using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IssuerReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerReponse()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralFactory()
	{
	}
}
