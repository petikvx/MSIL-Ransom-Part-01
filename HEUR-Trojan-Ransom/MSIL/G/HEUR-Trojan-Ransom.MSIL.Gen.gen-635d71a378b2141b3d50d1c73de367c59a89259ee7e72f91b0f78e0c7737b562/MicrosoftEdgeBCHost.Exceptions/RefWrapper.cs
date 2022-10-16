using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RefWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectMap()
	{
	}
}
