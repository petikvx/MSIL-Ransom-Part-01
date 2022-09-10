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

		private readonly Class40 class40_0;

		private readonly Class32 class32_0;

		public bool bool_0 = true;

		public Class30(Class28 reportSender, byte[] encryptedData, Class40 services, Class32 notificationEmailSettings)
		{
			class28_0 = reportSender;
			class32_0 = notificationEmailSettings;
			class40_0 = services;
			byte_0 = encryptedData;
		}

		public void method_0(string string_0)
		{
			byte[] destinationArray = default(byte[]);
			Class31 @class = default(Class31);
			string errorMessage = default(string);
			while (true)
			{
				if (string_0 == Class14.smethod_0(1046))
				{
					while (true)
					{
						Class42.smethod_97(class28_0, Enum1.const_2);
						byte[] bytes = Encoding.UTF8.GetBytes(Class14.smethod_0(1051));
						if (!FJsftKKDUacnAnO7aPb())
						{
							switch (4)
							{
							case 5:
								break;
							case 0:
								goto end_IL_0003;
							case 2:
							case 4:
								destinationArray = new byte[bytes.Length + byte_0.Length];
								Array.Copy(bytes, destinationArray, bytes.Length);
								Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
								goto case 3;
							case 3:
							case 6:
							{
								@class = new Class31(class28_0);
								Class40 class2 = class40_0;
								string string_ = class32_0.string_0;
								string string_2 = class32_0.string_1;
								string string_3 = class32_0.string_2;
								Delegate11 delegate11_ = @class.method_0;
								Class42.smethod_74(destinationArray, string_, class2, string_3, delegate11_, string_2);
								goto default;
							}
							default:
								bool_0 = @class.bool_0;
								return;
							case 7:
								goto IL_0128;
							case 8:
								goto end_IL_0062;
							case 9:
								return;
							}
							continue;
						}
						return;
						continue;
						end_IL_0003:
						break;
					}
					continue;
				}
				errorMessage = string_0;
				if (class28_0.delegate10_0 == null)
				{
					break;
				}
				goto IL_0128;
				IL_0128:
				class28_0.delegate10_0(this, new EventArgs3(Enum1.const_1, errorMessage));
				break;
				continue;
				end_IL_0062:
				break;
			}
			bool_0 = false;
		}

		internal static bool GM1Z9LKCNDwZ9pf1Aah()
		{
			return true;
		}

		internal static bool FJsftKKDUacnAnO7aPb()
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
			while (true)
			{
				IL_0046:
				if (string_0.StartsWith(Class14.smethod_0(1104)))
				{
					while (true)
					{
						Class42.smethod_146(class28_0, Enum1.const_2, string_0);
						bool_0 = false;
						if (!dDDVcFKyTgXnaZquJEW())
						{
							switch (2)
							{
							case 1:
								break;
							case 0:
							case 5:
								goto IL_0046;
							case 2:
								return;
							default:
								goto end_IL_0046;
							case 6:
								return;
							}
							continue;
						}
						break;
					}
				}
				else
				{
					Class42.smethod_113(class28_0, Enum1.const_3, string.Empty, string_0);
				}
				break;
				continue;
				end_IL_0046:
				break;
			}
			bool_0 = true;
		}

		internal static bool ofJwMgKM3V453IUnwxt()
		{
			return true;
		}

		internal static bool dDDVcFKyTgXnaZquJEW()
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
			string_0 = emailAddress;
			string_2 = buildFriendlyNumber;
			string_1 = appFriendlyName;
		}

		internal static bool lVU85dKAhEGF2gJQBna()
		{
			return true;
		}

		internal static bool OXwKFxKHBH0bDUj8xat()
		{
			return false;
		}
	}

	internal IWebProxy iwebProxy_0;

	internal Delegate10 delegate10_0;

	public event Delegate10 SendingReportFeedback
	{
		add
		{
			Delegate10 @delegate = delegate10_0;
			Delegate10 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate10 value2 = (Delegate10)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate10_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate10 @delegate = delegate10_0;
			Delegate10 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate10 value2 = (Delegate10)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate10_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	internal static bool J91agSKpbUW5JJKGMw1()
	{
		return true;
	}

	internal static bool wKkevIKfyDW3Wk3e3Na()
	{
		return false;
	}
}
