using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContainerObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerObject()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralComparator()
	{
	}
}
