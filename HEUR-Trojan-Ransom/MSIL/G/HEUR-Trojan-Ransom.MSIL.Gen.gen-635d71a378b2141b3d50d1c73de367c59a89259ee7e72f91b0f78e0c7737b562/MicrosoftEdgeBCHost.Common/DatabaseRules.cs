using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DatabaseRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseRules()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateParams()
	{
	}
}
