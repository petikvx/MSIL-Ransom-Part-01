using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigurationAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralDispatcher()
	{
	}
}
