using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DecoratorAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralEvent()
	{
	}
}
