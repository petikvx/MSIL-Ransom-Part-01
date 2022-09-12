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

namespace Hospital_Management_System.My;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form1 m_Form1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form2 m_Form2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form3 m_Form3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form4 m_Form4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form5 m_Form5;

		public Form1 Form1
		{
			[DebuggerHidden]
			get
			{
				m_Form1 = Create__Instance__(m_Form1);
				return m_Form1;
			}
			[DebuggerHidden]
			set
			{
				if (value == m_Form1)
				{
					goto IL_001a;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value == null)
				{
					num = 243109363;
					num2 = 243109363;
				}
				else
				{
					num = 1818666492;
					num2 = 1818666492;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x53BFA769u) % 6u)
					{
					case 3u:
						break;
					case 2u:
						num = ((int)num3 * -45711285) ^ 0x395BD55D;
						continue;
					case 0u:
						Dispose__Instance__(ref m_Form1);
						num = 2005561493;
						continue;
					default:
						return;
					case 1u:
						goto IL_0076;
					case 5u:
						throw MyForms.smethod_12("Property can only be set to Nothing");
					case 4u:
						return;
					}
					break;
				}
				goto IL_001a;
				IL_001a:
				num = 125731633;
				goto IL_0041;
			}
		}

		public Form2 Form2
		{
			[DebuggerHidden]
			get
			{
				m_Form2 = Create__Instance__(m_Form2);
				return m_Form2;
			}
			[DebuggerHidden]
			set
			{
				if (value == m_Form2)
				{
					goto IL_0029;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value == null)
				{
					num = -270511099;
					num2 = -270511099;
				}
				else
				{
					num = -1152272599;
					num2 = -1152272599;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xE3F24CDDu) % 6u)
					{
					case 5u:
						num = (int)(num3 * 1504178879) ^ -49966949;
						continue;
					case 4u:
						break;
					case 0u:
						Dispose__Instance__(ref m_Form2);
						num = -215155438;
						continue;
					default:
						return;
					case 3u:
						goto IL_0076;
					case 2u:
						throw MyForms.smethod_12("Property can only be set to Nothing");
					case 1u:
						return;
					}
					break;
				}
				goto IL_0029;
				IL_0029:
				num = -1784965782;
				goto IL_0041;
			}
		}

		public Form3 Form3
		{
			[DebuggerHidden]
			get
			{
				m_Form3 = Create__Instance__(m_Form3);
				return m_Form3;
			}
			[DebuggerHidden]
			set
			{
				if (value == m_Form3)
				{
					goto IL_003c;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value != null)
				{
					num = -1865247293;
					num2 = -1865247293;
				}
				else
				{
					num = -1155425174;
					num2 = -1155425174;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xCEF74375u) % 6u)
					{
					case 3u:
						Dispose__Instance__(ref m_Form3);
						num = -2119066854;
						continue;
					case 1u:
						num = ((int)num3 * -1073358231) ^ -1931286697;
						continue;
					case 0u:
						break;
					default:
						return;
					case 4u:
						goto IL_0076;
					case 2u:
						throw MyForms.smethod_12("Property can only be set to Nothing");
					case 5u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = -1273647824;
				goto IL_0041;
			}
		}

		public Form4 Form4
		{
			[DebuggerHidden]
			get
			{
				m_Form4 = Create__Instance__(m_Form4);
				return m_Form4;
			}
			[DebuggerHidden]
			set
			{
				if (value == m_Form4)
				{
					goto IL_001a;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value == null)
				{
					num = 1014243179;
					num2 = 1014243179;
				}
				else
				{
					num = 868425411;
					num2 = 868425411;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x1A0B709Fu) % 6u)
					{
					case 5u:
						break;
					case 4u:
						Dispose__Instance__(ref m_Form4);
						num = 1494045709;
						continue;
					case 1u:
						num = (int)(num3 * 69050755) ^ -204239108;
						continue;
					default:
						return;
					case 3u:
						goto IL_0076;
					case 2u:
						throw MyForms.smethod_12("Property can only be set to Nothing");
					case 0u:
						return;
					}
					break;
				}
				goto IL_001a;
				IL_001a:
				num = 1677630436;
				goto IL_0041;
			}
		}

		public Form5 Form5
		{
			[DebuggerHidden]
			get
			{
				m_Form5 = Create__Instance__(m_Form5);
				return m_Form5;
			}
			[DebuggerHidden]
			set
			{
				if (value == m_Form5)
				{
					goto IL_0029;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value != null)
				{
					num = 1436803821;
					num2 = 1436803821;
				}
				else
				{
					num = 452247228;
					num2 = 452247228;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x3DD6D935u) % 6u)
					{
					case 5u:
						num = ((int)num3 * -1619300510) ^ 0x714B44AE;
						continue;
					case 2u:
						break;
					case 1u:
						Dispose__Instance__(ref m_Form5);
						num = 886722324;
						continue;
					default:
						return;
					case 0u:
						goto IL_0076;
					case 4u:
						throw MyForms.smethod_12("Property can only be set to Nothing");
					case 3u:
						return;
					}
					break;
				}
				goto IL_0029;
				IL_0029:
				num = 175603416;
				goto IL_0041;
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance != null)
			{
				goto IL_006f;
			}
			int num = 1;
			goto IL_0183;
			IL_0183:
			bool flag = (byte)num != 0;
			int num2 = 1133441151;
			goto IL_0127;
			IL_006f:
			num2 = 1554803831;
			goto IL_0127;
			IL_0127:
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x4C1AD34Fu) % 15u)
				{
				case 14u:
					num2 = ((int)num3 * -1846652013) ^ 0x3DE5F2E2;
					continue;
				case 13u:
					flag2 = m_FormBeingCreated != null;
					num2 = (int)(num3 * 443722653) ^ -1738899995;
					continue;
				case 12u:
					flag3 = MyForms.smethod_1(m_FormBeingCreated, (object)MyForms.smethod_0(typeof(T).TypeHandle));
					num2 = ((int)num3 * -1011756478) ^ -1235364579;
					continue;
				case 11u:
					num2 = 2093287015;
					continue;
				case 9u:
					break;
				case 8u:
					num2 = (int)((num3 * 1157033345) ^ 0x406E75F6);
					continue;
				case 7u:
					MyForms.smethod_5(m_FormBeingCreated, (object)MyForms.smethod_0(typeof(T).TypeHandle), (object)null);
					num2 = 2066967210;
					continue;
				case 6u:
					goto IL_00a8;
				case 5u:
					m_FormBeingCreated = MyForms.smethod_4();
					num2 = 1252377744;
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = 196028877;
						num8 = 196028877;
					}
					else
					{
						num7 = 1573233994;
						num8 = 1573233994;
					}
					num2 = num7 ^ (int)(num3 * 1297112079);
					continue;
				}
				case 2u:
					num2 = (int)((num3 * 793438852) ^ 0x67E7C27D);
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1763920444;
						num6 = 1763920444;
					}
					else
					{
						num5 = 2050094458;
						num6 = 2050094458;
					}
					num2 = num5 ^ (int)(num3 * 1635681375);
					continue;
				}
				case 10u:
					goto IL_0176;
				default:
					try
					{
						return new T();
					}
					catch (TargetInvocationException exception_) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						MyForms.smethod_6((Exception)exception_);
						return MyForms.smethod_7((Exception)exception_) != null;
					}).Invoke())
					{
						string string_ = MyForms.smethod_2("WinForms_SeeInnerException", new string[1] { MyForms.smethod_8(MyForms.smethod_7((Exception)exception_)) });
						throw MyForms.smethod_9(string_, MyForms.smethod_7((Exception)exception_));
					}
					finally
					{
						while (true)
						{
							IL_0242:
							int num4 = 1750187434;
							while (true)
							{
								switch ((num3 = (uint)num4 ^ 0x4C1AD34Fu) % 4u)
								{
								case 1u:
									MyForms.smethod_10(m_FormBeingCreated, (object)MyForms.smethod_0(typeof(T).TypeHandle));
									num4 = ((int)num3 * -630047679) ^ 0x1D7DD95E;
									continue;
								case 0u:
									num4 = (int)((num3 * 1535112131) ^ 0x7458ADD8);
									continue;
								default:
									goto end_IL_0220;
								case 2u:
									break;
								case 3u:
									goto end_IL_0220;
								}
								goto IL_0242;
								continue;
								end_IL_0220:
								break;
							}
							break;
						}
					}
				case 4u:
					throw MyForms.smethod_3(MyForms.smethod_2("WinForms_RecursiveFormCreate", new string[0]));
				}
				break;
				IL_00a8:
				if (flag)
				{
					num2 = ((int)num3 * -1893775791) ^ -1786495440;
					continue;
				}
				T result = Instance;
				while (true)
				{
					int num9 = 904498847;
					while (true)
					{
						switch ((num3 = (uint)num9 ^ 0x4C1AD34Fu) % 3u)
						{
						case 2u:
							goto IL_0264;
						case 0u:
							break;
						default:
							return result;
						}
						break;
						IL_0264:
						num9 = ((int)num3 * -839611836) ^ -1087340755;
					}
				}
			}
			goto IL_006f;
			IL_0176:
			num = (((Control)Instance).get_IsDisposed() ? 1 : 0);
			goto IL_0183;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			((Component)instance).Dispose();
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
			while (true)
			{
				int num = 576623563;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x75F6D950u) % 3u)
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
					num = ((int)num2 * -254683457) ^ 0x34A5B308;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			bool result = this.method_0(MyForms.smethod_11(o));
			while (true)
			{
				int num = -523245337;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEB7A33AAu) % 3u)
					{
					case 2u:
						goto IL_000f;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000f:
					num = (int)((num2 * 298910450) ^ 0x1D9CE0BB);
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int result = default(int);
			while (true)
			{
				int num = -776686717;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC4C47EFCu) % 4u)
					{
					case 3u:
						result = this.method_1();
						num = (int)((num2 * 429262361) ^ 0x424183C5);
						continue;
					case 2u:
						num = ((int)num2 * -1833288941) ^ -702952137;
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
		internal new Type GetType()
		{
			Type result = default(Type);
			while (true)
			{
				int num = 2048860883;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6B6A78E5u) % 4u)
					{
					case 2u:
						result = MyForms.smethod_0(typeof(MyForms).TypeHandle);
						num = ((int)num2 * -2133923307) ^ 0x6B3707FA;
						continue;
					case 1u:
						num = (int)((num2 * 1154700474) ^ 0x571E1C1F);
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
		public override string ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = 1963264602;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x760B4BCDu) % 4u)
					{
					case 3u:
						result = this.method_2();
						num = (int)((num2 * 300222958) ^ 0x2125C9E3);
						continue;
					case 0u:
						num = ((int)num2 * -1287540935) ^ -682937332;
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

		static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static bool smethod_1(Hashtable hashtable_0, object object_0)
		{
			return hashtable_0.ContainsKey(object_0);
		}

		static string smethod_2(string string_0, string[] string_1)
		{
			return Utils.GetResourceString(string_0, string_1);
		}

		static InvalidOperationException smethod_3(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static Hashtable smethod_4()
		{
			return new Hashtable();
		}

		static void smethod_5(Hashtable hashtable_0, object object_0, object object_1)
		{
			hashtable_0.Add(object_0, object_1);
		}

		static void smethod_6(Exception exception_0)
		{
			ProjectData.SetProjectError(exception_0);
		}

		static Exception smethod_7(Exception exception_0)
		{
			return exception_0.InnerException;
		}

		static string smethod_8(Exception exception_0)
		{
			return exception_0.Message;
		}

		static InvalidOperationException smethod_9(string string_0, Exception exception_0)
		{
			return new InvalidOperationException(string_0, exception_0);
		}

		static void smethod_10(Hashtable hashtable_0, object object_0)
		{
			hashtable_0.Remove(object_0);
		}

		static object smethod_11(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		bool method_0(object object_0)
		{
			return base.Equals(object_0);
		}

		int method_1()
		{
			return base.GetHashCode();
		}

		string method_2()
		{
			return base.ToString();
		}

		static ArgumentException smethod_12(string string_0)
		{
			return new ArgumentException(string_0);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			bool result = this.method_0(MyWebServices.smethod_0(o));
			while (true)
			{
				int num = 1193184108;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x45BB224u) % 3u)
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
					num = (int)((num2 * 2089394909) ^ 0x4509EA94);
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return this.method_1();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return MyWebServices.smethod_1(typeof(MyWebServices).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = 686760716;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x19AB7485u) % 3u)
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
					result = this.method_2();
					num = (int)(num2 * 1868536968) ^ -139442810;
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			T result = default(T);
			bool flag = default(bool);
			while (true)
			{
				int num = -1905219242;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE0AEFCD7u) % 8u)
					{
					case 7u:
						result = instance;
						num = (int)((num2 * 1045204122) ^ 0x781C7FF1);
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 368776697;
							num4 = 368776697;
						}
						else
						{
							num3 = 419850488;
							num4 = 419850488;
						}
						num = num3 ^ (int)(num2 * 454269788);
						continue;
					}
					case 4u:
						num = (int)((num2 * 1792836332) ^ 0x719FAB97);
						continue;
					case 3u:
						num = -1191786864;
						continue;
					case 2u:
						result = new T();
						num = ((int)num2 * -501644623) ^ 0x44CBAE9;
						continue;
					case 1u:
						flag = instance == null;
						num = (int)((num2 * 19161813) ^ 0x7ED2870F);
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
		private void Dispose__Instance__<T>(ref T instance)
		{
			while (true)
			{
				int num = -1365500692;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC3DBBE88u) % 3u)
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
					instance = default(T);
					num = (int)((num2 * 1424954292) ^ 0x61F08550);
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
		}

		static object smethod_0(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		bool method_0(object object_0)
		{
			return base.Equals(object_0);
		}

		int method_1()
		{
			return base.GetHashCode();
		}

		static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		string method_2()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					goto IL_002a;
				}
				goto IL_0050;
				IL_0050:
				T threadStaticValue = m_ThreadStaticValue;
				int num = -344594541;
				goto IL_002f;
				IL_002f:
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE9DD38B8u) % 4u)
					{
					case 1u:
						m_ThreadStaticValue = new T();
						num = ((int)num2 * -2085503983) ^ 0x735F81CF;
						continue;
					case 0u:
						break;
					case 2u:
						goto IL_0050;
					default:
						return threadStaticValue;
					}
					break;
				}
				goto IL_002a;
				IL_002a:
				num = -1628355099;
				goto IL_002f;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider;

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider;

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider;

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider;

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			MyApplication getInstance = default(MyApplication);
			while (true)
			{
				int num = 1695362909;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x723C47EBu) % 4u)
					{
					case 2u:
						getInstance = m_AppObjectProvider.GetInstance;
						num = (int)((num2 * 130230348) ^ 0x38376BE2);
						continue;
					case 1u:
						num = (int)(num2 * 2129922723) ^ -28696237;
						continue;
					case 0u:
						break;
					default:
						return getInstance;
					}
					break;
				}
			}
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			User getInstance = default(User);
			while (true)
			{
				int num = 1647852972;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1627CA96u) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return getInstance;
					}
					break;
					IL_0003:
					getInstance = m_UserObjectProvider.GetInstance;
					num = ((int)num2 * -2088463868) ^ 0x1B33F6B;
				}
			}
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			MyWebServices getInstance = m_MyWebServicesObjectProvider.GetInstance;
			while (true)
			{
				int num = -2122745780;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81E98366u) % 3u)
					{
					case 2u:
						goto IL_000d;
					case 0u:
						break;
					default:
						return getInstance;
					}
					break;
					IL_000d:
					num = (int)(num2 * 1574354558) ^ -463270698;
				}
			}
		}
	}

	static MyProject()
	{
		while (true)
		{
			int num = -923155274;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE6DF958u) % 4u)
				{
				case 3u:
					m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
					num = ((int)num2 * -759183707) ^ 0x62C4440E;
					continue;
				case 2u:
					m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
					m_UserObjectProvider = new ThreadSafeObjectProvider<User>();
					m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();
					num = ((int)num2 * -880580585) ^ -544897367;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}
}
