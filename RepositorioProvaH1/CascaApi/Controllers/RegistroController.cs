using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/RegistroAusenciaEleicao/[controller]")]

public class CadastraController : ControllerBase
{
    private readonly IRegistroRepository _repository;

    public CadastraController(IRegistroRepository repository)
    {
        _repository = repository;
    }

    #region Metodo Post
    [HttpPost]
    public IActionResult Adiciona([FromBody] Cadastro novoCadastro)
    {
        if (_repository.ExisteCpf(novoCadastro.Cpf))
        {
            return BadRequest($"Este CPF já esta cadastrado, {novoCadastro.Cpf}. Digite outro para funcionar o cadastro");
        }

        _repository.Adicionar(novoCadastro);
        return Ok(novoCadastro);
    }

    [Route("{Cpf}/{NumeroTurno}/{DescricaoJustificativa}")]
    public IActionResult Registra([FromBody] Cadastro novoCadastro)
    {
        if (_repository.ExisteEleitor(novoCadastro.NumeroTurno))
        {
            return BadRequest($"Este numero de eleitor já esta cadastrado, {novoCadastro.NumeroTurno}. Digite outro para funcionar o cadastro");
        }

        _repository.Adicionar(novoCadastro);
        return Ok(novoCadastro);
    }
    #endregion

    #region Metodo Get
    [HttpGet]
    public IActionResult BuscarTodos()
    {
        return Ok(_repository.BuscarTodos());
    }


    [HttpGet]
    [Route("ConsultarJustificativa")]
    public IActionResult ConsultaPorJustificativa(string descricaoJustificativa)
    {
        var exemplo = _repository.ConsultarPorJustificativa(descricaoJustificativa);

        if (exemplo == null)
        {
            return NotFound();
        }

        return Ok(exemplo);
    }
    #endregion

}