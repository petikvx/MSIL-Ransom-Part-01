using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SpecificationValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceMethod()
	{
	}
}
