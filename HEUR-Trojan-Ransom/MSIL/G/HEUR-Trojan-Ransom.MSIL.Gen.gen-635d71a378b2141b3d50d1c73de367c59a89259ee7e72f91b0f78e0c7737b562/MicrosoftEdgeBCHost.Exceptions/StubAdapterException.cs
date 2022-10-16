using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StubAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfacePage()
	{
	}
}
