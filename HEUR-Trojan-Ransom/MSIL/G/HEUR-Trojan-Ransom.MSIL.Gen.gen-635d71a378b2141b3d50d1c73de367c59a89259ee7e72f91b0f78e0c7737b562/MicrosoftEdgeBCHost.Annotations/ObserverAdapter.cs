using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ObserverAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceValue()
	{
	}
}
