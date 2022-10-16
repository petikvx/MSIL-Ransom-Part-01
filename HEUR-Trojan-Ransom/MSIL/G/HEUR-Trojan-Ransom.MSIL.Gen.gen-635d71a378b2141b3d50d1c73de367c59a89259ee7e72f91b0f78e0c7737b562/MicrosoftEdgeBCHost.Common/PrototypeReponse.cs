using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PrototypeReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralWorker()
	{
	}
}
