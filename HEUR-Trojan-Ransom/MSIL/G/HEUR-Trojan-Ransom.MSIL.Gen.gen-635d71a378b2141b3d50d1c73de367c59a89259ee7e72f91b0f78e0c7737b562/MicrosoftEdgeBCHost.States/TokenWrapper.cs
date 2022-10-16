using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TokenWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateAttribute()
	{
	}
}
