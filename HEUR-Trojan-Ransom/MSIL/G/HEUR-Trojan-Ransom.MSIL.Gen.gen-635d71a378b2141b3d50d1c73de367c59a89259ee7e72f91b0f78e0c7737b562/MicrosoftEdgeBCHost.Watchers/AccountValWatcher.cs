using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AccountValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfacePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfacePrinter()
	{
	}
}
