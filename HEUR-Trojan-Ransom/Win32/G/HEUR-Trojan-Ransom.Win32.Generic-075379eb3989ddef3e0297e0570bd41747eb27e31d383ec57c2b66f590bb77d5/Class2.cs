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

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "10.0.0.0")]
internal sealed class Class2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class3
	{
		public global::Launcher launcher_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		[SpecialName]
		public global::Launcher method_0()
		{
			launcher_0 = Create__Instance__(launcher_0);
			return launcher_0;
		}

		[SpecialName]
		public void method_1(global::Launcher launcher_1)
		{
			if (launcher_1 != launcher_0)
			{
				if (launcher_1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Dispose__Instance__(ref launcher_0);
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance != null && !((Control)Instance).get_IsDisposed())
			{
				return Instance;
			}
			if (hashtable_0 != null)
			{
				if (hashtable_0.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
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
				string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message });
				throw new InvalidOperationException(resourceString, ex.InnerException);
			}
			finally
			{
				hashtable_0.Remove(typeof(T));
			}
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			((Component)instance).Dispose();
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class3()
		{
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
		internal Type method_2()
		{
			return typeof(Class3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class4
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
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
			return typeof(Class4);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T gparam_0;

		[SpecialName]
		[DebuggerHidden]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<Class1> threadSafeObjectProvider_0 = new ThreadSafeObjectProvider<Class1>();

	private static readonly ThreadSafeObjectProvider<Class0> threadSafeObjectProvider_1 = new ThreadSafeObjectProvider<Class0>();

	private static readonly ThreadSafeObjectProvider<User> threadSafeObjectProvider_2 = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<Class3> threadSafeObjectProvider_3 = new ThreadSafeObjectProvider<Class3>();

	private static readonly ThreadSafeObjectProvider<Class4> threadSafeObjectProvider_4 = new ThreadSafeObjectProvider<Class4>();

	[SpecialName]
	[DebuggerHidden]
	internal static Class1 smethod_0()
	{
		return threadSafeObjectProvider_0.method_0();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static Class0 smethod_1()
	{
		return threadSafeObjectProvider_1.method_0();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static User smethod_2()
	{
		return threadSafeObjectProvider_2.method_0();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static Class3 smethod_3()
	{
		return threadSafeObjectProvider_3.method_0();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static Class4 smethod_4()
	{
		return threadSafeObjectProvider_4.method_0();
	}
}
