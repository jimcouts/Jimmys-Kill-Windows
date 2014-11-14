<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShutdown
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShutdown))
        Me.cmdRestart = New DevComponents.DotNetBar.ButtonX()
        Me.cmdShutDown = New DevComponents.DotNetBar.ButtonX()
        Me.cmdForceShutdown = New DevComponents.DotNetBar.ButtonX()
        Me.lblShutdown = New DevComponents.DotNetBar.LabelX()
        Me.lblForceShutdown = New DevComponents.DotNetBar.LabelX()
        Me.lblRestart = New DevComponents.DotNetBar.LabelX()
        Me.lblCORE = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.SuspendLayout()
        '
        'cmdRestart
        '
        Me.cmdRestart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdRestart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdRestart.Location = New System.Drawing.Point(84, 71)
        Me.cmdRestart.Name = "cmdRestart"
        Me.cmdRestart.Size = New System.Drawing.Size(75, 23)
        Me.cmdRestart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmdRestart.TabIndex = 0
        Me.cmdRestart.Text = "Restart"
        '
        'cmdShutDown
        '
        Me.cmdShutDown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdShutDown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdShutDown.Location = New System.Drawing.Point(260, 71)
        Me.cmdShutDown.Name = "cmdShutDown"
        Me.cmdShutDown.Size = New System.Drawing.Size(75, 23)
        Me.cmdShutDown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmdShutDown.TabIndex = 0
        Me.cmdShutDown.Text = "Shutdown"
        Me.cmdShutDown.Tooltip = "20 Second Delay on the Shutdown"
        '
        'cmdForceShutdown
        '
        Me.cmdForceShutdown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdForceShutdown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdForceShutdown.Location = New System.Drawing.Point(457, 71)
        Me.cmdForceShutdown.Name = "cmdForceShutdown"
        Me.cmdForceShutdown.Size = New System.Drawing.Size(88, 23)
        Me.cmdForceShutdown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmdForceShutdown.TabIndex = 0
        Me.cmdForceShutdown.Text = "Force Shutdown"
        '
        'lblShutdown
        '
        '
        '
        '
        Me.lblShutdown.BackgroundStyle.Class = ""
        Me.lblShutdown.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblShutdown.Location = New System.Drawing.Point(179, 71)
        Me.lblShutdown.Name = "lblShutdown"
        Me.lblShutdown.Size = New System.Drawing.Size(75, 23)
        Me.lblShutdown.TabIndex = 1
        Me.lblShutdown.Text = "20 sec Delay:"
        '
        'lblForceShutdown
        '
        '
        '
        '
        Me.lblForceShutdown.BackgroundStyle.Class = ""
        Me.lblForceShutdown.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblForceShutdown.Location = New System.Drawing.Point(341, 71)
        Me.lblForceShutdown.Name = "lblForceShutdown"
        Me.lblForceShutdown.Size = New System.Drawing.Size(110, 23)
        Me.lblForceShutdown.TabIndex = 2
        Me.lblForceShutdown.Text = "No delay Shutdown:"
        '
        'lblRestart
        '
        '
        '
        '
        Me.lblRestart.BackgroundStyle.Class = ""
        Me.lblRestart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblRestart.Location = New System.Drawing.Point(14, 71)
        Me.lblRestart.Name = "lblRestart"
        Me.lblRestart.Size = New System.Drawing.Size(64, 23)
        Me.lblRestart.TabIndex = 3
        Me.lblRestart.Text = "Restart PC:"
        '
        'lblCORE
        '
        '
        '
        '
        Me.lblCORE.BackgroundStyle.Class = ""
        Me.lblCORE.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCORE.Location = New System.Drawing.Point(68, 12)
        Me.lblCORE.Name = "lblCORE"
        Me.lblCORE.Size = New System.Drawing.Size(440, 53)
        Me.lblCORE.TabIndex = 4
        Me.lblCORE.Text = "<b><font size=""+6""><i>Jimmy's </i><font color=""#B02B2C"">Restart, Shutdown and For" & _
    "ce Shutdown</font></font></b>"
        '
        'frmShutdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(556, 106)
        Me.Controls.Add(Me.lblCORE)
        Me.Controls.Add(Me.lblRestart)
        Me.Controls.Add(Me.lblForceShutdown)
        Me.Controls.Add(Me.lblShutdown)
        Me.Controls.Add(Me.cmdShutDown)
        Me.Controls.Add(Me.cmdForceShutdown)
        Me.Controls.Add(Me.cmdRestart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShutdown"
        Me.Text = "Jimmy's Shutdown Restart and Logoff for Win 8+"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdRestart As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdShutDown As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdForceShutdown As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblShutdown As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblForceShutdown As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblRestart As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCORE As DevComponents.DotNetBar.Controls.ReflectionLabel

End Class
