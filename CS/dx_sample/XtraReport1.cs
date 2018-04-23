using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using System.Collections.Generic;
using System.Data;

namespace dx_sample {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        Dictionary<string, float> sections = new Dictionary<string,float>();
        public XtraReport1() {
            InitializeComponent();
        }
        bool documentBuilt = false;
        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            ((XRSubreport)sender).ReportSource.Parameters[0].Value = GetCurrentColumnValue("CustomerID").ToString();
        }
        public void CreateCustomDocument() {
            CreateDocument();
            documentBuilt = true;
            CreateDocument();
        }
        protected override void AfterReportPrint() {
            if (documentBuilt) return;
            foreach (DevExpress.XtraPrinting.Page page in Pages) {
                foreach (Brick brick in page) {
                    LabelBrick labelBrick = brick as LabelBrick;
                    if (labelBrick != null && labelBrick.Value != null && labelBrick.Value.ToString() != string.Empty) {
                        ((XRLabel)labelBrick.BrickOwner.RealControl).BackColor = Color.LightGreen;
                        if (sections.ContainsKey(labelBrick.Value.ToString()))
                            sections[labelBrick.Value.ToString()] += labelBrick.Size.Height;
                        else
                            sections.Add(labelBrick.Value.ToString(), labelBrick.Size.Height);
                    }
                }
            }
        }
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            string customerID = GetCurrentColumnValue("CustomerID").ToString();
            if (((XtraReport)xrSubreport1.ReportSource).Parameters.Count > 0)
                ((XtraReport) xrSubreport1.ReportSource).Parameters[0].Value = customerID;
            xrSubreport1.ReportSource.FillDataSource();
            xrSubreport1.ReportSource.ApplyFiltering();
            if (xrSubreport1.ReportSource.RowCount == 0) {
                e.Cancel = true;
                return;
            }
            if (!documentBuilt) return;
            if (!sections.ContainsKey(customerID))
                System.Diagnostics.Debug.WriteLine(customerID + " not found."); //  Not executed.
            else {
                xrLabel1.HeightF = 100 * GraphicsUnitConverter.Convert(sections[customerID], GraphicsUnit.Document, GraphicsUnit.Inch);
                ((DetailBand)sender).HeightF = 100 * GraphicsUnitConverter.Convert(sections[customerID], GraphicsUnit.Document, GraphicsUnit.Inch);
            }
        }
    }
}
