using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class EventAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceSerializer()
	{
	}
}
