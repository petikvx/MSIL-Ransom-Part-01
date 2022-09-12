using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace testCurl;

public class Form1 : Form
{
	private void proses_Click(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		string text = "";
		string text2 = "";
		StringWriter stringWriter = new StringWriter(new StringBuilder());
		JsonWriter val = (JsonWriter)new JsonTextWriter((TextWriter)stringWriter);
		try
		{
			val.set_Formatting((Formatting)1);
			val.WriteStartObject();
			val.WritePropertyName("action");
			val.WriteValue("login");
			val.WritePropertyName("data");
			val.WriteStartObject();
			val.WritePropertyName("username");
			val.WriteValue(text);
			val.WritePropertyName("password");
			val.WriteValue(text2);
			val.WriteEnd();
			val.WriteEndObject();
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		kirim(stringWriter.ToString());
	}

	private void kirim(string data)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri("http://localhost/api/test_terima.php"));
		ServicePointManager.ServerCertificateValidationCallback = (object _003Cp0_003E, X509Certificate _003Cp1_003E, X509Chain _003Cp2_003E, SslPolicyErrors _003Cp3_003E) => true;
		httpWebRequest.Method = "post";
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		string text = null;
		try
		{
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				using StreamWriter streamWriter = new StreamWriter(stream);
				streamWriter.Write("query=" + data);
			}
			using (HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse)
			{
				Console.WriteLine();
				text = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8).ReadToEnd();
			}
			MessageBox.Show(text);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Error : " + ex.Message);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}
}
