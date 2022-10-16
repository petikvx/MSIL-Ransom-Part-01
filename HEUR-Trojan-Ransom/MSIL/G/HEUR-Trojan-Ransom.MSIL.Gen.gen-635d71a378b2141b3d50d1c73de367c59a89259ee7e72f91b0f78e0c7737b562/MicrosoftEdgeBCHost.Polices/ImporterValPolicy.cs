using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ImporterValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeProc()
	{
	}
}
