using System;

namespace PreEmptive.Analytics.Common;

public interface IQueueTransmitter : IQueueProcessor
{
	event Action<MessageBatch> TransmissionFailed;

	bool Transmit(MessageBatch batch);

	void FailTransmissionsNow();
}
