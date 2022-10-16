using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProcGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceFacade()
	{
	}
}
