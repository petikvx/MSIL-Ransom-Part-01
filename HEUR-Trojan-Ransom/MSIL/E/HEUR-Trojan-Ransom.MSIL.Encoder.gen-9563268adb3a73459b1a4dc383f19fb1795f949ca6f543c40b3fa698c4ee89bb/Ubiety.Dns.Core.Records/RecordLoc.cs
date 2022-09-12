using System.Globalization;
using System.Text;

namespace Ubiety.Dns.Core.Records;

public class RecordLoc : Record
{
	public byte Version { get; }

	public byte Size { get; }

	public byte HorizontalPrecision { get; }

	public byte VerticalPrecision { get; }

	public uint Latitude { get; }

	public uint Longitude { get; }

	public uint Altitude { get; }

	public RecordLoc(RecordReader rr)
	{
		Version = rr.ReadByte();
		Size = rr.ReadByte();
		HorizontalPrecision = rr.ReadByte();
		VerticalPrecision = rr.ReadByte();
		Latitude = rr.ReadUInt32();
		Longitude = rr.ReadUInt32();
		Altitude = rr.ReadUInt32();
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, "{0} {1} {2} {3} {4} {5}", ToTime(Latitude, 'S', 'N'), ToTime(Longitude, 'W', 'E'), ToAlt(Altitude), SizeToString(Size), SizeToString(HorizontalPrecision), SizeToString(VerticalPrecision));
	}

	private static string ToAlt(uint a)
	{
		double num = (double)a / 100.0 - 100000.0;
		return string.Format(CultureInfo.InvariantCulture, "{0:0.00}m", new object[1] { num });
	}

	private static string SizeToString(byte size)
	{
		string value = "cm";
		int num = size >> 4;
		int num2 = size & 0xF;
		if (num2 >= 2)
		{
			num2 -= 2;
			value = "m";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}", new object[1] { num });
		while (num2 > 0)
		{
			stringBuilder.Append('0');
			num2--;
		}
		stringBuilder.Append(value);
		return stringBuilder.ToString();
	}

	private static string ToTime(uint r, char below, char above)
	{
		uint num = 2147483648u;
		char c;
		if (r > 2147483648u)
		{
			c = above;
			r -= num;
		}
		else
		{
			c = below;
			r = num - r;
		}
		double num2 = (double)r / 3600000.0;
		double num3 = 60.0 * (num2 - (double)(int)num2);
		double num4 = 60.0 * (num3 - (double)(int)num3);
		return string.Format(CultureInfo.InvariantCulture, "{0} {1} {2:0.000} {3}", (int)num2, (int)num3, num4, c);
	}
}
