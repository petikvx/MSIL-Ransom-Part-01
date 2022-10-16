using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParameterOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfacePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfacePrinter()
	{
	}
}
