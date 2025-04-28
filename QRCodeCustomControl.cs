using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeControlProject
{
    public partial class QRCodeCustomControl : UserControl
    {
        private string Text;
        private List<byte> Final;

        
        public QRCodeCustomControl()
        {
            InitializeComponent();
        }

        public void AddText(string Text)
        {
            //Numeric mode: 0001
            //Alphanumeric mode: 0010
            //Byte mode: 0100

            this.Text = Text;
            
            byte[] Data = Encoding.UTF8.GetBytes(Text);
            byte Length = (byte)Data.Length;
            byte Mode = 4;
            int ByteCount = Encoding.UTF8.GetBytes(Text).Length;


            List<byte> Code = new List<byte>();
            Code.Add(Mode);
            Code.Add(Length);
            foreach (byte b in Data)
            {
                Code.Add(b);
            }

            int Version = QrVersionSelector.SelectVersion(ByteCount);
            int ErrorCorrectionBytes = QrVersionSelector.GetErrorCorrectionBytes(Version);
            if (Version == -1)
                MessageBox.Show("Túl nagy adat!");
            else
            {
                Final.AddRange(QrDataHelper.AddPadding(Code, ErrorCorrectionBytes));
                Final.AddRange(ReedSalamonEncoder.Encode(Code, ErrorCorrectionBytes));
            }
        }

        public void GenerateQR()
        {

        }
    }
}
