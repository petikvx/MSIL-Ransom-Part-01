using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

internal sealed class DtlsReassembler
{
	private sealed class Range
	{
		private int m_start;

		private int m_end;

		public int Start
		{
			get
			{
				return m_start;
			}
			set
			{
				m_start = value;
			}
		}

		public int End
		{
			get
			{
				return m_end;
			}
			set
			{
				m_end = value;
			}
		}

		internal Range(int start, int end)
		{
			m_start = start;
			m_end = end;
		}
	}

	private readonly short m_msg_type;

	private readonly byte[] m_body;

	private readonly IList m_missing = Platform.CreateArrayList();

	internal short MsgType => m_msg_type;

	internal DtlsReassembler(short msg_type, int length)
	{
		m_msg_type = msg_type;
		m_body = new byte[length];
		m_missing.Add(new Range(0, length));
	}

	internal byte[] GetBodyIfComplete()
	{
		if (m_missing.Count <= 0)
		{
			return m_body;
		}
		return null;
	}

	internal void ContributeFragment(short msg_type, int length, byte[] buf, int off, int fragment_offset, int fragment_length)
	{
		int num = fragment_offset + fragment_length;
		if (m_msg_type != msg_type || m_body.Length != length || num > length)
		{
			return;
		}
		if (fragment_length == 0)
		{
			if (fragment_offset == 0 && m_missing.Count > 0 && ((Range)m_missing[0]).End == 0)
			{
				m_missing.RemoveAt(0);
			}
			return;
		}
		for (int i = 0; i < m_missing.Count; i++)
		{
			Range range = (Range)m_missing[i];
			if (range.Start >= num)
			{
				break;
			}
			if (range.End <= fragment_offset)
			{
				continue;
			}
			int num2 = System.Math.Max(range.Start, fragment_offset);
			int num3 = System.Math.Min(range.End, num);
			int length2 = num3 - num2;
			Array.Copy(buf, off + num2 - fragment_offset, m_body, num2, length2);
			if (num2 == range.Start)
			{
				if (num3 == range.End)
				{
					m_missing.RemoveAt(i--);
				}
				else
				{
					range.Start = num3;
				}
				continue;
			}
			if (num3 != range.End)
			{
				m_missing.Insert(++i, new Range(num3, range.End));
			}
			range.End = num2;
		}
	}

	internal void Reset()
	{
		m_missing.Clear();
		m_missing.Add(new Range(0, m_body.Length));
	}
}
