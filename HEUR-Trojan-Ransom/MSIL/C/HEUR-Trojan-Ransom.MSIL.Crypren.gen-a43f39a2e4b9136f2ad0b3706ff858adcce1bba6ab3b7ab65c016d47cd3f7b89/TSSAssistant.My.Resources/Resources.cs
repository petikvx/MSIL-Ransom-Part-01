using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace TSSAssistant.My.Resources;

[CompilerGenerated]
[HideModuleName]
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
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
					int num = Class40.smethod_1(19);
					int num2 = -15;
					while (true)
					{
						num2 ^= Class45.smethod_0(18);
						while (true)
						{
							int num3 = Class33.smethod_1(22);
							while (true)
							{
								switch (num3 ^ Class45.smethod_0(69))
								{
								case -17:
									break;
								case -18:
									goto IL_002d;
								case -19:
									num3 = -2;
									continue;
								default:
									goto end_IL_00b5;
								case -16:
									goto end_IL_00db;
								}
								goto IL_001b;
								IL_002d:
								switch (num2)
								{
								case -9:
									goto IL_004d;
								case -8:
									goto IL_00a2;
								case -10:
									goto IL_00e6;
								case -11:
									goto end_IL_00ef;
								}
								num3 = -4;
								continue;
								IL_00e6:
								num2 = -1;
								goto end_IL_00db;
								IL_004d:
								switch (num)
								{
								case -11:
									break;
								case -10:
									goto IL_0070;
								case -9:
									goto IL_0099;
								default:
									goto IL_00eb;
								case -8:
									goto end_IL_00fd;
								}
								num = -5;
								goto IL_00a2;
								IL_00eb:
								num2 = -4;
								goto end_IL_00db;
								IL_0099:
								resourceManager_0 = resourceManager;
								num = -10;
								goto IL_00a2;
								IL_0070:
								resourceManager = new ResourceManager(Class47.smethod_0("\ue627\ue620\ue620\ue632\ue600\ue600\ue61a\ue600\ue607\ue612\ue61d\ue607\ue65d\ue621\ue616\ue600\ue61c\ue606\ue601\ue610\ue616\ue600", 58896), typeof(Resources).Assembly);
								num = -7;
								goto IL_00a2;
								IL_001b:
								num2 = Class33.smethod_1(29);
								num3 = -29;
								continue;
								IL_00a2:
								num ^= Class45.smethod_0(65);
								goto IL_001b;
								continue;
								end_IL_00b5:
								break;
							}
							continue;
							end_IL_00db:
							break;
						}
						continue;
						end_IL_00ef:
						break;
					}
					continue;
					end_IL_00fd:
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
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			object objectValue = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = Class45.smethod_0(89);
				while (true)
				{
					switch (num ^ Class45.smethod_0(82))
					{
					case 33:
						objectValue = RuntimeHelpers.GetObjectValue(Delegate17.smethod_0().GetObject(Class47.smethod_0("\ue810\ue810\ue811\ue80f\ue802\ue806\ue807", 59494), cultureInfo_0));
						num = 6;
						continue;
					case 31:
						result = (Bitmap)objectValue;
						num = 57;
						continue;
					case 30:
						num = Class45.smethod_0(16);
						continue;
					case 32:
					case 34:
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
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			object objectValue = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = Class33.smethod_1(25);
				while (true)
				{
					switch (num ^ Class45.smethod_0(82))
					{
					case -27:
						objectValue = RuntimeHelpers.GetObjectValue(Delegate17.smethod_0().GetObject(Class47.smethod_0("\uee19\uee00\uee05\uee0a\uee16\uee01\uee01\uee13", 61026), cultureInfo_0));
						num = -5;
						continue;
					case -28:
						num = -3;
						continue;
					case -30:
						result = (Bitmap)objectValue;
						num = -6;
						continue;
					case -29:
					case -26:
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
				int num = Class45.smethod_0(14);
				while (true)
				{
					switch (num ^ Class45.smethod_0(82))
					{
					case 28:
						result = (Bitmap)objectValue;
						num = 2;
						continue;
					case 26:
						objectValue = RuntimeHelpers.GetObjectValue(Delegate17.smethod_0().GetObject(Class47.smethod_0("\ue31b\ue316\ue31d\ue309\ue319\ue307\ue308", 58215), cultureInfo_0));
						num = Class45.smethod_0(15);
						continue;
					case 25:
						num = 0;
						continue;
					case 27:
					case 29:
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
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			object objectValue = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = Class33.smethod_1(25);
				while (true)
				{
					switch (num ^ Class45.smethod_0(34))
					{
					case -21:
						objectValue = RuntimeHelpers.GetObjectValue(Delegate17.smethod_0().GetObject(Class47.smethod_0("\ued99\ued95\ued8e\ued97\ued93\ued96\ued90", 60855), cultureInfo_0));
						num = -2;
						continue;
					case -22:
						num = -3;
						continue;
					case -23:
						result = (Bitmap)objectValue;
						num = -5;
						continue;
					case -20:
					case -19:
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
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			object objectValue = default(object);
			Bitmap result = default(Bitmap);
			while (true)
			{
				int num = Class45.smethod_0(9);
				while (true)
				{
					switch (num ^ Class45.smethod_0(91))
					{
					case 24:
						objectValue = RuntimeHelpers.GetObjectValue(Delegate17.smethod_0().GetObject(Class47.smethod_0("\uecbd\ueca6\uecb2\ueca9\uecac\uecb9\uecb6", 60632), cultureInfo_0));
						num = 15;
						continue;
					case 23:
						num = Class45.smethod_0(37);
						continue;
					case 21:
						result = (Bitmap)objectValue;
						num = 12;
						continue;
					case 22:
					case 25:
						return result;
					}
					break;
				}
			}
		}
	}
}
