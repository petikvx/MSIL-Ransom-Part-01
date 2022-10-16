using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Strategy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Strategy()
	{
		WriterPropertyProducer.ResolveStub();
		GetMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetMapping()
	{
	}
}
