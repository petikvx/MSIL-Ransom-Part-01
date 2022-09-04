using System;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.SmartExceptionsCore;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
public sealed class DoNotPruneAttribute : Attribute
{
	public DoNotPruneAttribute()
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static DoNotPruneAttribute()
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

	internal static string smethod_0(string string_0, object object_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 82:
					return string.Format(string_0, object_0);
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, string_0, object_0, int_0, int_1);
			throw;
		}
	}

	internal static Guid smethod_1(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 66:
					return Guid.NewGuid();
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static Size smethod_2(Control control_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 110:
					return control_0.get_Size();
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, control_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_3(CryptoStream cryptoStream_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 2;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 60:
					cryptoStream_0.FlushFinalBlock();
					return;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, cryptoStream_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_4(WebClientProtocol webClientProtocol_0, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 26:
					webClientProtocol_0.set_Timeout(int_0);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, webClientProtocol_0, int_0, int_1, int_2);
			throw;
		}
	}

	internal static string smethod_5(string string_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 119:
					return string_0.Substring(int_0, int_1);
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, string_0, int_0, int_1, int_2, int_3);
			throw;
		}
	}

	internal static Assembly smethod_6(int int_0, int int_1)
	{
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 55:
					return Assembly.GetExecutingAssembly();
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, int_0, int_1);
			throw;
		}
	}
}
