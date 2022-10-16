using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class HelperOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralPool()
	{
	}
}
