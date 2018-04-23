namespace WindowsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange1 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange2 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.marker = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent();
            this.arcScale = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.leftRange = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.rightRange = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(12, 12);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(260, 260);
            this.gaugeControl1.TabIndex = 0;
            // 
            // circularGauge1
            // 
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 248, 248);
            this.circularGauge1.Markers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent[] {
            this.marker});
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
            this.circularGauge1.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.leftRange,
            this.rightRange});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScale});
            // 
            // marker
            // 
            this.marker.ArcScale = this.arcScale;
            this.marker.Name = "whiteMarker";
            this.marker.ShapeType = DevExpress.XtraGauges.Core.Model.MarkerPointerShapeType.Circle;
            this.marker.ZOrder = -100;
            // 
            // arcScale
            // 
            this.arcScale.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 11F);
            this.arcScale.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScale.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F);
            this.arcScale.EndAngle = 0F;
            this.arcScale.MajorTickCount = 21;
            this.arcScale.MajorTickmark.FormatString = "{0:F0}";
            this.arcScale.MajorTickmark.ShapeOffset = -3.5F;
            this.arcScale.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4;
            this.arcScale.MajorTickmark.ShowTick = false;
            this.arcScale.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScale.MaxValue = 100F;
            this.arcScale.MinorTickCount = 4;
            this.arcScale.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3;
            this.arcScale.MinorTickmark.ShowTick = false;
            this.arcScale.Name = "scale1";
            arcScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Green");
            arcScaleRange1.EndThickness = 6F;
            arcScaleRange1.EndValue = 45F;
            arcScaleRange1.Name = "RangeGood";
            arcScaleRange1.ShapeOffset = 0F;
            arcScaleRange1.StartThickness = 6F;
            arcScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000");
            arcScaleRange2.EndThickness = 6F;
            arcScaleRange2.EndValue = 100F;
            arcScaleRange2.Name = "RangeBad";
            arcScaleRange2.ShapeOffset = 0F;
            arcScaleRange2.StartThickness = 6F;
            arcScaleRange2.StartValue = 45F;
            this.arcScale.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange1,
            arcScaleRange2});
            this.arcScale.StartAngle = -180F;
            this.arcScale.Value = 35F;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScale;
            this.arcScaleNeedleComponent1.EndOffset = 15F;
            this.arcScaleNeedleComponent1.Name = "needle";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style11;
            this.arcScaleNeedleComponent1.StartOffset = -8F;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // leftRange
            // 
            this.leftRange.AppearanceRangeBar.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#80FF80FF");
            this.leftRange.ArcScale = this.arcScale;
            this.leftRange.EndOffset = 0F;
            this.leftRange.Name = "leftRange";
            this.leftRange.ZOrder = -10;
            // 
            // rightRange
            // 
            this.rightRange.AnchorValue = 100F;
            this.rightRange.AppearanceRangeBar.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#80FF80FF");
            this.rightRange.ArcScale = this.arcScale;
            this.rightRange.EndOffset = 0F;
            this.rightRange.Name = "rightRange";
            this.rightRange.ZOrder = -10;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 278);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(260, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 349);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.gaugeControl1);
            this.Name = "Form1";
            this.Text = "How to customize the UI style of Circular Gauge";
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private System.Windows.Forms.TrackBar trackBar1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScale;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent marker;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent leftRange;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent rightRange;
    }
}

