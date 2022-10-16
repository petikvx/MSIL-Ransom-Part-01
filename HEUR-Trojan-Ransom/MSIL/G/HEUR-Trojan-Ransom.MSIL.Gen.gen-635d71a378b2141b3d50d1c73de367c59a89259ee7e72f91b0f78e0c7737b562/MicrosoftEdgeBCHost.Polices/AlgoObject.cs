using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AlgoObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoObject()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralOrder()
	{
	}
}
