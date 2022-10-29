using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2
{
    class CVatTu
    {
        private string m_maVT, m_tenVT, m_donVT;
        public string maVT
        {
            get { return m_maVT; }
            set { m_maVT = value; }
        }
        public string tenVT
        {
            get { return m_tenVT; }
            set { m_tenVT = value; }
        }
        public string donVT
        {
            get { return m_donVT; }
            set { m_donVT = value; }
        }
        public CVatTu()
        {
            m_tenVT = "";
            m_maVT = "";
            m_donVT = "";
        }
        public CVatTu (string ma,string ten,string donvi)
        {
            m_maVT = ma;
            m_tenVT = ten;
            m_donVT = donvi;
        }
    }
}
