<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.BCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkSearch = New System.Windows.Forms.CheckBox()
        Me.ChkRefresh = New System.Windows.Forms.CheckBox()
        Me.BSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BCancel
        '
        Me.BCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BCancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BCancel.Image = CType(resources.GetObject("BCancel.Image"), System.Drawing.Image)
        Me.BCancel.Location = New System.Drawing.Point(142, 130)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(101, 51)
        Me.BCancel.TabIndex = 15
        Me.BCancel.Text = "Cancel:"
        Me.BCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkSearch)
        Me.GroupBox1.Controls.Add(Me.ChkRefresh)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(24, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 93)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'ChkSearch
        '
        Me.ChkSearch.AutoSize = True
        Me.ChkSearch.Location = New System.Drawing.Point(10, 55)
        Me.ChkSearch.Name = "ChkSearch"
        Me.ChkSearch.Size = New System.Drawing.Size(196, 23)
        Me.ChkSearch.TabIndex = 1
        Me.ChkSearch.Text = "Quick Search (No waiting)"
        Me.ChkSearch.UseVisualStyleBackColor = True
        '
        'ChkRefresh
        '
        Me.ChkRefresh.AutoSize = True
        Me.ChkRefresh.Location = New System.Drawing.Point(10, 26)
        Me.ChkRefresh.Name = "ChkRefresh"
        Me.ChkRefresh.Size = New System.Drawing.Size(203, 23)
        Me.ChkRefresh.TabIndex = 0
        Me.ChkRefresh.Text = "Quick Refresh (No waiting)"
        Me.ChkRefresh.UseVisualStyleBackColor = True
        '
        'BSave
        '
        Me.BSave.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BSave.Image = CType(resources.GetObject("BSave.Image"), System.Drawing.Image)
        Me.BSave.Location = New System.Drawing.Point(24, 130)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(101, 51)
        Me.BSave.TabIndex = 14
        Me.BSave.Text = "Apply Changes:"
        Me.BSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BSave.UseVisualStyleBackColor = True
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BSave)
        Me.Name = "FrmSettings"
        Me.Text = "FrmSettings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkSearch As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRefresh As System.Windows.Forms.CheckBox
    Friend WithEvents BSave As System.Windows.Forms.Button
End Class
