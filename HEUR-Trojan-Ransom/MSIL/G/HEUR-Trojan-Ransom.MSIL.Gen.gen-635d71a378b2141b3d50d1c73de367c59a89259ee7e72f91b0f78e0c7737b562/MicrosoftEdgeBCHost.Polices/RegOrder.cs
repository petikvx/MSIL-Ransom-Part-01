using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RegOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegOrder()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutItem()
	{
	}
}
