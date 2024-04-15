<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.subForm_panel = New MetroFramework.Controls.MetroPanel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 35)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "OLS MG Control Form"
        '
        'subForm_panel
        '
        Me.subForm_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subForm_panel.HorizontalScrollbarBarColor = True
        Me.subForm_panel.HorizontalScrollbarHighlightOnWheel = False
        Me.subForm_panel.HorizontalScrollbarSize = 10
        Me.subForm_panel.Location = New System.Drawing.Point(0, 35)
        Me.subForm_panel.Name = "subForm_panel"
        Me.subForm_panel.Size = New System.Drawing.Size(800, 415)
        Me.subForm_panel.TabIndex = 2
        Me.subForm_panel.VerticalScrollbarBarColor = True
        Me.subForm_panel.VerticalScrollbarHighlightOnWheel = False
        Me.subForm_panel.VerticalScrollbarSize = 10
        '
        'subForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.subForm_panel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "subForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OLS MG TRS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents subForm_panel As MetroFramework.Controls.MetroPanel
End Class
