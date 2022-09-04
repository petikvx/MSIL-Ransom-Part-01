using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ns0;

internal class Class22
{
	private sealed class Class24
	{
		private readonly Class22 class22_0;

		private readonly byte[] byte_0;

		private readonly Class33 class33_0;

		private readonly Class26 class26_0;

		public bool bool_0 = true;

		public Class24(Class22 CO_, byte[] CO_, Class33 CO_, Class26 CO_)
		{
			class22_0 = CO_;
			class26_0 = CO_;
			class33_0 = CO_;
			byte_0 = CO_;
		}

		public void method_0(string CO_)
		{
			if (CO_ == Class5.smethod_0(80075))
			{
				class22_0.method_5(Enum0.const_2);
				byte[] bytes = Encoding.UTF8.GetBytes(Class5.smethod_0(80080));
				byte[] array = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, array, bytes.Length);
				Array.Copy(byte_0, 0, array, bytes.Length, byte_0.Length);
				Class25 @class = new Class25(class22_0);
				class33_0.method_2(array, class26_0.method_2(), class26_0.method_1(), class26_0.method_0(), @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (class22_0.delegate1_0 != null)
				{
					class22_0.delegate1_0(this, new EventArgs3(Enum0.const_1, CO_));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class25
	{
		private readonly Class22 class22_0;

		public bool bool_0;

		public Class25(Class22 CO_)
		{
			class22_0 = CO_;
		}

		public void method_0(string CO_)
		{
			if (CO_.StartsWith(Class5.smethod_0(80133)))
			{
				class22_0.method_4(Enum0.const_2, CO_);
				bool_0 = false;
				return;
			}
			class22_0.method_3(Enum0.const_3, string.Empty, CO_);
			if (uint.MaxValue != 0)
			{
				bool_0 = true;
			}
		}
	}

	internal sealed class Class26
	{
		public static Class26 class26_0 = new Class26(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class26(string CO_, string CO_, string CO_)
		{
			string_0 = CO_;
			string_2 = CO_;
			string_1 = CO_;
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

	private Delegate1 delegate1_0;

	public void method_0(IWebProxy CO_)
	{
		iwebProxy_0 = CO_;
	}

	internal bool method_1(byte[] CO_, Class26 CO_)
	{
		byte[] cO_;
		try
		{
			cO_ = Class8.smethod_2(CO_);
		}
		catch (Exception)
		{
			method_4(Enum0.const_0, Class8.string_0);
			return false;
		}
		byte[] array = Class21.smethod_0(cO_, Class5.smethod_0(79700));
		if (array == null)
		{
			method_4(Enum0.const_0, Class21.string_0);
			return false;
		}
		if (0 == 0)
		{
			method_5(Enum0.const_1);
			Class33 @class = new Class33(Class5.smethod_0(80026));
			if (iwebProxy_0 != null)
			{
				@class.method_0(iwebProxy_0);
			}
			Class24 class2 = new Class24(this, array, @class, CO_);
			@class.method_1(class2.method_0);
			return class2.bool_0;
		}
		bool result;
		return result;
	}

	[SpecialName]
	public void method_2(Delegate1 CO_)
	{
		if (false)
		{
			goto IL_000f;
		}
		Delegate1 @delegate;
		if (0 == 0)
		{
			@delegate = delegate1_0;
		}
		goto IL_003d;
		IL_002d:
		Delegate1 delegate2;
		if ((object)@delegate == delegate2)
		{
			goto IL_000f;
		}
		goto IL_003d;
		IL_003d:
		if (7u != 0)
		{
			Delegate1 delegate3 = @delegate;
			if (6u != 0)
			{
				delegate2 = delegate3;
			}
			goto IL_0012;
		}
		goto IL_002d;
		IL_000f:
		if (0 == 0)
		{
			return;
		}
		goto IL_0012;
		IL_0012:
		Delegate1 value = (Delegate1)Delegate.Combine(delegate2, CO_);
		@delegate = Interlocked.CompareExchange(ref delegate1_0, value, delegate2);
		goto IL_002d;
	}

	protected void method_3(Enum0 CO_, string CO_, string CO_)
	{
		Delegate1 @delegate = delegate1_0;
		Delegate1 delegate2 = default(Delegate1);
		if (0 == 0)
		{
			delegate2 = @delegate;
		}
		delegate2?.Invoke(this, new EventArgs3(CO_, CO_, CO_));
	}

	protected void method_4(Enum0 CO_, string CO_)
	{
		method_3(CO_, CO_, string.Empty);
	}

	protected void method_5(Enum0 CO_)
	{
		method_4(CO_, string.Empty);
	}
}
