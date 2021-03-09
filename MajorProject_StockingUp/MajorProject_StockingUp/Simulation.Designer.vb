<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Simulation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Simulation))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortfolioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIMULATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksGraph = New LiveCharts.WinForms.CartesianChart()
        Me.GraphPanel = New System.Windows.Forms.Panel()
        Me.ListGridView = New System.Windows.Forms.DataGridView()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.ListPanel = New System.Windows.Forms.Panel()
        Me.DetailsPanel = New System.Windows.Forms.Panel()
        Me.InfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodeLabel = New System.Windows.Forms.Label()
        Me.SearchBox2 = New System.Windows.Forms.TextBox()
        Me.PurchasesGridView = New System.Windows.Forms.DataGridView()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.BUYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuyGroupBox = New System.Windows.Forms.GroupBox()
        Me.BuyAmendBalance = New System.Windows.Forms.Label()
        Me.BuyPriceLabel = New System.Windows.Forms.Label()
        Me.BuyButton = New System.Windows.Forms.Button()
        Me.BuyCount = New System.Windows.Forms.NumericUpDown()
        Me.SellGroupBox = New System.Windows.Forms.GroupBox()
        Me.SellAmendBalance = New System.Windows.Forms.Label()
        Me.SellCount = New System.Windows.Forms.NumericUpDown()
        Me.SellPriceLabel = New System.Windows.Forms.Label()
        Me.SellButton = New System.Windows.Forms.Button()
        Me.FormExit = New System.Windows.Forms.Button()
        Me.Resizer = New System.Windows.Forms.Timer(Me.components)
        Me.SetButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GraphPanel.SuspendLayout()
        CType(Me.ListGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListPanel.SuspendLayout()
        Me.DetailsPanel.SuspendLayout()
        CType(Me.InfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.BuyGroupBox.SuspendLayout()
        CType(Me.BuyCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SellGroupBox.SuspendLayout()
        CType(Me.SellCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem, Me.PortfolioToolStripMenuItem, Me.SIMULATIONToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(1920, 50)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1920, 50)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(116, 46)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'PortfolioToolStripMenuItem
        '
        Me.PortfolioToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.PortfolioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.PortfolioToolStripMenuItem.Name = "PortfolioToolStripMenuItem"
        Me.PortfolioToolStripMenuItem.Size = New System.Drawing.Size(241, 46)
        Me.PortfolioToolStripMenuItem.Text = "MY PORTFOLIO"
        '
        'SIMULATIONToolStripMenuItem
        '
        Me.SIMULATIONToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.SIMULATIONToolStripMenuItem.Name = "SIMULATIONToolStripMenuItem"
        Me.SIMULATIONToolStripMenuItem.Size = New System.Drawing.Size(208, 46)
        Me.SIMULATIONToolStripMenuItem.Text = "SIMULATION"
        '
        'StocksGraph
        '
        Me.StocksGraph.Location = New System.Drawing.Point(11, 18)
        Me.StocksGraph.Name = "StocksGraph"
        Me.StocksGraph.Size = New System.Drawing.Size(1030, 662)
        Me.StocksGraph.TabIndex = 0
        Me.StocksGraph.Text = "CartesianChart1"
        '
        'GraphPanel
        '
        Me.GraphPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GraphPanel.Controls.Add(Me.StocksGraph)
        Me.GraphPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphPanel.Location = New System.Drawing.Point(12, 66)
        Me.GraphPanel.Name = "GraphPanel"
        Me.GraphPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.GraphPanel.Size = New System.Drawing.Size(1068, 700)
        Me.GraphPanel.TabIndex = 14
        '
        'ListGridView
        '
        Me.ListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ListGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ListGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.ListGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.ListGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ListGridView.Location = New System.Drawing.Point(10, 63)
        Me.ListGridView.Name = "ListGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ListGridView.RowTemplate.Height = 33
        Me.ListGridView.Size = New System.Drawing.Size(1044, 220)
        Me.ListGridView.TabIndex = 2
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SearchBox.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SearchBox.Location = New System.Drawing.Point(13, 14)
        Me.SearchBox.Multiline = True
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(1041, 39)
        Me.SearchBox.TabIndex = 3
        Me.SearchBox.Text = "Please Search Stocks Here..."
        '
        'ListPanel
        '
        Me.ListPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ListPanel.Controls.Add(Me.ListGridView)
        Me.ListPanel.Controls.Add(Me.SearchBox)
        Me.ListPanel.Location = New System.Drawing.Point(8, 772)
        Me.ListPanel.Name = "ListPanel"
        Me.ListPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.ListPanel.Size = New System.Drawing.Size(1072, 296)
        Me.ListPanel.TabIndex = 15
        '
        'DetailsPanel
        '
        Me.DetailsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetailsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DetailsPanel.Controls.Add(Me.InfoDataGridView)
        Me.DetailsPanel.Controls.Add(Me.CodeLabel)
        Me.DetailsPanel.Controls.Add(Me.SearchBox2)
        Me.DetailsPanel.Controls.Add(Me.PurchasesGridView)
        Me.DetailsPanel.Controls.Add(Me.MenuStrip2)
        Me.DetailsPanel.Controls.Add(Me.BuyGroupBox)
        Me.DetailsPanel.Controls.Add(Me.SellGroupBox)
        Me.DetailsPanel.Location = New System.Drawing.Point(1090, 66)
        Me.DetailsPanel.Name = "DetailsPanel"
        Me.DetailsPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.DetailsPanel.Size = New System.Drawing.Size(818, 1002)
        Me.DetailsPanel.TabIndex = 18
        '
        'InfoDataGridView
        '
        Me.InfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.InfoDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.InfoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.InfoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InfoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.InfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InfoDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.InfoDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.InfoDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.InfoDataGridView.Location = New System.Drawing.Point(16, 127)
        Me.InfoDataGridView.Name = "InfoDataGridView"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InfoDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.InfoDataGridView.RowTemplate.Height = 33
        Me.InfoDataGridView.Size = New System.Drawing.Size(789, 325)
        Me.InfoDataGridView.TabIndex = 4
        '
        'CodeLabel
        '
        Me.CodeLabel.AutoSize = True
        Me.CodeLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.CodeLabel.Location = New System.Drawing.Point(333, 52)
        Me.CodeLabel.Name = "CodeLabel"
        Me.CodeLabel.Size = New System.Drawing.Size(180, 72)
        Me.CodeLabel.TabIndex = 0
        Me.CodeLabel.Text = "Name"
        Me.CodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchBox2
        '
        Me.SearchBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.SearchBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchBox2.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SearchBox2.Location = New System.Drawing.Point(16, 720)
        Me.SearchBox2.Multiline = True
        Me.SearchBox2.Name = "SearchBox2"
        Me.SearchBox2.Size = New System.Drawing.Size(789, 39)
        Me.SearchBox2.TabIndex = 3
        Me.SearchBox2.Text = "Search For Purchased Shares Here..."
        '
        'PurchasesGridView
        '
        Me.PurchasesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PurchasesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PurchasesGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PurchasesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PurchasesGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.PurchasesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PurchasesGridView.DefaultCellStyle = DataGridViewCellStyle9
        Me.PurchasesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.PurchasesGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PurchasesGridView.Location = New System.Drawing.Point(16, 769)
        Me.PurchasesGridView.Name = "PurchasesGridView"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PurchasesGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.PurchasesGridView.RowTemplate.Height = 33
        Me.PurchasesGridView.Size = New System.Drawing.Size(789, 220)
        Me.PurchasesGridView.TabIndex = 2
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BUYToolStripMenuItem, Me.SELLToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(3)
        Me.MenuStrip2.Size = New System.Drawing.Size(812, 60)
        Me.MenuStrip2.TabIndex = 16
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'BUYToolStripMenuItem
        '
        Me.BUYToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.BUYToolStripMenuItem.Checked = True
        Me.BUYToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BUYToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BUYToolStripMenuItem.Name = "BUYToolStripMenuItem"
        Me.BUYToolStripMenuItem.Size = New System.Drawing.Size(100, 54)
        Me.BUYToolStripMenuItem.Text = "BUY"
        '
        'SELLToolStripMenuItem
        '
        Me.SELLToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.SELLToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SELLToolStripMenuItem.Name = "SELLToolStripMenuItem"
        Me.SELLToolStripMenuItem.Size = New System.Drawing.Size(107, 54)
        Me.SELLToolStripMenuItem.Text = "SELL"
        '
        'BuyGroupBox
        '
        Me.BuyGroupBox.Controls.Add(Me.BuyAmendBalance)
        Me.BuyGroupBox.Controls.Add(Me.BuyPriceLabel)
        Me.BuyGroupBox.Controls.Add(Me.BuyButton)
        Me.BuyGroupBox.Controls.Add(Me.BuyCount)
        Me.BuyGroupBox.Font = New System.Drawing.Font("Segoe UI", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BuyGroupBox.Location = New System.Drawing.Point(16, 458)
        Me.BuyGroupBox.Name = "BuyGroupBox"
        Me.BuyGroupBox.Size = New System.Drawing.Size(789, 242)
        Me.BuyGroupBox.TabIndex = 7
        Me.BuyGroupBox.TabStop = False
        Me.BuyGroupBox.Text = "Buy Stocks"
        '
        'BuyAmendBalance
        '
        Me.BuyAmendBalance.AutoSize = True
        Me.BuyAmendBalance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyAmendBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BuyAmendBalance.Location = New System.Drawing.Point(6, 162)
        Me.BuyAmendBalance.Name = "BuyAmendBalance"
        Me.BuyAmendBalance.Size = New System.Drawing.Size(540, 32)
        Me.BuyAmendBalance.TabIndex = 23
        Me.BuyAmendBalance.Text = "You will have $$$$$$ remaining in your balance..."
        '
        'BuyPriceLabel
        '
        Me.BuyPriceLabel.AutoSize = True
        Me.BuyPriceLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyPriceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BuyPriceLabel.Location = New System.Drawing.Point(214, 77)
        Me.BuyPriceLabel.Name = "BuyPriceLabel"
        Me.BuyPriceLabel.Size = New System.Drawing.Size(454, 32)
        Me.BuyPriceLabel.TabIndex = 13
        Me.BuyPriceLabel.Text = "$00.00 will be deducted from your funds."
        '
        'BuyButton
        '
        Me.BuyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BuyButton.FlatAppearance.BorderSize = 0
        Me.BuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuyButton.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BuyButton.Location = New System.Drawing.Point(7, 67)
        Me.BuyButton.Name = "BuyButton"
        Me.BuyButton.Size = New System.Drawing.Size(100, 49)
        Me.BuyButton.TabIndex = 10
        Me.BuyButton.Text = "Buy"
        Me.BuyButton.UseVisualStyleBackColor = False
        '
        'BuyCount
        '
        Me.BuyCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BuyCount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BuyCount.Location = New System.Drawing.Point(113, 66)
        Me.BuyCount.Name = "BuyCount"
        Me.BuyCount.Size = New System.Drawing.Size(90, 50)
        Me.BuyCount.TabIndex = 6
        '
        'SellGroupBox
        '
        Me.SellGroupBox.Controls.Add(Me.SellAmendBalance)
        Me.SellGroupBox.Controls.Add(Me.SellCount)
        Me.SellGroupBox.Controls.Add(Me.SellPriceLabel)
        Me.SellGroupBox.Controls.Add(Me.SellButton)
        Me.SellGroupBox.Font = New System.Drawing.Font("Segoe UI", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SellGroupBox.Location = New System.Drawing.Point(16, 458)
        Me.SellGroupBox.Name = "SellGroupBox"
        Me.SellGroupBox.Size = New System.Drawing.Size(789, 242)
        Me.SellGroupBox.TabIndex = 25
        Me.SellGroupBox.TabStop = False
        Me.SellGroupBox.Text = "Sell Stocks"
        '
        'SellAmendBalance
        '
        Me.SellAmendBalance.AutoSize = True
        Me.SellAmendBalance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellAmendBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SellAmendBalance.Location = New System.Drawing.Point(6, 155)
        Me.SellAmendBalance.Name = "SellAmendBalance"
        Me.SellAmendBalance.Size = New System.Drawing.Size(574, 32)
        Me.SellAmendBalance.TabIndex = 52
        Me.SellAmendBalance.Text = "You will have ######## remaining in your balance..."
        '
        'SellCount
        '
        Me.SellCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.SellCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SellCount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SellCount.Location = New System.Drawing.Point(118, 65)
        Me.SellCount.Name = "SellCount"
        Me.SellCount.Size = New System.Drawing.Size(90, 46)
        Me.SellCount.TabIndex = 47
        '
        'SellPriceLabel
        '
        Me.SellPriceLabel.AutoSize = True
        Me.SellPriceLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellPriceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SellPriceLabel.Location = New System.Drawing.Point(214, 72)
        Me.SellPriceLabel.Name = "SellPriceLabel"
        Me.SellPriceLabel.Size = New System.Drawing.Size(501, 32)
        Me.SellPriceLabel.TabIndex = 49
        Me.SellPriceLabel.Text = "By selling 0 of 0 shares, you will profit $00.00."
        '
        'SellButton
        '
        Me.SellButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.SellButton.FlatAppearance.BorderSize = 0
        Me.SellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SellButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SellButton.Location = New System.Drawing.Point(7, 62)
        Me.SellButton.Name = "SellButton"
        Me.SellButton.Size = New System.Drawing.Size(105, 52)
        Me.SellButton.TabIndex = 48
        Me.SellButton.Text = "Sell"
        Me.SellButton.UseVisualStyleBackColor = False
        '
        'FormExit
        '
        Me.FormExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FormExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FormExit.Location = New System.Drawing.Point(1870, 0)
        Me.FormExit.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.FormExit.Name = "FormExit"
        Me.FormExit.Size = New System.Drawing.Size(50, 50)
        Me.FormExit.TabIndex = 19
        Me.FormExit.Text = "X"
        Me.FormExit.UseVisualStyleBackColor = True
        '
        'SetButton
        '
        Me.SetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.SetButton.Location = New System.Drawing.Point(1820, 0)
        Me.SetButton.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(50, 50)
        Me.SetButton.TabIndex = 20
        Me.SetButton.Text = "U+2699"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'Simulation
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.SetButton)
        Me.Controls.Add(Me.FormExit)
        Me.Controls.Add(Me.DetailsPanel)
        Me.Controls.Add(Me.GraphPanel)
        Me.Controls.Add(Me.ListPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Simulation"
        Me.Text = "Simulation"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GraphPanel.ResumeLayout(False)
        CType(Me.ListGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListPanel.ResumeLayout(False)
        Me.ListPanel.PerformLayout()
        Me.DetailsPanel.ResumeLayout(False)
        Me.DetailsPanel.PerformLayout()
        CType(Me.InfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.BuyGroupBox.ResumeLayout(False)
        Me.BuyGroupBox.PerformLayout()
        CType(Me.BuyCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SellGroupBox.ResumeLayout(False)
        Me.SellGroupBox.PerformLayout()
        CType(Me.SellCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PortfolioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StocksGraph As LiveCharts.WinForms.CartesianChart
    Friend WithEvents GraphPanel As Panel
    Friend WithEvents ListGridView As DataGridView
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents ListPanel As Panel
    Friend WithEvents DetailsPanel As Panel
    Friend WithEvents InfoDataGridView As DataGridView
    Friend WithEvents PurchasesGridView As DataGridView
    Friend WithEvents SearchBox2 As TextBox
    Friend WithEvents CodeLabel As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents BUYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SELLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SellGroupBox As GroupBox
    Friend WithEvents SellAmendBalance As Label
    Friend WithEvents SellButton As Button
    Friend WithEvents SellCount As NumericUpDown
    Friend WithEvents SellPriceLabel As Label
    Friend WithEvents FormExit As Button
    Friend WithEvents SIMULATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuyGroupBox As GroupBox
    Friend WithEvents BuyAmendBalance As Label
    Friend WithEvents BuyPriceLabel As Label
    Friend WithEvents BuyButton As Button
    Friend WithEvents BuyCount As NumericUpDown
    Friend WithEvents Resizer As Timer
    Friend WithEvents SetButton As Button
End Class
