using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class EventProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventProperty()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceAttribute()
	{
	}
}
