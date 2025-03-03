﻿using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repos.Interfecs
{
    public interface IUsuarioRepositorio
    {
        Task<List<Usuario>> BuscarTodosUsuarios();

        Task<Usuario> BuscarPorId(int id);

        Task<Usuario> Adicionar(Usuario usuario);

        Task<Usuario> Atualizar(Usuario usuario, int id);

        Task<bool> Apagar(int id);

    }
}
