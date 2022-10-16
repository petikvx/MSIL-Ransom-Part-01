using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MapperWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralAnnotation()
	{
	}
}
