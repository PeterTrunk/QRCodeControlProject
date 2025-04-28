using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeControlProject
{
    internal class QrDataHelper
    {
        /// <summary>
        /// Kitölti az adatfolyamot padding bájtokkal (0xEC és 0x11 váltakozva),
        /// amíg el nem éri a kívánt hosszúságot.
        /// </summary>
        /// <param name="data">A meglévő adatfolyam</param>
        /// <param name="targetLength">A kívánt végső hossz</param>
        public static List<byte> AddPadding(List<byte> data, int targetLength)
        {
            bool toggle = true;

            while (data.Count < targetLength)
            {
                data.Add(toggle ? (byte)0xEC : (byte)0x11);
                toggle = !toggle; // váltogat EC és 11 között
            }
            return data;
        }
    }
}
