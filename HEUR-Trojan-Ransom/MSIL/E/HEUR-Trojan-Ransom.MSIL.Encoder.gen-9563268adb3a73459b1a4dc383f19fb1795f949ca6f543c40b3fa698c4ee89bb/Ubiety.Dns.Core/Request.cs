using System.Collections.Generic;
using Ubiety.Dns.Core.Common;

namespace Ubiety.Dns.Core;

public class Request
{
	private readonly List<Question> _questions;

	public Header Header { get; }

	public Request()
	{
		Header = new Header
		{
			OpCode = OperationCode.Query,
			QuestionCount = 0
		};
		_questions = new List<Question>();
	}

	public byte[] GetData()
	{
		List<byte> list = new List<byte>();
		Header.QuestionCount = (ushort)_questions.Count;
		list.AddRange(Header.GetData());
		foreach (Question question in _questions)
		{
			list.AddRange(question.GetData());
		}
		return list.ToArray();
	}

	public void AddQuestion(Question question)
	{
		_questions.Add(question);
	}
}
