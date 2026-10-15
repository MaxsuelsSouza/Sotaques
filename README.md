# 🗺️ Sotaques — A Guerra das Girias

Um projeto de alta resiliência e tolerância a falhas disfarçado de jogo de tabuleiro geopolítico em tempo real. O objetivo é testar infraestrutura sob estresse (alta escrita, consistência eventual, mapas dinâmicos e disparo de e-mails em lote) enquanto usuários disputam território nacional usando gírias locais.

---

## 🚀 O Conceito

Cada cidade do Brasil pode registrar suas gírias mais comuns. Elas disputam território de forma orgânica ou agressiva. Quando uma gíria domina **98% de um estado**, ela é coroada como **Gíria Regional** e passa a disputar a soberania nacional com outros estados.

---

## 🕹️ Mecânicas do Jogo e Estados da Gíria

### 1. Criação e Engajamento Inicial

Ao criar uma gíria, o usuário obrigatoriamente vincula seu **e-mail** e **região de nascimento**. A gíria não possui um "dono"; ela pertence ao território. O criador escolhe uma das duas estratégias de crescimento:

- **Popular:** Cresce abertamente. O usuário divulga o link para amigos ou viajantes que navegam pelo mapa e dão um "Up".
- **Infiltrar (Secreta):** Cresce de forma anônima e baseada na localização estrita do usuário. Não fica visível para o país inteiro, apenas para as regiões vizinhas onde ela está se expandindo. Ao atingir **40% de território local**, a gíria perde o segredo e entra em modo de disputa aberta.

### 2. Disputas Territoriais e Sistema de Defesa

Quando duas gírias de cidades vizinhas se encontram na fronteira (Ex: _“Mano”_ em Caruaru e _“Boy”_ em Gravatá se encontrando em Bezerros):

1.  **Gatilho de Ataque:** A disputa começa.
2.  **Notificação Massiva:** Todos os usuários cadastrados para defender a gíria naquela região recebem um e-mail de alerta.
3.  **A Batalha:** Apenas pessoas localizadas geograficamente na região afetada podem votar na disputa (validação por geolocalização). Os usuários podem defender sua gíria ou trair o time trocando de lado.
4.  **Resolução:** O time vencedor "come" a porcentagem do perdedor. Os derrotados passam a adotar a gíria vencedora automaticamente.

> 💡 **Nota de Recriação:** A gíria perdedora pode ser recriada na cidade natal, mas não poderá mais usar o modo _Infiltrar_. A gíria vencedora fica ciente da recriação e monitora seu crescimento; ao atingir **30%**, o vencedor pode atacar novamente.

### 3. Modos Especiais de Jogo

| Modo/Estado         | Condição de Ativação                                                                     | Mecânica e Regras                                                                                                                                                                                                                                                                                                                                                                                                           | Consequência de Vitória/Derrota                                                                                                                                                                                                                     |
| :------------------ | :--------------------------------------------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Em Recuperação**  | Vencer uma disputa normal com extrema dificuldade.                                       | A gíria perde a habilidade de visualizar as gírias que já conquistou uma vez. Para sair deste estado, deve atacar qualquer gíria de **>40%** do estado (independente da distância) e **vencer 3 disputas seguidas**.                                                                                                                                                                                                        | **Vitória:** Recupera a visão das conquistas e remove a flag de recuperação.<br>**Derrota:** Perde 10% de território a cada derrota. Se perder as 3, a gíria **some do mapa**.                                                                      |
| **Golpe de Estado** | Usuário cria uma gíria usando sua cidade natal dentro de uma cidade de **outro estado**. | Cresce anonimamente até **30%** (visível apenas para naturais daquela gíria). Ao passar de 30%, ganha a flag pública de _Golpe de Estado_ e vira alvo de todas as gírias locais. Se o defensor local tiver **>60%**, o golpista pode pedir ajuda ao estado de origem: a disputa ganha **2 dias de espera** e e-mails são metralhados para os conterrâneos balancearem a porcentagem inicial em 0% vs 0%. A votação dura 4h. | **Empate:** Ambas as gírias entram em modo de _Recuperação_.<br>**Derrota do Golpe:** Segue as regras padrão de perda territorial.                                                                                                                  |
| **Revolta Armada**  | Ativado pela gíria perdedora dentro de **1 semana** após a derrota.                      | Os perdedores disparam um e-mail de convocação geral e possuem uma janela de **6 horas** para mobilizar a comunidade e juntar **50% de votos**.                                                                                                                                                                                                                                                                             | **Vitória:** Ficam imunes a ataques da gíria que os venceu por 1 semana, ganham permissão para atacar qualquer gíria **>40%** do estado e roubam 10% da perdedora por vitória.<br>**Derrota:** Bloqueados de tentar uma nova revolta por **1 mês**. |

---

## 📏 Regras Globais e Restrições

### Níveis de Usuário e Alianças

- **Neutros (Sem partido):** Podem dar "Up" em apenas uma gíria por estado para ajudar na porcentagem orgânica (Intenção), mas **não participam** de janelas de disputa ativa ou defesa.
- **Alistados (Com partido):** Podem apoiar gírias de outros estados por afinidade, computando pontos de intenção (mais fracos que o voto regional). Podem mudar de time quando quiserem, pois a gíria pertence à região, não ao usuário.

### Soberania das Gírias Regionais (98% do Estado)

- Uma vez atingido **98% do estado**, ela vira **Regional** e fica imune a ataques de gírias menores de dentro do seu próprio estado (a menos que outra gíria interna também chegue a 98%).
- Ao virar Regional, ela "zera" sua porcentagem interna de ataque e adota uma postura **puramente defensiva** contra novos ataques de 98% ou Golpes de Estado externos que atinjam **80%**.
- **Ataque Externo (Invasão):** Uma gíria Regional pode dar golpes em outros estados. Se vencer, ela ganha uma pequena porcentagem no estado vizinho e pode expandir agressivamente (atacando sem ser atacada) ou organicamente (migração de usuários).
- **Absorção de Território:** Se a gíria invasora chegar a 98% no estado vizinho, ela enfrenta a Gíria Regional daquele estado. Se vencer, ela **mescla os territórios**, unificando os estados sob a mesma gíria no mapa.

### Tratados de Paz e Conquista Suprema

- **Acordo de Não-Agressão:** Um estado que perdeu território para um invasor pode tentar até **2 Golpes de Estado** para retomar a terra. Se perder ambos, na terceira tentativa ele pode forçar um acordo de paz com o dominante, reavendo parte do território e selando um pacto de não-agressão.
- **Contador de Hegemonia (Rank de Conquista):** Quando uma Gíria Regional mescla outros estados, ela ganha um contador permanente de conquistas (de 1 a 26). **Esse número nunca diminui**, mesmo que o território seja perdido depois, pois registra o ápice histórico e a dificuldade da jornada de engenharia do servidor (Vencer regional -> Subir até 98% -> Vencer novamente).

---

## 🛠️ O Desafio Técnico (Para o Portfólio)

Este projeto foi desenhado especificamente para demonstrar proficiência em arquitetura de sistemas distribuídos e de alta carga:

- **Ingestão Massiva (High-Throughput Writes):** O fluxo de cliques ("Ups") e batalhas em tempo real de 4h exige uma camada de cache robusta (Redis) e mensageria (RabbitMQ/Kafka) para evitar concorrência e _race conditions_ no banco de dados.
- **Geofencing e Computação Espacial:** Uso de queries geográficas (PostGIS) para validar se o usuário está de fato na fronteira ou região permitida para defender ou atacar.
- **Broadcast em Tempo Real:** Atualização de milhares de mapas simultâneos via WebSockets/SSE no momento exato em que as porcentagens mudam.
- **Notificações Resilientes:** Sistema de fila isolado para envio de e-mails em lote (Mailgun/SES) para milhares de usuários simultâneos em momentos de "Ataque" e "Revolta Armada", sem travar a thread principal da aplicação.
