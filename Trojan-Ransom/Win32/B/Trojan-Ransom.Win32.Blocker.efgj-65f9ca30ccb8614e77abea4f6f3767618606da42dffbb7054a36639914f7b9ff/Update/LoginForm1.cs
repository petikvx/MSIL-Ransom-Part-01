using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Update;

[DesignerGenerated]
public class LoginForm1 : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	internal PictureBox pictureBox_0;

	internal Label label_0;

	internal Label label_1;

	internal TextBox textBox_0;

	internal TextBox textBox_1;

	internal Button button_0;

	internal Button button_1;

	internal IContainer icontainer_0;

	public LoginForm1()
	{
		smethod_0(this);
		InitializeComponent();
	}

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

	[SpecialName]
	internal virtual PictureBox vmethod_0()
	{
		return pictureBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(PictureBox pictureBox_1)
	{
		PictureBox val = (pictureBox_0 = pictureBox_1);
	}

	[SpecialName]
	internal virtual Label vmethod_2()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Label label_2)
	{
		Label val = (label_0 = label_2);
	}

	[SpecialName]
	internal virtual Label vmethod_4()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(Label label_2)
	{
		Label val = (label_1 = label_2);
	}

	[SpecialName]
	internal virtual TextBox vmethod_6()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(TextBox textBox_2)
	{
		TextBox val = (textBox_0 = textBox_2);
	}

	[SpecialName]
	internal virtual TextBox vmethod_8()
	{
		return textBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(TextBox textBox_2)
	{
		TextBox val = (textBox_1 = textBox_2);
	}

	[SpecialName]
	internal virtual Button vmethod_10()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(Button button_2)
	{
		EventHandler eventHandler = method_0;
		if (button_0 != null)
		{
			((Control)button_0).remove_Click(eventHandler);
		}
		Button val = (button_0 = button_2);
		if (button_0 != null)
		{
			((Control)button_0).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button vmethod_12()
	{
		return button_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(Button button_2)
	{
		EventHandler eventHandler = method_1;
		if (button_1 != null)
		{
			((Control)button_1).remove_Click(eventHandler);
		}
		Button val = (button_1 = button_2);
		if (button_1 != null)
		{
			((Control)button_1).add_Click(eventHandler);
		}
	}

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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LoginForm1));
		vmethod_1(new PictureBox());
		vmethod_3(new Label());
		vmethod_5(new Label());
		vmethod_7(new TextBox());
		vmethod_9(new TextBox());
		vmethod_11(new Button());
		vmethod_13(new Button());
		((ISupportInitialize)vmethod_0()).BeginInit();
		((Control)this).SuspendLayout();
		vmethod_0().set_Image((Image)componentResourceManager.GetObject("LogoPictureBox.Image"));
		PictureBox obj = vmethod_0();
		Point location = new Point(0, 0);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("LogoPictureBox");
		PictureBox obj2 = vmethod_0();
		Size size = new Size(165, 193);
		((Control)obj2).set_Size(size);
		vmethod_0().set_TabIndex(0);
		vmethod_0().set_TabStop(false);
		Label obj3 = vmethod_2();
		location = new Point(172, 24);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("UsernameLabel");
		Label obj4 = vmethod_2();
		size = new Size(220, 23);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(0);
		vmethod_2().set_Text("&User name");
		vmethod_2().set_TextAlign((ContentAlignment)16);
		Label obj5 = vmethod_4();
		location = new Point(172, 81);
		((Control)obj5).set_Location(location);
		((Control)vmethod_4()).set_Name("PasswordLabel");
		Label obj6 = vmethod_4();
		size = new Size(220, 23);
		((Control)obj6).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(2);
		vmethod_4().set_Text("&Password");
		vmethod_4().set_TextAlign((ContentAlignment)16);
		TextBox obj7 = vmethod_6();
		location = new Point(174, 44);
		((Control)obj7).set_Location(location);
		((Control)vmethod_6()).set_Name("UsernameTextBox");
		TextBox obj8 = vmethod_6();
		size = new Size(220, 20);
		((Control)obj8).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(1);
		TextBox obj9 = vmethod_8();
		location = new Point(174, 101);
		((Control)obj9).set_Location(location);
		((Control)vmethod_8()).set_Name("PasswordTextBox");
		vmethod_8().set_PasswordChar('*');
		TextBox obj10 = vmethod_8();
		size = new Size(220, 20);
		((Control)obj10).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(3);
		Button obj11 = vmethod_10();
		location = new Point(197, 161);
		((Control)obj11).set_Location(location);
		((Control)vmethod_10()).set_Name("OK");
		Button obj12 = vmethod_10();
		size = new Size(94, 23);
		((Control)obj12).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(4);
		((ButtonBase)vmethod_10()).set_Text("&OK");
		vmethod_12().set_DialogResult((DialogResult)2);
		Button obj13 = vmethod_12();
		location = new Point(300, 161);
		((Control)obj13).set_Location(location);
		((Control)vmethod_12()).set_Name("Cancel");
		Button obj14 = vmethod_12();
		size = new Size(94, 23);
		((Control)obj14).set_Size(size);
		((Control)vmethod_12()).set_TabIndex(5);
		((ButtonBase)vmethod_12()).set_Text("&Cancel");
		((Form)this).set_AcceptButton((IButtonControl)(object)vmethod_10());
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)vmethod_12());
		size = new Size(401, 192);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_12());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("LoginForm1");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("LoginForm1");
		((ISupportInitialize)vmethod_0()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void method_0(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void method_1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
