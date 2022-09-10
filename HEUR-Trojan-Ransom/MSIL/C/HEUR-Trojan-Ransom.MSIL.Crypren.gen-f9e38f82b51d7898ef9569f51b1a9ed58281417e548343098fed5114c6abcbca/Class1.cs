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

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Class1
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
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
						throw Delegate27.smethod_0(Class41.smethod_0(27267));
					}
					method_0(ref gform0_0);
				}
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if ((((int?)((Control)(gparam_0?)).get_IsDisposed()) ?? Class43.smethod_0(1)) != 0 || 1 == 0)
			{
				if (hashtable_0 != null || 1 == 0)
				{
					bool flag = default(bool);
					while (true)
					{
						int num = Class5.smethod_0(3);
						while (true)
						{
							switch (num ^ Class43.smethod_0(30))
							{
							case -12:
								num = Class5.smethod_0(5);
								continue;
							case -13:
								break;
							case -14:
								flag = Delegate13.smethod_0(hashtable_0, Delegate12.smethod_0(typeof(T).TypeHandle));
								num = -11;
								continue;
							default:
								goto end_IL_006f;
							case -11:
								goto IL_00a5;
							}
							if (flag)
							{
								num = -13;
								continue;
							}
							if (true)
							{
								goto end_IL_0095;
							}
							goto IL_00a5;
							IL_00a5:
							throw Delegate15.smethod_0(Delegate14.smethod_0(Class41.smethod_0(27211), new string[Class43.smethod_0(0)]));
							continue;
							end_IL_006f:
							break;
						}
						continue;
						end_IL_0095:
						break;
					}
				}
				else
				{
					hashtable_0 = Delegate16.smethod_0();
				}
				Delegate17.smethod_0(hashtable_0, Delegate12.smethod_0(typeof(T).TypeHandle), null);
				TargetInvocationException object_ = default(TargetInvocationException);
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
						result = Class43.smethod_0(0);
					}
					else
					{
						Delegate18.smethod_0(obj2);
						object_ = obj2;
						result = ((((Delegate19.smethod_0(object_) != null) ? 1u : 0u) > (uint)Class43.smethod_0(0)) ? 1 : 0);
					}
					return (byte)result != 0;
				}).Invoke())
				{
					string string_ = Class41.smethod_0(27240);
					string[] array = new string[Class43.smethod_0(1)];
					array[Class43.smethod_0(0)] = Delegate20.smethod_0(Delegate19.smethod_0(object_));
					string string_2 = Delegate14.smethod_0(string_, array);
					throw Delegate21.smethod_0(string_2, Delegate19.smethod_0(object_));
				}
				finally
				{
					Delegate22.smethod_0(hashtable_0, Delegate12.smethod_0(typeof(T).TypeHandle));
				}
			}
			return gparam_0;
		}

		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			while (true)
			{
				int num = Class43.smethod_0(0);
				while (true)
				{
					switch (num ^ Class43.smethod_0(75))
					{
					case 16:
						gparam_0 = default(T);
						num = 30;
						continue;
					case 15:
						((Component)gparam_0).Dispose();
						num = 31;
						continue;
					case 14:
						num = Class43.smethod_0(1);
						continue;
					case 17:
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
				int num = Class5.smethod_0(9);
				while (true)
				{
					switch (num ^ Class43.smethod_0(41))
					{
					case -10:
						result = Delegate24.smethod_0(this, Delegate23.smethod_0(o));
						num = -8;
						continue;
					case -11:
						num = Class35.smethod_0(10);
						continue;
					case -12:
					case -9:
						return result;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int result = default(int);
			while (true)
			{
				int num = Class43.smethod_0(46);
				while (true)
				{
					switch (num ^ Class43.smethod_0(38))
					{
					case 24:
						result = Delegate25.smethod_0(this);
						num = 2;
						continue;
					case 22:
						num = 3;
						continue;
					case 23:
					case 25:
						return result;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			Type result = default(Type);
			while (true)
			{
				int num = Class43.smethod_0(79);
				while (true)
				{
					switch (num ^ Class43.smethod_0(46))
					{
					case 17:
						result = Delegate12.smethod_0(typeof(Class2).TypeHandle);
						num = Class43.smethod_0(7);
						continue;
					case 16:
						num = 29;
						continue;
					case 15:
					case 18:
						return result;
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
				int num = Class5.smethod_0(24);
				while (true)
				{
					switch (num ^ Class43.smethod_0(78))
					{
					case -15:
						num = Class16.smethod_0(22);
						continue;
					case -16:
						result = Delegate26.smethod_0(this);
						num = -26;
						continue;
					case -14:
					case -13:
						return result;
					}
					break;
				}
			}
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
				int num = Class43.smethod_0(75);
				while (true)
				{
					switch (num ^ Class43.smethod_0(2))
					{
					case 12:
						result = Delegate24.smethod_0(this, Delegate23.smethod_0(o));
						num = 8;
						continue;
					case 10:
						num = 9;
						continue;
					case 11:
					case 13:
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
			int result = default(int);
			while (true)
			{
				int num = Class5.smethod_0(6);
				while (true)
				{
					switch (num ^ Class43.smethod_0(53))
					{
					case -5:
						result = Delegate25.smethod_0(this);
						num = Class35.smethod_0(12);
						continue;
					case -6:
						num = -14;
						continue;
					case -7:
					case -4:
						return result;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			Type result = default(Type);
			while (true)
			{
				int num = Class35.smethod_0(8);
				while (true)
				{
					switch (num ^ Class43.smethod_0(30))
					{
					case -6:
						num = -4;
						continue;
					case -7:
						result = Delegate12.smethod_0(typeof(Class3).TypeHandle);
						num = -2;
						continue;
					case -8:
					case -5:
						return result;
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
				int num = Class5.smethod_0(14);
				while (true)
				{
					switch (num ^ Class43.smethod_0(74))
					{
					case -14:
						result = Delegate26.smethod_0(this);
						num = -1;
						continue;
					case -16:
						num = -2;
						continue;
					case -15:
					case -13:
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
		}
	}

	private static readonly Class4<Class0> class4_0 = new Class4<Class0>();

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
			Class0 prop_ = default(Class0);
			while (true)
			{
				int num = Class35.smethod_0(12);
				while (true)
				{
					switch (num ^ Class43.smethod_0(73))
					{
					case -4:
						num = -9;
						continue;
					case -6:
						prop_ = class4_0.Prop_0;
						num = Class35.smethod_0(16);
						continue;
					case -5:
					case -3:
						return prop_;
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
			Form0 prop_ = default(Form0);
			while (true)
			{
				int num = Class43.smethod_0(7);
				while (true)
				{
					switch (num ^ Class43.smethod_0(46))
					{
					case 16:
						num = 29;
						continue;
					case 15:
						prop_ = class4_1.Prop_0;
						num = 3;
						continue;
					case 14:
					case 17:
						return prop_;
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
			User prop_ = default(User);
			while (true)
			{
				int num = Class35.smethod_0(15);
				while (true)
				{
					switch (num ^ Class43.smethod_0(74))
					{
					case -9:
						num = -7;
						continue;
					case -10:
						prop_ = class4_2.Prop_0;
						num = -5;
						continue;
					case -11:
					case -8:
						return prop_;
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
			Class2 prop_ = default(Class2);
			while (true)
			{
				int num = Class43.smethod_0(0);
				while (true)
				{
					switch (num ^ Class43.smethod_0(19))
					{
					case 8:
						num = Class43.smethod_0(75);
						continue;
					case 7:
						prop_ = class4_3.Prop_0;
						num = 14;
						continue;
					case 9:
					case 10:
						return prop_;
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
			Class3 prop_ = default(Class3);
			while (true)
			{
				int num = Class5.smethod_0(11);
				while (true)
				{
					switch (num ^ Class43.smethod_0(75))
					{
					case -15:
						prop_ = class4_4.Prop_0;
						num = -1;
						continue;
					case -17:
						num = -32;
						continue;
					case -16:
					case -14:
						return prop_;
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
			int num = Class35.smethod_0(17);
			while (true)
			{
				switch (num ^ Class43.smethod_0(57))
				{
				case -1:
					class4_4 = new Class4<Class3>();
					num = 9;
					continue;
				case -2:
					num = -9;
					continue;
				case -3:
					class4_2 = new Class4<User>();
					num = -14;
					continue;
				case -4:
					class4_1 = new Class4<Form0>();
					num = -12;
					continue;
				case -5:
					class4_3 = new Class4<Class2>();
					num = -10;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}
}
