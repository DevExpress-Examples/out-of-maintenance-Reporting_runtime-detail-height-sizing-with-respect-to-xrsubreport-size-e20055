Imports Microsoft.VisualBasic
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace dx_sample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim reportPrintTool As New ReportPrintTool(New XtraReport1())
			TryCast(reportPrintTool.Report, XtraReport1).CreateCustomDocument()
			reportPrintTool.ShowPreviewDialog()
		End Sub
	End Class
End Namespace
