using System.Text.RegularExpressions;
using Domain.Exceptions;

namespace Domain.ValueObjects;

public record Email
{
    public string Endereco { get; private init; }

    public Email(string endereco)
    {
        if (string.IsNullOrWhiteSpace(endereco) || !Regex.IsMatch(endereco, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            throw new RegraDeNegocioException("O endereço de e-mail informado é inválido.");
        }

        Endereco = endereco.Trim().ToLower();
    }

    public static implicit operator string(Email email) => email.Endereco;
    public static implicit operator Email(string endereco) => new(endereco);
}
