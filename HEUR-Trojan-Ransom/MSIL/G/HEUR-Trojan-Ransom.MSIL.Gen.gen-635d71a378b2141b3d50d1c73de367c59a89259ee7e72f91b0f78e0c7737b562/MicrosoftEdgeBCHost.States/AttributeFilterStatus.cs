using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttributeFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralObject()
	{
	}
}
