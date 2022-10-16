using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ServerWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateReader()
	{
	}
}
