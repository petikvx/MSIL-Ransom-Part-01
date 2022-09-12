using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Qsrjkm.Properties;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null || 1 == 0)
			{
				ResourceManager resourceManager = default(ResourceManager);
				while (true)
				{
					int num = Class5.smethod_0(15);
					int num2 = -13;
					while (true)
					{
						IL_00cf:
						num2 ^= 0x1A;
						int num3;
						while (true)
						{
							num3 = Class12.smethod_2(13);
							switch (num3 ^ 0x11)
							{
							case -16:
								goto end_IL_0018;
							case -17:
								goto IL_005e;
							case -15:
								goto IL_00cf;
							}
							continue;
							end_IL_0018:
							break;
						}
						switch (num2)
						{
						case -24:
							goto IL_0071;
						case -23:
							goto IL_00b9;
						case -25:
							goto end_IL_00cf;
						}
						num3 = -2;
						num3 = -17;
						goto IL_005e;
						IL_00b9:
						num ^= 0xD;
						num2 = Class12.smethod_2(19);
						num3 = -32;
						num3 = -15;
						continue;
						IL_005e:
						num2 = Class12.smethod_2(19);
						num3 = -32;
						num3 = -15;
						continue;
						IL_0071:
						switch (num)
						{
						case 22:
							goto IL_008c;
						case 23:
							goto IL_0097;
						case 24:
							goto end_IL_00db;
						}
						num2 = -3;
						continue;
						IL_0097:
						resourceManager = new ResourceManager(Class3.smethod_0(32349), typeof(Resources).Assembly);
						num = 27;
						goto IL_00b9;
						IL_008c:
						resourceManager_0 = resourceManager;
						num = 21;
						goto IL_00b9;
						continue;
						end_IL_00cf:
						break;
					}
					continue;
					end_IL_00db:
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

	internal static byte[] Byte_0
	{
		get
		{
			byte[] result = default(byte[]);
			object @object = default(object);
			while (true)
			{
				int num = Class12.smethod_2(32);
				int num2 = 1;
				while (true)
				{
					IL_00b9:
					num2 ^= 0x23;
					int num3;
					while (true)
					{
						num3 = Class12.smethod_2(40);
						switch (num3 ^ 0x21)
						{
						case 41:
							goto end_IL_0007;
						case 40:
							goto IL_004c;
						case 42:
							goto IL_00b9;
						}
						continue;
						end_IL_0007:
						break;
					}
					switch (num2)
					{
					case 33:
						goto IL_005e;
					case 34:
						goto IL_00a4;
					case 32:
						goto end_IL_00b9;
					}
					num3 = 9;
					num3 = 40;
					goto IL_004c;
					IL_00a4:
					num ^= 0x20;
					num2 = Class5.smethod_0(26);
					num3 = 11;
					num3 = 42;
					continue;
					IL_004c:
					num2 = Class5.smethod_0(26);
					num3 = 11;
					num3 = 42;
					continue;
					IL_005e:
					switch (num)
					{
					default:
						num2 = 3;
						continue;
					case -23:
						result = (byte[])@object;
						num = -56;
						break;
					case -22:
						@object = ResourceManager_0.GetObject(Class3.smethod_0(32612), cultureInfo_0);
						num = -55;
						break;
					case -24:
					case -21:
						return result;
					}
					goto IL_00a4;
					continue;
					end_IL_00b9:
					break;
				}
			}
		}
	}

	internal Resources()
	{
	}
}
