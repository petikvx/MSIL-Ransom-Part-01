using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigurationFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CancelStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelStrategy()
	{
	}
}
