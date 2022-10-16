using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StatusVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusVal()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterWrapper()
	{
	}
}
