Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
Imports System.Collections.Generic
Imports System.Data

Namespace dx_sample
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Private sections As New Dictionary(Of String, Single)()
		Public Sub New()
			InitializeComponent()
		End Sub
		Private documentBuilt As Boolean = False
		Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubreport1.BeforePrint
			CType(sender, XRSubreport).ReportSource.Parameters(0).Value = GetCurrentColumnValue("CustomerID").ToString()
		End Sub
		Public Sub CreateCustomDocument()
			CreateDocument()
			documentBuilt = True
			CreateDocument()
		End Sub
		Protected Overrides Sub AfterReportPrint()
			If documentBuilt Then
				Return
			End If
			For Each page As DevExpress.XtraPrinting.Page In Pages
				For Each brick As Brick In page
					Dim labelBrick As LabelBrick = TryCast(brick, LabelBrick)
					If labelBrick IsNot Nothing AndAlso labelBrick.Value IsNot Nothing AndAlso labelBrick.Value.ToString() <> String.Empty Then
						CType(labelBrick.BrickOwner.RealControl, XRLabel).BackColor = Color.LightGreen
						If sections.ContainsKey(labelBrick.Value.ToString()) Then
							sections(labelBrick.Value.ToString()) += labelBrick.Size.Height
						Else
							sections.Add(labelBrick.Value.ToString(), labelBrick.Size.Height)
						End If
					End If
				Next brick
			Next page
		End Sub
		Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
			Dim customerID As String = GetCurrentColumnValue("CustomerID").ToString()
			If (CType(xrSubreport1.ReportSource, XtraReport)).Parameters.Count > 0 Then
				CType(xrSubreport1.ReportSource, XtraReport).Parameters(0).Value = customerID
			End If
			xrSubreport1.ReportSource.FillDataSource()
			xrSubreport1.ReportSource.ApplyFiltering()
			If xrSubreport1.ReportSource.RowCount = 0 Then
				e.Cancel = True
				Return
			End If
			If (Not documentBuilt) Then
				Return
			End If
			If (Not sections.ContainsKey(customerID)) Then
				System.Diagnostics.Debug.WriteLine(customerID & " not found.") ' Not executed.
			Else
				xrLabel1.HeightF = 100 * GraphicsUnitConverter.Convert(sections(customerID), GraphicsUnit.Document, GraphicsUnit.Inch)
				CType(sender, DetailBand).HeightF = 100 * GraphicsUnitConverter.Convert(sections(customerID), GraphicsUnit.Document, GraphicsUnit.Inch)
			End If
		End Sub
	End Class
End Namespace
