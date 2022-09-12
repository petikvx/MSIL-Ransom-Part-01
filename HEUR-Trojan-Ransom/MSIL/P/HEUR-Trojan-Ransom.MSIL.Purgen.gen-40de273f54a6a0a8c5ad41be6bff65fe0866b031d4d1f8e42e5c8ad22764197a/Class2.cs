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
					goto IL_003c;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value == null)
				{
					num = 1809863496;
					num2 = 1809863496;
				}
				else
				{
					num = 524898245;
					num2 = 524898245;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x704B9193u) % 6u)
					{
					case 5u:
						method_0(ref gform0_0);
						num = 1374594213;
						continue;
					case 1u:
						num = (int)(num3 * 1933498041) ^ -617574554;
						continue;
					case 0u:
						break;
					default:
						return;
					case 3u:
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
				num = 252774856;
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
				if (value == null)
				{
					num = 118971075;
					num2 = 118971075;
				}
				else
				{
					num = 2020537501;
					num2 = 2020537501;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x2C77E779u) % 6u)
					{
					case 5u:
						num = ((int)num3 * -593528265) ^ 0x2812C9E3;
						continue;
					case 4u:
						method_0(ref gform1_0);
						num = 1541638106;
						continue;
					case 3u:
						break;
					default:
						return;
					case 0u:
						goto IL_0076;
					case 2u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 1u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = 1704879222;
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
					goto IL_001a;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value == null)
				{
					num = -254953846;
					num2 = -254953846;
				}
				else
				{
					num = -989216329;
					num2 = -989216329;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xE0C64EE2u) % 6u)
					{
					case 5u:
						break;
					case 4u:
						method_0(ref gform2_0);
						num = -1203707096;
						continue;
					case 3u:
						num = (int)(num3 * 1577433576) ^ -1426542432;
						continue;
					default:
						return;
					case 2u:
						goto IL_0076;
					case 1u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 0u:
						return;
					}
					break;
				}
				goto IL_001a;
				IL_001a:
				num = -1736901209;
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
					goto IL_002d;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value == null)
				{
					num = -195841979;
					num2 = -195841979;
				}
				else
				{
					num = -1033262138;
					num2 = -1033262138;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xC73A7E12u) % 6u)
					{
					case 5u:
						method_0(ref gform3_0);
						num = -890902020;
						continue;
					case 3u:
						break;
					case 2u:
						num = (int)(num3 * 1452602891) ^ -235015882;
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
				num = -97581940;
				goto IL_0041;
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Expected I4, but got Unknown
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected I4, but got Unknown
			//IL_022a: Incompatible stack heights: 0 vs 1
			//IL_0231: Incompatible stack heights: 0 vs 1
			bool flag = default(bool);
			bool flag2 = default(bool);
			T result = default(T);
			string string_ = default(string);
			while (true)
			{
				int num = 1252461483;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7B9810CAu) % 14u)
					{
					case 13u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = 491662921;
							num6 = 491662921;
						}
						else
						{
							num5 = 1204307378;
							num6 = 1204307378;
						}
						num = num5 ^ ((int)num2 * -1013244577);
						continue;
					}
					case 12u:
						hashtable_0 = Class3.smethod_5();
						num = (int)((num2 * 1516244988) ^ 0x6A2307EA);
						continue;
					case 10u:
						flag2 = Class3.smethod_2(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle));
						num = ((int)num2 * -555760729) ^ 0xC4273C4;
						continue;
					case 9u:
						if (gparam_0 != null)
						{
							num = (int)((num2 * 610711357) ^ 0x7E0B057D);
							continue;
						}
						goto IL_0094;
					case 8u:
					{
						int num7;
						int num8;
						if (!flag2)
						{
							num7 = -753905963;
							num8 = -753905963;
						}
						else
						{
							num7 = -1618748742;
							num8 = -1618748742;
						}
						num = num7 ^ ((int)num2 * -444909909);
						continue;
					}
					case 7u:
						num = 354237418;
						continue;
					case 6u:
						num = (int)(num2 * 1178110848) ^ -1429296246;
						continue;
					case 5u:
						num = 1837570082;
						continue;
					case 3u:
						flag = hashtable_0 != null;
						num = (int)(num2 * 1995371222) ^ -1071341265;
						continue;
					case 2u:
						if (!((Control)gparam_0).get_IsDisposed())
						{
							while (true)
							{
								int num4 = 1295773406;
								while (true)
								{
									switch ((num2 = (uint)num4 ^ 0x7B9810CAu) % 3u)
									{
									case 2u:
										goto IL_026d;
									case 0u:
										break;
									default:
										return result;
									}
									break;
									IL_026d:
									result = gparam_0;
									num4 = (int)((num2 * 2071341384) ^ 0x71EEBFB5);
								}
							}
						}
						goto IL_0094;
					case 0u:
						Class3.smethod_6(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle), (object)null);
						num = 911612969;
						continue;
					case 11u:
						break;
					default:
						try
						{
							while (true)
							{
								int num3 = 1621383810;
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0x7B9810CAu) % 3u)
									{
									case 2u:
										goto IL_0179;
									case 0u:
										break;
									default:
										return result;
									case 1u:
										return result;
									}
									break;
									IL_0179:
									result = new T();
									num3 = ((int)num2 * -1492206639) ^ 0x23D3D4AF;
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
								_ = 1190765270;
								while (true)
								{
									_003F val = /*Error near IL_01e3: Stack underflow*/^ 0x7B9810CA;
									num2 = (uint)(int)val;
									switch (val % 3)
									{
									case 1:
										string_ = Class3.smethod_3("WinForms_SeeInnerException", new string[1] { Class3.smethod_9(Class3.smethod_8((Exception)exception_)) });
										_ = (num2 * 1911793311) ^ 0xB7D67E79u;
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
					case 4u:
						{
							throw Class3.smethod_4(Class3.smethod_3("WinForms_RecursiveFormCreate", new string[0]));
						}
						IL_0094:
						num = 2075577499;
						continue;
					}
					break;
				}
			}
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
				int num = 1760329299;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1B70FCA6u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -235661079) ^ -2109386540;
						continue;
					case 1u:
						result = this.method_2(Class3.smethod_12(obj));
						num = ((int)num2 * -2140088646) ^ -318676734;
						continue;
					case 3u:
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
			int result = this.method_3();
			while (true)
			{
				int num = -1472366062;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x909B8C63u) % 3u)
					{
					case 2u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = (int)(num2 * 1053055598) ^ -488781866;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return Class3.smethod_1(typeof(Class3).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = 842980519;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1239DC77u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = this.method_4();
					num = (int)(num2 * 2021379400) ^ -288585135;
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
			bool result = default(bool);
			while (true)
			{
				int num = -708057453;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBB4242F9u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1930206181) ^ -1226899487;
						continue;
					case 2u:
						result = this.method_2(Class4.smethod_1(obj));
						num = ((int)num2 * -1486521934) ^ 0x42759B22;
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
		[DebuggerHidden]
		int object.GetHashCode()
		{
			int result = default(int);
			while (true)
			{
				int num = -328358660;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCCEA08EFu) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = this.method_3();
					num = ((int)num2 * -485934558) ^ 0x5343F1DE;
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
				int num = -1388941060;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE9F99072u) % 4u)
					{
					case 2u:
						result = Class4.smethod_2(typeof(Class4).TypeHandle);
						num = ((int)num2 * -1845564530) ^ -797322641;
						continue;
					case 1u:
						num = (int)((num2 * 1366793800) ^ 0x6D9548CA);
						continue;
					case 3u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		string object.ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = -1894429516;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF7CA11FBu) % 4u)
					{
					case 3u:
						result = this.method_4();
						num = (int)(num2 * 2116058965) ^ -642143035;
						continue;
					case 1u:
						num = ((int)num2 * -1413203780) ^ -1944598795;
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

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			bool flag = gparam_0 == null;
			T result = default(T);
			while (true)
			{
				int num = 2100169368;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5E3B25D4u) % 7u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 342357838;
							num4 = 342357838;
						}
						else
						{
							num3 = 538014345;
							num4 = 538014345;
						}
						num = num3 ^ (int)(num2 * 1542282625);
						continue;
					}
					case 3u:
						num = ((int)num2 * -1786022540) ^ -556942931;
						continue;
					case 2u:
						result = gparam_0;
						num = 1821512131;
						continue;
					case 1u:
						num = (int)((num2 * 288849430) ^ 0x486526B5);
						continue;
					case 0u:
						result = new T();
						num = (int)(num2 * 1186823443) ^ -387576616;
						continue;
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
				bool flag = default(bool);
				while (true)
				{
					int num = 1950614661;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x18EFECD3u) % 7u)
						{
						case 6u:
							result = gparam_0;
							num = 559422233;
							continue;
						case 3u:
							num = ((int)num2 * -477379844) ^ -1410896005;
							continue;
						case 2u:
							gparam_0 = new T();
							num = ((int)num2 * -2031533289) ^ 0x4557362B;
							continue;
						case 1u:
							flag = gparam_0 == null;
							num = ((int)num2 * -878772832) ^ 0x55B7DD2C;
							continue;
						case 0u:
						{
							int num3;
							int num4;
							if (flag)
							{
								num3 = -2086660300;
								num4 = -2086660300;
							}
							else
							{
								num3 = -691723396;
								num4 = -691723396;
							}
							num = num3 ^ ((int)num2 * -271154351);
							continue;
						}
						case 5u:
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
		}
	}

	private static readonly Class5<Class1> class5_0 = new Class5<Class1>();

	private static readonly Class5<Class0> class5_1;

	private static readonly Class5<User> class5_2;

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
				int num = 2017561840;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x391C2B5Bu) % 4u)
					{
					case 3u:
						prop_ = class5_0.Prop_0;
						num = (int)((num2 * 1358725076) ^ 0x44CAFE16);
						continue;
					case 1u:
						num = ((int)num2 * -1244012507) ^ -1383240288;
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

	[HelpKeyword("My.Application")]
	internal static Class0 Class0_0
	{
		[DebuggerHidden]
		get
		{
			Class0 prop_ = default(Class0);
			while (true)
			{
				int num = 1830232957;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC92E3B1u) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return prop_;
					}
					break;
					IL_0003:
					prop_ = class5_1.Prop_0;
					num = ((int)num2 * -2029064417) ^ -996229214;
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
				int num = 851343861;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4A56D69Au) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return prop_;
					}
					break;
					IL_0003:
					prop_ = class5_2.Prop_0;
					num = (int)(num2 * 116071142) ^ -625633964;
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
			return class5_3.Prop_0;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			return class5_4.Prop_0;
		}
	}

	static Class2()
	{
		while (true)
		{
			int num = 44923097;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2ECD0C81u) % 3u)
				{
				case 2u:
					goto IL_000c;
				case 0u:
					break;
				default:
					class5_2 = new Class5<User>();
					class5_3 = new Class5<Class3>();
					class5_4 = new Class5<Class4>();
					return;
				}
				break;
				IL_000c:
				class5_1 = new Class5<Class0>();
				num = ((int)num2 * -1280198995) ^ -722654470;
			}
		}
	}
}
