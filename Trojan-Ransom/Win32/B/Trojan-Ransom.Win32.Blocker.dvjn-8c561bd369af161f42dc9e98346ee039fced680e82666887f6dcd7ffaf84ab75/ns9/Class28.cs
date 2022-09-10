using System;
using System.Net;
using System.Text;
using System.Threading;
using ns7;

namespace ns9;

internal class Class28
{
	internal class Class30
	{
		private readonly Class28 class28_0;

		private readonly byte[] byte_0;

		private readonly Class41 class41_0;

		private readonly Class32 class32_0;

		public bool bool_0;

		public Class30(Class28 reportSender, byte[] encryptedData, Class41 services, Class32 notificationEmailSettings)
		{
			while (true)
			{
				bool_0 = true;
				if (pqvgQf7e09jAjkNG6vU())
				{
					switch (3)
					{
					case 0:
					case 4:
						continue;
					case 1:
					case 3:
						base._002Ector();
						goto case 5;
					case 5:
						class28_0 = reportSender;
						class32_0 = notificationEmailSettings;
						class41_0 = services;
						break;
					case 6:
						return;
					}
					break;
				}
				return;
			}
			byte_0 = encryptedData;
		}

		public void method_0(string string_0)
		{
			if (string_0 == Class14.smethod_0(1259))
			{
				Class33.smethod_40(class28_0, Enum1.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes(Class14.smethod_0(1264));
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class31 @class = new Class31(class28_0);
				Class41 class2 = class41_0;
				string string_ = class32_0.string_0;
				string string_2 = class32_0.string_1;
				string string_3 = class32_0.string_2;
				Delegate12 delegate12_ = @class.method_0;
				Class33.smethod_135(string_, string_3, string_2, destinationArray, class2, delegate12_);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class28_0.delegate11_0 != null)
				{
					class28_0.delegate11_0(this, new EventArgs3(Enum1.const_1, string_0));
				}
				bool_0 = false;
			}
		}

		internal static bool pqvgQf7e09jAjkNG6vU()
		{
			return true;
		}

		internal static bool BEb9fl7JmOiranlMCR8()
		{
			return false;
		}
	}

	private class Class31
	{
		private readonly Class28 class28_0;

		public bool bool_0;

		public Class31(Class28 reportSender)
		{
			class28_0 = reportSender;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith(Class14.smethod_0(1317)))
			{
				Class33.smethod_113(class28_0, Enum1.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				Class33.smethod_59(class28_0, Enum1.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}

		internal static bool OuV93Y7jpd7weFVXGve()
		{
			return true;
		}

		internal static bool w7qK1k7D2cubw3YYMwt()
		{
			return false;
		}
	}

	internal class Class32
	{
		public static Class32 class32_0 = new Class32(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public string BuildFriendlyNumber => string_2;

		public string AppFriendlyName => string_1;

		public string EmailAddress => string_0;

		public Class32(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
		{
			int num = 4;
			if (!MV5FST7W1SyxiSLE3gZ())
			{
			}
			do
			{
				IL_0048:
				switch (num)
				{
				case 0:
				case 4:
					break;
				default:
					string_1 = appFriendlyName;
					num = 5;
					if (!MV5FST7W1SyxiSLE3gZ())
					{
						goto IL_0048;
					}
					break;
				case 1:
				case 2:
					string_0 = emailAddress;
					string_2 = buildFriendlyNumber;
					goto default;
				case 5:
					return;
				}
				base._002Ector();
				num = 2;
			}
			while (MleqU87fL4KZxroi5ks());
		}

		internal static bool MleqU87fL4KZxroi5ks()
		{
			return true;
		}

		internal static bool MV5FST7W1SyxiSLE3gZ()
		{
			return false;
		}
	}

	internal IWebProxy iwebProxy_0;

	internal Delegate11 delegate11_0;

	public event Delegate11 SendingReportFeedback
	{
		add
		{
			Delegate11 @delegate = delegate11_0;
			Delegate11 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate11 value2 = (Delegate11)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate11_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate11 @delegate = delegate11_0;
			Delegate11 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate11 value2 = (Delegate11)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate11_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	internal static bool R8Eohc7Ox5syaBYSQZQ()
	{
		return true;
	}

	internal static bool q7qFyT7GW8MotRRmYGI()
	{
		return false;
	}
}
