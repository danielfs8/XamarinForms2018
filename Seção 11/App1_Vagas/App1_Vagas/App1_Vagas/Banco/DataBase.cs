using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using App1_Vagas.Modelos;
using Xamarin.Forms;
using System.Linq;

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
            _conexao.CreateTable<Vaga>();

        }
        
        public List<Vaga> Consultar()
        {
            return _conexao.Table<Vaga>().ToList();
        }
      public Vaga ObterVagaPorID(int id)
        {
            return _conexao.Table<Vaga>().Where(a => a.Id == id).FirstOrDefault();
        }
  
        public void Cadastro(Vaga vaga)
        {
             _conexao.Insert(vaga);
        }
        public void Exclusao( Vaga vaga)
        {
            _conexao.Delete(vaga);
           
        }
        public void Atualizacao(Vaga vaga)
        {
            _conexao.Update(vaga);
        } 
    }   
 }
