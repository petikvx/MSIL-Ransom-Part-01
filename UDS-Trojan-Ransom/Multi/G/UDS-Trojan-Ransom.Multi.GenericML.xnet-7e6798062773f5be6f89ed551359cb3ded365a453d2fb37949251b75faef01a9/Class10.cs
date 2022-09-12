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

[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Class10
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class11
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm1 gform1_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm0 gform0_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class11()
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
						throw new InvalidOperationException(Utils.GetResourceString(Class7.smethod_0(-1566193356), new string[0]));
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
					string resourceString = Utils.GetResourceString(Class7.smethod_0(-1566193175), new string[1] { ex.InnerException!.Message });
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
			return typeof(Class11);
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
		public GForm0 method_3()
		{
			gform0_0 = smethod_0(gform0_0);
			return gform0_0;
		}

		[DebuggerHidden]
		public void method_4(GForm1 gform1_1)
		{
			if (gform1_1 != gform1_0)
			{
				if (gform1_1 != null)
				{
					throw new ArgumentException(Class7.smethod_0(-1566193208));
				}
				method_0(ref gform1_0);
			}
		}

		[DebuggerHidden]
		public void method_5(GForm0 gform0_1)
		{
			if (gform0_1 != gform0_0)
			{
				if (gform0_1 != null)
				{
					throw new ArgumentException(Class7.smethod_0(-1566193208));
				}
				method_0(ref gform0_0);
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class12
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class12()
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
			return typeof(Class12);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class13<T> where T : new()
	{
		[ThreadStatic]
		private static T gparam_0;

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class13()
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

	private static readonly Class13<Class23> class13_0 = new Class13<Class23>();

	private static readonly Class13<Class6> class13_1 = new Class13<Class6>();

	private static readonly Class13<User> class13_2 = new Class13<User>();

	private static Class13<Class11> class13_3 = new Class13<Class11>();

	private static readonly Class13<Class12> class13_4 = new Class13<Class12>();

	[DebuggerHidden]
	internal static Class23 smethod_0()
	{
		return class13_0.method_0();
	}

	[DebuggerHidden]
	internal static Class6 smethod_1()
	{
		return class13_1.method_0();
	}

	[DebuggerHidden]
	internal static User smethod_2()
	{
		return class13_2.method_0();
	}

	[DebuggerHidden]
	internal static Class11 smethod_3()
	{
		return class13_3.method_0();
	}

	[DebuggerHidden]
	internal static Class12 smethod_4()
	{
		return class13_4.method_0();
	}
}
