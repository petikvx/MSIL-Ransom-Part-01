using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdvisorAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralDatabase()
	{
	}
}
