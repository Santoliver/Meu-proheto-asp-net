using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pnoticias.BLL
{
    public class VotosBLL
    {
        private int IdVoto_;
        private int Voto1_;
        private int Voto2_;
        private int Voto3_;
        private int Vototol_;
        public int IdVoto
        {
            get { return IdVoto_; } set { IdVoto_ = value; }
        }
        public int Voto1
        {
            get { return Voto1_; } set { Voto1_ = value;  }
        }
        public int Voto2
        {
            get { return Voto2_; } set { Voto2_ = value; }
        }
        public int Voto3
        {
            get { return Voto3_; }  set { Voto3_ = value; }
        }
        public int Vototol
        {
            get { return Vototol_; } set { Vototol_ = value; }
        }
    }
}