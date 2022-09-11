using System;
using System.Security.Cryptography;
using System.Text;

namespace TryPaper;

public class WebHookEvent
{
	public string Key { get; set; }

	public DateTime DateUtc { get; set; }

	public ApiEventType EventType { get; set; }

	public string Message { get; set; }

	public string Hash { get; set; }

	public bool IsValid(string secretKey)
	{
		HMACSHA1 hMACSHA = new HMACSHA1(Convert.FromBase64String(secretKey));
		string s = $"{Key}-{EventType}-{Message}";
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		byte[] inArray = hMACSHA.ComputeHash(bytes);
		return Convert.ToBase64String(inArray).Equals(Hash);
	}
}
