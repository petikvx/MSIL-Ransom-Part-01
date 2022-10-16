using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TestVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestVal()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectUtils()
	{
	}
}
