using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAritmetica
{
    
    [ServiceContract]
    public interface IWSaritmetica
    {
        [OperationContract]

        clsAritmetica Sumar(int numero1, int numero2);

    }

    [DataContract]
    public class clsAritmetica
    {
        [DataMember]
        public int numeroA { get; set; }
        [DataMember]
        public int numeroB { get; set; }
        [DataMember]
        public int respuesta { get; set; }
    }

}
