﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public class Agendamento
    {
        #region PROPRIEDADES
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        public string Modelo { get; set; }
        public decimal Preco { get; set; }
        public string DataFormatada
        {
            get
            {
                return DataAgendamento.Add(HoraAgendamento).ToString("dd/MM/yyyy HH:mm");
            }
        }

        DateTime dataAgendamento = DateTime.Today;
        public DateTime DataAgendamento
        {
            get { return dataAgendamento; }
            set { dataAgendamento = value; }
        }

        public TimeSpan HoraAgendamento { get; set; }

        public bool Confirmado { get; set; }
        #endregion  

        #region CONSTRUTORES
        public Agendamento(string nome, string fone, string email, string modelo, decimal preco, DateTime dataAgendamento, TimeSpan horaAgendamento)
            : this(nome, fone, email, modelo, preco)
        {
            this.DataAgendamento = dataAgendamento;
            this.HoraAgendamento = horaAgendamento;
        }

        public Agendamento(string nome, string fone, string email, string modelo, decimal preco)
        {
            this.Nome = nome;
            this.Fone = fone;
            this.Email = email;
            this.Modelo = modelo;
            this.Preco = preco;
        }

        public Agendamento()
        {

        }
        #endregion
    }
}
