using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DatabaseWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		TestCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestCreator()
	{
	}
}
