using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace WinManipulate.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0 = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)Delegate24.smethod_0());

	private static bool bool_0;

	private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings MySettings_0
	{
		get
		{
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected O, but got Unknown
			if ((bool_0 ? 1 : 0) == Class84.smethod_0(0) || 1 == 0)
			{
				object obj = default(object);
				while (true)
				{
					int num = Class84.smethod_0(5);
					while (true)
					{
						switch (num ^ Class84.smethod_0(74))
						{
						case 77:
							num = 1;
							continue;
						case 76:
							ObjectFlowControl.CheckForSyncLockOnValueType(obj);
							num = 7;
							continue;
						case 75:
							num = 2;
							continue;
						case 74:
							obj = object_0;
							num = Class84.smethod_0(0);
							continue;
						case 78:
							goto end_IL_0067;
						}
						break;
					}
					continue;
					end_IL_0067:
					break;
				}
				bool lockTaken = (byte)Class84.smethod_0(0) != 0;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					bool flag = default(bool);
					while (true)
					{
						IL_00d9:
						int num2 = Class84.smethod_0(7);
						while (true)
						{
							switch (num2 ^ Class84.smethod_0(387))
							{
							case 76:
								flag = (bool_0 ? 1 : 0) == Class84.smethod_0(0);
								num2 = 2;
								continue;
							case 75:
								num2 = Class84.smethod_0(8);
								continue;
							case 74:
								if (flag)
								{
									num2 = 5;
									continue;
								}
								if (true)
								{
									goto end_IL_00ac;
								}
								goto case 77;
							case 73:
								num2 = 1;
								continue;
							case 77:
								((WindowsFormsApplicationBase)Delegate10.smethod_0()).add_Shutdown((ShutdownEventHandler)delegate
								{
									if (((WindowsFormsApplicationBase)Delegate10.smethod_0()).get_SaveMySettingsOnExit() || 1 == 0)
									{
										while (true)
										{
											int num4 = Class89.smethod_1(56);
											int num5 = 8;
											while (true)
											{
												num5 ^= Class84.smethod_0(386);
												while (true)
												{
													int num6 = Class84.smethod_0(20);
													while (true)
													{
														switch (num6 ^ Class84.smethod_0(16))
														{
														case 75:
															break;
														case 73:
															goto IL_007c;
														case 74:
															num6 = 10;
															continue;
														default:
															goto end_IL_0091;
														case 76:
															goto end_IL_00b4;
														}
														switch (num5)
														{
														case 77:
															goto IL_0038;
														case 79:
															goto IL_006f;
														case 78:
															goto IL_00c8;
														case 76:
															goto end_IL_00cb;
														}
														num6 = 9;
														continue;
														IL_006f:
														num4 ^= Class84.smethod_0(385);
														goto IL_007c;
														IL_00c8:
														num5 = 9;
														goto end_IL_00b4;
														IL_0038:
														switch (num4)
														{
														case -55:
															break;
														case -54:
															goto IL_0058;
														case -53:
															goto IL_0067;
														default:
															goto IL_00be;
														case -52:
															return;
														}
														num4 = -13;
														goto IL_006f;
														IL_00be:
														num5 = Class84.smethod_0(20);
														goto end_IL_00b4;
														IL_0067:
														num4 = Class46.Class47.smethod_0(76);
														goto IL_006f;
														IL_0058:
														((ApplicationSettingsBase)Delegate25.smethod_0()).Save();
														num4 = -15;
														goto IL_006f;
														IL_007c:
														num5 = Class84.smethod_0(80);
														num6 = Class84.smethod_0(31);
														continue;
														end_IL_0091:
														break;
													}
													continue;
													end_IL_00b4:
													break;
												}
												continue;
												end_IL_00cb:
												break;
											}
										}
									}
								});
								while (true)
								{
									IL_0147:
									int num3 = Class46.Class47.smethod_0(67);
									while (true)
									{
										switch (num3 ^ Class84.smethod_0(76))
										{
										case -58:
											num3 = -123;
											continue;
										case -59:
											num3 = -124;
											continue;
										case -60:
											bool_0 = (byte)Class84.smethod_0(1) != 0;
											num3 = Class46.Class47.smethod_0(73);
											continue;
										case -57:
											goto end_IL_0121;
										}
										goto IL_0147;
										continue;
										end_IL_0121:
										break;
									}
									break;
								}
								goto end_IL_00ac;
							}
							goto IL_00d9;
							continue;
							end_IL_00ac:
							break;
						}
						break;
					}
				}
				finally
				{
					if (lockTaken || 1 == 0)
					{
						Monitor.Exit(obj);
					}
				}
			}
			return mySettings_0;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void smethod_0(object sender, EventArgs e)
	{
		if ((!((WindowsFormsApplicationBase)Delegate10.smethod_0()).get_SaveMySettingsOnExit()) ? true : false)
		{
			return;
		}
		while (true)
		{
			int num = Class89.smethod_1(56);
			int num2 = 8;
			while (true)
			{
				num2 ^= Class84.smethod_0(386);
				while (true)
				{
					int num3 = Class84.smethod_0(20);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(16))
						{
						case 75:
							break;
						case 73:
							goto IL_007c;
						case 74:
							num3 = 10;
							continue;
						default:
							goto end_IL_0091;
						case 76:
							goto end_IL_00b4;
						}
						switch (num2)
						{
						case 77:
							goto IL_0038;
						case 79:
							goto IL_006f;
						case 78:
							goto IL_00c8;
						case 76:
							goto end_IL_00cb;
						}
						num3 = 9;
						continue;
						IL_006f:
						num ^= Class84.smethod_0(385);
						goto IL_007c;
						IL_00c8:
						num2 = 9;
						goto end_IL_00b4;
						IL_0038:
						switch (num)
						{
						case -55:
							break;
						case -54:
							goto IL_0058;
						case -53:
							goto IL_0067;
						default:
							goto IL_00be;
						case -52:
							return;
						}
						num = -13;
						goto IL_006f;
						IL_00be:
						num2 = Class84.smethod_0(20);
						goto end_IL_00b4;
						IL_0067:
						num = Class46.Class47.smethod_0(76);
						goto IL_006f;
						IL_0058:
						((ApplicationSettingsBase)Delegate25.smethod_0()).Save();
						num = -15;
						goto IL_006f;
						IL_007c:
						num2 = Class84.smethod_0(80);
						num3 = Class84.smethod_0(31);
						continue;
						end_IL_0091:
						break;
					}
					continue;
					end_IL_00b4:
					break;
				}
				continue;
				end_IL_00cb:
				break;
			}
		}
	}
}
