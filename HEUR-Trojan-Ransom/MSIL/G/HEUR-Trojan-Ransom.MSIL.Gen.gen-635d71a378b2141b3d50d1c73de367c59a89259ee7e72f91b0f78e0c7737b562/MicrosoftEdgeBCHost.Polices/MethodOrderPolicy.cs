using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MethodOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralQueue()
	{
	}
}
