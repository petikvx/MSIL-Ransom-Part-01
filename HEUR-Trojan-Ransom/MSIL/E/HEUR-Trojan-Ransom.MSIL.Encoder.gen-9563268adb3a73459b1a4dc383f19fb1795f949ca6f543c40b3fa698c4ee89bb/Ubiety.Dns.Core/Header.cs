using System;
using System.Collections.Generic;
using System.Net;
using Ubiety.Dns.Core.Common;

namespace Ubiety.Dns.Core;

public class Header
{
	private ushort _flags;

	public ushort Id { get; set; }

	public ushort QuestionCount { get; set; }

	public ushort AnswerCount { get; set; }

	public ushort NameserverCount { get; set; }

	public ushort AdditionalRecordsCount { get; set; }

	public bool QueryResponse
	{
		get
		{
			return GetBits(_flags, 15, 1) == 1;
		}
		set
		{
			_flags = SetBits(_flags, 15, 1, value);
		}
	}

	public OperationCode OpCode
	{
		get
		{
			return (OperationCode)GetBits(_flags, 11, 4);
		}
		set
		{
			_flags = SetBits(_flags, 11, 4, (ushort)value);
		}
	}

	public bool AuthoritativeAnswer
	{
		get
		{
			return GetBits(_flags, 10, 1) == 1;
		}
		set
		{
			_flags = SetBits(_flags, 10, 1, value);
		}
	}

	public bool Truncation
	{
		get
		{
			return GetBits(_flags, 9, 1) == 1;
		}
		set
		{
			_flags = SetBits(_flags, 9, 1, value);
		}
	}

	public bool Recursion
	{
		get
		{
			return GetBits(_flags, 8, 1) == 1;
		}
		set
		{
			_flags = SetBits(_flags, 8, 1, value);
		}
	}

	public bool RecursionAvailable
	{
		get
		{
			return GetBits(_flags, 7, 1) == 1;
		}
		set
		{
			_flags = SetBits(_flags, 7, 1, value);
		}
	}

	public ushort Z
	{
		get
		{
			return GetBits(_flags, 4, 3);
		}
		set
		{
			_flags = SetBits(_flags, 4, 3, value);
		}
	}

	public ResponseCode ResponseCode
	{
		get
		{
			return (ResponseCode)GetBits(_flags, 0, 4);
		}
		set
		{
			_flags = SetBits(_flags, 0, 4, (ushort)value);
		}
	}

	public Header()
	{
	}

	internal Header(RecordReader rr)
	{
		Id = rr.ReadUInt16();
		_flags = rr.ReadUInt16();
		QuestionCount = rr.ReadUInt16();
		AnswerCount = rr.ReadUInt16();
		NameserverCount = rr.ReadUInt16();
		AdditionalRecordsCount = rr.ReadUInt16();
	}

	public IEnumerable<byte> GetData()
	{
		List<byte> list = new List<byte>();
		list.AddRange(WriteShort(Id));
		list.AddRange(WriteShort(_flags));
		list.AddRange(WriteShort(QuestionCount));
		list.AddRange(WriteShort(AnswerCount));
		list.AddRange(WriteShort(NameserverCount));
		list.AddRange(WriteShort(AdditionalRecordsCount));
		return list.ToArray();
	}

	private static ushort SetBits(ushort oldValue, int position, int length, bool blnValue)
	{
		return SetBits(oldValue, position, length, (ushort)(blnValue ? 1 : 0));
	}

	private static ushort SetBits(ushort oldValue, int position, int length, ushort newValue)
	{
		if (length <= 0 || position >= 16)
		{
			return oldValue;
		}
		int num = (2 << length - 1) - 1;
		oldValue = (ushort)(oldValue & (ushort)(~(num << position)));
		oldValue = (ushort)(oldValue | (ushort)((newValue & num) << position));
		return oldValue;
	}

	private static ushort GetBits(ushort oldValue, int position, int length)
	{
		if (length <= 0 || position >= 16)
		{
			return 0;
		}
		int num = (2 << length - 1) - 1;
		return (ushort)((oldValue >> position) & num);
	}

	private static IEnumerable<byte> WriteShort(ushort value)
	{
		return BitConverter.GetBytes(IPAddress.HostToNetworkOrder((short)value));
	}
}
