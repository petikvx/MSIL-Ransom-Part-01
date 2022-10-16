using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProducerObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerObject()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralAuthentication()
	{
	}
}
