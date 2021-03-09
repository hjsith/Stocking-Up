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

Public Class Simulation
    Public StockEntry1, StockEntry2, StockEntry3, StockEntry4, StockEntry5 As New LineSeries
    Public Link As New SheetsQuickstart.Program

    Public AllStockDataSet As New DataSet("AllStockData")
    Public AllDataTable As New DataTable("Data")

    Public SingleInfoDataSet As New DataSet("SingleDataSet")
    Public SingleInfoDataTable As New DataTable("SingleDataTable")

    Public SaveData As DataSet

    Public Dates As New List(Of String)
    Public MyXAxis As New Axis
    Public MyYAxis As New Axis

    Public UserBalance, BuyNumber, SellNumber As Integer
    Public TotalPrice As Double



    Private Sub Simulation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        i = 0
        b = 0


        'Create Dataset

        AllStockDataSet = CreateDataset()
        SaveData = CreatePurchaseDataColumns()

        'Set DataGridView1 
        PurchasesGridView.DataSource = SaveData.Tables("Purchases")
        ListGridView.DataSource = AllStockDataSet.Tables("Data")
        AddDataToDataSetDynamically(AllStockDataSet)

        SingleInfoDataTable.Columns.Add("Field") : SingleInfoDataTable.Columns("Field").ReadOnly = True
        SingleInfoDataTable.Columns.Add("Info") : SingleInfoDataTable.Columns("Info").ReadOnly = True
        SingleInfoDataSet.Tables.Add(SingleInfoDataTable)

        MyXAxis.Title = "Dates"
        MyYAxis.Title = "Values"

        For b = 19 To 0 Step -1
            Dates.Add(DateTime.Now.AddDays(-b))
        Next

        MyXAxis.Labels = Dates

        StocksGraph.AxisX.Add(MyXAxis)
        StocksGraph.LegendLocation = LegendLocation.Right

        LoadFromXMLfile(Path.Combine(Directory.GetCurrentDirectory(), "SaveData/savefile.xml"))

        MsgBox(UserBalance)
        GroupBox1.Enabled = False

    End Sub

    Public Function CreateDataset() As DataSet

        AllDataTable.Columns.Add(New DataColumn("View Details", GetType(Boolean)))
        AllDataTable.Columns.Add(New DataColumn("Display on Graph", GetType(Boolean)))
        AllDataTable.Columns.Add("Code") : AllDataTable.Columns("Code").ReadOnly = True
        AllDataTable.Columns.Add("CompanyName") : AllDataTable.Columns("CompanyName").ReadOnly = True
        AllDataTable.Columns.Add("Sector") : AllDataTable.Columns("Sector").ReadOnly = True
        AllDataTable.Columns.Add("Current Value") : AllDataTable.Columns("Current Value").ReadOnly = True
        AllDataTable.Columns.Add("Yesterday's Value") : AllDataTable.Columns("Yesterday's Value").ReadOnly = True
        AllDataTable.Columns.Add("Last Time Updated") : AllDataTable.Columns("Last Time Updated").ReadOnly = True

        AllStockDataSet.Tables.Add(AllDataTable)

        For Each Col As DataGridViewColumn In ListGridView.Columns
            Col.Frozen = False
        Next

        Return AllStockDataSet
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







    Private Sub StockList1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListGridView.CellContentClick

        Dim ColumnCheck As Integer = ListGridView.CurrentCellAddress.X

        If ColumnCheck <= 1 Then
            Dim CheckboxStatus As Boolean = Convert.ToBoolean(ListGridView.CurrentCell.EditedFormattedValue)

            If CheckboxStatus = True And c <= 4 And ColumnCheck = 1 Then

                i = ListGridView.CurrentCellAddress.Y
                c += 1
                Call CreateGraph()

            ElseIf c < 5 And CheckboxStatus = False And ColumnCheck = 1 Then

                i = ListGridView.CurrentCellAddress.Y
                c -= 1
                Call DeleteGraph()

            ElseIf c = 5 And CheckboxStatus = False And ColumnCheck = 1 Then
                c -= 1
                Call DeleteGraph()
            ElseIf c >= 5 And CheckboxStatus = True And ColumnCheck = 1 Then
                MsgBox("You can only show 5 different stock entries!")

            ElseIf ColumnCheck = 0 Then

                For Each row As DataGridViewRow In ListGridView.Rows
                    row.Cells("View Details").Value = False
                Next

                ListGridView.CurrentRow.Cells("View Details").Value = True
                i = ListGridView.CurrentCellAddress.Y

                SingleInfoDataSet.Clear()

                InfoDataGridView.DataSource = SingleInfoDataSet.Tables("SingleDataTable")

                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Company:", AllStockInfo(i, CompName))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Sector:", AllStockInfo(i, Industry))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Current Value:", AllStockInfo(i, CurrValue))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Yesterday's Value:", AllStockInfo(i, YestValue))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Change in Price:", AllStockInfo(i, Delta))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Percentage Change in Price:", AllStockInfo(i, PercentDelta))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("52 Week High:", AllStockInfo(i, YearHigh))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("52 Week Low:", AllStockInfo(i, YearLow))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Market Capitalisation:", AllStockInfo(i, MarketCap))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Last Time Updated:", AllStockInfo(i, TimeUpdate))

                GroupBox1.Enabled = True
            End If
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

            AllDataTable.DefaultView.RowFilter = ""
            ListGridView.Refresh()
        ElseIf SearchBox.Text = "Please Search Stocks Here..." Then

        Else
            AllDataTable.DefaultView.RowFilter = String.Format("CompanyName LIKE '%{0}%'", SearchBox.Text)
            ListGridView.Refresh()
        End If

    End Sub

    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        BuyNumber = BuyCount.Value
        TotalPrice = BuyNumber * AllStockInfo(i, CurrValue)

        AddToSaveData(SaveData)
        SaveToXMLFile(Path.Combine(Directory.GetCurrentDirectory(), "SaveData/savefile.xml"), SaveData)
        UserBalance = UserBalance + BuyNumber
    End Sub

    Private Sub AddToSaveData(Place As DataSet)
        Place.Tables("Purchases").Rows.Add(AllStockInfo(i, Code), BuyNumber, TotalPrice)
    End Sub

    Private Sub Simulation_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        GraphPanel.Width = Me.Width * 0.636
        GraphPanel.Height = Me.Height * 0.632

        ListPanel.Width = Me.Width * 0.636
        ListPanel.Height = Me.Height * 0.288

        ListGridView.Height = ListPanel.Height * 0.87
        ListGridView.Width = ListPanel.Width * 0.988

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
        ListGridView.Location = New Point((SearchBox.Margin.Left), (SearchBox.Height + SearchBox.Margin.Bottom))

    End Sub

    Private Sub SaveToXMLFile(filename As String, d As DataSet)
        Dim ser As XmlSerializer = New XmlSerializer(GetType(DataSet))

        Dim writer As TextWriter = New StreamWriter(filename)
        ser.Serialize(writer, d)

        writer.Close()
    End Sub

    Private Sub LoadFromXMLfile(filename As String)
        If System.IO.File.Exists(filename) Then
            Dim xmlSerializer As XmlSerializer = New XmlSerializer(SaveData.GetType)
            Dim readStream As FileStream = New FileStream(filename, FileMode.Open)
            SaveData = CType(xmlSerializer.Deserialize(readStream), DataSet)
            readStream.Close()
            PurchasesGridView.DataSource = SaveData.Tables("Purchases")
        Else
            MsgBox("file not found! add data and press save button first.", MsgBoxStyle.Exclamation, "")
        End If
    End Sub

    Private Function CreatePurchaseDataColumns() As DataSet
        Dim AllPurchases As New DataSet("AllPurchases")
        Dim PurchasesDataTable As New DataTable("Purchases")
        PurchasesDataTable.Columns.Add("Code")
        PurchasesDataTable.Columns.Add("Number of Stocks")
        PurchasesDataTable.Columns.Add("Purchase Rate")
        AllPurchases.Tables.Add(PurchasesDataTable)
        Return AllPurchases
    End Function
End Class