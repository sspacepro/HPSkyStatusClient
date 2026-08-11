namespace HPSkyStatusClient;

using ReaLTaiizor;
partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pgAdmin = new TabPage();
        btnBackup = new Button();
        btnStatus = new Button();
        txtUpdateApiKey = new TextBox();
        btnShutdownServer = new Button();
        grpUsers = new GroupBox();
        txtNotificationMessage = new RichTextBox();
        aloneTextBox1 = new ReaLTaiizor.Controls.AloneTextBox();
        btnSendNotification = new Button();
        radNotificationSelected = new RadioButton();
        radNotificationEveryone = new RadioButton();
        lblNotificationMessage = new Label();
        txtNotificationTitle = new TextBox();
        lblNotificationTitle = new Label();
        numPurgeInactive = new NumericUpDown();
        btnPurgeInactive = new Button();
        btnDelete = new Button();
        btnUnblock = new Button();
        btnBlock = new Button();
        lvUsers = new ListView();
        clmUsername = new ColumnHeader();
        clmBlocked = new ColumnHeader();
        clmLastRequest = new ColumnHeader();
        btnRefreshUsers = new Button();
        grpCleanup = new GroupBox();
        numWatchExpiration = new NumericUpDown();
        lblWatchExpiration = new Label();
        numWatchCleanupInterval = new NumericUpDown();
        lblWatchCleanupInterval = new Label();
        grpClientLimits = new GroupBox();
        numMaxPlayerRequestsPerMinute = new NumericUpDown();
        lblMaxPlayerRequestsPerMinute = new Label();
        numMaxAuctionWatches = new NumericUpDown();
        lblMaxAuctionWatches = new Label();
        grpServerSettings = new GroupBox();
        numItemCacheUpdateMinutes = new NumericUpDown();
        lblItemCacheUpdateMinutes = new Label();
        numAuctionCheckInterval = new NumericUpDown();
        lblAuctionCheckInterval = new Label();
        numAuctionCacheRefresh = new NumericUpDown();
        lblAuctionCacheRefrsh = new Label();
        numHypixelUpdateInterval = new NumericUpDown();
        lblHypixelUpdateInterval = new Label();
        pgSettings = new TabPage();
        btnHealth = new Button();
        txtAdminKey = new TextBox();
        btnReloadSettings = new Button();
        btnSaveSettings = new Button();
        grpClientSettings = new GroupBox();
        lblServerUrl = new Label();
        chkMinimizeToTray = new CheckBox();
        lblLogtime = new Label();
        chkStartupNotificationHistory = new CheckBox();
        chkAuctionNotifications = new CheckBox();
        numNotificationHistory = new NumericUpDown();
        txtServerUrl = new TextBox();
        grpServer = new GroupBox();
        lblMaxAuctions = new Label();
        pgAuctions = new TabPage();
        grpAuctions = new GroupBox();
        lvAuctions = new ListView();
        Item = new ColumnHeader();
        Tier = new ColumnHeader();
        PetLevel = new ColumnHeader();
        Stars = new ColumnHeader();
        Recomb = new ColumnHeader();
        CheapestAuction = new ColumnHeader();
        AuctionName = new ColumnHeader();
        NotifyBelow = new ColumnHeader();
        parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
        lblServer = new ReaLTaiizor.Controls.SkyLabel();
        lblPlayerCount = new ReaLTaiizor.Controls.SkyLabel();
        lblUsername = new ReaLTaiizor.Controls.SkyLabel();
        lblLastUpdate = new ReaLTaiizor.Controls.SkyLabel();
        btnRefresh = new ReaLTaiizor.Controls.SkyButton();
        btnAddAuction = new ReaLTaiizor.Controls.SkyButton();
        btnRemoveAuction = new ReaLTaiizor.Controls.SkyButton();
        tabMain = new ReaLTaiizor.Controls.DungeonTabPage();
        txtAdminServerUrl = new TextBox();
        pgAdmin.SuspendLayout();
        grpUsers.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numPurgeInactive).BeginInit();
        grpCleanup.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numWatchExpiration).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numWatchCleanupInterval).BeginInit();
        grpClientLimits.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numMaxPlayerRequestsPerMinute).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numMaxAuctionWatches).BeginInit();
        grpServerSettings.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numItemCacheUpdateMinutes).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numAuctionCheckInterval).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numAuctionCacheRefresh).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numHypixelUpdateInterval).BeginInit();
        pgSettings.SuspendLayout();
        grpClientSettings.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numNotificationHistory).BeginInit();
        grpServer.SuspendLayout();
        pgAuctions.SuspendLayout();
        grpAuctions.SuspendLayout();
        parrotGradientPanel1.SuspendLayout();
        tabMain.SuspendLayout();
        SuspendLayout();
        // 
        // pgAdmin
        // 
        pgAdmin.BackColor = Color.FromArgb(247, 186, 54);
        pgAdmin.Controls.Add(txtAdminServerUrl);
        pgAdmin.Controls.Add(btnBackup);
        pgAdmin.Controls.Add(btnStatus);
        pgAdmin.Controls.Add(txtUpdateApiKey);
        pgAdmin.Controls.Add(btnShutdownServer);
        pgAdmin.Controls.Add(grpUsers);
        pgAdmin.Controls.Add(grpCleanup);
        pgAdmin.Controls.Add(grpClientLimits);
        pgAdmin.Controls.Add(grpServerSettings);
        pgAdmin.Location = new Point(4, 28);
        pgAdmin.Name = "pgAdmin";
        pgAdmin.Padding = new Padding(3);
        pgAdmin.Size = new Size(906, 440);
        pgAdmin.TabIndex = 4;
        pgAdmin.Text = "Admin";
        // 
        // btnBackup
        // 
        btnBackup.Location = new Point(432, 325);
        btnBackup.Name = "btnBackup";
        btnBackup.Size = new Size(75, 23);
        btnBackup.TabIndex = 7;
        btnBackup.Text = "Backup";
        btnBackup.UseVisualStyleBackColor = true;
        btnBackup.Click += btnBackup_Click;
        // 
        // btnStatus
        // 
        btnStatus.Location = new Point(350, 325);
        btnStatus.Name = "btnStatus";
        btnStatus.Size = new Size(75, 23);
        btnStatus.TabIndex = 6;
        btnStatus.Text = "Status";
        btnStatus.UseVisualStyleBackColor = true;
        btnStatus.Click += btnStatus_Click;
        // 
        // txtUpdateApiKey
        // 
        txtUpdateApiKey.Location = new Point(269, 354);
        txtUpdateApiKey.Name = "txtUpdateApiKey";
        txtUpdateApiKey.PlaceholderText = "Update Api Key";
        txtUpdateApiKey.Size = new Size(238, 23);
        txtUpdateApiKey.TabIndex = 5;
        txtUpdateApiKey.Visible = false;
        txtUpdateApiKey.KeyDown += txtUpdateApiKey_KeyDown;
        // 
        // btnShutdownServer
        // 
        btnShutdownServer.Location = new Point(269, 325);
        btnShutdownServer.Name = "btnShutdownServer";
        btnShutdownServer.Size = new Size(75, 23);
        btnShutdownServer.TabIndex = 4;
        btnShutdownServer.Text = "Shutdown Server";
        btnShutdownServer.UseVisualStyleBackColor = true;
        btnShutdownServer.Click += btnShutdownServer_Click;
        // 
        // grpUsers
        // 
        grpUsers.Controls.Add(txtNotificationMessage);
        grpUsers.Controls.Add(aloneTextBox1);
        grpUsers.Controls.Add(btnSendNotification);
        grpUsers.Controls.Add(radNotificationSelected);
        grpUsers.Controls.Add(radNotificationEveryone);
        grpUsers.Controls.Add(lblNotificationMessage);
        grpUsers.Controls.Add(txtNotificationTitle);
        grpUsers.Controls.Add(lblNotificationTitle);
        grpUsers.Controls.Add(numPurgeInactive);
        grpUsers.Controls.Add(btnPurgeInactive);
        grpUsers.Controls.Add(btnDelete);
        grpUsers.Controls.Add(btnUnblock);
        grpUsers.Controls.Add(btnBlock);
        grpUsers.Controls.Add(lvUsers);
        grpUsers.Controls.Add(btnRefreshUsers);
        grpUsers.Location = new Point(263, 6);
        grpUsers.Name = "grpUsers";
        grpUsers.Size = new Size(603, 313);
        grpUsers.TabIndex = 3;
        grpUsers.TabStop = false;
        grpUsers.Text = "Users";
        // 
        // txtNotificationMessage
        // 
        txtNotificationMessage.Location = new Point(303, 88);
        txtNotificationMessage.Name = "txtNotificationMessage";
        txtNotificationMessage.Size = new Size(294, 129);
        txtNotificationMessage.TabIndex = 14;
        txtNotificationMessage.Text = "";
        // 
        // aloneTextBox1
        // 
        aloneTextBox1.BackColor = Color.Transparent;
        aloneTextBox1.EnabledCalc = true;
        aloneTextBox1.Font = new Font("Segoe UI", 9F);
        aloneTextBox1.ForeColor = Color.FromArgb(124, 133, 142);
        aloneTextBox1.Location = new Point(141, 12);
        aloneTextBox1.MaxLength = 32767;
        aloneTextBox1.MultiLine = false;
        aloneTextBox1.Name = "aloneTextBox1";
        aloneTextBox1.ReadOnly = false;
        aloneTextBox1.Size = new Size(97, 29);
        aloneTextBox1.TabIndex = 13;
        aloneTextBox1.Text = "aloneTextBox1";
        aloneTextBox1.TextAlign = HorizontalAlignment.Left;
        aloneTextBox1.UseSystemPasswordChar = false;
        // 
        // btnSendNotification
        // 
        btnSendNotification.Location = new Point(522, 248);
        btnSendNotification.Name = "btnSendNotification";
        btnSendNotification.Size = new Size(75, 23);
        btnSendNotification.TabIndex = 12;
        btnSendNotification.Text = "Send";
        btnSendNotification.UseVisualStyleBackColor = true;
        btnSendNotification.Click += btnSendNotification_Click;
        // 
        // radNotificationSelected
        // 
        radNotificationSelected.AutoSize = true;
        radNotificationSelected.Location = new Point(429, 223);
        radNotificationSelected.Name = "radNotificationSelected";
        radNotificationSelected.Size = new Size(100, 19);
        radNotificationSelected.TabIndex = 11;
        radNotificationSelected.TabStop = true;
        radNotificationSelected.Text = "Selected Users";
        radNotificationSelected.UseVisualStyleBackColor = true;
        // 
        // radNotificationEveryone
        // 
        radNotificationEveryone.AutoSize = true;
        radNotificationEveryone.Location = new Point(303, 223);
        radNotificationEveryone.Name = "radNotificationEveryone";
        radNotificationEveryone.Size = new Size(73, 19);
        radNotificationEveryone.TabIndex = 10;
        radNotificationEveryone.TabStop = true;
        radNotificationEveryone.Text = "Everyone";
        radNotificationEveryone.UseVisualStyleBackColor = true;
        // 
        // lblNotificationMessage
        // 
        lblNotificationMessage.AutoSize = true;
        lblNotificationMessage.Location = new Point(303, 70);
        lblNotificationMessage.Name = "lblNotificationMessage";
        lblNotificationMessage.Size = new Size(53, 15);
        lblNotificationMessage.TabIndex = 8;
        lblNotificationMessage.Text = "Message";
        // 
        // txtNotificationTitle
        // 
        txtNotificationTitle.Location = new Point(303, 44);
        txtNotificationTitle.Name = "txtNotificationTitle";
        txtNotificationTitle.Size = new Size(294, 23);
        txtNotificationTitle.TabIndex = 7;
        // 
        // lblNotificationTitle
        // 
        lblNotificationTitle.AutoSize = true;
        lblNotificationTitle.Location = new Point(303, 26);
        lblNotificationTitle.Name = "lblNotificationTitle";
        lblNotificationTitle.Size = new Size(30, 15);
        lblNotificationTitle.TabIndex = 6;
        lblNotificationTitle.Text = "Title";
        // 
        // numPurgeInactive
        // 
        numPurgeInactive.Location = new Point(6, 256);
        numPurgeInactive.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
        numPurgeInactive.Name = "numPurgeInactive";
        numPurgeInactive.Size = new Size(120, 23);
        numPurgeInactive.TabIndex = 4;
        // 
        // btnPurgeInactive
        // 
        btnPurgeInactive.Location = new Point(6, 285);
        btnPurgeInactive.Name = "btnPurgeInactive";
        btnPurgeInactive.Size = new Size(158, 23);
        btnPurgeInactive.TabIndex = 5;
        btnPurgeInactive.Text = "Purge inactive Users Days";
        btnPurgeInactive.UseVisualStyleBackColor = true;
        btnPurgeInactive.Click += btnPurgeInactive_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(163, 227);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(75, 23);
        btnDelete.TabIndex = 4;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnUnblock
        // 
        btnUnblock.Location = new Point(87, 227);
        btnUnblock.Name = "btnUnblock";
        btnUnblock.Size = new Size(75, 23);
        btnUnblock.TabIndex = 3;
        btnUnblock.Text = "Unblock";
        btnUnblock.UseVisualStyleBackColor = true;
        btnUnblock.Click += btnUnblock_Click;
        // 
        // btnBlock
        // 
        btnBlock.Location = new Point(6, 227);
        btnBlock.Name = "btnBlock";
        btnBlock.Size = new Size(75, 23);
        btnBlock.TabIndex = 2;
        btnBlock.Text = "Block";
        btnBlock.UseVisualStyleBackColor = true;
        btnBlock.Click += btnBlock_Click;
        // 
        // lvUsers
        // 
        lvUsers.Columns.AddRange(new ColumnHeader[] { clmUsername, clmBlocked, clmLastRequest });
        lvUsers.FullRowSelect = true;
        lvUsers.GridLines = true;
        lvUsers.Location = new Point(6, 44);
        lvUsers.Name = "lvUsers";
        lvUsers.Size = new Size(291, 177);
        lvUsers.TabIndex = 1;
        lvUsers.UseCompatibleStateImageBehavior = false;
        lvUsers.View = View.Details;
        // 
        // clmUsername
        // 
        clmUsername.Text = "Username";
        clmUsername.Width = 115;
        // 
        // clmBlocked
        // 
        clmBlocked.Text = "Blocked";
        clmBlocked.Width = 55;
        // 
        // clmLastRequest
        // 
        clmLastRequest.Text = "Last Request";
        clmLastRequest.Width = 115;
        // 
        // btnRefreshUsers
        // 
        btnRefreshUsers.Location = new Point(6, 15);
        btnRefreshUsers.Name = "btnRefreshUsers";
        btnRefreshUsers.Size = new Size(75, 23);
        btnRefreshUsers.TabIndex = 0;
        btnRefreshUsers.Text = "Refresh Users";
        btnRefreshUsers.UseVisualStyleBackColor = true;
        btnRefreshUsers.Click += btnRefreshUsers_Click;
        // 
        // grpCleanup
        // 
        grpCleanup.Controls.Add(numWatchExpiration);
        grpCleanup.Controls.Add(lblWatchExpiration);
        grpCleanup.Controls.Add(numWatchCleanupInterval);
        grpCleanup.Controls.Add(lblWatchCleanupInterval);
        grpCleanup.Location = new Point(6, 330);
        grpCleanup.Name = "grpCleanup";
        grpCleanup.Size = new Size(251, 111);
        grpCleanup.TabIndex = 2;
        grpCleanup.TabStop = false;
        grpCleanup.Text = "Cleanup";
        // 
        // numWatchExpiration
        // 
        numWatchExpiration.Location = new Point(6, 81);
        numWatchExpiration.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numWatchExpiration.Name = "numWatchExpiration";
        numWatchExpiration.Size = new Size(120, 23);
        numWatchExpiration.TabIndex = 3;
        numWatchExpiration.KeyDown += numWatchExpiration_KeyDown;
        // 
        // lblWatchExpiration
        // 
        lblWatchExpiration.AutoSize = true;
        lblWatchExpiration.Location = new Point(6, 63);
        lblWatchExpiration.Name = "lblWatchExpiration";
        lblWatchExpiration.Size = new Size(127, 15);
        lblWatchExpiration.TabIndex = 2;
        lblWatchExpiration.Text = "Watch Expiration Days:";
        // 
        // numWatchCleanupInterval
        // 
        numWatchCleanupInterval.Location = new Point(6, 37);
        numWatchCleanupInterval.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numWatchCleanupInterval.Name = "numWatchCleanupInterval";
        numWatchCleanupInterval.Size = new Size(120, 23);
        numWatchCleanupInterval.TabIndex = 1;
        numWatchCleanupInterval.KeyDown += numWatchCleanupInterval_KeyDown;
        // 
        // lblWatchCleanupInterval
        // 
        lblWatchCleanupInterval.AutoSize = true;
        lblWatchCleanupInterval.Location = new Point(2, 19);
        lblWatchCleanupInterval.Name = "lblWatchCleanupInterval";
        lblWatchCleanupInterval.Size = new Size(231, 15);
        lblWatchCleanupInterval.TabIndex = 0;
        lblWatchCleanupInterval.Text = "Cleanup Expired Watches Interval minutes:";
        // 
        // grpClientLimits
        // 
        grpClientLimits.Controls.Add(numMaxPlayerRequestsPerMinute);
        grpClientLimits.Controls.Add(lblMaxPlayerRequestsPerMinute);
        grpClientLimits.Controls.Add(numMaxAuctionWatches);
        grpClientLimits.Controls.Add(lblMaxAuctionWatches);
        grpClientLimits.Location = new Point(6, 212);
        grpClientLimits.Name = "grpClientLimits";
        grpClientLimits.Size = new Size(251, 112);
        grpClientLimits.TabIndex = 1;
        grpClientLimits.TabStop = false;
        grpClientLimits.Text = "Client Limits";
        // 
        // numMaxPlayerRequestsPerMinute
        // 
        numMaxPlayerRequestsPerMinute.Location = new Point(6, 81);
        numMaxPlayerRequestsPerMinute.Name = "numMaxPlayerRequestsPerMinute";
        numMaxPlayerRequestsPerMinute.Size = new Size(120, 23);
        numMaxPlayerRequestsPerMinute.TabIndex = 3;
        numMaxPlayerRequestsPerMinute.KeyDown += numMaxPlayerRequestsPerMinute_KeyDown;
        // 
        // lblMaxPlayerRequestsPerMinute
        // 
        lblMaxPlayerRequestsPerMinute.AutoSize = true;
        lblMaxPlayerRequestsPerMinute.Location = new Point(6, 63);
        lblMaxPlayerRequestsPerMinute.Name = "lblMaxPlayerRequestsPerMinute";
        lblMaxPlayerRequestsPerMinute.Size = new Size(177, 15);
        lblMaxPlayerRequestsPerMinute.TabIndex = 2;
        lblMaxPlayerRequestsPerMinute.Text = "Max Client Requests Per Minute:";
        // 
        // numMaxAuctionWatches
        // 
        numMaxAuctionWatches.Location = new Point(6, 37);
        numMaxAuctionWatches.Name = "numMaxAuctionWatches";
        numMaxAuctionWatches.Size = new Size(120, 23);
        numMaxAuctionWatches.TabIndex = 1;
        numMaxAuctionWatches.KeyDown += numMaxAuctionWatches_KeyDown;
        // 
        // lblMaxAuctionWatches
        // 
        lblMaxAuctionWatches.AutoSize = true;
        lblMaxAuctionWatches.Location = new Point(6, 19);
        lblMaxAuctionWatches.Name = "lblMaxAuctionWatches";
        lblMaxAuctionWatches.Size = new Size(125, 15);
        lblMaxAuctionWatches.TabIndex = 0;
        lblMaxAuctionWatches.Text = "Max Auction Watches:";
        // 
        // grpServerSettings
        // 
        grpServerSettings.Controls.Add(numItemCacheUpdateMinutes);
        grpServerSettings.Controls.Add(lblItemCacheUpdateMinutes);
        grpServerSettings.Controls.Add(numAuctionCheckInterval);
        grpServerSettings.Controls.Add(lblAuctionCheckInterval);
        grpServerSettings.Controls.Add(numAuctionCacheRefresh);
        grpServerSettings.Controls.Add(lblAuctionCacheRefrsh);
        grpServerSettings.Controls.Add(numHypixelUpdateInterval);
        grpServerSettings.Controls.Add(lblHypixelUpdateInterval);
        grpServerSettings.Location = new Point(6, 6);
        grpServerSettings.Name = "grpServerSettings";
        grpServerSettings.Size = new Size(251, 200);
        grpServerSettings.TabIndex = 0;
        grpServerSettings.TabStop = false;
        grpServerSettings.Text = "Server Settings";
        // 
        // numItemCacheUpdateMinutes
        // 
        numItemCacheUpdateMinutes.Location = new Point(6, 169);
        numItemCacheUpdateMinutes.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        numItemCacheUpdateMinutes.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
        numItemCacheUpdateMinutes.Name = "numItemCacheUpdateMinutes";
        numItemCacheUpdateMinutes.Size = new Size(120, 23);
        numItemCacheUpdateMinutes.TabIndex = 7;
        numItemCacheUpdateMinutes.Value = new decimal(new int[] { 10, 0, 0, 0 });
        numItemCacheUpdateMinutes.KeyDown += numItemCacheUpdateMinutes_KeyDown;
        // 
        // lblItemCacheUpdateMinutes
        // 
        lblItemCacheUpdateMinutes.AutoSize = true;
        lblItemCacheUpdateMinutes.Location = new Point(0, 151);
        lblItemCacheUpdateMinutes.Name = "lblItemCacheUpdateMinutes";
        lblItemCacheUpdateMinutes.Size = new Size(192, 15);
        lblItemCacheUpdateMinutes.TabIndex = 6;
        lblItemCacheUpdateMinutes.Text = "Item Name Cache Update Minutes:";
        // 
        // numAuctionCheckInterval
        // 
        numAuctionCheckInterval.Location = new Point(6, 125);
        numAuctionCheckInterval.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        numAuctionCheckInterval.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
        numAuctionCheckInterval.Name = "numAuctionCheckInterval";
        numAuctionCheckInterval.Size = new Size(120, 23);
        numAuctionCheckInterval.TabIndex = 5;
        numAuctionCheckInterval.Value = new decimal(new int[] { 10, 0, 0, 0 });
        numAuctionCheckInterval.KeyDown += numAuctionCheckInterval_KeyDown;
        // 
        // lblAuctionCheckInterval
        // 
        lblAuctionCheckInterval.AutoSize = true;
        lblAuctionCheckInterval.Location = new Point(6, 107);
        lblAuctionCheckInterval.Name = "lblAuctionCheckInterval";
        lblAuctionCheckInterval.Size = new Size(188, 15);
        lblAuctionCheckInterval.TabIndex = 4;
        lblAuctionCheckInterval.Text = "Scan Cache For Auctions Seconds:";
        // 
        // numAuctionCacheRefresh
        // 
        numAuctionCacheRefresh.Location = new Point(6, 81);
        numAuctionCacheRefresh.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        numAuctionCacheRefresh.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
        numAuctionCacheRefresh.Name = "numAuctionCacheRefresh";
        numAuctionCacheRefresh.Size = new Size(120, 23);
        numAuctionCacheRefresh.TabIndex = 3;
        numAuctionCacheRefresh.Value = new decimal(new int[] { 10, 0, 0, 0 });
        numAuctionCacheRefresh.KeyDown += numAuctionCacheRefresh_KeyDown;
        // 
        // lblAuctionCacheRefrsh
        // 
        lblAuctionCacheRefrsh.AutoSize = true;
        lblAuctionCacheRefrsh.Location = new Point(6, 63);
        lblAuctionCacheRefrsh.Name = "lblAuctionCacheRefrsh";
        lblAuctionCacheRefrsh.Size = new Size(188, 15);
        lblAuctionCacheRefrsh.TabIndex = 2;
        lblAuctionCacheRefrsh.Text = "Refresh Hypixel Auctions Seconds:";
        // 
        // numHypixelUpdateInterval
        // 
        numHypixelUpdateInterval.Location = new Point(6, 37);
        numHypixelUpdateInterval.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numHypixelUpdateInterval.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
        numHypixelUpdateInterval.Name = "numHypixelUpdateInterval";
        numHypixelUpdateInterval.Size = new Size(120, 23);
        numHypixelUpdateInterval.TabIndex = 1;
        numHypixelUpdateInterval.Value = new decimal(new int[] { 10, 0, 0, 0 });
        numHypixelUpdateInterval.KeyDown += numHypixelUpdateInterval_KeyDown;
        // 
        // lblHypixelUpdateInterval
        // 
        lblHypixelUpdateInterval.AutoSize = true;
        lblHypixelUpdateInterval.Location = new Point(6, 19);
        lblHypixelUpdateInterval.Name = "lblHypixelUpdateInterval";
        lblHypixelUpdateInterval.Size = new Size(179, 15);
        lblHypixelUpdateInterval.TabIndex = 0;
        lblHypixelUpdateInterval.Text = "Hypixel Update Interval Seconds:";
        // 
        // pgSettings
        // 
        pgSettings.BackColor = Color.FromArgb(247, 186, 54);
        pgSettings.Controls.Add(btnHealth);
        pgSettings.Controls.Add(txtAdminKey);
        pgSettings.Controls.Add(btnReloadSettings);
        pgSettings.Controls.Add(btnSaveSettings);
        pgSettings.Controls.Add(grpClientSettings);
        pgSettings.Controls.Add(grpServer);
        pgSettings.Location = new Point(4, 28);
        pgSettings.Name = "pgSettings";
        pgSettings.Padding = new Padding(3);
        pgSettings.Size = new Size(906, 440);
        pgSettings.TabIndex = 3;
        pgSettings.Text = "Settings";
        // 
        // btnHealth
        // 
        btnHealth.Location = new Point(11, 292);
        btnHealth.Name = "btnHealth";
        btnHealth.Size = new Size(75, 23);
        btnHealth.TabIndex = 5;
        btnHealth.Text = "Health";
        btnHealth.UseVisualStyleBackColor = true;
        btnHealth.Click += btnHealth_Click;
        // 
        // txtAdminKey
        // 
        txtAdminKey.Location = new Point(6, 263);
        txtAdminKey.Name = "txtAdminKey";
        txtAdminKey.PlaceholderText = "Admin Key";
        txtAdminKey.Size = new Size(272, 23);
        txtAdminKey.TabIndex = 4;
        txtAdminKey.UseSystemPasswordChar = true;
        txtAdminKey.KeyDown += txtAdminKey_KeyDown;
        // 
        // btnReloadSettings
        // 
        btnReloadSettings.Location = new Point(92, 234);
        btnReloadSettings.Name = "btnReloadSettings";
        btnReloadSettings.Size = new Size(75, 23);
        btnReloadSettings.TabIndex = 3;
        btnReloadSettings.Text = "Reload";
        btnReloadSettings.UseVisualStyleBackColor = true;
        btnReloadSettings.Click += btnReloadSettings_Click;
        // 
        // btnSaveSettings
        // 
        btnSaveSettings.Location = new Point(11, 234);
        btnSaveSettings.Name = "btnSaveSettings";
        btnSaveSettings.Size = new Size(75, 23);
        btnSaveSettings.TabIndex = 2;
        btnSaveSettings.Text = "Save";
        btnSaveSettings.UseVisualStyleBackColor = true;
        btnSaveSettings.Click += btnSaveSettings_Click;
        // 
        // grpClientSettings
        // 
        grpClientSettings.Controls.Add(lblServerUrl);
        grpClientSettings.Controls.Add(chkMinimizeToTray);
        grpClientSettings.Controls.Add(lblLogtime);
        grpClientSettings.Controls.Add(chkStartupNotificationHistory);
        grpClientSettings.Controls.Add(chkAuctionNotifications);
        grpClientSettings.Controls.Add(numNotificationHistory);
        grpClientSettings.Controls.Add(txtServerUrl);
        grpClientSettings.Location = new Point(2, 48);
        grpClientSettings.Name = "grpClientSettings";
        grpClientSettings.Size = new Size(273, 181);
        grpClientSettings.TabIndex = 1;
        grpClientSettings.TabStop = false;
        grpClientSettings.Text = "Client Settings";
        // 
        // lblServerUrl
        // 
        lblServerUrl.AutoSize = true;
        lblServerUrl.Location = new Point(5, 19);
        lblServerUrl.Name = "lblServerUrl";
        lblServerUrl.Size = new Size(106, 15);
        lblServerUrl.TabIndex = 7;
        lblServerUrl.Text = "Server address URL";
        // 
        // chkMinimizeToTray
        // 
        chkMinimizeToTray.AutoSize = true;
        chkMinimizeToTray.Location = new Point(6, 160);
        chkMinimizeToTray.Name = "chkMinimizeToTray";
        chkMinimizeToTray.Size = new Size(112, 19);
        chkMinimizeToTray.TabIndex = 6;
        chkMinimizeToTray.Text = "Minimize to tray";
        chkMinimizeToTray.UseVisualStyleBackColor = true;
        // 
        // lblLogtime
        // 
        lblLogtime.AutoSize = true;
        lblLogtime.Location = new Point(6, 111);
        lblLogtime.Name = "lblLogtime";
        lblLogtime.Size = new Size(163, 15);
        lblLogtime.TabIndex = 5;
        lblLogtime.Text = "Notification history (minutes)";
        // 
        // chkStartupNotificationHistory
        // 
        chkStartupNotificationHistory.AutoSize = true;
        chkStartupNotificationHistory.Checked = true;
        chkStartupNotificationHistory.CheckState = CheckState.Checked;
        chkStartupNotificationHistory.Location = new Point(5, 89);
        chkStartupNotificationHistory.Name = "chkStartupNotificationHistory";
        chkStartupNotificationHistory.Size = new Size(228, 19);
        chkStartupNotificationHistory.TabIndex = 4;
        chkStartupNotificationHistory.Text = "Receive recent notifications on startup";
        chkStartupNotificationHistory.UseVisualStyleBackColor = true;
        // 
        // chkAuctionNotifications
        // 
        chkAuctionNotifications.AutoSize = true;
        chkAuctionNotifications.Checked = true;
        chkAuctionNotifications.CheckState = CheckState.Checked;
        chkAuctionNotifications.Location = new Point(5, 64);
        chkAuctionNotifications.Name = "chkAuctionNotifications";
        chkAuctionNotifications.Size = new Size(178, 19);
        chkAuctionNotifications.TabIndex = 3;
        chkAuctionNotifications.Text = "Receive auction notifications";
        chkAuctionNotifications.UseVisualStyleBackColor = true;
        // 
        // numNotificationHistory
        // 
        numNotificationHistory.Location = new Point(6, 131);
        numNotificationHistory.Name = "numNotificationHistory";
        numNotificationHistory.Size = new Size(120, 23);
        numNotificationHistory.TabIndex = 1;
        // 
        // txtServerUrl
        // 
        txtServerUrl.Location = new Point(5, 37);
        txtServerUrl.Name = "txtServerUrl";
        txtServerUrl.PlaceholderText = "http://localhost:5122";
        txtServerUrl.Size = new Size(261, 23);
        txtServerUrl.TabIndex = 0;
        txtServerUrl.TextChanged += txtServerUrl_TextChanged;
        // 
        // grpServer
        // 
        grpServer.Controls.Add(lblMaxAuctions);
        grpServer.Location = new Point(1, 1);
        grpServer.Name = "grpServer";
        grpServer.Size = new Size(274, 41);
        grpServer.TabIndex = 0;
        grpServer.TabStop = false;
        grpServer.Text = "Server Limits";
        // 
        // lblMaxAuctions
        // 
        lblMaxAuctions.AutoSize = true;
        lblMaxAuctions.Location = new Point(7, 19);
        lblMaxAuctions.Name = "lblMaxAuctions";
        lblMaxAuctions.Size = new Size(82, 15);
        lblMaxAuctions.TabIndex = 1;
        lblMaxAuctions.Text = "Max Auctions:";
        // 
        // pgAuctions
        // 
        pgAuctions.BackColor = Color.FromArgb(247, 186, 54);
        pgAuctions.Controls.Add(grpAuctions);
        pgAuctions.Location = new Point(4, 28);
        pgAuctions.Name = "pgAuctions";
        pgAuctions.Padding = new Padding(3);
        pgAuctions.Size = new Size(906, 440);
        pgAuctions.TabIndex = 2;
        pgAuctions.Text = "Status";
        // 
        // grpAuctions
        // 
        grpAuctions.Controls.Add(lvAuctions);
        grpAuctions.Controls.Add(parrotGradientPanel1);
        grpAuctions.Dock = DockStyle.Fill;
        grpAuctions.Font = new Font("Minecraft", 8.25F);
        grpAuctions.Location = new Point(3, 3);
        grpAuctions.Name = "grpAuctions";
        grpAuctions.Size = new Size(900, 434);
        grpAuctions.TabIndex = 0;
        grpAuctions.TabStop = false;
        grpAuctions.Text = "Status";
        // 
        // lvAuctions
        // 
        lvAuctions.BackColor = Color.Black;
        lvAuctions.Columns.AddRange(new ColumnHeader[] { Item, Tier, PetLevel, Stars, Recomb, CheapestAuction, AuctionName, NotifyBelow });
        lvAuctions.Font = new Font("Minecraft", 8.25F);
        lvAuctions.ForeColor = Color.Black;
        lvAuctions.FullRowSelect = true;
        lvAuctions.GridLines = true;
        lvAuctions.Location = new Point(3, 76);
        lvAuctions.MultiSelect = false;
        lvAuctions.Name = "lvAuctions";
        lvAuctions.Size = new Size(890, 142);
        lvAuctions.TabIndex = 0;
        lvAuctions.UseCompatibleStateImageBehavior = false;
        lvAuctions.View = View.Details;
        lvAuctions.DoubleClick += lvAuctions_DoubleClick;
        // 
        // Item
        // 
        Item.Text = "Item";
        Item.Width = 140;
        // 
        // Tier
        // 
        Tier.Text = "Tier";
        Tier.Width = 85;
        // 
        // PetLevel
        // 
        PetLevel.Text = "Pet Level";
        PetLevel.Width = 75;
        // 
        // Stars
        // 
        Stars.Text = "Stars";
        Stars.Width = 55;
        // 
        // Recomb
        // 
        Recomb.Text = "Recomb";
        // 
        // CheapestAuction
        // 
        CheapestAuction.Text = "Cheapest Auction";
        CheapestAuction.Width = 130;
        // 
        // AuctionName
        // 
        AuctionName.Text = "Auction Name";
        AuctionName.Width = 210;
        // 
        // NotifyBelow
        // 
        NotifyBelow.Text = "Notify Below";
        NotifyBelow.Width = 130;
        // 
        // parrotGradientPanel1
        // 
        parrotGradientPanel1.BottomLeft = Color.FromArgb(255, 190, 55);
        parrotGradientPanel1.BottomRight = Color.FromArgb(35, 180, 110);
        parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
        parrotGradientPanel1.Controls.Add(lblServer);
        parrotGradientPanel1.Controls.Add(lblPlayerCount);
        parrotGradientPanel1.Controls.Add(lblUsername);
        parrotGradientPanel1.Controls.Add(lblLastUpdate);
        parrotGradientPanel1.Controls.Add(btnRefresh);
        parrotGradientPanel1.Controls.Add(btnAddAuction);
        parrotGradientPanel1.Controls.Add(btnRemoveAuction);
        parrotGradientPanel1.Dock = DockStyle.Fill;
        parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
        parrotGradientPanel1.Location = new Point(3, 17);
        parrotGradientPanel1.Name = "parrotGradientPanel1";
        parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
        parrotGradientPanel1.PrimerColor = Color.Black;
        parrotGradientPanel1.Size = new Size(894, 414);
        parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
        parrotGradientPanel1.TabIndex = 13;
        parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
        parrotGradientPanel1.TopLeft = Color.DodgerBlue;
        parrotGradientPanel1.TopRight = Color.FromArgb(123, 63, 170);
        // 
        // lblServer
        // 
        lblServer.AutoSize = true;
        lblServer.BackColor = Color.Transparent;
        lblServer.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblServer.ForeColor = SystemColors.ActiveCaptionText;
        lblServer.Location = new Point(7, 32);
        lblServer.Name = "lblServer";
        lblServer.Size = new Size(58, 13);
        lblServer.TabIndex = 18;
        lblServer.Text = "Server:";
        // 
        // lblPlayerCount
        // 
        lblPlayerCount.AutoSize = true;
        lblPlayerCount.BackColor = Color.Transparent;
        lblPlayerCount.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblPlayerCount.ForeColor = SystemColors.ActiveCaptionText;
        lblPlayerCount.Location = new Point(7, 19);
        lblPlayerCount.Name = "lblPlayerCount";
        lblPlayerCount.Size = new Size(62, 13);
        lblPlayerCount.TabIndex = 17;
        lblPlayerCount.Text = "Players:";
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.BackColor = Color.Transparent;
        lblUsername.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblUsername.ForeColor = SystemColors.ActiveCaptionText;
        lblUsername.Location = new Point(7, 6);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(74, 13);
        lblUsername.TabIndex = 16;
        lblUsername.Text = "Username:";
        // 
        // lblLastUpdate
        // 
        lblLastUpdate.AutoSize = true;
        lblLastUpdate.BackColor = Color.Transparent;
        lblLastUpdate.Font = new Font("Minecraft", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblLastUpdate.ForeColor = SystemColors.ActiveCaptionText;
        lblLastUpdate.Location = new Point(234, 6);
        lblLastUpdate.Name = "lblLastUpdate";
        lblLastUpdate.Size = new Size(89, 13);
        lblLastUpdate.TabIndex = 15;
        lblLastUpdate.Text = "Last Update:";
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.Black;
        btnRefresh.Cursor = Cursors.Hand;
        btnRefresh.DownBGColorA = Color.FromArgb(107, 107, 107);
        btnRefresh.DownBGColorB = Color.FromArgb(123, 123, 123);
        btnRefresh.DownBorderColorA = Color.FromArgb(227, 195, 95);
        btnRefresh.DownBorderColorB = Color.FromArgb(227, 195, 95);
        btnRefresh.DownBorderColorC = Color.FromArgb(169, 128, 56);
        btnRefresh.DownBorderColorD = Color.FromArgb(169, 128, 56);
        btnRefresh.DownForeColor = Color.White;
        btnRefresh.DownShadowForeColor = Color.FromArgb(53, 53, 53);
        btnRefresh.Font = new Font("Minecraft", 8.25F);
        btnRefresh.ForeColor = Color.White;
        btnRefresh.HoverBGColorA = Color.FromArgb(107, 107, 107);
        btnRefresh.HoverBGColorB = Color.FromArgb(123, 123, 123);
        btnRefresh.HoverBorderColorA = Color.White;
        btnRefresh.HoverBorderColorB = Color.White;
        btnRefresh.HoverBorderColorC = Color.White;
        btnRefresh.HoverBorderColorD = Color.White;
        btnRefresh.HoverForeColor = Color.White;
        btnRefresh.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
        btnRefresh.Location = new Point(234, 22);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.NormalBGColorA = Color.FromArgb(107, 107, 107);
        btnRefresh.NormalBGColorB = Color.FromArgb(123, 123, 123);
        btnRefresh.NormalBorderColorA = Color.DarkGray;
        btnRefresh.NormalBorderColorB = Color.DarkGray;
        btnRefresh.NormalBorderColorC = Color.Black;
        btnRefresh.NormalBorderColorD = Color.Black;
        btnRefresh.NormalForeColor = Color.White;
        btnRefresh.NormalShadowForeColor = Color.FromArgb(53, 53, 53);
        btnRefresh.Size = new Size(121, 23);
        btnRefresh.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        btnRefresh.TabIndex = 14;
        btnRefresh.Text = "Refresh";
        btnRefresh.Click += btnRefresh_Click;
        // 
        // btnAddAuction
        // 
        btnAddAuction.BackColor = Color.Black;
        btnAddAuction.Cursor = Cursors.Hand;
        btnAddAuction.DownBGColorA = Color.FromArgb(107, 107, 107);
        btnAddAuction.DownBGColorB = Color.FromArgb(123, 123, 123);
        btnAddAuction.DownBorderColorA = Color.FromArgb(227, 195, 95);
        btnAddAuction.DownBorderColorB = Color.FromArgb(227, 195, 95);
        btnAddAuction.DownBorderColorC = Color.FromArgb(169, 128, 56);
        btnAddAuction.DownBorderColorD = Color.FromArgb(169, 128, 56);
        btnAddAuction.DownForeColor = Color.White;
        btnAddAuction.DownShadowForeColor = Color.FromArgb(53, 53, 53);
        btnAddAuction.Font = new Font("Minecraft", 8.25F);
        btnAddAuction.ForeColor = Color.White;
        btnAddAuction.HoverBGColorA = Color.FromArgb(107, 107, 107);
        btnAddAuction.HoverBGColorB = Color.FromArgb(123, 123, 123);
        btnAddAuction.HoverBorderColorA = Color.White;
        btnAddAuction.HoverBorderColorB = Color.White;
        btnAddAuction.HoverBorderColorC = Color.White;
        btnAddAuction.HoverBorderColorD = Color.White;
        btnAddAuction.HoverForeColor = Color.White;
        btnAddAuction.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
        btnAddAuction.Location = new Point(20, 205);
        btnAddAuction.Name = "btnAddAuction";
        btnAddAuction.NormalBGColorA = Color.FromArgb(107, 107, 107);
        btnAddAuction.NormalBGColorB = Color.FromArgb(123, 123, 123);
        btnAddAuction.NormalBorderColorA = Color.DarkGray;
        btnAddAuction.NormalBorderColorB = Color.DarkGray;
        btnAddAuction.NormalBorderColorC = Color.Black;
        btnAddAuction.NormalBorderColorD = Color.Black;
        btnAddAuction.NormalForeColor = Color.White;
        btnAddAuction.NormalShadowForeColor = Color.FromArgb(53, 53, 53);
        btnAddAuction.Size = new Size(121, 23);
        btnAddAuction.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        btnAddAuction.TabIndex = 13;
        btnAddAuction.Text = "Add";
        btnAddAuction.Click += btnAddAuction_Click;
        // 
        // btnRemoveAuction
        // 
        btnRemoveAuction.BackColor = Color.Black;
        btnRemoveAuction.Cursor = Cursors.Hand;
        btnRemoveAuction.DownBGColorA = Color.FromArgb(107, 107, 107);
        btnRemoveAuction.DownBGColorB = Color.FromArgb(123, 123, 123);
        btnRemoveAuction.DownBorderColorA = Color.FromArgb(227, 195, 95);
        btnRemoveAuction.DownBorderColorB = Color.FromArgb(227, 195, 95);
        btnRemoveAuction.DownBorderColorC = Color.FromArgb(169, 128, 56);
        btnRemoveAuction.DownBorderColorD = Color.FromArgb(169, 128, 56);
        btnRemoveAuction.DownForeColor = Color.White;
        btnRemoveAuction.DownShadowForeColor = Color.FromArgb(53, 53, 53);
        btnRemoveAuction.Font = new Font("Minecraft", 8.25F);
        btnRemoveAuction.ForeColor = Color.White;
        btnRemoveAuction.HoverBGColorA = Color.FromArgb(107, 107, 107);
        btnRemoveAuction.HoverBGColorB = Color.FromArgb(123, 123, 123);
        btnRemoveAuction.HoverBorderColorA = Color.White;
        btnRemoveAuction.HoverBorderColorB = Color.White;
        btnRemoveAuction.HoverBorderColorC = Color.White;
        btnRemoveAuction.HoverBorderColorD = Color.White;
        btnRemoveAuction.HoverForeColor = Color.White;
        btnRemoveAuction.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
        btnRemoveAuction.Location = new Point(162, 205);
        btnRemoveAuction.Name = "btnRemoveAuction";
        btnRemoveAuction.NormalBGColorA = Color.FromArgb(107, 107, 107);
        btnRemoveAuction.NormalBGColorB = Color.FromArgb(123, 123, 123);
        btnRemoveAuction.NormalBorderColorA = Color.DarkGray;
        btnRemoveAuction.NormalBorderColorB = Color.DarkGray;
        btnRemoveAuction.NormalBorderColorC = Color.Black;
        btnRemoveAuction.NormalBorderColorD = Color.Black;
        btnRemoveAuction.NormalForeColor = Color.White;
        btnRemoveAuction.NormalShadowForeColor = Color.FromArgb(53, 53, 53);
        btnRemoveAuction.Size = new Size(121, 23);
        btnRemoveAuction.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        btnRemoveAuction.TabIndex = 12;
        btnRemoveAuction.Text = "Remove";
        btnRemoveAuction.Click += btnRemoveAuction_Click;
        // 
        // tabMain
        // 
        tabMain.ActivePageBackColor = Color.FromArgb(76, 51, 11);
        tabMain.ActivePageBorderColor = Color.FromArgb(201, 198, 195);
        tabMain.ActivePageTextColor = Color.White;
        tabMain.BaseColor = Color.FromArgb(184, 139, 59);
        tabMain.Controls.Add(pgAuctions);
        tabMain.Controls.Add(pgSettings);
        tabMain.Controls.Add(pgAdmin);
        tabMain.DeactivePageTextColor = SystemColors.ScrollBar;
        tabMain.Dock = DockStyle.Fill;
        tabMain.ItemSize = new Size(80, 24);
        tabMain.Location = new Point(0, 0);
        tabMain.Multiline = true;
        tabMain.Name = "tabMain";
        tabMain.PageBackColor = Color.FromArgb(247, 186, 54);
        tabMain.PageEdgeBorderColor = Color.Cyan;
        tabMain.PageEdgeColor = Color.FromArgb(209, 170, 87);
        tabMain.SelectedIndex = 0;
        tabMain.Size = new Size(914, 472);
        tabMain.TabIndex = 2;
        // 
        // txtAdminServerUrl
        // 
        txtAdminServerUrl.Location = new Point(269, 383);
        txtAdminServerUrl.Name = "txtAdminServerUrl";
        txtAdminServerUrl.Size = new Size(238, 23);
        txtAdminServerUrl.TabIndex = 8;
        txtAdminServerUrl.KeyDown += txtAdminServerUrl_KeyDown;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(914, 472);
        Controls.Add(tabMain);
        Name = "MainForm";
        Text = "Hypixel Skyblock Status";
        Load += MainForm_Load;
        pgAdmin.ResumeLayout(false);
        pgAdmin.PerformLayout();
        grpUsers.ResumeLayout(false);
        grpUsers.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numPurgeInactive).EndInit();
        grpCleanup.ResumeLayout(false);
        grpCleanup.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numWatchExpiration).EndInit();
        ((System.ComponentModel.ISupportInitialize)numWatchCleanupInterval).EndInit();
        grpClientLimits.ResumeLayout(false);
        grpClientLimits.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numMaxPlayerRequestsPerMinute).EndInit();
        ((System.ComponentModel.ISupportInitialize)numMaxAuctionWatches).EndInit();
        grpServerSettings.ResumeLayout(false);
        grpServerSettings.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numItemCacheUpdateMinutes).EndInit();
        ((System.ComponentModel.ISupportInitialize)numAuctionCheckInterval).EndInit();
        ((System.ComponentModel.ISupportInitialize)numAuctionCacheRefresh).EndInit();
        ((System.ComponentModel.ISupportInitialize)numHypixelUpdateInterval).EndInit();
        pgSettings.ResumeLayout(false);
        pgSettings.PerformLayout();
        grpClientSettings.ResumeLayout(false);
        grpClientSettings.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numNotificationHistory).EndInit();
        grpServer.ResumeLayout(false);
        grpServer.PerformLayout();
        pgAuctions.ResumeLayout(false);
        grpAuctions.ResumeLayout(false);
        parrotGradientPanel1.ResumeLayout(false);
        parrotGradientPanel1.PerformLayout();
        tabMain.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TabPage pgAdmin;
    private Button btnStatus;
    private TextBox txtUpdateApiKey;
    private Button btnShutdownServer;
    private GroupBox grpUsers;
    private NumericUpDown numPurgeInactive;
    private Button btnPurgeInactive;
    private Button btnDelete;
    private Button btnUnblock;
    private Button btnBlock;
    private ListView lvUsers;
    private ColumnHeader clmUsername;
    private ColumnHeader clmBlocked;
    private ColumnHeader clmLastRequest;
    private Button btnRefreshUsers;
    private GroupBox grpCleanup;
    private NumericUpDown numWatchExpiration;
    private Label lblWatchExpiration;
    private NumericUpDown numWatchCleanupInterval;
    private Label lblWatchCleanupInterval;
    private GroupBox grpClientLimits;
    private NumericUpDown numMaxPlayerRequestsPerMinute;
    private Label lblMaxPlayerRequestsPerMinute;
    private NumericUpDown numMaxAuctionWatches;
    private Label lblMaxAuctionWatches;
    private GroupBox grpServerSettings;
    private NumericUpDown numItemCacheUpdateMinutes;
    private Label lblItemCacheUpdateMinutes;
    private NumericUpDown numAuctionCheckInterval;
    private Label lblAuctionCheckInterval;
    private NumericUpDown numAuctionCacheRefresh;
    private Label lblAuctionCacheRefrsh;
    private NumericUpDown numHypixelUpdateInterval;
    private Label lblHypixelUpdateInterval;
    private TabPage pgSettings;
    private Button btnHealth;
    private TextBox txtAdminKey;
    private Button btnReloadSettings;
    private Button btnSaveSettings;
    private GroupBox grpClientSettings;
    private Label lblServerUrl;
    private CheckBox chkMinimizeToTray;
    private Label lblLogtime;
    private CheckBox chkStartupNotificationHistory;
    private CheckBox chkAuctionNotifications;
    private NumericUpDown numNotificationHistory;
    private TextBox txtServerUrl;
    private TabPage pgAuctions;
    private GroupBox grpAuctions;
    private ListView lvAuctions;
    private ColumnHeader Item;
    private ColumnHeader Tier;
    private ColumnHeader PetLevel;
    private ColumnHeader Stars;
    private ColumnHeader Recomb;
    private ColumnHeader CheapestAuction;
    private ColumnHeader AuctionName;
    private ColumnHeader NotifyBelow;
    private ReaLTaiizor.Controls.DungeonTabPage tabMain;
    private GroupBox grpServer;
    private Label lblMaxAuctions;
    private ReaLTaiizor.Controls.SkyButton btnRemoveAuction;
    private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
    private ReaLTaiizor.Controls.SkyButton btnAddAuction;
    private ReaLTaiizor.Controls.SkyButton btnRefresh;
    private ReaLTaiizor.Controls.SkyLabel lblLastUpdate;
    private ReaLTaiizor.Controls.SkyLabel lblUsername;
    private ReaLTaiizor.Controls.SkyLabel lblServer;
    private ReaLTaiizor.Controls.SkyLabel lblPlayerCount;
    private Button btnBackup;
    private Label lblNotificationTitle;
    private TextBox txtNotificationTitle;
    private Label lblNotificationMessage;
    private RadioButton radNotificationSelected;
    private RadioButton radNotificationEveryone;
    private RichTextBox txtNotificationMessage;
    private ReaLTaiizor.Controls.AloneTextBox aloneTextBox1;
    private Button btnSendNotification;
    private TextBox txtAdminServerUrl;
}
