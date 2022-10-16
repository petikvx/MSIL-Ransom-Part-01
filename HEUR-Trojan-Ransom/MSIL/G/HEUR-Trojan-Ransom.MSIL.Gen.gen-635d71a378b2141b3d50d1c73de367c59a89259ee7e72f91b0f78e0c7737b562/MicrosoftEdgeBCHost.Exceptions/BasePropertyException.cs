using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class BasePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BasePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralConfig()
	{
	}
}
