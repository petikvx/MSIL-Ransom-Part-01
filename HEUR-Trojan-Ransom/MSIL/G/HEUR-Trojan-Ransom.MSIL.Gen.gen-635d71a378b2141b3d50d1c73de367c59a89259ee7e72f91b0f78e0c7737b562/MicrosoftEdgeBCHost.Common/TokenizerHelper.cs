using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TokenizerHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerHelper()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralWriter()
	{
	}
}
