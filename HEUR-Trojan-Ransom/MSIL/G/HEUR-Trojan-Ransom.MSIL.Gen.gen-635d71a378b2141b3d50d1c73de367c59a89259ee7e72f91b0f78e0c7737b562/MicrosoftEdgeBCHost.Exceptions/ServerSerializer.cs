using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ServerSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralMapping()
	{
	}
}
