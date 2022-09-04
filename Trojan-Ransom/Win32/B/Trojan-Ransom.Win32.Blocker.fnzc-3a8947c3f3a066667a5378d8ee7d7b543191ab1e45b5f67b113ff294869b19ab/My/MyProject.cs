using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "10.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class0
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			try
			{
				return base.Equals(SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(obj, 889, 851));
			}
			catch (Exception exception)
			{
				bool flag = default(bool);
				StackFrameHelper.CreateException3(exception, flag, this, obj);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			try
			{
				return base.GetHashCode();
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			try
			{
				return Class26.smethod_1(typeof(Class0).TypeHandle, 480, 452);
			}
			catch (Exception exception)
			{
				Type o = default(Type);
				StackFrameHelper.CreateException2(exception, o, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			try
			{
				return base.ToString();
			}
			catch (Exception exception)
			{
				string o = default(string);
				StackFrameHelper.CreateException2(exception, o, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class0()
		{
		}

		[SecuritySafeCritical]
		static Class0()
		{
			Class32.smethod_1();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class1<T> where T : new()
	{
		[ThreadStatic]
		private static T gparam_0;

		[SpecialName]
		internal T method_0()
		{
			try
			{
				if (gparam_0 == null)
				{
					gparam_0 = new T();
				}
				return gparam_0;
			}
			catch (Exception exception)
			{
				T val = default(T);
				StackFrameHelper.CreateException2(exception, val, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class1()
		{
		}

		[SecuritySafeCritical]
		static Class1()
		{
			Class32.smethod_1();
		}
	}

	private static readonly Class1<MyComputer> class1_0;

	private static readonly Class1<MyApplication> class1_1;

	private static readonly Class1<User> class1_2;

	private static readonly Class1<Class0> class1_3;

	[HelpKeyword("My.Computer")]
	internal static MyComputer MyComputer_0
	{
		get
		{
			try
			{
				return class1_0.method_0();
			}
			catch (Exception exception)
			{
				MyComputer o = default(MyComputer);
				StackFrameHelper.CreateException1(exception, o);
				throw;
			}
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication MyApplication_0
	{
		get
		{
			try
			{
				return class1_1.method_0();
			}
			catch (Exception exception)
			{
				MyApplication o = default(MyApplication);
				StackFrameHelper.CreateException1(exception, o);
				throw;
			}
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		get
		{
			try
			{
				return class1_2.method_0();
			}
			catch (Exception exception)
			{
				User o = default(User);
				StackFrameHelper.CreateException1(exception, o);
				throw;
			}
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class0 Class0_0
	{
		get
		{
			try
			{
				return class1_3.method_0();
			}
			catch (Exception exception)
			{
				Class0 o = default(Class0);
				StackFrameHelper.CreateException1(exception, o);
				throw;
			}
		}
	}

	[SecuritySafeCritical]
	static MyProject()
	{
		Class32.smethod_1();
		try
		{
			class1_0 = new Class1<MyComputer>();
			class1_1 = new Class1<MyApplication>();
			class1_2 = new Class1<User>();
			class1_3 = new Class1<Class0>();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
