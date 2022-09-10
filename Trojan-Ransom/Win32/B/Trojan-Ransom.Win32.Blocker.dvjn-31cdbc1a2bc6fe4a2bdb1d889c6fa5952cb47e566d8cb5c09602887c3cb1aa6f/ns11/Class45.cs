using System;
using System.Net;
using System.Text;
using System.Threading;

namespace ns11;

internal class Class45
{
	internal class Class47
	{
		private readonly Class45 class45_0;

		private readonly byte[] byte_0;

		private readonly Class57 class57_0;

		private readonly Class49 class49_0;

		public bool bool_0 = true;

		public Class47(Class45 reportSender, byte[] encryptedData, Class57 services, Class49 notificationEmailSettings)
		{
			class45_0 = reportSender;
			class49_0 = notificationEmailSettings;
			class57_0 = services;
			byte_0 = encryptedData;
		}

		public void method_0(string string_0)
		{
			if (qoHc2TsR9Rqr2OFqRXM())
			{
			}
			string errorMessage = default(string);
			byte[] bytes = default(byte[]);
			byte[] destinationArray = default(byte[]);
			Class48 @class = default(Class48);
			Class57 class2 = default(Class57);
			string string_ = default(string);
			switch (1)
			{
			case 1:
				if (string_0 == "OK")
				{
					goto case 0;
				}
				errorMessage = string_0;
				if (class45_0.delegate20_0 == null)
				{
					break;
				}
				goto case 5;
			case 0:
				Class21.smethod_11(class45_0, Enum4.const_2);
				bytes = Encoding.UTF8.GetBytes("{516600D7-3050-406A-87C1-F0EB057ED33B}");
				destinationArray = new byte[bytes.Length + byte_0.Length];
				goto case 6;
			case 6:
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				@class = new Class48(class45_0);
				goto case 2;
			case 2:
				class2 = class57_0;
				string_ = class49_0.string_0;
				goto default;
			default:
			{
				string string_2 = class49_0.string_1;
				string string_3 = class49_0.string_2;
				Delegate21 delegate21_ = @class.method_0;
				Class21.smethod_155(string_2, class2, string_3, delegate21_, string_, destinationArray);
				bool_0 = @class.bool_0;
				return;
			}
			case 5:
			case 7:
				class45_0.delegate20_0(this, new EventArgs3(Enum4.const_1, errorMessage));
				break;
			case 8:
				break;
			case 9:
				return;
			}
			bool_0 = false;
		}

		internal static bool waWJBxsFcKpLRjsxyI5()
		{
			return true;
		}

		internal static bool qoHc2TsR9Rqr2OFqRXM()
		{
			return false;
		}
	}

	private class Class48
	{
		private readonly Class45 class45_0;

		public bool bool_0;

		public Class48(Class45 reportSender)
		{
			class45_0 = reportSender;
		}

		public void method_0(string string_0)
		{
			while (string_0.StartsWith("ERR"))
			{
				while (true)
				{
					Class21.smethod_75(class45_0, Enum4.const_2, string_0);
					if (NMVEses2kvXSyXe1ewO())
					{
						switch (3)
						{
						case 1:
						case 4:
							continue;
						default:
							return;
						case 0:
						case 5:
							break;
						case 3:
							bool_0 = false;
							return;
						case 2:
							return;
						case 6:
							return;
						}
						break;
					}
					return;
				}
			}
			Class21.smethod_45(class45_0, Enum4.const_3, string.Empty, string_0);
			bool_0 = true;
		}

		internal static bool NMVEses2kvXSyXe1ewO()
		{
			return true;
		}

		internal static bool BSmCjksJHw8awvXbFkD()
		{
			return false;
		}
	}

	internal class Class49
	{
		public static Class49 class49_0 = new Class49(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public string BuildFriendlyNumber => string_2;

		public string AppFriendlyName => string_1;

		public string EmailAddress => string_0;

		public Class49(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
		{
			string_0 = emailAddress;
			string_2 = buildFriendlyNumber;
			string_1 = appFriendlyName;
		}

		internal static bool A9toZDsoQwRPvHh36oJ()
		{
			return true;
		}

		internal static bool u9iddrs90MEacRJoVOU()
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
			int num = 0;
			if (!kRuspysn8CKibsuY1kh())
			{
				goto IL_0042;
			}
			goto IL_0046;
			IL_0046:
			switch (num)
			{
			case 2:
			case 3:
				break;
			default:
				goto IL_002a;
			case 0:
				goto IL_003b;
			case 1:
			case 5:
				goto IL_0042;
			case 6:
				return;
			}
			goto IL_000f;
			IL_003b:
			Delegate20 @delegate = delegate20_0;
			goto IL_0042;
			IL_0042:
			Delegate20 delegate2 = @delegate;
			goto IL_000f;
			IL_000f:
			Delegate20 value2 = (Delegate20)Delegate.Remove(delegate2, value);
			@delegate = Interlocked.CompareExchange(ref delegate20_0, value2, delegate2);
			goto IL_002a;
			IL_002a:
			if ((object)@delegate != delegate2)
			{
				goto IL_0042;
			}
			num = 6;
			if (!kRuspysn8CKibsuY1kh())
			{
				goto IL_003b;
			}
			goto IL_0046;
		}
	}

	internal static bool kRuspysn8CKibsuY1kh()
	{
		return true;
	}

	internal static bool UXi2R0sWJ4TatIbuD4V()
	{
		return false;
	}
}
