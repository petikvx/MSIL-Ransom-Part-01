using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PredicateFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralIssuer()
	{
	}
}
