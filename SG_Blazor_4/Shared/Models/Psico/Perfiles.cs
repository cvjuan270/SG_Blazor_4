using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG_Blazor_4.Shared.Models.Psico
{
    public class PerPsico
    {

        public int IdPerPsico { get; set; }
        public string Nombre { get; set; }
        public ICollection<PruebaPsico> pruebasPsico { get; set; }

        public PerPsico()
        {
            pruebasPsico = new HashSet<PruebaPsico>();
        }
    }

    public class Perfiles
    {
        public static List<PerPsico> GetPerfiles()
        {
            var lstPruebas = PruebasPsico.GetPruebasPsico();
            var lst1 = new List<PerPsico>(){

                new PerPsico{ IdPerPsico=1,Nombre="BASICO-Profesional y administrativo", pruebasPsico= lstPruebas.Where(c=>c.IdPruebaPsico==1 || c.IdPruebaPsico==2).ToList()},
                new PerPsico{ IdPerPsico =2,Nombre="BASICO-TECNICO", pruebasPsico= lstPruebas.Where(c=>c.IdPruebaPsico ==3 || c.IdPruebaPsico==4).ToList() },
                new PerPsico{ IdPerPsico =3,Nombre="BASICO-OPERARIO",pruebasPsico = lstPruebas.Where(c=>c.IdPruebaPsico==5 || c.IdPruebaPsico==6).ToList()},
                new PerPsico{ IdPerPsico =2,Nombre="BASICO-BRIGADISTA", pruebasPsico= lstPruebas.Where(c=>c.IdPruebaPsico==7||c.IdPruebaPsico==8).ToList()},
                new PerPsico{ IdPerPsico =2,Nombre="BASICO-OBLIGATORIO (TODOS)",pruebasPsico = lstPruebas.Where(c=>c.IdPruebaPsico == 9 || c.IdPruebaPsico == 10|| c.IdPruebaPsico == 11 || c.IdPruebaPsico == 12).ToList()}
            };

            return lst1;
        }
    }

    public class PruebaPsico
    {

        public int IdPruebaPsico { get; set; }
        public string Nombre { get; set; }



    }

    public class PruebasPsico
    {
        public static IEnumerable<PruebaPsico> GetPruebasPsico()
        {
            var lst = new List<PruebaPsico>();

            lst.Add(new PruebaPsico { IdPruebaPsico = 1, Nombre = "DISC" });
            lst.Add(new PruebaPsico { IdPruebaPsico = 3, Nombre = "Test de Lucher" });
            lst.Add(new PruebaPsico { IdPruebaPsico = 8, Nombre = "IG2 - Tony 2" });
            lst.Add(new PruebaPsico { IdPruebaPsico = 9, Nombre = "Cuestionario de persepción del riesgo" });
            lst.Add(new PruebaPsico { IdPruebaPsico = 10, Nombre = "BA7-A (Atención y consentración)" });
            lst.Add(new PruebaPsico { IdPruebaPsico = 12, Nombre = "LSB-50 (Minimult)" });

            return lst;
        }
    }
}
