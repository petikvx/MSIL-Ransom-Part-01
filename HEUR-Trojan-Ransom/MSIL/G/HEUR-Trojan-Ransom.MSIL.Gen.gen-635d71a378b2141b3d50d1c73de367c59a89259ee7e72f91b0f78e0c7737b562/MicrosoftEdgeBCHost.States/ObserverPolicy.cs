using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ObserverPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceField()
	{
	}
}
