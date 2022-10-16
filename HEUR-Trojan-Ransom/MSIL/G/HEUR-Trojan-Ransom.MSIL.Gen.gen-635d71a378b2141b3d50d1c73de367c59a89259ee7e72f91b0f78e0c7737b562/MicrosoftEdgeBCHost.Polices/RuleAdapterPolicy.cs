using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RuleAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralSingleton()
	{
	}
}
