namespace HPSkyStatusClient.Forms
{
    partial class LoginForm
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
            txtUsername = new TextBox();
            btnRegister = new Button();
            txtAdminKey = new TextBox();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(34, 59);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(34, 88);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 32);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtAdminKey
            // 
            txtAdminKey.Location = new Point(34, 126);
            txtAdminKey.Name = "txtAdminKey";
            txtAdminKey.PlaceholderText = "Admin Key";
            txtAdminKey.Size = new Size(272, 23);
            txtAdminKey.TabIndex = 5;
            txtAdminKey.UseSystemPasswordChar = true;
            txtAdminKey.KeyDown += txtAdminKey1_KeyDown;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAdminKey);
            Controls.Add(btnRegister);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Button btnRegister;
        private TextBox txtAdminKey;
    }
}