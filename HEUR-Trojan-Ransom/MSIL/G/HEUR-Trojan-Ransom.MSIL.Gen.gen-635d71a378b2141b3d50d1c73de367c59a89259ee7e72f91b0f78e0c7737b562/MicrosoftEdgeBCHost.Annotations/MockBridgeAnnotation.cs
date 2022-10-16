using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MockBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ReadDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadDic()
	{
	}
}
