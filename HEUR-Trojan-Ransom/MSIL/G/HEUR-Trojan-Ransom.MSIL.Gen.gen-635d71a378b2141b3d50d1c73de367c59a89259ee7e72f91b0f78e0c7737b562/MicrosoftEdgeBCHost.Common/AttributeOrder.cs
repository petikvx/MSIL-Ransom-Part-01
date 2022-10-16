using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AttributeOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeOrder()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveProc()
	{
	}
}
