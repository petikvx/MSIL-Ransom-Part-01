using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace ExciteRAN;

internal class PluginDictionary
{
	internal static readonly byte[] windowPosition;

	static PluginDictionary()
	{
		if (windowPosition != null)
		{
			return;
		}
		while (true)
		{
			switch (7)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			string s = "RXhjaXRlUkFOJA==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			windowPosition = StreamTree.SaveFile(97L, manifestResourceStream);
			return;
		}
	}

	internal static string CheckContext(int windowPosition)
	{
		int num = 0;
		if ((PluginDictionary.windowPosition[windowPosition] & 0x80) == 0)
		{
			while (true)
			{
				switch (7)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			num = PluginDictionary.windowPosition[windowPosition];
			windowPosition++;
		}
		else if ((PluginDictionary.windowPosition[windowPosition] & 0x40) == 0)
		{
			while (true)
			{
				switch (6)
				{
				case 0:
					continue;
				}
				break;
			}
			num = (PluginDictionary.windowPosition[windowPosition] & -129) << 8;
			num |= PluginDictionary.windowPosition[windowPosition + 1];
			windowPosition += 2;
		}
		else
		{
			num = (PluginDictionary.windowPosition[windowPosition] & -193) << 24;
			num |= PluginDictionary.windowPosition[windowPosition + 1] << 16;
			num |= PluginDictionary.windowPosition[windowPosition + 2] << 8;
			num |= PluginDictionary.windowPosition[windowPosition + 3];
			windowPosition += 4;
		}
		if (num < 1)
		{
			while (true)
			{
				switch (7)
				{
				case 0:
					break;
				default:
					return string.Empty;
				}
			}
		}
		string @string = Encoding.Unicode.GetString(PluginDictionary.windowPosition, windowPosition, num);
		return string.Intern(@string);
	}
}
