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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdEqual = New System.Windows.Forms.Button()
        Me.cmdInverse = New System.Windows.Forms.Button()
        Me.cmdSqrt = New System.Windows.Forms.Button()
        Me.cmdPowerOf = New System.Windows.Forms.Button()
        Me.cmdAddition = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdSubstract = New System.Windows.Forms.Button()
        Me.cmdDivision = New System.Windows.Forms.Button()
        Me.cmdDecimal = New System.Windows.Forms.Button()
        Me.cmdSign = New System.Windows.Forms.Button()
        Me.cmd0 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.cmd9 = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.cmd7 = New System.Windows.Forms.Button()
        Me.cmdC = New System.Windows.Forms.Button()
        Me.cmdCE = New System.Windows.Forms.Button()
        Me.cmdBackspace = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtInput)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 100)
        Me.Panel1.TabIndex = 1
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(15, 17)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(275, 65)
        Me.txtInput.TabIndex = 0
        Me.txtInput.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdEqual)
        Me.Panel2.Controls.Add(Me.cmdInverse)
        Me.Panel2.Controls.Add(Me.cmdSqrt)
        Me.Panel2.Controls.Add(Me.cmdPowerOf)
        Me.Panel2.Controls.Add(Me.cmdAddition)
        Me.Panel2.Controls.Add(Me.cmdMultiply)
        Me.Panel2.Controls.Add(Me.cmdSubstract)
        Me.Panel2.Controls.Add(Me.cmdDivision)
        Me.Panel2.Controls.Add(Me.cmdDecimal)
        Me.Panel2.Controls.Add(Me.cmdSign)
        Me.Panel2.Controls.Add(Me.cmd0)
        Me.Panel2.Controls.Add(Me.cmd3)
        Me.Panel2.Controls.Add(Me.cmd2)
        Me.Panel2.Controls.Add(Me.cmd1)
        Me.Panel2.Controls.Add(Me.cmd6)
        Me.Panel2.Controls.Add(Me.cmd5)
        Me.Panel2.Controls.Add(Me.cmd4)
        Me.Panel2.Controls.Add(Me.cmd9)
        Me.Panel2.Controls.Add(Me.cmd8)
        Me.Panel2.Controls.Add(Me.cmd7)
        Me.Panel2.Controls.Add(Me.cmdC)
        Me.Panel2.Controls.Add(Me.cmdCE)
        Me.Panel2.Controls.Add(Me.cmdBackspace)
        Me.Panel2.Location = New System.Drawing.Point(12, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(305, 296)
        Me.Panel2.TabIndex = 2
        '
        'cmdEqual
        '
        Me.cmdEqual.Location = New System.Drawing.Point(244, 230)
        Me.cmdEqual.Name = "cmdEqual"
        Me.cmdEqual.Size = New System.Drawing.Size(46, 43)
        Me.cmdEqual.TabIndex = 22
        Me.cmdEqual.Text = "="
        Me.cmdEqual.UseVisualStyleBackColor = True
        '
        'cmdInverse
        '
        Me.cmdInverse.Location = New System.Drawing.Point(244, 179)
        Me.cmdInverse.Name = "cmdInverse"
        Me.cmdInverse.Size = New System.Drawing.Size(46, 44)
        Me.cmdInverse.TabIndex = 21
        Me.cmdInverse.Text = "1/x"
        Me.cmdInverse.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        Me.cmdSqrt.Location = New System.Drawing.Point(244, 129)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(46, 44)
        Me.cmdSqrt.TabIndex = 20
        Me.cmdSqrt.Text = "sqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'cmdPowerOf
        '
        Me.cmdPowerOf.Location = New System.Drawing.Point(244, 79)
        Me.cmdPowerOf.Name = "cmdPowerOf"
        Me.cmdPowerOf.Size = New System.Drawing.Size(46, 44)
        Me.cmdPowerOf.TabIndex = 19
        Me.cmdPowerOf.Text = "X^"
        Me.cmdPowerOf.UseVisualStyleBackColor = True
        '
        'cmdAddition
        '
        Me.cmdAddition.Location = New System.Drawing.Point(192, 230)
        Me.cmdAddition.Name = "cmdAddition"
        Me.cmdAddition.Size = New System.Drawing.Size(46, 43)
        Me.cmdAddition.TabIndex = 18
        Me.cmdAddition.Text = "+"
        Me.cmdAddition.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Location = New System.Drawing.Point(192, 129)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(46, 44)
        Me.cmdMultiply.TabIndex = 17
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdSubstract
        '
        Me.cmdSubstract.Location = New System.Drawing.Point(192, 179)
        Me.cmdSubstract.Name = "cmdSubstract"
        Me.cmdSubstract.Size = New System.Drawing.Size(46, 44)
        Me.cmdSubstract.TabIndex = 16
        Me.cmdSubstract.Text = "-"
        Me.cmdSubstract.UseVisualStyleBackColor = True
        '
        'cmdDivision
        '
        Me.cmdDivision.Location = New System.Drawing.Point(192, 79)
        Me.cmdDivision.Name = "cmdDivision"
        Me.cmdDivision.Size = New System.Drawing.Size(46, 44)
        Me.cmdDivision.TabIndex = 15
        Me.cmdDivision.Text = "/"
        Me.cmdDivision.UseVisualStyleBackColor = True
        '
        'cmdDecimal
        '
        Me.cmdDecimal.Location = New System.Drawing.Point(119, 230)
        Me.cmdDecimal.Name = "cmdDecimal"
        Me.cmdDecimal.Size = New System.Drawing.Size(46, 43)
        Me.cmdDecimal.TabIndex = 14
        Me.cmdDecimal.Text = "."
        Me.cmdDecimal.UseVisualStyleBackColor = True
        '
        'cmdSign
        '
        Me.cmdSign.Location = New System.Drawing.Point(67, 230)
        Me.cmdSign.Name = "cmdSign"
        Me.cmdSign.Size = New System.Drawing.Size(46, 43)
        Me.cmdSign.TabIndex = 13
        Me.cmdSign.Text = "-/+"
        Me.cmdSign.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.Location = New System.Drawing.Point(15, 229)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(46, 44)
        Me.cmd0.TabIndex = 12
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Location = New System.Drawing.Point(119, 179)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(46, 44)
        Me.cmd3.TabIndex = 11
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(67, 179)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(46, 44)
        Me.cmd2.TabIndex = 10
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(15, 179)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(46, 44)
        Me.cmd1.TabIndex = 9
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Location = New System.Drawing.Point(119, 129)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(46, 44)
        Me.cmd6.TabIndex = 8
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.Location = New System.Drawing.Point(67, 129)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(46, 44)
        Me.cmd5.TabIndex = 7
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(15, 129)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(46, 44)
        Me.cmd4.TabIndex = 6
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.Location = New System.Drawing.Point(119, 79)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(46, 44)
        Me.cmd9.TabIndex = 5
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Location = New System.Drawing.Point(67, 79)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(46, 44)
        Me.cmd8.TabIndex = 4
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.Location = New System.Drawing.Point(15, 79)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(46, 44)
        Me.cmd7.TabIndex = 3
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmdC
        '
        Me.cmdC.Location = New System.Drawing.Point(244, 17)
        Me.cmdC.Name = "cmdC"
        Me.cmdC.Size = New System.Drawing.Size(46, 44)
        Me.cmdC.TabIndex = 2
        Me.cmdC.Text = "C"
        Me.cmdC.UseVisualStyleBackColor = True
        '
        'cmdCE
        '
        Me.cmdCE.Location = New System.Drawing.Point(192, 17)
        Me.cmdCE.Name = "cmdCE"
        Me.cmdCE.Size = New System.Drawing.Size(46, 44)
        Me.cmdCE.TabIndex = 1
        Me.cmdCE.Text = "CE"
        Me.cmdCE.UseVisualStyleBackColor = True
        '
        'cmdBackspace
        '
        Me.cmdBackspace.Location = New System.Drawing.Point(15, 17)
        Me.cmdBackspace.Name = "cmdBackspace"
        Me.cmdBackspace.Size = New System.Drawing.Size(117, 44)
        Me.cmdBackspace.TabIndex = 0
        Me.cmdBackspace.Text = "Backspace"
        Me.cmdBackspace.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 432)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdC As Button
    Friend WithEvents cmdCE As Button
    Friend WithEvents cmdBackspace As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdSubstract As Button
    Friend WithEvents cmdDivision As Button
    Friend WithEvents cmdDecimal As Button
    Friend WithEvents cmdSign As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmdAddition As Button
    Friend WithEvents cmdPowerOf As Button
    Friend WithEvents cmdInverse As Button
    Friend WithEvents cmdSqrt As Button
    Friend WithEvents cmdEqual As Button
End Class
