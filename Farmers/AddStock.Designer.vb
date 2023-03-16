<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStock))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelFarmerName = New System.Windows.Forms.Label()
        Me.LabelFarmID = New System.Windows.Forms.Label()
        Me.LabelFamerID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddStockBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BuyingPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelProName = New System.Windows.Forms.Label()
        Me.LabelStock = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LableProID = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtRestock = New System.Windows.Forms.TextBox()
        Me.LvRecord = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(293, 33)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(264, 41)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Select"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.LabelFarmerName)
        Me.GroupBox2.Controls.Add(Me.LabelFarmID)
        Me.GroupBox2.Controls.Add(Me.LabelFamerID)
        Me.GroupBox2.Location = New System.Drawing.Point(299, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 69)
        Me.GroupBox2.TabIndex = 42
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
        'LabelFarmerName
        '
        Me.LabelFarmerName.AutoSize = True
        Me.LabelFarmerName.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFarmerName.Location = New System.Drawing.Point(129, 47)
        Me.LabelFarmerName.Name = "LabelFarmerName"
        Me.LabelFarmerName.Size = New System.Drawing.Size(49, 19)
        Me.LabelFarmerName.TabIndex = 18
        Me.LabelFarmerName.Text = "Name"
        '
        'LabelFarmID
        '
        Me.LabelFarmID.AutoSize = True
        Me.LabelFarmID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFarmID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelFarmID.Location = New System.Drawing.Point(6, 16)
        Me.LabelFarmID.Name = "LabelFarmID"
        Me.LabelFarmID.Size = New System.Drawing.Size(72, 19)
        Me.LabelFarmID.TabIndex = 17
        Me.LabelFarmID.Text = "Fermer ID"
        '
        'LabelFamerID
        '
        Me.LabelFamerID.AutoSize = True
        Me.LabelFamerID.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFamerID.Location = New System.Drawing.Point(129, 16)
        Me.LabelFamerID.Name = "LabelFamerID"
        Me.LabelFamerID.Size = New System.Drawing.Size(57, 19)
        Me.LabelFamerID.TabIndex = 16
        Me.LabelFamerID.Text = "FarmID"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox1.Controls.Add(Me.AddStockBtn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BuyingPrice)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LabelProName)
        Me.GroupBox1.Controls.Add(Me.LabelStock)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LableProID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtRestock)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(296, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 308)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'AddStockBtn
        '
        Me.AddStockBtn.BackColor = System.Drawing.Color.Red
        Me.AddStockBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AddStockBtn.Enabled = False
        Me.AddStockBtn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStockBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddStockBtn.Image = CType(resources.GetObject("AddStockBtn.Image"), System.Drawing.Image)
        Me.AddStockBtn.Location = New System.Drawing.Point(0, 237)
        Me.AddStockBtn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.AddStockBtn.Name = "AddStockBtn"
        Me.AddStockBtn.Size = New System.Drawing.Size(264, 41)
        Me.AddStockBtn.TabIndex = 47
        Me.AddStockBtn.Text = "Add Stock"
        Me.AddStockBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddStockBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.AddStockBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(9, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Buying price"
        '
        'BuyingPrice
        '
        Me.BuyingPrice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyingPrice.Location = New System.Drawing.Point(130, 189)
        Me.BuyingPrice.Name = "BuyingPrice"
        Me.BuyingPrice.Size = New System.Drawing.Size(100, 27)
        Me.BuyingPrice.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(9, 149)
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
        'LabelStock
        '
        Me.LabelStock.AutoSize = True
        Me.LabelStock.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStock.Location = New System.Drawing.Point(134, 108)
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
        Me.Label8.Location = New System.Drawing.Point(9, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Stock available"
        '
        'TxtRestock
        '
        Me.TxtRestock.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRestock.Location = New System.Drawing.Point(130, 142)
        Me.TxtRestock.Name = "TxtRestock"
        Me.TxtRestock.Size = New System.Drawing.Size(100, 27)
        Me.TxtRestock.TabIndex = 7
        '
        'LvRecord
        '
        Me.LvRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvRecord.Location = New System.Drawing.Point(12, 33)
        Me.LvRecord.Name = "LvRecord"
        Me.LvRecord.Size = New System.Drawing.Size(260, 463)
        Me.LvRecord.TabIndex = 43
        Me.LvRecord.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Select product"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(637, 33)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(264, 41)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Make Payment"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'AddStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 520)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LvRecord)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddStock"
        Me.Text = "AddStock"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelFarmerName As System.Windows.Forms.Label
    Friend WithEvents LabelFarmID As System.Windows.Forms.Label
    Friend WithEvents LabelFamerID As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelProName As System.Windows.Forms.Label
    Friend WithEvents LabelStock As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LableProID As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtRestock As System.Windows.Forms.TextBox
    Friend WithEvents LvRecord As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddStockBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BuyingPrice As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
