namespace ShopFormsClient
{
    partial class OrderWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ordersBox = new System.Windows.Forms.ListBox();
            this.isDelivered = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.markDeliveredButton = new System.Windows.Forms.Button();
            this.removeOrderButton = new System.Windows.Forms.Button();
            this.orderItems = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderItems);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.ordersBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.userLabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.addressLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Orders";
            // 
            // ordersBox
            // 
            this.ordersBox.FormattingEnabled = true;
            this.ordersBox.Location = new System.Drawing.Point(6, 38);
            this.ordersBox.Name = "ordersBox";
            this.ordersBox.Size = new System.Drawing.Size(104, 186);
            this.ordersBox.TabIndex = 0;
            this.ordersBox.SelectedIndexChanged += new System.EventHandler(this.ordersBox_SelectedIndexChanged);
            // 
            // isDelivered
            // 
            this.isDelivered.AutoSize = true;
            this.isDelivered.Location = new System.Drawing.Point(116, 22);
            this.isDelivered.Name = "isDelivered";
            this.isDelivered.Size = new System.Drawing.Size(71, 17);
            this.isDelivered.TabIndex = 6;
            this.isDelivered.Text = "Delivered";
            this.isDelivered.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusLabel);
            this.groupBox3.Controls.Add(this.refreshButton);
            this.groupBox3.Controls.Add(this.markDeliveredButton);
            this.groupBox3.Controls.Add(this.isDelivered);
            this.groupBox3.Controls.Add(this.removeOrderButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 166);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(6, 45);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(104, 23);
            this.refreshButton.TabIndex = 18;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(179, 133);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 15;
            this.dateLabel.Text = "today";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Date";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(179, 111);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(13, 13);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total price";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(116, 87);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(28, 13);
            this.addressLabel.TabIndex = 11;
            this.addressLabel.Text = "addr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Address";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(116, 51);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(27, 13);
            this.userLabel.TabIndex = 9;
            this.userLabel.Text = "user";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "User";
            // 
            // markDeliveredButton
            // 
            this.markDeliveredButton.Location = new System.Drawing.Point(6, 19);
            this.markDeliveredButton.Name = "markDeliveredButton";
            this.markDeliveredButton.Size = new System.Drawing.Size(104, 23);
            this.markDeliveredButton.TabIndex = 7;
            this.markDeliveredButton.Text = "Mark delivered";
            this.markDeliveredButton.UseVisualStyleBackColor = true;
            this.markDeliveredButton.Click += new System.EventHandler(this.markDeliveredButton_Click);
            // 
            // removeOrderButton
            // 
            this.removeOrderButton.Location = new System.Drawing.Point(323, 137);
            this.removeOrderButton.Name = "removeOrderButton";
            this.removeOrderButton.Size = new System.Drawing.Size(104, 23);
            this.removeOrderButton.TabIndex = 0;
            this.removeOrderButton.Text = "Remove order";
            this.removeOrderButton.UseVisualStyleBackColor = true;
            this.removeOrderButton.Click += new System.EventHandler(this.removeOrderButton_Click);
            // 
            // orderItems
            // 
            this.orderItems.Enabled = false;
            this.orderItems.Location = new System.Drawing.Point(112, 204);
            this.orderItems.Name = "orderItems";
            this.orderItems.Size = new System.Drawing.Size(313, 20);
            this.orderItems.TabIndex = 16;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 142);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 19;
            // 
            // OrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 426);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderWindow";
            this.Text = "OrderWindow";
            this.Load += new System.EventHandler(this.OrderWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ordersBox;
        private System.Windows.Forms.CheckBox isDelivered;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button markDeliveredButton;
        private System.Windows.Forms.Button removeOrderButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox orderItems;
        private System.Windows.Forms.Label statusLabel;
    }
}