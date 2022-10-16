using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal static class Stub
{
	private static List<string> wrapper;

	private static object InterruptWorker;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static unsafe Stub()
	{
		WriterPropertyProducer.ResolveStub();
		int num = 8;
		string[] array = default(string[]);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0017:
				int num7;
				switch (num2)
				{
				case 6:
					SelectWorker();
					num2 = 2;
					break;
				case 7:
					WriterPropertyProducer.QueryStub();
					num2 = 6;
					break;
				case 4:
					wrapper = new List<string>(array);
					num2 = 3;
					break;
				case 3:
					return;
				case 8:
					CalcWorker();
					num2 = 7;
					if (false)
					{
						num2 = 7;
					}
					break;
				case 1:
				{
					int privacyState = _003CModule_003E.get_PrivacyState();
					num2 = 5;
					break;
				}
				case 2:
					DefineWorker();
					num2 = 1;
					if (false)
					{
						num2 = 0;
					}
					break;
				case 5:
					num7 = StateManager.CountMethod(4.5 / -1.5, StateManager.ListMethod);
					if ((StateManager.CountMethod(2133792344.0281222 - DicManager.CountMethod(1066896167.5, DicManager.RunMethod), StateManager.ListMethod) ^ StateManager.CountMethod(1375126204.348664 - DicManager.CountMethod(687563092.0, DicManager.SortMethod), StateManager.ListMethod)) == StateManager.CountMethod(1179041626.0 - DicManager.CountMethod(393013875.5, DicManager.VerifyMethod), StateManager.ListMethod))
					{
						int privacyState = StateManager.CountMethod(2.5403023058681398 - DicManager.CountMethod(1.0, DicManager.FlushMethod), StateManager.ListMethod);
						num7 += sizeof(float);
					}
					goto IL_0192;
				default:
				{
					string[] array2 = array;
					int num3 = EnableWorker();
					int num4 = StateManager.CountMethod(2.0 * -2.0, StateManager.ListMethod);
					if ((StateManager.CountMethod(487121933.0 - DicManager.CountMethod(243560966.0, DicManager.ResetMethod), StateManager.ListMethod) ^ StateManager.CountMethod(1078385742.0 - DicManager.CountMethod(539192870.5, DicManager.ResetMethod), StateManager.ListMethod)) == StateManager.CountMethod(2.0 * 782703648.5, StateManager.ListMethod))
					{
						num3 = StateManager.CountMethod(0.4425922753450977 + DicManager.CountMethod(1.0, DicManager.CalculateMethod), StateManager.ListMethod);
						num4 += sizeof(float);
					}
					int num5 = ReadWorker() ^ RegisterWorker();
					int num6 = StateManager.CountMethod(60.0 - DicManager.CountMethod(20.0, DicManager.SetMethod), StateManager.ListMethod);
					if ((StateManager.CountMethod(112613755.76836003 - DicManager.CountMethod(56306878.0, DicManager.CalculateMethod), StateManager.ListMethod) ^ StateManager.CountMethod(1332968975.9417815 + DicManager.CountMethod(666484488.0, DicManager.FlushMethod), StateManager.ListMethod)) == StateManager.CountMethod(7.658979842455662E+17 / 618828726.0, StateManager.ListMethod))
					{
						num5 = StateManager.CountMethod(2.0 + DicManager.CountMethod(1.0, DicManager.SortMethod), StateManager.ListMethod);
						num6 += sizeof(float);
					}
					array2[num4] = (string)PrintWorker(num6);
					num2 = 4;
					if (false)
					{
						num2 = 0;
					}
					break;
				}
				}
				goto IL_0017;
				IL_0192:
				array = (string[])StartWorker(num7);
				num2 = 0;
			}
			while (true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static void CreateStub()
	{
		//Discarded unreachable code: IL_0002, IL_00ee, IL_00fd, IL_015b, IL_032e, IL_0345
		int num = 8;
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (_003CModule_003E.GetAssembliesFromDirectory >= (int)(nuint)MockFilterProducer.StopStub(_003CModule_003E.get_AvatarMedium))
					{
						num2 = 4;
						continue;
					}
					goto case 15;
				case 4:
					_003CModule_003E._invoke = StateManager.CountMethod(4.0 - DicManager.CountMethod(1.5, DicManager.SetMethod), StateManager.ListMethod);
					num2 = 2;
					continue;
				case 15:
					_003CModule_003E.get_StateMessage = _003CModule_003E.get_AvatarMedium[_003CModule_003E.GetAssembliesFromDirectory];
					num = 9;
					break;
				case 3:
					return;
				case 12:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					if (CountWorker())
					{
						continue;
					}
					break;
				case 7:
					_003CModule_003E.remove_OnRockedInitialized = StateManager.CountMethod(25.0 + DicManager.CountMethod(25.0, DicManager.VerifyMethod), StateManager.ListMethod);
					num2 = 10;
					continue;
				case 11:
					_003CModule_003E.get_AvatarMedium = wrapper.ToArray();
					num2 = 17;
					continue;
				case 14:
					_003CModule_003E.Register = _003CModule_003E.GetOpenWindows();
					num2 = 18;
					continue;
				case 1:
					_003CModule_003E.SaveGroup = _003CModule_003E.get_SteamID64();
					num2 = 6;
					continue;
				case 9:
					try
					{
						InsertStub(_003CModule_003E.get_StateMessage);
						int num5 = 2;
						while (true)
						{
							switch (num5)
							{
							case 2:
								_003CModule_003E.get_Location = StateManager.CountMethod(999.4707561352556 + DicManager.CountMethod(500.0, DicManager.CalculateMethod), StateManager.ListMethod);
								num5 = 0;
								if (RemoveWorker() == null)
								{
									num5 = 0;
								}
								continue;
							default:
							{
								int num6 = StateManager.CountMethod(498.0 + DicManager.CountMethod(498.0, DicManager.CheckMethod), StateManager.ListMethod);
								if ((StateManager.CountMethod(30276492184512800.0 / 123037580.0, StateManager.ListMethod) ^ StateManager.CountMethod(368423178.2070055 - DicManager.CountMethod(184204803.0, DicManager.CallMethod), StateManager.ListMethod)) == StateManager.CountMethod(459256605.9764557 - DicManager.CountMethod(229628303.0, DicManager.CalculateMethod), StateManager.ListMethod))
								{
									_003CModule_003E.get_Location = StateManager.CountMethod(3.0 - DicManager.CountMethod(1.0, DicManager.ForgotMethod), StateManager.ListMethod);
									num6 += sizeof(float);
								}
								ServerManager.CountMethod(num6, ServerManager.PrepareMethod);
								num5 = 1;
								if (RemoveWorker() != null)
								{
									num5 = num7;
								}
								continue;
							}
							case 1:
								break;
							}
							break;
						}
					}
					catch
					{
						int num8 = 0;
						if (RemoveWorker() != null)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 13;
				case 17:
					_003CModule_003E.set_TradeBanState = _003CModule_003E.GetPermissions();
					num = 16;
					break;
				case 8:
				case 19:
					if (VisitStub())
					{
						num2 = 14;
						if (CountWorker())
						{
							continue;
						}
						break;
					}
					goto case 7;
				case 10:
				{
					int num12 = StateManager.CountMethod(45.15377959582483 - DicManager.CountMethod(23.0, DicManager.PopMethod), StateManager.ListMethod);
					if ((StateManager.CountMethod(1533349749.8846111 - DicManager.CountMethod(766674870.5, DicManager.RunMethod), StateManager.ListMethod) ^ StateManager.CountMethod(1658877674.5829823 + DicManager.CountMethod(829438837.0, DicManager.PopMethod), StateManager.ListMethod)) == StateManager.CountMethod(965048710.4638762 - DicManager.CountMethod(482524355.5, DicManager.FlushMethod), StateManager.ListMethod))
					{
						_003CModule_003E.remove_OnRockedInitialized = StateManager.CountMethod(3.0 - 1.0, StateManager.ListMethod);
						num12 += sizeof(float);
					}
					ServerManager.CountMethod(num12, ServerManager.PrepareMethod);
					num2 = 19;
					continue;
				}
				case 18:
				{
					int num11 = StateManager.CountMethod(-1.5 + -1.5, StateManager.ListMethod);
					if ((StateManager.CountMethod(40177292192410480.0 / 141734421.0, StateManager.ListMethod) ^ StateManager.CountMethod(151778159.88017926 - DicManager.CountMethod(75889076.0, DicManager.RunMethod), StateManager.ListMethod)) == StateManager.CountMethod(435066689.38245976 + DicManager.CountMethod(217533345.0, DicManager.FlushMethod), StateManager.ListMethod))
					{
						_003CModule_003E.Register = StateManager.CountMethod(2.0 * 1.0, StateManager.ListMethod);
						num11 += sizeof(float);
					}
					switch (num11)
					{
					case 0:
						break;
					default:
						goto IL_0533;
					}
					goto case 14;
				}
				case 6:
				{
					int num10 = StateManager.CountMethod(-4.5 - -1.5, StateManager.ListMethod);
					if ((StateManager.CountMethod(2.0 * 1027770542.0, StateManager.ListMethod) ^ StateManager.CountMethod(1455892061.2750096 + DicManager.CountMethod(727959521.0, DicManager.CallMethod), StateManager.ListMethod)) == StateManager.CountMethod(371281743.0 + DicManager.CountMethod(371281743.0, DicManager.VerifyMethod), StateManager.ListMethod))
					{
						_003CModule_003E.SaveGroup = StateManager.CountMethod(3.0 - DicManager.CountMethod(1.0, DicManager.VerifyMethod), StateManager.ListMethod);
						num10 += sizeof(float);
					}
					if (num10 == 0)
					{
						num2 = 12;
						if (CountWorker())
						{
							continue;
						}
						break;
					}
					goto case 11;
				}
				case 16:
				{
					int num4 = StateManager.CountMethod(-6.0 - -2.0, StateManager.ListMethod);
					if ((StateManager.CountMethod(2.0 * 697997508.0, StateManager.ListMethod) ^ StateManager.CountMethod(519298812.0 - DicManager.CountMethod(173099604.0, DicManager.VerifyMethod), StateManager.ListMethod)) == StateManager.CountMethod(1801680816.0 - DicManager.CountMethod(600560272.0, DicManager.CheckMethod), StateManager.ListMethod))
					{
						_003CModule_003E.set_TradeBanState = StateManager.CountMethod(1.0 + 1.0, StateManager.ListMethod);
						num4 += sizeof(float);
					}
					_003CModule_003E.GetAssembliesFromDirectory = num4;
					num2 = 4;
					if (RemoveWorker() == null)
					{
						num2 = 5;
					}
					continue;
				}
				case 13:
				{
					int getAssembliesFromDirectory = _003CModule_003E.GetAssembliesFromDirectory;
					_003CModule_003E.QueueOnMainThread = _003CModule_003E.HasPermission();
					int num9 = StateManager.CountMethod(-4.5 - -1.5, StateManager.ListMethod);
					if ((StateManager.CountMethod(1703236491.8037117 + DicManager.CountMethod(851618245.5, DicManager.FlushMethod), StateManager.ListMethod) ^ StateManager.CountMethod(1631012520.0 - 543670840.0, StateManager.ListMethod)) == StateManager.CountMethod(625661947.9762245 + DicManager.CountMethod(312830973.5, DicManager.PopMethod), StateManager.ListMethod))
					{
						_003CModule_003E.QueueOnMainThread = StateManager.CountMethod(1.4596976941318602 + DicManager.CountMethod(1.0, DicManager.FlushMethod), StateManager.ListMethod);
						num9 += sizeof(float);
					}
					_003CModule_003E.GetAssembliesFromDirectory = getAssembliesFromDirectory + num9;
					num2 = 0;
					if (!CountWorker())
					{
						num2 = 0;
					}
					continue;
				}
				case 2:
					{
						int num3 = _003CModule_003E._invoke() ^ _003CModule_003E.Close();
						if ((StateManager.CountMethod(1703552959.0 - DicManager.CountMethod(851776479.0, DicManager.ResetMethod), StateManager.ListMethod) ^ StateManager.CountMethod(644092106.0 + DicManager.CountMethod(644092105.5, DicManager.VerifyMethod), StateManager.ListMethod)) == StateManager.CountMethod(692192812.3192039 - DicManager.CountMethod(346096406.5, DicManager.PopMethod), StateManager.ListMethod))
						{
							_003CModule_003E._invoke = StateManager.CountMethod(1.0 + DicManager.CountMethod(1.0, DicManager.CallMethod), StateManager.ListMethod);
							num3 += sizeof(float);
						}
						switch (num3)
						{
						case 0:
							break;
						default:
							num2 = 1;
							if (CountWorker())
							{
								num2 = 3;
							}
							continue;
						}
						goto case 4;
					}
					IL_0533:
					num2 = 1;
					if (RemoveWorker() == null)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool VisitStub()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void InsertStub(object init)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void AwakeStub(object setup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object SetupStub(object value, object selection, object proc)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static MethodInfo ValidateStub(object spec)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcWorker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectWorker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineWorker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object StartWorker(int config_length)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int EnableWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ReadWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RegisterWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PrintWorker(int lastend)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CountWorker()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Stub RemoveWorker()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int InvokeWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DisableWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int LoginWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PublishWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DestroyWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int InitWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PushWorker(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ReflectWorker(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CancelWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MoveWorker(int task_Ptr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UIntPtr UpdateWorker(object P_0)
	{
		return (UIntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DeleteWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AssetWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FillWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ValidateWorker(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RunWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SortWorker(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int VerifyWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FlushWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ResetWorker()
	{
		return 0;
	}
}
