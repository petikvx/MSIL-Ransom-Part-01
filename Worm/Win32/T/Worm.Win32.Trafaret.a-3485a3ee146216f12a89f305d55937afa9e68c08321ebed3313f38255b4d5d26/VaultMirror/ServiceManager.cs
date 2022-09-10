using System;
using System.Web.Services.Protocols;
using VaultMirror.Document;
using VaultMirror.Security;

namespace VaultMirror;

public class ServiceManager
{
	private static ServiceManager mgr;

	private SecurityService secSvc;

	private DocumentServiceWse docSvc;

	private string server;

	private ServiceManager()
	{
	}

	public static ServiceManager GetServiceManager()
	{
		if (mgr == null)
		{
			mgr = new ServiceManager();
		}
		return mgr;
	}

	public SecurityService CreateSecurityService(string username, string password, string server, string database)
	{
		if (secSvc == null)
		{
			this.server = server;
			secSvc = new SecurityService();
			SetSvcUrl((SoapHttpClientProtocol)(object)secSvc);
			secSvc.SecurityHeaderValue = new VaultMirror.Security.SecurityHeader();
			secSvc.SignIn(username, password, database);
		}
		return secSvc;
	}

	public static DocumentServiceWse GetDocumentService()
	{
		ServiceManager serviceManager = GetServiceManager();
		if (serviceManager.docSvc == null)
		{
			serviceManager.docSvc = new DocumentServiceWse();
			serviceManager.docSvc.Url = serviceManager.SetSvcUrl((SoapHttpClientProtocol)(object)serviceManager.docSvc);
			serviceManager.docSvc.SecurityHeaderValue = new VaultMirror.Document.SecurityHeader();
			serviceManager.docSvc.SecurityHeaderValue.Ticket = serviceManager.secSvc.SecurityHeaderValue.Ticket;
			serviceManager.docSvc.SecurityHeaderValue.UserId = serviceManager.secSvc.SecurityHeaderValue.UserId;
		}
		return serviceManager.docSvc;
	}

	public static void LogOut()
	{
		ServiceManager serviceManager = GetServiceManager();
		serviceManager.secSvc = null;
		serviceManager.docSvc = null;
	}

	private string SetSvcUrl(SoapHttpClientProtocol svc)
	{
		UriBuilder uriBuilder = new UriBuilder(((WebClientProtocol)svc).get_Url());
		string text = "https://";
		string text2 = server;
		try
		{
			if (text2.StartsWith(text))
			{
				uriBuilder.Scheme = text;
				text2 = text2.Remove(0, text.Length);
			}
			int num = text2.IndexOf(":");
			if (num > 0)
			{
				uriBuilder.Host = text2.Substring(0, num);
				uriBuilder.Port = int.Parse(text2.Substring(num + 1));
			}
			else
			{
				uriBuilder.Host = text2;
			}
			((WebClientProtocol)svc).set_Url(uriBuilder.Uri.ToString());
		}
		catch
		{
		}
		return ((WebClientProtocol)svc).get_Url();
	}
}
