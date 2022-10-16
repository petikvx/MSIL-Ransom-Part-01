using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CustomerServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerServer()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralUtils()
	{
	}
}
