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
using ns0;

namespace ___codefort;

[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
internal sealed class Class1
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class2
	{
		public GForm0 gform0_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		public GForm0 GForm0_0
		{
			get
			{
				gform0_0 = smethod_0(gform0_0);
				return gform0_0;
			}
			set
			{
				if (value != gform0_0)
				{
					if (value != null)
					{
						throw new ArgumentException(Class9.smethod_0(1));
					}
					method_0(ref gform0_0);
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class2()
		{
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T Instance) where T : Form, new()
		{
			if (Instance != null && !((Control)Instance).get_IsDisposed())
			{
				return Instance;
			}
			if (hashtable_0 != null)
			{
				if (hashtable_0.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString(Class9.smethod_0(72), Class16.smethod_0(Class7.smethod_0(20))));
				}
			}
			else
			{
				hashtable_0 = new Hashtable();
			}
			hashtable_0.Add(typeof(T), Class12.object_0);
			TargetInvocationException ex = default(TargetInvocationException);
			try
			{
				return new T();
			}
			catch (object obj) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				TargetInvocationException obj2 = obj as TargetInvocationException;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
				if (obj2 == null)
				{
					result = Class7.smethod_0(24);
				}
				else
				{
					ex = obj2;
					ProjectData.SetProjectError((Exception)obj2);
					result = ((((((ex.InnerException == Class18.exception_0) ? 1 : 0) == Class7.smethod_0(28)) ? 1u : 0u) > (uint)Class7.smethod_0(32)) ? 1 : 0);
				}
				return (byte)result != 0;
			}).Invoke())
			{
				string text = Class9.smethod_0(129);
				string[] array = Class16.smethod_0(Class7.smethod_0(36));
				array[Class7.smethod_0(40)] = ex.InnerException!.Message;
				string resourceString = Utils.GetResourceString(text, array);
				throw new InvalidOperationException(resourceString, ex.InnerException);
			}
			finally
			{
				hashtable_0.Remove(typeof(T));
			}
		}

		[DebuggerHidden]
		private void method_0<T>(ref T instance) where T : Form
		{
			((Component)instance).Dispose();
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object object_0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(object_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return typeof(Class2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class3()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object object_0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(object_0));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void method_1<T>(ref T instance)
		{
			instance = default(T);
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class4<T1> where T1 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T1 gparam_0;

		internal T1 Prop_0
		{
			[DebuggerHidden]
			get
			{
				if (gparam_0 == null)
				{
					gparam_0 = new T1();
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

	private static readonly Class4<MyApplication> class4_1 = new Class4<MyApplication>();

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
	internal static MyApplication MyApplication_0
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
