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

		private readonly Class56 class56_0;

		private readonly Class48 class48_0;

		public bool bool_0;

		public Class46(Class44 reportSender, byte[] encryptedData, Class56 services, Class48 notificationEmailSettings)
		{
			if (RO6jxcZEsmcJjxpWtOm())
			{
			}
			switch (4)
			{
			case 4:
				bool_0 = true;
				goto case 5;
			case 5:
				base._002Ector();
				class44_0 = reportSender;
				goto case 0;
			case 0:
			case 2:
				class48_0 = notificationEmailSettings;
				break;
			case 6:
				return;
			}
			class56_0 = services;
			byte_0 = encryptedData;
		}

		public void method_0(string string_0)
		{
			string errorMessage = default(string);
			while (true)
			{
				if (string_0 == "OK")
				{
					while (true)
					{
						Class58.smethod_45(class44_0, Enum4.const_2);
						byte[] bytes = Encoding.UTF8.GetBytes("{FE10A302-31B7-4EF2-AA46-5131772A0A9D}");
						while (true)
						{
							byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
							Array.Copy(bytes, destinationArray, bytes.Length);
							Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
							Class47 @class = new Class47(class44_0);
							Class56 class2 = class56_0;
							string string_ = class48_0.string_0;
							string string_2 = class48_0.string_1;
							string string_3 = class48_0.string_2;
							Delegate21 delegate21_ = @class.method_0;
							while (true)
							{
								Class58.smethod_65(string_, string_2, string_3, delegate21_, destinationArray, class2);
								while (true)
								{
									bool_0 = @class.bool_0;
									int num = 5;
									if (RO6jxcZEsmcJjxpWtOm())
									{
										return;
									}
									while (true)
									{
										switch (num)
										{
										default:
											num = 6;
											if (!RO6jxcZEsmcJjxpWtOm())
											{
												continue;
											}
											goto IL_013a;
										case 6:
											break;
										case 7:
											goto end_IL_0044;
										case 1:
										case 2:
											goto end_IL_0061;
										case 8:
											goto end_IL_0072;
										case 0:
										case 4:
											goto end_IL_00f3;
										case 5:
											return;
										case 3:
											goto IL_013a;
										case 9:
											return;
										}
										break;
									}
									continue;
									end_IL_0044:
									break;
								}
								continue;
								end_IL_0061:
								break;
							}
							continue;
							end_IL_0072:
							break;
						}
						continue;
						end_IL_00f3:
						break;
					}
					continue;
				}
				errorMessage = string_0;
				if (class44_0.delegate20_0 == null)
				{
					break;
				}
				goto IL_013a;
				IL_013a:
				class44_0.delegate20_0(this, new EventArgs3(Enum4.const_1, errorMessage));
				break;
			}
			bool_0 = false;
		}

		internal static bool u3DChEZmTwMIDLLV4Uo()
		{
			return true;
		}

		internal static bool RO6jxcZEsmcJjxpWtOm()
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
			while (true)
			{
				if (string_0.StartsWith("ERR"))
				{
					if (oowxsRZCarlnlEovepH())
					{
						switch (3)
						{
						case 0:
							continue;
						case 1:
						case 3:
							Class58.smethod_159(class44_0, Enum4.const_2, string_0);
							goto case 2;
						case 2:
						case 4:
							bool_0 = false;
							return;
						case 6:
							return;
						}
						break;
					}
					return;
				}
				Class58.smethod_23(class44_0, Enum4.const_3, string.Empty, string_0);
				break;
			}
			bool_0 = true;
		}

		internal static bool oowxsRZCarlnlEovepH()
		{
			return true;
		}

		internal static bool GTXBhIZBXZB5ZprDW8N()
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
			string_0 = emailAddress;
			string_2 = buildFriendlyNumber;
			string_1 = appFriendlyName;
		}

		internal static bool Pp7A9IZUoHKrkpOZ8D7()
		{
			return true;
		}

		internal static bool a9dY3sZdyWeJfTqSmZj()
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
			while (true)
			{
				Delegate20 @delegate = delegate20_0;
				while (true)
				{
					Delegate20 delegate2 = @delegate;
					Delegate20 value2 = (Delegate20)Delegate.Remove(delegate2, value);
					while (true)
					{
						IL_0037:
						@delegate = Interlocked.CompareExchange(ref delegate20_0, value2, delegate2);
						while ((object)@delegate == delegate2)
						{
							if (I2wNhIZ2GLrO6vwTHcg())
							{
								switch (6)
								{
								case 5:
									goto IL_0037;
								case 1:
								case 2:
									goto end_IL_0030;
								case 0:
								case 3:
									goto end_IL_0047;
								case 6:
									return;
								}
								continue;
							}
							goto IL_0037;
							continue;
							end_IL_0030:
							break;
						}
						break;
					}
					continue;
					end_IL_0047:
					break;
				}
			}
		}
	}

	internal static bool I2wNhIZ2GLrO6vwTHcg()
	{
		return true;
	}

	internal static bool avtlIGZ5tP0cQaWtyH1()
	{
		return false;
	}
}
