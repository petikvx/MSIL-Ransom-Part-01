using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp52;

internal static class Samsung
{
	internal static byte[] Buffer(string encoded)
	{
		string[] array = new string[256];
		IDictionary<string, byte> dictionary = new Dictionary<string, byte>();
		foreach (int item in Enumerable.Range(0, 256))
		{
			string text = (array[item] = ((byte)item).ToString("X2"));
			dictionary[text] = (byte)item;
			dictionary[text.ToLowerInvariant()] = (byte)item;
		}
		byte[] array2 = new byte[encoded.Length / 2];
		foreach (int item2 in Enumerable.Range(0, array2.Length))
		{
			array2[item2] = dictionary[encoded.Substring(item2 * 2, 2)];
		}
		return array2;
	}
}
