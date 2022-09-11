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
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class Class1
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class2
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm0 gform0_0;

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
				if ((value != gform0_0) ? true : false)
				{
					if (value != null || 1 == 0)
					{
						throw new ArgumentException(Class86.smethod_0("\ue9ab\ue989\ue994\ue98b\ue99e\ue989\ue98f\ue982\ue9db\ue998\ue99a\ue995\ue9db\ue994\ue995\ue997\ue982\ue9db\ue999\ue99e\ue9db\ue988\ue99e\ue98f\ue9db\ue98f\ue994\ue9db\ue9b5\ue994\ue98f\ue993\ue992\ue995\ue99c", 59899));
					}
					method_0(ref gform0_0);
				}
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if ((((int?)((Control)(gparam_0?)).get_IsDisposed()) ?? Class84.smethod_0(1)) != 0 || 1 == 0)
			{
				if (hashtable_0 != null || 1 == 0)
				{
					if (hashtable_0.ContainsKey(typeof(T)) || 1 == 0)
					{
						throw new InvalidOperationException(Utils.GetResourceString(Class86.smethod_0("\uecaa\uec94\uec93\uecbb\uec92\uec8f\uec90\uec8e\ueca2\uecaf\uec98\uec9e\uec88\uec8f\uec8e\uec94\uec8b\uec98\uecbb\uec92\uec8f\uec90\uecbe\uec8f\uec98\uec9c\uec89\uec98", 60461), new string[Class84.smethod_0(0)]));
					}
				}
				else
				{
					hashtable_0 = new Hashtable();
				}
				hashtable_0.Add(typeof(T), null);
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
					if (obj2 == null && 0 == 0)
					{
						result = Class84.smethod_0(0);
					}
					else
					{
						ProjectData.SetProjectError((Exception)obj2);
						ex = obj2;
						result = ((((ex.InnerException != null) ? 1u : 0u) > (uint)Class84.smethod_0(0)) ? 1 : 0);
					}
					return (byte)result != 0;
				}).Invoke())
				{
					string text = Class86.smethod_0("\ueb8e\uebb0\uebb7\ueb9f\uebb6\uebab\uebb4\uebaa\ueb86\ueb8a\uebbc\uebbc\ueb90\uebb7\uebb7\uebbc\uebab\ueb9c\ueba1\uebba\uebbc\ueba9\uebad\uebb0\uebb6\uebb7", 60377);
					string[] array = new string[Class84.smethod_0(1)];
					array[Class84.smethod_0(0)] = ex.InnerException!.Message;
					string resourceString = Utils.GetResourceString(text, array);
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
			while (true)
			{
				int num = Class84.smethod_0(380);
				while (true)
				{
					switch (num ^ Class84.smethod_0(128))
					{
					case 65:
						gparam_0 = default(T);
						num = Class84.smethod_0(381);
						continue;
					case 64:
						((Component)gparam_0).Dispose();
						num = 127;
						continue;
					case 63:
						num = 1;
						continue;
					case 66:
						return;
					}
					break;
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class2()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			bool result = default(bool);
			while (true)
			{
				int num = Class89.smethod_1(49);
				while (true)
				{
					switch (num ^ Class84.smethod_0(76))
					{
					case -53:
						result = base.Equals(RuntimeHelpers.GetObjectValue(o));
						num = -117;
						continue;
					case -55:
						num = -120;
						continue;
					case -54:
					case -52:
						return result;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int hashCode = default(int);
			while (true)
			{
				int num = Class84.smethod_0(75);
				while (true)
				{
					switch (num ^ Class84.smethod_0(383))
					{
					case 64:
						num = 119;
						continue;
					case 63:
						hashCode = base.GetHashCode();
						num = 118;
						continue;
					case 65:
					case 66:
						return hashCode;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			Type typeFromHandle = default(Type);
			while (true)
			{
				int num = Class84.smethod_0(1);
				while (true)
				{
					switch (num ^ Class84.smethod_0(65))
					{
					case 57:
						typeFromHandle = typeof(Class2);
						num = 15;
						continue;
					case 56:
						num = 0;
						continue;
					case 55:
					case 58:
						return typeFromHandle;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = Class89.smethod_1(52);
				while (true)
				{
					switch (num ^ Class84.smethod_0(78))
					{
					case -59:
						num = -13;
						continue;
					case -60:
						result = base.ToString();
						num = Class89.smethod_1(56);
						continue;
					case -58:
					case -57:
						return result;
					}
					break;
				}
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			bool result = default(bool);
			while (true)
			{
				int num = Class89.smethod_1(60);
				while (true)
				{
					switch (num ^ Class84.smethod_0(68))
					{
					case -56:
						result = base.Equals(RuntimeHelpers.GetObjectValue(o));
						num = -6;
						continue;
					case -57:
						num = Class89.smethod_1(66);
						continue;
					case -55:
					case -54:
						return result;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			int hashCode = default(int);
			while (true)
			{
				int num = Class84.smethod_0(9);
				while (true)
				{
					switch (num ^ Class84.smethod_0(129))
					{
					case 58:
						hashCode = base.GetHashCode();
						num = 4;
						continue;
					case 57:
						num = Class84.smethod_0(5);
						continue;
					case 59:
					case 60:
						return hashCode;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			Type typeFromHandle = default(Type);
			while (true)
			{
				int num = Class89.smethod_1(59);
				while (true)
				{
					switch (num ^ Class84.smethod_0(384))
					{
					case -51:
						num = Class89.smethod_1(50);
						continue;
					case -52:
						typeFromHandle = typeof(Class3);
						num = -119;
						continue;
					case -53:
					case -50:
						return typeFromHandle;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = Class84.smethod_0(5);
				while (true)
				{
					switch (num ^ Class84.smethod_0(120))
					{
					case 64:
						num = 121;
						continue;
					case 63:
						result = base.ToString();
						num = 7;
						continue;
					case 62:
					case 65:
						return result;
					}
					break;
				}
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			if (gparam_0 == null || 1 == 0)
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
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class4<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T gparam_0;

		internal T Prop_0
		{
			[DebuggerHidden]
			get
			{
				if (gparam_0 == null || 1 == 0)
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

	private static readonly Class4<Class0> class4_0 = Delegate13.smethod_0();

	private static readonly Class4<Form0> class4_1;

	private static readonly Class4<User> class4_2;

	private static Class4<Class2> class4_3;

	private static readonly Class4<Class3> class4_4;

	[HelpKeyword("My.Computer")]
	internal static Class0 Class0_0
	{
		[DebuggerHidden]
		get
		{
			Class0 result = default(Class0);
			while (true)
			{
				int num = Class84.smethod_0(9);
				while (true)
				{
					switch (num ^ Class84.smethod_0(130))
					{
					case 58:
						num = 7;
						continue;
					case 56:
						result = Delegate18.smethod_0(class4_0);
						num = 4;
						continue;
					case 57:
					case 59:
						return result;
					}
					break;
				}
			}
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			Form0 result = default(Form0);
			while (true)
			{
				int num = Class89.smethod_1(63);
				while (true)
				{
					switch (num ^ Class84.smethod_0(378))
					{
					case -57:
						num = -14;
						continue;
					case -58:
						result = Delegate19.smethod_0(class4_1);
						num = -3;
						continue;
					case -56:
					case -55:
						return result;
					}
					break;
				}
			}
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			User result = default(User);
			while (true)
			{
				int num = Class84.smethod_0(379);
				while (true)
				{
					switch (num ^ Class84.smethod_0(16))
					{
					case 62:
						num = Class84.smethod_0(380);
						continue;
					case 61:
						result = Delegate20.smethod_0(class4_2);
						num = 127;
						continue;
					case 63:
					case 64:
						return result;
					}
					break;
				}
			}
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class2 Class2_0
	{
		[DebuggerHidden]
		get
		{
			Class2 result = default(Class2);
			while (true)
			{
				int num = Class89.smethod_1(52);
				while (true)
				{
					switch (num ^ Class84.smethod_0(124))
					{
					case -50:
						result = Delegate21.smethod_0(class4_3);
						num = Class89.smethod_1(64);
						continue;
					case -52:
						num = -16;
						continue;
					case -51:
					case -49:
						return result;
					}
					break;
				}
			}
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			Class3 result = default(Class3);
			while (true)
			{
				int num = Class84.smethod_0(379);
				while (true)
				{
					switch (num ^ Class84.smethod_0(124))
					{
					case 66:
						num = 126;
						continue;
					case 65:
						result = Delegate22.smethod_0(class4_4);
						num = Class84.smethod_0(381);
						continue;
					case 64:
					case 67:
						return result;
					}
					break;
				}
			}
		}
	}

	static Class1()
	{
		while (true)
		{
			int num = Class89.smethod_1(60);
			while (true)
			{
				switch (num ^ Class84.smethod_0(128))
				{
				case -57:
					class4_4 = Delegate17.smethod_0();
					num = -10;
					continue;
				case -58:
					num = Class89.smethod_1(55);
					continue;
				case -59:
					class4_1 = Delegate14.smethod_0();
					num = -3;
					continue;
				case -60:
					class4_3 = Delegate16.smethod_0();
					num = -7;
					continue;
				case -61:
					class4_2 = Delegate15.smethod_0();
					num = -6;
					continue;
				case -56:
					return;
				}
				break;
			}
		}
	}
}
