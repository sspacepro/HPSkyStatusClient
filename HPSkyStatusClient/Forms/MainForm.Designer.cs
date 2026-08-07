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
        grpStatus = new GroupBox();
        btnRefresh = new Button();
        lblLastUpdate = new Label();
        lblServer = new Label();
        lblPlayerCount = new Label();
        lblUsername = new Label();
        grpPlayers = new GroupBox();
        btnRemovePlayer = new Button();
        btnAddPlayer = new Button();
        lvPlayers = new ListView();
        Username = new ColumnHeader();
        Status = new ColumnHeader();
        lblLocation = new ColumnHeader();
        tabMain = new TabControl();
        pgStatus = new TabPage();
        pgPlayers = new TabPage();
        pgAuctions = new TabPage();
        grpAuctions = new GroupBox();
        btnRemoveAuction = new Button();
        btnAddAuction = new Button();
        lvAuctions = new ListView();
        Item = new ColumnHeader();
        Tier = new ColumnHeader();
        PetLevel = new ColumnHeader();
        Stars = new ColumnHeader();
        Recomb = new ColumnHeader();
        CheapestAuction = new ColumnHeader();
        AuctionName = new ColumnHeader();
        NotifyBelow = new ColumnHeader();
        pgSettings = new TabPage();
        txtAdminKey = new TextBox();
        btnReloadSettings = new Button();
        btnSaveSettings = new Button();
        grpClientSettings = new GroupBox();
        lblServerUrl = new Label();
        chkMinimizeToTray = new CheckBox();
        lblLogtime = new Label();
        chkStartupNotificationHistory = new CheckBox();
        chkAuctionNotifications = new CheckBox();
        chkPlayerNotifications = new CheckBox();
        numNotificationHistory = new NumericUpDown();
        txtServerUrl = new TextBox();
        grpServer = new GroupBox();
        lblMaxAuctions = new Label();
        lblMaxPlayers = new Label();
        pgAdmin = new TabPage();
        txtUpdateApiKey = new TextBox();
        btnShutdownServer = new Button();
        grpUsers = new GroupBox();
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
        numItemCacheUpdatteMinutes = new NumericUpDown();
        lblItemCacheUpdateMinutes = new Label();
        numAuctionCheckInterval = new NumericUpDown();
        lblAuctionCheckInterval = new Label();
        numAuctionCacheRefresh = new NumericUpDown();
        lblAuctionCacheRefrsh = new Label();
        munHypixelUpdateInterval = new NumericUpDown();
        lblHypixelUpdateInterval = new Label();
        grpStatus.SuspendLayout();
        grpPlayers.SuspendLayout();
        tabMain.SuspendLayout();
        pgStatus.SuspendLayout();
        pgPlayers.SuspendLayout();
        pgAuctions.SuspendLayout();
        grpAuctions.SuspendLayout();
        pgSettings.SuspendLayout();
        grpClientSettings.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numNotificationHistory).BeginInit();
        grpServer.SuspendLayout();
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
        ((System.ComponentModel.ISupportInitialize)numItemCacheUpdatteMinutes).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numAuctionCheckInterval).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numAuctionCacheRefresh).BeginInit();
        ((System.ComponentModel.ISupportInitialize)munHypixelUpdateInterval).BeginInit();
        SuspendLayout();
        // 
        // grpStatus
        // 
        grpStatus.Controls.Add(btnRefresh);
        grpStatus.Controls.Add(lblLastUpdate);
        grpStatus.Controls.Add(lblServer);
        grpStatus.Controls.Add(lblPlayerCount);
        grpStatus.Controls.Add(lblUsername);
        grpStatus.Dock = DockStyle.Fill;
        grpStatus.Location = new Point(3, 3);
        grpStatus.Name = "grpStatus";
        grpStatus.Size = new Size(786, 438);
        grpStatus.TabIndex = 0;
        grpStatus.TabStop = false;
        grpStatus.Text = "Status";
        // 
        // btnRefresh
        // 
        btnRefresh.Location = new Point(12, 137);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(75, 23);
        btnRefresh.TabIndex = 4;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = true;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // lblLastUpdate
        // 
        lblLastUpdate.AutoSize = true;
        lblLastUpdate.Location = new Point(12, 109);
        lblLastUpdate.Name = "lblLastUpdate";
        lblLastUpdate.Size = new Size(72, 15);
        lblLastUpdate.TabIndex = 3;
        lblLastUpdate.Text = "Last Update:";
        // 
        // lblServer
        // 
        lblServer.AutoSize = true;
        lblServer.Location = new Point(12, 94);
        lblServer.Name = "lblServer";
        lblServer.Size = new Size(42, 15);
        lblServer.TabIndex = 2;
        lblServer.Text = "Server:";
        // 
        // lblPlayerCount
        // 
        lblPlayerCount.AutoSize = true;
        lblPlayerCount.Location = new Point(12, 79);
        lblPlayerCount.Name = "lblPlayerCount";
        lblPlayerCount.Size = new Size(47, 15);
        lblPlayerCount.TabIndex = 1;
        lblPlayerCount.Text = "Players:";
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Location = new Point(12, 64);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(63, 15);
        lblUsername.TabIndex = 0;
        lblUsername.Text = "Username:";
        // 
        // grpPlayers
        // 
        grpPlayers.Controls.Add(btnRemovePlayer);
        grpPlayers.Controls.Add(btnAddPlayer);
        grpPlayers.Controls.Add(lvPlayers);
        grpPlayers.Dock = DockStyle.Fill;
        grpPlayers.Location = new Point(3, 3);
        grpPlayers.Name = "grpPlayers";
        grpPlayers.Size = new Size(786, 438);
        grpPlayers.TabIndex = 1;
        grpPlayers.TabStop = false;
        grpPlayers.Text = "Watched Players";
        // 
        // btnRemovePlayer
        // 
        btnRemovePlayer.Location = new Point(92, 132);
        btnRemovePlayer.Name = "btnRemovePlayer";
        btnRemovePlayer.Size = new Size(75, 23);
        btnRemovePlayer.TabIndex = 2;
        btnRemovePlayer.Text = "Remove Player";
        btnRemovePlayer.UseVisualStyleBackColor = true;
        btnRemovePlayer.Click += btnRemovePlayer_Click;
        // 
        // btnAddPlayer
        // 
        btnAddPlayer.Location = new Point(11, 132);
        btnAddPlayer.Name = "btnAddPlayer";
        btnAddPlayer.Size = new Size(75, 23);
        btnAddPlayer.TabIndex = 1;
        btnAddPlayer.Text = "Add Player";
        btnAddPlayer.UseVisualStyleBackColor = true;
        btnAddPlayer.Click += btnAddPlayer_Click;
        // 
        // lvPlayers
        // 
        lvPlayers.Columns.AddRange(new ColumnHeader[] { Username, Status, lblLocation });
        lvPlayers.FullRowSelect = true;
        lvPlayers.GridLines = true;
        lvPlayers.Location = new Point(11, 22);
        lvPlayers.MultiSelect = false;
        lvPlayers.Name = "lvPlayers";
        lvPlayers.Size = new Size(406, 104);
        lvPlayers.TabIndex = 0;
        lvPlayers.UseCompatibleStateImageBehavior = false;
        lvPlayers.View = View.Details;
        // 
        // Username
        // 
        Username.Text = "Username";
        Username.Width = 140;
        // 
        // Status
        // 
        Status.Text = "Status";
        Status.Width = 80;
        // 
        // lblLocation
        // 
        lblLocation.Text = "Location";
        lblLocation.Width = 180;
        // 
        // tabMain
        // 
        tabMain.Controls.Add(pgStatus);
        tabMain.Controls.Add(pgPlayers);
        tabMain.Controls.Add(pgAuctions);
        tabMain.Controls.Add(pgSettings);
        tabMain.Controls.Add(pgAdmin);
        tabMain.Dock = DockStyle.Fill;
        tabMain.Location = new Point(0, 0);
        tabMain.Name = "tabMain";
        tabMain.SelectedIndex = 0;
        tabMain.Size = new Size(800, 472);
        tabMain.TabIndex = 2;
        // 
        // pgStatus
        // 
        pgStatus.Controls.Add(grpStatus);
        pgStatus.Location = new Point(4, 24);
        pgStatus.Name = "pgStatus";
        pgStatus.Padding = new Padding(3);
        pgStatus.Size = new Size(792, 444);
        pgStatus.TabIndex = 0;
        pgStatus.Text = "Status";
        pgStatus.UseVisualStyleBackColor = true;
        // 
        // pgPlayers
        // 
        pgPlayers.Controls.Add(grpPlayers);
        pgPlayers.Location = new Point(4, 24);
        pgPlayers.Name = "pgPlayers";
        pgPlayers.Padding = new Padding(3);
        pgPlayers.Size = new Size(792, 444);
        pgPlayers.TabIndex = 1;
        pgPlayers.Text = "Players";
        pgPlayers.UseVisualStyleBackColor = true;
        // 
        // pgAuctions
        // 
        pgAuctions.Controls.Add(grpAuctions);
        pgAuctions.Location = new Point(4, 24);
        pgAuctions.Name = "pgAuctions";
        pgAuctions.Padding = new Padding(3);
        pgAuctions.Size = new Size(792, 444);
        pgAuctions.TabIndex = 2;
        pgAuctions.Text = "Auctions";
        pgAuctions.UseVisualStyleBackColor = true;
        // 
        // grpAuctions
        // 
        grpAuctions.Controls.Add(btnRemoveAuction);
        grpAuctions.Controls.Add(btnAddAuction);
        grpAuctions.Controls.Add(lvAuctions);
        grpAuctions.Dock = DockStyle.Fill;
        grpAuctions.Location = new Point(3, 3);
        grpAuctions.Name = "grpAuctions";
        grpAuctions.Size = new Size(786, 438);
        grpAuctions.TabIndex = 0;
        grpAuctions.TabStop = false;
        grpAuctions.Text = "Auction Watches";
        // 
        // btnRemoveAuction
        // 
        btnRemoveAuction.Location = new Point(87, 165);
        btnRemoveAuction.Name = "btnRemoveAuction";
        btnRemoveAuction.Size = new Size(75, 23);
        btnRemoveAuction.TabIndex = 2;
        btnRemoveAuction.Text = "Remove Auction";
        btnRemoveAuction.UseVisualStyleBackColor = true;
        btnRemoveAuction.Click += btnRemoveAuction_Click;
        // 
        // btnAddAuction
        // 
        btnAddAuction.Location = new Point(6, 165);
        btnAddAuction.Name = "btnAddAuction";
        btnAddAuction.Size = new Size(75, 23);
        btnAddAuction.TabIndex = 1;
        btnAddAuction.Text = "Add Auction";
        btnAddAuction.UseVisualStyleBackColor = true;
        btnAddAuction.Click += btnAddAuction_Click;
        // 
        // lvAuctions
        // 
        lvAuctions.Columns.AddRange(new ColumnHeader[] { Item, Tier, PetLevel, Stars, Recomb, CheapestAuction, AuctionName, NotifyBelow });
        lvAuctions.FullRowSelect = true;
        lvAuctions.GridLines = true;
        lvAuctions.Location = new Point(3, 17);
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
        // pgSettings
        // 
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
        // txtAdminKey
        // 
        txtAdminKey.Location = new Point(3, 303);
        txtAdminKey.Name = "txtAdminKey";
        txtAdminKey.PlaceholderText = "Admin Key";
        txtAdminKey.Size = new Size(272, 23);
        txtAdminKey.TabIndex = 4;
        txtAdminKey.UseSystemPasswordChar = true;
        txtAdminKey.KeyDown += txtAdminKey_KeyDown;
        // 
        // btnReloadSettings
        // 
        btnReloadSettings.Location = new Point(89, 274);
        btnReloadSettings.Name = "btnReloadSettings";
        btnReloadSettings.Size = new Size(75, 23);
        btnReloadSettings.TabIndex = 3;
        btnReloadSettings.Text = "Reload";
        btnReloadSettings.UseVisualStyleBackColor = true;
        btnReloadSettings.Click += btnReloadSettings_Click;
        // 
        // btnSaveSettings
        // 
        btnSaveSettings.Location = new Point(8, 274);
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
        grpClientSettings.Controls.Add(chkPlayerNotifications);
        grpClientSettings.Controls.Add(numNotificationHistory);
        grpClientSettings.Controls.Add(txtServerUrl);
        grpClientSettings.Location = new Point(2, 59);
        grpClientSettings.Name = "grpClientSettings";
        grpClientSettings.Size = new Size(273, 209);
        grpClientSettings.TabIndex = 1;
        grpClientSettings.TabStop = false;
        grpClientSettings.Text = "Client Settings";
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
        // chkMinimizeToTray
        // 
        chkMinimizeToTray.AutoSize = true;
        chkMinimizeToTray.Location = new Point(5, 187);
        chkMinimizeToTray.Name = "chkMinimizeToTray";
        chkMinimizeToTray.Size = new Size(112, 19);
        chkMinimizeToTray.TabIndex = 6;
        chkMinimizeToTray.Text = "Minimize to tray";
        chkMinimizeToTray.UseVisualStyleBackColor = true;
        // 
        // lblLogtime
        // 
        lblLogtime.AutoSize = true;
        lblLogtime.Location = new Point(5, 143);
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
        chkStartupNotificationHistory.Location = new Point(5, 116);
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
        chkAuctionNotifications.Location = new Point(5, 91);
        chkAuctionNotifications.Name = "chkAuctionNotifications";
        chkAuctionNotifications.Size = new Size(178, 19);
        chkAuctionNotifications.TabIndex = 3;
        chkAuctionNotifications.Text = "Receive auction notifications";
        chkAuctionNotifications.UseVisualStyleBackColor = true;
        // 
        // chkPlayerNotifications
        // 
        chkPlayerNotifications.AutoSize = true;
        chkPlayerNotifications.Checked = true;
        chkPlayerNotifications.CheckState = CheckState.Checked;
        chkPlayerNotifications.Location = new Point(5, 66);
        chkPlayerNotifications.Name = "chkPlayerNotifications";
        chkPlayerNotifications.Size = new Size(170, 19);
        chkPlayerNotifications.TabIndex = 2;
        chkPlayerNotifications.Text = "Receive player notifications";
        chkPlayerNotifications.UseVisualStyleBackColor = true;
        // 
        // numNotificationHistory
        // 
        numNotificationHistory.Location = new Point(5, 161);
        numNotificationHistory.Name = "numNotificationHistory";
        numNotificationHistory.Size = new Size(120, 23);
        numNotificationHistory.TabIndex = 1;
        // 
        // txtServerUrl
        // 
        txtServerUrl.Location = new Point(5, 37);
        txtServerUrl.Name = "txtServerUrl";
        txtServerUrl.PlaceholderText = "test";
        txtServerUrl.Size = new Size(261, 23);
        txtServerUrl.TabIndex = 0;
        txtServerUrl.Text = "test";
        // 
        // grpServer
        // 
        grpServer.Controls.Add(lblMaxAuctions);
        grpServer.Controls.Add(lblMaxPlayers);
        grpServer.Location = new Point(1, 1);
        grpServer.Name = "grpServer";
        grpServer.Size = new Size(274, 58);
        grpServer.TabIndex = 0;
        grpServer.TabStop = false;
        grpServer.Text = "Server Limits";
        // 
        // lblMaxAuctions
        // 
        lblMaxAuctions.AutoSize = true;
        lblMaxAuctions.Location = new Point(6, 34);
        lblMaxAuctions.Name = "lblMaxAuctions";
        lblMaxAuctions.Size = new Size(0, 15);
        lblMaxAuctions.TabIndex = 1;
        // 
        // lblMaxPlayers
        // 
        lblMaxPlayers.AutoSize = true;
        lblMaxPlayers.Location = new Point(5, 19);
        lblMaxPlayers.Name = "lblMaxPlayers";
        lblMaxPlayers.Size = new Size(0, 15);
        lblMaxPlayers.TabIndex = 0;
        // 
        // pgAdmin
        // 
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
        // txtUpdateApiKey
        // 
        txtUpdateApiKey.Location = new Point(263, 322);
        txtUpdateApiKey.Name = "txtUpdateApiKey";
        txtUpdateApiKey.PlaceholderText = "Update Api Key";
        txtUpdateApiKey.Size = new Size(238, 23);
        txtUpdateApiKey.TabIndex = 5;
        txtUpdateApiKey.KeyDown += txtUpdateApiKey_KeyDown;
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
        // numItemCacheUpdatteMinutes
        // 
        numItemCacheUpdatteMinutes.Location = new Point(6, 169);
        numItemCacheUpdatteMinutes.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        numItemCacheUpdatteMinutes.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
        numItemCacheUpdatteMinutes.Name = "numItemCacheUpdatteMinutes";
        numItemCacheUpdatteMinutes.Size = new Size(120, 23);
        numItemCacheUpdatteMinutes.TabIndex = 7;
        numItemCacheUpdatteMinutes.Value = new decimal(new int[] { 10, 0, 0, 0 });
        numItemCacheUpdatteMinutes.KeyDown += this.numItemCacheUpdatteMinutes_KeyDown;
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
        // lblHypixelUpdateInterval
        // 
        lblHypixelUpdateInterval.AutoSize = true;
        lblHypixelUpdateInterval.Location = new Point(6, 19);
        lblHypixelUpdateInterval.Name = "lblHypixelUpdateInterval";
        lblHypixelUpdateInterval.Size = new Size(179, 15);
        lblHypixelUpdateInterval.TabIndex = 0;
        lblHypixelUpdateInterval.Text = "Hypixel Update Interval Seconds:";
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
        grpStatus.ResumeLayout(false);
        grpStatus.PerformLayout();
        grpPlayers.ResumeLayout(false);
        tabMain.ResumeLayout(false);
        pgStatus.ResumeLayout(false);
        pgPlayers.ResumeLayout(false);
        pgAuctions.ResumeLayout(false);
        grpAuctions.ResumeLayout(false);
        pgSettings.ResumeLayout(false);
        pgSettings.PerformLayout();
        grpClientSettings.ResumeLayout(false);
        grpClientSettings.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numNotificationHistory).EndInit();
        grpServer.ResumeLayout(false);
        grpServer.PerformLayout();
        pgAdmin.ResumeLayout(false);
        pgAdmin.PerformLayout();
        grpUsers.ResumeLayout(false);
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
        ((System.ComponentModel.ISupportInitialize)numItemCacheUpdatteMinutes).EndInit();
        ((System.ComponentModel.ISupportInitialize)numAuctionCheckInterval).EndInit();
        ((System.ComponentModel.ISupportInitialize)numAuctionCacheRefresh).EndInit();
        ((System.ComponentModel.ISupportInitialize)munHypixelUpdateInterval).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox grpStatus;
    private Label lblUsername;
    private Label lblPlayerCount;
    private Label lblServer;
    private Label lblLastUpdate;
    private Button btnRefresh;
    private GroupBox grpPlayers;
    private ListView lvPlayers;
    private ColumnHeader Username;
    private ColumnHeader Status;
    private ColumnHeader lblLocation;
    private Button btnAddPlayer;
    private Button btnRemovePlayer;
    private TabControl tabMain;
    private TabPage pgStatus;
    private TabPage pgPlayers;
    private TabPage pgAuctions;
    private TabPage pgSettings;
    private TabPage pgAdmin;
    private GroupBox grpAuctions;
    private ListView lvAuctions;
    private ColumnHeader Item;
    private ColumnHeader Tier;
    private ColumnHeader Stars;
    private ColumnHeader Recomb;
    private ColumnHeader CheapestAuction;
    private ColumnHeader NotifyBelow;
    private Button btnAddAuction;
    private Button btnRemoveAuction;
    private ColumnHeader PetLevel;
    private GroupBox grpServer;
    private Label lblMaxPlayers;
    private Label lblMaxAuctions;
    private GroupBox grpClientSettings;
    private TextBox txtServerUrl;
    private NumericUpDown numNotificationHistory;
    private CheckBox chkAuctionNotifications;
    private CheckBox chkPlayerNotifications;
    private CheckBox chkStartupNotificationHistory;
    private Label lblLogtime;
    private Button btnSaveSettings;
    private Button btnReloadSettings;
    private CheckBox chkMinimizeToTray;
    private Label lblServerUrl;
    private TextBox txtAdminKey;
    private GroupBox grpServerSettings;
    private NumericUpDown numAuctionCheckInterval;
    private Label lblAuctionCheckInterval;
    private NumericUpDown numAuctionCacheRefresh;
    private Label lblAuctionCacheRefrsh;
    private NumericUpDown munHypixelUpdateInterval;
    private Label lblHypixelUpdateInterval;
    private GroupBox grpClientLimits;
    private NumericUpDown numMaxAuctionWatches;
    private Label lblMaxAuctionWatches;
    private Label lblMaxPlayerRequestsPerMinute;
    private NumericUpDown numMaxPlayerRequestsPerMinute;
    private GroupBox grpCleanup;
    private Label lblWatchCleanupInterval;
    private NumericUpDown numWatchCleanupInterval;
    private Label lblWatchExpiration;
    private NumericUpDown numWatchExpiration;
    private GroupBox grpUsers;
    private Button btnBlock;
    private ListView lvUsers;
    private ColumnHeader clmUsername;
    private ColumnHeader clmBlocked;
    private Button btnRefreshUsers;
    private Button btnUnblock;
    private Button btnShutdownServer;
    private NumericUpDown numPurgeInactive;
    private TextBox txtUpdateApiKey;
    private Button btnPurgeInactive;
    private Button btnDelete;
    private ColumnHeader clmLastRequest;
    private NumericUpDown numItemCacheUpdatteMinutes;
    private Label lblItemCacheUpdateMinutes;
    private ColumnHeader AuctionName;
}
