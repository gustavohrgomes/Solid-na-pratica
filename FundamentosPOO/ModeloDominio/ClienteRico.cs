using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDominio
{
    class ClienteRico
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public ClienteRico(int id, string nome, string endereco)
        {
            // Validação mais robusta, não é muito recomendado

            //if (id <= 0)
            //    throw new InvalidOperationException("Id não pode ser menor ou igual a 0");

            //if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
            //    throw new InvalidOperationException();

            // Validação abaixo também não algo a ser seguido, o ideal seria implementa o
            // Notification Pattern, criado por Martin Fowler

            DomainExceptionValidation.When(id <= 0, "Id não pode ser menor ou igual a 0.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "O campo nome não pode estar vazio.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(endereco), "O campo endereco não pode estar vazio");

            Id = id;
            Nome = nome;
            Endereco = endereco;
        }
    }
}
