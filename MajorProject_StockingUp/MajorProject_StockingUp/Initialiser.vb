Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Sheets.v4
Imports Google.Apis.Sheets.v4.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Threading
Imports System.Net.Http
Imports LiveCharts.Wpf
Imports System.Windows.Forms
Imports System.Collections

Public Module GlobalVariables
    Public AllStockInfo(199, 11) As String
    Public AllStockValues(200, 20) As String
    Public PurchaseIndex, InfoElement, SeriesCheck, StockInfoIndex, AllInfoIndex, SellCheck, BOS, TransactionID, WidthCounter As Integer
    Public ProfitLossString As String
    Public MaxCounter As Integer

    Public AllTransactions As New DataSet("AllTransactions")
    Public TransactionDataTable As New DataTable("Transaction")
    Public SaveData As DataSet
    Public UserBalanceData As DataSet
    Public HistoryData As DataSet
    Public RecordsData As DataSet

    Public watch As Stopwatch

    Public UserBalance As Double
    Public BiggestProfit, BiggestLoss As Double
    Public TotalMoneyMade, TotalMoneyLost As Double

    Public LTS, STS As String

    Public LongTradingSess, ShortTradingSess As TimeSpan
    Public BuyNumber, SellNumber As Integer

    Public TotalBuyPrice, TotalSellPrice As Double

    Public ID, Code, CompName, Industry, CurrValue, YestValue, Delta, PercentDelta, YearHigh, YearLow, MarketCap, TimeUpdate As Integer
    Public Link As New SheetsQuickstart.Program
    Public Saves As New RootSaveClass

    Public X, Y As Integer
    Public StockEntry1, StockEntry2, StockEntry3, StockEntry4, StockEntry5 As New LineSeries

    Public XResList As New List(Of Integer)
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public C1, C2, C3, C4, C5 As Color
    Public cDialog As New ColorDialog()

End Module

Namespace SheetsQuickstart



    Public Class Program

        '''''''''''''''''''''''''''''''''''''''''''''''''''API BEGINS HERE'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Shared Scopes As String() = {SheetsService.Scope.SpreadsheetsReadonly} ''Only reads from the spreadsheet
        Shared ApplicationName As String = "Google Sheets API .NET Quickstart"

        Public Shared Sub Main()

            ''These numbers help me identify key information when I need it

            ID = 0
            Code = 1
            CompName = 2
            Industry = 3
            CurrValue = 4
            YestValue = 5
            Delta = 6
            PercentDelta = 7
            YearHigh = 8
            YearLow = 9
            MarketCap = 10
            TimeUpdate = 11

            ''Authorising API Credentials'

            Dim Credential As UserCredential

            Using Stream = New FileStream("client_secret.json", FileMode.Open, FileAccess.Read)
                Dim CredPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal)
                CredPath = Path.Combine(CredPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json")

                Credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(Stream).Secrets, Scopes, "user", CancellationToken.None, New FileDataStore(CredPath, True)).Result
                Console.WriteLine(Convert.ToString("Credential file saved to: ") & CredPath)
            End Using

            ''Finished Authorising API Credentials'

            ''Create Google Sheets API Service.

            Dim Service = New SheetsService(New BaseClientService.Initializer() With {
                .HttpClientInitializer = Credential,
                .ApplicationName = ApplicationName
            })

            ''Define Request parameters.

            ''This section is for the stock details (e.g. Company Name, Market Capital etc.)

            Dim SpreadsheetId As [String] = "1GHbj-0hun8pe1i-N8pIX7qS7bygCN7GAzB-9XgSFKRU"
            Dim Range As [String] = "Sheet1!A2:L"
            Dim Request As SpreadsheetsResource.ValuesResource.GetRequest = Service.Spreadsheets.Values.[Get](SpreadsheetId, Range)

            Dim Response As ValueRange = Request.Execute()
            Dim Values As IList(Of IList(Of [Object])) = Response.Values
            If Values IsNot Nothing AndAlso Values.Count > 0 Then
                For Each Row As IList In Values ''Loops through each row of Spreadsheet
                    For InfoElement = 0 To 11
                        AllStockInfo(AllInfoIndex, InfoElement) = Row(InfoElement) ''For each cell in each row, value is added to the array
                    Next
                    AllInfoIndex += 1 ''Simulates new row in array
                Next
                AllInfoIndex = 0
                InfoElement = 0
            Else
                MsgBox("No data found. Please reboot the program. If this issue persists, please restart the program, or check your internet connection")
            End If

            ''This section is for stock values from the last 19 hours

            Dim Sheet2Range As [String] = "Sheet1!N2:AF" ''Defines new request range
            Dim RequestSheet2 As SpreadsheetsResource.ValuesResource.GetRequest = Service.Spreadsheets.Values.[Get](SpreadsheetId, Sheet2Range)
            Dim ResponseSheet2 As ValueRange = RequestSheet2.Execute()
            Dim Sheet2Values As IList(Of IList(Of [Object])) = ResponseSheet2.Values
            If Sheet2Values IsNot Nothing AndAlso Sheet2Values.Count > 0 Then
                For Each Row As IList In Sheet2Values ''Loops through each row of Spreadsheet
                    For InfoElement = 0 To 18
                        AllStockValues(AllInfoIndex, InfoElement) = Row(InfoElement) ''For each cell in each row, value is added to the array
                    Next
                    AllInfoIndex += 1 ''Simulates new row in array
                Next
                AllInfoIndex = 0
                InfoElement = 0
            Else
                MsgBox("No data found. Please reboot the program. If this issue persists, please restart the program, or check your internet connection")
            End If

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''API ENDS HERE'''''''''''''''''''''''''''''''''''''''''''''''''''''''

            SaveData = Saves.CreatePurchaseDataColumns() ''Creates save data table with empty columns and rows

            RecordsData = Saves.CreateRecordsColumns() ''Creates records data table with empty columns and rows

            HistoryData = Saves.CreateHistoryDataset() ''Creates history data table with empty columns and rows

            Saves.LoadFromXMLfile(Path.Combine(Directory.GetCurrentDirectory(), "SaveData/savefile.xml")) ''Populates save data table with previously stored data in XML file
            Saves.LoadFromRecordsXMLfile(Path.Combine(Directory.GetCurrentDirectory(), "SaveData/records.xml")) ''Populates records data table with previously stored data in XML file
            Saves.LoadFromHistoryXMLfile(Path.Combine(Directory.GetCurrentDirectory(), "SaveData/transactions.xml")) ''Populates transactions data table with previously stored data in XML file
            UserBalance = My.Settings.UserBalance ''Sets the userbalance to their balance when they last left the program

            Home.Show() ''Shows home screen form

        End Sub
    End Class
End Namespace