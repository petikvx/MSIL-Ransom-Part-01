using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0;

public sealed class GForm0 : Form
{
	private int int_0;

	private volatile GEnum0 genum0_0;

	private volatile bool bool_0;

	private volatile int int_1;

	private IContainer icontainer_0;

	private Label label_0;

	private PictureBox pictureBox_0;

	private PictureBox pictureBox_1;

	private PictureBox pictureBox_2;

	private PictureBox pictureBox_3;

	private PictureBox pictureBox_4;

	private PictureBox pictureBox_5;

	private PictureBox pictureBox_6;

	private PictureBox pictureBox_7;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private PictureBox pictureBox_8;

	private PictureBox pictureBox_9;

	private GroupBox groupBox_0;

	private Label label_8;

	private Label label_9;

	private Label label_10;

	private Label label_11;

	private Label label_12;

	private Label label_13;

	private Label label_14;

	private Label label_15;

	private Label label_16;

	private GroupBox groupBox_1;

	private Label label_17;

	private GroupBox groupBox_2;

	private GroupBox groupBox_3;

	private Label label_18;

	private Label label_19;

	private Label label_20;

	private Label label_21;

	private Label label_22;

	private Label label_23;

	private Label label_24;

	private Label label_25;

	private Label label_26;

	private PictureBox pictureBox_10;

	private PictureBox pictureBox_11;

	private PictureBox pictureBox_12;

	private PictureBox pictureBox_13;

	private PictureBox pictureBox_14;

	private PictureBox pictureBox_15;

	private PictureBox pictureBox_16;

	private Label label_27;

	private Label label_28;

	private Label label_29;

	private Label label_30;

	private Label label_31;

	private Label label_32;

	private GroupBox groupBox_4;

	private Label label_33;

	public GForm0()
	{
		method_23();
		Delegate89.smethod_0(this, 255);
		Delegate138.smethod_0(this, 720);
		Delegate103.smethod_0(pictureBox_8, (Image)(object)Delegate120.smethod_0());
		Delegate103.smethod_0(pictureBox_9, (Image)(object)Delegate9.smethod_0());
		int_0 = 0;
		genum0_0 = GEnum0.const_0;
		bool_0 = false;
	}

	public void method_0(string string_0)
	{
		Delegate67.smethod_0(label_26, string_0);
	}

	public void method_1(string string_0)
	{
		string text = "";
		string_0 = Delegate98.smethod_0(string_0);
		string[] array = Delegate50.smethod_0(string_0, new char[1] { ',' });
		if (array.Length == 4)
		{
			text = Delegate31.smethod_0(Delegate18.smethod_0(Delegate72.smethod_0(array[3]), 2), 8, '0');
			method_2(text);
			text = Delegate31.smethod_0(Delegate18.smethod_0(Delegate72.smethod_0(array[0]), 2), 8, '0');
			for (int i = 0; i < 8; i++)
			{
				method_22(i + 1, Delegate0.smethod_0(text, 7 - i) == '1');
			}
			text = Delegate31.smethod_0(Delegate18.smethod_0(Delegate72.smethod_0(array[1]), 2), 8, '0');
			for (int j = 0; j < 8; j++)
			{
				method_22(j + 9, Delegate0.smethod_0(text, 7 - j) == '1');
			}
			text = Delegate31.smethod_0(Delegate18.smethod_0(Delegate72.smethod_0(array[2]), 2), 8, '0');
			for (int k = 0; k < 8; k++)
			{
				method_22(k + 17, Delegate0.smethod_0(text, 7 - k) == '1');
			}
		}
	}

	private void method_2(string string_0)
	{
		if (Delegate40.smethod_0(string_0, "00000001"))
		{
			int_0 = 1;
		}
		else if (Delegate40.smethod_0(string_0, "00000011"))
		{
			int_0 = 2;
		}
		else if (Delegate40.smethod_0(string_0, "00000010"))
		{
			int_0 = 3;
		}
		else if (Delegate40.smethod_0(string_0, "00000110"))
		{
			int_0 = 4;
		}
		else if (Delegate40.smethod_0(string_0, "00000111"))
		{
			int_0 = 5;
		}
		else if (Delegate40.smethod_0(string_0, "00000101"))
		{
			int_0 = 6;
		}
		else if (Delegate40.smethod_0(string_0, "00000100"))
		{
			int_0 = 7;
		}
		else if (Delegate40.smethod_0(string_0, "00001100"))
		{
			int_0 = 8;
		}
		else if (Delegate40.smethod_0(string_0, "00001101"))
		{
			int_0 = 9;
		}
		else if (Delegate40.smethod_0(string_0, "00001111"))
		{
			int_0 = 10;
		}
		else if (Delegate40.smethod_0(string_0, "00001110"))
		{
			int_0 = 11;
		}
		else if (Delegate40.smethod_0(string_0, "00001010"))
		{
			int_0 = 12;
		}
		else if (Delegate40.smethod_0(string_0, "00001011"))
		{
			int_0 = 13;
		}
		else if (Delegate40.smethod_0(string_0, "00001001"))
		{
			int_0 = 14;
		}
		else if (Delegate40.smethod_0(string_0, "00001000"))
		{
			int_0 = 15;
		}
	}

	private void method_3()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		Delegate103.smethod_0(pictureBox_7, null);
		Delegate45.smethod_0(pictureBox_7, new PaintEventHandler(method_18));
		Delegate103.smethod_0(pictureBox_6, null);
		Delegate45.smethod_0(pictureBox_6, new PaintEventHandler(method_17));
		Delegate103.smethod_0(pictureBox_5, null);
		Delegate45.smethod_0(pictureBox_5, new PaintEventHandler(method_16));
		Delegate103.smethod_0(pictureBox_4, null);
		Delegate45.smethod_0(pictureBox_4, new PaintEventHandler(method_15));
		Delegate103.smethod_0(pictureBox_0, null);
		Delegate45.smethod_0(pictureBox_0, new PaintEventHandler(method_14));
		Delegate103.smethod_0(pictureBox_1, null);
		Delegate45.smethod_0(pictureBox_1, new PaintEventHandler(method_13));
		Delegate103.smethod_0(pictureBox_2, null);
		Delegate45.smethod_0(pictureBox_2, new PaintEventHandler(method_12));
		Delegate103.smethod_0(pictureBox_3, null);
		Delegate45.smethod_0(pictureBox_3, new PaintEventHandler(method_11));
		Delegate103.smethod_0(pictureBox_14, null);
		Delegate45.smethod_0(pictureBox_14, new PaintEventHandler(method_10));
		Delegate103.smethod_0(pictureBox_13, null);
		Delegate45.smethod_0(pictureBox_13, new PaintEventHandler(method_9));
		Delegate103.smethod_0(pictureBox_12, null);
		Delegate45.smethod_0(pictureBox_12, new PaintEventHandler(method_8));
		Delegate103.smethod_0(pictureBox_11, null);
		Delegate45.smethod_0(pictureBox_11, new PaintEventHandler(method_7));
		Delegate103.smethod_0(pictureBox_10, null);
		Delegate45.smethod_0(pictureBox_10, new PaintEventHandler(method_6));
		Delegate103.smethod_0(pictureBox_16, null);
		Delegate45.smethod_0(pictureBox_16, new PaintEventHandler(method_5));
		Delegate103.smethod_0(pictureBox_15, null);
		Delegate45.smethod_0(pictureBox_15, new PaintEventHandler(method_4));
	}

	private void method_4(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_15);
	}

	private void method_5(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_16);
	}

	private void method_6(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_10);
	}

	private void method_7(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_11);
	}

	private void method_8(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_12);
	}

	private void method_9(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_13);
	}

	private void method_10(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_14);
	}

	private void method_11(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_3);
	}

	private void method_12(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_2);
	}

	private void method_13(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_1);
	}

	private void method_14(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_0);
	}

	private void method_15(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_4);
	}

	private void method_16(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_5);
	}

	private void method_17(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_6);
	}

	private void method_18(object sender, PaintEventArgs e)
	{
		method_19(pictureBox_7);
	}

	private void method_19(PictureBox pictureBox_17)
	{
		if (int_1 == 2)
		{
			Delegate80.smethod_0(pictureBox_17, bool_0: false);
			bool_0 = false;
			method_21();
		}
		int_1++;
	}

	public void method_20()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected O, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected O, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected O, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected O, but got Unknown
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected O, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected O, but got Unknown
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected O, but got Unknown
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected O, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected O, but got Unknown
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected O, but got Unknown
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected O, but got Unknown
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected O, but got Unknown
		if (bool_0 || int_0 == 0)
		{
			return;
		}
		bool_0 = true;
		method_3();
		if (genum0_0 == GEnum0.const_1)
		{
			if (int_0 == 1)
			{
				Delegate58.smethod_0(pictureBox_7, new PaintEventHandler(method_18));
				Delegate80.smethod_0(pictureBox_7, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_7, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 2)
			{
				Delegate58.smethod_0(pictureBox_6, new PaintEventHandler(method_17));
				Delegate80.smethod_0(pictureBox_6, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_6, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 3)
			{
				Delegate58.smethod_0(pictureBox_5, new PaintEventHandler(method_16));
				Delegate80.smethod_0(pictureBox_5, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_5, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 4)
			{
				Delegate58.smethod_0(pictureBox_4, new PaintEventHandler(method_15));
				Delegate80.smethod_0(pictureBox_4, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_4, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 5)
			{
				Delegate58.smethod_0(pictureBox_0, new PaintEventHandler(method_14));
				Delegate80.smethod_0(pictureBox_0, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_0, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 6)
			{
				Delegate58.smethod_0(pictureBox_1, new PaintEventHandler(method_13));
				Delegate80.smethod_0(pictureBox_1, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_1, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 7)
			{
				Delegate58.smethod_0(pictureBox_2, new PaintEventHandler(method_12));
				Delegate80.smethod_0(pictureBox_2, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_2, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 8)
			{
				Delegate58.smethod_0(pictureBox_3, new PaintEventHandler(method_11));
				Delegate80.smethod_0(pictureBox_3, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_3, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 9)
			{
				Delegate58.smethod_0(pictureBox_14, new PaintEventHandler(method_10));
				Delegate80.smethod_0(pictureBox_14, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_14, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 10)
			{
				Delegate58.smethod_0(pictureBox_13, new PaintEventHandler(method_9));
				Delegate80.smethod_0(pictureBox_13, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_13, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 11)
			{
				Delegate58.smethod_0(pictureBox_12, new PaintEventHandler(method_8));
				Delegate80.smethod_0(pictureBox_12, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_12, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 12)
			{
				Delegate58.smethod_0(pictureBox_11, new PaintEventHandler(method_7));
				Delegate80.smethod_0(pictureBox_11, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_11, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 13)
			{
				Delegate58.smethod_0(pictureBox_10, new PaintEventHandler(method_6));
				Delegate80.smethod_0(pictureBox_10, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_10, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 14)
			{
				Delegate58.smethod_0(pictureBox_16, new PaintEventHandler(method_5));
				Delegate80.smethod_0(pictureBox_16, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_16, (Image)(object)Delegate39.smethod_0());
			}
			else if (int_0 == 15)
			{
				Delegate58.smethod_0(pictureBox_15, new PaintEventHandler(method_4));
				Delegate80.smethod_0(pictureBox_15, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_15, (Image)(object)Delegate39.smethod_0());
			}
		}
		else if (genum0_0 == GEnum0.const_2)
		{
			if (int_0 == 1)
			{
				Delegate58.smethod_0(pictureBox_7, new PaintEventHandler(method_18));
				Delegate80.smethod_0(pictureBox_7, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_7, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 2)
			{
				Delegate58.smethod_0(pictureBox_6, new PaintEventHandler(method_17));
				Delegate80.smethod_0(pictureBox_6, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_6, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 3)
			{
				Delegate58.smethod_0(pictureBox_5, new PaintEventHandler(method_16));
				Delegate80.smethod_0(pictureBox_5, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_5, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 4)
			{
				Delegate58.smethod_0(pictureBox_4, new PaintEventHandler(method_15));
				Delegate80.smethod_0(pictureBox_4, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_4, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 5)
			{
				Delegate58.smethod_0(pictureBox_0, new PaintEventHandler(method_14));
				Delegate80.smethod_0(pictureBox_0, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_0, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 6)
			{
				Delegate58.smethod_0(pictureBox_1, new PaintEventHandler(method_13));
				Delegate80.smethod_0(pictureBox_1, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_1, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 7)
			{
				Delegate58.smethod_0(pictureBox_2, new PaintEventHandler(method_12));
				Delegate80.smethod_0(pictureBox_2, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_2, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 8)
			{
				Delegate58.smethod_0(pictureBox_3, new PaintEventHandler(method_11));
				Delegate80.smethod_0(pictureBox_3, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_3, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 9)
			{
				Delegate58.smethod_0(pictureBox_14, new PaintEventHandler(method_10));
				Delegate80.smethod_0(pictureBox_14, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_14, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 10)
			{
				Delegate58.smethod_0(pictureBox_13, new PaintEventHandler(method_9));
				Delegate80.smethod_0(pictureBox_13, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_13, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 11)
			{
				Delegate58.smethod_0(pictureBox_12, new PaintEventHandler(method_8));
				Delegate80.smethod_0(pictureBox_12, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_12, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 12)
			{
				Delegate58.smethod_0(pictureBox_11, new PaintEventHandler(method_7));
				Delegate80.smethod_0(pictureBox_11, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_11, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 13)
			{
				Delegate58.smethod_0(pictureBox_10, new PaintEventHandler(method_6));
				Delegate80.smethod_0(pictureBox_10, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_10, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 14)
			{
				Delegate58.smethod_0(pictureBox_16, new PaintEventHandler(method_5));
				Delegate80.smethod_0(pictureBox_16, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_16, (Image)(object)Delegate66.smethod_0());
			}
			else if (int_0 == 15)
			{
				Delegate58.smethod_0(pictureBox_15, new PaintEventHandler(method_4));
				Delegate80.smethod_0(pictureBox_15, bool_0: true);
				int_1 = 0;
				Delegate103.smethod_0(pictureBox_15, (Image)(object)Delegate66.smethod_0());
			}
		}
	}

	public void method_21()
	{
		if (bool_0)
		{
			return;
		}
		method_3();
		if (genum0_0 == GEnum0.const_1)
		{
			if (int_0 == 1)
			{
				Delegate103.smethod_0(pictureBox_7, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 2)
			{
				Delegate103.smethod_0(pictureBox_6, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 3)
			{
				Delegate103.smethod_0(pictureBox_5, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 4)
			{
				Delegate103.smethod_0(pictureBox_4, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 5)
			{
				Delegate103.smethod_0(pictureBox_0, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 6)
			{
				Delegate103.smethod_0(pictureBox_1, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 7)
			{
				Delegate103.smethod_0(pictureBox_2, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 8)
			{
				Delegate103.smethod_0(pictureBox_3, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 9)
			{
				Delegate103.smethod_0(pictureBox_14, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 10)
			{
				Delegate103.smethod_0(pictureBox_13, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 11)
			{
				Delegate103.smethod_0(pictureBox_12, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 12)
			{
				Delegate103.smethod_0(pictureBox_11, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 13)
			{
				Delegate103.smethod_0(pictureBox_10, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 14)
			{
				Delegate103.smethod_0(pictureBox_16, (Image)(object)Delegate132.smethod_0());
			}
			else if (int_0 == 15)
			{
				Delegate103.smethod_0(pictureBox_15, (Image)(object)Delegate132.smethod_0());
			}
		}
		else if (genum0_0 == GEnum0.const_2)
		{
			if (int_0 == 1)
			{
				Delegate103.smethod_0(pictureBox_7, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 2)
			{
				Delegate103.smethod_0(pictureBox_6, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 3)
			{
				Delegate103.smethod_0(pictureBox_5, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 4)
			{
				Delegate103.smethod_0(pictureBox_4, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 5)
			{
				Delegate103.smethod_0(pictureBox_0, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 6)
			{
				Delegate103.smethod_0(pictureBox_1, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 7)
			{
				Delegate103.smethod_0(pictureBox_2, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 8)
			{
				Delegate103.smethod_0(pictureBox_3, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 9)
			{
				Delegate103.smethod_0(pictureBox_14, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 10)
			{
				Delegate103.smethod_0(pictureBox_13, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 11)
			{
				Delegate103.smethod_0(pictureBox_12, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 12)
			{
				Delegate103.smethod_0(pictureBox_11, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 13)
			{
				Delegate103.smethod_0(pictureBox_10, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 14)
			{
				Delegate103.smethod_0(pictureBox_16, (Image)(object)Delegate62.smethod_0());
			}
			else if (int_0 == 15)
			{
				Delegate103.smethod_0(pictureBox_15, (Image)(object)Delegate62.smethod_0());
			}
		}
	}

	public void method_22(int int_2, bool bool_1)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		switch (int_2)
		{
		case 11:
			if (bool_1)
			{
				Delegate103.smethod_0(pictureBox_8, (Image)(object)Delegate4.smethod_0());
			}
			else
			{
				Delegate103.smethod_0(pictureBox_8, (Image)(object)Delegate120.smethod_0());
			}
			return;
		case 12:
			if (bool_1)
			{
				Delegate103.smethod_0(pictureBox_9, (Image)(object)Delegate71.smethod_0());
			}
			else
			{
				Delegate103.smethod_0(pictureBox_9, (Image)(object)Delegate9.smethod_0());
			}
			return;
		case 16:
			if (bool_1)
			{
				if (genum0_0 != GEnum0.const_1)
				{
					genum0_0 = GEnum0.const_1;
					method_20();
				}
				else
				{
					method_21();
				}
				return;
			}
			break;
		}
		if (int_2 == 17 && bool_1)
		{
			if (genum0_0 != GEnum0.const_2)
			{
				genum0_0 = GEnum0.const_2;
				method_20();
			}
			else
			{
				method_21();
			}
			return;
		}
		if (int_2 >= 25 && bool_1)
		{
			int_0 = int_2 - 24;
			method_21();
			return;
		}
		IEnumerator enumerator = Delegate142.smethod_0(Delegate13.smethod_1(this));
		try
		{
			while (Delegate119.smethod_0(enumerator))
			{
				Control object_ = (Control)Delegate124.smethod_0(enumerator);
				if (!Delegate93.smethod_0(object_))
				{
					continue;
				}
				IEnumerator enumerator2 = Delegate142.smethod_0(Delegate13.smethod_0(object_));
				try
				{
					while (Delegate119.smethod_0(enumerator2))
					{
						Control object_2 = (Control)Delegate124.smethod_0(enumerator2);
						if (Delegate115.smethod_0(object_2) == null || Delegate72.smethod_0((string)Delegate115.smethod_0(object_2)) != int_2)
						{
							continue;
						}
						if (bool_1)
						{
							Color color_ = Delegate97.smethod_0();
							Color color_2 = Delegate8.smethod_0();
							string string_ = Delegate84.smethod_0(Delegate115.smethod_0(Delegate107.smethod_0(Delegate13.smethod_0(object_))));
							if (Delegate40.smethod_0(string_, "power"))
							{
								color_2 = Delegate26.smethod_0();
								color_ = Delegate97.smethod_0();
							}
							else if (Delegate40.smethod_0(string_, "status"))
							{
								color_2 = Delegate26.smethod_0();
								color_ = Delegate97.smethod_0();
							}
							else if (Delegate40.smethod_0(string_, "fire"))
							{
								color_2 = Delegate30.smethod_0();
								color_ = Delegate88.smethod_0();
							}
							else if (Delegate40.smethod_0(string_, "alarm"))
							{
								color_2 = Delegate137.smethod_0();
								color_ = Delegate97.smethod_0();
							}
							Delegate111.smethod_0(object_2, color_);
							Delegate128.smethod_0(object_2, color_2);
						}
						else
						{
							Delegate111.smethod_0(object_2, Delegate88.smethod_0());
							Delegate128.smethod_0(object_2, Delegate8.smethod_0());
						}
						return;
					}
				}
				finally
				{
					if (enumerator2 is IDisposable object_3)
					{
						Delegate17.smethod_0(object_3);
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable object_4)
			{
				Delegate17.smethod_0(object_4);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			Delegate17.smethod_0(icontainer_0);
		}
		Delegate35.smethod_0(this, disposing);
	}

	private void method_23()
	{
		label_0 = Delegate140.smethod_0();
		pictureBox_0 = Delegate69.smethod_0();
		pictureBox_1 = Delegate69.smethod_0();
		pictureBox_2 = Delegate69.smethod_0();
		pictureBox_3 = Delegate69.smethod_0();
		pictureBox_4 = Delegate69.smethod_0();
		pictureBox_5 = Delegate69.smethod_0();
		pictureBox_6 = Delegate69.smethod_0();
		pictureBox_7 = Delegate69.smethod_0();
		label_1 = Delegate140.smethod_0();
		label_2 = Delegate140.smethod_0();
		label_3 = Delegate140.smethod_0();
		label_4 = Delegate140.smethod_0();
		label_5 = Delegate140.smethod_0();
		label_6 = Delegate140.smethod_0();
		label_7 = Delegate140.smethod_0();
		pictureBox_8 = Delegate69.smethod_0();
		pictureBox_9 = Delegate69.smethod_0();
		groupBox_0 = Delegate91.smethod_0();
		label_27 = Delegate140.smethod_0();
		label_28 = Delegate140.smethod_0();
		label_29 = Delegate140.smethod_0();
		label_30 = Delegate140.smethod_0();
		label_31 = Delegate140.smethod_0();
		label_32 = Delegate140.smethod_0();
		pictureBox_15 = Delegate69.smethod_0();
		pictureBox_16 = Delegate69.smethod_0();
		pictureBox_10 = Delegate69.smethod_0();
		pictureBox_11 = Delegate69.smethod_0();
		pictureBox_12 = Delegate69.smethod_0();
		pictureBox_13 = Delegate69.smethod_0();
		pictureBox_14 = Delegate69.smethod_0();
		label_8 = Delegate140.smethod_0();
		label_9 = Delegate140.smethod_0();
		label_10 = Delegate140.smethod_0();
		label_11 = Delegate140.smethod_0();
		label_12 = Delegate140.smethod_0();
		label_13 = Delegate140.smethod_0();
		label_14 = Delegate140.smethod_0();
		label_15 = Delegate140.smethod_0();
		label_16 = Delegate140.smethod_0();
		groupBox_1 = Delegate91.smethod_0();
		label_17 = Delegate140.smethod_0();
		groupBox_2 = Delegate91.smethod_0();
		label_24 = Delegate140.smethod_0();
		label_25 = Delegate140.smethod_0();
		groupBox_3 = Delegate91.smethod_0();
		label_19 = Delegate140.smethod_0();
		label_20 = Delegate140.smethod_0();
		label_21 = Delegate140.smethod_0();
		label_22 = Delegate140.smethod_0();
		label_23 = Delegate140.smethod_0();
		label_18 = Delegate140.smethod_0();
		label_26 = Delegate140.smethod_0();
		groupBox_4 = Delegate91.smethod_0();
		label_33 = Delegate140.smethod_0();
		Delegate122.smethod_0(pictureBox_0);
		Delegate122.smethod_0(pictureBox_1);
		Delegate122.smethod_0(pictureBox_2);
		Delegate122.smethod_0(pictureBox_3);
		Delegate122.smethod_0(pictureBox_4);
		Delegate122.smethod_0(pictureBox_5);
		Delegate122.smethod_0(pictureBox_6);
		Delegate122.smethod_0(pictureBox_7);
		Delegate122.smethod_0(pictureBox_8);
		Delegate122.smethod_0(pictureBox_9);
		Delegate11.smethod_1(groupBox_0);
		Delegate122.smethod_0(pictureBox_15);
		Delegate122.smethod_0(pictureBox_16);
		Delegate122.smethod_0(pictureBox_10);
		Delegate122.smethod_0(pictureBox_11);
		Delegate122.smethod_0(pictureBox_12);
		Delegate122.smethod_0(pictureBox_13);
		Delegate122.smethod_0(pictureBox_14);
		Delegate11.smethod_1(groupBox_1);
		Delegate11.smethod_1(groupBox_2);
		Delegate11.smethod_1(groupBox_3);
		Delegate11.smethod_1(groupBox_4);
		Delegate11.smethod_0(this);
		Delegate109.smethod_0(label_0, bool_0: true);
		Delegate126.smethod_0(label_0, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_0, new Point(19, 360));
		Delegate44.smethod_1(label_0, "label1");
		Delegate15.smethod_0(label_0, new Size(19, 20));
		Delegate130.smethod_0(label_0, 4);
		Delegate67.smethod_0(label_0, "5");
		Delegate117.smethod_0(pictureBox_0, new Point(44, 468));
		Delegate44.smethod_1(pictureBox_0, "pbf5");
		Delegate15.smethod_0(pictureBox_0, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_0, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_0, 3);
		Delegate82.smethod_0(pictureBox_0, bool_0: false);
		Delegate117.smethod_0(pictureBox_1, new Point(44, 427));
		Delegate44.smethod_1(pictureBox_1, "pbf6");
		Delegate15.smethod_0(pictureBox_1, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_1, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_1, 2);
		Delegate82.smethod_0(pictureBox_1, bool_0: false);
		Delegate117.smethod_0(pictureBox_2, new Point(44, 386));
		Delegate44.smethod_1(pictureBox_2, "pbf7");
		Delegate15.smethod_0(pictureBox_2, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_2, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_2, 1);
		Delegate82.smethod_0(pictureBox_2, bool_0: false);
		Delegate117.smethod_0(pictureBox_3, new Point(44, 345));
		Delegate44.smethod_1(pictureBox_3, "pbf8");
		Delegate15.smethod_0(pictureBox_3, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_3, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_3, 0);
		Delegate82.smethod_0(pictureBox_3, bool_0: false);
		Delegate117.smethod_0(pictureBox_4, new Point(44, 509));
		Delegate44.smethod_1(pictureBox_4, "pbf4");
		Delegate15.smethod_0(pictureBox_4, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_4, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_4, 4);
		Delegate82.smethod_0(pictureBox_4, bool_0: false);
		Delegate117.smethod_0(pictureBox_5, new Point(44, 550));
		Delegate44.smethod_1(pictureBox_5, "pbf3");
		Delegate15.smethod_0(pictureBox_5, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_5, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_5, 5);
		Delegate82.smethod_0(pictureBox_5, bool_0: false);
		Delegate117.smethod_0(pictureBox_6, new Point(44, 591));
		Delegate44.smethod_1(pictureBox_6, "pbf2");
		Delegate15.smethod_0(pictureBox_6, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_6, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_6, 7);
		Delegate82.smethod_0(pictureBox_6, bool_0: false);
		Delegate117.smethod_0(pictureBox_7, new Point(44, 632));
		Delegate44.smethod_1(pictureBox_7, "pbf1");
		Delegate15.smethod_0(pictureBox_7, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_7, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_7, 8);
		Delegate82.smethod_0(pictureBox_7, bool_0: false);
		Delegate109.smethod_0(label_1, bool_0: true);
		Delegate126.smethod_0(label_1, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_1, new Point(19, 401));
		Delegate44.smethod_1(label_1, "label2");
		Delegate15.smethod_0(label_1, new Size(19, 20));
		Delegate130.smethod_0(label_1, 9);
		Delegate67.smethod_0(label_1, "3");
		Delegate109.smethod_0(label_2, bool_0: true);
		Delegate126.smethod_0(label_2, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_2, new Point(19, 442));
		Delegate44.smethod_1(label_2, "label3");
		Delegate15.smethod_0(label_2, new Size(19, 20));
		Delegate130.smethod_0(label_2, 10);
		Delegate67.smethod_0(label_2, "2");
		Delegate109.smethod_0(label_3, bool_0: true);
		Delegate126.smethod_0(label_3, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_3, new Point(7, 647));
		Delegate44.smethod_1(label_3, "label4");
		Delegate15.smethod_0(label_3, new Size(31, 20));
		Delegate130.smethod_0(label_3, 11);
		Delegate67.smethod_0(label_3, "B2");
		Delegate109.smethod_0(label_4, bool_0: true);
		Delegate126.smethod_0(label_4, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_4, new Point(7, 606));
		Delegate44.smethod_1(label_4, "label5");
		Delegate15.smethod_0(label_4, new Size(31, 20));
		Delegate130.smethod_0(label_4, 12);
		Delegate67.smethod_0(label_4, "B1");
		Delegate109.smethod_0(label_5, bool_0: true);
		Delegate126.smethod_0(label_5, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_5, new Point(5, 565));
		Delegate44.smethod_1(label_5, "label6");
		Delegate15.smethod_0(label_5, new Size(33, 20));
		Delegate130.smethod_0(label_5, 13);
		Delegate67.smethod_0(label_5, "SB");
		Delegate109.smethod_0(label_6, bool_0: true);
		Delegate126.smethod_0(label_6, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_6, new Point(15, 524));
		Delegate44.smethod_1(label_6, "label7");
		Delegate15.smethod_0(label_6, new Size(23, 20));
		Delegate130.smethod_0(label_6, 14);
		Delegate67.smethod_0(label_6, "G");
		Delegate109.smethod_0(label_7, bool_0: true);
		Delegate126.smethod_0(label_7, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_7, new Point(15, 483));
		Delegate44.smethod_1(label_7, "label8");
		Delegate15.smethod_0(label_7, new Size(23, 20));
		Delegate130.smethod_0(label_7, 15);
		Delegate67.smethod_0(label_7, "M");
		Delegate117.smethod_0(pictureBox_8, new Point(10, 11));
		Delegate44.smethod_1(pictureBox_8, "pbup");
		Delegate15.smethod_0(pictureBox_8, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_8, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_8, 16);
		Delegate82.smethod_0(pictureBox_8, bool_0: false);
		Delegate117.smethod_0(pictureBox_9, new Point(51, 11));
		Delegate44.smethod_1(pictureBox_9, "pbdown");
		Delegate15.smethod_0(pictureBox_9, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_9, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_9, 17);
		Delegate82.smethod_0(pictureBox_9, bool_0: false);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_33);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_27);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_28);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_29);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_30);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_31);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_32);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_15);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_16);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_10);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_11);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_12);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_13);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_14);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_0);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_9);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_4);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_8);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_1);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_7);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_2);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_6);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_5);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_5);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_3);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_4);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_6);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_3);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_0);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_2);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)pictureBox_7);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_0), (Control)(object)label_1);
		Delegate117.smethod_0(groupBox_0, new Point(5, 32));
		Delegate44.smethod_1(groupBox_0, "groupBox1");
		Delegate15.smethod_0(groupBox_0, new Size(102, 678));
		Delegate130.smethod_0(groupBox_0, 18);
		Delegate95.smethod_0(groupBox_0, bool_0: false);
		Delegate109.smethod_0(label_27, bool_0: true);
		Delegate126.smethod_0(label_27, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_27, new Point(9, 114));
		Delegate44.smethod_1(label_27, "label14");
		Delegate15.smethod_0(label_27, new Size(29, 20));
		Delegate130.smethod_0(label_27, 30);
		Delegate67.smethod_0(label_27, "11");
		Delegate109.smethod_0(label_28, bool_0: true);
		Delegate126.smethod_0(label_28, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_28, new Point(9, 155));
		Delegate44.smethod_1(label_28, "label13");
		Delegate15.smethod_0(label_28, new Size(29, 20));
		Delegate130.smethod_0(label_28, 29);
		Delegate67.smethod_0(label_28, "10");
		Delegate109.smethod_0(label_29, bool_0: true);
		Delegate126.smethod_0(label_29, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_29, new Point(19, 195));
		Delegate44.smethod_1(label_29, "label12");
		Delegate15.smethod_0(label_29, new Size(19, 20));
		Delegate130.smethod_0(label_29, 28);
		Delegate67.smethod_0(label_29, "9");
		Delegate109.smethod_0(label_30, bool_0: true);
		Delegate126.smethod_0(label_30, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_30, new Point(19, 237));
		Delegate44.smethod_1(label_30, "label11");
		Delegate15.smethod_0(label_30, new Size(19, 20));
		Delegate130.smethod_0(label_30, 27);
		Delegate67.smethod_0(label_30, "8");
		Delegate109.smethod_0(label_31, bool_0: true);
		Delegate126.smethod_0(label_31, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_31, new Point(19, 278));
		Delegate44.smethod_1(label_31, "label10");
		Delegate15.smethod_0(label_31, new Size(19, 20));
		Delegate130.smethod_0(label_31, 26);
		Delegate67.smethod_0(label_31, "7");
		Delegate109.smethod_0(label_32, bool_0: true);
		Delegate126.smethod_0(label_32, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_32, new Point(19, 319));
		Delegate44.smethod_1(label_32, "label9");
		Delegate15.smethod_0(label_32, new Size(19, 20));
		Delegate130.smethod_0(label_32, 25);
		Delegate67.smethod_0(label_32, "6");
		Delegate117.smethod_0(pictureBox_15, new Point(44, 58));
		Delegate44.smethod_1(pictureBox_15, "pbf15");
		Delegate15.smethod_0(pictureBox_15, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_15, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_15, 24);
		Delegate82.smethod_0(pictureBox_15, bool_0: false);
		Delegate117.smethod_0(pictureBox_16, new Point(44, 99));
		Delegate44.smethod_1(pictureBox_16, "pbf14");
		Delegate15.smethod_0(pictureBox_16, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_16, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_16, 23);
		Delegate82.smethod_0(pictureBox_16, bool_0: false);
		Delegate117.smethod_0(pictureBox_10, new Point(44, 140));
		Delegate44.smethod_1(pictureBox_10, "pbf13");
		Delegate15.smethod_0(pictureBox_10, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_10, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_10, 22);
		Delegate82.smethod_0(pictureBox_10, bool_0: false);
		Delegate117.smethod_0(pictureBox_11, new Point(44, 181));
		Delegate44.smethod_1(pictureBox_11, "pbf12");
		Delegate15.smethod_0(pictureBox_11, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_11, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_11, 21);
		Delegate82.smethod_0(pictureBox_11, bool_0: false);
		Delegate117.smethod_0(pictureBox_12, new Point(44, 222));
		Delegate44.smethod_1(pictureBox_12, "pbf11");
		Delegate15.smethod_0(pictureBox_12, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_12, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_12, 20);
		Delegate82.smethod_0(pictureBox_12, bool_0: false);
		Delegate117.smethod_0(pictureBox_13, new Point(44, 263));
		Delegate44.smethod_1(pictureBox_13, "pbf10");
		Delegate15.smethod_0(pictureBox_13, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_13, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_13, 19);
		Delegate82.smethod_0(pictureBox_13, bool_0: false);
		Delegate117.smethod_0(pictureBox_14, new Point(44, 304));
		Delegate44.smethod_1(pictureBox_14, "pbf9");
		Delegate15.smethod_0(pictureBox_14, new Size(35, 35));
		Delegate105.smethod_0(pictureBox_14, (PictureBoxSizeMode)1);
		Delegate113.smethod_0(pictureBox_14, 18);
		Delegate82.smethod_0(pictureBox_14, bool_0: false);
		Delegate128.smethod_0(label_8, Delegate8.smethod_0());
		Delegate24.smethod_0(label_8, (BorderStyle)1);
		Delegate117.smethod_0(label_8, new Point(6, 20));
		Delegate44.smethod_1(label_8, "status1");
		Delegate15.smethod_0(label_8, new Size(60, 20));
		Delegate130.smethod_0(label_8, 19);
		Delegate86.smethod_0(label_8, "1");
		Delegate67.smethod_0(label_8, "NORL");
		Delegate28.smethod_0(label_8, (ContentAlignment)32);
		Delegate128.smethod_0(label_9, Delegate8.smethod_0());
		Delegate24.smethod_0(label_9, (BorderStyle)1);
		Delegate117.smethod_0(label_9, new Point(6, 20));
		Delegate44.smethod_1(label_9, "status6");
		Delegate15.smethod_0(label_9, new Size(60, 20));
		Delegate130.smethod_0(label_9, 24);
		Delegate86.smethod_0(label_9, "6");
		Delegate67.smethod_0(label_9, "RUN");
		Delegate28.smethod_0(label_9, (ContentAlignment)32);
		Delegate128.smethod_0(label_10, Delegate8.smethod_0());
		Delegate24.smethod_0(label_10, (BorderStyle)1);
		Delegate117.smethod_0(label_10, new Point(6, 16));
		Delegate44.smethod_1(label_10, "status5");
		Delegate15.smethod_0(label_10, new Size(60, 20));
		Delegate130.smethod_0(label_10, 23);
		Delegate86.smethod_0(label_10, "5");
		Delegate67.smethod_0(label_10, "FECL");
		Delegate28.smethod_0(label_10, (ContentAlignment)32);
		Delegate128.smethod_0(label_11, Delegate8.smethod_0());
		Delegate24.smethod_0(label_11, (BorderStyle)1);
		Delegate117.smethod_0(label_11, new Point(6, 61));
		Delegate44.smethod_1(label_11, "status7");
		Delegate15.smethod_0(label_11, new Size(60, 20));
		Delegate130.smethod_0(label_11, 25);
		Delegate86.smethod_0(label_11, "7");
		Delegate67.smethod_0(label_11, "INDL");
		Delegate28.smethod_0(label_11, (ContentAlignment)32);
		Delegate128.smethod_0(label_12, Delegate8.smethod_0());
		Delegate24.smethod_0(label_12, (BorderStyle)1);
		Delegate117.smethod_0(label_12, new Point(5, 184));
		Delegate44.smethod_1(label_12, "status14");
		Delegate15.smethod_0(label_12, new Size(60, 20));
		Delegate130.smethod_0(label_12, 30);
		Delegate86.smethod_0(label_12, "14");
		Delegate67.smethod_0(label_12, "RUNL");
		Delegate28.smethod_0(label_12, (ContentAlignment)32);
		Delegate128.smethod_0(label_13, Delegate8.smethod_0());
		Delegate24.smethod_0(label_13, (BorderStyle)1);
		Delegate117.smethod_0(label_13, new Point(6, 16));
		Delegate44.smethod_1(label_13, "status13");
		Delegate15.smethod_0(label_13, new Size(60, 20));
		Delegate130.smethod_0(label_13, 29);
		Delegate86.smethod_0(label_13, "13");
		Delegate67.smethod_0(label_13, "CON");
		Delegate28.smethod_0(label_13, (ContentAlignment)32);
		Delegate128.smethod_0(label_14, Delegate8.smethod_0());
		Delegate24.smethod_0(label_14, (BorderStyle)1);
		Delegate117.smethod_0(label_14, new Point(6, 102));
		Delegate44.smethod_1(label_14, "status24");
		Delegate15.smethod_0(label_14, new Size(60, 20));
		Delegate130.smethod_0(label_14, 38);
		Delegate86.smethod_0(label_14, "24");
		Delegate67.smethod_0(label_14, "OLH");
		Delegate28.smethod_0(label_14, (ContentAlignment)32);
		Delegate128.smethod_0(label_15, Delegate8.smethod_0());
		Delegate24.smethod_0(label_15, (BorderStyle)1);
		Delegate117.smethod_0(label_15, new Point(6, 59));
		Delegate44.smethod_1(label_15, "status22");
		Delegate15.smethod_0(label_15, new Size(60, 20));
		Delegate130.smethod_0(label_15, 36);
		Delegate86.smethod_0(label_15, "22");
		Delegate67.smethod_0(label_15, "FEL");
		Delegate28.smethod_0(label_15, (ContentAlignment)32);
		Delegate128.smethod_0(label_16, Delegate8.smethod_0());
		Delegate24.smethod_0(label_16, (BorderStyle)1);
		Delegate117.smethod_0(label_16, new Point(6, 143));
		Delegate44.smethod_1(label_16, "status18");
		Delegate15.smethod_0(label_16, new Size(60, 20));
		Delegate130.smethod_0(label_16, 32);
		Delegate86.smethod_0(label_16, "18");
		Delegate67.smethod_0(label_16, "HANDMD");
		Delegate28.smethod_0(label_16, (ContentAlignment)32);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_1), (Control)(object)label_17);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_1), (Control)(object)label_8);
		Delegate117.smethod_0(groupBox_1, new Point(114, 518));
		Delegate44.smethod_1(groupBox_1, "groupBox2");
		Delegate15.smethod_0(groupBox_1, new Size(133, 106));
		Delegate130.smethod_0(groupBox_1, 39);
		Delegate95.smethod_0(groupBox_1, bool_0: false);
		Delegate86.smethod_0(groupBox_1, "power");
		Delegate67.smethod_0(groupBox_1, "Power");
		Delegate109.smethod_0(label_17, bool_0: true);
		Delegate111.smethod_0(label_17, Delegate135.smethod_0());
		Delegate117.smethod_0(label_17, new Point(3, 40));
		Delegate44.smethod_1(label_17, "label38");
		Delegate15.smethod_0(label_17, new Size(54, 13));
		Delegate130.smethod_0(label_17, 53);
		Delegate67.smethod_0(label_17, "Power On");
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_2), (Control)(object)label_24);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_2), (Control)(object)label_25);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_2), (Control)(object)label_10);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_2), (Control)(object)label_15);
		Delegate117.smethod_0(groupBox_2, new Point(113, 295));
		Delegate44.smethod_1(groupBox_2, "groupBox3");
		Delegate15.smethod_0(groupBox_2, new Size(134, 105));
		Delegate130.smethod_0(groupBox_2, 40);
		Delegate95.smethod_0(groupBox_2, bool_0: false);
		Delegate86.smethod_0(groupBox_2, "fire");
		Delegate67.smethod_0(groupBox_2, "Fire");
		Delegate109.smethod_0(label_24, bool_0: true);
		Delegate111.smethod_0(label_24, Delegate135.smethod_0());
		Delegate117.smethod_0(label_24, new Point(3, 79));
		Delegate44.smethod_1(label_24, "label46");
		Delegate15.smethod_0(label_24, new Size(93, 13));
		Delegate130.smethod_0(label_24, 58);
		Delegate67.smethod_0(label_24, "Fireman Operation");
		Delegate109.smethod_0(label_25, bool_0: true);
		Delegate111.smethod_0(label_25, Delegate135.smethod_0());
		Delegate117.smethod_0(label_25, new Point(3, 36));
		Delegate44.smethod_1(label_25, "label44");
		Delegate15.smethod_0(label_25, new Size(115, 13));
		Delegate130.smethod_0(label_25, 59);
		Delegate67.smethod_0(label_25, "Fire Emergency Return");
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_3), (Control)(object)label_19);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_3), (Control)(object)label_20);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_3), (Control)(object)label_21);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_3), (Control)(object)label_22);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_3), (Control)(object)label_23);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_3), (Control)(object)label_9);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_3), (Control)(object)label_16);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_3), (Control)(object)label_12);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_3), (Control)(object)label_14);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_3), (Control)(object)label_11);
		Delegate117.smethod_0(groupBox_3, new Point(113, 43));
		Delegate44.smethod_1(groupBox_3, "groupBox4");
		Delegate15.smethod_0(groupBox_3, new Size(134, 246));
		Delegate130.smethod_0(groupBox_3, 42);
		Delegate95.smethod_0(groupBox_3, bool_0: false);
		Delegate86.smethod_0(groupBox_3, "status");
		Delegate67.smethod_0(groupBox_3, "Status");
		Delegate109.smethod_0(label_19, bool_0: true);
		Delegate111.smethod_0(label_19, Delegate135.smethod_0());
		Delegate117.smethod_0(label_19, new Point(3, 124));
		Delegate44.smethod_1(label_19, "label33");
		Delegate15.smethod_0(label_19, new Size(57, 13));
		Delegate130.smethod_0(label_19, 48);
		Delegate67.smethod_0(label_19, "Over Load");
		Delegate109.smethod_0(label_20, bool_0: true);
		Delegate111.smethod_0(label_20, Delegate135.smethod_0());
		Delegate117.smethod_0(label_20, new Point(3, 164));
		Delegate44.smethod_1(label_20, "label32");
		Delegate15.smethod_0(label_20, new Size(53, 13));
		Delegate130.smethod_0(label_20, 47);
		Delegate67.smethod_0(label_20, "Hand Op.");
		Delegate109.smethod_0(label_21, bool_0: true);
		Delegate111.smethod_0(label_21, Delegate135.smethod_0());
		Delegate117.smethod_0(label_21, new Point(3, 82));
		Delegate44.smethod_1(label_21, "label22");
		Delegate15.smethod_0(label_21, new Size(67, 13));
		Delegate130.smethod_0(label_21, 45);
		Delegate67.smethod_0(label_21, "Independent");
		Delegate109.smethod_0(label_22, bool_0: true);
		Delegate111.smethod_0(label_22, Delegate135.smethod_0());
		Delegate117.smethod_0(label_22, new Point(3, 205));
		Delegate44.smethod_1(label_22, "label21");
		Delegate15.smethod_0(label_22, new Size(53, 13));
		Delegate130.smethod_0(label_22, 44);
		Delegate67.smethod_0(label_22, "Operation");
		Delegate109.smethod_0(label_23, bool_0: true);
		Delegate111.smethod_0(label_23, Delegate135.smethod_0());
		Delegate117.smethod_0(label_23, new Point(3, 40));
		Delegate44.smethod_1(label_23, "label20");
		Delegate15.smethod_0(label_23, new Size(54, 13));
		Delegate130.smethod_0(label_23, 43);
		Delegate67.smethod_0(label_23, "Run/Stop");
		Delegate109.smethod_0(label_18, bool_0: true);
		Delegate111.smethod_0(label_18, Delegate135.smethod_0());
		Delegate117.smethod_0(label_18, new Point(4, 36));
		Delegate44.smethod_1(label_18, "label34");
		Delegate15.smethod_0(label_18, new Size(33, 13));
		Delegate130.smethod_0(label_18, 49);
		Delegate67.smethod_0(label_18, "Alarm");
		Delegate128.smethod_0(label_26, Delegate88.smethod_0());
		Delegate126.smethod_0(label_26, Delegate6.smethod_0("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate111.smethod_0(label_26, Delegate97.smethod_0());
		Delegate117.smethod_0(label_26, new Point(0, -1));
		Delegate44.smethod_1(label_26, "description");
		Delegate15.smethod_0(label_26, new Size(259, 30));
		Delegate130.smethod_0(label_26, 43);
		Delegate67.smethod_0(label_26, "DESCRIPTION");
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_4), (Control)(object)label_18);
		Delegate78.smethod_0(Delegate13.smethod_0(groupBox_4), (Control)(object)label_13);
		Delegate117.smethod_0(groupBox_4, new Point(113, 406));
		Delegate44.smethod_1(groupBox_4, "groupBox5");
		Delegate15.smethod_0(groupBox_4, new Size(134, 106));
		Delegate130.smethod_0(groupBox_4, 54);
		Delegate95.smethod_0(groupBox_4, bool_0: false);
		Delegate86.smethod_0(groupBox_4, "alarm");
		Delegate67.smethod_0(groupBox_4, "Alarm");
		Delegate109.smethod_0(label_33, bool_0: true);
		Delegate126.smethod_0(label_33, Delegate6.smethod_0("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, 0));
		Delegate117.smethod_0(label_33, new Point(9, 73));
		Delegate44.smethod_1(label_33, "label15");
		Delegate15.smethod_0(label_33, new Size(29, 20));
		Delegate130.smethod_0(label_33, 31);
		Delegate67.smethod_0(label_33, "12");
		Delegate60.smethod_0(this, new SizeF(6f, 13f));
		Delegate37.smethod_0(this, (AutoScaleMode)1);
		Delegate128.smethod_0(this, Delegate56.smethod_0());
		Delegate64.smethod_0(this, new Size(255, 720));
		Delegate78.smethod_0(Delegate13.smethod_1(this), (Control)(object)groupBox_4);
		Delegate78.smethod_0(Delegate13.smethod_1(this), (Control)(object)label_26);
		Delegate78.smethod_0(Delegate13.smethod_1(this), (Control)(object)groupBox_3);
		Delegate78.smethod_0(Delegate13.smethod_1(this), (Control)(object)groupBox_2);
		Delegate78.smethod_0(Delegate13.smethod_1(this), (Control)(object)groupBox_1);
		Delegate78.smethod_0(Delegate13.smethod_1(this), (Control)(object)groupBox_0);
		Delegate49.smethod_0(this, (FormBorderStyle)0);
		Delegate44.smethod_0(this, "DisplayForm2");
		Delegate102.smethod_0(this, (FormStartPosition)0);
		Delegate67.smethod_0(this, "DisplayForm");
		Delegate54.smethod_0(pictureBox_0);
		Delegate54.smethod_0(pictureBox_1);
		Delegate54.smethod_0(pictureBox_2);
		Delegate54.smethod_0(pictureBox_3);
		Delegate54.smethod_0(pictureBox_4);
		Delegate54.smethod_0(pictureBox_5);
		Delegate54.smethod_0(pictureBox_6);
		Delegate54.smethod_0(pictureBox_7);
		Delegate54.smethod_0(pictureBox_8);
		Delegate54.smethod_0(pictureBox_9);
		Delegate22.smethod_1(groupBox_0, bool_0: false);
		Delegate76.smethod_0(groupBox_0);
		Delegate54.smethod_0(pictureBox_15);
		Delegate54.smethod_0(pictureBox_16);
		Delegate54.smethod_0(pictureBox_10);
		Delegate54.smethod_0(pictureBox_11);
		Delegate54.smethod_0(pictureBox_12);
		Delegate54.smethod_0(pictureBox_13);
		Delegate54.smethod_0(pictureBox_14);
		Delegate22.smethod_1(groupBox_1, bool_0: false);
		Delegate76.smethod_0(groupBox_1);
		Delegate22.smethod_1(groupBox_2, bool_0: false);
		Delegate76.smethod_0(groupBox_2);
		Delegate22.smethod_1(groupBox_3, bool_0: false);
		Delegate76.smethod_0(groupBox_3);
		Delegate22.smethod_1(groupBox_4, bool_0: false);
		Delegate76.smethod_0(groupBox_4);
		Delegate22.smethod_0(this, bool_0: false);
	}
}
