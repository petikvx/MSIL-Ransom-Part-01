using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProcessAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralAdvisor()
	{
	}
}
