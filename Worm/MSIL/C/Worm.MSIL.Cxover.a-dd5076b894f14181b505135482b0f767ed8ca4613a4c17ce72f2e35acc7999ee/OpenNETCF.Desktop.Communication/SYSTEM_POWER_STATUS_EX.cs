namespace OpenNETCF.Desktop.Communication;

public struct SYSTEM_POWER_STATUS_EX
{
	public byte ACLineStatus;

	public byte BatteryFlag;

	public byte BatteryLifePercent;

	internal byte Reserved1;

	public int BatteryLifeTime;

	public int BatteryFullLifeTime;

	internal byte Reserved2;

	public byte BackupBatteryFlag;

	public byte BackupBatteryLifePercent;

	internal byte Reserved3;

	public int BackupBatteryLifeTime;

	public int BackupBatteryFullLifeTime;
}
