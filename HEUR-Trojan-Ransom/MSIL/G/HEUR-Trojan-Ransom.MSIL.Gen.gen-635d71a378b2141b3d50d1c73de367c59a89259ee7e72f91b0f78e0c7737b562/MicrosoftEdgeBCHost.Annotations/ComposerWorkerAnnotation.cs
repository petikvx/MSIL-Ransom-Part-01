using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ComposerWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralFacade()
	{
	}
}
