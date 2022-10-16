using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RoleHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleHelper()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralPool()
	{
	}
}
