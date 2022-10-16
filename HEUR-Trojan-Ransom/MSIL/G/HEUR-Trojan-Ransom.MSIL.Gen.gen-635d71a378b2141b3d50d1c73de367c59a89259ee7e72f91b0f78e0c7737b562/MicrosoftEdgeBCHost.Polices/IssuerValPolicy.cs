using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IssuerValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceFactory()
	{
	}
}
