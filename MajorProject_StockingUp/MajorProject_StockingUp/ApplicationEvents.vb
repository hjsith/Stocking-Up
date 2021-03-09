Imports System.IO
Imports System.Threading
Imports System.Collections.Generic
Imports System.Xml.Serialization
Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown

            watch.Stop() ''

            If LongTradingSess < watch.Elapsed Then
                LongTradingSess = watch.Elapsed
            End If

            If ShortTradingSess > watch.Elapsed Then
                ShortTradingSess = watch.Elapsed
            End If

            RecordsData = Saves.CreateRecordsColumns()
            Saves.AddToRecordData(RecordsData)
            Saves.SaveToXMLFile(Path.Combine(Directory.GetCurrentDirectory(), "SaveData/records.xml"), RecordsData)
            My.Settings.Save()
        End Sub
    End Class
End Namespace
