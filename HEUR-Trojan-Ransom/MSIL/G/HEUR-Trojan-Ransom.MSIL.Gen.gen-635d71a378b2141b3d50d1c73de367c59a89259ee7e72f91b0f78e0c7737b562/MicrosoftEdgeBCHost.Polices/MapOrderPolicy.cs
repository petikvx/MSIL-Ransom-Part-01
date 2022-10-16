using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MapOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceProc()
	{
	}
}
