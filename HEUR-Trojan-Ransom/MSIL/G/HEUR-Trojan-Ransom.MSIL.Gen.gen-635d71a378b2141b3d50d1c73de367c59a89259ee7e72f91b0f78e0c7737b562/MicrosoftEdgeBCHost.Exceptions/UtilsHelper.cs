using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class UtilsHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsHelper()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralInvocation()
	{
	}
}
