using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Class18
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class19
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm1 gform1_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm4 gform4_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm5 gform5_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm0 gform0_0;

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class19()
		{
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if (gparam_0 == null || ((Control)gparam_0).get_IsDisposed())
			{
				if (hashtable_0 != null)
				{
					if (hashtable_0.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString(Class16.smethod_0(-561826762), new string[0]));
					}
				}
				else
				{
					hashtable_0 = new Hashtable();
				}
				hashtable_0.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError((Exception)ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString(Class16.smethod_0(-561826727), new string[1] { ex.InnerException!.Message });
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					hashtable_0.Remove(typeof(T));
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return typeof(Class19);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		public GForm1 method_2()
		{
			gform1_0 = smethod_0(gform1_0);
			return gform1_0;
		}

		[DebuggerHidden]
		public GForm4 method_3()
		{
			gform4_0 = smethod_0(gform4_0);
			return gform4_0;
		}

		[DebuggerHidden]
		public GForm5 method_4()
		{
			gform5_0 = smethod_0(gform5_0);
			return gform5_0;
		}

		[DebuggerHidden]
		public GForm0 method_5()
		{
			gform0_0 = smethod_0(gform0_0);
			return gform0_0;
		}

		[DebuggerHidden]
		public void method_6(GForm1 gform1_1)
		{
			if (gform1_1 != gform1_0)
			{
				if (gform1_1 != null)
				{
					throw new ArgumentException(Class16.smethod_0(-561826694));
				}
				method_0(ref gform1_0);
			}
		}

		[DebuggerHidden]
		public void method_7(GForm4 gform4_1)
		{
			if (gform4_1 != gform4_0)
			{
				if (gform4_1 != null)
				{
					throw new ArgumentException(Class16.smethod_0(-561826694));
				}
				method_0(ref gform4_0);
			}
		}

		[DebuggerHidden]
		public void method_8(GForm5 gform5_1)
		{
			if (gform5_1 != gform5_0)
			{
				if (gform5_1 != null)
				{
					throw new ArgumentException(Class16.smethod_0(-561826694));
				}
				method_0(ref gform5_0);
			}
		}

		[DebuggerHidden]
		public void method_9(GForm0 gform0_1)
		{
			if (gform0_1 != gform0_0)
			{
				if (gform0_1 != null)
				{
					throw new ArgumentException(Class16.smethod_0(-561826694));
				}
				method_0(ref gform0_0);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class20
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class20()
		{
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
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
			return typeof(Class20);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
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
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class21<T> where T : new()
	{
		[ThreadStatic]
		private static T gparam_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class21()
		{
		}

		[DebuggerHidden]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}
	}

	private static readonly Class21<Class14> class21_0 = new Class21<Class14>();

	private static readonly Class21<Class15> class21_1 = new Class21<Class15>();

	private static readonly Class21<User> class21_2 = new Class21<User>();

	private static Class21<Class19> class21_3 = new Class21<Class19>();

	private static readonly Class21<Class20> class21_4 = new Class21<Class20>();

	[DebuggerHidden]
	internal static Class14 smethod_0()
	{
		return class21_0.method_0();
	}

	[DebuggerHidden]
	internal static Class15 smethod_1()
	{
		return class21_1.method_0();
	}

	[DebuggerHidden]
	internal static User smethod_2()
	{
		return class21_2.method_0();
	}

	[DebuggerHidden]
	internal static Class19 smethod_3()
	{
		return class21_3.method_0();
	}

	[DebuggerHidden]
	internal static Class20 smethod_4()
	{
		return class21_4.method_0();
	}
}
