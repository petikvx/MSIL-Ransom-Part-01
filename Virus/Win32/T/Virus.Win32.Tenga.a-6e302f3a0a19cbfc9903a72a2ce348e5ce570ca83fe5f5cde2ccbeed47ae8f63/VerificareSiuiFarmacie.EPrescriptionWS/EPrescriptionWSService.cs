using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using VerificareSiuiFarmacie.Properties;

namespace VerificareSiuiFarmacie.EPrescriptionWS;

[WebServiceBinding(Namespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro", Name = "EPrescriptionWSSoapBinding")]
[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
[DesignerCategory("code")]
public class EPrescriptionWSService : SoapHttpClientProtocol
{
	private SendOrPostCallback sendOrPostCallback_0;

	private SendOrPostCallback sendOrPostCallback_1;

	private SendOrPostCallback sendOrPostCallback_2;

	private SendOrPostCallback sendOrPostCallback_3;

	private SendOrPostCallback sendOrPostCallback_4;

	private SendOrPostCallback sendOrPostCallback_5;

	private SendOrPostCallback sendOrPostCallback_6;

	private SendOrPostCallback sendOrPostCallback_7;

	private SendOrPostCallback sendOrPostCallback_8;

	private bool bool_0;

	private X509Certificate2 x509Certificate2_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private processPrescribedPrescriptionCompletedEventHandler processPrescribedPrescriptionCompletedEventHandler_0;

	private processIssuedPrescriptionCompletedEventHandler processIssuedPrescriptionCompletedEventHandler_0;

	private getPrescribedPrescriptionCompletedEventHandler getPrescribedPrescriptionCompletedEventHandler_0;

	private cancelPrescribedPrescriptionCompletedEventHandler cancelPrescribedPrescriptionCompletedEventHandler_0;

	private cancelReleasedPrescriptionCompletedEventHandler cancelReleasedPrescriptionCompletedEventHandler_0;

	private updateInvoicesCompletedEventHandler updateInvoicesCompletedEventHandler_0;

	private getReleasedPrescriptionCompletedEventHandler getReleasedPrescriptionCompletedEventHandler_0;

	private downloadNotReportedPrescriptionsReportCompletedEventHandler downloadNotReportedPrescriptionsReportCompletedEventHandler_0;

	private getStatusForPrescriptionsCompletedEventHandler getStatusForPrescriptionsCompletedEventHandler_0;

	public X509Certificate2 CertificatSSL
	{
		get
		{
			return x509Certificate2_0;
		}
		set
		{
			x509Certificate2_0 = value;
		}
	}

	public string SessionId
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public string WsUserName
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public string WsPassword
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
		}
	}

	public string Url
	{
		get
		{
			return ((WebClientProtocol)this).get_Url();
		}
		set
		{
			if (method_9(((WebClientProtocol)this).get_Url()) && !bool_0 && !method_9(value))
			{
				((WebClientProtocol)this).set_UseDefaultCredentials(false);
			}
			((WebClientProtocol)this).set_Url(value);
		}
	}

	public bool UseDefaultCredentials
	{
		get
		{
			return ((WebClientProtocol)this).get_UseDefaultCredentials();
		}
		set
		{
			((WebClientProtocol)this).set_UseDefaultCredentials(value);
			bool_0 = true;
		}
	}

	public event processPrescribedPrescriptionCompletedEventHandler processPrescribedPrescriptionCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			processPrescribedPrescriptionCompletedEventHandler_0 = (processPrescribedPrescriptionCompletedEventHandler)Delegate.Combine(processPrescribedPrescriptionCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			processPrescribedPrescriptionCompletedEventHandler_0 = (processPrescribedPrescriptionCompletedEventHandler)Delegate.Remove(processPrescribedPrescriptionCompletedEventHandler_0, value);
		}
	}

	public event processIssuedPrescriptionCompletedEventHandler processIssuedPrescriptionCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			processIssuedPrescriptionCompletedEventHandler_0 = (processIssuedPrescriptionCompletedEventHandler)Delegate.Combine(processIssuedPrescriptionCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			processIssuedPrescriptionCompletedEventHandler_0 = (processIssuedPrescriptionCompletedEventHandler)Delegate.Remove(processIssuedPrescriptionCompletedEventHandler_0, value);
		}
	}

	public event getPrescribedPrescriptionCompletedEventHandler getPrescribedPrescriptionCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getPrescribedPrescriptionCompletedEventHandler_0 = (getPrescribedPrescriptionCompletedEventHandler)Delegate.Combine(getPrescribedPrescriptionCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getPrescribedPrescriptionCompletedEventHandler_0 = (getPrescribedPrescriptionCompletedEventHandler)Delegate.Remove(getPrescribedPrescriptionCompletedEventHandler_0, value);
		}
	}

	public event cancelPrescribedPrescriptionCompletedEventHandler cancelPrescribedPrescriptionCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelPrescribedPrescriptionCompletedEventHandler_0 = (cancelPrescribedPrescriptionCompletedEventHandler)Delegate.Combine(cancelPrescribedPrescriptionCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelPrescribedPrescriptionCompletedEventHandler_0 = (cancelPrescribedPrescriptionCompletedEventHandler)Delegate.Remove(cancelPrescribedPrescriptionCompletedEventHandler_0, value);
		}
	}

	public event cancelReleasedPrescriptionCompletedEventHandler cancelReleasedPrescriptionCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelReleasedPrescriptionCompletedEventHandler_0 = (cancelReleasedPrescriptionCompletedEventHandler)Delegate.Combine(cancelReleasedPrescriptionCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelReleasedPrescriptionCompletedEventHandler_0 = (cancelReleasedPrescriptionCompletedEventHandler)Delegate.Remove(cancelReleasedPrescriptionCompletedEventHandler_0, value);
		}
	}

	public event updateInvoicesCompletedEventHandler updateInvoicesCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			updateInvoicesCompletedEventHandler_0 = (updateInvoicesCompletedEventHandler)Delegate.Combine(updateInvoicesCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			updateInvoicesCompletedEventHandler_0 = (updateInvoicesCompletedEventHandler)Delegate.Remove(updateInvoicesCompletedEventHandler_0, value);
		}
	}

	public event getReleasedPrescriptionCompletedEventHandler getReleasedPrescriptionCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getReleasedPrescriptionCompletedEventHandler_0 = (getReleasedPrescriptionCompletedEventHandler)Delegate.Combine(getReleasedPrescriptionCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getReleasedPrescriptionCompletedEventHandler_0 = (getReleasedPrescriptionCompletedEventHandler)Delegate.Remove(getReleasedPrescriptionCompletedEventHandler_0, value);
		}
	}

	public event downloadNotReportedPrescriptionsReportCompletedEventHandler downloadNotReportedPrescriptionsReportCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			downloadNotReportedPrescriptionsReportCompletedEventHandler_0 = (downloadNotReportedPrescriptionsReportCompletedEventHandler)Delegate.Combine(downloadNotReportedPrescriptionsReportCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			downloadNotReportedPrescriptionsReportCompletedEventHandler_0 = (downloadNotReportedPrescriptionsReportCompletedEventHandler)Delegate.Remove(downloadNotReportedPrescriptionsReportCompletedEventHandler_0, value);
		}
	}

	public event getStatusForPrescriptionsCompletedEventHandler getStatusForPrescriptionsCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getStatusForPrescriptionsCompletedEventHandler_0 = (getStatusForPrescriptionsCompletedEventHandler)Delegate.Combine(getStatusForPrescriptionsCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getStatusForPrescriptionsCompletedEventHandler_0 = (getStatusForPrescriptionsCompletedEventHandler)Delegate.Remove(getStatusForPrescriptionsCompletedEventHandler_0, value);
		}
	}

	public EPrescriptionWSService()
	{
		Url = Settings.Default.ServerCNAS_EPrescriptionWS_EPrescriptionWSService;
		if (method_9(Url))
		{
			UseDefaultCredentials = true;
			bool_0 = false;
		}
		else
		{
			bool_0 = true;
		}
	}

	protected override WebRequest GetWebRequest(Uri uri)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)((SoapHttpClientProtocol)this).GetWebRequest(uri);
		httpWebRequest.Headers.Add("OSCP_RESPONSE", string_0);
		CredentialCache credentialCache = new CredentialCache();
		credentialCache.Add(uri, "Basic", new NetworkCredential(string_1, string_2));
		httpWebRequest.Credentials = credentialCache;
		httpWebRequest.ProtocolVersion = HttpVersion.Version10;
		httpWebRequest.KeepAlive = false;
		httpWebRequest.AllowAutoRedirect = false;
		httpWebRequest.PreAuthenticate = true;
		httpWebRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
		httpWebRequest.Proxy = WebRequest.GetSystemWebProxy();
		ServicePointManager.Expect100Continue = false;
		return httpWebRequest;
	}

	public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return true;
	}

	[SoapRpcMethod("", ResponseNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro", RequestNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro")]
	[return: SoapElement("processPrescribedPrescriptionReturn")]
	public string processPrescribedPrescription(string reportXml)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("processPrescribedPrescription", new object[1] { reportXml });
		return (string)array[0];
	}

	public void processPrescribedPrescriptionAsync(string reportXml)
	{
		processPrescribedPrescriptionAsync(reportXml, null);
	}

	public void processPrescribedPrescriptionAsync(string reportXml, object userState)
	{
		if (sendOrPostCallback_0 == null)
		{
			sendOrPostCallback_0 = method_0;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("processPrescribedPrescription", new object[1] { reportXml }, sendOrPostCallback_0, userState);
	}

	private void method_0(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (processPrescribedPrescriptionCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			processPrescribedPrescriptionCompletedEventHandler_0(this, new processPrescribedPrescriptionCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapRpcMethod("", ResponseNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro", RequestNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro")]
	[return: SoapElement("processIssuedPrescriptionReturn")]
	public string processIssuedPrescription(string reportXml)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("processIssuedPrescription", new object[1] { reportXml });
		return (string)array[0];
	}

	public void processIssuedPrescriptionAsync(string reportXml)
	{
		processIssuedPrescriptionAsync(reportXml, null);
	}

	public void processIssuedPrescriptionAsync(string reportXml, object userState)
	{
		if (sendOrPostCallback_1 == null)
		{
			sendOrPostCallback_1 = method_1;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("processIssuedPrescription", new object[1] { reportXml }, sendOrPostCallback_1, userState);
	}

	private void method_1(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (processIssuedPrescriptionCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			processIssuedPrescriptionCompletedEventHandler_0(this, new processIssuedPrescriptionCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapRpcMethod("", ResponseNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro", RequestNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro")]
	[return: SoapElement("getPrescribedPrescriptionReturn")]
	public string getPrescribedPrescription(string providerCode, string physicianStencilNo, string contractNo, string contractType, string insuranceHouseCode, string series, string no, DateTime prescriptionDate)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getPrescribedPrescription", new object[8] { providerCode, physicianStencilNo, contractNo, contractType, insuranceHouseCode, series, no, prescriptionDate });
		return (string)array[0];
	}

	public void getPrescribedPrescriptionAsync(string providerCode, string physicianStencilNo, string contractNo, string contractType, string insuranceHouseCode, string series, string no, DateTime prescriptionDate)
	{
		getPrescribedPrescriptionAsync(providerCode, physicianStencilNo, contractNo, contractType, insuranceHouseCode, series, no, prescriptionDate, null);
	}

	public void getPrescribedPrescriptionAsync(string providerCode, string physicianStencilNo, string contractNo, string contractType, string insuranceHouseCode, string series, string no, DateTime prescriptionDate, object userState)
	{
		if (sendOrPostCallback_2 == null)
		{
			sendOrPostCallback_2 = method_2;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getPrescribedPrescription", new object[8] { providerCode, physicianStencilNo, contractNo, contractType, insuranceHouseCode, series, no, prescriptionDate }, sendOrPostCallback_2, userState);
	}

	private void method_2(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getPrescribedPrescriptionCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getPrescribedPrescriptionCompletedEventHandler_0(this, new getPrescribedPrescriptionCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapRpcMethod("", ResponseNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro", RequestNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro")]
	[return: SoapElement("cancelPrescribedPrescriptionReturn")]
	public int cancelPrescribedPrescription(string providerCode, string physicianStencilNo, string contractNo, string contractType, string insuranceHouseCode, string series, string no, DateTime prescriptionDate, string cancellationReason)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("cancelPrescribedPrescription", new object[9] { providerCode, physicianStencilNo, contractNo, contractType, insuranceHouseCode, series, no, prescriptionDate, cancellationReason });
		return (int)array[0];
	}

	public void cancelPrescribedPrescriptionAsync(string providerCode, string physicianStencilNo, string contractNo, string contractType, string insuranceHouseCode, string series, string no, DateTime prescriptionDate, string cancellationReason)
	{
		cancelPrescribedPrescriptionAsync(providerCode, physicianStencilNo, contractNo, contractType, insuranceHouseCode, series, no, prescriptionDate, cancellationReason, null);
	}

	public void cancelPrescribedPrescriptionAsync(string providerCode, string physicianStencilNo, string contractNo, string contractType, string insuranceHouseCode, string series, string no, DateTime prescriptionDate, string cancellationReason, object userState)
	{
		if (sendOrPostCallback_3 == null)
		{
			sendOrPostCallback_3 = method_3;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("cancelPrescribedPrescription", new object[9] { providerCode, physicianStencilNo, contractNo, contractType, insuranceHouseCode, series, no, prescriptionDate, cancellationReason }, sendOrPostCallback_3, userState);
	}

	private void method_3(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (cancelPrescribedPrescriptionCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			cancelPrescribedPrescriptionCompletedEventHandler_0(this, new cancelPrescribedPrescriptionCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapRpcMethod("", ResponseNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro", RequestNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro")]
	[return: SoapElement("cancelReleasedPrescriptionReturn")]
	public int cancelReleasedPrescription(string providerCode, string workplaceCode, string insuranceHouseCode, string series, string no, int fractionNo, string cancellationReason)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("cancelReleasedPrescription", new object[7] { providerCode, workplaceCode, insuranceHouseCode, series, no, fractionNo, cancellationReason });
		return (int)array[0];
	}

	public void cancelReleasedPrescriptionAsync(string providerCode, string workplaceCode, string insuranceHouseCode, string series, string no, int fractionNo, string cancellationReason)
	{
		cancelReleasedPrescriptionAsync(providerCode, workplaceCode, insuranceHouseCode, series, no, fractionNo, cancellationReason, null);
	}

	public void cancelReleasedPrescriptionAsync(string providerCode, string workplaceCode, string insuranceHouseCode, string series, string no, int fractionNo, string cancellationReason, object userState)
	{
		if (sendOrPostCallback_4 == null)
		{
			sendOrPostCallback_4 = method_4;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("cancelReleasedPrescription", new object[7] { providerCode, workplaceCode, insuranceHouseCode, series, no, fractionNo, cancellationReason }, sendOrPostCallback_4, userState);
	}

	private void method_4(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (cancelReleasedPrescriptionCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			cancelReleasedPrescriptionCompletedEventHandler_0(this, new cancelReleasedPrescriptionCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapRpcMethod("", ResponseNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro", RequestNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro")]
	[return: SoapElement("updateInvoicesReturn")]
	public int updateInvoices(string requestXml)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("updateInvoices", new object[1] { requestXml });
		return (int)array[0];
	}

	public void updateInvoicesAsync(string requestXml)
	{
		updateInvoicesAsync(requestXml, null);
	}

	public void updateInvoicesAsync(string requestXml, object userState)
	{
		if (sendOrPostCallback_5 == null)
		{
			sendOrPostCallback_5 = method_5;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("updateInvoices", new object[1] { requestXml }, sendOrPostCallback_5, userState);
	}

	private void method_5(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (updateInvoicesCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			updateInvoicesCompletedEventHandler_0(this, new updateInvoicesCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapRpcMethod("", ResponseNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro", RequestNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro")]
	[return: SoapElement("getReleasedPrescriptionReturn")]
	public string getReleasedPrescription(string providerCode, string workplaceCode, string insuranceHouseCode, string series, string no, int fractionNo)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getReleasedPrescription", new object[6] { providerCode, workplaceCode, insuranceHouseCode, series, no, fractionNo });
		return (string)array[0];
	}

	public void getReleasedPrescriptionAsync(string providerCode, string workplaceCode, string insuranceHouseCode, string series, string no, int fractionNo)
	{
		getReleasedPrescriptionAsync(providerCode, workplaceCode, insuranceHouseCode, series, no, fractionNo, null);
	}

	public void getReleasedPrescriptionAsync(string providerCode, string workplaceCode, string insuranceHouseCode, string series, string no, int fractionNo, object userState)
	{
		if (sendOrPostCallback_6 == null)
		{
			sendOrPostCallback_6 = method_6;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getReleasedPrescription", new object[6] { providerCode, workplaceCode, insuranceHouseCode, series, no, fractionNo }, sendOrPostCallback_6, userState);
	}

	private void method_6(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getReleasedPrescriptionCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getReleasedPrescriptionCompletedEventHandler_0(this, new getReleasedPrescriptionCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapRpcMethod("", ResponseNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro", RequestNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro")]
	[return: SoapElement("downloadNotReportedPrescriptionsReportReturn")]
	public string downloadNotReportedPrescriptionsReport(string insuranceHouseCode, DateTime fromDate, DateTime toDate, string providerCode, string stencilNo)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("downloadNotReportedPrescriptionsReport", new object[5] { insuranceHouseCode, fromDate, toDate, providerCode, stencilNo });
		return (string)array[0];
	}

	public void downloadNotReportedPrescriptionsReportAsync(string insuranceHouseCode, DateTime fromDate, DateTime toDate, string providerCode, string stencilNo)
	{
		downloadNotReportedPrescriptionsReportAsync(insuranceHouseCode, fromDate, toDate, providerCode, stencilNo, null);
	}

	public void downloadNotReportedPrescriptionsReportAsync(string insuranceHouseCode, DateTime fromDate, DateTime toDate, string providerCode, string stencilNo, object userState)
	{
		if (sendOrPostCallback_7 == null)
		{
			sendOrPostCallback_7 = method_7;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("downloadNotReportedPrescriptionsReport", new object[5] { insuranceHouseCode, fromDate, toDate, providerCode, stencilNo }, sendOrPostCallback_7, userState);
	}

	private void method_7(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (downloadNotReportedPrescriptionsReportCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			downloadNotReportedPrescriptionsReportCompletedEventHandler_0(this, new downloadNotReportedPrescriptionsReportCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapRpcMethod("", ResponseNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro", RequestNamespace = "http://processPrescription.webservices.utils.svapnt.siveco.ro")]
	[return: SoapElement("getStatusForPrescriptionsReturn")]
	public string getStatusForPrescriptions(string insuranceHouseCode, string providerCode, string contractNo, string contractType, DateTime startFrom, DateTime endTo, string workPlaceCode)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getStatusForPrescriptions", new object[7] { insuranceHouseCode, providerCode, contractNo, contractType, startFrom, endTo, workPlaceCode });
		return (string)array[0];
	}

	public void getStatusForPrescriptionsAsync(string insuranceHouseCode, string providerCode, string contractNo, string contractType, DateTime startFrom, DateTime endTo, string workPlaceCode)
	{
		getStatusForPrescriptionsAsync(insuranceHouseCode, providerCode, contractNo, contractType, startFrom, endTo, workPlaceCode, null);
	}

	public void getStatusForPrescriptionsAsync(string insuranceHouseCode, string providerCode, string contractNo, string contractType, DateTime startFrom, DateTime endTo, string workPlaceCode, object userState)
	{
		if (sendOrPostCallback_8 == null)
		{
			sendOrPostCallback_8 = method_8;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getStatusForPrescriptions", new object[7] { insuranceHouseCode, providerCode, contractNo, contractType, startFrom, endTo, workPlaceCode }, sendOrPostCallback_8, userState);
	}

	private void method_8(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getStatusForPrescriptionsCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getStatusForPrescriptionsCompletedEventHandler_0(this, new getStatusForPrescriptionsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	public void CancelAsync(object userState)
	{
		((HttpWebClientProtocol)this).CancelAsync(userState);
	}

	private bool method_9(string string_3)
	{
		if (string_3 == null || string_3 == string.Empty)
		{
			return false;
		}
		Uri uri = new Uri(string_3);
		if (uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		return false;
	}
}
