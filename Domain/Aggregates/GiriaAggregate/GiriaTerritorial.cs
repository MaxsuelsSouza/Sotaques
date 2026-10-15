using Domain.ValueObjects;

namespace Domain.Aggregates.GiriaAggregate;

public class GiriaTerritorial
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; } = string.Empty;

    // Substituindo strings soltas por Value Objects estruturados:
    public LocalizacaoGeografica Localizacao { get; private set; }

    public decimal PorcentagemTerritorio { get; private set; }
    public StatusGiria Status { get; private set; }
    public DateTime? DataUltimaDerrota { get; private set; }

    // ... restante da classe e construtores


    public void DeclararRevolta()
    {
        // 1. Validar se o status atual permite revolta (se não, joga Exception)

        // 2. Validar se existe uma DataUltimaDerrota e se ela aconteceu há menos de 1 semana (se não, joga Exception)

        // 3. Se passou nas validações, altera o estado da própria gíria:
        // This.Status = StatusGiria.SobRevolta;

        // 4. (Opcional no DDD) Registrar o evento de domínio 'RevoltaArmadaDeclarada' para a infraestrutura enviar os e-mails depois.
    }

}
