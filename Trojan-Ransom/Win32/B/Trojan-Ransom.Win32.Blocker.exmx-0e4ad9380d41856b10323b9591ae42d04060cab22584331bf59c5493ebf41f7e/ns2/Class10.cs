using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns0;
using ns4;

namespace ns2;

internal class Class10
{
	private class Class12
	{
		private readonly Class10 class10_0;

		private readonly byte[] byte_0;

		private readonly Class15 class15_0;

		private readonly Class14 class14_0;

		public bool bool_0 = true;

		public Class12(Class10 class10_1, byte[] byte_1, Class15 class15_1, Class14 class14_1)
		{
			class10_0 = class10_1;
			class14_0 = class14_1;
			class15_0 = class15_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				class10_0.method_4(Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes("{0ADE7626-11E1-4738-AA5D-E3E4E0C13035}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class13 @class = new Class13(class10_0);
				class15_0.method_2(destinationArray, class14_0.method_2(), class14_0.method_1(), class14_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class10_0.delegate0_0 != null)
				{
					class10_0.delegate0_0(this, new EventArgs0(Enum0.const_1, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private class Class13
	{
		private readonly Class10 class10_0;

		public bool bool_0;

		public Class13(Class10 class10_1)
		{
			class10_0 = class10_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				class10_0.method_3(Enum0.const_2, string_0);
				bool_0 = false;
			}
			else
			{
				class10_0.method_2(Enum0.const_3, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal class Class14
	{
		public static Class14 class14_0 = new Class14(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class14(string string_3, string string_4, string string_5)
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

	private Delegate0 delegate0_0;

	internal bool method_0(byte[] byte_0, Class14 class14_0)
	{
		byte[] byte_;
		bool result;
		try
		{
			byte_ = Class2.smethod_0(byte_0);
		}
		catch (Exception)
		{
			method_3(Enum0.const_0, Class2.string_0);
			result = false;
			goto IL_001b;
		}
		byte[] array = Class9.smethod_0(byte_, "<RSAKeyValue><Modulus>lXUvhjEAy4bnMesSCGMHhFGFniV9HdqNigR5yKLyZr+TviEXYYq9NlHxDfy77+lLEDgwlHWIis2VMuK49N7V176aTBsvR7qHTdrTvbURkf7dXVWuQl4T+kj2MiCMyKdmVuC+Ox0dRnKZ0Y9b1E+MEgsAJd3ZtVG9PrlKLHwDh08=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			method_3(Enum0.const_0, Class9.string_0);
			return false;
		}
		method_4(Enum0.const_1);
		Class15 @class = new Class15("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class12 class2 = new Class12(this, array, @class, class14_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
		IL_001b:
		return result;
	}

	[SpecialName]
	public void method_1(Delegate0 delegate0_1)
	{
		Delegate0 @delegate = delegate0_0;
		Delegate0 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate0 value = (Delegate0)Delegate.Combine(delegate2, delegate0_1);
			@delegate = Interlocked.CompareExchange(ref delegate0_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	protected void method_2(Enum0 enum0_0, string string_0, string string_1)
	{
		delegate0_0?.Invoke(this, new EventArgs0(enum0_0, string_0, string_1));
	}

	protected void method_3(Enum0 enum0_0, string string_0)
	{
		method_2(enum0_0, string_0, string.Empty);
	}

	protected void method_4(Enum0 enum0_0)
	{
		method_3(enum0_0, string.Empty);
	}
}
