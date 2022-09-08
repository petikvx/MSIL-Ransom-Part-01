using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace builder;

[DesignerGenerated]
public class Form5 : Form
{
	private static List<WeakReference> list_0;

	private IContainer icontainer_0;

	[AccessedThroughProperty("BlackShadesNetForm1")]
	private BlackShadesNetForm _BlackShadesNetForm1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("تأثيرالماء3")]
	private GClass0 gclass0_0;

	internal virtual BlackShadesNetForm BlackShadesNetForm1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BlackShadesNetForm1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = BlackShadesNetForm1_Click;
			if (_BlackShadesNetForm1 != null)
			{
				((Control)_BlackShadesNetForm1).remove_Click(eventHandler);
			}
			_BlackShadesNetForm1 = value;
			if (_BlackShadesNetForm1 != null)
			{
				((Control)_BlackShadesNetForm1).add_Click(eventHandler);
			}
		}
	}

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

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).remove_Click(eventHandler);
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).add_Click(eventHandler);
			}
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
			EventHandler eventHandler = Label2_Click;
			if (_Label2 != null)
			{
				((Control)_Label2).remove_Click(eventHandler);
			}
			_Label2 = value;
			if (_Label2 != null)
			{
				((Control)_Label2).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label13_Click;
			if (_Label13 != null)
			{
				((Control)_Label13).remove_Click(eventHandler);
			}
			_Label13 = value;
			if (_Label13 != null)
			{
				((Control)_Label13).add_Click(eventHandler);
			}
		}
	}

	internal virtual GClass0 GClass0_0
	{
		[DebuggerNonUserCode]
		get
		{
			return gclass0_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			gclass0_0 = value;
		}
	}

	[DebuggerNonUserCode]
	static Form5()
	{
		Class14.hYiyYvszsKHjE();
		list_0 = new List<WeakReference>();
	}

	[DebuggerNonUserCode]
	public Form5()
	{
		Class14.hYiyYvszsKHjE();
		((Form)this)._002Ector();
		smethod_0(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
			{
				icontainer_0.Dispose();
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected O, but got Unknown
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected O, but got Unknown
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected O, but got Unknown
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form5));
		BlackShadesNetForm1 = new BlackShadesNetForm();
		Panel1 = new Panel();
		Label13 = new Label();
		Label12 = new Label();
		Label11 = new Label();
		Label7 = new Label();
		Label9 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		PictureBox1 = new PictureBox();
		GClass0_0 = new GClass0();
		((Control)BlackShadesNetForm1).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		BlackShadesNetForm1.CloseButtonExitsApp = false;
		((Control)BlackShadesNetForm1).get_Controls().Add((Control)(object)Panel1);
		((Control)BlackShadesNetForm1).set_Dock((DockStyle)5);
		((Control)BlackShadesNetForm1).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)1));
		((Control)BlackShadesNetForm1).set_ForeColor(Color.FromArgb(142, 152, 156));
		BlackShadesNetForm blackShadesNetForm = BlackShadesNetForm1;
		Point location = new Point(0, 0);
		((Control)blackShadesNetForm).set_Location(location);
		BlackShadesNetForm1.MinimizeButton = true;
		((Control)BlackShadesNetForm1).set_Name("BlackShadesNetForm1");
		BlackShadesNetForm blackShadesNetForm2 = BlackShadesNetForm1;
		Size size = new Size(390, 212);
		((Control)blackShadesNetForm2).set_Size(size);
		((Control)BlackShadesNetForm1).set_TabIndex(0);
		((Control)BlackShadesNetForm1).set_Text("About");
		((Control)Panel1).set_BackColor(Color.Black);
		((Control)Panel1).get_Controls().Add((Control)(object)GClass0_0);
		((Control)Panel1).get_Controls().Add((Control)(object)Label13);
		((Control)Panel1).get_Controls().Add((Control)(object)Label12);
		((Control)Panel1).get_Controls().Add((Control)(object)Label11);
		((Control)Panel1).get_Controls().Add((Control)(object)Label7);
		((Control)Panel1).get_Controls().Add((Control)(object)Label9);
		((Control)Panel1).get_Controls().Add((Control)(object)Label3);
		((Control)Panel1).get_Controls().Add((Control)(object)Label2);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox1);
		Panel panel = Panel1;
		location = new Point(0, 24);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(491, 225);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(2);
		Label13.set_AutoSize(true);
		((Control)Label13).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label13).set_ForeColor(Color.DodgerBlue);
		Label label = Label13;
		location = new Point(12, 141);
		((Control)label).set_Location(location);
		((Control)Label13).set_Name("Label13");
		Label label2 = Label13;
		size = new Size(46, 16);
		((Control)label2).set_Size(size);
		((Control)Label13).set_TabIndex(58);
		Label13.set_Text("Credits");
		Label12.set_AutoSize(true);
		((Control)Label12).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label12).set_ForeColor(Color.DodgerBlue);
		Label label3 = Label12;
		location = new Point(223, 141);
		((Control)label3).set_Location(location);
		((Control)Label12).set_Name("Label12");
		Label label4 = Label12;
		size = new Size(93, 16);
		((Control)label4).set_Size(size);
		((Control)Label12).set_TabIndex(57);
		Label12.set_Text(" Код сниффера");
		Label11.set_AutoSize(true);
		((Control)Label11).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_ForeColor(Color.DodgerBlue);
		Label label5 = Label11;
		location = new Point(214, 141);
		((Control)label5).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label6 = Label11;
		size = new Size(14, 16);
		((Control)label6).set_Size(size);
		((Control)Label11).set_TabIndex(56);
		Label11.set_Text("_");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.DodgerBlue);
		Label label7 = Label7;
		location = new Point(105, 141);
		((Control)label7).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label8 = Label7;
		size = new Size(12, 16);
		((Control)label8).set_Size(size);
		((Control)Label7).set_TabIndex(55);
		Label7.set_Text(":");
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.DodgerBlue);
		Label label9 = Label9;
		location = new Point(105, 113);
		((Control)label9).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label10 = Label9;
		size = new Size(12, 16);
		((Control)label10).set_Size(size);
		((Control)Label9).set_TabIndex(45);
		Label9.set_Text(":");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.DodgerBlue);
		Label label11 = Label3;
		location = new Point(123, 141);
		((Control)label11).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label12 = Label3;
		size = new Size(94, 16);
		((Control)label12).set_Size(size);
		((Control)Label3).set_TabIndex(39);
		Label3.set_Text("SaherBlue Eagle");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Trebuchet MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.DodgerBlue);
		Label label13 = Label2;
		location = new Point(158, 111);
		((Control)label13).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label14 = Label2;
		size = new Size(103, 18);
		((Control)label14).set_Size(size);
		((Control)Label2).set_TabIndex(38);
		Label2.set_Text("Cyber SpLiTTer");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.DodgerBlue);
		Label label15 = Label1;
		location = new Point(12, 113);
		((Control)label15).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label16 = Label1;
		size = new Size(71, 16);
		((Control)label16).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Created By ");
		PictureBox pictureBox = PictureBox1;
		location = new Point(3, 0);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(485, 10);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(3);
		PictureBox1.set_TabStop(false);
		((Control)GClass0_0).set_BackColor(Color.Transparent);
		GClass0_0.ImageBitmap = (Bitmap)componentResourceManager.GetObject("تأثيرالماء3.ImageBitmap");
		GClass0 gClass0_ = GClass0_0;
		location = new Point(0, 0);
		((Control)gClass0_).set_Location(location);
		((Control)GClass0_0).set_Name("تأثيرالماء3");
		GClass0_0.Scale = 1;
		GClass0 gClass0_2 = GClass0_0;
		size = new Size(390, 101);
		((Control)gClass0_2).set_Size(size);
		((Control)GClass0_0).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(390, 212);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)BlackShadesNetForm1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form5");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("About");
		((Form)this).set_TransparencyKey(Color.Fuchsia);
		((Control)BlackShadesNetForm1).ResumeLayout(false);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void BlackShadesNetForm1_Click(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_5(), (AudioPlayMode)1);
	}

	private void Label2_Click(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void Label13_Click(object sender, EventArgs e)
	{
	}
}
