# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Arquitetura e Tecnologias

o	Descreva brevemente a arquitetura definida para o projeto e as tecnologias a serem utilizadas. Sugere-se a criação de um diagrama de componentes da solução.

## Project Model Canvas


![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/ce31f1ba01c99fac9c98351d5d5ee4b2f194db4e/documentos/img/ProjectModelCanvasA1.pdf)



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

|ID     | Título |  Descrição do Requisito  |Prioridade |
|-------|--------|-----------------|----|
|RNF-001|Desempenho e Velocidade | O aplicativo deve garantir uma resposta rápida às interações do usuário, minimizando o tempo de carregamento de páginas e imagens.  | ALTA | 
|RNF-002|Segurança |Implementação de protocolos de segurança robustos para proteger dados sensíveis dos usuários, como informações de pagamento e dados pessoais. |  ALTA | 
|RNF-003|Compatibilidade e Responsividade |Garantir que o aplicativo seja compatível com diferentes dispositivos e sistemas operacionais, além de possuir um layout responsivo para oferecer uma experiência consistente. | MÉDIA |
|RNF-004|Escalabilidade| A arquitetura do aplicativo deve ser projetada para lidar com o crescimento de usuários e transações, assegurando que o desempenho seja mantido mesmo diante de um aumento significativo de demanda. | ALTA |
|RNF-005| Navegação Intuitiva | Proporcionar uma experiência de usuário intuitiva e fácil de navegar, com uma estrutura de menu lógica e botões claros, para facilitar a busca e a compra de produtos. | MÉDIO |
|RNF-006|Disponibilidade |Assegurar alta disponibilidade do aplicativo, minimizando períodos de inatividade para garantir que os clientes possam acessar a loja a qualquer momento. | MÉDIO |
|RNF-007|Backup e Recuperação de Dados |Implementar procedimentos de backup regulares e mecanismos eficazes de recuperação de dados para evitar perdas irreparáveis de informações importantes. | ALTA |
|RNF-008|Gerenciamento de Conteúdo |Facilitar a atualização de conteúdo por parte da equipe da Magnífico Ponto, permitindo a inclusão fácil de novos produtos, promoções e informações relevantes sem a necessidade de intervenção técnica constante. | ALTA |
|RNF-009|Experiência do Usuário (UX) |Garantir uma interface de usuário intuitiva, agradável e de fácil compreensão, promovendo uma experiência positiva e incentivando a interação contínua. |Médio |
|RNF-010|Monitoramento e Análise |Integrar ferramentas de monitoramento para coletar dados sobre o comportamento dos usuários, possibilitando análises que orientem melhorias na experiência do cliente e na eficácia das estratégias de venda. |Média |
|RNF-011|Gerenciamento de Sessão |Manter a estabilidade das sessões do usuário, permitindo que os clientes permaneçam logados durante suas interações no aplicativo sem a necessidade de múltiplos logins. |Alta |
|RNF-012|Atualizações Automáticas |Implementar um sistema que permita atualizações automáticas do aplicativo para garantir que os usuários tenham acesso às últimas funcionalidades e correções de segurança. |Média |




## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01|O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 23/06/2024.  |
|02| A plataforma deve se restringir às tecnologias básicas utilizando ferramentas de desenvolvimento pré estabelecidas. |
|03| A equipe não pode subcontratar o desenvolvimento do trabalho. |
|04| A plataforma se compromete em não compartilhar históricos de pesquisa e dados sensíveis dos usuários. |

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
