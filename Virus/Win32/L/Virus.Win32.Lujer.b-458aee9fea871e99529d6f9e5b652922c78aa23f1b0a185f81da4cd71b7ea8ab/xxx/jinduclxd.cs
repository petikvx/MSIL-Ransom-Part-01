using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic.CompilerServices;

namespace xxx;

[DesignerGenerated]
public class jinduclxd : Office2007Form
{
	private IContainer components;

	[AccessedThroughProperty("LabelX1")]
	private LabelX _LabelX1;

	[AccessedThroughProperty("PBZ")]
	private ProgressBarX _PBZ;

	[AccessedThroughProperty("LabelX3")]
	private LabelX _LabelX3;

	[AccessedThroughProperty("PBD")]
	private ProgressBarX _PBD;

	[AccessedThroughProperty("LabelX4")]
	private LabelX _LabelX4;

	[AccessedThroughProperty("xx")]
	private LabelX _xx;

	internal virtual LabelX LabelX1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX1 = value;
		}
	}

	public virtual ProgressBarX PBZ
	{
		[DebuggerNonUserCode]
		get
		{
			return _PBZ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PBZ = value;
		}
	}

	internal virtual LabelX LabelX3
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX3 = value;
		}
	}

	public virtual ProgressBarX PBD
	{
		[DebuggerNonUserCode]
		get
		{
			return _PBD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PBD = value;
		}
	}

	internal virtual LabelX LabelX4
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelX4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelX4 = value;
		}
	}

	internal virtual LabelX xx
	{
		[DebuggerNonUserCode]
		get
		{
			return _xx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_xx = value;
		}
	}

	[DebuggerNonUserCode]
	public jinduclxd()
	{
		((Form)this).add_Load((EventHandler)jinduclxd_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Office2007Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		PBZ = new ProgressBarX();
		LabelX1 = new LabelX();
		LabelX3 = new LabelX();
		PBD = new ProgressBarX();
		LabelX4 = new LabelX();
		xx = new LabelX();
		((Control)this).SuspendLayout();
		((BaseItemControl)PBZ).get_BackgroundStyle().set_Class("");
		((BaseItemControl)PBZ).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)PBZ).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ProgressBarX pBZ = PBZ;
		Point location = new Point(107, 14);
		((Control)pBZ).set_Location(location);
		((Control)PBZ).set_Name("PBZ");
		ProgressBarX pBZ2 = PBZ;
		Size size = new Size(588, 23);
		((Control)pBZ2).set_Size(size);
		((Control)PBZ).set_TabIndex(0);
		((Control)PBZ).set_Text("ProgressBarX1");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX = LabelX1;
		location = new Point(26, 14);
		((Control)labelX).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX2 = LabelX1;
		size = new Size(75, 23);
		((Control)labelX2).set_Size(size);
		((Control)LabelX1).set_TabIndex(1);
		LabelX1.set_Text("总进度");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX3).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX3 = LabelX3;
		location = new Point(26, 72);
		((Control)labelX3).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX4 = LabelX3;
		size = new Size(107, 23);
		((Control)labelX4).set_Size(size);
		((Control)LabelX3).set_TabIndex(1);
		LabelX3.set_Text("正在处理的...");
		((BaseItemControl)PBD).get_BackgroundStyle().set_Class("");
		((BaseItemControl)PBD).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)PBD).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		ProgressBarX pBD = PBD;
		location = new Point(107, 43);
		((Control)pBD).set_Location(location);
		((Control)PBD).set_Name("PBD");
		ProgressBarX pBD2 = PBD;
		size = new Size(588, 23);
		((Control)pBD2).set_Size(size);
		((Control)PBD).set_TabIndex(0);
		((Control)PBD).set_Text("ProgressBarX1");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX4).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX labelX5 = LabelX4;
		location = new Point(26, 43);
		((Control)labelX5).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX6 = LabelX4;
		size = new Size(75, 23);
		((Control)labelX6).set_Size(size);
		((Control)LabelX4).set_TabIndex(1);
		LabelX4.set_Text("当前进度");
		((BaseItemControl)xx).get_BackgroundStyle().set_Class("");
		((BaseItemControl)xx).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)xx).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		LabelX obj = xx;
		location = new Point(107, 72);
		((Control)obj).set_Location(location);
		((Control)xx).set_Name("xx");
		LabelX obj2 = xx;
		size = new Size(588, 23);
		((Control)obj2).set_Size(size);
		((Control)xx).set_TabIndex(2);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_AutoValidate((AutoValidate)0);
		((Office2007Form)this).set_CaptionFont(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		size = new Size(719, 104);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)xx);
		((Control)this).get_Controls().Add((Control)(object)LabelX3);
		((Control)this).get_Controls().Add((Control)(object)LabelX4);
		((Control)this).get_Controls().Add((Control)(object)LabelX1);
		((Control)this).get_Controls().Add((Control)(object)PBD);
		((Control)this).get_Controls().Add((Control)(object)PBZ);
		((Control)this).set_Font(new Font("宋体", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("jinduclxd");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
	}

	private void jinduclxd_Load(object sender, EventArgs e)
	{
	}
}
