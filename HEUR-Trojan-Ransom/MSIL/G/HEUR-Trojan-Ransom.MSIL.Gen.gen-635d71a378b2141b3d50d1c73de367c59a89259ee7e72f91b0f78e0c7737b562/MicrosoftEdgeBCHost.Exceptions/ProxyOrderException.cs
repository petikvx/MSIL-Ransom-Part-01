using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProxyOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceServer()
	{
	}
}
