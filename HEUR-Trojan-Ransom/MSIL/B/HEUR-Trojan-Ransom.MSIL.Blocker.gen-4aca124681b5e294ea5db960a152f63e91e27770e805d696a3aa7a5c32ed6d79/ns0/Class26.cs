using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns1;
using ns11;
using ns2;
using ns4;
using ns7;

namespace ns0;

internal class Class26
{
	private sealed class Class28
	{
		private readonly Class26 class26_0;

		private readonly byte[] byte_0;

		private readonly Class36 class36_0;

		private readonly Class30 class30_0;

		public bool bool_0 = true;

		[NonSerialized]
		internal static GetString getString_0;

		public Class28(Class26 class26_1, byte[] byte_1, Class36 class36_1, Class30 class30_1)
		{
			class26_0 = class26_1;
			class30_0 = class30_1;
			class36_0 = class36_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == getString_0(107388009))
			{
				class26_0.method_5(Enum6.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes(getString_0(107390004));
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class29 @class = new Class29(class26_0);
				class36_0.method_2(destinationArray, class30_0.method_2(), class30_0.method_1(), class30_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class26_0.delegate2_0 != null)
				{
					class26_0.delegate2_0(this, new EventArgs4(Enum6.const_1, string_0));
				}
				bool_0 = false;
			}
		}

		static Class28()
		{
			Strings.CreateGetStringDelegate(typeof(Class28));
		}
	}

	private sealed class Class29
	{
		private readonly Class26 class26_0;

		public bool bool_0;

		[NonSerialized]
		internal static GetString getString_0;

		public Class29(Class26 class26_1)
		{
			class26_0 = class26_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith(getString_0(107388017)))
			{
				class26_0.method_4(Enum6.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class26_0.method_3(Enum6.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}

		static Class29()
		{
			Strings.CreateGetStringDelegate(typeof(Class29));
		}
	}

	internal sealed class Class30
	{
		public static Class30 class30_0 = new Class30(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class30(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
		}

		[SpecialName]
		public string method_0()
		{
			return string_2;
		}

		[SpecialName]
		public string method_1()
		{
			return string_1;
		}

		[SpecialName]
		public string method_2()
		{
			return string_0;
		}
	}

	private IWebProxy iwebProxy_0;

	private Delegate2 delegate2_0;

	[NonSerialized]
	internal static GetString getString_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	internal bool method_1(byte[] byte_0, Class30 class30_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class13.smethod_2(byte_0);
		}
		catch (Exception)
		{
			method_4(Enum6.const_0, Class13.string_0);
			return false;
		}
		byte[] array = Class25.smethod_0(byte_, getString_0(107389021));
		if (array == null)
		{
			method_4(Enum6.const_0, Class25.string_0);
			return false;
		}
		method_5(Enum6.const_1);
		Class36 @class = new Class36(getString_0(107388215));
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class28 class2 = new Class28(this, array, @class, class30_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
	}

	[SpecialName]
	public void method_2(Delegate2 delegate2_1)
	{
		Delegate2 @delegate = delegate2_0;
		Delegate2 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate2 value = (Delegate2)Delegate.Combine(delegate2, delegate2_1);
			@delegate = Interlocked.CompareExchange(ref delegate2_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	protected void method_3(Enum6 enum6_0, string string_0, string string_1)
	{
		delegate2_0?.Invoke(this, new EventArgs4(enum6_0, string_0, string_1));
	}

	protected void method_4(Enum6 enum6_0, string string_0)
	{
		method_3(enum6_0, string_0, string.Empty);
	}

	protected void method_5(Enum6 enum6_0)
	{
		method_4(enum6_0, string.Empty);
	}

	static Class26()
	{
		Strings.CreateGetStringDelegate(typeof(Class26));
	}
}
