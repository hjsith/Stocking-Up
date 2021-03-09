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

Public Class Home

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