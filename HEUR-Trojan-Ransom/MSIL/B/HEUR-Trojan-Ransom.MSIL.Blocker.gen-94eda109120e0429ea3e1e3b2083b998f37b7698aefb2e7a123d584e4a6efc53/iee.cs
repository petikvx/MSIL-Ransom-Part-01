using System;
using System.Collections.Generic;
using System.Text;

internal static class iee
{
	private sealed class qsy
	{
		public string abv;

		public byte[] abw;

		internal List<byte> uwv()
		{
			List<byte> list = new List<byte>();
			for (int i = 0; i < abw.Length; i++)
			{
				list.Add((byte)(Encoding.ASCII.GetBytes(abv)[i % Encoding.ASCII.GetBytes(abv).Length] ^ abw[i]));
			}
			return list;
		}
	}

	internal static byte[] xjc(byte[] enw)
	{
		return new Func<List<byte>>(new qsy
		{
			abw = enw,
			abv = "Jslthxvkss"
		}.uwv)().ToArray() ?? null;
	}
}
