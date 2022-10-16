using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MapperBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		TestCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestCollection()
	{
	}
}
