using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StatusOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceEvent()
	{
	}
}
