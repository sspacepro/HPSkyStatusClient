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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuctionDetailsForm));
            lblItemName = new Label();
            lblLowestBin = new Label();
            lblNotifyBelow = new Label();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            txtLore = new RichTextBox();
            parrotGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemName.Location = new Point(0, 9);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(70, 13);
            lblItemName.TabIndex = 0;
            lblItemName.Text = "Item Name";
            // 
            // lblLowestBin
            // 
            lblLowestBin.AutoSize = true;
            lblLowestBin.BackColor = Color.Transparent;
            lblLowestBin.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowestBin.Location = new Point(3, 26);
            lblLowestBin.Name = "lblLowestBin";
            lblLowestBin.Size = new Size(72, 13);
            lblLowestBin.TabIndex = 1;
            lblLowestBin.Text = "LowestBin";
            // 
            // lblNotifyBelow
            // 
            lblNotifyBelow.AutoSize = true;
            lblNotifyBelow.BackColor = Color.Transparent;
            lblNotifyBelow.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotifyBelow.Location = new Point(3, 41);
            lblNotifyBelow.Name = "lblNotifyBelow";
            lblNotifyBelow.Size = new Size(83, 13);
            lblNotifyBelow.TabIndex = 2;
            lblNotifyBelow.Text = "NotifyBelow";
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.DarkGreen;
            parrotGradientPanel1.BottomRight = Color.Maroon;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(txtLore);
            parrotGradientPanel1.Controls.Add(lblNotifyBelow);
            parrotGradientPanel1.Controls.Add(lblItemName);
            parrotGradientPanel1.Controls.Add(lblLowestBin);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(342, 577);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 5;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.Maroon;
            parrotGradientPanel1.TopRight = Color.Blue;
            // 
            // txtLore
            // 
            txtLore.BackColor = Color.White;
            txtLore.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLore.Location = new Point(0, 57);
            txtLore.Name = "txtLore";
            txtLore.Size = new Size(342, 532);
            txtLore.TabIndex = 3;
            txtLore.Text = "";
            // 
            // AuctionDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(342, 577);
            Controls.Add(parrotGradientPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AuctionDetailsForm";
            Text = "AuctionDetailsForm";
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblItemName;
        private Label lblLowestBin;
        private Label lblNotifyBelow;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private RichTextBox txtLore;
    }
}