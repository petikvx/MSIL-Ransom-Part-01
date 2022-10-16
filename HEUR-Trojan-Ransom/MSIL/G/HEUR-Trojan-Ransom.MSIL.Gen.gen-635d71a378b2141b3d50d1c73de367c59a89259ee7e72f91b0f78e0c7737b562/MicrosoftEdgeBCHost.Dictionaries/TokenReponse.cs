using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TokenReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenReponse()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralManager()
	{
	}
}
