using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using Fatality_Menu;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using Siticone.UI.WinForms.Suite;
using cCMBEkOBGIwpDnI0MY;
using fJpF6sGRwSPY0tjIER;
using mLChtR0pUQjVeOabmX;
using zjWSh2Z73jBs4TcJ0x;

namespace Neutron;

public class Register : Form
{
	private IContainer oyRNqmxec;

	private Label s4jWHEN37;

	private SiticoneTransition tnw6FhDHa;

	private SiticoneDragControl BOTrQv7dO;

	private SiticoneControlBox GClInPKjn;

	private SiticoneRoundedTextBox vIAb93aN9;

	private SiticoneRoundedTextBox OUKufE9Fu;

	private SiticoneRoundedTextBox RoDsl6SwN;

	private SiticoneRoundedTextBox ujBaGKRFU;

	private Label wH5ARToRj;

	private SiticoneShadowForm MjAjnet9o;

	private SiticoneRoundedGradientButton BBF1kRhJV;

	private SiticoneRoundedGradientButton TmmwjZus2;

	private SiticoneControlBox pLgXayfe3;

	private static Register kJkaZDOQRTD79hRw2o;

	public Register()
	{
		O9lTNfXbd2ULkrPiLQ();
		vXdHWnMK4dt1JhAwgc();
		oyRNqmxec = null;
		((Form)this)._002Ector();
		T7klJOLIv();
	}

	private void Xy13TRnaJ(object sender, EventArgs e)
	{
	}

	private void q8tJNGdMJ(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		while (true)
		{
			bool flag = snvDE3LFc7xuQSJqWC.Register(G8WEEIteFdlpZX0WWa(OUKufE9Fu), G8WEEIteFdlpZX0WWa(RoDsl6SwN), G8WEEIteFdlpZX0WWa(ujBaGKRFU), G8WEEIteFdlpZX0WWa(vIAb93aN9));
			while (true)
			{
				int num2;
				if (flag)
				{
					num2 = 0;
					if (!xkjW7QIXrKtcNKRvBI())
					{
						goto IL_0044;
					}
					goto IL_0048;
				}
				return;
				IL_0044:
				num2 = num;
				goto IL_0048;
				IL_0048:
				while (true)
				{
					switch (num2)
					{
					case 2:
						goto end_IL_0048;
					case 3:
						goto end_IL_005f;
					case 1:
						return;
					}
					MessageBox.Show((string)z1XkbsDEIEPWEgLs1i(0), (string)z1XkbsDEIEPWEgLs1i(62), (MessageBoxButtons)0, (MessageBoxIcon)64);
					num2 = 1;
					if (xkjW7QIXrKtcNKRvBI())
					{
						continue;
					}
					goto IL_0044;
					continue;
					end_IL_0048:
					break;
				}
				continue;
				end_IL_005f:
				break;
			}
		}
	}

	private void wW1dJvgMI(object sender, EventArgs e)
	{
		int num = 3;
		Login object_ = default(Login);
		while (true)
		{
			IL_004f:
			TM6cmtGcNjGNlNs2DT(this);
			int num2 = 0;
			if (xkjW7QIXrKtcNKRvBI())
			{
				goto IL_000b;
			}
			goto IL_0038;
			IL_0038:
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				default:
					DVW7gCq1DNyMhxRB90(object_);
					num2 = 1;
					if (IcyxIf7AsWGYAUCoLJ() == null)
					{
						continue;
					}
					return;
				case 3:
					goto IL_004f;
				case 1:
					return;
				}
				break;
			}
			goto IL_000b;
			IL_000b:
			object_ = new Login();
			num2 = 0;
			if (IcyxIf7AsWGYAUCoLJ() != null)
			{
				num2 = num;
			}
			goto IL_0038;
		}
	}

	private void cBlimJcyZ(object sender, EventArgs e)
	{
		int num = 1;
		while (true)
		{
			wyWJs0Ee2qHrA0ipOU(0);
			int num2 = 0;
			if (IcyxIf7AsWGYAUCoLJ() != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				break;
			default:
				return;
			case 0:
				return;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		int num = 2;
		bool flag = default(bool);
		while (true)
		{
			int num2;
			if (!disposing)
			{
				num2 = 0;
				goto IL_000c;
			}
			int num3 = 1;
			if (!xkjW7QIXrKtcNKRvBI())
			{
				num3 = num;
			}
			goto IL_0027;
			IL_0027:
			switch (num3)
			{
			case 1:
				break;
			case 2:
				continue;
			default:
				goto IL_005f;
			case 3:
				goto IL_0063;
			case 4:
				goto end_IL_0059;
			case 5:
				return;
			}
			num2 = ((oyRNqmxec != null) ? 1 : 0);
			goto IL_000c;
			IL_0063:
			B1lSj5YFvM1poMCAcZ(oyRNqmxec);
			num = 4;
			break;
			IL_005f:
			if (!flag)
			{
				break;
			}
			goto IL_0063;
			IL_000c:
			flag = (byte)num2 != 0;
			num3 = 0;
			if (!xkjW7QIXrKtcNKRvBI())
			{
				goto IL_0027;
			}
			goto IL_005f;
			continue;
			end_IL_0059:
			break;
		}
		eHR0eQ0P9EjPXOyJjM(this, disposing);
	}

	private void T7klJOLIv()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected O, but got Unknown
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected O, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected O, but got Unknown
		//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Expected O, but got Unknown
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d82: Expected O, but got Unknown
		//IL_0ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecd: Expected O, but got Unknown
		//IL_1079: Unknown result type (might be due to invalid IL or missing references)
		//IL_113c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1146: Expected O, but got Unknown
		//IL_123c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1246: Expected O, but got Unknown
		//IL_1402: Unknown result type (might be due to invalid IL or missing references)
		//IL_1537: Unknown result type (might be due to invalid IL or missing references)
		//IL_1541: Expected O, but got Unknown
		//IL_158e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1598: Expected O, but got Unknown
		//IL_1599: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a3: Expected O, but got Unknown
		//IL_15aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b4: Expected O, but got Unknown
		//IL_1607: Unknown result type (might be due to invalid IL or missing references)
		//IL_1611: Expected O, but got Unknown
		//IL_1612: Unknown result type (might be due to invalid IL or missing references)
		//IL_161c: Expected O, but got Unknown
		//IL_1883: Unknown result type (might be due to invalid IL or missing references)
		//IL_188d: Expected O, but got Unknown
		//IL_18a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ad: Expected O, but got Unknown
		//IL_19d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dda: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de1: Expected O, but got Unknown
		int num = 165;
		ComponentResourceManager object_ = default(ComponentResourceManager);
		while (true)
		{
			oyRNqmxec = new Container();
			while (true)
			{
				Animation val = new Animation();
				int num2 = 197;
				if (!xkjW7QIXrKtcNKRvBI())
				{
					goto IL_00ee;
				}
				goto IL_1a14;
				IL_1a14:
				while (true)
				{
					switch (num2)
					{
					case 238:
						LdU63BSVZhuspQDy8N(val, 0f);
						goto case 94;
					case 94:
						val.set_MaxTime(1f);
						goto case 104;
					case 104:
						AbJjkJR2enMfKI5te5(val, 0f);
						goto case 138;
					case 138:
						g0DmJAndNrureuGiQh(val, (PointF)WgUeP1fHh06tDjP80q(object_, z1XkbsDEIEPWEgLs1i(282)));
						goto case 6;
					case 6:
						LJs5bGNrDIQ83P2iwl(val, (PointF)WgUeP1fHh06tDjP80q(object_, z1XkbsDEIEPWEgLs1i(330)));
						goto case 77;
					case 77:
						hJ2LOMc2wDbN1S4qfw(val, 0);
						goto case 37;
					case 37:
						lJqWTIxSCD5p6oaMU5(val, new Padding(50));
						num2 = 236;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 188;
					case 188:
						PvD8Fbiq4scUu72Fgd(s4jWHEN37, new Point(2, 9));
						goto case 4;
					case 4:
						VACk5W2uNijvqPIrcc(s4jWHEN37, z1XkbsDEIEPWEgLs1i(118));
						goto case 2;
					case 2:
						uWeKZAo0XlC6v8fdRl(s4jWHEN37, new Size(289, 30));
						goto case 175;
					case 175:
						lDh8MPTk0ql4jkcFsM(s4jWHEN37, 42);
						num2 = 8;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 237:
						UrFHqaBZHiZXOKklS1A(xGLd5lBAiVyNRAmbyvf(this), wH5ARToRj);
						num = 117;
						goto case 117;
					case 117:
						((Animator)tnw6FhDHa).SetDecoration((Control)(object)this, (DecorationType)0);
						num = 72;
						goto case 72;
					case 72:
						RXQL0QBe6KvLSys1iE0(this, (FormBorderStyle)0);
						goto case 14;
					case 14:
						S35jAtBLJX4edAWHBHn(this, z1XkbsDEIEPWEgLs1i(788));
						num2 = 56;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 236:
						QbWkBrQFl2GFlx10pZ(val, 1f);
						num2 = 10;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto case 7;
					case 7:
						YN90AeBGBYAKn2ALOkP(vIAb93aN9, (HorizontalAlignment)2);
						num2 = 118;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 235:
						WGmppwp1JHFhPXuY5C(val, 0f);
						goto case 129;
					case 129:
						m2UxKmC0XkbZSqUnhp(val, 1f);
						num2 = 44;
						if (!xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 52;
					case 52:
						((Animator)tnw6FhDHa).set_DefaultAnimation(val);
						num = 209;
						goto case 209;
					case 209:
						fhfkXR3iDLbo905csO(vIAb93aN9, bool_0: true);
						num2 = 0;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto default;
					default:
						cPpOvQs6NGtLjRXFM4(vIAb93aN9, Color.Red);
						goto case 173;
					case 173:
						iC9KesKUNu4hgvKB2S(vIAb93aN9, m1ayIEUchXmqCS9pXa());
						goto case 96;
					case 96:
						Q4uPbKZCHDnv9WBSIL(tnw6FhDHa, vIAb93aN9, (DecorationType)0);
						num2 = 111;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 234:
						lDh8MPTk0ql4jkcFsM(TmmwjZus2, 49);
						goto case 97;
					case 97:
						pMKvWjaKklIIXFg0HS(TmmwjZus2, XaXlykERDhtdRwMnBY.oXbWkAhpNa(788));
						num2 = 19;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 233:
						((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
						num2 = 86;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 232:
						DrUfIPutZTpwWgOJPk(ta7jYhB7joliDbN4tCm(OUKufE9Fu), scfwY8bgmEokL2whq7(94, 148, 255));
						goto case 168;
					case 168:
						vbCThoBjjaIh49JHUyb(((SiticoneTextBox)OUKufE9Fu).get_HoveredState(), OUKufE9Fu);
						goto case 163;
					case 163:
						PvD8Fbiq4scUu72Fgd(OUKufE9Fu, new Point(55, 123));
						goto case 174;
					case 174:
						dpF47E4CoDChpADcCd(OUKufE9Fu, new Padding(6));
						goto case 68;
					case 68:
						VACk5W2uNijvqPIrcc(OUKufE9Fu, XaXlykERDhtdRwMnBY.oXbWkAhpNa(526));
						num2 = 11;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 231:
						LlTQZvBBDjdc2hkxvwP(YWT8wHBFNnAu5fHAhW3(ujBaGKRFU), Color.FromArgb(138, 138, 138));
						goto case 227;
					case 227:
						vbCThoBjjaIh49JHUyb(YWT8wHBFNnAu5fHAhW3(ujBaGKRFU), ujBaGKRFU);
						goto case 65;
					case 65:
						YNWSheBW7hXaN8Qj36e(YWT8wHBFNnAu5fHAhW3(ujBaGKRFU), scfwY8bgmEokL2whq7(138, 138, 138));
						num = 223;
						goto case 223;
					case 223:
						rnSffIBrSKOgdwcogc2(ujBaGKRFU, pnjXHoemEpWbcGXqbO());
						goto case 49;
					case 49:
						((TextBoxState)ssxgEpBhqGW8lam0DTP(ujBaGKRFU)).set_BorderColor(Color.FromArgb(94, 148, 255));
						goto case 169;
					case 169:
						vbCThoBjjaIh49JHUyb(((SiticoneTextBox)ujBaGKRFU).get_FocusedState(), ujBaGKRFU);
						num2 = 33;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 230:
						UnDtR8yIA9I1b3Vswu(GClInPKjn, rNM3mOVyXNCsahnx0P());
						num2 = 31;
						if (IcyxIf7AsWGYAUCoLJ() != null)
						{
							continue;
						}
						goto case 70;
					case 70:
						PvD8Fbiq4scUu72Fgd(GClInPKjn, new Point(322, 5));
						goto case 89;
					case 89:
						dpF47E4CoDChpADcCd(GClInPKjn, new Padding(4, 5, 4, 5));
						num2 = 25;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 23;
					case 23:
						soEaE8dOuh9kT85EIt(wH5ARToRj, bool_0: true);
						num2 = 134;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 229:
						DXii6cBX1hdja3VjdwF(vIAb93aN9, '\0');
						goto case 46;
					case 46:
						ka5VCaBMpLF9UauWSLX(vIAb93aN9, "");
						num = 119;
						goto case 119;
					case 119:
						VgvVC4BtNmJZOA0gaXm(vIAb93aN9, "");
						goto case 122;
					case 122:
						Sk9q3m98us8XnpWdjc(RoBxXCBDZojkfYHRTlb(vIAb93aN9), vIAb93aN9);
						num2 = 144;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 228:
						VACk5W2uNijvqPIrcc(BBF1kRhJV, z1XkbsDEIEPWEgLs1i(808));
						num = 108;
						goto case 108;
					case 108:
						Sk9q3m98us8XnpWdjc(RgcmxQBoveW240a75vv(BBF1kRhJV), BBF1kRhJV);
						goto case 195;
					case 195:
						uWeKZAo0XlC6v8fdRl(BBF1kRhJV, new Size(382, 41));
						goto case 141;
					case 141:
						lDh8MPTk0ql4jkcFsM(BBF1kRhJV, 50);
						num2 = 24;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 226:
						((TextBox)RoDsl6SwN).set_ForeColor(YVjV3vBOwBTTOUKEnE6());
						num2 = 18;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto case 7;
					case 225:
						lDh8MPTk0ql4jkcFsM(OUKufE9Fu, 47);
						goto case 45;
					case 45:
						YN90AeBGBYAKn2ALOkP(OUKufE9Fu, (HorizontalAlignment)2);
						num2 = 191;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 224:
						eaPMZlzvER9TQGJmUv(YWT8wHBFNnAu5fHAhW3(ujBaGKRFU), scfwY8bgmEokL2whq7(226, 226, 226));
						goto case 231;
					case 222:
						ly29Y3Af0QfOhuCngi(GClInPKjn, (ControlBoxType)0);
						goto case 126;
					case 126:
						Q4uPbKZCHDnv9WBSIL(tnw6FhDHa, GClInPKjn, (DecorationType)0);
						goto case 110;
					case 110:
						FpR8KRLnlh8rAMYoaX(GClInPKjn, pnjXHoemEpWbcGXqbO());
						goto case 204;
					case 204:
						OwRcbpgyXs5HDUN4mv(BdTT6c5trj2dspOMJI(GClInPKjn), GClInPKjn);
						goto case 230;
					case 221:
						((SiticoneTextBox)RoDsl6SwN).set_PlaceholderText("");
						num2 = 91;
						if (!xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 214;
					case 214:
						((TextBox)RoDsl6SwN).set_SelectedText("");
						goto case 60;
					case 60:
						Sk9q3m98us8XnpWdjc(RoBxXCBDZojkfYHRTlb(RoDsl6SwN), RoDsl6SwN);
						num2 = 88;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 220:
						Sk9q3m98us8XnpWdjc(xvRaAPJ9DNi32QwUIU(GClInPKjn), GClInPKjn);
						num2 = 178;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto case 137;
					case 137:
						ny56OdBlZ6R4qfq9Pt5(this, new Size(464, 495));
						num2 = 81;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 219:
						((Control)OUKufE9Fu).set_Size(new Size(354, 46));
						goto case 225;
					case 218:
						pLgXayfe3 = new SiticoneControlBox();
						goto case 133;
					case 133:
						TmmwjZus2 = new SiticoneRoundedGradientButton();
						goto case 51;
					case 51:
						BBF1kRhJV = new SiticoneRoundedGradientButton();
						num2 = 43;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto case 41;
					case 41:
						rnSffIBrSKOgdwcogc2(vIAb93aN9, Color.Black);
						goto case 215;
					case 215:
						((TextBoxState)ssxgEpBhqGW8lam0DTP(vIAb93aN9)).set_BorderColor(scfwY8bgmEokL2whq7(94, 148, 255));
						num2 = 184;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 217:
						YNWSheBW7hXaN8Qj36e(((SiticoneTextBox)RoDsl6SwN).get_DisabledState(), scfwY8bgmEokL2whq7(138, 138, 138));
						goto case 67;
					case 67:
						((SiticoneTextBox)RoDsl6SwN).set_FillColor(pnjXHoemEpWbcGXqbO());
						num = 131;
						goto case 131;
					case 131:
						DrUfIPutZTpwWgOJPk(ssxgEpBhqGW8lam0DTP(RoDsl6SwN), Color.FromArgb(94, 148, 255));
						num2 = 27;
						if (!xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 50;
					case 50:
						((TextBoxState)ssxgEpBhqGW8lam0DTP(RoDsl6SwN)).set_Parent((TextBox)(object)RoDsl6SwN);
						num = 226;
						goto case 226;
					case 216:
						YN90AeBGBYAKn2ALOkP(ujBaGKRFU, (HorizontalAlignment)2);
						num2 = 23;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto case 19;
					case 19:
						FtpxL5B0kBywphApv7w(TmmwjZus2, new EventHandler(q8tJNGdMJ));
						goto case 85;
					case 85:
						UZlNXiBPWaVNQ5y8mVY(kohKkbBHiRJpANBBcDE(BBF1kRhJV), BBF1kRhJV);
						num2 = 23;
						if (IcyxIf7AsWGYAUCoLJ() != null)
						{
							continue;
						}
						goto case 27;
					case 27:
						HOlOy1BTTnkGBUO8gQI(dBkRpaBdU5jQsBioGBP(BBF1kRhJV), BBF1kRhJV);
						goto case 9;
					case 9:
						((Animator)tnw6FhDHa).SetDecoration((Control)(object)BBF1kRhJV, (DecorationType)0);
						num = 91;
						goto case 91;
					case 91:
						h6KalYBwpWMbVgX5pN2(BBF1kRhJV, dRI1HTBaSnKRH2IhOhL());
						goto case 74;
					case 74:
						Ak8wmRBi0fIrW4jgmaJ(BBF1kRhJV, Color.Empty);
						goto case 155;
					case 155:
						X3t1xOwsHj1jWWtVni(BBF1kRhJV, (object)new Font((string)z1XkbsDEIEPWEgLs1i(704), 9f));
						goto case 16;
					case 16:
						ma4jsKBqqEteGFeGLoe(BBF1kRhJV, rNM3mOVyXNCsahnx0P());
						num2 = 80;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 40;
					case 40:
						DYQhlRBgqjMyqMij9ho(this, new EventHandler(Xy13TRnaJ));
						num2 = 128;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 213:
						((Control)TmmwjZus2).set_Name((string)z1XkbsDEIEPWEgLs1i(724));
						num2 = 150;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 30;
					case 30:
						UZlNXiBPWaVNQ5y8mVY(kohKkbBHiRJpANBBcDE(TmmwjZus2), TmmwjZus2);
						goto case 211;
					case 211:
						((ButtonImages)dBkRpaBdU5jQsBioGBP(TmmwjZus2)).set_Parent((CustomButtonBase)(object)TmmwjZus2);
						goto case 206;
					case 206:
						Q4uPbKZCHDnv9WBSIL(tnw6FhDHa, TmmwjZus2, (DecorationType)0);
						goto case 58;
					case 58:
						h6KalYBwpWMbVgX5pN2(TmmwjZus2, Color.DarkRed);
						num2 = 185;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 212:
						LlTQZvBBDjdc2hkxvwP(((SiticoneTextBox)RoDsl6SwN).get_DisabledState(), Color.FromArgb(138, 138, 138));
						goto case 113;
					case 113:
						vbCThoBjjaIh49JHUyb(YWT8wHBFNnAu5fHAhW3(RoDsl6SwN), RoDsl6SwN);
						num2 = 217;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 210:
						((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
						goto case 233;
					case 208:
						PJ91HtBITJlxhvEDjmr(vIAb93aN9, YVjV3vBOwBTTOUKEnE6());
						num = 83;
						goto case 83;
					case 83:
						DrUfIPutZTpwWgOJPk(ta7jYhB7joliDbN4tCm(vIAb93aN9), scfwY8bgmEokL2whq7(94, 148, 255));
						num2 = 87;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 207:
						V85u50mtmPk2drYal6(val, bool_0: true);
						num2 = 71;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto case 21;
					case 21:
						((SiticoneTextBox)OUKufE9Fu).set_PlaceholderText("");
						goto case 190;
					case 190:
						VgvVC4BtNmJZOA0gaXm(OUKufE9Fu, "");
						num2 = 45;
						if (IcyxIf7AsWGYAUCoLJ() != null)
						{
							continue;
						}
						goto case 84;
					case 84:
						((SiticoneTextBox)OUKufE9Fu).get_ShadowDecoration().set_Parent((Control)(object)OUKufE9Fu);
						num2 = 219;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 205:
						uWeKZAo0XlC6v8fdRl(pLgXayfe3, new Size(68, 45));
						goto case 132;
					case 132:
						lDh8MPTk0ql4jkcFsM(pLgXayfe3, 38);
						num2 = 64;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 203:
						VACk5W2uNijvqPIrcc(RoDsl6SwN, z1XkbsDEIEPWEgLs1i(566));
						num = 15;
						goto case 15;
					case 15:
						DXii6cBX1hdja3VjdwF(RoDsl6SwN, '\0');
						num2 = 221;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto case 63;
					case 63:
						lDh8MPTk0ql4jkcFsM(RoDsl6SwN, 46);
						goto case 55;
					case 55:
						YN90AeBGBYAKn2ALOkP(RoDsl6SwN, (HorizontalAlignment)2);
						num2 = 28;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 202:
						dpF47E4CoDChpADcCd(wH5ARToRj, new Padding(4, 0, 4, 0));
						goto case 156;
					case 156:
						VACk5W2uNijvqPIrcc(wH5ARToRj, z1XkbsDEIEPWEgLs1i(646));
						num2 = 108;
						if (!xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 152;
					case 152:
						uWeKZAo0XlC6v8fdRl(wH5ARToRj, new Size(0, 28));
						goto case 29;
					case 29:
						lDh8MPTk0ql4jkcFsM(wH5ARToRj, 40);
						num2 = 26;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 201:
						LlTQZvBBDjdc2hkxvwP(YWT8wHBFNnAu5fHAhW3(vIAb93aN9), scfwY8bgmEokL2whq7(138, 138, 138));
						goto case 196;
					case 196:
						((SiticoneTextBox)vIAb93aN9).get_DisabledState().set_Parent((TextBox)(object)vIAb93aN9);
						num = 114;
						goto case 114;
					case 114:
						YNWSheBW7hXaN8Qj36e(((SiticoneTextBox)vIAb93aN9).get_DisabledState(), scfwY8bgmEokL2whq7(138, 138, 138));
						num2 = 41;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 200:
						FtpxL5B0kBywphApv7w(BBF1kRhJV, new EventHandler(wW1dJvgMI));
						num2 = 210;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 38;
					case 38:
						eaPMZlzvER9TQGJmUv(((SiticoneTextBox)vIAb93aN9).get_DisabledState(), scfwY8bgmEokL2whq7(226, 226, 226));
						goto case 201;
					case 199:
						t8xMLpBEZtUU2C0ejAH(BdTT6c5trj2dspOMJI(pLgXayfe3), scfwY8bgmEokL2whq7(232, 17, 35));
						goto case 92;
					case 92:
						NOKkoYBYMuemg9NXRY2(pLgXayfe3.get_HoveredState(), rNM3mOVyXNCsahnx0P());
						num = 115;
						goto case 115;
					case 115:
						OwRcbpgyXs5HDUN4mv(BdTT6c5trj2dspOMJI(pLgXayfe3), pLgXayfe3);
						goto case 142;
					case 142:
						UnDtR8yIA9I1b3Vswu(pLgXayfe3, rNM3mOVyXNCsahnx0P());
						goto case 148;
					case 148:
						PvD8Fbiq4scUu72Fgd(pLgXayfe3, new Point(391, 5));
						goto case 160;
					case 160:
						dpF47E4CoDChpADcCd(pLgXayfe3, new Padding(4, 5, 4, 5));
						goto case 75;
					case 75:
						VACk5W2uNijvqPIrcc(pLgXayfe3, XaXlykERDhtdRwMnBY.oXbWkAhpNa(662));
						goto case 166;
					case 166:
						Sk9q3m98us8XnpWdjc(xvRaAPJ9DNi32QwUIU(pLgXayfe3), pLgXayfe3);
						goto case 205;
					case 198:
						vbCThoBjjaIh49JHUyb(ta7jYhB7joliDbN4tCm(ujBaGKRFU), ujBaGKRFU);
						goto case 36;
					case 36:
						((Control)ujBaGKRFU).set_Location(new Point(55, 236));
						num2 = 13;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 9;
					case 197:
						object_ = new ComponentResourceManager(Type.GetTypeFromHandle(EOdePNHNLKbT1LEVXI(33554434)));
						goto case 171;
					case 171:
						s4jWHEN37 = new Label();
						num2 = 21;
						if (!xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 105;
					case 105:
						BOTrQv7dO = new SiticoneDragControl(oyRNqmxec);
						num2 = 59;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 194:
						PvD8Fbiq4scUu72Fgd(RoDsl6SwN, new Point(55, 180));
						num2 = 147;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 193:
						((TextBox)ujBaGKRFU).set_SelectedText("");
						num2 = 47;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 28;
					case 28:
						fhfkXR3iDLbo905csO(ujBaGKRFU, bool_0: true);
						goto case 12;
					case 12:
						cPpOvQs6NGtLjRXFM4(ujBaGKRFU, YVjV3vBOwBTTOUKEnE6());
						goto case 44;
					case 44:
						((Control)ujBaGKRFU).set_Cursor((Cursor)m1ayIEUchXmqCS9pXa());
						num2 = 112;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 192:
						((Control)ujBaGKRFU).set_TabIndex(45);
						goto case 216;
					case 191:
						fhfkXR3iDLbo905csO(RoDsl6SwN, bool_0: true);
						num2 = 69;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 187:
						lDh8MPTk0ql4jkcFsM(vIAb93aN9, 48);
						goto case 7;
					case 186:
						pLgXayfe3.set_FillColor(pnjXHoemEpWbcGXqbO());
						num2 = 199;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 185:
						Ak8wmRBi0fIrW4jgmaJ(TmmwjZus2, Color.Empty);
						num2 = 1;
						if (IcyxIf7AsWGYAUCoLJ() != null)
						{
							continue;
						}
						goto case 1;
					case 1:
						X3t1xOwsHj1jWWtVni(TmmwjZus2, (object)new Font((string)z1XkbsDEIEPWEgLs1i(704), 9f));
						goto case 107;
					case 107:
						ma4jsKBqqEteGFeGLoe(TmmwjZus2, rNM3mOVyXNCsahnx0P());
						goto case 20;
					case 20:
						UZlNXiBPWaVNQ5y8mVY(kkMofKB2tGpi6fmXhfi(TmmwjZus2), TmmwjZus2);
						goto case 57;
					case 57:
						PvD8Fbiq4scUu72Fgd(TmmwjZus2, new Point(44, 358));
						num = 213;
						goto case 213;
					case 184:
						vbCThoBjjaIh49JHUyb(ssxgEpBhqGW8lam0DTP(vIAb93aN9), vIAb93aN9);
						num = 208;
						goto case 208;
					case 183:
						((Control)vIAb93aN9).set_Location(new Point(55, 294));
						num2 = 179;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 182:
						((TextBoxState)YWT8wHBFNnAu5fHAhW3(OUKufE9Fu)).set_Parent((TextBox)(object)OUKufE9Fu);
						goto case 35;
					case 35:
						YNWSheBW7hXaN8Qj36e(YWT8wHBFNnAu5fHAhW3(OUKufE9Fu), scfwY8bgmEokL2whq7(138, 138, 138));
						goto case 143;
					case 143:
						rnSffIBrSKOgdwcogc2(OUKufE9Fu, Color.Black);
						num2 = 146;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 181:
						DrUfIPutZTpwWgOJPk(((SiticoneTextBox)vIAb93aN9).get_DisabledState(), scfwY8bgmEokL2whq7(208, 208, 208));
						num2 = 38;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 180:
						UrFHqaBZHiZXOKklS1A(((Control)this).get_Controls(), s4jWHEN37);
						num2 = 42;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto case 42;
					case 42:
						UrFHqaBZHiZXOKklS1A(xGLd5lBAiVyNRAmbyvf(this), pLgXayfe3);
						num = 149;
						goto case 149;
					case 149:
						UrFHqaBZHiZXOKklS1A(xGLd5lBAiVyNRAmbyvf(this), GClInPKjn);
						goto case 48;
					case 48:
						UrFHqaBZHiZXOKklS1A(((Control)this).get_Controls(), vIAb93aN9);
						num2 = 170;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 179:
						dpF47E4CoDChpADcCd(vIAb93aN9, new Padding(6));
						goto case 17;
					case 17:
						VACk5W2uNijvqPIrcc(vIAb93aN9, z1XkbsDEIEPWEgLs1i(488));
						goto case 229;
					case 178:
						uWeKZAo0XlC6v8fdRl(GClInPKjn, new Size(68, 45));
						goto case 99;
					case 99:
						lDh8MPTk0ql4jkcFsM(GClInPKjn, 39);
						num2 = 8;
						if (!xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 73;
					case 73:
						FyfJUS65Y3jC1IULBA(tnw6FhDHa, (AnimationType)1);
						goto case 5;
					case 5:
						vgmRKa1uf7vYUow6Ai(tnw6FhDHa, null);
						goto case 207;
					case 177:
						PovBAfkt5qDoiNfhle(ujBaGKRFU, XaXlykERDhtdRwMnBY.oXbWkAhpNa(586));
						num = 3;
						goto case 3;
					case 3:
						DrUfIPutZTpwWgOJPk(YWT8wHBFNnAu5fHAhW3(ujBaGKRFU), scfwY8bgmEokL2whq7(208, 208, 208));
						num = 224;
						goto case 224;
					case 176:
						RoDsl6SwN = new SiticoneRoundedTextBox();
						num2 = 127;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 48;
					case 172:
						((TextBoxState)ta7jYhB7joliDbN4tCm(RoDsl6SwN)).set_Parent((TextBox)(object)RoDsl6SwN);
						goto case 194;
					case 170:
						((ControlCollection)xGLd5lBAiVyNRAmbyvf(this)).Add((Control)(object)OUKufE9Fu);
						num2 = 147;
						if (IcyxIf7AsWGYAUCoLJ() != null)
						{
							continue;
						}
						goto case 151;
					case 151:
						((ControlCollection)xGLd5lBAiVyNRAmbyvf(this)).Add((Control)(object)RoDsl6SwN);
						goto case 93;
					case 93:
						((ControlCollection)xGLd5lBAiVyNRAmbyvf(this)).Add((Control)(object)ujBaGKRFU);
						num2 = 237;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 167:
						eaPMZlzvER9TQGJmUv(YWT8wHBFNnAu5fHAhW3(OUKufE9Fu), scfwY8bgmEokL2whq7(226, 226, 226));
						goto case 153;
					case 153:
						LlTQZvBBDjdc2hkxvwP(YWT8wHBFNnAu5fHAhW3(OUKufE9Fu), scfwY8bgmEokL2whq7(138, 138, 138));
						num = 182;
						goto case 182;
					case 162:
						X3t1xOwsHj1jWWtVni(s4jWHEN37, (object)new Font((string)z1XkbsDEIEPWEgLs1i(80), 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
						goto case 100;
					case 100:
						((Control)s4jWHEN37).set_ForeColor(SystemColors.ButtonFace);
						goto case 188;
					case 161:
						val.set_ScaleCoeff((PointF)WgUeP1fHh06tDjP80q(object_, z1XkbsDEIEPWEgLs1i(378)));
						num2 = 140;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 10;
					case 10:
						val.set_RotateLimit(0f);
						num2 = 161;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 159:
						DrUfIPutZTpwWgOJPk(YWT8wHBFNnAu5fHAhW3(OUKufE9Fu), Color.FromArgb(208, 208, 208));
						goto case 167;
					case 158:
						Q4uPbKZCHDnv9WBSIL(tnw6FhDHa, OUKufE9Fu, (DecorationType)0);
						num2 = 109;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 157:
						PvD8Fbiq4scUu72Fgd(wH5ARToRj, new Point(-9, 187));
						goto case 202;
					case 154:
						eaPMZlzvER9TQGJmUv(YWT8wHBFNnAu5fHAhW3(RoDsl6SwN), scfwY8bgmEokL2whq7(226, 226, 226));
						num2 = 212;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto case 69;
					case 69:
						cPpOvQs6NGtLjRXFM4(RoDsl6SwN, YVjV3vBOwBTTOUKEnE6());
						goto case 90;
					case 90:
						iC9KesKUNu4hgvKB2S(RoDsl6SwN, Cursors.get_IBeam());
						goto case 95;
					case 95:
						((Animator)tnw6FhDHa).SetDecoration((Control)(object)RoDsl6SwN, (DecorationType)0);
						goto case 54;
					case 54:
						PovBAfkt5qDoiNfhle(RoDsl6SwN, z1XkbsDEIEPWEgLs1i(546));
						goto case 31;
					case 31:
						DrUfIPutZTpwWgOJPk(YWT8wHBFNnAu5fHAhW3(RoDsl6SwN), Color.FromArgb(208, 208, 208));
						num2 = 154;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 150:
						Sk9q3m98us8XnpWdjc(RgcmxQBoveW240a75vv(TmmwjZus2), TmmwjZus2);
						goto case 106;
					case 106:
						((Control)TmmwjZus2).set_Size(new Size(382, 41));
						goto case 234;
					case 147:
						dpF47E4CoDChpADcCd(RoDsl6SwN, new Padding(6));
						goto case 203;
					case 146:
						DrUfIPutZTpwWgOJPk(ssxgEpBhqGW8lam0DTP(OUKufE9Fu), scfwY8bgmEokL2whq7(94, 148, 255));
						num2 = 124;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 145:
						DXii6cBX1hdja3VjdwF(ujBaGKRFU, '\0');
						goto case 103;
					case 103:
						ka5VCaBMpLF9UauWSLX(ujBaGKRFU, "");
						num2 = 193;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 144:
						uWeKZAo0XlC6v8fdRl(vIAb93aN9, new Size(354, 46));
						num = 187;
						goto case 187;
					case 140:
						H2l0Rp8Ao085XLU9q6(val, (PointF)WgUeP1fHh06tDjP80q(object_, XaXlykERDhtdRwMnBY.oXbWkAhpNa(424)));
						goto case 235;
					case 139:
						Q4uPbKZCHDnv9WBSIL(tnw6FhDHa, pLgXayfe3, (DecorationType)0);
						goto case 186;
					case 136:
						ma4jsKBqqEteGFeGLoe(wH5ARToRj, Color.White);
						goto case 157;
					case 135:
						cPpOvQs6NGtLjRXFM4(OUKufE9Fu, YVjV3vBOwBTTOUKEnE6());
						goto case 98;
					case 98:
						iC9KesKUNu4hgvKB2S(OUKufE9Fu, m1ayIEUchXmqCS9pXa());
						goto case 158;
					case 134:
						((Animator)tnw6FhDHa).SetDecoration((Control)(object)wH5ARToRj, (DecorationType)0);
						goto case 34;
					case 34:
						((Control)wH5ARToRj).set_Font(new Font((string)z1XkbsDEIEPWEgLs1i(614), 10f));
						num2 = 136;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto IL_00ee;
					case 130:
						((Control)ujBaGKRFU).set_Size(new Size(354, 46));
						goto case 192;
					case 128:
						((Control)this).ResumeLayout(false);
						num2 = 70;
						if (!xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 102;
					case 127:
						ujBaGKRFU = new SiticoneRoundedTextBox();
						goto case 66;
					case 66:
						wH5ARToRj = new Label();
						goto case 39;
					case 39:
						MjAjnet9o = new SiticoneShadowForm(oyRNqmxec);
						num2 = 94;
						if (!xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 218;
					case 125:
						xY4xXCl2ZEiUbi6Pxj(GClInPKjn, 10);
						goto case 222;
					case 124:
						vbCThoBjjaIh49JHUyb(ssxgEpBhqGW8lam0DTP(OUKufE9Fu), OUKufE9Fu);
						num2 = 78;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 123:
						vIAb93aN9 = new SiticoneRoundedTextBox();
						goto case 101;
					case 101:
						OUKufE9Fu = new SiticoneRoundedTextBox();
						num2 = 176;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 121:
						PvD8Fbiq4scUu72Fgd(BBF1kRhJV, new Point(44, 415));
						goto case 228;
					case 120:
						((Control)this).set_Text((string)z1XkbsDEIEPWEgLs1i(788));
						num2 = 40;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 118:
						fhfkXR3iDLbo905csO(OUKufE9Fu, bool_0: true);
						num2 = 135;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 116:
						soEaE8dOuh9kT85EIt(s4jWHEN37, bool_0: true);
						goto case 32;
					case 32:
						((Animator)tnw6FhDHa).SetDecoration((Control)(object)s4jWHEN37, (DecorationType)0);
						goto case 162;
					case 112:
						Q4uPbKZCHDnv9WBSIL(tnw6FhDHa, ujBaGKRFU, (DecorationType)0);
						goto case 177;
					case 111:
						PovBAfkt5qDoiNfhle(vIAb93aN9, z1XkbsDEIEPWEgLs1i(470));
						num2 = 72;
						if (IcyxIf7AsWGYAUCoLJ() != null)
						{
							continue;
						}
						goto case 181;
					case 109:
						PovBAfkt5qDoiNfhle(OUKufE9Fu, XaXlykERDhtdRwMnBY.oXbWkAhpNa(506));
						goto case 159;
					case 88:
						uWeKZAo0XlC6v8fdRl(RoDsl6SwN, new Size(354, 46));
						num2 = 63;
						if (xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 56;
					case 56:
						eJP1w6B52lOZh15SMUh(this, (FormStartPosition)1);
						goto case 120;
					case 87:
						vbCThoBjjaIh49JHUyb(ta7jYhB7joliDbN4tCm(vIAb93aN9), vIAb93aN9);
						goto case 183;
					case 86:
						xlxeiQBvRJHpwkwlSV5(this, pnjXHoemEpWbcGXqbO());
						goto case 137;
					case 82:
						pLgXayfe3.set_BorderRadius(10);
						goto case 139;
					case 81:
						UrFHqaBZHiZXOKklS1A(xGLd5lBAiVyNRAmbyvf(this), BBF1kRhJV);
						num2 = 76;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 80:
						UZlNXiBPWaVNQ5y8mVY(kkMofKB2tGpi6fmXhfi(BBF1kRhJV), BBF1kRhJV);
						goto case 121;
					case 79:
						BOTrQv7dO.set_TargetControl((Control)(object)this);
						goto case 61;
					case 61:
						QcjpRovYpZrpc290Pk(GClInPKjn, (AnchorStyles)9);
						num2 = 87;
						if (!xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 125;
					case 78:
						PJ91HtBITJlxhvEDjmr(OUKufE9Fu, YVjV3vBOwBTTOUKEnE6());
						num2 = 232;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 76:
						UrFHqaBZHiZXOKklS1A(xGLd5lBAiVyNRAmbyvf(this), TmmwjZus2);
						goto case 180;
					case 71:
						val.set_BlindCoeff((PointF)WgUeP1fHh06tDjP80q(object_, z1XkbsDEIEPWEgLs1i(236)));
						num2 = 238;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto case 229;
					case 64:
						FtpxL5B0kBywphApv7w(pLgXayfe3, new EventHandler(cBlimJcyZ));
						num = 30;
						goto case 30;
					case 62:
						tnw6FhDHa = new SiticoneTransition();
						num2 = 123;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 59:
						GClInPKjn = new SiticoneControlBox();
						goto case 62;
					case 53:
						DrUfIPutZTpwWgOJPk(ta7jYhB7joliDbN4tCm(ujBaGKRFU), scfwY8bgmEokL2whq7(94, 148, 255));
						num2 = 198;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 47:
						Sk9q3m98us8XnpWdjc(RoBxXCBDZojkfYHRTlb(ujBaGKRFU), ujBaGKRFU);
						goto case 130;
					case 43:
						OBPWiHPQeMxisvcZMc(this);
						num = 116;
						goto case 116;
					case 33:
						PJ91HtBITJlxhvEDjmr(ujBaGKRFU, YVjV3vBOwBTTOUKEnE6());
						goto case 53;
					case 26:
						QcjpRovYpZrpc290Pk(pLgXayfe3, (AnchorStyles)9);
						num2 = 78;
						if (!xkjW7QIXrKtcNKRvBI())
						{
							continue;
						}
						goto case 82;
					case 25:
						VACk5W2uNijvqPIrcc(GClInPKjn, XaXlykERDhtdRwMnBY.oXbWkAhpNa(194));
						goto case 220;
					case 24:
						((Control)BBF1kRhJV).set_Text(XaXlykERDhtdRwMnBY.oXbWkAhpNa(872));
						goto case 200;
					case 22:
						((Control)ujBaGKRFU).set_Name((string)z1XkbsDEIEPWEgLs1i(600));
						num2 = 145;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 18:
						DrUfIPutZTpwWgOJPk(ta7jYhB7joliDbN4tCm(RoDsl6SwN), scfwY8bgmEokL2whq7(94, 148, 255));
						goto case 172;
					case 13:
						dpF47E4CoDChpADcCd(ujBaGKRFU, new Padding(6));
						goto case 22;
					case 11:
						DXii6cBX1hdja3VjdwF(OUKufE9Fu, '\0');
						goto case 21;
					case 8:
						pMKvWjaKklIIXFg0HS(s4jWHEN37, z1XkbsDEIEPWEgLs1i(134));
						num2 = 79;
						if (IcyxIf7AsWGYAUCoLJ() == null)
						{
							continue;
						}
						goto IL_00ee;
					case 164:
						break;
					case 165:
						goto end_IL_1dda;
					case 102:
						av5sYfBVn02PqtX6nZL(this);
						return;
					case 189:
						return;
					}
					break;
				}
				continue;
				IL_00ee:
				num2 = num;
				goto IL_1a14;
				continue;
				end_IL_1dda:
				break;
			}
		}
	}

	internal static void O9lTNfXbd2ULkrPiLQ()
	{
		XaXlykERDhtdRwMnBY.jXRWMU6APG();
	}

	internal static void vXdHWnMK4dt1JhAwgc()
	{
		zB3PVH9hASM2TtLqpf.unC5KZCzPQ9Xt();
	}

	internal static bool xkjW7QIXrKtcNKRvBI()
	{
		return kJkaZDOQRTD79hRw2o == null;
	}

	internal static Register IcyxIf7AsWGYAUCoLJ()
	{
		return kJkaZDOQRTD79hRw2o;
	}

	internal static object G8WEEIteFdlpZX0WWa(object object_0)
	{
		return ((TextBox)object_0).get_Text();
	}

	internal static object z1XkbsDEIEPWEgLs1i(int int_0)
	{
		return XaXlykERDhtdRwMnBY.oXbWkAhpNa(int_0);
	}

	internal static void TM6cmtGcNjGNlNs2DT(object object_0)
	{
		((Control)object_0).Hide();
	}

	internal static void DVW7gCq1DNyMhxRB90(object object_0)
	{
		((Control)object_0).Show();
	}

	internal static void wyWJs0Ee2qHrA0ipOU(int int_0)
	{
		Environment.Exit(int_0);
	}

	internal static void B1lSj5YFvM1poMCAcZ(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static void eHR0eQ0P9EjPXOyJjM(object object_0, bool bool_0)
	{
		((Form)object_0).Dispose(bool_0);
	}

	internal static RuntimeTypeHandle EOdePNHNLKbT1LEVXI(int token)
	{
		return aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(token);
	}

	internal static void OBPWiHPQeMxisvcZMc(object object_0)
	{
		((Control)object_0).SuspendLayout();
	}

	internal static void soEaE8dOuh9kT85EIt(object object_0, bool bool_0)
	{
		((Control)object_0).set_AutoSize(bool_0);
	}

	internal static void X3t1xOwsHj1jWWtVni(object object_0, object object_1)
	{
		((Control)object_0).set_Font((Font)object_1);
	}

	internal static void PvD8Fbiq4scUu72Fgd(object object_0, Point point_0)
	{
		((Control)object_0).set_Location(point_0);
	}

	internal static void VACk5W2uNijvqPIrcc(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static void uWeKZAo0XlC6v8fdRl(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void lDh8MPTk0ql4jkcFsM(object object_0, int int_0)
	{
		((Control)object_0).set_TabIndex(int_0);
	}

	internal static void pMKvWjaKklIIXFg0HS(object object_0, object object_1)
	{
		((Control)object_0).set_Text((string)object_1);
	}

	internal static void QcjpRovYpZrpc290Pk(object object_0, AnchorStyles anchorStyles_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_Anchor(anchorStyles_0);
	}

	internal static void xY4xXCl2ZEiUbi6Pxj(object object_0, int int_0)
	{
		((SiticoneControlBox)object_0).set_BorderRadius(int_0);
	}

	internal static void ly29Y3Af0QfOhuCngi(object object_0, ControlBoxType controlBoxType_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SiticoneControlBox)object_0).set_ControlBoxType(controlBoxType_0);
	}

	internal static void Q4uPbKZCHDnv9WBSIL(object object_0, object object_1, DecorationType decorationType_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((Animator)object_0).SetDecoration((Control)object_1, decorationType_0);
	}

	internal static Color pnjXHoemEpWbcGXqbO()
	{
		return Color.Black;
	}

	internal static void FpR8KRLnlh8rAMYoaX(object object_0, Color color_0)
	{
		((SiticoneControlBox)object_0).set_FillColor(color_0);
	}

	internal static object BdTT6c5trj2dspOMJI(object object_0)
	{
		return ((SiticoneControlBox)object_0).get_HoveredState();
	}

	internal static void OwRcbpgyXs5HDUN4mv(object object_0, object object_1)
	{
		((ControlBoxState)object_0).set_Parent((ControlBox)object_1);
	}

	internal static Color rNM3mOVyXNCsahnx0P()
	{
		return Color.White;
	}

	internal static void UnDtR8yIA9I1b3Vswu(object object_0, Color color_0)
	{
		((SiticoneControlBox)object_0).set_IconColor(color_0);
	}

	internal static void dpF47E4CoDChpADcCd(object object_0, Padding padding_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_Margin(padding_0);
	}

	internal static object xvRaAPJ9DNi32QwUIU(object object_0)
	{
		return ((SiticoneControlBox)object_0).get_ShadowDecoration();
	}

	internal static void Sk9q3m98us8XnpWdjc(object object_0, object object_1)
	{
		((ShadowDecoration)object_0).set_Parent((Control)object_1);
	}

	internal static void FyfJUS65Y3jC1IULBA(object object_0, AnimationType animationType_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Animator)object_0).set_AnimationType(animationType_0);
	}

	internal static void vgmRKa1uf7vYUow6Ai(object object_0, object object_1)
	{
		((Animator)object_0).set_Cursor((Cursor)object_1);
	}

	internal static void V85u50mtmPk2drYal6(object object_0, bool bool_0)
	{
		((Animation)object_0).set_AnimateOnlyDifferences(bool_0);
	}

	internal static object WgUeP1fHh06tDjP80q(object object_0, object object_1)
	{
		return ((ResourceManager)object_0).GetObject((string)object_1);
	}

	internal static void LdU63BSVZhuspQDy8N(object object_0, float float_0)
	{
		((Animation)object_0).set_LeafCoeff(float_0);
	}

	internal static void AbJjkJR2enMfKI5te5(object object_0, float float_0)
	{
		((Animation)object_0).set_MinTime(float_0);
	}

	internal static void g0DmJAndNrureuGiQh(object object_0, PointF pointF_0)
	{
		((Animation)object_0).set_MosaicCoeff(pointF_0);
	}

	internal static void LJs5bGNrDIQ83P2iwl(object object_0, PointF pointF_0)
	{
		((Animation)object_0).set_MosaicShift(pointF_0);
	}

	internal static void hJ2LOMc2wDbN1S4qfw(object object_0, int int_0)
	{
		((Animation)object_0).set_MosaicSize(int_0);
	}

	internal static void lJqWTIxSCD5p6oaMU5(object object_0, Padding padding_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Animation)object_0).set_Padding(padding_0);
	}

	internal static void QbWkBrQFl2GFlx10pZ(object object_0, float float_0)
	{
		((Animation)object_0).set_RotateCoeff(float_0);
	}

	internal static void H2l0Rp8Ao085XLU9q6(object object_0, PointF pointF_0)
	{
		((Animation)object_0).set_SlideCoeff(pointF_0);
	}

	internal static void WGmppwp1JHFhPXuY5C(object object_0, float float_0)
	{
		((Animation)object_0).set_TimeCoeff(float_0);
	}

	internal static void m2UxKmC0XkbZSqUnhp(object object_0, float float_0)
	{
		((Animation)object_0).set_TransparencyCoeff(float_0);
	}

	internal static void fhfkXR3iDLbo905csO(object object_0, bool bool_0)
	{
		((Control)object_0).set_AllowDrop(bool_0);
	}

	internal static void cPpOvQs6NGtLjRXFM4(object object_0, Color color_0)
	{
		((SiticoneTextBox)object_0).set_BorderColor(color_0);
	}

	internal static object m1ayIEUchXmqCS9pXa()
	{
		return Cursors.get_IBeam();
	}

	internal static void iC9KesKUNu4hgvKB2S(object object_0, object object_1)
	{
		((Control)object_0).set_Cursor((Cursor)object_1);
	}

	internal static void PovBAfkt5qDoiNfhle(object object_0, object object_1)
	{
		((TextBox)object_0).set_DefaultText((string)object_1);
	}

	internal static Color scfwY8bgmEokL2whq7(int int_0, int int_1, int int_2)
	{
		return Color.FromArgb(int_0, int_1, int_2);
	}

	internal static void DrUfIPutZTpwWgOJPk(object object_0, Color color_0)
	{
		((TextBoxState)object_0).set_BorderColor(color_0);
	}

	internal static void eaPMZlzvER9TQGJmUv(object object_0, Color color_0)
	{
		((TextBoxState)object_0).set_FillColor(color_0);
	}

	internal static object YWT8wHBFNnAu5fHAhW3(object object_0)
	{
		return ((SiticoneTextBox)object_0).get_DisabledState();
	}

	internal static void LlTQZvBBDjdc2hkxvwP(object object_0, Color color_0)
	{
		((TextBoxState)object_0).set_ForeColor(color_0);
	}

	internal static void YNWSheBW7hXaN8Qj36e(object object_0, Color color_0)
	{
		((TextBoxState)object_0).set_PlaceholderForeColor(color_0);
	}

	internal static void rnSffIBrSKOgdwcogc2(object object_0, Color color_0)
	{
		((SiticoneTextBox)object_0).set_FillColor(color_0);
	}

	internal static object ssxgEpBhqGW8lam0DTP(object object_0)
	{
		return ((SiticoneTextBox)object_0).get_FocusedState();
	}

	internal static void vbCThoBjjaIh49JHUyb(object object_0, object object_1)
	{
		((TextBoxState)object_0).set_Parent((TextBox)object_1);
	}

	internal static Color YVjV3vBOwBTTOUKEnE6()
	{
		return Color.Red;
	}

	internal static void PJ91HtBITJlxhvEDjmr(object object_0, Color color_0)
	{
		((TextBox)object_0).set_ForeColor(color_0);
	}

	internal static object ta7jYhB7joliDbN4tCm(object object_0)
	{
		return ((SiticoneTextBox)object_0).get_HoveredState();
	}

	internal static void DXii6cBX1hdja3VjdwF(object object_0, char char_0)
	{
		((TextBox)object_0).set_PasswordChar(char_0);
	}

	internal static void ka5VCaBMpLF9UauWSLX(object object_0, object object_1)
	{
		((SiticoneTextBox)object_0).set_PlaceholderText((string)object_1);
	}

	internal static void VgvVC4BtNmJZOA0gaXm(object object_0, object object_1)
	{
		((TextBox)object_0).set_SelectedText((string)object_1);
	}

	internal static object RoBxXCBDZojkfYHRTlb(object object_0)
	{
		return ((SiticoneTextBox)object_0).get_ShadowDecoration();
	}

	internal static void YN90AeBGBYAKn2ALOkP(object object_0, HorizontalAlignment horizontalAlignment_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TextBox)object_0).set_TextAlign(horizontalAlignment_0);
	}

	internal static void ma4jsKBqqEteGFeGLoe(object object_0, Color color_0)
	{
		((Control)object_0).set_ForeColor(color_0);
	}

	internal static void t8xMLpBEZtUU2C0ejAH(object object_0, Color color_0)
	{
		((ControlBoxState)object_0).set_FillColor(color_0);
	}

	internal static void NOKkoYBYMuemg9NXRY2(object object_0, Color color_0)
	{
		((ControlBoxState)object_0).set_IconColor(color_0);
	}

	internal static void FtpxL5B0kBywphApv7w(object object_0, object object_1)
	{
		((Control)object_0).add_Click((EventHandler)object_1);
	}

	internal static object kohKkbBHiRJpANBBcDE(object object_0)
	{
		return ((SiticoneGradientButton)object_0).get_CheckedState();
	}

	internal static void UZlNXiBPWaVNQ5y8mVY(object object_0, object object_1)
	{
		((ButtonState)object_0).set_Parent((CustomButtonBase)object_1);
	}

	internal static object dBkRpaBdU5jQsBioGBP(object object_0)
	{
		return ((SiticoneGradientButton)object_0).get_CustomImages();
	}

	internal static void h6KalYBwpWMbVgX5pN2(object object_0, Color color_0)
	{
		((SiticoneGradientButton)object_0).set_FillColor(color_0);
	}

	internal static void Ak8wmRBi0fIrW4jgmaJ(object object_0, Color color_0)
	{
		((SiticoneGradientButton)object_0).set_FillColor2(color_0);
	}

	internal static object kkMofKB2tGpi6fmXhfi(object object_0)
	{
		return ((SiticoneGradientButton)object_0).get_HoveredState();
	}

	internal static object RgcmxQBoveW240a75vv(object object_0)
	{
		return ((SiticoneGradientButton)object_0).get_ShadowDecoration();
	}

	internal static void HOlOy1BTTnkGBUO8gQI(object object_0, object object_1)
	{
		((ButtonImages)object_0).set_Parent((CustomButtonBase)object_1);
	}

	internal static Color dRI1HTBaSnKRH2IhOhL()
	{
		return Color.DarkRed;
	}

	internal static void xlxeiQBvRJHpwkwlSV5(object object_0, Color color_0)
	{
		((Control)object_0).set_BackColor(color_0);
	}

	internal static void ny56OdBlZ6R4qfq9Pt5(object object_0, Size size_0)
	{
		((Form)object_0).set_ClientSize(size_0);
	}

	internal static object xGLd5lBAiVyNRAmbyvf(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static void UrFHqaBZHiZXOKklS1A(object object_0, object object_1)
	{
		((ControlCollection)object_0).Add((Control)object_1);
	}

	internal static void RXQL0QBe6KvLSys1iE0(object object_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Form)object_0).set_FormBorderStyle(formBorderStyle_0);
	}

	internal static void S35jAtBLJX4edAWHBHn(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static void eJP1w6B52lOZh15SMUh(object object_0, FormStartPosition formStartPosition_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Form)object_0).set_StartPosition(formStartPosition_0);
	}

	internal static void DYQhlRBgqjMyqMij9ho(object object_0, object object_1)
	{
		((Form)object_0).add_Load((EventHandler)object_1);
	}

	internal static void av5sYfBVn02PqtX6nZL(object object_0)
	{
		((Control)object_0).PerformLayout();
	}
}
