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
using HP.SupportFramework.Common.HPSAIssues;
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
				return (GForm0)Class28.smethod_0(4816312, this, null);
			}
			[DebuggerHidden]
			set
			{
				Class28.smethod_0(4816365, this, value);
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if (gparam_0 == null || ((Control)gparam_0).get_IsDisposed() || 1 == 0)
			{
				if (hashtable_0 != null || 1 == 0)
				{
					if (hashtable_0.ContainsKey(typeof(T)) || 1 == 0)
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
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
						result = 0;
					}
					else
					{
						ProjectData.SetProjectError((Exception)obj2);
						ex = obj2;
						result = ((ex.InnerException != null) ? 1 : 0);
					}
					return (byte)result != 0;
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
			return gparam_0;
		}

		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			int num = ActionItemBase.smethod_0(30);
			int num2 = -58;
			num2 = -30;
			while (true)
			{
				num ^= 0x19;
				num2 = GClass6.smethod_0(34);
				while (true)
				{
					switch (num2 ^ 0x24)
					{
					default:
						goto IL_0010;
					case -32:
						switch (num)
						{
						case -23:
							num = -16;
							goto end_IL_0021;
						case -22:
							((Component)gparam_0).Dispose();
							num = -14;
							goto end_IL_0021;
						case -21:
							gparam_0 = default(T);
							num = GClass6.smethod_0(35);
							goto end_IL_0021;
						case -20:
							return;
						}
						num2 = -59;
						num2 = -31;
						goto case -31;
					case -31:
						num = ActionItemBase.smethod_0(30);
						num2 = -58;
						num2 = -30;
						break;
					case -30:
						break;
					case -33:
						{
							while (true)
							{
								num2 = -5;
								num2 = -33;
							}
						}
						end_IL_0021:
						break;
					}
					break;
					IL_0010:
					num2 = GClass6.smethod_0(34);
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
				int num = 12;
				int num2 = GClass6.smethod_0(34);
				while (true)
				{
					IL_00b2:
					num2 ^= 0x25;
					int num3;
					while (true)
					{
						num3 = GClass6.smethod_0(31);
						while (true)
						{
							switch (num3 ^ 0x22)
							{
							case -37:
								num3 = ActionItemBase.smethod_0(23);
								continue;
							case -38:
								goto end_IL_002c;
							case -39:
								goto IL_0055;
							case -36:
								goto IL_00b2;
							}
							break;
						}
						continue;
						end_IL_002c:
						break;
					}
					switch (num2)
					{
					case -34:
						goto IL_0065;
					case -33:
						goto IL_009a;
					case -31:
						goto IL_009f;
					case -32:
						goto end_IL_00b2;
					}
					num3 = -5;
					num3 = -39;
					goto IL_0055;
					IL_009f:
					num ^= 0x28;
					num2 = ActionItemBase.smethod_0(28);
					num3 = -2;
					num3 = -36;
					continue;
					IL_0055:
					num2 = ActionItemBase.smethod_0(28);
					num3 = -2;
					num3 = -36;
					continue;
					IL_009a:
					num2 = -6;
					continue;
					IL_0065:
					switch (num)
					{
					default:
						num2 = -59;
						continue;
					case 36:
						result = base.Equals(RuntimeHelpers.GetObjectValue(o));
						num = 13;
						break;
					case 38:
						num = 14;
						break;
					case 37:
					case 39:
						return result;
					}
					goto IL_009f;
					continue;
					end_IL_00b2:
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return (int)Class28.smethod_0(4814872, this, null);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			int num = ActionItemBase.smethod_0(25);
			Type typeFromHandle = default(Type);
			while (true)
			{
				switch (num ^ 0x2D)
				{
				default:
					goto IL_000a;
				case -45:
					typeFromHandle = typeof(Class2);
					num = -7;
					num = -44;
					break;
				case -43:
					while (true)
					{
						num = -8;
						num = -43;
					}
				case -44:
				case -42:
					break;
				}
				break;
				IL_000a:
				num = ActionItemBase.smethod_0(25);
			}
			return typeFromHandle;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)Class28.smethod_0(4815740, this, null);
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
			int num = 25;
			int num2 = -24;
			num2 = -39;
			bool result = default(bool);
			while (true)
			{
				num ^= 0x29;
				num2 = GClass6.smethod_0(44);
				while (true)
				{
					switch (num2 ^ 0x31)
					{
					default:
						goto IL_000b;
					case -40:
						switch (num)
						{
						case 46:
							num = 7;
							goto end_IL_001c;
						case 48:
							result = base.Equals(RuntimeHelpers.GetObjectValue(o));
							num = 6;
							goto end_IL_001c;
						case 47:
						case 49:
							return result;
						}
						num2 = -25;
						num2 = -42;
						goto case -42;
					case -42:
						num = 25;
						num2 = -24;
						num2 = -39;
						break;
					case -39:
						break;
					case -41:
						{
							while (true)
							{
								num2 = -26;
								num2 = -41;
							}
						}
						end_IL_001c:
						break;
					}
					break;
					IL_000b:
					num2 = GClass6.smethod_0(44);
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int num = GClass6.smethod_0(35);
			int num2 = -6;
			num2 = -43;
			int hashCode = default(int);
			while (true)
			{
				num ^= 0x2C;
				num2 = ActionItemBase.smethod_1(45);
				while (true)
				{
					switch (num2 ^ 0x2F)
					{
					case -46:
						switch (num)
						{
						default:
							num2 = ActionItemBase.smethod_0(28);
							continue;
						case -40:
							num = ActionItemBase.smethod_1(47);
							break;
						case -39:
							hashCode = base.GetHashCode();
							num = -5;
							break;
						case -41:
						case -38:
							return hashCode;
						}
						break;
					default:
						num2 = ActionItemBase.smethod_1(45);
						continue;
					case -44:
						num = GClass6.smethod_0(35);
						num2 = -6;
						num2 = -43;
						break;
					case -43:
						break;
					case -45:
						while (true)
						{
							num2 = -4;
							num2 = -45;
						}
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return (Type)Class28.smethod_0(4816196, this, null);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)Class28.smethod_0(4815972, this, null);
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

	private static readonly Class4<Class0> class4_0;

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
			return (Class0)Class28.smethod_0(4813493, null, null);
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			return (Form0)Class28.smethod_0(4814089, null, null);
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (User)Class28.smethod_0(4813879, null, null);
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class2 Class2_0
	{
		[DebuggerHidden]
		get
		{
			return (Class2)Class28.smethod_0(4814475, null, null);
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			return (Class3)Class28.smethod_0(4815336, null, null);
		}
	}

	static Class1()
	{
		Class28.smethod_0(4812840, null, null);
	}
}
