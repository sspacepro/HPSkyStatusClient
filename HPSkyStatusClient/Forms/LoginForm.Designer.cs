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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtAdminKey = new TextBox();
            txtServerUrl = new TextBox();
            txtUsername = new ReaLTaiizor.Controls.CyberTextBox();
            btnRegister = new ReaLTaiizor.Controls.CyberButton();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            parrotGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAdminKey
            // 
            txtAdminKey.Location = new Point(30, 134);
            txtAdminKey.Name = "txtAdminKey";
            txtAdminKey.PlaceholderText = "Admin Key";
            txtAdminKey.Size = new Size(272, 23);
            txtAdminKey.TabIndex = 5;
            txtAdminKey.UseSystemPasswordChar = true;
            txtAdminKey.KeyDown += txtAdminKey1_KeyDown;
            // 
            // txtServerUrl
            // 
            txtServerUrl.Location = new Point(30, 163);
            txtServerUrl.Name = "txtServerUrl";
            txtServerUrl.PlaceholderText = "Server URL";
            txtServerUrl.Size = new Size(272, 23);
            txtServerUrl.TabIndex = 6;
            txtServerUrl.KeyDown += txtServerUrl_KeyDown;
            // 
            // txtUsername
            // 
            txtUsername.AccessibleName = "Username (Minecraft)";
            txtUsername.Alpha = 20;
            txtUsername.BackColor = Color.Transparent;
            txtUsername.Background_WidthPen = 5F;
            txtUsername.BackgroundPen = true;
            txtUsername.ColorBackground = Color.FromArgb(128, 255, 128);
            txtUsername.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtUsername.ColorLighting = Color.FromArgb(29, 200, 238);
            txtUsername.ColorPen_1 = Color.FromArgb(192, 0, 0);
            txtUsername.ColorPen_2 = Color.FromArgb(0, 0, 192);
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtUsername.Font = new Font("Arial", 10F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Lighting = false;
            txtUsername.LinearGradientPen = false;
            txtUsername.Location = new Point(12, 35);
            txtUsername.Name = "txtUsername";
            txtUsername.PenWidth = 15;
            txtUsername.RGB = true;
            txtUsername.Rounding = true;
            txtUsername.RoundingInt = 60;
            txtUsername.Size = new Size(305, 40);
            txtUsername.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtUsername.TabIndex = 7;
            txtUsername.Tag = "Cyber";
            txtUsername.TextButton = "";
            txtUsername.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtUsername.Timer_RGB = 50;
            // 
            // btnRegister
            // 
            btnRegister.Alpha = 20;
            btnRegister.BackColor = Color.Transparent;
            btnRegister.Background = true;
            btnRegister.Background_WidthPen = 6F;
            btnRegister.BackgroundPen = true;
            btnRegister.ColorBackground = Color.FromArgb(64, 0, 0);
            btnRegister.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnRegister.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnRegister.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnRegister.ColorLighting = Color.FromArgb(29, 200, 238);
            btnRegister.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnRegister.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnRegister.Effect_1 = true;
            btnRegister.Effect_1_ColorBackground = Color.Yellow;
            btnRegister.Effect_1_Transparency = 25;
            btnRegister.Effect_2 = true;
            btnRegister.Effect_2_ColorBackground = Color.Black;
            btnRegister.Effect_2_Transparency = 20;
            btnRegister.Font = new Font("Arial", 11F);
            btnRegister.ForeColor = Color.FromArgb(245, 245, 245);
            btnRegister.Lighting = false;
            btnRegister.LinearGradient_Background = false;
            btnRegister.LinearGradientPen = false;
            btnRegister.Location = new Point(12, 81);
            btnRegister.Name = "btnRegister";
            btnRegister.PenWidth = 15;
            btnRegister.RGB = true;
            btnRegister.Rounding = true;
            btnRegister.RoundingInt = 70;
            btnRegister.Size = new Size(305, 38);
            btnRegister.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnRegister.TabIndex = 8;
            btnRegister.Tag = "Cyber";
            btnRegister.TextButton = "Register";
            btnRegister.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnRegister.Timer_Effect_1 = 100;
            btnRegister.Timer_RGB = 50;
            btnRegister.Click += btnRegister_Click;
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.Black;
            parrotGradientPanel1.BottomRight = Color.Blue;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(dungeonHeaderLabel1);
            parrotGradientPanel1.Controls.Add(txtUsername);
            parrotGradientPanel1.Controls.Add(btnRegister);
            parrotGradientPanel1.Controls.Add(txtServerUrl);
            parrotGradientPanel1.Controls.Add(txtAdminKey);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(329, 128);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 9;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.Gold;
            parrotGradientPanel1.TopRight = Color.DarkRed;
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel1.ForeColor = Color.Black;
            dungeonHeaderLabel1.Location = new Point(81, 9);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(164, 20);
            dungeonHeaderLabel1.TabIndex = 9;
            dungeonHeaderLabel1.Text = "Username (Minecraft)";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(329, 128);
            Controls.Add(parrotGradientPanel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtAdminKey;
        private TextBox txtServerUrl;
        private ReaLTaiizor.Controls.CyberTextBox txtUsername;
        private ReaLTaiizor.Controls.CyberButton btnRegister;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
    }
}