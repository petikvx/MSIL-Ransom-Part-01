using System;
using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Storage.Basic;

public class AccessToken : TokenBase
{
	public string UserName { get; set; }

	public string[] Roles { get; set; }

	public DateTime ExpiryDate { get; set; }
}
