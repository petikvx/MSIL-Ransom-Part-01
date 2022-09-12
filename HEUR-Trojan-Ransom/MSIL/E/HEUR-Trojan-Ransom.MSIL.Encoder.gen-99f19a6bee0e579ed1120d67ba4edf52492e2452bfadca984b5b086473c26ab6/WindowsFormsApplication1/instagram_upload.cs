#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Logger;
using MetroFramework.Controls;

namespace WindowsFormsApplication1;

internal class instagram_upload
{
	private string username_OR_email = "";

	private string password = "";

	private string csrfToken = "";

	private string sessionId = "";

	private string userId = "";

	private string strName = "";

	private string email = "";

	private Form1 pm_form;

	private const string AppName = "Challenge Required";

	private string StateFile = "state.bin";

	private readonly Size NormalSize = new Size(432, 164);

	private readonly Size ChallengeSize = new Size(432, 604);

	private static IInstaApi InstaApi;

	public static bool instagram_loign = false;

	private CookieContainer ck = new CookieContainer();

	public string text_between
	{
		get
		{
			string text2 = "";
			text2 = text.Substring(text.IndexOf(start_keyword) + 2 + start_keyword.Length, text.Length - (text.IndexOf(start_keyword) + 2 + start_keyword.Length));
			return text2.Substring(0, text2.IndexOf(end_keyword)).TrimEnd(new char[0]).TrimStart(new char[0]);
		}
	}

	public void instagram_uploader()
	{
		pm_form = Form1.mainform;
		username_OR_email = ((Control)Form1.insta_posh_class.instagram_username_textBox2).get_Text();
		password = ((Control)Form1.insta_posh_class.instagram_password_textBox3).get_Text();
	}

	public async Task instagram_picture_uploader(Form1 pm_form, List<extract_data.Listng_data> Listings_data)
	{
		if (InstaApi == null)
		{
			MessageBox.Show("Login first.");
			return;
		}
		if (!InstaApi.IsUserAuthenticated)
		{
			MessageBox.Show("Login first.");
			return;
		}
		MethodInvoker val = default(MethodInvoker);
		foreach (extract_data.Listng_data r in Listings_data)
		{
			string listing_captionsn = r.title + "\r\n" + r.price + "\r\n" + r.description + "\r\n";
			string Listing_image_path = r.image_link;
			((Control)pm_form.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
			{
				pm_form.status_textBox1.AppendText("Going for " + r.title + " Upload\r\n");
			});
			InstaImageUpload mediaImage = new InstaImageUpload
			{
				Height = 1056,
				Width = 816,
				Uri = Listing_image_path
			};
			if (!(await InstaApi.MediaProcessor.UploadPhotoAsync(mediaImage, listing_captionsn)).Succeeded)
			{
				continue;
			}
			((Control)pm_form.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
			{
				pm_form.status_textBox1.AppendText("Upoaded " + r.title + "\r\n");
			});
			MetroTextBox status_textBox = pm_form.status_textBox1;
			MethodInvoker obj = val;
			if (obj == null)
			{
				MethodInvoker val2 = delegate
				{
					pm_form.status_textBox1.AppendText("App in Sleep for 2 minute\r\n");
				};
				MethodInvoker val3 = val2;
				val = val2;
				obj = val3;
			}
			((Control)status_textBox).Invoke((Delegate)(object)obj);
			Thread.Sleep(60000);
		}
		((Control)pm_form.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((Control)pm_form.status_textBox1).set_Text("Instagram Upload is completed\r\n");
		});
		MetroButton instagram_image_upload_button = Form1.insta_posh_class.instagram_image_upload_button1;
		object obj2 = _003C_003Ec._003C_003E9__14_4;
		if (obj2 == null)
		{
			MethodInvoker val4 = delegate
			{
				((Control)Form1.insta_posh_class.instagram_image_upload_button1).set_Enabled(true);
			};
			obj2 = (object)val4;
			_003C_003Ec._003C_003E9__14_4 = val4;
		}
		((Control)instagram_image_upload_button).Invoke((Delegate)obj2);
		try
		{
			foreach (string file in Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.png"))
			{
				if (file.Contains("images"))
				{
					File.Delete(file);
				}
			}
		}
		catch
		{
		}
	}

	private void SaveSession()
	{
		if (InstaApi != null && InstaApi.IsUserAuthenticated)
		{
			Stream stateDataAsStream = InstaApi.GetStateDataAsStream();
			using FileStream destination = File.Create(StateFile);
			stateDataAsStream.Seek(0L, SeekOrigin.Begin);
			stateDataAsStream.CopyTo(destination);
		}
	}

	public async Task initialize_and_login()
	{
		try
		{
			foreach (string file in Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.png"))
			{
				if (file.Contains("images"))
				{
					File.Delete(file);
				}
			}
		}
		catch
		{
		}
		TimeSpan span = new TimeSpan(0, 1, 0);
		InstaApi.SetTimeout(span);
		UserSessionData userSession = new UserSessionData
		{
			UserName = username_OR_email,
			Password = password
		};
		InstaApi = InstaApiBuilder.CreateBuilder().SetUser(userSession).UseLogger(new DebugLogger(LogLevel.All))
			.SetRequestDelay(RequestDelay.FromSeconds(0, 1))
			.Build();
		if (InstaApi.IsUserAuthenticated)
		{
			return;
		}
		IResult<InstaLoginResult> logInResult = await InstaApi.LoginAsync();
		Debug.WriteLine(logInResult.Value);
		if (logInResult.Succeeded)
		{
			instagram_loign = true;
			return;
		}
		instagram_loign = false;
		if (logInResult.Value == InstaLoginResult.ChallengeRequired)
		{
			IResult<InstaChallengeRequireVerifyMethod> challenge = await InstaApi.GetChallengeRequireVerifyMethodAsync();
			if (challenge.Succeeded)
			{
				MetroTextBox status_textBox = Form1.mainform.status_textBox1;
				object obj2 = _003C_003Ec._003C_003E9__17_0;
				if (obj2 == null)
				{
					MethodInvoker val = delegate
					{
						Form1.mainform.status_textBox1.AppendText("Cannot be able to login to Instagram please try to login your instagram on any browser and check if any verification is required\r\n");
					};
					obj2 = (object)val;
					_003C_003Ec._003C_003E9__17_0 = val;
				}
				((Control)status_textBox).Invoke((Delegate)obj2);
			}
			else
			{
				MessageBox.Show(challenge.Info.Message, "ERR", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
		else if (logInResult.Value == InstaLoginResult.TwoFactorRequired)
		{
		}
	}

	private bool Request_www_instagram_com_login(out HttpWebResponse response, string csr)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.instagram.com/accounts/login/ajax/");
			httpWebRequest.Headers.Add("Origin", "https://www.instagram.com");
			httpWebRequest.Headers.Add("X-Instagram-AJAX", "79d0a43d9853");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.94 Safari/537.36";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
			httpWebRequest.Accept = "*/*";
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.Headers.Add("X-CSRFToken", csr);
			httpWebRequest.Referer = "https://www.instagram.com/";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8");
			httpWebRequest.CookieContainer = ck;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			string s = "username=" + username_OR_email + "&password=" + password + "&queryParams=%7B%22source%22%3A%22auth_switcher%22%7D&optIntoOneTap=true";
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	private bool Request_www_instagram_com_ajax_bz(out HttpWebResponse response, string token)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.instagram.com/ajax/bz");
			httpWebRequest.Headers.Add("Origin", "https://www.instagram.com");
			httpWebRequest.Headers.Add("X-Instagram-AJAX", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.94 Safari/537.36";
			httpWebRequest.ContentType = "application/json; charset=UTF-8";
			httpWebRequest.Accept = "application/json, text/javascript, */*; q=0.01";
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.Headers.Add("X-CSRFToken", token);
			httpWebRequest.Referer = "https://www.instagram.com/";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8");
			httpWebRequest.CookieContainer = ck;
			httpWebRequest.Method = "POST";
			httpWebRequest.ServicePoint.Expect100Continue = false;
			string s = "{\"q\":[{\"page_id\":\"8750k1\",\"posts\":[[\"qe:expose\",{\"qe\":\"wo\"},1462875525383,0],[\"slipstream:pageview\",{\"description\":\"unifiedHome\",\"event_name\":\"pageview\",\"platform\":\"web\",\"extra\":\"{\\\"gk\\\":{}}\",\"hostname\":\"www.instagram.com\",\"path\":\"/\",\"referer\":\"\",\"url\":\"https://www.instagram.com/\"},1462875525456,0],[\"slipstream:action\",{\"description\":\"fbLoginFallback\",\"event_name\":\"action\",\"extra\":\"{\\\"gk\\\":{},\\\"type\\\":\\\"signup\\\"}\",\"hostname\":\"www.instagram.com\",\"path\":\"/\",\"referer\":\"\",\"url\":\"https://www.instagram.com/\"},1462875530378,0]],\"trigger\":\"qe:expose\"}],\"ts\":1462875530481}";
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	private string ReadResponse(HttpWebResponse response)
	{
		using Stream stream = response.GetResponseStream();
		Stream stream2 = stream;
		if (response.ContentEncoding.ToLower().Contains("gzip"))
		{
			stream2 = new GZipStream(stream2, CompressionMode.Decompress);
		}
		else if (response.ContentEncoding.ToLower().Contains("deflate"))
		{
			stream2 = new DeflateStream(stream2, CompressionMode.Decompress);
		}
		using StreamReader streamReader = new StreamReader(stream2, Encoding.UTF8);
		return streamReader.ReadToEnd();
	}

	private bool GetEditData(out HttpWebResponse response)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.instagram.com/accounts/edit/");
			httpWebRequest.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0");
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, sdch, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8,ur;q=0.6,tr;q=0.4");
			httpWebRequest.CookieContainer = ck;
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	private bool Request_www_instagram_com_firstpage(out HttpWebResponse response)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.instagram.com/");
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, sdch, br");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.8");
			httpWebRequest.CookieContainer = ck;
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}
}
