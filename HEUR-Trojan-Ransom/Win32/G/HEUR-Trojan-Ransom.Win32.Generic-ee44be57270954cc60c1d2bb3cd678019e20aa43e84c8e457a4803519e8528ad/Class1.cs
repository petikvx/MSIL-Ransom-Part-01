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
internal sealed class Class1
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class2
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form1 form1_0;

		public Form1 Form1_0
		{
			[DebuggerHidden]
			get
			{
				form1_0 = smethod_0(form1_0);
				return form1_0;
			}
			[DebuggerHidden]
			set
			{
				if (value == form1_0)
				{
					goto IL_001a;
				}
				goto IL_0076;
				IL_0076:
				int num;
				int num2;
				if (value != null)
				{
					num = 567401559;
					num2 = 567401559;
				}
				else
				{
					num = 1170391701;
					num2 = 1170391701;
				}
				goto IL_0041;
				IL_0041:
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x3426D47u) % 6u)
					{
					case 5u:
						break;
					case 4u:
						method_0(ref form1_0);
						num = 566084324;
						continue;
					case 1u:
						num = ((int)num3 * -1562241278) ^ 0x49CB70E;
						continue;
					default:
						return;
					case 0u:
						goto IL_0076;
					case 2u:
						throw new ArgumentException("Property can only be set to Nothing");
					case 3u:
						return;
					}
					break;
				}
				goto IL_001a;
				IL_001a:
				num = 1005884466;
				goto IL_0041;
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			bool flag2 = default(bool);
			bool flag = default(bool);
			T result = default(T);
			while (true)
			{
				int num = -1264588709;
				while (true)
				{
					int num5;
					uint num2;
					switch ((num2 = (uint)num ^ 0xC53E154Eu) % 14u)
					{
					case 13u:
					{
						int num8;
						int num9;
						if (flag2)
						{
							num8 = -1007149638;
							num9 = -1007149638;
						}
						else
						{
							num8 = -441170728;
							num9 = -441170728;
						}
						num = num8 ^ ((int)num2 * -223791150);
						continue;
					}
					case 12u:
					{
						int num6;
						int num7;
						if (hashtable_0.ContainsKey(typeof(T)))
						{
							num6 = 84761665;
							num7 = 84761665;
						}
						else
						{
							num6 = 358056877;
							num7 = 358056877;
						}
						num = num6 ^ ((int)num2 * -826339649);
						continue;
					}
					case 11u:
						num = ((int)num2 * -957884381) ^ -812218875;
						continue;
					case 10u:
						num = (int)(num2 * 1784673722) ^ -1031056005;
						continue;
					case 8u:
						num5 = (((Control)gparam_0).get_IsDisposed() ? 1 : 0);
						goto IL_009c;
					case 5u:
						if (gparam_0 != null)
						{
							num = ((int)num2 * -13559864) ^ 0x15CB5C;
							continue;
						}
						num5 = 1;
						goto IL_009c;
					case 4u:
						flag2 = hashtable_0 != null;
						num = ((int)num2 * -951173100) ^ -1246132769;
						continue;
					case 3u:
						num = -1327252090;
						continue;
					case 2u:
						hashtable_0 = new Hashtable();
						num = -885275429;
						continue;
					case 1u:
						num = (int)((num2 * 1248078752) ^ 0x2F38C2EA);
						continue;
					case 0u:
						if (flag)
						{
							num = (int)((num2 * 1614635484) ^ 0xA4DCD18);
							continue;
						}
						while (true)
						{
							int num4 = -1639355301;
							while (true)
							{
								switch ((num2 = (uint)num4 ^ 0xC53E154Eu) % 4u)
								{
								case 2u:
									num4 = (int)((num2 * 279745289) ^ 0x2DF83420);
									continue;
								case 1u:
									result = gparam_0;
									num4 = (int)((num2 * 183144235) ^ 0x51CBCFEF);
									continue;
								case 3u:
									break;
								default:
									return result;
								}
								break;
							}
						}
					case 7u:
						break;
					default:
						hashtable_0.Add(typeof(T), null);
						try
						{
							return new T();
						}
						catch (TargetInvocationException ex) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							ProjectData.SetProjectError((Exception)ex);
							return ex.InnerException != null;
						}).Invoke())
						{
							string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message });
							throw new InvalidOperationException(resourceString, ex.InnerException);
						}
						finally
						{
							while (true)
							{
								IL_0269:
								int num3 = -1702729136;
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0xC53E154Eu) % 3u)
									{
									case 2u:
										goto IL_0229;
									default:
										goto end_IL_024b;
									case 0u:
										break;
									case 1u:
										goto end_IL_024b;
									}
									goto IL_0269;
									IL_0229:
									hashtable_0.Remove(typeof(T));
									num3 = ((int)num2 * -1037130061) ^ 0x1D6AC1B7;
									continue;
									end_IL_024b:
									break;
								}
								break;
							}
						}
					case 9u:
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
						IL_009c:
						flag = (byte)num5 != 0;
						num = -859078386;
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
		public Class2()
		{
			while (true)
			{
				int num = 13052741;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5D4632C1u) % 3u)
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
					num = ((int)num2 * -1256016492) ^ 0x289697FF;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		bool object.Equals(object obj)
		{
			bool result = default(bool);
			while (true)
			{
				int num = 1125089297;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1D0F3BFCu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 511104362) ^ -1229255444;
						continue;
					case 1u:
						result = base.Equals(RuntimeHelpers.GetObjectValue(obj));
						num = (int)(num2 * 203544575) ^ -1547638820;
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
			int hashCode = base.GetHashCode();
			while (true)
			{
				int num = -760098115;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCCFC109Cu) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 2u:
						break;
					default:
						return hashCode;
					}
					break;
					IL_0009:
					num = (int)(num2 * 449705790) ^ -1802121023;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			Type typeFromHandle = default(Type);
			while (true)
			{
				int num = -543889914;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD7ACDDADu) % 4u)
					{
					case 3u:
						typeFromHandle = typeof(Class2);
						num = (int)((num2 * 1786106143) ^ 0x27ADB780);
						continue;
					case 0u:
						num = ((int)num2 * -1274460565) ^ 0xFFC0208;
						continue;
					case 2u:
						break;
					default:
						return typeFromHandle;
					}
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class3
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		bool object.Equals(object obj)
		{
			bool result = default(bool);
			while (true)
			{
				int num = -302355068;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x99FEAB11u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -976378141) ^ -1066366864;
						continue;
					case 1u:
						result = base.Equals(RuntimeHelpers.GetObjectValue(obj));
						num = (int)((num2 * 1021504793) ^ 0x4EF9EA43);
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
		int object.GetHashCode()
		{
			int hashCode = default(int);
			while (true)
			{
				int num = -2099297135;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAE9687ABu) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return hashCode;
					}
					break;
					IL_0003:
					hashCode = base.GetHashCode();
					num = (int)((num2 * 127808493) ^ 0x2D80BF72);
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return typeof(Class3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		string object.ToString()
		{
			string result = base.ToString();
			while (true)
			{
				int num = 1716200163;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x211A135Bu) % 3u)
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
					num = (int)((num2 * 1022178586) ^ 0x57C163F0);
				}
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			T result = default(T);
			while (true)
			{
				int num = 1559008388;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x760714D1u) % 6u)
					{
					case 5u:
						result = gparam_0;
						num = 1985972694;
						continue;
					case 4u:
						result = new T();
						num = (int)((num2 * 477316446) ^ 0x6F3DB3E5);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (gparam_0 != null)
						{
							num3 = 1905159139;
							num4 = 1905159139;
						}
						else
						{
							num3 = 753784436;
							num4 = 753784436;
						}
						num = num3 ^ ((int)num2 * -762324317);
						continue;
					}
					case 0u:
						num = (int)((num2 * 1052056939) ^ 0x506058FE);
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
				int num = 1075884580;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x48A714E0u) % 3u)
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
					num = ((int)num2 * -1054564765) ^ 0x5FFBA9DE;
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class4<T> where T : new()
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
					int num = -1823560575;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xABA1442Eu) % 7u)
						{
						case 6u:
							flag = gparam_0 == null;
							num = (int)((num2 * 348215418) ^ 0x3B189704);
							continue;
						case 5u:
							num = ((int)num2 * -887454389) ^ -1091946420;
							continue;
						case 4u:
							gparam_0 = new T();
							num = (int)((num2 * 1936072141) ^ 0x40E5840D);
							continue;
						case 2u:
						{
							int num3;
							int num4;
							if (!flag)
							{
								num3 = 272602831;
								num4 = 272602831;
							}
							else
							{
								num3 = 1085087972;
								num4 = 1085087972;
							}
							num = num3 ^ (int)(num2 * 787087056);
							continue;
						}
						case 1u:
							result = gparam_0;
							num = -195137728;
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
		public Class4()
		{
			while (true)
			{
				int num = -1327771178;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x92AAC1B9u) % 3u)
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
					num = ((int)num2 * -1566716632) ^ -656689828;
				}
			}
		}
	}

	private static readonly Class4<Class0> class4_0 = new Class4<Class0>();

	private static readonly Class4<Form0> class4_1;

	private static readonly Class4<User> class4_2;

	private static Class4<Class2> class4_3;

	private static readonly Class4<Class3> class4_4;

	[HelpKeyword("My.Computer")]
	internal static Class0 Class0_0
	{
		[DebuggerHidden]
		get
		{
			return class4_0.Prop_0;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			Form0 prop_ = default(Form0);
			while (true)
			{
				int num = -2115342914;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x98224FFDu) % 3u)
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
					prop_ = class4_1.Prop_0;
					num = (int)((num2 * 1661674169) ^ 0x2E90A15A);
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
				int num = -808248225;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD6BF031Cu) % 4u)
					{
					case 3u:
						prop_ = class4_2.Prop_0;
						num = (int)((num2 * 783804481) ^ 0x46246E26);
						continue;
					case 1u:
						num = ((int)num2 * -2080872287) ^ 0x6A41B9EF;
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
	internal static Class2 Class2_0
	{
		[DebuggerHidden]
		get
		{
			Class2 prop_ = class4_3.Prop_0;
			while (true)
			{
				int num = -1758897800;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA1B80FA1u) % 3u)
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
					num = ((int)num2 * -1742021128) ^ -1917159342;
				}
			}
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			Class3 prop_ = default(Class3);
			while (true)
			{
				int num = 1918639947;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1362AF85u) % 3u)
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
					prop_ = class4_4.Prop_0;
					num = ((int)num2 * -1938468774) ^ 0x2D3B06E3;
				}
			}
		}
	}

	static Class1()
	{
		while (true)
		{
			int num = -1354013492;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C9944FFu) % 5u)
				{
				case 4u:
					class4_1 = new Class4<Form0>();
					class4_2 = new Class4<User>();
					num = ((int)num2 * -996797826) ^ -2101293897;
					continue;
				case 2u:
					class4_4 = new Class4<Class3>();
					num = (int)(num2 * 60269316) ^ -1017743222;
					continue;
				case 0u:
					class4_3 = new Class4<Class2>();
					num = (int)(num2 * 1530825638) ^ -543991743;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}
}
