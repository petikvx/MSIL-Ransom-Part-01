using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class EventPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceCallback()
	{
	}
}
