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
using SmartAssembly.SmartUsageCore;

namespace My;

[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class0
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			bool flag2 = default(bool);
			bool flag = default(bool);
			try
			{
				try
				{
					flag2 = (flag = base.Equals(SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_0(obj, 426, 498)));
					return flag2;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, flag, this, obj);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException4(exception2, flag, flag2, this, obj);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int hashCode = default(int);
			int num = default(int);
			try
			{
				try
				{
					hashCode = base.GetHashCode();
					num = hashCode;
					return num;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, hashCode, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, hashCode, num, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			Type type = default(Type);
			Type type2 = default(Type);
			try
			{
				try
				{
					type = SendingReportFeedbackEventArgs1.smethod_0(typeof(Class0).TypeHandle, 687, 724);
					type2 = type;
					return type2;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, type, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, type, type2, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			string text = default(string);
			string text2 = default(string);
			try
			{
				try
				{
					text = base.ToString();
					text2 = text;
					return text2;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, text, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, text, text2, this);
				throw;
			}
		}

		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			int num = default(int);
			T val = default(T);
			T val2 = default(T);
			try
			{
				try
				{
					num = 5;
					if (gparam_0 == null)
					{
						val = new T();
						num = 0;
					}
					else
					{
						val = gparam_0;
						num = 0;
					}
					val2 = val;
					return val2;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, val, gparam_0);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException4(exception2, val, val2, num, gparam_0);
				throw;
			}
		}

		private void method_1<T>(ref T gparam_0)
		{
			T val = default(T);
			try
			{
				try
				{
					val = (gparam_0 = default(T));
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, val, this, gparam_0);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, val, this, gparam_0);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class0()
		{
			try
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
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException1(exception2, this);
				throw;
			}
		}

		static Class0()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
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
			int num = default(int);
			T val = default(T);
			T val2 = default(T);
			try
			{
				try
				{
					num = 2;
					if (gparam_0 == null)
					{
						gparam_0 = new T();
						num = 3;
					}
					val = gparam_0;
					val2 = val;
					return val2;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, val, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException4(exception2, val, val2, num, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class1()
		{
			try
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
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException1(exception2, this);
				throw;
			}
		}

		static Class1()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
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
			MyComputer myComputer2 = default(MyComputer);
			try
			{
				try
				{
					myComputer = class1_0.method_0();
					myComputer2 = myComputer;
					return myComputer2;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, myComputer);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, myComputer, myComputer2);
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
			MyApplication myApplication2 = default(MyApplication);
			try
			{
				try
				{
					myApplication = class1_1.method_0();
					myApplication2 = myApplication;
					return myApplication2;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, myApplication);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, myApplication, myApplication2);
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
			User val2 = default(User);
			try
			{
				try
				{
					val = class1_2.method_0();
					val2 = val;
					return val2;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, val);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, val, val2);
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
			Class0 class2 = default(Class0);
			try
			{
				try
				{
					@class = class1_3.method_0();
					class2 = @class;
					return class2;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, @class);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, @class, class2);
				throw;
			}
		}
	}

	static MyProject()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
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
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException0(exception2);
			throw;
		}
	}
}
