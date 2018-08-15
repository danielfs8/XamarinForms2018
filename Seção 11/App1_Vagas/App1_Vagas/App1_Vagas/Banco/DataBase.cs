using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using App1_Vagas.Modelos;
using Xamarin.Forms;

namespace App1_Vagas.Banco
{
    class DataBase
    {
        private SQLiteConnection _conexao;
    
        public DataBase()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminnho("database.sqlite");
            _conexao = new SQLiteConnection(caminho);
        }
        /*
        public List<Vaga> Consultar()
        {
            return (List<Vaga>)null;
        }
        public Vaga ObterVagaPorID()
        {
            return null;
        }

        public void Cadastro(Vaga vaga)
        {
            return null;
        }
        public void Exclusao( Vaga vaga)
        {
            return null;
        }
        public void Atualizacao(Vaga vaga)
        {
            return null;
        } */
    }   
 }
