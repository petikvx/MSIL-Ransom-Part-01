using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProccesorAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceCode()
	{
	}
}
