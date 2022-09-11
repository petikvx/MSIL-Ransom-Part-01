using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns18;
using ns21;
using ns22;
using ns8;

namespace ns19;

internal sealed class Class168
{
	private byte byte_0;

	private int int_0;

	private ulong ulong_0;

	private byte[] byte_1 = new byte[4];

	private Class167 class167_0;

	private Stream3 stream3_0;

	private Stream stream_0;

	private Stream stream_1;

	[NonSerialized]
	internal static GetString getString_0;

	internal Stream BaseStream => stream3_0;

	public Encoding Encoding
	{
		get
		{
			return class167_0.Encoding;
		}
		set
		{
			class167_0.Encoding = value;
		}
	}

	public byte SequenceByte
	{
		get
		{
			return byte_0;
		}
		set
		{
			byte_0 = value;
		}
	}

	public int MaxBlockSize
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	public ulong MaxPacketSize
	{
		get
		{
			return ulong_0;
		}
		set
		{
			ulong_0 = value;
		}
	}

	public Class168(Encoding encoding_0)
	{
		ulong_0 = ulong.MaxValue;
		int_0 = int.MaxValue;
		class167_0 = new Class167(encoding_0);
	}

	public Class168(Stream stream_2, Encoding encoding_0, bool bool_0)
		: this(encoding_0)
	{
		stream3_0 = new Stream3(stream_2);
		stream_1 = (stream_0 = ((!bool_0) ? ((Stream)stream3_0) : ((Stream)new Stream2(stream3_0))));
	}

	public void method_0()
	{
		stream_1.Dispose();
		stream_0.Dispose();
		stream3_0.Close();
	}

	public void method_1(int int_1)
	{
		stream3_0.method_3(int_1);
	}

	public Class167 method_2()
	{
		method_3();
		if (class167_0.Buffer[0] == byte.MaxValue)
		{
			class167_0.method_1();
			int errno = class167_0.method_13(2);
			string empty = string.Empty;
			empty = ((!class167_0.Version.method_0(5, 5, 0)) ? class167_0.method_23() : class167_0.method_24(Encoding.UTF8));
			if (empty.StartsWith(getString_0(107399288), StringComparison.Ordinal))
			{
				empty.Substring(1, 5);
				empty = empty.Substring(6);
			}
			throw new MySqlException(empty, errno);
		}
		return class167_0;
	}

	internal static void smethod_0(Stream stream_2, byte[] byte_2, int int_1, int int_2)
	{
		int num = 0;
		int num2 = int_2;
		while (true)
		{
			if (num2 > 0)
			{
				int num3 = stream_2.Read(byte_2, int_1 + num, num2);
				if (num3 == 0)
				{
					break;
				}
				num += num3;
				num2 -= num3;
				continue;
			}
			return;
		}
		throw new EndOfStreamException();
	}

	public void method_3()
	{
		try
		{
			class167_0.Length = 0;
			int num = 0;
			int num2;
			do
			{
				smethod_0(stream_0, byte_1, 0, 4);
				byte_0 = (byte)(byte_1[3] + 1);
				num2 = byte_1[0] + (byte_1[1] << 8) + (byte_1[2] << 16);
				class167_0.Length += num2;
				smethod_0(stream_0, class167_0.Buffer, num, num2);
				num += num2;
			}
			while (num2 >= int_0);
			class167_0.Position = 0;
		}
		catch (IOException inner)
		{
			throw new MySqlException(Class121.ReadFromStreamFailed, isFatal: true, inner);
		}
	}

	public void method_4(Class167 class167_1)
	{
		byte[] buffer = class167_1.Buffer;
		int num = class167_1.Position - 4;
		if ((ulong)num > ulong_0)
		{
			throw new MySqlException(Class121.QueryTooLarge, 1153);
		}
		int num2 = 0;
		do
		{
			int num3 = ((num <= int_0) ? num : int_0);
			buffer[num2] = (byte)((uint)num3 & 0xFFu);
			buffer[num2 + 1] = (byte)((uint)(num3 >> 8) & 0xFFu);
			buffer[num2 + 2] = (byte)((uint)(num3 >> 16) & 0xFFu);
			buffer[num2 + 3] = byte_0++;
			stream_1.Write(buffer, num2, num3 + 4);
			stream_1.Flush();
			num -= num3;
			num2 += num3;
		}
		while (num > 0);
	}

	public void method_5(byte[] byte_2, int int_1)
	{
		byte_2[0] = (byte)((uint)int_1 & 0xFFu);
		byte_2[1] = (byte)((uint)(int_1 >> 8) & 0xFFu);
		byte_2[2] = (byte)((uint)(int_1 >> 16) & 0xFFu);
		byte_2[3] = byte_0++;
		stream_1.Write(byte_2, 0, int_1 + 4);
		stream_1.Flush();
	}

	static Class168()
	{
		Strings.CreateGetStringDelegate(typeof(Class168));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399330), getString_0(107399325)).Replace(getString_0(107399288), getString_0(107399283)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399278)))
		{
			throw new SecurityException(getString_0(107399253));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
