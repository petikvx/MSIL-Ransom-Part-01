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
internal sealed class Class2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class3
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm0 gform0_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm1 gform1_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm2 gform2_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public GForm3 gform3_0;

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
				if (value == gform0_0)
				{
					goto IL_002d;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value != null)
				{
					num = 1945543145;
					num2 = 1945543145;
				}
				else
				{
					num = 378737614;
					num2 = 378737614;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x71C6F89Du) % 6u)
					{
					case 5u:
						method_0(ref gform0_0);
						num = 614984697;
						continue;
					case 3u:
						break;
					case 2u:
						num = ((int)num3 * -1149221463) ^ 0x19A1826B;
						continue;
					default:
						return;
					case 1u:
						goto IL_0076;
					case 0u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 4u:
						return;
					}
					break;
				}
				goto IL_002d;
				IL_002d:
				num = 842509535;
				goto IL_0041;
			}
		}

		public GForm1 GForm1_0
		{
			[DebuggerHidden]
			get
			{
				gform1_0 = smethod_0(gform1_0);
				return gform1_0;
			}
			[DebuggerHidden]
			set
			{
				if (value == gform1_0)
				{
					goto IL_003c;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value != null)
				{
					num = 966460465;
					num2 = 966460465;
				}
				else
				{
					num = 1341548779;
					num2 = 1341548779;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x275F1948u) % 6u)
					{
					case 3u:
						method_0(ref gform1_0);
						num = 1164364293;
						continue;
					case 2u:
						num = (int)(num3 * 1612646827) ^ -2144032883;
						continue;
					case 0u:
						break;
					default:
						return;
					case 4u:
						goto IL_0076;
					case 1u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 5u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = 125897168;
				goto IL_0041;
			}
		}

		public GForm2 GForm2_0
		{
			[DebuggerHidden]
			get
			{
				gform2_0 = smethod_0(gform2_0);
				return gform2_0;
			}
			[DebuggerHidden]
			set
			{
				if (value == gform2_0)
				{
					goto IL_003c;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value == null)
				{
					num = -503716978;
					num2 = -503716978;
				}
				else
				{
					num = -187666299;
					num2 = -187666299;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xC109582Fu) % 6u)
					{
					case 5u:
						method_0(ref gform2_0);
						num = -322985572;
						continue;
					case 4u:
						num = ((int)num3 * -1350944301) ^ -1647028978;
						continue;
					case 3u:
						break;
					default:
						return;
					case 2u:
						goto IL_0076;
					case 0u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 1u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = -2064448567;
				goto IL_0041;
			}
		}

		public GForm3 GForm3_0
		{
			[DebuggerHidden]
			get
			{
				gform3_0 = smethod_0(gform3_0);
				return gform3_0;
			}
			[DebuggerHidden]
			set
			{
				if (value == gform3_0)
				{
					goto IL_003c;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value == null)
				{
					num = 1945487414;
					num2 = 1945487414;
				}
				else
				{
					num = 1725427593;
					num2 = 1725427593;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x3CB77453u) % 6u)
					{
					case 5u:
						method_0(ref gform3_0);
						num = 332443031;
						continue;
					case 3u:
						num = (int)((num3 * 630922048) ^ 0x1D07ED7);
						continue;
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_0076;
					case 4u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 2u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = 2135724594;
				goto IL_0041;
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Expected I4, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected I4, but got Unknown
			//IL_0212: Incompatible stack heights: 0 vs 1
			//IL_0219: Incompatible stack heights: 0 vs 1
			if (gparam_0 != null)
			{
				goto IL_00fc;
			}
			int num = 1;
			goto IL_0155;
			IL_0148:
			num = (((Control)gparam_0).get_IsDisposed() ? 1 : 0);
			goto IL_0155;
			IL_00fc:
			int num2 = -343197459;
			goto IL_0101;
			IL_0101:
			bool flag = default(bool);
			bool flag2 = default(bool);
			T result = default(T);
			string string_ = default(string);
			bool flag3 = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xBAFBE6CCu) % 13u)
				{
				case 11u:
					break;
				case 10u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -1756583356;
						num8 = -1756583356;
					}
					else
					{
						num7 = -453647122;
						num8 = -453647122;
					}
					num2 = num7 ^ (int)(num3 * 211938706);
					continue;
				}
				case 9u:
					flag2 = Class3.smethod_2(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle));
					num2 = (int)((num3 * 1670659515) ^ 0x102872E8);
					continue;
				case 8u:
					Class3.smethod_6(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle), (object)null);
					num2 = -771347013;
					continue;
				case 7u:
					hashtable_0 = Class3.smethod_5();
					num2 = -1962421664;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -917638964;
						num6 = -917638964;
					}
					else
					{
						num5 = -917339039;
						num6 = -917339039;
					}
					num2 = num5 ^ (int)(num3 * 1946833330);
					continue;
				}
				case 5u:
					num2 = -834700438;
					continue;
				case 3u:
					flag = hashtable_0 != null;
					num2 = ((int)num3 * -1041903127) ^ 0x21E0AF3A;
					continue;
				case 2u:
					num2 = ((int)num3 * -451826738) ^ -978174718;
					continue;
				case 0u:
					goto end_IL_0101;
				case 4u:
					goto IL_0148;
				default:
					try
					{
						while (true)
						{
							int num4 = -676652835;
							while (true)
							{
								switch ((num3 = (uint)num4 ^ 0xBAFBE6CCu) % 3u)
								{
								case 1u:
									goto IL_0161;
								case 0u:
									break;
								default:
									return result;
								case 2u:
									return result;
								}
								break;
								IL_0161:
								result = new T();
								num4 = (int)((num3 * 1142260766) ^ 0x6EEC95A4);
							}
						}
					}
					catch (TargetInvocationException exception_) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						Class3.smethod_7((Exception)exception_);
						return Class3.smethod_8((Exception)exception_) != null;
					}).Invoke())
					{
						while (true)
						{
							_ = -109720673;
							while (true)
							{
								_003F val = /*Error near IL_01cb: Stack underflow*/^ -1157896500;
								num3 = (uint)(int)val;
								switch (val % 3)
								{
								case 1:
									string_ = Class3.smethod_3("WinForms_SeeInnerException", new string[1] { Class3.smethod_9(Class3.smethod_8((Exception)exception_)) });
									_ = (num3 * 2107531889) ^ 0x56701D62;
									continue;
								case 2:
									break;
								default:
									throw Class3.smethod_10(string_, Class3.smethod_8((Exception)exception_));
								}
								break;
							}
						}
					}
					finally
					{
						Class3.smethod_11(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle));
					}
				case 12u:
					throw Class3.smethod_4(Class3.smethod_3("WinForms_RecursiveFormCreate", new string[0]));
				}
				if (flag3)
				{
					num2 = (int)((num3 * 1221601281) ^ 0x179F06E5);
					continue;
				}
				while (true)
				{
					int num9 = -339281123;
					while (true)
					{
						switch ((num3 = (uint)num9 ^ 0xBAFBE6CCu) % 3u)
						{
						case 2u:
							goto IL_023f;
						case 0u:
							break;
						default:
							return result;
						}
						break;
						IL_023f:
						result = gparam_0;
						num9 = ((int)num3 * -607287455) ^ 0x39B675C6;
					}
				}
				continue;
				end_IL_0101:
				break;
			}
			goto IL_00fc;
			IL_0155:
			flag3 = (byte)num != 0;
			num2 = -1507354662;
			goto IL_0101;
		}

		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		bool object.Equals(object obj)
		{
			bool result = default(bool);
			while (true)
			{
				int num = -1091192199;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC64A479Fu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 599759415) ^ -868268421;
						continue;
					case 2u:
						result = this.method_2(Class3.smethod_12(obj));
						num = ((int)num2 * -243347410) ^ -520225744;
						continue;
					case 0u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		int object.GetHashCode()
		{
			int result = default(int);
			while (true)
			{
				int num = 1413274422;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5BBE275Bu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1656694113) ^ -489466124;
						continue;
					case 1u:
						result = this.method_3();
						num = (int)((num2 * 1555419636) ^ 0x17564C6C);
						continue;
					case 0u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			Type result = Class3.smethod_1(typeof(Class3).TypeHandle);
			while (true)
			{
				int num = 1232655777;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x42340644u) % 3u)
					{
					case 2u:
						goto IL_000d;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000d:
					num = (int)((num2 * 1076956683) ^ 0x50A0D14B);
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = -1985515458;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x88192D4Du) % 4u)
					{
					case 3u:
						result = this.method_4();
						num = ((int)num2 * -1135711831) ^ -948840925;
						continue;
					case 1u:
						num = (int)((num2 * 875942792) ^ 0x53CF7DFB);
						continue;
					case 0u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}

		static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static bool smethod_2(Hashtable hashtable_1, object object_0)
		{
			return hashtable_1.ContainsKey(object_0);
		}

		static string smethod_3(string string_0, string[] string_1)
		{
			return Utils.GetResourceString(string_0, string_1);
		}

		static InvalidOperationException smethod_4(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static Hashtable smethod_5()
		{
			return new Hashtable();
		}

		static void smethod_6(Hashtable hashtable_1, object object_0, object object_1)
		{
			hashtable_1.Add(object_0, object_1);
		}

		static void smethod_7(Exception exception_0)
		{
			ProjectData.SetProjectError(exception_0);
		}

		static Exception smethod_8(Exception exception_0)
		{
			return exception_0.InnerException;
		}

		static string smethod_9(Exception exception_0)
		{
			return exception_0.Message;
		}

		static InvalidOperationException smethod_10(string string_0, Exception exception_0)
		{
			return new InvalidOperationException(string_0, exception_0);
		}

		static void smethod_11(Hashtable hashtable_1, object object_0)
		{
			hashtable_1.Remove(object_0);
		}

		static object smethod_12(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		bool method_2(object object_0)
		{
			return base.Equals(object_0);
		}

		int method_3()
		{
			return base.GetHashCode();
		}

		string method_4()
		{
			return base.ToString();
		}

		static ArgumentException smethod_13(string string_0)
		{
			return new ArgumentException(string_0);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class4
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		bool object.Equals(object obj)
		{
			return this.method_2(Class4.smethod_1(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		int object.GetHashCode()
		{
			int result = default(int);
			while (true)
			{
				int num = 1081031440;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4850EF7Du) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = this.method_3();
					num = ((int)num2 * -343499835) ^ 0x3F10E398;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return Class4.smethod_2(typeof(Class4).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		string object.ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = 1367713672;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x26A46BC6u) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = this.method_4();
					num = (int)((num2 * 1180500412) ^ 0x590C5597);
				}
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			T result = default(T);
			bool flag = default(bool);
			while (true)
			{
				int num = 986202163;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x695143C6u) % 7u)
					{
					case 5u:
						result = gparam_0;
						num = ((int)num2 * -1396661196) ^ -1921147753;
						continue;
					case 4u:
						num = 1545798654;
						continue;
					case 3u:
						result = new T();
						num = ((int)num2 * -295046939) ^ 0x139EB779;
						continue;
					case 2u:
						flag = gparam_0 == null;
						num = ((int)num2 * -225685484) ^ 0x40347CDC;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1816034481;
							num4 = 1816034481;
						}
						else
						{
							num3 = 392281412;
							num4 = 392281412;
						}
						num = num3 ^ (int)(num2 * 453348806);
						continue;
					}
					case 6u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
		}

		static object smethod_1(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		bool method_2(object object_0)
		{
			return base.Equals(object_0);
		}

		int method_3()
		{
			return base.GetHashCode();
		}

		static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		string method_4()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class5<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;

		internal T Prop_0
		{
			[DebuggerHidden]
			get
			{
				T result = default(T);
				while (true)
				{
					int num = -1503773121;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xD672D5A0u) % 6u)
						{
						case 5u:
							num = (int)(num2 * 1979034200) ^ -198842510;
							continue;
						case 4u:
							result = gparam_0;
							num = -1406862967;
							continue;
						case 3u:
							gparam_0 = new T();
							num = (int)((num2 * 781971661) ^ 0x6B44BDAD);
							continue;
						case 1u:
						{
							int num3;
							int num4;
							if (gparam_0 != null)
							{
								num3 = -698043314;
								num4 = -698043314;
							}
							else
							{
								num3 = -1877509529;
								num4 = -1877509529;
							}
							num = num3 ^ ((int)num2 * -74920468);
							continue;
						}
						case 2u:
							break;
						default:
							return result;
						}
						break;
					}
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class5()
		{
			while (true)
			{
				int num = 705940894;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1DC567A8u) % 3u)
					{
					case 1u:
						goto IL_0008;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0008:
					num = (int)((num2 * 550556793) ^ 0x2508D158);
				}
			}
		}
	}

	private static readonly Class5<Class1> class5_0 = new Class5<Class1>();

	private static readonly Class5<Class0> class5_1 = new Class5<Class0>();

	private static readonly Class5<User> class5_2 = new Class5<User>();

	private static Class5<Class3> class5_3;

	private static readonly Class5<Class4> class5_4;

	[HelpKeyword("My.Computer")]
	internal static Class1 Class1_0
	{
		[DebuggerHidden]
		get
		{
			Class1 prop_ = default(Class1);
			while (true)
			{
				int num = 1715257786;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD4E4577u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 2024634420) ^ -1216163217;
						continue;
					case 1u:
						prop_ = class5_0.Prop_0;
						num = (int)((num2 * 354525445) ^ 0x2BBE739);
						continue;
					case 2u:
						break;
					default:
						return prop_;
					}
					break;
				}
			}
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class0 Class0_0
	{
		[DebuggerHidden]
		get
		{
			Class0 prop_ = default(Class0);
			while (true)
			{
				int num = 1286413748;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5AB9B4C1u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -360369753) ^ 0x19711F38;
						continue;
					case 1u:
						prop_ = class5_1.Prop_0;
						num = ((int)num2 * -1770467645) ^ 0x62D298C;
						continue;
					case 0u:
						break;
					default:
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
				int num = -284172410;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCE6FBA18u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -2036023938) ^ -378815417;
						continue;
					case 2u:
						prop_ = class5_2.Prop_0;
						num = ((int)num2 * -749175653) ^ -317163699;
						continue;
					case 0u:
						break;
					default:
						return prop_;
					}
					break;
				}
			}
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			Class3 prop_ = class5_3.Prop_0;
			while (true)
			{
				int num = 401697879;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x64D851D5u) % 3u)
					{
					case 2u:
						goto IL_000d;
					case 0u:
						break;
					default:
						return prop_;
					}
					break;
					IL_000d:
					num = (int)((num2 * 1183335749) ^ 0x742189DF);
				}
			}
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			Class4 prop_ = default(Class4);
			while (true)
			{
				int num = 1301203682;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x553D02B9u) % 4u)
					{
					case 3u:
						prop_ = class5_4.Prop_0;
						num = (int)((num2 * 1567563836) ^ 0x3752A8B);
						continue;
					case 2u:
						num = (int)((num2 * 1867029012) ^ 0xE3EBB0);
						continue;
					case 0u:
						break;
					default:
						return prop_;
					}
					break;
				}
			}
		}
	}

	static Class2()
	{
		while (true)
		{
			int num = 1754444759;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B68E46Bu) % 3u)
				{
				case 2u:
					goto IL_0020;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0020:
				class5_3 = new Class5<Class3>();
				class5_4 = new Class5<Class4>();
				num = ((int)num2 * -951239387) ^ 0x462AC324;
			}
		}
	}
}
