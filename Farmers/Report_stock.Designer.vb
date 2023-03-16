<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_stock
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
        Me.BSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GpbReciept = New System.Windows.Forms.GroupBox()
        Me.LvRecord = New System.Windows.Forms.ListView()
        Me.GpbReciept.SuspendLayout()
        Me.SuspendLayout()
        '
        'BSearch
        '
        Me.BSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BSearch.Location = New System.Drawing.Point(49, 9)
        Me.BSearch.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BSearch.Name = "BSearch"
        Me.BSearch.Size = New System.Drawing.Size(85, 43)
        Me.BSearch.TabIndex = 27
        Me.BSearch.Text = "Print report:"
        Me.BSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "REPORT"
        '
        'GpbReciept
        '
        Me.GpbReciept.Controls.Add(Me.LvRecord)
        Me.GpbReciept.Controls.Add(Me.Label1)
        Me.GpbReciept.Location = New System.Drawing.Point(49, 51)
        Me.GpbReciept.Name = "GpbReciept"
        Me.GpbReciept.Size = New System.Drawing.Size(939, 547)
        Me.GpbReciept.TabIndex = 28
        Me.GpbReciept.TabStop = False
        '
        'LvRecord
        '
        Me.LvRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvRecord.Location = New System.Drawing.Point(0, 34)
        Me.LvRecord.Name = "LvRecord"
        Me.LvRecord.Size = New System.Drawing.Size(913, 484)
        Me.LvRecord.TabIndex = 2
        Me.LvRecord.UseCompatibleStateImageBehavior = False
        '
        'Report_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 545)
        Me.Controls.Add(Me.BSearch)
        Me.Controls.Add(Me.GpbReciept)
        Me.Name = "Report_stock"
        Me.Text = "Report_stock"
        Me.GpbReciept.ResumeLayout(False)
        Me.GpbReciept.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GpbReciept As System.Windows.Forms.GroupBox
    Friend WithEvents LvRecord As System.Windows.Forms.ListView
End Class
