using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class GForm4 : Form
{
	private Graphics graphics_0;

	private Bitmap bitmap_0;

	private Class12 class12_0;

	private Class13 class13_0;

	private List<Class13> list_0;

	private Class13 class13_1;

	private Random random_0;

	private bool bool_0;

	private Class13.Enum1 enum1_0;

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private PictureBox pictureBox_0;

	public GForm4()
	{
		method_11();
		graphics_0 = GForm4.smethod_0((Control)(object)this);
		bitmap_0 = GForm4.smethod_3(GForm4.smethod_1((Control)(object)pictureBox_0), GForm4.smethod_2((Control)(object)pictureBox_0));
		graphics_0 = GForm4.smethod_4((Image)(object)bitmap_0);
	}

	private Class13.Enum1 method_0()
	{
		return (Class13.Enum1)GForm4.smethod_7(random_0, GForm4.smethod_6(GForm4.smethod_5(typeof(Class13.Enum1).TypeHandle)).Length);
	}

	private void method_1(string string_0)
	{
		GForm4.smethod_11(graphics_0, string_0, GForm4.smethod_8("Consolas", 12f), (Brush)(object)GForm4.smethod_9(Color.Black), (float)(GForm4.smethod_10((Form)(object)this).Width / 2 - 40), 20f);
	}

	private void method_2()
	{
		GForm4.smethod_12(timer_0, 250);
		random_0 = GForm4.smethod_13();
		class12_0 = new Class12(0, 0, GForm4.smethod_10((Form)(object)this).Width, GForm4.smethod_10((Form)(object)this).Height, 20);
		class13_0 = new Class13(GForm4.smethod_14(random_0, 20, GForm4.smethod_10((Form)(object)this).Width - 20), GForm4.smethod_14(random_0, 20, GForm4.smethod_10((Form)(object)this).Height - 20));
		list_0 = new List<Class13>();
		list_0.Add(class13_0);
		class13_1 = new Class13(GForm4.smethod_14(random_0, 20, GForm4.smethod_10((Form)(object)this).Width - 20), GForm4.smethod_14(random_0, 20, GForm4.smethod_10((Form)(object)this).Height - 20));
		enum1_0 = method_0();
		bool_0 = false;
	}

	private void method_3(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_4()
	{
		for (int num = list_0.Count - 1; num >= 0; num--)
		{
			if (num == 0)
			{
				list_0[num].method_6(enum1_0);
				for (int i = 1; i < list_0.Count; i++)
				{
					if (list_0[num].Rectangle_0.X == list_0[i].Rectangle_0.X && list_0[num].Rectangle_0.Y == list_0[i].Rectangle_0.Y)
					{
						method_8(bool_1: true);
					}
				}
			}
			else
			{
				Point location = new Point(list_0[num - 1].Rectangle_0.X, list_0[num - 1].Rectangle_0.Y);
				list_0[num].Rectangle_0 = new Rectangle(location, list_0[num - 1].Rectangle_0.Size);
			}
		}
	}

	private void method_5()
	{
		class12_0.method_5(graphics_0);
		class13_1.method_5(graphics_0);
		foreach (Class13 item in list_0)
		{
			item.method_5(graphics_0);
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		GForm4.smethod_15(graphics_0, Color.White);
		method_4();
		method_7();
		method_5();
		method_8();
		method_9();
		GForm4.smethod_16(pictureBox_0, (Image)(object)bitmap_0);
	}

	private void method_7()
	{
		if (class13_0.method_4(class13_1))
		{
			Class13 item = new Class13(list_0[list_0.Count - 1].Rectangle_0.X, list_0[list_0.Count - 1].Rectangle_0.Y);
			list_0.Add(item);
			class13_1 = new Class13(GForm4.smethod_14(random_0, 20, GForm4.smethod_10((Form)(object)this).Width - 20), GForm4.smethod_14(random_0, 20, GForm4.smethod_10((Form)(object)this).Height - 20));
			if (GForm4.smethod_17(timer_0) >= 30)
			{
				Timer timer_ = timer_0;
				GForm4.smethod_12(timer_, GForm4.smethod_17(timer_) - 10);
			}
			else
			{
				GForm4.smethod_12(timer_0, 30);
			}
		}
	}

	private void method_8(bool bool_1 = false)
	{
		if (class13_0.method_0() < 10 || class13_0.method_1() > GForm4.smethod_10((Form)(object)this).Width - 10 || class13_0.method_2() < 10 || class13_0.method_3() > GForm4.smethod_10((Form)(object)this).Height - 10 || bool_1)
		{
			bool_0 = true;
			class13_0.method_7();
			method_1("Game Over!");
		}
	}

	private void method_9()
	{
		if (bool_0)
		{
			GForm4.smethod_18(timer_0);
		}
		else
		{
			GForm4.smethod_19(timer_0);
		}
	}

	private void method_10(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		if ((int)GForm4.smethod_20(e) == 39)
		{
			enum1_0 = Class13.Enum1.Right;
		}
		if ((int)GForm4.smethod_20(e) == 37)
		{
			enum1_0 = Class13.Enum1.Left;
		}
		if ((int)GForm4.smethod_20(e) == 38)
		{
			enum1_0 = Class13.Enum1.Up;
		}
		if ((int)GForm4.smethod_20(e) == 40)
		{
			enum1_0 = Class13.Enum1.Down;
		}
		if ((int)GForm4.smethod_20(e) == 80)
		{
			if (bool_0)
			{
				bool_0 = false;
				GForm4.smethod_19(timer_0);
			}
			else
			{
				bool_0 = true;
			}
		}
		if ((int)GForm4.smethod_20(e) == 32)
		{
			method_2();
			GForm4.smethod_19(timer_0);
		}
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			GForm4.smethod_21((IDisposable)icontainer_0);
		}
		((Form)this).Dispose(disposing);
	}

	private void method_11()
	{
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		icontainer_0 = GForm4.smethod_22();
		timer_0 = GForm4.smethod_23(icontainer_0);
		pictureBox_0 = GForm4.smethod_24();
		GForm4.smethod_25((ISupportInitialize)pictureBox_0);
		GForm4.smethod_26((Control)(object)this);
		GForm4.smethod_27(timer_0, bool_1: true);
		GForm4.smethod_12(timer_0, 250);
		GForm4.smethod_28(timer_0, (EventHandler)method_6);
		GForm4.smethod_29((Control)(object)pictureBox_0, (DockStyle)5);
		GForm4.smethod_30((Control)(object)pictureBox_0, new Point(0, 0));
		GForm4.smethod_31((Control)(object)pictureBox_0, "pictureBox1");
		GForm4.smethod_32((Control)(object)pictureBox_0, new Size(968, 887));
		GForm4.smethod_33(pictureBox_0, 0);
		GForm4.smethod_34(pictureBox_0, bool_1: false);
		GForm4.smethod_35((ContainerControl)(object)this, new SizeF(12f, 25f));
		GForm4.smethod_36((ContainerControl)(object)this, (AutoScaleMode)1);
		GForm4.smethod_37((Form)(object)this, new Size(968, 887));
		GForm4.smethod_39(GForm4.smethod_38((Control)(object)this), (Control)(object)pictureBox_0);
		GForm4.smethod_40((Form)(object)this, bool_1: true);
		GForm4.smethod_41((Form)(object)this, new Padding(6));
		GForm4.smethod_42((Control)(object)this, "Form1");
		GForm4.smethod_43((Control)(object)this, "Snake by Karan Bhamra");
		GForm4.smethod_44((Form)(object)this, (EventHandler)method_3);
		GForm4.smethod_45((Control)(object)this, new KeyEventHandler(method_10));
		GForm4.smethod_46((ISupportInitialize)pictureBox_0);
		GForm4.smethod_47((Control)(object)this, bool_1: false);
		new Class9();
	}

	static Graphics smethod_0(Control control_0)
	{
		return control_0.CreateGraphics();
	}

	static int smethod_1(Control control_0)
	{
		return control_0.get_Width();
	}

	static int smethod_2(Control control_0)
	{
		return control_0.get_Height();
	}

	static Bitmap smethod_3(int int_0, int int_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Bitmap(int_0, int_1);
	}

	static Graphics smethod_4(Image image_0)
	{
		return Graphics.FromImage(image_0);
	}

	static Type smethod_5(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static string[] smethod_6(Type type_0)
	{
		return Enum.GetNames(type_0);
	}

	static int smethod_7(Random random_1, int int_0)
	{
		return random_1.Next(int_0);
	}

	static Font smethod_8(string string_0, float float_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Font(string_0, float_0);
	}

	static SolidBrush smethod_9(Color color_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new SolidBrush(color_0);
	}

	static Size smethod_10(Form form_0)
	{
		return form_0.get_ClientSize();
	}

	static void smethod_11(Graphics graphics_1, string string_0, Font font_0, Brush brush_0, float float_0, float float_1)
	{
		graphics_1.DrawString(string_0, font_0, brush_0, float_0, float_1);
	}

	static void smethod_12(Timer timer_1, int int_0)
	{
		timer_1.set_Interval(int_0);
	}

	static Random smethod_13()
	{
		return new Random();
	}

	static int smethod_14(Random random_1, int int_0, int int_1)
	{
		return random_1.Next(int_0, int_1);
	}

	static void smethod_15(Graphics graphics_1, Color color_0)
	{
		graphics_1.Clear(color_0);
	}

	static void smethod_16(PictureBox pictureBox_1, Image image_0)
	{
		pictureBox_1.set_Image(image_0);
	}

	static int smethod_17(Timer timer_1)
	{
		return timer_1.get_Interval();
	}

	static void smethod_18(Timer timer_1)
	{
		timer_1.Stop();
	}

	static void smethod_19(Timer timer_1)
	{
		timer_1.Start();
	}

	static Keys smethod_20(KeyEventArgs keyEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return keyEventArgs_0.get_KeyCode();
	}

	static void smethod_21(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_22()
	{
		return new Container();
	}

	static Timer smethod_23(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static PictureBox smethod_24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new PictureBox();
	}

	static void smethod_25(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	static void smethod_26(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_27(Timer timer_1, bool bool_1)
	{
		timer_1.set_Enabled(bool_1);
	}

	static void smethod_28(Timer timer_1, EventHandler eventHandler_0)
	{
		timer_1.add_Tick(eventHandler_0);
	}

	static void smethod_29(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
	}

	static void smethod_30(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_31(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_32(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_33(PictureBox pictureBox_1, int int_0)
	{
		pictureBox_1.set_TabIndex(int_0);
	}

	static void smethod_34(PictureBox pictureBox_1, bool bool_1)
	{
		pictureBox_1.set_TabStop(bool_1);
	}

	static void smethod_35(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_36(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_37(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_38(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_39(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_40(Form form_0, bool bool_1)
	{
		form_0.set_KeyPreview(bool_1);
	}

	static void smethod_41(Form form_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_Margin(padding_0);
	}

	static void smethod_42(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_43(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_44(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_45(Control control_0, KeyEventHandler keyEventHandler_0)
	{
		control_0.add_KeyDown(keyEventHandler_0);
	}

	static void smethod_46(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.EndInit();
	}

	static void smethod_47(Control control_0, bool bool_1)
	{
		control_0.ResumeLayout(bool_1);
	}
}
