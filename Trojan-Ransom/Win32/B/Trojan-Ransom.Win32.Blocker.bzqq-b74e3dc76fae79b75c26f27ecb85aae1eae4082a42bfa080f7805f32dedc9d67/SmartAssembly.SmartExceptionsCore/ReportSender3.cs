using System;
using System.Net;
using System.Text;
using System.Threading;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender3
{
	private class AfterLoginClosure
	{
		private readonly ReportSender3 m_ReportSender;

		private readonly byte[] m_EncryptedData;

		private readonly WebServicesClient1 m_Services;

		private readonly NotificationEmailSettings m_NotificationEmailSettings;

		public bool Succeeded = true;

		public AfterLoginClosure(ReportSender3 reportSender, byte[] encryptedData, WebServicesClient1 services, NotificationEmailSettings notificationEmailSettings)
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
					m_ReportSender.InvokeSendingReportFeedback(SendingReportStep3.Transfering);
					bytes = Encoding.UTF8.GetBytes("{FA0844EB-EF82-404C-B76C-C092ABDB9392}");
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
						m_ReportSender.SendingReportFeedback(this, new SendingReportFeedbackEventArgs3(SendingReportStep3.ConnectingToServer, text));
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

	private class AfterUploadClosure
	{
		private readonly ReportSender3 m_ReportSender;

		public bool Succeeded;

		public AfterUploadClosure(ReportSender3 reportSender)
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
					m_ReportSender.InvokeSendingReportFeedback(SendingReportStep3.Transfering, transferingResult);
					Succeeded = false;
				}
				else
				{
					m_ReportSender.InvokeSendingReportFeedback(SendingReportStep3.Finished, string.Empty, transferingResult);
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

	internal class NotificationEmailSettings
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

	public event SendingReportFeedbackEventHandler3 SendingReportFeedback
	{
		add
		{
			SendingReportFeedbackEventHandler3 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler3);
			SendingReportFeedbackEventHandler3 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler3);
			SendingReportFeedbackEventHandler3 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler3);
			try
			{
				sendingReportFeedbackEventHandler = this.SendingReportFeedback;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler3)Delegate.Combine(sendingReportFeedbackEventHandler2, value);
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
			SendingReportFeedbackEventHandler3 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler3);
			SendingReportFeedbackEventHandler3 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler3);
			SendingReportFeedbackEventHandler3 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler3);
			try
			{
				sendingReportFeedbackEventHandler = this.SendingReportFeedback;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler3)Delegate.Remove(sendingReportFeedbackEventHandler2, value);
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
				array = SimpleZip1.Zip(reportData);
			}
			catch (Exception)
			{
				InvokeSendingReportFeedback(SendingReportStep3.PreparingReport, SimpleZip1.ExceptionMessage);
				flag = false;
				return flag;
			}
			array2 = Encryption1.Encrypt(array, "<RSAKeyValue><Modulus>ouQsWoWBnmOqk5oiU2jtlbq5pjqf+VMkxyeAMax4XhYx/73DvmvK2hM6oHyJMzG9z4q2g6iVzseYCR9G25/HguU2hRhyjPcloCXUrQo5yBoVCQzTNnnc5XXeKzLqKuEpkrNRSRyWRB9eh4a6BtuxveEOfBxiHIIXzo0+ffdbu90=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			if (array2 == null)
			{
				InvokeSendingReportFeedback(SendingReportStep3.PreparingReport, Encryption1.ExceptionMessage);
				return false;
			}
			InvokeSendingReportFeedback(SendingReportStep3.ConnectingToServer);
			webServicesClient = new WebServicesClient1("!1b5d570f-4f6d-4187-55a3-b83778a63f94");
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

	protected void InvokeSendingReportFeedback(SendingReportStep3 step, string errorMessage, string reportId)
	{
		SendingReportFeedbackEventHandler3 sendingReportFeedback = default(SendingReportFeedbackEventHandler3);
		try
		{
			sendingReportFeedback = this.SendingReportFeedback;
			sendingReportFeedback?.Invoke(this, new SendingReportFeedbackEventArgs3(step, errorMessage, reportId));
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, sendingReportFeedback, this, step, errorMessage, reportId);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep3 step, string errorMessage)
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

	protected void InvokeSendingReportFeedback(SendingReportStep3 step)
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
