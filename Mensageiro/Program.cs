using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensageiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contato c1 = new Contato("Pablo", "986325871");
            Contato c2 = new Contato("Juliana", "996358741");
            Contato c3 = new Contato("Matheus", "920145687");
            Contato c4 = new Contato("leonardo", "950527891");
            Mensagem m1 = new MsgTexto(c1,"05:41","Mensagem de texto",60);
            Mensagem m2 = new MsgTexto(c2, "03:00", "Mensagem de texto", 120);
            Mensagem m3 = new MsgFoto(c2, "13:9", "Mensagem de texto", 30);
            Mensagem m4 = new MsgAudio(c3, "10:47", "Mensagem de texto", 40);
            Mensagem m5 = new MsgFoto(c3, "09:49", "Mensagem de texto", 50);
            Mensagem m6 = new MsgAudio(c4, "12:50", "Mensagem de texto", 60);
            Mensageiro instantaneo = new Mensageiro();
            instantaneo.addContato(c1);
            instantaneo.addContato(c2);
            instantaneo.addContato(c3);
            instantaneo.addContato(c4);
            instantaneo.listarContatos();
            instantaneo.addMensagem(m1);
            instantaneo.addMensagem(m2);
            instantaneo.addMensagem(m3);
            instantaneo.addMensagem(m4);
            instantaneo.addMensagem(m5);
            instantaneo.addMensagem(m6);
            instantaneo.listarMensagens();

            Console.WriteLine("\n\n"+m1.ToString());
        }
    }
}
