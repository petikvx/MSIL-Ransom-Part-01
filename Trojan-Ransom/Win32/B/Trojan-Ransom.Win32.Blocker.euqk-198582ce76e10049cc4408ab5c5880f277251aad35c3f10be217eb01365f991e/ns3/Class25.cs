using System;
using System.Net;
using System.Text;
using System.Threading;
using ns0;
using ns1;
using ns2;
using ns7;
using ns8;

namespace ns3;

internal class Class25
{
	private class Class27
	{
		private readonly Class25 class25_0;

		private readonly byte[] byte_0;

		private readonly Class37 class37_0;

		private readonly Class29 class29_0;

		public bool bool_0 = true;

		public Class27(Class25 reportSender, byte[] encryptedData, Class37 services, Class29 notificationEmailSettings)
		{
			class25_0 = reportSender;
			class29_0 = notificationEmailSettings;
			class37_0 = services;
			byte_0 = encryptedData;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class25_0.method_4(Enum1.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{C310B14D-4169-4768-A0F4-C1C02707021E}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class28 @class = new Class28(class25_0);
				class37_0.method_2(destinationArray, class29_0.EmailAddress, class29_0.AppFriendlyName, class29_0.BuildFriendlyNumber, @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class25_0.delegate1_0 != null)
				{
					class25_0.delegate1_0(this, new EventArgs3(Enum1.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class28
	{
		private readonly Class25 class25_0;

		public bool bool_0;

		public Class28(Class25 reportSender)
		{
			class25_0 = reportSender;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class25_0.method_3(Enum1.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class25_0.method_2(Enum1.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class29
	{
		public static Class29 class29_0 = new Class29(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public string BuildFriendlyNumber => string_2;

		public string AppFriendlyName => string_1;

		public string EmailAddress => string_0;

		public Class29(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
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

	private Delegate1 delegate1_0;

	public event Delegate1 SendingReportFeedback
	{
		add
		{
			Delegate1 @delegate = delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value2 = (Delegate1)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate1 @delegate = delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value2 = (Delegate1)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	internal bool method_1(byte[] byte_0, Class29 class29_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class12.smethod_4(byte_0);
		}
		catch (Exception)
		{
			method_3(Enum1.const_0, Class12.string_0);
			return false;
		}
		byte[] array = Class24.smethod_0(byte_, "<RSAKeyValue><Modulus>s5oOc7N1G+U2WZuzOH/JhQeZt6XLrDjEppHdCBkIhJKLOIwsFwdqH1OkCRhkJYafjSQFO1/ugsdrR8Jl5RH8s82VzGEyej620UcUPXBJvuseEdB3/Bm1ZCHLLNtNQcCANNkToi2avVzJdQWRiE39z5R9yxcsFqsaraa8TpinfrU=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_3(Enum1.const_0, Class24.string_0);
			return false;
		}
		method_4(Enum1.const_1);
		Class37 @class = new Class37("!b9f80054-5908-7e41-504d-307116511006");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class27 class2 = new Class27(this, array, @class, class29_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
	}

	protected void method_2(Enum1 enum1_0, string string_3, string string_4)
	{
		delegate1_0?.Invoke(this, new EventArgs3(enum1_0, string_3, string_4));
	}

	protected void method_3(Enum1 enum1_0, string string_3)
	{
		method_2(enum1_0, string_3, string.Empty);
	}

	protected void method_4(Enum1 enum1_0)
	{
		method_3(enum1_0, string.Empty);
	}
}
