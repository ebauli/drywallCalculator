<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRoomDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DrywallDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DrywallDataSet1 = New DrywallCalculator.drywallDataSet1()
        Me.DataTable2TableAdapter = New DrywallCalculator.drywallDataSet1TableAdapters.DataTable2TableAdapter()
        Me.DataTable1TableAdapter = New DrywallCalculator.drywallDataSet1TableAdapters.DataTable1TableAdapter()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrywallDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrywallDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DrywallDataSet1BindingSource
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.DrywallDataSet1BindingSource
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "DataSet1"
        ReportDataSource5.Value = Me.DataTable1BindingSource
        ReportDataSource6.Name = "DataSet2"
        ReportDataSource6.Value = Me.DataTable2BindingSource
        ReportDataSource7.Name = "DataTable1"
        ReportDataSource7.Value = Me.DataTable1BindingSource
        ReportDataSource8.Name = "DataTable2"
        ReportDataSource8.Value = Me.DataTable2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DrywallCalculator.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1043, 406)
        Me.ReportViewer1.TabIndex = 0
        '
        'DrywallDataSet1BindingSource
        '
        Me.DrywallDataSet1BindingSource.DataSource = Me.DrywallDataSet1
        Me.DrywallDataSet1BindingSource.Position = 0
        '
        'DrywallDataSet1
        '
        Me.DrywallDataSet1.DataSetName = "drywallDataSet1"
        Me.DrywallDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'frmRoomDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 406)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRoomDetails"
        Me.Text = "frmRoomDetails"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrywallDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrywallDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DrywallDataSet1BindingSource As BindingSource
    Friend WithEvents DrywallDataSet1 As drywallDataSet1
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable2BindingSource As BindingSource
    Friend WithEvents DataTable2TableAdapter As drywallDataSet1TableAdapters.DataTable2TableAdapter
    Friend WithEvents DataTable1TableAdapter As drywallDataSet1TableAdapters.DataTable1TableAdapter
End Class
