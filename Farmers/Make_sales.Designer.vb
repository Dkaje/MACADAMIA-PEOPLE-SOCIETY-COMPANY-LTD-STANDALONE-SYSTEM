<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Make_sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Make_sales))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LvRecord = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelProName = New System.Windows.Forms.Label()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.LabelStock = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LableProID = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelCustName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelCustID = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select product"
        '
        'LvRecord
        '
        Me.LvRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvRecord.Location = New System.Drawing.Point(12, 59)
        Me.LvRecord.Name = "LvRecord"
        Me.LvRecord.Size = New System.Drawing.Size(260, 463)
        Me.LvRecord.TabIndex = 34
        Me.LvRecord.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LabelProName)
        Me.GroupBox1.Controls.Add(Me.LabelPrice)
        Me.GroupBox1.Controls.Add(Me.LabelStock)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LableProID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtQuantity)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(296, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 255)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(7, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Quantity"
        '
        'LabelProName
        '
        Me.LabelProName.AutoSize = True
        Me.LabelProName.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProName.Location = New System.Drawing.Point(129, 67)
        Me.LabelProName.Name = "LabelProName"
        Me.LabelProName.Size = New System.Drawing.Size(101, 19)
        Me.LabelProName.TabIndex = 14
        Me.LabelProName.Text = "ProductName"
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrice.Location = New System.Drawing.Point(132, 99)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(43, 19)
        Me.LabelPrice.TabIndex = 13
        Me.LabelPrice.Text = "Price"
        '
        'LabelStock
        '
        Me.LabelStock.AutoSize = True
        Me.LabelStock.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStock.Location = New System.Drawing.Point(132, 133)
        Me.LabelStock.Name = "LabelStock"
        Me.LabelStock.Size = New System.Drawing.Size(45, 19)
        Me.LabelStock.TabIndex = 12
        Me.LabelStock.Text = "Stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(6, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Products ID"
        '
        'LableProID
        '
        Me.LableProID.AutoSize = True
        Me.LableProID.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LableProID.Location = New System.Drawing.Point(129, 34)
        Me.LableProID.Name = "LableProID"
        Me.LableProID.Size = New System.Drawing.Size(75, 19)
        Me.LableProID.TabIndex = 10
        Me.LableProID.Text = "ProductID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(6, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Product Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(7, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Stock available"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(6, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Price Ksh:"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.Location = New System.Drawing.Point(128, 167)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(88, 31)
        Me.TxtQuantity.TabIndex = 7
        '
        'SubmitBtn
        '
        Me.SubmitBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SubmitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SubmitBtn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SubmitBtn.Image = CType(resources.GetObject("SubmitBtn.Image"), System.Drawing.Image)
        Me.SubmitBtn.Location = New System.Drawing.Point(299, 467)
        Me.SubmitBtn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(258, 41)
        Me.SubmitBtn.TabIndex = 39
        Me.SubmitBtn.Text = "Submit:"
        Me.SubmitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SubmitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.LabelCustName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LabelCustID)
        Me.GroupBox2.Location = New System.Drawing.Point(299, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 69)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(6, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Name"
        '
        'LabelCustName
        '
        Me.LabelCustName.AutoSize = True
        Me.LabelCustName.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustName.Location = New System.Drawing.Point(129, 47)
        Me.LabelCustName.Name = "LabelCustName"
        Me.LabelCustName.Size = New System.Drawing.Size(49, 19)
        Me.LabelCustName.TabIndex = 18
        Me.LabelCustName.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Customer ID"
        '
        'LabelCustID
        '
        Me.LabelCustID.AutoSize = True
        Me.LabelCustID.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustID.Location = New System.Drawing.Point(129, 16)
        Me.LabelCustID.Name = "LabelCustID"
        Me.LabelCustID.Size = New System.Drawing.Size(51, 19)
        Me.LabelCustID.TabIndex = 16
        Me.LabelCustID.Text = "CustID"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(293, 59)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(264, 41)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Select"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(569, 59)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(264, 41)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Make Payment"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Make_sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 581)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LvRecord)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Make_sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make_sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LvRecord As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LableProID As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents LabelProName As System.Windows.Forms.Label
    Friend WithEvents LabelPrice As System.Windows.Forms.Label
    Friend WithEvents LabelStock As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelCustName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelCustID As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
