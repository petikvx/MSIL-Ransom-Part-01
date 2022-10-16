using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WatcherReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherReponse()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralConnection()
	{
	}
}
