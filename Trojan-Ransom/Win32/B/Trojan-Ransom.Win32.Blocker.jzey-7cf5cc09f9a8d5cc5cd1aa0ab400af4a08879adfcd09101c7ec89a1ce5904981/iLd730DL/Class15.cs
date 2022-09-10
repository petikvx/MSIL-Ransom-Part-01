using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace iLd730DL;

internal class Class15
{
	internal static void e6ru47tw(Graphics graphics_0, Pen pen_0, Point point_0, Point point_1, int int_0)
	{
		switch (int_0 ^ 0xD2DB)
		{
		}
		graphics_0.DrawLine(pen_0, point_0, point_1);
	}

	internal static Type[] AgvPkUOx(object[] object_0, int int_0)
	{
		return (int_0 ^ 0xCC49) switch
		{
			_ => Type.GetTypeArray(object_0), 
		};
	}

	internal static MethodInfo ohQ0YYe2(Type type_0, string string_0, BindingFlags bindingFlags_0, Binder binder_0, CallingConventions callingConventions_0, Type[] type_1, ParameterModifier[] parameterModifier_0, int int_0)
	{
		return (int_0 ^ 0xB7EE) switch
		{
			_ => type_0.GetMethod(string_0, bindingFlags_0, binder_0, callingConventions_0, type_1, parameterModifier_0), 
		};
	}

	internal static object Yg20dYyl(MethodBase methodBase_0, object object_0, BindingFlags bindingFlags_0, Binder binder_0, object[] object_1, CultureInfo cultureInfo_0, int int_0)
	{
		return (int_0 ^ 0xC44B) switch
		{
			_ => methodBase_0.Invoke(object_0, bindingFlags_0, binder_0, object_1, cultureInfo_0), 
		};
	}

	internal static char[] ftpBFsac(string string_0, int int_0)
	{
		return (int_0 ^ 0x4A6E) switch
		{
			_ => string_0.ToCharArray(), 
		};
	}

	internal static int Xcu2ie9g(string string_0, char[] char_0, int int_0)
	{
		return (int_0 ^ 0xF221) switch
		{
			_ => string_0.IndexOfAny(char_0), 
		};
	}

	internal static CultureInfo kJu0kMKf(int int_0)
	{
		return (int_0 ^ 0xB043) switch
		{
			_ => CultureInfo.InvariantCulture, 
		};
	}

	internal static double SovO4tjC(string string_0, IFormatProvider iformatProvider_0, int int_0)
	{
		return (int_0 ^ 0x13EA) switch
		{
			_ => double.Parse(string_0, iformatProvider_0), 
		};
	}

	internal static SizeF HaAQudSW(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		return (int_0 ^ 0x42E7) switch
		{
			_ => graphics_0.MeasureString(string_0, font_0), 
		};
	}

	internal static PointF smethod_0(Point point_0, int int_0)
	{
		return (int_0 ^ 0xD7A6) switch
		{
			_ => point_0, 
		};
	}

	internal static void smethod_1(Graphics graphics_0, string string_0, Font font_0, Brush brush_0, RectangleF rectangleF_0, int int_0)
	{
		switch (int_0 ^ 0xA891)
		{
		}
		graphics_0.DrawString(string_0, font_0, brush_0, rectangleF_0);
	}

	internal static char I9IgXm7u(string string_0, int int_0, int int_1)
	{
		return (int_1 ^ 0x673E) switch
		{
			_ => string_0[int_0], 
		};
	}

	internal static StringBuilder TSl8DiL7(StringBuilder stringBuilder_0, char char_0, int int_0)
	{
		return (int_0 ^ 0x5F71) switch
		{
			_ => stringBuilder_0.Append(char_0), 
		};
	}

	internal static string QySGJYLH(StringBuilder stringBuilder_0, int int_0)
	{
		return (int_0 ^ 0x8094) switch
		{
			_ => stringBuilder_0.ToString(), 
		};
	}

	internal static void EKGiNP89(TextBoxBase textBoxBase_0, Color color_0, int int_0)
	{
		switch (int_0 ^ 0xD096)
		{
		default:
			textBoxBase_0.set_ForeColor(color_0);
			break;
		case 1:
			textBoxBase_0.set_BackColor(color_0);
			break;
		}
	}

	internal static void smethod_2(TrackBar trackBar_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0x1292)
		{
		default:
			trackBar_0.set_Maximum(int_0);
			break;
		case 1:
			trackBar_0.set_TickFrequency(int_0);
			break;
		case 2:
			trackBar_0.set_Value(int_0);
			break;
		}
	}

	internal static void wzSCQB6O(CheckBox checkBox_0, CheckState checkState_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0x7C6F)
		{
		}
		checkBox_0.set_CheckState(checkState_0);
	}

	internal static void smethod_3(RadioButton radioButton_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x626B)
		{
		default:
			radioButton_0.set_TabStop(bool_0);
			break;
		case 1:
			radioButton_0.set_Checked(bool_0);
			break;
		}
	}

	internal static void o1CcFPG3(RadioButton radioButton_0, EventHandler eventHandler_0, int int_0)
	{
		switch (int_0 ^ 0x496D)
		{
		default:
			radioButton_0.remove_CheckedChanged(eventHandler_0);
			break;
		case 1:
			radioButton_0.add_CheckedChanged(eventHandler_0);
			break;
		}
	}

	internal static void JbYwaqDf(TrackBar trackBar_0, EventHandler eventHandler_0, int int_0)
	{
		switch (int_0 ^ 0xF39B)
		{
		default:
			trackBar_0.remove_ValueChanged(eventHandler_0);
			break;
		case 1:
			trackBar_0.add_ValueChanged(eventHandler_0);
			break;
		}
	}
}
