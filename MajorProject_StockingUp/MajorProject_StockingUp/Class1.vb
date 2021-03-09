Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Sheets.v4
Imports Google.Apis.Sheets.v4.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports System.IO
Imports System.Threading

Namespace SheetsQuickstart
    Public Class Values
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
            Dim range As [String] = "Sheet2!A2:U"
            Dim request As SpreadsheetsResource.ValuesResource.GetRequest = service.Spreadsheets.Values.[Get](spreadsheetId, range)
            ' Prints the names and majors of students in a sample spreadsheet:
            ' https://docs.google.com/spreadsheets/d/1fsdXp17vGNnbWJi6kaoVt_qs8yJ6zQ3PjN_a5fqxMuM/edit
            Dim response As ValueRange = request.Execute()
            Dim values As IList(Of IList(Of [Object])) = response.Values
            If values IsNot Nothing AndAlso values.Count > 0 Then
                For Each row As IList In values
                    For d = 0 To 38
                        allstockvalues(c, d) = row(d + 3)
                    Next
                    Console.WriteLine("Here" & allstockvalues(c, d))
                    If c Mod 2 = 0 Then
                        c = c + 1
                    End If

                Next

            Else
                Console.WriteLine("No data found.")
            End If

            i = 0
            b = 0

        End Sub

    End Class
End Namespace