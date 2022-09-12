using System;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace MySql.Data.Common;

internal struct DBVersion
{
	private readonly string _srcString;

	public int Major { get; }

	public int Minor { get; }

	public int Build { get; }

	public bool IsEnterprise { get; private set; }

	public DBVersion(string s, int major, int minor, int build)
	{
		Major = major;
		Minor = minor;
		Build = build;
		_srcString = s;
		IsEnterprise = s.ToLowerInvariant().Contains("-enterprise-");
	}

	public static DBVersion Parse(string versionString)
	{
		int num = 0;
		int num2 = versionString.IndexOf('.', 0);
		if (num2 == -1)
		{
			throw new MySqlException(Resources.BadVersionFormat);
		}
		int major = Convert.ToInt32(versionString.Substring(num, num2 - num).Trim(), NumberFormatInfo.InvariantInfo);
		num = num2 + 1;
		num2 = versionString.IndexOf('.', num);
		if (num2 == -1)
		{
			throw new MySqlException(Resources.BadVersionFormat);
		}
		int minor = Convert.ToInt32(versionString.Substring(num, num2 - num).Trim(), NumberFormatInfo.InvariantInfo);
		num = num2 + 1;
		int i;
		for (i = num; i < versionString.Length && char.IsDigit(versionString, i); i++)
		{
		}
		int build = Convert.ToInt32(versionString.Substring(num, i - num).Trim(), NumberFormatInfo.InvariantInfo);
		return new DBVersion(versionString, major, minor, build);
	}

	public bool isAtLeast(int majorNum, int minorNum, int buildNum)
	{
		if (Major > majorNum)
		{
			return true;
		}
		if (Major == majorNum && Minor > minorNum)
		{
			return true;
		}
		if (Major == majorNum && Minor == minorNum && Build >= buildNum)
		{
			return true;
		}
		return false;
	}

	public override string ToString()
	{
		return _srcString;
	}
}
