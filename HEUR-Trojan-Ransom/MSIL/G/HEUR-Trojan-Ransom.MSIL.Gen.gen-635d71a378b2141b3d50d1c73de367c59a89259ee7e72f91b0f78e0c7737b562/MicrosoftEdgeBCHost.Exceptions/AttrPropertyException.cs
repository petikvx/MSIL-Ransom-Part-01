using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AttrPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralTag()
	{
	}
}
