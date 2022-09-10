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

namespace ns0;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class Class2
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm0 gform0_0;

		public GForm0 Form1
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
				smethod_5();
				if (!smethod_4())
				{
					return;
				}
				while (true)
				{
					if (value == gform0_0)
					{
						return;
					}
					if (value != null)
					{
						break;
					}
					method_0(ref gform0_0);
					if (smethod_4())
					{
						switch (5)
						{
						case 0:
						case 3:
							continue;
						case 1:
						case 4:
						case 5:
							return;
						}
						break;
					}
					return;
				}
				throw new ArgumentException("Property can only be set to Nothing");
			}
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
					string resourceString;
					do
					{
						resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message });
					}
					while (1 == 0);
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
			for (int num = 0; num == 0; num = 1)
			{
				gparam_0 = default(T);
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
			smethod_1(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return smethod_3(this, smethod_2(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return smethod_6(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return smethod_7(typeof(Class3).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)smethod_8(this);
		}

		internal static void smethod_1(object object_0)
		{
			object_0._002Ector();
		}

		internal static object smethod_2(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static bool smethod_3(object object_0, object object_1)
		{
			return object_0.Equals(object_1);
		}

		internal static bool smethod_4()
		{
			return true;
		}

		internal static bool smethod_5()
		{
			return false;
		}

		internal static int smethod_6(object object_0)
		{
			return object_0.GetHashCode();
		}

		internal static Type smethod_7(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static object smethod_8(object object_0)
		{
			return object_0.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class4
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return smethod_2(this, smethod_1(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return smethod_5(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return smethod_6(typeof(Class4).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return (string)smethod_7(this);
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
			smethod_8(this);
		}

		internal static object smethod_1(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static bool smethod_2(object object_0, object object_1)
		{
			return object_0.Equals(object_1);
		}

		internal static bool smethod_3()
		{
			return true;
		}

		internal static bool smethod_4()
		{
			return false;
		}

		internal static int smethod_5(object object_0)
		{
			return object_0.GetHashCode();
		}

		internal static Type smethod_6(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static object smethod_7(object object_0)
		{
			return object_0.ToString();
		}

		internal static void smethod_8(object object_0)
		{
			object_0._002Ector();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class5<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;

		[SpecialName]
		[DebuggerHidden]
		internal T method_0()
		{
			bool flag = gparam_0 == null;
			T result = default(T);
			for (int num = 0; num == 0; num = 1)
			{
				if (flag)
				{
					gparam_0 = new T();
				}
				result = gparam_0;
			}
			return result;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class5()
		{
		}
	}

	private static readonly Class5<Class1> class5_0;

	private static readonly Class5<Form0> class5_1;

	private static readonly Class5<User> class5_2;

	private static Class5<Class3> class5_3;

	private static readonly Class5<Class4> class5_4;

	[HelpKeyword("My.Computer")]
	internal static Class1 Class1_0
	{
		[DebuggerHidden]
		get
		{
			return class5_0.method_0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			return class5_1.method_0();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class5_2.method_0();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			return class5_3.method_0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			return class5_4.method_0();
		}
	}

	static Class2()
	{
		while (true)
		{
			class5_0 = new Class5<Class1>();
			_ = 0;
			if (smethod_0())
			{
				if (smethod_1())
				{
				}
				switch (0)
				{
				case 3:
					break;
				case 0:
				case 1:
					class5_1 = new Class5<Form0>();
					goto IL_0054;
				case 2:
				case 5:
					goto IL_0054;
				default:
					goto IL_005e;
				case 6:
					goto end_IL_0001;
				case 7:
					return;
				}
				continue;
			}
			goto IL_0054;
			IL_0054:
			class5_2 = new Class5<User>();
			goto IL_005e;
			IL_005e:
			class5_3 = new Class5<Class3>();
			break;
			continue;
			end_IL_0001:
			break;
		}
		class5_4 = new Class5<Class4>();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static bool smethod_1()
	{
		return false;
	}
}
