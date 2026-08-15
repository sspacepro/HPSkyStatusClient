namespace HPSkyStatusClient.Forms
{
    partial class AddAuctionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuctionForm));
            txtItem = new TextBox();
            lstItems = new ListBox();
            btnAdd = new ReaLTaiizor.Controls.SkyButton();
            lblServerAdress = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            lblStars = new ReaLTaiizor.Controls.SkyLabel();
            chkRecomb = new ReaLTaiizor.Controls.SkyCheckBox();
            lblTier = new ReaLTaiizor.Controls.SkyLabel();
            cmbTier = new ReaLTaiizor.Controls.SkyComboBox();
            lblPetLevel = new ReaLTaiizor.Controls.SkyLabel();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            numPetLevel = new NumericUpDown();
            numStars = new NumericUpDown();
            numNotify = new NumericUpDown();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPetLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNotify).BeginInit();
            SuspendLayout();
            // 
            // txtItem
            // 
            txtItem.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtItem.Location = new Point(2, 22);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(191, 21);
            txtItem.TabIndex = 1;
            txtItem.TextChanged += txtItem_TextChanged;
            // 
            // lstItems
            // 
            lstItems.AccessibleName = "";
            lstItems.BackColor = Color.White;
            lstItems.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstItems.FormattingEnabled = true;
            lstItems.Location = new Point(2, 51);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(191, 121);
            lstItems.TabIndex = 13;
            lstItems.SelectedIndexChanged += lstItems_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.DownBGColorA = Color.FromArgb(107, 107, 107);
            btnAdd.DownBGColorB = Color.FromArgb(123, 123, 123);
            btnAdd.DownBorderColorA = Color.FromArgb(227, 195, 95);
            btnAdd.DownBorderColorB = Color.FromArgb(227, 195, 95);
            btnAdd.DownBorderColorC = Color.FromArgb(169, 128, 56);
            btnAdd.DownBorderColorD = Color.FromArgb(169, 128, 56);
            btnAdd.DownForeColor = Color.White;
            btnAdd.DownShadowForeColor = Color.FromArgb(53, 53, 53);
            btnAdd.Font = new Font("Minecraft", 8.25F);
            btnAdd.ForeColor = Color.White;
            btnAdd.HoverBGColorA = Color.FromArgb(107, 107, 107);
            btnAdd.HoverBGColorB = Color.FromArgb(123, 123, 123);
            btnAdd.HoverBorderColorA = Color.White;
            btnAdd.HoverBorderColorB = Color.White;
            btnAdd.HoverBorderColorC = Color.White;
            btnAdd.HoverBorderColorD = Color.White;
            btnAdd.HoverForeColor = Color.White;
            btnAdd.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnAdd.Location = new Point(2, 220);
            btnAdd.Name = "btnAdd";
            btnAdd.NormalBGColorA = Color.FromArgb(107, 107, 107);
            btnAdd.NormalBGColorB = Color.FromArgb(123, 123, 123);
            btnAdd.NormalBorderColorA = Color.DarkGray;
            btnAdd.NormalBorderColorB = Color.DarkGray;
            btnAdd.NormalBorderColorC = Color.Black;
            btnAdd.NormalBorderColorD = Color.Black;
            btnAdd.NormalForeColor = Color.White;
            btnAdd.NormalShadowForeColor = Color.FromArgb(53, 53, 53);
            btnAdd.Size = new Size(121, 23);
            btnAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblServerAdress
            // 
            lblServerAdress.AutoSize = true;
            lblServerAdress.BackColor = Color.Transparent;
            lblServerAdress.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServerAdress.ForeColor = SystemColors.ActiveCaptionText;
            lblServerAdress.Location = new Point(3, 175);
            lblServerAdress.Name = "lblServerAdress";
            lblServerAdress.Size = new Size(86, 13);
            lblServerAdress.TabIndex = 31;
            lblServerAdress.Text = "Notify Below";
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.BackColor = Color.Transparent;
            skyLabel1.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skyLabel1.ForeColor = SystemColors.ActiveCaptionText;
            skyLabel1.Location = new Point(2, 6);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(70, 13);
            skyLabel1.TabIndex = 32;
            skyLabel1.Text = "Item Name";
            // 
            // lblStars
            // 
            lblStars.AutoSize = true;
            lblStars.BackColor = Color.Transparent;
            lblStars.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStars.ForeColor = SystemColors.ActiveCaptionText;
            lblStars.Location = new Point(195, 22);
            lblStars.Name = "lblStars";
            lblStars.Size = new Size(94, 13);
            lblStars.TabIndex = 33;
            lblStars.Text = "Minimum stars";
            // 
            // chkRecomb
            // 
            chkRecomb.BackColor = Color.Black;
            chkRecomb.BoxBGColorA = Color.Red;
            chkRecomb.BoxBGColorB = Color.Transparent;
            chkRecomb.BoxBorderColorA = SystemColors.MenuHighlight;
            chkRecomb.BoxBorderColorB = SystemColors.HotTrack;
            chkRecomb.BoxBorderColorC = Color.Blue;
            chkRecomb.Checked = false;
            chkRecomb.CheckedColor = Color.FromArgb(220, 27, 94, 137);
            chkRecomb.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRecomb.ForeColor = Color.Black;
            chkRecomb.Location = new Point(195, 73);
            chkRecomb.Name = "chkRecomb";
            chkRecomb.Size = new Size(127, 14);
            chkRecomb.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            chkRecomb.TabIndex = 35;
            chkRecomb.Text = "Recombobulated";
            // 
            // lblTier
            // 
            lblTier.AutoSize = true;
            lblTier.BackColor = Color.Transparent;
            lblTier.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTier.ForeColor = SystemColors.ActiveCaptionText;
            lblTier.Location = new Point(195, 90);
            lblTier.Name = "lblTier";
            lblTier.Size = new Size(34, 13);
            lblTier.TabIndex = 36;
            lblTier.Text = "Tier";
            // 
            // cmbTier
            // 
            cmbTier.BackColor = Color.Transparent;
            cmbTier.BGColorA = Color.Transparent;
            cmbTier.BGColorB = SystemColors.MenuHighlight;
            cmbTier.BorderColorA = Color.FromArgb(192, 0, 0);
            cmbTier.BorderColorB = Color.Maroon;
            cmbTier.BorderColorC = Color.FromArgb(64, 0, 0);
            cmbTier.BorderColorD = Color.FromArgb(255, 128, 128);
            cmbTier.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTier.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTier.ForeColor = Color.Black;
            cmbTier.FormattingEnabled = true;
            cmbTier.ItemHeight = 16;
            cmbTier.ItemHighlightColor = Color.LightGreen;
            cmbTier.LineColorA = Color.FromArgb(192, 0, 0);
            cmbTier.LineColorB = Color.Maroon;
            cmbTier.LineColorC = Color.FromArgb(64, 0, 0);
            cmbTier.ListBackColor = Color.Transparent;
            cmbTier.ListBorderColor = Color.FromArgb(64, 0, 0);
            cmbTier.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            cmbTier.ListForeColor = Color.Black;
            cmbTier.ListSelectedBackColorA = SystemColors.MenuHighlight;
            cmbTier.ListSelectedBackColorB = Color.Transparent;
            cmbTier.Location = new Point(195, 106);
            cmbTier.Name = "cmbTier";
            cmbTier.Size = new Size(120, 22);
            cmbTier.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cmbTier.StartIndex = 0;
            cmbTier.TabIndex = 37;
            cmbTier.TriangleColorA = Color.FromArgb(192, 0, 0);
            cmbTier.TriangleColorB = Color.FromArgb(192, 0, 0);
            // 
            // lblPetLevel
            // 
            lblPetLevel.AutoSize = true;
            lblPetLevel.BackColor = Color.Transparent;
            lblPetLevel.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPetLevel.ForeColor = SystemColors.ActiveCaptionText;
            lblPetLevel.Location = new Point(195, 131);
            lblPetLevel.Name = "lblPetLevel";
            lblPetLevel.Size = new Size(117, 13);
            lblPetLevel.TabIndex = 38;
            lblPetLevel.Text = "Minimum Pet Level";
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.Brown;
            parrotGradientPanel1.BottomRight = Color.DarkBlue;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(btnAdd);
            parrotGradientPanel1.Controls.Add(numNotify);
            parrotGradientPanel1.Controls.Add(numStars);
            parrotGradientPanel1.Controls.Add(numPetLevel);
            parrotGradientPanel1.Controls.Add(cmbTier);
            parrotGradientPanel1.Controls.Add(lblStars);
            parrotGradientPanel1.Controls.Add(lblPetLevel);
            parrotGradientPanel1.Controls.Add(lblTier);
            parrotGradientPanel1.Controls.Add(lblServerAdress);
            parrotGradientPanel1.Controls.Add(chkRecomb);
            parrotGradientPanel1.Controls.Add(skyLabel1);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(327, 247);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 40;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.DarkRed;
            parrotGradientPanel1.TopRight = Color.DarkGreen;
            // 
            // numPetLevel
            // 
            numPetLevel.BackColor = SystemColors.MenuHighlight;
            numPetLevel.Location = new Point(195, 147);
            numPetLevel.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numPetLevel.Name = "numPetLevel";
            numPetLevel.Size = new Size(120, 23);
            numPetLevel.TabIndex = 40;
            // 
            // numStars
            // 
            numStars.BackColor = SystemColors.MenuHighlight;
            numStars.Location = new Point(195, 38);
            numStars.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numStars.Name = "numStars";
            numStars.Size = new Size(120, 23);
            numStars.TabIndex = 41;
            // 
            // numNotify
            // 
            numNotify.BackColor = SystemColors.MenuHighlight;
            numNotify.Location = new Point(0, 191);
            numNotify.Maximum = new decimal(new int[] { -1539607551, 11, 0, 0 });
            numNotify.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numNotify.Name = "numNotify";
            numNotify.Size = new Size(120, 23);
            numNotify.TabIndex = 42;
            numNotify.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddAuctionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 247);
            Controls.Add(lstItems);
            Controls.Add(txtItem);
            Controls.Add(parrotGradientPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddAuctionForm";
            Text = "AddAuctionForm";
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPetLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStars).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNotify).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtItem;
        private ListBox lstItems;
        private ReaLTaiizor.Controls.SkyButton btnAdd;
        private ReaLTaiizor.Controls.SkyLabel lblServerAdress;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.SkyLabel lblStars;
        private ReaLTaiizor.Controls.SkyCheckBox chkRecomb;
        private ReaLTaiizor.Controls.SkyLabel lblTier;
        private ReaLTaiizor.Controls.SkyComboBox cmbTier;
        private ReaLTaiizor.Controls.SkyLabel lblPetLevel;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private NumericUpDown numPetLevel;
        private NumericUpDown numStars;
        private NumericUpDown numNotify;
    }
}