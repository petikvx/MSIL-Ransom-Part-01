using System;
using System.IO;
using System.Text;

namespace LogToText;

internal class LogReader
{
	private readonly byte[] sign = new byte[8] { 255, 255, 70, 78, 84, 82, 69, 69 };

	private readonly byte[] endsign = new byte[4] { 0, 69, 78, 68 };

	private uint current_rec_offset;

	private uint first_rec_offset;

	private BinaryReader reader;

	private uint version;

	private Encoding encoding;

	public uint Version => version;

	private uint ReadUInt()
	{
		return reader.ReadUInt32();
	}

	private string ReadString()
	{
		return new string(encoding.GetChars(reader.ReadBytes((int)reader.ReadUInt32())));
	}

	private bool ReadHeader()
	{
		try
		{
			byte[] array = reader.ReadBytes(sign.Length);
			int num = 0;
			while (true)
			{
				if (num < sign.Length)
				{
					if (sign[num] != array[num])
					{
						break;
					}
					num++;
					continue;
				}
				version = ReadUInt();
				ReadUInt();
				first_rec_offset = (uint)reader.BaseStream.Position;
				current_rec_offset = first_rec_offset;
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public LogRec ReadRec()
	{
		try
		{
			reader.BaseStream.Position = current_rec_offset;
			uint num = ReadUInt();
			if (num == 0)
			{
				return null;
			}
			LogRec result = ReadUInt() switch
			{
				0u => ReadCallInfo(), 
				1u => ReadExceptionInfo(), 
				_ => new LogRec(), 
			};
			current_rec_offset += num;
			return result;
		}
		catch
		{
			return null;
		}
	}

	private CallRec ReadCallInfo()
	{
		try
		{
			CallRec callRec = new CallRec();
			callRec.Level = ReadUInt();
			callRec.ThreadId = ReadUInt();
			callRec.CallAddr = ReadUInt();
			callRec.FuncAddr = ReadUInt();
			callRec.FuncName = ReadString();
			uint num = ReadUInt();
			if (num > 50)
			{
				return null;
			}
			callRec.Args = new string[num];
			for (int i = 0; i < num; i++)
			{
				callRec.Args[i] = ReadString();
			}
			return callRec;
		}
		catch
		{
			return null;
		}
	}

	private ExceptionRec ReadExceptionInfo()
	{
		return null;
	}

	public LogReader(Stream input)
		: this(input, Encoding.UTF8)
	{
	}

	public LogReader(Stream input, Encoding encoding)
	{
		this.encoding = encoding;
		input.Seek(0L, SeekOrigin.Begin);
		reader = new BinaryReader(input, encoding);
		if (!ReadHeader())
		{
			throw new Exception("Missing log file header");
		}
	}

	public void Close()
	{
		reader.Close();
	}
}
