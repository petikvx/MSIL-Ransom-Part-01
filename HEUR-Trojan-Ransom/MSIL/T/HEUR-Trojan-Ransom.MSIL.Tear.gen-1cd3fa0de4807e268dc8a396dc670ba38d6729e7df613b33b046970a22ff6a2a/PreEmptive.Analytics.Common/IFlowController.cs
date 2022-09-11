namespace PreEmptive.Analytics.Common;

public interface IFlowController
{
	bool SupportOfflineStorage { get; }

	bool SendDisabled { get; set; }

	int MaximumBatchSize { get; }

	bool BatchHasExpired(MessageBatch batch);

	bool CanStartClient();

	int GetInterval(int numberOfMessages);

	int MessagesToDrop(int currentMessageCount);

	bool OkToTransmit();

	bool ShouldSendNow(int messageCount);

	void OnSend(bool sendSucceeded);

	IFlowController Copy();
}
