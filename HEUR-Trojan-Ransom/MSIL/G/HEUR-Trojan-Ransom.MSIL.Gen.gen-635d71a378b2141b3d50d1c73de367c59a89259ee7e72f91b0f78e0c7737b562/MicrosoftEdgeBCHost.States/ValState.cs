using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ValState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValState()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceStatus()
	{
	}
}
