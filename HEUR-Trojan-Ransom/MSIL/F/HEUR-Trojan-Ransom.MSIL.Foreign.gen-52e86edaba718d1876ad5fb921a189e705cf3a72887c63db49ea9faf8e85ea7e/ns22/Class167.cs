using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns21;

namespace ns22;

internal sealed class Class167
{
	private byte[] byte_0 = new byte[256];

	private Encoding encoding_0;

	private readonly MemoryStream memoryStream_0 = new MemoryStream(5);

	[CompilerGenerated]
	private Struct23 struct23_0;

	[NonSerialized]
	internal static GetString getString_0;

	public Encoding Encoding
	{
		get
		{
			return encoding_0;
		}
		set
		{
			encoding_0 = value;
		}
	}

	public bool HasMoreData => memoryStream_0.Position < memoryStream_0.Length;

	public int Position
	{
		get
		{
			return (int)memoryStream_0.Position;
		}
		set
		{
			memoryStream_0.Position = value;
		}
	}

	public int Length
	{
		get
		{
			return (int)memoryStream_0.Length;
		}
		set
		{
			memoryStream_0.SetLength(value);
		}
	}

	public bool IsLastPacket
	{
		get
		{
			if (memoryStream_0.GetBuffer()[0] == 254)
			{
				return Length <= 5;
			}
			return false;
		}
	}

	public byte[] Buffer => memoryStream_0.GetBuffer();

	public Struct23 Version
	{
		[CompilerGenerated]
		get
		{
			return struct23_0;
		}
		[CompilerGenerated]
		set
		{
			struct23_0 = value;
		}
	}

	private Class167()
	{
		method_0();
	}

	public Class167(Encoding encoding_1)
		: this()
	{
		Encoding = encoding_1;
	}

	public Class167(MemoryStream memoryStream_1)
		: this()
	{
		memoryStream_0 = memoryStream_1;
	}

	public void method_0()
	{
		Position = 4;
	}

	public byte method_1()
	{
		return (byte)memoryStream_0.ReadByte();
	}

	public int method_2(byte[] byte_1, int int_0, int int_1)
	{
		return memoryStream_0.Read(byte_1, int_0, int_1);
	}

	public void method_3(byte byte_1)
	{
		memoryStream_0.WriteByte(byte_1);
	}

	public void method_4(byte[] byte_1)
	{
		method_5(byte_1, 0, byte_1.Length);
	}

	public void method_5(byte[] byte_1, int int_0, int int_1)
	{
		memoryStream_0.Write(byte_1, int_0, int_1);
	}

	public int method_6()
	{
		byte b = method_1();
		if (b < 1 || b > 4)
		{
			throw new MySqlException(Class121.IncorrectTransmission);
		}
		return method_13(b);
	}

	public void method_7(long long_0, byte byte_1)
	{
		long position = memoryStream_0.Position;
		memoryStream_0.Position = long_0;
		memoryStream_0.WriteByte(byte_1);
		memoryStream_0.Position = position;
	}

	public long method_8()
	{
		byte b = method_1();
		return b switch
		{
			251 => -1L, 
			252 => method_13(2), 
			253 => method_13(3), 
			254 => method_10(8), 
			_ => b, 
		};
	}

	public ulong method_9(int int_0)
	{
		ulong num = 0uL;
		int num2 = (int)memoryStream_0.Position;
		byte[] buffer = memoryStream_0.GetBuffer();
		int num3 = 0;
		for (int i = 0; i < int_0; i++)
		{
			num <<= num3;
			num |= buffer[num2++];
			num3 = 8;
		}
		memoryStream_0.Position += int_0;
		return num;
	}

	public long method_10(int int_0)
	{
		byte[] buffer = memoryStream_0.GetBuffer();
		int startIndex = (int)memoryStream_0.Position;
		memoryStream_0.Position += int_0;
		return int_0 switch
		{
			8 => BitConverter.ToInt64(buffer, startIndex), 
			4 => BitConverter.ToUInt32(buffer, startIndex), 
			2 => BitConverter.ToUInt16(buffer, startIndex), 
			_ => throw new NotSupportedException(getString_0(107376480)), 
		};
	}

	public ulong method_11(int int_0)
	{
		byte[] buffer = memoryStream_0.GetBuffer();
		int startIndex = (int)memoryStream_0.Position;
		memoryStream_0.Position += int_0;
		return int_0 switch
		{
			8 => BitConverter.ToUInt64(buffer, startIndex), 
			4 => BitConverter.ToUInt32(buffer, startIndex), 
			2 => BitConverter.ToUInt16(buffer, startIndex), 
			_ => throw new NotSupportedException(getString_0(107376480)), 
		};
	}

	public int method_12()
	{
		int num = 0;
		int num2 = (int)memoryStream_0.Position;
		byte[] buffer = memoryStream_0.GetBuffer();
		int num3 = 0;
		for (int i = 0; i < 3; i++)
		{
			num |= buffer[num2++] << num3;
			num3 += 8;
		}
		memoryStream_0.Position += 3L;
		return num;
	}

	public int method_13(int int_0)
	{
		if (int_0 == 3)
		{
			return method_12();
		}
		return (int)method_10(int_0);
	}

	public void method_14(long long_0, int int_0)
	{
		long num = long_0;
		for (int i = 0; i < int_0; i++)
		{
			byte_0[i] = (byte)((ulong)num & 0xFFuL);
			num >>= 8;
		}
		method_5(byte_0, 0, int_0);
	}

	public int method_15()
	{
		byte b = method_1();
		return b switch
		{
			251 => -1, 
			252 => method_13(2), 
			253 => method_13(3), 
			254 => method_13(4), 
			_ => b, 
		};
	}

	public void method_16(long long_0)
	{
		if (long_0 < 251L)
		{
			method_3((byte)long_0);
		}
		else if (long_0 < 65536L)
		{
			method_3(252);
			method_14(long_0, 2);
		}
		else if (long_0 < 16777216L)
		{
			method_3(253);
			method_14(long_0, 3);
		}
		else
		{
			method_3(254);
			method_14(long_0, 4);
		}
	}

	public void method_17(string string_0)
	{
		byte[] bytes = encoding_0.GetBytes(string_0);
		method_16(bytes.Length);
		method_5(bytes, 0, bytes.Length);
	}

	public void method_18(string string_0)
	{
		byte[] bytes = encoding_0.GetBytes(string_0);
		method_5(bytes, 0, bytes.Length);
	}

	public void method_19(string string_0)
	{
		method_18(string_0);
		method_3(0);
	}

	public string method_20()
	{
		long long_ = method_15();
		return method_22(long_);
	}

	public string method_21(long long_0)
	{
		if (long_0 == 0L)
		{
			return string.Empty;
		}
		method_2(byte_0, 0, (int)long_0);
		return Encoding.GetEncoding(getString_0(107356264)).GetString(byte_0, 0, (int)long_0);
	}

	public string method_22(long long_0)
	{
		if (long_0 == 0L)
		{
			return string.Empty;
		}
		if (byte_0 == null || long_0 > byte_0.Length)
		{
			byte_0 = new byte[long_0];
		}
		method_2(byte_0, 0, (int)long_0);
		return encoding_0.GetString(byte_0, 0, (int)long_0);
	}

	public string method_23()
	{
		return method_24(encoding_0);
	}

	public string method_24(Encoding encoding_1)
	{
		byte[] array = method_25();
		return encoding_1.GetString(array, 0, array.Length);
	}

	public byte[] method_25()
	{
		byte[] buffer = memoryStream_0.GetBuffer();
		int i = (int)memoryStream_0.Position;
		byte[] array;
		for (array = buffer; i < (int)memoryStream_0.Length && array[i] != 0; i++)
		{
		}
		byte[] array2 = new byte[i - memoryStream_0.Position];
		Array.Copy(array, (int)memoryStream_0.Position, array2, 0, (int)(i - memoryStream_0.Position));
		memoryStream_0.Position = i + 1;
		return array2;
	}

	static Class167()
	{
		Strings.CreateGetStringDelegate(typeof(Class167));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399288), getString_0(107399283)).Replace(getString_0(107399246), getString_0(107399241)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399236)))
		{
			throw new SecurityException(getString_0(107399211));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
