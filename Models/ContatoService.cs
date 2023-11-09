using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections;


namespace Atv3._1.Models
{
    public class ContatoService
    {
        public void Inserir(Contato c)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Add(c);
                bc.SaveChanges();
            }
        }
      
        public List<Contato> Listar()
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Contatos.ToList();
            }
        }
        
        public void Editar(Contato c)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                Contato contato = bc.Contatos.Find(c.id);
                contato.nome = c.nome;
                contato.phone = c.phone;
                contato.email = c.email;
                contato.servico = c.servico;
                contato.mensagem = c.mensagem;
                contato.Respondido = c.Respondido;

                bc.SaveChanges();
            }
        }
        
        public Contato ObterPorId(int id)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Contatos.Find(id);
            }
        }


        public void excluirContato(int id)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Contatos.Remove(bc.Contatos.Find(id));
                bc.SaveChanges();
            }
        }


    }
}