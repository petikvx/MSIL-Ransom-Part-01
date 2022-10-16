using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParamsFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReadAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadAdapter()
	{
	}
}
