using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AccountWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		OrderService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderService()
	{
	}
}
