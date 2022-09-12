namespace Gecko.WebIDL;

public class CameraCapabilities : WebIDLBase
{
	public object[] PreviewSizes => GetProperty<object[]>("previewSizes");

	public object[] PictureSizes => GetProperty<object[]>("pictureSizes");

	public object[] ThumbnailSizes => GetProperty<object[]>("thumbnailSizes");

	public object[] VideoSizes => GetProperty<object[]>("videoSizes");

	public string[] FileFormats => GetProperty<string[]>("fileFormats");

	public string[] WhiteBalanceModes => GetProperty<string[]>("whiteBalanceModes");

	public string[] SceneModes => GetProperty<string[]>("sceneModes");

	public string[] Effects => GetProperty<string[]>("effects");

	public string[] FlashModes => GetProperty<string[]>("flashModes");

	public string[] FocusModes => GetProperty<string[]>("focusModes");

	public double[] ZoomRatios => GetProperty<double[]>("zoomRatios");

	public uint MaxFocusAreas => GetProperty<uint>("maxFocusAreas");

	public uint MaxMeteringAreas => GetProperty<uint>("maxMeteringAreas");

	public uint MaxDetectedFaces => GetProperty<uint>("maxDetectedFaces");

	public double MinExposureCompensation => GetProperty<double>("minExposureCompensation");

	public double MaxExposureCompensation => GetProperty<double>("maxExposureCompensation");

	public double ExposureCompensationStep => GetProperty<double>("exposureCompensationStep");

	public nsISupports RecorderProfiles => GetProperty<nsISupports>("recorderProfiles");

	public string[] IsoModes => GetProperty<string[]>("isoModes");

	public string[] MeteringModes => GetProperty<string[]>("meteringModes");

	public CameraCapabilities(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
