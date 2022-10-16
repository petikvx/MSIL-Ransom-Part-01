using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConsumerOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerOrder()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyStruct()
	{
	}
}
