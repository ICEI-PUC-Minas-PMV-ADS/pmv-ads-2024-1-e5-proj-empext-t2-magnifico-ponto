# Especificações do Projeto

O projeto tem como objetivo desenvolver uma aplicação web personalizada para a artesã Katia, visando otimizar a gestão de vendas e controle de peças em seu negócio de artesanato. A solução fornecerá uma interface intuitiva e funcionalidades específicas para atender às necessidades exclusivas da Katia. 

## Arquitetura e Tecnologias

Com o avanço do comércio eletrônico e a crescente digitalização dos negócios, é fundamental para empresas de todos os setores expandirem sua presença para o meio digital. Nesse contexto, a loja de artesanato "Magnífico Ponto" reconheceu a necessidade de ingressar no mundo online para alcançar um público mais amplo e oferecer uma experiência de compra conveniente e acessível aos seus clientes. Para atender a esse objetivo, a equipe de desenvolvimento optou por adotar tecnologias sólidas e confiáveis no mercado, visando criar um site de vendas robusto e eficiente. Logo abaixo, a fim de justificar a escolha das tecnologias selecionadas para o desenvolvimento do site "Magnífico Ponto", é detalhado tanto as ferramentas escolhidas para o backend quanto para o frontend, bem como as integrações com APIs externas. 

Tecnologias para o Backend: 

<strong>ASP.NET MVC:</strong> A equipe optou pelo ASP.NET MVC devido à sua robustez e escalabilidade. Esta escolha se deve à arquitetura de software que separa claramente a lógica de negócios da interface do usuário, facilitando o desenvolvimento e a manutenção do código. Além disso, a ampla comunidade de desenvolvedores e o suporte da Microsoft garantem atualizações regulares e segurança.  

<strong>Entity Framework:</strong> O Entity Framework foi escolhido como ORM (Object-Relational Mapping) para facilitar a manipulação dos dados do banco de dados. Com o EF, é possível mapear objetos do modelo de domínio diretamente para tabelas de banco de dados, simplificando operações de CRUD (Create, Read, Update, Delete) e garantindo um código mais limpo e legível.  

<strong>SQL Server:</strong> Para o banco de dados, foi selecionado o SQL Server devido à sua confiabilidade, desempenho e recursos avançados de segurança. Sua integração com o ambiente .NET é excelente, simplificando o desenvolvimento e garantindo a integridade dos dados.  

<strong>ASP.NET Identity:</strong> O ASP.NET Identity foi adotado para gerenciamento de identidade, autenticação e autorização de usuários. Ele oferece recursos robustos para lidar com o login, registro, recuperação de senha e gerenciamento de perfis de usuários de forma segura, além de ser altamente personalizável. 

<strong>BCrypt:</strong> A escolha do BCrypt para criptografia de senhas foi motivada pela sua reputação de ser uma das técnicas mais seguras disponíveis atualmente. BCrypt é um algoritmo de hash de senha que adiciona um nível adicional de segurança, tornando as senhas dos usuários virtualmente impossíveis de serem decifradas por ataques de força bruta ou de dicionário. Isso é crucial para proteger as informações sensíveis dos usuários, como credenciais de login, garantindo que elas permaneçam seguras, mesmo em caso de violação de dados. 

## Project Model Canvas


![Project Model Canvas](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/8653c2af71f9dfda1d66d0071e0945b7844eb857/documentos/img/ProjectModelCanvasA1.png)



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
