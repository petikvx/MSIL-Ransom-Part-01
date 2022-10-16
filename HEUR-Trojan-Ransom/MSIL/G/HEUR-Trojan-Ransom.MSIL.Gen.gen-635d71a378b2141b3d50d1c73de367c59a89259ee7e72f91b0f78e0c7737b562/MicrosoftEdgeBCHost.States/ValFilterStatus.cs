using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ValFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceAuthentication()
	{
	}
}
