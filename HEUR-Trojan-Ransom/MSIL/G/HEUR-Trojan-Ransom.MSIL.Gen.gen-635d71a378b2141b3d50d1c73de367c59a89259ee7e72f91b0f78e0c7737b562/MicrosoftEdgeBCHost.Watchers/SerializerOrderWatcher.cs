using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SerializerOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralTests()
	{
	}
}
