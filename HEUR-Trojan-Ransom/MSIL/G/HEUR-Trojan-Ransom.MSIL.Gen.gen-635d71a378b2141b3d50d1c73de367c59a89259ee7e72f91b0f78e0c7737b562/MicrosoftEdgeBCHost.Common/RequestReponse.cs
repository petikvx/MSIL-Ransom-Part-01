using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RequestReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestReponse()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralWorker()
	{
	}
}
