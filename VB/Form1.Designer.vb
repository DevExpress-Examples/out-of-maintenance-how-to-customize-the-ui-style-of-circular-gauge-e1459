Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim arcScaleRange1 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim arcScaleRange2 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.marker = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent()
			Me.arcScale = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.leftRange = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
			Me.rightRange = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
			Me.trackBar1 = New System.Windows.Forms.TrackBar()
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.marker, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScale, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.leftRange, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rightRange, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge1})
			Me.gaugeControl1.Location = New System.Drawing.Point(12, 12)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(260, 260)
			Me.gaugeControl1.TabIndex = 0
			' 
			' circularGauge1
			' 
			Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 248, 248)
			Me.circularGauge1.Markers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent() { Me.marker})
			Me.circularGauge1.Name = "circularGauge1"
			Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent1})
			Me.circularGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent() { Me.leftRange, Me.rightRange})
			Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScale})
			' 
			' marker
			' 
			Me.marker.ArcScale = Me.arcScale
			Me.marker.Name = "whiteMarker"
			Me.marker.ShapeType = DevExpress.XtraGauges.Core.Model.MarkerPointerShapeType.Circle
			Me.marker.ZOrder = -100
			' 
			' arcScale
			' 
			Me.arcScale.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 11F)
			Me.arcScale.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.arcScale.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
			Me.arcScale.EndAngle = 0F
			Me.arcScale.MajorTickCount = 21
			Me.arcScale.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScale.MajorTickmark.ShapeOffset = -3.5F
			Me.arcScale.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
			Me.arcScale.MajorTickmark.ShowTick = False
			Me.arcScale.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScale.MaxValue = 100F
			Me.arcScale.MinorTickCount = 4
			Me.arcScale.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
			Me.arcScale.MinorTickmark.ShowTick = False
			Me.arcScale.Name = "scale1"
			arcScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Green")
			arcScaleRange1.EndThickness = 6F
			arcScaleRange1.EndValue = 45F
			arcScaleRange1.Name = "RangeGood"
			arcScaleRange1.ShapeOffset = 0F
			arcScaleRange1.StartThickness = 6F
			arcScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
			arcScaleRange2.EndThickness = 6F
			arcScaleRange2.EndValue = 100F
			arcScaleRange2.Name = "RangeBad"
			arcScaleRange2.ShapeOffset = 0F
			arcScaleRange2.StartThickness = 6F
			arcScaleRange2.StartValue = 45F
			Me.arcScale.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() { arcScaleRange1, arcScaleRange2})
			Me.arcScale.StartAngle = -180F
			Me.arcScale.Value = 35F
			' 
			' arcScaleNeedleComponent1
			' 
			Me.arcScaleNeedleComponent1.ArcScale = Me.arcScale
			Me.arcScaleNeedleComponent1.EndOffset = 15F
			Me.arcScaleNeedleComponent1.Name = "needle"
			Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style11
			Me.arcScaleNeedleComponent1.StartOffset = -8F
			Me.arcScaleNeedleComponent1.ZOrder = -50
			' 
			' leftRange
			' 
			Me.leftRange.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#80FF80FF")
			Me.leftRange.ArcScale = Me.arcScale
			Me.leftRange.EndOffset = 0F
			Me.leftRange.Name = "leftRange"
			Me.leftRange.ZOrder = -10
			' 
			' rightRange
			' 
			Me.rightRange.AnchorValue = 100F
			Me.rightRange.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#80FF80FF")
			Me.rightRange.ArcScale = Me.arcScale
			Me.rightRange.EndOffset = 0F
			Me.rightRange.Name = "rightRange"
			Me.rightRange.ZOrder = -10
			' 
			' trackBar1
			' 
			Me.trackBar1.Location = New System.Drawing.Point(12, 278)
			Me.trackBar1.Maximum = 100
			Me.trackBar1.Name = "trackBar1"
			Me.trackBar1.Size = New System.Drawing.Size(260, 45)
			Me.trackBar1.TabIndex = 1
			Me.trackBar1.TickFrequency = 5
'			Me.trackBar1.ValueChanged += New System.EventHandler(Me.trackBar1_ValueChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 349)
			Me.Controls.Add(Me.trackBar1)
			Me.Controls.Add(Me.gaugeControl1)
			Me.Name = "Form1"
			Me.Text = "How to customize the UI style of Circular Gauge"
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.marker, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScale, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.leftRange, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rightRange, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
		Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScale As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private marker As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent
		Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private leftRange As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
		Private rightRange As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
	End Class
End Namespace

