using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrestadordeServico
{
    public PrestadordeServico(string nome, string telefone, string categoriaServico, string email, string prazoExecucaoServico, int valorInicialServico, int valorFinalServico)
    {
        NomeEmpresa = nome;
        Telefone = telefone;
        CategoriaServico = categoriaServico;
        Email = email;
        PrazoExecucaoServico = prazoExecucaoServico;
        ValorInicialServico = valorInicialServico;
        ValorFinalServico = valorFinalServico;
    }

    private string nomeEmpresa;

    private string telefone;

    private string categoriaServico;

    private string email;


    private string prazoExecucaoServico;

    private int valorInicialServico;

    private int valorFinalServico;

    public int ValorFinalServico
    {
        get { return valorFinalServico; }
        set { valorFinalServico = value; }
    }

    public int ValorInicialServico
    {
        get { return valorInicialServico; }
        set { valorInicialServico = value; }
    }

    public string PrazoExecucaoServico
    {
        get { return prazoExecucaoServico; }
        set { prazoExecucaoServico = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string CategoriaServico
    {
        get { return categoriaServico; }
        set { categoriaServico = value; }
    }

    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }

    public string NomeEmpresa
    {
        get { return nomeEmpresa; }
        set { nomeEmpresa = value; }
    }

}
