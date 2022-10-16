using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReaderRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceIssuer()
	{
	}
}
