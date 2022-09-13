using System.Collections.Generic;
using System.Net;
using System.Text;

public class DiscordWebhook
{
	public static class FormUpload
	{
		public class FileParameter
		{
			public extern byte[] File { get; set; }

			public extern string FileName { get; set; }

			public extern string ContentType { get; set; }

			public extern FileParameter(byte[] file);

			public extern FileParameter(byte[] file, string filename);

			public extern FileParameter(byte[] file, string filename, string contenttype);
		}

		private static readonly Encoding encoding;

		public static extern HttpWebResponse MultipartFormDataPost(string postUrl, string userAgent, Dictionary<string, object> postParameters);

		private static extern HttpWebResponse PostForm(string postUrl, string userAgent, string contentType, byte[] formData);

		private static extern byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary);
	}

	private static string defaultWebhook;

	private static string defaultUserAgent;

	private static string defaultUserName;

	private static string defaultAvatar;

	public static extern void SendTestWebhook();

	public static extern string Send(string mssgBody);

	public static extern string Send(string mssgBody, string userName);

	public static extern string Send(string mssgBody, string userName, string webhook);

	public static extern string SendFile(string mssgBody, string filename, string fileformat, string filepath, string application);

	public static extern string SendFile(string mssgBody, string filename, string fileformat, string filepath, string application, string userName);

	public static extern string SendFile(string mssgBody, string filename, string fileformat, string filepath, string application, string userName, string webhook);

	public extern DiscordWebhook();
}
