using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Class1
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class2
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm2 gform2_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm1 gform1_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm6 gform6_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm0 gform0_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm3 gform3_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm4 gform4_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm5 gform5_0;

		public GForm2 GForm2_0
		{
			[DebuggerHidden]
			get
			{
				gform2_0 = smethod_0(gform2_0);
				return gform2_0;
			}
			[DebuggerHidden]
			set
			{
				if (value != gform2_0)
				{
					if (value != null)
					{
						throw Class2.smethod_13("Property can only be set to Nothing");
					}
					method_0(ref gform2_0);
				}
			}
		}

		public GForm1 GForm1_0
		{
			[DebuggerHidden]
			get
			{
				gform1_0 = smethod_0(gform1_0);
				return gform1_0;
			}
			[DebuggerHidden]
			set
			{
				if (value != gform1_0)
				{
					if (value != null)
					{
						throw Class2.smethod_13("Property can only be set to Nothing");
					}
					method_0(ref gform1_0);
				}
			}
		}

		public GForm6 GForm6_0
		{
			[DebuggerHidden]
			get
			{
				gform6_0 = smethod_0(gform6_0);
				return gform6_0;
			}
			[DebuggerHidden]
			set
			{
				if (value != gform6_0)
				{
					if (value != null)
					{
						throw Class2.smethod_13("Property can only be set to Nothing");
					}
					method_0(ref gform6_0);
				}
			}
		}

		public GForm0 GForm0_0
		{
			[DebuggerHidden]
			get
			{
				gform0_0 = smethod_0(gform0_0);
				return gform0_0;
			}
			[DebuggerHidden]
			set
			{
				if (value != gform0_0)
				{
					if (value != null)
					{
						throw Class2.smethod_13("Property can only be set to Nothing");
					}
					method_0(ref gform0_0);
				}
			}
		}

		public GForm3 GForm3_0
		{
			[DebuggerHidden]
			get
			{
				gform3_0 = smethod_0(gform3_0);
				return gform3_0;
			}
			[DebuggerHidden]
			set
			{
				if (value != gform3_0)
				{
					if (value != null)
					{
						throw Class2.smethod_13("Property can only be set to Nothing");
					}
					method_0(ref gform3_0);
				}
			}
		}

		public GForm4 GForm4_0
		{
			[DebuggerHidden]
			get
			{
				gform4_0 = smethod_0(gform4_0);
				return gform4_0;
			}
			[DebuggerHidden]
			set
			{
				if (value != gform4_0)
				{
					if (value != null)
					{
						throw Class2.smethod_13("Property can only be set to Nothing");
					}
					method_0(ref gform4_0);
				}
			}
		}

		public GForm5 GForm5_0
		{
			[DebuggerHidden]
			get
			{
				gform5_0 = smethod_0(gform5_0);
				return gform5_0;
			}
			[DebuggerHidden]
			set
			{
				if (value != gform5_0)
				{
					if (value != null)
					{
						throw Class2.smethod_13("Property can only be set to Nothing");
					}
					method_0(ref gform5_0);
				}
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if (gparam_0 == null || ((Control)gparam_0).get_IsDisposed())
			{
				if (hashtable_0 != null)
				{
					if (Class2.smethod_2(hashtable_0, (object)Class2.smethod_1(typeof(T).TypeHandle)))
					{
						throw Class2.smethod_4(Class2.smethod_3("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					hashtable_0 = Class2.smethod_5();
				}
				Class2.smethod_6(hashtable_0, (object)Class2.smethod_1(typeof(T).TypeHandle), (object)null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException exception_) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					Class2.smethod_7((Exception)exception_);
					return Class2.smethod_8((Exception)exception_) != null;
				}).Invoke())
				{
					string string_ = Class2.smethod_3("WinForms_SeeInnerException", new string[1] { Class2.smethod_9(Class2.smethod_8((Exception)exception_)) });
					throw Class2.smethod_10(string_, Class2.smethod_8((Exception)exception_));
				}
				finally
				{
					Class2.smethod_11(hashtable_0, (object)Class2.smethod_1(typeof(T).TypeHandle));
				}
			}
			return gparam_0;
		}

		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class2()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		bool object.Equals(object obj)
		{
			return this.method_2(Class2.smethod_12(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		int object.GetHashCode()
		{
			return this.method_3();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return Class2.smethod_1(typeof(Class2).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			return this.method_4();
		}

		static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static bool smethod_2(Hashtable hashtable_1, object object_0)
		{
			return hashtable_1.ContainsKey(object_0);
		}

		static string smethod_3(string string_0, string[] string_1)
		{
			return Utils.GetResourceString(string_0, string_1);
		}

		static InvalidOperationException smethod_4(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static Hashtable smethod_5()
		{
			return new Hashtable();
		}

		static void smethod_6(Hashtable hashtable_1, object object_0, object object_1)
		{
			hashtable_1.Add(object_0, object_1);
		}

		static void smethod_7(Exception exception_0)
		{
			ProjectData.SetProjectError(exception_0);
		}

		static Exception smethod_8(Exception exception_0)
		{
			return exception_0.InnerException;
		}

		static string smethod_9(Exception exception_0)
		{
			return exception_0.Message;
		}

		static InvalidOperationException smethod_10(string string_0, Exception exception_0)
		{
			return new InvalidOperationException(string_0, exception_0);
		}

		static void smethod_11(Hashtable hashtable_1, object object_0)
		{
			hashtable_1.Remove(object_0);
		}

		static object smethod_12(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		bool method_2(object object_0)
		{
			return base.Equals(object_0);
		}

		int method_3()
		{
			return base.GetHashCode();
		}

		string method_4()
		{
			return base.ToString();
		}

		static ArgumentException smethod_13(string string_0)
		{
			return new ArgumentException(string_0);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class3
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		bool object.Equals(object obj)
		{
			return this.method_2(Class3.smethod_1(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		int object.GetHashCode()
		{
			return this.method_3();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return Class3.smethod_2(typeof(Class3).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		string object.ToString()
		{
			return this.method_4();
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			if (gparam_0 == null)
			{
				return new T();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
		}

		static object smethod_1(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		bool method_2(object object_0)
		{
			return base.Equals(object_0);
		}

		int method_3()
		{
			return base.GetHashCode();
		}

		static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		string method_4()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class4<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;

		internal T Prop_0
		{
			[DebuggerHidden]
			get
			{
				if (gparam_0 == null)
				{
					gparam_0 = new T();
				}
				return gparam_0;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
		}
	}

	private static readonly Class4<Class0> class4_0 = new Class4<Class0>();

	private static readonly Class4<Form0> class4_1 = new Class4<Form0>();

	private static readonly Class4<User> class4_2 = new Class4<User>();

	private static Class4<Class2> class4_3 = new Class4<Class2>();

	private static readonly Class4<Class3> class4_4 = new Class4<Class3>();

	[HelpKeyword("My.Computer")]
	internal static Class0 Class0_0
	{
		[DebuggerHidden]
		get
		{
			return class4_0.Prop_0;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			return class4_1.Prop_0;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class4_2.Prop_0;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class2 Class2_0
	{
		[DebuggerHidden]
		get
		{
			return class4_3.Prop_0;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			return class4_4.Prop_0;
		}
	}
}
