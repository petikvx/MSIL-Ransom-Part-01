using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SingletonRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceMapper()
	{
	}
}
