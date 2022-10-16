using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProxyServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyServer()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralIterator()
	{
	}
}
