using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AccountState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountState()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceProperty()
	{
	}
}
