using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TokenizerOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceAttribute()
	{
	}
}
