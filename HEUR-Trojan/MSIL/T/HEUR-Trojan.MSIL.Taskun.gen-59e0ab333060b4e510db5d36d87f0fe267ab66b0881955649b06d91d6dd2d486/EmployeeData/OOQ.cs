using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace EmployeeData;

[DesignerGenerated]
public class OOQ : UserControl
{
	private IContainer components;

	private static string X66;

	private static string X88;

	public static string GetCore3
	{
		get
		{
			return "fEOkT";
		}
		set
		{
			X66 = value;
		}
	}

	public static string GetCore2
	{
		get
		{
			return "SvBIzi";
		}
		set
		{
			X88 = value;
		}
	}

	public OOQ()
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
				OOQ.smethod_0((IDisposable)components);
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
		OOQ.smethod_1((Control)(object)this);
		OOQ.smethod_2((ContainerControl)(object)this, new SizeF(6f, 13f));
		OOQ.smethod_3((ContainerControl)(object)this, (AutoScaleMode)1);
		OOQ.smethod_4((Control)(object)this, "CoreG");
		OOQ.smethod_5((Control)(object)this, bool_0: false);
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

	static void smethod_4(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_5(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
