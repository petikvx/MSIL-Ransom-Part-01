using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WrapperFilterPolicy
{
	internal static readonly object bridge;

	private static object CallWorker;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static unsafe WrapperFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		int num = 4;
		string text = default(string);
		byte[] array = default(byte[]);
		Stream stream = default(Stream);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					text = (string)QueryWorker();
					num = 11;
					break;
				case 11:
					array = ManagerManager.CountMethod(text, ManagerManager.RemoveMethod);
					num2 = 9;
					if (true)
					{
						continue;
					}
					break;
				default:
				{
					int num10 = ViewWorker();
					num2 = 8;
					continue;
				}
				case 4:
					CompareWorker();
					num2 = 3;
					continue;
				case 5:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 2:
					stream = PrototypeManager.CountMethod(GlobalManager.CountMethod(GlobalManager.CollectManager), text, PrototypeManager.IncludeManager);
					num = 15;
					break;
				case 3:
					WriterPropertyProducer.FindStub();
					num2 = 13;
					continue;
				case 12:
					return;
				case 13:
					VisitWorker();
					num2 = 0;
					if (0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
				{
					int num4 = StateManager.CountMethod(145.5 - 48.5, StateManager.ListMethod);
					num2 = 7;
					continue;
				}
				case 6:
				{
					int num5 = SearchWorker();
					num2 = 14;
					if (true)
					{
						continue;
					}
					break;
				}
				case 1:
					if (bridge != null)
					{
						return;
					}
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				case 8:
				{
					int num9 = StateManager.CountMethod(4.5 / -1.5, StateManager.ListMethod);
					if ((StateManager.CountMethod(1874008684.3457596 - DicManager.CountMethod(937004341.5, DicManager.CalculateMethod), StateManager.ListMethod) ^ StateManager.CountMethod(1398330402.0178125 + DicManager.CountMethod(699178422.0, DicManager.CallMethod), StateManager.ListMethod)) == StateManager.CountMethod(1021976838.5396389 + DicManager.CountMethod(510988419.5, DicManager.FlushMethod), StateManager.ListMethod))
					{
						int num10 = StateManager.CountMethod(1.0 + DicManager.CountMethod(1.0, DicManager.CheckMethod), StateManager.ListMethod);
						num9 += sizeof(float);
					}
					switch (num9)
					{
					case 0:
						break;
					default:
						goto IL_025f;
					}
					goto default;
				}
				case 14:
				{
					int num8 = ConnectWorker() ^ _003CModule_003E.get_AllowedCaller();
					if ((StateManager.CountMethod(1295987642.2780569 + DicManager.CountMethod(647993821.0, DicManager.FlushMethod), StateManager.ListMethod) ^ StateManager.CountMethod(1848766381.5 - DicManager.CountMethod(616255460.5, DicManager.CheckMethod), StateManager.ListMethod)) == StateManager.CountMethod(71937137.90972428 + DicManager.CountMethod(35968569.5, DicManager.CalculateMethod), StateManager.ListMethod))
					{
						int num5 = StateManager.CountMethod(2.0 / 1.0, StateManager.ListMethod);
						num8 += sizeof(float);
					}
					if (num8 == 0)
					{
						num2 = 5;
						if (true)
						{
							continue;
						}
						break;
					}
					goto case 10;
				}
				case 9:
				{
					Encoding encoding = MethodManager.CountMethod(MethodManager.MapMethod);
					byte[] array2 = array;
					int num6 = AddWorker();
					int num7 = StateManager.CountMethod(2.0 * -2.0, StateManager.ListMethod);
					if ((StateManager.CountMethod(910991797.0 + DicManager.CountMethod(910991797.0, DicManager.ForgotMethod), StateManager.ListMethod) ^ StateManager.CountMethod(1688427308.0 + DicManager.CountMethod(844213654.5, DicManager.ResetMethod), StateManager.ListMethod)) == StateManager.CountMethod(9525454591275480.0 / 69012515.5, StateManager.ListMethod))
					{
						num6 = StateManager.CountMethod(1.0 + 1.0, StateManager.ListMethod);
						num7 += sizeof(float);
					}
					text = MapperManager.CountMethod(encoding, array2, num7, array.Length, MapperManager.ConcatManager);
					num2 = 2;
					continue;
				}
				case 7:
					{
						int num3 = StateManager.CountMethod(94.0 - DicManager.CountMethod(46.5, DicManager.ResetMethod), StateManager.ListMethod);
						if ((StateManager.CountMethod(6.305869781683201E+17 / 561510008.0, StateManager.ListMethod) ^ StateManager.CountMethod(1067495545.0 - DicManager.CountMethod(355831848.5, DicManager.ForgotMethod), StateManager.ListMethod)) == StateManager.CountMethod(1753563211.2482343 - DicManager.CountMethod(876766800.5, DicManager.CallMethod), StateManager.ListMethod))
						{
							int num4 = StateManager.CountMethod(1.0 + DicManager.CountMethod(1.0, DicManager.CheckMethod), StateManager.ListMethod);
							num3 += sizeof(float);
						}
						bridge = CustomizeWorker(num3, stream);
						num2 = 12;
						continue;
					}
					IL_025f:
					num2 = 6;
					if (true)
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
	public WrapperFilterPolicy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string CallStub(int lastend)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareWorker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitWorker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ViewWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SearchWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ConnectWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QueryWorker()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AddWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CustomizeWorker(long v_ID, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckWorker()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WrapperFilterPolicy ForgotWorker()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostWorker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FindWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RevertWorker()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ConcatConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CollectConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int IncludeConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CloneConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int StopConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int NewConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PatchConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RestartConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AwakeConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WriteConnection()
	{
		return 0;
	}
}
