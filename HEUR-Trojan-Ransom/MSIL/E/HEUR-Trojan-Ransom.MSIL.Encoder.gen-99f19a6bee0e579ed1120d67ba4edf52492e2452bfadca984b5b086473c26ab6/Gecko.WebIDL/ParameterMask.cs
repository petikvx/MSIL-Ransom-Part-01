using System.ComponentModel;

namespace Gecko.WebIDL;

public enum ParameterMask
{
	[Description("subject")]
	subject,
	[Description("datetime")]
	datetime,
	[Description("sender_name")]
	sender_name,
	[Description("sender_addressing")]
	sender_addressing,
	[Description("recipient_name")]
	recipient_name,
	[Description("recipient_addressing")]
	recipient_addressing,
	[Description("type")]
	type,
	[Description("size")]
	size,
	[Description("reception_status")]
	reception_status,
	[Description("text")]
	text,
	[Description("attachment_size")]
	attachment_size,
	[Description("priority")]
	priority,
	[Description("read")]
	read,
	[Description("sent")]
	sent,
	[Description("protected")]
	@protected,
	[Description("replyto_addressing")]
	replyto_addressing
}
