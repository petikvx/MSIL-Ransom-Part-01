using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AccountValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceManager()
	{
	}
}
