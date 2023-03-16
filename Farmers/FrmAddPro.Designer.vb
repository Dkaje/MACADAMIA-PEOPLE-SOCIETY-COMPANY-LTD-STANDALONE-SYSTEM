<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddPro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddPro))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtProName = New System.Windows.Forms.TextBox()
        Me.TxtProPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BClose = New System.Windows.Forms.Button()
        Me.BSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtStock)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtProName)
        Me.GroupBox1.Controls.Add(Me.TxtProPrice)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 152)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(9, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(8, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Product name:"
        '
        'TxtProName
        '
        Me.TxtProName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProName.Location = New System.Drawing.Point(138, 37)
        Me.TxtProName.Name = "TxtProName"
        Me.TxtProName.Size = New System.Drawing.Size(306, 26)
        Me.TxtProName.TabIndex = 7
        '
        'TxtProPrice
        '
        Me.TxtProPrice.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProPrice.Location = New System.Drawing.Point(138, 76)
        Me.TxtProPrice.Name = "TxtProPrice"
        Me.TxtProPrice.Size = New System.Drawing.Size(306, 26)
        Me.TxtProPrice.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(148, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 33)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Add new Product:"
        '
        'BClose
        '
        Me.BClose.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BClose.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BClose.Image = CType(resources.GetObject("BClose.Image"), System.Drawing.Image)
        Me.BClose.Location = New System.Drawing.Point(282, 219)
        Me.BClose.Name = "BClose"
        Me.BClose.Size = New System.Drawing.Size(190, 43)
        Me.BClose.TabIndex = 16
        Me.BClose.Text = "Cancel:"
        Me.BClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BClose.UseVisualStyleBackColor = True
        '
        'BSave
        '
        Me.BSave.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BSave.Image = CType(resources.GetObject("BSave.Image"), System.Drawing.Image)
        Me.BSave.Location = New System.Drawing.Point(71, 219)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(205, 43)
        Me.BSave.TabIndex = 15
        Me.BSave.Text = "Save"
        Me.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(9, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Stock:"
        '
        'TxtStock
        '
        Me.TxtStock.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStock.Location = New System.Drawing.Point(138, 111)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(306, 26)
        Me.TxtStock.TabIndex = 9
        '
        'FrmAddPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 338)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BClose)
        Me.Controls.Add(Me.BSave)
        Me.Name = "FrmAddPro"
        Me.Text = "FrmAddPro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtProName As System.Windows.Forms.TextBox
    Friend WithEvents TxtProPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BClose As System.Windows.Forms.Button
    Friend WithEvents BSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
End Class
