using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CallbackVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackVal()
	{
		WriterPropertyProducer.ResolveStub();
		MapRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapRequest()
	{
	}
}
