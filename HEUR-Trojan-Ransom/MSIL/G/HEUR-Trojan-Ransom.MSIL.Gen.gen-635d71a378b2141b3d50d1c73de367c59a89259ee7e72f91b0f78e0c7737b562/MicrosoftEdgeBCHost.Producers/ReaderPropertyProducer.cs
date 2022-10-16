using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ReaderPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralReg()
	{
	}
}
