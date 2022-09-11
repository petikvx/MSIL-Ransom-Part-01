namespace PreEmptive.Analytics.Common;

public interface IOfflineDataStore
{
	void SaveBatch(MessageBatch messagebatch);

	MessageBatch GetSavedBatch();

	void ClearBatch(MessageBatch messagebatch);
}
