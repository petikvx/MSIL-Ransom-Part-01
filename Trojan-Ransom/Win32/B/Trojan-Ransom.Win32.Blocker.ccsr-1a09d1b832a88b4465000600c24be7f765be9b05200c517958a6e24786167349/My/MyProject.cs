using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;

namespace My;

[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class0
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			bool flag = default(bool);
			try
			{
				return flag = base.Equals(HeaderControl.smethod_0(obj, 386, 408));
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, flag, this, obj);
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, hashCode, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			Type type = default(Type);
			try
			{
				type = DoNotEncodeStringsAttribute.smethod_0(typeof(Class0).TypeHandle, 793, 832);
				return type;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, type, this);
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, text, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class0()
		{
			try
			{
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		static Class0()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class1<T> where T : new()
	{
		[ThreadStatic]
		private static T gparam_0;

		[SpecialName]
		internal T method_0()
		{
			T val = default(T);
			try
			{
				if (gparam_0 == null)
				{
					gparam_0 = new T();
				}
				val = gparam_0;
				return val;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, val, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class1()
		{
			try
			{
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		static Class1()
		{
			DESCryptoIndirector.smethod_0();
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
			MyComputer myComputer = default(MyComputer);
			try
			{
				myComputer = class1_0.method_0();
				return myComputer;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, myComputer);
				throw;
			}
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication MyApplication_0
	{
		get
		{
			MyApplication myApplication = default(MyApplication);
			try
			{
				myApplication = class1_1.method_0();
				return myApplication;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, myApplication);
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
				val = class1_2.method_0();
				return val;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, val);
				throw;
			}
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class0 Class0_0
	{
		get
		{
			Class0 @class = default(Class0);
			try
			{
				@class = class1_3.method_0();
				return @class;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, @class);
				throw;
			}
		}
	}

	static MyProject()
	{
		DESCryptoIndirector.smethod_0();
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
