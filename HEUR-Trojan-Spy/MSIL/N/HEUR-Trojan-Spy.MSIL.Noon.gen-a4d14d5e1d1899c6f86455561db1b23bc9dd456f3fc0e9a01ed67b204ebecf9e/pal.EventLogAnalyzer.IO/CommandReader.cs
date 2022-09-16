using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace pal.EventLogAnalyzer.IO;

public class CommandReader : CommandHandler
{
	protected BinaryReader reader;

	public bool IgnoreInitialGarbage { get; set; } = false;


	public CommandReader(Stream readFrom, ProtocolRules rules)
		: base(readFrom, rules)
	{
	}

	public override void Dispose()
	{
		stream = null;
		reader.Dispose();
	}

	public ResultType TryRead(out Command command)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_0_ = default(_003C_003Ec__DisplayClass7_0);
		_003C_003Ec__DisplayClass7_0_._003C_003E4__this = this;
		if (!stream.CanRead)
		{
			throw new InvalidOperationException("The stream is unreadable.");
		}
		_003C_003Ec__DisplayClass7_0_.readArgs = new List<object>();
		_003C_003Ec__DisplayClass7_0_.prevObj = null;
		_003C_003Ec__DisplayClass7_0_.arrayIndex = 0;
		_003C_003Ec__DisplayClass7_0_.arrayLength = 0;
		_003C_003Ec__DisplayClass7_0_.readingArray = null;
		lock (lockTarget)
		{
			byte value3;
			while (true)
			{
				int num = 0;
				if (reader.TryReadByte(out var value) == null)
				{
					if (value != base.Rules.commandStart)
					{
						if (value != byte.MaxValue)
						{
							num++;
							continue;
						}
						method_3(ref _003C_003Ec__DisplayClass7_0_);
						command = default(Command);
						return ResultType.TERMINATED;
					}
					num = 0;
					if (reader.TryReadUInt16(out var _) != null)
					{
						pal.EventLogAnalyzer.Core.BreakDebugger("CANT_READ: command id");
					}
					else
					{
						if (reader.TryReadByte(out value3) == null)
						{
							break;
						}
						pal.EventLogAnalyzer.Core.BreakDebugger("CANT_READ: end byte");
					}
				}
				else
				{
					pal.EventLogAnalyzer.Core.BreakDebugger("CANT_READ: start byte");
				}
				method_3(ref _003C_003Ec__DisplayClass7_0_);
				command = default(Command);
				return ResultType.CANT_READ;
			}
			if (value3 != base.Rules.commandEnd)
			{
				pal.EventLogAnalyzer.Core.BreakDebugger("INV_DATA: end byte");
			}
			method_3(ref _003C_003Ec__DisplayClass7_0_);
			command = default(Command);
			return ResultType.INVALID_DATA;
		}
	}

	[CompilerGenerated]
	private int method_0(ParamType param, ref _003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_0_0)
	{
		Exception ex = null;
		object obj = null;
		switch (param)
		{
		case ParamType.BYTES_2:
		{
			BinaryReader binaryReader5 = reader;
			int count = 2;
			ex = binaryReader5.TryReadBytes(in count, out var value18);
			obj = value18;
			break;
		}
		case ParamType.BYTES_1:
		{
			BinaryReader binaryReader4 = reader;
			int count = 1;
			ex = binaryReader4.TryReadBytes(in count, out var value17);
			obj = value17;
			break;
		}
		case ParamType.BYTES_8:
		{
			BinaryReader binaryReader3 = reader;
			int count = 8;
			ex = binaryReader3.TryReadBytes(in count, out var value16);
			obj = value16;
			break;
		}
		case ParamType.BYTES_4:
		{
			BinaryReader binaryReader2 = reader;
			int count = 4;
			ex = binaryReader2.TryReadBytes(in count, out var value15);
			obj = value15;
			break;
		}
		case ParamType.CHAR:
		{
			ex = reader.TryReadChar(out var value14);
			obj = value14;
			break;
		}
		case ParamType.BOOLEAN:
		{
			ex = reader.TryReadBoolean(out var value13);
			obj = value13;
			break;
		}
		case ParamType.SHORT:
		{
			ex = reader.TryReadInt16(out var value12);
			obj = value12;
			break;
		}
		case ParamType.BYTE:
		{
			ex = reader.TryReadByte(out var value11);
			obj = value11;
			break;
		}
		case ParamType.SBYTE:
		{
			ex = reader.TryReadSByte(out var value10);
			obj = value10;
			break;
		}
		case ParamType.INT:
		{
			ex = reader.TryReadInt32(out var value9);
			obj = value9;
			break;
		}
		case ParamType.USHORT:
		{
			ex = reader.TryReadUInt16(out var value8);
			obj = value8;
			break;
		}
		case ParamType.ULONG:
		{
			ex = reader.TryReadUInt64(out var value7);
			obj = value7;
			break;
		}
		case ParamType.UINT:
		{
			ex = reader.TryReadUInt32(out var value6);
			obj = value6;
			break;
		}
		case ParamType.DOUBLE:
		{
			ex = reader.TryReadDouble(out var value5);
			obj = value5;
			break;
		}
		case ParamType.FLOAT:
		{
			ex = reader.TryReadSingle(out var value4);
			obj = value4;
			break;
		}
		case ParamType.BYTES_16:
		case ParamType.GUID:
		{
			BinaryReader binaryReader = reader;
			int count = 16;
			ex = binaryReader.TryReadBytes(in count, out var value3);
			obj = value3;
			break;
		}
		case ParamType.LONG:
		case ParamType.DATETIME:
		{
			ex = reader.TryReadInt64(out var value2);
			obj = value2;
			break;
		}
		case ParamType.DECIMAL:
		{
			ex = reader.TryReadDecimal(out var value);
			obj = value;
			break;
		}
		}
		if (ex != null)
		{
			return 1;
		}
		switch (param)
		{
		case ParamType.GUID:
			obj = new Guid((byte[])obj);
			break;
		case ParamType.DATETIME:
			obj = DateTime.FromBinary((long)obj);
			break;
		}
		method_2(obj, ref _003C_003Ec__DisplayClass7_0_0);
		return 0;
	}

	[CompilerGenerated]
	private int method_1(ParamType param, ref _003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_0_0)
	{
		int value = 0;
		if (reader.TryReadInt32(out value) != null)
		{
			return 1;
		}
		if (reader.TryReadByte(out var value2) != null)
		{
			return 1;
		}
		if (value2 != base.Rules.commandDefine)
		{
			return 2;
		}
		if (reader.TryReadBytes(in value, out var value3) != null)
		{
			return 1;
		}
		object obj = null;
		switch (param)
		{
		case ParamType.RAW:
			obj = value3;
			break;
		case ParamType.STRING:
			obj = base.Rules.stringEncoding.GetString(value3);
			break;
		}
		method_2(obj, ref _003C_003Ec__DisplayClass7_0_0);
		return 0;
	}

	[CompilerGenerated]
	private void method_2(object obj, ref _003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_0_0)
	{
		if (_003C_003Ec__DisplayClass7_0_0.readingArray != null)
		{
			_003C_003Ec__DisplayClass7_0_0.readingArray.SetValue(obj, _003C_003Ec__DisplayClass7_0_0.arrayIndex);
		}
		else
		{
			_003C_003Ec__DisplayClass7_0_0.readArgs.Add(obj);
		}
	}

	[CompilerGenerated]
	private void method_3(ref _003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_0_0)
	{
		_003C_003Ec__DisplayClass7_0_0.prevObj = null;
		_003C_003Ec__DisplayClass7_0_0.currObj = null;
		_003C_003Ec__DisplayClass7_0_0.readingArray = null;
		_003C_003Ec__DisplayClass7_0_0.arrayLength = 0;
		_003C_003Ec__DisplayClass7_0_0.arrayIndex = 0;
	}
}
