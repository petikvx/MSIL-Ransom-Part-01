using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CallbackAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralTag()
	{
	}
}
