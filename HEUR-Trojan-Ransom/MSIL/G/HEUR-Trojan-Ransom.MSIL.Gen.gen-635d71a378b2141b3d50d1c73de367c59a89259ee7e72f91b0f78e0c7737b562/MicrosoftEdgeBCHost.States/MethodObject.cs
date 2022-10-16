using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MethodObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodObject()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralConfig()
	{
	}
}
