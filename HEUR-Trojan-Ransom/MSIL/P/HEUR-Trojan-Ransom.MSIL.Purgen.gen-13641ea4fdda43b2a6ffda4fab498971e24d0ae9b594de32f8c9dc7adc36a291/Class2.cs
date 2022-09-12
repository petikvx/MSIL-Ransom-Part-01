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
				if (value != null)
				{
					num = -1603064102;
					num2 = -1603064102;
				}
				else
				{
					num = -207745015;
					num2 = -207745015;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xEDC59169u) % 6u)
					{
					case 4u:
						method_0(ref gform0_0);
						num = -163157264;
						continue;
					case 3u:
						num = (int)(num3 * 1476858398) ^ -1942926078;
						continue;
					case 2u:
						break;
					default:
						return;
					case 0u:
						goto IL_0076;
					case 5u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 1u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = -294989026;
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
					goto IL_002d;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value != null)
				{
					num = 951289163;
					num2 = 951289163;
				}
				else
				{
					num = 1392968006;
					num2 = 1392968006;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x33309713u) % 6u)
					{
					case 5u:
						method_0(ref gform1_0);
						num = 236590177;
						continue;
					case 3u:
						break;
					case 1u:
						num = ((int)num3 * -1172579057) ^ 0x72DD4E86;
						continue;
					default:
						return;
					case 4u:
						goto IL_0076;
					case 2u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 0u:
						return;
					}
					break;
				}
				goto IL_002d;
				IL_002d:
				num = 314459066;
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
					goto IL_0029;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value != null)
				{
					num = 190097957;
					num2 = 190097957;
				}
				else
				{
					num = 1726605720;
					num2 = 1726605720;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x1A62D355u) % 6u)
					{
					case 3u:
						num = (int)((num3 * 921578076) ^ 0x63C1AAC4);
						continue;
					case 2u:
						break;
					case 1u:
						method_0(ref gform2_0);
						num = 739424640;
						continue;
					default:
						return;
					case 0u:
						goto IL_0076;
					case 4u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 5u:
						return;
					}
					break;
				}
				goto IL_0029;
				IL_0029:
				num = 2131850114;
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
				if (value == null)
				{
					num = -1162664080;
					num2 = -1162664080;
				}
				else
				{
					num = -1971912223;
					num2 = -1971912223;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x8DE64E58u) % 6u)
					{
					case 4u:
						break;
					case 2u:
						num = ((int)num3 * -1393968421) ^ -1804175465;
						continue;
					case 0u:
						method_0(ref gform3_0);
						num = -1166782411;
						continue;
					default:
						return;
					case 3u:
						goto IL_0076;
					case 5u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 1u:
						return;
					}
					break;
				}
				goto IL_001a;
				IL_001a:
				num = -517630498;
				goto IL_0041;
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected I4, but got Unknown
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Expected I4, but got Unknown
			//IL_01ed: Incompatible stack heights: 0 vs 1
			//IL_01f4: Incompatible stack heights: 0 vs 1
			bool flag = default(bool);
			string string_ = default(string);
			while (true)
			{
				int num = 539748613;
				while (true)
				{
					int num4;
					uint num2;
					switch ((num2 = (uint)num ^ 0x7304B1A7u) % 12u)
					{
					case 11u:
						num = 1679341075;
						continue;
					case 10u:
					{
						int num7;
						int num8;
						if (hashtable_0 == null)
						{
							num7 = -692894122;
							num8 = -692894122;
						}
						else
						{
							num7 = -1307641244;
							num8 = -1307641244;
						}
						num = num7 ^ (int)(num2 * 177886391);
						continue;
					}
					case 9u:
					{
						if (flag)
						{
							num = ((int)num2 * -1083893912) ^ -999374271;
							continue;
						}
						T result = gparam_0;
						while (true)
						{
							int num9 = 2130818785;
							while (true)
							{
								switch ((num2 = (uint)num9 ^ 0x7304B1A7u) % 3u)
								{
								case 1u:
									goto IL_0254;
								case 0u:
									break;
								default:
									return result;
								}
								break;
								IL_0254:
								num9 = (int)(num2 * 1012453736) ^ -1220904053;
							}
						}
					}
					case 8u:
						num4 = (((Control)gparam_0).get_IsDisposed() ? 1 : 0);
						goto IL_0065;
					case 6u:
						num = 236762864;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (Class3.smethod_2(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle)))
						{
							num5 = -1382664206;
							num6 = -1382664206;
						}
						else
						{
							num5 = -1324965944;
							num6 = -1324965944;
						}
						num = num5 ^ ((int)num2 * -728288887);
						continue;
					}
					case 4u:
						hashtable_0 = Class3.smethod_5();
						num = ((int)num2 * -1574951569) ^ -1714072642;
						continue;
					case 3u:
						num = (int)((num2 * 1085636152) ^ 0x487065BA);
						continue;
					case 2u:
						if (gparam_0 != null)
						{
							num = ((int)num2 * -151519028) ^ -225805101;
							continue;
						}
						num4 = 1;
						goto IL_0065;
					case 7u:
						break;
					case 0u:
						throw Class3.smethod_4(Class3.smethod_3("WinForms_RecursiveFormCreate", new string[0]));
					default:
						{
							Class3.smethod_6(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle), (object)null);
							try
							{
								return new T();
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
									_ = 1916130807;
									while (true)
									{
										_003F val = /*Error near IL_01a6: Stack underflow*/^ 0x7304B1A7;
										num2 = (uint)(int)val;
										switch (val % 3)
										{
										case 2:
											string_ = Class3.smethod_3("WinForms_SeeInnerException", new string[1] { Class3.smethod_9(Class3.smethod_8((Exception)exception_)) });
											_ = ((int)num2 * -1358219026) ^ -1320706486;
											continue;
										case 0:
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
								while (true)
								{
									IL_0248:
									int num3 = 245552014;
									while (true)
									{
										switch ((num2 = (uint)num3 ^ 0x7304B1A7u) % 3u)
										{
										case 1u:
											goto IL_0208;
										default:
											goto end_IL_022a;
										case 0u:
											break;
										case 2u:
											goto end_IL_022a;
										}
										goto IL_0248;
										IL_0208:
										Class3.smethod_11(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle));
										num3 = (int)((num2 * 1812613793) ^ 0x75D99479);
										continue;
										end_IL_022a:
										break;
									}
									break;
								}
							}
						}
						IL_0065:
						flag = (byte)num4 != 0;
						num = 629283790;
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
				int num = 1934306052;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1E8487A7u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -443605637) ^ -523375670;
						continue;
					case 0u:
						gparam_0 = default(T);
						num = (int)(num2 * 2075107322) ^ -456180362;
						continue;
					default:
						return;
					case 2u:
						break;
					case 1u:
						return;
					}
					break;
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
				int num = 1659767509;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7D2918E7u) % 3u)
					{
					case 1u:
						goto IL_000f;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_000f:
					num = ((int)num2 * -1972124769) ^ 0x6E0E211;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		int object.GetHashCode()
		{
			int result = default(int);
			while (true)
			{
				int num = 323022881;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4FDAA3B4u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = this.method_3();
					num = ((int)num2 * -1641963161) ^ 0x21C285A3;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			Type result = default(Type);
			while (true)
			{
				int num = -855675209;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC4B3EE8Eu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -647409203) ^ -1540447027;
						continue;
					case 1u:
						result = Class3.smethod_1(typeof(Class3).TypeHandle);
						num = ((int)num2 * -932291578) ^ -483767029;
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
				int num = -1629915873;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA7B1E908u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = this.method_4();
					num = ((int)num2 * -309785549) ^ -1625042473;
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
			bool result = this.method_2(Class4.smethod_1(obj));
			while (true)
			{
				int num = -41100349;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF93590A4u) % 3u)
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
					num = (int)((num2 * 143677309) ^ 0xEEA5D47);
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
				int num = -2091346562;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x97A89A79u) % 4u)
					{
					case 3u:
						result = this.method_3();
						num = (int)(num2 * 100351774) ^ -1386075519;
						continue;
					case 2u:
						num = (int)(num2 * 1104418752) ^ -1339625668;
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
		internal Type method_0()
		{
			return Class4.smethod_2(typeof(Class4).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		string object.ToString()
		{
			string result = this.method_4();
			while (true)
			{
				int num = 1177638901;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x713FCA35u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = (int)(num2 * 324589711) ^ -1175676559;
				}
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			bool flag = default(bool);
			T result = default(T);
			while (true)
			{
				int num = -1379012643;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCAD685E8u) % 7u)
					{
					case 6u:
						num = -1549788251;
						continue;
					case 4u:
						flag = gparam_0 == null;
						num = (int)((num2 * 1324924983) ^ 0x22CCAA7);
						continue;
					case 3u:
						result = new T();
						num = ((int)num2 * -296511534) ^ -878811169;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 238287115;
							num4 = 238287115;
						}
						else
						{
							num3 = 2023065520;
							num4 = 2023065520;
						}
						num = num3 ^ (int)(num2 * 665930341);
						continue;
					}
					case 0u:
						result = gparam_0;
						num = (int)((num2 * 1657522766) ^ 0x124C33E1);
						continue;
					case 5u:
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
			while (true)
			{
				int num = -2108829153;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA6C02958u) % 3u)
					{
					case 1u:
						goto IL_0008;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0008:
					num = (int)(num2 * 33781669) ^ -1926271312;
				}
			}
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
				if (gparam_0 == null)
				{
					goto IL_002a;
				}
				goto IL_0050;
				IL_0050:
				T result = gparam_0;
				int num = -1721694135;
				goto IL_002f;
				IL_002f:
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA973D992u) % 4u)
					{
					case 1u:
						gparam_0 = new T();
						num = (int)(num2 * 202384824) ^ -1462367512;
						continue;
					case 0u:
						break;
					case 2u:
						goto IL_0050;
					default:
						return result;
					}
					break;
				}
				goto IL_002a;
				IL_002a:
				num = -1435350549;
				goto IL_002f;
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
				int num = 1341887720;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x10B7218Eu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1373694467) ^ -2123093542;
						continue;
					case 2u:
						prop_ = class5_0.Prop_0;
						num = ((int)num2 * -264454915) ^ -232224289;
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
				int num = 1415384382;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x71F8A2F0u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return prop_;
					}
					break;
					IL_0003:
					prop_ = class5_1.Prop_0;
					num = (int)((num2 * 876760526) ^ 0x2641175D);
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
				int num = 2073367449;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x68E172Cu) % 4u)
					{
					case 1u:
						prop_ = class5_2.Prop_0;
						num = ((int)num2 * -316574988) ^ 0x5735105C;
						continue;
					case 0u:
						num = (int)(num2 * 858818587) ^ -1013093978;
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
			Class3 prop_ = default(Class3);
			while (true)
			{
				int num = 1787844110;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4E8DF7D3u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1096551079) ^ 0x5FEA2595;
						continue;
					case 1u:
						prop_ = class5_3.Prop_0;
						num = ((int)num2 * -1508352573) ^ -1057275046;
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

	[HelpKeyword("My.WebServices")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			Class4 prop_ = default(Class4);
			while (true)
			{
				int num = -1864397830;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x98BC1C9Eu) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return prop_;
					}
					break;
					IL_0003:
					prop_ = class5_4.Prop_0;
					num = (int)(num2 * 1346674241) ^ -1747285107;
				}
			}
		}
	}

	static Class2()
	{
		while (true)
		{
			int num = 914536871;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CC95A0Fu) % 6u)
				{
				case 5u:
					class5_3 = new Class5<Class3>();
					num = (int)((num2 * 1983559306) ^ 0x30DFC59D);
					continue;
				case 2u:
					class5_1 = new Class5<Class0>();
					num = (int)((num2 * 1950329545) ^ 0x18C250A0);
					continue;
				case 1u:
					class5_2 = new Class5<User>();
					num = (int)(num2 * 404501725) ^ -1691494867;
					continue;
				case 0u:
					class5_4 = new Class5<Class4>();
					num = (int)((num2 * 281606167) ^ 0x333D6C12);
					continue;
				default:
					return;
				case 4u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}
}
