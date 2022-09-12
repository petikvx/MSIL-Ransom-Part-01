using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;

namespace Ubiety.Dns.Core.Records;

public class RecordNsap : Record
{
	private readonly byte[] _address;

	public ushort Length { get; set; }

	public Collection<byte> NsapAddress => new Collection<byte>(_address);

	public RecordNsap(RecordReader rr)
	{
		Length = rr.ReadUInt16();
		_address = rr.ReadBytes(Length);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0} ", new object[1] { Length });
		byte[] address = _address;
		foreach (byte b in address)
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0:X00}", new object[1] { b });
		}
		return stringBuilder.ToString();
	}

	public string ToGOSIPV2()
	{
		return string.Format(CultureInfo.InvariantCulture, "{0:X}.{1:X}.{2:X}.{3:X}.{4:X}.{5:X}.{6:X}{7:X}.{8:X}", _address[0], (_address[1] << 8) | _address[2], _address[3], (_address[4] << 16) | (_address[5] << 8) | _address[6], (_address[7] << 8) | _address[8], (_address[9] << 8) | _address[10], (_address[11] << 8) | _address[12], (_address[13] << 16) | (_address[14] << 8) | _address[15], (_address[16] << 16) | (_address[17] << 8) | _address[18]);
	}
}
