Public Class Config

    Private ConfigXml As Xml.XmlDocument = Nothing

    Private _Config As String = ""
    Public Property Config() As String
        Get
            Return _Config
        End Get
        Set(ByVal value As String)
            _Config = value
            ConfigXml.Load(value)
        End Set
    End Property

#Region "Konstruktor"

    Public Sub New()
    End Sub

    Public Sub New(ByVal pConfig As String)
        Me.Config = pConfig
    End Sub

#End Region

#Region "Methoden"

    Public Sub SetStammverzeichnisRoot(ByVal pPath As String)

    End Sub

    Public Function GetStammverzeichnisRoot() As String
        Return ""
    End Function

    Public Sub SetDataBasePath(ByVal pPath As String)

    End Sub

    Public Function GetDataBasePath() As String
        Return ""
    End Function



#End Region

End Class
