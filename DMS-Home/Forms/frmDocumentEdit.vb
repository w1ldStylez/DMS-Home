Public Class frmDocumentEdit

    Private _DocID As String
    Public Property DocID() As String
        Get
            Return _DocID
        End Get
        Set(ByVal value As String)
            _DocID = value
        End Set
    End Property


    Private Sub frmDocumentEdit_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub
End Class