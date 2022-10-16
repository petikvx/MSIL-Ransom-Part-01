using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralCode()
	{
	}
}
