using System;
using System.Globalization;

namespace The_chViewer;

public class NmeaParser
{
	public static GpsPoint Parse(string sentence)
	{
		if (IsValid(sentence))
		{
			string text = GetWords(sentence)[0];
			if (text == "$GPRMC")
			{
				return ParseGPRMC(sentence);
			}
			if (text == "$GPGGA")
			{
				return ParseGPGGA(sentence);
			}
		}
		return null;
	}

	private static GpsPoint ParseGPGGA(string sentence)
	{
		GpsPoint gpsPoint = new GpsPoint();
		string[] words = GetWords(sentence);
		if ((words[2] != "") & (words[3] != "") & (words[4] != "") & (words[5] != ""))
		{
			int degrees = Convert.ToInt32(words[2].Substring(0, 2));
			double minutes = Convert.ToDouble(words[2].Substring(2), CultureInfo.InvariantCulture);
			gpsPoint.Latitude = DMSToDecimalDegrees(degrees, minutes, 0.0);
			if (words[3].ToUpper() == "S")
			{
				gpsPoint.Latitude *= -1.0;
			}
			degrees = Convert.ToInt32(words[4].Substring(0, 3));
			minutes = Convert.ToDouble(words[4].Substring(3), CultureInfo.InvariantCulture);
			gpsPoint.Longitude = DMSToDecimalDegrees(degrees, minutes, 0.0);
			if (words[5].ToUpper() == "W")
			{
				gpsPoint.Longitude *= -1.0;
			}
		}
		if (words[1] != "")
		{
			int hour = Convert.ToInt32(words[1].Substring(0, 2));
			int minute = Convert.ToInt32(words[1].Substring(2, 2));
			int second = Convert.ToInt32(words[1].Substring(4, 2));
			int millisecond = 0;
			if (words[1].Length > 7)
			{
				millisecond = Convert.ToInt32(words[1].Substring(7));
			}
			DateTime dateTime = DateTime.Today.ToUniversalTime();
			DateTime dateTime3 = (gpsPoint.Time = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, hour, minute, second, millisecond));
		}
		return gpsPoint;
	}

	private static GpsPoint ParseGPRMC(string sentence)
	{
		GpsPoint gpsPoint = new GpsPoint();
		string[] words = GetWords(sentence);
		if ((words[3] != "") & (words[4] != "") & (words[5] != "") & (words[6] != ""))
		{
			int degrees = Convert.ToInt32(words[3].Substring(0, 2));
			double minutes = Convert.ToDouble(words[3].Substring(2), CultureInfo.InvariantCulture);
			gpsPoint.Latitude = DMSToDecimalDegrees(degrees, minutes, 0.0);
			if (words[4].ToUpper() == "S")
			{
				gpsPoint.Latitude *= -1.0;
			}
			degrees = Convert.ToInt32(words[5].Substring(0, 3));
			minutes = Convert.ToDouble(words[5].Substring(3), CultureInfo.InvariantCulture);
			gpsPoint.Longitude = DMSToDecimalDegrees(degrees, minutes, 0.0);
			if (words[6].ToUpper() == "W")
			{
				gpsPoint.Longitude *= -1.0;
			}
		}
		if (words[1] != "" && !string.IsNullOrEmpty(words[9]))
		{
			int hour = Convert.ToInt32(words[1].Substring(0, 2));
			int minute = Convert.ToInt32(words[1].Substring(2, 2));
			int second = Convert.ToInt32(words[1].Substring(4, 2));
			int millisecond = 0;
			if (words[1].Length > 7)
			{
				millisecond = Convert.ToInt32(words[1].Substring(7));
			}
			int day = Convert.ToInt32(words[9].Substring(0, 2));
			int month = Convert.ToInt32(words[9].Substring(2, 2));
			int year = Convert.ToInt32(DateTime.Today.Year.ToString().Substring(0, 2)) * 100 + Convert.ToInt32(words[9].Substring(4, 2));
			DateTime dateTime2 = (gpsPoint.Time = new DateTime(year, month, day, hour, minute, second, millisecond));
		}
		return gpsPoint;
	}

	private static string GetChecksum(string sentence)
	{
		int num = 0;
		foreach (char c in sentence)
		{
			switch (c)
			{
			default:
				num = ((num != 0) ? (num ^ Convert.ToByte(c)) : Convert.ToByte(c));
				continue;
			case '$':
				continue;
			case '*':
				break;
			}
			break;
		}
		return num.ToString("X2");
	}

	private static string[] GetWords(string sentence)
	{
		return sentence.Split(new char[1] { ',' });
	}

	private static bool IsValid(string sentence)
	{
		return sentence.Substring(sentence.IndexOf("*") + 1) == GetChecksum(sentence);
	}

	public static double DMSToDecimalDegrees(int degrees, double minutes, double seconds)
	{
		return (double)degrees + minutes / 60.0 + seconds / 3600.0;
	}
}
