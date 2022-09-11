using System;
using System.Net;
using System.Text;
using System.Threading;
using ns1;
using ns2;
using ns5;
using ns8;
using ns9;

namespace ns6;

internal class Class43
{
	private sealed class Class45
	{
		private readonly Class43 class43_0;

		private readonly byte[] byte_0;

		private readonly Class49 class49_0;

		private readonly Class47 class47_0;

		public bool bool_0 = true;

		public Class45(Class43 reportSender, byte[] encryptedData, Class49 services, Class47 notificationEmailSettings)
		{
			class43_0 = reportSender;
			class47_0 = notificationEmailSettings;
			class49_0 = services;
			byte_0 = encryptedData;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class43_0.method_4(Enum3.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{CA3D9371-DEE3-452C-95B3-67B91E478690}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class46 @class = new Class46(class43_0);
				class49_0.method_2(destinationArray, class47_0.EmailAddress, class47_0.AppFriendlyName, class47_0.BuildFriendlyNumber, @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class43_0.delegate4_0 != null)
				{
					class43_0.delegate4_0(this, new EventArgs4(Enum3.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class46
	{
		private readonly Class43 class43_0;

		public bool bool_0;

		public Class46(Class43 reportSender)
		{
			class43_0 = reportSender;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class43_0.method_3(Enum3.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class43_0.method_2(Enum3.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class47
	{
		public static Class47 class47_0 = new Class47(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public string BuildFriendlyNumber => string_2;

		public string AppFriendlyName => string_1;

		public string EmailAddress => string_0;

		public Class47(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
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

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	internal unsafe bool method_1(byte[] byte_0, Class47 class47_0)
	{
		void* ptr = stackalloc byte[2];
		byte[] byte_;
		try
		{
			byte_ = Class13.smethod_4(byte_0);
		}
		catch (Exception)
		{
			method_3(Enum3.const_0, Class13.string_0);
			*(sbyte*)ptr = 0;
			goto IL_0020;
		}
		byte[] array = Class42.smethod_0(byte_, "<RSAKeyValue><Modulus>oiaYMBplaz9Z78gvLm/8AJQcA1Iy19LjinWdP7SEFnw5t14dfmHOh3yS0xlvH4mUhGCvJtcfqQauOIk1ef7xuo99rggkwbAhUNDMvwAdox4P9DvW59SuYcPlhB1NvtZhwiLfrJGEk66d2hf7IAOvbf0fmuBt+zA/WE+iOKwUWN0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_3(Enum3.const_0, Class42.string_0);
			((byte*)ptr)[1] = 0;
		}
		else
		{
			method_4(Enum3.const_1);
			Class49 @class = new Class49("d98c1dd4-008f-04b2-e980-0998ecf8427e");
			if (iwebProxy_0 != null)
			{
				@class.method_0(iwebProxy_0);
			}
			Class45 class2 = new Class45(this, array, @class, class47_0);
			@class.method_1(class2.method_0);
			((byte*)ptr)[1] = (class2.bool_0 ? ((byte)1) : ((byte)0));
		}
		goto IL_009b;
		IL_0020:
		((byte*)ptr)[1] = *(byte*)ptr;
		goto IL_009b;
		IL_009b:
		return ((byte*)ptr)[1] != 0;
	}

	protected void method_2(Enum3 enum3_0, string string_3, string string_4)
	{
		delegate4_0?.Invoke(this, new EventArgs4(enum3_0, string_3, string_4));
	}

	protected void method_3(Enum3 enum3_0, string string_3)
	{
		method_2(enum3_0, string_3, string.Empty);
	}

	protected void method_4(Enum3 enum3_0)
	{
		method_3(enum3_0, string.Empty);
	}
}
