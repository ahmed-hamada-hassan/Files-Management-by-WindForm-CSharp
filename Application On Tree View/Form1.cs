using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Application_On_Tree_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAddNewFolders_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbAddFolders.Text))
            {
                if (treeView1.SelectedNode == null)
                {
                    
                    TreeNode NewNode = treeView1.Nodes.Add(tbAddFolders.Text);
                    NewNode.ImageIndex = 0;
                    NewNode.SelectedImageIndex = 2;
                    UpdateProgressBarPercentage();
                }
                else
                {
                    TreeNode CurrentNode = treeView1.SelectedNode;

                    if (CurrentNode != null && !string.IsNullOrWhiteSpace(tbAddFolders.Text) && CurrentNode.ImageIndex != 1) 
                    {
                        TreeNode NewFolder = CurrentNode.Nodes.Add(tbAddFolders.Text);
                        NewFolder.ImageIndex = 0;
                        NewFolder.SelectedImageIndex = 2;
                        CurrentNode.Expand();
                        UpdateProgressBarPercentage();
                    }
                    else
                    {
                        MessageBox.Show("The Folder Must have name not white spaces and Must not Add Folder in File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                

            }

            else
            {
                MessageBox.Show("The Folder Must have name not white spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnAddNewFile_Click(object sender, EventArgs e)
        {
            TreeNode CurrentNode = treeView1.SelectedNode;

            if (CurrentNode != null && !string.IsNullOrWhiteSpace(tbAddNewFile.Text) && CurrentNode.ImageIndex != 1) 
            {
                TreeNode NewFile = CurrentNode.Nodes.Add(tbAddNewFile.Text);
                NewFile.ImageIndex = 1;
                NewFile.SelectedImageIndex = 1;
                CurrentNode.Expand();
                UpdateProgressBarPercentage();
            }
            else
            {
                MessageBox.Show("The File Must have name not white spaces and Must not Add File in File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

      
        private void DeletingNode()
        {
            TreeNode selectednode = treeView1.SelectedNode;

            if(selectednode != null)
            {
                if(selectednode.SelectedImageIndex==6||selectednode.SelectedImageIndex==3)
                {
                    MessageBox.Show("Don't allowed to delete this files or folders","Deleting System's Folder",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var Confirm = MessageBox.Show("Are you sure from deleting this ? ", "Conform Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(Confirm == DialogResult.Yes)
                {
                    selectednode.Remove();
                    UpdateProgressBarPercentage();
                }
            }
            else
            {
                MessageBox.Show("Please select a thing to delete","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletingNode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = null;
        }

        private int CalculateAllNodesInTheTreeNode(TreeNodeCollection node)
        {
            int Counter = 0;
            foreach (TreeNode child in node)
            {
                Counter++;
                if(child.Nodes.Count > 0)
                {
                    Counter += CalculateAllNodesInTheTreeNode(child.Nodes);
                }
            }

            return Counter;
        }

        private void UpdateProgressBarPercentage()
        {
            int Folders = CalculateAllNodesInTheTreeNode(treeView1.Nodes);

            if(Folders > progressBar1.Maximum)
            {
                lbCurrentStorage.Text = "Full 128 GB";
                progressBar1.Value = progressBar1.Maximum;
                return;
            }
            
            if(Folders == 5)
            {
                lbCurrentStorage.Text = "16 GB";
                progressBar1.Value = 16;
                return;
            }

            int Percentage = (int)(((float)Folders / (float)progressBar1.Maximum) * 100);
            lbCurrentStorage.Text = $"{16 + Percentage} GB";
            progressBar1.Value = (int)Percentage;
        }

        
    }
}
