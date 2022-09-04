using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ns6;

internal class Class20
{
	internal static ICryptoTransform smethod_0(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		return (int_0 ^ 0xDBBB) switch
		{
			_ => symmetricAlgorithm_0.CreateDecryptor(), 
		};
	}

	internal static StringComparer smethod_1(int int_0)
	{
		return (int_0 ^ 0x7A1D) switch
		{
			_ => StringComparer.OrdinalIgnoreCase, 
		};
	}

	internal static int smethod_2(StringComparer stringComparer_0, string string_0, string string_1, int int_0)
	{
		return (int_0 ^ 0x16C6) switch
		{
			_ => stringComparer_0.Compare(string_0, string_1), 
		};
	}

	internal static byte[] smethod_3(Encoding encoding_0, string string_0, int int_0)
	{
		return (int_0 ^ 0x3758) switch
		{
			_ => encoding_0.GetBytes(string_0), 
		};
	}

	internal static byte[] smethod_4(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0)
	{
		return (int_0 ^ 0x9FBA) switch
		{
			_ => hashAlgorithm_0.ComputeHash(byte_0), 
		};
	}

	internal static StringBuilder smethod_5(StringBuilder stringBuilder_0, string string_0, int int_0)
	{
		return (int_0 ^ 0x4F5E) switch
		{
			_ => stringBuilder_0.Append(string_0), 
		};
	}

	internal static string smethod_6(object object_0, int int_0)
	{
		return (int_0 ^ 0xCF3B) switch
		{
			_ => object_0.ToString(), 
		};
	}

	internal static void smethod_7(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0)
	{
		switch (int_0 ^ 0xB2F)
		{
		}
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	internal static Type smethod_8(RuntimeTypeHandle runtimeTypeHandle_0, int int_0)
	{
		return (int_0 ^ 0xA826) switch
		{
			_ => Type.GetTypeFromHandle(runtimeTypeHandle_0), 
		};
	}

	internal static Assembly smethod_9(Type type_0, int int_0)
	{
		return (int_0 ^ 0x80E6) switch
		{
			_ => type_0.Assembly, 
		};
	}

	internal static bool smethod_10(object object_0, object object_1, int int_0)
	{
		return (int_0 ^ 0xB46A) switch
		{
			_ => object.ReferenceEquals(object_0, object_1), 
		};
	}

	internal static SettingsBase smethod_11(SettingsBase settingsBase_0, int int_0)
	{
		return (SettingsBase)((int_0 ^ 0x9409) switch
		{
			_ => SettingsBase.Synchronized(settingsBase_0), 
		});
	}

	internal static string smethod_12(byte[] byte_0, int int_0)
	{
		return (int_0 ^ 0x872F) switch
		{
			_ => Convert.ToBase64String(byte_0), 
		};
	}

	internal static void smethod_13(Array array_0, int int_0, Array array_1, int int_1, int int_2, int int_3)
	{
		switch (int_3 ^ 0xA5F5)
		{
		}
		Array.Copy(array_0, int_0, array_1, int_1, int_2);
	}

	internal static bool smethod_14(int int_0)
	{
		return (int_0 ^ 0xFB7C) switch
		{
			_ => Debugger.IsAttached, 
		};
	}

	internal static string smethod_15(string string_0, int int_0)
	{
		return (int_0 ^ 0x98EF) switch
		{
			_ => Environment.GetEnvironmentVariable(string_0), 
		};
	}

	internal static DialogResult smethod_16(string string_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)((int_0 ^ 0x37B5) switch
		{
			_ => MessageBox.Show(string_0), 
		});
	}

	internal static void smethod_17(string string_0, int int_0)
	{
		switch (int_0 ^ 0xA17C)
		{
		}
		Environment.FailFast(string_0);
	}

	internal static char[] smethod_18(string string_0, int int_0)
	{
		return (int_0 ^ 0xECEF) switch
		{
			_ => string_0.ToCharArray(), 
		};
	}

	internal static Stream smethod_19(BinaryReader binaryReader_0, int int_0)
	{
		return (int_0 ^ 0x55F) switch
		{
			_ => binaryReader_0.BaseStream, 
		};
	}
}
