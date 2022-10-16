using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DecoratorProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorProperty()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceSetter()
	{
	}
}
