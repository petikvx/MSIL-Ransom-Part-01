using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ResolverVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverVal()
	{
		WriterPropertyProducer.ResolveStub();
		GetAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetAnnotation()
	{
	}
}
