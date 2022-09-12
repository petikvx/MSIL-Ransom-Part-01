using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;

[HideModuleName]
[StandardModule]
internal sealed class Class4
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Window", "Create__Instance__", "Dispose__Instance__", "My.MyWpfExtenstionModule.Windows")]
	internal sealed class Class5
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[DebuggerHidden]
		private static T smethod_0<T>(T Instance) where T : Window, new()
		{
			if (Instance == null)
			{
				if (hashtable_0 != null)
				{
					if (hashtable_0.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException("The window cannot be accessed via My.Windows from the Window constructor.");
					}
				}
				else
				{
					hashtable_0 = new Hashtable();
				}
				hashtable_0.Add(typeof(T), null);
				return new T();
			}
			return Instance;
		}

		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Window
		{
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class5()
		{
			Class8.KfbtZ1rztVm6P();
			base._002Ector();
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
			return typeof(Class5);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	private static Class1.Class2<Computer> class2_0;

	private static Class1.Class2<User> class2_1;

	private static Class1.Class2<Class5> class2_2;

	private static Class1.Class2<Log> class2_3;

	static Class4()
	{
		Class8.KfbtZ1rztVm6P();
		class2_0 = new Class1.Class2<Computer>();
		class2_1 = new Class1.Class2<User>();
		class2_2 = new Class1.Class2<Class5>();
		class2_3 = new Class1.Class2<Log>();
	}

	[SpecialName]
	internal static Class3 smethod_0()
	{
		return (Class3)(object)Application.get_Current();
	}

	[SpecialName]
	internal static Computer smethod_1()
	{
		return class2_0.method_0();
	}

	[SpecialName]
	internal static User smethod_2()
	{
		return class2_1.method_0();
	}

	[SpecialName]
	internal static Log rkahPdfwN()
	{
		return class2_3.method_0();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static Class5 smethod_3()
	{
		return class2_2.method_0();
	}
}
