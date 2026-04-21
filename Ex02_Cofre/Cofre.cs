public class Cofre
{
    private string dono;
    private string senha;
    private bool estaAberto;
    private int tentativasErradas;

    public bool EstaAberto => estaAberto;

    public Cofre(string dono, string senha)
    {
        this.dono = dono;
        this.senha = senha;
        estaAberto = false;
        tentativasErradas = 0;
    }

    public string Abrir(string senhaInformada)
    {
        if (tentativasErradas >= 3)
            return "Cofre Bloqueado";

        if (senhaInformada == senha)
        {
            estaAberto = true;
            tentativasErradas = 0;
            return "Cofre aberto";
        }

        tentativasErradas++;
        return "Senha incorreta";
    }

    public void Fechar()
    {
        estaAberto = false;
    }

    public bool AlterarSenha(string senhaAntiga, string novaSenha)
    {
        if (!estaAberto)
            return false;

        if (senhaAntiga == senha)
        {
            senha = novaSenha;
            return true;
        }

        return false;
    }
}
