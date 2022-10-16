using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class UtilsOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		LoginBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginBase()
	{
	}
}
