using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace EmployeeData;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	private object canClose;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Timer1")]
	internal virtual Timer Timer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer displayOverFullscreenAndUWA
	{
		[CompilerGenerated]
		get
		{
			return _displayOverFullscreenAndUWA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = DisplayOverFullscreenAndUWA_Tick;
			Timer val = _displayOverFullscreenAndUWA;
			if (val != null)
			{
				Form1.smethod_14(val, eventHandler_);
			}
			_displayOverFullscreenAndUWA = value;
			val = _displayOverFullscreenAndUWA;
			if (val != null)
			{
				Form1.smethod_15(val, eventHandler_);
			}
		}
	}

	public Form1()
	{
		canClose = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				Form1.smethod_0((IDisposable)components);
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
		components = Form1.smethod_1();
		Form1.smethod_3(Form1.smethod_2(typeof(Form1).TypeHandle));
		Form1.smethod_4(Label1, bool_0: true);
		Form1.smethod_6((Control)(object)Label1, Form1.smethod_5("Microsoft Sans Serif", 6f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Form1.smethod_7((Control)(object)Label1, new Point(12, 107));
		Form1.smethod_8((Control)(object)Label1, "Label1");
		Form1.smethod_9((Control)(object)Label1, new Size(47, 9));
		Form1.smethod_10((Control)(object)Label1, 2);
		Form1.smethod_11(Label1, "192.168.?.??");
		Form1.smethod_12(displayOverFullscreenAndUWA, bool_0: true);
		Form1.smethod_13(displayOverFullscreenAndUWA, 1000);
	}

	private void DisplayOverFullscreenAndUWA_Tick(object sender, EventArgs e)
	{
	}

	static void smethod_0(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_1()
	{
		return new Container();
	}

	static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_3(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static void smethod_4(Label label_0, bool bool_0)
	{
		label_0.set_AutoSize(bool_0);
	}

	static Font smethod_5(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_6(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_7(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_8(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_9(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_10(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_11(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static void smethod_12(Timer timer_0, bool bool_0)
	{
		timer_0.set_Enabled(bool_0);
	}

	static void smethod_13(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static void smethod_14(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.remove_Tick(eventHandler_0);
	}

	static void smethod_15(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}
}
