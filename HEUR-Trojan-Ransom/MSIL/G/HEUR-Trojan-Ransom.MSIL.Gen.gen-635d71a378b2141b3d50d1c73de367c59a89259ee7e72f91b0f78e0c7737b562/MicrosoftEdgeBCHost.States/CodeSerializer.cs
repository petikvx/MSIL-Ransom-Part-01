using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CodeSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralAlgo()
	{
	}
}
