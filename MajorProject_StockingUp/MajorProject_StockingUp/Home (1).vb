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
Imports MaterialSkin
Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.WinForms

Public Class RealtimeMarket
    Public StockEntry1, StockEntry2, StockEntry3, StockEntry4, StockEntry5 As New LineSeries
    Public Link As New SheetsQuickstart.Program
    Public InfoSet As New DataSet("All Stock Data")
    Public AllInfo As New DataTable("Data")
    Public Dates As New List(Of String)
    Public MyXAxis As New Axis
    Public MyYAxis As New Axis



    Private Sub RealtimeMarket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        i = 0
        b = 0

        Resizer.Start()
        Call Link.Main()

        'Create Dataset

        InfoSet = CreateDataset()
        'Set DataGridView1 
        StockList1.DataSource = InfoSet.Tables("Data")
        AddDataToDataSetDynamically(InfoSet)

        MyXAxis.Title = "Dates"
        MyYAxis.Title = "Values"

        For b = 19 To 0 Step -1
            Dates.Add(DateTime.Now.AddDays(-b))
        Next

        MyXAxis.Labels = Dates

        StocksGraph.AxisX.Add(MyXAxis)
        StocksGraph.LegendLocation = LegendLocation.Right

    End Sub

    Public Function CreateDataset() As DataSet

        AllInfo.Columns.Add(New DataColumn("View Details", GetType(Boolean)))
        AllInfo.Columns.Add(New DataColumn("Display on Graph", GetType(Boolean)))
        AllInfo.Columns.Add("Code") : AllInfo.Columns("Code").ReadOnly = True
        AllInfo.Columns.Add("CompanyName") : AllInfo.Columns("CompanyName").ReadOnly = True
        AllInfo.Columns.Add("Sector") : AllInfo.Columns("Sector").ReadOnly = True
        AllInfo.Columns.Add("Current Value") : AllInfo.Columns("Current Value").ReadOnly = True
        AllInfo.Columns.Add("Yesterday's Value") : AllInfo.Columns("Yesterday's Value").ReadOnly = True
        AllInfo.Columns.Add("Last Time Updated") : AllInfo.Columns("Last Time Updated").ReadOnly = True

        InfoSet.Tables.Add(AllInfo)

        For Each Col As DataGridViewColumn In StockList1.Columns
            Col.Frozen = False
        Next

        Return InfoSet
    End Function

    Private Sub AddDataToDataSetDynamically(Content As DataSet)
        For i = 0 To 199

            Content.Tables("Data").Rows.Add(False, False, AllStockInfo(i, Code), AllStockInfo(i, CompName),
                                      AllStockInfo(i, Industry), AllStockInfo(i, CurrValue),
                                      AllStockInfo(i, YestValue), AllStockInfo(i, TimeUpdate))

        Next
    End Sub

    Sub CreateGraph()
        b = 19
        If c = 1 Then

            StockEntry1.Title = AllStockInfo(i, Code)



            StockEntry1.Values = New ChartValues(Of Double) From {AllStockValues(i, b), AllStockValues(i, b - 1),
            AllStockValues(i, b - 2), AllStockValues(i, b - 3), AllStockValues(i, b - 4), AllStockValues(i, b - 5), AllStockValues(i, b - 6),
            AllStockValues(i, b - 7), AllStockValues(i, b - 7), AllStockValues(i, b - 8), AllStockValues(i, b - 9), AllStockValues(i, b - 10),
            AllStockValues(i, b - 11), AllStockValues(i, b - 12), AllStockValues(i, b - 13), AllStockValues(i, b - 14), AllStockValues(i, b - 15),
            AllStockValues(i, b - 16), AllStockValues(i, b - 17), AllStockValues(i, b - 18), AllStockValues(i, b - 19)}
            StocksGraph.Series.Add(StockEntry1)



        ElseIf c = 2 Then

            StockEntry2.Title = AllStockInfo(i, Code)

            StockEntry2.Values = New ChartValues(Of Double) From {AllStockValues(i, b), AllStockValues(i, b - 1),
            AllStockValues(i, b - 2), AllStockValues(i, b - 3), AllStockValues(i, b - 4), AllStockValues(i, b - 5), AllStockValues(i, b - 6),
            AllStockValues(i, b - 7), AllStockValues(i, b - 7), AllStockValues(i, b - 8), AllStockValues(i, b - 9), AllStockValues(i, b - 10),
            AllStockValues(i, b - 11), AllStockValues(i, b - 12), AllStockValues(i, b - 13), AllStockValues(i, b - 14), AllStockValues(i, b - 15),
            AllStockValues(i, b - 16), AllStockValues(i, b - 17), AllStockValues(i, b - 18), AllStockValues(i, b - 19)}
            StocksGraph.Series.Add(StockEntry2)


        ElseIf c = 3 Then

            StockEntry3.Title = AllStockInfo(i, Code)

            StockEntry3.Values = New ChartValues(Of Double) From {AllStockValues(i, b), AllStockValues(i, b - 1),
            AllStockValues(i, b - 2), AllStockValues(i, b - 3), AllStockValues(i, b - 4), AllStockValues(i, b - 5), AllStockValues(i, b - 6),
            AllStockValues(i, b - 7), AllStockValues(i, b - 7), AllStockValues(i, b - 8), AllStockValues(i, b - 9), AllStockValues(i, b - 10),
            AllStockValues(i, b - 11), AllStockValues(i, b - 12), AllStockValues(i, b - 13), AllStockValues(i, b - 14), AllStockValues(i, b - 15),
            AllStockValues(i, b - 16), AllStockValues(i, b - 17), AllStockValues(i, b - 18), AllStockValues(i, b - 19)}
            StocksGraph.Series.Add(StockEntry3)

        ElseIf c = 4 Then

            StockEntry4.Title = AllStockInfo(i, Code)

            StockEntry4.Values = New ChartValues(Of Double) From {AllStockValues(i, b), AllStockValues(i, b - 1),
            AllStockValues(i, b - 2), AllStockValues(i, b - 3), AllStockValues(i, b - 4), AllStockValues(i, b - 5), AllStockValues(i, b - 6),
            AllStockValues(i, b - 7), AllStockValues(i, b - 7), AllStockValues(i, b - 8), AllStockValues(i, b - 9), AllStockValues(i, b - 10),
            AllStockValues(i, b - 11), AllStockValues(i, b - 12), AllStockValues(i, b - 13), AllStockValues(i, b - 14), AllStockValues(i, b - 15),
            AllStockValues(i, b - 16), AllStockValues(i, b - 17), AllStockValues(i, b - 18), AllStockValues(i, b - 19)}
            StocksGraph.Series.Add(StockEntry4)

        ElseIf c = 5 Then

            StockEntry5.Title = AllStockInfo(i, Code)

            StockEntry5.Values = New ChartValues(Of Double) From {AllStockValues(i, b), AllStockValues(i, b - 1),
            AllStockValues(i, b - 2), AllStockValues(i, b - 3), AllStockValues(i, b - 4), AllStockValues(i, b - 5), AllStockValues(i, b - 6),
            AllStockValues(i, b - 7), AllStockValues(i, b - 7), AllStockValues(i, b - 8), AllStockValues(i, b - 9), AllStockValues(i, b - 10),
            AllStockValues(i, b - 11), AllStockValues(i, b - 12), AllStockValues(i, b - 13), AllStockValues(i, b - 14), AllStockValues(i, b - 15),
            AllStockValues(i, b - 16), AllStockValues(i, b - 17), AllStockValues(i, b - 18), AllStockValues(i, b - 19)}
            StocksGraph.Series.Add(StockEntry5)

        End If

    End Sub

    Sub DeleteGraph()

        If c = 0 Then

            StocksGraph.Series.Remove(StockEntry1)
            StocksGraph.Series.Clear()

        ElseIf c = 1 Then

            StocksGraph.Series.Remove(StockEntry2)
            StocksGraph.Series.Clear()
            StocksGraph.Series.Add(StockEntry1)

        ElseIf c = 2 Then

            StocksGraph.Series.Remove(StockEntry3)
            StocksGraph.Series.Clear()
            StocksGraph.Series.Add(StockEntry1)
            StocksGraph.Series.Add(StockEntry2)

        ElseIf c = 3 Then

            StocksGraph.Series.Remove(StockEntry4)
            StocksGraph.Series.Clear()
            StocksGraph.Series.Add(StockEntry1)
            StocksGraph.Series.Add(StockEntry2)
            StocksGraph.Series.Add(StockEntry3)

        ElseIf c = 4 Then

            StocksGraph.Series.Remove(StockEntry5)
            StocksGraph.Series.Clear()
            StocksGraph.Series.Add(StockEntry1)
            StocksGraph.Series.Add(StockEntry2)
            StocksGraph.Series.Add(StockEntry3)
            StocksGraph.Series.Add(StockEntry4)

        End If

    End Sub







    Private Sub StockList1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StockList1.CellContentClick

        Dim CheckboxStatus As Boolean = Convert.ToBoolean(StockList1.CurrentCell.EditedFormattedValue)
        Dim ColumnCheck As Integer = StockList1.CurrentCellAddress.X

        If CheckboxStatus = True And c <= 4 And ColumnCheck = 1 Then

            i = StockList1.CurrentCellAddress.Y
            c += 1
            Call CreateGraph()

        ElseIf c < 5 And CheckboxStatus = False And ColumnCheck = 1 Then

            i = StockList1.CurrentCellAddress.Y
            c -= 1
            Call DeleteGraph()

        ElseIf c = 5 And CheckboxStatus = False And ColumnCheck = 1 Then
            c -= 1
            Call DeleteGraph()
        ElseIf c >= 5 And CheckboxStatus = True And ColumnCheck = 1 Then
            MsgBox("You can only show 5 different stock entries!")

        ElseIf ColumnCheck = 0 Then

            For Each row As DataGridViewRow In StockList1.Rows
                row.Cells("View Details").Value = False
            Next

            StockList1.CurrentRow.Cells("View Details").Value = True
            i = StockList1.CurrentCellAddress.Y
            codelbl.Text = AllStockInfo(i, Code)
            namelbl.Text = AllStockInfo(i, CompName)
            sectorlbl.Text = AllStockInfo(i, Industry)
            cvalbl.Text = AllStockInfo(i, CurrValue)
            yvalbl.Text = AllStockInfo(i, YestValue)
            ciplbl.Text = AllStockInfo(i, Delta)
            whlbl.Text = AllStockInfo(i, YearHigh)
            wllbl.Text = AllStockInfo(i, YearLow)
            marklbl.Text = AllStockInfo(i, MarketCap)
            timelbl.Text = AllStockInfo(i, TimeUpdate)

        End If

    End Sub

    Private Sub searchbox_Click(sender As Object, e As EventArgs) Handles SearchBox.Click
        SearchBox.Text = ""
    End Sub


    Private Sub searchbox_LostFocus(sender As Object, e As EventArgs) Handles SearchBox.LostFocus
        SearchBox.Text = "Please Search Stocks Here..."
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged

        If Me.Text = "" Then

            AllInfo.DefaultView.RowFilter = ""
            StockList1.Refresh()
        ElseIf SearchBox.Text = "Please Search Stocks Here..." Then

        Else
            AllInfo.DefaultView.RowFilter = String.Format("CompanyName LIKE '%{0}%'", SearchBox.Text)
            StockList1.Refresh()
        End If

    End Sub

    Private Sub RealtimeMarket_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        GraphPanel.Width = Me.Width * 0.636
        GraphPanel.Height = Me.Height * 0.632

        ListPanel.Width = Me.Width * 0.636
        ListPanel.Height = Me.Height * 0.288

        StockList1.Height = ListPanel.Height * 0.87
        StockList1.Width = ListPanel.Width * 0.988

        SearchBox.Height = ListPanel.Height * 0.12
        SearchBox.Width = ListPanel.Width * 0.988

        StocksGraph.Height = GraphPanel.Height * 0.987
        StocksGraph.Width = GraphPanel.Width * 0.97

        DetailsPanel.Width = Me.Width * 0.35
        DetailsPanel.Height = Me.Height * 0.92

        GraphPanel.Location = New Point((GraphPanel.Margin.Left), (MenuStrip1.Height))
        DetailsPanel.Location = New Point((GraphPanel.Width + 4 * (GraphPanel.Margin.Right)), (MenuStrip1.Height))
        ListPanel.Location = New Point((GraphPanel.Margin.Left), (MenuStrip1.Height + GraphPanel.Height + GraphPanel.Margin.Bottom))
        SearchBox.Location = New Point((SearchBox.Left), (SearchBox.Margin.Top))
        StockList1.Location = New Point((SearchBox.Margin.Left), (SearchBox.Height + SearchBox.Margin.Bottom))

    End Sub
End Class