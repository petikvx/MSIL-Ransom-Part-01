using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StubOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralStub()
	{
	}
}
