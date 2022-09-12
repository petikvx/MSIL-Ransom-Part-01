using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Ubiety.Dns.Core.Common;

namespace Ubiety.Dns.Core;

public class Question
{
	private string _questionName;

	public string QuestionName
	{
		get
		{
			return _questionName;
		}
		private set
		{
			_questionName = value;
			if (!_questionName.EndsWith(".", StringComparison.InvariantCulture))
			{
				_questionName += ".";
			}
		}
	}

	public QuestionType QuestionType { get; }

	public QuestionClass QuestionClass { get; }

	public Question(string questionName, QuestionType questionType, QuestionClass questionClass)
	{
		QuestionName = questionName;
		QuestionType = questionType;
		QuestionClass = questionClass;
	}

	internal Question(RecordReader rr)
	{
		QuestionName = rr.ReadDomainName();
		QuestionType = (QuestionType)rr.ReadUInt16();
		QuestionClass = (QuestionClass)rr.ReadUInt16();
	}

	public override string ToString()
	{
		return string.Format("{0,-32}\t{1}\t{2}", QuestionName, QuestionClass, QuestionType);
	}

	public IEnumerable<byte> GetData()
	{
		List<byte> list = new List<byte>();
		list.AddRange(WriteName(QuestionName));
		list.AddRange(WriteShort((ushort)QuestionType));
		list.AddRange(WriteShort((ushort)QuestionClass));
		return list.ToArray();
	}

	private static IEnumerable<byte> WriteName(string src)
	{
		if (!src.EndsWith(".", StringComparison.InvariantCulture))
		{
			src += ".";
		}
		if (src == ".")
		{
			return new byte[1];
		}
		StringBuilder stringBuilder = new StringBuilder();
		int length = src.Length;
		stringBuilder.Append('\0');
		int num = 0;
		int num2 = 0;
		while (num < length)
		{
			stringBuilder.Append(src[num]);
			if (src[num] == '.')
			{
				stringBuilder[num - num2] = (char)((uint)num2 & 0xFFu);
				num2 = -1;
			}
			num++;
			num2++;
		}
		stringBuilder[stringBuilder.Length - 1] = '\0';
		return Encoding.ASCII.GetBytes(stringBuilder.ToString());
	}

	private static IEnumerable<byte> WriteShort(ushort value)
	{
		return BitConverter.GetBytes(IPAddress.HostToNetworkOrder((short)value));
	}
}
