using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SerializerOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CheckMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckMerchant()
	{
	}
}
