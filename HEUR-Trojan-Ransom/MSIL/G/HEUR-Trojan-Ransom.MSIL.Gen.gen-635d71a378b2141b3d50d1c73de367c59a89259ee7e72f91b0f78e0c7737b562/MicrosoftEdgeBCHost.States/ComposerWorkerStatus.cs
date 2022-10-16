using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.States;

internal class ComposerWorkerStatus
{
	internal static ModuleHandle _WorkerAuthentication;

	internal static object ConnectLiteralMerchant;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle DisableLiteralProc(int token)
	{
		//Discarded unreachable code: IL_0002
		return _WorkerAuthentication.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeFieldHandle LoginLiteralProc(int token)
	{
		//Discarded unreachable code: IL_0002
		return _WorkerAuthentication.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ComposerWorkerStatus()
	{
	}//Discarded unreachable code: IL_0002


	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerWorkerStatus()
	{
		//Discarded unreachable code: IL_0002
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				_WorkerAuthentication = FindLiteralMerchant(((object[])PostLiteralMerchant(CustomizeLiteralMerchant(typeof(ComposerWorkerStatus).TypeHandle).Assembly))[0]);
				num2 = 0;
				if (0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QueryLiteralMerchant()
	{
		//Discarded unreachable code: IL_0002
		return ConnectLiteralMerchant == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ComposerWorkerStatus AddLiteralMerchant()
	{
		//Discarded unreachable code: IL_0002
		return (ComposerWorkerStatus)ConnectLiteralMerchant;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type CustomizeLiteralMerchant(RuntimeTypeHandle P_0)
	{
		//Discarded unreachable code: IL_0002
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PostLiteralMerchant(object P_0)
	{
		//Discarded unreachable code: IL_0002
		return ((Assembly)P_0).GetModules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ModuleHandle FindLiteralMerchant(object P_0)
	{
		//Discarded unreachable code: IL_0002
		return ((Module)P_0).ModuleHandle;
	}
}
