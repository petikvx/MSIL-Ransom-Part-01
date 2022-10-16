using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TokenHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenHelper()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralList()
	{
	}
}
