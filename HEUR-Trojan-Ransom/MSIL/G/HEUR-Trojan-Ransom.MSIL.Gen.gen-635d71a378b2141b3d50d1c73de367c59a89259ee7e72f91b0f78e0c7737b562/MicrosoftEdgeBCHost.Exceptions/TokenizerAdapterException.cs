using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TokenizerAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceAdvisor()
	{
	}
}
