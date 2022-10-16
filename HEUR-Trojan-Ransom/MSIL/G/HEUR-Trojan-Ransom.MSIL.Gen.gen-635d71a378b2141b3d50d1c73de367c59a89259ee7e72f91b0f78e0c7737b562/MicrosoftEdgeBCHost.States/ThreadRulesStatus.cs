using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ThreadRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceMap()
	{
	}
}
