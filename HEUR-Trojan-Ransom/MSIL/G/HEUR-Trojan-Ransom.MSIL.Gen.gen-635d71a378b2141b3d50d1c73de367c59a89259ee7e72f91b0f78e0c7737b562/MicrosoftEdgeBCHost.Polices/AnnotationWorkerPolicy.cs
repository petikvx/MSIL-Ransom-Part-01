using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AnnotationWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceProxy()
	{
	}
}
