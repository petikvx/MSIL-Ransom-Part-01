using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WriterValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceCallback()
	{
	}
}
