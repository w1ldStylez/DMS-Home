Imports System.IO

Public Class frmAblage


    Private _Filename As String
    Public Property Filename() As String
        Get
            Return _Filename
        End Get
        Set(ByVal value As String)
            _Filename = value
        End Set
    End Property


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        InsertDocIntoDatabase(txtTitel.Text, txtBemerkung.Text, txtTags.Text, dtpDate.Text, CStr(cboCategories.SelectedItem))
    End Sub

    ''' <summary>
    ''' Methode zum einfügen eines Dokuments in die Datenbank.
    ''' </summary>
    ''' <returns>Gibt einen Wahrheitswert zurück.</returns>
    ''' <remarks></remarks>
    Public Function InsertDocIntoDatabase(ByVal pTitle As String, ByVal pBemerkung As String, ByVal pTags As String, ByVal pDatum As String, ByVal pKategorie As String) As Boolean
        Dim objConnection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\Entwicklung\Vb.net\PRIV\DMS-Home\DMS-Home\DMS-Home\bin\Debug\DB\Data.mdb;")

        Dim strTmp As String = Guid.NewGuid.ToString
        Dim strPath As String = "d:\Entwicklung\Vb.net\PRIV\DMS-Home\DMS-Home\DMS-Home\bin\Debug\FILES\" + "\" + strTmp + ".dat"
        Dim strOrig As String = _Filename.Split("\"c)(_Filename.Split("\"c).Length - 1)

        File.Copy(_Filename, strPath)

        Try
            Dim strSqlCat As String = String.Format("SELECT ID FROM CATEGORIES WHERE KATEGORIE = '{0}'", pKategorie)
            Dim objAdapter As New OleDb.OleDbDataAdapter(strSqlCat, objConnection)
            Dim objDatatable As New DataTable
            objAdapter.Fill(objDatatable)

            Dim strSql As String = ("INSERT INTO Documents ([Path],[OriginalName],[Extension],[Size],[Title],[Bemerkung],[Tags],[Date],[KategorieID] )VALUES(@Path,@OriginalName,@Extension,@Size,@Titel,@Bemerkung,@Tags,@Date,@KategorieID);")
            Dim objCommand As New System.Data.OleDb.OleDbCommand(strSql, objConnection)

            objCommand.Parameters.Add("@Path", System.Data.OleDb.OleDbType.VarChar).Value = strPath
            objCommand.Parameters.Add("@OriginalName", System.Data.OleDb.OleDbType.VarChar).Value = strOrig
            objCommand.Parameters.Add("@Extension", System.Data.OleDb.OleDbType.VarChar).Value = Path.GetExtension(_Filename)
            objCommand.Parameters.Add("@Size", System.Data.OleDb.OleDbType.Integer).Value = New FileInfo(_Filename).Length      ' Bytes
            objCommand.Parameters.Add("@Titel", System.Data.OleDb.OleDbType.VarChar).Value = pTitle
            objCommand.Parameters.Add("@Bemerkung", System.Data.OleDb.OleDbType.VarChar).Value = pBemerkung
            objCommand.Parameters.Add("@Tags", System.Data.OleDb.OleDbType.VarChar).Value = pTags
            objCommand.Parameters.Add("@Date", System.Data.OleDb.OleDbType.Date).Value = CDate(pDatum).Date
            objCommand.Parameters.Add("@KategorieID", System.Data.OleDb.OleDbType.Integer).Value = CInt(objDatatable.Rows(0).Item("ID"))

            objConnection.Open()
            objCommand.ExecuteNonQuery()
            objConnection.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub frmAblage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objConnection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\Entwicklung\Vb.net\PRIV\DMS-Home\DMS-Home\DMS-Home\bin\Debug\DB\Data.mdb;")
        Dim objDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM CATEGORIES", objConnection)
        Dim objDatatable As New DataTable
        objDataAdapter.Fill(objDatatable)
        For Each oRow As DataRow In objDatatable.Rows
            cboCategories.Items.Add(oRow.Item("Kategorie"))
        Next

        cboCategories.SelectedItem = "-Alle-"
    End Sub
End Class