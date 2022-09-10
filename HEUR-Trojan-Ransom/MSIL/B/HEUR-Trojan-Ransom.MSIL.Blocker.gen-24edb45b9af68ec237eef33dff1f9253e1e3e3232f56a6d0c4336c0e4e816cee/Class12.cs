using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.MyServices.Internal;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Class12
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class13
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class13()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
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
			return typeof(Class13);
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
			if (1 == 0)
			{
			}
			if (gparam_0 == null)
			{
				return new T();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			if (1 == 0)
			{
			}
			gparam_0 = default(T);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class14<T> where T : new()
	{
		private readonly ContextValue<T> contextValue_0;

		internal T Prop_0
		{
			[DebuggerHidden]
			get
			{
				T val = contextValue_0.get_Value();
				int num = 0;
				while (true)
				{
					if (num == 0)
					{
						if (val != null)
						{
							break;
						}
						val = new T();
						num = 1;
						continue;
					}
					contextValue_0.set_Value(val);
					break;
				}
				return val;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class14()
		{
			if (1 == 0)
			{
			}
			base._002Ector();
			contextValue_0 = new ContextValue<T>();
		}
	}

	private static readonly Class14<Class11> class14_0 = new Class14<Class11>();

	private static readonly Class14<Class10> class14_1;

	private static readonly Class14<User> class14_2;

	private static readonly Class14<Class13> class14_3;

	[HelpKeyword("My.Computer")]
	internal static Class11 Class11_0
	{
		[DebuggerHidden]
		get
		{
			return class14_0.Prop_0;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class10 Class10_0
	{
		[DebuggerHidden]
		get
		{
			return class14_1.Prop_0;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class14_2.Prop_0;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class13 Class13_0
	{
		[DebuggerHidden]
		get
		{
			return class14_3.Prop_0;
		}
	}

	static Class12()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				class14_3 = new Class14<Class13>();
				num = 3;
				break;
			case 1:
				class14_2 = new Class14<User>();
				num = 2;
				break;
			case 0:
				class14_1 = new Class14<Class10>();
				num = 1;
				break;
			default:
				return;
			}
		}
	}
}
