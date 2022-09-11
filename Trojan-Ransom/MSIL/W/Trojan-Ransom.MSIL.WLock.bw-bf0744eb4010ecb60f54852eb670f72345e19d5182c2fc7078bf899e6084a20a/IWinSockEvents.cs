using System;

public interface IWinSockEvents
{
	public delegate void ConnectedToServerEventHandler(object sender, WinsockConnectedEventArgs e);

	public delegate void ConnectionClientEventHandler(object sender, WinsockConnectionRequestEventArgs e);

	public delegate void CountChangedEventHandler(object sender, WinsockCollectionCountChangedEventArgs e);

	public delegate void TextReceivedEventHandler(object sender, EventArgs e);

	public delegate void CommandReceivedEventHandler(object sender, EventArgs e);

	public delegate void FileReceivedEventHandler(object sender, EventArgs e);

	public delegate void DisconnectedEventHandler(object sender, EventArgs e);

	public delegate void ErrorReceivedEventHandler(object sender, WinsockErrorReceivedEventArgs e);

	public delegate void SendTextCompleteEventHandler(object sender, WinsockSendEventArgs e);

	public delegate void SendFileCompleteEventHandler(object sender, WinsockSendEventArgs e);

	public delegate void SendProgressEventHandler(object sender, WinsockSendEventArgs e);

	public delegate void ReceiveProgressEventHandler(object sender, WinsockReceiveProgressEventArgs e);

	public delegate void StateChangedEventHandler(object sender, WinsockStateChangedEventArgs e);

	event ConnectedToServerEventHandler ConnectedToServer;

	event ConnectionClientEventHandler ConnectionClient;

	event CountChangedEventHandler CountChanged;

	event TextReceivedEventHandler TextReceived;

	event CommandReceivedEventHandler CommandReceived;

	event FileReceivedEventHandler FileReceived;

	event DisconnectedEventHandler Disconnected;

	event ErrorReceivedEventHandler ErrorReceived;

	event SendTextCompleteEventHandler SendTextComplete;

	event SendFileCompleteEventHandler SendFileComplete;

	event SendProgressEventHandler SendProgress;

	event ReceiveProgressEventHandler ReceiveProgress;

	event StateChangedEventHandler StateChanged;
}
