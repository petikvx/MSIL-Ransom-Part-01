using System;
using System.Runtime.InteropServices;
using Ionic.Zlib;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
public sealed class GClass5
{
	public byte[] byte_0;

	public int int_0;

	public int int_1;

	public long long_0;

	public byte[] byte_1;

	public int int_2;

	public int int_3;

	public long long_1;

	public string string_0;

	internal Class9 class9_0;

	internal Class14 class14_0;

	internal uint uint_0;

	public CompressionLevel compressionLevel_0 = CompressionLevel.Default;

	public int int_4 = 15;

	public CompressionStrategy compressionStrategy_0;

	public int Int32_0 => (int)uint_0;

	public GClass5()
	{
	}

	public GClass5(CompressionMode mode)
	{
		switch (mode)
		{
		case CompressionMode.Compress:
			if (method_7() != 0)
			{
				throw new GException0("Cannot initialize for deflate.");
			}
			break;
		case CompressionMode.Decompress:
			if (method_0() != 0)
			{
				throw new GException0("Cannot initialize for inflate.");
			}
			break;
		default:
			throw new GException0("Invalid ZlibStreamFlavor.");
		}
	}

	public int method_0()
	{
		return method_2(int_4);
	}

	public int method_1(bool bool_0)
	{
		return method_3(int_4, bool_0);
	}

	public int method_2(int int_5)
	{
		int_4 = int_5;
		return method_3(int_5, bool_0: true);
	}

	public int method_3(int int_5, bool bool_0)
	{
		int_4 = int_5;
		if (class9_0 != null)
		{
			throw new GException0("You may not call InitializeInflate() after calling InitializeDeflate().");
		}
		class14_0 = new Class14(bool_0);
		return class14_0.method_2(this, int_5);
	}

	public int method_4(FlushType flushType_0)
	{
		if (class14_0 == null)
		{
			throw new GException0("No Inflate State!");
		}
		return class14_0.method_3(flushType_0);
	}

	public int method_5()
	{
		if (class14_0 == null)
		{
			throw new GException0("No Inflate State!");
		}
		int result = class14_0.method_1();
		class14_0 = null;
		return result;
	}

	public int method_6()
	{
		if (class14_0 == null)
		{
			throw new GException0("No Inflate State!");
		}
		return class14_0.method_5();
	}

	public int method_7()
	{
		return method_12(bool_0: true);
	}

	public int method_8(CompressionLevel compressionLevel_1)
	{
		compressionLevel_0 = compressionLevel_1;
		return method_12(bool_0: true);
	}

	public int method_9(CompressionLevel compressionLevel_1, bool bool_0)
	{
		compressionLevel_0 = compressionLevel_1;
		return method_12(bool_0);
	}

	public int method_10(CompressionLevel compressionLevel_1, int int_5)
	{
		compressionLevel_0 = compressionLevel_1;
		int_4 = int_5;
		return method_12(bool_0: true);
	}

	public int method_11(CompressionLevel compressionLevel_1, int int_5, bool bool_0)
	{
		compressionLevel_0 = compressionLevel_1;
		int_4 = int_5;
		return method_12(bool_0);
	}

	private int method_12(bool bool_0)
	{
		if (class14_0 != null)
		{
			throw new GException0("You may not call InitializeDeflate() after calling InitializeInflate().");
		}
		class9_0 = new Class9();
		class9_0.Boolean_0 = bool_0;
		return class9_0.method_28(this, compressionLevel_0, int_4, compressionStrategy_0);
	}

	public int method_13(FlushType flushType_0)
	{
		if (class9_0 == null)
		{
			throw new GException0("No Deflate State!");
		}
		return class9_0.method_35(flushType_0);
	}

	public int method_14()
	{
		if (class9_0 == null)
		{
			throw new GException0("No Deflate State!");
		}
		class9_0 = null;
		return 0;
	}

	public void method_15()
	{
		if (class9_0 == null)
		{
			throw new GException0("No Deflate State!");
		}
		class9_0.method_30();
	}

	public int method_16(CompressionLevel compressionLevel_1, CompressionStrategy compressionStrategy_1)
	{
		if (class9_0 == null)
		{
			throw new GException0("No Deflate State!");
		}
		return class9_0.method_33(compressionLevel_1, compressionStrategy_1);
	}

	public int method_17(byte[] byte_2)
	{
		if (class14_0 != null)
		{
			return class14_0.method_4(byte_2);
		}
		if (class9_0 == null)
		{
			throw new GException0("No Inflate or Deflate state!");
		}
		return class9_0.method_34(byte_2);
	}

	internal void method_18()
	{
		int int_ = class9_0.int_21;
		if (int_ > int_3)
		{
			int_ = int_3;
		}
		if (int_ != 0)
		{
			if (class9_0.byte_0.Length <= class9_0.int_20 || byte_1.Length <= int_2 || class9_0.byte_0.Length < class9_0.int_20 + int_ || byte_1.Length < int_2 + int_)
			{
				throw new GException0($"Invalid State. (pending.Length={class9_0.byte_0.Length}, pendingCount={class9_0.int_21})");
			}
			Array.Copy(class9_0.byte_0, class9_0.int_20, byte_1, int_2, int_);
			int_2 += int_;
			class9_0.int_20 += int_;
			long_1 += int_;
			int_3 -= int_;
			class9_0.int_21 -= int_;
			if (class9_0.int_21 == 0)
			{
				class9_0.int_20 = 0;
			}
		}
	}

	internal int method_19(byte[] byte_2, int int_5, int int_6)
	{
		int num = int_1;
		if (num > int_6)
		{
			num = int_6;
		}
		if (num == 0)
		{
			return 0;
		}
		int_1 -= num;
		if (class9_0.Boolean_0)
		{
			uint_0 = GClass4.smethod_0(uint_0, byte_0, int_0, num);
		}
		Array.Copy(byte_0, int_0, byte_2, int_5, num);
		int_0 += num;
		long_0 += num;
		return num;
	}
}
