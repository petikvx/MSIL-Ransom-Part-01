using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ListenerPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralProxy()
	{
	}
}
