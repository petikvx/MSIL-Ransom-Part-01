using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace ns0;

[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
internal sealed class Class2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class3
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			bool flag = default(bool);
			try
			{
				return flag = base.Equals(RuntimeHelpers.GetObjectValue(obj));
			}
			catch (Exception exception_)
			{
				GClass6.smethod_3(exception_, flag, this, obj);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int hashCode = default(int);
			try
			{
				hashCode = base.GetHashCode();
				return hashCode;
			}
			catch (Exception exception_)
			{
				GClass6.smethod_2(exception_, hashCode, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			Type typeFromHandle = default(Type);
			try
			{
				typeFromHandle = typeof(Class3);
				return typeFromHandle;
			}
			catch (Exception exception_)
			{
				GClass6.smethod_2(exception_, typeFromHandle, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			string text = default(string);
			try
			{
				text = base.ToString();
				return text;
			}
			catch (Exception exception_)
			{
				GClass6.smethod_2(exception_, text, this);
				throw;
			}
		}

		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			T val = default(T);
			try
			{
				if (gparam_0 == null)
				{
					val = new T();
					return val;
				}
				val = gparam_0;
				return val;
			}
			catch (Exception exception_)
			{
				GClass6.smethod_2(exception_, val, gparam_0);
				throw;
			}
		}

		private void method_1<T>(ref T gparam_0)
		{
			T val = default(T);
			try
			{
				val = (gparam_0 = default(T));
			}
			catch (Exception exception_)
			{
				GClass6.smethod_3(exception_, val, this, gparam_0);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
			try
			{
			}
			catch (Exception exception_)
			{
				GClass6.smethod_1(exception_, this);
				throw;
			}
		}

		static Class3()
		{
			GClass11.smethod_0();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class4<T> where T : new()
	{
		[ThreadStatic]
		private static T gparam_0;

		[SpecialName]
		internal T method_0()
		{
			T ⴓ = default(T);
			try
			{
				if (Class4<T>.Ⴓ == null)
				{
					Class4<T>.Ⴓ = new T();
				}
				ⴓ = Class4<T>.Ⴓ;
				return ⴓ;
			}
			catch (Exception exception_)
			{
				GClass6.smethod_2(exception_, ⴓ, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
			try
			{
			}
			catch (Exception exception_)
			{
				GClass6.smethod_1(exception_, this);
				throw;
			}
		}

		static Class4()
		{
			GClass11.smethod_0();
		}
	}

	private static readonly Class4<Class1> class4_0;

	private static readonly Class4<Class0> class4_1;

	private static readonly Class4<User> class4_2;

	private static readonly Class4<Class3> class4_3;

	[HelpKeyword("My.Computer")]
	internal static Class1 Class1_0
	{
		get
		{
			Class1 @class = default(Class1);
			try
			{
				@class = class4_0.method_0();
				return @class;
			}
			catch (Exception exception_)
			{
				GClass6.smethod_1(exception_, @class);
				throw;
			}
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class0 Class0_0
	{
		get
		{
			Class0 @class = default(Class0);
			try
			{
				@class = class4_1.method_0();
				return @class;
			}
			catch (Exception exception_)
			{
				GClass6.smethod_1(exception_, @class);
				throw;
			}
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		get
		{
			User val = default(User);
			try
			{
				val = class4_2.method_0();
				return val;
			}
			catch (Exception exception_)
			{
				GClass6.smethod_1(exception_, val);
				throw;
			}
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class3 Class3_0
	{
		get
		{
			Class3 @class = default(Class3);
			try
			{
				@class = class4_3.method_0();
				return @class;
			}
			catch (Exception exception_)
			{
				GClass6.smethod_1(exception_, @class);
				throw;
			}
		}
	}

	static Class2()
	{
		GClass11.smethod_0();
		try
		{
			class4_0 = new Class4<Class1>();
			class4_1 = new Class4<Class0>();
			class4_2 = new Class4<User>();
			class4_3 = new Class4<Class3>();
		}
		catch (Exception exception_)
		{
			GClass6.smethod_0(exception_);
			throw;
		}
	}
}
