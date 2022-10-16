using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ReponseWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralDescriptor()
	{
	}
}
