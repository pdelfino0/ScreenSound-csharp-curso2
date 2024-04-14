class Episodio
{
    private List<string> convidados = new List<string>();

    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public string Resumo => $"Episódio {Ordem}: {Titulo} ({Duracao} Minutos) - {string.Join(",", convidados)}";
    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}