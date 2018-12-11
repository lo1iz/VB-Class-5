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
        Me.Numeric = New System.Windows.Forms.NumericUpDown()
        Me.LabelNumeric = New System.Windows.Forms.Label()
        CType(Me.Numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Numeric
        '
        Me.Numeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numeric.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Numeric.Location = New System.Drawing.Point(20, 25)
        Me.Numeric.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Numeric.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Numeric.Name = "Numeric"
        Me.Numeric.Size = New System.Drawing.Size(83, 26)
        Me.Numeric.TabIndex = 0
        Me.Numeric.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'LabelNumeric
        '
        Me.LabelNumeric.BackColor = System.Drawing.SystemColors.Info
        Me.LabelNumeric.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeric.ForeColor = System.Drawing.Color.Tomato
        Me.LabelNumeric.Location = New System.Drawing.Point(130, 25)
        Me.LabelNumeric.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNumeric.Name = "LabelNumeric"
        Me.LabelNumeric.Size = New System.Drawing.Size(198, 197)
        Me.LabelNumeric.TabIndex = 1
        Me.LabelNumeric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 250)
        Me.Controls.Add(Me.LabelNumeric)
        Me.Controls.Add(Me.Numeric)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Numeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Numeric As NumericUpDown
    Friend WithEvents LabelNumeric As Label
End Class
