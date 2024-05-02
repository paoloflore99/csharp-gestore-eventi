﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        public string Titolo;

        private List<Evento> eventi;

        public ProgrammaEventi(string titolo)
        {
            this.Titolo = titolo;
            eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento eventiaggiunti)
        {
           eventi.Add(eventiaggiunti);
        }



        public List<Evento>EventiInData(DateTime data)
        {
            List<Evento> eventiInData = new List<Evento>();

            foreach (var evento in eventi)
            {
                if (evento.Data.Date == data.Date)
                {
                    eventiInData.Add(evento);
                }
            }

            return eventiInData;
        }



    }
}
