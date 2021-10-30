using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_Blazor_4.Shared.Models.Psico
{
    public class LSB_50Model : HeaderTest
    {
        public LSB_50Model()
        {
            Fecha = DateTime.Now;
        }

        [Key]
        public int IdLSB_50 { get; set; }

        public int IdOrdenAtencion { get; set; }

        [ForeignKey("IdOrdenAtencion")]
        public OrdenAtencionModel ordenAtencion { get; set; }

        #region valores

        [Required]
        public int? _1 { get; set; }
        [Required]
        public int? _2 { get; set; }
        [Required]
        public int? _3 { get; set; }
        [Required]
        public int? _4 { get; set; }
        [Required]
        public int? _5 { get; set; }
        [Required]
        public int? _6 { get; set; }
        [Required]
        public int? _7 { get; set; }
        [Required]
        public int? _8 { get; set; }
        [Required]
        public int? _9 { get; set; }
        [Required]
        public int? _10 { get; set; }
        [Required]
        public int? _11 { get; set; }
        [Required]
        public int? _12 { get; set; }
        [Required]
        public int? _13 { get; set; }
        [Required]
        public int? _14 { get; set; }
        [Required]
        public int? _15 { get; set; }
        [Required]
        public int? _16 { get; set; }
        [Required]
        public int? _17 { get; set; }
        [Required]
        public int? _18 { get; set; }
        [Required]
        public int? _19 { get; set; }
        [Required]
        public int? _20 { get; set; }
        [Required]
        public int? _21 { get; set; }
        [Required]
        public int? _22 { get; set; }
        [Required]
        public int? _23 { get; set; }
        [Required]
        public int? _24 { get; set; }
        [Required]
        public int? _25 { get; set; }
        [Required]
        public int? _26 { get; set; }
        [Required]
        public int? _27 { get; set; }
        [Required]
        public int? _28 { get; set; }
        [Required]
        public int? _29 { get; set; }
        [Required]
        public int? _30 { get; set; }
        [Required]
        public int? _31 { get; set; }
        [Required]
        public int? _32 { get; set; }
        [Required]
        public int? _33 { get; set; }
        [Required]
        public int? _34 { get; set; }
        [Required]
        public int? _35 { get; set; }
        [Required]
        public int? _36 { get; set; }
        [Required]
        public int? _37 { get; set; }
        [Required]
        public int? _38 { get; set; }
        [Required]
        public int? _39 { get; set; }
        [Required]
        public int? _40 { get; set; }
        [Required]
        public int? _41 { get; set; }
        [Required]
        public int? _42 { get; set; }
        [Required]
        public int? _43 { get; set; }
        [Required]
        public int? _44 { get; set; }
        [Required]
        public int? _45 { get; set; }
        [Required]
        public int? _46 { get; set; }
        [Required]
        public int? _47 { get; set; }
        [Required]
        public int? _48 { get; set; }
        [Required]
        public int? _49 { get; set; }
        [Required]
        public int? _50 { get; set; }

        #endregion

        #region resultados
        #region Cuadro PC LSB-50
        public int Min() { return (int)(_2 + _4 + _9 + _11 + _12 + _13 + _30 + _49); }
        public int Mag() { return (int)(_5 + _10 + _17 + _22 + _26 + _29 + _42 + _46); }
        public int Pr() { return (int)(_6 + _7 + _8 + _15 + _16 + _24 + _26 + _29 + _30 + _31 + _33 + _36 + _38 + _40); }
        public int Hp() { return (int)(_16 + _24 + _26 + _29 + _30 + _38 + _40); }
        public int Ob() { return (int)(_6 + _7 + _8 + _15 + _31 + _33 + _36); }
        public int An() { return (int)(_4 + _10 + _18 + _22 + _25 + _34 + _35 + _47 + _50); }
        public int Hs() { return (int)(_3 + _9 + _23 + _41 + _44 + _48); }
        public int Sm() { return (int)(_6 + _7 + _8 + _15 + _16 + _24 + _26 + _29 + _30 + _31 + _33 + _36 + _38 + _40); }
        public int De() { return (int)(_2 + _12 + _17 + _21 + _28 + _32 + _37 + _39 + _42 + _49); }
        public int Su() { return (int)(_13 + _14 + _27); }
        public int Su_a() { return (int)(_2 + _13 + _14 + _27 + _34 + _37 + _50); }
        public int IRPsi() { return (int)(_5 + _17 + _18 + _22 + _25 + _29 + _31 + _32 + _34 + _42 + _47 + _50); }
        #endregion

        #region MyRegion
        public int Total() { return Pr() + An() + Hs() + Sm() + De() + Su(); }
        public decimal PdGlobal() { return Total() / 50; }
        public int Pc()
        {
            int Pc = 0;
            decimal pd = PdGlobal();
            if (pd < 0.02m) { Pc = 2; }
            else
            {
                if (pd < 0.04m) { Pc = 3; }
                else
                {
                    if (pd < 0.06m) { Pc = 4; }
                    else
                    {
                        if (pd < 0.1m) { Pc = 5; }
                        else
                        {
                            if (pd < 0.13m) { Pc = 10; }
                            else
                            {
                                if (pd < 0.18m) { Pc = 15; }
                                else
                                {
                                    if (pd < 0.19m) { Pc = 20; }
                                    else
                                    {
                                        if (pd < 0.22m) { Pc = 25; }
                                        else
                                        {
                                            if (pd < 0.26m) { Pc = 30; }
                                            else
                                            {
                                                if (pd < 0.31m) { Pc = 35; }
                                                else
                                                {
                                                    if (pd < 0.33m) { Pc = 40; }
                                                    else
                                                    {
                                                        if (pd < 0.37m) { Pc = 45; }
                                                        else
                                                        {
                                                            if (pd < 0.39m) { Pc = 50; }
                                                            else
                                                            {
                                                                if (pd < 0.44m) { Pc = 55; }
                                                                else
                                                                {
                                                                    if (pd < 0.51m) { Pc = 60; }
                                                                    else
                                                                    {
                                                                        if (pd < 0.53m) { Pc = 65; }
                                                                        else
                                                                        {
                                                                            if (pd < 0.6m) { Pc = 70; }
                                                                            else
                                                                            {
                                                                                if (pd < 0.64m) { Pc = 75; }
                                                                                else
                                                                                {
                                                                                    if (pd < 0.72m) { Pc = 80; }
                                                                                    else
                                                                                    {
                                                                                        if (pd < 0.85m) { Pc = 85; }
                                                                                        else
                                                                                        {
                                                                                            if (pd < 1.07m) { Pc = 90; }
                                                                                            else
                                                                                            {
                                                                                                if (pd < 1.2m) { Pc = 95; }
                                                                                                else
                                                                                                {
                                                                                                    if (pd < 1.31m) { Pc = 96; }
                                                                                                    else
                                                                                                    {
                                                                                                        if (pd < 1.39m) { Pc = 97; }
                                                                                                        else
                                                                                                        {
                                                                                                            if (pd < 1.51m) { Pc = 98; }
                                                                                                            else
                                                                                                            {
                                                                                                                if (pd < 4.01m)
                                                                                                                {
                                                                                                                    Pc = 99;
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return Pc;
        }
        public int NumCer()
        {
            int CerosCount = 0;
            List<int> lst = new();
            lst.Add((int)(_1));
            lst.Add((int)(_2));
            lst.Add((int)(_3));
            lst.Add((int)(_4));
            lst.Add((int)(_5));
            lst.Add((int)(_6));
            lst.Add((int)(_7));
            lst.Add((int)(_8));
            lst.Add((int)(_9));
            lst.Add((int)(_10));
            lst.Add((int)(_11));
            lst.Add((int)(_12));
            lst.Add((int)(_13));
            lst.Add((int)(_14));
            lst.Add((int)(_15));
            lst.Add((int)(_16));
            lst.Add((int)(_17));
            lst.Add((int)(_18));
            lst.Add((int)(_19));
            lst.Add((int)(_20));
            lst.Add((int)(_21));
            lst.Add((int)(_22));
            lst.Add((int)(_23));
            lst.Add((int)(_24));
            lst.Add((int)(_25));
            lst.Add((int)(_26));
            lst.Add((int)(_27));
            lst.Add((int)(_28));
            lst.Add((int)(_29));
            lst.Add((int)(_30));
            lst.Add((int)(_31));
            lst.Add((int)(_32));
            lst.Add((int)(_33));
            lst.Add((int)(_34));
            lst.Add((int)(_35));
            lst.Add((int)(_36));
            lst.Add((int)(_37));
            lst.Add((int)(_38));
            lst.Add((int)(_39));
            lst.Add((int)(_40));
            lst.Add((int)(_41));
            lst.Add((int)(_42));
            lst.Add((int)(_43));
            lst.Add((int)(_44));
            lst.Add((int)(_45));
            lst.Add((int)(_46));
            lst.Add((int)(_47));
            lst.Add((int)(_48));
            lst.Add((int)(_49));
            lst.Add((int)(_50));

            foreach (var item in lst)
            {
                if (item == 0)
                {
                    CerosCount++;
                }
            }
            return CerosCount;
        }
        public int PdNum()
        {
            return 50 - NumCer();
        }
        public int Pc1()
        {
            int pc1 = 0;
            int pd = PdNum();
            if (pd == 0) { pc1 = 1; }
            else
            {
                if (pd == 1) { pc1 = 3; }
                else
                {
                    if (pd < 4) { pc1 = 5; }
                    else
                    {
                        if (pd == 4) { pc1 = 10; }
                        else
                        {
                            if (pd == 5) { pc1 = 15; }
                            else
                            {
                                if (pd == 6) { pc1 = 20; }
                                else
                                {
                                    if (pd == 7) { pc1 = 25; }
                                    else
                                    {
                                        if (pd == 8) { pc1 = 30; }
                                        else
                                        {
                                            if (pd == 9) { pc1 = 35; }
                                            else
                                            {
                                                if (pd == 10) { pc1 = 40; }
                                                else
                                                {
                                                    if (pd == 11) { pc1 = 45; }
                                                    else
                                                    {
                                                        if (pd == 12) { pc1 = 50; }
                                                        else
                                                        {
                                                            if (pd == 13) { pc1 = 55; }
                                                            else
                                                            {
                                                                if (pd == 14) { pc1 = 60; }
                                                                else
                                                                {
                                                                    if (pd == 15) { pc1 = 65; }
                                                                    else
                                                                    {
                                                                        if (pd < 19) { pc1 = 70; }
                                                                        else
                                                                        {
                                                                            if (pd == 19) { pc1 = 75; }
                                                                            else
                                                                            {
                                                                                if (pd < 23) { pc1 = 80; }
                                                                                else
                                                                                {
                                                                                    if (pd < 25) { pc1 = 85; }
                                                                                    else
                                                                                    {
                                                                                        if (pd < 29) { pc1 = 90; }
                                                                                        else
                                                                                        {
                                                                                            if (pd < 32) { pc1 = 95; }
                                                                                            else
                                                                                            {
                                                                                                if (pd < 34) { pc1 = 96; }
                                                                                                else
                                                                                                {
                                                                                                    if (pd < 36) { pc1 = 97; }
                                                                                                    else
                                                                                                    {
                                                                                                        if (pd == 36) { pc1 = 98; }
                                                                                                        else
                                                                                                        {
                                                                                                            if (pd < 51)
                                                                                                            {
                                                                                                                pc1 = 99;
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return pc1;
        }
        public double PdInt()
        {
            if (Total() > 0 & PdNum() > 0)
            {
                return (double)(Total() / PdNum());
            }
            else
            {
                return 0;
            }
        }
        public double Pc2()
        {
            double pdint = (double)PdInt();
            double pc2 = 0;
            if (pdint < 1.1) { pc2 = 10; }
            else
            {
                if (pdint < 1.13) { pc2 = 15; }
                else
                {
                    if (pdint < 1.21) { pc2 = 20; }
                    else
                    {
                        if (pdint < 1.26) { pc2 = 25; }
                        else
                        {
                            if (pdint < 1.33) { pc2 = 30; }
                            else
                            {
                                if (pdint < 1.38) { pc2 = 35; }
                                else
                                {
                                    if (pdint < 1.44) { pc2 = 40; }
                                    else
                                    {
                                        if (pdint < 1.5) { pc2 = 45; }
                                        else
                                        {
                                            if (pdint < 1.56) { pc2 = 50; }
                                            else
                                            {
                                                if (pdint < 1.62) { pc2 = 55; }
                                                else
                                                {
                                                    if (pdint < 1.68) { pc2 = 60; }
                                                    else
                                                    {
                                                        if (pdint < 1.78) { pc2 = 65; }
                                                        else
                                                        {
                                                            if (pdint < 1.86) { pc2 = 70; }
                                                            else
                                                            {
                                                                if (pdint < 2) { pc2 = 75; }
                                                                else
                                                                {
                                                                    if (pdint < 2.13) { pc2 = 80; }
                                                                    else
                                                                    {
                                                                        if (pdint < 2.21) { pc2 = 85; }
                                                                        else
                                                                        {
                                                                            if (pdint < 2.36) { pc2 = 90; }
                                                                            else
                                                                            {
                                                                                if (pdint < 2.5) { pc2 = 95; }
                                                                                else
                                                                                {
                                                                                    if (pdint < 2.6) { pc2 = 96; }
                                                                                    else
                                                                                    {
                                                                                        if (pdint < 2.71) { pc2 = 97; }
                                                                                        else
                                                                                        {
                                                                                            if (pdint < 3) { pc2 = 98; }
                                                                                            else
                                                                                            {
                                                                                                if (pdint < 4.01)
                                                                                                {
                                                                                                    pc2 = 99;
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return pc2;
        }
        public string IndiceGlobal()
        {
            string indiceGlobal;
            var pc = Pc();
            if (pc <= 15)
            {
                indiceGlobal = "BAJO";
            }
            else if (pc < 85)
            {
                indiceGlobal = "MODERADO";
            }
            else
            {
                indiceGlobal = "ALTO";
            }
            return indiceGlobal;
        }
        public string NumSintimas()
        {
            string NumSintomas;
            var pc = Pc1();
            if (pc <= 15)
            {
                NumSintomas = "BAJO";
            }
            else if (pc < 85)
            {
                NumSintomas = "MODERADO";
            }
            else
            {
                NumSintomas = "ALTO";
            }
            return NumSintomas;
        }
        public string IntensidadSintomas()
        {
            string intensidadSintomas;
            var pc = Pc2();
            if (String.IsNullOrEmpty(pc.ToString()))
            {
                intensidadSintomas = "INVALIDO";
            }
            else if (pc <= 15)
            {
                intensidadSintomas = "BAJO";
            }
            else if (pc < 85)
            {
                intensidadSintomas = "MODERADO";
            }
            else
            {
                intensidadSintomas = "ALTO";
            }
            return intensidadSintomas;
        }
        #endregion
        #endregion
    }
}
