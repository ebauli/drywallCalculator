<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExploreProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRoomsInProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewProjectToolStripMenuItem, Me.OpenProjectToolStripMenuItem, Me.ExploreProjectToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'AddNewProjectToolStripMenuItem
        '
        Me.AddNewProjectToolStripMenuItem.Name = "AddNewProjectToolStripMenuItem"
        Me.AddNewProjectToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AddNewProjectToolStripMenuItem.Text = "Add New Project"
        '
        'OpenProjectToolStripMenuItem
        '
        Me.OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem"
        Me.OpenProjectToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.OpenProjectToolStripMenuItem.Text = "Open project"
        '
        'ExploreProjectToolStripMenuItem
        '
        Me.ExploreProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewRoomsInProjectToolStripMenuItem})
        Me.ExploreProjectToolStripMenuItem.Name = "ExploreProjectToolStripMenuItem"
        Me.ExploreProjectToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ExploreProjectToolStripMenuItem.Text = "Explore Project"
        '
        'ViewRoomsInProjectToolStripMenuItem
        '
        Me.ViewRoomsInProjectToolStripMenuItem.Name = "ViewRoomsInProjectToolStripMenuItem"
        Me.ViewRoomsInProjectToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ViewRoomsInProjectToolStripMenuItem.Text = "View Rooms in Project"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Project Main Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExploreProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewRoomsInProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenProjectToolStripMenuItem As ToolStripMenuItem
End Class
