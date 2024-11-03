 namespace Atividade
 {
     class Clientes
    {
        publicstring nome {get; set;}
        publicstring endereco {get; set;}
        publicfloatvalor {get; protectedset;}
        publicfloatvalor_imposto {get; protectedset;}
        publicfloattotal {get; protectedset;}

        publicvirtual void Pagar_Imposto(float v)
        {  
            this.valor = v;
            this.valor_imposto = this.valor* 10 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
 }
