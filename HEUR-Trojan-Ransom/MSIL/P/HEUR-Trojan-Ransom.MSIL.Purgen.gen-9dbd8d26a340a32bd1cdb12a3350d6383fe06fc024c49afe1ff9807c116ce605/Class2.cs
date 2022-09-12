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
					goto IL_001a;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value == null)
				{
					num = 192956392;
					num2 = 192956392;
				}
				else
				{
					num = 470259485;
					num2 = 470259485;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x41D32F2Au) % 6u)
					{
					case 5u:
						break;
					case 3u:
						num = (int)(num3 * 583583984) ^ -150631818;
						continue;
					case 2u:
						method_0(ref gform0_0);
						num = 726556518;
						continue;
					default:
						return;
					case 0u:
						goto IL_0076;
					case 1u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 4u:
						return;
					}
					break;
				}
				goto IL_001a;
				IL_001a:
				num = 597944117;
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
					goto IL_001a;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value != null)
				{
					num = 631948033;
					num2 = 631948033;
				}
				else
				{
					num = 223046801;
					num2 = 223046801;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x6C45689Du) % 6u)
					{
					case 5u:
						break;
					case 4u:
						method_0(ref gform1_0);
						num = 3545962;
						continue;
					case 1u:
						num = ((int)num3 * -1836213973) ^ 0x10E58BEB;
						continue;
					default:
						return;
					case 2u:
						goto IL_0076;
					case 0u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 3u:
						return;
					}
					break;
				}
				goto IL_001a;
				IL_001a:
				num = 1211541406;
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
					goto IL_002d;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value != null)
				{
					num = 275368434;
					num2 = 275368434;
				}
				else
				{
					num = 112660398;
					num2 = 112660398;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x2F5EA7E7u) % 6u)
					{
					case 5u:
						method_0(ref gform2_0);
						num = 489173023;
						continue;
					case 4u:
						break;
					case 2u:
						num = ((int)num3 * -1019428145) ^ 0x4110C1B1;
						continue;
					default:
						return;
					case 1u:
						goto IL_0076;
					case 3u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 0u:
						return;
					}
					break;
				}
				goto IL_002d;
				IL_002d:
				num = 1968943381;
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
					goto IL_001a;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value != null)
				{
					num = -1686730874;
					num2 = -1686730874;
				}
				else
				{
					num = -2048111306;
					num2 = -2048111306;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xED41AB11u) % 6u)
					{
					case 4u:
						break;
					case 3u:
						method_0(ref gform3_0);
						num = -351749689;
						continue;
					case 1u:
						num = (int)((num3 * 1881097444) ^ 0x143E267B);
						continue;
					default:
						return;
					case 0u:
						goto IL_0076;
					case 5u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 2u:
						return;
					}
					break;
				}
				goto IL_001a;
				IL_001a:
				num = -1864375946;
				goto IL_0041;
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			bool flag = default(bool);
			T result = default(T);
			while (true)
			{
				int num = -55995744;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA4B24705u) % 12u)
					{
					case 10u:
					{
						int num7;
						int num8;
						if (hashtable_0 == null)
						{
							num7 = -1482063311;
							num8 = -1482063311;
						}
						else
						{
							num7 = -346492206;
							num8 = -346492206;
						}
						num = num7 ^ (int)(num2 * 653953672);
						continue;
					}
					case 9u:
						if (!((Control)gparam_0).get_IsDisposed())
						{
							result = gparam_0;
							while (true)
							{
								int num9 = -1003734475;
								while (true)
								{
									switch ((num2 = (uint)num9 ^ 0xA4B24705u) % 3u)
									{
									case 1u:
										goto IL_0244;
									case 0u:
										break;
									default:
										return result;
									}
									break;
									IL_0244:
									num9 = (int)(num2 * 414089553) ^ -823932394;
								}
							}
						}
						goto IL_0047;
					case 8u:
						hashtable_0 = Class3.smethod_5();
						num = ((int)num2 * -1827297299) ^ -1027063172;
						continue;
					case 7u:
						num = -138062784;
						continue;
					case 5u:
						Class3.smethod_6(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle), (object)null);
						num = -1225704145;
						continue;
					case 3u:
						flag = Class3.smethod_2(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle));
						num = (int)((num2 * 569618084) ^ 0x519DA4AB);
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = -1439030076;
							num6 = -1439030076;
						}
						else
						{
							num5 = -1033368908;
							num6 = -1033368908;
						}
						num = num5 ^ ((int)num2 * -1865935019);
						continue;
					}
					case 1u:
						if (gparam_0 != null)
						{
							num = (int)((num2 * 521529080) ^ 0x52D54DF4);
							continue;
						}
						goto IL_0047;
					case 0u:
						num = -1898927959;
						continue;
					case 4u:
						break;
					default:
						try
						{
							while (true)
							{
								int num3 = -99650303;
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0xA4B24705u) % 3u)
									{
									case 1u:
										goto IL_014f;
									case 2u:
										break;
									default:
										return result;
									case 0u:
										return result;
									}
									break;
									IL_014f:
									result = new T();
									num3 = ((int)num2 * -1446508409) ^ 0x1513B90A;
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
							string string_ = Class3.smethod_3("WinForms_SeeInnerException", new string[1] { Class3.smethod_9(Class3.smethod_8((Exception)exception_)) });
							throw Class3.smethod_10(string_, Class3.smethod_8((Exception)exception_));
						}
						finally
						{
							while (true)
							{
								IL_0238:
								int num4 = -552653838;
								while (true)
								{
									switch ((num2 = (uint)num4 ^ 0xA4B24705u) % 4u)
									{
									case 3u:
										Class3.smethod_11(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle));
										num4 = (int)((num2 * 1547368127) ^ 0x5593B56E);
										continue;
									case 2u:
										num4 = (int)((num2 * 1140881294) ^ 0x6F21E730);
										continue;
									default:
										goto end_IL_0216;
									case 0u:
										break;
									case 1u:
										goto end_IL_0216;
									}
									goto IL_0238;
									continue;
									end_IL_0216:
									break;
								}
								break;
							}
						}
					case 11u:
						{
							throw Class3.smethod_4(Class3.smethod_3("WinForms_RecursiveFormCreate", new string[0]));
						}
						IL_0047:
						num = -1887066125;
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
			while (true)
			{
				int num = 185229385;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x117D3DD8u) % 3u)
					{
					case 2u:
						goto IL_000e;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_000e:
					gparam_0 = default(T);
					num = (int)((num2 * 2106892526) ^ 0x32874C69);
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		bool object.Equals(object obj)
		{
			bool result = this.method_2(Class3.smethod_12(obj));
			while (true)
			{
				int num = -1515441727;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x931CBDD4u) % 3u)
					{
					case 1u:
						goto IL_000f;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000f:
					num = ((int)num2 * -1085609041) ^ 0x660BFB59;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		int object.GetHashCode()
		{
			return this.method_3();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			Type result = default(Type);
			while (true)
			{
				int num = -1098775877;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFDCC5DD2u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -703779185) ^ -1296791133;
						continue;
					case 1u:
						result = Class3.smethod_1(typeof(Class3).TypeHandle);
						num = ((int)num2 * -582372810) ^ 0x51BA93CB;
						continue;
					case 2u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = -627936247;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC427D898u) % 4u)
					{
					case 1u:
						result = this.method_4();
						num = (int)((num2 * 683526044) ^ 0x5B1B6444);
						continue;
					case 0u:
						num = ((int)num2 * -1252365610) ^ 0x2367BE3E;
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
				int num = -1999586034;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDB76BCD1u) % 3u)
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
					result = this.method_2(Class4.smethod_1(obj));
					num = ((int)num2 * -1543649425) ^ -1561061406;
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
				int num = -164972583;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE76F2FA4u) % 4u)
					{
					case 1u:
						result = this.method_3();
						num = (int)(num2 * 2082524740) ^ -535085368;
						continue;
					case 0u:
						num = (int)(num2 * 21103781) ^ -1396228582;
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
		internal Type method_0()
		{
			Type result = default(Type);
			while (true)
			{
				int num = -719619626;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD872815Bu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 2069510232) ^ -589344731;
						continue;
					case 1u:
						result = Class4.smethod_2(typeof(Class4).TypeHandle);
						num = ((int)num2 * -1121878062) ^ 0x5E41B79A;
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
		string object.ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = -1838375433;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE54DC418u) % 4u)
					{
					case 3u:
						result = this.method_4();
						num = ((int)num2 * -1030606042) ^ 0x7630E227;
						continue;
					case 1u:
						num = (int)(num2 * 1160909971) ^ -1144190995;
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
			T result = default(T);
			bool flag = default(bool);
			while (true)
			{
				int num = 1182384049;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3CF6D3D5u) % 8u)
					{
					case 7u:
						result = new T();
						num = ((int)num2 * -339180377) ^ 0x24B1AA96;
						continue;
					case 5u:
						num = 794645302;
						continue;
					case 4u:
						flag = gparam_0 == null;
						num = ((int)num2 * -2006739749) ^ -1504136696;
						continue;
					case 3u:
						result = gparam_0;
						num = (int)(num2 * 92029489) ^ -900626226;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1928310482;
							num4 = 1928310482;
						}
						else
						{
							num3 = 121061408;
							num4 = 121061408;
						}
						num = num3 ^ ((int)num2 * -2112694280);
						continue;
					}
					case 0u:
						num = (int)(num2 * 1252187769) ^ -1736738969;
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
					int num = -1700988013;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xD186B9BCu) % 6u)
						{
						case 4u:
							gparam_0 = new T();
							num = (int)(num2 * 1859399628) ^ -282432477;
							continue;
						case 3u:
							result = gparam_0;
							num = -1459678963;
							continue;
						case 2u:
						{
							int num3;
							int num4;
							if (flag)
							{
								num3 = 216694274;
								num4 = 216694274;
							}
							else
							{
								num3 = 7489077;
								num4 = 7489077;
							}
							num = num3 ^ (int)(num2 * 3966869);
							continue;
						}
						case 1u:
							flag = gparam_0 == null;
							num = ((int)num2 * -1384694123) ^ 0x61DE84F9;
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
			Class1 prop_ = class5_0.Prop_0;
			while (true)
			{
				int num = 1762107472;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6184800u) % 3u)
					{
					case 1u:
						goto IL_000d;
					case 2u:
						break;
					default:
						return prop_;
					}
					break;
					IL_000d:
					num = (int)((num2 * 1400852185) ^ 0x743E52E4);
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
				int num = -1952129857;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x83F35AE1u) % 3u)
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
					num = (int)(num2 * 1562284307) ^ -821351438;
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
				int num = 856657421;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x736FB940u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1439448701) ^ -682872310;
						continue;
					case 1u:
						prop_ = class5_2.Prop_0;
						num = (int)((num2 * 255354118) ^ 0x34276D10);
						continue;
					case 3u:
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
				int num = 473299419;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCADB544u) % 3u)
					{
					case 1u:
						goto IL_000d;
					case 0u:
						break;
					default:
						return prop_;
					}
					break;
					IL_000d:
					num = (int)((num2 * 926004459) ^ 0x2CB8690C);
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
			return class5_4.Prop_0;
		}
	}

	static Class2()
	{
		while (true)
		{
			int num = 1197172018;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x101BECE5u) % 4u)
				{
				case 3u:
					class5_1 = new Class5<Class0>();
					num = ((int)num2 * -1701964261) ^ -1200995867;
					continue;
				case 1u:
					class5_2 = new Class5<User>();
					num = ((int)num2 * -1382692000) ^ -1368342465;
					continue;
				case 0u:
					break;
				default:
					class5_3 = new Class5<Class3>();
					class5_4 = new Class5<Class4>();
					return;
				}
				break;
			}
		}
	}
}
