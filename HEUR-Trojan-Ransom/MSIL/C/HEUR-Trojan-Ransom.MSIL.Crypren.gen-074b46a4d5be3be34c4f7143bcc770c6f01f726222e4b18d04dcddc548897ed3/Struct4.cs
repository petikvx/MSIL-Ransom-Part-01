using System.IO;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Size = 1)]
internal struct Struct4
{
	internal static void smethod_0(string string_0, string string_1)
	{
		if (!File.Exists(string_0) && 0 == 0)
		{
			return;
		}
		Directory.CreateDirectory(Path.GetDirectoryName(string_1));
		while (true)
		{
			int num = Class46.Class47.smethod_0(72);
			int num2 = 31;
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(414))
				{
				case 116:
					num ^= Class84.smethod_0(93);
					goto default;
				default:
					num2 = Class84.smethod_0(55);
					continue;
				case 115:
					num2 = 24;
					continue;
				case 114:
					switch (num)
					{
					default:
						num2 = 26;
						continue;
					case -110:
						num = -10;
						break;
					case -109:
						Delegate501.smethod_0(string_1);
						num = Class89.smethod_1(56);
						break;
					case -108:
						File.Copy(string_0, string_1, (byte)Class84.smethod_0(1) != 0);
						num = -15;
						break;
					case -107:
						return;
					}
					goto case 116;
				case 113:
					break;
				}
				break;
			}
		}
	}

	internal static void smethod_1(string string_0)
	{
		if (File.Exists(string_0) ? true : false)
		{
			File.SetAttributes(string_0, (FileAttributes)((int)File.GetAttributes(string_0) & Class84.smethod_0(134)));
		}
	}
}
