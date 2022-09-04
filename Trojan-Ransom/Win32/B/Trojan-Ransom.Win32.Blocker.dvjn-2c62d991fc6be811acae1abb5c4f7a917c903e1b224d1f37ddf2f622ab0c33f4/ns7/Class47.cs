using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns0;
using ns10;
using ns3;
using ns5;
using ns9;

namespace ns7;

internal class Class47
{
	private sealed class Class49
	{
		private readonly Class47 class47_0;

		private readonly byte[] byte_0;

		private readonly Class52 class52_0;

		private readonly Class51 class51_0;

		public bool bool_0 = true;

		public Class49(Class47 class47_1, byte[] byte_1, Class52 class52_1, Class51 class51_1)
		{
			try
			{
				class47_0 = class47_1;
				class51_0 = class51_1;
				class52_0 = class52_1;
				byte_0 = byte_1;
			}
			catch (Exception exception_)
			{
				Class38.smethod_5(exception_, this, class47_1, byte_1, class52_1, class51_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			byte[] bytes = default(byte[]);
			byte[] array = default(byte[]);
			Class50 @class = default(Class50);
			string text = default(string);
			try
			{
				if (string_0 == Class15.smethod_0(949962))
				{
					class47_0.method_4(Enum2.const_2);
					bytes = Encoding.UTF8.GetBytes(Class15.smethod_0(949967));
					array = new byte[bytes.Length + byte_0.Length];
					Array.Copy(bytes, array, bytes.Length);
					Array.Copy(byte_0, 0, array, bytes.Length, byte_0.Length);
					@class = new Class50(class47_0);
					class52_0.method_2(array, class51_0.method_2(), class51_0.method_1(), class51_0.method_0(), @class.method_0);
					bool_0 = @class.bool_0;
				}
				else
				{
					text = string_0;
					if (class47_0.delegate11_0 != null)
					{
						class47_0.delegate11_0(this, new EventArgs4(Enum2.const_1, text));
					}
					bool_0 = false;
				}
			}
			catch (Exception exception_)
			{
				Class38.smethod_6(exception_, bytes, array, @class, text, this, string_0);
				throw;
			}
		}
	}

	private sealed class Class50
	{
		private readonly Class47 class47_0;

		public bool bool_0;

		public Class50(Class47 class47_1)
		{
			try
			{
				class47_0 = class47_1;
			}
			catch (Exception exception_)
			{
				Class38.smethod_2(exception_, this, class47_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			try
			{
				if (string_0.StartsWith(Class15.smethod_0(950020)))
				{
					class47_0.method_3(Enum2.const_2, string_0);
					bool_0 = false;
				}
				else
				{
					class47_0.method_2(Enum2.const_3, string.Empty, string_0);
					bool_0 = true;
				}
			}
			catch (Exception exception_)
			{
				Class38.smethod_2(exception_, this, string_0);
				throw;
			}
		}
	}

	internal sealed class Class51
	{
		public static Class51 class51_0;

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class51(string string_3, string string_4, string string_5)
		{
			try
			{
				string_0 = string_3;
				string_2 = string_5;
				string_1 = string_4;
			}
			catch (Exception exception_)
			{
				Class38.smethod_4(exception_, this, string_3, string_4, string_5);
				throw;
			}
		}

		[SpecialName]
		public string method_0()
		{
			try
			{
				return string_2;
			}
			catch (Exception exception_)
			{
				Class38.smethod_1(exception_, this);
				throw;
			}
		}

		[SpecialName]
		public string method_1()
		{
			try
			{
				return string_1;
			}
			catch (Exception exception_)
			{
				Class38.smethod_1(exception_, this);
				throw;
			}
		}

		[SpecialName]
		public string method_2()
		{
			try
			{
				return string_0;
			}
			catch (Exception exception_)
			{
				Class38.smethod_1(exception_, this);
				throw;
			}
		}

		static Class51()
		{
			try
			{
				class51_0 = new Class51(null, null, null);
			}
			catch (Exception exception_)
			{
				Class38.smethod_0(exception_);
				throw;
			}
		}
	}

	private IWebProxy iwebProxy_0;

	private Delegate11 delegate11_0;

	internal bool method_0(byte[] byte_0, Class51 class51_0)
	{
		byte[] array = default(byte[]);
		bool flag = default(bool);
		byte[] array2 = default(byte[]);
		Class52 @class = default(Class52);
		Class49 class2 = default(Class49);
		try
		{
			try
			{
				array = Class18.smethod_2(byte_0);
			}
			catch (Exception)
			{
				method_3(Enum2.const_0, Class18.string_0);
				flag = false;
				return flag;
			}
			array2 = Class46.smethod_0(array, Class15.smethod_0(949587));
			if (array2 == null)
			{
				method_3(Enum2.const_0, Class46.string_0);
				return false;
			}
			method_4(Enum2.const_1);
			@class = new Class52(Class15.smethod_0(949913));
			if (iwebProxy_0 != null)
			{
				@class.method_0(iwebProxy_0);
			}
			class2 = new Class49(this, array2, @class, class51_0);
			@class.method_1(class2.method_0);
			return class2.bool_0;
		}
		catch (Exception exception_)
		{
			Class38.smethod_8(exception_, array, array2, @class, class2, flag, this, byte_0, class51_0);
			throw;
		}
	}

	[SpecialName]
	public void method_1(Delegate11 delegate11_1)
	{
		Delegate11 @delegate = default(Delegate11);
		Delegate11 delegate2 = default(Delegate11);
		Delegate11 delegate3 = default(Delegate11);
		try
		{
			@delegate = delegate11_0;
			do
			{
				delegate2 = @delegate;
				delegate3 = (Delegate11)Delegate.Combine(delegate2, delegate11_1);
				@delegate = Interlocked.CompareExchange(ref delegate11_0, delegate3, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		catch (Exception exception_)
		{
			Class38.smethod_5(exception_, @delegate, delegate2, delegate3, this, delegate11_1);
			throw;
		}
	}

	protected void method_2(Enum2 enum2_0, string string_0, string string_1)
	{
		Delegate11 @delegate = default(Delegate11);
		try
		{
			@delegate = delegate11_0;
			@delegate?.Invoke(this, new EventArgs4(enum2_0, string_0, string_1));
		}
		catch (Exception exception_)
		{
			Class38.smethod_5(exception_, @delegate, this, enum2_0, string_0, string_1);
			throw;
		}
	}

	protected void method_3(Enum2 enum2_0, string string_0)
	{
		try
		{
			method_2(enum2_0, string_0, string.Empty);
		}
		catch (Exception exception_)
		{
			Class38.smethod_3(exception_, this, enum2_0, string_0);
			throw;
		}
	}

	protected void method_4(Enum2 enum2_0)
	{
		try
		{
			method_3(enum2_0, string.Empty);
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, this, enum2_0);
			throw;
		}
	}
}
