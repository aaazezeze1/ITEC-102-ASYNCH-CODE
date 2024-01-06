// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
// refer to this video https://youtu.be/e1BChQXdBb0?feature=shared
// arrays aren't allowed so yeah i'm insane and this was torture to code but atleast it works
using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter a number between 0 to 999: ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    if (num >= 0 && num <= 30)
    {
        switch (num)
        {
            case 0: Console.WriteLine("Zero"); break;
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
            case 10: Console.WriteLine("Ten"); break;
            case 11: Console.WriteLine("Eleven"); break;
            case 12: Console.WriteLine("Twelve"); break;
            case 13: Console.WriteLine("Thriteen"); break;
            case 14: Console.WriteLine("Fourteen"); break;
            case 15: Console.WriteLine("Fifteen"); break;
            case 16: Console.WriteLine("Sixteen"); break;
            case 17: Console.WriteLine("Seventeen"); break;
            case 18: Console.WriteLine("Eighteen"); break;
            case 19: Console.WriteLine("Nineteen"); break;
            case 20: Console.WriteLine("Twenty"); break;
            case 21: Console.WriteLine("Twenty One"); break;
            case 22: Console.WriteLine("Twenty Two"); break;
            case 23: Console.WriteLine("Twenty Three"); break;
            case 24: Console.WriteLine("Twenty Four"); break;
            case 25: Console.WriteLine("Twenty Five"); break;
            case 26: Console.WriteLine("Twenty Six"); break;
            case 27: Console.WriteLine("Twenty Seven"); break;
            case 28: Console.WriteLine("Twenty Eight"); break;
            case 29: Console.WriteLine("Twenty Nine"); break;
            case 30: Console.WriteLine("Thirty"); break;
        }
    }
    
    if (num > 30 && num <= 60)
    {
        switch (num)
        {
            case 31: Console.WriteLine("Thirty One"); break;
            case 32: Console.WriteLine("Thirty Two"); break;
            case 33: Console.WriteLine("Thirty Three"); break;
            case 34: Console.WriteLine("Thirty Four"); break;
            case 35: Console.WriteLine("Thirty Five"); break;
            case 36: Console.WriteLine("Thirty Six"); break;
            case 37: Console.WriteLine("Thirty Seven"); break;
            case 38: Console.WriteLine("Thirty Eight"); break;
            case 39: Console.WriteLine("Thirty Nine"); break;
            case 40: Console.WriteLine("Forty"); break;
            case 41: Console.WriteLine("Forty One"); break;
            case 42: Console.WriteLine("Forty Two"); break;
            case 43: Console.WriteLine("Forty Three"); break;
            case 44: Console.WriteLine("Forty Four"); break;
            case 45: Console.WriteLine("Forty Five"); break;
            case 46: Console.WriteLine("Forty Six"); break;
            case 47: Console.WriteLine("Forty Seven"); break;
            case 48: Console.WriteLine("Forty Eight"); break;
            case 49: Console.WriteLine("Forty Nine"); break;
            case 50: Console.WriteLine("Fifty"); break;
            case 51: Console.WriteLine("Fifty One"); break;
            case 52: Console.WriteLine("Fifty Two"); break;
            case 53: Console.WriteLine("Fifty Three"); break;
            case 54: Console.WriteLine("Fifty Four"); break;
            case 55: Console.WriteLine("Fifty Five"); break;
            case 56: Console.WriteLine("Fifty Six"); break;
            case 57: Console.WriteLine("Fifty Seven"); break;
            case 58: Console.WriteLine("Fifty Eight"); break;
            case 59: Console.WriteLine("Fifty Nine"); break;
            case 60: Console.WriteLine("Sixty"); break;
        }
    }
    
    if (num > 60 && num <= 90)
    {
        switch (num)
        {
            case 61: Console.WriteLine("Sixty One"); break;
            case 62: Console.WriteLine("Sixty Two"); break;
            case 63: Console.WriteLine("Sixty Three"); break;
            case 64: Console.WriteLine("Sixty Four"); break;
            case 65: Console.WriteLine("Sixty Five"); break;
            case 66: Console.WriteLine("Sixty Six"); break;
            case 67: Console.WriteLine("Sixty Seven"); break;
            case 68: Console.WriteLine("Sixty Eight"); break;
            case 69: Console.WriteLine("Sixty Nine"); break;
            case 70: Console.WriteLine("Seventy"); break;
            case 71: Console.WriteLine("Seventy One"); break;
            case 72: Console.WriteLine("Seventy Two"); break;
            case 73: Console.WriteLine("Seventy Three"); break;
            case 74: Console.WriteLine("Seventy Four"); break;
            case 75: Console.WriteLine("Seventy Five"); break;
            case 76: Console.WriteLine("Seventy Six"); break;
            case 77: Console.WriteLine("Seventy Seven"); break;
            case 78: Console.WriteLine("Seventy Eight"); break;
            case 79: Console.WriteLine("Seventy Nine"); break;
            case 80: Console.WriteLine("Eighty"); break;
            case 81: Console.WriteLine("Eighty One"); break;
            case 82: Console.WriteLine("Eighty Two"); break;
            case 83: Console.WriteLine("Eighty Three"); break;
            case 84: Console.WriteLine("Eighty Four"); break;
            case 85: Console.WriteLine("Eighty Five"); break;
            case 86: Console.WriteLine("Eighty Six"); break;
            case 87: Console.WriteLine("Eighty Seven"); break;
            case 88: Console.WriteLine("Eighty Eight"); break;
            case 89: Console.WriteLine("Eighty Nine"); break;
            case 90: Console.WriteLine("Ninety"); break;
        }
    }
    
    if (num > 90 && num <= 120)
    {
        switch (num)
        {
            case 91: Console.WriteLine("Ninety One"); break;
            case 92: Console.WriteLine("Ninety Two"); break;
            case 93: Console.WriteLine("Ninety Three"); break;
            case 94: Console.WriteLine("Ninety Four"); break;
            case 95: Console.WriteLine("Ninety Five"); break;
            case 96: Console.WriteLine("Ninety Six"); break;
            case 97: Console.WriteLine("Ninety Seven"); break;
            case 98: Console.WriteLine("Ninety Eight"); break;
            case 99: Console.WriteLine("Ninety Nine"); break;
            case 100: Console.WriteLine("One Hundred"); break;
            case 101: Console.WriteLine("One Hundred One"); break;
            case 102: Console.WriteLine("One Hundred Two"); break;
            case 103: Console.WriteLine("One Hundred Three"); break;
            case 104: Console.WriteLine("One Hundred Four"); break;
            case 105: Console.WriteLine("One Hundred Five"); break;
            case 106: Console.WriteLine("One Hundred Six"); break;
            case 107: Console.WriteLine("One Hundred Seven"); break;
            case 108: Console.WriteLine("One Hundred Eight"); break;
            case 109: Console.WriteLine("One Hundred Nine"); break;
            case 110: Console.WriteLine("One Hundred Ten"); break;
            case 111: Console.WriteLine("One Hundred Eleven"); break;
            case 112: Console.WriteLine("One Hundred Twelve"); break;
            case 113: Console.WriteLine("One Hundred Thriteen"); break;
            case 114: Console.WriteLine("One Hundred Fourteen"); break;
            case 115: Console.WriteLine("One Hundred Fifteen"); break;
            case 116: Console.WriteLine("One Hundred Sixteen"); break;
            case 117: Console.WriteLine("One Hundred Seventeen"); break;
            case 118: Console.WriteLine("One Hundred Eighteen"); break;
            case 119: Console.WriteLine("One Hundred Nineteen"); break;
            case 120: Console.WriteLine("One Hundred Twenty"); break;
        }
    }
    
    if (num > 120 && num <= 150)
    {
        switch (num)
        {
            case 121: Console.WriteLine("One Hundred Twenty One"); break;
            case 122: Console.WriteLine("One Hundred Twenty Two"); break;
            case 123: Console.WriteLine("One Hundred Twenty Three"); break;
            case 124: Console.WriteLine("One Hundred Twenty Four"); break;
            case 125: Console.WriteLine("One Hundred Twenty Five"); break;
            case 126: Console.WriteLine("One Hundred Twenty Six"); break;
            case 127: Console.WriteLine("One Hundred Twenty Seven"); break;
            case 128: Console.WriteLine("One Hundred Twenty Eight"); break;
            case 129: Console.WriteLine("One Hundred Twenty Nine"); break;
            case 130: Console.WriteLine("One Hundred Thirty"); break;
            case 131: Console.WriteLine("One Hundred Thirty One"); break;
            case 132: Console.WriteLine("One Hundred Thirty Two"); break;
            case 133: Console.WriteLine("One Hundred Thirty Three"); break;
            case 134: Console.WriteLine("One Hundred Thirty Four"); break;
            case 135: Console.WriteLine("One Hundred Thirty Five"); break;
            case 136: Console.WriteLine("One Hundred Thirty Six"); break;
            case 137: Console.WriteLine("One Hundred Thirty Seven"); break;
            case 138: Console.WriteLine("One Hundred Thirty Eight"); break;
            case 139: Console.WriteLine("One Hundred Thirty Nine"); break;
            case 140: Console.WriteLine("One Hundred Forty"); break;
            case 141: Console.WriteLine("One Hundred Forty One"); break;
            case 142: Console.WriteLine("One Hundred Forty Two"); break;
            case 143: Console.WriteLine("One Hundred Forty Three"); break;
            case 144: Console.WriteLine("One Hundred Forty Four"); break;
            case 145: Console.WriteLine("One Hundred Forty Five"); break;
            case 146: Console.WriteLine("One Hundred Forty Six"); break;
            case 147: Console.WriteLine("One Hundred Forty Seven"); break;
            case 148: Console.WriteLine("One Hundred Forty Eight"); break;
            case 149: Console.WriteLine("One Hundred Forty Nine"); break;
            case 150: Console.WriteLine("One Hundred Fifty"); break;
        }
    }
    
    if (num > 150 && num <= 180)
    {
        switch (num)
        {
            case 151: Console.WriteLine("One Hundred Fifty One"); break;
            case 152: Console.WriteLine("One Hundred Fifty Two"); break;
            case 153: Console.WriteLine("One Hundred Fifty Three"); break;
            case 154: Console.WriteLine("One Hundred Fifty Four"); break;
            case 155: Console.WriteLine("One Hundred Fifty Five"); break;
            case 156: Console.WriteLine("One Hundred Fifty Six"); break;
            case 157: Console.WriteLine("One Hundred Fifty Seven"); break;
            case 158: Console.WriteLine("One Hundred Fifty Eight"); break;
            case 159: Console.WriteLine("One Hundred Fifty Nine"); break;
            case 160: Console.WriteLine("One Hundred Sixty"); break;
            case 161: Console.WriteLine("One Hundred Sixty One"); break;
            case 162: Console.WriteLine("One Hundred Sixty Two"); break;
            case 163: Console.WriteLine("One Hundred Sixty Three"); break;
            case 164: Console.WriteLine("One Hundred Sixty Four"); break;
            case 165: Console.WriteLine("One Hundred Sixty Five"); break;
            case 166: Console.WriteLine("One Hundred Sixty Six"); break;
            case 167: Console.WriteLine("One Hundred Sixty Seven"); break;
            case 168: Console.WriteLine("One Hundred Sixty Eight"); break;
            case 169: Console.WriteLine("One Hundred Sixty Nine"); break;
            case 170: Console.WriteLine("One Hundred Seventy"); break;
            case 171: Console.WriteLine("One Hundred Seventy One"); break;
            case 172: Console.WriteLine("One Hundred Seventy Two"); break;
            case 173: Console.WriteLine("One Hundred Seventy Three"); break;
            case 174: Console.WriteLine("One Hundred Seventy Four"); break;
            case 175: Console.WriteLine("One Hundred Seventy Five"); break;
            case 176: Console.WriteLine("One Hundred Seventy Six"); break;
            case 177: Console.WriteLine("One Hundred Seventy Seven"); break;
            case 178: Console.WriteLine("One Hundred Seventy Eight"); break;
            case 179: Console.WriteLine("One Hundred Seventy Nine"); break;
            case 180: Console.WriteLine("One Hundred Eighty"); break;
        }
    }
    
    if (num > 180 && num <= 210)
    {
        switch (num)
        {
            case 181: Console.WriteLine("One Hundred Eighty One"); break;
            case 182: Console.WriteLine("One Hundred Eighty Two"); break;
            case 183: Console.WriteLine("One Hundred Eighty Three"); break;
            case 184: Console.WriteLine("One Hundred Eighty Four"); break;
            case 185: Console.WriteLine("One Hundred Eighty Five"); break;
            case 186: Console.WriteLine("One Hundred Eighty Six"); break;
            case 187: Console.WriteLine("One Hundred Eighty Seven"); break;
            case 188: Console.WriteLine("One Hundred Eighty Eight"); break;
            case 189: Console.WriteLine("One Hundred Eighty Nine"); break;
            case 190: Console.WriteLine("One Hundred Ninety"); break;
            case 191: Console.WriteLine("One Hundred Ninety One"); break;
            case 192: Console.WriteLine("One Hundred Ninety Two"); break;
            case 193: Console.WriteLine("One Hundred Ninety Three"); break;
            case 194: Console.WriteLine("One Hundred Ninety Four"); break;
            case 195: Console.WriteLine("One Hundred Ninety Five"); break;
            case 196: Console.WriteLine("One Hundred Ninety Six"); break;
            case 197: Console.WriteLine("One Hundred Ninety Seven"); break;
            case 198: Console.WriteLine("One Hundred Ninety Eight"); break;
            case 199: Console.WriteLine("One Hundred Ninety Nine"); break;
            case 200: Console.WriteLine("Two Hundred"); break;
            case 201: Console.WriteLine("Two Hundred One"); break;
            case 202: Console.WriteLine("Two Hundred Two"); break;
            case 203: Console.WriteLine("Two Hundred Three"); break;
            case 204: Console.WriteLine("Two Hundred Four"); break;
            case 205: Console.WriteLine("Two Hundred Five"); break;
            case 206: Console.WriteLine("Two Hundred Six"); break;
            case 207: Console.WriteLine("Two Hundred Seven"); break;
            case 208: Console.WriteLine("Two Hundred Eight"); break;
            case 209: Console.WriteLine("Two Hundred Nine"); break;
            case 210: Console.WriteLine("Two Hundred Ten"); break;
        }
    }
    
    if (num > 210 && num <= 240)
    {
        switch (num)
        {
            case 211: Console.WriteLine("Two Hundred Eleven"); break;
            case 212: Console.WriteLine("Two Hundred Twelve"); break;
            case 213: Console.WriteLine("Two Hundred Thirteen"); break;
            case 214: Console.WriteLine("Two Hundred Fourteen"); break;
            case 215: Console.WriteLine("Two Hundred Fifteen"); break;
            case 216: Console.WriteLine("Two Hundred Sixteen"); break;
            case 217: Console.WriteLine("Two Hundred Seventeen"); break;
            case 218: Console.WriteLine("Two Hundred Eighteen"); break;
            case 219: Console.WriteLine("Two Hundred Nineteen"); break;
            case 220: Console.WriteLine("Two Hundred Twenty"); break;
            case 221: Console.WriteLine("Two Hundred Twenty One"); break;
            case 222: Console.WriteLine("Two Hundred Twenty Two"); break;
            case 223: Console.WriteLine("Two Hundred Twenty Three"); break;
            case 224: Console.WriteLine("Two Hundred Twenty Four"); break;
            case 225: Console.WriteLine("Two Hundred Twenty Five"); break;
            case 226: Console.WriteLine("Two Hundred Twenty Six"); break;
            case 227: Console.WriteLine("Two Hundred Twenty Seven"); break;
            case 228: Console.WriteLine("Two Hundred Twenty Eight"); break;
            case 229: Console.WriteLine("Two Hundred Twenty Nine"); break;
            case 230: Console.WriteLine("Two Hundred Thirty"); break;
            case 231: Console.WriteLine("Two Hundred Thirty One"); break;
            case 232: Console.WriteLine("Two Hundred Thirty Two"); break;
            case 233: Console.WriteLine("Two Hundred Thirty Three"); break;
            case 234: Console.WriteLine("Two Hundred Thirty Four"); break;
            case 235: Console.WriteLine("Two Hundred Thirty Five"); break;
            case 236: Console.WriteLine("Two Hundred Thirty Six"); break;
            case 237: Console.WriteLine("Two Hundred Thirty Seven"); break;
            case 238: Console.WriteLine("Two Hundred Thirty Eight"); break;
            case 239: Console.WriteLine("Two Hundred Thirty Nine"); break;
            case 240: Console.WriteLine("Two Hundred Forty"); break;
        }
    }
    
    if (num > 240 && num <= 270)
    {
        switch (num)
        {
            case 241: Console.WriteLine("Two Hundred Forty One"); break;
            case 242: Console.WriteLine("Two Hundred Forty Two"); break;
            case 243: Console.WriteLine("Two Hundred Forty Three"); break;
            case 244: Console.WriteLine("Two Hundred Forty Four"); break;
            case 245: Console.WriteLine("Two Hundred Forty Five"); break;
            case 246: Console.WriteLine("Two Hundred Forty Six"); break;
            case 247: Console.WriteLine("Two Hundred Forty Seven"); break;
            case 248: Console.WriteLine("Two Hundred Forty Eight"); break;
            case 249: Console.WriteLine("Two Hundred Forty Nine"); break;
            case 250: Console.WriteLine("Two Hundred Fifty"); break;
            case 251: Console.WriteLine("Two Hundred Fifty One"); break;
            case 252: Console.WriteLine("Two Hundred Fifty Two"); break;
            case 253: Console.WriteLine("Two Hundred Fifty Three"); break;
            case 254: Console.WriteLine("Two Hundred Fifty Four"); break;
            case 255: Console.WriteLine("Two Hundred Fifty Five"); break;
            case 256: Console.WriteLine("Two Hundred Fifty Six"); break;
            case 257: Console.WriteLine("Two Hundred Fifty Seven"); break;
            case 258: Console.WriteLine("Two Hundred Fifty Eight"); break;
            case 259: Console.WriteLine("Two Hundred Fifty Nine"); break;
            case 260: Console.WriteLine("Two Hundred Sixty"); break;
            case 261: Console.WriteLine("Two Hundred Sixty One"); break;
            case 262: Console.WriteLine("Two Hundred Sixty Two"); break;
            case 263: Console.WriteLine("Two Hundred Sixty Three"); break;
            case 264: Console.WriteLine("Two Hundred Sixty Four"); break;
            case 265: Console.WriteLine("Two Hundred Sixty Five"); break;
            case 266: Console.WriteLine("Two Hundred Sixty Six"); break;
            case 267: Console.WriteLine("Two Hundred Sixty Seven"); break;
            case 268: Console.WriteLine("Two Hundred Sixty Eight"); break;
            case 269: Console.WriteLine("Two Hundred Sixty Nine"); break;
            case 270: Console.WriteLine("Two Hundred Seventy"); break;
        }
    }
    
    if (num > 270 && num <= 300)
    {
        switch (num)
        {
            case 271: Console.WriteLine("Two Hundred Seventy One"); break;
            case 272: Console.WriteLine("Two Hundred Seventy Two"); break;
            case 273: Console.WriteLine("Two Hundred Seventy Three"); break;
            case 274: Console.WriteLine("Two Hundred Seventy Four"); break;
            case 275: Console.WriteLine("Two Hundred Seventy Five"); break;
            case 276: Console.WriteLine("Two Hundred Seventy Six"); break;
            case 277: Console.WriteLine("Two Hundred Seventy Seven"); break;
            case 278: Console.WriteLine("Two Hundred Seventy Eight"); break;
            case 279: Console.WriteLine("Two Hundred Seventy Nine"); break;
            case 280: Console.WriteLine("Two Hundred Eighty"); break;
            case 281: Console.WriteLine("Two Hundred Eighty One"); break;
            case 282: Console.WriteLine("Two Hundred Eighty Two"); break;
            case 283: Console.WriteLine("Two Hundred Eighty Three"); break;
            case 284: Console.WriteLine("Two Hundred Eighty Four"); break;
            case 285: Console.WriteLine("Two Hundred Eighty Five"); break;
            case 286: Console.WriteLine("Two Hundred Eighty Six"); break;
            case 287: Console.WriteLine("Two Hundred Eighty Seven"); break;
            case 288: Console.WriteLine("Two Hundred Eighty Eight"); break;
            case 289: Console.WriteLine("Two Hundred Eighty Nine"); break;
            case 290: Console.WriteLine("Two Hundred Ninety"); break;
            case 291: Console.WriteLine("Two Hundred Ninety One"); break;
            case 292: Console.WriteLine("Two Hundred Ninety Two"); break;
            case 293: Console.WriteLine("Two Hundred Ninety Three"); break;
            case 294: Console.WriteLine("Two Hundred Ninety Four"); break;
            case 295: Console.WriteLine("Two Hundred Ninety Five"); break;
            case 296: Console.WriteLine("Two Hundred Ninety Six"); break;
            case 297: Console.WriteLine("Two Hundred Ninety Seven"); break;
            case 298: Console.WriteLine("Two Hundred Ninety Eight"); break;
            case 299: Console.WriteLine("Two Hundred Ninety Nine"); break;
            case 300: Console.WriteLine("Three Hundred"); break;
        }
    }
    
    if (num > 300 && num <= 330)
    {
        switch (num)
        {
            case 301: Console.WriteLine("Three Hundred One"); break;
            case 302: Console.WriteLine("Three Hundred Two"); break;
            case 303: Console.WriteLine("Three Hundred Three"); break;
            case 304: Console.WriteLine("Three Hundred Four"); break;
            case 305: Console.WriteLine("Three Hundred Five"); break;
            case 306: Console.WriteLine("Three Hundred Six"); break;
            case 307: Console.WriteLine("Three Hundred Seven"); break;
            case 308: Console.WriteLine("Three Hundred Eight"); break;
            case 309: Console.WriteLine("Three Hundred Nine"); break;
            case 310: Console.WriteLine("Three Hundred Ten"); break;
            case 311: Console.WriteLine("Three Hundred Eleven"); break;
            case 312: Console.WriteLine("Three Hundred Twelve"); break;
            case 313: Console.WriteLine("Three Hundred Thirteen"); break;
            case 314: Console.WriteLine("Three Hundred Fourteen"); break;
            case 315: Console.WriteLine("Three Hundred Fifteen"); break;
            case 316: Console.WriteLine("Three Hundred Sixteen"); break;
            case 317: Console.WriteLine("Three Hundred Seventeen"); break;
            case 318: Console.WriteLine("Three Hundred Eighteen"); break;
            case 319: Console.WriteLine("Three Hundred Nineteen"); break;
            case 320: Console.WriteLine("Three Hundred Twenty"); break;
            case 321: Console.WriteLine("Three Hundred Twenty One"); break;
            case 322: Console.WriteLine("Three Hundred Twenty Two"); break;
            case 323: Console.WriteLine("Three Hundred Twenty Three"); break;
            case 324: Console.WriteLine("Three Hundred Twenty Four"); break;
            case 325: Console.WriteLine("Three Hundred Twenty Five"); break;
            case 326: Console.WriteLine("Three Hundred Twenty Six"); break;
            case 327: Console.WriteLine("Three Hundred Twenty Seven"); break;
            case 328: Console.WriteLine("Three Hundred Twenty Eight"); break;
            case 329: Console.WriteLine("Three Hundred Twenty Nine"); break;
            case 330: Console.WriteLine("Three Hundred Thirty"); break;
        }
    }
    
    if (num > 330 && num <= 360)
    {
        switch (num)
        {
            case 331: Console.WriteLine("Three Hundred Thirty One"); break;
            case 332: Console.WriteLine("Three Hundred Thirty Two"); break;
            case 333: Console.WriteLine("Three Hundred Thirty Three"); break;
            case 334: Console.WriteLine("Three Hundred Thirty Four"); break;
            case 335: Console.WriteLine("Three Hundred Thirty Five"); break;
            case 336: Console.WriteLine("Three Hundred Thirty Six"); break;
            case 337: Console.WriteLine("Three Hundred Thirty Seven"); break;
            case 338: Console.WriteLine("Three Hundred Thirty Eight"); break;
            case 339: Console.WriteLine("Three Hundred Thirty Nine"); break;
            case 340: Console.WriteLine("Three Hundred Forty"); break;
            case 341: Console.WriteLine("Three Hundred Forty One"); break;
            case 342: Console.WriteLine("Three Hundred Forty Two"); break;
            case 343: Console.WriteLine("Three Hundred Forty Three"); break;
            case 344: Console.WriteLine("Three Hundred Forty Four"); break;
            case 345: Console.WriteLine("Three Hundred Forty Five"); break;
            case 346: Console.WriteLine("Three Hundred Forty Six"); break;
            case 347: Console.WriteLine("Three Hundred Forty Seven"); break;
            case 348: Console.WriteLine("Three Hundred Forty Eight"); break;
            case 349: Console.WriteLine("Three Hundred Forty Nine"); break;
            case 350: Console.WriteLine("Three Hundred Fifty"); break;
            case 351: Console.WriteLine("Three Hundred Fifty One"); break;
            case 352: Console.WriteLine("Three Hundred Fifty Two"); break;
            case 353: Console.WriteLine("Three Hundred Fifty Three"); break;
            case 354: Console.WriteLine("Three Hundred Fifty Four"); break;
            case 355: Console.WriteLine("Three Hundred Fifty Five"); break;
            case 356: Console.WriteLine("Three Hundred Fifty Six"); break;
            case 357: Console.WriteLine("Three Hundred Fifty Seven"); break;
            case 358: Console.WriteLine("Three Hundred Fifty Eight"); break;
            case 359: Console.WriteLine("Three Hundred Fifty Nine"); break;
            case 360: Console.WriteLine("Three Hundred Sixty"); break;
        }
    }
    
    if (num > 360 && num <= 390)
    {
        switch (num)
        {
            case 361: Console.WriteLine("Three Hundred Sixty One"); break;
            case 362: Console.WriteLine("Three Hundred Sixty Two"); break;
            case 363: Console.WriteLine("Three Hundred Sixty Three"); break;
            case 364: Console.WriteLine("Three Hundred Sixty Four"); break;
            case 365: Console.WriteLine("Three Hundred Sixty Five"); break;
            case 366: Console.WriteLine("Three Hundred Sixty Six"); break;
            case 367: Console.WriteLine("Three Hundred Sixty Seven"); break;
            case 368: Console.WriteLine("Three Hundred Sixty Eight"); break;
            case 369: Console.WriteLine("Three Hundred Sixty Nine"); break;
            case 370: Console.WriteLine("Three Hundred Seventy"); break;
            case 371: Console.WriteLine("Three Hundred Seventy One"); break;
            case 372: Console.WriteLine("Three Hundred Seventy Two"); break;
            case 373: Console.WriteLine("Three Hundred Seventy Three"); break;
            case 374: Console.WriteLine("Three Hundred Seventy Four"); break;
            case 375: Console.WriteLine("Three Hundred Seventy Five"); break;
            case 376: Console.WriteLine("Three Hundred Seventy Six"); break;
            case 377: Console.WriteLine("Three Hundred Seventy Seven"); break;
            case 378: Console.WriteLine("Three Hundred Seventy Eight"); break;
            case 379: Console.WriteLine("Three Hundred Seventy Nine"); break;
            case 380: Console.WriteLine("Three Hundred Eighty"); break;
            case 381: Console.WriteLine("Three Hundred Eighty One"); break;
            case 382: Console.WriteLine("Three Hundred Eighty Two"); break;
            case 383: Console.WriteLine("Three Hundred Eighty Three"); break;
            case 384: Console.WriteLine("Three Hundred Eighty Four"); break;
            case 385: Console.WriteLine("Three Hundred Eighty Five"); break;
            case 386: Console.WriteLine("Three Hundred Eighty Six"); break;
            case 387: Console.WriteLine("Three Hundred Eighty Seven"); break;
            case 388: Console.WriteLine("Three Hundred Eighty Eight"); break;
            case 389: Console.WriteLine("Three Hundred Eighty Nine"); break;
            case 390: Console.WriteLine("Three Hundred Ninety"); break;
        }
    }
    
    if (num > 390 && num <= 420)
    {
        switch (num)
        {
            case 391: Console.WriteLine("Three Hundred Ninety One"); break;
            case 392: Console.WriteLine("Three Hundred Ninety Two"); break;
            case 393: Console.WriteLine("Three Hundred Ninety Three"); break;
            case 394: Console.WriteLine("Three Hundred Ninety Four"); break;
            case 395: Console.WriteLine("Three Hundred Ninety Five"); break;
            case 396: Console.WriteLine("Three Hundred Ninety Six"); break;
            case 397: Console.WriteLine("Three Hundred Ninety Seven"); break;
            case 398: Console.WriteLine("Three Hundred Ninety Eight"); break;
            case 399: Console.WriteLine("Three Hundred Ninety Nine"); break;
            case 400: Console.WriteLine("Four Hundred"); break;
            case 401: Console.WriteLine("Four Hundred One"); break;
            case 402: Console.WriteLine("Four Hundred Two"); break;
            case 403: Console.WriteLine("Four Hundred Three"); break;
            case 404: Console.WriteLine("Four Hundred Four"); break;
            case 405: Console.WriteLine("Four Hundred Five"); break;
            case 406: Console.WriteLine("Four Hundred Six"); break;
            case 407: Console.WriteLine("Four Hundred Seven"); break;
            case 408: Console.WriteLine("Four Hundred Eight"); break;
            case 409: Console.WriteLine("Four Hundred Nine"); break;
            case 410: Console.WriteLine("Four Hundred Ten"); break;
            case 411: Console.WriteLine("Four Hundred Eleven"); break;
            case 412: Console.WriteLine("Four Hundred Twelve"); break;
            case 413: Console.WriteLine("Four Hundred Thirteen"); break;
            case 414: Console.WriteLine("Four Hundred Fourteen"); break;
            case 415: Console.WriteLine("Four Hundred Fifteen"); break;
            case 416: Console.WriteLine("Four Hundred Sixteen"); break;
            case 417: Console.WriteLine("Four Hundred Seventeen"); break;
            case 418: Console.WriteLine("Four Hundred Eighteen"); break;
            case 419: Console.WriteLine("Four Hundred Nineteen"); break;
            case 420: Console.WriteLine("Four Hundred Twenty"); break;
        }
    }
    
    if (num > 420 && num <= 450)
    {
        switch (num)
        {
            case 421: Console.WriteLine("Four Hundred Twenty One"); break;
            case 422: Console.WriteLine("Four Hundred Twenty Two"); break;
            case 423: Console.WriteLine("Four Hundred Twenty Three"); break;
            case 424: Console.WriteLine("Four Hundred Twenty Four"); break;
            case 425: Console.WriteLine("Four Hundred Twenty Five"); break;
            case 426: Console.WriteLine("Four Hundred Twenty Six"); break;
            case 427: Console.WriteLine("Four Hundred Twenty Seven"); break;
            case 428: Console.WriteLine("Four Hundred Twenty Eight"); break;
            case 429: Console.WriteLine("Four Hundred Twenty Nine"); break;
            case 430: Console.WriteLine("Four Hundred Thirty"); break;
            case 431: Console.WriteLine("Four Hundred Thirty One"); break;
            case 432: Console.WriteLine("Four Hundred Thirty Two"); break;
            case 433: Console.WriteLine("Four Hundred Thirty Three"); break;
            case 434: Console.WriteLine("Four Hundred Thirty Four"); break;
            case 435: Console.WriteLine("Four Hundred Thirty Five"); break;
            case 436: Console.WriteLine("Four Hundred Thirty Six"); break;
            case 437: Console.WriteLine("Four Hundred Thirty Seven"); break;
            case 438: Console.WriteLine("Four Hundred Thirty Eight"); break;
            case 439: Console.WriteLine("Four Hundred Thirty Nine"); break;
            case 440: Console.WriteLine("Four Hundred Forty"); break;
            case 441: Console.WriteLine("Four Hundred Forty One"); break;
            case 442: Console.WriteLine("Four Hundred Forty Two"); break;
            case 443: Console.WriteLine("Four Hundred Forty Three"); break;
            case 444: Console.WriteLine("Four Hundred Forty Four"); break;
            case 445: Console.WriteLine("Four Hundred Forty Five"); break;
            case 446: Console.WriteLine("Four Hundred Forty Six"); break;
            case 447: Console.WriteLine("Four Hundred Forty Seven"); break;
            case 448: Console.WriteLine("Four Hundred Forty Eight"); break;
            case 449: Console.WriteLine("Four Hundred Forty Nine"); break;
            case 450: Console.WriteLine("Four Hundred Fifty"); break;
        }
    }
    
    if (num > 450 && num <= 480)
    {
        switch (num)
        {
            case 451: Console.WriteLine("Four Hundred Fifty One"); break;
            case 452: Console.WriteLine("Four Hundred Fifty Two"); break;
            case 453: Console.WriteLine("Four Hundred Fifty Three"); break;
            case 454: Console.WriteLine("Four Hundred Fifty Four"); break;
            case 455: Console.WriteLine("Four Hundred Fifty Five"); break;
            case 456: Console.WriteLine("Four Hundred Fifty Six"); break;
            case 457: Console.WriteLine("Four Hundred Fifty Seven"); break;
            case 458: Console.WriteLine("Four Hundred Fifty Eight"); break;
            case 459: Console.WriteLine("Four Hundred Fifty Nine"); break;
            case 460: Console.WriteLine("Four Hundred Sixty"); break;
            case 461: Console.WriteLine("Four Hundred Sixty One"); break;
            case 462: Console.WriteLine("Four Hundred Sixty Two"); break;
            case 463: Console.WriteLine("Four Hundred Sixty Three"); break;
            case 464: Console.WriteLine("Four Hundred Sixty Four"); break;
            case 465: Console.WriteLine("Four Hundred Sixty Five"); break;
            case 466: Console.WriteLine("Four Hundred Sixty Six"); break;
            case 467: Console.WriteLine("Four Hundred Sixty Seven"); break;
            case 468: Console.WriteLine("Four Hundred Sixty Eight"); break;
            case 469: Console.WriteLine("Four Hundred Sixty Nine"); break;
            case 470: Console.WriteLine("Four Hundred Seventy"); break;
            case 471: Console.WriteLine("Four Hundred Seventy One"); break;
            case 472: Console.WriteLine("Four Hundred Seventy Two"); break;
            case 473: Console.WriteLine("Four Hundred Seventy Three"); break;
            case 474: Console.WriteLine("Four Hundred Seventy Four"); break;
            case 475: Console.WriteLine("Four Hundred Seventy Five"); break;
            case 476: Console.WriteLine("Four Hundred Seventy Six"); break;
            case 477: Console.WriteLine("Four Hundred Seventy Seven"); break;
            case 478: Console.WriteLine("Four Hundred Seventy Eight"); break;
            case 479: Console.WriteLine("Four Hundred Seventy Nine"); break;
            case 480: Console.WriteLine("Four Hundred Eighty"); break;
        }
    }
    
    if (num > 480 && num <= 510)
    {
        switch (num)
        {
            case 481: Console.WriteLine("Four Hundred Eighty One"); break;
            case 482: Console.WriteLine("Four Hundred Eighty Two"); break;
            case 483: Console.WriteLine("Four Hundred Eighty Three"); break;
            case 484: Console.WriteLine("Four Hundred Eighty Four"); break;
            case 485: Console.WriteLine("Four Hundred Eighty Five"); break;
            case 486: Console.WriteLine("Four Hundred Eighty Six"); break;
            case 487: Console.WriteLine("Four Hundred Eighty Seven"); break;
            case 488: Console.WriteLine("Four Hundred Eighty Eight"); break;
            case 489: Console.WriteLine("Four Hundred Eighty Nine"); break;
            case 490: Console.WriteLine("Four Hundred Ninety"); break;
            case 491: Console.WriteLine("Four Hundred Ninety One"); break;
            case 492: Console.WriteLine("Four Hundred Ninety Two"); break;
            case 493: Console.WriteLine("Four Hundred Ninety Three"); break;
            case 494: Console.WriteLine("Four Hundred Ninety Four"); break;
            case 495: Console.WriteLine("Four Hundred Ninety Five"); break;
            case 496: Console.WriteLine("Four Hundred Ninety Six"); break;
            case 497: Console.WriteLine("Four Hundred Ninety Seven"); break;
            case 498: Console.WriteLine("Four Hundred Ninety Eight"); break;
            case 499: Console.WriteLine("Four Hundred Ninety Nine"); break;
            case 500: Console.WriteLine("Five Hundred"); break;
            case 501: Console.WriteLine("Five Hundred One"); break;
            case 502: Console.WriteLine("Five Hundred Two"); break;
            case 503: Console.WriteLine("Five Hundred Three"); break;
            case 504: Console.WriteLine("Five Hundred Four"); break;
            case 505: Console.WriteLine("Five Hundred Five"); break;
            case 506: Console.WriteLine("Five Hundred Six"); break;
            case 507: Console.WriteLine("Five Hundred Seven"); break;
            case 508: Console.WriteLine("Five Hundred Eight"); break;
            case 509: Console.WriteLine("Five Hundred Nine"); break;
            case 510: Console.WriteLine("Five Hundred Ten"); break;
        }
    }
    
    if (num > 510 && num <= 540)
    {
        switch (num)
        {
            case 511: Console.WriteLine("Five Hundred Eleven"); break;
            case 512: Console.WriteLine("Five Hundred Twelve"); break;
            case 513: Console.WriteLine("Five Hundred Thirteen"); break;
            case 514: Console.WriteLine("Five Hundred Fourteen"); break;
            case 515: Console.WriteLine("Five Hundred Fifteen"); break;
            case 516: Console.WriteLine("Five Hundred Sixteen"); break;
            case 517: Console.WriteLine("Five Hundred Seventeen"); break;
            case 518: Console.WriteLine("Five Hundred Eighteen"); break;
            case 519: Console.WriteLine("Five Hundred Nineteen"); break;
            case 520: Console.WriteLine("Five Hundred Twenty"); break;
            case 521: Console.WriteLine("Five Hundred Twenty One"); break;
            case 522: Console.WriteLine("Five Hundred Twenty Two"); break;
            case 523: Console.WriteLine("Five Hundred Twenty Three"); break;
            case 524: Console.WriteLine("Five Hundred Twenty Four"); break;
            case 525: Console.WriteLine("Five Hundred Twenty Five"); break;
            case 526: Console.WriteLine("Five Hundred Twenty Six"); break;
            case 527: Console.WriteLine("Five Hundred Twenty Seven"); break;
            case 528: Console.WriteLine("Five Hundred Twenty Eight"); break;
            case 529: Console.WriteLine("Five Hundred Twenty Nine"); break;
            case 530: Console.WriteLine("Five Hundred Thirty"); break;
            case 531: Console.WriteLine("Five Hundred Thirty One"); break;
            case 532: Console.WriteLine("Five Hundred Thirty Two"); break;
            case 533: Console.WriteLine("Five Hundred Thirty Three"); break;
            case 534: Console.WriteLine("Five Hundred Thirty Four"); break;
            case 535: Console.WriteLine("Five Hundred Thirty Five"); break;
            case 536: Console.WriteLine("Five Hundred Thirty Six"); break;
            case 537: Console.WriteLine("Five Hundred Thirty Seven"); break;
            case 538: Console.WriteLine("Five Hundred Thirty Eight"); break;
            case 539: Console.WriteLine("Five Hundred Thirty Nine"); break;
            case 540: Console.WriteLine("Five Hundred Forty"); break;
        }
    }
    
    if (num > 540 && num <= 570)
    {
        switch (num)
        {
            case 541: Console.WriteLine("Five Hundred Forty One"); break;
            case 542: Console.WriteLine("Five Hundred Forty Two"); break;
            case 543: Console.WriteLine("Five Hundred Forty Three"); break;
            case 544: Console.WriteLine("Five Hundred Forty Four"); break;
            case 545: Console.WriteLine("Five Hundred Forty Five"); break;
            case 546: Console.WriteLine("Five Hundred Forty Six"); break;
            case 547: Console.WriteLine("Five Hundred Forty Seven"); break;
            case 548: Console.WriteLine("Five Hundred Forty Eight"); break;
            case 549: Console.WriteLine("Five Hundred Forty Nine"); break;
            case 550: Console.WriteLine("Five Hundred Fifty"); break;
            case 551: Console.WriteLine("Five Hundred Fifty One"); break;
            case 552: Console.WriteLine("Five Hundred Fifty Two"); break;
            case 553: Console.WriteLine("Five Hundred Fifty Three"); break;
            case 554: Console.WriteLine("Five Hundred Fifty Four"); break;
            case 555: Console.WriteLine("Five Hundred Fifty Five"); break;
            case 556: Console.WriteLine("Five Hundred Fifty Six"); break;
            case 557: Console.WriteLine("Five Hundred Fifty Seven"); break;
            case 558: Console.WriteLine("Five Hundred Fifty Eight"); break;
            case 559: Console.WriteLine("Five Hundred Fifty Nine"); break;
            case 560: Console.WriteLine("Five Hundred Sixty"); break;
            case 561: Console.WriteLine("Five Hundred Sixty One"); break;
            case 562: Console.WriteLine("Five Hundred Sixty Two"); break;
            case 563: Console.WriteLine("Five Hundred Sixty Three"); break;
            case 564: Console.WriteLine("Five Hundred Sixty Four"); break;
            case 565: Console.WriteLine("Five Hundred Sixty Five"); break;
            case 566: Console.WriteLine("Five Hundred Sixty Six"); break;
            case 567: Console.WriteLine("Five Hundred Sixty Seven"); break;
            case 568: Console.WriteLine("Five Hundred Sixty Eight"); break;
            case 569: Console.WriteLine("Five Hundred Sixty Nine"); break;
            case 570: Console.WriteLine("Five Hundred Seventy"); break;
        }
    }
    
    if (num > 570 && num <= 600)
    {
        switch (num)
        {
            case 571: Console.WriteLine("Five Hundred Seventy One"); break;
            case 572: Console.WriteLine("Five Hundred Seventy Two"); break;
            case 573: Console.WriteLine("Five Hundred Seventy Three"); break;
            case 574: Console.WriteLine("Five Hundred Seventy Four"); break;
            case 575: Console.WriteLine("Five Hundred Seventy Five"); break;
            case 576: Console.WriteLine("Five Hundred Seventy Six"); break;
            case 577: Console.WriteLine("Five Hundred Seventy Seven"); break;
            case 578: Console.WriteLine("Five Hundred Seventy Eight"); break;
            case 579: Console.WriteLine("Five Hundred Seventy Nine"); break;
            case 580: Console.WriteLine("Five Hundred Eighty"); break;
            case 581: Console.WriteLine("Five Hundred Eighty One"); break;
            case 582: Console.WriteLine("Five Hundred Eighty Two"); break;
            case 583: Console.WriteLine("Five Hundred Eighty Three"); break;
            case 584: Console.WriteLine("Five Hundred Eighty Four"); break;
            case 585: Console.WriteLine("Five Hundred Eighty Five"); break;
            case 586: Console.WriteLine("Five Hundred Eighty Six"); break;
            case 587: Console.WriteLine("Five Hundred Eighty Seven"); break;
            case 588: Console.WriteLine("Five Hundred Eighty Eight"); break;
            case 589: Console.WriteLine("Five Hundred Eighty Nine"); break;
            case 590: Console.WriteLine("Five Hundred Ninety"); break;
            case 591: Console.WriteLine("Five Hundred Ninety One"); break;
            case 592: Console.WriteLine("Five Hundred Ninety Two"); break;
            case 593: Console.WriteLine("Five Hundred Ninety Three"); break;
            case 594: Console.WriteLine("Five Hundred Ninety Four"); break;
            case 595: Console.WriteLine("Five Hundred Ninety Five"); break;
            case 596: Console.WriteLine("Five Hundred Ninety Six"); break;
            case 597: Console.WriteLine("Five Hundred Ninety Seven"); break;
            case 598: Console.WriteLine("Five Hundred Ninety Eight"); break;
            case 599: Console.WriteLine("Five Hundred Ninety Nine"); break;
            case 600: Console.WriteLine("Six Hundred"); break;
        }
    }
    
    if (num > 600 && num <= 630)
    {
        switch (num)
        {
            case 601: Console.WriteLine("Six Hundred One"); break;
            case 602: Console.WriteLine("Six Hundred Two"); break;
            case 603: Console.WriteLine("Six Hundred Three"); break;
            case 604: Console.WriteLine("Six Hundred Four"); break;
            case 605: Console.WriteLine("Six Hundred Five"); break;
            case 606: Console.WriteLine("Six Hundred Six"); break;
            case 607: Console.WriteLine("Six Hundred Seven"); break;
            case 608: Console.WriteLine("Six Hundred Eight"); break;
            case 609: Console.WriteLine("Six Hundred Nine"); break;
            case 610: Console.WriteLine("Six Hundred Ten"); break;
            case 611: Console.WriteLine("Six Hundred Eleven"); break;
            case 612: Console.WriteLine("Six Hundred Twelve"); break;
            case 613: Console.WriteLine("Six Hundred Thirteen"); break;
            case 614: Console.WriteLine("Six Hundred Fourteen"); break;
            case 615: Console.WriteLine("Six Hundred Fifteen"); break;
            case 616: Console.WriteLine("Six Hundred Sixteen"); break;
            case 617: Console.WriteLine("Six Hundred Seventeen"); break;
            case 618: Console.WriteLine("Six Hundred Eighteen"); break;
            case 619: Console.WriteLine("Six Hundred Nineteen"); break;
            case 620: Console.WriteLine("Six Hundred Twenty"); break;
            case 621: Console.WriteLine("Six Hundred Twenty One"); break;
            case 622: Console.WriteLine("Six Hundred Twenty Two"); break;
            case 623: Console.WriteLine("Six Hundred Twenty Three"); break;
            case 624: Console.WriteLine("Six Hundred Twenty Four"); break;
            case 625: Console.WriteLine("Six Hundred Twenty Five"); break;
            case 626: Console.WriteLine("Six Hundred Twenty Six"); break;
            case 627: Console.WriteLine("Six Hundred Twenty Seven"); break;
            case 628: Console.WriteLine("Six Hundred Twenty Eight"); break;
            case 629: Console.WriteLine("Six Hundred Twenty Nine"); break;
            case 630: Console.WriteLine("Six Hundred Thirty"); break;
            case 631: Console.WriteLine("Six Hundred Thirty One"); break;
            case 632: Console.WriteLine("Six Hundred Thirty Two"); break;
            case 633: Console.WriteLine("Six Hundred Thirty Three"); break;
            case 634: Console.WriteLine("Six Hundred Thirty Four"); break;
            case 635: Console.WriteLine("Six Hundred Thirty Five"); break;
            case 636: Console.WriteLine("Six Hundred Thirty Six"); break;
            case 637: Console.WriteLine("Six Hundred Thirty Seven"); break;
            case 638: Console.WriteLine("Six Hundred Thirty Eight"); break;
            case 639: Console.WriteLine("Six Hundred Thirty Nine"); break;
            case 640: Console.WriteLine("Six Hundred Forty"); break;
        }
    }
    
    if (num > 640 && num <= 670)
    {
        switch (num)
        {
            case 641: Console.WriteLine("Six Hundred Forty One"); break;
            case 642: Console.WriteLine("Six Hundred Forty Two"); break;
            case 643: Console.WriteLine("Six Hundred Forty Three"); break;
            case 644: Console.WriteLine("Six Hundred Forty Four"); break;
            case 645: Console.WriteLine("Six Hundred Forty Five"); break;
            case 646: Console.WriteLine("Six Hundred Forty Six"); break;
            case 647: Console.WriteLine("Six Hundred Forty Seven"); break;
            case 648: Console.WriteLine("Six Hundred Forty Eight"); break;
            case 649: Console.WriteLine("Six Hundred Forty Nine"); break;
            case 650: Console.WriteLine("Six Hundred Fifty"); break;
            case 651: Console.WriteLine("Six Hundred Fifty One"); break;
            case 652: Console.WriteLine("Six Hundred Fifty Two"); break;
            case 653: Console.WriteLine("Six Hundred Fifty Three"); break;
            case 654: Console.WriteLine("Six Hundred Fifty Four"); break;
            case 655: Console.WriteLine("Six Hundred Fifty Five"); break;
            case 656: Console.WriteLine("Six Hundred Fifty Six"); break;
            case 657: Console.WriteLine("Six Hundred Fifty Seven"); break;
            case 658: Console.WriteLine("Six Hundred Fifty Eight"); break;
            case 659: Console.WriteLine("Six Hundred Fifty Nine"); break;
            case 660: Console.WriteLine("Six Hundred Sixty"); break;
            case 661: Console.WriteLine("Six Hundred Sixty One"); break;
            case 662: Console.WriteLine("Six Hundred Sixty Two"); break;
            case 663: Console.WriteLine("Six Hundred Sixty Three"); break;
            case 664: Console.WriteLine("Six Hundred Sixty Four"); break;
            case 665: Console.WriteLine("Six Hundred Sixty Five"); break;
            case 666: Console.WriteLine("Six Hundred Sixty Six"); break;
            case 667: Console.WriteLine("Six Hundred Sixty Seven"); break;
            case 668: Console.WriteLine("Six Hundred Sixty Eight"); break;
            case 669: Console.WriteLine("Six Hundred Sixty Nine"); break;
            case 670: Console.WriteLine("Six Hundred Seventy"); break;
        }
    }
    
    if (num > 670 && num <= 700)
    {
        switch (num)
        {
            case 671: Console.WriteLine("Six Hundred Seventy One"); break;
            case 672: Console.WriteLine("Six Hundred Seventy Two"); break;
            case 673: Console.WriteLine("Six Hundred Seventy Three"); break;
            case 674: Console.WriteLine("Six Hundred Seventy Four"); break;
            case 675: Console.WriteLine("Six Hundred Seventy Five"); break;
            case 676: Console.WriteLine("Six Hundred Seventy Six"); break;
            case 677: Console.WriteLine("Six Hundred Seventy Seven"); break;
            case 678: Console.WriteLine("Six Hundred Seventy Eight"); break;
            case 679: Console.WriteLine("Six Hundred Seventy Nine"); break;
            case 680: Console.WriteLine("Six Hundred Eighty"); break;
            case 681: Console.WriteLine("Six Hundred Eighty One"); break;
            case 682: Console.WriteLine("Six Hundred Eighty Two"); break;
            case 683: Console.WriteLine("Six Hundred Eighty Three"); break;
            case 684: Console.WriteLine("Six Hundred Eighty Four"); break;
            case 685: Console.WriteLine("Six Hundred Eighty Five"); break;
            case 686: Console.WriteLine("Six Hundred Eighty Six"); break;
            case 687: Console.WriteLine("Six Hundred Eighty Seven"); break;
            case 688: Console.WriteLine("Six Hundred Eighty Eight"); break;
            case 689: Console.WriteLine("Six Hundred Eighty Nine"); break;
            case 690: Console.WriteLine("Six Hundred Ninety"); break;
            case 691: Console.WriteLine("Six Hundred Ninety One"); break;
            case 692: Console.WriteLine("Six Hundred Ninety Two"); break;
            case 693: Console.WriteLine("Six Hundred Ninety Three"); break;
            case 694: Console.WriteLine("Six Hundred Ninety Four"); break;
            case 695: Console.WriteLine("Six Hundred Ninety Five"); break;
            case 696: Console.WriteLine("Six Hundred Ninety Six"); break;
            case 697: Console.WriteLine("Six Hundred Ninety Seven"); break;
            case 698: Console.WriteLine("Six Hundred Ninety Eight"); break;
            case 699: Console.WriteLine("Six Hundred Ninety Nine"); break;
            case 700: Console.WriteLine("Seven Hundred"); break;
        }
    }
    
    if (num > 700 && num <= 730)
    {
        switch (num)
        {
            case 701: Console.WriteLine("Seven Hundred One"); break;
            case 702: Console.WriteLine("Seven Hundred Two"); break;
            case 703: Console.WriteLine("Seven Hundred Three"); break;
            case 704: Console.WriteLine("Seven Hundred Four"); break;
            case 705: Console.WriteLine("Seven Hundred Five"); break;
            case 706: Console.WriteLine("Seven Hundred Six"); break;
            case 707: Console.WriteLine("Seven Hundred Seven"); break;
            case 708: Console.WriteLine("Seven Hundred Eight"); break;
            case 709: Console.WriteLine("Seven Hundred Nine"); break;
            case 710: Console.WriteLine("Seven Hundred Ten"); break;
            case 711: Console.WriteLine("Seven Hundred Eleven"); break;
            case 712: Console.WriteLine("Seven Hundred Twelve"); break;
            case 713: Console.WriteLine("Seven Hundred Thirteen"); break;
            case 714: Console.WriteLine("Seven Hundred Fourteen"); break;
            case 715: Console.WriteLine("Seven Hundred Fifteen"); break;
            case 716: Console.WriteLine("Seven Hundred Sixteen"); break;
            case 717: Console.WriteLine("Seven Hundred Seventeen"); break;
            case 718: Console.WriteLine("Seven Hundred Eighteen"); break;
            case 719: Console.WriteLine("Seven Hundred Nineteen"); break;
            case 720: Console.WriteLine("Seven Hundred Twenty"); break;
            case 721: Console.WriteLine("Seven Hundred Twenty One"); break;
            case 722: Console.WriteLine("Seven Hundred Twenty Two"); break;
            case 723: Console.WriteLine("Seven Hundred Twenty Three"); break;
            case 724: Console.WriteLine("Seven Hundred Twenty Four"); break;
            case 725: Console.WriteLine("Seven Hundred Twenty Five"); break;
            case 726: Console.WriteLine("Seven Hundred Twenty Six"); break;
            case 727: Console.WriteLine("Seven Hundred Twenty Seven"); break;
            case 728: Console.WriteLine("Seven Hundred Twenty Eight"); break;
            case 729: Console.WriteLine("Seven Hundred Twenty Nine"); break;
            case 730: Console.WriteLine("Seven Hundred Thirty"); break;
        }
    }
    
    if (num > 730 && num <= 760)
    {
        switch (num)
        {
            case 731: Console.WriteLine("Seven Hundred Thirty One"); break;
            case 732: Console.WriteLine("Seven Hundred Thirty Two"); break;
            case 733: Console.WriteLine("Seven Hundred Thirty Three"); break;
            case 734: Console.WriteLine("Seven Hundred Thirty Four"); break;
            case 735: Console.WriteLine("Seven Hundred Thirty Five"); break;
            case 736: Console.WriteLine("Seven Hundred Thirty Six"); break;
            case 737: Console.WriteLine("Seven Hundred Thirty Seven"); break;
            case 738: Console.WriteLine("Seven Hundred Thirty Eight"); break;
            case 739: Console.WriteLine("Seven Hundred Thirty Nine"); break;
            case 740: Console.WriteLine("Seven Hundred Forty"); break;
            case 741: Console.WriteLine("Seven Hundred Forty One"); break;
            case 742: Console.WriteLine("Seven Hundred Forty Two"); break;
            case 743: Console.WriteLine("Seven Hundred Forty Three"); break;
            case 744: Console.WriteLine("Seven Hundred Forty Four"); break;
            case 745: Console.WriteLine("Seven Hundred Forty Five"); break;
            case 746: Console.WriteLine("Seven Hundred Forty Six"); break;
            case 747: Console.WriteLine("Seven Hundred Forty Seven"); break;
            case 748: Console.WriteLine("Seven Hundred Forty Eight"); break;
            case 749: Console.WriteLine("Seven Hundred Forty Nine"); break;
            case 750: Console.WriteLine("Seven Hundred Fifty"); break;
            case 751: Console.WriteLine("Seven Hundred Fifty One"); break;
            case 752: Console.WriteLine("Seven Hundred Fifty Two"); break;
            case 753: Console.WriteLine("Seven Hundred Fifty Three"); break;
            case 754: Console.WriteLine("Seven Hundred Fifty Four"); break;
            case 755: Console.WriteLine("Seven Hundred Fifty Five"); break;
            case 756: Console.WriteLine("Seven Hundred Fifty Six"); break;
            case 757: Console.WriteLine("Seven Hundred Fifty Seven"); break;
            case 758: Console.WriteLine("Seven Hundred Fifty Eight"); break;
            case 759: Console.WriteLine("Seven Hundred Fifty Nine"); break;
            case 760: Console.WriteLine("Seven Hundred Sixty"); break;
        }
    }
    
    if (num > 760 && num <= 790)
    {
        switch (num)
        {
            case 761: Console.WriteLine("Seven Hundred Sixty One"); break;
            case 762: Console.WriteLine("Seven Hundred Sixty Two"); break;
            case 763: Console.WriteLine("Seven Hundred Sixty Three"); break;
            case 764: Console.WriteLine("Seven Hundred Sixty Four"); break;
            case 765: Console.WriteLine("Seven Hundred Sixty Five"); break;
            case 766: Console.WriteLine("Seven Hundred Sixty Six"); break;
            case 767: Console.WriteLine("Seven Hundred Sixty Seven"); break;
            case 768: Console.WriteLine("Seven Hundred Sixty Eight"); break;
            case 769: Console.WriteLine("Seven Hundred Sixty Nine"); break;
            case 770: Console.WriteLine("Seven Hundred Seventy"); break;
            case 771: Console.WriteLine("Seven Hundred Seventy One"); break;
            case 772: Console.WriteLine("Seven Hundred Seventy Two"); break;
            case 773: Console.WriteLine("Seven Hundred Seventy Three"); break;
            case 774: Console.WriteLine("Seven Hundred Seventy Four"); break;
            case 775: Console.WriteLine("Seven Hundred Seventy Five"); break;
            case 776: Console.WriteLine("Seven Hundred Seventy Six"); break;
            case 777: Console.WriteLine("Seven Hundred Seventy Seven"); break;
            case 778: Console.WriteLine("Seven Hundred Seventy Eight"); break;
            case 779: Console.WriteLine("Seven Hundred Seventy Nine"); break;
            case 780: Console.WriteLine("Seven Hundred Eighty"); break;
            case 781: Console.WriteLine("Seven Hundred Eighty One"); break;
            case 782: Console.WriteLine("Seven Hundred Eighty Two"); break;
            case 783: Console.WriteLine("Seven Hundred Eighty Three"); break;
            case 784: Console.WriteLine("Seven Hundred Eighty Four"); break;
            case 785: Console.WriteLine("Seven Hundred Eighty Five"); break;
            case 786: Console.WriteLine("Seven Hundred Eighty Six"); break;
            case 787: Console.WriteLine("Seven Hundred Eighty Seven"); break;
            case 788: Console.WriteLine("Seven Hundred Eighty Eight"); break;
            case 789: Console.WriteLine("Seven Hundred Eighty Nine"); break;
            case 790: Console.WriteLine("Seven Hundred Ninety"); break;
        }
    }
    
    if (num > 790 && num <= 820)
    {
        switch (num)
        {
            case 791: Console.WriteLine("Seven Hundred Ninety One"); break;
            case 792: Console.WriteLine("Seven Hundred Ninety Two"); break;
            case 793: Console.WriteLine("Seven Hundred Ninety Three"); break;
            case 794: Console.WriteLine("Seven Hundred Ninety Four"); break;
            case 795: Console.WriteLine("Seven Hundred Ninety Five"); break;
            case 796: Console.WriteLine("Seven Hundred Ninety Six"); break;
            case 797: Console.WriteLine("Seven Hundred Ninety Seven"); break;
            case 798: Console.WriteLine("Seven Hundred Ninety Eight"); break;
            case 799: Console.WriteLine("Seven Hundred Ninety Nine"); break;
            case 800: Console.WriteLine("Eight Hundred"); break;
            case 801: Console.WriteLine("Eight Hundred One"); break;
            case 802: Console.WriteLine("Eight Hundred Two"); break;
            case 803: Console.WriteLine("Eight Hundred Three"); break;
            case 804: Console.WriteLine("Eight Hundred Four"); break;
            case 805: Console.WriteLine("Eight Hundred Five"); break;
            case 806: Console.WriteLine("Eight Hundred Six"); break;
            case 807: Console.WriteLine("Eight Hundred Seven"); break;
            case 808: Console.WriteLine("Eight Hundred Eight"); break;
            case 809: Console.WriteLine("Eight Hundred Nine"); break;
            case 810: Console.WriteLine("Eight Hundred Ten"); break;
            case 811: Console.WriteLine("Eight Hundred Eleven"); break;
            case 812: Console.WriteLine("Eight Hundred Twelve"); break;
            case 813: Console.WriteLine("Eight Hundred Thirteen"); break;
            case 814: Console.WriteLine("Eight Hundred Fourteen"); break;
            case 815: Console.WriteLine("Eight Hundred Fifteen"); break;
            case 816: Console.WriteLine("Eight Hundred Sixteen"); break;
            case 817: Console.WriteLine("Eight Hundred Seventeen"); break;
            case 818: Console.WriteLine("Eight Hundred Eighteen"); break;
            case 819: Console.WriteLine("Eight Hundred Nineteen"); break;
            case 820: Console.WriteLine("Eight Hundred Twenty"); break;
        }
    }
    
    if (num > 820 && num <= 850)
    {
        switch (num)
        {
            case 821: Console.WriteLine("Eight Hundred Twenty One"); break;
            case 822: Console.WriteLine("Eight Hundred Twenty Two"); break;
            case 823: Console.WriteLine("Eight Hundred Twenty Three"); break;
            case 824: Console.WriteLine("Eight Hundred Twenty Four"); break;
            case 825: Console.WriteLine("Eight Hundred Twenty Five"); break;
            case 826: Console.WriteLine("Eight Hundred Twenty Six"); break;
            case 827: Console.WriteLine("Eight Hundred Twenty Seven"); break;
            case 828: Console.WriteLine("Eight Hundred Twenty Eight"); break;
            case 829: Console.WriteLine("Eight Hundred Twenty Nine"); break;
            case 830: Console.WriteLine("Eight Hundred Thirty"); break;
            case 831: Console.WriteLine("Eight Hundred Thirty One"); break;
            case 832: Console.WriteLine("Eight Hundred Thirty Two"); break;
            case 833: Console.WriteLine("Eight Hundred Thirty Three"); break;
            case 834: Console.WriteLine("Eight Hundred Thirty Four"); break;
            case 835: Console.WriteLine("Eight Hundred Thirty Five"); break;
            case 836: Console.WriteLine("Eight Hundred Thirty Six"); break;
            case 837: Console.WriteLine("Eight Hundred Thirty Seven"); break;
            case 838: Console.WriteLine("Eight Hundred Thirty Eight"); break;
            case 839: Console.WriteLine("Eight Hundred Thirty Nine"); break;
            case 840: Console.WriteLine("Eight Hundred Forty"); break;
            case 841: Console.WriteLine("Eight Hundred Forty One"); break;
            case 842: Console.WriteLine("Eight Hundred Forty Two"); break;
            case 843: Console.WriteLine("Eight Hundred Forty Three"); break;
            case 844: Console.WriteLine("Eight Hundred Forty Four"); break;
            case 845: Console.WriteLine("Eight Hundred Forty Five"); break;
            case 846: Console.WriteLine("Eight Hundred Forty Six"); break;
            case 847: Console.WriteLine("Eight Hundred Forty Seven"); break;
            case 848: Console.WriteLine("Eight Hundred Forty Eight"); break;
            case 849: Console.WriteLine("Eight Hundred Forty Nine"); break;
            case 850: Console.WriteLine("Eight Hundred Fifty"); break;
        }
    }
    
    if (num > 850 && num <= 880)
    {
        switch (num)
        {
            case 851: Console.WriteLine("Eight Hundred Fifty One"); break;
            case 852: Console.WriteLine("Eight Hundred Fifty Two"); break;
            case 853: Console.WriteLine("Eight Hundred Fifty Three"); break;
            case 854: Console.WriteLine("Eight Hundred Fifty Four"); break;
            case 855: Console.WriteLine("Eight Hundred Fifty Five"); break;
            case 856: Console.WriteLine("Eight Hundred Fifty Six"); break;
            case 857: Console.WriteLine("Eight Hundred Fifty Seven"); break;
            case 858: Console.WriteLine("Eight Hundred Fifty Eight"); break;
            case 859: Console.WriteLine("Eight Hundred Fifty Nine"); break;
            case 860: Console.WriteLine("Eight Hundred Sixty"); break;
            case 861: Console.WriteLine("Eight Hundred Sixty One"); break;
            case 862: Console.WriteLine("Eight Hundred Sixty Two"); break;
            case 863: Console.WriteLine("Eight Hundred Sixty Three"); break;
            case 864: Console.WriteLine("Eight Hundred Sixty Four"); break;
            case 865: Console.WriteLine("Eight Hundred Sixty Five"); break;
            case 866: Console.WriteLine("Eight Hundred Sixty Six"); break;
            case 867: Console.WriteLine("Eight Hundred Sixty Seven"); break;
            case 868: Console.WriteLine("Eight Hundred Sixty Eight"); break;
            case 869: Console.WriteLine("Eight Hundred Sixty Nine"); break;
            case 870: Console.WriteLine("Eight Hundred Seventy"); break;
            case 871: Console.WriteLine("Eight Hundred Seventy One"); break;
            case 872: Console.WriteLine("Eight Hundred Seventy Two"); break;
            case 873: Console.WriteLine("Eight Hundred Seventy Three"); break;
            case 874: Console.WriteLine("Eight Hundred Seventy Four"); break;
            case 875: Console.WriteLine("Eight Hundred Seventy Five"); break;
            case 876: Console.WriteLine("Eight Hundred Seventy Six"); break;
            case 877: Console.WriteLine("Eight Hundred Seventy Seven"); break;
            case 878: Console.WriteLine("Eight Hundred Seventy Eight"); break;
            case 879: Console.WriteLine("Eight Hundred Seventy Nine"); break;
            case 880: Console.WriteLine("Eight Hundred Eighty"); break;
        }
    }
    
    if (num > 880 && num <= 910)
    {
        switch (num)
        {
            case 881: Console.WriteLine("Eight Hundred Eighty One"); break;
            case 882: Console.WriteLine("Eight Hundred Eighty Two"); break;
            case 883: Console.WriteLine("Eight Hundred Eighty Three"); break;
            case 884: Console.WriteLine("Eight Hundred Eighty Four"); break;
            case 885: Console.WriteLine("Eight Hundred Eighty Five"); break;
            case 886: Console.WriteLine("Eight Hundred Eighty Six"); break;
            case 887: Console.WriteLine("Eight Hundred Eighty Seven"); break;
            case 888: Console.WriteLine("Eight Hundred Eighty Eight"); break;
            case 889: Console.WriteLine("Eight Hundred Eighty Nine"); break;
            case 890: Console.WriteLine("Eight Hundred Ninety"); break;
            case 891: Console.WriteLine("Eight Hundred Ninety One"); break;
            case 892: Console.WriteLine("Eight Hundred Ninety Two"); break;
            case 893: Console.WriteLine("Eight Hundred Ninety Three"); break;
            case 894: Console.WriteLine("Eight Hundred Ninety Four"); break;
            case 895: Console.WriteLine("Eight Hundred Ninety Five"); break;
            case 896: Console.WriteLine("Eight Hundred Ninety Six"); break;
            case 897: Console.WriteLine("Eight Hundred Ninety Seven"); break;
            case 898: Console.WriteLine("Eight Hundred Ninety Eight"); break;
            case 899: Console.WriteLine("Eight Hundred Ninety Nine"); break;
            case 900: Console.WriteLine("Nine Hundred"); break;
            case 901: Console.WriteLine("Nine Hundred One"); break;
            case 902: Console.WriteLine("Nine Hundred Two"); break;
            case 903: Console.WriteLine("Nine Hundred Three"); break;
            case 904: Console.WriteLine("Nine Hundred Four"); break;
            case 905: Console.WriteLine("Nine Hundred Five"); break;
            case 906: Console.WriteLine("Nine Hundred Six"); break;
            case 907: Console.WriteLine("Nine Hundred Seven"); break;
            case 908: Console.WriteLine("Nine Hundred Eight"); break;
            case 909: Console.WriteLine("Nine Hundred Nine"); break;
            case 910: Console.WriteLine("Nine Hundred Ten"); break;
        }
    }
    
    if (num > 910 && num <= 940)
    {
        switch (num)
        {
            case 911: Console.WriteLine("Nine Hundred Eleven"); break;
            case 912: Console.WriteLine("Nine Hundred Twelve"); break;
            case 913: Console.WriteLine("Nine Hundred Thirteen"); break;
            case 914: Console.WriteLine("Nine Hundred Fourteen"); break;
            case 915: Console.WriteLine("Nine Hundred Fifteen"); break;
            case 916: Console.WriteLine("Nine Hundred Sixteen"); break;
            case 917: Console.WriteLine("Nine Hundred Seventeen"); break;
            case 918: Console.WriteLine("Nine Hundred Eighteen"); break;
            case 919: Console.WriteLine("Nine Hundred Nineteen"); break;
            case 920: Console.WriteLine("Nine Hundred Twenty"); break;
            case 921: Console.WriteLine("Nine Hundred Twenty One"); break;
            case 922: Console.WriteLine("Nine Hundred Twenty Two"); break;
            case 923: Console.WriteLine("Nine Hundred Twenty Three"); break;
            case 924: Console.WriteLine("Nine Hundred Twenty Four"); break;
            case 925: Console.WriteLine("Nine Hundred Twenty Five"); break;
            case 926: Console.WriteLine("Nine Hundred Twenty Six"); break;
            case 927: Console.WriteLine("Nine Hundred Twenty Seven"); break;
            case 928: Console.WriteLine("Nine Hundred Twenty Eight"); break;
            case 929: Console.WriteLine("Nine Hundred Twenty Nine"); break;
            case 930: Console.WriteLine("Nine Hundred Thirty"); break;
            case 931: Console.WriteLine("Nine Hundred Thirty One"); break;
            case 932: Console.WriteLine("Nine Hundred Thirty Two"); break;
            case 933: Console.WriteLine("Nine Hundred Thirty Three"); break;
            case 934: Console.WriteLine("Nine Hundred Thirty Four"); break;
            case 935: Console.WriteLine("Nine Hundred Thirty Five"); break;
            case 936: Console.WriteLine("Nine Hundred Thirty Six"); break;
            case 937: Console.WriteLine("Nine Hundred Thirty Seven"); break;
            case 938: Console.WriteLine("Nine Hundred Thirty Eight"); break;
            case 939: Console.WriteLine("Nine Hundred Thirty Nine"); break;
            case 940: Console.WriteLine("Nine Hundred Forty"); break;
        }
    }
    
    if (num > 940 && num <= 970)
    {
        switch (num)
        {
            case 941: Console.WriteLine("Nine Hundred Forty One"); break;
            case 942: Console.WriteLine("Nine Hundred Forty Two"); break;
            case 943: Console.WriteLine("Nine Hundred Forty Three"); break;
            case 944: Console.WriteLine("Nine Hundred Forty Four"); break;
            case 945: Console.WriteLine("Nine Hundred Forty Five"); break;
            case 946: Console.WriteLine("Nine Hundred Forty Six"); break;
            case 947: Console.WriteLine("Nine Hundred Forty Seven"); break;
            case 948: Console.WriteLine("Nine Hundred Forty Eight"); break;
            case 949: Console.WriteLine("Nine Hundred Forty Nine"); break;
            case 950: Console.WriteLine("Nine Hundred Fifty"); break;
            case 951: Console.WriteLine("Nine Hundred Fifty One"); break;
            case 952: Console.WriteLine("Nine Hundred Fifty Two"); break;
            case 953: Console.WriteLine("Nine Hundred Fifty Three"); break;
            case 954: Console.WriteLine("Nine Hundred Fifty Four"); break;
            case 955: Console.WriteLine("Nine Hundred Fifty Five"); break;
            case 956: Console.WriteLine("Nine Hundred Fifty Six"); break;
            case 957: Console.WriteLine("Nine Hundred Fifty Seven"); break;
            case 958: Console.WriteLine("Nine Hundred Fifty Eight"); break;
            case 959: Console.WriteLine("Nine Hundred Fifty Nine"); break;
            case 960: Console.WriteLine("Nine Hundred Sixty"); break;
            case 961: Console.WriteLine("Nine Hundred Sixty One"); break;
            case 962: Console.WriteLine("Nine Hundred Sixty Two"); break;
            case 963: Console.WriteLine("Nine Hundred Sixty Three"); break;
            case 964: Console.WriteLine("Nine Hundred Sixty Four"); break;
            case 965: Console.WriteLine("Nine Hundred Sixty Five"); break;
            case 966: Console.WriteLine("Nine Hundred Sixty Six"); break;
            case 967: Console.WriteLine("Nine Hundred Sixty Seven"); break;
            case 968: Console.WriteLine("Nine Hundred Sixty Eight"); break;
            case 969: Console.WriteLine("Nine Hundred Sixty Nine"); break;
            case 970: Console.WriteLine("Nine Hundred Seventy"); break;
        }
    }
    
    if (num > 970 && num <= 999)
    {
        switch (num)
        {
            case 970: Console.WriteLine("Nine Hundred Seventy"); break;
            case 971: Console.WriteLine("Nine Hundred Seventy One"); break;
            case 972: Console.WriteLine("Nine Hundred Seventy Two"); break;
            case 973: Console.WriteLine("Nine Hundred Seventy Three"); break;
            case 974: Console.WriteLine("Nine Hundred Seventy Four"); break;
            case 975: Console.WriteLine("Nine Hundred Seventy Five"); break;
            case 976: Console.WriteLine("Nine Hundred Seventy Six"); break;
            case 977: Console.WriteLine("Nine Hundred Seventy Seven"); break;
            case 978: Console.WriteLine("Nine Hundred Seventy Eight"); break;
            case 979: Console.WriteLine("Nine Hundred Seventy Nine"); break;
            case 980: Console.WriteLine("Nine Hundred Eighty"); break;
            case 981: Console.WriteLine("Nine Hundred Eighty One"); break;
            case 982: Console.WriteLine("Nine Hundred Eighty Two"); break;
            case 983: Console.WriteLine("Nine Hundred Eighty Three"); break;
            case 984: Console.WriteLine("Nine Hundred Eighty Four"); break;
            case 985: Console.WriteLine("Nine Hundred Eighty Five"); break;
            case 986: Console.WriteLine("Nine Hundred Eighty Six"); break;
            case 987: Console.WriteLine("Nine Hundred Eighty Seven"); break;
            case 988: Console.WriteLine("Nine Hundred Eighty Eight"); break;
            case 989: Console.WriteLine("Nine Hundred Eighty Nine"); break;
            case 990: Console.WriteLine("Nine Hundred Ninety"); break;
            case 991: Console.WriteLine("Nine Hundred Ninety One"); break;
            case 992: Console.WriteLine("Nine Hundred Ninety Two"); break;
            case 993: Console.WriteLine("Nine Hundred Ninety Three"); break;
            case 994: Console.WriteLine("Nine Hundred Ninety Four"); break;
            case 995: Console.WriteLine("Nine Hundred Ninety Five"); break;
            case 996: Console.WriteLine("Nine Hundred Ninety Six"); break;
            case 997: Console.WriteLine("Nine Hundred Ninety Seven"); break;
            case 998: Console.WriteLine("Nine Hundred Ninety Eight"); break;
            case 999: Console.WriteLine("Nine Hundred Ninety Nine"); break;
        }
    }
    }
}