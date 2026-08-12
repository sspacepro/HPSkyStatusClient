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
            lblItemName = new Label();
            txtItem = new TextBox();
            lblTier = new Label();
            cmbTier = new ComboBox();
            lblStars = new Label();
            numStars = new NumericUpDown();
            chkRecomb = new CheckBox();
            lblPetLevel = new Label();
            numPetLevel = new NumericUpDown();
            lblNotifyBelow = new Label();
            numNotify = new NumericUpDown();
            btnAdd = new Button();
            lstItems = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numStars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPetLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNotify).BeginInit();
            SuspendLayout();
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(0, -1);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(66, 15);
            lblItemName.TabIndex = 0;
            lblItemName.Text = "Item Name";
            // 
            // txtItem
            // 
            txtItem.Location = new Point(2, 16);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(194, 23);
            txtItem.TabIndex = 1;
            txtItem.TextChanged += txtItem_TextChanged;
            // 
            // lblTier
            // 
            lblTier.AutoSize = true;
            lblTier.Location = new Point(202, 86);
            lblTier.Name = "lblTier";
            lblTier.Size = new Size(27, 15);
            lblTier.TabIndex = 2;
            lblTier.Text = "Tier";
            // 
            // cmbTier
            // 
            cmbTier.FormattingEnabled = true;
            cmbTier.Location = new Point(199, 104);
            cmbTier.Name = "cmbTier";
            cmbTier.Size = new Size(121, 23);
            cmbTier.TabIndex = 3;
            cmbTier.Text = "(Optional)";
            // 
            // lblStars
            // 
            lblStars.AutoSize = true;
            lblStars.Location = new Point(199, 17);
            lblStars.Name = "lblStars";
            lblStars.Size = new Size(87, 15);
            lblStars.TabIndex = 4;
            lblStars.Text = "Minimum stars";
            // 
            // numStars
            // 
            numStars.Location = new Point(199, 35);
            numStars.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numStars.Name = "numStars";
            numStars.Size = new Size(120, 23);
            numStars.TabIndex = 5;
            // 
            // chkRecomb
            // 
            chkRecomb.AutoSize = true;
            chkRecomb.Location = new Point(202, 64);
            chkRecomb.Name = "chkRecomb";
            chkRecomb.Size = new Size(117, 19);
            chkRecomb.TabIndex = 6;
            chkRecomb.Text = "Recombobulated";
            chkRecomb.UseVisualStyleBackColor = true;
            // 
            // lblPetLevel
            // 
            lblPetLevel.AutoSize = true;
            lblPetLevel.Location = new Point(202, 130);
            lblPetLevel.Name = "lblPetLevel";
            lblPetLevel.Size = new Size(110, 15);
            lblPetLevel.TabIndex = 7;
            lblPetLevel.Text = "Minimum Pet Level";
            // 
            // numPetLevel
            // 
            numPetLevel.Location = new Point(200, 152);
            numPetLevel.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numPetLevel.Name = "numPetLevel";
            numPetLevel.Size = new Size(120, 23);
            numPetLevel.TabIndex = 8;
            // 
            // lblNotifyBelow
            // 
            lblNotifyBelow.AutoSize = true;
            lblNotifyBelow.Location = new Point(2, 178);
            lblNotifyBelow.Name = "lblNotifyBelow";
            lblNotifyBelow.Size = new Size(75, 15);
            lblNotifyBelow.TabIndex = 9;
            lblNotifyBelow.Text = "Notify Below";
            // 
            // numNotify
            // 
            numNotify.Location = new Point(2, 196);
            numNotify.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numNotify.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numNotify.Name = "numNotify";
            numNotify.Size = new Size(120, 23);
            numNotify.TabIndex = 10;
            numNotify.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(2, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstItems
            // 
            lstItems.AccessibleName = "";
            lstItems.FormattingEnabled = true;
            lstItems.Location = new Point(2, 51);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(194, 124);
            lstItems.TabIndex = 13;
            lstItems.SelectedIndexChanged += lstItems_SelectedIndexChanged;
            // 
            // AddAuctionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 251);
            Controls.Add(lstItems);
            Controls.Add(btnAdd);
            Controls.Add(numNotify);
            Controls.Add(lblNotifyBelow);
            Controls.Add(numPetLevel);
            Controls.Add(lblPetLevel);
            Controls.Add(chkRecomb);
            Controls.Add(numStars);
            Controls.Add(lblStars);
            Controls.Add(cmbTier);
            Controls.Add(lblTier);
            Controls.Add(txtItem);
            Controls.Add(lblItemName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddAuctionForm";
            Text = "AddAuctionForm";
            ((System.ComponentModel.ISupportInitialize)numStars).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPetLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNotify).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemName;
        private TextBox txtItem;
        private Label lblTier;
        private ComboBox cmbTier;
        private Label lblStars;
        private NumericUpDown numStars;
        private CheckBox chkRecomb;
        private Label lblPetLevel;
        private NumericUpDown numPetLevel;
        private Label lblNotifyBelow;
        private NumericUpDown numNotify;
        private Button btnAdd;
        private ListBox lstItems;
    }
}