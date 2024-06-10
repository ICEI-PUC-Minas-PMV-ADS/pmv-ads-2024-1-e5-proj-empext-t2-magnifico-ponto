# Planos de Testes de Software

|Caso de Teste|CT-001|
|-|-|
|Requisitos que motivaram o teste: |**RF-001:**  A plataforma deve possuir uma página de login com usuário e senha.
|Objetivo do teste:| Averiguar funcionamento do cadastro ao popular banco de dados.|
|Condição para aprovado: | Login e senha cadastrados no banco de dados a partir da página de login.|
|Resultado:| Login e senha de novo usuário inserido no banco de dados.|
|Observação: ||	

|Caso de Teste|CT-002|
|-|-|
|Requisitos que motivaram o teste:| **RF-001:**  A plataforma fornecerá a funcionalidade para autenticação do usuário|
|Objetivo do teste:| Averiguar que pessoas autorizadas tenham acesso ao sistema.|
|Condição para aprovado:|Inseridos usuário e senha, o login deve ser feito.|
|Resultado:| Bloqueio/liberação do sistema após inserção de credenciais de acesso.|
|Observação: ||	

|Caso de Teste|CT-003|
|-|-|
|Requisitos que motivaram o teste:|**RF-001:** A plataforma fornecerá a funcionalidade para autenticação do usuário|
|Objetivo do teste: | Averiguar que somente pessoas autorizadas tenham acesso ao sistema|
|Condição para aprovado:| Inseridos usuário e senha errados, o usuário não deve acessar o sistema|
|Resultado:| Bloqueio de credenciais não cadastrados.|
|Observação: ||

|Caso de Teste|CT-004|
|-|-|
|Requisitos que motivaram o teste:|**RF-011:** Garantir que a plataforma seja adaptável a diferentes tamanhos de tela, proporcionando uma experiência consistente em dispositivos móveis. |
|Objetivo do teste: | Todas as funcionalidades descritas no backlog funcionam em Android e iOS.|
|Condição para aprovado:|Um usuário realizará todos os casos de teste descritos para os requisitos funcionais de RF-001 a RF-015 ao menos uma vez a partir de um aparelho iOS e um aparelho Android e todos devem ser aprovados. |
|Resultado:| Aplicativo funcional nas plataformas Android e IOS|
|Observação: ||

|Caso de Teste|CT-005|
|-|-|
|Requisitos que motivaram o teste:|**RF-010:** Manter um controle preciso do estoque para evitar vendas de produtos esgotados e otimizar a logística de reposição. |
|Objetivo do teste: |Efetuar o cadastro de um produto e adiciona-lo ao banco de dados |
|Condição para aprovado:| Produto devidamente cadastrado e presente no banco de dados|
|Resultado:| Produto cadastrado com sucesso|
|Observação: ||

|Caso de Teste|CT-006|
|-|-|
|Requisitos que motivaram o teste:|**RF-010:** Manter um controle preciso do estoque para evitar vendas de produtos esgotados e otimizar a logística de reposição. |
|Objetivo do teste: |Efetuar a edição de um produto e atualizando as informações no banco de dados |
|Condição para aprovado:| Produto devidamente editado e atualizado no banco de dados|
|Resultado:| Produto editado com sucesso|
|Observação: ||

|Caso de Teste|CT-007|
|-|-|
|Requisitos que motivaram o teste:|**RF-010:** Manter um controle preciso do estoque para evitar vendas de produtos esgotados e otimizar a logística de reposição. |
|Objetivo do teste: |Efetuar a exclusão de um produto e apagando as informações no banco de dados |
|Condição para aprovado:| Produto devidamente excluído e atualizado no banco de dados|
|Resultado:| Produto editado com sucesso|
|Observação: ||

|Caso de Teste|CT-008|
|-|-|
|Requisitos que motivaram o teste:|**RF-009:** Suporte ao Cliente  |
|Objetivo do teste: | Disponibilizar um canal de suporte eficiente, ou seja, e-mail ou telefone, para esclarecimento de dúvidas e resolução de problemas. |
|Condição para aprovado:| Registro das mensagens enviadas pelo usuário na página listagem de mensagens do administrador. |
|Resultado:| Mensagem armazenada no banco de dados. |
|Observação: ||

|Caso de Teste|CT-009|
|-|-|
|Requisitos que motivaram o teste:|**RNF-05:** Navegação Intuitiva  |
|Objetivo do teste: | Proporcionar uma experiência de usuário intuitiva e fácil de navegar, com uma estrutura de menu lógica e botões claros, para facilitar a busca e a compra de produtos. |
|Condição para aprovado:| Renderização de campos com instruções de preenchimento.|
|Resultado:| Aprovado e renderizado com sucesso. |
|Observação: ||

|Caso de Teste|CT-010|
|-|-|
|Requisitos que motivaram o teste:|**RNF-09:** Experiência do Usuário (UX)  |
|Objetivo do teste: | Garantir uma interface de usuário intuitiva, agradável e de fácil compreensão, promovendo uma experiência positiva e incentivando a interação contínua. |
|Condição para aprovado:| Fácil percepção dos dados a ser inserido. |
|Resultado:| Aprovado, após observado a percepção de dados inseridos no software. |
|Observação: ||

|Caso de Teste|CT-011|
|-|-|
|Requisitos que motivaram o teste:|**RNF-10:** Monitoramento e Análise   |
|Objetivo do teste: | Integrar ferramentas de monitoramento para coletar dados sobre o comportamento dos usuários, possibilitando análises que orientem melhorias na experiência do cliente e na eficácia das estratégias de venda. |
|Condição para aprovado:| Agrupamento de mensagens coordenadas por assuntos na página de listagem de mensagens do administrador.|
|Resultado:| Aprovado e mensagens registradas no banco de dados com sucesso. |
|Observação: ||

|Caso de Teste|CT-012|
|-|-|
|Requisitos que motivaram o teste:|**RF-04:** Finalização de Compra e Pagamento	Oferecer uma experiência simplificada para a conclusão da compra, integrando métodos de pagamento seguros e eficientes.   |
|Objetivo do teste: | Integrar ferramentas de pagamento que permita uso de cartão e pedido de reembolso |
|Condição para aprovado:| Aprovação de uma compra, e registro de extorno|
|Resultado:| Aprovado, a funcionalidade funcionou como esperado no teste |
|Observação: ||

|Caso de Teste|CT-013|
|-|-|
|Requisitos que motivaram o teste:|**RF-006:** Permitir que os usuários personalizem seus perfis, incluindo informações de endereço de entrega, histórico de pedidos e preferências de comunicação.|
|Objetivo do teste: |Efetuar a edição do usuário e atualizando as informações no banco de dados |
|Condição para aprovado:| Usuário devidamente editado e atualizado no banco de dados|
|Resultado:| Usuário editado com sucesso|
|Observação: ||

|Caso de Teste|CT-014|
|-|-|
|Requisitos que motivaram o teste:|**RF-016:**  Permitir o cliente insira o CEP e escolha a melhor opção de envio|
|Objetivo do teste: |Inserir o CEP e ter as opções de frete calculadas adequadamente, poder selecionar o frete desejado |
|Condição para aprovado:| Inserção e registro do CEP, Cálculo adequado do frete, seleção do frete desejado|
|Resultado:| Aprovado, a funcionalidade funcionou como esperado|
|Observação: ||

|Caso de Teste|CT-015|
|-|-|
|Requisitos que motivaram o teste:|**RF-015:** Permitir que as cores e acessórios sejam personalizados, de acordo com o amigurumi. Pode ser feito por meio de seleção ou de envio de mensagem junto com o pedido|
|Objetivo do teste: | Personalização dos amigurumis. |
|Condição para aprovado:| Salvamento no banco de dados|
|Resultado:| Aprovado, a funcionalidade funcionou como esperado|
|Observação: ||
# Evidências de Testes de Software

## Evidência de Caso de Teste CT-001
Podemos visualizar um usuário inserindo os dados para realizar o cadastro
![Imagem cadastro](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/InserindoRegistro.JPG)
Após a inserção dos dados, os mesmos sao inseridos no banco de dados
![Imagem BD](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/banco%20de%20dados%20login.jpg)
## Evidência de Caso de Teste CT-002
Ao inserir os dados corretamentes o usuário poderá entrar na pagina inicial do site
![Login](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/Fazendo%20Login.JPG)
![AutenticacaoHome](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/Usuario%20Logado.JPG)
## Evidência de Caso de Teste CT-003
Caso o usuário insira os dados incorretamente ou não insira os dados não poderá ser redirecionado para a Home
![Validação](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/Validação%20de%20inputs%20Login.JPG)
## Evidência de Caso de Teste CT-004

Responsividade da página index / home (página principal da aplicação)

![Responsividade da página Index](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/d3e72c0727efbef3a5ef634de40a3e4893c6ca99/documentos/Testes/Index.gif)

Responsividade da página about que fornece informações sobre as artesãs e mais informações sobre a loja

![Responsividade da página About](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/d3e72c0727efbef3a5ef634de40a3e4893c6ca99/documentos/Testes/mobile.gif)

Responsividade da página faq que contém as 10 perguntas mais frequêntes sobre a loja

![Responsividade da página faq](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/d3e72c0727efbef3a5ef634de40a3e4893c6ca99/documentos/Testes/faq.gif)

Responsividade da página contact, com a qual é possível enviar e-mail e consultar dados de contato da loja

![Responsividade da página Contact](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/d3e72c0727efbef3a5ef634de40a3e4893c6ca99/documentos/Testes/about.gif)

## Evidência de Caso de Teste CT-005
O admin deve conseguir realizar o cadastro de produtos

![1 - Itens cadastrados antes](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/teste5-1.JPG)
1 - Itens cadastrados antes

![2 - Cadastro de itens](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/teste5-2.JPG)
2 - Cadastro de itens

![3 - Cadastro de itens](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/teste5-3.JPG)
3 - Cadastro de itens

![4 - Itens cadastrados depois](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/teste5-4.JPG)
4 - Itens cadastrados depois

![5 - Itens cadastrados na galeria de produtos](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/teste5-5.JPG)
5 - Itens cadastrados na galeria de produtos

![6 - Itens cadastrados BD 1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/teste5-6.JPG)
6 - Itens cadastrados BD

## Evidência de Caso de Teste CT-006
O admin deve conseguir editar informações do produto

![EditarProduto](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/Editar%20Item.JPG)
![EditarProdutoBD](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/Index%20Editado.JPG)
![EditarDetalhes](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/Detalhes.JPG)

## Evidência de Caso de Teste CT-007
O admin deve conseguir apagar um produto

![ApagarProduto](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/Apagar%20Item.JPG)
![ApagarProdutoBD](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/main/documentos/img/Index%20Apagar.JPG)

## Evidência de Caso de Teste CT-008, CT-009 e CT-010.<br/>
Registra na página de mensagem, Aceitação de dados inseridas pelo usuário e Experiência do Usuário (UX).

![1  Página de contato direto](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/assets/102244252/8c65cebb-b6a3-49e1-93db-7aa9c38c53b9)
![2  Teste de envio de mensagem](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/assets/102244252/fde35f81-d29f-4d68-8957-e913a322065c)

## Evidência de Caso de Teste CT-011
Agrupamento de mensagens coordenadas por assuntos

![3  Listagem de mensagens](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/assets/102244252/bee919d0-e9b2-4a46-8c46-9e28ead3fce2)
![4  Visualização da mensagem](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/assets/102244252/d6a1faab-910d-49e9-8ac6-505efa850055)
![5  Mensagens cadastradas no banco de dados](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/assets/102244252/888cdc69-5285-4e66-bbd6-1a998d185f6f)

Apagando última mensagem na página de listagem de mensagens do administrador. Posteriormente ação de deleção foi replicada nos registros do banco de dados.
  
![6  Mensagem apagada da listagem](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/assets/102244252/b03b1826-82a4-4978-a57e-9bd2e046dab4)
![7  Mensagem apagada do banco de dados](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/assets/102244252/0ebc7ee4-d770-4c97-8ff4-f74e359fdcae)

## Evidência de Caso de Teste CT-012
Vídeo com o funcionamento adequado da funcionalidade tal como desenvolvida.

![Pagamento](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/feee3183ef5c9bd4d9c79549e6e912913b4aa641/documentos/Testes/Pagamento_GIF.gif)

## Evidência de Caso de Teste CT-013
Evidências sobre Formulário Crud Dados de entrega do usuário. Imagens do Banco de dados funcionando normalmente. 
![4 - Dados no BD](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/assets/102244252/8eed2750-8854-4d6a-af56-50a87f454e65)
![3 - Dados registrado no site](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/assets/102244252/70e3e3b0-c1cb-42ee-abd4-bf2c7b6a249d)
![2 - Inserindo Dados](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/assets/102244252/95801b80-58e3-4b06-a2cd-3271c3d28ed0)
![1- Formulario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/assets/102244252/7df90e86-0ed5-4e94-84bd-96cfbf4316ae)


## Evidência de Caso de Teste CT-014
Vídeo com o funcionamento adequado da funcionalidade tal como desenvolvida.

![Envio](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-magnifico-ponto/blob/b0b7213275d62e78ea990ae77af32a3828aaf5d0/documentos/Testes/Envio_Teste_GIF.gif)


