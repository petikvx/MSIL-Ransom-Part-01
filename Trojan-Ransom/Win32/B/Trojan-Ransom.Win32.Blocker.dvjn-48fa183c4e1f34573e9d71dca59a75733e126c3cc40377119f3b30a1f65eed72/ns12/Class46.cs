using System;
using System.Net;
using System.Text;
using System.Threading;
using ns10;

namespace ns12;

internal class Class46
{
	internal class Class48
	{
		private readonly Class46 class46_0;

		private readonly byte[] byte_0;

		private readonly Class58 class58_0;

		private readonly Class50 class50_0;

		public bool bool_0 = true;

		public Class48(Class46 reportSender, byte[] encryptedData, Class58 services, Class50 notificationEmailSettings)
		{
			class46_0 = reportSender;
			class50_0 = notificationEmailSettings;
			class58_0 = services;
			byte_0 = encryptedData;
		}

		public void method_0(string string_0)
		{
			if (string_0 == Class32.smethod_0(866))
			{
				Class12.smethod_45(class46_0, Enum4.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes(Class32.smethod_0(2800));
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class49 @class = new Class49(class46_0);
				Class58 class2 = class58_0;
				string string_ = class50_0.string_0;
				string string_2 = class50_0.string_1;
				string string_3 = class50_0.string_2;
				Delegate21 delegate21_ = @class.method_0;
				Class12.smethod_106(delegate21_, string_, class2, destinationArray, string_3, string_2);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class46_0.delegate20_0 != null)
				{
					class46_0.delegate20_0(this, new EventArgs3(Enum4.const_1, string_0));
				}
				bool_0 = false;
			}
		}

		internal static bool tkBjyel3JLhdCBS5W8d()
		{
			return true;
		}

		internal static bool BrhGJJlDoF03ZAT2oV7()
		{
			return false;
		}
	}

	private class Class49
	{
		private readonly Class46 class46_0;

		public bool bool_0;

		public Class49(Class46 reportSender)
		{
			class46_0 = reportSender;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith(Class32.smethod_0(861)))
			{
				Class12.smethod_73(class46_0, Enum4.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				Class12.smethod_42(class46_0, Enum4.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}

		internal static bool DDpT5elob1cSsH00lEx()
		{
			return true;
		}

		internal static bool uaRIJflwMrvw4DJrBNR()
		{
			return false;
		}
	}

	internal class Class50
	{
		public static Class50 class50_0 = new Class50(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public string BuildFriendlyNumber => string_2;

		public string AppFriendlyName => string_1;

		public string EmailAddress => string_0;

		public Class50(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
		{
			while (true)
			{
				base._002Ector();
				if (jnOpKXlFNIDvm0sOnN9())
				{
					switch (4)
					{
					case 0:
					case 3:
						continue;
					case 1:
					case 4:
						string_0 = emailAddress;
						break;
					case 5:
						return;
					}
				}
				break;
			}
			string_2 = buildFriendlyNumber;
			string_1 = appFriendlyName;
		}

		internal static bool jnOpKXlFNIDvm0sOnN9()
		{
			return true;
		}

		internal static bool MqDQrblngyEeddRhFmW()
		{
			return false;
		}
	}

	internal IWebProxy iwebProxy_0;

	internal Delegate20 delegate20_0;

	public event Delegate20 SendingReportFeedback
	{
		add
		{
			Delegate20 @delegate = delegate20_0;
			Delegate20 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate20 value2 = (Delegate20)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate20_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate20 @delegate = delegate20_0;
			Delegate20 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate20 value2 = (Delegate20)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate20_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	internal static bool wqZmqGlUJWPBgmQqNn9()
	{
		return true;
	}

	internal static bool rClT6llc5Bpt3qCVyiW()
	{
		return false;
	}
}
