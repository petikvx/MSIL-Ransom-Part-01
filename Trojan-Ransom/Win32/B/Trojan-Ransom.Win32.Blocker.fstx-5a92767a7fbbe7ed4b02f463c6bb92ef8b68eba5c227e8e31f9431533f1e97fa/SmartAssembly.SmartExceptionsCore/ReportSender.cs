using System;
using System.Net;
using System.Text;
using System.Threading;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender
{
	private class AfterLoginClosure
	{
		private readonly ReportSender m_ReportSender;

		private readonly byte[] m_EncryptedData;

		private readonly WebServicesClient m_Services;

		private readonly NotificationEmailSettings m_NotificationEmailSettings;

		public bool Succeeded = true;

		public AfterLoginClosure(ReportSender reportSender_0, byte[] byte_0, WebServicesClient webServicesClient_0, NotificationEmailSettings notificationEmailSettings_0)
		{
			m_ReportSender = reportSender_0;
			m_NotificationEmailSettings = notificationEmailSettings_0;
			m_Services = webServicesClient_0;
			m_EncryptedData = byte_0;
		}

		public void AfterLogin(string string_0)
		{
			if (string_0 == "OK")
			{
				m_ReportSender.InvokeSendingReportFeedback(SendingReportStep.Transfering);
				byte[] bytes = Encoding.UTF8.GetBytes("{9EADBEBC-3D5B-44AD-9ABE-7FB1EC533F65}");
				byte[] array = new byte[bytes.Length + m_EncryptedData.Length];
				Array.Copy(bytes, array, bytes.Length);
				Array.Copy(m_EncryptedData, 0, array, bytes.Length, m_EncryptedData.Length);
				AfterUploadClosure afterUploadClosure = new AfterUploadClosure(m_ReportSender);
				m_Services.Upload(array, m_NotificationEmailSettings.EmailAddress, m_NotificationEmailSettings.AppFriendlyName, m_NotificationEmailSettings.BuildFriendlyNumber, afterUploadClosure.AfterUpload);
				Succeeded = afterUploadClosure.Succeeded;
			}
			else
			{
				if (m_ReportSender.SendingReportFeedback != null)
				{
					m_ReportSender.SendingReportFeedback(this, new SendingReportFeedbackEventArgs(SendingReportStep.ConnectingToServer, string_0));
				}
				Succeeded = false;
			}
		}
	}

	private class AfterUploadClosure
	{
		private readonly ReportSender m_ReportSender;

		public bool Succeeded;

		public AfterUploadClosure(ReportSender reportSender_0)
		{
			m_ReportSender = reportSender_0;
		}

		public void AfterUpload(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				m_ReportSender.InvokeSendingReportFeedback(SendingReportStep.Transfering, string_0);
				Succeeded = false;
			}
			else
			{
				m_ReportSender.InvokeSendingReportFeedback(SendingReportStep.Finished, string.Empty, string_0);
				Succeeded = true;
			}
		}
	}

	internal class NotificationEmailSettings
	{
		public static NotificationEmailSettings NullEmailSettings = new NotificationEmailSettings(null, null, null);

		private readonly string m_EmailAddress;

		private readonly string m_AppFriendlyName;

		private readonly string m_BuildFriendlyNumber;

		public string BuildFriendlyNumber => m_BuildFriendlyNumber;

		public string AppFriendlyName => m_AppFriendlyName;

		public string EmailAddress => m_EmailAddress;

		public NotificationEmailSettings(string string_0, string string_1, string string_2)
		{
			m_EmailAddress = string_0;
			m_BuildFriendlyNumber = string_2;
			m_AppFriendlyName = string_1;
		}
	}

	private IWebProxy m_Proxy;

	public event SendingReportFeedbackEventHandler SendingReportFeedback
	{
		add
		{
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler = this.SendingReportFeedback;
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler2;
			do
			{
				sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
				SendingReportFeedbackEventHandler value2 = (SendingReportFeedbackEventHandler)Delegate.Combine(sendingReportFeedbackEventHandler2, value);
				sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref this.SendingReportFeedback, value2, sendingReportFeedbackEventHandler2);
			}
			while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
		}
	}

	public void SetProxy(IWebProxy iwebProxy_0)
	{
		m_Proxy = iwebProxy_0;
	}

	internal bool SendReport(byte[] byte_0, NotificationEmailSettings notificationEmailSettings_0)
	{
		byte[] byte_;
		try
		{
			byte_ = SimpleZip.Zip(byte_0);
		}
		catch (Exception)
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport, SimpleZip.ExceptionMessage);
			return false;
		}
		byte[] array = Encryption.Encrypt(byte_, "<RSAKeyValue><Modulus>p19IUWXgcBEUanZSAJRxgMOGN2rLRXDS6iYgzxYKveOZlKrDVwdrhTND74B3nV5ewjm7WWgvvGb62pEaC9XyfCaKo0FVOUXK6mveowJ/VukB+wJCDZCMZEqFgBnjIGDzkBsmJUA5Swa/eLQhaEMCBueDf7lSLjoJm0webUxWeF0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport, Encryption.ExceptionMessage);
			return false;
		}
		InvokeSendingReportFeedback(SendingReportStep.ConnectingToServer);
		WebServicesClient webServicesClient = new WebServicesClient("90b6f93e-e6b5-82b5-99cd-93351fba1f1c");
		if (m_Proxy != null)
		{
			webServicesClient.SetProxy(m_Proxy);
		}
		AfterLoginClosure afterLoginClosure = new AfterLoginClosure(this, array, webServicesClient, notificationEmailSettings_0);
		webServicesClient.LoginToServer(afterLoginClosure.AfterLogin);
		return afterLoginClosure.Succeeded;
	}

	protected void InvokeSendingReportFeedback(SendingReportStep sendingReportStep_0, string string_0, string string_1)
	{
		this.SendingReportFeedback?.Invoke(this, new SendingReportFeedbackEventArgs(sendingReportStep_0, string_0, string_1));
	}

	protected void InvokeSendingReportFeedback(SendingReportStep sendingReportStep_0, string string_0)
	{
		InvokeSendingReportFeedback(sendingReportStep_0, string_0, string.Empty);
	}

	protected void InvokeSendingReportFeedback(SendingReportStep sendingReportStep_0)
	{
		InvokeSendingReportFeedback(sendingReportStep_0, string.Empty);
	}
}
