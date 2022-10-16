using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParserVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserVal()
	{
		WriterPropertyProducer.ResolveStub();
		CompareSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareSpecification()
	{
	}
}
