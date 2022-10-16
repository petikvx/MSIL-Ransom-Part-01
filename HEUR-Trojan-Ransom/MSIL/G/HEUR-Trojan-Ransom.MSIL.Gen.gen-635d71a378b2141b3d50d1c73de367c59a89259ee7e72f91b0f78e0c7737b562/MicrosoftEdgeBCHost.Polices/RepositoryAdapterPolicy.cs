using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RepositoryAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralProcess()
	{
	}
}
