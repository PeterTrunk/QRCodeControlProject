using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeControlProject
{
    internal class QrVersionSelector
    {
        private static readonly (int Version, int MaxBytes, int ErrorCorrectionBytes)[] VersionTable = new (int, int, int)[]
        {
            (1, 14, 10),
            (2, 26, 16),
            (3, 42, 26),
            (4, 62, 36),
            (5, 84, 48),
            (6, 106, 64),
            (7, 122, 72),
            (8, 152, 88),
            (9, 180, 110),
            (10, 213, 130),
            (11, 251, 150),
            (12, 287, 176),
            (13, 331, 198),
            (14, 362, 216),
            (15, 412, 240),
            (16, 450, 280),
            (17, 504, 308),
            (18, 560, 338),
            (19, 624, 364),
            (20, 666, 416),
            (21, 711, 442),
            (22, 779, 476),
            (23, 857, 504),
            (24, 911, 560),
            (25, 997, 588),
            (26, 1059, 644),
            (27, 1125, 702),
            (28, 1190, 742),
            (29, 1264, 790),
            (30, 1370, 842),
            (31, 1452, 898),
            (32, 1538, 958),
            (33, 1628, 983),
            (34, 1722, 1051),
            (35, 1809, 1093),
            (36, 1911, 1139),
            (37, 1989, 1219),
            (38, 2099, 1273),
            (39, 2213, 1322),
            (40, 2331, 1424)
        };

        /// <summary>
        /// Verzió kiválasztása adott adatmennyiség alapján
        /// </summary>
        /// <param name="dataLength">Az adat hossza bájtban</param>
        /// <returns>A legkisebb QR verzió, ami elfér, vagy -1 ha nem lehet kódolni</returns>
        public static int SelectVersion(int dataLength)
        {
            foreach (var entry in VersionTable)
            {
                if (dataLength <= entry.MaxBytes)
                    return entry.Version;
            }
            //Fallback
            return -1;
        }

        /// <summary>
        /// Hibajavító bájtok számának lekérése adott verzió alapján
        /// </summary>
        public static int GetErrorCorrectionBytes(int version)
        {
            foreach (var entry in VersionTable)
            {
                if (entry.Version == version)
                    return entry.ErrorCorrectionBytes;
            }
            //Fallback
            return -1;
        }

    }
}
