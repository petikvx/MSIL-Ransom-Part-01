using System.Collections.ObjectModel;
using System.Globalization;

namespace Ubiety.Dns.Core.Records;

public class RecordWks : Record
{
	private readonly byte[] _bitmap;

	public string Address { get; set; }

	public int Protocol { get; set; }

	public Collection<byte> Bitmap => new Collection<byte>(_bitmap);

	public RecordWks(RecordReader rr)
	{
		ushort num = rr.ReadUInt16(-2);
		Address = string.Format(CultureInfo.InvariantCulture, "{0}.{1}.{2}.{3}", rr.ReadByte(), rr.ReadByte(), rr.ReadByte(), rr.ReadByte());
		Protocol = rr.ReadByte();
		num = (ushort)(num - 5);
		_bitmap = new byte[num];
		_bitmap = rr.ReadBytes(num);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, "{0} {1}", new object[2] { Address, Protocol });
	}
}
