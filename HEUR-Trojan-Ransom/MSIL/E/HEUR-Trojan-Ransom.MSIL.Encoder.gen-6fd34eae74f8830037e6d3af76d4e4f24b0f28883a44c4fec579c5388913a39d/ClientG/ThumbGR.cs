using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClientG.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[DesignerGenerated]
public class ThumbGR : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

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
			_PictureBox1 = value;
		}
	}

	internal virtual PictureBox PictureBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox3_Click;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).remove_Click(eventHandler);
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).add_Click(eventHandler);
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
	public ThumbGR()
	{
		((Form)this).add_Load((EventHandler)ThumbGR_Load);
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ThumbGR));
		PictureBox1 = new PictureBox();
		PictureBox3 = new PictureBox();
		PictureBox2 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)PictureBox1).set_BackColor(Color.Black);
		((Control)PictureBox1).set_Dock((DockStyle)5);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(0, 0);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(832, 443);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)3);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		((Control)PictureBox3).set_Anchor((AnchorStyles)10);
		((Control)PictureBox3).set_BackColor(Color.Transparent);
		PictureBox3.set_Image((Image)(object)Resources._1485015177_arrow_maximise);
		PictureBox pictureBox3 = PictureBox3;
		location = new Point(796, 406);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox3).set_Name("PictureBox3");
		PictureBox pictureBox4 = PictureBox3;
		size = new Size(32, 32);
		((Control)pictureBox4).set_Size(size);
		PictureBox3.set_SizeMode((PictureBoxSizeMode)3);
		PictureBox3.set_TabIndex(2);
		PictureBox3.set_TabStop(false);
		((Control)PictureBox3).set_Tag((object)"0");
		((Control)PictureBox2).set_Anchor((AnchorStyles)10);
		((Control)PictureBox2).set_BackColor(Color.Transparent);
		PictureBox2.set_Image((Image)(object)Resources._1487992409_zoom_in);
		PictureBox pictureBox5 = PictureBox2;
		location = new Point(796, 368);
		((Control)pictureBox5).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox6 = PictureBox2;
		size = new Size(32, 32);
		((Control)pictureBox6).set_Size(size);
		PictureBox2.set_SizeMode((PictureBoxSizeMode)3);
		PictureBox2.set_TabIndex(3);
		PictureBox2.set_TabStop(false);
		((Control)PictureBox2).set_Tag((object)"0");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(832, 443);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox3);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("ThumbGR");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Thumb");
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		try
		{
			if (Operators.ConditionalCompareObjectEqual(((Control)PictureBox3).get_Tag(), (object)"0", false))
			{
				((Control)PictureBox3).set_Tag((object)"1");
				PictureBox3.set_Image((Image)(object)Resources._1485015206_arrow_minimise);
				((Control)this).FindForm().set_WindowState((FormWindowState)2);
			}
			else
			{
				((Control)PictureBox3).set_Tag((object)"0");
				PictureBox3.set_Image((Image)(object)Resources._1485015177_arrow_maximise);
				((Control)this).FindForm().set_WindowState((FormWindowState)0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		try
		{
			if (Operators.ConditionalCompareObjectEqual(((Control)PictureBox2).get_Tag(), (object)"0", false))
			{
				((Control)PictureBox2).set_Tag((object)"1");
				PictureBox2.set_Image((Image)(object)Resources._1487992424_zoom_out);
				PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
			}
			else
			{
				((Control)PictureBox2).set_Tag((object)"0");
				PictureBox2.set_Image((Image)(object)Resources._1487992409_zoom_in);
				PictureBox1.set_SizeMode((PictureBoxSizeMode)3);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ThumbGR_Load(object sender, EventArgs e)
	{
	}
}
