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
					num = -1953351106;
					num2 = -1953351106;
				}
				else
				{
					num = -1046970787;
					num2 = -1046970787;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xEBD8E351u) % 6u)
					{
					case 4u:
						num = ((int)num3 * -1684627347) ^ -235954526;
						continue;
					case 3u:
						method_0(ref gform0_0);
						num = -990940938;
						continue;
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_0076;
					case 2u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 5u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = -1758553995;
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
					num = 1520208108;
					num2 = 1520208108;
				}
				else
				{
					num = 1100434476;
					num2 = 1100434476;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x716D45A8u) % 6u)
					{
					case 5u:
						num = ((int)num3 * -392574351) ^ -1080316530;
						continue;
					case 4u:
						method_0(ref gform1_0);
						num = 1959132521;
						continue;
					case 0u:
						break;
					default:
						return;
					case 3u:
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
				num = 1163217279;
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
					num = -1569355442;
					num2 = -1569355442;
				}
				else
				{
					num = -1126452155;
					num2 = -1126452155;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xE14AEC62u) % 6u)
					{
					case 5u:
						method_0(ref gform2_0);
						num = -1146014456;
						continue;
					case 3u:
						break;
					case 1u:
						num = ((int)num3 * -51464313) ^ 0x1FBFEBFB;
						continue;
					default:
						return;
					case 0u:
						goto IL_0076;
					case 2u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 4u:
						return;
					}
					break;
				}
				goto IL_002d;
				IL_002d:
				num = -1166750633;
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
				if (value != null)
				{
					num = -182349136;
					num2 = -182349136;
				}
				else
				{
					num = -1137521439;
					num2 = -1137521439;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x992916CCu) % 6u)
					{
					case 3u:
						method_0(ref gform3_0);
						num = -1954497336;
						continue;
					case 2u:
						break;
					case 1u:
						num = (int)(num3 * 1771133674) ^ -556838714;
						continue;
					default:
						return;
					case 5u:
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
				num = -1452987193;
				goto IL_0041;
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Expected I4, but got Unknown
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected I4, but got Unknown
			//IL_0210: Incompatible stack heights: 0 vs 1
			//IL_0217: Incompatible stack heights: 0 vs 1
			bool flag2 = default(bool);
			bool flag = default(bool);
			string string_ = default(string);
			while (true)
			{
				int num = 605435201;
				while (true)
				{
					int num8;
					uint num2;
					switch ((num2 = (uint)num ^ 0x7E12F613u) % 14u)
					{
					case 13u:
						hashtable_0 = Class3.smethod_5();
						num = ((int)num2 * -1044662816) ^ 0x4BD0169C;
						continue;
					case 12u:
						if (flag2)
						{
							num = (int)(num2 * 1445980073) ^ -2115565939;
							continue;
						}
						return gparam_0;
					case 11u:
						num = 1910051368;
						continue;
					case 10u:
						num = 2121484859;
						continue;
					case 9u:
					{
						int num6;
						int num7;
						if (flag)
						{
							num6 = -1862149486;
							num7 = -1862149486;
						}
						else
						{
							num6 = -1407686439;
							num7 = -1407686439;
						}
						num = num6 ^ ((int)num2 * -1490301851);
						continue;
					}
					case 8u:
						if (gparam_0 != null)
						{
							num = ((int)num2 * -1617439444) ^ -1693653694;
							continue;
						}
						num8 = 1;
						goto IL_0094;
					case 7u:
						num8 = (((Control)gparam_0).get_IsDisposed() ? 1 : 0);
						goto IL_0094;
					case 6u:
						Class3.smethod_6(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle), (object)null);
						num = 655029398;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (Class3.smethod_2(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle)))
						{
							num4 = -1667476653;
							num5 = -1667476653;
						}
						else
						{
							num4 = -357697157;
							num5 = -357697157;
						}
						num = num4 ^ (int)(num2 * 699290819);
						continue;
					}
					case 2u:
						flag = hashtable_0 != null;
						num = (int)((num2 * 1680574392) ^ 0x5A29A466);
						continue;
					case 1u:
						num = (int)(num2 * 1062049148) ^ -1727003649;
						continue;
					case 3u:
						break;
					case 0u:
						throw Class3.smethod_4(Class3.smethod_3("WinForms_RecursiveFormCreate", new string[0]));
					default:
						{
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
									_ = 18408620;
									while (true)
									{
										_003F val = /*Error near IL_01c9: Stack underflow*/^ 0x7E12F613;
										num2 = (uint)(int)val;
										switch (val % 3)
										{
										case 1:
											string_ = Class3.smethod_3("WinForms_SeeInnerException", new string[1] { Class3.smethod_9(Class3.smethod_8((Exception)exception_)) });
											_ = (num2 * 1897532874) ^ 0xF2116426u;
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
									IL_026b:
									int num3 = 1992880039;
									while (true)
									{
										switch ((num2 = (uint)num3 ^ 0x7E12F613u) % 3u)
										{
										case 2u:
											goto IL_022b;
										default:
											goto end_IL_024d;
										case 0u:
											break;
										case 1u:
											goto end_IL_024d;
										}
										goto IL_026b;
										IL_022b:
										Class3.smethod_11(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle));
										num3 = ((int)num2 * -566852910) ^ -1596681080;
										continue;
										end_IL_024d:
										break;
									}
									break;
								}
							}
						}
						IL_0094:
						flag2 = (byte)num8 != 0;
						num = 651263117;
						continue;
					}
					break;
				}
			}
		}

		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			while (true)
			{
				int num = -1804460190;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE0A38970u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						gparam_0 = default(T);
						return;
					}
					break;
					IL_0003:
					((Component)gparam_0).Dispose();
					num = (int)((num2 * 922611294) ^ 0x24EE2F06);
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
			while (true)
			{
				int num = -862540097;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE5F34747u) % 3u)
					{
					case 2u:
						goto IL_0008;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0008:
					num = ((int)num2 * -1031675176) ^ 0x541E5478;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		bool object.Equals(object obj)
		{
			bool result = this.method_2(Class3.smethod_12(obj));
			while (true)
			{
				int num = -523089272;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAC5A78DCu) % 3u)
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
					num = (int)(num2 * 1005460157) ^ -1763818596;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		int object.GetHashCode()
		{
			int result = this.method_3();
			while (true)
			{
				int num = -683911152;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBABD83FDu) % 3u)
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
					num = (int)((num2 * 1700111753) ^ 0x6F8FEA99);
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			Type result = default(Type);
			while (true)
			{
				int num = -799675999;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC2FFCB72u) % 3u)
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
					result = Class3.smethod_1(typeof(Class3).TypeHandle);
					num = ((int)num2 * -979843613) ^ 0x29992777;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = 1385039648;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1CDB5ACAu) % 3u)
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
					num = ((int)num2 * -1534913267) ^ -1258377450;
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
				int num = -824360487;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE7FB0254u) % 3u)
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
					num = ((int)num2 * -1921345452) ^ -2020027412;
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
				int num = 2131366556;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x12239B59u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 799040940) ^ 0x67DA5102);
						continue;
					case 1u:
						result = this.method_3();
						num = (int)((num2 * 246715056) ^ 0x2A32D887);
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
			Type result = default(Type);
			while (true)
			{
				int num = 735356917;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x63D6C8E0u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1782214503) ^ 0x57064873;
						continue;
					case 1u:
						result = Class4.smethod_2(typeof(Class4).TypeHandle);
						num = ((int)num2 * -181383636) ^ 0x5F5C91B3;
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
		[DebuggerHidden]
		string object.ToString()
		{
			return this.method_4();
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			T result = default(T);
			while (true)
			{
				int num = 468119526;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x39487BA5u) % 8u)
					{
					case 7u:
						num = (int)((num2 * 1878258332) ^ 0x299EAB20);
						continue;
					case 6u:
						result = gparam_0;
						num = (int)(num2 * 440993019) ^ -1702350784;
						continue;
					case 5u:
						num = (int)((num2 * 449743093) ^ 0x72EF6EC5);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (gparam_0 == null)
						{
							num3 = 1179435727;
							num4 = 1179435727;
						}
						else
						{
							num3 = 151084045;
							num4 = 151084045;
						}
						num = num3 ^ ((int)num2 * -2127039648);
						continue;
					}
					case 2u:
						result = new T();
						num = ((int)num2 * -1967879267) ^ -529997734;
						continue;
					case 0u:
						num = 971619739;
						continue;
					case 4u:
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
			while (true)
			{
				int num = 1151552767;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x69028A8Bu) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0003:
					gparam_0 = default(T);
					num = (int)(num2 * 921982032) ^ -1572299321;
				}
			}
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
					int num = 1308449484;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xF387041u) % 6u)
						{
						case 5u:
						{
							int num3;
							int num4;
							if (gparam_0 != null)
							{
								num3 = -1932468631;
								num4 = -1932468631;
							}
							else
							{
								num3 = -1098910769;
								num4 = -1098910769;
							}
							num = num3 ^ ((int)num2 * -1691182694);
							continue;
						}
						case 4u:
							result = gparam_0;
							num = 304640738;
							continue;
						case 3u:
							num = (int)((num2 * 559079038) ^ 0x92B0A6);
							continue;
						case 2u:
							gparam_0 = new T();
							num = (int)((num2 * 1112746528) ^ 0x2299E03B);
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
			while (true)
			{
				int num = -1798229291;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB39D6382u) % 3u)
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
					num = ((int)num2 * -2009971072) ^ 0x74DDC292;
				}
			}
		}
	}

	private static readonly Class5<Class1> class5_0 = new Class5<Class1>();

	private static readonly Class5<Class0> class5_1 = new Class5<Class0>();

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
				int num = 443630967;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3C0032D1u) % 3u)
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
					num = ((int)num2 * -460575618) ^ -932505037;
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
				int num = 111345185;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8587B7u) % 3u)
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
					num = (int)(num2 * 1564933082) ^ -348628913;
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
			User prop_ = class5_2.Prop_0;
			while (true)
			{
				int num = -2042832732;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA6286636u) % 3u)
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
					num = (int)((num2 * 76155457) ^ 0x3D9817FF);
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
				int num = -49845255;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB2AB78B2u) % 4u)
					{
					case 3u:
						prop_ = class5_3.Prop_0;
						num = (int)((num2 * 1427361026) ^ 0x78059B20);
						continue;
					case 0u:
						num = ((int)num2 * -1232965755) ^ 0x7A10A2A3;
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

	[HelpKeyword("My.WebServices")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			Class4 prop_ = default(Class4);
			while (true)
			{
				int num = 274721112;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x65FCFE8u) % 3u)
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
					prop_ = class5_4.Prop_0;
					num = ((int)num2 * -422215272) ^ 0x210EA32E;
				}
			}
		}
	}

	static Class2()
	{
		while (true)
		{
			int num = -1861564170;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBD14D651u) % 3u)
				{
				case 1u:
					goto IL_0016;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0016:
				class5_2 = new Class5<User>();
				class5_3 = new Class5<Class3>();
				class5_4 = new Class5<Class4>();
				num = (int)((num2 * 678290512) ^ 0x67601D80);
			}
		}
	}
}
