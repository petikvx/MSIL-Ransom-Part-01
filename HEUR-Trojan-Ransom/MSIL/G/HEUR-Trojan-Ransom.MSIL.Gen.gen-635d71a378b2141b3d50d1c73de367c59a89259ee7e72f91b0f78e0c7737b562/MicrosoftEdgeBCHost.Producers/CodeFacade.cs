using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CodeFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralBase()
	{
	}
}
