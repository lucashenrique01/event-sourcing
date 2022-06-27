using System;
using EventDaoNamespace;
using ConsumerApp.Models;
using ConsumerApp.Converters;


namespace ConsumerApp.Services{

    public class EventTransactionService{

        EventTransactionDAO eventDAO = new EventTransactionDAO();
        private const int MINUTESADD = 5;

        public void save(Event eventt){
            EventTransaction eventTransaction = new EventTransaction();

            eventTransaction.token = tokenGenerate();
            eventTransaction.idClient = eventt.data.cliente.idCliente;
            eventTransaction.idTransacao = eventt.data.idTransacao;
            eventTransaction.canalSolicitante = eventt.data.canalSolicitante;
            eventTransaction.duracaoToken =  DateTime.Now.AddMinutes(MINUTESADD); 
            eventDAO.insertEventTransaction(eventTransaction);
        }


        public EventTransaction returnByClientToken(string idCliente, string token){
        return null;}
        public void createTable(){
            eventDAO.createTableEventTransaction();
        }
        private string tokenGenerate()
        {
            Random tokenRandom = new Random();
            string token = tokenRandom.Next(0, 1000000).ToString("D6");
            return token;
        }
    }
}