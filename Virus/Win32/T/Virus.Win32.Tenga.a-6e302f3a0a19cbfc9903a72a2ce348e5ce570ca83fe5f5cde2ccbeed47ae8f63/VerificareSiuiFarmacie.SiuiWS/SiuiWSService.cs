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

namespace VerificareSiuiFarmacie.SiuiWS;

[WebServiceBinding(Namespace = "http://webservices.utils.svapnt.siveco.ro", Name = "SiuiWSSoapBinding")]
[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
[DesignerCategory("code")]
public class SiuiWSService : SoapHttpClientProtocol
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

	private SendOrPostCallback sendOrPostCallback_9;

	private SendOrPostCallback sendOrPostCallback_10;

	private SendOrPostCallback sendOrPostCallback_11;

	private SendOrPostCallback sendOrPostCallback_12;

	private SendOrPostCallback sendOrPostCallback_13;

	private bool bool_0;

	private X509Certificate2 x509Certificate2_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private getCataloguesCompletedEventHandler getCataloguesCompletedEventHandler_0;

	private getProviderInfoCompletedEventHandler getProviderInfoCompletedEventHandler_0;

	private sendReportCompletedEventHandler sendReportCompletedEventHandler_0;

	private getReportFeedbackCompletedEventHandler getReportFeedbackCompletedEventHandler_0;

	private getRefundCompletedEventHandler getRefundCompletedEventHandler_0;

	private getRefundForInvoiceCompletedEventHandler getRefundForInvoiceCompletedEventHandler_0;

	private getDecisionsCompletedEventHandler getDecisionsCompletedEventHandler_0;

	private registerApplicationInstanceCompletedEventHandler registerApplicationInstanceCompletedEventHandler_0;

	private isPhysicianOnContractCompletedEventHandler isPhysicianOnContractCompletedEventHandler_0;

	private generatePrescriptionSeriesCompletedEventHandler generatePrescriptionSeriesCompletedEventHandler_0;

	private getPrescriptionSeriesInfoCompletedEventHandler getPrescriptionSeriesInfoCompletedEventHandler_0;

	private getPartnerInfoCompletedEventHandler getPartnerInfoCompletedEventHandler_0;

	private getRegisterFeedbackAggregatedCompletedEventHandler getRegisterFeedbackAggregatedCompletedEventHandler_0;

	private getRegisterFeedbackCompletedEventHandler getRegisterFeedbackCompletedEventHandler_0;

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
			if (method_14(((WebClientProtocol)this).get_Url()) && !bool_0 && !method_14(value))
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

	public event getCataloguesCompletedEventHandler getCataloguesCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getCataloguesCompletedEventHandler_0 = (getCataloguesCompletedEventHandler)Delegate.Combine(getCataloguesCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getCataloguesCompletedEventHandler_0 = (getCataloguesCompletedEventHandler)Delegate.Remove(getCataloguesCompletedEventHandler_0, value);
		}
	}

	public event getProviderInfoCompletedEventHandler getProviderInfoCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getProviderInfoCompletedEventHandler_0 = (getProviderInfoCompletedEventHandler)Delegate.Combine(getProviderInfoCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getProviderInfoCompletedEventHandler_0 = (getProviderInfoCompletedEventHandler)Delegate.Remove(getProviderInfoCompletedEventHandler_0, value);
		}
	}

	public event sendReportCompletedEventHandler sendReportCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			sendReportCompletedEventHandler_0 = (sendReportCompletedEventHandler)Delegate.Combine(sendReportCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			sendReportCompletedEventHandler_0 = (sendReportCompletedEventHandler)Delegate.Remove(sendReportCompletedEventHandler_0, value);
		}
	}

	public event getReportFeedbackCompletedEventHandler getReportFeedbackCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getReportFeedbackCompletedEventHandler_0 = (getReportFeedbackCompletedEventHandler)Delegate.Combine(getReportFeedbackCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getReportFeedbackCompletedEventHandler_0 = (getReportFeedbackCompletedEventHandler)Delegate.Remove(getReportFeedbackCompletedEventHandler_0, value);
		}
	}

	public event getRefundCompletedEventHandler getRefundCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getRefundCompletedEventHandler_0 = (getRefundCompletedEventHandler)Delegate.Combine(getRefundCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getRefundCompletedEventHandler_0 = (getRefundCompletedEventHandler)Delegate.Remove(getRefundCompletedEventHandler_0, value);
		}
	}

	public event getRefundForInvoiceCompletedEventHandler getRefundForInvoiceCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getRefundForInvoiceCompletedEventHandler_0 = (getRefundForInvoiceCompletedEventHandler)Delegate.Combine(getRefundForInvoiceCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getRefundForInvoiceCompletedEventHandler_0 = (getRefundForInvoiceCompletedEventHandler)Delegate.Remove(getRefundForInvoiceCompletedEventHandler_0, value);
		}
	}

	public event getDecisionsCompletedEventHandler getDecisionsCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getDecisionsCompletedEventHandler_0 = (getDecisionsCompletedEventHandler)Delegate.Combine(getDecisionsCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getDecisionsCompletedEventHandler_0 = (getDecisionsCompletedEventHandler)Delegate.Remove(getDecisionsCompletedEventHandler_0, value);
		}
	}

	public event registerApplicationInstanceCompletedEventHandler registerApplicationInstanceCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			registerApplicationInstanceCompletedEventHandler_0 = (registerApplicationInstanceCompletedEventHandler)Delegate.Combine(registerApplicationInstanceCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			registerApplicationInstanceCompletedEventHandler_0 = (registerApplicationInstanceCompletedEventHandler)Delegate.Remove(registerApplicationInstanceCompletedEventHandler_0, value);
		}
	}

	public event isPhysicianOnContractCompletedEventHandler isPhysicianOnContractCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			isPhysicianOnContractCompletedEventHandler_0 = (isPhysicianOnContractCompletedEventHandler)Delegate.Combine(isPhysicianOnContractCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			isPhysicianOnContractCompletedEventHandler_0 = (isPhysicianOnContractCompletedEventHandler)Delegate.Remove(isPhysicianOnContractCompletedEventHandler_0, value);
		}
	}

	public event generatePrescriptionSeriesCompletedEventHandler generatePrescriptionSeriesCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			generatePrescriptionSeriesCompletedEventHandler_0 = (generatePrescriptionSeriesCompletedEventHandler)Delegate.Combine(generatePrescriptionSeriesCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			generatePrescriptionSeriesCompletedEventHandler_0 = (generatePrescriptionSeriesCompletedEventHandler)Delegate.Remove(generatePrescriptionSeriesCompletedEventHandler_0, value);
		}
	}

	public event getPrescriptionSeriesInfoCompletedEventHandler getPrescriptionSeriesInfoCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getPrescriptionSeriesInfoCompletedEventHandler_0 = (getPrescriptionSeriesInfoCompletedEventHandler)Delegate.Combine(getPrescriptionSeriesInfoCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getPrescriptionSeriesInfoCompletedEventHandler_0 = (getPrescriptionSeriesInfoCompletedEventHandler)Delegate.Remove(getPrescriptionSeriesInfoCompletedEventHandler_0, value);
		}
	}

	public event getPartnerInfoCompletedEventHandler getPartnerInfoCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getPartnerInfoCompletedEventHandler_0 = (getPartnerInfoCompletedEventHandler)Delegate.Combine(getPartnerInfoCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getPartnerInfoCompletedEventHandler_0 = (getPartnerInfoCompletedEventHandler)Delegate.Remove(getPartnerInfoCompletedEventHandler_0, value);
		}
	}

	public event getRegisterFeedbackAggregatedCompletedEventHandler getRegisterFeedbackAggregatedCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getRegisterFeedbackAggregatedCompletedEventHandler_0 = (getRegisterFeedbackAggregatedCompletedEventHandler)Delegate.Combine(getRegisterFeedbackAggregatedCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getRegisterFeedbackAggregatedCompletedEventHandler_0 = (getRegisterFeedbackAggregatedCompletedEventHandler)Delegate.Remove(getRegisterFeedbackAggregatedCompletedEventHandler_0, value);
		}
	}

	public event getRegisterFeedbackCompletedEventHandler getRegisterFeedbackCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getRegisterFeedbackCompletedEventHandler_0 = (getRegisterFeedbackCompletedEventHandler)Delegate.Combine(getRegisterFeedbackCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getRegisterFeedbackCompletedEventHandler_0 = (getRegisterFeedbackCompletedEventHandler)Delegate.Remove(getRegisterFeedbackCompletedEventHandler_0, value);
		}
	}

	public SiuiWSService()
	{
		Url = Settings.Default.ServerCNAS_SiuiWS_SiuiWSService;
		if (method_14(Url))
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

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("getCataloguesReturn")]
	public string[] getCatalogues(string partnerCategory, DateTime start)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getCatalogues", new object[2] { partnerCategory, start });
		return (string[])array[0];
	}

	public void getCataloguesAsync(string partnerCategory, DateTime start)
	{
		getCataloguesAsync(partnerCategory, start, null);
	}

	public void getCataloguesAsync(string partnerCategory, DateTime start, object userState)
	{
		if (sendOrPostCallback_0 == null)
		{
			sendOrPostCallback_0 = method_0;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getCatalogues", new object[2] { partnerCategory, start }, sendOrPostCallback_0, userState);
	}

	private void method_0(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getCataloguesCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getCataloguesCompletedEventHandler_0(this, new getCataloguesCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("getProviderInfoReturn")]
	public string[] getProviderInfo(string partnerCategory, DateTime start, DateTime stop, string uic)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getProviderInfo", new object[4] { partnerCategory, start, stop, uic });
		return (string[])array[0];
	}

	public void getProviderInfoAsync(string partnerCategory, DateTime start, DateTime stop, string uic)
	{
		getProviderInfoAsync(partnerCategory, start, stop, uic, null);
	}

	public void getProviderInfoAsync(string partnerCategory, DateTime start, DateTime stop, string uic, object userState)
	{
		if (sendOrPostCallback_1 == null)
		{
			sendOrPostCallback_1 = method_1;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getProviderInfo", new object[4] { partnerCategory, start, stop, uic }, sendOrPostCallback_1, userState);
	}

	private void method_1(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getProviderInfoCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getProviderInfoCompletedEventHandler_0(this, new getProviderInfoCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("sendReportReturn")]
	public int sendReport(string reportType, string reportXML)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("sendReport", new object[2] { reportType, reportXML });
		return (int)array[0];
	}

	public void sendReportAsync(string reportType, string reportXML)
	{
		sendReportAsync(reportType, reportXML, null);
	}

	public void sendReportAsync(string reportType, string reportXML, object userState)
	{
		if (sendOrPostCallback_2 == null)
		{
			sendOrPostCallback_2 = method_2;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("sendReport", new object[2] { reportType, reportXML }, sendOrPostCallback_2, userState);
	}

	private void method_2(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (sendReportCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			sendReportCompletedEventHandler_0(this, new sendReportCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("getReportFeedbackReturn")]
	public string[] getReportFeedback(string fileName)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getReportFeedback", new object[1] { fileName });
		return (string[])array[0];
	}

	public void getReportFeedbackAsync(string fileName)
	{
		getReportFeedbackAsync(fileName, null);
	}

	public void getReportFeedbackAsync(string fileName, object userState)
	{
		if (sendOrPostCallback_3 == null)
		{
			sendOrPostCallback_3 = method_3;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getReportFeedback", new object[1] { fileName }, sendOrPostCallback_3, userState);
	}

	private void method_3(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getReportFeedbackCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getReportFeedbackCompletedEventHandler_0(this, new getReportFeedbackCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("getRefundReturn")]
	public string[] getRefund(string partnerCategory, DateTime start, DateTime stop, string uic)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getRefund", new object[4] { partnerCategory, start, stop, uic });
		return (string[])array[0];
	}

	public void getRefundAsync(string partnerCategory, DateTime start, DateTime stop, string uic)
	{
		getRefundAsync(partnerCategory, start, stop, uic, null);
	}

	public void getRefundAsync(string partnerCategory, DateTime start, DateTime stop, string uic, object userState)
	{
		if (sendOrPostCallback_4 == null)
		{
			sendOrPostCallback_4 = method_4;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getRefund", new object[4] { partnerCategory, start, stop, uic }, sendOrPostCallback_4, userState);
	}

	private void method_4(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getRefundCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getRefundCompletedEventHandler_0(this, new getRefundCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("getRefundForInvoiceReturn")]
	public string[] getRefundForInvoice(string partnerCategory, string invoiceNumber, DateTime invoiceDate, string uic)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getRefundForInvoice", new object[4] { partnerCategory, invoiceNumber, invoiceDate, uic });
		return (string[])array[0];
	}

	public void getRefundForInvoiceAsync(string partnerCategory, string invoiceNumber, DateTime invoiceDate, string uic)
	{
		getRefundForInvoiceAsync(partnerCategory, invoiceNumber, invoiceDate, uic, null);
	}

	public void getRefundForInvoiceAsync(string partnerCategory, string invoiceNumber, DateTime invoiceDate, string uic, object userState)
	{
		if (sendOrPostCallback_5 == null)
		{
			sendOrPostCallback_5 = method_5;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getRefundForInvoice", new object[4] { partnerCategory, invoiceNumber, invoiceDate, uic }, sendOrPostCallback_5, userState);
	}

	private void method_5(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getRefundForInvoiceCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getRefundForInvoiceCompletedEventHandler_0(this, new getRefundForInvoiceCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("getDecisionsReturn")]
	public string[] getDecisions(string partnerCategory, string requestXml)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getDecisions", new object[2] { partnerCategory, requestXml });
		return (string[])array[0];
	}

	public void getDecisionsAsync(string partnerCategory, string requestXml)
	{
		getDecisionsAsync(partnerCategory, requestXml, null);
	}

	public void getDecisionsAsync(string partnerCategory, string requestXml, object userState)
	{
		if (sendOrPostCallback_6 == null)
		{
			sendOrPostCallback_6 = method_6;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getDecisions", new object[2] { partnerCategory, requestXml }, sendOrPostCallback_6, userState);
	}

	private void method_6(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getDecisionsCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getDecisionsCompletedEventHandler_0(this, new getDecisionsCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("registerApplicationInstanceReturn")]
	public string[] registerApplicationInstance(string provType, string uic, string ctrNo, string serialNo, DateTime regDate)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("registerApplicationInstance", new object[5] { provType, uic, ctrNo, serialNo, regDate });
		return (string[])array[0];
	}

	public void registerApplicationInstanceAsync(string provType, string uic, string ctrNo, string serialNo, DateTime regDate)
	{
		registerApplicationInstanceAsync(provType, uic, ctrNo, serialNo, regDate, null);
	}

	public void registerApplicationInstanceAsync(string provType, string uic, string ctrNo, string serialNo, DateTime regDate, object userState)
	{
		if (sendOrPostCallback_7 == null)
		{
			sendOrPostCallback_7 = method_7;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("registerApplicationInstance", new object[5] { provType, uic, ctrNo, serialNo, regDate }, sendOrPostCallback_7, userState);
	}

	private void method_7(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (registerApplicationInstanceCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			registerApplicationInstanceCompletedEventHandler_0(this, new registerApplicationInstanceCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("isPhysicianOnContractReturn")]
	public string isPhysicianOnContract(string contractNo, long physicianId, DateTime atDate)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("isPhysicianOnContract", new object[3] { contractNo, physicianId, atDate });
		return (string)array[0];
	}

	public void isPhysicianOnContractAsync(string contractNo, long physicianId, DateTime atDate)
	{
		isPhysicianOnContractAsync(contractNo, physicianId, atDate, null);
	}

	public void isPhysicianOnContractAsync(string contractNo, long physicianId, DateTime atDate, object userState)
	{
		if (sendOrPostCallback_8 == null)
		{
			sendOrPostCallback_8 = method_8;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("isPhysicianOnContract", new object[3] { contractNo, physicianId, atDate }, sendOrPostCallback_8, userState);
	}

	private void method_8(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (isPhysicianOnContractCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			isPhysicianOnContractCompletedEventHandler_0(this, new isPhysicianOnContractCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("generatePrescriptionSeriesReturn")]
	public string[] generatePrescriptionSeries(string categoryCode, string orgUnitCode, string uic, string subUnitCode, DateTime validFrom, bool isOnLine, int quantity)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("generatePrescriptionSeries", new object[7] { categoryCode, orgUnitCode, uic, subUnitCode, validFrom, isOnLine, quantity });
		return (string[])array[0];
	}

	public void generatePrescriptionSeriesAsync(string categoryCode, string orgUnitCode, string uic, string subUnitCode, DateTime validFrom, bool isOnLine, int quantity)
	{
		generatePrescriptionSeriesAsync(categoryCode, orgUnitCode, uic, subUnitCode, validFrom, isOnLine, quantity, null);
	}

	public void generatePrescriptionSeriesAsync(string categoryCode, string orgUnitCode, string uic, string subUnitCode, DateTime validFrom, bool isOnLine, int quantity, object userState)
	{
		if (sendOrPostCallback_9 == null)
		{
			sendOrPostCallback_9 = method_9;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("generatePrescriptionSeries", new object[7] { categoryCode, orgUnitCode, uic, subUnitCode, validFrom, isOnLine, quantity }, sendOrPostCallback_9, userState);
	}

	private void method_9(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (generatePrescriptionSeriesCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			generatePrescriptionSeriesCompletedEventHandler_0(this, new generatePrescriptionSeriesCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("getPrescriptionSeriesInfoReturn")]
	public string[] getPrescriptionSeriesInfo(string categoryCode, string orgUnitCode, string uic, string subUnitCode)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getPrescriptionSeriesInfo", new object[4] { categoryCode, orgUnitCode, uic, subUnitCode });
		return (string[])array[0];
	}

	public void getPrescriptionSeriesInfoAsync(string categoryCode, string orgUnitCode, string uic, string subUnitCode)
	{
		getPrescriptionSeriesInfoAsync(categoryCode, orgUnitCode, uic, subUnitCode, null);
	}

	public void getPrescriptionSeriesInfoAsync(string categoryCode, string orgUnitCode, string uic, string subUnitCode, object userState)
	{
		if (sendOrPostCallback_10 == null)
		{
			sendOrPostCallback_10 = method_10;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getPrescriptionSeriesInfo", new object[4] { categoryCode, orgUnitCode, uic, subUnitCode }, sendOrPostCallback_10, userState);
	}

	private void method_10(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getPrescriptionSeriesInfoCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getPrescriptionSeriesInfoCompletedEventHandler_0(this, new getPrescriptionSeriesInfoCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("getPartnerInfoReturn")]
	public string[] getPartnerInfo(string partnerCode, DateTime startDate, DateTime stopDate, string uic, string subUnitCode)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getPartnerInfo", new object[5] { partnerCode, startDate, stopDate, uic, subUnitCode });
		return (string[])array[0];
	}

	public void getPartnerInfoAsync(string partnerCode, DateTime startDate, DateTime stopDate, string uic, string subUnitCode)
	{
		getPartnerInfoAsync(partnerCode, startDate, stopDate, uic, subUnitCode, null);
	}

	public void getPartnerInfoAsync(string partnerCode, DateTime startDate, DateTime stopDate, string uic, string subUnitCode, object userState)
	{
		if (sendOrPostCallback_11 == null)
		{
			sendOrPostCallback_11 = method_11;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getPartnerInfo", new object[5] { partnerCode, startDate, stopDate, uic, subUnitCode }, sendOrPostCallback_11, userState);
	}

	private void method_11(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getPartnerInfoCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getPartnerInfoCompletedEventHandler_0(this, new getPartnerInfoCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("getRegisterFeedbackAggregatedReturn")]
	public string[] getRegisterFeedbackAggregated(string partnerUic, string partnerWorkplace, DateTime start, DateTime stop)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getRegisterFeedbackAggregated", new object[4] { partnerUic, partnerWorkplace, start, stop });
		return (string[])array[0];
	}

	public void getRegisterFeedbackAggregatedAsync(string partnerUic, string partnerWorkplace, DateTime start, DateTime stop)
	{
		getRegisterFeedbackAggregatedAsync(partnerUic, partnerWorkplace, start, stop, null);
	}

	public void getRegisterFeedbackAggregatedAsync(string partnerUic, string partnerWorkplace, DateTime start, DateTime stop, object userState)
	{
		if (sendOrPostCallback_12 == null)
		{
			sendOrPostCallback_12 = method_12;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getRegisterFeedbackAggregated", new object[4] { partnerUic, partnerWorkplace, start, stop }, sendOrPostCallback_12, userState);
	}

	private void method_12(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getRegisterFeedbackAggregatedCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getRegisterFeedbackAggregatedCompletedEventHandler_0(this, new getRegisterFeedbackAggregatedCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement("getRegisterFeedbackReturn")]
	public string[] getRegisterFeedback(string filename)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getRegisterFeedback", new object[1] { filename });
		return (string[])array[0];
	}

	public void getRegisterFeedbackAsync(string filename)
	{
		getRegisterFeedbackAsync(filename, null);
	}

	public void getRegisterFeedbackAsync(string filename, object userState)
	{
		if (sendOrPostCallback_13 == null)
		{
			sendOrPostCallback_13 = method_13;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getRegisterFeedback", new object[1] { filename }, sendOrPostCallback_13, userState);
	}

	private void method_13(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getRegisterFeedbackCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getRegisterFeedbackCompletedEventHandler_0(this, new getRegisterFeedbackCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	public void CancelAsync(object userState)
	{
		((HttpWebClientProtocol)this).CancelAsync(userState);
	}

	private bool method_14(string string_3)
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
