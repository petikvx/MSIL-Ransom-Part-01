using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ResolverRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceProxy()
	{
	}
}
