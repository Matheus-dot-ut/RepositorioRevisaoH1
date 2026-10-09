public interface IRegistroRepository
{
    public void Adicionar(Cadastro cadastra);
    public  List<Cadastro> BuscarTodos();
    public  Cadastro ConsultarPorJustificativa(string descricaoJustificativa);
    public  bool ExisteCpf(string cpf);

    public  bool ExisteEleitor(int numeroEleitor);
}