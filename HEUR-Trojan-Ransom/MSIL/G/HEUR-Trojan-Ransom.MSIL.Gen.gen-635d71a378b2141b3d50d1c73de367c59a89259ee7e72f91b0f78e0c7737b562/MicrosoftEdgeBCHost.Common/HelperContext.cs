using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class HelperContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperContext()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfacePublisher()
	{
	}
}
