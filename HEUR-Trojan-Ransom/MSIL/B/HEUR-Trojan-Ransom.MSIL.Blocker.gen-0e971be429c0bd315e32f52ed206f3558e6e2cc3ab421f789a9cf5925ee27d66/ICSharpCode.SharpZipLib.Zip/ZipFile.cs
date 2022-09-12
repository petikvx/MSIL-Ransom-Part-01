using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Encryption;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip;

public class ZipFile : IDisposable, IEnumerable
{
	[Flags]
	private enum xuMBRnuFHhXnkKwomiUMzNClIAVe
	{
		Extract = 1,
		Header = 2
	}

	public delegate void KeysRequiredEventHandler(object sender, KeysRequiredEventArgs e);

	private class MUaBThaLPSOmRiVcsFzePGqcabqCA : Stream
	{
		private Stream oSQdSCBxoNkCmkErffiTQbNitoGd;

		private long ouuAsufedfbUFQuchUFsVYcflmKb;

		private long MyLYIEFqGXZGgPkSlUJbGGmIFwpBA;

		private long BShTQyklEfSolQvBihSXFfXEyojg;

		private long SQsdGvTBUvuOeDcYZPOxMIntAweC;

		private ZipFile YWcZOOdhJvCLkNXCwAijEUDPtuCuA;

		bool Stream.CanRead => true;

		bool Stream.CanSeek => true;

		bool Stream.CanTimeout => oSQdSCBxoNkCmkErffiTQbNitoGd.CanTimeout;

		bool Stream.CanWrite => false;

		long Stream.Length => MyLYIEFqGXZGgPkSlUJbGGmIFwpBA;

		long Stream.Position
		{
			get
			{
				return BShTQyklEfSolQvBihSXFfXEyojg - SQsdGvTBUvuOeDcYZPOxMIntAweC;
			}
			set
			{
				long num = SQsdGvTBUvuOeDcYZPOxMIntAweC + value;
				if (num >= SQsdGvTBUvuOeDcYZPOxMIntAweC)
				{
					if (num >= ouuAsufedfbUFQuchUFsVYcflmKb)
					{
						throw new InvalidOperationException(_003CModule_003E.smethod_4<string>(1983592477u));
					}
					BShTQyklEfSolQvBihSXFfXEyojg = num;
					return;
				}
				throw new ArgumentException(_003CModule_003E.smethod_6<string>(4166892953u));
			}
		}

		public MUaBThaLPSOmRiVcsFzePGqcabqCA(ZipFile zipFile, long start, long length)
		{
			SQsdGvTBUvuOeDcYZPOxMIntAweC = start;
			MyLYIEFqGXZGgPkSlUJbGGmIFwpBA = length;
			YWcZOOdhJvCLkNXCwAijEUDPtuCuA = zipFile;
			oSQdSCBxoNkCmkErffiTQbNitoGd = YWcZOOdhJvCLkNXCwAijEUDPtuCuA.oSQdSCBxoNkCmkErffiTQbNitoGd;
			BShTQyklEfSolQvBihSXFfXEyojg = start;
			ouuAsufedfbUFQuchUFsVYcflmKb = start + length;
		}

		public override void zdebThhIbLmIaDlrgliyWnaFMaHzb()
		{
		}

		public override void THnSEfXDiaoRRUtYFkqYfqwEkNYD()
		{
		}

		public override int FkobfSfTCZRkGaiBpxAxBcTiTXviA(byte[] buffer, int offset, int count)
		{
			lock (oSQdSCBxoNkCmkErffiTQbNitoGd)
			{
				if (count > ouuAsufedfbUFQuchUFsVYcflmKb - BShTQyklEfSolQvBihSXFfXEyojg)
				{
					count = (int)(ouuAsufedfbUFQuchUFsVYcflmKb - BShTQyklEfSolQvBihSXFfXEyojg);
					if (count == 0)
					{
						return 0;
					}
				}
				oSQdSCBxoNkCmkErffiTQbNitoGd.Seek(BShTQyklEfSolQvBihSXFfXEyojg, SeekOrigin.Begin);
				int num = oSQdSCBxoNkCmkErffiTQbNitoGd.Read(buffer, offset, count);
				if (num > 0)
				{
					BShTQyklEfSolQvBihSXFfXEyojg += num;
				}
				return num;
			}
		}

		public override int cWiQHoDjbEtNHTfSzIDeKmiuHweW()
		{
			if (BShTQyklEfSolQvBihSXFfXEyojg >= ouuAsufedfbUFQuchUFsVYcflmKb)
			{
				return -1;
			}
			lock (oSQdSCBxoNkCmkErffiTQbNitoGd)
			{
				long offset = BShTQyklEfSolQvBihSXFfXEyojg++;
				oSQdSCBxoNkCmkErffiTQbNitoGd.Seek(offset, SeekOrigin.Begin);
				return oSQdSCBxoNkCmkErffiTQbNitoGd.ReadByte();
			}
		}

		public override long qyGcwWUBOOzpOZKJixOcQHCoWYUs(long offset, SeekOrigin origin)
		{
			long num = BShTQyklEfSolQvBihSXFfXEyojg;
			switch (origin)
			{
			case SeekOrigin.Begin:
				num = SQsdGvTBUvuOeDcYZPOxMIntAweC + offset;
				break;
			case SeekOrigin.Current:
				num = BShTQyklEfSolQvBihSXFfXEyojg + offset;
				break;
			case SeekOrigin.End:
				num = ouuAsufedfbUFQuchUFsVYcflmKb + offset;
				break;
			}
			if (num < SQsdGvTBUvuOeDcYZPOxMIntAweC)
			{
				throw new ArgumentException(_003CModule_003E.smethod_6<string>(4166892953u));
			}
			if (num >= ouuAsufedfbUFQuchUFsVYcflmKb)
			{
				throw new IOException(_003CModule_003E.smethod_2<string>(2846446993u));
			}
			BShTQyklEfSolQvBihSXFfXEyojg = num;
			return BShTQyklEfSolQvBihSXFfXEyojg;
		}

		public override void KPCDkqqUOjVuLymtiDgOLHHfvudB(long value)
		{
			throw new NotSupportedException();
		}

		public override void cKylBARGjjaXUVmEnDrJyuQyEqAk(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}
	}

	private class bvyWMmVbnCSBLnEoFiiwRaEybKHFA : Stream
	{
		private Stream oSQdSCBxoNkCmkErffiTQbNitoGd;

		bool Stream.CanRead => false;

		bool Stream.CanSeek => false;

		bool Stream.CanWrite => oSQdSCBxoNkCmkErffiTQbNitoGd.CanWrite;

		long Stream.Length => 0L;

		long Stream.Position
		{
			get
			{
				return oSQdSCBxoNkCmkErffiTQbNitoGd.Position;
			}
			set
			{
			}
		}

		public bvyWMmVbnCSBLnEoFiiwRaEybKHFA(Stream baseStream)
		{
			oSQdSCBxoNkCmkErffiTQbNitoGd = baseStream;
		}

		public override void zdebThhIbLmIaDlrgliyWnaFMaHzb()
		{
		}

		public override void THnSEfXDiaoRRUtYFkqYfqwEkNYD()
		{
			oSQdSCBxoNkCmkErffiTQbNitoGd.Flush();
		}

		public override int FkobfSfTCZRkGaiBpxAxBcTiTXviA(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override long qyGcwWUBOOzpOZKJixOcQHCoWYUs(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void KPCDkqqUOjVuLymtiDgOLHHfvudB(long value)
		{
		}

		public override void cKylBARGjjaXUVmEnDrJyuQyEqAk(byte[] buffer, int offset, int count)
		{
			oSQdSCBxoNkCmkErffiTQbNitoGd.Write(buffer, offset, count);
		}
	}

	private enum OrnxgiJlSmPauttbqOavFmSOWvIA
	{
		Copy,
		Modify,
		Add
	}

	private class WrEbEWxHJOLPYCWqbyUtcgkVaaCJ : IComparer
	{
		public int Compare(object object_0, object object_1)
		{
			thPpzZXBmOvoFyICpxWtjCreRqDO thPpzZXBmOvoFyICpxWtjCreRqDO = object_0 as thPpzZXBmOvoFyICpxWtjCreRqDO;
			thPpzZXBmOvoFyICpxWtjCreRqDO thPpzZXBmOvoFyICpxWtjCreRqDO2 = object_1 as thPpzZXBmOvoFyICpxWtjCreRqDO;
			if (thPpzZXBmOvoFyICpxWtjCreRqDO != null)
			{
				if (thPpzZXBmOvoFyICpxWtjCreRqDO2 != null)
				{
					int num = ((thPpzZXBmOvoFyICpxWtjCreRqDO.MnlddAHZNGTZhkXsczABGSOSLbPO != 0 && thPpzZXBmOvoFyICpxWtjCreRqDO.MnlddAHZNGTZhkXsczABGSOSLbPO != OrnxgiJlSmPauttbqOavFmSOWvIA.Modify) ? 1 : 0);
					int num2 = ((thPpzZXBmOvoFyICpxWtjCreRqDO2.MnlddAHZNGTZhkXsczABGSOSLbPO != 0 && thPpzZXBmOvoFyICpxWtjCreRqDO2.MnlddAHZNGTZhkXsczABGSOSLbPO != OrnxgiJlSmPauttbqOavFmSOWvIA.Modify) ? 1 : 0);
					int num3 = num - num2;
					if (num3 != 0)
					{
						return num3;
					}
					long num4 = thPpzZXBmOvoFyICpxWtjCreRqDO.NXAdZPyzVYHlwYykTFLjZCIXlZJN.Offset - thPpzZXBmOvoFyICpxWtjCreRqDO2.NXAdZPyzVYHlwYykTFLjZCIXlZJN.Offset;
					if (num4 < 0L)
					{
						return -1;
					}
					if (num4 == 0L)
					{
						return 0;
					}
				}
				return 1;
			}
			if (thPpzZXBmOvoFyICpxWtjCreRqDO2 == null)
			{
				return 0;
			}
			return -1;
		}
	}

	private class XvHVdBrpKOmvGAADdTVJJSzGvbQF : IEnumerator
	{
		private ZipEntry[] GwxbaDEjMcDsIesHuiCsoNNGHKcAb;

		private int oGxDqfIJweFrZEgdgcgVQrScUbLW = -1;

		public object Current => GwxbaDEjMcDsIesHuiCsoNNGHKcAb[oGxDqfIJweFrZEgdgcgVQrScUbLW];

		public XvHVdBrpKOmvGAADdTVJJSzGvbQF(ZipEntry[] entries)
		{
			GwxbaDEjMcDsIesHuiCsoNNGHKcAb = entries;
		}

		public bool MoveNext()
		{
			return ++oGxDqfIJweFrZEgdgcgVQrScUbLW < GwxbaDEjMcDsIesHuiCsoNNGHKcAb.Length;
		}

		public void Reset()
		{
			oGxDqfIJweFrZEgdgcgVQrScUbLW = -1;
		}
	}

	private class usHPSPuHXHIIepTmquPhrjDhInpV
	{
		private string bKEqJOElwYfNiaJgeQwIUnSIKHTT;

		private bool bMKvpOKEJgzkcpkGhXfATsoZcNul;

		private byte[] RZjOtsQYSFnLoPIlfggAbmlvpmGtA;

		public bool DeltVoAobJsCDhqirDpIgrOFXikMA => bMKvpOKEJgzkcpkGhXfATsoZcNul;

		public byte[] xwFGxtvSwXdLGGnYPhhxeSqizALAb
		{
			get
			{
				VCxeEIjlEAUFmoBnVVQIJNxLgOyMA();
				return (byte[])RZjOtsQYSFnLoPIlfggAbmlvpmGtA.Clone();
			}
		}

		public int rqsuuEnzQrNTXyiaaHxrmaTtOFVk
		{
			get
			{
				VCxeEIjlEAUFmoBnVVQIJNxLgOyMA();
				return RZjOtsQYSFnLoPIlfggAbmlvpmGtA.Length;
			}
		}

		public usHPSPuHXHIIepTmquPhrjDhInpV(string comment)
		{
			bKEqJOElwYfNiaJgeQwIUnSIKHTT = comment;
			bMKvpOKEJgzkcpkGhXfATsoZcNul = true;
		}

		public usHPSPuHXHIIepTmquPhrjDhInpV(byte[] rawString)
		{
			RZjOtsQYSFnLoPIlfggAbmlvpmGtA = rawString;
		}

		private void VCxeEIjlEAUFmoBnVVQIJNxLgOyMA()
		{
			if (RZjOtsQYSFnLoPIlfggAbmlvpmGtA == null)
			{
				RZjOtsQYSFnLoPIlfggAbmlvpmGtA = ZipConstants.ConvertToArray(bKEqJOElwYfNiaJgeQwIUnSIKHTT);
			}
		}

		private void OaxwbxghPEwyIYaZJXcuRyjjQWnj()
		{
			if (bKEqJOElwYfNiaJgeQwIUnSIKHTT == null)
			{
				bKEqJOElwYfNiaJgeQwIUnSIKHTT = ZipConstants.ConvertToString(RZjOtsQYSFnLoPIlfggAbmlvpmGtA);
			}
		}

		[SpecialName]
		public static string BCAgBxbWQAUoSCvLuqySRLoTyiRq(usHPSPuHXHIIepTmquPhrjDhInpV zipString)
		{
			zipString.OaxwbxghPEwyIYaZJXcuRyjjQWnj();
			return zipString.bKEqJOElwYfNiaJgeQwIUnSIKHTT;
		}

		public void QAUcQcqMSxkpfuvnEqzXciYpNlzb()
		{
			if (bMKvpOKEJgzkcpkGhXfATsoZcNul)
			{
				RZjOtsQYSFnLoPIlfggAbmlvpmGtA = null;
			}
			else
			{
				bKEqJOElwYfNiaJgeQwIUnSIKHTT = null;
			}
		}
	}

	private class thPpzZXBmOvoFyICpxWtjCreRqDO
	{
		private OrnxgiJlSmPauttbqOavFmSOWvIA IYEDUoncSiqBBFlZcXgovITbklOy;

		private long PCYPMDunQufvHUHJliFMGNSsZfBBA;

		private IStaticDataSource pUiWpTKxydHRVwSmgcBYCTeggxtC;

		private ZipEntry cFaVCaZYpKaXBFhZzmswBJGtfGQcA;

		private string IJjcZGPLocAnoOaSYhIvsJbSpRsj;

		private ZipEntry DqQQJoKXeMOwXdAzNMTqmcdqQipS;

		private long eZlntIOhLhRMbuWzbLhgvjisBPNIA;

		public OrnxgiJlSmPauttbqOavFmSOWvIA MnlddAHZNGTZhkXsczABGSOSLbPO => IYEDUoncSiqBBFlZcXgovITbklOy;

		public long UXNqdVumXwceIdwPXloWfcbNSWelA
		{
			get
			{
				return PCYPMDunQufvHUHJliFMGNSsZfBBA;
			}
			set
			{
				PCYPMDunQufvHUHJliFMGNSsZfBBA = value;
			}
		}

		public ZipEntry NXAdZPyzVYHlwYykTFLjZCIXlZJN => cFaVCaZYpKaXBFhZzmswBJGtfGQcA;

		public string XVltgDeunXTAEHlFxUOpyCdKxUvw => IJjcZGPLocAnoOaSYhIvsJbSpRsj;

		public ZipEntry ugCHqYYazdEMfCldUEWGbhxGqBtlb
		{
			get
			{
				if (DqQQJoKXeMOwXdAzNMTqmcdqQipS == null)
				{
					DqQQJoKXeMOwXdAzNMTqmcdqQipS = (ZipEntry)cFaVCaZYpKaXBFhZzmswBJGtfGQcA.Clone();
				}
				return DqQQJoKXeMOwXdAzNMTqmcdqQipS;
			}
		}

		public long kWXcHxqzOtbcDwaBDZwcxSqScTvO
		{
			get
			{
				return eZlntIOhLhRMbuWzbLhgvjisBPNIA;
			}
			set
			{
				eZlntIOhLhRMbuWzbLhgvjisBPNIA = value;
			}
		}

		public thPpzZXBmOvoFyICpxWtjCreRqDO(ZipEntry entry)
			: this(OrnxgiJlSmPauttbqOavFmSOWvIA.Copy, entry)
		{
		}

		public thPpzZXBmOvoFyICpxWtjCreRqDO(IStaticDataSource dataSource, ZipEntry entry)
		{
			eZlntIOhLhRMbuWzbLhgvjisBPNIA = -1L;
			PCYPMDunQufvHUHJliFMGNSsZfBBA = -1L;
			IYEDUoncSiqBBFlZcXgovITbklOy = OrnxgiJlSmPauttbqOavFmSOWvIA.Add;
			cFaVCaZYpKaXBFhZzmswBJGtfGQcA = entry;
			pUiWpTKxydHRVwSmgcBYCTeggxtC = dataSource;
		}

		public thPpzZXBmOvoFyICpxWtjCreRqDO(ZipEntry original, ZipEntry updated)
		{
			eZlntIOhLhRMbuWzbLhgvjisBPNIA = -1L;
			PCYPMDunQufvHUHJliFMGNSsZfBBA = -1L;
			throw new ZipException(_003CModule_003E.smethod_5<string>(2710609613u));
		}

		public thPpzZXBmOvoFyICpxWtjCreRqDO(OrnxgiJlSmPauttbqOavFmSOWvIA command, ZipEntry entry)
		{
			eZlntIOhLhRMbuWzbLhgvjisBPNIA = -1L;
			PCYPMDunQufvHUHJliFMGNSsZfBBA = -1L;
			IYEDUoncSiqBBFlZcXgovITbklOy = command;
			cFaVCaZYpKaXBFhZzmswBJGtfGQcA = (ZipEntry)entry.Clone();
		}

		public thPpzZXBmOvoFyICpxWtjCreRqDO(string fileName, ZipEntry entry)
		{
			eZlntIOhLhRMbuWzbLhgvjisBPNIA = -1L;
			PCYPMDunQufvHUHJliFMGNSsZfBBA = -1L;
			IYEDUoncSiqBBFlZcXgovITbklOy = OrnxgiJlSmPauttbqOavFmSOWvIA.Add;
			cFaVCaZYpKaXBFhZzmswBJGtfGQcA = entry;
			IJjcZGPLocAnoOaSYhIvsJbSpRsj = fileName;
		}

		[Obsolete]
		public thPpzZXBmOvoFyICpxWtjCreRqDO(string fileName, string entryName)
			: this(fileName, entryName, CompressionMethod.Deflated)
		{
		}

		[Obsolete]
		public thPpzZXBmOvoFyICpxWtjCreRqDO(IStaticDataSource dataSource, string entryName, CompressionMethod compressionMethod)
		{
			eZlntIOhLhRMbuWzbLhgvjisBPNIA = -1L;
			PCYPMDunQufvHUHJliFMGNSsZfBBA = -1L;
			IYEDUoncSiqBBFlZcXgovITbklOy = OrnxgiJlSmPauttbqOavFmSOWvIA.Add;
			cFaVCaZYpKaXBFhZzmswBJGtfGQcA = new ZipEntry(entryName);
			cFaVCaZYpKaXBFhZzmswBJGtfGQcA.CompressionMethod = compressionMethod;
			pUiWpTKxydHRVwSmgcBYCTeggxtC = dataSource;
		}

		[Obsolete]
		public thPpzZXBmOvoFyICpxWtjCreRqDO(string fileName, string entryName, CompressionMethod compressionMethod)
		{
			eZlntIOhLhRMbuWzbLhgvjisBPNIA = -1L;
			PCYPMDunQufvHUHJliFMGNSsZfBBA = -1L;
			IYEDUoncSiqBBFlZcXgovITbklOy = OrnxgiJlSmPauttbqOavFmSOWvIA.Add;
			cFaVCaZYpKaXBFhZzmswBJGtfGQcA = new ZipEntry(entryName);
			cFaVCaZYpKaXBFhZzmswBJGtfGQcA.CompressionMethod = compressionMethod;
			IJjcZGPLocAnoOaSYhIvsJbSpRsj = fileName;
		}

		public Stream gwEXgeoFldTESiQPwNRiHeEGLDmL()
		{
			Stream result = null;
			if (pUiWpTKxydHRVwSmgcBYCTeggxtC != null)
			{
				result = pUiWpTKxydHRVwSmgcBYCTeggxtC.GetSource();
			}
			return result;
		}
	}

	private IArchiveStorage dVoxdaUowkecEDFiANVGvbrLsMtPA;

	private Stream oSQdSCBxoNkCmkErffiTQbNitoGd;

	private int UmklLlbllLOhNJXjXDoBGkiRDmyR;

	private byte[] FnNczgeTiwCRfrmMSzVbtHOBuXHF;

	private string bKEqJOElwYfNiaJgeQwIUnSIKHTT;

	private bool sxHszzHnHRSgwWeizkQqamyfNKTH;

	private bool zEPFoRrUcxRVDtXjdFoorsbpBqmy;

	private byte[] goVmdMtFztsdhTpDJGlFvZRqbanw;

	private const int RUJhItVRHbAScneItPnyIcMjggJA = 4096;

	private ZipEntry[] FepEnkzlfCEEYbpcNpgADMHBvbSBA;

	private bool jyMCZdrdfTgaMCMnZDfFILWcWueNb;

	private bool pbFCeDjePibKuCThtdWRJFnEOqieb;

	private bool tTMSyxFlQfXCQfFhbrPnqimGRjzK;

	public KeysRequiredEventHandler KeysRequired;

	private string sHzRvUailBFDiYKMmGMjRZIxxzc;

	private usHPSPuHXHIIepTmquPhrjDhInpV xcYEgbCHsfkbRUrlEDuqXvxyBJHs;

	private long sTndfsDVLvLWJtATbmmFqOoFIizeA;

	private long DhtwVxPonFDVAZIaDILDZUjDYGlw;

	private IDynamicDataSource GkbUCAVbELlWmfDleedewYjRoQyl;

	private IEntryFactory mCBWENDSMtHghmeWZuahOsAupJFG;

	private Hashtable uVXdFEfRBBELttmcDmgqjyofsWbdb;

	private ArrayList giGRnjjpSMDOUnRSciXGooOFTiui;

	private UseZip64 bKsRPzWeosiiVJMdrYkiLDpYbLKcA;

	public int BufferSize
	{
		get
		{
			return UmklLlbllLOhNJXjXDoBGkiRDmyR;
		}
		set
		{
			if (value < 1024)
			{
				throw new ArgumentOutOfRangeException("value", "cannot be below 1024");
			}
			if (UmklLlbllLOhNJXjXDoBGkiRDmyR != value)
			{
				UmklLlbllLOhNJXjXDoBGkiRDmyR = value;
				goVmdMtFztsdhTpDJGlFvZRqbanw = null;
			}
		}
	}

	public long Count => FepEnkzlfCEEYbpcNpgADMHBvbSBA.Length;

	public ZipEntry this[int index] => (ZipEntry)FepEnkzlfCEEYbpcNpgADMHBvbSBA[index].Clone();

	public IEntryFactory EntryFactory
	{
		get
		{
			return mCBWENDSMtHghmeWZuahOsAupJFG;
		}
		set
		{
			if (value != null)
			{
				mCBWENDSMtHghmeWZuahOsAupJFG = value;
			}
			else
			{
				mCBWENDSMtHghmeWZuahOsAupJFG = new ZipEntryFactory();
			}
		}
	}

	private bool KfsVPVxIMSAjvjzaXuKzjciricrbb => FnNczgeTiwCRfrmMSzVbtHOBuXHF != null;

	public bool IsEmbeddedArchive => sTndfsDVLvLWJtATbmmFqOoFIizeA > 0L;

	public bool IsNewArchive => pbFCeDjePibKuCThtdWRJFnEOqieb;

	public bool IsStreamOwner
	{
		get
		{
			return tTMSyxFlQfXCQfFhbrPnqimGRjzK;
		}
		set
		{
			tTMSyxFlQfXCQfFhbrPnqimGRjzK = value;
		}
	}

	public bool IsUpdating => giGRnjjpSMDOUnRSciXGooOFTiui != null;

	private byte[] EKWlTccqDWgNOdCVOullQNLjBMqmA
	{
		get
		{
			return FnNczgeTiwCRfrmMSzVbtHOBuXHF;
		}
		set
		{
			FnNczgeTiwCRfrmMSzVbtHOBuXHF = value;
		}
	}

	public string Name => sHzRvUailBFDiYKMmGMjRZIxxzc;

	public INameTransform NameTransform
	{
		get
		{
			return mCBWENDSMtHghmeWZuahOsAupJFG.NameTransform;
		}
		set
		{
			mCBWENDSMtHghmeWZuahOsAupJFG.NameTransform = value;
		}
	}

	public string Password
	{
		set
		{
			if (value != null && value.Length != 0)
			{
				FnNczgeTiwCRfrmMSzVbtHOBuXHF = PkzipClassic.GenerateKeys(ZipConstants.ConvertToArray(value));
			}
			else
			{
				FnNczgeTiwCRfrmMSzVbtHOBuXHF = null;
			}
		}
	}

	[Obsolete("Use the Count property instead")]
	public int Size => FepEnkzlfCEEYbpcNpgADMHBvbSBA.Length;

	public UseZip64 UseZip64
	{
		get
		{
			return bKsRPzWeosiiVJMdrYkiLDpYbLKcA;
		}
		set
		{
			bKsRPzWeosiiVJMdrYkiLDpYbLKcA = value;
		}
	}

	public string ZipFileComment => bKEqJOElwYfNiaJgeQwIUnSIKHTT;

	internal ZipFile()
	{
		bKsRPzWeosiiVJMdrYkiLDpYbLKcA = UseZip64.Dynamic;
		UmklLlbllLOhNJXjXDoBGkiRDmyR = 4096;
		mCBWENDSMtHghmeWZuahOsAupJFG = new ZipEntryFactory();
		FepEnkzlfCEEYbpcNpgADMHBvbSBA = new ZipEntry[0];
		pbFCeDjePibKuCThtdWRJFnEOqieb = true;
	}

	public ZipFile(FileStream file)
	{
		bKsRPzWeosiiVJMdrYkiLDpYbLKcA = UseZip64.Dynamic;
		UmklLlbllLOhNJXjXDoBGkiRDmyR = 4096;
		mCBWENDSMtHghmeWZuahOsAupJFG = new ZipEntryFactory();
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		if (file.CanSeek)
		{
			oSQdSCBxoNkCmkErffiTQbNitoGd = file;
			sHzRvUailBFDiYKMmGMjRZIxxzc = file.Name;
			tTMSyxFlQfXCQfFhbrPnqimGRjzK = true;
			try
			{
				xOfyZuIzvAugbytjrnpdUMiBeUuHA();
				return;
			}
			catch
			{
				qZFSnoWQnTHbIWtpZPkDNbJfuMu(disposing: true);
				throw;
			}
		}
		throw new ArgumentException("Stream is not seekable", "file");
	}

	public ZipFile(Stream stream)
	{
		bKsRPzWeosiiVJMdrYkiLDpYbLKcA = UseZip64.Dynamic;
		UmklLlbllLOhNJXjXDoBGkiRDmyR = 4096;
		mCBWENDSMtHghmeWZuahOsAupJFG = new ZipEntryFactory();
		if (stream != null)
		{
			if (!stream.CanSeek)
			{
				throw new ArgumentException("Stream is not seekable", "stream");
			}
			oSQdSCBxoNkCmkErffiTQbNitoGd = stream;
			tTMSyxFlQfXCQfFhbrPnqimGRjzK = true;
			if (oSQdSCBxoNkCmkErffiTQbNitoGd.Length > 0L)
			{
				try
				{
					xOfyZuIzvAugbytjrnpdUMiBeUuHA();
					return;
				}
				catch
				{
					qZFSnoWQnTHbIWtpZPkDNbJfuMu(disposing: true);
					throw;
				}
			}
			FepEnkzlfCEEYbpcNpgADMHBvbSBA = new ZipEntry[0];
			pbFCeDjePibKuCThtdWRJFnEOqieb = true;
			return;
		}
		throw new ArgumentNullException("stream");
	}

	public ZipFile(string name)
	{
		bKsRPzWeosiiVJMdrYkiLDpYbLKcA = UseZip64.Dynamic;
		UmklLlbllLOhNJXjXDoBGkiRDmyR = 4096;
		mCBWENDSMtHghmeWZuahOsAupJFG = new ZipEntryFactory();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		sHzRvUailBFDiYKMmGMjRZIxxzc = name;
		oSQdSCBxoNkCmkErffiTQbNitoGd = File.OpenRead(name);
		tTMSyxFlQfXCQfFhbrPnqimGRjzK = true;
		try
		{
			xOfyZuIzvAugbytjrnpdUMiBeUuHA();
		}
		catch
		{
			qZFSnoWQnTHbIWtpZPkDNbJfuMu(disposing: true);
			throw;
		}
	}

	public void AbortUpdate()
	{
		oiWoRFxXDnaOxWpwWrRnvGsRTuuL();
	}

	public void Add(ZipEntry entry)
	{
		if (entry != null)
		{
			xhkvpTMVPUsQbxxfTRItHTaZQCno();
			if (entry.Size != 0L || (ulong)entry.CompressedSize > 0uL)
			{
				throw new ZipException("Entry cannot have any data");
			}
			SmWWycZxpdSlNWGVdsEfxdLDhueL(new thPpzZXBmOvoFyICpxWtjCreRqDO(OrnxgiJlSmPauttbqOavFmSOWvIA.Add, entry));
			return;
		}
		throw new ArgumentNullException("entry");
	}

	public void Add(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		xhkvpTMVPUsQbxxfTRItHTaZQCno();
		SmWWycZxpdSlNWGVdsEfxdLDhueL(new thPpzZXBmOvoFyICpxWtjCreRqDO(fileName, EntryFactory.MakeFileEntry(fileName)));
	}

	public void Add(IStaticDataSource dataSource, string entryName)
	{
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		if (entryName == null)
		{
			throw new ArgumentNullException("entryName");
		}
		xhkvpTMVPUsQbxxfTRItHTaZQCno();
		SmWWycZxpdSlNWGVdsEfxdLDhueL(new thPpzZXBmOvoFyICpxWtjCreRqDO(dataSource, EntryFactory.MakeFileEntry(entryName, useFileSystem: false)));
	}

	public void Add(string fileName, CompressionMethod compressionMethod)
	{
		if (fileName != null)
		{
			if (!ZipEntry.IsCompressionMethodSupported(compressionMethod))
			{
				throw new ArgumentOutOfRangeException("compressionMethod");
			}
			xhkvpTMVPUsQbxxfTRItHTaZQCno();
			zEPFoRrUcxRVDtXjdFoorsbpBqmy = true;
			ZipEntry zipEntry = EntryFactory.MakeFileEntry(fileName);
			zipEntry.CompressionMethod = compressionMethod;
			SmWWycZxpdSlNWGVdsEfxdLDhueL(new thPpzZXBmOvoFyICpxWtjCreRqDO(fileName, zipEntry));
			return;
		}
		throw new ArgumentNullException("fileName");
	}

	public void Add(string fileName, string entryName)
	{
		if (fileName != null)
		{
			if (entryName == null)
			{
				throw new ArgumentNullException("entryName");
			}
			xhkvpTMVPUsQbxxfTRItHTaZQCno();
			SmWWycZxpdSlNWGVdsEfxdLDhueL(new thPpzZXBmOvoFyICpxWtjCreRqDO(fileName, EntryFactory.MakeFileEntry(entryName)));
			return;
		}
		throw new ArgumentNullException("fileName");
	}

	public void Add(IStaticDataSource dataSource, string entryName, CompressionMethod compressionMethod)
	{
		if (dataSource != null)
		{
			if (entryName == null)
			{
				throw new ArgumentNullException("entryName");
			}
			xhkvpTMVPUsQbxxfTRItHTaZQCno();
			ZipEntry zipEntry = EntryFactory.MakeFileEntry(entryName, useFileSystem: false);
			zipEntry.CompressionMethod = compressionMethod;
			SmWWycZxpdSlNWGVdsEfxdLDhueL(new thPpzZXBmOvoFyICpxWtjCreRqDO(dataSource, zipEntry));
			return;
		}
		throw new ArgumentNullException("dataSource");
	}

	public void Add(string fileName, CompressionMethod compressionMethod, bool useUnicodeText)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (!jyMCZdrdfTgaMCMnZDfFILWcWueNb)
		{
			if (!ZipEntry.IsCompressionMethodSupported(compressionMethod))
			{
				throw new ArgumentOutOfRangeException("compressionMethod");
			}
			xhkvpTMVPUsQbxxfTRItHTaZQCno();
			zEPFoRrUcxRVDtXjdFoorsbpBqmy = true;
			ZipEntry zipEntry = EntryFactory.MakeFileEntry(fileName);
			zipEntry.IsUnicodeText = useUnicodeText;
			zipEntry.CompressionMethod = compressionMethod;
			SmWWycZxpdSlNWGVdsEfxdLDhueL(new thPpzZXBmOvoFyICpxWtjCreRqDO(fileName, zipEntry));
			return;
		}
		throw new ObjectDisposedException("ZipFile");
	}

	public void Add(IStaticDataSource dataSource, string entryName, CompressionMethod compressionMethod, bool useUnicodeText)
	{
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		if (entryName == null)
		{
			throw new ArgumentNullException("entryName");
		}
		xhkvpTMVPUsQbxxfTRItHTaZQCno();
		ZipEntry zipEntry = EntryFactory.MakeFileEntry(entryName, useFileSystem: false);
		zipEntry.IsUnicodeText = useUnicodeText;
		zipEntry.CompressionMethod = compressionMethod;
		SmWWycZxpdSlNWGVdsEfxdLDhueL(new thPpzZXBmOvoFyICpxWtjCreRqDO(dataSource, zipEntry));
	}

	public void AddDirectory(string directoryName)
	{
		if (directoryName == null)
		{
			throw new ArgumentNullException("directoryName");
		}
		xhkvpTMVPUsQbxxfTRItHTaZQCno();
		ZipEntry entry = EntryFactory.MakeDirectoryEntry(directoryName);
		SmWWycZxpdSlNWGVdsEfxdLDhueL(new thPpzZXBmOvoFyICpxWtjCreRqDO(OrnxgiJlSmPauttbqOavFmSOWvIA.Add, entry));
	}

	private void mOBUpUNwklggqEbuqAdAKyuUSLyn(ZipFile workFile, thPpzZXBmOvoFyICpxWtjCreRqDO update)
	{
		Stream stream = null;
		if (update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.IsFile)
		{
			stream = update.gwEXgeoFldTESiQPwNRiHeEGLDmL();
			if (stream == null)
			{
				stream = GkbUCAVbELlWmfDleedewYjRoQyl.GetSource(update.NXAdZPyzVYHlwYykTFLjZCIXlZJN, update.XVltgDeunXTAEHlFxUOpyCdKxUvw);
			}
		}
		if (stream != null)
		{
			using (stream)
			{
				long length = stream.Length;
				if (update.ugCHqYYazdEMfCldUEWGbhxGqBtlb.Size < 0L)
				{
					update.ugCHqYYazdEMfCldUEWGbhxGqBtlb.Size = length;
				}
				else if (update.ugCHqYYazdEMfCldUEWGbhxGqBtlb.Size != length)
				{
					throw new ZipException("Entry size/stream size mismatch");
				}
				workFile.hEcscZKxMjBQHTmZmqkcbNpBEZPD(update);
				long position = workFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Position;
				using (Stream destination = workFile.WhJXmOjAMpFpYylmAqmEgamARclj(update.ugCHqYYazdEMfCldUEWGbhxGqBtlb))
				{
					SyhGlyiBbAkLqvMtbblaFFsdhdSrA(update, destination, stream, length, updateCrc: true);
				}
				long position2 = workFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Position;
				update.ugCHqYYazdEMfCldUEWGbhxGqBtlb.CompressedSize = position2 - position;
				if ((update.ugCHqYYazdEMfCldUEWGbhxGqBtlb.Flags & 8) == 8)
				{
					new LocxVjlCNZghquSrgFvmkfSoMwVu(workFile.oSQdSCBxoNkCmkErffiTQbNitoGd).cxxYPOBvfRDrWLERoUzWhcAmdYMf(update.ugCHqYYazdEMfCldUEWGbhxGqBtlb);
				}
				return;
			}
		}
		workFile.hEcscZKxMjBQHTmZmqkcbNpBEZPD(update);
		update.ugCHqYYazdEMfCldUEWGbhxGqBtlb.CompressedSize = 0L;
	}

	private void SmWWycZxpdSlNWGVdsEfxdLDhueL(thPpzZXBmOvoFyICpxWtjCreRqDO update)
	{
		zEPFoRrUcxRVDtXjdFoorsbpBqmy = true;
		int num = amccLqdqEHOuSwarRzEAEEwOaaSsA(update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.Name);
		if (num >= 0)
		{
			if (giGRnjjpSMDOUnRSciXGooOFTiui[num] == null)
			{
				DhtwVxPonFDVAZIaDILDZUjDYGlw++;
			}
			giGRnjjpSMDOUnRSciXGooOFTiui[num] = update;
		}
		else
		{
			num = giGRnjjpSMDOUnRSciXGooOFTiui.Add(update);
			DhtwVxPonFDVAZIaDILDZUjDYGlw++;
			uVXdFEfRBBELttmcDmgqjyofsWbdb.Add(update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.Name, num);
		}
	}

	public void BeginUpdate()
	{
		if (Name != null)
		{
			BeginUpdate(new DiskArchiveStorage(this), new DynamicDiskDataSource());
		}
		else
		{
			BeginUpdate(new MemoryArchiveStorage(), new DynamicDiskDataSource());
		}
	}

	public void BeginUpdate(IArchiveStorage archiveStorage)
	{
		BeginUpdate(archiveStorage, new DynamicDiskDataSource());
	}

	public void BeginUpdate(IArchiveStorage archiveStorage, IDynamicDataSource dataSource)
	{
		if (archiveStorage == null)
		{
			throw new ArgumentNullException("archiveStorage");
		}
		if (dataSource != null)
		{
			if (jyMCZdrdfTgaMCMnZDfFILWcWueNb)
			{
				throw new ObjectDisposedException("ZipFile");
			}
			if (!IsEmbeddedArchive)
			{
				dVoxdaUowkecEDFiANVGvbrLsMtPA = archiveStorage;
				GkbUCAVbELlWmfDleedewYjRoQyl = dataSource;
				uVXdFEfRBBELttmcDmgqjyofsWbdb = new Hashtable();
				giGRnjjpSMDOUnRSciXGooOFTiui = new ArrayList(FepEnkzlfCEEYbpcNpgADMHBvbSBA.Length);
				ZipEntry[] fepEnkzlfCEEYbpcNpgADMHBvbSBA = FepEnkzlfCEEYbpcNpgADMHBvbSBA;
				foreach (ZipEntry zipEntry in fepEnkzlfCEEYbpcNpgADMHBvbSBA)
				{
					int num = giGRnjjpSMDOUnRSciXGooOFTiui.Add(new thPpzZXBmOvoFyICpxWtjCreRqDO(zipEntry));
					uVXdFEfRBBELttmcDmgqjyofsWbdb.Add(zipEntry.Name, num);
				}
				DhtwVxPonFDVAZIaDILDZUjDYGlw = giGRnjjpSMDOUnRSciXGooOFTiui.Count;
				zEPFoRrUcxRVDtXjdFoorsbpBqmy = false;
				sxHszzHnHRSgwWeizkQqamyfNKTH = false;
				xcYEgbCHsfkbRUrlEDuqXvxyBJHs = null;
				return;
			}
			throw new ZipException("Cannot update embedded/SFX archives");
		}
		throw new ArgumentNullException("dataSource");
	}

	private static void JDoEPCffZrQlvhVBYalMKPCCuCaoA(CryptoStream classicCryptoStream, ZipEntry entry)
	{
		byte[] array = new byte[12];
		StreamUtils.ReadFully(classicCryptoStream, array);
		if (array[11] != entry.uPXHpDLLHuKQqXZtvUAcFYLSdRod)
		{
			throw new ZipException("Invalid password");
		}
	}

	private void xhkvpTMVPUsQbxxfTRItHTaZQCno()
	{
		if (giGRnjjpSMDOUnRSciXGooOFTiui == null)
		{
			throw new InvalidOperationException("BeginUpdate has not been called");
		}
	}

	public void Close()
	{
		qZFSnoWQnTHbIWtpZPkDNbJfuMu(disposing: true);
		GC.SuppressFinalize(this);
	}

	public void CommitUpdate()
	{
		if (!jyMCZdrdfTgaMCMnZDfFILWcWueNb)
		{
			xhkvpTMVPUsQbxxfTRItHTaZQCno();
			try
			{
				uVXdFEfRBBELttmcDmgqjyofsWbdb.Clear();
				uVXdFEfRBBELttmcDmgqjyofsWbdb = null;
				if (zEPFoRrUcxRVDtXjdFoorsbpBqmy)
				{
					hRGenzeiTpKZVPLhpHtgAvyRPJYF();
				}
				else if (!sxHszzHnHRSgwWeizkQqamyfNKTH)
				{
					if (FepEnkzlfCEEYbpcNpgADMHBvbSBA.Length == 0)
					{
						byte[] comment = ((xcYEgbCHsfkbRUrlEDuqXvxyBJHs != null) ? xcYEgbCHsfkbRUrlEDuqXvxyBJHs.xwFGxtvSwXdLGGnYPhhxeSqizALAb : ZipConstants.ConvertToArray(bKEqJOElwYfNiaJgeQwIUnSIKHTT));
						using LocxVjlCNZghquSrgFvmkfSoMwVu locxVjlCNZghquSrgFvmkfSoMwVu = new LocxVjlCNZghquSrgFvmkfSoMwVu(oSQdSCBxoNkCmkErffiTQbNitoGd);
						locxVjlCNZghquSrgFvmkfSoMwVu.VKkbsirOafYYaSurlqVFagoVDczz(0L, 0L, 0L, comment);
						return;
					}
				}
				else
				{
					fiiDPpcVHAbAYJyhznjHMQfuAJHh();
				}
				return;
			}
			finally
			{
				oiWoRFxXDnaOxWpwWrRnvGsRTuuL();
			}
		}
		throw new ObjectDisposedException("ZipFile");
	}

	private void SyhGlyiBbAkLqvMtbblaFFsdhdSrA(thPpzZXBmOvoFyICpxWtjCreRqDO update, Stream destination, Stream source, long bytesToCopy, bool updateCrc)
	{
		if (destination == source)
		{
			throw new InvalidOperationException("Destination and source are the same");
		}
		Crc32 crc = new Crc32();
		byte[] array = IrkFpTHmvJLAzFLGHlpTrJSXxwSK();
		long num = bytesToCopy;
		long num2 = 0L;
		int num4;
		do
		{
			int num3 = array.Length;
			if (bytesToCopy < num3)
			{
				num3 = (int)bytesToCopy;
			}
			num4 = source.Read(array, 0, num3);
			if (num4 > 0)
			{
				if (updateCrc)
				{
					crc.Update(array, 0, num4);
				}
				destination.Write(array, 0, num4);
				bytesToCopy -= num4;
				num2 += num4;
			}
		}
		while (num4 > 0 && bytesToCopy > 0L);
		if (num2 != num)
		{
			throw new ZipException($"Failed to copy bytes expected {num} read {num2}");
		}
		if (updateCrc)
		{
			update.ugCHqYYazdEMfCldUEWGbhxGqBtlb.Crc = crc.Value;
		}
	}

	private void bepnZaoUDfxxMgQUqNfISvOIyZkg(thPpzZXBmOvoFyICpxWtjCreRqDO update, Stream dest, Stream source)
	{
		int num = wIXThPqQxLLvHqYqfABsoXoBaruB(update);
		if (num <= 0)
		{
			return;
		}
		byte[] array = IrkFpTHmvJLAzFLGHlpTrJSXxwSK();
		while (num > 0)
		{
			int count = Math.Min(array.Length, num);
			int num2 = source.Read(array, 0, count);
			if (num2 > 0)
			{
				dest.Write(array, 0, num2);
				num -= num2;
				continue;
			}
			throw new ZipException("Unxpected end of stream");
		}
	}

	private void acmjHieQtsJGAPwNRWkZQqEpJeFhA(thPpzZXBmOvoFyICpxWtjCreRqDO update, Stream stream, ref long destinationPosition, long sourcePosition)
	{
		int num = wIXThPqQxLLvHqYqfABsoXoBaruB(update);
		while (true)
		{
			if (num > 0)
			{
				int count = num;
				byte[] buffer = IrkFpTHmvJLAzFLGHlpTrJSXxwSK();
				stream.Position = sourcePosition;
				int num2 = stream.Read(buffer, 0, count);
				if (num2 <= 0)
				{
					break;
				}
				stream.Position = destinationPosition;
				stream.Write(buffer, 0, num2);
				num -= num2;
				destinationPosition += num2;
				sourcePosition += num2;
				continue;
			}
			return;
		}
		throw new ZipException("Unxpected end of stream");
	}

	private void FCliRYAHoYAUOvjWuixvtCWqNCDb(ZipFile workFile, thPpzZXBmOvoFyICpxWtjCreRqDO update)
	{
		workFile.hEcscZKxMjBQHTmZmqkcbNpBEZPD(update);
		if (update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.CompressedSize > 0L)
		{
			long offset = update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.Offset + 26L;
			oSQdSCBxoNkCmkErffiTQbNitoGd.Seek(offset, SeekOrigin.Begin);
			uint num = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
			uint num2 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
			oSQdSCBxoNkCmkErffiTQbNitoGd.Seek(num + num2, SeekOrigin.Current);
			SyhGlyiBbAkLqvMtbblaFFsdhdSrA(update, workFile.oSQdSCBxoNkCmkErffiTQbNitoGd, oSQdSCBxoNkCmkErffiTQbNitoGd, update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.CompressedSize, updateCrc: false);
		}
		bepnZaoUDfxxMgQUqNfISvOIyZkg(update, workFile.oSQdSCBxoNkCmkErffiTQbNitoGd, oSQdSCBxoNkCmkErffiTQbNitoGd);
	}

	private void kurpGNrppcCufCZHTbyIUWRpggKDA(thPpzZXBmOvoFyICpxWtjCreRqDO update, Stream stream, bool updateCrc, ref long destinationPosition, ref long sourcePosition)
	{
		long num = update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.CompressedSize;
		Crc32 crc = new Crc32();
		byte[] array = IrkFpTHmvJLAzFLGHlpTrJSXxwSK();
		long num2 = num;
		long num3 = 0L;
		int num5;
		do
		{
			int num4 = array.Length;
			if (num < num4)
			{
				num4 = (int)num;
			}
			stream.Position = sourcePosition;
			num5 = stream.Read(array, 0, num4);
			if (num5 > 0)
			{
				if (updateCrc)
				{
					crc.Update(array, 0, num5);
				}
				stream.Position = destinationPosition;
				stream.Write(array, 0, num5);
				destinationPosition += num5;
				sourcePosition += num5;
				num -= num5;
				num3 += num5;
			}
		}
		while (num5 > 0 && num > 0L);
		if (num3 == num2)
		{
			if (updateCrc)
			{
				update.ugCHqYYazdEMfCldUEWGbhxGqBtlb.Crc = crc.Value;
			}
			return;
		}
		throw new ZipException($"Failed to copy bytes expected {num2} read {num3}");
	}

	private void XkesWNLBodoQAvDfOiXGwxXJLdge(ZipFile workFile, thPpzZXBmOvoFyICpxWtjCreRqDO update, ref long destinationPosition)
	{
		bool flag = false;
		if (update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.Offset == destinationPosition)
		{
			flag = true;
		}
		if (!flag)
		{
			oSQdSCBxoNkCmkErffiTQbNitoGd.Position = destinationPosition;
			workFile.hEcscZKxMjBQHTmZmqkcbNpBEZPD(update);
			destinationPosition = oSQdSCBxoNkCmkErffiTQbNitoGd.Position;
		}
		long num = 0L;
		long num2 = update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.Offset + 26L;
		oSQdSCBxoNkCmkErffiTQbNitoGd.Seek(num2, SeekOrigin.Begin);
		uint num3 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
		uint num4 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
		num = oSQdSCBxoNkCmkErffiTQbNitoGd.Position + num3 + num4;
		if (!flag)
		{
			if (update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.CompressedSize > 0L)
			{
				kurpGNrppcCufCZHTbyIUWRpggKDA(update, oSQdSCBxoNkCmkErffiTQbNitoGd, updateCrc: false, ref destinationPosition, ref num);
			}
			acmjHieQtsJGAPwNRWkZQqEpJeFhA(update, oSQdSCBxoNkCmkErffiTQbNitoGd, ref destinationPosition, num);
		}
		else
		{
			destinationPosition += num - num2 + 26L + update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.CompressedSize + wIXThPqQxLLvHqYqfABsoXoBaruB(update);
		}
	}

	public static ZipFile Create(Stream outStream)
	{
		if (outStream == null)
		{
			throw new ArgumentNullException("outStream");
		}
		if (outStream.CanWrite)
		{
			if (!outStream.CanSeek)
			{
				throw new ArgumentException("Stream is not seekable", "outStream");
			}
			return new ZipFile
			{
				oSQdSCBxoNkCmkErffiTQbNitoGd = outStream
			};
		}
		throw new ArgumentException("Stream is not writeable", "outStream");
	}

	public static ZipFile Create(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		FileStream fileStream = File.Create(fileName);
		return new ZipFile
		{
			sHzRvUailBFDiYKMmGMjRZIxxzc = fileName,
			oSQdSCBxoNkCmkErffiTQbNitoGd = fileStream,
			tTMSyxFlQfXCQfFhbrPnqimGRjzK = true
		};
	}

	private Stream uJFyoamJHSKAhowggvkHzehLZOvM(Stream baseStream, ZipEntry entry)
	{
		CryptoStream cryptoStream = null;
		if (entry.Version < 50 || (entry.Flags & 0x40) == 0)
		{
			PkzipClassicManaged pkzipClassicManaged = new PkzipClassicManaged();
			aSapdaDjPHVUjACnSuGlASJrGHTU(entry.Name);
			if (!KfsVPVxIMSAjvjzaXuKzjciricrbb)
			{
				throw new ZipException("No password available for encrypted stream");
			}
			cryptoStream = new CryptoStream(baseStream, pkzipClassicManaged.CreateDecryptor(FnNczgeTiwCRfrmMSzVbtHOBuXHF, null), CryptoStreamMode.Read);
			JDoEPCffZrQlvhVBYalMKPCCuCaoA(cryptoStream, entry);
			return cryptoStream;
		}
		throw new ZipException("Decryption method not supported");
	}

	private Stream kBNUKcsBwXOrYhPEfnpliZUkYvOc(Stream baseStream, ZipEntry entry)
	{
		CryptoStream cryptoStream = null;
		if (entry.Version < 50 || (entry.Flags & 0x40) == 0)
		{
			PkzipClassicManaged pkzipClassicManaged = new PkzipClassicManaged();
			aSapdaDjPHVUjACnSuGlASJrGHTU(entry.Name);
			if (!KfsVPVxIMSAjvjzaXuKzjciricrbb)
			{
				throw new ZipException("No password available for encrypted stream");
			}
			cryptoStream = new CryptoStream(new bvyWMmVbnCSBLnEoFiiwRaEybKHFA(baseStream), pkzipClassicManaged.CreateEncryptor(FnNczgeTiwCRfrmMSzVbtHOBuXHF, null), CryptoStreamMode.Write);
			if (entry.Crc >= 0L && (entry.Flags & 8) == 0)
			{
				xgvnKozApQrIHZJdRCBCdgEUHxRs(cryptoStream, entry.Crc);
				return cryptoStream;
			}
			xgvnKozApQrIHZJdRCBCdgEUHxRs(cryptoStream, entry.DosTime << 16);
		}
		return cryptoStream;
	}

	public void Delete(ZipEntry entry)
	{
		if (entry != null)
		{
			xhkvpTMVPUsQbxxfTRItHTaZQCno();
			int num = amccLqdqEHOuSwarRzEAEEwOaaSsA(entry);
			if (num < 0)
			{
				throw new ZipException("Cannot find entry to delete");
			}
			zEPFoRrUcxRVDtXjdFoorsbpBqmy = true;
			giGRnjjpSMDOUnRSciXGooOFTiui[num] = null;
			DhtwVxPonFDVAZIaDILDZUjDYGlw--;
			return;
		}
		throw new ArgumentNullException("entry");
	}

	public bool Delete(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		xhkvpTMVPUsQbxxfTRItHTaZQCno();
		int num = amccLqdqEHOuSwarRzEAEEwOaaSsA(fileName);
		if (num < 0 || giGRnjjpSMDOUnRSciXGooOFTiui[num] == null)
		{
			throw new ZipException("Cannot find entry to delete");
		}
		zEPFoRrUcxRVDtXjdFoorsbpBqmy = true;
		giGRnjjpSMDOUnRSciXGooOFTiui[num] = null;
		DhtwVxPonFDVAZIaDILDZUjDYGlw--;
		return true;
	}

	protected virtual void Dispose(bool disposing)
	{
		qZFSnoWQnTHbIWtpZPkDNbJfuMu(disposing);
	}

	private void qZFSnoWQnTHbIWtpZPkDNbJfuMu(bool disposing)
	{
		if (jyMCZdrdfTgaMCMnZDfFILWcWueNb)
		{
			return;
		}
		jyMCZdrdfTgaMCMnZDfFILWcWueNb = true;
		FepEnkzlfCEEYbpcNpgADMHBvbSBA = new ZipEntry[0];
		if (IsStreamOwner && oSQdSCBxoNkCmkErffiTQbNitoGd != null)
		{
			lock (oSQdSCBxoNkCmkErffiTQbNitoGd)
			{
				oSQdSCBxoNkCmkErffiTQbNitoGd.Close();
			}
		}
		oiWoRFxXDnaOxWpwWrRnvGsRTuuL();
	}

	~ZipFile()
	{
		Dispose(disposing: false);
	}

	public int FindEntry(string name, bool ignoreCase)
	{
		if (jyMCZdrdfTgaMCMnZDfFILWcWueNb)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		for (int i = 0; i < FepEnkzlfCEEYbpcNpgADMHBvbSBA.Length; i++)
		{
			if (string.Compare(name, FepEnkzlfCEEYbpcNpgADMHBvbSBA[i].Name, ignoreCase, CultureInfo.InvariantCulture) == 0)
			{
				return i;
			}
		}
		return -1;
	}

	private int amccLqdqEHOuSwarRzEAEEwOaaSsA(ZipEntry entry)
	{
		int result = -1;
		string key = SFwJcMQLDGwmehucLrYQoLmJvubC(entry.Name);
		if (uVXdFEfRBBELttmcDmgqjyofsWbdb.ContainsKey(key))
		{
			result = (int)uVXdFEfRBBELttmcDmgqjyofsWbdb[key];
		}
		return result;
	}

	private int amccLqdqEHOuSwarRzEAEEwOaaSsA(string fileName)
	{
		int result = -1;
		string key = SFwJcMQLDGwmehucLrYQoLmJvubC(fileName);
		if (uVXdFEfRBBELttmcDmgqjyofsWbdb.ContainsKey(key))
		{
			result = (int)uVXdFEfRBBELttmcDmgqjyofsWbdb[key];
		}
		return result;
	}

	private byte[] IrkFpTHmvJLAzFLGHlpTrJSXxwSK()
	{
		if (goVmdMtFztsdhTpDJGlFvZRqbanw == null)
		{
			goVmdMtFztsdhTpDJGlFvZRqbanw = new byte[UmklLlbllLOhNJXjXDoBGkiRDmyR];
		}
		return goVmdMtFztsdhTpDJGlFvZRqbanw;
	}

	private int wIXThPqQxLLvHqYqfABsoXoBaruB(thPpzZXBmOvoFyICpxWtjCreRqDO update)
	{
		int result = 0;
		if (((uint)update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.Flags & 8u) != 0)
		{
			result = 12;
			if (update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.LocalHeaderRequiresZip64)
			{
				result = 20;
			}
		}
		return result;
	}

	public ZipEntry GetEntry(string name)
	{
		if (jyMCZdrdfTgaMCMnZDfFILWcWueNb)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		int num = FindEntry(name, ignoreCase: true);
		if (num >= 0)
		{
			return (ZipEntry)FepEnkzlfCEEYbpcNpgADMHBvbSBA[num].Clone();
		}
		return null;
	}

	public IEnumerator GetEnumerator()
	{
		if (jyMCZdrdfTgaMCMnZDfFILWcWueNb)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		return new XvHVdBrpKOmvGAADdTVJJSzGvbQF(FepEnkzlfCEEYbpcNpgADMHBvbSBA);
	}

	public Stream GetInputStream(ZipEntry entry)
	{
		if (entry != null)
		{
			if (jyMCZdrdfTgaMCMnZDfFILWcWueNb)
			{
				throw new ObjectDisposedException("ZipFile");
			}
			long num = entry.ZipFileIndex;
			if (num < 0L || num >= FepEnkzlfCEEYbpcNpgADMHBvbSBA.Length || FepEnkzlfCEEYbpcNpgADMHBvbSBA[(int)(IntPtr)num].Name != entry.Name)
			{
				num = FindEntry(entry.Name, ignoreCase: true);
				if (num < 0L)
				{
					throw new ZipException("Entry cannot be found");
				}
			}
			return GetInputStream(num);
		}
		throw new ArgumentNullException("entry");
	}

	public Stream GetInputStream(long entryIndex)
	{
		if (!jyMCZdrdfTgaMCMnZDfFILWcWueNb)
		{
			long start = RWvsNJodNapGOGPneckXaybNVCjD(FepEnkzlfCEEYbpcNpgADMHBvbSBA[(int)(IntPtr)entryIndex]);
			CompressionMethod compressionMethod = FepEnkzlfCEEYbpcNpgADMHBvbSBA[(int)(IntPtr)entryIndex].CompressionMethod;
			Stream stream = new MUaBThaLPSOmRiVcsFzePGqcabqCA(this, start, FepEnkzlfCEEYbpcNpgADMHBvbSBA[(int)(IntPtr)entryIndex].CompressedSize);
			if (FepEnkzlfCEEYbpcNpgADMHBvbSBA[(int)(IntPtr)entryIndex].IsCrypted)
			{
				stream = uJFyoamJHSKAhowggvkHzehLZOvM(stream, FepEnkzlfCEEYbpcNpgADMHBvbSBA[(int)(IntPtr)entryIndex]);
				if (stream == null)
				{
					throw new ZipException("Unable to decrypt this entry");
				}
			}
			return compressionMethod switch
			{
				CompressionMethod.Deflated => new InflaterInputStream(stream, new Inflater(noHeader: true)), 
				CompressionMethod.Stored => stream, 
				_ => throw new ZipException("Unsupported compression method " + compressionMethod), 
			};
		}
		throw new ObjectDisposedException("ZipFile");
	}

	private Stream WhJXmOjAMpFpYylmAqmEgamARclj(ZipEntry entry)
	{
		Stream stream = oSQdSCBxoNkCmkErffiTQbNitoGd;
		if (entry.IsCrypted)
		{
			stream = kBNUKcsBwXOrYhPEfnpliZUkYvOc(stream, entry);
		}
		return entry.CompressionMethod switch
		{
			CompressionMethod.Deflated => new DeflaterOutputStream(stream, new Deflater(9, noZlibHeaderOrFooter: true))
			{
				IsStreamOwner = false
			}, 
			CompressionMethod.Stored => new bvyWMmVbnCSBLnEoFiiwRaEybKHFA(stream), 
			_ => throw new ZipException("Unknown compression method " + entry.CompressionMethod), 
		};
	}

	private string XAeFREWwfkpNexqkytxJWvlkNoxi(string name)
	{
		if (NameTransform == null)
		{
			return name;
		}
		return NameTransform.TransformDirectory(name);
	}

	private string SFwJcMQLDGwmehucLrYQoLmJvubC(string name)
	{
		if (NameTransform == null)
		{
			return name;
		}
		return NameTransform.TransformFile(name);
	}

	private long WgTaXlNVHbhKiPlGxOSWomCYaXwq(int signature, long endLocation, int minimumBlockSize, int maximumVariableData)
	{
		using LocxVjlCNZghquSrgFvmkfSoMwVu locxVjlCNZghquSrgFvmkfSoMwVu = new LocxVjlCNZghquSrgFvmkfSoMwVu(oSQdSCBxoNkCmkErffiTQbNitoGd);
		return locxVjlCNZghquSrgFvmkfSoMwVu.WgTaXlNVHbhKiPlGxOSWomCYaXwq(signature, endLocation, minimumBlockSize, maximumVariableData);
	}

	private long RWvsNJodNapGOGPneckXaybNVCjD(ZipEntry entry)
	{
		return HRuzgCRLBJrfAlnAbZZWFAbPonCS(entry, xuMBRnuFHhXnkKwomiUMzNClIAVe.Extract);
	}

	private void KvgeHHnbrwCHeDJxuDNZXcTTsdSCA(ZipFile workFile, thPpzZXBmOvoFyICpxWtjCreRqDO update)
	{
		workFile.hEcscZKxMjBQHTmZmqkcbNpBEZPD(update);
		long position = workFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Position;
		if (update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.IsFile && update.XVltgDeunXTAEHlFxUOpyCdKxUvw != null)
		{
			using Stream destination = workFile.WhJXmOjAMpFpYylmAqmEgamARclj(update.ugCHqYYazdEMfCldUEWGbhxGqBtlb);
			using Stream stream = GetInputStream(update.NXAdZPyzVYHlwYykTFLjZCIXlZJN);
			SyhGlyiBbAkLqvMtbblaFFsdhdSrA(update, destination, stream, stream.Length, updateCrc: true);
		}
		long position2 = workFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Position;
		update.NXAdZPyzVYHlwYykTFLjZCIXlZJN.CompressedSize = position2 - position;
	}

	private void aSapdaDjPHVUjACnSuGlASJrGHTU(string fileName)
	{
		if (KeysRequired != null)
		{
			KeysRequiredEventArgs keysRequiredEventArgs = new KeysRequiredEventArgs(fileName, FnNczgeTiwCRfrmMSzVbtHOBuXHF);
			KeysRequired(this, keysRequiredEventArgs);
			FnNczgeTiwCRfrmMSzVbtHOBuXHF = keysRequiredEventArgs.Key;
		}
	}

	private void oiWoRFxXDnaOxWpwWrRnvGsRTuuL()
	{
		if (dVoxdaUowkecEDFiANVGvbrLsMtPA != null)
		{
			dVoxdaUowkecEDFiANVGvbrLsMtPA.Dispose();
			dVoxdaUowkecEDFiANVGvbrLsMtPA = null;
		}
		GkbUCAVbELlWmfDleedewYjRoQyl = null;
		giGRnjjpSMDOUnRSciXGooOFTiui = null;
		uVXdFEfRBBELttmcDmgqjyofsWbdb = null;
	}

	private void xOfyZuIzvAugbytjrnpdUMiBeUuHA()
	{
		if (oSQdSCBxoNkCmkErffiTQbNitoGd.CanSeek)
		{
			long num = WgTaXlNVHbhKiPlGxOSWomCYaXwq(101010256, oSQdSCBxoNkCmkErffiTQbNitoGd.Length, 22, 65535);
			if (num >= 0L)
			{
				ushort num2 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
				ushort num3 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
				ulong num4 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
				ulong num5 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
				ulong num6 = GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
				long num7 = GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
				uint num8 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
				if (num8 == 0)
				{
					bKEqJOElwYfNiaJgeQwIUnSIKHTT = string.Empty;
				}
				else
				{
					byte[] array = new byte[num8];
					StreamUtils.ReadFully(oSQdSCBxoNkCmkErffiTQbNitoGd, array);
					bKEqJOElwYfNiaJgeQwIUnSIKHTT = ZipConstants.ConvertToString(array);
				}
				bool flag = false;
				if (num2 == ushort.MaxValue || num3 == ushort.MaxValue || num4 == 65535L || num5 == 65535L || num6 == 4294967295L || num7 == 4294967295L)
				{
					flag = true;
					long num9 = WgTaXlNVHbhKiPlGxOSWomCYaXwq(117853008, num, 0, 4096);
					if (num9 < 0L)
					{
						throw new ZipException("Cannot find Zip64 locator");
					}
					GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
					ulong num10 = hVaGRmiggqGgpDVkuRUgnjasOprdA();
					GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
					oSQdSCBxoNkCmkErffiTQbNitoGd.Position = (long)num10;
					long num11 = GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
					if (num11 != 101075792L)
					{
						throw new ZipException($"Invalid Zip64 Central directory signature at {num10:X}");
					}
					hVaGRmiggqGgpDVkuRUgnjasOprdA();
					KHkGfxVHrHgRWcfzqjYleLSbBizDA();
					KHkGfxVHrHgRWcfzqjYleLSbBizDA();
					GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
					GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
					num4 = hVaGRmiggqGgpDVkuRUgnjasOprdA();
					num5 = hVaGRmiggqGgpDVkuRUgnjasOprdA();
					num6 = hVaGRmiggqGgpDVkuRUgnjasOprdA();
					num7 = (long)hVaGRmiggqGgpDVkuRUgnjasOprdA();
				}
				FepEnkzlfCEEYbpcNpgADMHBvbSBA = new ZipEntry[num4];
				if (!flag && num7 < num - (long)(4L + num6))
				{
					sTndfsDVLvLWJtATbmmFqOoFIizeA = num - ((long)(4L + num6) + num7);
					if (sTndfsDVLvLWJtATbmmFqOoFIizeA <= 0L)
					{
						throw new ZipException("Invalid embedded zip archive");
					}
				}
				oSQdSCBxoNkCmkErffiTQbNitoGd.Seek(sTndfsDVLvLWJtATbmmFqOoFIizeA + num7, SeekOrigin.Begin);
				ulong num12 = 0uL;
				while (true)
				{
					if (num12 < num4)
					{
						if (GNEeFBjuYQeUvwbHCxVOpzTNsydoA() != 33639248)
						{
							break;
						}
						int madeByInfo = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
						int versionRequiredToExtract = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
						int num13 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
						int method = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
						uint num14 = GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
						uint num15 = GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
						long num16 = GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
						long num17 = GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
						int num18 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
						int num19 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
						int num20 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
						KHkGfxVHrHgRWcfzqjYleLSbBizDA();
						KHkGfxVHrHgRWcfzqjYleLSbBizDA();
						uint externalFileAttributes = GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
						long offset = GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
						byte[] array2 = new byte[Math.Max(num18, num20)];
						StreamUtils.ReadFully(oSQdSCBxoNkCmkErffiTQbNitoGd, array2, 0, num18);
						string name = ZipConstants.ConvertToStringExt(num13, array2, num18);
						ZipEntry zipEntry = new ZipEntry(name, versionRequiredToExtract, madeByInfo, (CompressionMethod)method);
						zipEntry.Crc = (long)num15 & 0xFFFFFFFFL;
						zipEntry.Size = num17 & 0xFFFFFFFFL;
						zipEntry.CompressedSize = num16 & 0xFFFFFFFFL;
						zipEntry.Flags = num13;
						zipEntry.DosTime = num14;
						zipEntry.ZipFileIndex = (long)num12;
						zipEntry.Offset = offset;
						zipEntry.ExternalFileAttributes = (int)externalFileAttributes;
						if ((num13 & 8) == 0)
						{
							zipEntry.uPXHpDLLHuKQqXZtvUAcFYLSdRod = (byte)(num15 >> 24);
						}
						else
						{
							zipEntry.uPXHpDLLHuKQqXZtvUAcFYLSdRod = (byte)((num14 >> 8) & 0xFFu);
						}
						if (num19 > 0)
						{
							byte[] array3 = new byte[num19];
							StreamUtils.ReadFully(oSQdSCBxoNkCmkErffiTQbNitoGd, array3);
							zipEntry.ExtraData = array3;
						}
						zipEntry.AeqxguekIVMcjGFKBbGLRoJAaXqg(localHeader: false);
						if (num20 > 0)
						{
							StreamUtils.ReadFully(oSQdSCBxoNkCmkErffiTQbNitoGd, array2, 0, num20);
							zipEntry.Comment = ZipConstants.ConvertToStringExt(num13, array2, num20);
						}
						FepEnkzlfCEEYbpcNpgADMHBvbSBA[(int)(IntPtr)checked((long)num12)] = zipEntry;
						num12++;
						continue;
					}
					return;
				}
				throw new ZipException("Wrong Central Directory signature");
			}
			throw new ZipException("Cannot find central directory");
		}
		throw new ZipException("ZipFile stream must be seekable");
	}

	private uint GNEeFBjuYQeUvwbHCxVOpzTNsydoA()
	{
		return (uint)(KHkGfxVHrHgRWcfzqjYleLSbBizDA() | (KHkGfxVHrHgRWcfzqjYleLSbBizDA() << 16));
	}

	private ulong hVaGRmiggqGgpDVkuRUgnjasOprdA()
	{
		return GNEeFBjuYQeUvwbHCxVOpzTNsydoA() | GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
	}

	private ushort KHkGfxVHrHgRWcfzqjYleLSbBizDA()
	{
		int num = oSQdSCBxoNkCmkErffiTQbNitoGd.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException("End of stream");
		}
		int num2 = oSQdSCBxoNkCmkErffiTQbNitoGd.ReadByte();
		if (num2 < 0)
		{
			throw new EndOfStreamException("End of stream");
		}
		return (ushort)((ushort)num | (ushort)(num2 << 8));
	}

	private void grlNucqnpjDVcKShYNtHzLTODnoB()
	{
		if (Name == null)
		{
			throw new InvalidOperationException("Name is not known cannot Reopen");
		}
		grlNucqnpjDVcKShYNtHzLTODnoB(File.OpenRead(Name));
	}

	private void grlNucqnpjDVcKShYNtHzLTODnoB(Stream source)
	{
		if (source == null)
		{
			throw new ZipException("Failed to reopen archive - no source");
		}
		pbFCeDjePibKuCThtdWRJFnEOqieb = false;
		oSQdSCBxoNkCmkErffiTQbNitoGd = source;
		xOfyZuIzvAugbytjrnpdUMiBeUuHA();
	}

	private void hRGenzeiTpKZVPLhpHtgAvyRPJYF()
	{
		long num = 0L;
		long length = 0L;
		bool flag = true;
		bool flag2 = false;
		long destinationPosition = 0L;
		ZipFile zipFile;
		if (IsNewArchive)
		{
			zipFile = this;
			zipFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Position = 0L;
			flag2 = true;
		}
		else if (dVoxdaUowkecEDFiANVGvbrLsMtPA.UpdateMode != FileUpdateMode.Direct)
		{
			zipFile = Create(dVoxdaUowkecEDFiANVGvbrLsMtPA.GetTemporaryOutput());
			zipFile.UseZip64 = UseZip64;
			if (FnNczgeTiwCRfrmMSzVbtHOBuXHF != null)
			{
				zipFile.FnNczgeTiwCRfrmMSzVbtHOBuXHF = (byte[])FnNczgeTiwCRfrmMSzVbtHOBuXHF.Clone();
			}
		}
		else
		{
			zipFile = this;
			zipFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Position = 0L;
			flag2 = true;
			giGRnjjpSMDOUnRSciXGooOFTiui.Sort(new WrEbEWxHJOLPYCWqbyUtcgkVaaCJ());
		}
		try
		{
			foreach (thPpzZXBmOvoFyICpxWtjCreRqDO item in giGRnjjpSMDOUnRSciXGooOFTiui)
			{
				if (item == null)
				{
					continue;
				}
				switch (item.MnlddAHZNGTZhkXsczABGSOSLbPO)
				{
				case OrnxgiJlSmPauttbqOavFmSOWvIA.Copy:
					if (flag2)
					{
						XkesWNLBodoQAvDfOiXGwxXJLdge(zipFile, item, ref destinationPosition);
					}
					else
					{
						FCliRYAHoYAUOvjWuixvtCWqNCDb(zipFile, item);
					}
					break;
				case OrnxgiJlSmPauttbqOavFmSOWvIA.Modify:
					KvgeHHnbrwCHeDJxuDNZXcTTsdSCA(zipFile, item);
					break;
				case OrnxgiJlSmPauttbqOavFmSOWvIA.Add:
					if (!IsNewArchive && flag2)
					{
						zipFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Position = destinationPosition;
					}
					mOBUpUNwklggqEbuqAdAKyuUSLyn(zipFile, item);
					if (flag2)
					{
						destinationPosition = zipFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Position;
					}
					break;
				}
			}
			if (!IsNewArchive && flag2)
			{
				zipFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Position = destinationPosition;
			}
			long position = zipFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Position;
			foreach (thPpzZXBmOvoFyICpxWtjCreRqDO item2 in giGRnjjpSMDOUnRSciXGooOFTiui)
			{
				if (item2 != null)
				{
					num += zipFile.aoWPFWiNbQVRnwlAbxDWjIWYxazb(item2.ugCHqYYazdEMfCldUEWGbhxGqBtlb);
				}
			}
			byte[] comment = ((xcYEgbCHsfkbRUrlEDuqXvxyBJHs != null) ? xcYEgbCHsfkbRUrlEDuqXvxyBJHs.xwFGxtvSwXdLGGnYPhhxeSqizALAb : ZipConstants.ConvertToArray(bKEqJOElwYfNiaJgeQwIUnSIKHTT));
			using (LocxVjlCNZghquSrgFvmkfSoMwVu locxVjlCNZghquSrgFvmkfSoMwVu = new LocxVjlCNZghquSrgFvmkfSoMwVu(zipFile.oSQdSCBxoNkCmkErffiTQbNitoGd))
			{
				locxVjlCNZghquSrgFvmkfSoMwVu.VKkbsirOafYYaSurlqVFagoVDczz(DhtwVxPonFDVAZIaDILDZUjDYGlw, num, position, comment);
			}
			length = zipFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Position;
			foreach (thPpzZXBmOvoFyICpxWtjCreRqDO item3 in giGRnjjpSMDOUnRSciXGooOFTiui)
			{
				if (item3 == null)
				{
					continue;
				}
				if (item3.UXNqdVumXwceIdwPXloWfcbNSWelA > 0L && item3.ugCHqYYazdEMfCldUEWGbhxGqBtlb.CompressedSize > 0L)
				{
					zipFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Position = item3.UXNqdVumXwceIdwPXloWfcbNSWelA;
					zipFile.izRGOUentiyqAkNhkfWOgEFeqnCxb((int)item3.ugCHqYYazdEMfCldUEWGbhxGqBtlb.Crc);
				}
				if (item3.kWXcHxqzOtbcDwaBDZwcxSqScTvO > 0L)
				{
					zipFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Position = item3.kWXcHxqzOtbcDwaBDZwcxSqScTvO;
					if (!item3.ugCHqYYazdEMfCldUEWGbhxGqBtlb.LocalHeaderRequiresZip64)
					{
						zipFile.izRGOUentiyqAkNhkfWOgEFeqnCxb((int)item3.ugCHqYYazdEMfCldUEWGbhxGqBtlb.CompressedSize);
						zipFile.izRGOUentiyqAkNhkfWOgEFeqnCxb((int)item3.ugCHqYYazdEMfCldUEWGbhxGqBtlb.Size);
					}
					else
					{
						zipFile.OyynbzvBPJeXFNnanDZTiCPtrfILA(item3.ugCHqYYazdEMfCldUEWGbhxGqBtlb.Size);
						zipFile.OyynbzvBPJeXFNnanDZTiCPtrfILA(item3.ugCHqYYazdEMfCldUEWGbhxGqBtlb.CompressedSize);
					}
				}
			}
		}
		catch (Exception)
		{
			flag = false;
		}
		finally
		{
			if (!flag2)
			{
				zipFile.Close();
			}
			else if (flag)
			{
				zipFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Flush();
				zipFile.oSQdSCBxoNkCmkErffiTQbNitoGd.SetLength(length);
			}
		}
		if (flag)
		{
			if (!flag2)
			{
				oSQdSCBxoNkCmkErffiTQbNitoGd.Close();
				grlNucqnpjDVcKShYNtHzLTODnoB(dVoxdaUowkecEDFiANVGvbrLsMtPA.ConvertTemporaryToFinal());
			}
			else
			{
				pbFCeDjePibKuCThtdWRJFnEOqieb = false;
				zipFile.oSQdSCBxoNkCmkErffiTQbNitoGd.Flush();
				xOfyZuIzvAugbytjrnpdUMiBeUuHA();
			}
		}
		else
		{
			zipFile.Close();
			if (!flag2 && zipFile.Name != null)
			{
				File.Delete(zipFile.Name);
			}
		}
	}

	public void SetComment(string comment)
	{
		if (jyMCZdrdfTgaMCMnZDfFILWcWueNb)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		xhkvpTMVPUsQbxxfTRItHTaZQCno();
		xcYEgbCHsfkbRUrlEDuqXvxyBJHs = new usHPSPuHXHIIepTmquPhrjDhInpV(comment);
		if (xcYEgbCHsfkbRUrlEDuqXvxyBJHs.rqsuuEnzQrNTXyiaaHxrmaTtOFVk > 65535)
		{
			xcYEgbCHsfkbRUrlEDuqXvxyBJHs = null;
			throw new ZipException("Comment length exceeds maximum - 65535");
		}
		sxHszzHnHRSgwWeizkQqamyfNKTH = true;
	}

	void IDisposable.Dispose()
	{
		Close();
	}

	public bool TestArchive(bool testData)
	{
		return TestArchive(testData, TestStrategy.FindFirstError, null);
	}

	public bool TestArchive(bool testData, TestStrategy strategy, ZipTestResultHandler resultHandler)
	{
		if (!jyMCZdrdfTgaMCMnZDfFILWcWueNb)
		{
			TestStatus testStatus = new TestStatus(this);
			resultHandler?.Invoke(testStatus, null);
			xuMBRnuFHhXnkKwomiUMzNClIAVe tests = (testData ? (xuMBRnuFHhXnkKwomiUMzNClIAVe.Extract | xuMBRnuFHhXnkKwomiUMzNClIAVe.Header) : xuMBRnuFHhXnkKwomiUMzNClIAVe.Header);
			bool flag = true;
			try
			{
				int num = 0;
				while (flag && num < Count)
				{
					if (resultHandler != null)
					{
						testStatus.EJafPsLKgitPKKsbeeqypiSfAbuh(this[num]);
						testStatus.hBJocMANnrMIZumjXrwBzalpFdsu(TestOperation.EntryHeader);
						resultHandler(testStatus, null);
					}
					try
					{
						HRuzgCRLBJrfAlnAbZZWFAbPonCS(this[num], tests);
					}
					catch (ZipException ex)
					{
						testStatus.cwbBMiHvXjnRDrwPuhHtuRHvRFYy();
						resultHandler?.Invoke(testStatus, $"Exception during test - '{ex.Message}'");
						if (strategy == TestStrategy.FindFirstError)
						{
							flag = false;
						}
					}
					if (flag && testData && this[num].IsFile)
					{
						if (resultHandler != null)
						{
							testStatus.hBJocMANnrMIZumjXrwBzalpFdsu(TestOperation.EntryData);
							resultHandler(testStatus, null);
						}
						Crc32 crc = new Crc32();
						using (Stream stream = GetInputStream(this[num]))
						{
							byte[] array = new byte[4096];
							long num2 = 0L;
							int num3;
							while ((num3 = stream.Read(array, 0, array.Length)) > 0)
							{
								crc.Update(array, 0, num3);
								if (resultHandler != null)
								{
									num2 += num3;
									testStatus.nFbJYhhCbTzUPreUFzKnqgqedWfXA(num2);
									resultHandler(testStatus, null);
								}
							}
						}
						if (this[num].Crc != crc.Value)
						{
							testStatus.cwbBMiHvXjnRDrwPuhHtuRHvRFYy();
							resultHandler?.Invoke(testStatus, "CRC mismatch");
							if (strategy == TestStrategy.FindFirstError)
							{
								flag = false;
							}
						}
						if (((uint)this[num].Flags & 8u) != 0)
						{
							LocxVjlCNZghquSrgFvmkfSoMwVu locxVjlCNZghquSrgFvmkfSoMwVu = new LocxVjlCNZghquSrgFvmkfSoMwVu(oSQdSCBxoNkCmkErffiTQbNitoGd);
							DescriptorData descriptorData = new DescriptorData();
							locxVjlCNZghquSrgFvmkfSoMwVu.GeZBxamwPHYaRwSbMduxiFuicajz(this[num].LocalHeaderRequiresZip64, descriptorData);
							if (this[num].Crc != descriptorData.Crc)
							{
								testStatus.cwbBMiHvXjnRDrwPuhHtuRHvRFYy();
							}
							if (this[num].CompressedSize != descriptorData.CompressedSize)
							{
								testStatus.cwbBMiHvXjnRDrwPuhHtuRHvRFYy();
							}
							if (this[num].Size != descriptorData.Size)
							{
								testStatus.cwbBMiHvXjnRDrwPuhHtuRHvRFYy();
							}
						}
					}
					if (resultHandler != null)
					{
						testStatus.hBJocMANnrMIZumjXrwBzalpFdsu(TestOperation.EntryComplete);
						resultHandler(testStatus, null);
					}
					num++;
				}
				if (resultHandler != null)
				{
					testStatus.hBJocMANnrMIZumjXrwBzalpFdsu(TestOperation.MiscellaneousTests);
					resultHandler(testStatus, null);
				}
			}
			catch (Exception ex2)
			{
				testStatus.cwbBMiHvXjnRDrwPuhHtuRHvRFYy();
				resultHandler?.Invoke(testStatus, $"Exception during test - '{ex2.Message}'");
			}
			if (resultHandler != null)
			{
				testStatus.hBJocMANnrMIZumjXrwBzalpFdsu(TestOperation.Complete);
				testStatus.EJafPsLKgitPKKsbeeqypiSfAbuh(null);
				resultHandler(testStatus, null);
			}
			return testStatus.ErrorCount == 0;
		}
		throw new ObjectDisposedException("ZipFile");
	}

	private long HRuzgCRLBJrfAlnAbZZWFAbPonCS(ZipEntry entry, xuMBRnuFHhXnkKwomiUMzNClIAVe tests)
	{
		lock (oSQdSCBxoNkCmkErffiTQbNitoGd)
		{
			bool flag = (tests & xuMBRnuFHhXnkKwomiUMzNClIAVe.Header) != 0;
			bool flag2 = (tests & xuMBRnuFHhXnkKwomiUMzNClIAVe.Extract) != 0;
			oSQdSCBxoNkCmkErffiTQbNitoGd.Seek(sTndfsDVLvLWJtATbmmFqOoFIizeA + entry.Offset, SeekOrigin.Begin);
			if (GNEeFBjuYQeUvwbHCxVOpzTNsydoA() != 67324752)
			{
				throw new ZipException($"Wrong local header signature @{sTndfsDVLvLWJtATbmmFqOoFIizeA + entry.Offset:X}");
			}
			short num = (short)KHkGfxVHrHgRWcfzqjYleLSbBizDA();
			short num2 = (short)KHkGfxVHrHgRWcfzqjYleLSbBizDA();
			short num3 = (short)KHkGfxVHrHgRWcfzqjYleLSbBizDA();
			short num4 = (short)KHkGfxVHrHgRWcfzqjYleLSbBizDA();
			short num5 = (short)KHkGfxVHrHgRWcfzqjYleLSbBizDA();
			uint num6 = GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
			long num7 = GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
			long num8 = GNEeFBjuYQeUvwbHCxVOpzTNsydoA();
			int num9 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
			int num10 = KHkGfxVHrHgRWcfzqjYleLSbBizDA();
			byte[] array = new byte[num9];
			StreamUtils.ReadFully(oSQdSCBxoNkCmkErffiTQbNitoGd, array);
			byte[] array2 = new byte[num10];
			StreamUtils.ReadFully(oSQdSCBxoNkCmkErffiTQbNitoGd, array2);
			ZipExtraData zipExtraData = new ZipExtraData(array2);
			if (!zipExtraData.Find(1))
			{
				if (num >= 45 && ((int)num8 == -1 || (int)num7 == -1))
				{
					throw new ZipException("Required Zip64 extended information missing");
				}
			}
			else
			{
				if (num < 45)
				{
					throw new ZipException($"Extra data contains Zip64 information but version {num / 10}.{num % 10} is not high enough");
				}
				if ((int)num8 != -1 && (int)num7 != -1)
				{
					throw new ZipException("Entry sizes not correct for Zip64");
				}
				num8 = zipExtraData.ReadLong();
				num7 = zipExtraData.ReadLong();
				if (((uint)num2 & 8u) != 0)
				{
					if (num8 != -1L && num8 != entry.Size)
					{
						throw new ZipException("Size invalid for descriptor");
					}
					if (num7 != -1L && num7 != entry.CompressedSize)
					{
						throw new ZipException("Compressed size invalid for descriptor");
					}
				}
			}
			if (flag2 && entry.IsFile)
			{
				if (!entry.IsCompressionMethodSupported())
				{
					throw new ZipException("Compression method not supported");
				}
				if (num > 45 || (num > 20 && num < 45))
				{
					throw new ZipException($"Version required to extract this entry not supported ({num})");
				}
				if (((uint)num2 & 0x3060u) != 0)
				{
					throw new ZipException("The library does not support the zip version required to extract this entry");
				}
			}
			if (flag)
			{
				if (num <= 63 && num != 10 && num != 11 && num != 20 && num != 21 && num != 25 && num != 27 && num != 45 && num != 46 && num != 50 && num != 51 && num != 52 && num != 61 && num != 62 && num != 63)
				{
					throw new ZipException($"Version required to extract this entry is invalid ({num})");
				}
				if (((uint)num2 & 0xC010u) != 0)
				{
					throw new ZipException("Reserved bit flags cannot be set.");
				}
				if (((uint)num2 & (true ? 1u : 0u)) != 0 && num < 20)
				{
					throw new ZipException($"Version required to extract this entry is too low for encryption ({num})");
				}
				if (((uint)num2 & 0x40u) != 0)
				{
					if ((num2 & 1) == 0)
					{
						throw new ZipException("Strong encryption flag set but encryption flag is not set");
					}
					if (num < 50)
					{
						throw new ZipException($"Version required to extract this entry is too low for encryption ({num})");
					}
				}
				if (((uint)num2 & 0x20u) != 0 && num < 27)
				{
					throw new ZipException($"Patched data requires higher version than ({num})");
				}
				if (num2 != entry.Flags)
				{
					throw new ZipException("Central header/local header flags mismatch");
				}
				if (entry.CompressionMethod != (CompressionMethod)num3)
				{
					throw new ZipException("Central header/local header compression method mismatch");
				}
				if (entry.Version != num)
				{
					throw new ZipException("Extract version mismatch");
				}
				if (((uint)num2 & 0x40u) != 0 && num < 62)
				{
					throw new ZipException("Strong encryption flag set but version not high enough");
				}
				if (((uint)num2 & 0x2000u) != 0 && (num4 != 0 || num5 != 0))
				{
					throw new ZipException("Header masked set but date/time values non-zero");
				}
				if ((num2 & 8) == 0 && num6 != (uint)entry.Crc)
				{
					throw new ZipException("Central header/local header crc mismatch");
				}
				if (num8 == 0L && num7 == 0L && num6 != 0)
				{
					throw new ZipException("Invalid CRC for empty entry");
				}
				if (entry.Name.Length > num9)
				{
					throw new ZipException("File name length mismatch");
				}
				string text = ZipConstants.ConvertToStringExt(num2, array);
				if (text != entry.Name)
				{
					throw new ZipException("Central header and local header file name mismatch");
				}
				if (entry.IsDirectory)
				{
					if (num8 > 0L)
					{
						throw new ZipException("Directory cannot have size");
					}
					if (!entry.IsCrypted)
					{
						if (num7 > 2L)
						{
							throw new ZipException("Directory compressed size invalid");
						}
					}
					else if (num7 > 14L)
					{
						throw new ZipException("Directory compressed size invalid");
					}
				}
				if (!ZipNameTransform.IsValidName(text, relaxed: true))
				{
					throw new ZipException("Name is invalid");
				}
			}
			if ((num2 & 8) == 0 || num8 > 0L || num7 > 0L)
			{
				if (num8 != entry.Size)
				{
					throw new ZipException($"Size mismatch between central header({entry.Size}) and local header({num8})");
				}
				if (num7 != entry.CompressedSize)
				{
					throw new ZipException($"Compressed size mismatch between central header({entry.CompressedSize}) and local header({num7})");
				}
			}
			int num11 = num9 + num10;
			return sTndfsDVLvLWJtATbmmFqOoFIizeA + entry.Offset + 30L + num11;
		}
	}

	private void fiiDPpcVHAbAYJyhznjHMQfuAJHh()
	{
		long length = oSQdSCBxoNkCmkErffiTQbNitoGd.Length;
		LocxVjlCNZghquSrgFvmkfSoMwVu locxVjlCNZghquSrgFvmkfSoMwVu = null;
		if (dVoxdaUowkecEDFiANVGvbrLsMtPA.UpdateMode != 0)
		{
			if (dVoxdaUowkecEDFiANVGvbrLsMtPA.UpdateMode == FileUpdateMode.Direct)
			{
				oSQdSCBxoNkCmkErffiTQbNitoGd = dVoxdaUowkecEDFiANVGvbrLsMtPA.OpenForDirectUpdate(oSQdSCBxoNkCmkErffiTQbNitoGd);
				locxVjlCNZghquSrgFvmkfSoMwVu = new LocxVjlCNZghquSrgFvmkfSoMwVu(oSQdSCBxoNkCmkErffiTQbNitoGd);
			}
			else
			{
				oSQdSCBxoNkCmkErffiTQbNitoGd.Close();
				oSQdSCBxoNkCmkErffiTQbNitoGd = null;
				locxVjlCNZghquSrgFvmkfSoMwVu = new LocxVjlCNZghquSrgFvmkfSoMwVu(Name);
			}
		}
		else
		{
			locxVjlCNZghquSrgFvmkfSoMwVu = new LocxVjlCNZghquSrgFvmkfSoMwVu(dVoxdaUowkecEDFiANVGvbrLsMtPA.MakeTemporaryCopy(oSQdSCBxoNkCmkErffiTQbNitoGd))
			{
				MjVEoLBoHsdhPuAYZvVjarfKgyJMA = true
			};
			oSQdSCBxoNkCmkErffiTQbNitoGd.Close();
			oSQdSCBxoNkCmkErffiTQbNitoGd = null;
		}
		using (locxVjlCNZghquSrgFvmkfSoMwVu)
		{
			if (locxVjlCNZghquSrgFvmkfSoMwVu.WgTaXlNVHbhKiPlGxOSWomCYaXwq(101010256, length, 22, 65535) < 0L)
			{
				throw new ZipException("Cannot find central directory");
			}
			locxVjlCNZghquSrgFvmkfSoMwVu.Position += 16L;
			byte[] xwFGxtvSwXdLGGnYPhhxeSqizALAb = xcYEgbCHsfkbRUrlEDuqXvxyBJHs.xwFGxtvSwXdLGGnYPhhxeSqizALAb;
			locxVjlCNZghquSrgFvmkfSoMwVu.WPwBCcZKsWTMxrdsFHKYotnEJfDC(xwFGxtvSwXdLGGnYPhhxeSqizALAb.Length);
			locxVjlCNZghquSrgFvmkfSoMwVu.Write(xwFGxtvSwXdLGGnYPhhxeSqizALAb, 0, xwFGxtvSwXdLGGnYPhhxeSqizALAb.Length);
			locxVjlCNZghquSrgFvmkfSoMwVu.SetLength(locxVjlCNZghquSrgFvmkfSoMwVu.Position);
		}
		if (dVoxdaUowkecEDFiANVGvbrLsMtPA.UpdateMode == FileUpdateMode.Safe)
		{
			grlNucqnpjDVcKShYNtHzLTODnoB(dVoxdaUowkecEDFiANVGvbrLsMtPA.ConvertTemporaryToFinal());
		}
		else
		{
			xOfyZuIzvAugbytjrnpdUMiBeUuHA();
		}
	}

	private int aoWPFWiNbQVRnwlAbxDWjIWYxazb(ZipEntry entry)
	{
		if (entry.CompressedSize < 0L)
		{
			throw new ZipException("Attempt to write central directory entry with unknown csize");
		}
		if (entry.Size < 0L)
		{
			throw new ZipException("Attempt to write central directory entry with unknown size");
		}
		if (entry.Crc >= 0L)
		{
			izRGOUentiyqAkNhkfWOgEFeqnCxb(33639248);
			WPwBCcZKsWTMxrdsFHKYotnEJfDC(45);
			WPwBCcZKsWTMxrdsFHKYotnEJfDC(entry.Version);
			WPwBCcZKsWTMxrdsFHKYotnEJfDC(entry.Flags);
			WPwBCcZKsWTMxrdsFHKYotnEJfDC((byte)entry.CompressionMethod);
			izRGOUentiyqAkNhkfWOgEFeqnCxb((int)entry.DosTime);
			izRGOUentiyqAkNhkfWOgEFeqnCxb((int)entry.Crc);
			if (!entry.IsZip64Forced() && entry.CompressedSize < 4294967295L)
			{
				izRGOUentiyqAkNhkfWOgEFeqnCxb((int)(entry.CompressedSize & 0xFFFFFFFFL));
			}
			else
			{
				izRGOUentiyqAkNhkfWOgEFeqnCxb(-1);
			}
			if (!entry.IsZip64Forced() && entry.Size < 4294967295L)
			{
				izRGOUentiyqAkNhkfWOgEFeqnCxb((int)entry.Size);
			}
			else
			{
				izRGOUentiyqAkNhkfWOgEFeqnCxb(-1);
			}
			byte[] array = ZipConstants.ConvertToArray(entry.Flags, entry.Name);
			if (array.Length <= 65535)
			{
				WPwBCcZKsWTMxrdsFHKYotnEJfDC(array.Length);
				ZipExtraData zipExtraData = new ZipExtraData(entry.ExtraData);
				if (!entry.CentralHeaderRequiresZip64)
				{
					zipExtraData.Delete(1);
				}
				else
				{
					zipExtraData.StartNewEntry();
					if (entry.Size >= 4294967295L || bKsRPzWeosiiVJMdrYkiLDpYbLKcA == UseZip64.On)
					{
						zipExtraData.AddLeLong(entry.Size);
					}
					if (entry.CompressedSize >= 4294967295L || bKsRPzWeosiiVJMdrYkiLDpYbLKcA == UseZip64.On)
					{
						zipExtraData.AddLeLong(entry.CompressedSize);
					}
					if (entry.Offset >= 4294967295L)
					{
						zipExtraData.AddLeLong(entry.Offset);
					}
					zipExtraData.AddNewEntry(1);
				}
				byte[] entryData = zipExtraData.GetEntryData();
				WPwBCcZKsWTMxrdsFHKYotnEJfDC(entryData.Length);
				WPwBCcZKsWTMxrdsFHKYotnEJfDC((entry.Comment != null) ? entry.Comment.Length : 0);
				WPwBCcZKsWTMxrdsFHKYotnEJfDC(0);
				WPwBCcZKsWTMxrdsFHKYotnEJfDC(0);
				if (entry.ExternalFileAttributes != -1)
				{
					izRGOUentiyqAkNhkfWOgEFeqnCxb(entry.ExternalFileAttributes);
				}
				else if (entry.IsDirectory)
				{
					CidIExkmOcpNFGSezkMxGqsjoCwc(16u);
				}
				else
				{
					CidIExkmOcpNFGSezkMxGqsjoCwc(0u);
				}
				if (entry.Offset >= 4294967295L)
				{
					CidIExkmOcpNFGSezkMxGqsjoCwc(uint.MaxValue);
				}
				else
				{
					CidIExkmOcpNFGSezkMxGqsjoCwc((uint)entry.Offset);
				}
				if (array.Length != 0)
				{
					oSQdSCBxoNkCmkErffiTQbNitoGd.Write(array, 0, array.Length);
				}
				if (entryData.Length != 0)
				{
					oSQdSCBxoNkCmkErffiTQbNitoGd.Write(entryData, 0, entryData.Length);
				}
				byte[] array2 = ((entry.Comment != null) ? Encoding.ASCII.GetBytes(entry.Comment) : new byte[0]);
				if (array2.Length != 0)
				{
					oSQdSCBxoNkCmkErffiTQbNitoGd.Write(array2, 0, array2.Length);
				}
				return 46 + array.Length + entryData.Length + array2.Length;
			}
			throw new ZipException("Entry name is too long.");
		}
		throw new ZipException("Attempt to write central directory entry with unknown crc");
	}

	private static void xgvnKozApQrIHZJdRCBCdgEUHxRs(Stream stream, long crcValue)
	{
		byte[] array = new byte[12];
		new Random().NextBytes(array);
		array[11] = (byte)(crcValue >> 24);
		stream.Write(array, 0, array.Length);
	}

	private void izRGOUentiyqAkNhkfWOgEFeqnCxb(int value)
	{
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(value & 0xFFFF);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(value >> 16);
	}

	private void OyynbzvBPJeXFNnanDZTiCPtrfILA(long value)
	{
		izRGOUentiyqAkNhkfWOgEFeqnCxb((int)(value & 0xFFFFFFFFL));
		izRGOUentiyqAkNhkfWOgEFeqnCxb((int)(value >> 32));
	}

	private void WPwBCcZKsWTMxrdsFHKYotnEJfDC(int value)
	{
		oSQdSCBxoNkCmkErffiTQbNitoGd.WriteByte((byte)((uint)value & 0xFFu));
		oSQdSCBxoNkCmkErffiTQbNitoGd.WriteByte((byte)((uint)(value >> 8) & 0xFFu));
	}

	private void CidIExkmOcpNFGSezkMxGqsjoCwc(uint value)
	{
		QvsWjaMcaHNljSdazCUqdeyKLTYMA((ushort)(value & 0xFFFFu));
		QvsWjaMcaHNljSdazCUqdeyKLTYMA((ushort)(value >> 16));
	}

	private void OHfGUEbmEKQSkLcuHkBWfcMhNOnP(ulong value)
	{
		CidIExkmOcpNFGSezkMxGqsjoCwc((uint)(value & 0xFFFFFFFFuL));
		CidIExkmOcpNFGSezkMxGqsjoCwc((uint)(value >> 32));
	}

	private void QvsWjaMcaHNljSdazCUqdeyKLTYMA(ushort value)
	{
		oSQdSCBxoNkCmkErffiTQbNitoGd.WriteByte((byte)(value & 0xFFu));
		oSQdSCBxoNkCmkErffiTQbNitoGd.WriteByte((byte)(value >> 8));
	}

	private void hEcscZKxMjBQHTmZmqkcbNpBEZPD(thPpzZXBmOvoFyICpxWtjCreRqDO update)
	{
		ZipEntry ugCHqYYazdEMfCldUEWGbhxGqBtlb = update.ugCHqYYazdEMfCldUEWGbhxGqBtlb;
		ugCHqYYazdEMfCldUEWGbhxGqBtlb.Offset = oSQdSCBxoNkCmkErffiTQbNitoGd.Position;
		if (update.MnlddAHZNGTZhkXsczABGSOSLbPO != 0)
		{
			if (ugCHqYYazdEMfCldUEWGbhxGqBtlb.CompressionMethod != CompressionMethod.Deflated)
			{
				if (ugCHqYYazdEMfCldUEWGbhxGqBtlb.CompressionMethod == CompressionMethod.Stored)
				{
					ugCHqYYazdEMfCldUEWGbhxGqBtlb.Flags &= -9;
				}
			}
			else if (ugCHqYYazdEMfCldUEWGbhxGqBtlb.Size == 0L)
			{
				ugCHqYYazdEMfCldUEWGbhxGqBtlb.CompressedSize = ugCHqYYazdEMfCldUEWGbhxGqBtlb.Size;
				ugCHqYYazdEMfCldUEWGbhxGqBtlb.Crc = 0L;
				ugCHqYYazdEMfCldUEWGbhxGqBtlb.CompressionMethod = CompressionMethod.Stored;
			}
			if (KfsVPVxIMSAjvjzaXuKzjciricrbb)
			{
				ugCHqYYazdEMfCldUEWGbhxGqBtlb.IsCrypted = true;
				if (ugCHqYYazdEMfCldUEWGbhxGqBtlb.Crc < 0L)
				{
					ugCHqYYazdEMfCldUEWGbhxGqBtlb.Flags |= 8;
				}
			}
			else
			{
				ugCHqYYazdEMfCldUEWGbhxGqBtlb.IsCrypted = false;
			}
			switch (bKsRPzWeosiiVJMdrYkiLDpYbLKcA)
			{
			case UseZip64.On:
				ugCHqYYazdEMfCldUEWGbhxGqBtlb.ForceZip64();
				break;
			case UseZip64.Dynamic:
				if (ugCHqYYazdEMfCldUEWGbhxGqBtlb.Size < 0L)
				{
					ugCHqYYazdEMfCldUEWGbhxGqBtlb.ForceZip64();
				}
				break;
			}
		}
		izRGOUentiyqAkNhkfWOgEFeqnCxb(67324752);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(ugCHqYYazdEMfCldUEWGbhxGqBtlb.Version);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(ugCHqYYazdEMfCldUEWGbhxGqBtlb.Flags);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC((byte)ugCHqYYazdEMfCldUEWGbhxGqBtlb.CompressionMethod);
		izRGOUentiyqAkNhkfWOgEFeqnCxb((int)ugCHqYYazdEMfCldUEWGbhxGqBtlb.DosTime);
		if (ugCHqYYazdEMfCldUEWGbhxGqBtlb.HasCrc)
		{
			izRGOUentiyqAkNhkfWOgEFeqnCxb((int)ugCHqYYazdEMfCldUEWGbhxGqBtlb.Crc);
		}
		else
		{
			update.UXNqdVumXwceIdwPXloWfcbNSWelA = oSQdSCBxoNkCmkErffiTQbNitoGd.Position;
			izRGOUentiyqAkNhkfWOgEFeqnCxb(0);
		}
		if (!ugCHqYYazdEMfCldUEWGbhxGqBtlb.LocalHeaderRequiresZip64)
		{
			if (ugCHqYYazdEMfCldUEWGbhxGqBtlb.CompressedSize < 0L || ugCHqYYazdEMfCldUEWGbhxGqBtlb.Size < 0L)
			{
				update.kWXcHxqzOtbcDwaBDZwcxSqScTvO = oSQdSCBxoNkCmkErffiTQbNitoGd.Position;
			}
			izRGOUentiyqAkNhkfWOgEFeqnCxb((int)ugCHqYYazdEMfCldUEWGbhxGqBtlb.CompressedSize);
			izRGOUentiyqAkNhkfWOgEFeqnCxb((int)ugCHqYYazdEMfCldUEWGbhxGqBtlb.Size);
		}
		else
		{
			izRGOUentiyqAkNhkfWOgEFeqnCxb(-1);
			izRGOUentiyqAkNhkfWOgEFeqnCxb(-1);
		}
		byte[] array = ZipConstants.ConvertToArray(ugCHqYYazdEMfCldUEWGbhxGqBtlb.Flags, ugCHqYYazdEMfCldUEWGbhxGqBtlb.Name);
		if (array.Length > 65535)
		{
			throw new ZipException("Entry name too long.");
		}
		ZipExtraData zipExtraData = new ZipExtraData(ugCHqYYazdEMfCldUEWGbhxGqBtlb.ExtraData);
		if (ugCHqYYazdEMfCldUEWGbhxGqBtlb.LocalHeaderRequiresZip64)
		{
			zipExtraData.StartNewEntry();
			zipExtraData.AddLeLong(ugCHqYYazdEMfCldUEWGbhxGqBtlb.Size);
			zipExtraData.AddLeLong(ugCHqYYazdEMfCldUEWGbhxGqBtlb.CompressedSize);
			zipExtraData.AddNewEntry(1);
		}
		else
		{
			zipExtraData.Delete(1);
		}
		ugCHqYYazdEMfCldUEWGbhxGqBtlb.ExtraData = zipExtraData.GetEntryData();
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(array.Length);
		WPwBCcZKsWTMxrdsFHKYotnEJfDC(ugCHqYYazdEMfCldUEWGbhxGqBtlb.ExtraData.Length);
		if (array.Length != 0)
		{
			oSQdSCBxoNkCmkErffiTQbNitoGd.Write(array, 0, array.Length);
		}
		if (ugCHqYYazdEMfCldUEWGbhxGqBtlb.LocalHeaderRequiresZip64)
		{
			if (!zipExtraData.Find(1))
			{
				throw new ZipException("Internal error cannot find extra data");
			}
			update.kWXcHxqzOtbcDwaBDZwcxSqScTvO = oSQdSCBxoNkCmkErffiTQbNitoGd.Position + zipExtraData.CurrentReadIndex;
		}
		if (ugCHqYYazdEMfCldUEWGbhxGqBtlb.ExtraData.Length != 0)
		{
			oSQdSCBxoNkCmkErffiTQbNitoGd.Write(ugCHqYYazdEMfCldUEWGbhxGqBtlb.ExtraData, 0, ugCHqYYazdEMfCldUEWGbhxGqBtlb.ExtraData.Length);
		}
	}
}
