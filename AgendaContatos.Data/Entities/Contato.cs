using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContatos.Data.Entities
{
    public class Contato
    {
        private Guid _idContato;
        private string? _nome;
        private string? _telefone;
        private string? _email;
        private DateTime? _dataNascimento;
        private int? _tipo;
        private Guid? _idUsuario;

        public Guid IdContato { get => _idContato; set => _idContato = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public string? Telefone { get => _telefone; set => _telefone = value; }
        public string? Email { get => _email; set => _email = value; }
        public DateTime? DataNascimento { get => _dataNascimento; set => _dataNascimento = value; }
        public int? Tipo { get => _tipo; set => _tipo = value; }
        public Guid? IdUsuario { get => _idUsuario; set => _idUsuario = value; }
    }
}
