using System;

namespace ArgumentosNomeados
{
    class Program
    {
        static void Enviar(string destino, string titulo, string assunto)
        {
            Console.WriteLine($"{destino} - {titulo} - {assunto}");
        }
        static void Main(string[] args)
        {
            Enviar(destino: "email_teste@gmail.com", assunto: "teste", titulo: "argumentos");
            Enviar(destino: "email_teste@gmail.com", titulo: "argumentos", assunto: "teste");
            Enviar(titulo: "argumentos", assunto: "teste", destino: "email_teste@gmail.com");
            Enviar(assunto: "teste", titulo: "argumentos", destino: "email_teste@gmail.com");
        }
    }
}
