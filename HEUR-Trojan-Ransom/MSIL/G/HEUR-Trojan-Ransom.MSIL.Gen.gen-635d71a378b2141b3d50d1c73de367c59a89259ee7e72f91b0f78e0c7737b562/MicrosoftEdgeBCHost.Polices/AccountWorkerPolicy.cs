using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AccountWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceWatcher()
	{
	}
}
