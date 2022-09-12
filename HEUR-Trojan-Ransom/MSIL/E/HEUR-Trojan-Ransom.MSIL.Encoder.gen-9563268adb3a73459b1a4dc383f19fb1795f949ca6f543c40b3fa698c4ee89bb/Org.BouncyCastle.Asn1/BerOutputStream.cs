using System;
using System.IO;

namespace Org.BouncyCastle.Asn1;

public class BerOutputStream : DerOutputStream
{
	public BerOutputStream(Stream os)
		: base(os)
	{
	}

	[Obsolete("Use version taking an Asn1Encodable arg instead")]
	public override void WriteObject(object obj)
	{
		if (obj == null)
		{
			WriteNull();
			return;
		}
		if (obj is Asn1Object)
		{
			((Asn1Object)obj).Encode(this);
			return;
		}
		if (!(obj is Asn1Encodable))
		{
			throw new IOException("object not BerEncodable");
		}
		((Asn1Encodable)obj).ToAsn1Object().Encode(this);
	}
}
