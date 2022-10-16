using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CustomerVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerVal()
	{
		WriterPropertyProducer.ResolveStub();
		MapAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapAnnotation()
	{
	}
}
