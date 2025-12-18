using BookFlixRazor.Models;
using System.Collections.Generic;

namespace BookFlixRazor.Repository.IRepositorio
{
    public interface ILibroRepositorio
    {
        IEnumerable<Libro> GetAll();   
        Libro? GetById(int id);         
        // void Add(Libro libro);          
        // void Update(Libro libro);       
        // void Remove(int id);            
    }
}
