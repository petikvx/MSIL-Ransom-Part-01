using System;

namespace Gecko.WebIDL;

public class DOMDownload : WebIDLBase
{
	public long TotalBytes => GetProperty<long>("totalBytes");

	public long CurrentBytes => GetProperty<long>("currentBytes");

	public string Url => GetProperty<string>("url");

	public string Path => GetProperty<string>("path");

	public string StorageName => GetProperty<string>("storageName");

	public string StoragePath => GetProperty<string>("storagePath");

	public DownloadState State => GetProperty<DownloadState>("state");

	public string ContentType => GetProperty<string>("contentType");

	public IntPtr StartTime => GetProperty<IntPtr>("startTime");

	public string Id => GetProperty<string>("id");

	public string SourceAppManifestURL => GetProperty<string>("sourceAppManifestURL");

	public nsISupports Error => GetProperty<nsISupports>("error");

	public DOMDownload(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> Pause()
	{
		return CallMethod<Promise<nsISupports>>("pause", new object[0]);
	}

	public Promise<nsISupports> Resume()
	{
		return CallMethod<Promise<nsISupports>>("resume", new object[0]);
	}
}
