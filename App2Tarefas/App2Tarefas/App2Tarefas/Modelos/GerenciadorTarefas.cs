using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace App2Tarefas.Modelos
{
    class GerenciadorTarefas
    {
        private List<Tarefas> Lista { get; set; }
       

        public void Salvar(Tarefas tarefa)
        {
            Lista = Listagem();
            Lista.Add(tarefa);

            SalvarNoProperties(Lista);
        }

        public void Deletar(int index)
        {
            Lista = Listagem();
            Lista.RemoveAt(index);

            SalvarNoProperties(Lista);
        }

        public void Finalizar (int index, Tarefas tarefa)
        {
            Lista = Listagem();
            Lista.RemoveAt(index);

            tarefa.DataFinalizacao = DateTime.Now;

            Lista.Add(tarefa);
            SalvarNoProperties(Lista);
        }
        public List<Tarefas> Listagem()
        {
          return  ListagemNoProperties();
        }
        
 
        private void SalvarNoProperties (List<Tarefas> Lista)
        {
            
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                App.Current.Properties.Remove("Tarefas");
            }

            string JsonVal = JsonConvert.SerializeObject(Lista);

            App.Current.Properties.Add("Tarefas", JsonVal);
        }
         
        private List<Tarefas> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                string JsonVal = (string)App.Current.Properties["Tarefas"];

                List<Tarefas> Lista = JsonConvert.DeserializeObject<List<Tarefas>>(JsonVal);
                return Lista;
                //return (List<Tarefas>)App.Current.Properties["Tarefas"];

            }

            return new List<Tarefas>();
        }
    }
}
