using System;
using System.Web.Services;
using System.Web.Services.Protocols;
using eC98jAqdnPLlDITmK6;
using efj3Zs3NfkVQ52e6FtC;
using etKNQTu9kgqwCqmIAv;

namespace eEE0sjI4GGwwj1C248V;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal class eugpB2ICX7B27crxYe4 : SoapHttpClientProtocol
{
	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk eulODlten;

	public eugpB2ICX7B27crxYe4()
	{
		_ = 1;
		if (!enAonPfZgOc7AImepqx())
		{
			eOMV8afgVVbAZjJsHon(this);
			eoq3iifilUwJX97m8gw(this, eMF4Gef2ASgUYNLfoB4(euAC07IzsB8OZ8VCedc.eeN1kpseb, eulODlten(25418)));
		}
		eRvSNufEpQpHf4qNJX7(this, 30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((object[])eQJ2AgfYkeaBV56D1qj(this, eulODlten(25451), new object[1] { licenseID }))[0];
	}

	static eugpB2ICX7B27crxYe4()
	{
		eaplxrfoDg304WGQWGu(eUJFEEfflWvYvc6BUcO(typeof(eugpB2ICX7B27crxYe4).TypeHandle));
	}

	internal static void eOMV8afgVVbAZjJsHon(object object_0)
	{
		((SoapHttpClientProtocol)object_0)._002Ector();
	}

	internal static object eMF4Gef2ASgUYNLfoB4(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static void eoq3iifilUwJX97m8gw(object object_0, object object_1)
	{
		((WebClientProtocol)object_0).set_Url((string)object_1);
	}

	internal static void eRvSNufEpQpHf4qNJX7(object object_0, int int_0)
	{
		((WebClientProtocol)object_0).set_Timeout(int_0);
	}

	internal static bool eJrNunfCtb8UsYyr7lh()
	{
		return true;
	}

	internal static bool enAonPfZgOc7AImepqx()
	{
		return false;
	}

	internal static object eQJ2AgfYkeaBV56D1qj(object object_0, object object_1, object object_2)
	{
		return ((SoapHttpClientProtocol)object_0).Invoke((string)object_1, (object[])object_2);
	}

	internal static Type eUJFEEfflWvYvc6BUcO(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void eaplxrfoDg304WGQWGu(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
