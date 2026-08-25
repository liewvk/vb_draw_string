<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        picBox = New PictureBox()
        btnDrawText = New Button()
        btnClear = New Button()
        CType(picBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picBox
        ' 
        picBox.Location = New Point(91, 48)
        picBox.Name = "picBox"
        picBox.Size = New Size(597, 337)
        picBox.TabIndex = 0
        picBox.TabStop = False
        ' 
        ' btnDrawText
        ' 
        btnDrawText.Location = New Point(177, 402)
        btnDrawText.Name = "btnDrawText"
        btnDrawText.Size = New Size(157, 36)
        btnDrawText.TabIndex = 1
        btnDrawText.Text = "Draw Text"
        btnDrawText.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(405, 402)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(157, 36)
        btnClear.TabIndex = 1
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(btnDrawText)
        Controls.Add(picBox)
        Name = "Form1"
        Text = "Form1"
        CType(picBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents picBox As PictureBox
    Friend WithEvents btnDrawText As Button
    Friend WithEvents btnClear As Button

End Class
