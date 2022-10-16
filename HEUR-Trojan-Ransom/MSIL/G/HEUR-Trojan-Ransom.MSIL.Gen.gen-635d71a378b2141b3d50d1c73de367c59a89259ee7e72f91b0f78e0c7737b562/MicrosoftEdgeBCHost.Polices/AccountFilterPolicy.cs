using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AccountFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInitializer()
	{
	}
}
