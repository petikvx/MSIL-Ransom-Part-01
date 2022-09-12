using System.ComponentModel;

namespace Gecko.WebIDL;

public enum PushEncryptionKeyName
{
	[Description("p256dh")]
	p256dh,
	[Description("auth")]
	auth
}
