using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TokenizerOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralIdentifier()
	{
	}
}
