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
        NotifyBelow = new ColumnHeader();
        pgSettings = new TabPage();
        pgAdmin = new TabPage();
        grpStatus.SuspendLayout();
        grpPlayers.SuspendLayout();
        tabMain.SuspendLayout();
        pgStatus.SuspendLayout();
        pgPlayers.SuspendLayout();
        pgAuctions.SuspendLayout();
        grpAuctions.SuspendLayout();
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
        grpStatus.Size = new Size(786, 416);
        grpStatus.TabIndex = 0;
        grpStatus.TabStop = false;
        grpStatus.Text = "Status";
        // 
        // btnRefresh
        // 
        btnRefresh.Location = new Point(309, 148);
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
        grpPlayers.Size = new Size(786, 416);
        grpPlayers.TabIndex = 1;
        grpPlayers.TabStop = false;
        grpPlayers.Text = "Watched Players";
        // 
        // btnRemovePlayer
        // 
        btnRemovePlayer.Location = new Point(105, 156);
        btnRemovePlayer.Name = "btnRemovePlayer";
        btnRemovePlayer.Size = new Size(75, 23);
        btnRemovePlayer.TabIndex = 2;
        btnRemovePlayer.Text = "Remove Player";
        btnRemovePlayer.UseVisualStyleBackColor = true;
        btnRemovePlayer.Click += btnRemovePlayer_Click;
        // 
        // btnAddPlayer
        // 
        btnAddPlayer.Location = new Point(24, 156);
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
        lvPlayers.Size = new Size(372, 128);
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
        tabMain.Size = new Size(800, 450);
        tabMain.TabIndex = 2;
        // 
        // pgStatus
        // 
        pgStatus.Controls.Add(grpStatus);
        pgStatus.Location = new Point(4, 24);
        pgStatus.Name = "pgStatus";
        pgStatus.Padding = new Padding(3);
        pgStatus.Size = new Size(792, 422);
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
        pgPlayers.Size = new Size(792, 422);
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
        pgAuctions.Size = new Size(792, 422);
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
        grpAuctions.Size = new Size(786, 416);
        grpAuctions.TabIndex = 0;
        grpAuctions.TabStop = false;
        grpAuctions.Text = "Auction Watches";
        // 
        // btnRemoveAuction
        // 
        btnRemoveAuction.Location = new Point(150, 172);
        btnRemoveAuction.Name = "btnRemoveAuction";
        btnRemoveAuction.Size = new Size(75, 23);
        btnRemoveAuction.TabIndex = 2;
        btnRemoveAuction.Text = "Remove Auction";
        btnRemoveAuction.UseVisualStyleBackColor = true;
        btnRemoveAuction.Click += btnRemoveAuction_Click;
        // 
        // btnAddAuction
        // 
        btnAddAuction.Location = new Point(6, 172);
        btnAddAuction.Name = "btnAddAuction";
        btnAddAuction.Size = new Size(75, 23);
        btnAddAuction.TabIndex = 1;
        btnAddAuction.Text = "Add Auction";
        btnAddAuction.UseVisualStyleBackColor = true;
        btnAddAuction.Click += btnAddAuction_Click;
        // 
        // lvAuctions
        // 
        lvAuctions.Columns.AddRange(new ColumnHeader[] { Item, Tier, PetLevel, Stars, Recomb, CheapestAuction, NotifyBelow });
        lvAuctions.FullRowSelect = true;
        lvAuctions.GridLines = true;
        lvAuctions.Location = new Point(3, 17);
        lvAuctions.MultiSelect = false;
        lvAuctions.Name = "lvAuctions";
        lvAuctions.Size = new Size(694, 149);
        lvAuctions.TabIndex = 0;
        lvAuctions.UseCompatibleStateImageBehavior = false;
        lvAuctions.View = View.Details;
        lvAuctions.DoubleClick += lvAuctions_DoubleClick;
        // 
        // Item
        // 
        Item.Text = "Item";
        Item.Width = 180;
        // 
        // Tier
        // 
        Tier.Text = "Tier";
        Tier.Width = 90;
        // 
        // PetLevel
        // 
        PetLevel.Text = "Pet Level";
        // 
        // Stars
        // 
        Stars.Text = "Stars";
        // 
        // Recomb
        // 
        Recomb.Text = "Recomb";
        Recomb.Width = 80;
        // 
        // CheapestAuction
        // 
        CheapestAuction.Text = "Cheapest Auction";
        CheapestAuction.Width = 110;
        // 
        // NotifyBelow
        // 
        NotifyBelow.Text = "Notift Below";
        NotifyBelow.Width = 110;
        // 
        // pgSettings
        // 
        pgSettings.Location = new Point(4, 24);
        pgSettings.Name = "pgSettings";
        pgSettings.Padding = new Padding(3);
        pgSettings.Size = new Size(792, 422);
        pgSettings.TabIndex = 3;
        pgSettings.Text = "Settings";
        pgSettings.UseVisualStyleBackColor = true;
        // 
        // pgAdmin
        // 
        pgAdmin.Location = new Point(4, 24);
        pgAdmin.Name = "pgAdmin";
        pgAdmin.Padding = new Padding(3);
        pgAdmin.Size = new Size(792, 422);
        pgAdmin.TabIndex = 4;
        pgAdmin.Text = "Admin";
        pgAdmin.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
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
}
