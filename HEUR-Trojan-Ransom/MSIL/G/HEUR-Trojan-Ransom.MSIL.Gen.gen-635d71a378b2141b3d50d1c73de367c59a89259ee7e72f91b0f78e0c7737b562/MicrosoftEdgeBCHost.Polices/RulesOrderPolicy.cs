using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RulesOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceList()
	{
	}
}
