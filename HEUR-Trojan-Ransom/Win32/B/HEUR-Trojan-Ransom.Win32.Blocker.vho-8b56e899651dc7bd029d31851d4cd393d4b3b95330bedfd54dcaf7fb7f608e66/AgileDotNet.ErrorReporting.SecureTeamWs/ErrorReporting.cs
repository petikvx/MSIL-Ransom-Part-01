using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Protocols;
using AgileDotNet.ErrorReporting.Properties;

namespace AgileDotNet.ErrorReporting.SecureTeamWs;

[DesignerCategory("code")]
[DebuggerStepThrough]
[WebServiceBinding(Name = "ErrorReportingSoap", Namespace = "http://secureteam.net/webservices/")]
[GeneratedCode("System.Web.Services", "4.0.30319.1")]
public class ErrorReporting : SoapHttpClientProtocol
{
	private SendOrPostCallback sendOrPostCallback_0;

	private bool bool_0;

	private CreateErrorReportCompletedEventHandler createErrorReportCompletedEventHandler_0;

	public string Url
	{
		get
		{
			return ((WebClientProtocol)this).get_Url();
		}
		set
		{
			if (method_1(((WebClientProtocol)this).get_Url()) && !bool_0 && !method_1(value))
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

	public event CreateErrorReportCompletedEventHandler CreateErrorReportCompleted
	{
		add
		{
			CreateErrorReportCompletedEventHandler createErrorReportCompletedEventHandler = createErrorReportCompletedEventHandler_0;
			CreateErrorReportCompletedEventHandler createErrorReportCompletedEventHandler2;
			do
			{
				createErrorReportCompletedEventHandler2 = createErrorReportCompletedEventHandler;
				CreateErrorReportCompletedEventHandler value2 = (CreateErrorReportCompletedEventHandler)Delegate.Combine(createErrorReportCompletedEventHandler2, value);
				createErrorReportCompletedEventHandler = Interlocked.CompareExchange(ref createErrorReportCompletedEventHandler_0, value2, createErrorReportCompletedEventHandler2);
			}
			while ((object)createErrorReportCompletedEventHandler != createErrorReportCompletedEventHandler2);
		}
		remove
		{
			CreateErrorReportCompletedEventHandler createErrorReportCompletedEventHandler = createErrorReportCompletedEventHandler_0;
			CreateErrorReportCompletedEventHandler createErrorReportCompletedEventHandler2;
			do
			{
				createErrorReportCompletedEventHandler2 = createErrorReportCompletedEventHandler;
				CreateErrorReportCompletedEventHandler value2 = (CreateErrorReportCompletedEventHandler)Delegate.Remove(createErrorReportCompletedEventHandler2, value);
				createErrorReportCompletedEventHandler = Interlocked.CompareExchange(ref createErrorReportCompletedEventHandler_0, value2, createErrorReportCompletedEventHandler2);
			}
			while ((object)createErrorReportCompletedEventHandler != createErrorReportCompletedEventHandler2);
		}
	}

	public ErrorReporting()
	{
		Url = Settings.Default.AgileDotNet_ExceptionReporting_SecureTeamWs_ErrorReporting;
		if (method_1(Url))
		{
			UseDefaultCredentials = true;
			bool_0 = false;
		}
		else
		{
			bool_0 = true;
		}
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public void CreateErrorReport(string xml)
	{
		((SoapHttpClientProtocol)this).Invoke("CreateErrorReport", new object[1] { xml });
	}

	public void CreateErrorReportAsync(string xml)
	{
		CreateErrorReportAsync(xml, null);
	}

	public void CreateErrorReportAsync(string xml, object userState)
	{
		if (sendOrPostCallback_0 == null)
		{
			sendOrPostCallback_0 = method_0;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("CreateErrorReport", new object[1] { xml }, sendOrPostCallback_0, userState);
	}

	private void method_0(object object_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		if (createErrorReportCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			createErrorReportCompletedEventHandler_0(this, new AsyncCompletedEventArgs(((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	public void CancelAsync(object userState)
	{
		((HttpWebClientProtocol)this).CancelAsync(userState);
	}

	private bool method_1(string string_0)
	{
		if (string_0 != null && !(string_0 == string.Empty))
		{
			Uri uri = new Uri(string_0);
			if (uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
			return false;
		}
		return false;
	}
}
