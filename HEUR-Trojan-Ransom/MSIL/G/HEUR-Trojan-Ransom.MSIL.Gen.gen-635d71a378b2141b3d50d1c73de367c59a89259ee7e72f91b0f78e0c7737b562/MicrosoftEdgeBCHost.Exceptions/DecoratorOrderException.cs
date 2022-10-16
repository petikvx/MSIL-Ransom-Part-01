using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DecoratorOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceInitializer()
	{
	}
}
