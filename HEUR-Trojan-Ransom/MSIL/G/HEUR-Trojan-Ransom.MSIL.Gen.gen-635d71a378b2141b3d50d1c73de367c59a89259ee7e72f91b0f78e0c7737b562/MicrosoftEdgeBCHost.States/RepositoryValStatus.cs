using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RepositoryValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralModel()
	{
	}
}
