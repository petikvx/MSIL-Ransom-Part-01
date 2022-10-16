using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConsumerProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerProperty()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceAttribute()
	{
	}
}
