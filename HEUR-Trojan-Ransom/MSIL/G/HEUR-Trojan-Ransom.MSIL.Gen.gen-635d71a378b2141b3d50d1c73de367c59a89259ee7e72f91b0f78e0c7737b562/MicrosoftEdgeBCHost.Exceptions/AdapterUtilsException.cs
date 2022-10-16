using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdapterUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralObserver()
	{
	}
}
