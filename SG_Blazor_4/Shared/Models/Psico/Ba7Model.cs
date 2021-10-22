using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_Blazor_4.Shared.Models.Psico
{
    public class Ba7Model : HeaderTest
    {
        [Key]
        public int IdBa7 { get; set; }

        public int IdOrdenAtencion { get; set; }

        [ForeignKey("IdOrdenAtencion")]
        public OrdenAtencion ordenAtencion { get; set; }

        #region valores

        [Required]
        public int? _1 { get; set; } = -1;
        [Required]
        public int? _2 { get; set; } = -1;
        [Required]
        public int? _3 { get; set; } = -1;
        [Required]
        public int? _4 { get; set; } = -1;

        [Required]
        public int? _5 { get; set; } = -1;
        [Required]
        public int? _6 { get; set; } = -1;
        [Required]
        public int? _7 { get; set; } = -1;
        [Required]
        public int? _8 { get; set; } = -1;
        [Required]
        public int? _9 { get; set; } = -1;
        [Required]
        public int? _10 { get; set; } = -1;
        [Required]
        public int? _11 { get; set; } = -1;
        [Required]
        public int? _12 { get; set; } = -1;
        [Required]
        public int? _13 { get; set; } = -1;
        [Required]
        public int? _14 { get; set; } = -1;
        [Required]
        public int? _15 { get; set; } = -1;
        [Required]
        public int? _16 { get; set; } = -1;
        [Required]
        public int? _17 { get; set; } = -1;
        [Required]
        public int? _18 { get; set; } = -1;
        [Required]
        public int? _19 { get; set; } = -1;
        [Required]
        public int? _20 { get; set; } = -1;
        [Required]
        public int? _21 { get; set; } = -1;
        [Required]
        public int? _22 { get; set; } = -1;
        [Required]
        public int? _23 { get; set; } = -1;
        [Required]
        public int? _24 { get; set; } = -1;
        [Required]
        public int? _25 { get; set; } = -1;
        [Required]
        public int? _26 { get; set; } = -1;
        [Required]
        public int? _27 { get; set; } = -1;
        [Required]
        public int? _28 { get; set; } = -1;
        [Required]
        public int? _29 { get; set; } = -1;
        [Required]
        public int? _30 { get; set; } = -1;
        [Required]
        public int? _31 { get; set; } = -1;
        [Required]
        public int? _32 { get; set; } = -1;
        [Required]
        public int? _33 { get; set; } = -1;
        [Required]
        public int? _34 { get; set; } = -1;
        [Required]
        public int? _35 { get; set; } = -1;
        [Required]
        public int? _36 { get; set; } = -1;
        [Required]
        public int? _37 { get; set; } = -1;
        [Required]
        public int? _38 { get; set; } = -1;
        [Required]
        public int? _39 { get; set; } = -1;
        [Required]
        public int? _40 { get; set; } = -1;
        [Required]
        public int? _41 { get; set; } = -1;
        [Required]
        public int? _42 { get; set; } = -1;
        [Required]
        public int? _43 { get; set; } = -1;
        [Required]
        public int? _44 { get; set; } = -1;
        [Required]
        public int? _45 { get; set; } = -1;
        [Required]
        public int? _46 { get; set; } = -1;
        [Required]
        public int? _47 { get; set; } = -1;
        [Required]
        public int? _48 { get; set; } = -1;
        [Required]
        public int? _49 { get; set; } = -1;
        [Required]
        public int? _50 { get; set; } = -1;
        [Required]
        public int? _51 { get; set; } = -1;
        [Required]
        public int? _52 { get; set; } = -1;
        [Required]
        public int? _53 { get; set; } = -1;
        [Required]
        public int? _54 { get; set; } = -1;
        [Required]
        public int? _55 { get; set; } = -1;
        [Required]
        public int? _56 { get; set; } = -1;
        [Required]
        public int? _57 { get; set; } = -1;
        [Required]
        public int? _58 { get; set; } = -1;
        [Required]
        public int? _59 { get; set; } = -1;
        [Required]
        public int? _60 { get; set; } = -1;
        [Required]
        public int? _61 { get; set; } = -1;
        [Required]
        public int? _62 { get; set; } = -1;
        [Required]
        public int? _63 { get; set; } = -1;
        [Required]
        public int? _64 { get; set; } = -1;
        [Required]
        public int? _65 { get; set; } = -1;
        [Required]
        public int? _66 { get; set; } = -1;
        [Required]
        public int? _67 { get; set; } = -1;
        [Required]
        public int? _68 { get; set; } = -1;
        [Required]
        public int? _69 { get; set; } = -1;
        [Required]
        public int? _70 { get; set; } = -1;
        [Required]
        public int? _71 { get; set; } = -1;
        [Required]
        public int? _72 { get; set; } = -1;
        [Required]
        public int? _73 { get; set; } = -1;
        [Required]
        public int? _74 { get; set; } = -1;
        [Required]
        public int? _75 { get; set; } = -1;
        [Required]
        public int? _76 { get; set; } = -1;
        [Required]
        public int? _77 { get; set; } = -1;
        [Required]
        public int? _78 { get; set; } = -1;
        [Required]
        public int? _79 { get; set; } = -1;
        [Required]
        public int? _80 { get; set; } = -1;

        #endregion

        public int EjericiosResueltos()
        {
            return GetLstResultados().Where(c => c.Respuesta != -1).Count();
        }
        public int Errores()
        {
            return GetLstResultados().Where(c => c.Respuesta == 0).Count();
        }
        public int Aciertos()
        {
            return GetLstResultados().Where(c => c.Respuesta == 1).Count();
        }

        public int Atencion_PD() { return Aciertos(); }

        public int Atencion_PC()
        {
            int apd = Atencion_PD();
            int apc;

            if (apd < 12) { apc = 1; }
            else
            {
                if (apd < 13) { apc = 2; }
                else
                {
                    if (apd < 14) { apc = 3; }
                    else
                    {
                        if (apd < 15) { apc = 4; }
                        else
                        {
                            if (apd < 19) { apc = 5; }
                            else
                            {
                                if (apd < 22) { apc = 10; }
                                else
                                {
                                    if (apd < 24) { apc = 15; }
                                    else
                                    {
                                        if (apd < 26) { apc = 20; }
                                        else
                                        {
                                            if (apd < 27) { apc = 25; }
                                            else
                                            {
                                                if (apd < 29) { apc = 30; }
                                                else
                                                {
                                                    if (apd < 31) { apc = 35; }
                                                    else
                                                    {
                                                        if (apd < 32) { apc = 40; }
                                                        else
                                                        {
                                                            if (apd < 33) { apc = 45; }
                                                            else
                                                            {
                                                                if (apd < 35) { apc = 50; }
                                                                else
                                                                {
                                                                    if (apd < 36) { apc = 55; }
                                                                    else
                                                                    {
                                                                        if (apd < 37) { apc = 60; }
                                                                        else
                                                                        {
                                                                            if (apd < 39) { apc = 65; }
                                                                            else
                                                                            {
                                                                                if (apd < 41) { apc = 70; }
                                                                                else
                                                                                {
                                                                                    if (apd < 44) { apc = 75; }
                                                                                    else
                                                                                    {
                                                                                        if (apd < 48) { apc = 80; }
                                                                                        else
                                                                                        {
                                                                                            if (apd < 56) { apc = 85; }
                                                                                            else
                                                                                            {
                                                                                                if (apd < 64) { apc = 90; }
                                                                                                else
                                                                                                {
                                                                                                    if (apd < 66) { apc = 95; }
                                                                                                    else
                                                                                                    {
                                                                                                        if (apd < 68) { apc = 96; }
                                                                                                        else
                                                                                                        {
                                                                                                            if (apd < 70) { apc = 97; }
                                                                                                            else
                                                                                                            {
                                                                                                                if (apd < 73)
                                                                                                                {
                                                                                                                    apc = 98;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    apc = 99;
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
            return apc;
        }

        public string Atencion_Nivel()
        {
            int apc = Atencion_PC();

            if (apc < 16)
            {
                return "LENTO";
            }
            else
            {
                if (apc < 85)
                {
                    return "NORMAL";
                }
                else
                {
                    return "RAPIDO";
                }
            }

        }

        public float CON()
        {
            var pd = Atencion_PD();
            var er = EjericiosResueltos();
            return (pd / er) * 100;
        }


        public int NivelAptitu_PC()
        {
            var con = CON();
            int pc;
            if (con < 35) { pc = 1; }
            else
            {
                if (con < 37) { pc = 2; }
                else
                {
                    if (con < 40) { pc = 3; }
                    else
                    {
                        if (con < 46) { pc = 4; }
                        else
                        {
                            if (con < 59) { pc = 5; }
                            else
                            {
                                if (con < 63) { pc = 10; }
                                else
                                {
                                    if (con < 68) { pc = 15; }
                                    else
                                    {
                                        if (con < 70) { pc = 20; }
                                        else
                                        {
                                            if (con < 73) { pc = 25; }
                                            else
                                            {
                                                if (con < 75) { pc = 30; }
                                                else
                                                {
                                                    if (con < 78) { pc = 35; }
                                                    else
                                                    {
                                                        if (con < 79) { pc = 40; }
                                                        else
                                                        {
                                                            if (con < 81) { pc = 45; }
                                                            else
                                                            {
                                                                if (con < 82) { pc = 50; }
                                                                else
                                                                {
                                                                    if (con < 83) { pc = 55; }
                                                                    else
                                                                    {
                                                                        if (con < 84) { pc = 60; }
                                                                        else
                                                                        {
                                                                            if (con < 86) { pc = 65; }
                                                                            else
                                                                            {
                                                                                if (con < 88) { pc = 70; }
                                                                                else
                                                                                {
                                                                                    if (con < 89) { pc = 75; }
                                                                                    else
                                                                                    {
                                                                                        if (con < 90) { pc = 80; }
                                                                                        else
                                                                                        {
                                                                                            if (con < 92) { pc = 85; }
                                                                                            else
                                                                                            {
                                                                                                if (con < 95) { pc = 90; }
                                                                                                else
                                                                                                {
                                                                                                    if (con < 96) { pc = 95; }
                                                                                                    else
                                                                                                    {
                                                                                                        if (con < 97) { pc = 96; }
                                                                                                        else
                                                                                                        {
                                                                                                            if (con < 98) { pc = 97; }
                                                                                                            else
                                                                                                            {
                                                                                                                if (con < 100)
                                                                                                                {
                                                                                                                    pc = 98;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    pc = 99;
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
            return pc;
        }

        public string NivelAptirudinal()
        {
            var pc = NivelAptitu_PC();
            if (pc < 16)
            {
                return "IMPRECISO";
            }
            else
            {
                if (pc < 85)
                {
                    return "NORMAL";
                }
                else
                {
                    return "PRECISO";
                }
            }
        }
        public List<Resultado> GetLstResultados()
        {
            Type type = this.GetType();
            System.Reflection.PropertyInfo[] oBa7s = type.GetProperties();

            Ba7_Respuestas ba7_Respuesta = new Ba7_Respuestas();
            Type type1 = ba7_Respuesta.GetType();
            System.Reflection.PropertyInfo[] oBa7_Respuestas = type1.GetProperties();

            var Resultados = new List<Resultado>();

            foreach (var oBa7_Respuesta in oBa7_Respuestas)
            {
                //trae la propiedad con el mismo nombre
                var oBa7 = oBa7s.Where(c => c.Name == oBa7_Respuesta.Name).FirstOrDefault();
                //Valores de la propiedad
                int ba7Value = int.Parse(oBa7.GetValue(this, null).ToString());
                int ba7RespValue = int.Parse(oBa7_Respuesta.GetValue(ba7_Respuesta, null).ToString());

                if (ba7Value == -1)
                {

                    Resultados.Add(new Resultado { Pregunta = oBa7.Name, Respuesta = -1 });
                }
                else if (ba7Value == ba7RespValue)
                {
                    Resultados.Add(new Resultado { Pregunta = oBa7.Name, Respuesta = 1 }); // 1=verdader0 0=falso
                }
                else
                {

                    Resultados.Add(new Resultado { Pregunta = oBa7.Name, Respuesta = 0 });

                }
            }
            return Resultados;
        }


        public Ba7Model()
        {

        }
    }
    public class Ba7_Respuestas
    {

        #region valores

        public int _1 { get; } = 2;
        public int _2 { get; } = 2;
        public int _3 { get; } = 1;
        public int _4 { get; } = 0;
        public int _5 { get; } = 1;
        public int _6 { get; } = 2;
        public int _7 { get; } = 1;
        public int _8 { get; } = 1;
        public int _9 { get; } = 3;
        public int _10 { get; } = 1;
        public int _11 { get; } = 3;
        public int _12 { get; } = 0;
        public int _13 { get; } = 3;
        public int _14 { get; } = 1;
        public int _15 { get; } = 3;
        public int _16 { get; } = 1;
        public int _17 { get; } = 1;
        public int _18 { get; } = 2;
        public int _19 { get; } = 1;
        public int _20 { get; } = 2;
        public int _21 { get; } = 3;
        public int _22 { get; } = 1;
        public int _23 { get; } = 2;
        public int _24 { get; } = 1;
        public int _25 { get; } = 2;
        public int _26 { get; } = 2;
        public int _27 { get; } = 0;
        public int _28 { get; } = 1;
        public int _29 { get; } = 0;
        public int _30 { get; } = 1;
        public int _31 { get; } = 2;
        public int _32 { get; } = 2;
        public int _33 { get; } = 3;
        public int _34 { get; } = 0;
        public int _35 { get; } = 3;
        public int _36 { get; } = 2;
        public int _37 { get; } = 0;
        public int _38 { get; } = 1;
        public int _39 { get; } = 3;
        public int _40 { get; } = 0;
        public int _41 { get; } = 0;
        public int _42 { get; } = 3;
        public int _43 { get; } = 1;
        public int _44 { get; } = 2;
        public int _45 { get; } = 1;
        public int _46 { get; } = 0;
        public int _47 { get; } = 1;
        public int _48 { get; } = 2;
        public int _49 { get; } = 0;
        public int _50 { get; } = 2;
        public int _51 { get; } = 0;
        public int _52 { get; } = 3;
        public int _53 { get; } = 0;
        public int _54 { get; } = 0;
        public int _55 { get; } = 0;
        public int _56 { get; } = 2;
        public int _57 { get; } = 2;
        public int _58 { get; } = 1;
        public int _59 { get; } = 0;
        public int _60 { get; } = 3;
        public int _61 { get; } = 3;
        public int _62 { get; } = 2;
        public int _63 { get; } = 1;
        public int _64 { get; } = 2;
        public int _65 { get; } = 1;
        public int _66 { get; } = 3;
        public int _67 { get; } = 2;
        public int _68 { get; } = 0;
        public int _69 { get; } = 1;
        public int _70 { get; } = 3;
        public int _71 { get; } = 2;
        public int _72 { get; } = 2;
        public int _73 { get; } = 2;
        public int _74 { get; } = 0;
        public int _75 { get; } = 0;
        public int _76 { get; } = 1;
        public int _77 { get; } = 1;
        public int _78 { get; } = 3;
        public int _79 { get; } = 0;
        public int _80 { get; } = 0;



        #endregion

    }
    public class Resultado
    {
        public string Pregunta { get; set; }
        public int Respuesta { get; set; }
    }

}
