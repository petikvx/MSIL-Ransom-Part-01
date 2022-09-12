using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Filesystem;

public enum DeviceGuid
{
	[Description("6BDD1FC1-810F-11d0-BEC7-08002BE2092F")]
	Bus1394,
	[Description("7EBEFBC0-3200-11d2-B4C2-00A0C9697D07")]
	Guid61883,
	[Description("629758EE-986E-4D9E-8E47-DE27F8AB054D")]
	ApplicationLaunchButton,
	[Description("72631E54-78A4-11D0-BCF7-00AA00B7B32A")]
	Battery,
	[Description("4AFA3D52-74A7-11d0-be5e-00A0C9062857")]
	Lid,
	[Description("3FD0F03D-92E0-45FB-B75C-5ED8FFB01021")]
	Memory,
	[Description("CD48A365-FA94-4CE2-A232-A1B764E5D8B4")]
	MessageIndicator,
	[Description("97FADB10-4E33-40AE-359C-8BEF029DBDD0")]
	Processor,
	[Description("4AFA3D53-74A7-11d0-be5e-00A0C9062857")]
	SysButton,
	[Description("4AFA3D51-74A7-11d0-be5e-00A0C9062857")]
	ThermalZone,
	[Description("0850302A-B344-4fda-9BE9-90576B8D46F0")]
	Bluetooth,
	[Description("FDE5BBA4-B3F9-46FB-BDAA-0728CE3100B4")]
	Brightness,
	[Description("5B45201D-F2F2-4F3B-85BB-30FF1F953599")]
	DisplayAdapter,
	[Description("2564AA4F-DDDB-4495-B497-6AD4A84163D7")]
	I2C,
	[Description("6BDD1FC6-810F-11D0-BEC7-08002BE2092F")]
	StillImage,
	[Description("E6F07B5F-EE97-4a90-B076-33F57BF4EAA7")]
	Monitor,
	[Description("BF4672DE-6B4E-4BE4-A325-68A91EA49C09")]
	OutputProtectionManagement,
	[Description("1AD9E4F0-F88D-4360-BAB9-4C2D55E564CD")]
	VideoOutputArrival,
	[Description("1CA05180-A699-450A-9A0C-DE4FBE3DDD89")]
	DisplayDeviceArrival,
	[Description("4D1E55B2-F16F-11CF-88CB-001111000030")]
	Hid,
	[Description("4D1E55B2-F16F-11CF-88CB-001111000030")]
	Keyboard,
	[Description("378DE44C-56EF-11D1-BC8C-00A0C91405DD")]
	Mouse,
	[Description("2C7089AA-2E0E-11D1-B114-00C04FC2AAE4")]
	Modem,
	[Description("CAC88484-7515-4C03-82E6-71A87ABAC361")]
	Network,
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ComPort")]
	[Description("86E0D1E0-8089-11D0-9CE4-08003E301F73")]
	ComPort,
	[Description("97F76EF0-F883-11D0-AF1F-0000F800845C")]
	Parallel,
	[Description("811FC6A5-F728-11D0-A537-0000F8753ED1")]
	ParallelClass,
	[Description("4D36E978-E325-11CE-BFC1-08002BE10318")]
	SerialEnumBusEnumerator,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Cdrom")]
	[Description("53F56312-B6BF-11D0-94F2-00A0C91EFB8B")]
	CdromChanger,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Cdrom")]
	[Description("53F56308-B6BF-11D0-94F2-00A0C91EFB8B")]
	Cdrom,
	[Description("53F56307-B6BF-11D0-94F2-00A0C91EFB8B")]
	Disk,
	[Description("53F56311-B6BF-11D0-94F2-00A0C91EFB8B")]
	Floppy,
	[Description("53F56310-B6BF-11D0-94F2-00A0C91EFB8B")]
	MediumChanger,
	[Description("53F5630A-B6BF-11D0-94F2-00A0C91EFB8B")]
	Partition,
	[Description("2ACCFE60-C130-11D2-B082-00A0C91EFB8B")]
	StoragePort,
	[Description("53F5630B-B6BF-11D0-94F2-00A0C91EFB8B")]
	Tape,
	[Description("53F5630D-B6BF-11D0-94F2-00A0C91EFB8B")]
	Volume,
	[Description("53F5630C-B6BF-11D0-94F2-00A0C91EFB8B")]
	WriteOnceDisk,
	[Description("A5DCBF10-6530-11D2-901F-00C04FB951ED")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Usb")]
	UsbDevice,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Usb")]
	[Description("3ABF6F2D-71C4-462A-8A92-1E6861E6AF27")]
	UsbHostController,
	[Description("F18A0E88-C30C-11D0-8815-00A0C906BED8")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Usb")]
	UsbHub,
	[Description("6AC27878-A6FA-4155-BA85-F98F491D4F33")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Wpd")]
	Wpd,
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Wpd")]
	[Description("BA0C718F-4DED-49B7-BDD3-FABE28661211")]
	WpdPrivate
}
