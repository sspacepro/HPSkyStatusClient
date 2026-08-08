namespace HPSkyStatusClient;

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
        grpServerSettings = new GroupBox();
        lblHypixelUpdateInterval = new Label();
        munHypixelUpdateInterval = new NumericUpDown();
        lblAuctionCacheRefrsh = new Label();
        numAuctionCacheRefresh = new NumericUpDown();
        lblAuctionCheckInterval = new Label();
        numAuctionCheckInterval = new NumericUpDown();
        lblItemCacheUpdateMinutes = new Label();
        numItemCacheUpdatteMinutes = new NumericUpDown();
        grpClientLimits = new GroupBox();
        lblMaxAuctionWatches = new Label();
        numMaxAuctionWatches = new NumericUpDown();
        lblMaxPlayerRequestsPerMinute = new Label();
        numMaxPlayerRequestsPerMinute = new NumericUpDown();
        grpCleanup = new GroupBox();
        lblWatchCleanupInterval = new Label();
        numWatchCleanupInterval = new NumericUpDown();
        lblWatchExpiration = new Label();
        numWatchExpiration = new NumericUpDown();
        grpUsers = new GroupBox();
        btnRefreshUsers = new Button();
        lvUsers = new ListView();
        clmUsername = new ColumnHeader();
        clmBlocked = new ColumnHeader();
        clmLastRequest = new ColumnHeader();
        btnBlock = new Button();
        btnUnblock = new Button();
        btnDelete = new Button();
        btnPurgeInactive = new Button();
        numPurgeInactive = new NumericUpDown();
        btnShutdownServer = new Button();
        txtUpdateApiKey = new TextBox();
        btnStatus = new Button();
        pgSettings = new TabPage();
        grpClientSettings = new GroupBox();
        txtServerUrl = new TextBox();
        numNotificationHistory = new NumericUpDown();
        chkAuctionNotifications = new CheckBox();
        chkStartupNotificationHistory = new CheckBox();
        lblLogtime = new Label();
        chkMinimizeToTray = new CheckBox();
        lblServerUrl = new Label();
        btnSaveSettings = new Button();
        btnReloadSettings = new Button();
        txtAdminKey = new TextBox();
        btnHealth = new Button();
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
        btnAddAuction = new Button();
        btnRemoveAuction = new Button();
        tabMain = new TabControl();
        btnRefresh = new Button();
        lblLastUpdate = new Label();
        lblServer = new Label();
        lblPlayerCount = new Label();
        lblUsername = new Label();
        lblMaxAuctions = new Label();
        grpServer = new GroupBox();
        pgAdmin.SuspendLayout();
        grpServerSettings.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)munHypixelUpdateInterval).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numAuctionCacheRefresh).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numAuctionCheckInterval).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numItemCacheUpdatteMinutes).BeginInit();
        grpClientLimits.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numMaxAuctionWatches).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numMaxPlayerRequestsPerMinute).BeginInit();
        grpCleanup.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numWatchCleanupInterval).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numWatchExpiration).BeginInit();
        grpUsers.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numPurgeInactive).BeginInit();
        pgSettings.SuspendLayout();
        grpClientSettings.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numNotificationHistory).BeginInit();
        pgAuctions.SuspendLayout();
        grpAuctions.SuspendLayout();
        tabMain.SuspendLayout();
        grpServer.SuspendLayout();
        SuspendLayout();
        // 
        // pgAdmin
        // 
        pgAdmin.Controls.Add(btnStatus);
        pgAdmin.Controls.Add(txtUpdateApiKey);
        pgAdmin.Controls.Add(btnShutdownServer);
        pgAdmin.Controls.Add(grpUsers);
        pgAdmin.Controls.Add(grpCleanup);
        pgAdmin.Controls.Add(grpClientLimits);
        pgAdmin.Controls.Add(grpServerSettings);
        pgAdmin.Location = new Point(4, 24);
        pgAdmin.Name = "pgAdmin";
        pgAdmin.Padding = new Padding(3);
        pgAdmin.Size = new Size(792, 444);
        pgAdmin.TabIndex = 4;
        pgAdmin.Text = "Admin";
        pgAdmin.UseVisualStyleBackColor = true;
        // 
        // grpServerSettings
        // 
        grpServerSettings.Controls.Add(numItemCacheUpdatteMinutes);
        grpServerSettings.Controls.Add(lblItemCacheUpdateMinutes);
        grpServerSettings.Controls.Add(numAuctionCheckInterval);
        grpServerSettings.Controls.Add(lblAuctionCheckInterval);
        grpServerSettings.Controls.Add(numAuctionCacheRefresh);
        grpServerSettings.Controls.Add(lblAuctionCacheRefrsh);
        grpServerSettings.Controls.Add(munHypixelUpdateInterval);
        grpServerSettings.Controls.Add(lblHypixelUpdateInterval);
        grpServerSettings.Location = new Point(6, 6);
        grpServerSettings.Name = "grpServerSettings";
        grpServerSettings.Size = new Size(251, 200);
        grpServerSettings.TabIndex = 0;
        grpServerSettings.TabStop = false;
        grpServerSettings.Text = "Server Settings";
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
        // munHypixelUpdateInterval
        // 
        munHypixelUpdateInterval.Location = new Point(6, 37);
        munHypixelUpdateInterval.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        munHypixelUpdateInterval.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
        munHypixelUpdateInterval.Name = "munHypixelUpdateInterval";
        munHypixelUpdateInterval.Size = new Size(120, 23);
        munHypixelUpdateInterval.TabIndex = 1;
        munHypixelUpdateInterval.Value = new decimal(new int[] { 10, 0, 0, 0 });
        munHypixelUpdateInterval.KeyDown += munHypixelUpdateInterval_KeyDown;
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
        // lblAuctionCheckInterval
        // 
        lblAuctionCheckInterval.AutoSize = true;
        lblAuctionCheckInterval.Location = new Point(6, 107);
        lblAuctionCheckInterval.Name = "lblAuctionCheckInterval";
        lblAuctionCheckInterval.Size = new Size(188, 15);
        lblAuctionCheckInterval.TabIndex = 4;
        lblAuctionCheckInterval.Text = "Scan Cache For Auctions Seconds:";
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
        // lblItemCacheUpdateMinutes
        // 
        lblItemCacheUpdateMinutes.AutoSize = true;
        lblItemCacheUpdateMinutes.Location = new Point(0, 151);
        lblItemCacheUpdateMinutes.Name = "lblItemCacheUpdateMinutes";
        lblItemCacheUpdateMinutes.Size = new Size(192, 15);
        lblItemCacheUpdateMinutes.TabIndex = 6;
        lblItemCacheUpdateMinutes.Text = "Item Name Cache Update Minutes:";
        // 
        // numItemCacheUpdatteMinutes
        // 
        numItemCacheUpdatteMinutes.Location = new Point(6, 169);
        numItemCacheUpdatteMinutes.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        numItemCacheUpdatteMinutes.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
        numItemCacheUpdatteMinutes.Name = "numItemCacheUpdatteMinutes";
        numItemCacheUpdatteMinutes.Size = new Size(120, 23);
        numItemCacheUpdatteMinutes.TabIndex = 7;
        numItemCacheUpdatteMinutes.Value = new decimal(new int[] { 10, 0, 0, 0 });
        numItemCacheUpdatteMinutes.KeyDown += numItemCacheUpdatteMinutes_KeyDown;
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
        // lblMaxAuctionWatches
        // 
        lblMaxAuctionWatches.AutoSize = true;
        lblMaxAuctionWatches.Location = new Point(6, 19);
        lblMaxAuctionWatches.Name = "lblMaxAuctionWatches";
        lblMaxAuctionWatches.Size = new Size(125, 15);
        lblMaxAuctionWatches.TabIndex = 0;
        lblMaxAuctionWatches.Text = "Max Auction Watches:";
        // 
        // numMaxAuctionWatches
        // 
        numMaxAuctionWatches.Location = new Point(6, 37);
        numMaxAuctionWatches.Name = "numMaxAuctionWatches";
        numMaxAuctionWatches.Size = new Size(120, 23);
        numMaxAuctionWatches.TabIndex = 1;
        numMaxAuctionWatches.KeyDown += numMaxAuctionWatches_KeyDown;
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
        // numMaxPlayerRequestsPerMinute
        // 
        numMaxPlayerRequestsPerMinute.Location = new Point(6, 81);
        numMaxPlayerRequestsPerMinute.Name = "numMaxPlayerRequestsPerMinute";
        numMaxPlayerRequestsPerMinute.Size = new Size(120, 23);
        numMaxPlayerRequestsPerMinute.TabIndex = 3;
        numMaxPlayerRequestsPerMinute.KeyDown += numMaxPlayerRequestsPerMinute_KeyDown;
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
        // lblWatchCleanupInterval
        // 
        lblWatchCleanupInterval.AutoSize = true;
        lblWatchCleanupInterval.Location = new Point(2, 19);
        lblWatchCleanupInterval.Name = "lblWatchCleanupInterval";
        lblWatchCleanupInterval.Size = new Size(231, 15);
        lblWatchCleanupInterval.TabIndex = 0;
        lblWatchCleanupInterval.Text = "Cleanup Expired Watches Interval minutes:";
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
        // lblWatchExpiration
        // 
        lblWatchExpiration.AutoSize = true;
        lblWatchExpiration.Location = new Point(6, 63);
        lblWatchExpiration.Name = "lblWatchExpiration";
        lblWatchExpiration.Size = new Size(127, 15);
        lblWatchExpiration.TabIndex = 2;
        lblWatchExpiration.Text = "Watch Expiration Days:";
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
        // grpUsers
        // 
        grpUsers.Controls.Add(numPurgeInactive);
        grpUsers.Controls.Add(btnPurgeInactive);
        grpUsers.Controls.Add(btnDelete);
        grpUsers.Controls.Add(btnUnblock);
        grpUsers.Controls.Add(btnBlock);
        grpUsers.Controls.Add(lvUsers);
        grpUsers.Controls.Add(btnRefreshUsers);
        grpUsers.Location = new Point(263, 6);
        grpUsers.Name = "grpUsers";
        grpUsers.Size = new Size(303, 313);
        grpUsers.TabIndex = 3;
        grpUsers.TabStop = false;
        grpUsers.Text = "Users";
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
        // lvUsers
        // 
        lvUsers.Columns.AddRange(new ColumnHeader[] { clmUsername, clmBlocked, clmLastRequest });
        lvUsers.FullRowSelect = true;
        lvUsers.GridLines = true;
        lvUsers.Location = new Point(6, 44);
        lvUsers.MultiSelect = false;
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
        // numPurgeInactive
        // 
        numPurgeInactive.Location = new Point(6, 256);
        numPurgeInactive.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
        numPurgeInactive.Name = "numPurgeInactive";
        numPurgeInactive.Size = new Size(120, 23);
        numPurgeInactive.TabIndex = 4;
        // 
        // btnShutdownServer
        // 
        btnShutdownServer.Location = new Point(263, 351);
        btnShutdownServer.Name = "btnShutdownServer";
        btnShutdownServer.Size = new Size(75, 23);
        btnShutdownServer.TabIndex = 4;
        btnShutdownServer.Text = "Shutdown Server";
        btnShutdownServer.UseVisualStyleBackColor = true;
        btnShutdownServer.Click += btnShutdownServer_Click;
        // 
        // txtUpdateApiKey
        // 
        txtUpdateApiKey.Location = new Point(263, 322);
        txtUpdateApiKey.Name = "txtUpdateApiKey";
        txtUpdateApiKey.PlaceholderText = "Update Api Key";
        txtUpdateApiKey.Size = new Size(238, 23);
        txtUpdateApiKey.TabIndex = 5;
        txtUpdateApiKey.KeyDown += txtUpdateApiKey_KeyDown;
        // 
        // btnStatus
        // 
        btnStatus.Location = new Point(344, 351);
        btnStatus.Name = "btnStatus";
        btnStatus.Size = new Size(75, 23);
        btnStatus.TabIndex = 6;
        btnStatus.Text = "Status";
        btnStatus.UseVisualStyleBackColor = true;
        btnStatus.Click += btnStatus_Click;
        // 
        // pgSettings
        // 
        pgSettings.Controls.Add(btnHealth);
        pgSettings.Controls.Add(txtAdminKey);
        pgSettings.Controls.Add(btnReloadSettings);
        pgSettings.Controls.Add(btnSaveSettings);
        pgSettings.Controls.Add(grpClientSettings);
        pgSettings.Controls.Add(grpServer);
        pgSettings.Location = new Point(4, 24);
        pgSettings.Name = "pgSettings";
        pgSettings.Padding = new Padding(3);
        pgSettings.Size = new Size(792, 444);
        pgSettings.TabIndex = 3;
        pgSettings.Text = "Settings";
        pgSettings.UseVisualStyleBackColor = true;
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
        // txtServerUrl
        // 
        txtServerUrl.Location = new Point(5, 37);
        txtServerUrl.Name = "txtServerUrl";
        txtServerUrl.PlaceholderText = "test";
        txtServerUrl.Size = new Size(261, 23);
        txtServerUrl.TabIndex = 0;
        txtServerUrl.Text = "test";
        txtServerUrl.TextChanged += txtServerUrl_TextChanged;
        // 
        // numNotificationHistory
        // 
        numNotificationHistory.Location = new Point(6, 131);
        numNotificationHistory.Name = "numNotificationHistory";
        numNotificationHistory.Size = new Size(120, 23);
        numNotificationHistory.TabIndex = 1;
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
        // lblLogtime
        // 
        lblLogtime.AutoSize = true;
        lblLogtime.Location = new Point(6, 111);
        lblLogtime.Name = "lblLogtime";
        lblLogtime.Size = new Size(163, 15);
        lblLogtime.TabIndex = 5;
        lblLogtime.Text = "Notification history (minutes)";
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
        // lblServerUrl
        // 
        lblServerUrl.AutoSize = true;
        lblServerUrl.Location = new Point(5, 19);
        lblServerUrl.Name = "lblServerUrl";
        lblServerUrl.Size = new Size(92, 15);
        lblServerUrl.TabIndex = 7;
        lblServerUrl.Text = "Server adress url";
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
        // pgAuctions
        // 
        pgAuctions.Controls.Add(grpAuctions);
        pgAuctions.Location = new Point(4, 24);
        pgAuctions.Name = "pgAuctions";
        pgAuctions.Padding = new Padding(3);
        pgAuctions.Size = new Size(792, 444);
        pgAuctions.TabIndex = 2;
        pgAuctions.Text = "Status";
        pgAuctions.UseVisualStyleBackColor = true;
        // 
        // grpAuctions
        // 
        grpAuctions.Controls.Add(btnRefresh);
        grpAuctions.Controls.Add(lblLastUpdate);
        grpAuctions.Controls.Add(lblServer);
        grpAuctions.Controls.Add(lblPlayerCount);
        grpAuctions.Controls.Add(lblUsername);
        grpAuctions.Controls.Add(btnRemoveAuction);
        grpAuctions.Controls.Add(btnAddAuction);
        grpAuctions.Controls.Add(lvAuctions);
        grpAuctions.Dock = DockStyle.Fill;
        grpAuctions.Location = new Point(3, 3);
        grpAuctions.Name = "grpAuctions";
        grpAuctions.Size = new Size(786, 438);
        grpAuctions.TabIndex = 0;
        grpAuctions.TabStop = false;
        grpAuctions.Text = "Status";
        // 
        // lvAuctions
        // 
        lvAuctions.Columns.AddRange(new ColumnHeader[] { Item, Tier, PetLevel, Stars, Recomb, CheapestAuction, AuctionName, NotifyBelow });
        lvAuctions.FullRowSelect = true;
        lvAuctions.GridLines = true;
        lvAuctions.Location = new Point(3, 76);
        lvAuctions.MultiSelect = false;
        lvAuctions.Name = "lvAuctions";
        lvAuctions.Size = new Size(783, 142);
        lvAuctions.TabIndex = 0;
        lvAuctions.UseCompatibleStateImageBehavior = false;
        lvAuctions.View = View.Details;
        lvAuctions.DoubleClick += lvAuctions_DoubleClick;
        // 
        // Item
        // 
        Item.Text = "Item";
        Item.Width = 130;
        // 
        // Tier
        // 
        Tier.Text = "Tier";
        Tier.Width = 85;
        // 
        // PetLevel
        // 
        PetLevel.Text = "Pet Level";
        // 
        // Stars
        // 
        Stars.Text = "Stars";
        Stars.Width = 45;
        // 
        // Recomb
        // 
        Recomb.Text = "Recomb";
        // 
        // CheapestAuction
        // 
        CheapestAuction.Text = "Cheapest Auction";
        CheapestAuction.Width = 110;
        // 
        // AuctionName
        // 
        AuctionName.Text = "Auction Name";
        AuctionName.Width = 177;
        // 
        // NotifyBelow
        // 
        NotifyBelow.Text = "Notify Below";
        NotifyBelow.Width = 110;
        // 
        // btnAddAuction
        // 
        btnAddAuction.Location = new Point(6, 224);
        btnAddAuction.Name = "btnAddAuction";
        btnAddAuction.Size = new Size(75, 23);
        btnAddAuction.TabIndex = 1;
        btnAddAuction.Text = "Add Auction";
        btnAddAuction.UseVisualStyleBackColor = true;
        btnAddAuction.Click += btnAddAuction_Click;
        // 
        // btnRemoveAuction
        // 
        btnRemoveAuction.Location = new Point(87, 224);
        btnRemoveAuction.Name = "btnRemoveAuction";
        btnRemoveAuction.Size = new Size(75, 23);
        btnRemoveAuction.TabIndex = 2;
        btnRemoveAuction.Text = "Remove Auction";
        btnRemoveAuction.UseVisualStyleBackColor = true;
        btnRemoveAuction.Click += btnRemoveAuction_Click;
        // 
        // tabMain
        // 
        tabMain.Controls.Add(pgAuctions);
        tabMain.Controls.Add(pgSettings);
        tabMain.Controls.Add(pgAdmin);
        tabMain.Dock = DockStyle.Fill;
        tabMain.Location = new Point(0, 0);
        tabMain.Multiline = true;
        tabMain.Name = "tabMain";
        tabMain.SelectedIndex = 0;
        tabMain.Size = new Size(800, 472);
        tabMain.TabIndex = 2;
        // 
        // btnRefresh
        // 
        btnRefresh.Location = new Point(145, 37);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(75, 23);
        btnRefresh.TabIndex = 9;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = true;
        // 
        // lblLastUpdate
        // 
        lblLastUpdate.AutoSize = true;
        lblLastUpdate.Location = new Point(145, 19);
        lblLastUpdate.Name = "lblLastUpdate";
        lblLastUpdate.Size = new Size(72, 15);
        lblLastUpdate.TabIndex = 8;
        lblLastUpdate.Text = "Last Update:";
        // 
        // lblServer
        // 
        lblServer.AutoSize = true;
        lblServer.Location = new Point(6, 49);
        lblServer.Name = "lblServer";
        lblServer.Size = new Size(42, 15);
        lblServer.TabIndex = 7;
        lblServer.Text = "Server:";
        // 
        // lblPlayerCount
        // 
        lblPlayerCount.AutoSize = true;
        lblPlayerCount.Location = new Point(6, 34);
        lblPlayerCount.Name = "lblPlayerCount";
        lblPlayerCount.Size = new Size(47, 15);
        lblPlayerCount.TabIndex = 6;
        lblPlayerCount.Text = "Players:";
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Location = new Point(5, 19);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(63, 15);
        lblUsername.TabIndex = 5;
        lblUsername.Text = "Username:";
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
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 472);
        Controls.Add(tabMain);
        Name = "MainForm";
        Text = "MainForm";
        Load += MainForm_Load;
        pgAdmin.ResumeLayout(false);
        pgAdmin.PerformLayout();
        grpServerSettings.ResumeLayout(false);
        grpServerSettings.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)munHypixelUpdateInterval).EndInit();
        ((System.ComponentModel.ISupportInitialize)numAuctionCacheRefresh).EndInit();
        ((System.ComponentModel.ISupportInitialize)numAuctionCheckInterval).EndInit();
        ((System.ComponentModel.ISupportInitialize)numItemCacheUpdatteMinutes).EndInit();
        grpClientLimits.ResumeLayout(false);
        grpClientLimits.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numMaxAuctionWatches).EndInit();
        ((System.ComponentModel.ISupportInitialize)numMaxPlayerRequestsPerMinute).EndInit();
        grpCleanup.ResumeLayout(false);
        grpCleanup.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numWatchCleanupInterval).EndInit();
        ((System.ComponentModel.ISupportInitialize)numWatchExpiration).EndInit();
        grpUsers.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numPurgeInactive).EndInit();
        pgSettings.ResumeLayout(false);
        pgSettings.PerformLayout();
        grpClientSettings.ResumeLayout(false);
        grpClientSettings.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numNotificationHistory).EndInit();
        pgAuctions.ResumeLayout(false);
        grpAuctions.ResumeLayout(false);
        grpAuctions.PerformLayout();
        tabMain.ResumeLayout(false);
        grpServer.ResumeLayout(false);
        grpServer.PerformLayout();
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
    private NumericUpDown numItemCacheUpdatteMinutes;
    private Label lblItemCacheUpdateMinutes;
    private NumericUpDown numAuctionCheckInterval;
    private Label lblAuctionCheckInterval;
    private NumericUpDown numAuctionCacheRefresh;
    private Label lblAuctionCacheRefrsh;
    private NumericUpDown munHypixelUpdateInterval;
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
    private Button btnRefresh;
    private Label lblLastUpdate;
    private Label lblServer;
    private Label lblPlayerCount;
    private Label lblUsername;
    private Button btnRemoveAuction;
    private Button btnAddAuction;
    private ListView lvAuctions;
    private ColumnHeader Item;
    private ColumnHeader Tier;
    private ColumnHeader PetLevel;
    private ColumnHeader Stars;
    private ColumnHeader Recomb;
    private ColumnHeader CheapestAuction;
    private ColumnHeader AuctionName;
    private ColumnHeader NotifyBelow;
    private TabControl tabMain;
    private GroupBox grpServer;
    private Label lblMaxAuctions;
}
