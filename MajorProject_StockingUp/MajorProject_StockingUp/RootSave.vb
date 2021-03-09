Imports System.IO
Imports System.Threading
Imports System.Collections.Generic

Imports System.Net.Http
Imports System.Xml.Serialization


Public Class RootSaveClass

    Public Function CreateHistoryDataset() As DataSet

        ''Creates datatable for transactions with columns and sets them to read only so user cannot change values

        TransactionDataTable.Columns.Add("TransactionID") : TransactionDataTable.Columns("TransactionID").ReadOnly = True
        TransactionDataTable.Columns.Add("Code") : TransactionDataTable.Columns("Code").ReadOnly = True
        TransactionDataTable.Columns.Add("CompanyName") : TransactionDataTable.Columns("CompanyName").ReadOnly = True
        TransactionDataTable.Columns.Add("Value") : TransactionDataTable.Columns("Value").ReadOnly = True
        TransactionDataTable.Columns.Add("Number of Shares") : TransactionDataTable.Columns("Number of Shares").ReadOnly = True
        TransactionDataTable.Columns.Add("Buy or Sell?") : TransactionDataTable.Columns("Buy or Sell?").ReadOnly = True
        TransactionDataTable.Columns.Add("Amount") : TransactionDataTable.Columns("Amount").ReadOnly = True
        TransactionDataTable.Columns.Add("Final Balance") : TransactionDataTable.Columns("Final Balance").ReadOnly = True
        TransactionDataTable.Columns.Add("DateTime of Transaction") : TransactionDataTable.Columns("DateTime of Transaction").ReadOnly = True

        AllTransactions.Tables.Add(TransactionDataTable) ''Adds data table to dataset

        Return AllTransactions
    End Function

    Public Function CreatePurchaseDataColumns() As DataSet

        ''Creates Dataset for purchases and populates it with datatable with columns for purchases

        Dim AllPurchases As New DataSet("AllPurchases")
        Dim PurchasesDataTable As New DataTable("Purchases")
        PurchasesDataTable.Columns.Add("Code")
        PurchasesDataTable.Columns.Add("Number of Stocks")
        PurchasesDataTable.Columns.Add("Purchase Rate")
        AllPurchases.Tables.Add(PurchasesDataTable)
        Return AllPurchases

    End Function

    Public Function CreateRecordsColumns() As DataSet

        ''Creates Dataset for records and populates it with datatable with columns for records

        Dim AllRecords As New DataSet("AllRecords")
        Dim Record As New DataTable("Record")
        Record.Columns.Add("Biggest Profit")
        Record.Columns.Add("Biggest Loss")
        Record.Columns.Add("Longest Session")
        Record.Columns.Add("Shortest Session")
        Record.Columns.Add("Total Money Made")
        Record.Columns.Add("Total Money Lost")

        AllRecords.Tables.Add(Record)

        Return AllRecords

    End Function

    Public Sub SaveToXMLFile(filename As String, d As DataSet) ''Saves input data to XML file that is stored in a sub folder


        Dim ser As XmlSerializer = New XmlSerializer(GetType(DataSet))

        Dim writer As TextWriter = New StreamWriter(filename)
        ser.Serialize(writer, d)

        writer.Close()

    End Sub

    Public Sub LoadFromXMLfile(filename As String) ''Loads purchases from XML

        If System.IO.File.Exists(filename) Then
            Dim xmlSerializer As XmlSerializer = New XmlSerializer(SaveData.GetType)
            Dim readStream As FileStream = New FileStream(filename, FileMode.Open)
            SaveData = CType(xmlSerializer.Deserialize(readStream), DataSet)
            readStream.Close()
        End If

    End Sub

    Public Sub LoadFromRecordsXMLfile(filename As String) ''Loads record data from XML

        If System.IO.File.Exists(filename) Then
            Dim xmlSerializer As XmlSerializer = New XmlSerializer(RecordsData.GetType)
            Dim readStream As FileStream = New FileStream(filename, FileMode.Open)
            RecordsData = CType(xmlSerializer.Deserialize(readStream), DataSet)
            readStream.Close()

            ''Allocates table values to variables

            BiggestProfit = RecordsData.Tables("Record").Rows(0)(0).ToString
            BiggestLoss = RecordsData.Tables("Record").Rows(0)(1).ToString
            LTS = RecordsData.Tables("Record").Rows(0)(2).ToString
            STS = RecordsData.Tables("Record").Rows(0)(3).ToString
            TotalMoneyMade = RecordsData.Tables("Record").Rows(0)(4).ToString
            TotalMoneyLost = RecordsData.Tables("Record").Rows(0)(5).ToString
        End If


    End Sub

    Public Sub LoadFromHistoryXMLfile(filename As String) ''Loads history data from XML

        If System.IO.File.Exists(filename) Then
            Dim xmlSerializer As XmlSerializer = New XmlSerializer(HistoryData.GetType)
            Dim readStream As FileStream = New FileStream(filename, FileMode.Open)
            HistoryData = CType(xmlSerializer.Deserialize(readStream), DataSet)
            readStream.Close()

            ''Declare TransactionID as last ID used in previous run of the program

            Dim row As Integer = HistoryData.Tables("Transaction").Rows.Count
            TransactionID = HistoryData.Tables("Transaction").Rows(row - 1)(0) + 1
        End If

    End Sub

    Public Sub AddToHistoryData(Content As DataSet)

        If BOS = 1 Then ''In case of sell flag

            ''Adds every selling transaction
            Content.Tables("Transaction").Rows.Add(TransactionID, AllStockInfo(StockInfoIndex, Code), AllStockInfo(StockInfoIndex, CompName),
                                      AllStockInfo(StockInfoIndex, CurrValue), SellNumber, "Sell",
                                      TotalSellPrice, UserBalance, DateTime.Now)



        ElseIf BOS = 2 Then ''In case of buy flag

            ''Adds every buying transaction
            Content.Tables("Transaction").Rows.Add(TransactionID, AllStockInfo(StockInfoIndex, Code), AllStockInfo(StockInfoIndex, CompName),
                                      AllStockInfo(StockInfoIndex, CurrValue), BuyNumber, "Buy",
                                      TotalBuyPrice, UserBalance, DateTime.Now)

        End If

        ''Increment TransactionID
        TransactionID += 1

    End Sub

    Public Sub AddToSaveData(Place As DataSet)

        ''Adds purchase details to purchases data table
        Place.Tables("Purchases").Rows.Add(AllStockInfo(StockInfoIndex, Code), BuyNumber, TotalBuyPrice)

    End Sub

    Public Sub AddToRecordData(Holder As DataSet)

        ''Adds record details to records data table     
        Holder.Tables("Record").Clear()
        Holder.Tables("Record").Rows.Add(BiggestProfit, BiggestLoss, LongTradingSess, ShortTradingSess, TotalMoneyMade, TotalMoneyLost)

    End Sub
End Class
