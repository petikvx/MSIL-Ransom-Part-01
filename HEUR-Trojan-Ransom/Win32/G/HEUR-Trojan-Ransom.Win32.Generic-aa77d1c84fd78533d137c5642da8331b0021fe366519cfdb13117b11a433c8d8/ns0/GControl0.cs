using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[DesignerGenerated]
public class GControl0 : UserControl
{
	private object object_0;

	[AccessedThroughProperty("btnMagnifier")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_0;

	internal virtual Button btnMagnifier
	{
		[CompilerGenerated]
		get
		{
			return button_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			button_0 = value;
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			bool flag = disposing && object_0 != null;
			if (0 == 0 && flag)
			{
				_ = 0;
				if (smethod_2())
				{
					smethod_0(object_0);
				}
			}
		}
		finally
		{
			smethod_1(this, disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		while (true)
		{
			smethod_4(this, (object)new Button());
			while (true)
			{
				smethod_5(this);
				while (true)
				{
					smethod_7(smethod_6(this), bool_0: true);
					_ = 1;
					if (smethod_3())
					{
						goto IL_0214;
					}
					goto IL_00ed;
					IL_00ed:
					smethod_9(smethod_6(this), smethod_8());
					goto IL_0039;
					IL_0039:
					smethod_11(smethod_6(this), smethod_10());
					goto IL_0049;
					IL_0049:
					smethod_12(smethod_6(this), (ImageLayout)2);
					goto IL_0055;
					IL_0055:
					smethod_13(smethod_6(this), (object)new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					int num = 21;
					if (!smethod_3())
					{
						goto IL_0102;
					}
					goto IL_0172;
					IL_0102:
					while (true)
					{
						switch (num)
						{
						case 16:
							break;
						case 22:
							smethod_31(this);
							num = 25;
							if (smethod_2())
							{
								continue;
							}
							goto IL_0039;
						case 13:
							goto IL_0039;
						case 19:
							goto IL_0049;
						case 20:
							goto IL_0055;
						case 21:
							smethod_14(smethod_6(this), (ContentAlignment)2);
							num = 11;
							if (smethod_2())
							{
								continue;
							}
							goto IL_0192;
						case 17:
							smethod_27(smethod_26(this), smethod_6(this));
							goto case 6;
						case 6:
							smethod_28(this, "UCMagnifier");
							num = 8;
							if (smethod_2())
							{
								continue;
							}
							goto end_IL_0236;
						case 9:
							smethod_30(this, bool_0: false);
							goto case 22;
						case 8:
							smethod_29(this, new Size(86, 81));
							goto case 9;
						case 1:
						case 3:
							goto IL_00ed;
						case 14:
							goto IL_0172;
						case 18:
							goto IL_0192;
						case 15:
							goto IL_019b;
						case 0:
							goto IL_01b2;
						case 2:
							goto IL_01c0;
						default:
							goto IL_01d2;
						case 7:
							goto IL_01e4;
						case 11:
							smethod_15(smethod_6(this), new Point(0, 0));
							goto case 5;
						case 5:
							smethod_16(smethod_6(this), "btnMagnifier");
							goto IL_0214;
						case 10:
						case 24:
							goto IL_0214;
						case 23:
							goto end_IL_0006;
						case 4:
							goto end_IL_0236;
						case 25:
							return;
						}
						break;
					}
					continue;
					IL_0214:
					smethod_17(smethod_6(this), new Size(78, 75));
					goto IL_01e4;
					IL_01e4:
					smethod_18(smethod_6(this), 0);
					goto IL_01d2;
					IL_01d2:
					smethod_19(smethod_6(this), "Magnifier");
					goto IL_01c0;
					IL_01c0:
					smethod_20(smethod_6(this), (ContentAlignment)256);
					goto IL_01b2;
					IL_01b2:
					smethod_21(smethod_6(this), bool_0: false);
					goto IL_019b;
					IL_019b:
					smethod_22(this, new SizeF(6f, 13f));
					goto IL_0192;
					IL_0192:
					smethod_23(this, (AutoScaleMode)1);
					goto IL_0172;
					IL_0172:
					smethod_25(this, smethod_24());
					num = 17;
					if (smethod_3())
					{
						continue;
					}
					goto IL_0102;
					continue;
					end_IL_0006:
					break;
				}
				continue;
				end_IL_0236:
				break;
			}
		}
	}

	public GControl0()
	{
		smethod_32(this);
		_ = 0;
		if (smethod_2())
		{
			method_0();
		}
		method_1((Control)(object)this);
	}

	private void method_1(Control control_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = (IEnumerator)smethod_34(smethod_33(control_0));
			Control val = default(Control);
			bool flag2 = default(bool);
			while (true)
			{
				bool flag = smethod_38(enumerator);
				int num = 8;
				if (smethod_3())
				{
					continue;
				}
				while (true)
				{
					switch (num)
					{
					case 8:
						if (flag)
						{
							val = (Control)smethod_35(enumerator);
							num = 6;
							if (smethod_3())
							{
							}
							continue;
						}
						return;
					case 5:
						flag2 = smethod_37(val);
						goto default;
					default:
						_ = 0;
						if (smethod_2())
						{
							num = 0;
							if (!smethod_3())
							{
								continue;
							}
							goto case 6;
						}
						num = 2;
						if (!smethod_3())
						{
							continue;
						}
						goto case 8;
					case 6:
						smethod_36(val, new EventHandler(method_2));
						goto case 5;
					case 0:
					case 3:
						if (!flag2)
						{
							break;
						}
						goto case 2;
					case 2:
					case 4:
						method_1(val);
						break;
					case 1:
					case 7:
						break;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				smethod_0(enumerator as IDisposable);
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		smethod_39(this, this, EventArgs.Empty);
	}

	internal static void smethod_0(object object_1)
	{
		((IDisposable)object_1).Dispose();
	}

	internal static void smethod_1(object object_1, bool bool_0)
	{
		((ContainerControl)object_1).Dispose(bool_0);
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static bool smethod_3()
	{
		return false;
	}

	internal static void smethod_4(object object_1, object object_2)
	{
		((GControl0)object_1).btnMagnifier = (Button)object_2;
	}

	internal static void smethod_5(object object_1)
	{
		((Control)object_1).SuspendLayout();
	}

	internal static object smethod_6(object object_1)
	{
		return ((GControl0)object_1).btnMagnifier;
	}

	internal static void smethod_7(object object_1, bool bool_0)
	{
		((ButtonBase)object_1).set_AutoSize(bool_0);
	}

	internal static Color smethod_8()
	{
		return Color.White;
	}

	internal static void smethod_9(object object_1, Color color_0)
	{
		((ButtonBase)object_1).set_BackColor(color_0);
	}

	internal static object smethod_10()
	{
		return Class20.smethod_1();
	}

	internal static void smethod_11(object object_1, object object_2)
	{
		((Control)object_1).set_BackgroundImage((Image)object_2);
	}

	internal static void smethod_12(object object_1, ImageLayout imageLayout_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_1).set_BackgroundImageLayout(imageLayout_0);
	}

	internal static void smethod_13(object object_1, object object_2)
	{
		((Control)object_1).set_Font((Font)object_2);
	}

	internal static void smethod_14(object object_1, ContentAlignment contentAlignment_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ButtonBase)object_1).set_ImageAlign(contentAlignment_0);
	}

	internal static void smethod_15(object object_1, Point point_0)
	{
		((Control)object_1).set_Location(point_0);
	}

	internal static void smethod_16(object object_1, object object_2)
	{
		((Control)object_1).set_Name((string)object_2);
	}

	internal static void smethod_17(object object_1, Size size_0)
	{
		((Control)object_1).set_Size(size_0);
	}

	internal static void smethod_18(object object_1, int int_0)
	{
		((Control)object_1).set_TabIndex(int_0);
	}

	internal static void smethod_19(object object_1, object object_2)
	{
		((ButtonBase)object_1).set_Text((string)object_2);
	}

	internal static void smethod_20(object object_1, ContentAlignment contentAlignment_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ButtonBase)object_1).set_TextAlign(contentAlignment_0);
	}

	internal static void smethod_21(object object_1, bool bool_0)
	{
		((ButtonBase)object_1).set_UseVisualStyleBackColor(bool_0);
	}

	internal static void smethod_22(object object_1, SizeF sizeF_0)
	{
		((ContainerControl)object_1).set_AutoScaleDimensions(sizeF_0);
	}

	internal static void smethod_23(object object_1, AutoScaleMode autoScaleMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)object_1).set_AutoScaleMode(autoScaleMode_0);
	}

	internal static Color smethod_24()
	{
		return Color.Transparent;
	}

	internal static void smethod_25(object object_1, Color color_0)
	{
		((Control)object_1).set_BackColor(color_0);
	}

	internal static object smethod_26(object object_1)
	{
		return ((Control)object_1).get_Controls();
	}

	internal static void smethod_27(object object_1, object object_2)
	{
		((ControlCollection)object_1).Add((Control)object_2);
	}

	internal static void smethod_28(object object_1, object object_2)
	{
		((Control)object_1).set_Name((string)object_2);
	}

	internal static void smethod_29(object object_1, Size size_0)
	{
		((Control)object_1).set_Size(size_0);
	}

	internal static void smethod_30(object object_1, bool bool_0)
	{
		((Control)object_1).ResumeLayout(bool_0);
	}

	internal static void smethod_31(object object_1)
	{
		((Control)object_1).PerformLayout();
	}

	internal static void smethod_32(object object_1)
	{
		((UserControl)object_1)._002Ector();
	}

	internal static object smethod_33(object object_1)
	{
		return ((Control)object_1).get_Controls();
	}

	internal static object smethod_34(object object_1)
	{
		return ((ControlCollection)object_1).GetEnumerator();
	}

	internal static object smethod_35(object object_1)
	{
		return ((IEnumerator)object_1).Current;
	}

	internal static void smethod_36(object object_1, object object_2)
	{
		((Control)object_1).add_Click((EventHandler)object_2);
	}

	internal static bool smethod_37(object object_1)
	{
		return ((Control)object_1).get_HasChildren();
	}

	internal static bool smethod_38(object object_1)
	{
		return ((IEnumerator)object_1).MoveNext();
	}

	internal static void smethod_39(object object_1, object object_2, object object_3)
	{
		((Control)object_1).InvokeOnClick((Control)object_2, (EventArgs)object_3);
	}
}
