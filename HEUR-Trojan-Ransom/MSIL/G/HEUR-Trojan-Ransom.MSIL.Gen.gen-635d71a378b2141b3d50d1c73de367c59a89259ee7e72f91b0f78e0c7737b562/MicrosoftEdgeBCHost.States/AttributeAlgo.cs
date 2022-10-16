using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttributeAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralContext()
	{
	}
}
