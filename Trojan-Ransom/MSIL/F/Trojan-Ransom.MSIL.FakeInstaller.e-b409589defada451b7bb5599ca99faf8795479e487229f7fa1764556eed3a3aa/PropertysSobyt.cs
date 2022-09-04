using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public struct PropertysSobyt
{
	public peremens.ErrString err;

	public TreeNode bylBreakpoint;

	public object MyObj;

	public SortedList Paramy;

	public SortedList ParamyUp;

	public string eType;

	public object e;

	public object sender;

	public PropertysSobyt(object sender, object e, Type type, string sobyt = "")
	{
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		this = default(PropertysSobyt);
		int try0007_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		Keys val = default(Keys);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				SortedList paramy;
				int index;
				Type typeFromHandle;
				object[] array;
				object[] array2;
				object[] array4;
				object obj2;
				SortedList paramy2;
				int index2;
				Type typeFromHandle2;
				object[] array7;
				object[] array8;
				object obj3;
				SortedList paramy3;
				int index3;
				Type typeFromHandle3;
				object[] array9;
				object[] array10;
				object obj4;
				SortedList paramy4;
				int index4;
				Type typeFromHandle4;
				object[] array6;
				object[] array11;
				object obj;
				object[] array3;
				object[] array12;
				bool[] array5;
				object obj5;
				switch (try0007_dispatch)
				{
				default:
					num = 1;
					Paramy = new SortedList();
					goto IL_0015;
				case 16197:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0007;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0015;
						case 3:
							goto IL_001b;
						case 4:
						case 5:
							goto IL_0030;
						case 6:
							goto IL_003f;
						case 7:
							goto IL_004e;
						case 8:
							goto IL_0061;
						case 9:
						case 10:
							goto IL_0074;
						case 11:
							goto IL_007b;
						case 12:
						case 13:
							goto IL_008a;
						case 14:
							goto IL_012a;
						case 15:
							goto IL_0160;
						case 16:
							goto IL_016a;
						case 17:
						case 18:
							goto IL_01b3;
						case 19:
							goto IL_01e9;
						case 20:
							goto IL_01f3;
						case 21:
						case 22:
							goto IL_0236;
						case 23:
							goto IL_026c;
						case 24:
							goto IL_0276;
						case 25:
						case 26:
							goto IL_02b9;
						case 27:
							goto IL_02ef;
						case 28:
							goto IL_02f9;
						case 29:
						case 30:
							goto IL_033c;
						case 31:
							goto IL_0372;
						case 32:
							goto IL_037c;
						case 33:
						case 34:
							goto IL_03bf;
						case 35:
							goto IL_03c6;
						case 36:
						case 37:
						case 38:
							goto IL_03d5;
						case 39:
							goto IL_0427;
						case 40:
							goto IL_045d;
						case 41:
							goto IL_0467;
						case 42:
						case 43:
							goto IL_04aa;
						case 44:
							goto IL_04e0;
						case 45:
							goto IL_04ed;
						case 46:
						case 47:
							goto IL_0599;
						case 48:
							goto IL_05a0;
						case 49:
						case 50:
						case 51:
							goto IL_05af;
						case 52:
							goto IL_061b;
						case 53:
							goto IL_0651;
						case 54:
							goto IL_065b;
						case 55:
						case 56:
							goto IL_06ae;
						case 57:
							goto IL_06e4;
						case 58:
							goto IL_06f1;
						case 59:
						case 60:
							goto IL_079d;
						case 61:
							goto IL_07d3;
						case 62:
							goto IL_07e0;
						case 63:
						case 64:
							goto IL_088c;
						case 65:
							goto IL_08c2;
						case 66:
							goto IL_08cf;
						case 67:
						case 68:
							goto IL_097b;
						case 69:
							goto IL_0982;
						case 70:
						case 71:
						case 72:
							goto IL_0991;
						case 73:
							goto IL_09e3;
						case 74:
							goto IL_09eb;
						case 75:
							goto IL_0a21;
						case 76:
							goto IL_0a2b;
						case 77:
						case 78:
							goto IL_0a6e;
						case 79:
							goto IL_0aa4;
						case 80:
							goto IL_0aae;
						case 81:
						case 82:
							goto IL_0af1;
						case 83:
							goto IL_0b27;
						case 84:
							goto IL_0b31;
						case 85:
						case 86:
							goto IL_0b74;
						case 87:
							goto IL_0baa;
						case 88:
							goto IL_0bb4;
						case 89:
						case 90:
							goto IL_0bf7;
						case 91:
							goto IL_0bfe;
						case 92:
						case 93:
						case 94:
							goto IL_0c0d;
						case 95:
							goto IL_0c5f;
						case 96:
							goto IL_0c67;
						case 97:
							goto IL_0c9d;
						case 98:
							goto IL_0ca7;
						case 99:
						case 100:
							goto IL_0cea;
						case 101:
							goto IL_0d20;
						case 102:
							goto IL_0d2a;
						case 103:
						case 104:
							goto IL_0d6d;
						case 105:
							goto IL_0da3;
						case 106:
							goto IL_0dad;
						case 107:
						case 108:
							goto IL_0df0;
						case 109:
							goto IL_0e26;
						case 110:
							goto IL_0e30;
						case 111:
						case 112:
							goto IL_0e73;
						case 113:
							goto IL_0ea9;
						case 114:
							goto IL_0eb3;
						case 115:
						case 116:
							goto IL_0eea;
						case 117:
							goto IL_0ef1;
						case 118:
						case 119:
						case 120:
							goto IL_0f00;
						case 121:
							goto IL_0f52;
						case 122:
							goto IL_0f5a;
						case 123:
							goto IL_0f90;
						case 124:
							goto IL_0f9a;
						case 125:
						case 126:
							goto IL_0ff1;
						case 127:
							goto IL_0ff8;
						case 128:
						case 129:
						case 130:
							goto IL_1007;
						case 131:
							goto IL_105c;
						case 132:
							goto IL_1064;
						case 133:
							goto IL_109d;
						case 134:
							goto IL_10aa;
						case 135:
						case 136:
							goto IL_1104;
						case 137:
							goto IL_110e;
						case 138:
						case 139:
						case 140:
							goto IL_1120;
						case 141:
							goto IL_1175;
						case 142:
							goto IL_117d;
						case 143:
							goto IL_11b6;
						case 144:
							goto IL_11c3;
						case 145:
						case 146:
							goto IL_121d;
						case 147:
							goto IL_1227;
						case 148:
						case 149:
						case 150:
							goto IL_1239;
						case 151:
							goto IL_128e;
						case 152:
							goto IL_1296;
						case 153:
							goto IL_12cf;
						case 154:
							goto IL_12dc;
						case 155:
						case 156:
							goto IL_1316;
						case 157:
							goto IL_1320;
						case 158:
						case 159:
						case 160:
							goto IL_1332;
						case 161:
							goto IL_13a1;
						case 162:
							goto IL_13a9;
						case 163:
							goto IL_13e2;
						case 164:
							goto IL_13ef;
						case 165:
						case 166:
							goto IL_145d;
						case 167:
							goto IL_1496;
						case 168:
							goto IL_14a3;
						case 169:
						case 170:
							goto IL_14dd;
						case 171:
							goto IL_14e7;
						case 172:
						case 173:
						case 174:
							goto IL_14f9;
						case 175:
							goto IL_154e;
						case 176:
							goto IL_1556;
						case 177:
							goto IL_158f;
						case 178:
							goto IL_159c;
						case 179:
						case 180:
							goto IL_160a;
						case 181:
							goto IL_1614;
						case 182:
						case 183:
						case 184:
							goto IL_1626;
						case 185:
							goto IL_1666;
						case 186:
							goto IL_166e;
						case 187:
							goto IL_16a7;
						case 188:
							goto IL_16b4;
						case 189:
						case 190:
						case 191:
							goto IL_1722;
						case 192:
							goto IL_1777;
						case 193:
							goto IL_177f;
						case 194:
							goto IL_17b8;
						case 195:
							goto IL_17c5;
						case 196:
						case 197:
							goto IL_17ff;
						case 198:
							goto IL_1809;
						case 199:
						case 200:
						case 201:
							goto IL_181b;
						case 202:
							goto IL_1870;
						case 203:
							goto IL_1878;
						case 204:
							goto IL_18b1;
						case 205:
							goto IL_18be;
						case 206:
						case 207:
							goto IL_1904;
						case 208:
							goto IL_193d;
						case 209:
							goto IL_194a;
						case 210:
						case 211:
							goto IL_1990;
						case 212:
							goto IL_19c9;
						case 213:
							goto IL_19d6;
						case 214:
						case 215:
							goto IL_1a10;
						case 216:
							goto IL_1a1a;
						case 217:
						case 218:
						case 219:
							goto IL_1a2c;
						case 220:
							goto IL_1ae9;
						case 221:
							goto IL_1af1;
						case 222:
							goto IL_1b2a;
						case 223:
							goto IL_1b37;
						case 224:
						case 225:
							goto IL_1b7d;
						case 226:
							goto IL_1bb6;
						case 227:
							goto IL_1bc3;
						case 228:
						case 229:
							goto IL_1c09;
						case 230:
							goto IL_1c13;
						case 231:
						case 232:
						case 233:
							goto IL_1c25;
						case 234:
							goto IL_1cae;
						case 235:
							goto IL_1cb6;
						case 236:
							goto IL_1cef;
						case 237:
							goto IL_1cfc;
						case 238:
						case 239:
							goto IL_1d56;
						case 240:
							goto IL_1d60;
						case 241:
						case 242:
						case 243:
							goto IL_1d72;
						case 244:
							goto IL_1de1;
						case 245:
							goto IL_1de9;
						case 246:
							goto IL_1e22;
						case 247:
							goto IL_1e2f;
						case 248:
						case 249:
							goto IL_1e7b;
						case 250:
							goto IL_1eb4;
						case 251:
							goto IL_1ec1;
						case 252:
						case 253:
							goto IL_1f07;
						case 254:
							goto IL_1f40;
						case 255:
							goto IL_1f4d;
						case 256:
						case 257:
							goto IL_1f93;
						case 258:
							goto IL_1fcc;
						case 259:
							goto IL_1fd9;
						case 260:
						case 261:
							goto IL_201f;
						case 262:
							goto IL_2058;
						case 263:
							goto IL_2065;
						case 264:
						case 265:
							goto IL_20ab;
						case 266:
							goto IL_20e4;
						case 267:
							goto IL_20f1;
						case 268:
						case 269:
							goto IL_2137;
						case 270:
							goto IL_2170;
						case 271:
							goto IL_217d;
						case 272:
						case 273:
							goto IL_21c3;
						case 274:
							goto IL_21cd;
						case 275:
						case 276:
						case 277:
							goto IL_21df;
						case 278:
							goto IL_2234;
						case 279:
							goto IL_223c;
						case 280:
							goto IL_2275;
						case 281:
							goto IL_2282;
						case 282:
						case 283:
							goto IL_22dc;
						case 284:
							goto IL_22e6;
						case 285:
						case 286:
						case 287:
							goto IL_22f8;
						case 288:
							goto IL_234d;
						case 289:
							goto IL_2355;
						case 290:
							goto IL_238e;
						case 291:
							goto IL_239b;
						case 292:
						case 293:
							goto IL_23e1;
						case 294:
							goto IL_241a;
						case 295:
							goto IL_2427;
						case 296:
						case 297:
							goto IL_246d;
						case 298:
							goto IL_2477;
						case 299:
						case 300:
						case 301:
							goto IL_2489;
						case 302:
							goto IL_24de;
						case 303:
							goto IL_24e6;
						case 304:
							goto IL_251f;
						case 305:
							goto IL_252c;
						case 306:
						case 307:
							goto IL_2572;
						case 308:
							goto IL_25ab;
						case 309:
							goto IL_25b8;
						case 310:
						case 311:
							goto IL_25fe;
						case 312:
							goto IL_2608;
						case 313:
						case 314:
						case 315:
							goto IL_261a;
						case 316:
							goto IL_266f;
						case 317:
							goto IL_2677;
						case 318:
							goto IL_26b0;
						case 319:
							goto IL_26bd;
						case 320:
						case 321:
							goto IL_2703;
						case 322:
							goto IL_270d;
						case 323:
						case 324:
						case 325:
							goto IL_271f;
						case 326:
							goto IL_278e;
						case 327:
							goto IL_2796;
						case 328:
							goto IL_27cf;
						case 329:
							goto IL_27dc;
						case 330:
						case 331:
							goto IL_2816;
						case 332:
							goto IL_2820;
						case 333:
						case 334:
						case 335:
							goto IL_2832;
						case 336:
							goto IL_2887;
						case 337:
							goto IL_288f;
						case 338:
							goto IL_28c8;
						case 339:
							goto IL_28d5;
						case 340:
						case 341:
							goto IL_290f;
						case 342:
							goto IL_2919;
						case 343:
						case 344:
						case 345:
							goto IL_292b;
						case 346:
							goto IL_298a;
						case 347:
							goto IL_2992;
						case 348:
							goto IL_29cb;
						case 349:
							goto IL_29d8;
						case 350:
						case 351:
							goto IL_2a12;
						case 352:
							goto IL_2a4b;
						case 353:
							goto IL_2a58;
						case 354:
						case 355:
							goto IL_2a9e;
						case 356:
						case 357:
							goto IL_2ab0;
						case 358:
							goto IL_2b0f;
						case 359:
							goto IL_2b17;
						case 360:
							goto IL_2b50;
						case 361:
							goto IL_2b5d;
						case 362:
						case 363:
							goto IL_2ba3;
						case 364:
							goto IL_2bdc;
						case 365:
							goto IL_2be9;
						case 366:
						case 367:
							goto IL_2c2f;
						case 368:
						case 369:
							goto IL_2c41;
						case 370:
							goto IL_2ca0;
						case 371:
							goto IL_2ca8;
						case 372:
							goto IL_2ce1;
						case 373:
							goto IL_2cf1;
						case 374:
						case 375:
							goto IL_2d8a;
						case 376:
						case 377:
							goto IL_2d9c;
						case 378:
							goto IL_2e2f;
						case 379:
							goto IL_2e37;
						case 380:
							goto IL_2e70;
						case 381:
							goto IL_2e7d;
						case 382:
						case 383:
							goto IL_2ec3;
						case 384:
							goto IL_2efc;
						case 385:
							goto IL_2f09;
						case 386:
						case 387:
							goto IL_2f4f;
						case 388:
							goto IL_2f88;
						case 389:
							goto IL_2f95;
						case 390:
						case 391:
							goto IL_2fdb;
						case 392:
							goto IL_3014;
						case 393:
							goto IL_3021;
						case 394:
						case 395:
							goto IL_3067;
						case 396:
						case 397:
							goto IL_3079;
						case 398:
							goto IL_30d8;
						case 399:
							goto IL_30e0;
						case 400:
							goto IL_3119;
						case 401:
							goto IL_3126;
						case 402:
						case 403:
							goto IL_316c;
						case 404:
							goto IL_31a5;
						case 405:
							goto IL_31b2;
						case 406:
						case 407:
							goto IL_31f8;
						case 408:
							goto IL_3231;
						case 409:
							goto IL_323e;
						case 410:
						case 411:
							goto IL_3284;
						case 412:
							goto IL_32bd;
						case 413:
							goto IL_32ca;
						case 414:
						case 415:
							goto IL_3310;
						case 416:
						case 417:
							goto IL_3322;
						case 418:
							goto IL_3381;
						case 419:
							goto IL_3389;
						case 420:
							goto IL_33c2;
						case 421:
							goto IL_33cf;
						case 422:
						case 423:
							goto IL_342e;
						case 424:
							goto IL_3467;
						case 425:
							goto IL_3474;
						case 426:
						case 427:
							goto IL_34d3;
						case 428:
						case 429:
							goto IL_34e5;
						case 430:
							goto IL_3505;
						case 431:
							goto IL_3512;
						case 434:
							goto IL_3529;
						case 435:
							goto IL_3549;
						case 436:
							goto IL_3556;
						case 439:
							goto IL_356d;
						case 440:
							goto IL_358d;
						case 441:
							goto IL_359a;
						case 444:
							goto IL_35b1;
						case 445:
							goto IL_35d1;
						case 446:
							goto IL_35de;
						case 449:
							goto IL_35f5;
						case 450:
							goto IL_3615;
						case 451:
							goto IL_3622;
						case 454:
							goto IL_3639;
						case 455:
							goto IL_3659;
						case 456:
							goto IL_3666;
						case 459:
							goto IL_367a;
						case 460:
							goto IL_369a;
						case 461:
							goto IL_36a4;
						case 464:
							goto IL_36b8;
						case 465:
							goto IL_36d8;
						case 432:
						case 433:
						case 437:
						case 438:
						case 442:
						case 443:
						case 447:
						case 448:
						case 452:
						case 453:
						case 457:
						case 458:
						case 462:
						case 463:
						case 466:
						case 467:
							goto IL_36ea;
						case 468:
							goto IL_36fc;
						case 469:
							goto IL_3716;
						case 470:
							goto IL_3775;
						case 471:
							goto IL_3785;
						case 472:
							goto IL_3798;
						case 473:
							goto end_IL_0007_2;
						default:
							goto end_IL_0007;
						case 474:
							goto end_IL_0007_3;
						}
						goto default;
					}
					IL_36b8:
					num = 464;
					if (Operators.CompareString(sobyt, peremens.trans("Присоединились к серверу"), false) == 0)
					{
						goto IL_36d8;
					}
					goto IL_36ea;
					IL_0015:
					num = 2;
					if ((object)type == null)
					{
						goto IL_001b;
					}
					goto IL_0030;
					IL_001b:
					num = 3;
					type = GetType();
					goto IL_0030;
					IL_0030:
					num = 5;
					this.e = RuntimeHelpers.GetObjectValue(e);
					goto IL_003f;
					IL_003f:
					num = 6;
					this.sender = RuntimeHelpers.GetObjectValue(sender);
					goto IL_004e;
					IL_004e:
					num = 7;
					if (peremens.isCompilBest & !peremens.isDevelop)
					{
						goto IL_0061;
					}
					goto IL_0074;
					IL_0061:
					num = 8;
					peremens.RunProj.Param = this;
					goto IL_0074;
					IL_0074:
					num = 10;
					if (e == null)
					{
						goto IL_007b;
					}
					goto IL_008a;
					IL_007b:
					num = 11;
					eType = "System.EventArgs";
					goto IL_008a;
					IL_008a:
					num = 13;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.MouseEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Нажатие кнопки мыши"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Отжатие кнопки мыши"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Движение курсора"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Вращение колесика"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_012a;
					}
					goto IL_03d5;
					IL_012a:
					num = 14;
					Paramy.Add(peremens.MyZnak + peremens.trans("Кнопка мыши"), peremens.MyZnak + "last");
					goto IL_0160;
					IL_0160:
					num = 15;
					if (e != null)
					{
						goto IL_016a;
					}
					goto IL_01b3;
					IL_016a:
					num = 16;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), OpredKnopky((MouseButtons)Conversions.ToInteger(NewLateBinding.LateGet(e, (Type)null, "Button", new object[0], (string[])null, (Type[])null, (bool[])null))));
					goto IL_01b3;
					IL_01b3:
					num = 18;
					Paramy.Add(peremens.MyZnak + peremens.trans("Мышь X"), peremens.MyZnak + "last");
					goto IL_01e9;
					IL_01e9:
					num = 19;
					if (e != null)
					{
						goto IL_01f3;
					}
					goto IL_0236;
					IL_01f3:
					num = 20;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_0236;
					IL_0236:
					num = 22;
					Paramy.Add(peremens.MyZnak + peremens.trans("Мышь Y"), peremens.MyZnak + "last");
					goto IL_026c;
					IL_026c:
					num = 23;
					if (e != null)
					{
						goto IL_0276;
					}
					goto IL_02b9;
					IL_0276:
					num = 24;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_02b9;
					IL_02b9:
					num = 26;
					Paramy.Add(peremens.MyZnak + peremens.trans("Прокручено колесиком"), peremens.MyZnak + "last");
					goto IL_02ef;
					IL_02ef:
					num = 27;
					if (e != null)
					{
						goto IL_02f9;
					}
					goto IL_033c;
					IL_02f9:
					num = 28;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "Delta", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_033c;
					IL_033c:
					num = 30;
					Paramy.Add(peremens.MyZnak + peremens.trans("Количество кликов"), peremens.MyZnak + "last");
					goto IL_0372;
					IL_0372:
					num = 31;
					if (e != null)
					{
						goto IL_037c;
					}
					goto IL_03bf;
					IL_037c:
					num = 32;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "Clicks", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_03bf;
					IL_03bf:
					num = 34;
					if (e == null)
					{
						goto IL_03c6;
					}
					goto IL_03d5;
					IL_03c6:
					num = 35;
					eType = "System.Windows.Forms.MouseEventArgs";
					goto IL_03d5;
					IL_03d5:
					num = 38;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.KeyPressEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Нажатие клавиатуры"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_0427;
					}
					goto IL_05af;
					IL_0427:
					num = 39;
					Paramy.Add(peremens.MyZnak + peremens.trans("Введенный символ"), peremens.MyZnak + "last");
					goto IL_045d;
					IL_045d:
					num = 40;
					if (e != null)
					{
						goto IL_0467;
					}
					goto IL_04aa;
					IL_0467:
					num = 41;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "KeyChar", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_04aa;
					IL_04aa:
					num = 43;
					Paramy.Add(peremens.MyZnak + peremens.trans("Отменить ввод"), peremens.MyZnak + "last");
					goto IL_04e0;
					IL_04e0:
					num = 44;
					if (e != null)
					{
						goto IL_04ed;
					}
					goto IL_0599;
					IL_04ed:
					num = 45;
					paramy = Paramy;
					index = Paramy.IndexOfValue(peremens.MyZnak + "last");
					typeFromHandle = typeof(peremens);
					array = new object[1];
					array2 = array;
					obj = e;
					array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "handled", new object[0], (string[])null, (Type[])null, (bool[])null));
					array3 = array;
					array4 = array3;
					array5 = new bool[1] { true };
					obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "DaOrNet", array4, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						NewLateBinding.LateSetComplex(obj, (Type)null, "handled", new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, false);
					}
					paramy.SetByIndex(index, RuntimeHelpers.GetObjectValue(obj2));
					goto IL_0599;
					IL_36ea:
					num = 467;
					ParamyUp = new SortedList();
					goto IL_36fc;
					IL_36d8:
					num = 465;
					eType = "WinsockConnectedEventArgs";
					goto IL_36ea;
					IL_0599:
					num = 47;
					if (e == null)
					{
						goto IL_05a0;
					}
					goto IL_05af;
					IL_05a0:
					num = 48;
					eType = "System.Windows.Forms.KeyPressEventArgs";
					goto IL_05af;
					IL_05af:
					num = 51;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.KeyEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Нажатие вниз кнопки"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Отжатие кнопки"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_061b;
					}
					goto IL_0991;
					IL_061b:
					num = 52;
					Paramy.Add(peremens.MyZnak + peremens.trans("Нажатая клавиша"), peremens.MyZnak + "last");
					goto IL_0651;
					IL_0651:
					num = 53;
					if (e != null)
					{
						goto IL_065b;
					}
					goto IL_06ae;
					IL_065b:
					num = 54;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), Enum.GetName(((object)val).GetType(), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "KeyCode", new object[0], (string[])null, (Type[])null, (bool[])null))));
					goto IL_06ae;
					IL_06ae:
					num = 56;
					Paramy.Add(peremens.MyZnak + peremens.trans("Нажат шифт"), peremens.MyZnak + "last");
					goto IL_06e4;
					IL_06e4:
					num = 57;
					if (e != null)
					{
						goto IL_06f1;
					}
					goto IL_079d;
					IL_06f1:
					num = 58;
					paramy2 = Paramy;
					index2 = Paramy.IndexOfValue(peremens.MyZnak + "last");
					typeFromHandle2 = typeof(peremens);
					array6 = new object[1];
					array7 = array6;
					obj = e;
					array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Shift", new object[0], (string[])null, (Type[])null, (bool[])null));
					array3 = array6;
					array8 = array3;
					array5 = new bool[1] { true };
					obj3 = NewLateBinding.LateGet((object)null, typeFromHandle2, "DaOrNet", array8, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						NewLateBinding.LateSetComplex(obj, (Type)null, "Shift", new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, false);
					}
					paramy2.SetByIndex(index2, RuntimeHelpers.GetObjectValue(obj3));
					goto IL_079d;
					IL_3780:
					if (num5 <= num6)
					{
						goto IL_3716;
					}
					goto IL_3785;
					IL_36fc:
					num = 468;
					num6 = checked(Paramy.Count - 1);
					num5 = 0;
					goto IL_3780;
					IL_079d:
					num = 60;
					Paramy.Add(peremens.MyZnak + peremens.trans("Нажат контрол"), peremens.MyZnak + "last");
					goto IL_07d3;
					IL_07d3:
					num = 61;
					if (e != null)
					{
						goto IL_07e0;
					}
					goto IL_088c;
					IL_07e0:
					num = 62;
					paramy3 = Paramy;
					index3 = Paramy.IndexOfValue(peremens.MyZnak + "last");
					typeFromHandle3 = typeof(peremens);
					array6 = new object[1];
					array9 = array6;
					obj = e;
					array9[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Control", new object[0], (string[])null, (Type[])null, (bool[])null));
					array3 = array6;
					array10 = array3;
					array5 = new bool[1] { true };
					obj4 = NewLateBinding.LateGet((object)null, typeFromHandle3, "DaOrNet", array10, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						NewLateBinding.LateSetComplex(obj, (Type)null, "Control", new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, false);
					}
					paramy3.SetByIndex(index3, RuntimeHelpers.GetObjectValue(obj4));
					goto IL_088c;
					IL_3798:
					num = 472;
					if (!(peremens.isCompilBest & !peremens.isDevelop))
					{
						goto end_IL_0007_3;
					}
					break;
					IL_3785:
					num = 471;
					MyObj = RuntimeHelpers.GetObjectValue(sender);
					goto IL_3798;
					IL_088c:
					num = 64;
					Paramy.Add(peremens.MyZnak + peremens.trans("Нажат альт"), peremens.MyZnak + "last");
					goto IL_08c2;
					IL_08c2:
					num = 65;
					if (e != null)
					{
						goto IL_08cf;
					}
					goto IL_097b;
					IL_08cf:
					num = 66;
					paramy4 = Paramy;
					index4 = Paramy.IndexOfValue(peremens.MyZnak + "last");
					typeFromHandle4 = typeof(peremens);
					array6 = new object[1];
					array11 = array6;
					obj = e;
					array11[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Alt", new object[0], (string[])null, (Type[])null, (bool[])null));
					array3 = array6;
					array12 = array3;
					array5 = new bool[1] { true };
					obj5 = NewLateBinding.LateGet((object)null, typeFromHandle4, "DaOrNet", array12, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						NewLateBinding.LateSetComplex(obj, (Type)null, "Alt", new object[1] { RuntimeHelpers.GetObjectValue(array3[0]) }, (string[])null, (Type[])null, true, false);
					}
					paramy4.SetByIndex(index4, RuntimeHelpers.GetObjectValue(obj5));
					goto IL_097b;
					IL_3775:
					num = 470;
					num5 = checked(num5 + 1);
					goto IL_3780;
					IL_3716:
					num = 469;
					ParamyUp.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(Strings), "UCase", new object[1] { RuntimeHelpers.GetObjectValue(Paramy.GetKey(num5)) }, (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(Paramy.GetByIndex(num5)));
					goto IL_3775;
					IL_097b:
					num = 68;
					if (e == null)
					{
						goto IL_0982;
					}
					goto IL_0991;
					IL_0982:
					num = 69;
					eType = "System.Windows.Forms.KeyEventArgs";
					goto IL_0991;
					IL_0991:
					num = 72;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.SplitterEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Разделитель перемещен"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_09e3;
					}
					goto IL_0c0d;
					IL_09e3:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_09eb;
					IL_09eb:
					num = 74;
					Paramy.Add(peremens.MyZnak + peremens.trans("Разделитель X"), peremens.MyZnak + "last");
					goto IL_0a21;
					IL_0a21:
					num = 75;
					if (e != null)
					{
						goto IL_0a2b;
					}
					goto IL_0a6e;
					IL_0a2b:
					num = 76;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "SplitX", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_0a6e;
					IL_0a6e:
					num = 78;
					Paramy.Add(peremens.MyZnak + peremens.trans("Разделитель Y"), peremens.MyZnak + "last");
					goto IL_0aa4;
					IL_0aa4:
					num = 79;
					if (e != null)
					{
						goto IL_0aae;
					}
					goto IL_0af1;
					IL_0aae:
					num = 80;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "SplitY", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_0af1;
					IL_0af1:
					num = 82;
					Paramy.Add(peremens.MyZnak + peremens.trans("Мышь X"), peremens.MyZnak + "last");
					goto IL_0b27;
					IL_0b27:
					num = 83;
					if (e != null)
					{
						goto IL_0b31;
					}
					goto IL_0b74;
					IL_0b31:
					num = 84;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_0b74;
					IL_0b74:
					num = 86;
					Paramy.Add(peremens.MyZnak + peremens.trans("Мышь Y"), peremens.MyZnak + "last");
					goto IL_0baa;
					IL_0baa:
					num = 87;
					if (e != null)
					{
						goto IL_0bb4;
					}
					goto IL_0bf7;
					IL_0bb4:
					num = 88;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_0bf7;
					IL_0bf7:
					num = 90;
					if (e == null)
					{
						goto IL_0bfe;
					}
					goto IL_0c0d;
					IL_0bfe:
					num = 91;
					eType = "System.Windows.Forms.SplitterEventArgs";
					goto IL_0c0d;
					IL_0c0d:
					num = 94;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.SplitterCancelEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Разделитель перемещается"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_0c5f;
					}
					goto IL_0f00;
					IL_0c5f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0c67;
					IL_0c67:
					num = 96;
					Paramy.Add(peremens.MyZnak + peremens.trans("Разделитель X"), peremens.MyZnak + "last");
					goto IL_0c9d;
					IL_0c9d:
					num = 97;
					if (e != null)
					{
						goto IL_0ca7;
					}
					goto IL_0cea;
					IL_0ca7:
					num = 98;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "SplitX", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_0cea;
					IL_0cea:
					num = 100;
					Paramy.Add(peremens.MyZnak + peremens.trans("Разделитель Y"), peremens.MyZnak + "last");
					goto IL_0d20;
					IL_0d20:
					num = 101;
					if (e != null)
					{
						goto IL_0d2a;
					}
					goto IL_0d6d;
					IL_0d2a:
					num = 102;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "SplitY", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_0d6d;
					IL_0d6d:
					num = 104;
					Paramy.Add(peremens.MyZnak + peremens.trans("Мышь X"), peremens.MyZnak + "last");
					goto IL_0da3;
					IL_0da3:
					num = 105;
					if (e != null)
					{
						goto IL_0dad;
					}
					goto IL_0df0;
					IL_0dad:
					num = 106;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "MouseCursorX", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_0df0;
					IL_0df0:
					num = 108;
					Paramy.Add(peremens.MyZnak + peremens.trans("Мышь Y"), peremens.MyZnak + "last");
					goto IL_0e26;
					IL_0e26:
					num = 109;
					if (e != null)
					{
						goto IL_0e30;
					}
					goto IL_0e73;
					IL_0e30:
					num = 110;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "MouseCursorY", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_0e73;
					IL_0e73:
					num = 112;
					Paramy.Add(peremens.MyZnak + peremens.trans("Отменить перемещение"), peremens.MyZnak + "last");
					goto IL_0ea9;
					IL_0ea9:
					num = 113;
					if (e != null)
					{
						goto IL_0eb3;
					}
					goto IL_0eea;
					IL_0eb3:
					num = 114;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), peremens.trans("Нет"));
					goto IL_0eea;
					IL_0eea:
					num = 116;
					if (e == null)
					{
						goto IL_0ef1;
					}
					goto IL_0f00;
					IL_0ef1:
					num = 117;
					eType = "System.Windows.Forms.SplitterCancelEventArgs";
					goto IL_0f00;
					IL_0f00:
					num = 120;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.WebBrowserDocumentCompletedEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Страница загрузилась"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_0f52;
					}
					goto IL_1007;
					IL_0f52:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0f5a;
					IL_0f5a:
					num = 122;
					Paramy.Add(peremens.MyZnak + peremens.trans("Ссылка"), peremens.MyZnak + "last");
					goto IL_0f90;
					IL_0f90:
					num = 123;
					if (e != null)
					{
						goto IL_0f9a;
					}
					goto IL_0ff1;
					IL_0f9a:
					num = 124;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(e, (Type)null, "Url", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AbsoluteUri", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_0ff1;
					IL_0ff1:
					num = 126;
					if (e == null)
					{
						goto IL_0ff8;
					}
					goto IL_1007;
					IL_0ff8:
					num = 127;
					eType = "System.Windows.Forms.WebBrowserDocumentCompletedEventArgs";
					goto IL_1007;
					IL_1007:
					num = 130;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.WebBrowserNavigatingEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Переходит по ссылке"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_105c;
					}
					goto IL_1120;
					IL_105c:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1064;
					IL_1064:
					num = 132;
					Paramy.Add(peremens.MyZnak + peremens.trans("Ссылка"), peremens.MyZnak + "last");
					goto IL_109d;
					IL_109d:
					num = 133;
					if (e != null)
					{
						goto IL_10aa;
					}
					goto IL_1104;
					IL_10aa:
					num = 134;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(e, (Type)null, "Url", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AbsoluteUri", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_1104;
					IL_1104:
					num = 136;
					if (e == null)
					{
						goto IL_110e;
					}
					goto IL_1120;
					IL_110e:
					num = 137;
					eType = "System.Windows.Forms.WebBrowserNavigatingEventArgs";
					goto IL_1120;
					IL_1120:
					num = 140;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.WebBrowserNavigatedEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Перешел по ссылке"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_1175;
					}
					goto IL_1239;
					IL_1175:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_117d;
					IL_117d:
					num = 142;
					Paramy.Add(peremens.MyZnak + peremens.trans("Ссылка"), peremens.MyZnak + "last");
					goto IL_11b6;
					IL_11b6:
					num = 143;
					if (e != null)
					{
						goto IL_11c3;
					}
					goto IL_121d;
					IL_11c3:
					num = 144;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(e, (Type)null, "Url", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "AbsoluteUri", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_121d;
					IL_121d:
					num = 146;
					if (e == null)
					{
						goto IL_1227;
					}
					goto IL_1239;
					IL_1227:
					num = 147;
					eType = "System.Windows.Forms.WebBrowserNavigatedEventArgs";
					goto IL_1239;
					IL_1239:
					num = 150;
					if ((Operators.CompareString(type.ToString(), "System.ComponentModel.CancelEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Открытие в новом окне"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_128e;
					}
					goto IL_1332;
					IL_128e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1296;
					IL_1296:
					num = 152;
					Paramy.Add(peremens.MyZnak + peremens.trans("Отменить в новом окне"), peremens.MyZnak + "last");
					goto IL_12cf;
					IL_12cf:
					num = 153;
					if (e != null)
					{
						goto IL_12dc;
					}
					goto IL_1316;
					IL_12dc:
					num = 154;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), peremens.trans("Нет"));
					goto IL_1316;
					IL_1316:
					num = 156;
					if (e == null)
					{
						goto IL_1320;
					}
					goto IL_1332;
					IL_1320:
					num = 157;
					eType = "System.Windows.Forms.CancelEventArgs";
					goto IL_1332;
					IL_1332:
					num = 160;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.TabControlCancelEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Снимается выделение закладки"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Выделяют закладку"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_13a1;
					}
					goto IL_14f9;
					IL_13a1:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_13a9;
					IL_13a9:
					num = 162;
					Paramy.Add(peremens.MyZnak + peremens.trans("Номер выделенной закладки"), peremens.MyZnak + "last");
					goto IL_13e2;
					IL_13e2:
					num = 163;
					if (e != null)
					{
						goto IL_13ef;
					}
					goto IL_145d;
					IL_13ef:
					num = 164;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(e, (Type)null, "tabPage", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Index", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_145d;
					IL_145d:
					num = 166;
					Paramy.Add(peremens.MyZnak + peremens.trans("Отменить событие"), peremens.MyZnak + "last");
					goto IL_1496;
					IL_1496:
					num = 167;
					if (e != null)
					{
						goto IL_14a3;
					}
					goto IL_14dd;
					IL_14a3:
					num = 168;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), peremens.trans("Нет"));
					goto IL_14dd;
					IL_14dd:
					num = 170;
					if (e == null)
					{
						goto IL_14e7;
					}
					goto IL_14f9;
					IL_14e7:
					num = 171;
					eType = "System.Windows.Forms.TabControlCancelEventArgs";
					goto IL_14f9;
					IL_14f9:
					num = 174;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.TabControlEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Снялось выделение закладки"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_154e;
					}
					goto IL_1626;
					IL_154e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1556;
					IL_1556:
					num = 176;
					Paramy.Add(peremens.MyZnak + peremens.trans("Номер выделенной закладки"), peremens.MyZnak + "last");
					goto IL_158f;
					IL_158f:
					num = 177;
					if (e != null)
					{
						goto IL_159c;
					}
					goto IL_160a;
					IL_159c:
					num = 178;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(e, (Type)null, "tabPage", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Index", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_160a;
					IL_160a:
					num = 180;
					if (e == null)
					{
						goto IL_1614;
					}
					goto IL_1626;
					IL_1614:
					num = 181;
					eType = "System.Windows.Forms.TabControlEventArgs";
					goto IL_1626;
					IL_1626:
					num = 184;
					if ((Operators.CompareString(sobyt, peremens.trans("Выделили закладку"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_1666;
					}
					goto IL_1722;
					IL_1666:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_166e;
					IL_166e:
					num = 186;
					Paramy.Add(peremens.MyZnak + peremens.trans("Номер выделенной закладки"), peremens.MyZnak + "last");
					goto IL_16a7;
					IL_16a7:
					num = 187;
					if (e != null)
					{
						goto IL_16b4;
					}
					goto IL_1722;
					IL_16b4:
					num = 188;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedTabIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_1722;
					IL_1722:
					num = 191;
					if ((Operators.CompareString(type.ToString(), "System.String", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Изменение значения"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_1777;
					}
					goto IL_181b;
					IL_1777:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_177f;
					IL_177f:
					num = 193;
					Paramy.Add(peremens.MyZnak + peremens.trans("Отменить событие"), peremens.MyZnak + "last");
					goto IL_17b8;
					IL_17b8:
					num = 194;
					if (e != null)
					{
						goto IL_17c5;
					}
					goto IL_17ff;
					IL_17c5:
					num = 195;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), peremens.trans("Нет"));
					goto IL_17ff;
					IL_17ff:
					num = 197;
					if (e == null)
					{
						goto IL_1809;
					}
					goto IL_181b;
					IL_1809:
					num = 198;
					eType = "String";
					goto IL_181b;
					IL_181b:
					num = 201;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.DataGridViewCellCancelEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Начало редактирования ячейки"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_1870;
					}
					goto IL_1a2c;
					IL_1870:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1878;
					IL_1878:
					num = 203;
					Paramy.Add(peremens.MyZnak + peremens.trans("Номер строки"), peremens.MyZnak + "last");
					goto IL_18b1;
					IL_18b1:
					num = 204;
					if (e != null)
					{
						goto IL_18be;
					}
					goto IL_1904;
					IL_18be:
					num = 205;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_1904;
					IL_1904:
					num = 207;
					Paramy.Add(peremens.MyZnak + peremens.trans("Номер столбца"), peremens.MyZnak + "last");
					goto IL_193d;
					IL_193d:
					num = 208;
					if (e != null)
					{
						goto IL_194a;
					}
					goto IL_1990;
					IL_194a:
					num = 209;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "ColumnIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_1990;
					IL_1990:
					num = 211;
					Paramy.Add(peremens.MyZnak + peremens.trans("Отменить событие"), peremens.MyZnak + "last");
					goto IL_19c9;
					IL_19c9:
					num = 212;
					if (e != null)
					{
						goto IL_19d6;
					}
					goto IL_1a10;
					IL_19d6:
					num = 213;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), peremens.trans("Нет"));
					goto IL_1a10;
					IL_1a10:
					num = 215;
					if (e == null)
					{
						goto IL_1a1a;
					}
					goto IL_1a2c;
					IL_1a1a:
					num = 216;
					eType = "System.Windows.Forms.DataGridViewCellCancelEventArgs";
					goto IL_1a2c;
					IL_1a2c:
					num = 219;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.DataGridViewCellEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Клик по ячейке"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Двойной клик по ячейке"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Конец редактирования ячеки"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Ячейка в фокусе"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Ячека потеряла фокус"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_1ae9;
					}
					goto IL_1c25;
					IL_1ae9:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1af1;
					IL_1af1:
					num = 221;
					Paramy.Add(peremens.MyZnak + peremens.trans("Номер строки"), peremens.MyZnak + "last");
					goto IL_1b2a;
					IL_1b2a:
					num = 222;
					if (e != null)
					{
						goto IL_1b37;
					}
					goto IL_1b7d;
					IL_1b37:
					num = 223;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_1b7d;
					IL_1b7d:
					num = 225;
					Paramy.Add(peremens.MyZnak + peremens.trans("Номер столбца"), peremens.MyZnak + "last");
					goto IL_1bb6;
					IL_1bb6:
					num = 226;
					if (e != null)
					{
						goto IL_1bc3;
					}
					goto IL_1c09;
					IL_1bc3:
					num = 227;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "ColumnIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_1c09;
					IL_1c09:
					num = 229;
					if (e == null)
					{
						goto IL_1c13;
					}
					goto IL_1c25;
					IL_1c13:
					num = 230;
					eType = "System.Windows.Forms.DataGridViewCellEventArgs";
					goto IL_1c25;
					IL_1c25:
					num = 233;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.DataGridViewColumnEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Столбец переместили"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Сортировка столбца"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Изменилась ширина столбца"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_1cae;
					}
					goto IL_1d72;
					IL_1cae:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1cb6;
					IL_1cb6:
					num = 235;
					Paramy.Add(peremens.MyZnak + peremens.trans("Номер столбца"), peremens.MyZnak + "last");
					goto IL_1cef;
					IL_1cef:
					num = 236;
					if (e != null)
					{
						goto IL_1cfc;
					}
					goto IL_1d56;
					IL_1cfc:
					num = 237;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(e, (Type)null, "Column", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Index", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_1d56;
					IL_1d56:
					num = 239;
					if (e == null)
					{
						goto IL_1d60;
					}
					goto IL_1d72;
					IL_1d60:
					num = 240;
					eType = "System.Windows.Forms.DataGridViewColumnEventArgs";
					goto IL_1d72;
					IL_1d72:
					num = 243;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.DataGridViewCellMouseEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Двойной клик по заголовку столбца"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Клик по заголовку строки"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_1de1;
					}
					goto IL_21df;
					IL_1de1:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_1de9;
					IL_1de9:
					num = 245;
					Paramy.Add(peremens.MyZnak + peremens.trans("Кнопка мыши"), peremens.MyZnak + "last");
					goto IL_1e22;
					IL_1e22:
					num = 246;
					if (e != null)
					{
						goto IL_1e2f;
					}
					goto IL_1e7b;
					IL_1e2f:
					num = 247;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), OpredKnopky((MouseButtons)Conversions.ToInteger(NewLateBinding.LateGet(e, (Type)null, "Button", new object[0], (string[])null, (Type[])null, (bool[])null))));
					goto IL_1e7b;
					IL_1e7b:
					num = 249;
					Paramy.Add(peremens.MyZnak + peremens.trans("Мышь X"), peremens.MyZnak + "last");
					goto IL_1eb4;
					IL_1eb4:
					num = 250;
					if (e != null)
					{
						goto IL_1ec1;
					}
					goto IL_1f07;
					IL_1ec1:
					num = 251;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_1f07;
					IL_1f07:
					num = 253;
					Paramy.Add(peremens.MyZnak + peremens.trans("Мышь Y"), peremens.MyZnak + "last");
					goto IL_1f40;
					IL_1f40:
					num = 254;
					if (e != null)
					{
						goto IL_1f4d;
					}
					goto IL_1f93;
					IL_1f4d:
					num = 255;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_1f93;
					IL_1f93:
					num = 257;
					Paramy.Add(peremens.MyZnak + peremens.trans("Прокручено колесиком"), peremens.MyZnak + "last");
					goto IL_1fcc;
					IL_1fcc:
					num = 258;
					if (e != null)
					{
						goto IL_1fd9;
					}
					goto IL_201f;
					IL_1fd9:
					num = 259;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "Delta", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_201f;
					IL_201f:
					num = 261;
					Paramy.Add(peremens.MyZnak + peremens.trans("Количество кликов"), peremens.MyZnak + "last");
					goto IL_2058;
					IL_2058:
					num = 262;
					if (e != null)
					{
						goto IL_2065;
					}
					goto IL_20ab;
					IL_2065:
					num = 263;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "Clicks", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_20ab;
					IL_20ab:
					num = 265;
					Paramy.Add(peremens.MyZnak + peremens.trans("Номер строки"), peremens.MyZnak + "last");
					goto IL_20e4;
					IL_20e4:
					num = 266;
					if (e != null)
					{
						goto IL_20f1;
					}
					goto IL_2137;
					IL_20f1:
					num = 267;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_2137;
					IL_2137:
					num = 269;
					Paramy.Add(peremens.MyZnak + peremens.trans("Номер столбца"), peremens.MyZnak + "last");
					goto IL_2170;
					IL_2170:
					num = 270;
					if (e != null)
					{
						goto IL_217d;
					}
					goto IL_21c3;
					IL_217d:
					num = 271;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "ColumnIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_21c3;
					IL_21c3:
					num = 273;
					if (e == null)
					{
						goto IL_21cd;
					}
					goto IL_21df;
					IL_21cd:
					num = 274;
					eType = "System.Windows.Forms.DataGridViewCellMouseEventArgs";
					goto IL_21df;
					IL_21df:
					num = 277;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.DataGridViewRowEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Изменилась вышина строки"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_2234;
					}
					goto IL_22f8;
					IL_2234:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_223c;
					IL_223c:
					num = 279;
					Paramy.Add(peremens.MyZnak + peremens.trans("Номер строки"), peremens.MyZnak + "last");
					goto IL_2275;
					IL_2275:
					num = 280;
					if (e != null)
					{
						goto IL_2282;
					}
					goto IL_22dc;
					IL_2282:
					num = 281;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(e, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Index", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_22dc;
					IL_22dc:
					num = 283;
					if (e == null)
					{
						goto IL_22e6;
					}
					goto IL_22f8;
					IL_22e6:
					num = 284;
					eType = "System.Windows.Forms.DataGridViewRowEventArgs";
					goto IL_22f8;
					IL_22f8:
					num = 287;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.DataGridViewRowsAddedEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Добавли строку"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_234d;
					}
					goto IL_2489;
					IL_234d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2355;
					IL_2355:
					num = 289;
					Paramy.Add(peremens.MyZnak + peremens.trans("Номер начальной строки"), peremens.MyZnak + "last");
					goto IL_238e;
					IL_238e:
					num = 290;
					if (e != null)
					{
						goto IL_239b;
					}
					goto IL_23e1;
					IL_239b:
					num = 291;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_23e1;
					IL_23e1:
					num = 293;
					Paramy.Add(peremens.MyZnak + peremens.trans("Количество строк"), peremens.MyZnak + "last");
					goto IL_241a;
					IL_241a:
					num = 294;
					if (e != null)
					{
						goto IL_2427;
					}
					goto IL_246d;
					IL_2427:
					num = 295;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_246d;
					IL_246d:
					num = 297;
					if (e == null)
					{
						goto IL_2477;
					}
					goto IL_2489;
					IL_2477:
					num = 298;
					eType = "System.Windows.Forms.DataGridViewRowsAddedEventArgs";
					goto IL_2489;
					IL_2489:
					num = 301;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.DataGridViewRowsRemovedEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Удалили строку"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_24de;
					}
					goto IL_261a;
					IL_24de:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_24e6;
					IL_24e6:
					num = 303;
					Paramy.Add(peremens.MyZnak + peremens.trans("Номер начальной строки"), peremens.MyZnak + "last");
					goto IL_251f;
					IL_251f:
					num = 304;
					if (e != null)
					{
						goto IL_252c;
					}
					goto IL_2572;
					IL_252c:
					num = 305;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_2572;
					IL_2572:
					num = 307;
					Paramy.Add(peremens.MyZnak + peremens.trans("Количество строк"), peremens.MyZnak + "last");
					goto IL_25ab;
					IL_25ab:
					num = 308;
					if (e != null)
					{
						goto IL_25b8;
					}
					goto IL_25fe;
					IL_25b8:
					num = 309;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "RowCount", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_25fe;
					IL_25fe:
					num = 311;
					if (e == null)
					{
						goto IL_2608;
					}
					goto IL_261a;
					IL_2608:
					num = 312;
					eType = "System.Windows.Forms.DataGridViewRowsRemovedEventArgs";
					goto IL_261a;
					IL_261a:
					num = 315;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.LinkClickedEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Клик по ссылке документа"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_266f;
					}
					goto IL_271f;
					IL_266f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2677;
					IL_2677:
					num = 317;
					Paramy.Add(peremens.MyZnak + peremens.trans("Текст ссылки"), peremens.MyZnak + "last");
					goto IL_26b0;
					IL_26b0:
					num = 318;
					if (e != null)
					{
						goto IL_26bd;
					}
					goto IL_2703;
					IL_26bd:
					num = 319;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "LinkText", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_2703;
					IL_2703:
					num = 321;
					if (e == null)
					{
						goto IL_270d;
					}
					goto IL_271f;
					IL_270d:
					num = 322;
					eType = "System.Windows.Forms.LinkClickedEventArgs";
					goto IL_271f;
					IL_271f:
					num = 325;
					if ((Operators.CompareString(type.ToString(), "System.ComponentModel.CancelEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Открытие"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Отправляется запрос"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_278e;
					}
					goto IL_2832;
					IL_278e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2796;
					IL_2796:
					num = 327;
					Paramy.Add(peremens.MyZnak + peremens.trans("Отменить событие"), peremens.MyZnak + "last");
					goto IL_27cf;
					IL_27cf:
					num = 328;
					if (e != null)
					{
						goto IL_27dc;
					}
					goto IL_2816;
					IL_27dc:
					num = 329;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), peremens.trans("Нет"));
					goto IL_2816;
					IL_2816:
					num = 331;
					if (e == null)
					{
						goto IL_2820;
					}
					goto IL_2832;
					IL_2820:
					num = 332;
					eType = "System.ComponentModel.CancelEventArgs";
					goto IL_2832;
					IL_2832:
					num = 335;
					if ((Operators.CompareString(type.ToString(), "System.Windows.Forms.ToolStripDropDownClosingEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Закрытие"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_2887;
					}
					goto IL_292b;
					IL_2887:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_288f;
					IL_288f:
					num = 337;
					Paramy.Add(peremens.MyZnak + peremens.trans("Отменить событие"), peremens.MyZnak + "last");
					goto IL_28c8;
					IL_28c8:
					num = 338;
					if (e != null)
					{
						goto IL_28d5;
					}
					goto IL_290f;
					IL_28d5:
					num = 339;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), peremens.trans("Нет"));
					goto IL_290f;
					IL_290f:
					num = 341;
					if (e == null)
					{
						goto IL_2919;
					}
					goto IL_292b;
					IL_2919:
					num = 342;
					eType = "System.Windows.Forms.ToolStripDropDownClosingEventArgs";
					goto IL_292b;
					IL_292b:
					num = 345;
					if ((Operators.CompareString(type.ToString(), peremens.ClassAplication + "WinsockConnectionRequestEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Присоединился клиент"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_298a;
					}
					goto IL_2ab0;
					IL_298a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2992;
					IL_2992:
					num = 347;
					Paramy.Add(peremens.MyZnak + peremens.trans("Отменить событие"), peremens.MyZnak + "last");
					goto IL_29cb;
					IL_29cb:
					num = 348;
					if (e != null)
					{
						goto IL_29d8;
					}
					goto IL_2a12;
					IL_29d8:
					num = 349;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), peremens.trans("Нет"));
					goto IL_2a12;
					IL_2a12:
					num = 351;
					Paramy.Add(peremens.MyZnak + peremens.trans("Ip клиента"), peremens.MyZnak + "last");
					goto IL_2a4b;
					IL_2a4b:
					num = 352;
					if (e != null)
					{
						goto IL_2a58;
					}
					goto IL_2a9e;
					IL_2a58:
					num = 353;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "ClientIP", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_2a9e;
					IL_2a9e:
					num = 355;
					eType = "WinsockConnectionRequestEventArgs";
					goto IL_2ab0;
					IL_2ab0:
					num = 357;
					if ((Operators.CompareString(type.ToString(), peremens.ClassAplication + "WinsockCollectionCountChangedEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Изменилось число клиентов"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_2b0f;
					}
					goto IL_2c41;
					IL_2b0f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2b17;
					IL_2b17:
					num = 359;
					Paramy.Add(peremens.MyZnak + peremens.trans("Было клиентов"), peremens.MyZnak + "last");
					goto IL_2b50;
					IL_2b50:
					num = 360;
					if (e != null)
					{
						goto IL_2b5d;
					}
					goto IL_2ba3;
					IL_2b5d:
					num = 361;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "OldCount", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_2ba3;
					IL_2ba3:
					num = 363;
					Paramy.Add(peremens.MyZnak + peremens.trans("Стало клиентов"), peremens.MyZnak + "last");
					goto IL_2bdc;
					IL_2bdc:
					num = 364;
					if (e != null)
					{
						goto IL_2be9;
					}
					goto IL_2c2f;
					IL_2be9:
					num = 365;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "NewCount", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_2c2f;
					IL_2c2f:
					num = 367;
					eType = "WinsockCollectionCountChangedEventArgs";
					goto IL_2c41;
					IL_2c41:
					num = 369;
					if ((Operators.CompareString(type.ToString(), peremens.ClassAplication + "WinsockErrorReceivedEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Произошла ошибка"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_2ca0;
					}
					goto IL_2d9c;
					IL_2ca0:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2ca8;
					IL_2ca8:
					num = 371;
					Paramy.Add(peremens.MyZnak + peremens.trans("Ошибка приема"), peremens.MyZnak + "last");
					goto IL_2ce1;
					IL_2ce1:
					num = 372;
					if (e != null)
					{
						goto IL_2cf1;
					}
					goto IL_2d8a;
					IL_2cf1:
					num = 373;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(e, (Type)null, "ErrorCode", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(e, (Type)null, "Function", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"   "), NewLateBinding.LateGet(e, (Type)null, "Message", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(e, (Type)null, "Details", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_2d8a;
					IL_2d8a:
					num = 375;
					eType = "WinsockErrorReceivedEventArgs";
					goto IL_2d9c;
					IL_2d9c:
					num = 377;
					if ((Operators.CompareString(type.ToString(), peremens.ClassAplication + "WinsockSendEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Отправился текст"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Отправился файл"), false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Отправилась команда"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_2e2f;
					}
					goto IL_3079;
					IL_2e2f:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_2e37;
					IL_2e37:
					num = 379;
					Paramy.Add(peremens.MyZnak + peremens.trans("Процент переданного"), peremens.MyZnak + "last");
					goto IL_2e70;
					IL_2e70:
					num = 380;
					if (e != null)
					{
						goto IL_2e7d;
					}
					goto IL_2ec3;
					IL_2e7d:
					num = 381;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "SentPercent", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_2ec3;
					IL_2ec3:
					num = 383;
					Paramy.Add(peremens.MyZnak + peremens.trans("Ip получателя"), peremens.MyZnak + "last");
					goto IL_2efc;
					IL_2efc:
					num = 384;
					if (e != null)
					{
						goto IL_2f09;
					}
					goto IL_2f4f;
					IL_2f09:
					num = 385;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "DestinationIP", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_2f4f;
					IL_2f4f:
					num = 387;
					Paramy.Add(peremens.MyZnak + peremens.trans("Всего байт"), peremens.MyZnak + "last");
					goto IL_2f88;
					IL_2f88:
					num = 388;
					if (e != null)
					{
						goto IL_2f95;
					}
					goto IL_2fdb;
					IL_2f95:
					num = 389;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "BytesTotal", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_2fdb;
					IL_2fdb:
					num = 391;
					Paramy.Add(peremens.MyZnak + peremens.trans("Отправлено байт"), peremens.MyZnak + "last");
					goto IL_3014;
					IL_3014:
					num = 392;
					if (e != null)
					{
						goto IL_3021;
					}
					goto IL_3067;
					IL_3021:
					num = 393;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "BytesSent", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_3067;
					IL_3067:
					num = 395;
					eType = "WinsockSendEventArgs";
					goto IL_3079;
					IL_3079:
					num = 397;
					if ((Operators.CompareString(type.ToString(), peremens.ClassAplication + "WinsockReceiveProgressEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Идет прием данных"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_30d8;
					}
					goto IL_3322;
					IL_30d8:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_30e0;
					IL_30e0:
					num = 399;
					Paramy.Add(peremens.MyZnak + peremens.trans("Процент полученного"), peremens.MyZnak + "last");
					goto IL_3119;
					IL_3119:
					num = 400;
					if (e != null)
					{
						goto IL_3126;
					}
					goto IL_316c;
					IL_3126:
					num = 401;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "ReceivedPercent", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_316c;
					IL_316c:
					num = 403;
					Paramy.Add(peremens.MyZnak + peremens.trans("Ip источника"), peremens.MyZnak + "last");
					goto IL_31a5;
					IL_31a5:
					num = 404;
					if (e != null)
					{
						goto IL_31b2;
					}
					goto IL_31f8;
					IL_31b2:
					num = 405;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "SourceIP", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_31f8;
					IL_31f8:
					num = 407;
					Paramy.Add(peremens.MyZnak + peremens.trans("Всего байт"), peremens.MyZnak + "last");
					goto IL_3231;
					IL_3231:
					num = 408;
					if (e != null)
					{
						goto IL_323e;
					}
					goto IL_3284;
					IL_323e:
					num = 409;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "BytesTotal", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_3284;
					IL_3284:
					num = 411;
					Paramy.Add(peremens.MyZnak + peremens.trans("Получено байт"), peremens.MyZnak + "last");
					goto IL_32bd;
					IL_32bd:
					num = 412;
					if (e != null)
					{
						goto IL_32ca;
					}
					goto IL_3310;
					IL_32ca:
					num = 413;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "BytesReceived", new object[0], (string[])null, (Type[])null, (bool[])null)));
					goto IL_3310;
					IL_3310:
					num = 415;
					eType = "WinsockReceiveProgressEventArgs";
					goto IL_3322;
					IL_3322:
					num = 417;
					if ((Operators.CompareString(type.ToString(), peremens.ClassAplication + "WinsockStateChangedEventArgs", false) == 0) | (Operators.CompareString(sobyt, peremens.trans("Изменился статус"), false) == 0) | (Operators.CompareString(sobyt, peremens.MyZnak + "All", false) == 0))
					{
						goto IL_3381;
					}
					goto IL_34e5;
					IL_3381:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_3389;
					IL_3389:
					num = 419;
					Paramy.Add(peremens.MyZnak + peremens.trans("Старый статус"), peremens.MyZnak + "last");
					goto IL_33c2;
					IL_33c2:
					num = 420;
					if (e != null)
					{
						goto IL_33cf;
					}
					goto IL_342e;
					IL_33cf:
					num = 421;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(peremens.ClientServStates.GetByIndex(peremens.ClientServStates.IndexOfValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "Old_State", new object[0], (string[])null, (Type[])null, (bool[])null))))));
					goto IL_342e;
					IL_342e:
					num = 423;
					Paramy.Add(peremens.MyZnak + peremens.trans("Новый статус"), peremens.MyZnak + "last");
					goto IL_3467;
					IL_3467:
					num = 424;
					if (e != null)
					{
						goto IL_3474;
					}
					goto IL_34d3;
					IL_3474:
					num = 425;
					Paramy.SetByIndex(Paramy.IndexOfValue(peremens.MyZnak + "last"), RuntimeHelpers.GetObjectValue(peremens.ClientServStates.GetByIndex(peremens.ClientServStates.IndexOfValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(e, (Type)null, "New_State", new object[0], (string[])null, (Type[])null, (bool[])null))))));
					goto IL_34d3;
					IL_34d3:
					num = 427;
					eType = "WinsockStateChangedEventArgs";
					goto IL_34e5;
					IL_34e5:
					num = 429;
					if (Operators.CompareString(sobyt, peremens.trans("Прорисовка"), false) == 0)
					{
						goto IL_3505;
					}
					goto IL_3529;
					IL_3505:
					num = 430;
					if (e == null)
					{
						goto IL_3512;
					}
					goto IL_36ea;
					IL_3512:
					num = 431;
					eType = "System.Windows.Forms.PaintEventArgs";
					goto IL_36ea;
					IL_3529:
					num = 434;
					if (Operators.CompareString(sobyt, peremens.trans("Клик по выделенной ячейке"), false) == 0)
					{
						goto IL_3549;
					}
					goto IL_356d;
					IL_3549:
					num = 435;
					if (e == null)
					{
						goto IL_3556;
					}
					goto IL_36ea;
					IL_3556:
					num = 436;
					eType = "System.Windows.Forms.DataGridViewCellMouseEventArgs";
					goto IL_36ea;
					IL_356d:
					num = 439;
					if (Operators.CompareString(sobyt, peremens.trans("Открытие в новом окне"), false) == 0)
					{
						goto IL_358d;
					}
					goto IL_35b1;
					IL_358d:
					num = 440;
					if (e == null)
					{
						goto IL_359a;
					}
					goto IL_36ea;
					IL_359a:
					num = 441;
					eType = "System.ComponentModel.CancelEventArgs";
					goto IL_36ea;
					IL_35b1:
					num = 444;
					if (Operators.CompareString(sobyt, peremens.trans("Прокрутка"), false) == 0)
					{
						goto IL_35d1;
					}
					goto IL_35f5;
					IL_35d1:
					num = 445;
					if (e == null)
					{
						goto IL_35de;
					}
					goto IL_36ea;
					IL_35de:
					num = 446;
					eType = "System.Windows.Forms.ScrollEventArgs";
					goto IL_36ea;
					IL_35f5:
					num = 449;
					if (Operators.CompareString(sobyt, peremens.trans("Закрытие окна"), false) == 0)
					{
						goto IL_3615;
					}
					goto IL_3639;
					IL_3615:
					num = 450;
					if (e == null)
					{
						goto IL_3622;
					}
					goto IL_36ea;
					IL_3622:
					num = 451;
					eType = "System.Windows.Forms.FormClosingEventArgs";
					goto IL_36ea;
					IL_3639:
					num = 454;
					if (Operators.CompareString(sobyt, peremens.trans("Закрылось"), false) == 0)
					{
						goto IL_3659;
					}
					goto IL_367a;
					IL_3659:
					num = 455;
					if (e == null)
					{
						goto IL_3666;
					}
					goto IL_36ea;
					IL_3666:
					num = 456;
					eType = "System.Windows.Forms.ToolStripDropDownClosedEventArgs";
					goto IL_36ea;
					IL_367a:
					num = 459;
					if (Operators.CompareString(sobyt, peremens.trans("Клик по ссылке"), false) == 0)
					{
						goto IL_369a;
					}
					goto IL_36b8;
					IL_369a:
					num = 460;
					if (e == null)
					{
						goto IL_36a4;
					}
					goto IL_36ea;
					IL_36a4:
					num = 461;
					eType = "System.Windows.Forms.LinkLabelLinkClickedEventArgs";
					goto IL_36ea;
					end_IL_0007_2:
					break;
				}
				num = 473;
				peremens.RunProj.Param = this;
				break;
				end_IL_0007:;
			}
			catch (object obj6) when (obj6 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj6);
				try0007_dispatch = 16197;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0007_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public string OpredKnopky(MouseButtons but)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		string result = peremens.trans("Никакой");
		if ((int)but == 1048576)
		{
			result = peremens.trans("Левая");
		}
		else if ((int)but == 2097152)
		{
			result = peremens.trans("Правая");
		}
		else if ((int)but == 4194304)
		{
			result = peremens.trans("Колесико");
		}
		else if ((int)but == 8388608)
		{
			result = peremens.trans("ДопКнопка1");
		}
		else if ((int)but == 16777216)
		{
			result = peremens.trans("ДопКнопка2");
		}
		return result;
	}

	public void Zavershit()
	{
		if (e == null)
		{
			return;
		}
		checked
		{
			int num = ParamyUp.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Array.IndexOf((Array)peremens.SobytsNotReadOnly, RuntimeHelpers.GetObjectValue(ParamyUp.GetKey(i))) != -1)
				{
					if (Operators.ConditionalCompareObjectEqual(ParamyUp.GetKey(i), (object)Strings.UCase(peremens.MyZnak + peremens.trans("Отменить ввод")), false))
					{
						NewLateBinding.LateSet(e, (Type)null, "Handled", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(peremens), "DaOrNet", new object[1] { RuntimeHelpers.GetObjectValue(ParamyUp.GetByIndex(i)) }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					}
					else
					{
						NewLateBinding.LateSet(e, (Type)null, "Cancel", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)null, typeof(peremens), "DaOrNet", new object[1] { RuntimeHelpers.GetObjectValue(ParamyUp.GetByIndex(i)) }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					}
				}
			}
		}
	}
}
