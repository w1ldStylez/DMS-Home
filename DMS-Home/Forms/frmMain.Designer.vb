<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DokumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HinzufügenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÄndernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EntfernenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.KonfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StammdatenverzeichnisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogDateipfadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜberToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ÜberToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageSearch = New System.Windows.Forms.TabPage()
        Me.SplitContainerSearch = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnFilter = New System.Windows.Forms.ToolStripButton()
        Me.cboCategories = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvDocuments = New System.Windows.Forms.DataGridView()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKategorieID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnExtension = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnGröße = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTitel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnBemerkung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTags = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPageAblage = New System.Windows.Forms.TabPage()
        Me.SplitContainerAblage = New System.Windows.Forms.SplitContainer()
        Me.tvDocuments = New System.Windows.Forms.TreeView()
        Me.ContextMenuAblage = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AblegenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.StautsBarLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAktualisieren = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAnzeigen = New System.Windows.Forms.ToolStripButton()
        Me.btnAendern = New System.Windows.Forms.ToolStripButton()
        Me.btnExport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAblegen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.brnEntfernen = New System.Windows.Forms.ToolStripButton()
        Me.MainMenu.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPageSearch.SuspendLayout()
        Me.SplitContainerSearch.Panel1.SuspendLayout()
        Me.SplitContainerSearch.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgvDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAblage.SuspendLayout()
        Me.SplitContainerAblage.Panel1.SuspendLayout()
        Me.SplitContainerAblage.SuspendLayout()
        Me.ContextMenuAblage.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.OptionenToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(1152, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DokumentToolStripMenuItem, Me.KategorieToolStripMenuItem, Me.ToolStripMenuItem3, Me.KonfigurationToolStripMenuItem})
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OptionenToolStripMenuItem.Text = "Optionen"
        '
        'DokumentToolStripMenuItem
        '
        Me.DokumentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HinzufügenToolStripMenuItem})
        Me.DokumentToolStripMenuItem.Name = "DokumentToolStripMenuItem"
        Me.DokumentToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.DokumentToolStripMenuItem.Text = "Dokument"
        '
        'HinzufügenToolStripMenuItem
        '
        Me.HinzufügenToolStripMenuItem.Name = "HinzufügenToolStripMenuItem"
        Me.HinzufügenToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.HinzufügenToolStripMenuItem.Text = "Hinzufügen"
        '
        'KategorieToolStripMenuItem
        '
        Me.KategorieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HinzufügenToolStripMenuItem1, Me.ÄndernToolStripMenuItem, Me.ToolStripMenuItem2, Me.EntfernenToolStripMenuItem})
        Me.KategorieToolStripMenuItem.Name = "KategorieToolStripMenuItem"
        Me.KategorieToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.KategorieToolStripMenuItem.Text = "Kategorie"
        '
        'HinzufügenToolStripMenuItem1
        '
        Me.HinzufügenToolStripMenuItem1.Name = "HinzufügenToolStripMenuItem1"
        Me.HinzufügenToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.HinzufügenToolStripMenuItem1.Text = "Hinzufügen"
        '
        'ÄndernToolStripMenuItem
        '
        Me.ÄndernToolStripMenuItem.Name = "ÄndernToolStripMenuItem"
        Me.ÄndernToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ÄndernToolStripMenuItem.Text = "Ändern"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(133, 6)
        '
        'EntfernenToolStripMenuItem
        '
        Me.EntfernenToolStripMenuItem.Name = "EntfernenToolStripMenuItem"
        Me.EntfernenToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.EntfernenToolStripMenuItem.Text = "Entfernen"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(144, 6)
        '
        'KonfigurationToolStripMenuItem
        '
        Me.KonfigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StammdatenverzeichnisToolStripMenuItem, Me.LogDateipfadToolStripMenuItem})
        Me.KonfigurationToolStripMenuItem.Name = "KonfigurationToolStripMenuItem"
        Me.KonfigurationToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.KonfigurationToolStripMenuItem.Text = "Konfiguration"
        '
        'StammdatenverzeichnisToolStripMenuItem
        '
        Me.StammdatenverzeichnisToolStripMenuItem.Name = "StammdatenverzeichnisToolStripMenuItem"
        Me.StammdatenverzeichnisToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.StammdatenverzeichnisToolStripMenuItem.Text = "Stammdatenverzeichnis"
        '
        'LogDateipfadToolStripMenuItem
        '
        Me.LogDateipfadToolStripMenuItem.Name = "LogDateipfadToolStripMenuItem"
        Me.LogDateipfadToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.LogDateipfadToolStripMenuItem.Text = "Log-Dateipfad"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HilfeToolStripMenuItem, Me.ÜberToolStripMenuItem, Me.ÜberToolStripMenuItem1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'ÜberToolStripMenuItem
        '
        Me.ÜberToolStripMenuItem.Name = "ÜberToolStripMenuItem"
        Me.ÜberToolStripMenuItem.Size = New System.Drawing.Size(96, 6)
        '
        'ÜberToolStripMenuItem1
        '
        Me.ÜberToolStripMenuItem1.Name = "ÜberToolStripMenuItem1"
        Me.ÜberToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.ÜberToolStripMenuItem1.Text = "Über"
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.TabPageSearch)
        Me.TabControl.Controls.Add(Me.TabPageAblage)
        Me.TabControl.Location = New System.Drawing.Point(12, 59)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1128, 448)
        Me.TabControl.TabIndex = 1
        '
        'TabPageSearch
        '
        Me.TabPageSearch.Controls.Add(Me.SplitContainerSearch)
        Me.TabPageSearch.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSearch.Name = "TabPageSearch"
        Me.TabPageSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSearch.Size = New System.Drawing.Size(1120, 422)
        Me.TabPageSearch.TabIndex = 0
        Me.TabPageSearch.Text = "Suche"
        '
        'SplitContainerSearch
        '
        Me.SplitContainerSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainerSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerSearch.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainerSearch.Name = "SplitContainerSearch"
        '
        'SplitContainerSearch.Panel1
        '
        Me.SplitContainerSearch.Panel1.Controls.Add(Me.ToolStrip2)
        Me.SplitContainerSearch.Panel1.Controls.Add(Me.cboCategories)
        Me.SplitContainerSearch.Panel1.Controls.Add(Me.txtSearch)
        Me.SplitContainerSearch.Panel1.Controls.Add(Me.dgvDocuments)
        Me.SplitContainerSearch.Size = New System.Drawing.Size(1114, 416)
        Me.SplitContainerSearch.SplitterDistance = 650
        Me.SplitContainerSearch.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFilter})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(26, 25)
        Me.ToolStrip2.TabIndex = 4
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnFilter
        '
        Me.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFilter.Image = CType(resources.GetObject("btnFilter.Image"), System.Drawing.Image)
        Me.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(23, 22)
        Me.btnFilter.Text = "Filter"
        '
        'cboCategories
        '
        Me.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboCategories.FormattingEnabled = True
        Me.cboCategories.Items.AddRange(New Object() {"-Alle-"})
        Me.cboCategories.Location = New System.Drawing.Point(183, 5)
        Me.cboCategories.Name = "cboCategories"
        Me.cboCategories.Size = New System.Drawing.Size(148, 21)
        Me.cboCategories.Sorted = True
        Me.cboCategories.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(29, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(148, 20)
        Me.txtSearch.TabIndex = 3
        '
        'dgvDocuments
        '
        Me.dgvDocuments.AllowUserToAddRows = False
        Me.dgvDocuments.AllowUserToDeleteRows = False
        Me.dgvDocuments.AllowUserToOrderColumns = True
        Me.dgvDocuments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDocuments.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvDocuments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocuments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnPath, Me.ColumnKategorieID, Me.ColumnExtension, Me.ColumnGröße, Me.ColumnTitel, Me.ColumnBemerkung, Me.ColumnTags, Me.ColumnDate})
        Me.dgvDocuments.Location = New System.Drawing.Point(-2, 31)
        Me.dgvDocuments.Name = "dgvDocuments"
        Me.dgvDocuments.ReadOnly = True
        Me.dgvDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDocuments.Size = New System.Drawing.Size(645, 383)
        Me.dgvDocuments.TabIndex = 1
        '
        'ColumnID
        '
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        Me.ColumnID.Visible = False
        '
        'ColumnPath
        '
        Me.ColumnPath.HeaderText = "Path"
        Me.ColumnPath.Name = "ColumnPath"
        Me.ColumnPath.ReadOnly = True
        Me.ColumnPath.Visible = False
        '
        'ColumnKategorieID
        '
        Me.ColumnKategorieID.HeaderText = "KategorieID"
        Me.ColumnKategorieID.Name = "ColumnKategorieID"
        Me.ColumnKategorieID.ReadOnly = True
        Me.ColumnKategorieID.Visible = False
        '
        'ColumnExtension
        '
        Me.ColumnExtension.HeaderText = "Extension"
        Me.ColumnExtension.Name = "ColumnExtension"
        Me.ColumnExtension.ReadOnly = True
        '
        'ColumnGröße
        '
        Me.ColumnGröße.HeaderText = "Größe"
        Me.ColumnGröße.Name = "ColumnGröße"
        Me.ColumnGröße.ReadOnly = True
        '
        'ColumnTitel
        '
        Me.ColumnTitel.HeaderText = "Titel"
        Me.ColumnTitel.Name = "ColumnTitel"
        Me.ColumnTitel.ReadOnly = True
        '
        'ColumnBemerkung
        '
        Me.ColumnBemerkung.HeaderText = "Bemerkung"
        Me.ColumnBemerkung.Name = "ColumnBemerkung"
        Me.ColumnBemerkung.ReadOnly = True
        '
        'ColumnTags
        '
        Me.ColumnTags.HeaderText = "Tags"
        Me.ColumnTags.Name = "ColumnTags"
        Me.ColumnTags.ReadOnly = True
        '
        'ColumnDate
        '
        Me.ColumnDate.HeaderText = "Datum"
        Me.ColumnDate.Name = "ColumnDate"
        Me.ColumnDate.ReadOnly = True
        '
        'TabPageAblage
        '
        Me.TabPageAblage.Controls.Add(Me.SplitContainerAblage)
        Me.TabPageAblage.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAblage.Name = "TabPageAblage"
        Me.TabPageAblage.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAblage.Size = New System.Drawing.Size(1120, 422)
        Me.TabPageAblage.TabIndex = 1
        Me.TabPageAblage.Text = "Ablage"
        '
        'SplitContainerAblage
        '
        Me.SplitContainerAblage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainerAblage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerAblage.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainerAblage.Name = "SplitContainerAblage"
        '
        'SplitContainerAblage.Panel1
        '
        Me.SplitContainerAblage.Panel1.Controls.Add(Me.tvDocuments)
        Me.SplitContainerAblage.Size = New System.Drawing.Size(1114, 416)
        Me.SplitContainerAblage.SplitterDistance = 639
        Me.SplitContainerAblage.TabIndex = 0
        '
        'tvDocuments
        '
        Me.tvDocuments.BackColor = System.Drawing.SystemColors.Control
        Me.tvDocuments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvDocuments.ContextMenuStrip = Me.ContextMenuAblage
        Me.tvDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvDocuments.Location = New System.Drawing.Point(0, 0)
        Me.tvDocuments.Name = "tvDocuments"
        Me.tvDocuments.Size = New System.Drawing.Size(635, 412)
        Me.tvDocuments.TabIndex = 0
        '
        'ContextMenuAblage
        '
        Me.ContextMenuAblage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AblegenToolStripMenuItem})
        Me.ContextMenuAblage.Name = "ContextMenuAblage"
        Me.ContextMenuAblage.Size = New System.Drawing.Size(119, 26)
        '
        'AblegenToolStripMenuItem
        '
        Me.AblegenToolStripMenuItem.Name = "AblegenToolStripMenuItem"
        Me.AblegenToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AblegenToolStripMenuItem.Text = "Ablegen"
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StautsBarLabel1})
        Me.StatusBar.Location = New System.Drawing.Point(0, 510)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(1152, 22)
        Me.StatusBar.TabIndex = 2
        Me.StatusBar.Text = "StatusStrip1"
        '
        'StautsBarLabel1
        '
        Me.StautsBarLabel1.Name = "StautsBarLabel1"
        Me.StautsBarLabel1.Size = New System.Drawing.Size(37, 17)
        Me.StautsBarLabel1.Text = "Bereit"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAktualisieren, Me.ToolStripSeparator3, Me.btnAnzeigen, Me.btnAendern, Me.btnExport, Me.ToolStripSeparator1, Me.btnAblegen, Me.ToolStripSeparator2, Me.brnEntfernen})
        Me.ToolStrip1.Location = New System.Drawing.Point(12, 31)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(493, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAktualisieren
        '
        Me.btnAktualisieren.Image = CType(resources.GetObject("btnAktualisieren.Image"), System.Drawing.Image)
        Me.btnAktualisieren.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAktualisieren.Name = "btnAktualisieren"
        Me.btnAktualisieren.Size = New System.Drawing.Size(95, 22)
        Me.btnAktualisieren.Text = "Aktualisieren"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnAnzeigen
        '
        Me.btnAnzeigen.Image = CType(resources.GetObject("btnAnzeigen.Image"), System.Drawing.Image)
        Me.btnAnzeigen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnzeigen.Name = "btnAnzeigen"
        Me.btnAnzeigen.Size = New System.Drawing.Size(76, 22)
        Me.btnAnzeigen.Text = "Anzeigen"
        '
        'btnAendern
        '
        Me.btnAendern.Image = CType(resources.GetObject("btnAendern.Image"), System.Drawing.Image)
        Me.btnAendern.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAendern.Name = "btnAendern"
        Me.btnAendern.Size = New System.Drawing.Size(66, 22)
        Me.btnAendern.Text = "Ändern"
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(86, 22)
        Me.btnExport.Text = "Exportieren"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnAblegen
        '
        Me.btnAblegen.Enabled = False
        Me.btnAblegen.Image = CType(resources.GetObject("btnAblegen.Image"), System.Drawing.Image)
        Me.btnAblegen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAblegen.Name = "btnAblegen"
        Me.btnAblegen.Size = New System.Drawing.Size(71, 22)
        Me.btnAblegen.Text = "Ablegen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'brnEntfernen
        '
        Me.brnEntfernen.Image = CType(resources.GetObject("brnEntfernen.Image"), System.Drawing.Image)
        Me.brnEntfernen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.brnEntfernen.Name = "brnEntfernen"
        Me.brnEntfernen.Size = New System.Drawing.Size(78, 22)
        Me.brnEntfernen.Text = "Entfernen"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 532)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MainMenu)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPageSearch.ResumeLayout(False)
        Me.SplitContainerSearch.Panel1.ResumeLayout(False)
        Me.SplitContainerSearch.Panel1.PerformLayout()
        Me.SplitContainerSearch.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgvDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAblage.ResumeLayout(False)
        Me.SplitContainerAblage.Panel1.ResumeLayout(False)
        Me.SplitContainerAblage.ResumeLayout(False)
        Me.ContextMenuAblage.ResumeLayout(False)
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPageSearch As System.Windows.Forms.TabPage
    Friend WithEvents TabPageAblage As System.Windows.Forms.TabPage
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents StautsBarLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainerSearch As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainerAblage As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvDocuments As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents tvDocuments As System.Windows.Forms.TreeView
    Friend WithEvents cboCategories As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnKategorieID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnExtension As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnGröße As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTitel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnBemerkung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTags As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuAblage As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AblegenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAnzeigen As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAendern As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAblegen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents brnEntfernen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFilter As System.Windows.Forms.ToolStripButton
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DokumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KategorieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HinzufügenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÄndernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EntfernenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KonfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StammdatenverzeichnisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogDateipfadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÜberToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ÜberToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAktualisieren As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExport As System.Windows.Forms.ToolStripButton

End Class
