using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PageFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceConsumer()
	{
	}
}
