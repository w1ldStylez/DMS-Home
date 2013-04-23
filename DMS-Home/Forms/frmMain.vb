Imports System.IO

Public Class frmMain

#Region "Properties"

#End Region

#Region "Methods"

    Public Sub ShowTree(ByVal pPath As String)
        tvDocuments.Nodes.Clear()
        Dim nNode As New TreeNode(pPath)
        tvDocuments.Nodes.Add(nNode)
        nNode.StateImageIndex = 0
        Me.FillTreeNode(nNode)
    End Sub

    Private Sub FillTreeNode(ByVal dNode As TreeNode)
        Try
            Dim dirInfo As New DirectoryInfo(dNode.FullPath)
            For Each dInfo As DirectoryInfo In dirInfo.GetDirectories
                Dim nNode As New TreeNode(dInfo.Name)
                dNode.Nodes.Add(nNode)
                ' nNode.StateImageIndex = 1
                FillTreeNode(nNode)
            Next
            For Each filInfo As FileInfo In dirInfo.GetFiles
                Dim fNode As New TreeNode(filInfo.Name)
                dNode.Nodes.Add(fNode)
            Next
        Catch : End Try
    End Sub

#End Region

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objConnection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\Entwicklung\Vb.net\PRIV\DMS-Home\DMS-Home\DMS-Home\bin\Debug\DB\Data.mdb;")
        Dim objDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM CATEGORIES", objConnection)
        Dim objDatatable As New DataTable
        objDataAdapter.Fill(objDatatable)
        For Each oRow As DataRow In objDatatable.Rows
            cboCategories.Items.Add(oRow.Item("Kategorie"))
        Next

        cboCategories.SelectedItem = "-Alle-"

        ShowTree("d:\Entwicklung\Bilder\")
    End Sub

    Private Sub tvDocuments_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvDocuments.NodeMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuAblage.Show(Cursor.Position.X, Cursor.Position.Y)
        End If
    End Sub

    Private Sub AblegenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AblegenToolStripMenuItem.Click
        Dim frm2 As New frmAblage
        frm2.Filename = tvDocuments.SelectedNode.FullPath
        frm2.ShowDialog()

    End Sub

    Private Sub cboCategories_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategories.SelectedIndexChanged
        dgvDocuments.Rows.Clear()

        If Not cboCategories.SelectedItem.ToString = "-Alle-" Then
            Dim objConnection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\Entwicklung\Vb.net\PRIV\DMS-Home\DMS-Home\DMS-Home\bin\Debug\DB\Data.mdb;")
            Dim objDataAdapter As New System.Data.OleDb.OleDbDataAdapter(String.Format("SELECT ID FROM CATEGORIES WHERE Kategorie = '{0}'", cboCategories.SelectedItem), objConnection)
            Dim objDatatable As New DataTable
            objDataAdapter.Fill(objDatatable)

            objDataAdapter = New OleDb.OleDbDataAdapter("SELECT * FROM DOCUMENTS WHERE KategorieID = " + CStr(objDatatable.Rows(0).Item("ID")), objConnection)
            Dim odata As New DataTable
            objDataAdapter.Fill(odata)

            For Each oRow As DataRow In odata.Rows
                dgvDocuments.Rows.Add(oRow("id"), oRow("path"), oRow("kategorieid"), oRow("extension"), oRow("size"), oRow("title"), oRow("Bemerkung"), oRow("Tags"), oRow("date"))
            Next
        Else
            Dim objConnection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\Entwicklung\Vb.net\PRIV\DMS-Home\DMS-Home\DMS-Home\bin\Debug\DB\Data.mdb;")
            Dim objDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM DOCUMENTS", objConnection)

            Dim objtable = New DataTable()
            objDataAdapter.Fill(objtable)

            For Each oRow As DataRow In objtable.Rows
                dgvDocuments.Rows.Add(oRow("id"), oRow("path"), oRow("kategorieid"), oRow("extension"), oRow("size"), oRow("title"), oRow("Bemerkung"), oRow("Tags"), oRow("date"))
            Next
        End If
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged
        If TabControl.SelectedTab.Name = "TabPageAblage" Then
            btnAnzeigen.Enabled = True
            btnExport.Enabled = False
            btnAendern.Enabled = False
            btnAblegen.Enabled = True
            brnEntfernen.Enabled = False
        Else
            btnAnzeigen.Enabled = True
            btnAendern.Enabled = True
            btnExport.Enabled = True
            btnAblegen.Enabled = False
            brnEntfernen.Enabled = True
        End If
    End Sub

    Private Sub btnAendern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAendern.Click
        If dgvDocuments.SelectedRows.Count > 1 Then
            Dim objResult = MsgBox("Wollen Sie wirklich mehr als ein Dokument bearbeiten?", MsgBoxStyle.OkCancel, "Achtung!")
            If objResult = MsgBoxResult.Ok Then
                For Each oRow As DataGridViewRow In dgvDocuments.SelectedRows
                    Dim frmEdit As New frmDocumentEdit
                    frmEdit.DocID = CStr(oRow.Cells("ColumnID").Value)
                    frmEdit.Show()
                Next
            End If
        Else
            Dim frmEdit As New frmDocumentEdit
            frmEdit.DocID = CStr(dgvDocuments.SelectedRows(0).Cells("ColumnID").Value)
            frmEdit.ShowDialog()
        End If
    End Sub
End Class
