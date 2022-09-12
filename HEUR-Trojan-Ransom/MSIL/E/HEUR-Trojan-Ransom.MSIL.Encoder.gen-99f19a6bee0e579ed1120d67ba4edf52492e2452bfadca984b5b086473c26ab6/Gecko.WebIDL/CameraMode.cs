using System.ComponentModel;

namespace Gecko.WebIDL;

public enum CameraMode
{
	[Description("unspecified")]
	unspecified,
	[Description("picture")]
	picture,
	[Description("video")]
	video
}
