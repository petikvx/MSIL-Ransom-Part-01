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
					num = 1492650271;
					num2 = 1492650271;
				}
				else
				{
					num = 308158666;
					num2 = 308158666;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x1F9B81CAu) % 6u)
					{
					case 4u:
						num = ((int)num3 * -281896512) ^ -112750287;
						continue;
					case 3u:
						method_0(ref gform0_0);
						num = 838750641;
						continue;
					case 0u:
						break;
					default:
						return;
					case 5u:
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
				num = 2071159396;
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
					num = -2085961000;
					num2 = -2085961000;
				}
				else
				{
					num = -848850534;
					num2 = -848850534;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x8718ADB6u) % 6u)
					{
					case 5u:
						break;
					case 3u:
						num = ((int)num3 * -1818497824) ^ -1011472842;
						continue;
					case 2u:
						method_0(ref gform1_0);
						num = -1860544170;
						continue;
					default:
						return;
					case 1u:
						goto IL_0076;
					case 4u:
						throw Class3.smethod_13("Property can only be set to Nothing");
					case 0u:
						return;
					}
					break;
				}
				goto IL_001a;
				IL_001a:
				num = -796240901;
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
				if (value == null)
				{
					num = -1983225016;
					num2 = -1983225016;
				}
				else
				{
					num = -348009884;
					num2 = -348009884;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xD487DCBAu) % 6u)
					{
					case 5u:
						num = (int)((num3 * 603859440) ^ 0x1EBAA23C);
						continue;
					case 3u:
						break;
					case 0u:
						method_0(ref gform2_0);
						num = -1768706644;
						continue;
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
				goto IL_0029;
				IL_0029:
				num = -1532599843;
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
					num = -377606085;
					num2 = -377606085;
				}
				else
				{
					num = -277464177;
					num2 = -277464177;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xD30F16E1u) % 6u)
					{
					case 5u:
						break;
					case 1u:
						num = (int)((num3 * 289529330) ^ 0x25E084F3);
						continue;
					case 0u:
						method_0(ref gform3_0);
						num = -2057042879;
						continue;
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
				goto IL_001a;
				IL_001a:
				num = -968801664;
				goto IL_0041;
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Expected I4, but got Unknown
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected I4, but got Unknown
			//IL_020e: Incompatible stack heights: 0 vs 1
			//IL_0215: Incompatible stack heights: 0 vs 1
			T result = default(T);
			string string_ = default(string);
			while (true)
			{
				int num = 1504013068;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6A660815u) % 14u)
					{
					case 13u:
						num = 725445738;
						continue;
					case 12u:
						num = ((int)num2 * -943389779) ^ 0x3C2603D7;
						continue;
					case 11u:
						hashtable_0 = Class3.smethod_5();
						num = (int)((num2 * 1196998785) ^ 0x425B8C6E);
						continue;
					case 10u:
						num = ((int)num2 * -1374156933) ^ -729548295;
						continue;
					case 9u:
					{
						int num3;
						int num4;
						if (hashtable_0 != null)
						{
							num3 = 1901913401;
							num4 = 1901913401;
						}
						else
						{
							num3 = 2098837309;
							num4 = 2098837309;
						}
						num = num3 ^ ((int)num2 * -1090552069);
						continue;
					}
					case 8u:
						num = (int)((num2 * 623146292) ^ 0x6FEBB313);
						continue;
					case 7u:
						if (!((Control)gparam_0).get_IsDisposed())
						{
							while (true)
							{
								int num7 = 1486645414;
								while (true)
								{
									switch ((num2 = (uint)num7 ^ 0x6A660815u) % 3u)
									{
									case 2u:
										goto IL_023b;
									case 0u:
										break;
									default:
										return result;
									}
									break;
									IL_023b:
									result = gparam_0;
									num7 = ((int)num2 * -1278388697) ^ 0x167034FB;
								}
							}
						}
						goto IL_00a7;
					case 6u:
						num = 563210325;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (!Class3.smethod_2(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle)))
						{
							num5 = 506944801;
							num6 = 506944801;
						}
						else
						{
							num5 = 1840664689;
							num6 = 1840664689;
						}
						num = num5 ^ (int)(num2 * 531423718);
						continue;
					}
					case 4u:
						Class3.smethod_6(hashtable_0, (object)Class3.smethod_1(typeof(T).TypeHandle), (object)null);
						num = 1424516448;
						continue;
					case 1u:
						if (gparam_0 != null)
						{
							num = ((int)num2 * -2006556861) ^ -1234247755;
							continue;
						}
						goto IL_00a7;
					case 2u:
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
									_ = 1370042350;
									while (true)
									{
										_003F val = /*Error near IL_01c7: Stack underflow*/^ 0x6A660815;
										num2 = (uint)(int)val;
										switch (val % 3)
										{
										case 1:
											string_ = Class3.smethod_3("WinForms_SeeInnerException", new string[1] { Class3.smethod_9(Class3.smethod_8((Exception)exception_)) });
											_ = ((int)num2 * -915303536) ^ 0x384FBFCE;
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
						}
						IL_00a7:
						num = 1106019162;
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
				int num = 240070310;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x33146FCFu) % 4u)
					{
					case 1u:
						num = ((int)num2 * -1917220776) ^ -128656537;
						continue;
					case 0u:
						gparam_0 = default(T);
						num = ((int)num2 * -2029281606) ^ -1414861139;
						continue;
					default:
						return;
					case 3u:
						break;
					case 2u:
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
			while (true)
			{
				int num = 754614417;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4DBC026Bu) % 3u)
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
					num = (int)(num2 * 478195213) ^ -1892488218;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		bool object.Equals(object obj)
		{
			bool result = this.method_2(Class3.smethod_12(obj));
			while (true)
			{
				int num = -2047667262;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAAADB0C4u) % 3u)
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
					num = ((int)num2 * -2139062566) ^ -247726694;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		int object.GetHashCode()
		{
			int result = default(int);
			while (true)
			{
				int num = 1838140567;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4BB883F6u) % 3u)
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
					num = ((int)num2 * -423870588) ^ -1151388788;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			Type result = Class3.smethod_1(typeof(Class3).TypeHandle);
			while (true)
			{
				int num = 783457298;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5EED842u) % 3u)
					{
					case 1u:
						goto IL_000d;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000d:
					num = ((int)num2 * -259173399) ^ 0x2FF26AAC;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = -157753759;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE584812Du) % 3u)
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
					num = (int)(num2 * 1228459802) ^ -676148761;
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
				int num = 737284964;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x144230B1u) % 3u)
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
					num = (int)((num2 * 1423838469) ^ 0x6C2FC62F);
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
				int num = -2034748644;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBC8B9DF9u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1670995824) ^ 0x4F0292D9;
						continue;
					case 1u:
						result = this.method_3();
						num = ((int)num2 * -482894141) ^ 0x68574AC1;
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
		internal Type method_0()
		{
			Type result = default(Type);
			while (true)
			{
				int num = -1238967640;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD6491DE6u) % 4u)
					{
					case 2u:
						result = Class4.smethod_2(typeof(Class4).TypeHandle);
						num = (int)(num2 * 77168423) ^ -896173855;
						continue;
					case 1u:
						num = ((int)num2 * -1462631820) ^ 0x4243FA2E;
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
				int num = -185770973;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC2C44EADu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1031296392) ^ 0x1906BCFC;
						continue;
					case 2u:
						result = this.method_4();
						num = (int)(num2 * 851306191) ^ -1556488076;
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
				int num = -1962164462;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x944BE40Eu) % 6u)
					{
					case 5u:
						num = (int)((num2 * 1775366295) ^ 0x604EE305);
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1126897137;
							num4 = -1126897137;
						}
						else
						{
							num3 = -2094593918;
							num4 = -2094593918;
						}
						num = num3 ^ (int)(num2 * 637507725);
						continue;
					}
					case 1u:
						result = new T();
						num = (int)((num2 * 1051481198) ^ 0x584F10A);
						continue;
					case 0u:
						result = gparam_0;
						num = -1094312959;
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
				if (gparam_0 == null)
				{
					goto IL_002a;
				}
				goto IL_0050;
				IL_0050:
				T result = gparam_0;
				int num = 1327015739;
				goto IL_002f;
				IL_002f:
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7BD7A20Du) % 4u)
					{
					case 3u:
						gparam_0 = new T();
						num = (int)(num2 * 1867454469) ^ -2013470109;
						continue;
					case 0u:
						break;
					case 1u:
						goto IL_0050;
					default:
						return result;
					}
					break;
				}
				goto IL_002a;
				IL_002a:
				num = 597643430;
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

	private static readonly Class5<Class0> class5_1 = new Class5<Class0>();

	private static readonly Class5<User> class5_2 = new Class5<User>();

	private static Class5<Class3> class5_3 = new Class5<Class3>();

	private static readonly Class5<Class4> class5_4 = new Class5<Class4>();

	[HelpKeyword("My.Computer")]
	internal static Class1 Class1_0
	{
		[DebuggerHidden]
		get
		{
			Class1 prop_ = default(Class1);
			while (true)
			{
				int num = -1652272084;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDCDCF361u) % 3u)
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
					prop_ = class5_0.Prop_0;
					num = (int)(num2 * 1084616829) ^ -2089892475;
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
			return class5_1.Prop_0;
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
				int num = -1477088855;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA1574CC8u) % 4u)
					{
					case 1u:
						prop_ = class5_2.Prop_0;
						num = (int)(num2 * 668868910) ^ -288706610;
						continue;
					case 0u:
						num = (int)((num2 * 243687391) ^ 0x7CEE9F33);
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

	[HelpKeyword("My.Forms")]
	internal static Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			Class3 prop_ = default(Class3);
			while (true)
			{
				int num = 1765623866;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x142E35A7u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1720997034) ^ 0x4091F419;
						continue;
					case 1u:
						prop_ = class5_3.Prop_0;
						num = (int)((num2 * 1448564044) ^ 0x76217C44);
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
				int num = 2142735171;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5122B934u) % 3u)
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
					prop_ = class5_4.Prop_0;
					num = ((int)num2 * -1583259288) ^ 0x3DB3D438;
				}
			}
		}
	}
}
