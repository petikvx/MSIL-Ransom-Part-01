using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ReaderWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralMapper()
	{
	}
}
