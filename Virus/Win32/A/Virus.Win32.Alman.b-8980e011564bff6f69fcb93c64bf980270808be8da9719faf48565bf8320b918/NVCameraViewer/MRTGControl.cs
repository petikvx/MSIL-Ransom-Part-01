using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NVCameraViewer;

[DesignerGenerated]
public class MRTGControl : UserControl
{
	private class FlowDataClass
	{
		public long FlowIn;

		public long FlowOut;

		[DebuggerNonUserCode]
		public FlowDataClass()
		{
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	private ArrayList iFlowList;

	public MRTGControl()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		iFlowList = new ArrayList();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Control)this).set_Name("MRTGControl");
		((Control)this).ResumeLayout(false);
	}

	public void AddFlow(long FlowIn, long FlowOut)
	{
		int width = ((Control)this).get_Width();
		FlowDataClass flowDataClass = new FlowDataClass();
		flowDataClass.FlowIn = FlowIn;
		flowDataClass.FlowOut = FlowOut;
		iFlowList.Add(flowDataClass);
		checked
		{
			if (iFlowList.Count > width)
			{
				int num = iFlowList.Count - width;
				int num2 = 1;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					iFlowList.RemoveAt(0);
					num2++;
				}
			}
			UpdateGraph();
		}
	}

	public void UpdateGraph()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		Image val = (Image)new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage(val);
		int num = ((val.get_Width() <= iFlowList.Count) ? val.get_Width() : iFlowList.Count);
		val.get_Height();
		int num2 = num;
		int num3 = 1;
		checked
		{
			long num7 = default(long);
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				if (iFlowList.Count - num3 <= iFlowList.Count - 1)
				{
					FlowDataClass flowDataClass = (FlowDataClass)iFlowList[iFlowList.Count - num3];
					long num6 = ((flowDataClass.FlowOut <= flowDataClass.FlowIn) ? flowDataClass.FlowIn : flowDataClass.FlowOut);
					if (num6 > num7)
					{
						num7 = num6;
					}
				}
				num3++;
			}
			if (num7 > 0L)
			{
				int num8 = num;
				int num9 = 1;
				while (true)
				{
					int num10 = num9;
					int num5 = num8;
					if (num10 > num5)
					{
						break;
					}
					if (iFlowList.Count - num9 <= iFlowList.Count - 1)
					{
						FlowDataClass flowDataClass = (FlowDataClass)iFlowList[iFlowList.Count - num9];
						if (flowDataClass.FlowOut > flowDataClass.FlowIn)
						{
							val2.DrawLine(new Pen(Color.FromArgb(0, 80, 255)), val.get_Width() - num9, (int)Math.Round((double)val.get_Height() - (double)val.get_Height() * ((double)flowDataClass.FlowIn / (double)num7)), val.get_Width() - num9, val.get_Height());
							val2.DrawLine(new Pen(Color.FromArgb(255, 80, 0)), val.get_Width() - num9, (int)Math.Round((double)val.get_Height() - (double)val.get_Height() * ((double)flowDataClass.FlowOut / (double)num7)), val.get_Width() - num9, val.get_Height());
						}
						else
						{
							val2.DrawLine(new Pen(Color.FromArgb(255, 80, 0)), val.get_Width() - num9, (int)Math.Round((double)val.get_Height() - (double)val.get_Height() * ((double)flowDataClass.FlowOut / (double)num7)), val.get_Width() - num9, val.get_Height());
							val2.DrawLine(new Pen(Color.FromArgb(0, 80, 255)), val.get_Width() - num9, (int)Math.Round((double)val.get_Height() - (double)val.get_Height() * ((double)flowDataClass.FlowIn / (double)num7)), val.get_Width() - num9, val.get_Height());
						}
					}
					num9++;
				}
			}
			val2.DrawString(FlowText(num7), new Font("Arial", 7f), Brushes.get_Black(), 1f, 1f);
			val2.DrawString(FlowText((long)Math.Round((double)num7 / 2.0)), new Font("Arial", 7f), Brushes.get_Black(), 1f, (float)((double)val.get_Height() / 2.0 + 1.0));
			val2.DrawLine(new Pen(Color.Black), 0, (int)Math.Round((double)val.get_Height() / 2.0), val.get_Width(), (int)Math.Round((double)val.get_Height() / 2.0));
			val2.Dispose();
			((Control)this).set_BackgroundImage(val);
		}
	}

	private string FlowText(long FlowCount)
	{
		if (FlowCount > 1073741824L)
		{
			return Strings.FormatNumber((object)((double)FlowCount / 1073741824.0), 1, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + " G";
		}
		if (FlowCount > 1048576L)
		{
			return Strings.FormatNumber((object)((double)FlowCount / 1048576.0), 1, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + " M";
		}
		if (FlowCount > 1024L)
		{
			return Strings.FormatNumber((object)((double)FlowCount / 1024.0), 0, (TriState)(-2), (TriState)(-2), (TriState)(-2)) + " K";
		}
		return Strings.FormatNumber((object)FlowCount, 0, (TriState)(-2), (TriState)(-2), (TriState)(-2));
	}
}
