# Especificações do Projeto

O projeto tem como objetivo desenvolver uma aplicação web personalizada para a artesã Katia, visando otimizar a gestão de vendas e controle de peças em seu negócio de artesanato. A solução fornecerá uma interface intuitiva e funcionalidades específicas para atender às necessidades exclusivas da Katia. 

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Cliente  | Acessar produtos do site de forma simples e rápida  | Facilitar a minha compra  |
|Cliente  |Calcular o frete direto do site |Saber qual o valor do envio do produto até minha casa |
|Cliente   | Ter acesso a uma fila de espera dos pedidos em produção|Saber o Tempo de fabricação do meu pedido  |
|Cliente   |Saber quais cores estão disponíveis   |Configurar meu pedido de acordo com minha necessidade  |
|Cliente  | Ter acesso a um link ou botão que possibilite contato pelo WhatsApp |  Conversar diretamente com o Vendedor  |
|Vendedor  |Painel com todas os pedidos do site em ordem de chegada  |Produzir os pedidos de acordo com que são encomendados  |
|Vendedor  |Cadastrar e gerenciar meus produtos de acordo com estoque e disponibilidade   |Evitar que um cliente faça um pedido que não possa ser atendido |
|Vendedor  | Cadastrar minhas vendas feitas pelo WhatsApp |Manter atualizado a fila de espera dos pedidos |


## Arquitetura e Tecnologias

Com o avanço do comércio eletrônico e a crescente digitalização dos negócios, é fundamental para empresas de todos os setores expandirem sua presença para o meio digital. Nesse contexto, a loja de artesanato "Magnífico Ponto" reconheceu a necessidade de ingressar no mundo online para alcançar um público mais amplo e oferecer uma experiência de compra conveniente e acessível aos seus clientes. Para atender a esse objetivo, a equipe de desenvolvimento optou por adotar tecnologias sólidas e confiáveis no mercado, visando criar um site de vendas robusto e eficiente. Logo abaixo, a fim de justificar a escolha das tecnologias selecionadas para o desenvolvimento do site "Magnífico Ponto", é detalhado tanto as ferramentas escolhidas para o backend quanto para o frontend, bem como as integrações com APIs externas. 

### Tecnologias para o Backend:

<strong>ASP.NET MVC:</strong> A equipe optou pelo ASP.NET MVC devido à sua robustez e escalabilidade. Esta escolha se deve à arquitetura de software que separa claramente a lógica de negócios da interface do usuário, facilitando o desenvolvimento e a manutenção do código. Além disso, a ampla comunidade de desenvolvedores e o suporte da Microsoft garantem atualizações regulares e segurança.  

<strong>Entity Framework:</strong> O Entity Framework foi escolhido como ORM (Object-Relational Mapping) para facilitar a manipulação dos dados do banco de dados. Com o EF, é possível mapear objetos do modelo de domínio diretamente para tabelas de banco de dados, simplificando operações de CRUD (Create, Read, Update, Delete) e garantindo um código mais limpo e legível.  

<strong>SQL Server:</strong> Para o banco de dados, foi selecionado o SQL Server devido à sua confiabilidade, desempenho e recursos avançados de segurança. Sua integração com o ambiente .NET é excelente, simplificando o desenvolvimento e garantindo a integridade dos dados.  

<strong>ASP.NET Identity:</strong> O ASP.NET Identity foi adotado para gerenciamento de identidade, autenticação e autorização de usuários. Ele oferece recursos robustos para lidar com o login, registro, recuperação de senha e gerenciamento de perfis de usuários de forma segura, além de ser altamente personalizável. 

<strong>BCrypt:</strong> A escolha do BCrypt para criptografia de senhas foi motivada pela sua reputação de ser uma das técnicas mais seguras disponíveis atualmente. BCrypt é um algoritmo de hash de senha que adiciona um nível adicional de segurança, tornando as senhas dos usuários virtualmente impossíveis de serem decifradas por ataques de força bruta ou de dicionário. Isso é crucial para proteger as informações sensíveis dos usuários, como credenciais de login, garantindo que elas permaneçam seguras, mesmo em caso de violação de dados.


### Tecnologias para o Frontend:

<strong>HTML/CSS/Javascript:</strong> 

Essas tecnologias, conhecidas como o trio fundamental do desenvolvimento web, desempenham papéis cruciais na construção de um site de vendas eficaz.  

O HTML (HyperText Markup Language) oferece a estrutura básica e a semântica necessária para organizar e apresentar o conteúdo da página. Com sua ampla compatibilidade com navegadores, o HTML é a base sobre a qual toda a experiência do usuário é construída.  

O CSS (Cascading Style Sheets) é responsável por estilizar o conteúdo HTML, tornando-o visualmente atraente e consistente em diferentes dispositivos e tamanhos de tela. Através do CSS, é possível controlar a aparência de elementos individuais, criar layouts responsivos e garantir uma experiência visualmente agradável para os usuários.  

O Javascript, por sua vez, é a linguagem de programação que adiciona interatividade e dinamismo ao site. Com o Javascript, é possível criar animações, validar formulários, carregar conteúdo dinamicamente e interagir com o usuário em tempo real. Sua versatilidade e poder é essencial para proporcionar uma experiência de usuário rica e envolvente em um site de vendas.  

<strong>BOOTSTRAP:</strong> 

O Bootstrap foi escolhido por ser um framework web frontend amplamente adotado devido à sua facilidade de uso e à vasta gama de componentes pré-projetados que oferece. Alguns dos pontos fortes na utilização Bootstrap, é a economia de tempo e esforço na criação de layouts responsivos e visualmente atraentes. 

Uma das principais vantagens do Bootstrap é sua grade responsiva, que permite que o layout se adapte automaticamente a diferentes tamanhos de tela, desde dispositivos móveis até desktops, facilitando o acesso ao site da loja Magnifico Ponto em diferentes tipos de dispositivos. Além disso, o Bootstrap oferece uma variedade de componentes, como botões, formulários, barras de navegação e modais, que podem ser facilmente personalizados e integrados ao design do site de vendas. 

Outro ponto forte do Bootstrap é sua extensa documentação e comunidade de desenvolvedores ativa, que fornecem suporte e recursos adicionais para facilitar o desenvolvimento. Isso faz do Bootstrap uma escolha sólida para criar uma interface do usuário consistente e profissional, garantindo uma experiência positiva para os usuários do site de vendas Magnífico Ponto. 

### Uso de ferramentas externas 

 

<strong>API dos Correios:</strong>

A integração da API dos Correios desempenha um papel fundamental no aprimoramento da experiência do usuário no site de vendas Magnífico Ponto. Ao calcular os custos de frete com base no endereço do cliente, esta API proporciona uma estimativa precisa dos custos de envio, permitindo que os clientes tenham uma visão transparente dos custos totais antes de finalizar a compra.  

Além de fornecer uma estimativa de frete precisa, a integração com a API dos Correios também oferece benefícios adicionais, como a rastreabilidade dos pedidos. Os clientes podem acompanhar o status de entrega de seus produtos, aumentando a confiança e a satisfação do cliente. Isso contribui para uma experiência de compra mais satisfatória e confiável, fatores essenciais para o sucesso do site de vendas.  

A API dos Correios também simplifica os processos logísticos para o Magnífico Ponto, automatizando o cálculo de custos de envio e agilizando o processo de despacho de produtos. Isso permite que a equipe de operações gerencie os pedidos de forma mais eficiente, reduzindo erros e custos associados ao envio de mercadorias. 

  

<strong>Mercado Pago (método de pagamento):</strong> 

A integração do Mercado Pago no site de vendas Magnífico Ponto oferece uma solução abrangente para o processamento de pagamentos, proporcionando aos clientes uma variedade de opções seguras e eficientes para concluir suas compras. Ao oferecer métodos de pagamento como cartão de crédito e PIX, o Magnífico Ponto atende às preferências dos clientes, oferecendo conveniência e flexibilidade no momento do pagamento.  

Além de simplificar o processo de pagamento para os clientes, a integração com o Mercado Pago também oferece benefícios significativos para o Magnífico Ponto. Como uma plataforma de comércio eletrônico estabelecida e confiável, o Mercado Pago proporciona segurança e confiança tanto para os vendedores quanto para os compradores no momento de efetuar o pagamento online. <br>
<br>

Em resumo, essas tecnologias foram escolhidas com base em sua robustez, escalabilidade, facilidade de uso e capacidade de fornecer uma experiência de usuário de alta qualidade no site de vendas. Além disso, as integrações com APIs externas adicionam funcionalidades importantes que melhoram a conveniência e a confiabilidade para os usuários finais. <br>
<br>


![Diagrama_Arquitetura_MagnificoPonto](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/assets/103782980/f1e69163-6835-4915-8418-19013ea89cab)




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
![Diagrama de Casos de uso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/diagrama_casosdeusoMp.png)


## Modelo ER (Projeto Conceitual)
![Modelo ER](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/Diagrama_ER_MagnificoPonto.png)


## Projeto da Base de Dados

![Projeto BD 1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/projetobdtabela1.png)
![Projeto BD 2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/projetobdtabela2.png)
