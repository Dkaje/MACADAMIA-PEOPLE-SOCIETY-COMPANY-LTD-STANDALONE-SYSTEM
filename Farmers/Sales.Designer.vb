<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.BClose = New System.Windows.Forms.Button()
        Me.LvRecord = New System.Windows.Forms.ListView()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BSearch = New System.Windows.Forms.Button()
        Me.BRefresh = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BClose
        '
        Me.BClose.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BClose.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BClose.Image = CType(resources.GetObject("BClose.Image"), System.Drawing.Image)
        Me.BClose.Location = New System.Drawing.Point(716, 0)
        Me.BClose.Name = "BClose"
        Me.BClose.Size = New System.Drawing.Size(80, 41)
        Me.BClose.TabIndex = 55
        Me.BClose.Text = " Exit:"
        Me.BClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BClose.UseVisualStyleBackColor = True
        '
        'LvRecord
        '
        Me.LvRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvRecord.Location = New System.Drawing.Point(25, 127)
        Me.LvRecord.Name = "LvRecord"
        Me.LvRecord.Size = New System.Drawing.Size(781, 433)
        Me.LvRecord.TabIndex = 51
        Me.LvRecord.UseCompatibleStateImageBehavior = False
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(6, 15)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(140, 26)
        Me.TxtSearch.TabIndex = 2
        Me.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(204, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 45)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(46, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search All:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(224, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 33)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Sales history"
        '
        'BSearch
        '
        Me.BSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BSearch.Image = CType(resources.GetObject("BSearch.Image"), System.Drawing.Image)
        Me.BSearch.Location = New System.Drawing.Point(379, 2)
        Me.BSearch.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BSearch.Name = "BSearch"
        Me.BSearch.Size = New System.Drawing.Size(99, 43)
        Me.BSearch.TabIndex = 53
        Me.BSearch.Text = "Search:"
        Me.BSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSearch.UseVisualStyleBackColor = True
        '
        'BRefresh
        '
        Me.BRefresh.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BRefresh.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BRefresh.Image = CType(resources.GetObject("BRefresh.Image"), System.Drawing.Image)
        Me.BRefresh.Location = New System.Drawing.Point(96, 0)
        Me.BRefresh.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BRefresh.Name = "BRefresh"
        Me.BRefresh.Size = New System.Drawing.Size(99, 43)
        Me.BRefresh.TabIndex = 52
        Me.BRefresh.Text = "Refresh:"
        Me.BRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BRefresh.UseVisualStyleBackColor = True
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 628)
        Me.Controls.Add(Me.BClose)
        Me.Controls.Add(Me.LvRecord)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BSearch)
        Me.Controls.Add(Me.BRefresh)
        Me.Name = "Sales"
        Me.Text = "Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BClose As System.Windows.Forms.Button
    Friend WithEvents LvRecord As System.Windows.Forms.ListView
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BSearch As System.Windows.Forms.Button
    Friend WithEvents BRefresh As System.Windows.Forms.Button
End Class
