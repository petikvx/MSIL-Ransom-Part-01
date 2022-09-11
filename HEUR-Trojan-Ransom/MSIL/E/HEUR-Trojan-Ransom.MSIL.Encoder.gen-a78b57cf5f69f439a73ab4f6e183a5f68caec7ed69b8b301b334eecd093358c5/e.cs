using System;
using System.Runtime.InteropServices;

internal class e
{
	public delegate int j(int int_0, IntPtr intptr_0, IntPtr intptr_1);

	public enum f
	{
		a = 1,
		b = 2,
		c = 3,
		d = 4,
		e = 5,
		f = 6,
		g = 8,
		h = 9,
		i = 12,
		j = 13,
		k = 16,
		l = 17,
		m = 18,
		n = 19,
		o = 20,
		p = 21,
		q = 21,
		r = 23,
		s = 24,
		t = 25,
		u = 25,
		v = 27,
		w = 28,
		x = 29,
		y = 30,
		z = 31,
		aa = 32,
		bb = 33,
		cb = 34,
		db = 35,
		eb = 36,
		fb = 37,
		gb = 38,
		hb = 39,
		ib = 40,
		jb = 41,
		kb = 42,
		lb = 43,
		mb = 44,
		nb = 45,
		ob = 46,
		pb = 47,
		qb = 48,
		rb = 49,
		sb = 50,
		tb = 51,
		ub = 52,
		vb = 53,
		wb = 54,
		xb = 55,
		yb = 56,
		zb = 57,
		ab = 65,
		cc = 66,
		dc = 67,
		ec = 68,
		fc = 69,
		gc = 70,
		hc = 71,
		ic = 72,
		jc = 73,
		kc = 74,
		lc = 75,
		mc = 76,
		dd = 77,
		ed = 78,
		fd = 79,
		gd = 80,
		hd = 81,
		id = 82,
		jd = 83,
		kd = 84,
		ld = 85,
		md = 86,
		nd = 87,
		od = 88,
		pd = 89,
		qd = 90,
		rd = 91,
		sd = 92,
		td = 93,
		ud = 95,
		vd = 96,
		wd = 97,
		xd = 98,
		yd = 99,
		zd = 100,
		ad = 101,
		bd = 102,
		cd = 103,
		ee = 104,
		fe = 105,
		ge = 106,
		he = 107,
		ie = 108,
		je = 109,
		ke = 110,
		le = 111,
		me = 112,
		ne = 113,
		oe = 114,
		pe = 115,
		qe = 116,
		re = 117,
		se = 118,
		te = 119,
		ue = 120,
		ve = 121,
		we = 122,
		xe = 123,
		ye = 124,
		ze = 125,
		ae = 126,
		be = 127,
		ce = 128,
		ff = 129,
		gf = 130,
		hf = 131,
		@if = 132,
		jf = 133,
		kf = 134,
		lf = 135,
		mf = 144,
		nf = 145,
		of = 160,
		pf = 161,
		qf = 162,
		rf = 163,
		sf = 164,
		tf = 165,
		uf = 166,
		vf = 167,
		wf = 168,
		xf = 169,
		yf = 170,
		zf = 171,
		af = 172,
		bf = 173,
		cf = 174,
		df = 175,
		ef = 176,
		gg = 177,
		hg = 178,
		ig = 179,
		jg = 180,
		kg = 181,
		lg = 182,
		mg = 183,
		ng = 186,
		og = 187,
		pg = 188,
		qg = 189,
		rg = 190,
		sg = 191,
		tg = 192,
		ug = 219,
		vg = 220,
		wg = 221,
		xg = 222,
		yg = 223,
		zg = 226,
		ag = 229,
		bg = 231,
		cg = 246,
		hh = 247,
		ih = 248,
		jh = 249,
		kh = 250,
		lh = 251,
		mh = 252,
		nh = 253,
		oh = 254
	}

	public struct g
	{
		public int a;

		public int b;

		public int c;

		public int d;
	}

	[StructLayout(LayoutKind.Sequential)]
	public class h
	{
		public int a;

		public int b;
	}

	[StructLayout(LayoutKind.Sequential)]
	public class i
	{
		public h a;

		public int b;

		public int c;

		public int d;
	}

	public const int a = 256;

	public const int b = 257;

	public const int c = 7;

	public const int d = 13;

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ClipCursor(ref g g_0);

	[DllImport("user32.dll", EntryPoint = "ClipCursor")]
	public static extern bool ClipCursor_1(IntPtr intptr_0);

	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr intptr_0);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr SetActiveWindow(IntPtr intptr_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetWindowRect(HandleRef handleRef_0, out g g_0);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern int SetWindowsHookEx(int int_0, j j_0, IntPtr intptr_0, int int_1);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern bool UnhookWindowsHookEx(int int_0);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern int CallNextHookEx(int int_0, int int_1, IntPtr intptr_0, IntPtr intptr_1);
}
