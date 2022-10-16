using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContainerGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceExpression()
	{
	}
}
