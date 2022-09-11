namespace CryptoNar;

public class UHWIDEngine
{
	private string _uID;

	private string _uIDW;

	private bool _includeWindows = false;

	public string SimpleUID => _uID;

	public string AdvancedUID => _uIDW;

	public UHWIDEngine()
	{
		doUniqueID();
	}

	private void doUniqueID()
	{
		string diskID = DiskID.getDiskID();
		string cpuID = CpuID.getCpuID();
		string windowsID = WindowsID.getWindowsID();
		_uID = diskID + cpuID;
		_uIDW = _uID + windowsID;
	}
}
