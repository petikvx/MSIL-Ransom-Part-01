using System;
using System.Collections;

namespace Caspol;

internal class ParserStack
{
	private ArrayList m_array;

	public ParserStack()
	{
		m_array = new ArrayList();
	}

	public void Push(ParserStackFrame element)
	{
		m_array.Add(element);
	}

	public ParserStackFrame Pop()
	{
		if (IsEmpty())
		{
			throw new InvalidOperationException(caspol.manager.GetString("InvalidOperation_EmptyStack"));
		}
		int count = m_array.Count;
		ParserStackFrame result = (ParserStackFrame)m_array[count - 1];
		m_array.RemoveAt(count - 1);
		return result;
	}

	public ParserStackFrame Peek()
	{
		if (IsEmpty())
		{
			throw new InvalidOperationException(caspol.manager.GetString("InvalidOperation_EmptyStack"));
		}
		return (ParserStackFrame)m_array[m_array.Count - 1];
	}

	public bool IsEmpty()
	{
		return m_array.Count == 0;
	}

	public int GetCount()
	{
		return m_array.Count;
	}
}
