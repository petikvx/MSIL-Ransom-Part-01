using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RepositoryBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateStatus()
	{
	}
}
