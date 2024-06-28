# Implantação do Software


A aplicação interativa Magnífico Ponto foi hospedada em [smarterasp.net](https://www.smarterasp.net/) com banco de dados SQLite. 

Para ter acesso a aplicação desenvolvida [clique aqui](https://magnificopto-001-site1.ctempurl.com/)


## Tecnologias Utilizadas

* ### Frontend:

#### HTML/CSS/Javascript: 
Essas tecnologias, conhecidas como o trio fundamental do desenvolvimento web, desempenham papéis cruciais na construção de um site de vendas eficaz. 
O HTML (HyperText Markup Language) oferece a estrutura básica e a semântica necessária para organizar e apresentar o conteúdo da página. Com sua ampla compatibilidade com navegadores, o HTML é a base sobre a qual toda a experiência do usuário é construída.
 
O CSS (Cascading Style Sheets) é responsável por estilizar o conteúdo HTML, tornando-o visualmente atraente e consistente em diferentes dispositivos e tamanhos de tela. Através do CSS, é possível controlar a aparência de elementos individuais, criar layouts responsivos e garantir uma experiência visualmente agradável para os usuários. 
O Javascript, por sua vez, é a linguagem de programação que adiciona interatividade e dinamismo ao site. Com o Javascript, é possível criar animações, validar formulários, carregar conteúdo dinamicamente e interagir com o usuário em tempo real. Sua versatilidade e poder é essencial para proporcionar uma experiência de usuário rica e envolvente em um site de vendas. 

BOOTSTRAP: 
O Bootstrap foi escolhido por ser um framework web frontend amplamente adotado devido à sua facilidade de uso e à vasta gama de componentes pré-projetados que oferece. Alguns dos pontos fortes na utilização Bootstrap, é a economia de tempo e esforço na criação de layouts responsivos e visualmente atraentes. 
Uma das principais vantagens do Bootstrap é sua grade responsiva, que permite que o layout se adapte automaticamente a diferentes tamanhos de tela, desde dispositivos móveis até desktops, facilitando o acesso ao site da loja Magnifico Ponto em diferentes tipos de dispositivos. Além disso, o Bootstrap oferece uma variedade de componentes, como botões, formulários, barras de navegação e modais, que podem ser facilmente personalizados e integrados ao design do site de vendas. 
Outro ponto forte do Bootstrap é sua extensa documentação e comunidade de desenvolvedores ativa, que fornecem suporte e recursos adicionais para facilitar o desenvolvimento. Isso faz do Bootstrap uma escolha sólida para criar uma interface do usuário consistente e profissional, garantindo uma experiência positiva para os usuários do site de vendas Magnífico Ponto. 


* ### Backend:
  
ASP.NET MVC: A equipe optou pelo ASP.NET MVC devido à sua robustez e escalabilidade. Esta escolha se deve à arquitetura de software que separa claramente a lógica de negócios da interface do usuário, facilitando o desenvolvimento e a manutenção do código. Além disso, a ampla comunidade de desenvolvedores e o suporte da Microsoft garantem atualizações regulares e segurança.
  
Entity Framework: O Entity Framework foi escolhido como ORM (Object-Relational Mapping) para facilitar a manipulação dos dados do banco de dados. Com o EF, é possível mapear objetos do modelo de domínio diretamente para tabelas de banco de dados, simplificando operações de CRUD (Create, Read, Update, Delete) e garantindo um código mais limpo e legível. 

SQL Server: Para o banco de dados, foi selecionado o SQL Server devido à sua confiabilidade, desempenho e recursos avançados de segurança. Sua integração com o ambiente .NET é excelente, simplificando o desenvolvimento e garantindo a integridade dos dados. 

ASP.NET Identity: O ASP.NET Identity foi adotado para gerenciamento de identidade, autenticação e autorização de usuários. Ele oferece recursos robustos para lidar com o login, registro, recuperação de senha e gerenciamento de perfis de usuários de forma segura, além de ser altamente personalizável. 



* ### Serviços de Terceiros:
  
API para cálculo de entregas (Melhor Envio)

A integração da API do Melhor Envio desempenha um papel crucial no aprimoramento da experiência do usuário no site de vendas Magnífico Ponto. Ao calcular os custos de frete com base no endereço do cliente, esta API fornece uma estimativa precisa dos custos de envio, permitindo que os clientes tenham uma visão clara dos custos totais antes de finalizar a compra.
Além de oferecer uma estimativa de frete precisa, a integração com a API do Melhor Envio também proporciona benefícios adicionais, como a rastreabilidade dos pedidos. Os clientes podem acompanhar o status de entrega de seus produtos, aumentando a confiança e a satisfação do cliente, o que contribui para uma experiência de compra mais satisfatória e confiável.
A API do Melhor Envio também simplifica os processos logísticos para o Magnífico Ponto, automatizando o cálculo de custos de envio e agilizando o processo de despacho de produtos. Isso permite que a equipe de operações gerencie os pedidos de forma mais eficiente, reduzindo erros e custos associados ao envio de mercadorias.

API para pagamentos (Stripe) 

A integração do Stripe no site de vendas Magnífico Ponto oferece uma solução abrangente para o processamento de pagamentos, proporcionando aos clientes uma variedade de opções seguras e eficientes para concluir suas compras. Ao oferecer métodos de pagamento como cartão de crédito e PIX, o Magnífico Ponto atende às preferências dos clientes, oferecendo conveniência e flexibilidade no momento do pagamento. 
Além de simplificar o processo de pagamento para os clientes, a integração com o Stripe também oferece benefícios significativos para o Magnífico Ponto. Como uma plataforma de comércio eletrônico estabelecida e confiável, o Stripe proporciona segurança e confiança tanto para os vendedores quanto para os compradores no momento de efetuar o pagamento online. 
Em resumo, essas tecnologias foram escolhidas com base em sua robustez, escalabilidade, facilidade de uso e capacidade de fornecer uma experiência de usuário de alta qualidade no site de vendas. Além disso, as integrações com APIs externas adicionam funcionalidades importantes que melhoram a conveniência e a confiabilidade para os usuários finais.



* ### Processo de implantação

A escolha do servidor SmarterAsp.net para o website de vendas criado para loja Magnífico Ponto foi motivada por várias vantagens, especialmente no que se refere ao custo-benefício e à flexibilidade para ajustes e melhorias. 

A plataforma SmarterAsp.net oferece um período de 60 dias de armazenamento gratuito, permitindo que a equipe de desenvolvimento, juntamente com loja Magnífico Ponto possam testar a viabilidade e o desempenho da aplicação sem custos iniciais. Este período é crucial para identificar e corrigir problemas, implementar melhorias e garantir que o site atenda às expectativas antes de se comprometer financeiramente. Comparada a outras plataformas, a SmarterAsp.net apresenta um custo-benefício atraente, com planos acessíveis após o período gratuito. A plataforma é conhecida por sua interface amigável e facilidade de configuração, o que permite à equipe de desenvolvimento configurar o ambiente de hospedagem de forma rápida e eficiente. 

O desempenho e a confiabilidade da SmarterAsp.net garantem que o site de vendas funcione de maneira rápida e estável, um fator crítico para um site de comércio eletrônico. A escalabilidade oferecida permite que a Magnífico Ponto tenha os ajustes dos recursos conforme necessário, lidando com picos de tráfego durante promoções ou feriados sem comprometer a experiência do usuário. A segurança robusta é outra vantagem, protegendo dados sensíveis dos clientes, como informações de pagamento. Além disso, o suporte técnico eficiente da SmarterAsp.net proporciona assistência rápida em caso de problemas técnicos, garantindo operação contínua do site. 

Em suma, a SmarterAsp.net foi escolhida pela combinação de período gratuito, custo acessível, facilidade de uso, desempenho confiável, escalabilidade, segurança robusta e suporte técnico eficiente, assegurando uma experiência de compra online conveniente, segura e satisfatória para os clientes do Magnífico Ponto.


