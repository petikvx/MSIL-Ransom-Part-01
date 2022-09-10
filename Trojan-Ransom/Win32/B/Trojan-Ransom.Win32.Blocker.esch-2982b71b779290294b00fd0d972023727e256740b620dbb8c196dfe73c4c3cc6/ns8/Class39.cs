using System;
using System.Net;
using System.Text;
using System.Threading;
using ns0;
using ns3;
using ns5;
using ns9;

namespace ns8;

internal class Class39
{
	private sealed class Class41
	{
		private readonly Class39 class39_0;

		private readonly byte[] byte_0;

		private readonly Class45 class45_0;

		private readonly Class43 class43_0;

		public bool bool_0 = true;

		public Class41(Class39 reportSender, byte[] encryptedData, Class45 services, Class43 notificationEmailSettings)
		{
			class39_0 = reportSender;
			class43_0 = notificationEmailSettings;
			class45_0 = services;
			byte_0 = encryptedData;
		}

		public void method_0(string loginResult)
		{
			if (loginResult == "OK")
			{
				class39_0.method_4(Enum3.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{F0C71864-193B-4207-B969-A15E8EDFFBBB}");
				byte[] array = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, array, bytes.Length);
				Array.Copy(byte_0, 0, array, bytes.Length, byte_0.Length);
				Class42 @class = new Class42(class39_0);
				class45_0.method_2(array, class43_0.EmailAddress, class43_0.AppFriendlyName, class43_0.BuildFriendlyNumber, @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class39_0.delegate4_0 != null)
				{
					class39_0.delegate4_0(this, new EventArgs4(Enum3.const_1, loginResult));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class42
	{
		private readonly Class39 class39_0;

		public bool bool_0;

		public Class42(Class39 reportSender)
		{
			class39_0 = reportSender;
		}

		public void method_0(string transferingResult)
		{
			if (transferingResult.StartsWith("ERR"))
			{
				class39_0.method_3(Enum3.const_2, transferingResult);
				bool_0 = false;
			}
			else
			{
				class39_0.method_2(Enum3.const_3, string.Empty, transferingResult);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class43
	{
		public static Class43 class43_0 = new Class43(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public string BuildFriendlyNumber => string_2;

		public string AppFriendlyName => string_1;

		public string EmailAddress => string_0;

		public Class43(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
		{
			string_0 = emailAddress;
			string_2 = buildFriendlyNumber;
			string_1 = appFriendlyName;
		}
	}

	protected const string string_0 = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	private const string string_1 = "{be78a0c5-c47c-4127-a428-52bdc580a02f}";

	private const string string_2 = "{bf13b64c-b3d2-4165-b3f5-7f852d4744cf}";

	private IWebProxy iwebProxy_0;

	private Delegate4 delegate4_0;

	public event Delegate4 SendingReportFeedback
	{
		add
		{
			Delegate4 @delegate = delegate4_0;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value2 = (Delegate4)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate4_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate4 @delegate = delegate4_0;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value2 = (Delegate4)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate4_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public void method_0(IWebProxy proxy)
	{
		iwebProxy_0 = proxy;
	}

	internal bool method_1(byte[] reportData, Class43 notificationEmailSettings)
	{
		byte[] data;
		bool result;
		try
		{
			data = Class9.smethod_2(reportData);
		}
		catch (Exception)
		{
			method_3(Enum3.const_0, Class9.string_0);
			result = false;
			goto IL_001b;
		}
		byte[] array = Class38.smethod_0(data, "<RSAKeyValue><Modulus>n6J9m8OYa1exXG6ZBNtnFJorH0WNhaXXzmaBj5GvrOx6bJJ6ZHN0CaJ/Q2NFEbuola/QuSDzNCQxTBFzsitGl/8NJZ+/qVY4SlFHh+zIGxPFzOrtvOABq994JJbY+a06COOzsewJ55wsDmT1f88/EeltMVoOyOG7wF7LObp4sZE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_3(Enum3.const_0, Class38.string_0);
			return false;
		}
		method_4(Enum3.const_1);
		Class45 @class = new Class45("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class41 class2 = new Class41(this, array, @class, notificationEmailSettings);
		@class.method_1(class2.method_0);
		return class2.bool_0;
		IL_001b:
		return result;
	}

	protected void method_2(Enum3 step, string errorMessage, string reportId)
	{
		delegate4_0?.Invoke(this, new EventArgs4(step, errorMessage, reportId));
	}

	protected void method_3(Enum3 step, string errorMessage)
	{
		method_2(step, errorMessage, string.Empty);
	}

	protected void method_4(Enum3 step)
	{
		method_3(step, string.Empty);
	}
}
