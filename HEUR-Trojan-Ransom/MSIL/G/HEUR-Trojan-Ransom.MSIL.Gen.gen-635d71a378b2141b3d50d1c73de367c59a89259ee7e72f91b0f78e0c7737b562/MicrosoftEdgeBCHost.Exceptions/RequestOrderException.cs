using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RequestOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceDecorator()
	{
	}
}
