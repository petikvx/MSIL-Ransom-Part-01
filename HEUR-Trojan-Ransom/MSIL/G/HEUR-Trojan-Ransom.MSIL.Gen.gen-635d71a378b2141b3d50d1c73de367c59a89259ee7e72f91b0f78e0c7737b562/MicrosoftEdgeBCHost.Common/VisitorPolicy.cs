using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class VisitorPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceDatabase()
	{
	}
}
