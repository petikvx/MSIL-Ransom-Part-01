using System.Globalization;

namespace Ubiety.Dns.Core.Records;

public class RecordSig : Record
{
	public ushort TypeCovered { get; set; }

	public byte Algorithm { get; set; }

	public byte Labels { get; set; }

	public uint OriginalTTL { get; set; }

	public uint SignatureExpiration { get; set; }

	public uint SignatureInception { get; set; }

	public ushort KeyTag { get; set; }

	public string SignersName { get; set; }

	public string Signature { get; set; }

	public RecordSig(RecordReader rr)
	{
		TypeCovered = rr.ReadUInt16();
		Algorithm = rr.ReadByte();
		Labels = rr.ReadByte();
		OriginalTTL = rr.ReadUInt32();
		SignatureExpiration = rr.ReadUInt32();
		SignatureInception = rr.ReadUInt32();
		KeyTag = rr.ReadUInt16();
		SignersName = rr.ReadDomainName();
		Signature = rr.ReadString();
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, "{0} {1} {2} {3} {4} {5} {6} {7} \"{8}\"", TypeCovered, Algorithm, Labels, OriginalTTL, SignatureExpiration, SignatureInception, KeyTag, SignersName, Signature);
	}
}
