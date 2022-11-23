using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 3, b = 7;
            sbyte c = -7, d = 0;
            short e = -1000, f = 1;
            ushort g = 2, h = 30000;
            int i = -1000000, j = 485;
            uint k = 500, l = 4294967295;
            long m = -922337203685547765, n = 9223372036855477;
            ulong o = 2, p = 9223372036855477654;
            char q = 'L', r = 't';
            float s = 0.0001f, t = 9.89f;
            decimal u = 400.75m, v = 3_000.5m;
            double w = 12.111, x = -956.1007;
            bool y = true, z = false;
            string s1 = "letter", s2 = "signature";

            // <, >, <=, >=, ==

            bool comparisonByte = a == b;
            bool comparisonByte1 = a > b;
            bool comparisonByte2 = a < b;
            bool comparisonByte3 = a >= b;
            bool comparisonByte4 = a <= b;

            Console.WriteLine("Comparison of type is Byte:");
            Console.WriteLine($"{a} == {b} = {comparisonByte}");
            Console.WriteLine($"{a} > {b} = {comparisonByte1}");
            Console.WriteLine($"{a} < {b} = {comparisonByte2}");
            Console.WriteLine($"{a} >= {b} = {comparisonByte3}");
            Console.WriteLine($"{a} <= {b} = {comparisonByte4} \n");

            bool comparisonSbyte = c == d;
            bool comparisonSbyte1 = c > d;
            bool comparisonSbyte2 = c < d;
            bool comparisonSbyte3 = c >= d;
            bool comparisonSbyte4 = c <= d;

            Console.WriteLine("Comparison of type is Sbyte:");
            Console.WriteLine($"{c} == {d} = {comparisonSbyte}");
            Console.WriteLine($"{c} > {d} = {comparisonSbyte1}");
            Console.WriteLine($"{c} < {d} = {comparisonSbyte2}");
            Console.WriteLine($"{c} >= {d} = {comparisonSbyte3}");
            Console.WriteLine($"{c} <= {d} = {comparisonSbyte4} \n");

            bool comparisonShort = e == f;
            bool comparisonShort1 = e > f;
            bool comparisonShort2 = e < f;
            bool comparisonShort3 = e >= f;
            bool comparisonShort4 = e <= f;

            Console.WriteLine("Comparison of type is Short:");
            Console.WriteLine($"{e} == {f} = {comparisonShort}");
            Console.WriteLine($"{e} > {f} = {comparisonShort1}");
            Console.WriteLine($"{e} < {f} = {comparisonShort2}");
            Console.WriteLine($"{e} >= {f} = {comparisonShort3}");
            Console.WriteLine($"{e} <= {f} = {comparisonShort4} \n");

            bool comparisonUshort = g == h;
            bool comparisonUshort1 = g > h;
            bool comparisonUshort2 = g < h;
            bool comparisonUshort3 = g >= h;
            bool comparisonUshort4 = g <= h;

            Console.WriteLine("Comparison of type is Ushort:");
            Console.WriteLine($"{g} == {h} = {comparisonUshort}");
            Console.WriteLine($"{g} > {h} = {comparisonUshort1}");
            Console.WriteLine($"{g} < {h} = {comparisonUshort2}");
            Console.WriteLine($"{g} >= {h} = {comparisonUshort3}");
            Console.WriteLine($"{g} <= {h} = {comparisonUshort4} \n");

            bool comparisonInt = i == j;
            bool comparisonInt1 = i > j;
            bool comparisonInt2 = i < j;
            bool comparisonInt3 = i >= j;
            bool comparisonInt4 = i <= j;

            Console.WriteLine("Comparison of type is Int:");
            Console.WriteLine($"{i} == {j} = {comparisonInt}");
            Console.WriteLine($"{i} > {j} = {comparisonInt1}");
            Console.WriteLine($"{i} < {j} = {comparisonInt2}");
            Console.WriteLine($"{i} >= {j} = {comparisonInt3}");
            Console.WriteLine($"{i} <= {j} = {comparisonInt4}  \n");

            bool comparisonUint = i == j;
            bool comparisonUint1 = i > j;
            bool comparisonUint2 = i < j;
            bool comparisonUint3 = i >= j;
            bool comparisonUint4 = i <= j;

            Console.WriteLine("Comparison of type is Uint:");
            Console.WriteLine($"{k} == {l} = {comparisonUint}");
            Console.WriteLine($"{k} > {l} = {comparisonUint1}");
            Console.WriteLine($"{k} < {l} = {comparisonUint2}");
            Console.WriteLine($"{k} >= {l} = {comparisonUint3}");
            Console.WriteLine($"{k} <= {l} = {comparisonUint4} \n");

            Console.WriteLine("Comparison of type is Long:");
            bool comparisonLong = m == n;
            bool comparisonLong1 = m > n;
            bool comparisonLong2 = m < n;
            bool comparisonLong3 = m >= n;
            bool comparisonLong4 = m <= n;
            Console.WriteLine($"{m} == {n} = {comparisonLong}");
            Console.WriteLine($"{m} > {n} = {comparisonLong1}");
            Console.WriteLine($"{m} < {n} = {comparisonLong2}");
            Console.WriteLine($"{m} >= {n} = {comparisonLong3}");
            Console.WriteLine($"{m} <= {n} = {comparisonLong4}  \n");

            Console.WriteLine("Comparison of type is Ulong:");
            bool comparisonUlong = o == p;
            bool comparisonUlong1 = o > p;
            bool comparisonUlong2 = o < p;
            bool comparisonUlong3 = o >= p;
            bool comparisonUlong4 = o <= p;
            Console.WriteLine($"{o} == {p} = {comparisonUlong}");
            Console.WriteLine($"{o} > {p} = {comparisonUlong1}");
            Console.WriteLine($"{o} < {p} = {comparisonUlong2}");
            Console.WriteLine($"{o} >= {p} = {comparisonUlong3}");
            Console.WriteLine($"{o} <= {p} = {comparisonUlong4}  \n");

            Console.WriteLine("Comparison of type is Char:");
            bool comparisonChar = q == r;
            bool comparisonChar1 = q > r;
            bool comparisonChar2 = q < r;
            bool comparisonChar3 = q >= r;
            bool comparisonChar4 = q <= r;
            Console.WriteLine($"{q} == {r} = {comparisonChar}");
            Console.WriteLine($"{q} > {r} = {comparisonChar1}");
            Console.WriteLine($"{q} < {r} = {comparisonChar2}");
            Console.WriteLine($"{q} >= {r} = {comparisonChar3}");
            Console.WriteLine($"{q} <= {r} = {comparisonChar4}  \n");

            Console.WriteLine("Comparison of type is Float:");
            bool comparisonFloat = s == t;
            bool comparisonFloat1 = s > t;
            bool comparisonFloat2 = s < t;
            bool comparisonFloat3 = s >= t;
            bool comparisonFloat4 = s <= t;
            Console.WriteLine($"{s} == {t} = {comparisonFloat}");
            Console.WriteLine($"{s} > {t} = {comparisonFloat1}");
            Console.WriteLine($"{s} < {t} = {comparisonFloat2}");
            Console.WriteLine($"{s} >= {t} = {comparisonFloat3}");
            Console.WriteLine($"{s} <= {t} = {comparisonFloat4}  \n");

            Console.WriteLine("Comparison of type is Decimal:");
            bool comparisonDecimal = u == v;
            bool comparisonDecimal1 = u > v;
            bool comparisonDecimal2 = u < v;
            bool comparisonDecimal3 = u >= v;
            bool comparisonDecimal4 = u <= v;
            Console.WriteLine($"{u} == {v} = {comparisonDecimal}");
            Console.WriteLine($"{u} > {v} = {comparisonDecimal2}");
            Console.WriteLine($"{u} >= {v} = {comparisonDecimal3}");
            Console.WriteLine($"{u} <= {v} = {comparisonDecimal4}  \n");

            Console.WriteLine("Comparison of type is Double:");
            bool comparisonDouble = w == x;
            bool comparisonDouble1 = w > x;
            bool comparisonDouble2 = w < x;
            bool comparisonDouble3 = w >= x;
            bool comparisonDouble4 = w <= x;
            Console.WriteLine($"{w} == {x} = {comparisonDouble}");
            Console.WriteLine($"{w} > {x} = {comparisonDouble1}");
            Console.WriteLine($"{w} < {x} = {comparisonDouble2}");
            Console.WriteLine($"{w} >= {x} = {comparisonDouble3}");
            Console.WriteLine($"{w} <= {x} = {comparisonDouble4}  \n");

            Console.WriteLine("Comparison of type is Bool:");
            bool comparisonBool = y == z;
           // bool comparisonBool1 = y > z;
           // bool comparisonBool2 = y < z;
           // bool comparisonBool3 = y >= z;
           // bool comparisonBool4 = y <= z;
            Console.WriteLine($"{y} == {z} = {comparisonBool}");
           // Console.WriteLine($"{y} > {z} = {comparisonBool1}");
           // Console.WriteLine($"{y} < {z} = {comparisonBool2}");
           // Console.WriteLine($"{y} >= {z} = {comparisonBool3}");
           // Console.WriteLine($"{y} <= {z} = {comparisonBool4}  \n");

            Console.WriteLine("Comparison of type is String:");
            bool comparisonString = s1 == s2;
           // bool comparisonString1 = s1 > s2;
           // bool comparisonString2 = s1 < s2;
           // bool comparisonString3 = s1 >= s2;
           // bool comparisonString4 = s1 <= s2;
            Console.WriteLine($"{s1} == {s2} = {comparisonString}");
           // Console.WriteLine($"{s1} > {s2} = {comparisonString1}");
           // Console.WriteLine($"{s1} < {s2} = {comparisonString2}");
           // Console.WriteLine($"{s1} >= {s2} = {comparisonString3}");
           // Console.WriteLine($"{s1} <= {s2} = {comparisonString4}  \n");


            Console.ReadKey();
        }
    }
}
