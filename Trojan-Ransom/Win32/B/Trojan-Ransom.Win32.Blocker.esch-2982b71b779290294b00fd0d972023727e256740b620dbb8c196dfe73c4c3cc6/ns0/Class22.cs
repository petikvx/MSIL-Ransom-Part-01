using System;
using System.Net;
using System.Text;
using System.Threading;
using ns2;
using ns3;
using ns4;
using ns6;
using ns9;

namespace ns0;

internal class Class22
{
	private sealed class Class24
	{
		private readonly Class22 class22_0;

		private readonly byte[] byte_0;

		private readonly Class34 class34_0;

		private readonly Class26 class26_0;

		public bool bool_0 = true;

		public Class24(Class22 reportSender, byte[] encryptedData, Class34 services, Class26 notificationEmailSettings)
		{
			class22_0 = reportSender;
			class26_0 = notificationEmailSettings;
			class34_0 = services;
			byte_0 = encryptedData;
		}

		public void method_0(string loginResult)
		{
			if (loginResult == "OK")
			{
				class22_0.method_4(Enum1.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{F0C71864-193B-4207-B969-A15E8EDFFBBB}");
				byte[] array = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, array, bytes.Length);
				Array.Copy(byte_0, 0, array, bytes.Length, byte_0.Length);
				Class25 @class = new Class25(class22_0);
				class34_0.method_2(array, class26_0.EmailAddress, class26_0.AppFriendlyName, class26_0.BuildFriendlyNumber, @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class22_0.delegate2_0 != null)
				{
					class22_0.delegate2_0(this, new EventArgs3(Enum1.const_1, loginResult));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class25
	{
		private readonly Class22 class22_0;

		public bool bool_0;

		public Class25(Class22 reportSender)
		{
			class22_0 = reportSender;
		}

		public void method_0(string transferingResult)
		{
			if (transferingResult.StartsWith("ERR"))
			{
				class22_0.method_3(Enum1.const_2, transferingResult);
				bool_0 = false;
			}
			else
			{
				class22_0.method_2(Enum1.const_3, string.Empty, transferingResult);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class26
	{
		public static Class26 class26_0 = new Class26(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public string BuildFriendlyNumber => string_2;

		public string AppFriendlyName => string_1;

		public string EmailAddress => string_0;

		public Class26(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
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

	private Delegate2 delegate2_0;

	public event Delegate2 SendingReportFeedback
	{
		add
		{
			Delegate2 @delegate = delegate2_0;
			Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate2 value2 = (Delegate2)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate2_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate2 @delegate = delegate2_0;
			Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate2 value2 = (Delegate2)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate2_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public void method_0(IWebProxy proxy)
	{
		iwebProxy_0 = proxy;
	}

	internal bool method_1(byte[] reportData, Class26 notificationEmailSettings)
	{
		byte[] data;
		try
		{
			data = Class9.smethod_2(reportData);
		}
		catch (Exception)
		{
			method_3(Enum1.const_0, Class9.string_0);
			return false;
		}
		byte[] array = Class21.smethod_0(data, "<RSAKeyValue><Modulus>n6J9m8OYa1exXG6ZBNtnFJorH0WNhaXXzmaBj5GvrOx6bJJ6ZHN0CaJ/Q2NFEbuola/QuSDzNCQxTBFzsitGl/8NJZ+/qVY4SlFHh+zIGxPFzOrtvOABq994JJbY+a06COOzsewJ55wsDmT1f88/EeltMVoOyOG7wF7LObp4sZE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_3(Enum1.const_0, Class21.string_0);
			return false;
		}
		method_4(Enum1.const_1);
		Class34 @class = new Class34("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class24 class2 = new Class24(this, array, @class, notificationEmailSettings);
		@class.method_1(class2.method_0);
		return class2.bool_0;
	}

	protected void method_2(Enum1 step, string errorMessage, string reportId)
	{
		delegate2_0?.Invoke(this, new EventArgs3(step, errorMessage, reportId));
	}

	protected void method_3(Enum1 step, string errorMessage)
	{
		method_2(step, errorMessage, string.Empty);
	}

	protected void method_4(Enum1 step)
	{
		method_3(step, string.Empty);
	}
}
