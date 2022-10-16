using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConnectionWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		WriteBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteBridge()
	{
	}
}
