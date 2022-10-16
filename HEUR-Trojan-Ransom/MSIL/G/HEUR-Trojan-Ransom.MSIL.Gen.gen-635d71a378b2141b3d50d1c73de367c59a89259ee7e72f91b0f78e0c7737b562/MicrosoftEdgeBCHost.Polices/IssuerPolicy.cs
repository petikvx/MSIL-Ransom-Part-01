using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IssuerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceSystem()
	{
	}
}
