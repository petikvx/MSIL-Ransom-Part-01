using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WriterValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StopPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopPolicy()
	{
	}
}
