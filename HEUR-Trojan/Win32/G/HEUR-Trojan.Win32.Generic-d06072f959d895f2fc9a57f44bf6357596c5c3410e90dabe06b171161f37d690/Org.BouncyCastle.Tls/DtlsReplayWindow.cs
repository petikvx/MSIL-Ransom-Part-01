using System;

namespace Org.BouncyCastle.Tls;

internal sealed class DtlsReplayWindow
{
	private const long ValidSeqMask = 281474976710655L;

	private const long WindowSize = 64L;

	private long m_latestConfirmedSeq = -1L;

	private ulong m_bitmap;

	internal bool ShouldDiscard(long seq)
	{
		if ((seq & 0xFFFFFFFFFFFFL) != seq)
		{
			return true;
		}
		if (seq <= m_latestConfirmedSeq)
		{
			long num = m_latestConfirmedSeq - seq;
			if (num >= 64L)
			{
				return true;
			}
			if ((m_bitmap & (ulong)(1L << (int)num)) != 0L)
			{
				return true;
			}
		}
		return false;
	}

	internal void ReportAuthenticated(long seq)
	{
		if ((seq & 0xFFFFFFFFFFFFL) != seq)
		{
			throw new ArgumentException("out of range", "seq");
		}
		if (seq <= m_latestConfirmedSeq)
		{
			long num = m_latestConfirmedSeq - seq;
			if (num < 64L)
			{
				m_bitmap |= (ulong)(1L << (int)num);
			}
			return;
		}
		long num2 = seq - m_latestConfirmedSeq;
		if (num2 >= 64L)
		{
			m_bitmap = 1uL;
		}
		else
		{
			m_bitmap <<= (int)num2;
			m_bitmap |= 1uL;
		}
		m_latestConfirmedSeq = seq;
	}

	internal void Reset(long seq)
	{
		if ((seq & 0xFFFFFFFFFFFFL) != seq)
		{
			throw new ArgumentException("out of range", "seq");
		}
		m_latestConfirmedSeq = seq;
		m_bitmap = ulong.MaxValue >> (int)System.Math.Max(0L, 63L - seq);
	}
}
