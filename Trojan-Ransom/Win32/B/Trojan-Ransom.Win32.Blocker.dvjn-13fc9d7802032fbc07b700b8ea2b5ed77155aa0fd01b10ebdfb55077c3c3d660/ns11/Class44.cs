using System;
using System.Net;
using System.Text;
using System.Threading;

namespace ns11;

internal class Class44
{
	internal class Class46
	{
		private readonly Class44 class44_0;

		private readonly byte[] byte_0;

		private readonly Class57 class57_0;

		private readonly Class48 class48_0;

		public bool bool_0;

		public Class46(Class44 reportSender, byte[] encryptedData, Class57 services, Class48 notificationEmailSettings)
		{
			while (true)
			{
				bool_0 = true;
				if (wVSSKqX8FWyRup66JXb())
				{
					switch (4)
					{
					case 0:
					case 1:
						break;
					case 4:
						base._002Ector();
						class44_0 = reportSender;
						goto IL_0047;
					case 5:
						goto IL_0047;
					default:
						goto end_IL_0001;
					case 6:
						return;
					}
					continue;
				}
				goto IL_0047;
				IL_0047:
				class48_0 = notificationEmailSettings;
				break;
				continue;
				end_IL_0001:
				break;
			}
			class57_0 = services;
			byte_0 = encryptedData;
		}

		public void method_0(string string_0)
		{
			Class57 @class = default(Class57);
			string string_ = default(string);
			string string_2 = default(string);
			string string_3 = default(string);
			Delegate21 delegate21_ = default(Delegate21);
			Class47 class2 = default(Class47);
			byte[] destinationArray = default(byte[]);
			while (true)
			{
				if (!(string_0 == "OK"))
				{
					int num = 6;
					if (!wVSSKqX8FWyRup66JXb())
					{
						goto IL_0132;
					}
					while (true)
					{
						switch (num)
						{
						default:
							num = 5;
							if (!w6KGutXTfILVG1Sg5YP())
							{
								continue;
							}
							return;
						case 8:
							break;
						case 1:
						case 2:
							goto IL_0069;
						case 6:
							if (class44_0.delegate20_0 != null)
							{
								class44_0.delegate20_0(this, new EventArgs3(Enum4.const_1, string_0));
							}
							bool_0 = false;
							return;
						case 7:
							goto IL_00e9;
						case 3:
						case 4:
							goto IL_00f5;
						case 5:
							goto IL_0132;
						case 0:
							goto end_IL_004e;
						case 9:
							return;
						}
						break;
					}
					continue;
				}
				goto IL_0069;
				IL_00f5:
				@class = class57_0;
				string_ = class48_0.string_0;
				string_2 = class48_0.string_1;
				string_3 = class48_0.string_2;
				delegate21_ = class2.method_0;
				goto IL_0132;
				IL_0132:
				Class56.smethod_45(string_, @class, string_2, string_3, delegate21_, destinationArray);
				break;
				IL_0069:
				Class56.smethod_105(class44_0, Enum4.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{F0280EF0-7ADC-4BC9-80E4-1C939C365FDB}");
				destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				goto IL_00e9;
				IL_00e9:
				class2 = new Class47(class44_0);
				goto IL_00f5;
				continue;
				end_IL_004e:
				break;
			}
			bool_0 = class2.bool_0;
		}

		internal static bool wVSSKqX8FWyRup66JXb()
		{
			return true;
		}

		internal static bool w6KGutXTfILVG1Sg5YP()
		{
			return false;
		}
	}

	private class Class47
	{
		private readonly Class44 class44_0;

		public bool bool_0;

		public Class47(Class44 reportSender)
		{
			class44_0 = reportSender;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				Class56.smethod_51(class44_0, Enum4.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				Class56.smethod_139(class44_0, Enum4.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}

		internal static bool DTlXWWXjV2canUpc08Y()
		{
			return true;
		}

		internal static bool cFia9gX6J0PcqaeoZGL()
		{
			return false;
		}
	}

	internal class Class48
	{
		public static Class48 class48_0 = new Class48(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public string BuildFriendlyNumber => string_2;

		public string AppFriendlyName => string_1;

		public string EmailAddress => string_0;

		public Class48(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
		{
			if (!SRdWp3XntZwu6fXPpi8())
			{
				switch (4)
				{
				case 0:
				case 4:
					base._002Ector();
					goto case 1;
				case 1:
				case 3:
					string_0 = emailAddress;
					string_2 = buildFriendlyNumber;
					break;
				case 5:
					return;
				}
			}
			string_1 = appFriendlyName;
		}

		internal static bool kHJsGUXUpAHkcgqRnfP()
		{
			return true;
		}

		internal static bool SRdWp3XntZwu6fXPpi8()
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
			Delegate20 value2 = default(Delegate20);
			while (true)
			{
				Delegate20 @delegate = delegate20_0;
				while (true)
				{
					Delegate20 delegate2 = @delegate;
					int num = 1;
					if (!wrX4uWXIRavDGwoHfK9())
					{
						goto IL_0023;
					}
					goto IL_0032;
					IL_0032:
					switch (num)
					{
					case 1:
						goto IL_0023;
					case 2:
						continue;
					case 0:
					case 4:
						goto end_IL_0055;
					case 6:
						return;
					}
					goto IL_0003;
					IL_0023:
					value2 = (Delegate20)Delegate.Combine(delegate2, value);
					goto IL_0003;
					IL_0003:
					@delegate = Interlocked.CompareExchange(ref delegate20_0, value2, delegate2);
					if ((object)@delegate != delegate2)
					{
						continue;
					}
					num = 6;
					if (t1rpFBXdQTtiS16GtaW())
					{
					}
					goto IL_0032;
					continue;
					end_IL_0055:
					break;
				}
			}
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

	internal static bool wrX4uWXIRavDGwoHfK9()
	{
		return true;
	}

	internal static bool t1rpFBXdQTtiS16GtaW()
	{
		return false;
	}
}
