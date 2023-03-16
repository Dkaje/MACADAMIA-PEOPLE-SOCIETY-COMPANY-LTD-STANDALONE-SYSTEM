<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AxPDFViewer1 = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.AxPDFViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AxPDFViewer1
        '
        Me.AxPDFViewer1.Enabled = True
        Me.AxPDFViewer1.Location = New System.Drawing.Point(0, 29)
        Me.AxPDFViewer1.Name = "AxPDFViewer1"
        Me.AxPDFViewer1.OcxState = CType(resources.GetObject("AxPDFViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxPDFViewer1.Size = New System.Drawing.Size(710, 620)
        Me.AxPDFViewer1.TabIndex = 1
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 638)
        Me.Controls.Add(Me.AxPDFViewer1)
        Me.Name = "Help"
        Me.Text = "Help"
        CType(Me.AxPDFViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AxPDFViewer1 As AxAcroPDFLib.AxAcroPDF
End Class
