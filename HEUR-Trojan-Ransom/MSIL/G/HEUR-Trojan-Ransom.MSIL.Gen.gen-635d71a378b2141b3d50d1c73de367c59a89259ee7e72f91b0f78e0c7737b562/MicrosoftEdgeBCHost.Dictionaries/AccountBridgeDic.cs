using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AccountBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceServer()
	{
	}
}
