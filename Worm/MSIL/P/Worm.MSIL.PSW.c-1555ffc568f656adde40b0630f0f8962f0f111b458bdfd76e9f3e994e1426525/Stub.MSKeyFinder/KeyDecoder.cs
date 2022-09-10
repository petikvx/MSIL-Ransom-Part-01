using System.Collections;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Stub.MSKeyFinder;

public class KeyDecoder
{
	public enum Key
	{
		XP,
		Office11,
		Office12
	}

	[DebuggerNonUserCode]
	public KeyDecoder()
	{
	}

	public static byte[] GetRegistryDigitalProductId(Key key)
	{
		byte[] result = null;
		RegistryKey registryKey = null;
		switch (key)
		{
		case Key.XP:
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: false);
			break;
		case Key.Office11:
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Office\\11.0\\Registration\\{90110409-6000-11D3-8CFE-0150048383C9}", writable: false);
			break;
		case Key.Office12:
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Office\\12.0\\Registration\\{91120000-002F-0000-0000-0000000FF1CE}", writable: false);
			break;
		}
		if (registryKey != null)
		{
			result = registryKey.GetValue("DigitalProductId") as byte[];
			registryKey.Close();
			return result;
		}
		if (registryKey == null)
		{
			result = null;
		}
		return result;
	}

	public static string DecodeProductKey(byte[] digitalProductId)
	{
		if (digitalProductId == null)
		{
			return "";
		}
		char[] array = new char[24]
		{
			'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'M', 'P',
			'Q', 'R', 'T', 'V', 'W', 'X', 'Y', '2', '3', '4',
			'6', '7', '8', '9'
		};
		char[] array2 = new char[29];
		ArrayList arrayList = new ArrayList();
		int num = 52;
		checked
		{
			do
			{
				arrayList.Add(digitalProductId[num]);
				num++;
			}
			while (num <= 67);
			int num2 = 28;
			do
			{
				if (unchecked(checked(num2 + 1) % 6) != 0)
				{
					int num3 = 0;
					int num4 = 14;
					do
					{
						int num5 = (num3 << 8) | Conversions.ToByte(arrayList[num4]);
						arrayList[num4] = (byte)unchecked(num5 / 24);
						num3 = unchecked(num5 % 24);
						array2[num2] = array[num3];
						num4 += -1;
					}
					while (num4 >= 0);
				}
				else
				{
					array2[num2] = '-';
				}
				num2 += -1;
			}
			while (num2 >= 0);
			return new string(array2);
		}
	}
}
