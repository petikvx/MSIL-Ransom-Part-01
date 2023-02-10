using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SpeechLib;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("269316D8-57BD-11D2-9EEE-00C04F797396")]
public interface ISpeechVoice
{
	int Rate
	{
		[DispId(5)]
		get;
		[DispId(5)]
		[param: In]
		set;
	}

	void _VtblGap1_7();

	void _VtblGap2_12();

	[DispId(12)]
	int Speak([In][MarshalAs(UnmanagedType.BStr)] string Text, [In] SpeechVoiceSpeakFlags Flags = SpeechVoiceSpeakFlags.SVSFDefault);
}
