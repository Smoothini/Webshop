namespace ShopFormsClient
{
    partial class MainWindow
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.orderTab = new System.Windows.Forms.TabPage();
            this.userTab = new System.Windows.Forms.TabPage();
            this.productTab = new System.Windows.Forms.TabPage();
            this.categoryTab = new System.Windows.Forms.TabPage();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.userTab);
            this.tabs.Controls.Add(this.orderTab);
            this.tabs.Controls.Add(this.productTab);
            this.tabs.Controls.Add(this.categoryTab);
            this.tabs.Location = new System.Drawing.Point(13, 13);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(683, 442);
            this.tabs.TabIndex = 0;
            // 
            // orderTab
            // 
            this.orderTab.Location = new System.Drawing.Point(4, 22);
            this.orderTab.Name = "orderTab";
            this.orderTab.Padding = new System.Windows.Forms.Padding(3);
            this.orderTab.Size = new System.Drawing.Size(586, 320);
            this.orderTab.TabIndex = 0;
            this.orderTab.Text = "Orders";
            this.orderTab.UseVisualStyleBackColor = true;
            // 
            // userTab
            // 
            this.userTab.Location = new System.Drawing.Point(4, 22);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(3);
            this.userTab.Size = new System.Drawing.Size(675, 416);
            this.userTab.TabIndex = 1;
            this.userTab.Text = "Users";
            this.userTab.UseVisualStyleBackColor = true;
            // 
            // productTab
            // 
            this.productTab.Location = new System.Drawing.Point(4, 22);
            this.productTab.Name = "productTab";
            this.productTab.Size = new System.Drawing.Size(586, 320);
            this.productTab.TabIndex = 2;
            this.productTab.Text = "Products";
            this.productTab.UseVisualStyleBackColor = true;
            // 
            // categoryTab
            // 
            this.categoryTab.Location = new System.Drawing.Point(4, 22);
            this.categoryTab.Name = "categoryTab";
            this.categoryTab.Size = new System.Drawing.Size(586, 320);
            this.categoryTab.TabIndex = 3;
            this.categoryTab.Text = "Categories";
            this.categoryTab.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 467);
            this.Controls.Add(this.tabs);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage userTab;
        private System.Windows.Forms.TabPage orderTab;
        private System.Windows.Forms.TabPage productTab;
        private System.Windows.Forms.TabPage categoryTab;
    }
}