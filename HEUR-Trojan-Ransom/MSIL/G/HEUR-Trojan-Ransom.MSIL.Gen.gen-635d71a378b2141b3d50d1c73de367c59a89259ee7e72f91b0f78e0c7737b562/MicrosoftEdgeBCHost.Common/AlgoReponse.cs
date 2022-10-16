using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AlgoReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoReponse()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceConsumer()
	{
	}
}
