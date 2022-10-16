using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProcessValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralMethod()
	{
	}
}
