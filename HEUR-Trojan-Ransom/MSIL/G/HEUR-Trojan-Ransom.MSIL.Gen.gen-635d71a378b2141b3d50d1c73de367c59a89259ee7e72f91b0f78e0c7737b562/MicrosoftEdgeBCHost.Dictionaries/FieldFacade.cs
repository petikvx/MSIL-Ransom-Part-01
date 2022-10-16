using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FieldFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldFacade()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralConsumer()
	{
	}
}
