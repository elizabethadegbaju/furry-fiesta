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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.principal = New System.Windows.Forms.TextBox()
        Me.rate = New System.Windows.Forms.TextBox()
        Me.time = New System.Windows.Forms.TextBox()
        Me.simple_I = New System.Windows.Forms.Button()
        Me.compound_I = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.exiter = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Principal :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Rate of Interest  :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Time :"
        '
        'principal
        '
        Me.principal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.principal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.principal.Location = New System.Drawing.Point(201, 58)
        Me.principal.Name = "principal"
        Me.principal.Size = New System.Drawing.Size(190, 26)
        Me.principal.TabIndex = 1
        Me.principal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rate
        '
        Me.rate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rate.Location = New System.Drawing.Point(201, 103)
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(190, 26)
        Me.rate.TabIndex = 2
        Me.rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'time
        '
        Me.time.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time.Location = New System.Drawing.Point(201, 148)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(190, 26)
        Me.time.TabIndex = 3
        Me.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'simple_I
        '
        Me.simple_I.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.simple_I.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simple_I.Location = New System.Drawing.Point(42, 197)
        Me.simple_I.Name = "simple_I"
        Me.simple_I.Size = New System.Drawing.Size(84, 44)
        Me.simple_I.TabIndex = 4
        Me.simple_I.Text = "Simple Interest"
        Me.simple_I.UseVisualStyleBackColor = True
        '
        'compound_I
        '
        Me.compound_I.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.compound_I.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compound_I.Location = New System.Drawing.Point(132, 197)
        Me.compound_I.Name = "compound_I"
        Me.compound_I.Size = New System.Drawing.Size(84, 44)
        Me.compound_I.TabIndex = 5
        Me.compound_I.Text = "Compound Interest"
        Me.compound_I.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.Location = New System.Drawing.Point(222, 197)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(84, 44)
        Me.clear.TabIndex = 6
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'exiter
        '
        Me.exiter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.exiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exiter.Location = New System.Drawing.Point(312, 197)
        Me.exiter.Name = "exiter"
        Me.exiter.Size = New System.Drawing.Size(84, 44)
        Me.exiter.TabIndex = 7
        Me.exiter.Text = "Exit"
        Me.exiter.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Result :"
        '
        'result
        '
        Me.result.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.result.Enabled = False
        Me.result.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result.Location = New System.Drawing.Point(201, 267)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(190, 26)
        Me.result.TabIndex = 8
        Me.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 340)
        Me.Controls.Add(Me.exiter)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.compound_I)
        Me.Controls.Add(Me.simple_I)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.rate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.principal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Interest Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents principal As TextBox
    Friend WithEvents rate As TextBox
    Friend WithEvents time As TextBox
    Friend WithEvents simple_I As Button
    Friend WithEvents compound_I As Button
    Friend WithEvents clear As Button
    Friend WithEvents exiter As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents result As TextBox
End Class
