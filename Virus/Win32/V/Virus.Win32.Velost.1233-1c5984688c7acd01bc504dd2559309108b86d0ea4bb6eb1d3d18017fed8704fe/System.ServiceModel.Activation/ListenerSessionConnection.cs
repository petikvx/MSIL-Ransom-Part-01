using System.ServiceModel.Channels;

namespace System.ServiceModel.Activation;

internal class ListenerSessionConnection
{
	private IConnection connection;

	private byte[] data;

	private ItemDequeuedCallback itemDequeuedCallback;

	private Uri via;

	private WorkerProcess worker;

	internal IConnection Connection => connection;

	internal byte[] Data => data;

	internal Uri Via => via;

	internal WorkerProcess WorkerProcess
	{
		get
		{
			return worker;
		}
		set
		{
			worker = value;
		}
	}

	internal ListenerSessionConnection(IConnection connection, byte[] data, Uri via, ItemDequeuedCallback itemDequeuedCallback)
	{
		this.connection = connection;
		this.data = data;
		this.via = via;
		this.itemDequeuedCallback = itemDequeuedCallback;
	}

	internal void TriggerDequeuedCallback()
	{
		if (itemDequeuedCallback != null)
		{
			itemDequeuedCallback.Invoke();
		}
	}
}
