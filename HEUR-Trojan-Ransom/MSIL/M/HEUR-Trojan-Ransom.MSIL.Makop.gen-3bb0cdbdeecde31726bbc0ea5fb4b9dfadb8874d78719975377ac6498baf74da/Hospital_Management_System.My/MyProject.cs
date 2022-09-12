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

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
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
					goto IL_002d;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value != null)
				{
					num = -484997953;
					num2 = -484997953;
				}
				else
				{
					num = -1589324096;
					num2 = -1589324096;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x88355439u) % 6u)
					{
					case 5u:
						Dispose__Instance__(ref m_Form1);
						num = -1530158410;
						continue;
					case 4u:
						break;
					case 1u:
						num = ((int)num3 * -1477424260) ^ 0x44733CFA;
						continue;
					default:
						return;
					case 2u:
						goto IL_0076;
					case 0u:
						throw MyForms.smethod_12("Property can only be set to Nothing");
					case 3u:
						return;
					}
					break;
				}
				goto IL_002d;
				IL_002d:
				num = -1444675084;
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
					goto IL_003c;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value != null)
				{
					num = -1981186696;
					num2 = -1981186696;
				}
				else
				{
					num = -598894957;
					num2 = -598894957;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xF608E052u) % 6u)
					{
					case 5u:
						Dispose__Instance__(ref m_Form2);
						num = -1139170358;
						continue;
					case 3u:
						num = ((int)num3 * -1363003994) ^ 0x6FED9BF4;
						continue;
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_0076;
					case 2u:
						throw MyForms.smethod_12("Property can only be set to Nothing");
					case 4u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = -177753513;
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
				if (value == null)
				{
					num = -1742295501;
					num2 = -1742295501;
				}
				else
				{
					num = -1580678003;
					num2 = -1580678003;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xDE7A6FB9u) % 6u)
					{
					case 5u:
						num = ((int)num3 * -898423739) ^ -519390140;
						continue;
					case 4u:
						Dispose__Instance__(ref m_Form3);
						num = -1927540751;
						continue;
					case 3u:
						break;
					default:
						return;
					case 1u:
						goto IL_0076;
					case 0u:
						throw MyForms.smethod_12("Property can only be set to Nothing");
					case 2u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = -1271902456;
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
					goto IL_003c;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value == null)
				{
					num = 1801393713;
					num2 = 1801393713;
				}
				else
				{
					num = 1670217516;
					num2 = 1670217516;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x1AFA681Cu) % 6u)
					{
					case 5u:
						Dispose__Instance__(ref m_Form4);
						num = 1737626381;
						continue;
					case 1u:
						num = (int)((num3 * 341914202) ^ 0x675076CF);
						continue;
					case 0u:
						break;
					default:
						return;
					case 4u:
						goto IL_0076;
					case 2u:
						throw MyForms.smethod_12("Property can only be set to Nothing");
					case 3u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = 113525017;
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
					goto IL_003c;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value == null)
				{
					num = 160743155;
					num2 = 160743155;
				}
				else
				{
					num = 1114893860;
					num2 = 1114893860;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x30D65B76u) % 6u)
					{
					case 5u:
						Dispose__Instance__(ref m_Form5);
						num = 542236409;
						continue;
					case 3u:
						num = (int)((num3 * 1598501334) ^ 0x48F7FE6B);
						continue;
					case 0u:
						break;
					default:
						return;
					case 4u:
						goto IL_0076;
					case 2u:
						throw MyForms.smethod_12("Property can only be set to Nothing");
					case 1u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = 88585709;
				goto IL_0041;
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			bool flag3 = default(bool);
			bool flag2 = default(bool);
			T result = default(T);
			bool flag = default(bool);
			while (true)
			{
				int num = -819840219;
				while (true)
				{
					int num6;
					uint num2;
					switch ((num2 = (uint)num ^ 0xAB683BA7u) % 13u)
					{
					case 11u:
						flag3 = MyForms.smethod_1(m_FormBeingCreated, (object)MyForms.smethod_0(typeof(T).TypeHandle));
						num = (int)(num2 * 1300829192) ^ -790422103;
						continue;
					case 10u:
						if (Instance != null)
						{
							num = (int)((num2 * 1112250129) ^ 0x216F57EA);
							continue;
						}
						num6 = 1;
						goto IL_004a;
					case 9u:
						if (flag2)
						{
							num = (int)(num2 * 1773893004) ^ -1011307585;
							continue;
						}
						while (true)
						{
							int num5 = -988509279;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0xAB683BA7u) % 3u)
								{
								case 2u:
									goto IL_01f6;
								case 0u:
									break;
								default:
									return result;
								}
								break;
								IL_01f6:
								result = Instance;
								num5 = (int)(num2 * 429637529) ^ -765033212;
							}
						}
					case 7u:
						num = -924336031;
						continue;
					case 6u:
						num6 = (((Control)Instance).get_IsDisposed() ? 1 : 0);
						goto IL_004a;
					case 5u:
						flag = m_FormBeingCreated != null;
						num = ((int)num2 * -431642402) ^ -908783765;
						continue;
					case 4u:
						m_FormBeingCreated = MyForms.smethod_4();
						num = -483524102;
						continue;
					case 3u:
					{
						int num7;
						int num8;
						if (!flag3)
						{
							num7 = -771237387;
							num8 = -771237387;
						}
						else
						{
							num7 = -1390752337;
							num8 = -1390752337;
						}
						num = num7 ^ ((int)num2 * -760445886);
						continue;
					}
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 307897006;
							num4 = 307897006;
						}
						else
						{
							num3 = 1976609063;
							num4 = 1976609063;
						}
						num = num3 ^ ((int)num2 * -278325220);
						continue;
					}
					case 0u:
						num = ((int)num2 * -978062178) ^ 0x22186907;
						continue;
					case 12u:
						break;
					case 2u:
						throw MyForms.smethod_3(MyForms.smethod_2("WinForms_RecursiveFormCreate", new string[0]));
					default:
						{
							MyForms.smethod_5(m_FormBeingCreated, (object)MyForms.smethod_0(typeof(T).TypeHandle), (object)null);
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
								MyForms.smethod_10(m_FormBeingCreated, (object)MyForms.smethod_0(typeof(T).TypeHandle));
							}
						}
						IL_004a:
						flag2 = (byte)num6 != 0;
						num = -2011431459;
						continue;
					}
					break;
				}
			}
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
				int num = 947716760;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x79FA79B4u) % 3u)
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
					num = (int)((num2 * 823603646) ^ 0x7308787B);
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return this.method_0(MyForms.smethod_11(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return this.method_1();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return MyForms.smethod_0(typeof(MyForms).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return this.method_2();
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
			bool result = default(bool);
			while (true)
			{
				int num = 1537032570;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x52BA5FC8u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 686235244) ^ 0x11022B91);
						continue;
					case 2u:
						result = this.method_0(MyWebServices.smethod_0(o));
						num = ((int)num2 * -1137539975) ^ 0xDB7AD15;
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
		public override int GetHashCode()
		{
			return this.method_1();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			Type result = default(Type);
			while (true)
			{
				int num = 1175393893;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x224A624Au) % 3u)
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
					result = MyWebServices.smethod_1(typeof(MyWebServices).TypeHandle);
					num = ((int)num2 * -398216450) ^ -293236212;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			string result = this.method_2();
			while (true)
			{
				int num = 1310766264;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x36FED577u) % 3u)
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
					num = ((int)num2 * -1340248053) ^ -1719235832;
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			bool flag = default(bool);
			T result = default(T);
			while (true)
			{
				int num = 558794066;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x395A0321u) % 8u)
					{
					case 6u:
						num = 1963453357;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 2054429185;
							num4 = 2054429185;
						}
						else
						{
							num3 = 195477038;
							num4 = 195477038;
						}
						num = num3 ^ ((int)num2 * -476864011);
						continue;
					}
					case 4u:
						result = instance;
						num = ((int)num2 * -994773347) ^ -1351781545;
						continue;
					case 3u:
						flag = instance == null;
						num = ((int)num2 * -1354916715) ^ 0x1D4A17DB;
						continue;
					case 1u:
						result = new T();
						num = ((int)num2 * -1913307) ^ 0x3664222C;
						continue;
					case 0u:
						num = (int)(num2 * 1799276629) ^ -848501637;
						continue;
					case 7u:
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
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
			while (true)
			{
				int num = -1834478727;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDBF540C0u) % 3u)
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
					num = ((int)num2 * -1477694087) ^ 0x26412663;
				}
			}
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
				bool flag = m_ThreadStaticValue == null;
				T threadStaticValue = default(T);
				while (true)
				{
					int num = 1354108328;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x27BAC852u) % 6u)
						{
						case 3u:
							m_ThreadStaticValue = new T();
							num = ((int)num2 * -333536549) ^ -1487890212;
							continue;
						case 2u:
						{
							int num3;
							int num4;
							if (flag)
							{
								num3 = 675985553;
								num4 = 675985553;
							}
							else
							{
								num3 = 1270699021;
								num4 = 1270699021;
							}
							num = num3 ^ ((int)num2 * -1096767629);
							continue;
						}
						case 1u:
							threadStaticValue = m_ThreadStaticValue;
							num = 336008216;
							continue;
						case 0u:
							num = ((int)num2 * -1319233124) ^ 0x67AB59B2;
							continue;
						case 5u:
							break;
						default:
							return threadStaticValue;
						}
						break;
					}
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
			while (true)
			{
				int num = 55197332;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x709322D4u) % 3u)
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
					num = (int)((num2 * 1377224350) ^ 0x4B03AC70);
				}
			}
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			MyComputer getInstance = default(MyComputer);
			while (true)
			{
				int num = -1433354905;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC5D8B59Eu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 728257821) ^ -1915209035;
						continue;
					case 1u:
						getInstance = m_ComputerObjectProvider.GetInstance;
						num = ((int)num2 * -1154232568) ^ -1618379323;
						continue;
					case 2u:
						break;
					default:
						return getInstance;
					}
					break;
				}
			}
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			MyApplication getInstance = m_AppObjectProvider.GetInstance;
			while (true)
			{
				int num = 251490704;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x53D6D4F1u) % 3u)
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
					num = (int)(num2 * 1029598481) ^ -943424185;
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
				int num = -1500824946;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA8428254u) % 3u)
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
					num = ((int)num2 * -2004722636) ^ -2039351108;
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
			MyForms getInstance = m_MyFormsObjectProvider.GetInstance;
			while (true)
			{
				int num = 1596243886;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x25605492u) % 3u)
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
					num = (int)((num2 * 527219631) ^ 0x383F95C2);
				}
			}
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			MyWebServices getInstance = default(MyWebServices);
			while (true)
			{
				int num = -2056649204;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x82EFA72Fu) % 4u)
					{
					case 3u:
						getInstance = m_MyWebServicesObjectProvider.GetInstance;
						num = (int)(num2 * 311877687) ^ -1817015544;
						continue;
					case 2u:
						num = (int)(num2 * 2068894300) ^ -1874324130;
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
}
