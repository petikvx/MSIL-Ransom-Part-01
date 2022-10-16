using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RulesPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralRef()
	{
	}
}
