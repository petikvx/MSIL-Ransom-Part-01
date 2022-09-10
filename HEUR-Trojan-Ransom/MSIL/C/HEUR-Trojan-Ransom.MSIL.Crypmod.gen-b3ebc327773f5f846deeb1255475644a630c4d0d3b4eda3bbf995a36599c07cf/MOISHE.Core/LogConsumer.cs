using System;
using System.Collections.Concurrent;
using _003CPrivateImplementationDetails_003E_007B18A11B1C_002D3AA7_002D4357_002DAAD9_002DCC83BB5216E3_007D;

namespace MOISHE.Core;

public class LogConsumer : AbstractConsumer<string>
{
	public LogConsumer(BlockingCollection<string> source)
		: base(source)
	{
	}

	protected override void OnItemArrived(string item)
	{
		Console.WriteLine(runner.Name + Class0.bj() + item);
	}
}
