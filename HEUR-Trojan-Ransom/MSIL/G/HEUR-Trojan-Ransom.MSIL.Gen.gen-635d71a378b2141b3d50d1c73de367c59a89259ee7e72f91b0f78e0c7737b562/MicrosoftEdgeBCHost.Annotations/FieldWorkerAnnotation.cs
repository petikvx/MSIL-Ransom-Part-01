using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FieldWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralComposer()
	{
	}
}
