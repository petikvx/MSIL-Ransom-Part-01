using System;
using System.ComponentModel;

public interface IInternetEvents
{
	public delegate void SendingQueryEventHandler(object sender, CancelEventArgs e);

	public delegate void SentQueryEventHandler(object sender, EventArgs e);

	public delegate void ReceivedResponseEventHandler(object sender, EventArgs e);

	public delegate void ReceiveProgressEventHandler(object sender, WinsockReceiveProgressEventArgs e);

	public delegate void DownloadCancelledEventHandler(object sender, EventArgs e);

	event SendingQueryEventHandler SendingQuery;

	event SentQueryEventHandler SentQuery;

	event ReceivedResponseEventHandler ReceivedResponse;

	event ReceiveProgressEventHandler ReceiveProgress;

	event DownloadCancelledEventHandler DownloadCancelled;
}
