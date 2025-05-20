namespace Application_On_Tree_View
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("File1", 4, 3);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("File2", 4, 3);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("File3", 4, 3);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Program", 5, 6, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Phone\'s Files", 5, 6, new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbMyFiles = new System.Windows.Forms.Label();
            this.tbAddFolders = new System.Windows.Forms.TextBox();
            this.btnAddNewFolders = new System.Windows.Forms.Button();
            this.tbAddNewFile = new System.Windows.Forms.TextBox();
            this.btnAddNewFile = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.lbStorage = new System.Windows.Forms.Label();
            this.lbCurrentStorage = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbTotalStorage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 57);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 4;
            treeNode1.Name = "Node2";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "File1";
            treeNode2.ImageIndex = 4;
            treeNode2.Name = "Node3";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "File2";
            treeNode3.ImageIndex = 4;
            treeNode3.Name = "Node4";
            treeNode3.SelectedImageIndex = 3;
            treeNode3.Text = "File3";
            treeNode4.ImageIndex = 5;
            treeNode4.Name = "Node1";
            treeNode4.SelectedImageIndex = 6;
            treeNode4.Text = "Program";
            treeNode5.ImageIndex = 5;
            treeNode5.Name = "Node0";
            treeNode5.SelectedImageIndex = 6;
            treeNode5.Text = "Phone\'s Files";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(399, 667);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "google-docs.png");
            this.imageList1.Images.SetKeyName(2, "open-folder.png");
            this.imageList1.Images.SetKeyName(3, "paper.png");
            this.imageList1.Images.SetKeyName(4, "documents.png");
            this.imageList1.Images.SetKeyName(5, "data-encryption.png");
            this.imageList1.Images.SetKeyName(6, "folders.png");
            // 
            // lbMyFiles
            // 
            this.lbMyFiles.BackColor = System.Drawing.Color.Silver;
            this.lbMyFiles.Location = new System.Drawing.Point(12, 9);
            this.lbMyFiles.Name = "lbMyFiles";
            this.lbMyFiles.Size = new System.Drawing.Size(399, 29);
            this.lbMyFiles.TabIndex = 1;
            this.lbMyFiles.Text = "My Files";
            this.lbMyFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAddFolders
            // 
            this.tbAddFolders.Location = new System.Drawing.Point(477, 102);
            this.tbAddFolders.MaxLength = 32;
            this.tbAddFolders.Name = "tbAddFolders";
            this.tbAddFolders.Size = new System.Drawing.Size(384, 34);
            this.tbAddFolders.TabIndex = 2;
            // 
            // btnAddNewFolders
            // 
            this.btnAddNewFolders.Location = new System.Drawing.Point(477, 169);
            this.btnAddNewFolders.Name = "btnAddNewFolders";
            this.btnAddNewFolders.Size = new System.Drawing.Size(384, 45);
            this.btnAddNewFolders.TabIndex = 3;
            this.btnAddNewFolders.Text = "Add New Folder";
            this.btnAddNewFolders.UseVisualStyleBackColor = true;
            this.btnAddNewFolders.Click += new System.EventHandler(this.btnAddNewFolders_Click);
            // 
            // tbAddNewFile
            // 
            this.tbAddNewFile.Location = new System.Drawing.Point(883, 102);
            this.tbAddNewFile.MaxLength = 32;
            this.tbAddNewFile.Name = "tbAddNewFile";
            this.tbAddNewFile.Size = new System.Drawing.Size(384, 34);
            this.tbAddNewFile.TabIndex = 5;
            // 
            // btnAddNewFile
            // 
            this.btnAddNewFile.Location = new System.Drawing.Point(883, 169);
            this.btnAddNewFile.Name = "btnAddNewFile";
            this.btnAddNewFile.Size = new System.Drawing.Size(384, 45);
            this.btnAddNewFile.TabIndex = 6;
            this.btnAddNewFile.Text = "Add New File";
            this.btnAddNewFile.UseVisualStyleBackColor = true;
            this.btnAddNewFile.Click += new System.EventHandler(this.btnAddNewFile_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(477, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(384, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.Transparent;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExist.Location = new System.Drawing.Point(883, 270);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(384, 45);
            this.btnExist.TabIndex = 10;
            this.btnExist.Text = "back";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbStorage
            // 
            this.lbStorage.Location = new System.Drawing.Point(708, 391);
            this.lbStorage.Name = "lbStorage";
            this.lbStorage.Size = new System.Drawing.Size(322, 60);
            this.lbStorage.TabIndex = 11;
            this.lbStorage.Text = "Storage";
            this.lbStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCurrentStorage
            // 
            this.lbCurrentStorage.BackColor = System.Drawing.Color.Transparent;
            this.lbCurrentStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCurrentStorage.ForeColor = System.Drawing.Color.Black;
            this.lbCurrentStorage.Location = new System.Drawing.Point(769, 475);
            this.lbCurrentStorage.Name = "lbCurrentStorage";
            this.lbCurrentStorage.Size = new System.Drawing.Size(92, 60);
            this.lbCurrentStorage.TabIndex = 12;
            this.lbCurrentStorage.Text = "16 GB";
            this.lbCurrentStorage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(682, 573);
            this.progressBar1.MarqueeAnimationSpeed = 128;
            this.progressBar1.Maximum = 128;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(390, 47);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Value = 16;
            // 
            // lbTotalStorage
            // 
            this.lbTotalStorage.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotalStorage.ForeColor = System.Drawing.Color.Black;
            this.lbTotalStorage.Location = new System.Drawing.Point(855, 475);
            this.lbTotalStorage.Name = "lbTotalStorage";
            this.lbTotalStorage.Size = new System.Drawing.Size(113, 60);
            this.lbTotalStorage.TabIndex = 14;
            this.lbTotalStorage.Text = "/ 128 GB";
            this.lbTotalStorage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 736);
            this.Controls.Add(this.lbTotalStorage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbCurrentStorage);
            this.Controls.Add(this.lbStorage);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNewFile);
            this.Controls.Add(this.tbAddNewFile);
            this.Controls.Add(this.btnAddNewFolders);
            this.Controls.Add(this.tbAddFolders);
            this.Controls.Add(this.lbMyFiles);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folders Managment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lbMyFiles;
        private System.Windows.Forms.TextBox tbAddFolders;
        private System.Windows.Forms.Button btnAddNewFolders;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox tbAddNewFile;
        private System.Windows.Forms.Button btnAddNewFile;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Label lbStorage;
        private System.Windows.Forms.Label lbCurrentStorage;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbTotalStorage;
    }
}

