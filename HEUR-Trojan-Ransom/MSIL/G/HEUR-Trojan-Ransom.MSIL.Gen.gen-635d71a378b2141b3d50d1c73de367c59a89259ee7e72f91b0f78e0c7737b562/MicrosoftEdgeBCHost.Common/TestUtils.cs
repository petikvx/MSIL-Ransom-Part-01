using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TestUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestUtils()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceAttr()
	{
	}
}
