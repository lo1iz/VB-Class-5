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
        Me.PictureBoxCard = New System.Windows.Forms.PictureBox()
        Me.rdCard1 = New System.Windows.Forms.RadioButton()
        Me.rdCard2 = New System.Windows.Forms.RadioButton()
        Me.rdCard3 = New System.Windows.Forms.RadioButton()
        Me.rdCard4 = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBoxCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxCard
        '
        Me.PictureBoxCard.Location = New System.Drawing.Point(29, 33)
        Me.PictureBoxCard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBoxCard.Name = "PictureBoxCard"
        Me.PictureBoxCard.Size = New System.Drawing.Size(170, 217)
        Me.PictureBoxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCard.TabIndex = 0
        Me.PictureBoxCard.TabStop = False
        '
        'rdCard1
        '
        Me.rdCard1.AutoSize = True
        Me.rdCard1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCard1.Location = New System.Drawing.Point(219, 33)
        Me.rdCard1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdCard1.Name = "rdCard1"
        Me.rdCard1.Size = New System.Drawing.Size(85, 24)
        Me.rdCard1.TabIndex = 1
        Me.rdCard1.TabStop = True
        Me.rdCard1.Text = "ไพ่โพธิ์ดำ"
        Me.rdCard1.UseVisualStyleBackColor = True
        '
        'rdCard2
        '
        Me.rdCard2.AutoSize = True
        Me.rdCard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCard2.Location = New System.Drawing.Point(219, 70)
        Me.rdCard2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdCard2.Name = "rdCard2"
        Me.rdCard2.Size = New System.Drawing.Size(94, 24)
        Me.rdCard2.TabIndex = 2
        Me.rdCard2.TabStop = True
        Me.rdCard2.Text = "ไพ่โพธิ์แดง"
        Me.rdCard2.UseVisualStyleBackColor = True
        '
        'rdCard3
        '
        Me.rdCard3.AutoSize = True
        Me.rdCard3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCard3.Location = New System.Drawing.Point(219, 109)
        Me.rdCard3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdCard3.Name = "rdCard3"
        Me.rdCard3.Size = New System.Drawing.Size(87, 24)
        Me.rdCard3.TabIndex = 3
        Me.rdCard3.TabStop = True
        Me.rdCard3.Text = "ไพ่ดอกจิก"
        Me.rdCard3.UseVisualStyleBackColor = True
        '
        'rdCard4
        '
        Me.rdCard4.AutoSize = True
        Me.rdCard4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCard4.Location = New System.Drawing.Point(219, 146)
        Me.rdCard4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdCard4.Name = "rdCard4"
        Me.rdCard4.Size = New System.Drawing.Size(119, 24)
        Me.rdCard4.TabIndex = 4
        Me.rdCard4.TabStop = True
        Me.rdCard4.Text = "ไพ่ข้าวหลามตัด"
        Me.rdCard4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 280)
        Me.Controls.Add(Me.rdCard4)
        Me.Controls.Add(Me.rdCard3)
        Me.Controls.Add(Me.rdCard2)
        Me.Controls.Add(Me.rdCard1)
        Me.Controls.Add(Me.PictureBoxCard)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBoxCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxCard As PictureBox
    Friend WithEvents rdCard1 As RadioButton
    Friend WithEvents rdCard2 As RadioButton
    Friend WithEvents rdCard3 As RadioButton
    Friend WithEvents rdCard4 As RadioButton
End Class
