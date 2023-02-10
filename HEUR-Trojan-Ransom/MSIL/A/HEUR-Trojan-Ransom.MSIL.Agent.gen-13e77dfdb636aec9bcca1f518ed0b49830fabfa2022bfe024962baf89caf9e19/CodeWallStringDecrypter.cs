using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

internal class CodeWallStringDecrypter
{
	private static object _o;

	private static Dictionary<int, string> _d;

	private static string Decrypt(int P_0, int P_1, int P_2)
	{
		int num = 0;
		string result = default(string);
		while (true)
		{
			int num2 = -1751090888;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)_003CModule_003E.BatchSize(num2)) % 8u)
				{
				case 7u:
					break;
				case 6u:
				{
					byte[] array = null;
					num2 = ((int)num3 * -1236120934) ^ -1043441931;
					continue;
				}
				case 1u:
				{
					Assembly assembly = null;
					num2 = ((int)num3 * -564906664) ^ 0x38A4F32;
					continue;
				}
				case 2u:
				{
					Random random = null;
					num2 = ((int)num3 * -84676257) ^ 0x7E32AF03;
					continue;
				}
				case 5u:
					result = null;
					num2 = (int)((num3 * 1201866949) ^ 0x1FB44586);
					continue;
				case 4u:
				{
					Stream stream = null;
					num2 = (int)((num3 * 973789034) ^ 0x56FDADC);
					continue;
				}
				case 3u:
				{
					object obj = null;
					num2 = ((int)num3 * -1946377650) ^ -726432428;
					continue;
				}
				default:
					return result;
				}
				break;
			}
		}
	}

	static CodeWallStringDecrypter()
	{
		_d = new Dictionary<int, string>();
	}
}
