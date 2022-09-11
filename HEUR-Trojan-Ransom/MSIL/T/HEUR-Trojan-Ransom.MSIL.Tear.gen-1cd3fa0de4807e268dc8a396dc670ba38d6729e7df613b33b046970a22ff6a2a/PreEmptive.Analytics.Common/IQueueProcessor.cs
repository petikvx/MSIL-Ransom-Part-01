namespace PreEmptive.Analytics.Common;

public interface IQueueProcessor
{
	bool Running { get; set; }

	void Start();

	void Stop();

	void ProcessQueueNow();
}
