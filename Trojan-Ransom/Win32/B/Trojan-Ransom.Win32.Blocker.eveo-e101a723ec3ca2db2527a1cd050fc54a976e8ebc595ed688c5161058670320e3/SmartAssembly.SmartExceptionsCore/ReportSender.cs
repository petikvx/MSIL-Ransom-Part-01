using System;
using System.Net;
using System.Text;
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

		public AfterLoginClosure(ReportSender reportSender, byte[] encryptedData, WebServicesClient services, NotificationEmailSettings notificationEmailSettings)
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
				m_ReportSender.InvokeSendingReportFeedback(SendingReportStep.Transfering);
				byte[] bytes = Encoding.UTF8.GetBytes("{5A1FEE7B-46A6-48AF-B86E-DB5D01C466E9}");
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
					m_ReportSender.SendingReportFeedback(this, new SendingReportFeedbackEventArgs(SendingReportStep.ConnectingToServer, loginResult));
				}
				Succeeded = false;
			}
		}
	}

	private class AfterUploadClosure
	{
		private readonly ReportSender m_ReportSender;

		public bool Succeeded;

		public AfterUploadClosure(ReportSender reportSender)
		{
			m_ReportSender = reportSender;
		}

		public void AfterUpload(string transferingResult)
		{
			if (transferingResult.StartsWith("ERR"))
			{
				m_ReportSender.InvokeSendingReportFeedback(SendingReportStep.Transfering, transferingResult);
				Succeeded = false;
			}
			else
			{
				m_ReportSender.InvokeSendingReportFeedback(SendingReportStep.Finished, string.Empty, transferingResult);
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

	public event SendingReportFeedbackEventHandler SendingReportFeedback;

	public void SetProxy(IWebProxy proxy)
	{
		m_Proxy = proxy;
	}

	internal bool SendReport(byte[] reportData, NotificationEmailSettings notificationEmailSettings)
	{
		byte[] data;
		try
		{
			data = SimpleZip.Zip(reportData);
		}
		catch (Exception)
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport, SimpleZip.ExceptionMessage);
			return false;
		}
		byte[] array = Encryption.Encrypt(data, "<RSAKeyValue><Modulus>3pN7WvLV3A7XsmutACQQa5zndqUbwUeSKE78n9ddwtiuhLkakIfJnObTuOIvT0dCO6Q6RlbEreNfIxNx0ndmeuhb4VKPdw2oLSoc67ntf0y5FS6ifET+VUBScQ13huOVLvXWq1m7F38hnImYzxAwpi2z4MYz41KicgQhBKdwWHk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport, Encryption.ExceptionMessage);
			return false;
		}
		InvokeSendingReportFeedback(SendingReportStep.ConnectingToServer);
		WebServicesClient webServicesClient = new WebServicesClient("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (m_Proxy != null)
		{
			webServicesClient.SetProxy(m_Proxy);
		}
		AfterLoginClosure afterLoginClosure = new AfterLoginClosure(this, array, webServicesClient, notificationEmailSettings);
		webServicesClient.LoginToServer(afterLoginClosure.AfterLogin);
		return afterLoginClosure.Succeeded;
	}

	protected void InvokeSendingReportFeedback(SendingReportStep step, string errorMessage, string reportId)
	{
		this.SendingReportFeedback?.Invoke(this, new SendingReportFeedbackEventArgs(step, errorMessage, reportId));
	}

	protected void InvokeSendingReportFeedback(SendingReportStep step, string errorMessage)
	{
		InvokeSendingReportFeedback(step, errorMessage, string.Empty);
	}

	protected void InvokeSendingReportFeedback(SendingReportStep step)
	{
		InvokeSendingReportFeedback(step, string.Empty);
	}
}
