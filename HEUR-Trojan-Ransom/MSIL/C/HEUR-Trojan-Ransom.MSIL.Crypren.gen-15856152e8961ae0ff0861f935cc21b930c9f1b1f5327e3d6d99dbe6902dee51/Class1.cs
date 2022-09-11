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

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
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
				if ((value != form1_0) ? true : false)
				{
					if (value != null || 1 == 0)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					method_0(ref form1_0);
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
				int num = 5;
				int num2 = 3;
				while (true)
				{
					num2 ^= 0x30;
					while (true)
					{
						int num3 = GEventArgs2.smethod_0(49);
						int num4 = GEventArgs2.smethod_1(59);
						while (true)
						{
							num4 ^= 0x33;
							while (true)
							{
								int num5 = 1;
								int num6 = 124;
								while (true)
								{
									num6 ^= 0x41;
									while (true)
									{
										int num7 = 0;
										int num8 = Class8.smethod_0(48);
										while (true)
										{
											num8 ^= 0x39;
											int num9 = 6;
											int num10 = -15;
											num10 = -54;
											while (true)
											{
												IL_01dd:
												num9 ^= 0x40;
												while (true)
												{
													num10 = Class8.smethod_0(38);
													switch (num10 ^ 0x3B)
													{
													case -57:
														goto end_IL_0007;
													case -56:
														goto IL_01d2;
													case -54:
														goto IL_01dd;
													case -55:
														while (true)
														{
															num10 = -14;
															num10 = -55;
														}
													}
													continue;
													end_IL_0007:
													break;
												}
												switch (num9)
												{
												case 68:
													goto IL_005a;
												case 70:
													goto IL_0062;
												case 69:
													goto IL_01c4;
												case 71:
													goto end_IL_01dd;
												}
												num10 = -13;
												num10 = -56;
												goto IL_01d2;
												IL_01b6:
												num6 = 122;
												num7 = 5;
												goto IL_01bd;
												IL_01c4:
												num8 = Class8.smethod_0(47);
												num9 = 7;
												continue;
												IL_0062:
												switch (num8)
												{
												case -62:
													goto IL_0084;
												case -61:
													goto IL_01bd;
												case -63:
													goto IL_01e9;
												case -64:
													goto end_IL_01f3;
												}
												num9 = 5;
												continue;
												IL_01e9:
												num8 = -8;
												break;
												IL_0084:
												switch (num7)
												{
												case 67:
													break;
												case 68:
													goto IL_01b1;
												case 69:
													goto IL_01b6;
												default:
													goto IL_01ef;
												case 70:
													goto end_IL_0207;
												}
												switch (num6)
												{
												case 59:
													goto IL_00c5;
												case 61:
													goto IL_01a8;
												case 58:
													goto IL_0215;
												case 60:
													goto end_IL_021f;
												}
												num7 = 6;
												goto IL_01bd;
												IL_01ef:
												num8 = -7;
												break;
												IL_01b1:
												num7 = 7;
												goto IL_01bd;
												IL_01bd:
												num7 ^= 0x43;
												goto IL_01c4;
												IL_0215:
												num6 = 123;
												goto end_IL_0207;
												IL_00c5:
												switch (num5)
												{
												case 60:
													break;
												case 61:
													goto IL_00ec;
												case 59:
													goto IL_019d;
												default:
													goto IL_021b;
												case 62:
													goto end_IL_0228;
												}
												num5 = 0;
												goto IL_01a8;
												IL_021b:
												num6 = 125;
												goto end_IL_0207;
												IL_00ec:
												switch (num4)
												{
												case -47:
													goto IL_010d;
												case -45:
													goto IL_0198;
												case -48:
													goto IL_0231;
												case -46:
													goto end_IL_0239;
												}
												num5 = 7;
												goto IL_01a8;
												IL_0231:
												num4 = -29;
												goto end_IL_0228;
												IL_010d:
												switch (num3)
												{
												case -49:
													break;
												case -48:
													goto IL_0189;
												case -47:
													goto IL_0195;
												default:
													goto IL_0236;
												case -46:
													goto end_IL_0240;
												}
												switch (num2)
												{
												case 48:
													goto IL_0149;
												case 51:
													goto IL_0184;
												case 50:
													goto IL_0256;
												case 49:
													goto end_IL_0258;
												}
												num3 = -23;
												goto IL_0198;
												IL_0236:
												num4 = -31;
												goto end_IL_0228;
												IL_0195:
												num3 = -24;
												goto IL_0198;
												IL_005a:
												num9 = 4;
												continue;
												IL_0256:
												num2 = 2;
												goto end_IL_0240;
												IL_0149:
												switch (num)
												{
												case 52:
													break;
												case 53:
													goto IL_016b;
												case 54:
													goto IL_0176;
												default:
													goto IL_0252;
												case 55:
													return;
												}
												num = 7;
												goto IL_0184;
												IL_0252:
												num2 = 1;
												goto end_IL_0240;
												IL_0176:
												((Component)gparam_0).Dispose();
												num = 6;
												goto IL_0184;
												IL_016b:
												gparam_0 = default(T);
												num = 4;
												goto IL_0184;
												IL_01d2:
												num9 = 6;
												num10 = -15;
												num10 = -54;
												continue;
												IL_0184:
												num ^= 0x33;
												goto IL_0189;
												IL_0189:
												num2 = 0;
												num3 = GEventArgs2.smethod_1(56);
												goto IL_0198;
												IL_01a8:
												num5 ^= 0x3C;
												goto IL_01b6;
												IL_0198:
												num3 ^= 0x39;
												goto IL_019d;
												IL_019d:
												num4 = Class8.smethod_0(53);
												num5 = 2;
												goto IL_01a8;
												continue;
												end_IL_01dd:
												break;
											}
											continue;
											end_IL_01f3:
											break;
										}
										continue;
										end_IL_0207:
										break;
									}
									continue;
									end_IL_021f:
									break;
								}
								continue;
								end_IL_0228:
								break;
							}
							continue;
							end_IL_0239:
							break;
						}
						continue;
						end_IL_0240:
						break;
					}
					continue;
					end_IL_0258:
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
				int num = Class8.smethod_0(58);
				int num2 = -2;
				while (true)
				{
					num2 ^= 0x3E;
					int num3 = 120;
					int num4 = -10;
					num4 = -55;
					while (true)
					{
						IL_00d5:
						num3 ^= 0x3A;
						num4 = GEventArgs2.smethod_0(46);
						while (true)
						{
							switch (num4 ^ 0x3F)
							{
							case -58:
								num4 = Class8.smethod_0(57);
								continue;
							default:
								num4 = GEventArgs2.smethod_0(46);
								continue;
							case -56:
								break;
							case -57:
								goto IL_005e;
							case -55:
								goto IL_00d5;
							}
							break;
						}
						switch (num3)
						{
						case 66:
							goto IL_006b;
						case 67:
							goto IL_00c5;
						case 68:
							goto IL_00ca;
						case 69:
							goto end_IL_00d5;
						}
						num4 = -8;
						num4 = -57;
						goto IL_005e;
						IL_00be:
						num ^= 0x3B;
						goto IL_00ca;
						IL_00ca:
						num2 = Class55.smethod_1(64);
						num3 = 127;
						continue;
						IL_00c5:
						num3 = 121;
						continue;
						IL_006b:
						switch (num2)
						{
						case -67:
							goto IL_0089;
						case -64:
							goto IL_00be;
						case -65:
							goto IL_00ed;
						case -66:
							goto end_IL_00f5;
						}
						num3 = 126;
						continue;
						IL_00ed:
						num2 = Class55.smethod_1(66);
						break;
						IL_0089:
						switch (num)
						{
						case -57:
							break;
						case -56:
							goto IL_00ae;
						default:
							goto IL_00e8;
						case -58:
						case -55:
							return result;
						}
						num = Class8.smethod_0(38);
						goto IL_00be;
						IL_00e8:
						num2 = -128;
						break;
						IL_00ae:
						result = base.Equals(RuntimeHelpers.GetObjectValue(o));
						num = -3;
						goto IL_00be;
						IL_005e:
						num3 = 120;
						num4 = -10;
						num4 = -55;
						continue;
						end_IL_00d5:
						break;
					}
					continue;
					end_IL_00f5:
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
				int num = Class55.smethod_1(67);
				int num2 = -2;
				while (true)
				{
					num2 ^= 0x45;
					while (true)
					{
						int num3 = Class8.smethod_0(42);
						int num4 = 9;
						while (true)
						{
							num4 ^= 0x44;
							while (true)
							{
								int num5 = Class8.smethod_0(48);
								int num6 = 14;
								while (true)
								{
									num6 ^= 0x49;
									while (true)
									{
										int num7 = GEventArgs2.smethod_0(49);
										int num8 = -115;
										while (true)
										{
											num8 ^= 0x4D;
											int num9 = Class55.smethod_1(72);
											int num10 = -6;
											num10 = -66;
											while (true)
											{
												num9 ^= 0x4B;
												while (true)
												{
													num10 = GEventArgs2.smethod_0(43);
													while (true)
													{
														switch (num10 ^ 0x44)
														{
														case -68:
															break;
														default:
															goto end_IL_0029;
														case -69:
															num9 = Class55.smethod_1(72);
															num10 = -6;
															num10 = -66;
															goto end_IL_004a;
														case -66:
															goto end_IL_004a;
														case -67:
															while (true)
															{
																num10 = -7;
																num10 = -67;
															}
														}
														switch (num9)
														{
														case -72:
															goto IL_006b;
														case -70:
															goto IL_0079;
														case -71:
															goto IL_01d7;
														case -69:
															goto end_IL_01e4;
														}
														num10 = Class8.smethod_0(39);
														continue;
														IL_006b:
														num9 = Class8.smethod_0(58);
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
												IL_01c1:
												num5 ^= 0x45;
												goto IL_01c8;
												IL_0079:
												switch (num8)
												{
												case -66:
													goto IL_009c;
												case -64:
													goto IL_01d0;
												case -65:
													goto IL_01f6;
												case -67:
													goto end_IL_01ff;
												}
												num9 = -14;
												continue;
												IL_01f6:
												num8 = GEventArgs2.smethod_0(44);
												break;
												IL_009c:
												switch (num7)
												{
												case -67:
													break;
												case -65:
													goto IL_00c4;
												case -66:
													goto IL_01c8;
												default:
													goto IL_01f0;
												case -64:
													goto end_IL_0219;
												}
												num7 = -12;
												goto IL_01d0;
												IL_01f0:
												num8 = -16;
												break;
												IL_00c4:
												switch (num6)
												{
												case 69:
													goto IL_00e7;
												case 71:
													goto IL_01c1;
												case 70:
													goto IL_022e;
												case 68:
													goto end_IL_0232;
												}
												num7 = -9;
												goto IL_01d0;
												IL_022e:
												num6 = 15;
												goto end_IL_0219;
												IL_00e7:
												switch (num5)
												{
												case -66:
													break;
												case -65:
													goto IL_010f;
												case -67:
													goto IL_01b4;
												default:
													goto IL_0228;
												case -64:
													goto end_IL_023b;
												}
												num5 = -5;
												goto IL_01c1;
												IL_0228:
												num6 = 13;
												goto end_IL_0219;
												IL_010f:
												switch (num4)
												{
												case 74:
													goto IL_0132;
												case 77:
													goto IL_01af;
												case 76:
													goto IL_0250;
												case 75:
													goto end_IL_0253;
												}
												num5 = -8;
												goto IL_01c1;
												IL_0250:
												num4 = 8;
												goto end_IL_023b;
												IL_0132:
												switch (num3)
												{
												case -71:
													break;
												case -70:
													goto IL_0155;
												case -72:
													goto IL_01a5;
												default:
													goto IL_024a;
												case -69:
													goto end_IL_025c;
												}
												num3 = -3;
												goto IL_01af;
												IL_024a:
												num4 = 15;
												goto end_IL_023b;
												IL_0155:
												switch (num2)
												{
												case -71:
													goto IL_0173;
												case -69:
													goto IL_01a0;
												case -72:
													goto IL_026a;
												case -70:
													goto end_IL_0277;
												}
												num3 = -4;
												goto IL_01af;
												IL_026a:
												num2 = -3;
												goto end_IL_025c;
												IL_0173:
												switch (num)
												{
												case -62:
													break;
												case -61:
													goto IL_019d;
												default:
													goto IL_026f;
												case -63:
												case -60:
													return hashCode;
												}
												hashCode = base.GetHashCode();
												num = -127;
												goto IL_01a0;
												IL_026f:
												num2 = Class8.smethod_0(39);
												goto end_IL_025c;
												IL_019d:
												num = -125;
												goto IL_01a0;
												IL_01c8:
												num6 = 12;
												num7 = -119;
												goto IL_01d0;
												IL_01a0:
												num ^= 0x40;
												goto IL_01a5;
												IL_01a5:
												num2 = Class8.smethod_0(38);
												num3 = -1;
												goto IL_01af;
												IL_01d7:
												num8 = Class8.smethod_0(58);
												num9 = -16;
												continue;
												IL_01d0:
												num7 ^= 0x49;
												goto IL_01d7;
												IL_01af:
												num3 ^= 0x44;
												goto IL_01b4;
												IL_01b4:
												num4 = 14;
												num5 = Class55.smethod_1(65);
												goto IL_01c1;
												continue;
												end_IL_01e4:
												break;
											}
											continue;
											end_IL_01ff:
											break;
										}
										continue;
										end_IL_0219:
										break;
									}
									continue;
									end_IL_0232:
									break;
								}
								continue;
								end_IL_023b:
								break;
							}
							continue;
							end_IL_0253:
							break;
						}
						continue;
						end_IL_025c:
						break;
					}
					continue;
					end_IL_0277:
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
				int num = 4;
				int num2 = -16;
				while (true)
				{
					num2 ^= 0x4E;
					while (true)
					{
						int num3 = Class8.smethod_0(38);
						int num4 = -13;
						while (true)
						{
							num4 ^= 0x4A;
							while (true)
							{
								int num5 = 15;
								int num6 = 9;
								while (true)
								{
									num6 ^= 0x43;
									while (true)
									{
										int num7 = GEventArgs2.smethod_0(49);
										int num8 = 4;
										while (true)
										{
											num8 ^= 0x48;
											while (true)
											{
												int num9 = 8;
												int num10 = Class8.smethod_0(48);
												while (true)
												{
													switch (num10 ^ 0x4C)
													{
													case -74:
														break;
													default:
														goto IL_000d;
													case -76:
														goto IL_001b;
													case -77:
														goto end_IL_01a9;
													case -75:
														while (true)
														{
															num10 = -7;
															num10 = -75;
														}
													}
													goto IL_0006;
													IL_001b:
													switch (num9)
													{
													case 70:
														break;
													case 71:
														goto IL_0040;
													case 69:
														goto IL_019e;
													default:
														goto IL_01cf;
													case 72:
														goto end_IL_01d6;
													}
													num9 = 9;
													goto IL_0006;
													IL_01cf:
													num10 = -1;
													num10 = -77;
													break;
													IL_0040:
													switch (num8)
													{
													case 73:
														goto IL_0060;
													case 76:
														goto IL_0197;
													case 75:
														goto IL_01e9;
													case 74:
														goto end_IL_01ec;
													}
													num9 = 10;
													goto IL_0006;
													IL_01e9:
													num8 = 3;
													goto end_IL_01d6;
													IL_0060:
													switch (num7)
													{
													case -66:
														break;
													case -65:
														goto IL_0088;
													case -67:
														goto IL_018a;
													default:
														goto IL_01e4;
													case -64:
														goto end_IL_01f5;
													}
													num7 = -9;
													goto IL_0197;
													IL_01e4:
													num8 = 2;
													goto end_IL_01d6;
													IL_0088:
													switch (num6)
													{
													case 73:
														goto IL_00ab;
													case 74:
														goto IL_0183;
													case 72:
														goto IL_0203;
													case 71:
														goto end_IL_020c;
													}
													num7 = -12;
													goto IL_0197;
													IL_0203:
													num6 = 11;
													goto end_IL_01f5;
													IL_00ab:
													switch (num5)
													{
													case 76:
														break;
													case 75:
														goto IL_0170;
													case 77:
														goto IL_017f;
													default:
														goto IL_0209;
													case 78:
														goto end_IL_0215;
													}
													switch (num4)
													{
													case -72:
														goto IL_00ec;
													case -71:
														goto IL_016b;
													case -74:
														goto IL_021f;
													case -73:
														goto end_IL_022e;
													}
													num5 = 8;
													goto IL_0183;
													IL_0209:
													num6 = 4;
													goto end_IL_01f5;
													IL_017f:
													num5 = 14;
													goto IL_0183;
													IL_019e:
													num8 = 1;
													num9 = 7;
													goto IL_0006;
													IL_021f:
													num4 = -4;
													goto end_IL_0215;
													IL_00ec:
													switch (num3)
													{
													case -76:
														break;
													case -75:
														goto IL_010f;
													case -74:
														goto IL_0160;
													default:
														goto IL_0225;
													case -73:
														goto end_IL_0237;
													}
													num3 = -3;
													goto IL_016b;
													IL_0225:
													num4 = Class8.smethod_0(41);
													goto end_IL_0215;
													IL_010f:
													switch (num2)
													{
													case -67:
														goto IL_012c;
													case -66:
														goto IL_015b;
													case -68:
														goto IL_0245;
													case -69:
														goto end_IL_0252;
													}
													num3 = -1;
													goto IL_016b;
													IL_0245:
													num2 = -14;
													goto end_IL_0237;
													IL_012c:
													switch (num)
													{
													case 76:
														break;
													case 77:
														goto IL_0159;
													default:
														goto IL_024a;
													case 78:
													case 79:
														return typeFromHandle;
													}
													typeFromHandle = typeof(Class2);
													num = 6;
													goto IL_015b;
													IL_024a:
													num2 = GEventArgs2.smethod_0(40);
													goto end_IL_0237;
													IL_0159:
													num = 5;
													goto IL_015b;
													IL_000d:
													num10 = GEventArgs2.smethod_0(43);
													continue;
													IL_015b:
													num ^= 0x48;
													goto IL_0160;
													IL_0160:
													num2 = Class8.smethod_0(58);
													num3 = -2;
													goto IL_016b;
													IL_0006:
													num9 ^= 0x4F;
													goto IL_000d;
													IL_018a:
													num6 = 10;
													num7 = Class55.smethod_1(78);
													goto IL_0197;
													IL_016b:
													num3 ^= 0x49;
													goto IL_0170;
													IL_0170:
													num4 = GEventArgs2.smethod_0(44);
													num5 = 13;
													goto IL_0183;
													IL_0197:
													num7 ^= 0x49;
													goto IL_019e;
													IL_0183:
													num5 ^= 0x43;
													goto IL_018a;
													continue;
													end_IL_01a9:
													break;
												}
												continue;
												end_IL_01d6:
												break;
											}
											continue;
											end_IL_01ec:
											break;
										}
										continue;
										end_IL_01f5:
										break;
									}
									continue;
									end_IL_020c:
									break;
								}
								continue;
								end_IL_0215:
								break;
							}
							continue;
							end_IL_022e:
							break;
						}
						continue;
						end_IL_0237:
						break;
					}
					continue;
					end_IL_0252:
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
				int num = Class8.smethod_0(47);
				int num2 = -13;
				while (true)
				{
					num2 ^= 0x45;
					while (true)
					{
						int num3 = Class8.smethod_0(41);
						int num4 = -8;
						while (true)
						{
							num4 ^= 0x4D;
							while (true)
							{
								int num5 = Class55.smethod_1(71);
								int num6 = Class55.smethod_1(65);
								while (true)
								{
									switch (num6 ^ 0x45)
									{
									case -64:
										break;
									case -65:
										goto IL_001b;
									default:
										num6 = Class8.smethod_0(48);
										continue;
									case -66:
										goto end_IL_010d;
									case -67:
										while (true)
										{
											num6 = -8;
											num6 = -67;
										}
									}
									goto IL_0006;
									IL_001b:
									switch (num5)
									{
									case -75:
										break;
									case -73:
										goto IL_0040;
									case -74:
										goto IL_00ed;
									default:
										goto IL_0130;
									case -72:
										goto end_IL_0138;
									}
									num5 = -10;
									goto IL_0006;
									IL_0130:
									num6 = -5;
									num6 = -66;
									break;
									IL_0040:
									switch (num4)
									{
									case -77:
										goto IL_0060;
									case -75:
										goto IL_00e8;
									case -78:
										goto IL_014c;
									case -76:
										goto end_IL_015b;
									}
									num5 = -11;
									goto IL_0006;
									IL_014c:
									num4 = Class8.smethod_0(39);
									goto end_IL_0138;
									IL_0060:
									switch (num3)
									{
									case -70:
										break;
									case -69:
										goto IL_0083;
									case -68:
										goto IL_00d8;
									default:
										goto IL_0157;
									case -67:
										goto end_IL_0164;
									}
									num3 = -4;
									goto IL_00e8;
									IL_0157:
									num4 = -7;
									goto end_IL_0138;
									IL_0083:
									switch (num2)
									{
									case -75:
										goto IL_00a1;
									case -74:
										goto IL_00d3;
									case -77:
										goto IL_0172;
									case -76:
										goto end_IL_017a;
									}
									num3 = -6;
									goto IL_00e8;
									IL_0172:
									num2 = -10;
									goto end_IL_0164;
									IL_00a1:
									switch (num)
									{
									case -68:
										break;
									case -67:
										goto IL_00c4;
									default:
										goto IL_0177;
									case -66:
									case -65:
										return result;
									}
									num = -6;
									goto IL_00d3;
									IL_0177:
									num2 = -15;
									goto end_IL_0164;
									IL_00c4:
									result = base.ToString();
									num = GEventArgs2.smethod_0(43);
									goto IL_00d3;
									IL_0006:
									num5 ^= 0x43;
									num6 = Class8.smethod_0(48);
									continue;
									IL_00d3:
									num ^= 0x46;
									goto IL_00d8;
									IL_00d8:
									num2 = Class8.smethod_0(37);
									num3 = Class8.smethod_0(47);
									goto IL_00e8;
									IL_00e8:
									num3 ^= 0x46;
									goto IL_00ed;
									IL_00ed:
									num4 = Class8.smethod_0(42);
									num5 = Class8.smethod_0(47);
									goto IL_0006;
									continue;
									end_IL_010d:
									break;
								}
								continue;
								end_IL_0138:
								break;
							}
							continue;
							end_IL_015b:
							break;
						}
						continue;
						end_IL_0164:
						break;
					}
					continue;
					end_IL_017a:
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class3
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			bool result = default(bool);
			while (true)
			{
				int num = 2;
				int num2 = 1;
				while (true)
				{
					num2 ^= 0x47;
					while (true)
					{
						int num3 = 14;
						int num4 = 8;
						while (true)
						{
							num4 ^= 0x47;
							while (true)
							{
								int num5 = 7;
								int num6 = 0;
								while (true)
								{
									num6 ^= 0x49;
									while (true)
									{
										int num7 = 7;
										int num8 = 0;
										while (true)
										{
											num8 ^= 0x4B;
											int num9 = 2;
											int num10 = -16;
											num10 = -76;
											while (true)
											{
												num9 ^= 0x4B;
												while (true)
												{
													num10 = GEventArgs2.smethod_0(40);
													while (true)
													{
														switch (num10 ^ 0x44)
														{
														case -79:
															break;
														default:
															goto end_IL_0029;
														case -77:
															num9 = 2;
															num10 = -16;
															num10 = -76;
															goto end_IL_004a;
														case -76:
															goto end_IL_004a;
														case -78:
															while (true)
															{
																num10 = -10;
																num10 = -78;
															}
														}
														switch (num9)
														{
														case 73:
															goto IL_0055;
														case 72:
															goto IL_01a6;
														case 74:
															goto IL_01ae;
														case 75:
															goto end_IL_01be;
														}
														num10 = GEventArgs2.smethod_0(46);
														continue;
														IL_01ae:
														num9 = 1;
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
												IL_0190:
												num5 ^= 0x4D;
												goto IL_0197;
												IL_0055:
												switch (num8)
												{
												case 73:
													goto IL_0077;
												case 75:
													goto IL_019f;
												case 74:
													goto IL_01cf;
												case 72:
													goto end_IL_01d2;
												}
												num9 = 3;
												continue;
												IL_01cf:
												num8 = 1;
												break;
												IL_0077:
												switch (num7)
												{
												case 78:
													break;
												case 79:
													goto IL_009e;
												case 77:
													goto IL_0197;
												default:
													goto IL_01ca;
												case 80:
													goto end_IL_01e6;
												}
												num7 = 6;
												goto IL_019f;
												IL_01ca:
												num8 = 3;
												break;
												IL_009e:
												switch (num6)
												{
												case 71:
													goto IL_00c0;
												case 73:
													goto IL_0190;
												case 72:
													goto IL_01f4;
												case 70:
													goto end_IL_01f7;
												}
												num7 = 5;
												goto IL_019f;
												IL_01f4:
												num6 = 1;
												goto end_IL_01e6;
												IL_00c0:
												switch (num5)
												{
												case 73:
													break;
												case 74:
													goto IL_00e7;
												case 75:
													goto IL_0189;
												default:
													goto IL_01ee;
												case 76:
													goto end_IL_0200;
												}
												num5 = 4;
												goto IL_0190;
												IL_01ee:
												num6 = 15;
												goto end_IL_01e6;
												IL_00e7:
												switch (num4)
												{
												case 77:
													goto IL_0109;
												case 79:
													goto IL_0184;
												case 78:
													goto IL_020e;
												case 76:
													goto end_IL_0212;
												}
												num5 = 6;
												goto IL_0190;
												IL_020e:
												num4 = 9;
												goto end_IL_0200;
												IL_0109:
												switch (num3)
												{
												case 67:
													break;
												case 68:
													goto IL_017b;
												case 69:
													goto IL_0182;
												default:
													goto IL_0208;
												case 70:
													goto end_IL_021b;
												}
												switch (num2)
												{
												case 69:
													goto IL_0145;
												case 70:
													goto IL_0176;
												case 68:
													goto IL_0223;
												case 67:
													goto end_IL_0229;
												}
												num3 = 9;
												goto IL_0184;
												IL_0208:
												num4 = 11;
												goto end_IL_0200;
												IL_0182:
												num3 = 8;
												goto IL_0184;
												IL_019f:
												num7 ^= 0x48;
												goto IL_01a6;
												IL_0223:
												num2 = 3;
												goto end_IL_021b;
												IL_0145:
												switch (num)
												{
												case 72:
													break;
												case 74:
													goto IL_0167;
												default:
													goto IL_0227;
												case 73:
												case 75:
													return result;
												}
												num = 0;
												goto IL_0176;
												IL_0227:
												num2 = 4;
												goto end_IL_021b;
												IL_0167:
												result = base.Equals(RuntimeHelpers.GetObjectValue(o));
												num = 1;
												goto IL_0176;
												IL_0197:
												num6 = 14;
												num7 = 24;
												goto IL_019f;
												IL_0176:
												num ^= 0x48;
												goto IL_017b;
												IL_017b:
												num2 = 2;
												num3 = 11;
												goto IL_0184;
												IL_01a6:
												num8 = 2;
												num9 = 0;
												continue;
												IL_0184:
												num3 ^= 0x4D;
												goto IL_0189;
												IL_0189:
												num4 = 10;
												num5 = 1;
												goto IL_0190;
												continue;
												end_IL_01be:
												break;
											}
											continue;
											end_IL_01d2:
											break;
										}
										continue;
										end_IL_01e6:
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
							end_IL_0212:
							break;
						}
						continue;
						end_IL_021b:
						break;
					}
					continue;
					end_IL_0229:
					break;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			int hashCode = default(int);
			while (true)
			{
				int num = Class8.smethod_0(42);
				int num2 = -121;
				while (true)
				{
					num2 ^= 0x47;
					while (true)
					{
						int num3 = 15;
						int num4 = Class8.smethod_0(37);
						while (true)
						{
							num4 ^= 0x4B;
							while (true)
							{
								int num5 = GEventArgs2.smethod_0(43);
								int num6 = -11;
								while (true)
								{
									num6 ^= 0x4F;
									while (true)
									{
										int num7 = Class8.smethod_0(38);
										int num8 = -14;
										while (true)
										{
											num8 ^= 0x46;
											int num9 = 0;
											int num10 = -12;
											num10 = -66;
											while (true)
											{
												IL_01eb:
												num9 ^= 0x4C;
												while (true)
												{
													num10 = GEventArgs2.smethod_0(46);
													while (true)
													{
														switch (num10 ^ 0x4A)
														{
														case -68:
															num10 = GEventArgs2.smethod_0(49);
															continue;
														case -67:
															goto end_IL_0030;
														case -69:
															goto IL_005d;
														case -66:
															goto IL_01eb;
														}
														break;
													}
													continue;
													end_IL_0030:
													break;
												}
												switch (num9)
												{
												case 76:
													goto IL_006d;
												case 75:
													goto IL_01da;
												case 77:
													goto IL_01e8;
												case 78:
													goto end_IL_01eb;
												}
												num10 = -15;
												num10 = -69;
												goto IL_005d;
												IL_01a7:
												num4 = Class8.smethod_0(58);
												num5 = Class8.smethod_0(39);
												goto IL_01b9;
												IL_01da:
												num8 = GEventArgs2.smethod_0(46);
												num9 = 2;
												continue;
												IL_01e8:
												num9 = 1;
												continue;
												IL_006d:
												switch (num8)
												{
												case -79:
													goto IL_008f;
												case -76:
													goto IL_01d3;
												case -77:
													goto IL_01fd;
												case -78:
													goto end_IL_0206;
												}
												num9 = 7;
												continue;
												IL_01fd:
												num8 = GEventArgs2.smethod_0(40);
												break;
												IL_008f:
												switch (num7)
												{
												case -74:
													break;
												case -73:
													goto IL_01c0;
												case -72:
													goto IL_01cf;
												default:
													goto IL_01f7;
												case -71:
													goto end_IL_021a;
												}
												switch (num6)
												{
												case -73:
													goto IL_00d6;
												case -70:
													goto IL_01b9;
												case -71:
													goto IL_022f;
												case -72:
													goto end_IL_0233;
												}
												num7 = Class8.smethod_0(41);
												goto IL_01d3;
												IL_01f7:
												num8 = -12;
												break;
												IL_01cf:
												num7 = -14;
												goto IL_01d3;
												IL_01c0:
												num6 = GEventArgs2.smethod_0(43);
												num7 = -13;
												goto IL_01d3;
												IL_022f:
												num6 = -10;
												goto end_IL_021a;
												IL_00d6:
												switch (num5)
												{
												case -71:
													break;
												case -69:
													goto IL_00fe;
												case -70:
													goto IL_01a7;
												default:
													goto IL_0229;
												case -68:
													goto end_IL_023c;
												}
												num5 = -6;
												goto IL_01b9;
												IL_0229:
												num6 = -9;
												goto end_IL_021a;
												IL_00fe:
												switch (num4)
												{
												case -72:
													goto IL_0121;
												case -69:
													goto IL_01a2;
												case -71:
													goto IL_0251;
												case -70:
													goto end_IL_0255;
												}
												num5 = -7;
												goto IL_01b9;
												IL_0251:
												num4 = -14;
												goto end_IL_023c;
												IL_0121:
												switch (num3)
												{
												case 68:
													break;
												case 67:
													goto IL_0192;
												case 69:
													goto IL_019f;
												default:
													goto IL_024b;
												case 70:
													goto end_IL_025e;
												}
												switch (num2)
												{
												case -67:
													goto IL_015c;
												case -64:
													goto IL_018d;
												case -66:
													goto IL_0271;
												case -65:
													goto end_IL_0279;
												}
												num3 = 8;
												goto IL_01a2;
												IL_024b:
												num4 = -15;
												goto end_IL_023c;
												IL_019f:
												num3 = 14;
												goto IL_01a2;
												IL_01b9:
												num5 ^= 0x43;
												goto IL_01c0;
												IL_0271:
												num2 = Class8.smethod_0(57);
												goto end_IL_025e;
												IL_015c:
												switch (num)
												{
												case -76:
													break;
												case -75:
													goto IL_018b;
												default:
													goto IL_026c;
												case -74:
												case -73:
													return hashCode;
												}
												hashCode = base.GetHashCode();
												num = Class8.smethod_0(38);
												goto IL_018d;
												IL_026c:
												num2 = -8;
												goto end_IL_025e;
												IL_018b:
												num = -1;
												goto IL_018d;
												IL_005d:
												num9 = 0;
												num10 = -12;
												num10 = -66;
												continue;
												IL_018d:
												num ^= 0x4A;
												goto IL_0192;
												IL_0192:
												num2 = Class8.smethod_0(48);
												num3 = 13;
												goto IL_01a2;
												IL_01d3:
												num7 ^= 0x4A;
												goto IL_01da;
												IL_01a2:
												num3 ^= 0x4B;
												goto IL_01a7;
												continue;
												end_IL_01eb:
												break;
											}
											continue;
											end_IL_0206:
											break;
										}
										continue;
										end_IL_021a:
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
							end_IL_0255:
							break;
						}
						continue;
						end_IL_025e:
						break;
					}
					continue;
					end_IL_0279:
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
				int num = 18;
				int num2 = 22;
				while (true)
				{
					num2 ^= 0x47;
					while (true)
					{
						int num3 = 4;
						int num4 = Class8.smethod_0(39);
						while (true)
						{
							num4 ^= 0x44;
							while (true)
							{
								int num5 = 4;
								int num6 = 28;
								while (true)
								{
									num6 ^= 0x4E;
									int num7 = Class55.smethod_1(71);
									while (true)
									{
										switch (num7 ^ 0x48)
										{
										case -68:
											break;
										default:
											num7 = Class55.smethod_1(71);
											continue;
										case -66:
											num6 = 30;
											num7 = -9;
											num7 = -65;
											goto end_IL_0034;
										case -65:
											goto end_IL_0034;
										case -67:
											while (true)
											{
												num7 = -11;
												num7 = -67;
											}
										}
										switch (num6)
										{
										case 80:
											goto IL_0057;
										case 81:
											goto IL_0130;
										case 82:
											goto IL_0136;
										case 79:
											goto end_IL_0157;
										}
										num7 = GEventArgs2.smethod_0(49);
										continue;
										IL_0130:
										num6 = 31;
										break;
										continue;
										end_IL_0034:
										break;
									}
									continue;
									IL_011d:
									num3 ^= 0x4F;
									goto IL_0122;
									IL_0057:
									switch (num5)
									{
									case 76:
										goto IL_0079;
									case 78:
										goto IL_0081;
									case 77:
										goto IL_0122;
									case 79:
										goto end_IL_016c;
									}
									num6 = 1;
									continue;
									IL_0081:
									switch (num4)
									{
									case -70:
										goto IL_00a3;
									case -69:
										goto IL_011d;
									case -71:
										goto IL_0175;
									case -72:
										goto end_IL_017f;
									}
									num5 = 7;
									goto IL_0136;
									IL_0175:
									num4 = -3;
									goto end_IL_016c;
									IL_00a3:
									switch (num3)
									{
									case 74:
										break;
									case 75:
										goto IL_00c5;
									case 73:
										goto IL_0118;
									default:
										goto IL_017b;
									case 76:
										goto end_IL_0188;
									}
									num3 = 5;
									goto IL_011d;
									IL_017b:
									num4 = -4;
									goto end_IL_016c;
									IL_00c5:
									switch (num2)
									{
									case 80:
										goto IL_00e2;
									case 81:
										goto IL_0113;
									case 79:
										goto IL_0195;
									case 78:
										goto end_IL_019c;
									}
									num3 = 6;
									goto IL_011d;
									IL_0195:
									num2 = 8;
									goto end_IL_0188;
									IL_00e2:
									switch (num)
									{
									case 80:
										break;
									case 81:
										goto IL_0105;
									default:
										goto IL_0199;
									case 79:
									case 82:
										return typeFromHandle;
									}
									num = 19;
									goto IL_0113;
									IL_0199:
									num2 = 9;
									goto end_IL_0188;
									IL_0105:
									typeFromHandle = typeof(Class3);
									num = 12;
									goto IL_0113;
									IL_0122:
									num4 = Class8.smethod_0(42);
									num5 = 5;
									goto IL_0136;
									IL_0113:
									num ^= 0x43;
									goto IL_0118;
									IL_0118:
									num2 = 23;
									num3 = 3;
									goto IL_011d;
									IL_0136:
									num5 ^= 0x4A;
									num6 = 30;
									num7 = -9;
									num7 = -65;
									continue;
									IL_0079:
									num5 = 6;
									goto IL_0136;
									continue;
									end_IL_0157:
									break;
								}
								continue;
								end_IL_016c:
								break;
							}
							continue;
							end_IL_017f:
							break;
						}
						continue;
						end_IL_0188:
						break;
					}
					continue;
					end_IL_019c:
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
				int num = 3;
				int num2 = 9;
				while (true)
				{
					num2 ^= 0x4F;
					while (true)
					{
						int num3 = 25;
						int num4 = -4;
						while (true)
						{
							num4 ^= 0x49;
							while (true)
							{
								int num5 = 13;
								int num6 = 4;
								while (true)
								{
									num6 ^= 0x4B;
									while (true)
									{
										int num7 = 10;
										int num8 = -8;
										while (true)
										{
											num8 ^= 0x46;
											int num9 = GEventArgs2.smethod_0(43);
											int num10 = -13;
											num10 = -70;
											while (true)
											{
												num9 ^= 0x46;
												while (true)
												{
													num10 = Class55.smethod_1(72);
													while (true)
													{
														switch (num10 ^ 0x49)
														{
														case -72:
															break;
														default:
															goto end_IL_0029;
														case -73:
															num9 = GEventArgs2.smethod_0(43);
															num10 = -13;
															num10 = -70;
															goto end_IL_004a;
														case -70:
															goto end_IL_004a;
														case -71:
															while (true)
															{
																num10 = -16;
																num10 = -71;
															}
														}
														switch (num9)
														{
														case -67:
															goto IL_006b;
														case -66:
															goto IL_0074;
														case -68:
															goto IL_01c8;
														case -65:
															goto end_IL_01d5;
														}
														num10 = Class8.smethod_0(42);
														continue;
														IL_006b:
														num9 = -5;
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
												IL_01b4:
												num5 ^= 0x4B;
												goto IL_01bb;
												IL_0074:
												switch (num8)
												{
												case -67:
													goto IL_0097;
												case -66:
													goto IL_01c1;
												case -69:
													goto IL_01e1;
												case -68:
													goto end_IL_01f0;
												}
												num9 = -6;
												continue;
												IL_01e1:
												num8 = -3;
												break;
												IL_0097:
												switch (num7)
												{
												case 69:
													break;
												case 71:
													goto IL_00be;
												case 70:
													goto IL_01bb;
												default:
													goto IL_01e7;
												case 72:
													goto end_IL_020a;
												}
												num7 = 8;
												goto IL_01c1;
												IL_01e7:
												num8 = Class8.smethod_0(48);
												break;
												IL_00be:
												switch (num6)
												{
												case 78:
													goto IL_00e1;
												case 79:
													goto IL_01b4;
												case 77:
													goto IL_0214;
												case 76:
													goto end_IL_021c;
												}
												num7 = 11;
												goto IL_01c1;
												IL_0214:
												num6 = 6;
												goto end_IL_020a;
												IL_00e1:
												switch (num5)
												{
												case 68:
													break;
												case 70:
													goto IL_0109;
												case 69:
													goto IL_01a7;
												default:
													goto IL_0219;
												case 71:
													goto end_IL_0225;
												}
												num5 = 15;
												goto IL_01b4;
												IL_0219:
												num6 = 7;
												goto end_IL_020a;
												IL_0109:
												switch (num4)
												{
												case -77:
													goto IL_012c;
												case -75:
													goto IL_01a2;
												case -76:
													goto IL_0239;
												case -78:
													goto end_IL_023d;
												}
												num5 = 14;
												goto IL_01b4;
												IL_0239:
												num4 = -3;
												goto end_IL_0225;
												IL_012c:
												switch (num3)
												{
												case 79:
													break;
												case 81:
													goto IL_014e;
												case 80:
													goto IL_019c;
												default:
													goto IL_022e;
												case 82:
													goto end_IL_0246;
												}
												num3 = 7;
												goto IL_01a2;
												IL_022e:
												num4 = Class8.smethod_0(47);
												goto end_IL_0225;
												IL_014e:
												switch (num2)
												{
												case 68:
													goto IL_016c;
												case 70:
													goto IL_0197;
												case 67:
													goto IL_024f;
												case 69:
													goto end_IL_0257;
												}
												num3 = 24;
												goto IL_01a2;
												IL_024f:
												num2 = 12;
												goto end_IL_0246;
												IL_016c:
												switch (num)
												{
												case 74:
													break;
												case 76:
													goto IL_018e;
												default:
													goto IL_0254;
												case 75:
												case 77:
													return result;
												}
												num = 5;
												goto IL_0197;
												IL_0254:
												num2 = 10;
												goto end_IL_0246;
												IL_018e:
												result = base.ToString();
												num = 4;
												goto IL_0197;
												IL_01bb:
												num6 = 5;
												num7 = 5;
												goto IL_01c1;
												IL_0197:
												num ^= 0x4F;
												goto IL_019c;
												IL_019c:
												num2 = 11;
												num3 = 26;
												goto IL_01a2;
												IL_01c8:
												num8 = Class8.smethod_0(47);
												num9 = -7;
												continue;
												IL_01c1:
												num7 ^= 0x4D;
												goto IL_01c8;
												IL_01a2:
												num3 ^= 0x48;
												goto IL_01a7;
												IL_01a7:
												num4 = Class8.smethod_0(48);
												num5 = 12;
												goto IL_01b4;
												continue;
												end_IL_01d5:
												break;
											}
											continue;
											end_IL_01f0:
											break;
										}
										continue;
										end_IL_020a:
										break;
									}
									continue;
									end_IL_021c:
									break;
								}
								continue;
								end_IL_0225:
								break;
							}
							continue;
							end_IL_023d:
							break;
						}
						continue;
						end_IL_0246:
						break;
					}
					continue;
					end_IL_0257:
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
		[ThreadStatic]
		[CompilerGenerated]
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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
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
				int num = Class8.smethod_0(53);
				int num2 = 11;
				while (true)
				{
					num2 ^= 0x37;
					while (true)
					{
						int num3 = Class8.smethod_0(42);
						int num4 = -31;
						while (true)
						{
							num4 ^= 0x31;
							while (true)
							{
								int num5 = 1;
								int num6 = 0;
								while (true)
								{
									num6 ^= 0x38;
									int num7 = 20;
									int num8 = -28;
									num8 = -46;
									while (true)
									{
										num7 ^= 0x3B;
										num8 = Class8.smethod_0(50);
										while (true)
										{
											switch (num8 ^ 0x36)
											{
											case -48:
												break;
											default:
												num8 = Class8.smethod_0(50);
												continue;
											case -47:
												num7 = 20;
												num8 = -28;
												num8 = -46;
												goto end_IL_0034;
											case -46:
												goto end_IL_0034;
											case -49:
												while (true)
												{
													num8 = -7;
													num8 = -49;
												}
											}
											switch (num7)
											{
											case 47:
												goto IL_0057;
											case 48:
												goto IL_0161;
											case 49:
												goto IL_0167;
											case 50:
												goto end_IL_017d;
											}
											num8 = Class8.smethod_0(51);
											continue;
											IL_0161:
											num7 = 11;
											break;
											continue;
											end_IL_0034:
											break;
										}
										continue;
										IL_0158:
										num5 ^= 0x30;
										goto IL_0167;
										IL_0057:
										switch (num6)
										{
										case 54:
											goto IL_007a;
										case 56:
											goto IL_0158;
										case 53:
											goto IL_0192;
										case 55:
											goto end_IL_019c;
										}
										num7 = 10;
										continue;
										IL_0192:
										num6 = 13;
										break;
										IL_007a:
										switch (num5)
										{
										case 49:
											break;
										case 50:
											goto IL_0147;
										case 51:
											goto IL_0155;
										default:
											goto IL_0198;
										case 52:
											goto end_IL_01b1;
										}
										switch (num4)
										{
										case -51:
											goto IL_00bb;
										case -48:
											goto IL_0142;
										case -50:
											goto IL_01c4;
										case -49:
											goto end_IL_01c7;
										}
										num5 = 2;
										goto IL_0158;
										IL_0198:
										num6 = 15;
										break;
										IL_0155:
										num5 = 3;
										goto IL_0158;
										IL_0147:
										num4 = Class8.smethod_0(38);
										num5 = 4;
										goto IL_0158;
										IL_01c4:
										num4 = -1;
										goto end_IL_01b1;
										IL_00bb:
										switch (num3)
										{
										case -56:
											break;
										case -55:
											goto IL_00e3;
										case -57:
											goto IL_013c;
										default:
											goto IL_01b9;
										case -54:
											goto end_IL_01d0;
										}
										num3 = Class8.smethod_0(39);
										goto IL_0142;
										IL_01b9:
										num4 = Class8.smethod_0(42);
										goto end_IL_01b1;
										IL_00e3:
										switch (num2)
										{
										case 59:
											goto IL_0101;
										case 60:
											goto IL_0137;
										case 57:
											goto IL_01de;
										case 58:
											goto end_IL_01e6;
										}
										num3 = -16;
										goto IL_0142;
										IL_01de:
										num2 = 14;
										goto end_IL_01d0;
										IL_0101:
										switch (num)
										{
										case -49:
											break;
										case -48:
											goto IL_0124;
										default:
											goto IL_01e3;
										case -50:
										case -47:
											return result;
										}
										num = -3;
										goto IL_0137;
										IL_01e3:
										num2 = 13;
										goto end_IL_01d0;
										IL_0124:
										result = Delegate11.smethod_0(class4_0);
										num = Class8.smethod_0(38);
										goto IL_0137;
										IL_0142:
										num3 ^= 0x37;
										goto IL_0147;
										IL_0137:
										num ^= 0x32;
										goto IL_013c;
										IL_013c:
										num2 = 12;
										num3 = -3;
										goto IL_0142;
										IL_0167:
										num6 = 14;
										num7 = 9;
										continue;
										end_IL_017d:
										break;
									}
									continue;
									end_IL_019c:
									break;
								}
								continue;
								end_IL_01b1:
								break;
							}
							continue;
							end_IL_01c7:
							break;
						}
						continue;
						end_IL_01d0:
						break;
					}
					continue;
					end_IL_01e6:
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
				int num = Class8.smethod_0(39);
				int num2 = -8;
				while (true)
				{
					num2 ^= 0x31;
					while (true)
					{
						int num3 = Class8.smethod_0(39);
						int num4 = 9;
						while (true)
						{
							num4 ^= 0x37;
							while (true)
							{
								int num5 = 1;
								int num6 = 12;
								while (true)
								{
									num6 ^= 0x30;
									int num7 = 14;
									int num8 = -27;
									num8 = -44;
									while (true)
									{
										IL_0188:
										num7 ^= 0x35;
										num8 = Class8.smethod_0(53);
										while (true)
										{
											switch (num8 ^ 0x31)
											{
											case -46:
												num8 = GEventArgs2.smethod_1(68);
												continue;
											default:
												num8 = Class8.smethod_0(53);
												continue;
											case -45:
												break;
											case -47:
												goto IL_005f;
											case -44:
												goto IL_0188;
											}
											break;
										}
										switch (num7)
										{
										case 58:
											goto IL_0070;
										case 59:
											goto IL_0079;
										case 60:
											goto IL_0181;
										case 61:
											goto end_IL_0188;
										}
										num8 = -32;
										num8 = -47;
										goto IL_005f;
										IL_0169:
										num3 ^= 0x32;
										goto IL_016e;
										IL_016e:
										num4 = 12;
										num5 = 2;
										goto IL_017a;
										IL_0079:
										switch (num6)
										{
										case 59:
											goto IL_009c;
										case 60:
											goto IL_017a;
										case 57:
											goto IL_019d;
										case 58:
											goto end_IL_01a7;
										}
										num7 = 9;
										continue;
										IL_019d:
										num6 = 9;
										break;
										IL_009c:
										switch (num5)
										{
										case 56:
											break;
										case 57:
											goto IL_016e;
										case 58:
											goto IL_0177;
										default:
											goto IL_01a3;
										case 59:
											goto end_IL_01bc;
										}
										switch (num4)
										{
										case 59:
											goto IL_00dd;
										case 62:
											goto IL_0169;
										case 61:
											goto IL_01cb;
										case 60:
											goto end_IL_01cf;
										}
										num5 = 0;
										goto IL_017a;
										IL_01a3:
										num6 = 10;
										break;
										IL_0177:
										num5 = 3;
										goto IL_017a;
										IL_0181:
										num6 = 11;
										num7 = 8;
										continue;
										IL_01cb:
										num4 = 10;
										goto end_IL_01bc;
										IL_00dd:
										switch (num3)
										{
										case -51:
											break;
										case -52:
											goto IL_0154;
										case -50:
											goto IL_0166;
										default:
											goto IL_01c5;
										case -49:
											goto end_IL_01d8;
										}
										switch (num2)
										{
										case -58:
											goto IL_0119;
										case -55:
											goto IL_014f;
										case -56:
											goto IL_01f0;
										case -57:
											goto end_IL_01f3;
										}
										num3 = -2;
										goto IL_0169;
										IL_01c5:
										num4 = 11;
										goto end_IL_01bc;
										IL_0166:
										num3 = -4;
										goto IL_0169;
										IL_0070:
										num7 = 15;
										continue;
										IL_01f0:
										num2 = -7;
										goto end_IL_01d8;
										IL_0119:
										switch (num)
										{
										case -56:
											break;
										case -54:
											goto IL_0141;
										default:
											goto IL_01e6;
										case -55:
										case -53:
											return result;
										}
										num = Class8.smethod_0(41);
										goto IL_014f;
										IL_01e6:
										num2 = GEventArgs2.smethod_0(49);
										goto end_IL_01d8;
										IL_0141:
										result = Delegate12.smethod_0(class4_1);
										num = -4;
										goto IL_014f;
										IL_005f:
										num7 = 14;
										num8 = -27;
										num8 = -44;
										continue;
										IL_014f:
										num ^= 0x35;
										goto IL_0154;
										IL_0154:
										num2 = GEventArgs2.smethod_0(46);
										num3 = Class8.smethod_0(41);
										goto IL_0169;
										IL_017a:
										num5 ^= 0x39;
										goto IL_0181;
										continue;
										end_IL_0188:
										break;
									}
									continue;
									end_IL_01a7:
									break;
								}
								continue;
								end_IL_01bc:
								break;
							}
							continue;
							end_IL_01cf:
							break;
						}
						continue;
						end_IL_01d8:
						break;
					}
					continue;
					end_IL_01f3:
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
				int num = 123;
				int num2 = -3;
				while (true)
				{
					num2 ^= 0x3A;
					while (true)
					{
						int num3 = GEventArgs2.smethod_1(63);
						int num4 = 2;
						while (true)
						{
							num4 ^= 0x42;
							while (true)
							{
								int num5 = Class55.smethod_1(69);
								int num6 = 0;
								while (true)
								{
									num6 ^= 0x3F;
									while (true)
									{
										int num7 = Class8.smethod_0(48);
										int num8 = -11;
										while (true)
										{
											num8 ^= 0x3D;
											int num9 = 126;
											int num10 = -118;
											num10 = -64;
											while (true)
											{
												IL_01ed:
												num9 ^= 0x3A;
												while (true)
												{
													num10 = GEventArgs2.smethod_0(40);
													while (true)
													{
														switch (num10 ^ 0x4A)
														{
														case -67:
															num10 = GEventArgs2.smethod_0(46);
															continue;
														case -65:
															goto end_IL_0030;
														case -66:
															goto IL_005d;
														case -64:
															goto IL_01ed;
														}
														break;
													}
													continue;
													end_IL_0030:
													break;
												}
												switch (num9)
												{
												case 67:
													goto IL_006e;
												case 68:
													goto IL_0077;
												case 69:
													goto IL_01e0;
												case 70:
													goto end_IL_01ed;
												}
												num10 = -12;
												num10 = -66;
												goto IL_005d;
												IL_01cc:
												num6 = 3;
												num7 = -11;
												goto IL_01d9;
												IL_01e0:
												num8 = GEventArgs2.smethod_0(43);
												num9 = 124;
												continue;
												IL_0077:
												switch (num8)
												{
												case -59:
													goto IL_009a;
												case -56:
													goto IL_01d9;
												case -58:
													goto IL_01ff;
												case -57:
													goto end_IL_0208;
												}
												num9 = 127;
												continue;
												IL_01ff:
												num8 = Class8.smethod_0(47);
												break;
												IL_009a:
												switch (num7)
												{
												case -58:
													break;
												case -57:
													goto IL_01cc;
												case -56:
													goto IL_01d5;
												default:
													goto IL_01f9;
												case -55:
													goto end_IL_021d;
												}
												switch (num6)
												{
												case 60:
													goto IL_00e1;
												case 63:
													goto IL_01c5;
												case 62:
													goto IL_0231;
												case 61:
													goto end_IL_0234;
												}
												num7 = Class8.smethod_0(47);
												goto IL_01d9;
												IL_01f9:
												num8 = -6;
												break;
												IL_01d5:
												num7 = -12;
												goto IL_01d9;
												IL_01d9:
												num7 ^= 0x3C;
												goto IL_01e0;
												IL_0231:
												num6 = 1;
												goto end_IL_021d;
												IL_00e1:
												switch (num5)
												{
												case -60:
													break;
												case -59:
													goto IL_010e;
												case -58:
													goto IL_01bd;
												default:
													goto IL_022c;
												case -57:
													goto end_IL_023d;
												}
												num5 = Class55.smethod_1(65);
												goto IL_01c5;
												IL_022c:
												num6 = 2;
												goto end_IL_021d;
												IL_010e:
												switch (num4)
												{
												case 62:
													goto IL_0131;
												case 64:
													goto IL_01b8;
												case 61:
													goto IL_024b;
												case 63:
													goto end_IL_0255;
												}
												num5 = -121;
												goto IL_01c5;
												IL_024b:
												num4 = 127;
												goto end_IL_023d;
												IL_0131:
												switch (num3)
												{
												case -60:
													break;
												case -58:
													goto IL_0154;
												case -59:
													goto IL_01a8;
												default:
													goto IL_0251;
												case -57:
													goto end_IL_025e;
												}
												num3 = -124;
												goto IL_01b8;
												IL_0251:
												num4 = 125;
												goto end_IL_023d;
												IL_0154:
												switch (num2)
												{
												case -60:
													goto IL_0172;
												case -57:
													goto IL_01a3;
												case -58:
													goto IL_026f;
												case -59:
													goto end_IL_0272;
												}
												num3 = -123;
												goto IL_01b8;
												IL_026f:
												num2 = -4;
												goto end_IL_025e;
												IL_0172:
												switch (num)
												{
												case 69:
													break;
												case 71:
													goto IL_0195;
												default:
													goto IL_026b;
												case 70:
												case 72:
													return result;
												}
												num = 121;
												goto IL_01a3;
												IL_026b:
												num2 = -1;
												goto end_IL_025e;
												IL_0195:
												result = Delegate13.smethod_0(class4_2);
												num = 122;
												goto IL_01a3;
												IL_005d:
												num9 = 126;
												num10 = -118;
												num10 = -64;
												continue;
												IL_01a3:
												num ^= 0x3C;
												goto IL_01a8;
												IL_01a8:
												num2 = Class8.smethod_0(42);
												num3 = GEventArgs2.smethod_1(60);
												goto IL_01b8;
												IL_01c5:
												num5 ^= 0x41;
												goto IL_01cc;
												IL_006e:
												num9 = 121;
												continue;
												IL_01b8:
												num3 ^= 0x40;
												goto IL_01bd;
												IL_01bd:
												num4 = 124;
												num5 = -122;
												goto IL_01c5;
												continue;
												end_IL_01ed:
												break;
											}
											continue;
											end_IL_0208:
											break;
										}
										continue;
										end_IL_021d:
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
							end_IL_0255:
							break;
						}
						continue;
						end_IL_025e:
						break;
					}
					continue;
					end_IL_0272:
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
				int num = Class8.smethod_0(41);
				int num2 = -15;
				while (true)
				{
					num2 ^= 0x45;
					while (true)
					{
						int num3 = 4;
						int num4 = -11;
						while (true)
						{
							num4 ^= 0x4A;
							while (true)
							{
								int num5 = 5;
								int num6 = -13;
								while (true)
								{
									num6 ^= 0x4D;
									while (true)
									{
										int num7 = 0;
										int num8 = 28;
										while (true)
										{
											num8 ^= 0x4C;
											int num9 = 2;
											int num10 = -1;
											num10 = -74;
											while (true)
											{
												IL_01d8:
												num9 ^= 0x4A;
												while (true)
												{
													num10 = Class8.smethod_0(41);
													switch (num10 ^ 0x49)
													{
													case -76:
														goto end_IL_0007;
													case -77:
														goto IL_0055;
													case -74:
														goto IL_01d8;
													case -75:
														while (true)
														{
															num10 = -4;
															num10 = -75;
														}
													}
													continue;
													end_IL_0007:
													break;
												}
												switch (num9)
												{
												case 71:
													goto IL_0064;
												case 72:
													goto IL_006d;
												case 70:
													goto IL_01d2;
												case 73:
													goto end_IL_01d8;
												}
												num10 = -6;
												num10 = -77;
												goto IL_0055;
												IL_01cb:
												num7 ^= 0x45;
												goto IL_01d2;
												IL_01b8:
												num5 ^= 0x46;
												goto IL_01bf;
												IL_006d:
												switch (num8)
												{
												case 77:
													goto IL_0090;
												case 80:
													goto IL_01cb;
												case 79:
													goto IL_01e9;
												case 78:
													goto end_IL_01ec;
												}
												num9 = 12;
												continue;
												IL_01e9:
												num8 = 3;
												break;
												IL_0090:
												switch (num7)
												{
												case 68:
													break;
												case 69:
													goto IL_00b7;
												case 67:
													goto IL_01bf;
												default:
													goto IL_01e4;
												case 70:
													goto end_IL_01ff;
												}
												num7 = 1;
												goto IL_01cb;
												IL_01e4:
												num8 = 2;
												break;
												IL_00b7:
												switch (num6)
												{
												case -69:
													goto IL_00d9;
												case -66:
													goto IL_01b8;
												case -68:
													goto IL_0213;
												case -67:
													goto end_IL_0217;
												}
												num7 = 6;
												goto IL_01cb;
												IL_0213:
												num6 = -15;
												goto end_IL_01ff;
												IL_00d9:
												switch (num5)
												{
												case 67:
													break;
												case 68:
													goto IL_01a7;
												case 69:
													goto IL_01ac;
												default:
													goto IL_0208;
												case 70:
													goto end_IL_0220;
												}
												switch (num4)
												{
												case -66:
													goto IL_011a;
												case -65:
													goto IL_01a0;
												case -67:
													goto IL_0229;
												case -68:
													goto end_IL_0238;
												}
												num5 = 3;
												goto IL_01b8;
												IL_0208:
												num6 = Class8.smethod_0(37);
												goto end_IL_01ff;
												IL_01a7:
												num5 = 2;
												goto IL_01b8;
												IL_01d2:
												num8 = 1;
												num9 = 3;
												continue;
												IL_0229:
												num4 = GEventArgs2.smethod_0(46);
												goto end_IL_0220;
												IL_011a:
												switch (num3)
												{
												case 73:
													break;
												case 74:
													goto IL_0192;
												case 75:
													goto IL_0196;
												default:
													goto IL_0234;
												case 76:
													goto end_IL_0241;
												}
												switch (num2)
												{
												case -77:
													goto IL_0155;
												case -76:
													goto IL_018b;
												case -78:
													goto IL_0249;
												case -79:
													goto end_IL_0251;
												}
												num3 = 6;
												goto IL_01a0;
												IL_0234:
												num4 = -10;
												goto end_IL_0220;
												IL_0192:
												num3 = 7;
												goto IL_01a0;
												IL_0064:
												num9 = 13;
												continue;
												IL_0249:
												num2 = -9;
												goto end_IL_0241;
												IL_0155:
												switch (num)
												{
												case -75:
													break;
												case -74:
													goto IL_0178;
												default:
													goto IL_024e;
												case -73:
												case -72:
													return result;
												}
												num = -2;
												goto IL_018b;
												IL_024e:
												num2 = -12;
												goto end_IL_0241;
												IL_0178:
												result = Delegate14.smethod_0(class4_3);
												num = Class8.smethod_0(38);
												goto IL_018b;
												IL_0055:
												num9 = 2;
												num10 = -1;
												num10 = -74;
												continue;
												IL_018b:
												num ^= 0x4B;
												goto IL_0196;
												IL_0196:
												num2 = GEventArgs2.smethod_0(49);
												num3 = 1;
												goto IL_01a0;
												IL_01bf:
												num6 = GEventArgs2.smethod_0(49);
												num7 = 3;
												goto IL_01cb;
												IL_01a0:
												num3 ^= 0x4D;
												goto IL_01ac;
												IL_01ac:
												num4 = Class55.smethod_1(71);
												num5 = 0;
												goto IL_01b8;
												continue;
												end_IL_01d8:
												break;
											}
											continue;
											end_IL_01ec:
											break;
										}
										continue;
										end_IL_01ff:
										break;
									}
									continue;
									end_IL_0217:
									break;
								}
								continue;
								end_IL_0220:
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
					end_IL_0251:
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
				int num = Class8.smethod_0(57);
				int num2 = 8;
				while (true)
				{
					num2 ^= 0x4F;
					while (true)
					{
						int num3 = Class8.smethod_0(38);
						int num4 = 3;
						while (true)
						{
							num4 ^= 0x45;
							while (true)
							{
								int num5 = 6;
								int num6 = Class8.smethod_0(48);
								while (true)
								{
									num6 ^= 0x47;
									while (true)
									{
										int num7 = Class8.smethod_0(57);
										int num8 = Class8.smethod_0(38);
										while (true)
										{
											num8 ^= 0x47;
											int num9 = Class55.smethod_1(72);
											int num10 = -4;
											num10 = -75;
											while (true)
											{
												IL_01e4:
												num9 ^= 0x4B;
												while (true)
												{
													num10 = Class8.smethod_0(48);
													switch (num10 ^ 0x49)
													{
													case -77:
														goto end_IL_0007;
													case -78:
														goto IL_0055;
													case -75:
														goto IL_01e4;
													case -76:
														while (true)
														{
															num10 = -3;
															num10 = -76;
														}
													}
													continue;
													end_IL_0007:
													break;
												}
												switch (num9)
												{
												case -71:
													goto IL_006b;
												case -70:
													goto IL_0074;
												case -72:
													goto IL_01d7;
												case -69:
													goto end_IL_01e4;
												}
												num10 = -5;
												num10 = -78;
												goto IL_0055;
												IL_01b1:
												num4 = 1;
												num5 = 3;
												goto IL_01b7;
												IL_01be:
												num6 = Class8.smethod_0(47);
												num7 = -1;
												goto IL_01d0;
												IL_0074:
												switch (num8)
												{
												case -70:
													goto IL_0097;
												case -69:
													goto IL_01d0;
												case -71:
													goto IL_01f0;
												case -72:
													goto end_IL_01f9;
												}
												num9 = -13;
												continue;
												IL_01f0:
												num8 = -2;
												break;
												IL_0097:
												switch (num7)
												{
												case -77:
													break;
												case -78:
													goto IL_01be;
												case -76:
													goto IL_01cc;
												default:
													goto IL_01f6;
												case -75:
													goto end_IL_0213;
												}
												switch (num6)
												{
												case -68:
													goto IL_00de;
												case -67:
													goto IL_01b7;
												case -69:
													goto IL_0227;
												case -70:
													goto end_IL_0231;
												}
												num7 = GEventArgs2.smethod_0(43);
												goto IL_01d0;
												IL_01f6:
												num8 = -1;
												break;
												IL_01cc:
												num7 = -2;
												goto IL_01d0;
												IL_01d0:
												num7 ^= 0x4A;
												goto IL_01d7;
												IL_0227:
												num6 = -4;
												goto end_IL_0213;
												IL_00de:
												switch (num5)
												{
												case 75:
													break;
												case 76:
													goto IL_01ac;
												case 77:
													goto IL_01b1;
												default:
													goto IL_022d;
												case 78:
													goto end_IL_023a;
												}
												switch (num4)
												{
												case 68:
													goto IL_011f;
												case 70:
													goto IL_01a5;
												case 69:
													goto IL_024d;
												case 67:
													goto end_IL_0250;
												}
												num5 = 0;
												goto IL_01b7;
												IL_022d:
												num6 = -3;
												goto end_IL_0213;
												IL_01ac:
												num5 = 1;
												goto IL_01b7;
												IL_01d7:
												num8 = Class8.smethod_0(41);
												num9 = -16;
												continue;
												IL_024d:
												num4 = 0;
												goto end_IL_023a;
												IL_011f:
												switch (num3)
												{
												case -75:
													break;
												case -74:
													goto IL_0195;
												case -73:
													goto IL_019d;
												default:
													goto IL_0248;
												case -72:
													goto end_IL_0259;
												}
												switch (num2)
												{
												case 68:
													goto IL_015a;
												case 71:
													goto IL_0190;
												case 70:
													goto IL_026b;
												case 69:
													goto end_IL_026e;
												}
												num3 = -1;
												goto IL_01a5;
												IL_0248:
												num4 = 6;
												goto end_IL_023a;
												IL_019d:
												num3 = Class8.smethod_0(42);
												goto IL_01a5;
												IL_006b:
												num9 = -14;
												continue;
												IL_026b:
												num2 = 9;
												goto end_IL_0259;
												IL_015a:
												switch (num)
												{
												case -76:
													break;
												case -75:
													goto IL_0188;
												default:
													goto IL_0266;
												case -77:
												case -74:
													return result;
												}
												result = Delegate15.smethod_0(class4_4);
												num = -2;
												goto IL_0190;
												IL_0266:
												num2 = 10;
												goto end_IL_0259;
												IL_0188:
												num = GEventArgs2.smethod_0(43);
												goto IL_0190;
												IL_0055:
												num9 = Class55.smethod_1(72);
												num10 = -4;
												num10 = -75;
												continue;
												IL_0190:
												num ^= 0x4D;
												goto IL_0195;
												IL_0195:
												num2 = 11;
												num3 = -15;
												goto IL_01a5;
												IL_01b7:
												num5 ^= 0x4D;
												goto IL_01be;
												IL_01a5:
												num3 ^= 0x49;
												goto IL_01b1;
												continue;
												end_IL_01e4:
												break;
											}
											continue;
											end_IL_01f9:
											break;
										}
										continue;
										end_IL_0213:
										break;
									}
									continue;
									end_IL_0231:
									break;
								}
								continue;
								end_IL_023a:
								break;
							}
							continue;
							end_IL_0250:
							break;
						}
						continue;
						end_IL_0259:
						break;
					}
					continue;
					end_IL_026e:
					break;
				}
			}
		}
	}

	static Class1()
	{
		while (true)
		{
			int num = GEventArgs2.smethod_0(44);
			int num2 = 5;
			while (true)
			{
				num2 ^= 0x2C;
				while (true)
				{
					int num3 = 4;
					int num4 = -7;
					while (true)
					{
						num4 ^= 0x2F;
						while (true)
						{
							int num5 = 4;
							int num6 = 27;
							while (true)
							{
								num6 ^= 0x2B;
								while (true)
								{
									int num7 = Class8.smethod_0(42);
									int num8 = -2;
									while (true)
									{
										num8 ^= 0x2B;
										int num9 = Class8.smethod_0(42);
										while (true)
										{
											switch (num9 ^ 0x2A)
											{
											case -44:
												break;
											default:
												num9 = Class8.smethod_0(42);
												continue;
											case -42:
												num8 = Class8.smethod_0(39);
												num9 = -3;
												num9 = -41;
												goto end_IL_003d;
											case -41:
												goto end_IL_003d;
											case -43:
												while (true)
												{
													num9 = -1;
													num9 = -43;
												}
											}
											switch (num8)
											{
											case -45:
												goto IL_0060;
											case -44:
												goto IL_0069;
											case -43:
												goto IL_01d4;
											case -46:
												goto end_IL_01ff;
											}
											num9 = Class8.smethod_0(38);
											continue;
											IL_0060:
											num8 = -8;
											break;
											continue;
											end_IL_003d:
											break;
										}
										continue;
										IL_01b3:
										num4 = Class8.smethod_0(48);
										num5 = 26;
										goto IL_01bf;
										IL_0069:
										switch (num7)
										{
										case -42:
											goto IL_008c;
										case -41:
											goto IL_01c8;
										case -40:
											goto IL_01cd;
										case -39:
											goto end_IL_0214;
										}
										num8 = -7;
										continue;
										IL_01c8:
										num7 = -1;
										goto IL_01d4;
										IL_008c:
										switch (num6)
										{
										case 47:
											goto IL_00b4;
										case 48:
											goto IL_01bf;
										case 45:
											goto IL_0223;
										case 46:
											goto end_IL_022b;
										}
										num7 = Class8.smethod_0(37);
										goto IL_01d4;
										IL_0223:
										num6 = 6;
										goto end_IL_0214;
										IL_00b4:
										switch (num5)
										{
										case 45:
											break;
										case 46:
											goto IL_00db;
										case 47:
											goto IL_01b3;
										default:
											goto IL_0228;
										case 48:
											goto end_IL_0234;
										}
										num5 = 7;
										goto IL_01bf;
										IL_0228:
										num6 = 5;
										goto end_IL_0214;
										IL_00db:
										switch (num4)
										{
										case -43:
											goto IL_00fc;
										case -42:
											goto IL_01ae;
										case -45:
											goto IL_023d;
										case -44:
											goto end_IL_024a;
										}
										num5 = 5;
										goto IL_01bf;
										IL_023d:
										num4 = Class8.smethod_0(38);
										goto end_IL_0234;
										IL_00fc:
										switch (num3)
										{
										case 42:
											break;
										case 43:
											goto IL_01a6;
										case 44:
											goto IL_01ac;
										default:
											goto IL_0247;
										case 45:
											goto end_IL_0251;
										}
										switch (num2)
										{
										case 40:
											goto IL_0137;
										case 41:
											goto IL_01a1;
										case 39:
											goto IL_0258;
										case 38:
											goto end_IL_0260;
										}
										num3 = 5;
										goto IL_01ae;
										IL_0247:
										num4 = -5;
										goto end_IL_0234;
										IL_01ac:
										num3 = 2;
										goto IL_01ae;
										IL_01bf:
										num5 ^= 0x2A;
										goto IL_01cd;
										IL_0258:
										num2 = 11;
										goto end_IL_0251;
										IL_0137:
										switch (num)
										{
										case -38:
											break;
										case -37:
											goto IL_016c;
										case -36:
											goto IL_0171;
										case -35:
											goto IL_0180;
										case -34:
											goto IL_0194;
										default:
											goto IL_025d;
										case -33:
											return;
										}
										class4_1 = Delegate7.smethod_0();
										num = -12;
										goto IL_01a1;
										IL_025d:
										num2 = 10;
										goto end_IL_0251;
										IL_0194:
										class4_4 = Delegate10.smethod_0();
										num = -9;
										goto IL_01a1;
										IL_0180:
										class4_3 = Delegate9.smethod_0();
										num = GEventArgs2.smethod_0(49);
										goto IL_01a1;
										IL_0171:
										class4_2 = Delegate8.smethod_0();
										num = -11;
										goto IL_01a1;
										IL_016c:
										num = -13;
										goto IL_01a1;
										IL_01cd:
										num6 = 4;
										num7 = -15;
										goto IL_01d4;
										IL_01a1:
										num ^= 0x28;
										goto IL_01a6;
										IL_01a6:
										num2 = 4;
										num3 = 3;
										goto IL_01ae;
										IL_01d4:
										num7 ^= 0x28;
										num8 = Class8.smethod_0(39);
										num9 = -3;
										num9 = -41;
										continue;
										IL_01ae:
										num3 ^= 0x2E;
										goto IL_01b3;
										continue;
										end_IL_01ff:
										break;
									}
									continue;
									end_IL_0214:
									break;
								}
								continue;
								end_IL_022b:
								break;
							}
							continue;
							end_IL_0234:
							break;
						}
						continue;
						end_IL_024a:
						break;
					}
					continue;
					end_IL_0251:
					break;
				}
				continue;
				end_IL_0260:
				break;
			}
		}
	}
}
