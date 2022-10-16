using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ComparatorOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceRule()
	{
	}
}
