using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ComposerValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerValException()
	{
		WriterPropertyProducer.ResolveStub();
		EnableDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableDecorator()
	{
	}
}
