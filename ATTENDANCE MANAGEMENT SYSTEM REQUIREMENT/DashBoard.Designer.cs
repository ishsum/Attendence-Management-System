namespace ATTENDANCE_MANAGEMENT_SYSTEM_REQUIREMENT
{
    partial class DashBoard
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Update Profile");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Profile Management", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Class");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Subject");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Time Table");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Facility Management", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Mark Attendence");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Attendence Report");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Attendence Managemnt", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Admin");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Faculty");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Student");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("User Management", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView4 = new System.Windows.Forms.TreeView();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.MenuList = new System.Windows.Forms.TreeView();
            this.adminpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(86, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScrollMargin = new System.Drawing.Size(4, 4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.treeView4);
            this.splitContainer1.Panel1.Controls.Add(this.treeView3);
            this.splitContainer1.Panel1.Controls.Add(this.treeView2);
            this.splitContainer1.Panel1.Controls.Add(this.MenuList);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.adminpanel);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 632);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Attendence Managemnt System";
            // 
            // treeView4
            // 
            this.treeView4.Location = new System.Drawing.Point(16, 471);
            this.treeView4.Name = "treeView4";
            treeNode1.Name = "Update Profile";
            treeNode1.Text = "Update Profile";
            treeNode2.Name = "Profile Management";
            treeNode2.Text = "Profile Management";
            this.treeView4.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView4.Size = new System.Drawing.Size(224, 102);
            this.treeView4.TabIndex = 3;
            // 
            // treeView3
            // 
            this.treeView3.Location = new System.Drawing.Point(16, 218);
            this.treeView3.Name = "treeView3";
            treeNode3.Name = "Class";
            treeNode3.Text = "Class";
            treeNode4.Name = "Subject";
            treeNode4.Text = "Subject";
            treeNode5.Name = "Time Table";
            treeNode5.Text = "Time Table";
            treeNode6.Name = "Faciltiy Management";
            treeNode6.Text = "Facility Management";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView3.Size = new System.Drawing.Size(224, 102);
            this.treeView3.TabIndex = 2;
            this.treeView3.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView3_AfterSelect);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(16, 340);
            this.treeView2.Name = "treeView2";
            treeNode7.Name = "Mark Attendence";
            treeNode7.Text = "Mark Attendence";
            treeNode8.Name = "Attendence Report";
            treeNode8.Text = "Attendence Report";
            treeNode9.Name = "Attendence Managemnt";
            treeNode9.Text = "Attendence Managemnt";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView2.Size = new System.Drawing.Size(224, 102);
            this.treeView2.TabIndex = 1;
            // 
            // MenuList
            // 
            this.MenuList.Location = new System.Drawing.Point(16, 83);
            this.MenuList.Name = "MenuList";
            treeNode10.BackColor = System.Drawing.Color.LightBlue;
            treeNode10.Name = "Admin";
            treeNode10.Tag = "Data Source=.;Initial Catalog=MASD;Integrated Security=True";
            treeNode10.Text = "Admin";
            treeNode10.ToolTipText = "Admin";
            treeNode11.BackColor = System.Drawing.Color.DeepSkyBlue;
            treeNode11.Name = "Faculty";
            treeNode11.Text = "Faculty";
            treeNode12.BackColor = System.Drawing.Color.DodgerBlue;
            treeNode12.Name = "Student";
            treeNode12.Text = "Student";
            treeNode13.BackColor = System.Drawing.Color.SteelBlue;
            treeNode13.Name = "User Management";
            treeNode13.Text = "User Management";
            this.MenuList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.MenuList.Size = new System.Drawing.Size(224, 102);
            this.MenuList.TabIndex = 0;
            this.MenuList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // adminpanel
            // 
            this.adminpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminpanel.Location = new System.Drawing.Point(14, 83);
            this.adminpanel.Name = "adminpanel";
            this.adminpanel.Size = new System.Drawing.Size(498, 237);
            this.adminpanel.TabIndex = 2;
            this.adminpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.adminpanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            // 
            // adminBindingSource1
            // 
            this.adminBindingSource1.DataMember = "Admin";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 592);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView MenuList;
        private System.Windows.Forms.TreeView treeView4;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private MASDDataSet mASDDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private MASDDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.Panel adminpanel;
       private MASDDataSet1 mASDDataSet1;
        private System.Windows.Forms.BindingSource adminBindingSource1;
        private MASDDataSet1TableAdapters.AdminTableAdapter adminTableAdapter1;
    }
}