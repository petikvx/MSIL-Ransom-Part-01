using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RecordFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfacePredicate()
	{
	}
}
