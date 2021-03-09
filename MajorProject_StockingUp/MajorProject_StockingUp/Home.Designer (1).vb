<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RealtimeMarket
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
        Me.Resizer = New System.Windows.Forms.Timer(Me.components)
        Me.GraphPanel = New System.Windows.Forms.Panel()
        Me.StocksGraph = New LiveCharts.WinForms.CartesianChart()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.StockList1 = New System.Windows.Forms.DataGridView()
        Me.ListPanel = New System.Windows.Forms.Panel()
        Me.DetailsPanel = New System.Windows.Forms.Panel()
        Me.sectorlbl = New System.Windows.Forms.Label()
        Me.timelbl = New System.Windows.Forms.Label()
        Me.marklbl = New System.Windows.Forms.Label()
        Me.wllbl = New System.Windows.Forms.Label()
        Me.whlbl = New System.Windows.Forms.Label()
        Me.ciplbl = New System.Windows.Forms.Label()
        Me.yvalbl = New System.Windows.Forms.Label()
        Me.cvalbl = New System.Windows.Forms.Label()
        Me.namelbl = New System.Windows.Forms.Label()
        Me.sec = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.complbl = New System.Windows.Forms.Label()
        Me.codelbl = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REALTIMEMARKETPLACEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIMULATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoVIew = New System.Windows.Forms.TableLayoutPanel()
        Me.GraphPanel.SuspendLayout()
        CType(Me.StockList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListPanel.SuspendLayout()
        Me.DetailsPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.InfoVIew.SuspendLayout()
        Me.SuspendLayout()
        '
        'Resizer
        '
        Me.Resizer.Enabled = True
        '
        'GraphPanel
        '
        Me.GraphPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GraphPanel.Controls.Add(Me.StocksGraph)
        Me.GraphPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphPanel.Location = New System.Drawing.Point(13, 79)
        Me.GraphPanel.Name = "GraphPanel"
        Me.GraphPanel.Size = New System.Drawing.Size(1247, 754)
        Me.GraphPanel.TabIndex = 8
        '
        'StocksGraph
        '
        Me.StocksGraph.Location = New System.Drawing.Point(11, 18)
        Me.StocksGraph.Name = "StocksGraph"
        Me.StocksGraph.Size = New System.Drawing.Size(1206, 662)
        Me.StocksGraph.TabIndex = 0
        Me.StocksGraph.Text = "CartesianChart1"
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(1758, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(0, 0)
        Me.Panel3.TabIndex = 10
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.Location = New System.Drawing.Point(10, 3)
        Me.SearchBox.Multiline = True
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(1232, 39)
        Me.SearchBox.TabIndex = 3
        Me.SearchBox.Text = "Please Search Stocks Here..."
        '
        'StockList1
        '
        Me.StockList1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.StockList1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.StockList1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StockList1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.StockList1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StockList1.DefaultCellStyle = DataGridViewCellStyle2
        Me.StockList1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.StockList1.GridColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StockList1.Location = New System.Drawing.Point(10, 48)
        Me.StockList1.Name = "StockList1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StockList1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.StockList1.RowTemplate.Height = 33
        Me.StockList1.Size = New System.Drawing.Size(1206, 168)
        Me.StockList1.TabIndex = 2
        '
        'ListPanel
        '
        Me.ListPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ListPanel.Controls.Add(Me.StockList1)
        Me.ListPanel.Controls.Add(Me.SearchBox)
        Me.ListPanel.Location = New System.Drawing.Point(14, 839)
        Me.ListPanel.Name = "ListPanel"
        Me.ListPanel.Size = New System.Drawing.Size(1246, 229)
        Me.ListPanel.TabIndex = 9
        '
        'DetailsPanel
        '
        Me.DetailsPanel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DetailsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DetailsPanel.Controls.Add(Me.InfoVIew)
        Me.DetailsPanel.Controls.Add(Me.codelbl)
        Me.DetailsPanel.Location = New System.Drawing.Point(1266, 79)
        Me.DetailsPanel.Name = "DetailsPanel"
        Me.DetailsPanel.Size = New System.Drawing.Size(642, 989)
        Me.DetailsPanel.TabIndex = 11
        '
        'sectorlbl
        '
        Me.sectorlbl.AutoSize = True
        Me.sectorlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectorlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.sectorlbl.Location = New System.Drawing.Point(325, 37)
        Me.sectorlbl.Name = "sectorlbl"
        Me.sectorlbl.Size = New System.Drawing.Size(103, 37)
        Me.sectorlbl.TabIndex = 18
        Me.sectorlbl.Text = "Name"
        '
        'timelbl
        '
        Me.timelbl.AutoSize = True
        Me.timelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.timelbl.Location = New System.Drawing.Point(325, 296)
        Me.timelbl.Name = "timelbl"
        Me.timelbl.Size = New System.Drawing.Size(103, 37)
        Me.timelbl.TabIndex = 17
        Me.timelbl.Text = "Name"
        '
        'marklbl
        '
        Me.marklbl.AutoSize = True
        Me.marklbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marklbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.marklbl.Location = New System.Drawing.Point(325, 259)
        Me.marklbl.Name = "marklbl"
        Me.marklbl.Size = New System.Drawing.Size(103, 37)
        Me.marklbl.TabIndex = 16
        Me.marklbl.Text = "Name"
        '
        'wllbl
        '
        Me.wllbl.AutoSize = True
        Me.wllbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wllbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.wllbl.Location = New System.Drawing.Point(325, 222)
        Me.wllbl.Name = "wllbl"
        Me.wllbl.Size = New System.Drawing.Size(103, 37)
        Me.wllbl.TabIndex = 15
        Me.wllbl.Text = "Name"
        '
        'whlbl
        '
        Me.whlbl.AutoSize = True
        Me.whlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.whlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.whlbl.Location = New System.Drawing.Point(325, 185)
        Me.whlbl.Name = "whlbl"
        Me.whlbl.Size = New System.Drawing.Size(103, 37)
        Me.whlbl.TabIndex = 14
        Me.whlbl.Text = "Name"
        '
        'ciplbl
        '
        Me.ciplbl.AutoSize = True
        Me.ciplbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ciplbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ciplbl.Location = New System.Drawing.Point(325, 148)
        Me.ciplbl.Name = "ciplbl"
        Me.ciplbl.Size = New System.Drawing.Size(103, 37)
        Me.ciplbl.TabIndex = 13
        Me.ciplbl.Text = "Name"
        '
        'yvalbl
        '
        Me.yvalbl.AutoSize = True
        Me.yvalbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yvalbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.yvalbl.Location = New System.Drawing.Point(325, 111)
        Me.yvalbl.Name = "yvalbl"
        Me.yvalbl.Size = New System.Drawing.Size(103, 37)
        Me.yvalbl.TabIndex = 12
        Me.yvalbl.Text = "Name"
        '
        'cvalbl
        '
        Me.cvalbl.AutoSize = True
        Me.cvalbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cvalbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.cvalbl.Location = New System.Drawing.Point(325, 74)
        Me.cvalbl.Name = "cvalbl"
        Me.cvalbl.Size = New System.Drawing.Size(103, 37)
        Me.cvalbl.TabIndex = 11
        Me.cvalbl.Text = "Name"
        '
        'namelbl
        '
        Me.namelbl.AutoSize = True
        Me.namelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.namelbl.Location = New System.Drawing.Point(325, 0)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(103, 37)
        Me.namelbl.TabIndex = 10
        Me.namelbl.Text = "Name"
        '
        'sec
        '
        Me.sec.AutoSize = True
        Me.sec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.sec.Location = New System.Drawing.Point(3, 37)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(118, 37)
        Me.sec.TabIndex = 9
        Me.sec.Text = "Sector:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(3, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(288, 37)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Last Time Updated"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(316, 37)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Market Capitalisation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 37)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "52 Week Low:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 37)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "52 Week High:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 37)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Change in Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(283, 37)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Yesterday's Value:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Current Value:"
        '
        'complbl
        '
        Me.complbl.AutoSize = True
        Me.complbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.complbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.complbl.Location = New System.Drawing.Point(3, 0)
        Me.complbl.Name = "complbl"
        Me.complbl.Size = New System.Drawing.Size(163, 37)
        Me.complbl.TabIndex = 1
        Me.complbl.Text = "Company:"
        '
        'codelbl
        '
        Me.codelbl.AutoSize = True
        Me.codelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.codelbl.Location = New System.Drawing.Point(244, 52)
        Me.codelbl.Name = "codelbl"
        Me.codelbl.Size = New System.Drawing.Size(167, 61)
        Me.codelbl.TabIndex = 0
        Me.codelbl.Text = "Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem, Me.REALTIMEMARKETPLACEToolStripMenuItem, Me.SIMULATIONToolStripMenuItem, Me.SETTINGSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1920, 50)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(142, 46)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'REALTIMEMARKETPLACEToolStripMenuItem
        '
        Me.REALTIMEMARKETPLACEToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.REALTIMEMARKETPLACEToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.REALTIMEMARKETPLACEToolStripMenuItem.Name = "REALTIMEMARKETPLACEToolStripMenuItem"
        Me.REALTIMEMARKETPLACEToolStripMenuItem.Size = New System.Drawing.Size(505, 46)
        Me.REALTIMEMARKETPLACEToolStripMenuItem.Text = "REALTIME MARKETPLACE"
        '
        'SIMULATIONToolStripMenuItem
        '
        Me.SIMULATIONToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SIMULATIONToolStripMenuItem.Name = "SIMULATIONToolStripMenuItem"
        Me.SIMULATIONToolStripMenuItem.Size = New System.Drawing.Size(256, 46)
        Me.SIMULATIONToolStripMenuItem.Text = "SIMULATION"
        '
        'SETTINGSToolStripMenuItem
        '
        Me.SETTINGSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SETTINGSToolStripMenuItem.Name = "SETTINGSToolStripMenuItem"
        Me.SETTINGSToolStripMenuItem.Size = New System.Drawing.Size(216, 46)
        Me.SETTINGSToolStripMenuItem.Text = "SETTINGS"
        '
        'InfoVIew
        '
        Me.InfoVIew.AutoSize = True
        Me.InfoVIew.ColumnCount = 2
        Me.InfoVIew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoVIew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoVIew.Controls.Add(Me.timelbl, 1, 8)
        Me.InfoVIew.Controls.Add(Me.Label3, 0, 3)
        Me.InfoVIew.Controls.Add(Me.marklbl, 1, 7)
        Me.InfoVIew.Controls.Add(Me.complbl, 0, 0)
        Me.InfoVIew.Controls.Add(Me.wllbl, 1, 6)
        Me.InfoVIew.Controls.Add(Me.namelbl, 1, 0)
        Me.InfoVIew.Controls.Add(Me.sectorlbl, 1, 1)
        Me.InfoVIew.Controls.Add(Me.whlbl, 1, 5)
        Me.InfoVIew.Controls.Add(Me.sec, 0, 1)
        Me.InfoVIew.Controls.Add(Me.ciplbl, 1, 4)
        Me.InfoVIew.Controls.Add(Me.Label2, 0, 2)
        Me.InfoVIew.Controls.Add(Me.Label8, 0, 8)
        Me.InfoVIew.Controls.Add(Me.yvalbl, 1, 3)
        Me.InfoVIew.Controls.Add(Me.Label7, 0, 7)
        Me.InfoVIew.Controls.Add(Me.cvalbl, 1, 2)
        Me.InfoVIew.Controls.Add(Me.Label6, 0, 6)
        Me.InfoVIew.Controls.Add(Me.Label4, 0, 4)
        Me.InfoVIew.Controls.Add(Me.Label5, 0, 5)
        Me.InfoVIew.Location = New System.Drawing.Point(3, 116)
        Me.InfoVIew.Name = "InfoVIew"
        Me.InfoVIew.RowCount = 9
        Me.InfoVIew.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoVIew.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoVIew.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoVIew.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoVIew.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoVIew.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoVIew.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoVIew.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoVIew.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoVIew.Size = New System.Drawing.Size(636, 860)
        Me.InfoVIew.TabIndex = 19
        '
        'RealtimeMarket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.DetailsPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GraphPanel)
        Me.Controls.Add(Me.ListPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1920, 1080)
        Me.Name = "RealtimeMarket"
        Me.ShowIcon = False
        Me.Text = "Graph"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GraphPanel.ResumeLayout(False)
        CType(Me.StockList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListPanel.ResumeLayout(False)
        Me.ListPanel.PerformLayout()
        Me.DetailsPanel.ResumeLayout(False)
        Me.DetailsPanel.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.InfoVIew.ResumeLayout(False)
        Me.InfoVIew.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Resizer As Timer
    Friend WithEvents GraphPanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StocksGraph As LiveCharts.WinForms.CartesianChart
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents StockList1 As DataGridView
    Friend WithEvents ListPanel As Panel
    Friend WithEvents DetailsPanel As Panel
    Friend WithEvents codelbl As Label
    Friend WithEvents sectorlbl As Label
    Friend WithEvents timelbl As Label
    Friend WithEvents marklbl As Label
    Friend WithEvents wllbl As Label
    Friend WithEvents whlbl As Label
    Friend WithEvents ciplbl As Label
    Friend WithEvents yvalbl As Label
    Friend WithEvents cvalbl As Label
    Friend WithEvents namelbl As Label
    Friend WithEvents sec As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents complbl As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REALTIMEMARKETPLACEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SIMULATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SETTINGSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoVIew As TableLayoutPanel
End Class
