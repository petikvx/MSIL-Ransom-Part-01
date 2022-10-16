using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class OrderObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderObject()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralModel()
	{
	}
}
