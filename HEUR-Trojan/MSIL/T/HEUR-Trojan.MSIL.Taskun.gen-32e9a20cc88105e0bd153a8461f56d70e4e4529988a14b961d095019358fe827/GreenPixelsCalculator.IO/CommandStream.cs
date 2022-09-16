#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace GreenPixelsCalculator.IO;

[Obsolete("Please use CommandReader and CommandWriter.")]
public class CommandStream : Stream
{
	private const int ARRAYLENGTH_PLUS_DEFINE = 5;

	public ProtocolRules Rules;

	private List<object> readArgs = new List<object>();

	private byte[] readBuffer;

	private long readingTasks = 0L;

	private long writingTasks = 0L;

	private AutoResetEvent readSignal = new AutoResetEvent(initialState: false);

	private AutoResetEvent writeSignal = new AutoResetEvent(initialState: false);

	public override bool CanRead => UsedStream.CanRead;

	public override bool CanSeek => false;

	public override bool CanWrite => UsedStream.CanWrite;

	[Obsolete("This class does not support Length", true)]
	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	[Obsolete("This class does not support Position", true)]
	public override long Position
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public Stream UsedStream { get; set; }

	public bool IgnoreInitialGarbage { get; set; } = false;


	public CommandStream(Stream underlying, ProtocolRules rules, uint bufferSize = 256u)
	{
		UsedStream = underlying;
		readBuffer = new byte[bufferSize];
		Rules = rules;
	}

	protected override void Dispose(bool disposing)
	{
		readSignal.Dispose();
		writeSignal.Dispose();
	}

	public void CriticalPause()
	{
		if (Interlocked.Read(ref readingTasks) < 1L || readSignal.WaitOne())
		{
			Interlocked.Increment(ref readingTasks);
			if (Interlocked.Read(ref writingTasks) < 1L || writeSignal.WaitOne())
			{
				Interlocked.Increment(ref writingTasks);
			}
		}
	}

	public void CriticalResume()
	{
		if (Interlocked.Read(ref readingTasks) >= 1L)
		{
			readSignal.Set();
			Interlocked.Decrement(ref readingTasks);
		}
		if (Interlocked.Read(ref writingTasks) >= 1L)
		{
			writeSignal.Set();
			Interlocked.Decrement(ref writingTasks);
		}
	}

	public ResultType ReadCommand(out Command command)
	{
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_0_ = default(_003C_003Ec__DisplayClass31_0);
		_003C_003Ec__DisplayClass31_0_._003C_003E4__this = this;
		if (!UsedStream.CanRead)
		{
			throw new InvalidOperationException("The underlyingStream is unwritable.");
		}
		command = default(Command);
		if (Interlocked.Read(ref readingTasks) >= 1L && !readSignal.WaitOne())
		{
			return ResultType.CANT_READ;
		}
		Interlocked.Increment(ref readingTasks);
		readArgs.Clear();
		while (true)
		{
			ushort num = 0;
			num = 1;
			if (readChunk(1))
			{
				byte b = readBuffer[0];
				if (b != Rules.commandStart)
				{
					if (b != byte.MaxValue)
					{
						if (IgnoreInitialGarbage || b == 0)
						{
							continue;
						}
						goto IL_0157;
					}
					method_4(ref _003C_003Ec__DisplayClass31_0_);
					method_3(ref _003C_003Ec__DisplayClass31_0_);
					return ResultType.TERMINATED;
				}
				num = (ushort)(num - 1);
				if (readStruct<ushort>(out var _))
				{
					_003C_003Ec__DisplayClass31_0_.readOk = false;
					_003C_003Ec__DisplayClass31_0_.prevObj = null;
					_003C_003Ec__DisplayClass31_0_.arrayIndex = 0;
					_003C_003Ec__DisplayClass31_0_.arrayLength = 0;
					_003C_003Ec__DisplayClass31_0_.array = null;
					method_4(ref _003C_003Ec__DisplayClass31_0_);
					if (readChunk(1))
					{
						if (readBuffer[0] == Rules.commandEnd)
						{
							break;
						}
						goto IL_0157;
					}
				}
			}
			method_4(ref _003C_003Ec__DisplayClass31_0_);
			method_3(ref _003C_003Ec__DisplayClass31_0_);
			return ResultType.CANT_READ;
			IL_0157:
			method_4(ref _003C_003Ec__DisplayClass31_0_);
			method_3(ref _003C_003Ec__DisplayClass31_0_);
			return ResultType.INVALID_DATA;
		}
		method_3(ref _003C_003Ec__DisplayClass31_0_);
		return ResultType.SUCCESS;
	}

	public void WriteCommand(Command command)
	{
		if (!UsedStream.CanWrite)
		{
			throw new InvalidOperationException("The underlyingStream is unwritable.");
		}
		if (Interlocked.Read(ref writingTasks) >= 1L && !writeSignal.WaitOne())
		{
			return;
		}
		Interlocked.Increment(ref writingTasks);
		byte[] array = new byte[3] { Rules.commandStart, 0, 0 };
		command.Format.Type.WriteObjectInByteArray(array, 1);
		GreenPixelsCalculator.Core.Write(UsedStream, array);
		object obj = null;
		int num = 0;
		int num2 = 0;
		Array array2 = null;
		int num3 = 0;
		int num4 = 0;
		object obj2;
		while (true)
		{
			if (num4 < command.Format.Count)
			{
				ParamType paramType = command.Format[num4];
				if (array2 != null)
				{
					obj2 = array2.GetValue(num);
				}
				else
				{
					obj2 = ((num3 < command.Args.Length) ? command.Args[num3] : null);
					obj = ((num3 == 0) ? null : command.Args[num3 - 1]);
				}
				if (paramType.HasFlag(ParamType._SPECIAL))
				{
					switch (paramType)
					{
					case ParamType._IF_TRUE:
						if (obj != null && obj is bool)
						{
							if (!(bool)obj)
							{
								num4 = command.Format.GetNextNonSpecialParam(num4);
							}
							break;
						}
						throw new InvalidOperationException("_IF_TRUE requires a missing parameter.");
					case ParamType._IF_0:
						if (obj != null)
						{
							if (!obj.EqualsZero())
							{
								num4 = command.Format.GetNextNonSpecialParam(num4);
							}
							break;
						}
						throw new InvalidOperationException("_IF_0 requires a missing parameter.");
					case ParamType._IF_NOT_0:
						if (obj != null)
						{
							if (obj.EqualsZero())
							{
								num4 = command.Format.GetNextNonSpecialParam(num4);
							}
							break;
						}
						throw new InvalidOperationException("_IF_NOT_0 requires a missing parameter.");
					case ParamType._ARRAY_OF:
						if (obj2 != null && obj2 is Array)
						{
							if (array2 == null)
							{
								array2 = (Array)obj2;
								num2 = array2.Length;
								GreenPixelsCalculator.Core.Write(UsedStream, num2.ReadObjectAsByteArray());
								if (num2 == 0)
								{
									array2 = null;
									num4++;
								}
								else
								{
									num = 0;
								}
								break;
							}
							throw new InvalidOperationException("_ARRAY_OF cannot be repeated.");
						}
						throw new InvalidOperationException("_ARRAY_OF require a missing parameter.");
					default:
						throw new InvalidOperationException("Unable to recognize special parameter: " + $"0x{paramType:x}");
					}
				}
				else
				{
					if (num3 > 0)
					{
						UsedStream.WriteByte(Rules.commandNext);
					}
					if (paramType == ParamType.DYNAMIC)
					{
						ParamType paramType2 = GreenPixelsCalculator.Core.FindType(obj2);
						byte[] buffer = ((ushort)paramType2).ReadObjectAsByteArray();
						GreenPixelsCalculator.Core.Write(UsedStream, buffer);
						UsedStream.WriteByte(Rules.commandDefine);
						Stream usedStream = UsedStream;
						byte[] buffer2;
						if (!paramType2.HasFlag(ParamType._FIXED_LENGTH))
						{
							if (!paramType2.HasFlag(ParamType._PREFIXED_LENGTH))
							{
								break;
							}
							buffer2 = method_5(paramType2, obj2);
						}
						else
						{
							buffer2 = smethod_0(paramType2, obj2);
						}
						GreenPixelsCalculator.Core.Write(usedStream, buffer2);
						num3++;
					}
					else if (paramType.HasFlag(ParamType._FIXED_LENGTH))
					{
						GreenPixelsCalculator.Core.Write(UsedStream, smethod_0(paramType, obj2));
						num3++;
					}
					else if (paramType.HasFlag(ParamType._PREFIXED_LENGTH))
					{
						GreenPixelsCalculator.Core.Write(UsedStream, method_5(paramType, obj2));
						num3++;
					}
					if (array2 != null)
					{
						if (++num == num2)
						{
							array2 = null;
						}
						else
						{
							num4--;
							num3--;
						}
					}
				}
				num4++;
				continue;
			}
			obj = null;
			obj2 = null;
			array2 = null;
			num2 = 0;
			num = 0;
			UsedStream.WriteByte(Rules.commandEnd);
			Flush();
			writeSignal.Set();
			Interlocked.Decrement(ref writingTasks);
			return;
		}
		throw new ArgumentException("Unrecognized type of object (" + obj2.GetType().FullName + ")", "currObj");
	}

	private bool readChunk(int requiredLength)
	{
		if (requiredLength < 0)
		{
			throw new ArgumentOutOfRangeException("requiredLength", "The required amount of data is negative.");
		}
		if (requiredLength == 0)
		{
			return true;
		}
		if (requiredLength > readBuffer.Length)
		{
			readBuffer = new byte[requiredLength];
		}
		int num = 0;
		int num2 = 0;
		do
		{
			try
			{
				num2 = UsedStream.Read(readBuffer, num, requiredLength - num);
			}
			catch (Exception ex)
			{
				Debug.Print(ex.Message);
				return false;
			}
			if (num2 != 0)
			{
				num += num2;
				continue;
			}
			return false;
		}
		while (num < requiredLength);
		if (num != requiredLength)
		{
			throw new IndexOutOfRangeException("Weird, but the amount of received data does not match the required one.");
		}
		return true;
	}

	private bool readStruct<T>(out T value) where T : struct
	{
		int requiredLength = Marshal.SizeOf(typeof(T));
		value = default(T);
		if (!readChunk(requiredLength))
		{
			return false;
		}
		value = readBuffer.ReadBytesAs<T>();
		return true;
	}

	public override void Close()
	{
		CriticalPause();
		if (UsedStream != null && UsedStream.CanWrite)
		{
			try
			{
				UsedStream.WriteByte(byte.MaxValue);
				UsedStream.Flush();
			}
			catch (IOException)
			{
			}
			UsedStream.Close();
			UsedStream = null;
		}
	}

	public override void Flush()
	{
		UsedStream.Flush();
	}

	[Obsolete("This class does not support Seek", true)]
	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	[Obsolete("This class does not support SetLength", true)]
	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	[Obsolete("This class does not support direct Read", true)]
	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	[Obsolete("This class does not support direct Write", true)]
	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	[CompilerGenerated]
	private int method_0(ParamType param, ref _003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_0_0)
	{
		switch (param & ParamType.__LENGTHS_AND_KINDS)
		{
		case ParamType.BYTES_2:
			_003C_003Ec__DisplayClass31_0_0.readOk = readChunk(2);
			break;
		case ParamType.BYTES_1:
			_003C_003Ec__DisplayClass31_0_0.readOk = readChunk(1);
			break;
		case ParamType.BYTES_16:
			_003C_003Ec__DisplayClass31_0_0.readOk = readChunk(16);
			break;
		case ParamType.BYTES_8:
			_003C_003Ec__DisplayClass31_0_0.readOk = readChunk(8);
			break;
		case ParamType.BYTES_4:
			_003C_003Ec__DisplayClass31_0_0.readOk = readChunk(4);
			break;
		}
		if (!_003C_003Ec__DisplayClass31_0_0.readOk)
		{
			return 1;
		}
		object obj = null;
		switch (param)
		{
		case ParamType.BYTES_2:
			obj = readBuffer.ReadBytesAsArrayOf<byte>(0, 2);
			break;
		case ParamType.BYTES_1:
			obj = readBuffer.ReadBytesAsArrayOf<byte>(0, 1);
			break;
		case ParamType.BYTES_16:
			obj = readBuffer.ReadBytesAsArrayOf<byte>(0, 16);
			break;
		case ParamType.BYTES_8:
			obj = readBuffer.ReadBytesAsArrayOf<byte>(0, 8);
			break;
		case ParamType.BYTES_4:
			obj = readBuffer.ReadBytesAsArrayOf<byte>(0, 4);
			break;
		case ParamType.CHAR:
			obj = readBuffer.ReadBytesAs<char>();
			break;
		case ParamType.BOOLEAN:
			obj = readBuffer.ReadBytesAs<bool>();
			break;
		case ParamType.SHORT:
			obj = readBuffer.ReadBytesAs<short>();
			break;
		case ParamType.BYTE:
			obj = readBuffer.ReadBytesAs<byte>();
			break;
		case ParamType.SBYTE:
			obj = readBuffer.ReadBytesAs<sbyte>();
			break;
		case ParamType.INT:
			obj = readBuffer.ReadBytesAs<int>();
			break;
		case ParamType.USHORT:
			obj = readBuffer.ReadBytesAs<ushort>();
			break;
		case ParamType.ULONG:
			obj = readBuffer.ReadBytesAs<ulong>();
			break;
		case ParamType.LONG:
			obj = readBuffer.ReadBytesAs<long>();
			break;
		case ParamType.UINT:
			obj = readBuffer.ReadBytesAs<uint>();
			break;
		case ParamType.DOUBLE:
			obj = readBuffer.ReadBytesAs<double>();
			break;
		case ParamType.FLOAT:
			obj = readBuffer.ReadBytesAs<float>();
			break;
		case ParamType.GUID:
			obj = new Guid(readBuffer.ReadBytesAsArrayOf<byte>(0, 16));
			break;
		case ParamType.DATETIME:
			obj = DateTime.FromBinary(readBuffer.ReadBytesAs<long>());
			break;
		case ParamType.DECIMAL:
			obj = readBuffer.ReadBytesAs<decimal>();
			break;
		}
		method_2(obj, ref _003C_003Ec__DisplayClass31_0_0);
		return 0;
	}

	[CompilerGenerated]
	private int method_1(ParamType param, ref _003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_0_0)
	{
		int value = 0;
		if (!readStruct<int>(out value))
		{
			return 1;
		}
		if (!readChunk(1))
		{
			return 1;
		}
		if (readBuffer[0] != Rules.commandDefine)
		{
			return 2;
		}
		if (!readChunk(value))
		{
			return 1;
		}
		object obj = null;
		switch (param)
		{
		case ParamType.RAW:
			obj = readBuffer.ReadBytesAsArrayOf<byte>(0, value);
			break;
		case ParamType.STRING:
			obj = Rules.stringEncoding.GetString(readBuffer, 0, value);
			break;
		}
		method_2(obj, ref _003C_003Ec__DisplayClass31_0_0);
		return 0;
	}

	[CompilerGenerated]
	private void method_2(object obj, ref _003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_0_0)
	{
		if (_003C_003Ec__DisplayClass31_0_0.array != null)
		{
			_003C_003Ec__DisplayClass31_0_0.array.SetValue(obj, _003C_003Ec__DisplayClass31_0_0.arrayIndex);
		}
		else
		{
			readArgs.Add(obj);
		}
	}

	[CompilerGenerated]
	private void method_3(ref _003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_0_0)
	{
		if (Interlocked.Read(ref readingTasks) >= 1L)
		{
			readSignal.Set();
			Interlocked.Decrement(ref readingTasks);
		}
	}

	[CompilerGenerated]
	private void method_4(ref _003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_0_0)
	{
		_003C_003Ec__DisplayClass31_0_0.prevObj = null;
		_003C_003Ec__DisplayClass31_0_0.currObj = null;
		_003C_003Ec__DisplayClass31_0_0.array = null;
		_003C_003Ec__DisplayClass31_0_0.arrayLength = 0;
		_003C_003Ec__DisplayClass31_0_0.arrayIndex = 0;
	}

	[CompilerGenerated]
	internal static byte[] smethod_0<T>(ParamType param, T value)
	{
		if (!param.HasFlag(ParamType._FIXED_LENGTH))
		{
			throw new ArgumentException("This parameter does not have a fixed length.", "param");
		}
		return param switch
		{
			ParamType.DATETIME => ((DateTime)(object)value).ToBinary().ReadObjectAsByteArray(), 
			ParamType.GUID => ((Guid)(object)value).ToByteArray(), 
			_ => value.ReadObjectAsByteArray(), 
		};
	}

	[CompilerGenerated]
	private byte[] method_5(ParamType param, object value)
	{
		if (!param.HasFlag(ParamType._PREFIXED_LENGTH))
		{
			throw new ArgumentException("This parameter does not have a dynamic length.", "param");
		}
		byte[] array = null;
		int num = 0;
		if (value is string text)
		{
			num = Rules.stringEncoding.GetByteCount(text);
			array = new byte[5 + num];
			num.WriteObjectInByteArray(array);
			array[4] = Rules.commandDefine;
			Rules.stringEncoding.GetBytes(text, 0, text.Length, array, 5);
		}
		else
		{
			if (!(value is byte[] array2))
			{
				throw new ArgumentException("Invalid type of data (only string and byte[] are allowed).", "value");
			}
			num = array2.Length;
			array = new byte[5 + num];
			num.WriteObjectInByteArray(array);
			array[4] = Rules.commandDefine;
			Array.Copy(array2, 0, array, 5, num);
		}
		return array;
	}
}
