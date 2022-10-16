using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FacadeFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeFacade()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralStruct()
	{
	}
}
