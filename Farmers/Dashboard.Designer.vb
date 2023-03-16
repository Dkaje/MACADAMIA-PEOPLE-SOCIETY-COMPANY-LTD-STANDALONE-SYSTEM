<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.StaffBtn = New System.Windows.Forms.Button()
        Me.CustomersBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SalesBtn = New System.Windows.Forms.Button()
        Me.FramersBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.My_databaseDataSet1 = New Global.Farmers.my_databaseDataSet()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.My_databaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffBtn
        '
        Me.StaffBtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffBtn.Location = New System.Drawing.Point(12, 50)
        Me.StaffBtn.Name = "StaffBtn"
        Me.StaffBtn.Size = New System.Drawing.Size(371, 43)
        Me.StaffBtn.TabIndex = 0
        Me.StaffBtn.Text = "Staff"
        Me.StaffBtn.UseVisualStyleBackColor = True
        '
        'CustomersBtn
        '
        Me.CustomersBtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomersBtn.Location = New System.Drawing.Point(12, 188)
        Me.CustomersBtn.Name = "CustomersBtn"
        Me.CustomersBtn.Size = New System.Drawing.Size(371, 43)
        Me.CustomersBtn.TabIndex = 1
        Me.CustomersBtn.Text = "Customers"
        Me.CustomersBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(371, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Stock"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SalesBtn
        '
        Me.SalesBtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesBtn.Location = New System.Drawing.Point(12, 334)
        Me.SalesBtn.Name = "SalesBtn"
        Me.SalesBtn.Size = New System.Drawing.Size(371, 43)
        Me.SalesBtn.TabIndex = 3
        Me.SalesBtn.Text = "Sales history"
        Me.SalesBtn.UseVisualStyleBackColor = True
        '
        'FramersBtn
        '
        Me.FramersBtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FramersBtn.Location = New System.Drawing.Point(12, 118)
        Me.FramersBtn.Name = "FramersBtn"
        Me.FramersBtn.Size = New System.Drawing.Size(371, 43)
        Me.FramersBtn.TabIndex = 4
        Me.FramersBtn.Text = "Farmers / Suppliers"
        Me.FramersBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 396)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(371, 43)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Stock in history"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "MACADEMIA PEOPLE'S  COMPANY LIMITED"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3, Me.ToolStripLabel4, Me.ToolStripLabel5, Me.ToolStripLabel6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(770, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabel1.Text = "Staff report"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(90, 22)
        Me.ToolStripLabel2.Text = "Suppliers report"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripLabel3.Text = "Customer report"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripLabel4.Text = "Stock report"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel5.Text = "Sales report"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel6.Text = "HELP"
        '
        'My_databaseDataSet1
        '
        Me.My_databaseDataSet1.DataSetName = "my_databaseDataSet"
        Me.My_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 530)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.FramersBtn)
        Me.Controls.Add(Me.SalesBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CustomersBtn)
        Me.Controls.Add(Me.StaffBtn)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.My_databaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StaffBtn As System.Windows.Forms.Button
    Friend WithEvents CustomersBtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SalesBtn As System.Windows.Forms.Button
    Friend WithEvents FramersBtn As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents My_databaseDataSet1 As Global.Farmers.my_databaseDataSet
End Class
