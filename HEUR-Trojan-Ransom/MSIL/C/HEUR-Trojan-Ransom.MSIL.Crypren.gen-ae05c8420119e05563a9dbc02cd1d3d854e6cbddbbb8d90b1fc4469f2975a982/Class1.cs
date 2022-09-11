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
using antlr;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Class1
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class2
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public frmCage frmCage_0;

		public frmCage FrmCage_0
		{
			[DebuggerHidden]
			get
			{
				frmCage_0 = smethod_0(frmCage_0);
				return frmCage_0;
			}
			[DebuggerHidden]
			set
			{
				if ((value != frmCage_0) ? true : false)
				{
					if (value != null || 1 == 0)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					method_0(ref frmCage_0);
				}
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if (gparam_0 == null || ((Control)gparam_0).get_IsDisposed() || 1 == 0)
			{
				if (hashtable_0 != null || 1 == 0)
				{
					if (hashtable_0.ContainsKey(typeof(T)) || 1 == 0)
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					hashtable_0 = new Hashtable();
				}
				hashtable_0.Add(typeof(T), null);
				TargetInvocationException ex = default(TargetInvocationException);
				try
				{
					return new T();
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					TargetInvocationException obj2 = obj as TargetInvocationException;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
					if (obj2 == null && 0 == 0)
					{
						result = 0;
					}
					else
					{
						ProjectData.SetProjectError((Exception)obj2);
						ex = obj2;
						result = ((ex.InnerException != null) ? 1 : 0);
					}
					return (byte)result != 0;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message });
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					hashtable_0.Remove(typeof(T));
				}
			}
			return gparam_0;
		}

		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			while (true)
			{
				int num = Class40.smethod_2(60);
				int num2 = 24;
				while (true)
				{
					num2 ^= 0x4C;
					while (true)
					{
						int num3 = 11;
						int num4 = 9;
						while (true)
						{
							num4 ^= 0x51;
							while (true)
							{
								int num5 = 6;
								int num6 = -1;
								while (true)
								{
									num6 ^= 0x54;
									while (true)
									{
										int num7 = Class40.smethod_2(54);
										int num8 = 5;
										while (true)
										{
											num8 ^= 0x53;
											int num9 = Class24.smethod_0(56);
											int num10 = -1;
											num10 = -89;
											while (true)
											{
												IL_01ef:
												num9 ^= 0x58;
												while (true)
												{
													num10 = Class40.smethod_2(54);
													while (true)
													{
														switch (num10 ^ 0x58)
														{
														case -90:
															num10 = Class24.smethod_0(52);
															continue;
														case -91:
															goto end_IL_0030;
														case -92:
															goto IL_005d;
														case -89:
															goto IL_01ef;
														}
														break;
													}
													continue;
													end_IL_0030:
													break;
												}
												switch (num9)
												{
												case -89:
													goto IL_0072;
												case -88:
													goto IL_007a;
												case -90:
													goto IL_01e3;
												case -87:
													goto end_IL_01ef;
												}
												num10 = -4;
												num10 = -92;
												goto IL_005d;
												IL_01e3:
												num8 = 7;
												num9 = Class40.smethod_2(60);
												continue;
												IL_01c8:
												num5 ^= 0x52;
												goto IL_01cf;
												IL_007a:
												switch (num8)
												{
												case 84:
													goto IL_009d;
												case 86:
													goto IL_01dc;
												case 85:
													goto IL_0200;
												case 83:
													goto end_IL_0203;
												}
												num9 = -2;
												continue;
												IL_0200:
												num8 = 6;
												break;
												IL_009d:
												switch (num7)
												{
												case -80:
													break;
												case -79:
													goto IL_00c5;
												case -81:
													goto IL_01cf;
												default:
													goto IL_01fb;
												case -78:
													goto end_IL_021c;
												}
												num7 = -4;
												goto IL_01dc;
												IL_01fb:
												num8 = 0;
												break;
												IL_00c5:
												switch (num6)
												{
												case -86:
													goto IL_00e8;
												case -85:
													goto IL_01c8;
												case -87:
													goto IL_022a;
												case -88:
													goto end_IL_0234;
												}
												num7 = -29;
												goto IL_01dc;
												IL_022a:
												num6 = -3;
												goto end_IL_021c;
												IL_00e8:
												switch (num5)
												{
												case 83:
													break;
												case 84:
													goto IL_010f;
												case 85:
													goto IL_01c3;
												default:
													goto IL_0230;
												case 86:
													goto end_IL_023d;
												}
												num5 = 1;
												goto IL_01c8;
												IL_0230:
												num6 = -4;
												goto end_IL_021c;
												IL_010f:
												switch (num4)
												{
												case 85:
													goto IL_0130;
												case 88:
													goto IL_01be;
												case 87:
													goto IL_0249;
												case 86:
													goto end_IL_024b;
												}
												num5 = 7;
												goto IL_01c8;
												IL_0249:
												num4 = 6;
												goto end_IL_023d;
												IL_0130:
												switch (num3)
												{
												case 82:
													break;
												case 81:
													goto IL_01b3;
												case 83:
													goto IL_01bb;
												default:
													goto IL_0245;
												case 84:
													goto end_IL_0252;
												}
												switch (num2)
												{
												case 81:
													goto IL_016b;
												case 84:
													goto IL_01ae;
												case 83:
													goto IL_025f;
												case 82:
													goto end_IL_0262;
												}
												num3 = 8;
												goto IL_01be;
												IL_0245:
												num4 = 7;
												goto end_IL_023d;
												IL_01bb:
												num3 = 10;
												goto IL_01be;
												IL_0072:
												num9 = -1;
												continue;
												IL_025f:
												num2 = 31;
												goto end_IL_0252;
												IL_016b:
												switch (num)
												{
												case -79:
													break;
												case -78:
													goto IL_019a;
												case -77:
													goto IL_019f;
												default:
													goto IL_025a;
												case -76:
													return;
												}
												gparam_0 = default(T);
												num = Class24.smethod_0(51);
												goto IL_01ae;
												IL_025a:
												num2 = 30;
												goto end_IL_0252;
												IL_019f:
												((Component)gparam_0).Dispose();
												num = -13;
												goto IL_01ae;
												IL_019a:
												num = -16;
												goto IL_01ae;
												IL_005d:
												num9 = Class24.smethod_0(56);
												num10 = -1;
												num10 = -89;
												continue;
												IL_01ae:
												num ^= 0x42;
												goto IL_01b3;
												IL_01b3:
												num2 = 29;
												num3 = 13;
												goto IL_01be;
												IL_01cf:
												num6 = Class24.smethod_0(52);
												num7 = -2;
												goto IL_01dc;
												IL_01be:
												num3 ^= 0x59;
												goto IL_01c3;
												IL_01c3:
												num4 = 4;
												num5 = 4;
												goto IL_01c8;
												IL_01dc:
												num7 ^= 0x4C;
												goto IL_01e3;
												continue;
												end_IL_01ef:
												break;
											}
											continue;
											end_IL_0203:
											break;
										}
										continue;
										end_IL_021c:
										break;
									}
									continue;
									end_IL_0234:
									break;
								}
								continue;
								end_IL_023d:
								break;
							}
							continue;
							end_IL_024b:
							break;
						}
						continue;
						end_IL_0252:
						break;
					}
					continue;
					end_IL_0262:
					break;
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class2()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			bool result = default(bool);
			while (true)
			{
				int num = 28;
				int num2 = 14;
				while (true)
				{
					num2 ^= 0x56;
					while (true)
					{
						int num3 = 12;
						int num4 = ANTLRPanicException.smethod_0(81);
						while (true)
						{
							num4 ^= 0x56;
							while (true)
							{
								int num5 = Class15.smethod_0(78);
								int num6 = -11;
								while (true)
								{
									num6 ^= 0x5B;
									while (true)
									{
										int num7 = Class24.smethod_0(50);
										int num8 = 28;
										while (true)
										{
											IL_01bd:
											num8 ^= 0x4C;
											int num9 = Class24.smethod_0(50);
											while (true)
											{
												switch (num9 ^ 0x5C)
												{
												default:
													num9 = Class24.smethod_0(50);
													continue;
												case -90:
													break;
												case -91:
													goto IL_0054;
												case -89:
													goto IL_01bd;
												case -92:
													while (true)
													{
														num9 = -8;
														num9 = -92;
													}
												}
												break;
											}
											switch (num8)
											{
											case 77:
												goto IL_0064;
											case 79:
												goto IL_006c;
											case 80:
												goto IL_01ab;
											case 78:
												goto end_IL_01bd;
											}
											num9 = -7;
											num9 = -91;
											goto IL_0054;
											IL_008e:
											num7 = Class40.smethod_2(62);
											goto IL_01ab;
											IL_0197:
											num5 ^= 0x52;
											goto IL_019e;
											IL_006c:
											switch (num7)
											{
											case -75:
												goto IL_008e;
											case -74:
												goto IL_009c;
											case -76:
												goto IL_019e;
											case -73:
												goto end_IL_01d2;
											}
											num8 = 2;
											continue;
											IL_009c:
											switch (num6)
											{
											case -83:
												goto IL_00bf;
											case -82:
												goto IL_0197;
											case -85:
												goto IL_01e1;
											case -84:
												goto end_IL_01eb;
											}
											num7 = -8;
											goto IL_01ab;
											IL_01e1:
											num6 = -16;
											goto end_IL_01d2;
											IL_00bf:
											switch (num5)
											{
											case -90:
												break;
											case -89:
												goto IL_0184;
											case -88:
												goto IL_0193;
											default:
												goto IL_01e7;
											case -87:
												goto end_IL_01f4;
											}
											switch (num4)
											{
											case -82:
												goto IL_0101;
											case -80:
												goto IL_017f;
											case -83:
												goto IL_0203;
											case -81:
												goto end_IL_020d;
											}
											num5 = -11;
											goto IL_0197;
											IL_01e7:
											num6 = -9;
											goto end_IL_01d2;
											IL_0193:
											num5 = -6;
											goto IL_0197;
											IL_01ab:
											num7 ^= 0x4C;
											num8 = 3;
											num9 = -5;
											num9 = -89;
											continue;
											IL_0203:
											num4 = -5;
											goto end_IL_01f4;
											IL_0101:
											switch (num3)
											{
											case 88:
												break;
											case 90:
												goto IL_0124;
											case 89:
												goto IL_017a;
											default:
												goto IL_0209;
											case 91:
												goto end_IL_0216;
											}
											num3 = 14;
											goto IL_017f;
											IL_0209:
											num4 = -7;
											goto end_IL_01f4;
											IL_0124:
											switch (num2)
											{
											case 86:
												goto IL_0142;
											case 88:
												goto IL_0175;
											case 85:
												goto IL_0224;
											case 87:
												goto end_IL_022a;
											}
											num3 = 15;
											goto IL_017f;
											IL_0224:
											num2 = 3;
											goto end_IL_0216;
											IL_0142:
											switch (num)
											{
											case 81:
												break;
											case 83:
												goto IL_0165;
											default:
												goto IL_0228;
											case 82:
											case 84:
												return result;
											}
											num = 30;
											goto IL_0175;
											IL_0228:
											num2 = 1;
											goto end_IL_0216;
											IL_0165:
											result = base.Equals(RuntimeHelpers.GetObjectValue(o));
											num = 29;
											goto IL_0175;
											IL_0054:
											num8 = 3;
											num9 = -5;
											num9 = -89;
											continue;
											IL_0175:
											num ^= 0x4F;
											goto IL_017a;
											IL_017a:
											num2 = 0;
											num3 = 13;
											goto IL_017f;
											IL_019e:
											num6 = Class24.smethod_0(51);
											num7 = -5;
											goto IL_01ab;
											IL_0064:
											num8 = 1;
											continue;
											IL_017f:
											num3 ^= 0x56;
											goto IL_0184;
											IL_0184:
											num4 = Class15.smethod_0(74);
											num5 = -5;
											goto IL_0197;
											continue;
											end_IL_01bd:
											break;
										}
										continue;
										end_IL_01d2:
										break;
									}
									continue;
									end_IL_01eb:
									break;
								}
								continue;
								end_IL_01f4:
								break;
							}
							continue;
							end_IL_020d:
							break;
						}
						continue;
						end_IL_0216:
						break;
					}
					continue;
					end_IL_022a:
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int hashCode = default(int);
			while (true)
			{
				int num = Class15.smethod_0(76);
				int num2 = -23;
				while (true)
				{
					num2 ^= 0x59;
					while (true)
					{
						int num3 = 30;
						int num4 = -17;
						while (true)
						{
							num4 ^= 0x58;
							while (true)
							{
								int num5 = 4;
								int num6 = -32;
								while (true)
								{
									num6 ^= 0x55;
									while (true)
									{
										int num7 = 21;
										int num8 = Class40.smethod_2(54);
										while (true)
										{
											IL_01bf:
											num8 ^= 0x50;
											int num9 = ANTLRPanicException.smethod_0(89);
											while (true)
											{
												switch (num9 ^ 0x4F)
												{
												default:
													num9 = ANTLRPanicException.smethod_0(89);
													continue;
												case -82:
													break;
												case -81:
													goto IL_01af;
												case -80:
													goto IL_01bf;
												case -83:
													while (true)
													{
														num9 = -30;
														num9 = -83;
													}
												}
												break;
											}
											switch (num8)
											{
											case -85:
												goto IL_0059;
											case -84:
												goto IL_0190;
											case -83:
												goto IL_0196;
											case -86:
												goto end_IL_01bf;
											}
											num9 = -32;
											num9 = -81;
											goto IL_01af;
											IL_015e:
											num3 ^= 0x4C;
											goto IL_0163;
											IL_0163:
											num4 = ANTLRPanicException.smethod_0(80);
											num5 = 6;
											goto IL_0174;
											IL_0190:
											num8 = -4;
											continue;
											IL_0059:
											switch (num7)
											{
											case 90:
												goto IL_007c;
											case 91:
												goto IL_017b;
											case 92:
												goto IL_018a;
											case 93:
												goto end_IL_01d4;
											}
											num8 = -6;
											continue;
											IL_018a:
											num7 = 19;
											goto IL_0196;
											IL_007c:
											switch (num6)
											{
											case -76:
												goto IL_009f;
											case -75:
												goto IL_0174;
											case -77:
												goto IL_01e3;
											case -78:
												goto end_IL_01f2;
											}
											num7 = 20;
											goto IL_0196;
											IL_01e3:
											num6 = -26;
											goto end_IL_01d4;
											IL_009f:
											switch (num5)
											{
											case 85:
												break;
											case 84:
												goto IL_0163;
											case 86:
												goto IL_0171;
											default:
												goto IL_01e9;
											case 87:
												goto end_IL_01fb;
											}
											switch (num4)
											{
											case -76:
												goto IL_00e0;
											case -73:
												goto IL_015e;
											case -74:
												goto IL_020a;
											case -75:
												goto end_IL_020e;
											}
											num5 = 5;
											goto IL_0174;
											IL_01e9:
											num6 = Class48.smethod_2(70);
											goto end_IL_01d4;
											IL_0171:
											num5 = 7;
											goto IL_0174;
											IL_017b:
											num6 = ANTLRPanicException.smethod_0(89);
											num7 = 18;
											goto IL_0196;
											IL_020a:
											num4 = -18;
											goto end_IL_01fb;
											IL_00e0:
											switch (num3)
											{
											case 82:
												break;
											case 81:
												goto IL_014e;
											case 83:
												goto IL_015b;
											default:
												goto IL_0204;
											case 84:
												goto end_IL_0217;
											}
											switch (num2)
											{
											case -81:
												goto IL_011c;
											case -80:
												goto IL_0149;
											case -82:
												goto IL_0220;
											case -83:
												goto end_IL_022d;
											}
											num3 = 29;
											goto IL_015e;
											IL_0204:
											num4 = -19;
											goto end_IL_01fb;
											IL_015b:
											num3 = 31;
											goto IL_015e;
											IL_0174:
											num5 ^= 0x51;
											goto IL_017b;
											IL_0220:
											num2 = Class24.smethod_0(47);
											goto end_IL_0217;
											IL_011c:
											switch (num)
											{
											case -84:
												break;
											case -83:
												goto IL_013f;
											default:
												goto IL_022a;
											case -82:
											case -81:
												return hashCode;
											}
											num = -31;
											goto IL_0149;
											IL_022a:
											num2 = -12;
											goto end_IL_0217;
											IL_013f:
											hashCode = base.GetHashCode();
											num = -29;
											goto IL_0149;
											IL_01af:
											num8 = Class24.smethod_0(59);
											num9 = -1;
											num9 = -80;
											continue;
											IL_0149:
											num ^= 0x4D;
											goto IL_014e;
											IL_014e:
											num2 = Class24.smethod_0(51);
											num3 = 24;
											goto IL_015e;
											IL_0196:
											num7 ^= 0x4F;
											num8 = Class24.smethod_0(59);
											num9 = -1;
											num9 = -80;
											continue;
											end_IL_01bf:
											break;
										}
										continue;
										end_IL_01d4:
										break;
									}
									continue;
									end_IL_01f2:
									break;
								}
								continue;
								end_IL_01fb:
								break;
							}
							continue;
							end_IL_020e:
							break;
						}
						continue;
						end_IL_0217:
						break;
					}
					continue;
					end_IL_022d:
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			Type typeFromHandle = default(Type);
			while (true)
			{
				int num = Class24.smethod_0(47);
				int num2 = 21;
				while (true)
				{
					num2 ^= 0x4C;
					while (true)
					{
						int num3 = Class40.smethod_2(62);
						int num4 = 4;
						while (true)
						{
							num4 ^= 0x53;
							while (true)
							{
								int num5 = 14;
								int num6 = -7;
								while (true)
								{
									num6 ^= 0x55;
									while (true)
									{
										int num7 = Class24.smethod_0(51);
										int num8 = 2;
										while (true)
										{
											num8 ^= 0x55;
											while (true)
											{
												int num9 = 1;
												int num10 = Class15.smethod_0(74);
												while (true)
												{
													switch (num10 ^ 0x50)
													{
													case -88:
														break;
													default:
														goto IL_000d;
													case -89:
														goto IL_001b;
													case -91:
														goto end_IL_01b3;
													case -90:
														while (true)
														{
															num10 = -10;
															num10 = -90;
														}
													}
													goto IL_0006;
													IL_001b:
													switch (num9)
													{
													case 90:
														break;
													case 91:
														goto IL_01a0;
													case 92:
														goto IL_01a8;
													default:
														goto IL_01d9;
													case 93:
														goto end_IL_01e1;
													}
													switch (num8)
													{
													case 85:
														goto IL_0059;
													case 87:
														goto IL_0197;
													case 84:
														goto IL_01ef;
													case 86:
														goto end_IL_01f7;
													}
													num9 = 7;
													goto IL_0006;
													IL_01d9:
													num10 = -11;
													num10 = -91;
													break;
													IL_01a0:
													num9 = 0;
													goto IL_0006;
													IL_0197:
													num7 ^= 0x50;
													goto IL_01a8;
													IL_01ef:
													num8 = 1;
													goto end_IL_01e1;
													IL_0059:
													switch (num7)
													{
													case -90:
														break;
													case -89:
														goto IL_0184;
													case -88:
														goto IL_0193;
													default:
														goto IL_01f4;
													case -87:
														goto end_IL_0200;
													}
													switch (num6)
													{
													case -86:
														goto IL_00a0;
													case -84:
														goto IL_017d;
													case -87:
														goto IL_020e;
													case -85:
														goto end_IL_021d;
													}
													num7 = Class24.smethod_0(47);
													goto IL_0197;
													IL_01f4:
													num8 = 3;
													goto end_IL_01e1;
													IL_0193:
													num7 = -8;
													goto IL_0197;
													IL_0184:
													num6 = Class24.smethod_0(57);
													num7 = -7;
													goto IL_0197;
													IL_020e:
													num6 = -4;
													goto end_IL_0200;
													IL_00a0:
													switch (num5)
													{
													case 82:
														break;
													case 84:
														goto IL_00c7;
													case 83:
														goto IL_0176;
													default:
														goto IL_0214;
													case 85:
														goto end_IL_0226;
													}
													num5 = 8;
													goto IL_017d;
													IL_0214:
													num6 = Class24.smethod_0(52);
													goto end_IL_0200;
													IL_00c7:
													switch (num4)
													{
													case 86:
														goto IL_00ea;
													case 87:
														goto IL_0171;
													case 85:
														goto IL_0230;
													case 84:
														goto end_IL_0238;
													}
													num5 = 9;
													goto IL_017d;
													IL_0230:
													num4 = 6;
													goto end_IL_0226;
													IL_00ea:
													switch (num3)
													{
													case -77:
														break;
													case -75:
														goto IL_0112;
													case -76:
														goto IL_016b;
													default:
														goto IL_0235;
													case -74:
														goto end_IL_0241;
													}
													num3 = Class24.smethod_0(57);
													goto IL_0171;
													IL_0235:
													num4 = 7;
													goto end_IL_0226;
													IL_0112:
													switch (num2)
													{
													case 88:
														goto IL_0130;
													case 89:
														goto IL_0166;
													case 86:
														goto IL_024e;
													case 87:
														goto end_IL_0256;
													}
													num3 = -8;
													goto IL_0171;
													IL_024e:
													num2 = 26;
													goto end_IL_0241;
													IL_0130:
													switch (num)
													{
													case -91:
														break;
													case -90:
														goto IL_0158;
													default:
														goto IL_0253;
													case -89:
													case -88:
														return typeFromHandle;
													}
													num = Class15.smethod_0(78);
													goto IL_0166;
													IL_0253:
													num2 = 27;
													goto end_IL_0241;
													IL_0158:
													typeFromHandle = typeof(Class2);
													num = -10;
													goto IL_0166;
													IL_000d:
													num10 = Class24.smethod_0(47);
													continue;
													IL_0166:
													num ^= 0x51;
													goto IL_016b;
													IL_016b:
													num2 = 20;
													num3 = -6;
													goto IL_0171;
													IL_0006:
													num9 ^= 0x5B;
													goto IL_000d;
													IL_017d:
													num5 ^= 0x5A;
													goto IL_0184;
													IL_0171:
													num3 ^= 0x4C;
													goto IL_0176;
													IL_0176:
													num4 = 5;
													num5 = 15;
													goto IL_017d;
													IL_01a8:
													num8 = 0;
													num9 = 6;
													goto IL_0006;
													continue;
													end_IL_01b3:
													break;
												}
												continue;
												end_IL_01e1:
												break;
											}
											continue;
											end_IL_01f7:
											break;
										}
										continue;
										end_IL_0200:
										break;
									}
									continue;
									end_IL_021d:
									break;
								}
								continue;
								end_IL_0226:
								break;
							}
							continue;
							end_IL_0238:
							break;
						}
						continue;
						end_IL_0241:
						break;
					}
					continue;
					end_IL_0256:
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
				int num = Class40.smethod_2(61);
				int num2 = 0;
				while (true)
				{
					num2 ^= 0x59;
					while (true)
					{
						int num3 = 31;
						int num4 = -4;
						while (true)
						{
							num4 ^= 0x4D;
							while (true)
							{
								int num5 = 5;
								int num6 = -27;
								while (true)
								{
									num6 ^= 0x55;
									while (true)
									{
										int num7 = ANTLRPanicException.smethod_0(91);
										int num8 = -7;
										while (true)
										{
											IL_01c7:
											num8 ^= 0x4F;
											int num9 = Class40.smethod_2(58);
											while (true)
											{
												switch (num9 ^ 0x5A)
												{
												default:
													num9 = Class40.smethod_2(58);
													continue;
												case -87:
													break;
												case -88:
													goto IL_0054;
												case -86:
													goto IL_01c7;
												case -89:
													while (true)
													{
														num9 = -3;
														num9 = -89;
													}
												}
												break;
											}
											switch (num8)
											{
											case -77:
												goto IL_006a;
											case -76:
												goto IL_0073;
											case -74:
												goto IL_01af;
											case -75:
												goto end_IL_01c7;
											}
											num9 = -14;
											num9 = -88;
											goto IL_0054;
											IL_019c:
											num6 = Class24.smethod_0(59);
											num7 = -17;
											goto IL_01af;
											IL_01af:
											num7 ^= 0x59;
											num8 = Class24.smethod_0(59);
											num9 = -16;
											num9 = -86;
											continue;
											IL_0073:
											switch (num7)
											{
											case -76:
												goto IL_0096;
											case -77:
												goto IL_019c;
											case -75:
												goto IL_01ab;
											case -74:
												goto end_IL_01dc;
											}
											num8 = -6;
											continue;
											IL_01ab:
											num7 = -20;
											goto IL_01af;
											IL_0096:
											switch (num6)
											{
											case -82:
												goto IL_00be;
											case -80:
												goto IL_0195;
											case -81:
												goto IL_01f1;
											case -83:
												goto end_IL_01f5;
											}
											num7 = ANTLRPanicException.smethod_0(86);
											goto IL_01af;
											IL_01f1:
											num6 = -6;
											goto end_IL_01dc;
											IL_00be:
											switch (num5)
											{
											case 80:
												break;
											case 82:
												goto IL_00e5;
											case 81:
												goto IL_0189;
											default:
												goto IL_01eb;
											case 83:
												goto end_IL_01fe;
											}
											num5 = 7;
											goto IL_0195;
											IL_01eb:
											num6 = -8;
											goto end_IL_01dc;
											IL_00e5:
											switch (num4)
											{
											case -80:
												goto IL_0107;
											case -79:
												goto IL_0184;
											case -82:
												goto IL_0207;
											case -81:
												goto end_IL_0216;
											}
											num5 = 6;
											goto IL_0195;
											IL_0207:
											num4 = Class15.smethod_0(66);
											goto end_IL_01fe;
											IL_0107:
											switch (num3)
											{
											case 81:
												break;
											case 83:
												goto IL_012a;
											case 82:
												goto IL_017f;
											default:
												goto IL_0212;
											case 84:
												goto end_IL_021f;
											}
											num3 = 29;
											goto IL_0184;
											IL_0212:
											num4 = -30;
											goto end_IL_01fe;
											IL_012a:
											switch (num2)
											{
											case 88:
												goto IL_0148;
											case 89:
												goto IL_017a;
											case 87:
												goto IL_0228;
											case 86:
												goto end_IL_0230;
											}
											num3 = 30;
											goto IL_0184;
											IL_0228:
											num2 = 14;
											goto end_IL_021f;
											IL_0148:
											switch (num)
											{
											case -84:
												break;
											case -83:
												goto IL_0172;
											default:
												goto IL_022d;
											case -82:
											case -81:
												return result;
											}
											result = base.ToString();
											num = -2;
											goto IL_017a;
											IL_022d:
											num2 = 15;
											goto end_IL_021f;
											IL_0172:
											num = Class40.smethod_2(54);
											goto IL_017a;
											IL_0054:
											num8 = Class24.smethod_0(59);
											num9 = -16;
											num9 = -86;
											continue;
											IL_017a:
											num ^= 0x50;
											goto IL_017f;
											IL_017f:
											num2 = 1;
											num3 = 24;
											goto IL_0184;
											IL_0195:
											num5 ^= 0x57;
											goto IL_019c;
											IL_006a:
											num8 = -4;
											continue;
											IL_0184:
											num3 ^= 0x4C;
											goto IL_0189;
											IL_0189:
											num4 = Class40.smethod_2(54);
											num5 = 4;
											goto IL_0195;
											continue;
											end_IL_01c7:
											break;
										}
										continue;
										end_IL_01dc:
										break;
									}
									continue;
									end_IL_01f5:
									break;
								}
								continue;
								end_IL_01fe:
								break;
							}
							continue;
							end_IL_0216:
							break;
						}
						continue;
						end_IL_021f:
						break;
					}
					continue;
					end_IL_0230:
					break;
				}
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			bool result = default(bool);
			while (true)
			{
				int num = Class15.smethod_0(76);
				int num2 = 1;
				while (true)
				{
					num2 ^= 0x51;
					while (true)
					{
						int num3 = ANTLRPanicException.smethod_0(77);
						int num4 = 24;
						while (true)
						{
							num4 ^= 0x4D;
							while (true)
							{
								int num5 = ANTLRPanicException.smethod_0(81);
								int num6 = 0;
								while (true)
								{
									num6 ^= 0x55;
									while (true)
									{
										int num7 = Class24.smethod_0(52);
										int num8 = -1;
										while (true)
										{
											IL_01ce:
											num8 ^= 0x4F;
											int num9 = Class40.smethod_2(58);
											while (true)
											{
												switch (num9 ^ 0x5A)
												{
												default:
													num9 = Class40.smethod_2(58);
													continue;
												case -87:
													break;
												case -88:
													goto IL_0054;
												case -85:
													goto IL_01ce;
												case -86:
													while (true)
													{
														num9 = -16;
														num9 = -86;
													}
												}
												break;
											}
											switch (num8)
											{
											case -82:
												goto IL_006a;
											case -81:
												goto IL_0073;
											case -80:
												goto IL_01b6;
											case -83:
												goto end_IL_01ce;
											}
											num9 = -14;
											num9 = -88;
											goto IL_0054;
											IL_009b:
											num7 = Class15.smethod_0(76);
											goto IL_01b6;
											IL_01a8:
											num5 ^= 0x56;
											goto IL_01af;
											IL_0073:
											switch (num7)
											{
											case -81:
												goto IL_009b;
											case -79:
												goto IL_00a9;
											case -80:
												goto IL_01af;
											case -78:
												goto end_IL_01e3;
											}
											num8 = Class24.smethod_0(48);
											continue;
											IL_00a9:
											switch (num6)
											{
											case 83:
												goto IL_00cb;
											case 85:
												goto IL_01a8;
											case 84:
												goto IL_01f6;
											case 82:
												goto end_IL_01f9;
											}
											num7 = -1;
											goto IL_01b6;
											IL_01f6:
											num6 = 1;
											goto end_IL_01e3;
											IL_00cb:
											switch (num5)
											{
											case -80:
												break;
											case -79:
												goto IL_019a;
											case -78:
												goto IL_01a0;
											default:
												goto IL_01f1;
											case -77:
												goto end_IL_0202;
											}
											switch (num4)
											{
											case 84:
												goto IL_010d;
											case 85:
												goto IL_0193;
											case 82:
												goto IL_0210;
											case 83:
												goto end_IL_021a;
											}
											num5 = -28;
											goto IL_01a8;
											IL_01f1:
											num6 = 7;
											goto end_IL_01e3;
											IL_019a:
											num5 = -25;
											goto IL_01a8;
											IL_01b6:
											num7 ^= 0x4F;
											num8 = Class15.smethod_0(76);
											num9 = -15;
											num9 = -85;
											continue;
											IL_0210:
											num4 = 31;
											goto end_IL_0202;
											IL_010d:
											switch (num3)
											{
											case -82:
												break;
											case -81:
												goto IL_0183;
											case -80:
												goto IL_018d;
											default:
												goto IL_0216;
											case -79:
												goto end_IL_0223;
											}
											switch (num2)
											{
											case 77:
												goto IL_0149;
											case 80:
												goto IL_017c;
											case 78:
												goto IL_0236;
											case 79:
												goto end_IL_0239;
											}
											num3 = -21;
											goto IL_0193;
											IL_0216:
											num4 = 30;
											goto end_IL_0202;
											IL_0183:
											num3 = Class15.smethod_0(78);
											goto IL_0193;
											IL_006a:
											num8 = -31;
											continue;
											IL_0236:
											num2 = 31;
											goto end_IL_0223;
											IL_0149:
											switch (num)
											{
											case -83:
												break;
											case -81:
												goto IL_0179;
											default:
												goto IL_0231;
											case -82:
											case -80:
												return result;
											}
											result = base.Equals(RuntimeHelpers.GetObjectValue(o));
											num = -29;
											goto IL_017c;
											IL_0231:
											num2 = 30;
											goto end_IL_0223;
											IL_0179:
											num = -30;
											goto IL_017c;
											IL_0054:
											num8 = Class15.smethod_0(76);
											num9 = -15;
											num9 = -85;
											continue;
											IL_017c:
											num ^= 0x4D;
											goto IL_018d;
											IL_018d:
											num2 = 28;
											num3 = -22;
											goto IL_0193;
											IL_01af:
											num6 = 6;
											num7 = -3;
											goto IL_01b6;
											IL_0193:
											num3 ^= 0x5B;
											goto IL_01a0;
											IL_01a0:
											num4 = 25;
											num5 = -27;
											goto IL_01a8;
											continue;
											end_IL_01ce:
											break;
										}
										continue;
										end_IL_01e3:
										break;
									}
									continue;
									end_IL_01f9:
									break;
								}
								continue;
								end_IL_0202:
								break;
							}
							continue;
							end_IL_021a:
							break;
						}
						continue;
						end_IL_0223:
						break;
					}
					continue;
					end_IL_0239:
					break;
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int hashCode = default(int);
			while (true)
			{
				int num = 5;
				int num2 = -29;
				while (true)
				{
					num2 ^= 0x55;
					while (true)
					{
						int num3 = Class15.smethod_0(78);
						int num4 = 30;
						while (true)
						{
							num4 ^= 0x4C;
							while (true)
							{
								int num5 = ANTLRPanicException.smethod_0(81);
								int num6 = 11;
								while (true)
								{
									num6 ^= 0x56;
									while (true)
									{
										int num7 = Class40.smethod_2(58);
										int num8 = 14;
										while (true)
										{
											num8 ^= 0x5B;
											int num9 = Class15.smethod_0(76);
											while (true)
											{
												switch (num9 ^ 0x4E)
												{
												case -82:
													break;
												case -83:
													goto IL_0171;
												default:
													num9 = Class15.smethod_0(76);
													continue;
												case -80:
													goto end_IL_0188;
												case -81:
													while (true)
													{
														num9 = -31;
														num9 = -81;
													}
												}
												switch (num8)
												{
												case 83:
													goto IL_002d;
												case 85:
													goto IL_016a;
												case 82:
													goto IL_01ab;
												case 84:
													goto end_IL_01b5;
												}
												num9 = -29;
												num9 = -83;
												goto IL_0171;
												IL_015b:
												num5 ^= 0x52;
												goto IL_0162;
												IL_01ab:
												num8 = 9;
												break;
												IL_002d:
												switch (num7)
												{
												case -82:
													break;
												case -81:
													goto IL_0055;
												case -80:
													goto IL_0162;
												default:
													goto IL_01b1;
												case -79:
													goto end_IL_01c7;
												}
												num7 = -14;
												goto IL_016a;
												IL_01b1:
												num8 = 15;
												break;
												IL_0055:
												switch (num6)
												{
												case 91:
													goto IL_007d;
												case 93:
													goto IL_015b;
												case 92:
													goto IL_01dc;
												case 90:
													goto end_IL_01e0;
												}
												num7 = ANTLRPanicException.smethod_0(80);
												goto IL_016a;
												IL_01dc:
												num6 = 10;
												goto end_IL_01c7;
												IL_007d:
												switch (num5)
												{
												case -77:
													break;
												case -76:
													goto IL_00aa;
												case -75:
													goto IL_0153;
												default:
													goto IL_01d6;
												case -74:
													goto end_IL_01e9;
												}
												num5 = ANTLRPanicException.smethod_0(89);
												goto IL_015b;
												IL_01d6:
												num6 = 12;
												goto end_IL_01c7;
												IL_00aa:
												switch (num4)
												{
												case 81:
													goto IL_00cd;
												case 82:
													goto IL_014e;
												case 80:
													goto IL_01f8;
												case 79:
													goto end_IL_0201;
												}
												num5 = -25;
												goto IL_015b;
												IL_01f8:
												num4 = 28;
												goto end_IL_01e9;
												IL_00cd:
												switch (num3)
												{
												case -82:
													break;
												case -83:
													goto IL_0139;
												case -81:
													goto IL_0146;
												default:
													goto IL_01fe;
												case -80:
													goto end_IL_020a;
												}
												switch (num2)
												{
												case -77:
													goto IL_0109;
												case -74:
													goto IL_0134;
												case -75:
													goto IL_0222;
												case -76:
													goto end_IL_0225;
												}
												num3 = -9;
												goto IL_014e;
												IL_01fe:
												num4 = 3;
												goto end_IL_01e9;
												IL_0146:
												num3 = ANTLRPanicException.smethod_0(77);
												goto IL_014e;
												IL_016a:
												num7 ^= 0x5C;
												goto IL_0171;
												IL_0222:
												num2 = -32;
												goto end_IL_020a;
												IL_0109:
												switch (num)
												{
												case 85:
													break;
												case 86:
													goto IL_0132;
												default:
													goto IL_0218;
												case 87:
												case 88:
													return hashCode;
												}
												hashCode = base.GetHashCode();
												num = 7;
												goto IL_0134;
												IL_0218:
												num2 = ANTLRPanicException.smethod_0(89);
												goto end_IL_020a;
												IL_0132:
												num = 6;
												goto IL_0134;
												IL_0171:
												num8 = 8;
												num9 = Class24.smethod_0(52);
												continue;
												IL_0134:
												num ^= 0x50;
												goto IL_0139;
												IL_0139:
												num2 = ANTLRPanicException.smethod_0(81);
												num3 = -22;
												goto IL_014e;
												IL_0162:
												num6 = 13;
												num7 = -19;
												goto IL_016a;
												IL_014e:
												num3 ^= 0x5A;
												goto IL_0153;
												IL_0153:
												num4 = 29;
												num5 = -28;
												goto IL_015b;
												continue;
												end_IL_0188:
												break;
											}
											continue;
											end_IL_01b5:
											break;
										}
										continue;
										end_IL_01c7:
										break;
									}
									continue;
									end_IL_01e0:
									break;
								}
								continue;
								end_IL_01e9:
								break;
							}
							continue;
							end_IL_0201:
							break;
						}
						continue;
						end_IL_020a:
						break;
					}
					continue;
					end_IL_0225:
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			Type typeFromHandle = default(Type);
			while (true)
			{
				int num = Class40.smethod_2(58);
				int num2 = 63;
				while (true)
				{
					num2 ^= 0x64;
					while (true)
					{
						int num3 = Class24.smethod_0(56);
						int num4 = -2;
						while (true)
						{
							num4 ^= 0x5B;
							while (true)
							{
								int num5 = ANTLRPanicException.smethod_0(93);
								int num6 = 60;
								while (true)
								{
									num6 ^= 0x58;
									while (true)
									{
										int num7 = 7;
										int num8 = 9;
										while (true)
										{
											num8 ^= 0x60;
											int num9 = 2;
											int num10 = -64;
											num10 = -91;
											while (true)
											{
												IL_01d8:
												num9 ^= 0x64;
												while (true)
												{
													num10 = Form0.smethod_0(100);
													while (true)
													{
														switch (num10 ^ 0x65)
														{
														case -92:
															num10 = ANTLRPanicException.smethod_0(96);
															continue;
														case -94:
															goto end_IL_0030;
														case -93:
															goto IL_01cd;
														case -91:
															goto IL_01d8;
														}
														break;
													}
													continue;
													end_IL_0030:
													break;
												}
												switch (num9)
												{
												case 102:
													goto IL_0062;
												case 103:
													goto IL_01be;
												case 104:
													goto IL_01c7;
												case 105:
													goto end_IL_01d8;
												}
												num10 = -58;
												num10 = -93;
												goto IL_01cd;
												IL_0197:
												num4 = Class40.smethod_2(62);
												num5 = -61;
												goto IL_01a4;
												IL_01be:
												num8 = 7;
												num9 = 13;
												continue;
												IL_01c7:
												num9 = 12;
												continue;
												IL_0062:
												switch (num8)
												{
												case 103:
													goto IL_0084;
												case 105:
													goto IL_01b7;
												case 104:
													goto IL_01e9;
												case 102:
													goto end_IL_01ec;
												}
												num9 = 3;
												continue;
												IL_01e9:
												num8 = 8;
												break;
												IL_0084:
												switch (num7)
												{
												case 88:
													break;
												case 89:
													goto IL_01ab;
												case 90:
													goto IL_01b4;
												default:
													goto IL_01e4;
												case 91:
													goto end_IL_0200;
												}
												switch (num6)
												{
												case 98:
													goto IL_00c5;
												case 100:
													goto IL_01a4;
												case 97:
													goto IL_0209;
												case 99:
													goto end_IL_0213;
												}
												num7 = 6;
												goto IL_01b7;
												IL_01e4:
												num8 = 6;
												break;
												IL_01b4:
												num7 = 5;
												goto IL_01b7;
												IL_01ab:
												num6 = 58;
												num7 = 4;
												goto IL_01b7;
												IL_0209:
												num6 = 57;
												goto end_IL_0200;
												IL_00c5:
												switch (num5)
												{
												case -99:
													break;
												case -98:
													goto IL_00ed;
												case -100:
													goto IL_0197;
												default:
													goto IL_020f;
												case -97:
													goto end_IL_021c;
												}
												num5 = -63;
												goto IL_01a4;
												IL_020f:
												num6 = 59;
												goto end_IL_0200;
												IL_00ed:
												switch (num4)
												{
												case -94:
													goto IL_0110;
												case -91:
													goto IL_0192;
												case -93:
													goto IL_0230;
												case -92:
													goto end_IL_0239;
												}
												num5 = -64;
												goto IL_01a4;
												IL_0230:
												num4 = Class15.smethod_0(74);
												goto end_IL_021c;
												IL_0110:
												switch (num3)
												{
												case -89:
													break;
												case -88:
													goto IL_0138;
												case -87:
													goto IL_018c;
												default:
													goto IL_022b;
												case -86:
													goto end_IL_0242;
												}
												num3 = Class24.smethod_0(57);
												goto IL_0192;
												IL_022b:
												num4 = -1;
												goto end_IL_021c;
												IL_0138:
												switch (num2)
												{
												case 90:
													goto IL_0156;
												case 91:
													goto IL_0187;
												case 89:
													goto IL_0250;
												case 88:
													goto end_IL_0258;
												}
												num3 = -15;
												goto IL_0192;
												IL_0250:
												num2 = 61;
												goto end_IL_0242;
												IL_0156:
												switch (num)
												{
												case -86:
													break;
												case -85:
													goto IL_0179;
												default:
													goto IL_0255;
												case -87:
												case -84:
													return typeFromHandle;
												}
												num = -14;
												goto IL_0187;
												IL_0255:
												num2 = 60;
												goto end_IL_0242;
												IL_0179:
												typeFromHandle = typeof(Class3);
												num = -15;
												goto IL_0187;
												IL_01cd:
												num9 = 2;
												num10 = -64;
												num10 = -91;
												continue;
												IL_0187:
												num ^= 0x58;
												goto IL_018c;
												IL_018c:
												num2 = 62;
												num3 = -14;
												goto IL_0192;
												IL_01b7:
												num7 ^= 0x5F;
												goto IL_01be;
												IL_01a4:
												num5 ^= 0x5C;
												goto IL_01ab;
												IL_0192:
												num3 ^= 0x58;
												goto IL_0197;
												continue;
												end_IL_01d8:
												break;
											}
											continue;
											end_IL_01ec:
											break;
										}
										continue;
										end_IL_0200:
										break;
									}
									continue;
									end_IL_0213:
									break;
								}
								continue;
								end_IL_021c:
								break;
							}
							continue;
							end_IL_0239:
							break;
						}
						continue;
						end_IL_0242:
						break;
					}
					continue;
					end_IL_0258:
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			string result = default(string);
			while (true)
			{
				int num = 59;
				int num2 = 0;
				while (true)
				{
					num2 ^= 0x62;
					while (true)
					{
						int num3 = Class40.smethod_2(54);
						int num4 = 59;
						while (true)
						{
							num4 ^= 0x66;
							while (true)
							{
								int num5 = 61;
								int num6 = 54;
								while (true)
								{
									num6 ^= 0x5E;
									while (true)
									{
										int num7 = Class24.smethod_0(47);
										int num8 = Form0.smethod_0(94);
										while (true)
										{
											switch (num8 ^ 0x66)
											{
											case -90:
												break;
											case -93:
												goto IL_001b;
											default:
												num8 = Form0.smethod_0(95);
												continue;
											case -91:
												goto end_IL_0156;
											case -92:
												while (true)
												{
													num8 = -62;
													num8 = -92;
												}
											}
											goto IL_0006;
											IL_001b:
											switch (num7)
											{
											case -86:
												break;
											case -85:
												goto IL_0137;
											case -84:
												goto IL_0140;
											default:
												goto IL_0179;
											case -83:
												goto end_IL_0181;
											}
											switch (num6)
											{
											case 103:
												goto IL_005a;
											case 104:
												goto IL_012e;
											case 102:
												goto IL_0195;
											case 101:
												goto end_IL_019f;
											}
											num7 = -15;
											goto IL_0006;
											IL_0179:
											num8 = -61;
											num8 = -91;
											break;
											IL_0137:
											num7 = -10;
											goto IL_0006;
											IL_0126:
											num4 = 58;
											num5 = 58;
											goto IL_012e;
											IL_0195:
											num6 = 56;
											goto end_IL_0181;
											IL_005a:
											switch (num5)
											{
											case 98:
												break;
											case 99:
												goto IL_0082;
											case 97:
												goto IL_0126;
											default:
												goto IL_019b;
											case 100:
												goto end_IL_01a8;
											}
											num5 = 60;
											goto IL_012e;
											IL_019b:
											num6 = 59;
											goto end_IL_0181;
											IL_0082:
											switch (num4)
											{
											case 92:
												goto IL_00a5;
											case 93:
												goto IL_0121;
											case 90:
												goto IL_01b2;
											case 91:
												goto end_IL_01bc;
											}
											num5 = 63;
											goto IL_012e;
											IL_01b2:
											num4 = 60;
											goto end_IL_01a8;
											IL_00a5:
											switch (num3)
											{
											case -95:
												break;
											case -94:
												goto IL_00cd;
											case -96:
												goto IL_011c;
											default:
												goto IL_01b8;
											case -93:
												goto end_IL_01c5;
											}
											num3 = Class24.smethod_0(52);
											goto IL_0121;
											IL_01b8:
											num4 = 61;
											goto end_IL_01a8;
											IL_00cd:
											switch (num2)
											{
											case 97:
												goto IL_00ea;
											case 98:
												goto IL_0117;
											case 96:
												goto IL_01d3;
											case 95:
												goto end_IL_01da;
											}
											num3 = -1;
											goto IL_0121;
											IL_01d3:
											num2 = 2;
											goto end_IL_01c5;
											IL_00ea:
											switch (num)
											{
											case 100:
												break;
											case 102:
												goto IL_010d;
											default:
												goto IL_01d7;
											case 101:
											case 103:
												return result;
											}
											num = 57;
											goto IL_0117;
											IL_01d7:
											num2 = 61;
											goto end_IL_01c5;
											IL_010d:
											result = base.ToString();
											num = 56;
											goto IL_0117;
											IL_0006:
											num7 ^= 0x5D;
											num8 = Form0.smethod_0(95);
											continue;
											IL_0117:
											num ^= 0x5D;
											goto IL_011c;
											IL_011c:
											num2 = 3;
											num3 = -4;
											goto IL_0121;
											IL_012e:
											num5 ^= 0x5E;
											goto IL_0140;
											IL_0140:
											num6 = 57;
											num7 = -16;
											goto IL_0006;
											IL_0121:
											num3 ^= 0x5F;
											goto IL_0126;
											continue;
											end_IL_0156:
											break;
										}
										continue;
										end_IL_0181:
										break;
									}
									continue;
									end_IL_019f:
									break;
								}
								continue;
								end_IL_01a8:
								break;
							}
							continue;
							end_IL_01bc:
							break;
						}
						continue;
						end_IL_01c5:
						break;
					}
					continue;
					end_IL_01da:
					break;
				}
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			if (gparam_0 == null || 1 == 0)
			{
				return new T();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
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
				if (gparam_0 == null || 1 == 0)
				{
					gparam_0 = new T();
				}
				return gparam_0;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
		}
	}

	private static readonly Class4<Class0> class4_0 = Delegate6.smethod_0();

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
			Class0 result = default(Class0);
			while (true)
			{
				int num = 10;
				int num2 = 3;
				while (true)
				{
					num2 ^= 0x3D;
					while (true)
					{
						int num3 = Class24.smethod_0(55);
						int num4 = 7;
						while (true)
						{
							num4 ^= 0x39;
							while (true)
							{
								int num5 = Class48.smethod_2(64);
								int num6 = -5;
								while (true)
								{
									num6 ^= 0x3A;
									while (true)
									{
										int num7 = Class24.smethod_0(50);
										int num8 = 11;
										while (true)
										{
											num8 ^= 0x46;
											int num9 = Class15.smethod_0(66);
											while (true)
											{
												switch (num9 ^ 0x52)
												{
												case -79:
													break;
												default:
													num9 = Class15.smethod_0(66);
													continue;
												case -78:
													num8 = 10;
													num9 = -26;
													num9 = -76;
													goto end_IL_0034;
												case -76:
													goto end_IL_0034;
												case -77:
													while (true)
													{
														num9 = -31;
														num9 = -77;
													}
												}
												switch (num8)
												{
												case 75:
													goto IL_0057;
												case 76:
													goto IL_0060;
												case 77:
													goto IL_019e;
												case 74:
													goto end_IL_01bf;
												}
												num9 = Class15.smethod_0(76);
												continue;
												IL_0057:
												num8 = 13;
												break;
												continue;
												end_IL_0034:
												break;
											}
											continue;
											IL_016d:
											num3 ^= 0x3C;
											goto IL_0172;
											IL_0060:
											switch (num7)
											{
											case -66:
												goto IL_0083;
											case -65:
												goto IL_0186;
											case -64:
												goto IL_0195;
											case -63:
												goto end_IL_01d4;
											}
											num8 = 12;
											continue;
											IL_0195:
											num7 = Class15.smethod_0(68);
											goto IL_019e;
											IL_0083:
											switch (num6)
											{
											case -66:
												goto IL_00a6;
											case -63:
												goto IL_017f;
											case -65:
												goto IL_01e9;
											case -64:
												goto end_IL_01ed;
											}
											num7 = -5;
											goto IL_019e;
											IL_01e9:
											num6 = -123;
											goto end_IL_01d4;
											IL_00a6:
											switch (num5)
											{
											case -61:
												break;
											case -60:
												goto IL_0172;
											case -59:
												goto IL_017b;
											default:
												goto IL_01e3;
											case -58:
												goto end_IL_01f6;
											}
											switch (num4)
											{
											case 59:
												goto IL_00ed;
											case 62:
												goto IL_016d;
											case 61:
												goto IL_020a;
											case 60:
												goto end_IL_020d;
											}
											num5 = Class48.smethod_2(65);
											goto IL_017f;
											IL_01e3:
											num6 = -6;
											goto end_IL_01d4;
											IL_017b:
											num5 = -125;
											goto IL_017f;
											IL_017f:
											num5 ^= 0x46;
											goto IL_0186;
											IL_020a:
											num4 = 4;
											goto end_IL_01f6;
											IL_00ed:
											switch (num3)
											{
											case -46:
												break;
											case -44:
												goto IL_0115;
											case -45:
												goto IL_0168;
											default:
												goto IL_0205;
											case -43:
												goto end_IL_0216;
											}
											num3 = Class24.smethod_0(46);
											goto IL_016d;
											IL_0205:
											num4 = 5;
											goto end_IL_01f6;
											IL_0115:
											switch (num2)
											{
											case 60:
												goto IL_0133;
											case 62:
												goto IL_0163;
											case 59:
												goto IL_0223;
											case 61:
												goto end_IL_0229;
											}
											num3 = -17;
											goto IL_016d;
											IL_0223:
											num2 = 6;
											goto end_IL_0216;
											IL_0133:
											switch (num)
											{
											case 54:
												break;
											case 56:
												goto IL_0161;
											default:
												goto IL_0227;
											case 55:
											case 57:
												return result;
											}
											result = Delegate11.smethod_0(class4_0);
											num = 11;
											goto IL_0163;
											IL_0227:
											num2 = 0;
											goto end_IL_0216;
											IL_0161:
											num = 4;
											goto IL_0163;
											IL_0172:
											num4 = 2;
											num5 = -128;
											goto IL_017f;
											IL_0163:
											num ^= 0x3C;
											goto IL_0168;
											IL_0168:
											num2 = 1;
											num3 = -23;
											goto IL_016d;
											IL_019e:
											num7 ^= 0x44;
											num8 = 10;
											num9 = -26;
											num9 = -76;
											continue;
											IL_0186:
											num6 = Class15.smethod_0(68);
											num7 = -123;
											goto IL_019e;
											continue;
											end_IL_01bf:
											break;
										}
										continue;
										end_IL_01d4:
										break;
									}
									continue;
									end_IL_01ed:
									break;
								}
								continue;
								end_IL_01f6:
								break;
							}
							continue;
							end_IL_020d:
							break;
						}
						continue;
						end_IL_0216:
						break;
					}
					continue;
					end_IL_0229:
					break;
				}
			}
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			Form0 result = default(Form0);
			while (true)
			{
				int num = 2;
				int num2 = Class24.smethod_0(52);
				while (true)
				{
					num2 ^= 0x43;
					while (true)
					{
						int num3 = 1;
						int num4 = 7;
						while (true)
						{
							num4 ^= 0x4B;
							while (true)
							{
								int num5 = Class15.smethod_0(74);
								int num6 = 5;
								while (true)
								{
									num6 ^= 0x4F;
									while (true)
									{
										int num7 = 1;
										int num8 = -13;
										while (true)
										{
											num8 ^= 0x4E;
											while (true)
											{
												int num9 = 0;
												int num10 = Class24.smethod_0(51);
												while (true)
												{
													switch (num10 ^ 0x51)
													{
													case -89:
														break;
													default:
														goto IL_000d;
													case -90:
														goto IL_001b;
													case -92:
														goto end_IL_01a4;
													case -91:
														while (true)
														{
															num10 = -12;
															num10 = -91;
														}
													}
													goto IL_0006;
													IL_001b:
													switch (num9)
													{
													case 87:
														break;
													case 88:
														goto IL_0189;
													case 89:
														goto IL_019b;
													default:
														goto IL_01ca;
													case 90:
														goto end_IL_01d2;
													}
													switch (num8)
													{
													case -70:
														goto IL_005a;
													case -67:
														goto IL_0182;
													case -68:
														goto IL_01e6;
													case -69:
														goto end_IL_01ea;
													}
													num9 = 15;
													goto IL_0006;
													IL_01ca:
													num10 = -11;
													num10 = -92;
													break;
													IL_019b:
													num9 = 14;
													goto IL_0006;
													IL_0175:
													num5 ^= 0x4A;
													goto IL_017c;
													IL_01e6:
													num8 = -14;
													goto end_IL_01d2;
													IL_005a:
													switch (num7)
													{
													case 77:
														break;
													case 78:
														goto IL_0081;
													case 76:
														goto IL_017c;
													default:
														goto IL_01e0;
													case 79:
														goto end_IL_01f3;
													}
													num7 = 2;
													goto IL_0182;
													IL_01e0:
													num8 = -11;
													goto end_IL_01d2;
													IL_0081:
													switch (num6)
													{
													case 71:
														goto IL_00a3;
													case 74:
														goto IL_0175;
													case 73:
														goto IL_0201;
													case 72:
														goto end_IL_0204;
													}
													num7 = 3;
													goto IL_0182;
													IL_0201:
													num6 = 6;
													goto end_IL_01f3;
													IL_00a3:
													switch (num5)
													{
													case -78:
														break;
													case -79:
														goto IL_0168;
													case -77:
														goto IL_0171;
													default:
														goto IL_01fc;
													case -76:
														goto end_IL_020d;
													}
													switch (num4)
													{
													case 73:
														goto IL_00e5;
													case 76:
														goto IL_0163;
													case 74:
														goto IL_0220;
													case 75:
														goto end_IL_0223;
													}
													num5 = -5;
													goto IL_0175;
													IL_01fc:
													num6 = 7;
													goto end_IL_01f3;
													IL_0171:
													num5 = -7;
													goto IL_0175;
													IL_0182:
													num7 ^= 0x4F;
													goto IL_0189;
													IL_0220:
													num4 = 1;
													goto end_IL_020d;
													IL_00e5:
													switch (num3)
													{
													case 69:
														break;
													case 71:
														goto IL_0107;
													case 70:
														goto IL_0158;
													default:
														goto IL_021b;
													case 72:
														goto end_IL_022c;
													}
													num3 = 3;
													goto IL_0163;
													IL_021b:
													num4 = 0;
													goto end_IL_020d;
													IL_0107:
													switch (num2)
													{
													case -70:
														goto IL_0124;
													case -67:
														goto IL_0153;
													case -68:
														goto IL_0238;
													case -69:
														goto end_IL_023a;
													}
													num3 = 0;
													goto IL_0163;
													IL_0238:
													num2 = -1;
													goto end_IL_022c;
													IL_0124:
													switch (num)
													{
													case 75:
														break;
													case 76:
														goto IL_0151;
													default:
														goto IL_0233;
													case 74:
													case 77:
														return result;
													}
													result = Delegate12.smethod_0(class4_1);
													num = 3;
													goto IL_0153;
													IL_0233:
													num2 = -8;
													goto end_IL_022c;
													IL_0151:
													num = 5;
													goto IL_0153;
													IL_000d:
													num10 = Class24.smethod_0(47);
													continue;
													IL_0153:
													num ^= 0x49;
													goto IL_0158;
													IL_0158:
													num2 = Class40.smethod_2(62);
													num3 = 14;
													goto IL_0163;
													IL_0006:
													num9 ^= 0x57;
													goto IL_000d;
													IL_017c:
													num6 = 8;
													num7 = 0;
													goto IL_0182;
													IL_0163:
													num3 ^= 0x46;
													goto IL_0168;
													IL_0168:
													num4 = 2;
													num5 = -2;
													goto IL_0175;
													IL_0189:
													num8 = Class15.smethod_0(78);
													num9 = 13;
													goto IL_0006;
													continue;
													end_IL_01a4:
													break;
												}
												continue;
												end_IL_01d2:
												break;
											}
											continue;
											end_IL_01ea:
											break;
										}
										continue;
										end_IL_01f3:
										break;
									}
									continue;
									end_IL_0204:
									break;
								}
								continue;
								end_IL_020d:
								break;
							}
							continue;
							end_IL_0223:
							break;
						}
						continue;
						end_IL_022c:
						break;
					}
					continue;
					end_IL_023a:
					break;
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
			User result = default(User);
			while (true)
			{
				int num = 14;
				int num2 = -9;
				while (true)
				{
					num2 ^= 0x50;
					while (true)
					{
						int num3 = ANTLRPanicException.smethod_0(85);
						int num4 = Class15.smethod_0(74);
						while (true)
						{
							num4 ^= 0x4D;
							while (true)
							{
								int num5 = Class40.smethod_2(62);
								int num6 = 4;
								while (true)
								{
									num6 ^= 0x58;
									while (true)
									{
										int num7 = Class24.smethod_0(47);
										int num8 = 8;
										while (true)
										{
											num8 ^= 0x50;
											int num9 = Class40.smethod_2(62);
											int num10 = -23;
											num10 = -80;
											while (true)
											{
												IL_01ef:
												num9 ^= 0x4C;
												while (true)
												{
													num10 = Class24.smethod_0(47);
													while (true)
													{
														switch (num10 ^ 0x59)
														{
														case -83:
															num10 = Class15.smethod_0(78);
															continue;
														case -82:
															goto end_IL_0030;
														case -81:
															goto IL_01de;
														case -80:
															goto IL_01ef;
														}
														break;
													}
													continue;
													end_IL_0030:
													break;
												}
												switch (num9)
												{
												case -76:
													goto IL_0062;
												case -75:
													goto IL_006b;
												case -74:
													goto IL_01d0;
												case -73:
													goto end_IL_01ef;
												}
												num10 = -10;
												num10 = -81;
												goto IL_01de;
												IL_01bd:
												num6 = 1;
												num7 = ANTLRPanicException.smethod_0(86);
												goto IL_01c9;
												IL_01d0:
												num8 = 7;
												num9 = Class24.smethod_0(59);
												continue;
												IL_006b:
												switch (num8)
												{
												case 87:
													goto IL_008e;
												case 88:
													goto IL_01c9;
												case 85:
													goto IL_01fb;
												case 86:
													goto end_IL_0203;
												}
												num9 = -6;
												continue;
												IL_01fb:
												num8 = 5;
												break;
												IL_008e:
												switch (num7)
												{
												case -81:
													break;
												case -80:
													goto IL_01b7;
												case -79:
													goto IL_01bd;
												default:
													goto IL_0200;
												case -78:
													goto end_IL_021d;
												}
												switch (num6)
												{
												case 89:
													goto IL_00d0;
												case 92:
													goto IL_01ae;
												case 90:
													goto IL_0230;
												case 91:
													goto end_IL_0233;
												}
												num7 = -23;
												goto IL_01c9;
												IL_0200:
												num8 = 6;
												break;
												IL_01b7:
												num7 = -24;
												goto IL_01c9;
												IL_01c9:
												num7 ^= 0x58;
												goto IL_01d0;
												IL_0230:
												num6 = 2;
												goto end_IL_021d;
												IL_00d0:
												switch (num5)
												{
												case -77:
													break;
												case -76:
													goto IL_00f8;
												case -78:
													goto IL_01a1;
												default:
													goto IL_022b;
												case -75:
													goto end_IL_023c;
												}
												num5 = -2;
												goto IL_01ae;
												IL_022b:
												num6 = 3;
												goto end_IL_021d;
												IL_00f8:
												switch (num4)
												{
												case -78:
													goto IL_011a;
												case -75:
													goto IL_019c;
												case -76:
													goto IL_0250;
												case -77:
													goto end_IL_0254;
												}
												num5 = -1;
												goto IL_01ae;
												IL_0250:
												num4 = -7;
												goto end_IL_023c;
												IL_011a:
												switch (num3)
												{
												case -80:
													break;
												case -79:
													goto IL_013d;
												case -78:
													goto IL_0191;
												default:
													goto IL_024a;
												case -77:
													goto end_IL_025d;
												}
												num3 = -24;
												goto IL_019c;
												IL_024a:
												num4 = -2;
												goto end_IL_023c;
												IL_013d:
												switch (num2)
												{
												case -90:
													goto IL_015b;
												case -89:
													goto IL_018c;
												case -91:
													goto IL_0270;
												case -92:
													goto end_IL_027d;
												}
												num3 = -22;
												goto IL_019c;
												IL_0270:
												num2 = ANTLRPanicException.smethod_0(77);
												goto end_IL_025d;
												IL_015b:
												switch (num)
												{
												case 90:
													break;
												case 91:
													goto IL_017e;
												default:
													goto IL_027a;
												case 89:
												case 92:
													return result;
												}
												num = 15;
												goto IL_018c;
												IL_027a:
												num2 = -12;
												goto end_IL_025d;
												IL_017e:
												result = Delegate13.smethod_0(class4_2);
												num = 12;
												goto IL_018c;
												IL_01de:
												num9 = Class40.smethod_2(62);
												num10 = -23;
												num10 = -80;
												continue;
												IL_018c:
												num ^= 0x55;
												goto IL_0191;
												IL_0191:
												num2 = Class24.smethod_0(51);
												num3 = -21;
												goto IL_019c;
												IL_01ae:
												num5 ^= 0x4D;
												goto IL_01bd;
												IL_0062:
												num9 = -8;
												continue;
												IL_019c:
												num3 ^= 0x58;
												goto IL_01a1;
												IL_01a1:
												num4 = Class24.smethod_0(57);
												num5 = -8;
												goto IL_01ae;
												continue;
												end_IL_01ef:
												break;
											}
											continue;
											end_IL_0203:
											break;
										}
										continue;
										end_IL_021d:
										break;
									}
									continue;
									end_IL_0233:
									break;
								}
								continue;
								end_IL_023c:
								break;
							}
							continue;
							end_IL_0254:
							break;
						}
						continue;
						end_IL_025d:
						break;
					}
					continue;
					end_IL_027d:
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
			Class2 result = default(Class2);
			while (true)
			{
				int num = Class24.smethod_0(59);
				int num2 = 18;
				while (true)
				{
					num2 ^= 0x4C;
					while (true)
					{
						int num3 = 1;
						int num4 = -11;
						while (true)
						{
							num4 ^= 0x5B;
							while (true)
							{
								int num5 = Class24.smethod_0(56);
								int num6 = -10;
								while (true)
								{
									num6 ^= 0x5B;
									int num7 = Class24.smethod_0(48);
									while (true)
									{
										switch (num7 ^ 0x57)
										{
										case -75:
											break;
										case -76:
											goto IL_0110;
										default:
											num7 = Class24.smethod_0(48);
											continue;
										case -73:
											goto end_IL_012d;
										case -74:
											while (true)
											{
												num7 = -31;
												num7 = -74;
											}
										}
										switch (num6)
										{
										case -86:
											goto IL_002d;
										case -83:
											goto IL_0109;
										case -84:
											goto IL_015b;
										case -85:
											goto end_IL_015f;
										}
										num7 = -29;
										num7 = -76;
										goto IL_0110;
										IL_00f7:
										num3 ^= 0x52;
										goto IL_00fc;
										IL_015b:
										num6 = -9;
										break;
										IL_002d:
										switch (num5)
										{
										case -92:
											break;
										case -91:
											goto IL_0055;
										case -90:
											goto IL_00fc;
										default:
											goto IL_0150;
										case -89:
											goto end_IL_0171;
										}
										num5 = -15;
										goto IL_0109;
										IL_0150:
										num6 = Class24.smethod_0(56);
										break;
										IL_0055:
										switch (num4)
										{
										case -83:
											goto IL_007d;
										case -82:
											goto IL_00f7;
										case -84:
											goto IL_0180;
										case -85:
											goto end_IL_018a;
										}
										num5 = Class40.smethod_2(58);
										goto IL_0109;
										IL_0180:
										num4 = -9;
										goto end_IL_0171;
										IL_007d:
										switch (num3)
										{
										case 83:
											break;
										case 82:
											goto IL_00ee;
										case 84:
											goto IL_00f5;
										default:
											goto IL_0186;
										case 85:
											goto end_IL_0193;
										}
										switch (num2)
										{
										case 92:
											goto IL_00b8;
										case 94:
											goto IL_00e9;
										case 91:
											goto IL_019b;
										case 93:
											goto end_IL_01a3;
										}
										num3 = 0;
										goto IL_00f7;
										IL_0186:
										num4 = -16;
										goto end_IL_0171;
										IL_00f5:
										num3 = 6;
										goto IL_00f7;
										IL_0109:
										num5 ^= 0x55;
										goto IL_0110;
										IL_019b:
										num2 = 23;
										goto end_IL_0193;
										IL_00b8:
										switch (num)
										{
										case -84:
											break;
										case -82:
											goto IL_00db;
										default:
											goto IL_01a0;
										case -83:
										case -81:
											return result;
										}
										num = -7;
										goto IL_00e9;
										IL_01a0:
										num2 = 17;
										goto end_IL_0193;
										IL_00db:
										result = Delegate14.smethod_0(class4_3);
										num = -8;
										goto IL_00e9;
										IL_0110:
										num6 = Class40.smethod_2(60);
										num7 = Class15.smethod_0(76);
										continue;
										IL_00e9:
										num ^= 0x55;
										goto IL_00ee;
										IL_00ee:
										num2 = 16;
										num3 = 7;
										goto IL_00f7;
										IL_00fc:
										num4 = Class24.smethod_0(51);
										num5 = -14;
										goto IL_0109;
										continue;
										end_IL_012d:
										break;
									}
									continue;
									end_IL_015f:
									break;
								}
								continue;
								end_IL_0171:
								break;
							}
							continue;
							end_IL_018a:
							break;
						}
						continue;
						end_IL_0193:
						break;
					}
					continue;
					end_IL_01a3:
					break;
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
			Class3 result = default(Class3);
			while (true)
			{
				int num = Class40.smethod_2(61);
				int num2 = 12;
				while (true)
				{
					num2 ^= 0x53;
					while (true)
					{
						int num3 = 10;
						int num4 = -17;
						while (true)
						{
							num4 ^= 0x58;
							while (true)
							{
								int num5 = 24;
								int num6 = -2;
								while (true)
								{
									num6 ^= 0x4D;
									while (true)
									{
										int num7 = Class40.smethod_2(62);
										int num8 = -4;
										while (true)
										{
											num8 ^= 0x51;
											int num9 = 25;
											int num10 = -32;
											num10 = -76;
											while (true)
											{
												num9 ^= 0x4E;
												while (true)
												{
													num10 = Class48.smethod_2(70);
													while (true)
													{
														switch (num10 ^ 0x54)
														{
														case -77:
															break;
														default:
															goto end_IL_0029;
														case -78:
															num9 = 25;
															num10 = -32;
															num10 = -76;
															goto end_IL_004a;
														case -76:
															goto end_IL_004a;
														case -79:
															while (true)
															{
																num10 = -27;
																num10 = -79;
															}
														}
														switch (num9)
														{
														case 87:
															goto IL_0066;
														case 86:
															goto IL_01ca;
														case 88:
															goto IL_01d9;
														case 89:
															goto end_IL_01dd;
														}
														num10 = ANTLRPanicException.smethod_0(81);
														continue;
														IL_01d9:
														num9 = 22;
														goto end_IL_004a;
														continue;
														end_IL_0029:
														break;
													}
													continue;
													end_IL_004a:
													break;
												}
												continue;
												IL_0188:
												num3 ^= 0x51;
												goto IL_0195;
												IL_0066:
												switch (num8)
												{
												case -84:
													goto IL_0089;
												case -83:
													goto IL_01c3;
												case -85:
													goto IL_01e9;
												case -86:
													goto end_IL_01f3;
												}
												num9 = 24;
												continue;
												IL_01e9:
												num8 = -6;
												break;
												IL_0089:
												switch (num7)
												{
												case -86:
													break;
												case -85:
													goto IL_01ab;
												case -84:
													goto IL_01b6;
												default:
													goto IL_01ef;
												case -83:
													goto end_IL_0208;
												}
												switch (num6)
												{
												case -78:
													goto IL_00ca;
												case -77:
													goto IL_01a2;
												case -80:
													goto IL_0217;
												case -79:
													goto end_IL_0226;
												}
												num7 = -1;
												goto IL_01c3;
												IL_01ef:
												num8 = -5;
												break;
												IL_01ab:
												num7 = Class15.smethod_0(74);
												goto IL_01c3;
												IL_01a2:
												num5 ^= 0x4C;
												goto IL_01b6;
												IL_0217:
												num6 = Class40.smethod_2(54);
												goto end_IL_0208;
												IL_00ca:
												switch (num5)
												{
												case 84:
													break;
												case 85:
													goto IL_018f;
												case 86:
													goto IL_0195;
												default:
													goto IL_0222;
												case 87:
													goto end_IL_022f;
												}
												switch (num4)
												{
												case -76:
													goto IL_010c;
												case -73:
													goto IL_0188;
												case -75:
													goto IL_023f;
												case -74:
													goto end_IL_0243;
												}
												num5 = 26;
												goto IL_01a2;
												IL_0222:
												num6 = -4;
												goto end_IL_0208;
												IL_018f:
												num5 = 25;
												goto IL_01a2;
												IL_01b6:
												num6 = Class24.smethod_0(57);
												num7 = -2;
												goto IL_01c3;
												IL_023f:
												num4 = -19;
												goto end_IL_022f;
												IL_010c:
												switch (num3)
												{
												case 89:
													break;
												case 91:
													goto IL_012e;
												case 90:
													goto IL_0182;
												default:
													goto IL_0239;
												case 92:
													goto end_IL_024c;
												}
												num3 = 8;
												goto IL_0188;
												IL_0239:
												num4 = -18;
												goto end_IL_022f;
												IL_012e:
												switch (num2)
												{
												case 94:
													goto IL_014c;
												case 95:
													goto IL_017d;
												case 93:
													goto IL_0255;
												case 92:
													goto end_IL_025d;
												}
												num3 = 11;
												goto IL_0188;
												IL_0255:
												num2 = 14;
												goto end_IL_024c;
												IL_014c:
												switch (num)
												{
												case -81:
													break;
												case -80:
													goto IL_016f;
												default:
													goto IL_025a;
												case -79:
												case -78:
													return result;
												}
												num = -29;
												goto IL_017d;
												IL_025a:
												num2 = 15;
												goto end_IL_024c;
												IL_016f:
												result = Delegate15.smethod_0(class4_4);
												num = -3;
												goto IL_017d;
												IL_0195:
												num4 = ANTLRPanicException.smethod_0(80);
												num5 = 27;
												goto IL_01a2;
												IL_017d:
												num ^= 0x4C;
												goto IL_0182;
												IL_0182:
												num2 = 13;
												num3 = 13;
												goto IL_0188;
												IL_01ca:
												num8 = Class40.smethod_2(54);
												num9 = 23;
												continue;
												IL_01c3:
												num7 ^= 0x53;
												goto IL_01ca;
												continue;
												end_IL_01dd:
												break;
											}
											continue;
											end_IL_01f3:
											break;
										}
										continue;
										end_IL_0208:
										break;
									}
									continue;
									end_IL_0226:
									break;
								}
								continue;
								end_IL_022f:
								break;
							}
							continue;
							end_IL_0243:
							break;
						}
						continue;
						end_IL_024c:
						break;
					}
					continue;
					end_IL_025d:
					break;
				}
			}
		}
	}

	static Class1()
	{
		while (true)
		{
			int num = Class40.smethod_2(58);
			int num2 = -6;
			while (true)
			{
				num2 ^= 0x35;
				while (true)
				{
					int num3 = Class40.smethod_2(61);
					int num4 = -1;
					while (true)
					{
						num4 ^= 0x2F;
						while (true)
						{
							int num5 = Class24.smethod_0(51);
							int num6 = -16;
							while (true)
							{
								num6 ^= 0x3B;
								while (true)
								{
									int num7 = Class40.smethod_2(54);
									int num8 = -3;
									while (true)
									{
										num8 ^= 0x35;
										int num9 = 10;
										int num10 = -13;
										num10 = -59;
										while (true)
										{
											IL_0236:
											num9 ^= 0x35;
											while (true)
											{
												num10 = Class24.smethod_0(53);
												switch (num10 ^ 0x36)
												{
												case -60:
													goto end_IL_0010;
												case -61:
													goto IL_005e;
												case -59:
													goto IL_0236;
												case -62:
													while (true)
													{
														num10 = -12;
														num10 = -62;
													}
												}
												continue;
												end_IL_0010:
												break;
											}
											switch (num9)
											{
											case 61:
												goto IL_006f;
											case 63:
												goto IL_0077;
											case 62:
												goto IL_0229;
											case 64:
												goto end_IL_0236;
											}
											num10 = -11;
											num10 = -61;
											goto IL_005e;
											IL_0229:
											num8 = Class24.smethod_0(53);
											num9 = 117;
											continue;
											IL_020e:
											num5 ^= 0x3A;
											goto IL_0215;
											IL_0077:
											switch (num8)
											{
											case -57:
												goto IL_009a;
											case -56:
												goto IL_0222;
											case -59:
												goto IL_0242;
											case -58:
												goto end_IL_024c;
											}
											num9 = 11;
											continue;
											IL_0242:
											num8 = -16;
											break;
											IL_009a:
											switch (num7)
											{
											case -61:
												break;
											case -60:
												goto IL_00c7;
											case -62:
												goto IL_0215;
											default:
												goto IL_0248;
											case -59:
												goto end_IL_0261;
											}
											num7 = Class24.smethod_0(50);
											goto IL_0222;
											IL_0248:
											num8 = -13;
											break;
											IL_00c7:
											switch (num6)
											{
											case -54:
												goto IL_00ea;
											case -53:
												goto IL_020e;
											case -55:
												goto IL_0270;
											case -56:
												goto end_IL_027f;
											}
											num7 = -5;
											goto IL_0222;
											IL_0270:
											num6 = Class24.smethod_0(53);
											goto end_IL_0261;
											IL_00ea:
											switch (num5)
											{
											case -53:
												break;
											case -52:
												goto IL_0117;
											case -54:
												goto IL_0202;
											default:
												goto IL_027b;
											case -51:
												goto end_IL_0288;
											}
											num5 = Class40.smethod_2(60);
											goto IL_020e;
											IL_027b:
											num6 = -13;
											goto end_IL_0261;
											IL_0117:
											switch (num4)
											{
											case -51:
												goto IL_0139;
											case -48:
												goto IL_01fd;
											case -50:
												goto IL_029c;
											case -49:
												goto end_IL_029f;
											}
											num5 = -16;
											goto IL_020e;
											IL_029c:
											num4 = -31;
											goto end_IL_0288;
											IL_0139:
											switch (num3)
											{
											case -51:
												break;
											case -50:
												goto IL_01e8;
											case -49:
												goto IL_01f2;
											default:
												goto IL_0297;
											case -48:
												goto end_IL_02a6;
											}
											switch (num2)
											{
											case -52:
												goto IL_0178;
											case -49:
												goto IL_01e1;
											case -51:
												goto IL_02bc;
											case -50:
												goto end_IL_02bf;
											}
											num3 = -2;
											goto IL_01fd;
											IL_0297:
											num4 = -32;
											goto end_IL_0288;
											IL_01e8:
											num3 = Class24.smethod_0(57);
											goto IL_01fd;
											IL_006f:
											num9 = 8;
											continue;
											IL_02bc:
											num2 = -8;
											goto end_IL_02a6;
											IL_0178:
											switch (num)
											{
											case -61:
												break;
											case -60:
												goto IL_01ad;
											case -59:
												goto IL_01bc;
											case -58:
												goto IL_01ca;
											case -57:
												goto IL_01d4;
											default:
												goto IL_02b2;
											case -56:
												return;
											}
											class4_2 = Delegate8.smethod_0();
											num = -16;
											goto IL_01e1;
											IL_02b2:
											num2 = Class24.smethod_0(59);
											goto end_IL_02a6;
											IL_01d4:
											class4_3 = Delegate9.smethod_0();
											num = -14;
											goto IL_01e1;
											IL_01ca:
											num = Class40.smethod_2(60);
											goto IL_01e1;
											IL_01bc:
											class4_4 = Delegate10.smethod_0();
											num = -1;
											goto IL_01e1;
											IL_01ad:
											class4_1 = Delegate7.smethod_0();
											num = -12;
											goto IL_01e1;
											IL_005e:
											num9 = 10;
											num10 = -13;
											num10 = -59;
											continue;
											IL_01e1:
											num ^= 0x37;
											goto IL_01f2;
											IL_01f2:
											num2 = Class40.smethod_2(62);
											num3 = -31;
											goto IL_01fd;
											IL_0215:
											num6 = Class40.smethod_2(60);
											num7 = -4;
											goto IL_0222;
											IL_01fd:
											num3 ^= 0x31;
											goto IL_0202;
											IL_0202:
											num4 = Class24.smethod_0(48);
											num5 = -9;
											goto IL_020e;
											IL_0222:
											num7 ^= 0x39;
											goto IL_0229;
											continue;
											end_IL_0236:
											break;
										}
										continue;
										end_IL_024c:
										break;
									}
									continue;
									end_IL_0261:
									break;
								}
								continue;
								end_IL_027f:
								break;
							}
							continue;
							end_IL_0288:
							break;
						}
						continue;
						end_IL_029f:
						break;
					}
					continue;
					end_IL_02a6:
					break;
				}
				continue;
				end_IL_02bf:
				break;
			}
		}
	}
}
