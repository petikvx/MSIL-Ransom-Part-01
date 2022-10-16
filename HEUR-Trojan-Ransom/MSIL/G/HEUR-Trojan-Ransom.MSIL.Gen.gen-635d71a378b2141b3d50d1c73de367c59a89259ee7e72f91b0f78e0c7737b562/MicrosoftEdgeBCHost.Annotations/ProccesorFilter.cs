using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProccesorFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorFilter()
	{
		WriterPropertyProducer.ResolveStub();
		StopFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopFacade()
	{
	}
}
