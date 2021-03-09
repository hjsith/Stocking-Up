<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyPortfolio
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyPortfolio))
        Me.Heading1 = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.TransactionGridView = New System.Windows.Forms.DataGridView()
        Me.InfoView = New System.Windows.Forms.TableLayoutPanel()
        Me.MLLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.complbl = New System.Windows.Forms.Label()
        Me.Profit = New System.Windows.Forms.Label()
        Me.Loss = New System.Windows.Forms.Label()
        Me.sec = New System.Windows.Forms.Label()
        Me.MMLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.STradeSess = New System.Windows.Forms.Label()
        Me.PTradeSess = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBLbl = New System.Windows.Forms.Label()
        Me.Heading3 = New System.Windows.Forms.Label()
        Me.Heading2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REALTIMEMARKETPLACEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIMULATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormExit = New System.Windows.Forms.Button()
        Me.SetButton = New System.Windows.Forms.Button()
        CType(Me.TransactionGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoView.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Heading1
        '
        Me.Heading1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Heading1.AutoSize = True
        Me.Heading1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Heading1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Heading1.Location = New System.Drawing.Point(5, 3)
        Me.Heading1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(415, 72)
        Me.Heading1.TabIndex = 20
        Me.Heading1.Text = "Transaction Log:"
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SearchBox.Location = New System.Drawing.Point(14, 131)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchBox.Multiline = True
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(1281, 46)
        Me.SearchBox.TabIndex = 3
        Me.SearchBox.Text = "Please Search Stocks Here..."
        '
        'TransactionGridView
        '
        Me.TransactionGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TransactionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TransactionGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TransactionGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TransactionGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TransactionGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TransactionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TransactionGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.TransactionGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.TransactionGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TransactionGridView.Location = New System.Drawing.Point(14, 179)
        Me.TransactionGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.TransactionGridView.Name = "TransactionGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TransactionGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TransactionGridView.RowTemplate.Height = 33
        Me.TransactionGridView.Size = New System.Drawing.Size(1281, 468)
        Me.TransactionGridView.TabIndex = 2
        '
        'InfoView
        '
        Me.InfoView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.InfoView.ColumnCount = 2
        Me.InfoView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.11744!))
        Me.InfoView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.88256!))
        Me.InfoView.Controls.Add(Me.MLLbl, 1, 5)
        Me.InfoView.Controls.Add(Me.Label3, 0, 3)
        Me.InfoView.Controls.Add(Me.complbl, 0, 0)
        Me.InfoView.Controls.Add(Me.Profit, 1, 0)
        Me.InfoView.Controls.Add(Me.Loss, 1, 1)
        Me.InfoView.Controls.Add(Me.sec, 0, 1)
        Me.InfoView.Controls.Add(Me.MMLbl, 1, 4)
        Me.InfoView.Controls.Add(Me.Label2, 0, 2)
        Me.InfoView.Controls.Add(Me.STradeSess, 1, 3)
        Me.InfoView.Controls.Add(Me.PTradeSess, 1, 2)
        Me.InfoView.Controls.Add(Me.Label4, 0, 4)
        Me.InfoView.Controls.Add(Me.Label5, 0, 6)
        Me.InfoView.Controls.Add(Me.Label1, 0, 5)
        Me.InfoView.Controls.Add(Me.CBLbl, 1, 6)
        Me.InfoView.Font = New System.Drawing.Font("Segoe UI", 4.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.InfoView.Location = New System.Drawing.Point(14, 80)
        Me.InfoView.Margin = New System.Windows.Forms.Padding(2)
        Me.InfoView.Name = "InfoView"
        Me.InfoView.Padding = New System.Windows.Forms.Padding(3)
        Me.InfoView.RowCount = 10
        Me.InfoView.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoView.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoView.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoView.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoView.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoView.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoView.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoView.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoView.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.InfoView.Size = New System.Drawing.Size(568, 277)
        Me.InfoView.TabIndex = 19
        '
        'MLLbl
        '
        Me.MLLbl.AutoSize = True
        Me.MLLbl.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MLLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MLLbl.Location = New System.Drawing.Point(326, 188)
        Me.MLLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MLLbl.Name = "MLLbl"
        Me.MLLbl.Size = New System.Drawing.Size(98, 37)
        Me.MLLbl.TabIndex = 20
        Me.MLLbl.Text = "$00.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(311, 37)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Shortest Trading Session:"
        '
        'complbl
        '
        Me.complbl.AutoSize = True
        Me.complbl.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.complbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.complbl.Location = New System.Drawing.Point(5, 3)
        Me.complbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.complbl.Name = "complbl"
        Me.complbl.Size = New System.Drawing.Size(182, 37)
        Me.complbl.TabIndex = 1
        Me.complbl.Text = "Biggest Profit:"
        '
        'Profit
        '
        Me.Profit.AutoSize = True
        Me.Profit.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Profit.Location = New System.Drawing.Point(326, 3)
        Me.Profit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Profit.Name = "Profit"
        Me.Profit.Size = New System.Drawing.Size(98, 37)
        Me.Profit.TabIndex = 10
        Me.Profit.Text = "$00.00"
        '
        'Loss
        '
        Me.Loss.AutoSize = True
        Me.Loss.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Loss.Location = New System.Drawing.Point(326, 40)
        Me.Loss.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Loss.Name = "Loss"
        Me.Loss.Size = New System.Drawing.Size(98, 37)
        Me.Loss.TabIndex = 18
        Me.Loss.Text = "$00.00"
        '
        'sec
        '
        Me.sec.AutoSize = True
        Me.sec.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.sec.Location = New System.Drawing.Point(5, 40)
        Me.sec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(169, 37)
        Me.sec.TabIndex = 9
        Me.sec.Text = "Biggest Loss:"
        '
        'MMLbl
        '
        Me.MMLbl.AutoSize = True
        Me.MMLbl.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MMLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MMLbl.Location = New System.Drawing.Point(326, 151)
        Me.MMLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MMLbl.Name = "MMLbl"
        Me.MMLbl.Size = New System.Drawing.Size(98, 37)
        Me.MMLbl.TabIndex = 13
        Me.MMLbl.Text = "$00.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Longest Trading Session:"
        '
        'STradeSess
        '
        Me.STradeSess.AutoSize = True
        Me.STradeSess.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STradeSess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.STradeSess.Location = New System.Drawing.Point(326, 114)
        Me.STradeSess.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.STradeSess.Name = "STradeSess"
        Me.STradeSess.Size = New System.Drawing.Size(225, 37)
        Me.STradeSess.TabIndex = 12
        Me.STradeSess.Text = "HH:MM:SS:MSMS"
        '
        'PTradeSess
        '
        Me.PTradeSess.AutoSize = True
        Me.PTradeSess.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PTradeSess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.PTradeSess.Location = New System.Drawing.Point(326, 77)
        Me.PTradeSess.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PTradeSess.Name = "PTradeSess"
        Me.PTradeSess.Size = New System.Drawing.Size(225, 37)
        Me.PTradeSess.TabIndex = 11
        Me.PTradeSess.Text = "HH:MM:SS:MSMS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 37)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Money Made:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(5, 225)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 37)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Current Balance:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 188)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 37)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Total Money Lost:"
        '
        'CBLbl
        '
        Me.CBLbl.AutoSize = True
        Me.CBLbl.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.CBLbl.Location = New System.Drawing.Point(326, 225)
        Me.CBLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CBLbl.Name = "CBLbl"
        Me.CBLbl.Size = New System.Drawing.Size(98, 37)
        Me.CBLbl.TabIndex = 14
        Me.CBLbl.Text = "$00.00"
        '
        'Heading3
        '
        Me.Heading3.AutoSize = True
        Me.Heading3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Heading3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Heading3.Location = New System.Drawing.Point(3, 3)
        Me.Heading3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Heading3.Name = "Heading3"
        Me.Heading3.Size = New System.Drawing.Size(235, 72)
        Me.Heading3.TabIndex = 0
        Me.Heading3.Text = "Statistics"
        '
        'Heading2
        '
        Me.Heading2.AutoSize = True
        Me.Heading2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Heading2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Heading2.Location = New System.Drawing.Point(5, 3)
        Me.Heading2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Heading2.Name = "Heading2"
        Me.Heading2.Size = New System.Drawing.Size(596, 72)
        Me.Heading2.TabIndex = 21
        Me.Heading2.Text = "Progress to $1 MILLION"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(209, 169)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(892, 27)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Heading3)
        Me.Panel3.Controls.Add(Me.InfoView)
        Me.Panel3.Location = New System.Drawing.Point(1325, 63)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel3.Size = New System.Drawing.Size(586, 1007)
        Me.Panel3.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Heading1)
        Me.Panel1.Controls.Add(Me.TransactionGridView)
        Me.Panel1.Controls.Add(Me.SearchBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 63)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(1310, 660)
        Me.Panel1.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Controls.Add(Me.Heading2)
        Me.Panel2.Location = New System.Drawing.Point(12, 727)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel2.Size = New System.Drawing.Size(1310, 343)
        Me.Panel2.TabIndex = 24
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem, Me.REALTIMEMARKETPLACEToolStripMenuItem, Me.SIMULATIONToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(1920, 50)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1920, 50)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(116, 46)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'REALTIMEMARKETPLACEToolStripMenuItem
        '
        Me.REALTIMEMARKETPLACEToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.REALTIMEMARKETPLACEToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.REALTIMEMARKETPLACEToolStripMenuItem.Name = "REALTIMEMARKETPLACEToolStripMenuItem"
        Me.REALTIMEMARKETPLACEToolStripMenuItem.Size = New System.Drawing.Size(241, 46)
        Me.REALTIMEMARKETPLACEToolStripMenuItem.Text = "MY PORTFOLIO"
        '
        'SIMULATIONToolStripMenuItem
        '
        Me.SIMULATIONToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.SIMULATIONToolStripMenuItem.Name = "SIMULATIONToolStripMenuItem"
        Me.SIMULATIONToolStripMenuItem.Size = New System.Drawing.Size(208, 46)
        Me.SIMULATIONToolStripMenuItem.Text = "SIMULATION"
        '
        'FormExit
        '
        Me.FormExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FormExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FormExit.Location = New System.Drawing.Point(1867, 0)
        Me.FormExit.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.FormExit.Name = "FormExit"
        Me.FormExit.Size = New System.Drawing.Size(53, 50)
        Me.FormExit.TabIndex = 27
        Me.FormExit.Text = "X"
        Me.FormExit.UseVisualStyleBackColor = True
        '
        'SetButton
        '
        Me.SetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.SetButton.Location = New System.Drawing.Point(1817, 0)
        Me.SetButton.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(50, 50)
        Me.SetButton.TabIndex = 28
        Me.SetButton.Text = "U+2699"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'MyPortfolio
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.ControlBox = False
        Me.Controls.Add(Me.SetButton)
        Me.Controls.Add(Me.FormExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MyPortfolio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graph"
        CType(Me.TransactionGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfoView.ResumeLayout(False)
        Me.InfoView.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents TransactionGridView As DataGridView
    Friend WithEvents Heading3 As Label
    Friend WithEvents Loss As Label
    Friend WithEvents CBLbl As Label
    Friend WithEvents MMLbl As Label
    Friend WithEvents STradeSess As Label
    Friend WithEvents PTradeSess As Label
    Friend WithEvents Profit As Label
    Friend WithEvents sec As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents complbl As Label
    Friend WithEvents InfoView As TableLayoutPanel
    Friend WithEvents MLLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Heading1 As Label
    Friend WithEvents Heading2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REALTIMEMARKETPLACEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SIMULATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormExit As Button
    Friend WithEvents SetButton As Button
End Class
