using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SystemValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SearchBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchBase()
	{
	}
}
