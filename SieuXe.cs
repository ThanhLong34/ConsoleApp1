using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SieuXe
    {
        // Fields
        private string hangSX;
        private string loai;
        private uint gia;
        private string kieuXe;
        private int tocDo;

        // Property
        public string HangSX { get => hangSX; set => hangSX = value; }
        public string Loai { get => loai; set => loai = value; }
        public uint Gia { get => gia; set => gia = value; }
        public string KieuXe { get => kieuXe; set => kieuXe = value; }
        public int TocDo { get => tocDo; set => tocDo = value; }

        // Constructor
        public SieuXe()
        {

        }
        public SieuXe(string hangSX, string loai, uint gia, string kieuXe, int tocDo)
        {
            this.hangSX = hangSX;
            this.loai = loai;
            this.gia = gia;
            this.kieuXe = kieuXe;
            this.tocDo = tocDo;
        }
        public SieuXe(string lineData)
        {
            string[] data = lineData.Trim().Split(',');
            hangSX = data[0].Trim();
            loai = data[1].Trim();
            gia = uint.Parse(data[2].Trim());
            kieuXe = data[3].Trim();
            tocDo = int.Parse(data[4].Trim());
        }

        // Methods


        // Override 
        public override string ToString()
        {
            string s = "|{0}|{1}|{2}|{3}|{4}|";
            return string.Format(s, hangSX.PadRight(12), loai.PadRight(12), gia.ToString().PadRight(12), kieuXe.PadRight(12), tocDo.ToString().PadRight(12));
        }


    }
}
