using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace pal.EventLogAnalyzer.IO;

public class CommandWriter : CommandHandler
{
	private const int ARRAYLENGTH_PLUS_DEFINE = 5;

	protected BinaryWriter writer;

	public CommandWriter(Stream writeTo, ProtocolRules rules)
		: base(writeTo, rules)
	{
	}

	public override void Dispose()
	{
		stream = null;
		writer.Dispose();
	}

	public void TryWrite(in Command command)
	{
		if (!stream.CanWrite)
		{
			throw new InvalidOperationException("The stream is unwritable.");
		}
		object obj = null;
		int num = 0;
		int num2 = 0;
		Array array = null;
		lock (lockTarget)
		{
			byte[] array2 = new byte[3]
			{
				base.Rules.commandStart,
				0,
				0
			};
			command.Format.Type.WriteObjectInByteArray(array2, 1);
			writer.Write(array2);
			int num3 = 0;
			object obj2;
			for (int i = 0; i < command.Format.Count; i++)
			{
				ParamType paramType = command.Format[i];
				if (array != null)
				{
					obj2 = array.GetValue(num);
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
								i = command.Format.GetNextNonSpecialParam(i);
							}
							break;
						}
						throw new InvalidOperationException("_IF_TRUE requires a missing parameter.");
					case ParamType._IF_0:
						if (obj != null)
						{
							if (!obj.EqualsZero())
							{
								i = command.Format.GetNextNonSpecialParam(i);
							}
							break;
						}
						throw new InvalidOperationException("_IF_0 requires a missing parameter.");
					case ParamType._IF_NOT_0:
						if (obj != null)
						{
							if (obj.EqualsZero())
							{
								i = command.Format.GetNextNonSpecialParam(i);
							}
							break;
						}
						throw new InvalidOperationException("_IF_NOT_0 requires a missing parameter.");
					case ParamType._ARRAY_OF:
						if (obj2 != null && obj2 is Array)
						{
							if (array == null)
							{
								array = (Array)obj2;
								num2 = array.Length;
								writer.Write(num2);
								if (num2 == 0)
								{
									array = null;
									i++;
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
					continue;
				}
				if (num3 > 0)
				{
					writer.Write(base.Rules.commandNext);
				}
				if (paramType == ParamType.DYNAMIC)
				{
					ParamType paramType2 = pal.EventLogAnalyzer.Core.FindType(obj2);
					writer.Write((ushort)paramType2);
					writer.Write(base.Rules.commandDefine);
					if (paramType2.HasFlag(ParamType._FIXED_LENGTH))
					{
						method_0(paramType2, obj2);
					}
					else
					{
						if (!paramType2.HasFlag(ParamType._PREFIXED_LENGTH))
						{
							throw new ArgumentException("Unrecognized type of object (" + obj2.GetType().FullName + ")", "currObj");
						}
						method_1(paramType2, obj2);
					}
					num3++;
				}
				else if (paramType.HasFlag(ParamType._FIXED_LENGTH))
				{
					method_0(paramType, obj2);
					num3++;
				}
				else if (paramType.HasFlag(ParamType._PREFIXED_LENGTH))
				{
					method_1(paramType, obj2);
					num3++;
				}
				if (array != null)
				{
					if (++num == num2)
					{
						array = null;
						continue;
					}
					i--;
					num3--;
				}
			}
			obj = null;
			obj2 = null;
			array = null;
			num2 = 0;
			num = 0;
			writer.Write(base.Rules.commandEnd);
			writer.Flush();
		}
	}

	[CompilerGenerated]
	private void method_0(ParamType param, object value)
	{
		switch (param)
		{
		case ParamType.BYTES_2:
			writer.Write((byte[])value, 0, 2);
			break;
		case ParamType.BYTES_1:
			writer.Write((byte[])value, 0, 1);
			break;
		case ParamType.BYTES_16:
			writer.Write((byte[])value, 0, 16);
			break;
		case ParamType.BYTES_8:
			writer.Write((byte[])value, 0, 8);
			break;
		case ParamType.BYTES_4:
			writer.Write((byte[])value, 0, 4);
			break;
		case ParamType.CHAR:
			writer.Write((char)value);
			break;
		case ParamType.BOOLEAN:
			writer.Write((bool)value);
			break;
		case ParamType.SHORT:
			writer.Write((short)value);
			break;
		case ParamType.BYTE:
			writer.Write((byte)value);
			break;
		case ParamType.SBYTE:
			writer.Write((sbyte)value);
			break;
		case ParamType.INT:
			writer.Write((int)value);
			break;
		case ParamType.USHORT:
			writer.Write((ushort)value);
			break;
		case ParamType.ULONG:
			writer.Write((ulong)value);
			break;
		case ParamType.LONG:
			writer.Write((long)value);
			break;
		case ParamType.UINT:
			writer.Write((uint)value);
			break;
		case ParamType.DOUBLE:
			writer.Write((double)value);
			break;
		case ParamType.FLOAT:
			writer.Write((float)value);
			break;
		case ParamType.GUID:
			writer.Write(((Guid)value).ToByteArray());
			break;
		case ParamType.DATETIME:
			writer.Write(((DateTime)value).ToBinary());
			break;
		case ParamType.DECIMAL:
			writer.Write((decimal)value);
			break;
		}
	}

	[CompilerGenerated]
	private void method_1(ParamType param, object value)
	{
		byte[] array = null;
		if (value is string s)
		{
			array = base.Rules.stringEncoding.GetBytes(s);
		}
		else
		{
			if (!(value is byte[] array2))
			{
				throw new ArgumentException("Invalid type of data (only string and byte[] are allowed).", "value");
			}
			array = array2;
		}
		writer.Write(array.Length);
		writer.Write(base.Rules.commandDefine);
		writer.Write(array);
	}
}
