namespace PreEmptive.Analytics.Common;

public interface IQueuePersister : IQueueProcessor
{
	void SaveDataOffline(MessageBatch batch);
}
