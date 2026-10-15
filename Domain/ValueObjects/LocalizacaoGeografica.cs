using Domain.Exceptions;

namespace Domain.ValueObjects;

public record LocalizacaoGeografica
{
    public string Cidade { get; private init; }
    public string Estado { get; private init; }

    public LocalizacaoGeografica(string cidade, string estado)
    {
        if (string.IsNullOrWhiteSpace(cidade))
            throw new RegraDeNegocioException("A cidade não pode ser vazia.");

        if (string.IsNullOrWhiteSpace(estado) || estado.Trim().Length != 2)
            throw new RegraDeNegocioException("O estado deve ser informado com a sigla de 2 letras (Ex: PE, SP).");

        Cidade = cidade.Trim();
        Estado = estado.Trim().ToUpper();
    }
}
