using System;
using System.Collections.Generic;
using System.Text;

namespace TareaMVVM.Models
{
    public class Cargos
    {
        public string Cargo { get; set; }
        public static List<Cargos> GetCargos()
        {
            var cargo = new List<Cargos>()
            {


                new Cargos(){ Cargo ="CEO" },
                new Cargos(){ Cargo ="Gerente Financiero" },
                new Cargos(){ Cargo ="Gerente de Comunicaciones" },
                 new Cargos(){ Cargo ="Gerente de Marketing" }

            };
            return cargo;
        }
    }
}
