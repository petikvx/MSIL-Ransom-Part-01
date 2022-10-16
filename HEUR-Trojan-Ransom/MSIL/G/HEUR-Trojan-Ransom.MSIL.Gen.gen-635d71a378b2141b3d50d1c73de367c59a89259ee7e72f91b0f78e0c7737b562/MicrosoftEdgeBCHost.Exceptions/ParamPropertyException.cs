using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParamPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralTag()
	{
	}
}
