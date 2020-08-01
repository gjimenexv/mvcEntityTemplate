using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PeliculaRepository
    {
        public List<Pelicula> GetPeliculas()
        {
            var list = new List<Pelicula>();
            Pelicula pelicula = new Pelicula { Titulo = "Duro de Matar", Cartelera = true, Genero = "Accion" };
            list.Add(pelicula);
            pelicula = new Pelicula { Titulo = "Transformers ", Cartelera = false, Genero = "Accion" };
            list.Add(pelicula);
            pelicula = new Pelicula { Titulo = "Dr Strange", Cartelera = true, Genero = "Accion" };
            list.Add(pelicula);
            return list;
        }

        public List<SelectListItem> GetData()
        {
            var list = new List<SelectListItem>
            {
                new SelectListItem(){ Text="House", Value = "1" },
                new SelectListItem(){ Text="Roots", Value = "2" },
                new SelectListItem(){ Text="Trova", Value = "3" },
                new SelectListItem(){ Text="Punk", Value = "4" }
            };

            return list;
        }
    }
}