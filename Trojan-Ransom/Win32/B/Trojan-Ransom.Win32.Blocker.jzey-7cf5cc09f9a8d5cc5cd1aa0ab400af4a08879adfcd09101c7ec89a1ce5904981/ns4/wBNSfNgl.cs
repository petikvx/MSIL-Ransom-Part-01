using System;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns4;

internal class wBNSfNgl
{
	internal static long UHAR69Ut(string string_0, int int_0)
	{
		return (int_0 ^ 0x29D4) switch
		{
			_ => Conversions.ToLong(string_0), 
		};
	}

	internal static char smethod_0(int int_0, int int_1)
	{
		return (int_1 ^ 0x7164) switch
		{
			_ => Strings.Chr(int_0), 
		};
	}

	internal static string[] smethod_1(string string_0, string string_1, int int_0, CompareMethod compareMethod_0, int int_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return (int_1 ^ 0x5E13) switch
		{
			_ => Strings.Split(string_0, string_1, int_0, compareMethod_0), 
		};
	}

	internal static Type JBeoqOgq(Assembly assembly_0, string string_0, int int_0)
	{
		return (int_0 ^ 0x8E41) switch
		{
			_ => assembly_0.GetType(string_0), 
		};
	}

	internal static MethodInfo smethod_2(Type type_0, string string_0, int int_0)
	{
		return (int_0 ^ 0x39ED) switch
		{
			_ => type_0.GetMethod(string_0), 
		};
	}

	internal static object SaIBWYOL(MethodBase methodBase_0, object object_0, object[] object_1, int int_0)
	{
		return (int_0 ^ 0x14FD) switch
		{
			_ => methodBase_0.Invoke(object_0, object_1), 
		};
	}

	internal static Type smethod_3(string string_0, int int_0)
	{
		return (int_0 ^ 0x2FBE) switch
		{
			_ => Type.GetType(string_0), 
		};
	}

	internal static MethodInfo[] tp7vVv3d(Type type_0, int int_0)
	{
		return (int_0 ^ 0xA1EF) switch
		{
			_ => type_0.GetMethods(), 
		};
	}

	internal static AppDomain smethod_4(int int_0)
	{
		return (int_0 ^ 0xA140) switch
		{
			_ => AppDomain.CurrentDomain, 
		};
	}

	internal static TimeSpan cl3w4DeK(double double_0, int int_0)
	{
		return (int_0 ^ 0xA2D2) switch
		{
			1 => TimeSpan.FromHours(double_0), 
			2 => TimeSpan.FromMilliseconds(double_0), 
			3 => TimeSpan.FromDays(double_0), 
			4 => TimeSpan.FromMinutes(double_0), 
			_ => TimeSpan.FromSeconds(double_0), 
		};
	}

	internal static void Ntnxowb0(Array array_0, int int_0, Array array_1, int int_1, int int_2, int int_3)
	{
		switch (int_3 ^ 0x828C)
		{
		}
		Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
	}

	internal static IEnumerator ekkLDZam(IEnumerable ienumerable_0, int int_0)
	{
		return (int_0 ^ 0xE331) switch
		{
			_ => ienumerable_0.GetEnumerator(), 
		};
	}

	internal static DateTime smethod_5(object object_0, int int_0)
	{
		return (int_0 ^ 0x64C9) switch
		{
			_ => Conversions.ToDate(object_0), 
		};
	}

	internal static DateTime t5xT0x3Q(int int_0)
	{
		return (int_0 ^ 0x3E47) switch
		{
			_ => DateAndTime.get_Now(), 
		};
	}

	internal static int bnHs8wOz(DateTime dateTime_0, DateTime dateTime_1, int int_0)
	{
		return (int_0 ^ 0x408) switch
		{
			_ => DateTime.Compare(dateTime_0, dateTime_1), 
		};
	}

	internal static Color u3BbPDGd(int int_0, int int_1, int int_2, int int_3)
	{
		return (int_3 ^ 0x9987) switch
		{
			_ => Color.FromArgb(int_0, int_1, int_2), 
		};
	}

	internal static int bGpy8YPP(int int_0, int int_1)
	{
		return (int_1 ^ 0xC3A5) switch
		{
			_ => Math.Abs(int_0), 
		};
	}

	internal static void ew4jYi0G(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0)
	{
		switch (int_0 ^ 0xBD2F)
		{
		}
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	internal static void huAghHeA(Graphics graphics_0, Brush brush_0, int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		switch (int_4 ^ 0xB9E1)
		{
		}
		graphics_0.FillEllipse(brush_0, int_0, int_1, int_2, int_3);
	}

	internal static XmlNodeType HULRl21P(XmlTextReader xmlTextReader_0, int int_0)
	{
		return (int_0 ^ 0x106B) switch
		{
			_ => xmlTextReader_0.NodeType, 
		};
	}
}
