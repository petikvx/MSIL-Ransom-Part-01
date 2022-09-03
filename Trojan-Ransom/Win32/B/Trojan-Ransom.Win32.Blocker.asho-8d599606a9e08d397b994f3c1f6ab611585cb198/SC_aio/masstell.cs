using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SC_aio.My;

namespace SC_aio;

[DesignerGenerated]
public class masstell : Form
{
	private IContainer components;

	[AccessedThroughProperty("emailbox")]
	private TextBox _emailbox;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("status")]
	private Label _status;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private List<string> emails;

	private int current;

	private bool finish;

	private int threads;

	private CookieContainer logincookie2;

	private string domain2;

	internal virtual TextBox emailbox
	{
		get
		{
			return _emailbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_emailbox = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label status
	{
		get
		{
			return _status;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_status = value;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	public masstell()
	{
		((Form)this).add_Load((EventHandler)masstell_Load);
		emails = new List<string>();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		components = new Container();
		emailbox = new TextBox();
		ProgressBar1 = new ProgressBar();
		Button1 = new Button();
		status = new Label();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		TextBox obj = emailbox;
		Point location = new Point(12, 12);
		((Control)obj).set_Location(location);
		((TextBoxBase)emailbox).set_MaxLength(999999999);
		emailbox.set_Multiline(true);
		((Control)emailbox).set_Name("emailbox");
		TextBox obj2 = emailbox;
		Size size = new Size(260, 202);
		((Control)obj2).set_Size(size);
		((Control)emailbox).set_TabIndex(0);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(12, 218);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(260, 21);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(1);
		Button button = Button1;
		location = new Point(12, 263);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(260, 29);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Begin");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label obj3 = status;
		location = new Point(9, 239);
		((Control)obj3).set_Location(location);
		((Control)status).set_Name("status");
		Label obj4 = status;
		size = new Size(260, 23);
		((Control)obj4).set_Size(size);
		((Control)status).set_TabIndex(3);
		status.set_Text("Enter emails into top box one per line, then begin!");
		status.set_TextAlign((ContentAlignment)32);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 299);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)status);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)emailbox);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("masstell");
		((Form)this).set_Text("ShiftCode - Mass Tell");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public object sendPost2(string url, string postData)
	{
		try
		{
			CookieContainer cookieContainer = new CookieContainer();
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			byte[] bytes = uTF8Encoding.GetBytes(postData);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.Method = "POST";
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Timeout = 30000;
			httpWebRequest.CookieContainer = logincookie2;
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.Referer = "";
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 7.1; ru; rv:1.9.2.3) Gecko/20100801 Firefox/12.0 (.NET CLR 3.5.30729)";
			httpWebRequest.ContentLength = bytes.Length;
			httpWebRequest.CookieContainer = logincookie2;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			cookieContainer.Add(httpWebResponse.Cookies);
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			return streamReader.ReadToEnd();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "";
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string[] array = emailbox.get_Text().Split(new char[1] { '\r' });
		string[] array2 = array;
		foreach (string item in array2)
		{
			emails.Add(item);
		}
		ProgressBar1.set_Maximum(emails.Count);
		createThread(new Thread((ThreadStart)delegate
		{
			startthreads(domain2);
		}));
		Timer1.Start();
	}

	public void createThread(Thread thread)
	{
		thread.Start();
	}

	private void sendemailbulk(string ur, string postdata)
	{
		try
		{
			sendPost2("http://" + domain2 + "/members/tell.php?send", postdata);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		checked
		{
			threads--;
			Thread.EndThreadAffinity();
		}
	}

	private void startthreads(string doma)
	{
		_Closure_0024__1 other = default(_Closure_0024__1);
		_Closure_0024__1 CS_0024_003C_003E8__locals0 = new _Closure_0024__1(other);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_doma = doma;
		CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
		checked
		{
			while (true)
			{
				int num = 1;
				if (threads < 5)
				{
					int num2 = 0;
					CS_0024_003C_003E8__locals0._0024VB_0024Local_postdata = "name=" + MyProject.Forms.aio.randSelect(MyProject.Forms.aio.firstnames) + " " + MyProject.Forms.aio.randSelect(MyProject.Forms.aio.lastnames) + "&email=" + MyProject.Forms.aio.randSelect(MyProject.Forms.aio.firstnames) + MyProject.Forms.aio.rand.Next(0, 99999) + "@gmail.com";
					while (num2 != 5)
					{
						num2++;
						string text;
						try
						{
							text = emails[current];
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex, num);
							text = "emaildone";
							ProjectData.ClearProjectError();
						}
						if (Operators.CompareString(text, "emaildone", false) != 0)
						{
							current++;
							string[] array = text.Split(new char[1] { '@' });
							string text2 = array[0];
							CS_0024_003C_003E8__locals0._0024VB_0024Local_postdata = CS_0024_003C_003E8__locals0._0024VB_0024Local_postdata + "&name" + num2 + "=" + text2 + "&email" + num2 + "=" + text;
						}
					}
					createThread(new Thread((ThreadStart)delegate
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Me.sendemailbulk(CS_0024_003C_003E8__locals0._0024VB_0024Local_doma, CS_0024_003C_003E8__locals0._0024VB_0024Local_postdata);
					}));
					threads++;
					if (current > emails.Count - 1)
					{
						return;
					}
					if (finish)
					{
						break;
					}
				}
				else
				{
					Thread.Sleep(100);
				}
			}
			Thread.EndThreadAffinity();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 276:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_001f;
						case 4:
							goto IL_0029;
						case 5:
							goto IL_0037;
						case 6:
							goto IL_007a;
						case 7:
						case 8:
							goto IL_008a;
						case 9:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 10:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_008a:
					num = 8;
					status.set_Text("Done " + current + "/" + emails.Count);
					break;
					IL_0007:
					num = 2;
					if (current >= checked(emails.Count - 1))
					{
						goto IL_001f;
					}
					goto IL_008a;
					IL_001f:
					num = 3;
					finish = true;
					goto IL_0029;
					IL_0029:
					num = 4;
					Timer1.Stop();
					goto IL_0037;
					IL_0037:
					num = 5;
					status.set_Text("Sent all emails " + emails.Count + "/" + emails.Count);
					goto IL_007a;
					IL_007a:
					num = 6;
					ProgressBar1.set_Value(100);
					goto IL_008a;
					end_IL_0000_2:
					break;
				}
				num = 9;
				ProgressBar1.set_Value(current);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 276;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void masstell_Load(object sender, EventArgs e)
	{
		logincookie2 = MyProject.Forms.aio.logincookie;
		domain2 = MyProject.Forms.aio.domain;
	}
}
