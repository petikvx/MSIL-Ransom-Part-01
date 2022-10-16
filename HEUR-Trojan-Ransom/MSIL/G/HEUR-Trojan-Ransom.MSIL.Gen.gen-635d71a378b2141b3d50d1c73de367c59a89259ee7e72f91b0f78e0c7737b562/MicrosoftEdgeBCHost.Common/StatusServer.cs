using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StatusServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusServer()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralWatcher()
	{
	}
}
