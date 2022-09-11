using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.SystemProfileInfo;

namespace PreEmptive.Analytics.Common.Tags.SystemProfileTags;

public class DiskInfoTag : Tag
{
	[CompilerGenerated]
	private DiskInfo diskInfo_0;

	public override string TagName
	{
		get
		{
			int num = 6;
			int num2 = 1704;
			int num3 = num2;
			num2 = 1704;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return "\udeb6튿횡틅";
			}
		}
	}

	public DiskInfo Disk
	{
		[CompilerGenerated]
		get
		{
			int num = 16189;
			int num2 = num;
			num = 16189;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return diskInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -12395;
			int num2 = num;
			num = -12395;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			diskInfo_0 = value;
		}
	}

	public DiskInfoTag(DiskInfo disk)
	{
		AddOptionalAttribute("튡횿튨껋", disk.Size);
		AddOptionalAttribute("튴횤튷껋", disk.Free);
		AddOptionalAttribute("튼횷튿껋", disk.Name);
		AddOptionalAttribute("튴횥튦껗닂뛓", disk.Filesystem);
		AddOptionalAttribute("튡횳튠껇닓뛚", disk.Serial);
		Disk = disk;
	}
}
