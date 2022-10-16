using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WrapperBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperBridge()
	{
		WriterPropertyProducer.ResolveStub();
		OrderParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderParser()
	{
	}
}
