using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ManagerOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralVal()
	{
	}
}
