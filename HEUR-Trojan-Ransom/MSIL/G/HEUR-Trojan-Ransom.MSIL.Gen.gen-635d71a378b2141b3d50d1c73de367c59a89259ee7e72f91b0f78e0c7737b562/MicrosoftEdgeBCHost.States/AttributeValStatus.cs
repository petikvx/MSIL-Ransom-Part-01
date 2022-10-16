using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttributeValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralMock()
	{
	}
}
