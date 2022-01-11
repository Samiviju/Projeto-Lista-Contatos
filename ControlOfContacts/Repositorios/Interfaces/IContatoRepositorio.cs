using ControlOfContacts.Models;
using System.Collections.Generic;

namespace ControlOfContacts.Repositorios.Interfaces
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();

        ContatoModel Adicionar(ContatoModel contato);
    }
}