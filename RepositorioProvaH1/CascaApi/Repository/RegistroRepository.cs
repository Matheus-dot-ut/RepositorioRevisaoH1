public class RegistroRepository : IRegistroRepository
{
    private static List<Cadastro> cadastro = new List<Cadastro>();

    public void Adicionar(Cadastro cadastra)
    {
        cadastro.Add(cadastra);
    }

    public List<Cadastro> BuscarTodos()
    {
        return cadastro;
    }


    public Cadastro ConsultarPorJustificativa(string descricaoJustificativa)
    {
        return cadastro.FirstOrDefault(e => e.DescricaoJustificativa == descricaoJustificativa);
    }

    public bool ExisteCpf(string cpf)
    {
        return cadastro.Any(e => e.Cpf == cpf);
    }

    public bool ExisteEleitor(int numeroEleitor)
    {
        return cadastro.Any(e => e.NumeroTurno == numeroEleitor);
    }


}