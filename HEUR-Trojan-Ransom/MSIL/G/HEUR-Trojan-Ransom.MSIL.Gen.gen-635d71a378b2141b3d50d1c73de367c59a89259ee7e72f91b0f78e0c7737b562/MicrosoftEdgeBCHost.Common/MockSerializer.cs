using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MockSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralAttribute()
	{
	}
}
