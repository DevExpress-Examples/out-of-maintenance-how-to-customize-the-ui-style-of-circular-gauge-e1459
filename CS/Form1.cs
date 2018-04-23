using System;
using System.Windows.Forms;
using DevExpress.XtraGauges.Core.Model;
using System.Collections.Generic;
using DevExpress.XtraGauges.Core.Drawing;
using System.Drawing;
using DevExpress.XtraGauges.Core.Base;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        TextShape txt;

        public Form1() {
            InitializeComponent();
            arcScale.ValueChanged += OnScaleValueChanged;
            txt = CreateCustomTextualMarker((ComplexShape)marker.Shape);
            UpdateGauge();
        }
        TextShape CreateCustomTextualMarker(ComplexShape markerShape) {
            RectangleF2D box = new RectangleF2D(-15, -15, 30, 30);
            
            EllipseShape eShape = new EllipseShape(box);
            TextShape txt = new TextShape();
            
            eShape.BeginUpdate();
            eShape.Name = "bg";
            eShape.Appearance.ContentBrush = new SolidBrushObject(Color.White);
            eShape.Appearance.BorderBrush = new SolidBrushObject(Color.Black);
            eShape.Appearance.BorderWidth = 2;
            eShape.EndUpdate();

            txt.BeginUpdate();
            txt.Name = "marketText";
            txt.Text = "Test";
            txt.Box = box;
            txt.AppearanceText.TextBrush = new SolidBrushObject(Color.Black);
            txt.AppearanceText.Font = new Font("Tahoma", 8f);
            txt.ShadingFlags = ShadingFlags.NoShading;
            txt.EndUpdate();

            markerShape.AddRange(new BaseShape[] { eShape, txt });
            return txt;
        }
        void OnCustomTickmarkText(CustomTickmarkTextEventArgs ea) {
            if(ea.Value == arcScale.MinValue || ea.Value == arcScale.MaxValue) return;
            ea.Result = string.Empty;
        }
        void trackBar1_ValueChanged(object sender, EventArgs e) {
            UpdateGauge();
        }
        void UpdateGauge() {
            arcScale.Value = trackBar1.Value;
        }
        void OnScaleValueChanged(object sender, EventArgs e) {
            leftRange.AnchorValue = Math.Max(arcScale.MinValue, arcScale.Value - 10);
            rightRange.AnchorValue = Math.Min(arcScale.MaxValue, arcScale.Value + 10);
            txt.Text = string.Format("{0:P0}", arcScale.Percent);
        }
    }
}