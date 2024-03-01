# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Arquitetura e Tecnologias

o	Descreva brevemente a arquitetura definida para o projeto e as tecnologias a serem utilizadas. Sugere-se a criação de um diagrama de componentes da solução.

## Project Model Canvas

Colocar a imagem do modelo construído apresentando a proposta de solução.

> **Links Úteis**:
> Disponíveis em material de apoio do projeto

## Requisitos

Os requisitos funcionais e não funcionais principais a serem atendidos são apresentados abaixo. De acordo com a ordem de prioridade eles serão implementados. As restrições também são apresentadas abaixo. 

### Requisitos Funcionais

|ID    | Título |  Descrição do Requisito  | Prioridade |
|------|--------|---------------------------------|----|
|RF-001| Autenticação e Cadastro de Usuário| Implementar um sistema seguro de autenticação, permitindo que os usuários criem contas e acessem o aplicativo com facilidade.  | ALTA | 
|RF-002| Catálogo de Produtos | Apresentar de forma organizada e intuitiva o catálogo de amigurumis. Além dos produtos relacionados, possibilitando a busca, filtragem e visualização detalhada de cada item.    | ALTA |
|RF-003| Carrinho de Compras | Permitir que os usuários adicionem produtos ao carrinho, revisem seus itens escolhidos, ajustem quantidades e prossigam para a finalização da compra. | ALTA |
|RF-004| Finalização de Compra e Pagamento | Oferecer uma experiência simplificada para a conclusão da compra, integrando métodos de pagamento seguros e eficientes. | ALTA |
|RF-005| Rastreamento de Pedidos | Fornecer aos clientes a capacidade de rastrear o status de seus pedidos, junto a API dos correios, mantendo-os informados sobre o processo de entrega. | MÉDIA |
|RF-006| Perfil do Usuário | Permitir que os usuários personalizem seus perfis, incluindo informações de endereço de entrega, histórico de pedidos e preferências de comunicação. | MÉDIA |
|RF-007| Promoções e Descontos | Integrar um sistema de promoções e descontos, incentivando a fidelização dos clientes e impulsionando as vendas. | Baixa |
|RF-008| Integração com Redes Sociais | Facilitar o compartilhamento de produtos nas redes sociais, aumentando a visibilidade da loja e engajamento dos clientes. | BAIXA |
|RF-009| Suporte ao Cliente | Disponibilizar um canal de suporte eficiente, ou seja, e-mail ou telefone, para esclarecimento de dúvidas e resolução de problemas. | ALTA | 
|RF-010| Gestão de Estoque | Manter um controle preciso do estoque para evitar vendas de produtos esgotados e otimizar a logística de reposição. | ALTA | 
|RF-011| Layout Responsivo | Garantir que o aplicativo seja adaptável a diferentes tamanhos de tela, proporcionando uma experiência consistente em dispositivos móveis. | MÉDIA|
|RF-012| Segurança da Informação | Implementar protocolos de segurança robustos para proteger dados sensíveis dos usuários, como informações de pagamento e dados pessoais. | ALTA | 
|RF-013| Histórico de Compras | Permitir que os usuários acessem facilmente seu histórico de compras, incentivando a fidelização e simplificando futuras transações. | MÉDIA |
|RF-014| Contador de tempo de confecção | Permitir que itens com estoque zerado sejam comprados, porém exibir o prazo para confecção e envio de acordo com as regras de negócio. | ALTA |
|RF-015| Personalização dos amigurumis | Permitir que as cores e acessórios sejam personalizados, de acordo com o amigurumi. Pode ser feito por meio de seleção ou de envio de mensagem junto com o pedido. | ALTA | 




### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |

Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)

## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

Sugestão de ferramentas para geração deste artefato: LucidChart e Draw.io.

A referência abaixo irá auxiliá-lo na geração do artefato “Modelo ER”.

> - [Como fazer um diagrama entidade relacionamento | Lucidchart](https://www.lucidchart.com/pages/pt/como-fazer-um-diagrama-entidade-relacionamento)

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
