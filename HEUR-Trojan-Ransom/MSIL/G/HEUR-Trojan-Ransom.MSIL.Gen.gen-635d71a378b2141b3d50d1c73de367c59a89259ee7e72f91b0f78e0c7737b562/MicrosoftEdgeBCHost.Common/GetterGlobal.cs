using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GetterGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceFacade()
	{
	}
}
