using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RepositoryProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryProperty()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceService()
	{
	}
}
