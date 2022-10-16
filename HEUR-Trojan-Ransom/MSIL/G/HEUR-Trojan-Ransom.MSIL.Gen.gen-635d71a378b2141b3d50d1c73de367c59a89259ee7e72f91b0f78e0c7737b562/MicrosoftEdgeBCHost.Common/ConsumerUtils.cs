using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConsumerUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceGlobal()
	{
	}
}
