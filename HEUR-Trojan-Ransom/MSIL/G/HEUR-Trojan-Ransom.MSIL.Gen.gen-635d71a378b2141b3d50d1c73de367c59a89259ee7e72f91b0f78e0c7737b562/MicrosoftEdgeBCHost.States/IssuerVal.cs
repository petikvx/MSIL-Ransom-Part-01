using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IssuerVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerVal()
	{
		WriterPropertyProducer.ResolveStub();
		FillTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillTask()
	{
	}
}
