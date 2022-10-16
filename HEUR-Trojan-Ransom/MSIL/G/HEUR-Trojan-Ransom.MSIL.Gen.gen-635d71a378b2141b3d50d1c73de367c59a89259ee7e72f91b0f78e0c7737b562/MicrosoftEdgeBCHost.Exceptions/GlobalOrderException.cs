using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class GlobalOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeBase()
	{
	}
}
