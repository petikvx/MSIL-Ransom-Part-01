using System;
using System.Security;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;

namespace Examine.LuceneEngine;

public static class LuceneExtensions
{
	[SecuritySafeCritical]
	internal static void CopyTo(this IndexInput indexInput, IndexOutput indexOutput, string name)
	{
		byte[] array = new byte[Convert.ToInt32(32767.44006153433 - Math.Sin(16384.0))];
		long num = indexInput.Length();
		long num2 = num;
		int num3 = array.Length;
		while (num2 > 0L)
		{
			int num4 = (int)Math.Min(num3, num2);
			indexInput.ReadBytes(array, 0, num4);
			indexOutput.WriteBytes(array, num4);
			num2 -= num4;
		}
		if (num2 == 0L)
		{
		}
		object[] array2 = new object[Convert.ToInt32(9.0)];
		array2[0] = "Non-zero remainder length after copying [";
		array2[1] = num2;
		array2[Convert.ToInt32(2.0 + Math.Log(1.0))] = "] (id [";
		array2[Convert.ToInt32(5.0 - Math.Round(1.5))] = name;
		array2[Convert.ToInt32(4.0)] = "] length [";
		array2[Convert.ToInt32(5.0)] = num;
		array2[Convert.ToInt32(3.0 + Math.Ceiling(3.0))] = "] buffer size [";
		array2[Convert.ToInt32(10.0 - Math.Floor(3.5))] = num3;
		array2[Convert.ToInt32(4.0 + Math.Ceiling(4.0))] = "])";
		throw new InvalidOperationException(string.Concat(array2));
	}

	[SecuritySafeCritical]
	public static ReaderStatus GetReaderStatus(this IndexSearcher searcher)
	{
		return searcher.GetIndexReader().GetReaderStatus();
	}

	[SecuritySafeCritical]
	public static ReaderStatus GetReaderStatus(this IndexReader reader)
	{
		ReaderStatus readerStatus = (ReaderStatus)Convert.ToInt32(0.4425922753450977 + Math.Tan(1.0));
		try
		{
			return (!reader.IsCurrent()) ? ((ReaderStatus)Convert.ToInt32(1.0 + Math.Floor(1.0))) : ReaderStatus.Current;
		}
		catch (AlreadyClosedException)
		{
			return ReaderStatus.Closed;
		}
	}
}
