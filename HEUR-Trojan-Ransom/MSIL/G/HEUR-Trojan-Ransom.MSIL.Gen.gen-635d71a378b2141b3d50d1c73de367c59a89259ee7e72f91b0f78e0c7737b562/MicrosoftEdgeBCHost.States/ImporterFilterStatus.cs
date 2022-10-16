using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ImporterFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceCreator()
	{
	}
}
