using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DatabaseContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseContext()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceSpecification()
	{
	}
}
