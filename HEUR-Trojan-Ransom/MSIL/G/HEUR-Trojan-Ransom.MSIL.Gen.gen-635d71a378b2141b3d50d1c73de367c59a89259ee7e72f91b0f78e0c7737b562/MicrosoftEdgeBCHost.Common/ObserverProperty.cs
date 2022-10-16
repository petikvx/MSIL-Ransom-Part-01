using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ObserverProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverProperty()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceState()
	{
	}
}
