using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CreatorValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveAccount()
	{
	}
}
