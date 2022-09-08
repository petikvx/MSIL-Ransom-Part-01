using System.Collections.Generic;
using System.Text;

namespace Orcus.Commands.Passwords.Applications.Mozilla.Cryptography;

public class Asn1DerObject
{
	public Asn1Der.Type Type { get; set; }

	public int Lenght { get; set; }

	public List<Asn1DerObject> Objects { get; set; }

	public byte[] Data { get; set; }

	public Asn1DerObject()
	{
		Objects = new List<Asn1DerObject>();
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		switch (Type)
		{
		case Asn1Der.Type.Sequence:
			stringBuilder.AppendLine("SEQUENCE {");
			break;
		case Asn1Der.Type.Integer:
		{
			byte[] data = Data;
			foreach (byte b2 in data)
			{
				stringBuilder2.AppendFormat("{0:X2}", b2);
			}
			stringBuilder.AppendLine("\tINTEGER " + stringBuilder2);
			break;
		}
		case Asn1Der.Type.OctetString:
		{
			byte[] data = Data;
			foreach (byte b3 in data)
			{
				stringBuilder2.AppendFormat("{0:X2}", b3);
			}
			stringBuilder.AppendLine("\tOCTETSTRING " + stringBuilder2);
			break;
		}
		case Asn1Der.Type.ObjectIdentifier:
		{
			byte[] data = Data;
			foreach (byte b in data)
			{
				stringBuilder2.AppendFormat("{0:X2}", b);
			}
			stringBuilder.AppendLine("\tOBJECTIDENTIFIER " + stringBuilder2);
			break;
		}
		}
		foreach (Asn1DerObject @object in Objects)
		{
			stringBuilder.Append(@object);
		}
		if (Type.Equals(Asn1Der.Type.Sequence))
		{
			stringBuilder.AppendLine("}");
		}
		return stringBuilder.ToString();
	}
}
