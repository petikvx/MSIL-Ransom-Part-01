using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CallbackOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackOrder()
	{
		WriterPropertyProducer.ResolveStub();
		StopItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopItem()
	{
	}
}
