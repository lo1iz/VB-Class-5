<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.TextBoxItem = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckedListBox
        '
        Me.CheckedListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox.FormattingEnabled = True
        Me.CheckedListBox.Location = New System.Drawing.Point(185, 24)
        Me.CheckedListBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckedListBox.Name = "CheckedListBox"
        Me.CheckedListBox.Size = New System.Drawing.Size(205, 130)
        Me.CheckedListBox.TabIndex = 0
        '
        'TextBoxItem
        '
        Me.TextBoxItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxItem.Location = New System.Drawing.Point(18, 24)
        Me.TextBoxItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxItem.Name = "TextBoxItem"
        Me.TextBoxItem.Size = New System.Drawing.Size(149, 26)
        Me.TextBoxItem.TabIndex = 1
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(18, 60)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(68, 33)
        Me.ButtonAdd.TabIndex = 2
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(98, 60)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(68, 33)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 195)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxItem)
        Me.Controls.Add(Me.CheckedListBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckedListBox As CheckedListBox
    Friend WithEvents TextBoxItem As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonDelete As Button
End Class
