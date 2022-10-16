using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConsumerValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceAdvisor()
	{
	}
}
