using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConnectionHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionHelper()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralAdvisor()
	{
	}
}
