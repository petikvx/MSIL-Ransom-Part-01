using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace nO_bUILDER;

[DesignerGenerated]
public class Form2 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	private bool drag;

	private int mousex;

	private int mousey;

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

	internal virtual PictureBox PictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox2_Click;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).remove_Click(eventHandler);
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public Form2()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Form)this).add_Load((EventHandler)Form2_DoubleClick);
		((Control)this).add_MouseDown(new MouseEventHandler(Form1_MouseDown));
		((Control)this).add_MouseMove(new MouseEventHandler(Form1_MouseMove));
		((Control)this).add_MouseUp(new MouseEventHandler(Form1_MouseUp));
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		PictureBox1 = new PictureBox();
		PictureBox2 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(1, 101);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(305, 66);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)2);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		PictureBox2.set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(1, 12);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(299, 67);
		((Control)pictureBox4).set_Size(size);
		PictureBox2.set_SizeMode((PictureBoxSizeMode)2);
		PictureBox2.set_TabIndex(1);
		PictureBox2.set_TabStop(false);
		((Control)PictureBox2).set_Visible(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)2);
		size = new Size(318, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_Text("Form2");
		((Form)this).set_TransparencyKey(Color.Transparent);
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
	}

	private void Form2_DoubleClick(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void Form1_MouseDown(object sender, MouseEventArgs e)
	{
		drag = true;
		checked
		{
			mousex = Cursor.get_Position().X - ((Control)this).get_Left();
			mousey = Cursor.get_Position().Y - ((Control)this).get_Top();
		}
	}

	private void Form1_MouseMove(object sender, MouseEventArgs e)
	{
		checked
		{
			if (drag)
			{
				((Control)this).set_Top(Cursor.get_Position().Y - mousey);
				((Control)this).set_Left(Cursor.get_Position().X - mousex);
			}
		}
	}

	private void Form1_MouseUp(object sender, MouseEventArgs e)
	{
		drag = false;
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
	}
}
