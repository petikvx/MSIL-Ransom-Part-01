using System;
using System.IO;
using System.Text;

namespace The_chViewer;

public class GpsRec
{
	private int latitude = -1;

	private int longitude = -1;

	private int timeZ = -1;

	private int date = -1;

	private int speed;

	private int altitude;

	private int unk1;

	private int typeOfCurRec = -1;

	private int typeOfNextRec = -1;

	public GpsRec()
	{
		typeOfNextRec = 2;
		typeOfCurRec = 2;
		latitude = 0;
		longitude = 0;
		timeZ = 0;
		date = 0;
		speed = 0;
		altitude = 0;
		unk1 = -1;
	}

	public void copy(GpsRec init)
	{
		typeOfNextRec = init.typeOfNextRec;
		typeOfCurRec = init.typeOfCurRec;
		latitude = init.latitude;
		longitude = init.longitude;
		timeZ = init.timeZ;
		date = init.date;
		speed = init.speed;
		altitude = init.altitude;
		unk1 = init.unk1;
	}

	public GpsRec(GpsRec init)
	{
		copy(init);
	}

	public bool equals(object arg0)
	{
		bool result = false;
		if (arg0 != null && arg0 is GpsRec)
		{
			GpsRec gpsRec = (GpsRec)arg0;
			result = typeOfNextRec == gpsRec.typeOfNextRec && typeOfCurRec == gpsRec.typeOfCurRec && latitude == gpsRec.latitude && longitude == gpsRec.longitude && timeZ == gpsRec.timeZ && date == gpsRec.date && speed == gpsRec.speed && altitude == gpsRec.altitude && unk1 == gpsRec.unk1;
		}
		return result;
	}

	public GpsRec(BinaryReader buf, int recType)
	{
		typeOfNextRec = recType;
		typeOfCurRec = recType;
		switch (recType)
		{
		case 0:
			latitude = GetInt(buf);
			longitude = GetInt(buf);
			break;
		case 1:
			date = GetInt(buf);
			if (date.ToString().Length > 6)
			{
				latitude = date;
				longitude = GetInt(buf);
				timeZ = GetInt(buf);
				date = GetInt(buf);
				speed = GetInt(buf);
			}
			else
			{
				speed = GetInt(buf);
				latitude = GetInt(buf);
				longitude = GetInt(buf);
				timeZ = GetInt(buf);
			}
			break;
		case 2:
			latitude = GetInt(buf);
			longitude = GetInt(buf);
			timeZ = GetInt(buf);
			date = GetInt(buf);
			speed = GetInt(buf);
			altitude = GetInt(buf);
			unk1 = GetInt(buf);
			typeOfNextRec = GetInt(buf);
			break;
		}
	}

	public bool isValid()
	{
		if (latitude <= 360000000 && latitude >= 0 && longitude <= 360000000 && longitude >= 0 && timeZ >= 0 && timeZ <= 240000 && unk1 >= 0)
		{
			return unk1 <= 1;
		}
		return false;
	}

	public int getTypeOfNextRec()
	{
		return typeOfNextRec;
	}

	public override string ToString()
	{
		return "[GpsRec:  lat = " + latitude + ", long = " + longitude + ", timeZ = " + timeZ + ", date = " + date + ", speed = " + speed + ", alt = " + altitude + ", unk1 = " + unk1 + ", typeOfCurRec = " + typeOfCurRec + ", typeOfNextRec = " + typeOfNextRec + "]";
	}

	public int getLatitude()
	{
		return latitude;
	}

	public string ToGpxTrkpt()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<trkpt");
		stringBuilder.Append(" lat=\"").Append(ToDegree(latitude).ToString().Replace(',', '.')).Append("\"");
		stringBuilder.Append(" lon=\"").Append(ToDegree(longitude).ToString().Replace(',', '.')).Append("\"");
		stringBuilder.Append(">");
		if (typeOfCurRec > 0)
		{
			stringBuilder.Append("<time>").Append(getZuluTime(timeZ, date)).Append("</time>");
			stringBuilder.Append("<speed>").Append((double)speed / 360.0).Append("</speed>");
			if (typeOfCurRec > 1)
			{
				stringBuilder.Append("<ele>").Append((double)altitude / 10000.0).Append("</ele>");
			}
		}
		stringBuilder.Append("</trkpt>");
		return stringBuilder.ToString();
	}

	public string ToGpxWpt()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<wpt");
		stringBuilder.Append(" lat=\"").Append(ToDegree(longitude)).Append("\"");
		stringBuilder.Append(" lon=\"").Append(ToDegree(longitude)).Append("\"");
		stringBuilder.Append(">");
		if (typeOfCurRec > 0)
		{
			stringBuilder.Append("<time>").Append(getZuluTime(timeZ, date)).Append("</time>");
			if (typeOfCurRec > 1)
			{
				stringBuilder.Append("<ele>").Append((double)altitude / 10000.0).Append("</ele>");
			}
		}
		stringBuilder.Append("</wpt>");
		return stringBuilder.ToString();
	}

	private static double ToDegree(int gsLatOrLon)
	{
		double num = gsLatOrLon / 1000000;
		double num2 = ((double)gsLatOrLon - num * 1000000.0) / 600000.0;
		return num + num2;
	}

	private string ToDateTime(string dateTimeFormat)
	{
		int num = timeZ / 10000;
		int num2 = (timeZ - num * 10000) / 100;
		int second = timeZ - num * 10000 - num2 * 100;
		int num3 = date / 10000;
		int num4 = (date - num3 * 10000) / 100;
		int year = 2000 + (date - num3 * 10000 - num4 * 100);
		DateTime dateTime;
		try
		{
			dateTime = new DateTime(year, num4, num3, num, num2, second);
		}
		catch (ArgumentOutOfRangeException)
		{
			dateTime = DateTime.UtcNow;
		}
		return dateTime.ToString(dateTimeFormat);
	}

	private string getZuluTime(int gsTime, int gsDate)
	{
		return ToDateTime("yyyy-MM-dd'T'HH:mm:ss'Z'");
	}

	public string getDateTimeString()
	{
		return ToDateTime("yyyyMMddHHmmss");
	}

	public int getAltitude()
	{
		return altitude;
	}

	public void setAltitude(int altitude)
	{
		this.altitude = altitude;
	}

	public int getDate()
	{
		return date;
	}

	public void setDate(int date)
	{
		this.date = date;
	}

	public int getLongitude()
	{
		return longitude;
	}

	public void setLongitude(int longitude)
	{
		this.longitude = longitude;
	}

	public int getSpeed()
	{
		return speed;
	}

	public void setSpeed(int speed)
	{
		this.speed = speed;
	}

	public int getTimeZ()
	{
		return timeZ;
	}

	public void setTimeZ(int timeZ)
	{
		this.timeZ = timeZ;
	}

	public void setLatitude(int latitude)
	{
		this.latitude = latitude;
	}

	private static byte[] GetShort(int num)
	{
		if (num > 255)
		{
			return new byte[2]
			{
				(byte)(num / 100),
				(byte)(num - 1000)
			};
		}
		return new byte[2]
		{
			0,
			(byte)num
		};
	}

	private static int GetInt(BinaryReader buf)
	{
		byte num = buf.ReadByte();
		byte b = buf.ReadByte();
		byte b2 = buf.ReadByte();
		byte b3 = buf.ReadByte();
		return num * 256 * 256 * 256 + b * 256 * 256 + b2 * 256 + b3;
	}
}
