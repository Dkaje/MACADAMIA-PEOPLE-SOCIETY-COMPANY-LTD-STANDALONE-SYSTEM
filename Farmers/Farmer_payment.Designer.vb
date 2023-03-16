<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Farmer_payment
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
        Me.LvRecord = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelFarmerName = New System.Windows.Forms.Label()
        Me.LabelFarmID = New System.Windows.Forms.Label()
        Me.LabelFamerID = New System.Windows.Forms.Label()
        Me.GpbReciept = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelBal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelCash = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelTotalCost = New System.Windows.Forms.Label()
        Me.GpbForm = New System.Windows.Forms.GroupBox()
        Me.TxbBal = New System.Windows.Forms.TextBox()
        Me.TxbCash = New System.Windows.Forms.TextBox()
        Me.TxbTotal = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GpbReciept.SuspendLayout()
        Me.GpbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'LvRecord
        '
        Me.LvRecord.Location = New System.Drawing.Point(11, 113)
        Me.LvRecord.Name = "LvRecord"
        Me.LvRecord.Size = New System.Drawing.Size(271, 247)
        Me.LvRecord.TabIndex = 0
        Me.LvRecord.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(443, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Farmer / Supplier Payment"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.LabelDate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.LabelFarmerName)
        Me.GroupBox2.Controls.Add(Me.LabelFarmID)
        Me.GroupBox2.Controls.Add(Me.LabelFamerID)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 81)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(13, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 19)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Date"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(136, 4)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(44, 19)
        Me.LabelDate.TabIndex = 22
        Me.LabelDate.Text = "DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(6, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Name"
        '
        'LabelFarmerName
        '
        Me.LabelFarmerName.AutoSize = True
        Me.LabelFarmerName.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFarmerName.Location = New System.Drawing.Point(129, 59)
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
        Me.LabelFarmID.Location = New System.Drawing.Point(6, 28)
        Me.LabelFarmID.Name = "LabelFarmID"
        Me.LabelFarmID.Size = New System.Drawing.Size(72, 19)
        Me.LabelFarmID.TabIndex = 17
        Me.LabelFarmID.Text = "Farmer ID"
        '
        'LabelFamerID
        '
        Me.LabelFamerID.AutoSize = True
        Me.LabelFamerID.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFamerID.Location = New System.Drawing.Point(129, 28)
        Me.LabelFamerID.Name = "LabelFamerID"
        Me.LabelFamerID.Size = New System.Drawing.Size(57, 19)
        Me.LabelFamerID.TabIndex = 16
        Me.LabelFamerID.Text = "FarmID"
        '
        'GpbReciept
        '
        Me.GpbReciept.Controls.Add(Me.Label12)
        Me.GpbReciept.Controls.Add(Me.Label7)
        Me.GpbReciept.Controls.Add(Me.LabelBal)
        Me.GpbReciept.Controls.Add(Me.Label5)
        Me.GpbReciept.Controls.Add(Me.LabelCash)
        Me.GpbReciept.Controls.Add(Me.Label4)
        Me.GpbReciept.Controls.Add(Me.LabelTotalCost)
        Me.GpbReciept.Controls.Add(Me.GroupBox2)
        Me.GpbReciept.Controls.Add(Me.LvRecord)
        Me.GpbReciept.Location = New System.Drawing.Point(12, 33)
        Me.GpbReciept.Name = "GpbReciept"
        Me.GpbReciept.Size = New System.Drawing.Size(299, 487)
        Me.GpbReciept.TabIndex = 20
        Me.GpbReciept.TabStop = False
        Me.GpbReciept.Text = "Payment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 429)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Bal Ksh:"
        '
        'LabelBal
        '
        Me.LabelBal.AutoSize = True
        Me.LabelBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBal.Location = New System.Drawing.Point(117, 429)
        Me.LabelBal.Name = "LabelBal"
        Me.LabelBal.Size = New System.Drawing.Size(80, 18)
        Me.LabelBal.TabIndex = 49
        Me.LabelBal.Text = "------------"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Cash Ksh:"
        '
        'LabelCash
        '
        Me.LabelCash.AutoSize = True
        Me.LabelCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCash.Location = New System.Drawing.Point(117, 392)
        Me.LabelCash.Name = "LabelCash"
        Me.LabelCash.Size = New System.Drawing.Size(80, 18)
        Me.LabelCash.TabIndex = 47
        Me.LabelCash.Text = "------------"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Total Ksh:"
        '
        'LabelTotalCost
        '
        Me.LabelTotalCost.AutoSize = True
        Me.LabelTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalCost.Location = New System.Drawing.Point(117, 360)
        Me.LabelTotalCost.Name = "LabelTotalCost"
        Me.LabelTotalCost.Size = New System.Drawing.Size(80, 18)
        Me.LabelTotalCost.TabIndex = 45
        Me.LabelTotalCost.Text = "------------"
        '
        'GpbForm
        '
        Me.GpbForm.Controls.Add(Me.TxbBal)
        Me.GpbForm.Controls.Add(Me.TxbCash)
        Me.GpbForm.Controls.Add(Me.TxbTotal)
        Me.GpbForm.Controls.Add(Me.BtnSubmit)
        Me.GpbForm.Controls.Add(Me.Label8)
        Me.GpbForm.Controls.Add(Me.Label9)
        Me.GpbForm.Controls.Add(Me.Label10)
        Me.GpbForm.Location = New System.Drawing.Point(343, 54)
        Me.GpbForm.Name = "GpbForm"
        Me.GpbForm.Size = New System.Drawing.Size(262, 198)
        Me.GpbForm.TabIndex = 45
        Me.GpbForm.TabStop = False
        '
        'TxbBal
        '
        Me.TxbBal.Enabled = False
        Me.TxbBal.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbBal.Location = New System.Drawing.Point(97, 83)
        Me.TxbBal.Name = "TxbBal"
        Me.TxbBal.Size = New System.Drawing.Size(124, 25)
        Me.TxbBal.TabIndex = 57
        '
        'TxbCash
        '
        Me.TxbCash.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbCash.Location = New System.Drawing.Point(97, 48)
        Me.TxbCash.Name = "TxbCash"
        Me.TxbCash.Size = New System.Drawing.Size(124, 25)
        Me.TxbCash.TabIndex = 56
        '
        'TxbTotal
        '
        Me.TxbTotal.Enabled = False
        Me.TxbTotal.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbTotal.Location = New System.Drawing.Point(97, 17)
        Me.TxbTotal.Name = "TxbTotal"
        Me.TxbTotal.Size = New System.Drawing.Size(124, 25)
        Me.TxbTotal.TabIndex = 55
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.Red
        Me.BtnSubmit.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.ForeColor = System.Drawing.Color.White
        Me.BtnSubmit.Location = New System.Drawing.Point(9, 137)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(247, 32)
        Me.BtnSubmit.TabIndex = 54
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 18)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Bal Ksh:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 18)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Cash Ksh:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 18)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Total Ksh:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(51, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 21)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Nothing to pay !!"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(230, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "MACADEMIA PEOPLE'S  COMPANY LIMITED"
        '
        'Farmer_payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 578)
        Me.Controls.Add(Me.GpbForm)
        Me.Controls.Add(Me.GpbReciept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Farmer_payment"
        Me.Text = "Farmer_payment"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GpbReciept.ResumeLayout(False)
        Me.GpbReciept.PerformLayout()
        Me.GpbForm.ResumeLayout(False)
        Me.GpbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LvRecord As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelFarmerName As System.Windows.Forms.Label
    Friend WithEvents LabelFarmID As System.Windows.Forms.Label
    Friend WithEvents LabelFamerID As System.Windows.Forms.Label
    Friend WithEvents GpbReciept As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelCash As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelTotalCost As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelBal As System.Windows.Forms.Label
    Friend WithEvents GpbForm As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxbBal As System.Windows.Forms.TextBox
    Friend WithEvents TxbCash As System.Windows.Forms.TextBox
    Friend WithEvents TxbTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabelDate As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
