<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRooms
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
        Me.cbxRooms = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCornerName = New System.Windows.Forms.TextBox()
        Me.txtCornerDesc = New System.Windows.Forms.TextBox()
        Me.txtLsDistance = New System.Windows.Forms.TextBox()
        Me.txtRsDistance = New System.Windows.Forms.TextBox()
        Me.txtHeightFF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.txtWallName = New System.Windows.Forms.TextBox()
        Me.txtWallDesc = New System.Windows.Forms.TextBox()
        Me.txtLeftCorner = New System.Windows.Forms.TextBox()
        Me.txtRightCorner = New System.Windows.Forms.TextBox()
        Me.txtWallWidth = New System.Windows.Forms.TextBox()
        Me.txtBaseboardHeight = New System.Windows.Forms.TextBox()
        Me.txtRevealHeight = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.cmbHasReveal = New System.Windows.Forms.ComboBox()
        Me.GroupCorner = New System.Windows.Forms.GroupBox()
        Me.GroupWall = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupWall.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxRooms
        '
        Me.cbxRooms.FormattingEnabled = True
        Me.cbxRooms.Location = New System.Drawing.Point(63, 70)
        Me.cbxRooms.Name = "cbxRooms"
        Me.cbxRooms.Size = New System.Drawing.Size(293, 21)
        Me.cbxRooms.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(481, 98)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(521, 212)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seelect room to view or modify"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(619, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Modify Values inside Grid"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(321, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Project Name "
        '
        'txtCornerName
        '
        Me.txtCornerName.Location = New System.Drawing.Point(229, 145)
        Me.txtCornerName.Name = "txtCornerName"
        Me.txtCornerName.Size = New System.Drawing.Size(150, 20)
        Me.txtCornerName.TabIndex = 5
        '
        'txtCornerDesc
        '
        Me.txtCornerDesc.Location = New System.Drawing.Point(229, 171)
        Me.txtCornerDesc.Name = "txtCornerDesc"
        Me.txtCornerDesc.Size = New System.Drawing.Size(150, 20)
        Me.txtCornerDesc.TabIndex = 6
        '
        'txtLsDistance
        '
        Me.txtLsDistance.Location = New System.Drawing.Point(229, 197)
        Me.txtLsDistance.Name = "txtLsDistance"
        Me.txtLsDistance.Size = New System.Drawing.Size(150, 20)
        Me.txtLsDistance.TabIndex = 7
        '
        'txtRsDistance
        '
        Me.txtRsDistance.Location = New System.Drawing.Point(229, 223)
        Me.txtRsDistance.Name = "txtRsDistance"
        Me.txtRsDistance.Size = New System.Drawing.Size(150, 20)
        Me.txtRsDistance.TabIndex = 8
        '
        'txtHeightFF
        '
        Me.txtHeightFF.Location = New System.Drawing.Point(229, 249)
        Me.txtHeightFF.Name = "txtHeightFF"
        Me.txtHeightFF.Size = New System.Drawing.Size(150, 20)
        Me.txtHeightFF.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Corner Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Corner Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Left Stud Distance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Right Stud Distance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Height From Ceiling to finished Floor"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Add Corner "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(454, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(509, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(585, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Corner Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(681, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "None Selected"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(152, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(255, 311)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(481, 424)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(521, 177)
        Me.DataGridView2.TabIndex = 23
        '
        'txtWallName
        '
        Me.txtWallName.Location = New System.Drawing.Point(229, 416)
        Me.txtWallName.Name = "txtWallName"
        Me.txtWallName.Size = New System.Drawing.Size(150, 20)
        Me.txtWallName.TabIndex = 24
        '
        'txtWallDesc
        '
        Me.txtWallDesc.Location = New System.Drawing.Point(229, 442)
        Me.txtWallDesc.Name = "txtWallDesc"
        Me.txtWallDesc.Size = New System.Drawing.Size(150, 20)
        Me.txtWallDesc.TabIndex = 25
        '
        'txtLeftCorner
        '
        Me.txtLeftCorner.Location = New System.Drawing.Point(229, 468)
        Me.txtLeftCorner.Name = "txtLeftCorner"
        Me.txtLeftCorner.Size = New System.Drawing.Size(150, 20)
        Me.txtLeftCorner.TabIndex = 26
        '
        'txtRightCorner
        '
        Me.txtRightCorner.Location = New System.Drawing.Point(229, 494)
        Me.txtRightCorner.Name = "txtRightCorner"
        Me.txtRightCorner.Size = New System.Drawing.Size(150, 20)
        Me.txtRightCorner.TabIndex = 27
        '
        'txtWallWidth
        '
        Me.txtWallWidth.Location = New System.Drawing.Point(229, 520)
        Me.txtWallWidth.Name = "txtWallWidth"
        Me.txtWallWidth.Size = New System.Drawing.Size(150, 20)
        Me.txtWallWidth.TabIndex = 28
        '
        'txtBaseboardHeight
        '
        Me.txtBaseboardHeight.Location = New System.Drawing.Point(229, 572)
        Me.txtBaseboardHeight.Name = "txtBaseboardHeight"
        Me.txtBaseboardHeight.Size = New System.Drawing.Size(150, 20)
        Me.txtBaseboardHeight.TabIndex = 30
        '
        'txtRevealHeight
        '
        Me.txtRevealHeight.Location = New System.Drawing.Point(229, 598)
        Me.txtRevealHeight.Name = "txtRevealHeight"
        Me.txtRevealHeight.Size = New System.Drawing.Size(150, 20)
        Me.txtRevealHeight.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(48, 416)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Wall Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(48, 442)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Wall description"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(48, 468)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Left Corner"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(48, 494)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Right Corner"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(48, 520)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 13)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Wall Width"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(48, 546)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "HasReveal"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(48, 572)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 13)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Baseboard Height"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(48, 598)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Reveal Height"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(48, 624)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 13)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "SE Strip Size Height"
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(229, 624)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(150, 20)
        Me.txt.TabIndex = 41
        '
        'cmbHasReveal
        '
        Me.cmbHasReveal.FormattingEnabled = True
        Me.cmbHasReveal.Location = New System.Drawing.Point(229, 545)
        Me.cmbHasReveal.Name = "cmbHasReveal"
        Me.cmbHasReveal.Size = New System.Drawing.Size(121, 21)
        Me.cmbHasReveal.TabIndex = 42
        '
        'GroupCorner
        '
        Me.GroupCorner.Location = New System.Drawing.Point(20, 108)
        Me.GroupCorner.Name = "GroupCorner"
        Me.GroupCorner.Size = New System.Drawing.Size(389, 238)
        Me.GroupCorner.TabIndex = 43
        Me.GroupCorner.TabStop = False
        Me.GroupCorner.Text = "Corner Information"
        '
        'GroupWall
        '
        Me.GroupWall.Controls.Add(Me.Button6)
        Me.GroupWall.Controls.Add(Me.Button4)
        Me.GroupWall.Controls.Add(Me.Button5)
        Me.GroupWall.Location = New System.Drawing.Point(20, 392)
        Me.GroupWall.Name = "GroupWall"
        Me.GroupWall.Size = New System.Drawing.Size(389, 344)
        Me.GroupWall.TabIndex = 44
        Me.GroupWall.TabStop = False
        Me.GroupWall.Text = "Wall Information"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(35, 266)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Add Wall"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(132, 266)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(235, 266)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 47
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 760)
        Me.Controls.Add(Me.cmbHasReveal)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtRevealHeight)
        Me.Controls.Add(Me.txtBaseboardHeight)
        Me.Controls.Add(Me.txtWallWidth)
        Me.Controls.Add(Me.txtRightCorner)
        Me.Controls.Add(Me.txtLeftCorner)
        Me.Controls.Add(Me.txtWallDesc)
        Me.Controls.Add(Me.txtWallName)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHeightFF)
        Me.Controls.Add(Me.txtRsDistance)
        Me.Controls.Add(Me.txtLsDistance)
        Me.Controls.Add(Me.txtCornerDesc)
        Me.Controls.Add(Me.txtCornerName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxRooms)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupCorner)
        Me.Controls.Add(Me.GroupWall)
        Me.Name = "frmRooms"
        Me.Text = "frmRooms"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupWall.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxRooms As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCornerName As TextBox
    Friend WithEvents txtCornerDesc As TextBox
    Friend WithEvents txtLsDistance As TextBox
    Friend WithEvents txtRsDistance As TextBox
    Friend WithEvents txtHeightFF As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txtWallName As TextBox
    Friend WithEvents txtWallDesc As TextBox
    Friend WithEvents txtLeftCorner As TextBox
    Friend WithEvents txtRightCorner As TextBox
    Friend WithEvents txtWallWidth As TextBox
    Friend WithEvents txtBaseboardHeight As TextBox
    Friend WithEvents txtRevealHeight As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txt As TextBox
    Friend WithEvents cmbHasReveal As ComboBox
    Friend WithEvents GroupCorner As GroupBox
    Friend WithEvents GroupWall As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
