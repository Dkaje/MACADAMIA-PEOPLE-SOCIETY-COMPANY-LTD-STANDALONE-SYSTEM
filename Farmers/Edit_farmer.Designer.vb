﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_farmer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_farmer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BClose = New System.Windows.Forms.Button()
        Me.BSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIDNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LableFarmerID = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtPhoneNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(193, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 33)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Edit Farmer/Supplier:"
        '
        'BClose
        '
        Me.BClose.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BClose.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BClose.Image = CType(resources.GetObject("BClose.Image"), System.Drawing.Image)
        Me.BClose.Location = New System.Drawing.Point(327, 329)
        Me.BClose.Name = "BClose"
        Me.BClose.Size = New System.Drawing.Size(190, 43)
        Me.BClose.TabIndex = 24
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
        Me.BSave.Location = New System.Drawing.Point(116, 329)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(205, 43)
        Me.BSave.TabIndex = 23
        Me.BSave.Text = "Edit"
        Me.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtIDNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LableFarmerID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtFirstName)
        Me.GroupBox1.Controls.Add(Me.TxtLastName)
        Me.GroupBox1.Controls.Add(Me.TxtAddress)
        Me.GroupBox1.Controls.Add(Me.TxtPhoneNum)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(79, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 234)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(7, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "National ID NO:"
        '
        'TxtIDNo
        '
        Me.TxtIDNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIDNo.Location = New System.Drawing.Point(137, 105)
        Me.TxtIDNo.Name = "TxtIDNo"
        Me.TxtIDNo.Size = New System.Drawing.Size(306, 26)
        Me.TxtIDNo.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(6, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Farmer ID"
        '
        'LableFarmerID
        '
        Me.LableFarmerID.AutoSize = True
        Me.LableFarmerID.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LableFarmerID.Location = New System.Drawing.Point(129, 13)
        Me.LableFarmerID.Name = "LableFarmerID"
        Me.LableFarmerID.Size = New System.Drawing.Size(19, 19)
        Me.LableFarmerID.TabIndex = 10
        Me.LableFarmerID.Text = "D"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(4, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(9, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Phone Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(8, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Email Address:"
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirstName.Location = New System.Drawing.Point(133, 67)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(151, 26)
        Me.TxtFirstName.TabIndex = 2
        '
        'TxtLastName
        '
        Me.TxtLastName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLastName.Location = New System.Drawing.Point(290, 67)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(148, 26)
        Me.TxtLastName.TabIndex = 3
        '
        'TxtAddress
        '
        Me.TxtAddress.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(138, 141)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(306, 26)
        Me.TxtAddress.TabIndex = 7
        '
        'TxtPhoneNum
        '
        Me.TxtPhoneNum.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhoneNum.Location = New System.Drawing.Point(138, 173)
        Me.TxtPhoneNum.Name = "TxtPhoneNum"
        Me.TxtPhoneNum.Size = New System.Drawing.Size(306, 26)
        Me.TxtPhoneNum.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(296, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(130, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        '
        'Edit_farmer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 424)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BClose)
        Me.Controls.Add(Me.BSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Edit_farmer"
        Me.Text = "Edit_farmer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BClose As System.Windows.Forms.Button
    Friend WithEvents BSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtIDNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LableFarmerID As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents TxtLastName As System.Windows.Forms.TextBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtPhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
