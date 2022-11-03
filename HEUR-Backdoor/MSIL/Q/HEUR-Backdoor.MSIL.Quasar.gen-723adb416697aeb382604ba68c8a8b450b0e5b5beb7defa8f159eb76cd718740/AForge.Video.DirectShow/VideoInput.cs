namespace AForge.Video.DirectShow;

public class VideoInput
{
	public readonly int Index;

	public readonly PhysicalConnectorType Type;

	public static VideoInput Default => new VideoInput(-1, PhysicalConnectorType.Default);

	internal VideoInput(int index, PhysicalConnectorType type)
	{
		Index = index;
		Type = type;
	}
}
