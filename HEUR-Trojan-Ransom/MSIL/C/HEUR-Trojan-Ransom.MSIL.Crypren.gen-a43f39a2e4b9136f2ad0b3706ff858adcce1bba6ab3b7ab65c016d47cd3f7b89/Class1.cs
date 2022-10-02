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

[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
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
						throw new ArgumentException(Class47.smethod_0("\ue0e6\ue0c4\ue0d9\ue0c6\ue0d3\ue0c4\ue0c2\ue0cf\ue096\ue0d5\ue0d7\ue0d8\ue096\ue0d9\ue0d8\ue0da\ue0cf\ue096\ue0d4\ue0d3\ue096\ue0c5\ue0d3\ue0c2\ue096\ue0c2\ue0d9\ue096\ue0f8\ue0d9\ue0c2\ue0de\ue0df\ue0d8\ue0d1", 57478));
					}
					method_0(ref gform0_0);
				}
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if ((((int?)((Control)(gparam_0?)).get_IsDisposed()) ?? Class45.smethod_0(1)) != 0 || 1 == 0)
			{
				if (hashtable_0 != null || 1 == 0)
				{
					bool flag = default(bool);
					while (true)
					{
						int num = Class40.smethod_1(15);
						while (true)
						{
							switch (num ^ Class45.smethod_0(44))
							{
							case -12:
								break;
							case -13:
								flag = hashtable_0.ContainsKey(typeof(T));
								num = -32;
								continue;
							case -14:
								num = Class40.smethod_1(14);
								continue;
							default:
								goto end_IL_0070;
							case -11:
								goto IL_00a7;
							}
							if (flag)
							{
								num = -31;
								continue;
							}
							if (true)
							{
								goto end_IL_0096;
							}
							goto IL_00a7;
							IL_00a7:
							throw new InvalidOperationException(Utils.GetResourceString(Class47.smethod_0("\ue388\ue3b6\ue3b1\ue399\ue3b0\ue3ad\ue3b2\ue3ac\ue380\ue38d\ue3ba\ue3bc\ue3aa\ue3ad\ue3ac\ue3b6\ue3a9\ue3ba\ue399\ue3b0\ue3ad\ue3b2\ue39c\ue3ad\ue3ba\ue3be\ue3ab\ue3ba", 58328), new string[Class45.smethod_0(0)]));
							continue;
							end_IL_0070:
							break;
						}
						continue;
						end_IL_0096:
						break;
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
						result = Class45.smethod_0(0);
					}
					else
					{
						ProjectData.SetProjectError((Exception)obj2);
						ex = obj2;
						result = ((((ex.InnerException != null) ? 1u : 0u) > (uint)Class45.smethod_0(0)) ? 1 : 0);
					}
					return (byte)result != 0;
				}).Invoke())
				{
					string text = Class47.smethod_0("\uef88\uefb6\uefb1\uef99\uefb0\uefad\uefb2\uefac\uef80\uef8c\uefba\uefba\uef96\uefb1\uefb1\uefba\uefad\uef9a\uefa7\uefbc\uefba\uefaf\uefab\uefb6\uefb0\uefb1", 61400);
					string[] array = new string[Class45.smethod_0(1)];
					array[Class45.smethod_0(0)] = ex.InnerException!.Message;
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
				int num = Class45.smethod_0(83);
				while (true)
				{
					switch (num ^ Class45.smethod_0(68))
					{
					case 16:
						((Component)gparam_0).Dispose();
						num = 0;
						continue;
					case 15:
						gparam_0 = default(T);
						num = 30;
						continue;
					case 14:
						num = 1;
						continue;
					case 17:
						return;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class2()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			bool result = default(bool);
			while (true)
			{
				int num = Class45.smethod_0(11);
				while (true)
				{
					switch (num ^ Class45.smethod_0(44))
					{
					case 17:
						num = 5;
						continue;
					case 16:
						result = base.Equals(RuntimeHelpers.GetObjectValue(o));
						num = 6;
						continue;
					case 18:
					case 19:
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
				int num = Class40.smethod_1(9);
				while (true)
				{
					switch (num ^ Class45.smethod_0(37))
					{
					case -12:
						hashCode = base.GetHashCode();
						num = -8;
						continue;
					case -13:
						num = -2;
						continue;
					case -11:
					case -10:
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
				int num = Class45.smethod_0(16);
				while (true)
				{
					switch (num ^ Class45.smethod_0(51))
					{
					case 13:
						num = 6;
						continue;
					case 12:
						typeFromHandle = typeof(Class2);
						num = 5;
						continue;
					case 14:
					case 15:
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
				int num = Class45.smethod_0(83);
				while (true)
				{
					switch (num ^ Class45.smethod_0(10))
					{
					case 15:
						result = base.ToString();
						num = 30;
						continue;
					case 13:
						num = 29;
						continue;
					case 14:
					case 16:
						return result;
					}
					break;
				}
			}
		}

		internal static int smethod_1(int int_0)
		{
			return int_0 switch
			{
				35 => -58, 
				38 => -60, 
				39 => -61, 
				31 => -16, 
				26 => -14, 
				_ => -1, 
			};
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class3
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			bool result = default(bool);
			while (true)
			{
				int num = Class40.smethod_1(19);
				while (true)
				{
					switch (num ^ Class45.smethod_0(53))
					{
					case -11:
						num = -7;
						continue;
					case -12:
						result = base.Equals(RuntimeHelpers.GetObjectValue(o));
						num = Class40.smethod_1(12);
						continue;
					case -13:
					case -10:
						return result;
					}
					break;
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int hashCode = default(int);
			while (true)
			{
				int num = Class45.smethod_0(83);
				while (true)
				{
					switch (num ^ Class45.smethod_0(37))
					{
					case 18:
						hashCode = base.GetHashCode();
						num = 29;
						continue;
					case 17:
						num = Class45.smethod_0(85);
						continue;
					case 16:
					case 19:
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
				int num = Class40.smethod_1(11);
				while (true)
				{
					switch (num ^ Class45.smethod_0(37))
					{
					case -16:
						num = -3;
						continue;
					case -18:
						typeFromHandle = typeof(Class3);
						num = Class40.smethod_1(20);
						continue;
					case -17:
					case -15:
						return typeFromHandle;
					}
					break;
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = Class45.smethod_0(82);
				while (true)
				{
					switch (num ^ Class45.smethod_0(18))
					{
					case 16:
						result = base.ToString();
						num = 6;
						continue;
					case 14:
						num = 7;
						continue;
					case 15:
					case 17:
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class3()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
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

	private static readonly Class4<Class0> class4_0 = Delegate7.smethod_0();

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
				int num = Class45.smethod_0(82);
				while (true)
				{
					switch (num ^ Class45.smethod_0(44))
					{
					case 13:
						result = Delegate12.smethod_0(class4_0);
						num = Class45.smethod_0(83);
						continue;
					case 12:
						num = 24;
						continue;
					case 11:
					case 14:
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
				int num = Class45.smethod_0(82);
				while (true)
				{
					switch (num ^ Class45.smethod_0(44))
					{
					case 13:
						result = Delegate13.smethod_0(class4_1);
						num = Class45.smethod_0(84);
						continue;
					case 11:
						num = 31;
						continue;
					case 12:
					case 14:
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
				int num = Class45.smethod_0(85);
				while (true)
				{
					switch (num ^ Class45.smethod_0(86))
					{
					case 15:
						num = 29;
						continue;
					case 14:
						result = Delegate14.smethod_0(class4_2);
						num = Class45.smethod_0(83);
						continue;
					case 13:
					case 16:
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
				int num = Class45.smethod_0(42);
				while (true)
				{
					switch (num ^ Class45.smethod_0(65))
					{
					case 19:
						result = Delegate15.smethod_0(class4_3);
						num = 26;
						continue;
					case 18:
						num = 28;
						continue;
					case 20:
					case 21:
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
				int num = Class45.smethod_0(83);
				while (true)
				{
					switch (num ^ Class45.smethod_0(69))
					{
					case 14:
						num = 29;
						continue;
					case 12:
						result = Delegate16.smethod_0(class4_4);
						num = 30;
						continue;
					case 13:
					case 15:
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
			int num = Class40.smethod_1(19);
			while (true)
			{
				switch (num ^ Class45.smethod_0(18))
				{
				case -15:
					class4_1 = Delegate8.smethod_0();
					num = -26;
					continue;
				case -16:
					class4_3 = Delegate10.smethod_0();
					num = -28;
					continue;
				case -17:
					class4_2 = Delegate9.smethod_0();
					num = -7;
					continue;
				case -18:
					num = Class40.smethod_1(15);
					continue;
				case -19:
					class4_4 = Delegate11.smethod_0();
					num = -5;
					continue;
				case -14:
					return;
				}
				break;
			}
		}
	}
}
