using System.Collections.Generic;
using Gecko.Interop;

namespace Gecko.Net;

public sealed class DnsRecord
{
	private ComPtr<nsIDNSRecord> _record;

	public string CanonicalName => nsString.Get(_record.Instance.GetCanonicalNameAttribute);

	public string[] Records
	{
		get
		{
			List<string> list = new List<string>();
			while (_record.Instance.HasMore())
			{
				string item = nsString.Get(_record.Instance.GetNextAddrAsString);
				list.Add(item);
			}
			_record.Instance.Rewind();
			return list.ToArray();
		}
	}

	internal DnsRecord(nsIDNSRecord record)
	{
		_record = new ComPtr<nsIDNSRecord>(record);
	}
}
