using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TestFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralItem()
	{
	}
}
