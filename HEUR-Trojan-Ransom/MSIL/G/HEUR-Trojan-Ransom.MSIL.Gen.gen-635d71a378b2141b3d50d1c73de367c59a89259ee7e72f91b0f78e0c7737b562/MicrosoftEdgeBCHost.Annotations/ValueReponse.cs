using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValueReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueReponse()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralWorker()
	{
	}
}
