using System.ComponentModel;

class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"{Ordem}. - {Titulo} ({Duracao} min) {string.Join(",", convidados)}"; //arrow function (lambda)
    /*
      public string Resumo{
      get{
        return $"{Ordem}, {Titulo} ({Duracao})";
      }}
     */

    public void AdicionarConvidados(string convidado) //metodo recebe argumento convidado e add na lista convidados 
    {
        convidados.Add(convidado);
    }

}