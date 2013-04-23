<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAblage
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTitel = New System.Windows.Forms.TextBox()
        Me.txtBemerkung = New System.Windows.Forms.TextBox()
        Me.txtTags = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboCategories = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtTitel
        '
        Me.txtTitel.Location = New System.Drawing.Point(97, 143)
        Me.txtTitel.Name = "txtTitel"
        Me.txtTitel.Size = New System.Drawing.Size(100, 20)
        Me.txtTitel.TabIndex = 0
        '
        'txtBemerkung
        '
        Me.txtBemerkung.Location = New System.Drawing.Point(97, 187)
        Me.txtBemerkung.Name = "txtBemerkung"
        Me.txtBemerkung.Size = New System.Drawing.Size(100, 20)
        Me.txtBemerkung.TabIndex = 1
        '
        'txtTags
        '
        Me.txtTags.Location = New System.Drawing.Point(97, 224)
        Me.txtTags.Multiline = True
        Me.txtTags.Name = "txtTags"
        Me.txtTags.Size = New System.Drawing.Size(184, 68)
        Me.txtTags.TabIndex = 2
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(107, 80)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(97, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboCategories
        '
        Me.cboCategories.FormattingEnabled = True
        Me.cboCategories.Location = New System.Drawing.Point(107, 107)
        Me.cboCategories.Name = "cboCategories"
        Me.cboCategories.Size = New System.Drawing.Size(298, 21)
        Me.cboCategories.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 428)
        Me.Controls.Add(Me.cboCategories)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtTags)
        Me.Controls.Add(Me.txtBemerkung)
        Me.Controls.Add(Me.txtTitel)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitel As System.Windows.Forms.TextBox
    Friend WithEvents txtBemerkung As System.Windows.Forms.TextBox
    Friend WithEvents txtTags As System.Windows.Forms.TextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboCategories As System.Windows.Forms.ComboBox
End Class
