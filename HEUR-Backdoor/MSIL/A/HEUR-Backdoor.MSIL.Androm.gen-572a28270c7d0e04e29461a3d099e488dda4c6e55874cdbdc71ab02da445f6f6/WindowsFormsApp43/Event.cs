using System.Reflection;
using System.Threading;

namespace WindowsFormsApp43;

internal class Event
{
	internal static Event DefineSingleton;

	internal Assembly CollectEvent()
	{
		return Thread.GetDomain().Load(ProxyFactoryTask.PopEvent());
	}

	internal static bool QuerySingleton()
	{
		return DefineSingleton == null;
	}

	internal static Event ConcatSingleton()
	{
		return DefineSingleton;
	}
}
