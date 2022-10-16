using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ServiceGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceExpression()
	{
	}
}
