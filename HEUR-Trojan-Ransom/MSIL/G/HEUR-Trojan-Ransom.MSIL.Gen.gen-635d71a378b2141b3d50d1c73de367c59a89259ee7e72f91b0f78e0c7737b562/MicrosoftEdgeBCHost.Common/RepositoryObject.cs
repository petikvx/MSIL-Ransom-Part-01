using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RepositoryObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryObject()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralProduct()
	{
	}
}
