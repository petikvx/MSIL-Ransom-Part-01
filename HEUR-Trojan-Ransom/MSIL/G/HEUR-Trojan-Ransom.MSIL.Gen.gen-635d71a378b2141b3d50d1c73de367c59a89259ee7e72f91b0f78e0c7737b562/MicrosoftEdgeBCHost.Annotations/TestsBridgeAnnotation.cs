using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TestsBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PatchQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchQueue()
	{
	}
}
