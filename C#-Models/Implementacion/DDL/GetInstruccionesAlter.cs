﻿using ISW712.UTN.EXAMEN1.GRUPONIMER.Builder;
using ISW712.UTN.EXAMEN1.GRUPONIMER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW712.UTN.EXAMEN1.GRUPONIMER.Implementacion.DDL
{
    internal class GetInstruccionesAlter:IGetDDL
    {
        private string version;

        public GetInstruccionesAlter(string version)
        {
            this.version = version;
        }

        public void GetDDL()
        {
            var director = new Director();
            var constructor = new ConstructorConcreto();
            director.Constructor = constructor;
            director.ConstruirAlterMin();
            Console.WriteLine(constructor.GetProducto().ListarPartes());

        }
    }
}
