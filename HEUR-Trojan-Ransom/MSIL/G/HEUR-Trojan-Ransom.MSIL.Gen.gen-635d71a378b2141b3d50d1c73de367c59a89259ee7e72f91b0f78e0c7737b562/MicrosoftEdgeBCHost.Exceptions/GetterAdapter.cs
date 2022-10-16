using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class GetterAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceEvent()
	{
	}
}
