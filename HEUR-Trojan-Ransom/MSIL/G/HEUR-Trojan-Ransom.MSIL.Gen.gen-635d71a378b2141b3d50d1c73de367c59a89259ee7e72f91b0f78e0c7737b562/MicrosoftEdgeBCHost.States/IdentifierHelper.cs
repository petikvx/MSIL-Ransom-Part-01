using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IdentifierHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierHelper()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralCreator()
	{
	}
}
