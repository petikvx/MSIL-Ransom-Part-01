using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StructFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructFacade()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralConsumer()
	{
	}
}
