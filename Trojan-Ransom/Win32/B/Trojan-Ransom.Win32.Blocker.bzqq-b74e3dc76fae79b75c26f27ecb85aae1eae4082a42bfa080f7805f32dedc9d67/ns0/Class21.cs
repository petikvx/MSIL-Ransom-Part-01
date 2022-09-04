using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class21
{
	internal Type type_0;

	internal object object_0;

	internal bool bool_0;

	public Class21(object object_1, bool bool_1)
		: this(object_1, (object_1 != null) ? SimpleZip.Stream0.smethod_0(object_1, 270, 259) : null, bool_1)
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, object_1, bool_1);
			throw;
		}
	}

	public Class21(object object_1, Type type_1, bool bool_1)
	{
		object o = default(object);
		Type o2 = default(Type);
		bool flag = default(bool);
		try
		{
			o = (object_0 = object_1);
			o2 = (type_0 = type_1);
			flag = (bool_0 = bool_1);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, o, o2, flag, this, object_1, type_1, bool_1);
			throw;
		}
	}

	[SpecialName]
	public bool method_0()
	{
		try
		{
			return bool_0;
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException2(exception, num, this);
			throw;
		}
	}

	public object method_1()
	{
		try
		{
			return object_0;
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException2(exception, num, this);
			throw;
		}
	}

	public Type method_2()
	{
		try
		{
			return type_0;
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException2(exception, num, this);
			throw;
		}
	}

	static Class21()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static void smethod_0(RegistryKey registryKey_0, string string_0, object object_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 71:
					registryKey_0.SetValue(string_0, object_1);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException7(exception, num, num2, registryKey_0, string_0, object_1, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(Control control_0, Point point_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 43:
					control_0.set_Location(point_0);
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, point_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_2(Form form_0, bool bool_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 125:
					form_0.set_ShowInTaskbar(bool_1);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, form_0, bool_1, int_0, int_1);
			throw;
		}
	}

	internal static ICryptoTransform smethod_3(SymmetricAlgorithm symmetricAlgorithm_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 8:
					return symmetricAlgorithm_0.CreateEncryptor();
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, symmetricAlgorithm_0, int_0, int_1);
			throw;
		}
	}

	internal static StringBuilder smethod_4(StringBuilder stringBuilder_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 83:
					return stringBuilder_0.Append(string_0);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, stringBuilder_0, string_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_5(Array array_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 18:
					return array_0.Length;
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, array_0, int_0, int_1);
			throw;
		}
	}
}
