Imports DevExpress.XtraMap
Imports System
Imports System.Windows.Forms

Namespace MapErrorEvent
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim imageLayer As New ImageLayer()
            mapControl1.Layers.Add(imageLayer)
            Dim provider As New WmsDataProvider()
            imageLayer.DataProvider = provider
            provider.ServerUri = "http://YOUR_SERVER_URI"
            provider.ActiveLayerName = "ACTIVE_LAYER_NAME"
            AddHandler imageLayer.Error, AddressOf OnError
        End Sub
        Private Sub OnError(ByVal sender As Object, ByVal e As MapErrorEventArgs)
            MessageBox.Show(e.Exception.Message)
        End Sub
    End Class
End Namespace
