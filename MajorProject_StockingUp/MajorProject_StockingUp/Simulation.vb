Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Sheets.v4
Imports Google.Apis.Sheets.v4.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports System.IO
Imports System.Threading

Imports System.Net.Http
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.ComponentModel
Imports MaterialSkin
Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.WinForms
Imports System.Windows.Media
Imports System.Windows.Forms

Public Class Simulation

    ''Creates dataset and table for storing all stock data
    Public AllStockDataSet As New DataSet("AllStockData")
    Public AllDataTable As New DataTable("Data")

    ''Creates a dynamic dataset and table for storing a single stock listing's details
    Public SingleInfoDataSet As New DataSet("SingleDataSet")
    Public SingleInfoDataTable As New DataTable("SingleDataTable")

    Public Price As Double ''Holds the sell price

    Public Dates As New List(Of String) ''List of Times  for each hour for the last 19 hours
    Public MyXAxis As New Axis ''Declare Axis to allow for customisation
    Public MyYAxis As New Axis

    Private Sub Simulation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Height = My.Settings.YResolution ''Sets the form height to match previously saved resolution
        Me.Width = My.Settings.XResolution ''Sets the form width to match previously saved resolution

        AllInfoIndex = 0
        InfoElement = 0

        If My.Settings.StartCheck = 0 Then
            UserBalance = 5000
            My.Settings.StartCheck = 1
        End If


        AllStockDataSet = CreateDataset() ''Creates dataset for all stock data

        'Set DataGridView1 
        PurchasesGridView.DataSource = SaveData.Tables("Purchases") ''Displays purchases save data in purchase grid view
        ListGridView.DataSource = AllStockDataSet.Tables("Data") ''Displays all stock data in list grid view
        AddDataToDataSetDynamically(AllStockDataSet) ''Adds all stock data to data set

        SingleInfoDataTable.Columns.Add("Field") : SingleInfoDataTable.Columns("Field").ReadOnly = True ''Sets value to be read only so that the user cannot change the values
        SingleInfoDataTable.Columns.Add("Info") : SingleInfoDataTable.Columns("Info").ReadOnly = True ''Sets value to be read only so that the user cannot change the values
        SingleInfoDataSet.Tables.Add(SingleInfoDataTable)

        MyXAxis.Title = "Dates" ''Sets X Axis label as Dates
        MyYAxis.Title = "Values" ''Sets Y Axis label as Values

        ''Loops and adds hourly times for the last 19 hours
        For InfoElement = 19 To 0 Step -1
            Dates.Add(DateTime.Now.AddHours(-InfoElement))
        Next

        MyXAxis.Labels = Dates ''Adds list to X Axis Label

        StocksGraph.AxisX.Add(MyXAxis) ''Adds custom X Axis to Stocks Graph
        StocksGraph.LegendLocation = LegendLocation.Right ''Changes legend location for graph to be on the left

        BuyGroupBox.Enabled = False ''Allows the user to select a stock listing before purchasing anything

        ListGridView.Columns("ID").Visible = False ''Hides ID column to user, however allows for program to still reference it
        ListGridView.Columns("ID").Visible = False ''Hides ID column to user, however allows for program to still reference it

        Call Resize() ''Calls the resize function to scale all controls based on form size
        Me.CenterToScreen() ''Centers the form onto screen

    End Sub

    Public Function CreateDataset() As DataSet

        AllDataTable.Columns.Add(New DataColumn("View Details", GetType(Boolean))) ''Creates column with checkboxes
        AllDataTable.Columns.Add(New DataColumn("Display on Graph", GetType(Boolean))) ''Creates column with checkboxes
        AllDataTable.Columns.Add("ID") : AllDataTable.Columns("ID").ReadOnly = True ''Creates read only ID column
        AllDataTable.Columns.Add("Code") : AllDataTable.Columns("Code").ReadOnly = True ''Creates read only Code column
        AllDataTable.Columns.Add("CompanyName") : AllDataTable.Columns("CompanyName").ReadOnly = True ''Creates read only Company Name column
        AllDataTable.Columns.Add("Sector") : AllDataTable.Columns("Sector").ReadOnly = True ''Creates read only Sector column
        AllDataTable.Columns.Add("Current Value") : AllDataTable.Columns("Current Value").ReadOnly = True ''Creates read only Current Value column
        AllDataTable.Columns.Add("Yesterday's Value") : AllDataTable.Columns("Yesterday's Value").ReadOnly = True ''Creates read only Yesterday's Value column
        AllDataTable.Columns.Add("Last Time Updated") : AllDataTable.Columns("Last Time Updated").ReadOnly = True ''Creates read only Last Time Updated column

        AllStockDataSet.Tables.Add(AllDataTable)

        For Each Col As DataGridViewColumn In ListGridView.Columns ''Loops through each column and freezes them so that searchbar can work
            Col.Frozen = False
        Next

        Return AllStockDataSet
    End Function

    Private Sub AddDataToDataSetDynamically(Content As DataSet)

        ''Adds all stock data to Data Table
        For AllInfoIndex = 0 To 199

            Content.Tables("Data").Rows.Add(False, False, AllStockInfo(AllInfoIndex, ID), AllStockInfo(AllInfoIndex, Code), AllStockInfo(AllInfoIndex, CompName),
                                      AllStockInfo(AllInfoIndex, Industry), AllStockInfo(AllInfoIndex, CurrValue),
                                      AllStockInfo(AllInfoIndex, YestValue), AllStockInfo(AllInfoIndex, TimeUpdate))

        Next
    End Sub

    Sub CreateGraph()
        InfoElement = 19 ''Sets to 19 so that all 19 values can be retrieved
        If SeriesCheck = 1 Then ''Checks if there is only one series

            StockEntry1.Title = AllStockInfo(AllInfoIndex, Code)

            StockEntry1.Values = New ChartValues(Of Double) From {AllStockValues(AllInfoIndex, InfoElement), AllStockValues(AllInfoIndex, InfoElement - 1),
            AllStockValues(AllInfoIndex, InfoElement - 2), AllStockValues(AllInfoIndex, InfoElement - 3), AllStockValues(AllInfoIndex, InfoElement - 4), AllStockValues(AllInfoIndex, InfoElement - 5), AllStockValues(AllInfoIndex, InfoElement - 6),
            AllStockValues(AllInfoIndex, InfoElement - 7), AllStockValues(AllInfoIndex, InfoElement - 7), AllStockValues(AllInfoIndex, InfoElement - 8), AllStockValues(AllInfoIndex, InfoElement - 9), AllStockValues(AllInfoIndex, InfoElement - 10),
            AllStockValues(AllInfoIndex, InfoElement - 11), AllStockValues(AllInfoIndex, InfoElement - 12), AllStockValues(AllInfoIndex, InfoElement - 13), AllStockValues(AllInfoIndex, InfoElement - 14), AllStockValues(AllInfoIndex, InfoElement - 15),
            AllStockValues(AllInfoIndex, InfoElement - 16), AllStockValues(AllInfoIndex, InfoElement - 17), AllStockValues(AllInfoIndex, InfoElement - 18), AllStockValues(AllInfoIndex, InfoElement - 19)}
            StocksGraph.Series.Add(StockEntry1)



        ElseIf SeriesCheck = 2 Then ''Checks if there is only two series

            StockEntry2.Title = AllStockInfo(AllInfoIndex, Code)

            StockEntry2.Values = New ChartValues(Of Double) From {AllStockValues(AllInfoIndex, InfoElement), AllStockValues(AllInfoIndex, InfoElement - 1),
            AllStockValues(AllInfoIndex, InfoElement - 2), AllStockValues(AllInfoIndex, InfoElement - 3), AllStockValues(AllInfoIndex, InfoElement - 4), AllStockValues(AllInfoIndex, InfoElement - 5), AllStockValues(AllInfoIndex, InfoElement - 6),
            AllStockValues(AllInfoIndex, InfoElement - 7), AllStockValues(AllInfoIndex, InfoElement - 7), AllStockValues(AllInfoIndex, InfoElement - 8), AllStockValues(AllInfoIndex, InfoElement - 9), AllStockValues(AllInfoIndex, InfoElement - 10),
            AllStockValues(AllInfoIndex, InfoElement - 11), AllStockValues(AllInfoIndex, InfoElement - 12), AllStockValues(AllInfoIndex, InfoElement - 13), AllStockValues(AllInfoIndex, InfoElement - 14), AllStockValues(AllInfoIndex, InfoElement - 15),
            AllStockValues(AllInfoIndex, InfoElement - 16), AllStockValues(AllInfoIndex, InfoElement - 17), AllStockValues(AllInfoIndex, InfoElement - 18), AllStockValues(AllInfoIndex, InfoElement - 19)}
            StocksGraph.Series.Add(StockEntry2)


        ElseIf SeriesCheck = 3 Then ''Checks if there is only three series

            StockEntry3.Title = AllStockInfo(AllInfoIndex, Code)

            StockEntry3.Values = New ChartValues(Of Double) From {AllStockValues(AllInfoIndex, InfoElement), AllStockValues(AllInfoIndex, InfoElement - 1),
            AllStockValues(AllInfoIndex, InfoElement - 2), AllStockValues(AllInfoIndex, InfoElement - 3), AllStockValues(AllInfoIndex, InfoElement - 4), AllStockValues(AllInfoIndex, InfoElement - 5), AllStockValues(AllInfoIndex, InfoElement - 6),
            AllStockValues(AllInfoIndex, InfoElement - 7), AllStockValues(AllInfoIndex, InfoElement - 7), AllStockValues(AllInfoIndex, InfoElement - 8), AllStockValues(AllInfoIndex, InfoElement - 9), AllStockValues(AllInfoIndex, InfoElement - 10),
            AllStockValues(AllInfoIndex, InfoElement - 11), AllStockValues(AllInfoIndex, InfoElement - 12), AllStockValues(AllInfoIndex, InfoElement - 13), AllStockValues(AllInfoIndex, InfoElement - 14), AllStockValues(AllInfoIndex, InfoElement - 15),
            AllStockValues(AllInfoIndex, InfoElement - 16), AllStockValues(AllInfoIndex, InfoElement - 17), AllStockValues(AllInfoIndex, InfoElement - 18), AllStockValues(AllInfoIndex, InfoElement - 19)}
            StocksGraph.Series.Add(StockEntry3)

        ElseIf SeriesCheck = 4 Then ''Checks if there is only four series

            StockEntry4.Title = AllStockInfo(AllInfoIndex, Code)

            StockEntry4.Values = New ChartValues(Of Double) From {AllStockValues(AllInfoIndex, InfoElement), AllStockValues(AllInfoIndex, InfoElement - 1),
            AllStockValues(AllInfoIndex, InfoElement - 2), AllStockValues(AllInfoIndex, InfoElement - 3), AllStockValues(AllInfoIndex, InfoElement - 4), AllStockValues(AllInfoIndex, InfoElement - 5), AllStockValues(AllInfoIndex, InfoElement - 6),
            AllStockValues(AllInfoIndex, InfoElement - 7), AllStockValues(AllInfoIndex, InfoElement - 7), AllStockValues(AllInfoIndex, InfoElement - 8), AllStockValues(AllInfoIndex, InfoElement - 9), AllStockValues(AllInfoIndex, InfoElement - 10),
            AllStockValues(AllInfoIndex, InfoElement - 11), AllStockValues(AllInfoIndex, InfoElement - 12), AllStockValues(AllInfoIndex, InfoElement - 13), AllStockValues(AllInfoIndex, InfoElement - 14), AllStockValues(AllInfoIndex, InfoElement - 15),
            AllStockValues(AllInfoIndex, InfoElement - 16), AllStockValues(AllInfoIndex, InfoElement - 17), AllStockValues(AllInfoIndex, InfoElement - 18), AllStockValues(AllInfoIndex, InfoElement - 19)}
            StocksGraph.Series.Add(StockEntry4)

        ElseIf SeriesCheck = 5 Then ''Checks if there is only five series

            StockEntry5.Title = AllStockInfo(AllInfoIndex, Code)

            StockEntry5.Values = New ChartValues(Of Double) From {AllStockValues(AllInfoIndex, InfoElement), AllStockValues(AllInfoIndex, InfoElement - 1),
            AllStockValues(AllInfoIndex, InfoElement - 2), AllStockValues(AllInfoIndex, InfoElement - 3), AllStockValues(AllInfoIndex, InfoElement - 4), AllStockValues(AllInfoIndex, InfoElement - 5), AllStockValues(AllInfoIndex, InfoElement - 6),
            AllStockValues(AllInfoIndex, InfoElement - 7), AllStockValues(AllInfoIndex, InfoElement - 7), AllStockValues(AllInfoIndex, InfoElement - 8), AllStockValues(AllInfoIndex, InfoElement - 9), AllStockValues(AllInfoIndex, InfoElement - 10),
            AllStockValues(AllInfoIndex, InfoElement - 11), AllStockValues(AllInfoIndex, InfoElement - 12), AllStockValues(AllInfoIndex, InfoElement - 13), AllStockValues(AllInfoIndex, InfoElement - 14), AllStockValues(AllInfoIndex, InfoElement - 15),
            AllStockValues(AllInfoIndex, InfoElement - 16), AllStockValues(AllInfoIndex, InfoElement - 17), AllStockValues(AllInfoIndex, InfoElement - 18), AllStockValues(AllInfoIndex, InfoElement - 19)}
            StocksGraph.Series.Add(StockEntry5)

        End If

    End Sub

    Sub DeleteGraph()

        If SeriesCheck = 0 Then

            StocksGraph.Series.Remove(StockEntry1) ''Clears all series
            StocksGraph.Series.Clear()

        ElseIf SeriesCheck = 1 Then
            ''Clears second series but adds 1st one back
            StocksGraph.Series.Remove(StockEntry2)
            StocksGraph.Series.Clear()
            StocksGraph.Series.Add(StockEntry1)

        ElseIf SeriesCheck = 2 Then
            ''Clears third series but adds 1st and 2nd back
            StocksGraph.Series.Remove(StockEntry3)
            StocksGraph.Series.Clear()
            StocksGraph.Series.Add(StockEntry1)
            StocksGraph.Series.Add(StockEntry2)

        ElseIf SeriesCheck = 3 Then
            ''Clears fourth series but adds 1st, 2nd and 3rd back
            StocksGraph.Series.Remove(StockEntry4)
            StocksGraph.Series.Clear()
            StocksGraph.Series.Add(StockEntry1)
            StocksGraph.Series.Add(StockEntry2)
            StocksGraph.Series.Add(StockEntry3)

        ElseIf SeriesCheck = 4 Then
            ''Clears fifth series but adds 1st, 2nd, 3rd and 4th back
            StocksGraph.Series.Remove(StockEntry5)
            StocksGraph.Series.Clear()
            StocksGraph.Series.Add(StockEntry1)
            StocksGraph.Series.Add(StockEntry2)
            StocksGraph.Series.Add(StockEntry3)
            StocksGraph.Series.Add(StockEntry4)

        End If

    End Sub

    Private Sub StockList1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListGridView.CellContentClick

        Dim ColumnCheck As Integer = ListGridView.CurrentCellAddress.X ''Checks which checkbox column was ticked

        Cursor = Cursors.AppStarting ''Shows loading icon as this section takes a long time to load

        If ColumnCheck <= 1 Then ''Checks if it is the Display On Graph checkbox column
            Dim CheckboxStatus As Boolean = Convert.ToBoolean(ListGridView.CurrentCell.EditedFormattedValue) ''Sets checkbox status to check if already checked

            If CheckboxStatus = True And SeriesCheck <= 4 And ColumnCheck = 1 Then ''Checks if they've checked the display column and have all series
                AllInfoIndex = ListGridView.CurrentRow.Cells("ID").Value
                SeriesCheck += 1
                Call CreateGraph()

            ElseIf SeriesCheck <= 5 And CheckboxStatus = False And ColumnCheck = 1 Then ''Checks if they've checked the display column and have all series

                AllInfoIndex = ListGridView.CurrentRow.Cells("ID").Value
                SeriesCheck -= 1
                Call DeleteGraph()


            ElseIf SeriesCheck >= 5 And CheckboxStatus = True And ColumnCheck = 1 Then ''Checks if they've checked the display column and have all series

                MsgBox("You can only show 5 different stock entries!") ''Alerts user that only 5 series can be displayed at once

            ElseIf ColumnCheck = 0 Then ''Checks if it is the View Details checkbox column

                ''View details is meant to only have one checked cell, so this code sets all the other checkboxes to false

                For Each row As DataGridViewRow In ListGridView.Rows
                    row.Cells("View Details").Value = False
                Next

                ListGridView.CurrentRow.Cells("View Details").Value = True ''Sets clicked cell to checked
                StockInfoIndex = ListGridView.CurrentRow.Cells("ID").Value ''Gets row number

                SingleInfoDataSet.Clear() ''Prepares dataset for new data

                CodeLabel.Text = AllStockInfo(StockInfoIndex, Code) ''Displays code name

                InfoDataGridView.DataSource = SingleInfoDataSet.Tables("SingleDataTable") ''Displays SingleInfo Dataset on Info Data Grid View

                '' This section adds all the info required

                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Company:", AllStockInfo(StockInfoIndex, CompName))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Sector:", AllStockInfo(StockInfoIndex, Industry))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Current Value:", AllStockInfo(StockInfoIndex, CurrValue))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Yesterday's Value:", AllStockInfo(StockInfoIndex, YestValue))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Change in Price:", AllStockInfo(StockInfoIndex, Delta))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Percentage Change in Price:", AllStockInfo(StockInfoIndex, PercentDelta))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("52 Week High:", AllStockInfo(StockInfoIndex, YearHigh))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("52 Week Low:", AllStockInfo(StockInfoIndex, YearLow))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Market Capitalisation:", AllStockInfo(StockInfoIndex, MarketCap))
                SingleInfoDataSet.Tables("SingleDataTable").Rows.Add("Last Time Updated:", AllStockInfo(StockInfoIndex, TimeUpdate))

                BuyGroupBox.Enabled = True
                SellCount.Maximum = 0 ''Temporarily sets max to be 0 until checked

                SellCheck = 0 ''Checks if user can sell

                BuyButton.Enabled = True
                BuyCount.Enabled = True

                BuyCount.Maximum = Math.Floor(UserBalance / AllStockInfo(StockInfoIndex, CurrValue)) ''Rounds down the number of stocks user can buy, to whole number


                ''Loops through each row in the purchases row to see if stocks were previously purchased from company

                For Each row As DataGridViewRow In PurchasesGridView.Rows

                    If row.Cells("Code").Value = AllStockInfo(StockInfoIndex, Code) Then

                        PurchaseIndex = row.Cells("Code").DataGridView.CurrentCellAddress.Y ''Gets index of row
                        BuyButton.Enabled = False ''Disables purchasing ability
                        BuyCount.Enabled = False

                        Exit For
                    End If

                Next

            End If
        End If
        Cursor = Cursors.Default ''Resets cursor back to normal
    End Sub

    Private Sub searchbox_Click(sender As Object, e As EventArgs) Handles SearchBox.Click
        SearchBox.Text = "" ''On click, searchbox is empty
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
            AllDataTable.DefaultView.RowFilter = String.Format("CompanyName LIKE '%{0}%'", SearchBox.Text) ''Searchbox text is used to filter the Company Name column of the all data table
            ListGridView.Refresh() ''Refreshes list grid to accommodate new filtered data table
        End If

    End Sub

    Private Sub BuyCount_ValueChanged(sender As Object, e As EventArgs) Handles BuyCount.ValueChanged
        BuyNumber = BuyCount.Value ''Stores value in varaible for later use

        TotalBuyPrice = BuyNumber * AllStockInfo(StockInfoIndex, CurrValue) ''Calculates how much money shall be deducted from User Balance
        BuyPriceLabel.Text = "$" & TotalBuyPrice & " will be deducted from your funds." ''Displays this information to user

        BuyAmendBalance.Text = "You will have $" & Decimal.Round((UserBalance - TotalBuyPrice), 2, MidpointRounding.AwayFromZero) & " remaining in your balance..." ''Rounds down to two decimal places
    End Sub

    Private Sub SellCount_ValueChanged(sender As Object, e As EventArgs) Handles SellCount.ValueChanged

        SellNumber = SellCount.Value ''Stores value in variable for later use
        MaxCounter = PurchasesGridView.Rows(PurchaseIndex).Cells(1).Value ''Max amount user can sell is the amount of stocks they bought
        SellCount.Maximum = MaxCounter
        SellPriceLabel.Visible = True

        If AllStockInfo(StockInfoIndex, CurrValue) > (PurchasesGridView.Rows(PurchaseIndex).Cells(2).Value / PurchasesGridView.Rows(PurchaseIndex).Cells(1).Value) Then ''Checks for profit

            ProfitLossString = "profit" ''Changes variable to reflect profit

            Price = (AllStockInfo(StockInfoIndex, CurrValue) - (PurchasesGridView.Rows(PurchaseIndex).Cells(2).Value / PurchasesGridView.Rows(PurchaseIndex).Cells(1).Value)) * SellNumber
            Price = Decimal.Round(Price, 2, MidpointRounding.AwayFromZero) ''Rounds down calculated price to two decimal places

            SellPriceLabel.Text = "By selling " & SellNumber & " of " & MaxCounter & " shares, you will " & ProfitLossString _
            & " " & (Price - PurchasesGridView.Rows(PurchaseIndex).Cells(1).Value) ''Displays profit to user

        ElseIf AllStockInfo(StockInfoIndex, CurrValue) = (PurchasesGridView.Rows(PurchaseIndex).Cells(2).Value / PurchasesGridView.Rows(PurchaseIndex).Cells(1).Value) Then ''Checks for breakeven

            ProfitLossString = "breakeven" ''Changes variable to reflect breakeven
            SellPriceLabel.Text = "By selling " & SellNumber & " of " & MaxCounter & " shares, you will " & ProfitLossString

        ElseIf AllStockInfo(StockInfoIndex, CurrValue) < (PurchasesGridView.Rows(PurchaseIndex).Cells(2).Value / PurchasesGridView.Rows(PurchaseIndex).Cells(1).Value) Then ''Checks for loss

            ProfitLossString = "lose" ''Changes variable to reflect loss

            Price = (AllStockInfo(StockInfoIndex, CurrValue) - (PurchasesGridView.Rows(PurchaseIndex).Cells(2).Value / PurchasesGridView.Rows(PurchaseIndex).Cells(1).Value)) * SellCount.Value
            Price = Decimal.Round(Price, 2, MidpointRounding.AwayFromZero) ''Rounds down calculated price to two decimal places

            SellPriceLabel.Text = "By selling " & SellNumber & " of " & MaxCounter & " shares, you will " & ProfitLossString _
            & " " & (PurchasesGridView.Rows(PurchaseIndex).Cells(1).Value - Price) ''Displays loss to user

        End If

        TotalSellPrice = SellNumber * AllStockInfo(StockInfoIndex, CurrValue) ''Calculates sell price
        SellAmendBalance.Text = "You will have $" & (UserBalance + TotalSellPrice) & " in your balance after you sell..."


    End Sub

    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click

        BuyNumber = BuyCount.Value
        TotalBuyPrice = BuyNumber * AllStockInfo(StockInfoIndex, CurrValue) ''Calculates buy price
        UserBalance = UserBalance - TotalBuyPrice ''Updates UserBalance
        BOS = 2 ''Sets flag to be 2 so that transaction log can know its a purchase

        Saves.AddToSaveData(SaveData) ''Adds it to the purchases
        Saves.AddToHistoryData(HistoryData) ''Adds to History Data

        Saves.SaveToXMLFile(Path.Combine(Directory.GetCurrentDirectory(), "SaveData/savefile.xml"), SaveData) ''Save Purchases to XML file
        Saves.SaveToXMLFile(Path.Combine(Directory.GetCurrentDirectory(), "SaveData/transactions.xml"), HistoryData) ''Save History to XML file
        My.Settings.UserBalance = UserBalance ''Stores updated userbalance within program
        BuyButton.Enabled = False ''Disables users ability to purchases more stocks
        BuyCount.Enabled = False

        If UserBalance = 1000000 Then ''Checks for win
            MessageBox.Show("Congratulations! You're a millionaire",
                                              "You win!",
                                              MessageBoxButtons.OK)

            Dim YN As DialogResult = MessageBox.Show("Do you want to start again from the beginning?",
                      "Restart?",
                      MessageBoxButtons.YesNo) ''Offers new game to users

            If YN = DialogResult.Yes Then

                For Each FileFound As String In Directory.GetFiles((Path.Combine(Directory.GetCurrentDirectory(), "SaveData/")), ".xml")
                    File.Delete(FileFound) ''Deletes all XML Save files
                Next
                Application.Restart() ''Restarts application

            End If

        End If

    End Sub

    Private Sub SellButton_Click(sender As Object, e As EventArgs) Handles SellButton.Click

        SellButton.Enabled = False ''Disables sell button temporarily

        If SellNumber = 0 Then ''Checks if user is trying to sell zero stocks

            MsgBox("You can't sell zero stocks!")
            SellButton.Enabled = True

        Else
            For Each row As DataGridViewRow In PurchasesGridView.Rows ''Loops through each row and searches for purchases

                If row.Cells("Code").Value = AllStockInfo(StockInfoIndex, Code) Then ''Matches up code

                    If row.Cells("Number of Stocks").Value = SellNumber Then ''If User is selling all stocks from one listing

                        If ProfitLossString = "profit" Then ''In case of profit

                            TotalMoneyMade = TotalMoneyMade + Math.Abs(Price) ''Adds to cumulative profit

                            If BiggestProfit < Convert.ToDouble(Price) Then ''Checks for biggest profit
                                BiggestProfit = Convert.ToDouble(Price)
                            End If

                        ElseIf ProfitLossString = "lose" Then ''In case of loss

                            TotalMoneyLost = TotalMoneyLost + Math.Abs(Price) ''Adds to cumulative loss

                            If BiggestLoss < Convert.ToDouble(Price) Then ''Checks for biggest loss
                                BiggestLoss = Convert.ToDouble(Price)
                            End If
                        End If

                        PurchasesGridView.Rows.RemoveAt(PurchaseIndex) ''Removes purchase row
                        UserBalance = UserBalance + TotalSellPrice ''Updates UserBalance
                        BOS = 1 ''Set BOS flag to 1 to show Sell
                        Saves.AddToHistoryData(HistoryData) ''Add History Data to Dataset

                    ElseIf row.Cells("Number of Stocks").Value > SellNumber Then ''Partially selling all their stocks from one listing

                        If ProfitLossString = "profit" Then ''In case of profit

                            TotalMoneyMade = TotalMoneyMade + Math.Abs(Price) ''Adds to cumulative profit
                            If BiggestProfit < Convert.ToDouble(Price) Then ''Checks for biggest profit
                                BiggestProfit = Convert.ToDouble(Price)
                            End If

                        ElseIf ProfitLossString = "lose" Then ''In case of loss

                            TotalMoneyLost = TotalMoneyLost + Math.Abs(Price) ''Adds to cumulative loss
                            If BiggestLoss < Convert.ToDouble(Price) Then ''Checks for biggest loss
                                BiggestLoss = Convert.ToDouble(Price)
                            End If

                        End If
                        row.Cells("Number of Stocks").Value = row.Cells("Number of Stocks").Value - SellNumber ''Updates number of stocks left
                        UserBalance = UserBalance + TotalSellPrice ''Updates UserBalance
                        BOS = 1 ''Set BOS flag to 1 to show Sell
                        Saves.AddToHistoryData(HistoryData) ''Add History Data to Dataset





                    End If
                    Saves.AddToRecordData(RecordsData) ''Add Record Data to Dataset
                End If

            Next

            Saves.SaveToXMLFile(Path.Combine(Directory.GetCurrentDirectory(), "SaveData/savefile.xml"), SaveData) ''Saves updated purchases to XML file
            My.Settings.UserBalance = UserBalance ''Stores updated userbalance within program
            Saves.SaveToXMLFile(Path.Combine(Directory.GetCurrentDirectory(), "SaveData/transactions.xml"), HistoryData) ''Saves updated history data to XML file
            Saves.SaveToXMLFile(Path.Combine(Directory.GetCurrentDirectory(), "SaveData/records.xml"), RecordsData) ''Saves updated records data to XML file
        End If
    End Sub

    Private Sub BUYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUYToolStripMenuItem.Click
        BuyGroupBox.Visible = True ''Shows Buy Box
        SellGroupBox.Visible = False ''Hides Sell Box
    End Sub

    Private Sub SELLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELLToolStripMenuItem.Click
        BuyGroupBox.Visible = False ''Shows Sell Box
        SellGroupBox.Visible = True ''Hides Buy Box
        If PurchaseIndex <> -1 Then ''Error checking for no purchases
            SellCount.Maximum = PurchasesGridView.Rows(PurchaseIndex).Cells(1).Value ''Sets sellcount maximum of random
        End If
    End Sub

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseDown
        ''Checks if mouse is held down on menustrip to allow repositioning of form

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Cross
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseMove

        ''Moves the form

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseUp

        ''Leaves the form in one location

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Me.Close() ''Closes Simulation Form
        Home.Show() ''Shows Home Form
    End Sub

    Private Sub REALTIMEMARKETPLACEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PortfolioToolStripMenuItem.Click
        Me.Close() ''Closes Simulation Form
        MyPortfolio.Show() ''Shows My Portfolio Form
    End Sub

    Private Sub FormExit_Click(sender As Object, e As EventArgs) Handles FormExit.Click

        ''Presents user with messagebox to exit form

        Dim YN As DialogResult = MessageBox.Show("Are you sure you want to exit the application?",
                                                      "Exit the application?",
                                                      MessageBoxButtons.YesNo)

        ''If they want to exit the application, casts for all open forms and closes them all
        If YN = DialogResult.Yes Then
            My.Application.OpenForms.Cast(Of Form)() _
              .ToList() _
              .ForEach(Sub(form) form.Close())
        End If
    End Sub

    Private Sub Resize()

        ''Checks every control in the form, and applys custom font sizes to each one

        For Each cntrl As Control In Me.Controls

            If cntrl Is MenuStrip1 Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 200), FontStyle.Bold)

            ElseIf cntrl Is FormExit Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 200), FontStyle.Bold)

            ElseIf cntrl Is SetButton Then

                SetButton.Font = New Font("Arial Unicode MS", Convert.ToSingle(Me.ClientSize.Width / 150), FontStyle.Regular)
                SetButton.Text = ChrW(&H2699)

            End If
        Next

        For Each cntrl As Control In ListPanel.Controls
            If cntrl Is ListGridView Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 300), FontStyle.Bold)

            ElseIf cntrl Is SearchBox Then
                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 100), FontStyle.Bold)

            End If
        Next

        For Each cntrl As Control In DetailsPanel.Controls
            If cntrl Is InfoDataGridView Or cntrl Is PurchasesGridView Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 300), FontStyle.Bold)

            ElseIf cntrl Is MenuStrip2 Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 200), FontStyle.Bold)

            ElseIf cntrl Is CodeLabel Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 100), FontStyle.Bold)

            ElseIf cntrl Is BuyGroupBox Or cntrl Is SellGroupBox Then

                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 140), FontStyle.Bold)

                For Each subcntrl As Control In cntrl.Controls

                    If subcntrl Is BuyButton Or subcntrl Is SellButton Then

                        subcntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 200), FontStyle.Bold)

                    ElseIf subcntrl Is BuyAmendBalance Or subcntrl Is BuyPriceLabel Or subcntrl Is SellAmendBalance Or subcntrl Is SellPriceLabel Then

                        subcntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 250), FontStyle.Bold)

                    ElseIf subcntrl Is BuyCount Or subcntrl Is SellCount Then

                        subcntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 100), FontStyle.Bold)

                    End If
                Next

            ElseIf cntrl Is SearchBox2 Then
                cntrl.Font = New Font("Segoe UI", Convert.ToSingle(Me.ClientSize.Width / 100), FontStyle.Bold)

            End If
        Next

        ''Changes control dimensions based on form height and width

        MenuStrip1.Height = Me.Height * 0.046
        MenuStrip1.Width = Me.Width

        GraphPanel.Height = Me.Height * 0.62
        GraphPanel.Width = Me.Width * 0.611
        GraphPanel.Location = New Point(0.7 * GraphPanel.Padding.Left, MenuStrip1.Height + GraphPanel.Margin.Top)

        StocksGraph.Height = GraphPanel.Height * 0.96
        StocksGraph.Width = GraphPanel.Width * 0.96

        ListPanel.Height = Me.Height * 0.32
        ListPanel.Width = Me.Width * 0.611
        ListPanel.Location = New Point(ListPanel.Margin.Left, MenuStrip1.Height + GraphPanel.Height + GraphPanel.Margin.Top + GraphPanel.Margin.Bottom)

        DetailsPanel.Height = Me.Height * 0.94
        DetailsPanel.Width = Me.Width * 0.38
        DetailsPanel.Location = New Point(GraphPanel.Width + GraphPanel.Margin.Left + GraphPanel.Margin.Right, MenuStrip1.Height + GraphPanel.Margin.Top)

        ListGridView.Height = ListPanel.Height * 0.7
        ListGridView.Width = ListPanel.Width * 0.96

        CodeLabel.Height = CodeLabel.Font.Height
        CodeLabel.Location = New Point(DetailsPanel.Width / 2 - CodeLabel.Width / 2, MenuStrip2.Height)

        InfoDataGridView.Height = DetailsPanel.Height * 0.33
        InfoDataGridView.Width = DetailsPanel.Width * 0.96
        InfoDataGridView.Location = New Point(DetailsPanel.Width * 0.02, MenuStrip2.Height + CodeLabel.Height)

        BuyGroupBox.Height = DetailsPanel.Height * 0.247
        BuyGroupBox.Width = DetailsPanel.Width
        BuyGroupBox.Location = New Point(0, MenuStrip2.Height + CodeLabel.Height + InfoDataGridView.Height)

        SellGroupBox.Height = DetailsPanel.Height * 0.25
        SellGroupBox.Width = DetailsPanel.Width
        SellGroupBox.Location = New Point(0, MenuStrip2.Height + CodeLabel.Height + InfoDataGridView.Height)

        SearchBox2.Height = SearchBox.Height
        SearchBox2.Width = DetailsPanel.Width * 0.96
        SearchBox2.Location = New Point(DetailsPanel.Width * 0.02, BuyGroupBox.Location.Y + BuyGroupBox.Height + SearchBox2.Margin.Top)

        PurchasesGridView.Height = ListGridView.Height
        PurchasesGridView.Width = DetailsPanel.Width * 0.96
        PurchasesGridView.Location = New Point(DetailsPanel.Width * 0.02, SearchBox2.Location.Y + SearchBox2.Height + SearchBox2.Margin.Top)

        SellButton.Height = SellCount.Height
        SellButton.Width = SellButton.Height * 2
        SellButton.Location = New Point(SellButton.Margin.Left, 2 * SellButton.Height)

        SellCount.Height = SellGroupBox.Height / 2
        SellCount.Width = SellCount.Height * 2
        SellCount.Location = New Point(SellButton.Margin.Left + SellButton.Margin.Right + SellButton.Width, SellButton.Location.Y)

        SellPriceLabel.Location = New Point(SellCount.Location.X + SellCount.Width + SellPriceLabel.Margin.Left, SellButton.Location.Y)
        SellAmendBalance.Location = New Point(SellAmendBalance.Margin.Left, SellButton.Location.Y * 2)

        BuyButton.Height = BuyCount.Height
        BuyButton.Width = BuyButton.Height * 2
        BuyButton.Location = New Point(BuyButton.Margin.Left, 2 * BuyButton.Height)

        BuyCount.Height = BuyGroupBox.Height / 2
        BuyCount.Width = BuyCount.Height * 2
        BuyCount.Location = New Point(BuyButton.Margin.Left + BuyButton.Margin.Right + BuyButton.Width, BuyButton.Location.Y)

        BuyPriceLabel.Location = New Point(BuyCount.Location.X + BuyCount.Width + BuyPriceLabel.Margin.Left, BuyButton.Location.Y)
        BuyAmendBalance.Location = New Point(BuyAmendBalance.Margin.Left, BuyButton.Location.Y * 2)
    End Sub

    Private Sub SetButton_(sender As Object, e As EventArgs) Handles SetButton.Click
        ''Shows the settings form, as a dialog so you cannot click away, without properly closing it
        Settings.ShowDialog()
    End Sub

    Private Sub searchbox2_Click(sender As Object, e As EventArgs) Handles SearchBox2.Click
        ''On click, searchbox is empty
        SearchBox.Text = ""
    End Sub

    Private Sub searchbox2_LostFocus(sender As Object, e As EventArgs) Handles SearchBox2.LostFocus
        SearchBox.Text = "Please Search Stocks Here..."
    End Sub

    Private Sub searchbox2_TextChanged(sender As Object, e As EventArgs) Handles SearchBox2.TextChanged

        If Me.Text = "" Then

            SaveData.Tables("Purchases").DefaultView.RowFilter = ""
            PurchasesGridView.Refresh()

        ElseIf SearchBox.Text = "Please Search Stocks Here..." Then

        Else

            SaveData.Tables("Purchases").DefaultView.RowFilter = String.Format("Code LIKE '%{0}%'", SearchBox2.Text) ''Searchbox text is used to filter the Company Name column of the all data table
            PurchasesGridView.Refresh() ''Refreshes list grid to accommodate new filtered data table

        End If

    End Sub
End Class
