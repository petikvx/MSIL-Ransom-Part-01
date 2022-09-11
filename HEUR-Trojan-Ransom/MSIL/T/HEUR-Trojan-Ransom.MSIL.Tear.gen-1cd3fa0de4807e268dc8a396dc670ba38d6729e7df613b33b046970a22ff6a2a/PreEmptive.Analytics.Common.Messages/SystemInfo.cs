using System.Collections.Generic;
using PreEmptive.Analytics.Common.SystemProfileInfo;

namespace PreEmptive.Analytics.Common.Messages;

public class SystemInfo
{
	public IList<CpuInfo> Cpus = new List<CpuInfo>();

	public MemoryInfo Memory;

	public IList<DiskInfo> Disks = new List<DiskInfo>();

	public IList<NetworkInfo> Networks = new List<NetworkInfo>();

	public DomainInfo? Domain;

	public TimeInfo TimeZone;

	public IList<PageFileInfo> PageFiles = new List<PageFileInfo>();

	public ScreenInfo Screen;

	public VideoInfo Video;

	public SoundInfo Sound;

	public ModemInfo Modem;

	public TerminalServicesInfo TerminalServices;

	public string Manufacturer;

	public string Model;

	public string PowerState;
}
