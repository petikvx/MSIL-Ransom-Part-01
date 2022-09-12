using System.Collections;

namespace Org.BouncyCastle.Asn1;

internal class LazyDerSequence : DerSequence
{
	private byte[] encoded;

	public override Asn1Encodable this[int index]
	{
		get
		{
			Parse();
			return base[index];
		}
	}

	public override int Count
	{
		get
		{
			Parse();
			return base.Count;
		}
	}

	internal LazyDerSequence(byte[] encoded)
	{
		this.encoded = encoded;
	}

	private void Parse()
	{
		lock (this)
		{
			if (encoded != null)
			{
				Asn1InputStream asn1InputStream = new LazyAsn1InputStream(encoded);
				Asn1Object obj;
				while ((obj = asn1InputStream.ReadObject()) != null)
				{
					AddObject(obj);
				}
				encoded = null;
			}
		}
	}

	public override IEnumerator GetEnumerator()
	{
		Parse();
		return base.GetEnumerator();
	}

	internal override void Encode(DerOutputStream derOut)
	{
		lock (this)
		{
			if (encoded == null)
			{
				base.Encode(derOut);
			}
			else
			{
				derOut.WriteEncoded(48, encoded);
			}
		}
	}
}
