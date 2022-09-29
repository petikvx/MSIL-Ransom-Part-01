using System;
using System.Security.Cryptography;

internal class Class1
{
	public byte[] method_0(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4)
	{
		object[] object_ = new object[6] { this, byte_0, byte_1, byte_2, byte_3, byte_4 };
		return (byte[])(Array)new GClass22().method_112(object_, 845831);
	}

	private int method_1(IntPtr intptr_0)
	{
		object[] object_ = new object[2] { this, intptr_0 };
		return (int)new GClass22().method_112(object_, 1548375);
	}

	private IntPtr method_2(string string_0, string string_1, string FAC9BAF6)
	{
		object[] object_ = new object[4] { this, string_0, string_1, FAC9BAF6 };
		return (IntPtr)new GClass22().method_112(object_, 842232);
	}

	private IntPtr method_3(IntPtr intptr_0, byte[] byte_0, out IntPtr intptr_1)
	{
		byte[] byte_ = method_4(intptr_0, GClass2.string_0);
		int num = Delegate69.smethod_0(byte_, 0);
		IntPtr intPtr = Delegate15.smethod_0(num);
		byte[] array = method_5(GClass2.byte_0, Delegate54.smethod_0(1), Delegate54.smethod_0(byte_0.Length), byte_0);
		uint num2 = GClass2.BCryptImportKey(intptr_0, IntPtr.Zero, GClass2.string_4, out intptr_1, intPtr, num, array, array.Length, 0u);
		if (num2 != 0)
		{
			throw new CryptographicException(Delegate12.smethod_0("BCrypt.BCryptImportKey() failed with status code:{0}", num2));
		}
		return intPtr;
	}

	private byte[] method_4(IntPtr intptr_0, string string_0)
	{
		object[] object_ = new object[3] { this, intptr_0, string_0 };
		return (byte[])(Array)new GClass22().method_112(object_, 855197);
	}

	public byte[] method_5(params byte[][] byte_0)
	{
		object[] object_ = new object[2] { this, byte_0 };
		return (byte[])(Array)new GClass22().method_112(object_, 816604);
	}
}
