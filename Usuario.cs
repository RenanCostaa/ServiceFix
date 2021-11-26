using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Usuario
{
    //Construtor da Classe Usuário
    public Usuario(){
      
    }
    public Usuario(string nome, string telefone, string dataNascimento, string endereco)
    {
        Nome = nome;
        Telefone = telefone;
        DataNascimento = dataNascimento;
        Endereco = endereco;
    }

    private string nome;

    private string telefone;

    private string dataNascimento;

    private string endereco;

    public string Endereco 
    { 
        get { return endereco; } 
        set { endereco = value; } 
    }

    public string DataNascimento
    {
        get { return dataNascimento; }
        set { dataNascimento = value; }
    }

    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public Usuario EditaUsuario(string nome, string telefone, string dataNascimento, string endereco)
    {
        Usuario newUser = new Usuario(nome, telefone, dataNascimento, endereco);

        return newUser;
    }

}
