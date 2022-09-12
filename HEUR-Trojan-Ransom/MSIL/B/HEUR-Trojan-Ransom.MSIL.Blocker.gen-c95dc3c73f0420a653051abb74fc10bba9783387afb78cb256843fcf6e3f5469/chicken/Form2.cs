using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace chicken;

public class Form2 : Form
{
	private WebClient PezHxFGGFTZxCWlbhZCNJHrwOPkl;

	public static string webString;

	private static byte[] YzBRIVUxaJVmjEDtROkGJXZIcLMW = Encoding.ASCII.GetBytes("8@#$%%7&");

	public static string userurl = "ZlyuRf19L4Axge6dTiRBuLxzz0MgaULigxYCxwEeD60=";

	public static string urlString = "https://shout-tese.blogspot.com/";

	private IContainer kIRxdvplOwoJsmagcKCtTAqXYlCQ;

	private ProgressBar PHKYSLFBxGulbMCVDILeYyvdcUAT;

	private PictureBox UpesJsowGRHAcNfGaCDBJLBwXvYf;

	public Form2()
	{
		tSSxvWKRPTkncrJVVkMRgnrXomxK();
		PezHxFGGFTZxCWlbhZCNJHrwOPkl = new WebClient();
		PezHxFGGFTZxCWlbhZCNJHrwOPkl.Encoding = Encoding.GetEncoding("UTF-8");
		webString = PezHxFGGFTZxCWlbhZCNJHrwOPkl.DownloadString(urlString);
		uXxiYuWSXrMdUhXBaCmJKIhszeyy();
	}

	private string ExrUtrGIrVegUboRfrYDiddupjgeA(string type)
	{
		return webString.Replace(" ", "").Split(new string[1] { type + "]" }, StringSplitOptions.RemoveEmptyEntries)[1].Replace("[/", "").Split(new string[1] { "[/image]" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	private void uXxiYuWSXrMdUhXBaCmJKIhszeyy()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		PezHxFGGFTZxCWlbhZCNJHrwOPkl.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.3; WOW64; Trident/7.0)");
		string fileName = string.Format("MrImage.gif", Path.GetFileName(ExrUtrGIrVegUboRfrYDiddupjgeA("image")));
		try
		{
			PezHxFGGFTZxCWlbhZCNJHrwOPkl.DownloadProgressChanged += apDruiWCkiCzqfcmyHWwfuhGSBOAb;
			PezHxFGGFTZxCWlbhZCNJHrwOPkl.DownloadFileCompleted += JSVMtZxdjpmsJOhHYWPYODoKNgjF;
			PezHxFGGFTZxCWlbhZCNJHrwOPkl.DownloadFileAsync(new Uri(ExrUtrGIrVegUboRfrYDiddupjgeA("image")), fileName);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Failed to load main image. error : " + ex.Message, " Message");
		}
	}

	private void JSVMtZxdjpmsJOhHYWPYODoKNgjF(object sender, AsyncCompletedEventArgs e)
	{
		Thread.Sleep(1000);
		((Control)this).Hide();
		Form1 form = new Form1();
		((Form)form).set_Owner((Form)(object)this);
		((Control)form).Show();
	}

	private void apDruiWCkiCzqfcmyHWwfuhGSBOAb(object sender, DownloadProgressChangedEventArgs e)
	{
		PHKYSLFBxGulbMCVDILeYyvdcUAT.set_Value(e.ProgressPercentage);
	}

	public static string Decrypt(string strKey)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		dESCryptoServiceProvider.Mode = CipherMode.ECB;
		dESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		dESCryptoServiceProvider.Key = YzBRIVUxaJVmjEDtROkGJXZIcLMW;
		dESCryptoServiceProvider.IV = YzBRIVUxaJVmjEDtROkGJXZIcLMW;
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write);
		strKey = strKey.Replace(" ", "+");
		byte[] array = Convert.FromBase64String(strKey);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.FlushFinalBlock();
		return Encoding.UTF8.GetString(memoryStream.GetBuffer()).Replace("\0", "");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && kIRxdvplOwoJsmagcKCtTAqXYlCQ != null)
		{
			kIRxdvplOwoJsmagcKCtTAqXYlCQ.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void tSSxvWKRPTkncrJVVkMRgnrXomxK()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		PHKYSLFBxGulbMCVDILeYyvdcUAT = new ProgressBar();
		UpesJsowGRHAcNfGaCDBJLBwXvYf = new PictureBox();
		((ISupportInitialize)UpesJsowGRHAcNfGaCDBJLBwXvYf).BeginInit();
		((Control)this).SuspendLayout();
		((Control)PHKYSLFBxGulbMCVDILeYyvdcUAT).set_BackColor(Color.LightGray);
		((Control)PHKYSLFBxGulbMCVDILeYyvdcUAT).set_Location(new Point(0, 153));
		((Control)PHKYSLFBxGulbMCVDILeYyvdcUAT).set_Name("progressBar1");
		((Control)PHKYSLFBxGulbMCVDILeYyvdcUAT).set_Size(new Size(167, 10));
		((Control)PHKYSLFBxGulbMCVDILeYyvdcUAT).set_TabIndex(1);
		((Control)UpesJsowGRHAcNfGaCDBJLBwXvYf).set_BackColor(Color.Transparent);
		((Control)UpesJsowGRHAcNfGaCDBJLBwXvYf).set_BackgroundImageLayout((ImageLayout)0);
		UpesJsowGRHAcNfGaCDBJLBwXvYf.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)UpesJsowGRHAcNfGaCDBJLBwXvYf).set_Location(new Point(0, 0));
		((Control)UpesJsowGRHAcNfGaCDBJLBwXvYf).set_Name("pictureBox1");
		((Control)UpesJsowGRHAcNfGaCDBJLBwXvYf).set_Size(new Size(167, 154));
		UpesJsowGRHAcNfGaCDBJLBwXvYf.set_TabIndex(2);
		UpesJsowGRHAcNfGaCDBJLBwXvYf.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Control)this).set_BackColor(SystemColors.ActiveBorder);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(167, 163));
		((Control)this).get_Controls().Add((Control)(object)UpesJsowGRHAcNfGaCDBJLBwXvYf);
		((Control)this).get_Controls().Add((Control)(object)PHKYSLFBxGulbMCVDILeYyvdcUAT);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form2");
		((Form)this).set_TransparencyKey(SystemColors.ActiveBorder);
		((ISupportInitialize)UpesJsowGRHAcNfGaCDBJLBwXvYf).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
