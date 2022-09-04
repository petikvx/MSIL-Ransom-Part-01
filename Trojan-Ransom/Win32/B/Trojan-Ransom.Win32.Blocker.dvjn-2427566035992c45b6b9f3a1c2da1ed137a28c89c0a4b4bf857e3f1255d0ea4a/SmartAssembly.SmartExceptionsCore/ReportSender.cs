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

		public bool Succeeded;

		public AfterLoginClosure(ReportSender reportSender, byte[] encryptedData, WebServicesClient services, NotificationEmailSettings notificationEmailSettings)
		{
			Class2.l4t8M9wzGUypc();
			Succeeded = true;
			base._002Ector();
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
				byte[] bytes = Encoding.UTF8.GetBytes("{1CD3919F-B939-4749-8562-FA804A172C81}");
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
			Class2.l4t8M9wzGUypc();
			base._002Ector();
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
		public static NotificationEmailSettings NullEmailSettings;

		private readonly string m_EmailAddress;

		private readonly string m_AppFriendlyName;

		private readonly string m_BuildFriendlyNumber;

		public string BuildFriendlyNumber => m_BuildFriendlyNumber;

		public string AppFriendlyName => m_AppFriendlyName;

		public string EmailAddress => m_EmailAddress;

		public NotificationEmailSettings(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
		{
			Class2.l4t8M9wzGUypc();
			base._002Ector();
			m_EmailAddress = emailAddress;
			m_BuildFriendlyNumber = buildFriendlyNumber;
			m_AppFriendlyName = appFriendlyName;
		}

		static NotificationEmailSettings()
		{
			Class2.l4t8M9wzGUypc();
			NullEmailSettings = new NotificationEmailSettings(null, null, null);
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
		byte[] array = Encryption.Encrypt(data, "<RSAKeyValue><Modulus>4IM+vt7kiszKC5KoI45Oljjed1mbJ00yJVoeg///2kZmeEIGKm0my3uYK85jRpuiGFmwSMsG4CzX+itN4RZ8KzkzqNsUutPBxcdB5Bqz+QGinEktbKSOQxP8wjevpU1N8vgZWiKDwAfz2VVTZq1YLpeD6ANMekDeKWmO2WJVmoM=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
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

	public ReportSender()
	{
		Class2.l4t8M9wzGUypc();
		base._002Ector();
	}
}
