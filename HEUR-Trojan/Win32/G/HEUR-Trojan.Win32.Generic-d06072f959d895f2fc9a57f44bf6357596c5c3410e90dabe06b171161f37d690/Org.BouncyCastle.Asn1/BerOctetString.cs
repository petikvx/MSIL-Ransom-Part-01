using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class BerOctetString : DerOctetString, IEnumerable
{
	private class ChunkEnumerator : IEnumerator
	{
		private readonly byte[] octets;

		private readonly int chunkSize;

		private DerOctetString currentChunk;

		private int nextChunkPos;

		public object Current
		{
			get
			{
				if (currentChunk == null)
				{
					throw new InvalidOperationException();
				}
				return currentChunk;
			}
		}

		internal ChunkEnumerator(byte[] octets, int chunkSize)
		{
			this.octets = octets;
			this.chunkSize = chunkSize;
		}

		public bool MoveNext()
		{
			if (nextChunkPos >= octets.Length)
			{
				currentChunk = null;
				return false;
			}
			int num = System.Math.Min(octets.Length - nextChunkPos, chunkSize);
			byte[] array = new byte[num];
			Array.Copy(octets, nextChunkPos, array, 0, num);
			currentChunk = new DerOctetString(array);
			nextChunkPos += num;
			return true;
		}

		public void Reset()
		{
			currentChunk = null;
			nextChunkPos = 0;
		}
	}

	private static readonly int DefaultChunkSize = 1000;

	private readonly int chunkSize;

	private readonly Asn1OctetString[] octs;

	public static BerOctetString FromSequence(Asn1Sequence seq)
	{
		int count = seq.Count;
		Asn1OctetString[] array = new Asn1OctetString[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = Asn1OctetString.GetInstance(seq[i]);
		}
		return new BerOctetString(array);
	}

	internal static byte[] FlattenOctetStrings(Asn1OctetString[] octetStrings)
	{
		int num = octetStrings.Length;
		switch (num)
		{
		default:
		{
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				num2 += octetStrings[i].str.Length;
			}
			byte[] array = new byte[num2];
			int num3 = 0;
			for (int j = 0; j < num; j++)
			{
				byte[] array2 = octetStrings[j].str;
				Array.Copy(array2, 0, array, num3, array2.Length);
				num3 += array2.Length;
			}
			return array;
		}
		case 1:
			return octetStrings[0].str;
		case 0:
			return Asn1OctetString.EmptyOctets;
		}
	}

	private static Asn1OctetString[] ToOctetStringArray(IEnumerable e)
	{
		IList list = Platform.CreateArrayList(e);
		int count = list.Count;
		Asn1OctetString[] array = new Asn1OctetString[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = Asn1OctetString.GetInstance(list[i]);
		}
		return array;
	}

	[Obsolete("Will be removed")]
	public BerOctetString(IEnumerable e)
		: this(ToOctetStringArray(e))
	{
	}

	public BerOctetString(byte[] str)
		: this(str, DefaultChunkSize)
	{
	}

	public BerOctetString(Asn1OctetString[] octs)
		: this(octs, DefaultChunkSize)
	{
	}

	public BerOctetString(byte[] str, int chunkSize)
		: this(str, null, chunkSize)
	{
	}

	public BerOctetString(Asn1OctetString[] octs, int chunkSize)
		: this(FlattenOctetStrings(octs), octs, chunkSize)
	{
	}

	private BerOctetString(byte[] str, Asn1OctetString[] octs, int chunkSize)
		: base(str)
	{
		this.octs = octs;
		this.chunkSize = chunkSize;
	}

	public IEnumerator GetEnumerator()
	{
		if (octs == null)
		{
			return new ChunkEnumerator(str, chunkSize);
		}
		return octs.GetEnumerator();
	}

	[Obsolete("Use GetEnumerator() instead")]
	public IEnumerator GetObjects()
	{
		return GetEnumerator();
	}

	internal override void Encode(DerOutputStream derOut)
	{
		if (!(derOut is Asn1OutputStream) && !(derOut is BerOutputStream))
		{
			base.Encode(derOut);
			return;
		}
		derOut.WriteByte(36);
		derOut.WriteByte(128);
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Asn1OctetString obj = (Asn1OctetString)enumerator.Current;
				derOut.WriteObject(obj);
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		derOut.WriteByte(0);
		derOut.WriteByte(0);
	}
}
