using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RepositoryGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceExpression()
	{
	}
}
