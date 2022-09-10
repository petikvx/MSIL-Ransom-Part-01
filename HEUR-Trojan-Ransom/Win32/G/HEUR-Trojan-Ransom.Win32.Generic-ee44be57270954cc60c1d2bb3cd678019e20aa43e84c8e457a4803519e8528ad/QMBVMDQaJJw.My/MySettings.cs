using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace QMBVMDQaJJw.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0 = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	private static bool bool_0;

	private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			bool flag = !bool_0;
			object obj = default(object);
			MySettings result = default(MySettings);
			while (true)
			{
				int num = 170060832;
				while (true)
				{
					int num7;
					uint num2;
					switch ((num2 = (uint)num ^ 0x40F1686Au) % 6u)
					{
					case 5u:
						num = ((int)num2 * -1490070419) ^ -315646967;
						continue;
					case 4u:
						obj = object_0;
						ObjectFlowControl.CheckForSyncLockOnValueType(obj);
						num = (int)((num2 * 1393691583) ^ 0x7B6F5B09);
						continue;
					case 3u:
						Monitor.Enter(obj);
						num = (int)(num2 * 2041270365) ^ -1717272024;
						continue;
					case 2u:
						if (flag)
						{
							num = (int)((num2 * 2124031659) ^ 0x5323F1E7);
							continue;
						}
						goto IL_01a8;
					case 0u:
						break;
					default:
						{
							try
							{
								bool flag2 = !bool_0;
								while (true)
								{
									IL_0112:
									int num3 = 261826687;
									while (true)
									{
										switch ((num2 = (uint)num3 ^ 0x40F1686Au) % 4u)
										{
										case 3u:
											((WindowsFormsApplicationBase)Class1.Form0_0).add_Shutdown((ShutdownEventHandler)delegate
											{
												bool saveMySettingsOnExit = default(bool);
												while (true)
												{
													int num8 = 1970606737;
													while (true)
													{
														uint num9;
														switch ((num9 = (uint)num8 ^ 0x5D60094Cu) % 7u)
														{
														case 5u:
															saveMySettingsOnExit = ((WindowsFormsApplicationBase)Class1.Form0_0).get_SaveMySettingsOnExit();
															num8 = ((int)num9 * -1977618777) ^ 0x241A0940;
															continue;
														case 4u:
														{
															int num10;
															int num11;
															if (!saveMySettingsOnExit)
															{
																num10 = -909490847;
																num11 = -909490847;
															}
															else
															{
																num10 = -1391658885;
																num11 = -1391658885;
															}
															num8 = num10 ^ ((int)num9 * -807339358);
															continue;
														}
														case 2u:
															num8 = ((int)num9 * -623673588) ^ 0x1524440B;
															continue;
														case 1u:
															num8 = 227877669;
															continue;
														case 0u:
															((ApplicationSettingsBase)Class6.MySettings_0).Save();
															num8 = (int)((num9 * 1360518456) ^ 0x19EAB18F);
															continue;
														default:
															return;
														case 6u:
															break;
														case 3u:
															return;
														}
														break;
													}
												}
											});
											bool_0 = true;
											num3 = ((int)num2 * -1406349342) ^ -184546334;
											continue;
										case 1u:
										{
											int num4;
											int num5;
											if (!flag2)
											{
												num4 = 697023148;
												num5 = 697023148;
											}
											else
											{
												num4 = 864570525;
												num5 = 864570525;
											}
											num3 = num4 ^ (int)(num2 * 288468416);
											continue;
										}
										default:
											goto end_IL_00f0;
										case 0u:
											break;
										case 2u:
											goto end_IL_00f0;
										}
										goto IL_0112;
										continue;
										end_IL_00f0:
										break;
									}
									break;
								}
							}
							finally
							{
								Monitor.Exit(obj);
								while (true)
								{
									IL_0163:
									int num6 = 2087532049;
									while (true)
									{
										switch ((num2 = (uint)num6 ^ 0x40F1686Au) % 4u)
										{
										case 3u:
											num6 = (int)((num2 * 1237369731) ^ 0x4162C21);
											continue;
										case 2u:
											num6 = ((int)num2 * -702998678) ^ 0x353EC3C7;
											continue;
										default:
											goto end_IL_0141;
										case 0u:
											break;
										case 1u:
											goto end_IL_0141;
										}
										goto IL_0163;
										continue;
										end_IL_0141:
										break;
									}
									break;
								}
							}
							goto IL_0181;
						}
						IL_01a8:
						num7 = 136979960;
						goto IL_0186;
						IL_0186:
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x40F1686Au) % 4u)
							{
							case 2u:
								result = mySettings_0;
								num7 = ((int)num2 * -1123623409) ^ 0x68646655;
								continue;
							case 0u:
								break;
							case 3u:
								goto IL_01a8;
							default:
								return result;
							}
							break;
						}
						goto IL_0181;
						IL_0181:
						num7 = 1081440357;
						goto IL_0186;
					}
					break;
				}
			}
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void smethod_0(object sender, EventArgs e)
	{
		bool saveMySettingsOnExit = default(bool);
		while (true)
		{
			int num = 1970606737;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5D60094Cu) % 7u)
				{
				case 5u:
					saveMySettingsOnExit = ((WindowsFormsApplicationBase)Class1.Form0_0).get_SaveMySettingsOnExit();
					num = ((int)num2 * -1977618777) ^ 0x241A0940;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!saveMySettingsOnExit)
					{
						num3 = -909490847;
						num4 = -909490847;
					}
					else
					{
						num3 = -1391658885;
						num4 = -1391658885;
					}
					num = num3 ^ ((int)num2 * -807339358);
					continue;
				}
				case 2u:
					num = ((int)num2 * -623673588) ^ 0x1524440B;
					continue;
				case 1u:
					num = 227877669;
					continue;
				case 0u:
					((ApplicationSettingsBase)Class6.MySettings_0).Save();
					num = (int)((num2 * 1360518456) ^ 0x19EAB18F);
					continue;
				default:
					return;
				case 6u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}
}
