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
        Me.DayUpDown = New System.Windows.Forms.DomainUpDown()
        Me.LabelDay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DayUpDown
        '
        Me.DayUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayUpDown.Items.Add("จันทร์")
        Me.DayUpDown.Items.Add("อังคาร")
        Me.DayUpDown.Items.Add("พุธ")
        Me.DayUpDown.Items.Add("พฤหัสบดี")
        Me.DayUpDown.Items.Add("ศุกร์")
        Me.DayUpDown.Items.Add("เสาร์")
        Me.DayUpDown.Items.Add("อาทิตย์")
        Me.DayUpDown.Location = New System.Drawing.Point(25, 28)
        Me.DayUpDown.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DayUpDown.Name = "DayUpDown"
        Me.DayUpDown.Size = New System.Drawing.Size(222, 29)
        Me.DayUpDown.TabIndex = 0
        '
        'LabelDay
        '
        Me.LabelDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDay.ForeColor = System.Drawing.Color.LightCoral
        Me.LabelDay.Location = New System.Drawing.Point(25, 80)
        Me.LabelDay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDay.Name = "LabelDay"
        Me.LabelDay.Size = New System.Drawing.Size(222, 49)
        Me.LabelDay.TabIndex = 1
        Me.LabelDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 158)
        Me.Controls.Add(Me.LabelDay)
        Me.Controls.Add(Me.DayUpDown)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DayUpDown As DomainUpDown
    Friend WithEvents LabelDay As Label
End Class
