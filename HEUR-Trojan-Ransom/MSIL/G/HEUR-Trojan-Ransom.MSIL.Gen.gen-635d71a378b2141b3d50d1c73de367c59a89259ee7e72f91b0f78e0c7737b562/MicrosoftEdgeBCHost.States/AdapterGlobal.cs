using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AdapterGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceListener()
	{
	}
}
