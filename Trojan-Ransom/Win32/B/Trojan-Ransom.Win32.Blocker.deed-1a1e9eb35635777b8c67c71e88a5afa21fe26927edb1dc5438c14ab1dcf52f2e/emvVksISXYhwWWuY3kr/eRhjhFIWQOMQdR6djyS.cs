using System;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using eC98jAqdnPLlDITmK6;
using etKNQTu9kgqwCqmIAv;

namespace emvVksISXYhwWWuY3kr;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal class eRhjhFIWQOMQdR6djyS : SoapHttpClientProtocol
{
	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk eulODlten;

	public eRhjhFIWQOMQdR6djyS(string string_0)
	{
		eJuIyPfdkjNEpXfe13r(this);
		esYrfbfX234taahIC89();
		if (!eRjgYVf69h1xTuNbeiP())
		{
			eCDFBAfyi0s3chy516D(this, eIpVEsfa6CskuFl1dNc(string_0, eulODlten(25469)));
		}
		eXQRdbfMclHSax7J1Na(this, 180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((object[])eIUpl8fu2otZ6pe4IRN(this, eulODlten(25490), new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber }))[0];
	}

	static eRhjhFIWQOMQdR6djyS()
	{
		eDyavNfSffBpC5jDUlq(el4tkufbwSJ3WVnuwQL(typeof(eRhjhFIWQOMQdR6djyS).TypeHandle));
	}

	internal static void eJuIyPfdkjNEpXfe13r(object object_0)
	{
		((SoapHttpClientProtocol)object_0)._002Ector();
	}

	internal static object eIpVEsfa6CskuFl1dNc(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static void eCDFBAfyi0s3chy516D(object object_0, object object_1)
	{
		((WebClientProtocol)object_0).set_Url((string)object_1);
	}

	internal static void eXQRdbfMclHSax7J1Na(object object_0, int int_0)
	{
		((WebClientProtocol)object_0).set_Timeout(int_0);
	}

	internal static bool esYrfbfX234taahIC89()
	{
		return true;
	}

	internal static bool eRjgYVf69h1xTuNbeiP()
	{
		return false;
	}

	internal static object eIUpl8fu2otZ6pe4IRN(object object_0, object object_1, object object_2)
	{
		return ((SoapHttpClientProtocol)object_0).Invoke((string)object_1, (object[])object_2);
	}

	internal static Type el4tkufbwSJ3WVnuwQL(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void eDyavNfSffBpC5jDUlq(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
