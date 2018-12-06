namespace WindowsFormsApp.Views
{
    partial class UserListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.updateRowButton = new System.Windows.Forms.ToolStripButton();
            this.changeUserRole = new System.Windows.Forms.ToolStripSplitButton();
            this.promoteToAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.promoteToUser = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.sortButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.firstNameSortButton = new System.Windows.Forms.ToolStripMenuItem();
            this.accountRegisteredSortButton = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logoutButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNav)).BeginInit();
            this.bindingNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 35);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(1158, 406);
            this.dataGridView.TabIndex = 0;
            //this.dataGridView.Columns["Password"].Visible = false;
            //this.dataGridView.Columns["UserId"].Visible = false;
            //this.dataGridView.Columns["DateOfBirth"].Visible = false;
            //this.dataGridView.Columns["AccountRegistered"].Visible = false;
            // 
            // bindingNav
            // 
            this.bindingNav.AddNewItem = null;
            this.bindingNav.CountItem = null;
            this.bindingNav.DeleteItem = null;
            this.bindingNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateRowButton,
            this.changeUserRole,
            this.deleteButton,
            this.sortButton});
            this.bindingNav.Location = new System.Drawing.Point(0, 0);
            this.bindingNav.MoveFirstItem = null;
            this.bindingNav.MoveLastItem = null;
            this.bindingNav.MoveNextItem = null;
            this.bindingNav.MovePreviousItem = null;
            this.bindingNav.Name = "bindingNav";
            this.bindingNav.PositionItem = null;
            this.bindingNav.Size = new System.Drawing.Size(1182, 27);
            this.bindingNav.TabIndex = 1;
            this.bindingNav.Visible = false;
            // 
            // updateRowButton
            // 
            this.updateRowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateRowButton.Image = ((System.Drawing.Image)(resources.GetObject("updateRowButton.Image")));
            this.updateRowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateRowButton.Name = "updateRowButton";
            this.updateRowButton.Size = new System.Drawing.Size(62, 24);
            this.updateRowButton.Text = "Update";
            this.updateRowButton.Click += new System.EventHandler(this.updateRowButton_Click);
            // 
            // changeUserRole
            // 
            this.changeUserRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeUserRole.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promoteToAdmin,
            this.promoteToUser});
            this.changeUserRole.Image = ((System.Drawing.Image)(resources.GetObject("changeUserRole.Image")));
            this.changeUserRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeUserRole.Name = "changeUserRole";
            this.changeUserRole.Size = new System.Drawing.Size(145, 24);
            this.changeUserRole.Text = "Change User Role";
            this.changeUserRole.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // promoteToAdmin
            // 
            this.promoteToAdmin.Name = "promoteToAdmin";
            this.promoteToAdmin.Size = new System.Drawing.Size(128, 26);
            this.promoteToAdmin.Text = "Admin";
            this.promoteToAdmin.Click += new System.EventHandler(this.promoteToAdmin_Click);
            // 
            // promoteToUser
            // 
            this.promoteToUser.Name = "promoteToUser";
            this.promoteToUser.Size = new System.Drawing.Size(128, 26);
            this.promoteToUser.Text = "User";
            this.promoteToUser.Click += new System.EventHandler(this.promoteToUser_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(57, 24);
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstNameSortButton,
            this.accountRegisteredSortButton});
            this.sortButton.Image = ((System.Drawing.Image)(resources.GetObject("sortButton.Image")));
            this.sortButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(70, 24);
            this.sortButton.Text = "Sort by";
            // 
            // firstNameSortButton
            // 
            this.firstNameSortButton.Name = "firstNameSortButton";
            this.firstNameSortButton.Size = new System.Drawing.Size(209, 26);
            this.firstNameSortButton.Text = "First name";
            this.firstNameSortButton.Click += new System.EventHandler(this.firstNameSortButton_Click);
            // 
            // accountRegisteredSortButton
            // 
            this.accountRegisteredSortButton.Name = "accountRegisteredSortButton";
            this.accountRegisteredSortButton.Size = new System.Drawing.Size(209, 26);
            this.accountRegisteredSortButton.Text = "Account registered";
            this.accountRegisteredSortButton.Click += new System.EventHandler(this.accountRegisteredSortButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.Location = new System.Drawing.Point(1050, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(120, 28);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(897, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(109, 25);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 453);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bindingNav);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserList";
            this.Load += new System.EventHandler(this.UserListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNav)).EndInit();
            this.bindingNav.ResumeLayout(false);
            this.bindingNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingNavigator bindingNav;
        private System.Windows.Forms.ToolStripButton updateRowButton;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripSplitButton changeUserRole;
        private System.Windows.Forms.ToolStripMenuItem promoteToAdmin;
        private System.Windows.Forms.ToolStripMenuItem promoteToUser;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ToolStripDropDownButton sortButton;
        private System.Windows.Forms.ToolStripMenuItem firstNameSortButton;
        private System.Windows.Forms.ToolStripMenuItem accountRegisteredSortButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

