<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picCard = New System.Windows.Forms.PictureBox()
        Me.rdSpade = New System.Windows.Forms.RadioButton()
        Me.rdHeart = New System.Windows.Forms.RadioButton()
        Me.rdClub = New System.Windows.Forms.RadioButton()
        Me.rdDiamond = New System.Windows.Forms.RadioButton()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCard
        '
        Me.picCard.Image = Global.workshop503.My.Resources.Resources.back
        Me.picCard.Location = New System.Drawing.Point(52, 47)
        Me.picCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picCard.Name = "picCard"
        Me.picCard.Size = New System.Drawing.Size(257, 330)
        Me.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCard.TabIndex = 0
        Me.picCard.TabStop = False
        '
        'rdSpade
        '
        Me.rdSpade.AutoSize = True
        Me.rdSpade.Location = New System.Drawing.Point(377, 64)
        Me.rdSpade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdSpade.Name = "rdSpade"
        Me.rdSpade.Size = New System.Drawing.Size(70, 21)
        Me.rdSpade.TabIndex = 1
        Me.rdSpade.TabStop = True
        Me.rdSpade.Text = "Spade"
        Me.rdSpade.UseVisualStyleBackColor = True
        '
        'rdHeart
        '
        Me.rdHeart.AutoSize = True
        Me.rdHeart.Location = New System.Drawing.Point(377, 117)
        Me.rdHeart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdHeart.Name = "rdHeart"
        Me.rdHeart.Size = New System.Drawing.Size(64, 21)
        Me.rdHeart.TabIndex = 2
        Me.rdHeart.TabStop = True
        Me.rdHeart.Text = "Heart"
        Me.rdHeart.UseVisualStyleBackColor = True
        '
        'rdClub
        '
        Me.rdClub.AutoSize = True
        Me.rdClub.Location = New System.Drawing.Point(377, 169)
        Me.rdClub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdClub.Name = "rdClub"
        Me.rdClub.Size = New System.Drawing.Size(57, 21)
        Me.rdClub.TabIndex = 3
        Me.rdClub.TabStop = True
        Me.rdClub.Text = "Club"
        Me.rdClub.UseVisualStyleBackColor = True
        '
        'rdDiamond
        '
        Me.rdDiamond.AutoSize = True
        Me.rdDiamond.Location = New System.Drawing.Point(377, 220)
        Me.rdDiamond.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdDiamond.Name = "rdDiamond"
        Me.rdDiamond.Size = New System.Drawing.Size(85, 21)
        Me.rdDiamond.TabIndex = 4
        Me.rdDiamond.TabStop = True
        Me.rdDiamond.Text = "Diamond"
        Me.rdDiamond.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(52, 427)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(200, 49)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnAnswer
        '
        Me.btnAnswer.Enabled = False
        Me.btnAnswer.Location = New System.Drawing.Point(301, 427)
        Me.btnAnswer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(200, 49)
        Me.btnAnswer.TabIndex = 6
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 514)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.rdDiamond)
        Me.Controls.Add(Me.rdClub)
        Me.Controls.Add(Me.rdHeart)
        Me.Controls.Add(Me.rdSpade)
        Me.Controls.Add(Me.picCard)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Guess The Card"
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCard As PictureBox
    Friend WithEvents rdSpade As RadioButton
    Friend WithEvents rdHeart As RadioButton
    Friend WithEvents rdClub As RadioButton
    Friend WithEvents rdDiamond As RadioButton
    Friend WithEvents btnStart As Button
    Friend WithEvents btnAnswer As Button
End Class