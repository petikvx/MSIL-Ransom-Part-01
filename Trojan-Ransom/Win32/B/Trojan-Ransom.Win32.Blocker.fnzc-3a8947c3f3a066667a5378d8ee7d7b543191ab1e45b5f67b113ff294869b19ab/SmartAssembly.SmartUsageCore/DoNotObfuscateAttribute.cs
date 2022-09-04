using System;
using System.Reflection.Emit;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Forms;
using ns0;

namespace SmartAssembly.SmartUsageCore;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class DoNotObfuscateAttribute : Attribute
{
	[SecuritySafeCritical]
	static DoNotObfuscateAttribute()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_0(ButtonBase buttonBase_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 8:
				buttonBase_0.set_UseVisualStyleBackColor(bool_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_1(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 73:
				return exception_0.StackTrace;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_2(Control control_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 73:
				control_0.Refresh();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_3(ref ulong ulong_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 28:
				return ulong_0.ToString(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_4(ILGenerator ilgenerator_0, OpCode opCode_0, Label label_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 72:
				ilgenerator_0.Emit(opCode_0, label_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ICryptoTransform smethod_5(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return symmetricAlgorithm_0.CreateEncryptor(byte_0, byte_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static ICryptoTransform smethod_6(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 19:
				return symmetricAlgorithm_0.CreateDecryptor(byte_0, byte_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_7(Guid guid_0, Guid guid_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 30:
				return guid_0 != guid_1;
			}
		}
	}
}
