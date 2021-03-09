Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Sheets.v4
Imports Google.Apis.Sheets.v4.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports System.IO
Imports System.Threading
Imports System.Collections.Generic

Public Module GlobalVariables
    Public allstockdata(2243, 10) As String
    Public allstockvalues(4487, 39) As String
    Public i, b, c, d, e As Integer
    Public code, name, industry, cvalue, yvalue, delta, percentdelta, yearhigh, yearlow, marketcap, timeupdate As Integer
End Module

Namespace SheetsQuickstart
    Public Class Program
        Shared Scopes As String() = {SheetsService.Scope.SpreadsheetsReadonly}
        Shared ApplicationName As String = "Google Sheets API .NET Quickstart"
        Public Shared Sub Main()
            Dim credential As UserCredential

            Using stream = New FileStream("client_secret.json", FileMode.Open, FileAccess.Read)
                Dim credPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal)
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json")

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", CancellationToken.None, New FileDataStore(credPath, True)).Result
                Console.WriteLine(Convert.ToString("Credential file saved to: ") & credPath)
            End Using

            ' Create Google Sheets API service.
            Dim service = New SheetsService(New BaseClientService.Initializer() With {
                .HttpClientInitializer = credential,
                .ApplicationName = ApplicationName
            })

            ' Define request parameters.
            Dim spreadsheetId As [String] = "1fsdXp17vGNnbWJi6kaoVt_qs8yJ6zQ3PjN_a5fqxMuM"
            Dim range As [String] = "Sheet1!A2:L"
            Dim request As SpreadsheetsResource.ValuesResource.GetRequest = service.Spreadsheets.Values.[Get](spreadsheetId, range)
            code = 0
            name = 1
            industry = 2
            cvalue = 3
            yvalue = 4
            delta = 5
            percentdelta = 6
            yearhigh = 7
            yearlow = 8
            marketcap = 9
            timeupdate = 10
            ' Prints the names and majors of students in a sample spreadsheet:
            ' https://docs.google.com/spreadsheets/d/1fsdXp17vGNnbWJi6kaoVt_qs8yJ6zQ3PjN_a5fqxMuM/edit
            Dim response As ValueRange = request.Execute()
            Dim values As IList(Of IList(Of [Object])) = response.Values
            If values IsNot Nothing AndAlso values.Count > 0 Then
                For Each row As IList In values
                    For b = 0 To 10
                        allstockdata(i, b) = row(b)
                    Next
                    i = i + 1
                Next

            Else
                Console.WriteLine("No data found.")
            End If

            i = 0
            b = 0
            e = 2
            Dim service2 = New SheetsService(New BaseClientService.Initializer() With {
                .HttpClientInitializer = credential,
                .ApplicationName = ApplicationName
            })

            ' Define request parameters.
            Dim spreadsheetId As [String] = "1fsdXp17vGNnbWJi6kaoVt_qs8yJ6zQ3PjN_a5fqxMuM"
            Dim rangevalues As [String] = "Sheet2!A2:W"
            Dim request2 As SpreadsheetsResource.ValuesResource.GetRequest = service.Spreadsheets.Values.[Get](spreadsheetId, rangevalues)
            Dim response2 As ValueRange = request2.Execute()
            Dim values2 As IList(Of IList(Of [Object])) = response2.Values
            If values2 IsNot Nothing AndAlso values2.Count > 0 Then
                For Each price As IList In values2
                    For b = 0 To 17
                        allstockvalues(c, d) = price(e)
                        e += 1
                    Next
                    e = 0
                Next
            End If
        End Sub

    End Class
End Namespace