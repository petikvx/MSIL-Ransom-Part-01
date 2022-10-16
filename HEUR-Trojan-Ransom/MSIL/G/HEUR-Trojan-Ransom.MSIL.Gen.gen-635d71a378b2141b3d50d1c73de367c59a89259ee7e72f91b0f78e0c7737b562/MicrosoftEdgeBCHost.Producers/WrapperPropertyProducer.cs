using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WrapperPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralSpecification()
	{
	}
}
