using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    // classe para fazer a conexao com o banco de dados
    public class AgendaContext : DbContext
    {
        // receber a configuacao
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        // criar uma tabela
        public DbSet<Contato> Contatos { get; set; }


    }
}