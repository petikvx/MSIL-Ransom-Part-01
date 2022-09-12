namespace Gecko.WebIDL;

public class CameraControl : WebIDLBase
{
	public nsISupports Capabilities => GetProperty<nsISupports>("capabilities");

	public string Effect
	{
		get
		{
			return GetProperty<string>("effect");
		}
		set
		{
			SetProperty("effect", value);
		}
	}

	public string WhiteBalanceMode
	{
		get
		{
			return GetProperty<string>("whiteBalanceMode");
		}
		set
		{
			SetProperty("whiteBalanceMode", value);
		}
	}

	public string SceneMode
	{
		get
		{
			return GetProperty<string>("sceneMode");
		}
		set
		{
			SetProperty("sceneMode", value);
		}
	}

	public string FlashMode
	{
		get
		{
			return GetProperty<string>("flashMode");
		}
		set
		{
			SetProperty("flashMode", value);
		}
	}

	public string FocusMode
	{
		get
		{
			return GetProperty<string>("focusMode");
		}
		set
		{
			SetProperty("focusMode", value);
		}
	}

	public double Zoom
	{
		get
		{
			return GetProperty<double>("zoom");
		}
		set
		{
			SetProperty("zoom", value);
		}
	}

	public double FocalLength => GetProperty<double>("focalLength");

	public double FocusDistanceNear => GetProperty<double>("focusDistanceNear");

	public double FocusDistanceOptimum => GetProperty<double>("focusDistanceOptimum");

	public double FocusDistanceFar => GetProperty<double>("focusDistanceFar");

	public double ExposureCompensation
	{
		get
		{
			return GetProperty<double>("exposureCompensation");
		}
		set
		{
			SetProperty("exposureCompensation", value);
		}
	}

	public string IsoMode
	{
		get
		{
			return GetProperty<string>("isoMode");
		}
		set
		{
			SetProperty("isoMode", value);
		}
	}

	public double PictureQuality
	{
		get
		{
			return GetProperty<double>("pictureQuality");
		}
		set
		{
			SetProperty("pictureQuality", value);
		}
	}

	public int SensorAngle => GetProperty<int>("sensorAngle");

	public string MeteringMode
	{
		get
		{
			return GetProperty<string>("meteringMode");
		}
		set
		{
			SetProperty("meteringMode", value);
		}
	}

	public CameraControl(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object[] GetMeteringAreas()
	{
		return CallMethod<object[]>("getMeteringAreas", new object[0]);
	}

	public void SetMeteringAreas()
	{
		CallVoidMethod("setMeteringAreas");
	}

	public void SetMeteringAreas(object[] meteringAreas)
	{
		CallVoidMethod("setMeteringAreas", meteringAreas);
	}

	public object[] GetFocusAreas()
	{
		return CallMethod<object[]>("getFocusAreas", new object[0]);
	}

	public void SetFocusAreas()
	{
		CallVoidMethod("setFocusAreas");
	}

	public void SetFocusAreas(object[] focusAreas)
	{
		CallVoidMethod("setFocusAreas", focusAreas);
	}

	public object GetPictureSize()
	{
		return CallMethod<object>("getPictureSize", new object[0]);
	}

	public void SetPictureSize()
	{
		CallVoidMethod("setPictureSize");
	}

	public void SetPictureSize(object size)
	{
		CallVoidMethod("setPictureSize", size);
	}

	public object GetThumbnailSize()
	{
		return CallMethod<object>("getThumbnailSize", new object[0]);
	}

	public void SetThumbnailSize()
	{
		CallVoidMethod("setThumbnailSize");
	}

	public void SetThumbnailSize(object size)
	{
		CallVoidMethod("setThumbnailSize", size);
	}

	public Promise<bool> AutoFocus()
	{
		return CallMethod<Promise<bool>>("autoFocus", new object[0]);
	}

	public Promise<nsIDOMBlob> TakePicture()
	{
		return CallMethod<Promise<nsIDOMBlob>>("takePicture", new object[0]);
	}

	public Promise<nsIDOMBlob> TakePicture(object options)
	{
		return CallMethod<Promise<nsIDOMBlob>>("takePicture", new object[1] { options });
	}

	public Promise StartRecording(object options, nsISupports storageArea, string filename)
	{
		return CallMethod<Promise>("startRecording", new object[3] { options, storageArea, filename });
	}

	public void StopRecording()
	{
		CallVoidMethod("stopRecording");
	}

	public void PauseRecording()
	{
		CallVoidMethod("pauseRecording");
	}

	public void ResumeRecording()
	{
		CallVoidMethod("resumeRecording");
	}

	public void ResumePreview()
	{
		CallVoidMethod("resumePreview");
	}

	public Promise Release()
	{
		return CallMethod<Promise>("release", new object[0]);
	}

	public Promise<object> SetConfiguration()
	{
		return CallMethod<Promise<object>>("setConfiguration", new object[0]);
	}

	public Promise<object> SetConfiguration(object configuration)
	{
		return CallMethod<Promise<object>>("setConfiguration", new object[1] { configuration });
	}

	public void ResumeContinuousFocus()
	{
		CallVoidMethod("resumeContinuousFocus");
	}

	public void StartFaceDetection()
	{
		CallVoidMethod("startFaceDetection");
	}

	public void StopFaceDetection()
	{
		CallVoidMethod("stopFaceDetection");
	}
}
