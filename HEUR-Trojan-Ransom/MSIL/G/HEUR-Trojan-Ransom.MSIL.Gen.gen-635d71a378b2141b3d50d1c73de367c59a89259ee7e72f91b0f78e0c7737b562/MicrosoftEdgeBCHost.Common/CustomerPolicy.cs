using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CustomerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceCreator()
	{
	}
}
