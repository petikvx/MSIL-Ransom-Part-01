using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CustomerWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		GetRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetRole()
	{
	}
}
