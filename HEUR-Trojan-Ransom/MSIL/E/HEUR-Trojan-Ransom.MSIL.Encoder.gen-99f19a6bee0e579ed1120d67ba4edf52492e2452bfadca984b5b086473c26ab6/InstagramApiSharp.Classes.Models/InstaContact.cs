using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaContact
{
	[JsonProperty("phone_numbers")]
	public List<string> PhoneNumbers { get; set; }

	[JsonProperty("email_addresses")]
	public List<string> EmailAddresses { get; set; }

	[JsonProperty("first_name")]
	public string FirstName { get; set; }

	[JsonProperty("last_name")]
	public string LastName { get; set; }
}
