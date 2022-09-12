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
	private enum mJMGpmMuVGWvpjuNdoffJSUuVlYX
	{
		Extract = 1,
		Header = 2
	}

	public delegate void KeysRequiredEventHandler(object sender, KeysRequiredEventArgs e);

	private class ZstJItbZbaATJbHdCeNCjhtlUrkA : Stream
	{
		private Stream bnUsFfzRpiPSoBspiesaqzitUkVf;

		private long vjkCqPgNiSoTWrvJugVwFlXwpGlY;

		private long HKJqnxtCLucEqyjtwEjWcbtBIPsp;

		private long OevPjBMsUGfyzjFqnyowxgWDxDgr;

		private long HEuxDSfBKWcEwhylCsQGOcLkMjpFb;

		private ZipFile BJoclnJfTIvUyqejhbkMaxUYHeLL;

		bool Stream.CanRead => true;

		bool Stream.CanSeek => true;

		bool Stream.CanTimeout => bnUsFfzRpiPSoBspiesaqzitUkVf.CanTimeout;

		bool Stream.CanWrite => false;

		long Stream.Length => HKJqnxtCLucEqyjtwEjWcbtBIPsp;

		long Stream.Position
		{
			get
			{
				return OevPjBMsUGfyzjFqnyowxgWDxDgr - HEuxDSfBKWcEwhylCsQGOcLkMjpFb;
			}
			set
			{
				long num = HEuxDSfBKWcEwhylCsQGOcLkMjpFb + value;
				if (num < HEuxDSfBKWcEwhylCsQGOcLkMjpFb)
				{
					throw new ArgumentException("Negative position is invalid");
				}
				if (num >= vjkCqPgNiSoTWrvJugVwFlXwpGlY)
				{
					throw new InvalidOperationException("Cannot seek past end");
				}
				OevPjBMsUGfyzjFqnyowxgWDxDgr = num;
			}
		}

		public ZstJItbZbaATJbHdCeNCjhtlUrkA(ZipFile zipFile, long start, long length)
		{
			HEuxDSfBKWcEwhylCsQGOcLkMjpFb = start;
			HKJqnxtCLucEqyjtwEjWcbtBIPsp = length;
			BJoclnJfTIvUyqejhbkMaxUYHeLL = zipFile;
			bnUsFfzRpiPSoBspiesaqzitUkVf = BJoclnJfTIvUyqejhbkMaxUYHeLL.bnUsFfzRpiPSoBspiesaqzitUkVf;
			OevPjBMsUGfyzjFqnyowxgWDxDgr = start;
			vjkCqPgNiSoTWrvJugVwFlXwpGlY = start + length;
		}

		public override void mpefNMoGvicOqKbIavuPRKrLTHIk()
		{
		}

		public override void QxrfgOkbBVYEDNvGSgrzaNzdPFPLb()
		{
		}

		public override int QuRHndxCozYYFKqaLJQIqSdmmaX(byte[] buffer, int offset, int count)
		{
			lock (bnUsFfzRpiPSoBspiesaqzitUkVf)
			{
				if (count > vjkCqPgNiSoTWrvJugVwFlXwpGlY - OevPjBMsUGfyzjFqnyowxgWDxDgr)
				{
					count = (int)(vjkCqPgNiSoTWrvJugVwFlXwpGlY - OevPjBMsUGfyzjFqnyowxgWDxDgr);
					if (count == 0)
					{
						return 0;
					}
				}
				bnUsFfzRpiPSoBspiesaqzitUkVf.Seek(OevPjBMsUGfyzjFqnyowxgWDxDgr, SeekOrigin.Begin);
				int num = bnUsFfzRpiPSoBspiesaqzitUkVf.Read(buffer, offset, count);
				if (num > 0)
				{
					OevPjBMsUGfyzjFqnyowxgWDxDgr += num;
				}
				return num;
			}
		}

		public override int bkkXoVtKdzDVPkArqTWXugrvSDhP()
		{
			if (OevPjBMsUGfyzjFqnyowxgWDxDgr >= vjkCqPgNiSoTWrvJugVwFlXwpGlY)
			{
				return -1;
			}
			lock (bnUsFfzRpiPSoBspiesaqzitUkVf)
			{
				long offset = OevPjBMsUGfyzjFqnyowxgWDxDgr++;
				bnUsFfzRpiPSoBspiesaqzitUkVf.Seek(offset, SeekOrigin.Begin);
				return bnUsFfzRpiPSoBspiesaqzitUkVf.ReadByte();
			}
		}

		public override long zpGkAbiwMvQDGqsanjJTcNBnkbRT(long offset, SeekOrigin origin)
		{
			long num = OevPjBMsUGfyzjFqnyowxgWDxDgr;
			switch (origin)
			{
			case SeekOrigin.Begin:
				num = HEuxDSfBKWcEwhylCsQGOcLkMjpFb + offset;
				break;
			case SeekOrigin.Current:
				num = OevPjBMsUGfyzjFqnyowxgWDxDgr + offset;
				break;
			case SeekOrigin.End:
				num = vjkCqPgNiSoTWrvJugVwFlXwpGlY + offset;
				break;
			}
			if (num < HEuxDSfBKWcEwhylCsQGOcLkMjpFb)
			{
				throw new ArgumentException("Negative position is invalid");
			}
			if (num >= vjkCqPgNiSoTWrvJugVwFlXwpGlY)
			{
				throw new IOException("Cannot seek past end");
			}
			OevPjBMsUGfyzjFqnyowxgWDxDgr = num;
			return OevPjBMsUGfyzjFqnyowxgWDxDgr;
		}

		public override void DEQgxThAMIInuHZVBpCNdnAgqOAxd(long value)
		{
			throw new NotSupportedException();
		}

		public override void xEaWPnfzdCnOUoczuyEkOiRfgpXjA(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}
	}

	private class epazeRvPjpoWBAzRMdLTbXFnrrCj : Stream
	{
		private Stream bnUsFfzRpiPSoBspiesaqzitUkVf;

		bool Stream.CanRead => false;

		bool Stream.CanSeek => false;

		bool Stream.CanWrite => bnUsFfzRpiPSoBspiesaqzitUkVf.CanWrite;

		long Stream.Length => 0L;

		long Stream.Position
		{
			get
			{
				return bnUsFfzRpiPSoBspiesaqzitUkVf.Position;
			}
			set
			{
			}
		}

		public epazeRvPjpoWBAzRMdLTbXFnrrCj(Stream baseStream)
		{
			bnUsFfzRpiPSoBspiesaqzitUkVf = baseStream;
		}

		public override void mpefNMoGvicOqKbIavuPRKrLTHIk()
		{
		}

		public override void QxrfgOkbBVYEDNvGSgrzaNzdPFPLb()
		{
			bnUsFfzRpiPSoBspiesaqzitUkVf.Flush();
		}

		public override int QuRHndxCozYYFKqaLJQIqSdmmaX(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override long zpGkAbiwMvQDGqsanjJTcNBnkbRT(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void DEQgxThAMIInuHZVBpCNdnAgqOAxd(long value)
		{
		}

		public override void xEaWPnfzdCnOUoczuyEkOiRfgpXjA(byte[] buffer, int offset, int count)
		{
			bnUsFfzRpiPSoBspiesaqzitUkVf.Write(buffer, offset, count);
		}
	}

	private enum NIvaNLgvfzBbgAOSAwBBrzdkZnqvB
	{
		Copy,
		Modify,
		Add
	}

	private class TfSXXzVGDtopWdrFspvCSAdQDRJS : IComparer
	{
		public int Compare(object object_0, object object_1)
		{
			soPNFcrRohSBRDVpyROOVagrFcSl soPNFcrRohSBRDVpyROOVagrFcSl = object_0 as soPNFcrRohSBRDVpyROOVagrFcSl;
			soPNFcrRohSBRDVpyROOVagrFcSl soPNFcrRohSBRDVpyROOVagrFcSl2 = object_1 as soPNFcrRohSBRDVpyROOVagrFcSl;
			if (soPNFcrRohSBRDVpyROOVagrFcSl == null)
			{
				if (soPNFcrRohSBRDVpyROOVagrFcSl2 == null)
				{
					return 0;
				}
				return -1;
			}
			if (soPNFcrRohSBRDVpyROOVagrFcSl2 != null)
			{
				int num = ((soPNFcrRohSBRDVpyROOVagrFcSl.DpsNxfjXebzjbJLZjNeKaNbDSKib != 0 && soPNFcrRohSBRDVpyROOVagrFcSl.DpsNxfjXebzjbJLZjNeKaNbDSKib != NIvaNLgvfzBbgAOSAwBBrzdkZnqvB.Modify) ? 1 : 0);
				int num2 = ((soPNFcrRohSBRDVpyROOVagrFcSl2.DpsNxfjXebzjbJLZjNeKaNbDSKib != 0 && soPNFcrRohSBRDVpyROOVagrFcSl2.DpsNxfjXebzjbJLZjNeKaNbDSKib != NIvaNLgvfzBbgAOSAwBBrzdkZnqvB.Modify) ? 1 : 0);
				int num3 = num - num2;
				if (num3 != 0)
				{
					return num3;
				}
				long num4 = soPNFcrRohSBRDVpyROOVagrFcSl.UOCIbsWqZlcXqzADYfCOfsLGycKO.Offset - soPNFcrRohSBRDVpyROOVagrFcSl2.UOCIbsWqZlcXqzADYfCOfsLGycKO.Offset;
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
	}

	private class QHVnjcPoIdWEIreokrYmrvwZlQHR : IEnumerator
	{
		private ZipEntry[] RMjKMsaCQHXIKROkraBBpUYHnHpk;

		private int vqvSOUugyLejRxsAnRbkkaNbwKUW = -1;

		public object Current => RMjKMsaCQHXIKROkraBBpUYHnHpk[vqvSOUugyLejRxsAnRbkkaNbwKUW];

		public QHVnjcPoIdWEIreokrYmrvwZlQHR(ZipEntry[] entries)
		{
			RMjKMsaCQHXIKROkraBBpUYHnHpk = entries;
		}

		public bool MoveNext()
		{
			return ++vqvSOUugyLejRxsAnRbkkaNbwKUW < RMjKMsaCQHXIKROkraBBpUYHnHpk.Length;
		}

		public void Reset()
		{
			vqvSOUugyLejRxsAnRbkkaNbwKUW = -1;
		}
	}

	private class pMXyhoEtXqmkgSxZbtrKJKCmiKkfA
	{
		private string eYQlQpyUcttysBjLvxCxuGRThsKs;

		private bool gaYaDpcvFFgFeICvanAvghjERRrWA;

		private byte[] QGtFwFutSehLoqQQgfHbCEyafVZw;

		public bool WslpBTmBzkGqZCUNcgkhVOFQNPpo => gaYaDpcvFFgFeICvanAvghjERRrWA;

		public byte[] eHDZEvLmZcrMxObcYgEQgnuyxEYb
		{
			get
			{
				MHvilPXYdlpwFoEDGZrBnaHQpbbe();
				return (byte[])QGtFwFutSehLoqQQgfHbCEyafVZw.Clone();
			}
		}

		public int ybqJIjHpOWbxJALRlTOWTAAspxUCb
		{
			get
			{
				MHvilPXYdlpwFoEDGZrBnaHQpbbe();
				return QGtFwFutSehLoqQQgfHbCEyafVZw.Length;
			}
		}

		public pMXyhoEtXqmkgSxZbtrKJKCmiKkfA(string comment)
		{
			eYQlQpyUcttysBjLvxCxuGRThsKs = comment;
			gaYaDpcvFFgFeICvanAvghjERRrWA = true;
		}

		public pMXyhoEtXqmkgSxZbtrKJKCmiKkfA(byte[] rawString)
		{
			QGtFwFutSehLoqQQgfHbCEyafVZw = rawString;
		}

		private void MHvilPXYdlpwFoEDGZrBnaHQpbbe()
		{
			if (QGtFwFutSehLoqQQgfHbCEyafVZw == null)
			{
				QGtFwFutSehLoqQQgfHbCEyafVZw = ZipConstants.ConvertToArray(eYQlQpyUcttysBjLvxCxuGRThsKs);
			}
		}

		private void DozwCUIgLtjOYffwAQEHRfgqptmHA()
		{
			if (eYQlQpyUcttysBjLvxCxuGRThsKs == null)
			{
				eYQlQpyUcttysBjLvxCxuGRThsKs = ZipConstants.ConvertToString(QGtFwFutSehLoqQQgfHbCEyafVZw);
			}
		}

		[SpecialName]
		public static string EGKtBMiMPrKGWCCchfXtbmjEJKYG(pMXyhoEtXqmkgSxZbtrKJKCmiKkfA zipString)
		{
			zipString.DozwCUIgLtjOYffwAQEHRfgqptmHA();
			return zipString.eYQlQpyUcttysBjLvxCxuGRThsKs;
		}

		public void DpKtQTONKAKCvHfYHRdYQzfeGqip()
		{
			if (gaYaDpcvFFgFeICvanAvghjERRrWA)
			{
				QGtFwFutSehLoqQQgfHbCEyafVZw = null;
			}
			else
			{
				eYQlQpyUcttysBjLvxCxuGRThsKs = null;
			}
		}
	}

	private class soPNFcrRohSBRDVpyROOVagrFcSl
	{
		private NIvaNLgvfzBbgAOSAwBBrzdkZnqvB VSIXjLXqSTIMPmPczHWNEREoDUNgb;

		private long MqKgQiKqWZLnFrksqGerdfHbdGEs;

		private IStaticDataSource uiiwmqguzOMbLDHdfndzwrGhOVeU;

		private ZipEntry jlkwCLtFnbtkXolcutIZfZkktyRE;

		private string FVlQInrRgLskatQxTeaOEMyBIUvgb;

		private ZipEntry QXObBHqGizIIPEMWYUMHMLclbFqQ;

		private long thjHItelTQgHnJjCmaqHBJbdapUi;

		public NIvaNLgvfzBbgAOSAwBBrzdkZnqvB DpsNxfjXebzjbJLZjNeKaNbDSKib => VSIXjLXqSTIMPmPczHWNEREoDUNgb;

		public long PmXFDcEEZNENWDwaSzNfKbaArGrK
		{
			get
			{
				return MqKgQiKqWZLnFrksqGerdfHbdGEs;
			}
			set
			{
				MqKgQiKqWZLnFrksqGerdfHbdGEs = value;
			}
		}

		public ZipEntry UOCIbsWqZlcXqzADYfCOfsLGycKO => jlkwCLtFnbtkXolcutIZfZkktyRE;

		public string GIvCqaQnzeuAOygMiBSMOcQTvfaD => FVlQInrRgLskatQxTeaOEMyBIUvgb;

		public ZipEntry npCKxxeBbMgvfKZQHTZfVMqbkYsG
		{
			get
			{
				if (QXObBHqGizIIPEMWYUMHMLclbFqQ == null)
				{
					QXObBHqGizIIPEMWYUMHMLclbFqQ = (ZipEntry)jlkwCLtFnbtkXolcutIZfZkktyRE.Clone();
				}
				return QXObBHqGizIIPEMWYUMHMLclbFqQ;
			}
		}

		public long vnLjtACtQCkQLFooYjuTVYxDgGcI
		{
			get
			{
				return thjHItelTQgHnJjCmaqHBJbdapUi;
			}
			set
			{
				thjHItelTQgHnJjCmaqHBJbdapUi = value;
			}
		}

		public soPNFcrRohSBRDVpyROOVagrFcSl(ZipEntry entry)
			: this(NIvaNLgvfzBbgAOSAwBBrzdkZnqvB.Copy, entry)
		{
		}

		public soPNFcrRohSBRDVpyROOVagrFcSl(IStaticDataSource dataSource, ZipEntry entry)
		{
			thjHItelTQgHnJjCmaqHBJbdapUi = -1L;
			MqKgQiKqWZLnFrksqGerdfHbdGEs = -1L;
			VSIXjLXqSTIMPmPczHWNEREoDUNgb = NIvaNLgvfzBbgAOSAwBBrzdkZnqvB.Add;
			jlkwCLtFnbtkXolcutIZfZkktyRE = entry;
			uiiwmqguzOMbLDHdfndzwrGhOVeU = dataSource;
		}

		public soPNFcrRohSBRDVpyROOVagrFcSl(ZipEntry original, ZipEntry updated)
		{
			thjHItelTQgHnJjCmaqHBJbdapUi = -1L;
			MqKgQiKqWZLnFrksqGerdfHbdGEs = -1L;
			throw new ZipException("Modify not currently supported");
		}

		public soPNFcrRohSBRDVpyROOVagrFcSl(NIvaNLgvfzBbgAOSAwBBrzdkZnqvB command, ZipEntry entry)
		{
			thjHItelTQgHnJjCmaqHBJbdapUi = -1L;
			MqKgQiKqWZLnFrksqGerdfHbdGEs = -1L;
			VSIXjLXqSTIMPmPczHWNEREoDUNgb = command;
			jlkwCLtFnbtkXolcutIZfZkktyRE = (ZipEntry)entry.Clone();
		}

		public soPNFcrRohSBRDVpyROOVagrFcSl(string fileName, ZipEntry entry)
		{
			thjHItelTQgHnJjCmaqHBJbdapUi = -1L;
			MqKgQiKqWZLnFrksqGerdfHbdGEs = -1L;
			VSIXjLXqSTIMPmPczHWNEREoDUNgb = NIvaNLgvfzBbgAOSAwBBrzdkZnqvB.Add;
			jlkwCLtFnbtkXolcutIZfZkktyRE = entry;
			FVlQInrRgLskatQxTeaOEMyBIUvgb = fileName;
		}

		[Obsolete]
		public soPNFcrRohSBRDVpyROOVagrFcSl(string fileName, string entryName)
			: this(fileName, entryName, CompressionMethod.Deflated)
		{
		}

		[Obsolete]
		public soPNFcrRohSBRDVpyROOVagrFcSl(IStaticDataSource dataSource, string entryName, CompressionMethod compressionMethod)
		{
			thjHItelTQgHnJjCmaqHBJbdapUi = -1L;
			MqKgQiKqWZLnFrksqGerdfHbdGEs = -1L;
			VSIXjLXqSTIMPmPczHWNEREoDUNgb = NIvaNLgvfzBbgAOSAwBBrzdkZnqvB.Add;
			jlkwCLtFnbtkXolcutIZfZkktyRE = new ZipEntry(entryName);
			jlkwCLtFnbtkXolcutIZfZkktyRE.CompressionMethod = compressionMethod;
			uiiwmqguzOMbLDHdfndzwrGhOVeU = dataSource;
		}

		[Obsolete]
		public soPNFcrRohSBRDVpyROOVagrFcSl(string fileName, string entryName, CompressionMethod compressionMethod)
		{
			thjHItelTQgHnJjCmaqHBJbdapUi = -1L;
			MqKgQiKqWZLnFrksqGerdfHbdGEs = -1L;
			VSIXjLXqSTIMPmPczHWNEREoDUNgb = NIvaNLgvfzBbgAOSAwBBrzdkZnqvB.Add;
			jlkwCLtFnbtkXolcutIZfZkktyRE = new ZipEntry(entryName);
			jlkwCLtFnbtkXolcutIZfZkktyRE.CompressionMethod = compressionMethod;
			FVlQInrRgLskatQxTeaOEMyBIUvgb = fileName;
		}

		public Stream pjSyzVOahEhrQNvctyIRlHRFfutX()
		{
			Stream result = null;
			if (uiiwmqguzOMbLDHdfndzwrGhOVeU != null)
			{
				result = uiiwmqguzOMbLDHdfndzwrGhOVeU.GetSource();
			}
			return result;
		}
	}

	private IArchiveStorage uikJSBoaaTSoYahFVISzZRyAjqcg;

	private Stream bnUsFfzRpiPSoBspiesaqzitUkVf;

	private int VtubFCRTrgJIBihIMhvkubjWtNnu;

	private byte[] YzBRIVUxaJVmjEDtROkGJXZIcLMW;

	private string eYQlQpyUcttysBjLvxCxuGRThsKs;

	private bool fJTOYQvFrghycnoHkBbXUAzqqwYM;

	private bool eODOIiDDaUjhHGpEoFtRBNkgEPpgb;

	private byte[] nBHFYtFHhCTQngPyAgswVuWtDAeI;

	private const int AwAARpALHgggIIHTcPSANQpeNHFfC = 4096;

	private ZipEntry[] WMpBiXDdnnyUMAIJUidbupSSHYLk;

	private bool gPAJpOXsfclOUdxCUVeyxsHJtLpQ;

	private bool qRVGSoJSNHSymizMswHuxUeHjDpv;

	private bool wLAMyKxDbSSzQUvMyMwOQVxXsyqm;

	public KeysRequiredEventHandler KeysRequired;

	private string tRVAXCmQaABtTkPdDStnZsUXXSwn;

	private pMXyhoEtXqmkgSxZbtrKJKCmiKkfA wnKFaCcimSZNNzGEZTpFfqkfBeIp;

	private long rlpITDpbFOegFjOmeudatAjEFLaSA;

	private long WnrraMtGtghsOmjBGIHavgiOAfmx;

	private IDynamicDataSource TwdryllcGwHToEhCbggFFCeCxTnAA;

	private IEntryFactory nXTDsqIrUWRlpaVxQIrIciHepGWXb;

	private Hashtable vAFpbzdVFybLpDBYMbRZWnwmxJuC;

	private ArrayList daIofKLnSpllCEnnpKfpMrHMGsfM;

	private UseZip64 svuDrGoXqHoWNqaKclrVfIkLByFbA;

	public int BufferSize
	{
		get
		{
			return VtubFCRTrgJIBihIMhvkubjWtNnu;
		}
		set
		{
			if (value < 1024)
			{
				throw new ArgumentOutOfRangeException("value", "cannot be below 1024");
			}
			if (VtubFCRTrgJIBihIMhvkubjWtNnu != value)
			{
				VtubFCRTrgJIBihIMhvkubjWtNnu = value;
				nBHFYtFHhCTQngPyAgswVuWtDAeI = null;
			}
		}
	}

	public long Count => WMpBiXDdnnyUMAIJUidbupSSHYLk.Length;

	public ZipEntry this[int index] => (ZipEntry)WMpBiXDdnnyUMAIJUidbupSSHYLk[index].Clone();

	public IEntryFactory EntryFactory
	{
		get
		{
			return nXTDsqIrUWRlpaVxQIrIciHepGWXb;
		}
		set
		{
			if (value == null)
			{
				nXTDsqIrUWRlpaVxQIrIciHepGWXb = new ZipEntryFactory();
			}
			else
			{
				nXTDsqIrUWRlpaVxQIrIciHepGWXb = value;
			}
		}
	}

	private bool FLchgkTeUbJpdSFXUHHWWdzkWFst => YzBRIVUxaJVmjEDtROkGJXZIcLMW != null;

	public bool IsEmbeddedArchive => rlpITDpbFOegFjOmeudatAjEFLaSA > 0L;

	public bool IsNewArchive => qRVGSoJSNHSymizMswHuxUeHjDpv;

	public bool IsStreamOwner
	{
		get
		{
			return wLAMyKxDbSSzQUvMyMwOQVxXsyqm;
		}
		set
		{
			wLAMyKxDbSSzQUvMyMwOQVxXsyqm = value;
		}
	}

	public bool IsUpdating => daIofKLnSpllCEnnpKfpMrHMGsfM != null;

	private byte[] FRGhhBAmHthjWpwQBgBAvIGklUfJ
	{
		get
		{
			return YzBRIVUxaJVmjEDtROkGJXZIcLMW;
		}
		set
		{
			YzBRIVUxaJVmjEDtROkGJXZIcLMW = value;
		}
	}

	public string Name => tRVAXCmQaABtTkPdDStnZsUXXSwn;

	public INameTransform NameTransform
	{
		get
		{
			return nXTDsqIrUWRlpaVxQIrIciHepGWXb.NameTransform;
		}
		set
		{
			nXTDsqIrUWRlpaVxQIrIciHepGWXb.NameTransform = value;
		}
	}

	public string Password
	{
		set
		{
			if (value != null && value.Length != 0)
			{
				YzBRIVUxaJVmjEDtROkGJXZIcLMW = PkzipClassic.GenerateKeys(ZipConstants.ConvertToArray(value));
			}
			else
			{
				YzBRIVUxaJVmjEDtROkGJXZIcLMW = null;
			}
		}
	}

	[Obsolete("Use the Count property instead")]
	public int Size => WMpBiXDdnnyUMAIJUidbupSSHYLk.Length;

	public UseZip64 UseZip64
	{
		get
		{
			return svuDrGoXqHoWNqaKclrVfIkLByFbA;
		}
		set
		{
			svuDrGoXqHoWNqaKclrVfIkLByFbA = value;
		}
	}

	public string ZipFileComment => eYQlQpyUcttysBjLvxCxuGRThsKs;

	internal ZipFile()
	{
		svuDrGoXqHoWNqaKclrVfIkLByFbA = UseZip64.Dynamic;
		VtubFCRTrgJIBihIMhvkubjWtNnu = 4096;
		nXTDsqIrUWRlpaVxQIrIciHepGWXb = new ZipEntryFactory();
		WMpBiXDdnnyUMAIJUidbupSSHYLk = new ZipEntry[0];
		qRVGSoJSNHSymizMswHuxUeHjDpv = true;
	}

	public ZipFile(FileStream file)
	{
		svuDrGoXqHoWNqaKclrVfIkLByFbA = UseZip64.Dynamic;
		VtubFCRTrgJIBihIMhvkubjWtNnu = 4096;
		nXTDsqIrUWRlpaVxQIrIciHepGWXb = new ZipEntryFactory();
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		if (!file.CanSeek)
		{
			throw new ArgumentException("Stream is not seekable", "file");
		}
		bnUsFfzRpiPSoBspiesaqzitUkVf = file;
		tRVAXCmQaABtTkPdDStnZsUXXSwn = file.Name;
		wLAMyKxDbSSzQUvMyMwOQVxXsyqm = true;
		try
		{
			ivppqJuGdrEizTlSekNEgrsYzehG();
		}
		catch
		{
			nnRBaAayOUApbDpUGaGDzbyvQDDfc(disposing: true);
			throw;
		}
	}

	public ZipFile(Stream stream)
	{
		svuDrGoXqHoWNqaKclrVfIkLByFbA = UseZip64.Dynamic;
		VtubFCRTrgJIBihIMhvkubjWtNnu = 4096;
		nXTDsqIrUWRlpaVxQIrIciHepGWXb = new ZipEntryFactory();
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream.CanSeek)
		{
			throw new ArgumentException("Stream is not seekable", "stream");
		}
		bnUsFfzRpiPSoBspiesaqzitUkVf = stream;
		wLAMyKxDbSSzQUvMyMwOQVxXsyqm = true;
		if (bnUsFfzRpiPSoBspiesaqzitUkVf.Length > 0L)
		{
			try
			{
				ivppqJuGdrEizTlSekNEgrsYzehG();
				return;
			}
			catch
			{
				nnRBaAayOUApbDpUGaGDzbyvQDDfc(disposing: true);
				throw;
			}
		}
		WMpBiXDdnnyUMAIJUidbupSSHYLk = new ZipEntry[0];
		qRVGSoJSNHSymizMswHuxUeHjDpv = true;
	}

	public ZipFile(string name)
	{
		svuDrGoXqHoWNqaKclrVfIkLByFbA = UseZip64.Dynamic;
		VtubFCRTrgJIBihIMhvkubjWtNnu = 4096;
		nXTDsqIrUWRlpaVxQIrIciHepGWXb = new ZipEntryFactory();
		if (name != null)
		{
			tRVAXCmQaABtTkPdDStnZsUXXSwn = name;
			bnUsFfzRpiPSoBspiesaqzitUkVf = File.OpenRead(name);
			wLAMyKxDbSSzQUvMyMwOQVxXsyqm = true;
			try
			{
				ivppqJuGdrEizTlSekNEgrsYzehG();
				return;
			}
			catch
			{
				nnRBaAayOUApbDpUGaGDzbyvQDDfc(disposing: true);
				throw;
			}
		}
		throw new ArgumentNullException("name");
	}

	public void AbortUpdate()
	{
		lwWpbgRVHScTdtRZJmCEZcjGqlzg();
	}

	public void Add(ZipEntry entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		cngFjoaeXzubjErIWHAOvRlCtwmG();
		if (entry.Size != 0L || entry.CompressedSize != 0L)
		{
			throw new ZipException("Entry cannot have any data");
		}
		PyKYLFrxMUmCZhducvkSJxQYQkpG(new soPNFcrRohSBRDVpyROOVagrFcSl(NIvaNLgvfzBbgAOSAwBBrzdkZnqvB.Add, entry));
	}

	public void Add(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		cngFjoaeXzubjErIWHAOvRlCtwmG();
		PyKYLFrxMUmCZhducvkSJxQYQkpG(new soPNFcrRohSBRDVpyROOVagrFcSl(fileName, EntryFactory.MakeFileEntry(fileName)));
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
		cngFjoaeXzubjErIWHAOvRlCtwmG();
		PyKYLFrxMUmCZhducvkSJxQYQkpG(new soPNFcrRohSBRDVpyROOVagrFcSl(dataSource, EntryFactory.MakeFileEntry(entryName, useFileSystem: false)));
	}

	public void Add(string fileName, CompressionMethod compressionMethod)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (!ZipEntry.IsCompressionMethodSupported(compressionMethod))
		{
			throw new ArgumentOutOfRangeException("compressionMethod");
		}
		cngFjoaeXzubjErIWHAOvRlCtwmG();
		eODOIiDDaUjhHGpEoFtRBNkgEPpgb = true;
		ZipEntry zipEntry = EntryFactory.MakeFileEntry(fileName);
		zipEntry.CompressionMethod = compressionMethod;
		PyKYLFrxMUmCZhducvkSJxQYQkpG(new soPNFcrRohSBRDVpyROOVagrFcSl(fileName, zipEntry));
	}

	public void Add(string fileName, string entryName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (entryName == null)
		{
			throw new ArgumentNullException("entryName");
		}
		cngFjoaeXzubjErIWHAOvRlCtwmG();
		PyKYLFrxMUmCZhducvkSJxQYQkpG(new soPNFcrRohSBRDVpyROOVagrFcSl(fileName, EntryFactory.MakeFileEntry(entryName)));
	}

	public void Add(IStaticDataSource dataSource, string entryName, CompressionMethod compressionMethod)
	{
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		if (entryName == null)
		{
			throw new ArgumentNullException("entryName");
		}
		cngFjoaeXzubjErIWHAOvRlCtwmG();
		ZipEntry zipEntry = EntryFactory.MakeFileEntry(entryName, useFileSystem: false);
		zipEntry.CompressionMethod = compressionMethod;
		PyKYLFrxMUmCZhducvkSJxQYQkpG(new soPNFcrRohSBRDVpyROOVagrFcSl(dataSource, zipEntry));
	}

	public void Add(string fileName, CompressionMethod compressionMethod, bool useUnicodeText)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (gPAJpOXsfclOUdxCUVeyxsHJtLpQ)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		if (!ZipEntry.IsCompressionMethodSupported(compressionMethod))
		{
			throw new ArgumentOutOfRangeException("compressionMethod");
		}
		cngFjoaeXzubjErIWHAOvRlCtwmG();
		eODOIiDDaUjhHGpEoFtRBNkgEPpgb = true;
		ZipEntry zipEntry = EntryFactory.MakeFileEntry(fileName);
		zipEntry.IsUnicodeText = useUnicodeText;
		zipEntry.CompressionMethod = compressionMethod;
		PyKYLFrxMUmCZhducvkSJxQYQkpG(new soPNFcrRohSBRDVpyROOVagrFcSl(fileName, zipEntry));
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
		cngFjoaeXzubjErIWHAOvRlCtwmG();
		ZipEntry zipEntry = EntryFactory.MakeFileEntry(entryName, useFileSystem: false);
		zipEntry.IsUnicodeText = useUnicodeText;
		zipEntry.CompressionMethod = compressionMethod;
		PyKYLFrxMUmCZhducvkSJxQYQkpG(new soPNFcrRohSBRDVpyROOVagrFcSl(dataSource, zipEntry));
	}

	public void AddDirectory(string directoryName)
	{
		if (directoryName == null)
		{
			throw new ArgumentNullException("directoryName");
		}
		cngFjoaeXzubjErIWHAOvRlCtwmG();
		ZipEntry entry = EntryFactory.MakeDirectoryEntry(directoryName);
		PyKYLFrxMUmCZhducvkSJxQYQkpG(new soPNFcrRohSBRDVpyROOVagrFcSl(NIvaNLgvfzBbgAOSAwBBrzdkZnqvB.Add, entry));
	}

	private void dgDDmhfOcABAqCrTrHgbKsvZOktxA(ZipFile workFile, soPNFcrRohSBRDVpyROOVagrFcSl update)
	{
		Stream stream = null;
		if (update.UOCIbsWqZlcXqzADYfCOfsLGycKO.IsFile)
		{
			stream = update.pjSyzVOahEhrQNvctyIRlHRFfutX();
			if (stream == null)
			{
				stream = TwdryllcGwHToEhCbggFFCeCxTnAA.GetSource(update.UOCIbsWqZlcXqzADYfCOfsLGycKO, update.GIvCqaQnzeuAOygMiBSMOcQTvfaD);
			}
		}
		if (stream != null)
		{
			using (stream)
			{
				long length = stream.Length;
				if (update.npCKxxeBbMgvfKZQHTZfVMqbkYsG.Size < 0L)
				{
					update.npCKxxeBbMgvfKZQHTZfVMqbkYsG.Size = length;
				}
				else if (update.npCKxxeBbMgvfKZQHTZfVMqbkYsG.Size != length)
				{
					throw new ZipException("Entry size/stream size mismatch");
				}
				workFile.kAsFIojyzCvpNTsNnafBdNKGGjYRB(update);
				long position = workFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Position;
				using (Stream destination = workFile.JBLYfdHGMIlnCDhPFnvjWCvHPyit(update.npCKxxeBbMgvfKZQHTZfVMqbkYsG))
				{
					FIfHeBAdbvcxocUEmxoDtdrmLERdA(update, destination, stream, length, updateCrc: true);
				}
				long position2 = workFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Position;
				update.npCKxxeBbMgvfKZQHTZfVMqbkYsG.CompressedSize = position2 - position;
				if ((update.npCKxxeBbMgvfKZQHTZfVMqbkYsG.Flags & 8) == 8)
				{
					new CfcHHULxLwXWsXVCpmxHEpDxPQAF(workFile.bnUsFfzRpiPSoBspiesaqzitUkVf).fJlqenbXfahrYgkwnpXdDTXpIEJK(update.npCKxxeBbMgvfKZQHTZfVMqbkYsG);
				}
				return;
			}
		}
		workFile.kAsFIojyzCvpNTsNnafBdNKGGjYRB(update);
		update.npCKxxeBbMgvfKZQHTZfVMqbkYsG.CompressedSize = 0L;
	}

	private void PyKYLFrxMUmCZhducvkSJxQYQkpG(soPNFcrRohSBRDVpyROOVagrFcSl update)
	{
		eODOIiDDaUjhHGpEoFtRBNkgEPpgb = true;
		int num = fobzNlEOgZKIEREYmXhncvXxTHEA(update.UOCIbsWqZlcXqzADYfCOfsLGycKO.Name);
		if (num >= 0)
		{
			if (daIofKLnSpllCEnnpKfpMrHMGsfM[num] == null)
			{
				WnrraMtGtghsOmjBGIHavgiOAfmx++;
			}
			daIofKLnSpllCEnnpKfpMrHMGsfM[num] = update;
		}
		else
		{
			num = daIofKLnSpllCEnnpKfpMrHMGsfM.Add(update);
			WnrraMtGtghsOmjBGIHavgiOAfmx++;
			vAFpbzdVFybLpDBYMbRZWnwmxJuC.Add(update.UOCIbsWqZlcXqzADYfCOfsLGycKO.Name, num);
		}
	}

	public void BeginUpdate()
	{
		if (Name == null)
		{
			BeginUpdate(new MemoryArchiveStorage(), new DynamicDiskDataSource());
		}
		else
		{
			BeginUpdate(new DiskArchiveStorage(this), new DynamicDiskDataSource());
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
			if (!gPAJpOXsfclOUdxCUVeyxsHJtLpQ)
			{
				if (IsEmbeddedArchive)
				{
					throw new ZipException("Cannot update embedded/SFX archives");
				}
				uikJSBoaaTSoYahFVISzZRyAjqcg = archiveStorage;
				TwdryllcGwHToEhCbggFFCeCxTnAA = dataSource;
				vAFpbzdVFybLpDBYMbRZWnwmxJuC = new Hashtable();
				daIofKLnSpllCEnnpKfpMrHMGsfM = new ArrayList(WMpBiXDdnnyUMAIJUidbupSSHYLk.Length);
				ZipEntry[] wMpBiXDdnnyUMAIJUidbupSSHYLk = WMpBiXDdnnyUMAIJUidbupSSHYLk;
				foreach (ZipEntry zipEntry in wMpBiXDdnnyUMAIJUidbupSSHYLk)
				{
					int num = daIofKLnSpllCEnnpKfpMrHMGsfM.Add(new soPNFcrRohSBRDVpyROOVagrFcSl(zipEntry));
					vAFpbzdVFybLpDBYMbRZWnwmxJuC.Add(zipEntry.Name, num);
				}
				WnrraMtGtghsOmjBGIHavgiOAfmx = daIofKLnSpllCEnnpKfpMrHMGsfM.Count;
				eODOIiDDaUjhHGpEoFtRBNkgEPpgb = false;
				fJTOYQvFrghycnoHkBbXUAzqqwYM = false;
				wnKFaCcimSZNNzGEZTpFfqkfBeIp = null;
				return;
			}
			throw new ObjectDisposedException("ZipFile");
		}
		throw new ArgumentNullException("dataSource");
	}

	private static void KoytjCHNEIFCpEqePwwbfXTLztzC(CryptoStream classicCryptoStream, ZipEntry entry)
	{
		byte[] array = new byte[12];
		StreamUtils.ReadFully(classicCryptoStream, array);
		if (array[11] != entry.rJZTdarrXDaaoJcowVDHUrDNtOtDA)
		{
			throw new ZipException("Invalid password");
		}
	}

	private void cngFjoaeXzubjErIWHAOvRlCtwmG()
	{
		if (daIofKLnSpllCEnnpKfpMrHMGsfM == null)
		{
			throw new InvalidOperationException("BeginUpdate has not been called");
		}
	}

	public void Close()
	{
		nnRBaAayOUApbDpUGaGDzbyvQDDfc(disposing: true);
		GC.SuppressFinalize(this);
	}

	public void CommitUpdate()
	{
		if (gPAJpOXsfclOUdxCUVeyxsHJtLpQ)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		cngFjoaeXzubjErIWHAOvRlCtwmG();
		try
		{
			vAFpbzdVFybLpDBYMbRZWnwmxJuC.Clear();
			vAFpbzdVFybLpDBYMbRZWnwmxJuC = null;
			if (eODOIiDDaUjhHGpEoFtRBNkgEPpgb)
			{
				oEGbKUIRRYZaVgeQkDWHaWzIVqDM();
			}
			else if (fJTOYQvFrghycnoHkBbXUAzqqwYM)
			{
				aaynbKSkBvlRCmNEuBugwQsjyrEv();
			}
			else if (WMpBiXDdnnyUMAIJUidbupSSHYLk.Length == 0)
			{
				byte[] comment = ((wnKFaCcimSZNNzGEZTpFfqkfBeIp != null) ? wnKFaCcimSZNNzGEZTpFfqkfBeIp.eHDZEvLmZcrMxObcYgEQgnuyxEYb : ZipConstants.ConvertToArray(eYQlQpyUcttysBjLvxCxuGRThsKs));
				using CfcHHULxLwXWsXVCpmxHEpDxPQAF cfcHHULxLwXWsXVCpmxHEpDxPQAF = new CfcHHULxLwXWsXVCpmxHEpDxPQAF(bnUsFfzRpiPSoBspiesaqzitUkVf);
				cfcHHULxLwXWsXVCpmxHEpDxPQAF.EVwkUZBieQSmujkYuEOuEMdWuXmM(0L, 0L, 0L, comment);
				return;
			}
		}
		finally
		{
			lwWpbgRVHScTdtRZJmCEZcjGqlzg();
		}
	}

	private void FIfHeBAdbvcxocUEmxoDtdrmLERdA(soPNFcrRohSBRDVpyROOVagrFcSl update, Stream destination, Stream source, long bytesToCopy, bool updateCrc)
	{
		if (destination == source)
		{
			throw new InvalidOperationException("Destination and source are the same");
		}
		Crc32 crc = new Crc32();
		byte[] array = BgyBGibftuFmxoIpCzucJeFEnUDp();
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
		if (num2 == num)
		{
			if (updateCrc)
			{
				update.npCKxxeBbMgvfKZQHTZfVMqbkYsG.Crc = crc.Value;
			}
			return;
		}
		throw new ZipException($"Failed to copy bytes expected {num} read {num2}");
	}

	private void uwtoJZGvZSVPMVBnpcSpmlXVNTdT(soPNFcrRohSBRDVpyROOVagrFcSl update, Stream dest, Stream source)
	{
		int num = lYZgnQeMSwpftqPxgoFmhOGCmXohA(update);
		if (num <= 0)
		{
			return;
		}
		byte[] array = BgyBGibftuFmxoIpCzucJeFEnUDp();
		while (true)
		{
			if (num > 0)
			{
				int count = Math.Min(array.Length, num);
				int num2 = source.Read(array, 0, count);
				if (num2 <= 0)
				{
					break;
				}
				dest.Write(array, 0, num2);
				num -= num2;
				continue;
			}
			return;
		}
		throw new ZipException("Unxpected end of stream");
	}

	private void bnmpXRuvzDoCrFiDSleFMNNcHGnB(soPNFcrRohSBRDVpyROOVagrFcSl update, Stream stream, ref long destinationPosition, long sourcePosition)
	{
		int num = lYZgnQeMSwpftqPxgoFmhOGCmXohA(update);
		while (true)
		{
			if (num > 0)
			{
				int count = num;
				byte[] buffer = BgyBGibftuFmxoIpCzucJeFEnUDp();
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

	private void MmSdIgciJFsoMGOMNRfUHNJPtcBUA(ZipFile workFile, soPNFcrRohSBRDVpyROOVagrFcSl update)
	{
		workFile.kAsFIojyzCvpNTsNnafBdNKGGjYRB(update);
		if (update.UOCIbsWqZlcXqzADYfCOfsLGycKO.CompressedSize > 0L)
		{
			long offset = update.UOCIbsWqZlcXqzADYfCOfsLGycKO.Offset + 26L;
			bnUsFfzRpiPSoBspiesaqzitUkVf.Seek(offset, SeekOrigin.Begin);
			uint num = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
			uint num2 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
			bnUsFfzRpiPSoBspiesaqzitUkVf.Seek(num + num2, SeekOrigin.Current);
			FIfHeBAdbvcxocUEmxoDtdrmLERdA(update, workFile.bnUsFfzRpiPSoBspiesaqzitUkVf, bnUsFfzRpiPSoBspiesaqzitUkVf, update.UOCIbsWqZlcXqzADYfCOfsLGycKO.CompressedSize, updateCrc: false);
		}
		uwtoJZGvZSVPMVBnpcSpmlXVNTdT(update, workFile.bnUsFfzRpiPSoBspiesaqzitUkVf, bnUsFfzRpiPSoBspiesaqzitUkVf);
	}

	private void tbpstcVMzLIQjqCwQdUloKQcPORK(soPNFcrRohSBRDVpyROOVagrFcSl update, Stream stream, bool updateCrc, ref long destinationPosition, ref long sourcePosition)
	{
		long num = update.UOCIbsWqZlcXqzADYfCOfsLGycKO.CompressedSize;
		Crc32 crc = new Crc32();
		byte[] array = BgyBGibftuFmxoIpCzucJeFEnUDp();
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
		if (num3 != num2)
		{
			throw new ZipException($"Failed to copy bytes expected {num2} read {num3}");
		}
		if (updateCrc)
		{
			update.npCKxxeBbMgvfKZQHTZfVMqbkYsG.Crc = crc.Value;
		}
	}

	private void UXiSKwvUNIuGKYFaXdzzCAwEDctWA(ZipFile workFile, soPNFcrRohSBRDVpyROOVagrFcSl update, ref long destinationPosition)
	{
		bool flag = false;
		if (update.UOCIbsWqZlcXqzADYfCOfsLGycKO.Offset == destinationPosition)
		{
			flag = true;
		}
		if (!flag)
		{
			bnUsFfzRpiPSoBspiesaqzitUkVf.Position = destinationPosition;
			workFile.kAsFIojyzCvpNTsNnafBdNKGGjYRB(update);
			destinationPosition = bnUsFfzRpiPSoBspiesaqzitUkVf.Position;
		}
		long num = 0L;
		long num2 = update.UOCIbsWqZlcXqzADYfCOfsLGycKO.Offset + 26L;
		bnUsFfzRpiPSoBspiesaqzitUkVf.Seek(num2, SeekOrigin.Begin);
		uint num3 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
		uint num4 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
		num = bnUsFfzRpiPSoBspiesaqzitUkVf.Position + num3 + num4;
		if (flag)
		{
			destinationPosition += num - num2 + 26L + update.UOCIbsWqZlcXqzADYfCOfsLGycKO.CompressedSize + lYZgnQeMSwpftqPxgoFmhOGCmXohA(update);
			return;
		}
		if (update.UOCIbsWqZlcXqzADYfCOfsLGycKO.CompressedSize > 0L)
		{
			tbpstcVMzLIQjqCwQdUloKQcPORK(update, bnUsFfzRpiPSoBspiesaqzitUkVf, updateCrc: false, ref destinationPosition, ref num);
		}
		bnmpXRuvzDoCrFiDSleFMNNcHGnB(update, bnUsFfzRpiPSoBspiesaqzitUkVf, ref destinationPosition, num);
	}

	public static ZipFile Create(Stream outStream)
	{
		if (outStream == null)
		{
			throw new ArgumentNullException("outStream");
		}
		if (!outStream.CanWrite)
		{
			throw new ArgumentException("Stream is not writeable", "outStream");
		}
		if (!outStream.CanSeek)
		{
			throw new ArgumentException("Stream is not seekable", "outStream");
		}
		return new ZipFile
		{
			bnUsFfzRpiPSoBspiesaqzitUkVf = outStream
		};
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
			tRVAXCmQaABtTkPdDStnZsUXXSwn = fileName,
			bnUsFfzRpiPSoBspiesaqzitUkVf = fileStream,
			wLAMyKxDbSSzQUvMyMwOQVxXsyqm = true
		};
	}

	private Stream nWRUCDAkHviwtDIFbdocLdwEcnan(Stream baseStream, ZipEntry entry)
	{
		if (entry.Version >= 50 && ((uint)entry.Flags & 0x40u) != 0)
		{
			throw new ZipException("Decryption method not supported");
		}
		PkzipClassicManaged pkzipClassicManaged = new PkzipClassicManaged();
		fAkLxXdURwufbvnQTBkAoBOgesSr(entry.Name);
		if (!FLchgkTeUbJpdSFXUHHWWdzkWFst)
		{
			throw new ZipException("No password available for encrypted stream");
		}
		CryptoStream cryptoStream = new CryptoStream(baseStream, pkzipClassicManaged.CreateDecryptor(YzBRIVUxaJVmjEDtROkGJXZIcLMW, null), CryptoStreamMode.Read);
		KoytjCHNEIFCpEqePwwbfXTLztzC(cryptoStream, entry);
		return cryptoStream;
	}

	private Stream zrRdmrFKBeWgzWUwaBmGzSIvjtsSA(Stream baseStream, ZipEntry entry)
	{
		CryptoStream cryptoStream = null;
		if (entry.Version < 50 || (entry.Flags & 0x40) == 0)
		{
			PkzipClassicManaged pkzipClassicManaged = new PkzipClassicManaged();
			fAkLxXdURwufbvnQTBkAoBOgesSr(entry.Name);
			if (!FLchgkTeUbJpdSFXUHHWWdzkWFst)
			{
				throw new ZipException("No password available for encrypted stream");
			}
			cryptoStream = new CryptoStream(new epazeRvPjpoWBAzRMdLTbXFnrrCj(baseStream), pkzipClassicManaged.CreateEncryptor(YzBRIVUxaJVmjEDtROkGJXZIcLMW, null), CryptoStreamMode.Write);
			if (entry.Crc >= 0L && (entry.Flags & 8) == 0)
			{
				kajZHFBujrfZRwJQCDBjLWRBRCMT(cryptoStream, entry.Crc);
				return cryptoStream;
			}
			kajZHFBujrfZRwJQCDBjLWRBRCMT(cryptoStream, entry.DosTime << 16);
		}
		return cryptoStream;
	}

	public void Delete(ZipEntry entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		cngFjoaeXzubjErIWHAOvRlCtwmG();
		int num = fobzNlEOgZKIEREYmXhncvXxTHEA(entry);
		if (num < 0)
		{
			throw new ZipException("Cannot find entry to delete");
		}
		eODOIiDDaUjhHGpEoFtRBNkgEPpgb = true;
		daIofKLnSpllCEnnpKfpMrHMGsfM[num] = null;
		WnrraMtGtghsOmjBGIHavgiOAfmx--;
	}

	public bool Delete(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		cngFjoaeXzubjErIWHAOvRlCtwmG();
		int num = fobzNlEOgZKIEREYmXhncvXxTHEA(fileName);
		if (num < 0 || daIofKLnSpllCEnnpKfpMrHMGsfM[num] == null)
		{
			throw new ZipException("Cannot find entry to delete");
		}
		eODOIiDDaUjhHGpEoFtRBNkgEPpgb = true;
		daIofKLnSpllCEnnpKfpMrHMGsfM[num] = null;
		WnrraMtGtghsOmjBGIHavgiOAfmx--;
		return true;
	}

	protected virtual void Dispose(bool disposing)
	{
		nnRBaAayOUApbDpUGaGDzbyvQDDfc(disposing);
	}

	private void nnRBaAayOUApbDpUGaGDzbyvQDDfc(bool disposing)
	{
		if (gPAJpOXsfclOUdxCUVeyxsHJtLpQ)
		{
			return;
		}
		gPAJpOXsfclOUdxCUVeyxsHJtLpQ = true;
		WMpBiXDdnnyUMAIJUidbupSSHYLk = new ZipEntry[0];
		if (IsStreamOwner && bnUsFfzRpiPSoBspiesaqzitUkVf != null)
		{
			lock (bnUsFfzRpiPSoBspiesaqzitUkVf)
			{
				bnUsFfzRpiPSoBspiesaqzitUkVf.Close();
			}
		}
		lwWpbgRVHScTdtRZJmCEZcjGqlzg();
	}

	~ZipFile()
	{
		Dispose(disposing: false);
	}

	public int FindEntry(string name, bool ignoreCase)
	{
		if (gPAJpOXsfclOUdxCUVeyxsHJtLpQ)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		for (int i = 0; i < WMpBiXDdnnyUMAIJUidbupSSHYLk.Length; i++)
		{
			if (string.Compare(name, WMpBiXDdnnyUMAIJUidbupSSHYLk[i].Name, ignoreCase, CultureInfo.InvariantCulture) == 0)
			{
				return i;
			}
		}
		return -1;
	}

	private int fobzNlEOgZKIEREYmXhncvXxTHEA(ZipEntry entry)
	{
		int result = -1;
		string key = XBmglfauJrcIemITChevUGQYqGcJA(entry.Name);
		if (vAFpbzdVFybLpDBYMbRZWnwmxJuC.ContainsKey(key))
		{
			result = (int)vAFpbzdVFybLpDBYMbRZWnwmxJuC[key];
		}
		return result;
	}

	private int fobzNlEOgZKIEREYmXhncvXxTHEA(string fileName)
	{
		int result = -1;
		string key = XBmglfauJrcIemITChevUGQYqGcJA(fileName);
		if (vAFpbzdVFybLpDBYMbRZWnwmxJuC.ContainsKey(key))
		{
			result = (int)vAFpbzdVFybLpDBYMbRZWnwmxJuC[key];
		}
		return result;
	}

	private byte[] BgyBGibftuFmxoIpCzucJeFEnUDp()
	{
		if (nBHFYtFHhCTQngPyAgswVuWtDAeI == null)
		{
			nBHFYtFHhCTQngPyAgswVuWtDAeI = new byte[VtubFCRTrgJIBihIMhvkubjWtNnu];
		}
		return nBHFYtFHhCTQngPyAgswVuWtDAeI;
	}

	private int lYZgnQeMSwpftqPxgoFmhOGCmXohA(soPNFcrRohSBRDVpyROOVagrFcSl update)
	{
		int result = 0;
		if (((uint)update.UOCIbsWqZlcXqzADYfCOfsLGycKO.Flags & 8u) != 0)
		{
			result = 12;
			if (update.UOCIbsWqZlcXqzADYfCOfsLGycKO.LocalHeaderRequiresZip64)
			{
				result = 20;
			}
		}
		return result;
	}

	public ZipEntry GetEntry(string name)
	{
		if (gPAJpOXsfclOUdxCUVeyxsHJtLpQ)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		int num = FindEntry(name, ignoreCase: true);
		if (num < 0)
		{
			return null;
		}
		return (ZipEntry)WMpBiXDdnnyUMAIJUidbupSSHYLk[num].Clone();
	}

	public IEnumerator GetEnumerator()
	{
		if (gPAJpOXsfclOUdxCUVeyxsHJtLpQ)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		return new QHVnjcPoIdWEIreokrYmrvwZlQHR(WMpBiXDdnnyUMAIJUidbupSSHYLk);
	}

	public Stream GetInputStream(ZipEntry entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		if (!gPAJpOXsfclOUdxCUVeyxsHJtLpQ)
		{
			long num = entry.ZipFileIndex;
			if (num < 0L || num >= WMpBiXDdnnyUMAIJUidbupSSHYLk.Length || WMpBiXDdnnyUMAIJUidbupSSHYLk[(int)(IntPtr)num].Name != entry.Name)
			{
				num = FindEntry(entry.Name, ignoreCase: true);
				if (num < 0L)
				{
					throw new ZipException("Entry cannot be found");
				}
			}
			return GetInputStream(num);
		}
		throw new ObjectDisposedException("ZipFile");
	}

	public Stream GetInputStream(long entryIndex)
	{
		if (gPAJpOXsfclOUdxCUVeyxsHJtLpQ)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		long start = GkvwSuMfvNIZAzgcvgnDEwfMCigDA(WMpBiXDdnnyUMAIJUidbupSSHYLk[(int)(IntPtr)entryIndex]);
		CompressionMethod compressionMethod = WMpBiXDdnnyUMAIJUidbupSSHYLk[(int)(IntPtr)entryIndex].CompressionMethod;
		Stream stream = new ZstJItbZbaATJbHdCeNCjhtlUrkA(this, start, WMpBiXDdnnyUMAIJUidbupSSHYLk[(int)(IntPtr)entryIndex].CompressedSize);
		if (WMpBiXDdnnyUMAIJUidbupSSHYLk[(int)(IntPtr)entryIndex].IsCrypted)
		{
			stream = nWRUCDAkHviwtDIFbdocLdwEcnan(stream, WMpBiXDdnnyUMAIJUidbupSSHYLk[(int)(IntPtr)entryIndex]);
			if (stream == null)
			{
				throw new ZipException("Unable to decrypt this entry");
			}
		}
		return compressionMethod switch
		{
			CompressionMethod.Stored => stream, 
			CompressionMethod.Deflated => new InflaterInputStream(stream, new Inflater(noHeader: true)), 
			_ => throw new ZipException("Unsupported compression method " + compressionMethod), 
		};
	}

	private Stream JBLYfdHGMIlnCDhPFnvjWCvHPyit(ZipEntry entry)
	{
		Stream stream = bnUsFfzRpiPSoBspiesaqzitUkVf;
		if (entry.IsCrypted)
		{
			stream = zrRdmrFKBeWgzWUwaBmGzSIvjtsSA(stream, entry);
		}
		return entry.CompressionMethod switch
		{
			CompressionMethod.Deflated => new DeflaterOutputStream(stream, new Deflater(9, noZlibHeaderOrFooter: true))
			{
				IsStreamOwner = false
			}, 
			CompressionMethod.Stored => new epazeRvPjpoWBAzRMdLTbXFnrrCj(stream), 
			_ => throw new ZipException("Unknown compression method " + entry.CompressionMethod), 
		};
	}

	private string QnunnhkUxHSVsKAFfCygcacdFcgNA(string name)
	{
		if (NameTransform == null)
		{
			return name;
		}
		return NameTransform.TransformDirectory(name);
	}

	private string XBmglfauJrcIemITChevUGQYqGcJA(string name)
	{
		if (NameTransform == null)
		{
			return name;
		}
		return NameTransform.TransformFile(name);
	}

	private long RWJEtMzwFGAycwGfgDZhGGVDMqtQ(int signature, long endLocation, int minimumBlockSize, int maximumVariableData)
	{
		using CfcHHULxLwXWsXVCpmxHEpDxPQAF cfcHHULxLwXWsXVCpmxHEpDxPQAF = new CfcHHULxLwXWsXVCpmxHEpDxPQAF(bnUsFfzRpiPSoBspiesaqzitUkVf);
		return cfcHHULxLwXWsXVCpmxHEpDxPQAF.RWJEtMzwFGAycwGfgDZhGGVDMqtQ(signature, endLocation, minimumBlockSize, maximumVariableData);
	}

	private long GkvwSuMfvNIZAzgcvgnDEwfMCigDA(ZipEntry entry)
	{
		return UxgMJxzfBgJHMEapoYtnzieCeMHw(entry, mJMGpmMuVGWvpjuNdoffJSUuVlYX.Extract);
	}

	private void JKezsmRAzTAvkkoYrFWcdEAWuERRA(ZipFile workFile, soPNFcrRohSBRDVpyROOVagrFcSl update)
	{
		workFile.kAsFIojyzCvpNTsNnafBdNKGGjYRB(update);
		long position = workFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Position;
		if (update.UOCIbsWqZlcXqzADYfCOfsLGycKO.IsFile && update.GIvCqaQnzeuAOygMiBSMOcQTvfaD != null)
		{
			using Stream destination = workFile.JBLYfdHGMIlnCDhPFnvjWCvHPyit(update.npCKxxeBbMgvfKZQHTZfVMqbkYsG);
			using Stream stream = GetInputStream(update.UOCIbsWqZlcXqzADYfCOfsLGycKO);
			FIfHeBAdbvcxocUEmxoDtdrmLERdA(update, destination, stream, stream.Length, updateCrc: true);
		}
		long position2 = workFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Position;
		update.UOCIbsWqZlcXqzADYfCOfsLGycKO.CompressedSize = position2 - position;
	}

	private void fAkLxXdURwufbvnQTBkAoBOgesSr(string fileName)
	{
		if (KeysRequired != null)
		{
			KeysRequiredEventArgs keysRequiredEventArgs = new KeysRequiredEventArgs(fileName, YzBRIVUxaJVmjEDtROkGJXZIcLMW);
			KeysRequired(this, keysRequiredEventArgs);
			YzBRIVUxaJVmjEDtROkGJXZIcLMW = keysRequiredEventArgs.Key;
		}
	}

	private void lwWpbgRVHScTdtRZJmCEZcjGqlzg()
	{
		if (uikJSBoaaTSoYahFVISzZRyAjqcg != null)
		{
			uikJSBoaaTSoYahFVISzZRyAjqcg.Dispose();
			uikJSBoaaTSoYahFVISzZRyAjqcg = null;
		}
		TwdryllcGwHToEhCbggFFCeCxTnAA = null;
		daIofKLnSpllCEnnpKfpMrHMGsfM = null;
		vAFpbzdVFybLpDBYMbRZWnwmxJuC = null;
	}

	private void ivppqJuGdrEizTlSekNEgrsYzehG()
	{
		if (!bnUsFfzRpiPSoBspiesaqzitUkVf.CanSeek)
		{
			throw new ZipException("ZipFile stream must be seekable");
		}
		long num = RWJEtMzwFGAycwGfgDZhGGVDMqtQ(101010256, bnUsFfzRpiPSoBspiesaqzitUkVf.Length, 22, 65535);
		if (num < 0L)
		{
			throw new ZipException("Cannot find central directory");
		}
		ushort num2 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
		ushort num3 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
		ulong num4 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
		ulong num5 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
		ulong num6 = JMolyeGQcnyfyEmLDEhvDKSCZgIB();
		long num7 = JMolyeGQcnyfyEmLDEhvDKSCZgIB();
		uint num8 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
		if (num8 != 0)
		{
			byte[] array = new byte[num8];
			StreamUtils.ReadFully(bnUsFfzRpiPSoBspiesaqzitUkVf, array);
			eYQlQpyUcttysBjLvxCxuGRThsKs = ZipConstants.ConvertToString(array);
		}
		else
		{
			eYQlQpyUcttysBjLvxCxuGRThsKs = string.Empty;
		}
		bool flag = false;
		if (num2 == ushort.MaxValue || num3 == ushort.MaxValue || num4 == 65535L || num5 == 65535L || num6 == 4294967295L || num7 == 4294967295L)
		{
			flag = true;
			if (RWJEtMzwFGAycwGfgDZhGGVDMqtQ(117853008, num, 0, 4096) < 0L)
			{
				throw new ZipException("Cannot find Zip64 locator");
			}
			JMolyeGQcnyfyEmLDEhvDKSCZgIB();
			ulong num9 = oEwdxFIQgRLUfyoNzHDBEZxzwUeCA();
			JMolyeGQcnyfyEmLDEhvDKSCZgIB();
			bnUsFfzRpiPSoBspiesaqzitUkVf.Position = (long)num9;
			if ((long)JMolyeGQcnyfyEmLDEhvDKSCZgIB() != 101075792L)
			{
				throw new ZipException($"Invalid Zip64 Central directory signature at {num9:X}");
			}
			oEwdxFIQgRLUfyoNzHDBEZxzwUeCA();
			LWyXKQbezwbfCAlKtXHCAhJwpPcU();
			LWyXKQbezwbfCAlKtXHCAhJwpPcU();
			JMolyeGQcnyfyEmLDEhvDKSCZgIB();
			JMolyeGQcnyfyEmLDEhvDKSCZgIB();
			num4 = oEwdxFIQgRLUfyoNzHDBEZxzwUeCA();
			num5 = oEwdxFIQgRLUfyoNzHDBEZxzwUeCA();
			num6 = oEwdxFIQgRLUfyoNzHDBEZxzwUeCA();
			num7 = (long)oEwdxFIQgRLUfyoNzHDBEZxzwUeCA();
		}
		WMpBiXDdnnyUMAIJUidbupSSHYLk = new ZipEntry[num4];
		if (!flag && num7 < num - (long)(4L + num6))
		{
			rlpITDpbFOegFjOmeudatAjEFLaSA = num - ((long)(4L + num6) + num7);
			if (rlpITDpbFOegFjOmeudatAjEFLaSA <= 0L)
			{
				throw new ZipException("Invalid embedded zip archive");
			}
		}
		bnUsFfzRpiPSoBspiesaqzitUkVf.Seek(rlpITDpbFOegFjOmeudatAjEFLaSA + num7, SeekOrigin.Begin);
		ulong num10 = 0uL;
		while (true)
		{
			if (num10 < num4)
			{
				if (JMolyeGQcnyfyEmLDEhvDKSCZgIB() != 33639248)
				{
					break;
				}
				int madeByInfo = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
				int versionRequiredToExtract = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
				int num11 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
				int method = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
				uint num12 = JMolyeGQcnyfyEmLDEhvDKSCZgIB();
				uint num13 = JMolyeGQcnyfyEmLDEhvDKSCZgIB();
				long num14 = JMolyeGQcnyfyEmLDEhvDKSCZgIB();
				long num15 = JMolyeGQcnyfyEmLDEhvDKSCZgIB();
				int num16 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
				int num17 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
				int num18 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
				LWyXKQbezwbfCAlKtXHCAhJwpPcU();
				LWyXKQbezwbfCAlKtXHCAhJwpPcU();
				uint externalFileAttributes = JMolyeGQcnyfyEmLDEhvDKSCZgIB();
				long offset = JMolyeGQcnyfyEmLDEhvDKSCZgIB();
				byte[] array2 = new byte[Math.Max(num16, num18)];
				StreamUtils.ReadFully(bnUsFfzRpiPSoBspiesaqzitUkVf, array2, 0, num16);
				ZipEntry zipEntry = new ZipEntry(ZipConstants.ConvertToStringExt(num11, array2, num16), versionRequiredToExtract, madeByInfo, (CompressionMethod)method);
				zipEntry.Crc = (long)num13 & 0xFFFFFFFFL;
				zipEntry.Size = num15 & 0xFFFFFFFFL;
				zipEntry.CompressedSize = num14 & 0xFFFFFFFFL;
				zipEntry.Flags = num11;
				zipEntry.DosTime = num12;
				zipEntry.ZipFileIndex = (long)num10;
				zipEntry.Offset = offset;
				zipEntry.ExternalFileAttributes = (int)externalFileAttributes;
				if ((num11 & 8) == 0)
				{
					zipEntry.rJZTdarrXDaaoJcowVDHUrDNtOtDA = (byte)(num13 >> 24);
				}
				else
				{
					zipEntry.rJZTdarrXDaaoJcowVDHUrDNtOtDA = (byte)((num12 >> 8) & 0xFFu);
				}
				if (num17 > 0)
				{
					byte[] array3 = new byte[num17];
					StreamUtils.ReadFully(bnUsFfzRpiPSoBspiesaqzitUkVf, array3);
					zipEntry.ExtraData = array3;
				}
				zipEntry.FaiEDFBWmsKkhQbvMleyMnUFnRnFA(localHeader: false);
				if (num18 > 0)
				{
					StreamUtils.ReadFully(bnUsFfzRpiPSoBspiesaqzitUkVf, array2, 0, num18);
					zipEntry.Comment = ZipConstants.ConvertToStringExt(num11, array2, num18);
				}
				WMpBiXDdnnyUMAIJUidbupSSHYLk[(int)(IntPtr)checked((long)num10)] = zipEntry;
				num10++;
				continue;
			}
			return;
		}
		throw new ZipException("Wrong Central Directory signature");
	}

	private uint JMolyeGQcnyfyEmLDEhvDKSCZgIB()
	{
		return (uint)(LWyXKQbezwbfCAlKtXHCAhJwpPcU() | (LWyXKQbezwbfCAlKtXHCAhJwpPcU() << 16));
	}

	private ulong oEwdxFIQgRLUfyoNzHDBEZxzwUeCA()
	{
		return JMolyeGQcnyfyEmLDEhvDKSCZgIB() | JMolyeGQcnyfyEmLDEhvDKSCZgIB();
	}

	private ushort LWyXKQbezwbfCAlKtXHCAhJwpPcU()
	{
		int num = bnUsFfzRpiPSoBspiesaqzitUkVf.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException("End of stream");
		}
		int num2 = bnUsFfzRpiPSoBspiesaqzitUkVf.ReadByte();
		if (num2 < 0)
		{
			throw new EndOfStreamException("End of stream");
		}
		return (ushort)((ushort)num | (ushort)(num2 << 8));
	}

	private void fitAzNKTtWgtVkffXrCAcDQDBemEb()
	{
		if (Name == null)
		{
			throw new InvalidOperationException("Name is not known cannot Reopen");
		}
		fitAzNKTtWgtVkffXrCAcDQDBemEb(File.OpenRead(Name));
	}

	private void fitAzNKTtWgtVkffXrCAcDQDBemEb(Stream source)
	{
		if (source == null)
		{
			throw new ZipException("Failed to reopen archive - no source");
		}
		qRVGSoJSNHSymizMswHuxUeHjDpv = false;
		bnUsFfzRpiPSoBspiesaqzitUkVf = source;
		ivppqJuGdrEizTlSekNEgrsYzehG();
	}

	private void oEGbKUIRRYZaVgeQkDWHaWzIVqDM()
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
			zipFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Position = 0L;
			flag2 = true;
		}
		else if (uikJSBoaaTSoYahFVISzZRyAjqcg.UpdateMode == FileUpdateMode.Direct)
		{
			zipFile = this;
			zipFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Position = 0L;
			flag2 = true;
			daIofKLnSpllCEnnpKfpMrHMGsfM.Sort(new TfSXXzVGDtopWdrFspvCSAdQDRJS());
		}
		else
		{
			zipFile = Create(uikJSBoaaTSoYahFVISzZRyAjqcg.GetTemporaryOutput());
			zipFile.UseZip64 = UseZip64;
			if (YzBRIVUxaJVmjEDtROkGJXZIcLMW != null)
			{
				zipFile.YzBRIVUxaJVmjEDtROkGJXZIcLMW = (byte[])YzBRIVUxaJVmjEDtROkGJXZIcLMW.Clone();
			}
		}
		try
		{
			foreach (soPNFcrRohSBRDVpyROOVagrFcSl item in daIofKLnSpllCEnnpKfpMrHMGsfM)
			{
				if (item == null)
				{
					continue;
				}
				switch (item.DpsNxfjXebzjbJLZjNeKaNbDSKib)
				{
				case NIvaNLgvfzBbgAOSAwBBrzdkZnqvB.Copy:
					if (!flag2)
					{
						MmSdIgciJFsoMGOMNRfUHNJPtcBUA(zipFile, item);
					}
					else
					{
						UXiSKwvUNIuGKYFaXdzzCAwEDctWA(zipFile, item, ref destinationPosition);
					}
					break;
				case NIvaNLgvfzBbgAOSAwBBrzdkZnqvB.Modify:
					JKezsmRAzTAvkkoYrFWcdEAWuERRA(zipFile, item);
					break;
				case NIvaNLgvfzBbgAOSAwBBrzdkZnqvB.Add:
					if (!IsNewArchive && flag2)
					{
						zipFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Position = destinationPosition;
					}
					dgDDmhfOcABAqCrTrHgbKsvZOktxA(zipFile, item);
					if (flag2)
					{
						destinationPosition = zipFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Position;
					}
					break;
				}
			}
			if (!IsNewArchive && flag2)
			{
				zipFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Position = destinationPosition;
			}
			long position = zipFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Position;
			foreach (soPNFcrRohSBRDVpyROOVagrFcSl item2 in daIofKLnSpllCEnnpKfpMrHMGsfM)
			{
				if (item2 != null)
				{
					num += zipFile.pDKgpscSTlnjXHJQFcwwHRZFZApab(item2.npCKxxeBbMgvfKZQHTZfVMqbkYsG);
				}
			}
			byte[] comment = ((wnKFaCcimSZNNzGEZTpFfqkfBeIp != null) ? wnKFaCcimSZNNzGEZTpFfqkfBeIp.eHDZEvLmZcrMxObcYgEQgnuyxEYb : ZipConstants.ConvertToArray(eYQlQpyUcttysBjLvxCxuGRThsKs));
			using (CfcHHULxLwXWsXVCpmxHEpDxPQAF cfcHHULxLwXWsXVCpmxHEpDxPQAF = new CfcHHULxLwXWsXVCpmxHEpDxPQAF(zipFile.bnUsFfzRpiPSoBspiesaqzitUkVf))
			{
				cfcHHULxLwXWsXVCpmxHEpDxPQAF.EVwkUZBieQSmujkYuEOuEMdWuXmM(WnrraMtGtghsOmjBGIHavgiOAfmx, num, position, comment);
			}
			length = zipFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Position;
			foreach (soPNFcrRohSBRDVpyROOVagrFcSl item3 in daIofKLnSpllCEnnpKfpMrHMGsfM)
			{
				if (item3 == null)
				{
					continue;
				}
				if (item3.PmXFDcEEZNENWDwaSzNfKbaArGrK > 0L && item3.npCKxxeBbMgvfKZQHTZfVMqbkYsG.CompressedSize > 0L)
				{
					zipFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Position = item3.PmXFDcEEZNENWDwaSzNfKbaArGrK;
					zipFile.lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)item3.npCKxxeBbMgvfKZQHTZfVMqbkYsG.Crc);
				}
				if (item3.vnLjtACtQCkQLFooYjuTVYxDgGcI > 0L)
				{
					zipFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Position = item3.vnLjtACtQCkQLFooYjuTVYxDgGcI;
					if (!item3.npCKxxeBbMgvfKZQHTZfVMqbkYsG.LocalHeaderRequiresZip64)
					{
						zipFile.lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)item3.npCKxxeBbMgvfKZQHTZfVMqbkYsG.CompressedSize);
						zipFile.lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)item3.npCKxxeBbMgvfKZQHTZfVMqbkYsG.Size);
					}
					else
					{
						zipFile.VFgRDKXYZqnnFobLuQUciDMkCOVk(item3.npCKxxeBbMgvfKZQHTZfVMqbkYsG.Size);
						zipFile.VFgRDKXYZqnnFobLuQUciDMkCOVk(item3.npCKxxeBbMgvfKZQHTZfVMqbkYsG.CompressedSize);
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
			if (flag2)
			{
				if (flag)
				{
					zipFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Flush();
					zipFile.bnUsFfzRpiPSoBspiesaqzitUkVf.SetLength(length);
				}
			}
			else
			{
				zipFile.Close();
			}
		}
		if (flag)
		{
			if (flag2)
			{
				qRVGSoJSNHSymizMswHuxUeHjDpv = false;
				zipFile.bnUsFfzRpiPSoBspiesaqzitUkVf.Flush();
				ivppqJuGdrEizTlSekNEgrsYzehG();
			}
			else
			{
				bnUsFfzRpiPSoBspiesaqzitUkVf.Close();
				fitAzNKTtWgtVkffXrCAcDQDBemEb(uikJSBoaaTSoYahFVISzZRyAjqcg.ConvertTemporaryToFinal());
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
		if (gPAJpOXsfclOUdxCUVeyxsHJtLpQ)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		cngFjoaeXzubjErIWHAOvRlCtwmG();
		wnKFaCcimSZNNzGEZTpFfqkfBeIp = new pMXyhoEtXqmkgSxZbtrKJKCmiKkfA(comment);
		if (wnKFaCcimSZNNzGEZTpFfqkfBeIp.ybqJIjHpOWbxJALRlTOWTAAspxUCb > 65535)
		{
			wnKFaCcimSZNNzGEZTpFfqkfBeIp = null;
			throw new ZipException("Comment length exceeds maximum - 65535");
		}
		fJTOYQvFrghycnoHkBbXUAzqqwYM = true;
	}

	void IDisposable.Dispose()
	{
		GC.SuppressFinalize(this);
	}

	public bool TestArchive(bool testData)
	{
		return TestArchive(testData, TestStrategy.FindFirstError, null);
	}

	public bool TestArchive(bool testData, TestStrategy strategy, ZipTestResultHandler resultHandler)
	{
		if (gPAJpOXsfclOUdxCUVeyxsHJtLpQ)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		TestStatus testStatus = new TestStatus(this);
		resultHandler?.Invoke(testStatus, null);
		mJMGpmMuVGWvpjuNdoffJSUuVlYX tests = (testData ? (mJMGpmMuVGWvpjuNdoffJSUuVlYX.Extract | mJMGpmMuVGWvpjuNdoffJSUuVlYX.Header) : mJMGpmMuVGWvpjuNdoffJSUuVlYX.Header);
		bool flag = true;
		try
		{
			int num = 0;
			while (flag && num < Count)
			{
				if (resultHandler != null)
				{
					testStatus.VWczLRxkaDJBCdXStllZJiRsBpnZ(this[num]);
					testStatus.wIHSnlsOnWcmBRTUGkJqXgowUytH(TestOperation.EntryHeader);
					resultHandler(testStatus, null);
				}
				try
				{
					UxgMJxzfBgJHMEapoYtnzieCeMHw(this[num], tests);
				}
				catch (ZipException ex)
				{
					testStatus.vMnKaDxSRWCbXkMedSWQLOAsrcDwA();
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
						testStatus.wIHSnlsOnWcmBRTUGkJqXgowUytH(TestOperation.EntryData);
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
								testStatus.mQbsCOstuciNHDdWGBdEKdeffhkF(num2);
								resultHandler(testStatus, null);
							}
						}
					}
					if (this[num].Crc != crc.Value)
					{
						testStatus.vMnKaDxSRWCbXkMedSWQLOAsrcDwA();
						resultHandler?.Invoke(testStatus, "CRC mismatch");
						if (strategy == TestStrategy.FindFirstError)
						{
							flag = false;
						}
					}
					if (((uint)this[num].Flags & 8u) != 0)
					{
						CfcHHULxLwXWsXVCpmxHEpDxPQAF cfcHHULxLwXWsXVCpmxHEpDxPQAF = new CfcHHULxLwXWsXVCpmxHEpDxPQAF(bnUsFfzRpiPSoBspiesaqzitUkVf);
						DescriptorData descriptorData = new DescriptorData();
						cfcHHULxLwXWsXVCpmxHEpDxPQAF.VPNVkTYFRgWjVXjCBrNWSFxnHlgi(this[num].LocalHeaderRequiresZip64, descriptorData);
						if (this[num].Crc != descriptorData.Crc)
						{
							testStatus.vMnKaDxSRWCbXkMedSWQLOAsrcDwA();
						}
						if (this[num].CompressedSize != descriptorData.CompressedSize)
						{
							testStatus.vMnKaDxSRWCbXkMedSWQLOAsrcDwA();
						}
						if (this[num].Size != descriptorData.Size)
						{
							testStatus.vMnKaDxSRWCbXkMedSWQLOAsrcDwA();
						}
					}
				}
				if (resultHandler != null)
				{
					testStatus.wIHSnlsOnWcmBRTUGkJqXgowUytH(TestOperation.EntryComplete);
					resultHandler(testStatus, null);
				}
				num++;
			}
			if (resultHandler != null)
			{
				testStatus.wIHSnlsOnWcmBRTUGkJqXgowUytH(TestOperation.MiscellaneousTests);
				resultHandler(testStatus, null);
			}
		}
		catch (Exception ex2)
		{
			testStatus.vMnKaDxSRWCbXkMedSWQLOAsrcDwA();
			resultHandler?.Invoke(testStatus, $"Exception during test - '{ex2.Message}'");
		}
		if (resultHandler != null)
		{
			testStatus.wIHSnlsOnWcmBRTUGkJqXgowUytH(TestOperation.Complete);
			testStatus.VWczLRxkaDJBCdXStllZJiRsBpnZ(null);
			resultHandler(testStatus, null);
		}
		return testStatus.ErrorCount == 0;
	}

	private long UxgMJxzfBgJHMEapoYtnzieCeMHw(ZipEntry entry, mJMGpmMuVGWvpjuNdoffJSUuVlYX tests)
	{
		lock (bnUsFfzRpiPSoBspiesaqzitUkVf)
		{
			_ = 310670383;
			bool num = (tests & mJMGpmMuVGWvpjuNdoffJSUuVlYX.Header) != 0;
			bool num2 = (tests & mJMGpmMuVGWvpjuNdoffJSUuVlYX.Extract) != 0;
			bnUsFfzRpiPSoBspiesaqzitUkVf.Seek(rlpITDpbFOegFjOmeudatAjEFLaSA + entry.Offset, SeekOrigin.Begin);
			if (JMolyeGQcnyfyEmLDEhvDKSCZgIB() != 67324752)
			{
				throw new ZipException($"Wrong local header signature @{rlpITDpbFOegFjOmeudatAjEFLaSA + entry.Offset:X}");
			}
			short num3 = (short)LWyXKQbezwbfCAlKtXHCAhJwpPcU();
			short num4 = (short)LWyXKQbezwbfCAlKtXHCAhJwpPcU();
			short num5 = (short)LWyXKQbezwbfCAlKtXHCAhJwpPcU();
			short num6 = (short)LWyXKQbezwbfCAlKtXHCAhJwpPcU();
			short num7 = (short)LWyXKQbezwbfCAlKtXHCAhJwpPcU();
			uint num8 = JMolyeGQcnyfyEmLDEhvDKSCZgIB();
			long num9 = JMolyeGQcnyfyEmLDEhvDKSCZgIB();
			long num10 = JMolyeGQcnyfyEmLDEhvDKSCZgIB();
			int num11 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
			int num12 = LWyXKQbezwbfCAlKtXHCAhJwpPcU();
			byte[] array = new byte[num11];
			StreamUtils.ReadFully(bnUsFfzRpiPSoBspiesaqzitUkVf, array);
			byte[] array2 = new byte[num12];
			StreamUtils.ReadFully(bnUsFfzRpiPSoBspiesaqzitUkVf, array2);
			ZipExtraData zipExtraData = new ZipExtraData(array2);
			if (zipExtraData.Find(1))
			{
				if (num3 < 45)
				{
					throw new ZipException($"Extra data contains Zip64 information but version {num3 / 10}.{num3 % 10} is not high enough");
				}
				if ((int)num10 != -1 && (int)num9 != -1)
				{
					throw new ZipException("Entry sizes not correct for Zip64");
				}
				num10 = zipExtraData.ReadLong();
				num9 = zipExtraData.ReadLong();
				if (((uint)num4 & 8u) != 0)
				{
					if (num10 != -1L && num10 != entry.Size)
					{
						throw new ZipException("Size invalid for descriptor");
					}
					if (num9 != -1L && num9 != entry.CompressedSize)
					{
						throw new ZipException("Compressed size invalid for descriptor");
					}
				}
			}
			else if (num3 >= 45 && ((int)num10 == -1 || (int)num9 == -1))
			{
				throw new ZipException("Required Zip64 extended information missing");
			}
			if (num2 && entry.IsFile)
			{
				if (!entry.IsCompressionMethodSupported())
				{
					throw new ZipException("Compression method not supported");
				}
				if (num3 > 45 || (num3 > 20 && num3 < 45))
				{
					throw new ZipException($"Version required to extract this entry not supported ({num3})");
				}
				if (((uint)num4 & 0x3060u) != 0)
				{
					throw new ZipException("The library does not support the zip version required to extract this entry");
				}
			}
			if (num)
			{
				if (num3 <= 63 && num3 != 10 && num3 != 11 && num3 != 20 && num3 != 21 && num3 != 25 && num3 != 27 && num3 != 45 && num3 != 46 && num3 != 50 && num3 != 51 && num3 != 52 && num3 != 61 && num3 != 62 && num3 != 63)
				{
					throw new ZipException($"Version required to extract this entry is invalid ({num3})");
				}
				if (((uint)num4 & 0xC010u) != 0)
				{
					throw new ZipException("Reserved bit flags cannot be set.");
				}
				if (((uint)num4 & (true ? 1u : 0u)) != 0 && num3 < 20)
				{
					throw new ZipException($"Version required to extract this entry is too low for encryption ({num3})");
				}
				if (((uint)num4 & 0x40u) != 0)
				{
					if ((num4 & 1) == 0)
					{
						throw new ZipException("Strong encryption flag set but encryption flag is not set");
					}
					if (num3 < 50)
					{
						throw new ZipException($"Version required to extract this entry is too low for encryption ({num3})");
					}
				}
				if (((uint)num4 & 0x20u) != 0 && num3 < 27)
				{
					throw new ZipException($"Patched data requires higher version than ({num3})");
				}
				if (num4 != entry.Flags)
				{
					throw new ZipException("Central header/local header flags mismatch");
				}
				if (entry.CompressionMethod != (CompressionMethod)num5)
				{
					throw new ZipException("Central header/local header compression method mismatch");
				}
				if (entry.Version != num3)
				{
					throw new ZipException("Extract version mismatch");
				}
				if (((uint)num4 & 0x40u) != 0 && num3 < 62)
				{
					throw new ZipException("Strong encryption flag set but version not high enough");
				}
				if (((uint)num4 & 0x2000u) != 0 && (num6 != 0 || num7 != 0))
				{
					throw new ZipException("Header masked set but date/time values non-zero");
				}
				if ((num4 & 8) == 0 && num8 != (uint)entry.Crc)
				{
					throw new ZipException("Central header/local header crc mismatch");
				}
				if (num10 == 0L && num9 == 0L && num8 != 0)
				{
					throw new ZipException("Invalid CRC for empty entry");
				}
				if (entry.Name.Length > num11)
				{
					throw new ZipException("File name length mismatch");
				}
				string text = ZipConstants.ConvertToStringExt(num4, array);
				if (text != entry.Name)
				{
					throw new ZipException("Central header and local header file name mismatch");
				}
				if (entry.IsDirectory)
				{
					if (num10 > 0L)
					{
						throw new ZipException("Directory cannot have size");
					}
					if (entry.IsCrypted)
					{
						if (num9 > 14L)
						{
							throw new ZipException("Directory compressed size invalid");
						}
					}
					else if (num9 > 2L)
					{
						throw new ZipException("Directory compressed size invalid");
					}
				}
				if (!ZipNameTransform.IsValidName(text, relaxed: true))
				{
					throw new ZipException("Name is invalid");
				}
			}
			if ((num4 & 8) == 0 || num10 > 0L || num9 > 0L)
			{
				if (num10 != entry.Size)
				{
					throw new ZipException($"Size mismatch between central header({entry.Size}) and local header({num10})");
				}
				if (num9 != entry.CompressedSize)
				{
					throw new ZipException($"Compressed size mismatch between central header({entry.CompressedSize}) and local header({num9})");
				}
			}
			int num13 = num11 + num12;
			return rlpITDpbFOegFjOmeudatAjEFLaSA + entry.Offset + 30L + num13;
		}
	}

	private void aaynbKSkBvlRCmNEuBugwQsjyrEv()
	{
		long length = bnUsFfzRpiPSoBspiesaqzitUkVf.Length;
		CfcHHULxLwXWsXVCpmxHEpDxPQAF cfcHHULxLwXWsXVCpmxHEpDxPQAF = null;
		if (uikJSBoaaTSoYahFVISzZRyAjqcg.UpdateMode == FileUpdateMode.Safe)
		{
			cfcHHULxLwXWsXVCpmxHEpDxPQAF = new CfcHHULxLwXWsXVCpmxHEpDxPQAF(uikJSBoaaTSoYahFVISzZRyAjqcg.MakeTemporaryCopy(bnUsFfzRpiPSoBspiesaqzitUkVf))
			{
				HTFIeiABiJBGNjpOAGEOJylRFbQe = true
			};
			bnUsFfzRpiPSoBspiesaqzitUkVf.Close();
			bnUsFfzRpiPSoBspiesaqzitUkVf = null;
		}
		else if (uikJSBoaaTSoYahFVISzZRyAjqcg.UpdateMode == FileUpdateMode.Direct)
		{
			bnUsFfzRpiPSoBspiesaqzitUkVf = uikJSBoaaTSoYahFVISzZRyAjqcg.OpenForDirectUpdate(bnUsFfzRpiPSoBspiesaqzitUkVf);
			cfcHHULxLwXWsXVCpmxHEpDxPQAF = new CfcHHULxLwXWsXVCpmxHEpDxPQAF(bnUsFfzRpiPSoBspiesaqzitUkVf);
		}
		else
		{
			bnUsFfzRpiPSoBspiesaqzitUkVf.Close();
			bnUsFfzRpiPSoBspiesaqzitUkVf = null;
			cfcHHULxLwXWsXVCpmxHEpDxPQAF = new CfcHHULxLwXWsXVCpmxHEpDxPQAF(Name);
		}
		using (cfcHHULxLwXWsXVCpmxHEpDxPQAF)
		{
			if (cfcHHULxLwXWsXVCpmxHEpDxPQAF.RWJEtMzwFGAycwGfgDZhGGVDMqtQ(101010256, length, 22, 65535) < 0L)
			{
				throw new ZipException("Cannot find central directory");
			}
			cfcHHULxLwXWsXVCpmxHEpDxPQAF.Position += 16L;
			byte[] eHDZEvLmZcrMxObcYgEQgnuyxEYb = wnKFaCcimSZNNzGEZTpFfqkfBeIp.eHDZEvLmZcrMxObcYgEQgnuyxEYb;
			cfcHHULxLwXWsXVCpmxHEpDxPQAF.NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(eHDZEvLmZcrMxObcYgEQgnuyxEYb.Length);
			cfcHHULxLwXWsXVCpmxHEpDxPQAF.Write(eHDZEvLmZcrMxObcYgEQgnuyxEYb, 0, eHDZEvLmZcrMxObcYgEQgnuyxEYb.Length);
			cfcHHULxLwXWsXVCpmxHEpDxPQAF.SetLength(cfcHHULxLwXWsXVCpmxHEpDxPQAF.Position);
		}
		if (uikJSBoaaTSoYahFVISzZRyAjqcg.UpdateMode == FileUpdateMode.Safe)
		{
			fitAzNKTtWgtVkffXrCAcDQDBemEb(uikJSBoaaTSoYahFVISzZRyAjqcg.ConvertTemporaryToFinal());
		}
		else
		{
			ivppqJuGdrEizTlSekNEgrsYzehG();
		}
	}

	private int pDKgpscSTlnjXHJQFcwwHRZFZApab(ZipEntry entry)
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
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc(33639248);
			NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(45);
			NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(entry.Version);
			NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(entry.Flags);
			NfkIrBJfWhAdtBUKBIQbCGiMHmIPb((byte)entry.CompressionMethod);
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)entry.DosTime);
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)entry.Crc);
			if (!entry.IsZip64Forced() && entry.CompressedSize < 4294967295L)
			{
				lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)(entry.CompressedSize & 0xFFFFFFFFL));
			}
			else
			{
				lJPoAtXdrFCOCsGHnNwvsEhvMLQc(-1);
			}
			if (!entry.IsZip64Forced() && entry.Size < 4294967295L)
			{
				lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)entry.Size);
			}
			else
			{
				lJPoAtXdrFCOCsGHnNwvsEhvMLQc(-1);
			}
			byte[] array = ZipConstants.ConvertToArray(entry.Flags, entry.Name);
			if (array.Length <= 65535)
			{
				NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(array.Length);
				ZipExtraData zipExtraData = new ZipExtraData(entry.ExtraData);
				if (entry.CentralHeaderRequiresZip64)
				{
					zipExtraData.StartNewEntry();
					if (entry.Size >= 4294967295L || svuDrGoXqHoWNqaKclrVfIkLByFbA == UseZip64.On)
					{
						zipExtraData.AddLeLong(entry.Size);
					}
					if (entry.CompressedSize >= 4294967295L || svuDrGoXqHoWNqaKclrVfIkLByFbA == UseZip64.On)
					{
						zipExtraData.AddLeLong(entry.CompressedSize);
					}
					if (entry.Offset >= 4294967295L)
					{
						zipExtraData.AddLeLong(entry.Offset);
					}
					zipExtraData.AddNewEntry(1);
				}
				else
				{
					zipExtraData.Delete(1);
				}
				byte[] entryData = zipExtraData.GetEntryData();
				NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(entryData.Length);
				NfkIrBJfWhAdtBUKBIQbCGiMHmIPb((entry.Comment != null) ? entry.Comment.Length : 0);
				NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(0);
				NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(0);
				if (entry.ExternalFileAttributes == -1)
				{
					if (!entry.IsDirectory)
					{
						LxtgiUATyLxFFbAziYtScNzmdFLBA(0u);
					}
					else
					{
						LxtgiUATyLxFFbAziYtScNzmdFLBA(16u);
					}
				}
				else
				{
					lJPoAtXdrFCOCsGHnNwvsEhvMLQc(entry.ExternalFileAttributes);
				}
				if (entry.Offset < 4294967295L)
				{
					LxtgiUATyLxFFbAziYtScNzmdFLBA((uint)entry.Offset);
				}
				else
				{
					LxtgiUATyLxFFbAziYtScNzmdFLBA(uint.MaxValue);
				}
				if (array.Length != 0)
				{
					bnUsFfzRpiPSoBspiesaqzitUkVf.Write(array, 0, array.Length);
				}
				if (entryData.Length != 0)
				{
					bnUsFfzRpiPSoBspiesaqzitUkVf.Write(entryData, 0, entryData.Length);
				}
				byte[] array2 = ((entry.Comment != null) ? Encoding.ASCII.GetBytes(entry.Comment) : new byte[0]);
				if (array2.Length != 0)
				{
					bnUsFfzRpiPSoBspiesaqzitUkVf.Write(array2, 0, array2.Length);
				}
				return 46 + array.Length + entryData.Length + array2.Length;
			}
			throw new ZipException("Entry name is too long.");
		}
		throw new ZipException("Attempt to write central directory entry with unknown crc");
	}

	private static void kajZHFBujrfZRwJQCDBjLWRBRCMT(Stream stream, long crcValue)
	{
		byte[] array = new byte[12];
		new Random().NextBytes(array);
		array[11] = (byte)(crcValue >> 24);
		stream.Write(array, 0, array.Length);
	}

	private void lJPoAtXdrFCOCsGHnNwvsEhvMLQc(int value)
	{
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(value & 0xFFFF);
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(value >> 16);
	}

	private void VFgRDKXYZqnnFobLuQUciDMkCOVk(long value)
	{
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)(value & 0xFFFFFFFFL));
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)(value >> 32));
	}

	private void NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(int value)
	{
		bnUsFfzRpiPSoBspiesaqzitUkVf.WriteByte((byte)((uint)value & 0xFFu));
		bnUsFfzRpiPSoBspiesaqzitUkVf.WriteByte((byte)((uint)(value >> 8) & 0xFFu));
	}

	private void LxtgiUATyLxFFbAziYtScNzmdFLBA(uint value)
	{
		VbcVJHaBgkLmhhXLkDgVYnnXgsXI((ushort)(value & 0xFFFFu));
		VbcVJHaBgkLmhhXLkDgVYnnXgsXI((ushort)(value >> 16));
	}

	private void HWfatnBCChKeqehTOxGjBKRyozwO(ulong value)
	{
		LxtgiUATyLxFFbAziYtScNzmdFLBA((uint)(value & 0xFFFFFFFFuL));
		LxtgiUATyLxFFbAziYtScNzmdFLBA((uint)(value >> 32));
	}

	private void VbcVJHaBgkLmhhXLkDgVYnnXgsXI(ushort value)
	{
		bnUsFfzRpiPSoBspiesaqzitUkVf.WriteByte((byte)(value & 0xFFu));
		bnUsFfzRpiPSoBspiesaqzitUkVf.WriteByte((byte)(value >> 8));
	}

	private void kAsFIojyzCvpNTsNnafBdNKGGjYRB(soPNFcrRohSBRDVpyROOVagrFcSl update)
	{
		ZipEntry npCKxxeBbMgvfKZQHTZfVMqbkYsG = update.npCKxxeBbMgvfKZQHTZfVMqbkYsG;
		npCKxxeBbMgvfKZQHTZfVMqbkYsG.Offset = bnUsFfzRpiPSoBspiesaqzitUkVf.Position;
		if (update.DpsNxfjXebzjbJLZjNeKaNbDSKib != 0)
		{
			if (npCKxxeBbMgvfKZQHTZfVMqbkYsG.CompressionMethod != CompressionMethod.Deflated)
			{
				if (npCKxxeBbMgvfKZQHTZfVMqbkYsG.CompressionMethod == CompressionMethod.Stored)
				{
					npCKxxeBbMgvfKZQHTZfVMqbkYsG.Flags &= -9;
				}
			}
			else if (npCKxxeBbMgvfKZQHTZfVMqbkYsG.Size == 0L)
			{
				npCKxxeBbMgvfKZQHTZfVMqbkYsG.CompressedSize = npCKxxeBbMgvfKZQHTZfVMqbkYsG.Size;
				npCKxxeBbMgvfKZQHTZfVMqbkYsG.Crc = 0L;
				npCKxxeBbMgvfKZQHTZfVMqbkYsG.CompressionMethod = CompressionMethod.Stored;
			}
			if (FLchgkTeUbJpdSFXUHHWWdzkWFst)
			{
				npCKxxeBbMgvfKZQHTZfVMqbkYsG.IsCrypted = true;
				if (npCKxxeBbMgvfKZQHTZfVMqbkYsG.Crc < 0L)
				{
					npCKxxeBbMgvfKZQHTZfVMqbkYsG.Flags |= 8;
				}
			}
			else
			{
				npCKxxeBbMgvfKZQHTZfVMqbkYsG.IsCrypted = false;
			}
			switch (svuDrGoXqHoWNqaKclrVfIkLByFbA)
			{
			case UseZip64.On:
				npCKxxeBbMgvfKZQHTZfVMqbkYsG.ForceZip64();
				break;
			case UseZip64.Dynamic:
				if (npCKxxeBbMgvfKZQHTZfVMqbkYsG.Size < 0L)
				{
					npCKxxeBbMgvfKZQHTZfVMqbkYsG.ForceZip64();
				}
				break;
			}
		}
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc(67324752);
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(npCKxxeBbMgvfKZQHTZfVMqbkYsG.Version);
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(npCKxxeBbMgvfKZQHTZfVMqbkYsG.Flags);
		NfkIrBJfWhAdtBUKBIQbCGiMHmIPb((byte)npCKxxeBbMgvfKZQHTZfVMqbkYsG.CompressionMethod);
		lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)npCKxxeBbMgvfKZQHTZfVMqbkYsG.DosTime);
		if (!npCKxxeBbMgvfKZQHTZfVMqbkYsG.HasCrc)
		{
			update.PmXFDcEEZNENWDwaSzNfKbaArGrK = bnUsFfzRpiPSoBspiesaqzitUkVf.Position;
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc(0);
		}
		else
		{
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)npCKxxeBbMgvfKZQHTZfVMqbkYsG.Crc);
		}
		if (npCKxxeBbMgvfKZQHTZfVMqbkYsG.LocalHeaderRequiresZip64)
		{
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc(-1);
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc(-1);
		}
		else
		{
			if (npCKxxeBbMgvfKZQHTZfVMqbkYsG.CompressedSize < 0L || npCKxxeBbMgvfKZQHTZfVMqbkYsG.Size < 0L)
			{
				update.vnLjtACtQCkQLFooYjuTVYxDgGcI = bnUsFfzRpiPSoBspiesaqzitUkVf.Position;
			}
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)npCKxxeBbMgvfKZQHTZfVMqbkYsG.CompressedSize);
			lJPoAtXdrFCOCsGHnNwvsEhvMLQc((int)npCKxxeBbMgvfKZQHTZfVMqbkYsG.Size);
		}
		byte[] array = ZipConstants.ConvertToArray(npCKxxeBbMgvfKZQHTZfVMqbkYsG.Flags, npCKxxeBbMgvfKZQHTZfVMqbkYsG.Name);
		if (array.Length <= 65535)
		{
			ZipExtraData zipExtraData = new ZipExtraData(npCKxxeBbMgvfKZQHTZfVMqbkYsG.ExtraData);
			if (npCKxxeBbMgvfKZQHTZfVMqbkYsG.LocalHeaderRequiresZip64)
			{
				zipExtraData.StartNewEntry();
				zipExtraData.AddLeLong(npCKxxeBbMgvfKZQHTZfVMqbkYsG.Size);
				zipExtraData.AddLeLong(npCKxxeBbMgvfKZQHTZfVMqbkYsG.CompressedSize);
				zipExtraData.AddNewEntry(1);
			}
			else
			{
				zipExtraData.Delete(1);
			}
			npCKxxeBbMgvfKZQHTZfVMqbkYsG.ExtraData = zipExtraData.GetEntryData();
			NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(array.Length);
			NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(npCKxxeBbMgvfKZQHTZfVMqbkYsG.ExtraData.Length);
			if (array.Length != 0)
			{
				bnUsFfzRpiPSoBspiesaqzitUkVf.Write(array, 0, array.Length);
			}
			if (npCKxxeBbMgvfKZQHTZfVMqbkYsG.LocalHeaderRequiresZip64)
			{
				if (!zipExtraData.Find(1))
				{
					throw new ZipException("Internal error cannot find extra data");
				}
				update.vnLjtACtQCkQLFooYjuTVYxDgGcI = bnUsFfzRpiPSoBspiesaqzitUkVf.Position + zipExtraData.CurrentReadIndex;
			}
			if (npCKxxeBbMgvfKZQHTZfVMqbkYsG.ExtraData.Length != 0)
			{
				bnUsFfzRpiPSoBspiesaqzitUkVf.Write(npCKxxeBbMgvfKZQHTZfVMqbkYsG.ExtraData, 0, npCKxxeBbMgvfKZQHTZfVMqbkYsG.ExtraData.Length);
			}
			return;
		}
		throw new ZipException("Entry name too long.");
	}
}
