using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MerchantOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceGetter()
	{
	}
}
