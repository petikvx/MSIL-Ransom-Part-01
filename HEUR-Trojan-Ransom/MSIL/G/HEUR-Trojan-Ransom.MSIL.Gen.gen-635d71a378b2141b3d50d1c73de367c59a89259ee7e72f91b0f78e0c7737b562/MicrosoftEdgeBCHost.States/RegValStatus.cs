using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RegValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralDefinition()
	{
	}
}
