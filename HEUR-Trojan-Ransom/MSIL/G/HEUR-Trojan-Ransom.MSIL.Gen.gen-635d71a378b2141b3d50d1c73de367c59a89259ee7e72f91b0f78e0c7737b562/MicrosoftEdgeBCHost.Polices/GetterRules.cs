using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class GetterRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterRules()
	{
		WriterPropertyProducer.ResolveStub();
		StartParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartParameter()
	{
	}
}
