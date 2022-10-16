using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DatabaseValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseValException()
	{
		WriterPropertyProducer.ResolveStub();
		NewRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewRef()
	{
	}
}
