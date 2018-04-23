Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Core.Model
Imports System.Collections.Generic
Imports DevExpress.XtraGauges.Core.Drawing
Imports System.Drawing
Imports DevExpress.XtraGauges.Core.Base

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private txt As TextShape

		Public Sub New()
			InitializeComponent()
			AddHandler arcScale.ValueChanged, AddressOf OnScaleValueChanged
			txt = CreateCustomTextualMarker(CType(marker.Shape, ComplexShape))
			UpdateGauge()
		End Sub
		Private Function CreateCustomTextualMarker(ByVal markerShape As ComplexShape) As TextShape
			Dim box As New RectangleF2D(-15, -15, 30, 30)

			Dim eShape As New EllipseShape(box)
			Dim txt As New TextShape()

			eShape.BeginUpdate()
			eShape.Name = "bg"
			eShape.Appearance.ContentBrush = New SolidBrushObject(Color.White)
			eShape.Appearance.BorderBrush = New SolidBrushObject(Color.Black)
			eShape.Appearance.BorderWidth = 2
			eShape.EndUpdate()

			txt.BeginUpdate()
			txt.Name = "marketText"
			txt.Text = "Test"
			txt.Box = box
			txt.AppearanceText.TextBrush = New SolidBrushObject(Color.Black)
			txt.AppearanceText.Font = New Font("Tahoma", 8f)
			txt.ShadingFlags = ShadingFlags.NoShading
			txt.EndUpdate()

			markerShape.AddRange(New BaseShape() { eShape, txt })
			Return txt
		End Function
		Private Sub OnCustomTickmarkText(ByVal ea As CustomTickmarkTextEventArgs)
			If ea.Value = arcScale.MinValue OrElse ea.Value = arcScale.MaxValue Then
				Return
			End If
			ea.Result = String.Empty
		End Sub
		Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar1.ValueChanged
			UpdateGauge()
		End Sub
		Private Sub UpdateGauge()
			arcScale.Value = trackBar1.Value
		End Sub
		Private Sub OnScaleValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			leftRange.AnchorValue = Math.Max(arcScale.MinValue, arcScale.Value - 10)
			rightRange.AnchorValue = Math.Min(arcScale.MaxValue, arcScale.Value + 10)
			txt.Text = String.Format("{0:P0}", arcScale.Percent)
		End Sub
	End Class
End Namespace