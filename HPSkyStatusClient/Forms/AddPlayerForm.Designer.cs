namespace HPSkyStatusClient.Forms
{
    partial class AddPlayerForm
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
            lblMCUsername = new Label();
            btnAdd = new Button();
            txtUsername = new TextBox();
            SuspendLayout();
            // 
            // lblMCUsername
            // 
            lblMCUsername.AutoSize = true;
            lblMCUsername.Location = new Point(18, 17);
            lblMCUsername.Name = "lblMCUsername";
            lblMCUsername.Size = new Size(114, 15);
            lblMCUsername.TabIndex = 0;
            lblMCUsername.Text = "Minecraft Username";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 81);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(21, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 2;
            // 
            // AddPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUsername);
            Controls.Add(btnAdd);
            Controls.Add(lblMCUsername);
            Name = "AddPlayerForm";
            Text = "AddPlayerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMCUsername;
        private Button btnAdd;
        private TextBox txtUsername;
    }
}