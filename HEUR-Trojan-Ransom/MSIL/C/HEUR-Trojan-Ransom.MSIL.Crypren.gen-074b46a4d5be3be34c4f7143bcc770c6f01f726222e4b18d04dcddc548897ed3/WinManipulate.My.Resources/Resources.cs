using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WinManipulate.My.Resources;

[CompilerGenerated]
[HideModuleName]
[DebuggerNonUserCode]
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null) || 1 == 0)
			{
				ResourceManager resourceManager = default(ResourceManager);
				while (true)
				{
					int num = Class89.smethod_1(52);
					int num2 = -122;
					while (true)
					{
						num2 ^= Class84.smethod_0(41);
						while (true)
						{
							int num3 = Class84.smethod_0(377);
							while (true)
							{
								switch (num3 ^ Class84.smethod_0(16))
								{
								case 63:
									break;
								case 61:
									goto IL_00a1;
								case 62:
									num3 = 126;
									continue;
								default:
									goto end_IL_00b8;
								case 64:
									goto end_IL_00de;
								}
								switch (num2)
								{
								case -70:
									goto IL_003b;
								case -67:
									goto IL_0094;
								case -69:
									goto IL_00f2;
								case -68:
									goto end_IL_00f6;
								}
								num3 = 125;
								continue;
								IL_0094:
								num ^= Class84.smethod_0(383);
								goto IL_00a1;
								IL_00f2:
								num2 = -128;
								goto end_IL_00de;
								IL_003b:
								switch (num)
								{
								case -59:
									break;
								case -58:
									goto IL_0087;
								case -57:
									goto IL_0091;
								default:
									goto IL_00ec;
								case -56:
									goto end_IL_0104;
								}
								resourceManager = new ResourceManager(Class86.smethod_0("\uebaa\ueb94\ueb93\uebb0\ueb9c\ueb93\ueb94\ueb8d\ueb88\ueb91\ueb9c\ueb89\ueb98\uebd3\uebaf\ueb98\ueb8e\ueb92\ueb88\ueb8f\ueb9e\ueb98\ueb8e", 60269), typeof(Resources).Assembly);
								num = Class89.smethod_1(64);
								goto IL_0094;
								IL_00ec:
								num2 = -121;
								goto end_IL_00de;
								IL_0091:
								num = -16;
								goto IL_0094;
								IL_0087:
								resourceManager_0 = resourceManager;
								num = -1;
								goto IL_0094;
								IL_00a1:
								num2 = Class46.Class47.smethod_0(70);
								num3 = Class84.smethod_0(0);
								continue;
								end_IL_00b8:
								break;
							}
							continue;
							end_IL_00de:
							break;
						}
						continue;
						end_IL_00f6:
						break;
					}
					continue;
					end_IL_0104:
					break;
				}
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal static Bitmap Bitmap_0
	{
		get
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			object objectValue = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = Class46.Class47.smethod_0(72);
				while (true)
				{
					switch (num ^ Class84.smethod_0(76))
					{
					case -74:
						objectValue = RuntimeHelpers.GetObjectValue(Delegate23.smethod_0().GetObject(Class86.smethod_0("\uf899\uf898\uf89e\uf883\uf885\uf891", 63733), cultureInfo_0));
						num = -12;
						continue;
					case -75:
						result = (Bitmap)objectValue;
						num = -10;
						continue;
					case -76:
						num = -11;
						continue;
					case -73:
					case -72:
						return result;
					}
					break;
				}
			}
		}
	}

	internal static Bitmap Bitmap_1
	{
		get
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			object objectValue = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = Class89.smethod_1(57);
				while (true)
				{
					switch (num ^ Class84.smethod_0(41))
					{
					case -58:
						num = Class46.Class47.smethod_0(75);
						continue;
					case -60:
						objectValue = RuntimeHelpers.GetObjectValue(Delegate23.smethod_0().GetObject(Class86.smethod_0("\ue9c7\ue9db\ue9ce\ue9df", 59819), cultureInfo_0));
						num = -8;
						continue;
					case -61:
						result = (Bitmap)objectValue;
						num = -2;
						continue;
					case -59:
					case -57:
						return result;
					}
					break;
				}
			}
		}
	}

	internal static Bitmap Bitmap_2
	{
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object objectValue = default(object);
			while (true)
			{
				int num = Class46.Class47.smethod_0(65);
				while (true)
				{
					switch (num ^ Class84.smethod_0(384))
					{
					case -68:
						result = (Bitmap)objectValue;
						num = Class89.smethod_1(57);
						continue;
					case -69:
						objectValue = RuntimeHelpers.GetObjectValue(Delegate23.smethod_0().GetObject(Class86.smethod_0("\ue8ad\ue8b0\ue8a0\ue8a1\ue8af\ue8ba\ue8bd\ue8b5", 59477), cultureInfo_0));
						num = -2;
						continue;
					case -70:
						num = -8;
						continue;
					case -67:
					case -66:
						return result;
					}
					break;
				}
			}
		}
	}

	internal static Bitmap Bitmap_3
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			Bitmap result = default(Bitmap);
			object objectValue = default(object);
			while (true)
			{
				int num = Class46.Class47.smethod_0(79);
				while (true)
				{
					switch (num ^ Class84.smethod_0(388))
					{
					case -82:
						num = -21;
						continue;
					case -83:
						result = (Bitmap)objectValue;
						num = -23;
						continue;
					case -85:
						objectValue = RuntimeHelpers.GetObjectValue(Delegate23.smethod_0().GetObject(Class86.smethod_0("\uf64f\uf65d\uf654\uf654\uf657\uf648\uf645", 63038), cultureInfo_0));
						num = -24;
						continue;
					case -84:
					case -81:
						return result;
					}
					break;
				}
			}
		}
	}

	internal static Bitmap Bitmap_4
	{
		get
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			object objectValue = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = Class84.smethod_0(9);
				while (true)
				{
					switch (num ^ Class84.smethod_0(389))
					{
					case 87:
						num = 7;
						continue;
					case 85:
						objectValue = RuntimeHelpers.GetObjectValue(Delegate23.smethod_0().GetObject(Class86.smethod_0("\ue901\ue901\ue91f\ue916\ue901\ue90d", 59747), cultureInfo_0));
						num = 4;
						continue;
					case 84:
						result = (Bitmap)objectValue;
						num = 6;
						continue;
					case 86:
					case 88:
						return result;
					}
					break;
				}
			}
		}
	}
}
