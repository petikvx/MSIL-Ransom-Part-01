using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ValObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValObject()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralModel()
	{
	}
}
