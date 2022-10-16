using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ManagerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceCreator()
	{
	}
}
