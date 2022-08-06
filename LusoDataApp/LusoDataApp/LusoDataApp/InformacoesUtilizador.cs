using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

using SQLite;


namespace LusoDataApp
{
    public class InformacoesUtilizador
    {
       [PrimaryKey, AutoIncrement]
       public string Nome
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Senha
        {
            get;
            set;
        }
        public float Ordenado
        {
            get;
            set;
        }
        public float Renda
        {
            get;
            set;
        }
        public float Eletricidade
        {
            get;
            set;
        }
        public float Agua
        {
            get;
            set;

        }
        public float Combustivel
        {
            get;
            set;
        }
        public float Alimentacao
        {
            get;
            set;
        }
        public float OutrasDespesas
        {
            get;
            set;
        }
    }
}
