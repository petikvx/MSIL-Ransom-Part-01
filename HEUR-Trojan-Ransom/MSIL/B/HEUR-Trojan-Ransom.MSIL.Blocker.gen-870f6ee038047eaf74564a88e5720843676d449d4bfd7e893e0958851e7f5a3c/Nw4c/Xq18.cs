using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bp2s;
using Hn20;
using Lg2q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Rm76;
using Wj80;
using d8Y9;
using f7W1;
using m7A6;
using o7R3;
using t3B2;
using t4PD;

namespace Nw4c;

[DesignerGenerated]
public class Xq18 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("MenuStrip1")]
	internal virtual MenuStrip MenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FileToolStripMenuItem")]
	internal virtual ToolStripMenuItem FileToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem MapelToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _MapelToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = n1YK;
			ToolStripMenuItem mapelToolStripMenuItem = _MapelToolStripMenuItem;
			if (mapelToolStripMenuItem != null)
			{
				((ToolStripItem)mapelToolStripMenuItem).remove_Click(eventHandler);
			}
			_MapelToolStripMenuItem = value;
			mapelToolStripMenuItem = _MapelToolStripMenuItem;
			if (mapelToolStripMenuItem != null)
			{
				((ToolStripItem)mapelToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem TugasToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _TugasToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m5H8;
			ToolStripMenuItem tugasToolStripMenuItem = _TugasToolStripMenuItem;
			if (tugasToolStripMenuItem != null)
			{
				((ToolStripItem)tugasToolStripMenuItem).remove_Click(eventHandler);
			}
			_TugasToolStripMenuItem = value;
			tugasToolStripMenuItem = _TugasToolStripMenuItem;
			if (tugasToolStripMenuItem != null)
			{
				((ToolStripItem)tugasToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem UserToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _UserToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Zf30;
			ToolStripMenuItem userToolStripMenuItem = _UserToolStripMenuItem;
			if (userToolStripMenuItem != null)
			{
				((ToolStripItem)userToolStripMenuItem).remove_Click(eventHandler);
			}
			_UserToolStripMenuItem = value;
			userToolStripMenuItem = _UserToolStripMenuItem;
			if (userToolStripMenuItem != null)
			{
				((ToolStripItem)userToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem QuitToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _QuitToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = e1PZ;
			ToolStripMenuItem quitToolStripMenuItem = _QuitToolStripMenuItem;
			if (quitToolStripMenuItem != null)
			{
				((ToolStripItem)quitToolStripMenuItem).remove_Click(eventHandler);
			}
			_QuitToolStripMenuItem = value;
			quitToolStripMenuItem = _QuitToolStripMenuItem;
			if (quitToolStripMenuItem != null)
			{
				((ToolStripItem)quitToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("StatusStrip1")]
	internal virtual StatusStrip StatusStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripStatusLabel kodeuser
	{
		[CompilerGenerated]
		get
		{
			return _kodeuser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = n7FK;
			ToolStripStatusLabel val = _kodeuser;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			_kodeuser = value;
			val = _kodeuser;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripProgressBar1")]
	internal virtual ToolStripProgressBar ToolStripProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox5")]
	internal virtual GroupBox GroupBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button4")]
	internal virtual Button Button4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = z9ND;
			Button button = _Button3;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DTP")]
	internal virtual DateTimePicker DTP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Nz0d;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual object CRV
	{
		[CompilerGenerated]
		get
		{
			return _CRV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_CRV = RuntimeHelpers.GetObjectValue(value);
		}
	}

	[field: AccessedThroughProperty("GroupBox6")]
	internal virtual GroupBox GroupBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Zb51;
			Button button = _Button5;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button5 = value;
			button = _Button5;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d4X1;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Xq18()
	{
		((Form)this).add_Load((EventHandler)w1D6);
		f7X6();
	}

	[DebuggerNonUserCode]
	protected override void c1R7(bool Yk81)
	{
		try
		{
			if (Yk81 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Yk81);
		}
	}

	[DebuggerStepThrough]
	private void f7X6()
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be4: Expected O, but got Unknown
		MenuStrip1 = new MenuStrip();
		FileToolStripMenuItem = new ToolStripMenuItem();
		MapelToolStripMenuItem = new ToolStripMenuItem();
		TugasToolStripMenuItem = new ToolStripMenuItem();
		UserToolStripMenuItem = new ToolStripMenuItem();
		QuitToolStripMenuItem = new ToolStripMenuItem();
		StatusStrip1 = new StatusStrip();
		kodeuser = new ToolStripStatusLabel();
		ToolStripProgressBar1 = new ToolStripProgressBar();
		GroupBox1 = new GroupBox();
		GroupBox6 = new GroupBox();
		Button5 = new Button();
		GroupBox5 = new GroupBox();
		Button4 = new Button();
		GroupBox4 = new GroupBox();
		Button3 = new Button();
		GroupBox3 = new GroupBox();
		Button2 = new Button();
		DTP = new DateTimePicker();
		GroupBox2 = new GroupBox();
		Button1 = new Button();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		((Control)MenuStrip1).SuspendLayout();
		((Control)StatusStrip1).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox6).SuspendLayout();
		((Control)GroupBox5).SuspendLayout();
		((Control)GroupBox4).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)FileToolStripMenuItem,
			(ToolStripItem)QuitToolStripMenuItem
		});
		((Control)MenuStrip1).set_Location(new Point(0, 0));
		((Control)MenuStrip1).set_Name("MenuStrip1");
		((Control)MenuStrip1).set_Size(new Size(769, 24));
		((Control)MenuStrip1).set_TabIndex(0);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripDropDownItem)FileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)MapelToolStripMenuItem,
			(ToolStripItem)TugasToolStripMenuItem,
			(ToolStripItem)UserToolStripMenuItem
		});
		((ToolStripItem)FileToolStripMenuItem).set_Name("FileToolStripMenuItem");
		((ToolStripItem)FileToolStripMenuItem).set_Size(new Size(37, 20));
		((ToolStripItem)FileToolStripMenuItem).set_Text("File");
		((ToolStripItem)MapelToolStripMenuItem).set_Name("MapelToolStripMenuItem");
		((ToolStripItem)MapelToolStripMenuItem).set_Size(new Size(107, 22));
		((ToolStripItem)MapelToolStripMenuItem).set_Text("Mapel");
		((ToolStripItem)TugasToolStripMenuItem).set_Name("TugasToolStripMenuItem");
		((ToolStripItem)TugasToolStripMenuItem).set_Size(new Size(107, 22));
		((ToolStripItem)TugasToolStripMenuItem).set_Text("Tugas");
		((ToolStripItem)UserToolStripMenuItem).set_Name("UserToolStripMenuItem");
		((ToolStripItem)UserToolStripMenuItem).set_Size(new Size(107, 22));
		((ToolStripItem)UserToolStripMenuItem).set_Text("User");
		((ToolStripItem)QuitToolStripMenuItem).set_Name("QuitToolStripMenuItem");
		((ToolStripItem)QuitToolStripMenuItem).set_Size(new Size(42, 20));
		((ToolStripItem)QuitToolStripMenuItem).set_Text("Quit");
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)kodeuser,
			(ToolStripItem)ToolStripProgressBar1,
			(ToolStripItem)ToolStripStatusLabel1
		});
		((Control)StatusStrip1).set_Location(new Point(0, 419));
		((Control)StatusStrip1).set_Name("StatusStrip1");
		((Control)StatusStrip1).set_Size(new Size(769, 22));
		((Control)StatusStrip1).set_TabIndex(1);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)kodeuser).set_Name("kodeuser");
		((ToolStripItem)kodeuser).set_Size(new Size(120, 17));
		((ToolStripItem)kodeuser).set_Text("ToolStripStatusLabel1");
		((ToolStripItem)ToolStripProgressBar1).set_Name("ToolStripProgressBar1");
		((ToolStripControlHost)ToolStripProgressBar1).set_Size(new Size(100, 16));
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox2);
		((Control)GroupBox1).set_Dock((DockStyle)1);
		((Control)GroupBox1).set_Location(new Point(0, 24));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(769, 101));
		((Control)GroupBox1).set_TabIndex(3);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Laporan");
		((Control)GroupBox6).get_Controls().Add((Control)(object)Button5);
		((Control)GroupBox6).set_Dock((DockStyle)3);
		((Control)GroupBox6).set_Location(new Point(571, 16));
		((Control)GroupBox6).set_Name("GroupBox6");
		((Control)GroupBox6).set_Size(new Size(121, 82));
		((Control)GroupBox6).set_TabIndex(7);
		GroupBox6.set_TabStop(false);
		GroupBox6.set_Text("All Mapel");
		((Control)Button5).set_Dock((DockStyle)5);
		((Control)Button5).set_Location(new Point(3, 16));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(115, 63));
		((Control)Button5).set_TabIndex(0);
		((ButtonBase)Button5).set_Text("View");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		((Control)GroupBox5).get_Controls().Add((Control)(object)Button4);
		((Control)GroupBox5).set_Dock((DockStyle)3);
		((Control)GroupBox5).set_Location(new Point(450, 16));
		((Control)GroupBox5).set_Name("GroupBox5");
		((Control)GroupBox5).set_Size(new Size(121, 82));
		((Control)GroupBox5).set_TabIndex(6);
		GroupBox5.set_TabStop(false);
		GroupBox5.set_Text("Project Task");
		((Control)Button4).set_Dock((DockStyle)5);
		((Control)Button4).set_Location(new Point(3, 16));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(115, 63));
		((Control)Button4).set_TabIndex(0);
		((ButtonBase)Button4).set_Text("View");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Button3);
		((Control)GroupBox4).set_Dock((DockStyle)3);
		((Control)GroupBox4).set_Location(new Point(329, 16));
		((Control)GroupBox4).set_Name("GroupBox4");
		((Control)GroupBox4).set_Size(new Size(121, 82));
		((Control)GroupBox4).set_TabIndex(5);
		GroupBox4.set_TabStop(false);
		GroupBox4.set_Text("Active Task");
		((Control)Button3).set_Dock((DockStyle)5);
		((Control)Button3).set_Location(new Point(3, 16));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(115, 63));
		((Control)Button3).set_TabIndex(0);
		((ButtonBase)Button3).set_Text("View");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox3).get_Controls().Add((Control)(object)DTP);
		((Control)GroupBox3).set_Dock((DockStyle)3);
		((Control)GroupBox3).set_Location(new Point(124, 16));
		((Control)GroupBox3).set_Name("GroupBox3");
		((Control)GroupBox3).set_Size(new Size(205, 82));
		((Control)GroupBox3).set_TabIndex(4);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("Monthly");
		((Control)Button2).set_Dock((DockStyle)5);
		((Control)Button2).set_Location(new Point(3, 36));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(199, 43));
		((Control)Button2).set_TabIndex(6);
		((ButtonBase)Button2).set_Text("View");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		DTP.set_CustomFormat("MMMM yyyy");
		((Control)DTP).set_Dock((DockStyle)1);
		DTP.set_Format((DateTimePickerFormat)8);
		((Control)DTP).set_Location(new Point(3, 16));
		((Control)DTP).set_Name("DTP");
		((Control)DTP).set_Size(new Size(199, 20));
		((Control)DTP).set_TabIndex(3);
		DTP.set_Value(new DateTime(2019, 11, 20, 0, 0, 0, 0));
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox2).set_Dock((DockStyle)3);
		((Control)GroupBox2).set_Location(new Point(3, 16));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(121, 82));
		((Control)GroupBox2).set_TabIndex(3);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("All Time");
		((Control)Button1).set_Dock((DockStyle)5);
		((Control)Button1).set_Location(new Point(3, 16));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(115, 63));
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("View");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		NewLateBinding.LateSetComplex(CRV, (Type)null, "ActiveViewIndex", new object[1] { -1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(CRV, (Type)null, "BorderStyle", new object[1] { (object)(BorderStyle)1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(CRV, (Type)null, "Dock", new object[1] { (object)(DockStyle)5 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(CRV, (Type)null, "Location", new object[1]
		{
			new Point(0, 125)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(CRV, (Type)null, "Name", new object[1] { "CRV" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(CRV, (Type)null, "SelectionFormula", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(CRV, (Type)null, "Size", new object[1]
		{
			new Size(769, 294)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(CRV, (Type)null, "TabIndex", new object[1] { 4 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(CRV, (Type)null, "ViewTimeSelectionFormula", new object[1] { "" }, (string[])null, (Type[])null, false, true);
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		((ToolStripItem)ToolStripStatusLabel1).set_Size(new Size(206, 17));
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Made By @raflidev With Love - Bekasi");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(769, 441));
		((Control)this).get_Controls().Add((Control)CRV);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Form)this).set_MainMenuStrip(MenuStrip1);
		((Control)this).set_Name("MenuUtama");
		((Form)this).set_Text("MENU UTAMA - RAFLI RAMADHAN");
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox6).ResumeLayout(false);
		((Control)GroupBox5).ResumeLayout(false);
		((Control)GroupBox4).ResumeLayout(false);
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void e1PZ(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void n1YK(object sender, EventArgs e)
	{
		Ld7n ld7n = new Ld7n();
		((Control)ld7n).Show();
	}

	private void m5H8(object sender, EventArgs e)
	{
		d3CT d3CT = new d3CT();
		((Control)d3CT).Show();
	}

	private void Zf30(object sender, EventArgs e)
	{
		Ge4b ge4b = new Ge4b();
		((Control)ge4b).Show();
	}

	private void n7FK(object sender, EventArgs e)
	{
	}

	private void Nz0d(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(CRV, (Type)null, "SelectionFormula", new object[1] { "{TBL_USER.id_user} = '" + ((ToolStripItem)kodeuser).get_Text() + "'" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(CRV, (Type)null, "ReportSource", new object[1] { "LaporanAllTime.rpt" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(CRV, (Type)null, "RefreshReport", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void w1D6(object sender, EventArgs e)
	{
	}

	private void Cg9d(object sender, EventArgs e)
	{
	}

	private void z9ND(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(CRV, (Type)null, "SelectionFormula", new object[1] { "{TBL_TUGAS.tugas_aktif} = 'True'" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(CRV, (Type)null, "ReportSource", new object[1] { "LaporanAllTime.rpt" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(CRV, (Type)null, "RefreshReport", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void Zb51(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(CRV, (Type)null, "ReportSource", new object[1] { "LaporanAllMapel.rpt" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(CRV, (Type)null, "RefreshReport", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	private void d4X1(object sender, EventArgs e)
	{
		NewLateBinding.LateSetComplex(CRV, (Type)null, "SelectionFormula", new object[1] { "month({TBL_TUGAS.deadline}) = (" + Conversions.ToString(DateAndTime.Month(Conversions.ToDate(DTP.get_Text()))) + ")" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(CRV, (Type)null, "ReportSource", new object[1] { "LaporanAllTime.rpt" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateCall(CRV, (Type)null, "RefreshReport", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	internal static void Ho41(List<object> s2SP, int s7ZE)
	{
		byte[] array = new byte[16];
		int num = 0;
		checked
		{
			while (num < 16)
			{
				if (num == 0)
				{
					array[num] = (byte)num;
					array[num + 1] = (byte)Math.Abs(s7ZE);
				}
				else if (num > 1)
				{
					array[num] = (byte)Math.Abs(s7ZE + 65);
				}
				int num2 = num + 1;
				if (num < num2)
				{
					num = num2;
				}
			}
			s2SP.Add(array);
			d3CT.p7N8(s2SP, (byte[])s2SP[4], 255);
		}
	}

	internal static int b1XP(int Qy4p, int b9P7)
	{
		return Qy4p % b9P7;
	}

	static void j3A9()
	{
		do
		{
			_ = (Ld7n)(object)n2H1.Default;
		}
		while ((object)n2H1.Default != null);
		object obj = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y4B7 y4B);
		try
		{
			_ = (Pd01)(object)n2H1.Default;
			_ = (_003CModule_003E)(object)n2H1.Default;
			_ = (Xq18)(object)n2H1.Default;
			_ = (d3CT)(object)n2H1.Default;
		}
		catch
		{
			do
			{
				uIntPtr = (UIntPtr)n2H1.Default;
				if (uIntPtr != (UIntPtr)(nuint)0u)
				{
					y4B = y4B;
					y4B = null;
					continue;
				}
				_ = (_003CModule_003E)(object)n2H1.Default;
				_003CModule_003E obj2 = (_003CModule_003E)(object)n2H1.Default;
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = obj2;
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ym89 ym);
		try
		{
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Ld7n)(object)n2H1.Default;
				}
			}
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)n2H1.Default;
				}
			}
			else
			{
				while (obj != null)
				{
					ym = ym;
					ym = ym;
				}
			}
			goto IL_00f7;
		}
		IL_0242:
		n2H1 n2H = n2H;
		_ = (Pd01)(object)n2H1.Default;
		_ = (Ge4b)(object)n2H1.Default;
		q0D6 q0D;
		try
		{
			_ = (_003CModule_003E)(object)n2H1.Default;
		}
		finally
		{
			do
			{
				y4B = null;
				q0D6 obj4 = (q0D6)(object)n2H1.Default;
				q0D = (q0D6)(object)n2H1.Default;
				q0D = obj4;
				_ = (Xq18)(object)n2H1.Default;
			}
			while ((object)n2H1.Default != null || obj != null);
			goto IL_02b2;
		}
		IL_063e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ge4b ge4b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t8X9 t8X);
		try
		{
			while (obj != null)
			{
			}
		}
		catch
		{
			if (checked(uIntPtr + uIntPtr) == 0)
			{
				ge4b = ge4b;
			}
			else
			{
				try
				{
					_ = (Ym89)(object)n2H1.Default;
				}
				catch
				{
					t8X = t8X;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d3CT d3CT);
		while ((object)n2H1.Default != null)
		{
			try
			{
				_ = (Ge4b)(object)n2H1.Default;
			}
			catch
			{
				_ = (Ld7n)(object)n2H1.Default;
			}
			finally
			{
				try
				{
					d3CT = (d3CT)(object)n2H1.Default;
				}
				catch
				{
					_ = (Ym89)(object)n2H1.Default;
				}
				continue;
			}
		}
		return;
		IL_02b2:
		uIntPtr = default(UIntPtr);
		Xq18 xq;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pd01 pd);
		checked
		{
			if (unchecked(unchecked((nuint)default(UIntPtr)) / uIntPtr) + uIntPtr == 0)
			{
				try
				{
					_ = (q0D6)(object)n2H1.Default;
					pd = null;
				}
				catch
				{
				}
			}
			q0D = q0D;
			t8X = t8X;
			t8X = t8X;
			ge4b = ge4b;
			Xq18 obj10 = (Xq18)(object)n2H1.Default;
			xq = null;
			xq = obj10;
		}
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			xq = xq;
			_ = (Ym89)(object)n2H1.Default;
		}
		try
		{
			try
			{
				while (obj != null)
				{
					n2H = n2H1.Default;
				}
			}
			finally
			{
				try
				{
					ym = ym;
				}
				finally
				{
					_ = (q0D6)(object)n2H1.Default;
					goto end_IL_033e;
				}
			}
			end_IL_033e:;
		}
		catch
		{
			UIntPtr num = (UIntPtr)n2H1.Default;
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num) * uIntPtr == 0)
				{
					try
					{
						Ld7n ld7n = ld7n;
						ld7n = ld7n;
						_ = (q0D6)(object)n2H1.Default;
						_ = (Xq18)(object)n2H1.Default;
					}
					catch
					{
						xq = xq;
					}
				}
				else
				{
					t8X = t8X;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w4M5 w4M);
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				n2H = n2H;
				y4B = y4B;
			}
			finally
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Xq18)(object)n2H1.Default;
					ym = ym;
					w4M = w4M;
				}
				else
				{
					q0D = q0D;
				}
				goto IL_043a;
			}
		}
		try
		{
			_ = (Xq18)(object)n2H1.Default;
		}
		catch
		{
			_ = (d3CT)(object)n2H1.Default;
		}
		goto IL_043a;
		IL_00f7:
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr == 0)
			{
				if (uIntPtr * (uIntPtr * unchecked((nuint)(UIntPtr)n2H1.Default)) == 0)
				{
					if (uIntPtr == 0)
					{
						ym = (Ym89)(object)n2H1.Default;
					}
				}
				else
				{
					n2H = n2H;
					n2H = n2H;
				}
			}
			else
			{
				try
				{
				}
				catch
				{
					try
					{
						_ = (Xq18)(object)n2H1.Default;
						_ = (w4M5)(object)n2H1.Default;
						_ = (_003CModule_003E)(object)n2H1.Default;
						_ = (Ym89)(object)n2H1.Default;
					}
					finally
					{
						_ = (t8X9)(object)n2H1.Default;
						goto end_IL_014b;
					}
					end_IL_014b:;
				}
			}
			while (obj != null)
			{
				try
				{
					do
					{
						d3CT = null;
						d3CT = d3CT;
					}
					while (obj != null);
				}
				catch
				{
					_ = (w4M5)(object)n2H1.Default;
				}
			}
			while ((object)n2H1.Default != null)
			{
				while (obj != null)
				{
					try
					{
						_003CModule_003E = _003CModule_003E;
					}
					catch
					{
						_ = (t8X9)(object)n2H1.Default;
					}
				}
			}
			do
			{
				ym = ym;
				_ = (Pd01)(object)n2H1.Default;
			}
			while (obj != null);
			do
			{
				_ = (t8X9)(object)n2H1.Default;
			}
			while (obj != null);
		}
		if (uIntPtr == 0)
		{
			try
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					w4M = w4M;
					w4M = w4M;
				}
			}
			finally
			{
				do
				{
					d3CT = d3CT;
				}
				while (obj != null);
				goto IL_0242;
			}
		}
		goto IL_0242;
		IL_043a:
		try
		{
			try
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					pd = pd;
					ge4b = null;
				}
			}
			catch
			{
				UIntPtr num2 = (UIntPtr)n2H1.Default;
				uIntPtr = default(UIntPtr);
				if ((nuint)num2 / uIntPtr == 0)
				{
					y4B = null;
				}
				else
				{
					_ = (Xq18)(object)n2H1.Default;
				}
			}
		}
		catch
		{
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Ge4b)(object)n2H1.Default;
					continue;
				}
				y4B = (y4B7)(object)n2H1.Default;
				ge4b = ge4b;
			}
		}
		try
		{
			try
			{
				try
				{
					_ = (Ym89)(object)n2H1.Default;
				}
				finally
				{
					_ = (Pd01)(object)n2H1.Default;
					goto end_IL_04c9;
				}
				end_IL_04c9:;
			}
			catch
			{
			}
		}
		catch
		{
			do
			{
				_ = (Ym89)(object)n2H1.Default;
			}
			while ((object)n2H1.Default != null || obj != null);
		}
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					ym = ym;
				}
				catch
				{
					_ = (Pd01)(object)n2H1.Default;
				}
			}
			else if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				_ = (d3CT)(object)n2H1.Default;
			}
			else
			{
				_ = (y4B7)(object)n2H1.Default;
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				t8X = null;
				_ = (Pd01)(object)n2H1.Default;
				t8X = t8X;
			}
			else if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Ge4b)(object)n2H1.Default;
				_ = (d3CT)(object)n2H1.Default;
				d3CT = (d3CT)(object)n2H1.Default;
				_ = (d3CT)(object)n2H1.Default;
			}
		}
		checked
		{
			if (uIntPtr * unchecked((nuint)(UIntPtr)n2H1.Default) == 0)
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						ge4b = (Ge4b)(object)n2H1.Default;
					}
				}
				finally
				{
					if (uIntPtr == 0)
					{
						Ld7n ld7n = null;
					}
					else
					{
						pd = pd;
						ge4b = ge4b;
						t8X = (t8X9)(object)n2H1.Default;
					}
					goto IL_063e;
				}
			}
			_ = (Ps93)(object)n2H1.Default;
			_ = (_003CModule_003E)(object)n2H1.Default;
			goto IL_063e;
		}
	}

	static void b1KL()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q0D6 q0D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			try
			{
				do
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					obj = obj;
				}
				while (obj != null || obj != null);
			}
			catch
			{
				do
				{
					num = unchecked((nuint)(UIntPtr)n2H1.Default) + num;
					if (num == 0)
					{
						q0D = q0D;
						q0D = null;
					}
				}
				while (obj != null);
			}
			do
			{
				try
				{
					_ = (w4M5)(object)n2H1.Default;
				}
				catch
				{
					_ = (d3CT)(object)n2H1.Default;
				}
			}
			while ((object)n2H1.Default != null || obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ps93 ps);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ym89 ym);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ld7n ld7n);
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while ((object)n2H1.Default != null)
				{
					_ = (Ps93)(object)n2H1.Default;
					ps = (Ps93)(object)n2H1.Default;
					ps = null;
					ym = ym;
					ym = null;
				}
			}
			finally
			{
				try
				{
					ld7n = ld7n;
					ld7n = null;
				}
				finally
				{
					_ = (Pd01)(object)n2H1.Default;
					goto IL_0100;
				}
			}
		}
		_ = (t8X9)(object)n2H1.Default;
		goto IL_0100;
		IL_013e:
		t8X9 obj4 = (t8X9)(object)n2H1.Default;
		t8X9 t8X = null;
		t8X = obj4;
		while ((object)n2H1.Default != null)
		{
			while ((object)n2H1.Default != null)
			{
				while (obj != null)
				{
					_ = n2H1.Default;
				}
			}
		}
		_ = (d3CT)(object)n2H1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n2H1 n2H);
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (Ge4b)(object)n2H1.Default;
				}
				catch
				{
					ym = null;
				}
			}
			while ((object)n2H1.Default != null);
		}
		else
		{
			do
			{
				n2H = n2H1.Default;
				n2H = n2H;
				ym = ym;
				_ = (y4B7)(object)n2H1.Default;
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y4B7 y4B);
		if (num == 0 && num == 0)
		{
			try
			{
				y4B = y4B;
				y4B = y4B;
			}
			catch
			{
				t8X = t8X;
			}
		}
		UIntPtr num2 = (UIntPtr)n2H1.Default;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pd01 pd);
		checked
		{
			nuint num3 = unchecked((nuint)num2) * (num * num);
			num = default(UIntPtr);
			if (num3 * num + num == 0)
			{
				nuint num4 = num;
				nuint num5 = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)n2H1.Default);
				num = default(UIntPtr);
				if (unchecked(num4 / (num5 / num)) + unchecked((nuint)(UIntPtr)n2H1.Default) != 0)
				{
					try
					{
						_ = (d3CT)(object)n2H1.Default;
					}
					finally
					{
						Pd01 obj7 = (Pd01)(object)n2H1.Default;
						pd = pd;
						pd = obj7;
						goto IL_02bb;
					}
				}
				d3CT d3CT = (d3CT)(object)n2H1.Default;
				d3CT = d3CT;
			}
			goto IL_02bb;
		}
		IL_0398:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xq18 xq);
		try
		{
			_ = (_003CModule_003E)(object)n2H1.Default;
		}
		finally
		{
			if (num == 0)
			{
				try
				{
					_ = (q0D6)(object)n2H1.Default;
					y4B = y4B;
					_ = (w4M5)(object)n2H1.Default;
				}
				catch
				{
					xq = xq;
					y4B = null;
					ym = (Ym89)(object)n2H1.Default;
				}
			}
			else
			{
				while (obj != null)
				{
					d3CT d3CT = null;
				}
			}
			goto IL_03f7;
		}
		IL_0573:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ge4b ge4b);
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			y4B = y4B;
			ld7n = ld7n;
			ge4b = null;
			_ = (_003CModule_003E)(object)n2H1.Default;
		}
		else
		{
			try
			{
				if (num == 0)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			catch
			{
				try
				{
					_ = (Ld7n)(object)n2H1.Default;
				}
				catch
				{
					_ = (w4M5)(object)n2H1.Default;
				}
			}
		}
		w4M5 w4M = w4M;
		_ = (Ld7n)(object)n2H1.Default;
		n2H = n2H1.Default;
		w4M = w4M;
		_ = (Ym89)(object)n2H1.Default;
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				xq = xq;
				ym = ym;
				_ = (w4M5)(object)n2H1.Default;
			}
			else
			{
				q0D = null;
				q0D = null;
				xq = xq;
				d3CT d3CT = (d3CT)(object)n2H1.Default;
			}
		}
		finally
		{
			while (obj != null)
			{
				do
				{
					_ = (Ym89)(object)n2H1.Default;
				}
				while (obj != null);
			}
			goto IL_066f;
		}
		IL_02bb:
		y4B = y4B;
		do
		{
			try
			{
				try
				{
					_ = (w4M5)(object)n2H1.Default;
				}
				finally
				{
					xq = xq;
					xq = null;
					_ = (w4M5)(object)n2H1.Default;
					n2H = n2H;
					ge4b = (Ge4b)(object)n2H1.Default;
					ge4b = null;
					goto end_IL_02c4;
				}
				end_IL_02c4:;
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Ge4b)(object)n2H1.Default;
					t8X = null;
				}
			}
		}
		while (obj != null);
		do
		{
			if (num == 0)
			{
				while (obj != null)
				{
					w4M = w4M;
					ld7n = null;
				}
			}
		}
		while (obj != null);
		try
		{
			_ = (Pd01)(object)n2H1.Default;
		}
		catch
		{
			pd = pd;
		}
		finally
		{
			try
			{
				y4B = (y4B7)(object)n2H1.Default;
			}
			finally
			{
				ym = (Ym89)(object)n2H1.Default;
				goto IL_0398;
			}
		}
		IL_066f:
		try
		{
			while ((object)n2H1.Default != null)
			{
				try
				{
					_ = (y4B7)(object)n2H1.Default;
				}
				finally
				{
					t8X = null;
					_ = (y4B7)(object)n2H1.Default;
					continue;
				}
			}
		}
		catch
		{
			try
			{
				do
				{
					n2H = n2H;
				}
				while (obj != null);
			}
			finally
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					d3CT d3CT = null;
					ym = (Ym89)(object)n2H1.Default;
				}
				else
				{
					_003CModule_003E = (_003CModule_003E)(object)n2H1.Default;
				}
				goto end_IL_06a1;
			}
			end_IL_06a1:;
		}
		_ = (q0D6)(object)n2H1.Default;
		q0D = q0D;
		checked
		{
			if (num == 0 && num * unchecked((nuint)(UIntPtr)n2H1.Default) != 0)
			{
				_ = (t8X9)(object)n2H1.Default;
			}
			_ = (Ym89)(object)n2H1.Default;
			_ = (q0D6)(object)n2H1.Default;
			_ = (_003CModule_003E)(object)n2H1.Default;
			ld7n = null;
			UIntPtr num6 = unchecked((UIntPtr)n2H1.Default);
			num = default(UIntPtr);
			if (unchecked((nuint)num6) - num == 0)
			{
				do
				{
					ge4b = (Ge4b)(object)n2H1.Default;
					_ = (q0D6)(object)n2H1.Default;
				}
				while (obj != null || (object)n2H1.Default != null);
			}
			t8X = t8X;
			while (obj != null)
			{
				if (num == 0)
				{
					while (obj != null)
					{
						_ = (q0D6)(object)n2H1.Default;
					}
					continue;
				}
				try
				{
					_ = (Xq18)(object)n2H1.Default;
				}
				finally
				{
					n2H = n2H;
					continue;
				}
			}
			w4M = (w4M5)(object)n2H1.Default;
			return;
		}
		IL_03f7:
		xq = xq;
		while ((object)n2H1.Default != null)
		{
			t8X = t8X;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (checked(num - num - num) == 0)
				{
					_ = (w4M5)(object)n2H1.Default;
				}
			}
			else
			{
				n2H = null;
			}
		}
		finally
		{
			UIntPtr num7 = (UIntPtr)n2H1.Default;
			num = default(UIntPtr);
			checked
			{
				nuint num8 = (num + num) * (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)n2H1.Default));
				num = default(UIntPtr);
				nuint num9 = num8 - (num - num);
				num = default(UIntPtr);
				if (unchecked((nuint)num7) * (unchecked((nuint)default(UIntPtr)) * (num9 + num) * unchecked((nuint)(UIntPtr)n2H1.Default)) == 0)
				{
					_ = (Ps93)(object)n2H1.Default;
					_ = (t8X9)(object)n2H1.Default;
					ge4b = ge4b;
					_ = (w4M5)(object)n2H1.Default;
				}
				else
				{
					try
					{
						_ = (_003CModule_003E)(object)n2H1.Default;
					}
					catch
					{
						_ = (Xq18)(object)n2H1.Default;
					}
				}
				goto IL_0516;
			}
		}
		IL_0100:
		if (num == 0)
		{
			try
			{
				do
				{
					ps = ps;
					w4M = null;
					w4M = w4M;
				}
				while ((object)n2H1.Default != null);
			}
			finally
			{
				do
				{
					_ = (Xq18)(object)n2H1.Default;
				}
				while (obj != null);
				goto IL_013e;
			}
		}
		goto IL_013e;
		IL_0516:
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			ld7n = ld7n;
		}
		else
		{
			if (num == 0)
			{
				try
				{
					y4B = y4B;
				}
				finally
				{
					_ = (Ge4b)(object)n2H1.Default;
					goto IL_0573;
				}
			}
			try
			{
				ld7n = (Ld7n)(object)n2H1.Default;
				_ = (_003CModule_003E)(object)n2H1.Default;
			}
			catch
			{
				_ = n2H1.Default;
			}
		}
		goto IL_0573;
	}

	static void Ln3f()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E obj = (_003CModule_003E)(object)n2H1.Default;
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = obj;
		}
		nuint uIntPtr = (UIntPtr)n2H1.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			catch
			{
				_ = (Ps93)(object)n2H1.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ge4b ge4b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ps93 ps);
		w4M5 w4M;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t8X9 t8X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d3CT d3CT);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n2H1 n2H);
		checked
		{
			if (uIntPtr * unchecked((nuint)(UIntPtr)n2H1.Default) == 0)
			{
				try
				{
					do
					{
						n2H = null;
						n2H = n2H;
						_003CModule_003E = _003CModule_003E;
						t8X9 obj3 = (t8X9)(object)n2H1.Default;
						t8X = (t8X9)(object)n2H1.Default;
						t8X = obj3;
						ge4b = ge4b;
						ge4b = ge4b;
						obj4 = n2H1.Default;
					}
					while (obj4 != null);
				}
				catch
				{
					ps = (Ps93)(object)n2H1.Default;
					ps = null;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Ld7n ld7n = ld7n;
					ld7n = ld7n;
				}
				else
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr + (uIntPtr - unchecked((nuint)(UIntPtr)n2H1.Default)) == 0)
					{
						_ = (Ym89)(object)n2H1.Default;
						_ = (t8X9)(object)n2H1.Default;
					}
					else
					{
						_ = (Pd01)(object)n2H1.Default;
					}
				}
			}
			if (uIntPtr == 0)
			{
				if (uIntPtr * unchecked((nuint)(UIntPtr)n2H1.Default) + unchecked((nuint)(UIntPtr)n2H1.Default) - uIntPtr == 0)
				{
					_ = (Ge4b)(object)n2H1.Default;
					_ = (Xq18)(object)n2H1.Default;
					_ = (t8X9)(object)n2H1.Default;
					_ = (d3CT)(object)n2H1.Default;
				}
				else
				{
					Ld7n ld7n = null;
					d3CT obj6 = (d3CT)(object)n2H1.Default;
					d3CT = d3CT;
					d3CT = obj6;
					ld7n = (Ld7n)(object)n2H1.Default;
					_ = (t8X9)(object)n2H1.Default;
				}
			}
			while (obj4 != null)
			{
				try
				{
					_ = (d3CT)(object)n2H1.Default;
				}
				finally
				{
					try
					{
						_ = (y4B7)(object)n2H1.Default;
					}
					finally
					{
						_ = (y4B7)(object)n2H1.Default;
						continue;
					}
				}
			}
			_ = (Pd01)(object)n2H1.Default;
			d3CT = null;
			_ = (Xq18)(object)n2H1.Default;
			_ = (Xq18)(object)n2H1.Default;
			_ = (Ps93)(object)n2H1.Default;
			t8X = t8X;
			_ = (_003CModule_003E)(object)n2H1.Default;
			w4M = null;
			w4M = null;
			Ym89 ym = (Ym89)(object)n2H1.Default;
			ym = ym;
		}
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (obj4 != null)
				{
					_ = (t8X9)(object)n2H1.Default;
				}
			}
			goto IL_02e7;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q0D6 q0D);
		try
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Pd01)(object)n2H1.Default;
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				_003CModule_003E = (_003CModule_003E)(object)n2H1.Default;
			}
			else
			{
				n2H = null;
				_ = (Ps93)(object)n2H1.Default;
				q0D = null;
				q0D = q0D;
				ge4b = ge4b;
			}
			goto IL_02e7;
		}
		IL_02e7:
		try
		{
			_ = (y4B7)(object)n2H1.Default;
		}
		catch
		{
			if (uIntPtr == 0)
			{
			}
		}
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			ps = null;
		}
		checked
		{
			try
			{
				_ = (Xq18)(object)n2H1.Default;
			}
			catch
			{
				if (unchecked(checked(uIntPtr - uIntPtr) / uIntPtr) - unchecked((nuint)(UIntPtr)n2H1.Default) == 0)
				{
					d3CT = d3CT;
				}
				else
				{
					t8X = null;
					y4B7 y4B = y4B;
					y4B = y4B;
					_ = (_003CModule_003E)(object)n2H1.Default;
					_ = (w4M5)(object)n2H1.Default;
				}
			}
			try
			{
				do
				{
					t8X = t8X;
				}
				while (obj4 != null);
			}
			catch
			{
				do
				{
					_ = (y4B7)(object)n2H1.Default;
					d3CT = null;
					_ = (w4M5)(object)n2H1.Default;
				}
				while ((object)n2H1.Default != null || obj4 != null);
			}
		}
		try
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					ps = ps;
				}
			}
			else
			{
				d3CT = (d3CT)(object)n2H1.Default;
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (Ym89)(object)n2H1.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)n2H1.Default;
					goto end_IL_03ea;
				}
				end_IL_03ea:;
			}
			catch
			{
				while (true)
				{
					Ld7n ld7n = null;
					if ((object)n2H1.Default != null)
					{
						continue;
					}
					goto end_IL_0407;
				}
				end_IL_0407:;
			}
		}
		if (uIntPtr == 0)
		{
			while (obj4 != null)
			{
				do
				{
					n2H = null;
				}
				while (obj4 != null);
			}
		}
		try
		{
		}
		finally
		{
			_ = (d3CT)(object)n2H1.Default;
			goto IL_0446;
		}
		IL_0446:
		UIntPtr num = (UIntPtr)n2H1.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			Pd01 pd;
			if (unchecked((nuint)num) + uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					_ = (Ym89)(object)n2H1.Default;
				}
				else
				{
					q0D = q0D;
					pd = (Pd01)(object)n2H1.Default;
					pd = pd;
				}
			}
			pd = (Pd01)(object)n2H1.Default;
			q0D = (q0D6)(object)n2H1.Default;
			_ = (t8X9)(object)n2H1.Default;
			_ = (Pd01)(object)n2H1.Default;
			_ = (_003CModule_003E)(object)n2H1.Default;
			_ = (Ge4b)(object)n2H1.Default;
			do
			{
				_ = (_003CModule_003E)(object)n2H1.Default;
				d3CT = d3CT;
				_ = n2H1.Default;
				_ = (Pd01)(object)n2H1.Default;
			}
			while (obj4 != null);
			uIntPtr = default(UIntPtr);
			if (uIntPtr + uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					pd = (Pd01)(object)n2H1.Default;
				}
				else if (unchecked((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u))
				{
					_ = (q0D6)(object)n2H1.Default;
				}
			}
			while (obj4 != null)
			{
				do
				{
					pd = null;
					t8X = t8X;
					_ = n2H1.Default;
				}
				while ((object)n2H1.Default != null);
			}
			while (obj4 != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					n2H = n2H1.Default;
				}
			}
			_ = (w4M5)(object)n2H1.Default;
			Ld7n ld7n = (Ld7n)(object)n2H1.Default;
			ps = null;
			pd = (Pd01)(object)n2H1.Default;
		}
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					_ = (w4M5)(object)n2H1.Default;
				}
				while (obj4 != null);
			}
		}
		else
		{
			try
			{
				w4M = w4M;
			}
			catch
			{
				d3CT = d3CT;
			}
		}
		_ = (Ym89)(object)n2H1.Default;
		_ = (y4B7)(object)n2H1.Default;
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			_ = (d3CT)(object)n2H1.Default;
			_ = (Ym89)(object)n2H1.Default;
			_ = (Ge4b)(object)n2H1.Default;
			t8X = t8X;
		}
		try
		{
			try
			{
				while (obj4 != null)
				{
					n2H = null;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					d3CT = d3CT;
					q0D = q0D;
					Ym89 ym = null;
					n2H = n2H;
				}
			}
		}
		catch
		{
			_ = (Ge4b)(object)n2H1.Default;
		}
	}
}
