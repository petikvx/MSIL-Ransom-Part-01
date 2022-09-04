using System;
using System.Net;
using System.Text;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender1
{
	private class AfterLoginClosure
	{
		private readonly ReportSender1 m_ReportSender;

		private readonly byte[] m_EncryptedData;

		private readonly WebServicesClient1 m_Services;

		private readonly NotificationEmailSettings m_NotificationEmailSettings;

		public bool Succeeded = true;

		public AfterLoginClosure(ReportSender1 reportSender, byte[] encryptedData, WebServicesClient1 services, NotificationEmailSettings notificationEmailSettings)
		{
			m_ReportSender = reportSender;
			m_NotificationEmailSettings = notificationEmailSettings;
			m_Services = services;
			m_EncryptedData = encryptedData;
		}

		public void AfterLogin(string loginResult)
		{
			if (loginResult == "OK")
			{
				m_ReportSender.InvokeSendingReportFeedback(SendingReportStep1.Transfering);
				byte[] bytes = Encoding.UTF8.GetBytes("{A8DEB29C-67F1-417A-B4A7-8685485B59D2}");
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
					m_ReportSender.SendingReportFeedback(this, new SendingReportFeedbackEventArgs1(SendingReportStep1.ConnectingToServer, loginResult));
				}
				Succeeded = false;
			}
		}
	}

	private class AfterUploadClosure
	{
		private readonly ReportSender1 m_ReportSender;

		public bool Succeeded;

		public AfterUploadClosure(ReportSender1 reportSender)
		{
			m_ReportSender = reportSender;
		}

		public void AfterUpload(string transferingResult)
		{
			if (transferingResult.StartsWith("ERR"))
			{
				m_ReportSender.InvokeSendingReportFeedback(SendingReportStep1.Transfering, transferingResult);
				Succeeded = false;
			}
			else
			{
				m_ReportSender.InvokeSendingReportFeedback(SendingReportStep1.Finished, string.Empty, transferingResult);
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

		public NotificationEmailSettings(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
		{
			m_EmailAddress = emailAddress;
			m_BuildFriendlyNumber = buildFriendlyNumber;
			m_AppFriendlyName = appFriendlyName;
		}
	}

	protected const string AssemblyID = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	private const string LicenseID = "{be78a0c5-c47c-4127-a428-52bdc580a02f}";

	private const string CryptoPublicKey = "{bf13b64c-b3d2-4165-b3f5-7f852d4744cf}";

	private IWebProxy m_Proxy;

	public event SendingReportFeedbackEventHandler1 SendingReportFeedback;

	public void SetProxy(IWebProxy proxy)
	{
		m_Proxy = proxy;
	}

	internal bool SendReport(byte[] reportData, NotificationEmailSettings notificationEmailSettings)
	{
		byte[] data;
		bool result;
		try
		{
			data = SimpleZip.Zip(reportData);
		}
		catch (Exception)
		{
			InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, SimpleZip.ExceptionMessage);
			result = false;
			goto IL_001b;
		}
		byte[] array = Encryption1.Encrypt(data, "<RSAKeyValue><Modulus>2ew8eRVJezuoj0Gwr3qc2So7B2XEw5rrvUYLJh8knZz9ULGO/Mum7LIdw4vre7JLf2VDMtJGIMN7kbbjG4VzbQYWhSF3heZ8UnzHX6t2yW78RN0qYZX8paj3Cd0ozQC/+NMbFWv/2vJUnIj4LbcnZVAIsckX79OWrez258BXKaE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, Encryption1.ExceptionMessage);
			return false;
		}
		InvokeSendingReportFeedback(SendingReportStep1.ConnectingToServer);
		WebServicesClient1 webServicesClient = new WebServicesClient1("!feaa9341-fcd5-30ca-61f9-2eb67a11f402");
		if (m_Proxy != null)
		{
			webServicesClient.SetProxy(m_Proxy);
		}
		AfterLoginClosure afterLoginClosure = new AfterLoginClosure(this, array, webServicesClient, notificationEmailSettings);
		webServicesClient.LoginToServer(afterLoginClosure.AfterLogin);
		return afterLoginClosure.Succeeded;
		IL_001b:
		return result;
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step, string errorMessage, string reportId)
	{
		this.SendingReportFeedback?.Invoke(this, new SendingReportFeedbackEventArgs1(step, errorMessage, reportId));
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step, string errorMessage)
	{
		InvokeSendingReportFeedback(step, errorMessage, string.Empty);
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step)
	{
		InvokeSendingReportFeedback(step, string.Empty);
	}
}
