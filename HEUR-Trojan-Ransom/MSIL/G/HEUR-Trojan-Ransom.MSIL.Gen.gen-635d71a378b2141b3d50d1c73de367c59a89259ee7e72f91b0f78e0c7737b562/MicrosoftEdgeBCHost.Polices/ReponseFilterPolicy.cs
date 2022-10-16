using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ReponseFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RunGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunGetter()
	{
	}
}
