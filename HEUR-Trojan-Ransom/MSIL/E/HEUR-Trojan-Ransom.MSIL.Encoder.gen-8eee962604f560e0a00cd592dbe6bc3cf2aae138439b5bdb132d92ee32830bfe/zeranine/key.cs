using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using zeranine.My;

namespace zeranine;

[DesignerGenerated]
public class key : Form
{
	private IContainer components;

	internal virtual Button unlck
	{
		[CompilerGenerated]
		get
		{
			return _unlck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button val = _unlck;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_unlck = value;
			val = _unlck;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("keytxt")]
	internal virtual TextBox keytxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("yazi1")]
	internal virtual Label yazi1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public key()
	{
		((Form)this).add_Load((EventHandler)Key_Load);
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
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		unlck = new Button();
		keytxt = new TextBox();
		yazi1 = new Label();
		((Control)this).SuspendLayout();
		((ButtonBase)unlck).set_FlatStyle((FlatStyle)0);
		((Control)unlck).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)unlck).set_Location(new Point(50, 74));
		((Control)unlck).set_Name("unlck");
		((Control)unlck).set_Size(new Size(118, 48));
		((Control)unlck).set_TabIndex(0);
		((ButtonBase)unlck).set_Text("Kilidi Aç");
		((ButtonBase)unlck).set_UseVisualStyleBackColor(true);
		((Control)keytxt).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)keytxt).set_Location(new Point(25, 27));
		((Control)keytxt).set_Name("keytxt");
		((Control)keytxt).set_Size(new Size(172, 21));
		((Control)keytxt).set_TabIndex(1);
		yazi1.set_AutoSize(true);
		((Control)yazi1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)yazi1).set_Location(new Point(22, 9));
		((Control)yazi1).set_Name("yazi1");
		((Control)yazi1).set_Size(new Size(56, 15));
		((Control)yazi1).set_TabIndex(2);
		yazi1.set_Text("Anahtar");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(192, 255, 192));
		((Form)this).set_ClientSize(new Size(219, 146));
		((Control)this).get_Controls().Add((Control)(object)yazi1);
		((Control)this).get_Controls().Add((Control)(object)keytxt);
		((Control)this).get_Controls().Add((Control)(object)unlck);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("key");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(keytxt.get_Text(), "URJOtBT9U8kuYp5EU%lROswqHxPu*Qe#3zd#NR9H3MQaKvq7DqvJwcyb3!g5u*BE3Q17lBzD6EXCCWgUHqRq#$GzBCAUKDu4kMG@4SuCzSlsnw8guVXdpTJ*ja%jaF!@r2zypmyX5PZLSWMND29XORO0DhS3VLBUZrau%Jzh59ha@7oWXSgHfEnan8VI35CTnFUAVzQ@C0!oJN7F!5fDe@oVEAg&WRnA&wVXMOB6bmFnL8zABQP7y8oUy*5VssGtm1qu0J!m#iB0XaKeig5GbPK*IB7nSOmRgtBTqFi1XcDp&w%YX0MMW9r6qSmZkn#o5StD8zWd&ER8M3atEiZ0CA#gCEC*!SpjhXtnD@y&EiOSqStWR!uCwDm$Xma#XxLOXh0XJvqkS!W2ULysTOp96NVeKxyy!$iP&A4i15N$Kjs4PtKMwqKihLqjVVNt%0SwsH4UQp0XatxW#zxyNmCKt9HVrtWFR@8sz5LIYy5gyvIwv#P46wGsxhcsAic52ufHuF%*OpaXq$t70s9we!I3vP#r2!Ipv9NEQabQ7qPQWrC@We1pJO0amLUfkNFvHTBqqpqzRrywl0gEma4XA!ghImzeP5fTL@iDQtlgwB*zYdxVeQ!jrqvom@iEylKulFLrRDW2xXA*@PSEXeA*D5b3G@ZwLhQLZMOs1fdB@9U#QXV6KEPUllRpdqLXm9QQHxhQB8lra*FdKHMrH2Mg158n#7oj3oX@rEv!Pe5k16TNGNF%e2QTvjxLY@VcsbXUjLuGttcc6bO#LuHQ2SFa*dghokcvS@0yi*D4!8lTZnWU4#9duFja%WvfEm0iRpsdKxuMrMX3guKtQumUL8amsz@ul6ZOHcCj#sKfIWUiQP3KMCxSAG&roftT4AaUViVdSAy&kglXN0%D%SIJhHOBFs#X*zkIv9Wh3y0ll0H@3iewJQWl0zmn3t79fb*t5dbNEXiG05&QAuH5OGnRD*Q$vINJ11GK!W&ZHzsuhpU4@5nImbt8WQQ6vfz$K9O8yvxmXqxwW2JWmVCZ#e%yggwkfADB9wKIBuFGHBt$m6l3H@TaDaBFDY1r*mgXNWw8rBu0p5r@talj#3dlpc78vFFl3vH#35qyJmLGH!THRHtCMRweJ#hkYXlM$J&3XX9XSvaqR&EwrZqotc8l*Ct9XGAUa*K7#ZS@h%SZqGvlyT!*g6!2Ku4udA9MVoQsWG@!HwgXsi4!PIJEnBnDfqwI46yh%GdbYDYSZ90SyEibzcf4Z$*tBmmFSt&j780Me2clsZNnj4NbIVR!0#qBhsalysAfCqtzM5%&9@LAqTKf9k66CeSdqZEu!Zv9ZhL!KvYlYT2&rqsXI#MnvDD6*QiV0kFigLjihR$MVthrlUUAgpM&NhmWeO33NDtNOsZgHKPZ8A!b4UUm$iok*H$8*WE@Xb8rA3D24n!5AV*Nok1T@p7EXJogXzhtfvC&BJbBq!RqpSKMiRTW4tAHD##zO%EEfhZNsaMFJZcB*pwe*C7GgUYuv43GoKVUwNkI2%2henmEq*ivGy1l776UrE0xGfZ8EqmtFOlCJyB2HtdwVgAYSJvYQZZxedb8wnAAuXq0mYcI6Em&Adc8FaP#4Xdoxw6FXbe@tdC&yil@gn!MM!XaBC3v7fe&tCCy16T$8sm5beJ%xVWQ50C58%EVHR4n8emwGVbj3%m@o!85!&7lrXB@AGz$!7wQX*661VyctMv8Nipg&I@jTS5KDTw9$fR5i5ep4bdGH$0fbCozyT7TEN6Fcv3h*yHn4zZqEAL$EWCX1ZiaE%jkh&0$88NIh5hRXMKKl&vyhCoqkINMN@DCP5G69#revDwIOtAOo7XGJTcFrJTZua4n!fb1GmkqORDeOgCzI*&oe%!$2BOyK!SuhiPirhIbvG01Q7Zkg2qvDoJ$mf8e*ugv*q%Fz@hAZ$27eaO4KDSqK5r29T5MiDDB9e28BttNUq%hvkzl0E34cYLc8dfG&$zW107Aho@ySe%@9jGX@sUeiI*K2ZA&ONpyZiP4MZElKEL&2rcx&qMNjVNs2wgRo5kFxgcz#kLDOi3e%BRKWkA6aCoE45CYsv%O2GIuPl#vfJ8B1iW0f%#E5NEv1*$7Ivs!loLZ!5#kpN0zDNluiKSW!!SobV3qp5NsyGYM&%8JbSwrVNSNvJY&D%As%%XfCm4t9ha%x8XlLJUieA2XcP4Ggpp@GFpaI2HXwDrnMvYWUMV@LzO5DAcVrXNs1HySSwdrC%UbqOLpZHU3#vqozT&hZUf8y8ve%GE&iD0OFMnxxv$KDsxFyj1*y$!QZulr1GsTDWtz4CjNfIsDy45fjqOVnFHmkKXsa5%RcLgP*7jwAN2qlx04YfhK16F7PHPtnZmjLbaNXpglg0VaMZBvS@34XuZFfiA0ryJjaSFKwmgi*$dAkeUYf2Bt5Ruyk4hOpP@QRL93tz*fVU5!Ry3BwKuYxxnr6P82F!!Sbvr9e0EO#$*KV@huaGzf3E!@&q%e1fA@2MZ4g#55fG#2yD5DHm1*bVY&3Ybw49Wx4FRJDMOGj#9wJ9d#U@6ONb1GW2BR2IBGsF7TuvA47UXgvbw#uHcBChk2mkVjk6mb@@ddBsi72bp!mUTueG%uf9dk#eGjAysBhvN2&s2b*EIa1ro!zaFea15@y!J%M*7DrOtzg0wuN#WB0DslYns9tOaPZTcFj%Y9GFRM&XU9Mszfe#CvI6g*o7rDNeaWXrkQeW4VUgOa2sWaX#K5Rp%mYzthvO*!w7k#IjBR9PBbrff$kRos#EeHu70nCv8fhVM#h!!n@!5bO4#StY6e9o7S@dijrvPmQ$35@kWrYBybIc2ZDI@mY#G!w3aEsR$gMSUsB7yJbno*y%KZKrGj@cwVYBI9KS8gFSxYqiYerTLkOHc0Sj@aLuNj$*#AyZ8roh2GHuiB@B0izMgq7qpAY7$sFO3rOxo1U2$gn5s6B1Hj#ESS1MbIj*@qlJB!1ZvEV9X7QAcb&S*6ZUYa$KzbWGRV9n#e40FkFDX#ptb0jAkzA5zztA%Q8tqoRb*cF&GGNW1W6#tki81v$zuDwDt##xlUuIMnV8Vl@emmED3youH9!#TzP4OCmlLxkGBxRGxjmo@zNI8tJ#OIQl!0xV7zTT*q2Xb&behi%&VMB@MH5#!r6DH*NjA5h7y@QL&YgBrEvfLsyoy4iz#Y0PtYpDs0eLa*H25Y$Wa4lw5z1XI*tevqDACa0IiDqz9kemL6SA9uZ9mDT@&1#Ug9xs4gz$7Wn6mUXtVOMLoTFB0dv*p7KQi5s9VuREGwClg@V!o8gSoSfW#w!0T!o9l&wQBX*a%hF1q237q#SQz1BZZ%F*@zTNhc9iFF00aGVgmnfB@3Jyi7It%6zerAHfw0sn@t!lD0ptF3MlZEe8Q#ej3oMhnviA*PSV#0HIb&vRRXOCtnnN4IY@vitnhT&QrPuyKzq*%%6Shv!FAjwAh4eZzy9UG@aqAf8bcY1@6oQ*kfu9QoN&%&IWk4*U05!D$oSbWZckr3c!NfOUd9E0ocUC6lzHzgCaWND5vslzlcoC#PiePmQ01aw2#Qek94tL1CFAcS7twmoMwrhQcu0mykIvZjBfnazQrDK!Kib6o%dnUKeLiXhNdguQ@rJ!q!fvv73Thof3T#7@g#BoFy6Z2mmkR3*18iovZQ1WQtd@Rn3ii1J8q#W1$o@JtSCNQn4KOkDyCn*tudIOSdbyt9KEVW0kWrC&rylDss#7xs%D5Cf0GOZQQM@qDZX1s1cTLaC$0e$9JdaacHIsQ9EI1uQF%4A24cn6QM04AKABsZgML!n5qEKsW31Zs%85eCegYdTyPmsG9DxBnd3EpdLZ14JvtBLDkd%quAwhhXPEUdsTeZLoc4oaZnO##&FObP45GHonpu5!wHeXkYq#Y5apX$zHU@mKSBCFIwm&K68Q*WmSizSFPKYfonHkQh@WIuive9oWLTs1%sRBrH7#jh#hL%y#pCpcdlImNZNik$@506i$%f2iJ*MAzBKIJUgJDQXtKEW1@YSnn*pnw#&jiH2F8IvMoF8ZxT2KiXU1SBPtP7u!t%toW%A5wSUCRjlwy!Y3Ffe8if0h0hYav3!SUTc!T%vZcrJIx14WI1vn0ufqF!EP@tPXq2cFy6jISO5z5rS9MC14Hn18Nuv0!g6rcuz$xY&LqN4lYouWJEc0!tpDBd1EKrplRmwj0Wkwepm@SoJ799RwEfZReW#U&@B8&S#l1k$V@oVlHWtu33EKA!hLWFFd2yZLoN59t&fxE$#xsnKRcIzDxZ*ekrxvf0@DYK%@zUB5wofE7S!i4WBT8vvxo0XbIsSMCz9IqQ0qH#PiT3G!ZP1rZiEcXhn9%8wE%@CgSs1N5TMEGmEut5L20Av@v6tic0tIgLMz18iGXNVG5A5Kd2OaW4M5gitu8rkE8E64am3UveENnP6VBJFJMsUl*psrnwgFcqg1cajZ83nRZ8RzL*tymB1oSt%T@kG8&8k%IeSa9OKrecV972GPcq!BY0IrEy%wWotzXuRgoTZ7zJKp*6VaEZ5pgJgq%a%JRv4Yr4kMK9aS03KPQ!sgd5s%sdTnnaKnwpPdnU7DuiyEymxM8zAdqYfVD*fnK6*jYv4KNGb5#pu#fOgfoHOwAG6*K3APOs2XKPoDRN8!xEJBDkpX098DRkJrY%ATfVQKw6Ty9dwBhV*5%549mlXOTYG9G%NuNovcw8NfzZXWl745lmV@BaG3&bZ7ztSDyCW29$I&rxIWwacV3KW2jtTmi!euIoofgU&JkC5pexKl1sf%*Edp&Z2FRJsgzvxcJCPCD2k1nGXuJhUyvhWEk*IQ!11BrxyRAHcYDd@F2lb0bg5jx3tS9T1K3*JLBjiypfube5VSOqL*%Qou5RMXdGrPP14e3qESDlK$u3e!hbErI2NmSXoS&tuJwFumaQx6M!$tfs9bMTpbC9HvNRuFCUurZBHPh11zmgFP&@g9XmGmETgX788r4s41GM3eLT3U!Yx430xtkVQxOhnG3sRi!i$@lNiU8CwEsuUO4l3GjOHiCGM*7wk!bt!S@4SpRdUi*Me@W9kRyk8NBv0faKvLz$C82bUA2NxG@*KYBsk*l@czunqgdMogQJRDKfAUnkxLv!tcLbEq9X9&!LmOtn5P*qYsQHO$sZtaezE23O4bh&H2jtK8!uaAoImeDaVEWi7Jd*!bgTtfS#haj%J56PD&Ytu5m9y22Zn89&Yk1I1ha#QtaM#GzyHHfATSm%xH#1M!PIBMH*EXw4%#Da$aFsbcSg@8Nf&$TtNiRXE1kR8!ussKdYPlawCkyjJiOC*baIEDQwMO%DYwTJq8Wr$Xyu#5RcsHO$miS&0MOp3PlaP&*OzP!ju%GKLonhUnEFAaZpEvrETgxolYf6&DlDOEJQChul*g4oLgaOHrjd&XyOH0*viqKRbBZ50JN%BffmLiDexzYo2hFzn#iKJ8cQ5mNKpEw7ENc1RMD7w@&r1$x3$8q%AcvbcxQ7$2XTD0KoFNib0kWpBtYaxTOqW0&b0ax2$FC#eNoAtiXqZPFYPfAr9piLNg6l3iXEYPGuI!kwFYpo$&zgVIuUaf@O5zQ&pDGkUs!KJspW4lmjA3pppyyUWDdSV0yRLmgCre#LeP6C17yX2SOCKAqzmuwRPixr3*LqFK149ELA!w2YmoZclwgk5pY6qM5$zOI@vISR0TCGxQ7y!*EaSVff1AUxu#NWhPiNO9CE5hk!UavOr9erh$MeICbVw#56fo7iHTK25AEKKNUzmfGVy4OMcEel7pQbLnVFcNH7xlVhzb3#qKIqXjgKaufDo*#PSC8%1PX9*h&NiguBjj4WH9NbgkeqhdSZqfYxc&CBvirPl2b@9e2edgIsx6YQkG1#xH%cR67Mh@a*Q&YnikqDknvj&FAFhuZPqwze%*LcGP6jGjCzHkh9YxsKUVFl62eVctq2GTqj8O%$qlDWDJ&%NZz!EpTj@9fNkKHV2iTw3&aj1X@ISrIW4hIl@xXZ9gQ9iStGEQ#3yjcPypapWL0Kzrrcb4!Et@wvpBBIDvdbwn&te2VMwHcXPfIZaqeJxyJ5vP9xo!MAHYWlt7&iioQMZ8gj!KhVR#m7eb7Y@&&44cQZS5fCs$aii%FWiY5EtzrMlxHrAIPkRuRwRQ0%eFCV3ExI5KpdB@KdTEN3xWCkPY0wnqF1799Ox%rhA*VY!LjxKndND6HqczGemB#OFXfB@$oWuf3yaMSdOcMAN0xa1Rl&yN4*EHTdFI4o*p!&cRpZhCyKx3aN9eiksR&hk4u@!O7GH6B68z7jBVYwwTjjGGda8s5pSTvh5W&@Esc0!DOIg8j&2JTztkvVK&gXBUnOEZnnX$SEqSqc1$@AJ*wiA5WtaLrGMnyHY9EQU$i6ZPib3s#oEGOc6eOIc@mMmM0c2jN10loNYzrTvuzqQDCf9WKTt$N0r5TNXfITFCX10amGv4Vqc$$JKUcf8@H$7w42ge$pMgLOojO*Jd&yJ%xvajDDcCtl#!3Dft9R8FE$TQ3afE%$5qVb*h!%B!NKV9TWPL2xEozE12cTPC6*fYPmf!E&!cpG03JT%gt#kHzpzRJfFhp*$OE6sgQwg$%B8TM7sSwIRcw*79VXr*!TvqkMylAYZ%WPKYqGFLVVtHQ!0f8Tt2eIDMOqI9Igr7rUoHwIRorglf8OarUTmpE61OM7K9&FcOdvY$msRZbFj&56NAQZnx3C3U@a4y7rRmd&ClyeFbbvn8W3rotjSHznUB2dClx1!sW6@*4BKLtMvgX#79rPFw9jVylasVc@mj#4LZATTS9gWn1Nm7FC3IVEsmKdV#qXI09lM2rh87$Vw2WH&7WUpA8Ewyk*o5&yBk7$OoBTo&D$M9pzZDGwg%hI14xvRT2caftl#02R6cFS6D0withlyJreDyDszOC$EA4gOE5*jXzdzxkxDam6LQm0WPiewi0rajn%ItIeXJbBrOnnnOPyBFswvdT84zka6IDpjnPS1hICOlIIB#zI2BQ$zzjeaij&7aEjL7d9*6&2%QIK$k7aACH$0hYsEkrS7kENh76cZ0j5Dw*jr8JYkJ6$@IrDit4wnO#UM#c6n4ji!k!dioBeB@HxnIt8P@3f5VRX2N6w%lKP8XDRpO#@syVUHfgEjDqUBEMG@dK4RmIYS1yyecSa*AVfA6QWg2N24YO4L6XlE8LGq6bopQ8HtpvaRGG%WWXx8o3@M#nhng%8xPXc4Bgy3GIncnmez1YQkvgCchCucz2mTWLbRDbup7#2Goz*QiqvRoXbiV9v*UWcm$3PCLvWyDaM1N5Wqde@JG$E*J!5DOv4k1okUk%Fv3%nOkJ4ZlF4p@@g9yQ!SzskpFBA*tbfg8gojQyWA6fzi1OR7Ik$3dV$ju7JJJ%Fj9wQVn6S9@!uU2bxZsCyJfLDMkFXSpmZaAQJd75TL15aLaKqsiSZgg5dwtdKiIASpbUtL1U!wrnqjk1laweJ&Ws3EMVS3ukD1MTJPZF0Xzcx!n3M21jUdZu@r0p8fb7Cgky6zR%jRmugT#BZriZCky8bzz0xjfuV!aqqx%uK$9cZeOiwyZQ%L5zqLwGAzhAL18nsmsBVwogLvI%LRd*TYxK%JAfaZUTW80*FaYKfx4i%xO#cz#rvipVDXRJMNa$C4sl$j0k!2!4#onH#fcJ5c&nre$qrP&!w8GBFc*29SZ3QU1wjKOgKz89&F@znJ2l$AH$iMb1gjJmMD6&mhghazq69gdAihnyZN*QN5n6IvAAQVv3h5NGCtkErK$CibS*5TW8epsQ@j8NZqPNTJ1m#HWFC37DalwgdBd68wx1l%M!u6NB#RR8jfEX%q%kRpPqV!jYmrn%UAa&44TeP6IS#x%76PaqzNJ5Q$f2WxwlDUnjeG@B&0$UH6v&$L1&R6fHZEQ8Yzqzi%PJKv@zV8T8rxxTII&L6Z3Gogsay3lGjELkQmWirBkSMGxbP%zp@f3SCJ#dc!a!vmYNMNc$UX@$Ok@IRRt2D$mdj!IHSSfyaS58QKxC@44el*d0PuuUhHxzAUdTe$Mbrd45o30g2r8hAh0LxQ066UR23e8$gE67r2vIDHlu3O1YIQZ13!$Xdoe&uCCj459xUByguShQefDr2!tmOgbOii#cXYvBFCz7ODdgzSGKTnS7lVE@RY$w3UPlGvS%5GLcOeDyXmV$a0##y%zCU@spGcE3W1aEAjONCpSgSneEc9WczUVj$pkCW$5laic%MR4zlQ1JmsSGxOmgPbDCFZIs*MZgTgGJLh1Ue5ZJ2M%L6emhrY5*fA0Vik19ZUYGmJ4Qv1bTk@i!@%v38Rx4kHdkpfl@dZShwZ*wJ%UZWlwl0*!lx7ah53$FFTAQPIPtjaeD7*Tc%7H*T0sRmAefykL@#2Ry5EKO%cbZ3YNZN&k7v%unArdoDJ#8YLIep#G!w2CQY2wwVn1!9Ng&HdYNa4kvhcBrpiJszSK3#Exg#P@YRC9kEk&le21!qPiv1FHmehBpDMDDorStbVeFcZNFL6O7zRln$boYhptJBSh1H36Vjgz4kDTb0bbH@cYUaxhmD@lub4EsRV7qA!wT0QD1RN7GnMp73vzrVTSQ#F@P8AsFdTgaoF3sUP4Y$fgxOfy44o4PigYVww2q3!C#FPSX2g6fx3Ux7EB@KXjxx00IPh5&WN4cdMS*vBCXRx0ouawSV9gfrNFnXKIUk9Sk*rtuUCGiVVG99LvoTmkWGYtZHEKl2QMrfpQDPb&T27s%gFOlw2a&x$eJ7#nQ13PFiX3s4S8ro0#hFwsCy7X9Po3jkgFuwQ!8rnWrk4qe3rr6B%djklz@FPY3#TIwNm#**4y0aaz4psf6%%InD$jkZ*@Cx@wzv@zpws7GgMJjU$muj167k3trDsIABwCgM9IW2Yim7CHZuAy#uh1%5Yo2iImEk7esjC6UWy2USTAiV3%c@NO@$FKwToNtLeb96XpscEH$OgNlYGGOLjk6SLwE0JaHLIinRAl7NmAxGsOx1*7Ni8Ib3EQuAL!2D9sG&9#x3IB*JVz8%8M2LW*M9HtmsZ&CtHUGAhz1EiTa7J1HNqxB*9qpBGGZoQFDK*NCaT8xItXCc7OZPM9bb%DUZEF@bAMWdpy85YG@rA2NkOmD1pKCqdbN4!l%nFvhhB7vho#ZGfSBdyjkzCbuyjf9nLdDmjoMNUFJQz4lVt5ktAjFraFlDaR7$*I5kzM5zfwSTa#Agy9FN#oNb*tMecJMcHnrR8a4HAtnl0uRGeeNBMTaS#3MfA0w%kplVlrhxe&NjaBKmcf97$LyWm8wewxHI%qBKi$#v6Y5oGzr2s9D30yB9ZxIm4capyFmSA9EHLmBGoKQvp#uXuNQgpbtTvq13XPYam82s$$RNX4TohV%AQM4lXGc*oTt#ugr8uPiqbb!y$cruqelAt0MkUMMg5#EkKW!qMt31mO*OTeQUwqQjhtJ#3gniDbUg&qOhKaI%KtWF2&zP50SON3DZm&WFGUXk30qcZIKvIT8w&Eb5P7MlSG@DnX#MNDZy5LLBpXywQ5f@#o2i50Yhhl!w7NxbN&iF@J0u!AP0hY$vA9I*$upVNRqTsXDC9XJSWa9UXHQ$L79SQfW7eyf!Qv0k1gCE6m1Tol98AwjXEUKPR*Dmae6jRqbAiX2Qel*7fPDEGX7qoRw5lL2@dxd1pRC7K8ZL#@S1vMJC$8gMgP#93FX&$9mpIGRXNe3g&VvV8$J8bz&eqztAWCdek!p4PcsP4UxZeAOU2ha75x$ECI*RuqBkBY$Ff1f5l@EQbg9ql9HOBFIv%L2HEB#mTmYPEiOBbeVCTOC4iQFujVJ$piI#8*1K8z6xRsMcUfm%sGCRi&*W5ID&D38$ATCcmLc@RNmYECadimLjgzUBAEOzw8UwtqCaDjshDi94tiS@h8xZRYxJ8BcI6lFS2YeW99A*@dg&zypzUUrxj#f4!2bCHKkzDQC$E5@h*y6NrzritLwL@QI*SJ#g770S2P#jwUvx1KyT&1MbK2R$W86vIDl4bvja7nUC%IU8x*TSzXB0625eP5$@rhbti1WFAYusgjeC", false) == 0)
		{
			((Control)MyProject.Forms.sifrecoz.coz).set_Enabled(true);
			if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.zeranine.dil.get_SelectedItem(), (object)"Türkçe", false))
			{
				Interaction.MsgBox((object)"Kilidi başarıyla açtın!", (MsgBoxStyle)0, (object)null);
				((Form)this).Close();
			}
			else if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.zeranine.dil.get_SelectedItem(), (object)"English", false))
			{
				Interaction.MsgBox((object)"You've successfully unlocked!", (MsgBoxStyle)0, (object)null);
				((Form)this).Close();
			}
		}
		else if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.zeranine.dil.get_SelectedItem(), (object)"Türkçe", false))
		{
			Interaction.MsgBox((object)"Girdiğin anahtar hatalı!", (MsgBoxStyle)0, (object)null);
		}
		else if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.zeranine.dil.get_SelectedItem(), (object)"English", false))
		{
			Interaction.MsgBox((object)"The key you entered is invalid!", (MsgBoxStyle)0, (object)null);
		}
	}

	private void Key_Load(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.zeranine.dil.get_SelectedItem(), (object)"Türkçe", false))
		{
			((ButtonBase)unlck).set_Text("Kilidi Aç");
			yazi1.set_Text("Anahtar");
		}
		else if (Operators.ConditionalCompareObjectEqual(MyProject.Forms.zeranine.dil.get_SelectedItem(), (object)"English", false))
		{
			((ButtonBase)unlck).set_Text("Unlock");
			yazi1.set_Text("Key");
		}
	}
}
