using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Infragistics.UltraChart.Resources;
using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using Infragistics.Win.UltraWinChart;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class frmDrawGraph : InheritedForm
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("UltraChart1")]
	private UltraChart _UltraChart1;

	private virtual UltraChart UltraChart1
	{
		[DebuggerNonUserCode]
		get
		{
			return _UltraChart1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UltraChart1 = value;
		}
	}

	[DebuggerNonUserCode]
	public frmDrawGraph()
	{
		__ENCList.Add(new WeakReference(this));
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected O, but got Unknown
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected O, but got Unknown
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected O, but got Unknown
		//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Expected O, but got Unknown
		//IL_0cd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce1: Expected O, but got Unknown
		//IL_0d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da3: Expected O, but got Unknown
		//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd5: Expected O, but got Unknown
		//IL_108d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1097: Expected O, but got Unknown
		GradientEffect val = new GradientEffect();
		UltraChart1 = new UltraChart();
		((ISupportInitialize)UltraChart1).BeginInit();
		((Control)this).SuspendLayout();
		UltraChart1.set_ChartType((ChartType)3);
		UltraChart1.get_Axis().set_BackColor(Color.FromArgb(255, 248, 220));
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X().get_Labels()).set_Font(new Font("Verdana", 7f));
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X().get_Labels()).set_FontColor(Color.DimGray);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X().get_Labels()).set_HorizontalAlign((StringAlignment)0);
		UltraChart1.get_Axis().get_X().get_Labels()
			.set_ItemFormatString("<ITEM_LABEL>");
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X().get_Labels()).get_Layout().set_Behavior((AxisLabelLayoutBehaviors)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X().get_Labels()).set_Orientation((TextOrientation)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X().get_Labels()
			.get_SeriesLabels()).set_Font(new Font("Verdana", 7f));
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X().get_Labels()
			.get_SeriesLabels()).set_FontColor(Color.DimGray);
		UltraChart1.get_Axis().get_X().get_Labels()
			.get_SeriesLabels()
			.set_FormatString("");
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X().get_Labels()
			.get_SeriesLabels()).set_HorizontalAlign((StringAlignment)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X().get_Labels()
			.get_SeriesLabels()).get_Layout().set_Behavior((AxisLabelLayoutBehaviors)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X().get_Labels()
			.get_SeriesLabels()).set_Orientation((TextOrientation)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X().get_Labels()
			.get_SeriesLabels()).set_VerticalAlign((StringAlignment)1);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X().get_Labels()).set_VerticalAlign((StringAlignment)1);
		UltraChart1.get_Axis().get_X().set_LineThickness(1);
		UltraChart1.get_Axis().get_X().get_MajorGridLines()
			.set_AlphaLevel(byte.MaxValue);
		UltraChart1.get_Axis().get_X().get_MajorGridLines()
			.set_Color(Color.Gainsboro);
		UltraChart1.get_Axis().get_X().get_MajorGridLines()
			.set_DrawStyle((LineDrawStyle)4);
		UltraChart1.get_Axis().get_X().get_MajorGridLines()
			.set_Visible(true);
		UltraChart1.get_Axis().get_X().get_MinorGridLines()
			.set_AlphaLevel(byte.MaxValue);
		UltraChart1.get_Axis().get_X().get_MinorGridLines()
			.set_Color(Color.LightGray);
		UltraChart1.get_Axis().get_X().get_MinorGridLines()
			.set_DrawStyle((LineDrawStyle)4);
		UltraChart1.get_Axis().get_X().get_MinorGridLines()
			.set_Visible(false);
		UltraChart1.get_Axis().get_X().set_TickmarkStyle((AxisTickStyle)2);
		UltraChart1.get_Axis().get_X().set_Visible(true);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X2().get_Labels()).set_Font(new Font("Verdana", 7f));
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X2().get_Labels()).set_FontColor(Color.Gray);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X2().get_Labels()).set_HorizontalAlign((StringAlignment)2);
		UltraChart1.get_Axis().get_X2().get_Labels()
			.set_ItemFormatString("<ITEM_LABEL>");
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X2().get_Labels()).get_Layout().set_Behavior((AxisLabelLayoutBehaviors)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X2().get_Labels()).set_Orientation((TextOrientation)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X2().get_Labels()
			.get_SeriesLabels()).set_Font(new Font("Verdana", 7f));
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X2().get_Labels()
			.get_SeriesLabels()).set_FontColor(Color.Gray);
		UltraChart1.get_Axis().get_X2().get_Labels()
			.get_SeriesLabels()
			.set_FormatString("");
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X2().get_Labels()
			.get_SeriesLabels()).set_HorizontalAlign((StringAlignment)2);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X2().get_Labels()
			.get_SeriesLabels()).get_Layout().set_Behavior((AxisLabelLayoutBehaviors)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X2().get_Labels()
			.get_SeriesLabels()).set_Orientation((TextOrientation)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X2().get_Labels()
			.get_SeriesLabels()).set_VerticalAlign((StringAlignment)1);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X2().get_Labels()).set_VerticalAlign((StringAlignment)1);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_X2().get_Labels()).set_Visible(false);
		UltraChart1.get_Axis().get_X2().set_LineThickness(1);
		UltraChart1.get_Axis().get_X2().get_MajorGridLines()
			.set_AlphaLevel(byte.MaxValue);
		UltraChart1.get_Axis().get_X2().get_MajorGridLines()
			.set_Color(Color.Gainsboro);
		UltraChart1.get_Axis().get_X2().get_MajorGridLines()
			.set_DrawStyle((LineDrawStyle)4);
		UltraChart1.get_Axis().get_X2().get_MajorGridLines()
			.set_Visible(true);
		UltraChart1.get_Axis().get_X2().get_MinorGridLines()
			.set_AlphaLevel(byte.MaxValue);
		UltraChart1.get_Axis().get_X2().get_MinorGridLines()
			.set_Color(Color.LightGray);
		UltraChart1.get_Axis().get_X2().get_MinorGridLines()
			.set_DrawStyle((LineDrawStyle)4);
		UltraChart1.get_Axis().get_X2().get_MinorGridLines()
			.set_Visible(false);
		UltraChart1.get_Axis().get_X2().set_TickmarkStyle((AxisTickStyle)2);
		UltraChart1.get_Axis().get_X2().set_Visible(false);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y().get_Labels()).set_Font(new Font("Verdana", 7f));
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y().get_Labels()).set_FontColor(Color.DimGray);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y().get_Labels()).set_HorizontalAlign((StringAlignment)2);
		UltraChart1.get_Axis().get_Y().get_Labels()
			.set_ItemFormatString("<DATA_VALUE:00.##>");
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y().get_Labels()).get_Layout().set_Behavior((AxisLabelLayoutBehaviors)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y().get_Labels()).set_Orientation((TextOrientation)2);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y().get_Labels()
			.get_SeriesLabels()).set_Font(new Font("Verdana", 7f));
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y().get_Labels()
			.get_SeriesLabels()).set_FontColor(Color.DimGray);
		UltraChart1.get_Axis().get_Y().get_Labels()
			.get_SeriesLabels()
			.set_FormatString("");
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y().get_Labels()
			.get_SeriesLabels()).set_HorizontalAlign((StringAlignment)2);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y().get_Labels()
			.get_SeriesLabels()).get_Layout().set_Behavior((AxisLabelLayoutBehaviors)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y().get_Labels()
			.get_SeriesLabels()).set_Orientation((TextOrientation)2);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y().get_Labels()
			.get_SeriesLabels()).set_VerticalAlign((StringAlignment)1);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y().get_Labels()).set_VerticalAlign((StringAlignment)1);
		UltraChart1.get_Axis().get_Y().set_LineThickness(1);
		UltraChart1.get_Axis().get_Y().get_MajorGridLines()
			.set_AlphaLevel(byte.MaxValue);
		UltraChart1.get_Axis().get_Y().get_MajorGridLines()
			.set_Color(Color.Gainsboro);
		UltraChart1.get_Axis().get_Y().get_MajorGridLines()
			.set_DrawStyle((LineDrawStyle)4);
		UltraChart1.get_Axis().get_Y().get_MajorGridLines()
			.set_Visible(true);
		UltraChart1.get_Axis().get_Y().get_MinorGridLines()
			.set_AlphaLevel(byte.MaxValue);
		UltraChart1.get_Axis().get_Y().get_MinorGridLines()
			.set_Color(Color.LightGray);
		UltraChart1.get_Axis().get_Y().get_MinorGridLines()
			.set_DrawStyle((LineDrawStyle)4);
		UltraChart1.get_Axis().get_Y().get_MinorGridLines()
			.set_Visible(false);
		UltraChart1.get_Axis().get_Y().set_TickmarkInterval(40.0);
		UltraChart1.get_Axis().get_Y().set_TickmarkStyle((AxisTickStyle)2);
		UltraChart1.get_Axis().get_Y().set_Visible(true);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y2().get_Labels()).set_Font(new Font("Verdana", 7f));
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y2().get_Labels()).set_FontColor(Color.Gray);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y2().get_Labels()).set_HorizontalAlign((StringAlignment)0);
		UltraChart1.get_Axis().get_Y2().get_Labels()
			.set_ItemFormatString("<DATA_VALUE:00.##>");
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y2().get_Labels()).get_Layout().set_Behavior((AxisLabelLayoutBehaviors)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y2().get_Labels()).set_Orientation((TextOrientation)2);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y2().get_Labels()
			.get_SeriesLabels()).set_Font(new Font("Verdana", 7f));
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y2().get_Labels()
			.get_SeriesLabels()).set_FontColor(Color.Gray);
		UltraChart1.get_Axis().get_Y2().get_Labels()
			.get_SeriesLabels()
			.set_FormatString("");
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y2().get_Labels()
			.get_SeriesLabels()).set_HorizontalAlign((StringAlignment)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y2().get_Labels()
			.get_SeriesLabels()).get_Layout().set_Behavior((AxisLabelLayoutBehaviors)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y2().get_Labels()
			.get_SeriesLabels()).set_Orientation((TextOrientation)2);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y2().get_Labels()
			.get_SeriesLabels()).set_VerticalAlign((StringAlignment)1);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y2().get_Labels()).set_VerticalAlign((StringAlignment)1);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Y2().get_Labels()).set_Visible(false);
		UltraChart1.get_Axis().get_Y2().set_LineThickness(1);
		UltraChart1.get_Axis().get_Y2().get_MajorGridLines()
			.set_AlphaLevel(byte.MaxValue);
		UltraChart1.get_Axis().get_Y2().get_MajorGridLines()
			.set_Color(Color.Gainsboro);
		UltraChart1.get_Axis().get_Y2().get_MajorGridLines()
			.set_DrawStyle((LineDrawStyle)4);
		UltraChart1.get_Axis().get_Y2().get_MajorGridLines()
			.set_Visible(true);
		UltraChart1.get_Axis().get_Y2().get_MinorGridLines()
			.set_AlphaLevel(byte.MaxValue);
		UltraChart1.get_Axis().get_Y2().get_MinorGridLines()
			.set_Color(Color.LightGray);
		UltraChart1.get_Axis().get_Y2().get_MinorGridLines()
			.set_DrawStyle((LineDrawStyle)4);
		UltraChart1.get_Axis().get_Y2().get_MinorGridLines()
			.set_Visible(false);
		UltraChart1.get_Axis().get_Y2().set_TickmarkInterval(40.0);
		UltraChart1.get_Axis().get_Y2().set_TickmarkStyle((AxisTickStyle)2);
		UltraChart1.get_Axis().get_Y2().set_Visible(false);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z().get_Labels()).set_Font(new Font("Verdana", 7f));
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z().get_Labels()).set_FontColor(Color.DimGray);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z().get_Labels()).set_HorizontalAlign((StringAlignment)0);
		UltraChart1.get_Axis().get_Z().get_Labels()
			.set_ItemFormatString("");
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z().get_Labels()).get_Layout().set_Behavior((AxisLabelLayoutBehaviors)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z().get_Labels()).set_Orientation((TextOrientation)2);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z().get_Labels()
			.get_SeriesLabels()).set_Font(new Font("Verdana", 7f));
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z().get_Labels()
			.get_SeriesLabels()).set_FontColor(Color.DimGray);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z().get_Labels()
			.get_SeriesLabels()).set_HorizontalAlign((StringAlignment)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z().get_Labels()
			.get_SeriesLabels()).get_Layout().set_Behavior((AxisLabelLayoutBehaviors)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z().get_Labels()
			.get_SeriesLabels()).set_Orientation((TextOrientation)2);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z().get_Labels()
			.get_SeriesLabels()).set_VerticalAlign((StringAlignment)1);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z().get_Labels()).set_VerticalAlign((StringAlignment)1);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z().get_Labels()).set_Visible(false);
		UltraChart1.get_Axis().get_Z().set_LineThickness(1);
		UltraChart1.get_Axis().get_Z().get_MajorGridLines()
			.set_AlphaLevel(byte.MaxValue);
		UltraChart1.get_Axis().get_Z().get_MajorGridLines()
			.set_Color(Color.Gainsboro);
		UltraChart1.get_Axis().get_Z().get_MajorGridLines()
			.set_DrawStyle((LineDrawStyle)4);
		UltraChart1.get_Axis().get_Z().get_MajorGridLines()
			.set_Visible(true);
		UltraChart1.get_Axis().get_Z().get_MinorGridLines()
			.set_AlphaLevel(byte.MaxValue);
		UltraChart1.get_Axis().get_Z().get_MinorGridLines()
			.set_Color(Color.LightGray);
		UltraChart1.get_Axis().get_Z().get_MinorGridLines()
			.set_DrawStyle((LineDrawStyle)4);
		UltraChart1.get_Axis().get_Z().get_MinorGridLines()
			.set_Visible(false);
		UltraChart1.get_Axis().get_Z().set_TickmarkStyle((AxisTickStyle)2);
		UltraChart1.get_Axis().get_Z().set_Visible(false);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z2().get_Labels()).set_Font(new Font("Verdana", 7f));
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z2().get_Labels()).set_FontColor(Color.Gray);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z2().get_Labels()).set_HorizontalAlign((StringAlignment)0);
		UltraChart1.get_Axis().get_Z2().get_Labels()
			.set_ItemFormatString("");
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z2().get_Labels()).get_Layout().set_Behavior((AxisLabelLayoutBehaviors)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z2().get_Labels()).set_Orientation((TextOrientation)2);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z2().get_Labels()
			.get_SeriesLabels()).set_Font(new Font("Verdana", 7f));
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z2().get_Labels()
			.get_SeriesLabels()).set_FontColor(Color.Gray);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z2().get_Labels()
			.get_SeriesLabels()).set_HorizontalAlign((StringAlignment)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z2().get_Labels()
			.get_SeriesLabels()).get_Layout().set_Behavior((AxisLabelLayoutBehaviors)0);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z2().get_Labels()
			.get_SeriesLabels()).set_Orientation((TextOrientation)2);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z2().get_Labels()
			.get_SeriesLabels()).set_VerticalAlign((StringAlignment)1);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z2().get_Labels()).set_VerticalAlign((StringAlignment)1);
		((AxisLabelAppearanceBase)UltraChart1.get_Axis().get_Z2().get_Labels()).set_Visible(false);
		UltraChart1.get_Axis().get_Z2().set_LineThickness(1);
		UltraChart1.get_Axis().get_Z2().get_MajorGridLines()
			.set_AlphaLevel(byte.MaxValue);
		UltraChart1.get_Axis().get_Z2().get_MajorGridLines()
			.set_Color(Color.Gainsboro);
		UltraChart1.get_Axis().get_Z2().get_MajorGridLines()
			.set_DrawStyle((LineDrawStyle)4);
		UltraChart1.get_Axis().get_Z2().get_MajorGridLines()
			.set_Visible(true);
		UltraChart1.get_Axis().get_Z2().get_MinorGridLines()
			.set_AlphaLevel(byte.MaxValue);
		UltraChart1.get_Axis().get_Z2().get_MinorGridLines()
			.set_Color(Color.LightGray);
		UltraChart1.get_Axis().get_Z2().get_MinorGridLines()
			.set_DrawStyle((LineDrawStyle)4);
		UltraChart1.get_Axis().get_Z2().get_MinorGridLines()
			.set_Visible(false);
		UltraChart1.get_Axis().get_Z2().set_TickmarkStyle((AxisTickStyle)2);
		UltraChart1.get_Axis().get_Z2().set_Visible(false);
		UltraChart1.get_ColorModel().set_AlphaLevel((byte)150);
		UltraChart1.get_ColorModel().set_ModelStyle((ColorModels)4);
		((Control)UltraChart1).set_Dock((DockStyle)5);
		UltraChart1.get_Effects().get_Effects().Add((IEffect)(object)val);
		UltraChart1.get_Legend().set_Visible(true);
		UltraChart ultraChart = UltraChart1;
		Point location = new Point(0, 0);
		((Control)ultraChart).set_Location(location);
		((Control)UltraChart1).set_Name("UltraChart1");
		UltraChart ultraChart2 = UltraChart1;
		Size size = new Size(709, 423);
		((Control)ultraChart2).set_Size(size);
		UltraChart1.set_TabIndex(0);
		UltraChart1.get_Tooltips().set_HighlightFillColor(Color.DimGray);
		UltraChart1.get_Tooltips().set_HighlightOutlineColor(Color.DarkGray);
		UltraChart1.get_Tooltips().set_TooltipControl((Control)null);
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		size = new Size(709, 423);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)UltraChart1);
		((Control)this).set_Name("frmDrawGraph");
		((ISupportInitialize)UltraChart1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
