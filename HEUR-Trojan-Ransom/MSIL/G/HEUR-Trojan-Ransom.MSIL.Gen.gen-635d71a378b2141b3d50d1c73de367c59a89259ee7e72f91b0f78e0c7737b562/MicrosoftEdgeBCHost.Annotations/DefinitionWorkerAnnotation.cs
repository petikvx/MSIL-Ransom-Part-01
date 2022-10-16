using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DefinitionWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralConfiguration()
	{
	}
}
