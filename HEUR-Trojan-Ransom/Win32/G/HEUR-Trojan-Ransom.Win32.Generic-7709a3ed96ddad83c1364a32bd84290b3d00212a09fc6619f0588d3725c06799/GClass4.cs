using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml;

public sealed class GClass4
{
	private static string string_0;

	public static bool smethod_0()
	{
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
		socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
		socket.ReceiveTimeout = 3000;
		string s = "M-SEARCH * HTTP/1.1\r\nHOST: 239.255.255.250:1900\r\nST:upnp:rootdevice\r\nMAN:\"ssdp:discover\"\r\nMX:3\r\n\r\n";
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		IPEndPoint remoteEP = new IPEndPoint(IPAddress.Broadcast, 1900);
		byte[] array = new byte[4096];
		try
		{
			socket.SendTo(bytes, remoteEP);
			int num = 0;
			do
			{
				num = socket.Receive(array);
				string text = Encoding.ASCII.GetString(array, 0, num).ToLower();
				if (text.Contains("upnp:rootdevice"))
				{
					text = text.Substring(text.ToLower().IndexOf("location:") + 9);
					text = text.Substring(0, text.IndexOf("\r")).Trim();
					if (!string.IsNullOrEmpty(string_0 = smethod_1(text)))
					{
						socket.Close();
						return true;
					}
				}
			}
			while (num > 0);
			socket.Close();
			return false;
		}
		catch
		{
			socket.Close();
			return false;
		}
	}

	private static string smethod_1(string string_1)
	{
		XmlDocument xmlDocument = new XmlDocument();
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_1);
		httpWebRequest.KeepAlive = false;
		using WebResponse webResponse = httpWebRequest.GetResponse();
		using Stream inStream = webResponse.GetResponseStream();
		xmlDocument.Load(inStream);
		XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
		xmlNamespaceManager.AddNamespace("tns", "urn:schemas-upnp-org:device-1-0");
		XmlNode xmlNode = xmlDocument.SelectSingleNode("//tns:device/tns:deviceType/text()", xmlNamespaceManager);
		if (!xmlNode.Value!.Contains("InternetGatewayDevice"))
		{
			return null;
		}
		XmlNode xmlNode2 = xmlDocument.SelectSingleNode("//tns:service[tns:serviceType=\"urn:schemas-upnp-org:service:WANIPConnection:1\"]/tns:controlURL/text()", xmlNamespaceManager);
		if (xmlNode2 == null)
		{
			return null;
		}
		Uri baseUri = new Uri(string_1);
		Uri uri = new Uri(baseUri, xmlNode2.Value);
		return uri.AbsoluteUri;
	}

	public static bool smethod_2(int int_0, ProtocolType protocolType_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new Exception("No UPnP service available or Discover() has not been called");
		}
		string string_2 = string.Format("<u:AddPortMapping xmlns:u=\"urn:schemas-upnp-org:service:WANIPConnection:1\"><NewRemoteHost></NewRemoteHost><NewExternalPort>{0}</NewExternalPort><NewProtocol>{1}</NewProtocol><NewInternalPort>{0}</NewInternalPort><NewInternalClient>{2}</NewInternalClient><NewEnabled>1</NewEnabled><NewPortMappingDescription>{3}</NewPortMappingDescription><NewLeaseDuration>0</NewLeaseDuration></u:AddPortMapping>", int_0, protocolType_0.ToString().ToUpper(), Dns.GetHostAddresses(Dns.GetHostName())[0], string_1);
		if (smethod_5(string_0, string_2, "AddPortMapping") != null)
		{
			return true;
		}
		return false;
	}

	public static bool smethod_3(int int_0, ProtocolType protocolType_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new Exception("No UPnP service available or Discover() has not been called");
		}
		string string_ = $"<u:DeletePortMapping xmlns:u=\"urn:schemas-upnp-org:service:WANIPConnection:1\"><NewRemoteHost></NewRemoteHost><NewExternalPort>{int_0}</NewExternalPort><NewProtocol>{protocolType_0.ToString().ToUpper()}</NewProtocol></u:DeletePortMapping>";
		if (smethod_5(string_0, string_, "DeletePortMapping") != null)
		{
			return true;
		}
		return false;
	}

	public static IPAddress smethod_4()
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new Exception("No UPnP service available or Discover() has not been called");
		}
		XmlDocument xmlDocument = smethod_5(string_0, "<u:GetExternalIPAddress xmlns:u=\"urn:schemas-upnp-org:service:WANIPConnection:1\"></u:GetExternalIPAddress>", "GetExternalIPAddress");
		XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
		xmlNamespaceManager.AddNamespace("tns", "urn:schemas-upnp-org:device-1-0");
		string value = xmlDocument.SelectSingleNode("//NewExternalIPAddress/text()", xmlNamespaceManager)!.Value;
		return IPAddress.Parse(value);
	}

	private static XmlDocument smethod_5(string string_1, string string_2, string string_3)
	{
		string s = "<?xml version=\"1.0\"?><s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\"><s:Body>" + string_2 + "</s:Body></s:Envelope>";
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_1);
		httpWebRequest.KeepAlive = false;
		httpWebRequest.Method = "POST";
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		httpWebRequest.Headers.Add("SOAPACTION", "\"urn:schemas-upnp-org:service:WANIPConnection:1#" + string_3 + "\"");
		httpWebRequest.ContentType = "text/xml; charset=\"utf-8\"";
		httpWebRequest.ContentLength = bytes.Length;
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		XmlDocument xmlDocument = new XmlDocument();
		using WebResponse webResponse = httpWebRequest.GetResponse();
		using Stream inStream = webResponse.GetResponseStream();
		xmlDocument.Load(inStream);
		return xmlDocument;
	}
}
