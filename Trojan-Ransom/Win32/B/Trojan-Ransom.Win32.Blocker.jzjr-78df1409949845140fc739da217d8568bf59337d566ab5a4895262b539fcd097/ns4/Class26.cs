using System;
using System.Net;
using System.Text;
using System.Threading;
using ns0;
using ns1;
using ns9;

namespace ns4;

internal class Class26
{
	private sealed class Class28
	{
		private readonly Class26 class26_0;

		private readonly byte[] byte_0;

		private readonly Class38 class38_0;

		private readonly Class30 class30_0;

		public bool bool_0 = true;

		public Class28(Class26 reportSender, byte[] encryptedData, Class38 services, Class30 notificationEmailSettings)
		{
			class26_0 = reportSender;
			class30_0 = notificationEmailSettings;
			class38_0 = services;
			byte_0 = encryptedData;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class26_0.method_4(Enum1.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{CA3D9371-DEE3-452C-95B3-67B91E478690}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class29 @class = new Class29(class26_0);
				class38_0.method_2(destinationArray, class30_0.EmailAddress, class30_0.AppFriendlyName, class30_0.BuildFriendlyNumber, @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class26_0.delegate2_0 != null)
				{
					class26_0.delegate2_0(this, new EventArgs3(Enum1.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class29
	{
		private readonly Class26 class26_0;

		public bool bool_0;

		public Class29(Class26 reportSender)
		{
			class26_0 = reportSender;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class26_0.method_3(Enum1.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class26_0.method_2(Enum1.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class30
	{
		public static Class30 class30_0 = new Class30(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public string BuildFriendlyNumber => string_2;

		public string AppFriendlyName => string_1;

		public string EmailAddress => string_0;

		public Class30(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
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

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	internal bool method_1(byte[] byte_0, Class30 class30_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class13.smethod_4(byte_0);
		}
		catch (Exception)
		{
			method_3(Enum1.const_0, Class13.string_0);
			return false;
		}
		byte[] array = Class25.smethod_0(byte_, "<RSAKeyValue><Modulus>oiaYMBplaz9Z78gvLm/8AJQcA1Iy19LjinWdP7SEFnw5t14dfmHOh3yS0xlvH4mUhGCvJtcfqQauOIk1ef7xuo99rggkwbAhUNDMvwAdox4P9DvW59SuYcPlhB1NvtZhwiLfrJGEk66d2hf7IAOvbf0fmuBt+zA/WE+iOKwUWN0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_3(Enum1.const_0, Class25.string_0);
			return false;
		}
		method_4(Enum1.const_1);
		Class38 @class = new Class38("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class28 class2 = new Class28(this, array, @class, class30_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
	}

	protected void method_2(Enum1 enum1_0, string string_3, string string_4)
	{
		delegate2_0?.Invoke(this, new EventArgs3(enum1_0, string_3, string_4));
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
