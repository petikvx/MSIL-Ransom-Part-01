using System;

namespace WindowsFormsApplication1;

public class UploadedImage
{
	public string id { get; set; }

	public string picture { get; set; }

	public string path { get; set; }

	public string path_small { get; set; }

	public string path_large { get; set; }

	public string content_type { get; set; }

	public string storage_location { get; set; }

	public string md5_hash { get; set; }

	public DateTime created_at { get; set; }

	public string url { get; set; }

	public string url_small { get; set; }

	public string url_large { get; set; }
}
