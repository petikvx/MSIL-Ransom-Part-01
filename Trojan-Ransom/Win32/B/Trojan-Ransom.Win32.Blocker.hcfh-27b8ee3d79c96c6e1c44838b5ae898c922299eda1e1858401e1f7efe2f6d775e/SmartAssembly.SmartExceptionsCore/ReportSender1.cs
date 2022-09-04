using System;
using System.Net;
using System.Text;
using System.Threading;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender1
{
	private sealed class AfterLoginClosure
	{
		private readonly ReportSender1 m_ReportSender;

		private readonly byte[] m_EncryptedData;

		private readonly WebServicesClient1 m_Services;

		private readonly NotificationEmailSettings m_NotificationEmailSettings;

		public bool Succeeded = true;

		public AfterLoginClosure(ReportSender1 reportSender, byte[] encryptedData, WebServicesClient1 services, NotificationEmailSettings notificationEmailSettings)
		{
			try
			{
				m_ReportSender = reportSender;
				m_NotificationEmailSettings = notificationEmailSettings;
				m_Services = services;
				m_EncryptedData = encryptedData;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, this, reportSender, encryptedData, services, notificationEmailSettings);
				throw;
			}
		}

		public void AfterLogin(string loginResult)
		{
			byte[] bytes = default(byte[]);
			byte[] array = default(byte[]);
			AfterUploadClosure afterUploadClosure = default(AfterUploadClosure);
			string text = default(string);
			try
			{
				if (loginResult == "OK")
				{
					m_ReportSender.InvokeSendingReportFeedback(SendingReportStep1.Transfering);
					bytes = Encoding.UTF8.GetBytes("{033897BF-7A25-4E84-A557-884D8EA9E0D8}");
					array = new byte[bytes.Length + m_EncryptedData.Length];
					Array.Copy(bytes, array, bytes.Length);
					Array.Copy(m_EncryptedData, 0, array, bytes.Length, m_EncryptedData.Length);
					afterUploadClosure = new AfterUploadClosure(m_ReportSender);
					m_Services.Upload(array, m_NotificationEmailSettings.EmailAddress, m_NotificationEmailSettings.AppFriendlyName, m_NotificationEmailSettings.BuildFriendlyNumber, afterUploadClosure.AfterUpload);
					Succeeded = afterUploadClosure.Succeeded;
				}
				else
				{
					text = loginResult;
					if (m_ReportSender.SendingReportFeedback != null)
					{
						m_ReportSender.SendingReportFeedback(this, new SendingReportFeedbackEventArgs1(SendingReportStep1.ConnectingToServer, text));
					}
					Succeeded = false;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, bytes, array, afterUploadClosure, text, this, loginResult);
				throw;
			}
		}
	}

	private sealed class AfterUploadClosure
	{
		private readonly ReportSender1 m_ReportSender;

		public bool Succeeded;

		public AfterUploadClosure(ReportSender1 reportSender)
		{
			try
			{
				m_ReportSender = reportSender;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, reportSender);
				throw;
			}
		}

		public void AfterUpload(string transferingResult)
		{
			try
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, transferingResult);
				throw;
			}
		}
	}

	internal sealed class NotificationEmailSettings
	{
		public static NotificationEmailSettings NullEmailSettings;

		private readonly string m_EmailAddress;

		private readonly string m_AppFriendlyName;

		private readonly string m_BuildFriendlyNumber;

		public string BuildFriendlyNumber
		{
			get
			{
				try
				{
					return m_BuildFriendlyNumber;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
		}

		public string AppFriendlyName
		{
			get
			{
				try
				{
					return m_AppFriendlyName;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
		}

		public string EmailAddress
		{
			get
			{
				try
				{
					return m_EmailAddress;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
		}

		public NotificationEmailSettings(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
		{
			try
			{
				m_EmailAddress = emailAddress;
				m_BuildFriendlyNumber = buildFriendlyNumber;
				m_AppFriendlyName = appFriendlyName;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, this, emailAddress, appFriendlyName, buildFriendlyNumber);
				throw;
			}
		}

		static NotificationEmailSettings()
		{
			try
			{
				NullEmailSettings = new NotificationEmailSettings(null, null, null);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	protected const string AssemblyID = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	private const string LicenseID = "{be78a0c5-c47c-4127-a428-52bdc580a02f}";

	private const string CryptoPublicKey = "{bf13b64c-b3d2-4165-b3f5-7f852d4744cf}";

	private IWebProxy m_Proxy;

	public event SendingReportFeedbackEventHandler1 SendingReportFeedback
	{
		add
		{
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler1);
			try
			{
				sendingReportFeedbackEventHandler = this.SendingReportFeedback;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler1)Delegate.Combine(sendingReportFeedbackEventHandler2, value);
					sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref this.SendingReportFeedback, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
				}
				while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, this, value);
				throw;
			}
		}
		remove
		{
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler1);
			try
			{
				sendingReportFeedbackEventHandler = this.SendingReportFeedback;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler1)Delegate.Remove(sendingReportFeedbackEventHandler2, value);
					sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref this.SendingReportFeedback, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
				}
				while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, this, value);
				throw;
			}
		}
	}

	public void SetProxy(IWebProxy proxy)
	{
		try
		{
			m_Proxy = proxy;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, proxy);
			throw;
		}
	}

	internal bool SendReport(byte[] reportData, NotificationEmailSettings notificationEmailSettings)
	{
		byte[] array = default(byte[]);
		bool flag = default(bool);
		byte[] array2 = default(byte[]);
		WebServicesClient1 webServicesClient = default(WebServicesClient1);
		AfterLoginClosure afterLoginClosure = default(AfterLoginClosure);
		try
		{
			try
			{
				array = SimpleZip.Zip(reportData);
			}
			catch (Exception)
			{
				InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, SimpleZip.ExceptionMessage);
				flag = false;
				return flag;
			}
			array2 = Encryption1.Encrypt(array, "<RSAKeyValue><Modulus>yNHncfanfFaY53rbLlBpku2Ntwgo3D2aKXkBn3lsG21BtQInpkbVl+9wxDcvDlVRvtXGbbIpuyomRY/xe4QoCOAWvgMOTU3draJjHY5qyqOJWzEfUxVcYrmez8qJUeZFHH5F4n7FWEyLtuqQMmYOsYOPQSdxRnPpvuWOA7Zn6Fc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			if (array2 == null)
			{
				InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, Encryption1.ExceptionMessage);
				return false;
			}
			InvokeSendingReportFeedback(SendingReportStep1.ConnectingToServer);
			webServicesClient = new WebServicesClient1("!39d4a1e5-ac2d-c6ce-bb8d-afa49e656757");
			if (m_Proxy != null)
			{
				webServicesClient.SetProxy(m_Proxy);
			}
			afterLoginClosure = new AfterLoginClosure(this, array2, webServicesClient, notificationEmailSettings);
			webServicesClient.LoginToServer(afterLoginClosure.AfterLogin);
			return afterLoginClosure.Succeeded;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, array, array2, webServicesClient, afterLoginClosure, flag, this, reportData, notificationEmailSettings);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step, string errorMessage, string reportId)
	{
		SendingReportFeedbackEventHandler1 sendingReportFeedback = default(SendingReportFeedbackEventHandler1);
		try
		{
			sendingReportFeedback = this.SendingReportFeedback;
			sendingReportFeedback?.Invoke(this, new SendingReportFeedbackEventArgs1(step, errorMessage, reportId));
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, sendingReportFeedback, this, step, errorMessage, reportId);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step, string errorMessage)
	{
		try
		{
			InvokeSendingReportFeedback(step, errorMessage, string.Empty);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, step, errorMessage);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step)
	{
		try
		{
			InvokeSendingReportFeedback(step, string.Empty);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, step);
			throw;
		}
	}
}
