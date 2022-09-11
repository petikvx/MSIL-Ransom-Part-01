using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns17;
using ns9;

namespace MySql.Data.MySqlClient.Memcached;

public sealed class BinaryClient : Class189
{
	private enum Enum51 : byte
	{
		const_0 = 0,
		const_1 = 1,
		const_2 = 2,
		const_3 = 3,
		const_4 = 4,
		const_5 = 5,
		const_6 = 6,
		const_7 = 7,
		const_8 = 8,
		const_9 = 12,
		const_10 = 13,
		const_11 = 14,
		const_12 = 15,
		const_13 = 32,
		const_14 = 33,
		const_15 = 34
	}

	private enum Enum52 : byte
	{
		const_0 = 128,
		const_1
	}

	private enum ResponseStatus : ushort
	{
		NoError = 0,
		KeyNotFound = 1,
		KeyExists = 2,
		ValueTooLarge = 3,
		InvalidArguments = 4,
		ItemNotStored = 5,
		IncrDecrOnNonNumericValue = 6,
		VbucketBelongsToAnotherServer = 7,
		AuthenticationError = 8,
		AuthenticationContinue = 9,
		UnknownCommand = 129,
		OutOfMemory = 130,
		NotSupported = 131,
		InternalError = 132,
		Busy = 133,
		TemporaryFailure = 134
	}

	private readonly Encoding encoding_0;

	[NonSerialized]
	internal static GetString getString_0;

	public BinaryClient(string server, uint port)
		: base(server, port)
	{
		encoding_0 = Encoding.UTF8;
	}

	public override void vmethod_2(string string_1, object object_0, TimeSpan timeSpan_0)
	{
		method_0(128, 2, string_1, object_0, timeSpan_0, bool_0: true);
	}

	public override void vmethod_3(string string_1, object object_0)
	{
		method_0(128, 14, string_1, object_0, TimeSpan.Zero, bool_0: false);
	}

	public override void vmethod_4(string string_1, object object_0, TimeSpan timeSpan_0, ulong ulong_0)
	{
		throw new NotImplementedException(getString_0(107371466));
	}

	public override void vmethod_5(string string_1, int int_0)
	{
		method_4(128, 6, string_1, int_0);
	}

	public override void vmethod_6(string string_1)
	{
		method_2(128, 4, string_1);
	}

	public override void vmethod_7(TimeSpan timeSpan_0)
	{
		method_3(128, 8, timeSpan_0);
	}

	public override KeyValuePair<string, object> vmethod_8(string string_1)
	{
		method_1(128, 0, string_1, out var string_2);
		return new KeyValuePair<string, object>(string_1, string_2);
	}

	public override void vmethod_9(string string_1, int int_0)
	{
		method_4(128, 5, string_1, int_0);
	}

	public override void vmethod_10(string string_1, object object_0)
	{
		method_0(128, 15, string_1, object_0, TimeSpan.Zero, bool_0: false);
	}

	public override void vmethod_11(string string_1, object object_0, TimeSpan timeSpan_0)
	{
		method_0(128, 3, string_1, object_0, timeSpan_0, bool_0: true);
	}

	public override void vmethod_12(string string_1, object object_0, TimeSpan timeSpan_0)
	{
		method_0(128, 1, string_1, object_0, timeSpan_0, bool_0: true);
	}

	private void method_0(byte byte_0, byte byte_1, string string_1, object object_0, TimeSpan timeSpan_0, bool bool_0)
	{
		byte[] array = method_7(byte_0, byte_1, string_1, object_0, timeSpan_0, bool_0);
		stream_0.Write(array, 0, array.Length);
		method_5();
	}

	private void method_1(byte byte_0, byte byte_1, string string_1, out string string_2)
	{
		byte[] array = method_8(byte_0, byte_1, string_1);
		stream_0.Write(array, 0, array.Length);
		byte[] array2 = method_5();
		byte[] array3 = new byte[array2[4] - 4];
		Array.Copy(array2, 28, array3, 0, array2[4] - 4);
		string_2 = encoding_0.GetString(array3, 0, array3.Length);
	}

	private void method_2(byte byte_0, byte byte_1, string string_1)
	{
		byte[] array = method_8(byte_0, byte_1, string_1);
		stream_0.Write(array, 0, array.Length);
		method_5();
	}

	private void method_3(byte byte_0, byte byte_1, TimeSpan timeSpan_0)
	{
		byte[] array = method_9(byte_0, byte_1, timeSpan_0);
		stream_0.Write(array, 0, array.Length);
		method_5();
	}

	private void method_4(byte byte_0, byte byte_1, string string_1, int int_0)
	{
		byte[] array = method_10(byte_0, byte_1, string_1, int_0);
		stream_0.Write(array, 0, array.Length);
		method_5();
	}

	private byte[] method_5()
	{
		byte[] array = new byte[24];
		stream_0.Read(array, 0, array.Length);
		method_6(array);
		return array;
	}

	private void method_6(byte[] byte_0)
	{
		ushort num = (ushort)((byte_0[6] << 8) | byte_0[7]);
		if (num != 0)
		{
			ResponseStatus responseStatus = (ResponseStatus)num;
			throw new Exception0(responseStatus.ToString());
		}
	}

	private byte[] method_7(byte byte_0, byte byte_1, string string_1, object object_0, TimeSpan timeSpan_0, bool bool_0)
	{
		byte[] bytes = encoding_0.GetBytes(string_1);
		byte[] bytes2 = encoding_0.GetBytes(object_0.ToString());
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.WriteByte(byte_0);
		memoryStream.WriteByte(byte_1);
		method_11(BitConverter.GetBytes((ushort)bytes.Length), memoryStream);
		memoryStream.WriteByte(8);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		method_11(BitConverter.GetBytes((uint)(bytes.Length + bytes2.Length + (bool_0 ? 8 : 0))), memoryStream);
		method_11(BitConverter.GetBytes(0u), memoryStream);
		method_11(BitConverter.GetBytes((ushort)0), memoryStream);
		if (bool_0)
		{
			memoryStream.Write(new byte[4], 0, 4);
			method_11(BitConverter.GetBytes((uint)timeSpan_0.TotalSeconds), memoryStream);
		}
		memoryStream.Write(bytes, 0, bytes.Length);
		memoryStream.Write(bytes2, 0, bytes2.Length);
		return memoryStream.ToArray();
	}

	private byte[] method_8(byte byte_0, byte byte_1, string string_1)
	{
		byte[] bytes = encoding_0.GetBytes(string_1);
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.WriteByte(byte_0);
		memoryStream.WriteByte(byte_1);
		method_11(BitConverter.GetBytes((ushort)bytes.Length), memoryStream);
		memoryStream.WriteByte(8);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		method_11(BitConverter.GetBytes((ushort)bytes.Length), memoryStream);
		method_11(BitConverter.GetBytes(0u), memoryStream);
		method_11(BitConverter.GetBytes(0u), memoryStream);
		memoryStream.Write(bytes, 0, bytes.Length);
		return memoryStream.ToArray();
	}

	private byte[] method_9(byte byte_0, byte byte_1, TimeSpan timeSpan_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.WriteByte(byte_0);
		memoryStream.WriteByte(byte_1);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(4);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		method_11(BitConverter.GetBytes((ushort)4), memoryStream);
		method_11(BitConverter.GetBytes(0u), memoryStream);
		method_11(BitConverter.GetBytes(0u), memoryStream);
		method_11(BitConverter.GetBytes((uint)timeSpan_0.TotalSeconds), memoryStream);
		return memoryStream.ToArray();
	}

	private byte[] method_10(byte byte_0, byte byte_1, string string_1, int int_0)
	{
		byte[] bytes = encoding_0.GetBytes(string_1);
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.WriteByte(byte_0);
		memoryStream.WriteByte(byte_1);
		method_11(BitConverter.GetBytes((ushort)bytes.Length), memoryStream);
		memoryStream.WriteByte(20);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		memoryStream.WriteByte(0);
		method_11(BitConverter.GetBytes((ushort)(bytes.Length + 20)), memoryStream);
		method_11(BitConverter.GetBytes(0u), memoryStream);
		method_11(BitConverter.GetBytes(0u), memoryStream);
		long num = int_0;
		if (byte_1 == 6)
		{
			num *= -1L;
		}
		method_11(BitConverter.GetBytes(0L), memoryStream);
		TimeSpan zero = TimeSpan.Zero;
		method_11(BitConverter.GetBytes((uint)zero.TotalSeconds), memoryStream);
		memoryStream.Write(bytes, 0, bytes.Length);
		return memoryStream.ToArray();
	}

	private void method_11(byte[] byte_0, MemoryStream memoryStream_0)
	{
		Array.Reverse((Array)byte_0);
		memoryStream_0.Write(byte_0, 0, byte_0.Length);
	}

	static BinaryClient()
	{
		Strings.CreateGetStringDelegate(typeof(BinaryClient));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399510), getString_0(107399505)).Replace(getString_0(107399468), getString_0(107399463)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399458)))
		{
			throw new SecurityException(getString_0(107399433));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
