using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using System.Xml;
using System.Globalization;
using System.Net;
using System.Reflection;
using System.ComponentModel;
using System.Xml.Xsl;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using System.Drawing;
using System.Runtime.InteropServices;

[CompilerGenerated]
internal sealed class PrivateImplementationDetails
{
    // Token: 0x0600027A RID: 634 RVA: 0x00011844 File Offset: 0x0000FA44
    internal static uint ComputeStringHash(string s)
    {
        uint num = 0;
    if (s != null)
        {
            num = 2166136261U;
            for (int i = 0; i < s.Length; i++)
            {
                num = ((uint)s[i] ^ num) * 16777619U;
            }
        }
        return num;
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1024)]
    private struct __StaticArrayInitTypeSize1024

    {
    }

// Token: 0x040000DD RID: 221 RVA: 0x00029B94 File Offset: 0x00027D94
internal static readonly long _9D75365EC9B6F679EDF98065F16E00E071553B95AD3069EB14E73651DA88D36D;

// Token: 0x0200004D RID: 77
}


namespace HtmlAgilityPack
{
    // Token: 0x02000005 RID: 5
    public enum AttributeValueQuote
    {
        // Token: 0x04000015 RID: 21
        SingleQuote,
        // Token: 0x04000016 RID: 22
        DoubleQuote,
        // Token: 0x04000017 RID: 23
        None,
        // Token: 0x04000018 RID: 24
        WithoutValue,
        // Token: 0x04000019 RID: 25
        Initial
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000002 RID: 2
    [Obsolete("This type should not be used; it is intended for internal use in HTML Agility Pack.")]
    [CLSCompliant(false)]
    public class Crc32
    {
        // Token: 0x17000001 RID: 1
        // (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        // (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
        internal uint CheckSum
        {
            get
            {
                return this._crc32;
            }
            set
            {
                this._crc32 = value;
            }
        }

        // Token: 0x06000003 RID: 3 RVA: 0x00002064 File Offset: 0x00000264
        public static uint CRC32Bytes(byte[] bytes)
        {
            uint num = uint.MaxValue;
            int i = bytes.Length;
            int num2 = 0;
            while (i > 0)
            {
                i--;
                num = Crc32.UPDC32(bytes[i], num);
                num2++;
            }
            return ~num;
        }

        // Token: 0x06000004 RID: 4 RVA: 0x00002094 File Offset: 0x00000294
        public static uint CRC32String(string text)
        {
            uint num = uint.MaxValue;
            int i = text.Length;
            int num2 = 0;
            while (i > 0)
            {
                i--;
                char c = text[i];
                byte octet = (byte)(c & 'ÿ');
                num = Crc32.UPDC32((byte)(c >> 8), num);
                num = Crc32.UPDC32(octet, num);
                num2++;
            }
            return ~num;
        }

        // Token: 0x06000005 RID: 5 RVA: 0x000020DE File Offset: 0x000002DE
        internal uint AddToCRC32(int c)
        {
            return this.AddToCRC32((ushort)c);
        }

        // Token: 0x06000006 RID: 6 RVA: 0x000020E8 File Offset: 0x000002E8
        internal uint AddToCRC32(ushort c)
        {
            byte octet = (byte)(c & 255);
            byte octet2 = (byte)(c >> 8);
            this._crc32 = Crc32.UPDC32(octet2, this._crc32);
            this._crc32 = Crc32.UPDC32(octet, this._crc32);
            return ~this._crc32;
        }

        // Token: 0x06000007 RID: 7 RVA: 0x0000212E File Offset: 0x0000032E
        private static uint UPDC32(byte octet, uint crc)
        {
            return Crc32.crc_32_tab[(int)((crc ^ (uint)octet) & 255U)] ^ crc >> 8;
        }

        // Token: 0x04000001 RID: 1
        private uint _crc32;

        // Token: 0x04000002 RID: 2
        private static uint[] crc_32_tab = new uint[]
        {
            0U,
            1996959894U,
            3993919788U,
            2567524794U,
            124634137U,
            1886057615U,
            3915621685U,
            2657392035U,
            249268274U,
            2044508324U,
            3772115230U,
            2547177864U,
            162941995U,
            2125561021U,
            3887607047U,
            2428444049U,
            498536548U,
            1789927666U,
            4089016648U,
            2227061214U,
            450548861U,
            1843258603U,
            4107580753U,
            2211677639U,
            325883990U,
            1684777152U,
            4251122042U,
            2321926636U,
            335633487U,
            1661365465U,
            4195302755U,
            2366115317U,
            997073096U,
            1281953886U,
            3579855332U,
            2724688242U,
            1006888145U,
            1258607687U,
            3524101629U,
            2768942443U,
            901097722U,
            1119000684U,
            3686517206U,
            2898065728U,
            853044451U,
            1172266101U,
            3705015759U,
            2882616665U,
            651767980U,
            1373503546U,
            3369554304U,
            3218104598U,
            565507253U,
            1454621731U,
            3485111705U,
            3099436303U,
            671266974U,
            1594198024U,
            3322730930U,
            2970347812U,
            795835527U,
            1483230225U,
            3244367275U,
            3060149565U,
            1994146192U,
            31158534U,
            2563907772U,
            4023717930U,
            1907459465U,
            112637215U,
            2680153253U,
            3904427059U,
            2013776290U,
            251722036U,
            2517215374U,
            3775830040U,
            2137656763U,
            141376813U,
            2439277719U,
            3865271297U,
            1802195444U,
            476864866U,
            2238001368U,
            4066508878U,
            1812370925U,
            453092731U,
            2181625025U,
            4111451223U,
            1706088902U,
            314042704U,
            2344532202U,
            4240017532U,
            1658658271U,
            366619977U,
            2362670323U,
            4224994405U,
            1303535960U,
            984961486U,
            2747007092U,
            3569037538U,
            1256170817U,
            1037604311U,
            2765210733U,
            3554079995U,
            1131014506U,
            879679996U,
            2909243462U,
            3663771856U,
            1141124467U,
            855842277U,
            2852801631U,
            3708648649U,
            1342533948U,
            654459306U,
            3188396048U,
            3373015174U,
            1466479909U,
            544179635U,
            3110523913U,
            3462522015U,
            1591671054U,
            702138776U,
            2966460450U,
            3352799412U,
            1504918807U,
            783551873U,
            3082640443U,
            3233442989U,
            3988292384U,
            2596254646U,
            62317068U,
            1957810842U,
            3939845945U,
            2647816111U,
            81470997U,
            1943803523U,
            3814918930U,
            2489596804U,
            225274430U,
            2053790376U,
            3826175755U,
            2466906013U,
            167816743U,
            2097651377U,
            4027552580U,
            2265490386U,
            503444072U,
            1762050814U,
            4150417245U,
            2154129355U,
            426522225U,
            1852507879U,
            4275313526U,
            2312317920U,
            282753626U,
            1742555852U,
            4189708143U,
            2394877945U,
            397917763U,
            1622183637U,
            3604390888U,
            2714866558U,
            953729732U,
            1340076626U,
            3518719985U,
            2797360999U,
            1068828381U,
            1219638859U,
            3624741850U,
            2936675148U,
            906185462U,
            1090812512U,
            3747672003U,
            2825379669U,
            829329135U,
            1181335161U,
            3412177804U,
            3160834842U,
            628085408U,
            1382605366U,
            3423369109U,
            3138078467U,
            570562233U,
            1426400815U,
            3317316542U,
            2998733608U,
            733239954U,
            1555261956U,
            3268935591U,
            3050360625U,
            752459403U,
            1541320221U,
            2607071920U,
            3965973030U,
            1969922972U,
            40735498U,
            2617837225U,
            3943577151U,
            1913087877U,
            83908371U,
            2512341634U,
            3803740692U,
            2075208622U,
            213261112U,
            2463272603U,
            3855990285U,
            2094854071U,
            198958881U,
            2262029012U,
            4057260610U,
            1759359992U,
            534414190U,
            2176718541U,
            4139329115U,
            1873836001U,
            414664567U,
            2282248934U,
            4279200368U,
            1711684554U,
            285281116U,
            2405801727U,
            4167216745U,
            1634467795U,
            376229701U,
            2685067896U,
            3608007406U,
            1308918612U,
            956543938U,
            2808555105U,
            3495958263U,
            1231636301U,
            1047427035U,
            2932959818U,
            3654703836U,
            1088359270U,
            936918000U,
            2847714899U,
            3736837829U,
            1202900863U,
            817233897U,
            3183342108U,
            3401237130U,
            1404277552U,
            615818150U,
            3134207493U,
            3453421203U,
            1423857449U,
            601450431U,
            3009837614U,
            3294710456U,
            1567103746U,
            711928724U,
            3020668471U,
            3272380065U,
            1510334235U,
            755167117U
        };
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000003 RID: 3
    internal class EncodingFoundException : Exception
    {
        // Token: 0x0600000A RID: 10 RVA: 0x00002167 File Offset: 0x00000367
        internal EncodingFoundException(Encoding encoding)
        {
            this._encoding = encoding;
        }

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x0600000B RID: 11 RVA: 0x00002176 File Offset: 0x00000376
        internal Encoding Encoding
        {
            get
            {
                return this._encoding;
            }
        }

        // Token: 0x04000003 RID: 3
        private Encoding _encoding;
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000011 RID: 17
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class HasXPathAttribute : Attribute
    {
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000004 RID: 4
    [DebuggerDisplay("Name: {OriginalName}, Value: {Value}")]
    public class HtmlAttribute : IComparable
    {
        // Token: 0x0600000C RID: 12 RVA: 0x0000217E File Offset: 0x0000037E
        internal HtmlAttribute(HtmlDocument ownerdocument)
        {
            this._ownerdocument = ownerdocument;
        }

        // Token: 0x17000003 RID: 3
        // (get) Token: 0x0600000D RID: 13 RVA: 0x00002194 File Offset: 0x00000394
        // (set) Token: 0x0600000E RID: 14 RVA: 0x0000219C File Offset: 0x0000039C
        public int Line
        {
            get
            {
                return this._line;
            }
            internal set
            {
                this._line = value;
            }
        }

        // Token: 0x17000004 RID: 4
        // (get) Token: 0x0600000F RID: 15 RVA: 0x000021A5 File Offset: 0x000003A5
        public int LinePosition
        {
            get
            {
                return this._lineposition;
            }
        }

        // Token: 0x17000005 RID: 5
        // (get) Token: 0x06000010 RID: 16 RVA: 0x000021AD File Offset: 0x000003AD
        public int ValueStartIndex
        {
            get
            {
                return this._valuestartindex;
            }
        }

        // Token: 0x17000006 RID: 6
        // (get) Token: 0x06000011 RID: 17 RVA: 0x000021B5 File Offset: 0x000003B5
        public int ValueLength
        {
            get
            {
                return this._valuelength;
            }
        }

        // Token: 0x17000007 RID: 7
        // (get) Token: 0x06000012 RID: 18 RVA: 0x000021C0 File Offset: 0x000003C0
        // (set) Token: 0x06000013 RID: 19 RVA: 0x000021FF File Offset: 0x000003FF
        public bool UseOriginalName
        {
            get
            {
                bool result = false;
                if (this._localUseOriginalName != null)
                {
                    result = this._localUseOriginalName.Value;
                }
                else if (this.OwnerDocument != null)
                {
                    result = this.OwnerDocument.OptionDefaultUseOriginalName;
                }
                return result;
            }
            set
            {
                this._localUseOriginalName = new bool?(value);
            }
        }

        // Token: 0x17000008 RID: 8
        // (get) Token: 0x06000014 RID: 20 RVA: 0x00002210 File Offset: 0x00000410
        // (set) Token: 0x06000015 RID: 21 RVA: 0x00002261 File Offset: 0x00000461
        public string Name
        {
            get
            {
                if (this._name == null)
                {
                    this._name = this._ownerdocument.Text.Substring(this._namestartindex, this._namelength);
                }
                if (!this.UseOriginalName)
                {
                    return this._name.ToLowerInvariant();
                }
                return this._name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                this._name = value;
                if (this._ownernode != null)
                {
                    this._ownernode.SetChanged();
                }
            }
        }

        // Token: 0x17000009 RID: 9
        // (get) Token: 0x06000016 RID: 22 RVA: 0x0000228B File Offset: 0x0000048B
        public string OriginalName
        {
            get
            {
                return this._name;
            }
        }

        // Token: 0x1700000A RID: 10
        // (get) Token: 0x06000017 RID: 23 RVA: 0x00002293 File Offset: 0x00000493
        public HtmlDocument OwnerDocument
        {
            get
            {
                return this._ownerdocument;
            }
        }

        // Token: 0x1700000B RID: 11
        // (get) Token: 0x06000018 RID: 24 RVA: 0x0000229B File Offset: 0x0000049B
        public HtmlNode OwnerNode
        {
            get
            {
                return this._ownernode;
            }
        }

        // Token: 0x1700000C RID: 12
        // (get) Token: 0x06000019 RID: 25 RVA: 0x000022A3 File Offset: 0x000004A3
        // (set) Token: 0x0600001A RID: 26 RVA: 0x000022AB File Offset: 0x000004AB
        public AttributeValueQuote QuoteType
        {
            get
            {
                return this._quoteType;
            }
            set
            {
                this._quoteType = value;
            }
        }

        // Token: 0x1700000D RID: 13
        // (get) Token: 0x0600001B RID: 27 RVA: 0x000022B4 File Offset: 0x000004B4
        // (set) Token: 0x0600001C RID: 28 RVA: 0x000022BC File Offset: 0x000004BC
        internal AttributeValueQuote InternalQuoteType { get; set; }

        // Token: 0x1700000E RID: 14
        // (get) Token: 0x0600001D RID: 29 RVA: 0x000022C5 File Offset: 0x000004C5
        public int StreamPosition
        {
            get
            {
                return this._streamposition;
            }
        }

        // Token: 0x1700000F RID: 15
        // (get) Token: 0x0600001E RID: 30 RVA: 0x000022D0 File Offset: 0x000004D0
        // (set) Token: 0x0600001F RID: 31 RVA: 0x00002352 File Offset: 0x00000552
        public string Value
        {
            get
            {
                if (this._value == null && this._ownerdocument.Text == null && this._valuestartindex == 0 && this._valuelength == 0)
                {
                    return null;
                }
                if (this._value == null)
                {
                    this._value = this._ownerdocument.Text.Substring(this._valuestartindex, this._valuelength);
                    if (!this._ownerdocument.BackwardCompatibility)
                    {
                        this._value = HtmlEntity.DeEntitize(this._value);
                    }
                }
                return this._value;
            }
            set
            {
                this._value = value;
                if (this._ownernode != null)
                {
                    this._ownernode.SetChanged();
                }
            }
        }

        // Token: 0x17000010 RID: 16
        // (get) Token: 0x06000020 RID: 32 RVA: 0x0000236E File Offset: 0x0000056E
        public string DeEntitizeValue
        {
            get
            {
                return HtmlEntity.DeEntitize(this.Value);
            }
        }

        // Token: 0x17000011 RID: 17
        // (get) Token: 0x06000021 RID: 33 RVA: 0x0000237B File Offset: 0x0000057B
        internal string XmlName
        {
            get
            {
                return HtmlDocument.GetXmlName(this.Name, true, this.OwnerDocument.OptionPreserveXmlNamespaces);
            }
        }

        // Token: 0x17000012 RID: 18
        // (get) Token: 0x06000022 RID: 34 RVA: 0x00002394 File Offset: 0x00000594
        internal string XmlValue
        {
            get
            {
                return this.Value;
            }
        }

        // Token: 0x17000013 RID: 19
        // (get) Token: 0x06000023 RID: 35 RVA: 0x0000239C File Offset: 0x0000059C
        public string XPath
        {
            get
            {
                return ((this.OwnerNode == null) ? "/" : (this.OwnerNode.XPath + "/")) + this.GetRelativeXpath();
            }
        }

        // Token: 0x06000024 RID: 36 RVA: 0x000023D0 File Offset: 0x000005D0
        public int CompareTo(object obj)
        {
            HtmlAttribute htmlAttribute = obj as HtmlAttribute;
            if (htmlAttribute == null)
            {
                throw new ArgumentException("obj");
            }
            return this.Name.CompareTo(htmlAttribute.Name);
        }

        // Token: 0x06000025 RID: 37 RVA: 0x00002404 File Offset: 0x00000604
        public HtmlAttribute Clone()
        {
            return new HtmlAttribute(this._ownerdocument)
            {
                Name = this.OriginalName,
                Value = this.Value,
                QuoteType = this.QuoteType,
                InternalQuoteType = this.InternalQuoteType,
                _isFromParse = this._isFromParse,
                _hasEqual = this._hasEqual
            };
        }

        // Token: 0x06000026 RID: 38 RVA: 0x00002464 File Offset: 0x00000664
        public void Remove()
        {
            this._ownernode.Attributes.Remove(this);
        }

        // Token: 0x06000027 RID: 39 RVA: 0x00002478 File Offset: 0x00000678
        private string GetRelativeXpath()
        {
            if (this.OwnerNode == null)
            {
                return this.Name;
            }
            int num = 1;
            foreach (HtmlAttribute htmlAttribute in ((IEnumerable<HtmlAttribute>)this.OwnerNode.Attributes))
            {
                if (!(htmlAttribute.Name != this.Name))
                {
                    if (htmlAttribute == this)
                    {
                        break;
                    }
                    num++;
                }
            }
            return string.Concat(new string[]
            {
                "@",
                this.Name,
                "[",
                num.ToString(),
                "]"
            });
        }

        // Token: 0x04000004 RID: 4
        private int _line;

        // Token: 0x04000005 RID: 5
        internal int _lineposition;

        // Token: 0x04000006 RID: 6
        internal string _name;

        // Token: 0x04000007 RID: 7
        internal int _namelength;

        // Token: 0x04000008 RID: 8
        internal int _namestartindex;

        // Token: 0x04000009 RID: 9
        internal HtmlDocument _ownerdocument;

        // Token: 0x0400000A RID: 10
        internal HtmlNode _ownernode;

        // Token: 0x0400000B RID: 11
        private AttributeValueQuote _quoteType = AttributeValueQuote.DoubleQuote;

        // Token: 0x0400000C RID: 12
        internal int _streamposition;

        // Token: 0x0400000D RID: 13
        internal string _value;

        // Token: 0x0400000E RID: 14
        internal int _valuelength;

        // Token: 0x0400000F RID: 15
        internal int _valuestartindex;

        // Token: 0x04000010 RID: 16
        internal bool _isFromParse;

        // Token: 0x04000011 RID: 17
        internal bool _hasEqual;

        // Token: 0x04000012 RID: 18
        private bool? _localUseOriginalName;
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000006 RID: 6
    public class HtmlAttributeCollection : IList<HtmlAttribute>, ICollection<HtmlAttribute>, IEnumerable<HtmlAttribute>, IEnumerable
    {
        // Token: 0x06000028 RID: 40 RVA: 0x00002528 File Offset: 0x00000728
        internal HtmlAttributeCollection(HtmlNode ownernode)
        {
            this._ownernode = ownernode;
        }

        // Token: 0x17000014 RID: 20
        // (get) Token: 0x06000029 RID: 41 RVA: 0x00002552 File Offset: 0x00000752
        public int Count
        {
            get
            {
                return this.items.Count;
            }
        }

        // Token: 0x17000015 RID: 21
        // (get) Token: 0x0600002A RID: 42 RVA: 0x0000255F File Offset: 0x0000075F
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        // Token: 0x17000016 RID: 22
        public HtmlAttribute this[int index]
        {
            get
            {
                return this.items[index];
            }
            set
            {
                HtmlAttribute htmlAttribute = this.items[index];
                this.items[index] = value;
                if (htmlAttribute.Name != value.Name)
                {
                    this.Hashitems.Remove(htmlAttribute.Name);
                }
                this.Hashitems[value.Name] = value;
                value._ownernode = this._ownernode;
                this._ownernode.SetChanged();
            }
        }

        // Token: 0x17000017 RID: 23
        public HtmlAttribute this[string name]
        {
            get
            {
                if (name == null)
                {
                    throw new ArgumentNullException("name");
                }
                HtmlAttribute result;
                if (!this.Hashitems.TryGetValue(name, out result))
                {
                    return null;
                }
                return result;
            }
            set
            {
                HtmlAttribute item;
                if (!this.Hashitems.TryGetValue(name, out item))
                {
                    this.Append(value);
                    return;
                }
                this[this.items.IndexOf(item)] = value;
            }
        }

        // Token: 0x0600002F RID: 47 RVA: 0x00002651 File Offset: 0x00000851
        public void Add(string name, string value)
        {
            this.Append(name, value);
        }

        // Token: 0x06000030 RID: 48 RVA: 0x0000265C File Offset: 0x0000085C
        public void Add(HtmlAttribute item)
        {
            this.Append(item);
        }

        // Token: 0x06000031 RID: 49 RVA: 0x00002668 File Offset: 0x00000868
        public void AddRange(IEnumerable<HtmlAttribute> items)
        {
            foreach (HtmlAttribute newAttribute in items)
            {
                this.Append(newAttribute);
            }
        }

        // Token: 0x06000032 RID: 50 RVA: 0x000026B4 File Offset: 0x000008B4
        public void AddRange(Dictionary<string, string> items)
        {
            foreach (KeyValuePair<string, string> keyValuePair in items)
            {
                this.Add(keyValuePair.Key, keyValuePair.Value);
            }
        }

        // Token: 0x06000033 RID: 51 RVA: 0x00002710 File Offset: 0x00000910
        void ICollection<HtmlAttribute>.Clear()
        {
            this.Clear();
        }

        // Token: 0x06000034 RID: 52 RVA: 0x00002718 File Offset: 0x00000918
        public bool Contains(HtmlAttribute item)
        {
            return this.items.Contains(item);
        }

        // Token: 0x06000035 RID: 53 RVA: 0x00002726 File Offset: 0x00000926
        public void CopyTo(HtmlAttribute[] array, int arrayIndex)
        {
            this.items.CopyTo(array, arrayIndex);
        }

        // Token: 0x06000036 RID: 54 RVA: 0x00002735 File Offset: 0x00000935
        IEnumerator<HtmlAttribute> IEnumerable<HtmlAttribute>.GetEnumerator()
        {
            return this.items.GetEnumerator();
        }

        // Token: 0x06000037 RID: 55 RVA: 0x00002747 File Offset: 0x00000947
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.items.GetEnumerator();
        }

        // Token: 0x06000038 RID: 56 RVA: 0x00002759 File Offset: 0x00000959
        public int IndexOf(HtmlAttribute item)
        {
            return this.items.IndexOf(item);
        }

        // Token: 0x06000039 RID: 57 RVA: 0x00002768 File Offset: 0x00000968
        public void Insert(int index, HtmlAttribute item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            this.Hashitems[item.Name] = item;
            item._ownernode = this._ownernode;
            this.items.Insert(index, item);
            this._ownernode.SetChanged();
        }

        // Token: 0x0600003A RID: 58 RVA: 0x000027BC File Offset: 0x000009BC
        bool ICollection<HtmlAttribute>.Remove(HtmlAttribute item)
        {
            if (item == null)
            {
                return false;
            }
            int attributeIndex = this.GetAttributeIndex(item);
            if (attributeIndex == -1)
            {
                return false;
            }
            this.RemoveAt(attributeIndex);
            return true;
        }

        // Token: 0x0600003B RID: 59 RVA: 0x000027E4 File Offset: 0x000009E4
        public void RemoveAt(int index)
        {
            HtmlAttribute htmlAttribute = this.items[index];
            this.Hashitems.Remove(htmlAttribute.Name);
            this.items.RemoveAt(index);
            this._ownernode.SetChanged();
        }

        // Token: 0x0600003C RID: 60 RVA: 0x00002828 File Offset: 0x00000A28
        public HtmlAttribute Append(HtmlAttribute newAttribute)
        {
            if (this._ownernode.NodeType == HtmlNodeType.Text || this._ownernode.NodeType == HtmlNodeType.Comment)
            {
                throw new Exception("A Text or Comment node cannot have attributes.");
            }
            if (newAttribute == null)
            {
                throw new ArgumentNullException("newAttribute");
            }
            this.Hashitems[newAttribute.Name] = newAttribute;
            newAttribute._ownernode = this._ownernode;
            this.items.Add(newAttribute);
            this._ownernode.SetChanged();
            return newAttribute;
        }

        // Token: 0x0600003D RID: 61 RVA: 0x000028A0 File Offset: 0x00000AA0
        public HtmlAttribute Append(string name)
        {
            HtmlAttribute newAttribute = this._ownernode._ownerdocument.CreateAttribute(name);
            return this.Append(newAttribute);
        }

        // Token: 0x0600003E RID: 62 RVA: 0x000028C8 File Offset: 0x00000AC8
        public HtmlAttribute Append(string name, string value)
        {
            HtmlAttribute newAttribute = this._ownernode._ownerdocument.CreateAttribute(name, value);
            return this.Append(newAttribute);
        }

        // Token: 0x0600003F RID: 63 RVA: 0x000028F0 File Offset: 0x00000AF0
        public bool Contains(string name)
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (string.Equals(this.items[i].Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        // Token: 0x06000040 RID: 64 RVA: 0x00002930 File Offset: 0x00000B30
        public HtmlAttribute Prepend(HtmlAttribute newAttribute)
        {
            this.Insert(0, newAttribute);
            return newAttribute;
        }

        // Token: 0x06000041 RID: 65 RVA: 0x0000293C File Offset: 0x00000B3C
        public void Remove(HtmlAttribute attribute)
        {
            if (attribute == null)
            {
                throw new ArgumentNullException("attribute");
            }
            int attributeIndex = this.GetAttributeIndex(attribute);
            if (attributeIndex == -1)
            {
                throw new IndexOutOfRangeException();
            }
            this.RemoveAt(attributeIndex);
        }

        // Token: 0x06000042 RID: 66 RVA: 0x00002970 File Offset: 0x00000B70
        public void Remove(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            for (int i = this.items.Count - 1; i >= 0; i--)
            {
                if (string.Equals(this.items[i].Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    this.RemoveAt(i);
                }
            }
        }

        // Token: 0x06000043 RID: 67 RVA: 0x000029C4 File Offset: 0x00000BC4
        public void RemoveAll()
        {
            this.Hashitems.Clear();
            this.items.Clear();
            this._ownernode.SetChanged();
        }

        // Token: 0x06000044 RID: 68 RVA: 0x000029E7 File Offset: 0x00000BE7
        public IEnumerable<HtmlAttribute> AttributesWithName(string attributeName)
        {
            int num;
            for (int i = 0; i < this.items.Count; i = num + 1)
            {
                if (string.Equals(this.items[i].Name, attributeName, StringComparison.OrdinalIgnoreCase))
                {
                    yield return this.items[i];
                }
                num = i;
            }
            yield break;
        }

        // Token: 0x06000045 RID: 69 RVA: 0x000029FE File Offset: 0x00000BFE
        public void Remove()
        {
            this.items.Clear();
        }

        // Token: 0x06000046 RID: 70 RVA: 0x00002A0B File Offset: 0x00000C0B
        internal void Clear()
        {
            this.Hashitems.Clear();
            this.items.Clear();
        }

        // Token: 0x06000047 RID: 71 RVA: 0x00002A24 File Offset: 0x00000C24
        internal int GetAttributeIndex(HtmlAttribute attribute)
        {
            if (attribute == null)
            {
                throw new ArgumentNullException("attribute");
            }
            for (int i = 0; i < this.items.Count; i++)
            {
                if (this.items[i] == attribute)
                {
                    return i;
                }
            }
            return -1;
        }

        // Token: 0x06000048 RID: 72 RVA: 0x00002A68 File Offset: 0x00000C68
        internal int GetAttributeIndex(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            for (int i = 0; i < this.items.Count; i++)
            {
                if (string.Equals(this.items[i].Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }

        // Token: 0x0400001A RID: 26
        internal Dictionary<string, HtmlAttribute> Hashitems = new Dictionary<string, HtmlAttribute>(StringComparer.OrdinalIgnoreCase);

        // Token: 0x0400001B RID: 27
        private HtmlNode _ownernode;

        // Token: 0x0400001C RID: 28
        internal List<HtmlAttribute> items = new List<HtmlAttribute>();
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000007 RID: 7
    internal class HtmlCmdLine
    {
        // Token: 0x06000049 RID: 73 RVA: 0x00002AB6 File Offset: 0x00000CB6
        static HtmlCmdLine()
        {
            HtmlCmdLine.ParseArgs();
        }

        // Token: 0x0600004A RID: 74 RVA: 0x00002AC4 File Offset: 0x00000CC4
        internal static string GetOption(string name, string def)
        {
            string result = def;
            string[] commandLineArgs = Environment.GetCommandLineArgs();
            for (int i = 1; i < commandLineArgs.Length; i++)
            {
                HtmlCmdLine.GetStringArg(commandLineArgs[i], name, ref result);
            }
            return result;
        }

        // Token: 0x0600004B RID: 75 RVA: 0x00002AF4 File Offset: 0x00000CF4
        internal static string GetOption(int index, string def)
        {
            string result = def;
            string[] commandLineArgs = Environment.GetCommandLineArgs();
            int num = 0;
            for (int i = 1; i < commandLineArgs.Length; i++)
            {
                if (HtmlCmdLine.GetStringArg(commandLineArgs[i], ref result))
                {
                    if (index == num)
                    {
                        return result;
                    }
                    result = def;
                    num++;
                }
            }
            return result;
        }

        // Token: 0x0600004C RID: 76 RVA: 0x00002B34 File Offset: 0x00000D34
        internal static bool GetOption(string name, bool def)
        {
            bool result = def;
            string[] commandLineArgs = Environment.GetCommandLineArgs();
            for (int i = 1; i < commandLineArgs.Length; i++)
            {
                HtmlCmdLine.GetBoolArg(commandLineArgs[i], name, ref result);
            }
            return result;
        }

        // Token: 0x0600004D RID: 77 RVA: 0x00002B64 File Offset: 0x00000D64
        internal static int GetOption(string name, int def)
        {
            int result = def;
            string[] commandLineArgs = Environment.GetCommandLineArgs();
            for (int i = 1; i < commandLineArgs.Length; i++)
            {
                HtmlCmdLine.GetIntArg(commandLineArgs[i], name, ref result);
            }
            return result;
        }

        // Token: 0x0600004E RID: 78 RVA: 0x00002B94 File Offset: 0x00000D94
        private static void GetBoolArg(string Arg, string Name, ref bool ArgValue)
        {
            if (Arg.Length < Name.Length + 1)
            {
                return;
            }
            if ('/' != Arg[0] && '-' != Arg[0])
            {
                return;
            }
            if (Arg.Substring(1, Name.Length).ToLowerInvariant() == Name.ToLowerInvariant())
            {
                ArgValue = true;
            }
        }

        // Token: 0x0600004F RID: 79 RVA: 0x00002BEC File Offset: 0x00000DEC
        private static void GetIntArg(string Arg, string Name, ref int ArgValue)
        {
            if (Arg.Length < Name.Length + 3)
            {
                return;
            }
            if ('/' != Arg[0] && '-' != Arg[0])
            {
                return;
            }
            if (Arg.Substring(1, Name.Length).ToLowerInvariant() == Name.ToLowerInvariant())
            {
                try
                {
                    ArgValue = Convert.ToInt32(Arg.Substring(Name.Length + 2, Arg.Length - Name.Length - 2));
                }
                catch
                {
                }
            }
        }

        // Token: 0x06000050 RID: 80 RVA: 0x00002C7C File Offset: 0x00000E7C
        private static bool GetStringArg(string Arg, ref string ArgValue)
        {
            if ('/' == Arg[0] || '-' == Arg[0])
            {
                return false;
            }
            ArgValue = Arg;
            return true;
        }

        // Token: 0x06000051 RID: 81 RVA: 0x00002C9C File Offset: 0x00000E9C
        private static void GetStringArg(string Arg, string Name, ref string ArgValue)
        {
            if (Arg.Length < Name.Length + 3)
            {
                return;
            }
            if ('/' != Arg[0] && '-' != Arg[0])
            {
                return;
            }
            if (Arg.Substring(1, Name.Length).ToLowerInvariant() == Name.ToLowerInvariant())
            {
                ArgValue = Arg.Substring(Name.Length + 2, Arg.Length - Name.Length - 2);
            }
        }

        // Token: 0x06000052 RID: 82 RVA: 0x00002D10 File Offset: 0x00000F10
        private static void ParseArgs()
        {
            string[] commandLineArgs = Environment.GetCommandLineArgs();
            for (int i = 1; i < commandLineArgs.Length; i++)
            {
                HtmlCmdLine.GetBoolArg(commandLineArgs[i], "?", ref HtmlCmdLine.Help);
                HtmlCmdLine.GetBoolArg(commandLineArgs[i], "h", ref HtmlCmdLine.Help);
                HtmlCmdLine.GetBoolArg(commandLineArgs[i], "help", ref HtmlCmdLine.Help);
            }
        }

        // Token: 0x0400001D RID: 29
        internal static bool Help = false;
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000008 RID: 8
    public class HtmlCommentNode : HtmlNode
    {
        // Token: 0x06000054 RID: 84 RVA: 0x00002D6F File Offset: 0x00000F6F
        internal HtmlCommentNode(HtmlDocument ownerdocument, int index) : base(HtmlNodeType.Comment, ownerdocument, index)
        {
        }

        // Token: 0x17000018 RID: 24
        // (get) Token: 0x06000055 RID: 85 RVA: 0x00002D7A File Offset: 0x00000F7A
        // (set) Token: 0x06000056 RID: 86 RVA: 0x00002D91 File Offset: 0x00000F91
        public string Comment
        {
            get
            {
                if (this._comment == null)
                {
                    return base.InnerHtml;
                }
                return this._comment;
            }
            set
            {
                this._comment = value;
            }
        }

        // Token: 0x17000019 RID: 25
        // (get) Token: 0x06000057 RID: 87 RVA: 0x00002D9A File Offset: 0x00000F9A
        // (set) Token: 0x06000058 RID: 88 RVA: 0x00002DB1 File Offset: 0x00000FB1
        public override string InnerHtml
        {
            get
            {
                if (this._comment == null)
                {
                    return base.InnerHtml;
                }
                return this._comment;
            }
            set
            {
                this._comment = value;
            }
        }

        // Token: 0x1700001A RID: 26
        // (get) Token: 0x06000059 RID: 89 RVA: 0x00002DBA File Offset: 0x00000FBA
        public override string OuterHtml
        {
            get
            {
                if (this._comment == null)
                {
                    return base.OuterHtml;
                }
                return "<!--" + this._comment + "-->";
            }
        }

        // Token: 0x0400001E RID: 30
        private string _comment;
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000009 RID: 9
    internal class HtmlConsoleListener : TraceListener
    {
        // Token: 0x0600005A RID: 90 RVA: 0x00002DE0 File Offset: 0x00000FE0
        public override void Write(string Message)
        {
            this.Write(Message, "");
        }

        // Token: 0x0600005B RID: 91 RVA: 0x00002DEE File Offset: 0x00000FEE
        public override void Write(string Message, string Category)
        {
            Console.Write("T:" + Category + ": " + Message);
        }

        // Token: 0x0600005C RID: 92 RVA: 0x00002E06 File Offset: 0x00001006
        public override void WriteLine(string Message)
        {
            this.Write(Message + "\n");
        }

        // Token: 0x0600005D RID: 93 RVA: 0x00002E19 File Offset: 0x00001019
        public override void WriteLine(string Message, string Category)
        {
            this.Write(Message + "\n", Category);
        }
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x0200000A RID: 10
    public class HtmlDocument : IXPathNavigable
    {
        // Token: 0x1700001B RID: 27
        // (get) Token: 0x0600005F RID: 95 RVA: 0x00002E35 File Offset: 0x00001035
        // (set) Token: 0x06000060 RID: 96 RVA: 0x00002E3C File Offset: 0x0000103C
        public static bool DisableBehaviorTagP
        {
            get
            {
                return HtmlDocument._disableBehaviorTagP;
            }
            set
            {
                if (value)
                {
                    if (HtmlNode.ElementsFlags.ContainsKey("p"))
                    {
                        HtmlNode.ElementsFlags.Remove("p");
                    }
                }
                else if (!HtmlNode.ElementsFlags.ContainsKey("p"))
                {
                    HtmlNode.ElementsFlags.Add("p", HtmlElementFlag.Empty | HtmlElementFlag.Closed);
                }
                HtmlDocument._disableBehaviorTagP = value;
            }
        }

        // Token: 0x1700001C RID: 28
        // (get) Token: 0x06000061 RID: 97 RVA: 0x00002E96 File Offset: 0x00001096
        // (set) Token: 0x06000062 RID: 98 RVA: 0x00002E9D File Offset: 0x0000109D
        public static Action<HtmlDocument> DefaultBuilder { get; set; }

        // Token: 0x1700001D RID: 29
        // (get) Token: 0x06000063 RID: 99 RVA: 0x00002EA5 File Offset: 0x000010A5
        // (set) Token: 0x06000064 RID: 100 RVA: 0x00002EAD File Offset: 0x000010AD
        public Action<HtmlDocument> ParseExecuting { get; set; }

        // Token: 0x06000065 RID: 101 RVA: 0x00002EB8 File Offset: 0x000010B8
        public HtmlDocument()
        {
            if (HtmlDocument.DefaultBuilder != null)
            {
                HtmlDocument.DefaultBuilder(this);
            }
            this._documentnode = this.CreateNode(HtmlNodeType.Document, 0);
            this.OptionDefaultStreamEncoding = Encoding.Default;
        }

        // Token: 0x1700001E RID: 30
        // (get) Token: 0x06000066 RID: 102 RVA: 0x00002F30 File Offset: 0x00001130
        public string ParsedText
        {
            get
            {
                return this.Text;
            }
        }

        // Token: 0x1700001F RID: 31
        // (get) Token: 0x06000067 RID: 103 RVA: 0x00002F38 File Offset: 0x00001138
        // (set) Token: 0x06000068 RID: 104 RVA: 0x00002F3F File Offset: 0x0000113F
        public static int MaxDepthLevel
        {
            get
            {
                return HtmlDocument._maxDepthLevel;
            }
            set
            {
                HtmlDocument._maxDepthLevel = value;
            }
        }

        // Token: 0x17000020 RID: 32
        // (get) Token: 0x06000069 RID: 105 RVA: 0x00002F47 File Offset: 0x00001147
        public int CheckSum
        {
            get
            {
                if (this._crc32 != null)
                {
                    return (int)this._crc32.CheckSum;
                }
                return 0;
            }
        }

        // Token: 0x17000021 RID: 33
        // (get) Token: 0x0600006A RID: 106 RVA: 0x00002F5E File Offset: 0x0000115E
        public Encoding DeclaredEncoding
        {
            get
            {
                return this._declaredencoding;
            }
        }

        // Token: 0x17000022 RID: 34
        // (get) Token: 0x0600006B RID: 107 RVA: 0x00002F66 File Offset: 0x00001166
        public HtmlNode DocumentNode
        {
            get
            {
                return this._documentnode;
            }
        }

        // Token: 0x17000023 RID: 35
        // (get) Token: 0x0600006C RID: 108 RVA: 0x00002F6E File Offset: 0x0000116E
        public Encoding Encoding
        {
            get
            {
                return this.GetOutEncoding();
            }
        }

        // Token: 0x17000024 RID: 36
        // (get) Token: 0x0600006D RID: 109 RVA: 0x00002F76 File Offset: 0x00001176
        public IEnumerable<HtmlParseError> ParseErrors
        {
            get
            {
                return this._parseerrors;
            }
        }

        // Token: 0x17000025 RID: 37
        // (get) Token: 0x0600006E RID: 110 RVA: 0x00002F7E File Offset: 0x0000117E
        public string Remainder
        {
            get
            {
                return this._remainder;
            }
        }

        // Token: 0x17000026 RID: 38
        // (get) Token: 0x0600006F RID: 111 RVA: 0x00002F86 File Offset: 0x00001186
        public int RemainderOffset
        {
            get
            {
                return this._remainderOffset;
            }
        }

        // Token: 0x17000027 RID: 39
        // (get) Token: 0x06000070 RID: 112 RVA: 0x00002F8E File Offset: 0x0000118E
        public Encoding StreamEncoding
        {
            get
            {
                return this._streamencoding;
            }
        }

        // Token: 0x06000071 RID: 113 RVA: 0x00002F96 File Offset: 0x00001196
        public static string GetXmlName(string name)
        {
            return HtmlDocument.GetXmlName(name, false, false);
        }

        // Token: 0x06000072 RID: 114 RVA: 0x00002FA0 File Offset: 0x000011A0
        public void UseAttributeOriginalName(string tagName)
        {
            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.DocumentNode.SelectNodes("//" + tagName)))
            {
                foreach (HtmlAttribute htmlAttribute in ((IEnumerable<HtmlAttribute>)htmlNode.Attributes))
                {
                    htmlAttribute.UseOriginalName = true;
                }
            }
        }

        // Token: 0x06000073 RID: 115 RVA: 0x00003030 File Offset: 0x00001230
        public static string GetXmlName(string name, bool isAttribute, bool preserveXmlNamespaces)
        {
            string text = string.Empty;
            bool flag = true;
            for (int i = 0; i < name.Length; i++)
            {
                if ((name[i] >= 'a' && name[i] <= 'z') || (name[i] >= 'A' && name[i] <= 'Z') || (name[i] >= '0' && name[i] <= '9') || ((isAttribute || preserveXmlNamespaces) && name[i] == ':') || name[i] == '_' || name[i] == '-' || name[i] == '.')
                {
                    text += name[i].ToString();
                }
                else
                {
                    flag = false;
                    byte[] bytes = Encoding.UTF8.GetBytes(new char[]
                    {
                        name[i]
                    });
                    for (int j = 0; j < bytes.Length; j++)
                    {
                        text += bytes[j].ToString("x2");
                    }
                    text += "_";
                }
            }
            if (flag)
            {
                return text;
            }
            return "_" + text;
        }

        // Token: 0x06000074 RID: 116 RVA: 0x0000314E File Offset: 0x0000134E
        public static string HtmlEncode(string html)
        {
            return HtmlDocument.HtmlEncodeWithCompatibility(html, true);
        }

        // Token: 0x06000075 RID: 117 RVA: 0x00003158 File Offset: 0x00001358
        internal static string HtmlEncodeWithCompatibility(string html, bool backwardCompatibility = true)
        {
            if (html == null)
            {
                throw new ArgumentNullException("html");
            }
            return (backwardCompatibility ? new Regex("&(?!(amp;)|(lt;)|(gt;)|(quot;))", RegexOptions.IgnoreCase) : new Regex("&(?!(amp;)|(lt;)|(gt;)|(quot;)|(nbsp;)|(reg;))", RegexOptions.IgnoreCase)).Replace(html, "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;");
        }

        // Token: 0x06000076 RID: 118 RVA: 0x000031C6 File Offset: 0x000013C6
        public static bool IsWhiteSpace(int c)
        {
            return c == 10 || c == 13 || c == 32 || c == 9;
        }

        // Token: 0x06000077 RID: 119 RVA: 0x000031DF File Offset: 0x000013DF
        public HtmlAttribute CreateAttribute(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            HtmlAttribute htmlAttribute = this.CreateAttribute();
            htmlAttribute.Name = name;
            return htmlAttribute;
        }

        // Token: 0x06000078 RID: 120 RVA: 0x000031FC File Offset: 0x000013FC
        public HtmlAttribute CreateAttribute(string name, string value)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            HtmlAttribute htmlAttribute = this.CreateAttribute(name);
            htmlAttribute.Value = value;
            return htmlAttribute;
        }

        // Token: 0x06000079 RID: 121 RVA: 0x0000321A File Offset: 0x0000141A
        public HtmlCommentNode CreateComment()
        {
            return (HtmlCommentNode)this.CreateNode(HtmlNodeType.Comment);
        }

        // Token: 0x0600007A RID: 122 RVA: 0x00003228 File Offset: 0x00001428
        public HtmlCommentNode CreateComment(string comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException("comment");
            }
            HtmlCommentNode htmlCommentNode = this.CreateComment();
            htmlCommentNode.Comment = comment;
            return htmlCommentNode;
        }

        // Token: 0x0600007B RID: 123 RVA: 0x00003245 File Offset: 0x00001445
        public HtmlNode CreateElement(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            HtmlNode htmlNode = this.CreateNode(HtmlNodeType.Element);
            htmlNode.SetName(name);
            return htmlNode;
        }

        // Token: 0x0600007C RID: 124 RVA: 0x00003263 File Offset: 0x00001463
        public HtmlTextNode CreateTextNode()
        {
            return (HtmlTextNode)this.CreateNode(HtmlNodeType.Text);
        }

        // Token: 0x0600007D RID: 125 RVA: 0x00003271 File Offset: 0x00001471
        public HtmlTextNode CreateTextNode(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }
            HtmlTextNode htmlTextNode = this.CreateTextNode();
            htmlTextNode.Text = text;
            return htmlTextNode;
        }

        // Token: 0x0600007E RID: 126 RVA: 0x0000328E File Offset: 0x0000148E
        public Encoding DetectEncoding(Stream stream)
        {
            return this.DetectEncoding(stream, false);
        }

        // Token: 0x0600007F RID: 127 RVA: 0x00003298 File Offset: 0x00001498
        public Encoding DetectEncoding(Stream stream, bool checkHtml)
        {
            this._useHtmlEncodingForStream = checkHtml;
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            return this.DetectEncoding(new StreamReader(stream));
        }

        // Token: 0x06000080 RID: 128 RVA: 0x000032BC File Offset: 0x000014BC
        public Encoding DetectEncoding(TextReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }
            this._onlyDetectEncoding = true;
            if (this.OptionCheckSyntax)
            {
                this.Openednodes = new Dictionary<int, HtmlNode>();
            }
            else
            {
                this.Openednodes = null;
            }
            if (this.OptionUseIdAttribute)
            {
                this.Nodesid = new Dictionary<string, HtmlNode>(StringComparer.OrdinalIgnoreCase);
            }
            else
            {
                this.Nodesid = null;
            }
            StreamReader streamReader = reader as StreamReader;
            if (streamReader != null && !this._useHtmlEncodingForStream)
            {
                this.Text = streamReader.ReadToEnd();
                this._streamencoding = streamReader.CurrentEncoding;
                return this._streamencoding;
            }
            this._streamencoding = null;
            this._declaredencoding = null;
            this.Text = reader.ReadToEnd();
            this._documentnode = this.CreateNode(HtmlNodeType.Document, 0);
            try
            {
                this.Parse();
            }
            catch (EncodingFoundException ex)
            {
                return ex.Encoding;
            }
            return this._streamencoding;
        }

        // Token: 0x06000081 RID: 129 RVA: 0x0000339C File Offset: 0x0000159C
        public Encoding DetectEncodingHtml(string html)
        {
            if (html == null)
            {
                throw new ArgumentNullException("html");
            }
            Encoding result;
            using (StringReader stringReader = new StringReader(html))
            {
                result = this.DetectEncoding(stringReader);
            }
            return result;
        }

        // Token: 0x06000082 RID: 130 RVA: 0x000033E4 File Offset: 0x000015E4
        public HtmlNode GetElementbyId(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            if (this.Nodesid == null)
            {
                throw new Exception(HtmlDocument.HtmlExceptionUseIdAttributeFalse);
            }
            if (!this.Nodesid.ContainsKey(id))
            {
                return null;
            }
            return this.Nodesid[id];
        }

        // Token: 0x06000083 RID: 131 RVA: 0x00003423 File Offset: 0x00001623
        public void Load(Stream stream)
        {
            this.Load(new StreamReader(stream, this.OptionDefaultStreamEncoding));
        }

        // Token: 0x06000084 RID: 132 RVA: 0x00003437 File Offset: 0x00001637
        public void Load(Stream stream, bool detectEncodingFromByteOrderMarks)
        {
            this.Load(new StreamReader(stream, detectEncodingFromByteOrderMarks));
        }

        // Token: 0x06000085 RID: 133 RVA: 0x00003446 File Offset: 0x00001646
        public void Load(Stream stream, Encoding encoding)
        {
            this.Load(new StreamReader(stream, encoding));
        }

        // Token: 0x06000086 RID: 134 RVA: 0x00003455 File Offset: 0x00001655
        public void Load(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
        {
            this.Load(new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks));
        }

        // Token: 0x06000087 RID: 135 RVA: 0x00003465 File Offset: 0x00001665
        public void Load(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
        {
            this.Load(new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, buffersize));
        }

        // Token: 0x06000088 RID: 136 RVA: 0x00003478 File Offset: 0x00001678
        public void Load(TextReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }
            this._onlyDetectEncoding = false;
            if (this.OptionCheckSyntax)
            {
                this.Openednodes = new Dictionary<int, HtmlNode>();
            }
            else
            {
                this.Openednodes = null;
            }
            if (this.OptionUseIdAttribute)
            {
                this.Nodesid = new Dictionary<string, HtmlNode>(StringComparer.OrdinalIgnoreCase);
            }
            else
            {
                this.Nodesid = null;
            }
            StreamReader streamReader = reader as StreamReader;
            if (streamReader != null)
            {
                try
                {
                    streamReader.Peek();
                }
                catch (Exception)
                {
                }
                this._streamencoding = streamReader.CurrentEncoding;
            }
            else
            {
                this._streamencoding = null;
            }
            this._declaredencoding = null;
            this.Text = reader.ReadToEnd();
            this._documentnode = this.CreateNode(HtmlNodeType.Document, 0);
            this.Parse();
            if (!this.OptionCheckSyntax || this.Openednodes == null)
            {
                return;
            }
            foreach (HtmlNode htmlNode in this.Openednodes.Values)
            {
                if (htmlNode._starttag)
                {
                    string text;
                    if (this.OptionExtractErrorSourceText)
                    {
                        text = htmlNode.OuterHtml;
                        if (text.Length > this.OptionExtractErrorSourceTextMaxLength)
                        {
                            text = text.Substring(0, this.OptionExtractErrorSourceTextMaxLength);
                        }
                    }
                    else
                    {
                        text = string.Empty;
                    }
                    this.AddError(HtmlParseErrorCode.TagNotClosed, htmlNode._line, htmlNode._lineposition, htmlNode._streamposition, text, "End tag </" + htmlNode.Name + "> was not found");
                }
            }
            this.Openednodes.Clear();
        }

        // Token: 0x06000089 RID: 137 RVA: 0x00003600 File Offset: 0x00001800
        public void LoadHtml(string html)
        {
            if (html == null)
            {
                throw new ArgumentNullException("html");
            }
            using (StringReader stringReader = new StringReader(html))
            {
                this.Load(stringReader);
            }
        }

        // Token: 0x0600008A RID: 138 RVA: 0x00003648 File Offset: 0x00001848
        public void Save(Stream outStream)
        {
            StreamWriter writer = new StreamWriter(outStream, this.GetOutEncoding());
            this.Save(writer);
        }

        // Token: 0x0600008B RID: 139 RVA: 0x0000366C File Offset: 0x0000186C
        public void Save(Stream outStream, Encoding encoding)
        {
            if (outStream == null)
            {
                throw new ArgumentNullException("outStream");
            }
            if (encoding == null)
            {
                throw new ArgumentNullException("encoding");
            }
            StreamWriter writer = new StreamWriter(outStream, encoding);
            this.Save(writer);
        }

        // Token: 0x0600008C RID: 140 RVA: 0x000036A4 File Offset: 0x000018A4
        public void Save(StreamWriter writer)
        {
            this.Save(writer);
        }

        // Token: 0x0600008D RID: 141 RVA: 0x000036AD File Offset: 0x000018AD
        public void Save(TextWriter writer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            this.DocumentNode.WriteTo(writer, 0);
            writer.Flush();
        }

        // Token: 0x0600008E RID: 142 RVA: 0x000036D0 File Offset: 0x000018D0
        public void Save(XmlWriter writer)
        {
            this.DocumentNode.WriteTo(writer);
            writer.Flush();
        }

        // Token: 0x0600008F RID: 143 RVA: 0x000036E4 File Offset: 0x000018E4
        internal HtmlAttribute CreateAttribute()
        {
            return new HtmlAttribute(this);
        }

        // Token: 0x06000090 RID: 144 RVA: 0x000036EC File Offset: 0x000018EC
        internal HtmlNode CreateNode(HtmlNodeType type)
        {
            return this.CreateNode(type, -1);
        }

        // Token: 0x06000091 RID: 145 RVA: 0x000036F6 File Offset: 0x000018F6
        internal HtmlNode CreateNode(HtmlNodeType type, int index)
        {
            if (type == HtmlNodeType.Comment)
            {
                return new HtmlCommentNode(this, index);
            }
            if (type != HtmlNodeType.Text)
            {
                return new HtmlNode(type, this, index);
            }
            return new HtmlTextNode(this, index);
        }

        // Token: 0x06000092 RID: 146 RVA: 0x0000371A File Offset: 0x0000191A
        internal Encoding GetOutEncoding()
        {
            Encoding result;
            if ((result = this._declaredencoding) == null)
            {
                result = (this._streamencoding ?? this.OptionDefaultStreamEncoding);
            }
            return result;
        }

        // Token: 0x06000093 RID: 147 RVA: 0x00003738 File Offset: 0x00001938
        internal HtmlNode GetXmlDeclaration()
        {
            if (!this._documentnode.HasChildNodes)
            {
                return null;
            }
            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this._documentnode._childnodes))
            {
                if (htmlNode.Name == "?xml")
                {
                    return htmlNode;
                }
            }
            return null;
        }

        // Token: 0x06000094 RID: 148 RVA: 0x000037AC File Offset: 0x000019AC
        internal void SetIdForNode(HtmlNode node, string id)
        {
            if (!this.OptionUseIdAttribute)
            {
                return;
            }
            if (this.Nodesid == null || id == null)
            {
                return;
            }
            if (node == null)
            {
                this.Nodesid.Remove(id);
                return;
            }
            this.Nodesid[id] = node;
        }

        // Token: 0x06000095 RID: 149 RVA: 0x000037E4 File Offset: 0x000019E4
        internal void UpdateLastParentNode()
        {
            do
            {
                if (this._lastparentnode.Closed)
                {
                    this._lastparentnode = this._lastparentnode.ParentNode;
                }
            }
            while (this._lastparentnode != null && this._lastparentnode.Closed);
            if (this._lastparentnode == null)
            {
                this._lastparentnode = this._documentnode;
            }
        }

        // Token: 0x06000096 RID: 150 RVA: 0x00003838 File Offset: 0x00001A38
        private void AddError(HtmlParseErrorCode code, int line, int linePosition, int streamPosition, string sourceText, string reason)
        {
            HtmlParseError item = new HtmlParseError(code, line, linePosition, streamPosition, sourceText, reason);
            this._parseerrors.Add(item);
        }

        // Token: 0x06000097 RID: 151 RVA: 0x00003860 File Offset: 0x00001A60
        private void CloseCurrentNode()
        {
            if (this._currentnode.Closed)
            {
                return;
            }
            bool flag = false;
            HtmlNode dictionaryValueOrDefault = Utilities.GetDictionaryValueOrDefault<string, HtmlNode>(this.Lastnodes, this._currentnode.Name, null);
            if (dictionaryValueOrDefault == null)
            {
                if (HtmlNode.IsClosedElement(this._currentnode.Name))
                {
                    this._currentnode.CloseNode(this._currentnode, 0);
                    if (this._lastparentnode != null)
                    {
                        HtmlNode htmlNode = null;
                        Stack<HtmlNode> stack = new Stack<HtmlNode>();
                        if (!this._currentnode.Name.Equals("br"))
                        {
                            for (HtmlNode htmlNode2 = this._lastparentnode.LastChild; htmlNode2 != null; htmlNode2 = htmlNode2.PreviousSibling)
                            {
                                if (htmlNode2.Name == this._currentnode.Name && !htmlNode2.HasChildNodes)
                                {
                                    htmlNode = htmlNode2;
                                    break;
                                }
                                stack.Push(htmlNode2);
                            }
                        }
                        if (htmlNode != null)
                        {
                            while (stack.Count != 0)
                            {
                                HtmlNode htmlNode3 = stack.Pop();
                                this._lastparentnode.RemoveChild(htmlNode3);
                                htmlNode.AppendChild(htmlNode3);
                            }
                        }
                        else
                        {
                            this._lastparentnode.AppendChild(this._currentnode);
                        }
                    }
                }
                else if (HtmlNode.CanOverlapElement(this._currentnode.Name))
                {
                    HtmlNode htmlNode4 = this.CreateNode(HtmlNodeType.Text, this._currentnode._outerstartindex);
                    htmlNode4._outerlength = this._currentnode._outerlength;
                    ((HtmlTextNode)htmlNode4).Text = ((HtmlTextNode)htmlNode4).Text.ToLowerInvariant();
                    if (this._lastparentnode != null)
                    {
                        this._lastparentnode.AppendChild(htmlNode4);
                    }
                }
                else if (HtmlNode.IsEmptyElement(this._currentnode.Name))
                {
                    this.AddError(HtmlParseErrorCode.EndTagNotRequired, this._currentnode._line, this._currentnode._lineposition, this._currentnode._streamposition, this._currentnode.OuterHtml, "End tag </" + this._currentnode.Name + "> is not required");
                }
                else
                {
                    this.AddError(HtmlParseErrorCode.TagNotOpened, this._currentnode._line, this._currentnode._lineposition, this._currentnode._streamposition, this._currentnode.OuterHtml, "Start tag <" + this._currentnode.Name + "> was not found");
                    flag = true;
                }
            }
            else
            {
                if (this.OptionFixNestedTags && this.FindResetterNodes(dictionaryValueOrDefault, this.GetResetters(this._currentnode.Name)))
                {
                    this.AddError(HtmlParseErrorCode.EndTagInvalidHere, this._currentnode._line, this._currentnode._lineposition, this._currentnode._streamposition, this._currentnode.OuterHtml, "End tag </" + this._currentnode.Name + "> invalid here");
                    flag = true;
                }
                if (!flag)
                {
                    this.Lastnodes[this._currentnode.Name] = dictionaryValueOrDefault._prevwithsamename;
                    dictionaryValueOrDefault.CloseNode(this._currentnode, 0);
                }
            }
            if (!flag && this._lastparentnode != null && (!HtmlNode.IsClosedElement(this._currentnode.Name) || this._currentnode._starttag))
            {
                this.UpdateLastParentNode();
            }
        }

        // Token: 0x06000098 RID: 152 RVA: 0x00003B77 File Offset: 0x00001D77
        private string CurrentNodeName()
        {
            return this.Text.Substring(this._currentnode._namestartindex, this._currentnode._namelength);
        }

        // Token: 0x06000099 RID: 153 RVA: 0x00003B9C File Offset: 0x00001D9C
        private void DecrementPosition()
        {
            this._index--;
            if (this._lineposition == 0)
            {
                this._lineposition = this._maxlineposition;
                this._line--;
                return;
            }
            this._lineposition--;
        }

        // Token: 0x0600009A RID: 154 RVA: 0x00003BE8 File Offset: 0x00001DE8
        private HtmlNode FindResetterNode(HtmlNode node, string name)
        {
            HtmlNode dictionaryValueOrDefault = Utilities.GetDictionaryValueOrDefault<string, HtmlNode>(this.Lastnodes, name, null);
            if (dictionaryValueOrDefault == null)
            {
                return null;
            }
            if (dictionaryValueOrDefault.Closed)
            {
                return null;
            }
            if (dictionaryValueOrDefault._streamposition < node._streamposition)
            {
                return null;
            }
            return dictionaryValueOrDefault;
        }

        // Token: 0x0600009B RID: 155 RVA: 0x00003C24 File Offset: 0x00001E24
        private bool FindResetterNodes(HtmlNode node, string[] names)
        {
            if (names == null)
            {
                return false;
            }
            for (int i = 0; i < names.Length; i++)
            {
                if (this.FindResetterNode(node, names[i]) != null)
                {
                    return true;
                }
            }
            return false;
        }

        // Token: 0x0600009C RID: 156 RVA: 0x00003C54 File Offset: 0x00001E54
        private void FixNestedTag(string name, string[] resetters)
        {
            if (resetters == null)
            {
                return;
            }
            HtmlNode dictionaryValueOrDefault = Utilities.GetDictionaryValueOrDefault<string, HtmlNode>(this.Lastnodes, this._currentnode.Name, null);
            if (dictionaryValueOrDefault == null || this.Lastnodes[name].Closed)
            {
                return;
            }
            if (this.FindResetterNodes(dictionaryValueOrDefault, resetters))
            {
                return;
            }
            HtmlNode htmlNode = new HtmlNode(dictionaryValueOrDefault.NodeType, this, -1);
            htmlNode._endnode = htmlNode;
            dictionaryValueOrDefault.CloseNode(htmlNode, 0);
        }

        // Token: 0x0600009D RID: 157 RVA: 0x00003CBC File Offset: 0x00001EBC
        private void FixNestedTags()
        {
            if (!this._currentnode._starttag)
            {
                return;
            }
            string name = this.CurrentNodeName();
            this.FixNestedTag(name, this.GetResetters(name));
        }

        // Token: 0x0600009E RID: 158 RVA: 0x00003CEC File Offset: 0x00001EEC
        private string[] GetResetters(string name)
        {
            string[] result;
            if (!HtmlDocument.HtmlResetters.TryGetValue(name, out result))
            {
                return null;
            }
            return result;
        }

        // Token: 0x0600009F RID: 159 RVA: 0x00003D0C File Offset: 0x00001F0C
        private void IncrementPosition()
        {
            if (this._crc32 != null)
            {
                this._crc32.AddToCRC32(this._c);
            }
            this._index++;
            this._maxlineposition = this._lineposition;
            if (this._c == 10)
            {
                this._lineposition = 0;
                this._line++;
                return;
            }
            this._lineposition++;
        }

        // Token: 0x060000A0 RID: 160 RVA: 0x00003D7C File Offset: 0x00001F7C
        private bool IsValidTag()
        {
            return this._c == 60 && this._index < this.Text.Length && (char.IsLetter(this.Text[this._index]) || this.Text[this._index] == '/' || this.Text[this._index] == '?' || this.Text[this._index] == '!' || this.Text[this._index] == '%');
        }

        // Token: 0x060000A1 RID: 161 RVA: 0x00003E1C File Offset: 0x0000201C
        private bool NewCheck()
        {
            if (this._c != 60 || !this.IsValidTag())
            {
                return false;
            }
            if (this._index < this.Text.Length && this.Text[this._index] == '%')
            {
                if (this.DisableServerSideCode)
                {
                    return false;
                }
                HtmlDocument.ParseState state = this._state;
                if (state != HtmlDocument.ParseState.WhichTag)
                {
                    if (state != HtmlDocument.ParseState.BetweenAttributes)
                    {
                        if (state == HtmlDocument.ParseState.AttributeAfterEquals)
                        {
                            this.PushAttributeValueStart(this._index - 1);
                        }
                    }
                    else
                    {
                        this.PushAttributeNameStart(this._index - 1, this._lineposition - 1);
                    }
                }
                else
                {
                    this.PushNodeNameStart(true, this._index - 1);
                    this._state = HtmlDocument.ParseState.Tag;
                }
                this._oldstate = this._state;
                this._state = HtmlDocument.ParseState.ServerSideCode;
                return true;
            }
            else
            {
                if (!this.PushNodeEnd(this._index - 1, true))
                {
                    this._index = this.Text.Length;
                    return true;
                }
                this._state = HtmlDocument.ParseState.WhichTag;
                if (this._index - 1 <= this.Text.Length - 2 && (this.Text[this._index] == '!' || this.Text[this._index] == '?'))
                {
                    this.PushNodeStart(HtmlNodeType.Comment, this._index - 1, this._lineposition - 1);
                    this.PushNodeNameStart(true, this._index);
                    this.PushNodeNameEnd(this._index + 1);
                    this._state = HtmlDocument.ParseState.Comment;
                    if (this._index < this.Text.Length - 2)
                    {
                        if (this.Text[this._index + 1] == '-' && this.Text[this._index + 2] == '-')
                        {
                            this._fullcomment = true;
                        }
                        else
                        {
                            this._fullcomment = false;
                        }
                    }
                    return true;
                }
                this.PushNodeStart(HtmlNodeType.Element, this._index - 1, this._lineposition - 1);
                return true;
            }
        }

        // Token: 0x060000A2 RID: 162 RVA: 0x00003FF4 File Offset: 0x000021F4
        private void Parse()
        {
            if (this.ParseExecuting != null)
            {
                this.ParseExecuting(this);
            }
            int num = 0;
            if (this.OptionComputeChecksum)
            {
                this._crc32 = new Crc32();
            }
            this.Lastnodes = new Dictionary<string, HtmlNode>();
            this._c = 0;
            this._fullcomment = false;
            this._parseerrors = new List<HtmlParseError>();
            this._line = 1;
            this._lineposition = 0;
            this._maxlineposition = 0;
            this._state = HtmlDocument.ParseState.Text;
            this._oldstate = this._state;
            this._documentnode._innerlength = this.Text.Length;
            this._documentnode._outerlength = this.Text.Length;
            this._remainderOffset = this.Text.Length;
            this._lastparentnode = this._documentnode;
            this._currentnode = this.CreateNode(HtmlNodeType.Text, 0);
            this._currentattribute = null;
            this._index = 0;
            this.PushNodeStart(HtmlNodeType.Text, 0, this._lineposition);
            while (this._index < this.Text.Length)
            {
                this._c = (int)this.Text[this._index];
                this.IncrementPosition();
                switch (this._state)
                {
                    case HtmlDocument.ParseState.Text:
                        if (this.NewCheck())
                        {
                        }
                        break;
                    case HtmlDocument.ParseState.WhichTag:
                        if (!this.NewCheck())
                        {
                            if (this._c == 47)
                            {
                                this.PushNodeNameStart(false, this._index);
                            }
                            else
                            {
                                this.PushNodeNameStart(true, this._index - 1);
                                this.DecrementPosition();
                            }
                            this._state = HtmlDocument.ParseState.Tag;
                        }
                        break;
                    case HtmlDocument.ParseState.Tag:
                        if (!this.NewCheck())
                        {
                            if (HtmlDocument.IsWhiteSpace(this._c))
                            {
                                this.CloseParentImplicitExplicitNode();
                                this.PushNodeNameEnd(this._index - 1);
                                if (this._state == HtmlDocument.ParseState.Tag)
                                {
                                    this._state = HtmlDocument.ParseState.BetweenAttributes;
                                }
                            }
                            else if (this._c == 47)
                            {
                                this.CloseParentImplicitExplicitNode();
                                this.PushNodeNameEnd(this._index - 1);
                                if (this._state == HtmlDocument.ParseState.Tag)
                                {
                                    this._state = HtmlDocument.ParseState.EmptyTag;
                                }
                            }
                            else if (this._c == 62)
                            {
                                this.CloseParentImplicitExplicitNode();
                                this.PushNodeNameEnd(this._index - 1);
                                if (this._state == HtmlDocument.ParseState.Tag)
                                {
                                    if (!this.PushNodeEnd(this._index, false))
                                    {
                                        this._index = this.Text.Length;
                                    }
                                    else if (this._state == HtmlDocument.ParseState.Tag)
                                    {
                                        this._state = HtmlDocument.ParseState.Text;
                                        this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                    }
                                }
                            }
                        }
                        break;
                    case HtmlDocument.ParseState.BetweenAttributes:
                        if (!this.NewCheck() && !HtmlDocument.IsWhiteSpace(this._c))
                        {
                            if (this._c == 47 || this._c == 63)
                            {
                                this._state = HtmlDocument.ParseState.EmptyTag;
                            }
                            else if (this._c == 62)
                            {
                                if (!this.PushNodeEnd(this._index, false))
                                {
                                    this._index = this.Text.Length;
                                }
                                else if (this._state == HtmlDocument.ParseState.BetweenAttributes)
                                {
                                    this._state = HtmlDocument.ParseState.Text;
                                    this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                }
                            }
                            else
                            {
                                this.PushAttributeNameStart(this._index - 1, this._lineposition - 1);
                                this._state = HtmlDocument.ParseState.AttributeName;
                            }
                        }
                        break;
                    case HtmlDocument.ParseState.EmptyTag:
                        if (!this.NewCheck())
                        {
                            if (this._c == 62)
                            {
                                if (!this.PushNodeEnd(this._index, true))
                                {
                                    this._index = this.Text.Length;
                                }
                                else if (this._state == HtmlDocument.ParseState.EmptyTag)
                                {
                                    this._state = HtmlDocument.ParseState.Text;
                                    this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                }
                            }
                            else if (!HtmlDocument.IsWhiteSpace(this._c))
                            {
                                this.DecrementPosition();
                                this._state = HtmlDocument.ParseState.BetweenAttributes;
                            }
                            else
                            {
                                this._state = HtmlDocument.ParseState.BetweenAttributes;
                            }
                        }
                        break;
                    case HtmlDocument.ParseState.AttributeName:
                        if (!this.NewCheck())
                        {
                            this._currentattribute._isFromParse = true;
                            if (this._c == 47)
                            {
                                this.PushAttributeNameEnd(this._index - 1);
                                this._state = HtmlDocument.ParseState.AttributeBeforeEquals;
                            }
                            else if (HtmlDocument.IsWhiteSpace(this._c))
                            {
                                this.PushAttributeNameEnd(this._index - 1);
                                this._state = HtmlDocument.ParseState.AttributeBeforeEquals;
                            }
                            else if (this._c == 61)
                            {
                                this.PushAttributeNameEnd(this._index - 1);
                                this._currentattribute._hasEqual = true;
                                this._state = HtmlDocument.ParseState.AttributeAfterEquals;
                            }
                            else if (this._c == 62)
                            {
                                this.PushAttributeNameEnd(this._index - 1);
                                if (!this.PushNodeEnd(this._index, false))
                                {
                                    this._index = this.Text.Length;
                                }
                                else if (this._state == HtmlDocument.ParseState.AttributeName)
                                {
                                    this._state = HtmlDocument.ParseState.Text;
                                    this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                }
                            }
                        }
                        break;
                    case HtmlDocument.ParseState.AttributeBeforeEquals:
                        if (!this.NewCheck() && !HtmlDocument.IsWhiteSpace(this._c))
                        {
                            if (this._c == 62)
                            {
                                if (!this.PushNodeEnd(this._index, false))
                                {
                                    this._index = this.Text.Length;
                                }
                                else if (this._state == HtmlDocument.ParseState.AttributeBeforeEquals)
                                {
                                    this._state = HtmlDocument.ParseState.Text;
                                    this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                }
                            }
                            else if (this._c == 61)
                            {
                                this._currentattribute._hasEqual = true;
                                this._state = HtmlDocument.ParseState.AttributeAfterEquals;
                            }
                            else
                            {
                                this._state = HtmlDocument.ParseState.BetweenAttributes;
                                this.DecrementPosition();
                            }
                        }
                        break;
                    case HtmlDocument.ParseState.AttributeAfterEquals:
                        if (!this.NewCheck() && !HtmlDocument.IsWhiteSpace(this._c))
                        {
                            if (this._c == 39 || this._c == 34)
                            {
                                this._state = HtmlDocument.ParseState.QuotedAttributeValue;
                                this.PushAttributeValueStart(this._index, this._c);
                                num = this._c;
                            }
                            else if (this._c == 62)
                            {
                                if (!this.PushNodeEnd(this._index, false))
                                {
                                    this._index = this.Text.Length;
                                }
                                else if (this._state == HtmlDocument.ParseState.AttributeAfterEquals)
                                {
                                    this._state = HtmlDocument.ParseState.Text;
                                    this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                }
                            }
                            else
                            {
                                this.PushAttributeValueStart(this._index - 1);
                                this._state = HtmlDocument.ParseState.AttributeValue;
                            }
                        }
                        break;
                    case HtmlDocument.ParseState.AttributeValue:
                        if (!this.NewCheck())
                        {
                            if (HtmlDocument.IsWhiteSpace(this._c))
                            {
                                this.PushAttributeValueEnd(this._index - 1);
                                this._state = HtmlDocument.ParseState.BetweenAttributes;
                            }
                            else if (this._c == 62)
                            {
                                this.PushAttributeValueEnd(this._index - 1);
                                if (!this.PushNodeEnd(this._index, false))
                                {
                                    this._index = this.Text.Length;
                                }
                                else if (this._state == HtmlDocument.ParseState.AttributeValue)
                                {
                                    this._state = HtmlDocument.ParseState.Text;
                                    this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                }
                            }
                        }
                        break;
                    case HtmlDocument.ParseState.Comment:
                        if (this._c == 62 && (!this._fullcomment || (this.Text[this._index - 2] == '-' && this.Text[this._index - 3] == '-') || (this.Text[this._index - 2] == '!' && this.Text[this._index - 3] == '-' && this.Text[this._index - 4] == '-')))
                        {
                            if (!this.PushNodeEnd(this._index, false))
                            {
                                this._index = this.Text.Length;
                            }
                            else
                            {
                                this._state = HtmlDocument.ParseState.Text;
                                this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                            }
                        }
                        break;
                    case HtmlDocument.ParseState.QuotedAttributeValue:
                        if (this._c == num)
                        {
                            this.PushAttributeValueEnd(this._index - 1);
                            this._state = HtmlDocument.ParseState.BetweenAttributes;
                        }
                        else if (this._c == 60 && this._index < this.Text.Length && this.Text[this._index] == '%')
                        {
                            this._oldstate = this._state;
                            this._state = HtmlDocument.ParseState.ServerSideCode;
                        }
                        break;
                    case HtmlDocument.ParseState.ServerSideCode:
                        if (this._c == 37)
                        {
                            if (this._index < this.Text.Length && this.Text[this._index] == '>')
                            {
                                HtmlDocument.ParseState oldstate = this._oldstate;
                                if (oldstate != HtmlDocument.ParseState.BetweenAttributes)
                                {
                                    if (oldstate == HtmlDocument.ParseState.AttributeAfterEquals)
                                    {
                                        this._state = HtmlDocument.ParseState.AttributeValue;
                                    }
                                    else
                                    {
                                        this._state = this._oldstate;
                                    }
                                }
                                else
                                {
                                    this.PushAttributeNameEnd(this._index + 1);
                                    this._state = HtmlDocument.ParseState.BetweenAttributes;
                                }
                                this.IncrementPosition();
                            }
                        }
                        else if (this._oldstate == HtmlDocument.ParseState.QuotedAttributeValue && this._c == num)
                        {
                            this._state = this._oldstate;
                            this.DecrementPosition();
                        }
                        break;
                    case HtmlDocument.ParseState.PcData:
                        if (this._currentnode._namelength + 3 <= this.Text.Length - (this._index - 1) && string.Compare(this.Text.Substring(this._index - 1, this._currentnode._namelength + 2), "</" + this._currentnode.Name, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            int num2 = (int)this.Text[this._index - 1 + 2 + this._currentnode.Name.Length];
                            if (num2 == 62 || HtmlDocument.IsWhiteSpace(num2))
                            {
                                HtmlNode htmlNode = this.CreateNode(HtmlNodeType.Text, this._currentnode._outerstartindex + this._currentnode._outerlength);
                                htmlNode._outerlength = this._index - 1 - htmlNode._outerstartindex;
                                htmlNode._streamposition = htmlNode._outerstartindex;
                                htmlNode._line = this._currentnode.Line;
                                htmlNode._lineposition = this._currentnode.LinePosition + this._currentnode._namelength + 2;
                                this._currentnode.AppendChild(htmlNode);
                                if (this._currentnode.Name.ToLowerInvariant().Equals("script") || this._currentnode.Name.ToLowerInvariant().Equals("style"))
                                {
                                    this._currentnode._isHideInnerText = true;
                                }
                                this.PushNodeStart(HtmlNodeType.Element, this._index - 1, this._lineposition - 1);
                                this.PushNodeNameStart(false, this._index - 1 + 2);
                                this._state = HtmlDocument.ParseState.Tag;
                                this.IncrementPosition();
                            }
                        }
                        break;
                }
            }
            if (this._currentnode._namestartindex > 0)
            {
                this.PushNodeNameEnd(this._index);
            }
            this.PushNodeEnd(this._index, false);
            this.Lastnodes.Clear();
        }

        // Token: 0x060000A3 RID: 163 RVA: 0x00004AD0 File Offset: 0x00002CD0
        private void PushAttributeNameEnd(int index)
        {
            this._currentattribute._namelength = index - this._currentattribute._namestartindex;
            if (this._currentattribute.Name != null && !HtmlDocument.BlockAttributes.Contains(this._currentattribute.Name))
            {
                this._currentnode.Attributes.Append(this._currentattribute);
            }
        }

        // Token: 0x060000A4 RID: 164 RVA: 0x00004B30 File Offset: 0x00002D30
        private void PushAttributeNameStart(int index, int lineposition)
        {
            this._currentattribute = this.CreateAttribute();
            this._currentattribute._namestartindex = index;
            this._currentattribute.Line = this._line;
            this._currentattribute._lineposition = lineposition;
            this._currentattribute._streamposition = index;
        }

        // Token: 0x060000A5 RID: 165 RVA: 0x00004B7E File Offset: 0x00002D7E
        private void PushAttributeValueEnd(int index)
        {
            this._currentattribute._valuelength = index - this._currentattribute._valuestartindex;
        }

        // Token: 0x060000A6 RID: 166 RVA: 0x00004B98 File Offset: 0x00002D98
        private void PushAttributeValueStart(int index)
        {
            this.PushAttributeValueStart(index, 0);
        }

        // Token: 0x060000A7 RID: 167 RVA: 0x00004BA4 File Offset: 0x00002DA4
        private void CloseParentImplicitExplicitNode()
        {
            bool flag = true;
            while (flag && !this._lastparentnode.Closed)
            {
                flag = false;
                bool flag2 = false;
                if (this.IsParentImplicitEnd())
                {
                    if (this.OptionOutputAsXml)
                    {
                        flag2 = true;
                    }
                    else
                    {
                        this.CloseParentImplicitEnd();
                        flag = true;
                    }
                }
                if (flag2 || this.IsParentExplicitEnd())
                {
                    this.CloseParentExplicitEnd();
                    flag = true;
                }
            }
        }

        // Token: 0x060000A8 RID: 168 RVA: 0x00004BF8 File Offset: 0x00002DF8
        private bool IsParentImplicitEnd()
        {
            if (!this._currentnode._starttag)
            {
                return false;
            }
            bool result = false;
            string name = this._lastparentnode.Name;
            string a = this.Text.Substring(this._currentnode._namestartindex, this._index - this._currentnode._namestartindex - 1).ToLowerInvariant();
            if (!(name == "a"))
            {
                if (!(name == "dd"))
                {
                    if (!(name == "dt"))
                    {
                        if (!(name == "li"))
                        {
                            if (!(name == "p"))
                            {
                                if (name == "option")
                                {
                                    result = (a == "option");
                                }
                            }
                            else if (HtmlDocument.DisableBehaviorTagP)
                            {
                                result = (a == "address" || a == "article" || a == "aside" || a == "blockquote" || a == "dir" || a == "div" || a == "dl" || a == "fieldset" || a == "footer" || a == "form" || a == "h1" || a == "h2" || a == "h3" || a == "h4" || a == "h5" || a == "h6" || a == "header" || a == "hr" || a == "li" || a == "menu" || a == "nav" || a == "ol" || a == "p" || a == "pre" || a == "section" || a == "table" || a == "ul");
                            }
                            else
                            {
                                result = (a == "p");
                            }
                        }
                        else
                        {
                            result = (a == "li");
                        }
                    }
                    else
                    {
                        result = (a == "dt" || a == "dd");
                    }
                }
                else
                {
                    result = (a == "dt" || a == "dd");
                }
            }
            else
            {
                result = (a == "a");
            }
            return result;
        }

        // Token: 0x060000A9 RID: 169 RVA: 0x00004EC8 File Offset: 0x000030C8
        private bool IsParentExplicitEnd()
        {
            if (!this._currentnode._starttag)
            {
                return false;
            }
            bool result = false;
            string name = this._lastparentnode.Name;
            string a = this.Text.Substring(this._currentnode._namestartindex, this._index - this._currentnode._namestartindex - 1).ToLowerInvariant();
            uint num = PrivateImplementationDetails.ComputeStringHash(name);
            if (num <= 2352688966U)
            {
                if (num <= 1095059089U)
                {
                    if (num != 1027948613U)
                    {
                        if (num == 1095059089U)
                        {
                            if (name == "th")
                            {
                                result = (a == "td" || a == "th" || a == "tr");
                            }
                        }
                    }
                    else if (name == "td")
                    {
                        result = (a == "td" || a == "th" || a == "tr");
                    }
                }
                else if (num != 1195724803U)
                {
                    if (num != 1251777503U)
                    {
                        if (num == 2352688966U)
                        {
                            if (name == "h5")
                            {
                                result = (a == "h1" || a == "h2" || a == "h3" || a == "h4");
                            }
                        }
                    }
                    else if (name == "table")
                    {
                        result = (a == "table");
                    }
                }
                else if (name == "tr")
                {
                    result = (a == "tr");
                }
            }
            else if (num <= 2403021823U)
            {
                if (num != 2369466585U)
                {
                    if (num != 2386244204U)
                    {
                        if (num == 2403021823U)
                        {
                            if (name == "h2")
                            {
                                result = (a == "h1" || a == "h3" || a == "h4" || a == "h5");
                            }
                        }
                    }
                    else if (name == "h3")
                    {
                        result = (a == "h1" || a == "h2" || a == "h4" || a == "h5");
                    }
                }
                else if (name == "h4")
                {
                    result = (a == "h1" || a == "h2" || a == "h3" || a == "h5");
                }
            }
            else if (num != 2419799442U)
            {
                if (num != 2556802313U)
                {
                    if (num == 4111221743U)
                    {
                        if (name == "p")
                        {
                            result = (a == "div");
                        }
                    }
                }
                else if (name == "title")
                {
                    result = (a == "title");
                }
            }
            else if (name == "h1")
            {
                result = (a == "h2" || a == "h3" || a == "h4" || a == "h5");
            }
            return result;
        }

        // Token: 0x060000AA RID: 170 RVA: 0x0000526C File Offset: 0x0000346C
        private void CloseParentImplicitEnd()
        {
            HtmlNode htmlNode = new HtmlNode(this._lastparentnode.NodeType, this, -1);
            htmlNode._endnode = htmlNode;
            htmlNode._isImplicitEnd = true;
            this._lastparentnode._isImplicitEnd = true;
            this._lastparentnode.CloseNode(htmlNode, 0);
        }

        // Token: 0x060000AB RID: 171 RVA: 0x000052B4 File Offset: 0x000034B4
        private void CloseParentExplicitEnd()
        {
            HtmlNode htmlNode = new HtmlNode(this._lastparentnode.NodeType, this, -1);
            htmlNode._endnode = htmlNode;
            this._lastparentnode.CloseNode(htmlNode, 0);
        }

        // Token: 0x060000AC RID: 172 RVA: 0x000052E8 File Offset: 0x000034E8
        private void PushAttributeValueStart(int index, int quote)
        {
            this._currentattribute._valuestartindex = index;
            if (quote == 39)
            {
                this._currentattribute.QuoteType = AttributeValueQuote.SingleQuote;
            }
            this._currentattribute.InternalQuoteType = this._currentattribute.QuoteType;
            if (quote == 0)
            {
                this._currentattribute.InternalQuoteType = AttributeValueQuote.None;
            }
        }

        // Token: 0x060000AD RID: 173 RVA: 0x00005338 File Offset: 0x00003538
        private bool PushNodeEnd(int index, bool close)
        {
            this._currentnode._outerlength = index - this._currentnode._outerstartindex;
            if (this._currentnode._nodetype == HtmlNodeType.Text || this._currentnode._nodetype == HtmlNodeType.Comment)
            {
                if (this._currentnode._outerlength > 0)
                {
                    this._currentnode._innerlength = this._currentnode._outerlength;
                    this._currentnode._innerstartindex = this._currentnode._outerstartindex;
                    if (this._lastparentnode != null)
                    {
                        this._lastparentnode.AppendChild(this._currentnode);
                    }
                }
            }
            else if (this._currentnode._starttag && this._lastparentnode != this._currentnode)
            {
                if (this._lastparentnode != null)
                {
                    this._lastparentnode.AppendChild(this._currentnode);
                }
                this.ReadDocumentEncoding(this._currentnode);
                HtmlNode dictionaryValueOrDefault = Utilities.GetDictionaryValueOrDefault<string, HtmlNode>(this.Lastnodes, this._currentnode.Name, null);
                this._currentnode._prevwithsamename = dictionaryValueOrDefault;
                this.Lastnodes[this._currentnode.Name] = this._currentnode;
                if (this._currentnode.NodeType == HtmlNodeType.Document || this._currentnode.NodeType == HtmlNodeType.Element)
                {
                    this._lastparentnode = this._currentnode;
                }
                if (HtmlNode.IsCDataElement(this.CurrentNodeName()))
                {
                    this._state = HtmlDocument.ParseState.PcData;
                    return true;
                }
                if (HtmlNode.IsClosedElement(this._currentnode.Name) || HtmlNode.IsEmptyElement(this._currentnode.Name))
                {
                    close = true;
                }
            }
            if (close || !this._currentnode._starttag)
            {
                if (this.OptionStopperNodeName != null && this._remainder == null && string.Compare(this._currentnode.Name, this.OptionStopperNodeName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    this._remainderOffset = index;
                    this._remainder = this.Text.Substring(this._remainderOffset);
                    this.CloseCurrentNode();
                    return false;
                }
                this.CloseCurrentNode();
            }
            return true;
        }

        // Token: 0x060000AE RID: 174 RVA: 0x0000552A File Offset: 0x0000372A
        private void PushNodeNameEnd(int index)
        {
            this._currentnode._namelength = index - this._currentnode._namestartindex;
            if (this.OptionFixNestedTags)
            {
                this.FixNestedTags();
            }
        }

        // Token: 0x060000AF RID: 175 RVA: 0x00005552 File Offset: 0x00003752
        private void PushNodeNameStart(bool starttag, int index)
        {
            this._currentnode._starttag = starttag;
            this._currentnode._namestartindex = index;
        }

        // Token: 0x060000B0 RID: 176 RVA: 0x0000556C File Offset: 0x0000376C
        private void PushNodeStart(HtmlNodeType type, int index, int lineposition)
        {
            this._currentnode = this.CreateNode(type, index);
            this._currentnode._line = this._line;
            this._currentnode._lineposition = lineposition;
            this._currentnode._streamposition = index;
        }

        // Token: 0x060000B1 RID: 177 RVA: 0x000055A8 File Offset: 0x000037A8
        private void ReadDocumentEncoding(HtmlNode node)
        {
            if (!this.OptionReadEncoding)
            {
                return;
            }
            if (node._namelength != 4)
            {
                return;
            }
            if (node.Name != "meta")
            {
                return;
            }
            string text = null;
            HtmlAttribute htmlAttribute = node.Attributes["http-equiv"];
            if (htmlAttribute != null)
            {
                if (string.Compare(htmlAttribute.Value, "content-type", StringComparison.OrdinalIgnoreCase) != 0)
                {
                    return;
                }
                HtmlAttribute htmlAttribute2 = node.Attributes["content"];
                if (htmlAttribute2 != null)
                {
                    text = NameValuePairList.GetNameValuePairsValue(htmlAttribute2.Value, "charset");
                }
            }
            else
            {
                htmlAttribute = node.Attributes["charset"];
                if (htmlAttribute != null)
                {
                    text = htmlAttribute.Value;
                }
            }
            if (!string.IsNullOrEmpty(text))
            {
                if (string.Equals(text, "utf8", StringComparison.OrdinalIgnoreCase))
                {
                    text = "utf-8";
                }
                try
                {
                    this._declaredencoding = Encoding.GetEncoding(text);
                }
                catch (ArgumentException)
                {
                    this._declaredencoding = null;
                }
                if (this._onlyDetectEncoding)
                {
                    throw new EncodingFoundException(this._declaredencoding);
                }
                if (this._streamencoding != null && this._declaredencoding != null && this._declaredencoding.CodePage != this._streamencoding.CodePage)
                {
                    this.AddError(HtmlParseErrorCode.CharsetMismatch, this._line, this._lineposition, this._index, node.OuterHtml, "Encoding mismatch between StreamEncoding: " + this._streamencoding.WebName + " and DeclaredEncoding: " + this._declaredencoding.WebName);
                }
            }
        }

        // Token: 0x060000B2 RID: 178 RVA: 0x00005710 File Offset: 0x00003910
        public void DetectEncodingAndLoad(string path)
        {
            this.DetectEncodingAndLoad(path, true);
        }

        // Token: 0x060000B3 RID: 179 RVA: 0x0000571C File Offset: 0x0000391C
        public void DetectEncodingAndLoad(string path, bool detectEncoding)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }
            Encoding encoding;
            if (detectEncoding)
            {
                encoding = this.DetectEncoding(path);
            }
            else
            {
                encoding = null;
            }
            if (encoding == null)
            {
                this.Load(path);
                return;
            }
            this.Load(path, encoding);
        }

        // Token: 0x060000B4 RID: 180 RVA: 0x0000575C File Offset: 0x0000395C
        public Encoding DetectEncoding(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }
            Encoding result;
            using (StreamReader streamReader = new StreamReader(path, this.OptionDefaultStreamEncoding))
            {
                result = this.DetectEncoding(streamReader);
            }
            return result;
        }

        // Token: 0x060000B5 RID: 181 RVA: 0x000057AC File Offset: 0x000039AC
        public void Load(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }
            using (StreamReader streamReader = new StreamReader(path, this.OptionDefaultStreamEncoding))
            {
                this.Load(streamReader);
            }
        }

        // Token: 0x060000B6 RID: 182 RVA: 0x000057F8 File Offset: 0x000039F8
        public void Load(string path, bool detectEncodingFromByteOrderMarks)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }
            using (StreamReader streamReader = new StreamReader(path, detectEncodingFromByteOrderMarks))
            {
                this.Load(streamReader);
            }
        }

        // Token: 0x060000B7 RID: 183 RVA: 0x00005840 File Offset: 0x00003A40
        public void Load(string path, Encoding encoding)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }
            if (encoding == null)
            {
                throw new ArgumentNullException("encoding");
            }
            using (StreamReader streamReader = new StreamReader(path, encoding))
            {
                this.Load(streamReader);
            }
        }

        // Token: 0x060000B8 RID: 184 RVA: 0x00005894 File Offset: 0x00003A94
        public void Load(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }
            if (encoding == null)
            {
                throw new ArgumentNullException("encoding");
            }
            using (StreamReader streamReader = new StreamReader(path, encoding, detectEncodingFromByteOrderMarks))
            {
                this.Load(streamReader);
            }
        }

        // Token: 0x060000B9 RID: 185 RVA: 0x000058EC File Offset: 0x00003AEC
        public void Load(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }
            if (encoding == null)
            {
                throw new ArgumentNullException("encoding");
            }
            using (StreamReader streamReader = new StreamReader(path, encoding, detectEncodingFromByteOrderMarks, buffersize))
            {
                this.Load(streamReader);
            }
        }

        // Token: 0x060000BA RID: 186 RVA: 0x00005944 File Offset: 0x00003B44
        public void Save(string filename)
        {
            using (StreamWriter streamWriter = new StreamWriter(filename, false, this.GetOutEncoding()))
            {
                this.Save(streamWriter);
            }
        }

        // Token: 0x060000BB RID: 187 RVA: 0x00005984 File Offset: 0x00003B84
        public void Save(string filename, Encoding encoding)
        {
            if (filename == null)
            {
                throw new ArgumentNullException("filename");
            }
            if (encoding == null)
            {
                throw new ArgumentNullException("encoding");
            }
            using (StreamWriter streamWriter = new StreamWriter(filename, false, encoding))
            {
                this.Save(streamWriter);
            }
        }

        // Token: 0x060000BC RID: 188 RVA: 0x000059DC File Offset: 0x00003BDC
        public XPathNavigator CreateNavigator()
        {
            return new HtmlNodeNavigator(this, this._documentnode);
        }

        // Token: 0x0400001F RID: 31
        internal static bool _disableBehaviorTagP = true;

        // Token: 0x04000022 RID: 34
        private static int _maxDepthLevel = int.MaxValue;

        // Token: 0x04000023 RID: 35
        private int _c;

        // Token: 0x04000024 RID: 36
        private Crc32 _crc32;

        // Token: 0x04000025 RID: 37
        private HtmlAttribute _currentattribute;

        // Token: 0x04000026 RID: 38
        private HtmlNode _currentnode;

        // Token: 0x04000027 RID: 39
        private Encoding _declaredencoding;

        // Token: 0x04000028 RID: 40
        private HtmlNode _documentnode;

        // Token: 0x04000029 RID: 41
        private bool _fullcomment;

        // Token: 0x0400002A RID: 42
        private int _index;

        // Token: 0x0400002B RID: 43
        internal Dictionary<string, HtmlNode> Lastnodes = new Dictionary<string, HtmlNode>();

        // Token: 0x0400002C RID: 44
        private HtmlNode _lastparentnode;

        // Token: 0x0400002D RID: 45
        private int _line;

        // Token: 0x0400002E RID: 46
        private int _lineposition;

        // Token: 0x0400002F RID: 47
        private int _maxlineposition;

        // Token: 0x04000030 RID: 48
        internal Dictionary<string, HtmlNode> Nodesid;

        // Token: 0x04000031 RID: 49
        private HtmlDocument.ParseState _oldstate;

        // Token: 0x04000032 RID: 50
        private bool _onlyDetectEncoding;

        // Token: 0x04000033 RID: 51
        internal Dictionary<int, HtmlNode> Openednodes;

        // Token: 0x04000034 RID: 52
        private List<HtmlParseError> _parseerrors = new List<HtmlParseError>();

        // Token: 0x04000035 RID: 53
        private string _remainder;

        // Token: 0x04000036 RID: 54
        private int _remainderOffset;

        // Token: 0x04000037 RID: 55
        private HtmlDocument.ParseState _state;

        // Token: 0x04000038 RID: 56
        private Encoding _streamencoding;

        // Token: 0x04000039 RID: 57
        private bool _useHtmlEncodingForStream;

        // Token: 0x0400003A RID: 58
        public string Text;

        // Token: 0x0400003B RID: 59
        public bool BackwardCompatibility = true;

        // Token: 0x0400003C RID: 60
        public bool OptionAddDebuggingAttributes;

        // Token: 0x0400003D RID: 61
        public bool OptionAutoCloseOnEnd;

        // Token: 0x0400003E RID: 62
        public bool OptionCheckSyntax = true;

        // Token: 0x0400003F RID: 63
        public bool OptionComputeChecksum;

        // Token: 0x04000040 RID: 64
        public bool OptionEmptyCollection;

        // Token: 0x04000041 RID: 65
        public bool DisableServerSideCode;

        // Token: 0x04000042 RID: 66
        public Encoding OptionDefaultStreamEncoding;

        // Token: 0x04000043 RID: 67
        public bool OptionXmlForceOriginalComment;

        // Token: 0x04000044 RID: 68
        public bool OptionExtractErrorSourceText;

        // Token: 0x04000045 RID: 69
        public int OptionExtractErrorSourceTextMaxLength = 100;

        // Token: 0x04000046 RID: 70
        public bool OptionFixNestedTags;

        // Token: 0x04000047 RID: 71
        public bool OptionOutputAsXml;

        // Token: 0x04000048 RID: 72
        public bool OptionPreserveXmlNamespaces;

        // Token: 0x04000049 RID: 73
        public bool OptionOutputOptimizeAttributeValues;

        // Token: 0x0400004A RID: 74
        public AttributeValueQuote? GlobalAttributeValueQuote;

        // Token: 0x0400004B RID: 75
        public bool OptionOutputOriginalCase;

        // Token: 0x0400004C RID: 76
        public bool OptionOutputUpperCase;

        // Token: 0x0400004D RID: 77
        public bool OptionReadEncoding = true;

        // Token: 0x0400004E RID: 78
        public string OptionStopperNodeName;

        // Token: 0x0400004F RID: 79
        public bool OptionDefaultUseOriginalName;

        // Token: 0x04000050 RID: 80
        public bool OptionUseIdAttribute = true;

        // Token: 0x04000051 RID: 81
        public bool OptionWriteEmptyNodes;

        // Token: 0x04000052 RID: 82
        public int OptionMaxNestedChildNodes;

        // Token: 0x04000053 RID: 83
        internal static readonly string HtmlExceptionRefNotChild = "Reference node must be a child of this node";

        // Token: 0x04000054 RID: 84
        internal static readonly string HtmlExceptionUseIdAttributeFalse = "You need to set UseIdAttribute property to true to enable this feature";

        // Token: 0x04000055 RID: 85
        internal static readonly string HtmlExceptionClassDoesNotExist = "Class name doesn't exist";

        // Token: 0x04000056 RID: 86
        internal static readonly string HtmlExceptionClassExists = "Class name already exists";

        // Token: 0x04000057 RID: 87
        internal static readonly Dictionary<string, string[]> HtmlResetters = new Dictionary<string, string[]>
        {
            {
                "li",
                new string[]
                {
                    "ul",
                    "ol"
                }
            },
            {
                "tr",
                new string[]
                {
                    "table"
                }
            },
            {
                "th",
                new string[]
                {
                    "tr",
                    "table"
                }
            },
            {
                "td",
                new string[]
                {
                    "tr",
                    "table"
                }
            }
        };

        // Token: 0x04000058 RID: 88
        private static List<string> BlockAttributes = new List<string>
        {
            "\"",
            "'"
        };

        // Token: 0x0200002D RID: 45
        private enum ParseState
        {
            // Token: 0x040000E6 RID: 230
            Text,
            // Token: 0x040000E7 RID: 231
            WhichTag,
            // Token: 0x040000E8 RID: 232
            Tag,
            // Token: 0x040000E9 RID: 233
            BetweenAttributes,
            // Token: 0x040000EA RID: 234
            EmptyTag,
            // Token: 0x040000EB RID: 235
            AttributeName,
            // Token: 0x040000EC RID: 236
            AttributeBeforeEquals,
            // Token: 0x040000ED RID: 237
            AttributeAfterEquals,
            // Token: 0x040000EE RID: 238
            AttributeValue,
            // Token: 0x040000EF RID: 239
            Comment,
            // Token: 0x040000F0 RID: 240
            QuotedAttributeValue,
            // Token: 0x040000F1 RID: 241
            ServerSideCode,
            // Token: 0x040000F2 RID: 242
            PcData
        }
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x0200000B RID: 11
    [Flags]
    public enum HtmlElementFlag
    {
        // Token: 0x0400005A RID: 90
        CData = 1,
        // Token: 0x0400005B RID: 91
        Empty = 2,
        // Token: 0x0400005C RID: 92
        Closed = 4,
        // Token: 0x0400005D RID: 93
        CanOverlap = 8
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x0200000C RID: 12
    public class HtmlEntity
    {
        // Token: 0x17000028 RID: 40
        // (get) Token: 0x060000BE RID: 190 RVA: 0x00005AD9 File Offset: 0x00003CD9
        // (set) Token: 0x060000BF RID: 191 RVA: 0x00005AE0 File Offset: 0x00003CE0
        public static bool UseWebUtility { get; set; }

        // Token: 0x17000029 RID: 41
        // (get) Token: 0x060000C0 RID: 192 RVA: 0x00005AE8 File Offset: 0x00003CE8
        public static Dictionary<int, string> EntityName
        {
            get
            {
                return HtmlEntity._entityName;
            }
        }

        // Token: 0x1700002A RID: 42
        // (get) Token: 0x060000C1 RID: 193 RVA: 0x00005AEF File Offset: 0x00003CEF
        public static Dictionary<string, int> EntityValue
        {
            get
            {
                return HtmlEntity._entityValue;
            }
        }

        // Token: 0x060000C2 RID: 194 RVA: 0x00005AF8 File Offset: 0x00003CF8
        static HtmlEntity()
        {
            HtmlEntity._entityValue.Add("quot", 34);
            HtmlEntity._entityName.Add(34, "quot");
            HtmlEntity._entityValue.Add("amp", 38);
            HtmlEntity._entityName.Add(38, "amp");
            HtmlEntity._entityValue.Add("apos", 39);
            HtmlEntity._entityName.Add(39, "apos");
            HtmlEntity._entityValue.Add("lt", 60);
            HtmlEntity._entityName.Add(60, "lt");
            HtmlEntity._entityValue.Add("gt", 62);
            HtmlEntity._entityName.Add(62, "gt");
            HtmlEntity._entityValue.Add("nbsp", 160);
            HtmlEntity._entityName.Add(160, "nbsp");
            HtmlEntity._entityValue.Add("iexcl", 161);
            HtmlEntity._entityName.Add(161, "iexcl");
            HtmlEntity._entityValue.Add("cent", 162);
            HtmlEntity._entityName.Add(162, "cent");
            HtmlEntity._entityValue.Add("pound", 163);
            HtmlEntity._entityName.Add(163, "pound");
            HtmlEntity._entityValue.Add("curren", 164);
            HtmlEntity._entityName.Add(164, "curren");
            HtmlEntity._entityValue.Add("yen", 165);
            HtmlEntity._entityName.Add(165, "yen");
            HtmlEntity._entityValue.Add("brvbar", 166);
            HtmlEntity._entityName.Add(166, "brvbar");
            HtmlEntity._entityValue.Add("sect", 167);
            HtmlEntity._entityName.Add(167, "sect");
            HtmlEntity._entityValue.Add("uml", 168);
            HtmlEntity._entityName.Add(168, "uml");
            HtmlEntity._entityValue.Add("copy", 169);
            HtmlEntity._entityName.Add(169, "copy");
            HtmlEntity._entityValue.Add("ordf", 170);
            HtmlEntity._entityName.Add(170, "ordf");
            HtmlEntity._entityValue.Add("laquo", 171);
            HtmlEntity._entityName.Add(171, "laquo");
            HtmlEntity._entityValue.Add("not", 172);
            HtmlEntity._entityName.Add(172, "not");
            HtmlEntity._entityValue.Add("shy", 173);
            HtmlEntity._entityName.Add(173, "shy");
            HtmlEntity._entityValue.Add("reg", 174);
            HtmlEntity._entityName.Add(174, "reg");
            HtmlEntity._entityValue.Add("macr", 175);
            HtmlEntity._entityName.Add(175, "macr");
            HtmlEntity._entityValue.Add("deg", 176);
            HtmlEntity._entityName.Add(176, "deg");
            HtmlEntity._entityValue.Add("plusmn", 177);
            HtmlEntity._entityName.Add(177, "plusmn");
            HtmlEntity._entityValue.Add("sup2", 178);
            HtmlEntity._entityName.Add(178, "sup2");
            HtmlEntity._entityValue.Add("sup3", 179);
            HtmlEntity._entityName.Add(179, "sup3");
            HtmlEntity._entityValue.Add("acute", 180);
            HtmlEntity._entityName.Add(180, "acute");
            HtmlEntity._entityValue.Add("micro", 181);
            HtmlEntity._entityName.Add(181, "micro");
            HtmlEntity._entityValue.Add("para", 182);
            HtmlEntity._entityName.Add(182, "para");
            HtmlEntity._entityValue.Add("middot", 183);
            HtmlEntity._entityName.Add(183, "middot");
            HtmlEntity._entityValue.Add("cedil", 184);
            HtmlEntity._entityName.Add(184, "cedil");
            HtmlEntity._entityValue.Add("sup1", 185);
            HtmlEntity._entityName.Add(185, "sup1");
            HtmlEntity._entityValue.Add("ordm", 186);
            HtmlEntity._entityName.Add(186, "ordm");
            HtmlEntity._entityValue.Add("raquo", 187);
            HtmlEntity._entityName.Add(187, "raquo");
            HtmlEntity._entityValue.Add("frac14", 188);
            HtmlEntity._entityName.Add(188, "frac14");
            HtmlEntity._entityValue.Add("frac12", 189);
            HtmlEntity._entityName.Add(189, "frac12");
            HtmlEntity._entityValue.Add("frac34", 190);
            HtmlEntity._entityName.Add(190, "frac34");
            HtmlEntity._entityValue.Add("iquest", 191);
            HtmlEntity._entityName.Add(191, "iquest");
            HtmlEntity._entityValue.Add("Agrave", 192);
            HtmlEntity._entityName.Add(192, "Agrave");
            HtmlEntity._entityValue.Add("Aacute", 193);
            HtmlEntity._entityName.Add(193, "Aacute");
            HtmlEntity._entityValue.Add("Acirc", 194);
            HtmlEntity._entityName.Add(194, "Acirc");
            HtmlEntity._entityValue.Add("Atilde", 195);
            HtmlEntity._entityName.Add(195, "Atilde");
            HtmlEntity._entityValue.Add("Auml", 196);
            HtmlEntity._entityName.Add(196, "Auml");
            HtmlEntity._entityValue.Add("Aring", 197);
            HtmlEntity._entityName.Add(197, "Aring");
            HtmlEntity._entityValue.Add("AElig", 198);
            HtmlEntity._entityName.Add(198, "AElig");
            HtmlEntity._entityValue.Add("Ccedil", 199);
            HtmlEntity._entityName.Add(199, "Ccedil");
            HtmlEntity._entityValue.Add("Egrave", 200);
            HtmlEntity._entityName.Add(200, "Egrave");
            HtmlEntity._entityValue.Add("Eacute", 201);
            HtmlEntity._entityName.Add(201, "Eacute");
            HtmlEntity._entityValue.Add("Ecirc", 202);
            HtmlEntity._entityName.Add(202, "Ecirc");
            HtmlEntity._entityValue.Add("Euml", 203);
            HtmlEntity._entityName.Add(203, "Euml");
            HtmlEntity._entityValue.Add("Igrave", 204);
            HtmlEntity._entityName.Add(204, "Igrave");
            HtmlEntity._entityValue.Add("Iacute", 205);
            HtmlEntity._entityName.Add(205, "Iacute");
            HtmlEntity._entityValue.Add("Icirc", 206);
            HtmlEntity._entityName.Add(206, "Icirc");
            HtmlEntity._entityValue.Add("Iuml", 207);
            HtmlEntity._entityName.Add(207, "Iuml");
            HtmlEntity._entityValue.Add("ETH", 208);
            HtmlEntity._entityName.Add(208, "ETH");
            HtmlEntity._entityValue.Add("Ntilde", 209);
            HtmlEntity._entityName.Add(209, "Ntilde");
            HtmlEntity._entityValue.Add("Ograve", 210);
            HtmlEntity._entityName.Add(210, "Ograve");
            HtmlEntity._entityValue.Add("Oacute", 211);
            HtmlEntity._entityName.Add(211, "Oacute");
            HtmlEntity._entityValue.Add("Ocirc", 212);
            HtmlEntity._entityName.Add(212, "Ocirc");
            HtmlEntity._entityValue.Add("Otilde", 213);
            HtmlEntity._entityName.Add(213, "Otilde");
            HtmlEntity._entityValue.Add("Ouml", 214);
            HtmlEntity._entityName.Add(214, "Ouml");
            HtmlEntity._entityValue.Add("times", 215);
            HtmlEntity._entityName.Add(215, "times");
            HtmlEntity._entityValue.Add("Oslash", 216);
            HtmlEntity._entityName.Add(216, "Oslash");
            HtmlEntity._entityValue.Add("Ugrave", 217);
            HtmlEntity._entityName.Add(217, "Ugrave");
            HtmlEntity._entityValue.Add("Uacute", 218);
            HtmlEntity._entityName.Add(218, "Uacute");
            HtmlEntity._entityValue.Add("Ucirc", 219);
            HtmlEntity._entityName.Add(219, "Ucirc");
            HtmlEntity._entityValue.Add("Uuml", 220);
            HtmlEntity._entityName.Add(220, "Uuml");
            HtmlEntity._entityValue.Add("Yacute", 221);
            HtmlEntity._entityName.Add(221, "Yacute");
            HtmlEntity._entityValue.Add("THORN", 222);
            HtmlEntity._entityName.Add(222, "THORN");
            HtmlEntity._entityValue.Add("szlig", 223);
            HtmlEntity._entityName.Add(223, "szlig");
            HtmlEntity._entityValue.Add("agrave", 224);
            HtmlEntity._entityName.Add(224, "agrave");
            HtmlEntity._entityValue.Add("aacute", 225);
            HtmlEntity._entityName.Add(225, "aacute");
            HtmlEntity._entityValue.Add("acirc", 226);
            HtmlEntity._entityName.Add(226, "acirc");
            HtmlEntity._entityValue.Add("atilde", 227);
            HtmlEntity._entityName.Add(227, "atilde");
            HtmlEntity._entityValue.Add("auml", 228);
            HtmlEntity._entityName.Add(228, "auml");
            HtmlEntity._entityValue.Add("aring", 229);
            HtmlEntity._entityName.Add(229, "aring");
            HtmlEntity._entityValue.Add("aelig", 230);
            HtmlEntity._entityName.Add(230, "aelig");
            HtmlEntity._entityValue.Add("ccedil", 231);
            HtmlEntity._entityName.Add(231, "ccedil");
            HtmlEntity._entityValue.Add("egrave", 232);
            HtmlEntity._entityName.Add(232, "egrave");
            HtmlEntity._entityValue.Add("eacute", 233);
            HtmlEntity._entityName.Add(233, "eacute");
            HtmlEntity._entityValue.Add("ecirc", 234);
            HtmlEntity._entityName.Add(234, "ecirc");
            HtmlEntity._entityValue.Add("euml", 235);
            HtmlEntity._entityName.Add(235, "euml");
            HtmlEntity._entityValue.Add("igrave", 236);
            HtmlEntity._entityName.Add(236, "igrave");
            HtmlEntity._entityValue.Add("iacute", 237);
            HtmlEntity._entityName.Add(237, "iacute");
            HtmlEntity._entityValue.Add("icirc", 238);
            HtmlEntity._entityName.Add(238, "icirc");
            HtmlEntity._entityValue.Add("iuml", 239);
            HtmlEntity._entityName.Add(239, "iuml");
            HtmlEntity._entityValue.Add("eth", 240);
            HtmlEntity._entityName.Add(240, "eth");
            HtmlEntity._entityValue.Add("ntilde", 241);
            HtmlEntity._entityName.Add(241, "ntilde");
            HtmlEntity._entityValue.Add("ograve", 242);
            HtmlEntity._entityName.Add(242, "ograve");
            HtmlEntity._entityValue.Add("oacute", 243);
            HtmlEntity._entityName.Add(243, "oacute");
            HtmlEntity._entityValue.Add("ocirc", 244);
            HtmlEntity._entityName.Add(244, "ocirc");
            HtmlEntity._entityValue.Add("otilde", 245);
            HtmlEntity._entityName.Add(245, "otilde");
            HtmlEntity._entityValue.Add("ouml", 246);
            HtmlEntity._entityName.Add(246, "ouml");
            HtmlEntity._entityValue.Add("divide", 247);
            HtmlEntity._entityName.Add(247, "divide");
            HtmlEntity._entityValue.Add("oslash", 248);
            HtmlEntity._entityName.Add(248, "oslash");
            HtmlEntity._entityValue.Add("ugrave", 249);
            HtmlEntity._entityName.Add(249, "ugrave");
            HtmlEntity._entityValue.Add("uacute", 250);
            HtmlEntity._entityName.Add(250, "uacute");
            HtmlEntity._entityValue.Add("ucirc", 251);
            HtmlEntity._entityName.Add(251, "ucirc");
            HtmlEntity._entityValue.Add("uuml", 252);
            HtmlEntity._entityName.Add(252, "uuml");
            HtmlEntity._entityValue.Add("yacute", 253);
            HtmlEntity._entityName.Add(253, "yacute");
            HtmlEntity._entityValue.Add("thorn", 254);
            HtmlEntity._entityName.Add(254, "thorn");
            HtmlEntity._entityValue.Add("yuml", 255);
            HtmlEntity._entityName.Add(255, "yuml");
            HtmlEntity._entityValue.Add("fnof", 402);
            HtmlEntity._entityName.Add(402, "fnof");
            HtmlEntity._entityValue.Add("Alpha", 913);
            HtmlEntity._entityName.Add(913, "Alpha");
            HtmlEntity._entityValue.Add("Beta", 914);
            HtmlEntity._entityName.Add(914, "Beta");
            HtmlEntity._entityValue.Add("Gamma", 915);
            HtmlEntity._entityName.Add(915, "Gamma");
            HtmlEntity._entityValue.Add("Delta", 916);
            HtmlEntity._entityName.Add(916, "Delta");
            HtmlEntity._entityValue.Add("Epsilon", 917);
            HtmlEntity._entityName.Add(917, "Epsilon");
            HtmlEntity._entityValue.Add("Zeta", 918);
            HtmlEntity._entityName.Add(918, "Zeta");
            HtmlEntity._entityValue.Add("Eta", 919);
            HtmlEntity._entityName.Add(919, "Eta");
            HtmlEntity._entityValue.Add("Theta", 920);
            HtmlEntity._entityName.Add(920, "Theta");
            HtmlEntity._entityValue.Add("Iota", 921);
            HtmlEntity._entityName.Add(921, "Iota");
            HtmlEntity._entityValue.Add("Kappa", 922);
            HtmlEntity._entityName.Add(922, "Kappa");
            HtmlEntity._entityValue.Add("Lambda", 923);
            HtmlEntity._entityName.Add(923, "Lambda");
            HtmlEntity._entityValue.Add("Mu", 924);
            HtmlEntity._entityName.Add(924, "Mu");
            HtmlEntity._entityValue.Add("Nu", 925);
            HtmlEntity._entityName.Add(925, "Nu");
            HtmlEntity._entityValue.Add("Xi", 926);
            HtmlEntity._entityName.Add(926, "Xi");
            HtmlEntity._entityValue.Add("Omicron", 927);
            HtmlEntity._entityName.Add(927, "Omicron");
            HtmlEntity._entityValue.Add("Pi", 928);
            HtmlEntity._entityName.Add(928, "Pi");
            HtmlEntity._entityValue.Add("Rho", 929);
            HtmlEntity._entityName.Add(929, "Rho");
            HtmlEntity._entityValue.Add("Sigma", 931);
            HtmlEntity._entityName.Add(931, "Sigma");
            HtmlEntity._entityValue.Add("Tau", 932);
            HtmlEntity._entityName.Add(932, "Tau");
            HtmlEntity._entityValue.Add("Upsilon", 933);
            HtmlEntity._entityName.Add(933, "Upsilon");
            HtmlEntity._entityValue.Add("Phi", 934);
            HtmlEntity._entityName.Add(934, "Phi");
            HtmlEntity._entityValue.Add("Chi", 935);
            HtmlEntity._entityName.Add(935, "Chi");
            HtmlEntity._entityValue.Add("Psi", 936);
            HtmlEntity._entityName.Add(936, "Psi");
            HtmlEntity._entityValue.Add("Omega", 937);
            HtmlEntity._entityName.Add(937, "Omega");
            HtmlEntity._entityValue.Add("alpha", 945);
            HtmlEntity._entityName.Add(945, "alpha");
            HtmlEntity._entityValue.Add("beta", 946);
            HtmlEntity._entityName.Add(946, "beta");
            HtmlEntity._entityValue.Add("gamma", 947);
            HtmlEntity._entityName.Add(947, "gamma");
            HtmlEntity._entityValue.Add("delta", 948);
            HtmlEntity._entityName.Add(948, "delta");
            HtmlEntity._entityValue.Add("epsilon", 949);
            HtmlEntity._entityName.Add(949, "epsilon");
            HtmlEntity._entityValue.Add("zeta", 950);
            HtmlEntity._entityName.Add(950, "zeta");
            HtmlEntity._entityValue.Add("eta", 951);
            HtmlEntity._entityName.Add(951, "eta");
            HtmlEntity._entityValue.Add("theta", 952);
            HtmlEntity._entityName.Add(952, "theta");
            HtmlEntity._entityValue.Add("iota", 953);
            HtmlEntity._entityName.Add(953, "iota");
            HtmlEntity._entityValue.Add("kappa", 954);
            HtmlEntity._entityName.Add(954, "kappa");
            HtmlEntity._entityValue.Add("lambda", 955);
            HtmlEntity._entityName.Add(955, "lambda");
            HtmlEntity._entityValue.Add("mu", 956);
            HtmlEntity._entityName.Add(956, "mu");
            HtmlEntity._entityValue.Add("nu", 957);
            HtmlEntity._entityName.Add(957, "nu");
            HtmlEntity._entityValue.Add("xi", 958);
            HtmlEntity._entityName.Add(958, "xi");
            HtmlEntity._entityValue.Add("omicron", 959);
            HtmlEntity._entityName.Add(959, "omicron");
            HtmlEntity._entityValue.Add("pi", 960);
            HtmlEntity._entityName.Add(960, "pi");
            HtmlEntity._entityValue.Add("rho", 961);
            HtmlEntity._entityName.Add(961, "rho");
            HtmlEntity._entityValue.Add("sigmaf", 962);
            HtmlEntity._entityName.Add(962, "sigmaf");
            HtmlEntity._entityValue.Add("sigma", 963);
            HtmlEntity._entityName.Add(963, "sigma");
            HtmlEntity._entityValue.Add("tau", 964);
            HtmlEntity._entityName.Add(964, "tau");
            HtmlEntity._entityValue.Add("upsilon", 965);
            HtmlEntity._entityName.Add(965, "upsilon");
            HtmlEntity._entityValue.Add("phi", 966);
            HtmlEntity._entityName.Add(966, "phi");
            HtmlEntity._entityValue.Add("chi", 967);
            HtmlEntity._entityName.Add(967, "chi");
            HtmlEntity._entityValue.Add("psi", 968);
            HtmlEntity._entityName.Add(968, "psi");
            HtmlEntity._entityValue.Add("omega", 969);
            HtmlEntity._entityName.Add(969, "omega");
            HtmlEntity._entityValue.Add("thetasym", 977);
            HtmlEntity._entityName.Add(977, "thetasym");
            HtmlEntity._entityValue.Add("upsih", 978);
            HtmlEntity._entityName.Add(978, "upsih");
            HtmlEntity._entityValue.Add("piv", 982);
            HtmlEntity._entityName.Add(982, "piv");
            HtmlEntity._entityValue.Add("bull", 8226);
            HtmlEntity._entityName.Add(8226, "bull");
            HtmlEntity._entityValue.Add("hellip", 8230);
            HtmlEntity._entityName.Add(8230, "hellip");
            HtmlEntity._entityValue.Add("prime", 8242);
            HtmlEntity._entityName.Add(8242, "prime");
            HtmlEntity._entityValue.Add("Prime", 8243);
            HtmlEntity._entityName.Add(8243, "Prime");
            HtmlEntity._entityValue.Add("oline", 8254);
            HtmlEntity._entityName.Add(8254, "oline");
            HtmlEntity._entityValue.Add("frasl", 8260);
            HtmlEntity._entityName.Add(8260, "frasl");
            HtmlEntity._entityValue.Add("weierp", 8472);
            HtmlEntity._entityName.Add(8472, "weierp");
            HtmlEntity._entityValue.Add("image", 8465);
            HtmlEntity._entityName.Add(8465, "image");
            HtmlEntity._entityValue.Add("real", 8476);
            HtmlEntity._entityName.Add(8476, "real");
            HtmlEntity._entityValue.Add("trade", 8482);
            HtmlEntity._entityName.Add(8482, "trade");
            HtmlEntity._entityValue.Add("alefsym", 8501);
            HtmlEntity._entityName.Add(8501, "alefsym");
            HtmlEntity._entityValue.Add("larr", 8592);
            HtmlEntity._entityName.Add(8592, "larr");
            HtmlEntity._entityValue.Add("uarr", 8593);
            HtmlEntity._entityName.Add(8593, "uarr");
            HtmlEntity._entityValue.Add("rarr", 8594);
            HtmlEntity._entityName.Add(8594, "rarr");
            HtmlEntity._entityValue.Add("darr", 8595);
            HtmlEntity._entityName.Add(8595, "darr");
            HtmlEntity._entityValue.Add("harr", 8596);
            HtmlEntity._entityName.Add(8596, "harr");
            HtmlEntity._entityValue.Add("crarr", 8629);
            HtmlEntity._entityName.Add(8629, "crarr");
            HtmlEntity._entityValue.Add("lArr", 8656);
            HtmlEntity._entityName.Add(8656, "lArr");
            HtmlEntity._entityValue.Add("uArr", 8657);
            HtmlEntity._entityName.Add(8657, "uArr");
            HtmlEntity._entityValue.Add("rArr", 8658);
            HtmlEntity._entityName.Add(8658, "rArr");
            HtmlEntity._entityValue.Add("dArr", 8659);
            HtmlEntity._entityName.Add(8659, "dArr");
            HtmlEntity._entityValue.Add("hArr", 8660);
            HtmlEntity._entityName.Add(8660, "hArr");
            HtmlEntity._entityValue.Add("forall", 8704);
            HtmlEntity._entityName.Add(8704, "forall");
            HtmlEntity._entityValue.Add("part", 8706);
            HtmlEntity._entityName.Add(8706, "part");
            HtmlEntity._entityValue.Add("exist", 8707);
            HtmlEntity._entityName.Add(8707, "exist");
            HtmlEntity._entityValue.Add("empty", 8709);
            HtmlEntity._entityName.Add(8709, "empty");
            HtmlEntity._entityValue.Add("nabla", 8711);
            HtmlEntity._entityName.Add(8711, "nabla");
            HtmlEntity._entityValue.Add("isin", 8712);
            HtmlEntity._entityName.Add(8712, "isin");
            HtmlEntity._entityValue.Add("notin", 8713);
            HtmlEntity._entityName.Add(8713, "notin");
            HtmlEntity._entityValue.Add("ni", 8715);
            HtmlEntity._entityName.Add(8715, "ni");
            HtmlEntity._entityValue.Add("prod", 8719);
            HtmlEntity._entityName.Add(8719, "prod");
            HtmlEntity._entityValue.Add("sum", 8721);
            HtmlEntity._entityName.Add(8721, "sum");
            HtmlEntity._entityValue.Add("minus", 8722);
            HtmlEntity._entityName.Add(8722, "minus");
            HtmlEntity._entityValue.Add("lowast", 8727);
            HtmlEntity._entityName.Add(8727, "lowast");
            HtmlEntity._entityValue.Add("radic", 8730);
            HtmlEntity._entityName.Add(8730, "radic");
            HtmlEntity._entityValue.Add("prop", 8733);
            HtmlEntity._entityName.Add(8733, "prop");
            HtmlEntity._entityValue.Add("infin", 8734);
            HtmlEntity._entityName.Add(8734, "infin");
            HtmlEntity._entityValue.Add("ang", 8736);
            HtmlEntity._entityName.Add(8736, "ang");
            HtmlEntity._entityValue.Add("and", 8743);
            HtmlEntity._entityName.Add(8743, "and");
            HtmlEntity._entityValue.Add("or", 8744);
            HtmlEntity._entityName.Add(8744, "or");
            HtmlEntity._entityValue.Add("cap", 8745);
            HtmlEntity._entityName.Add(8745, "cap");
            HtmlEntity._entityValue.Add("cup", 8746);
            HtmlEntity._entityName.Add(8746, "cup");
            HtmlEntity._entityValue.Add("int", 8747);
            HtmlEntity._entityName.Add(8747, "int");
            HtmlEntity._entityValue.Add("there4", 8756);
            HtmlEntity._entityName.Add(8756, "there4");
            HtmlEntity._entityValue.Add("sim", 8764);
            HtmlEntity._entityName.Add(8764, "sim");
            HtmlEntity._entityValue.Add("cong", 8773);
            HtmlEntity._entityName.Add(8773, "cong");
            HtmlEntity._entityValue.Add("asymp", 8776);
            HtmlEntity._entityName.Add(8776, "asymp");
            HtmlEntity._entityValue.Add("ne", 8800);
            HtmlEntity._entityName.Add(8800, "ne");
            HtmlEntity._entityValue.Add("equiv", 8801);
            HtmlEntity._entityName.Add(8801, "equiv");
            HtmlEntity._entityValue.Add("le", 8804);
            HtmlEntity._entityName.Add(8804, "le");
            HtmlEntity._entityValue.Add("ge", 8805);
            HtmlEntity._entityName.Add(8805, "ge");
            HtmlEntity._entityValue.Add("sub", 8834);
            HtmlEntity._entityName.Add(8834, "sub");
            HtmlEntity._entityValue.Add("sup", 8835);
            HtmlEntity._entityName.Add(8835, "sup");
            HtmlEntity._entityValue.Add("nsub", 8836);
            HtmlEntity._entityName.Add(8836, "nsub");
            HtmlEntity._entityValue.Add("sube", 8838);
            HtmlEntity._entityName.Add(8838, "sube");
            HtmlEntity._entityValue.Add("supe", 8839);
            HtmlEntity._entityName.Add(8839, "supe");
            HtmlEntity._entityValue.Add("oplus", 8853);
            HtmlEntity._entityName.Add(8853, "oplus");
            HtmlEntity._entityValue.Add("otimes", 8855);
            HtmlEntity._entityName.Add(8855, "otimes");
            HtmlEntity._entityValue.Add("perp", 8869);
            HtmlEntity._entityName.Add(8869, "perp");
            HtmlEntity._entityValue.Add("sdot", 8901);
            HtmlEntity._entityName.Add(8901, "sdot");
            HtmlEntity._entityValue.Add("lceil", 8968);
            HtmlEntity._entityName.Add(8968, "lceil");
            HtmlEntity._entityValue.Add("rceil", 8969);
            HtmlEntity._entityName.Add(8969, "rceil");
            HtmlEntity._entityValue.Add("lfloor", 8970);
            HtmlEntity._entityName.Add(8970, "lfloor");
            HtmlEntity._entityValue.Add("rfloor", 8971);
            HtmlEntity._entityName.Add(8971, "rfloor");
            HtmlEntity._entityValue.Add("lang", 9001);
            HtmlEntity._entityName.Add(9001, "lang");
            HtmlEntity._entityValue.Add("rang", 9002);
            HtmlEntity._entityName.Add(9002, "rang");
            HtmlEntity._entityValue.Add("loz", 9674);
            HtmlEntity._entityName.Add(9674, "loz");
            HtmlEntity._entityValue.Add("spades", 9824);
            HtmlEntity._entityName.Add(9824, "spades");
            HtmlEntity._entityValue.Add("clubs", 9827);
            HtmlEntity._entityName.Add(9827, "clubs");
            HtmlEntity._entityValue.Add("hearts", 9829);
            HtmlEntity._entityName.Add(9829, "hearts");
            HtmlEntity._entityValue.Add("diams", 9830);
            HtmlEntity._entityName.Add(9830, "diams");
            HtmlEntity._entityValue.Add("OElig", 338);
            HtmlEntity._entityName.Add(338, "OElig");
            HtmlEntity._entityValue.Add("oelig", 339);
            HtmlEntity._entityName.Add(339, "oelig");
            HtmlEntity._entityValue.Add("Scaron", 352);
            HtmlEntity._entityName.Add(352, "Scaron");
            HtmlEntity._entityValue.Add("scaron", 353);
            HtmlEntity._entityName.Add(353, "scaron");
            HtmlEntity._entityValue.Add("Yuml", 376);
            HtmlEntity._entityName.Add(376, "Yuml");
            HtmlEntity._entityValue.Add("circ", 710);
            HtmlEntity._entityName.Add(710, "circ");
            HtmlEntity._entityValue.Add("tilde", 732);
            HtmlEntity._entityName.Add(732, "tilde");
            HtmlEntity._entityValue.Add("ensp", 8194);
            HtmlEntity._entityName.Add(8194, "ensp");
            HtmlEntity._entityValue.Add("emsp", 8195);
            HtmlEntity._entityName.Add(8195, "emsp");
            HtmlEntity._entityValue.Add("thinsp", 8201);
            HtmlEntity._entityName.Add(8201, "thinsp");
            HtmlEntity._entityValue.Add("zwnj", 8204);
            HtmlEntity._entityName.Add(8204, "zwnj");
            HtmlEntity._entityValue.Add("zwj", 8205);
            HtmlEntity._entityName.Add(8205, "zwj");
            HtmlEntity._entityValue.Add("lrm", 8206);
            HtmlEntity._entityName.Add(8206, "lrm");
            HtmlEntity._entityValue.Add("rlm", 8207);
            HtmlEntity._entityName.Add(8207, "rlm");
            HtmlEntity._entityValue.Add("ndash", 8211);
            HtmlEntity._entityName.Add(8211, "ndash");
            HtmlEntity._entityValue.Add("mdash", 8212);
            HtmlEntity._entityName.Add(8212, "mdash");
            HtmlEntity._entityValue.Add("lsquo", 8216);
            HtmlEntity._entityName.Add(8216, "lsquo");
            HtmlEntity._entityValue.Add("rsquo", 8217);
            HtmlEntity._entityName.Add(8217, "rsquo");
            HtmlEntity._entityValue.Add("sbquo", 8218);
            HtmlEntity._entityName.Add(8218, "sbquo");
            HtmlEntity._entityValue.Add("ldquo", 8220);
            HtmlEntity._entityName.Add(8220, "ldquo");
            HtmlEntity._entityValue.Add("rdquo", 8221);
            HtmlEntity._entityName.Add(8221, "rdquo");
            HtmlEntity._entityValue.Add("bdquo", 8222);
            HtmlEntity._entityName.Add(8222, "bdquo");
            HtmlEntity._entityValue.Add("dagger", 8224);
            HtmlEntity._entityName.Add(8224, "dagger");
            HtmlEntity._entityValue.Add("Dagger", 8225);
            HtmlEntity._entityName.Add(8225, "Dagger");
            HtmlEntity._entityValue.Add("permil", 8240);
            HtmlEntity._entityName.Add(8240, "permil");
            HtmlEntity._entityValue.Add("lsaquo", 8249);
            HtmlEntity._entityName.Add(8249, "lsaquo");
            HtmlEntity._entityValue.Add("rsaquo", 8250);
            HtmlEntity._entityName.Add(8250, "rsaquo");
            HtmlEntity._entityValue.Add("euro", 8364);
            HtmlEntity._entityName.Add(8364, "euro");
            HtmlEntity._maxEntitySize = 9;
        }

        // Token: 0x060000C3 RID: 195 RVA: 0x0000828A File Offset: 0x0000648A
        private HtmlEntity()
        {
        }

        // Token: 0x060000C4 RID: 196 RVA: 0x00008294 File Offset: 0x00006494
        public static string DeEntitize(string text)
        {
            if (text == null)
            {
                return null;
            }
            if (text.Length == 0)
            {
                return text;
            }
            StringBuilder stringBuilder = new StringBuilder(text.Length);
            HtmlEntity.ParseState parseState = HtmlEntity.ParseState.Text;
            StringBuilder stringBuilder2 = new StringBuilder(10);
            for (int i = 0; i < text.Length; i++)
            {
                if (parseState != HtmlEntity.ParseState.Text)
                {
                    if (parseState == HtmlEntity.ParseState.EntityStart)
                    {
                        char c = text[i];
                        if (c != '&')
                        {
                            if (c == ';')
                            {
                                if (stringBuilder2.Length == 0)
                                {
                                    stringBuilder.Append("&;");
                                }
                                else
                                {
                                    if (stringBuilder2[0] == '#')
                                    {
                                        string text2 = stringBuilder2.ToString();
                                        try
                                        {
                                            string text3 = text2.Substring(1).Trim();
                                            int fromBase;
                                            if (text3.StartsWith("x", StringComparison.OrdinalIgnoreCase))
                                            {
                                                fromBase = 16;
                                                text3 = text3.Substring(1);
                                            }
                                            else
                                            {
                                                fromBase = 10;
                                            }
                                            int value = Convert.ToInt32(text3, fromBase);
                                            stringBuilder.Append(Convert.ToChar(value));
                                            goto IL_153;
                                        }
                                        catch
                                        {
                                            stringBuilder.Append("&#" + text2 + ";");
                                            goto IL_153;
                                        }
                                        goto IL_10C;
                                    }
                                    goto IL_10C;
                                IL_153:
                                    stringBuilder2.Remove(0, stringBuilder2.Length);
                                    goto IL_161;
                                IL_10C:
                                    int value2;
                                    if (!HtmlEntity._entityValue.TryGetValue(stringBuilder2.ToString(), out value2))
                                    {
                                        StringBuilder stringBuilder3 = stringBuilder;
                                        string str = "&";
                                        StringBuilder stringBuilder4 = stringBuilder2;
                                        stringBuilder3.Append(str + ((stringBuilder4 != null) ? stringBuilder4.ToString() : null) + ";");
                                        goto IL_153;
                                    }
                                    stringBuilder.Append(Convert.ToChar(value2));
                                    goto IL_153;
                                }
                            IL_161:
                                parseState = HtmlEntity.ParseState.Text;
                            }
                            else
                            {
                                stringBuilder2.Append(text[i]);
                                if (stringBuilder2.Length > HtmlEntity._maxEntitySize)
                                {
                                    parseState = HtmlEntity.ParseState.Text;
                                    StringBuilder stringBuilder5 = stringBuilder;
                                    string str2 = "&";
                                    StringBuilder stringBuilder6 = stringBuilder2;
                                    stringBuilder5.Append(str2 + ((stringBuilder6 != null) ? stringBuilder6.ToString() : null));
                                    stringBuilder2.Remove(0, stringBuilder2.Length);
                                }
                            }
                        }
                        else
                        {
                            StringBuilder stringBuilder7 = stringBuilder;
                            string str3 = "&";
                            StringBuilder stringBuilder8 = stringBuilder2;
                            stringBuilder7.Append(str3 + ((stringBuilder8 != null) ? stringBuilder8.ToString() : null));
                            stringBuilder2.Remove(0, stringBuilder2.Length);
                        }
                    }
                }
                else if (text[i] == '&')
                {
                    parseState = HtmlEntity.ParseState.EntityStart;
                }
                else
                {
                    stringBuilder.Append(text[i]);
                }
            }
            if (parseState == HtmlEntity.ParseState.EntityStart)
            {
                StringBuilder stringBuilder9 = stringBuilder;
                string str4 = "&";
                StringBuilder stringBuilder10 = stringBuilder2;
                stringBuilder9.Append(str4 + ((stringBuilder10 != null) ? stringBuilder10.ToString() : null));
            }
            return stringBuilder.ToString();
        }

        // Token: 0x060000C5 RID: 197 RVA: 0x000084C8 File Offset: 0x000066C8
        public static HtmlNode Entitize(HtmlNode node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }
            HtmlNode htmlNode = node.CloneNode(true);
            if (htmlNode.HasAttributes)
            {
                HtmlEntity.Entitize(htmlNode.Attributes);
            }
            if (htmlNode.HasChildNodes)
            {
                HtmlEntity.Entitize(htmlNode.ChildNodes);
            }
            else if (htmlNode.NodeType == HtmlNodeType.Text)
            {
                ((HtmlTextNode)htmlNode).Text = HtmlEntity.Entitize(((HtmlTextNode)htmlNode).Text, true, true);
            }
            return htmlNode;
        }

        // Token: 0x060000C6 RID: 198 RVA: 0x0000853A File Offset: 0x0000673A
        public static string Entitize(string text)
        {
            return HtmlEntity.Entitize(text, true);
        }

        // Token: 0x060000C7 RID: 199 RVA: 0x00008543 File Offset: 0x00006743
        public static string Entitize(string text, bool useNames)
        {
            return HtmlEntity.Entitize(text, useNames, false);
        }

        // Token: 0x060000C8 RID: 200 RVA: 0x00008550 File Offset: 0x00006750
        public static string Entitize(string text, bool useNames, bool entitizeQuotAmpAndLtGt)
        {
            if (text == null)
            {
                return null;
            }
            if (text.Length == 0)
            {
                return text;
            }
            StringBuilder stringBuilder = new StringBuilder(text.Length);
            if (HtmlEntity.UseWebUtility)
            {
                TextElementEnumerator textElementEnumerator = StringInfo.GetTextElementEnumerator(text);
                while (textElementEnumerator.MoveNext())
                {
                    stringBuilder.Append(WebUtility.HtmlEncode(textElementEnumerator.GetTextElement()));
                }
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int num = (int)text[i];
                    if (num > 127 || (entitizeQuotAmpAndLtGt && (num == 34 || num == 38 || num == 60 || num == 62)))
                    {
                        string text2 = null;
                        if (useNames)
                        {
                            HtmlEntity.EntityName.TryGetValue(num, out text2);
                        }
                        if (text2 == null)
                        {
                            stringBuilder.Append("&#" + num.ToString() + ";");
                        }
                        else
                        {
                            stringBuilder.Append("&" + text2 + ";");
                        }
                    }
                    else
                    {
                        stringBuilder.Append(text[i]);
                    }
                }
            }
            return stringBuilder.ToString();
        }

        // Token: 0x060000C9 RID: 201 RVA: 0x00008648 File Offset: 0x00006848
        private static void Entitize(HtmlAttributeCollection collection)
        {
            foreach (HtmlAttribute htmlAttribute in ((IEnumerable<HtmlAttribute>)collection))
            {
                if (htmlAttribute.Value != null)
                {
                    htmlAttribute.Value = HtmlEntity.Entitize(htmlAttribute.Value);
                }
            }
        }

        // Token: 0x060000CA RID: 202 RVA: 0x000086A4 File Offset: 0x000068A4
        private static void Entitize(HtmlNodeCollection collection)
        {
            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)collection))
            {
                if (htmlNode.HasAttributes)
                {
                    HtmlEntity.Entitize(htmlNode.Attributes);
                }
                if (htmlNode.HasChildNodes)
                {
                    HtmlEntity.Entitize(htmlNode.ChildNodes);
                }
                else if (htmlNode.NodeType == HtmlNodeType.Text)
                {
                    ((HtmlTextNode)htmlNode).Text = HtmlEntity.Entitize(((HtmlTextNode)htmlNode).Text, true, true);
                }
            }
        }

        // Token: 0x0400005F RID: 95
        private static readonly int _maxEntitySize;

        // Token: 0x04000060 RID: 96
        private static Dictionary<int, string> _entityName = new Dictionary<int, string>();

        // Token: 0x04000061 RID: 97
        private static Dictionary<string, int> _entityValue = new Dictionary<string, int>();

        // Token: 0x0200002E RID: 46
        private enum ParseState
        {
            // Token: 0x040000F4 RID: 244
            Text,
            // Token: 0x040000F5 RID: 245
            EntityStart
        }
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x0200000D RID: 13
    internal class HtmlNameTable : XmlNameTable
    {
        // Token: 0x060000CB RID: 203 RVA: 0x00008734 File Offset: 0x00006934
        public override string Add(string array)
        {
            return this._nametable.Add(array);
        }

        // Token: 0x060000CC RID: 204 RVA: 0x00008742 File Offset: 0x00006942
        public override string Add(char[] array, int offset, int length)
        {
            return this._nametable.Add(array, offset, length);
        }

        // Token: 0x060000CD RID: 205 RVA: 0x00008752 File Offset: 0x00006952
        public override string Get(string array)
        {
            return this._nametable.Get(array);
        }

        // Token: 0x060000CE RID: 206 RVA: 0x00008760 File Offset: 0x00006960
        public override string Get(char[] array, int offset, int length)
        {
            return this._nametable.Get(array, offset, length);
        }

        // Token: 0x060000CF RID: 207 RVA: 0x00008770 File Offset: 0x00006970
        internal string GetOrAdd(string array)
        {
            string text = this.Get(array);
            if (text == null)
            {
                return this.Add(array);
            }
            return text;
        }

        // Token: 0x04000062 RID: 98
        private NameTable _nametable = new NameTable();
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x0200000E RID: 14
    [DebuggerDisplay("Name: {OriginalName}")]
    public class HtmlNode : IXPathNavigable
    {
        // Token: 0x060000D1 RID: 209 RVA: 0x000087A4 File Offset: 0x000069A4
        static HtmlNode()
        {
            HtmlNode.ElementsFlags.Add("script", HtmlElementFlag.CData);
            HtmlNode.ElementsFlags.Add("style", HtmlElementFlag.CData);
            HtmlNode.ElementsFlags.Add("noxhtml", HtmlElementFlag.CData);
            HtmlNode.ElementsFlags.Add("textarea", HtmlElementFlag.CData);
            HtmlNode.ElementsFlags.Add("title", HtmlElementFlag.CData);
            HtmlNode.ElementsFlags.Add("base", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("link", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("meta", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("isindex", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("hr", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("col", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("img", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("param", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("embed", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("frame", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("wbr", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("bgsound", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("spacer", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("keygen", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("area", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("input", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("basefont", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("source", HtmlElementFlag.Empty);
            HtmlNode.ElementsFlags.Add("form", HtmlElementFlag.CanOverlap);
            HtmlNode.ElementsFlags.Add("br", HtmlElementFlag.Empty | HtmlElementFlag.Closed);
            if (!HtmlDocument.DisableBehaviorTagP)
            {
                HtmlNode.ElementsFlags.Add("p", HtmlElementFlag.Empty | HtmlElementFlag.Closed);
            }
        }

        // Token: 0x060000D2 RID: 210 RVA: 0x00008988 File Offset: 0x00006B88
        public HtmlNode(HtmlNodeType type, HtmlDocument ownerdocument, int index)
        {
            this._nodetype = type;
            this._ownerdocument = ownerdocument;
            this._outerstartindex = index;
            switch (type)
            {
                case HtmlNodeType.Document:
                    this.SetName(HtmlNode.HtmlNodeTypeNameDocument);
                    this._endnode = this;
                    break;
                case HtmlNodeType.Comment:
                    this.SetName(HtmlNode.HtmlNodeTypeNameComment);
                    this._endnode = this;
                    break;
                case HtmlNodeType.Text:
                    this.SetName(HtmlNode.HtmlNodeTypeNameText);
                    this._endnode = this;
                    break;
            }
            if (this._ownerdocument.Openednodes != null && !this.Closed && -1 != index)
            {
                this._ownerdocument.Openednodes.Add(index, this);
            }
            if (-1 != index || type == HtmlNodeType.Comment || type == HtmlNodeType.Text)
            {
                return;
            }
            this.SetChanged();
        }

        // Token: 0x1700002B RID: 43
        // (get) Token: 0x060000D3 RID: 211 RVA: 0x00008A40 File Offset: 0x00006C40
        // (set) Token: 0x060000D4 RID: 212 RVA: 0x00008A5C File Offset: 0x00006C5C
        public HtmlAttributeCollection Attributes
        {
            get
            {
                if (!this.HasAttributes)
                {
                    this._attributes = new HtmlAttributeCollection(this);
                }
                return this._attributes;
            }
            internal set
            {
                this._attributes = value;
            }
        }

        // Token: 0x1700002C RID: 44
        // (get) Token: 0x060000D5 RID: 213 RVA: 0x00008A68 File Offset: 0x00006C68
        // (set) Token: 0x060000D6 RID: 214 RVA: 0x00008A8E File Offset: 0x00006C8E
        public HtmlNodeCollection ChildNodes
        {
            get
            {
                HtmlNodeCollection result;
                if ((result = this._childnodes) == null)
                {
                    result = (this._childnodes = new HtmlNodeCollection(this));
                }
                return result;
            }
            internal set
            {
                this._childnodes = value;
            }
        }

        // Token: 0x1700002D RID: 45
        // (get) Token: 0x060000D7 RID: 215 RVA: 0x00008A97 File Offset: 0x00006C97
        public bool Closed
        {
            get
            {
                return this._endnode != null;
            }
        }

        // Token: 0x1700002E RID: 46
        // (get) Token: 0x060000D8 RID: 216 RVA: 0x00008AA2 File Offset: 0x00006CA2
        public HtmlAttributeCollection ClosingAttributes
        {
            get
            {
                if (this.HasClosingAttributes)
                {
                    return this._endnode.Attributes;
                }
                return new HtmlAttributeCollection(this);
            }
        }

        // Token: 0x1700002F RID: 47
        // (get) Token: 0x060000D9 RID: 217 RVA: 0x00008ABE File Offset: 0x00006CBE
        public HtmlNode EndNode
        {
            get
            {
                return this._endnode;
            }
        }

        // Token: 0x17000030 RID: 48
        // (get) Token: 0x060000DA RID: 218 RVA: 0x00008AC6 File Offset: 0x00006CC6
        public HtmlNode FirstChild
        {
            get
            {
                if (this.HasChildNodes)
                {
                    return this._childnodes[0];
                }
                return null;
            }
        }

        // Token: 0x17000031 RID: 49
        // (get) Token: 0x060000DB RID: 219 RVA: 0x00008ADE File Offset: 0x00006CDE
        public bool HasAttributes
        {
            get
            {
                return this._attributes != null && this._attributes.Count > 0;
            }
        }

        // Token: 0x17000032 RID: 50
        // (get) Token: 0x060000DC RID: 220 RVA: 0x00008AFB File Offset: 0x00006CFB
        public bool HasChildNodes
        {
            get
            {
                return this._childnodes != null && this._childnodes.Count > 0;
            }
        }

        // Token: 0x17000033 RID: 51
        // (get) Token: 0x060000DD RID: 221 RVA: 0x00008B18 File Offset: 0x00006D18
        public bool HasClosingAttributes
        {
            get
            {
                return this._endnode != null && this._endnode != this && this._endnode._attributes != null && this._endnode._attributes.Count > 0;
            }
        }

        // Token: 0x17000034 RID: 52
        // (get) Token: 0x060000DE RID: 222 RVA: 0x00008B52 File Offset: 0x00006D52
        // (set) Token: 0x060000DF RID: 223 RVA: 0x00008B72 File Offset: 0x00006D72
        public string Id
        {
            get
            {
                if (this._ownerdocument.Nodesid == null)
                {
                    throw new Exception(HtmlDocument.HtmlExceptionUseIdAttributeFalse);
                }
                return this.GetId();
            }
            set
            {
                if (this._ownerdocument.Nodesid == null)
                {
                    throw new Exception(HtmlDocument.HtmlExceptionUseIdAttributeFalse);
                }
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                this.SetId(value);
            }
        }

        // Token: 0x17000035 RID: 53
        // (get) Token: 0x060000E0 RID: 224 RVA: 0x00008BA4 File Offset: 0x00006DA4
        // (set) Token: 0x060000E1 RID: 225 RVA: 0x00008C0C File Offset: 0x00006E0C
        public virtual string InnerHtml
        {
            get
            {
                if (this._changed)
                {
                    this.UpdateHtml();
                    return this._innerhtml;
                }
                if (this._innerhtml != null)
                {
                    return this._innerhtml;
                }
                if (this._innerstartindex < 0 || this._innerlength < 0)
                {
                    return string.Empty;
                }
                return this._ownerdocument.Text.Substring(this._innerstartindex, this._innerlength);
            }
            set
            {
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(value);
                this.RemoveAllChildren();
                this.AppendChildren(htmlDocument.DocumentNode.ChildNodes);
            }
        }

        // Token: 0x17000036 RID: 54
        // (get) Token: 0x060000E2 RID: 226 RVA: 0x00008C40 File Offset: 0x00006E40
        public virtual string InnerText
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                int depthLevel = 0;
                string text = this.Name;
                if (text != null)
                {
                    text = text.ToLowerInvariant();
                    bool isDisplayScriptingText = text == "head" || text == "script" || text == "style";
                    this.InternalInnerText(stringBuilder, isDisplayScriptingText, depthLevel);
                }
                else
                {
                    this.InternalInnerText(stringBuilder, false, depthLevel);
                }
                return stringBuilder.ToString();
            }
        }

        // Token: 0x060000E3 RID: 227 RVA: 0x00008CAC File Offset: 0x00006EAC
        internal virtual void InternalInnerText(StringBuilder sb, bool isDisplayScriptingText, int depthLevel)
        {
            depthLevel++;
            if (depthLevel > HtmlDocument.MaxDepthLevel)
            {
                throw new Exception(string.Format("Maximum deep level reached: {0}", HtmlDocument.MaxDepthLevel));
            }
            if (!this._ownerdocument.BackwardCompatibility)
            {
                if (this.HasChildNodes)
                {
                    this.AppendInnerText(sb, isDisplayScriptingText);
                    return;
                }
                sb.Append(this.GetCurrentNodeText());
                return;
            }
            else
            {
                if (this._nodetype == HtmlNodeType.Text)
                {
                    sb.Append(((HtmlTextNode)this).Text);
                    return;
                }
                if (this._nodetype == HtmlNodeType.Comment)
                {
                    return;
                }
                if (!this.HasChildNodes || (this._isHideInnerText && !isDisplayScriptingText))
                {
                    return;
                }
                foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ChildNodes))
                {
                    htmlNode.InternalInnerText(sb, isDisplayScriptingText, depthLevel);
                }
                return;
            }
        }

        // Token: 0x060000E4 RID: 228 RVA: 0x00008D88 File Offset: 0x00006F88
        public virtual string GetDirectInnerText()
        {
            if (!this._ownerdocument.BackwardCompatibility)
            {
                if (this.HasChildNodes)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    this.AppendDirectInnerText(stringBuilder);
                    return stringBuilder.ToString();
                }
                return this.GetCurrentNodeText();
            }
            else
            {
                if (this._nodetype == HtmlNodeType.Text)
                {
                    return ((HtmlTextNode)this).Text;
                }
                if (this._nodetype == HtmlNodeType.Comment)
                {
                    return "";
                }
                if (!this.HasChildNodes)
                {
                    return string.Empty;
                }
                StringBuilder stringBuilder2 = new StringBuilder();
                foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ChildNodes))
                {
                    if (htmlNode._nodetype == HtmlNodeType.Text)
                    {
                        stringBuilder2.Append(((HtmlTextNode)htmlNode).Text);
                    }
                }
                return stringBuilder2.ToString();
            }
        }

        // Token: 0x060000E5 RID: 229 RVA: 0x00008E58 File Offset: 0x00007058
        internal string GetCurrentNodeText()
        {
            if (this._nodetype == HtmlNodeType.Text)
            {
                string text = ((HtmlTextNode)this).Text;
                if (this.ParentNode.Name != "pre")
                {
                    text = text.Replace("\n", "").Replace("\r", "").Replace("\t", "");
                }
                return text;
            }
            return "";
        }

        // Token: 0x060000E6 RID: 230 RVA: 0x00008EC8 File Offset: 0x000070C8
        internal void AppendDirectInnerText(StringBuilder sb)
        {
            if (this._nodetype == HtmlNodeType.Text)
            {
                sb.Append(this.GetCurrentNodeText());
            }
            if (!this.HasChildNodes)
            {
                return;
            }
            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ChildNodes))
            {
                sb.Append(htmlNode.GetCurrentNodeText());
            }
        }

        // Token: 0x060000E7 RID: 231 RVA: 0x00008F3C File Offset: 0x0000713C
        internal void AppendInnerText(StringBuilder sb, bool isShowHideInnerText)
        {
            if (this._nodetype == HtmlNodeType.Text)
            {
                sb.Append(this.GetCurrentNodeText());
            }
            if (!this.HasChildNodes || (this._isHideInnerText && !isShowHideInnerText))
            {
                return;
            }
            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ChildNodes))
            {
                htmlNode.AppendInnerText(sb, isShowHideInnerText);
            }
        }

        // Token: 0x17000037 RID: 55
        // (get) Token: 0x060000E8 RID: 232 RVA: 0x00008FB4 File Offset: 0x000071B4
        public HtmlNode LastChild
        {
            get
            {
                if (this.HasChildNodes)
                {
                    return this._childnodes[this._childnodes.Count - 1];
                }
                return null;
            }
        }

        // Token: 0x17000038 RID: 56
        // (get) Token: 0x060000E9 RID: 233 RVA: 0x00008FD8 File Offset: 0x000071D8
        // (set) Token: 0x060000EA RID: 234 RVA: 0x00008FE0 File Offset: 0x000071E0
        public int Line
        {
            get
            {
                return this._line;
            }
            internal set
            {
                this._line = value;
            }
        }

        // Token: 0x17000039 RID: 57
        // (get) Token: 0x060000EB RID: 235 RVA: 0x00008FE9 File Offset: 0x000071E9
        // (set) Token: 0x060000EC RID: 236 RVA: 0x00008FF1 File Offset: 0x000071F1
        public int LinePosition
        {
            get
            {
                return this._lineposition;
            }
            internal set
            {
                this._lineposition = value;
            }
        }

        // Token: 0x1700003A RID: 58
        // (get) Token: 0x060000ED RID: 237 RVA: 0x00008FFA File Offset: 0x000071FA
        public int InnerStartIndex
        {
            get
            {
                return this._innerstartindex;
            }
        }

        // Token: 0x1700003B RID: 59
        // (get) Token: 0x060000EE RID: 238 RVA: 0x00009002 File Offset: 0x00007202
        public int OuterStartIndex
        {
            get
            {
                return this._outerstartindex;
            }
        }

        // Token: 0x1700003C RID: 60
        // (get) Token: 0x060000EF RID: 239 RVA: 0x0000900A File Offset: 0x0000720A
        public int InnerLength
        {
            get
            {
                return this.InnerHtml.Length;
            }
        }

        // Token: 0x1700003D RID: 61
        // (get) Token: 0x060000F0 RID: 240 RVA: 0x00009017 File Offset: 0x00007217
        public int OuterLength
        {
            get
            {
                return this.OuterHtml.Length;
            }
        }

        // Token: 0x1700003E RID: 62
        // (get) Token: 0x060000F1 RID: 241 RVA: 0x00009024 File Offset: 0x00007224
        // (set) Token: 0x060000F2 RID: 242 RVA: 0x000090C2 File Offset: 0x000072C2
        public string Name
        {
            get
            {
                if (this._optimizedName == null)
                {
                    if (this._name == null)
                    {
                        this.SetName(this._ownerdocument.Text.Substring(this._namestartindex, this._namelength));
                    }
                    if (this._name == null)
                    {
                        this._optimizedName = string.Empty;
                    }
                    else if (this.OwnerDocument != null)
                    {
                        this._optimizedName = (this.OwnerDocument.OptionDefaultUseOriginalName ? this._name : this._name.ToLowerInvariant());
                    }
                    else
                    {
                        this._optimizedName = this._name.ToLowerInvariant();
                    }
                }
                return this._optimizedName;
            }
            set
            {
                this.SetName(value);
                this.SetChanged();
            }
        }

        // Token: 0x060000F3 RID: 243 RVA: 0x000090D1 File Offset: 0x000072D1
        internal void SetName(string value)
        {
            this._name = value;
            this._optimizedName = null;
        }

        // Token: 0x1700003F RID: 63
        // (get) Token: 0x060000F4 RID: 244 RVA: 0x000090E1 File Offset: 0x000072E1
        // (set) Token: 0x060000F5 RID: 245 RVA: 0x000090E9 File Offset: 0x000072E9
        public HtmlNode NextSibling
        {
            get
            {
                return this._nextnode;
            }
            internal set
            {
                this._nextnode = value;
            }
        }

        // Token: 0x17000040 RID: 64
        // (get) Token: 0x060000F6 RID: 246 RVA: 0x000090F2 File Offset: 0x000072F2
        // (set) Token: 0x060000F7 RID: 247 RVA: 0x000090FA File Offset: 0x000072FA
        public HtmlNodeType NodeType
        {
            get
            {
                return this._nodetype;
            }
            internal set
            {
                this._nodetype = value;
            }
        }

        // Token: 0x17000041 RID: 65
        // (get) Token: 0x060000F8 RID: 248 RVA: 0x00009103 File Offset: 0x00007303
        public string OriginalName
        {
            get
            {
                return this._name;
            }
        }

        // Token: 0x17000042 RID: 66
        // (get) Token: 0x060000F9 RID: 249 RVA: 0x0000910C File Offset: 0x0000730C
        public virtual string OuterHtml
        {
            get
            {
                if (this._changed)
                {
                    this.UpdateHtml();
                    return this._outerhtml;
                }
                if (this._outerhtml != null)
                {
                    return this._outerhtml;
                }
                if (this._outerstartindex < 0 || this._outerlength < 0)
                {
                    return string.Empty;
                }
                return this._ownerdocument.Text.Substring(this._outerstartindex, this._outerlength);
            }
        }

        // Token: 0x17000043 RID: 67
        // (get) Token: 0x060000FA RID: 250 RVA: 0x00009171 File Offset: 0x00007371
        // (set) Token: 0x060000FB RID: 251 RVA: 0x00009179 File Offset: 0x00007379
        public HtmlDocument OwnerDocument
        {
            get
            {
                return this._ownerdocument;
            }
            internal set
            {
                this._ownerdocument = value;
            }
        }

        // Token: 0x17000044 RID: 68
        // (get) Token: 0x060000FC RID: 252 RVA: 0x00009182 File Offset: 0x00007382
        // (set) Token: 0x060000FD RID: 253 RVA: 0x0000918A File Offset: 0x0000738A
        public HtmlNode ParentNode
        {
            get
            {
                return this._parentnode;
            }
            internal set
            {
                this._parentnode = value;
            }
        }

        // Token: 0x17000045 RID: 69
        // (get) Token: 0x060000FE RID: 254 RVA: 0x00009193 File Offset: 0x00007393
        // (set) Token: 0x060000FF RID: 255 RVA: 0x0000919B File Offset: 0x0000739B
        public HtmlNode PreviousSibling
        {
            get
            {
                return this._prevnode;
            }
            internal set
            {
                this._prevnode = value;
            }
        }

        // Token: 0x17000046 RID: 70
        // (get) Token: 0x06000100 RID: 256 RVA: 0x000091A4 File Offset: 0x000073A4
        public int StreamPosition
        {
            get
            {
                return this._streamposition;
            }
        }

        // Token: 0x17000047 RID: 71
        // (get) Token: 0x06000101 RID: 257 RVA: 0x000091AC File Offset: 0x000073AC
        public string XPath
        {
            get
            {
                return ((this.ParentNode == null || this.ParentNode.NodeType == HtmlNodeType.Document) ? "/" : (this.ParentNode.XPath + "/")) + this.GetRelativeXpath();
            }
        }

        // Token: 0x17000048 RID: 72
        // (get) Token: 0x06000102 RID: 258 RVA: 0x000091EA File Offset: 0x000073EA
        // (set) Token: 0x06000103 RID: 259 RVA: 0x000091F2 File Offset: 0x000073F2
        public int Depth { get; set; }

        // Token: 0x06000104 RID: 260 RVA: 0x000091FC File Offset: 0x000073FC
        public static bool CanOverlapElement(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            HtmlElementFlag htmlElementFlag;
            return HtmlNode.ElementsFlags.TryGetValue(name, out htmlElementFlag) && (htmlElementFlag & HtmlElementFlag.CanOverlap) > (HtmlElementFlag)0;
        }

        // Token: 0x06000105 RID: 261 RVA: 0x0000922E File Offset: 0x0000742E
        public static HtmlNode CreateNode(string html)
        {
            return HtmlNode.CreateNode(html, null);
        }

        // Token: 0x06000106 RID: 262 RVA: 0x00009238 File Offset: 0x00007438
        public static HtmlNode CreateNode(string html, Action<HtmlDocument> htmlDocumentBuilder)
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            if (htmlDocumentBuilder != null)
            {
                htmlDocumentBuilder(htmlDocument);
            }
            htmlDocument.LoadHtml(html);
            if (!htmlDocument.DocumentNode.IsSingleElementNode())
            {
                throw new Exception("Multiple node elements can't be created.");
            }
            for (HtmlNode htmlNode = htmlDocument.DocumentNode.FirstChild; htmlNode != null; htmlNode = htmlNode.NextSibling)
            {
                if (htmlNode.NodeType == HtmlNodeType.Element && htmlNode.OuterHtml != "\r\n")
                {
                    return htmlNode;
                }
            }
            return htmlDocument.DocumentNode.FirstChild;
        }

        // Token: 0x06000107 RID: 263 RVA: 0x000092B4 File Offset: 0x000074B4
        public static bool IsCDataElement(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            HtmlElementFlag htmlElementFlag;
            return HtmlNode.ElementsFlags.TryGetValue(name, out htmlElementFlag) && (htmlElementFlag & HtmlElementFlag.CData) > (HtmlElementFlag)0;
        }

        // Token: 0x06000108 RID: 264 RVA: 0x000092E8 File Offset: 0x000074E8
        public static bool IsClosedElement(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            HtmlElementFlag htmlElementFlag;
            return HtmlNode.ElementsFlags.TryGetValue(name, out htmlElementFlag) && (htmlElementFlag & HtmlElementFlag.Closed) > (HtmlElementFlag)0;
        }

        // Token: 0x06000109 RID: 265 RVA: 0x0000931C File Offset: 0x0000751C
        public static bool IsEmptyElement(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            HtmlElementFlag htmlElementFlag;
            return name.Length == 0 || '!' == name[0] || '?' == name[0] || (HtmlNode.ElementsFlags.TryGetValue(name, out htmlElementFlag) && (htmlElementFlag & HtmlElementFlag.Empty) > (HtmlElementFlag)0);
        }

        // Token: 0x0600010A RID: 266 RVA: 0x00009374 File Offset: 0x00007574
        public static bool IsOverlappedClosingElement(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }
            return text.Length > 4 && text[0] == '<' && text[text.Length - 1] == '>' && text[1] == '/' && HtmlNode.CanOverlapElement(text.Substring(2, text.Length - 3));
        }

        // Token: 0x0600010B RID: 267 RVA: 0x000093D8 File Offset: 0x000075D8
        public IEnumerable<HtmlNode> Ancestors()
        {
            HtmlNode node = this.ParentNode;
            if (node != null)
            {
                yield return node;
                while (node.ParentNode != null)
                {
                    yield return node.ParentNode;
                    node = node.ParentNode;
                }
            }
            yield break;
        }

        // Token: 0x0600010C RID: 268 RVA: 0x000093E8 File Offset: 0x000075E8
        public IEnumerable<HtmlNode> Ancestors(string name)
        {
            HtmlNode i;
            for (i = this.ParentNode; i != null; i = i.ParentNode)
            {
                if (i.Name == name)
                {
                    yield return i;
                }
            }
            i = null;
            yield break;
        }

        // Token: 0x0600010D RID: 269 RVA: 0x000093FF File Offset: 0x000075FF
        public IEnumerable<HtmlNode> AncestorsAndSelf()
        {
            HtmlNode i;
            for (i = this; i != null; i = i.ParentNode)
            {
                yield return i;
            }
            i = null;
            yield break;
        }

        // Token: 0x0600010E RID: 270 RVA: 0x0000940F File Offset: 0x0000760F
        public IEnumerable<HtmlNode> AncestorsAndSelf(string name)
        {
            HtmlNode i;
            for (i = this; i != null; i = i.ParentNode)
            {
                if (i.Name == name)
                {
                    yield return i;
                }
            }
            i = null;
            yield break;
        }

        // Token: 0x0600010F RID: 271 RVA: 0x00009428 File Offset: 0x00007628
        public HtmlNode AppendChild(HtmlNode newChild)
        {
            if (newChild == null)
            {
                throw new ArgumentNullException("newChild");
            }
            this.ChildNodes.Append(newChild);
            this._ownerdocument.SetIdForNode(newChild, newChild.GetId());
            this.SetChildNodesId(newChild);
            HtmlNode parentnode = this._parentnode;
            HtmlDocument htmlDocument = null;
            while (parentnode != null)
            {
                if (parentnode.OwnerDocument != htmlDocument)
                {
                    parentnode.OwnerDocument.SetIdForNode(newChild, newChild.GetId());
                    parentnode.SetChildNodesId(newChild);
                    htmlDocument = parentnode.OwnerDocument;
                }
                parentnode = parentnode._parentnode;
            }
            this.SetChanged();
            return newChild;
        }

        // Token: 0x06000110 RID: 272 RVA: 0x000094B0 File Offset: 0x000076B0
        public void SetChildNodesId(HtmlNode chilNode)
        {
            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)chilNode.ChildNodes))
            {
                this._ownerdocument.SetIdForNode(htmlNode, htmlNode.GetId());
                if (htmlNode.ChildNodes == chilNode.ChildNodes)
                {
                    throw new Exception("Oops! a scenario that will cause a Stack Overflow has been found. See the following issue for an example: https://github.com/zzzprojects/html-agility-pack/issues/513");
                }
                this.SetChildNodesId(htmlNode);
            }
        }

        // Token: 0x06000111 RID: 273 RVA: 0x00009528 File Offset: 0x00007728
        public void AppendChildren(HtmlNodeCollection newChildren)
        {
            if (newChildren == null)
            {
                throw new ArgumentNullException("newChildren");
            }
            foreach (HtmlNode newChild in ((IEnumerable<HtmlNode>)newChildren))
            {
                this.AppendChild(newChild);
            }
        }

        // Token: 0x06000112 RID: 274 RVA: 0x00009580 File Offset: 0x00007780
        public IEnumerable<HtmlAttribute> ChildAttributes(string name)
        {
            return this.Attributes.AttributesWithName(name);
        }

        // Token: 0x06000113 RID: 275 RVA: 0x0000958E File Offset: 0x0000778E
        public HtmlNode Clone()
        {
            return this.CloneNode(true);
        }

        // Token: 0x06000114 RID: 276 RVA: 0x00009597 File Offset: 0x00007797
        public HtmlNode CloneNode(string newName)
        {
            return this.CloneNode(newName, true);
        }

        // Token: 0x06000115 RID: 277 RVA: 0x000095A1 File Offset: 0x000077A1
        public HtmlNode CloneNode(string newName, bool deep)
        {
            if (newName == null)
            {
                throw new ArgumentNullException("newName");
            }
            HtmlNode htmlNode = this.CloneNode(deep);
            htmlNode.SetName(newName);
            return htmlNode;
        }

        // Token: 0x06000116 RID: 278 RVA: 0x000095C0 File Offset: 0x000077C0
        public HtmlNode CloneNode(bool deep)
        {
            HtmlNode htmlNode = this._ownerdocument.CreateNode(this._nodetype);
            htmlNode.SetName(this.OriginalName);
            HtmlNodeType nodetype = this._nodetype;
            if (nodetype == HtmlNodeType.Comment)
            {
                ((HtmlCommentNode)htmlNode).Comment = ((HtmlCommentNode)this).Comment;
                return htmlNode;
            }
            if (nodetype == HtmlNodeType.Text)
            {
                ((HtmlTextNode)htmlNode).Text = ((HtmlTextNode)this).Text;
                return htmlNode;
            }
            if (this.HasAttributes)
            {
                foreach (HtmlAttribute htmlAttribute in ((IEnumerable<HtmlAttribute>)this._attributes))
                {
                    HtmlAttribute newAttribute = htmlAttribute.Clone();
                    htmlNode.Attributes.Append(newAttribute);
                }
            }
            if (this.HasClosingAttributes)
            {
                htmlNode._endnode = this._endnode.CloneNode(false);
                foreach (HtmlAttribute htmlAttribute2 in ((IEnumerable<HtmlAttribute>)this._endnode._attributes))
                {
                    HtmlAttribute newAttribute2 = htmlAttribute2.Clone();
                    htmlNode._endnode._attributes.Append(newAttribute2);
                }
            }
            if (!deep)
            {
                return htmlNode;
            }
            if (!this.HasChildNodes)
            {
                return htmlNode;
            }
            foreach (HtmlNode htmlNode2 in ((IEnumerable<HtmlNode>)this._childnodes))
            {
                HtmlNode newChild = htmlNode2.CloneNode(deep);
                htmlNode.AppendChild(newChild);
            }
            return htmlNode;
        }

        // Token: 0x06000117 RID: 279 RVA: 0x00009748 File Offset: 0x00007948
        public void CopyFrom(HtmlNode node)
        {
            this.CopyFrom(node, true);
        }

        // Token: 0x06000118 RID: 280 RVA: 0x00009754 File Offset: 0x00007954
        public void CopyFrom(HtmlNode node, bool deep)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }
            this.Attributes.RemoveAll();
            if (node.HasAttributes)
            {
                foreach (HtmlAttribute htmlAttribute in ((IEnumerable<HtmlAttribute>)node.Attributes))
                {
                    HtmlAttribute newAttribute = htmlAttribute.Clone();
                    this.Attributes.Append(newAttribute);
                }
            }
            if (deep)
            {
                this.RemoveAllChildren();
                if (node.HasChildNodes)
                {
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)node.ChildNodes))
                    {
                        this.AppendChild(htmlNode.CloneNode(true));
                    }
                }
            }
        }

        // Token: 0x06000119 RID: 281 RVA: 0x00009824 File Offset: 0x00007A24
        [Obsolete("Use Descendants() instead, the results of this function will change in a future version")]
        public IEnumerable<HtmlNode> DescendantNodes(int level = 0)
        {
            if (level > HtmlDocument.MaxDepthLevel)
            {
                throw new ArgumentException("The document is too complex to parse");
            }
            foreach (HtmlNode node in ((IEnumerable<HtmlNode>)this.ChildNodes))
            {
                yield return node;
                foreach (HtmlNode htmlNode in node.DescendantNodes(level + 1))
                {
                    yield return htmlNode;
                }
                IEnumerator<HtmlNode> enumerator2 = null;
            }
            IEnumerator<HtmlNode> enumerator = null;
            yield break;
            yield break;
        }

        // Token: 0x0600011A RID: 282 RVA: 0x0000983B File Offset: 0x00007A3B
        [Obsolete("Use DescendantsAndSelf() instead, the results of this function will change in a future version")]
        public IEnumerable<HtmlNode> DescendantNodesAndSelf()
        {
            return this.DescendantsAndSelf();
        }

        // Token: 0x0600011B RID: 283 RVA: 0x00009843 File Offset: 0x00007A43
        public IEnumerable<HtmlNode> Descendants()
        {
            return this.Descendants(0);
        }

        // Token: 0x0600011C RID: 284 RVA: 0x0000984C File Offset: 0x00007A4C
        public IEnumerable<HtmlNode> Descendants(int level)
        {
            if (level > HtmlDocument.MaxDepthLevel)
            {
                throw new ArgumentException("The document is too complex to parse");
            }
            foreach (HtmlNode node in ((IEnumerable<HtmlNode>)this.ChildNodes))
            {
                yield return node;
                foreach (HtmlNode htmlNode in node.Descendants(level + 1))
                {
                    yield return htmlNode;
                }
                IEnumerator<HtmlNode> enumerator2 = null;
            }
            IEnumerator<HtmlNode> enumerator = null;
            yield break;
            yield break;
        }

        // Token: 0x0600011D RID: 285 RVA: 0x00009863 File Offset: 0x00007A63
        public IEnumerable<HtmlNode> Descendants(string name)
        {
            foreach (HtmlNode htmlNode in this.Descendants())
            {
                if (string.Equals(htmlNode.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    yield return htmlNode;
                }
            }
            IEnumerator<HtmlNode> enumerator = null;
            yield break;
            yield break;
        }

        // Token: 0x0600011E RID: 286 RVA: 0x0000987A File Offset: 0x00007A7A
        public IEnumerable<HtmlNode> DescendantsAndSelf()
        {
            yield return this;
            foreach (HtmlNode htmlNode in this.Descendants())
            {
                if (htmlNode != null)
                {
                    yield return htmlNode;
                }
            }
            IEnumerator<HtmlNode> enumerator = null;
            yield break;
            yield break;
        }

        // Token: 0x0600011F RID: 287 RVA: 0x0000988A File Offset: 0x00007A8A
        public IEnumerable<HtmlNode> DescendantsAndSelf(string name)
        {
            yield return this;
            foreach (HtmlNode htmlNode in this.Descendants())
            {
                if (htmlNode.Name == name)
                {
                    yield return htmlNode;
                }
            }
            IEnumerator<HtmlNode> enumerator = null;
            yield break;
            yield break;
        }

        // Token: 0x06000120 RID: 288 RVA: 0x000098A4 File Offset: 0x00007AA4
        public HtmlNode Element(string name)
        {
            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ChildNodes))
            {
                if (htmlNode.Name == name)
                {
                    return htmlNode;
                }
            }
            return null;
        }

        // Token: 0x06000121 RID: 289 RVA: 0x00009900 File Offset: 0x00007B00
        public IEnumerable<HtmlNode> Elements(string name)
        {
            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ChildNodes))
            {
                if (htmlNode.Name == name)
                {
                    yield return htmlNode;
                }
            }
            IEnumerator<HtmlNode> enumerator = null;
            yield break;
            yield break;
        }

        // Token: 0x06000122 RID: 290 RVA: 0x00009918 File Offset: 0x00007B18
        public HtmlAttribute GetDataAttribute(string key)
        {
            return this.Attributes.Hashitems.SingleOrDefault((KeyValuePair<string, HtmlAttribute> x) => x.Key.Equals("data-" + key, StringComparison.OrdinalIgnoreCase)).Value;
        }

        // Token: 0x06000123 RID: 291 RVA: 0x00009958 File Offset: 0x00007B58
        public IEnumerable<HtmlAttribute> GetDataAttributes()
        {
            return (from x in this.Attributes.Hashitems
                    where x.Key.StartsWith("data-", StringComparison.OrdinalIgnoreCase)
                    select x.Value).ToList<HtmlAttribute>();
        }

        // Token: 0x06000124 RID: 292 RVA: 0x000099BD File Offset: 0x00007BBD
        public IEnumerable<HtmlAttribute> GetAttributes()
        {
            return this.Attributes.items;
        }

        // Token: 0x06000125 RID: 293 RVA: 0x000099CC File Offset: 0x00007BCC
        public IEnumerable<HtmlAttribute> GetAttributes(params string[] attributeNames)
        {
            List<HtmlAttribute> list = new List<HtmlAttribute>();
            foreach (string name in attributeNames)
            {
                list.Add(this.Attributes[name]);
            }
            return list;
        }

        // Token: 0x06000126 RID: 294 RVA: 0x00009A06 File Offset: 0x00007C06
        public string GetAttributeValue(string name, string def)
        {
            return this.GetAttributeValue<string>(name, def);
        }

        // Token: 0x06000127 RID: 295 RVA: 0x00009A10 File Offset: 0x00007C10
        public int GetAttributeValue(string name, int def)
        {
            return this.GetAttributeValue<int>(name, def);
        }

        // Token: 0x06000128 RID: 296 RVA: 0x00009A1A File Offset: 0x00007C1A
        public bool GetAttributeValue(string name, bool def)
        {
            return this.GetAttributeValue<bool>(name, def);
        }

        // Token: 0x06000129 RID: 297 RVA: 0x00009A24 File Offset: 0x00007C24
        public T GetAttributeValue<T>(string name, T def)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (!this.HasAttributes)
            {
                return def;
            }
            HtmlAttribute htmlAttribute = this.Attributes[name];
            if (htmlAttribute == null)
            {
                return def;
            }
            T result;
            try
            {
                result = (T)((object)htmlAttribute.Value.To(typeof(T)));
            }
            catch
            {
                result = def;
            }
            return result;
        }

        // Token: 0x0600012A RID: 298 RVA: 0x00009A90 File Offset: 0x00007C90
        public HtmlNode InsertAfter(HtmlNode newChild, HtmlNode refChild)
        {
            if (newChild == null)
            {
                throw new ArgumentNullException("newChild");
            }
            if (refChild == null)
            {
                return this.PrependChild(newChild);
            }
            if (newChild == refChild)
            {
                return newChild;
            }
            int num = -1;
            if (this._childnodes != null)
            {
                num = this._childnodes[refChild];
            }
            if (num == -1)
            {
                throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
            }
            if (this._childnodes != null)
            {
                this._childnodes.Insert(num + 1, newChild);
            }
            this._ownerdocument.SetIdForNode(newChild, newChild.GetId());
            this.SetChildNodesId(newChild);
            this.SetChanged();
            return newChild;
        }

        // Token: 0x0600012B RID: 299 RVA: 0x00009B1C File Offset: 0x00007D1C
        public HtmlNode InsertBefore(HtmlNode newChild, HtmlNode refChild)
        {
            if (newChild == null)
            {
                throw new ArgumentNullException("newChild");
            }
            if (refChild == null)
            {
                return this.AppendChild(newChild);
            }
            if (newChild == refChild)
            {
                return newChild;
            }
            int num = -1;
            if (this._childnodes != null)
            {
                num = this._childnodes[refChild];
            }
            if (num == -1)
            {
                throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
            }
            if (this._childnodes != null)
            {
                this._childnodes.Insert(num, newChild);
            }
            this._ownerdocument.SetIdForNode(newChild, newChild.GetId());
            this.SetChildNodesId(newChild);
            this.SetChanged();
            return newChild;
        }

        // Token: 0x0600012C RID: 300 RVA: 0x00009BA3 File Offset: 0x00007DA3
        public HtmlNode PrependChild(HtmlNode newChild)
        {
            if (newChild == null)
            {
                throw new ArgumentNullException("newChild");
            }
            this.ChildNodes.Prepend(newChild);
            this._ownerdocument.SetIdForNode(newChild, newChild.GetId());
            this.SetChildNodesId(newChild);
            this.SetChanged();
            return newChild;
        }

        // Token: 0x0600012D RID: 301 RVA: 0x00009BE0 File Offset: 0x00007DE0
        public void PrependChildren(HtmlNodeCollection newChildren)
        {
            if (newChildren == null)
            {
                throw new ArgumentNullException("newChildren");
            }
            for (int i = newChildren.Count - 1; i >= 0; i--)
            {
                this.PrependChild(newChildren[i]);
            }
        }

        // Token: 0x0600012E RID: 302 RVA: 0x00009C1C File Offset: 0x00007E1C
        public void Remove()
        {
            if (this.ParentNode != null)
            {
                this.ParentNode.ChildNodes.Remove(this);
            }
        }

        // Token: 0x0600012F RID: 303 RVA: 0x00009C38 File Offset: 0x00007E38
        public void RemoveAll()
        {
            this.RemoveAllChildren();
            if (this.HasAttributes)
            {
                this._attributes.Clear();
            }
            if (this._endnode != null && this._endnode != this && this._endnode._attributes != null)
            {
                this._endnode._attributes.Clear();
            }
            this.SetChanged();
        }

        // Token: 0x06000130 RID: 304 RVA: 0x00009C94 File Offset: 0x00007E94
        public void RemoveAllChildren()
        {
            if (!this.HasChildNodes)
            {
                return;
            }
            if (this._ownerdocument.OptionUseIdAttribute)
            {
                foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this._childnodes))
                {
                    this._ownerdocument.SetIdForNode(null, htmlNode.GetId());
                    this.RemoveAllIDforNode(htmlNode);
                }
            }
            this._childnodes.Clear();
            this.SetChanged();
        }

        // Token: 0x06000131 RID: 305 RVA: 0x00009D1C File Offset: 0x00007F1C
        public void RemoveAllIDforNode(HtmlNode node)
        {
            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)node.ChildNodes))
            {
                this._ownerdocument.SetIdForNode(null, htmlNode.GetId());
                this.RemoveAllIDforNode(htmlNode);
            }
        }

        // Token: 0x06000132 RID: 306 RVA: 0x00009D7C File Offset: 0x00007F7C
        public void MoveChild(HtmlNode child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Oops! the 'child' parameter cannot be null.");
            }
            HtmlNode parentNode = child.ParentNode;
            this.AppendChild(child);
            if (parentNode != null)
            {
                parentNode.RemoveChild(child);
            }
        }

        // Token: 0x06000133 RID: 307 RVA: 0x00009DB4 File Offset: 0x00007FB4
        public void MoveChildren(HtmlNodeCollection children)
        {
            if (children == null)
            {
                throw new ArgumentNullException("Oops! the 'children' parameter cannot be null.");
            }
            HtmlNode parentNode = children.ParentNode;
            this.AppendChildren(children);
            if (parentNode != null)
            {
                parentNode.RemoveChildren(children);
            }
        }

        // Token: 0x06000134 RID: 308 RVA: 0x00009DE8 File Offset: 0x00007FE8
        public void RemoveChildren(HtmlNodeCollection oldChildren)
        {
            if (oldChildren == null)
            {
                throw new ArgumentNullException("Oops! the 'oldChildren' parameter cannot be null.");
            }
            foreach (HtmlNode oldChild in oldChildren.ToList<HtmlNode>())
            {
                this.RemoveChild(oldChild);
            }
        }

        // Token: 0x06000135 RID: 309 RVA: 0x00009E4C File Offset: 0x0000804C
        public HtmlNode RemoveChild(HtmlNode oldChild)
        {
            if (oldChild == null)
            {
                throw new ArgumentNullException("oldChild");
            }
            int num = -1;
            if (this._childnodes != null)
            {
                num = this._childnodes[oldChild];
            }
            if (num == -1)
            {
                throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
            }
            if (this._childnodes != null)
            {
                this._childnodes.Remove(num);
            }
            this._ownerdocument.SetIdForNode(null, oldChild.GetId());
            this.RemoveAllIDforNode(oldChild);
            this.SetChanged();
            return oldChild;
        }

        // Token: 0x06000136 RID: 310 RVA: 0x00009EC4 File Offset: 0x000080C4
        public HtmlNode RemoveChild(HtmlNode oldChild, bool keepGrandChildren)
        {
            if (oldChild == null)
            {
                throw new ArgumentNullException("oldChild");
            }
            if (oldChild._childnodes != null && keepGrandChildren)
            {
                HtmlNode refChild = oldChild.PreviousSibling;
                foreach (HtmlNode newChild in ((IEnumerable<HtmlNode>)oldChild._childnodes))
                {
                    refChild = this.InsertAfter(newChild, refChild);
                }
            }
            this.RemoveChild(oldChild);
            this.SetChanged();
            return oldChild;
        }

        // Token: 0x06000137 RID: 311 RVA: 0x00009F44 File Offset: 0x00008144
        public HtmlNode ReplaceChild(HtmlNode newChild, HtmlNode oldChild)
        {
            if (newChild == null)
            {
                return this.RemoveChild(oldChild);
            }
            if (oldChild == null)
            {
                return this.AppendChild(newChild);
            }
            int num = -1;
            if (this._childnodes != null)
            {
                num = this._childnodes[oldChild];
            }
            if (num == -1)
            {
                throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
            }
            if (this._childnodes != null)
            {
                this._childnodes.Replace(num, newChild);
            }
            this._ownerdocument.SetIdForNode(null, oldChild.GetId());
            this.RemoveAllIDforNode(oldChild);
            this._ownerdocument.SetIdForNode(newChild, newChild.GetId());
            this.SetChildNodesId(newChild);
            this.SetChanged();
            return newChild;
        }

        // Token: 0x06000138 RID: 312 RVA: 0x00009FDC File Offset: 0x000081DC
        public HtmlAttribute SetAttributeValue(string name, string value)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            HtmlAttribute htmlAttribute = this.Attributes[name];
            if (htmlAttribute == null)
            {
                return this.Attributes.Append(this._ownerdocument.CreateAttribute(name, value));
            }
            htmlAttribute.Value = value;
            return htmlAttribute;
        }

        // Token: 0x06000139 RID: 313 RVA: 0x0000A028 File Offset: 0x00008228
        public void WriteContentTo(TextWriter outText, int level = 0)
        {
            if (level > HtmlDocument.MaxDepthLevel)
            {
                throw new ArgumentException("The document is too complex to parse");
            }
            if (this._childnodes == null)
            {
                return;
            }
            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this._childnodes))
            {
                htmlNode.WriteTo(outText, level + 1);
            }
        }

        // Token: 0x0600013A RID: 314 RVA: 0x0000A094 File Offset: 0x00008294
        public string WriteContentTo()
        {
            StringWriter stringWriter = new StringWriter();
            this.WriteContentTo(stringWriter, 0);
            stringWriter.Flush();
            return stringWriter.ToString();
        }

        // Token: 0x0600013B RID: 315 RVA: 0x0000A0BC File Offset: 0x000082BC
        public virtual void WriteTo(TextWriter outText, int level = 0)
        {
            switch (this._nodetype)
            {
                case HtmlNodeType.Document:
                    if (this._ownerdocument.OptionOutputAsXml)
                    {
                        outText.Write("<?xml version=\"1.0\" encoding=\"" + this._ownerdocument.GetOutEncoding().BodyName + "\"?>");
                        if (this._ownerdocument.DocumentNode.HasChildNodes)
                        {
                            int num = this._ownerdocument.DocumentNode._childnodes.Count;
                            if (num > 0)
                            {
                                if (this._ownerdocument.GetXmlDeclaration() != null)
                                {
                                    num--;
                                }
                                if (num > 1)
                                {
                                    if (!this._ownerdocument.BackwardCompatibility)
                                    {
                                        this.WriteContentTo(outText, level);
                                        return;
                                    }
                                    if (this._ownerdocument.OptionOutputUpperCase)
                                    {
                                        outText.Write("<SPAN>");
                                        this.WriteContentTo(outText, level);
                                        outText.Write("</SPAN>");
                                        return;
                                    }
                                    outText.Write("<span>");
                                    this.WriteContentTo(outText, level);
                                    outText.Write("</span>");
                                    return;
                                }
                            }
                        }
                    }
                    this.WriteContentTo(outText, level);
                    return;
                case HtmlNodeType.Element:
                    {
                        string text = this._ownerdocument.OptionOutputUpperCase ? this.Name.ToUpperInvariant() : this.Name;
                        if (this._ownerdocument.OptionOutputOriginalCase)
                        {
                            text = this.OriginalName;
                        }
                        if (this._ownerdocument.OptionOutputAsXml)
                        {
                            if (text.Length <= 0 || text[0] == '?' || text.Trim().Length == 0)
                            {
                                return;
                            }
                            text = HtmlDocument.GetXmlName(text, false, this._ownerdocument.OptionPreserveXmlNamespaces);
                        }
                        outText.Write("<" + text);
                        this.WriteAttributes(outText, false);
                        if (this.HasChildNodes)
                        {
                            outText.Write(">");
                            bool flag = false;
                            if (this._ownerdocument.OptionOutputAsXml && HtmlNode.IsCDataElement(this.Name))
                            {
                                flag = true;
                                outText.Write("\r\n//<![CDATA[\r\n");
                            }
                            if (flag)
                            {
                                if (this.HasChildNodes)
                                {
                                    this.ChildNodes[0].WriteTo(outText, level);
                                }
                                outText.Write("\r\n//]]>//\r\n");
                            }
                            else
                            {
                                this.WriteContentTo(outText, level);
                            }
                            if (this._ownerdocument.OptionOutputAsXml || !this._isImplicitEnd)
                            {
                                outText.Write("</" + text);
                                if (!this._ownerdocument.OptionOutputAsXml)
                                {
                                    this.WriteAttributes(outText, true);
                                }
                                outText.Write(">");
                                return;
                            }
                        }
                        else if (HtmlNode.IsEmptyElement(this.Name))
                        {
                            if (this._ownerdocument.OptionWriteEmptyNodes || this._ownerdocument.OptionOutputAsXml)
                            {
                                outText.Write(" />");
                                return;
                            }
                            if (this.Name.Length > 0 && this.Name[0] == '?')
                            {
                                outText.Write("?");
                            }
                            outText.Write(">");
                            return;
                        }
                        else
                        {
                            if (!this._isImplicitEnd)
                            {
                                outText.Write("></" + text + ">");
                                return;
                            }
                            outText.Write(">");
                        }
                        return;
                    }
                case HtmlNodeType.Comment:
                    {
                        string text2 = ((HtmlCommentNode)this).Comment;
                        if (!this._ownerdocument.OptionOutputAsXml)
                        {
                            outText.Write(text2);
                            return;
                        }
                        HtmlCommentNode htmlCommentNode = (HtmlCommentNode)this;
                        if (!this._ownerdocument.BackwardCompatibility && htmlCommentNode.Comment.ToLowerInvariant().StartsWith("<!doctype"))
                        {
                            outText.Write(htmlCommentNode.Comment);
                            return;
                        }
                        if (this.OwnerDocument.OptionXmlForceOriginalComment)
                        {
                            outText.Write(htmlCommentNode.Comment);
                            return;
                        }
                        outText.Write("<!--" + HtmlNode.GetXmlComment(htmlCommentNode) + " -->");
                        return;
                    }
                case HtmlNodeType.Text:
                    {
                        string text2 = ((HtmlTextNode)this).Text;
                        outText.Write(this._ownerdocument.OptionOutputAsXml ? HtmlDocument.HtmlEncodeWithCompatibility(text2, this._ownerdocument.BackwardCompatibility) : text2);
                        return;
                    }
                default:
                    return;
            }
        }

        // Token: 0x0600013C RID: 316 RVA: 0x0000A47C File Offset: 0x0000867C
        public void WriteTo(XmlWriter writer)
        {
            switch (this._nodetype)
            {
                case HtmlNodeType.Document:
                    writer.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"" + this._ownerdocument.GetOutEncoding().BodyName + "\"");
                    if (!this.HasChildNodes)
                    {
                        return;
                    }
                    using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>)this.ChildNodes).GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            HtmlNode htmlNode = enumerator.Current;
                            htmlNode.WriteTo(writer);
                        }
                        return;
                    }
                    break;
                case HtmlNodeType.Element:
                    {
                        string localName = this._ownerdocument.OptionOutputUpperCase ? this.Name.ToUpperInvariant() : this.Name;
                        if (this._ownerdocument.OptionOutputOriginalCase)
                        {
                            localName = this.OriginalName;
                        }
                        writer.WriteStartElement(localName);
                        HtmlNode.WriteAttributes(writer, this);
                        if (this.HasChildNodes)
                        {
                            foreach (HtmlNode htmlNode2 in ((IEnumerable<HtmlNode>)this.ChildNodes))
                            {
                                htmlNode2.WriteTo(writer);
                            }
                        }
                        writer.WriteEndElement();
                        return;
                    }
                case HtmlNodeType.Comment:
                    writer.WriteComment(HtmlNode.GetXmlComment((HtmlCommentNode)this));
                    return;
                case HtmlNodeType.Text:
                    break;
                default:
                    return;
            }
            string text = ((HtmlTextNode)this).Text;
            writer.WriteString(text);
        }

        // Token: 0x0600013D RID: 317 RVA: 0x0000A5D0 File Offset: 0x000087D0
        public string WriteTo()
        {
            string result;
            using (StringWriter stringWriter = new StringWriter())
            {
                this.WriteTo(stringWriter, 0);
                stringWriter.Flush();
                result = stringWriter.ToString();
            }
            return result;
        }

        // Token: 0x0600013E RID: 318 RVA: 0x0000A618 File Offset: 0x00008818
        public void SetParent(HtmlNode parent)
        {
            if (parent == null)
            {
                return;
            }
            this.ParentNode = parent;
            if (this.OwnerDocument.OptionMaxNestedChildNodes > 0)
            {
                this.Depth = parent.Depth + 1;
                if (this.Depth > this.OwnerDocument.OptionMaxNestedChildNodes)
                {
                    throw new Exception(string.Format("Document has more than {0} nested tags. This is likely due to the page not closing tags properly.", this.OwnerDocument.OptionMaxNestedChildNodes));
                }
            }
        }

        // Token: 0x0600013F RID: 319 RVA: 0x0000A67F File Offset: 0x0000887F
        internal void SetChanged()
        {
            this._changed = true;
            if (this.ParentNode != null)
            {
                this.ParentNode.SetChanged();
            }
        }

        // Token: 0x06000140 RID: 320 RVA: 0x0000A69B File Offset: 0x0000889B
        private void UpdateHtml()
        {
            this._innerhtml = this.WriteContentTo();
            this._outerhtml = this.WriteTo();
            this._changed = false;
        }

        // Token: 0x06000141 RID: 321 RVA: 0x0000A6BC File Offset: 0x000088BC
        internal static string GetXmlComment(HtmlCommentNode comment)
        {
            string comment2 = comment.Comment;
            return comment2.Substring(4, comment2.Length - 7).Replace("--", " - -");
        }

        // Token: 0x06000142 RID: 322 RVA: 0x0000A6F0 File Offset: 0x000088F0
        internal static void WriteAttributes(XmlWriter writer, HtmlNode node)
        {
            if (!node.HasAttributes)
            {
                return;
            }
            foreach (HtmlAttribute htmlAttribute in node.Attributes.Hashitems.Values)
            {
                writer.WriteAttributeString(htmlAttribute.XmlName, htmlAttribute.Value);
            }
        }

        // Token: 0x06000143 RID: 323 RVA: 0x0000A764 File Offset: 0x00008964
        internal void UpdateLastNode()
        {
            HtmlNode htmlNode = null;
            if (this._prevwithsamename == null || !this._prevwithsamename._starttag)
            {
                if (this._ownerdocument.Openednodes == null)
                {
                    goto IL_EC;
                }
                using (Dictionary<int, HtmlNode>.Enumerator enumerator = this._ownerdocument.Openednodes.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        KeyValuePair<int, HtmlNode> keyValuePair = enumerator.Current;
                        if ((keyValuePair.Key < this._outerstartindex || keyValuePair.Key > this._outerstartindex + this._outerlength) && keyValuePair.Value._name == this._name)
                        {
                            if (htmlNode == null && keyValuePair.Value._starttag)
                            {
                                htmlNode = keyValuePair.Value;
                            }
                            else if (htmlNode != null && htmlNode.InnerStartIndex < keyValuePair.Key && keyValuePair.Value._starttag)
                            {
                                htmlNode = keyValuePair.Value;
                            }
                        }
                    }
                    goto IL_EC;
                }
            }
            htmlNode = this._prevwithsamename;
        IL_EC:
            if (htmlNode != null)
            {
                this._ownerdocument.Lastnodes[htmlNode.Name] = htmlNode;
            }
        }

        // Token: 0x06000144 RID: 324 RVA: 0x0000A888 File Offset: 0x00008A88
        internal void CloseNode(HtmlNode endnode, int level = 0)
        {
            if (level > HtmlDocument.MaxDepthLevel)
            {
                throw new ArgumentException("The document is too complex to parse");
            }
            if (!this._ownerdocument.OptionAutoCloseOnEnd && this._childnodes != null)
            {
                foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this._childnodes))
                {
                    if (!htmlNode.Closed)
                    {
                        HtmlNode htmlNode2 = new HtmlNode(this.NodeType, this._ownerdocument, -1);
                        htmlNode2._endnode = htmlNode2;
                        htmlNode.CloseNode(htmlNode2, level + 1);
                    }
                }
            }
            if (!this.Closed)
            {
                this._endnode = endnode;
                if (this._ownerdocument.Openednodes != null)
                {
                    this._ownerdocument.Openednodes.Remove(this._outerstartindex);
                }
                if (Utilities.GetDictionaryValueOrDefault<string, HtmlNode>(this._ownerdocument.Lastnodes, this.Name, null) == this)
                {
                    this._ownerdocument.Lastnodes.Remove(this.Name);
                    this._ownerdocument.UpdateLastParentNode();
                    if (this._starttag && !string.IsNullOrEmpty(this.Name))
                    {
                        this.UpdateLastNode();
                    }
                }
                if (endnode == this)
                {
                    return;
                }
                this._innerstartindex = this._outerstartindex + this._outerlength;
                this._innerlength = endnode._outerstartindex - this._innerstartindex;
                this._outerlength = endnode._outerstartindex + endnode._outerlength - this._outerstartindex;
            }
        }

        // Token: 0x06000145 RID: 325 RVA: 0x0000A9F4 File Offset: 0x00008BF4
        internal string GetId()
        {
            HtmlAttribute htmlAttribute = this.Attributes["id"];
            if (htmlAttribute != null)
            {
                return htmlAttribute.Value;
            }
            return string.Empty;
        }

        // Token: 0x06000146 RID: 326 RVA: 0x0000AA24 File Offset: 0x00008C24
        internal void SetId(string id)
        {
            HtmlAttribute htmlAttribute = this.Attributes["id"] ?? this._ownerdocument.CreateAttribute("id");
            htmlAttribute.Value = id;
            this._ownerdocument.SetIdForNode(this, htmlAttribute.Value);
            this.Attributes["id"] = htmlAttribute;
            this.SetChanged();
        }

        // Token: 0x06000147 RID: 327 RVA: 0x0000AA88 File Offset: 0x00008C88
        internal void WriteAttribute(TextWriter outText, HtmlAttribute att)
        {
            if (att.Value == null)
            {
                return;
            }
            AttributeValueQuote attributeValueQuote = this.OwnerDocument.GlobalAttributeValueQuote ?? att.QuoteType;
            bool flag = attributeValueQuote == AttributeValueQuote.WithoutValue || (attributeValueQuote == AttributeValueQuote.Initial && att._isFromParse && !att._hasEqual && string.IsNullOrEmpty(att.XmlValue));
            if (attributeValueQuote == AttributeValueQuote.Initial && (!att._isFromParse || att._hasEqual || !string.IsNullOrEmpty(att.XmlValue)))
            {
                attributeValueQuote = att.InternalQuoteType;
            }
            string text = (attributeValueQuote == AttributeValueQuote.DoubleQuote) ? "\"" : ((attributeValueQuote == AttributeValueQuote.SingleQuote) ? "'" : "");
            if (this._ownerdocument.OptionOutputAsXml)
            {
                string text2 = this._ownerdocument.OptionOutputUpperCase ? att.XmlName.ToUpperInvariant() : att.XmlName;
                if (this._ownerdocument.OptionOutputOriginalCase)
                {
                    text2 = att.OriginalName;
                }
                if (!flag)
                {
                    outText.Write(string.Concat(new string[]
                    {
                        " ",
                        text2,
                        "=",
                        text,
                        HtmlDocument.HtmlEncodeWithCompatibility(att.XmlValue, this._ownerdocument.BackwardCompatibility),
                        text
                    }));
                    return;
                }
                outText.Write(" " + text2);
                return;
            }
            else
            {
                string text2 = this._ownerdocument.OptionOutputUpperCase ? att.Name.ToUpperInvariant() : att.Name;
                if (this._ownerdocument.OptionOutputOriginalCase)
                {
                    text2 = att.OriginalName;
                }
                if (att.Name.Length >= 4 && att.Name[0] == '<' && att.Name[1] == '%' && att.Name[att.Name.Length - 1] == '>' && att.Name[att.Name.Length - 2] == '%')
                {
                    outText.Write(" " + text2);
                    return;
                }
                if (flag)
                {
                    outText.Write(" " + text2);
                    return;
                }
                string text3 = (attributeValueQuote == AttributeValueQuote.DoubleQuote) ? ((!att.Value.StartsWith("@")) ? att.Value.Replace("\"", "&quot;") : att.Value) : ((attributeValueQuote == AttributeValueQuote.SingleQuote) ? att.Value.Replace("'", "&#39;") : att.Value);
                if (!this._ownerdocument.OptionOutputOptimizeAttributeValues)
                {
                    outText.Write(string.Concat(new string[]
                    {
                        " ",
                        text2,
                        "=",
                        text,
                        text3,
                        text
                    }));
                    return;
                }
                if (att.Value.IndexOfAny(new char[]
                {
                    '\n',
                    '\r',
                    '\t',
                    ' '
                }) < 0)
                {
                    outText.Write(" " + text2 + "=" + att.Value);
                    return;
                }
                outText.Write(string.Concat(new string[]
                {
                    " ",
                    text2,
                    "=",
                    text,
                    text3,
                    text
                }));
                return;
            }
        }

        // Token: 0x06000148 RID: 328 RVA: 0x0000AD9C File Offset: 0x00008F9C
        internal void WriteAttributes(TextWriter outText, bool closing)
        {
            if (!this._ownerdocument.OptionOutputAsXml)
            {
                if (!closing)
                {
                    if (this._attributes != null)
                    {
                        foreach (HtmlAttribute att in ((IEnumerable<HtmlAttribute>)this._attributes))
                        {
                            this.WriteAttribute(outText, att);
                        }
                    }
                    if (!this._ownerdocument.OptionAddDebuggingAttributes)
                    {
                        return;
                    }
                    this.WriteAttribute(outText, this._ownerdocument.CreateAttribute("_closed", this.Closed.ToString()));
                    this.WriteAttribute(outText, this._ownerdocument.CreateAttribute("_children", this.ChildNodes.Count.ToString()));
                    int num = 0;
                    using (IEnumerator<HtmlNode> enumerator2 = ((IEnumerable<HtmlNode>)this.ChildNodes).GetEnumerator())
                    {
                        while (enumerator2.MoveNext())
                        {
                            HtmlNode htmlNode = enumerator2.Current;
                            this.WriteAttribute(outText, this._ownerdocument.CreateAttribute("_child_" + num.ToString(), htmlNode.Name));
                            num++;
                        }
                        return;
                    }
                }
                if (this._endnode == null || this._endnode._attributes == null || this._endnode == this)
                {
                    return;
                }
                foreach (HtmlAttribute att2 in ((IEnumerable<HtmlAttribute>)this._endnode._attributes))
                {
                    this.WriteAttribute(outText, att2);
                }
                if (!this._ownerdocument.OptionAddDebuggingAttributes)
                {
                    return;
                }
                this.WriteAttribute(outText, this._ownerdocument.CreateAttribute("_closed", this.Closed.ToString()));
                this.WriteAttribute(outText, this._ownerdocument.CreateAttribute("_children", this.ChildNodes.Count.ToString()));
                return;
            }
            if (this._attributes == null)
            {
                return;
            }
            foreach (HtmlAttribute att3 in this._attributes.Hashitems.Values)
            {
                this.WriteAttribute(outText, att3);
            }
        }

        // Token: 0x06000149 RID: 329 RVA: 0x0000AFF0 File Offset: 0x000091F0
        private string GetRelativeXpath()
        {
            if (this.ParentNode == null)
            {
                return this.Name;
            }
            if (this.NodeType == HtmlNodeType.Document)
            {
                return string.Empty;
            }
            int num = 1;
            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ParentNode.ChildNodes))
            {
                if (!(htmlNode.Name != this.Name))
                {
                    if (htmlNode == this)
                    {
                        break;
                    }
                    num++;
                }
            }
            return this.Name + "[" + num.ToString() + "]";
        }

        // Token: 0x0600014A RID: 330 RVA: 0x0000B094 File Offset: 0x00009294
        private bool IsSingleElementNode()
        {
            int num = 0;
            for (HtmlNode htmlNode = this.FirstChild; htmlNode != null; htmlNode = htmlNode.NextSibling)
            {
                if (htmlNode.NodeType == HtmlNodeType.Element && htmlNode.OuterHtml != "\r\n")
                {
                    num++;
                }
            }
            return num <= 1;
        }

        // Token: 0x0600014B RID: 331 RVA: 0x0000B0DC File Offset: 0x000092DC
        public void AddClass(string name)
        {
            this.AddClass(name, false);
        }

        // Token: 0x0600014C RID: 332 RVA: 0x0000B0E8 File Offset: 0x000092E8
        public void AddClass(string name, bool throwError)
        {
            IEnumerable<HtmlAttribute> enumerable = this.Attributes.AttributesWithName("class");
            if (!this.IsEmpty(enumerable))
            {
                using (IEnumerator<HtmlAttribute> enumerator = enumerable.GetEnumerator())
                {
                    Func<string, bool> h = null;
                    while (enumerator.MoveNext())
                    {
                        HtmlAttribute htmlAttribute = enumerator.Current;
                        if (htmlAttribute.Value != null)
                        {
                            IEnumerable<string> source = htmlAttribute.Value.Split(new char[]
                            {
                                ' '
                            }).ToList<string>();
                            Func<string, bool> predicate;
                            predicate = (h = ((string x) => x.Equals(name)));
                            if (source.Any(predicate))
                            {
                                if (throwError)
                                {
                                    throw new Exception(HtmlDocument.HtmlExceptionClassExists);
                                }
                                continue;
                            }
                        }
                        this.SetAttributeValue(htmlAttribute.Name, htmlAttribute.Value + " " + name);
                    }
                    return;
                }
            }
            HtmlAttribute newAttribute = this._ownerdocument.CreateAttribute("class", name);
            this.Attributes.Append(newAttribute);
        }

        // Token: 0x0600014D RID: 333 RVA: 0x0000B1FC File Offset: 0x000093FC
        public void RemoveClass()
        {
            this.RemoveClass(false);
        }

        // Token: 0x0600014E RID: 334 RVA: 0x0000B208 File Offset: 0x00009408
        public void RemoveClass(bool throwError)
        {
            IEnumerable<HtmlAttribute> enumerable = this.Attributes.AttributesWithName("class");
            if (this.IsEmpty(enumerable) && throwError)
            {
                throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
            }
            foreach (HtmlAttribute attribute in enumerable)
            {
                this.Attributes.Remove(attribute);
            }
        }

        // Token: 0x0600014F RID: 335 RVA: 0x0000B27C File Offset: 0x0000947C
        public void RemoveClass(string name)
        {
            this.RemoveClass(name, false);
        }

        // Token: 0x06000150 RID: 336 RVA: 0x0000B288 File Offset: 0x00009488
        public void RemoveClass(string name, bool throwError)
        {
            IEnumerable<HtmlAttribute> enumerable = this.Attributes.AttributesWithName("class");
            if (this.IsEmpty(enumerable) && throwError)
            {
                throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
            }
            Func<string, bool> h;
            foreach (HtmlAttribute htmlAttribute in enumerable)
            {
                if (htmlAttribute.Value != null)
                {
                    if (htmlAttribute.Value.Equals(name))
                    {
                        this.Attributes.Remove(htmlAttribute);
                    }
                    else
                    {
                        if (htmlAttribute.Value != null)
                        {
                            IEnumerable<string> source = htmlAttribute.Value.Split(new char[]
                            {
                                ' '
                            }).ToList<string>();
                            Func<string, bool> predicate;
                            predicate = (h = ((string x) => x.Equals(name)));
                            if (source.Any(predicate))
                            {
                                string[] array = htmlAttribute.Value.Split(new char[]
                                {
                                    ' '
                                });
                                string text = "";
                                foreach (string text2 in array)
                                {
                                    if (!text2.Equals(name))
                                    {
                                        text = text + text2 + " ";
                                    }
                                }
                                text = text.Trim();
                                this.SetAttributeValue(htmlAttribute.Name, text);
                                goto IL_144;
                            }
                        }
                        if (throwError)
                        {
                            throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
                        }
                    }
                IL_144:
                    if (string.IsNullOrEmpty(htmlAttribute.Value))
                    {
                        this.Attributes.Remove(htmlAttribute);
                    }
                }
            }
        }

        // Token: 0x06000151 RID: 337 RVA: 0x0000B428 File Offset: 0x00009628
        public void ReplaceClass(string newClass, string oldClass)
        {
            this.ReplaceClass(newClass, oldClass, false);
        }

        // Token: 0x06000152 RID: 338 RVA: 0x0000B434 File Offset: 0x00009634
        public void ReplaceClass(string newClass, string oldClass, bool throwError)
        {
            if (string.IsNullOrEmpty(newClass))
            {
                this.RemoveClass(oldClass);
            }
            if (string.IsNullOrEmpty(oldClass))
            {
                this.AddClass(newClass);
            }
            IEnumerable<HtmlAttribute> enumerable = this.Attributes.AttributesWithName("class");
            if (this.IsEmpty(enumerable) && throwError)
            {
                throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
            }
            foreach (HtmlAttribute htmlAttribute in enumerable)
            {
                if (htmlAttribute.Value != null)
                {
                    if (htmlAttribute.Value.Equals(oldClass) || htmlAttribute.Value.Contains(oldClass))
                    {
                        string value = htmlAttribute.Value.Replace(oldClass, newClass);
                        this.SetAttributeValue(htmlAttribute.Name, value);
                    }
                    else if (throwError)
                    {
                        throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
                    }
                }
            }
        }

        // Token: 0x06000153 RID: 339 RVA: 0x0000B50C File Offset: 0x0000970C
        public IEnumerable<string> GetClasses()
        {
            IEnumerable<HtmlAttribute> enumerable = this.Attributes.AttributesWithName("class");
            foreach (HtmlAttribute htmlAttribute in enumerable)
            {
                string[] array = htmlAttribute.Value.Split(string.Empty, StringSplitOptions.RemoveEmptyEntries);
                foreach (string text in array)
                {
                    yield return text;
                }
                string[] array2 = null;
            }
            IEnumerator<HtmlAttribute> enumerator = null;
            yield break;
            yield break;
        }

        // Token: 0x06000154 RID: 340 RVA: 0x0000B51C File Offset: 0x0000971C
        public bool HasClass(string className)
        {
            foreach (string text in this.GetClasses())
            {
                string[] array = text.Split(string.Empty, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == className)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Token: 0x06000155 RID: 341 RVA: 0x0000B58C File Offset: 0x0000978C
        private bool IsEmpty(IEnumerable en)
        {
            IEnumerator enumerator = en.GetEnumerator();
            {
                if (enumerator.MoveNext())
                {
                    object obj = enumerator.Current;
                    return false;
                }
            }
            return true;
        }

        // Token: 0x06000156 RID: 342 RVA: 0x0000B5DC File Offset: 0x000097DC
        public T GetEncapsulatedData<T>()
        {
            return (T)((object)this.GetEncapsulatedData(typeof(T), null));
        }

        // Token: 0x06000157 RID: 343 RVA: 0x0000B5F4 File Offset: 0x000097F4
        public T GetEncapsulatedData<T>(HtmlDocument htmlDocument)
        {
            return (T)((object)this.GetEncapsulatedData(typeof(T), htmlDocument));
        }

        // Token: 0x06000158 RID: 344 RVA: 0x0000B60C File Offset: 0x0000980C
        public object GetEncapsulatedData(Type targetType, HtmlDocument htmlDocument = null)
        {
            if (targetType == null)
            {
                throw new ArgumentNullException("Parameter targetType is null");
            }
            HtmlDocument htmlDocument2;
            if (htmlDocument == null)
            {
                htmlDocument2 = this.OwnerDocument;
            }
            else
            {
                htmlDocument2 = htmlDocument;
            }
            if (!targetType.IsInstantiable())
            {
                throw new MissingMethodException("Parameterless Constructor excpected for " + targetType.FullName);
            }
            object obj = Activator.CreateInstance(targetType);
            if (!targetType.IsDefinedAttribute(typeof(HasXPathAttribute)))
            {
                throw new MissingXPathException("Type T must define HasXPath attribute and include properties with XPath attribute.");
            }
            IEnumerable<PropertyInfo> propertiesDefinedXPath = targetType.GetPropertiesDefinedXPath();
            if (propertiesDefinedXPath.CountOfIEnumerable<PropertyInfo>() == 0)
            {
                throw new MissingXPathException("Type " + targetType.FullName + " defined HasXPath Attribute but it does not have any property with XPath Attribte.");
            }
            foreach (PropertyInfo propertyInfo in propertiesDefinedXPath)
            {
                XPathAttribute xpathAttribute = ((IList)propertyInfo.GetCustomAttributes(typeof(XPathAttribute), false))[0] as XPathAttribute;
                if (!propertyInfo.IsIEnumerable())
                {
                    HtmlNode htmlNode = null;
                    try
                    {
                        htmlNode = htmlDocument2.DocumentNode.SelectSingleNode(xpathAttribute.XPath);
                    }
                    catch (XPathException ex)
                    {
                        throw new XPathException(string.Concat(new string[]
                        {
                            ex.Message,
                            " That means you have a syntax error in XPath property of this Property : ",
                            propertyInfo.PropertyType.FullName,
                            " ",
                            propertyInfo.Name
                        }));
                    }
                    catch (Exception inner)
                    {
                        throw new NodeNotFoundException("Cannot find node with giving XPath to bind to " + propertyInfo.PropertyType.FullName + " " + propertyInfo.Name, inner);
                    }
                    if (htmlNode == null)
                    {
                        if (!propertyInfo.IsDefined(typeof(SkipNodeNotFoundAttribute), false))
                        {
                            throw new NodeNotFoundException("Cannot find node with giving XPath to bind to " + propertyInfo.PropertyType.FullName + " " + propertyInfo.Name);
                        }
                    }
                    else if (propertyInfo.PropertyType.IsDefinedAttribute(typeof(HasXPathAttribute)))
                    {
                        HtmlDocument htmlDocument3 = new HtmlDocument();
                        htmlDocument3.LoadHtml(Tools.GetHtmlForEncapsulation(htmlNode, xpathAttribute.IsNodeReturnTypeExplicitlySet ? xpathAttribute.NodeReturnType : ReturnType.InnerHtml));
                        object encapsulatedData = this.GetEncapsulatedData(propertyInfo.PropertyType, htmlDocument3);
                        propertyInfo.SetValue(obj, encapsulatedData, null);
                    }
                    else
                    {
                        string text = string.Empty;
                        if (xpathAttribute.AttributeName == null)
                        {
                            text = Tools.GetNodeValueBasedOnXPathReturnType<string>(htmlNode, xpathAttribute);
                        }
                        else
                        {
                            HtmlNode.ThrowIfNodeReturnTypeIsExplicitlySetWhenAttributeNameIsGiven(xpathAttribute);
                            text = htmlNode.GetAttributeValue(xpathAttribute.AttributeName, null);
                        }
                        if (text == null)
                        {
                            throw new NodeAttributeNotFoundException(string.Concat(new string[]
                            {
                                "Can not find ",
                                xpathAttribute.AttributeName,
                                " Attribute in ",
                                htmlNode.Name,
                                " related to ",
                                propertyInfo.PropertyType.FullName,
                                " ",
                                propertyInfo.Name
                            }));
                        }
                        object value;
                        try
                        {
                            value = Convert.ChangeType(text, propertyInfo.PropertyType);
                        }
                        catch (FormatException)
                        {
                            throw new FormatException("Can not convert Invalid string to " + propertyInfo.PropertyType.FullName + " " + propertyInfo.Name);
                        }
                        catch (Exception ex2)
                        {
                            throw new Exception("Unhandled Exception : " + ex2.Message);
                        }
                        propertyInfo.SetValue(obj, value, null);
                    }
                }
                else
                {
                    IList<Type> list = propertyInfo.GetGenericTypes() as IList<Type>;
                    if (list == null || list.Count == 0)
                    {
                        throw new ArgumentException(propertyInfo.Name + " should have one generic argument.");
                    }
                    if (list.Count > 1)
                    {
                        throw new ArgumentException(propertyInfo.Name + " should have one generic argument.");
                    }
                    if (list.Count == 1)
                    {
                        HtmlNodeCollection htmlNodeCollection;
                        try
                        {
                            htmlNodeCollection = htmlDocument2.DocumentNode.SelectNodes(xpathAttribute.XPath);
                        }
                        catch (XPathException ex3)
                        {
                            throw new XPathException(string.Concat(new string[]
                            {
                                ex3.Message,
                                " That means you have a syntax error in XPath property of this Property : ",
                                propertyInfo.PropertyType.FullName,
                                " ",
                                propertyInfo.Name
                            }));
                        }
                        catch (Exception inner2)
                        {
                            throw new NodeNotFoundException("Cannot find node with giving XPath to bind to " + propertyInfo.PropertyType.FullName + " " + propertyInfo.Name, inner2);
                        }
                        if (htmlNodeCollection != null && htmlNodeCollection.Count != 0)
                        {
                            IList list2 = list[0].CreateIListOfType();
                            if (list[0].IsDefinedAttribute(typeof(HasXPathAttribute)))
                            {
                                using (IEnumerator<HtmlNode> enumerator2 = ((IEnumerable<HtmlNode>)htmlNodeCollection).GetEnumerator())
                                {
                                    while (enumerator2.MoveNext())
                                    {
                                        HtmlNode node = enumerator2.Current;
                                        HtmlDocument htmlDocument4 = new HtmlDocument();
                                        htmlDocument4.LoadHtml(Tools.GetHtmlForEncapsulation(node, xpathAttribute.IsNodeReturnTypeExplicitlySet ? xpathAttribute.NodeReturnType : ReturnType.InnerHtml));
                                        object encapsulatedData2 = this.GetEncapsulatedData(list[0], htmlDocument4);
                                        list2.Add(encapsulatedData2);
                                    }
                                    goto IL_62E;
                                }
                                goto IL_4BE;
                            }
                            goto IL_4BE;
                        IL_62E:
                            if (list2 == null || list2.Count == 0)
                            {
                                throw new Exception(string.Concat(new string[]
                                {
                                    "Cannot fill ",
                                    propertyInfo.PropertyType.FullName,
                                    " ",
                                    propertyInfo.Name,
                                    " because it is null."
                                }));
                            }
                            propertyInfo.SetValue(obj, list2, null);
                            continue;
                        IL_4BE:
                            if (xpathAttribute.AttributeName == null)
                            {
                                try
                                {
                                    list2 = Tools.GetNodesValuesBasedOnXPathReturnType(htmlNodeCollection, xpathAttribute, list[0]);
                                    goto IL_62E;
                                }
                                catch (FormatException)
                                {
                                    throw new FormatException("Can not convert Invalid string in node collection to " + list[0].FullName + " " + propertyInfo.Name);
                                }
                                catch (Exception ex4)
                                {
                                    throw new Exception("Unhandled Exception : " + ex4.Message);
                                }
                            }
                            HtmlNode.ThrowIfNodeReturnTypeIsExplicitlySetWhenAttributeNameIsGiven(xpathAttribute);
                            foreach (HtmlNode htmlNode2 in ((IEnumerable<HtmlNode>)htmlNodeCollection))
                            {
                                string attributeValue = htmlNode2.GetAttributeValue(xpathAttribute.AttributeName, null);
                                if (attributeValue == null)
                                {
                                    throw new NodeAttributeNotFoundException(string.Concat(new string[]
                                    {
                                        "Can not find ",
                                        xpathAttribute.AttributeName,
                                        " Attribute in ",
                                        htmlNode2.Name,
                                        " related to ",
                                        propertyInfo.PropertyType.FullName,
                                        " ",
                                        propertyInfo.Name
                                    }));
                                }
                                object value2;
                                try
                                {
                                    value2 = Convert.ChangeType(attributeValue, list[0]);
                                }
                                catch (FormatException)
                                {
                                    throw new FormatException("Can not convert Invalid string to " + list[0].FullName + " " + propertyInfo.Name);
                                }
                                catch (Exception ex5)
                                {
                                    throw new Exception("Unhandled Exception : " + ex5.Message);
                                }
                                list2.Add(value2);
                            }
                            goto IL_62E;
                        }
                        if (!propertyInfo.IsDefined(typeof(SkipNodeNotFoundAttribute), false))
                        {
                            throw new NodeNotFoundException("Cannot find node with giving XPath to bind to " + propertyInfo.PropertyType.FullName + " " + propertyInfo.Name);
                        }
                    }
                }
            }
            return obj;
        }

        // Token: 0x06000159 RID: 345 RVA: 0x0000BE00 File Offset: 0x0000A000
        private static void ThrowIfNodeReturnTypeIsExplicitlySetWhenAttributeNameIsGiven(XPathAttribute xPathAttr)
        {
            if (xPathAttr.IsNodeReturnTypeExplicitlySet && !string.IsNullOrEmpty(xPathAttr.AttributeName))
            {
                throw new InvalidNodeReturnTypeException("Specifying a ReturnType value not allowed for XPathAttribute annotations targeting element attributes");
            }
        }

        // Token: 0x0600015A RID: 346 RVA: 0x0000BE22 File Offset: 0x0000A022
        public XPathNavigator CreateNavigator()
        {
            return new HtmlNodeNavigator(this.OwnerDocument, this);
        }

        // Token: 0x0600015B RID: 347 RVA: 0x0000BE30 File Offset: 0x0000A030
        public XPathNavigator CreateRootNavigator()
        {
            return new HtmlNodeNavigator(this.OwnerDocument, this.OwnerDocument.DocumentNode);
        }

        // Token: 0x0600015C RID: 348 RVA: 0x0000BE48 File Offset: 0x0000A048
        public HtmlNodeCollection SelectNodes(string xpath)
        {
            HtmlNodeCollection htmlNodeCollection = new HtmlNodeCollection(null);
            XPathNodeIterator xpathNodeIterator = new HtmlNodeNavigator(this.OwnerDocument, this).Select(xpath);
            while (xpathNodeIterator.MoveNext())
            {
                XPathNavigator xpathNavigator = xpathNodeIterator.Current;
                HtmlNodeNavigator htmlNodeNavigator = (HtmlNodeNavigator)xpathNavigator;
                htmlNodeCollection.Add(htmlNodeNavigator.CurrentNode, false);
            }
            if (htmlNodeCollection.Count == 0 && !this.OwnerDocument.OptionEmptyCollection)
            {
                return null;
            }
            return htmlNodeCollection;
        }

        // Token: 0x0600015D RID: 349 RVA: 0x0000BEAC File Offset: 0x0000A0AC
        public HtmlNodeCollection SelectNodes(XPathExpression xpath)
        {
            HtmlNodeCollection htmlNodeCollection = new HtmlNodeCollection(null);
            XPathNodeIterator xpathNodeIterator = new HtmlNodeNavigator(this.OwnerDocument, this).Select(xpath);
            while (xpathNodeIterator.MoveNext())
            {
                XPathNavigator xpathNavigator = xpathNodeIterator.Current;
                HtmlNodeNavigator htmlNodeNavigator = (HtmlNodeNavigator)xpathNavigator;
                htmlNodeCollection.Add(htmlNodeNavigator.CurrentNode, false);
            }
            if (htmlNodeCollection.Count == 0 && !this.OwnerDocument.OptionEmptyCollection)
            {
                return null;
            }
            return htmlNodeCollection;
        }

        // Token: 0x0600015E RID: 350 RVA: 0x0000BF10 File Offset: 0x0000A110
        public HtmlNode SelectSingleNode(string xpath)
        {
            if (xpath == null)
            {
                throw new ArgumentNullException("xpath");
            }
            XPathNodeIterator xpathNodeIterator = new HtmlNodeNavigator(this.OwnerDocument, this).Select(xpath);
            if (!xpathNodeIterator.MoveNext())
            {
                return null;
            }
            return ((HtmlNodeNavigator)xpathNodeIterator.Current).CurrentNode;
        }

        // Token: 0x0600015F RID: 351 RVA: 0x0000BF58 File Offset: 0x0000A158
        public HtmlNode SelectSingleNode(XPathExpression xpath)
        {
            if (xpath == null)
            {
                throw new ArgumentNullException("xpath");
            }
            XPathNodeIterator xpathNodeIterator = new HtmlNodeNavigator(this.OwnerDocument, this).Select(xpath);
            if (!xpathNodeIterator.MoveNext())
            {
                return null;
            }
            return ((HtmlNodeNavigator)xpathNodeIterator.Current).CurrentNode;
        }

        // Token: 0x04000063 RID: 99
        internal const string DepthLevelExceptionMessage = "The document is too complex to parse";

        // Token: 0x04000064 RID: 100
        internal HtmlAttributeCollection _attributes;

        // Token: 0x04000065 RID: 101
        internal HtmlNodeCollection _childnodes;

        // Token: 0x04000066 RID: 102
        internal HtmlNode _endnode;

        // Token: 0x04000067 RID: 103
        private bool _changed;

        // Token: 0x04000068 RID: 104
        internal string _innerhtml;

        // Token: 0x04000069 RID: 105
        internal int _innerlength;

        // Token: 0x0400006A RID: 106
        internal int _innerstartindex;

        // Token: 0x0400006B RID: 107
        internal int _line;

        // Token: 0x0400006C RID: 108
        internal int _lineposition;

        // Token: 0x0400006D RID: 109
        private string _name;

        // Token: 0x0400006E RID: 110
        internal int _namelength;

        // Token: 0x0400006F RID: 111
        internal int _namestartindex;

        // Token: 0x04000070 RID: 112
        internal HtmlNode _nextnode;

        // Token: 0x04000071 RID: 113
        internal HtmlNodeType _nodetype;

        // Token: 0x04000072 RID: 114
        internal string _outerhtml;

        // Token: 0x04000073 RID: 115
        internal int _outerlength;

        // Token: 0x04000074 RID: 116
        internal int _outerstartindex;

        // Token: 0x04000075 RID: 117
        private string _optimizedName;

        // Token: 0x04000076 RID: 118
        internal HtmlDocument _ownerdocument;

        // Token: 0x04000077 RID: 119
        internal HtmlNode _parentnode;

        // Token: 0x04000078 RID: 120
        internal HtmlNode _prevnode;

        // Token: 0x04000079 RID: 121
        internal HtmlNode _prevwithsamename;

        // Token: 0x0400007A RID: 122
        internal bool _starttag;

        // Token: 0x0400007B RID: 123
        internal int _streamposition;

        // Token: 0x0400007C RID: 124
        internal bool _isImplicitEnd;

        // Token: 0x0400007D RID: 125
        internal bool _isHideInnerText;

        // Token: 0x0400007E RID: 126
        public static readonly string HtmlNodeTypeNameComment = "#comment";

        // Token: 0x0400007F RID: 127
        public static readonly string HtmlNodeTypeNameDocument = "#document";

        // Token: 0x04000080 RID: 128
        public static readonly string HtmlNodeTypeNameText = "#text";

        // Token: 0x04000081 RID: 129
        public static Dictionary<string, HtmlElementFlag> ElementsFlags = new Dictionary<string, HtmlElementFlag>(StringComparer.OrdinalIgnoreCase);
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x02000018 RID: 24
    public class HtmlNodeCollection : IList<HtmlNode>, ICollection<HtmlNode>, IEnumerable<HtmlNode>, IEnumerable
    {
        // Token: 0x06000183 RID: 387 RVA: 0x0000C39B File Offset: 0x0000A59B
        public HtmlNodeCollection(HtmlNode parentnode)
        {
            this._parentnode = parentnode;
        }

        // Token: 0x1700004D RID: 77
        // (get) Token: 0x06000184 RID: 388 RVA: 0x0000C3B5 File Offset: 0x0000A5B5
        internal HtmlNode ParentNode
        {
            get
            {
                return this._parentnode;
            }
        }

        // Token: 0x1700004E RID: 78
        public int this[HtmlNode node]
        {
            get
            {
                int nodeIndex = this.GetNodeIndex(node);
                if (nodeIndex == -1)
                {
                    throw new ArgumentOutOfRangeException("node", "Node \"" + node.CloneNode(false).OuterHtml + "\" was not found in the collection");
                }
                return nodeIndex;
            }
        }

        // Token: 0x1700004F RID: 79
        public HtmlNode this[string nodeName]
        {
            get
            {
                for (int i = 0; i < this._items.Count; i++)
                {
                    if (string.Equals(this._items[i].Name, nodeName, StringComparison.OrdinalIgnoreCase))
                    {
                        return this._items[i];
                    }
                }
                return null;
            }
        }

        // Token: 0x17000050 RID: 80
        // (get) Token: 0x06000187 RID: 391 RVA: 0x0000C43B File Offset: 0x0000A63B
        public int Count
        {
            get
            {
                return this._items.Count;
            }
        }

        // Token: 0x17000051 RID: 81
        // (get) Token: 0x06000188 RID: 392 RVA: 0x0000C448 File Offset: 0x0000A648
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        // Token: 0x17000052 RID: 82
        public HtmlNode this[int index]
        {
            get
            {
                return this._items[index];
            }
            set
            {
                this._items[index] = value;
            }
        }

        // Token: 0x0600018B RID: 395 RVA: 0x0000C468 File Offset: 0x0000A668
        public void Add(HtmlNode node)
        {
            this.Add(node, true);
        }

        // Token: 0x0600018C RID: 396 RVA: 0x0000C472 File Offset: 0x0000A672
        public void Add(HtmlNode node, bool setParent)
        {
            this._items.Add(node);
            if (setParent)
            {
                node.ParentNode = this._parentnode;
            }
        }

        // Token: 0x0600018D RID: 397 RVA: 0x0000C490 File Offset: 0x0000A690
        public void Clear()
        {
            foreach (HtmlNode htmlNode in this._items)
            {
                htmlNode.ParentNode = null;
                htmlNode.NextSibling = null;
                htmlNode.PreviousSibling = null;
            }
            this._items.Clear();
        }

        // Token: 0x0600018E RID: 398 RVA: 0x0000C4FC File Offset: 0x0000A6FC
        public bool Contains(HtmlNode item)
        {
            return this._items.Contains(item);
        }

        // Token: 0x0600018F RID: 399 RVA: 0x0000C50A File Offset: 0x0000A70A
        public void CopyTo(HtmlNode[] array, int arrayIndex)
        {
            this._items.CopyTo(array, arrayIndex);
        }

        // Token: 0x06000190 RID: 400 RVA: 0x0000C519 File Offset: 0x0000A719
        IEnumerator<HtmlNode> IEnumerable<HtmlNode>.GetEnumerator()
        {
            return this._items.GetEnumerator();
        }

        // Token: 0x06000191 RID: 401 RVA: 0x0000C52B File Offset: 0x0000A72B
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._items.GetEnumerator();
        }

        // Token: 0x06000192 RID: 402 RVA: 0x0000C53D File Offset: 0x0000A73D
        public int IndexOf(HtmlNode item)
        {
            return this._items.IndexOf(item);
        }

        // Token: 0x06000193 RID: 403 RVA: 0x0000C54C File Offset: 0x0000A74C
        public void Insert(int index, HtmlNode node)
        {
            HtmlNode htmlNode = null;
            HtmlNode htmlNode2 = null;
            if (index > 0)
            {
                htmlNode2 = this._items[index - 1];
            }
            if (index < this._items.Count)
            {
                htmlNode = this._items[index];
            }
            this._items.Insert(index, node);
            if (htmlNode2 != null)
            {
                if (node == htmlNode2)
                {
                    throw new InvalidProgramException("Unexpected error.");
                }
                htmlNode2._nextnode = node;
            }
            if (htmlNode != null)
            {
                htmlNode._prevnode = node;
            }
            node._prevnode = htmlNode2;
            if (htmlNode == node)
            {
                throw new InvalidProgramException("Unexpected error.");
            }
            node._nextnode = htmlNode;
            node.SetParent(this._parentnode);
        }

        // Token: 0x06000194 RID: 404 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
        public bool Remove(HtmlNode item)
        {
            int index = this._items.IndexOf(item);
            this.RemoveAt(index);
            return true;
        }

        // Token: 0x06000195 RID: 405 RVA: 0x0000C608 File Offset: 0x0000A808
        public void RemoveAt(int index)
        {
            HtmlNode htmlNode = null;
            HtmlNode htmlNode2 = null;
            HtmlNode htmlNode3 = this._items[index];
            HtmlNode htmlNode4 = this._parentnode ?? htmlNode3._parentnode;
            if (index > 0)
            {
                htmlNode2 = this._items[index - 1];
            }
            if (index < this._items.Count - 1)
            {
                htmlNode = this._items[index + 1];
            }
            this._items.RemoveAt(index);
            if (htmlNode2 != null)
            {
                if (htmlNode == htmlNode2)
                {
                    throw new InvalidProgramException("Unexpected error.");
                }
                htmlNode2._nextnode = htmlNode;
            }
            if (htmlNode != null)
            {
                htmlNode._prevnode = htmlNode2;
            }
            htmlNode3._prevnode = null;
            htmlNode3._nextnode = null;
            htmlNode3._parentnode = null;
            if (htmlNode4 != null)
            {
                htmlNode4.SetChanged();
            }
        }

        // Token: 0x06000196 RID: 406 RVA: 0x0000C6B8 File Offset: 0x0000A8B8
        public static HtmlNode FindFirst(HtmlNodeCollection items, string name)
        {
            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)items))
            {
                if (htmlNode.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return htmlNode;
                }
                if (htmlNode.HasChildNodes)
                {
                    HtmlNode htmlNode2 = HtmlNodeCollection.FindFirst(htmlNode.ChildNodes, name);
                    if (htmlNode2 != null)
                    {
                        return htmlNode2;
                    }
                }
            }
            return null;
        }

        // Token: 0x06000197 RID: 407 RVA: 0x0000C72C File Offset: 0x0000A92C
        public void Append(HtmlNode node)
        {
            HtmlNode htmlNode = null;
            if (this._items.Count > 0)
            {
                htmlNode = this._items[this._items.Count - 1];
            }
            this._items.Add(node);
            node._prevnode = htmlNode;
            node._nextnode = null;
            node.SetParent(this._parentnode);
            if (htmlNode == null)
            {
                return;
            }
            if (htmlNode == node)
            {
                throw new InvalidProgramException("Unexpected error.");
            }
            htmlNode._nextnode = node;
        }

        // Token: 0x06000198 RID: 408 RVA: 0x0000C7A2 File Offset: 0x0000A9A2
        public HtmlNode FindFirst(string name)
        {
            return HtmlNodeCollection.FindFirst(this, name);
        }

        // Token: 0x06000199 RID: 409 RVA: 0x0000C7AC File Offset: 0x0000A9AC
        public int GetNodeIndex(HtmlNode node)
        {
            for (int i = 0; i < this._items.Count; i++)
            {
                if (node == this._items[i])
                {
                    return i;
                }
            }
            return -1;
        }

        // Token: 0x0600019A RID: 410 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
        public void Prepend(HtmlNode node)
        {
            HtmlNode htmlNode = null;
            if (this._items.Count > 0)
            {
                htmlNode = this._items[0];
            }
            this._items.Insert(0, node);
            if (node == htmlNode)
            {
                throw new InvalidProgramException("Unexpected error.");
            }
            node._nextnode = htmlNode;
            node._prevnode = null;
            node.SetParent(this._parentnode);
            if (htmlNode != null)
            {
                htmlNode._prevnode = node;
            }
        }

        // Token: 0x0600019B RID: 411 RVA: 0x0000C84E File Offset: 0x0000AA4E
        public bool Remove(int index)
        {
            this.RemoveAt(index);
            return true;
        }

        // Token: 0x0600019C RID: 412 RVA: 0x0000C858 File Offset: 0x0000AA58
        public void Replace(int index, HtmlNode node)
        {
            HtmlNode htmlNode = null;
            HtmlNode htmlNode2 = null;
            HtmlNode htmlNode3 = this._items[index];
            if (index > 0)
            {
                htmlNode2 = this._items[index - 1];
            }
            if (index < this._items.Count - 1)
            {
                htmlNode = this._items[index + 1];
            }
            this._items[index] = node;
            if (htmlNode2 != null)
            {
                if (node == htmlNode2)
                {
                    throw new InvalidProgramException("Unexpected error.");
                }
                htmlNode2._nextnode = node;
            }
            if (htmlNode != null)
            {
                htmlNode._prevnode = node;
            }
            node._prevnode = htmlNode2;
            if (htmlNode == node)
            {
                throw new InvalidProgramException("Unexpected error.");
            }
            node._nextnode = htmlNode;
            node.SetParent(this._parentnode);
            htmlNode3._prevnode = null;
            htmlNode3._nextnode = null;
            htmlNode3._parentnode = null;
        }

        // Token: 0x0600019D RID: 413 RVA: 0x0000C914 File Offset: 0x0000AB14
        public IEnumerable<HtmlNode> Descendants()
        {
            foreach (HtmlNode htmlNode in this._items)
            {
                foreach (HtmlNode htmlNode2 in htmlNode.Descendants())
                {
                    yield return htmlNode2;
                }
                IEnumerator<HtmlNode> enumerator2 = null;
            }
            List<HtmlNode>.Enumerator enumerator = default(List<HtmlNode>.Enumerator);
            yield break;
            yield break;
        }

        // Token: 0x0600019E RID: 414 RVA: 0x0000C924 File Offset: 0x0000AB24
        public IEnumerable<HtmlNode> Descendants(string name)
        {
            foreach (HtmlNode htmlNode in this._items)
            {
                foreach (HtmlNode htmlNode2 in htmlNode.Descendants(name))
                {
                    yield return htmlNode2;
                }
                IEnumerator<HtmlNode> enumerator2 = null;
            }
            List<HtmlNode>.Enumerator enumerator = default(List<HtmlNode>.Enumerator);
            yield break;
            yield break;
        }

        // Token: 0x0600019F RID: 415 RVA: 0x0000C93B File Offset: 0x0000AB3B
        public IEnumerable<HtmlNode> Elements()
        {
            foreach (HtmlNode htmlNode in this._items)
            {
                foreach (HtmlNode htmlNode2 in ((IEnumerable<HtmlNode>)htmlNode.ChildNodes))
                {
                    yield return htmlNode2;
                }
                IEnumerator<HtmlNode> enumerator2 = null;
            }
            List<HtmlNode>.Enumerator enumerator = default(List<HtmlNode>.Enumerator);
            yield break;
            yield break;
        }

        // Token: 0x060001A0 RID: 416 RVA: 0x0000C94B File Offset: 0x0000AB4B
        public IEnumerable<HtmlNode> Elements(string name)
        {
            foreach (HtmlNode htmlNode in this._items)
            {
                foreach (HtmlNode htmlNode2 in htmlNode.Elements(name))
                {
                    yield return htmlNode2;
                }
                IEnumerator<HtmlNode> enumerator2 = null;
            }
            List<HtmlNode>.Enumerator enumerator = default(List<HtmlNode>.Enumerator);
            yield break;
            yield break;
        }

        // Token: 0x060001A1 RID: 417 RVA: 0x0000C962 File Offset: 0x0000AB62
        public IEnumerable<HtmlNode> Nodes()
        {
            foreach (HtmlNode htmlNode in this._items)
            {
                foreach (HtmlNode htmlNode2 in ((IEnumerable<HtmlNode>)htmlNode.ChildNodes))
                {
                    yield return htmlNode2;
                }
                IEnumerator<HtmlNode> enumerator2 = null;
            }
            List<HtmlNode>.Enumerator enumerator = default(List<HtmlNode>.Enumerator);
            yield break;
            yield break;
        }

        // Token: 0x0400008B RID: 139
        private readonly HtmlNode _parentnode;

        // Token: 0x0400008C RID: 140
        private readonly List<HtmlNode> _items = new List<HtmlNode>();
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x02000019 RID: 25
    public class HtmlNodeNavigator : XPathNavigator
    {
        // Token: 0x060001A2 RID: 418 RVA: 0x0000C972 File Offset: 0x0000AB72
        internal HtmlNodeNavigator()
        {
            this._doc = new HtmlDocument();
            this._nametable = new HtmlNameTable();
            this.Reset();
        }

        // Token: 0x060001A3 RID: 419 RVA: 0x0000C998 File Offset: 0x0000AB98
        internal HtmlNodeNavigator(HtmlDocument doc, HtmlNode currentNode)
        {
            if (currentNode == null)
            {
                throw new ArgumentNullException("currentNode");
            }
            if (currentNode.OwnerDocument != doc)
            {
                throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
            }
            if (doc == null)
            {
                throw new Exception("Oops! The HtmlDocument cannot be null.");
            }
            this._doc = doc;
            this._nametable = new HtmlNameTable();
            this.Reset();
            this._currentnode = currentNode;
        }

        // Token: 0x060001A4 RID: 420 RVA: 0x0000C9FC File Offset: 0x0000ABFC
        private HtmlNodeNavigator(HtmlNodeNavigator nav)
        {
            if (nav == null)
            {
                throw new ArgumentNullException("nav");
            }
            this._doc = nav._doc;
            this._currentnode = nav._currentnode;
            this._attindex = nav._attindex;
            this._nametable = nav._nametable;
        }

        // Token: 0x060001A5 RID: 421 RVA: 0x0000CA4D File Offset: 0x0000AC4D
        public HtmlNodeNavigator(Stream stream)
        {
            this._doc = new HtmlDocument();
            this._nametable = new HtmlNameTable();
            this._doc.Load(stream);
            this.Reset();
        }

        // Token: 0x060001A6 RID: 422 RVA: 0x0000CA7D File Offset: 0x0000AC7D
        public HtmlNodeNavigator(Stream stream, bool detectEncodingFromByteOrderMarks)
        {
            this._doc = new HtmlDocument();
            this._nametable = new HtmlNameTable();
            this._doc.Load(stream, detectEncodingFromByteOrderMarks);
            this.Reset();
        }

        // Token: 0x060001A7 RID: 423 RVA: 0x0000CAAE File Offset: 0x0000ACAE
        public HtmlNodeNavigator(Stream stream, Encoding encoding)
        {
            this._doc = new HtmlDocument();
            this._nametable = new HtmlNameTable();
            this._doc.Load(stream, encoding);
            this.Reset();
        }

        // Token: 0x060001A8 RID: 424 RVA: 0x0000CADF File Offset: 0x0000ACDF
        public HtmlNodeNavigator(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
        {
            this._doc = new HtmlDocument();
            this._nametable = new HtmlNameTable();
            this._doc.Load(stream, encoding, detectEncodingFromByteOrderMarks);
            this.Reset();
        }

        // Token: 0x060001A9 RID: 425 RVA: 0x0000CB11 File Offset: 0x0000AD11
        public HtmlNodeNavigator(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
        {
            this._doc = new HtmlDocument();
            this._nametable = new HtmlNameTable();
            this._doc.Load(stream, encoding, detectEncodingFromByteOrderMarks, buffersize);
            this.Reset();
        }

        // Token: 0x060001AA RID: 426 RVA: 0x0000CB45 File Offset: 0x0000AD45
        public HtmlNodeNavigator(TextReader reader)
        {
            this._doc = new HtmlDocument();
            this._nametable = new HtmlNameTable();
            this._doc.Load(reader);
            this.Reset();
        }

        // Token: 0x060001AB RID: 427 RVA: 0x0000CB75 File Offset: 0x0000AD75
        public HtmlNodeNavigator(string path)
        {
            this._doc = new HtmlDocument();
            this._nametable = new HtmlNameTable();
            this._doc.Load(path);
            this.Reset();
        }

        // Token: 0x060001AC RID: 428 RVA: 0x0000CBA5 File Offset: 0x0000ADA5
        public HtmlNodeNavigator(string path, bool detectEncodingFromByteOrderMarks)
        {
            this._doc = new HtmlDocument();
            this._nametable = new HtmlNameTable();
            this._doc.Load(path, detectEncodingFromByteOrderMarks);
            this.Reset();
        }

        // Token: 0x060001AD RID: 429 RVA: 0x0000CBD6 File Offset: 0x0000ADD6
        public HtmlNodeNavigator(string path, Encoding encoding)
        {
            this._doc = new HtmlDocument();
            this._nametable = new HtmlNameTable();
            this._doc.Load(path, encoding);
            this.Reset();
        }

        // Token: 0x060001AE RID: 430 RVA: 0x0000CC07 File Offset: 0x0000AE07
        public HtmlNodeNavigator(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
        {
            this._doc = new HtmlDocument();
            this._nametable = new HtmlNameTable();
            this._doc.Load(path, encoding, detectEncodingFromByteOrderMarks);
            this.Reset();
        }

        // Token: 0x060001AF RID: 431 RVA: 0x0000CC39 File Offset: 0x0000AE39
        public HtmlNodeNavigator(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
        {
            this._doc = new HtmlDocument();
            this._nametable = new HtmlNameTable();
            this._doc.Load(path, encoding, detectEncodingFromByteOrderMarks, buffersize);
            this.Reset();
        }

        // Token: 0x17000053 RID: 83
        // (get) Token: 0x060001B0 RID: 432 RVA: 0x0000CC6D File Offset: 0x0000AE6D
        public override string BaseURI
        {
            get
            {
                return this._nametable.GetOrAdd(string.Empty);
            }
        }

        // Token: 0x17000054 RID: 84
        // (get) Token: 0x060001B1 RID: 433 RVA: 0x0000CC7F File Offset: 0x0000AE7F
        public HtmlDocument CurrentDocument
        {
            get
            {
                return this._doc;
            }
        }

        // Token: 0x17000055 RID: 85
        // (get) Token: 0x060001B2 RID: 434 RVA: 0x0000CC87 File Offset: 0x0000AE87
        public HtmlNode CurrentNode
        {
            get
            {
                return this._currentnode;
            }
        }

        // Token: 0x17000056 RID: 86
        // (get) Token: 0x060001B3 RID: 435 RVA: 0x0000CC8F File Offset: 0x0000AE8F
        public override bool HasAttributes
        {
            get
            {
                return this._currentnode.Attributes.Count > 0;
            }
        }

        // Token: 0x17000057 RID: 87
        // (get) Token: 0x060001B4 RID: 436 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
        public override bool HasChildren
        {
            get
            {
                return this._currentnode.ChildNodes.Count > 0;
            }
        }

        // Token: 0x17000058 RID: 88
        // (get) Token: 0x060001B5 RID: 437 RVA: 0x0000CCB9 File Offset: 0x0000AEB9
        public override bool IsEmptyElement
        {
            get
            {
                return !this.HasChildren;
            }
        }

        // Token: 0x17000059 RID: 89
        // (get) Token: 0x060001B6 RID: 438 RVA: 0x0000CCC4 File Offset: 0x0000AEC4
        public override string LocalName
        {
            get
            {
                if (this._attindex != -1)
                {
                    return this._nametable.GetOrAdd(this._currentnode.Attributes[this._attindex].Name);
                }
                return this._nametable.GetOrAdd(this._currentnode.Name);
            }
        }

        // Token: 0x1700005A RID: 90
        // (get) Token: 0x060001B7 RID: 439 RVA: 0x0000CD17 File Offset: 0x0000AF17
        public override string Name
        {
            get
            {
                return this._nametable.GetOrAdd(this._currentnode.Name);
            }
        }

        // Token: 0x1700005B RID: 91
        // (get) Token: 0x060001B8 RID: 440 RVA: 0x0000CD2F File Offset: 0x0000AF2F
        public override string NamespaceURI
        {
            get
            {
                return this._nametable.GetOrAdd(string.Empty);
            }
        }

        // Token: 0x1700005C RID: 92
        // (get) Token: 0x060001B9 RID: 441 RVA: 0x0000CD41 File Offset: 0x0000AF41
        public override XmlNameTable NameTable
        {
            get
            {
                return this._nametable;
            }
        }

        // Token: 0x1700005D RID: 93
        // (get) Token: 0x060001BA RID: 442 RVA: 0x0000CD4C File Offset: 0x0000AF4C
        public override XPathNodeType NodeType
        {
            get
            {
                switch (this._currentnode.NodeType)
                {
                    case HtmlNodeType.Document:
                        return XPathNodeType.Root;
                    case HtmlNodeType.Element:
                        if (this._attindex != -1)
                        {
                            return XPathNodeType.Attribute;
                        }
                        return XPathNodeType.Element;
                    case HtmlNodeType.Comment:
                        return XPathNodeType.Comment;
                    case HtmlNodeType.Text:
                        return XPathNodeType.Text;
                    default:
                        throw new NotImplementedException("Internal error: Unhandled HtmlNodeType: " + this._currentnode.NodeType.ToString());
                }
            }
        }

        // Token: 0x1700005E RID: 94
        // (get) Token: 0x060001BB RID: 443 RVA: 0x0000CDB8 File Offset: 0x0000AFB8
        public override string Prefix
        {
            get
            {
                return this._nametable.GetOrAdd(string.Empty);
            }
        }

        // Token: 0x1700005F RID: 95
        // (get) Token: 0x060001BC RID: 444 RVA: 0x0000CDCC File Offset: 0x0000AFCC
        public override string Value
        {
            get
            {
                switch (this._currentnode.NodeType)
                {
                    case HtmlNodeType.Document:
                        return "";
                    case HtmlNodeType.Element:
                        if (this._attindex != -1)
                        {
                            return this._currentnode.Attributes[this._attindex].Value;
                        }
                        return this._currentnode.InnerText;
                    case HtmlNodeType.Comment:
                        return ((HtmlCommentNode)this._currentnode).Comment;
                    case HtmlNodeType.Text:
                        return ((HtmlTextNode)this._currentnode).Text;
                    default:
                        throw new NotImplementedException("Internal error: Unhandled HtmlNodeType: " + this._currentnode.NodeType.ToString());
                }
            }
        }

        // Token: 0x17000060 RID: 96
        // (get) Token: 0x060001BD RID: 445 RVA: 0x0000CE7E File Offset: 0x0000B07E
        public override string XmlLang
        {
            get
            {
                return this._nametable.GetOrAdd(string.Empty);
            }
        }

        // Token: 0x060001BE RID: 446 RVA: 0x0000CE90 File Offset: 0x0000B090
        public override XPathNavigator Clone()
        {
            return new HtmlNodeNavigator(this);
        }

        // Token: 0x060001BF RID: 447 RVA: 0x0000CE98 File Offset: 0x0000B098
        public override string GetAttribute(string localName, string namespaceURI)
        {
            HtmlAttribute htmlAttribute = this._currentnode.Attributes[localName];
            if (htmlAttribute == null)
            {
                return null;
            }
            return htmlAttribute.Value;
        }

        // Token: 0x060001C0 RID: 448 RVA: 0x0000CEC2 File Offset: 0x0000B0C2
        public override string GetNamespace(string name)
        {
            return string.Empty;
        }

        // Token: 0x060001C1 RID: 449 RVA: 0x0000CECC File Offset: 0x0000B0CC
        public override bool IsSamePosition(XPathNavigator other)
        {
            HtmlNodeNavigator htmlNodeNavigator = other as HtmlNodeNavigator;
            return htmlNodeNavigator != null && htmlNodeNavigator._currentnode == this._currentnode;
        }

        // Token: 0x060001C2 RID: 450 RVA: 0x0000CEF4 File Offset: 0x0000B0F4
        public override bool MoveTo(XPathNavigator other)
        {
            HtmlNodeNavigator htmlNodeNavigator = other as HtmlNodeNavigator;
            if (htmlNodeNavigator == null)
            {
                return false;
            }
            if (htmlNodeNavigator._doc == this._doc)
            {
                this._currentnode = htmlNodeNavigator._currentnode;
                this._attindex = htmlNodeNavigator._attindex;
                return true;
            }
            return false;
        }

        // Token: 0x060001C3 RID: 451 RVA: 0x0000CF38 File Offset: 0x0000B138
        public override bool MoveToAttribute(string localName, string namespaceURI)
        {
            int attributeIndex = this._currentnode.Attributes.GetAttributeIndex(localName);
            if (attributeIndex == -1)
            {
                return false;
            }
            this._attindex = attributeIndex;
            return true;
        }

        // Token: 0x060001C4 RID: 452 RVA: 0x0000CF65 File Offset: 0x0000B165
        public override bool MoveToFirst()
        {
            if (this._currentnode.ParentNode == null)
            {
                return false;
            }
            if (this._currentnode.ParentNode.FirstChild == null)
            {
                return false;
            }
            this._currentnode = this._currentnode.ParentNode.FirstChild;
            return true;
        }

        // Token: 0x060001C5 RID: 453 RVA: 0x0000CFA1 File Offset: 0x0000B1A1
        public override bool MoveToFirstAttribute()
        {
            if (!this.HasAttributes)
            {
                return false;
            }
            this._attindex = 0;
            return true;
        }

        // Token: 0x060001C6 RID: 454 RVA: 0x0000CFB5 File Offset: 0x0000B1B5
        public override bool MoveToFirstChild()
        {
            if (!this._currentnode.HasChildNodes)
            {
                return false;
            }
            this._currentnode = this._currentnode.ChildNodes[0];
            return true;
        }

        // Token: 0x060001C7 RID: 455 RVA: 0x0000CFDE File Offset: 0x0000B1DE
        public override bool MoveToFirstNamespace(XPathNamespaceScope scope)
        {
            return false;
        }

        // Token: 0x060001C8 RID: 456 RVA: 0x0000CFE4 File Offset: 0x0000B1E4
        public override bool MoveToId(string id)
        {
            HtmlNode elementbyId = this._doc.GetElementbyId(id);
            if (elementbyId == null)
            {
                return false;
            }
            this._currentnode = elementbyId;
            return true;
        }

        // Token: 0x060001C9 RID: 457 RVA: 0x0000D00B File Offset: 0x0000B20B
        public override bool MoveToNamespace(string name)
        {
            return false;
        }

        // Token: 0x060001CA RID: 458 RVA: 0x0000D00E File Offset: 0x0000B20E
        public override bool MoveToNext()
        {
            if (this._currentnode.NextSibling == null)
            {
                return false;
            }
            this._currentnode = this._currentnode.NextSibling;
            return true;
        }

        // Token: 0x060001CB RID: 459 RVA: 0x0000D031 File Offset: 0x0000B231
        public override bool MoveToNextAttribute()
        {
            if (this._attindex >= this._currentnode.Attributes.Count - 1)
            {
                return false;
            }
            this._attindex++;
            return true;
        }

        // Token: 0x060001CC RID: 460 RVA: 0x0000D05E File Offset: 0x0000B25E
        public override bool MoveToNextNamespace(XPathNamespaceScope scope)
        {
            return false;
        }

        // Token: 0x060001CD RID: 461 RVA: 0x0000D061 File Offset: 0x0000B261
        public override bool MoveToParent()
        {
            if (this._currentnode.ParentNode == null)
            {
                return false;
            }
            this._currentnode = this._currentnode.ParentNode;
            return true;
        }

        // Token: 0x060001CE RID: 462 RVA: 0x0000D084 File Offset: 0x0000B284
        public override bool MoveToPrevious()
        {
            if (this._currentnode.PreviousSibling == null)
            {
                return false;
            }
            this._currentnode = this._currentnode.PreviousSibling;
            return true;
        }

        // Token: 0x060001CF RID: 463 RVA: 0x0000D0A7 File Offset: 0x0000B2A7
        public override void MoveToRoot()
        {
            this._currentnode = this._doc.DocumentNode;
        }

        // Token: 0x060001D0 RID: 464 RVA: 0x0000D0BA File Offset: 0x0000B2BA
        private void Reset()
        {
            this._currentnode = this._doc.DocumentNode;
            this._attindex = -1;
        }

        // Token: 0x0400008D RID: 141
        private int _attindex;

        // Token: 0x0400008E RID: 142
        private HtmlNode _currentnode;

        // Token: 0x0400008F RID: 143
        private readonly HtmlDocument _doc;

        // Token: 0x04000090 RID: 144
        private readonly HtmlNameTable _nametable;

        // Token: 0x04000091 RID: 145
        internal bool Trace;
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x0200001A RID: 26
    public enum HtmlNodeType
    {
        // Token: 0x04000093 RID: 147
        Document,
        // Token: 0x04000094 RID: 148
        Element,
        // Token: 0x04000095 RID: 149
        Comment,
        // Token: 0x04000096 RID: 150
        Text
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x0200001B RID: 27
    public class HtmlParseError
    {
        // Token: 0x060001D1 RID: 465 RVA: 0x0000D0D4 File Offset: 0x0000B2D4
        internal HtmlParseError(HtmlParseErrorCode code, int line, int linePosition, int streamPosition, string sourceText, string reason)
        {
            this._code = code;
            this._line = line;
            this._linePosition = linePosition;
            this._streamPosition = streamPosition;
            this._sourceText = sourceText;
            this._reason = reason;
        }

        // Token: 0x17000061 RID: 97
        // (get) Token: 0x060001D2 RID: 466 RVA: 0x0000D109 File Offset: 0x0000B309
        public HtmlParseErrorCode Code
        {
            get
            {
                return this._code;
            }
        }

        // Token: 0x17000062 RID: 98
        // (get) Token: 0x060001D3 RID: 467 RVA: 0x0000D111 File Offset: 0x0000B311
        public int Line
        {
            get
            {
                return this._line;
            }
        }

        // Token: 0x17000063 RID: 99
        // (get) Token: 0x060001D4 RID: 468 RVA: 0x0000D119 File Offset: 0x0000B319
        public int LinePosition
        {
            get
            {
                return this._linePosition;
            }
        }

        // Token: 0x17000064 RID: 100
        // (get) Token: 0x060001D5 RID: 469 RVA: 0x0000D121 File Offset: 0x0000B321
        public string Reason
        {
            get
            {
                return this._reason;
            }
        }

        // Token: 0x17000065 RID: 101
        // (get) Token: 0x060001D6 RID: 470 RVA: 0x0000D129 File Offset: 0x0000B329
        public string SourceText
        {
            get
            {
                return this._sourceText;
            }
        }

        // Token: 0x17000066 RID: 102
        // (get) Token: 0x060001D7 RID: 471 RVA: 0x0000D131 File Offset: 0x0000B331
        public int StreamPosition
        {
            get
            {
                return this._streamPosition;
            }
        }

        // Token: 0x04000097 RID: 151
        private HtmlParseErrorCode _code;

        // Token: 0x04000098 RID: 152
        private int _line;

        // Token: 0x04000099 RID: 153
        private int _linePosition;

        // Token: 0x0400009A RID: 154
        private string _reason;

        // Token: 0x0400009B RID: 155
        private string _sourceText;

        // Token: 0x0400009C RID: 156
        private int _streamPosition;
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x0200001C RID: 28
    public enum HtmlParseErrorCode
    {
        // Token: 0x0400009E RID: 158
        TagNotClosed,
        // Token: 0x0400009F RID: 159
        TagNotOpened,
        // Token: 0x040000A0 RID: 160
        CharsetMismatch,
        // Token: 0x040000A1 RID: 161
        EndTagNotRequired,
        // Token: 0x040000A2 RID: 162
        EndTagInvalidHere
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x0200001D RID: 29
    public class HtmlTextNode : HtmlNode
    {
        // Token: 0x060001D8 RID: 472 RVA: 0x0000D139 File Offset: 0x0000B339
        internal HtmlTextNode(HtmlDocument ownerdocument, int index) : base(HtmlNodeType.Text, ownerdocument, index)
        {
        }

        // Token: 0x17000067 RID: 103
        // (get) Token: 0x060001D9 RID: 473 RVA: 0x0000D144 File Offset: 0x0000B344
        // (set) Token: 0x060001DA RID: 474 RVA: 0x0000D14C File Offset: 0x0000B34C
        public override string InnerHtml
        {
            get
            {
                return this.OuterHtml;
            }
            set
            {
                this._text = value;
            }
        }

        // Token: 0x17000068 RID: 104
        // (get) Token: 0x060001DB RID: 475 RVA: 0x0000D155 File Offset: 0x0000B355
        public override string OuterHtml
        {
            get
            {
                if (this._text == null)
                {
                    return base.OuterHtml;
                }
                return this._text;
            }
        }

        // Token: 0x17000069 RID: 105
        // (get) Token: 0x060001DC RID: 476 RVA: 0x0000D16C File Offset: 0x0000B36C
        // (set) Token: 0x060001DD RID: 477 RVA: 0x0000D183 File Offset: 0x0000B383
        public string Text
        {
            get
            {
                if (this._text == null)
                {
                    return base.OuterHtml;
                }
                return this._text;
            }
            set
            {
                this._text = value;
                base.SetChanged();
            }
        }

        // Token: 0x040000A3 RID: 163
        private string _text;
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x0200001E RID: 30
    public class HtmlWeb
    {
        // Token: 0x060001DE RID: 478 RVA: 0x0000D194 File Offset: 0x0000B394
        internal static HttpClient GetSharedHttpClient(string userAgent)
        {
            return HtmlWeb.SharedHttpClient.GetOrAdd(userAgent, (string x) => new HttpClient
            {
                DefaultRequestHeaders =
                {
                    {
                        "User-Agent",
                        userAgent
                    }
                }
            });
        }

        // Token: 0x1700006A RID: 106
        // (get) Token: 0x060001DF RID: 479 RVA: 0x0000D1CA File Offset: 0x0000B3CA
        // (set) Token: 0x060001E0 RID: 480 RVA: 0x0000D1D2 File Offset: 0x0000B3D2
        public DecompressionMethods AutomaticDecompression { get; set; }

        // Token: 0x1700006B RID: 107
        // (get) Token: 0x060001E2 RID: 482 RVA: 0x0000D211 File Offset: 0x0000B411
        // (set) Token: 0x060001E1 RID: 481 RVA: 0x0000D1DC File Offset: 0x0000B3DC
        public int? MaxAutoRedirects
        {
            get
            {
                return this._maxAutoRedirects;
            }
            set
            {
                int? num = value;
                int num2 = 0;
                if (num.GetValueOrDefault() <= num2 & num != null)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this._maxAutoRedirects = value;
            }
        }

        // Token: 0x1700006C RID: 108
        // (get) Token: 0x060001E3 RID: 483 RVA: 0x0000D219 File Offset: 0x0000B419
        // (set) Token: 0x060001E4 RID: 484 RVA: 0x0000D221 File Offset: 0x0000B421
        public int Timeout
        {
            get
            {
                return this._timeout;
            }
            set
            {
                if (value <= 0 && value != -1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this._timeout = value;
            }
        }

        // Token: 0x1700006D RID: 109
        // (get) Token: 0x060001E5 RID: 485 RVA: 0x0000D238 File Offset: 0x0000B438
        // (set) Token: 0x060001E6 RID: 486 RVA: 0x0000D240 File Offset: 0x0000B440
        public bool AutoDetectEncoding
        {
            get
            {
                return this._autoDetectEncoding;
            }
            set
            {
                this._autoDetectEncoding = value;
            }
        }

        // Token: 0x1700006E RID: 110
        // (get) Token: 0x060001E7 RID: 487 RVA: 0x0000D249 File Offset: 0x0000B449
        // (set) Token: 0x060001E8 RID: 488 RVA: 0x0000D251 File Offset: 0x0000B451
        public Encoding OverrideEncoding
        {
            get
            {
                return this._encoding;
            }
            set
            {
                this._encoding = value;
            }
        }

        // Token: 0x1700006F RID: 111
        // (get) Token: 0x060001E9 RID: 489 RVA: 0x0000D25A File Offset: 0x0000B45A
        // (set) Token: 0x060001EA RID: 490 RVA: 0x0000D262 File Offset: 0x0000B462
        public bool CacheOnly
        {
            get
            {
                return this._cacheOnly;
            }
            set
            {
                if (value && !this.UsingCache)
                {
                    throw new HtmlWebException("Cache is not enabled. Set UsingCache to true first.");
                }
                this._cacheOnly = value;
            }
        }

        // Token: 0x17000070 RID: 112
        // (get) Token: 0x060001EB RID: 491 RVA: 0x0000D281 File Offset: 0x0000B481
        // (set) Token: 0x060001EC RID: 492 RVA: 0x0000D289 File Offset: 0x0000B489
        public bool UsingCacheIfExists
        {
            get
            {
                return this._usingCacheIfExists;
            }
            set
            {
                this._usingCacheIfExists = value;
            }
        }

        // Token: 0x17000071 RID: 113
        // (get) Token: 0x060001ED RID: 493 RVA: 0x0000D292 File Offset: 0x0000B492
        // (set) Token: 0x060001EE RID: 494 RVA: 0x0000D29A File Offset: 0x0000B49A
        public string CachePath
        {
            get
            {
                return this._cachePath;
            }
            set
            {
                this._cachePath = value;
            }
        }

        // Token: 0x17000072 RID: 114
        // (get) Token: 0x060001EF RID: 495 RVA: 0x0000D2A3 File Offset: 0x0000B4A3
        public bool FromCache
        {
            get
            {
                return this._fromCache;
            }
        }

        // Token: 0x17000073 RID: 115
        // (get) Token: 0x060001F0 RID: 496 RVA: 0x0000D2AB File Offset: 0x0000B4AB
        public int RequestDuration
        {
            get
            {
                return this._requestDuration;
            }
        }

        // Token: 0x17000074 RID: 116
        // (get) Token: 0x060001F1 RID: 497 RVA: 0x0000D2B3 File Offset: 0x0000B4B3
        public Uri ResponseUri
        {
            get
            {
                return this._responseUri;
            }
        }

        // Token: 0x17000075 RID: 117
        // (get) Token: 0x060001F2 RID: 498 RVA: 0x0000D2BB File Offset: 0x0000B4BB
        public HttpStatusCode StatusCode
        {
            get
            {
                return this._statusCode;
            }
        }

        // Token: 0x17000076 RID: 118
        // (get) Token: 0x060001F3 RID: 499 RVA: 0x0000D2C3 File Offset: 0x0000B4C3
        // (set) Token: 0x060001F4 RID: 500 RVA: 0x0000D2CB File Offset: 0x0000B4CB
        public int StreamBufferSize
        {
            get
            {
                return this._streamBufferSize;
            }
            set
            {
                if (this._streamBufferSize <= 0)
                {
                    throw new ArgumentException("Size must be greater than zero.");
                }
                this._streamBufferSize = value;
            }
        }

        // Token: 0x17000077 RID: 119
        // (get) Token: 0x060001F5 RID: 501 RVA: 0x0000D2E8 File Offset: 0x0000B4E8
        // (set) Token: 0x060001F6 RID: 502 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
        public bool UseCookies
        {
            get
            {
                return this._useCookies;
            }
            set
            {
                this._useCookies = value;
            }
        }

        // Token: 0x17000078 RID: 120
        // (get) Token: 0x060001F7 RID: 503 RVA: 0x0000D2F9 File Offset: 0x0000B4F9
        // (set) Token: 0x060001F8 RID: 504 RVA: 0x0000D301 File Offset: 0x0000B501
        public bool CaptureRedirect { get; set; }

        // Token: 0x17000079 RID: 121
        // (get) Token: 0x060001F9 RID: 505 RVA: 0x0000D30A File Offset: 0x0000B50A
        // (set) Token: 0x060001FA RID: 506 RVA: 0x0000D312 File Offset: 0x0000B512
        public string UserAgent
        {
            get
            {
                return this._userAgent;
            }
            set
            {
                this._userAgent = value;
            }
        }

        // Token: 0x1700007A RID: 122
        // (get) Token: 0x060001FB RID: 507 RVA: 0x0000D31B File Offset: 0x0000B51B
        // (set) Token: 0x060001FC RID: 508 RVA: 0x0000D32D File Offset: 0x0000B52D
        public bool UsingCache
        {
            get
            {
                return this._cachePath != null && this._usingCache;
            }
            set
            {
                if (value && this._cachePath == null)
                {
                    throw new HtmlWebException("You need to define a CachePath first.");
                }
                this._usingCache = value;
            }
        }

        // Token: 0x060001FD RID: 509 RVA: 0x0000D34C File Offset: 0x0000B54C
        public static string GetContentTypeForExtension(string extension, string def)
        {
            if (string.IsNullOrEmpty(extension))
            {
                return def;
            }
            string result = "";
            if (!extension.StartsWith("."))
            {
                extension = "." + extension;
            }
            if (!MimeTypeMap.Mappings.TryGetValue(extension, out result))
            {
                result = def;
            }
            return result;
        }

        // Token: 0x060001FE RID: 510 RVA: 0x0000D398 File Offset: 0x0000B598
        public static string GetExtensionForContentType(string contentType, string def)
        {
            if (string.IsNullOrEmpty(contentType))
            {
                return def;
            }
            if (contentType.StartsWith("."))
            {
                throw new ArgumentException("Requested mime type is not valid: " + contentType);
            }
            string result = "";
            if (!MimeTypeMap.Mappings.TryGetValue(contentType, out result))
            {
                result = def;
            }
            return result;
        }

        // Token: 0x060001FF RID: 511 RVA: 0x0000D3E5 File Offset: 0x0000B5E5
        public object CreateInstance(string url, Type type)
        {
            return this.CreateInstance(url, null, null, type);
        }

        // Token: 0x06000200 RID: 512 RVA: 0x0000D3F1 File Offset: 0x0000B5F1
        public void Get(string url, string path)
        {
            this.Get(url, path, "GET");
        }

        // Token: 0x06000201 RID: 513 RVA: 0x0000D400 File Offset: 0x0000B600
        public void Get(string url, string path, WebProxy proxy, NetworkCredential credentials)
        {
            this.Get(url, path, proxy, credentials, "GET");
        }

        // Token: 0x06000202 RID: 514 RVA: 0x0000D414 File Offset: 0x0000B614
        public void Get(string url, string path, string method)
        {
            Uri uri = new Uri(url);
            if (uri.Scheme == Uri.UriSchemeHttps || uri.Scheme == Uri.UriSchemeHttp)
            {
                this.Get(uri, method, path, null, null, null);
                return;
            }
            throw new HtmlWebException("Unsupported uri scheme: '" + uri.Scheme + "'.");
        }

        // Token: 0x06000203 RID: 515 RVA: 0x0000D474 File Offset: 0x0000B674
        public void Get(string url, string path, WebProxy proxy, NetworkCredential credentials, string method)
        {
            Uri uri = new Uri(url);
            if (uri.Scheme == Uri.UriSchemeHttps || uri.Scheme == Uri.UriSchemeHttp)
            {
                this.Get(uri, method, path, null, proxy, credentials);
                return;
            }
            throw new HtmlWebException("Unsupported uri scheme: '" + uri.Scheme + "'.");
        }

        // Token: 0x06000204 RID: 516 RVA: 0x0000D4D8 File Offset: 0x0000B6D8
        public string GetCachePath(Uri uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException("uri");
            }
            if (!this.UsingCache)
            {
                throw new HtmlWebException("Cache is not enabled. Set UsingCache to true first.");
            }
            string result;
            if (uri.AbsolutePath == "/")
            {
                result = Path.Combine(this._cachePath, ".htm");
            }
            else
            {
                string text = uri.AbsolutePath;
                string text2 = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                for (int i = 0; i < text2.Length; i++)
                {
                    text = text.Replace(text2[i].ToString(), "");
                }
                if (uri.AbsolutePath[uri.AbsolutePath.Length - 1] == Path.AltDirectorySeparatorChar)
                {
                    result = Path.Combine(this._cachePath, (uri.Host + text.TrimEnd(new char[]
                    {
                        Path.AltDirectorySeparatorChar
                    })).Replace('/', '\\') + ".htm");
                }
                else
                {
                    result = Path.Combine(this._cachePath, uri.Host + text.Replace('/', '\\'));
                }
            }
            return result;
        }

        // Token: 0x06000205 RID: 517 RVA: 0x0000D603 File Offset: 0x0000B803
        public HtmlDocument Load(string url)
        {
            return this.Load(url, "GET");
        }

        // Token: 0x06000206 RID: 518 RVA: 0x0000D611 File Offset: 0x0000B811
        public HtmlDocument Load(Uri uri)
        {
            return this.Load(uri, "GET");
        }

        // Token: 0x06000207 RID: 519 RVA: 0x0000D620 File Offset: 0x0000B820
        public HtmlDocument Load(string url, string proxyHost, int proxyPort, string userId, string password)
        {
            WebProxy webProxy = new WebProxy(proxyHost, proxyPort);
            webProxy.BypassProxyOnLocal = true;
            NetworkCredential networkCredential = null;
            if (userId != null && password != null)
            {
                networkCredential = new NetworkCredential(userId, password);
                CredentialCache credentialCache = new CredentialCache();
                credentialCache.Add(webProxy.Address, "Basic", networkCredential);
                credentialCache.Add(webProxy.Address, "Digest", networkCredential);
            }
            return this.Load(url, "GET", webProxy, networkCredential);
        }

        // Token: 0x06000208 RID: 520 RVA: 0x0000D688 File Offset: 0x0000B888
        public HtmlDocument Load(Uri uri, string proxyHost, int proxyPort, string userId, string password)
        {
            WebProxy webProxy = new WebProxy(proxyHost, proxyPort);
            webProxy.BypassProxyOnLocal = true;
            NetworkCredential networkCredential = null;
            if (userId != null && password != null)
            {
                networkCredential = new NetworkCredential(userId, password);
                CredentialCache credentialCache = new CredentialCache();
                credentialCache.Add(webProxy.Address, "Basic", networkCredential);
                credentialCache.Add(webProxy.Address, "Digest", networkCredential);
            }
            return this.Load(uri, "GET", webProxy, networkCredential);
        }

        // Token: 0x06000209 RID: 521 RVA: 0x0000D6F0 File Offset: 0x0000B8F0
        public HtmlDocument Load(string url, string method)
        {
            Uri uri = new Uri(url);
            return this.Load(uri, method);
        }

        // Token: 0x0600020A RID: 522 RVA: 0x0000D70C File Offset: 0x0000B90C
        public HtmlDocument Load(Uri uri, string method)
        {
            if (this.UsingCache)
            {
                this._usingCacheAndLoad = true;
            }
            HtmlDocument htmlDocument;
            if (uri.Scheme == Uri.UriSchemeHttps || uri.Scheme == Uri.UriSchemeHttp)
            {
                htmlDocument = this.LoadUrl(uri, method, null, null);
            }
            else
            {
                if (!(uri.Scheme == Uri.UriSchemeFile))
                {
                    throw new HtmlWebException("Unsupported uri scheme: '" + uri.Scheme + "'.");
                }
                htmlDocument = new HtmlDocument();
                htmlDocument.OptionAutoCloseOnEnd = false;
                htmlDocument.OptionAutoCloseOnEnd = true;
                if (this.OverrideEncoding != null)
                {
                    htmlDocument.Load(uri.OriginalString, this.OverrideEncoding);
                }
                else
                {
                    htmlDocument.DetectEncodingAndLoad(uri.OriginalString, this._autoDetectEncoding);
                }
            }
            if (this.PreHandleDocument != null)
            {
                this.PreHandleDocument(htmlDocument);
            }
            return htmlDocument;
        }

        // Token: 0x0600020B RID: 523 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
        public HtmlDocument Load(string url, string method, WebProxy proxy, NetworkCredential credentials)
        {
            Uri uri = new Uri(url);
            return this.Load(uri, method, proxy, credentials);
        }

        // Token: 0x0600020C RID: 524 RVA: 0x0000D800 File Offset: 0x0000BA00
        public HtmlDocument Load(Uri uri, string method, WebProxy proxy, NetworkCredential credentials)
        {
            if (this.UsingCache)
            {
                this._usingCacheAndLoad = true;
            }
            HtmlDocument htmlDocument;
            if (uri.Scheme == Uri.UriSchemeHttps || uri.Scheme == Uri.UriSchemeHttp)
            {
                htmlDocument = this.LoadUrl(uri, method, proxy, credentials);
            }
            else
            {
                if (!(uri.Scheme == Uri.UriSchemeFile))
                {
                    throw new HtmlWebException("Unsupported uri scheme: '" + uri.Scheme + "'.");
                }
                htmlDocument = new HtmlDocument();
                htmlDocument.OptionAutoCloseOnEnd = false;
                htmlDocument.OptionAutoCloseOnEnd = true;
                htmlDocument.DetectEncodingAndLoad(uri.OriginalString, this._autoDetectEncoding);
            }
            if (this.PreHandleDocument != null)
            {
                this.PreHandleDocument(htmlDocument);
            }
            return htmlDocument;
        }

        // Token: 0x0600020D RID: 525 RVA: 0x0000D8B8 File Offset: 0x0000BAB8
        public void LoadHtmlAsXml(string htmlUrl, XmlTextWriter writer)
        {
            this.Load(htmlUrl).Save(writer);
        }

        // Token: 0x0600020E RID: 526 RVA: 0x0000D8C8 File Offset: 0x0000BAC8
        private static void FilePreparePath(string target)
        {
            if (File.Exists(target))
            {
                FileAttributes attributes = File.GetAttributes(target);
                File.SetAttributes(target, attributes & ~FileAttributes.ReadOnly);
                return;
            }
            string directoryName = Path.GetDirectoryName(target);
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
        }

        // Token: 0x0600020F RID: 527 RVA: 0x0000D905 File Offset: 0x0000BB05
        private static DateTime RemoveMilliseconds(DateTime t)
        {
            return new DateTime(t.Year, t.Month, t.Day, t.Hour, t.Minute, t.Second, 0);
        }

        // Token: 0x06000210 RID: 528 RVA: 0x0000D938 File Offset: 0x0000BB38
        private static DateTime RemoveMilliseconds(DateTimeOffset? offset)
        {
            DateTimeOffset dateTimeOffset = offset ?? DateTimeOffset.Now;
            return new DateTime(dateTimeOffset.Year, dateTimeOffset.Month, dateTimeOffset.Day, dateTimeOffset.Hour, dateTimeOffset.Minute, dateTimeOffset.Second, 0);
        }

        // Token: 0x06000211 RID: 529 RVA: 0x0000D990 File Offset: 0x0000BB90
        private static long SaveStream(Stream stream, string path, DateTime touchDate, int streamBufferSize)
        {
            HtmlWeb.FilePreparePath(path);
            long num = 0L;
            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (BinaryReader binaryReader = new BinaryReader(stream))
                {
                    using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                    {
                        byte[] array;
                        do
                        {
                            array = binaryReader.ReadBytes(streamBufferSize);
                            num += (long)array.Length;
                            if (array.Length != 0)
                            {
                                binaryWriter.Write(array);
                            }
                        }
                        while (array.Length != 0);
                        binaryWriter.Flush();
                    }
                }
            }
            File.SetLastWriteTime(path, touchDate);
            return num;
        }

        // Token: 0x06000212 RID: 530 RVA: 0x0000DA38 File Offset: 0x0000BC38
        private HttpStatusCode Get(Uri uri, string method, string path, HtmlDocument doc, IWebProxy proxy, ICredentials creds)
        {
            string text = null;
            bool flag = false;
            HttpWebRequest httpWebRequest = WebRequest.Create(uri) as HttpWebRequest;
            if (this.MaxAutoRedirects != null)
            {
                httpWebRequest.MaximumAutomaticRedirections = this.MaxAutoRedirects.Value;
            }
            httpWebRequest.Timeout = this.Timeout;
            httpWebRequest.Method = method;
            httpWebRequest.UserAgent = this.UserAgent;
            httpWebRequest.AutomaticDecompression = this.AutomaticDecompression;
            if (this.CaptureRedirect)
            {
                httpWebRequest.AllowAutoRedirect = false;
            }
            if (proxy != null)
            {
                if (creds != null)
                {
                    proxy.Credentials = creds;
                    httpWebRequest.Credentials = creds;
                }
                else
                {
                    proxy.Credentials = CredentialCache.DefaultCredentials;
                    httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
                }
                httpWebRequest.Proxy = proxy;
            }
            this._fromCache = false;
            this._requestDuration = 0;
            int tickCount = Environment.TickCount;
            if (this.UsingCache)
            {
                text = this.GetCachePath(httpWebRequest.RequestUri);
                if (File.Exists(text))
                {
                    httpWebRequest.IfModifiedSince = File.GetLastAccessTime(text);
                    flag = true;
                }
            }
            if (this._cacheOnly || this._usingCacheIfExists)
            {
                if (File.Exists(text))
                {
                    if (path != null)
                    {
                        IOLibrary.CopyAlways(text, path);
                        if (text != null)
                        {
                            File.SetLastWriteTime(path, File.GetLastWriteTime(text));
                        }
                    }
                    this._fromCache = true;
                    return HttpStatusCode.NotModified;
                }
                if (this._cacheOnly)
                {
                    throw new HtmlWebException("File was not found at cache path: '" + text + "'");
                }
            }
            if (this._useCookies)
            {
                httpWebRequest.CookieContainer = new CookieContainer();
            }
            if (this.PreRequest != null && !this.PreRequest(httpWebRequest))
            {
                return HttpStatusCode.ResetContent;
            }
            HttpWebResponse httpWebResponse;
            try
            {
                httpWebResponse = (httpWebRequest.GetResponse() as HttpWebResponse);
            }
            catch (WebException ex)
            {
                this._requestDuration = Environment.TickCount - tickCount;
                httpWebResponse = (HttpWebResponse)ex.Response;
                if (httpWebResponse == null)
                {
                    if (flag)
                    {
                        if (path != null)
                        {
                            IOLibrary.CopyAlways(text, path);
                            File.SetLastWriteTime(path, File.GetLastWriteTime(text));
                        }
                        return HttpStatusCode.NotModified;
                    }
                    throw;
                }
            }
            catch (Exception)
            {
                this._requestDuration = Environment.TickCount - tickCount;
                throw;
            }
            if (this.PostResponse != null)
            {
                this.PostResponse(httpWebRequest, httpWebResponse);
            }
            this._requestDuration = Environment.TickCount - tickCount;
            this._responseUri = httpWebResponse.ResponseUri;
            HttpStatusCode statusCode = httpWebResponse.StatusCode;
            bool flag2 = this.IsHtmlContent(httpWebResponse.ContentType);
            bool flag3 = string.IsNullOrEmpty(httpWebResponse.ContentType);
            string text2 = "";
            if (!string.IsNullOrEmpty(httpWebResponse.CharacterSet))
            {
                text2 = httpWebResponse.CharacterSet.Replace("\"", "");
            }
            Encoding encoding = null;
            try
            {
                encoding = ((!string.IsNullOrEmpty(flag2 ? text2 : httpWebResponse.ContentEncoding)) ? Encoding.GetEncoding(flag2 ? text2 : httpWebResponse.ContentEncoding) : null);
            }
            catch (Exception)
            {
            }
            if (this.OverrideEncoding != null)
            {
                encoding = this.OverrideEncoding;
            }
            if (this.CaptureRedirect && httpWebResponse.StatusCode == HttpStatusCode.Found)
            {
                string text3 = httpWebResponse.Headers["Location"];
                Uri uri2;
                if (!Uri.TryCreate(text3, UriKind.Absolute, out uri2))
                {
                    uri2 = new Uri(uri, text3);
                }
                return this.Get(uri2, "GET", path, doc, proxy, creds);
            }
            if (httpWebResponse.StatusCode != HttpStatusCode.NotModified)
            {
                Stream responseStream = httpWebResponse.GetResponseStream();
                if (responseStream != null)
                {
                    if (this.UsingCache)
                    {
                        HtmlWeb.SaveStream(responseStream, text, HtmlWeb.RemoveMilliseconds(httpWebResponse.LastModified), this._streamBufferSize);
                        this.SaveCacheHeaders(httpWebRequest.RequestUri, httpWebResponse);
                        if (path != null)
                        {
                            IOLibrary.CopyAlways(text, path);
                            File.SetLastWriteTime(path, File.GetLastWriteTime(text));
                        }
                        if (this._usingCacheAndLoad)
                        {
                            doc.Load(text);
                        }
                    }
                    else
                    {
                        if (doc != null && flag2)
                        {
                            if (encoding == null)
                            {
                                doc.Load(responseStream, true);
                            }
                            else
                            {
                                doc.Load(responseStream, encoding);
                            }
                        }
                        if (doc != null && flag3)
                        {
                            try
                            {
                                if (encoding == null)
                                {
                                    doc.Load(responseStream, true);
                                }
                                else
                                {
                                    doc.Load(responseStream, encoding);
                                }
                            }
                            catch
                            {
                            }
                        }
                    }
                    httpWebResponse.Close();
                }
                return statusCode;
            }
            if (this.UsingCache)
            {
                this._fromCache = true;
                if (path != null)
                {
                    IOLibrary.CopyAlways(text, path);
                    File.SetLastWriteTime(path, File.GetLastWriteTime(text));
                }
                return httpWebResponse.StatusCode;
            }
            throw new HtmlWebException("Server has send a NotModifed code, without cache enabled.");
        }

        // Token: 0x06000213 RID: 531 RVA: 0x0000DE7C File Offset: 0x0000C07C
        private string GetCacheHeader(Uri requestUri, string name, string def)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(this.GetCacheHeadersPath(requestUri));
            XmlNode xmlNode = xmlDocument.SelectSingleNode("//h[translate(@n, 'abcdefghijklmnopqrstuvwxyz','ABCDEFGHIJKLMNOPQRSTUVWXYZ')='" + name.ToUpperInvariant() + "']");
            if (xmlNode == null)
            {
                return def;
            }
            return xmlNode.Attributes[name].Value;
        }

        // Token: 0x06000214 RID: 532 RVA: 0x0000DECC File Offset: 0x0000C0CC
        private string GetCacheHeadersPath(Uri uri)
        {
            return this.GetCachePath(uri) + ".h.xml";
        }

        // Token: 0x06000215 RID: 533 RVA: 0x0000DEE0 File Offset: 0x0000C0E0
        private bool IsCacheHtmlContent(string path)
        {
            string contentTypeForExtension = HtmlWeb.GetContentTypeForExtension(Path.GetExtension(path), null);
            return this.IsHtmlContent(contentTypeForExtension);
        }

        // Token: 0x06000216 RID: 534 RVA: 0x0000DF01 File Offset: 0x0000C101
        private bool IsHtmlContent(string contentType)
        {
            return contentType.ToLowerInvariant().StartsWith("text/html");
        }

        // Token: 0x06000217 RID: 535 RVA: 0x0000DF13 File Offset: 0x0000C113
        private bool IsGZipEncoding(string contentEncoding)
        {
            return contentEncoding.ToLowerInvariant().StartsWith("gzip");
        }

        // Token: 0x06000218 RID: 536 RVA: 0x0000DF28 File Offset: 0x0000C128
        private HtmlDocument LoadUrl(Uri uri, string method, WebProxy proxy, NetworkCredential creds)
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.OptionAutoCloseOnEnd = false;
            htmlDocument.OptionFixNestedTags = true;
            this._statusCode = this.Get(uri, method, null, htmlDocument, proxy, creds);
            if (this._statusCode == HttpStatusCode.NotModified)
            {
                htmlDocument.DetectEncodingAndLoad(this.GetCachePath(uri));
            }
            return htmlDocument;
        }

        // Token: 0x06000219 RID: 537 RVA: 0x0000DF78 File Offset: 0x0000C178
        private void SaveCacheHeaders(Uri requestUri, HttpWebResponse resp)
        {
            string cacheHeadersPath = this.GetCacheHeadersPath(requestUri);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml("<c></c>");
            XmlNode firstChild = xmlDocument.FirstChild;
            foreach (object obj in resp.Headers)
            {
                string text = (string)obj;
                XmlNode xmlNode = xmlDocument.CreateElement("h");
                XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("n");
                xmlAttribute.Value = text;
                xmlNode.Attributes.Append(xmlAttribute);
                xmlAttribute = xmlDocument.CreateAttribute("v");
                xmlAttribute.Value = resp.Headers[text];
                xmlNode.Attributes.Append(xmlAttribute);
                firstChild.AppendChild(xmlNode);
            }
            xmlDocument.Save(cacheHeadersPath);
        }

        // Token: 0x0600021A RID: 538 RVA: 0x0000E060 File Offset: 0x0000C260
        //public Task<HtmlDocument> LoadFromWebAsync(string url)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), null, null);
        //}

        //// Token: 0x0600021B RID: 539 RVA: 0x0000E070 File Offset: 0x0000C270
        //public Task<HtmlDocument> LoadFromWebAsync(string url, CancellationToken cancellationToken)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), null, null, cancellationToken);
        //}

        //// Token: 0x0600021C RID: 540 RVA: 0x0000E081 File Offset: 0x0000C281
        //public Task<HtmlDocument> LoadFromWebAsync(string url, Encoding encoding)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), encoding, null, CancellationToken.None);
        //}

        //// Token: 0x0600021D RID: 541 RVA: 0x0000E096 File Offset: 0x0000C296
        //public Task<HtmlDocument> LoadFromWebAsync(string url, Encoding encoding, CancellationToken cancellationToken)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), encoding, null, cancellationToken);
        //}

        //// Token: 0x0600021E RID: 542 RVA: 0x0000E0A7 File Offset: 0x0000C2A7
        //public Task<HtmlDocument> LoadFromWebAsync(string url, Encoding encoding, string userName, string password)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), encoding, new NetworkCredential(userName, password), CancellationToken.None);
        //}

        //// Token: 0x0600021F RID: 543 RVA: 0x0000E0C3 File Offset: 0x0000C2C3
        //public Task<HtmlDocument> LoadFromWebAsync(string url, Encoding encoding, string userName, string password, CancellationToken cancellationToken)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), encoding, new NetworkCredential(userName, password), cancellationToken);
        //}

        //// Token: 0x06000220 RID: 544 RVA: 0x0000E0DC File Offset: 0x0000C2DC
        //public Task<HtmlDocument> LoadFromWebAsync(string url, Encoding encoding, string userName, string password, string domain)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), encoding, new NetworkCredential(userName, password, domain), CancellationToken.None);
        //}

        //// Token: 0x06000221 RID: 545 RVA: 0x0000E0FA File Offset: 0x0000C2FA
        //public Task<HtmlDocument> LoadFromWebAsync(string url, Encoding encoding, string userName, string password, string domain, CancellationToken cancellationToken)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), encoding, new NetworkCredential(userName, password, domain), cancellationToken);
        //}

        //// Token: 0x06000222 RID: 546 RVA: 0x0000E115 File Offset: 0x0000C315
        //public Task<HtmlDocument> LoadFromWebAsync(string url, string userName, string password, string domain)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), null, new NetworkCredential(userName, password, domain), CancellationToken.None);
        //}

        //// Token: 0x06000223 RID: 547 RVA: 0x0000E132 File Offset: 0x0000C332
        //public Task<HtmlDocument> LoadFromWebAsync(string url, string userName, string password, string domain, CancellationToken cancellationToken)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), null, new NetworkCredential(userName, password, domain), cancellationToken);
        //}

        //// Token: 0x06000224 RID: 548 RVA: 0x0000E14C File Offset: 0x0000C34C
        //public Task<HtmlDocument> LoadFromWebAsync(string url, string userName, string password)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), null, new NetworkCredential(userName, password), CancellationToken.None);
        //}

        //// Token: 0x06000225 RID: 549 RVA: 0x0000E167 File Offset: 0x0000C367
        //public Task<HtmlDocument> LoadFromWebAsync(string url, string userName, string password, CancellationToken cancellationToken)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), null, new NetworkCredential(userName, password), cancellationToken);
        //}

        //// Token: 0x06000226 RID: 550 RVA: 0x0000E17F File Offset: 0x0000C37F
        //public Task<HtmlDocument> LoadFromWebAsync(string url, NetworkCredential credentials)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), null, credentials, CancellationToken.None);
        //}

        //// Token: 0x06000227 RID: 551 RVA: 0x0000E194 File Offset: 0x0000C394
        //public Task<HtmlDocument> LoadFromWebAsync(string url, NetworkCredential credentials, CancellationToken cancellationToken)
        //{
        //    return this.LoadFromWebAsync(new Uri(url), null, credentials, cancellationToken);
        //}

        //// Token: 0x06000228 RID: 552 RVA: 0x0000E1A5 File Offset: 0x0000C3A5
        //public Task<HtmlDocument> LoadFromWebAsync(Uri uri, Encoding encoding, NetworkCredential credentials)
        //{
        //    return this.LoadFromWebAsync(uri, encoding, credentials, CancellationToken.None);
        //}

        //// Token: 0x06000229 RID: 553 RVA: 0x0000E1B8 File Offset: 0x0000C3B8
        //public Task<HtmlDocument> LoadFromWebAsync(Uri uri, Encoding encoding, NetworkCredential credentials, CancellationToken cancellationToken)
        //{
        //    HtmlWeb.LoadFromWebAsync d;

        //    < LoadFromWebAsync > d__.<> t__builder = AsyncTaskMethodBuilder<HtmlDocument>.Create();

        //    < LoadFromWebAsync > d__.<> 4__this = this;

        //    < LoadFromWebAsync > d__.uri = uri;

        //    < LoadFromWebAsync > d__.encoding = encoding;

        //    < LoadFromWebAsync > d__.credentials = credentials;

        //    < LoadFromWebAsync > d__.cancellationToken = cancellationToken;

        //    < LoadFromWebAsync > d__.<> 1__state = -1;

        //    < LoadFromWebAsync > d__.<> t__builder.Start < HtmlWeb.< LoadFromWebAsync > d__117 > (ref < LoadFromWebAsync > d__);
        //    return < LoadFromWebAsync > d__.<> t__builder.Task;
        //}

        // Token: 0x0600022A RID: 554 RVA: 0x0000E21C File Offset: 0x0000C41C
        public object CreateInstance(string htmlUrl, string xsltUrl, XsltArgumentList xsltArgs, Type type)
        {
            return this.CreateInstance(htmlUrl, xsltUrl, xsltArgs, type, null);
        }

        // Token: 0x0600022B RID: 555 RVA: 0x0000E22C File Offset: 0x0000C42C
        public object CreateInstance(string htmlUrl, string xsltUrl, XsltArgumentList xsltArgs, Type type, string xmlPath)
        {
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
            if (xsltUrl == null)
            {
                this.LoadHtmlAsXml(htmlUrl, xmlTextWriter);
            }
            else if (xmlPath == null)
            {
                this.LoadHtmlAsXml(htmlUrl, xsltUrl, xsltArgs, xmlTextWriter);
            }
            else
            {
                this.LoadHtmlAsXml(htmlUrl, xsltUrl, xsltArgs, xmlTextWriter, xmlPath);
            }
            xmlTextWriter.Flush();
            XmlTextReader xmlReader = new XmlTextReader(new StringReader(stringWriter.ToString()));
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            object result;
            try
            {
                result = xmlSerializer.Deserialize(xmlReader);
            }
            catch (InvalidOperationException ex)
            {
                string str = (ex != null) ? ex.ToString() : null;
                string str2 = ", --- xml:";
                StringWriter stringWriter2 = stringWriter;
                throw new Exception(str + str2 + ((stringWriter2 != null) ? stringWriter2.ToString() : null));
            }
            return result;
        }

        // Token: 0x0600022C RID: 556 RVA: 0x0000E2D4 File Offset: 0x0000C4D4
        public void LoadHtmlAsXml(string htmlUrl, string xsltUrl, XsltArgumentList xsltArgs, XmlTextWriter writer)
        {
            this.LoadHtmlAsXml(htmlUrl, xsltUrl, xsltArgs, writer, null);
        }

        // Token: 0x0600022D RID: 557 RVA: 0x0000E2E4 File Offset: 0x0000C4E4
        public void LoadHtmlAsXml(string htmlUrl, string xsltUrl, XsltArgumentList xsltArgs, XmlTextWriter writer, string xmlPath)
        {
            if (htmlUrl == null)
            {
                throw new ArgumentNullException("htmlUrl");
            }
            HtmlDocument htmlDocument = this.Load(htmlUrl);
            if (xmlPath != null)
            {
                XmlTextWriter xmlTextWriter = new XmlTextWriter(xmlPath, htmlDocument.Encoding);
                htmlDocument.Save(xmlTextWriter);
                xmlTextWriter.Close();
            }
            if (xsltArgs == null)
            {
                xsltArgs = new XsltArgumentList();
            }
            xsltArgs.AddParam("url", "", htmlUrl);
            xsltArgs.AddParam("requestDuration", "", this.RequestDuration);
            xsltArgs.AddParam("fromCache", "", this.FromCache);
            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
            xslCompiledTransform.Load(xsltUrl);
            xslCompiledTransform.Transform(htmlDocument, xsltArgs, writer);
        }

        // Token: 0x040000A4 RID: 164
        private bool _autoDetectEncoding = true;

        // Token: 0x040000A5 RID: 165
        private bool _cacheOnly;

        // Token: 0x040000A6 RID: 166
        private string _cachePath;

        // Token: 0x040000A7 RID: 167
        private bool _fromCache;

        // Token: 0x040000A8 RID: 168
        private int _requestDuration;

        // Token: 0x040000A9 RID: 169
        private Uri _responseUri;

        // Token: 0x040000AA RID: 170
        private HttpStatusCode _statusCode = HttpStatusCode.OK;

        // Token: 0x040000AB RID: 171
        private int _streamBufferSize = 1024;

        // Token: 0x040000AC RID: 172
        private bool _useCookies;

        // Token: 0x040000AD RID: 173
        private bool _usingCache;

        // Token: 0x040000AE RID: 174
        private bool _usingCacheAndLoad;

        // Token: 0x040000AF RID: 175
        private bool _usingCacheIfExists;

        // Token: 0x040000B0 RID: 176
        private string _userAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:x.x.x) Gecko/20041107 Firefox/x.x";

        // Token: 0x040000B1 RID: 177
        private int _timeout = 100000;

        // Token: 0x040000B2 RID: 178
        private int? _maxAutoRedirects;

        // Token: 0x040000B3 RID: 179
        public HtmlWeb.PostResponseHandler PostResponse;

        // Token: 0x040000B4 RID: 180
        public HtmlWeb.PreHandleDocumentHandler PreHandleDocument;

        // Token: 0x040000B5 RID: 181
        public HtmlWeb.PreRequestHandler PreRequest;

        // Token: 0x040000B6 RID: 182
        internal static ConcurrentDictionary<string, HttpClient> SharedHttpClient = new ConcurrentDictionary<string, HttpClient>();

        // Token: 0x040000B8 RID: 184
        private Encoding _encoding;

        // Token: 0x02000046 RID: 70
        // (Invoke) Token: 0x06000331 RID: 817
        public delegate void PostResponseHandler(HttpWebRequest request, HttpWebResponse response);

        // Token: 0x02000047 RID: 71
        // (Invoke) Token: 0x06000335 RID: 821
        public delegate void PreHandleDocumentHandler(HtmlDocument document);

        // Token: 0x02000048 RID: 72
        // (Invoke) Token: 0x06000339 RID: 825
        public delegate bool PreRequestHandler(HttpWebRequest request);
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x0200001F RID: 31
    public class HtmlWebException : Exception
    {
        // Token: 0x06000230 RID: 560 RVA: 0x0000E3D3 File Offset: 0x0000C5D3
        public HtmlWebException(string message) : base(message)
        {
        }
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000017 RID: 23
    public class InvalidNodeReturnTypeException : Exception
    {
        // Token: 0x06000181 RID: 385 RVA: 0x0000C388 File Offset: 0x0000A588
        public InvalidNodeReturnTypeException(string message) : base(message)
        {
        }

        // Token: 0x06000182 RID: 386 RVA: 0x0000C391 File Offset: 0x0000A591
        public InvalidNodeReturnTypeException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000020 RID: 32
    internal struct IOLibrary
    {
        // Token: 0x06000231 RID: 561 RVA: 0x0000E3DC File Offset: 0x0000C5DC
        internal static void CopyAlways(string source, string target)
        {
            if (!File.Exists(source))
            {
                return;
            }
            Directory.CreateDirectory(Path.GetDirectoryName(target));
            IOLibrary.MakeWritable(target);
            File.Copy(source, target, true);
        }

        // Token: 0x06000232 RID: 562 RVA: 0x0000E401 File Offset: 0x0000C601
        internal static void MakeWritable(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }
            File.SetAttributes(path, File.GetAttributes(path) & ~FileAttributes.ReadOnly);
        }
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x02000021 RID: 33
    internal static class MimeTypeMap
    {
        // Token: 0x040000BA RID: 186
        public static IDictionary<string, string> Mappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {
                ".323",
                "text/h323"
            },
            {
                ".3g2",
                "video/3gpp2"
            },
            {
                ".3gp",
                "video/3gpp"
            },
            {
                ".3gp2",
                "video/3gpp2"
            },
            {
                ".3gpp",
                "video/3gpp"
            },
            {
                ".7z",
                "application/x-7z-compressed"
            },
            {
                ".aa",
                "audio/audible"
            },
            {
                ".AAC",
                "audio/aac"
            },
            {
                ".aaf",
                "application/octet-stream"
            },
            {
                ".aax",
                "audio/vnd.audible.aax"
            },
            {
                ".ac3",
                "audio/ac3"
            },
            {
                ".aca",
                "application/octet-stream"
            },
            {
                ".accda",
                "application/msaccess.addin"
            },
            {
                ".accdb",
                "application/msaccess"
            },
            {
                ".accdc",
                "application/msaccess.cab"
            },
            {
                ".accde",
                "application/msaccess"
            },
            {
                ".accdr",
                "application/msaccess.runtime"
            },
            {
                ".accdt",
                "application/msaccess"
            },
            {
                ".accdw",
                "application/msaccess.webapplication"
            },
            {
                ".accft",
                "application/msaccess.ftemplate"
            },
            {
                ".acx",
                "application/internet-property-stream"
            },
            {
                ".AddIn",
                "text/xml"
            },
            {
                ".ade",
                "application/msaccess"
            },
            {
                ".adobebridge",
                "application/x-bridge-url"
            },
            {
                ".adp",
                "application/msaccess"
            },
            {
                ".ADT",
                "audio/vnd.dlna.adts"
            },
            {
                ".ADTS",
                "audio/aac"
            },
            {
                ".afm",
                "application/octet-stream"
            },
            {
                ".ai",
                "application/postscript"
            },
            {
                ".aif",
                "audio/aiff"
            },
            {
                ".aifc",
                "audio/aiff"
            },
            {
                ".aiff",
                "audio/aiff"
            },
            {
                ".air",
                "application/vnd.adobe.air-application-installer-package+zip"
            },
            {
                ".amc",
                "application/mpeg"
            },
            {
                ".anx",
                "application/annodex"
            },
            {
                ".apk",
                "application/vnd.android.package-archive"
            },
            {
                ".application",
                "application/x-ms-application"
            },
            {
                ".art",
                "image/x-jg"
            },
            {
                ".asa",
                "application/xml"
            },
            {
                ".asax",
                "application/xml"
            },
            {
                ".ascx",
                "application/xml"
            },
            {
                ".asd",
                "application/octet-stream"
            },
            {
                ".asf",
                "video/x-ms-asf"
            },
            {
                ".ashx",
                "application/xml"
            },
            {
                ".asi",
                "application/octet-stream"
            },
            {
                ".asm",
                "text/plain"
            },
            {
                ".asmx",
                "application/xml"
            },
            {
                ".aspx",
                "application/xml"
            },
            {
                ".asr",
                "video/x-ms-asf"
            },
            {
                ".asx",
                "video/x-ms-asf"
            },
            {
                ".atom",
                "application/atom+xml"
            },
            {
                ".au",
                "audio/basic"
            },
            {
                ".avi",
                "video/x-msvideo"
            },
            {
                ".axa",
                "audio/annodex"
            },
            {
                ".axs",
                "application/olescript"
            },
            {
                ".axv",
                "video/annodex"
            },
            {
                ".bas",
                "text/plain"
            },
            {
                ".bcpio",
                "application/x-bcpio"
            },
            {
                ".bin",
                "application/octet-stream"
            },
            {
                ".bmp",
                "image/bmp"
            },
            {
                ".c",
                "text/plain"
            },
            {
                ".cab",
                "application/octet-stream"
            },
            {
                ".caf",
                "audio/x-caf"
            },
            {
                ".calx",
                "application/vnd.ms-office.calx"
            },
            {
                ".cat",
                "application/vnd.ms-pki.seccat"
            },
            {
                ".cc",
                "text/plain"
            },
            {
                ".cd",
                "text/plain"
            },
            {
                ".cdda",
                "audio/aiff"
            },
            {
                ".cdf",
                "application/x-cdf"
            },
            {
                ".cer",
                "application/x-x509-ca-cert"
            },
            {
                ".cfg",
                "text/plain"
            },
            {
                ".chm",
                "application/octet-stream"
            },
            {
                ".class",
                "application/x-java-applet"
            },
            {
                ".clp",
                "application/x-msclip"
            },
            {
                ".cmd",
                "text/plain"
            },
            {
                ".cmx",
                "image/x-cmx"
            },
            {
                ".cnf",
                "text/plain"
            },
            {
                ".cod",
                "image/cis-cod"
            },
            {
                ".config",
                "application/xml"
            },
            {
                ".contact",
                "text/x-ms-contact"
            },
            {
                ".coverage",
                "application/xml"
            },
            {
                ".cpio",
                "application/x-cpio"
            },
            {
                ".cpp",
                "text/plain"
            },
            {
                ".crd",
                "application/x-mscardfile"
            },
            {
                ".crl",
                "application/pkix-crl"
            },
            {
                ".crt",
                "application/x-x509-ca-cert"
            },
            {
                ".cs",
                "text/plain"
            },
            {
                ".csdproj",
                "text/plain"
            },
            {
                ".csh",
                "application/x-csh"
            },
            {
                ".csproj",
                "text/plain"
            },
            {
                ".css",
                "text/css"
            },
            {
                ".csv",
                "text/csv"
            },
            {
                ".cur",
                "application/octet-stream"
            },
            {
                ".cxx",
                "text/plain"
            },
            {
                ".dat",
                "application/octet-stream"
            },
            {
                ".datasource",
                "application/xml"
            },
            {
                ".dbproj",
                "text/plain"
            },
            {
                ".dcr",
                "application/x-director"
            },
            {
                ".def",
                "text/plain"
            },
            {
                ".deploy",
                "application/octet-stream"
            },
            {
                ".der",
                "application/x-x509-ca-cert"
            },
            {
                ".dgml",
                "application/xml"
            },
            {
                ".dib",
                "image/bmp"
            },
            {
                ".dif",
                "video/x-dv"
            },
            {
                ".dir",
                "application/x-director"
            },
            {
                ".disco",
                "text/xml"
            },
            {
                ".divx",
                "video/divx"
            },
            {
                ".dll",
                "application/x-msdownload"
            },
            {
                ".dll.config",
                "text/xml"
            },
            {
                ".dlm",
                "text/dlm"
            },
            {
                ".doc",
                "application/msword"
            },
            {
                ".docm",
                "application/vnd.ms-word.document.macroEnabled.12"
            },
            {
                ".docx",
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
            },
            {
                ".dot",
                "application/msword"
            },
            {
                ".dotm",
                "application/vnd.ms-word.template.macroEnabled.12"
            },
            {
                ".dotx",
                "application/vnd.openxmlformats-officedocument.wordprocessingml.template"
            },
            {
                ".dsp",
                "application/octet-stream"
            },
            {
                ".dsw",
                "text/plain"
            },
            {
                ".dtd",
                "text/xml"
            },
            {
                ".dtsConfig",
                "text/xml"
            },
            {
                ".dv",
                "video/x-dv"
            },
            {
                ".dvi",
                "application/x-dvi"
            },
            {
                ".dwf",
                "drawing/x-dwf"
            },
            {
                ".dwg",
                "application/acad"
            },
            {
                ".dwp",
                "application/octet-stream"
            },
            {
                ".dxf",
                "application/x-dxf"
            },
            {
                ".dxr",
                "application/x-director"
            },
            {
                ".eml",
                "message/rfc822"
            },
            {
                ".emz",
                "application/octet-stream"
            },
            {
                ".eot",
                "application/vnd.ms-fontobject"
            },
            {
                ".eps",
                "application/postscript"
            },
            {
                ".es",
                "application/ecmascript"
            },
            {
                ".etl",
                "application/etl"
            },
            {
                ".etx",
                "text/x-setext"
            },
            {
                ".evy",
                "application/envoy"
            },
            {
                ".exe",
                "application/octet-stream"
            },
            {
                ".exe.config",
                "text/xml"
            },
            {
                ".fdf",
                "application/vnd.fdf"
            },
            {
                ".fif",
                "application/fractals"
            },
            {
                ".filters",
                "application/xml"
            },
            {
                ".fla",
                "application/octet-stream"
            },
            {
                ".flac",
                "audio/flac"
            },
            {
                ".flr",
                "x-world/x-vrml"
            },
            {
                ".flv",
                "video/x-flv"
            },
            {
                ".fsscript",
                "application/fsharp-script"
            },
            {
                ".fsx",
                "application/fsharp-script"
            },
            {
                ".generictest",
                "application/xml"
            },
            {
                ".gif",
                "image/gif"
            },
            {
                ".gpx",
                "application/gpx+xml"
            },
            {
                ".group",
                "text/x-ms-group"
            },
            {
                ".gsm",
                "audio/x-gsm"
            },
            {
                ".gtar",
                "application/x-gtar"
            },
            {
                ".gz",
                "application/x-gzip"
            },
            {
                ".h",
                "text/plain"
            },
            {
                ".hdf",
                "application/x-hdf"
            },
            {
                ".hdml",
                "text/x-hdml"
            },
            {
                ".hhc",
                "application/x-oleobject"
            },
            {
                ".hhk",
                "application/octet-stream"
            },
            {
                ".hhp",
                "application/octet-stream"
            },
            {
                ".hlp",
                "application/winhlp"
            },
            {
                ".hpp",
                "text/plain"
            },
            {
                ".hqx",
                "application/mac-binhex40"
            },
            {
                ".hta",
                "application/hta"
            },
            {
                ".htc",
                "text/x-component"
            },
            {
                ".htm",
                "text/html"
            },
            {
                ".html",
                "text/html"
            },
            {
                ".htt",
                "text/webviewhtml"
            },
            {
                ".hxa",
                "application/xml"
            },
            {
                ".hxc",
                "application/xml"
            },
            {
                ".hxd",
                "application/octet-stream"
            },
            {
                ".hxe",
                "application/xml"
            },
            {
                ".hxf",
                "application/xml"
            },
            {
                ".hxh",
                "application/octet-stream"
            },
            {
                ".hxi",
                "application/octet-stream"
            },
            {
                ".hxk",
                "application/xml"
            },
            {
                ".hxq",
                "application/octet-stream"
            },
            {
                ".hxr",
                "application/octet-stream"
            },
            {
                ".hxs",
                "application/octet-stream"
            },
            {
                ".hxt",
                "text/html"
            },
            {
                ".hxv",
                "application/xml"
            },
            {
                ".hxw",
                "application/octet-stream"
            },
            {
                ".hxx",
                "text/plain"
            },
            {
                ".i",
                "text/plain"
            },
            {
                ".ico",
                "image/x-icon"
            },
            {
                ".ics",
                "application/octet-stream"
            },
            {
                ".idl",
                "text/plain"
            },
            {
                ".ief",
                "image/ief"
            },
            {
                ".iii",
                "application/x-iphone"
            },
            {
                ".inc",
                "text/plain"
            },
            {
                ".inf",
                "application/octet-stream"
            },
            {
                ".ini",
                "text/plain"
            },
            {
                ".inl",
                "text/plain"
            },
            {
                ".ins",
                "application/x-internet-signup"
            },
            {
                ".ipa",
                "application/x-itunes-ipa"
            },
            {
                ".ipg",
                "application/x-itunes-ipg"
            },
            {
                ".ipproj",
                "text/plain"
            },
            {
                ".ipsw",
                "application/x-itunes-ipsw"
            },
            {
                ".iqy",
                "text/x-ms-iqy"
            },
            {
                ".isp",
                "application/x-internet-signup"
            },
            {
                ".ite",
                "application/x-itunes-ite"
            },
            {
                ".itlp",
                "application/x-itunes-itlp"
            },
            {
                ".itms",
                "application/x-itunes-itms"
            },
            {
                ".itpc",
                "application/x-itunes-itpc"
            },
            {
                ".IVF",
                "video/x-ivf"
            },
            {
                ".jar",
                "application/java-archive"
            },
            {
                ".java",
                "application/octet-stream"
            },
            {
                ".jck",
                "application/liquidmotion"
            },
            {
                ".jcz",
                "application/liquidmotion"
            },
            {
                ".jfif",
                "image/pjpeg"
            },
            {
                ".jnlp",
                "application/x-java-jnlp-file"
            },
            {
                ".jpb",
                "application/octet-stream"
            },
            {
                ".jpe",
                "image/jpeg"
            },
            {
                ".jpeg",
                "image/jpeg"
            },
            {
                ".jpg",
                "image/jpeg"
            },
            {
                ".js",
                "application/javascript"
            },
            {
                ".json",
                "application/json"
            },
            {
                ".jsx",
                "text/jscript"
            },
            {
                ".jsxbin",
                "text/plain"
            },
            {
                ".latex",
                "application/x-latex"
            },
            {
                ".library-ms",
                "application/windows-library+xml"
            },
            {
                ".lit",
                "application/x-ms-reader"
            },
            {
                ".loadtest",
                "application/xml"
            },
            {
                ".lpk",
                "application/octet-stream"
            },
            {
                ".lsf",
                "video/x-la-asf"
            },
            {
                ".lst",
                "text/plain"
            },
            {
                ".lsx",
                "video/x-la-asf"
            },
            {
                ".lzh",
                "application/octet-stream"
            },
            {
                ".m13",
                "application/x-msmediaview"
            },
            {
                ".m14",
                "application/x-msmediaview"
            },
            {
                ".m1v",
                "video/mpeg"
            },
            {
                ".m2t",
                "video/vnd.dlna.mpeg-tts"
            },
            {
                ".m2ts",
                "video/vnd.dlna.mpeg-tts"
            },
            {
                ".m2v",
                "video/mpeg"
            },
            {
                ".m3u",
                "audio/x-mpegurl"
            },
            {
                ".m3u8",
                "audio/x-mpegurl"
            },
            {
                ".m4a",
                "audio/m4a"
            },
            {
                ".m4b",
                "audio/m4b"
            },
            {
                ".m4p",
                "audio/m4p"
            },
            {
                ".m4r",
                "audio/x-m4r"
            },
            {
                ".m4v",
                "video/x-m4v"
            },
            {
                ".mac",
                "image/x-macpaint"
            },
            {
                ".mak",
                "text/plain"
            },
            {
                ".man",
                "application/x-troff-man"
            },
            {
                ".manifest",
                "application/x-ms-manifest"
            },
            {
                ".map",
                "text/plain"
            },
            {
                ".master",
                "application/xml"
            },
            {
                ".mbox",
                "application/mbox"
            },
            {
                ".mda",
                "application/msaccess"
            },
            {
                ".mdb",
                "application/x-msaccess"
            },
            {
                ".mde",
                "application/msaccess"
            },
            {
                ".mdp",
                "application/octet-stream"
            },
            {
                ".me",
                "application/x-troff-me"
            },
            {
                ".mfp",
                "application/x-shockwave-flash"
            },
            {
                ".mht",
                "message/rfc822"
            },
            {
                ".mhtml",
                "message/rfc822"
            },
            {
                ".mid",
                "audio/mid"
            },
            {
                ".midi",
                "audio/mid"
            },
            {
                ".mix",
                "application/octet-stream"
            },
            {
                ".mk",
                "text/plain"
            },
            {
                ".mk3d",
                "video/x-matroska-3d"
            },
            {
                ".mka",
                "audio/x-matroska"
            },
            {
                ".mkv",
                "video/x-matroska"
            },
            {
                ".mmf",
                "application/x-smaf"
            },
            {
                ".mno",
                "text/xml"
            },
            {
                ".mny",
                "application/x-msmoney"
            },
            {
                ".mod",
                "video/mpeg"
            },
            {
                ".mov",
                "video/quicktime"
            },
            {
                ".movie",
                "video/x-sgi-movie"
            },
            {
                ".mp2",
                "video/mpeg"
            },
            {
                ".mp2v",
                "video/mpeg"
            },
            {
                ".mp3",
                "audio/mpeg"
            },
            {
                ".mp4",
                "video/mp4"
            },
            {
                ".mp4v",
                "video/mp4"
            },
            {
                ".mpa",
                "video/mpeg"
            },
            {
                ".mpe",
                "video/mpeg"
            },
            {
                ".mpeg",
                "video/mpeg"
            },
            {
                ".mpf",
                "application/vnd.ms-mediapackage"
            },
            {
                ".mpg",
                "video/mpeg"
            },
            {
                ".mpp",
                "application/vnd.ms-project"
            },
            {
                ".mpv2",
                "video/mpeg"
            },
            {
                ".mqv",
                "video/quicktime"
            },
            {
                ".ms",
                "application/x-troff-ms"
            },
            {
                ".msg",
                "application/vnd.ms-outlook"
            },
            {
                ".msi",
                "application/octet-stream"
            },
            {
                ".mso",
                "application/octet-stream"
            },
            {
                ".mts",
                "video/vnd.dlna.mpeg-tts"
            },
            {
                ".mtx",
                "application/xml"
            },
            {
                ".mvb",
                "application/x-msmediaview"
            },
            {
                ".mvc",
                "application/x-miva-compiled"
            },
            {
                ".mxp",
                "application/x-mmxp"
            },
            {
                ".nc",
                "application/x-netcdf"
            },
            {
                ".nsc",
                "video/x-ms-asf"
            },
            {
                ".nws",
                "message/rfc822"
            },
            {
                ".ocx",
                "application/octet-stream"
            },
            {
                ".oda",
                "application/oda"
            },
            {
                ".odb",
                "application/vnd.oasis.opendocument.database"
            },
            {
                ".odc",
                "application/vnd.oasis.opendocument.chart"
            },
            {
                ".odf",
                "application/vnd.oasis.opendocument.formula"
            },
            {
                ".odg",
                "application/vnd.oasis.opendocument.graphics"
            },
            {
                ".odh",
                "text/plain"
            },
            {
                ".odi",
                "application/vnd.oasis.opendocument.image"
            },
            {
                ".odl",
                "text/plain"
            },
            {
                ".odm",
                "application/vnd.oasis.opendocument.text-master"
            },
            {
                ".odp",
                "application/vnd.oasis.opendocument.presentation"
            },
            {
                ".ods",
                "application/vnd.oasis.opendocument.spreadsheet"
            },
            {
                ".odt",
                "application/vnd.oasis.opendocument.text"
            },
            {
                ".oga",
                "audio/ogg"
            },
            {
                ".ogg",
                "audio/ogg"
            },
            {
                ".ogv",
                "video/ogg"
            },
            {
                ".ogx",
                "application/ogg"
            },
            {
                ".one",
                "application/onenote"
            },
            {
                ".onea",
                "application/onenote"
            },
            {
                ".onepkg",
                "application/onenote"
            },
            {
                ".onetmp",
                "application/onenote"
            },
            {
                ".onetoc",
                "application/onenote"
            },
            {
                ".onetoc2",
                "application/onenote"
            },
            {
                ".opus",
                "audio/ogg"
            },
            {
                ".orderedtest",
                "application/xml"
            },
            {
                ".osdx",
                "application/opensearchdescription+xml"
            },
            {
                ".otf",
                "application/font-sfnt"
            },
            {
                ".otg",
                "application/vnd.oasis.opendocument.graphics-template"
            },
            {
                ".oth",
                "application/vnd.oasis.opendocument.text-web"
            },
            {
                ".otp",
                "application/vnd.oasis.opendocument.presentation-template"
            },
            {
                ".ots",
                "application/vnd.oasis.opendocument.spreadsheet-template"
            },
            {
                ".ott",
                "application/vnd.oasis.opendocument.text-template"
            },
            {
                ".oxt",
                "application/vnd.openofficeorg.extension"
            },
            {
                ".p10",
                "application/pkcs10"
            },
            {
                ".p12",
                "application/x-pkcs12"
            },
            {
                ".p7b",
                "application/x-pkcs7-certificates"
            },
            {
                ".p7c",
                "application/pkcs7-mime"
            },
            {
                ".p7m",
                "application/pkcs7-mime"
            },
            {
                ".p7r",
                "application/x-pkcs7-certreqresp"
            },
            {
                ".p7s",
                "application/pkcs7-signature"
            },
            {
                ".pbm",
                "image/x-portable-bitmap"
            },
            {
                ".pcast",
                "application/x-podcast"
            },
            {
                ".pct",
                "image/pict"
            },
            {
                ".pcx",
                "application/octet-stream"
            },
            {
                ".pcz",
                "application/octet-stream"
            },
            {
                ".pdf",
                "application/pdf"
            },
            {
                ".pfb",
                "application/octet-stream"
            },
            {
                ".pfm",
                "application/octet-stream"
            },
            {
                ".pfx",
                "application/x-pkcs12"
            },
            {
                ".pgm",
                "image/x-portable-graymap"
            },
            {
                ".pic",
                "image/pict"
            },
            {
                ".pict",
                "image/pict"
            },
            {
                ".pkgdef",
                "text/plain"
            },
            {
                ".pkgundef",
                "text/plain"
            },
            {
                ".pko",
                "application/vnd.ms-pki.pko"
            },
            {
                ".pls",
                "audio/scpls"
            },
            {
                ".pma",
                "application/x-perfmon"
            },
            {
                ".pmc",
                "application/x-perfmon"
            },
            {
                ".pml",
                "application/x-perfmon"
            },
            {
                ".pmr",
                "application/x-perfmon"
            },
            {
                ".pmw",
                "application/x-perfmon"
            },
            {
                ".png",
                "image/png"
            },
            {
                ".pnm",
                "image/x-portable-anymap"
            },
            {
                ".pnt",
                "image/x-macpaint"
            },
            {
                ".pntg",
                "image/x-macpaint"
            },
            {
                ".pnz",
                "image/png"
            },
            {
                ".pot",
                "application/vnd.ms-powerpoint"
            },
            {
                ".potm",
                "application/vnd.ms-powerpoint.template.macroEnabled.12"
            },
            {
                ".potx",
                "application/vnd.openxmlformats-officedocument.presentationml.template"
            },
            {
                ".ppa",
                "application/vnd.ms-powerpoint"
            },
            {
                ".ppam",
                "application/vnd.ms-powerpoint.addin.macroEnabled.12"
            },
            {
                ".ppm",
                "image/x-portable-pixmap"
            },
            {
                ".pps",
                "application/vnd.ms-powerpoint"
            },
            {
                ".ppsm",
                "application/vnd.ms-powerpoint.slideshow.macroEnabled.12"
            },
            {
                ".ppsx",
                "application/vnd.openxmlformats-officedocument.presentationml.slideshow"
            },
            {
                ".ppt",
                "application/vnd.ms-powerpoint"
            },
            {
                ".pptm",
                "application/vnd.ms-powerpoint.presentation.macroEnabled.12"
            },
            {
                ".pptx",
                "application/vnd.openxmlformats-officedocument.presentationml.presentation"
            },
            {
                ".prf",
                "application/pics-rules"
            },
            {
                ".prm",
                "application/octet-stream"
            },
            {
                ".prx",
                "application/octet-stream"
            },
            {
                ".ps",
                "application/postscript"
            },
            {
                ".psc1",
                "application/PowerShell"
            },
            {
                ".psd",
                "application/octet-stream"
            },
            {
                ".psess",
                "application/xml"
            },
            {
                ".psm",
                "application/octet-stream"
            },
            {
                ".psp",
                "application/octet-stream"
            },
            {
                ".pst",
                "application/vnd.ms-outlook"
            },
            {
                ".pub",
                "application/x-mspublisher"
            },
            {
                ".pwz",
                "application/vnd.ms-powerpoint"
            },
            {
                ".qht",
                "text/x-html-insertion"
            },
            {
                ".qhtm",
                "text/x-html-insertion"
            },
            {
                ".qt",
                "video/quicktime"
            },
            {
                ".qti",
                "image/x-quicktime"
            },
            {
                ".qtif",
                "image/x-quicktime"
            },
            {
                ".qtl",
                "application/x-quicktimeplayer"
            },
            {
                ".qxd",
                "application/octet-stream"
            },
            {
                ".ra",
                "audio/x-pn-realaudio"
            },
            {
                ".ram",
                "audio/x-pn-realaudio"
            },
            {
                ".rar",
                "application/x-rar-compressed"
            },
            {
                ".ras",
                "image/x-cmu-raster"
            },
            {
                ".rat",
                "application/rat-file"
            },
            {
                ".rc",
                "text/plain"
            },
            {
                ".rc2",
                "text/plain"
            },
            {
                ".rct",
                "text/plain"
            },
            {
                ".rdlc",
                "application/xml"
            },
            {
                ".reg",
                "text/plain"
            },
            {
                ".resx",
                "application/xml"
            },
            {
                ".rf",
                "image/vnd.rn-realflash"
            },
            {
                ".rgb",
                "image/x-rgb"
            },
            {
                ".rgs",
                "text/plain"
            },
            {
                ".rm",
                "application/vnd.rn-realmedia"
            },
            {
                ".rmi",
                "audio/mid"
            },
            {
                ".rmp",
                "application/vnd.rn-rn_music_package"
            },
            {
                ".roff",
                "application/x-troff"
            },
            {
                ".rpm",
                "audio/x-pn-realaudio-plugin"
            },
            {
                ".rqy",
                "text/x-ms-rqy"
            },
            {
                ".rtf",
                "application/rtf"
            },
            {
                ".rtx",
                "text/richtext"
            },
            {
                ".rvt",
                "application/octet-stream"
            },
            {
                ".ruleset",
                "application/xml"
            },
            {
                ".s",
                "text/plain"
            },
            {
                ".safariextz",
                "application/x-safari-safariextz"
            },
            {
                ".scd",
                "application/x-msschedule"
            },
            {
                ".scr",
                "text/plain"
            },
            {
                ".sct",
                "text/scriptlet"
            },
            {
                ".sd2",
                "audio/x-sd2"
            },
            {
                ".sdp",
                "application/sdp"
            },
            {
                ".sea",
                "application/octet-stream"
            },
            {
                ".searchConnector-ms",
                "application/windows-search-connector+xml"
            },
            {
                ".setpay",
                "application/set-payment-initiation"
            },
            {
                ".setreg",
                "application/set-registration-initiation"
            },
            {
                ".settings",
                "application/xml"
            },
            {
                ".sgimb",
                "application/x-sgimb"
            },
            {
                ".sgml",
                "text/sgml"
            },
            {
                ".sh",
                "application/x-sh"
            },
            {
                ".shar",
                "application/x-shar"
            },
            {
                ".shtml",
                "text/html"
            },
            {
                ".sit",
                "application/x-stuffit"
            },
            {
                ".sitemap",
                "application/xml"
            },
            {
                ".skin",
                "application/xml"
            },
            {
                ".skp",
                "application/x-koan"
            },
            {
                ".sldm",
                "application/vnd.ms-powerpoint.slide.macroEnabled.12"
            },
            {
                ".sldx",
                "application/vnd.openxmlformats-officedocument.presentationml.slide"
            },
            {
                ".slk",
                "application/vnd.ms-excel"
            },
            {
                ".sln",
                "text/plain"
            },
            {
                ".slupkg-ms",
                "application/x-ms-license"
            },
            {
                ".smd",
                "audio/x-smd"
            },
            {
                ".smi",
                "application/octet-stream"
            },
            {
                ".smx",
                "audio/x-smd"
            },
            {
                ".smz",
                "audio/x-smd"
            },
            {
                ".snd",
                "audio/basic"
            },
            {
                ".snippet",
                "application/xml"
            },
            {
                ".snp",
                "application/octet-stream"
            },
            {
                ".sol",
                "text/plain"
            },
            {
                ".sor",
                "text/plain"
            },
            {
                ".spc",
                "application/x-pkcs7-certificates"
            },
            {
                ".spl",
                "application/futuresplash"
            },
            {
                ".spx",
                "audio/ogg"
            },
            {
                ".src",
                "application/x-wais-source"
            },
            {
                ".srf",
                "text/plain"
            },
            {
                ".SSISDeploymentManifest",
                "text/xml"
            },
            {
                ".ssm",
                "application/streamingmedia"
            },
            {
                ".sst",
                "application/vnd.ms-pki.certstore"
            },
            {
                ".stl",
                "application/vnd.ms-pki.stl"
            },
            {
                ".sv4cpio",
                "application/x-sv4cpio"
            },
            {
                ".sv4crc",
                "application/x-sv4crc"
            },
            {
                ".svc",
                "application/xml"
            },
            {
                ".svg",
                "image/svg+xml"
            },
            {
                ".swf",
                "application/x-shockwave-flash"
            },
            {
                ".step",
                "application/step"
            },
            {
                ".stp",
                "application/step"
            },
            {
                ".t",
                "application/x-troff"
            },
            {
                ".tar",
                "application/x-tar"
            },
            {
                ".tcl",
                "application/x-tcl"
            },
            {
                ".testrunconfig",
                "application/xml"
            },
            {
                ".testsettings",
                "application/xml"
            },
            {
                ".tex",
                "application/x-tex"
            },
            {
                ".texi",
                "application/x-texinfo"
            },
            {
                ".texinfo",
                "application/x-texinfo"
            },
            {
                ".tgz",
                "application/x-compressed"
            },
            {
                ".thmx",
                "application/vnd.ms-officetheme"
            },
            {
                ".thn",
                "application/octet-stream"
            },
            {
                ".tif",
                "image/tiff"
            },
            {
                ".tiff",
                "image/tiff"
            },
            {
                ".tlh",
                "text/plain"
            },
            {
                ".tli",
                "text/plain"
            },
            {
                ".toc",
                "application/octet-stream"
            },
            {
                ".tr",
                "application/x-troff"
            },
            {
                ".trm",
                "application/x-msterminal"
            },
            {
                ".trx",
                "application/xml"
            },
            {
                ".ts",
                "video/vnd.dlna.mpeg-tts"
            },
            {
                ".tsv",
                "text/tab-separated-values"
            },
            {
                ".ttf",
                "application/font-sfnt"
            },
            {
                ".tts",
                "video/vnd.dlna.mpeg-tts"
            },
            {
                ".txt",
                "text/plain"
            },
            {
                ".u32",
                "application/octet-stream"
            },
            {
                ".uls",
                "text/iuls"
            },
            {
                ".user",
                "text/plain"
            },
            {
                ".ustar",
                "application/x-ustar"
            },
            {
                ".vb",
                "text/plain"
            },
            {
                ".vbdproj",
                "text/plain"
            },
            {
                ".vbk",
                "video/mpeg"
            },
            {
                ".vbproj",
                "text/plain"
            },
            {
                ".vbs",
                "text/vbscript"
            },
            {
                ".vcf",
                "text/x-vcard"
            },
            {
                ".vcproj",
                "application/xml"
            },
            {
                ".vcs",
                "text/plain"
            },
            {
                ".vcxproj",
                "application/xml"
            },
            {
                ".vddproj",
                "text/plain"
            },
            {
                ".vdp",
                "text/plain"
            },
            {
                ".vdproj",
                "text/plain"
            },
            {
                ".vdx",
                "application/vnd.ms-visio.viewer"
            },
            {
                ".vml",
                "text/xml"
            },
            {
                ".vscontent",
                "application/xml"
            },
            {
                ".vsct",
                "text/xml"
            },
            {
                ".vsd",
                "application/vnd.visio"
            },
            {
                ".vsi",
                "application/ms-vsi"
            },
            {
                ".vsix",
                "application/vsix"
            },
            {
                ".vsixlangpack",
                "text/xml"
            },
            {
                ".vsixmanifest",
                "text/xml"
            },
            {
                ".vsmdi",
                "application/xml"
            },
            {
                ".vspscc",
                "text/plain"
            },
            {
                ".vss",
                "application/vnd.visio"
            },
            {
                ".vsscc",
                "text/plain"
            },
            {
                ".vssettings",
                "text/xml"
            },
            {
                ".vssscc",
                "text/plain"
            },
            {
                ".vst",
                "application/vnd.visio"
            },
            {
                ".vstemplate",
                "text/xml"
            },
            {
                ".vsto",
                "application/x-ms-vsto"
            },
            {
                ".vsw",
                "application/vnd.visio"
            },
            {
                ".vsx",
                "application/vnd.visio"
            },
            {
                ".vtt",
                "text/vtt"
            },
            {
                ".vtx",
                "application/vnd.visio"
            },
            {
                ".wasm",
                "application/wasm"
            },
            {
                ".wav",
                "audio/wav"
            },
            {
                ".wave",
                "audio/wav"
            },
            {
                ".wax",
                "audio/x-ms-wax"
            },
            {
                ".wbk",
                "application/msword"
            },
            {
                ".wbmp",
                "image/vnd.wap.wbmp"
            },
            {
                ".wcm",
                "application/vnd.ms-works"
            },
            {
                ".wdb",
                "application/vnd.ms-works"
            },
            {
                ".wdp",
                "image/vnd.ms-photo"
            },
            {
                ".webarchive",
                "application/x-safari-webarchive"
            },
            {
                ".webm",
                "video/webm"
            },
            {
                ".webp",
                "image/webp"
            },
            {
                ".webtest",
                "application/xml"
            },
            {
                ".wiq",
                "application/xml"
            },
            {
                ".wiz",
                "application/msword"
            },
            {
                ".wks",
                "application/vnd.ms-works"
            },
            {
                ".WLMP",
                "application/wlmoviemaker"
            },
            {
                ".wlpginstall",
                "application/x-wlpg-detect"
            },
            {
                ".wlpginstall3",
                "application/x-wlpg3-detect"
            },
            {
                ".wm",
                "video/x-ms-wm"
            },
            {
                ".wma",
                "audio/x-ms-wma"
            },
            {
                ".wmd",
                "application/x-ms-wmd"
            },
            {
                ".wmf",
                "application/x-msmetafile"
            },
            {
                ".wml",
                "text/vnd.wap.wml"
            },
            {
                ".wmlc",
                "application/vnd.wap.wmlc"
            },
            {
                ".wmls",
                "text/vnd.wap.wmlscript"
            },
            {
                ".wmlsc",
                "application/vnd.wap.wmlscriptc"
            },
            {
                ".wmp",
                "video/x-ms-wmp"
            },
            {
                ".wmv",
                "video/x-ms-wmv"
            },
            {
                ".wmx",
                "video/x-ms-wmx"
            },
            {
                ".wmz",
                "application/x-ms-wmz"
            },
            {
                ".woff",
                "application/font-woff"
            },
            {
                ".woff2",
                "application/font-woff2"
            },
            {
                ".wpl",
                "application/vnd.ms-wpl"
            },
            {
                ".wps",
                "application/vnd.ms-works"
            },
            {
                ".wri",
                "application/x-mswrite"
            },
            {
                ".wrl",
                "x-world/x-vrml"
            },
            {
                ".wrz",
                "x-world/x-vrml"
            },
            {
                ".wsc",
                "text/scriptlet"
            },
            {
                ".wsdl",
                "text/xml"
            },
            {
                ".wvx",
                "video/x-ms-wvx"
            },
            {
                ".x",
                "application/directx"
            },
            {
                ".xaf",
                "x-world/x-vrml"
            },
            {
                ".xaml",
                "application/xaml+xml"
            },
            {
                ".xap",
                "application/x-silverlight-app"
            },
            {
                ".xbap",
                "application/x-ms-xbap"
            },
            {
                ".xbm",
                "image/x-xbitmap"
            },
            {
                ".xdr",
                "text/plain"
            },
            {
                ".xht",
                "application/xhtml+xml"
            },
            {
                ".xhtml",
                "application/xhtml+xml"
            },
            {
                ".xla",
                "application/vnd.ms-excel"
            },
            {
                ".xlam",
                "application/vnd.ms-excel.addin.macroEnabled.12"
            },
            {
                ".xlc",
                "application/vnd.ms-excel"
            },
            {
                ".xld",
                "application/vnd.ms-excel"
            },
            {
                ".xlk",
                "application/vnd.ms-excel"
            },
            {
                ".xll",
                "application/vnd.ms-excel"
            },
            {
                ".xlm",
                "application/vnd.ms-excel"
            },
            {
                ".xls",
                "application/vnd.ms-excel"
            },
            {
                ".xlsb",
                "application/vnd.ms-excel.sheet.binary.macroEnabled.12"
            },
            {
                ".xlsm",
                "application/vnd.ms-excel.sheet.macroEnabled.12"
            },
            {
                ".xlsx",
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            },
            {
                ".xlt",
                "application/vnd.ms-excel"
            },
            {
                ".xltm",
                "application/vnd.ms-excel.template.macroEnabled.12"
            },
            {
                ".xltx",
                "application/vnd.openxmlformats-officedocument.spreadsheetml.template"
            },
            {
                ".xlw",
                "application/vnd.ms-excel"
            },
            {
                ".xml",
                "text/xml"
            },
            {
                ".xmp",
                "application/octet-stream"
            },
            {
                ".xmta",
                "application/xml"
            },
            {
                ".xof",
                "x-world/x-vrml"
            },
            {
                ".XOML",
                "text/plain"
            },
            {
                ".xpm",
                "image/x-xpixmap"
            },
            {
                ".xps",
                "application/vnd.ms-xpsdocument"
            },
            {
                ".xrm-ms",
                "text/xml"
            },
            {
                ".xsc",
                "application/xml"
            },
            {
                ".xsd",
                "text/xml"
            },
            {
                ".xsf",
                "text/xml"
            },
            {
                ".xsl",
                "text/xml"
            },
            {
                ".xslt",
                "text/xml"
            },
            {
                ".xsn",
                "application/octet-stream"
            },
            {
                ".xss",
                "application/xml"
            },
            {
                ".xspf",
                "application/xspf+xml"
            },
            {
                ".xtp",
                "application/octet-stream"
            },
            {
                ".xwd",
                "image/x-xwindowdump"
            },
            {
                ".z",
                "application/x-compress"
            },
            {
                ".zip",
                "application/zip"
            },
            {
                "application/fsharp-script",
                ".fsx"
            },
            {
                "application/msaccess",
                ".adp"
            },
            {
                "application/msword",
                ".doc"
            },
            {
                "application/octet-stream",
                ".bin"
            },
            {
                "application/onenote",
                ".one"
            },
            {
                "application/postscript",
                ".eps"
            },
            {
                "application/step",
                ".step"
            },
            {
                "application/vnd.ms-excel",
                ".xls"
            },
            {
                "application/vnd.ms-powerpoint",
                ".ppt"
            },
            {
                "application/vnd.ms-works",
                ".wks"
            },
            {
                "application/vnd.visio",
                ".vsd"
            },
            {
                "application/x-director",
                ".dir"
            },
            {
                "application/x-shockwave-flash",
                ".swf"
            },
            {
                "application/x-x509-ca-cert",
                ".cer"
            },
            {
                "application/x-zip-compressed",
                ".zip"
            },
            {
                "application/xhtml+xml",
                ".xhtml"
            },
            {
                "application/xml",
                ".xml"
            },
            {
                "audio/aac",
                ".AAC"
            },
            {
                "audio/aiff",
                ".aiff"
            },
            {
                "audio/basic",
                ".snd"
            },
            {
                "audio/mid",
                ".midi"
            },
            {
                "audio/wav",
                ".wav"
            },
            {
                "audio/x-m4a",
                ".m4a"
            },
            {
                "audio/x-mpegurl",
                ".m3u"
            },
            {
                "audio/x-pn-realaudio",
                ".ra"
            },
            {
                "audio/x-smd",
                ".smd"
            },
            {
                "image/bmp",
                ".bmp"
            },
            {
                "image/jpeg",
                ".jpg"
            },
            {
                "image/pict",
                ".pic"
            },
            {
                "image/png",
                ".png"
            },
            {
                "image/x-png",
                ".png"
            },
            {
                "image/tiff",
                ".tiff"
            },
            {
                "image/x-macpaint",
                ".mac"
            },
            {
                "image/x-quicktime",
                ".qti"
            },
            {
                "message/rfc822",
                ".eml"
            },
            {
                "text/html",
                ".html"
            },
            {
                "text/plain",
                ".txt"
            },
            {
                "text/scriptlet",
                ".wsc"
            },
            {
                "text/xml",
                ".xml"
            },
            {
                "video/3gpp",
                ".3gp"
            },
            {
                "video/3gpp2",
                ".3gp2"
            },
            {
                "video/mp4",
                ".mp4"
            },
            {
                "video/mpeg",
                ".mpg"
            },
            {
                "video/quicktime",
                ".mov"
            },
            {
                "video/vnd.dlna.mpeg-tts",
                ".m2t"
            },
            {
                "video/x-dv",
                ".dv"
            },
            {
                "video/x-la-asf",
                ".lsf"
            },
            {
                "video/x-ms-asf",
                ".asf"
            },
            {
                "x-world/x-vrml",
                ".xof"
            }
        };
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000016 RID: 22
    public class MissingXPathException : Exception
    {
        // Token: 0x0600017E RID: 382 RVA: 0x0000C36D File Offset: 0x0000A56D
        public MissingXPathException()
        {
        }

        // Token: 0x0600017F RID: 383 RVA: 0x0000C375 File Offset: 0x0000A575
        public MissingXPathException(string message) : base(message)
        {
        }

        // Token: 0x06000180 RID: 384 RVA: 0x0000C37E File Offset: 0x0000A57E
        public MissingXPathException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x02000022 RID: 34
    public class MixedCodeDocument
    {
        // Token: 0x06000234 RID: 564 RVA: 0x00010D88 File Offset: 0x0000EF88
        public MixedCodeDocument()
        {
            this._codefragments = new MixedCodeDocumentFragmentList(this);
            this._textfragments = new MixedCodeDocumentFragmentList(this);
            this._fragments = new MixedCodeDocumentFragmentList(this);
        }

        // Token: 0x1700007B RID: 123
        // (get) Token: 0x06000235 RID: 565 RVA: 0x00010DF8 File Offset: 0x0000EFF8
        public string Code
        {
            get
            {
                string text = "";
                int num = 0;
                foreach (MixedCodeDocumentFragment mixedCodeDocumentFragment in this._fragments)
                {
                    MixedCodeDocumentFragmentType type = mixedCodeDocumentFragment._type;
                    if (type != MixedCodeDocumentFragmentType.Code)
                    {
                        if (type == MixedCodeDocumentFragmentType.Text)
                        {
                            text = text + this.TokenResponseWrite + string.Format(this.TokenTextBlock, num) + "\n";
                            num++;
                        }
                    }
                    else
                    {
                        text = text + ((MixedCodeDocumentCodeFragment)mixedCodeDocumentFragment).Code + "\n";
                    }
                }
                return text;
            }
        }

        // Token: 0x1700007C RID: 124
        // (get) Token: 0x06000236 RID: 566 RVA: 0x00010EA4 File Offset: 0x0000F0A4
        public MixedCodeDocumentFragmentList CodeFragments
        {
            get
            {
                return this._codefragments;
            }
        }

        // Token: 0x1700007D RID: 125
        // (get) Token: 0x06000237 RID: 567 RVA: 0x00010EAC File Offset: 0x0000F0AC
        public MixedCodeDocumentFragmentList Fragments
        {
            get
            {
                return this._fragments;
            }
        }

        // Token: 0x1700007E RID: 126
        // (get) Token: 0x06000238 RID: 568 RVA: 0x00010EB4 File Offset: 0x0000F0B4
        public Encoding StreamEncoding
        {
            get
            {
                return this._streamencoding;
            }
        }

        // Token: 0x1700007F RID: 127
        // (get) Token: 0x06000239 RID: 569 RVA: 0x00010EBC File Offset: 0x0000F0BC
        public MixedCodeDocumentFragmentList TextFragments
        {
            get
            {
                return this._textfragments;
            }
        }

        // Token: 0x0600023A RID: 570 RVA: 0x00010EC4 File Offset: 0x0000F0C4
        public MixedCodeDocumentCodeFragment CreateCodeFragment()
        {
            return (MixedCodeDocumentCodeFragment)this.CreateFragment(MixedCodeDocumentFragmentType.Code);
        }

        // Token: 0x0600023B RID: 571 RVA: 0x00010ED2 File Offset: 0x0000F0D2
        public MixedCodeDocumentTextFragment CreateTextFragment()
        {
            return (MixedCodeDocumentTextFragment)this.CreateFragment(MixedCodeDocumentFragmentType.Text);
        }

        // Token: 0x0600023C RID: 572 RVA: 0x00010EE0 File Offset: 0x0000F0E0
        public void Load(Stream stream)
        {
            this.Load(new StreamReader(stream));
        }

        // Token: 0x0600023D RID: 573 RVA: 0x00010EEE File Offset: 0x0000F0EE
        public void Load(Stream stream, bool detectEncodingFromByteOrderMarks)
        {
            this.Load(new StreamReader(stream, detectEncodingFromByteOrderMarks));
        }

        // Token: 0x0600023E RID: 574 RVA: 0x00010EFD File Offset: 0x0000F0FD
        public void Load(Stream stream, Encoding encoding)
        {
            this.Load(new StreamReader(stream, encoding));
        }

        // Token: 0x0600023F RID: 575 RVA: 0x00010F0C File Offset: 0x0000F10C
        public void Load(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
        {
            this.Load(new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks));
        }

        // Token: 0x06000240 RID: 576 RVA: 0x00010F1C File Offset: 0x0000F11C
        public void Load(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
        {
            this.Load(new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, buffersize));
        }

        // Token: 0x06000241 RID: 577 RVA: 0x00010F2E File Offset: 0x0000F12E
        public void Load(string path)
        {
            this.Load(new StreamReader(path));
        }

        // Token: 0x06000242 RID: 578 RVA: 0x00010F3C File Offset: 0x0000F13C
        public void Load(string path, bool detectEncodingFromByteOrderMarks)
        {
            this.Load(new StreamReader(path, detectEncodingFromByteOrderMarks));
        }

        // Token: 0x06000243 RID: 579 RVA: 0x00010F4B File Offset: 0x0000F14B
        public void Load(string path, Encoding encoding)
        {
            this.Load(new StreamReader(path, encoding));
        }

        // Token: 0x06000244 RID: 580 RVA: 0x00010F5A File Offset: 0x0000F15A
        public void Load(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
        {
            this.Load(new StreamReader(path, encoding, detectEncodingFromByteOrderMarks));
        }

        // Token: 0x06000245 RID: 581 RVA: 0x00010F6A File Offset: 0x0000F16A
        public void Load(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
        {
            this.Load(new StreamReader(path, encoding, detectEncodingFromByteOrderMarks, buffersize));
        }

        // Token: 0x06000246 RID: 582 RVA: 0x00010F7C File Offset: 0x0000F17C
        public void Load(TextReader reader)
        {
            this._codefragments.Clear();
            this._textfragments.Clear();
            using (StreamReader streamReader = reader as StreamReader)
            {
                if (streamReader != null)
                {
                    this._streamencoding = streamReader.CurrentEncoding;
                }
                this._text = reader.ReadToEnd();
            }
            this.Parse();
        }

        // Token: 0x06000247 RID: 583 RVA: 0x00010FE4 File Offset: 0x0000F1E4
        public void LoadHtml(string html)
        {
            this.Load(new StringReader(html));
        }

        // Token: 0x06000248 RID: 584 RVA: 0x00010FF4 File Offset: 0x0000F1F4
        public void Save(Stream outStream)
        {
            StreamWriter writer = new StreamWriter(outStream, this.GetOutEncoding());
            this.Save(writer);
        }

        // Token: 0x06000249 RID: 585 RVA: 0x00011018 File Offset: 0x0000F218
        public void Save(Stream outStream, Encoding encoding)
        {
            StreamWriter writer = new StreamWriter(outStream, encoding);
            this.Save(writer);
        }

        // Token: 0x0600024A RID: 586 RVA: 0x00011034 File Offset: 0x0000F234
        public void Save(string filename)
        {
            StreamWriter writer = new StreamWriter(filename, false, this.GetOutEncoding());
            this.Save(writer);
        }

        // Token: 0x0600024B RID: 587 RVA: 0x00011058 File Offset: 0x0000F258
        public void Save(string filename, Encoding encoding)
        {
            StreamWriter writer = new StreamWriter(filename, false, encoding);
            this.Save(writer);
        }

        // Token: 0x0600024C RID: 588 RVA: 0x00011075 File Offset: 0x0000F275
        public void Save(StreamWriter writer)
        {
            this.Save(writer);
        }

        // Token: 0x0600024D RID: 589 RVA: 0x0001107E File Offset: 0x0000F27E
        public void Save(TextWriter writer)
        {
            writer.Flush();
        }

        // Token: 0x0600024E RID: 590 RVA: 0x00011086 File Offset: 0x0000F286
        internal MixedCodeDocumentFragment CreateFragment(MixedCodeDocumentFragmentType type)
        {
            if (type == MixedCodeDocumentFragmentType.Code)
            {
                return new MixedCodeDocumentCodeFragment(this);
            }
            if (type == MixedCodeDocumentFragmentType.Text)
            {
                return new MixedCodeDocumentTextFragment(this);
            }
            throw new NotSupportedException();
        }

        // Token: 0x0600024F RID: 591 RVA: 0x000110A2 File Offset: 0x0000F2A2
        internal Encoding GetOutEncoding()
        {
            if (this._streamencoding != null)
            {
                return this._streamencoding;
            }
            return Encoding.UTF8;
        }

        // Token: 0x06000250 RID: 592 RVA: 0x000110B8 File Offset: 0x0000F2B8
        private void IncrementPosition()
        {
            this._index++;
            if (this._c == 10)
            {
                this._lineposition = 1;
                this._line++;
                return;
            }
            this._lineposition++;
        }

        // Token: 0x06000251 RID: 593 RVA: 0x000110F8 File Offset: 0x0000F2F8
        private void Parse()
        {
            this._state = MixedCodeDocument.ParseState.Text;
            this._index = 0;
            this._currentfragment = this.CreateFragment(MixedCodeDocumentFragmentType.Text);
            while (this._index < this._text.Length)
            {
                this._c = (int)this._text[this._index];
                this.IncrementPosition();
                MixedCodeDocument.ParseState state = this._state;
                if (state != MixedCodeDocument.ParseState.Text)
                {
                    if (state == MixedCodeDocument.ParseState.Code)
                    {
                        if (this._index + this.TokenCodeEnd.Length < this._text.Length && this._text.Substring(this._index - 1, this.TokenCodeEnd.Length) == this.TokenCodeEnd)
                        {
                            this._state = MixedCodeDocument.ParseState.Text;
                            this._currentfragment.Length = this._index + this.TokenCodeEnd.Length - this._currentfragment.Index;
                            this._index += this.TokenCodeEnd.Length;
                            this._lineposition += this.TokenCodeEnd.Length;
                            this._currentfragment = this.CreateFragment(MixedCodeDocumentFragmentType.Text);
                            this.SetPosition();
                        }
                    }
                }
                else if (this._index + this.TokenCodeStart.Length < this._text.Length && this._text.Substring(this._index - 1, this.TokenCodeStart.Length) == this.TokenCodeStart)
                {
                    this._state = MixedCodeDocument.ParseState.Code;
                    this._currentfragment.Length = this._index - 1 - this._currentfragment.Index;
                    this._currentfragment = this.CreateFragment(MixedCodeDocumentFragmentType.Code);
                    this.SetPosition();
                }
            }
            this._currentfragment.Length = this._index - this._currentfragment.Index;
        }

        // Token: 0x06000252 RID: 594 RVA: 0x000112DC File Offset: 0x0000F4DC
        private void SetPosition()
        {
            this._currentfragment.Line = this._line;
            this._currentfragment._lineposition = this._lineposition;
            this._currentfragment.Index = this._index - 1;
            this._currentfragment.Length = 0;
        }

        // Token: 0x040000BB RID: 187
        private int _c;

        // Token: 0x040000BC RID: 188
        internal MixedCodeDocumentFragmentList _codefragments;

        // Token: 0x040000BD RID: 189
        private MixedCodeDocumentFragment _currentfragment;

        // Token: 0x040000BE RID: 190
        internal MixedCodeDocumentFragmentList _fragments;

        // Token: 0x040000BF RID: 191
        private int _index;

        // Token: 0x040000C0 RID: 192
        private int _line;

        // Token: 0x040000C1 RID: 193
        private int _lineposition;

        // Token: 0x040000C2 RID: 194
        private MixedCodeDocument.ParseState _state;

        // Token: 0x040000C3 RID: 195
        private Encoding _streamencoding;

        // Token: 0x040000C4 RID: 196
        internal string _text;

        // Token: 0x040000C5 RID: 197
        internal MixedCodeDocumentFragmentList _textfragments;

        // Token: 0x040000C6 RID: 198
        public string TokenCodeEnd = "%>";

        // Token: 0x040000C7 RID: 199
        public string TokenCodeStart = "<%";

        // Token: 0x040000C8 RID: 200
        public string TokenDirective = "@";

        // Token: 0x040000C9 RID: 201
        public string TokenResponseWrite = "Response.Write ";

        // Token: 0x040000CA RID: 202
        private string TokenTextBlock = "TextBlock({0})";

        // Token: 0x0200004B RID: 75
        private enum ParseState
        {
            // Token: 0x04000182 RID: 386
            Text,
            // Token: 0x04000183 RID: 387
            Code
        }
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x02000023 RID: 35
    public class MixedCodeDocumentCodeFragment : MixedCodeDocumentFragment
    {
        // Token: 0x06000253 RID: 595 RVA: 0x0001132A File Offset: 0x0000F52A
        internal MixedCodeDocumentCodeFragment(MixedCodeDocument doc) : base(doc, MixedCodeDocumentFragmentType.Code)
        {
        }

        // Token: 0x17000080 RID: 128
        // (get) Token: 0x06000254 RID: 596 RVA: 0x00011334 File Offset: 0x0000F534
        // (set) Token: 0x06000255 RID: 597 RVA: 0x000113E8 File Offset: 0x0000F5E8
        public string Code
        {
            get
            {
                if (this._code == null)
                {
                    this._code = base.FragmentText.Substring(this.Doc.TokenCodeStart.Length, base.FragmentText.Length - this.Doc.TokenCodeEnd.Length - this.Doc.TokenCodeStart.Length - 1).Trim();
                    if (this._code.StartsWith("="))
                    {
                        this._code = this.Doc.TokenResponseWrite + this._code.Substring(1, this._code.Length - 1);
                    }
                }
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }

        // Token: 0x040000CB RID: 203
        private string _code;
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x02000024 RID: 36
    public abstract class MixedCodeDocumentFragment
    {
        // Token: 0x06000256 RID: 598 RVA: 0x000113F4 File Offset: 0x0000F5F4
        internal MixedCodeDocumentFragment(MixedCodeDocument doc, MixedCodeDocumentFragmentType type)
        {
            this.Doc = doc;
            this._type = type;
            if (type != MixedCodeDocumentFragmentType.Code)
            {
                if (type == MixedCodeDocumentFragmentType.Text)
                {
                    this.Doc._textfragments.Append(this);
                }
            }
            else
            {
                this.Doc._codefragments.Append(this);
            }
            this.Doc._fragments.Append(this);
        }

        // Token: 0x17000081 RID: 129
        // (get) Token: 0x06000257 RID: 599 RVA: 0x00011451 File Offset: 0x0000F651
        // (set) Token: 0x06000258 RID: 600 RVA: 0x00011483 File Offset: 0x0000F683
        public string FragmentText
        {
            get
            {
                if (this._fragmentText == null)
                {
                    this._fragmentText = this.Doc._text.Substring(this.Index, this.Length);
                }
                return this._fragmentText;
            }
            internal set
            {
                this._fragmentText = value;
            }
        }

        // Token: 0x17000082 RID: 130
        // (get) Token: 0x06000259 RID: 601 RVA: 0x0001148C File Offset: 0x0000F68C
        public MixedCodeDocumentFragmentType FragmentType
        {
            get
            {
                return this._type;
            }
        }

        // Token: 0x17000083 RID: 131
        // (get) Token: 0x0600025A RID: 602 RVA: 0x00011494 File Offset: 0x0000F694
        // (set) Token: 0x0600025B RID: 603 RVA: 0x0001149C File Offset: 0x0000F69C
        public int Line
        {
            get
            {
                return this._line;
            }
            internal set
            {
                this._line = value;
            }
        }

        // Token: 0x17000084 RID: 132
        // (get) Token: 0x0600025C RID: 604 RVA: 0x000114A5 File Offset: 0x0000F6A5
        public int LinePosition
        {
            get
            {
                return this._lineposition;
            }
        }

        // Token: 0x17000085 RID: 133
        // (get) Token: 0x0600025D RID: 605 RVA: 0x000114AD File Offset: 0x0000F6AD
        public int StreamPosition
        {
            get
            {
                return this.Index;
            }
        }

        // Token: 0x040000CC RID: 204
        internal MixedCodeDocument Doc;

        // Token: 0x040000CD RID: 205
        private string _fragmentText;

        // Token: 0x040000CE RID: 206
        internal int Index;

        // Token: 0x040000CF RID: 207
        internal int Length;

        // Token: 0x040000D0 RID: 208
        private int _line;

        // Token: 0x040000D1 RID: 209
        internal int _lineposition;

        // Token: 0x040000D2 RID: 210
        internal MixedCodeDocumentFragmentType _type;
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x02000025 RID: 37
    public class MixedCodeDocumentFragmentList : IEnumerable
    {
        // Token: 0x0600025E RID: 606 RVA: 0x000114B5 File Offset: 0x0000F6B5
        internal MixedCodeDocumentFragmentList(MixedCodeDocument doc)
        {
            this._doc = doc;
        }

        // Token: 0x17000086 RID: 134
        // (get) Token: 0x0600025F RID: 607 RVA: 0x000114CF File Offset: 0x0000F6CF
        public MixedCodeDocument Doc
        {
            get
            {
                return this._doc;
            }
        }

        // Token: 0x17000087 RID: 135
        // (get) Token: 0x06000260 RID: 608 RVA: 0x000114D7 File Offset: 0x0000F6D7
        public int Count
        {
            get
            {
                return this._items.Count;
            }
        }

        // Token: 0x17000088 RID: 136
        public MixedCodeDocumentFragment this[int index]
        {
            get
            {
                return this._items[index];
            }
        }

        // Token: 0x06000262 RID: 610 RVA: 0x000114F2 File Offset: 0x0000F6F2
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        // Token: 0x06000263 RID: 611 RVA: 0x000114FA File Offset: 0x0000F6FA
        public void Append(MixedCodeDocumentFragment newFragment)
        {
            if (newFragment == null)
            {
                throw new ArgumentNullException("newFragment");
            }
            this._items.Add(newFragment);
        }

        // Token: 0x06000264 RID: 612 RVA: 0x00011516 File Offset: 0x0000F716
        public MixedCodeDocumentFragmentList.MixedCodeDocumentFragmentEnumerator GetEnumerator()
        {
            return new MixedCodeDocumentFragmentList.MixedCodeDocumentFragmentEnumerator(this._items);
        }

        // Token: 0x06000265 RID: 613 RVA: 0x00011523 File Offset: 0x0000F723
        public void Prepend(MixedCodeDocumentFragment newFragment)
        {
            if (newFragment == null)
            {
                throw new ArgumentNullException("newFragment");
            }
            this._items.Insert(0, newFragment);
        }

        // Token: 0x06000266 RID: 614 RVA: 0x00011540 File Offset: 0x0000F740
        public void Remove(MixedCodeDocumentFragment fragment)
        {
            if (fragment == null)
            {
                throw new ArgumentNullException("fragment");
            }
            int fragmentIndex = this.GetFragmentIndex(fragment);
            if (fragmentIndex == -1)
            {
                throw new IndexOutOfRangeException();
            }
            this.RemoveAt(fragmentIndex);
        }

        // Token: 0x06000267 RID: 615 RVA: 0x00011574 File Offset: 0x0000F774
        public void RemoveAll()
        {
            this._items.Clear();
        }

        // Token: 0x06000268 RID: 616 RVA: 0x00011581 File Offset: 0x0000F781
        public void RemoveAt(int index)
        {
            this._items.RemoveAt(index);
        }

        // Token: 0x06000269 RID: 617 RVA: 0x0001158F File Offset: 0x0000F78F
        internal void Clear()
        {
            this._items.Clear();
        }

        // Token: 0x0600026A RID: 618 RVA: 0x0001159C File Offset: 0x0000F79C
        internal int GetFragmentIndex(MixedCodeDocumentFragment fragment)
        {
            if (fragment == null)
            {
                throw new ArgumentNullException("fragment");
            }
            for (int i = 0; i < this._items.Count; i++)
            {
                if (this._items[i] == fragment)
                {
                    return i;
                }
            }
            return -1;
        }

        // Token: 0x040000D3 RID: 211
        private MixedCodeDocument _doc;

        // Token: 0x040000D4 RID: 212
        private IList<MixedCodeDocumentFragment> _items = new List<MixedCodeDocumentFragment>();

        // Token: 0x0200004C RID: 76
        public class MixedCodeDocumentFragmentEnumerator : IEnumerator
        {
            // Token: 0x06000340 RID: 832 RVA: 0x00013B62 File Offset: 0x00011D62
            internal MixedCodeDocumentFragmentEnumerator(IList<MixedCodeDocumentFragment> items)
            {
                this._items = items;
                this._index = -1;
            }

            // Token: 0x170000AF RID: 175
            // (get) Token: 0x06000341 RID: 833 RVA: 0x00013B78 File Offset: 0x00011D78
            public MixedCodeDocumentFragment Current
            {
                get
                {
                    return this._items[this._index];
                }
            }

            // Token: 0x170000B0 RID: 176
            // (get) Token: 0x06000342 RID: 834 RVA: 0x00013B8B File Offset: 0x00011D8B
            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            // Token: 0x06000343 RID: 835 RVA: 0x00013B93 File Offset: 0x00011D93
            public bool MoveNext()
            {
                this._index++;
                return this._index < this._items.Count;
            }

            // Token: 0x06000344 RID: 836 RVA: 0x00013BB6 File Offset: 0x00011DB6
            public void Reset()
            {
                this._index = -1;
            }

            // Token: 0x04000184 RID: 388
            private int _index;

            // Token: 0x04000185 RID: 389
            private IList<MixedCodeDocumentFragment> _items;
        }
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000026 RID: 38
    public enum MixedCodeDocumentFragmentType
    {
        // Token: 0x040000D6 RID: 214
        Code,
        // Token: 0x040000D7 RID: 215
        Text
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000027 RID: 39
    public class MixedCodeDocumentTextFragment : MixedCodeDocumentFragment
    {
        // Token: 0x0600026B RID: 619 RVA: 0x000115DF File Offset: 0x0000F7DF
        internal MixedCodeDocumentTextFragment(MixedCodeDocument doc) : base(doc, MixedCodeDocumentFragmentType.Text)
        {
        }

        // Token: 0x17000089 RID: 137
        // (get) Token: 0x0600026C RID: 620 RVA: 0x000115E9 File Offset: 0x0000F7E9
        // (set) Token: 0x0600026D RID: 621 RVA: 0x000115F1 File Offset: 0x0000F7F1
        public string Text
        {
            get
            {
                return base.FragmentText;
            }
            set
            {
                base.FragmentText = value;
            }
        }
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x02000028 RID: 40
    internal class NameValuePairList
    {
        // Token: 0x0600026E RID: 622 RVA: 0x000115FA File Offset: 0x0000F7FA
        internal NameValuePairList() : this(null)
        {
        }

        // Token: 0x0600026F RID: 623 RVA: 0x00011603 File Offset: 0x0000F803
        internal NameValuePairList(string text)
        {
            this.Text = text;
            this._allPairs = new List<KeyValuePair<string, string>>();
            this._pairsWithName = new Dictionary<string, List<KeyValuePair<string, string>>>();
            this.Parse(text);
        }

        // Token: 0x06000270 RID: 624 RVA: 0x0001162F File Offset: 0x0000F82F
        internal static string GetNameValuePairsValue(string text, string name)
        {
            return new NameValuePairList(text).GetNameValuePairValue(name);
        }

        // Token: 0x06000271 RID: 625 RVA: 0x0001163D File Offset: 0x0000F83D
        internal List<KeyValuePair<string, string>> GetNameValuePairs(string name)
        {
            if (name == null)
            {
                return this._allPairs;
            }
            if (!this._pairsWithName.ContainsKey(name))
            {
                return new List<KeyValuePair<string, string>>();
            }
            return this._pairsWithName[name];
        }

        // Token: 0x06000272 RID: 626 RVA: 0x0001166C File Offset: 0x0000F86C
        internal string GetNameValuePairValue(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException();
            }
            List<KeyValuePair<string, string>> nameValuePairs = this.GetNameValuePairs(name);
            if (nameValuePairs.Count == 0)
            {
                return string.Empty;
            }
            return nameValuePairs[0].Value.Trim();
        }

        // Token: 0x06000273 RID: 627 RVA: 0x000116AC File Offset: 0x0000F8AC
        private void Parse(string text)
        {
            this._allPairs.Clear();
            this._pairsWithName.Clear();
            if (text == null)
            {
                return;
            }
            foreach (string text2 in text.Split(new char[]
            {
                ';'
            }))
            {
                if (text2.Length != 0)
                {
                    string[] array2 = text2.Split(new char[]
                    {
                        '='
                    }, 2);
                    if (array2.Length != 0)
                    {
                        KeyValuePair<string, string> item = new KeyValuePair<string, string>(array2[0].Trim().ToLowerInvariant(), (array2.Length < 2) ? "" : array2[1]);
                        this._allPairs.Add(item);
                        List<KeyValuePair<string, string>> list;
                        if (!this._pairsWithName.TryGetValue(item.Key, out list))
                        {
                            list = new List<KeyValuePair<string, string>>();
                            this._pairsWithName.Add(item.Key, list);
                        }
                        list.Add(item);
                    }
                }
            }
        }

        // Token: 0x040000D8 RID: 216
        internal readonly string Text;

        // Token: 0x040000D9 RID: 217
        private List<KeyValuePair<string, string>> _allPairs;

        // Token: 0x040000DA RID: 218
        private Dictionary<string, List<KeyValuePair<string, string>>> _pairsWithName;
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x02000015 RID: 21
    public class NodeAttributeNotFoundException : Exception
    {
        // Token: 0x0600017B RID: 379 RVA: 0x0000C352 File Offset: 0x0000A552
        public NodeAttributeNotFoundException()
        {
        }

        // Token: 0x0600017C RID: 380 RVA: 0x0000C35A File Offset: 0x0000A55A
        public NodeAttributeNotFoundException(string message) : base(message)
        {
        }

        // Token: 0x0600017D RID: 381 RVA: 0x0000C363 File Offset: 0x0000A563
        public NodeAttributeNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000014 RID: 20
    public class NodeNotFoundException : Exception
    {
        // Token: 0x06000178 RID: 376 RVA: 0x0000C337 File Offset: 0x0000A537
        public NodeNotFoundException()
        {
        }

        // Token: 0x06000179 RID: 377 RVA: 0x0000C33F File Offset: 0x0000A53F
        public NodeNotFoundException(string message) : base(message)
        {
        }

        // Token: 0x0600017A RID: 378 RVA: 0x0000C348 File Offset: 0x0000A548
        public NodeNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x02000010 RID: 16
    public enum ReturnType
    {
        // Token: 0x04000084 RID: 132
        InnerText,
        // Token: 0x04000085 RID: 133
        InnerHtml,
        // Token: 0x04000086 RID: 134
        OuterHtml
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000013 RID: 19
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class SkipNodeNotFoundAttribute : Attribute
    {
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x0200000F RID: 15
    internal static class Tools
    {
        // Token: 0x06000160 RID: 352 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
        internal static bool IsDefinedAttribute(this Type type, Type attributeType)
        {
            if (type == null)
            {
                throw new ArgumentNullException("Parameter type is null when checking type defined attributeType or not.");
            }
            if (attributeType == null)
            {
                throw new ArgumentNullException("Parameter attributeType is null when checking type defined attributeType or not.");
            }
            return type.IsDefined(attributeType, false);
        }

        // Token: 0x06000161 RID: 353 RVA: 0x0000BFD7 File Offset: 0x0000A1D7
        internal static IEnumerable<PropertyInfo> GetPropertiesDefinedXPath(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("Parameter type is null while retrieving properties defined XPathAttribute of Type type.");
            }
            return type.GetProperties().HAPWhere((PropertyInfo x) => x.IsDefined(typeof(XPathAttribute), false));
        }

        // Token: 0x06000162 RID: 354 RVA: 0x0000C018 File Offset: 0x0000A218
        internal static bool IsIEnumerable(this PropertyInfo propertyInfo)
        {
            if (propertyInfo == null)
            {
                throw new ArgumentNullException("Parameter propertyInfo is null while checking propertyInfo for being IEnumerable or not.");
            }
            return !(propertyInfo.PropertyType == typeof(string)) && typeof(IEnumerable).IsAssignableFrom(propertyInfo.PropertyType);
        }

        // Token: 0x06000163 RID: 355 RVA: 0x0000C067 File Offset: 0x0000A267
        internal static IEnumerable<Type> GetGenericTypes(this PropertyInfo propertyInfo)
        {
            if (propertyInfo == null)
            {
                throw new ArgumentNullException("Parameter propertyInfo is null while Getting generic types of Property.");
            }
            return propertyInfo.PropertyType.GetGenericArguments();
        }

        // Token: 0x06000164 RID: 356 RVA: 0x0000C088 File Offset: 0x0000A288
        internal static MethodInfo GetMethodByItsName(this Type type, string methodName)
        {
            if (type == null)
            {
                throw new ArgumentNullException("Parameter type is null while Getting method from it.");
            }
            if (methodName == null || methodName == "")
            {
                throw new ArgumentNullException("Parameter methodName is null while Getting method from Type type.");
            }
            return type.GetMethod(methodName);
        }

        // Token: 0x06000165 RID: 357 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
        internal static IList CreateIListOfType(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("Parameter type is null while creating List<type>.");
            }
            return Activator.CreateInstance(typeof(List<>).MakeGenericType(new Type[]
            {
                type
            })) as IList;
        }

        // Token: 0x06000166 RID: 358 RVA: 0x0000C0F9 File Offset: 0x0000A2F9
        internal static T GetNodeValueBasedOnXPathReturnType<T>(HtmlNode htmlNode, XPathAttribute xPathAttribute)
        {
            if (htmlNode == null)
            {
                throw new ArgumentNullException("parameter html node is null");
            }
            if (xPathAttribute == null)
            {
                throw new ArgumentNullException("parameter xpathAttribute is null");
            }
            return (T)((object)Convert.ChangeType(Tools.GetHtmlForEncapsulation(htmlNode, xPathAttribute.NodeReturnType), typeof(T)));
        }

        // Token: 0x06000167 RID: 359 RVA: 0x0000C138 File Offset: 0x0000A338
        internal static IList GetNodesValuesBasedOnXPathReturnType(HtmlNodeCollection htmlNodeCollection, XPathAttribute xPathAttribute, Type listGenericType)
        {
            if (htmlNodeCollection == null || htmlNodeCollection.Count == 0)
            {
                throw new ArgumentNullException("parameter htmlNodeCollection is null or empty.");
            }
            if (xPathAttribute == null)
            {
                throw new ArgumentNullException("parameter xpathAttribute is null");
            }
            IList list = listGenericType.CreateIListOfType();
            foreach (HtmlNode node in ((IEnumerable<HtmlNode>)htmlNodeCollection))
            {
                list.Add(Convert.ChangeType(Tools.GetHtmlForEncapsulation(node, xPathAttribute.NodeReturnType), listGenericType));
            }
            return list;
        }

        // Token: 0x06000168 RID: 360 RVA: 0x0000C1C0 File Offset: 0x0000A3C0
        internal static IEnumerable<TSource> HAPWhere<TSource>(this IEnumerable<TSource> source, Tools.HAPFunc<TSource, bool> predicate)
        {
            foreach (TSource tsource in source)
            {
                if (predicate(tsource))
                {
                    yield return tsource;
                }
            }
            IEnumerator<TSource> enumerator = null;
            yield break;
            yield break;
        }

        // Token: 0x06000169 RID: 361 RVA: 0x0000C1D7 File Offset: 0x0000A3D7
        internal static bool IsInstantiable(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type is null");
            }
            return !(type.GetConstructor(Type.EmptyTypes) == null);
        }

        // Token: 0x0600016A RID: 362 RVA: 0x0000C204 File Offset: 0x0000A404
        internal static int CountOfIEnumerable<T>(this IEnumerable<T> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("Parameter source is null while counting the IEnumerable");
            }
            int num = 0;
            foreach (var c in source)
            {
                num++;
            }
            return num;
        }

        // Token: 0x0600016B RID: 363 RVA: 0x0000C25C File Offset: 0x0000A45C
        internal static string GetHtmlForEncapsulation(HtmlNode node, ReturnType returnType)
        {
            switch (returnType)
            {
                case ReturnType.InnerText:
                    return node.InnerText;
                case ReturnType.InnerHtml:
                    return node.InnerHtml;
                case ReturnType.OuterHtml:
                    return node.OuterHtml;
                default:
                    throw new InvalidNodeReturnTypeException(string.Format("Invalid ReturnType value {0}", returnType));
            }
        }

        // Token: 0x0200003E RID: 62
        // (Invoke) Token: 0x060002EF RID: 751
        internal delegate TResult HAPFunc<T, TResult>(T arg);
    }
}

namespace HtmlAgilityPack
{
    // Token: 0x02000029 RID: 41
    internal class Trace
    {
        // Token: 0x1700008A RID: 138
        // (get) Token: 0x06000274 RID: 628 RVA: 0x0001178A File Offset: 0x0000F98A
        internal static Trace Current
        {
            get
            {
                if (Trace._current == null)
                {
                    Trace._current = new Trace();
                }
                return Trace._current;
            }
        }

        // Token: 0x06000275 RID: 629 RVA: 0x000117A2 File Offset: 0x0000F9A2
        private void WriteLineIntern(string message, string category)
        {
        }

        // Token: 0x06000276 RID: 630 RVA: 0x000117A4 File Offset: 0x0000F9A4
        public static void WriteLine(string message, string category)
        {
            Trace.Current.WriteLineIntern(message, category);
        }

        // Token: 0x040000DB RID: 219
        internal static Trace _current;
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x0200002A RID: 42
    internal static class Utilities
    {
        // Token: 0x06000278 RID: 632 RVA: 0x000117BC File Offset: 0x0000F9BC
        public static TValue GetDictionaryValueOrDefault<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key, TValue defaultValue = default(TValue)) where TKey : class
        {
            TValue result;
            if (!dict.TryGetValue(key, out result))
            {
                return defaultValue;
            }
            return result;
        }

        // Token: 0x06000279 RID: 633 RVA: 0x000117D8 File Offset: 0x0000F9D8
        internal static object To(this object @this, Type type)
        {
            if (@this != null)
            {
                if (@this.GetType() == type)
                {
                    return @this;
                }
                TypeConverter converter = TypeDescriptor.GetConverter(@this);
                if (converter != null && converter.CanConvertTo(type))
                {
                    return converter.ConvertTo(@this, type);
                }
                converter = TypeDescriptor.GetConverter(type);
                if (converter != null && converter.CanConvertFrom(@this.GetType()))
                {
                    return converter.ConvertFrom(@this);
                }
                if (@this == DBNull.Value)
                {
                    return null;
                }
            }
            return @this;
        }
    }
}


namespace HtmlAgilityPack
{
    // Token: 0x02000012 RID: 18
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class XPathAttribute : Attribute
    {
        // Token: 0x17000049 RID: 73
        // (get) Token: 0x0600016D RID: 365 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
        // (set) Token: 0x0600016E RID: 366 RVA: 0x0000C2AC File Offset: 0x0000A4AC
        internal bool IsNodeReturnTypeExplicitlySet { get; private set; }

        // Token: 0x1700004A RID: 74
        // (get) Token: 0x0600016F RID: 367 RVA: 0x0000C2B5 File Offset: 0x0000A4B5
        public string XPath { get; }

        // Token: 0x1700004B RID: 75
        // (get) Token: 0x06000170 RID: 368 RVA: 0x0000C2BD File Offset: 0x0000A4BD
        // (set) Token: 0x06000171 RID: 369 RVA: 0x0000C2C5 File Offset: 0x0000A4C5
        public string AttributeName { get; set; }

        // Token: 0x1700004C RID: 76
        // (get) Token: 0x06000172 RID: 370 RVA: 0x0000C2CE File Offset: 0x0000A4CE
        // (set) Token: 0x06000173 RID: 371 RVA: 0x0000C2D6 File Offset: 0x0000A4D6
        public ReturnType NodeReturnType
        {
            get
            {
                return this._nodeReturnType;
            }
            set
            {
                this._nodeReturnType = value;
                this.IsNodeReturnTypeExplicitlySet = true;
            }
        }

        // Token: 0x06000174 RID: 372 RVA: 0x0000C2E6 File Offset: 0x0000A4E6
        public XPathAttribute(string xpathString)
        {
            this.XPath = xpathString;
            this._nodeReturnType = ReturnType.InnerText;
        }

        // Token: 0x06000175 RID: 373 RVA: 0x0000C2FC File Offset: 0x0000A4FC
        public XPathAttribute(string xpathString, ReturnType nodeReturnType)
        {
            this.XPath = xpathString;
            this.NodeReturnType = nodeReturnType;
        }

        // Token: 0x06000176 RID: 374 RVA: 0x0000C312 File Offset: 0x0000A512
        public XPathAttribute(string xpathString, string attributeName)
        {
            this.XPath = xpathString;
            this.AttributeName = attributeName;
            this._nodeReturnType = ReturnType.InnerText;
        }

        // Token: 0x04000087 RID: 135
        private ReturnType _nodeReturnType;
    }
}
