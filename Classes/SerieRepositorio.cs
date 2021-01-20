using System;
using System.Collections.Generic;
using cadastro_series.Interfaces;

namespace cadastro_series
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();
        public void Atualiza(int id, Series entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Series entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int ProximoID()
        {
            return listaSerie.Count;
        }

        public Series RetornaPorID(int id)
        {
            return listaSerie[id];
        }
    }
}