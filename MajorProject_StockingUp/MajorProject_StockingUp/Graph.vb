Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Sheets.v4
Imports Google.Apis.Sheets.v4.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports System.IO
Imports System.Threading
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.ComponentModel
Imports System.Windows.Forms.DataVisualization.Charting
Imports MaterialSkin

Public Class Graph
    Public stockentry1, stockentry2, stockentry3, stockentry4, stockentry5 As New Series
    Public Link As New SheetsQuickstart.Program
    Public InfoSet As New DataSet("All Stock Data")
    Public AllInfo As New DataTable("Data")
    Public tooltipprovider As New ToolTip


    Private Sub Graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        i = 0
        b = 0

        Resizer.Start()
        Call Link.Main()

        'Create Dataset
        InfoSet = CreateDataset()
        'Set DataGridView1 
        StockList1.DataSource = InfoSet.Tables("Data")
        AddDataToDataSetDynamically(InfoSet)


    End Sub

    Public Function CreateDataset() As DataSet

        AllInfo.Columns.Add(New DataColumn("Selection", GetType(Boolean)))
        AllInfo.Columns.Add("Code") : AllInfo.Columns("Code").ReadOnly = True
        AllInfo.Columns.Add("CompanyName") : AllInfo.Columns("CompanyName").ReadOnly = True
        AllInfo.Columns.Add("Sector") : AllInfo.Columns("Sector").ReadOnly = True
        AllInfo.Columns.Add("Current Value") : AllInfo.Columns("Current Value").ReadOnly = True
        AllInfo.Columns.Add("Yesterday's Value") : AllInfo.Columns("Yesterday's Value").ReadOnly = True
        AllInfo.Columns.Add("Last Time Updated") : AllInfo.Columns("Last Time Updated").ReadOnly = True

        InfoSet.Tables.Add(AllInfo)

        Return InfoSet
    End Function

    Private Sub AddDataToDataSetDynamically(Content As DataSet)
        For i = 0 To 199

            Content.Tables("Data").Rows.Add(False, allstockdata(i, code), allstockdata(i, compname),
                                      allstockdata(i, industry), allstockdata(i, cvalue),
                                      allstockdata(i, yvalue), allstockdata(i, timeupdate))

        Next
    End Sub

    Sub CreateGraph()

        If c = 1 Then

            stockentry1.Points.Clear()
            stockentry1.Name = allstockdata(i, code)
            'Change to a line graph.
            stockentry1.ChartType = SeriesChartType.Line
            For b = 19 To 0 Step -1
                If b = 0 Then
                    stockentry1.Points.AddXY(DateTime.Now, allstockdata(i, cvalue))
                Else
                    stockentry1.Points.AddXY(DateTime.Now.AddDays(-b), allstockvalues(i, b))
                End If
            Next
            Chart1.Series.Add(stockentry1)

        ElseIf c = 2 Then

            stockentry2.Points.Clear()
            stockentry2.Name = allstockdata(i, code)
            'Change to a line graph.
            stockentry2.ChartType = SeriesChartType.Line
            For b = 19 To 0 Step -1
                If b = 0 Then
                    stockentry2.Points.AddXY(DateTime.Now, allstockdata(i, cvalue))
                Else
                    stockentry2.Points.AddXY(DateTime.Now.AddDays(-b), allstockvalues(i, b))
                End If
            Next
            Chart1.Series.Add(stockentry2)

        ElseIf c = 3 Then

            stockentry3.Points.Clear()
            stockentry3.Name = allstockdata(i, code)
            'Change to a line graph.
            stockentry3.ChartType = SeriesChartType.Line
            For b = 19 To 0 Step -1
                If b = 0 Then
                    stockentry3.Points.AddXY(DateTime.Now, allstockdata(i, cvalue))
                Else
                    stockentry3.Points.AddXY(DateTime.Now.AddDays(-b), allstockvalues(i, b))
                End If
            Next
            Chart1.Series.Add(stockentry3)

        ElseIf c = 4 Then

            stockentry4.Points.Clear()
            stockentry4.Name = allstockdata(i, code)
            'Change to a line graph.
            stockentry4.ChartType = SeriesChartType.Line
            For b = 19 To 0 Step -1
                If b = 0 Then
                    stockentry4.Points.AddXY(DateTime.Now, allstockdata(i, cvalue))
                Else
                    stockentry4.Points.AddXY(DateTime.Now.AddDays(-b), allstockvalues(i, b))
                End If
            Next
            Chart1.Series.Add(stockentry4)

        ElseIf c = 5 Then

            stockentry5.Points.Clear()
            stockentry5.Name = allstockdata(i, code)
            'Change to a line graph.
            stockentry5.ChartType = SeriesChartType.Line
            For b = 19 To 0 Step -1
                If b = 0 Then
                    stockentry5.Points.AddXY(DateTime.Now, allstockdata(i, cvalue))
                Else
                    stockentry5.Points.AddXY(DateTime.Now.AddDays(-b), allstockvalues(i, b))
                End If
            Next
            Chart1.Series.Add(stockentry5)

        End If
    End Sub

    Sub DeleteGraph()

        If c = 0 Then

            Chart1.Series.Remove(stockentry1)
            Chart1.Series.Clear()

        ElseIf c = 1 Then

            Chart1.Series.Remove(stockentry2)
            Chart1.Series.Clear()
            Chart1.Series.Add(stockentry1)

        ElseIf c = 2 Then

            Chart1.Series.Remove(stockentry3)
            Chart1.Series.Clear()
            Chart1.Series.Add(stockentry1)
            Chart1.Series.Add(stockentry2)

        ElseIf c = 3 Then

            Chart1.Series.Remove(stockentry4)
            Chart1.Series.Clear()
            Chart1.Series.Add(stockentry1)
            Chart1.Series.Add(stockentry2)
            Chart1.Series.Add(stockentry3)

        ElseIf c = 4 Then

            Chart1.Series.Remove(stockentry5)
            Chart1.Series.Clear()
            Chart1.Series.Add(stockentry1)
            Chart1.Series.Add(stockentry2)
            Chart1.Series.Add(stockentry3)
            Chart1.Series.Add(stockentry4)

        End If

    End Sub

    Private Sub StockList1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StockList1.CellContentClick
        Dim checkBoxStatus As Boolean = Convert.ToBoolean(StockList1.CurrentCell.EditedFormattedValue)

        If checkBoxStatus = True And c <= 4 Then

            i = StockList1.CurrentCellAddress.Y
            c += 1
            Call CreateGraph()
        ElseIf c <= 5 And checkBoxStatus = False Then

            i = StockList1.CurrentCellAddress.Y
            c -= 1
            Call DeleteGraph()

        ElseIf c = 5 Then

            MsgBox("You can only show 5 different stock entries!")

        End If

    End Sub

    Private Sub searchbox_Click(sender As Object, e As EventArgs) Handles searchbox.Click
        searchbox.Text = ""
    End Sub


    Private Sub searchbox_LostFocus(sender As Object, e As EventArgs) Handles searchbox.LostFocus
        searchbox.Text = "Please Search Stocks Here..."
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged

        If Me.Text = "" Then

            AllInfo.DefaultView.RowFilter = ""
            StockList1.Refresh()
        ElseIf searchbox.Text = "Please Search Stocks Here..." Then

        Else
            AllInfo.DefaultView.RowFilter = String.Format("CompanyName LIKE '%{0}%'", searchbox.Text)
            StockList1.Refresh()
        End If

    End Sub

    Private Sub Resizer_Tick(sender As Object, e As EventArgs) Handles Resizer.Tick

        Chart1.Width = Me.Width / 2
        Chart1.Height = Me.Height * (47 / 100)

        StockList1.Width = Me.Width / 2
        StockList1.Height = Me.Height * (47 / 100)

        searchbox.Width = Me.Width / 2
        searchbox.Height = Me.Height * (2 / 100)
    End Sub

    Private Sub Chart1_MouseMove(sender As Object, e As MouseEventArgs) Handles Chart1.MouseMove
        Dim h As Windows.Forms.DataVisualization.Charting.HitTestResult = Chart1.HitTest(e.X, e.Y)
        If h.ChartElementType = DataVisualization.Charting.ChartElementType.DataPoint Then
            tooltipprovider.SetToolTip(Chart1, h.Series.Points(h.PointIndex).YValues(0) & " at " & h.Series.Points(h.PointIndex).AxisLabel)
        End If
    End Sub
End Class