using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns2;
using ns4;
using ns6;
using ns7;
using ns9;

namespace ns0;

internal class Class31
{
	private sealed class Class33
	{
		private readonly Class31 class31_0;

		private readonly byte[] byte_0;

		private readonly Class42 class42_0;

		private readonly Class35 class35_0;

		public bool bool_0 = true;

		public Class33(Class31 class31_1, byte[] byte_1, Class42 class42_1, Class35 class35_1)
		{
			class31_0 = class31_1;
			class35_0 = class35_1;
			class42_0 = class42_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == Class15.smethod_0(949962))
			{
				class31_0.method_5(Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes(Class15.smethod_0(949967));
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class34 @class = new Class34(class31_0);
				class42_0.method_2(destinationArray, class35_0.method_2(), class35_0.method_1(), class35_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class31_0.delegate9_0 != null)
				{
					class31_0.delegate9_0(this, new EventArgs3(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class34
	{
		private readonly Class31 class31_0;

		public bool bool_0;

		public Class34(Class31 class31_1)
		{
			class31_0 = class31_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith(Class15.smethod_0(950020)))
			{
				class31_0.method_4(Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class31_0.method_3(Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class35
	{
		public static Class35 class35_0 = new Class35(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class35(string string_3, string string_4, string string_5)
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

	private Delegate9 delegate9_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	internal bool method_1(byte[] byte_0, Class35 class35_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class18.smethod_2(byte_0);
		}
		catch (Exception)
		{
			method_4(Enum0.const_0, Class18.string_0);
			return false;
		}
		byte[] array = Class30.smethod_0(byte_, Class15.smethod_0(949587));
		if (array == null)
		{
			method_4(Enum0.const_0, Class30.string_0);
			return false;
		}
		method_5(Enum0.const_1);
		Class42 @class = new Class42(Class15.smethod_0(949913));
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class33 class2 = new Class33(this, array, @class, class35_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
	}

	[SpecialName]
	public void method_2(Delegate9 delegate9_1)
	{
		Delegate9 @delegate = delegate9_0;
		Delegate9 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate9 value = (Delegate9)Delegate.Combine(delegate2, delegate9_1);
			@delegate = Interlocked.CompareExchange(ref delegate9_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	protected void method_3(Enum0 enum0_0, string string_0, string string_1)
	{
		delegate9_0?.Invoke(this, new EventArgs3(enum0_0, string_0, string_1));
	}

	protected void method_4(Enum0 enum0_0, string string_0)
	{
		method_3(enum0_0, string_0, string.Empty);
	}

	protected void method_5(Enum0 enum0_0)
	{
		method_4(enum0_0, string.Empty);
	}
}
