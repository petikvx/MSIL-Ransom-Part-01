using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SchemaPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceInvocation()
	{
	}
}
