Namespace dx_sample
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.nwindDataSet1 = New dx_sample.nwindDataSet()
			Me.customersTableAdapter = New dx_sample.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.ordersTableAdapter = New dx_sample.nwindDataSetTableAdapters.OrdersTableAdapter()
			Me.xrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrControlStyle2 = New DevExpress.XtraReports.UI.XRControlStyle()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrSubreport1, Me.xrLabel1})
			Me.Detail.HeightF = 23F
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
			' 
			' xrSubreport1
			' 
			Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(100F, 0F)
			Me.xrSubreport1.Name = "xrSubreport1"
			Me.xrSubreport1.ReportSource = New dx_sample.XtraReport2()
			Me.xrSubreport1.SizeF = New System.Drawing.SizeF(100F, 23F)
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.xrSubreport1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrSubreport1_BeforePrint);
			' 
			' xrLabel1
			' 
			Me.xrLabel1.CanGrow = False
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomerID")})
			Me.xrLabel1.EvenStyleName = "xrControlStyle2"
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.OddStyleName = "xrControlStyle1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel1.StylePriority.UseBackColor = False
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' xrControlStyle1
			' 
			Me.xrControlStyle1.BackColor = System.Drawing.Color.LightCyan
			Me.xrControlStyle1.Name = "xrControlStyle1"
			Me.xrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			' 
			' xrControlStyle2
			' 
			Me.xrControlStyle2.BackColor = System.Drawing.Color.LightSteelBlue
			Me.xrControlStyle2.Name = "xrControlStyle2"
			Me.xrControlStyle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
			Me.DataAdapter = Me.customersTableAdapter
			Me.DataMember = "Customers"
			Me.DataSource = Me.nwindDataSet1
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.xrControlStyle1, Me.xrControlStyle2})
			Me.Version = "12.1"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private nwindDataSet1 As nwindDataSet
		Private customersTableAdapter As nwindDataSetTableAdapters.CustomersTableAdapter
		Private ordersTableAdapter As nwindDataSetTableAdapters.OrdersTableAdapter
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
		Private xrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
		Private xrControlStyle2 As DevExpress.XtraReports.UI.XRControlStyle
	End Class
End Namespace
