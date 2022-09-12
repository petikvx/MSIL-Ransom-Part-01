using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns0;
using ns2;
using ns3;
using ns4;
using ns6;

namespace ns7;

internal class Class48
{
	private sealed class Class50
	{
		private readonly Class48 class48_0;

		private readonly byte[] byte_0;

		private readonly Class55 class55_0;

		private readonly Class52 class52_0;

		public bool bool_0 = true;

		[NonSerialized]
		internal static GetString getString_0;

		public Class50(Class48 class48_1, byte[] byte_1, Class55 class55_1, Class52 class52_1)
		{
			class48_0 = class48_1;
			class52_0 = class52_1;
			class55_0 = class55_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == getString_0(107388181))
			{
				class48_0.method_4(Enum8.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes(getString_0(107390176));
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class51 @class = new Class51(class48_0);
				class55_0.method_2(destinationArray, class52_0.method_2(), class52_0.method_1(), class52_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class48_0.delegate4_0 != null)
				{
					class48_0.delegate4_0(this, new EventArgs5(Enum8.const_1, string_0));
				}
				bool_0 = false;
			}
		}

		static Class50()
		{
			Strings.CreateGetStringDelegate(typeof(Class50));
		}
	}

	private sealed class Class51
	{
		private readonly Class48 class48_0;

		public bool bool_0;

		[NonSerialized]
		internal static GetString getString_0;

		public Class51(Class48 class48_1)
		{
			class48_0 = class48_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith(getString_0(107388189)))
			{
				class48_0.method_3(Enum8.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class48_0.method_2(Enum8.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}

		static Class51()
		{
			Strings.CreateGetStringDelegate(typeof(Class51));
		}
	}

	internal sealed class Class52
	{
		public static Class52 class52_0 = new Class52(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class52(string string_3, string string_4, string string_5)
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

	private Delegate4 delegate4_0;

	[NonSerialized]
	internal static GetString getString_0;

	internal unsafe bool method_0(byte[] byte_0, Class52 class52_0)
	{
		void* ptr = stackalloc byte[2];
		byte[] byte_;
		try
		{
			byte_ = Class13.smethod_2(byte_0);
		}
		catch (Exception)
		{
			method_3(Enum8.const_0, Class13.string_0);
			*(sbyte*)ptr = 0;
			goto IL_0020;
		}
		byte[] array = Class53.smethod_0(byte_, getString_0(107389193));
		if (array == null)
		{
			method_3(Enum8.const_0, Class53.string_0);
			((byte*)ptr)[1] = 0;
		}
		else
		{
			method_4(Enum8.const_1);
			Class55 @class = new Class55(getString_0(107388387));
			if (iwebProxy_0 != null)
			{
				@class.method_0(iwebProxy_0);
			}
			Class50 class2 = new Class50(this, array, @class, class52_0);
			@class.method_1(class2.method_0);
			((byte*)ptr)[1] = (class2.bool_0 ? ((byte)1) : ((byte)0));
		}
		goto IL_00b2;
		IL_0020:
		((byte*)ptr)[1] = *(byte*)ptr;
		goto IL_00b2;
		IL_00b2:
		return ((byte*)ptr)[1] != 0;
	}

	[SpecialName]
	public void method_1(Delegate4 delegate4_1)
	{
		Delegate4 @delegate = delegate4_0;
		Delegate4 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate4 value = (Delegate4)Delegate.Combine(delegate2, delegate4_1);
			@delegate = Interlocked.CompareExchange(ref delegate4_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	protected void method_2(Enum8 enum8_0, string string_0, string string_1)
	{
		delegate4_0?.Invoke(this, new EventArgs5(enum8_0, string_0, string_1));
	}

	protected void method_3(Enum8 enum8_0, string string_0)
	{
		method_2(enum8_0, string_0, string.Empty);
	}

	protected void method_4(Enum8 enum8_0)
	{
		method_3(enum8_0, string.Empty);
	}

	static Class48()
	{
		Strings.CreateGetStringDelegate(typeof(Class48));
	}
}
