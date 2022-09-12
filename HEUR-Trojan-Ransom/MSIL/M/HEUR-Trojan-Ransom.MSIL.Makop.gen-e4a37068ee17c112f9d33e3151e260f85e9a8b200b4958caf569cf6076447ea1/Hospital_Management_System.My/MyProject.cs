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
					goto IL_003c;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value != null)
				{
					num = -1725492672;
					num2 = -1725492672;
				}
				else
				{
					num = -1001169971;
					num2 = -1001169971;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xEE34A226u) % 6u)
					{
					case 5u:
						Dispose__Instance__(ref m_Form1);
						num = -2078812196;
						continue;
					case 3u:
						num = (int)(num3 * 1473434023) ^ -1425552367;
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
				num = -1444958387;
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
					goto IL_001a;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value == null)
				{
					num = -623195297;
					num2 = -623195297;
				}
				else
				{
					num = -268934461;
					num2 = -268934461;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xD24BF3FDu) % 6u)
					{
					case 5u:
						break;
					case 4u:
						num = (int)(num3 * 797164325) ^ -606758726;
						continue;
					case 2u:
						Dispose__Instance__(ref m_Form2);
						num = -1025725896;
						continue;
					default:
						return;
					case 1u:
						goto IL_0076;
					case 0u:
						throw MyForms.smethod_12("Property can only be set to Nothing");
					case 3u:
						return;
					}
					break;
				}
				goto IL_001a;
				IL_001a:
				num = -1184919001;
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
					num = -2114053171;
					num2 = -2114053171;
				}
				else
				{
					num = -381374194;
					num2 = -381374194;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x94E9A7A4u) % 6u)
					{
					case 5u:
						num = ((int)num3 * -276178113) ^ -140902266;
						continue;
					case 4u:
						Dispose__Instance__(ref m_Form3);
						num = -1714582515;
						continue;
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_0076;
					case 1u:
						throw MyForms.smethod_12("Property can only be set to Nothing");
					case 3u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = -686649327;
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
					num = 1976832594;
					num2 = 1976832594;
				}
				else
				{
					num = 1972561301;
					num2 = 1972561301;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x61C6A543u) % 6u)
					{
					case 2u:
						num = ((int)num3 * -649096730) ^ 0x5F64825C;
						continue;
					case 1u:
						Dispose__Instance__(ref m_Form4);
						num = 719912504;
						continue;
					case 0u:
						break;
					default:
						return;
					case 3u:
						goto IL_0076;
					case 4u:
						throw MyForms.smethod_12("Property can only be set to Nothing");
					case 5u:
						return;
					}
					break;
				}
				goto IL_003c;
				IL_003c:
				num = 196268229;
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
				if (value != null)
				{
					num = -1506135920;
					num2 = -1506135920;
				}
				else
				{
					num = -1928324731;
					num2 = -1928324731;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xAA300922u) % 6u)
					{
					case 5u:
						Dispose__Instance__(ref m_Form5);
						num = -1274886020;
						continue;
					case 1u:
						num = ((int)num3 * -445145655) ^ 0x2684B2B1;
						continue;
					case 0u:
						break;
					default:
						return;
					case 3u:
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
				num = -977883193;
				goto IL_0041;
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ba: Expected I4, but got Unknown
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected I4, but got Unknown
			//IL_01fe: Incompatible stack heights: 0 vs 1
			//IL_0205: Incompatible stack heights: 0 vs 1
			bool flag3 = default(bool);
			T result = default(T);
			bool flag2 = default(bool);
			bool flag = default(bool);
			string string_ = default(string);
			while (true)
			{
				int num = 320824470;
				while (true)
				{
					int num4;
					uint num2;
					switch ((num2 = (uint)num ^ 0x5D18F703u) % 14u)
					{
					case 13u:
						if (flag3)
						{
							num = (int)((num2 * 1368321387) ^ 0x5E34FBF1);
							continue;
						}
						while (true)
						{
							int num9 = 586247031;
							while (true)
							{
								switch ((num2 = (uint)num9 ^ 0x5D18F703u) % 3u)
								{
								case 2u:
									goto IL_0276;
								case 0u:
									break;
								default:
									return result;
								}
								break;
								IL_0276:
								result = Instance;
								num9 = (int)(num2 * 63761539) ^ -1653460705;
							}
						}
					case 12u:
					{
						int num7;
						int num8;
						if (flag2)
						{
							num7 = 485340109;
							num8 = 485340109;
						}
						else
						{
							num7 = 503499534;
							num8 = 503499534;
						}
						num = num7 ^ ((int)num2 * -1885380338);
						continue;
					}
					case 11u:
						flag2 = m_FormBeingCreated != null;
						num = (int)(num2 * 1619116332) ^ -2088300597;
						continue;
					case 10u:
						num = (int)((num2 * 1365117341) ^ 0x2E6D3D0E);
						continue;
					case 8u:
						num = (int)((num2 * 1438657542) ^ 0x74E9A2E4);
						continue;
					case 6u:
						num4 = (((Control)Instance).get_IsDisposed() ? 1 : 0);
						goto IL_0096;
					case 5u:
						m_FormBeingCreated = MyForms.smethod_4();
						num = 299872605;
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = 1409285876;
							num6 = 1409285876;
						}
						else
						{
							num5 = 523906933;
							num6 = 523906933;
						}
						num = num5 ^ (int)(num2 * 65196121);
						continue;
					}
					case 3u:
						if (Instance != null)
						{
							num = ((int)num2 * -859496650) ^ -1479094367;
							continue;
						}
						num4 = 1;
						goto IL_0096;
					case 2u:
						num = 202125045;
						continue;
					case 0u:
						flag = MyForms.smethod_1(m_FormBeingCreated, (object)MyForms.smethod_0(typeof(T).TypeHandle));
						num = (int)((num2 * 802046802) ^ 0x21792705);
						continue;
					case 9u:
						break;
					default:
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
							while (true)
							{
								_ = 1832833684;
								while (true)
								{
									_003F val = /*Error near IL_01b7: Stack underflow*/^ 0x5D18F703;
									num2 = (uint)(int)val;
									switch (val % 3)
									{
									case 1:
										string_ = MyForms.smethod_2("WinForms_SeeInnerException", new string[1] { MyForms.smethod_8(MyForms.smethod_7((Exception)exception_)) });
										_ = (num2 * 799558999) ^ 0x40AB1AE3;
										continue;
									case 0:
										break;
									default:
										throw MyForms.smethod_9(string_, MyForms.smethod_7((Exception)exception_));
									}
									break;
								}
							}
						}
						finally
						{
							MyForms.smethod_10(m_FormBeingCreated, (object)MyForms.smethod_0(typeof(T).TypeHandle));
							while (true)
							{
								IL_0258:
								int num3 = 447079698;
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0x5D18F703u) % 3u)
									{
									case 1u:
										goto IL_022c;
									default:
										goto end_IL_023a;
									case 2u:
										break;
									case 0u:
										goto end_IL_023a;
									}
									goto IL_0258;
									IL_022c:
									num3 = (int)(num2 * 945683882) ^ -409822445;
									continue;
									end_IL_023a:
									break;
								}
								break;
							}
						}
					case 7u:
						{
							throw MyForms.smethod_3(MyForms.smethod_2("WinForms_RecursiveFormCreate", new string[0]));
						}
						IL_0096:
						flag3 = (byte)num4 != 0;
						num = 39727242;
						continue;
					}
					break;
				}
			}
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			while (true)
			{
				int num = -508952723;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEF078A16u) % 5u)
					{
					case 4u:
						instance = default(T);
						num = ((int)num2 * -1600349183) ^ -976043975;
						continue;
					case 3u:
						((Component)instance).Dispose();
						num = ((int)num2 * -58173534) ^ -923535957;
						continue;
					case 2u:
						num = ((int)num2 * -936738063) ^ -853695993;
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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
			while (true)
			{
				int num = 710944510;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x39B61F3u) % 3u)
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
					num = ((int)num2 * -1339492419) ^ 0x558013F7;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			bool result = this.method_0(MyForms.smethod_11(o));
			while (true)
			{
				int num = 961396463;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x243303CCu) % 3u)
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
					num = ((int)num2 * -852756200) ^ -1179931539;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return this.method_1();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			Type result = default(Type);
			while (true)
			{
				int num = 800175280;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCFF7462u) % 4u)
					{
					case 2u:
						result = MyForms.smethod_0(typeof(MyForms).TypeHandle);
						num = ((int)num2 * -418306880) ^ -306071497;
						continue;
					case 1u:
						num = (int)((num2 * 1025219342) ^ 0x63250703);
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
		public override string ToString()
		{
			string result = this.method_2();
			while (true)
			{
				int num = -1287275766;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9CADC334u) % 3u)
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
					num = ((int)num2 * -1236107551) ^ -852060171;
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
			bool result = default(bool);
			while (true)
			{
				int num = -1286702905;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBF0E26B1u) % 4u)
					{
					case 2u:
						result = this.method_0(MyWebServices.smethod_0(o));
						num = ((int)num2 * -1559939343) ^ -1361217022;
						continue;
					case 1u:
						num = ((int)num2 * -46896199) ^ -276002052;
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
		public override int GetHashCode()
		{
			int result = default(int);
			while (true)
			{
				int num = 2147429030;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3BCA35CFu) % 4u)
					{
					case 1u:
						result = this.method_1();
						num = ((int)num2 * -1010544171) ^ -2009652214;
						continue;
					case 0u:
						num = ((int)num2 * -31241720) ^ -1313456219;
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
		internal new Type GetType()
		{
			Type result = MyWebServices.smethod_1(typeof(MyWebServices).TypeHandle);
			while (true)
			{
				int num = -497233957;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF92CD062u) % 3u)
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
					num = (int)((num2 * 1914822413) ^ 0x5A8D4D43);
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
				int num = 1307935960;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA3B13F2u) % 3u)
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
					num = ((int)num2 * -660332361) ^ 0x58C20138;
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				goto IL_0040;
			}
			goto IL_006e;
			IL_006e:
			T result = instance;
			int num = 2105738551;
			goto IL_0045;
			IL_0045:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x441915FEu) % 6u)
				{
				case 5u:
					num = ((int)num2 * -308807544) ^ -1222567838;
					continue;
				case 3u:
					result = new T();
					num = ((int)num2 * -2138480949) ^ 0x2A94D2F8;
					continue;
				case 1u:
					num = ((int)num2 * -1748645325) ^ -260496471;
					continue;
				case 0u:
					break;
				case 4u:
					goto IL_006e;
				default:
					return result;
				}
				break;
			}
			goto IL_0040;
			IL_0040:
			num = 982732539;
			goto IL_0045;
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
				int num = 1290773216;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6526AF5Eu) % 3u)
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
					num = (int)(num2 * 577323709) ^ -633430814;
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
				T threadStaticValue = default(T);
				while (true)
				{
					int num = 1768335632;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x586976FBu) % 5u)
						{
						case 3u:
							threadStaticValue = m_ThreadStaticValue;
							num = 1327792296;
							continue;
						case 2u:
						{
							int num3;
							int num4;
							if (m_ThreadStaticValue != null)
							{
								num3 = -308463039;
								num4 = -308463039;
							}
							else
							{
								num3 = -1232238664;
								num4 = -1232238664;
							}
							num = num3 ^ (int)(num2 * 1300387870);
							continue;
						}
						case 1u:
							m_ThreadStaticValue = new T();
							num = (int)(num2 * 1686356447) ^ -1740964900;
							continue;
						case 0u:
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
			MyComputer getInstance = default(MyComputer);
			while (true)
			{
				int num = -1138379853;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x917E1F88u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return getInstance;
					}
					break;
					IL_0003:
					getInstance = m_ComputerObjectProvider.GetInstance;
					num = (int)(num2 * 38090065) ^ -1362527811;
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
				int num = -1131010659;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA877A985u) % 3u)
					{
					case 1u:
						goto IL_000d;
					case 0u:
						break;
					default:
						return getInstance;
					}
					break;
					IL_000d:
					num = (int)((num2 * 968598426) ^ 0x29C0E17B);
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
				int num = -131394926;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD48AE373u) % 3u)
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
					num = (int)((num2 * 1235316235) ^ 0x252AA509);
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
			MyForms getInstance = default(MyForms);
			while (true)
			{
				int num = 1084369850;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x476CE243u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 768375430) ^ -2145703121;
						continue;
					case 1u:
						getInstance = m_MyFormsObjectProvider.GetInstance;
						num = (int)(num2 * 743330546) ^ -1774498269;
						continue;
					case 3u:
						break;
					default:
						return getInstance;
					}
					break;
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
			MyWebServices getInstance = m_MyWebServicesObjectProvider.GetInstance;
			while (true)
			{
				int num = 2041774097;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6AE5AB61u) % 3u)
					{
					case 1u:
						goto IL_000d;
					case 0u:
						break;
					default:
						return getInstance;
					}
					break;
					IL_000d:
					num = (int)(num2 * 646986322) ^ -1524133403;
				}
			}
		}
	}

	static MyProject()
	{
		while (true)
		{
			int num = 2017069349;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29AA5347u) % 3u)
				{
				case 2u:
					goto IL_000c;
				case 0u:
					break;
				default:
					m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
					return;
				}
				break;
				IL_000c:
				m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
				m_UserObjectProvider = new ThreadSafeObjectProvider<User>();
				m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();
				num = (int)(num2 * 950707899) ^ -1658443600;
			}
		}
	}
}
