using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PreEmptive.Analytics.Common.Tags;

public class UserTag : Tag
{
	[CompilerGenerated]
	private UserInfo userInfo_0;

	public override string TagName
	{
		get
		{
			int num = 2;
			int num2 = -555;
			int num3 = num2;
			num2 = -555;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return "횧튭\udeb7튤";
			}
		}
	}

	public UserInfo UserInfo
	{
		[CompilerGenerated]
		get
		{
			if (1 == 0)
			{
			}
			int num = 12466;
			int num2 = num;
			num = 12466;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return userInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = 26439;
			int num2 = num;
			num = 26439;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			userInfo_0 = value;
		}
	}

	public UserTag(UserInfo userInfo, bool omitPII, [Optional] string fallbackName)
	{
		int num = 14;
		base._002Ector();
		if (omitPII)
		{
			userInfo.IsAdmin = null;
			userInfo.HashedName = fallbackName;
		}
		if (string.IsNullOrEmpty(userInfo.HashedName))
		{
			if (omitPII)
			{
				userInfo.HashedName = Guid.NewGuid().ToString();
			}
			else
			{
				userInfo.HashedName = userInfo.InstanceID ?? Guid.NewGuid().ToString();
			}
		}
		UserInfo = userInfo;
		AddAttribute("껜닗뛟닛", userInfo.HashedName);
		if (userInfo.IsAdmin.HasValue)
		{
			AddAttribute("껓닒뛟닗뻜", userInfo.IsAdmin.ToString()!.ToLowerInvariant());
		}
	}
}
