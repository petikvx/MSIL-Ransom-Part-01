using System;
using System.IO;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Polices;
using MicrosoftEdgeBCHost.Producers;
using MicrosoftEdgeBCHost.Watchers;

namespace MicrosoftEdgeBCHost.Common;

internal class Authentication
{
	private static readonly object _Rules;

	private static readonly int m_Filter;

	private static readonly int _Val;

	private static readonly object m_Order;

	private static readonly object adapter;

	private static readonly byte _Property;

	private static object ResolveConnection;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static unsafe Authentication()
	{
		WriterPropertyProducer.ResolveStub();
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
				{
					int num8 = StateManager.CountMethod(-3221225472.0 - -1073741824.0, StateManager.ListMethod);
					num2 = 9;
					continue;
				}
				case 1:
					GlobalPropertyPolicy.InvokeLiteralProc();
					num2 = 5;
					if (true)
					{
						num2 = 5;
					}
					continue;
				case 11:
					return;
				case 3:
					ComputeConnection();
					num2 = 2;
					if (1 == 0)
					{
						num2 = 2;
					}
					continue;
				case 10:
					adapter = Global.m_Context;
					num2 = 3;
					if (true)
					{
						num2 = 7;
					}
					continue;
				case 7:
				{
					int num9 = StateManager.CountMethod(2147483649.329698 + DicManager.CountMethod(1073741823.5, DicManager.CalculateMethod), StateManager.ListMethod);
					num2 = 4;
					continue;
				}
				case 13:
				{
					int num4 = CreateConnection();
					num2 = 6;
					if (true)
					{
						continue;
					}
					break;
				}
				case 14:
					_Rules = new object();
					num2 = 11;
					continue;
				case 2:
					ChangeConnection();
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				case 8:
				{
					int num5 = InsertConnection();
					num2 = 12;
					continue;
				}
				case 5:
					m_Order = Global.m_Context;
					num2 = 5;
					if (true)
					{
						num2 = 10;
					}
					continue;
				case 4:
				{
					int num10 = StateManager.CountMethod(2147483652.0309 - DicManager.CountMethod(1073741821.5, DicManager.RunMethod), StateManager.ListMethod);
					if ((StateManager.CountMethod(2052358476.9887767 + DicManager.CountMethod(1026179243.0, DicManager.RunMethod), StateManager.ListMethod) ^ StateManager.CountMethod(675197406.0 + 675197406.0, StateManager.ListMethod)) == StateManager.CountMethod(707388138.8870827 + DicManager.CountMethod(353694069.0, DicManager.FlushMethod), StateManager.ListMethod))
					{
						int num9 = StateManager.CountMethod(2.0 - DicManager.CountMethod(1.0, DicManager.SortMethod), StateManager.ListMethod);
						num10 += sizeof(float);
					}
					m_Filter = num10;
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				}
				case 9:
				{
					int num7 = StateManager.CountMethod(3221225466.0 - DicManager.CountMethod(1073741822.0, DicManager.VisitMethod), StateManager.ListMethod);
					if ((StateManager.CountMethod(2.0 * 236964819.5, StateManager.ListMethod) ^ StateManager.CountMethod(1935952668.4319527 + DicManager.CountMethod(967991890.5, DicManager.CallMethod), StateManager.ListMethod)) == StateManager.CountMethod(1868256022.655124 - DicManager.CountMethod(934128001.0, DicManager.SortMethod), StateManager.ListMethod))
					{
						int num8 = StateManager.CountMethod(1.0 + DicManager.CountMethod(1.0, DicManager.SetMethod), StateManager.ListMethod);
						num7 += sizeof(float);
					}
					_Val = num7;
					num2 = 8;
					continue;
				}
				case 12:
				{
					int num6 = ManageConnection() ^ RateConnection();
					if ((_003CModule_003E.Invoke() ^ ExcludeConnection() ^ StateManager.CountMethod(334509997.0 - DicManager.CountMethod(111503332.5, DicManager.ForgotMethod), StateManager.ListMethod)) == StateManager.CountMethod(516124440.0 + DicManager.CountMethod(516124439.5, DicManager.VerifyMethod), StateManager.ListMethod))
					{
						int num5 = StateManager.CountMethod(0.4425922753450977 + DicManager.CountMethod(1.0, DicManager.CalculateMethod), StateManager.ListMethod);
						num6 += sizeof(float);
					}
					m_Order = new MemoryStream(num6);
					num2 = 13;
					continue;
				}
				case 6:
				{
					int num3 = StateManager.CountMethod(-6.0 - -2.0, StateManager.ListMethod);
					if ((StateManager.CountMethod(550852647.0 - DicManager.CountMethod(183617549.0, DicManager.VerifyMethod), StateManager.ListMethod) ^ StateManager.CountMethod(932191821.4954782 + DicManager.CountMethod(466106705.5, DicManager.CallMethod), StateManager.ListMethod)) == StateManager.CountMethod(578020033.460913 - DicManager.CountMethod(289010012.5, DicManager.RunMethod), StateManager.ListMethod))
					{
						int num4 = InstantiateConnection() ^ InterruptConnection();
						num3 += sizeof(float);
					}
					adapter = new MemoryStream(num3);
					num2 = 14;
					continue;
				}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Authentication()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string ViewStub(object task)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] ComputeStub(object task)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] PatchStub(object setup)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] InstantiateStub(long v_ID, object visitor)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] GetStub(long offset_param, object map)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeConnection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeConnection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int InsertConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ManageConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RateConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ExcludeConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CreateConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int InstantiateConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int InterruptConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SetupConnection()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Authentication LogoutConnection()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderConnection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CountConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MapConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RemoveConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CalcConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SelectConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DefineConnection()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int StartConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int EnableConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ReadConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RegisterConnection()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PrintConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int InvokeConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DisableConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int LoginConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PublishConnection(long offset_param, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DestroyConnection(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object InitConnection(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PushConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ReflectConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CancelConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MoveConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int UpdateConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DeleteConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GetConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AssetConnection(int initLow)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FillConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ValidateConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ListConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RunConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SortConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int VerifyConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FlushConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ResetConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UIntPtr CalculateConnection(object P_0)
	{
		return (UIntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SetConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PopConnection(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PrepareConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CallConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CheckConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ForgotConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int TestConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CompareConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int VisitConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ViewConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SearchConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ConnectConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int QueryConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AddConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CustomizeConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PostConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FindConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RevertConnection()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ConcatServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CollectServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int IncludeServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CloneServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int StopServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int NewServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PatchServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RestartServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AwakeServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WriteServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ResolveServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SetupServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int LogoutServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ComputeServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ChangeServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int InsertServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ManageServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RateServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ExcludeServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CreateServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int InstantiateServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int InterruptServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CountServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RemoveServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CalcServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SelectServer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DefineServer()
	{
		return 0;
	}
}
