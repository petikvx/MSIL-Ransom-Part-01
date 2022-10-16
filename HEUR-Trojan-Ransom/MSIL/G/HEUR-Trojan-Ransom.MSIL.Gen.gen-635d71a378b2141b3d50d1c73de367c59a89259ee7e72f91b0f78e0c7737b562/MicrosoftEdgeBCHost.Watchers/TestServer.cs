using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestServer()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralClient()
	{
	}
}
