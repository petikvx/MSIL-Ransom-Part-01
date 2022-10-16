using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CustomerAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralAdvisor()
	{
	}
}
