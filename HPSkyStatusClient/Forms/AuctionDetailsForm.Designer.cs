namespace HPSkyStatusClient.Forms
{
    partial class AuctionDetailsForm
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
            lblItemName = new Label();
            lblLowestBin = new Label();
            lblNotifyBelow = new Label();
            txtLore = new RichTextBox();
            SuspendLayout();
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(0, 0);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(66, 15);
            lblItemName.TabIndex = 0;
            lblItemName.Text = "Item Name";
            // 
            // lblLowestBin
            // 
            lblLowestBin.AutoSize = true;
            lblLowestBin.Location = new Point(3, 16);
            lblLowestBin.Name = "lblLowestBin";
            lblLowestBin.Size = new Size(61, 15);
            lblLowestBin.TabIndex = 1;
            lblLowestBin.Text = "LowestBin";
            // 
            // lblNotifyBelow
            // 
            lblNotifyBelow.AutoSize = true;
            lblNotifyBelow.Location = new Point(5, 32);
            lblNotifyBelow.Name = "lblNotifyBelow";
            lblNotifyBelow.Size = new Size(72, 15);
            lblNotifyBelow.TabIndex = 2;
            lblNotifyBelow.Text = "NotifyBelow";
            // 
            // txtLore
            // 
            txtLore.Dock = DockStyle.Bottom;
            txtLore.Location = new Point(0, 50);
            txtLore.Name = "txtLore";
            txtLore.ReadOnly = true;
            txtLore.Size = new Size(342, 400);
            txtLore.TabIndex = 3;
            txtLore.Text = "";
            // 
            // AuctionDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 450);
            Controls.Add(txtLore);
            Controls.Add(lblNotifyBelow);
            Controls.Add(lblLowestBin);
            Controls.Add(lblItemName);
            Name = "AuctionDetailsForm";
            Text = "AuctionDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemName;
        private Label lblLowestBin;
        private Label lblNotifyBelow;
        private RichTextBox txtLore;
    }
}