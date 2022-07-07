Imports DevExpress.Xpf.Docking
Imports DevExpress.Xpf.Layout.Core
Imports DevExpress.Xpf.Ribbon
Imports System.Windows.Controls

Namespace WpfApplication1

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DXRibbonWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub biMDI_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Me.ChildDocumentGroup.MDIStyle = MDIStyle.MDI
        End Sub

        Private Sub biTabbed_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Me.ChildDocumentGroup.MDIStyle = MDIStyle.Tabbed
        End Sub
    End Class
End Namespace
