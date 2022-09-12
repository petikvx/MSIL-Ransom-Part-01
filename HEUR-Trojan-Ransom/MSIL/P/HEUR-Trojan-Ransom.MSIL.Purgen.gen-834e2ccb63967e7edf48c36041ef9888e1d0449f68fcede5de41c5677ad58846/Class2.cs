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
					num = -2081348868;
					num2 = -2081348868;
				}
				else
				{
					num = -1012527553;
					num2 = -1012527553;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xD0BBB304u) % 6u)
					{
					case 4u:
						method_0(ref gform0_0);
						num = -1521399047;
						continue;
					case 3u:
						num = (int)((num3 * 1208519118) ^ 0x55850137);
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
				num = -219790331;
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
					num = -1993397583;
					num2 = -1993397583;
				}
				else
				{
					num = -563759161;
					num2 = -563759161;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xFA68D5FEu) % 6u)
					{
					case 4u:
						num = (int)((num3 * 622373323) ^ 0x22D447E);
						continue;
					case 1u:
						method_0(ref gform1_0);
						num = -404703672;
						continue;
					case 0u:
						break;
					default:
						return;
					case 5u:
						goto IL_0076;
					case 3u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 2u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = -1882041828;
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
					num = -98139192;
					num2 = -98139192;
				}
				else
				{
					num = -1177500922;
					num2 = -1177500922;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xAFB07F85u) % 6u)
					{
					case 5u:
						method_0(ref gform2_0);
						num = -999117331;
						continue;
					case 4u:
						break;
					case 1u:
						num = ((int)num3 * -349932629) ^ 0x59239798;
						continue;
					default:
						return;
					case 2u:
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
				num = -1535076902;
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
					goto IL_0029;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value == null)
				{
					num = -572851289;
					num2 = -572851289;
				}
				else
				{
					num = -254060974;
					num2 = -254060974;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xE3CF97D1u) % 6u)
					{
					case 5u:
						num = ((int)num3 * -1921667706) ^ 0xF2E3776;
						continue;
					case 2u:
						break;
					case 0u:
						method_0(ref gform3_0);
						num = -2052797884;
						continue;
					default:
						return;
					case 4u:
						goto IL_0076;
					case 3u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 1u:
						return;
					}
					break;
				}
				goto IL_0029;
				IL_0029:
				num = -406781790;
				goto IL_0041;
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			bool flag2 = default(bool);
			bool flag = default(bool);
			bool flag3 = default(bool);
			T result = default(T);
			while (true)
			{
				int num = 659434047;
				while (true)
				{
					int num6;
					uint num2;
					switch ((num2 = (uint)num ^ 0x6C0C4A18u) % 15u)
					{
					case 14u:
						flag2 = hashtable_0 != null;
						num = ((int)num2 * -863187191) ^ 0x5D4D31F1;
						continue;
					case 11u:
						num6 = (((Control)gparam_0).get_IsDisposed() ? 1 : 0);
						goto IL_002f;
					case 10u:
						flag = Class3.smethod_2(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle));
						num = ((int)num2 * -1583681544) ^ 0x742AE2A1;
						continue;
					case 9u:
						if (flag3)
						{
							num = ((int)num2 * -319053561) ^ -1032301617;
							continue;
						}
						while (true)
						{
							int num7 = 1176564898;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x6C0C4A18u) % 4u)
								{
								case 2u:
									result = gparam_0;
									num7 = (int)((num2 * 2207162) ^ 0x58CE4B39);
									continue;
								case 1u:
									num7 = (int)((num2 * 389245475) ^ 0xB4F8AC4);
									continue;
								case 0u:
									break;
								default:
									return result;
								}
								break;
							}
						}
					case 8u:
					{
						int num8;
						int num9;
						if (!flag2)
						{
							num8 = 200589578;
							num9 = 200589578;
						}
						else
						{
							num8 = 822654085;
							num9 = 822654085;
						}
						num = num8 ^ ((int)num2 * -742775473);
						continue;
					}
					case 7u:
						hashtable_0 = Class3.smethod_5();
						num = (int)(num2 * 139539720) ^ -511181374;
						continue;
					case 6u:
						if (gparam_0 != null)
						{
							num = (int)(num2 * 484933923) ^ -435932317;
							continue;
						}
						num6 = 1;
						goto IL_002f;
					case 5u:
						num = 390966597;
						continue;
					case 3u:
						num = 186795114;
						continue;
					case 2u:
						Class3.smethod_6(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle), (object)null);
						num = 1097663965;
						continue;
					case 1u:
						num = (int)((num2 * 258669300) ^ 0x1CF07FCD);
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 1209528978;
							num5 = 1209528978;
						}
						else
						{
							num4 = 1144260903;
							num5 = 1144260903;
						}
						num = num4 ^ ((int)num2 * -2005769339);
						continue;
					}
					case 4u:
						break;
					case 12u:
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
								string string_ = Class3.smethod_3("WinForms_SeeInnerException", new string[1] { Class3.smethod_9(Class3.smethod_8((Exception)exception_)) });
								throw Class3.smethod_10(string_, Class3.smethod_8((Exception)exception_));
							}
							finally
							{
								while (true)
								{
									IL_0293:
									int num3 = 995161822;
									while (true)
									{
										switch ((num2 = (uint)num3 ^ 0x6C0C4A18u) % 3u)
										{
										case 1u:
											goto IL_0253;
										default:
											goto end_IL_0275;
										case 0u:
											break;
										case 2u:
											goto end_IL_0275;
										}
										goto IL_0293;
										IL_0253:
										Class3.smethod_11(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle));
										num3 = (int)(num2 * 245822112) ^ -1292195980;
										continue;
										end_IL_0275:
										break;
									}
									break;
								}
							}
						}
						IL_002f:
						flag3 = (byte)num6 != 0;
						num = 1285975796;
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
				int num = 1064379555;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2DF8C235u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 74618289) ^ 0x29A60776);
						continue;
					case 1u:
						gparam_0 = default(T);
						num = ((int)num2 * -1653772490) ^ 0x2FE6FA4;
						continue;
					default:
						return;
					case 0u:
						break;
					case 3u:
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
			bool result = default(bool);
			while (true)
			{
				int num = 1696776464;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6F0A9C34u) % 3u)
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
					result = this.method_2(Class3.smethod_12(obj));
					num = ((int)num2 * -544107528) ^ 0x11FD27EB;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		int object.GetHashCode()
		{
			int result = default(int);
			while (true)
			{
				int num = 1714334;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2F525FBu) % 4u)
					{
					case 1u:
						result = this.method_3();
						num = (int)(num2 * 56324373) ^ -538424710;
						continue;
					case 0u:
						num = (int)((num2 * 840460188) ^ 0x8666795);
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
		internal Type method_1()
		{
			Type result = Class3.smethod_1(typeof(Class3).TypeHandle);
			while (true)
			{
				int num = 1238574205;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3A717E2u) % 3u)
					{
					case 1u:
						goto IL_000d;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_000d:
					num = ((int)num2 * -426170195) ^ 0x2949F6B3;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			return this.method_4();
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
				int num = 189426718;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x63E23436u) % 3u)
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
					num = ((int)num2 * -1058657359) ^ -2070498759;
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
				int num = 209915741;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3B7ACADFu) % 4u)
					{
					case 2u:
						result = this.method_3();
						num = (int)((num2 * 324273454) ^ 0x1B6F9B16);
						continue;
					case 1u:
						num = ((int)num2 * -633411275) ^ 0x20F5477A;
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
				int num = 1334042078;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x50DE1AE3u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 2026315269) ^ 0x4F280E88);
						continue;
					case 1u:
						result = Class4.smethod_2(typeof(Class4).TypeHandle);
						num = (int)((num2 * 1161392320) ^ 0x2CE84678);
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
			string result = this.method_4();
			while (true)
			{
				int num = 186016467;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4E627839u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = ((int)num2 * -833449397) ^ 0x21B60B2C;
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
				int num = -2085371479;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE9A21C3Cu) % 7u)
					{
					case 5u:
						result = new T();
						num = ((int)num2 * -653307436) ^ -688465339;
						continue;
					case 4u:
						flag = gparam_0 == null;
						num = ((int)num2 * -2035617780) ^ 0x62CE3E3E;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -376409215;
							num4 = -376409215;
						}
						else
						{
							num3 = -1914328261;
							num4 = -1914328261;
						}
						num = num3 ^ (int)(num2 * 1404984193);
						continue;
					}
					case 1u:
						result = gparam_0;
						num = -2126520493;
						continue;
					case 0u:
						num = (int)(num2 * 1641792405) ^ -210291550;
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

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			while (true)
			{
				int num = -1217652414;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9E2DAC9Cu) % 3u)
					{
					case 2u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0003:
					gparam_0 = default(T);
					num = ((int)num2 * -1410800860) ^ -2035727733;
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
				bool flag = default(bool);
				T result = default(T);
				while (true)
				{
					int num = 218388351;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xCFB983Fu) % 7u)
						{
						case 6u:
						{
							int num3;
							int num4;
							if (!flag)
							{
								num3 = 1530348842;
								num4 = 1530348842;
							}
							else
							{
								num3 = 1763819617;
								num4 = 1763819617;
							}
							num = num3 ^ (int)(num2 * 347362872);
							continue;
						}
						case 5u:
							num = (int)((num2 * 1274848916) ^ 0x5F0FF8A2);
							continue;
						case 3u:
							flag = gparam_0 == null;
							num = (int)(num2 * 1003887076) ^ -1030445946;
							continue;
						case 1u:
							gparam_0 = new T();
							num = ((int)num2 * -1531653109) ^ -145243920;
							continue;
						case 0u:
							result = gparam_0;
							num = 717305954;
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
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class5()
		{
			while (true)
			{
				int num = -1093625498;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC74539A0u) % 3u)
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
					num = ((int)num2 * -1098128537) ^ 0x44ED0BB0;
				}
			}
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
				int num = 693041364;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2E954655u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -511695498) ^ -34287511;
						continue;
					case 1u:
						prop_ = class5_0.Prop_0;
						num = (int)(num2 * 1385742255) ^ -129862872;
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

	[HelpKeyword("My.Application")]
	internal static Class0 Class0_0
	{
		[DebuggerHidden]
		get
		{
			Class0 prop_ = class5_1.Prop_0;
			while (true)
			{
				int num = -90463260;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x83C96ED3u) % 3u)
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
					num = (int)((num2 * 934139785) ^ 0x565F0E7D);
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
				int num = 1204364320;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x64913F0Bu) % 3u)
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
					prop_ = class5_2.Prop_0;
					num = (int)((num2 * 1146665150) ^ 0x6018734D);
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
			int num = 1211837852;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2A84A729u) % 4u)
				{
				case 3u:
					class5_2 = new Class5<User>();
					class5_3 = new Class5<Class3>();
					num = (int)((num2 * 715296314) ^ 0x3EE97B23);
					continue;
				case 1u:
					class5_1 = new Class5<Class0>();
					num = ((int)num2 * -608390478) ^ -45895992;
					continue;
				case 2u:
					break;
				default:
					class5_4 = new Class5<Class4>();
					return;
				}
				break;
			}
		}
	}
}
