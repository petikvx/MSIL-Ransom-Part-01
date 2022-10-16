using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RegistryFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryFilter()
	{
		WriterPropertyProducer.ResolveStub();
		FlushConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushConfig()
	{
	}
}
