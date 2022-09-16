using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace EmployeeData;

[DesignerGenerated]
public class blackout : Form
{
	private IContainer components;

	public blackout()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				blackout.smethod_0((IDisposable)components);
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		blackout.smethod_1((Control)(object)this);
		blackout.smethod_2((ContainerControl)(object)this, new SizeF(6f, 13f));
		blackout.smethod_3((ContainerControl)(object)this, (AutoScaleMode)1);
		blackout.smethod_4((Form)(object)this, Color.Black);
		blackout.smethod_5((Control)(object)this, (ImageLayout)3);
		blackout.smethod_6((Form)(object)this, new Size(800, 450));
		blackout.smethod_8((Control)(object)this, blackout.smethod_7());
		blackout.smethod_9((Form)(object)this, (FormBorderStyle)0);
		blackout.smethod_10((Control)(object)this, "blackout");
		blackout.smethod_11((Form)(object)this, 0.9);
		blackout.smethod_12((Form)(object)this, bool_0: false);
		blackout.smethod_13((Form)(object)this, bool_0: false);
		blackout.smethod_14((Form)(object)this, "blackout");
		blackout.smethod_15((Form)(object)this, bool_0: true);
		blackout.smethod_16((Form)(object)this, (FormWindowState)2);
		blackout.smethod_17((Control)(object)this, bool_0: false);
	}

	static void smethod_0(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static void smethod_1(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_2(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_3(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_4(Form form_0, Color color_0)
	{
		form_0.set_BackColor(color_0);
	}

	static void smethod_5(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_6(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static Cursor smethod_7()
	{
		return Cursors.get_No();
	}

	static void smethod_8(Control control_0, Cursor cursor_0)
	{
		control_0.set_Cursor(cursor_0);
	}

	static void smethod_9(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_10(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_11(Form form_0, double double_0)
	{
		form_0.set_Opacity(double_0);
	}

	static void smethod_12(Form form_0, bool bool_0)
	{
		form_0.set_ShowIcon(bool_0);
	}

	static void smethod_13(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static void smethod_14(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_15(Form form_0, bool bool_0)
	{
		form_0.set_TopMost(bool_0);
	}

	static void smethod_16(Form form_0, FormWindowState formWindowState_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_WindowState(formWindowState_0);
	}

	static void smethod_17(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
