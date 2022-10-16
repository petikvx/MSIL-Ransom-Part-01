using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MapServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapServer()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralClient()
	{
	}
}
